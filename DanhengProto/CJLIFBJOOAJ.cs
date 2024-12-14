using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002CB RID: 715
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CJLIFBJOOAJ : IMessage<CJLIFBJOOAJ>, IMessage, IEquatable<CJLIFBJOOAJ>, IDeepCloneable<CJLIFBJOOAJ>, IBufferMessage
	{
		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0005A763 File Offset: 0x00058963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CJLIFBJOOAJ> Parser
		{
			get
			{
				return CJLIFBJOOAJ._parser;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x0005A76A File Offset: 0x0005896A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CJLIFBJOOAJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0005A77C File Offset: 0x0005897C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CJLIFBJOOAJ.Descriptor;
			}
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0005A783 File Offset: 0x00058983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CJLIFBJOOAJ()
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0005A798 File Offset: 0x00058998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CJLIFBJOOAJ(CJLIFBJOOAJ other) : this()
		{
			this.pKOKOOGPNFM_ = other.pKOKOOGPNFM_;
			this.dCEDNGLAOJI_ = other.dCEDNGLAOJI_;
			this.gMAKIOIBKME_ = other.gMAKIOIBKME_;
			this.buffList_ = other.buffList_.Clone();
			this.eOMONFAENDN_ = other.eOMONFAENDN_;
			this.kJJADMHEHGG_ = other.kJJADMHEHGG_;
			this.bIPGCKIBGLF_ = other.bIPGCKIBGLF_;
			this.eEEABJCNKDO_ = other.eEEABJCNKDO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0005A821 File Offset: 0x00058A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CJLIFBJOOAJ Clone()
		{
			return new CJLIFBJOOAJ(this);
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x0005A829 File Offset: 0x00058A29
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x0005A831 File Offset: 0x00058A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PKOKOOGPNFM
		{
			get
			{
				return this.pKOKOOGPNFM_;
			}
			set
			{
				this.pKOKOOGPNFM_ = value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x0005A83A File Offset: 0x00058A3A
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x0005A842 File Offset: 0x00058A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DCEDNGLAOJI
		{
			get
			{
				return this.dCEDNGLAOJI_;
			}
			set
			{
				this.dCEDNGLAOJI_ = value;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x0005A84B File Offset: 0x00058A4B
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x0005A853 File Offset: 0x00058A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GMAKIOIBKME
		{
			get
			{
				return this.gMAKIOIBKME_;
			}
			set
			{
				this.gMAKIOIBKME_ = value;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x0005A85C File Offset: 0x00058A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MBFIICLMKKD> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x0005A864 File Offset: 0x00058A64
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0005A86C File Offset: 0x00058A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EOMONFAENDN
		{
			get
			{
				return this.eOMONFAENDN_;
			}
			set
			{
				this.eOMONFAENDN_ = value;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0005A875 File Offset: 0x00058A75
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x0005A87D File Offset: 0x00058A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KJJADMHEHGG
		{
			get
			{
				return this.kJJADMHEHGG_;
			}
			set
			{
				this.kJJADMHEHGG_ = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0005A886 File Offset: 0x00058A86
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x0005A88E File Offset: 0x00058A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BIPGCKIBGLF
		{
			get
			{
				return this.bIPGCKIBGLF_;
			}
			set
			{
				this.bIPGCKIBGLF_ = value;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x0005A897 File Offset: 0x00058A97
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x0005A89F File Offset: 0x00058A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EEEABJCNKDO
		{
			get
			{
				return this.eEEABJCNKDO_;
			}
			set
			{
				this.eEEABJCNKDO_ = value;
			}
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x0005A8A8 File Offset: 0x00058AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CJLIFBJOOAJ);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0005A8B8 File Offset: 0x00058AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CJLIFBJOOAJ other)
		{
			return other != null && (other == this || (this.PKOKOOGPNFM == other.PKOKOOGPNFM && this.DCEDNGLAOJI == other.DCEDNGLAOJI && this.GMAKIOIBKME == other.GMAKIOIBKME && this.buffList_.Equals(other.buffList_) && this.EOMONFAENDN == other.EOMONFAENDN && this.KJJADMHEHGG == other.KJJADMHEHGG && this.BIPGCKIBGLF == other.BIPGCKIBGLF && this.EEEABJCNKDO == other.EEEABJCNKDO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x0005A968 File Offset: 0x00058B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PKOKOOGPNFM)
			{
				num ^= this.PKOKOOGPNFM.GetHashCode();
			}
			if (this.DCEDNGLAOJI)
			{
				num ^= this.DCEDNGLAOJI.GetHashCode();
			}
			if (this.GMAKIOIBKME)
			{
				num ^= this.GMAKIOIBKME.GetHashCode();
			}
			num ^= this.buffList_.GetHashCode();
			if (this.EOMONFAENDN != 0U)
			{
				num ^= this.EOMONFAENDN.GetHashCode();
			}
			if (this.KJJADMHEHGG != 0U)
			{
				num ^= this.KJJADMHEHGG.GetHashCode();
			}
			if (this.BIPGCKIBGLF)
			{
				num ^= this.BIPGCKIBGLF.GetHashCode();
			}
			if (this.EEEABJCNKDO != 0U)
			{
				num ^= this.EEEABJCNKDO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x0005AA4B File Offset: 0x00058C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0005AA53 File Offset: 0x00058C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0005AA5C File Offset: 0x00058C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EEEABJCNKDO != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EEEABJCNKDO);
			}
			if (this.BIPGCKIBGLF)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.BIPGCKIBGLF);
			}
			if (this.KJJADMHEHGG != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.KJJADMHEHGG);
			}
			if (this.EOMONFAENDN != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.EOMONFAENDN);
			}
			if (this.GMAKIOIBKME)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.GMAKIOIBKME);
			}
			if (this.PKOKOOGPNFM)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.PKOKOOGPNFM);
			}
			if (this.DCEDNGLAOJI)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.DCEDNGLAOJI);
			}
			this.buffList_.WriteTo(ref output, CJLIFBJOOAJ._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0005AB54 File Offset: 0x00058D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PKOKOOGPNFM)
			{
				num += 2;
			}
			if (this.DCEDNGLAOJI)
			{
				num += 2;
			}
			if (this.GMAKIOIBKME)
			{
				num += 2;
			}
			num += this.buffList_.CalculateSize(CJLIFBJOOAJ._repeated_buffList_codec);
			if (this.EOMONFAENDN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EOMONFAENDN);
			}
			if (this.KJJADMHEHGG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KJJADMHEHGG);
			}
			if (this.BIPGCKIBGLF)
			{
				num += 2;
			}
			if (this.EEEABJCNKDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EEEABJCNKDO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0005AC08 File Offset: 0x00058E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CJLIFBJOOAJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PKOKOOGPNFM)
			{
				this.PKOKOOGPNFM = other.PKOKOOGPNFM;
			}
			if (other.DCEDNGLAOJI)
			{
				this.DCEDNGLAOJI = other.DCEDNGLAOJI;
			}
			if (other.GMAKIOIBKME)
			{
				this.GMAKIOIBKME = other.GMAKIOIBKME;
			}
			this.buffList_.Add(other.buffList_);
			if (other.EOMONFAENDN != 0U)
			{
				this.EOMONFAENDN = other.EOMONFAENDN;
			}
			if (other.KJJADMHEHGG != 0U)
			{
				this.KJJADMHEHGG = other.KJJADMHEHGG;
			}
			if (other.BIPGCKIBGLF)
			{
				this.BIPGCKIBGLF = other.BIPGCKIBGLF;
			}
			if (other.EEEABJCNKDO != 0U)
			{
				this.EEEABJCNKDO = other.EEEABJCNKDO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0005ACCD File Offset: 0x00058ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0005ACD8 File Offset: 0x00058ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num <= 40U)
					{
						if (num == 24U)
						{
							this.EEEABJCNKDO = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.BIPGCKIBGLF = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.KJJADMHEHGG = input.ReadUInt32();
							continue;
						}
						if (num == 88U)
						{
							this.EOMONFAENDN = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 112U)
				{
					if (num == 104U)
					{
						this.GMAKIOIBKME = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.PKOKOOGPNFM = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 120U)
					{
						this.DCEDNGLAOJI = input.ReadBool();
						continue;
					}
					if (num == 5018U)
					{
						this.buffList_.AddEntriesFrom(ref input, CJLIFBJOOAJ._repeated_buffList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000D25 RID: 3365
		private static readonly MessageParser<CJLIFBJOOAJ> _parser = new MessageParser<CJLIFBJOOAJ>(() => new CJLIFBJOOAJ());

		// Token: 0x04000D26 RID: 3366
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D27 RID: 3367
		public const int PKOKOOGPNFMFieldNumber = 14;

		// Token: 0x04000D28 RID: 3368
		private bool pKOKOOGPNFM_;

		// Token: 0x04000D29 RID: 3369
		public const int DCEDNGLAOJIFieldNumber = 15;

		// Token: 0x04000D2A RID: 3370
		private bool dCEDNGLAOJI_;

		// Token: 0x04000D2B RID: 3371
		public const int GMAKIOIBKMEFieldNumber = 13;

		// Token: 0x04000D2C RID: 3372
		private bool gMAKIOIBKME_;

		// Token: 0x04000D2D RID: 3373
		public const int BuffListFieldNumber = 627;

		// Token: 0x04000D2E RID: 3374
		private static readonly FieldCodec<MBFIICLMKKD> _repeated_buffList_codec = FieldCodec.ForMessage<MBFIICLMKKD>(5018U, MBFIICLMKKD.Parser);

		// Token: 0x04000D2F RID: 3375
		private readonly RepeatedField<MBFIICLMKKD> buffList_ = new RepeatedField<MBFIICLMKKD>();

		// Token: 0x04000D30 RID: 3376
		public const int EOMONFAENDNFieldNumber = 11;

		// Token: 0x04000D31 RID: 3377
		private uint eOMONFAENDN_;

		// Token: 0x04000D32 RID: 3378
		public const int KJJADMHEHGGFieldNumber = 7;

		// Token: 0x04000D33 RID: 3379
		private uint kJJADMHEHGG_;

		// Token: 0x04000D34 RID: 3380
		public const int BIPGCKIBGLFFieldNumber = 5;

		// Token: 0x04000D35 RID: 3381
		private bool bIPGCKIBGLF_;

		// Token: 0x04000D36 RID: 3382
		public const int EEEABJCNKDOFieldNumber = 3;

		// Token: 0x04000D37 RID: 3383
		private uint eEEABJCNKDO_;
	}
}
