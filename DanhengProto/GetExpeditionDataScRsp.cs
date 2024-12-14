using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000693 RID: 1683
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetExpeditionDataScRsp : IMessage<GetExpeditionDataScRsp>, IMessage, IEquatable<GetExpeditionDataScRsp>, IDeepCloneable<GetExpeditionDataScRsp>, IBufferMessage
	{
		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06004B5C RID: 19292 RVA: 0x000CCBAB File Offset: 0x000CADAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetExpeditionDataScRsp> Parser
		{
			get
			{
				return GetExpeditionDataScRsp._parser;
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06004B5D RID: 19293 RVA: 0x000CCBB2 File Offset: 0x000CADB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetExpeditionDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06004B5E RID: 19294 RVA: 0x000CCBC4 File Offset: 0x000CADC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetExpeditionDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x000CCBCB File Offset: 0x000CADCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetExpeditionDataScRsp()
		{
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x000CCC0C File Offset: 0x000CAE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetExpeditionDataScRsp(GetExpeditionDataScRsp other) : this()
		{
			this.dLHILDEHBMI_ = other.dLHILDEHBMI_;
			this.aJMJNIMFDOO_ = other.aJMJNIMFDOO_.Clone();
			this.cLOGAEMKPPM_ = other.cLOGAEMKPPM_.Clone();
			this.gNJKNMOAEHA_ = other.gNJKNMOAEHA_.Clone();
			this.retcode_ = other.retcode_;
			this.lEOJCIHOGPM_ = other.lEOJCIHOGPM_.Clone();
			this.kLMGFFABHCA_ = other.kLMGFFABHCA_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x000CCC9D File Offset: 0x000CAE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetExpeditionDataScRsp Clone()
		{
			return new GetExpeditionDataScRsp(this);
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06004B62 RID: 19298 RVA: 0x000CCCA5 File Offset: 0x000CAEA5
		// (set) Token: 0x06004B63 RID: 19299 RVA: 0x000CCCAD File Offset: 0x000CAEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DLHILDEHBMI
		{
			get
			{
				return this.dLHILDEHBMI_;
			}
			set
			{
				this.dLHILDEHBMI_ = value;
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06004B64 RID: 19300 RVA: 0x000CCCB6 File Offset: 0x000CAEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AJMJNIMFDOO
		{
			get
			{
				return this.aJMJNIMFDOO_;
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06004B65 RID: 19301 RVA: 0x000CCCBE File Offset: 0x000CAEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JLHHCIJPOPD> CLOGAEMKPPM
		{
			get
			{
				return this.cLOGAEMKPPM_;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x000CCCC6 File Offset: 0x000CAEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GNJKNMOAEHA
		{
			get
			{
				return this.gNJKNMOAEHA_;
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06004B67 RID: 19303 RVA: 0x000CCCCE File Offset: 0x000CAECE
		// (set) Token: 0x06004B68 RID: 19304 RVA: 0x000CCCD6 File Offset: 0x000CAED6
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

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06004B69 RID: 19305 RVA: 0x000CCCDF File Offset: 0x000CAEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LEOJCIHOGPM
		{
			get
			{
				return this.lEOJCIHOGPM_;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06004B6A RID: 19306 RVA: 0x000CCCE7 File Offset: 0x000CAEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityExpedition> KLMGFFABHCA
		{
			get
			{
				return this.kLMGFFABHCA_;
			}
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x000CCCEF File Offset: 0x000CAEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetExpeditionDataScRsp);
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x000CCD00 File Offset: 0x000CAF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetExpeditionDataScRsp other)
		{
			return other != null && (other == this || (this.DLHILDEHBMI == other.DLHILDEHBMI && this.aJMJNIMFDOO_.Equals(other.aJMJNIMFDOO_) && this.cLOGAEMKPPM_.Equals(other.cLOGAEMKPPM_) && this.gNJKNMOAEHA_.Equals(other.gNJKNMOAEHA_) && this.Retcode == other.Retcode && this.lEOJCIHOGPM_.Equals(other.lEOJCIHOGPM_) && this.kLMGFFABHCA_.Equals(other.kLMGFFABHCA_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x000CCDB4 File Offset: 0x000CAFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DLHILDEHBMI != 0U)
			{
				num ^= this.DLHILDEHBMI.GetHashCode();
			}
			num ^= this.aJMJNIMFDOO_.GetHashCode();
			num ^= this.cLOGAEMKPPM_.GetHashCode();
			num ^= this.gNJKNMOAEHA_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.lEOJCIHOGPM_.GetHashCode();
			num ^= this.kLMGFFABHCA_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x000CCE52 File Offset: 0x000CB052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B6F RID: 19311 RVA: 0x000CCE5A File Offset: 0x000CB05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x000CCE64 File Offset: 0x000CB064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.gNJKNMOAEHA_.WriteTo(ref output, GetExpeditionDataScRsp._repeated_gNJKNMOAEHA_codec);
			this.kLMGFFABHCA_.WriteTo(ref output, GetExpeditionDataScRsp._repeated_kLMGFFABHCA_codec);
			this.aJMJNIMFDOO_.WriteTo(ref output, GetExpeditionDataScRsp._repeated_aJMJNIMFDOO_codec);
			if (this.DLHILDEHBMI != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.DLHILDEHBMI);
			}
			this.cLOGAEMKPPM_.WriteTo(ref output, GetExpeditionDataScRsp._repeated_cLOGAEMKPPM_codec);
			this.lEOJCIHOGPM_.WriteTo(ref output, GetExpeditionDataScRsp._repeated_lEOJCIHOGPM_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x000CCF14 File Offset: 0x000CB114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DLHILDEHBMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DLHILDEHBMI);
			}
			num += this.aJMJNIMFDOO_.CalculateSize(GetExpeditionDataScRsp._repeated_aJMJNIMFDOO_codec);
			num += this.cLOGAEMKPPM_.CalculateSize(GetExpeditionDataScRsp._repeated_cLOGAEMKPPM_codec);
			num += this.gNJKNMOAEHA_.CalculateSize(GetExpeditionDataScRsp._repeated_gNJKNMOAEHA_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.lEOJCIHOGPM_.CalculateSize(GetExpeditionDataScRsp._repeated_lEOJCIHOGPM_codec);
			num += this.kLMGFFABHCA_.CalculateSize(GetExpeditionDataScRsp._repeated_kLMGFFABHCA_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x000CCFCC File Offset: 0x000CB1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetExpeditionDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DLHILDEHBMI != 0U)
			{
				this.DLHILDEHBMI = other.DLHILDEHBMI;
			}
			this.aJMJNIMFDOO_.Add(other.aJMJNIMFDOO_);
			this.cLOGAEMKPPM_.Add(other.cLOGAEMKPPM_);
			this.gNJKNMOAEHA_.Add(other.gNJKNMOAEHA_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.lEOJCIHOGPM_.Add(other.lEOJCIHOGPM_);
			this.kLMGFFABHCA_.Add(other.kLMGFFABHCA_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x000CD071 File Offset: 0x000CB271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x000CD07C File Offset: 0x000CB27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
						if (num != 24U)
						{
							goto IL_4F;
						}
					}
					else if (num != 26U)
					{
						if (num == 34U)
						{
							this.kLMGFFABHCA_.AddEntriesFrom(ref input, GetExpeditionDataScRsp._repeated_kLMGFFABHCA_codec);
							continue;
						}
						if (num != 40U)
						{
							goto IL_4F;
						}
						goto IL_97;
					}
					this.gNJKNMOAEHA_.AddEntriesFrom(ref input, GetExpeditionDataScRsp._repeated_gNJKNMOAEHA_codec);
					continue;
				}
				if (num <= 72U)
				{
					if (num == 42U)
					{
						goto IL_97;
					}
					if (num == 72U)
					{
						this.DLHILDEHBMI = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.cLOGAEMKPPM_.AddEntriesFrom(ref input, GetExpeditionDataScRsp._repeated_cLOGAEMKPPM_codec);
						continue;
					}
					if (num == 96U || num == 98U)
					{
						this.lEOJCIHOGPM_.AddEntriesFrom(ref input, GetExpeditionDataScRsp._repeated_lEOJCIHOGPM_codec);
						continue;
					}
				}
				IL_4F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_97:
				this.aJMJNIMFDOO_.AddEntriesFrom(ref input, GetExpeditionDataScRsp._repeated_aJMJNIMFDOO_codec);
			}
		}

		// Token: 0x04001DD8 RID: 7640
		private static readonly MessageParser<GetExpeditionDataScRsp> _parser = new MessageParser<GetExpeditionDataScRsp>(() => new GetExpeditionDataScRsp());

		// Token: 0x04001DD9 RID: 7641
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DDA RID: 7642
		public const int DLHILDEHBMIFieldNumber = 9;

		// Token: 0x04001DDB RID: 7643
		private uint dLHILDEHBMI_;

		// Token: 0x04001DDC RID: 7644
		public const int AJMJNIMFDOOFieldNumber = 5;

		// Token: 0x04001DDD RID: 7645
		private static readonly FieldCodec<uint> _repeated_aJMJNIMFDOO_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04001DDE RID: 7646
		private readonly RepeatedField<uint> aJMJNIMFDOO_ = new RepeatedField<uint>();

		// Token: 0x04001DDF RID: 7647
		public const int CLOGAEMKPPMFieldNumber = 11;

		// Token: 0x04001DE0 RID: 7648
		private static readonly FieldCodec<JLHHCIJPOPD> _repeated_cLOGAEMKPPM_codec = FieldCodec.ForMessage<JLHHCIJPOPD>(90U, JLHHCIJPOPD.Parser);

		// Token: 0x04001DE1 RID: 7649
		private readonly RepeatedField<JLHHCIJPOPD> cLOGAEMKPPM_ = new RepeatedField<JLHHCIJPOPD>();

		// Token: 0x04001DE2 RID: 7650
		public const int GNJKNMOAEHAFieldNumber = 3;

		// Token: 0x04001DE3 RID: 7651
		private static readonly FieldCodec<uint> _repeated_gNJKNMOAEHA_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04001DE4 RID: 7652
		private readonly RepeatedField<uint> gNJKNMOAEHA_ = new RepeatedField<uint>();

		// Token: 0x04001DE5 RID: 7653
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04001DE6 RID: 7654
		private uint retcode_;

		// Token: 0x04001DE7 RID: 7655
		public const int LEOJCIHOGPMFieldNumber = 12;

		// Token: 0x04001DE8 RID: 7656
		private static readonly FieldCodec<uint> _repeated_lEOJCIHOGPM_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04001DE9 RID: 7657
		private readonly RepeatedField<uint> lEOJCIHOGPM_ = new RepeatedField<uint>();

		// Token: 0x04001DEA RID: 7658
		public const int KLMGFFABHCAFieldNumber = 4;

		// Token: 0x04001DEB RID: 7659
		private static readonly FieldCodec<ActivityExpedition> _repeated_kLMGFFABHCA_codec = FieldCodec.ForMessage<ActivityExpedition>(34U, ActivityExpedition.Parser);

		// Token: 0x04001DEC RID: 7660
		private readonly RepeatedField<ActivityExpedition> kLMGFFABHCA_ = new RepeatedField<ActivityExpedition>();
	}
}
