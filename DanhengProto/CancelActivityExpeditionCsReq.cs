using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200015B RID: 347
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CancelActivityExpeditionCsReq : IMessage<CancelActivityExpeditionCsReq>, IMessage, IEquatable<CancelActivityExpeditionCsReq>, IDeepCloneable<CancelActivityExpeditionCsReq>, IBufferMessage
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x0002D850 File Offset: 0x0002BA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CancelActivityExpeditionCsReq> Parser
		{
			get
			{
				return CancelActivityExpeditionCsReq._parser;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0002D857 File Offset: 0x0002BA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CancelActivityExpeditionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0002D869 File Offset: 0x0002BA69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelActivityExpeditionCsReq.Descriptor;
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0002D870 File Offset: 0x0002BA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelActivityExpeditionCsReq()
		{
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0002D878 File Offset: 0x0002BA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelActivityExpeditionCsReq(CancelActivityExpeditionCsReq other) : this()
		{
			this.hADKPJOKKCM_ = other.hADKPJOKKCM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0002D89D File Offset: 0x0002BA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelActivityExpeditionCsReq Clone()
		{
			return new CancelActivityExpeditionCsReq(this);
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x0002D8A5 File Offset: 0x0002BAA5
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x0002D8AD File Offset: 0x0002BAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HADKPJOKKCM
		{
			get
			{
				return this.hADKPJOKKCM_;
			}
			set
			{
				this.hADKPJOKKCM_ = value;
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0002D8B6 File Offset: 0x0002BAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelActivityExpeditionCsReq);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0002D8C4 File Offset: 0x0002BAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelActivityExpeditionCsReq other)
		{
			return other != null && (other == this || (this.HADKPJOKKCM == other.HADKPJOKKCM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HADKPJOKKCM != 0U)
			{
				num ^= this.HADKPJOKKCM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0002D933 File Offset: 0x0002BB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0002D93B File Offset: 0x0002BB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0002D944 File Offset: 0x0002BB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HADKPJOKKCM != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.HADKPJOKKCM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0002D978 File Offset: 0x0002BB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HADKPJOKKCM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HADKPJOKKCM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0002D9B6 File Offset: 0x0002BBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelActivityExpeditionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HADKPJOKKCM != 0U)
			{
				this.HADKPJOKKCM = other.HADKPJOKKCM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0002D9E7 File Offset: 0x0002BBE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HADKPJOKKCM = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040006A1 RID: 1697
		private static readonly MessageParser<CancelActivityExpeditionCsReq> _parser = new MessageParser<CancelActivityExpeditionCsReq>(() => new CancelActivityExpeditionCsReq());

		// Token: 0x040006A2 RID: 1698
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006A3 RID: 1699
		public const int HADKPJOKKCMFieldNumber = 10;

		// Token: 0x040006A4 RID: 1700
		private uint hADKPJOKKCM_;
	}
}
