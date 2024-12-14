using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000477 RID: 1143
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterTelevisionActivityStageCsReq : IMessage<EnterTelevisionActivityStageCsReq>, IMessage, IEquatable<EnterTelevisionActivityStageCsReq>, IDeepCloneable<EnterTelevisionActivityStageCsReq>, IBufferMessage
	{
		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x060032E8 RID: 13032 RVA: 0x0008C06B File Offset: 0x0008A26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterTelevisionActivityStageCsReq> Parser
		{
			get
			{
				return EnterTelevisionActivityStageCsReq._parser;
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x060032E9 RID: 13033 RVA: 0x0008C072 File Offset: 0x0008A272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterTelevisionActivityStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x0008C084 File Offset: 0x0008A284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterTelevisionActivityStageCsReq.Descriptor;
			}
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x0008C08B File Offset: 0x0008A28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTelevisionActivityStageCsReq()
		{
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x0008C0AC File Offset: 0x0008A2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTelevisionActivityStageCsReq(EnterTelevisionActivityStageCsReq other) : this()
		{
			this.dNFJOOAJIKG_ = other.dNFJOOAJIKG_;
			this.buffList_ = other.buffList_.Clone();
			this.avatarList_ = other.avatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x0008C0FE File Offset: 0x0008A2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTelevisionActivityStageCsReq Clone()
		{
			return new EnterTelevisionActivityStageCsReq(this);
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x0008C106 File Offset: 0x0008A306
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x0008C10E File Offset: 0x0008A30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DNFJOOAJIKG
		{
			get
			{
				return this.dNFJOOAJIKG_;
			}
			set
			{
				this.dNFJOOAJIKG_ = value;
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x0008C117 File Offset: 0x0008A317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x060032F1 RID: 13041 RVA: 0x0008C11F File Offset: 0x0008A31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CDFOIPHMOJP> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x0008C127 File Offset: 0x0008A327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterTelevisionActivityStageCsReq);
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x0008C138 File Offset: 0x0008A338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterTelevisionActivityStageCsReq other)
		{
			return other != null && (other == this || (this.DNFJOOAJIKG == other.DNFJOOAJIKG && this.buffList_.Equals(other.buffList_) && this.avatarList_.Equals(other.avatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x0008C19C File Offset: 0x0008A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DNFJOOAJIKG != 0U)
			{
				num ^= this.DNFJOOAJIKG.GetHashCode();
			}
			num ^= this.buffList_.GetHashCode();
			num ^= this.avatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x0008C1F7 File Offset: 0x0008A3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x0008C1FF File Offset: 0x0008A3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x0008C208 File Offset: 0x0008A408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DNFJOOAJIKG != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.DNFJOOAJIKG);
			}
			this.buffList_.WriteTo(ref output, EnterTelevisionActivityStageCsReq._repeated_buffList_codec);
			this.avatarList_.WriteTo(ref output, EnterTelevisionActivityStageCsReq._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x0008C268 File Offset: 0x0008A468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DNFJOOAJIKG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DNFJOOAJIKG);
			}
			num += this.buffList_.CalculateSize(EnterTelevisionActivityStageCsReq._repeated_buffList_codec);
			num += this.avatarList_.CalculateSize(EnterTelevisionActivityStageCsReq._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x0008C2CC File Offset: 0x0008A4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterTelevisionActivityStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DNFJOOAJIKG != 0U)
			{
				this.DNFJOOAJIKG = other.DNFJOOAJIKG;
			}
			this.buffList_.Add(other.buffList_);
			this.avatarList_.Add(other.avatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x0008C32A File Offset: 0x0008A52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x0008C334 File Offset: 0x0008A534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.DNFJOOAJIKG = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						goto IL_3F;
					}
				}
				else
				{
					if (num == 34U)
					{
						goto IL_3F;
					}
					if (num == 58U)
					{
						this.avatarList_.AddEntriesFrom(ref input, EnterTelevisionActivityStageCsReq._repeated_avatarList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_3F:
				this.buffList_.AddEntriesFrom(ref input, EnterTelevisionActivityStageCsReq._repeated_buffList_codec);
			}
		}

		// Token: 0x04001442 RID: 5186
		private static readonly MessageParser<EnterTelevisionActivityStageCsReq> _parser = new MessageParser<EnterTelevisionActivityStageCsReq>(() => new EnterTelevisionActivityStageCsReq());

		// Token: 0x04001443 RID: 5187
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001444 RID: 5188
		public const int DNFJOOAJIKGFieldNumber = 3;

		// Token: 0x04001445 RID: 5189
		private uint dNFJOOAJIKG_;

		// Token: 0x04001446 RID: 5190
		public const int BuffListFieldNumber = 4;

		// Token: 0x04001447 RID: 5191
		private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04001448 RID: 5192
		private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();

		// Token: 0x04001449 RID: 5193
		public const int AvatarListFieldNumber = 7;

		// Token: 0x0400144A RID: 5194
		private static readonly FieldCodec<CDFOIPHMOJP> _repeated_avatarList_codec = FieldCodec.ForMessage<CDFOIPHMOJP>(58U, CDFOIPHMOJP.Parser);

		// Token: 0x0400144B RID: 5195
		private readonly RepeatedField<CDFOIPHMOJP> avatarList_ = new RepeatedField<CDFOIPHMOJP>();
	}
}
