using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200000F RID: 15
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptActivityExpeditionScRsp : IMessage<AcceptActivityExpeditionScRsp>, IMessage, IEquatable<AcceptActivityExpeditionScRsp>, IDeepCloneable<AcceptActivityExpeditionScRsp>, IBufferMessage
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002F67 File Offset: 0x00001167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptActivityExpeditionScRsp> Parser
		{
			get
			{
				return AcceptActivityExpeditionScRsp._parser;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002F6E File Offset: 0x0000116E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptActivityExpeditionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002F80 File Offset: 0x00001180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptActivityExpeditionScRsp.Descriptor;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002F87 File Offset: 0x00001187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptActivityExpeditionScRsp()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002F90 File Offset: 0x00001190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptActivityExpeditionScRsp(AcceptActivityExpeditionScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.nACJGFAFCGE_ = ((other.nACJGFAFCGE_ != null) ? other.nACJGFAFCGE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002FDC File Offset: 0x000011DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptActivityExpeditionScRsp Clone()
		{
			return new AcceptActivityExpeditionScRsp(this);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002FE4 File Offset: 0x000011E4
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002FEC File Offset: 0x000011EC
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002FF5 File Offset: 0x000011F5
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002FFD File Offset: 0x000011FD
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

		// Token: 0x0600006C RID: 108 RVA: 0x00003006 File Offset: 0x00001206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptActivityExpeditionScRsp);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003014 File Offset: 0x00001214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptActivityExpeditionScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.NACJGFAFCGE, other.NACJGFAFCGE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003064 File Offset: 0x00001264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
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

		// Token: 0x0600006F RID: 111 RVA: 0x000030B9 File Offset: 0x000012B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000030C1 File Offset: 0x000012C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000030CC File Offset: 0x000012CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nACJGFAFCGE_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NACJGFAFCGE);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003128 File Offset: 0x00001328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
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

		// Token: 0x06000073 RID: 115 RVA: 0x00003180 File Offset: 0x00001380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptActivityExpeditionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
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

		// Token: 0x06000074 RID: 116 RVA: 0x000031E8 File Offset: 0x000013E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000031F4 File Offset: 0x000013F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
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

		// Token: 0x0400002C RID: 44
		private static readonly MessageParser<AcceptActivityExpeditionScRsp> _parser = new MessageParser<AcceptActivityExpeditionScRsp>(() => new AcceptActivityExpeditionScRsp());

		// Token: 0x0400002D RID: 45
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400002E RID: 46
		public const int RetcodeFieldNumber = 13;

		// Token: 0x0400002F RID: 47
		private uint retcode_;

		// Token: 0x04000030 RID: 48
		public const int NACJGFAFCGEFieldNumber = 2;

		// Token: 0x04000031 RID: 49
		private ActivityExpedition nACJGFAFCGE_;
	}
}
