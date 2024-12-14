using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200033D RID: 829
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CurChallenge : IMessage<CurChallenge>, IMessage, IEquatable<CurChallenge>, IDeepCloneable<CurChallenge>, IBufferMessage
	{
		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x000687D2 File Offset: 0x000669D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CurChallenge> Parser
		{
			get
			{
				return CurChallenge._parser;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x000687D9 File Offset: 0x000669D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CurChallengeReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x000687EB File Offset: 0x000669EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CurChallenge.Descriptor;
			}
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000687F2 File Offset: 0x000669F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurChallenge()
		{
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00068808 File Offset: 0x00066A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurChallenge(CurChallenge other) : this()
		{
			this.extraLineupType_ = other.extraLineupType_;
			this.challengeId_ = other.challengeId_;
			this.roundCount_ = other.roundCount_;
			this.scoreTwo_ = other.scoreTwo_;
			this.killMonsterList_ = other.killMonsterList_.Clone();
			this.scoreId_ = other.scoreId_;
			this.deadAvatarNum_ = other.deadAvatarNum_;
			this.status_ = other.status_;
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000688AD File Offset: 0x00066AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurChallenge Clone()
		{
			return new CurChallenge(this);
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x0600250E RID: 9486 RVA: 0x000688B5 File Offset: 0x00066AB5
		// (set) Token: 0x0600250F RID: 9487 RVA: 0x000688BD File Offset: 0x00066ABD
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

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x000688C6 File Offset: 0x00066AC6
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x000688CE File Offset: 0x00066ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x000688D7 File Offset: 0x00066AD7
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x000688DF File Offset: 0x00066ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoundCount
		{
			get
			{
				return this.roundCount_;
			}
			set
			{
				this.roundCount_ = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000688E8 File Offset: 0x00066AE8
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x000688F0 File Offset: 0x00066AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreTwo
		{
			get
			{
				return this.scoreTwo_;
			}
			set
			{
				this.scoreTwo_ = value;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000688F9 File Offset: 0x00066AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KillMonster> KillMonsterList
		{
			get
			{
				return this.killMonsterList_;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x00068901 File Offset: 0x00066B01
		// (set) Token: 0x06002518 RID: 9496 RVA: 0x00068909 File Offset: 0x00066B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x00068912 File Offset: 0x00066B12
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x0006891A File Offset: 0x00066B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DeadAvatarNum
		{
			get
			{
				return this.deadAvatarNum_;
			}
			set
			{
				this.deadAvatarNum_ = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x00068923 File Offset: 0x00066B23
		// (set) Token: 0x0600251C RID: 9500 RVA: 0x0006892B File Offset: 0x00066B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x00068934 File Offset: 0x00066B34
		// (set) Token: 0x0600251E RID: 9502 RVA: 0x0006893C File Offset: 0x00066B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryInfo StageInfo
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

		// Token: 0x0600251F RID: 9503 RVA: 0x00068945 File Offset: 0x00066B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CurChallenge);
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00068954 File Offset: 0x00066B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CurChallenge other)
		{
			return other != null && (other == this || (this.ExtraLineupType == other.ExtraLineupType && this.ChallengeId == other.ChallengeId && this.RoundCount == other.RoundCount && this.ScoreTwo == other.ScoreTwo && this.killMonsterList_.Equals(other.killMonsterList_) && this.ScoreId == other.ScoreId && this.DeadAvatarNum == other.DeadAvatarNum && this.Status == other.Status && object.Equals(this.StageInfo, other.StageInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x00068A18 File Offset: 0x00066C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num ^= this.ExtraLineupType.GetHashCode();
			}
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.RoundCount != 0U)
			{
				num ^= this.RoundCount.GetHashCode();
			}
			if (this.ScoreTwo != 0U)
			{
				num ^= this.ScoreTwo.GetHashCode();
			}
			num ^= this.killMonsterList_.GetHashCode();
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.DeadAvatarNum != 0U)
			{
				num ^= this.DeadAvatarNum.GetHashCode();
			}
			if (this.Status != ChallengeStatus.ChallengeUnknown)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x00068B1D File Offset: 0x00066D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x00068B25 File Offset: 0x00066D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00068B30 File Offset: 0x00066D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoundCount != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RoundCount);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.StageInfo);
			}
			this.killMonsterList_.WriteTo(ref output, CurChallenge._repeated_killMonsterList_codec);
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.Status != ChallengeStatus.ChallengeUnknown)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Status);
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ExtraLineupType);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.ScoreTwo != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ScoreTwo);
			}
			if (this.DeadAvatarNum != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.DeadAvatarNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00068C44 File Offset: 0x00066E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ExtraLineupType);
			}
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.RoundCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoundCount);
			}
			if (this.ScoreTwo != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreTwo);
			}
			num += this.killMonsterList_.CalculateSize(CurChallenge._repeated_killMonsterList_codec);
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.DeadAvatarNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DeadAvatarNum);
			}
			if (this.Status != ChallengeStatus.ChallengeUnknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x00068D40 File Offset: 0x00066F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CurChallenge other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				this.ExtraLineupType = other.ExtraLineupType;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.RoundCount != 0U)
			{
				this.RoundCount = other.RoundCount;
			}
			if (other.ScoreTwo != 0U)
			{
				this.ScoreTwo = other.ScoreTwo;
			}
			this.killMonsterList_.Add(other.killMonsterList_);
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.DeadAvatarNum != 0U)
			{
				this.DeadAvatarNum = other.DeadAvatarNum;
			}
			if (other.Status != ChallengeStatus.ChallengeUnknown)
			{
				this.Status = other.Status;
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new ChallengeStoryInfo();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00068E31 File Offset: 0x00067031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x00068E3C File Offset: 0x0006703C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.RoundCount = input.ReadUInt32();
							continue;
						}
						if (num == 18U)
						{
							if (this.stageInfo_ == null)
							{
								this.StageInfo = new ChallengeStoryInfo();
							}
							input.ReadMessage(this.StageInfo);
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							this.killMonsterList_.AddEntriesFrom(ref input, CurChallenge._repeated_killMonsterList_codec);
							continue;
						}
						if (num == 48U)
						{
							this.ChallengeId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 64U)
					{
						this.Status = (ChallengeStatus)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.ExtraLineupType = (ExtraLineupType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ScoreTwo = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.DeadAvatarNum = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F12 RID: 3858
		private static readonly MessageParser<CurChallenge> _parser = new MessageParser<CurChallenge>(() => new CurChallenge());

		// Token: 0x04000F13 RID: 3859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F14 RID: 3860
		public const int ExtraLineupTypeFieldNumber = 9;

		// Token: 0x04000F15 RID: 3861
		private ExtraLineupType extraLineupType_;

		// Token: 0x04000F16 RID: 3862
		public const int ChallengeIdFieldNumber = 6;

		// Token: 0x04000F17 RID: 3863
		private uint challengeId_;

		// Token: 0x04000F18 RID: 3864
		public const int RoundCountFieldNumber = 1;

		// Token: 0x04000F19 RID: 3865
		private uint roundCount_;

		// Token: 0x04000F1A RID: 3866
		public const int ScoreTwoFieldNumber = 13;

		// Token: 0x04000F1B RID: 3867
		private uint scoreTwo_;

		// Token: 0x04000F1C RID: 3868
		public const int KillMonsterListFieldNumber = 5;

		// Token: 0x04000F1D RID: 3869
		private static readonly FieldCodec<KillMonster> _repeated_killMonsterList_codec = FieldCodec.ForMessage<KillMonster>(42U, KillMonster.Parser);

		// Token: 0x04000F1E RID: 3870
		private readonly RepeatedField<KillMonster> killMonsterList_ = new RepeatedField<KillMonster>();

		// Token: 0x04000F1F RID: 3871
		public const int ScoreIdFieldNumber = 12;

		// Token: 0x04000F20 RID: 3872
		private uint scoreId_;

		// Token: 0x04000F21 RID: 3873
		public const int DeadAvatarNumFieldNumber = 14;

		// Token: 0x04000F22 RID: 3874
		private uint deadAvatarNum_;

		// Token: 0x04000F23 RID: 3875
		public const int StatusFieldNumber = 8;

		// Token: 0x04000F24 RID: 3876
		private ChallengeStatus status_;

		// Token: 0x04000F25 RID: 3877
		public const int StageInfoFieldNumber = 2;

		// Token: 0x04000F26 RID: 3878
		private ChallengeStoryInfo stageInfo_;
	}
}
