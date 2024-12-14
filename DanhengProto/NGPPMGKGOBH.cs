using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C19 RID: 3097
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NGPPMGKGOBH : IMessage<NGPPMGKGOBH>, IMessage, IEquatable<NGPPMGKGOBH>, IDeepCloneable<NGPPMGKGOBH>, IBufferMessage
	{
		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x06008921 RID: 35105 RVA: 0x00169FD8 File Offset: 0x001681D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NGPPMGKGOBH> Parser
		{
			get
			{
				return NGPPMGKGOBH._parser;
			}
		}

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x06008922 RID: 35106 RVA: 0x00169FDF File Offset: 0x001681DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NGPPMGKGOBHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x06008923 RID: 35107 RVA: 0x00169FF1 File Offset: 0x001681F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NGPPMGKGOBH.Descriptor;
			}
		}

		// Token: 0x06008924 RID: 35108 RVA: 0x00169FF8 File Offset: 0x001681F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGPPMGKGOBH()
		{
		}

		// Token: 0x06008925 RID: 35109 RVA: 0x0016A02C File Offset: 0x0016822C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGPPMGKGOBH(NGPPMGKGOBH other) : this()
		{
			this.fGKNNFGHEGG_ = other.fGKNNFGHEGG_.Clone();
			this.eOHLIDIKJJN_ = other.eOHLIDIKJJN_;
			this.aCMFDIGCDOO_ = other.aCMFDIGCDOO_;
			this.kGODMCGKNHE_ = other.kGODMCGKNHE_;
			this.extraRoundLimit_ = other.extraRoundLimit_;
			this.gFFKAHPJPOH_ = other.gFFKAHPJPOH_;
			this.gameStyleType_ = other.gameStyleType_;
			this.rogueMagicUnitInfoList_ = other.rogueMagicUnitInfoList_.Clone();
			this.fIPMDHIHIBB_ = other.fIPMDHIHIBB_;
			this.hHPDCIDLABC_ = other.hHPDCIDLABC_;
			this.magicScepterInfoList_ = other.magicScepterInfoList_.Clone();
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this.dHNMHPNJPPL_ = other.dHNMHPNJPPL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008926 RID: 35110 RVA: 0x0016A100 File Offset: 0x00168300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGPPMGKGOBH Clone()
		{
			return new NGPPMGKGOBH(this);
		}

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x06008927 RID: 35111 RVA: 0x0016A108 File Offset: 0x00168308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FGKNNFGHEGG
		{
			get
			{
				return this.fGKNNFGHEGG_;
			}
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x06008928 RID: 35112 RVA: 0x0016A110 File Offset: 0x00168310
		// (set) Token: 0x06008929 RID: 35113 RVA: 0x0016A118 File Offset: 0x00168318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EOHLIDIKJJN
		{
			get
			{
				return this.eOHLIDIKJJN_;
			}
			set
			{
				this.eOHLIDIKJJN_ = value;
			}
		}

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x0600892A RID: 35114 RVA: 0x0016A121 File Offset: 0x00168321
		// (set) Token: 0x0600892B RID: 35115 RVA: 0x0016A129 File Offset: 0x00168329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ACMFDIGCDOO
		{
			get
			{
				return this.aCMFDIGCDOO_;
			}
			set
			{
				this.aCMFDIGCDOO_ = value;
			}
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x0600892C RID: 35116 RVA: 0x0016A132 File Offset: 0x00168332
		// (set) Token: 0x0600892D RID: 35117 RVA: 0x0016A13A File Offset: 0x0016833A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KGODMCGKNHE
		{
			get
			{
				return this.kGODMCGKNHE_;
			}
			set
			{
				this.kGODMCGKNHE_ = value;
			}
		}

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x0600892E RID: 35118 RVA: 0x0016A143 File Offset: 0x00168343
		// (set) Token: 0x0600892F RID: 35119 RVA: 0x0016A14B File Offset: 0x0016834B
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

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x06008930 RID: 35120 RVA: 0x0016A154 File Offset: 0x00168354
		// (set) Token: 0x06008931 RID: 35121 RVA: 0x0016A15C File Offset: 0x0016835C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GFFKAHPJPOH
		{
			get
			{
				return this.gFFKAHPJPOH_;
			}
			set
			{
				this.gFFKAHPJPOH_ = value;
			}
		}

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x06008932 RID: 35122 RVA: 0x0016A165 File Offset: 0x00168365
		// (set) Token: 0x06008933 RID: 35123 RVA: 0x0016A16D File Offset: 0x0016836D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameStyleType
		{
			get
			{
				return this.gameStyleType_;
			}
			set
			{
				this.gameStyleType_ = value;
			}
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x06008934 RID: 35124 RVA: 0x0016A176 File Offset: 0x00168376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicGameUnitInfo> RogueMagicUnitInfoList
		{
			get
			{
				return this.rogueMagicUnitInfoList_;
			}
		}

		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x06008935 RID: 35125 RVA: 0x0016A17E File Offset: 0x0016837E
		// (set) Token: 0x06008936 RID: 35126 RVA: 0x0016A186 File Offset: 0x00168386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FIPMDHIHIBB
		{
			get
			{
				return this.fIPMDHIHIBB_;
			}
			set
			{
				this.fIPMDHIHIBB_ = value;
			}
		}

		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x06008937 RID: 35127 RVA: 0x0016A18F File Offset: 0x0016838F
		// (set) Token: 0x06008938 RID: 35128 RVA: 0x0016A197 File Offset: 0x00168397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HHPDCIDLABC
		{
			get
			{
				return this.hHPDCIDLABC_;
			}
			set
			{
				this.hHPDCIDLABC_ = value;
			}
		}

		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x06008939 RID: 35129 RVA: 0x0016A1A0 File Offset: 0x001683A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicGameScepterInfo> MagicScepterInfoList
		{
			get
			{
				return this.magicScepterInfoList_;
			}
		}

		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x0600893A RID: 35130 RVA: 0x0016A1A8 File Offset: 0x001683A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x0600893B RID: 35131 RVA: 0x0016A1B0 File Offset: 0x001683B0
		// (set) Token: 0x0600893C RID: 35132 RVA: 0x0016A1B8 File Offset: 0x001683B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DHNMHPNJPPL
		{
			get
			{
				return this.dHNMHPNJPPL_;
			}
			set
			{
				this.dHNMHPNJPPL_ = value;
			}
		}

		// Token: 0x0600893D RID: 35133 RVA: 0x0016A1C1 File Offset: 0x001683C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NGPPMGKGOBH);
		}

		// Token: 0x0600893E RID: 35134 RVA: 0x0016A1D0 File Offset: 0x001683D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NGPPMGKGOBH other)
		{
			return other != null && (other == this || (this.fGKNNFGHEGG_.Equals(other.fGKNNFGHEGG_) && this.EOHLIDIKJJN == other.EOHLIDIKJJN && this.ACMFDIGCDOO == other.ACMFDIGCDOO && this.KGODMCGKNHE == other.KGODMCGKNHE && this.ExtraRoundLimit == other.ExtraRoundLimit && this.GFFKAHPJPOH == other.GFFKAHPJPOH && this.GameStyleType == other.GameStyleType && this.rogueMagicUnitInfoList_.Equals(other.rogueMagicUnitInfoList_) && this.FIPMDHIHIBB == other.FIPMDHIHIBB && this.HHPDCIDLABC == other.HHPDCIDLABC && this.magicScepterInfoList_.Equals(other.magicScepterInfoList_) && this.avatarIdList_.Equals(other.avatarIdList_) && this.DHNMHPNJPPL == other.DHNMHPNJPPL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600893F RID: 35135 RVA: 0x0016A2E0 File Offset: 0x001684E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fGKNNFGHEGG_.GetHashCode();
			if (this.EOHLIDIKJJN != 0U)
			{
				num ^= this.EOHLIDIKJJN.GetHashCode();
			}
			if (this.ACMFDIGCDOO != 0U)
			{
				num ^= this.ACMFDIGCDOO.GetHashCode();
			}
			if (this.KGODMCGKNHE != 0U)
			{
				num ^= this.KGODMCGKNHE.GetHashCode();
			}
			if (this.ExtraRoundLimit != 0U)
			{
				num ^= this.ExtraRoundLimit.GetHashCode();
			}
			if (this.GFFKAHPJPOH != 0U)
			{
				num ^= this.GFFKAHPJPOH.GetHashCode();
			}
			if (this.GameStyleType != 0U)
			{
				num ^= this.GameStyleType.GetHashCode();
			}
			num ^= this.rogueMagicUnitInfoList_.GetHashCode();
			if (this.FIPMDHIHIBB != 0U)
			{
				num ^= this.FIPMDHIHIBB.GetHashCode();
			}
			if (this.HHPDCIDLABC != 0U)
			{
				num ^= this.HHPDCIDLABC.GetHashCode();
			}
			num ^= this.magicScepterInfoList_.GetHashCode();
			num ^= this.avatarIdList_.GetHashCode();
			if (this.DHNMHPNJPPL != 0U)
			{
				num ^= this.DHNMHPNJPPL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x0016A41F File Offset: 0x0016861F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x0016A427 File Offset: 0x00168627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x0016A430 File Offset: 0x00168630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EOHLIDIKJJN != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.EOHLIDIKJJN);
			}
			if (this.GFFKAHPJPOH != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GFFKAHPJPOH);
			}
			if (this.ExtraRoundLimit != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ExtraRoundLimit);
			}
			if (this.KGODMCGKNHE != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.KGODMCGKNHE);
			}
			if (this.HHPDCIDLABC != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.HHPDCIDLABC);
			}
			if (this.DHNMHPNJPPL != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.DHNMHPNJPPL);
			}
			if (this.FIPMDHIHIBB != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.FIPMDHIHIBB);
			}
			if (this.ACMFDIGCDOO != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ACMFDIGCDOO);
			}
			if (this.GameStyleType != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GameStyleType);
			}
			this.fGKNNFGHEGG_.WriteTo(ref output, NGPPMGKGOBH._repeated_fGKNNFGHEGG_codec);
			this.rogueMagicUnitInfoList_.WriteTo(ref output, NGPPMGKGOBH._repeated_rogueMagicUnitInfoList_codec);
			this.avatarIdList_.WriteTo(ref output, NGPPMGKGOBH._repeated_avatarIdList_codec);
			this.magicScepterInfoList_.WriteTo(ref output, NGPPMGKGOBH._repeated_magicScepterInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008943 RID: 35139 RVA: 0x0016A594 File Offset: 0x00168794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fGKNNFGHEGG_.CalculateSize(NGPPMGKGOBH._repeated_fGKNNFGHEGG_codec);
			if (this.EOHLIDIKJJN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EOHLIDIKJJN);
			}
			if (this.ACMFDIGCDOO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ACMFDIGCDOO);
			}
			if (this.KGODMCGKNHE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KGODMCGKNHE);
			}
			if (this.ExtraRoundLimit != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExtraRoundLimit);
			}
			if (this.GFFKAHPJPOH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GFFKAHPJPOH);
			}
			if (this.GameStyleType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameStyleType);
			}
			num += this.rogueMagicUnitInfoList_.CalculateSize(NGPPMGKGOBH._repeated_rogueMagicUnitInfoList_codec);
			if (this.FIPMDHIHIBB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FIPMDHIHIBB);
			}
			if (this.HHPDCIDLABC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HHPDCIDLABC);
			}
			num += this.magicScepterInfoList_.CalculateSize(NGPPMGKGOBH._repeated_magicScepterInfoList_codec);
			num += this.avatarIdList_.CalculateSize(NGPPMGKGOBH._repeated_avatarIdList_codec);
			if (this.DHNMHPNJPPL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DHNMHPNJPPL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008944 RID: 35140 RVA: 0x0016A6E0 File Offset: 0x001688E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NGPPMGKGOBH other)
		{
			if (other == null)
			{
				return;
			}
			this.fGKNNFGHEGG_.Add(other.fGKNNFGHEGG_);
			if (other.EOHLIDIKJJN != 0U)
			{
				this.EOHLIDIKJJN = other.EOHLIDIKJJN;
			}
			if (other.ACMFDIGCDOO != 0U)
			{
				this.ACMFDIGCDOO = other.ACMFDIGCDOO;
			}
			if (other.KGODMCGKNHE != 0U)
			{
				this.KGODMCGKNHE = other.KGODMCGKNHE;
			}
			if (other.ExtraRoundLimit != 0U)
			{
				this.ExtraRoundLimit = other.ExtraRoundLimit;
			}
			if (other.GFFKAHPJPOH != 0U)
			{
				this.GFFKAHPJPOH = other.GFFKAHPJPOH;
			}
			if (other.GameStyleType != 0U)
			{
				this.GameStyleType = other.GameStyleType;
			}
			this.rogueMagicUnitInfoList_.Add(other.rogueMagicUnitInfoList_);
			if (other.FIPMDHIHIBB != 0U)
			{
				this.FIPMDHIHIBB = other.FIPMDHIHIBB;
			}
			if (other.HHPDCIDLABC != 0U)
			{
				this.HHPDCIDLABC = other.HHPDCIDLABC;
			}
			this.magicScepterInfoList_.Add(other.magicScepterInfoList_);
			this.avatarIdList_.Add(other.avatarIdList_);
			if (other.DHNMHPNJPPL != 0U)
			{
				this.DHNMHPNJPPL = other.DHNMHPNJPPL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008945 RID: 35141 RVA: 0x0016A800 File Offset: 0x00168A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x0016A80C File Offset: 0x00168A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num <= 48U)
					{
						if (num == 16U)
						{
							this.EOHLIDIKJJN = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.GFFKAHPJPOH = input.ReadUInt32();
							continue;
						}
						if (num == 48U)
						{
							this.ExtraRoundLimit = input.ReadUInt32();
							continue;
						}
					}
					else if (num <= 64U)
					{
						if (num == 56U)
						{
							this.KGODMCGKNHE = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							this.HHPDCIDLABC = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 72U)
						{
							this.DHNMHPNJPPL = input.ReadUInt32();
							continue;
						}
						if (num == 80U)
						{
							this.FIPMDHIHIBB = input.ReadUInt32();
							continue;
						}
					}
				}
				else
				{
					if (num > 8866U)
					{
						if (num <= 9800U)
						{
							if (num == 9786U)
							{
								this.rogueMagicUnitInfoList_.AddEntriesFrom(ref input, NGPPMGKGOBH._repeated_rogueMagicUnitInfoList_codec);
								continue;
							}
							if (num != 9800U)
							{
								goto IL_C2;
							}
						}
						else if (num != 9802U)
						{
							if (num != 10970U)
							{
								goto IL_C2;
							}
							this.magicScepterInfoList_.AddEntriesFrom(ref input, NGPPMGKGOBH._repeated_magicScepterInfoList_codec);
							continue;
						}
						this.avatarIdList_.AddEntriesFrom(ref input, NGPPMGKGOBH._repeated_avatarIdList_codec);
						continue;
					}
					if (num <= 120U)
					{
						if (num == 112U)
						{
							this.ACMFDIGCDOO = input.ReadUInt32();
							continue;
						}
						if (num == 120U)
						{
							this.GameStyleType = input.ReadUInt32();
							continue;
						}
					}
					else if (num == 8864U || num == 8866U)
					{
						this.fGKNNFGHEGG_.AddEntriesFrom(ref input, NGPPMGKGOBH._repeated_fGKNNFGHEGG_codec);
						continue;
					}
				}
				IL_C2:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003489 RID: 13449
		private static readonly MessageParser<NGPPMGKGOBH> _parser = new MessageParser<NGPPMGKGOBH>(() => new NGPPMGKGOBH());

		// Token: 0x0400348A RID: 13450
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400348B RID: 13451
		public const int FGKNNFGHEGGFieldNumber = 1108;

		// Token: 0x0400348C RID: 13452
		private static readonly FieldCodec<uint> _repeated_fGKNNFGHEGG_codec = FieldCodec.ForUInt32(8866U);

		// Token: 0x0400348D RID: 13453
		private readonly RepeatedField<uint> fGKNNFGHEGG_ = new RepeatedField<uint>();

		// Token: 0x0400348E RID: 13454
		public const int EOHLIDIKJJNFieldNumber = 2;

		// Token: 0x0400348F RID: 13455
		private uint eOHLIDIKJJN_;

		// Token: 0x04003490 RID: 13456
		public const int ACMFDIGCDOOFieldNumber = 14;

		// Token: 0x04003491 RID: 13457
		private uint aCMFDIGCDOO_;

		// Token: 0x04003492 RID: 13458
		public const int KGODMCGKNHEFieldNumber = 7;

		// Token: 0x04003493 RID: 13459
		private uint kGODMCGKNHE_;

		// Token: 0x04003494 RID: 13460
		public const int ExtraRoundLimitFieldNumber = 6;

		// Token: 0x04003495 RID: 13461
		private uint extraRoundLimit_;

		// Token: 0x04003496 RID: 13462
		public const int GFFKAHPJPOHFieldNumber = 5;

		// Token: 0x04003497 RID: 13463
		private uint gFFKAHPJPOH_;

		// Token: 0x04003498 RID: 13464
		public const int GameStyleTypeFieldNumber = 15;

		// Token: 0x04003499 RID: 13465
		private uint gameStyleType_;

		// Token: 0x0400349A RID: 13466
		public const int RogueMagicUnitInfoListFieldNumber = 1223;

		// Token: 0x0400349B RID: 13467
		private static readonly FieldCodec<RogueMagicGameUnitInfo> _repeated_rogueMagicUnitInfoList_codec = FieldCodec.ForMessage<RogueMagicGameUnitInfo>(9786U, RogueMagicGameUnitInfo.Parser);

		// Token: 0x0400349C RID: 13468
		private readonly RepeatedField<RogueMagicGameUnitInfo> rogueMagicUnitInfoList_ = new RepeatedField<RogueMagicGameUnitInfo>();

		// Token: 0x0400349D RID: 13469
		public const int FIPMDHIHIBBFieldNumber = 10;

		// Token: 0x0400349E RID: 13470
		private uint fIPMDHIHIBB_;

		// Token: 0x0400349F RID: 13471
		public const int HHPDCIDLABCFieldNumber = 8;

		// Token: 0x040034A0 RID: 13472
		private uint hHPDCIDLABC_;

		// Token: 0x040034A1 RID: 13473
		public const int MagicScepterInfoListFieldNumber = 1371;

		// Token: 0x040034A2 RID: 13474
		private static readonly FieldCodec<RogueMagicGameScepterInfo> _repeated_magicScepterInfoList_codec = FieldCodec.ForMessage<RogueMagicGameScepterInfo>(10970U, RogueMagicGameScepterInfo.Parser);

		// Token: 0x040034A3 RID: 13475
		private readonly RepeatedField<RogueMagicGameScepterInfo> magicScepterInfoList_ = new RepeatedField<RogueMagicGameScepterInfo>();

		// Token: 0x040034A4 RID: 13476
		public const int AvatarIdListFieldNumber = 1225;

		// Token: 0x040034A5 RID: 13477
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(9802U);

		// Token: 0x040034A6 RID: 13478
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

		// Token: 0x040034A7 RID: 13479
		public const int DHNMHPNJPPLFieldNumber = 9;

		// Token: 0x040034A8 RID: 13480
		private uint dHNMHPNJPPL_;
	}
}
