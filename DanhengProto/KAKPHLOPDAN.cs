using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000987 RID: 2439
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KAKPHLOPDAN : IMessage<KAKPHLOPDAN>, IMessage, IEquatable<KAKPHLOPDAN>, IDeepCloneable<KAKPHLOPDAN>, IBufferMessage
	{
		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06006D02 RID: 27906 RVA: 0x001231F7 File Offset: 0x001213F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KAKPHLOPDAN> Parser
		{
			get
			{
				return KAKPHLOPDAN._parser;
			}
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x06006D03 RID: 27907 RVA: 0x001231FE File Offset: 0x001213FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KAKPHLOPDANReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x06006D04 RID: 27908 RVA: 0x00123210 File Offset: 0x00121410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KAKPHLOPDAN.Descriptor;
			}
		}

		// Token: 0x06006D05 RID: 27909 RVA: 0x00123217 File Offset: 0x00121417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KAKPHLOPDAN()
		{
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x0012322C File Offset: 0x0012142C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KAKPHLOPDAN(KAKPHLOPDAN other) : this()
		{
			this.fJIOMCLFLMK_ = other.fJIOMCLFLMK_;
			this.kCNBAPCDOAC_ = other.kCNBAPCDOAC_;
			this.hPEHGIGBKFH_ = other.hPEHGIGBKFH_.Clone();
			this.iMKELKMHOIK_ = ((other.iMKELKMHOIK_ != null) ? other.iMKELKMHOIK_.Clone() : null);
			this.fGCPMGKNMOK_ = other.fGCPMGKNMOK_;
			this.iGDJLMDKHCJ_ = other.iGDJLMDKHCJ_;
			this.scoreId_ = other.scoreId_;
			this.curHp_ = other.curHp_;
			this.eNEOHGOGJHO_ = other.eNEOHGOGJHO_;
			this.energyInfo_ = other.energyInfo_;
			this.cMCBBHJELBD_ = other.cMCBBHJELBD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x001232E9 File Offset: 0x001214E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KAKPHLOPDAN Clone()
		{
			return new KAKPHLOPDAN(this);
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06006D08 RID: 27912 RVA: 0x001232F1 File Offset: 0x001214F1
		// (set) Token: 0x06006D09 RID: 27913 RVA: 0x001232F9 File Offset: 0x001214F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FJIOMCLFLMK
		{
			get
			{
				return this.fJIOMCLFLMK_;
			}
			set
			{
				this.fJIOMCLFLMK_ = value;
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06006D0A RID: 27914 RVA: 0x00123302 File Offset: 0x00121502
		// (set) Token: 0x06006D0B RID: 27915 RVA: 0x0012330A File Offset: 0x0012150A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KCNBAPCDOAC
		{
			get
			{
				return this.kCNBAPCDOAC_;
			}
			set
			{
				this.kCNBAPCDOAC_ = value;
			}
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06006D0C RID: 27916 RVA: 0x00123313 File Offset: 0x00121513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HPEHGIGBKFH
		{
			get
			{
				return this.hPEHGIGBKFH_;
			}
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06006D0D RID: 27917 RVA: 0x0012331B File Offset: 0x0012151B
		// (set) Token: 0x06006D0E RID: 27918 RVA: 0x00123323 File Offset: 0x00121523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHPIFKICOPP IMKELKMHOIK
		{
			get
			{
				return this.iMKELKMHOIK_;
			}
			set
			{
				this.iMKELKMHOIK_ = value;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06006D0F RID: 27919 RVA: 0x0012332C File Offset: 0x0012152C
		// (set) Token: 0x06006D10 RID: 27920 RVA: 0x00123334 File Offset: 0x00121534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FGCPMGKNMOK
		{
			get
			{
				return this.fGCPMGKNMOK_;
			}
			set
			{
				this.fGCPMGKNMOK_ = value;
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06006D11 RID: 27921 RVA: 0x0012333D File Offset: 0x0012153D
		// (set) Token: 0x06006D12 RID: 27922 RVA: 0x00123345 File Offset: 0x00121545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IGDJLMDKHCJ
		{
			get
			{
				return this.iGDJLMDKHCJ_;
			}
			set
			{
				this.iGDJLMDKHCJ_ = value;
			}
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06006D13 RID: 27923 RVA: 0x0012334E File Offset: 0x0012154E
		// (set) Token: 0x06006D14 RID: 27924 RVA: 0x00123356 File Offset: 0x00121556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06006D15 RID: 27925 RVA: 0x0012335F File Offset: 0x0012155F
		// (set) Token: 0x06006D16 RID: 27926 RVA: 0x00123367 File Offset: 0x00121567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurHp
		{
			get
			{
				return this.curHp_;
			}
			set
			{
				this.curHp_ = value;
			}
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x06006D17 RID: 27927 RVA: 0x00123370 File Offset: 0x00121570
		// (set) Token: 0x06006D18 RID: 27928 RVA: 0x00123378 File Offset: 0x00121578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ENEOHGOGJHO
		{
			get
			{
				return this.eNEOHGOGJHO_;
			}
			set
			{
				this.eNEOHGOGJHO_ = value;
			}
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x06006D19 RID: 27929 RVA: 0x00123381 File Offset: 0x00121581
		// (set) Token: 0x06006D1A RID: 27930 RVA: 0x00123389 File Offset: 0x00121589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EnergyInfo
		{
			get
			{
				return this.energyInfo_;
			}
			set
			{
				this.energyInfo_ = value;
			}
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06006D1B RID: 27931 RVA: 0x00123392 File Offset: 0x00121592
		// (set) Token: 0x06006D1C RID: 27932 RVA: 0x0012339A File Offset: 0x0012159A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BLBJBAMDNBN CMCBBHJELBD
		{
			get
			{
				return this.cMCBBHJELBD_;
			}
			set
			{
				this.cMCBBHJELBD_ = value;
			}
		}

		// Token: 0x06006D1D RID: 27933 RVA: 0x001233A3 File Offset: 0x001215A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KAKPHLOPDAN);
		}

		// Token: 0x06006D1E RID: 27934 RVA: 0x001233B4 File Offset: 0x001215B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KAKPHLOPDAN other)
		{
			return other != null && (other == this || (this.FJIOMCLFLMK == other.FJIOMCLFLMK && this.KCNBAPCDOAC == other.KCNBAPCDOAC && this.hPEHGIGBKFH_.Equals(other.hPEHGIGBKFH_) && object.Equals(this.IMKELKMHOIK, other.IMKELKMHOIK) && this.FGCPMGKNMOK == other.FGCPMGKNMOK && this.IGDJLMDKHCJ == other.IGDJLMDKHCJ && this.ScoreId == other.ScoreId && this.CurHp == other.CurHp && this.ENEOHGOGJHO == other.ENEOHGOGJHO && this.EnergyInfo == other.EnergyInfo && this.CMCBBHJELBD == other.CMCBBHJELBD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x00123498 File Offset: 0x00121698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FJIOMCLFLMK != 0U)
			{
				num ^= this.FJIOMCLFLMK.GetHashCode();
			}
			if (this.KCNBAPCDOAC != 0U)
			{
				num ^= this.KCNBAPCDOAC.GetHashCode();
			}
			num ^= this.hPEHGIGBKFH_.GetHashCode();
			if (this.iMKELKMHOIK_ != null)
			{
				num ^= this.IMKELKMHOIK.GetHashCode();
			}
			if (this.FGCPMGKNMOK != 0U)
			{
				num ^= this.FGCPMGKNMOK.GetHashCode();
			}
			if (this.IGDJLMDKHCJ != 0U)
			{
				num ^= this.IGDJLMDKHCJ.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.CurHp != 0U)
			{
				num ^= this.CurHp.GetHashCode();
			}
			if (this.ENEOHGOGJHO != 0U)
			{
				num ^= this.ENEOHGOGJHO.GetHashCode();
			}
			if (this.EnergyInfo != 0U)
			{
				num ^= this.EnergyInfo.GetHashCode();
			}
			if (this.CMCBBHJELBD != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				num ^= this.CMCBBHJELBD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x001235C9 File Offset: 0x001217C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x001235D1 File Offset: 0x001217D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x001235DC File Offset: 0x001217DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnergyInfo != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.EnergyInfo);
			}
			if (this.iMKELKMHOIK_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.IMKELKMHOIK);
			}
			if (this.FGCPMGKNMOK != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.FGCPMGKNMOK);
			}
			if (this.IGDJLMDKHCJ != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.IGDJLMDKHCJ);
			}
			this.hPEHGIGBKFH_.WriteTo(ref output, KAKPHLOPDAN._repeated_hPEHGIGBKFH_codec);
			if (this.KCNBAPCDOAC != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.KCNBAPCDOAC);
			}
			if (this.FJIOMCLFLMK != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.FJIOMCLFLMK);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.CurHp != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.CurHp);
			}
			if (this.CMCBBHJELBD != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.CMCBBHJELBD);
			}
			if (this.ENEOHGOGJHO != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ENEOHGOGJHO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x00123728 File Offset: 0x00121928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FJIOMCLFLMK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FJIOMCLFLMK);
			}
			if (this.KCNBAPCDOAC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KCNBAPCDOAC);
			}
			num += this.hPEHGIGBKFH_.CalculateSize(KAKPHLOPDAN._repeated_hPEHGIGBKFH_codec);
			if (this.iMKELKMHOIK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IMKELKMHOIK);
			}
			if (this.FGCPMGKNMOK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FGCPMGKNMOK);
			}
			if (this.IGDJLMDKHCJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IGDJLMDKHCJ);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.CurHp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurHp);
			}
			if (this.ENEOHGOGJHO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ENEOHGOGJHO);
			}
			if (this.EnergyInfo != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EnergyInfo);
			}
			if (this.CMCBBHJELBD != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CMCBBHJELBD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x00123854 File Offset: 0x00121A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KAKPHLOPDAN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FJIOMCLFLMK != 0U)
			{
				this.FJIOMCLFLMK = other.FJIOMCLFLMK;
			}
			if (other.KCNBAPCDOAC != 0U)
			{
				this.KCNBAPCDOAC = other.KCNBAPCDOAC;
			}
			this.hPEHGIGBKFH_.Add(other.hPEHGIGBKFH_);
			if (other.iMKELKMHOIK_ != null)
			{
				if (this.iMKELKMHOIK_ == null)
				{
					this.IMKELKMHOIK = new DHPIFKICOPP();
				}
				this.IMKELKMHOIK.MergeFrom(other.IMKELKMHOIK);
			}
			if (other.FGCPMGKNMOK != 0U)
			{
				this.FGCPMGKNMOK = other.FGCPMGKNMOK;
			}
			if (other.IGDJLMDKHCJ != 0U)
			{
				this.IGDJLMDKHCJ = other.IGDJLMDKHCJ;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.CurHp != 0U)
			{
				this.CurHp = other.CurHp;
			}
			if (other.ENEOHGOGJHO != 0U)
			{
				this.ENEOHGOGJHO = other.ENEOHGOGJHO;
			}
			if (other.EnergyInfo != 0U)
			{
				this.EnergyInfo = other.EnergyInfo;
			}
			if (other.CMCBBHJELBD != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				this.CMCBBHJELBD = other.CMCBBHJELBD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x0012396D File Offset: 0x00121B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x00123978 File Offset: 0x00121B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 66U)
				{
					if (num <= 40U)
					{
						if (num == 16U)
						{
							this.EnergyInfo = input.ReadUInt32();
							continue;
						}
						if (num == 26U)
						{
							if (this.iMKELKMHOIK_ == null)
							{
								this.IMKELKMHOIK = new DHPIFKICOPP();
							}
							input.ReadMessage(this.IMKELKMHOIK);
							continue;
						}
						if (num == 40U)
						{
							this.FGCPMGKNMOK = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.IGDJLMDKHCJ = input.ReadUInt32();
							continue;
						}
						if (num == 64U || num == 66U)
						{
							this.hPEHGIGBKFH_.AddEntriesFrom(ref input, KAKPHLOPDAN._repeated_hPEHGIGBKFH_codec);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.KCNBAPCDOAC = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.FJIOMCLFLMK = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.CurHp = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.CMCBBHJELBD = (BLBJBAMDNBN)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.ENEOHGOGJHO = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040029CE RID: 10702
		private static readonly MessageParser<KAKPHLOPDAN> _parser = new MessageParser<KAKPHLOPDAN>(() => new KAKPHLOPDAN());

		// Token: 0x040029CF RID: 10703
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029D0 RID: 10704
		public const int FJIOMCLFLMKFieldNumber = 10;

		// Token: 0x040029D1 RID: 10705
		private uint fJIOMCLFLMK_;

		// Token: 0x040029D2 RID: 10706
		public const int KCNBAPCDOACFieldNumber = 9;

		// Token: 0x040029D3 RID: 10707
		private uint kCNBAPCDOAC_;

		// Token: 0x040029D4 RID: 10708
		public const int HPEHGIGBKFHFieldNumber = 8;

		// Token: 0x040029D5 RID: 10709
		private static readonly FieldCodec<uint> _repeated_hPEHGIGBKFH_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x040029D6 RID: 10710
		private readonly RepeatedField<uint> hPEHGIGBKFH_ = new RepeatedField<uint>();

		// Token: 0x040029D7 RID: 10711
		public const int IMKELKMHOIKFieldNumber = 3;

		// Token: 0x040029D8 RID: 10712
		private DHPIFKICOPP iMKELKMHOIK_;

		// Token: 0x040029D9 RID: 10713
		public const int FGCPMGKNMOKFieldNumber = 5;

		// Token: 0x040029DA RID: 10714
		private uint fGCPMGKNMOK_;

		// Token: 0x040029DB RID: 10715
		public const int IGDJLMDKHCJFieldNumber = 7;

		// Token: 0x040029DC RID: 10716
		private uint iGDJLMDKHCJ_;

		// Token: 0x040029DD RID: 10717
		public const int ScoreIdFieldNumber = 11;

		// Token: 0x040029DE RID: 10718
		private uint scoreId_;

		// Token: 0x040029DF RID: 10719
		public const int CurHpFieldNumber = 12;

		// Token: 0x040029E0 RID: 10720
		private uint curHp_;

		// Token: 0x040029E1 RID: 10721
		public const int ENEOHGOGJHOFieldNumber = 15;

		// Token: 0x040029E2 RID: 10722
		private uint eNEOHGOGJHO_;

		// Token: 0x040029E3 RID: 10723
		public const int EnergyInfoFieldNumber = 2;

		// Token: 0x040029E4 RID: 10724
		private uint energyInfo_;

		// Token: 0x040029E5 RID: 10725
		public const int CMCBBHJELBDFieldNumber = 13;

		// Token: 0x040029E6 RID: 10726
		private BLBJBAMDNBN cMCBBHJELBD_;
	}
}
