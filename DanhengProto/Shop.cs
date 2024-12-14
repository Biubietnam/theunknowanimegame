using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200114D RID: 4429
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Shop : IMessage<Shop>, IMessage, IEquatable<Shop>, IDeepCloneable<Shop>, IBufferMessage
	{
		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0600C594 RID: 50580 RVA: 0x002123C7 File Offset: 0x002105C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Shop> Parser
		{
			get
			{
				return Shop._parser;
			}
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0600C595 RID: 50581 RVA: 0x002123CE File Offset: 0x002105CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ShopReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0600C596 RID: 50582 RVA: 0x002123E0 File Offset: 0x002105E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Shop.Descriptor;
			}
		}

		// Token: 0x0600C597 RID: 50583 RVA: 0x002123E7 File Offset: 0x002105E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Shop()
		{
		}

		// Token: 0x0600C598 RID: 50584 RVA: 0x002123FC File Offset: 0x002105FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Shop(Shop other) : this()
		{
			this.shopId_ = other.shopId_;
			this.cityLevel_ = other.cityLevel_;
			this.beginTime_ = other.beginTime_;
			this.cityExp_ = other.cityExp_;
			this.endTime_ = other.endTime_;
			this.goodsList_ = other.goodsList_.Clone();
			this.cityTakenLevelReward_ = other.cityTakenLevelReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C599 RID: 50585 RVA: 0x00212479 File Offset: 0x00210679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Shop Clone()
		{
			return new Shop(this);
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0600C59A RID: 50586 RVA: 0x00212481 File Offset: 0x00210681
		// (set) Token: 0x0600C59B RID: 50587 RVA: 0x00212489 File Offset: 0x00210689
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

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0600C59C RID: 50588 RVA: 0x00212492 File Offset: 0x00210692
		// (set) Token: 0x0600C59D RID: 50589 RVA: 0x0021249A File Offset: 0x0021069A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CityLevel
		{
			get
			{
				return this.cityLevel_;
			}
			set
			{
				this.cityLevel_ = value;
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x0600C59E RID: 50590 RVA: 0x002124A3 File Offset: 0x002106A3
		// (set) Token: 0x0600C59F RID: 50591 RVA: 0x002124AB File Offset: 0x002106AB
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

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x0600C5A0 RID: 50592 RVA: 0x002124B4 File Offset: 0x002106B4
		// (set) Token: 0x0600C5A1 RID: 50593 RVA: 0x002124BC File Offset: 0x002106BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CityExp
		{
			get
			{
				return this.cityExp_;
			}
			set
			{
				this.cityExp_ = value;
			}
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0600C5A2 RID: 50594 RVA: 0x002124C5 File Offset: 0x002106C5
		// (set) Token: 0x0600C5A3 RID: 50595 RVA: 0x002124CD File Offset: 0x002106CD
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

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0600C5A4 RID: 50596 RVA: 0x002124D6 File Offset: 0x002106D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Goods> GoodsList
		{
			get
			{
				return this.goodsList_;
			}
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0600C5A5 RID: 50597 RVA: 0x002124DE File Offset: 0x002106DE
		// (set) Token: 0x0600C5A6 RID: 50598 RVA: 0x002124E6 File Offset: 0x002106E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong CityTakenLevelReward
		{
			get
			{
				return this.cityTakenLevelReward_;
			}
			set
			{
				this.cityTakenLevelReward_ = value;
			}
		}

		// Token: 0x0600C5A7 RID: 50599 RVA: 0x002124EF File Offset: 0x002106EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Shop);
		}

		// Token: 0x0600C5A8 RID: 50600 RVA: 0x00212500 File Offset: 0x00210700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Shop other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.CityLevel == other.CityLevel && this.BeginTime == other.BeginTime && this.CityExp == other.CityExp && this.EndTime == other.EndTime && this.goodsList_.Equals(other.goodsList_) && this.CityTakenLevelReward == other.CityTakenLevelReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5A9 RID: 50601 RVA: 0x002125A0 File Offset: 0x002107A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0U)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.CityLevel != 0U)
			{
				num ^= this.CityLevel.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.CityExp != 0U)
			{
				num ^= this.CityExp.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.goodsList_.GetHashCode();
			if (this.CityTakenLevelReward != 0UL)
			{
				num ^= this.CityTakenLevelReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C5AA RID: 50602 RVA: 0x0021266A File Offset: 0x0021086A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C5AB RID: 50603 RVA: 0x00212672 File Offset: 0x00210872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5AC RID: 50604 RVA: 0x0021267C File Offset: 0x0021087C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.BeginTime);
			}
			if (this.CityTakenLevelReward != 0UL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CityTakenLevelReward);
			}
			if (this.CityExp != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CityExp);
			}
			if (this.ShopId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ShopId);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EndTime);
			}
			this.goodsList_.WriteTo(ref output, Shop._repeated_goodsList_codec);
			if (this.CityLevel != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.CityLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5AD RID: 50605 RVA: 0x00212758 File Offset: 0x00210958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShopId);
			}
			if (this.CityLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CityLevel);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.CityExp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CityExp);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.goodsList_.CalculateSize(Shop._repeated_goodsList_codec);
			if (this.CityTakenLevelReward != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CityTakenLevelReward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C5AE RID: 50606 RVA: 0x00212824 File Offset: 0x00210A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Shop other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0U)
			{
				this.ShopId = other.ShopId;
			}
			if (other.CityLevel != 0U)
			{
				this.CityLevel = other.CityLevel;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.CityExp != 0U)
			{
				this.CityExp = other.CityExp;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.goodsList_.Add(other.goodsList_);
			if (other.CityTakenLevelReward != 0UL)
			{
				this.CityTakenLevelReward = other.CityTakenLevelReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C5AF RID: 50607 RVA: 0x002128D5 File Offset: 0x00210AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5B0 RID: 50608 RVA: 0x002128E0 File Offset: 0x00210AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.CityTakenLevelReward = input.ReadUInt64();
						continue;
					}
					if (num == 48U)
					{
						this.CityExp = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 56U)
					{
						this.ShopId = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.goodsList_.AddEntriesFrom(ref input, Shop._repeated_goodsList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.CityLevel = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004FC7 RID: 20423
		private static readonly MessageParser<Shop> _parser = new MessageParser<Shop>(() => new Shop());

		// Token: 0x04004FC8 RID: 20424
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FC9 RID: 20425
		public const int ShopIdFieldNumber = 7;

		// Token: 0x04004FCA RID: 20426
		private uint shopId_;

		// Token: 0x04004FCB RID: 20427
		public const int CityLevelFieldNumber = 15;

		// Token: 0x04004FCC RID: 20428
		private uint cityLevel_;

		// Token: 0x04004FCD RID: 20429
		public const int BeginTimeFieldNumber = 4;

		// Token: 0x04004FCE RID: 20430
		private long beginTime_;

		// Token: 0x04004FCF RID: 20431
		public const int CityExpFieldNumber = 6;

		// Token: 0x04004FD0 RID: 20432
		private uint cityExp_;

		// Token: 0x04004FD1 RID: 20433
		public const int EndTimeFieldNumber = 10;

		// Token: 0x04004FD2 RID: 20434
		private long endTime_;

		// Token: 0x04004FD3 RID: 20435
		public const int GoodsListFieldNumber = 13;

		// Token: 0x04004FD4 RID: 20436
		private static readonly FieldCodec<Goods> _repeated_goodsList_codec = FieldCodec.ForMessage<Goods>(106U, Goods.Parser);

		// Token: 0x04004FD5 RID: 20437
		private readonly RepeatedField<Goods> goodsList_ = new RepeatedField<Goods>();

		// Token: 0x04004FD6 RID: 20438
		public const int CityTakenLevelRewardFieldNumber = 5;

		// Token: 0x04004FD7 RID: 20439
		private ulong cityTakenLevelReward_;
	}
}
