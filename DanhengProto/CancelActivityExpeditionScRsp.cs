using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200015D RID: 349
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CancelActivityExpeditionScRsp : IMessage<CancelActivityExpeditionScRsp>, IMessage, IEquatable<CancelActivityExpeditionScRsp>, IDeepCloneable<CancelActivityExpeditionScRsp>, IBufferMessage
	{
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0002DACD File Offset: 0x0002BCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CancelActivityExpeditionScRsp> Parser
		{
			get
			{
				return CancelActivityExpeditionScRsp._parser;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0002DAD4 File Offset: 0x0002BCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CancelActivityExpeditionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0002DAE6 File Offset: 0x0002BCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelActivityExpeditionScRsp.Descriptor;
			}
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0002DAED File Offset: 0x0002BCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelActivityExpeditionScRsp()
		{
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0002DAF5 File Offset: 0x0002BCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelActivityExpeditionScRsp(CancelActivityExpeditionScRsp other) : this()
		{
			this.hADKPJOKKCM_ = other.hADKPJOKKCM_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0002DB26 File Offset: 0x0002BD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelActivityExpeditionScRsp Clone()
		{
			return new CancelActivityExpeditionScRsp(this);
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0002DB2E File Offset: 0x0002BD2E
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x0002DB36 File Offset: 0x0002BD36
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

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x0002DB3F File Offset: 0x0002BD3F
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x0002DB47 File Offset: 0x0002BD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0002DB50 File Offset: 0x0002BD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelActivityExpeditionScRsp);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0002DB5E File Offset: 0x0002BD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelActivityExpeditionScRsp other)
		{
			return other != null && (other == this || (this.HADKPJOKKCM == other.HADKPJOKKCM && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HADKPJOKKCM != 0U)
			{
				num ^= this.HADKPJOKKCM.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0002DBF4 File Offset: 0x0002BDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0002DBFC File Offset: 0x0002BDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0002DC08 File Offset: 0x0002BE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.HADKPJOKKCM != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.HADKPJOKKCM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0002DC64 File Offset: 0x0002BE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HADKPJOKKCM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HADKPJOKKCM);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0002DCBC File Offset: 0x0002BEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelActivityExpeditionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HADKPJOKKCM != 0U)
			{
				this.HADKPJOKKCM = other.HADKPJOKKCM;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0002DD0C File Offset: 0x0002BF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0002DD18 File Offset: 0x0002BF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HADKPJOKKCM = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040006A6 RID: 1702
		private static readonly MessageParser<CancelActivityExpeditionScRsp> _parser = new MessageParser<CancelActivityExpeditionScRsp>(() => new CancelActivityExpeditionScRsp());

		// Token: 0x040006A7 RID: 1703
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006A8 RID: 1704
		public const int HADKPJOKKCMFieldNumber = 11;

		// Token: 0x040006A9 RID: 1705
		private uint hADKPJOKKCM_;

		// Token: 0x040006AA RID: 1706
		public const int RetcodeFieldNumber = 9;

		// Token: 0x040006AB RID: 1707
		private uint retcode_;
	}
}
