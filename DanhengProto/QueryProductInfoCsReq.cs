using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D39 RID: 3385
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QueryProductInfoCsReq : IMessage<QueryProductInfoCsReq>, IMessage, IEquatable<QueryProductInfoCsReq>, IDeepCloneable<QueryProductInfoCsReq>, IBufferMessage
	{
		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x0600974C RID: 38732 RVA: 0x001934F7 File Offset: 0x001916F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QueryProductInfoCsReq> Parser
		{
			get
			{
				return QueryProductInfoCsReq._parser;
			}
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x0600974D RID: 38733 RVA: 0x001934FE File Offset: 0x001916FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QueryProductInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x0600974E RID: 38734 RVA: 0x00193510 File Offset: 0x00191710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryProductInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600974F RID: 38735 RVA: 0x00193517 File Offset: 0x00191717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryProductInfoCsReq()
		{
		}

		// Token: 0x06009750 RID: 38736 RVA: 0x0019351F File Offset: 0x0019171F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryProductInfoCsReq(QueryProductInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009751 RID: 38737 RVA: 0x00193538 File Offset: 0x00191738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryProductInfoCsReq Clone()
		{
			return new QueryProductInfoCsReq(this);
		}

		// Token: 0x06009752 RID: 38738 RVA: 0x00193540 File Offset: 0x00191740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryProductInfoCsReq);
		}

		// Token: 0x06009753 RID: 38739 RVA: 0x0019354E File Offset: 0x0019174E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QueryProductInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009754 RID: 38740 RVA: 0x0019356C File Offset: 0x0019176C
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

		// Token: 0x06009755 RID: 38741 RVA: 0x00193592 File Offset: 0x00191792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009756 RID: 38742 RVA: 0x0019359A File Offset: 0x0019179A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009757 RID: 38743 RVA: 0x001935A3 File Offset: 0x001917A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009758 RID: 38744 RVA: 0x001935BC File Offset: 0x001917BC
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

		// Token: 0x06009759 RID: 38745 RVA: 0x001935E2 File Offset: 0x001917E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QueryProductInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600975A RID: 38746 RVA: 0x001935FF File Offset: 0x001917FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600975B RID: 38747 RVA: 0x00193608 File Offset: 0x00191808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003AD8 RID: 15064
		private static readonly MessageParser<QueryProductInfoCsReq> _parser = new MessageParser<QueryProductInfoCsReq>(() => new QueryProductInfoCsReq());

		// Token: 0x04003AD9 RID: 15065
		private UnknownFieldSet _unknownFields;
	}
}
