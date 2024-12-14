using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000E3 RID: 227
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleEquipment : IMessage<BattleEquipment>, IMessage, IEquatable<BattleEquipment>, IDeepCloneable<BattleEquipment>, IBufferMessage
	{
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0001DD55 File Offset: 0x0001BF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleEquipment> Parser
		{
			get
			{
				return BattleEquipment._parser;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0001DD5C File Offset: 0x0001BF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleEquipmentReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0001DD6E File Offset: 0x0001BF6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleEquipment.Descriptor;
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0001DD75 File Offset: 0x0001BF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEquipment()
		{
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0001DD80 File Offset: 0x0001BF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEquipment(BattleEquipment other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.promotion_ = other.promotion_;
			this.rank_ = other.rank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0001DDD4 File Offset: 0x0001BFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEquipment Clone()
		{
			return new BattleEquipment(this);
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0001DDDC File Offset: 0x0001BFDC
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x0001DDE4 File Offset: 0x0001BFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0001DDED File Offset: 0x0001BFED
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x0001DDF5 File Offset: 0x0001BFF5
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

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0001DDFE File Offset: 0x0001BFFE
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x0001DE06 File Offset: 0x0001C006
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0001DE0F File Offset: 0x0001C00F
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x0001DE17 File Offset: 0x0001C017
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

		// Token: 0x06000A18 RID: 2584 RVA: 0x0001DE20 File Offset: 0x0001C020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleEquipment);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0001DE30 File Offset: 0x0001C030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleEquipment other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.Promotion == other.Promotion && this.Rank == other.Rank && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0001DE9C File Offset: 0x0001C09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0001DF26 File Offset: 0x0001C126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0001DF2E File Offset: 0x0001C12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0001DF38 File Offset: 0x0001C138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Promotion);
			}
			if (this.Rank != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Rank);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0001DFC8 File Offset: 0x0001C1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0001E050 File Offset: 0x0001C250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleEquipment other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0001E0C8 File Offset: 0x0001C2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0001E0D4 File Offset: 0x0001C2D4
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
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Rank = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000436 RID: 1078
		private static readonly MessageParser<BattleEquipment> _parser = new MessageParser<BattleEquipment>(() => new BattleEquipment());

		// Token: 0x04000437 RID: 1079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000438 RID: 1080
		public const int IdFieldNumber = 1;

		// Token: 0x04000439 RID: 1081
		private uint id_;

		// Token: 0x0400043A RID: 1082
		public const int LevelFieldNumber = 2;

		// Token: 0x0400043B RID: 1083
		private uint level_;

		// Token: 0x0400043C RID: 1084
		public const int PromotionFieldNumber = 3;

		// Token: 0x0400043D RID: 1085
		private uint promotion_;

		// Token: 0x0400043E RID: 1086
		public const int RankFieldNumber = 4;

		// Token: 0x0400043F RID: 1087
		private uint rank_;
	}
}
