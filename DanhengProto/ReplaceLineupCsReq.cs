using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DB9 RID: 3513
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReplaceLineupCsReq : IMessage<ReplaceLineupCsReq>, IMessage, IEquatable<ReplaceLineupCsReq>, IDeepCloneable<ReplaceLineupCsReq>, IBufferMessage
	{
		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x06009D11 RID: 40209 RVA: 0x001A265B File Offset: 0x001A085B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReplaceLineupCsReq> Parser
		{
			get
			{
				return ReplaceLineupCsReq._parser;
			}
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x06009D12 RID: 40210 RVA: 0x001A2662 File Offset: 0x001A0862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReplaceLineupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x06009D13 RID: 40211 RVA: 0x001A2674 File Offset: 0x001A0874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReplaceLineupCsReq.Descriptor;
			}
		}

		// Token: 0x06009D14 RID: 40212 RVA: 0x001A267B File Offset: 0x001A087B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceLineupCsReq()
		{
		}

		// Token: 0x06009D15 RID: 40213 RVA: 0x001A2690 File Offset: 0x001A0890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceLineupCsReq(ReplaceLineupCsReq other) : this()
		{
			this.index_ = other.index_;
			this.leaderSlot_ = other.leaderSlot_;
			this.isVirtual_ = other.isVirtual_;
			this.planeId_ = other.planeId_;
			this.extraLineupType_ = other.extraLineupType_;
			this.gameStoryLineId_ = other.gameStoryLineId_;
			this.lineupSlotList_ = other.lineupSlotList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D16 RID: 40214 RVA: 0x001A270D File Offset: 0x001A090D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceLineupCsReq Clone()
		{
			return new ReplaceLineupCsReq(this);
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x06009D17 RID: 40215 RVA: 0x001A2715 File Offset: 0x001A0915
		// (set) Token: 0x06009D18 RID: 40216 RVA: 0x001A271D File Offset: 0x001A091D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x06009D19 RID: 40217 RVA: 0x001A2726 File Offset: 0x001A0926
		// (set) Token: 0x06009D1A RID: 40218 RVA: 0x001A272E File Offset: 0x001A092E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LeaderSlot
		{
			get
			{
				return this.leaderSlot_;
			}
			set
			{
				this.leaderSlot_ = value;
			}
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x06009D1B RID: 40219 RVA: 0x001A2737 File Offset: 0x001A0937
		// (set) Token: 0x06009D1C RID: 40220 RVA: 0x001A273F File Offset: 0x001A093F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVirtual
		{
			get
			{
				return this.isVirtual_;
			}
			set
			{
				this.isVirtual_ = value;
			}
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x06009D1D RID: 40221 RVA: 0x001A2748 File Offset: 0x001A0948
		// (set) Token: 0x06009D1E RID: 40222 RVA: 0x001A2750 File Offset: 0x001A0950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlaneId
		{
			get
			{
				return this.planeId_;
			}
			set
			{
				this.planeId_ = value;
			}
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x06009D1F RID: 40223 RVA: 0x001A2759 File Offset: 0x001A0959
		// (set) Token: 0x06009D20 RID: 40224 RVA: 0x001A2761 File Offset: 0x001A0961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraLineupType ExtraLineupType
		{
			get
			{
				return this.extraLineupType_;
			}
			set
			{
				this.extraLineupType_ = value;
			}
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x06009D21 RID: 40225 RVA: 0x001A276A File Offset: 0x001A096A
		// (set) Token: 0x06009D22 RID: 40226 RVA: 0x001A2772 File Offset: 0x001A0972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameStoryLineId
		{
			get
			{
				return this.gameStoryLineId_;
			}
			set
			{
				this.gameStoryLineId_ = value;
			}
		}

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x06009D23 RID: 40227 RVA: 0x001A277B File Offset: 0x001A097B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LineupSlotData> LineupSlotList
		{
			get
			{
				return this.lineupSlotList_;
			}
		}

		// Token: 0x06009D24 RID: 40228 RVA: 0x001A2783 File Offset: 0x001A0983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReplaceLineupCsReq);
		}

		// Token: 0x06009D25 RID: 40229 RVA: 0x001A2794 File Offset: 0x001A0994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReplaceLineupCsReq other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.LeaderSlot == other.LeaderSlot && this.IsVirtual == other.IsVirtual && this.PlaneId == other.PlaneId && this.ExtraLineupType == other.ExtraLineupType && this.GameStoryLineId == other.GameStoryLineId && this.lineupSlotList_.Equals(other.lineupSlotList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D26 RID: 40230 RVA: 0x001A2834 File Offset: 0x001A0A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.LeaderSlot != 0U)
			{
				num ^= this.LeaderSlot.GetHashCode();
			}
			if (this.IsVirtual)
			{
				num ^= this.IsVirtual.GetHashCode();
			}
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num ^= this.ExtraLineupType.GetHashCode();
			}
			if (this.GameStoryLineId != 0U)
			{
				num ^= this.GameStoryLineId.GetHashCode();
			}
			num ^= this.lineupSlotList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D27 RID: 40231 RVA: 0x001A2904 File Offset: 0x001A0B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D28 RID: 40232 RVA: 0x001A290C File Offset: 0x001A0B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D29 RID: 40233 RVA: 0x001A2918 File Offset: 0x001A0B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PlaneId);
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ExtraLineupType);
			}
			if (this.IsVirtual)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsVirtual);
			}
			if (this.GameStoryLineId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GameStoryLineId);
			}
			this.lineupSlotList_.WriteTo(ref output, ReplaceLineupCsReq._repeated_lineupSlotList_codec);
			if (this.Index != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Index);
			}
			if (this.LeaderSlot != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LeaderSlot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D2A RID: 40234 RVA: 0x001A29F4 File Offset: 0x001A0BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			if (this.LeaderSlot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LeaderSlot);
			}
			if (this.IsVirtual)
			{
				num += 2;
			}
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ExtraLineupType);
			}
			if (this.GameStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameStoryLineId);
			}
			num += this.lineupSlotList_.CalculateSize(ReplaceLineupCsReq._repeated_lineupSlotList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D2B RID: 40235 RVA: 0x001A2AB4 File Offset: 0x001A0CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReplaceLineupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			if (other.LeaderSlot != 0U)
			{
				this.LeaderSlot = other.LeaderSlot;
			}
			if (other.IsVirtual)
			{
				this.IsVirtual = other.IsVirtual;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				this.ExtraLineupType = other.ExtraLineupType;
			}
			if (other.GameStoryLineId != 0U)
			{
				this.GameStoryLineId = other.GameStoryLineId;
			}
			this.lineupSlotList_.Add(other.lineupSlotList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D2C RID: 40236 RVA: 0x001A2B65 File Offset: 0x001A0D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D2D RID: 40237 RVA: 0x001A2B70 File Offset: 0x001A0D70
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
						this.PlaneId = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ExtraLineupType = (ExtraLineupType)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.IsVirtual = input.ReadBool();
						continue;
					}
				}
				else if (num <= 90U)
				{
					if (num == 64U)
					{
						this.GameStoryLineId = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						this.lineupSlotList_.AddEntriesFrom(ref input, ReplaceLineupCsReq._repeated_lineupSlotList_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Index = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.LeaderSlot = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D0D RID: 15629
		private static readonly MessageParser<ReplaceLineupCsReq> _parser = new MessageParser<ReplaceLineupCsReq>(() => new ReplaceLineupCsReq());

		// Token: 0x04003D0E RID: 15630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D0F RID: 15631
		public const int IndexFieldNumber = 13;

		// Token: 0x04003D10 RID: 15632
		private uint index_;

		// Token: 0x04003D11 RID: 15633
		public const int LeaderSlotFieldNumber = 14;

		// Token: 0x04003D12 RID: 15634
		private uint leaderSlot_;

		// Token: 0x04003D13 RID: 15635
		public const int IsVirtualFieldNumber = 3;

		// Token: 0x04003D14 RID: 15636
		private bool isVirtual_;

		// Token: 0x04003D15 RID: 15637
		public const int PlaneIdFieldNumber = 1;

		// Token: 0x04003D16 RID: 15638
		private uint planeId_;

		// Token: 0x04003D17 RID: 15639
		public const int ExtraLineupTypeFieldNumber = 2;

		// Token: 0x04003D18 RID: 15640
		private ExtraLineupType extraLineupType_;

		// Token: 0x04003D19 RID: 15641
		public const int GameStoryLineIdFieldNumber = 8;

		// Token: 0x04003D1A RID: 15642
		private uint gameStoryLineId_;

		// Token: 0x04003D1B RID: 15643
		public const int LineupSlotListFieldNumber = 11;

		// Token: 0x04003D1C RID: 15644
		private static readonly FieldCodec<LineupSlotData> _repeated_lineupSlotList_codec = FieldCodec.ForMessage<LineupSlotData>(90U, LineupSlotData.Parser);

		// Token: 0x04003D1D RID: 15645
		private readonly RepeatedField<LineupSlotData> lineupSlotList_ = new RepeatedField<LineupSlotData>();
	}
}
