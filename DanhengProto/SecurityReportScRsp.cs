using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200109D RID: 4253
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SecurityReportScRsp : IMessage<SecurityReportScRsp>, IMessage, IEquatable<SecurityReportScRsp>, IDeepCloneable<SecurityReportScRsp>, IBufferMessage
	{
		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0600BD90 RID: 48528 RVA: 0x001FED18 File Offset: 0x001FCF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SecurityReportScRsp> Parser
		{
			get
			{
				return SecurityReportScRsp._parser;
			}
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0600BD91 RID: 48529 RVA: 0x001FED1F File Offset: 0x001FCF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SecurityReportScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0600BD92 RID: 48530 RVA: 0x001FED31 File Offset: 0x001FCF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecurityReportScRsp.Descriptor;
			}
		}

		// Token: 0x0600BD93 RID: 48531 RVA: 0x001FED38 File Offset: 0x001FCF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecurityReportScRsp()
		{
		}

		// Token: 0x0600BD94 RID: 48532 RVA: 0x001FED40 File Offset: 0x001FCF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecurityReportScRsp(SecurityReportScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD95 RID: 48533 RVA: 0x001FED65 File Offset: 0x001FCF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecurityReportScRsp Clone()
		{
			return new SecurityReportScRsp(this);
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x0600BD96 RID: 48534 RVA: 0x001FED6D File Offset: 0x001FCF6D
		// (set) Token: 0x0600BD97 RID: 48535 RVA: 0x001FED75 File Offset: 0x001FCF75
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

		// Token: 0x0600BD98 RID: 48536 RVA: 0x001FED7E File Offset: 0x001FCF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecurityReportScRsp);
		}

		// Token: 0x0600BD99 RID: 48537 RVA: 0x001FED8C File Offset: 0x001FCF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecurityReportScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD9A RID: 48538 RVA: 0x001FEDBC File Offset: 0x001FCFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600BD9B RID: 48539 RVA: 0x001FEDFB File Offset: 0x001FCFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BD9C RID: 48540 RVA: 0x001FEE03 File Offset: 0x001FD003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD9D RID: 48541 RVA: 0x001FEE0C File Offset: 0x001FD00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD9E RID: 48542 RVA: 0x001FEE40 File Offset: 0x001FD040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600BD9F RID: 48543 RVA: 0x001FEE7E File Offset: 0x001FD07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecurityReportScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BDA0 RID: 48544 RVA: 0x001FEEAF File Offset: 0x001FD0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDA1 RID: 48545 RVA: 0x001FEEB8 File Offset: 0x001FD0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D13 RID: 19731
		private static readonly MessageParser<SecurityReportScRsp> _parser = new MessageParser<SecurityReportScRsp>(() => new SecurityReportScRsp());

		// Token: 0x04004D14 RID: 19732
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D15 RID: 19733
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004D16 RID: 19734
		private uint retcode_;
	}
}
