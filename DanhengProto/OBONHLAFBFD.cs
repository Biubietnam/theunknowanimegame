using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C45 RID: 3141
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OBONHLAFBFD : IMessage<OBONHLAFBFD>, IMessage, IEquatable<OBONHLAFBFD>, IDeepCloneable<OBONHLAFBFD>, IBufferMessage
	{
		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x06008B4C RID: 35660 RVA: 0x0017003C File Offset: 0x0016E23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OBONHLAFBFD> Parser
		{
			get
			{
				return OBONHLAFBFD._parser;
			}
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x06008B4D RID: 35661 RVA: 0x00170043 File Offset: 0x0016E243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OBONHLAFBFDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x06008B4E RID: 35662 RVA: 0x00170055 File Offset: 0x0016E255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OBONHLAFBFD.Descriptor;
			}
		}

		// Token: 0x06008B4F RID: 35663 RVA: 0x0017005C File Offset: 0x0016E25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBONHLAFBFD()
		{
		}

		// Token: 0x06008B50 RID: 35664 RVA: 0x00170064 File Offset: 0x0016E264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBONHLAFBFD(OBONHLAFBFD other) : this()
		{
			this.jMBAGBFIKCM_ = other.jMBAGBFIKCM_;
			this.mCLJBLKACMP_ = other.mCLJBLKACMP_;
			this.aNEAAKIDPFL_ = other.aNEAAKIDPFL_;
			this.cPEEEPDBBPH_ = other.cPEEEPDBBPH_;
			this.gNOHNPJBFJC_ = other.gNOHNPJBFJC_;
			this.pJILEMMBLFG_ = other.pJILEMMBLFG_;
			this.nENGEIIJJCB_ = other.nENGEIIJJCB_;
			this.nMJDBOIPFIC_ = other.nMJDBOIPFIC_;
			this.cGADMDEKIAC_ = other.cGADMDEKIAC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B51 RID: 35665 RVA: 0x001700F4 File Offset: 0x0016E2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBONHLAFBFD Clone()
		{
			return new OBONHLAFBFD(this);
		}

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x06008B52 RID: 35666 RVA: 0x001700FC File Offset: 0x0016E2FC
		// (set) Token: 0x06008B53 RID: 35667 RVA: 0x00170104 File Offset: 0x0016E304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JMBAGBFIKCM
		{
			get
			{
				return this.jMBAGBFIKCM_;
			}
			set
			{
				this.jMBAGBFIKCM_ = value;
			}
		}

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x06008B54 RID: 35668 RVA: 0x0017010D File Offset: 0x0016E30D
		// (set) Token: 0x06008B55 RID: 35669 RVA: 0x00170115 File Offset: 0x0016E315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MCLJBLKACMP
		{
			get
			{
				return this.mCLJBLKACMP_;
			}
			set
			{
				this.mCLJBLKACMP_ = value;
			}
		}

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x06008B56 RID: 35670 RVA: 0x0017011E File Offset: 0x0016E31E
		// (set) Token: 0x06008B57 RID: 35671 RVA: 0x00170126 File Offset: 0x0016E326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ANEAAKIDPFL
		{
			get
			{
				return this.aNEAAKIDPFL_;
			}
			set
			{
				this.aNEAAKIDPFL_ = value;
			}
		}

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x06008B58 RID: 35672 RVA: 0x0017012F File Offset: 0x0016E32F
		// (set) Token: 0x06008B59 RID: 35673 RVA: 0x00170137 File Offset: 0x0016E337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CPEEEPDBBPH
		{
			get
			{
				return this.cPEEEPDBBPH_;
			}
			set
			{
				this.cPEEEPDBBPH_ = value;
			}
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x06008B5A RID: 35674 RVA: 0x00170140 File Offset: 0x0016E340
		// (set) Token: 0x06008B5B RID: 35675 RVA: 0x00170148 File Offset: 0x0016E348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GNOHNPJBFJC
		{
			get
			{
				return this.gNOHNPJBFJC_;
			}
			set
			{
				this.gNOHNPJBFJC_ = value;
			}
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x06008B5C RID: 35676 RVA: 0x00170151 File Offset: 0x0016E351
		// (set) Token: 0x06008B5D RID: 35677 RVA: 0x00170159 File Offset: 0x0016E359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PJILEMMBLFG
		{
			get
			{
				return this.pJILEMMBLFG_;
			}
			set
			{
				this.pJILEMMBLFG_ = value;
			}
		}

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x06008B5E RID: 35678 RVA: 0x00170162 File Offset: 0x0016E362
		// (set) Token: 0x06008B5F RID: 35679 RVA: 0x0017016A File Offset: 0x0016E36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NENGEIIJJCB
		{
			get
			{
				return this.nENGEIIJJCB_;
			}
			set
			{
				this.nENGEIIJJCB_ = value;
			}
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x06008B60 RID: 35680 RVA: 0x00170173 File Offset: 0x0016E373
		// (set) Token: 0x06008B61 RID: 35681 RVA: 0x0017017B File Offset: 0x0016E37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NMJDBOIPFIC
		{
			get
			{
				return this.nMJDBOIPFIC_;
			}
			set
			{
				this.nMJDBOIPFIC_ = value;
			}
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x06008B62 RID: 35682 RVA: 0x00170184 File Offset: 0x0016E384
		// (set) Token: 0x06008B63 RID: 35683 RVA: 0x0017018C File Offset: 0x0016E38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CGADMDEKIAC
		{
			get
			{
				return this.cGADMDEKIAC_;
			}
			set
			{
				this.cGADMDEKIAC_ = value;
			}
		}

		// Token: 0x06008B64 RID: 35684 RVA: 0x00170195 File Offset: 0x0016E395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OBONHLAFBFD);
		}

		// Token: 0x06008B65 RID: 35685 RVA: 0x001701A4 File Offset: 0x0016E3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OBONHLAFBFD other)
		{
			return other != null && (other == this || (this.JMBAGBFIKCM == other.JMBAGBFIKCM && this.MCLJBLKACMP == other.MCLJBLKACMP && this.ANEAAKIDPFL == other.ANEAAKIDPFL && this.CPEEEPDBBPH == other.CPEEEPDBBPH && this.GNOHNPJBFJC == other.GNOHNPJBFJC && this.PJILEMMBLFG == other.PJILEMMBLFG && this.NENGEIIJJCB == other.NENGEIIJJCB && this.NMJDBOIPFIC == other.NMJDBOIPFIC && this.CGADMDEKIAC == other.CGADMDEKIAC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B66 RID: 35686 RVA: 0x00170260 File Offset: 0x0016E460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JMBAGBFIKCM)
			{
				num ^= this.JMBAGBFIKCM.GetHashCode();
			}
			if (this.MCLJBLKACMP)
			{
				num ^= this.MCLJBLKACMP.GetHashCode();
			}
			if (this.ANEAAKIDPFL)
			{
				num ^= this.ANEAAKIDPFL.GetHashCode();
			}
			if (this.CPEEEPDBBPH)
			{
				num ^= this.CPEEEPDBBPH.GetHashCode();
			}
			if (this.GNOHNPJBFJC)
			{
				num ^= this.GNOHNPJBFJC.GetHashCode();
			}
			if (this.PJILEMMBLFG)
			{
				num ^= this.PJILEMMBLFG.GetHashCode();
			}
			if (this.NENGEIIJJCB)
			{
				num ^= this.NENGEIIJJCB.GetHashCode();
			}
			if (this.NMJDBOIPFIC)
			{
				num ^= this.NMJDBOIPFIC.GetHashCode();
			}
			if (this.CGADMDEKIAC)
			{
				num ^= this.CGADMDEKIAC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B67 RID: 35687 RVA: 0x00170367 File Offset: 0x0016E567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x0017036F File Offset: 0x0016E56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x00170378 File Offset: 0x0016E578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ANEAAKIDPFL)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ANEAAKIDPFL);
			}
			if (this.NMJDBOIPFIC)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.NMJDBOIPFIC);
			}
			if (this.PJILEMMBLFG)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.PJILEMMBLFG);
			}
			if (this.CPEEEPDBBPH)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.CPEEEPDBBPH);
			}
			if (this.NENGEIIJJCB)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.NENGEIIJJCB);
			}
			if (this.GNOHNPJBFJC)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.GNOHNPJBFJC);
			}
			if (this.JMBAGBFIKCM)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.JMBAGBFIKCM);
			}
			if (this.CGADMDEKIAC)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.CGADMDEKIAC);
			}
			if (this.MCLJBLKACMP)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.MCLJBLKACMP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x00170494 File Offset: 0x0016E694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JMBAGBFIKCM)
			{
				num += 2;
			}
			if (this.MCLJBLKACMP)
			{
				num += 2;
			}
			if (this.ANEAAKIDPFL)
			{
				num += 2;
			}
			if (this.CPEEEPDBBPH)
			{
				num += 2;
			}
			if (this.GNOHNPJBFJC)
			{
				num += 2;
			}
			if (this.PJILEMMBLFG)
			{
				num += 2;
			}
			if (this.NENGEIIJJCB)
			{
				num += 2;
			}
			if (this.NMJDBOIPFIC)
			{
				num += 2;
			}
			if (this.CGADMDEKIAC)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x00170528 File Offset: 0x0016E728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OBONHLAFBFD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JMBAGBFIKCM)
			{
				this.JMBAGBFIKCM = other.JMBAGBFIKCM;
			}
			if (other.MCLJBLKACMP)
			{
				this.MCLJBLKACMP = other.MCLJBLKACMP;
			}
			if (other.ANEAAKIDPFL)
			{
				this.ANEAAKIDPFL = other.ANEAAKIDPFL;
			}
			if (other.CPEEEPDBBPH)
			{
				this.CPEEEPDBBPH = other.CPEEEPDBBPH;
			}
			if (other.GNOHNPJBFJC)
			{
				this.GNOHNPJBFJC = other.GNOHNPJBFJC;
			}
			if (other.PJILEMMBLFG)
			{
				this.PJILEMMBLFG = other.PJILEMMBLFG;
			}
			if (other.NENGEIIJJCB)
			{
				this.NENGEIIJJCB = other.NENGEIIJJCB;
			}
			if (other.NMJDBOIPFIC)
			{
				this.NMJDBOIPFIC = other.NMJDBOIPFIC;
			}
			if (other.CGADMDEKIAC)
			{
				this.CGADMDEKIAC = other.CGADMDEKIAC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x00170604 File Offset: 0x0016E804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x00170610 File Offset: 0x0016E810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 32U)
					{
						if (num == 8U)
						{
							this.ANEAAKIDPFL = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.NMJDBOIPFIC = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.PJILEMMBLFG = input.ReadBool();
							continue;
						}
						if (num == 48U)
						{
							this.CPEEEPDBBPH = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U)
					{
						this.NENGEIIJJCB = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.GNOHNPJBFJC = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.JMBAGBFIKCM = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.CGADMDEKIAC = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.MCLJBLKACMP = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003572 RID: 13682
		private static readonly MessageParser<OBONHLAFBFD> _parser = new MessageParser<OBONHLAFBFD>(() => new OBONHLAFBFD());

		// Token: 0x04003573 RID: 13683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003574 RID: 13684
		public const int JMBAGBFIKCMFieldNumber = 9;

		// Token: 0x04003575 RID: 13685
		private bool jMBAGBFIKCM_;

		// Token: 0x04003576 RID: 13686
		public const int MCLJBLKACMPFieldNumber = 15;

		// Token: 0x04003577 RID: 13687
		private bool mCLJBLKACMP_;

		// Token: 0x04003578 RID: 13688
		public const int ANEAAKIDPFLFieldNumber = 1;

		// Token: 0x04003579 RID: 13689
		private bool aNEAAKIDPFL_;

		// Token: 0x0400357A RID: 13690
		public const int CPEEEPDBBPHFieldNumber = 6;

		// Token: 0x0400357B RID: 13691
		private bool cPEEEPDBBPH_;

		// Token: 0x0400357C RID: 13692
		public const int GNOHNPJBFJCFieldNumber = 8;

		// Token: 0x0400357D RID: 13693
		private bool gNOHNPJBFJC_;

		// Token: 0x0400357E RID: 13694
		public const int PJILEMMBLFGFieldNumber = 5;

		// Token: 0x0400357F RID: 13695
		private bool pJILEMMBLFG_;

		// Token: 0x04003580 RID: 13696
		public const int NENGEIIJJCBFieldNumber = 7;

		// Token: 0x04003581 RID: 13697
		private bool nENGEIIJJCB_;

		// Token: 0x04003582 RID: 13698
		public const int NMJDBOIPFICFieldNumber = 4;

		// Token: 0x04003583 RID: 13699
		private bool nMJDBOIPFIC_;

		// Token: 0x04003584 RID: 13700
		public const int CGADMDEKIACFieldNumber = 11;

		// Token: 0x04003585 RID: 13701
		private bool cGADMDEKIAC_;
	}
}
