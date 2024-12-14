using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007F1 RID: 2033
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetShareDataCsReq : IMessage<GetShareDataCsReq>, IMessage, IEquatable<GetShareDataCsReq>, IDeepCloneable<GetShareDataCsReq>, IBufferMessage
	{
		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x000F1B7A File Offset: 0x000EFD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetShareDataCsReq> Parser
		{
			get
			{
				return GetShareDataCsReq._parser;
			}
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06005AB0 RID: 23216 RVA: 0x000F1B81 File Offset: 0x000EFD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetShareDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06005AB1 RID: 23217 RVA: 0x000F1B93 File Offset: 0x000EFD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetShareDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x000F1B9A File Offset: 0x000EFD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShareDataCsReq()
		{
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x000F1BA2 File Offset: 0x000EFDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShareDataCsReq(GetShareDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x000F1BBB File Offset: 0x000EFDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShareDataCsReq Clone()
		{
			return new GetShareDataCsReq(this);
		}

		// Token: 0x06005AB5 RID: 23221 RVA: 0x000F1BC3 File Offset: 0x000EFDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetShareDataCsReq);
		}

		// Token: 0x06005AB6 RID: 23222 RVA: 0x000F1BD1 File Offset: 0x000EFDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetShareDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x000F1BF0 File Offset: 0x000EFDF0
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

		// Token: 0x06005AB8 RID: 23224 RVA: 0x000F1C16 File Offset: 0x000EFE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x000F1C1E File Offset: 0x000EFE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x000F1C27 File Offset: 0x000EFE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x000F1C40 File Offset: 0x000EFE40
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

		// Token: 0x06005ABC RID: 23228 RVA: 0x000F1C66 File Offset: 0x000EFE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetShareDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x000F1C83 File Offset: 0x000EFE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x000F1C8C File Offset: 0x000EFE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400232F RID: 9007
		private static readonly MessageParser<GetShareDataCsReq> _parser = new MessageParser<GetShareDataCsReq>(() => new GetShareDataCsReq());

		// Token: 0x04002330 RID: 9008
		private UnknownFieldSet _unknownFields;
	}
}
