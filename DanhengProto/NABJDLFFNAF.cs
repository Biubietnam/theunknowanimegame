using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BF7 RID: 3063
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NABJDLFFNAF : IMessage<NABJDLFFNAF>, IMessage, IEquatable<NABJDLFFNAF>, IDeepCloneable<NABJDLFFNAF>, IBufferMessage
	{
		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x0600878E RID: 34702 RVA: 0x00165932 File Offset: 0x00163B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NABJDLFFNAF> Parser
		{
			get
			{
				return NABJDLFFNAF._parser;
			}
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x0600878F RID: 34703 RVA: 0x00165939 File Offset: 0x00163B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NABJDLFFNAFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x06008790 RID: 34704 RVA: 0x0016594B File Offset: 0x00163B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NABJDLFFNAF.Descriptor;
			}
		}

		// Token: 0x06008791 RID: 34705 RVA: 0x00165954 File Offset: 0x00163B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NABJDLFFNAF()
		{
		}

		// Token: 0x06008792 RID: 34706 RVA: 0x001659C0 File Offset: 0x00163BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NABJDLFFNAF(NABJDLFFNAF other) : this()
		{
			this.lGCEACIAHBJ_ = other.lGCEACIAHBJ_;
			this.eNPCCPAMDHK_ = other.eNPCCPAMDHK_;
			this.gAGHJMKACBM_ = other.gAGHJMKACBM_;
			this.cKMKLNOAJAF_ = other.cKMKLNOAJAF_.Clone();
			this.kEAOHKHKBCA_ = other.kEAOHKHKBCA_;
			this.dLCMPPCGJAL_ = other.dLCMPPCGJAL_;
			this.eILAKPNJBJN_ = other.eILAKPNJBJN_;
			this.poolId_ = other.poolId_;
			this.hAJKAHEDEMM_ = other.hAJKAHEDEMM_.Clone();
			this.cIAFBNOKALL_ = other.cIAFBNOKALL_;
			this.fPEGIACNKHH_ = other.fPEGIACNKHH_;
			this.iFENKDFNNEI_ = other.iFENKDFNNEI_.Clone();
			this.gADNLGEGDLA_ = other.gADNLGEGDLA_;
			this.hJEGMIGPECO_ = other.hJEGMIGPECO_;
			this.iCBONDMIJDC_ = other.iCBONDMIJDC_.Clone();
			this.hBAHKLCCCBG_ = other.hBAHKLCCCBG_.Clone();
			this.dEJJPHCJLBO_ = other.dEJJPHCJLBO_;
			this.jBKCDEEIKKN_ = other.jBKCDEEIKKN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008793 RID: 34707 RVA: 0x00165AD5 File Offset: 0x00163CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NABJDLFFNAF Clone()
		{
			return new NABJDLFFNAF(this);
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x06008794 RID: 34708 RVA: 0x00165ADD File Offset: 0x00163CDD
		// (set) Token: 0x06008795 RID: 34709 RVA: 0x00165AE5 File Offset: 0x00163CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong LGCEACIAHBJ
		{
			get
			{
				return this.lGCEACIAHBJ_;
			}
			set
			{
				this.lGCEACIAHBJ_ = value;
			}
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x06008796 RID: 34710 RVA: 0x00165AEE File Offset: 0x00163CEE
		// (set) Token: 0x06008797 RID: 34711 RVA: 0x00165AF6 File Offset: 0x00163CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ENPCCPAMDHK
		{
			get
			{
				return this.eNPCCPAMDHK_;
			}
			set
			{
				this.eNPCCPAMDHK_ = value;
			}
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x06008798 RID: 34712 RVA: 0x00165AFF File Offset: 0x00163CFF
		// (set) Token: 0x06008799 RID: 34713 RVA: 0x00165B07 File Offset: 0x00163D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong GAGHJMKACBM
		{
			get
			{
				return this.gAGHJMKACBM_;
			}
			set
			{
				this.gAGHJMKACBM_ = value;
			}
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x0600879A RID: 34714 RVA: 0x00165B10 File Offset: 0x00163D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DHIPMOLCCHJ> CKMKLNOAJAF
		{
			get
			{
				return this.cKMKLNOAJAF_;
			}
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x0600879B RID: 34715 RVA: 0x00165B18 File Offset: 0x00163D18
		// (set) Token: 0x0600879C RID: 34716 RVA: 0x00165B20 File Offset: 0x00163D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KEAOHKHKBCA
		{
			get
			{
				return this.kEAOHKHKBCA_;
			}
			set
			{
				this.kEAOHKHKBCA_ = value;
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x0600879D RID: 34717 RVA: 0x00165B29 File Offset: 0x00163D29
		// (set) Token: 0x0600879E RID: 34718 RVA: 0x00165B31 File Offset: 0x00163D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DLCMPPCGJAL
		{
			get
			{
				return this.dLCMPPCGJAL_;
			}
			set
			{
				this.dLCMPPCGJAL_ = value;
			}
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x0600879F RID: 34719 RVA: 0x00165B3A File Offset: 0x00163D3A
		// (set) Token: 0x060087A0 RID: 34720 RVA: 0x00165B42 File Offset: 0x00163D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EILAKPNJBJN
		{
			get
			{
				return this.eILAKPNJBJN_;
			}
			set
			{
				this.eILAKPNJBJN_ = value;
			}
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x060087A1 RID: 34721 RVA: 0x00165B4B File Offset: 0x00163D4B
		// (set) Token: 0x060087A2 RID: 34722 RVA: 0x00165B53 File Offset: 0x00163D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PoolId
		{
			get
			{
				return this.poolId_;
			}
			set
			{
				this.poolId_ = value;
			}
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x060087A3 RID: 34723 RVA: 0x00165B5C File Offset: 0x00163D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KHBAFNOEJOE> HAJKAHEDEMM
		{
			get
			{
				return this.hAJKAHEDEMM_;
			}
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x060087A4 RID: 34724 RVA: 0x00165B64 File Offset: 0x00163D64
		// (set) Token: 0x060087A5 RID: 34725 RVA: 0x00165B6C File Offset: 0x00163D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CIAFBNOKALL
		{
			get
			{
				return this.cIAFBNOKALL_;
			}
			set
			{
				this.cIAFBNOKALL_ = value;
			}
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x060087A6 RID: 34726 RVA: 0x00165B75 File Offset: 0x00163D75
		// (set) Token: 0x060087A7 RID: 34727 RVA: 0x00165B7D File Offset: 0x00163D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FPEGIACNKHH
		{
			get
			{
				return this.fPEGIACNKHH_;
			}
			set
			{
				this.fPEGIACNKHH_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x060087A8 RID: 34728 RVA: 0x00165B90 File Offset: 0x00163D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DHIPMOLCCHJ> IFENKDFNNEI
		{
			get
			{
				return this.iFENKDFNNEI_;
			}
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x060087A9 RID: 34729 RVA: 0x00165B98 File Offset: 0x00163D98
		// (set) Token: 0x060087AA RID: 34730 RVA: 0x00165BA0 File Offset: 0x00163DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GADNLGEGDLA
		{
			get
			{
				return this.gADNLGEGDLA_;
			}
			set
			{
				this.gADNLGEGDLA_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x060087AB RID: 34731 RVA: 0x00165BB3 File Offset: 0x00163DB3
		// (set) Token: 0x060087AC RID: 34732 RVA: 0x00165BBB File Offset: 0x00163DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string HJEGMIGPECO
		{
			get
			{
				return this.hJEGMIGPECO_;
			}
			set
			{
				this.hJEGMIGPECO_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x060087AD RID: 34733 RVA: 0x00165BCE File Offset: 0x00163DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DHIPMOLCCHJ> ICBONDMIJDC
		{
			get
			{
				return this.iCBONDMIJDC_;
			}
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x060087AE RID: 34734 RVA: 0x00165BD6 File Offset: 0x00163DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DHIPMOLCCHJ> HBAHKLCCCBG
		{
			get
			{
				return this.hBAHKLCCCBG_;
			}
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x060087AF RID: 34735 RVA: 0x00165BDE File Offset: 0x00163DDE
		// (set) Token: 0x060087B0 RID: 34736 RVA: 0x00165BE6 File Offset: 0x00163DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DEJJPHCJLBO
		{
			get
			{
				return this.dEJJPHCJLBO_;
			}
			set
			{
				this.dEJJPHCJLBO_ = value;
			}
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x060087B1 RID: 34737 RVA: 0x00165BEF File Offset: 0x00163DEF
		// (set) Token: 0x060087B2 RID: 34738 RVA: 0x00165BF7 File Offset: 0x00163DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong JBKCDEEIKKN
		{
			get
			{
				return this.jBKCDEEIKKN_;
			}
			set
			{
				this.jBKCDEEIKKN_ = value;
			}
		}

		// Token: 0x060087B3 RID: 34739 RVA: 0x00165C00 File Offset: 0x00163E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NABJDLFFNAF);
		}

		// Token: 0x060087B4 RID: 34740 RVA: 0x00165C10 File Offset: 0x00163E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NABJDLFFNAF other)
		{
			return other != null && (other == this || (this.LGCEACIAHBJ == other.LGCEACIAHBJ && this.ENPCCPAMDHK == other.ENPCCPAMDHK && this.GAGHJMKACBM == other.GAGHJMKACBM && this.cKMKLNOAJAF_.Equals(other.cKMKLNOAJAF_) && this.KEAOHKHKBCA == other.KEAOHKHKBCA && this.DLCMPPCGJAL == other.DLCMPPCGJAL && this.EILAKPNJBJN == other.EILAKPNJBJN && this.PoolId == other.PoolId && this.hAJKAHEDEMM_.Equals(other.hAJKAHEDEMM_) && this.CIAFBNOKALL == other.CIAFBNOKALL && !(this.FPEGIACNKHH != other.FPEGIACNKHH) && this.iFENKDFNNEI_.Equals(other.iFENKDFNNEI_) && !(this.GADNLGEGDLA != other.GADNLGEGDLA) && !(this.HJEGMIGPECO != other.HJEGMIGPECO) && this.iCBONDMIJDC_.Equals(other.iCBONDMIJDC_) && this.hBAHKLCCCBG_.Equals(other.hBAHKLCCCBG_) && this.DEJJPHCJLBO == other.DEJJPHCJLBO && this.JBKCDEEIKKN == other.JBKCDEEIKKN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087B5 RID: 34741 RVA: 0x00165D84 File Offset: 0x00163F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LGCEACIAHBJ != 0UL)
			{
				num ^= this.LGCEACIAHBJ.GetHashCode();
			}
			if (this.ENPCCPAMDHK != 0U)
			{
				num ^= this.ENPCCPAMDHK.GetHashCode();
			}
			if (this.GAGHJMKACBM != 0UL)
			{
				num ^= this.GAGHJMKACBM.GetHashCode();
			}
			num ^= this.cKMKLNOAJAF_.GetHashCode();
			if (this.KEAOHKHKBCA != 0U)
			{
				num ^= this.KEAOHKHKBCA.GetHashCode();
			}
			if (this.DLCMPPCGJAL)
			{
				num ^= this.DLCMPPCGJAL.GetHashCode();
			}
			if (this.EILAKPNJBJN != 0U)
			{
				num ^= this.EILAKPNJBJN.GetHashCode();
			}
			if (this.PoolId != 0U)
			{
				num ^= this.PoolId.GetHashCode();
			}
			num ^= this.hAJKAHEDEMM_.GetHashCode();
			if (this.CIAFBNOKALL != 0U)
			{
				num ^= this.CIAFBNOKALL.GetHashCode();
			}
			if (this.FPEGIACNKHH.Length != 0)
			{
				num ^= this.FPEGIACNKHH.GetHashCode();
			}
			num ^= this.iFENKDFNNEI_.GetHashCode();
			if (this.GADNLGEGDLA.Length != 0)
			{
				num ^= this.GADNLGEGDLA.GetHashCode();
			}
			if (this.HJEGMIGPECO.Length != 0)
			{
				num ^= this.HJEGMIGPECO.GetHashCode();
			}
			num ^= this.iCBONDMIJDC_.GetHashCode();
			num ^= this.hBAHKLCCCBG_.GetHashCode();
			if (this.DEJJPHCJLBO != 0U)
			{
				num ^= this.DEJJPHCJLBO.GetHashCode();
			}
			if (this.JBKCDEEIKKN != 0UL)
			{
				num ^= this.JBKCDEEIKKN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x00165F3B File Offset: 0x0016413B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060087B7 RID: 34743 RVA: 0x00165F43 File Offset: 0x00164143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087B8 RID: 34744 RVA: 0x00165F4C File Offset: 0x0016414C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.iFENKDFNNEI_.WriteTo(ref output, NABJDLFFNAF._repeated_iFENKDFNNEI_codec);
			if (this.GAGHJMKACBM != 0UL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.GAGHJMKACBM);
			}
			if (this.KEAOHKHKBCA != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.KEAOHKHKBCA);
			}
			if (this.ENPCCPAMDHK != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ENPCCPAMDHK);
			}
			if (this.JBKCDEEIKKN != 0UL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.JBKCDEEIKKN);
			}
			if (this.DEJJPHCJLBO != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DEJJPHCJLBO);
			}
			if (this.CIAFBNOKALL != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.CIAFBNOKALL);
			}
			this.hAJKAHEDEMM_.WriteTo(ref output, NABJDLFFNAF._repeated_hAJKAHEDEMM_codec);
			this.cKMKLNOAJAF_.WriteTo(ref output, NABJDLFFNAF._repeated_cKMKLNOAJAF_codec);
			this.iCBONDMIJDC_.WriteTo(ref output, NABJDLFFNAF._repeated_iCBONDMIJDC_codec);
			this.hBAHKLCCCBG_.WriteTo(ref output, NABJDLFFNAF._repeated_hBAHKLCCCBG_codec);
			if (this.EILAKPNJBJN != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EILAKPNJBJN);
			}
			if (this.PoolId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.PoolId);
			}
			if (this.DLCMPPCGJAL)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.DLCMPPCGJAL);
			}
			if (this.LGCEACIAHBJ != 0UL)
			{
				output.WriteRawTag(120);
				output.WriteUInt64(this.LGCEACIAHBJ);
			}
			if (this.GADNLGEGDLA.Length != 0)
			{
				output.WriteRawTag(138, 61);
				output.WriteString(this.GADNLGEGDLA);
			}
			if (this.FPEGIACNKHH.Length != 0)
			{
				output.WriteRawTag(226, 91);
				output.WriteString(this.FPEGIACNKHH);
			}
			if (this.HJEGMIGPECO.Length != 0)
			{
				output.WriteRawTag(170, 112);
				output.WriteString(this.HJEGMIGPECO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087B9 RID: 34745 RVA: 0x0016614C File Offset: 0x0016434C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LGCEACIAHBJ != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LGCEACIAHBJ);
			}
			if (this.ENPCCPAMDHK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ENPCCPAMDHK);
			}
			if (this.GAGHJMKACBM != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GAGHJMKACBM);
			}
			num += this.cKMKLNOAJAF_.CalculateSize(NABJDLFFNAF._repeated_cKMKLNOAJAF_codec);
			if (this.KEAOHKHKBCA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KEAOHKHKBCA);
			}
			if (this.DLCMPPCGJAL)
			{
				num += 2;
			}
			if (this.EILAKPNJBJN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EILAKPNJBJN);
			}
			if (this.PoolId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PoolId);
			}
			num += this.hAJKAHEDEMM_.CalculateSize(NABJDLFFNAF._repeated_hAJKAHEDEMM_codec);
			if (this.CIAFBNOKALL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CIAFBNOKALL);
			}
			if (this.FPEGIACNKHH.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.FPEGIACNKHH);
			}
			num += this.iFENKDFNNEI_.CalculateSize(NABJDLFFNAF._repeated_iFENKDFNNEI_codec);
			if (this.GADNLGEGDLA.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.GADNLGEGDLA);
			}
			if (this.HJEGMIGPECO.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.HJEGMIGPECO);
			}
			num += this.iCBONDMIJDC_.CalculateSize(NABJDLFFNAF._repeated_iCBONDMIJDC_codec);
			num += this.hBAHKLCCCBG_.CalculateSize(NABJDLFFNAF._repeated_hBAHKLCCCBG_codec);
			if (this.DEJJPHCJLBO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DEJJPHCJLBO);
			}
			if (this.JBKCDEEIKKN != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.JBKCDEEIKKN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087BA RID: 34746 RVA: 0x0016630C File Offset: 0x0016450C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NABJDLFFNAF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LGCEACIAHBJ != 0UL)
			{
				this.LGCEACIAHBJ = other.LGCEACIAHBJ;
			}
			if (other.ENPCCPAMDHK != 0U)
			{
				this.ENPCCPAMDHK = other.ENPCCPAMDHK;
			}
			if (other.GAGHJMKACBM != 0UL)
			{
				this.GAGHJMKACBM = other.GAGHJMKACBM;
			}
			this.cKMKLNOAJAF_.Add(other.cKMKLNOAJAF_);
			if (other.KEAOHKHKBCA != 0U)
			{
				this.KEAOHKHKBCA = other.KEAOHKHKBCA;
			}
			if (other.DLCMPPCGJAL)
			{
				this.DLCMPPCGJAL = other.DLCMPPCGJAL;
			}
			if (other.EILAKPNJBJN != 0U)
			{
				this.EILAKPNJBJN = other.EILAKPNJBJN;
			}
			if (other.PoolId != 0U)
			{
				this.PoolId = other.PoolId;
			}
			this.hAJKAHEDEMM_.Add(other.hAJKAHEDEMM_);
			if (other.CIAFBNOKALL != 0U)
			{
				this.CIAFBNOKALL = other.CIAFBNOKALL;
			}
			if (other.FPEGIACNKHH.Length != 0)
			{
				this.FPEGIACNKHH = other.FPEGIACNKHH;
			}
			this.iFENKDFNNEI_.Add(other.iFENKDFNNEI_);
			if (other.GADNLGEGDLA.Length != 0)
			{
				this.GADNLGEGDLA = other.GADNLGEGDLA;
			}
			if (other.HJEGMIGPECO.Length != 0)
			{
				this.HJEGMIGPECO = other.HJEGMIGPECO;
			}
			this.iCBONDMIJDC_.Add(other.iCBONDMIJDC_);
			this.hBAHKLCCCBG_.Add(other.hBAHKLCCCBG_);
			if (other.DEJJPHCJLBO != 0U)
			{
				this.DEJJPHCJLBO = other.DEJJPHCJLBO;
			}
			if (other.JBKCDEEIKKN != 0UL)
			{
				this.JBKCDEEIKKN = other.JBKCDEEIKKN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060087BB RID: 34747 RVA: 0x0016649C File Offset: 0x0016469C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087BC RID: 34748 RVA: 0x001664A8 File Offset: 0x001646A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num <= 32U)
					{
						if (num <= 16U)
						{
							if (num == 10U)
							{
								this.iFENKDFNNEI_.AddEntriesFrom(ref input, NABJDLFFNAF._repeated_iFENKDFNNEI_codec);
								continue;
							}
							if (num == 16U)
							{
								this.GAGHJMKACBM = input.ReadUInt64();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.KEAOHKHKBCA = input.ReadUInt32();
								continue;
							}
							if (num == 32U)
							{
								this.ENPCCPAMDHK = input.ReadUInt32();
								continue;
							}
						}
					}
					else if (num <= 48U)
					{
						if (num == 40U)
						{
							this.JBKCDEEIKKN = input.ReadUInt64();
							continue;
						}
						if (num == 48U)
						{
							this.DEJJPHCJLBO = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.CIAFBNOKALL = input.ReadUInt32();
							continue;
						}
						if (num == 66U)
						{
							this.hAJKAHEDEMM_.AddEntriesFrom(ref input, NABJDLFFNAF._repeated_hAJKAHEDEMM_codec);
							continue;
						}
						if (num == 74U)
						{
							this.cKMKLNOAJAF_.AddEntriesFrom(ref input, NABJDLFFNAF._repeated_cKMKLNOAJAF_codec);
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num <= 90U)
					{
						if (num == 82U)
						{
							this.iCBONDMIJDC_.AddEntriesFrom(ref input, NABJDLFFNAF._repeated_iCBONDMIJDC_codec);
							continue;
						}
						if (num == 90U)
						{
							this.hBAHKLCCCBG_.AddEntriesFrom(ref input, NABJDLFFNAF._repeated_hBAHKLCCCBG_codec);
							continue;
						}
					}
					else
					{
						if (num == 96U)
						{
							this.EILAKPNJBJN = input.ReadUInt32();
							continue;
						}
						if (num == 104U)
						{
							this.PoolId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 120U)
				{
					if (num == 112U)
					{
						this.DLCMPPCGJAL = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.LGCEACIAHBJ = input.ReadUInt64();
						continue;
					}
				}
				else
				{
					if (num == 7818U)
					{
						this.GADNLGEGDLA = input.ReadString();
						continue;
					}
					if (num == 11746U)
					{
						this.FPEGIACNKHH = input.ReadString();
						continue;
					}
					if (num == 14378U)
					{
						this.HJEGMIGPECO = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040033E1 RID: 13281
		private static readonly MessageParser<NABJDLFFNAF> _parser = new MessageParser<NABJDLFFNAF>(() => new NABJDLFFNAF());

		// Token: 0x040033E2 RID: 13282
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033E3 RID: 13283
		public const int LGCEACIAHBJFieldNumber = 15;

		// Token: 0x040033E4 RID: 13284
		private ulong lGCEACIAHBJ_;

		// Token: 0x040033E5 RID: 13285
		public const int ENPCCPAMDHKFieldNumber = 4;

		// Token: 0x040033E6 RID: 13286
		private uint eNPCCPAMDHK_;

		// Token: 0x040033E7 RID: 13287
		public const int GAGHJMKACBMFieldNumber = 2;

		// Token: 0x040033E8 RID: 13288
		private ulong gAGHJMKACBM_;

		// Token: 0x040033E9 RID: 13289
		public const int CKMKLNOAJAFFieldNumber = 9;

		// Token: 0x040033EA RID: 13290
		private static readonly FieldCodec<DHIPMOLCCHJ> _repeated_cKMKLNOAJAF_codec = FieldCodec.ForMessage<DHIPMOLCCHJ>(74U, DHIPMOLCCHJ.Parser);

		// Token: 0x040033EB RID: 13291
		private readonly RepeatedField<DHIPMOLCCHJ> cKMKLNOAJAF_ = new RepeatedField<DHIPMOLCCHJ>();

		// Token: 0x040033EC RID: 13292
		public const int KEAOHKHKBCAFieldNumber = 3;

		// Token: 0x040033ED RID: 13293
		private uint kEAOHKHKBCA_;

		// Token: 0x040033EE RID: 13294
		public const int DLCMPPCGJALFieldNumber = 14;

		// Token: 0x040033EF RID: 13295
		private bool dLCMPPCGJAL_;

		// Token: 0x040033F0 RID: 13296
		public const int EILAKPNJBJNFieldNumber = 12;

		// Token: 0x040033F1 RID: 13297
		private uint eILAKPNJBJN_;

		// Token: 0x040033F2 RID: 13298
		public const int PoolIdFieldNumber = 13;

		// Token: 0x040033F3 RID: 13299
		private uint poolId_;

		// Token: 0x040033F4 RID: 13300
		public const int HAJKAHEDEMMFieldNumber = 8;

		// Token: 0x040033F5 RID: 13301
		private static readonly FieldCodec<KHBAFNOEJOE> _repeated_hAJKAHEDEMM_codec = FieldCodec.ForMessage<KHBAFNOEJOE>(66U, KHBAFNOEJOE.Parser);

		// Token: 0x040033F6 RID: 13302
		private readonly RepeatedField<KHBAFNOEJOE> hAJKAHEDEMM_ = new RepeatedField<KHBAFNOEJOE>();

		// Token: 0x040033F7 RID: 13303
		public const int CIAFBNOKALLFieldNumber = 7;

		// Token: 0x040033F8 RID: 13304
		private uint cIAFBNOKALL_;

		// Token: 0x040033F9 RID: 13305
		public const int FPEGIACNKHHFieldNumber = 1468;

		// Token: 0x040033FA RID: 13306
		private string fPEGIACNKHH_ = "";

		// Token: 0x040033FB RID: 13307
		public const int IFENKDFNNEIFieldNumber = 1;

		// Token: 0x040033FC RID: 13308
		private static readonly FieldCodec<DHIPMOLCCHJ> _repeated_iFENKDFNNEI_codec = FieldCodec.ForMessage<DHIPMOLCCHJ>(10U, DHIPMOLCCHJ.Parser);

		// Token: 0x040033FD RID: 13309
		private readonly RepeatedField<DHIPMOLCCHJ> iFENKDFNNEI_ = new RepeatedField<DHIPMOLCCHJ>();

		// Token: 0x040033FE RID: 13310
		public const int GADNLGEGDLAFieldNumber = 977;

		// Token: 0x040033FF RID: 13311
		private string gADNLGEGDLA_ = "";

		// Token: 0x04003400 RID: 13312
		public const int HJEGMIGPECOFieldNumber = 1797;

		// Token: 0x04003401 RID: 13313
		private string hJEGMIGPECO_ = "";

		// Token: 0x04003402 RID: 13314
		public const int ICBONDMIJDCFieldNumber = 10;

		// Token: 0x04003403 RID: 13315
		private static readonly FieldCodec<DHIPMOLCCHJ> _repeated_iCBONDMIJDC_codec = FieldCodec.ForMessage<DHIPMOLCCHJ>(82U, DHIPMOLCCHJ.Parser);

		// Token: 0x04003404 RID: 13316
		private readonly RepeatedField<DHIPMOLCCHJ> iCBONDMIJDC_ = new RepeatedField<DHIPMOLCCHJ>();

		// Token: 0x04003405 RID: 13317
		public const int HBAHKLCCCBGFieldNumber = 11;

		// Token: 0x04003406 RID: 13318
		private static readonly FieldCodec<DHIPMOLCCHJ> _repeated_hBAHKLCCCBG_codec = FieldCodec.ForMessage<DHIPMOLCCHJ>(90U, DHIPMOLCCHJ.Parser);

		// Token: 0x04003407 RID: 13319
		private readonly RepeatedField<DHIPMOLCCHJ> hBAHKLCCCBG_ = new RepeatedField<DHIPMOLCCHJ>();

		// Token: 0x04003408 RID: 13320
		public const int DEJJPHCJLBOFieldNumber = 6;

		// Token: 0x04003409 RID: 13321
		private uint dEJJPHCJLBO_;

		// Token: 0x0400340A RID: 13322
		public const int JBKCDEEIKKNFieldNumber = 5;

		// Token: 0x0400340B RID: 13323
		private ulong jBKCDEEIKKN_;
	}
}
