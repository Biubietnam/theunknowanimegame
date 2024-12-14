using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E63 RID: 3683
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonRemoveKeyword : IMessage<RogueCommonRemoveKeyword>, IMessage, IEquatable<RogueCommonRemoveKeyword>, IDeepCloneable<RogueCommonRemoveKeyword>, IBufferMessage
	{
		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x0600A443 RID: 42051 RVA: 0x001B9874 File Offset: 0x001B7A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonRemoveKeyword> Parser
		{
			get
			{
				return RogueCommonRemoveKeyword._parser;
			}
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x0600A444 RID: 42052 RVA: 0x001B987B File Offset: 0x001B7A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonRemoveKeywordReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x0600A445 RID: 42053 RVA: 0x001B988D File Offset: 0x001B7A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonRemoveKeyword.Descriptor;
			}
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x001B9894 File Offset: 0x001B7A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveKeyword()
		{
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x001B989C File Offset: 0x001B7A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveKeyword(RogueCommonRemoveKeyword other) : this()
		{
			this.keywordId_ = other.keywordId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x001B98C1 File Offset: 0x001B7AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveKeyword Clone()
		{
			return new RogueCommonRemoveKeyword(this);
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x0600A449 RID: 42057 RVA: 0x001B98C9 File Offset: 0x001B7AC9
		// (set) Token: 0x0600A44A RID: 42058 RVA: 0x001B98D1 File Offset: 0x001B7AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KeywordId
		{
			get
			{
				return this.keywordId_;
			}
			set
			{
				this.keywordId_ = value;
			}
		}

		// Token: 0x0600A44B RID: 42059 RVA: 0x001B98DA File Offset: 0x001B7ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonRemoveKeyword);
		}

		// Token: 0x0600A44C RID: 42060 RVA: 0x001B98E8 File Offset: 0x001B7AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonRemoveKeyword other)
		{
			return other != null && (other == this || (this.KeywordId == other.KeywordId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x001B9918 File Offset: 0x001B7B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KeywordId != 0U)
			{
				num ^= this.KeywordId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x001B9957 File Offset: 0x001B7B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x001B995F File Offset: 0x001B7B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x001B9968 File Offset: 0x001B7B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KeywordId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.KeywordId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x001B999C File Offset: 0x001B7B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KeywordId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KeywordId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x001B99DA File Offset: 0x001B7BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonRemoveKeyword other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KeywordId != 0U)
			{
				this.KeywordId = other.KeywordId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x001B9A0B File Offset: 0x001B7C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x001B9A14 File Offset: 0x001B7C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.KeywordId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004325 RID: 17189
		private static readonly MessageParser<RogueCommonRemoveKeyword> _parser = new MessageParser<RogueCommonRemoveKeyword>(() => new RogueCommonRemoveKeyword());

		// Token: 0x04004326 RID: 17190
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004327 RID: 17191
		public const int KeywordIdFieldNumber = 7;

		// Token: 0x04004328 RID: 17192
		private uint keywordId_;
	}
}
