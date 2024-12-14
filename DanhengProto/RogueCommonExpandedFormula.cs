using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E51 RID: 3665
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonExpandedFormula : IMessage<RogueCommonExpandedFormula>, IMessage, IEquatable<RogueCommonExpandedFormula>, IDeepCloneable<RogueCommonExpandedFormula>, IBufferMessage
	{
		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x0600A382 RID: 41858 RVA: 0x001B7E91 File Offset: 0x001B6091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonExpandedFormula> Parser
		{
			get
			{
				return RogueCommonExpandedFormula._parser;
			}
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x0600A383 RID: 41859 RVA: 0x001B7E98 File Offset: 0x001B6098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonExpandedFormulaReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x0600A384 RID: 41860 RVA: 0x001B7EAA File Offset: 0x001B60AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonExpandedFormula.Descriptor;
			}
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x001B7EB1 File Offset: 0x001B60B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonExpandedFormula()
		{
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x001B7EB9 File Offset: 0x001B60B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonExpandedFormula(RogueCommonExpandedFormula other) : this()
		{
			this.formulaInfo_ = ((other.formulaInfo_ != null) ? other.formulaInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x001B7EEE File Offset: 0x001B60EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonExpandedFormula Clone()
		{
			return new RogueCommonExpandedFormula(this);
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x0600A388 RID: 41864 RVA: 0x001B7EF6 File Offset: 0x001B60F6
		// (set) Token: 0x0600A389 RID: 41865 RVA: 0x001B7EFE File Offset: 0x001B60FE
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

		// Token: 0x0600A38A RID: 41866 RVA: 0x001B7F07 File Offset: 0x001B6107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonExpandedFormula);
		}

		// Token: 0x0600A38B RID: 41867 RVA: 0x001B7F15 File Offset: 0x001B6115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonExpandedFormula other)
		{
			return other != null && (other == this || (object.Equals(this.FormulaInfo, other.FormulaInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A38C RID: 41868 RVA: 0x001B7F48 File Offset: 0x001B6148
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

		// Token: 0x0600A38D RID: 41869 RVA: 0x001B7F84 File Offset: 0x001B6184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A38E RID: 41870 RVA: 0x001B7F8C File Offset: 0x001B618C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A38F RID: 41871 RVA: 0x001B7F95 File Offset: 0x001B6195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.formulaInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.FormulaInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A390 RID: 41872 RVA: 0x001B7FC8 File Offset: 0x001B61C8
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

		// Token: 0x0600A391 RID: 41873 RVA: 0x001B8008 File Offset: 0x001B6208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonExpandedFormula other)
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

		// Token: 0x0600A392 RID: 41874 RVA: 0x001B805C File Offset: 0x001B625C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A393 RID: 41875 RVA: 0x001B8068 File Offset: 0x001B6268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
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

		// Token: 0x040042F4 RID: 17140
		private static readonly MessageParser<RogueCommonExpandedFormula> _parser = new MessageParser<RogueCommonExpandedFormula>(() => new RogueCommonExpandedFormula());

		// Token: 0x040042F5 RID: 17141
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042F6 RID: 17142
		public const int FormulaInfoFieldNumber = 3;

		// Token: 0x040042F7 RID: 17143
		private FormulaInfo formulaInfo_;
	}
}
