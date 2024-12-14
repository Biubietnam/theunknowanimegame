using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003FF RID: 1023
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EHEACEHNEGA : IMessage<EHEACEHNEGA>, IMessage, IEquatable<EHEACEHNEGA>, IDeepCloneable<EHEACEHNEGA>, IBufferMessage
	{
		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x0007D61F File Offset: 0x0007B81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EHEACEHNEGA> Parser
		{
			get
			{
				return EHEACEHNEGA._parser;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x0007D626 File Offset: 0x0007B826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EHEACEHNEGAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x0007D638 File Offset: 0x0007B838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EHEACEHNEGA.Descriptor;
			}
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x0007D63F File Offset: 0x0007B83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EHEACEHNEGA()
		{
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x0007D648 File Offset: 0x0007B848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EHEACEHNEGA(EHEACEHNEGA other) : this()
		{
			this.bFBOLGKIMIB_ = ((other.bFBOLGKIMIB_ != null) ? other.bFBOLGKIMIB_.Clone() : null);
			this.lIGEDIHEFMB_ = ((other.lIGEDIHEFMB_ != null) ? other.lIGEDIHEFMB_.Clone() : null);
			this.kNMDKFFBGHP_ = ((other.kNMDKFFBGHP_ != null) ? other.kNMDKFFBGHP_.Clone() : null);
			this.hFGMHPLJFKP_ = ((other.hFGMHPLJFKP_ != null) ? other.hFGMHPLJFKP_.Clone() : null);
			this.gBBCBCAOOKI_ = ((other.gBBCBCAOOKI_ != null) ? other.gBBCBCAOOKI_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x0007D6F8 File Offset: 0x0007B8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EHEACEHNEGA Clone()
		{
			return new EHEACEHNEGA(this);
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06002D60 RID: 11616 RVA: 0x0007D700 File Offset: 0x0007B900
		// (set) Token: 0x06002D61 RID: 11617 RVA: 0x0007D708 File Offset: 0x0007B908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EFIGAKCIHHM BFBOLGKIMIB
		{
			get
			{
				return this.bFBOLGKIMIB_;
			}
			set
			{
				this.bFBOLGKIMIB_ = value;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x0007D711 File Offset: 0x0007B911
		// (set) Token: 0x06002D63 RID: 11619 RVA: 0x0007D719 File Offset: 0x0007B919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CPDLMGKIJLJ LIGEDIHEFMB
		{
			get
			{
				return this.lIGEDIHEFMB_;
			}
			set
			{
				this.lIGEDIHEFMB_ = value;
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x0007D722 File Offset: 0x0007B922
		// (set) Token: 0x06002D65 RID: 11621 RVA: 0x0007D72A File Offset: 0x0007B92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIKHAJADEMG KNMDKFFBGHP
		{
			get
			{
				return this.kNMDKFFBGHP_;
			}
			set
			{
				this.kNMDKFFBGHP_ = value;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x0007D733 File Offset: 0x0007B933
		// (set) Token: 0x06002D67 RID: 11623 RVA: 0x0007D73B File Offset: 0x0007B93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IFIJMOECCOE HFGMHPLJFKP
		{
			get
			{
				return this.hFGMHPLJFKP_;
			}
			set
			{
				this.hFGMHPLJFKP_ = value;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06002D68 RID: 11624 RVA: 0x0007D744 File Offset: 0x0007B944
		// (set) Token: 0x06002D69 RID: 11625 RVA: 0x0007D74C File Offset: 0x0007B94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OLFEIIBMPGL GBBCBCAOOKI
		{
			get
			{
				return this.gBBCBCAOOKI_;
			}
			set
			{
				this.gBBCBCAOOKI_ = value;
			}
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x0007D755 File Offset: 0x0007B955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EHEACEHNEGA);
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x0007D764 File Offset: 0x0007B964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EHEACEHNEGA other)
		{
			return other != null && (other == this || (object.Equals(this.BFBOLGKIMIB, other.BFBOLGKIMIB) && object.Equals(this.LIGEDIHEFMB, other.LIGEDIHEFMB) && object.Equals(this.KNMDKFFBGHP, other.KNMDKFFBGHP) && object.Equals(this.HFGMHPLJFKP, other.HFGMHPLJFKP) && object.Equals(this.GBBCBCAOOKI, other.GBBCBCAOOKI) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x0007D7F8 File Offset: 0x0007B9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bFBOLGKIMIB_ != null)
			{
				num ^= this.BFBOLGKIMIB.GetHashCode();
			}
			if (this.lIGEDIHEFMB_ != null)
			{
				num ^= this.LIGEDIHEFMB.GetHashCode();
			}
			if (this.kNMDKFFBGHP_ != null)
			{
				num ^= this.KNMDKFFBGHP.GetHashCode();
			}
			if (this.hFGMHPLJFKP_ != null)
			{
				num ^= this.HFGMHPLJFKP.GetHashCode();
			}
			if (this.gBBCBCAOOKI_ != null)
			{
				num ^= this.GBBCBCAOOKI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x0007D88C File Offset: 0x0007BA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x0007D894 File Offset: 0x0007BA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x0007D8A0 File Offset: 0x0007BAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gBBCBCAOOKI_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GBBCBCAOOKI);
			}
			if (this.kNMDKFFBGHP_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.KNMDKFFBGHP);
			}
			if (this.hFGMHPLJFKP_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.HFGMHPLJFKP);
			}
			if (this.bFBOLGKIMIB_ != null)
			{
				output.WriteRawTag(170, 11);
				output.WriteMessage(this.BFBOLGKIMIB);
			}
			if (this.lIGEDIHEFMB_ != null)
			{
				output.WriteRawTag(130, 60);
				output.WriteMessage(this.LIGEDIHEFMB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x0007D958 File Offset: 0x0007BB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bFBOLGKIMIB_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BFBOLGKIMIB);
			}
			if (this.lIGEDIHEFMB_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LIGEDIHEFMB);
			}
			if (this.kNMDKFFBGHP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KNMDKFFBGHP);
			}
			if (this.hFGMHPLJFKP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HFGMHPLJFKP);
			}
			if (this.gBBCBCAOOKI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GBBCBCAOOKI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x0007D9F8 File Offset: 0x0007BBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EHEACEHNEGA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bFBOLGKIMIB_ != null)
			{
				if (this.bFBOLGKIMIB_ == null)
				{
					this.BFBOLGKIMIB = new EFIGAKCIHHM();
				}
				this.BFBOLGKIMIB.MergeFrom(other.BFBOLGKIMIB);
			}
			if (other.lIGEDIHEFMB_ != null)
			{
				if (this.lIGEDIHEFMB_ == null)
				{
					this.LIGEDIHEFMB = new CPDLMGKIJLJ();
				}
				this.LIGEDIHEFMB.MergeFrom(other.LIGEDIHEFMB);
			}
			if (other.kNMDKFFBGHP_ != null)
			{
				if (this.kNMDKFFBGHP_ == null)
				{
					this.KNMDKFFBGHP = new OIKHAJADEMG();
				}
				this.KNMDKFFBGHP.MergeFrom(other.KNMDKFFBGHP);
			}
			if (other.hFGMHPLJFKP_ != null)
			{
				if (this.hFGMHPLJFKP_ == null)
				{
					this.HFGMHPLJFKP = new IFIJMOECCOE();
				}
				this.HFGMHPLJFKP.MergeFrom(other.HFGMHPLJFKP);
			}
			if (other.gBBCBCAOOKI_ != null)
			{
				if (this.gBBCBCAOOKI_ == null)
				{
					this.GBBCBCAOOKI = new OLFEIIBMPGL();
				}
				this.GBBCBCAOOKI.MergeFrom(other.GBBCBCAOOKI);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x0007DAFC File Offset: 0x0007BCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x0007DB08 File Offset: 0x0007BD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 10U)
					{
						if (this.gBBCBCAOOKI_ == null)
						{
							this.GBBCBCAOOKI = new OLFEIIBMPGL();
						}
						input.ReadMessage(this.GBBCBCAOOKI);
						continue;
					}
					if (num == 50U)
					{
						if (this.kNMDKFFBGHP_ == null)
						{
							this.KNMDKFFBGHP = new OIKHAJADEMG();
						}
						input.ReadMessage(this.KNMDKFFBGHP);
						continue;
					}
				}
				else
				{
					if (num == 122U)
					{
						if (this.hFGMHPLJFKP_ == null)
						{
							this.HFGMHPLJFKP = new IFIJMOECCOE();
						}
						input.ReadMessage(this.HFGMHPLJFKP);
						continue;
					}
					if (num == 1450U)
					{
						if (this.bFBOLGKIMIB_ == null)
						{
							this.BFBOLGKIMIB = new EFIGAKCIHHM();
						}
						input.ReadMessage(this.BFBOLGKIMIB);
						continue;
					}
					if (num == 7682U)
					{
						if (this.lIGEDIHEFMB_ == null)
						{
							this.LIGEDIHEFMB = new CPDLMGKIJLJ();
						}
						input.ReadMessage(this.LIGEDIHEFMB);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001241 RID: 4673
		private static readonly MessageParser<EHEACEHNEGA> _parser = new MessageParser<EHEACEHNEGA>(() => new EHEACEHNEGA());

		// Token: 0x04001242 RID: 4674
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001243 RID: 4675
		public const int BFBOLGKIMIBFieldNumber = 181;

		// Token: 0x04001244 RID: 4676
		private EFIGAKCIHHM bFBOLGKIMIB_;

		// Token: 0x04001245 RID: 4677
		public const int LIGEDIHEFMBFieldNumber = 960;

		// Token: 0x04001246 RID: 4678
		private CPDLMGKIJLJ lIGEDIHEFMB_;

		// Token: 0x04001247 RID: 4679
		public const int KNMDKFFBGHPFieldNumber = 6;

		// Token: 0x04001248 RID: 4680
		private OIKHAJADEMG kNMDKFFBGHP_;

		// Token: 0x04001249 RID: 4681
		public const int HFGMHPLJFKPFieldNumber = 15;

		// Token: 0x0400124A RID: 4682
		private IFIJMOECCOE hFGMHPLJFKP_;

		// Token: 0x0400124B RID: 4683
		public const int GBBCBCAOOKIFieldNumber = 1;

		// Token: 0x0400124C RID: 4684
		private OLFEIIBMPGL gBBCBCAOOKI_;
	}
}
