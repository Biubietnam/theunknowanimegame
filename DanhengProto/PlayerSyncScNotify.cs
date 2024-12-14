using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CE9 RID: 3305
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerSyncScNotify : IMessage<PlayerSyncScNotify>, IMessage, IEquatable<PlayerSyncScNotify>, IDeepCloneable<PlayerSyncScNotify>, IBufferMessage
	{
		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x06009390 RID: 37776 RVA: 0x00187B1A File Offset: 0x00185D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSyncScNotify> Parser
		{
			get
			{
				return PlayerSyncScNotify._parser;
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x06009391 RID: 37777 RVA: 0x00187B21 File Offset: 0x00185D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerSyncScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x06009392 RID: 37778 RVA: 0x00187B33 File Offset: 0x00185D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSyncScNotify.Descriptor;
			}
		}

		// Token: 0x06009393 RID: 37779 RVA: 0x00187B3C File Offset: 0x00185D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSyncScNotify()
		{
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x00187BE0 File Offset: 0x00185DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSyncScNotify(PlayerSyncScNotify other) : this()
		{
			this.sectionStatus_ = other.sectionStatus_.Clone();
			this.materialList_ = other.materialList_.Clone();
			this.missionEventSync_ = ((other.missionEventSync_ != null) ? other.missionEventSync_.Clone() : null);
			this.newItemHintList_ = other.newItemHintList_.Clone();
			this.equipmentList_ = other.equipmentList_.Clone();
			this.pABLGNBDDCG_ = ((other.pABLGNBDDCG_ != null) ? other.pABLGNBDDCG_.Clone() : null);
			this.delEquipmentList_ = other.delEquipmentList_.Clone();
			this.playerboardModuleSync_ = ((other.playerboardModuleSync_ != null) ? other.playerboardModuleSync_.Clone() : null);
			this.hNBHLCAKAJG_ = other.hNBHLCAKAJG_.Clone();
			this.missionSync_ = ((other.missionSync_ != null) ? other.missionSync_.Clone() : null);
			this.totalAchievementExp_ = other.totalAchievementExp_;
			this.basicModuleSync_ = ((other.basicModuleSync_ != null) ? other.basicModuleSync_.Clone() : null);
			this.cEOMDDEJKEF_ = other.cEOMDDEJKEF_.Clone();
			this.messageGroupStatus_ = other.messageGroupStatus_.Clone();
			this.iKLEOCENKJG_ = ((other.iKLEOCENKJG_ != null) ? other.iKLEOCENKJG_.Clone() : null);
			this.multiPathAvatarInfoList_ = other.multiPathAvatarInfoList_.Clone();
			this.avatarSync_ = ((other.avatarSync_ != null) ? other.avatarSync_.Clone() : null);
			this.waitDelResourceList_ = other.waitDelResourceList_.Clone();
			this.basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
			this.questList_ = other.questList_.Clone();
			this.relicList_ = other.relicList_.Clone();
			this.delRelicList_ = other.delRelicList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009395 RID: 37781 RVA: 0x00187DCD File Offset: 0x00185FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSyncScNotify Clone()
		{
			return new PlayerSyncScNotify(this);
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x06009396 RID: 37782 RVA: 0x00187DD5 File Offset: 0x00185FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SectionStatus> SectionStatus
		{
			get
			{
				return this.sectionStatus_;
			}
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x06009397 RID: 37783 RVA: 0x00187DDD File Offset: 0x00185FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Material> MaterialList
		{
			get
			{
				return this.materialList_;
			}
		}

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x06009398 RID: 37784 RVA: 0x00187DE5 File Offset: 0x00185FE5
		// (set) Token: 0x06009399 RID: 37785 RVA: 0x00187DED File Offset: 0x00185FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionEventSync MissionEventSync
		{
			get
			{
				return this.missionEventSync_;
			}
			set
			{
				this.missionEventSync_ = value;
			}
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x0600939A RID: 37786 RVA: 0x00187DF6 File Offset: 0x00185FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NewItemHintList
		{
			get
			{
				return this.newItemHintList_;
			}
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x0600939B RID: 37787 RVA: 0x00187DFE File Offset: 0x00185FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Equipment> EquipmentList
		{
			get
			{
				return this.equipmentList_;
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x0600939C RID: 37788 RVA: 0x00187E06 File Offset: 0x00186006
		// (set) Token: 0x0600939D RID: 37789 RVA: 0x00187E0E File Offset: 0x0018600E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DEAJGOPAMNB PABLGNBDDCG
		{
			get
			{
				return this.pABLGNBDDCG_;
			}
			set
			{
				this.pABLGNBDDCG_ = value;
			}
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x0600939E RID: 37790 RVA: 0x00187E17 File Offset: 0x00186017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DelEquipmentList
		{
			get
			{
				return this.delEquipmentList_;
			}
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x0600939F RID: 37791 RVA: 0x00187E1F File Offset: 0x0018601F
		// (set) Token: 0x060093A0 RID: 37792 RVA: 0x00187E27 File Offset: 0x00186027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBoardModuleSync PlayerboardModuleSync
		{
			get
			{
				return this.playerboardModuleSync_;
			}
			set
			{
				this.playerboardModuleSync_ = value;
			}
		}

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x060093A1 RID: 37793 RVA: 0x00187E30 File Offset: 0x00186030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Material> HNBHLCAKAJG
		{
			get
			{
				return this.hNBHLCAKAJG_;
			}
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x060093A2 RID: 37794 RVA: 0x00187E38 File Offset: 0x00186038
		// (set) Token: 0x060093A3 RID: 37795 RVA: 0x00187E40 File Offset: 0x00186040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionSync MissionSync
		{
			get
			{
				return this.missionSync_;
			}
			set
			{
				this.missionSync_ = value;
			}
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x060093A4 RID: 37796 RVA: 0x00187E49 File Offset: 0x00186049
		// (set) Token: 0x060093A5 RID: 37797 RVA: 0x00187E51 File Offset: 0x00186051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TotalAchievementExp
		{
			get
			{
				return this.totalAchievementExp_;
			}
			set
			{
				this.totalAchievementExp_ = value;
			}
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x060093A6 RID: 37798 RVA: 0x00187E5A File Offset: 0x0018605A
		// (set) Token: 0x060093A7 RID: 37799 RVA: 0x00187E62 File Offset: 0x00186062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BasicModuleSync BasicModuleSync
		{
			get
			{
				return this.basicModuleSync_;
			}
			set
			{
				this.basicModuleSync_ = value;
			}
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x060093A8 RID: 37800 RVA: 0x00187E6B File Offset: 0x0018606B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IGFLEJNLOMM> CEOMDDEJKEF
		{
			get
			{
				return this.cEOMDDEJKEF_;
			}
		}

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x060093A9 RID: 37801 RVA: 0x00187E73 File Offset: 0x00186073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GroupStatus> MessageGroupStatus
		{
			get
			{
				return this.messageGroupStatus_;
			}
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x060093AA RID: 37802 RVA: 0x00187E7B File Offset: 0x0018607B
		// (set) Token: 0x060093AB RID: 37803 RVA: 0x00187E83 File Offset: 0x00186083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList IKLEOCENKJG
		{
			get
			{
				return this.iKLEOCENKJG_;
			}
			set
			{
				this.iKLEOCENKJG_ = value;
			}
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x060093AC RID: 37804 RVA: 0x00187E8C File Offset: 0x0018608C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MultiPathAvatarInfo> MultiPathAvatarInfoList
		{
			get
			{
				return this.multiPathAvatarInfoList_;
			}
		}

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x060093AD RID: 37805 RVA: 0x00187E94 File Offset: 0x00186094
		// (set) Token: 0x060093AE RID: 37806 RVA: 0x00187E9C File Offset: 0x0018609C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarSync AvatarSync
		{
			get
			{
				return this.avatarSync_;
			}
			set
			{
				this.avatarSync_ = value;
			}
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x060093AF RID: 37807 RVA: 0x00187EA5 File Offset: 0x001860A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WaitDelResource> WaitDelResourceList
		{
			get
			{
				return this.waitDelResourceList_;
			}
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x060093B0 RID: 37808 RVA: 0x00187EAD File Offset: 0x001860AD
		// (set) Token: 0x060093B1 RID: 37809 RVA: 0x00187EB5 File Offset: 0x001860B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfo BasicInfo
		{
			get
			{
				return this.basicInfo_;
			}
			set
			{
				this.basicInfo_ = value;
			}
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x060093B2 RID: 37810 RVA: 0x00187EBE File Offset: 0x001860BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Quest> QuestList
		{
			get
			{
				return this.questList_;
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x060093B3 RID: 37811 RVA: 0x00187EC6 File Offset: 0x001860C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Relic> RelicList
		{
			get
			{
				return this.relicList_;
			}
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x060093B4 RID: 37812 RVA: 0x00187ECE File Offset: 0x001860CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DelRelicList
		{
			get
			{
				return this.delRelicList_;
			}
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x00187ED6 File Offset: 0x001860D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSyncScNotify);
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x00187EE4 File Offset: 0x001860E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSyncScNotify other)
		{
			return other != null && (other == this || (this.sectionStatus_.Equals(other.sectionStatus_) && this.materialList_.Equals(other.materialList_) && object.Equals(this.MissionEventSync, other.MissionEventSync) && this.newItemHintList_.Equals(other.newItemHintList_) && this.equipmentList_.Equals(other.equipmentList_) && object.Equals(this.PABLGNBDDCG, other.PABLGNBDDCG) && this.delEquipmentList_.Equals(other.delEquipmentList_) && object.Equals(this.PlayerboardModuleSync, other.PlayerboardModuleSync) && this.hNBHLCAKAJG_.Equals(other.hNBHLCAKAJG_) && object.Equals(this.MissionSync, other.MissionSync) && this.TotalAchievementExp == other.TotalAchievementExp && object.Equals(this.BasicModuleSync, other.BasicModuleSync) && this.cEOMDDEJKEF_.Equals(other.cEOMDDEJKEF_) && this.messageGroupStatus_.Equals(other.messageGroupStatus_) && object.Equals(this.IKLEOCENKJG, other.IKLEOCENKJG) && this.multiPathAvatarInfoList_.Equals(other.multiPathAvatarInfoList_) && object.Equals(this.AvatarSync, other.AvatarSync) && this.waitDelResourceList_.Equals(other.waitDelResourceList_) && object.Equals(this.BasicInfo, other.BasicInfo) && this.questList_.Equals(other.questList_) && this.relicList_.Equals(other.relicList_) && this.delRelicList_.Equals(other.delRelicList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x001880D8 File Offset: 0x001862D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.sectionStatus_.GetHashCode();
			num ^= this.materialList_.GetHashCode();
			if (this.missionEventSync_ != null)
			{
				num ^= this.MissionEventSync.GetHashCode();
			}
			num ^= this.newItemHintList_.GetHashCode();
			num ^= this.equipmentList_.GetHashCode();
			if (this.pABLGNBDDCG_ != null)
			{
				num ^= this.PABLGNBDDCG.GetHashCode();
			}
			num ^= this.delEquipmentList_.GetHashCode();
			if (this.playerboardModuleSync_ != null)
			{
				num ^= this.PlayerboardModuleSync.GetHashCode();
			}
			num ^= this.hNBHLCAKAJG_.GetHashCode();
			if (this.missionSync_ != null)
			{
				num ^= this.MissionSync.GetHashCode();
			}
			if (this.TotalAchievementExp != 0U)
			{
				num ^= this.TotalAchievementExp.GetHashCode();
			}
			if (this.basicModuleSync_ != null)
			{
				num ^= this.BasicModuleSync.GetHashCode();
			}
			num ^= this.cEOMDDEJKEF_.GetHashCode();
			num ^= this.messageGroupStatus_.GetHashCode();
			if (this.iKLEOCENKJG_ != null)
			{
				num ^= this.IKLEOCENKJG.GetHashCode();
			}
			num ^= this.multiPathAvatarInfoList_.GetHashCode();
			if (this.avatarSync_ != null)
			{
				num ^= this.AvatarSync.GetHashCode();
			}
			num ^= this.waitDelResourceList_.GetHashCode();
			if (this.basicInfo_ != null)
			{
				num ^= this.BasicInfo.GetHashCode();
			}
			num ^= this.questList_.GetHashCode();
			num ^= this.relicList_.GetHashCode();
			num ^= this.delRelicList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x0018827D File Offset: 0x0018647D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x00188285 File Offset: 0x00186485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x00188290 File Offset: 0x00186490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.delEquipmentList_.WriteTo(ref output, PlayerSyncScNotify._repeated_delEquipmentList_codec);
			if (this.missionEventSync_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MissionEventSync);
			}
			this.relicList_.WriteTo(ref output, PlayerSyncScNotify._repeated_relicList_codec);
			if (this.basicModuleSync_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BasicModuleSync);
			}
			if (this.basicInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.BasicInfo);
			}
			this.questList_.WriteTo(ref output, PlayerSyncScNotify._repeated_questList_codec);
			this.delRelicList_.WriteTo(ref output, PlayerSyncScNotify._repeated_delRelicList_codec);
			if (this.avatarSync_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.AvatarSync);
			}
			this.materialList_.WriteTo(ref output, PlayerSyncScNotify._repeated_materialList_codec);
			this.equipmentList_.WriteTo(ref output, PlayerSyncScNotify._repeated_equipmentList_codec);
			if (this.missionSync_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MissionSync);
			}
			this.waitDelResourceList_.WriteTo(ref output, PlayerSyncScNotify._repeated_waitDelResourceList_codec);
			if (this.pABLGNBDDCG_ != null)
			{
				output.WriteRawTag(138, 3);
				output.WriteMessage(this.PABLGNBDDCG);
			}
			this.multiPathAvatarInfoList_.WriteTo(ref output, PlayerSyncScNotify._repeated_multiPathAvatarInfoList_codec);
			if (this.playerboardModuleSync_ != null)
			{
				output.WriteRawTag(138, 8);
				output.WriteMessage(this.PlayerboardModuleSync);
			}
			this.sectionStatus_.WriteTo(ref output, PlayerSyncScNotify._repeated_sectionStatus_codec);
			if (this.TotalAchievementExp != 0U)
			{
				output.WriteRawTag(144, 19);
				output.WriteUInt32(this.TotalAchievementExp);
			}
			this.cEOMDDEJKEF_.WriteTo(ref output, PlayerSyncScNotify._repeated_cEOMDDEJKEF_codec);
			this.messageGroupStatus_.WriteTo(ref output, PlayerSyncScNotify._repeated_messageGroupStatus_codec);
			if (this.iKLEOCENKJG_ != null)
			{
				output.WriteRawTag(130, 83);
				output.WriteMessage(this.IKLEOCENKJG);
			}
			this.hNBHLCAKAJG_.WriteTo(ref output, PlayerSyncScNotify._repeated_hNBHLCAKAJG_codec);
			this.newItemHintList_.WriteTo(ref output, PlayerSyncScNotify._repeated_newItemHintList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x0018849C File Offset: 0x0018669C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sectionStatus_.CalculateSize(PlayerSyncScNotify._repeated_sectionStatus_codec);
			num += this.materialList_.CalculateSize(PlayerSyncScNotify._repeated_materialList_codec);
			if (this.missionEventSync_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MissionEventSync);
			}
			num += this.newItemHintList_.CalculateSize(PlayerSyncScNotify._repeated_newItemHintList_codec);
			num += this.equipmentList_.CalculateSize(PlayerSyncScNotify._repeated_equipmentList_codec);
			if (this.pABLGNBDDCG_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PABLGNBDDCG);
			}
			num += this.delEquipmentList_.CalculateSize(PlayerSyncScNotify._repeated_delEquipmentList_codec);
			if (this.playerboardModuleSync_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PlayerboardModuleSync);
			}
			num += this.hNBHLCAKAJG_.CalculateSize(PlayerSyncScNotify._repeated_hNBHLCAKAJG_codec);
			if (this.missionSync_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MissionSync);
			}
			if (this.TotalAchievementExp != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.TotalAchievementExp);
			}
			if (this.basicModuleSync_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BasicModuleSync);
			}
			num += this.cEOMDDEJKEF_.CalculateSize(PlayerSyncScNotify._repeated_cEOMDDEJKEF_codec);
			num += this.messageGroupStatus_.CalculateSize(PlayerSyncScNotify._repeated_messageGroupStatus_codec);
			if (this.iKLEOCENKJG_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.IKLEOCENKJG);
			}
			num += this.multiPathAvatarInfoList_.CalculateSize(PlayerSyncScNotify._repeated_multiPathAvatarInfoList_codec);
			if (this.avatarSync_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AvatarSync);
			}
			num += this.waitDelResourceList_.CalculateSize(PlayerSyncScNotify._repeated_waitDelResourceList_codec);
			if (this.basicInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BasicInfo);
			}
			num += this.questList_.CalculateSize(PlayerSyncScNotify._repeated_questList_codec);
			num += this.relicList_.CalculateSize(PlayerSyncScNotify._repeated_relicList_codec);
			num += this.delRelicList_.CalculateSize(PlayerSyncScNotify._repeated_delRelicList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x00188694 File Offset: 0x00186894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerSyncScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.sectionStatus_.Add(other.sectionStatus_);
			this.materialList_.Add(other.materialList_);
			if (other.missionEventSync_ != null)
			{
				if (this.missionEventSync_ == null)
				{
					this.MissionEventSync = new MissionEventSync();
				}
				this.MissionEventSync.MergeFrom(other.MissionEventSync);
			}
			this.newItemHintList_.Add(other.newItemHintList_);
			this.equipmentList_.Add(other.equipmentList_);
			if (other.pABLGNBDDCG_ != null)
			{
				if (this.pABLGNBDDCG_ == null)
				{
					this.PABLGNBDDCG = new DEAJGOPAMNB();
				}
				this.PABLGNBDDCG.MergeFrom(other.PABLGNBDDCG);
			}
			this.delEquipmentList_.Add(other.delEquipmentList_);
			if (other.playerboardModuleSync_ != null)
			{
				if (this.playerboardModuleSync_ == null)
				{
					this.PlayerboardModuleSync = new PlayerBoardModuleSync();
				}
				this.PlayerboardModuleSync.MergeFrom(other.PlayerboardModuleSync);
			}
			this.hNBHLCAKAJG_.Add(other.hNBHLCAKAJG_);
			if (other.missionSync_ != null)
			{
				if (this.missionSync_ == null)
				{
					this.MissionSync = new MissionSync();
				}
				this.MissionSync.MergeFrom(other.MissionSync);
			}
			if (other.TotalAchievementExp != 0U)
			{
				this.TotalAchievementExp = other.TotalAchievementExp;
			}
			if (other.basicModuleSync_ != null)
			{
				if (this.basicModuleSync_ == null)
				{
					this.BasicModuleSync = new BasicModuleSync();
				}
				this.BasicModuleSync.MergeFrom(other.BasicModuleSync);
			}
			this.cEOMDDEJKEF_.Add(other.cEOMDDEJKEF_);
			this.messageGroupStatus_.Add(other.messageGroupStatus_);
			if (other.iKLEOCENKJG_ != null)
			{
				if (this.iKLEOCENKJG_ == null)
				{
					this.IKLEOCENKJG = new ItemList();
				}
				this.IKLEOCENKJG.MergeFrom(other.IKLEOCENKJG);
			}
			this.multiPathAvatarInfoList_.Add(other.multiPathAvatarInfoList_);
			if (other.avatarSync_ != null)
			{
				if (this.avatarSync_ == null)
				{
					this.AvatarSync = new AvatarSync();
				}
				this.AvatarSync.MergeFrom(other.AvatarSync);
			}
			this.waitDelResourceList_.Add(other.waitDelResourceList_);
			if (other.basicInfo_ != null)
			{
				if (this.basicInfo_ == null)
				{
					this.BasicInfo = new PlayerBasicInfo();
				}
				this.BasicInfo.MergeFrom(other.BasicInfo);
			}
			this.questList_.Add(other.questList_);
			this.relicList_.Add(other.relicList_);
			this.delRelicList_.Add(other.delRelicList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060093BD RID: 37821 RVA: 0x0018890D File Offset: 0x00186B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x00188918 File Offset: 0x00186B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 98U)
				{
					if (num <= 42U)
					{
						if (num <= 18U)
						{
							if (num == 8U || num == 10U)
							{
								this.delEquipmentList_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_delEquipmentList_codec);
								continue;
							}
							if (num == 18U)
							{
								if (this.missionEventSync_ == null)
								{
									this.MissionEventSync = new MissionEventSync();
								}
								input.ReadMessage(this.MissionEventSync);
								continue;
							}
						}
						else
						{
							if (num == 26U)
							{
								this.relicList_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_relicList_codec);
								continue;
							}
							if (num == 34U)
							{
								if (this.basicModuleSync_ == null)
								{
									this.BasicModuleSync = new BasicModuleSync();
								}
								input.ReadMessage(this.BasicModuleSync);
								continue;
							}
							if (num == 42U)
							{
								if (this.basicInfo_ == null)
								{
									this.BasicInfo = new PlayerBasicInfo();
								}
								input.ReadMessage(this.BasicInfo);
								continue;
							}
						}
					}
					else if (num <= 58U)
					{
						if (num == 50U)
						{
							this.questList_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_questList_codec);
							continue;
						}
						if (num == 56U || num == 58U)
						{
							this.delRelicList_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_delRelicList_codec);
							continue;
						}
					}
					else
					{
						if (num == 66U)
						{
							if (this.avatarSync_ == null)
							{
								this.AvatarSync = new AvatarSync();
							}
							input.ReadMessage(this.AvatarSync);
							continue;
						}
						if (num == 90U)
						{
							this.materialList_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_materialList_codec);
							continue;
						}
						if (num == 98U)
						{
							this.equipmentList_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_equipmentList_codec);
							continue;
						}
					}
				}
				else if (num <= 1714U)
				{
					if (num <= 394U)
					{
						if (num == 114U)
						{
							if (this.missionSync_ == null)
							{
								this.MissionSync = new MissionSync();
							}
							input.ReadMessage(this.MissionSync);
							continue;
						}
						if (num == 122U)
						{
							this.waitDelResourceList_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_waitDelResourceList_codec);
							continue;
						}
						if (num == 394U)
						{
							if (this.pABLGNBDDCG_ == null)
							{
								this.PABLGNBDDCG = new DEAJGOPAMNB();
							}
							input.ReadMessage(this.PABLGNBDDCG);
							continue;
						}
					}
					else
					{
						if (num == 818U)
						{
							this.multiPathAvatarInfoList_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_multiPathAvatarInfoList_codec);
							continue;
						}
						if (num == 1034U)
						{
							if (this.playerboardModuleSync_ == null)
							{
								this.PlayerboardModuleSync = new PlayerBoardModuleSync();
							}
							input.ReadMessage(this.PlayerboardModuleSync);
							continue;
						}
						if (num == 1714U)
						{
							this.sectionStatus_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_sectionStatus_codec);
							continue;
						}
					}
				}
				else if (num <= 9178U)
				{
					if (num == 2448U)
					{
						this.TotalAchievementExp = input.ReadUInt32();
						continue;
					}
					if (num == 8714U)
					{
						this.cEOMDDEJKEF_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_cEOMDDEJKEF_codec);
						continue;
					}
					if (num == 9178U)
					{
						this.messageGroupStatus_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_messageGroupStatus_codec);
						continue;
					}
				}
				else if (num <= 14002U)
				{
					if (num == 10626U)
					{
						if (this.iKLEOCENKJG_ == null)
						{
							this.IKLEOCENKJG = new ItemList();
						}
						input.ReadMessage(this.IKLEOCENKJG);
						continue;
					}
					if (num == 14002U)
					{
						this.hNBHLCAKAJG_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_hNBHLCAKAJG_codec);
						continue;
					}
				}
				else if (num == 15904U || num == 15906U)
				{
					this.newItemHintList_.AddEntriesFrom(ref input, PlayerSyncScNotify._repeated_newItemHintList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038F8 RID: 14584
		private static readonly MessageParser<PlayerSyncScNotify> _parser = new MessageParser<PlayerSyncScNotify>(() => new PlayerSyncScNotify());

		// Token: 0x040038F9 RID: 14585
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038FA RID: 14586
		public const int SectionStatusFieldNumber = 214;

		// Token: 0x040038FB RID: 14587
		private static readonly FieldCodec<SectionStatus> _repeated_sectionStatus_codec = FieldCodec.ForMessage<SectionStatus>(1714U, EggLink.DanhengServer.Proto.SectionStatus.Parser);

		// Token: 0x040038FC RID: 14588
		private readonly RepeatedField<SectionStatus> sectionStatus_ = new RepeatedField<SectionStatus>();

		// Token: 0x040038FD RID: 14589
		public const int MaterialListFieldNumber = 11;

		// Token: 0x040038FE RID: 14590
		private static readonly FieldCodec<Material> _repeated_materialList_codec = FieldCodec.ForMessage<Material>(90U, Material.Parser);

		// Token: 0x040038FF RID: 14591
		private readonly RepeatedField<Material> materialList_ = new RepeatedField<Material>();

		// Token: 0x04003900 RID: 14592
		public const int MissionEventSyncFieldNumber = 2;

		// Token: 0x04003901 RID: 14593
		private MissionEventSync missionEventSync_;

		// Token: 0x04003902 RID: 14594
		public const int NewItemHintListFieldNumber = 1988;

		// Token: 0x04003903 RID: 14595
		private static readonly FieldCodec<uint> _repeated_newItemHintList_codec = FieldCodec.ForUInt32(15906U);

		// Token: 0x04003904 RID: 14596
		private readonly RepeatedField<uint> newItemHintList_ = new RepeatedField<uint>();

		// Token: 0x04003905 RID: 14597
		public const int EquipmentListFieldNumber = 12;

		// Token: 0x04003906 RID: 14598
		private static readonly FieldCodec<Equipment> _repeated_equipmentList_codec = FieldCodec.ForMessage<Equipment>(98U, Equipment.Parser);

		// Token: 0x04003907 RID: 14599
		private readonly RepeatedField<Equipment> equipmentList_ = new RepeatedField<Equipment>();

		// Token: 0x04003908 RID: 14600
		public const int PABLGNBDDCGFieldNumber = 49;

		// Token: 0x04003909 RID: 14601
		private DEAJGOPAMNB pABLGNBDDCG_;

		// Token: 0x0400390A RID: 14602
		public const int DelEquipmentListFieldNumber = 1;

		// Token: 0x0400390B RID: 14603
		private static readonly FieldCodec<uint> _repeated_delEquipmentList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400390C RID: 14604
		private readonly RepeatedField<uint> delEquipmentList_ = new RepeatedField<uint>();

		// Token: 0x0400390D RID: 14605
		public const int PlayerboardModuleSyncFieldNumber = 129;

		// Token: 0x0400390E RID: 14606
		private PlayerBoardModuleSync playerboardModuleSync_;

		// Token: 0x0400390F RID: 14607
		public const int HNBHLCAKAJGFieldNumber = 1750;

		// Token: 0x04003910 RID: 14608
		private static readonly FieldCodec<Material> _repeated_hNBHLCAKAJG_codec = FieldCodec.ForMessage<Material>(14002U, Material.Parser);

		// Token: 0x04003911 RID: 14609
		private readonly RepeatedField<Material> hNBHLCAKAJG_ = new RepeatedField<Material>();

		// Token: 0x04003912 RID: 14610
		public const int MissionSyncFieldNumber = 14;

		// Token: 0x04003913 RID: 14611
		private MissionSync missionSync_;

		// Token: 0x04003914 RID: 14612
		public const int TotalAchievementExpFieldNumber = 306;

		// Token: 0x04003915 RID: 14613
		private uint totalAchievementExp_;

		// Token: 0x04003916 RID: 14614
		public const int BasicModuleSyncFieldNumber = 4;

		// Token: 0x04003917 RID: 14615
		private BasicModuleSync basicModuleSync_;

		// Token: 0x04003918 RID: 14616
		public const int CEOMDDEJKEFFieldNumber = 1089;

		// Token: 0x04003919 RID: 14617
		private static readonly FieldCodec<IGFLEJNLOMM> _repeated_cEOMDDEJKEF_codec = FieldCodec.ForMessage<IGFLEJNLOMM>(8714U, IGFLEJNLOMM.Parser);

		// Token: 0x0400391A RID: 14618
		private readonly RepeatedField<IGFLEJNLOMM> cEOMDDEJKEF_ = new RepeatedField<IGFLEJNLOMM>();

		// Token: 0x0400391B RID: 14619
		public const int MessageGroupStatusFieldNumber = 1147;

		// Token: 0x0400391C RID: 14620
		private static readonly FieldCodec<GroupStatus> _repeated_messageGroupStatus_codec = FieldCodec.ForMessage<GroupStatus>(9178U, GroupStatus.Parser);

		// Token: 0x0400391D RID: 14621
		private readonly RepeatedField<GroupStatus> messageGroupStatus_ = new RepeatedField<GroupStatus>();

		// Token: 0x0400391E RID: 14622
		public const int IKLEOCENKJGFieldNumber = 1328;

		// Token: 0x0400391F RID: 14623
		private ItemList iKLEOCENKJG_;

		// Token: 0x04003920 RID: 14624
		public const int MultiPathAvatarInfoListFieldNumber = 102;

		// Token: 0x04003921 RID: 14625
		private static readonly FieldCodec<MultiPathAvatarInfo> _repeated_multiPathAvatarInfoList_codec = FieldCodec.ForMessage<MultiPathAvatarInfo>(818U, MultiPathAvatarInfo.Parser);

		// Token: 0x04003922 RID: 14626
		private readonly RepeatedField<MultiPathAvatarInfo> multiPathAvatarInfoList_ = new RepeatedField<MultiPathAvatarInfo>();

		// Token: 0x04003923 RID: 14627
		public const int AvatarSyncFieldNumber = 8;

		// Token: 0x04003924 RID: 14628
		private AvatarSync avatarSync_;

		// Token: 0x04003925 RID: 14629
		public const int WaitDelResourceListFieldNumber = 15;

		// Token: 0x04003926 RID: 14630
		private static readonly FieldCodec<WaitDelResource> _repeated_waitDelResourceList_codec = FieldCodec.ForMessage<WaitDelResource>(122U, WaitDelResource.Parser);

		// Token: 0x04003927 RID: 14631
		private readonly RepeatedField<WaitDelResource> waitDelResourceList_ = new RepeatedField<WaitDelResource>();

		// Token: 0x04003928 RID: 14632
		public const int BasicInfoFieldNumber = 5;

		// Token: 0x04003929 RID: 14633
		private PlayerBasicInfo basicInfo_;

		// Token: 0x0400392A RID: 14634
		public const int QuestListFieldNumber = 6;

		// Token: 0x0400392B RID: 14635
		private static readonly FieldCodec<Quest> _repeated_questList_codec = FieldCodec.ForMessage<Quest>(50U, Quest.Parser);

		// Token: 0x0400392C RID: 14636
		private readonly RepeatedField<Quest> questList_ = new RepeatedField<Quest>();

		// Token: 0x0400392D RID: 14637
		public const int RelicListFieldNumber = 3;

		// Token: 0x0400392E RID: 14638
		private static readonly FieldCodec<Relic> _repeated_relicList_codec = FieldCodec.ForMessage<Relic>(26U, Relic.Parser);

		// Token: 0x0400392F RID: 14639
		private readonly RepeatedField<Relic> relicList_ = new RepeatedField<Relic>();

		// Token: 0x04003930 RID: 14640
		public const int DelRelicListFieldNumber = 7;

		// Token: 0x04003931 RID: 14641
		private static readonly FieldCodec<uint> _repeated_delRelicList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04003932 RID: 14642
		private readonly RepeatedField<uint> delRelicList_ = new RepeatedField<uint>();
	}
}
