using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000701 RID: 1793
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetLoginChatInfoCsReq : IMessage<GetLoginChatInfoCsReq>, IMessage, IEquatable<GetLoginChatInfoCsReq>, IDeepCloneable<GetLoginChatInfoCsReq>, IBufferMessage
	{
		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06005021 RID: 20513 RVA: 0x000D80F7 File Offset: 0x000D62F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetLoginChatInfoCsReq> Parser
		{
			get
			{
				return GetLoginChatInfoCsReq._parser;
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06005022 RID: 20514 RVA: 0x000D80FE File Offset: 0x000D62FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetLoginChatInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x000D8110 File Offset: 0x000D6310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLoginChatInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x000D8117 File Offset: 0x000D6317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginChatInfoCsReq()
		{
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x000D811F File Offset: 0x000D631F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginChatInfoCsReq(GetLoginChatInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x000D8138 File Offset: 0x000D6338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginChatInfoCsReq Clone()
		{
			return new GetLoginChatInfoCsReq(this);
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x000D8140 File Offset: 0x000D6340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLoginChatInfoCsReq);
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x000D814E File Offset: 0x000D634E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLoginChatInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x000D816C File Offset: 0x000D636C
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

		// Token: 0x0600502A RID: 20522 RVA: 0x000D8192 File Offset: 0x000D6392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x000D819A File Offset: 0x000D639A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x000D81A3 File Offset: 0x000D63A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x000D81BC File Offset: 0x000D63BC
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

		// Token: 0x0600502E RID: 20526 RVA: 0x000D81E2 File Offset: 0x000D63E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLoginChatInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x000D81FF File Offset: 0x000D63FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x000D8208 File Offset: 0x000D6408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F85 RID: 8069
		private static readonly MessageParser<GetLoginChatInfoCsReq> _parser = new MessageParser<GetLoginChatInfoCsReq>(() => new GetLoginChatInfoCsReq());

		// Token: 0x04001F86 RID: 8070
		private UnknownFieldSet _unknownFields;
	}
}
