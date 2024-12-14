using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200018D RID: 397
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Challenge : IMessage<Challenge>, IMessage, IEquatable<Challenge>, IDeepCloneable<Challenge>, IBufferMessage
	{
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00032E2F File Offset: 0x0003102F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Challenge> Parser
		{
			get
			{
				return Challenge._parser;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00032E36 File Offset: 0x00031036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00032E48 File Offset: 0x00031048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Challenge.Descriptor;
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00032E4F File Offset: 0x0003104F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Challenge()
		{
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00032E58 File Offset: 0x00031058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Challenge(Challenge other) : this()
		{
			this.dFFMIACMHLD_ = other.dFFMIACMHLD_;
			this.scoreTwo_ = other.scoreTwo_;
			this.recordId_ = other.recordId_;
			this.star_ = other.star_;
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.takenReward_ = other.takenReward_;
			this.scoreId_ = other.scoreId_;
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00032EEC File Offset: 0x000310EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Challenge Clone()
		{
			return new Challenge(this);
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x00032EF4 File Offset: 0x000310F4
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00032EFC File Offset: 0x000310FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DFFMIACMHLD
		{
			get
			{
				return this.dFFMIACMHLD_;
			}
			set
			{
				this.dFFMIACMHLD_ = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00032F05 File Offset: 0x00031105
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x00032F0D File Offset: 0x0003110D
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

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00032F16 File Offset: 0x00031116
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x00032F1E File Offset: 0x0003111E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RecordId
		{
			get
			{
				return this.recordId_;
			}
			set
			{
				this.recordId_ = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00032F27 File Offset: 0x00031127
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x00032F2F File Offset: 0x0003112F
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

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00032F38 File Offset: 0x00031138
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x00032F40 File Offset: 0x00031140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStageInfo StageInfo
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

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x00032F49 File Offset: 0x00031149
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x00032F51 File Offset: 0x00031151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TakenReward
		{
			get
			{
				return this.takenReward_;
			}
			set
			{
				this.takenReward_ = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00032F5A File Offset: 0x0003115A
		// (set) Token: 0x060011BC RID: 4540 RVA: 0x00032F62 File Offset: 0x00031162
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00032F6B File Offset: 0x0003116B
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x00032F73 File Offset: 0x00031173
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

		// Token: 0x060011BF RID: 4543 RVA: 0x00032F7C File Offset: 0x0003117C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Challenge);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00032F8C File Offset: 0x0003118C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Challenge other)
		{
			return other != null && (other == this || (this.DFFMIACMHLD == other.DFFMIACMHLD && this.ScoreTwo == other.ScoreTwo && this.RecordId == other.RecordId && this.Star == other.Star && object.Equals(this.StageInfo, other.StageInfo) && this.TakenReward == other.TakenReward && this.ScoreId == other.ScoreId && this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0003303C File Offset: 0x0003123C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DFFMIACMHLD)
			{
				num ^= this.DFFMIACMHLD.GetHashCode();
			}
			if (this.ScoreTwo != 0U)
			{
				num ^= this.ScoreTwo.GetHashCode();
			}
			if (this.RecordId != 0U)
			{
				num ^= this.RecordId.GetHashCode();
			}
			if (this.Star != 0U)
			{
				num ^= this.Star.GetHashCode();
			}
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this.TakenReward != 0U)
			{
				num ^= this.TakenReward.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00033127 File Offset: 0x00031327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0003312F File Offset: 0x0003132F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00033138 File Offset: 0x00031338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.StageInfo);
			}
			if (this.TakenReward != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.TakenReward);
			}
			if (this.ScoreTwo != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ScoreTwo);
			}
			if (this.DFFMIACMHLD)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.DFFMIACMHLD);
			}
			if (this.RecordId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.RecordId);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.Star != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Star);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0003323C File Offset: 0x0003143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DFFMIACMHLD)
			{
				num += 2;
			}
			if (this.ScoreTwo != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreTwo);
			}
			if (this.RecordId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RecordId);
			}
			if (this.Star != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Star);
			}
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this.TakenReward != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TakenReward);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00033318 File Offset: 0x00031518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Challenge other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DFFMIACMHLD)
			{
				this.DFFMIACMHLD = other.DFFMIACMHLD;
			}
			if (other.ScoreTwo != 0U)
			{
				this.ScoreTwo = other.ScoreTwo;
			}
			if (other.RecordId != 0U)
			{
				this.RecordId = other.RecordId;
			}
			if (other.Star != 0U)
			{
				this.Star = other.Star;
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new ChallengeStageInfo();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			if (other.TakenReward != 0U)
			{
				this.TakenReward = other.TakenReward;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000333F8 File Offset: 0x000315F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00033404 File Offset: 0x00031604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 42U)
					{
						if (num == 24U)
						{
							this.ChallengeId = input.ReadUInt32();
							continue;
						}
						if (num == 42U)
						{
							if (this.stageInfo_ == null)
							{
								this.StageInfo = new ChallengeStageInfo();
							}
							input.ReadMessage(this.StageInfo);
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.TakenReward = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							this.ScoreTwo = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 72U)
					{
						this.DFFMIACMHLD = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.RecordId = input.ReadUInt32();
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
						this.Star = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400076A RID: 1898
		private static readonly MessageParser<Challenge> _parser = new MessageParser<Challenge>(() => new Challenge());

		// Token: 0x0400076B RID: 1899
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400076C RID: 1900
		public const int DFFMIACMHLDFieldNumber = 9;

		// Token: 0x0400076D RID: 1901
		private bool dFFMIACMHLD_;

		// Token: 0x0400076E RID: 1902
		public const int ScoreTwoFieldNumber = 8;

		// Token: 0x0400076F RID: 1903
		private uint scoreTwo_;

		// Token: 0x04000770 RID: 1904
		public const int RecordIdFieldNumber = 10;

		// Token: 0x04000771 RID: 1905
		private uint recordId_;

		// Token: 0x04000772 RID: 1906
		public const int StarFieldNumber = 13;

		// Token: 0x04000773 RID: 1907
		private uint star_;

		// Token: 0x04000774 RID: 1908
		public const int StageInfoFieldNumber = 5;

		// Token: 0x04000775 RID: 1909
		private ChallengeStageInfo stageInfo_;

		// Token: 0x04000776 RID: 1910
		public const int TakenRewardFieldNumber = 7;

		// Token: 0x04000777 RID: 1911
		private uint takenReward_;

		// Token: 0x04000778 RID: 1912
		public const int ScoreIdFieldNumber = 12;

		// Token: 0x04000779 RID: 1913
		private uint scoreId_;

		// Token: 0x0400077A RID: 1914
		public const int ChallengeIdFieldNumber = 3;

		// Token: 0x0400077B RID: 1915
		private uint challengeId_;
	}
}
