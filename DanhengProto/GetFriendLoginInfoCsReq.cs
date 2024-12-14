using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006CD RID: 1741
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendLoginInfoCsReq : IMessage<GetFriendLoginInfoCsReq>, IMessage, IEquatable<GetFriendLoginInfoCsReq>, IDeepCloneable<GetFriendLoginInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06004DE8 RID: 19944 RVA: 0x000D2FEF File Offset: 0x000D11EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendLoginInfoCsReq> Parser
		{
			get
			{
				return GetFriendLoginInfoCsReq._parser;
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06004DE9 RID: 19945 RVA: 0x000D2FF6 File Offset: 0x000D11F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendLoginInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06004DEA RID: 19946 RVA: 0x000D3008 File Offset: 0x000D1208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendLoginInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x000D300F File Offset: 0x000D120F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendLoginInfoCsReq()
		{
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x000D3017 File Offset: 0x000D1217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendLoginInfoCsReq(GetFriendLoginInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x000D3030 File Offset: 0x000D1230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendLoginInfoCsReq Clone()
		{
			return new GetFriendLoginInfoCsReq(this);
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x000D3038 File Offset: 0x000D1238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendLoginInfoCsReq);
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x000D3046 File Offset: 0x000D1246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendLoginInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x000D3064 File Offset: 0x000D1264
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

		// Token: 0x06004DF1 RID: 19953 RVA: 0x000D308A File Offset: 0x000D128A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x000D3092 File Offset: 0x000D1292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x000D309B File Offset: 0x000D129B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x000D30B4 File Offset: 0x000D12B4
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

		// Token: 0x06004DF5 RID: 19957 RVA: 0x000D30DA File Offset: 0x000D12DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendLoginInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x000D30F7 File Offset: 0x000D12F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x000D3100 File Offset: 0x000D1300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001ECA RID: 7882
		private static readonly MessageParser<GetFriendLoginInfoCsReq> _parser = new MessageParser<GetFriendLoginInfoCsReq>(() => new GetFriendLoginInfoCsReq());

		// Token: 0x04001ECB RID: 7883
		private UnknownFieldSet _unknownFields;
	}
}
