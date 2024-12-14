using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F8D RID: 3981
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournCurGameInfo : IMessage<RogueTournCurGameInfo>, IMessage, IEquatable<RogueTournCurGameInfo>, IDeepCloneable<RogueTournCurGameInfo>, IBufferMessage
	{
		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600B152 RID: 45394 RVA: 0x001DC80A File Offset: 0x001DAA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournCurGameInfo> Parser
		{
			get
			{
				return RogueTournCurGameInfo._parser;
			}
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600B153 RID: 45395 RVA: 0x001DC811 File Offset: 0x001DAA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournCurGameInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600B154 RID: 45396 RVA: 0x001DC823 File Offset: 0x001DAA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournCurGameInfo.Descriptor;
			}
		}

		// Token: 0x0600B155 RID: 45397 RVA: 0x001DC82A File Offset: 0x001DAA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurGameInfo()
		{
		}

		// Token: 0x0600B156 RID: 45398 RVA: 0x001DC834 File Offset: 0x001DAA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurGameInfo(RogueTournCurGameInfo other) : this()
		{
			this.level_ = ((other.level_ != null) ? other.level_.Clone() : null);
			this.unlockValue_ = ((other.unlockValue_ != null) ? other.unlockValue_.Clone() : null);
			this.itemValue_ = ((other.itemValue_ != null) ? other.itemValue_.Clone() : null);
			this.rogueTournGameAreaInfo_ = ((other.rogueTournGameAreaInfo_ != null) ? other.rogueTournGameAreaInfo_.Clone() : null);
			this.gameDifficultyInfo_ = ((other.gameDifficultyInfo_ != null) ? other.gameDifficultyInfo_.Clone() : null);
			this.tournFormulaInfo_ = ((other.tournFormulaInfo_ != null) ? other.tournFormulaInfo_.Clone() : null);
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.miracleInfo_ = ((other.miracleInfo_ != null) ? other.miracleInfo_.Clone() : null);
			this.tournModuleInfo_ = ((other.tournModuleInfo_ != null) ? other.tournModuleInfo_.Clone() : null);
			this.buff_ = ((other.buff_ != null) ? other.buff_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B157 RID: 45399 RVA: 0x001DC970 File Offset: 0x001DAB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurGameInfo Clone()
		{
			return new RogueTournCurGameInfo(this);
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600B158 RID: 45400 RVA: 0x001DC978 File Offset: 0x001DAB78
		// (set) Token: 0x0600B159 RID: 45401 RVA: 0x001DC980 File Offset: 0x001DAB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevelInfo Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600B15A RID: 45402 RVA: 0x001DC989 File Offset: 0x001DAB89
		// (set) Token: 0x0600B15B RID: 45403 RVA: 0x001DC991 File Offset: 0x001DAB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KeywordUnlockValue UnlockValue
		{
			get
			{
				return this.unlockValue_;
			}
			set
			{
				this.unlockValue_ = value;
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600B15C RID: 45404 RVA: 0x001DC99A File Offset: 0x001DAB9A
		// (set) Token: 0x0600B15D RID: 45405 RVA: 0x001DC9A2 File Offset: 0x001DABA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGameItemValue ItemValue
		{
			get
			{
				return this.itemValue_;
			}
			set
			{
				this.itemValue_ = value;
			}
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600B15E RID: 45406 RVA: 0x001DC9AB File Offset: 0x001DABAB
		// (set) Token: 0x0600B15F RID: 45407 RVA: 0x001DC9B3 File Offset: 0x001DABB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGameAreaInfo RogueTournGameAreaInfo
		{
			get
			{
				return this.rogueTournGameAreaInfo_;
			}
			set
			{
				this.rogueTournGameAreaInfo_ = value;
			}
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600B160 RID: 45408 RVA: 0x001DC9BC File Offset: 0x001DABBC
		// (set) Token: 0x0600B161 RID: 45409 RVA: 0x001DC9C4 File Offset: 0x001DABC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGameDifficultyInfo GameDifficultyInfo
		{
			get
			{
				return this.gameDifficultyInfo_;
			}
			set
			{
				this.gameDifficultyInfo_ = value;
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600B162 RID: 45410 RVA: 0x001DC9CD File Offset: 0x001DABCD
		// (set) Token: 0x0600B163 RID: 45411 RVA: 0x001DC9D5 File Offset: 0x001DABD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaInfo TournFormulaInfo
		{
			get
			{
				return this.tournFormulaInfo_;
			}
			set
			{
				this.tournFormulaInfo_ = value;
			}
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600B164 RID: 45412 RVA: 0x001DC9DE File Offset: 0x001DABDE
		// (set) Token: 0x0600B165 RID: 45413 RVA: 0x001DC9E6 File Offset: 0x001DABE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLineupInfo Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600B166 RID: 45414 RVA: 0x001DC9EF File Offset: 0x001DABEF
		// (set) Token: 0x0600B167 RID: 45415 RVA: 0x001DC9F7 File Offset: 0x001DABF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracleInfo MiracleInfo
		{
			get
			{
				return this.miracleInfo_;
			}
			set
			{
				this.miracleInfo_ = value;
			}
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600B168 RID: 45416 RVA: 0x001DCA00 File Offset: 0x001DAC00
		// (set) Token: 0x0600B169 RID: 45417 RVA: 0x001DCA08 File Offset: 0x001DAC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournModuleInfo TournModuleInfo
		{
			get
			{
				return this.tournModuleInfo_;
			}
			set
			{
				this.tournModuleInfo_ = value;
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600B16A RID: 45418 RVA: 0x001DCA11 File Offset: 0x001DAC11
		// (set) Token: 0x0600B16B RID: 45419 RVA: 0x001DCA19 File Offset: 0x001DAC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffInfo Buff
		{
			get
			{
				return this.buff_;
			}
			set
			{
				this.buff_ = value;
			}
		}

		// Token: 0x0600B16C RID: 45420 RVA: 0x001DCA22 File Offset: 0x001DAC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournCurGameInfo);
		}

		// Token: 0x0600B16D RID: 45421 RVA: 0x001DCA30 File Offset: 0x001DAC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournCurGameInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Level, other.Level) && object.Equals(this.UnlockValue, other.UnlockValue) && object.Equals(this.ItemValue, other.ItemValue) && object.Equals(this.RogueTournGameAreaInfo, other.RogueTournGameAreaInfo) && object.Equals(this.GameDifficultyInfo, other.GameDifficultyInfo) && object.Equals(this.TournFormulaInfo, other.TournFormulaInfo) && object.Equals(this.Lineup, other.Lineup) && object.Equals(this.MiracleInfo, other.MiracleInfo) && object.Equals(this.TournModuleInfo, other.TournModuleInfo) && object.Equals(this.Buff, other.Buff) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B16E RID: 45422 RVA: 0x001DCB2C File Offset: 0x001DAD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.level_ != null)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.unlockValue_ != null)
			{
				num ^= this.UnlockValue.GetHashCode();
			}
			if (this.itemValue_ != null)
			{
				num ^= this.ItemValue.GetHashCode();
			}
			if (this.rogueTournGameAreaInfo_ != null)
			{
				num ^= this.RogueTournGameAreaInfo.GetHashCode();
			}
			if (this.gameDifficultyInfo_ != null)
			{
				num ^= this.GameDifficultyInfo.GetHashCode();
			}
			if (this.tournFormulaInfo_ != null)
			{
				num ^= this.TournFormulaInfo.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.miracleInfo_ != null)
			{
				num ^= this.MiracleInfo.GetHashCode();
			}
			if (this.tournModuleInfo_ != null)
			{
				num ^= this.TournModuleInfo.GetHashCode();
			}
			if (this.buff_ != null)
			{
				num ^= this.Buff.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B16F RID: 45423 RVA: 0x001DCC2E File Offset: 0x001DAE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x001DCC36 File Offset: 0x001DAE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x001DCC40 File Offset: 0x001DAE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.unlockValue_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.UnlockValue);
			}
			if (this.level_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Level);
			}
			if (this.rogueTournGameAreaInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueTournGameAreaInfo);
			}
			if (this.miracleInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.MiracleInfo);
			}
			if (this.tournFormulaInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TournFormulaInfo);
			}
			if (this.itemValue_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ItemValue);
			}
			if (this.gameDifficultyInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.GameDifficultyInfo);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Lineup);
			}
			if (this.tournModuleInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.TournModuleInfo);
			}
			if (this.buff_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Buff);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B172 RID: 45426 RVA: 0x001DCD7C File Offset: 0x001DAF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.level_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Level);
			}
			if (this.unlockValue_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockValue);
			}
			if (this.itemValue_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemValue);
			}
			if (this.rogueTournGameAreaInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournGameAreaInfo);
			}
			if (this.gameDifficultyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameDifficultyInfo);
			}
			if (this.tournFormulaInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TournFormulaInfo);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.miracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MiracleInfo);
			}
			if (this.tournModuleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TournModuleInfo);
			}
			if (this.buff_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Buff);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B173 RID: 45427 RVA: 0x001DCE94 File Offset: 0x001DB094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournCurGameInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.level_ != null)
			{
				if (this.level_ == null)
				{
					this.Level = new RogueTournLevelInfo();
				}
				this.Level.MergeFrom(other.Level);
			}
			if (other.unlockValue_ != null)
			{
				if (this.unlockValue_ == null)
				{
					this.UnlockValue = new KeywordUnlockValue();
				}
				this.UnlockValue.MergeFrom(other.UnlockValue);
			}
			if (other.itemValue_ != null)
			{
				if (this.itemValue_ == null)
				{
					this.ItemValue = new RogueGameItemValue();
				}
				this.ItemValue.MergeFrom(other.ItemValue);
			}
			if (other.rogueTournGameAreaInfo_ != null)
			{
				if (this.rogueTournGameAreaInfo_ == null)
				{
					this.RogueTournGameAreaInfo = new RogueTournGameAreaInfo();
				}
				this.RogueTournGameAreaInfo.MergeFrom(other.RogueTournGameAreaInfo);
			}
			if (other.gameDifficultyInfo_ != null)
			{
				if (this.gameDifficultyInfo_ == null)
				{
					this.GameDifficultyInfo = new RogueTournGameDifficultyInfo();
				}
				this.GameDifficultyInfo.MergeFrom(other.GameDifficultyInfo);
			}
			if (other.tournFormulaInfo_ != null)
			{
				if (this.tournFormulaInfo_ == null)
				{
					this.TournFormulaInfo = new RogueTournFormulaInfo();
				}
				this.TournFormulaInfo.MergeFrom(other.TournFormulaInfo);
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new RogueTournLineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.miracleInfo_ != null)
			{
				if (this.miracleInfo_ == null)
				{
					this.MiracleInfo = new ChessRogueMiracleInfo();
				}
				this.MiracleInfo.MergeFrom(other.MiracleInfo);
			}
			if (other.tournModuleInfo_ != null)
			{
				if (this.tournModuleInfo_ == null)
				{
					this.TournModuleInfo = new RogueTournModuleInfo();
				}
				this.TournModuleInfo.MergeFrom(other.TournModuleInfo);
			}
			if (other.buff_ != null)
			{
				if (this.buff_ == null)
				{
					this.Buff = new ChessRogueBuffInfo();
				}
				this.Buff.MergeFrom(other.Buff);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B174 RID: 45428 RVA: 0x001DD074 File Offset: 0x001DB274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B175 RID: 45429 RVA: 0x001DD080 File Offset: 0x001DB280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 66U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							if (this.unlockValue_ == null)
							{
								this.UnlockValue = new KeywordUnlockValue();
							}
							input.ReadMessage(this.UnlockValue);
							continue;
						}
						if (num == 18U)
						{
							if (this.level_ == null)
							{
								this.Level = new RogueTournLevelInfo();
							}
							input.ReadMessage(this.Level);
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.rogueTournGameAreaInfo_ == null)
							{
								this.RogueTournGameAreaInfo = new RogueTournGameAreaInfo();
							}
							input.ReadMessage(this.RogueTournGameAreaInfo);
							continue;
						}
						if (num == 58U)
						{
							if (this.miracleInfo_ == null)
							{
								this.MiracleInfo = new ChessRogueMiracleInfo();
							}
							input.ReadMessage(this.MiracleInfo);
							continue;
						}
						if (num == 66U)
						{
							if (this.tournFormulaInfo_ == null)
							{
								this.TournFormulaInfo = new RogueTournFormulaInfo();
							}
							input.ReadMessage(this.TournFormulaInfo);
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 74U)
					{
						if (this.itemValue_ == null)
						{
							this.ItemValue = new RogueGameItemValue();
						}
						input.ReadMessage(this.ItemValue);
						continue;
					}
					if (num == 82U)
					{
						if (this.gameDifficultyInfo_ == null)
						{
							this.GameDifficultyInfo = new RogueTournGameDifficultyInfo();
						}
						input.ReadMessage(this.GameDifficultyInfo);
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new RogueTournLineupInfo();
						}
						input.ReadMessage(this.Lineup);
						continue;
					}
					if (num == 114U)
					{
						if (this.tournModuleInfo_ == null)
						{
							this.TournModuleInfo = new RogueTournModuleInfo();
						}
						input.ReadMessage(this.TournModuleInfo);
						continue;
					}
					if (num == 122U)
					{
						if (this.buff_ == null)
						{
							this.Buff = new ChessRogueBuffInfo();
						}
						input.ReadMessage(this.Buff);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004823 RID: 18467
		private static readonly MessageParser<RogueTournCurGameInfo> _parser = new MessageParser<RogueTournCurGameInfo>(() => new RogueTournCurGameInfo());

		// Token: 0x04004824 RID: 18468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004825 RID: 18469
		public const int LevelFieldNumber = 2;

		// Token: 0x04004826 RID: 18470
		private RogueTournLevelInfo level_;

		// Token: 0x04004827 RID: 18471
		public const int UnlockValueFieldNumber = 1;

		// Token: 0x04004828 RID: 18472
		private KeywordUnlockValue unlockValue_;

		// Token: 0x04004829 RID: 18473
		public const int ItemValueFieldNumber = 9;

		// Token: 0x0400482A RID: 18474
		private RogueGameItemValue itemValue_;

		// Token: 0x0400482B RID: 18475
		public const int RogueTournGameAreaInfoFieldNumber = 6;

		// Token: 0x0400482C RID: 18476
		private RogueTournGameAreaInfo rogueTournGameAreaInfo_;

		// Token: 0x0400482D RID: 18477
		public const int GameDifficultyInfoFieldNumber = 10;

		// Token: 0x0400482E RID: 18478
		private RogueTournGameDifficultyInfo gameDifficultyInfo_;

		// Token: 0x0400482F RID: 18479
		public const int TournFormulaInfoFieldNumber = 8;

		// Token: 0x04004830 RID: 18480
		private RogueTournFormulaInfo tournFormulaInfo_;

		// Token: 0x04004831 RID: 18481
		public const int LineupFieldNumber = 11;

		// Token: 0x04004832 RID: 18482
		private RogueTournLineupInfo lineup_;

		// Token: 0x04004833 RID: 18483
		public const int MiracleInfoFieldNumber = 7;

		// Token: 0x04004834 RID: 18484
		private ChessRogueMiracleInfo miracleInfo_;

		// Token: 0x04004835 RID: 18485
		public const int TournModuleInfoFieldNumber = 14;

		// Token: 0x04004836 RID: 18486
		private RogueTournModuleInfo tournModuleInfo_;

		// Token: 0x04004837 RID: 18487
		public const int BuffFieldNumber = 15;

		// Token: 0x04004838 RID: 18488
		private ChessRogueBuffInfo buff_;
	}
}
