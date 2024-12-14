using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200063F RID: 1599
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChallengeGroupStatisticsScRsp : IMessage<GetChallengeGroupStatisticsScRsp>, IMessage, IEquatable<GetChallengeGroupStatisticsScRsp>, IDeepCloneable<GetChallengeGroupStatisticsScRsp>, IBufferMessage
	{
		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x000C45A6 File Offset: 0x000C27A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChallengeGroupStatisticsScRsp> Parser
		{
			get
			{
				return GetChallengeGroupStatisticsScRsp._parser;
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x060047BE RID: 18366 RVA: 0x000C45AD File Offset: 0x000C27AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChallengeGroupStatisticsScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x000C45BF File Offset: 0x000C27BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChallengeGroupStatisticsScRsp.Descriptor;
			}
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x000C45C6 File Offset: 0x000C27C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeGroupStatisticsScRsp()
		{
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x000C45D0 File Offset: 0x000C27D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeGroupStatisticsScRsp(GetChallengeGroupStatisticsScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.groupId_ = other.groupId_;
			GetChallengeGroupStatisticsScRsp.ChallengeOneofCase challengeCase = other.ChallengeCase;
			if (challengeCase != GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeStory)
			{
				if (challengeCase != GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeDefault)
				{
					if (challengeCase == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeBoss)
					{
						this.ChallengeBoss = other.ChallengeBoss.Clone();
					}
				}
				else
				{
					this.ChallengeDefault = other.ChallengeDefault.Clone();
				}
			}
			else
			{
				this.ChallengeStory = other.ChallengeStory.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x000C465A File Offset: 0x000C285A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeGroupStatisticsScRsp Clone()
		{
			return new GetChallengeGroupStatisticsScRsp(this);
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x000C4662 File Offset: 0x000C2862
		// (set) Token: 0x060047C4 RID: 18372 RVA: 0x000C466A File Offset: 0x000C286A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x060047C5 RID: 18373 RVA: 0x000C4673 File Offset: 0x000C2873
		// (set) Token: 0x060047C6 RID: 18374 RVA: 0x000C467B File Offset: 0x000C287B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x000C4684 File Offset: 0x000C2884
		// (set) Token: 0x060047C8 RID: 18376 RVA: 0x000C469D File Offset: 0x000C289D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStatistics ChallengeDefault
		{
			get
			{
				if (this.challengeCase_ != GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeDefault)
				{
					return null;
				}
				return (ChallengeStatistics)this.challenge_;
			}
			set
			{
				this.challenge_ = value;
				this.challengeCase_ = ((value == null) ? GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.None : GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeDefault);
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x060047C9 RID: 18377 RVA: 0x000C46B4 File Offset: 0x000C28B4
		// (set) Token: 0x060047CA RID: 18378 RVA: 0x000C46CC File Offset: 0x000C28CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryStatistics ChallengeStory
		{
			get
			{
				if (this.challengeCase_ != GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeStory)
				{
					return null;
				}
				return (ChallengeStoryStatistics)this.challenge_;
			}
			set
			{
				this.challenge_ = value;
				this.challengeCase_ = ((value == null) ? GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.None : GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeStory);
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x000C46E2 File Offset: 0x000C28E2
		// (set) Token: 0x060047CC RID: 18380 RVA: 0x000C46FB File Offset: 0x000C28FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossStatistics ChallengeBoss
		{
			get
			{
				if (this.challengeCase_ != GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeBoss)
				{
					return null;
				}
				return (ChallengeBossStatistics)this.challenge_;
			}
			set
			{
				this.challenge_ = value;
				this.challengeCase_ = ((value == null) ? GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.None : GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeBoss);
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x000C4712 File Offset: 0x000C2912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeGroupStatisticsScRsp.ChallengeOneofCase ChallengeCase
		{
			get
			{
				return this.challengeCase_;
			}
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x000C471A File Offset: 0x000C291A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearChallenge()
		{
			this.challengeCase_ = GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.None;
			this.challenge_ = null;
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x000C472A File Offset: 0x000C292A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChallengeGroupStatisticsScRsp);
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x000C4738 File Offset: 0x000C2938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChallengeGroupStatisticsScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.GroupId == other.GroupId && object.Equals(this.ChallengeDefault, other.ChallengeDefault) && object.Equals(this.ChallengeStory, other.ChallengeStory) && object.Equals(this.ChallengeBoss, other.ChallengeBoss) && this.ChallengeCase == other.ChallengeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x000C47D0 File Offset: 0x000C29D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeDefault)
			{
				num ^= this.ChallengeDefault.GetHashCode();
			}
			if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeStory)
			{
				num ^= this.ChallengeStory.GetHashCode();
			}
			if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeBoss)
			{
				num ^= this.ChallengeBoss.GetHashCode();
			}
			num ^= (int)this.challengeCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x000C4878 File Offset: 0x000C2A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x000C4880 File Offset: 0x000C2A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x000C488C File Offset: 0x000C2A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeStory)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ChallengeStory);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeDefault)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ChallengeDefault);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GroupId);
			}
			if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeBoss)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ChallengeBoss);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x000C4940 File Offset: 0x000C2B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeDefault)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChallengeDefault);
			}
			if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeStory)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChallengeStory);
			}
			if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeBoss)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChallengeBoss);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x000C49E4 File Offset: 0x000C2BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChallengeGroupStatisticsScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			GetChallengeGroupStatisticsScRsp.ChallengeOneofCase challengeCase = other.ChallengeCase;
			if (challengeCase != GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeStory)
			{
				if (challengeCase != GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeDefault)
				{
					if (challengeCase == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeBoss)
					{
						if (this.ChallengeBoss == null)
						{
							this.ChallengeBoss = new ChallengeBossStatistics();
						}
						this.ChallengeBoss.MergeFrom(other.ChallengeBoss);
					}
				}
				else
				{
					if (this.ChallengeDefault == null)
					{
						this.ChallengeDefault = new ChallengeStatistics();
					}
					this.ChallengeDefault.MergeFrom(other.ChallengeDefault);
				}
			}
			else
			{
				if (this.ChallengeStory == null)
				{
					this.ChallengeStory = new ChallengeStoryStatistics();
				}
				this.ChallengeStory.MergeFrom(other.ChallengeStory);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x000C4ABB File Offset: 0x000C2CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x000C4AC4 File Offset: 0x000C2CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 34U)
					{
						ChallengeStoryStatistics challengeStoryStatistics = new ChallengeStoryStatistics();
						if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeStory)
						{
							challengeStoryStatistics.MergeFrom(this.ChallengeStory);
						}
						input.ReadMessage(challengeStoryStatistics);
						this.ChallengeStory = challengeStoryStatistics;
						continue;
					}
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						ChallengeStatistics challengeStatistics = new ChallengeStatistics();
						if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeDefault)
						{
							challengeStatistics.MergeFrom(this.ChallengeDefault);
						}
						input.ReadMessage(challengeStatistics);
						this.ChallengeDefault = challengeStatistics;
						continue;
					}
					if (num == 112U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						ChallengeBossStatistics challengeBossStatistics = new ChallengeBossStatistics();
						if (this.challengeCase_ == GetChallengeGroupStatisticsScRsp.ChallengeOneofCase.ChallengeBoss)
						{
							challengeBossStatistics.MergeFrom(this.ChallengeBoss);
						}
						input.ReadMessage(challengeBossStatistics);
						this.ChallengeBoss = challengeBossStatistics;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001CB2 RID: 7346
		private static readonly MessageParser<GetChallengeGroupStatisticsScRsp> _parser = new MessageParser<GetChallengeGroupStatisticsScRsp>(() => new GetChallengeGroupStatisticsScRsp());

		// Token: 0x04001CB3 RID: 7347
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CB4 RID: 7348
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04001CB5 RID: 7349
		private uint retcode_;

		// Token: 0x04001CB6 RID: 7350
		public const int GroupIdFieldNumber = 14;

		// Token: 0x04001CB7 RID: 7351
		private uint groupId_;

		// Token: 0x04001CB8 RID: 7352
		public const int ChallengeDefaultFieldNumber = 12;

		// Token: 0x04001CB9 RID: 7353
		public const int ChallengeStoryFieldNumber = 4;

		// Token: 0x04001CBA RID: 7354
		public const int ChallengeBossFieldNumber = 15;

		// Token: 0x04001CBB RID: 7355
		private object challenge_;

		// Token: 0x04001CBC RID: 7356
		private GetChallengeGroupStatisticsScRsp.ChallengeOneofCase challengeCase_;

		// Token: 0x02001735 RID: 5941
		public enum ChallengeOneofCase
		{
			// Token: 0x04005EEB RID: 24299
			None,
			// Token: 0x04005EEC RID: 24300
			ChallengeDefault = 12,
			// Token: 0x04005EED RID: 24301
			ChallengeStory = 4,
			// Token: 0x04005EEE RID: 24302
			ChallengeBoss = 15
		}
	}
}
