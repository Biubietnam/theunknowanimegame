using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000221 RID: 545
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueGetInfo : IMessage<ChessRogueGetInfo>, IMessage, IEquatable<ChessRogueGetInfo>, IDeepCloneable<ChessRogueGetInfo>, IBufferMessage
	{
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x000477EE File Offset: 0x000459EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueGetInfo> Parser
		{
			get
			{
				return ChessRogueGetInfo._parser;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x000477F5 File Offset: 0x000459F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueGetInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00047807 File Offset: 0x00045A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueGetInfo.Descriptor;
			}
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0004780E File Offset: 0x00045A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGetInfo()
		{
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0004782C File Offset: 0x00045A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGetInfo(ChessRogueGetInfo other) : this()
		{
			this.chessAeonInfo_ = ((other.chessAeonInfo_ != null) ? other.chessAeonInfo_.Clone() : null);
			this.areaIdList_ = other.areaIdList_.Clone();
			this.queryDiceInfo_ = ((other.queryDiceInfo_ != null) ? other.queryDiceInfo_.Clone() : null);
			this.talentInfoList_ = ((other.talentInfoList_ != null) ? other.talentInfoList_.Clone() : null);
			this.rogueDifficultyInfo_ = ((other.rogueDifficultyInfo_ != null) ? other.rogueDifficultyInfo_.Clone() : null);
			this.exploredAreaIdList_ = other.exploredAreaIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000478E2 File Offset: 0x00045AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGetInfo Clone()
		{
			return new ChessRogueGetInfo(this);
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x000478EA File Offset: 0x00045AEA
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x000478F2 File Offset: 0x00045AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonInfo ChessAeonInfo
		{
			get
			{
				return this.chessAeonInfo_;
			}
			set
			{
				this.chessAeonInfo_ = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x000478FB File Offset: 0x00045AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AreaIdList
		{
			get
			{
				return this.areaIdList_;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00047903 File Offset: 0x00045B03
		// (set) Token: 0x0600188C RID: 6284 RVA: 0x0004790B File Offset: 0x00045B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryDiceInfo QueryDiceInfo
		{
			get
			{
				return this.queryDiceInfo_;
			}
			set
			{
				this.queryDiceInfo_ = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x00047914 File Offset: 0x00045B14
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x0004791C File Offset: 0x00045B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueTalentInfo TalentInfoList
		{
			get
			{
				return this.talentInfoList_;
			}
			set
			{
				this.talentInfoList_ = value;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x00047925 File Offset: 0x00045B25
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x0004792D File Offset: 0x00045B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryDiffcultyInfo RogueDifficultyInfo
		{
			get
			{
				return this.rogueDifficultyInfo_;
			}
			set
			{
				this.rogueDifficultyInfo_ = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x00047936 File Offset: 0x00045B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ExploredAreaIdList
		{
			get
			{
				return this.exploredAreaIdList_;
			}
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0004793E File Offset: 0x00045B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueGetInfo);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0004794C File Offset: 0x00045B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueGetInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ChessAeonInfo, other.ChessAeonInfo) && this.areaIdList_.Equals(other.areaIdList_) && object.Equals(this.QueryDiceInfo, other.QueryDiceInfo) && object.Equals(this.TalentInfoList, other.TalentInfoList) && object.Equals(this.RogueDifficultyInfo, other.RogueDifficultyInfo) && this.exploredAreaIdList_.Equals(other.exploredAreaIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x000479F4 File Offset: 0x00045BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.chessAeonInfo_ != null)
			{
				num ^= this.ChessAeonInfo.GetHashCode();
			}
			num ^= this.areaIdList_.GetHashCode();
			if (this.queryDiceInfo_ != null)
			{
				num ^= this.QueryDiceInfo.GetHashCode();
			}
			if (this.talentInfoList_ != null)
			{
				num ^= this.TalentInfoList.GetHashCode();
			}
			if (this.rogueDifficultyInfo_ != null)
			{
				num ^= this.RogueDifficultyInfo.GetHashCode();
			}
			num ^= this.exploredAreaIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00047A8E File Offset: 0x00045C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00047A96 File Offset: 0x00045C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00047AA0 File Offset: 0x00045CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.talentInfoList_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TalentInfoList);
			}
			if (this.queryDiceInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.QueryDiceInfo);
			}
			this.exploredAreaIdList_.WriteTo(ref output, ChessRogueGetInfo._repeated_exploredAreaIdList_codec);
			if (this.chessAeonInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ChessAeonInfo);
			}
			this.areaIdList_.WriteTo(ref output, ChessRogueGetInfo._repeated_areaIdList_codec);
			if (this.rogueDifficultyInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueDifficultyInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00047B54 File Offset: 0x00045D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.chessAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChessAeonInfo);
			}
			num += this.areaIdList_.CalculateSize(ChessRogueGetInfo._repeated_areaIdList_codec);
			if (this.queryDiceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QueryDiceInfo);
			}
			if (this.talentInfoList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TalentInfoList);
			}
			if (this.rogueDifficultyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueDifficultyInfo);
			}
			num += this.exploredAreaIdList_.CalculateSize(ChessRogueGetInfo._repeated_exploredAreaIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00047C00 File Offset: 0x00045E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueGetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.chessAeonInfo_ != null)
			{
				if (this.chessAeonInfo_ == null)
				{
					this.ChessAeonInfo = new ChessRogueQueryAeonInfo();
				}
				this.ChessAeonInfo.MergeFrom(other.ChessAeonInfo);
			}
			this.areaIdList_.Add(other.areaIdList_);
			if (other.queryDiceInfo_ != null)
			{
				if (this.queryDiceInfo_ == null)
				{
					this.QueryDiceInfo = new ChessRogueQueryDiceInfo();
				}
				this.QueryDiceInfo.MergeFrom(other.QueryDiceInfo);
			}
			if (other.talentInfoList_ != null)
			{
				if (this.talentInfoList_ == null)
				{
					this.TalentInfoList = new ChessRogueTalentInfo();
				}
				this.TalentInfoList.MergeFrom(other.TalentInfoList);
			}
			if (other.rogueDifficultyInfo_ != null)
			{
				if (this.rogueDifficultyInfo_ == null)
				{
					this.RogueDifficultyInfo = new ChessRogueQueryDiffcultyInfo();
				}
				this.RogueDifficultyInfo.MergeFrom(other.RogueDifficultyInfo);
			}
			this.exploredAreaIdList_.Add(other.exploredAreaIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00047CFA File Offset: 0x00045EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00047D04 File Offset: 0x00045F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 26U)
				{
					if (num <= 96U)
					{
						if (num == 82U)
						{
							if (this.chessAeonInfo_ == null)
							{
								this.ChessAeonInfo = new ChessRogueQueryAeonInfo();
							}
							input.ReadMessage(this.ChessAeonInfo);
							continue;
						}
						if (num != 96U)
						{
							goto IL_54;
						}
					}
					else if (num != 98U)
					{
						if (num != 106U)
						{
							goto IL_54;
						}
						if (this.rogueDifficultyInfo_ == null)
						{
							this.RogueDifficultyInfo = new ChessRogueQueryDiffcultyInfo();
						}
						input.ReadMessage(this.RogueDifficultyInfo);
						continue;
					}
					this.areaIdList_.AddEntriesFrom(ref input, ChessRogueGetInfo._repeated_areaIdList_codec);
					continue;
				}
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.talentInfoList_ == null)
						{
							this.TalentInfoList = new ChessRogueTalentInfo();
						}
						input.ReadMessage(this.TalentInfoList);
						continue;
					}
					if (num == 18U)
					{
						if (this.queryDiceInfo_ == null)
						{
							this.QueryDiceInfo = new ChessRogueQueryDiceInfo();
						}
						input.ReadMessage(this.QueryDiceInfo);
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.exploredAreaIdList_.AddEntriesFrom(ref input, ChessRogueGetInfo._repeated_exploredAreaIdList_codec);
					continue;
				}
				IL_54:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A7E RID: 2686
		private static readonly MessageParser<ChessRogueGetInfo> _parser = new MessageParser<ChessRogueGetInfo>(() => new ChessRogueGetInfo());

		// Token: 0x04000A7F RID: 2687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A80 RID: 2688
		public const int ChessAeonInfoFieldNumber = 10;

		// Token: 0x04000A81 RID: 2689
		private ChessRogueQueryAeonInfo chessAeonInfo_;

		// Token: 0x04000A82 RID: 2690
		public const int AreaIdListFieldNumber = 12;

		// Token: 0x04000A83 RID: 2691
		private static readonly FieldCodec<uint> _repeated_areaIdList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04000A84 RID: 2692
		private readonly RepeatedField<uint> areaIdList_ = new RepeatedField<uint>();

		// Token: 0x04000A85 RID: 2693
		public const int QueryDiceInfoFieldNumber = 2;

		// Token: 0x04000A86 RID: 2694
		private ChessRogueQueryDiceInfo queryDiceInfo_;

		// Token: 0x04000A87 RID: 2695
		public const int TalentInfoListFieldNumber = 1;

		// Token: 0x04000A88 RID: 2696
		private ChessRogueTalentInfo talentInfoList_;

		// Token: 0x04000A89 RID: 2697
		public const int RogueDifficultyInfoFieldNumber = 13;

		// Token: 0x04000A8A RID: 2698
		private ChessRogueQueryDiffcultyInfo rogueDifficultyInfo_;

		// Token: 0x04000A8B RID: 2699
		public const int ExploredAreaIdListFieldNumber = 3;

		// Token: 0x04000A8C RID: 2700
		private static readonly FieldCodec<uint> _repeated_exploredAreaIdList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04000A8D RID: 2701
		private readonly RepeatedField<uint> exploredAreaIdList_ = new RepeatedField<uint>();
	}
}
