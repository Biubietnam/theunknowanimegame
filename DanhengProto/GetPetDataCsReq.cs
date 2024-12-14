using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000759 RID: 1881
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPetDataCsReq : IMessage<GetPetDataCsReq>, IMessage, IEquatable<GetPetDataCsReq>, IDeepCloneable<GetPetDataCsReq>, IBufferMessage
	{
		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06005410 RID: 21520 RVA: 0x000E2332 File Offset: 0x000E0532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPetDataCsReq> Parser
		{
			get
			{
				return GetPetDataCsReq._parser;
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06005411 RID: 21521 RVA: 0x000E2339 File Offset: 0x000E0539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPetDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06005412 RID: 21522 RVA: 0x000E234B File Offset: 0x000E054B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPetDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x000E2352 File Offset: 0x000E0552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPetDataCsReq()
		{
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x000E235A File Offset: 0x000E055A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPetDataCsReq(GetPetDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x000E2373 File Offset: 0x000E0573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPetDataCsReq Clone()
		{
			return new GetPetDataCsReq(this);
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x000E237B File Offset: 0x000E057B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPetDataCsReq);
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x000E2389 File Offset: 0x000E0589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPetDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x000E23A8 File Offset: 0x000E05A8
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

		// Token: 0x06005419 RID: 21529 RVA: 0x000E23CE File Offset: 0x000E05CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x000E23D6 File Offset: 0x000E05D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x000E23DF File Offset: 0x000E05DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x000E23F8 File Offset: 0x000E05F8
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

		// Token: 0x0600541D RID: 21533 RVA: 0x000E241E File Offset: 0x000E061E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPetDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x000E243B File Offset: 0x000E063B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x000E2444 File Offset: 0x000E0644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002106 RID: 8454
		private static readonly MessageParser<GetPetDataCsReq> _parser = new MessageParser<GetPetDataCsReq>(() => new GetPetDataCsReq());

		// Token: 0x04002107 RID: 8455
		private UnknownFieldSet _unknownFields;
	}
}
