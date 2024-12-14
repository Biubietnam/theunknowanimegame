using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000989 RID: 2441
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KBBMNPCNHMO : IMessage<KBBMNPCNHMO>, IMessage, IEquatable<KBBMNPCNHMO>, IDeepCloneable<KBBMNPCNHMO>, IBufferMessage
	{
		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06006D2A RID: 27946 RVA: 0x00123C16 File Offset: 0x00121E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KBBMNPCNHMO> Parser
		{
			get
			{
				return KBBMNPCNHMO._parser;
			}
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06006D2B RID: 27947 RVA: 0x00123C1D File Offset: 0x00121E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KBBMNPCNHMOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06006D2C RID: 27948 RVA: 0x00123C2F File Offset: 0x00121E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KBBMNPCNHMO.Descriptor;
			}
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x00123C36 File Offset: 0x00121E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KBBMNPCNHMO()
		{
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x00123C78 File Offset: 0x00121E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KBBMNPCNHMO(KBBMNPCNHMO other) : this()
		{
			this.nMFPFCLDDNN_ = other.nMFPFCLDDNN_.Clone();
			this.iENLIPDAPMG_ = other.iENLIPDAPMG_.Clone();
			this.gDILHIGFFNP_ = other.gDILHIGFFNP_.Clone();
			this.dOIDHIJIKLH_ = other.dOIDHIJIKLH_;
			this.exp_ = other.exp_;
			this.bACNPJFOAOF_ = other.bACNPJFOAOF_.Clone();
			this.gMILJKPOPGD_ = other.gMILJKPOPGD_;
			this.itemValue_ = other.itemValue_;
			this.gNJAGILEMCJ_ = other.gNJAGILEMCJ_;
			this.hLGLFNABFOP_ = other.hLGLFNABFOP_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x00123D2D File Offset: 0x00121F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KBBMNPCNHMO Clone()
		{
			return new KBBMNPCNHMO(this);
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x06006D30 RID: 27952 RVA: 0x00123D35 File Offset: 0x00121F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NMFPFCLDDNN
		{
			get
			{
				return this.nMFPFCLDDNN_;
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x06006D31 RID: 27953 RVA: 0x00123D3D File Offset: 0x00121F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EJKBGEPDPMF> IENLIPDAPMG
		{
			get
			{
				return this.iENLIPDAPMG_;
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x06006D32 RID: 27954 RVA: 0x00123D45 File Offset: 0x00121F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LCINGIMGEEM> GDILHIGFFNP
		{
			get
			{
				return this.gDILHIGFFNP_;
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06006D33 RID: 27955 RVA: 0x00123D4D File Offset: 0x00121F4D
		// (set) Token: 0x06006D34 RID: 27956 RVA: 0x00123D55 File Offset: 0x00121F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DOIDHIJIKLH
		{
			get
			{
				return this.dOIDHIJIKLH_;
			}
			set
			{
				this.dOIDHIJIKLH_ = value;
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x06006D35 RID: 27957 RVA: 0x00123D5E File Offset: 0x00121F5E
		// (set) Token: 0x06006D36 RID: 27958 RVA: 0x00123D66 File Offset: 0x00121F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x06006D37 RID: 27959 RVA: 0x00123D6F File Offset: 0x00121F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BACNPJFOAOF
		{
			get
			{
				return this.bACNPJFOAOF_;
			}
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x06006D38 RID: 27960 RVA: 0x00123D77 File Offset: 0x00121F77
		// (set) Token: 0x06006D39 RID: 27961 RVA: 0x00123D7F File Offset: 0x00121F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GMILJKPOPGD
		{
			get
			{
				return this.gMILJKPOPGD_;
			}
			set
			{
				this.gMILJKPOPGD_ = value;
			}
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06006D3A RID: 27962 RVA: 0x00123D88 File Offset: 0x00121F88
		// (set) Token: 0x06006D3B RID: 27963 RVA: 0x00123D90 File Offset: 0x00121F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemValue
		{
			get
			{
				return this.itemValue_;
			}
			set
			{
				this.itemValue_ = value;
			}
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x06006D3C RID: 27964 RVA: 0x00123D99 File Offset: 0x00121F99
		// (set) Token: 0x06006D3D RID: 27965 RVA: 0x00123DA1 File Offset: 0x00121FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GNJAGILEMCJ
		{
			get
			{
				return this.gNJAGILEMCJ_;
			}
			set
			{
				this.gNJAGILEMCJ_ = value;
			}
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x06006D3E RID: 27966 RVA: 0x00123DAA File Offset: 0x00121FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NHCDHNDCJMI> HLGLFNABFOP
		{
			get
			{
				return this.hLGLFNABFOP_;
			}
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x00123DB2 File Offset: 0x00121FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KBBMNPCNHMO);
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x00123DC0 File Offset: 0x00121FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KBBMNPCNHMO other)
		{
			return other != null && (other == this || (this.nMFPFCLDDNN_.Equals(other.nMFPFCLDDNN_) && this.iENLIPDAPMG_.Equals(other.iENLIPDAPMG_) && this.gDILHIGFFNP_.Equals(other.gDILHIGFFNP_) && this.DOIDHIJIKLH == other.DOIDHIJIKLH && this.Exp == other.Exp && this.bACNPJFOAOF_.Equals(other.bACNPJFOAOF_) && this.GMILJKPOPGD == other.GMILJKPOPGD && this.ItemValue == other.ItemValue && this.GNJAGILEMCJ == other.GNJAGILEMCJ && this.hLGLFNABFOP_.Equals(other.hLGLFNABFOP_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x00123EA4 File Offset: 0x001220A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nMFPFCLDDNN_.GetHashCode();
			num ^= this.iENLIPDAPMG_.GetHashCode();
			num ^= this.gDILHIGFFNP_.GetHashCode();
			if (this.DOIDHIJIKLH != 0U)
			{
				num ^= this.DOIDHIJIKLH.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			num ^= this.bACNPJFOAOF_.GetHashCode();
			if (this.GMILJKPOPGD)
			{
				num ^= this.GMILJKPOPGD.GetHashCode();
			}
			if (this.ItemValue != 0U)
			{
				num ^= this.ItemValue.GetHashCode();
			}
			if (this.GNJAGILEMCJ)
			{
				num ^= this.GNJAGILEMCJ.GetHashCode();
			}
			num ^= this.hLGLFNABFOP_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x00123F8D File Offset: 0x0012218D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x00123F95 File Offset: 0x00122195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x00123FA0 File Offset: 0x001221A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DOIDHIJIKLH != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.DOIDHIJIKLH);
			}
			this.iENLIPDAPMG_.WriteTo(ref output, KBBMNPCNHMO._repeated_iENLIPDAPMG_codec);
			this.gDILHIGFFNP_.WriteTo(ref output, KBBMNPCNHMO._repeated_gDILHIGFFNP_codec);
			if (this.Exp != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Exp);
			}
			if (this.GMILJKPOPGD)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.GMILJKPOPGD);
			}
			if (this.GNJAGILEMCJ)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.GNJAGILEMCJ);
			}
			this.hLGLFNABFOP_.WriteTo(ref output, KBBMNPCNHMO._repeated_hLGLFNABFOP_codec);
			if (this.ItemValue != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ItemValue);
			}
			this.bACNPJFOAOF_.WriteTo(ref output, KBBMNPCNHMO._repeated_bACNPJFOAOF_codec);
			this.nMFPFCLDDNN_.WriteTo(ref output, KBBMNPCNHMO._repeated_nMFPFCLDDNN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x001240A4 File Offset: 0x001222A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nMFPFCLDDNN_.CalculateSize(KBBMNPCNHMO._repeated_nMFPFCLDDNN_codec);
			num += this.iENLIPDAPMG_.CalculateSize(KBBMNPCNHMO._repeated_iENLIPDAPMG_codec);
			num += this.gDILHIGFFNP_.CalculateSize(KBBMNPCNHMO._repeated_gDILHIGFFNP_codec);
			if (this.DOIDHIJIKLH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DOIDHIJIKLH);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			num += this.bACNPJFOAOF_.CalculateSize(KBBMNPCNHMO._repeated_bACNPJFOAOF_codec);
			if (this.GMILJKPOPGD)
			{
				num += 2;
			}
			if (this.ItemValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemValue);
			}
			if (this.GNJAGILEMCJ)
			{
				num += 2;
			}
			num += this.hLGLFNABFOP_.CalculateSize(KBBMNPCNHMO._repeated_hLGLFNABFOP_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x0012418C File Offset: 0x0012238C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KBBMNPCNHMO other)
		{
			if (other == null)
			{
				return;
			}
			this.nMFPFCLDDNN_.Add(other.nMFPFCLDDNN_);
			this.iENLIPDAPMG_.Add(other.iENLIPDAPMG_);
			this.gDILHIGFFNP_.Add(other.gDILHIGFFNP_);
			if (other.DOIDHIJIKLH != 0U)
			{
				this.DOIDHIJIKLH = other.DOIDHIJIKLH;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			this.bACNPJFOAOF_.Add(other.bACNPJFOAOF_);
			if (other.GMILJKPOPGD)
			{
				this.GMILJKPOPGD = other.GMILJKPOPGD;
			}
			if (other.ItemValue != 0U)
			{
				this.ItemValue = other.ItemValue;
			}
			if (other.GNJAGILEMCJ)
			{
				this.GNJAGILEMCJ = other.GNJAGILEMCJ;
			}
			this.hLGLFNABFOP_.Add(other.hLGLFNABFOP_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D47 RID: 27975 RVA: 0x0012426D File Offset: 0x0012246D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x00124278 File Offset: 0x00122478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 64U)
				{
					if (num <= 96U)
					{
						if (num == 74U)
						{
							this.hLGLFNABFOP_.AddEntriesFrom(ref input, KBBMNPCNHMO._repeated_hLGLFNABFOP_codec);
							continue;
						}
						if (num == 80U)
						{
							this.ItemValue = input.ReadUInt32();
							continue;
						}
						if (num != 96U)
						{
							goto IL_77;
						}
					}
					else if (num != 98U)
					{
						if (num != 112U && num != 114U)
						{
							goto IL_77;
						}
						this.nMFPFCLDDNN_.AddEntriesFrom(ref input, KBBMNPCNHMO._repeated_nMFPFCLDDNN_codec);
						continue;
					}
					this.bACNPJFOAOF_.AddEntriesFrom(ref input, KBBMNPCNHMO._repeated_bACNPJFOAOF_codec);
					continue;
				}
				if (num <= 34U)
				{
					if (num == 16U)
					{
						this.DOIDHIJIKLH = input.ReadUInt32();
						continue;
					}
					if (num == 26U)
					{
						this.iENLIPDAPMG_.AddEntriesFrom(ref input, KBBMNPCNHMO._repeated_iENLIPDAPMG_codec);
						continue;
					}
					if (num == 34U)
					{
						this.gDILHIGFFNP_.AddEntriesFrom(ref input, KBBMNPCNHMO._repeated_gDILHIGFFNP_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.GMILJKPOPGD = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.GNJAGILEMCJ = input.ReadBool();
						continue;
					}
				}
				IL_77:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040029E8 RID: 10728
		private static readonly MessageParser<KBBMNPCNHMO> _parser = new MessageParser<KBBMNPCNHMO>(() => new KBBMNPCNHMO());

		// Token: 0x040029E9 RID: 10729
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029EA RID: 10730
		public const int NMFPFCLDDNNFieldNumber = 14;

		// Token: 0x040029EB RID: 10731
		private static readonly FieldCodec<uint> _repeated_nMFPFCLDDNN_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x040029EC RID: 10732
		private readonly RepeatedField<uint> nMFPFCLDDNN_ = new RepeatedField<uint>();

		// Token: 0x040029ED RID: 10733
		public const int IENLIPDAPMGFieldNumber = 3;

		// Token: 0x040029EE RID: 10734
		private static readonly FieldCodec<EJKBGEPDPMF> _repeated_iENLIPDAPMG_codec = FieldCodec.ForMessage<EJKBGEPDPMF>(26U, EJKBGEPDPMF.Parser);

		// Token: 0x040029EF RID: 10735
		private readonly RepeatedField<EJKBGEPDPMF> iENLIPDAPMG_ = new RepeatedField<EJKBGEPDPMF>();

		// Token: 0x040029F0 RID: 10736
		public const int GDILHIGFFNPFieldNumber = 4;

		// Token: 0x040029F1 RID: 10737
		private static readonly FieldCodec<LCINGIMGEEM> _repeated_gDILHIGFFNP_codec = FieldCodec.ForMessage<LCINGIMGEEM>(34U, LCINGIMGEEM.Parser);

		// Token: 0x040029F2 RID: 10738
		private readonly RepeatedField<LCINGIMGEEM> gDILHIGFFNP_ = new RepeatedField<LCINGIMGEEM>();

		// Token: 0x040029F3 RID: 10739
		public const int DOIDHIJIKLHFieldNumber = 2;

		// Token: 0x040029F4 RID: 10740
		private uint dOIDHIJIKLH_;

		// Token: 0x040029F5 RID: 10741
		public const int ExpFieldNumber = 6;

		// Token: 0x040029F6 RID: 10742
		private uint exp_;

		// Token: 0x040029F7 RID: 10743
		public const int BACNPJFOAOFFieldNumber = 12;

		// Token: 0x040029F8 RID: 10744
		private static readonly FieldCodec<uint> _repeated_bACNPJFOAOF_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x040029F9 RID: 10745
		private readonly RepeatedField<uint> bACNPJFOAOF_ = new RepeatedField<uint>();

		// Token: 0x040029FA RID: 10746
		public const int GMILJKPOPGDFieldNumber = 7;

		// Token: 0x040029FB RID: 10747
		private bool gMILJKPOPGD_;

		// Token: 0x040029FC RID: 10748
		public const int ItemValueFieldNumber = 10;

		// Token: 0x040029FD RID: 10749
		private uint itemValue_;

		// Token: 0x040029FE RID: 10750
		public const int GNJAGILEMCJFieldNumber = 8;

		// Token: 0x040029FF RID: 10751
		private bool gNJAGILEMCJ_;

		// Token: 0x04002A00 RID: 10752
		public const int HLGLFNABFOPFieldNumber = 9;

		// Token: 0x04002A01 RID: 10753
		private static readonly FieldCodec<NHCDHNDCJMI> _repeated_hLGLFNABFOP_codec = FieldCodec.ForMessage<NHCDHNDCJMI>(74U, NHCDHNDCJMI.Parser);

		// Token: 0x04002A02 RID: 10754
		private readonly RepeatedField<NHCDHNDCJMI> hLGLFNABFOP_ = new RepeatedField<NHCDHNDCJMI>();
	}
}
