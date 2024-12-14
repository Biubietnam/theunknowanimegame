using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BFF RID: 3071
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NBAPLJDBOCB : IMessage<NBAPLJDBOCB>, IMessage, IEquatable<NBAPLJDBOCB>, IDeepCloneable<NBAPLJDBOCB>, IBufferMessage
	{
		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x060087F4 RID: 34804 RVA: 0x0016706B File Offset: 0x0016526B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NBAPLJDBOCB> Parser
		{
			get
			{
				return NBAPLJDBOCB._parser;
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x060087F5 RID: 34805 RVA: 0x00167072 File Offset: 0x00165272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NBAPLJDBOCBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x060087F6 RID: 34806 RVA: 0x00167084 File Offset: 0x00165284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NBAPLJDBOCB.Descriptor;
			}
		}

		// Token: 0x060087F7 RID: 34807 RVA: 0x0016708B File Offset: 0x0016528B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBAPLJDBOCB()
		{
		}

		// Token: 0x060087F8 RID: 34808 RVA: 0x001670AC File Offset: 0x001652AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBAPLJDBOCB(NBAPLJDBOCB other) : this()
		{
			this.itemValue_ = other.itemValue_;
			this.miracleList_ = other.miracleList_.Clone();
			this.buffList_ = other.buffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087F9 RID: 34809 RVA: 0x001670FE File Offset: 0x001652FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBAPLJDBOCB Clone()
		{
			return new NBAPLJDBOCB(this);
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x060087FA RID: 34810 RVA: 0x00167106 File Offset: 0x00165306
		// (set) Token: 0x060087FB RID: 34811 RVA: 0x0016710E File Offset: 0x0016530E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemValue
		{
			get
			{
				return this.itemValue_;
			}
			set
			{
				this.itemValue_ = value;
			}
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x060087FC RID: 34812 RVA: 0x00167117 File Offset: 0x00165317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameRogueMiracle> MiracleList
		{
			get
			{
				return this.miracleList_;
			}
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x060087FD RID: 34813 RVA: 0x0016711F File Offset: 0x0016531F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonBuff> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x00167127 File Offset: 0x00165327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NBAPLJDBOCB);
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x00167138 File Offset: 0x00165338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NBAPLJDBOCB other)
		{
			return other != null && (other == this || (this.ItemValue == other.ItemValue && this.miracleList_.Equals(other.miracleList_) && this.buffList_.Equals(other.buffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x0016719C File Offset: 0x0016539C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemValue != 0U)
			{
				num ^= this.ItemValue.GetHashCode();
			}
			num ^= this.miracleList_.GetHashCode();
			num ^= this.buffList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008801 RID: 34817 RVA: 0x001671F7 File Offset: 0x001653F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x001671FF File Offset: 0x001653FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008803 RID: 34819 RVA: 0x00167208 File Offset: 0x00165408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffList_.WriteTo(ref output, NBAPLJDBOCB._repeated_buffList_codec);
			this.miracleList_.WriteTo(ref output, NBAPLJDBOCB._repeated_miracleList_codec);
			if (this.ItemValue != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ItemValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x00167268 File Offset: 0x00165468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemValue);
			}
			num += this.miracleList_.CalculateSize(NBAPLJDBOCB._repeated_miracleList_codec);
			num += this.buffList_.CalculateSize(NBAPLJDBOCB._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008805 RID: 34821 RVA: 0x001672CC File Offset: 0x001654CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NBAPLJDBOCB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemValue != 0U)
			{
				this.ItemValue = other.ItemValue;
			}
			this.miracleList_.Add(other.miracleList_);
			this.buffList_.Add(other.buffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x0016732A File Offset: 0x0016552A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x00167334 File Offset: 0x00165534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 58U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemValue = input.ReadUInt32();
						}
					}
					else
					{
						this.miracleList_.AddEntriesFrom(ref input, NBAPLJDBOCB._repeated_miracleList_codec);
					}
				}
				else
				{
					this.buffList_.AddEntriesFrom(ref input, NBAPLJDBOCB._repeated_buffList_codec);
				}
			}
		}

		// Token: 0x04003424 RID: 13348
		private static readonly MessageParser<NBAPLJDBOCB> _parser = new MessageParser<NBAPLJDBOCB>(() => new NBAPLJDBOCB());

		// Token: 0x04003425 RID: 13349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003426 RID: 13350
		public const int ItemValueFieldNumber = 10;

		// Token: 0x04003427 RID: 13351
		private uint itemValue_;

		// Token: 0x04003428 RID: 13352
		public const int MiracleListFieldNumber = 7;

		// Token: 0x04003429 RID: 13353
		private static readonly FieldCodec<GameRogueMiracle> _repeated_miracleList_codec = FieldCodec.ForMessage<GameRogueMiracle>(58U, GameRogueMiracle.Parser);

		// Token: 0x0400342A RID: 13354
		private readonly RepeatedField<GameRogueMiracle> miracleList_ = new RepeatedField<GameRogueMiracle>();

		// Token: 0x0400342B RID: 13355
		public const int BuffListFieldNumber = 3;

		// Token: 0x0400342C RID: 13356
		private static readonly FieldCodec<RogueCommonBuff> _repeated_buffList_codec = FieldCodec.ForMessage<RogueCommonBuff>(26U, RogueCommonBuff.Parser);

		// Token: 0x0400342D RID: 13357
		private readonly RepeatedField<RogueCommonBuff> buffList_ = new RepeatedField<RogueCommonBuff>();
	}
}
