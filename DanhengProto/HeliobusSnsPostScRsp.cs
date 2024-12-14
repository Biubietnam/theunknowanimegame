using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008D1 RID: 2257
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSnsPostScRsp : IMessage<HeliobusSnsPostScRsp>, IMessage, IEquatable<HeliobusSnsPostScRsp>, IDeepCloneable<HeliobusSnsPostScRsp>, IBufferMessage
	{
		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x060064A4 RID: 25764 RVA: 0x0010D609 File Offset: 0x0010B809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSnsPostScRsp> Parser
		{
			get
			{
				return HeliobusSnsPostScRsp._parser;
			}
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x060064A5 RID: 25765 RVA: 0x0010D610 File Offset: 0x0010B810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSnsPostScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x060064A6 RID: 25766 RVA: 0x0010D622 File Offset: 0x0010B822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSnsPostScRsp.Descriptor;
			}
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x0010D629 File Offset: 0x0010B829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsPostScRsp()
		{
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x0010D634 File Offset: 0x0010B834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsPostScRsp(HeliobusSnsPostScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.lCJMLEHEBJK_ = ((other.lCJMLEHEBJK_ != null) ? other.lCJMLEHEBJK_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x0010D680 File Offset: 0x0010B880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsPostScRsp Clone()
		{
			return new HeliobusSnsPostScRsp(this);
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x060064AA RID: 25770 RVA: 0x0010D688 File Offset: 0x0010B888
		// (set) Token: 0x060064AB RID: 25771 RVA: 0x0010D690 File Offset: 0x0010B890
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

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x060064AC RID: 25772 RVA: 0x0010D699 File Offset: 0x0010B899
		// (set) Token: 0x060064AD RID: 25773 RVA: 0x0010D6A1 File Offset: 0x0010B8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PCMDGDLANFF LCJMLEHEBJK
		{
			get
			{
				return this.lCJMLEHEBJK_;
			}
			set
			{
				this.lCJMLEHEBJK_ = value;
			}
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x0010D6AA File Offset: 0x0010B8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSnsPostScRsp);
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x0010D6B8 File Offset: 0x0010B8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSnsPostScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.LCJMLEHEBJK, other.LCJMLEHEBJK) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x0010D708 File Offset: 0x0010B908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.lCJMLEHEBJK_ != null)
			{
				num ^= this.LCJMLEHEBJK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x0010D75D File Offset: 0x0010B95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x0010D765 File Offset: 0x0010B965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x0010D770 File Offset: 0x0010B970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lCJMLEHEBJK_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.LCJMLEHEBJK);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x0010D7CC File Offset: 0x0010B9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.lCJMLEHEBJK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LCJMLEHEBJK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x0010D824 File Offset: 0x0010BA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSnsPostScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.lCJMLEHEBJK_ != null)
			{
				if (this.lCJMLEHEBJK_ == null)
				{
					this.LCJMLEHEBJK = new PCMDGDLANFF();
				}
				this.LCJMLEHEBJK.MergeFrom(other.LCJMLEHEBJK);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x0010D88C File Offset: 0x0010BA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x0010D898 File Offset: 0x0010BA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 96U)
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
					if (this.lCJMLEHEBJK_ == null)
					{
						this.LCJMLEHEBJK = new PCMDGDLANFF();
					}
					input.ReadMessage(this.LCJMLEHEBJK);
				}
			}
		}

		// Token: 0x040026C1 RID: 9921
		private static readonly MessageParser<HeliobusSnsPostScRsp> _parser = new MessageParser<HeliobusSnsPostScRsp>(() => new HeliobusSnsPostScRsp());

		// Token: 0x040026C2 RID: 9922
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026C3 RID: 9923
		public const int RetcodeFieldNumber = 12;

		// Token: 0x040026C4 RID: 9924
		private uint retcode_;

		// Token: 0x040026C5 RID: 9925
		public const int LCJMLEHEBJKFieldNumber = 2;

		// Token: 0x040026C6 RID: 9926
		private PCMDGDLANFF lCJMLEHEBJK_;
	}
}
