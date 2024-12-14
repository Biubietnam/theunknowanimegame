using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200014B RID: 331
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BuyGoodsCsReq : IMessage<BuyGoodsCsReq>, IMessage, IEquatable<BuyGoodsCsReq>, IDeepCloneable<BuyGoodsCsReq>, IBufferMessage
	{
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0002BA87 File Offset: 0x00029C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuyGoodsCsReq> Parser
		{
			get
			{
				return BuyGoodsCsReq._parser;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0002BA8E File Offset: 0x00029C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BuyGoodsCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0002BAA0 File Offset: 0x00029CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuyGoodsCsReq.Descriptor;
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0002BAA7 File Offset: 0x00029CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyGoodsCsReq()
		{
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0002BAB0 File Offset: 0x00029CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyGoodsCsReq(BuyGoodsCsReq other) : this()
		{
			this.goodsId_ = other.goodsId_;
			this.itemId_ = other.itemId_;
			this.goodsNum_ = other.goodsNum_;
			this.shopId_ = other.shopId_;
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0002BB10 File Offset: 0x00029D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyGoodsCsReq Clone()
		{
			return new BuyGoodsCsReq(this);
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0002BB18 File Offset: 0x00029D18
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x0002BB20 File Offset: 0x00029D20
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

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0002BB29 File Offset: 0x00029D29
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x0002BB31 File Offset: 0x00029D31
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

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0002BB3A File Offset: 0x00029D3A
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x0002BB42 File Offset: 0x00029D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GoodsNum
		{
			get
			{
				return this.goodsNum_;
			}
			set
			{
				this.goodsNum_ = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0002BB4B File Offset: 0x00029D4B
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x0002BB53 File Offset: 0x00029D53
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

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0002BB5C File Offset: 0x00029D5C
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x0002BB64 File Offset: 0x00029D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0002BB6D File Offset: 0x00029D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuyGoodsCsReq);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0002BB7C File Offset: 0x00029D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuyGoodsCsReq other)
		{
			return other != null && (other == this || (this.GoodsId == other.GoodsId && this.ItemId == other.ItemId && this.GoodsNum == other.GoodsNum && this.ShopId == other.ShopId && this.InteractedPropEntityId == other.InteractedPropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0002BBF8 File Offset: 0x00029DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GoodsId != 0U)
			{
				num ^= this.GoodsId.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.GoodsNum != 0U)
			{
				num ^= this.GoodsNum.GetHashCode();
			}
			if (this.ShopId != 0U)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0002BC9B File Offset: 0x00029E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0002BCA3 File Offset: 0x00029EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0002BCAC File Offset: 0x00029EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ShopId);
			}
			if (this.GoodsNum != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GoodsNum);
			}
			if (this.GoodsId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.GoodsId);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ItemId);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0002BD5C File Offset: 0x00029F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GoodsId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GoodsId);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.GoodsNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GoodsNum);
			}
			if (this.ShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShopId);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0002BDFC File Offset: 0x00029FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuyGoodsCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GoodsId != 0U)
			{
				this.GoodsId = other.GoodsId;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.GoodsNum != 0U)
			{
				this.GoodsNum = other.GoodsNum;
			}
			if (other.ShopId != 0U)
			{
				this.ShopId = other.ShopId;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0002BE88 File Offset: 0x0002A088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0002BE94 File Offset: 0x0002A094
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
						this.ShopId = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.GoodsNum = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.GoodsId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ItemId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.InteractedPropEntityId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000660 RID: 1632
		private static readonly MessageParser<BuyGoodsCsReq> _parser = new MessageParser<BuyGoodsCsReq>(() => new BuyGoodsCsReq());

		// Token: 0x04000661 RID: 1633
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000662 RID: 1634
		public const int GoodsIdFieldNumber = 10;

		// Token: 0x04000663 RID: 1635
		private uint goodsId_;

		// Token: 0x04000664 RID: 1636
		public const int ItemIdFieldNumber = 12;

		// Token: 0x04000665 RID: 1637
		private uint itemId_;

		// Token: 0x04000666 RID: 1638
		public const int GoodsNumFieldNumber = 3;

		// Token: 0x04000667 RID: 1639
		private uint goodsNum_;

		// Token: 0x04000668 RID: 1640
		public const int ShopIdFieldNumber = 2;

		// Token: 0x04000669 RID: 1641
		private uint shopId_;

		// Token: 0x0400066A RID: 1642
		public const int InteractedPropEntityIdFieldNumber = 15;

		// Token: 0x0400066B RID: 1643
		private uint interactedPropEntityId_;
	}
}
