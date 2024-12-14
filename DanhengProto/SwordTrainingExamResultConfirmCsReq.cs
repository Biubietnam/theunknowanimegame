using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001229 RID: 4649
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingExamResultConfirmCsReq : IMessage<SwordTrainingExamResultConfirmCsReq>, IMessage, IEquatable<SwordTrainingExamResultConfirmCsReq>, IDeepCloneable<SwordTrainingExamResultConfirmCsReq>, IBufferMessage
	{
		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x0600CFB0 RID: 53168 RVA: 0x0022C833 File Offset: 0x0022AA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingExamResultConfirmCsReq> Parser
		{
			get
			{
				return SwordTrainingExamResultConfirmCsReq._parser;
			}
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x0600CFB1 RID: 53169 RVA: 0x0022C83A File Offset: 0x0022AA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingExamResultConfirmCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x0600CFB2 RID: 53170 RVA: 0x0022C84C File Offset: 0x0022AA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingExamResultConfirmCsReq.Descriptor;
			}
		}

		// Token: 0x0600CFB3 RID: 53171 RVA: 0x0022C853 File Offset: 0x0022AA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingExamResultConfirmCsReq()
		{
		}

		// Token: 0x0600CFB4 RID: 53172 RVA: 0x0022C85B File Offset: 0x0022AA5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingExamResultConfirmCsReq(SwordTrainingExamResultConfirmCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFB5 RID: 53173 RVA: 0x0022C874 File Offset: 0x0022AA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingExamResultConfirmCsReq Clone()
		{
			return new SwordTrainingExamResultConfirmCsReq(this);
		}

		// Token: 0x0600CFB6 RID: 53174 RVA: 0x0022C87C File Offset: 0x0022AA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingExamResultConfirmCsReq);
		}

		// Token: 0x0600CFB7 RID: 53175 RVA: 0x0022C88A File Offset: 0x0022AA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingExamResultConfirmCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600CFB8 RID: 53176 RVA: 0x0022C8A8 File Offset: 0x0022AAA8
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

		// Token: 0x0600CFB9 RID: 53177 RVA: 0x0022C8CE File Offset: 0x0022AACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CFBA RID: 53178 RVA: 0x0022C8D6 File Offset: 0x0022AAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFBB RID: 53179 RVA: 0x0022C8DF File Offset: 0x0022AADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFBC RID: 53180 RVA: 0x0022C8F8 File Offset: 0x0022AAF8
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

		// Token: 0x0600CFBD RID: 53181 RVA: 0x0022C91E File Offset: 0x0022AB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingExamResultConfirmCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CFBE RID: 53182 RVA: 0x0022C93B File Offset: 0x0022AB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFBF RID: 53183 RVA: 0x0022C944 File Offset: 0x0022AB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400538D RID: 21389
		private static readonly MessageParser<SwordTrainingExamResultConfirmCsReq> _parser = new MessageParser<SwordTrainingExamResultConfirmCsReq>(() => new SwordTrainingExamResultConfirmCsReq());

		// Token: 0x0400538E RID: 21390
		private UnknownFieldSet _unknownFields;
	}
}
