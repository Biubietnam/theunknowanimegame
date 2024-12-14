using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000719 RID: 1817
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMbtiReportCsReq : IMessage<GetMbtiReportCsReq>, IMessage, IEquatable<GetMbtiReportCsReq>, IDeepCloneable<GetMbtiReportCsReq>, IBufferMessage
	{
		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x0600512E RID: 20782 RVA: 0x000DA942 File Offset: 0x000D8B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMbtiReportCsReq> Parser
		{
			get
			{
				return GetMbtiReportCsReq._parser;
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x0600512F RID: 20783 RVA: 0x000DA949 File Offset: 0x000D8B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMbtiReportCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06005130 RID: 20784 RVA: 0x000DA95B File Offset: 0x000D8B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMbtiReportCsReq.Descriptor;
			}
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x000DA962 File Offset: 0x000D8B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMbtiReportCsReq()
		{
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x000DA96A File Offset: 0x000D8B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMbtiReportCsReq(GetMbtiReportCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x000DA983 File Offset: 0x000D8B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMbtiReportCsReq Clone()
		{
			return new GetMbtiReportCsReq(this);
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x000DA98B File Offset: 0x000D8B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMbtiReportCsReq);
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x000DA999 File Offset: 0x000D8B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMbtiReportCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x000DA9B8 File Offset: 0x000D8BB8
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

		// Token: 0x06005137 RID: 20791 RVA: 0x000DA9DE File Offset: 0x000D8BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x000DA9E6 File Offset: 0x000D8BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x000DA9EF File Offset: 0x000D8BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x000DAA08 File Offset: 0x000D8C08
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

		// Token: 0x0600513B RID: 20795 RVA: 0x000DAA2E File Offset: 0x000D8C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMbtiReportCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x000DAA4B File Offset: 0x000D8C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x000DAA54 File Offset: 0x000D8C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FE4 RID: 8164
		private static readonly MessageParser<GetMbtiReportCsReq> _parser = new MessageParser<GetMbtiReportCsReq>(() => new GetMbtiReportCsReq());

		// Token: 0x04001FE5 RID: 8165
		private UnknownFieldSet _unknownFields;
	}
}
