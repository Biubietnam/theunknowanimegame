using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D37 RID: 3383
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PVEBattleResultScRsp : IMessage<PVEBattleResultScRsp>, IMessage, IEquatable<PVEBattleResultScRsp>, IDeepCloneable<PVEBattleResultScRsp>, IBufferMessage
	{
		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x0600971A RID: 38682 RVA: 0x00192718 File Offset: 0x00190918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PVEBattleResultScRsp> Parser
		{
			get
			{
				return PVEBattleResultScRsp._parser;
			}
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x0600971B RID: 38683 RVA: 0x0019271F File Offset: 0x0019091F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PVEBattleResultScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x0600971C RID: 38684 RVA: 0x00192731 File Offset: 0x00190931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PVEBattleResultScRsp.Descriptor;
			}
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x00192738 File Offset: 0x00190938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PVEBattleResultScRsp()
		{
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x00192764 File Offset: 0x00190964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PVEBattleResultScRsp(PVEBattleResultScRsp other) : this()
		{
			this.stageId_ = other.stageId_;
			this.battleAvatarList_ = other.battleAvatarList_.Clone();
			this.oBGBHPKLPJH_ = other.oBGBHPKLPJH_;
			this.mismatchTurnCount_ = other.mismatchTurnCount_;
			this.binVersion_ = other.binVersion_;
			this.checkIdentical_ = other.checkIdentical_;
			this.multipleDropData_ = ((other.multipleDropData_ != null) ? other.multipleDropData_.Clone() : null);
			this.resVersion_ = other.resVersion_;
			this.pLBCDDFMFIO_ = other.pLBCDDFMFIO_;
			this.unk1_ = ((other.unk1_ != null) ? other.unk1_.Clone() : null);
			this.unk2_ = ((other.unk2_ != null) ? other.unk2_.Clone() : null);
			this.battleId_ = other.battleId_;
			this.eventId_ = other.eventId_;
			this.dropData_ = ((other.dropData_ != null) ? other.dropData_.Clone() : null);
			this.endStatus_ = other.endStatus_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x0019288D File Offset: 0x00190A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PVEBattleResultScRsp Clone()
		{
			return new PVEBattleResultScRsp(this);
		}

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x06009720 RID: 38688 RVA: 0x00192895 File Offset: 0x00190A95
		// (set) Token: 0x06009721 RID: 38689 RVA: 0x0019289D File Offset: 0x00190A9D
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

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x06009722 RID: 38690 RVA: 0x001928A6 File Offset: 0x00190AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleAvatar> BattleAvatarList
		{
			get
			{
				return this.battleAvatarList_;
			}
		}

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x06009723 RID: 38691 RVA: 0x001928AE File Offset: 0x00190AAE
		// (set) Token: 0x06009724 RID: 38692 RVA: 0x001928B6 File Offset: 0x00190AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OBGBHPKLPJH
		{
			get
			{
				return this.oBGBHPKLPJH_;
			}
			set
			{
				this.oBGBHPKLPJH_ = value;
			}
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x06009725 RID: 38693 RVA: 0x001928BF File Offset: 0x00190ABF
		// (set) Token: 0x06009726 RID: 38694 RVA: 0x001928C7 File Offset: 0x00190AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MismatchTurnCount
		{
			get
			{
				return this.mismatchTurnCount_;
			}
			set
			{
				this.mismatchTurnCount_ = value;
			}
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x06009727 RID: 38695 RVA: 0x001928D0 File Offset: 0x00190AD0
		// (set) Token: 0x06009728 RID: 38696 RVA: 0x001928D8 File Offset: 0x00190AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BinVersion
		{
			get
			{
				return this.binVersion_;
			}
			set
			{
				this.binVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x06009729 RID: 38697 RVA: 0x001928EB File Offset: 0x00190AEB
		// (set) Token: 0x0600972A RID: 38698 RVA: 0x001928F3 File Offset: 0x00190AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CheckIdentical
		{
			get
			{
				return this.checkIdentical_;
			}
			set
			{
				this.checkIdentical_ = value;
			}
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x0600972B RID: 38699 RVA: 0x001928FC File Offset: 0x00190AFC
		// (set) Token: 0x0600972C RID: 38700 RVA: 0x00192904 File Offset: 0x00190B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList MultipleDropData
		{
			get
			{
				return this.multipleDropData_;
			}
			set
			{
				this.multipleDropData_ = value;
			}
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x0600972D RID: 38701 RVA: 0x0019290D File Offset: 0x00190B0D
		// (set) Token: 0x0600972E RID: 38702 RVA: 0x00192915 File Offset: 0x00190B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ResVersion
		{
			get
			{
				return this.resVersion_;
			}
			set
			{
				this.resVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x0600972F RID: 38703 RVA: 0x00192928 File Offset: 0x00190B28
		// (set) Token: 0x06009730 RID: 38704 RVA: 0x00192930 File Offset: 0x00190B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PLBCDDFMFIO
		{
			get
			{
				return this.pLBCDDFMFIO_;
			}
			set
			{
				this.pLBCDDFMFIO_ = value;
			}
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x06009731 RID: 38705 RVA: 0x00192939 File Offset: 0x00190B39
		// (set) Token: 0x06009732 RID: 38706 RVA: 0x00192941 File Offset: 0x00190B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Unk1
		{
			get
			{
				return this.unk1_;
			}
			set
			{
				this.unk1_ = value;
			}
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x06009733 RID: 38707 RVA: 0x0019294A File Offset: 0x00190B4A
		// (set) Token: 0x06009734 RID: 38708 RVA: 0x00192952 File Offset: 0x00190B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Unk2
		{
			get
			{
				return this.unk2_;
			}
			set
			{
				this.unk2_ = value;
			}
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x06009735 RID: 38709 RVA: 0x0019295B File Offset: 0x00190B5B
		// (set) Token: 0x06009736 RID: 38710 RVA: 0x00192963 File Offset: 0x00190B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleId
		{
			get
			{
				return this.battleId_;
			}
			set
			{
				this.battleId_ = value;
			}
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x06009737 RID: 38711 RVA: 0x0019296C File Offset: 0x00190B6C
		// (set) Token: 0x06009738 RID: 38712 RVA: 0x00192974 File Offset: 0x00190B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x06009739 RID: 38713 RVA: 0x0019297D File Offset: 0x00190B7D
		// (set) Token: 0x0600973A RID: 38714 RVA: 0x00192985 File Offset: 0x00190B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList DropData
		{
			get
			{
				return this.dropData_;
			}
			set
			{
				this.dropData_ = value;
			}
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x0600973B RID: 38715 RVA: 0x0019298E File Offset: 0x00190B8E
		// (set) Token: 0x0600973C RID: 38716 RVA: 0x00192996 File Offset: 0x00190B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEndStatus EndStatus
		{
			get
			{
				return this.endStatus_;
			}
			set
			{
				this.endStatus_ = value;
			}
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x0600973D RID: 38717 RVA: 0x0019299F File Offset: 0x00190B9F
		// (set) Token: 0x0600973E RID: 38718 RVA: 0x001929A7 File Offset: 0x00190BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600973F RID: 38719 RVA: 0x001929B0 File Offset: 0x00190BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PVEBattleResultScRsp);
		}

		// Token: 0x06009740 RID: 38720 RVA: 0x001929C0 File Offset: 0x00190BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PVEBattleResultScRsp other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && this.battleAvatarList_.Equals(other.battleAvatarList_) && this.OBGBHPKLPJH == other.OBGBHPKLPJH && this.MismatchTurnCount == other.MismatchTurnCount && !(this.BinVersion != other.BinVersion) && this.CheckIdentical == other.CheckIdentical && object.Equals(this.MultipleDropData, other.MultipleDropData) && !(this.ResVersion != other.ResVersion) && this.PLBCDDFMFIO == other.PLBCDDFMFIO && object.Equals(this.Unk1, other.Unk1) && object.Equals(this.Unk2, other.Unk2) && this.BattleId == other.BattleId && this.EventId == other.EventId && object.Equals(this.DropData, other.DropData) && this.EndStatus == other.EndStatus && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009741 RID: 38721 RVA: 0x00192B0C File Offset: 0x00190D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			num ^= this.battleAvatarList_.GetHashCode();
			if (this.OBGBHPKLPJH != 0U)
			{
				num ^= this.OBGBHPKLPJH.GetHashCode();
			}
			if (this.MismatchTurnCount != 0U)
			{
				num ^= this.MismatchTurnCount.GetHashCode();
			}
			if (this.BinVersion.Length != 0)
			{
				num ^= this.BinVersion.GetHashCode();
			}
			if (this.CheckIdentical)
			{
				num ^= this.CheckIdentical.GetHashCode();
			}
			if (this.multipleDropData_ != null)
			{
				num ^= this.MultipleDropData.GetHashCode();
			}
			if (this.ResVersion.Length != 0)
			{
				num ^= this.ResVersion.GetHashCode();
			}
			if (this.PLBCDDFMFIO != 0U)
			{
				num ^= this.PLBCDDFMFIO.GetHashCode();
			}
			if (this.unk1_ != null)
			{
				num ^= this.Unk1.GetHashCode();
			}
			if (this.unk2_ != null)
			{
				num ^= this.Unk2.GetHashCode();
			}
			if (this.BattleId != 0U)
			{
				num ^= this.BattleId.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.dropData_ != null)
			{
				num ^= this.DropData.GetHashCode();
			}
			if (this.EndStatus != BattleEndStatus.BattleEndNone)
			{
				num ^= this.EndStatus.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009742 RID: 38722 RVA: 0x00192CB5 File Offset: 0x00190EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009743 RID: 38723 RVA: 0x00192CBD File Offset: 0x00190EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009744 RID: 38724 RVA: 0x00192CC8 File Offset: 0x00190EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.unk1_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Unk1);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.StageId);
			}
			if (this.BattleId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.BattleId);
			}
			if (this.CheckIdentical)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.CheckIdentical);
			}
			if (this.PLBCDDFMFIO != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PLBCDDFMFIO);
			}
			if (this.ResVersion.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ResVersion);
			}
			this.battleAvatarList_.WriteTo(ref output, PVEBattleResultScRsp._repeated_battleAvatarList_codec);
			if (this.EventId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.EventId);
			}
			if (this.dropData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.DropData);
			}
			if (this.BinVersion.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.BinVersion);
			}
			if (this.OBGBHPKLPJH != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.OBGBHPKLPJH);
			}
			if (this.multipleDropData_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MultipleDropData);
			}
			if (this.MismatchTurnCount != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MismatchTurnCount);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EndStatus != BattleEndStatus.BattleEndNone)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.EndStatus);
			}
			if (this.unk2_ != null)
			{
				output.WriteRawTag(202, 71);
				output.WriteMessage(this.Unk2);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009745 RID: 38725 RVA: 0x00192EB0 File Offset: 0x001910B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			num += this.battleAvatarList_.CalculateSize(PVEBattleResultScRsp._repeated_battleAvatarList_codec);
			if (this.OBGBHPKLPJH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OBGBHPKLPJH);
			}
			if (this.MismatchTurnCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MismatchTurnCount);
			}
			if (this.BinVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BinVersion);
			}
			if (this.CheckIdentical)
			{
				num += 2;
			}
			if (this.multipleDropData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MultipleDropData);
			}
			if (this.ResVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ResVersion);
			}
			if (this.PLBCDDFMFIO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PLBCDDFMFIO);
			}
			if (this.unk1_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Unk1);
			}
			if (this.unk2_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Unk2);
			}
			if (this.BattleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleId);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.dropData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DropData);
			}
			if (this.EndStatus != BattleEndStatus.BattleEndNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EndStatus);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009746 RID: 38726 RVA: 0x00193050 File Offset: 0x00191250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PVEBattleResultScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			this.battleAvatarList_.Add(other.battleAvatarList_);
			if (other.OBGBHPKLPJH != 0U)
			{
				this.OBGBHPKLPJH = other.OBGBHPKLPJH;
			}
			if (other.MismatchTurnCount != 0U)
			{
				this.MismatchTurnCount = other.MismatchTurnCount;
			}
			if (other.BinVersion.Length != 0)
			{
				this.BinVersion = other.BinVersion;
			}
			if (other.CheckIdentical)
			{
				this.CheckIdentical = other.CheckIdentical;
			}
			if (other.multipleDropData_ != null)
			{
				if (this.multipleDropData_ == null)
				{
					this.MultipleDropData = new ItemList();
				}
				this.MultipleDropData.MergeFrom(other.MultipleDropData);
			}
			if (other.ResVersion.Length != 0)
			{
				this.ResVersion = other.ResVersion;
			}
			if (other.PLBCDDFMFIO != 0U)
			{
				this.PLBCDDFMFIO = other.PLBCDDFMFIO;
			}
			if (other.unk1_ != null)
			{
				if (this.unk1_ == null)
				{
					this.Unk1 = new ItemList();
				}
				this.Unk1.MergeFrom(other.Unk1);
			}
			if (other.unk2_ != null)
			{
				if (this.unk2_ == null)
				{
					this.Unk2 = new ItemList();
				}
				this.Unk2.MergeFrom(other.Unk2);
			}
			if (other.BattleId != 0U)
			{
				this.BattleId = other.BattleId;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.dropData_ != null)
			{
				if (this.dropData_ == null)
				{
					this.DropData = new ItemList();
				}
				this.DropData.MergeFrom(other.DropData);
			}
			if (other.EndStatus != BattleEndStatus.BattleEndNone)
			{
				this.EndStatus = other.EndStatus;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009747 RID: 38727 RVA: 0x0019321F File Offset: 0x0019141F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009748 RID: 38728 RVA: 0x00193228 File Offset: 0x00191428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 32U)
					{
						if (num <= 16U)
						{
							if (num == 10U)
							{
								if (this.unk1_ == null)
								{
									this.Unk1 = new ItemList();
								}
								input.ReadMessage(this.Unk1);
								continue;
							}
							if (num == 16U)
							{
								this.StageId = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.BattleId = input.ReadUInt32();
								continue;
							}
							if (num == 32U)
							{
								this.CheckIdentical = input.ReadBool();
								continue;
							}
						}
					}
					else if (num <= 50U)
					{
						if (num == 40U)
						{
							this.PLBCDDFMFIO = input.ReadUInt32();
							continue;
						}
						if (num == 50U)
						{
							this.ResVersion = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							this.battleAvatarList_.AddEntriesFrom(ref input, PVEBattleResultScRsp._repeated_battleAvatarList_codec);
							continue;
						}
						if (num == 64U)
						{
							this.EventId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num <= 82U)
					{
						if (num == 74U)
						{
							if (this.dropData_ == null)
							{
								this.DropData = new ItemList();
							}
							input.ReadMessage(this.DropData);
							continue;
						}
						if (num == 82U)
						{
							this.BinVersion = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 88U)
						{
							this.OBGBHPKLPJH = input.ReadUInt32();
							continue;
						}
						if (num == 98U)
						{
							if (this.multipleDropData_ == null)
							{
								this.MultipleDropData = new ItemList();
							}
							input.ReadMessage(this.MultipleDropData);
							continue;
						}
					}
				}
				else if (num <= 112U)
				{
					if (num == 104U)
					{
						this.MismatchTurnCount = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 120U)
					{
						this.EndStatus = (BattleEndStatus)input.ReadEnum();
						continue;
					}
					if (num == 9162U)
					{
						if (this.unk2_ == null)
						{
							this.Unk2 = new ItemList();
						}
						input.ReadMessage(this.Unk2);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003AB4 RID: 15028
		private static readonly MessageParser<PVEBattleResultScRsp> _parser = new MessageParser<PVEBattleResultScRsp>(() => new PVEBattleResultScRsp());

		// Token: 0x04003AB5 RID: 15029
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AB6 RID: 15030
		public const int StageIdFieldNumber = 2;

		// Token: 0x04003AB7 RID: 15031
		private uint stageId_;

		// Token: 0x04003AB8 RID: 15032
		public const int BattleAvatarListFieldNumber = 7;

		// Token: 0x04003AB9 RID: 15033
		private static readonly FieldCodec<BattleAvatar> _repeated_battleAvatarList_codec = FieldCodec.ForMessage<BattleAvatar>(58U, BattleAvatar.Parser);

		// Token: 0x04003ABA RID: 15034
		private readonly RepeatedField<BattleAvatar> battleAvatarList_ = new RepeatedField<BattleAvatar>();

		// Token: 0x04003ABB RID: 15035
		public const int OBGBHPKLPJHFieldNumber = 11;

		// Token: 0x04003ABC RID: 15036
		private uint oBGBHPKLPJH_;

		// Token: 0x04003ABD RID: 15037
		public const int MismatchTurnCountFieldNumber = 13;

		// Token: 0x04003ABE RID: 15038
		private uint mismatchTurnCount_;

		// Token: 0x04003ABF RID: 15039
		public const int BinVersionFieldNumber = 10;

		// Token: 0x04003AC0 RID: 15040
		private string binVersion_ = "";

		// Token: 0x04003AC1 RID: 15041
		public const int CheckIdenticalFieldNumber = 4;

		// Token: 0x04003AC2 RID: 15042
		private bool checkIdentical_;

		// Token: 0x04003AC3 RID: 15043
		public const int MultipleDropDataFieldNumber = 12;

		// Token: 0x04003AC4 RID: 15044
		private ItemList multipleDropData_;

		// Token: 0x04003AC5 RID: 15045
		public const int ResVersionFieldNumber = 6;

		// Token: 0x04003AC6 RID: 15046
		private string resVersion_ = "";

		// Token: 0x04003AC7 RID: 15047
		public const int PLBCDDFMFIOFieldNumber = 5;

		// Token: 0x04003AC8 RID: 15048
		private uint pLBCDDFMFIO_;

		// Token: 0x04003AC9 RID: 15049
		public const int Unk1FieldNumber = 1;

		// Token: 0x04003ACA RID: 15050
		private ItemList unk1_;

		// Token: 0x04003ACB RID: 15051
		public const int Unk2FieldNumber = 1145;

		// Token: 0x04003ACC RID: 15052
		private ItemList unk2_;

		// Token: 0x04003ACD RID: 15053
		public const int BattleIdFieldNumber = 3;

		// Token: 0x04003ACE RID: 15054
		private uint battleId_;

		// Token: 0x04003ACF RID: 15055
		public const int EventIdFieldNumber = 8;

		// Token: 0x04003AD0 RID: 15056
		private uint eventId_;

		// Token: 0x04003AD1 RID: 15057
		public const int DropDataFieldNumber = 9;

		// Token: 0x04003AD2 RID: 15058
		private ItemList dropData_;

		// Token: 0x04003AD3 RID: 15059
		public const int EndStatusFieldNumber = 15;

		// Token: 0x04003AD4 RID: 15060
		private BattleEndStatus endStatus_;

		// Token: 0x04003AD5 RID: 15061
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04003AD6 RID: 15062
		private uint retcode_;
	}
}
