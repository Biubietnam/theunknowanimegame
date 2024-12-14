using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008C9 RID: 2249
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSnsCommentScRsp : IMessage<HeliobusSnsCommentScRsp>, IMessage, IEquatable<HeliobusSnsCommentScRsp>, IDeepCloneable<HeliobusSnsCommentScRsp>, IBufferMessage
	{
		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06006446 RID: 25670 RVA: 0x0010C82D File Offset: 0x0010AA2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSnsCommentScRsp> Parser
		{
			get
			{
				return HeliobusSnsCommentScRsp._parser;
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06006447 RID: 25671 RVA: 0x0010C834 File Offset: 0x0010AA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSnsCommentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06006448 RID: 25672 RVA: 0x0010C846 File Offset: 0x0010AA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSnsCommentScRsp.Descriptor;
			}
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x0010C84D File Offset: 0x0010AA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsCommentScRsp()
		{
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x0010C858 File Offset: 0x0010AA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsCommentScRsp(HeliobusSnsCommentScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.lCJMLEHEBJK_ = ((other.lCJMLEHEBJK_ != null) ? other.lCJMLEHEBJK_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x0010C8A4 File Offset: 0x0010AAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSnsCommentScRsp Clone()
		{
			return new HeliobusSnsCommentScRsp(this);
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x0600644C RID: 25676 RVA: 0x0010C8AC File Offset: 0x0010AAAC
		// (set) Token: 0x0600644D RID: 25677 RVA: 0x0010C8B4 File Offset: 0x0010AAB4
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

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x0600644E RID: 25678 RVA: 0x0010C8BD File Offset: 0x0010AABD
		// (set) Token: 0x0600644F RID: 25679 RVA: 0x0010C8C5 File Offset: 0x0010AAC5
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

		// Token: 0x06006450 RID: 25680 RVA: 0x0010C8CE File Offset: 0x0010AACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSnsCommentScRsp);
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x0010C8DC File Offset: 0x0010AADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSnsCommentScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.LCJMLEHEBJK, other.LCJMLEHEBJK) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x0010C92C File Offset: 0x0010AB2C
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

		// Token: 0x06006453 RID: 25683 RVA: 0x0010C981 File Offset: 0x0010AB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x0010C989 File Offset: 0x0010AB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x0010C994 File Offset: 0x0010AB94
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
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x0010C9F0 File Offset: 0x0010ABF0
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

		// Token: 0x06006457 RID: 25687 RVA: 0x0010CA48 File Offset: 0x0010AC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSnsCommentScRsp other)
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

		// Token: 0x06006458 RID: 25688 RVA: 0x0010CAB0 File Offset: 0x0010ACB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x0010CABC File Offset: 0x0010ACBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 32U)
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

		// Token: 0x040026A3 RID: 9891
		private static readonly MessageParser<HeliobusSnsCommentScRsp> _parser = new MessageParser<HeliobusSnsCommentScRsp>(() => new HeliobusSnsCommentScRsp());

		// Token: 0x040026A4 RID: 9892
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026A5 RID: 9893
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040026A6 RID: 9894
		private uint retcode_;

		// Token: 0x040026A7 RID: 9895
		public const int LCJMLEHEBJKFieldNumber = 2;

		// Token: 0x040026A8 RID: 9896
		private PCMDGDLANFF lCJMLEHEBJK_;
	}
}
