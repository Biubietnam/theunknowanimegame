using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A8B RID: 2699
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MarkItemScRsp : IMessage<MarkItemScRsp>, IMessage, IEquatable<MarkItemScRsp>, IDeepCloneable<MarkItemScRsp>, IBufferMessage
	{
		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x060077A7 RID: 30631 RVA: 0x0013D4D0 File Offset: 0x0013B6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkItemScRsp> Parser
		{
			get
			{
				return MarkItemScRsp._parser;
			}
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x060077A8 RID: 30632 RVA: 0x0013D4D7 File Offset: 0x0013B6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MarkItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x060077A9 RID: 30633 RVA: 0x0013D4E9 File Offset: 0x0013B6E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkItemScRsp.Descriptor;
			}
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x0013D4F0 File Offset: 0x0013B6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkItemScRsp()
		{
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x0013D4F8 File Offset: 0x0013B6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkItemScRsp(MarkItemScRsp other) : this()
		{
			this.fBEHICBKCAM_ = other.fBEHICBKCAM_;
			this.itemId_ = other.itemId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x0013D535 File Offset: 0x0013B735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkItemScRsp Clone()
		{
			return new MarkItemScRsp(this);
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x060077AD RID: 30637 RVA: 0x0013D53D File Offset: 0x0013B73D
		// (set) Token: 0x060077AE RID: 30638 RVA: 0x0013D545 File Offset: 0x0013B745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FBEHICBKCAM
		{
			get
			{
				return this.fBEHICBKCAM_;
			}
			set
			{
				this.fBEHICBKCAM_ = value;
			}
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x060077AF RID: 30639 RVA: 0x0013D54E File Offset: 0x0013B74E
		// (set) Token: 0x060077B0 RID: 30640 RVA: 0x0013D556 File Offset: 0x0013B756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x060077B1 RID: 30641 RVA: 0x0013D55F File Offset: 0x0013B75F
		// (set) Token: 0x060077B2 RID: 30642 RVA: 0x0013D567 File Offset: 0x0013B767
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

		// Token: 0x060077B3 RID: 30643 RVA: 0x0013D570 File Offset: 0x0013B770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkItemScRsp);
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x0013D580 File Offset: 0x0013B780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkItemScRsp other)
		{
			return other != null && (other == this || (this.FBEHICBKCAM == other.FBEHICBKCAM && this.ItemId == other.ItemId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x0013D5DC File Offset: 0x0013B7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FBEHICBKCAM)
			{
				num ^= this.FBEHICBKCAM.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
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

		// Token: 0x060077B6 RID: 30646 RVA: 0x0013D64D File Offset: 0x0013B84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x0013D655 File Offset: 0x0013B855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x0013D660 File Offset: 0x0013B860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ItemId);
			}
			if (this.FBEHICBKCAM)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.FBEHICBKCAM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077B9 RID: 30649 RVA: 0x0013D6D8 File Offset: 0x0013B8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FBEHICBKCAM)
			{
				num += 2;
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
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

		// Token: 0x060077BA RID: 30650 RVA: 0x0013D73C File Offset: 0x0013B93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkItemScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FBEHICBKCAM)
			{
				this.FBEHICBKCAM = other.FBEHICBKCAM;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x0013D7A0 File Offset: 0x0013B9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x0013D7AC File Offset: 0x0013B9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FBEHICBKCAM = input.ReadBool();
						}
					}
					else
					{
						this.ItemId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002DEF RID: 11759
		private static readonly MessageParser<MarkItemScRsp> _parser = new MessageParser<MarkItemScRsp>(() => new MarkItemScRsp());

		// Token: 0x04002DF0 RID: 11760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DF1 RID: 11761
		public const int FBEHICBKCAMFieldNumber = 15;

		// Token: 0x04002DF2 RID: 11762
		private bool fBEHICBKCAM_;

		// Token: 0x04002DF3 RID: 11763
		public const int ItemIdFieldNumber = 3;

		// Token: 0x04002DF4 RID: 11764
		private uint itemId_;

		// Token: 0x04002DF5 RID: 11765
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04002DF6 RID: 11766
		private uint retcode_;
	}
}
