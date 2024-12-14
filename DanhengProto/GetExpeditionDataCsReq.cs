using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000691 RID: 1681
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetExpeditionDataCsReq : IMessage<GetExpeditionDataCsReq>, IMessage, IEquatable<GetExpeditionDataCsReq>, IDeepCloneable<GetExpeditionDataCsReq>, IBufferMessage
	{
		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06004B49 RID: 19273 RVA: 0x000CC973 File Offset: 0x000CAB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetExpeditionDataCsReq> Parser
		{
			get
			{
				return GetExpeditionDataCsReq._parser;
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x000CC97A File Offset: 0x000CAB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetExpeditionDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06004B4B RID: 19275 RVA: 0x000CC98C File Offset: 0x000CAB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetExpeditionDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x000CC993 File Offset: 0x000CAB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetExpeditionDataCsReq()
		{
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x000CC99B File Offset: 0x000CAB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetExpeditionDataCsReq(GetExpeditionDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x000CC9B4 File Offset: 0x000CABB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetExpeditionDataCsReq Clone()
		{
			return new GetExpeditionDataCsReq(this);
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x000CC9BC File Offset: 0x000CABBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetExpeditionDataCsReq);
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x000CC9CA File Offset: 0x000CABCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetExpeditionDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x000CC9E8 File Offset: 0x000CABE8
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

		// Token: 0x06004B52 RID: 19282 RVA: 0x000CCA0E File Offset: 0x000CAC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x000CCA16 File Offset: 0x000CAC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x000CCA1F File Offset: 0x000CAC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x000CCA38 File Offset: 0x000CAC38
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

		// Token: 0x06004B56 RID: 19286 RVA: 0x000CCA5E File Offset: 0x000CAC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetExpeditionDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x000CCA7B File Offset: 0x000CAC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x000CCA84 File Offset: 0x000CAC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001DD5 RID: 7637
		private static readonly MessageParser<GetExpeditionDataCsReq> _parser = new MessageParser<GetExpeditionDataCsReq>(() => new GetExpeditionDataCsReq());

		// Token: 0x04001DD6 RID: 7638
		private UnknownFieldSet _unknownFields;
	}
}
