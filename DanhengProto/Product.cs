using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D05 RID: 3333
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Product : IMessage<Product>, IMessage, IEquatable<Product>, IDeepCloneable<Product>, IBufferMessage
	{
		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x060094E3 RID: 38115 RVA: 0x0018BC23 File Offset: 0x00189E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Product> Parser
		{
			get
			{
				return Product._parser;
			}
		}

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x060094E4 RID: 38116 RVA: 0x0018BC2A File Offset: 0x00189E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProductReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x060094E5 RID: 38117 RVA: 0x0018BC3C File Offset: 0x00189E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Product.Descriptor;
			}
		}

		// Token: 0x060094E6 RID: 38118 RVA: 0x0018BC43 File Offset: 0x00189E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Product()
		{
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x0018BC64 File Offset: 0x00189E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Product(Product other) : this()
		{
			this.fFKKKFJLIPB_ = other.fFKKKFJLIPB_;
			this.lOEPGDCDCBJ_ = other.lOEPGDCDCBJ_;
			this.eMDIBIKBAMK_ = other.eMDIBIKBAMK_;
			this.mEHPAOBCBDK_ = other.mEHPAOBCBDK_;
			this.fDGHNKDCPBI_ = other.fDGHNKDCPBI_;
			this.jMLNIBKPLGB_ = other.jMLNIBKPLGB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094E8 RID: 38120 RVA: 0x0018BCD0 File Offset: 0x00189ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Product Clone()
		{
			return new Product(this);
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x060094E9 RID: 38121 RVA: 0x0018BCD8 File Offset: 0x00189ED8
		// (set) Token: 0x060094EA RID: 38122 RVA: 0x0018BCE0 File Offset: 0x00189EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FFKKKFJLIPB
		{
			get
			{
				return this.fFKKKFJLIPB_;
			}
			set
			{
				this.fFKKKFJLIPB_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x060094EB RID: 38123 RVA: 0x0018BCF3 File Offset: 0x00189EF3
		// (set) Token: 0x060094EC RID: 38124 RVA: 0x0018BCFB File Offset: 0x00189EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LOEPGDCDCBJ
		{
			get
			{
				return this.lOEPGDCDCBJ_;
			}
			set
			{
				this.lOEPGDCDCBJ_ = value;
			}
		}

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x060094ED RID: 38125 RVA: 0x0018BD04 File Offset: 0x00189F04
		// (set) Token: 0x060094EE RID: 38126 RVA: 0x0018BD0C File Offset: 0x00189F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProductGiftType EMDIBIKBAMK
		{
			get
			{
				return this.eMDIBIKBAMK_;
			}
			set
			{
				this.eMDIBIKBAMK_ = value;
			}
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x060094EF RID: 38127 RVA: 0x0018BD15 File Offset: 0x00189F15
		// (set) Token: 0x060094F0 RID: 38128 RVA: 0x0018BD1D File Offset: 0x00189F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MEHPAOBCBDK
		{
			get
			{
				return this.mEHPAOBCBDK_;
			}
			set
			{
				this.mEHPAOBCBDK_ = value;
			}
		}

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x060094F1 RID: 38129 RVA: 0x0018BD26 File Offset: 0x00189F26
		// (set) Token: 0x060094F2 RID: 38130 RVA: 0x0018BD2E File Offset: 0x00189F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FDGHNKDCPBI
		{
			get
			{
				return this.fDGHNKDCPBI_;
			}
			set
			{
				this.fDGHNKDCPBI_ = value;
			}
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x060094F3 RID: 38131 RVA: 0x0018BD37 File Offset: 0x00189F37
		// (set) Token: 0x060094F4 RID: 38132 RVA: 0x0018BD3F File Offset: 0x00189F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JMLNIBKPLGB
		{
			get
			{
				return this.jMLNIBKPLGB_;
			}
			set
			{
				this.jMLNIBKPLGB_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060094F5 RID: 38133 RVA: 0x0018BD52 File Offset: 0x00189F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Product);
		}

		// Token: 0x060094F6 RID: 38134 RVA: 0x0018BD60 File Offset: 0x00189F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Product other)
		{
			return other != null && (other == this || (!(this.FFKKKFJLIPB != other.FFKKKFJLIPB) && this.LOEPGDCDCBJ == other.LOEPGDCDCBJ && this.EMDIBIKBAMK == other.EMDIBIKBAMK && this.MEHPAOBCBDK == other.MEHPAOBCBDK && this.FDGHNKDCPBI == other.FDGHNKDCPBI && !(this.JMLNIBKPLGB != other.JMLNIBKPLGB) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094F7 RID: 38135 RVA: 0x0018BDF4 File Offset: 0x00189FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FFKKKFJLIPB.Length != 0)
			{
				num ^= this.FFKKKFJLIPB.GetHashCode();
			}
			if (this.LOEPGDCDCBJ != 0U)
			{
				num ^= this.LOEPGDCDCBJ.GetHashCode();
			}
			if (this.EMDIBIKBAMK != ProductGiftType.ProductGiftNone)
			{
				num ^= this.EMDIBIKBAMK.GetHashCode();
			}
			if (this.MEHPAOBCBDK != 0U)
			{
				num ^= this.MEHPAOBCBDK.GetHashCode();
			}
			if (this.FDGHNKDCPBI)
			{
				num ^= this.FDGHNKDCPBI.GetHashCode();
			}
			if (this.JMLNIBKPLGB.Length != 0)
			{
				num ^= this.JMLNIBKPLGB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094F8 RID: 38136 RVA: 0x0018BEBA File Offset: 0x0018A0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060094F9 RID: 38137 RVA: 0x0018BEC2 File Offset: 0x0018A0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094FA RID: 38138 RVA: 0x0018BECC File Offset: 0x0018A0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JMLNIBKPLGB.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.JMLNIBKPLGB);
			}
			if (this.EMDIBIKBAMK != ProductGiftType.ProductGiftNone)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.EMDIBIKBAMK);
			}
			if (this.MEHPAOBCBDK != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MEHPAOBCBDK);
			}
			if (this.LOEPGDCDCBJ != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.LOEPGDCDCBJ);
			}
			if (this.FFKKKFJLIPB.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.FFKKKFJLIPB);
			}
			if (this.FDGHNKDCPBI)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.FDGHNKDCPBI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094FB RID: 38139 RVA: 0x0018BFA0 File Offset: 0x0018A1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FFKKKFJLIPB.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FFKKKFJLIPB);
			}
			if (this.LOEPGDCDCBJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LOEPGDCDCBJ);
			}
			if (this.EMDIBIKBAMK != ProductGiftType.ProductGiftNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EMDIBIKBAMK);
			}
			if (this.MEHPAOBCBDK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MEHPAOBCBDK);
			}
			if (this.FDGHNKDCPBI)
			{
				num += 2;
			}
			if (this.JMLNIBKPLGB.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.JMLNIBKPLGB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094FC RID: 38140 RVA: 0x0018C054 File Offset: 0x0018A254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Product other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FFKKKFJLIPB.Length != 0)
			{
				this.FFKKKFJLIPB = other.FFKKKFJLIPB;
			}
			if (other.LOEPGDCDCBJ != 0U)
			{
				this.LOEPGDCDCBJ = other.LOEPGDCDCBJ;
			}
			if (other.EMDIBIKBAMK != ProductGiftType.ProductGiftNone)
			{
				this.EMDIBIKBAMK = other.EMDIBIKBAMK;
			}
			if (other.MEHPAOBCBDK != 0U)
			{
				this.MEHPAOBCBDK = other.MEHPAOBCBDK;
			}
			if (other.FDGHNKDCPBI)
			{
				this.FDGHNKDCPBI = other.FDGHNKDCPBI;
			}
			if (other.JMLNIBKPLGB.Length != 0)
			{
				this.JMLNIBKPLGB = other.JMLNIBKPLGB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x0018C0FE File Offset: 0x0018A2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x0018C108 File Offset: 0x0018A308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 34U)
					{
						this.JMLNIBKPLGB = input.ReadString();
						continue;
					}
					if (num == 48U)
					{
						this.EMDIBIKBAMK = (ProductGiftType)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.MEHPAOBCBDK = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.LOEPGDCDCBJ = input.ReadUInt32();
						continue;
					}
					if (num == 82U)
					{
						this.FFKKKFJLIPB = input.ReadString();
						continue;
					}
					if (num == 104U)
					{
						this.FDGHNKDCPBI = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040039A8 RID: 14760
		private static readonly MessageParser<Product> _parser = new MessageParser<Product>(() => new Product());

		// Token: 0x040039A9 RID: 14761
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039AA RID: 14762
		public const int FFKKKFJLIPBFieldNumber = 10;

		// Token: 0x040039AB RID: 14763
		private string fFKKKFJLIPB_ = "";

		// Token: 0x040039AC RID: 14764
		public const int LOEPGDCDCBJFieldNumber = 9;

		// Token: 0x040039AD RID: 14765
		private uint lOEPGDCDCBJ_;

		// Token: 0x040039AE RID: 14766
		public const int EMDIBIKBAMKFieldNumber = 6;

		// Token: 0x040039AF RID: 14767
		private ProductGiftType eMDIBIKBAMK_;

		// Token: 0x040039B0 RID: 14768
		public const int MEHPAOBCBDKFieldNumber = 7;

		// Token: 0x040039B1 RID: 14769
		private uint mEHPAOBCBDK_;

		// Token: 0x040039B2 RID: 14770
		public const int FDGHNKDCPBIFieldNumber = 13;

		// Token: 0x040039B3 RID: 14771
		private bool fDGHNKDCPBI_;

		// Token: 0x040039B4 RID: 14772
		public const int JMLNIBKPLGBFieldNumber = 4;

		// Token: 0x040039B5 RID: 14773
		private string jMLNIBKPLGB_ = "";
	}
}
