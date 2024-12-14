using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EB7 RID: 3767
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicCurInfo : IMessage<RogueMagicCurInfo>, IMessage, IEquatable<RogueMagicCurInfo>, IDeepCloneable<RogueMagicCurInfo>, IBufferMessage
	{
		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x0600A84B RID: 43083 RVA: 0x001C53FE File Offset: 0x001C35FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicCurInfo> Parser
		{
			get
			{
				return RogueMagicCurInfo._parser;
			}
		}

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x0600A84C RID: 43084 RVA: 0x001C5405 File Offset: 0x001C3605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicCurInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x0600A84D RID: 43085 RVA: 0x001C5417 File Offset: 0x001C3617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicCurInfo.Descriptor;
			}
		}

		// Token: 0x0600A84E RID: 43086 RVA: 0x001C541E File Offset: 0x001C361E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurInfo()
		{
		}

		// Token: 0x0600A84F RID: 43087 RVA: 0x001C5428 File Offset: 0x001C3628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurInfo(RogueMagicCurInfo other) : this()
		{
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.itemValue_ = ((other.itemValue_ != null) ? other.itemValue_.Clone() : null);
			this.miracleInfo_ = ((other.miracleInfo_ != null) ? other.miracleInfo_.Clone() : null);
			this.level_ = ((other.level_ != null) ? other.level_.Clone() : null);
			this.gameDifficultyInfo_ = ((other.gameDifficultyInfo_ != null) ? other.gameDifficultyInfo_.Clone() : null);
			this.jDMGJDBMHEJ_ = ((other.jDMGJDBMHEJ_ != null) ? other.jDMGJDBMHEJ_.Clone() : null);
			this.magicItem_ = ((other.magicItem_ != null) ? other.magicItem_.Clone() : null);
			this.basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A850 RID: 43088 RVA: 0x001C552C File Offset: 0x001C372C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurInfo Clone()
		{
			return new RogueMagicCurInfo(this);
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x0600A851 RID: 43089 RVA: 0x001C5534 File Offset: 0x001C3734
		// (set) Token: 0x0600A852 RID: 43090 RVA: 0x001C553C File Offset: 0x001C373C
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

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x0600A853 RID: 43091 RVA: 0x001C5545 File Offset: 0x001C3745
		// (set) Token: 0x0600A854 RID: 43092 RVA: 0x001C554D File Offset: 0x001C374D
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

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x0600A855 RID: 43093 RVA: 0x001C5556 File Offset: 0x001C3756
		// (set) Token: 0x0600A856 RID: 43094 RVA: 0x001C555E File Offset: 0x001C375E
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

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x0600A857 RID: 43095 RVA: 0x001C5567 File Offset: 0x001C3767
		// (set) Token: 0x0600A858 RID: 43096 RVA: 0x001C556F File Offset: 0x001C376F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameLevelInfo Level
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

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x0600A859 RID: 43097 RVA: 0x001C5578 File Offset: 0x001C3778
		// (set) Token: 0x0600A85A RID: 43098 RVA: 0x001C5580 File Offset: 0x001C3780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameDifficultyInfo GameDifficultyInfo
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

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x0600A85B RID: 43099 RVA: 0x001C5589 File Offset: 0x001C3789
		// (set) Token: 0x0600A85C RID: 43100 RVA: 0x001C5591 File Offset: 0x001C3791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LKJMDOAHGIN JDMGJDBMHEJ
		{
			get
			{
				return this.jDMGJDBMHEJ_;
			}
			set
			{
				this.jDMGJDBMHEJ_ = value;
			}
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x0600A85D RID: 43101 RVA: 0x001C559A File Offset: 0x001C379A
		// (set) Token: 0x0600A85E RID: 43102 RVA: 0x001C55A2 File Offset: 0x001C37A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameItemInfo MagicItem
		{
			get
			{
				return this.magicItem_;
			}
			set
			{
				this.magicItem_ = value;
			}
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x0600A85F RID: 43103 RVA: 0x001C55AB File Offset: 0x001C37AB
		// (set) Token: 0x0600A860 RID: 43104 RVA: 0x001C55B3 File Offset: 0x001C37B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurAreaInfo BasicInfo
		{
			get
			{
				return this.basicInfo_;
			}
			set
			{
				this.basicInfo_ = value;
			}
		}

		// Token: 0x0600A861 RID: 43105 RVA: 0x001C55BC File Offset: 0x001C37BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicCurInfo);
		}

		// Token: 0x0600A862 RID: 43106 RVA: 0x001C55CC File Offset: 0x001C37CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicCurInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Lineup, other.Lineup) && object.Equals(this.ItemValue, other.ItemValue) && object.Equals(this.MiracleInfo, other.MiracleInfo) && object.Equals(this.Level, other.Level) && object.Equals(this.GameDifficultyInfo, other.GameDifficultyInfo) && object.Equals(this.JDMGJDBMHEJ, other.JDMGJDBMHEJ) && object.Equals(this.MagicItem, other.MagicItem) && object.Equals(this.BasicInfo, other.BasicInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A863 RID: 43107 RVA: 0x001C56A0 File Offset: 0x001C38A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.itemValue_ != null)
			{
				num ^= this.ItemValue.GetHashCode();
			}
			if (this.miracleInfo_ != null)
			{
				num ^= this.MiracleInfo.GetHashCode();
			}
			if (this.level_ != null)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.gameDifficultyInfo_ != null)
			{
				num ^= this.GameDifficultyInfo.GetHashCode();
			}
			if (this.jDMGJDBMHEJ_ != null)
			{
				num ^= this.JDMGJDBMHEJ.GetHashCode();
			}
			if (this.magicItem_ != null)
			{
				num ^= this.MagicItem.GetHashCode();
			}
			if (this.basicInfo_ != null)
			{
				num ^= this.BasicInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A864 RID: 43108 RVA: 0x001C5776 File Offset: 0x001C3976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A865 RID: 43109 RVA: 0x001C577E File Offset: 0x001C397E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A866 RID: 43110 RVA: 0x001C5788 File Offset: 0x001C3988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lineup_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Lineup);
			}
			if (this.itemValue_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ItemValue);
			}
			if (this.gameDifficultyInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.GameDifficultyInfo);
			}
			if (this.level_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Level);
			}
			if (this.magicItem_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MagicItem);
			}
			if (this.miracleInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MiracleInfo);
			}
			if (this.jDMGJDBMHEJ_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.JDMGJDBMHEJ);
			}
			if (this.basicInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.BasicInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A867 RID: 43111 RVA: 0x001C588C File Offset: 0x001C3A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.itemValue_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemValue);
			}
			if (this.miracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MiracleInfo);
			}
			if (this.level_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Level);
			}
			if (this.gameDifficultyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameDifficultyInfo);
			}
			if (this.jDMGJDBMHEJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JDMGJDBMHEJ);
			}
			if (this.magicItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MagicItem);
			}
			if (this.basicInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BasicInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A868 RID: 43112 RVA: 0x001C5974 File Offset: 0x001C3B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicCurInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new RogueTournLineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.itemValue_ != null)
			{
				if (this.itemValue_ == null)
				{
					this.ItemValue = new RogueGameItemValue();
				}
				this.ItemValue.MergeFrom(other.ItemValue);
			}
			if (other.miracleInfo_ != null)
			{
				if (this.miracleInfo_ == null)
				{
					this.MiracleInfo = new ChessRogueMiracleInfo();
				}
				this.MiracleInfo.MergeFrom(other.MiracleInfo);
			}
			if (other.level_ != null)
			{
				if (this.level_ == null)
				{
					this.Level = new RogueMagicGameLevelInfo();
				}
				this.Level.MergeFrom(other.Level);
			}
			if (other.gameDifficultyInfo_ != null)
			{
				if (this.gameDifficultyInfo_ == null)
				{
					this.GameDifficultyInfo = new RogueMagicGameDifficultyInfo();
				}
				this.GameDifficultyInfo.MergeFrom(other.GameDifficultyInfo);
			}
			if (other.jDMGJDBMHEJ_ != null)
			{
				if (this.jDMGJDBMHEJ_ == null)
				{
					this.JDMGJDBMHEJ = new LKJMDOAHGIN();
				}
				this.JDMGJDBMHEJ.MergeFrom(other.JDMGJDBMHEJ);
			}
			if (other.magicItem_ != null)
			{
				if (this.magicItem_ == null)
				{
					this.MagicItem = new RogueMagicGameItemInfo();
				}
				this.MagicItem.MergeFrom(other.MagicItem);
			}
			if (other.basicInfo_ != null)
			{
				if (this.basicInfo_ == null)
				{
					this.BasicInfo = new RogueTournCurAreaInfo();
				}
				this.BasicInfo.MergeFrom(other.BasicInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A869 RID: 43113 RVA: 0x001C5AFC File Offset: 0x001C3CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x001C5B08 File Offset: 0x001C3D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num <= 42U)
					{
						if (num == 10U)
						{
							if (this.lineup_ == null)
							{
								this.Lineup = new RogueTournLineupInfo();
							}
							input.ReadMessage(this.Lineup);
							continue;
						}
						if (num == 42U)
						{
							if (this.itemValue_ == null)
							{
								this.ItemValue = new RogueGameItemValue();
							}
							input.ReadMessage(this.ItemValue);
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							if (this.gameDifficultyInfo_ == null)
							{
								this.GameDifficultyInfo = new RogueMagicGameDifficultyInfo();
							}
							input.ReadMessage(this.GameDifficultyInfo);
							continue;
						}
						if (num == 74U)
						{
							if (this.level_ == null)
							{
								this.Level = new RogueMagicGameLevelInfo();
							}
							input.ReadMessage(this.Level);
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num == 82U)
					{
						if (this.magicItem_ == null)
						{
							this.MagicItem = new RogueMagicGameItemInfo();
						}
						input.ReadMessage(this.MagicItem);
						continue;
					}
					if (num == 98U)
					{
						if (this.miracleInfo_ == null)
						{
							this.MiracleInfo = new ChessRogueMiracleInfo();
						}
						input.ReadMessage(this.MiracleInfo);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.jDMGJDBMHEJ_ == null)
						{
							this.JDMGJDBMHEJ = new LKJMDOAHGIN();
						}
						input.ReadMessage(this.JDMGJDBMHEJ);
						continue;
					}
					if (num == 114U)
					{
						if (this.basicInfo_ == null)
						{
							this.BasicInfo = new RogueTournCurAreaInfo();
						}
						input.ReadMessage(this.BasicInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040044C6 RID: 17606
		private static readonly MessageParser<RogueMagicCurInfo> _parser = new MessageParser<RogueMagicCurInfo>(() => new RogueMagicCurInfo());

		// Token: 0x040044C7 RID: 17607
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044C8 RID: 17608
		public const int LineupFieldNumber = 1;

		// Token: 0x040044C9 RID: 17609
		private RogueTournLineupInfo lineup_;

		// Token: 0x040044CA RID: 17610
		public const int ItemValueFieldNumber = 5;

		// Token: 0x040044CB RID: 17611
		private RogueGameItemValue itemValue_;

		// Token: 0x040044CC RID: 17612
		public const int MiracleInfoFieldNumber = 12;

		// Token: 0x040044CD RID: 17613
		private ChessRogueMiracleInfo miracleInfo_;

		// Token: 0x040044CE RID: 17614
		public const int LevelFieldNumber = 9;

		// Token: 0x040044CF RID: 17615
		private RogueMagicGameLevelInfo level_;

		// Token: 0x040044D0 RID: 17616
		public const int GameDifficultyInfoFieldNumber = 7;

		// Token: 0x040044D1 RID: 17617
		private RogueMagicGameDifficultyInfo gameDifficultyInfo_;

		// Token: 0x040044D2 RID: 17618
		public const int JDMGJDBMHEJFieldNumber = 13;

		// Token: 0x040044D3 RID: 17619
		private LKJMDOAHGIN jDMGJDBMHEJ_;

		// Token: 0x040044D4 RID: 17620
		public const int MagicItemFieldNumber = 10;

		// Token: 0x040044D5 RID: 17621
		private RogueMagicGameItemInfo magicItem_;

		// Token: 0x040044D6 RID: 17622
		public const int BasicInfoFieldNumber = 14;

		// Token: 0x040044D7 RID: 17623
		private RogueTournCurAreaInfo basicInfo_;
	}
}
