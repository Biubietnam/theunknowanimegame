using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000859 RID: 2137
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GGFPEEMILPL : IMessage<GGFPEEMILPL>, IMessage, IEquatable<GGFPEEMILPL>, IDeepCloneable<GGFPEEMILPL>, IBufferMessage
	{
		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06005F08 RID: 24328 RVA: 0x000FB7E7 File Offset: 0x000F99E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GGFPEEMILPL> Parser
		{
			get
			{
				return GGFPEEMILPL._parser;
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06005F09 RID: 24329 RVA: 0x000FB7EE File Offset: 0x000F99EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GGFPEEMILPLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06005F0A RID: 24330 RVA: 0x000FB800 File Offset: 0x000F9A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GGFPEEMILPL.Descriptor;
			}
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x000FB807 File Offset: 0x000F9A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GGFPEEMILPL()
		{
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x000FB81C File Offset: 0x000F9A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GGFPEEMILPL(GGFPEEMILPL other) : this()
		{
			this.eKIGFGDLMPE_ = ((other.eKIGFGDLMPE_ != null) ? other.eKIGFGDLMPE_.Clone() : null);
			this.lDMCMAKIMBP_ = other.lDMCMAKIMBP_.Clone();
			this.nBFEDKIOOOH_ = ((other.nBFEDKIOOOH_ != null) ? other.nBFEDKIOOOH_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x000FB889 File Offset: 0x000F9A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GGFPEEMILPL Clone()
		{
			return new GGFPEEMILPL(this);
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06005F0E RID: 24334 RVA: 0x000FB891 File Offset: 0x000F9A91
		// (set) Token: 0x06005F0F RID: 24335 RVA: 0x000FB899 File Offset: 0x000F9A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GJNPFNDEHGL EKIGFGDLMPE
		{
			get
			{
				return this.eKIGFGDLMPE_;
			}
			set
			{
				this.eKIGFGDLMPE_ = value;
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06005F10 RID: 24336 RVA: 0x000FB8A2 File Offset: 0x000F9AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FIPNNGPAFCA> LDMCMAKIMBP
		{
			get
			{
				return this.lDMCMAKIMBP_;
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06005F11 RID: 24337 RVA: 0x000FB8AA File Offset: 0x000F9AAA
		// (set) Token: 0x06005F12 RID: 24338 RVA: 0x000FB8B2 File Offset: 0x000F9AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPNNGPAFCA NBFEDKIOOOH
		{
			get
			{
				return this.nBFEDKIOOOH_;
			}
			set
			{
				this.nBFEDKIOOOH_ = value;
			}
		}

		// Token: 0x06005F13 RID: 24339 RVA: 0x000FB8BB File Offset: 0x000F9ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GGFPEEMILPL);
		}

		// Token: 0x06005F14 RID: 24340 RVA: 0x000FB8CC File Offset: 0x000F9ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GGFPEEMILPL other)
		{
			return other != null && (other == this || (object.Equals(this.EKIGFGDLMPE, other.EKIGFGDLMPE) && this.lDMCMAKIMBP_.Equals(other.lDMCMAKIMBP_) && object.Equals(this.NBFEDKIOOOH, other.NBFEDKIOOOH) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x000FB934 File Offset: 0x000F9B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.eKIGFGDLMPE_ != null)
			{
				num ^= this.EKIGFGDLMPE.GetHashCode();
			}
			num ^= this.lDMCMAKIMBP_.GetHashCode();
			if (this.nBFEDKIOOOH_ != null)
			{
				num ^= this.NBFEDKIOOOH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x000FB994 File Offset: 0x000F9B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x000FB99C File Offset: 0x000F9B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x000FB9A8 File Offset: 0x000F9BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nBFEDKIOOOH_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NBFEDKIOOOH);
			}
			this.lDMCMAKIMBP_.WriteTo(ref output, GGFPEEMILPL._repeated_lDMCMAKIMBP_codec);
			if (this.eKIGFGDLMPE_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.EKIGFGDLMPE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F19 RID: 24345 RVA: 0x000FBA14 File Offset: 0x000F9C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.eKIGFGDLMPE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EKIGFGDLMPE);
			}
			num += this.lDMCMAKIMBP_.CalculateSize(GGFPEEMILPL._repeated_lDMCMAKIMBP_codec);
			if (this.nBFEDKIOOOH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NBFEDKIOOOH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x000FBA80 File Offset: 0x000F9C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GGFPEEMILPL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.eKIGFGDLMPE_ != null)
			{
				if (this.eKIGFGDLMPE_ == null)
				{
					this.EKIGFGDLMPE = new GJNPFNDEHGL();
				}
				this.EKIGFGDLMPE.MergeFrom(other.EKIGFGDLMPE);
			}
			this.lDMCMAKIMBP_.Add(other.lDMCMAKIMBP_);
			if (other.nBFEDKIOOOH_ != null)
			{
				if (this.nBFEDKIOOOH_ == null)
				{
					this.NBFEDKIOOOH = new FIPNNGPAFCA();
				}
				this.NBFEDKIOOOH.MergeFrom(other.NBFEDKIOOOH);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x000FBB11 File Offset: 0x000F9D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x000FBB1C File Offset: 0x000F9D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 66U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.eKIGFGDLMPE_ == null)
							{
								this.EKIGFGDLMPE = new GJNPFNDEHGL();
							}
							input.ReadMessage(this.EKIGFGDLMPE);
						}
					}
					else
					{
						this.lDMCMAKIMBP_.AddEntriesFrom(ref input, GGFPEEMILPL._repeated_lDMCMAKIMBP_codec);
					}
				}
				else
				{
					if (this.nBFEDKIOOOH_ == null)
					{
						this.NBFEDKIOOOH = new FIPNNGPAFCA();
					}
					input.ReadMessage(this.NBFEDKIOOOH);
				}
			}
		}

		// Token: 0x04002493 RID: 9363
		private static readonly MessageParser<GGFPEEMILPL> _parser = new MessageParser<GGFPEEMILPL>(() => new GGFPEEMILPL());

		// Token: 0x04002494 RID: 9364
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002495 RID: 9365
		public const int EKIGFGDLMPEFieldNumber = 13;

		// Token: 0x04002496 RID: 9366
		private GJNPFNDEHGL eKIGFGDLMPE_;

		// Token: 0x04002497 RID: 9367
		public const int LDMCMAKIMBPFieldNumber = 8;

		// Token: 0x04002498 RID: 9368
		private static readonly FieldCodec<FIPNNGPAFCA> _repeated_lDMCMAKIMBP_codec = FieldCodec.ForMessage<FIPNNGPAFCA>(66U, FIPNNGPAFCA.Parser);

		// Token: 0x04002499 RID: 9369
		private readonly RepeatedField<FIPNNGPAFCA> lDMCMAKIMBP_ = new RepeatedField<FIPNNGPAFCA>();

		// Token: 0x0400249A RID: 9370
		public const int NBFEDKIOOOHFieldNumber = 1;

		// Token: 0x0400249B RID: 9371
		private FIPNNGPAFCA nBFEDKIOOOH_;
	}
}
