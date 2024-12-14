using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000ED RID: 237
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleOp : IMessage<BattleOp>, IMessage, IEquatable<BattleOp>, IDeepCloneable<BattleOp>, IBufferMessage
	{
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0001EE4B File Offset: 0x0001D04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleOp> Parser
		{
			get
			{
				return BattleOp._parser;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0001EE52 File Offset: 0x0001D052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleOpReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0001EE64 File Offset: 0x0001D064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleOp.Descriptor;
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0001EE6B File Offset: 0x0001D06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleOp()
		{
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0001EE80 File Offset: 0x0001D080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleOp(BattleOp other) : this()
		{
			this.turnCounter_ = other.turnCounter_;
			this.state_ = other.state_;
			this.actionEntityId_ = other.actionEntityId_;
			this.targetEntityId_ = other.targetEntityId_;
			this.opType_ = other.opType_;
			this.skillIndex_ = other.skillIndex_;
			this.operationCounter_ = other.operationCounter_;
			this.gPBKOBEPMCA_ = other.gPBKOBEPMCA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0001EF04 File Offset: 0x0001D104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleOp Clone()
		{
			return new BattleOp(this);
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0001EF0C File Offset: 0x0001D10C
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0001EF14 File Offset: 0x0001D114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TurnCounter
		{
			get
			{
				return this.turnCounter_;
			}
			set
			{
				this.turnCounter_ = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0001EF1D File Offset: 0x0001D11D
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x0001EF25 File Offset: 0x0001D125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0001EF2E File Offset: 0x0001D12E
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0001EF36 File Offset: 0x0001D136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ActionEntityId
		{
			get
			{
				return this.actionEntityId_;
			}
			set
			{
				this.actionEntityId_ = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0001EF3F File Offset: 0x0001D13F
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0001EF47 File Offset: 0x0001D147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetEntityId
		{
			get
			{
				return this.targetEntityId_;
			}
			set
			{
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0001EF50 File Offset: 0x0001D150
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x0001EF58 File Offset: 0x0001D158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OpType
		{
			get
			{
				return this.opType_;
			}
			set
			{
				this.opType_ = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0001EF61 File Offset: 0x0001D161
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x0001EF69 File Offset: 0x0001D169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillIndex
		{
			get
			{
				return this.skillIndex_;
			}
			set
			{
				this.skillIndex_ = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0001EF72 File Offset: 0x0001D172
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x0001EF7A File Offset: 0x0001D17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OperationCounter
		{
			get
			{
				return this.operationCounter_;
			}
			set
			{
				this.operationCounter_ = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0001EF83 File Offset: 0x0001D183
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x0001EF8B File Offset: 0x0001D18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GPBKOBEPMCA
		{
			get
			{
				return this.gPBKOBEPMCA_;
			}
			set
			{
				this.gPBKOBEPMCA_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0001EF9E File Offset: 0x0001D19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleOp);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0001EFAC File Offset: 0x0001D1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleOp other)
		{
			return other != null && (other == this || (this.TurnCounter == other.TurnCounter && this.State == other.State && this.ActionEntityId == other.ActionEntityId && this.TargetEntityId == other.TargetEntityId && this.OpType == other.OpType && this.SkillIndex == other.SkillIndex && this.OperationCounter == other.OperationCounter && !(this.GPBKOBEPMCA != other.GPBKOBEPMCA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0001F05C File Offset: 0x0001D25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TurnCounter != 0U)
			{
				num ^= this.TurnCounter.GetHashCode();
			}
			if (this.State != 0U)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.ActionEntityId != 0U)
			{
				num ^= this.ActionEntityId.GetHashCode();
			}
			if (this.TargetEntityId != 0U)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.OpType != 0U)
			{
				num ^= this.OpType.GetHashCode();
			}
			if (this.SkillIndex != 0U)
			{
				num ^= this.SkillIndex.GetHashCode();
			}
			if (this.OperationCounter != 0U)
			{
				num ^= this.OperationCounter.GetHashCode();
			}
			if (this.GPBKOBEPMCA.Length != 0)
			{
				num ^= this.GPBKOBEPMCA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0001F14C File Offset: 0x0001D34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0001F154 File Offset: 0x0001D354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0001F160 File Offset: 0x0001D360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TurnCounter != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TurnCounter);
			}
			if (this.State != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.State);
			}
			if (this.ActionEntityId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ActionEntityId);
			}
			if (this.TargetEntityId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.TargetEntityId);
			}
			if (this.OpType != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.OpType);
			}
			if (this.SkillIndex != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.SkillIndex);
			}
			if (this.OperationCounter != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.OperationCounter);
			}
			if (this.GPBKOBEPMCA.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.GPBKOBEPMCA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0001F268 File Offset: 0x0001D468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TurnCounter != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TurnCounter);
			}
			if (this.State != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.State);
			}
			if (this.ActionEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ActionEntityId);
			}
			if (this.TargetEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetEntityId);
			}
			if (this.OpType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OpType);
			}
			if (this.SkillIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillIndex);
			}
			if (this.OperationCounter != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OperationCounter);
			}
			if (this.GPBKOBEPMCA.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GPBKOBEPMCA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0001F354 File Offset: 0x0001D554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TurnCounter != 0U)
			{
				this.TurnCounter = other.TurnCounter;
			}
			if (other.State != 0U)
			{
				this.State = other.State;
			}
			if (other.ActionEntityId != 0U)
			{
				this.ActionEntityId = other.ActionEntityId;
			}
			if (other.TargetEntityId != 0U)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			if (other.OpType != 0U)
			{
				this.OpType = other.OpType;
			}
			if (other.SkillIndex != 0U)
			{
				this.SkillIndex = other.SkillIndex;
			}
			if (other.OperationCounter != 0U)
			{
				this.OperationCounter = other.OperationCounter;
			}
			if (other.GPBKOBEPMCA.Length != 0)
			{
				this.GPBKOBEPMCA = other.GPBKOBEPMCA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0001F421 File Offset: 0x0001D621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0001F42C File Offset: 0x0001D62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.TurnCounter = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.State = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.ActionEntityId = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.TargetEntityId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.OpType = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.SkillIndex = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.OperationCounter = input.ReadUInt32();
						continue;
					}
					if (num == 66U)
					{
						this.GPBKOBEPMCA = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400045A RID: 1114
		private static readonly MessageParser<BattleOp> _parser = new MessageParser<BattleOp>(() => new BattleOp());

		// Token: 0x0400045B RID: 1115
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400045C RID: 1116
		public const int TurnCounterFieldNumber = 1;

		// Token: 0x0400045D RID: 1117
		private uint turnCounter_;

		// Token: 0x0400045E RID: 1118
		public const int StateFieldNumber = 2;

		// Token: 0x0400045F RID: 1119
		private uint state_;

		// Token: 0x04000460 RID: 1120
		public const int ActionEntityIdFieldNumber = 3;

		// Token: 0x04000461 RID: 1121
		private uint actionEntityId_;

		// Token: 0x04000462 RID: 1122
		public const int TargetEntityIdFieldNumber = 4;

		// Token: 0x04000463 RID: 1123
		private uint targetEntityId_;

		// Token: 0x04000464 RID: 1124
		public const int OpTypeFieldNumber = 5;

		// Token: 0x04000465 RID: 1125
		private uint opType_;

		// Token: 0x04000466 RID: 1126
		public const int SkillIndexFieldNumber = 6;

		// Token: 0x04000467 RID: 1127
		private uint skillIndex_;

		// Token: 0x04000468 RID: 1128
		public const int OperationCounterFieldNumber = 7;

		// Token: 0x04000469 RID: 1129
		private uint operationCounter_;

		// Token: 0x0400046A RID: 1130
		public const int GPBKOBEPMCAFieldNumber = 8;

		// Token: 0x0400046B RID: 1131
		private string gPBKOBEPMCA_ = "";
	}
}
