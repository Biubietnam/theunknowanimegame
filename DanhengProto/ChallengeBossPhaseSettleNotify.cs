using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200019B RID: 411
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBossPhaseSettleNotify : IMessage<ChallengeBossPhaseSettleNotify>, IMessage, IEquatable<ChallengeBossPhaseSettleNotify>, IDeepCloneable<ChallengeBossPhaseSettleNotify>, IBufferMessage
	{
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x000351A5 File Offset: 0x000333A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBossPhaseSettleNotify> Parser
		{
			get
			{
				return ChallengeBossPhaseSettleNotify._parser;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x000351AC File Offset: 0x000333AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBossPhaseSettleNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x000351BE File Offset: 0x000333BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBossPhaseSettleNotify.Descriptor;
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x000351C5 File Offset: 0x000333C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossPhaseSettleNotify()
		{
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000351D8 File Offset: 0x000333D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossPhaseSettleNotify(ChallengeBossPhaseSettleNotify other) : this()
		{
			this.isWin_ = other.isWin_;
			this.isReward_ = other.isReward_;
			this.star_ = other.star_;
			this.battleTargetList_ = other.battleTargetList_.Clone();
			this.scoreTwo_ = other.scoreTwo_;
			this.challengeScore_ = other.challengeScore_;
			this.isRemainingAction_ = other.isRemainingAction_;
			this.challengeId_ = other.challengeId_;
			this.oGMPDLCDJDL_ = other.oGMPDLCDJDL_;
			this.phase_ = other.phase_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00035279 File Offset: 0x00033479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossPhaseSettleNotify Clone()
		{
			return new ChallengeBossPhaseSettleNotify(this);
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00035281 File Offset: 0x00033481
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x00035289 File Offset: 0x00033489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00035292 File Offset: 0x00033492
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x0003529A File Offset: 0x0003349A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReward
		{
			get
			{
				return this.isReward_;
			}
			set
			{
				this.isReward_ = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x000352A3 File Offset: 0x000334A3
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x000352AB File Offset: 0x000334AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Star
		{
			get
			{
				return this.star_;
			}
			set
			{
				this.star_ = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x000352B4 File Offset: 0x000334B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleTarget> BattleTargetList
		{
			get
			{
				return this.battleTargetList_;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x000352BC File Offset: 0x000334BC
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x000352C4 File Offset: 0x000334C4
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

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x000352CD File Offset: 0x000334CD
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x000352D5 File Offset: 0x000334D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeScore
		{
			get
			{
				return this.challengeScore_;
			}
			set
			{
				this.challengeScore_ = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x000352DE File Offset: 0x000334DE
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x000352E6 File Offset: 0x000334E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRemainingAction
		{
			get
			{
				return this.isRemainingAction_;
			}
			set
			{
				this.isRemainingAction_ = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x000352EF File Offset: 0x000334EF
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x000352F7 File Offset: 0x000334F7
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00035300 File Offset: 0x00033500
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x00035308 File Offset: 0x00033508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OGMPDLCDJDL
		{
			get
			{
				return this.oGMPDLCDJDL_;
			}
			set
			{
				this.oGMPDLCDJDL_ = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00035311 File Offset: 0x00033511
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x00035319 File Offset: 0x00033519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Phase
		{
			get
			{
				return this.phase_;
			}
			set
			{
				this.phase_ = value;
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00035322 File Offset: 0x00033522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBossPhaseSettleNotify);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00035330 File Offset: 0x00033530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBossPhaseSettleNotify other)
		{
			return other != null && (other == this || (this.IsWin == other.IsWin && this.IsReward == other.IsReward && this.Star == other.Star && this.battleTargetList_.Equals(other.battleTargetList_) && this.ScoreTwo == other.ScoreTwo && this.ChallengeScore == other.ChallengeScore && this.IsRemainingAction == other.IsRemainingAction && this.ChallengeId == other.ChallengeId && this.OGMPDLCDJDL == other.OGMPDLCDJDL && this.Phase == other.Phase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00035400 File Offset: 0x00033600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this.IsReward)
			{
				num ^= this.IsReward.GetHashCode();
			}
			if (this.Star != 0U)
			{
				num ^= this.Star.GetHashCode();
			}
			num ^= this.battleTargetList_.GetHashCode();
			if (this.ScoreTwo != 0U)
			{
				num ^= this.ScoreTwo.GetHashCode();
			}
			if (this.ChallengeScore != 0U)
			{
				num ^= this.ChallengeScore.GetHashCode();
			}
			if (this.IsRemainingAction)
			{
				num ^= this.IsRemainingAction.GetHashCode();
			}
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.OGMPDLCDJDL != 0U)
			{
				num ^= this.OGMPDLCDJDL.GetHashCode();
			}
			if (this.Phase != 0U)
			{
				num ^= this.Phase.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00035515 File Offset: 0x00033715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0003551D File Offset: 0x0003371D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00035528 File Offset: 0x00033728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Phase != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Phase);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ChallengeId);
			}
			this.battleTargetList_.WriteTo(ref output, ChallengeBossPhaseSettleNotify._repeated_battleTargetList_codec);
			if (this.Star != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Star);
			}
			if (this.IsRemainingAction)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsRemainingAction);
			}
			if (this.IsReward)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsReward);
			}
			if (this.OGMPDLCDJDL != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.OGMPDLCDJDL);
			}
			if (this.ChallengeScore != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ChallengeScore);
			}
			if (this.ScoreTwo != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ScoreTwo);
			}
			if (this.IsWin)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsWin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00035658 File Offset: 0x00033858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsWin)
			{
				num += 2;
			}
			if (this.IsReward)
			{
				num += 2;
			}
			if (this.Star != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Star);
			}
			num += this.battleTargetList_.CalculateSize(ChallengeBossPhaseSettleNotify._repeated_battleTargetList_codec);
			if (this.ScoreTwo != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreTwo);
			}
			if (this.ChallengeScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeScore);
			}
			if (this.IsRemainingAction)
			{
				num += 2;
			}
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.OGMPDLCDJDL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OGMPDLCDJDL);
			}
			if (this.Phase != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Phase);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00035748 File Offset: 0x00033948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBossPhaseSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			if (other.IsReward)
			{
				this.IsReward = other.IsReward;
			}
			if (other.Star != 0U)
			{
				this.Star = other.Star;
			}
			this.battleTargetList_.Add(other.battleTargetList_);
			if (other.ScoreTwo != 0U)
			{
				this.ScoreTwo = other.ScoreTwo;
			}
			if (other.ChallengeScore != 0U)
			{
				this.ChallengeScore = other.ChallengeScore;
			}
			if (other.IsRemainingAction)
			{
				this.IsRemainingAction = other.IsRemainingAction;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.OGMPDLCDJDL != 0U)
			{
				this.OGMPDLCDJDL = other.OGMPDLCDJDL;
			}
			if (other.Phase != 0U)
			{
				this.Phase = other.Phase;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00035835 File Offset: 0x00033A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00035840 File Offset: 0x00033A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.Phase = input.ReadUInt32();
							continue;
						}
						if (num == 24U)
						{
							this.ChallengeId = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.battleTargetList_.AddEntriesFrom(ref input, ChallengeBossPhaseSettleNotify._repeated_battleTargetList_codec);
							continue;
						}
						if (num == 40U)
						{
							this.Star = input.ReadUInt32();
							continue;
						}
						if (num == 48U)
						{
							this.IsRemainingAction = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U)
					{
						this.IsReward = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.OGMPDLCDJDL = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ChallengeScore = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ScoreTwo = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.IsWin = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040007BF RID: 1983
		private static readonly MessageParser<ChallengeBossPhaseSettleNotify> _parser = new MessageParser<ChallengeBossPhaseSettleNotify>(() => new ChallengeBossPhaseSettleNotify());

		// Token: 0x040007C0 RID: 1984
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007C1 RID: 1985
		public const int IsWinFieldNumber = 14;

		// Token: 0x040007C2 RID: 1986
		private bool isWin_;

		// Token: 0x040007C3 RID: 1987
		public const int IsRewardFieldNumber = 7;

		// Token: 0x040007C4 RID: 1988
		private bool isReward_;

		// Token: 0x040007C5 RID: 1989
		public const int StarFieldNumber = 5;

		// Token: 0x040007C6 RID: 1990
		private uint star_;

		// Token: 0x040007C7 RID: 1991
		public const int BattleTargetListFieldNumber = 4;

		// Token: 0x040007C8 RID: 1992
		private static readonly FieldCodec<BattleTarget> _repeated_battleTargetList_codec = FieldCodec.ForMessage<BattleTarget>(34U, BattleTarget.Parser);

		// Token: 0x040007C9 RID: 1993
		private readonly RepeatedField<BattleTarget> battleTargetList_ = new RepeatedField<BattleTarget>();

		// Token: 0x040007CA RID: 1994
		public const int ScoreTwoFieldNumber = 12;

		// Token: 0x040007CB RID: 1995
		private uint scoreTwo_;

		// Token: 0x040007CC RID: 1996
		public const int ChallengeScoreFieldNumber = 9;

		// Token: 0x040007CD RID: 1997
		private uint challengeScore_;

		// Token: 0x040007CE RID: 1998
		public const int IsRemainingActionFieldNumber = 6;

		// Token: 0x040007CF RID: 1999
		private bool isRemainingAction_;

		// Token: 0x040007D0 RID: 2000
		public const int ChallengeIdFieldNumber = 3;

		// Token: 0x040007D1 RID: 2001
		private uint challengeId_;

		// Token: 0x040007D2 RID: 2002
		public const int OGMPDLCDJDLFieldNumber = 8;

		// Token: 0x040007D3 RID: 2003
		private uint oGMPDLCDJDL_;

		// Token: 0x040007D4 RID: 2004
		public const int PhaseFieldNumber = 1;

		// Token: 0x040007D5 RID: 2005
		private uint phase_;
	}
}
