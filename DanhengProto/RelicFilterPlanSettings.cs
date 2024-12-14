using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DA9 RID: 3497
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RelicFilterPlanSettings : IMessage<RelicFilterPlanSettings>, IMessage, IEquatable<RelicFilterPlanSettings>, IDeepCloneable<RelicFilterPlanSettings>, IBufferMessage
	{
		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x06009C4B RID: 40011 RVA: 0x001A0100 File Offset: 0x0019E300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RelicFilterPlanSettings> Parser
		{
			get
			{
				return RelicFilterPlanSettings._parser;
			}
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x06009C4C RID: 40012 RVA: 0x001A0107 File Offset: 0x0019E307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicFilterPlanSettingsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x06009C4D RID: 40013 RVA: 0x001A0119 File Offset: 0x0019E319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelicFilterPlanSettings.Descriptor;
			}
		}

		// Token: 0x06009C4E RID: 40014 RVA: 0x001A0120 File Offset: 0x0019E320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanSettings()
		{
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x001A018C File Offset: 0x0019E38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanSettings(RelicFilterPlanSettings other) : this()
		{
			this.rarityBitset_ = other.rarityBitset_;
			this.relicSetList_ = other.relicSetList_.Clone();
			this.bodyMainPropertyList_ = other.bodyMainPropertyList_.Clone();
			this.footMainPropertyList_ = other.footMainPropertyList_.Clone();
			this.sphereMainPropertyList_ = other.sphereMainPropertyList_.Clone();
			this.ropeMainPropertyList_ = other.ropeMainPropertyList_.Clone();
			this.isIncludeFilterSubProperty_ = other.isIncludeFilterSubProperty_;
			this.subPropertyNum_ = other.subPropertyNum_;
			this.subPropertyList_ = other.subPropertyList_.Clone();
			this.headMainPropertyList_ = other.headMainPropertyList_.Clone();
			this.handMainPropertyList_ = other.handMainPropertyList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x001A025C File Offset: 0x0019E45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanSettings Clone()
		{
			return new RelicFilterPlanSettings(this);
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x06009C51 RID: 40017 RVA: 0x001A0264 File Offset: 0x0019E464
		// (set) Token: 0x06009C52 RID: 40018 RVA: 0x001A026C File Offset: 0x0019E46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RarityBitset
		{
			get
			{
				return this.rarityBitset_;
			}
			set
			{
				this.rarityBitset_ = value;
			}
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x06009C53 RID: 40019 RVA: 0x001A0275 File Offset: 0x0019E475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> RelicSetList
		{
			get
			{
				return this.relicSetList_;
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x06009C54 RID: 40020 RVA: 0x001A027D File Offset: 0x0019E47D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BodyMainPropertyList
		{
			get
			{
				return this.bodyMainPropertyList_;
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x06009C55 RID: 40021 RVA: 0x001A0285 File Offset: 0x0019E485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FootMainPropertyList
		{
			get
			{
				return this.footMainPropertyList_;
			}
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x06009C56 RID: 40022 RVA: 0x001A028D File Offset: 0x0019E48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SphereMainPropertyList
		{
			get
			{
				return this.sphereMainPropertyList_;
			}
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x06009C57 RID: 40023 RVA: 0x001A0295 File Offset: 0x0019E495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> RopeMainPropertyList
		{
			get
			{
				return this.ropeMainPropertyList_;
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x06009C58 RID: 40024 RVA: 0x001A029D File Offset: 0x0019E49D
		// (set) Token: 0x06009C59 RID: 40025 RVA: 0x001A02A5 File Offset: 0x0019E4A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsIncludeFilterSubProperty
		{
			get
			{
				return this.isIncludeFilterSubProperty_;
			}
			set
			{
				this.isIncludeFilterSubProperty_ = value;
			}
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x06009C5A RID: 40026 RVA: 0x001A02AE File Offset: 0x0019E4AE
		// (set) Token: 0x06009C5B RID: 40027 RVA: 0x001A02B6 File Offset: 0x0019E4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SubPropertyNum
		{
			get
			{
				return this.subPropertyNum_;
			}
			set
			{
				this.subPropertyNum_ = value;
			}
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x06009C5C RID: 40028 RVA: 0x001A02BF File Offset: 0x0019E4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SubPropertyList
		{
			get
			{
				return this.subPropertyList_;
			}
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x06009C5D RID: 40029 RVA: 0x001A02C7 File Offset: 0x0019E4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HeadMainPropertyList
		{
			get
			{
				return this.headMainPropertyList_;
			}
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x06009C5E RID: 40030 RVA: 0x001A02CF File Offset: 0x0019E4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HandMainPropertyList
		{
			get
			{
				return this.handMainPropertyList_;
			}
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x001A02D7 File Offset: 0x0019E4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelicFilterPlanSettings);
		}

		// Token: 0x06009C60 RID: 40032 RVA: 0x001A02E8 File Offset: 0x0019E4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelicFilterPlanSettings other)
		{
			return other != null && (other == this || (this.RarityBitset == other.RarityBitset && this.relicSetList_.Equals(other.relicSetList_) && this.bodyMainPropertyList_.Equals(other.bodyMainPropertyList_) && this.footMainPropertyList_.Equals(other.footMainPropertyList_) && this.sphereMainPropertyList_.Equals(other.sphereMainPropertyList_) && this.ropeMainPropertyList_.Equals(other.ropeMainPropertyList_) && this.IsIncludeFilterSubProperty == other.IsIncludeFilterSubProperty && this.SubPropertyNum == other.SubPropertyNum && this.subPropertyList_.Equals(other.subPropertyList_) && this.headMainPropertyList_.Equals(other.headMainPropertyList_) && this.handMainPropertyList_.Equals(other.handMainPropertyList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C61 RID: 40033 RVA: 0x001A03EC File Offset: 0x0019E5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RarityBitset != 0U)
			{
				num ^= this.RarityBitset.GetHashCode();
			}
			num ^= this.relicSetList_.GetHashCode();
			num ^= this.bodyMainPropertyList_.GetHashCode();
			num ^= this.footMainPropertyList_.GetHashCode();
			num ^= this.sphereMainPropertyList_.GetHashCode();
			num ^= this.ropeMainPropertyList_.GetHashCode();
			if (this.IsIncludeFilterSubProperty)
			{
				num ^= this.IsIncludeFilterSubProperty.GetHashCode();
			}
			if (this.SubPropertyNum != 0U)
			{
				num ^= this.SubPropertyNum.GetHashCode();
			}
			num ^= this.subPropertyList_.GetHashCode();
			num ^= this.headMainPropertyList_.GetHashCode();
			num ^= this.handMainPropertyList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C62 RID: 40034 RVA: 0x001A04CD File Offset: 0x0019E6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C63 RID: 40035 RVA: 0x001A04D5 File Offset: 0x0019E6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C64 RID: 40036 RVA: 0x001A04E0 File Offset: 0x0019E6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RarityBitset != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RarityBitset);
			}
			this.relicSetList_.WriteTo(ref output, RelicFilterPlanSettings._repeated_relicSetList_codec);
			this.bodyMainPropertyList_.WriteTo(ref output, RelicFilterPlanSettings._repeated_bodyMainPropertyList_codec);
			this.footMainPropertyList_.WriteTo(ref output, RelicFilterPlanSettings._repeated_footMainPropertyList_codec);
			this.sphereMainPropertyList_.WriteTo(ref output, RelicFilterPlanSettings._repeated_sphereMainPropertyList_codec);
			this.ropeMainPropertyList_.WriteTo(ref output, RelicFilterPlanSettings._repeated_ropeMainPropertyList_codec);
			if (this.IsIncludeFilterSubProperty)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsIncludeFilterSubProperty);
			}
			if (this.SubPropertyNum != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.SubPropertyNum);
			}
			this.subPropertyList_.WriteTo(ref output, RelicFilterPlanSettings._repeated_subPropertyList_codec);
			this.headMainPropertyList_.WriteTo(ref output, RelicFilterPlanSettings._repeated_headMainPropertyList_codec);
			this.handMainPropertyList_.WriteTo(ref output, RelicFilterPlanSettings._repeated_handMainPropertyList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C65 RID: 40037 RVA: 0x001A05DC File Offset: 0x0019E7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RarityBitset != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RarityBitset);
			}
			num += this.relicSetList_.CalculateSize(RelicFilterPlanSettings._repeated_relicSetList_codec);
			num += this.bodyMainPropertyList_.CalculateSize(RelicFilterPlanSettings._repeated_bodyMainPropertyList_codec);
			num += this.footMainPropertyList_.CalculateSize(RelicFilterPlanSettings._repeated_footMainPropertyList_codec);
			num += this.sphereMainPropertyList_.CalculateSize(RelicFilterPlanSettings._repeated_sphereMainPropertyList_codec);
			num += this.ropeMainPropertyList_.CalculateSize(RelicFilterPlanSettings._repeated_ropeMainPropertyList_codec);
			if (this.IsIncludeFilterSubProperty)
			{
				num += 2;
			}
			if (this.SubPropertyNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubPropertyNum);
			}
			num += this.subPropertyList_.CalculateSize(RelicFilterPlanSettings._repeated_subPropertyList_codec);
			num += this.headMainPropertyList_.CalculateSize(RelicFilterPlanSettings._repeated_headMainPropertyList_codec);
			num += this.handMainPropertyList_.CalculateSize(RelicFilterPlanSettings._repeated_handMainPropertyList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C66 RID: 40038 RVA: 0x001A06D8 File Offset: 0x0019E8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelicFilterPlanSettings other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RarityBitset != 0U)
			{
				this.RarityBitset = other.RarityBitset;
			}
			this.relicSetList_.Add(other.relicSetList_);
			this.bodyMainPropertyList_.Add(other.bodyMainPropertyList_);
			this.footMainPropertyList_.Add(other.footMainPropertyList_);
			this.sphereMainPropertyList_.Add(other.sphereMainPropertyList_);
			this.ropeMainPropertyList_.Add(other.ropeMainPropertyList_);
			if (other.IsIncludeFilterSubProperty)
			{
				this.IsIncludeFilterSubProperty = other.IsIncludeFilterSubProperty;
			}
			if (other.SubPropertyNum != 0U)
			{
				this.SubPropertyNum = other.SubPropertyNum;
			}
			this.subPropertyList_.Add(other.subPropertyList_);
			this.headMainPropertyList_.Add(other.headMainPropertyList_);
			this.handMainPropertyList_.Add(other.handMainPropertyList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x001A07C4 File Offset: 0x0019E9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x001A07D0 File Offset: 0x0019E9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 24U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.RarityBitset = input.ReadUInt32();
								continue;
							}
							if (num != 16U)
							{
								goto IL_D3;
							}
						}
						else if (num != 18U)
						{
							if (num != 24U)
							{
								goto IL_D3;
							}
							goto IL_111;
						}
						this.relicSetList_.AddEntriesFrom(ref input, RelicFilterPlanSettings._repeated_relicSetList_codec);
						continue;
					}
					if (num <= 32U)
					{
						if (num == 26U)
						{
							goto IL_111;
						}
						if (num != 32U)
						{
							goto IL_D3;
						}
					}
					else if (num != 34U)
					{
						if (num != 40U && num != 42U)
						{
							goto IL_D3;
						}
						this.sphereMainPropertyList_.AddEntriesFrom(ref input, RelicFilterPlanSettings._repeated_sphereMainPropertyList_codec);
						continue;
					}
					this.footMainPropertyList_.AddEntriesFrom(ref input, RelicFilterPlanSettings._repeated_footMainPropertyList_codec);
					continue;
					IL_111:
					this.bodyMainPropertyList_.AddEntriesFrom(ref input, RelicFilterPlanSettings._repeated_bodyMainPropertyList_codec);
					continue;
				}
				if (num > 72U)
				{
					if (num <= 80U)
					{
						if (num == 74U)
						{
							goto IL_17C;
						}
						if (num != 80U)
						{
							goto IL_D3;
						}
					}
					else if (num != 82U)
					{
						if (num != 88U && num != 90U)
						{
							goto IL_D3;
						}
						this.handMainPropertyList_.AddEntriesFrom(ref input, RelicFilterPlanSettings._repeated_handMainPropertyList_codec);
						continue;
					}
					this.headMainPropertyList_.AddEntriesFrom(ref input, RelicFilterPlanSettings._repeated_headMainPropertyList_codec);
					continue;
				}
				if (num <= 50U)
				{
					if (num != 48U && num != 50U)
					{
						goto IL_D3;
					}
					this.ropeMainPropertyList_.AddEntriesFrom(ref input, RelicFilterPlanSettings._repeated_ropeMainPropertyList_codec);
					continue;
				}
				else
				{
					if (num == 56U)
					{
						this.IsIncludeFilterSubProperty = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.SubPropertyNum = input.ReadUInt32();
						continue;
					}
					if (num != 72U)
					{
						goto IL_D3;
					}
				}
				IL_17C:
				this.subPropertyList_.AddEntriesFrom(ref input, RelicFilterPlanSettings._repeated_subPropertyList_codec);
				continue;
				IL_D3:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003CAB RID: 15531
		private static readonly MessageParser<RelicFilterPlanSettings> _parser = new MessageParser<RelicFilterPlanSettings>(() => new RelicFilterPlanSettings());

		// Token: 0x04003CAC RID: 15532
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CAD RID: 15533
		public const int RarityBitsetFieldNumber = 1;

		// Token: 0x04003CAE RID: 15534
		private uint rarityBitset_;

		// Token: 0x04003CAF RID: 15535
		public const int RelicSetListFieldNumber = 2;

		// Token: 0x04003CB0 RID: 15536
		private static readonly FieldCodec<uint> _repeated_relicSetList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04003CB1 RID: 15537
		private readonly RepeatedField<uint> relicSetList_ = new RepeatedField<uint>();

		// Token: 0x04003CB2 RID: 15538
		public const int BodyMainPropertyListFieldNumber = 3;

		// Token: 0x04003CB3 RID: 15539
		private static readonly FieldCodec<uint> _repeated_bodyMainPropertyList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04003CB4 RID: 15540
		private readonly RepeatedField<uint> bodyMainPropertyList_ = new RepeatedField<uint>();

		// Token: 0x04003CB5 RID: 15541
		public const int FootMainPropertyListFieldNumber = 4;

		// Token: 0x04003CB6 RID: 15542
		private static readonly FieldCodec<uint> _repeated_footMainPropertyList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04003CB7 RID: 15543
		private readonly RepeatedField<uint> footMainPropertyList_ = new RepeatedField<uint>();

		// Token: 0x04003CB8 RID: 15544
		public const int SphereMainPropertyListFieldNumber = 5;

		// Token: 0x04003CB9 RID: 15545
		private static readonly FieldCodec<uint> _repeated_sphereMainPropertyList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04003CBA RID: 15546
		private readonly RepeatedField<uint> sphereMainPropertyList_ = new RepeatedField<uint>();

		// Token: 0x04003CBB RID: 15547
		public const int RopeMainPropertyListFieldNumber = 6;

		// Token: 0x04003CBC RID: 15548
		private static readonly FieldCodec<uint> _repeated_ropeMainPropertyList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04003CBD RID: 15549
		private readonly RepeatedField<uint> ropeMainPropertyList_ = new RepeatedField<uint>();

		// Token: 0x04003CBE RID: 15550
		public const int IsIncludeFilterSubPropertyFieldNumber = 7;

		// Token: 0x04003CBF RID: 15551
		private bool isIncludeFilterSubProperty_;

		// Token: 0x04003CC0 RID: 15552
		public const int SubPropertyNumFieldNumber = 8;

		// Token: 0x04003CC1 RID: 15553
		private uint subPropertyNum_;

		// Token: 0x04003CC2 RID: 15554
		public const int SubPropertyListFieldNumber = 9;

		// Token: 0x04003CC3 RID: 15555
		private static readonly FieldCodec<uint> _repeated_subPropertyList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04003CC4 RID: 15556
		private readonly RepeatedField<uint> subPropertyList_ = new RepeatedField<uint>();

		// Token: 0x04003CC5 RID: 15557
		public const int HeadMainPropertyListFieldNumber = 10;

		// Token: 0x04003CC6 RID: 15558
		private static readonly FieldCodec<uint> _repeated_headMainPropertyList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04003CC7 RID: 15559
		private readonly RepeatedField<uint> headMainPropertyList_ = new RepeatedField<uint>();

		// Token: 0x04003CC8 RID: 15560
		public const int HandMainPropertyListFieldNumber = 11;

		// Token: 0x04003CC9 RID: 15561
		private static readonly FieldCodec<uint> _repeated_handMainPropertyList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04003CCA RID: 15562
		private readonly RepeatedField<uint> handMainPropertyList_ = new RepeatedField<uint>();
	}
}
