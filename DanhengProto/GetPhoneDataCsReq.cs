using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200075D RID: 1885
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPhoneDataCsReq : IMessage<GetPhoneDataCsReq>, IMessage, IEquatable<GetPhoneDataCsReq>, IDeepCloneable<GetPhoneDataCsReq>, IBufferMessage
	{
		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x000E28E6 File Offset: 0x000E0AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPhoneDataCsReq> Parser
		{
			get
			{
				return GetPhoneDataCsReq._parser;
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x0600543C RID: 21564 RVA: 0x000E28ED File Offset: 0x000E0AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPhoneDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x000E28FF File Offset: 0x000E0AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPhoneDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x000E2906 File Offset: 0x000E0B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPhoneDataCsReq()
		{
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x000E290E File Offset: 0x000E0B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPhoneDataCsReq(GetPhoneDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x000E2927 File Offset: 0x000E0B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPhoneDataCsReq Clone()
		{
			return new GetPhoneDataCsReq(this);
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x000E292F File Offset: 0x000E0B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPhoneDataCsReq);
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x000E293D File Offset: 0x000E0B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPhoneDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x000E295C File Offset: 0x000E0B5C
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

		// Token: 0x06005444 RID: 21572 RVA: 0x000E2982 File Offset: 0x000E0B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x000E298A File Offset: 0x000E0B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x000E2993 File Offset: 0x000E0B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x000E29AC File Offset: 0x000E0BAC
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

		// Token: 0x06005448 RID: 21576 RVA: 0x000E29D2 File Offset: 0x000E0BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPhoneDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x000E29EF File Offset: 0x000E0BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x000E29F8 File Offset: 0x000E0BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002113 RID: 8467
		private static readonly MessageParser<GetPhoneDataCsReq> _parser = new MessageParser<GetPhoneDataCsReq>(() => new GetPhoneDataCsReq());

		// Token: 0x04002114 RID: 8468
		private UnknownFieldSet _unknownFields;
	}
}
