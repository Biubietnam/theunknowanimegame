using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010B9 RID: 4281
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SellItemScRsp : IMessage<SellItemScRsp>, IMessage, IEquatable<SellItemScRsp>, IDeepCloneable<SellItemScRsp>, IBufferMessage
	{
		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0600BEE5 RID: 48869 RVA: 0x0020224D File Offset: 0x0020044D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SellItemScRsp> Parser
		{
			get
			{
				return SellItemScRsp._parser;
			}
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0600BEE6 RID: 48870 RVA: 0x00202254 File Offset: 0x00200454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SellItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0600BEE7 RID: 48871 RVA: 0x00202266 File Offset: 0x00200466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SellItemScRsp.Descriptor;
			}
		}

		// Token: 0x0600BEE8 RID: 48872 RVA: 0x0020226D File Offset: 0x0020046D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SellItemScRsp()
		{
		}

		// Token: 0x0600BEE9 RID: 48873 RVA: 0x00202278 File Offset: 0x00200478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SellItemScRsp(SellItemScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.returnItemList_ = ((other.returnItemList_ != null) ? other.returnItemList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BEEA RID: 48874 RVA: 0x002022C4 File Offset: 0x002004C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SellItemScRsp Clone()
		{
			return new SellItemScRsp(this);
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0600BEEB RID: 48875 RVA: 0x002022CC File Offset: 0x002004CC
		// (set) Token: 0x0600BEEC RID: 48876 RVA: 0x002022D4 File Offset: 0x002004D4
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

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0600BEED RID: 48877 RVA: 0x002022DD File Offset: 0x002004DD
		// (set) Token: 0x0600BEEE RID: 48878 RVA: 0x002022E5 File Offset: 0x002004E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ReturnItemList
		{
			get
			{
				return this.returnItemList_;
			}
			set
			{
				this.returnItemList_ = value;
			}
		}

		// Token: 0x0600BEEF RID: 48879 RVA: 0x002022EE File Offset: 0x002004EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SellItemScRsp);
		}

		// Token: 0x0600BEF0 RID: 48880 RVA: 0x002022FC File Offset: 0x002004FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SellItemScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.ReturnItemList, other.ReturnItemList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEF1 RID: 48881 RVA: 0x0020234C File Offset: 0x0020054C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.returnItemList_ != null)
			{
				num ^= this.ReturnItemList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BEF2 RID: 48882 RVA: 0x002023A1 File Offset: 0x002005A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BEF3 RID: 48883 RVA: 0x002023A9 File Offset: 0x002005A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEF4 RID: 48884 RVA: 0x002023B4 File Offset: 0x002005B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.returnItemList_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ReturnItemList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BEF5 RID: 48885 RVA: 0x00202410 File Offset: 0x00200610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.returnItemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReturnItemList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BEF6 RID: 48886 RVA: 0x00202468 File Offset: 0x00200668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SellItemScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.returnItemList_ != null)
			{
				if (this.returnItemList_ == null)
				{
					this.ReturnItemList = new ItemList();
				}
				this.ReturnItemList.MergeFrom(other.ReturnItemList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BEF7 RID: 48887 RVA: 0x002024D0 File Offset: 0x002006D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEF8 RID: 48888 RVA: 0x002024DC File Offset: 0x002006DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.returnItemList_ == null)
						{
							this.ReturnItemList = new ItemList();
						}
						input.ReadMessage(this.ReturnItemList);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D8A RID: 19850
		private static readonly MessageParser<SellItemScRsp> _parser = new MessageParser<SellItemScRsp>(() => new SellItemScRsp());

		// Token: 0x04004D8B RID: 19851
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D8C RID: 19852
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04004D8D RID: 19853
		private uint retcode_;

		// Token: 0x04004D8E RID: 19854
		public const int ReturnItemListFieldNumber = 11;

		// Token: 0x04004D8F RID: 19855
		private ItemList returnItemList_;
	}
}
