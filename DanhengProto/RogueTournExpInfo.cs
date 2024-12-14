using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FB1 RID: 4017
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournExpInfo : IMessage<RogueTournExpInfo>, IMessage, IEquatable<RogueTournExpInfo>, IDeepCloneable<RogueTournExpInfo>, IBufferMessage
	{
		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600B300 RID: 45824 RVA: 0x001E0EC0 File Offset: 0x001DF0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournExpInfo> Parser
		{
			get
			{
				return RogueTournExpInfo._parser;
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600B301 RID: 45825 RVA: 0x001E0EC7 File Offset: 0x001DF0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournExpInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600B302 RID: 45826 RVA: 0x001E0ED9 File Offset: 0x001DF0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournExpInfo.Descriptor;
			}
		}

		// Token: 0x0600B303 RID: 45827 RVA: 0x001E0EE0 File Offset: 0x001DF0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournExpInfo()
		{
		}

		// Token: 0x0600B304 RID: 45828 RVA: 0x001E0EF3 File Offset: 0x001DF0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournExpInfo(RogueTournExpInfo other) : this()
		{
			this.exp_ = other.exp_;
			this.takenLevelRewards_ = other.takenLevelRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B305 RID: 45829 RVA: 0x001E0F29 File Offset: 0x001DF129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournExpInfo Clone()
		{
			return new RogueTournExpInfo(this);
		}

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600B306 RID: 45830 RVA: 0x001E0F31 File Offset: 0x001DF131
		// (set) Token: 0x0600B307 RID: 45831 RVA: 0x001E0F39 File Offset: 0x001DF139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600B308 RID: 45832 RVA: 0x001E0F42 File Offset: 0x001DF142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TakenLevelRewards
		{
			get
			{
				return this.takenLevelRewards_;
			}
		}

		// Token: 0x0600B309 RID: 45833 RVA: 0x001E0F4A File Offset: 0x001DF14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournExpInfo);
		}

		// Token: 0x0600B30A RID: 45834 RVA: 0x001E0F58 File Offset: 0x001DF158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournExpInfo other)
		{
			return other != null && (other == this || (this.Exp == other.Exp && this.takenLevelRewards_.Equals(other.takenLevelRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B30B RID: 45835 RVA: 0x001E0FA8 File Offset: 0x001DF1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			num ^= this.takenLevelRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B30C RID: 45836 RVA: 0x001E0FF5 File Offset: 0x001DF1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B30D RID: 45837 RVA: 0x001E0FFD File Offset: 0x001DF1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B30E RID: 45838 RVA: 0x001E1008 File Offset: 0x001DF208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.takenLevelRewards_.WriteTo(ref output, RogueTournExpInfo._repeated_takenLevelRewards_codec);
			if (this.Exp != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Exp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B30F RID: 45839 RVA: 0x001E1058 File Offset: 0x001DF258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			num += this.takenLevelRewards_.CalculateSize(RogueTournExpInfo._repeated_takenLevelRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B310 RID: 45840 RVA: 0x001E10AC File Offset: 0x001DF2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournExpInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			this.takenLevelRewards_.Add(other.takenLevelRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x001E10F9 File Offset: 0x001DF2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x001E1104 File Offset: 0x001DF304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U && num != 34U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Exp = input.ReadUInt32();
					}
				}
				else
				{
					this.takenLevelRewards_.AddEntriesFrom(ref input, RogueTournExpInfo._repeated_takenLevelRewards_codec);
				}
			}
		}

		// Token: 0x040048B5 RID: 18613
		private static readonly MessageParser<RogueTournExpInfo> _parser = new MessageParser<RogueTournExpInfo>(() => new RogueTournExpInfo());

		// Token: 0x040048B6 RID: 18614
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048B7 RID: 18615
		public const int ExpFieldNumber = 13;

		// Token: 0x040048B8 RID: 18616
		private uint exp_;

		// Token: 0x040048B9 RID: 18617
		public const int TakenLevelRewardsFieldNumber = 4;

		// Token: 0x040048BA RID: 18618
		private static readonly FieldCodec<uint> _repeated_takenLevelRewards_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040048BB RID: 18619
		private readonly RepeatedField<uint> takenLevelRewards_ = new RepeatedField<uint>();
	}
}
