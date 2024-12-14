using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E61 RID: 3681
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonRemoveFormula : IMessage<RogueCommonRemoveFormula>, IMessage, IEquatable<RogueCommonRemoveFormula>, IDeepCloneable<RogueCommonRemoveFormula>, IBufferMessage
	{
		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x0600A42E RID: 42030 RVA: 0x001B95BD File Offset: 0x001B77BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonRemoveFormula> Parser
		{
			get
			{
				return RogueCommonRemoveFormula._parser;
			}
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x0600A42F RID: 42031 RVA: 0x001B95C4 File Offset: 0x001B77C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonRemoveFormulaReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x0600A430 RID: 42032 RVA: 0x001B95D6 File Offset: 0x001B77D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonRemoveFormula.Descriptor;
			}
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x001B95DD File Offset: 0x001B77DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveFormula()
		{
		}

		// Token: 0x0600A432 RID: 42034 RVA: 0x001B95E5 File Offset: 0x001B77E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveFormula(RogueCommonRemoveFormula other) : this()
		{
			this.formulaInfo_ = ((other.formulaInfo_ != null) ? other.formulaInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x001B961A File Offset: 0x001B781A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveFormula Clone()
		{
			return new RogueCommonRemoveFormula(this);
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x0600A434 RID: 42036 RVA: 0x001B9622 File Offset: 0x001B7822
		// (set) Token: 0x0600A435 RID: 42037 RVA: 0x001B962A File Offset: 0x001B782A
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

		// Token: 0x0600A436 RID: 42038 RVA: 0x001B9633 File Offset: 0x001B7833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonRemoveFormula);
		}

		// Token: 0x0600A437 RID: 42039 RVA: 0x001B9641 File Offset: 0x001B7841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonRemoveFormula other)
		{
			return other != null && (other == this || (object.Equals(this.FormulaInfo, other.FormulaInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A438 RID: 42040 RVA: 0x001B9674 File Offset: 0x001B7874
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

		// Token: 0x0600A439 RID: 42041 RVA: 0x001B96B0 File Offset: 0x001B78B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A43A RID: 42042 RVA: 0x001B96B8 File Offset: 0x001B78B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x001B96C1 File Offset: 0x001B78C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.formulaInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.FormulaInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A43C RID: 42044 RVA: 0x001B96F4 File Offset: 0x001B78F4
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

		// Token: 0x0600A43D RID: 42045 RVA: 0x001B9734 File Offset: 0x001B7934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonRemoveFormula other)
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

		// Token: 0x0600A43E RID: 42046 RVA: 0x001B9788 File Offset: 0x001B7988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x001B9794 File Offset: 0x001B7994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
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

		// Token: 0x04004320 RID: 17184
		private static readonly MessageParser<RogueCommonRemoveFormula> _parser = new MessageParser<RogueCommonRemoveFormula>(() => new RogueCommonRemoveFormula());

		// Token: 0x04004321 RID: 17185
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004322 RID: 17186
		public const int FormulaInfoFieldNumber = 6;

		// Token: 0x04004323 RID: 17187
		private FormulaInfo formulaInfo_;
	}
}
