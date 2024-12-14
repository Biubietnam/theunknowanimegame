using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000973 RID: 2419
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JLBBLNCEJPP : IMessage<JLBBLNCEJPP>, IMessage, IEquatable<JLBBLNCEJPP>, IDeepCloneable<JLBBLNCEJPP>, IBufferMessage
	{
		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x06006C0F RID: 27663 RVA: 0x001201B0 File Offset: 0x0011E3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JLBBLNCEJPP> Parser
		{
			get
			{
				return JLBBLNCEJPP._parser;
			}
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x06006C10 RID: 27664 RVA: 0x001201B7 File Offset: 0x0011E3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JLBBLNCEJPPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x06006C11 RID: 27665 RVA: 0x001201C9 File Offset: 0x0011E3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JLBBLNCEJPP.Descriptor;
			}
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x001201D0 File Offset: 0x0011E3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLBBLNCEJPP()
		{
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x001201D8 File Offset: 0x0011E3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLBBLNCEJPP(JLBBLNCEJPP other) : this()
		{
			this.hMPCEPIBOFI_ = ((other.hMPCEPIBOFI_ != null) ? other.hMPCEPIBOFI_.Clone() : null);
			this.ePHEKAMBONB_ = ((other.ePHEKAMBONB_ != null) ? other.ePHEKAMBONB_.Clone() : null);
			this.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_ = ((other.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_ != null) ? other.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_.Clone() : null);
			this.cJJAEFCIMGD_ = ((other.cJJAEFCIMGD_ != null) ? other.cJJAEFCIMGD_.Clone() : null);
			this.getBuffList_ = ((other.getBuffList_ != null) ? other.getBuffList_.Clone() : null);
			this.removeBuffList_ = ((other.removeBuffList_ != null) ? other.removeBuffList_.Clone() : null);
			this.nIPGEFPKBJG_ = ((other.nIPGEFPKBJG_ != null) ? other.nIPGEFPKBJG_.Clone() : null);
			this.lOEHJNMPJAK_ = ((other.lOEHJNMPJAK_ != null) ? other.lOEHJNMPJAK_.Clone() : null);
			this.cAFCHIBNLNM_ = ((other.cAFCHIBNLNM_ != null) ? other.cAFCHIBNLNM_.Clone() : null);
			this.kABHLAEPBHC_ = ((other.kABHLAEPBHC_ != null) ? other.kABHLAEPBHC_.Clone() : null);
			this.jOABIMPBDPA_ = ((other.jOABIMPBDPA_ != null) ? other.jOABIMPBDPA_.Clone() : null);
			this.gDGIJKBBBNE_ = ((other.gDGIJKBBBNE_ != null) ? other.gDGIJKBBBNE_.Clone() : null);
			this.jPJICBLLLAL_ = ((other.jPJICBLLLAL_ != null) ? other.jPJICBLLLAL_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x00120368 File Offset: 0x0011E568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLBBLNCEJPP Clone()
		{
			return new JLBBLNCEJPP(this);
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x06006C15 RID: 27669 RVA: 0x00120370 File Offset: 0x0011E570
		// (set) Token: 0x06006C16 RID: 27670 RVA: 0x00120378 File Offset: 0x0011E578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMKBIJDAEPM HMPCEPIBOFI
		{
			get
			{
				return this.hMPCEPIBOFI_;
			}
			set
			{
				this.hMPCEPIBOFI_ = value;
			}
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x06006C17 RID: 27671 RVA: 0x00120381 File Offset: 0x0011E581
		// (set) Token: 0x06006C18 RID: 27672 RVA: 0x00120389 File Offset: 0x0011E589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMKBIJDAEPM EPHEKAMBONB
		{
			get
			{
				return this.ePHEKAMBONB_;
			}
			set
			{
				this.ePHEKAMBONB_ = value;
			}
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x06006C19 RID: 27673 RVA: 0x00120392 File Offset: 0x0011E592
		// (set) Token: 0x06006C1A RID: 27674 RVA: 0x0012039A File Offset: 0x0011E59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MONFGAKJBGN MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE
		{
			get
			{
				return this.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_;
			}
			set
			{
				this.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_ = value;
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x06006C1B RID: 27675 RVA: 0x001203A3 File Offset: 0x0011E5A3
		// (set) Token: 0x06006C1C RID: 27676 RVA: 0x001203AB File Offset: 0x0011E5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MONFGAKJBGN CJJAEFCIMGD
		{
			get
			{
				return this.cJJAEFCIMGD_;
			}
			set
			{
				this.cJJAEFCIMGD_ = value;
			}
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06006C1D RID: 27677 RVA: 0x001203B4 File Offset: 0x0011E5B4
		// (set) Token: 0x06006C1E RID: 27678 RVA: 0x001203BC File Offset: 0x0011E5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EAHJNKMLDHG GetBuffList
		{
			get
			{
				return this.getBuffList_;
			}
			set
			{
				this.getBuffList_ = value;
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06006C1F RID: 27679 RVA: 0x001203C5 File Offset: 0x0011E5C5
		// (set) Token: 0x06006C20 RID: 27680 RVA: 0x001203CD File Offset: 0x0011E5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EAHJNKMLDHG RemoveBuffList
		{
			get
			{
				return this.removeBuffList_;
			}
			set
			{
				this.removeBuffList_ = value;
			}
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06006C21 RID: 27681 RVA: 0x001203D6 File Offset: 0x0011E5D6
		// (set) Token: 0x06006C22 RID: 27682 RVA: 0x001203DE File Offset: 0x0011E5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CKIDOMIINKI NIPGEFPKBJG
		{
			get
			{
				return this.nIPGEFPKBJG_;
			}
			set
			{
				this.nIPGEFPKBJG_ = value;
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06006C23 RID: 27683 RVA: 0x001203E7 File Offset: 0x0011E5E7
		// (set) Token: 0x06006C24 RID: 27684 RVA: 0x001203EF File Offset: 0x0011E5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CKIDOMIINKI LOEHJNMPJAK
		{
			get
			{
				return this.lOEHJNMPJAK_;
			}
			set
			{
				this.lOEHJNMPJAK_ = value;
			}
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x06006C25 RID: 27685 RVA: 0x001203F8 File Offset: 0x0011E5F8
		// (set) Token: 0x06006C26 RID: 27686 RVA: 0x00120400 File Offset: 0x0011E600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GJNPFNDEHGL CAFCHIBNLNM
		{
			get
			{
				return this.cAFCHIBNLNM_;
			}
			set
			{
				this.cAFCHIBNLNM_ = value;
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x06006C27 RID: 27687 RVA: 0x00120409 File Offset: 0x0011E609
		// (set) Token: 0x06006C28 RID: 27688 RVA: 0x00120411 File Offset: 0x0011E611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NAJJJDCIDOM KABHLAEPBHC
		{
			get
			{
				return this.kABHLAEPBHC_;
			}
			set
			{
				this.kABHLAEPBHC_ = value;
			}
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x06006C29 RID: 27689 RVA: 0x0012041A File Offset: 0x0011E61A
		// (set) Token: 0x06006C2A RID: 27690 RVA: 0x00120422 File Offset: 0x0011E622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EAHJNKMLDHG JOABIMPBDPA
		{
			get
			{
				return this.jOABIMPBDPA_;
			}
			set
			{
				this.jOABIMPBDPA_ = value;
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06006C2B RID: 27691 RVA: 0x0012042B File Offset: 0x0011E62B
		// (set) Token: 0x06006C2C RID: 27692 RVA: 0x00120433 File Offset: 0x0011E633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CKIDOMIINKI GDGIJKBBBNE
		{
			get
			{
				return this.gDGIJKBBBNE_;
			}
			set
			{
				this.gDGIJKBBBNE_ = value;
			}
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x06006C2D RID: 27693 RVA: 0x0012043C File Offset: 0x0011E63C
		// (set) Token: 0x06006C2E RID: 27694 RVA: 0x00120444 File Offset: 0x0011E644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DOGNBLOFDOL JPJICBLLLAL
		{
			get
			{
				return this.jPJICBLLLAL_;
			}
			set
			{
				this.jPJICBLLLAL_ = value;
			}
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x0012044D File Offset: 0x0011E64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JLBBLNCEJPP);
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x0012045C File Offset: 0x0011E65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JLBBLNCEJPP other)
		{
			return other != null && (other == this || (object.Equals(this.HMPCEPIBOFI, other.HMPCEPIBOFI) && object.Equals(this.EPHEKAMBONB, other.EPHEKAMBONB) && object.Equals(this.MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE, other.MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE) && object.Equals(this.CJJAEFCIMGD, other.CJJAEFCIMGD) && object.Equals(this.GetBuffList, other.GetBuffList) && object.Equals(this.RemoveBuffList, other.RemoveBuffList) && object.Equals(this.NIPGEFPKBJG, other.NIPGEFPKBJG) && object.Equals(this.LOEHJNMPJAK, other.LOEHJNMPJAK) && object.Equals(this.CAFCHIBNLNM, other.CAFCHIBNLNM) && object.Equals(this.KABHLAEPBHC, other.KABHLAEPBHC) && object.Equals(this.JOABIMPBDPA, other.JOABIMPBDPA) && object.Equals(this.GDGIJKBBBNE, other.GDGIJKBBBNE) && object.Equals(this.JPJICBLLLAL, other.JPJICBLLLAL) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x00120598 File Offset: 0x0011E798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hMPCEPIBOFI_ != null)
			{
				num ^= this.HMPCEPIBOFI.GetHashCode();
			}
			if (this.ePHEKAMBONB_ != null)
			{
				num ^= this.EPHEKAMBONB.GetHashCode();
			}
			if (this.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_ != null)
			{
				num ^= this.MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE.GetHashCode();
			}
			if (this.cJJAEFCIMGD_ != null)
			{
				num ^= this.CJJAEFCIMGD.GetHashCode();
			}
			if (this.getBuffList_ != null)
			{
				num ^= this.GetBuffList.GetHashCode();
			}
			if (this.removeBuffList_ != null)
			{
				num ^= this.RemoveBuffList.GetHashCode();
			}
			if (this.nIPGEFPKBJG_ != null)
			{
				num ^= this.NIPGEFPKBJG.GetHashCode();
			}
			if (this.lOEHJNMPJAK_ != null)
			{
				num ^= this.LOEHJNMPJAK.GetHashCode();
			}
			if (this.cAFCHIBNLNM_ != null)
			{
				num ^= this.CAFCHIBNLNM.GetHashCode();
			}
			if (this.kABHLAEPBHC_ != null)
			{
				num ^= this.KABHLAEPBHC.GetHashCode();
			}
			if (this.jOABIMPBDPA_ != null)
			{
				num ^= this.JOABIMPBDPA.GetHashCode();
			}
			if (this.gDGIJKBBBNE_ != null)
			{
				num ^= this.GDGIJKBBBNE.GetHashCode();
			}
			if (this.jPJICBLLLAL_ != null)
			{
				num ^= this.JPJICBLLLAL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x001206DC File Offset: 0x0011E8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x001206E4 File Offset: 0x0011E8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x001206F0 File Offset: 0x0011E8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lOEHJNMPJAK_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.LOEHJNMPJAK);
			}
			if (this.gDGIJKBBBNE_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GDGIJKBBBNE);
			}
			if (this.kABHLAEPBHC_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.KABHLAEPBHC);
			}
			if (this.jOABIMPBDPA_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.JOABIMPBDPA);
			}
			if (this.getBuffList_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.GetBuffList);
			}
			if (this.cAFCHIBNLNM_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CAFCHIBNLNM);
			}
			if (this.cJJAEFCIMGD_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CJJAEFCIMGD);
			}
			if (this.ePHEKAMBONB_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EPHEKAMBONB);
			}
			if (this.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE);
			}
			if (this.hMPCEPIBOFI_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.HMPCEPIBOFI);
			}
			if (this.removeBuffList_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RemoveBuffList);
			}
			if (this.nIPGEFPKBJG_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.NIPGEFPKBJG);
			}
			if (this.jPJICBLLLAL_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.JPJICBLLLAL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x00120880 File Offset: 0x0011EA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hMPCEPIBOFI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HMPCEPIBOFI);
			}
			if (this.ePHEKAMBONB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EPHEKAMBONB);
			}
			if (this.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE);
			}
			if (this.cJJAEFCIMGD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CJJAEFCIMGD);
			}
			if (this.getBuffList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GetBuffList);
			}
			if (this.removeBuffList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemoveBuffList);
			}
			if (this.nIPGEFPKBJG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NIPGEFPKBJG);
			}
			if (this.lOEHJNMPJAK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LOEHJNMPJAK);
			}
			if (this.cAFCHIBNLNM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CAFCHIBNLNM);
			}
			if (this.kABHLAEPBHC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KABHLAEPBHC);
			}
			if (this.jOABIMPBDPA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JOABIMPBDPA);
			}
			if (this.gDGIJKBBBNE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GDGIJKBBBNE);
			}
			if (this.jPJICBLLLAL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JPJICBLLLAL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x001209E0 File Offset: 0x0011EBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JLBBLNCEJPP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hMPCEPIBOFI_ != null)
			{
				if (this.hMPCEPIBOFI_ == null)
				{
					this.HMPCEPIBOFI = new BMKBIJDAEPM();
				}
				this.HMPCEPIBOFI.MergeFrom(other.HMPCEPIBOFI);
			}
			if (other.ePHEKAMBONB_ != null)
			{
				if (this.ePHEKAMBONB_ == null)
				{
					this.EPHEKAMBONB = new BMKBIJDAEPM();
				}
				this.EPHEKAMBONB.MergeFrom(other.EPHEKAMBONB);
			}
			if (other.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_ != null)
			{
				if (this.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_ == null)
				{
					this.MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE = new MONFGAKJBGN();
				}
				this.MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE.MergeFrom(other.MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE);
			}
			if (other.cJJAEFCIMGD_ != null)
			{
				if (this.cJJAEFCIMGD_ == null)
				{
					this.CJJAEFCIMGD = new MONFGAKJBGN();
				}
				this.CJJAEFCIMGD.MergeFrom(other.CJJAEFCIMGD);
			}
			if (other.getBuffList_ != null)
			{
				if (this.getBuffList_ == null)
				{
					this.GetBuffList = new EAHJNKMLDHG();
				}
				this.GetBuffList.MergeFrom(other.GetBuffList);
			}
			if (other.removeBuffList_ != null)
			{
				if (this.removeBuffList_ == null)
				{
					this.RemoveBuffList = new EAHJNKMLDHG();
				}
				this.RemoveBuffList.MergeFrom(other.RemoveBuffList);
			}
			if (other.nIPGEFPKBJG_ != null)
			{
				if (this.nIPGEFPKBJG_ == null)
				{
					this.NIPGEFPKBJG = new CKIDOMIINKI();
				}
				this.NIPGEFPKBJG.MergeFrom(other.NIPGEFPKBJG);
			}
			if (other.lOEHJNMPJAK_ != null)
			{
				if (this.lOEHJNMPJAK_ == null)
				{
					this.LOEHJNMPJAK = new CKIDOMIINKI();
				}
				this.LOEHJNMPJAK.MergeFrom(other.LOEHJNMPJAK);
			}
			if (other.cAFCHIBNLNM_ != null)
			{
				if (this.cAFCHIBNLNM_ == null)
				{
					this.CAFCHIBNLNM = new GJNPFNDEHGL();
				}
				this.CAFCHIBNLNM.MergeFrom(other.CAFCHIBNLNM);
			}
			if (other.kABHLAEPBHC_ != null)
			{
				if (this.kABHLAEPBHC_ == null)
				{
					this.KABHLAEPBHC = new NAJJJDCIDOM();
				}
				this.KABHLAEPBHC.MergeFrom(other.KABHLAEPBHC);
			}
			if (other.jOABIMPBDPA_ != null)
			{
				if (this.jOABIMPBDPA_ == null)
				{
					this.JOABIMPBDPA = new EAHJNKMLDHG();
				}
				this.JOABIMPBDPA.MergeFrom(other.JOABIMPBDPA);
			}
			if (other.gDGIJKBBBNE_ != null)
			{
				if (this.gDGIJKBBBNE_ == null)
				{
					this.GDGIJKBBBNE = new CKIDOMIINKI();
				}
				this.GDGIJKBBBNE.MergeFrom(other.GDGIJKBBBNE);
			}
			if (other.jPJICBLLLAL_ != null)
			{
				if (this.jPJICBLLLAL_ == null)
				{
					this.JPJICBLLLAL = new DOGNBLOFDOL();
				}
				this.JPJICBLLLAL.MergeFrom(other.JPJICBLLLAL);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x00120C44 File Offset: 0x0011EE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x00120C50 File Offset: 0x0011EE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
						{
							if (this.lOEHJNMPJAK_ == null)
							{
								this.LOEHJNMPJAK = new CKIDOMIINKI();
							}
							input.ReadMessage(this.LOEHJNMPJAK);
							continue;
						}
						if (num == 18U)
						{
							if (this.gDGIJKBBBNE_ == null)
							{
								this.GDGIJKBBBNE = new CKIDOMIINKI();
							}
							input.ReadMessage(this.GDGIJKBBBNE);
							continue;
						}
						if (num == 26U)
						{
							if (this.kABHLAEPBHC_ == null)
							{
								this.KABHLAEPBHC = new NAJJJDCIDOM();
							}
							input.ReadMessage(this.KABHLAEPBHC);
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.jOABIMPBDPA_ == null)
							{
								this.JOABIMPBDPA = new EAHJNKMLDHG();
							}
							input.ReadMessage(this.JOABIMPBDPA);
							continue;
						}
						if (num == 42U)
						{
							if (this.getBuffList_ == null)
							{
								this.GetBuffList = new EAHJNKMLDHG();
							}
							input.ReadMessage(this.GetBuffList);
							continue;
						}
						if (num == 50U)
						{
							if (this.cAFCHIBNLNM_ == null)
							{
								this.CAFCHIBNLNM = new GJNPFNDEHGL();
							}
							input.ReadMessage(this.CAFCHIBNLNM);
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 66U)
					{
						if (this.cJJAEFCIMGD_ == null)
						{
							this.CJJAEFCIMGD = new MONFGAKJBGN();
						}
						input.ReadMessage(this.CJJAEFCIMGD);
						continue;
					}
					if (num == 82U)
					{
						if (this.ePHEKAMBONB_ == null)
						{
							this.EPHEKAMBONB = new BMKBIJDAEPM();
						}
						input.ReadMessage(this.EPHEKAMBONB);
						continue;
					}
					if (num == 90U)
					{
						if (this.mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_ == null)
						{
							this.MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE = new MONFGAKJBGN();
						}
						input.ReadMessage(this.MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE);
						continue;
					}
				}
				else if (num <= 106U)
				{
					if (num == 98U)
					{
						if (this.hMPCEPIBOFI_ == null)
						{
							this.HMPCEPIBOFI = new BMKBIJDAEPM();
						}
						input.ReadMessage(this.HMPCEPIBOFI);
						continue;
					}
					if (num == 106U)
					{
						if (this.removeBuffList_ == null)
						{
							this.RemoveBuffList = new EAHJNKMLDHG();
						}
						input.ReadMessage(this.RemoveBuffList);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.nIPGEFPKBJG_ == null)
						{
							this.NIPGEFPKBJG = new CKIDOMIINKI();
						}
						input.ReadMessage(this.NIPGEFPKBJG);
						continue;
					}
					if (num == 122U)
					{
						if (this.jPJICBLLLAL_ == null)
						{
							this.JPJICBLLLAL = new DOGNBLOFDOL();
						}
						input.ReadMessage(this.JPJICBLLLAL);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002959 RID: 10585
		private static readonly MessageParser<JLBBLNCEJPP> _parser = new MessageParser<JLBBLNCEJPP>(() => new JLBBLNCEJPP());

		// Token: 0x0400295A RID: 10586
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400295B RID: 10587
		public const int HMPCEPIBOFIFieldNumber = 12;

		// Token: 0x0400295C RID: 10588
		private BMKBIJDAEPM hMPCEPIBOFI_;

		// Token: 0x0400295D RID: 10589
		public const int EPHEKAMBONBFieldNumber = 10;

		// Token: 0x0400295E RID: 10590
		private BMKBIJDAEPM ePHEKAMBONB_;

		// Token: 0x0400295F RID: 10591
		public const int MONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADEFieldNumber = 11;

		// Token: 0x04002960 RID: 10592
		private MONFGAKJBGN mONOPOLYACTIONRESULTSOURCETYPEASSETUPGRADE_;

		// Token: 0x04002961 RID: 10593
		public const int CJJAEFCIMGDFieldNumber = 8;

		// Token: 0x04002962 RID: 10594
		private MONFGAKJBGN cJJAEFCIMGD_;

		// Token: 0x04002963 RID: 10595
		public const int GetBuffListFieldNumber = 5;

		// Token: 0x04002964 RID: 10596
		private EAHJNKMLDHG getBuffList_;

		// Token: 0x04002965 RID: 10597
		public const int RemoveBuffListFieldNumber = 13;

		// Token: 0x04002966 RID: 10598
		private EAHJNKMLDHG removeBuffList_;

		// Token: 0x04002967 RID: 10599
		public const int NIPGEFPKBJGFieldNumber = 14;

		// Token: 0x04002968 RID: 10600
		private CKIDOMIINKI nIPGEFPKBJG_;

		// Token: 0x04002969 RID: 10601
		public const int LOEHJNMPJAKFieldNumber = 1;

		// Token: 0x0400296A RID: 10602
		private CKIDOMIINKI lOEHJNMPJAK_;

		// Token: 0x0400296B RID: 10603
		public const int CAFCHIBNLNMFieldNumber = 6;

		// Token: 0x0400296C RID: 10604
		private GJNPFNDEHGL cAFCHIBNLNM_;

		// Token: 0x0400296D RID: 10605
		public const int KABHLAEPBHCFieldNumber = 3;

		// Token: 0x0400296E RID: 10606
		private NAJJJDCIDOM kABHLAEPBHC_;

		// Token: 0x0400296F RID: 10607
		public const int JOABIMPBDPAFieldNumber = 4;

		// Token: 0x04002970 RID: 10608
		private EAHJNKMLDHG jOABIMPBDPA_;

		// Token: 0x04002971 RID: 10609
		public const int GDGIJKBBBNEFieldNumber = 2;

		// Token: 0x04002972 RID: 10610
		private CKIDOMIINKI gDGIJKBBBNE_;

		// Token: 0x04002973 RID: 10611
		public const int JPJICBLLLALFieldNumber = 15;

		// Token: 0x04002974 RID: 10612
		private DOGNBLOFDOL jPJICBLLLAL_;
	}
}
