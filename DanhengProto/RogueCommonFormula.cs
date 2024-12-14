using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E53 RID: 3667
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonFormula : IMessage<RogueCommonFormula>, IMessage, IEquatable<RogueCommonFormula>, IDeepCloneable<RogueCommonFormula>, IBufferMessage
	{
		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x0600A397 RID: 41879 RVA: 0x001B8155 File Offset: 0x001B6355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonFormula> Parser
		{
			get
			{
				return RogueCommonFormula._parser;
			}
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x0600A398 RID: 41880 RVA: 0x001B815C File Offset: 0x001B635C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonFormulaReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x0600A399 RID: 41881 RVA: 0x001B816E File Offset: 0x001B636E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonFormula.Descriptor;
			}
		}

		// Token: 0x0600A39A RID: 41882 RVA: 0x001B8175 File Offset: 0x001B6375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonFormula()
		{
		}

		// Token: 0x0600A39B RID: 41883 RVA: 0x001B817D File Offset: 0x001B637D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonFormula(RogueCommonFormula other) : this()
		{
			this.formulaInfo_ = ((other.formulaInfo_ != null) ? other.formulaInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A39C RID: 41884 RVA: 0x001B81B2 File Offset: 0x001B63B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonFormula Clone()
		{
			return new RogueCommonFormula(this);
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x0600A39D RID: 41885 RVA: 0x001B81BA File Offset: 0x001B63BA
		// (set) Token: 0x0600A39E RID: 41886 RVA: 0x001B81C2 File Offset: 0x001B63C2
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

		// Token: 0x0600A39F RID: 41887 RVA: 0x001B81CB File Offset: 0x001B63CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonFormula);
		}

		// Token: 0x0600A3A0 RID: 41888 RVA: 0x001B81D9 File Offset: 0x001B63D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonFormula other)
		{
			return other != null && (other == this || (object.Equals(this.FormulaInfo, other.FormulaInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3A1 RID: 41889 RVA: 0x001B820C File Offset: 0x001B640C
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

		// Token: 0x0600A3A2 RID: 41890 RVA: 0x001B8248 File Offset: 0x001B6448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x001B8250 File Offset: 0x001B6450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3A4 RID: 41892 RVA: 0x001B8259 File Offset: 0x001B6459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.formulaInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FormulaInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3A5 RID: 41893 RVA: 0x001B828C File Offset: 0x001B648C
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

		// Token: 0x0600A3A6 RID: 41894 RVA: 0x001B82CC File Offset: 0x001B64CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonFormula other)
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

		// Token: 0x0600A3A7 RID: 41895 RVA: 0x001B8320 File Offset: 0x001B6520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x001B832C File Offset: 0x001B652C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
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

		// Token: 0x040042F9 RID: 17145
		private static readonly MessageParser<RogueCommonFormula> _parser = new MessageParser<RogueCommonFormula>(() => new RogueCommonFormula());

		// Token: 0x040042FA RID: 17146
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042FB RID: 17147
		public const int FormulaInfoFieldNumber = 10;

		// Token: 0x040042FC RID: 17148
		private FormulaInfo formulaInfo_;
	}
}
