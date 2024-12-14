using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200027B RID: 635
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryInfo : IMessage<ChessRogueQueryInfo>, IMessage, IEquatable<ChessRogueQueryInfo>, IDeepCloneable<ChessRogueQueryInfo>, IBufferMessage
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x00050EEC File Offset: 0x0004F0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryInfo> Parser
		{
			get
			{
				return ChessRogueQueryInfo._parser;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x00050EF3 File Offset: 0x0004F0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00050F05 File Offset: 0x0004F105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryInfo.Descriptor;
			}
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00050F0C File Offset: 0x0004F10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryInfo()
		{
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00050F2C File Offset: 0x0004F12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryInfo(ChessRogueQueryInfo other) : this()
		{
			this.rogueDifficultyInfo_ = ((other.rogueDifficultyInfo_ != null) ? other.rogueDifficultyInfo_.Clone() : null);
			this.rogueVirtualItemInfo_ = ((other.rogueVirtualItemInfo_ != null) ? other.rogueVirtualItemInfo_.Clone() : null);
			this.talentInfoList_ = ((other.talentInfoList_ != null) ? other.talentInfoList_.Clone() : null);
			this.exploredAreaIdList_ = other.exploredAreaIdList_.Clone();
			this.chessAeonInfo_ = ((other.chessAeonInfo_ != null) ? other.chessAeonInfo_.Clone() : null);
			this.queryDiceInfo_ = ((other.queryDiceInfo_ != null) ? other.queryDiceInfo_.Clone() : null);
			this.areaIdList_ = other.areaIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00050FFE File Offset: 0x0004F1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryInfo Clone()
		{
			return new ChessRogueQueryInfo(this);
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00051006 File Offset: 0x0004F206
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x0005100E File Offset: 0x0004F20E
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

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00051017 File Offset: 0x0004F217
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x0005101F File Offset: 0x0004F21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OICEICJKOCM RogueVirtualItemInfo
		{
			get
			{
				return this.rogueVirtualItemInfo_;
			}
			set
			{
				this.rogueVirtualItemInfo_ = value;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x00051028 File Offset: 0x0004F228
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x00051030 File Offset: 0x0004F230
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

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00051039 File Offset: 0x0004F239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ExploredAreaIdList
		{
			get
			{
				return this.exploredAreaIdList_;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00051041 File Offset: 0x0004F241
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x00051049 File Offset: 0x0004F249
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

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00051052 File Offset: 0x0004F252
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x0005105A File Offset: 0x0004F25A
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

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00051063 File Offset: 0x0004F263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AreaIdList
		{
			get
			{
				return this.areaIdList_;
			}
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0005106B File Offset: 0x0004F26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryInfo);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0005107C File Offset: 0x0004F27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueDifficultyInfo, other.RogueDifficultyInfo) && object.Equals(this.RogueVirtualItemInfo, other.RogueVirtualItemInfo) && object.Equals(this.TalentInfoList, other.TalentInfoList) && this.exploredAreaIdList_.Equals(other.exploredAreaIdList_) && object.Equals(this.ChessAeonInfo, other.ChessAeonInfo) && object.Equals(this.QueryDiceInfo, other.QueryDiceInfo) && this.areaIdList_.Equals(other.areaIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00051138 File Offset: 0x0004F338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueDifficultyInfo_ != null)
			{
				num ^= this.RogueDifficultyInfo.GetHashCode();
			}
			if (this.rogueVirtualItemInfo_ != null)
			{
				num ^= this.RogueVirtualItemInfo.GetHashCode();
			}
			if (this.talentInfoList_ != null)
			{
				num ^= this.TalentInfoList.GetHashCode();
			}
			num ^= this.exploredAreaIdList_.GetHashCode();
			if (this.chessAeonInfo_ != null)
			{
				num ^= this.ChessAeonInfo.GetHashCode();
			}
			if (this.queryDiceInfo_ != null)
			{
				num ^= this.QueryDiceInfo.GetHashCode();
			}
			num ^= this.areaIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x000511E8 File Offset: 0x0004F3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000511F0 File Offset: 0x0004F3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000511FC File Offset: 0x0004F3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.queryDiceInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.QueryDiceInfo);
			}
			if (this.rogueVirtualItemInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueVirtualItemInfo);
			}
			if (this.rogueDifficultyInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueDifficultyInfo);
			}
			this.exploredAreaIdList_.WriteTo(ref output, ChessRogueQueryInfo._repeated_exploredAreaIdList_codec);
			this.areaIdList_.WriteTo(ref output, ChessRogueQueryInfo._repeated_areaIdList_codec);
			if (this.talentInfoList_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TalentInfoList);
			}
			if (this.chessAeonInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ChessAeonInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x000512CC File Offset: 0x0004F4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueDifficultyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueDifficultyInfo);
			}
			if (this.rogueVirtualItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueVirtualItemInfo);
			}
			if (this.talentInfoList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TalentInfoList);
			}
			num += this.exploredAreaIdList_.CalculateSize(ChessRogueQueryInfo._repeated_exploredAreaIdList_codec);
			if (this.chessAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChessAeonInfo);
			}
			if (this.queryDiceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QueryDiceInfo);
			}
			num += this.areaIdList_.CalculateSize(ChessRogueQueryInfo._repeated_areaIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00051390 File Offset: 0x0004F590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueDifficultyInfo_ != null)
			{
				if (this.rogueDifficultyInfo_ == null)
				{
					this.RogueDifficultyInfo = new ChessRogueQueryDiffcultyInfo();
				}
				this.RogueDifficultyInfo.MergeFrom(other.RogueDifficultyInfo);
			}
			if (other.rogueVirtualItemInfo_ != null)
			{
				if (this.rogueVirtualItemInfo_ == null)
				{
					this.RogueVirtualItemInfo = new OICEICJKOCM();
				}
				this.RogueVirtualItemInfo.MergeFrom(other.RogueVirtualItemInfo);
			}
			if (other.talentInfoList_ != null)
			{
				if (this.talentInfoList_ == null)
				{
					this.TalentInfoList = new ChessRogueTalentInfo();
				}
				this.TalentInfoList.MergeFrom(other.TalentInfoList);
			}
			this.exploredAreaIdList_.Add(other.exploredAreaIdList_);
			if (other.chessAeonInfo_ != null)
			{
				if (this.chessAeonInfo_ == null)
				{
					this.ChessAeonInfo = new ChessRogueQueryAeonInfo();
				}
				this.ChessAeonInfo.MergeFrom(other.ChessAeonInfo);
			}
			if (other.queryDiceInfo_ != null)
			{
				if (this.queryDiceInfo_ == null)
				{
					this.QueryDiceInfo = new ChessRogueQueryDiceInfo();
				}
				this.QueryDiceInfo.MergeFrom(other.QueryDiceInfo);
			}
			this.areaIdList_.Add(other.areaIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x000514B6 File Offset: 0x0004F6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x000514C0 File Offset: 0x0004F6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 56U)
				{
					if (num <= 64U)
					{
						if (num == 58U)
						{
							goto IL_DC;
						}
						if (num != 64U)
						{
							goto IL_5C;
						}
					}
					else if (num != 66U)
					{
						if (num == 74U)
						{
							if (this.talentInfoList_ == null)
							{
								this.TalentInfoList = new ChessRogueTalentInfo();
							}
							input.ReadMessage(this.TalentInfoList);
							continue;
						}
						if (num != 122U)
						{
							goto IL_5C;
						}
						if (this.chessAeonInfo_ == null)
						{
							this.ChessAeonInfo = new ChessRogueQueryAeonInfo();
						}
						input.ReadMessage(this.ChessAeonInfo);
						continue;
					}
					this.areaIdList_.AddEntriesFrom(ref input, ChessRogueQueryInfo._repeated_areaIdList_codec);
					continue;
				}
				if (num <= 26U)
				{
					if (num == 10U)
					{
						if (this.queryDiceInfo_ == null)
						{
							this.QueryDiceInfo = new ChessRogueQueryDiceInfo();
						}
						input.ReadMessage(this.QueryDiceInfo);
						continue;
					}
					if (num == 26U)
					{
						if (this.rogueVirtualItemInfo_ == null)
						{
							this.RogueVirtualItemInfo = new OICEICJKOCM();
						}
						input.ReadMessage(this.RogueVirtualItemInfo);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						if (this.rogueDifficultyInfo_ == null)
						{
							this.RogueDifficultyInfo = new ChessRogueQueryDiffcultyInfo();
						}
						input.ReadMessage(this.RogueDifficultyInfo);
						continue;
					}
					if (num == 56U)
					{
						goto IL_DC;
					}
				}
				IL_5C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_DC:
				this.exploredAreaIdList_.AddEntriesFrom(ref input, ChessRogueQueryInfo._repeated_exploredAreaIdList_codec);
			}
		}

		// Token: 0x04000BCF RID: 3023
		private static readonly MessageParser<ChessRogueQueryInfo> _parser = new MessageParser<ChessRogueQueryInfo>(() => new ChessRogueQueryInfo());

		// Token: 0x04000BD0 RID: 3024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BD1 RID: 3025
		public const int RogueDifficultyInfoFieldNumber = 6;

		// Token: 0x04000BD2 RID: 3026
		private ChessRogueQueryDiffcultyInfo rogueDifficultyInfo_;

		// Token: 0x04000BD3 RID: 3027
		public const int RogueVirtualItemInfoFieldNumber = 3;

		// Token: 0x04000BD4 RID: 3028
		private OICEICJKOCM rogueVirtualItemInfo_;

		// Token: 0x04000BD5 RID: 3029
		public const int TalentInfoListFieldNumber = 9;

		// Token: 0x04000BD6 RID: 3030
		private ChessRogueTalentInfo talentInfoList_;

		// Token: 0x04000BD7 RID: 3031
		public const int ExploredAreaIdListFieldNumber = 7;

		// Token: 0x04000BD8 RID: 3032
		private static readonly FieldCodec<uint> _repeated_exploredAreaIdList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04000BD9 RID: 3033
		private readonly RepeatedField<uint> exploredAreaIdList_ = new RepeatedField<uint>();

		// Token: 0x04000BDA RID: 3034
		public const int ChessAeonInfoFieldNumber = 15;

		// Token: 0x04000BDB RID: 3035
		private ChessRogueQueryAeonInfo chessAeonInfo_;

		// Token: 0x04000BDC RID: 3036
		public const int QueryDiceInfoFieldNumber = 1;

		// Token: 0x04000BDD RID: 3037
		private ChessRogueQueryDiceInfo queryDiceInfo_;

		// Token: 0x04000BDE RID: 3038
		public const int AreaIdListFieldNumber = 8;

		// Token: 0x04000BDF RID: 3039
		private static readonly FieldCodec<uint> _repeated_areaIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04000BE0 RID: 3040
		private readonly RepeatedField<uint> areaIdList_ = new RepeatedField<uint>();
	}
}
