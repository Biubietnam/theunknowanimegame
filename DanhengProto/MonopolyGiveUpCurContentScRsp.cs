using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B4F RID: 2895
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGiveUpCurContentScRsp : IMessage<MonopolyGiveUpCurContentScRsp>, IMessage, IEquatable<MonopolyGiveUpCurContentScRsp>, IDeepCloneable<MonopolyGiveUpCurContentScRsp>, IBufferMessage
	{
		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x06008025 RID: 32805 RVA: 0x001524B5 File Offset: 0x001506B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGiveUpCurContentScRsp> Parser
		{
			get
			{
				return MonopolyGiveUpCurContentScRsp._parser;
			}
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x06008026 RID: 32806 RVA: 0x001524BC File Offset: 0x001506BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGiveUpCurContentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x06008027 RID: 32807 RVA: 0x001524CE File Offset: 0x001506CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGiveUpCurContentScRsp.Descriptor;
			}
		}

		// Token: 0x06008028 RID: 32808 RVA: 0x001524D5 File Offset: 0x001506D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGiveUpCurContentScRsp()
		{
		}

		// Token: 0x06008029 RID: 32809 RVA: 0x001524DD File Offset: 0x001506DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGiveUpCurContentScRsp(MonopolyGiveUpCurContentScRsp other) : this()
		{
			this.contentId_ = other.contentId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600802A RID: 32810 RVA: 0x0015250E File Offset: 0x0015070E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGiveUpCurContentScRsp Clone()
		{
			return new MonopolyGiveUpCurContentScRsp(this);
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x0600802B RID: 32811 RVA: 0x00152516 File Offset: 0x00150716
		// (set) Token: 0x0600802C RID: 32812 RVA: 0x0015251E File Offset: 0x0015071E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentId
		{
			get
			{
				return this.contentId_;
			}
			set
			{
				this.contentId_ = value;
			}
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x0600802D RID: 32813 RVA: 0x00152527 File Offset: 0x00150727
		// (set) Token: 0x0600802E RID: 32814 RVA: 0x0015252F File Offset: 0x0015072F
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

		// Token: 0x0600802F RID: 32815 RVA: 0x00152538 File Offset: 0x00150738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGiveUpCurContentScRsp);
		}

		// Token: 0x06008030 RID: 32816 RVA: 0x00152546 File Offset: 0x00150746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGiveUpCurContentScRsp other)
		{
			return other != null && (other == this || (this.ContentId == other.ContentId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008031 RID: 32817 RVA: 0x00152584 File Offset: 0x00150784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
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

		// Token: 0x06008032 RID: 32818 RVA: 0x001525DC File Offset: 0x001507DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008033 RID: 32819 RVA: 0x001525E4 File Offset: 0x001507E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008034 RID: 32820 RVA: 0x001525F0 File Offset: 0x001507F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ContentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008035 RID: 32821 RVA: 0x0015264C File Offset: 0x0015084C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
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

		// Token: 0x06008036 RID: 32822 RVA: 0x001526A4 File Offset: 0x001508A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGiveUpCurContentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008037 RID: 32823 RVA: 0x001526F4 File Offset: 0x001508F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008038 RID: 32824 RVA: 0x00152700 File Offset: 0x00150900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ContentId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003106 RID: 12550
		private static readonly MessageParser<MonopolyGiveUpCurContentScRsp> _parser = new MessageParser<MonopolyGiveUpCurContentScRsp>(() => new MonopolyGiveUpCurContentScRsp());

		// Token: 0x04003107 RID: 12551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003108 RID: 12552
		public const int ContentIdFieldNumber = 15;

		// Token: 0x04003109 RID: 12553
		private uint contentId_;

		// Token: 0x0400310A RID: 12554
		public const int RetcodeFieldNumber = 7;

		// Token: 0x0400310B RID: 12555
		private uint retcode_;
	}
}
