using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000721 RID: 1825
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMissionEventDataCsReq : IMessage<GetMissionEventDataCsReq>, IMessage, IEquatable<GetMissionEventDataCsReq>, IDeepCloneable<GetMissionEventDataCsReq>, IBufferMessage
	{
		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x000DB9BF File Offset: 0x000D9BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMissionEventDataCsReq> Parser
		{
			get
			{
				return GetMissionEventDataCsReq._parser;
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06005191 RID: 20881 RVA: 0x000DB9C6 File Offset: 0x000D9BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMissionEventDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06005192 RID: 20882 RVA: 0x000DB9D8 File Offset: 0x000D9BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMissionEventDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x000DB9DF File Offset: 0x000D9BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionEventDataCsReq()
		{
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x000DB9E7 File Offset: 0x000D9BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionEventDataCsReq(GetMissionEventDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x000DBA00 File Offset: 0x000D9C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionEventDataCsReq Clone()
		{
			return new GetMissionEventDataCsReq(this);
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x000DBA08 File Offset: 0x000D9C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMissionEventDataCsReq);
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x000DBA16 File Offset: 0x000D9C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMissionEventDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x000DBA34 File Offset: 0x000D9C34
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

		// Token: 0x06005199 RID: 20889 RVA: 0x000DBA5A File Offset: 0x000D9C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x000DBA62 File Offset: 0x000D9C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x000DBA6B File Offset: 0x000D9C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x000DBA84 File Offset: 0x000D9C84
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

		// Token: 0x0600519D RID: 20893 RVA: 0x000DBAAA File Offset: 0x000D9CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMissionEventDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x000DBAC7 File Offset: 0x000D9CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x000DBAD0 File Offset: 0x000D9CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400200E RID: 8206
		private static readonly MessageParser<GetMissionEventDataCsReq> _parser = new MessageParser<GetMissionEventDataCsReq>(() => new GetMissionEventDataCsReq());

		// Token: 0x0400200F RID: 8207
		private UnknownFieldSet _unknownFields;
	}
}
