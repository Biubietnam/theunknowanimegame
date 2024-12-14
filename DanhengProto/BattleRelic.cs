using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000F3 RID: 243
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleRelic : IMessage<BattleRelic>, IMessage, IEquatable<BattleRelic>, IDeepCloneable<BattleRelic>, IBufferMessage
	{
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00020193 File Offset: 0x0001E393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleRelic> Parser
		{
			get
			{
				return BattleRelic._parser;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0002019A File Offset: 0x0001E39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleRelicReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x000201AC File Offset: 0x0001E3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleRelic.Descriptor;
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000201B3 File Offset: 0x0001E3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRelic()
		{
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000201C8 File Offset: 0x0001E3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRelic(BattleRelic other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.mainAffixId_ = other.mainAffixId_;
			this.subAffixList_ = other.subAffixList_.Clone();
			this.uniqueId_ = other.uniqueId_;
			this.setId_ = other.setId_;
			this.type_ = other.type_;
			this.rarity_ = other.rarity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00020251 File Offset: 0x0001E451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRelic Clone()
		{
			return new BattleRelic(this);
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00020259 File Offset: 0x0001E459
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00020261 File Offset: 0x0001E461
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

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0002026A File Offset: 0x0001E46A
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x00020272 File Offset: 0x0001E472
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0002027B File Offset: 0x0001E47B
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x00020283 File Offset: 0x0001E483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainAffixId
		{
			get
			{
				return this.mainAffixId_;
			}
			set
			{
				this.mainAffixId_ = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0002028C File Offset: 0x0001E48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RelicAffix> SubAffixList
		{
			get
			{
				return this.subAffixList_;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00020294 File Offset: 0x0001E494
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x0002029C File Offset: 0x0001E49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x000202A5 File Offset: 0x0001E4A5
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x000202AD File Offset: 0x0001E4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SetId
		{
			get
			{
				return this.setId_;
			}
			set
			{
				this.setId_ = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x000202B6 File Offset: 0x0001E4B6
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x000202BE File Offset: 0x0001E4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x000202C7 File Offset: 0x0001E4C7
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x000202CF File Offset: 0x0001E4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Rarity
		{
			get
			{
				return this.rarity_;
			}
			set
			{
				this.rarity_ = value;
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000202D8 File Offset: 0x0001E4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleRelic);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x000202E8 File Offset: 0x0001E4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleRelic other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.MainAffixId == other.MainAffixId && this.subAffixList_.Equals(other.subAffixList_) && this.UniqueId == other.UniqueId && this.SetId == other.SetId && this.Type == other.Type && this.Rarity == other.Rarity && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00020398 File Offset: 0x0001E598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MainAffixId != 0U)
			{
				num ^= this.MainAffixId.GetHashCode();
			}
			num ^= this.subAffixList_.GetHashCode();
			if (this.UniqueId != 0U)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this.SetId != 0U)
			{
				num ^= this.SetId.GetHashCode();
			}
			if (this.Type != 0U)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Rarity != 0U)
			{
				num ^= this.Rarity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0002047B File Offset: 0x0001E67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00020483 File Offset: 0x0001E683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0002048C File Offset: 0x0001E68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.MainAffixId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MainAffixId);
			}
			this.subAffixList_.WriteTo(ref output, BattleRelic._repeated_subAffixList_codec);
			if (this.UniqueId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.UniqueId);
			}
			if (this.SetId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.SetId);
			}
			if (this.Type != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Type);
			}
			if (this.Rarity != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Rarity);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00020584 File Offset: 0x0001E784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.MainAffixId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainAffixId);
			}
			num += this.subAffixList_.CalculateSize(BattleRelic._repeated_subAffixList_codec);
			if (this.UniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UniqueId);
			}
			if (this.SetId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SetId);
			}
			if (this.Type != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			if (this.Rarity != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rarity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00020668 File Offset: 0x0001E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleRelic other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.MainAffixId != 0U)
			{
				this.MainAffixId = other.MainAffixId;
			}
			this.subAffixList_.Add(other.subAffixList_);
			if (other.UniqueId != 0U)
			{
				this.UniqueId = other.UniqueId;
			}
			if (other.SetId != 0U)
			{
				this.SetId = other.SetId;
			}
			if (other.Type != 0U)
			{
				this.Type = other.Type;
			}
			if (other.Rarity != 0U)
			{
				this.Rarity = other.Rarity;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0002072D File Offset: 0x0001E92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00020738 File Offset: 0x0001E938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Level = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.MainAffixId = input.ReadUInt32();
							continue;
						}
						if (num == 34U)
						{
							this.subAffixList_.AddEntriesFrom(ref input, BattleRelic._repeated_subAffixList_codec);
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.UniqueId = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.SetId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Type = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Rarity = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400048F RID: 1167
		private static readonly MessageParser<BattleRelic> _parser = new MessageParser<BattleRelic>(() => new BattleRelic());

		// Token: 0x04000490 RID: 1168
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000491 RID: 1169
		public const int IdFieldNumber = 1;

		// Token: 0x04000492 RID: 1170
		private uint id_;

		// Token: 0x04000493 RID: 1171
		public const int LevelFieldNumber = 2;

		// Token: 0x04000494 RID: 1172
		private uint level_;

		// Token: 0x04000495 RID: 1173
		public const int MainAffixIdFieldNumber = 3;

		// Token: 0x04000496 RID: 1174
		private uint mainAffixId_;

		// Token: 0x04000497 RID: 1175
		public const int SubAffixListFieldNumber = 4;

		// Token: 0x04000498 RID: 1176
		private static readonly FieldCodec<RelicAffix> _repeated_subAffixList_codec = FieldCodec.ForMessage<RelicAffix>(34U, RelicAffix.Parser);

		// Token: 0x04000499 RID: 1177
		private readonly RepeatedField<RelicAffix> subAffixList_ = new RepeatedField<RelicAffix>();

		// Token: 0x0400049A RID: 1178
		public const int UniqueIdFieldNumber = 5;

		// Token: 0x0400049B RID: 1179
		private uint uniqueId_;

		// Token: 0x0400049C RID: 1180
		public const int SetIdFieldNumber = 6;

		// Token: 0x0400049D RID: 1181
		private uint setId_;

		// Token: 0x0400049E RID: 1182
		public const int TypeFieldNumber = 7;

		// Token: 0x0400049F RID: 1183
		private uint type_;

		// Token: 0x040004A0 RID: 1184
		public const int RarityFieldNumber = 8;

		// Token: 0x040004A1 RID: 1185
		private uint rarity_;
	}
}
