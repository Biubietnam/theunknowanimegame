using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000151 RID: 337
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BuyNpcStuffScRsp : IMessage<BuyNpcStuffScRsp>, IMessage, IEquatable<BuyNpcStuffScRsp>, IDeepCloneable<BuyNpcStuffScRsp>, IBufferMessage
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x0002C7EC File Offset: 0x0002A9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuyNpcStuffScRsp> Parser
		{
			get
			{
				return BuyNpcStuffScRsp._parser;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x0002C7F3 File Offset: 0x0002A9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BuyNpcStuffScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x0002C805 File Offset: 0x0002AA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuyNpcStuffScRsp.Descriptor;
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0002C80C File Offset: 0x0002AA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyNpcStuffScRsp()
		{
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0002C814 File Offset: 0x0002AA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyNpcStuffScRsp(BuyNpcStuffScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.pOEDFMELAKE_ = other.pOEDFMELAKE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0002C845 File Offset: 0x0002AA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyNpcStuffScRsp Clone()
		{
			return new BuyNpcStuffScRsp(this);
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0002C84D File Offset: 0x0002AA4D
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x0002C855 File Offset: 0x0002AA55
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

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0002C85E File Offset: 0x0002AA5E
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x0002C866 File Offset: 0x0002AA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POEDFMELAKE
		{
			get
			{
				return this.pOEDFMELAKE_;
			}
			set
			{
				this.pOEDFMELAKE_ = value;
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0002C86F File Offset: 0x0002AA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuyNpcStuffScRsp);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0002C87D File Offset: 0x0002AA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuyNpcStuffScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.POEDFMELAKE == other.POEDFMELAKE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0002C8BC File Offset: 0x0002AABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.POEDFMELAKE != 0U)
			{
				num ^= this.POEDFMELAKE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0002C914 File Offset: 0x0002AB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0002C91C File Offset: 0x0002AB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0002C928 File Offset: 0x0002AB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.POEDFMELAKE != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.POEDFMELAKE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0002C984 File Offset: 0x0002AB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.POEDFMELAKE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POEDFMELAKE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0002C9DC File Offset: 0x0002ABDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuyNpcStuffScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.POEDFMELAKE != 0U)
			{
				this.POEDFMELAKE = other.POEDFMELAKE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0002CA2C File Offset: 0x0002AC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0002CA38 File Offset: 0x0002AC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.POEDFMELAKE = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400067F RID: 1663
		private static readonly MessageParser<BuyNpcStuffScRsp> _parser = new MessageParser<BuyNpcStuffScRsp>(() => new BuyNpcStuffScRsp());

		// Token: 0x04000680 RID: 1664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000681 RID: 1665
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04000682 RID: 1666
		private uint retcode_;

		// Token: 0x04000683 RID: 1667
		public const int POEDFMELAKEFieldNumber = 13;

		// Token: 0x04000684 RID: 1668
		private uint pOEDFMELAKE_;
	}
}
