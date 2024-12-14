using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000877 RID: 2167
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Goods : IMessage<Goods>, IMessage, IEquatable<Goods>, IDeepCloneable<Goods>, IBufferMessage
	{
		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06006053 RID: 24659 RVA: 0x000FEA65 File Offset: 0x000FCC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Goods> Parser
		{
			get
			{
				return Goods._parser;
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06006054 RID: 24660 RVA: 0x000FEA6C File Offset: 0x000FCC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GoodsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06006055 RID: 24661 RVA: 0x000FEA7E File Offset: 0x000FCC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Goods.Descriptor;
			}
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x000FEA85 File Offset: 0x000FCC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Goods()
		{
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x000FEA90 File Offset: 0x000FCC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Goods(Goods other) : this()
		{
			this.buyTimes_ = other.buyTimes_;
			this.beginTime_ = other.beginTime_;
			this.itemId_ = other.itemId_;
			this.goodsId_ = other.goodsId_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x000FEAF0 File Offset: 0x000FCCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Goods Clone()
		{
			return new Goods(this);
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x000FEAF8 File Offset: 0x000FCCF8
		// (set) Token: 0x0600605A RID: 24666 RVA: 0x000FEB00 File Offset: 0x000FCD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuyTimes
		{
			get
			{
				return this.buyTimes_;
			}
			set
			{
				this.buyTimes_ = value;
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x000FEB09 File Offset: 0x000FCD09
		// (set) Token: 0x0600605C RID: 24668 RVA: 0x000FEB11 File Offset: 0x000FCD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x0600605D RID: 24669 RVA: 0x000FEB1A File Offset: 0x000FCD1A
		// (set) Token: 0x0600605E RID: 24670 RVA: 0x000FEB22 File Offset: 0x000FCD22
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

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x0600605F RID: 24671 RVA: 0x000FEB2B File Offset: 0x000FCD2B
		// (set) Token: 0x06006060 RID: 24672 RVA: 0x000FEB33 File Offset: 0x000FCD33
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

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06006061 RID: 24673 RVA: 0x000FEB3C File Offset: 0x000FCD3C
		// (set) Token: 0x06006062 RID: 24674 RVA: 0x000FEB44 File Offset: 0x000FCD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x000FEB4D File Offset: 0x000FCD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Goods);
		}

		// Token: 0x06006064 RID: 24676 RVA: 0x000FEB5C File Offset: 0x000FCD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Goods other)
		{
			return other != null && (other == this || (this.BuyTimes == other.BuyTimes && this.BeginTime == other.BeginTime && this.ItemId == other.ItemId && this.GoodsId == other.GoodsId && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x000FEBD8 File Offset: 0x000FCDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuyTimes != 0U)
			{
				num ^= this.BuyTimes.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.GoodsId != 0U)
			{
				num ^= this.GoodsId.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x000FEC7B File Offset: 0x000FCE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x000FEC83 File Offset: 0x000FCE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006068 RID: 24680 RVA: 0x000FEC8C File Offset: 0x000FCE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuyTimes != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BuyTimes);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			if (this.GoodsId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.GoodsId);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ItemId);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.BeginTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x000FED38 File Offset: 0x000FCF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuyTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuyTimes);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.GoodsId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GoodsId);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x000FEDD8 File Offset: 0x000FCFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Goods other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuyTimes != 0U)
			{
				this.BuyTimes = other.BuyTimes;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.GoodsId != 0U)
			{
				this.GoodsId = other.GoodsId;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x000FEE64 File Offset: 0x000FD064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x000FEE70 File Offset: 0x000FD070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.BuyTimes = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.GoodsId = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ItemId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002507 RID: 9479
		private static readonly MessageParser<Goods> _parser = new MessageParser<Goods>(() => new Goods());

		// Token: 0x04002508 RID: 9480
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002509 RID: 9481
		public const int BuyTimesFieldNumber = 1;

		// Token: 0x0400250A RID: 9482
		private uint buyTimes_;

		// Token: 0x0400250B RID: 9483
		public const int BeginTimeFieldNumber = 11;

		// Token: 0x0400250C RID: 9484
		private long beginTime_;

		// Token: 0x0400250D RID: 9485
		public const int ItemIdFieldNumber = 8;

		// Token: 0x0400250E RID: 9486
		private uint itemId_;

		// Token: 0x0400250F RID: 9487
		public const int GoodsIdFieldNumber = 7;

		// Token: 0x04002510 RID: 9488
		private uint goodsId_;

		// Token: 0x04002511 RID: 9489
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04002512 RID: 9490
		private long endTime_;
	}
}
