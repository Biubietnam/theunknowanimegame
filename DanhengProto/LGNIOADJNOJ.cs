using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A0D RID: 2573
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LGNIOADJNOJ : IMessage<LGNIOADJNOJ>, IMessage, IEquatable<LGNIOADJNOJ>, IDeepCloneable<LGNIOADJNOJ>, IBufferMessage
	{
		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x0600722F RID: 29231 RVA: 0x0012FAD1 File Offset: 0x0012DCD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LGNIOADJNOJ> Parser
		{
			get
			{
				return LGNIOADJNOJ._parser;
			}
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06007230 RID: 29232 RVA: 0x0012FAD8 File Offset: 0x0012DCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LGNIOADJNOJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06007231 RID: 29233 RVA: 0x0012FAEA File Offset: 0x0012DCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LGNIOADJNOJ.Descriptor;
			}
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x0012FAF1 File Offset: 0x0012DCF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LGNIOADJNOJ()
		{
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x0012FB04 File Offset: 0x0012DD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LGNIOADJNOJ(LGNIOADJNOJ other) : this()
		{
			this.oHFINJLMILI_ = other.oHFINJLMILI_;
			this.oPMEPODLIDL_ = other.oPMEPODLIDL_;
			this.mDFPMNGJNHB_ = other.mDFPMNGJNHB_;
			this.aLCCELPMEDB_ = other.aLCCELPMEDB_.Clone();
			this.kJCKBJDKMAJ_ = other.kJCKBJDKMAJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x0012FB69 File Offset: 0x0012DD69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LGNIOADJNOJ Clone()
		{
			return new LGNIOADJNOJ(this);
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06007235 RID: 29237 RVA: 0x0012FB71 File Offset: 0x0012DD71
		// (set) Token: 0x06007236 RID: 29238 RVA: 0x0012FB79 File Offset: 0x0012DD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OHFINJLMILI
		{
			get
			{
				return this.oHFINJLMILI_;
			}
			set
			{
				this.oHFINJLMILI_ = value;
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06007237 RID: 29239 RVA: 0x0012FB82 File Offset: 0x0012DD82
		// (set) Token: 0x06007238 RID: 29240 RVA: 0x0012FB8A File Offset: 0x0012DD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OPMEPODLIDL
		{
			get
			{
				return this.oPMEPODLIDL_;
			}
			set
			{
				this.oPMEPODLIDL_ = value;
			}
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06007239 RID: 29241 RVA: 0x0012FB93 File Offset: 0x0012DD93
		// (set) Token: 0x0600723A RID: 29242 RVA: 0x0012FB9B File Offset: 0x0012DD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MDFPMNGJNHB
		{
			get
			{
				return this.mDFPMNGJNHB_;
			}
			set
			{
				this.mDFPMNGJNHB_ = value;
			}
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x0600723B RID: 29243 RVA: 0x0012FBA4 File Offset: 0x0012DDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ALCCELPMEDB
		{
			get
			{
				return this.aLCCELPMEDB_;
			}
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x0600723C RID: 29244 RVA: 0x0012FBAC File Offset: 0x0012DDAC
		// (set) Token: 0x0600723D RID: 29245 RVA: 0x0012FBB4 File Offset: 0x0012DDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KJCKBJDKMAJ
		{
			get
			{
				return this.kJCKBJDKMAJ_;
			}
			set
			{
				this.kJCKBJDKMAJ_ = value;
			}
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x0012FBBD File Offset: 0x0012DDBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LGNIOADJNOJ);
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x0012FBCC File Offset: 0x0012DDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LGNIOADJNOJ other)
		{
			return other != null && (other == this || (this.OHFINJLMILI == other.OHFINJLMILI && this.OPMEPODLIDL == other.OPMEPODLIDL && this.MDFPMNGJNHB == other.MDFPMNGJNHB && this.aLCCELPMEDB_.Equals(other.aLCCELPMEDB_) && this.KJCKBJDKMAJ == other.KJCKBJDKMAJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x0012FC4C File Offset: 0x0012DE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OHFINJLMILI != 0U)
			{
				num ^= this.OHFINJLMILI.GetHashCode();
			}
			if (this.OPMEPODLIDL != 0U)
			{
				num ^= this.OPMEPODLIDL.GetHashCode();
			}
			if (this.MDFPMNGJNHB != 0U)
			{
				num ^= this.MDFPMNGJNHB.GetHashCode();
			}
			num ^= this.aLCCELPMEDB_.GetHashCode();
			if (this.KJCKBJDKMAJ != 0U)
			{
				num ^= this.KJCKBJDKMAJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x0012FCE4 File Offset: 0x0012DEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x0012FCEC File Offset: 0x0012DEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x0012FCF8 File Offset: 0x0012DEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OHFINJLMILI != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.OHFINJLMILI);
			}
			if (this.KJCKBJDKMAJ != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.KJCKBJDKMAJ);
			}
			if (this.OPMEPODLIDL != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.OPMEPODLIDL);
			}
			if (this.MDFPMNGJNHB != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.MDFPMNGJNHB);
			}
			this.aLCCELPMEDB_.WriteTo(ref output, LGNIOADJNOJ._repeated_aLCCELPMEDB_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x0012FD9C File Offset: 0x0012DF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OHFINJLMILI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OHFINJLMILI);
			}
			if (this.OPMEPODLIDL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OPMEPODLIDL);
			}
			if (this.MDFPMNGJNHB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MDFPMNGJNHB);
			}
			num += this.aLCCELPMEDB_.CalculateSize(LGNIOADJNOJ._repeated_aLCCELPMEDB_codec);
			if (this.KJCKBJDKMAJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KJCKBJDKMAJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x0012FE38 File Offset: 0x0012E038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LGNIOADJNOJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OHFINJLMILI != 0U)
			{
				this.OHFINJLMILI = other.OHFINJLMILI;
			}
			if (other.OPMEPODLIDL != 0U)
			{
				this.OPMEPODLIDL = other.OPMEPODLIDL;
			}
			if (other.MDFPMNGJNHB != 0U)
			{
				this.MDFPMNGJNHB = other.MDFPMNGJNHB;
			}
			this.aLCCELPMEDB_.Add(other.aLCCELPMEDB_);
			if (other.KJCKBJDKMAJ != 0U)
			{
				this.KJCKBJDKMAJ = other.KJCKBJDKMAJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x0012FEC1 File Offset: 0x0012E0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x0012FECC File Offset: 0x0012E0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 24U)
					{
						this.OHFINJLMILI = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.KJCKBJDKMAJ = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.OPMEPODLIDL = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.MDFPMNGJNHB = input.ReadUInt32();
						continue;
					}
					if (num == 96U || num == 98U)
					{
						this.aLCCELPMEDB_.AddEntriesFrom(ref input, LGNIOADJNOJ._repeated_aLCCELPMEDB_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002BDC RID: 11228
		private static readonly MessageParser<LGNIOADJNOJ> _parser = new MessageParser<LGNIOADJNOJ>(() => new LGNIOADJNOJ());

		// Token: 0x04002BDD RID: 11229
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BDE RID: 11230
		public const int OHFINJLMILIFieldNumber = 3;

		// Token: 0x04002BDF RID: 11231
		private uint oHFINJLMILI_;

		// Token: 0x04002BE0 RID: 11232
		public const int OPMEPODLIDLFieldNumber = 9;

		// Token: 0x04002BE1 RID: 11233
		private uint oPMEPODLIDL_;

		// Token: 0x04002BE2 RID: 11234
		public const int MDFPMNGJNHBFieldNumber = 11;

		// Token: 0x04002BE3 RID: 11235
		private uint mDFPMNGJNHB_;

		// Token: 0x04002BE4 RID: 11236
		public const int ALCCELPMEDBFieldNumber = 12;

		// Token: 0x04002BE5 RID: 11237
		private static readonly FieldCodec<uint> _repeated_aLCCELPMEDB_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04002BE6 RID: 11238
		private readonly RepeatedField<uint> aLCCELPMEDB_ = new RepeatedField<uint>();

		// Token: 0x04002BE7 RID: 11239
		public const int KJCKBJDKMAJFieldNumber = 6;

		// Token: 0x04002BE8 RID: 11240
		private uint kJCKBJDKMAJ_;
	}
}
