using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000BB RID: 187
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Avatar : IMessage<Avatar>, IMessage, IEquatable<Avatar>, IDeepCloneable<Avatar>, IBufferMessage
	{
		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00016A35 File Offset: 0x00014C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Avatar> Parser
		{
			get
			{
				return Avatar._parser;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00016A3C File Offset: 0x00014C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00016A4E File Offset: 0x00014C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Avatar.Descriptor;
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00016A55 File Offset: 0x00014C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Avatar()
		{
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00016A80 File Offset: 0x00014C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Avatar(Avatar other) : this()
		{
			this.exp_ = other.exp_;
			this.skilltreeList_ = other.skilltreeList_.Clone();
			this.dressedSkinId_ = other.dressedSkinId_;
			this.rank_ = other.rank_;
			this.level_ = other.level_;
			this.promotion_ = other.promotion_;
			this.hasTakenPromotionRewardList_ = other.hasTakenPromotionRewardList_.Clone();
			this.equipmentUniqueId_ = other.equipmentUniqueId_;
			this.baseAvatarId_ = other.baseAvatarId_;
			this.firstMetTimeStamp_ = other.firstMetTimeStamp_;
			this.isMarked_ = other.isMarked_;
			this.equipRelicList_ = other.equipRelicList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00016B43 File Offset: 0x00014D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Avatar Clone()
		{
			return new Avatar(this);
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00016B4B File Offset: 0x00014D4B
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00016B53 File Offset: 0x00014D53
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

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00016B5C File Offset: 0x00014D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AvatarSkillTree> SkilltreeList
		{
			get
			{
				return this.skilltreeList_;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00016B64 File Offset: 0x00014D64
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00016B6C File Offset: 0x00014D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DressedSkinId
		{
			get
			{
				return this.dressedSkinId_;
			}
			set
			{
				this.dressedSkinId_ = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00016B75 File Offset: 0x00014D75
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00016B7D File Offset: 0x00014D7D
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

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00016B86 File Offset: 0x00014D86
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00016B8E File Offset: 0x00014D8E
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00016B97 File Offset: 0x00014D97
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00016B9F File Offset: 0x00014D9F
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00016BA8 File Offset: 0x00014DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HasTakenPromotionRewardList
		{
			get
			{
				return this.hasTakenPromotionRewardList_;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00016BB0 File Offset: 0x00014DB0
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00016BB8 File Offset: 0x00014DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EquipmentUniqueId
		{
			get
			{
				return this.equipmentUniqueId_;
			}
			set
			{
				this.equipmentUniqueId_ = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00016BC1 File Offset: 0x00014DC1
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00016BC9 File Offset: 0x00014DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00016BD2 File Offset: 0x00014DD2
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x00016BDA File Offset: 0x00014DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong FirstMetTimeStamp
		{
			get
			{
				return this.firstMetTimeStamp_;
			}
			set
			{
				this.firstMetTimeStamp_ = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00016BE3 File Offset: 0x00014DE3
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00016BEB File Offset: 0x00014DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMarked
		{
			get
			{
				return this.isMarked_;
			}
			set
			{
				this.isMarked_ = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00016BF4 File Offset: 0x00014DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EquipRelic> EquipRelicList
		{
			get
			{
				return this.equipRelicList_;
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00016BFC File Offset: 0x00014DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Avatar);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00016C0C File Offset: 0x00014E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Avatar other)
		{
			return other != null && (other == this || (this.Exp == other.Exp && this.skilltreeList_.Equals(other.skilltreeList_) && this.DressedSkinId == other.DressedSkinId && this.Rank == other.Rank && this.Level == other.Level && this.Promotion == other.Promotion && this.hasTakenPromotionRewardList_.Equals(other.hasTakenPromotionRewardList_) && this.EquipmentUniqueId == other.EquipmentUniqueId && this.BaseAvatarId == other.BaseAvatarId && this.FirstMetTimeStamp == other.FirstMetTimeStamp && this.IsMarked == other.IsMarked && this.equipRelicList_.Equals(other.equipRelicList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00016D04 File Offset: 0x00014F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			num ^= this.skilltreeList_.GetHashCode();
			if (this.DressedSkinId != 0U)
			{
				num ^= this.DressedSkinId.GetHashCode();
			}
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			num ^= this.hasTakenPromotionRewardList_.GetHashCode();
			if (this.EquipmentUniqueId != 0U)
			{
				num ^= this.EquipmentUniqueId.GetHashCode();
			}
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this.FirstMetTimeStamp != 0UL)
			{
				num ^= this.FirstMetTimeStamp.GetHashCode();
			}
			if (this.IsMarked)
			{
				num ^= this.IsMarked.GetHashCode();
			}
			num ^= this.equipRelicList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00016E35 File Offset: 0x00015035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00016E3D File Offset: 0x0001503D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00016E48 File Offset: 0x00015048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Exp != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Exp);
			}
			if (this.DressedSkinId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.DressedSkinId);
			}
			this.skilltreeList_.WriteTo(ref output, Avatar._repeated_skilltreeList_codec);
			if (this.Level != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Level);
			}
			if (this.IsMarked)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsMarked);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Promotion);
			}
			if (this.Rank != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Rank);
			}
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.BaseAvatarId);
			}
			this.hasTakenPromotionRewardList_.WriteTo(ref output, Avatar._repeated_hasTakenPromotionRewardList_codec);
			this.equipRelicList_.WriteTo(ref output, Avatar._repeated_equipRelicList_codec);
			if (this.FirstMetTimeStamp != 0UL)
			{
				output.WriteRawTag(104);
				output.WriteUInt64(this.FirstMetTimeStamp);
			}
			if (this.EquipmentUniqueId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.EquipmentUniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00016F98 File Offset: 0x00015198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			num += this.skilltreeList_.CalculateSize(Avatar._repeated_skilltreeList_codec);
			if (this.DressedSkinId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DressedSkinId);
			}
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			num += this.hasTakenPromotionRewardList_.CalculateSize(Avatar._repeated_hasTakenPromotionRewardList_codec);
			if (this.EquipmentUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EquipmentUniqueId);
			}
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this.FirstMetTimeStamp != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.FirstMetTimeStamp);
			}
			if (this.IsMarked)
			{
				num += 2;
			}
			num += this.equipRelicList_.CalculateSize(Avatar._repeated_equipRelicList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000170C4 File Offset: 0x000152C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Avatar other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			this.skilltreeList_.Add(other.skilltreeList_);
			if (other.DressedSkinId != 0U)
			{
				this.DressedSkinId = other.DressedSkinId;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			this.hasTakenPromotionRewardList_.Add(other.hasTakenPromotionRewardList_);
			if (other.EquipmentUniqueId != 0U)
			{
				this.EquipmentUniqueId = other.EquipmentUniqueId;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			if (other.FirstMetTimeStamp != 0UL)
			{
				this.FirstMetTimeStamp = other.FirstMetTimeStamp;
			}
			if (other.IsMarked)
			{
				this.IsMarked = other.IsMarked;
			}
			this.equipRelicList_.Add(other.equipRelicList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000171D3 File Offset: 0x000153D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000171DC File Offset: 0x000153DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 64U)
				{
					if (num <= 88U)
					{
						if (num == 72U)
						{
							this.Rank = input.ReadUInt32();
							continue;
						}
						if (num == 80U)
						{
							this.BaseAvatarId = input.ReadUInt32();
							continue;
						}
						if (num != 88U)
						{
							goto IL_88;
						}
					}
					else if (num <= 98U)
					{
						if (num != 90U)
						{
							if (num != 98U)
							{
								goto IL_88;
							}
							this.equipRelicList_.AddEntriesFrom(ref input, Avatar._repeated_equipRelicList_codec);
							continue;
						}
					}
					else
					{
						if (num == 104U)
						{
							this.FirstMetTimeStamp = input.ReadUInt64();
							continue;
						}
						if (num != 120U)
						{
							goto IL_88;
						}
						this.EquipmentUniqueId = input.ReadUInt32();
						continue;
					}
					this.hasTakenPromotionRewardList_.AddEntriesFrom(ref input, Avatar._repeated_hasTakenPromotionRewardList_codec);
					continue;
				}
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.DressedSkinId = input.ReadUInt32();
						continue;
					}
					if (num == 26U)
					{
						this.skilltreeList_.AddEntriesFrom(ref input, Avatar._repeated_skilltreeList_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.IsMarked = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
				}
				IL_88:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000302 RID: 770
		private static readonly MessageParser<Avatar> _parser = new MessageParser<Avatar>(() => new Avatar());

		// Token: 0x04000303 RID: 771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000304 RID: 772
		public const int ExpFieldNumber = 1;

		// Token: 0x04000305 RID: 773
		private uint exp_;

		// Token: 0x04000306 RID: 774
		public const int SkilltreeListFieldNumber = 3;

		// Token: 0x04000307 RID: 775
		private static readonly FieldCodec<AvatarSkillTree> _repeated_skilltreeList_codec = FieldCodec.ForMessage<AvatarSkillTree>(26U, AvatarSkillTree.Parser);

		// Token: 0x04000308 RID: 776
		private readonly RepeatedField<AvatarSkillTree> skilltreeList_ = new RepeatedField<AvatarSkillTree>();

		// Token: 0x04000309 RID: 777
		public const int DressedSkinIdFieldNumber = 2;

		// Token: 0x0400030A RID: 778
		private uint dressedSkinId_;

		// Token: 0x0400030B RID: 779
		public const int RankFieldNumber = 9;

		// Token: 0x0400030C RID: 780
		private uint rank_;

		// Token: 0x0400030D RID: 781
		public const int LevelFieldNumber = 5;

		// Token: 0x0400030E RID: 782
		private uint level_;

		// Token: 0x0400030F RID: 783
		public const int PromotionFieldNumber = 8;

		// Token: 0x04000310 RID: 784
		private uint promotion_;

		// Token: 0x04000311 RID: 785
		public const int HasTakenPromotionRewardListFieldNumber = 11;

		// Token: 0x04000312 RID: 786
		private static readonly FieldCodec<uint> _repeated_hasTakenPromotionRewardList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04000313 RID: 787
		private readonly RepeatedField<uint> hasTakenPromotionRewardList_ = new RepeatedField<uint>();

		// Token: 0x04000314 RID: 788
		public const int EquipmentUniqueIdFieldNumber = 15;

		// Token: 0x04000315 RID: 789
		private uint equipmentUniqueId_;

		// Token: 0x04000316 RID: 790
		public const int BaseAvatarIdFieldNumber = 10;

		// Token: 0x04000317 RID: 791
		private uint baseAvatarId_;

		// Token: 0x04000318 RID: 792
		public const int FirstMetTimeStampFieldNumber = 13;

		// Token: 0x04000319 RID: 793
		private ulong firstMetTimeStamp_;

		// Token: 0x0400031A RID: 794
		public const int IsMarkedFieldNumber = 7;

		// Token: 0x0400031B RID: 795
		private bool isMarked_;

		// Token: 0x0400031C RID: 796
		public const int EquipRelicListFieldNumber = 12;

		// Token: 0x0400031D RID: 797
		private static readonly FieldCodec<EquipRelic> _repeated_equipRelicList_codec = FieldCodec.ForMessage<EquipRelic>(98U, EquipRelic.Parser);

		// Token: 0x0400031E RID: 798
		private readonly RepeatedField<EquipRelic> equipRelicList_ = new RepeatedField<EquipRelic>();
	}
}
