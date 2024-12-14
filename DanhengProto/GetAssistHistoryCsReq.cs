using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200061B RID: 1563
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAssistHistoryCsReq : IMessage<GetAssistHistoryCsReq>, IMessage, IEquatable<GetAssistHistoryCsReq>, IDeepCloneable<GetAssistHistoryCsReq>, IBufferMessage
	{
		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06004610 RID: 17936 RVA: 0x000BFD37 File Offset: 0x000BDF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAssistHistoryCsReq> Parser
		{
			get
			{
				return GetAssistHistoryCsReq._parser;
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x06004611 RID: 17937 RVA: 0x000BFD3E File Offset: 0x000BDF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAssistHistoryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x000BFD50 File Offset: 0x000BDF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAssistHistoryCsReq.Descriptor;
			}
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x000BFD57 File Offset: 0x000BDF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistHistoryCsReq()
		{
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x000BFD5F File Offset: 0x000BDF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistHistoryCsReq(GetAssistHistoryCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x000BFD78 File Offset: 0x000BDF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistHistoryCsReq Clone()
		{
			return new GetAssistHistoryCsReq(this);
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x000BFD80 File Offset: 0x000BDF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAssistHistoryCsReq);
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x000BFD8E File Offset: 0x000BDF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAssistHistoryCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x000BFDAC File Offset: 0x000BDFAC
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

		// Token: 0x06004619 RID: 17945 RVA: 0x000BFDD2 File Offset: 0x000BDFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x000BFDDA File Offset: 0x000BDFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x000BFDE3 File Offset: 0x000BDFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x000BFDFC File Offset: 0x000BDFFC
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

		// Token: 0x0600461D RID: 17949 RVA: 0x000BFE22 File Offset: 0x000BE022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAssistHistoryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x000BFE3F File Offset: 0x000BE03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x000BFE48 File Offset: 0x000BE048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001BFF RID: 7167
		private static readonly MessageParser<GetAssistHistoryCsReq> _parser = new MessageParser<GetAssistHistoryCsReq>(() => new GetAssistHistoryCsReq());

		// Token: 0x04001C00 RID: 7168
		private UnknownFieldSet _unknownFields;
	}
}
