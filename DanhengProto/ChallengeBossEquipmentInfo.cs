using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000197 RID: 407
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBossEquipmentInfo : IMessage<ChallengeBossEquipmentInfo>, IMessage, IEquatable<ChallengeBossEquipmentInfo>, IDeepCloneable<ChallengeBossEquipmentInfo>, IBufferMessage
	{
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x000343DF File Offset: 0x000325DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBossEquipmentInfo> Parser
		{
			get
			{
				return ChallengeBossEquipmentInfo._parser;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x000343E6 File Offset: 0x000325E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBossEquipmentInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x000343F8 File Offset: 0x000325F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBossEquipmentInfo.Descriptor;
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x000343FF File Offset: 0x000325FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossEquipmentInfo()
		{
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00034408 File Offset: 0x00032608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossEquipmentInfo(ChallengeBossEquipmentInfo other) : this()
		{
			this.uniqueId_ = other.uniqueId_;
			this.level_ = other.level_;
			this.promotion_ = other.promotion_;
			this.rank_ = other.rank_;
			this.tid_ = other.tid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00034468 File Offset: 0x00032668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossEquipmentInfo Clone()
		{
			return new ChallengeBossEquipmentInfo(this);
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00034470 File Offset: 0x00032670
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x00034478 File Offset: 0x00032678
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

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00034481 File Offset: 0x00032681
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x00034489 File Offset: 0x00032689
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

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00034492 File Offset: 0x00032692
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x0003449A File Offset: 0x0003269A
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

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x000344A3 File Offset: 0x000326A3
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x000344AB File Offset: 0x000326AB
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

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x000344B4 File Offset: 0x000326B4
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x000344BC File Offset: 0x000326BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Tid
		{
			get
			{
				return this.tid_;
			}
			set
			{
				this.tid_ = value;
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000344C5 File Offset: 0x000326C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBossEquipmentInfo);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000344D4 File Offset: 0x000326D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBossEquipmentInfo other)
		{
			return other != null && (other == this || (this.UniqueId == other.UniqueId && this.Level == other.Level && this.Promotion == other.Promotion && this.Rank == other.Rank && this.Tid == other.Tid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00034550 File Offset: 0x00032750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UniqueId != 0U)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x000345F3 File Offset: 0x000327F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000345FB File Offset: 0x000327FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00034604 File Offset: 0x00032804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Tid != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Tid);
			}
			if (this.UniqueId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.UniqueId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Level);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Promotion);
			}
			if (this.Rank != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Rank);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000346B0 File Offset: 0x000328B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UniqueId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00034750 File Offset: 0x00032950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBossEquipmentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UniqueId != 0U)
			{
				this.UniqueId = other.UniqueId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x000347DC File Offset: 0x000329DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x000347E8 File Offset: 0x000329E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Tid = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.UniqueId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Rank = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400079D RID: 1949
		private static readonly MessageParser<ChallengeBossEquipmentInfo> _parser = new MessageParser<ChallengeBossEquipmentInfo>(() => new ChallengeBossEquipmentInfo());

		// Token: 0x0400079E RID: 1950
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400079F RID: 1951
		public const int UniqueIdFieldNumber = 2;

		// Token: 0x040007A0 RID: 1952
		private uint uniqueId_;

		// Token: 0x040007A1 RID: 1953
		public const int LevelFieldNumber = 4;

		// Token: 0x040007A2 RID: 1954
		private uint level_;

		// Token: 0x040007A3 RID: 1955
		public const int PromotionFieldNumber = 10;

		// Token: 0x040007A4 RID: 1956
		private uint promotion_;

		// Token: 0x040007A5 RID: 1957
		public const int RankFieldNumber = 14;

		// Token: 0x040007A6 RID: 1958
		private uint rank_;

		// Token: 0x040007A7 RID: 1959
		public const int TidFieldNumber = 1;

		// Token: 0x040007A8 RID: 1960
		private uint tid_;
	}
}
