using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001E1 RID: 481
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueAreaInfo : IMessage<ChessRogueAreaInfo>, IMessage, IEquatable<ChessRogueAreaInfo>, IDeepCloneable<ChessRogueAreaInfo>, IBufferMessage
	{
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x0003DF59 File Offset: 0x0003C159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueAreaInfo> Parser
		{
			get
			{
				return ChessRogueAreaInfo._parser;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x0003DF60 File Offset: 0x0003C160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueAreaInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x0003DF72 File Offset: 0x0003C172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueAreaInfo.Descriptor;
			}
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x0003DF79 File Offset: 0x0003C179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueAreaInfo()
		{
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0003DF98 File Offset: 0x0003C198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueAreaInfo(ChessRogueAreaInfo other) : this()
		{
			this.allowSelectCellIdList_ = other.allowSelectCellIdList_.Clone();
			this.historyCell_ = other.historyCell_.Clone();
			this.curId_ = other.curId_;
			this.cell_ = ((other.cell_ != null) ? other.cell_.Clone() : null);
			this.layerStatus_ = other.layerStatus_;
			this.dOHIBBPIKDD_ = ((other.dOHIBBPIKDD_ != null) ? other.dOHIBBPIKDD_.Clone() : null);
			this.curBoardId_ = other.curBoardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0003E03A File Offset: 0x0003C23A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueAreaInfo Clone()
		{
			return new ChessRogueAreaInfo(this);
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x0003E042 File Offset: 0x0003C242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AllowSelectCellIdList
		{
			get
			{
				return this.allowSelectCellIdList_;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x0003E04A File Offset: 0x0003C24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueHistoryCellInfo> HistoryCell
		{
			get
			{
				return this.historyCell_;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x0003E052 File Offset: 0x0003C252
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x0003E05A File Offset: 0x0003C25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurId
		{
			get
			{
				return this.curId_;
			}
			set
			{
				this.curId_ = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x0003E063 File Offset: 0x0003C263
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x0003E06B File Offset: 0x0003C26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellInfo Cell
		{
			get
			{
				return this.cell_;
			}
			set
			{
				this.cell_ = value;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x0003E074 File Offset: 0x0003C274
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x0003E07C File Offset: 0x0003C27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBoardCellStatus LayerStatus
		{
			get
			{
				return this.layerStatus_;
			}
			set
			{
				this.layerStatus_ = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x0003E085 File Offset: 0x0003C285
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x0003E08D File Offset: 0x0003C28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IEKCBAHADKE DOHIBBPIKDD
		{
			get
			{
				return this.dOHIBBPIKDD_;
			}
			set
			{
				this.dOHIBBPIKDD_ = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x0003E096 File Offset: 0x0003C296
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x0003E09E File Offset: 0x0003C29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurBoardId
		{
			get
			{
				return this.curBoardId_;
			}
			set
			{
				this.curBoardId_ = value;
			}
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0003E0A7 File Offset: 0x0003C2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueAreaInfo);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0003E0B8 File Offset: 0x0003C2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueAreaInfo other)
		{
			return other != null && (other == this || (this.allowSelectCellIdList_.Equals(other.allowSelectCellIdList_) && this.historyCell_.Equals(other.historyCell_) && this.CurId == other.CurId && object.Equals(this.Cell, other.Cell) && this.LayerStatus == other.LayerStatus && object.Equals(this.DOHIBBPIKDD, other.DOHIBBPIKDD) && this.CurBoardId == other.CurBoardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0003E168 File Offset: 0x0003C368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.allowSelectCellIdList_.GetHashCode();
			num ^= this.historyCell_.GetHashCode();
			if (this.CurId != 0U)
			{
				num ^= this.CurId.GetHashCode();
			}
			if (this.cell_ != null)
			{
				num ^= this.Cell.GetHashCode();
			}
			if (this.LayerStatus != ChessRogueBoardCellStatus.Idle)
			{
				num ^= this.LayerStatus.GetHashCode();
			}
			if (this.dOHIBBPIKDD_ != null)
			{
				num ^= this.DOHIBBPIKDD.GetHashCode();
			}
			if (this.CurBoardId != 0U)
			{
				num ^= this.CurBoardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0003E227 File Offset: 0x0003C427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0003E22F File Offset: 0x0003C42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0003E238 File Offset: 0x0003C438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.allowSelectCellIdList_.WriteTo(ref output, ChessRogueAreaInfo._repeated_allowSelectCellIdList_codec);
			if (this.CurId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CurId);
			}
			if (this.cell_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Cell);
			}
			if (this.CurBoardId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.CurBoardId);
			}
			this.historyCell_.WriteTo(ref output, ChessRogueAreaInfo._repeated_historyCell_codec);
			if (this.dOHIBBPIKDD_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.DOHIBBPIKDD);
			}
			if (this.LayerStatus != ChessRogueBoardCellStatus.Idle)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.LayerStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0003E308 File Offset: 0x0003C508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.allowSelectCellIdList_.CalculateSize(ChessRogueAreaInfo._repeated_allowSelectCellIdList_codec);
			num += this.historyCell_.CalculateSize(ChessRogueAreaInfo._repeated_historyCell_codec);
			if (this.CurId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurId);
			}
			if (this.cell_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Cell);
			}
			if (this.LayerStatus != ChessRogueBoardCellStatus.Idle)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LayerStatus);
			}
			if (this.dOHIBBPIKDD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DOHIBBPIKDD);
			}
			if (this.CurBoardId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurBoardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x0003E3CC File Offset: 0x0003C5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueAreaInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.allowSelectCellIdList_.Add(other.allowSelectCellIdList_);
			this.historyCell_.Add(other.historyCell_);
			if (other.CurId != 0U)
			{
				this.CurId = other.CurId;
			}
			if (other.cell_ != null)
			{
				if (this.cell_ == null)
				{
					this.Cell = new CellInfo();
				}
				this.Cell.MergeFrom(other.Cell);
			}
			if (other.LayerStatus != ChessRogueBoardCellStatus.Idle)
			{
				this.LayerStatus = other.LayerStatus;
			}
			if (other.dOHIBBPIKDD_ != null)
			{
				if (this.dOHIBBPIKDD_ == null)
				{
					this.DOHIBBPIKDD = new IEKCBAHADKE();
				}
				this.DOHIBBPIKDD.MergeFrom(other.DOHIBBPIKDD);
			}
			if (other.CurBoardId != 0U)
			{
				this.CurBoardId = other.CurBoardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0003E4AA File Offset: 0x0003C6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num <= 18U)
					{
						if (num == 16U || num == 18U)
						{
							this.allowSelectCellIdList_.AddEntriesFrom(ref input, ChessRogueAreaInfo._repeated_allowSelectCellIdList_codec);
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.CurId = input.ReadUInt32();
							continue;
						}
						if (num == 34U)
						{
							if (this.cell_ == null)
							{
								this.Cell = new CellInfo();
							}
							input.ReadMessage(this.Cell);
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.CurBoardId = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
					{
						this.historyCell_.AddEntriesFrom(ref input, ChessRogueAreaInfo._repeated_historyCell_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.dOHIBBPIKDD_ == null)
						{
							this.DOHIBBPIKDD = new IEKCBAHADKE();
						}
						input.ReadMessage(this.DOHIBBPIKDD);
						continue;
					}
					if (num == 88U)
					{
						this.LayerStatus = (ChessRogueBoardCellStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000913 RID: 2323
		private static readonly MessageParser<ChessRogueAreaInfo> _parser = new MessageParser<ChessRogueAreaInfo>(() => new ChessRogueAreaInfo());

		// Token: 0x04000914 RID: 2324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000915 RID: 2325
		public const int AllowSelectCellIdListFieldNumber = 2;

		// Token: 0x04000916 RID: 2326
		private static readonly FieldCodec<uint> _repeated_allowSelectCellIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04000917 RID: 2327
		private readonly RepeatedField<uint> allowSelectCellIdList_ = new RepeatedField<uint>();

		// Token: 0x04000918 RID: 2328
		public const int HistoryCellFieldNumber = 6;

		// Token: 0x04000919 RID: 2329
		private static readonly FieldCodec<ChessRogueHistoryCellInfo> _repeated_historyCell_codec = FieldCodec.ForMessage<ChessRogueHistoryCellInfo>(50U, ChessRogueHistoryCellInfo.Parser);

		// Token: 0x0400091A RID: 2330
		private readonly RepeatedField<ChessRogueHistoryCellInfo> historyCell_ = new RepeatedField<ChessRogueHistoryCellInfo>();

		// Token: 0x0400091B RID: 2331
		public const int CurIdFieldNumber = 3;

		// Token: 0x0400091C RID: 2332
		private uint curId_;

		// Token: 0x0400091D RID: 2333
		public const int CellFieldNumber = 4;

		// Token: 0x0400091E RID: 2334
		private CellInfo cell_;

		// Token: 0x0400091F RID: 2335
		public const int LayerStatusFieldNumber = 11;

		// Token: 0x04000920 RID: 2336
		private ChessRogueBoardCellStatus layerStatus_;

		// Token: 0x04000921 RID: 2337
		public const int DOHIBBPIKDDFieldNumber = 9;

		// Token: 0x04000922 RID: 2338
		private IEKCBAHADKE dOHIBBPIKDD_;

		// Token: 0x04000923 RID: 2339
		public const int CurBoardIdFieldNumber = 5;

		// Token: 0x04000924 RID: 2340
		private uint curBoardId_;
	}
}
