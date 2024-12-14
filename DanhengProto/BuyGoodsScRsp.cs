using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200014D RID: 333
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BuyGoodsScRsp : IMessage<BuyGoodsScRsp>, IMessage, IEquatable<BuyGoodsScRsp>, IDeepCloneable<BuyGoodsScRsp>, IBufferMessage
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x0002BFFF File Offset: 0x0002A1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuyGoodsScRsp> Parser
		{
			get
			{
				return BuyGoodsScRsp._parser;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x0002C006 File Offset: 0x0002A206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BuyGoodsScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0002C018 File Offset: 0x0002A218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuyGoodsScRsp.Descriptor;
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0002C01F File Offset: 0x0002A21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyGoodsScRsp()
		{
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0002C028 File Offset: 0x0002A228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyGoodsScRsp(BuyGoodsScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.shopId_ = other.shopId_;
			this.goodsId_ = other.goodsId_;
			this.goodsBuyTimes_ = other.goodsBuyTimes_;
			this.returnItemList_ = ((other.returnItemList_ != null) ? other.returnItemList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0002C098 File Offset: 0x0002A298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyGoodsScRsp Clone()
		{
			return new BuyGoodsScRsp(this);
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x0002C0A0 File Offset: 0x0002A2A0
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x0002C0A8 File Offset: 0x0002A2A8
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

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0002C0B1 File Offset: 0x0002A2B1
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x0002C0B9 File Offset: 0x0002A2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0002C0C2 File Offset: 0x0002A2C2
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x0002C0CA File Offset: 0x0002A2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GoodsId
		{
			get
			{
				return this.goodsId_;
			}
			set
			{
				this.goodsId_ = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0002C0D3 File Offset: 0x0002A2D3
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x0002C0DB File Offset: 0x0002A2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GoodsBuyTimes
		{
			get
			{
				return this.goodsBuyTimes_;
			}
			set
			{
				this.goodsBuyTimes_ = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0002C0E4 File Offset: 0x0002A2E4
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x0002C0EC File Offset: 0x0002A2EC
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

		// Token: 0x06000EED RID: 3821 RVA: 0x0002C0F5 File Offset: 0x0002A2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuyGoodsScRsp);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0002C104 File Offset: 0x0002A304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuyGoodsScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.ShopId == other.ShopId && this.GoodsId == other.GoodsId && this.GoodsBuyTimes == other.GoodsBuyTimes && object.Equals(this.ReturnItemList, other.ReturnItemList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0002C184 File Offset: 0x0002A384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ShopId != 0U)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.GoodsId != 0U)
			{
				num ^= this.GoodsId.GetHashCode();
			}
			if (this.GoodsBuyTimes != 0U)
			{
				num ^= this.GoodsBuyTimes.GetHashCode();
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

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0002C224 File Offset: 0x0002A424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0002C22C File Offset: 0x0002A42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0002C238 File Offset: 0x0002A438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GoodsBuyTimes != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GoodsBuyTimes);
			}
			if (this.ShopId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ShopId);
			}
			if (this.returnItemList_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ReturnItemList);
			}
			if (this.GoodsId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GoodsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0002C2E8 File Offset: 0x0002A4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShopId);
			}
			if (this.GoodsId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GoodsId);
			}
			if (this.GoodsBuyTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GoodsBuyTimes);
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

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0002C388 File Offset: 0x0002A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuyGoodsScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ShopId != 0U)
			{
				this.ShopId = other.ShopId;
			}
			if (other.GoodsId != 0U)
			{
				this.GoodsId = other.GoodsId;
			}
			if (other.GoodsBuyTimes != 0U)
			{
				this.GoodsBuyTimes = other.GoodsBuyTimes;
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

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0002C42C File Offset: 0x0002A62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0002C438 File Offset: 0x0002A638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.GoodsBuyTimes = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.ShopId = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.returnItemList_ == null)
						{
							this.ReturnItemList = new ItemList();
						}
						input.ReadMessage(this.ReturnItemList);
						continue;
					}
					if (num == 104U)
					{
						this.GoodsId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400066D RID: 1645
		private static readonly MessageParser<BuyGoodsScRsp> _parser = new MessageParser<BuyGoodsScRsp>(() => new BuyGoodsScRsp());

		// Token: 0x0400066E RID: 1646
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400066F RID: 1647
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04000670 RID: 1648
		private uint retcode_;

		// Token: 0x04000671 RID: 1649
		public const int ShopIdFieldNumber = 6;

		// Token: 0x04000672 RID: 1650
		private uint shopId_;

		// Token: 0x04000673 RID: 1651
		public const int GoodsIdFieldNumber = 13;

		// Token: 0x04000674 RID: 1652
		private uint goodsId_;

		// Token: 0x04000675 RID: 1653
		public const int GoodsBuyTimesFieldNumber = 3;

		// Token: 0x04000676 RID: 1654
		private uint goodsBuyTimes_;

		// Token: 0x04000677 RID: 1655
		public const int ReturnItemListFieldNumber = 7;

		// Token: 0x04000678 RID: 1656
		private ItemList returnItemList_;
	}
}
