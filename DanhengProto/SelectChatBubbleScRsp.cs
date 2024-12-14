using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010A1 RID: 4257
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectChatBubbleScRsp : IMessage<SelectChatBubbleScRsp>, IMessage, IEquatable<SelectChatBubbleScRsp>, IDeepCloneable<SelectChatBubbleScRsp>, IBufferMessage
	{
		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0600BDBA RID: 48570 RVA: 0x001FF20D File Offset: 0x001FD40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectChatBubbleScRsp> Parser
		{
			get
			{
				return SelectChatBubbleScRsp._parser;
			}
		}

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0600BDBB RID: 48571 RVA: 0x001FF214 File Offset: 0x001FD414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectChatBubbleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x0600BDBC RID: 48572 RVA: 0x001FF226 File Offset: 0x001FD426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectChatBubbleScRsp.Descriptor;
			}
		}

		// Token: 0x0600BDBD RID: 48573 RVA: 0x001FF22D File Offset: 0x001FD42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChatBubbleScRsp()
		{
		}

		// Token: 0x0600BDBE RID: 48574 RVA: 0x001FF235 File Offset: 0x001FD435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChatBubbleScRsp(SelectChatBubbleScRsp other) : this()
		{
			this.curChatBubble_ = other.curChatBubble_;
			this.mKPOIHGIHPC_ = other.mKPOIHGIHPC_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDBF RID: 48575 RVA: 0x001FF272 File Offset: 0x001FD472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChatBubbleScRsp Clone()
		{
			return new SelectChatBubbleScRsp(this);
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0600BDC0 RID: 48576 RVA: 0x001FF27A File Offset: 0x001FD47A
		// (set) Token: 0x0600BDC1 RID: 48577 RVA: 0x001FF282 File Offset: 0x001FD482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurChatBubble
		{
			get
			{
				return this.curChatBubble_;
			}
			set
			{
				this.curChatBubble_ = value;
			}
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0600BDC2 RID: 48578 RVA: 0x001FF28B File Offset: 0x001FD48B
		// (set) Token: 0x0600BDC3 RID: 48579 RVA: 0x001FF293 File Offset: 0x001FD493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MKPOIHGIHPC
		{
			get
			{
				return this.mKPOIHGIHPC_;
			}
			set
			{
				this.mKPOIHGIHPC_ = value;
			}
		}

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0600BDC4 RID: 48580 RVA: 0x001FF29C File Offset: 0x001FD49C
		// (set) Token: 0x0600BDC5 RID: 48581 RVA: 0x001FF2A4 File Offset: 0x001FD4A4
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

		// Token: 0x0600BDC6 RID: 48582 RVA: 0x001FF2AD File Offset: 0x001FD4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectChatBubbleScRsp);
		}

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x001FF2BC File Offset: 0x001FD4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectChatBubbleScRsp other)
		{
			return other != null && (other == this || (this.CurChatBubble == other.CurChatBubble && this.MKPOIHGIHPC == other.MKPOIHGIHPC && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDC8 RID: 48584 RVA: 0x001FF318 File Offset: 0x001FD518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurChatBubble != 0U)
			{
				num ^= this.CurChatBubble.GetHashCode();
			}
			if (this.MKPOIHGIHPC != 0U)
			{
				num ^= this.MKPOIHGIHPC.GetHashCode();
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

		// Token: 0x0600BDC9 RID: 48585 RVA: 0x001FF389 File Offset: 0x001FD589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BDCA RID: 48586 RVA: 0x001FF391 File Offset: 0x001FD591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDCB RID: 48587 RVA: 0x001FF39C File Offset: 0x001FD59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MKPOIHGIHPC != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MKPOIHGIHPC);
			}
			if (this.CurChatBubble != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.CurChatBubble);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BDCC RID: 48588 RVA: 0x001FF414 File Offset: 0x001FD614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurChatBubble != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurChatBubble);
			}
			if (this.MKPOIHGIHPC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MKPOIHGIHPC);
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

		// Token: 0x0600BDCD RID: 48589 RVA: 0x001FF484 File Offset: 0x001FD684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectChatBubbleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurChatBubble != 0U)
			{
				this.CurChatBubble = other.CurChatBubble;
			}
			if (other.MKPOIHGIHPC != 0U)
			{
				this.MKPOIHGIHPC = other.MKPOIHGIHPC;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BDCE RID: 48590 RVA: 0x001FF4E8 File Offset: 0x001FD6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDCF RID: 48591 RVA: 0x001FF4F4 File Offset: 0x001FD6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 96U)
					{
						if (num != 120U)
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
						this.CurChatBubble = input.ReadUInt32();
					}
				}
				else
				{
					this.MKPOIHGIHPC = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D1D RID: 19741
		private static readonly MessageParser<SelectChatBubbleScRsp> _parser = new MessageParser<SelectChatBubbleScRsp>(() => new SelectChatBubbleScRsp());

		// Token: 0x04004D1E RID: 19742
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D1F RID: 19743
		public const int CurChatBubbleFieldNumber = 12;

		// Token: 0x04004D20 RID: 19744
		private uint curChatBubble_;

		// Token: 0x04004D21 RID: 19745
		public const int MKPOIHGIHPCFieldNumber = 6;

		// Token: 0x04004D22 RID: 19746
		private uint mKPOIHGIHPC_;

		// Token: 0x04004D23 RID: 19747
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04004D24 RID: 19748
		private uint retcode_;
	}
}
