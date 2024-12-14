using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000949 RID: 2377
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Item : IMessage<Item>, IMessage, IEquatable<Item>, IDeepCloneable<Item>, IBufferMessage
	{
		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x06006A1D RID: 27165 RVA: 0x0011B345 File Offset: 0x00119545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Item> Parser
		{
			get
			{
				return Item._parser;
			}
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x06006A1E RID: 27166 RVA: 0x0011B34C File Offset: 0x0011954C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x06006A1F RID: 27167 RVA: 0x0011B35E File Offset: 0x0011955E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Item.Descriptor;
			}
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x0011B365 File Offset: 0x00119565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Item()
		{
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x0011B370 File Offset: 0x00119570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Item(Item other) : this()
		{
			this.promotion_ = other.promotion_;
			this.level_ = other.level_;
			this.num_ = other.num_;
			this.rank_ = other.rank_;
			this.uniqueId_ = other.uniqueId_;
			this.mainAffixId_ = other.mainAffixId_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x0011B3E8 File Offset: 0x001195E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Item Clone()
		{
			return new Item(this);
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x06006A23 RID: 27171 RVA: 0x0011B3F0 File Offset: 0x001195F0
		// (set) Token: 0x06006A24 RID: 27172 RVA: 0x0011B3F8 File Offset: 0x001195F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Promotion
		{
			get
			{
				return this.promotion_;
			}
			set
			{
				this.promotion_ = value;
			}
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x06006A25 RID: 27173 RVA: 0x0011B401 File Offset: 0x00119601
		// (set) Token: 0x06006A26 RID: 27174 RVA: 0x0011B409 File Offset: 0x00119609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06006A27 RID: 27175 RVA: 0x0011B412 File Offset: 0x00119612
		// (set) Token: 0x06006A28 RID: 27176 RVA: 0x0011B41A File Offset: 0x0011961A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06006A29 RID: 27177 RVA: 0x0011B423 File Offset: 0x00119623
		// (set) Token: 0x06006A2A RID: 27178 RVA: 0x0011B42B File Offset: 0x0011962B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06006A2B RID: 27179 RVA: 0x0011B434 File Offset: 0x00119634
		// (set) Token: 0x06006A2C RID: 27180 RVA: 0x0011B43C File Offset: 0x0011963C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x06006A2D RID: 27181 RVA: 0x0011B445 File Offset: 0x00119645
		// (set) Token: 0x06006A2E RID: 27182 RVA: 0x0011B44D File Offset: 0x0011964D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainAffixId
		{
			get
			{
				return this.mainAffixId_;
			}
			set
			{
				this.mainAffixId_ = value;
			}
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x06006A2F RID: 27183 RVA: 0x0011B456 File Offset: 0x00119656
		// (set) Token: 0x06006A30 RID: 27184 RVA: 0x0011B45E File Offset: 0x0011965E
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

		// Token: 0x06006A31 RID: 27185 RVA: 0x0011B467 File Offset: 0x00119667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Item);
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x0011B478 File Offset: 0x00119678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Item other)
		{
			return other != null && (other == this || (this.Promotion == other.Promotion && this.Level == other.Level && this.Num == other.Num && this.Rank == other.Rank && this.UniqueId == other.UniqueId && this.MainAffixId == other.MainAffixId && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x0011B514 File Offset: 0x00119714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.UniqueId != 0U)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this.MainAffixId != 0U)
			{
				num ^= this.MainAffixId.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x0011B5E9 File Offset: 0x001197E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x0011B5F1 File Offset: 0x001197F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x0011B5FC File Offset: 0x001197FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Promotion);
			}
			if (this.UniqueId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.UniqueId);
			}
			if (this.MainAffixId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MainAffixId);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ItemId);
			}
			if (this.Num != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Num);
			}
			if (this.Rank != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Rank);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x0011B6E4 File Offset: 0x001198E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.UniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UniqueId);
			}
			if (this.MainAffixId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainAffixId);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A38 RID: 27192 RVA: 0x0011B7B4 File Offset: 0x001199B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Item other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.UniqueId != 0U)
			{
				this.UniqueId = other.UniqueId;
			}
			if (other.MainAffixId != 0U)
			{
				this.MainAffixId = other.MainAffixId;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A39 RID: 27193 RVA: 0x0011B868 File Offset: 0x00119A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x0011B874 File Offset: 0x00119A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 32U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.UniqueId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.MainAffixId = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.ItemId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Num = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Rank = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040028A5 RID: 10405
		private static readonly MessageParser<Item> _parser = new MessageParser<Item>(() => new Item());

		// Token: 0x040028A6 RID: 10406
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028A7 RID: 10407
		public const int PromotionFieldNumber = 4;

		// Token: 0x040028A8 RID: 10408
		private uint promotion_;

		// Token: 0x040028A9 RID: 10409
		public const int LevelFieldNumber = 14;

		// Token: 0x040028AA RID: 10410
		private uint level_;

		// Token: 0x040028AB RID: 10411
		public const int NumFieldNumber = 11;

		// Token: 0x040028AC RID: 10412
		private uint num_;

		// Token: 0x040028AD RID: 10413
		public const int RankFieldNumber = 13;

		// Token: 0x040028AE RID: 10414
		private uint rank_;

		// Token: 0x040028AF RID: 10415
		public const int UniqueIdFieldNumber = 7;

		// Token: 0x040028B0 RID: 10416
		private uint uniqueId_;

		// Token: 0x040028B1 RID: 10417
		public const int MainAffixIdFieldNumber = 9;

		// Token: 0x040028B2 RID: 10418
		private uint mainAffixId_;

		// Token: 0x040028B3 RID: 10419
		public const int ItemIdFieldNumber = 10;

		// Token: 0x040028B4 RID: 10420
		private uint itemId_;
	}
}
