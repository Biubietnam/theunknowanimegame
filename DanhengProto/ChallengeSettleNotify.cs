using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001B3 RID: 435
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeSettleNotify : IMessage<ChallengeSettleNotify>, IMessage, IEquatable<ChallengeSettleNotify>, IDeepCloneable<ChallengeSettleNotify>, IBufferMessage
	{
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x0003849E File Offset: 0x0003669E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeSettleNotify> Parser
		{
			get
			{
				return ChallengeSettleNotify._parser;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x000384A5 File Offset: 0x000366A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeSettleNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x000384B7 File Offset: 0x000366B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeSettleNotify.Descriptor;
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x000384BE File Offset: 0x000366BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeSettleNotify()
		{
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x000384D4 File Offset: 0x000366D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeSettleNotify(ChallengeSettleNotify other) : this()
		{
			this.curChallenge_ = ((other.curChallenge_ != null) ? other.curChallenge_.Clone() : null);
			this.gGBCPNCDMFA_ = other.gGBCPNCDMFA_;
			this.cBKLMFOAAFJ_ = ((other.cBKLMFOAAFJ_ != null) ? other.cBKLMFOAAFJ_.Clone() : null);
			this.scoreTwo_ = other.scoreTwo_;
			this.challengeScore_ = other.challengeScore_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.challengeId_ = other.challengeId_;
			this.star_ = other.star_;
			this.isWin_ = other.isWin_;
			this.gLBJGILDBAK_ = other.gLBJGILDBAK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x000385A5 File Offset: 0x000367A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeSettleNotify Clone()
		{
			return new ChallengeSettleNotify(this);
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x000385AD File Offset: 0x000367AD
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x000385B5 File Offset: 0x000367B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurChallenge CurChallenge
		{
			get
			{
				return this.curChallenge_;
			}
			set
			{
				this.curChallenge_ = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x000385BE File Offset: 0x000367BE
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x000385C6 File Offset: 0x000367C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GGBCPNCDMFA
		{
			get
			{
				return this.gGBCPNCDMFA_;
			}
			set
			{
				this.gGBCPNCDMFA_ = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x000385CF File Offset: 0x000367CF
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x000385D7 File Offset: 0x000367D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OMPDJIJNNBP CBKLMFOAAFJ
		{
			get
			{
				return this.cBKLMFOAAFJ_;
			}
			set
			{
				this.cBKLMFOAAFJ_ = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x000385E0 File Offset: 0x000367E0
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x000385E8 File Offset: 0x000367E8
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

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x000385F1 File Offset: 0x000367F1
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x000385F9 File Offset: 0x000367F9
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

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00038602 File Offset: 0x00036802
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x0003860A File Offset: 0x0003680A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00038613 File Offset: 0x00036813
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x0003861B File Offset: 0x0003681B
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

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x00038624 File Offset: 0x00036824
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x0003862C File Offset: 0x0003682C
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

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x00038635 File Offset: 0x00036835
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x0003863D File Offset: 0x0003683D
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

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00038646 File Offset: 0x00036846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GLBJGILDBAK
		{
			get
			{
				return this.gLBJGILDBAK_;
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0003864E File Offset: 0x0003684E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeSettleNotify);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0003865C File Offset: 0x0003685C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeSettleNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CurChallenge, other.CurChallenge) && this.GGBCPNCDMFA == other.GGBCPNCDMFA && object.Equals(this.CBKLMFOAAFJ, other.CBKLMFOAAFJ) && this.ScoreTwo == other.ScoreTwo && this.ChallengeScore == other.ChallengeScore && object.Equals(this.Reward, other.Reward) && this.ChallengeId == other.ChallengeId && this.Star == other.Star && this.IsWin == other.IsWin && this.gLBJGILDBAK_.Equals(other.gLBJGILDBAK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0003873C File Offset: 0x0003693C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.curChallenge_ != null)
			{
				num ^= this.CurChallenge.GetHashCode();
			}
			if (this.GGBCPNCDMFA != 0U)
			{
				num ^= this.GGBCPNCDMFA.GetHashCode();
			}
			if (this.cBKLMFOAAFJ_ != null)
			{
				num ^= this.CBKLMFOAAFJ.GetHashCode();
			}
			if (this.ScoreTwo != 0U)
			{
				num ^= this.ScoreTwo.GetHashCode();
			}
			if (this.ChallengeScore != 0U)
			{
				num ^= this.ChallengeScore.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.Star != 0U)
			{
				num ^= this.Star.GetHashCode();
			}
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			num ^= this.gLBJGILDBAK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00038848 File Offset: 0x00036A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00038850 File Offset: 0x00036A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0003885C File Offset: 0x00036A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GGBCPNCDMFA != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GGBCPNCDMFA);
			}
			if (this.IsWin)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsWin);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Reward);
			}
			if (this.curChallenge_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CurChallenge);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.ScoreTwo != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ScoreTwo);
			}
			if (this.ChallengeScore != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ChallengeScore);
			}
			if (this.cBKLMFOAAFJ_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CBKLMFOAAFJ);
			}
			if (this.Star != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Star);
			}
			this.gLBJGILDBAK_.WriteTo(ref output, ChallengeSettleNotify._repeated_gLBJGILDBAK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0003898C File Offset: 0x00036B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.curChallenge_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurChallenge);
			}
			if (this.GGBCPNCDMFA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GGBCPNCDMFA);
			}
			if (this.cBKLMFOAAFJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CBKLMFOAAFJ);
			}
			if (this.ScoreTwo != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreTwo);
			}
			if (this.ChallengeScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeScore);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.Star != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Star);
			}
			if (this.IsWin)
			{
				num += 2;
			}
			num += this.gLBJGILDBAK_.CalculateSize(ChallengeSettleNotify._repeated_gLBJGILDBAK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00038A94 File Offset: 0x00036C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.curChallenge_ != null)
			{
				if (this.curChallenge_ == null)
				{
					this.CurChallenge = new CurChallenge();
				}
				this.CurChallenge.MergeFrom(other.CurChallenge);
			}
			if (other.GGBCPNCDMFA != 0U)
			{
				this.GGBCPNCDMFA = other.GGBCPNCDMFA;
			}
			if (other.cBKLMFOAAFJ_ != null)
			{
				if (this.cBKLMFOAAFJ_ == null)
				{
					this.CBKLMFOAAFJ = new OMPDJIJNNBP();
				}
				this.CBKLMFOAAFJ.MergeFrom(other.CBKLMFOAAFJ);
			}
			if (other.ScoreTwo != 0U)
			{
				this.ScoreTwo = other.ScoreTwo;
			}
			if (other.ChallengeScore != 0U)
			{
				this.ChallengeScore = other.ChallengeScore;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.Star != 0U)
			{
				this.Star = other.Star;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			this.gLBJGILDBAK_.Add(other.gLBJGILDBAK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00038BC9 File Offset: 0x00036DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00038BD4 File Offset: 0x00036DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.GGBCPNCDMFA = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.IsWin = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							if (this.reward_ == null)
							{
								this.Reward = new ItemList();
							}
							input.ReadMessage(this.Reward);
							continue;
						}
						if (num == 34U)
						{
							if (this.curChallenge_ == null)
							{
								this.CurChallenge = new CurChallenge();
							}
							input.ReadMessage(this.CurChallenge);
							continue;
						}
						if (num == 56U)
						{
							this.ChallengeId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 72U)
					{
						this.ScoreTwo = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ChallengeScore = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.cBKLMFOAAFJ_ == null)
						{
							this.CBKLMFOAAFJ = new OMPDJIJNNBP();
						}
						input.ReadMessage(this.CBKLMFOAAFJ);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Star = input.ReadUInt32();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.gLBJGILDBAK_.AddEntriesFrom(ref input, ChallengeSettleNotify._repeated_gLBJGILDBAK_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000835 RID: 2101
		private static readonly MessageParser<ChallengeSettleNotify> _parser = new MessageParser<ChallengeSettleNotify>(() => new ChallengeSettleNotify());

		// Token: 0x04000836 RID: 2102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000837 RID: 2103
		public const int CurChallengeFieldNumber = 4;

		// Token: 0x04000838 RID: 2104
		private CurChallenge curChallenge_;

		// Token: 0x04000839 RID: 2105
		public const int GGBCPNCDMFAFieldNumber = 1;

		// Token: 0x0400083A RID: 2106
		private uint gGBCPNCDMFA_;

		// Token: 0x0400083B RID: 2107
		public const int CBKLMFOAAFJFieldNumber = 11;

		// Token: 0x0400083C RID: 2108
		private OMPDJIJNNBP cBKLMFOAAFJ_;

		// Token: 0x0400083D RID: 2109
		public const int ScoreTwoFieldNumber = 9;

		// Token: 0x0400083E RID: 2110
		private uint scoreTwo_;

		// Token: 0x0400083F RID: 2111
		public const int ChallengeScoreFieldNumber = 10;

		// Token: 0x04000840 RID: 2112
		private uint challengeScore_;

		// Token: 0x04000841 RID: 2113
		public const int RewardFieldNumber = 3;

		// Token: 0x04000842 RID: 2114
		private ItemList reward_;

		// Token: 0x04000843 RID: 2115
		public const int ChallengeIdFieldNumber = 7;

		// Token: 0x04000844 RID: 2116
		private uint challengeId_;

		// Token: 0x04000845 RID: 2117
		public const int StarFieldNumber = 13;

		// Token: 0x04000846 RID: 2118
		private uint star_;

		// Token: 0x04000847 RID: 2119
		public const int IsWinFieldNumber = 2;

		// Token: 0x04000848 RID: 2120
		private bool isWin_;

		// Token: 0x04000849 RID: 2121
		public const int GLBJGILDBAKFieldNumber = 15;

		// Token: 0x0400084A RID: 2122
		private static readonly FieldCodec<uint> _repeated_gLBJGILDBAK_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x0400084B RID: 2123
		private readonly RepeatedField<uint> gLBJGILDBAK_ = new RepeatedField<uint>();
	}
}
