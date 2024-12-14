using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200000D RID: 13
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptActivityExpeditionCsReq : IMessage<AcceptActivityExpeditionCsReq>, IMessage, IEquatable<AcceptActivityExpeditionCsReq>, IDeepCloneable<AcceptActivityExpeditionCsReq>, IBufferMessage
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002C81 File Offset: 0x00000E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptActivityExpeditionCsReq> Parser
		{
			get
			{
				return AcceptActivityExpeditionCsReq._parser;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002C88 File Offset: 0x00000E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptActivityExpeditionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002C9A File Offset: 0x00000E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptActivityExpeditionCsReq.Descriptor;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002CA1 File Offset: 0x00000EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptActivityExpeditionCsReq()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002CA9 File Offset: 0x00000EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptActivityExpeditionCsReq(AcceptActivityExpeditionCsReq other) : this()
		{
			this.nACJGFAFCGE_ = ((other.nACJGFAFCGE_ != null) ? other.nACJGFAFCGE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002CDE File Offset: 0x00000EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptActivityExpeditionCsReq Clone()
		{
			return new AcceptActivityExpeditionCsReq(this);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002CE6 File Offset: 0x00000EE6
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002CEE File Offset: 0x00000EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityExpedition NACJGFAFCGE
		{
			get
			{
				return this.nACJGFAFCGE_;
			}
			set
			{
				this.nACJGFAFCGE_ = value;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002CF7 File Offset: 0x00000EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptActivityExpeditionCsReq);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002D05 File Offset: 0x00000F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptActivityExpeditionCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.NACJGFAFCGE, other.NACJGFAFCGE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002D38 File Offset: 0x00000F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.nACJGFAFCGE_ != null)
			{
				num ^= this.NACJGFAFCGE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002D74 File Offset: 0x00000F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002D7C File Offset: 0x00000F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002D85 File Offset: 0x00000F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nACJGFAFCGE_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.NACJGFAFCGE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002DB8 File Offset: 0x00000FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.nACJGFAFCGE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NACJGFAFCGE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002DF8 File Offset: 0x00000FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptActivityExpeditionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.nACJGFAFCGE_ != null)
			{
				if (this.nACJGFAFCGE_ == null)
				{
					this.NACJGFAFCGE = new ActivityExpedition();
				}
				this.NACJGFAFCGE.MergeFrom(other.NACJGFAFCGE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002E4C File Offset: 0x0000104C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002E58 File Offset: 0x00001058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.nACJGFAFCGE_ == null)
					{
						this.NACJGFAFCGE = new ActivityExpedition();
					}
					input.ReadMessage(this.NACJGFAFCGE);
				}
			}
		}

		// Token: 0x04000027 RID: 39
		private static readonly MessageParser<AcceptActivityExpeditionCsReq> _parser = new MessageParser<AcceptActivityExpeditionCsReq>(() => new AcceptActivityExpeditionCsReq());

		// Token: 0x04000028 RID: 40
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000029 RID: 41
		public const int NACJGFAFCGEFieldNumber = 10;

		// Token: 0x0400002A RID: 42
		private ActivityExpedition nACJGFAFCGE_;
	}
}
