using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000771 RID: 1905
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPlayerReturnMultiDropInfoCsReq : IMessage<GetPlayerReturnMultiDropInfoCsReq>, IMessage, IEquatable<GetPlayerReturnMultiDropInfoCsReq>, IDeepCloneable<GetPlayerReturnMultiDropInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x0600551A RID: 21786 RVA: 0x000E4A6B File Offset: 0x000E2C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPlayerReturnMultiDropInfoCsReq> Parser
		{
			get
			{
				return GetPlayerReturnMultiDropInfoCsReq._parser;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x0600551B RID: 21787 RVA: 0x000E4A72 File Offset: 0x000E2C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPlayerReturnMultiDropInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x0600551C RID: 21788 RVA: 0x000E4A84 File Offset: 0x000E2C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerReturnMultiDropInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x000E4A8B File Offset: 0x000E2C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReturnMultiDropInfoCsReq()
		{
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x000E4A93 File Offset: 0x000E2C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReturnMultiDropInfoCsReq(GetPlayerReturnMultiDropInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x000E4AAC File Offset: 0x000E2CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReturnMultiDropInfoCsReq Clone()
		{
			return new GetPlayerReturnMultiDropInfoCsReq(this);
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x000E4AB4 File Offset: 0x000E2CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerReturnMultiDropInfoCsReq);
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x000E4AC2 File Offset: 0x000E2CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPlayerReturnMultiDropInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x000E4AE0 File Offset: 0x000E2CE0
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

		// Token: 0x06005523 RID: 21795 RVA: 0x000E4B06 File Offset: 0x000E2D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x000E4B0E File Offset: 0x000E2D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x000E4B17 File Offset: 0x000E2D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x000E4B30 File Offset: 0x000E2D30
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

		// Token: 0x06005527 RID: 21799 RVA: 0x000E4B56 File Offset: 0x000E2D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPlayerReturnMultiDropInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x000E4B73 File Offset: 0x000E2D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x000E4B7C File Offset: 0x000E2D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002160 RID: 8544
		private static readonly MessageParser<GetPlayerReturnMultiDropInfoCsReq> _parser = new MessageParser<GetPlayerReturnMultiDropInfoCsReq>(() => new GetPlayerReturnMultiDropInfoCsReq());

		// Token: 0x04002161 RID: 8545
		private UnknownFieldSet _unknownFields;
	}
}
