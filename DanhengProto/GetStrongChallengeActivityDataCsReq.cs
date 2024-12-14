using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000811 RID: 2065
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetStrongChallengeActivityDataCsReq : IMessage<GetStrongChallengeActivityDataCsReq>, IMessage, IEquatable<GetStrongChallengeActivityDataCsReq>, IDeepCloneable<GetStrongChallengeActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x000F4CB7 File Offset: 0x000F2EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetStrongChallengeActivityDataCsReq> Parser
		{
			get
			{
				return GetStrongChallengeActivityDataCsReq._parser;
			}
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06005C0F RID: 23567 RVA: 0x000F4CBE File Offset: 0x000F2EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetStrongChallengeActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x000F4CD0 File Offset: 0x000F2ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStrongChallengeActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005C11 RID: 23569 RVA: 0x000F4CD7 File Offset: 0x000F2ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStrongChallengeActivityDataCsReq()
		{
		}

		// Token: 0x06005C12 RID: 23570 RVA: 0x000F4CDF File Offset: 0x000F2EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStrongChallengeActivityDataCsReq(GetStrongChallengeActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C13 RID: 23571 RVA: 0x000F4CF8 File Offset: 0x000F2EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStrongChallengeActivityDataCsReq Clone()
		{
			return new GetStrongChallengeActivityDataCsReq(this);
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x000F4D00 File Offset: 0x000F2F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStrongChallengeActivityDataCsReq);
		}

		// Token: 0x06005C15 RID: 23573 RVA: 0x000F4D0E File Offset: 0x000F2F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetStrongChallengeActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005C16 RID: 23574 RVA: 0x000F4D2C File Offset: 0x000F2F2C
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

		// Token: 0x06005C17 RID: 23575 RVA: 0x000F4D52 File Offset: 0x000F2F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C18 RID: 23576 RVA: 0x000F4D5A File Offset: 0x000F2F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C19 RID: 23577 RVA: 0x000F4D63 File Offset: 0x000F2F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x000F4D7C File Offset: 0x000F2F7C
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

		// Token: 0x06005C1B RID: 23579 RVA: 0x000F4DA2 File Offset: 0x000F2FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetStrongChallengeActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C1C RID: 23580 RVA: 0x000F4DBF File Offset: 0x000F2FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C1D RID: 23581 RVA: 0x000F4DC8 File Offset: 0x000F2FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400239C RID: 9116
		private static readonly MessageParser<GetStrongChallengeActivityDataCsReq> _parser = new MessageParser<GetStrongChallengeActivityDataCsReq>(() => new GetStrongChallengeActivityDataCsReq());

		// Token: 0x0400239D RID: 9117
		private UnknownFieldSet _unknownFields;
	}
}
