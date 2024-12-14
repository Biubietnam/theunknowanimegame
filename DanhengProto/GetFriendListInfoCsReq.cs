using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006C9 RID: 1737
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendListInfoCsReq : IMessage<GetFriendListInfoCsReq>, IMessage, IEquatable<GetFriendListInfoCsReq>, IDeepCloneable<GetFriendListInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06004DBE RID: 19902 RVA: 0x000D2A0B File Offset: 0x000D0C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendListInfoCsReq> Parser
		{
			get
			{
				return GetFriendListInfoCsReq._parser;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06004DBF RID: 19903 RVA: 0x000D2A12 File Offset: 0x000D0C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendListInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x000D2A24 File Offset: 0x000D0C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendListInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x000D2A2B File Offset: 0x000D0C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendListInfoCsReq()
		{
		}

		// Token: 0x06004DC2 RID: 19906 RVA: 0x000D2A33 File Offset: 0x000D0C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendListInfoCsReq(GetFriendListInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x000D2A4C File Offset: 0x000D0C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendListInfoCsReq Clone()
		{
			return new GetFriendListInfoCsReq(this);
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x000D2A54 File Offset: 0x000D0C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendListInfoCsReq);
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x000D2A62 File Offset: 0x000D0C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendListInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004DC6 RID: 19910 RVA: 0x000D2A80 File Offset: 0x000D0C80
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

		// Token: 0x06004DC7 RID: 19911 RVA: 0x000D2AA6 File Offset: 0x000D0CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x000D2AAE File Offset: 0x000D0CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x000D2AB7 File Offset: 0x000D0CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x000D2AD0 File Offset: 0x000D0CD0
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

		// Token: 0x06004DCB RID: 19915 RVA: 0x000D2AF6 File Offset: 0x000D0CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendListInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x000D2B13 File Offset: 0x000D0D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x000D2B1C File Offset: 0x000D0D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001EBC RID: 7868
		private static readonly MessageParser<GetFriendListInfoCsReq> _parser = new MessageParser<GetFriendListInfoCsReq>(() => new GetFriendListInfoCsReq());

		// Token: 0x04001EBD RID: 7869
		private UnknownFieldSet _unknownFields;
	}
}
