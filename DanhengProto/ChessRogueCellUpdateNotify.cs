using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001F1 RID: 497
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueCellUpdateNotify : IMessage<ChessRogueCellUpdateNotify>, IMessage, IEquatable<ChessRogueCellUpdateNotify>, IDeepCloneable<ChessRogueCellUpdateNotify>, IBufferMessage
	{
		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x0003FE0B File Offset: 0x0003E00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueCellUpdateNotify> Parser
		{
			get
			{
				return ChessRogueCellUpdateNotify._parser;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x0003FE12 File Offset: 0x0003E012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueCellUpdateNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x0003FE24 File Offset: 0x0003E024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueCellUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0003FE2B File Offset: 0x0003E02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCellUpdateNotify()
		{
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0003FE40 File Offset: 0x0003E040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCellUpdateNotify(ChessRogueCellUpdateNotify other) : this()
		{
			this.cellList_ = other.cellList_.Clone();
			this.reason_ = other.reason_;
			this.modifierSource_ = other.modifierSource_;
			this.boardId_ = other.boardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0003FE99 File Offset: 0x0003E099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCellUpdateNotify Clone()
		{
			return new ChessRogueCellUpdateNotify(this);
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x0003FEA1 File Offset: 0x0003E0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueCell> CellList
		{
			get
			{
				return this.cellList_;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x0003FEA9 File Offset: 0x0003E0A9
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x0003FEB1 File Offset: 0x0003E0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCellUpdateReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x0003FEBA File Offset: 0x0003E0BA
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x0003FEC2 File Offset: 0x0003E0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierSourceType ModifierSource
		{
			get
			{
				return this.modifierSource_;
			}
			set
			{
				this.modifierSource_ = value;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x0003FECB File Offset: 0x0003E0CB
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x0003FED3 File Offset: 0x0003E0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BoardId
		{
			get
			{
				return this.boardId_;
			}
			set
			{
				this.boardId_ = value;
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0003FEDC File Offset: 0x0003E0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueCellUpdateNotify);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0003FEEC File Offset: 0x0003E0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueCellUpdateNotify other)
		{
			return other != null && (other == this || (this.cellList_.Equals(other.cellList_) && this.Reason == other.Reason && this.ModifierSource == other.ModifierSource && this.BoardId == other.BoardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0003FF5C File Offset: 0x0003E15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cellList_.GetHashCode();
			if (this.Reason != ChessRogueCellUpdateReason.None)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.ModifierSource != RogueModifierSourceType.RogueModifierSourceNone)
			{
				num ^= this.ModifierSource.GetHashCode();
			}
			if (this.BoardId != 0U)
			{
				num ^= this.BoardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0003FFE7 File Offset: 0x0003E1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0003FFEF File Offset: 0x0003E1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0003FFF8 File Offset: 0x0003E1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoardId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BoardId);
			}
			if (this.Reason != ChessRogueCellUpdateReason.None)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Reason);
			}
			if (this.ModifierSource != RogueModifierSourceType.RogueModifierSourceNone)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ModifierSource);
			}
			this.cellList_.WriteTo(ref output, ChessRogueCellUpdateNotify._repeated_cellList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00040080 File Offset: 0x0003E280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cellList_.CalculateSize(ChessRogueCellUpdateNotify._repeated_cellList_codec);
			if (this.Reason != ChessRogueCellUpdateReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.ModifierSource != RogueModifierSourceType.RogueModifierSourceNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ModifierSource);
			}
			if (this.BoardId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BoardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00040104 File Offset: 0x0003E304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueCellUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.cellList_.Add(other.cellList_);
			if (other.Reason != ChessRogueCellUpdateReason.None)
			{
				this.Reason = other.Reason;
			}
			if (other.ModifierSource != RogueModifierSourceType.RogueModifierSourceNone)
			{
				this.ModifierSource = other.ModifierSource;
			}
			if (other.BoardId != 0U)
			{
				this.BoardId = other.BoardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00040179 File Offset: 0x0003E379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00040184 File Offset: 0x0003E384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.BoardId = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Reason = (ChessRogueCellUpdateReason)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.ModifierSource = (RogueModifierSourceType)input.ReadEnum();
						continue;
					}
					if (num == 122U)
					{
						this.cellList_.AddEntriesFrom(ref input, ChessRogueCellUpdateNotify._repeated_cellList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000968 RID: 2408
		private static readonly MessageParser<ChessRogueCellUpdateNotify> _parser = new MessageParser<ChessRogueCellUpdateNotify>(() => new ChessRogueCellUpdateNotify());

		// Token: 0x04000969 RID: 2409
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400096A RID: 2410
		public const int CellListFieldNumber = 15;

		// Token: 0x0400096B RID: 2411
		private static readonly FieldCodec<ChessRogueCell> _repeated_cellList_codec = FieldCodec.ForMessage<ChessRogueCell>(122U, ChessRogueCell.Parser);

		// Token: 0x0400096C RID: 2412
		private readonly RepeatedField<ChessRogueCell> cellList_ = new RepeatedField<ChessRogueCell>();

		// Token: 0x0400096D RID: 2413
		public const int ReasonFieldNumber = 4;

		// Token: 0x0400096E RID: 2414
		private ChessRogueCellUpdateReason reason_;

		// Token: 0x0400096F RID: 2415
		public const int ModifierSourceFieldNumber = 14;

		// Token: 0x04000970 RID: 2416
		private RogueModifierSourceType modifierSource_;

		// Token: 0x04000971 RID: 2417
		public const int BoardIdFieldNumber = 2;

		// Token: 0x04000972 RID: 2418
		private uint boardId_;
	}
}
