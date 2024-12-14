using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000399 RID: 921
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DHPIFKICOPP : IMessage<DHPIFKICOPP>, IMessage, IEquatable<DHPIFKICOPP>, IDeepCloneable<DHPIFKICOPP>, IBufferMessage
	{
		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x00071C31 File Offset: 0x0006FE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DHPIFKICOPP> Parser
		{
			get
			{
				return DHPIFKICOPP._parser;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060028EA RID: 10474 RVA: 0x00071C38 File Offset: 0x0006FE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DHPIFKICOPPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x00071C4A File Offset: 0x0006FE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DHPIFKICOPP.Descriptor;
			}
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x00071C51 File Offset: 0x0006FE51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHPIFKICOPP()
		{
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00071C5C File Offset: 0x0006FE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHPIFKICOPP(DHPIFKICOPP other) : this()
		{
			this.iFJMIECLKCL_ = other.iFJMIECLKCL_;
			this.nENDGHABLAM_ = other.nENDGHABLAM_;
			this.eNJIEEPCJCI_ = other.eNJIEEPCJCI_;
			this.cCFBCJEHGDF_ = other.cCFBCJEHGDF_;
			this.jINIGJMLDLM_ = other.jINIGJMLDLM_;
			this.aELHCMNNNEJ_ = other.aELHCMNNNEJ_;
			this.nIJCHGMMCHB_ = other.nIJCHGMMCHB_;
			this.hFHGNEFHPKA_ = other.hFHGNEFHPKA_;
			this.mOFJPIEOICM_ = other.mOFJPIEOICM_;
			this.jACBDAEENHP_ = other.jACBDAEENHP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00071CF8 File Offset: 0x0006FEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHPIFKICOPP Clone()
		{
			return new DHPIFKICOPP(this);
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x00071D00 File Offset: 0x0006FF00
		// (set) Token: 0x060028F0 RID: 10480 RVA: 0x00071D08 File Offset: 0x0006FF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IFJMIECLKCL
		{
			get
			{
				return this.iFJMIECLKCL_;
			}
			set
			{
				this.iFJMIECLKCL_ = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x00071D11 File Offset: 0x0006FF11
		// (set) Token: 0x060028F2 RID: 10482 RVA: 0x00071D19 File Offset: 0x0006FF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NENDGHABLAM
		{
			get
			{
				return this.nENDGHABLAM_;
			}
			set
			{
				this.nENDGHABLAM_ = value;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x00071D22 File Offset: 0x0006FF22
		// (set) Token: 0x060028F4 RID: 10484 RVA: 0x00071D2A File Offset: 0x0006FF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ENJIEEPCJCI
		{
			get
			{
				return this.eNJIEEPCJCI_;
			}
			set
			{
				this.eNJIEEPCJCI_ = value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x00071D33 File Offset: 0x0006FF33
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x00071D3B File Offset: 0x0006FF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CCFBCJEHGDF
		{
			get
			{
				return this.cCFBCJEHGDF_;
			}
			set
			{
				this.cCFBCJEHGDF_ = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x00071D44 File Offset: 0x0006FF44
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x00071D4C File Offset: 0x0006FF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JINIGJMLDLM
		{
			get
			{
				return this.jINIGJMLDLM_;
			}
			set
			{
				this.jINIGJMLDLM_ = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x00071D55 File Offset: 0x0006FF55
		// (set) Token: 0x060028FA RID: 10490 RVA: 0x00071D5D File Offset: 0x0006FF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AELHCMNNNEJ
		{
			get
			{
				return this.aELHCMNNNEJ_;
			}
			set
			{
				this.aELHCMNNNEJ_ = value;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x00071D66 File Offset: 0x0006FF66
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x00071D6E File Offset: 0x0006FF6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NIJCHGMMCHB
		{
			get
			{
				return this.nIJCHGMMCHB_;
			}
			set
			{
				this.nIJCHGMMCHB_ = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x00071D77 File Offset: 0x0006FF77
		// (set) Token: 0x060028FE RID: 10494 RVA: 0x00071D7F File Offset: 0x0006FF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HFHGNEFHPKA
		{
			get
			{
				return this.hFHGNEFHPKA_;
			}
			set
			{
				this.hFHGNEFHPKA_ = value;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x00071D88 File Offset: 0x0006FF88
		// (set) Token: 0x06002900 RID: 10496 RVA: 0x00071D90 File Offset: 0x0006FF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MOFJPIEOICM
		{
			get
			{
				return this.mOFJPIEOICM_;
			}
			set
			{
				this.mOFJPIEOICM_ = value;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x00071D99 File Offset: 0x0006FF99
		// (set) Token: 0x06002902 RID: 10498 RVA: 0x00071DA1 File Offset: 0x0006FFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JACBDAEENHP
		{
			get
			{
				return this.jACBDAEENHP_;
			}
			set
			{
				this.jACBDAEENHP_ = value;
			}
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00071DAA File Offset: 0x0006FFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DHPIFKICOPP);
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x00071DB8 File Offset: 0x0006FFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DHPIFKICOPP other)
		{
			return other != null && (other == this || (this.IFJMIECLKCL == other.IFJMIECLKCL && this.NENDGHABLAM == other.NENDGHABLAM && this.ENJIEEPCJCI == other.ENJIEEPCJCI && this.CCFBCJEHGDF == other.CCFBCJEHGDF && this.JINIGJMLDLM == other.JINIGJMLDLM && this.AELHCMNNNEJ == other.AELHCMNNNEJ && this.NIJCHGMMCHB == other.NIJCHGMMCHB && this.HFHGNEFHPKA == other.HFHGNEFHPKA && this.MOFJPIEOICM == other.MOFJPIEOICM && this.JACBDAEENHP == other.JACBDAEENHP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00071E84 File Offset: 0x00070084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IFJMIECLKCL != 0U)
			{
				num ^= this.IFJMIECLKCL.GetHashCode();
			}
			if (this.NENDGHABLAM != 0U)
			{
				num ^= this.NENDGHABLAM.GetHashCode();
			}
			if (this.ENJIEEPCJCI != 0U)
			{
				num ^= this.ENJIEEPCJCI.GetHashCode();
			}
			if (this.CCFBCJEHGDF != 0U)
			{
				num ^= this.CCFBCJEHGDF.GetHashCode();
			}
			if (this.JINIGJMLDLM != 0U)
			{
				num ^= this.JINIGJMLDLM.GetHashCode();
			}
			if (this.AELHCMNNNEJ != 0U)
			{
				num ^= this.AELHCMNNNEJ.GetHashCode();
			}
			if (this.NIJCHGMMCHB != 0U)
			{
				num ^= this.NIJCHGMMCHB.GetHashCode();
			}
			if (this.HFHGNEFHPKA != 0U)
			{
				num ^= this.HFHGNEFHPKA.GetHashCode();
			}
			if (this.MOFJPIEOICM != 0U)
			{
				num ^= this.MOFJPIEOICM.GetHashCode();
			}
			if (this.JACBDAEENHP != 0U)
			{
				num ^= this.JACBDAEENHP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00071FA4 File Offset: 0x000701A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00071FAC File Offset: 0x000701AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x00071FB8 File Offset: 0x000701B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IFJMIECLKCL != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.IFJMIECLKCL);
			}
			if (this.NENDGHABLAM != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.NENDGHABLAM);
			}
			if (this.ENJIEEPCJCI != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ENJIEEPCJCI);
			}
			if (this.CCFBCJEHGDF != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CCFBCJEHGDF);
			}
			if (this.JINIGJMLDLM != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.JINIGJMLDLM);
			}
			if (this.AELHCMNNNEJ != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.AELHCMNNNEJ);
			}
			if (this.NIJCHGMMCHB != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.NIJCHGMMCHB);
			}
			if (this.HFHGNEFHPKA != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.HFHGNEFHPKA);
			}
			if (this.MOFJPIEOICM != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MOFJPIEOICM);
			}
			if (this.JACBDAEENHP != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.JACBDAEENHP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x000720F0 File Offset: 0x000702F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IFJMIECLKCL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IFJMIECLKCL);
			}
			if (this.NENDGHABLAM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NENDGHABLAM);
			}
			if (this.ENJIEEPCJCI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ENJIEEPCJCI);
			}
			if (this.CCFBCJEHGDF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CCFBCJEHGDF);
			}
			if (this.JINIGJMLDLM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JINIGJMLDLM);
			}
			if (this.AELHCMNNNEJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AELHCMNNNEJ);
			}
			if (this.NIJCHGMMCHB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NIJCHGMMCHB);
			}
			if (this.HFHGNEFHPKA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HFHGNEFHPKA);
			}
			if (this.MOFJPIEOICM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MOFJPIEOICM);
			}
			if (this.JACBDAEENHP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JACBDAEENHP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00072208 File Offset: 0x00070408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DHPIFKICOPP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IFJMIECLKCL != 0U)
			{
				this.IFJMIECLKCL = other.IFJMIECLKCL;
			}
			if (other.NENDGHABLAM != 0U)
			{
				this.NENDGHABLAM = other.NENDGHABLAM;
			}
			if (other.ENJIEEPCJCI != 0U)
			{
				this.ENJIEEPCJCI = other.ENJIEEPCJCI;
			}
			if (other.CCFBCJEHGDF != 0U)
			{
				this.CCFBCJEHGDF = other.CCFBCJEHGDF;
			}
			if (other.JINIGJMLDLM != 0U)
			{
				this.JINIGJMLDLM = other.JINIGJMLDLM;
			}
			if (other.AELHCMNNNEJ != 0U)
			{
				this.AELHCMNNNEJ = other.AELHCMNNNEJ;
			}
			if (other.NIJCHGMMCHB != 0U)
			{
				this.NIJCHGMMCHB = other.NIJCHGMMCHB;
			}
			if (other.HFHGNEFHPKA != 0U)
			{
				this.HFHGNEFHPKA = other.HFHGNEFHPKA;
			}
			if (other.MOFJPIEOICM != 0U)
			{
				this.MOFJPIEOICM = other.MOFJPIEOICM;
			}
			if (other.JACBDAEENHP != 0U)
			{
				this.JACBDAEENHP = other.JACBDAEENHP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000722F8 File Offset: 0x000704F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00072304 File Offset: 0x00070504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.IFJMIECLKCL = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.NENDGHABLAM = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.ENJIEEPCJCI = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.CCFBCJEHGDF = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.JINIGJMLDLM = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.AELHCMNNNEJ = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.NIJCHGMMCHB = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.HFHGNEFHPKA = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.MOFJPIEOICM = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.JACBDAEENHP = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400107D RID: 4221
		private static readonly MessageParser<DHPIFKICOPP> _parser = new MessageParser<DHPIFKICOPP>(() => new DHPIFKICOPP());

		// Token: 0x0400107E RID: 4222
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400107F RID: 4223
		public const int IFJMIECLKCLFieldNumber = 1;

		// Token: 0x04001080 RID: 4224
		private uint iFJMIECLKCL_;

		// Token: 0x04001081 RID: 4225
		public const int NENDGHABLAMFieldNumber = 2;

		// Token: 0x04001082 RID: 4226
		private uint nENDGHABLAM_;

		// Token: 0x04001083 RID: 4227
		public const int ENJIEEPCJCIFieldNumber = 3;

		// Token: 0x04001084 RID: 4228
		private uint eNJIEEPCJCI_;

		// Token: 0x04001085 RID: 4229
		public const int CCFBCJEHGDFFieldNumber = 4;

		// Token: 0x04001086 RID: 4230
		private uint cCFBCJEHGDF_;

		// Token: 0x04001087 RID: 4231
		public const int JINIGJMLDLMFieldNumber = 5;

		// Token: 0x04001088 RID: 4232
		private uint jINIGJMLDLM_;

		// Token: 0x04001089 RID: 4233
		public const int AELHCMNNNEJFieldNumber = 6;

		// Token: 0x0400108A RID: 4234
		private uint aELHCMNNNEJ_;

		// Token: 0x0400108B RID: 4235
		public const int NIJCHGMMCHBFieldNumber = 7;

		// Token: 0x0400108C RID: 4236
		private uint nIJCHGMMCHB_;

		// Token: 0x0400108D RID: 4237
		public const int HFHGNEFHPKAFieldNumber = 8;

		// Token: 0x0400108E RID: 4238
		private uint hFHGNEFHPKA_;

		// Token: 0x0400108F RID: 4239
		public const int MOFJPIEOICMFieldNumber = 9;

		// Token: 0x04001090 RID: 4240
		private uint mOFJPIEOICM_;

		// Token: 0x04001091 RID: 4241
		public const int JACBDAEENHPFieldNumber = 10;

		// Token: 0x04001092 RID: 4242
		private uint jACBDAEENHP_;
	}
}
