using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001ED RID: 493
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueCell : IMessage<ChessRogueCell>, IMessage, IEquatable<ChessRogueCell>, IDeepCloneable<ChessRogueCell>, IBufferMessage
	{
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x0003F2FE File Offset: 0x0003D4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueCell> Parser
		{
			get
			{
				return ChessRogueCell._parser;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x0003F305 File Offset: 0x0003D505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueCellReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x0003F317 File Offset: 0x0003D517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueCell.Descriptor;
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0003F31E File Offset: 0x0003D51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCell()
		{
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0003F334 File Offset: 0x0003D534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCell(ChessRogueCell other) : this()
		{
			this.isUnlocked_ = other.isUnlocked_;
			this.markType_ = other.markType_;
			this.specialType_ = other.specialType_;
			this.iFEHGGKMHCA_ = other.iFEHGGKMHCA_.Clone();
			this.posY_ = other.posY_;
			this.posX_ = other.posX_;
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.blockType_ = other.blockType_;
			this.id_ = other.id_;
			this.roomId_ = other.roomId_;
			this.cellStatus_ = other.cellStatus_;
			this.isUnlock_ = other.isUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x0003F3FD File Offset: 0x0003D5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCell Clone()
		{
			return new ChessRogueCell(this);
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x0003F405 File Offset: 0x0003D605
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x0003F40D File Offset: 0x0003D60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlocked
		{
			get
			{
				return this.isUnlocked_;
			}
			set
			{
				this.isUnlocked_ = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x0003F416 File Offset: 0x0003D616
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x0003F41E File Offset: 0x0003D61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MarkType
		{
			get
			{
				return this.markType_;
			}
			set
			{
				this.markType_ = value;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x0003F427 File Offset: 0x0003D627
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x0003F42F File Offset: 0x0003D62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCellSpecialType SpecialType
		{
			get
			{
				return this.specialType_;
			}
			set
			{
				this.specialType_ = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x0003F438 File Offset: 0x0003D638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IFEHGGKMHCA
		{
			get
			{
				return this.iFEHGGKMHCA_;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x0003F440 File Offset: 0x0003D640
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x0003F448 File Offset: 0x0003D648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PosY
		{
			get
			{
				return this.posY_;
			}
			set
			{
				this.posY_ = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x0003F451 File Offset: 0x0003D651
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x0003F459 File Offset: 0x0003D659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PosX
		{
			get
			{
				return this.posX_;
			}
			set
			{
				this.posX_ = value;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x0003F462 File Offset: 0x0003D662
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x0003F46A File Offset: 0x0003D66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellAdvanceInfo StageInfo
		{
			get
			{
				return this.stageInfo_;
			}
			set
			{
				this.stageInfo_ = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x0003F473 File Offset: 0x0003D673
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x0003F47B File Offset: 0x0003D67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BlockType
		{
			get
			{
				return this.blockType_;
			}
			set
			{
				this.blockType_ = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x0003F484 File Offset: 0x0003D684
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x0003F48C File Offset: 0x0003D68C
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

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x0003F495 File Offset: 0x0003D695
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x0003F49D File Offset: 0x0003D69D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x0003F4A6 File Offset: 0x0003D6A6
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x0003F4AE File Offset: 0x0003D6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBoardCellStatus CellStatus
		{
			get
			{
				return this.cellStatus_;
			}
			set
			{
				this.cellStatus_ = value;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x0003F4B7 File Offset: 0x0003D6B7
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x0003F4BF File Offset: 0x0003D6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0003F4C8 File Offset: 0x0003D6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueCell);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0003F4D8 File Offset: 0x0003D6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueCell other)
		{
			return other != null && (other == this || (this.IsUnlocked == other.IsUnlocked && this.MarkType == other.MarkType && this.SpecialType == other.SpecialType && this.iFEHGGKMHCA_.Equals(other.iFEHGGKMHCA_) && this.PosY == other.PosY && this.PosX == other.PosX && object.Equals(this.StageInfo, other.StageInfo) && this.BlockType == other.BlockType && this.Id == other.Id && this.RoomId == other.RoomId && this.CellStatus == other.CellStatus && this.IsUnlock == other.IsUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0003F5CC File Offset: 0x0003D7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsUnlocked)
			{
				num ^= this.IsUnlocked.GetHashCode();
			}
			if (this.MarkType != 0U)
			{
				num ^= this.MarkType.GetHashCode();
			}
			if (this.SpecialType != ChessRogueCellSpecialType.None)
			{
				num ^= this.SpecialType.GetHashCode();
			}
			num ^= this.iFEHGGKMHCA_.GetHashCode();
			if (this.PosY != 0U)
			{
				num ^= this.PosY.GetHashCode();
			}
			if (this.PosX != 0U)
			{
				num ^= this.PosX.GetHashCode();
			}
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this.BlockType != 0U)
			{
				num ^= this.BlockType.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.CellStatus != ChessRogueBoardCellStatus.Idle)
			{
				num ^= this.CellStatus.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0003F71D File Offset: 0x0003D91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0003F725 File Offset: 0x0003D925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x0003F730 File Offset: 0x0003D930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CellStatus != ChessRogueBoardCellStatus.Idle)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.CellStatus);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.StageInfo);
			}
			this.iFEHGGKMHCA_.WriteTo(ref output, ChessRogueCell._repeated_iFEHGGKMHCA_codec);
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.RoomId);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Id);
			}
			if (this.BlockType != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.BlockType);
			}
			if (this.IsUnlocked)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsUnlocked);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsUnlock);
			}
			if (this.SpecialType != ChessRogueCellSpecialType.None)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.SpecialType);
			}
			if (this.MarkType != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MarkType);
			}
			if (this.PosY != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.PosY);
			}
			if (this.PosX != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.PosX);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0003F898 File Offset: 0x0003DA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsUnlocked)
			{
				num += 2;
			}
			if (this.MarkType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MarkType);
			}
			if (this.SpecialType != ChessRogueCellSpecialType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SpecialType);
			}
			num += this.iFEHGGKMHCA_.CalculateSize(ChessRogueCell._repeated_iFEHGGKMHCA_codec);
			if (this.PosY != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PosY);
			}
			if (this.PosX != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PosX);
			}
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this.BlockType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BlockType);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this.CellStatus != ChessRogueBoardCellStatus.Idle)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CellStatus);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0003F9C4 File Offset: 0x0003DBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueCell other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsUnlocked)
			{
				this.IsUnlocked = other.IsUnlocked;
			}
			if (other.MarkType != 0U)
			{
				this.MarkType = other.MarkType;
			}
			if (other.SpecialType != ChessRogueCellSpecialType.None)
			{
				this.SpecialType = other.SpecialType;
			}
			this.iFEHGGKMHCA_.Add(other.iFEHGGKMHCA_);
			if (other.PosY != 0U)
			{
				this.PosY = other.PosY;
			}
			if (other.PosX != 0U)
			{
				this.PosX = other.PosX;
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new CellAdvanceInfo();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			if (other.BlockType != 0U)
			{
				this.BlockType = other.BlockType;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			if (other.CellStatus != ChessRogueBoardCellStatus.Idle)
			{
				this.CellStatus = other.CellStatus;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0003FAF1 File Offset: 0x0003DCF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0003FAFC File Offset: 0x0003DCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 32U)
					{
						if (num == 8U)
						{
							this.CellStatus = (ChessRogueBoardCellStatus)input.ReadEnum();
							continue;
						}
						if (num == 18U)
						{
							if (this.stageInfo_ == null)
							{
								this.StageInfo = new CellAdvanceInfo();
							}
							input.ReadMessage(this.StageInfo);
							continue;
						}
						if (num != 32U)
						{
							goto IL_88;
						}
					}
					else if (num != 34U)
					{
						if (num == 40U)
						{
							this.RoomId = input.ReadUInt32();
							continue;
						}
						if (num != 48U)
						{
							goto IL_88;
						}
						this.Id = input.ReadUInt32();
						continue;
					}
					this.iFEHGGKMHCA_.AddEntriesFrom(ref input, ChessRogueCell._repeated_iFEHGGKMHCA_codec);
					continue;
				}
				if (num <= 80U)
				{
					if (num == 56U)
					{
						this.BlockType = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.IsUnlocked = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.SpecialType = (ChessRogueCellSpecialType)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.MarkType = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.PosY = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.PosX = input.ReadUInt32();
						continue;
					}
				}
				IL_88:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000944 RID: 2372
		private static readonly MessageParser<ChessRogueCell> _parser = new MessageParser<ChessRogueCell>(() => new ChessRogueCell());

		// Token: 0x04000945 RID: 2373
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000946 RID: 2374
		public const int IsUnlockedFieldNumber = 8;

		// Token: 0x04000947 RID: 2375
		private bool isUnlocked_;

		// Token: 0x04000948 RID: 2376
		public const int MarkTypeFieldNumber = 13;

		// Token: 0x04000949 RID: 2377
		private uint markType_;

		// Token: 0x0400094A RID: 2378
		public const int SpecialTypeFieldNumber = 12;

		// Token: 0x0400094B RID: 2379
		private ChessRogueCellSpecialType specialType_;

		// Token: 0x0400094C RID: 2380
		public const int IFEHGGKMHCAFieldNumber = 4;

		// Token: 0x0400094D RID: 2381
		private static readonly FieldCodec<uint> _repeated_iFEHGGKMHCA_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x0400094E RID: 2382
		private readonly RepeatedField<uint> iFEHGGKMHCA_ = new RepeatedField<uint>();

		// Token: 0x0400094F RID: 2383
		public const int PosYFieldNumber = 14;

		// Token: 0x04000950 RID: 2384
		private uint posY_;

		// Token: 0x04000951 RID: 2385
		public const int PosXFieldNumber = 15;

		// Token: 0x04000952 RID: 2386
		private uint posX_;

		// Token: 0x04000953 RID: 2387
		public const int StageInfoFieldNumber = 2;

		// Token: 0x04000954 RID: 2388
		private CellAdvanceInfo stageInfo_;

		// Token: 0x04000955 RID: 2389
		public const int BlockTypeFieldNumber = 7;

		// Token: 0x04000956 RID: 2390
		private uint blockType_;

		// Token: 0x04000957 RID: 2391
		public const int IdFieldNumber = 6;

		// Token: 0x04000958 RID: 2392
		private uint id_;

		// Token: 0x04000959 RID: 2393
		public const int RoomIdFieldNumber = 5;

		// Token: 0x0400095A RID: 2394
		private uint roomId_;

		// Token: 0x0400095B RID: 2395
		public const int CellStatusFieldNumber = 1;

		// Token: 0x0400095C RID: 2396
		private ChessRogueBoardCellStatus cellStatus_;

		// Token: 0x0400095D RID: 2397
		public const int IsUnlockFieldNumber = 10;

		// Token: 0x0400095E RID: 2398
		private bool isUnlock_;
	}
}
