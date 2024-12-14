using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006D1 RID: 1745
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendRecommendListInfoCsReq : IMessage<GetFriendRecommendListInfoCsReq>, IMessage, IEquatable<GetFriendRecommendListInfoCsReq>, IDeepCloneable<GetFriendRecommendListInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06004E16 RID: 19990 RVA: 0x000D3718 File Offset: 0x000D1918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendRecommendListInfoCsReq> Parser
		{
			get
			{
				return GetFriendRecommendListInfoCsReq._parser;
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06004E17 RID: 19991 RVA: 0x000D371F File Offset: 0x000D191F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendRecommendListInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06004E18 RID: 19992 RVA: 0x000D3731 File Offset: 0x000D1931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendRecommendListInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x000D3738 File Offset: 0x000D1938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendRecommendListInfoCsReq()
		{
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x000D3740 File Offset: 0x000D1940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendRecommendListInfoCsReq(GetFriendRecommendListInfoCsReq other) : this()
		{
			this.cOBDHLMALKI_ = other.cOBDHLMALKI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x000D3765 File Offset: 0x000D1965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendRecommendListInfoCsReq Clone()
		{
			return new GetFriendRecommendListInfoCsReq(this);
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06004E1C RID: 19996 RVA: 0x000D376D File Offset: 0x000D196D
		// (set) Token: 0x06004E1D RID: 19997 RVA: 0x000D3775 File Offset: 0x000D1975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool COBDHLMALKI
		{
			get
			{
				return this.cOBDHLMALKI_;
			}
			set
			{
				this.cOBDHLMALKI_ = value;
			}
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x000D377E File Offset: 0x000D197E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendRecommendListInfoCsReq);
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x000D378C File Offset: 0x000D198C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendRecommendListInfoCsReq other)
		{
			return other != null && (other == this || (this.COBDHLMALKI == other.COBDHLMALKI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x000D37BC File Offset: 0x000D19BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.COBDHLMALKI)
			{
				num ^= this.COBDHLMALKI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x000D37FB File Offset: 0x000D19FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x000D3803 File Offset: 0x000D1A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x000D380C File Offset: 0x000D1A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.COBDHLMALKI)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.COBDHLMALKI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x000D3840 File Offset: 0x000D1A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.COBDHLMALKI)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x000D3872 File Offset: 0x000D1A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendRecommendListInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.COBDHLMALKI)
			{
				this.COBDHLMALKI = other.COBDHLMALKI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x000D38A3 File Offset: 0x000D1AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x000D38AC File Offset: 0x000D1AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.COBDHLMALKI = input.ReadBool();
				}
			}
		}

		// Token: 0x04001EDC RID: 7900
		private static readonly MessageParser<GetFriendRecommendListInfoCsReq> _parser = new MessageParser<GetFriendRecommendListInfoCsReq>(() => new GetFriendRecommendListInfoCsReq());

		// Token: 0x04001EDD RID: 7901
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EDE RID: 7902
		public const int COBDHLMALKIFieldNumber = 9;

		// Token: 0x04001EDF RID: 7903
		private bool cOBDHLMALKI_;
	}
}
