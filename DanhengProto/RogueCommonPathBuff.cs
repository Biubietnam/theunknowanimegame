using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E5D RID: 3677
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonPathBuff : IMessage<RogueCommonPathBuff>, IMessage, IEquatable<RogueCommonPathBuff>, IDeepCloneable<RogueCommonPathBuff>, IBufferMessage
	{
		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0600A402 RID: 41986 RVA: 0x001B8F61 File Offset: 0x001B7161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonPathBuff> Parser
		{
			get
			{
				return RogueCommonPathBuff._parser;
			}
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x0600A403 RID: 41987 RVA: 0x001B8F68 File Offset: 0x001B7168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonPathBuffReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0600A404 RID: 41988 RVA: 0x001B8F7A File Offset: 0x001B717A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonPathBuff.Descriptor;
			}
		}

		// Token: 0x0600A405 RID: 41989 RVA: 0x001B8F81 File Offset: 0x001B7181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPathBuff()
		{
		}

		// Token: 0x0600A406 RID: 41990 RVA: 0x001B8F89 File Offset: 0x001B7189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPathBuff(RogueCommonPathBuff other) : this()
		{
			this.value_ = ((other.value_ != null) ? other.value_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A407 RID: 41991 RVA: 0x001B8FBE File Offset: 0x001B71BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPathBuff Clone()
		{
			return new RogueCommonPathBuff(this);
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0600A408 RID: 41992 RVA: 0x001B8FC6 File Offset: 0x001B71C6
		// (set) Token: 0x0600A409 RID: 41993 RVA: 0x001B8FCE File Offset: 0x001B71CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaTypeValue Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x0600A40A RID: 41994 RVA: 0x001B8FD7 File Offset: 0x001B71D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonPathBuff);
		}

		// Token: 0x0600A40B RID: 41995 RVA: 0x001B8FE5 File Offset: 0x001B71E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonPathBuff other)
		{
			return other != null && (other == this || (object.Equals(this.Value, other.Value) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x001B9018 File Offset: 0x001B7218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.value_ != null)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A40D RID: 41997 RVA: 0x001B9054 File Offset: 0x001B7254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x001B905C File Offset: 0x001B725C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x001B9065 File Offset: 0x001B7265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.value_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A410 RID: 42000 RVA: 0x001B9098 File Offset: 0x001B7298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.value_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A411 RID: 42001 RVA: 0x001B90D8 File Offset: 0x001B72D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonPathBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.value_ != null)
			{
				if (this.value_ == null)
				{
					this.Value = new FormulaTypeValue();
				}
				this.Value.MergeFrom(other.Value);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x001B912C File Offset: 0x001B732C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x001B9138 File Offset: 0x001B7338
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
					if (this.value_ == null)
					{
						this.Value = new FormulaTypeValue();
					}
					input.ReadMessage(this.Value);
				}
			}
		}

		// Token: 0x04004314 RID: 17172
		private static readonly MessageParser<RogueCommonPathBuff> _parser = new MessageParser<RogueCommonPathBuff>(() => new RogueCommonPathBuff());

		// Token: 0x04004315 RID: 17173
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004316 RID: 17174
		public const int ValueFieldNumber = 10;

		// Token: 0x04004317 RID: 17175
		private FormulaTypeValue value_;
	}
}
