using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008B1 RID: 2225
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HELBEIHMGKK : IMessage<HELBEIHMGKK>, IMessage, IEquatable<HELBEIHMGKK>, IDeepCloneable<HELBEIHMGKK>, IBufferMessage
	{
		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06006320 RID: 25376 RVA: 0x00109687 File Offset: 0x00107887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HELBEIHMGKK> Parser
		{
			get
			{
				return HELBEIHMGKK._parser;
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06006321 RID: 25377 RVA: 0x0010968E File Offset: 0x0010788E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HELBEIHMGKKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06006322 RID: 25378 RVA: 0x001096A0 File Offset: 0x001078A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HELBEIHMGKK.Descriptor;
			}
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x001096A7 File Offset: 0x001078A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HELBEIHMGKK()
		{
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x001096C8 File Offset: 0x001078C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HELBEIHMGKK(HELBEIHMGKK other) : this()
		{
			this.hNLHBNFLIJH_ = other.hNLHBNFLIJH_;
			this.pMMINPKDDOL_ = other.pMMINPKDDOL_;
			this.lONOMABLBFB_ = other.lONOMABLBFB_.Clone();
			this.aHBPANPJHOK_ = other.aHBPANPJHOK_;
			this.mJIIBAOPBPO_ = other.mJIIBAOPBPO_;
			this.cDIICHMHBDL_ = other.cDIICHMHBDL_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x0010973E File Offset: 0x0010793E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HELBEIHMGKK Clone()
		{
			return new HELBEIHMGKK(this);
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06006326 RID: 25382 RVA: 0x00109746 File Offset: 0x00107946
		// (set) Token: 0x06006327 RID: 25383 RVA: 0x0010974E File Offset: 0x0010794E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HNLHBNFLIJH
		{
			get
			{
				return this.hNLHBNFLIJH_;
			}
			set
			{
				this.hNLHBNFLIJH_ = value;
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06006328 RID: 25384 RVA: 0x00109757 File Offset: 0x00107957
		// (set) Token: 0x06006329 RID: 25385 RVA: 0x0010975F File Offset: 0x0010795F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PMMINPKDDOL
		{
			get
			{
				return this.pMMINPKDDOL_;
			}
			set
			{
				this.pMMINPKDDOL_ = value;
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x0600632A RID: 25386 RVA: 0x00109768 File Offset: 0x00107968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LONOMABLBFB
		{
			get
			{
				return this.lONOMABLBFB_;
			}
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x0600632B RID: 25387 RVA: 0x00109770 File Offset: 0x00107970
		// (set) Token: 0x0600632C RID: 25388 RVA: 0x00109778 File Offset: 0x00107978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AHBPANPJHOK
		{
			get
			{
				return this.aHBPANPJHOK_;
			}
			set
			{
				this.aHBPANPJHOK_ = value;
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x0600632D RID: 25389 RVA: 0x00109781 File Offset: 0x00107981
		// (set) Token: 0x0600632E RID: 25390 RVA: 0x00109789 File Offset: 0x00107989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MJIIBAOPBPO
		{
			get
			{
				return this.mJIIBAOPBPO_;
			}
			set
			{
				this.mJIIBAOPBPO_ = value;
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x0600632F RID: 25391 RVA: 0x00109792 File Offset: 0x00107992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KNNMIFKBOBO> CDIICHMHBDL
		{
			get
			{
				return this.cDIICHMHBDL_;
			}
		}

		// Token: 0x06006330 RID: 25392 RVA: 0x0010979A File Offset: 0x0010799A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HELBEIHMGKK);
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x001097A8 File Offset: 0x001079A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HELBEIHMGKK other)
		{
			return other != null && (other == this || (this.HNLHBNFLIJH == other.HNLHBNFLIJH && this.PMMINPKDDOL == other.PMMINPKDDOL && this.lONOMABLBFB_.Equals(other.lONOMABLBFB_) && this.AHBPANPJHOK == other.AHBPANPJHOK && this.MJIIBAOPBPO == other.MJIIBAOPBPO && this.cDIICHMHBDL_.Equals(other.cDIICHMHBDL_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x0010983C File Offset: 0x00107A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HNLHBNFLIJH != 0U)
			{
				num ^= this.HNLHBNFLIJH.GetHashCode();
			}
			if (this.PMMINPKDDOL != 0U)
			{
				num ^= this.PMMINPKDDOL.GetHashCode();
			}
			num ^= this.lONOMABLBFB_.GetHashCode();
			if (this.AHBPANPJHOK != 0U)
			{
				num ^= this.AHBPANPJHOK.GetHashCode();
			}
			if (this.MJIIBAOPBPO != 0U)
			{
				num ^= this.MJIIBAOPBPO.GetHashCode();
			}
			num ^= this.cDIICHMHBDL_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x001098E2 File Offset: 0x00107AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x001098EA File Offset: 0x00107AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x001098F4 File Offset: 0x00107AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lONOMABLBFB_.WriteTo(ref output, HELBEIHMGKK._repeated_lONOMABLBFB_codec);
			if (this.AHBPANPJHOK != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.AHBPANPJHOK);
			}
			if (this.PMMINPKDDOL != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.PMMINPKDDOL);
			}
			this.cDIICHMHBDL_.WriteTo(ref output, HELBEIHMGKK._repeated_cDIICHMHBDL_codec);
			if (this.HNLHBNFLIJH != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.HNLHBNFLIJH);
			}
			if (this.MJIIBAOPBPO != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.MJIIBAOPBPO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x001099A8 File Offset: 0x00107BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HNLHBNFLIJH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HNLHBNFLIJH);
			}
			if (this.PMMINPKDDOL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PMMINPKDDOL);
			}
			num += this.lONOMABLBFB_.CalculateSize(HELBEIHMGKK._repeated_lONOMABLBFB_codec);
			if (this.AHBPANPJHOK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHBPANPJHOK);
			}
			if (this.MJIIBAOPBPO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MJIIBAOPBPO);
			}
			num += this.cDIICHMHBDL_.CalculateSize(HELBEIHMGKK._repeated_cDIICHMHBDL_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x00109A54 File Offset: 0x00107C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HELBEIHMGKK other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HNLHBNFLIJH != 0U)
			{
				this.HNLHBNFLIJH = other.HNLHBNFLIJH;
			}
			if (other.PMMINPKDDOL != 0U)
			{
				this.PMMINPKDDOL = other.PMMINPKDDOL;
			}
			this.lONOMABLBFB_.Add(other.lONOMABLBFB_);
			if (other.AHBPANPJHOK != 0U)
			{
				this.AHBPANPJHOK = other.AHBPANPJHOK;
			}
			if (other.MJIIBAOPBPO != 0U)
			{
				this.MJIIBAOPBPO = other.MJIIBAOPBPO;
			}
			this.cDIICHMHBDL_.Add(other.cDIICHMHBDL_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x00109AEE File Offset: 0x00107CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x00109AF8 File Offset: 0x00107CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 40U || num == 42U)
					{
						this.lONOMABLBFB_.AddEntriesFrom(ref input, HELBEIHMGKK._repeated_lONOMABLBFB_codec);
						continue;
					}
					if (num == 48U)
					{
						this.AHBPANPJHOK = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 66U)
				{
					if (num == 56U)
					{
						this.PMMINPKDDOL = input.ReadUInt32();
						continue;
					}
					if (num == 66U)
					{
						this.cDIICHMHBDL_.AddEntriesFrom(ref input, HELBEIHMGKK._repeated_cDIICHMHBDL_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.HNLHBNFLIJH = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.MJIIBAOPBPO = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400262D RID: 9773
		private static readonly MessageParser<HELBEIHMGKK> _parser = new MessageParser<HELBEIHMGKK>(() => new HELBEIHMGKK());

		// Token: 0x0400262E RID: 9774
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400262F RID: 9775
		public const int HNLHBNFLIJHFieldNumber = 11;

		// Token: 0x04002630 RID: 9776
		private uint hNLHBNFLIJH_;

		// Token: 0x04002631 RID: 9777
		public const int PMMINPKDDOLFieldNumber = 7;

		// Token: 0x04002632 RID: 9778
		private uint pMMINPKDDOL_;

		// Token: 0x04002633 RID: 9779
		public const int LONOMABLBFBFieldNumber = 5;

		// Token: 0x04002634 RID: 9780
		private static readonly FieldCodec<uint> _repeated_lONOMABLBFB_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04002635 RID: 9781
		private readonly RepeatedField<uint> lONOMABLBFB_ = new RepeatedField<uint>();

		// Token: 0x04002636 RID: 9782
		public const int AHBPANPJHOKFieldNumber = 6;

		// Token: 0x04002637 RID: 9783
		private uint aHBPANPJHOK_;

		// Token: 0x04002638 RID: 9784
		public const int MJIIBAOPBPOFieldNumber = 15;

		// Token: 0x04002639 RID: 9785
		private uint mJIIBAOPBPO_;

		// Token: 0x0400263A RID: 9786
		public const int CDIICHMHBDLFieldNumber = 8;

		// Token: 0x0400263B RID: 9787
		private static readonly FieldCodec<KNNMIFKBOBO> _repeated_cDIICHMHBDL_codec = FieldCodec.ForMessage<KNNMIFKBOBO>(66U, KNNMIFKBOBO.Parser);

		// Token: 0x0400263C RID: 9788
		private readonly RepeatedField<KNNMIFKBOBO> cDIICHMHBDL_ = new RepeatedField<KNNMIFKBOBO>();
	}
}
