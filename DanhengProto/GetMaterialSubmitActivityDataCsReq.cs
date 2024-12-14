using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000715 RID: 1813
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMaterialSubmitActivityDataCsReq : IMessage<GetMaterialSubmitActivityDataCsReq>, IMessage, IEquatable<GetMaterialSubmitActivityDataCsReq>, IDeepCloneable<GetMaterialSubmitActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06005105 RID: 20741 RVA: 0x000DA427 File Offset: 0x000D8627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMaterialSubmitActivityDataCsReq> Parser
		{
			get
			{
				return GetMaterialSubmitActivityDataCsReq._parser;
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06005106 RID: 20742 RVA: 0x000DA42E File Offset: 0x000D862E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMaterialSubmitActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06005107 RID: 20743 RVA: 0x000DA440 File Offset: 0x000D8640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMaterialSubmitActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x000DA447 File Offset: 0x000D8647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMaterialSubmitActivityDataCsReq()
		{
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x000DA44F File Offset: 0x000D864F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMaterialSubmitActivityDataCsReq(GetMaterialSubmitActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x000DA468 File Offset: 0x000D8668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMaterialSubmitActivityDataCsReq Clone()
		{
			return new GetMaterialSubmitActivityDataCsReq(this);
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x000DA470 File Offset: 0x000D8670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMaterialSubmitActivityDataCsReq);
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x000DA47E File Offset: 0x000D867E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMaterialSubmitActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x000DA49C File Offset: 0x000D869C
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

		// Token: 0x0600510E RID: 20750 RVA: 0x000DA4C2 File Offset: 0x000D86C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x000DA4CA File Offset: 0x000D86CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x000DA4D3 File Offset: 0x000D86D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x000DA4EC File Offset: 0x000D86EC
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

		// Token: 0x06005112 RID: 20754 RVA: 0x000DA512 File Offset: 0x000D8712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMaterialSubmitActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x000DA52F File Offset: 0x000D872F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x000DA538 File Offset: 0x000D8738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FD9 RID: 8153
		private static readonly MessageParser<GetMaterialSubmitActivityDataCsReq> _parser = new MessageParser<GetMaterialSubmitActivityDataCsReq>(() => new GetMaterialSubmitActivityDataCsReq());

		// Token: 0x04001FDA RID: 8154
		private UnknownFieldSet _unknownFields;
	}
}
