using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000131 RID: 305
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BMICCBDOCGG : IMessage<BMICCBDOCGG>, IMessage, IEquatable<BMICCBDOCGG>, IDeepCloneable<BMICCBDOCGG>, IBufferMessage
	{
		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00028F63 File Offset: 0x00027163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BMICCBDOCGG> Parser
		{
			get
			{
				return BMICCBDOCGG._parser;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00028F6A File Offset: 0x0002716A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BMICCBDOCGGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x00028F7C File Offset: 0x0002717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BMICCBDOCGG.Descriptor;
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00028F83 File Offset: 0x00027183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMICCBDOCGG()
		{
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00028FA4 File Offset: 0x000271A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMICCBDOCGG(BMICCBDOCGG other) : this()
		{
			this.cDHKEBEIFDG_ = other.cDHKEBEIFDG_;
			this.oIAJNADKJBP_ = other.oIAJNADKJBP_.Clone();
			this.pHGBMKGICIN_ = other.pHGBMKGICIN_;
			this.gGMHDPCMGFP_ = ((other.gGMHDPCMGFP_ != null) ? other.gGMHDPCMGFP_.Clone() : null);
			this.dMHKBCBCLGF_ = other.dMHKBCBCLGF_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0002901E File Offset: 0x0002721E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMICCBDOCGG Clone()
		{
			return new BMICCBDOCGG(this);
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00029026 File Offset: 0x00027226
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x0002902E File Offset: 0x0002722E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CDHKEBEIFDG
		{
			get
			{
				return this.cDHKEBEIFDG_;
			}
			set
			{
				this.cDHKEBEIFDG_ = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x00029037 File Offset: 0x00027237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DHAIJMPAJDL> OIAJNADKJBP
		{
			get
			{
				return this.oIAJNADKJBP_;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x0002903F File Offset: 0x0002723F
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x00029047 File Offset: 0x00027247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHGBMKGICIN
		{
			get
			{
				return this.pHGBMKGICIN_;
			}
			set
			{
				this.pHGBMKGICIN_ = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00029050 File Offset: 0x00027250
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x00029058 File Offset: 0x00027258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHAIJMPAJDL GGMHDPCMGFP
		{
			get
			{
				return this.gGMHDPCMGFP_;
			}
			set
			{
				this.gGMHDPCMGFP_ = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00029061 File Offset: 0x00027261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DHAIJMPAJDL> DMHKBCBCLGF
		{
			get
			{
				return this.dMHKBCBCLGF_;
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00029069 File Offset: 0x00027269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BMICCBDOCGG);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00029078 File Offset: 0x00027278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BMICCBDOCGG other)
		{
			return other != null && (other == this || (this.CDHKEBEIFDG == other.CDHKEBEIFDG && this.oIAJNADKJBP_.Equals(other.oIAJNADKJBP_) && this.PHGBMKGICIN == other.PHGBMKGICIN && object.Equals(this.GGMHDPCMGFP, other.GGMHDPCMGFP) && this.dMHKBCBCLGF_.Equals(other.dMHKBCBCLGF_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00029100 File Offset: 0x00027300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CDHKEBEIFDG != 0U)
			{
				num ^= this.CDHKEBEIFDG.GetHashCode();
			}
			num ^= this.oIAJNADKJBP_.GetHashCode();
			if (this.PHGBMKGICIN != 0U)
			{
				num ^= this.PHGBMKGICIN.GetHashCode();
			}
			if (this.gGMHDPCMGFP_ != null)
			{
				num ^= this.GGMHDPCMGFP.GetHashCode();
			}
			num ^= this.dMHKBCBCLGF_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0002918A File Offset: 0x0002738A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00029192 File Offset: 0x00027392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0002919C File Offset: 0x0002739C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PHGBMKGICIN != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PHGBMKGICIN);
			}
			this.dMHKBCBCLGF_.WriteTo(ref output, BMICCBDOCGG._repeated_dMHKBCBCLGF_codec);
			this.oIAJNADKJBP_.WriteTo(ref output, BMICCBDOCGG._repeated_oIAJNADKJBP_codec);
			if (this.CDHKEBEIFDG != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CDHKEBEIFDG);
			}
			if (this.gGMHDPCMGFP_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GGMHDPCMGFP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00029234 File Offset: 0x00027434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CDHKEBEIFDG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CDHKEBEIFDG);
			}
			num += this.oIAJNADKJBP_.CalculateSize(BMICCBDOCGG._repeated_oIAJNADKJBP_codec);
			if (this.PHGBMKGICIN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHGBMKGICIN);
			}
			if (this.gGMHDPCMGFP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GGMHDPCMGFP);
			}
			num += this.dMHKBCBCLGF_.CalculateSize(BMICCBDOCGG._repeated_dMHKBCBCLGF_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x000292C8 File Offset: 0x000274C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BMICCBDOCGG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CDHKEBEIFDG != 0U)
			{
				this.CDHKEBEIFDG = other.CDHKEBEIFDG;
			}
			this.oIAJNADKJBP_.Add(other.oIAJNADKJBP_);
			if (other.PHGBMKGICIN != 0U)
			{
				this.PHGBMKGICIN = other.PHGBMKGICIN;
			}
			if (other.gGMHDPCMGFP_ != null)
			{
				if (this.gGMHDPCMGFP_ == null)
				{
					this.GGMHDPCMGFP = new DHAIJMPAJDL();
				}
				this.GGMHDPCMGFP.MergeFrom(other.GGMHDPCMGFP);
			}
			this.dMHKBCBCLGF_.Add(other.dMHKBCBCLGF_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00029366 File Offset: 0x00027566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00029370 File Offset: 0x00027570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 16U)
					{
						this.PHGBMKGICIN = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						this.dMHKBCBCLGF_.AddEntriesFrom(ref input, BMICCBDOCGG._repeated_dMHKBCBCLGF_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.oIAJNADKJBP_.AddEntriesFrom(ref input, BMICCBDOCGG._repeated_oIAJNADKJBP_codec);
						continue;
					}
					if (num == 80U)
					{
						this.CDHKEBEIFDG = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.gGMHDPCMGFP_ == null)
						{
							this.GGMHDPCMGFP = new DHAIJMPAJDL();
						}
						input.ReadMessage(this.GGMHDPCMGFP);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040005F1 RID: 1521
		private static readonly MessageParser<BMICCBDOCGG> _parser = new MessageParser<BMICCBDOCGG>(() => new BMICCBDOCGG());

		// Token: 0x040005F2 RID: 1522
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005F3 RID: 1523
		public const int CDHKEBEIFDGFieldNumber = 10;

		// Token: 0x040005F4 RID: 1524
		private uint cDHKEBEIFDG_;

		// Token: 0x040005F5 RID: 1525
		public const int OIAJNADKJBPFieldNumber = 9;

		// Token: 0x040005F6 RID: 1526
		private static readonly FieldCodec<DHAIJMPAJDL> _repeated_oIAJNADKJBP_codec = FieldCodec.ForMessage<DHAIJMPAJDL>(74U, DHAIJMPAJDL.Parser);

		// Token: 0x040005F7 RID: 1527
		private readonly RepeatedField<DHAIJMPAJDL> oIAJNADKJBP_ = new RepeatedField<DHAIJMPAJDL>();

		// Token: 0x040005F8 RID: 1528
		public const int PHGBMKGICINFieldNumber = 2;

		// Token: 0x040005F9 RID: 1529
		private uint pHGBMKGICIN_;

		// Token: 0x040005FA RID: 1530
		public const int GGMHDPCMGFPFieldNumber = 15;

		// Token: 0x040005FB RID: 1531
		private DHAIJMPAJDL gGMHDPCMGFP_;

		// Token: 0x040005FC RID: 1532
		public const int DMHKBCBCLGFFieldNumber = 7;

		// Token: 0x040005FD RID: 1533
		private static readonly FieldCodec<DHAIJMPAJDL> _repeated_dMHKBCBCLGF_codec = FieldCodec.ForMessage<DHAIJMPAJDL>(58U, DHAIJMPAJDL.Parser);

		// Token: 0x040005FE RID: 1534
		private readonly RepeatedField<DHAIJMPAJDL> dMHKBCBCLGF_ = new RepeatedField<DHAIJMPAJDL>();
	}
}
