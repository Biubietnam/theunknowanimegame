using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007A9 RID: 1961
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueBuffEnhanceInfoCsReq : IMessage<GetRogueBuffEnhanceInfoCsReq>, IMessage, IEquatable<GetRogueBuffEnhanceInfoCsReq>, IDeepCloneable<GetRogueBuffEnhanceInfoCsReq>, IBufferMessage
	{
		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x0600578E RID: 22414 RVA: 0x000EA797 File Offset: 0x000E8997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueBuffEnhanceInfoCsReq> Parser
		{
			get
			{
				return GetRogueBuffEnhanceInfoCsReq._parser;
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x0600578F RID: 22415 RVA: 0x000EA79E File Offset: 0x000E899E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueBuffEnhanceInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06005790 RID: 22416 RVA: 0x000EA7B0 File Offset: 0x000E89B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueBuffEnhanceInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x000EA7B7 File Offset: 0x000E89B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueBuffEnhanceInfoCsReq()
		{
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x000EA7BF File Offset: 0x000E89BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueBuffEnhanceInfoCsReq(GetRogueBuffEnhanceInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x000EA7D8 File Offset: 0x000E89D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueBuffEnhanceInfoCsReq Clone()
		{
			return new GetRogueBuffEnhanceInfoCsReq(this);
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x000EA7E0 File Offset: 0x000E89E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueBuffEnhanceInfoCsReq);
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x000EA7EE File Offset: 0x000E89EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueBuffEnhanceInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x000EA80C File Offset: 0x000E8A0C
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

		// Token: 0x06005797 RID: 22423 RVA: 0x000EA832 File Offset: 0x000E8A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x000EA83A File Offset: 0x000E8A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x000EA843 File Offset: 0x000E8A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x000EA85C File Offset: 0x000E8A5C
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

		// Token: 0x0600579B RID: 22427 RVA: 0x000EA882 File Offset: 0x000E8A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueBuffEnhanceInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x000EA89F File Offset: 0x000E8A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x000EA8A8 File Offset: 0x000E8AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002234 RID: 8756
		private static readonly MessageParser<GetRogueBuffEnhanceInfoCsReq> _parser = new MessageParser<GetRogueBuffEnhanceInfoCsReq>(() => new GetRogueBuffEnhanceInfoCsReq());

		// Token: 0x04002235 RID: 8757
		private UnknownFieldSet _unknownFields;
	}
}
