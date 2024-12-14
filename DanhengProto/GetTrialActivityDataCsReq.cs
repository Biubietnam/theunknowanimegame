using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000835 RID: 2101
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTrialActivityDataCsReq : IMessage<GetTrialActivityDataCsReq>, IMessage, IEquatable<GetTrialActivityDataCsReq>, IDeepCloneable<GetTrialActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06005D7E RID: 23934 RVA: 0x000F809B File Offset: 0x000F629B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTrialActivityDataCsReq> Parser
		{
			get
			{
				return GetTrialActivityDataCsReq._parser;
			}
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06005D7F RID: 23935 RVA: 0x000F80A2 File Offset: 0x000F62A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTrialActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06005D80 RID: 23936 RVA: 0x000F80B4 File Offset: 0x000F62B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTrialActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005D81 RID: 23937 RVA: 0x000F80BB File Offset: 0x000F62BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrialActivityDataCsReq()
		{
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x000F80C3 File Offset: 0x000F62C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrialActivityDataCsReq(GetTrialActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x000F80DC File Offset: 0x000F62DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrialActivityDataCsReq Clone()
		{
			return new GetTrialActivityDataCsReq(this);
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x000F80E4 File Offset: 0x000F62E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTrialActivityDataCsReq);
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x000F80F2 File Offset: 0x000F62F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTrialActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x000F8110 File Offset: 0x000F6310
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

		// Token: 0x06005D87 RID: 23943 RVA: 0x000F8136 File Offset: 0x000F6336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x000F813E File Offset: 0x000F633E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x000F8147 File Offset: 0x000F6347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x000F8160 File Offset: 0x000F6360
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

		// Token: 0x06005D8B RID: 23947 RVA: 0x000F8186 File Offset: 0x000F6386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTrialActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x000F81A3 File Offset: 0x000F63A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D8D RID: 23949 RVA: 0x000F81AC File Offset: 0x000F63AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002419 RID: 9241
		private static readonly MessageParser<GetTrialActivityDataCsReq> _parser = new MessageParser<GetTrialActivityDataCsReq>(() => new GetTrialActivityDataCsReq());

		// Token: 0x0400241A RID: 9242
		private UnknownFieldSet _unknownFields;
	}
}
