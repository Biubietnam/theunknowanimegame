using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EEF RID: 3823
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicLevelInfoUpdateScNotify : IMessage<RogueMagicLevelInfoUpdateScNotify>, IMessage, IEquatable<RogueMagicLevelInfoUpdateScNotify>, IDeepCloneable<RogueMagicLevelInfoUpdateScNotify>, IBufferMessage
	{
		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x0600AAD0 RID: 43728 RVA: 0x001CC28D File Offset: 0x001CA48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicLevelInfoUpdateScNotify> Parser
		{
			get
			{
				return RogueMagicLevelInfoUpdateScNotify._parser;
			}
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x0600AAD1 RID: 43729 RVA: 0x001CC294 File Offset: 0x001CA494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicLevelInfoUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x0600AAD2 RID: 43730 RVA: 0x001CC2A6 File Offset: 0x001CA4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicLevelInfoUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600AAD3 RID: 43731 RVA: 0x001CC2AD File Offset: 0x001CA4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLevelInfoUpdateScNotify()
		{
		}

		// Token: 0x0600AAD4 RID: 43732 RVA: 0x001CC2C0 File Offset: 0x001CA4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLevelInfoUpdateScNotify(RogueMagicLevelInfoUpdateScNotify other) : this()
		{
			this.reason_ = other.reason_;
			this.extraRoundLimit_ = other.extraRoundLimit_;
			this.status_ = other.status_;
			this.levelInfoList_ = other.levelInfoList_.Clone();
			this.lABGKMPMBED_ = other.lABGKMPMBED_;
			this.curLevelIndex_ = other.curLevelIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAD5 RID: 43733 RVA: 0x001CC331 File Offset: 0x001CA531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLevelInfoUpdateScNotify Clone()
		{
			return new RogueMagicLevelInfoUpdateScNotify(this);
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x0600AAD6 RID: 43734 RVA: 0x001CC339 File Offset: 0x001CA539
		// (set) Token: 0x0600AAD7 RID: 43735 RVA: 0x001CC341 File Offset: 0x001CA541
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

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x0600AAD8 RID: 43736 RVA: 0x001CC34A File Offset: 0x001CA54A
		// (set) Token: 0x0600AAD9 RID: 43737 RVA: 0x001CC352 File Offset: 0x001CA552
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

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x0600AADA RID: 43738 RVA: 0x001CC35B File Offset: 0x001CA55B
		// (set) Token: 0x0600AADB RID: 43739 RVA: 0x001CC363 File Offset: 0x001CA563
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

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x0600AADC RID: 43740 RVA: 0x001CC36C File Offset: 0x001CA56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicLayerInfo> LevelInfoList
		{
			get
			{
				return this.levelInfoList_;
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x0600AADD RID: 43741 RVA: 0x001CC374 File Offset: 0x001CA574
		// (set) Token: 0x0600AADE RID: 43742 RVA: 0x001CC37C File Offset: 0x001CA57C
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

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x0600AADF RID: 43743 RVA: 0x001CC385 File Offset: 0x001CA585
		// (set) Token: 0x0600AAE0 RID: 43744 RVA: 0x001CC38D File Offset: 0x001CA58D
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

		// Token: 0x0600AAE1 RID: 43745 RVA: 0x001CC396 File Offset: 0x001CA596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicLevelInfoUpdateScNotify);
		}

		// Token: 0x0600AAE2 RID: 43746 RVA: 0x001CC3A4 File Offset: 0x001CA5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicLevelInfoUpdateScNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.ExtraRoundLimit == other.ExtraRoundLimit && this.Status == other.Status && this.levelInfoList_.Equals(other.levelInfoList_) && this.LABGKMPMBED == other.LABGKMPMBED && this.CurLevelIndex == other.CurLevelIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AAE3 RID: 43747 RVA: 0x001CC434 File Offset: 0x001CA634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != RogueMagicSettleReason.None)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.ExtraRoundLimit != 0U)
			{
				num ^= this.ExtraRoundLimit.GetHashCode();
			}
			if (this.Status != RogueMagicLevelStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			num ^= this.levelInfoList_.GetHashCode();
			if (this.LABGKMPMBED != 0U)
			{
				num ^= this.LABGKMPMBED.GetHashCode();
			}
			if (this.CurLevelIndex != 0U)
			{
				num ^= this.CurLevelIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AAE4 RID: 43748 RVA: 0x001CC4F1 File Offset: 0x001CA6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AAE5 RID: 43749 RVA: 0x001CC4F9 File Offset: 0x001CA6F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAE6 RID: 43750 RVA: 0x001CC504 File Offset: 0x001CA704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != RogueMagicSettleReason.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Reason);
			}
			if (this.CurLevelIndex != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CurLevelIndex);
			}
			this.levelInfoList_.WriteTo(ref output, RogueMagicLevelInfoUpdateScNotify._repeated_levelInfoList_codec);
			if (this.LABGKMPMBED != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.LABGKMPMBED);
			}
			if (this.ExtraRoundLimit != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ExtraRoundLimit);
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

		// Token: 0x0600AAE7 RID: 43751 RVA: 0x001CC5C4 File Offset: 0x001CA7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != RogueMagicSettleReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.ExtraRoundLimit != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExtraRoundLimit);
			}
			if (this.Status != RogueMagicLevelStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			num += this.levelInfoList_.CalculateSize(RogueMagicLevelInfoUpdateScNotify._repeated_levelInfoList_codec);
			if (this.LABGKMPMBED != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LABGKMPMBED);
			}
			if (this.CurLevelIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurLevelIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x001CC678 File Offset: 0x001CA878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicLevelInfoUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != RogueMagicSettleReason.None)
			{
				this.Reason = other.Reason;
			}
			if (other.ExtraRoundLimit != 0U)
			{
				this.ExtraRoundLimit = other.ExtraRoundLimit;
			}
			if (other.Status != RogueMagicLevelStatus.None)
			{
				this.Status = other.Status;
			}
			this.levelInfoList_.Add(other.levelInfoList_);
			if (other.LABGKMPMBED != 0U)
			{
				this.LABGKMPMBED = other.LABGKMPMBED;
			}
			if (other.CurLevelIndex != 0U)
			{
				this.CurLevelIndex = other.CurLevelIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x001CC715 File Offset: 0x001CA915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x001CC720 File Offset: 0x001CA920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.Reason = (RogueMagicSettleReason)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.CurLevelIndex = input.ReadUInt32();
						continue;
					}
					if (num == 26U)
					{
						this.levelInfoList_.AddEntriesFrom(ref input, RogueMagicLevelInfoUpdateScNotify._repeated_levelInfoList_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.LABGKMPMBED = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ExtraRoundLimit = input.ReadUInt32();
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

		// Token: 0x040045B6 RID: 17846
		private static readonly MessageParser<RogueMagicLevelInfoUpdateScNotify> _parser = new MessageParser<RogueMagicLevelInfoUpdateScNotify>(() => new RogueMagicLevelInfoUpdateScNotify());

		// Token: 0x040045B7 RID: 17847
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045B8 RID: 17848
		public const int ReasonFieldNumber = 1;

		// Token: 0x040045B9 RID: 17849
		private RogueMagicSettleReason reason_;

		// Token: 0x040045BA RID: 17850
		public const int ExtraRoundLimitFieldNumber = 13;

		// Token: 0x040045BB RID: 17851
		private uint extraRoundLimit_;

		// Token: 0x040045BC RID: 17852
		public const int StatusFieldNumber = 15;

		// Token: 0x040045BD RID: 17853
		private RogueMagicLevelStatus status_;

		// Token: 0x040045BE RID: 17854
		public const int LevelInfoListFieldNumber = 3;

		// Token: 0x040045BF RID: 17855
		private static readonly FieldCodec<RogueMagicLayerInfo> _repeated_levelInfoList_codec = FieldCodec.ForMessage<RogueMagicLayerInfo>(26U, RogueMagicLayerInfo.Parser);

		// Token: 0x040045C0 RID: 17856
		private readonly RepeatedField<RogueMagicLayerInfo> levelInfoList_ = new RepeatedField<RogueMagicLayerInfo>();

		// Token: 0x040045C1 RID: 17857
		public const int LABGKMPMBEDFieldNumber = 9;

		// Token: 0x040045C2 RID: 17858
		private uint lABGKMPMBED_;

		// Token: 0x040045C3 RID: 17859
		public const int CurLevelIndexFieldNumber = 2;

		// Token: 0x040045C4 RID: 17860
		private uint curLevelIndex_;
	}
}
