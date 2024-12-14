using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200046B RID: 1131
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterStrongChallengeActivityStageCsReq : IMessage<EnterStrongChallengeActivityStageCsReq>, IMessage, IEquatable<EnterStrongChallengeActivityStageCsReq>, IDeepCloneable<EnterStrongChallengeActivityStageCsReq>, IBufferMessage
	{
		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x0008A853 File Offset: 0x00088A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterStrongChallengeActivityStageCsReq> Parser
		{
			get
			{
				return EnterStrongChallengeActivityStageCsReq._parser;
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x0008A85A File Offset: 0x00088A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterStrongChallengeActivityStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x0008A86C File Offset: 0x00088A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterStrongChallengeActivityStageCsReq.Descriptor;
			}
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x0008A873 File Offset: 0x00088A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterStrongChallengeActivityStageCsReq()
		{
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x0008A894 File Offset: 0x00088A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterStrongChallengeActivityStageCsReq(EnterStrongChallengeActivityStageCsReq other) : this()
		{
			this.stageId_ = other.stageId_;
			this.buffList_ = other.buffList_.Clone();
			this.avatarList_ = other.avatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x0008A8E6 File Offset: 0x00088AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterStrongChallengeActivityStageCsReq Clone()
		{
			return new EnterStrongChallengeActivityStageCsReq(this);
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x0008A8EE File Offset: 0x00088AEE
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x0008A8F6 File Offset: 0x00088AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x0008A8FF File Offset: 0x00088AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06003262 RID: 12898 RVA: 0x0008A907 File Offset: 0x00088B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<StrongChallengeAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x0008A90F File Offset: 0x00088B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterStrongChallengeActivityStageCsReq);
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x0008A920 File Offset: 0x00088B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterStrongChallengeActivityStageCsReq other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && this.buffList_.Equals(other.buffList_) && this.avatarList_.Equals(other.avatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x0008A984 File Offset: 0x00088B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			num ^= this.buffList_.GetHashCode();
			num ^= this.avatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x0008A9DF File Offset: 0x00088BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x0008A9E7 File Offset: 0x00088BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x0008A9F0 File Offset: 0x00088BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarList_.WriteTo(ref output, EnterStrongChallengeActivityStageCsReq._repeated_avatarList_codec);
			this.buffList_.WriteTo(ref output, EnterStrongChallengeActivityStageCsReq._repeated_buffList_codec);
			if (this.StageId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x0008AA50 File Offset: 0x00088C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			num += this.buffList_.CalculateSize(EnterStrongChallengeActivityStageCsReq._repeated_buffList_codec);
			num += this.avatarList_.CalculateSize(EnterStrongChallengeActivityStageCsReq._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x0008AAB4 File Offset: 0x00088CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterStrongChallengeActivityStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			this.buffList_.Add(other.buffList_);
			this.avatarList_.Add(other.avatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x0008AB12 File Offset: 0x00088D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x0008AB1C File Offset: 0x00088D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.avatarList_.AddEntriesFrom(ref input, EnterStrongChallengeActivityStageCsReq._repeated_avatarList_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_44;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_44;
					}
					if (num == 112U)
					{
						this.StageId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_44:
				this.buffList_.AddEntriesFrom(ref input, EnterStrongChallengeActivityStageCsReq._repeated_buffList_codec);
			}
		}

		// Token: 0x0400140D RID: 5133
		private static readonly MessageParser<EnterStrongChallengeActivityStageCsReq> _parser = new MessageParser<EnterStrongChallengeActivityStageCsReq>(() => new EnterStrongChallengeActivityStageCsReq());

		// Token: 0x0400140E RID: 5134
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400140F RID: 5135
		public const int StageIdFieldNumber = 14;

		// Token: 0x04001410 RID: 5136
		private uint stageId_;

		// Token: 0x04001411 RID: 5137
		public const int BuffListFieldNumber = 2;

		// Token: 0x04001412 RID: 5138
		private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04001413 RID: 5139
		private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();

		// Token: 0x04001414 RID: 5140
		public const int AvatarListFieldNumber = 1;

		// Token: 0x04001415 RID: 5141
		private static readonly FieldCodec<StrongChallengeAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<StrongChallengeAvatar>(10U, StrongChallengeAvatar.Parser);

		// Token: 0x04001416 RID: 5142
		private readonly RepeatedField<StrongChallengeAvatar> avatarList_ = new RepeatedField<StrongChallengeAvatar>();
	}
}
