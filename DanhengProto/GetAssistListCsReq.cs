using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200061F RID: 1567
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAssistListCsReq : IMessage<GetAssistListCsReq>, IMessage, IEquatable<GetAssistListCsReq>, IDeepCloneable<GetAssistListCsReq>, IBufferMessage
	{
		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x0600463F RID: 17983 RVA: 0x000C0478 File Offset: 0x000BE678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAssistListCsReq> Parser
		{
			get
			{
				return GetAssistListCsReq._parser;
			}
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06004640 RID: 17984 RVA: 0x000C047F File Offset: 0x000BE67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAssistListCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06004641 RID: 17985 RVA: 0x000C0491 File Offset: 0x000BE691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAssistListCsReq.Descriptor;
			}
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x000C0498 File Offset: 0x000BE698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistListCsReq()
		{
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x000C04A0 File Offset: 0x000BE6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistListCsReq(GetAssistListCsReq other) : this()
		{
			this.cOBJPPCBMJE_ = other.cOBJPPCBMJE_;
			this.cOBDHLMALKI_ = other.cOBDHLMALKI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x000C04D1 File Offset: 0x000BE6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistListCsReq Clone()
		{
			return new GetAssistListCsReq(this);
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06004645 RID: 17989 RVA: 0x000C04D9 File Offset: 0x000BE6D9
		// (set) Token: 0x06004646 RID: 17990 RVA: 0x000C04E1 File Offset: 0x000BE6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool COBJPPCBMJE
		{
			get
			{
				return this.cOBJPPCBMJE_;
			}
			set
			{
				this.cOBJPPCBMJE_ = value;
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06004647 RID: 17991 RVA: 0x000C04EA File Offset: 0x000BE6EA
		// (set) Token: 0x06004648 RID: 17992 RVA: 0x000C04F2 File Offset: 0x000BE6F2
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

		// Token: 0x06004649 RID: 17993 RVA: 0x000C04FB File Offset: 0x000BE6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAssistListCsReq);
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x000C0509 File Offset: 0x000BE709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAssistListCsReq other)
		{
			return other != null && (other == this || (this.COBJPPCBMJE == other.COBJPPCBMJE && this.COBDHLMALKI == other.COBDHLMALKI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x000C0548 File Offset: 0x000BE748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.COBJPPCBMJE)
			{
				num ^= this.COBJPPCBMJE.GetHashCode();
			}
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

		// Token: 0x0600464C RID: 17996 RVA: 0x000C05A0 File Offset: 0x000BE7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x000C05A8 File Offset: 0x000BE7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x000C05B4 File Offset: 0x000BE7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.COBJPPCBMJE)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.COBJPPCBMJE);
			}
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

		// Token: 0x0600464F RID: 17999 RVA: 0x000C0610 File Offset: 0x000BE810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.COBJPPCBMJE)
			{
				num += 2;
			}
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

		// Token: 0x06004650 RID: 18000 RVA: 0x000C0650 File Offset: 0x000BE850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAssistListCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.COBJPPCBMJE)
			{
				this.COBJPPCBMJE = other.COBJPPCBMJE;
			}
			if (other.COBDHLMALKI)
			{
				this.COBDHLMALKI = other.COBDHLMALKI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x000C06A0 File Offset: 0x000BE8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x000C06AC File Offset: 0x000BE8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
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
				else
				{
					this.COBJPPCBMJE = input.ReadBool();
				}
			}
		}

		// Token: 0x04001C10 RID: 7184
		private static readonly MessageParser<GetAssistListCsReq> _parser = new MessageParser<GetAssistListCsReq>(() => new GetAssistListCsReq());

		// Token: 0x04001C11 RID: 7185
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C12 RID: 7186
		public const int COBJPPCBMJEFieldNumber = 6;

		// Token: 0x04001C13 RID: 7187
		private bool cOBJPPCBMJE_;

		// Token: 0x04001C14 RID: 7188
		public const int COBDHLMALKIFieldNumber = 9;

		// Token: 0x04001C15 RID: 7189
		private bool cOBDHLMALKI_;
	}
}
