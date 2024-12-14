using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E87 RID: 3719
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueFormulaSelectInfo : IMessage<RogueFormulaSelectInfo>, IMessage, IEquatable<RogueFormulaSelectInfo>, IDeepCloneable<RogueFormulaSelectInfo>, IBufferMessage
	{
		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x0600A605 RID: 42501 RVA: 0x001BEC6F File Offset: 0x001BCE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueFormulaSelectInfo> Parser
		{
			get
			{
				return RogueFormulaSelectInfo._parser;
			}
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x0600A606 RID: 42502 RVA: 0x001BEC76 File Offset: 0x001BCE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueFormulaSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0600A607 RID: 42503 RVA: 0x001BEC88 File Offset: 0x001BCE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueFormulaSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600A608 RID: 42504 RVA: 0x001BEC8F File Offset: 0x001BCE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFormulaSelectInfo()
		{
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x001BECB0 File Offset: 0x001BCEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFormulaSelectInfo(RogueFormulaSelectInfo other) : this()
		{
			this.rollFormulaMaxCount_ = other.rollFormulaMaxCount_;
			this.handbookUnlockFormulaIdList_ = other.handbookUnlockFormulaIdList_.Clone();
			this.selectFormulaIdList_ = other.selectFormulaIdList_.Clone();
			this.canRoll_ = other.canRoll_;
			this.rollFormulaCostData_ = ((other.rollFormulaCostData_ != null) ? other.rollFormulaCostData_.Clone() : null);
			this.hintId_ = other.hintId_;
			this.rollFormulaFreeCount_ = other.rollFormulaFreeCount_;
			this.rollFormulaCount_ = other.rollFormulaCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A60A RID: 42506 RVA: 0x001BED4E File Offset: 0x001BCF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFormulaSelectInfo Clone()
		{
			return new RogueFormulaSelectInfo(this);
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600A60B RID: 42507 RVA: 0x001BED56 File Offset: 0x001BCF56
		// (set) Token: 0x0600A60C RID: 42508 RVA: 0x001BED5E File Offset: 0x001BCF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollFormulaMaxCount
		{
			get
			{
				return this.rollFormulaMaxCount_;
			}
			set
			{
				this.rollFormulaMaxCount_ = value;
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0600A60D RID: 42509 RVA: 0x001BED67 File Offset: 0x001BCF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HandbookUnlockFormulaIdList
		{
			get
			{
				return this.handbookUnlockFormulaIdList_;
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x0600A60E RID: 42510 RVA: 0x001BED6F File Offset: 0x001BCF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SelectFormulaIdList
		{
			get
			{
				return this.selectFormulaIdList_;
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x0600A60F RID: 42511 RVA: 0x001BED77 File Offset: 0x001BCF77
		// (set) Token: 0x0600A610 RID: 42512 RVA: 0x001BED7F File Offset: 0x001BCF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanRoll
		{
			get
			{
				return this.canRoll_;
			}
			set
			{
				this.canRoll_ = value;
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x0600A611 RID: 42513 RVA: 0x001BED88 File Offset: 0x001BCF88
		// (set) Token: 0x0600A612 RID: 42514 RVA: 0x001BED90 File Offset: 0x001BCF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData RollFormulaCostData
		{
			get
			{
				return this.rollFormulaCostData_;
			}
			set
			{
				this.rollFormulaCostData_ = value;
			}
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x0600A613 RID: 42515 RVA: 0x001BED99 File Offset: 0x001BCF99
		// (set) Token: 0x0600A614 RID: 42516 RVA: 0x001BEDA1 File Offset: 0x001BCFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HintId
		{
			get
			{
				return this.hintId_;
			}
			set
			{
				this.hintId_ = value;
			}
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x0600A615 RID: 42517 RVA: 0x001BEDAA File Offset: 0x001BCFAA
		// (set) Token: 0x0600A616 RID: 42518 RVA: 0x001BEDB2 File Offset: 0x001BCFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollFormulaFreeCount
		{
			get
			{
				return this.rollFormulaFreeCount_;
			}
			set
			{
				this.rollFormulaFreeCount_ = value;
			}
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x0600A617 RID: 42519 RVA: 0x001BEDBB File Offset: 0x001BCFBB
		// (set) Token: 0x0600A618 RID: 42520 RVA: 0x001BEDC3 File Offset: 0x001BCFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollFormulaCount
		{
			get
			{
				return this.rollFormulaCount_;
			}
			set
			{
				this.rollFormulaCount_ = value;
			}
		}

		// Token: 0x0600A619 RID: 42521 RVA: 0x001BEDCC File Offset: 0x001BCFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueFormulaSelectInfo);
		}

		// Token: 0x0600A61A RID: 42522 RVA: 0x001BEDDC File Offset: 0x001BCFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueFormulaSelectInfo other)
		{
			return other != null && (other == this || (this.RollFormulaMaxCount == other.RollFormulaMaxCount && this.handbookUnlockFormulaIdList_.Equals(other.handbookUnlockFormulaIdList_) && this.selectFormulaIdList_.Equals(other.selectFormulaIdList_) && this.CanRoll == other.CanRoll && object.Equals(this.RollFormulaCostData, other.RollFormulaCostData) && this.HintId == other.HintId && this.RollFormulaFreeCount == other.RollFormulaFreeCount && this.RollFormulaCount == other.RollFormulaCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A61B RID: 42523 RVA: 0x001BEE94 File Offset: 0x001BD094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RollFormulaMaxCount != 0U)
			{
				num ^= this.RollFormulaMaxCount.GetHashCode();
			}
			num ^= this.handbookUnlockFormulaIdList_.GetHashCode();
			num ^= this.selectFormulaIdList_.GetHashCode();
			if (this.CanRoll)
			{
				num ^= this.CanRoll.GetHashCode();
			}
			if (this.rollFormulaCostData_ != null)
			{
				num ^= this.RollFormulaCostData.GetHashCode();
			}
			if (this.HintId != 0U)
			{
				num ^= this.HintId.GetHashCode();
			}
			if (this.RollFormulaFreeCount != 0U)
			{
				num ^= this.RollFormulaFreeCount.GetHashCode();
			}
			if (this.RollFormulaCount != 0U)
			{
				num ^= this.RollFormulaCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A61C RID: 42524 RVA: 0x001BEF69 File Offset: 0x001BD169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x001BEF71 File Offset: 0x001BD171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x001BEF7C File Offset: 0x001BD17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RollFormulaFreeCount != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RollFormulaFreeCount);
			}
			if (this.HintId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.HintId);
			}
			if (this.CanRoll)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.CanRoll);
			}
			if (this.RollFormulaCount != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.RollFormulaCount);
			}
			if (this.RollFormulaMaxCount != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.RollFormulaMaxCount);
			}
			this.handbookUnlockFormulaIdList_.WriteTo(ref output, RogueFormulaSelectInfo._repeated_handbookUnlockFormulaIdList_codec);
			this.selectFormulaIdList_.WriteTo(ref output, RogueFormulaSelectInfo._repeated_selectFormulaIdList_codec);
			if (this.rollFormulaCostData_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RollFormulaCostData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x001BF068 File Offset: 0x001BD268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RollFormulaMaxCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollFormulaMaxCount);
			}
			num += this.handbookUnlockFormulaIdList_.CalculateSize(RogueFormulaSelectInfo._repeated_handbookUnlockFormulaIdList_codec);
			num += this.selectFormulaIdList_.CalculateSize(RogueFormulaSelectInfo._repeated_selectFormulaIdList_codec);
			if (this.CanRoll)
			{
				num += 2;
			}
			if (this.rollFormulaCostData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RollFormulaCostData);
			}
			if (this.HintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HintId);
			}
			if (this.RollFormulaFreeCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollFormulaFreeCount);
			}
			if (this.RollFormulaCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollFormulaCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x001BF138 File Offset: 0x001BD338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueFormulaSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RollFormulaMaxCount != 0U)
			{
				this.RollFormulaMaxCount = other.RollFormulaMaxCount;
			}
			this.handbookUnlockFormulaIdList_.Add(other.handbookUnlockFormulaIdList_);
			this.selectFormulaIdList_.Add(other.selectFormulaIdList_);
			if (other.CanRoll)
			{
				this.CanRoll = other.CanRoll;
			}
			if (other.rollFormulaCostData_ != null)
			{
				if (this.rollFormulaCostData_ == null)
				{
					this.RollFormulaCostData = new ItemCostData();
				}
				this.RollFormulaCostData.MergeFrom(other.RollFormulaCostData);
			}
			if (other.HintId != 0U)
			{
				this.HintId = other.HintId;
			}
			if (other.RollFormulaFreeCount != 0U)
			{
				this.RollFormulaFreeCount = other.RollFormulaFreeCount;
			}
			if (other.RollFormulaCount != 0U)
			{
				this.RollFormulaCount = other.RollFormulaCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x001BF212 File Offset: 0x001BD412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x001BF21C File Offset: 0x001BD41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num <= 48U)
					{
						if (num == 32U)
						{
							this.RollFormulaFreeCount = input.ReadUInt32();
							continue;
						}
						if (num == 48U)
						{
							this.HintId = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.CanRoll = input.ReadBool();
							continue;
						}
						if (num == 80U)
						{
							this.RollFormulaCount = input.ReadUInt32();
							continue;
						}
						if (num == 88U)
						{
							this.RollFormulaMaxCount = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num == 96U || num == 98U)
					{
						this.handbookUnlockFormulaIdList_.AddEntriesFrom(ref input, RogueFormulaSelectInfo._repeated_handbookUnlockFormulaIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U || num == 106U)
					{
						this.selectFormulaIdList_.AddEntriesFrom(ref input, RogueFormulaSelectInfo._repeated_selectFormulaIdList_codec);
						continue;
					}
					if (num == 122U)
					{
						if (this.rollFormulaCostData_ == null)
						{
							this.RollFormulaCostData = new ItemCostData();
						}
						input.ReadMessage(this.RollFormulaCostData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040043E0 RID: 17376
		private static readonly MessageParser<RogueFormulaSelectInfo> _parser = new MessageParser<RogueFormulaSelectInfo>(() => new RogueFormulaSelectInfo());

		// Token: 0x040043E1 RID: 17377
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043E2 RID: 17378
		public const int RollFormulaMaxCountFieldNumber = 11;

		// Token: 0x040043E3 RID: 17379
		private uint rollFormulaMaxCount_;

		// Token: 0x040043E4 RID: 17380
		public const int HandbookUnlockFormulaIdListFieldNumber = 12;

		// Token: 0x040043E5 RID: 17381
		private static readonly FieldCodec<uint> _repeated_handbookUnlockFormulaIdList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x040043E6 RID: 17382
		private readonly RepeatedField<uint> handbookUnlockFormulaIdList_ = new RepeatedField<uint>();

		// Token: 0x040043E7 RID: 17383
		public const int SelectFormulaIdListFieldNumber = 13;

		// Token: 0x040043E8 RID: 17384
		private static readonly FieldCodec<uint> _repeated_selectFormulaIdList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x040043E9 RID: 17385
		private readonly RepeatedField<uint> selectFormulaIdList_ = new RepeatedField<uint>();

		// Token: 0x040043EA RID: 17386
		public const int CanRollFieldNumber = 7;

		// Token: 0x040043EB RID: 17387
		private bool canRoll_;

		// Token: 0x040043EC RID: 17388
		public const int RollFormulaCostDataFieldNumber = 15;

		// Token: 0x040043ED RID: 17389
		private ItemCostData rollFormulaCostData_;

		// Token: 0x040043EE RID: 17390
		public const int HintIdFieldNumber = 6;

		// Token: 0x040043EF RID: 17391
		private uint hintId_;

		// Token: 0x040043F0 RID: 17392
		public const int RollFormulaFreeCountFieldNumber = 4;

		// Token: 0x040043F1 RID: 17393
		private uint rollFormulaFreeCount_;

		// Token: 0x040043F2 RID: 17394
		public const int RollFormulaCountFieldNumber = 10;

		// Token: 0x040043F3 RID: 17395
		private uint rollFormulaCount_;
	}
}
