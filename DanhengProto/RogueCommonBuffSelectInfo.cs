using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E3B RID: 3643
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonBuffSelectInfo : IMessage<RogueCommonBuffSelectInfo>, IMessage, IEquatable<RogueCommonBuffSelectInfo>, IDeepCloneable<RogueCommonBuffSelectInfo>, IBufferMessage
	{
		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x0600A27D RID: 41597 RVA: 0x001B4D75 File Offset: 0x001B2F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonBuffSelectInfo> Parser
		{
			get
			{
				return RogueCommonBuffSelectInfo._parser;
			}
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x0600A27E RID: 41598 RVA: 0x001B4D7C File Offset: 0x001B2F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonBuffSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x0600A27F RID: 41599 RVA: 0x001B4D8E File Offset: 0x001B2F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonBuffSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600A280 RID: 41600 RVA: 0x001B4D95 File Offset: 0x001B2F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuffSelectInfo()
		{
		}

		// Token: 0x0600A281 RID: 41601 RVA: 0x001B4DC0 File Offset: 0x001B2FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuffSelectInfo(RogueCommonBuffSelectInfo other) : this()
		{
			this.selectBuffList_ = other.selectBuffList_.Clone();
			this.canRoll_ = other.canRoll_;
			this.firstBuffTypeList_ = other.firstBuffTypeList_.Clone();
			this.rollBuffCount_ = other.rollBuffCount_;
			this.sourceHintId_ = other.sourceHintId_;
			this.rollBuffCostData_ = ((other.rollBuffCostData_ != null) ? other.rollBuffCostData_.Clone() : null);
			this.rollBuffMaxCount_ = other.rollBuffMaxCount_;
			this.sourceTotalCount_ = other.sourceTotalCount_;
			this.sourceType_ = other.sourceType_;
			this.sourceCurCount_ = other.sourceCurCount_;
			this.rollBuffFreeCount_ = other.rollBuffFreeCount_;
			this.certainSelectBuffId_ = other.certainSelectBuffId_;
			this.handbookUnlockBuffIdList_ = other.handbookUnlockBuffIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x001B4E9F File Offset: 0x001B309F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuffSelectInfo Clone()
		{
			return new RogueCommonBuffSelectInfo(this);
		}

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x0600A283 RID: 41603 RVA: 0x001B4EA7 File Offset: 0x001B30A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonBuff> SelectBuffList
		{
			get
			{
				return this.selectBuffList_;
			}
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x0600A284 RID: 41604 RVA: 0x001B4EAF File Offset: 0x001B30AF
		// (set) Token: 0x0600A285 RID: 41605 RVA: 0x001B4EB7 File Offset: 0x001B30B7
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

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x0600A286 RID: 41606 RVA: 0x001B4EC0 File Offset: 0x001B30C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FirstBuffTypeList
		{
			get
			{
				return this.firstBuffTypeList_;
			}
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x0600A287 RID: 41607 RVA: 0x001B4EC8 File Offset: 0x001B30C8
		// (set) Token: 0x0600A288 RID: 41608 RVA: 0x001B4ED0 File Offset: 0x001B30D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollBuffCount
		{
			get
			{
				return this.rollBuffCount_;
			}
			set
			{
				this.rollBuffCount_ = value;
			}
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x0600A289 RID: 41609 RVA: 0x001B4ED9 File Offset: 0x001B30D9
		// (set) Token: 0x0600A28A RID: 41610 RVA: 0x001B4EE1 File Offset: 0x001B30E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SourceHintId
		{
			get
			{
				return this.sourceHintId_;
			}
			set
			{
				this.sourceHintId_ = value;
			}
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x0600A28B RID: 41611 RVA: 0x001B4EEA File Offset: 0x001B30EA
		// (set) Token: 0x0600A28C RID: 41612 RVA: 0x001B4EF2 File Offset: 0x001B30F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData RollBuffCostData
		{
			get
			{
				return this.rollBuffCostData_;
			}
			set
			{
				this.rollBuffCostData_ = value;
			}
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x0600A28D RID: 41613 RVA: 0x001B4EFB File Offset: 0x001B30FB
		// (set) Token: 0x0600A28E RID: 41614 RVA: 0x001B4F03 File Offset: 0x001B3103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollBuffMaxCount
		{
			get
			{
				return this.rollBuffMaxCount_;
			}
			set
			{
				this.rollBuffMaxCount_ = value;
			}
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x0600A28F RID: 41615 RVA: 0x001B4F0C File Offset: 0x001B310C
		// (set) Token: 0x0600A290 RID: 41616 RVA: 0x001B4F14 File Offset: 0x001B3114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SourceTotalCount
		{
			get
			{
				return this.sourceTotalCount_;
			}
			set
			{
				this.sourceTotalCount_ = value;
			}
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600A291 RID: 41617 RVA: 0x001B4F1D File Offset: 0x001B311D
		// (set) Token: 0x0600A292 RID: 41618 RVA: 0x001B4F25 File Offset: 0x001B3125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuffSelectSourceType SourceType
		{
			get
			{
				return this.sourceType_;
			}
			set
			{
				this.sourceType_ = value;
			}
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600A293 RID: 41619 RVA: 0x001B4F2E File Offset: 0x001B312E
		// (set) Token: 0x0600A294 RID: 41620 RVA: 0x001B4F36 File Offset: 0x001B3136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SourceCurCount
		{
			get
			{
				return this.sourceCurCount_;
			}
			set
			{
				this.sourceCurCount_ = value;
			}
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0600A295 RID: 41621 RVA: 0x001B4F3F File Offset: 0x001B313F
		// (set) Token: 0x0600A296 RID: 41622 RVA: 0x001B4F47 File Offset: 0x001B3147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollBuffFreeCount
		{
			get
			{
				return this.rollBuffFreeCount_;
			}
			set
			{
				this.rollBuffFreeCount_ = value;
			}
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x0600A297 RID: 41623 RVA: 0x001B4F50 File Offset: 0x001B3150
		// (set) Token: 0x0600A298 RID: 41624 RVA: 0x001B4F58 File Offset: 0x001B3158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CertainSelectBuffId
		{
			get
			{
				return this.certainSelectBuffId_;
			}
			set
			{
				this.certainSelectBuffId_ = value;
			}
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x0600A299 RID: 41625 RVA: 0x001B4F61 File Offset: 0x001B3161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HandbookUnlockBuffIdList
		{
			get
			{
				return this.handbookUnlockBuffIdList_;
			}
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x001B4F69 File Offset: 0x001B3169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonBuffSelectInfo);
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x001B4F78 File Offset: 0x001B3178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonBuffSelectInfo other)
		{
			return other != null && (other == this || (this.selectBuffList_.Equals(other.selectBuffList_) && this.CanRoll == other.CanRoll && this.firstBuffTypeList_.Equals(other.firstBuffTypeList_) && this.RollBuffCount == other.RollBuffCount && this.SourceHintId == other.SourceHintId && object.Equals(this.RollBuffCostData, other.RollBuffCostData) && this.RollBuffMaxCount == other.RollBuffMaxCount && this.SourceTotalCount == other.SourceTotalCount && this.SourceType == other.SourceType && this.SourceCurCount == other.SourceCurCount && this.RollBuffFreeCount == other.RollBuffFreeCount && this.CertainSelectBuffId == other.CertainSelectBuffId && this.handbookUnlockBuffIdList_.Equals(other.handbookUnlockBuffIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x001B5088 File Offset: 0x001B3288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.selectBuffList_.GetHashCode();
			if (this.CanRoll)
			{
				num ^= this.CanRoll.GetHashCode();
			}
			num ^= this.firstBuffTypeList_.GetHashCode();
			if (this.RollBuffCount != 0U)
			{
				num ^= this.RollBuffCount.GetHashCode();
			}
			if (this.SourceHintId != 0U)
			{
				num ^= this.SourceHintId.GetHashCode();
			}
			if (this.rollBuffCostData_ != null)
			{
				num ^= this.RollBuffCostData.GetHashCode();
			}
			if (this.RollBuffMaxCount != 0U)
			{
				num ^= this.RollBuffMaxCount.GetHashCode();
			}
			if (this.SourceTotalCount != 0U)
			{
				num ^= this.SourceTotalCount.GetHashCode();
			}
			if (this.SourceType != RogueCommonBuffSelectSourceType.None)
			{
				num ^= this.SourceType.GetHashCode();
			}
			if (this.SourceCurCount != 0U)
			{
				num ^= this.SourceCurCount.GetHashCode();
			}
			if (this.RollBuffFreeCount != 0U)
			{
				num ^= this.RollBuffFreeCount.GetHashCode();
			}
			if (this.CertainSelectBuffId != 0U)
			{
				num ^= this.CertainSelectBuffId.GetHashCode();
			}
			num ^= this.handbookUnlockBuffIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A29D RID: 41629 RVA: 0x001B51D5 File Offset: 0x001B33D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x001B51DD File Offset: 0x001B33DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A29F RID: 41631 RVA: 0x001B51E8 File Offset: 0x001B33E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RollBuffMaxCount != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RollBuffMaxCount);
			}
			if (this.CertainSelectBuffId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CertainSelectBuffId);
			}
			this.selectBuffList_.WriteTo(ref output, RogueCommonBuffSelectInfo._repeated_selectBuffList_codec);
			if (this.RollBuffCount != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RollBuffCount);
			}
			if (this.rollBuffCostData_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RollBuffCostData);
			}
			if (this.SourceCurCount != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.SourceCurCount);
			}
			this.firstBuffTypeList_.WriteTo(ref output, RogueCommonBuffSelectInfo._repeated_firstBuffTypeList_codec);
			if (this.SourceHintId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.SourceHintId);
			}
			if (this.CanRoll)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.CanRoll);
			}
			if (this.SourceType != RogueCommonBuffSelectSourceType.None)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.SourceType);
			}
			if (this.RollBuffFreeCount != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.RollBuffFreeCount);
			}
			if (this.SourceTotalCount != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.SourceTotalCount);
			}
			this.handbookUnlockBuffIdList_.WriteTo(ref output, RogueCommonBuffSelectInfo._repeated_handbookUnlockBuffIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x001B5354 File Offset: 0x001B3554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.selectBuffList_.CalculateSize(RogueCommonBuffSelectInfo._repeated_selectBuffList_codec);
			if (this.CanRoll)
			{
				num += 2;
			}
			num += this.firstBuffTypeList_.CalculateSize(RogueCommonBuffSelectInfo._repeated_firstBuffTypeList_codec);
			if (this.RollBuffCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollBuffCount);
			}
			if (this.SourceHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SourceHintId);
			}
			if (this.rollBuffCostData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RollBuffCostData);
			}
			if (this.RollBuffMaxCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollBuffMaxCount);
			}
			if (this.SourceTotalCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SourceTotalCount);
			}
			if (this.SourceType != RogueCommonBuffSelectSourceType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SourceType);
			}
			if (this.SourceCurCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SourceCurCount);
			}
			if (this.RollBuffFreeCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollBuffFreeCount);
			}
			if (this.CertainSelectBuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CertainSelectBuffId);
			}
			num += this.handbookUnlockBuffIdList_.CalculateSize(RogueCommonBuffSelectInfo._repeated_handbookUnlockBuffIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x001B5498 File Offset: 0x001B3698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonBuffSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.selectBuffList_.Add(other.selectBuffList_);
			if (other.CanRoll)
			{
				this.CanRoll = other.CanRoll;
			}
			this.firstBuffTypeList_.Add(other.firstBuffTypeList_);
			if (other.RollBuffCount != 0U)
			{
				this.RollBuffCount = other.RollBuffCount;
			}
			if (other.SourceHintId != 0U)
			{
				this.SourceHintId = other.SourceHintId;
			}
			if (other.rollBuffCostData_ != null)
			{
				if (this.rollBuffCostData_ == null)
				{
					this.RollBuffCostData = new ItemCostData();
				}
				this.RollBuffCostData.MergeFrom(other.RollBuffCostData);
			}
			if (other.RollBuffMaxCount != 0U)
			{
				this.RollBuffMaxCount = other.RollBuffMaxCount;
			}
			if (other.SourceTotalCount != 0U)
			{
				this.SourceTotalCount = other.SourceTotalCount;
			}
			if (other.SourceType != RogueCommonBuffSelectSourceType.None)
			{
				this.SourceType = other.SourceType;
			}
			if (other.SourceCurCount != 0U)
			{
				this.SourceCurCount = other.SourceCurCount;
			}
			if (other.RollBuffFreeCount != 0U)
			{
				this.RollBuffFreeCount = other.RollBuffFreeCount;
			}
			if (other.CertainSelectBuffId != 0U)
			{
				this.CertainSelectBuffId = other.CertainSelectBuffId;
			}
			this.handbookUnlockBuffIdList_.Add(other.handbookUnlockBuffIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x001B55D3 File Offset: 0x001B37D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x001B55DC File Offset: 0x001B37DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.RollBuffMaxCount = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.CertainSelectBuffId = input.ReadUInt32();
							continue;
						}
						if (num == 26U)
						{
							this.selectBuffList_.AddEntriesFrom(ref input, RogueCommonBuffSelectInfo._repeated_selectBuffList_codec);
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 32U)
						{
							this.RollBuffCount = input.ReadUInt32();
							continue;
						}
						if (num == 42U)
						{
							if (this.rollBuffCostData_ == null)
							{
								this.RollBuffCostData = new ItemCostData();
							}
							input.ReadMessage(this.RollBuffCostData);
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.SourceCurCount = input.ReadUInt32();
							continue;
						}
						if (num == 56U)
						{
							goto IL_135;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num <= 64U)
					{
						if (num == 58U)
						{
							goto IL_135;
						}
						if (num == 64U)
						{
							this.SourceHintId = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 88U)
						{
							this.CanRoll = input.ReadBool();
							continue;
						}
						if (num == 96U)
						{
							this.SourceType = (RogueCommonBuffSelectSourceType)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 112U)
				{
					if (num == 104U)
					{
						this.RollBuffFreeCount = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.SourceTotalCount = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.handbookUnlockBuffIdList_.AddEntriesFrom(ref input, RogueCommonBuffSelectInfo._repeated_handbookUnlockBuffIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_135:
				this.firstBuffTypeList_.AddEntriesFrom(ref input, RogueCommonBuffSelectInfo._repeated_firstBuffTypeList_codec);
			}
		}

		// Token: 0x04004280 RID: 17024
		private static readonly MessageParser<RogueCommonBuffSelectInfo> _parser = new MessageParser<RogueCommonBuffSelectInfo>(() => new RogueCommonBuffSelectInfo());

		// Token: 0x04004281 RID: 17025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004282 RID: 17026
		public const int SelectBuffListFieldNumber = 3;

		// Token: 0x04004283 RID: 17027
		private static readonly FieldCodec<RogueCommonBuff> _repeated_selectBuffList_codec = FieldCodec.ForMessage<RogueCommonBuff>(26U, RogueCommonBuff.Parser);

		// Token: 0x04004284 RID: 17028
		private readonly RepeatedField<RogueCommonBuff> selectBuffList_ = new RepeatedField<RogueCommonBuff>();

		// Token: 0x04004285 RID: 17029
		public const int CanRollFieldNumber = 11;

		// Token: 0x04004286 RID: 17030
		private bool canRoll_;

		// Token: 0x04004287 RID: 17031
		public const int FirstBuffTypeListFieldNumber = 7;

		// Token: 0x04004288 RID: 17032
		private static readonly FieldCodec<uint> _repeated_firstBuffTypeList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04004289 RID: 17033
		private readonly RepeatedField<uint> firstBuffTypeList_ = new RepeatedField<uint>();

		// Token: 0x0400428A RID: 17034
		public const int RollBuffCountFieldNumber = 4;

		// Token: 0x0400428B RID: 17035
		private uint rollBuffCount_;

		// Token: 0x0400428C RID: 17036
		public const int SourceHintIdFieldNumber = 8;

		// Token: 0x0400428D RID: 17037
		private uint sourceHintId_;

		// Token: 0x0400428E RID: 17038
		public const int RollBuffCostDataFieldNumber = 5;

		// Token: 0x0400428F RID: 17039
		private ItemCostData rollBuffCostData_;

		// Token: 0x04004290 RID: 17040
		public const int RollBuffMaxCountFieldNumber = 1;

		// Token: 0x04004291 RID: 17041
		private uint rollBuffMaxCount_;

		// Token: 0x04004292 RID: 17042
		public const int SourceTotalCountFieldNumber = 14;

		// Token: 0x04004293 RID: 17043
		private uint sourceTotalCount_;

		// Token: 0x04004294 RID: 17044
		public const int SourceTypeFieldNumber = 12;

		// Token: 0x04004295 RID: 17045
		private RogueCommonBuffSelectSourceType sourceType_;

		// Token: 0x04004296 RID: 17046
		public const int SourceCurCountFieldNumber = 6;

		// Token: 0x04004297 RID: 17047
		private uint sourceCurCount_;

		// Token: 0x04004298 RID: 17048
		public const int RollBuffFreeCountFieldNumber = 13;

		// Token: 0x04004299 RID: 17049
		private uint rollBuffFreeCount_;

		// Token: 0x0400429A RID: 17050
		public const int CertainSelectBuffIdFieldNumber = 2;

		// Token: 0x0400429B RID: 17051
		private uint certainSelectBuffId_;

		// Token: 0x0400429C RID: 17052
		public const int HandbookUnlockBuffIdListFieldNumber = 15;

		// Token: 0x0400429D RID: 17053
		private static readonly FieldCodec<uint> _repeated_handbookUnlockBuffIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x0400429E RID: 17054
		private readonly RepeatedField<uint> handbookUnlockBuffIdList_ = new RepeatedField<uint>();
	}
}
