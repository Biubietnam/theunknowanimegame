using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003AD RID: 941
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DisplayAvatarDetailInfo : IMessage<DisplayAvatarDetailInfo>, IMessage, IEquatable<DisplayAvatarDetailInfo>, IDeepCloneable<DisplayAvatarDetailInfo>, IBufferMessage
	{
		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x00074237 File Offset: 0x00072437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DisplayAvatarDetailInfo> Parser
		{
			get
			{
				return DisplayAvatarDetailInfo._parser;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060029CB RID: 10699 RVA: 0x0007423E File Offset: 0x0007243E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DisplayAvatarDetailInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x00074250 File Offset: 0x00072450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DisplayAvatarDetailInfo.Descriptor;
			}
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00074257 File Offset: 0x00072457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarDetailInfo()
		{
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00074278 File Offset: 0x00072478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarDetailInfo(DisplayAvatarDetailInfo other) : this()
		{
			this.rank_ = other.rank_;
			this.exp_ = other.exp_;
			this.dressedSkinId_ = other.dressedSkinId_;
			this.avatarId_ = other.avatarId_;
			this.relicList_ = other.relicList_.Clone();
			this.pos_ = other.pos_;
			this.skilltreeList_ = other.skilltreeList_.Clone();
			this.promotion_ = other.promotion_;
			this.level_ = other.level_;
			this.equipment_ = ((other.equipment_ != null) ? other.equipment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x0007432E File Offset: 0x0007252E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarDetailInfo Clone()
		{
			return new DisplayAvatarDetailInfo(this);
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x00074336 File Offset: 0x00072536
		// (set) Token: 0x060029D1 RID: 10705 RVA: 0x0007433E File Offset: 0x0007253E
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

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060029D2 RID: 10706 RVA: 0x00074347 File Offset: 0x00072547
		// (set) Token: 0x060029D3 RID: 10707 RVA: 0x0007434F File Offset: 0x0007254F
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

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x00074358 File Offset: 0x00072558
		// (set) Token: 0x060029D5 RID: 10709 RVA: 0x00074360 File Offset: 0x00072560
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

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x00074369 File Offset: 0x00072569
		// (set) Token: 0x060029D7 RID: 10711 RVA: 0x00074371 File Offset: 0x00072571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x0007437A File Offset: 0x0007257A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DisplayRelicInfo> RelicList
		{
			get
			{
				return this.relicList_;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x00074382 File Offset: 0x00072582
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x0007438A File Offset: 0x0007258A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x00074393 File Offset: 0x00072593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AvatarSkillTree> SkilltreeList
		{
			get
			{
				return this.skilltreeList_;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x0007439B File Offset: 0x0007259B
		// (set) Token: 0x060029DD RID: 10717 RVA: 0x000743A3 File Offset: 0x000725A3
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

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060029DE RID: 10718 RVA: 0x000743AC File Offset: 0x000725AC
		// (set) Token: 0x060029DF RID: 10719 RVA: 0x000743B4 File Offset: 0x000725B4
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

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060029E0 RID: 10720 RVA: 0x000743BD File Offset: 0x000725BD
		// (set) Token: 0x060029E1 RID: 10721 RVA: 0x000743C5 File Offset: 0x000725C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayEquipmentInfo Equipment
		{
			get
			{
				return this.equipment_;
			}
			set
			{
				this.equipment_ = value;
			}
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000743CE File Offset: 0x000725CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DisplayAvatarDetailInfo);
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000743DC File Offset: 0x000725DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DisplayAvatarDetailInfo other)
		{
			return other != null && (other == this || (this.Rank == other.Rank && this.Exp == other.Exp && this.DressedSkinId == other.DressedSkinId && this.AvatarId == other.AvatarId && this.relicList_.Equals(other.relicList_) && this.Pos == other.Pos && this.skilltreeList_.Equals(other.skilltreeList_) && this.Promotion == other.Promotion && this.Level == other.Level && object.Equals(this.Equipment, other.Equipment) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000744B4 File Offset: 0x000726B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.DressedSkinId != 0U)
			{
				num ^= this.DressedSkinId.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			num ^= this.relicList_.GetHashCode();
			if (this.Pos != 0U)
			{
				num ^= this.Pos.GetHashCode();
			}
			num ^= this.skilltreeList_.GetHashCode();
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.equipment_ != null)
			{
				num ^= this.Equipment.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x000745BB File Offset: 0x000727BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000745C3 File Offset: 0x000727C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x000745CC File Offset: 0x000727CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Pos != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Pos);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.equipment_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Equipment);
			}
			if (this.Rank != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Rank);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Level);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Promotion);
			}
			if (this.DressedSkinId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.DressedSkinId);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Exp);
			}
			this.relicList_.WriteTo(ref output, DisplayAvatarDetailInfo._repeated_relicList_codec);
			this.skilltreeList_.WriteTo(ref output, DisplayAvatarDetailInfo._repeated_skilltreeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x000746F0 File Offset: 0x000728F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.DressedSkinId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DressedSkinId);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			num += this.relicList_.CalculateSize(DisplayAvatarDetailInfo._repeated_relicList_codec);
			if (this.Pos != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Pos);
			}
			num += this.skilltreeList_.CalculateSize(DisplayAvatarDetailInfo._repeated_skilltreeList_codec);
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.equipment_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Equipment);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x000747FC File Offset: 0x000729FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DisplayAvatarDetailInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.DressedSkinId != 0U)
			{
				this.DressedSkinId = other.DressedSkinId;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this.relicList_.Add(other.relicList_);
			if (other.Pos != 0U)
			{
				this.Pos = other.Pos;
			}
			this.skilltreeList_.Add(other.skilltreeList_);
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.equipment_ != null)
			{
				if (this.equipment_ == null)
				{
					this.Equipment = new DisplayEquipmentInfo();
				}
				this.Equipment.MergeFrom(other.Equipment);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x000748FE File Offset: 0x00072AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x00074908 File Offset: 0x00072B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Pos = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.AvatarId = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							if (this.equipment_ == null)
							{
								this.Equipment = new DisplayEquipmentInfo();
							}
							input.ReadMessage(this.Equipment);
							continue;
						}
						if (num == 64U)
						{
							this.Rank = input.ReadUInt32();
							continue;
						}
						if (num == 72U)
						{
							this.Level = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 80U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.DressedSkinId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						this.relicList_.AddEntriesFrom(ref input, DisplayAvatarDetailInfo._repeated_relicList_codec);
						continue;
					}
					if (num == 122U)
					{
						this.skilltreeList_.AddEntriesFrom(ref input, DisplayAvatarDetailInfo._repeated_skilltreeList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040010D8 RID: 4312
		private static readonly MessageParser<DisplayAvatarDetailInfo> _parser = new MessageParser<DisplayAvatarDetailInfo>(() => new DisplayAvatarDetailInfo());

		// Token: 0x040010D9 RID: 4313
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010DA RID: 4314
		public const int RankFieldNumber = 8;

		// Token: 0x040010DB RID: 4315
		private uint rank_;

		// Token: 0x040010DC RID: 4316
		public const int ExpFieldNumber = 13;

		// Token: 0x040010DD RID: 4317
		private uint exp_;

		// Token: 0x040010DE RID: 4318
		public const int DressedSkinIdFieldNumber = 12;

		// Token: 0x040010DF RID: 4319
		private uint dressedSkinId_;

		// Token: 0x040010E0 RID: 4320
		public const int AvatarIdFieldNumber = 2;

		// Token: 0x040010E1 RID: 4321
		private uint avatarId_;

		// Token: 0x040010E2 RID: 4322
		public const int RelicListFieldNumber = 14;

		// Token: 0x040010E3 RID: 4323
		private static readonly FieldCodec<DisplayRelicInfo> _repeated_relicList_codec = FieldCodec.ForMessage<DisplayRelicInfo>(114U, DisplayRelicInfo.Parser);

		// Token: 0x040010E4 RID: 4324
		private readonly RepeatedField<DisplayRelicInfo> relicList_ = new RepeatedField<DisplayRelicInfo>();

		// Token: 0x040010E5 RID: 4325
		public const int PosFieldNumber = 1;

		// Token: 0x040010E6 RID: 4326
		private uint pos_;

		// Token: 0x040010E7 RID: 4327
		public const int SkilltreeListFieldNumber = 15;

		// Token: 0x040010E8 RID: 4328
		private static readonly FieldCodec<AvatarSkillTree> _repeated_skilltreeList_codec = FieldCodec.ForMessage<AvatarSkillTree>(122U, AvatarSkillTree.Parser);

		// Token: 0x040010E9 RID: 4329
		private readonly RepeatedField<AvatarSkillTree> skilltreeList_ = new RepeatedField<AvatarSkillTree>();

		// Token: 0x040010EA RID: 4330
		public const int PromotionFieldNumber = 10;

		// Token: 0x040010EB RID: 4331
		private uint promotion_;

		// Token: 0x040010EC RID: 4332
		public const int LevelFieldNumber = 9;

		// Token: 0x040010ED RID: 4333
		private uint level_;

		// Token: 0x040010EE RID: 4334
		public const int EquipmentFieldNumber = 3;

		// Token: 0x040010EF RID: 4335
		private DisplayEquipmentInfo equipment_;
	}
}
