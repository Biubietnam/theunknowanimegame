using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000673 RID: 1651
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCurChallengeCsReq : IMessage<GetCurChallengeCsReq>, IMessage, IEquatable<GetCurChallengeCsReq>, IDeepCloneable<GetCurChallengeCsReq>, IBufferMessage
	{
		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x000C99D7 File Offset: 0x000C7BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCurChallengeCsReq> Parser
		{
			get
			{
				return GetCurChallengeCsReq._parser;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x060049FE RID: 18942 RVA: 0x000C99DE File Offset: 0x000C7BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCurChallengeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x060049FF RID: 18943 RVA: 0x000C99F0 File Offset: 0x000C7BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCurChallengeCsReq.Descriptor;
			}
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x000C99F7 File Offset: 0x000C7BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurChallengeCsReq()
		{
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x000C99FF File Offset: 0x000C7BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurChallengeCsReq(GetCurChallengeCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x000C9A18 File Offset: 0x000C7C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurChallengeCsReq Clone()
		{
			return new GetCurChallengeCsReq(this);
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x000C9A20 File Offset: 0x000C7C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCurChallengeCsReq);
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x000C9A2E File Offset: 0x000C7C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCurChallengeCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x000C9A4C File Offset: 0x000C7C4C
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

		// Token: 0x06004A06 RID: 18950 RVA: 0x000C9A72 File Offset: 0x000C7C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x000C9A7A File Offset: 0x000C7C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x000C9A83 File Offset: 0x000C7C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x000C9A9C File Offset: 0x000C7C9C
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

		// Token: 0x06004A0A RID: 18954 RVA: 0x000C9AC2 File Offset: 0x000C7CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCurChallengeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x000C9ADF File Offset: 0x000C7CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x000C9AE8 File Offset: 0x000C7CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D6B RID: 7531
		private static readonly MessageParser<GetCurChallengeCsReq> _parser = new MessageParser<GetCurChallengeCsReq>(() => new GetCurChallengeCsReq());

		// Token: 0x04001D6C RID: 7532
		private UnknownFieldSet _unknownFields;
	}
}
