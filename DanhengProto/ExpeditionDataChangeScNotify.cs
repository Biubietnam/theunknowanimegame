using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004E7 RID: 1255
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExpeditionDataChangeScNotify : IMessage<ExpeditionDataChangeScNotify>, IMessage, IEquatable<ExpeditionDataChangeScNotify>, IDeepCloneable<ExpeditionDataChangeScNotify>, IBufferMessage
	{
		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x0600381F RID: 14367 RVA: 0x00099BF3 File Offset: 0x00097DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpeditionDataChangeScNotify> Parser
		{
			get
			{
				return ExpeditionDataChangeScNotify._parser;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06003820 RID: 14368 RVA: 0x00099BFA File Offset: 0x00097DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExpeditionDataChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06003821 RID: 14369 RVA: 0x00099C0C File Offset: 0x00097E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpeditionDataChangeScNotify.Descriptor;
			}
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x00099C13 File Offset: 0x00097E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpeditionDataChangeScNotify()
		{
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x00099C48 File Offset: 0x00097E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpeditionDataChangeScNotify(ExpeditionDataChangeScNotify other) : this()
		{
			this.dLHILDEHBMI_ = other.dLHILDEHBMI_;
			this.kLMGFFABHCA_ = other.kLMGFFABHCA_.Clone();
			this.cLOGAEMKPPM_ = other.cLOGAEMKPPM_.Clone();
			this.gNJKNMOAEHA_ = other.gNJKNMOAEHA_.Clone();
			this.lEOJCIHOGPM_ = other.lEOJCIHOGPM_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x00099CBC File Offset: 0x00097EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpeditionDataChangeScNotify Clone()
		{
			return new ExpeditionDataChangeScNotify(this);
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06003825 RID: 14373 RVA: 0x00099CC4 File Offset: 0x00097EC4
		// (set) Token: 0x06003826 RID: 14374 RVA: 0x00099CCC File Offset: 0x00097ECC
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

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06003827 RID: 14375 RVA: 0x00099CD5 File Offset: 0x00097ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityExpedition> KLMGFFABHCA
		{
			get
			{
				return this.kLMGFFABHCA_;
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06003828 RID: 14376 RVA: 0x00099CDD File Offset: 0x00097EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JLHHCIJPOPD> CLOGAEMKPPM
		{
			get
			{
				return this.cLOGAEMKPPM_;
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x00099CE5 File Offset: 0x00097EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GNJKNMOAEHA
		{
			get
			{
				return this.gNJKNMOAEHA_;
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x0600382A RID: 14378 RVA: 0x00099CED File Offset: 0x00097EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LEOJCIHOGPM
		{
			get
			{
				return this.lEOJCIHOGPM_;
			}
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x00099CF5 File Offset: 0x00097EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpeditionDataChangeScNotify);
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x00099D04 File Offset: 0x00097F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpeditionDataChangeScNotify other)
		{
			return other != null && (other == this || (this.DLHILDEHBMI == other.DLHILDEHBMI && this.kLMGFFABHCA_.Equals(other.kLMGFFABHCA_) && this.cLOGAEMKPPM_.Equals(other.cLOGAEMKPPM_) && this.gNJKNMOAEHA_.Equals(other.gNJKNMOAEHA_) && this.lEOJCIHOGPM_.Equals(other.lEOJCIHOGPM_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00099D94 File Offset: 0x00097F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DLHILDEHBMI != 0U)
			{
				num ^= this.DLHILDEHBMI.GetHashCode();
			}
			num ^= this.kLMGFFABHCA_.GetHashCode();
			num ^= this.cLOGAEMKPPM_.GetHashCode();
			num ^= this.gNJKNMOAEHA_.GetHashCode();
			num ^= this.lEOJCIHOGPM_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00099E0B File Offset: 0x0009800B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00099E13 File Offset: 0x00098013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x00099E1C File Offset: 0x0009801C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kLMGFFABHCA_.WriteTo(ref output, ExpeditionDataChangeScNotify._repeated_kLMGFFABHCA_codec);
			this.lEOJCIHOGPM_.WriteTo(ref output, ExpeditionDataChangeScNotify._repeated_lEOJCIHOGPM_codec);
			if (this.DLHILDEHBMI != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.DLHILDEHBMI);
			}
			this.gNJKNMOAEHA_.WriteTo(ref output, ExpeditionDataChangeScNotify._repeated_gNJKNMOAEHA_codec);
			this.cLOGAEMKPPM_.WriteTo(ref output, ExpeditionDataChangeScNotify._repeated_cLOGAEMKPPM_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x00099EA0 File Offset: 0x000980A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DLHILDEHBMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DLHILDEHBMI);
			}
			num += this.kLMGFFABHCA_.CalculateSize(ExpeditionDataChangeScNotify._repeated_kLMGFFABHCA_codec);
			num += this.cLOGAEMKPPM_.CalculateSize(ExpeditionDataChangeScNotify._repeated_cLOGAEMKPPM_codec);
			num += this.gNJKNMOAEHA_.CalculateSize(ExpeditionDataChangeScNotify._repeated_gNJKNMOAEHA_codec);
			num += this.lEOJCIHOGPM_.CalculateSize(ExpeditionDataChangeScNotify._repeated_lEOJCIHOGPM_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x00099F2C File Offset: 0x0009812C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExpeditionDataChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DLHILDEHBMI != 0U)
			{
				this.DLHILDEHBMI = other.DLHILDEHBMI;
			}
			this.kLMGFFABHCA_.Add(other.kLMGFFABHCA_);
			this.cLOGAEMKPPM_.Add(other.cLOGAEMKPPM_);
			this.gNJKNMOAEHA_.Add(other.gNJKNMOAEHA_);
			this.lEOJCIHOGPM_.Add(other.lEOJCIHOGPM_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x00099FAC File Offset: 0x000981AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x00099FB8 File Offset: 0x000981B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 58U)
				{
					if (num <= 88U)
					{
						if (num == 72U)
						{
							this.DLHILDEHBMI = input.ReadUInt32();
							continue;
						}
						if (num != 88U)
						{
							goto IL_36;
						}
					}
					else if (num != 90U)
					{
						if (num != 122U)
						{
							goto IL_36;
						}
						this.cLOGAEMKPPM_.AddEntriesFrom(ref input, ExpeditionDataChangeScNotify._repeated_cLOGAEMKPPM_codec);
						continue;
					}
					this.gNJKNMOAEHA_.AddEntriesFrom(ref input, ExpeditionDataChangeScNotify._repeated_gNJKNMOAEHA_codec);
					continue;
				}
				if (num == 34U)
				{
					this.kLMGFFABHCA_.AddEntriesFrom(ref input, ExpeditionDataChangeScNotify._repeated_kLMGFFABHCA_codec);
					continue;
				}
				if (num == 56U || num == 58U)
				{
					this.lEOJCIHOGPM_.AddEntriesFrom(ref input, ExpeditionDataChangeScNotify._repeated_lEOJCIHOGPM_codec);
					continue;
				}
				IL_36:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001630 RID: 5680
		private static readonly MessageParser<ExpeditionDataChangeScNotify> _parser = new MessageParser<ExpeditionDataChangeScNotify>(() => new ExpeditionDataChangeScNotify());

		// Token: 0x04001631 RID: 5681
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001632 RID: 5682
		public const int DLHILDEHBMIFieldNumber = 9;

		// Token: 0x04001633 RID: 5683
		private uint dLHILDEHBMI_;

		// Token: 0x04001634 RID: 5684
		public const int KLMGFFABHCAFieldNumber = 4;

		// Token: 0x04001635 RID: 5685
		private static readonly FieldCodec<ActivityExpedition> _repeated_kLMGFFABHCA_codec = FieldCodec.ForMessage<ActivityExpedition>(34U, ActivityExpedition.Parser);

		// Token: 0x04001636 RID: 5686
		private readonly RepeatedField<ActivityExpedition> kLMGFFABHCA_ = new RepeatedField<ActivityExpedition>();

		// Token: 0x04001637 RID: 5687
		public const int CLOGAEMKPPMFieldNumber = 15;

		// Token: 0x04001638 RID: 5688
		private static readonly FieldCodec<JLHHCIJPOPD> _repeated_cLOGAEMKPPM_codec = FieldCodec.ForMessage<JLHHCIJPOPD>(122U, JLHHCIJPOPD.Parser);

		// Token: 0x04001639 RID: 5689
		private readonly RepeatedField<JLHHCIJPOPD> cLOGAEMKPPM_ = new RepeatedField<JLHHCIJPOPD>();

		// Token: 0x0400163A RID: 5690
		public const int GNJKNMOAEHAFieldNumber = 11;

		// Token: 0x0400163B RID: 5691
		private static readonly FieldCodec<uint> _repeated_gNJKNMOAEHA_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x0400163C RID: 5692
		private readonly RepeatedField<uint> gNJKNMOAEHA_ = new RepeatedField<uint>();

		// Token: 0x0400163D RID: 5693
		public const int LEOJCIHOGPMFieldNumber = 7;

		// Token: 0x0400163E RID: 5694
		private static readonly FieldCodec<uint> _repeated_lEOJCIHOGPM_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x0400163F RID: 5695
		private readonly RepeatedField<uint> lEOJCIHOGPM_ = new RepeatedField<uint>();
	}
}
