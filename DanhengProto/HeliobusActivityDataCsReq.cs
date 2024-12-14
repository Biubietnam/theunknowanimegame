using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008B3 RID: 2227
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusActivityDataCsReq : IMessage<HeliobusActivityDataCsReq>, IMessage, IEquatable<HeliobusActivityDataCsReq>, IDeepCloneable<HeliobusActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x0600633D RID: 25405 RVA: 0x00109C57 File Offset: 0x00107E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusActivityDataCsReq> Parser
		{
			get
			{
				return HeliobusActivityDataCsReq._parser;
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x0600633E RID: 25406 RVA: 0x00109C5E File Offset: 0x00107E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x0600633F RID: 25407 RVA: 0x00109C70 File Offset: 0x00107E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x00109C77 File Offset: 0x00107E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusActivityDataCsReq()
		{
		}

		// Token: 0x06006341 RID: 25409 RVA: 0x00109C7F File Offset: 0x00107E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusActivityDataCsReq(HeliobusActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x00109C98 File Offset: 0x00107E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusActivityDataCsReq Clone()
		{
			return new HeliobusActivityDataCsReq(this);
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x00109CA0 File Offset: 0x00107EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusActivityDataCsReq);
		}

		// Token: 0x06006344 RID: 25412 RVA: 0x00109CAE File Offset: 0x00107EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x00109CCC File Offset: 0x00107ECC
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

		// Token: 0x06006346 RID: 25414 RVA: 0x00109CF2 File Offset: 0x00107EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x00109CFA File Offset: 0x00107EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x00109D03 File Offset: 0x00107F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x00109D1C File Offset: 0x00107F1C
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

		// Token: 0x0600634A RID: 25418 RVA: 0x00109D42 File Offset: 0x00107F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600634B RID: 25419 RVA: 0x00109D5F File Offset: 0x00107F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x00109D68 File Offset: 0x00107F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400263E RID: 9790
		private static readonly MessageParser<HeliobusActivityDataCsReq> _parser = new MessageParser<HeliobusActivityDataCsReq>(() => new HeliobusActivityDataCsReq());

		// Token: 0x0400263F RID: 9791
		private UnknownFieldSet _unknownFields;
	}
}
