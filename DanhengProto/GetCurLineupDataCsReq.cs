using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000677 RID: 1655
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCurLineupDataCsReq : IMessage<GetCurLineupDataCsReq>, IMessage, IEquatable<GetCurLineupDataCsReq>, IDeepCloneable<GetCurLineupDataCsReq>, IBufferMessage
	{
		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06004A28 RID: 18984 RVA: 0x000C9FEF File Offset: 0x000C81EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCurLineupDataCsReq> Parser
		{
			get
			{
				return GetCurLineupDataCsReq._parser;
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x000C9FF6 File Offset: 0x000C81F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCurLineupDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06004A2A RID: 18986 RVA: 0x000CA008 File Offset: 0x000C8208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCurLineupDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x000CA00F File Offset: 0x000C820F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurLineupDataCsReq()
		{
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x000CA017 File Offset: 0x000C8217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurLineupDataCsReq(GetCurLineupDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x000CA030 File Offset: 0x000C8230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurLineupDataCsReq Clone()
		{
			return new GetCurLineupDataCsReq(this);
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x000CA038 File Offset: 0x000C8238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCurLineupDataCsReq);
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x000CA046 File Offset: 0x000C8246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCurLineupDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x000CA064 File Offset: 0x000C8264
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

		// Token: 0x06004A31 RID: 18993 RVA: 0x000CA08A File Offset: 0x000C828A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x000CA092 File Offset: 0x000C8292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x000CA09B File Offset: 0x000C829B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x000CA0B4 File Offset: 0x000C82B4
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

		// Token: 0x06004A35 RID: 18997 RVA: 0x000CA0DA File Offset: 0x000C82DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCurLineupDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x000CA0F7 File Offset: 0x000C82F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x000CA100 File Offset: 0x000C8300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D78 RID: 7544
		private static readonly MessageParser<GetCurLineupDataCsReq> _parser = new MessageParser<GetCurLineupDataCsReq>(() => new GetCurLineupDataCsReq());

		// Token: 0x04001D79 RID: 7545
		private UnknownFieldSet _unknownFields;
	}
}
