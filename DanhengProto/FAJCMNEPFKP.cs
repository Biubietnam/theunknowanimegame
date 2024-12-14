using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004FD RID: 1277
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FAJCMNEPFKP : IMessage<FAJCMNEPFKP>, IMessage, IEquatable<FAJCMNEPFKP>, IDeepCloneable<FAJCMNEPFKP>, IBufferMessage
	{
		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x0600391D RID: 14621 RVA: 0x0009CB65 File Offset: 0x0009AD65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FAJCMNEPFKP> Parser
		{
			get
			{
				return FAJCMNEPFKP._parser;
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x0009CB6C File Offset: 0x0009AD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FAJCMNEPFKPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x0600391F RID: 14623 RVA: 0x0009CB7E File Offset: 0x0009AD7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FAJCMNEPFKP.Descriptor;
			}
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x0009CB85 File Offset: 0x0009AD85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAJCMNEPFKP()
		{
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x0009CB90 File Offset: 0x0009AD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAJCMNEPFKP(FAJCMNEPFKP other) : this()
		{
			this.mKCHFNEOOMM_ = ((other.mKCHFNEOOMM_ != null) ? other.mKCHFNEOOMM_.Clone() : null);
			this.hDOJPDGNEBO_ = ((other.hDOJPDGNEBO_ != null) ? other.hDOJPDGNEBO_.Clone() : null);
			this.oHJHHAFMGIL_ = ((other.oHJHHAFMGIL_ != null) ? other.oHJHHAFMGIL_.Clone() : null);
			this.jFNKLMJNGLL_ = ((other.jFNKLMJNGLL_ != null) ? other.jFNKLMJNGLL_.Clone() : null);
			this.nLBKJHGCHDJ_ = ((other.nLBKJHGCHDJ_ != null) ? other.nLBKJHGCHDJ_.Clone() : null);
			this.lODOEOEBHPK_ = ((other.lODOEOEBHPK_ != null) ? other.lODOEOEBHPK_.Clone() : null);
			this.mGFCGKNCCCM_ = ((other.mGFCGKNCCCM_ != null) ? other.mGFCGKNCCCM_.Clone() : null);
			this.lNPKBCGHFBA_ = other.lNPKBCGHFBA_;
			this.gFBBLGMOCDN_ = other.gFBBLGMOCDN_;
			this.fIAAEFDIDDI_ = ((other.fIAAEFDIDDI_ != null) ? other.fIAAEFDIDDI_.Clone() : null);
			this.aENAJJCDGOD_ = ((other.aENAJJCDGOD_ != null) ? other.aENAJJCDGOD_.Clone() : null);
			this.pOPEMHPKLJO_ = other.pOPEMHPKLJO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x0009CCD4 File Offset: 0x0009AED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAJCMNEPFKP Clone()
		{
			return new FAJCMNEPFKP(this);
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x0009CCDC File Offset: 0x0009AEDC
		// (set) Token: 0x06003924 RID: 14628 RVA: 0x0009CCE4 File Offset: 0x0009AEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBGAPLLMHGD MKCHFNEOOMM
		{
			get
			{
				return this.mKCHFNEOOMM_;
			}
			set
			{
				this.mKCHFNEOOMM_ = value;
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x0009CCED File Offset: 0x0009AEED
		// (set) Token: 0x06003926 RID: 14630 RVA: 0x0009CCF5 File Offset: 0x0009AEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBOAMPMKCFH HDOJPDGNEBO
		{
			get
			{
				return this.hDOJPDGNEBO_;
			}
			set
			{
				this.hDOJPDGNEBO_ = value;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x0009CCFE File Offset: 0x0009AEFE
		// (set) Token: 0x06003928 RID: 14632 RVA: 0x0009CD06 File Offset: 0x0009AF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBOAMPMKCFH OHJHHAFMGIL
		{
			get
			{
				return this.oHJHHAFMGIL_;
			}
			set
			{
				this.oHJHHAFMGIL_ = value;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x0009CD0F File Offset: 0x0009AF0F
		// (set) Token: 0x0600392A RID: 14634 RVA: 0x0009CD17 File Offset: 0x0009AF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBHLEDPAPAL JFNKLMJNGLL
		{
			get
			{
				return this.jFNKLMJNGLL_;
			}
			set
			{
				this.jFNKLMJNGLL_ = value;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x0009CD20 File Offset: 0x0009AF20
		// (set) Token: 0x0600392C RID: 14636 RVA: 0x0009CD28 File Offset: 0x0009AF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FCDNGMIFCNO NLBKJHGCHDJ
		{
			get
			{
				return this.nLBKJHGCHDJ_;
			}
			set
			{
				this.nLBKJHGCHDJ_ = value;
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x0600392D RID: 14637 RVA: 0x0009CD31 File Offset: 0x0009AF31
		// (set) Token: 0x0600392E RID: 14638 RVA: 0x0009CD39 File Offset: 0x0009AF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AMHGAANHDMN LODOEOEBHPK
		{
			get
			{
				return this.lODOEOEBHPK_;
			}
			set
			{
				this.lODOEOEBHPK_ = value;
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x0009CD42 File Offset: 0x0009AF42
		// (set) Token: 0x06003930 RID: 14640 RVA: 0x0009CD4A File Offset: 0x0009AF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GIPDAFLPJNN MGFCGKNCCCM
		{
			get
			{
				return this.mGFCGKNCCCM_;
			}
			set
			{
				this.mGFCGKNCCCM_ = value;
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x0009CD53 File Offset: 0x0009AF53
		// (set) Token: 0x06003932 RID: 14642 RVA: 0x0009CD5B File Offset: 0x0009AF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LNPKBCGHFBA
		{
			get
			{
				return this.lNPKBCGHFBA_;
			}
			set
			{
				this.lNPKBCGHFBA_ = value;
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x0009CD64 File Offset: 0x0009AF64
		// (set) Token: 0x06003934 RID: 14644 RVA: 0x0009CD6C File Offset: 0x0009AF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GFBBLGMOCDN
		{
			get
			{
				return this.gFBBLGMOCDN_;
			}
			set
			{
				this.gFBBLGMOCDN_ = value;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x0009CD75 File Offset: 0x0009AF75
		// (set) Token: 0x06003936 RID: 14646 RVA: 0x0009CD7D File Offset: 0x0009AF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHHKEBFANLL FIAAEFDIDDI
		{
			get
			{
				return this.fIAAEFDIDDI_;
			}
			set
			{
				this.fIAAEFDIDDI_ = value;
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x0009CD86 File Offset: 0x0009AF86
		// (set) Token: 0x06003938 RID: 14648 RVA: 0x0009CD8E File Offset: 0x0009AF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMIDIIBGJLJ AENAJJCDGOD
		{
			get
			{
				return this.aENAJJCDGOD_;
			}
			set
			{
				this.aENAJJCDGOD_ = value;
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x0009CD97 File Offset: 0x0009AF97
		// (set) Token: 0x0600393A RID: 14650 RVA: 0x0009CD9F File Offset: 0x0009AF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POPEMHPKLJO
		{
			get
			{
				return this.pOPEMHPKLJO_;
			}
			set
			{
				this.pOPEMHPKLJO_ = value;
			}
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x0009CDA8 File Offset: 0x0009AFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FAJCMNEPFKP);
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x0009CDB8 File Offset: 0x0009AFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FAJCMNEPFKP other)
		{
			return other != null && (other == this || (object.Equals(this.MKCHFNEOOMM, other.MKCHFNEOOMM) && object.Equals(this.HDOJPDGNEBO, other.HDOJPDGNEBO) && object.Equals(this.OHJHHAFMGIL, other.OHJHHAFMGIL) && object.Equals(this.JFNKLMJNGLL, other.JFNKLMJNGLL) && object.Equals(this.NLBKJHGCHDJ, other.NLBKJHGCHDJ) && object.Equals(this.LODOEOEBHPK, other.LODOEOEBHPK) && object.Equals(this.MGFCGKNCCCM, other.MGFCGKNCCCM) && this.LNPKBCGHFBA == other.LNPKBCGHFBA && this.GFBBLGMOCDN == other.GFBBLGMOCDN && object.Equals(this.FIAAEFDIDDI, other.FIAAEFDIDDI) && object.Equals(this.AENAJJCDGOD, other.AENAJJCDGOD) && this.POPEMHPKLJO == other.POPEMHPKLJO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x0009CED0 File Offset: 0x0009B0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.mKCHFNEOOMM_ != null)
			{
				num ^= this.MKCHFNEOOMM.GetHashCode();
			}
			if (this.hDOJPDGNEBO_ != null)
			{
				num ^= this.HDOJPDGNEBO.GetHashCode();
			}
			if (this.oHJHHAFMGIL_ != null)
			{
				num ^= this.OHJHHAFMGIL.GetHashCode();
			}
			if (this.jFNKLMJNGLL_ != null)
			{
				num ^= this.JFNKLMJNGLL.GetHashCode();
			}
			if (this.nLBKJHGCHDJ_ != null)
			{
				num ^= this.NLBKJHGCHDJ.GetHashCode();
			}
			if (this.lODOEOEBHPK_ != null)
			{
				num ^= this.LODOEOEBHPK.GetHashCode();
			}
			if (this.mGFCGKNCCCM_ != null)
			{
				num ^= this.MGFCGKNCCCM.GetHashCode();
			}
			if (this.LNPKBCGHFBA != 0U)
			{
				num ^= this.LNPKBCGHFBA.GetHashCode();
			}
			if (this.GFBBLGMOCDN != 0U)
			{
				num ^= this.GFBBLGMOCDN.GetHashCode();
			}
			if (this.fIAAEFDIDDI_ != null)
			{
				num ^= this.FIAAEFDIDDI.GetHashCode();
			}
			if (this.aENAJJCDGOD_ != null)
			{
				num ^= this.AENAJJCDGOD.GetHashCode();
			}
			if (this.POPEMHPKLJO != 0U)
			{
				num ^= this.POPEMHPKLJO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x0009D007 File Offset: 0x0009B207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x0009D00F File Offset: 0x0009B20F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x0009D018 File Offset: 0x0009B218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nLBKJHGCHDJ_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NLBKJHGCHDJ);
			}
			if (this.hDOJPDGNEBO_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HDOJPDGNEBO);
			}
			if (this.mKCHFNEOOMM_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MKCHFNEOOMM);
			}
			if (this.mGFCGKNCCCM_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MGFCGKNCCCM);
			}
			if (this.jFNKLMJNGLL_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.JFNKLMJNGLL);
			}
			if (this.LNPKBCGHFBA != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.LNPKBCGHFBA);
			}
			if (this.lODOEOEBHPK_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.LODOEOEBHPK);
			}
			if (this.oHJHHAFMGIL_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.OHJHHAFMGIL);
			}
			if (this.fIAAEFDIDDI_ != null)
			{
				output.WriteRawTag(130, 21);
				output.WriteMessage(this.FIAAEFDIDDI);
			}
			if (this.aENAJJCDGOD_ != null)
			{
				output.WriteRawTag(242, 43);
				output.WriteMessage(this.AENAJJCDGOD);
			}
			if (this.POPEMHPKLJO != 0U)
			{
				output.WriteRawTag(160, 107);
				output.WriteUInt32(this.POPEMHPKLJO);
			}
			if (this.GFBBLGMOCDN != 0U)
			{
				output.WriteRawTag(208, 115);
				output.WriteUInt32(this.GFBBLGMOCDN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x0009D1A0 File Offset: 0x0009B3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.mKCHFNEOOMM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MKCHFNEOOMM);
			}
			if (this.hDOJPDGNEBO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HDOJPDGNEBO);
			}
			if (this.oHJHHAFMGIL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OHJHHAFMGIL);
			}
			if (this.jFNKLMJNGLL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JFNKLMJNGLL);
			}
			if (this.nLBKJHGCHDJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NLBKJHGCHDJ);
			}
			if (this.lODOEOEBHPK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LODOEOEBHPK);
			}
			if (this.mGFCGKNCCCM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MGFCGKNCCCM);
			}
			if (this.LNPKBCGHFBA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LNPKBCGHFBA);
			}
			if (this.GFBBLGMOCDN != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.GFBBLGMOCDN);
			}
			if (this.fIAAEFDIDDI_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FIAAEFDIDDI);
			}
			if (this.aENAJJCDGOD_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AENAJJCDGOD);
			}
			if (this.POPEMHPKLJO != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.POPEMHPKLJO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x0009D2E8 File Offset: 0x0009B4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FAJCMNEPFKP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.mKCHFNEOOMM_ != null)
			{
				if (this.mKCHFNEOOMM_ == null)
				{
					this.MKCHFNEOOMM = new JBGAPLLMHGD();
				}
				this.MKCHFNEOOMM.MergeFrom(other.MKCHFNEOOMM);
			}
			if (other.hDOJPDGNEBO_ != null)
			{
				if (this.hDOJPDGNEBO_ == null)
				{
					this.HDOJPDGNEBO = new MBOAMPMKCFH();
				}
				this.HDOJPDGNEBO.MergeFrom(other.HDOJPDGNEBO);
			}
			if (other.oHJHHAFMGIL_ != null)
			{
				if (this.oHJHHAFMGIL_ == null)
				{
					this.OHJHHAFMGIL = new MBOAMPMKCFH();
				}
				this.OHJHHAFMGIL.MergeFrom(other.OHJHHAFMGIL);
			}
			if (other.jFNKLMJNGLL_ != null)
			{
				if (this.jFNKLMJNGLL_ == null)
				{
					this.JFNKLMJNGLL = new OBHLEDPAPAL();
				}
				this.JFNKLMJNGLL.MergeFrom(other.JFNKLMJNGLL);
			}
			if (other.nLBKJHGCHDJ_ != null)
			{
				if (this.nLBKJHGCHDJ_ == null)
				{
					this.NLBKJHGCHDJ = new FCDNGMIFCNO();
				}
				this.NLBKJHGCHDJ.MergeFrom(other.NLBKJHGCHDJ);
			}
			if (other.lODOEOEBHPK_ != null)
			{
				if (this.lODOEOEBHPK_ == null)
				{
					this.LODOEOEBHPK = new AMHGAANHDMN();
				}
				this.LODOEOEBHPK.MergeFrom(other.LODOEOEBHPK);
			}
			if (other.mGFCGKNCCCM_ != null)
			{
				if (this.mGFCGKNCCCM_ == null)
				{
					this.MGFCGKNCCCM = new GIPDAFLPJNN();
				}
				this.MGFCGKNCCCM.MergeFrom(other.MGFCGKNCCCM);
			}
			if (other.LNPKBCGHFBA != 0U)
			{
				this.LNPKBCGHFBA = other.LNPKBCGHFBA;
			}
			if (other.GFBBLGMOCDN != 0U)
			{
				this.GFBBLGMOCDN = other.GFBBLGMOCDN;
			}
			if (other.fIAAEFDIDDI_ != null)
			{
				if (this.fIAAEFDIDDI_ == null)
				{
					this.FIAAEFDIDDI = new JHHKEBFANLL();
				}
				this.FIAAEFDIDDI.MergeFrom(other.FIAAEFDIDDI);
			}
			if (other.aENAJJCDGOD_ != null)
			{
				if (this.aENAJJCDGOD_ == null)
				{
					this.AENAJJCDGOD = new HMIDIIBGJLJ();
				}
				this.AENAJJCDGOD.MergeFrom(other.AENAJJCDGOD);
			}
			if (other.POPEMHPKLJO != 0U)
			{
				this.POPEMHPKLJO = other.POPEMHPKLJO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x0009D4D8 File Offset: 0x0009B6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x0009D4E4 File Offset: 0x0009B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
						{
							if (this.nLBKJHGCHDJ_ == null)
							{
								this.NLBKJHGCHDJ = new FCDNGMIFCNO();
							}
							input.ReadMessage(this.NLBKJHGCHDJ);
							continue;
						}
						if (num == 18U)
						{
							if (this.hDOJPDGNEBO_ == null)
							{
								this.HDOJPDGNEBO = new MBOAMPMKCFH();
							}
							input.ReadMessage(this.HDOJPDGNEBO);
							continue;
						}
						if (num == 26U)
						{
							if (this.mKCHFNEOOMM_ == null)
							{
								this.MKCHFNEOOMM = new JBGAPLLMHGD();
							}
							input.ReadMessage(this.MKCHFNEOOMM);
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.mGFCGKNCCCM_ == null)
							{
								this.MGFCGKNCCCM = new GIPDAFLPJNN();
							}
							input.ReadMessage(this.MGFCGKNCCCM);
							continue;
						}
						if (num == 42U)
						{
							if (this.jFNKLMJNGLL_ == null)
							{
								this.JFNKLMJNGLL = new OBHLEDPAPAL();
							}
							input.ReadMessage(this.JFNKLMJNGLL);
							continue;
						}
						if (num == 56U)
						{
							this.LNPKBCGHFBA = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 2690U)
				{
					if (num == 82U)
					{
						if (this.lODOEOEBHPK_ == null)
						{
							this.LODOEOEBHPK = new AMHGAANHDMN();
						}
						input.ReadMessage(this.LODOEOEBHPK);
						continue;
					}
					if (num == 122U)
					{
						if (this.oHJHHAFMGIL_ == null)
						{
							this.OHJHHAFMGIL = new MBOAMPMKCFH();
						}
						input.ReadMessage(this.OHJHHAFMGIL);
						continue;
					}
					if (num == 2690U)
					{
						if (this.fIAAEFDIDDI_ == null)
						{
							this.FIAAEFDIDDI = new JHHKEBFANLL();
						}
						input.ReadMessage(this.FIAAEFDIDDI);
						continue;
					}
				}
				else
				{
					if (num == 5618U)
					{
						if (this.aENAJJCDGOD_ == null)
						{
							this.AENAJJCDGOD = new HMIDIIBGJLJ();
						}
						input.ReadMessage(this.AENAJJCDGOD);
						continue;
					}
					if (num == 13728U)
					{
						this.POPEMHPKLJO = input.ReadUInt32();
						continue;
					}
					if (num == 14800U)
					{
						this.GFBBLGMOCDN = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040016AB RID: 5803
		private static readonly MessageParser<FAJCMNEPFKP> _parser = new MessageParser<FAJCMNEPFKP>(() => new FAJCMNEPFKP());

		// Token: 0x040016AC RID: 5804
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016AD RID: 5805
		public const int MKCHFNEOOMMFieldNumber = 3;

		// Token: 0x040016AE RID: 5806
		private JBGAPLLMHGD mKCHFNEOOMM_;

		// Token: 0x040016AF RID: 5807
		public const int HDOJPDGNEBOFieldNumber = 2;

		// Token: 0x040016B0 RID: 5808
		private MBOAMPMKCFH hDOJPDGNEBO_;

		// Token: 0x040016B1 RID: 5809
		public const int OHJHHAFMGILFieldNumber = 15;

		// Token: 0x040016B2 RID: 5810
		private MBOAMPMKCFH oHJHHAFMGIL_;

		// Token: 0x040016B3 RID: 5811
		public const int JFNKLMJNGLLFieldNumber = 5;

		// Token: 0x040016B4 RID: 5812
		private OBHLEDPAPAL jFNKLMJNGLL_;

		// Token: 0x040016B5 RID: 5813
		public const int NLBKJHGCHDJFieldNumber = 1;

		// Token: 0x040016B6 RID: 5814
		private FCDNGMIFCNO nLBKJHGCHDJ_;

		// Token: 0x040016B7 RID: 5815
		public const int LODOEOEBHPKFieldNumber = 10;

		// Token: 0x040016B8 RID: 5816
		private AMHGAANHDMN lODOEOEBHPK_;

		// Token: 0x040016B9 RID: 5817
		public const int MGFCGKNCCCMFieldNumber = 4;

		// Token: 0x040016BA RID: 5818
		private GIPDAFLPJNN mGFCGKNCCCM_;

		// Token: 0x040016BB RID: 5819
		public const int LNPKBCGHFBAFieldNumber = 7;

		// Token: 0x040016BC RID: 5820
		private uint lNPKBCGHFBA_;

		// Token: 0x040016BD RID: 5821
		public const int GFBBLGMOCDNFieldNumber = 1850;

		// Token: 0x040016BE RID: 5822
		private uint gFBBLGMOCDN_;

		// Token: 0x040016BF RID: 5823
		public const int FIAAEFDIDDIFieldNumber = 336;

		// Token: 0x040016C0 RID: 5824
		private JHHKEBFANLL fIAAEFDIDDI_;

		// Token: 0x040016C1 RID: 5825
		public const int AENAJJCDGODFieldNumber = 702;

		// Token: 0x040016C2 RID: 5826
		private HMIDIIBGJLJ aENAJJCDGOD_;

		// Token: 0x040016C3 RID: 5827
		public const int POPEMHPKLJOFieldNumber = 1716;

		// Token: 0x040016C4 RID: 5828
		private uint pOPEMHPKLJO_;
	}
}
