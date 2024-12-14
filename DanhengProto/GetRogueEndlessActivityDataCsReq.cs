using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007B5 RID: 1973
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueEndlessActivityDataCsReq : IMessage<GetRogueEndlessActivityDataCsReq>, IMessage, IEquatable<GetRogueEndlessActivityDataCsReq>, IDeepCloneable<GetRogueEndlessActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x0600580B RID: 22539 RVA: 0x000EB7F7 File Offset: 0x000E99F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueEndlessActivityDataCsReq> Parser
		{
			get
			{
				return GetRogueEndlessActivityDataCsReq._parser;
			}
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x0600580C RID: 22540 RVA: 0x000EB7FE File Offset: 0x000E99FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueEndlessActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x0600580D RID: 22541 RVA: 0x000EB810 File Offset: 0x000E9A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueEndlessActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x000EB817 File Offset: 0x000E9A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueEndlessActivityDataCsReq()
		{
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x000EB81F File Offset: 0x000E9A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueEndlessActivityDataCsReq(GetRogueEndlessActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x000EB838 File Offset: 0x000E9A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueEndlessActivityDataCsReq Clone()
		{
			return new GetRogueEndlessActivityDataCsReq(this);
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x000EB840 File Offset: 0x000E9A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueEndlessActivityDataCsReq);
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x000EB84E File Offset: 0x000E9A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueEndlessActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x000EB86C File Offset: 0x000E9A6C
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

		// Token: 0x06005814 RID: 22548 RVA: 0x000EB892 File Offset: 0x000E9A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x000EB89A File Offset: 0x000E9A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x000EB8A3 File Offset: 0x000E9AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x000EB8BC File Offset: 0x000E9ABC
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

		// Token: 0x06005818 RID: 22552 RVA: 0x000EB8E2 File Offset: 0x000E9AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueEndlessActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x000EB8FF File Offset: 0x000E9AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x000EB908 File Offset: 0x000E9B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002257 RID: 8791
		private static readonly MessageParser<GetRogueEndlessActivityDataCsReq> _parser = new MessageParser<GetRogueEndlessActivityDataCsReq>(() => new GetRogueEndlessActivityDataCsReq());

		// Token: 0x04002258 RID: 8792
		private UnknownFieldSet _unknownFields;
	}
}
