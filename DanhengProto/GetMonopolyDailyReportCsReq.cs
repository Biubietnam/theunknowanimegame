using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000729 RID: 1833
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMonopolyDailyReportCsReq : IMessage<GetMonopolyDailyReportCsReq>, IMessage, IEquatable<GetMonopolyDailyReportCsReq>, IDeepCloneable<GetMonopolyDailyReportCsReq>, IBufferMessage
	{
		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x060051EC RID: 20972 RVA: 0x000DCAEB File Offset: 0x000DACEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMonopolyDailyReportCsReq> Parser
		{
			get
			{
				return GetMonopolyDailyReportCsReq._parser;
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x060051ED RID: 20973 RVA: 0x000DCAF2 File Offset: 0x000DACF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMonopolyDailyReportCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x060051EE RID: 20974 RVA: 0x000DCB04 File Offset: 0x000DAD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMonopolyDailyReportCsReq.Descriptor;
			}
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x000DCB0B File Offset: 0x000DAD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyDailyReportCsReq()
		{
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x000DCB13 File Offset: 0x000DAD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyDailyReportCsReq(GetMonopolyDailyReportCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x000DCB2C File Offset: 0x000DAD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyDailyReportCsReq Clone()
		{
			return new GetMonopolyDailyReportCsReq(this);
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x000DCB34 File Offset: 0x000DAD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMonopolyDailyReportCsReq);
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x000DCB42 File Offset: 0x000DAD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMonopolyDailyReportCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x000DCB60 File Offset: 0x000DAD60
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

		// Token: 0x060051F5 RID: 20981 RVA: 0x000DCB86 File Offset: 0x000DAD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x000DCB8E File Offset: 0x000DAD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x000DCB97 File Offset: 0x000DAD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x000DCBB0 File Offset: 0x000DADB0
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

		// Token: 0x060051F9 RID: 20985 RVA: 0x000DCBD6 File Offset: 0x000DADD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMonopolyDailyReportCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060051FA RID: 20986 RVA: 0x000DCBF3 File Offset: 0x000DADF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x000DCBFC File Offset: 0x000DADFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400203E RID: 8254
		private static readonly MessageParser<GetMonopolyDailyReportCsReq> _parser = new MessageParser<GetMonopolyDailyReportCsReq>(() => new GetMonopolyDailyReportCsReq());

		// Token: 0x0400203F RID: 8255
		private UnknownFieldSet _unknownFields;
	}
}
