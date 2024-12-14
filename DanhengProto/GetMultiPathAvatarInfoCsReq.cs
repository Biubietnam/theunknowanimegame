using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200073D RID: 1853
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMultiPathAvatarInfoCsReq : IMessage<GetMultiPathAvatarInfoCsReq>, IMessage, IEquatable<GetMultiPathAvatarInfoCsReq>, IDeepCloneable<GetMultiPathAvatarInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x060052D3 RID: 21203 RVA: 0x000DF0E7 File Offset: 0x000DD2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMultiPathAvatarInfoCsReq> Parser
		{
			get
			{
				return GetMultiPathAvatarInfoCsReq._parser;
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x060052D4 RID: 21204 RVA: 0x000DF0EE File Offset: 0x000DD2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMultiPathAvatarInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x060052D5 RID: 21205 RVA: 0x000DF100 File Offset: 0x000DD300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMultiPathAvatarInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x000DF107 File Offset: 0x000DD307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultiPathAvatarInfoCsReq()
		{
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x000DF10F File Offset: 0x000DD30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultiPathAvatarInfoCsReq(GetMultiPathAvatarInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x000DF128 File Offset: 0x000DD328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultiPathAvatarInfoCsReq Clone()
		{
			return new GetMultiPathAvatarInfoCsReq(this);
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x000DF130 File Offset: 0x000DD330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMultiPathAvatarInfoCsReq);
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x000DF13E File Offset: 0x000DD33E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMultiPathAvatarInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x000DF15C File Offset: 0x000DD35C
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

		// Token: 0x060052DC RID: 21212 RVA: 0x000DF182 File Offset: 0x000DD382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x000DF18A File Offset: 0x000DD38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x000DF193 File Offset: 0x000DD393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x000DF1AC File Offset: 0x000DD3AC
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

		// Token: 0x060052E0 RID: 21216 RVA: 0x000DF1D2 File Offset: 0x000DD3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMultiPathAvatarInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x000DF1EF File Offset: 0x000DD3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x000DF1F8 File Offset: 0x000DD3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400208B RID: 8331
		private static readonly MessageParser<GetMultiPathAvatarInfoCsReq> _parser = new MessageParser<GetMultiPathAvatarInfoCsReq>(() => new GetMultiPathAvatarInfoCsReq());

		// Token: 0x0400208C RID: 8332
		private UnknownFieldSet _unknownFields;
	}
}
