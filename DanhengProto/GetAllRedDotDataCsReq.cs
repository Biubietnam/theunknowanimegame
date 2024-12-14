using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200060B RID: 1547
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAllRedDotDataCsReq : IMessage<GetAllRedDotDataCsReq>, IMessage, IEquatable<GetAllRedDotDataCsReq>, IDeepCloneable<GetAllRedDotDataCsReq>, IBufferMessage
	{
		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x0600456B RID: 17771 RVA: 0x000BE8C3 File Offset: 0x000BCAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAllRedDotDataCsReq> Parser
		{
			get
			{
				return GetAllRedDotDataCsReq._parser;
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x000BE8CA File Offset: 0x000BCACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAllRedDotDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x0600456D RID: 17773 RVA: 0x000BE8DC File Offset: 0x000BCADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllRedDotDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x000BE8E3 File Offset: 0x000BCAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllRedDotDataCsReq()
		{
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x000BE8EB File Offset: 0x000BCAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllRedDotDataCsReq(GetAllRedDotDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x000BE904 File Offset: 0x000BCB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllRedDotDataCsReq Clone()
		{
			return new GetAllRedDotDataCsReq(this);
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x000BE90C File Offset: 0x000BCB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllRedDotDataCsReq);
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x000BE91A File Offset: 0x000BCB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAllRedDotDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x000BE938 File Offset: 0x000BCB38
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

		// Token: 0x06004574 RID: 17780 RVA: 0x000BE95E File Offset: 0x000BCB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x000BE966 File Offset: 0x000BCB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x000BE96F File Offset: 0x000BCB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x000BE988 File Offset: 0x000BCB88
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

		// Token: 0x06004578 RID: 17784 RVA: 0x000BE9AE File Offset: 0x000BCBAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAllRedDotDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x000BE9CB File Offset: 0x000BCBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x000BE9D4 File Offset: 0x000BCBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001BD4 RID: 7124
		private static readonly MessageParser<GetAllRedDotDataCsReq> _parser = new MessageParser<GetAllRedDotDataCsReq>(() => new GetAllRedDotDataCsReq());

		// Token: 0x04001BD5 RID: 7125
		private UnknownFieldSet _unknownFields;
	}
}
