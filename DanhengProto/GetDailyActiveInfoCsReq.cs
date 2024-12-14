using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200067F RID: 1663
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetDailyActiveInfoCsReq : IMessage<GetDailyActiveInfoCsReq>, IMessage, IEquatable<GetDailyActiveInfoCsReq>, IDeepCloneable<GetDailyActiveInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x000CAA87 File Offset: 0x000C8C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetDailyActiveInfoCsReq> Parser
		{
			get
			{
				return GetDailyActiveInfoCsReq._parser;
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06004A7D RID: 19069 RVA: 0x000CAA8E File Offset: 0x000C8C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetDailyActiveInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06004A7E RID: 19070 RVA: 0x000CAAA0 File Offset: 0x000C8CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDailyActiveInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x000CAAA7 File Offset: 0x000C8CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDailyActiveInfoCsReq()
		{
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x000CAAAF File Offset: 0x000C8CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDailyActiveInfoCsReq(GetDailyActiveInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x000CAAC8 File Offset: 0x000C8CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDailyActiveInfoCsReq Clone()
		{
			return new GetDailyActiveInfoCsReq(this);
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x000CAAD0 File Offset: 0x000C8CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDailyActiveInfoCsReq);
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x000CAADE File Offset: 0x000C8CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDailyActiveInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x000CAAFC File Offset: 0x000C8CFC
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

		// Token: 0x06004A85 RID: 19077 RVA: 0x000CAB22 File Offset: 0x000C8D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x000CAB2A File Offset: 0x000C8D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x000CAB33 File Offset: 0x000C8D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x000CAB4C File Offset: 0x000C8D4C
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

		// Token: 0x06004A89 RID: 19081 RVA: 0x000CAB72 File Offset: 0x000C8D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDailyActiveInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x000CAB8F File Offset: 0x000C8D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x000CAB98 File Offset: 0x000C8D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D8C RID: 7564
		private static readonly MessageParser<GetDailyActiveInfoCsReq> _parser = new MessageParser<GetDailyActiveInfoCsReq>(() => new GetDailyActiveInfoCsReq());

		// Token: 0x04001D8D RID: 7565
		private UnknownFieldSet _unknownFields;
	}
}
