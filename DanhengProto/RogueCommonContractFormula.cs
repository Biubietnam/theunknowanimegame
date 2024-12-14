using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E3F RID: 3647
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonContractFormula : IMessage<RogueCommonContractFormula>, IMessage, IEquatable<RogueCommonContractFormula>, IDeepCloneable<RogueCommonContractFormula>, IBufferMessage
	{
		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x0600A2A9 RID: 41641 RVA: 0x001B5901 File Offset: 0x001B3B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonContractFormula> Parser
		{
			get
			{
				return RogueCommonContractFormula._parser;
			}
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x0600A2AA RID: 41642 RVA: 0x001B5908 File Offset: 0x001B3B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonContractFormulaReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x0600A2AB RID: 41643 RVA: 0x001B591A File Offset: 0x001B3B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonContractFormula.Descriptor;
			}
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x001B5921 File Offset: 0x001B3B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonContractFormula()
		{
		}

		// Token: 0x0600A2AD RID: 41645 RVA: 0x001B5929 File Offset: 0x001B3B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonContractFormula(RogueCommonContractFormula other) : this()
		{
			this.formulaInfo_ = ((other.formulaInfo_ != null) ? other.formulaInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2AE RID: 41646 RVA: 0x001B595E File Offset: 0x001B3B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonContractFormula Clone()
		{
			return new RogueCommonContractFormula(this);
		}

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x0600A2AF RID: 41647 RVA: 0x001B5966 File Offset: 0x001B3B66
		// (set) Token: 0x0600A2B0 RID: 41648 RVA: 0x001B596E File Offset: 0x001B3B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaInfo FormulaInfo
		{
			get
			{
				return this.formulaInfo_;
			}
			set
			{
				this.formulaInfo_ = value;
			}
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x001B5977 File Offset: 0x001B3B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonContractFormula);
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x001B5985 File Offset: 0x001B3B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonContractFormula other)
		{
			return other != null && (other == this || (object.Equals(this.FormulaInfo, other.FormulaInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x001B59B8 File Offset: 0x001B3BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.formulaInfo_ != null)
			{
				num ^= this.FormulaInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x001B59F4 File Offset: 0x001B3BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x001B59FC File Offset: 0x001B3BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x001B5A05 File Offset: 0x001B3C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.formulaInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.FormulaInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x001B5A38 File Offset: 0x001B3C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.formulaInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FormulaInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x001B5A78 File Offset: 0x001B3C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonContractFormula other)
		{
			if (other == null)
			{
				return;
			}
			if (other.formulaInfo_ != null)
			{
				if (this.formulaInfo_ == null)
				{
					this.FormulaInfo = new FormulaInfo();
				}
				this.FormulaInfo.MergeFrom(other.FormulaInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2B9 RID: 41657 RVA: 0x001B5ACC File Offset: 0x001B3CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x001B5AD8 File Offset: 0x001B3CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.formulaInfo_ == null)
					{
						this.FormulaInfo = new FormulaInfo();
					}
					input.ReadMessage(this.FormulaInfo);
				}
			}
		}

		// Token: 0x040042A7 RID: 17063
		private static readonly MessageParser<RogueCommonContractFormula> _parser = new MessageParser<RogueCommonContractFormula>(() => new RogueCommonContractFormula());

		// Token: 0x040042A8 RID: 17064
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042A9 RID: 17065
		public const int FormulaInfoFieldNumber = 4;

		// Token: 0x040042AA RID: 17066
		private FormulaInfo formulaInfo_;
	}
}
