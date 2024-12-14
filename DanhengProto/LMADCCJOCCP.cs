using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A21 RID: 2593
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LMADCCJOCCP : IMessage<LMADCCJOCCP>, IMessage, IEquatable<LMADCCJOCCP>, IDeepCloneable<LMADCCJOCCP>, IBufferMessage
	{
		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06007340 RID: 29504 RVA: 0x00132EAA File Offset: 0x001310AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LMADCCJOCCP> Parser
		{
			get
			{
				return LMADCCJOCCP._parser;
			}
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x06007341 RID: 29505 RVA: 0x00132EB1 File Offset: 0x001310B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LMADCCJOCCPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x06007342 RID: 29506 RVA: 0x00132EC3 File Offset: 0x001310C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LMADCCJOCCP.Descriptor;
			}
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x00132ECA File Offset: 0x001310CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMADCCJOCCP()
		{
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x00132ED2 File Offset: 0x001310D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMADCCJOCCP(LMADCCJOCCP other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x00132EEB File Offset: 0x001310EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMADCCJOCCP Clone()
		{
			return new LMADCCJOCCP(this);
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x00132EF3 File Offset: 0x001310F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LMADCCJOCCP);
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x00132F01 File Offset: 0x00131101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LMADCCJOCCP other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x00132F20 File Offset: 0x00131120
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

		// Token: 0x06007349 RID: 29513 RVA: 0x00132F46 File Offset: 0x00131146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x00132F4E File Offset: 0x0013114E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x00132F57 File Offset: 0x00131157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x00132F70 File Offset: 0x00131170
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

		// Token: 0x0600734D RID: 29517 RVA: 0x00132F96 File Offset: 0x00131196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LMADCCJOCCP other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x00132FB3 File Offset: 0x001311B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x00132FBC File Offset: 0x001311BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C5F RID: 11359
		private static readonly MessageParser<LMADCCJOCCP> _parser = new MessageParser<LMADCCJOCCP>(() => new LMADCCJOCCP());

		// Token: 0x04002C60 RID: 11360
		private UnknownFieldSet _unknownFields;
	}
}
