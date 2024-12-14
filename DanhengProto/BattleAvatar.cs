using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000D9 RID: 217
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleAvatar : IMessage<BattleAvatar>, IMessage, IEquatable<BattleAvatar>, IDeepCloneable<BattleAvatar>, IBufferMessage
	{
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0001C533 File Offset: 0x0001A733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleAvatar> Parser
		{
			get
			{
				return BattleAvatar._parser;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0001C53A File Offset: 0x0001A73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleAvatarReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0001C54C File Offset: 0x0001A74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleAvatar.Descriptor;
			}
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0001C553 File Offset: 0x0001A753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleAvatar()
		{
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0001C57C File Offset: 0x0001A77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleAvatar(BattleAvatar other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.rank_ = other.rank_;
			this.index_ = other.index_;
			this.skilltreeList_ = other.skilltreeList_.Clone();
			this.equipmentList_ = other.equipmentList_.Clone();
			this.hp_ = other.hp_;
			this.promotion_ = other.promotion_;
			this.relicList_ = other.relicList_.Clone();
			this.worldLevel_ = other.worldLevel_;
			this.assistUid_ = other.assistUid_;
			this.mBPNICPIMHH_ = ((other.mBPNICPIMHH_ != null) ? other.mBPNICPIMHH_.Clone() : null);
			this.spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
			this.mKJKMMIOCHB_ = other.mKJKMMIOCHB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0001C683 File Offset: 0x0001A883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleAvatar Clone()
		{
			return new BattleAvatar(this);
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0001C68B File Offset: 0x0001A88B
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x0001C693 File Offset: 0x0001A893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0001C69C File Offset: 0x0001A89C
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0001C6A4 File Offset: 0x0001A8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0001C6AD File Offset: 0x0001A8AD
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x0001C6B5 File Offset: 0x0001A8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0001C6BE File Offset: 0x0001A8BE
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x0001C6C6 File Offset: 0x0001A8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0001C6CF File Offset: 0x0001A8CF
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0001C6D7 File Offset: 0x0001A8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AvatarSkillTree> SkilltreeList
		{
			get
			{
				return this.skilltreeList_;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0001C6E8 File Offset: 0x0001A8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleEquipment> EquipmentList
		{
			get
			{
				return this.equipmentList_;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x0001C6F8 File Offset: 0x0001A8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Hp
		{
			get
			{
				return this.hp_;
			}
			set
			{
				this.hp_ = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0001C701 File Offset: 0x0001A901
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x0001C709 File Offset: 0x0001A909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Promotion
		{
			get
			{
				return this.promotion_;
			}
			set
			{
				this.promotion_ = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0001C712 File Offset: 0x0001A912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleRelic> RelicList
		{
			get
			{
				return this.relicList_;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0001C71A File Offset: 0x0001A91A
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x0001C722 File Offset: 0x0001A922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0001C72B File Offset: 0x0001A92B
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x0001C733 File Offset: 0x0001A933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AssistUid
		{
			get
			{
				return this.assistUid_;
			}
			set
			{
				this.assistUid_ = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0001C73C File Offset: 0x0001A93C
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x0001C744 File Offset: 0x0001A944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CDCPBIAPMBM MBPNICPIMHH
		{
			get
			{
				return this.mBPNICPIMHH_;
			}
			set
			{
				this.mBPNICPIMHH_ = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0001C74D File Offset: 0x0001A94D
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x0001C755 File Offset: 0x0001A955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpBarInfo SpBar
		{
			get
			{
				return this.spBar_;
			}
			set
			{
				this.spBar_ = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0001C75E File Offset: 0x0001A95E
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0001C766 File Offset: 0x0001A966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MKJKMMIOCHB
		{
			get
			{
				return this.mKJKMMIOCHB_;
			}
			set
			{
				this.mKJKMMIOCHB_ = value;
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0001C76F File Offset: 0x0001A96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleAvatar);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0001C780 File Offset: 0x0001A980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleAvatar other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.Id == other.Id && this.Level == other.Level && this.Rank == other.Rank && this.Index == other.Index && this.skilltreeList_.Equals(other.skilltreeList_) && this.equipmentList_.Equals(other.equipmentList_) && this.Hp == other.Hp && this.Promotion == other.Promotion && this.relicList_.Equals(other.relicList_) && this.WorldLevel == other.WorldLevel && this.AssistUid == other.AssistUid && object.Equals(this.MBPNICPIMHH, other.MBPNICPIMHH) && object.Equals(this.SpBar, other.SpBar) && this.MKJKMMIOCHB == other.MKJKMMIOCHB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0001C8B4 File Offset: 0x0001AAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			num ^= this.skilltreeList_.GetHashCode();
			num ^= this.equipmentList_.GetHashCode();
			if (this.Hp != 0U)
			{
				num ^= this.Hp.GetHashCode();
			}
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			num ^= this.relicList_.GetHashCode();
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.AssistUid != 0U)
			{
				num ^= this.AssistUid.GetHashCode();
			}
			if (this.mBPNICPIMHH_ != null)
			{
				num ^= this.MBPNICPIMHH.GetHashCode();
			}
			if (this.spBar_ != null)
			{
				num ^= this.SpBar.GetHashCode();
			}
			if (this.MKJKMMIOCHB != 0U)
			{
				num ^= this.MKJKMMIOCHB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0001CA30 File Offset: 0x0001AC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0001CA38 File Offset: 0x0001AC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0001CA44 File Offset: 0x0001AC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Id);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Level);
			}
			if (this.Rank != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Rank);
			}
			if (this.Index != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Index);
			}
			this.skilltreeList_.WriteTo(ref output, BattleAvatar._repeated_skilltreeList_codec);
			this.equipmentList_.WriteTo(ref output, BattleAvatar._repeated_equipmentList_codec);
			if (this.Hp != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Hp);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Promotion);
			}
			this.relicList_.WriteTo(ref output, BattleAvatar._repeated_relicList_codec);
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.AssistUid != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.AssistUid);
			}
			if (this.mBPNICPIMHH_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.MBPNICPIMHH);
			}
			if (this.spBar_ != null)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.SpBar);
			}
			if (this.MKJKMMIOCHB != 0U)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.MKJKMMIOCHB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			num += this.skilltreeList_.CalculateSize(BattleAvatar._repeated_skilltreeList_codec);
			num += this.equipmentList_.CalculateSize(BattleAvatar._repeated_equipmentList_codec);
			if (this.Hp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Hp);
			}
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			num += this.relicList_.CalculateSize(BattleAvatar._repeated_relicList_codec);
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.AssistUid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AssistUid);
			}
			if (this.mBPNICPIMHH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MBPNICPIMHH);
			}
			if (this.spBar_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SpBar);
			}
			if (this.MKJKMMIOCHB != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.MKJKMMIOCHB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0001CD70 File Offset: 0x0001AF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleAvatar other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			this.skilltreeList_.Add(other.skilltreeList_);
			this.equipmentList_.Add(other.equipmentList_);
			if (other.Hp != 0U)
			{
				this.Hp = other.Hp;
			}
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			this.relicList_.Add(other.relicList_);
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.AssistUid != 0U)
			{
				this.AssistUid = other.AssistUid;
			}
			if (other.mBPNICPIMHH_ != null)
			{
				if (this.mBPNICPIMHH_ == null)
				{
					this.MBPNICPIMHH = new CDCPBIAPMBM();
				}
				this.MBPNICPIMHH.MergeFrom(other.MBPNICPIMHH);
			}
			if (other.spBar_ != null)
			{
				if (this.spBar_ == null)
				{
					this.SpBar = new SpBarInfo();
				}
				this.SpBar.MergeFrom(other.SpBar);
			}
			if (other.MKJKMMIOCHB != 0U)
			{
				this.MKJKMMIOCHB = other.MKJKMMIOCHB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0001CEEB File Offset: 0x0001B0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0001CEF4 File Offset: 0x0001B0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.AvatarType = (AvatarType)input.ReadEnum();
							continue;
						}
						if (num == 16U)
						{
							this.Id = input.ReadUInt32();
							continue;
						}
						if (num == 24U)
						{
							this.Level = input.ReadUInt32();
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 32U)
						{
							this.Rank = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.Index = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							this.skilltreeList_.AddEntriesFrom(ref input, BattleAvatar._repeated_skilltreeList_codec);
							continue;
						}
						if (num == 58U)
						{
							this.equipmentList_.AddEntriesFrom(ref input, BattleAvatar._repeated_equipmentList_codec);
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num <= 80U)
					{
						if (num == 64U)
						{
							this.Hp = input.ReadUInt32();
							continue;
						}
						if (num == 80U)
						{
							this.Promotion = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 90U)
						{
							this.relicList_.AddEntriesFrom(ref input, BattleAvatar._repeated_relicList_codec);
							continue;
						}
						if (num == 96U)
						{
							this.WorldLevel = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 122U)
				{
					if (num == 104U)
					{
						this.AssistUid = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.mBPNICPIMHH_ == null)
						{
							this.MBPNICPIMHH = new CDCPBIAPMBM();
						}
						input.ReadMessage(this.MBPNICPIMHH);
						continue;
					}
				}
				else
				{
					if (num == 130U)
					{
						if (this.spBar_ == null)
						{
							this.SpBar = new SpBarInfo();
						}
						input.ReadMessage(this.SpBar);
						continue;
					}
					if (num == 136U)
					{
						this.MKJKMMIOCHB = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040003EC RID: 1004
		private static readonly MessageParser<BattleAvatar> _parser = new MessageParser<BattleAvatar>(() => new BattleAvatar());

		// Token: 0x040003ED RID: 1005
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003EE RID: 1006
		public const int AvatarTypeFieldNumber = 1;

		// Token: 0x040003EF RID: 1007
		private AvatarType avatarType_;

		// Token: 0x040003F0 RID: 1008
		public const int IdFieldNumber = 2;

		// Token: 0x040003F1 RID: 1009
		private uint id_;

		// Token: 0x040003F2 RID: 1010
		public const int LevelFieldNumber = 3;

		// Token: 0x040003F3 RID: 1011
		private uint level_;

		// Token: 0x040003F4 RID: 1012
		public const int RankFieldNumber = 4;

		// Token: 0x040003F5 RID: 1013
		private uint rank_;

		// Token: 0x040003F6 RID: 1014
		public const int IndexFieldNumber = 5;

		// Token: 0x040003F7 RID: 1015
		private uint index_;

		// Token: 0x040003F8 RID: 1016
		public const int SkilltreeListFieldNumber = 6;

		// Token: 0x040003F9 RID: 1017
		private static readonly FieldCodec<AvatarSkillTree> _repeated_skilltreeList_codec = FieldCodec.ForMessage<AvatarSkillTree>(50U, AvatarSkillTree.Parser);

		// Token: 0x040003FA RID: 1018
		private readonly RepeatedField<AvatarSkillTree> skilltreeList_ = new RepeatedField<AvatarSkillTree>();

		// Token: 0x040003FB RID: 1019
		public const int EquipmentListFieldNumber = 7;

		// Token: 0x040003FC RID: 1020
		private static readonly FieldCodec<BattleEquipment> _repeated_equipmentList_codec = FieldCodec.ForMessage<BattleEquipment>(58U, BattleEquipment.Parser);

		// Token: 0x040003FD RID: 1021
		private readonly RepeatedField<BattleEquipment> equipmentList_ = new RepeatedField<BattleEquipment>();

		// Token: 0x040003FE RID: 1022
		public const int HpFieldNumber = 8;

		// Token: 0x040003FF RID: 1023
		private uint hp_;

		// Token: 0x04000400 RID: 1024
		public const int PromotionFieldNumber = 10;

		// Token: 0x04000401 RID: 1025
		private uint promotion_;

		// Token: 0x04000402 RID: 1026
		public const int RelicListFieldNumber = 11;

		// Token: 0x04000403 RID: 1027
		private static readonly FieldCodec<BattleRelic> _repeated_relicList_codec = FieldCodec.ForMessage<BattleRelic>(90U, BattleRelic.Parser);

		// Token: 0x04000404 RID: 1028
		private readonly RepeatedField<BattleRelic> relicList_ = new RepeatedField<BattleRelic>();

		// Token: 0x04000405 RID: 1029
		public const int WorldLevelFieldNumber = 12;

		// Token: 0x04000406 RID: 1030
		private uint worldLevel_;

		// Token: 0x04000407 RID: 1031
		public const int AssistUidFieldNumber = 13;

		// Token: 0x04000408 RID: 1032
		private uint assistUid_;

		// Token: 0x04000409 RID: 1033
		public const int MBPNICPIMHHFieldNumber = 15;

		// Token: 0x0400040A RID: 1034
		private CDCPBIAPMBM mBPNICPIMHH_;

		// Token: 0x0400040B RID: 1035
		public const int SpBarFieldNumber = 16;

		// Token: 0x0400040C RID: 1036
		private SpBarInfo spBar_;

		// Token: 0x0400040D RID: 1037
		public const int MKJKMMIOCHBFieldNumber = 17;

		// Token: 0x0400040E RID: 1038
		private uint mKJKMMIOCHB_;
	}
}
