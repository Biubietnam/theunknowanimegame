using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200078D RID: 1933
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRaidInfoCsReq : IMessage<GetRaidInfoCsReq>, IMessage, IEquatable<GetRaidInfoCsReq>, IDeepCloneable<GetRaidInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06005656 RID: 22102 RVA: 0x000E7996 File Offset: 0x000E5B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRaidInfoCsReq> Parser
		{
			get
			{
				return GetRaidInfoCsReq._parser;
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06005657 RID: 22103 RVA: 0x000E799D File Offset: 0x000E5B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRaidInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06005658 RID: 22104 RVA: 0x000E79AF File Offset: 0x000E5BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRaidInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x000E79B6 File Offset: 0x000E5BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRaidInfoCsReq()
		{
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x000E79BE File Offset: 0x000E5BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRaidInfoCsReq(GetRaidInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x000E79D7 File Offset: 0x000E5BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRaidInfoCsReq Clone()
		{
			return new GetRaidInfoCsReq(this);
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x000E79DF File Offset: 0x000E5BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRaidInfoCsReq);
		}

		// Token: 0x0600565D RID: 22109 RVA: 0x000E79ED File Offset: 0x000E5BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRaidInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x000E7A0C File Offset: 0x000E5C0C
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

		// Token: 0x0600565F RID: 22111 RVA: 0x000E7A32 File Offset: 0x000E5C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005660 RID: 22112 RVA: 0x000E7A3A File Offset: 0x000E5C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005661 RID: 22113 RVA: 0x000E7A43 File Offset: 0x000E5C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x000E7A5C File Offset: 0x000E5C5C
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

		// Token: 0x06005663 RID: 22115 RVA: 0x000E7A82 File Offset: 0x000E5C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRaidInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x000E7A9F File Offset: 0x000E5C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x000E7AA8 File Offset: 0x000E5CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021CC RID: 8652
		private static readonly MessageParser<GetRaidInfoCsReq> _parser = new MessageParser<GetRaidInfoCsReq>(() => new GetRaidInfoCsReq());

		// Token: 0x040021CD RID: 8653
		private UnknownFieldSet _unknownFields;
	}
}
