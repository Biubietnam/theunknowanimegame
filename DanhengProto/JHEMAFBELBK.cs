using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000965 RID: 2405
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JHEMAFBELBK : IMessage<JHEMAFBELBK>, IMessage, IEquatable<JHEMAFBELBK>, IDeepCloneable<JHEMAFBELBK>, IBufferMessage
	{
		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06006B69 RID: 27497 RVA: 0x0011E72E File Offset: 0x0011C92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JHEMAFBELBK> Parser
		{
			get
			{
				return JHEMAFBELBK._parser;
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06006B6A RID: 27498 RVA: 0x0011E735 File Offset: 0x0011C935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JHEMAFBELBKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06006B6B RID: 27499 RVA: 0x0011E747 File Offset: 0x0011C947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JHEMAFBELBK.Descriptor;
			}
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x0011E74E File Offset: 0x0011C94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHEMAFBELBK()
		{
		}

		// Token: 0x06006B6D RID: 27501 RVA: 0x0011E756 File Offset: 0x0011C956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHEMAFBELBK(JHEMAFBELBK other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B6E RID: 27502 RVA: 0x0011E76F File Offset: 0x0011C96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHEMAFBELBK Clone()
		{
			return new JHEMAFBELBK(this);
		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x0011E777 File Offset: 0x0011C977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JHEMAFBELBK);
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x0011E785 File Offset: 0x0011C985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JHEMAFBELBK other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x0011E7A4 File Offset: 0x0011C9A4
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

		// Token: 0x06006B72 RID: 27506 RVA: 0x0011E7CA File Offset: 0x0011C9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x0011E7D2 File Offset: 0x0011C9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x0011E7DB File Offset: 0x0011C9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x0011E7F4 File Offset: 0x0011C9F4
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

		// Token: 0x06006B76 RID: 27510 RVA: 0x0011E81A File Offset: 0x0011CA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JHEMAFBELBK other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x0011E837 File Offset: 0x0011CA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x0011E840 File Offset: 0x0011CA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002921 RID: 10529
		private static readonly MessageParser<JHEMAFBELBK> _parser = new MessageParser<JHEMAFBELBK>(() => new JHEMAFBELBK());

		// Token: 0x04002922 RID: 10530
		private UnknownFieldSet _unknownFields;
	}
}
