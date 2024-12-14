using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200077F RID: 1919
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPunkLordDataScRsp : IMessage<GetPunkLordDataScRsp>, IMessage, IEquatable<GetPunkLordDataScRsp>, IDeepCloneable<GetPunkLordDataScRsp>, IBufferMessage
	{
		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x060055B7 RID: 21943 RVA: 0x000E62BB File Offset: 0x000E44BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPunkLordDataScRsp> Parser
		{
			get
			{
				return GetPunkLordDataScRsp._parser;
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x060055B8 RID: 21944 RVA: 0x000E62C2 File Offset: 0x000E44C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPunkLordDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x060055B9 RID: 21945 RVA: 0x000E62D4 File Offset: 0x000E44D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPunkLordDataScRsp.Descriptor;
			}
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x000E62DB File Offset: 0x000E44DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordDataScRsp()
		{
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x000E62F0 File Offset: 0x000E44F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordDataScRsp(GetPunkLordDataScRsp other) : this()
		{
			this.gPPMKLOPKEJ_ = other.gPPMKLOPKEJ_;
			this.gKLLEINMPBL_ = other.gKLLEINMPBL_;
			this.lHFDCBAFJGK_ = other.lHFDCBAFJGK_.Clone();
			this.gHHNLAEPDMG_ = other.gHHNLAEPDMG_;
			this.retcode_ = other.retcode_;
			this.iNEEMDECJPK_ = other.iNEEMDECJPK_;
			this.jLJDFNHKHOO_ = other.jLJDFNHKHOO_;
			this.pNKNDNLNOAK_ = other.pNKNDNLNOAK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x000E6379 File Offset: 0x000E4579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPunkLordDataScRsp Clone()
		{
			return new GetPunkLordDataScRsp(this);
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x060055BD RID: 21949 RVA: 0x000E6381 File Offset: 0x000E4581
		// (set) Token: 0x060055BE RID: 21950 RVA: 0x000E6389 File Offset: 0x000E4589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GPPMKLOPKEJ
		{
			get
			{
				return this.gPPMKLOPKEJ_;
			}
			set
			{
				this.gPPMKLOPKEJ_ = value;
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x060055BF RID: 21951 RVA: 0x000E6392 File Offset: 0x000E4592
		// (set) Token: 0x060055C0 RID: 21952 RVA: 0x000E639A File Offset: 0x000E459A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GKLLEINMPBL
		{
			get
			{
				return this.gKLLEINMPBL_;
			}
			set
			{
				this.gKLLEINMPBL_ = value;
			}
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x060055C1 RID: 21953 RVA: 0x000E63A3 File Offset: 0x000E45A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LHFDCBAFJGK
		{
			get
			{
				return this.lHFDCBAFJGK_;
			}
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x060055C2 RID: 21954 RVA: 0x000E63AB File Offset: 0x000E45AB
		// (set) Token: 0x060055C3 RID: 21955 RVA: 0x000E63B3 File Offset: 0x000E45B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GHHNLAEPDMG
		{
			get
			{
				return this.gHHNLAEPDMG_;
			}
			set
			{
				this.gHHNLAEPDMG_ = value;
			}
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x060055C4 RID: 21956 RVA: 0x000E63BC File Offset: 0x000E45BC
		// (set) Token: 0x060055C5 RID: 21957 RVA: 0x000E63C4 File Offset: 0x000E45C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x000E63CD File Offset: 0x000E45CD
		// (set) Token: 0x060055C7 RID: 21959 RVA: 0x000E63D5 File Offset: 0x000E45D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint INEEMDECJPK
		{
			get
			{
				return this.iNEEMDECJPK_;
			}
			set
			{
				this.iNEEMDECJPK_ = value;
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x060055C8 RID: 21960 RVA: 0x000E63DE File Offset: 0x000E45DE
		// (set) Token: 0x060055C9 RID: 21961 RVA: 0x000E63E6 File Offset: 0x000E45E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JLJDFNHKHOO
		{
			get
			{
				return this.jLJDFNHKHOO_;
			}
			set
			{
				this.jLJDFNHKHOO_ = value;
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x000E63EF File Offset: 0x000E45EF
		// (set) Token: 0x060055CB RID: 21963 RVA: 0x000E63F7 File Offset: 0x000E45F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PNKNDNLNOAK
		{
			get
			{
				return this.pNKNDNLNOAK_;
			}
			set
			{
				this.pNKNDNLNOAK_ = value;
			}
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x000E6400 File Offset: 0x000E4600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPunkLordDataScRsp);
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x000E6410 File Offset: 0x000E4610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPunkLordDataScRsp other)
		{
			return other != null && (other == this || (this.GPPMKLOPKEJ == other.GPPMKLOPKEJ && this.GKLLEINMPBL == other.GKLLEINMPBL && this.lHFDCBAFJGK_.Equals(other.lHFDCBAFJGK_) && this.GHHNLAEPDMG == other.GHHNLAEPDMG && this.Retcode == other.Retcode && this.INEEMDECJPK == other.INEEMDECJPK && this.JLJDFNHKHOO == other.JLJDFNHKHOO && this.PNKNDNLNOAK == other.PNKNDNLNOAK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x000E64C0 File Offset: 0x000E46C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GPPMKLOPKEJ != 0L)
			{
				num ^= this.GPPMKLOPKEJ.GetHashCode();
			}
			if (this.GKLLEINMPBL != 0U)
			{
				num ^= this.GKLLEINMPBL.GetHashCode();
			}
			num ^= this.lHFDCBAFJGK_.GetHashCode();
			if (this.GHHNLAEPDMG != 0U)
			{
				num ^= this.GHHNLAEPDMG.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.INEEMDECJPK != 0U)
			{
				num ^= this.INEEMDECJPK.GetHashCode();
			}
			if (this.JLJDFNHKHOO != 0U)
			{
				num ^= this.JLJDFNHKHOO.GetHashCode();
			}
			if (this.PNKNDNLNOAK != 0U)
			{
				num ^= this.PNKNDNLNOAK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x000E65A3 File Offset: 0x000E47A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x000E65AB File Offset: 0x000E47AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x000E65B4 File Offset: 0x000E47B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GPPMKLOPKEJ != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.GPPMKLOPKEJ);
			}
			if (this.GKLLEINMPBL != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GKLLEINMPBL);
			}
			if (this.JLJDFNHKHOO != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.JLJDFNHKHOO);
			}
			if (this.GHHNLAEPDMG != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.GHHNLAEPDMG);
			}
			this.lHFDCBAFJGK_.WriteTo(ref output, GetPunkLordDataScRsp._repeated_lHFDCBAFJGK_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.INEEMDECJPK != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.INEEMDECJPK);
			}
			if (this.PNKNDNLNOAK != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.PNKNDNLNOAK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x000E66AC File Offset: 0x000E48AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GPPMKLOPKEJ != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.GPPMKLOPKEJ);
			}
			if (this.GKLLEINMPBL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKLLEINMPBL);
			}
			num += this.lHFDCBAFJGK_.CalculateSize(GetPunkLordDataScRsp._repeated_lHFDCBAFJGK_codec);
			if (this.GHHNLAEPDMG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GHHNLAEPDMG);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.INEEMDECJPK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.INEEMDECJPK);
			}
			if (this.JLJDFNHKHOO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JLJDFNHKHOO);
			}
			if (this.PNKNDNLNOAK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PNKNDNLNOAK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x000E6790 File Offset: 0x000E4990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPunkLordDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GPPMKLOPKEJ != 0L)
			{
				this.GPPMKLOPKEJ = other.GPPMKLOPKEJ;
			}
			if (other.GKLLEINMPBL != 0U)
			{
				this.GKLLEINMPBL = other.GKLLEINMPBL;
			}
			this.lHFDCBAFJGK_.Add(other.lHFDCBAFJGK_);
			if (other.GHHNLAEPDMG != 0U)
			{
				this.GHHNLAEPDMG = other.GHHNLAEPDMG;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.INEEMDECJPK != 0U)
			{
				this.INEEMDECJPK = other.INEEMDECJPK;
			}
			if (other.JLJDFNHKHOO != 0U)
			{
				this.JLJDFNHKHOO = other.JLJDFNHKHOO;
			}
			if (other.PNKNDNLNOAK != 0U)
			{
				this.PNKNDNLNOAK = other.PNKNDNLNOAK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x000E6855 File Offset: 0x000E4A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x000E6860 File Offset: 0x000E4A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num <= 48U)
					{
						if (num == 24U)
						{
							this.GPPMKLOPKEJ = input.ReadInt64();
							continue;
						}
						if (num == 48U)
						{
							this.GKLLEINMPBL = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 64U)
						{
							this.JLJDFNHKHOO = input.ReadUInt32();
							continue;
						}
						if (num == 72U)
						{
							this.GHHNLAEPDMG = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 80U || num == 82U)
					{
						this.lHFDCBAFJGK_.AddEntriesFrom(ref input, GetPunkLordDataScRsp._repeated_lHFDCBAFJGK_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.INEEMDECJPK = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.PNKNDNLNOAK = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002195 RID: 8597
		private static readonly MessageParser<GetPunkLordDataScRsp> _parser = new MessageParser<GetPunkLordDataScRsp>(() => new GetPunkLordDataScRsp());

		// Token: 0x04002196 RID: 8598
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002197 RID: 8599
		public const int GPPMKLOPKEJFieldNumber = 3;

		// Token: 0x04002198 RID: 8600
		private long gPPMKLOPKEJ_;

		// Token: 0x04002199 RID: 8601
		public const int GKLLEINMPBLFieldNumber = 6;

		// Token: 0x0400219A RID: 8602
		private uint gKLLEINMPBL_;

		// Token: 0x0400219B RID: 8603
		public const int LHFDCBAFJGKFieldNumber = 10;

		// Token: 0x0400219C RID: 8604
		private static readonly FieldCodec<uint> _repeated_lHFDCBAFJGK_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x0400219D RID: 8605
		private readonly RepeatedField<uint> lHFDCBAFJGK_ = new RepeatedField<uint>();

		// Token: 0x0400219E RID: 8606
		public const int GHHNLAEPDMGFieldNumber = 9;

		// Token: 0x0400219F RID: 8607
		private uint gHHNLAEPDMG_;

		// Token: 0x040021A0 RID: 8608
		public const int RetcodeFieldNumber = 11;

		// Token: 0x040021A1 RID: 8609
		private uint retcode_;

		// Token: 0x040021A2 RID: 8610
		public const int INEEMDECJPKFieldNumber = 13;

		// Token: 0x040021A3 RID: 8611
		private uint iNEEMDECJPK_;

		// Token: 0x040021A4 RID: 8612
		public const int JLJDFNHKHOOFieldNumber = 8;

		// Token: 0x040021A5 RID: 8613
		private uint jLJDFNHKHOO_;

		// Token: 0x040021A6 RID: 8614
		public const int PNKNDNLNOAKFieldNumber = 14;

		// Token: 0x040021A7 RID: 8615
		private uint pNKNDNLNOAK_;
	}
}
