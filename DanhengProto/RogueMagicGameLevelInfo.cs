using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ED5 RID: 3797
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGameLevelInfo : IMessage<RogueMagicGameLevelInfo>, IMessage, IEquatable<RogueMagicGameLevelInfo>, IDeepCloneable<RogueMagicGameLevelInfo>, IBufferMessage
	{
		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x0600A9B3 RID: 43443 RVA: 0x001C915C File Offset: 0x001C735C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGameLevelInfo> Parser
		{
			get
			{
				return RogueMagicGameLevelInfo._parser;
			}
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x0600A9B4 RID: 43444 RVA: 0x001C9163 File Offset: 0x001C7363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameLevelInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x0600A9B5 RID: 43445 RVA: 0x001C9175 File Offset: 0x001C7375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGameLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600A9B6 RID: 43446 RVA: 0x001C917C File Offset: 0x001C737C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameLevelInfo()
		{
		}

		// Token: 0x0600A9B7 RID: 43447 RVA: 0x001C9190 File Offset: 0x001C7390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameLevelInfo(RogueMagicGameLevelInfo other) : this()
		{
			this.reason_ = other.reason_;
			this.status_ = other.status_;
			this.lABGKMPMBED_ = other.lABGKMPMBED_;
			this.curLevelIndex_ = other.curLevelIndex_;
			this.extraRoundLimit_ = other.extraRoundLimit_;
			this.levelInfoList_ = other.levelInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9B8 RID: 43448 RVA: 0x001C9201 File Offset: 0x001C7401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameLevelInfo Clone()
		{
			return new RogueMagicGameLevelInfo(this);
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x0600A9B9 RID: 43449 RVA: 0x001C9209 File Offset: 0x001C7409
		// (set) Token: 0x0600A9BA RID: 43450 RVA: 0x001C9211 File Offset: 0x001C7411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSettleReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x0600A9BB RID: 43451 RVA: 0x001C921A File Offset: 0x001C741A
		// (set) Token: 0x0600A9BC RID: 43452 RVA: 0x001C9222 File Offset: 0x001C7422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLevelStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x0600A9BD RID: 43453 RVA: 0x001C922B File Offset: 0x001C742B
		// (set) Token: 0x0600A9BE RID: 43454 RVA: 0x001C9233 File Offset: 0x001C7433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LABGKMPMBED
		{
			get
			{
				return this.lABGKMPMBED_;
			}
			set
			{
				this.lABGKMPMBED_ = value;
			}
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x0600A9BF RID: 43455 RVA: 0x001C923C File Offset: 0x001C743C
		// (set) Token: 0x0600A9C0 RID: 43456 RVA: 0x001C9244 File Offset: 0x001C7444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurLevelIndex
		{
			get
			{
				return this.curLevelIndex_;
			}
			set
			{
				this.curLevelIndex_ = value;
			}
		}

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x0600A9C1 RID: 43457 RVA: 0x001C924D File Offset: 0x001C744D
		// (set) Token: 0x0600A9C2 RID: 43458 RVA: 0x001C9255 File Offset: 0x001C7455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ExtraRoundLimit
		{
			get
			{
				return this.extraRoundLimit_;
			}
			set
			{
				this.extraRoundLimit_ = value;
			}
		}

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x0600A9C3 RID: 43459 RVA: 0x001C925E File Offset: 0x001C745E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicLayerInfo> LevelInfoList
		{
			get
			{
				return this.levelInfoList_;
			}
		}

		// Token: 0x0600A9C4 RID: 43460 RVA: 0x001C9266 File Offset: 0x001C7466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGameLevelInfo);
		}

		// Token: 0x0600A9C5 RID: 43461 RVA: 0x001C9274 File Offset: 0x001C7474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGameLevelInfo other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.Status == other.Status && this.LABGKMPMBED == other.LABGKMPMBED && this.CurLevelIndex == other.CurLevelIndex && this.ExtraRoundLimit == other.ExtraRoundLimit && this.levelInfoList_.Equals(other.levelInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9C6 RID: 43462 RVA: 0x001C9304 File Offset: 0x001C7504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != RogueMagicSettleReason.None)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.Status != RogueMagicLevelStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.LABGKMPMBED != 0U)
			{
				num ^= this.LABGKMPMBED.GetHashCode();
			}
			if (this.CurLevelIndex != 0U)
			{
				num ^= this.CurLevelIndex.GetHashCode();
			}
			if (this.ExtraRoundLimit != 0U)
			{
				num ^= this.ExtraRoundLimit.GetHashCode();
			}
			num ^= this.levelInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A9C7 RID: 43463 RVA: 0x001C93C1 File Offset: 0x001C75C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A9C8 RID: 43464 RVA: 0x001C93C9 File Offset: 0x001C75C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9C9 RID: 43465 RVA: 0x001C93D4 File Offset: 0x001C75D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurLevelIndex != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CurLevelIndex);
			}
			if (this.Reason != RogueMagicSettleReason.None)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Reason);
			}
			if (this.ExtraRoundLimit != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ExtraRoundLimit);
			}
			this.levelInfoList_.WriteTo(ref output, RogueMagicGameLevelInfo._repeated_levelInfoList_codec);
			if (this.LABGKMPMBED != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.LABGKMPMBED);
			}
			if (this.Status != RogueMagicLevelStatus.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9CA RID: 43466 RVA: 0x001C9494 File Offset: 0x001C7694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != RogueMagicSettleReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.Status != RogueMagicLevelStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.LABGKMPMBED != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LABGKMPMBED);
			}
			if (this.CurLevelIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurLevelIndex);
			}
			if (this.ExtraRoundLimit != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExtraRoundLimit);
			}
			num += this.levelInfoList_.CalculateSize(RogueMagicGameLevelInfo._repeated_levelInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A9CB RID: 43467 RVA: 0x001C9548 File Offset: 0x001C7748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGameLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != RogueMagicSettleReason.None)
			{
				this.Reason = other.Reason;
			}
			if (other.Status != RogueMagicLevelStatus.None)
			{
				this.Status = other.Status;
			}
			if (other.LABGKMPMBED != 0U)
			{
				this.LABGKMPMBED = other.LABGKMPMBED;
			}
			if (other.CurLevelIndex != 0U)
			{
				this.CurLevelIndex = other.CurLevelIndex;
			}
			if (other.ExtraRoundLimit != 0U)
			{
				this.ExtraRoundLimit = other.ExtraRoundLimit;
			}
			this.levelInfoList_.Add(other.levelInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A9CC RID: 43468 RVA: 0x001C95E5 File Offset: 0x001C77E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9CD RID: 43469 RVA: 0x001C95F0 File Offset: 0x001C77F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.CurLevelIndex = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Reason = (RogueMagicSettleReason)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.ExtraRoundLimit = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.levelInfoList_.AddEntriesFrom(ref input, RogueMagicGameLevelInfo._repeated_levelInfoList_codec);
						continue;
					}
					if (num == 96U)
					{
						this.LABGKMPMBED = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Status = (RogueMagicLevelStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004544 RID: 17732
		private static readonly MessageParser<RogueMagicGameLevelInfo> _parser = new MessageParser<RogueMagicGameLevelInfo>(() => new RogueMagicGameLevelInfo());

		// Token: 0x04004545 RID: 17733
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004546 RID: 17734
		public const int ReasonFieldNumber = 2;

		// Token: 0x04004547 RID: 17735
		private RogueMagicSettleReason reason_;

		// Token: 0x04004548 RID: 17736
		public const int StatusFieldNumber = 15;

		// Token: 0x04004549 RID: 17737
		private RogueMagicLevelStatus status_;

		// Token: 0x0400454A RID: 17738
		public const int LABGKMPMBEDFieldNumber = 12;

		// Token: 0x0400454B RID: 17739
		private uint lABGKMPMBED_;

		// Token: 0x0400454C RID: 17740
		public const int CurLevelIndexFieldNumber = 1;

		// Token: 0x0400454D RID: 17741
		private uint curLevelIndex_;

		// Token: 0x0400454E RID: 17742
		public const int ExtraRoundLimitFieldNumber = 7;

		// Token: 0x0400454F RID: 17743
		private uint extraRoundLimit_;

		// Token: 0x04004550 RID: 17744
		public const int LevelInfoListFieldNumber = 8;

		// Token: 0x04004551 RID: 17745
		private static readonly FieldCodec<RogueMagicLayerInfo> _repeated_levelInfoList_codec = FieldCodec.ForMessage<RogueMagicLayerInfo>(66U, RogueMagicLayerInfo.Parser);

		// Token: 0x04004552 RID: 17746
		private readonly RepeatedField<RogueMagicLayerInfo> levelInfoList_ = new RepeatedField<RogueMagicLayerInfo>();
	}
}
