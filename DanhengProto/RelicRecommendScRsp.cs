using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DAF RID: 3503
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RelicRecommendScRsp : IMessage<RelicRecommendScRsp>, IMessage, IEquatable<RelicRecommendScRsp>, IDeepCloneable<RelicRecommendScRsp>, IBufferMessage
	{
		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x06009C98 RID: 40088 RVA: 0x001A10DA File Offset: 0x0019F2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RelicRecommendScRsp> Parser
		{
			get
			{
				return RelicRecommendScRsp._parser;
			}
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x06009C99 RID: 40089 RVA: 0x001A10E1 File Offset: 0x0019F2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicRecommendScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x06009C9A RID: 40090 RVA: 0x001A10F3 File Offset: 0x0019F2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelicRecommendScRsp.Descriptor;
			}
		}

		// Token: 0x06009C9B RID: 40091 RVA: 0x001A10FC File Offset: 0x0019F2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicRecommendScRsp()
		{
		}

		// Token: 0x06009C9C RID: 40092 RVA: 0x001A1154 File Offset: 0x0019F354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicRecommendScRsp(RelicRecommendScRsp other) : this()
		{
			this.fICFDEBBFPF_ = other.fICFDEBBFPF_.Clone();
			this.kOCCBHMJNPB_ = other.kOCCBHMJNPB_.Clone();
			this.retcode_ = other.retcode_;
			this.eMOGIHMAKBG_ = other.eMOGIHMAKBG_.Clone();
			this.jJNGMADFMKA_ = other.jJNGMADFMKA_.Clone();
			this.pNAFGFMGOMJ_ = other.pNAFGFMGOMJ_.Clone();
			this.avatarId_ = other.avatarId_;
			this.rOGUETALENTSTATUSENABLE_ = other.rOGUETALENTSTATUSENABLE_;
			this.hLLBBAMOAIA_ = other.hLLBBAMOAIA_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C9D RID: 40093 RVA: 0x001A1202 File Offset: 0x0019F402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicRecommendScRsp Clone()
		{
			return new RelicRecommendScRsp(this);
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x06009C9E RID: 40094 RVA: 0x001A120A File Offset: 0x0019F40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KICJFOMNINL> FICFDEBBFPF
		{
			get
			{
				return this.fICFDEBBFPF_;
			}
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x06009C9F RID: 40095 RVA: 0x001A1212 File Offset: 0x0019F412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KICJFOMNINL> KOCCBHMJNPB
		{
			get
			{
				return this.kOCCBHMJNPB_;
			}
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x06009CA0 RID: 40096 RVA: 0x001A121A File Offset: 0x0019F41A
		// (set) Token: 0x06009CA1 RID: 40097 RVA: 0x001A1222 File Offset: 0x0019F422
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

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x06009CA2 RID: 40098 RVA: 0x001A122B File Offset: 0x0019F42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OPJNIHCPEIL> EMOGIHMAKBG
		{
			get
			{
				return this.eMOGIHMAKBG_;
			}
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x06009CA3 RID: 40099 RVA: 0x001A1233 File Offset: 0x0019F433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OPJNIHCPEIL> JJNGMADFMKA
		{
			get
			{
				return this.jJNGMADFMKA_;
			}
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x06009CA4 RID: 40100 RVA: 0x001A123B File Offset: 0x0019F43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KICJFOMNINL> PNAFGFMGOMJ
		{
			get
			{
				return this.pNAFGFMGOMJ_;
			}
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x06009CA5 RID: 40101 RVA: 0x001A1243 File Offset: 0x0019F443
		// (set) Token: 0x06009CA6 RID: 40102 RVA: 0x001A124B File Offset: 0x0019F44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x06009CA7 RID: 40103 RVA: 0x001A1254 File Offset: 0x0019F454
		// (set) Token: 0x06009CA8 RID: 40104 RVA: 0x001A125C File Offset: 0x0019F45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ROGUETALENTSTATUSENABLE
		{
			get
			{
				return this.rOGUETALENTSTATUSENABLE_;
			}
			set
			{
				this.rOGUETALENTSTATUSENABLE_ = value;
			}
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x06009CA9 RID: 40105 RVA: 0x001A1265 File Offset: 0x0019F465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KICJFOMNINL> HLLBBAMOAIA
		{
			get
			{
				return this.hLLBBAMOAIA_;
			}
		}

		// Token: 0x06009CAA RID: 40106 RVA: 0x001A126D File Offset: 0x0019F46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelicRecommendScRsp);
		}

		// Token: 0x06009CAB RID: 40107 RVA: 0x001A127C File Offset: 0x0019F47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelicRecommendScRsp other)
		{
			return other != null && (other == this || (this.fICFDEBBFPF_.Equals(other.fICFDEBBFPF_) && this.kOCCBHMJNPB_.Equals(other.kOCCBHMJNPB_) && this.Retcode == other.Retcode && this.eMOGIHMAKBG_.Equals(other.eMOGIHMAKBG_) && this.jJNGMADFMKA_.Equals(other.jJNGMADFMKA_) && this.pNAFGFMGOMJ_.Equals(other.pNAFGFMGOMJ_) && this.AvatarId == other.AvatarId && this.ROGUETALENTSTATUSENABLE == other.ROGUETALENTSTATUSENABLE && this.hLLBBAMOAIA_.Equals(other.hLLBBAMOAIA_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CAC RID: 40108 RVA: 0x001A1354 File Offset: 0x0019F554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fICFDEBBFPF_.GetHashCode();
			num ^= this.kOCCBHMJNPB_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.eMOGIHMAKBG_.GetHashCode();
			num ^= this.jJNGMADFMKA_.GetHashCode();
			num ^= this.pNAFGFMGOMJ_.GetHashCode();
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.ROGUETALENTSTATUSENABLE)
			{
				num ^= this.ROGUETALENTSTATUSENABLE.GetHashCode();
			}
			num ^= this.hLLBBAMOAIA_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CAD RID: 40109 RVA: 0x001A1419 File Offset: 0x0019F619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x001A1421 File Offset: 0x0019F621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x001A142C File Offset: 0x0019F62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fICFDEBBFPF_.WriteTo(ref output, RelicRecommendScRsp._repeated_fICFDEBBFPF_codec);
			this.hLLBBAMOAIA_.WriteTo(ref output, RelicRecommendScRsp._repeated_hLLBBAMOAIA_codec);
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AvatarId);
			}
			this.jJNGMADFMKA_.WriteTo(ref output, RelicRecommendScRsp._repeated_jJNGMADFMKA_codec);
			this.kOCCBHMJNPB_.WriteTo(ref output, RelicRecommendScRsp._repeated_kOCCBHMJNPB_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ROGUETALENTSTATUSENABLE)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.ROGUETALENTSTATUSENABLE);
			}
			this.eMOGIHMAKBG_.WriteTo(ref output, RelicRecommendScRsp._repeated_eMOGIHMAKBG_codec);
			this.pNAFGFMGOMJ_.WriteTo(ref output, RelicRecommendScRsp._repeated_pNAFGFMGOMJ_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x001A1508 File Offset: 0x0019F708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fICFDEBBFPF_.CalculateSize(RelicRecommendScRsp._repeated_fICFDEBBFPF_codec);
			num += this.kOCCBHMJNPB_.CalculateSize(RelicRecommendScRsp._repeated_kOCCBHMJNPB_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.eMOGIHMAKBG_.CalculateSize(RelicRecommendScRsp._repeated_eMOGIHMAKBG_codec);
			num += this.jJNGMADFMKA_.CalculateSize(RelicRecommendScRsp._repeated_jJNGMADFMKA_codec);
			num += this.pNAFGFMGOMJ_.CalculateSize(RelicRecommendScRsp._repeated_pNAFGFMGOMJ_codec);
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.ROGUETALENTSTATUSENABLE)
			{
				num += 2;
			}
			num += this.hLLBBAMOAIA_.CalculateSize(RelicRecommendScRsp._repeated_hLLBBAMOAIA_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x001A15DC File Offset: 0x0019F7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelicRecommendScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.fICFDEBBFPF_.Add(other.fICFDEBBFPF_);
			this.kOCCBHMJNPB_.Add(other.kOCCBHMJNPB_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.eMOGIHMAKBG_.Add(other.eMOGIHMAKBG_);
			this.jJNGMADFMKA_.Add(other.jJNGMADFMKA_);
			this.pNAFGFMGOMJ_.Add(other.pNAFGFMGOMJ_);
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.ROGUETALENTSTATUSENABLE)
			{
				this.ROGUETALENTSTATUSENABLE = other.ROGUETALENTSTATUSENABLE;
			}
			this.hLLBBAMOAIA_.Add(other.hLLBBAMOAIA_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x001A16A6 File Offset: 0x0019F8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CB3 RID: 40115 RVA: 0x001A16B0 File Offset: 0x0019F8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							this.fICFDEBBFPF_.AddEntriesFrom(ref input, RelicRecommendScRsp._repeated_fICFDEBBFPF_codec);
							continue;
						}
						if (num == 18U)
						{
							this.hLLBBAMOAIA_.AddEntriesFrom(ref input, RelicRecommendScRsp._repeated_hLLBBAMOAIA_codec);
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.AvatarId = input.ReadUInt32();
							continue;
						}
						if (num == 34U)
						{
							this.jJNGMADFMKA_.AddEntriesFrom(ref input, RelicRecommendScRsp._repeated_jJNGMADFMKA_codec);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 58U)
					{
						this.kOCCBHMJNPB_.AddEntriesFrom(ref input, RelicRecommendScRsp._repeated_kOCCBHMJNPB_codec);
						continue;
					}
					if (num == 88U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ROGUETALENTSTATUSENABLE = input.ReadBool();
						continue;
					}
					if (num == 106U)
					{
						this.eMOGIHMAKBG_.AddEntriesFrom(ref input, RelicRecommendScRsp._repeated_eMOGIHMAKBG_codec);
						continue;
					}
					if (num == 122U)
					{
						this.pNAFGFMGOMJ_.AddEntriesFrom(ref input, RelicRecommendScRsp._repeated_pNAFGFMGOMJ_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003CD8 RID: 15576
		private static readonly MessageParser<RelicRecommendScRsp> _parser = new MessageParser<RelicRecommendScRsp>(() => new RelicRecommendScRsp());

		// Token: 0x04003CD9 RID: 15577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CDA RID: 15578
		public const int FICFDEBBFPFFieldNumber = 1;

		// Token: 0x04003CDB RID: 15579
		private static readonly FieldCodec<KICJFOMNINL> _repeated_fICFDEBBFPF_codec = FieldCodec.ForMessage<KICJFOMNINL>(10U, KICJFOMNINL.Parser);

		// Token: 0x04003CDC RID: 15580
		private readonly RepeatedField<KICJFOMNINL> fICFDEBBFPF_ = new RepeatedField<KICJFOMNINL>();

		// Token: 0x04003CDD RID: 15581
		public const int KOCCBHMJNPBFieldNumber = 7;

		// Token: 0x04003CDE RID: 15582
		private static readonly FieldCodec<KICJFOMNINL> _repeated_kOCCBHMJNPB_codec = FieldCodec.ForMessage<KICJFOMNINL>(58U, KICJFOMNINL.Parser);

		// Token: 0x04003CDF RID: 15583
		private readonly RepeatedField<KICJFOMNINL> kOCCBHMJNPB_ = new RepeatedField<KICJFOMNINL>();

		// Token: 0x04003CE0 RID: 15584
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04003CE1 RID: 15585
		private uint retcode_;

		// Token: 0x04003CE2 RID: 15586
		public const int EMOGIHMAKBGFieldNumber = 13;

		// Token: 0x04003CE3 RID: 15587
		private static readonly FieldCodec<OPJNIHCPEIL> _repeated_eMOGIHMAKBG_codec = FieldCodec.ForMessage<OPJNIHCPEIL>(106U, OPJNIHCPEIL.Parser);

		// Token: 0x04003CE4 RID: 15588
		private readonly RepeatedField<OPJNIHCPEIL> eMOGIHMAKBG_ = new RepeatedField<OPJNIHCPEIL>();

		// Token: 0x04003CE5 RID: 15589
		public const int JJNGMADFMKAFieldNumber = 4;

		// Token: 0x04003CE6 RID: 15590
		private static readonly FieldCodec<OPJNIHCPEIL> _repeated_jJNGMADFMKA_codec = FieldCodec.ForMessage<OPJNIHCPEIL>(34U, OPJNIHCPEIL.Parser);

		// Token: 0x04003CE7 RID: 15591
		private readonly RepeatedField<OPJNIHCPEIL> jJNGMADFMKA_ = new RepeatedField<OPJNIHCPEIL>();

		// Token: 0x04003CE8 RID: 15592
		public const int PNAFGFMGOMJFieldNumber = 15;

		// Token: 0x04003CE9 RID: 15593
		private static readonly FieldCodec<KICJFOMNINL> _repeated_pNAFGFMGOMJ_codec = FieldCodec.ForMessage<KICJFOMNINL>(122U, KICJFOMNINL.Parser);

		// Token: 0x04003CEA RID: 15594
		private readonly RepeatedField<KICJFOMNINL> pNAFGFMGOMJ_ = new RepeatedField<KICJFOMNINL>();

		// Token: 0x04003CEB RID: 15595
		public const int AvatarIdFieldNumber = 3;

		// Token: 0x04003CEC RID: 15596
		private uint avatarId_;

		// Token: 0x04003CED RID: 15597
		public const int ROGUETALENTSTATUSENABLEFieldNumber = 12;

		// Token: 0x04003CEE RID: 15598
		private bool rOGUETALENTSTATUSENABLE_;

		// Token: 0x04003CEF RID: 15599
		public const int HLLBBAMOAIAFieldNumber = 2;

		// Token: 0x04003CF0 RID: 15600
		private static readonly FieldCodec<KICJFOMNINL> _repeated_hLLBBAMOAIA_codec = FieldCodec.ForMessage<KICJFOMNINL>(18U, KICJFOMNINL.Parser);

		// Token: 0x04003CF1 RID: 15601
		private readonly RepeatedField<KICJFOMNINL> hLLBBAMOAIA_ = new RepeatedField<KICJFOMNINL>();
	}
}
