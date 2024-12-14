using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000641 RID: 1601
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChallengeRaidInfoCsReq : IMessage<GetChallengeRaidInfoCsReq>, IMessage, IEquatable<GetChallengeRaidInfoCsReq>, IDeepCloneable<GetChallengeRaidInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x060047DC RID: 18396 RVA: 0x000C4C3F File Offset: 0x000C2E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChallengeRaidInfoCsReq> Parser
		{
			get
			{
				return GetChallengeRaidInfoCsReq._parser;
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x000C4C46 File Offset: 0x000C2E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChallengeRaidInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x060047DE RID: 18398 RVA: 0x000C4C58 File Offset: 0x000C2E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChallengeRaidInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x000C4C5F File Offset: 0x000C2E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRaidInfoCsReq()
		{
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x000C4C67 File Offset: 0x000C2E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRaidInfoCsReq(GetChallengeRaidInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x000C4C80 File Offset: 0x000C2E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRaidInfoCsReq Clone()
		{
			return new GetChallengeRaidInfoCsReq(this);
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x000C4C88 File Offset: 0x000C2E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChallengeRaidInfoCsReq);
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x000C4C96 File Offset: 0x000C2E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChallengeRaidInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x000C4CB4 File Offset: 0x000C2EB4
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

		// Token: 0x060047E5 RID: 18405 RVA: 0x000C4CDA File Offset: 0x000C2EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x000C4CE2 File Offset: 0x000C2EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x000C4CEB File Offset: 0x000C2EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x000C4D04 File Offset: 0x000C2F04
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

		// Token: 0x060047E9 RID: 18409 RVA: 0x000C4D2A File Offset: 0x000C2F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChallengeRaidInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x000C4D47 File Offset: 0x000C2F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x000C4D50 File Offset: 0x000C2F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001CBE RID: 7358
		private static readonly MessageParser<GetChallengeRaidInfoCsReq> _parser = new MessageParser<GetChallengeRaidInfoCsReq>(() => new GetChallengeRaidInfoCsReq());

		// Token: 0x04001CBF RID: 7359
		private UnknownFieldSet _unknownFields;
	}
}
