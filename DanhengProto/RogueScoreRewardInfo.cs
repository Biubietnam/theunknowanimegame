using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F71 RID: 3953
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueScoreRewardInfo : IMessage<RogueScoreRewardInfo>, IMessage, IEquatable<RogueScoreRewardInfo>, IDeepCloneable<RogueScoreRewardInfo>, IBufferMessage
	{
		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600B023 RID: 45091 RVA: 0x001D92D3 File Offset: 0x001D74D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueScoreRewardInfo> Parser
		{
			get
			{
				return RogueScoreRewardInfo._parser;
			}
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600B024 RID: 45092 RVA: 0x001D92DA File Offset: 0x001D74DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueScoreRewardInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600B025 RID: 45093 RVA: 0x001D92EC File Offset: 0x001D74EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueScoreRewardInfo.Descriptor;
			}
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x001D92F3 File Offset: 0x001D74F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo()
		{
		}

		// Token: 0x0600B027 RID: 45095 RVA: 0x001D9308 File Offset: 0x001D7508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo(RogueScoreRewardInfo other) : this()
		{
			this.exploreScore_ = other.exploreScore_;
			this.hasTakenInitialScore_ = other.hasTakenInitialScore_;
			this.rewardBeginTime_ = other.rewardBeginTime_;
			this.poolRefreshed_ = other.poolRefreshed_;
			this.poolId_ = other.poolId_;
			this.takenNormalFreeRowList_ = other.takenNormalFreeRowList_.Clone();
			this.rewardEndTime_ = other.rewardEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B028 RID: 45096 RVA: 0x001D9385 File Offset: 0x001D7585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo Clone()
		{
			return new RogueScoreRewardInfo(this);
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600B029 RID: 45097 RVA: 0x001D938D File Offset: 0x001D758D
		// (set) Token: 0x0600B02A RID: 45098 RVA: 0x001D9395 File Offset: 0x001D7595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ExploreScore
		{
			get
			{
				return this.exploreScore_;
			}
			set
			{
				this.exploreScore_ = value;
			}
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600B02B RID: 45099 RVA: 0x001D939E File Offset: 0x001D759E
		// (set) Token: 0x0600B02C RID: 45100 RVA: 0x001D93A6 File Offset: 0x001D75A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTakenInitialScore
		{
			get
			{
				return this.hasTakenInitialScore_;
			}
			set
			{
				this.hasTakenInitialScore_ = value;
			}
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600B02D RID: 45101 RVA: 0x001D93AF File Offset: 0x001D75AF
		// (set) Token: 0x0600B02E RID: 45102 RVA: 0x001D93B7 File Offset: 0x001D75B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RewardBeginTime
		{
			get
			{
				return this.rewardBeginTime_;
			}
			set
			{
				this.rewardBeginTime_ = value;
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600B02F RID: 45103 RVA: 0x001D93C0 File Offset: 0x001D75C0
		// (set) Token: 0x0600B030 RID: 45104 RVA: 0x001D93C8 File Offset: 0x001D75C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PoolRefreshed
		{
			get
			{
				return this.poolRefreshed_;
			}
			set
			{
				this.poolRefreshed_ = value;
			}
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0600B031 RID: 45105 RVA: 0x001D93D1 File Offset: 0x001D75D1
		// (set) Token: 0x0600B032 RID: 45106 RVA: 0x001D93D9 File Offset: 0x001D75D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PoolId
		{
			get
			{
				return this.poolId_;
			}
			set
			{
				this.poolId_ = value;
			}
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0600B033 RID: 45107 RVA: 0x001D93E2 File Offset: 0x001D75E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TakenNormalFreeRowList
		{
			get
			{
				return this.takenNormalFreeRowList_;
			}
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0600B034 RID: 45108 RVA: 0x001D93EA File Offset: 0x001D75EA
		// (set) Token: 0x0600B035 RID: 45109 RVA: 0x001D93F2 File Offset: 0x001D75F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RewardEndTime
		{
			get
			{
				return this.rewardEndTime_;
			}
			set
			{
				this.rewardEndTime_ = value;
			}
		}

		// Token: 0x0600B036 RID: 45110 RVA: 0x001D93FB File Offset: 0x001D75FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueScoreRewardInfo);
		}

		// Token: 0x0600B037 RID: 45111 RVA: 0x001D940C File Offset: 0x001D760C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueScoreRewardInfo other)
		{
			return other != null && (other == this || (this.ExploreScore == other.ExploreScore && this.HasTakenInitialScore == other.HasTakenInitialScore && this.RewardBeginTime == other.RewardBeginTime && this.PoolRefreshed == other.PoolRefreshed && this.PoolId == other.PoolId && this.takenNormalFreeRowList_.Equals(other.takenNormalFreeRowList_) && this.RewardEndTime == other.RewardEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B038 RID: 45112 RVA: 0x001D94AC File Offset: 0x001D76AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExploreScore != 0U)
			{
				num ^= this.ExploreScore.GetHashCode();
			}
			if (this.HasTakenInitialScore)
			{
				num ^= this.HasTakenInitialScore.GetHashCode();
			}
			if (this.RewardBeginTime != 0L)
			{
				num ^= this.RewardBeginTime.GetHashCode();
			}
			if (this.PoolRefreshed)
			{
				num ^= this.PoolRefreshed.GetHashCode();
			}
			if (this.PoolId != 0U)
			{
				num ^= this.PoolId.GetHashCode();
			}
			num ^= this.takenNormalFreeRowList_.GetHashCode();
			if (this.RewardEndTime != 0L)
			{
				num ^= this.RewardEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B039 RID: 45113 RVA: 0x001D9576 File Offset: 0x001D7776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B03A RID: 45114 RVA: 0x001D957E File Offset: 0x001D777E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B03B RID: 45115 RVA: 0x001D9588 File Offset: 0x001D7788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.takenNormalFreeRowList_.WriteTo(ref output, RogueScoreRewardInfo._repeated_takenNormalFreeRowList_codec);
			if (this.PoolId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.PoolId);
			}
			if (this.HasTakenInitialScore)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.HasTakenInitialScore);
			}
			if (this.ExploreScore != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ExploreScore);
			}
			if (this.RewardBeginTime != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.RewardBeginTime);
			}
			if (this.PoolRefreshed)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.PoolRefreshed);
			}
			if (this.RewardEndTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.RewardEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x001D9664 File Offset: 0x001D7864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExploreScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExploreScore);
			}
			if (this.HasTakenInitialScore)
			{
				num += 2;
			}
			if (this.RewardBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RewardBeginTime);
			}
			if (this.PoolRefreshed)
			{
				num += 2;
			}
			if (this.PoolId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PoolId);
			}
			num += this.takenNormalFreeRowList_.CalculateSize(RogueScoreRewardInfo._repeated_takenNormalFreeRowList_codec);
			if (this.RewardEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RewardEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x001D9718 File Offset: 0x001D7918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueScoreRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExploreScore != 0U)
			{
				this.ExploreScore = other.ExploreScore;
			}
			if (other.HasTakenInitialScore)
			{
				this.HasTakenInitialScore = other.HasTakenInitialScore;
			}
			if (other.RewardBeginTime != 0L)
			{
				this.RewardBeginTime = other.RewardBeginTime;
			}
			if (other.PoolRefreshed)
			{
				this.PoolRefreshed = other.PoolRefreshed;
			}
			if (other.PoolId != 0U)
			{
				this.PoolId = other.PoolId;
			}
			this.takenNormalFreeRowList_.Add(other.takenNormalFreeRowList_);
			if (other.RewardEndTime != 0L)
			{
				this.RewardEndTime = other.RewardEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x001D97C9 File Offset: 0x001D79C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B03F RID: 45119 RVA: 0x001D97D4 File Offset: 0x001D79D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.takenNormalFreeRowList_.AddEntriesFrom(ref input, RogueScoreRewardInfo._repeated_takenNormalFreeRowList_codec);
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.PoolId = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.HasTakenInitialScore = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 56U)
					{
						this.ExploreScore = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.RewardBeginTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.PoolRefreshed = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.RewardEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047A2 RID: 18338
		private static readonly MessageParser<RogueScoreRewardInfo> _parser = new MessageParser<RogueScoreRewardInfo>(() => new RogueScoreRewardInfo());

		// Token: 0x040047A3 RID: 18339
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047A4 RID: 18340
		public const int ExploreScoreFieldNumber = 7;

		// Token: 0x040047A5 RID: 18341
		private uint exploreScore_;

		// Token: 0x040047A6 RID: 18342
		public const int HasTakenInitialScoreFieldNumber = 5;

		// Token: 0x040047A7 RID: 18343
		private bool hasTakenInitialScore_;

		// Token: 0x040047A8 RID: 18344
		public const int RewardBeginTimeFieldNumber = 12;

		// Token: 0x040047A9 RID: 18345
		private long rewardBeginTime_;

		// Token: 0x040047AA RID: 18346
		public const int PoolRefreshedFieldNumber = 13;

		// Token: 0x040047AB RID: 18347
		private bool poolRefreshed_;

		// Token: 0x040047AC RID: 18348
		public const int PoolIdFieldNumber = 4;

		// Token: 0x040047AD RID: 18349
		private uint poolId_;

		// Token: 0x040047AE RID: 18350
		public const int TakenNormalFreeRowListFieldNumber = 1;

		// Token: 0x040047AF RID: 18351
		private static readonly FieldCodec<uint> _repeated_takenNormalFreeRowList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x040047B0 RID: 18352
		private readonly RepeatedField<uint> takenNormalFreeRowList_ = new RepeatedField<uint>();

		// Token: 0x040047B1 RID: 18353
		public const int RewardEndTimeFieldNumber = 14;

		// Token: 0x040047B2 RID: 18354
		private long rewardEndTime_;
	}
}
