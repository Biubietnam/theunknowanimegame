using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E1F RID: 3615
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBuffReforgeSelectCallback : IMessage<RogueBuffReforgeSelectCallback>, IMessage, IEquatable<RogueBuffReforgeSelectCallback>, IDeepCloneable<RogueBuffReforgeSelectCallback>, IBufferMessage
	{
		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x0600A170 RID: 41328 RVA: 0x001B0C23 File Offset: 0x001AEE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBuffReforgeSelectCallback> Parser
		{
			get
			{
				return RogueBuffReforgeSelectCallback._parser;
			}
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x0600A171 RID: 41329 RVA: 0x001B0C2A File Offset: 0x001AEE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBuffReforgeSelectCallbackReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x0600A172 RID: 41330 RVA: 0x001B0C3C File Offset: 0x001AEE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBuffReforgeSelectCallback.Descriptor;
			}
		}

		// Token: 0x0600A173 RID: 41331 RVA: 0x001B0C43 File Offset: 0x001AEE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffReforgeSelectCallback()
		{
		}

		// Token: 0x0600A174 RID: 41332 RVA: 0x001B0C4B File Offset: 0x001AEE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffReforgeSelectCallback(RogueBuffReforgeSelectCallback other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x001B0C64 File Offset: 0x001AEE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffReforgeSelectCallback Clone()
		{
			return new RogueBuffReforgeSelectCallback(this);
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x001B0C6C File Offset: 0x001AEE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBuffReforgeSelectCallback);
		}

		// Token: 0x0600A177 RID: 41335 RVA: 0x001B0C7A File Offset: 0x001AEE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBuffReforgeSelectCallback other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A178 RID: 41336 RVA: 0x001B0C98 File Offset: 0x001AEE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x001B0CBE File Offset: 0x001AEEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A17A RID: 41338 RVA: 0x001B0CC6 File Offset: 0x001AEEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A17B RID: 41339 RVA: 0x001B0CCF File Offset: 0x001AEECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A17C RID: 41340 RVA: 0x001B0CE8 File Offset: 0x001AEEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x001B0D0E File Offset: 0x001AEF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBuffReforgeSelectCallback other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A17E RID: 41342 RVA: 0x001B0D2B File Offset: 0x001AEF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A17F RID: 41343 RVA: 0x001B0D34 File Offset: 0x001AEF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004212 RID: 16914
		private static readonly MessageParser<RogueBuffReforgeSelectCallback> _parser = new MessageParser<RogueBuffReforgeSelectCallback>(() => new RogueBuffReforgeSelectCallback());

		// Token: 0x04004213 RID: 16915
		private UnknownFieldSet _unknownFields;
	}
}
