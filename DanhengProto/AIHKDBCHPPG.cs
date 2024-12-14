using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000077 RID: 119
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AIHKDBCHPPG : IMessage<AIHKDBCHPPG>, IMessage, IEquatable<AIHKDBCHPPG>, IDeepCloneable<AIHKDBCHPPG>, IBufferMessage
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0000E861 File Offset: 0x0000CA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AIHKDBCHPPG> Parser
		{
			get
			{
				return AIHKDBCHPPG._parser;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0000E868 File Offset: 0x0000CA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AIHKDBCHPPGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0000E87A File Offset: 0x0000CA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AIHKDBCHPPG.Descriptor;
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000E881 File Offset: 0x0000CA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AIHKDBCHPPG()
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000E8AC File Offset: 0x0000CAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AIHKDBCHPPG(AIHKDBCHPPG other) : this()
		{
			this.phase_ = other.phase_;
			this.iDMFMMKNMNN_ = other.iDMFMMKNMNN_;
			this.hADKKFPOMCJ_ = other.hADKKFPOMCJ_;
			this.aGMPJEDFKLF_ = other.aGMPJEDFKLF_;
			this.gMBCHDKFLHD_ = other.gMBCHDKFLHD_;
			this.iLHMJAHEIPI_ = other.iLHMJAHEIPI_;
			this.dPKHBCDJIGO_ = other.dPKHBCDJIGO_;
			this.eLOKPKGJEOK_ = other.eLOKPKGJEOK_;
			this.pLMFECAPGHD_ = other.pLMFECAPGHD_.Clone();
			this.eIAOLKIAOFI_ = other.eIAOLKIAOFI_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000E952 File Offset: 0x0000CB52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AIHKDBCHPPG Clone()
		{
			return new AIHKDBCHPPG(this);
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0000E95A File Offset: 0x0000CB5A
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x0000E962 File Offset: 0x0000CB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Phase
		{
			get
			{
				return this.phase_;
			}
			set
			{
				this.phase_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0000E975 File Offset: 0x0000CB75
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x0000E97D File Offset: 0x0000CB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float IDMFMMKNMNN
		{
			get
			{
				return this.iDMFMMKNMNN_;
			}
			set
			{
				this.iDMFMMKNMNN_ = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0000E986 File Offset: 0x0000CB86
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x0000E98E File Offset: 0x0000CB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float HADKKFPOMCJ
		{
			get
			{
				return this.hADKKFPOMCJ_;
			}
			set
			{
				this.hADKKFPOMCJ_ = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0000E997 File Offset: 0x0000CB97
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x0000E99F File Offset: 0x0000CB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AGMPJEDFKLF
		{
			get
			{
				return this.aGMPJEDFKLF_;
			}
			set
			{
				this.aGMPJEDFKLF_ = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0000E9A8 File Offset: 0x0000CBA8
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x0000E9B0 File Offset: 0x0000CBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GMBCHDKFLHD
		{
			get
			{
				return this.gMBCHDKFLHD_;
			}
			set
			{
				this.gMBCHDKFLHD_ = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0000E9B9 File Offset: 0x0000CBB9
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x0000E9C1 File Offset: 0x0000CBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ILHMJAHEIPI
		{
			get
			{
				return this.iLHMJAHEIPI_;
			}
			set
			{
				this.iLHMJAHEIPI_ = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0000E9CA File Offset: 0x0000CBCA
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x0000E9D2 File Offset: 0x0000CBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DPKHBCDJIGO
		{
			get
			{
				return this.dPKHBCDJIGO_;
			}
			set
			{
				this.dPKHBCDJIGO_ = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0000E9DB File Offset: 0x0000CBDB
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x0000E9E3 File Offset: 0x0000CBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ELOKPKGJEOK
		{
			get
			{
				return this.eLOKPKGJEOK_;
			}
			set
			{
				this.eLOKPKGJEOK_ = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0000E9EC File Offset: 0x0000CBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PLMFECAPGHD
		{
			get
			{
				return this.pLMFECAPGHD_;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0000E9F4 File Offset: 0x0000CBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EIAOLKIAOFI
		{
			get
			{
				return this.eIAOLKIAOFI_;
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AIHKDBCHPPG);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000EA0C File Offset: 0x0000CC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AIHKDBCHPPG other)
		{
			return other != null && (other == this || (!(this.Phase != other.Phase) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.IDMFMMKNMNN, other.IDMFMMKNMNN) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.HADKKFPOMCJ, other.HADKKFPOMCJ) && this.AGMPJEDFKLF == other.AGMPJEDFKLF && this.GMBCHDKFLHD == other.GMBCHDKFLHD && this.ILHMJAHEIPI == other.ILHMJAHEIPI && this.DPKHBCDJIGO == other.DPKHBCDJIGO && this.ELOKPKGJEOK == other.ELOKPKGJEOK && this.pLMFECAPGHD_.Equals(other.pLMFECAPGHD_) && this.eIAOLKIAOFI_.Equals(other.eIAOLKIAOFI_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000EAF8 File Offset: 0x0000CCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Phase.Length != 0)
			{
				num ^= this.Phase.GetHashCode();
			}
			if (this.IDMFMMKNMNN != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.IDMFMMKNMNN);
			}
			if (this.HADKKFPOMCJ != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.HADKKFPOMCJ);
			}
			if (this.AGMPJEDFKLF != 0U)
			{
				num ^= this.AGMPJEDFKLF.GetHashCode();
			}
			if (this.GMBCHDKFLHD != 0U)
			{
				num ^= this.GMBCHDKFLHD.GetHashCode();
			}
			if (this.ILHMJAHEIPI != 0U)
			{
				num ^= this.ILHMJAHEIPI.GetHashCode();
			}
			if (this.DPKHBCDJIGO != 0U)
			{
				num ^= this.DPKHBCDJIGO.GetHashCode();
			}
			if (this.ELOKPKGJEOK != 0U)
			{
				num ^= this.ELOKPKGJEOK.GetHashCode();
			}
			num ^= this.pLMFECAPGHD_.GetHashCode();
			num ^= this.eIAOLKIAOFI_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000EC12 File Offset: 0x0000CE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000EC1A File Offset: 0x0000CE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000EC24 File Offset: 0x0000CE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Phase.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Phase);
			}
			if (this.IDMFMMKNMNN != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.IDMFMMKNMNN);
			}
			if (this.HADKKFPOMCJ != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.HADKKFPOMCJ);
			}
			if (this.AGMPJEDFKLF != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AGMPJEDFKLF);
			}
			if (this.GMBCHDKFLHD != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GMBCHDKFLHD);
			}
			if (this.ILHMJAHEIPI != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ILHMJAHEIPI);
			}
			if (this.DPKHBCDJIGO != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.DPKHBCDJIGO);
			}
			if (this.ELOKPKGJEOK != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ELOKPKGJEOK);
			}
			this.pLMFECAPGHD_.WriteTo(ref output, AIHKDBCHPPG._repeated_pLMFECAPGHD_codec);
			this.eIAOLKIAOFI_.WriteTo(ref output, AIHKDBCHPPG._repeated_eIAOLKIAOFI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000ED58 File Offset: 0x0000CF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Phase.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Phase);
			}
			if (this.IDMFMMKNMNN != 0f)
			{
				num += 5;
			}
			if (this.HADKKFPOMCJ != 0f)
			{
				num += 5;
			}
			if (this.AGMPJEDFKLF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AGMPJEDFKLF);
			}
			if (this.GMBCHDKFLHD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GMBCHDKFLHD);
			}
			if (this.ILHMJAHEIPI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ILHMJAHEIPI);
			}
			if (this.DPKHBCDJIGO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DPKHBCDJIGO);
			}
			if (this.ELOKPKGJEOK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ELOKPKGJEOK);
			}
			num += this.pLMFECAPGHD_.CalculateSize(AIHKDBCHPPG._repeated_pLMFECAPGHD_codec);
			num += this.eIAOLKIAOFI_.CalculateSize(AIHKDBCHPPG._repeated_eIAOLKIAOFI_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000EE5C File Offset: 0x0000D05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AIHKDBCHPPG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Phase.Length != 0)
			{
				this.Phase = other.Phase;
			}
			if (other.IDMFMMKNMNN != 0f)
			{
				this.IDMFMMKNMNN = other.IDMFMMKNMNN;
			}
			if (other.HADKKFPOMCJ != 0f)
			{
				this.HADKKFPOMCJ = other.HADKKFPOMCJ;
			}
			if (other.AGMPJEDFKLF != 0U)
			{
				this.AGMPJEDFKLF = other.AGMPJEDFKLF;
			}
			if (other.GMBCHDKFLHD != 0U)
			{
				this.GMBCHDKFLHD = other.GMBCHDKFLHD;
			}
			if (other.ILHMJAHEIPI != 0U)
			{
				this.ILHMJAHEIPI = other.ILHMJAHEIPI;
			}
			if (other.DPKHBCDJIGO != 0U)
			{
				this.DPKHBCDJIGO = other.DPKHBCDJIGO;
			}
			if (other.ELOKPKGJEOK != 0U)
			{
				this.ELOKPKGJEOK = other.ELOKPKGJEOK;
			}
			this.pLMFECAPGHD_.Add(other.pLMFECAPGHD_);
			this.eIAOLKIAOFI_.Add(other.eIAOLKIAOFI_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000EF55 File Offset: 0x0000D155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000EF60 File Offset: 0x0000D160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 48U)
				{
					if (num <= 72U)
					{
						if (num == 56U)
						{
							this.DPKHBCDJIGO = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							this.ELOKPKGJEOK = input.ReadUInt32();
							continue;
						}
						if (num != 72U)
						{
							goto IL_77;
						}
					}
					else if (num != 74U)
					{
						if (num != 80U && num != 82U)
						{
							goto IL_77;
						}
						this.eIAOLKIAOFI_.AddEntriesFrom(ref input, AIHKDBCHPPG._repeated_eIAOLKIAOFI_codec);
						continue;
					}
					this.pLMFECAPGHD_.AddEntriesFrom(ref input, AIHKDBCHPPG._repeated_pLMFECAPGHD_codec);
					continue;
				}
				if (num <= 29U)
				{
					if (num == 10U)
					{
						this.Phase = input.ReadString();
						continue;
					}
					if (num == 21U)
					{
						this.IDMFMMKNMNN = input.ReadFloat();
						continue;
					}
					if (num == 29U)
					{
						this.HADKKFPOMCJ = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.AGMPJEDFKLF = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.GMBCHDKFLHD = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ILHMJAHEIPI = input.ReadUInt32();
						continue;
					}
				}
				IL_77:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040001D3 RID: 467
		private static readonly MessageParser<AIHKDBCHPPG> _parser = new MessageParser<AIHKDBCHPPG>(() => new AIHKDBCHPPG());

		// Token: 0x040001D4 RID: 468
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001D5 RID: 469
		public const int PhaseFieldNumber = 1;

		// Token: 0x040001D6 RID: 470
		private string phase_ = "";

		// Token: 0x040001D7 RID: 471
		public const int IDMFMMKNMNNFieldNumber = 2;

		// Token: 0x040001D8 RID: 472
		private float iDMFMMKNMNN_;

		// Token: 0x040001D9 RID: 473
		public const int HADKKFPOMCJFieldNumber = 3;

		// Token: 0x040001DA RID: 474
		private float hADKKFPOMCJ_;

		// Token: 0x040001DB RID: 475
		public const int AGMPJEDFKLFFieldNumber = 4;

		// Token: 0x040001DC RID: 476
		private uint aGMPJEDFKLF_;

		// Token: 0x040001DD RID: 477
		public const int GMBCHDKFLHDFieldNumber = 5;

		// Token: 0x040001DE RID: 478
		private uint gMBCHDKFLHD_;

		// Token: 0x040001DF RID: 479
		public const int ILHMJAHEIPIFieldNumber = 6;

		// Token: 0x040001E0 RID: 480
		private uint iLHMJAHEIPI_;

		// Token: 0x040001E1 RID: 481
		public const int DPKHBCDJIGOFieldNumber = 7;

		// Token: 0x040001E2 RID: 482
		private uint dPKHBCDJIGO_;

		// Token: 0x040001E3 RID: 483
		public const int ELOKPKGJEOKFieldNumber = 8;

		// Token: 0x040001E4 RID: 484
		private uint eLOKPKGJEOK_;

		// Token: 0x040001E5 RID: 485
		public const int PLMFECAPGHDFieldNumber = 9;

		// Token: 0x040001E6 RID: 486
		private static readonly FieldCodec<uint> _repeated_pLMFECAPGHD_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x040001E7 RID: 487
		private readonly RepeatedField<uint> pLMFECAPGHD_ = new RepeatedField<uint>();

		// Token: 0x040001E8 RID: 488
		public const int EIAOLKIAOFIFieldNumber = 10;

		// Token: 0x040001E9 RID: 489
		private static readonly FieldCodec<uint> _repeated_eIAOLKIAOFI_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x040001EA RID: 490
		private readonly RepeatedField<uint> eIAOLKIAOFI_ = new RepeatedField<uint>();
	}
}
