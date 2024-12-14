using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000153 RID: 339
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BuyRogueShopBuffScRsp : IMessage<BuyRogueShopBuffScRsp>, IMessage, IEquatable<BuyRogueShopBuffScRsp>, IDeepCloneable<BuyRogueShopBuffScRsp>, IBufferMessage
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x0002CB2D File Offset: 0x0002AD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuyRogueShopBuffScRsp> Parser
		{
			get
			{
				return BuyRogueShopBuffScRsp._parser;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0002CB34 File Offset: 0x0002AD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BuyRogueShopBuffScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x0002CB46 File Offset: 0x0002AD46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuyRogueShopBuffScRsp.Descriptor;
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0002CB4D File Offset: 0x0002AD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyRogueShopBuffScRsp()
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0002CB58 File Offset: 0x0002AD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyRogueShopBuffScRsp(BuyRogueShopBuffScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueBuffInfo_ = ((other.rogueBuffInfo_ != null) ? other.rogueBuffInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0002CBA4 File Offset: 0x0002ADA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyRogueShopBuffScRsp Clone()
		{
			return new BuyRogueShopBuffScRsp(this);
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x0002CBAC File Offset: 0x0002ADAC
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x0002CBB4 File Offset: 0x0002ADB4
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

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x0002CBBD File Offset: 0x0002ADBD
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x0002CBC5 File Offset: 0x0002ADC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JFKLIEHKDDE RogueBuffInfo
		{
			get
			{
				return this.rogueBuffInfo_;
			}
			set
			{
				this.rogueBuffInfo_ = value;
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0002CBCE File Offset: 0x0002ADCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuyRogueShopBuffScRsp);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0002CBDC File Offset: 0x0002ADDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuyRogueShopBuffScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueBuffInfo, other.RogueBuffInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0002CC2C File Offset: 0x0002AE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueBuffInfo_ != null)
			{
				num ^= this.RogueBuffInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0002CC81 File Offset: 0x0002AE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0002CC89 File Offset: 0x0002AE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0002CC94 File Offset: 0x0002AE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueBuffInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueBuffInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0002CCEC File Offset: 0x0002AEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuffInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0002CD44 File Offset: 0x0002AF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuyRogueShopBuffScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueBuffInfo_ != null)
			{
				if (this.rogueBuffInfo_ == null)
				{
					this.RogueBuffInfo = new JFKLIEHKDDE();
				}
				this.RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0002CDAC File Offset: 0x0002AFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0002CDB8 File Offset: 0x0002AFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueBuffInfo_ == null)
						{
							this.RogueBuffInfo = new JFKLIEHKDDE();
						}
						input.ReadMessage(this.RogueBuffInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000686 RID: 1670
		private static readonly MessageParser<BuyRogueShopBuffScRsp> _parser = new MessageParser<BuyRogueShopBuffScRsp>(() => new BuyRogueShopBuffScRsp());

		// Token: 0x04000687 RID: 1671
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000688 RID: 1672
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04000689 RID: 1673
		private uint retcode_;

		// Token: 0x0400068A RID: 1674
		public const int RogueBuffInfoFieldNumber = 13;

		// Token: 0x0400068B RID: 1675
		private JFKLIEHKDDE rogueBuffInfo_;
	}
}
