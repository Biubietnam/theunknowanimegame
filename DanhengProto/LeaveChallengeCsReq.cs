using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009F1 RID: 2545
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveChallengeCsReq : IMessage<LeaveChallengeCsReq>, IMessage, IEquatable<LeaveChallengeCsReq>, IDeepCloneable<LeaveChallengeCsReq>, IBufferMessage
	{
		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x060070FC RID: 28924 RVA: 0x0012D0E2 File Offset: 0x0012B2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveChallengeCsReq> Parser
		{
			get
			{
				return LeaveChallengeCsReq._parser;
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x060070FD RID: 28925 RVA: 0x0012D0E9 File Offset: 0x0012B2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveChallengeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x060070FE RID: 28926 RVA: 0x0012D0FB File Offset: 0x0012B2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveChallengeCsReq.Descriptor;
			}
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x0012D102 File Offset: 0x0012B302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveChallengeCsReq()
		{
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x0012D10A File Offset: 0x0012B30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveChallengeCsReq(LeaveChallengeCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x0012D123 File Offset: 0x0012B323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveChallengeCsReq Clone()
		{
			return new LeaveChallengeCsReq(this);
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x0012D12B File Offset: 0x0012B32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveChallengeCsReq);
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x0012D139 File Offset: 0x0012B339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveChallengeCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x0012D158 File Offset: 0x0012B358
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

		// Token: 0x06007105 RID: 28933 RVA: 0x0012D17E File Offset: 0x0012B37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x0012D186 File Offset: 0x0012B386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x0012D18F File Offset: 0x0012B38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x0012D1A8 File Offset: 0x0012B3A8
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

		// Token: 0x06007109 RID: 28937 RVA: 0x0012D1CE File Offset: 0x0012B3CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveChallengeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x0012D1EB File Offset: 0x0012B3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x0012D1F4 File Offset: 0x0012B3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B87 RID: 11143
		private static readonly MessageParser<LeaveChallengeCsReq> _parser = new MessageParser<LeaveChallengeCsReq>(() => new LeaveChallengeCsReq());

		// Token: 0x04002B88 RID: 11144
		private UnknownFieldSet _unknownFields;
	}
}
