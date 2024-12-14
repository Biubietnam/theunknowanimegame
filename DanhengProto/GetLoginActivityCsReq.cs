using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006FD RID: 1789
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetLoginActivityCsReq : IMessage<GetLoginActivityCsReq>, IMessage, IEquatable<GetLoginActivityCsReq>, IDeepCloneable<GetLoginActivityCsReq>, IBufferMessage
	{
		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06004FF8 RID: 20472 RVA: 0x000D7BD7 File Offset: 0x000D5DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetLoginActivityCsReq> Parser
		{
			get
			{
				return GetLoginActivityCsReq._parser;
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06004FF9 RID: 20473 RVA: 0x000D7BDE File Offset: 0x000D5DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetLoginActivityCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06004FFA RID: 20474 RVA: 0x000D7BF0 File Offset: 0x000D5DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLoginActivityCsReq.Descriptor;
			}
		}

		// Token: 0x06004FFB RID: 20475 RVA: 0x000D7BF7 File Offset: 0x000D5DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginActivityCsReq()
		{
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x000D7BFF File Offset: 0x000D5DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginActivityCsReq(GetLoginActivityCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x000D7C18 File Offset: 0x000D5E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginActivityCsReq Clone()
		{
			return new GetLoginActivityCsReq(this);
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x000D7C20 File Offset: 0x000D5E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLoginActivityCsReq);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x000D7C2E File Offset: 0x000D5E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLoginActivityCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x000D7C4C File Offset: 0x000D5E4C
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

		// Token: 0x06005001 RID: 20481 RVA: 0x000D7C72 File Offset: 0x000D5E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x000D7C7A File Offset: 0x000D5E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x000D7C83 File Offset: 0x000D5E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x000D7C9C File Offset: 0x000D5E9C
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

		// Token: 0x06005005 RID: 20485 RVA: 0x000D7CC2 File Offset: 0x000D5EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLoginActivityCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x000D7CDF File Offset: 0x000D5EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x000D7CE8 File Offset: 0x000D5EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F7A RID: 8058
		private static readonly MessageParser<GetLoginActivityCsReq> _parser = new MessageParser<GetLoginActivityCsReq>(() => new GetLoginActivityCsReq());

		// Token: 0x04001F7B RID: 8059
		private UnknownFieldSet _unknownFields;
	}
}
