using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200021F RID: 543
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueGameInfo : IMessage<ChessRogueGameInfo>, IMessage, IEquatable<ChessRogueGameInfo>, IDeepCloneable<ChessRogueGameInfo>, IBufferMessage
	{
		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x0004683E File Offset: 0x00044A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueGameInfo> Parser
		{
			get
			{
				return ChessRogueGameInfo._parser;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x00046845 File Offset: 0x00044A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueGameInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x00046857 File Offset: 0x00044A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueGameInfo.Descriptor;
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0004685E File Offset: 0x00044A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGameInfo()
		{
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00046874 File Offset: 0x00044A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGameInfo(ChessRogueGameInfo other) : this()
		{
			this.nousValueInfo_ = ((other.nousValueInfo_ != null) ? other.nousValueInfo_.Clone() : null);
			this.rogueLineupInfo_ = ((other.rogueLineupInfo_ != null) ? other.rogueLineupInfo_.Clone() : null);
			this.pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
			this.gameMiracleInfo_ = ((other.gameMiracleInfo_ != null) ? other.gameMiracleInfo_.Clone() : null);
			this.rogueBuffInfo_ = ((other.rogueBuffInfo_ != null) ? other.rogueBuffInfo_.Clone() : null);
			this.storyInfo_ = ((other.storyInfo_ != null) ? other.storyInfo_.Clone() : null);
			this.rogueDifficultyInfo_ = ((other.rogueDifficultyInfo_ != null) ? other.rogueDifficultyInfo_.Clone() : null);
			this.rogueVirtualItemInfo_ = ((other.rogueVirtualItemInfo_ != null) ? other.rogueVirtualItemInfo_.Clone() : null);
			this.rogueSubMode_ = other.rogueSubMode_;
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this.rogueAeonInfo_ = ((other.rogueAeonInfo_ != null) ? other.rogueAeonInfo_.Clone() : null);
			this.rogueStoryInfo_ = ((other.rogueStoryInfo_ != null) ? other.rogueStoryInfo_.Clone() : null);
			this.virtualItemInfo_ = ((other.virtualItemInfo_ != null) ? other.virtualItemInfo_.Clone() : null);
			this.rogueDiceInfo_ = ((other.rogueDiceInfo_ != null) ? other.rogueDiceInfo_.Clone() : null);
			this.rogueCurrentGameInfo_ = other.rogueCurrentGameInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00046A21 File Offset: 0x00044C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGameInfo Clone()
		{
			return new ChessRogueGameInfo(this);
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x00046A29 File Offset: 0x00044C29
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x00046A31 File Offset: 0x00044C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousValueInfo NousValueInfo
		{
			get
			{
				return this.nousValueInfo_;
			}
			set
			{
				this.nousValueInfo_ = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00046A3A File Offset: 0x00044C3A
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x00046A42 File Offset: 0x00044C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLineupInfo RogueLineupInfo
		{
			get
			{
				return this.rogueLineupInfo_;
			}
			set
			{
				this.rogueLineupInfo_ = value;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x00046A4B File Offset: 0x00044C4B
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x00046A53 File Offset: 0x00044C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPendingAction PendingAction
		{
			get
			{
				return this.pendingAction_;
			}
			set
			{
				this.pendingAction_ = value;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x00046A5C File Offset: 0x00044C5C
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x00046A64 File Offset: 0x00044C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracleInfo GameMiracleInfo
		{
			get
			{
				return this.gameMiracleInfo_;
			}
			set
			{
				this.gameMiracleInfo_ = value;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x00046A6D File Offset: 0x00044C6D
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x00046A75 File Offset: 0x00044C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffInfo RogueBuffInfo
		{
			get
			{
				return this.rogueBuffInfo_;
			}
			set
			{
				this.rogueBuffInfo_ = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x00046A7E File Offset: 0x00044C7E
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x00046A86 File Offset: 0x00044C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JIIOHNDIHAM StoryInfo
		{
			get
			{
				return this.storyInfo_;
			}
			set
			{
				this.storyInfo_ = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x00046A8F File Offset: 0x00044C8F
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x00046A97 File Offset: 0x00044C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCurrentDifficultyInfo RogueDifficultyInfo
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

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x00046AA0 File Offset: 0x00044CA0
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x00046AA8 File Offset: 0x00044CA8
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

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x00046AB1 File Offset: 0x00044CB1
		// (set) Token: 0x06001869 RID: 6249 RVA: 0x00046AB9 File Offset: 0x00044CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueSubMode
		{
			get
			{
				return this.rogueSubMode_;
			}
			set
			{
				this.rogueSubMode_ = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x00046AC2 File Offset: 0x00044CC2
		// (set) Token: 0x0600186B RID: 6251 RVA: 0x00046ACA File Offset: 0x00044CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x00046AD3 File Offset: 0x00044CD3
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x00046ADB File Offset: 0x00044CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueAeonInfo RogueAeonInfo
		{
			get
			{
				return this.rogueAeonInfo_;
			}
			set
			{
				this.rogueAeonInfo_ = value;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x00046AE4 File Offset: 0x00044CE4
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x00046AEC File Offset: 0x00044CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueStoryInfo RogueStoryInfo
		{
			get
			{
				return this.rogueStoryInfo_;
			}
			set
			{
				this.rogueStoryInfo_ = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x00046AF5 File Offset: 0x00044CF5
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x00046AFD File Offset: 0x00044CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueVirtualItem VirtualItemInfo
		{
			get
			{
				return this.virtualItemInfo_;
			}
			set
			{
				this.virtualItemInfo_ = value;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00046B06 File Offset: 0x00044D06
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x00046B0E File Offset: 0x00044D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceInfo RogueDiceInfo
		{
			get
			{
				return this.rogueDiceInfo_;
			}
			set
			{
				this.rogueDiceInfo_ = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00046B17 File Offset: 0x00044D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGameInfo> RogueCurrentGameInfo
		{
			get
			{
				return this.rogueCurrentGameInfo_;
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00046B1F File Offset: 0x00044D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueGameInfo);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00046B30 File Offset: 0x00044D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueGameInfo other)
		{
			return other != null && (other == this || (object.Equals(this.NousValueInfo, other.NousValueInfo) && object.Equals(this.RogueLineupInfo, other.RogueLineupInfo) && object.Equals(this.PendingAction, other.PendingAction) && object.Equals(this.GameMiracleInfo, other.GameMiracleInfo) && object.Equals(this.RogueBuffInfo, other.RogueBuffInfo) && object.Equals(this.StoryInfo, other.StoryInfo) && object.Equals(this.RogueDifficultyInfo, other.RogueDifficultyInfo) && object.Equals(this.RogueVirtualItemInfo, other.RogueVirtualItemInfo) && this.RogueSubMode == other.RogueSubMode && object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this.RogueAeonInfo, other.RogueAeonInfo) && object.Equals(this.RogueStoryInfo, other.RogueStoryInfo) && object.Equals(this.VirtualItemInfo, other.VirtualItemInfo) && object.Equals(this.RogueDiceInfo, other.RogueDiceInfo) && this.rogueCurrentGameInfo_.Equals(other.rogueCurrentGameInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00046C90 File Offset: 0x00044E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.nousValueInfo_ != null)
			{
				num ^= this.NousValueInfo.GetHashCode();
			}
			if (this.rogueLineupInfo_ != null)
			{
				num ^= this.RogueLineupInfo.GetHashCode();
			}
			if (this.pendingAction_ != null)
			{
				num ^= this.PendingAction.GetHashCode();
			}
			if (this.gameMiracleInfo_ != null)
			{
				num ^= this.GameMiracleInfo.GetHashCode();
			}
			if (this.rogueBuffInfo_ != null)
			{
				num ^= this.RogueBuffInfo.GetHashCode();
			}
			if (this.storyInfo_ != null)
			{
				num ^= this.StoryInfo.GetHashCode();
			}
			if (this.rogueDifficultyInfo_ != null)
			{
				num ^= this.RogueDifficultyInfo.GetHashCode();
			}
			if (this.rogueVirtualItemInfo_ != null)
			{
				num ^= this.RogueVirtualItemInfo.GetHashCode();
			}
			if (this.RogueSubMode != 0U)
			{
				num ^= this.RogueSubMode.GetHashCode();
			}
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this.rogueAeonInfo_ != null)
			{
				num ^= this.RogueAeonInfo.GetHashCode();
			}
			if (this.rogueStoryInfo_ != null)
			{
				num ^= this.RogueStoryInfo.GetHashCode();
			}
			if (this.virtualItemInfo_ != null)
			{
				num ^= this.VirtualItemInfo.GetHashCode();
			}
			if (this.rogueDiceInfo_ != null)
			{
				num ^= this.RogueDiceInfo.GetHashCode();
			}
			num ^= this.rogueCurrentGameInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00046DFB File Offset: 0x00044FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00046E03 File Offset: 0x00045003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00046E0C File Offset: 0x0004500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueAeonInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueAeonInfo);
			}
			if (this.rogueDiceInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueDiceInfo);
			}
			if (this.pendingAction_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PendingAction);
			}
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.LevelInfo);
			}
			if (this.storyInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.StoryInfo);
			}
			if (this.rogueVirtualItemInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueVirtualItemInfo);
			}
			if (this.rogueLineupInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueLineupInfo);
			}
			if (this.RogueSubMode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.RogueSubMode);
			}
			if (this.nousValueInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.NousValueInfo);
			}
			if (this.rogueStoryInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueStoryInfo);
			}
			if (this.rogueBuffInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RogueBuffInfo);
			}
			if (this.gameMiracleInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.GameMiracleInfo);
			}
			this.rogueCurrentGameInfo_.WriteTo(ref output, ChessRogueGameInfo._repeated_rogueCurrentGameInfo_codec);
			if (this.virtualItemInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.VirtualItemInfo);
			}
			if (this.rogueDifficultyInfo_ != null)
			{
				output.WriteRawTag(210, 33);
				output.WriteMessage(this.RogueDifficultyInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00046FCC File Offset: 0x000451CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.nousValueInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NousValueInfo);
			}
			if (this.rogueLineupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueLineupInfo);
			}
			if (this.pendingAction_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PendingAction);
			}
			if (this.gameMiracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameMiracleInfo);
			}
			if (this.rogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuffInfo);
			}
			if (this.storyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StoryInfo);
			}
			if (this.rogueDifficultyInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueDifficultyInfo);
			}
			if (this.rogueVirtualItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueVirtualItemInfo);
			}
			if (this.RogueSubMode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueSubMode);
			}
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this.rogueAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAeonInfo);
			}
			if (this.rogueStoryInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueStoryInfo);
			}
			if (this.virtualItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VirtualItemInfo);
			}
			if (this.rogueDiceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueDiceInfo);
			}
			num += this.rogueCurrentGameInfo_.CalculateSize(ChessRogueGameInfo._repeated_rogueCurrentGameInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00047158 File Offset: 0x00045358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueGameInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.nousValueInfo_ != null)
			{
				if (this.nousValueInfo_ == null)
				{
					this.NousValueInfo = new ChessRogueNousValueInfo();
				}
				this.NousValueInfo.MergeFrom(other.NousValueInfo);
			}
			if (other.rogueLineupInfo_ != null)
			{
				if (this.rogueLineupInfo_ == null)
				{
					this.RogueLineupInfo = new ChessRogueLineupInfo();
				}
				this.RogueLineupInfo.MergeFrom(other.RogueLineupInfo);
			}
			if (other.pendingAction_ != null)
			{
				if (this.pendingAction_ == null)
				{
					this.PendingAction = new RogueCommonPendingAction();
				}
				this.PendingAction.MergeFrom(other.PendingAction);
			}
			if (other.gameMiracleInfo_ != null)
			{
				if (this.gameMiracleInfo_ == null)
				{
					this.GameMiracleInfo = new ChessRogueMiracleInfo();
				}
				this.GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
			}
			if (other.rogueBuffInfo_ != null)
			{
				if (this.rogueBuffInfo_ == null)
				{
					this.RogueBuffInfo = new ChessRogueBuffInfo();
				}
				this.RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
			}
			if (other.storyInfo_ != null)
			{
				if (this.storyInfo_ == null)
				{
					this.StoryInfo = new JIIOHNDIHAM();
				}
				this.StoryInfo.MergeFrom(other.StoryInfo);
			}
			if (other.rogueDifficultyInfo_ != null)
			{
				if (this.rogueDifficultyInfo_ == null)
				{
					this.RogueDifficultyInfo = new ChessRogueCurrentDifficultyInfo();
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
			if (other.RogueSubMode != 0U)
			{
				this.RogueSubMode = other.RogueSubMode;
			}
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new ChessRogueLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			if (other.rogueAeonInfo_ != null)
			{
				if (this.rogueAeonInfo_ == null)
				{
					this.RogueAeonInfo = new ChessRogueAeonInfo();
				}
				this.RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
			}
			if (other.rogueStoryInfo_ != null)
			{
				if (this.rogueStoryInfo_ == null)
				{
					this.RogueStoryInfo = new ChessRogueStoryInfo();
				}
				this.RogueStoryInfo.MergeFrom(other.RogueStoryInfo);
			}
			if (other.virtualItemInfo_ != null)
			{
				if (this.virtualItemInfo_ == null)
				{
					this.VirtualItemInfo = new RogueVirtualItem();
				}
				this.VirtualItemInfo.MergeFrom(other.VirtualItemInfo);
			}
			if (other.rogueDiceInfo_ != null)
			{
				if (this.rogueDiceInfo_ == null)
				{
					this.RogueDiceInfo = new ChessRogueDiceInfo();
				}
				this.RogueDiceInfo.MergeFrom(other.RogueDiceInfo);
			}
			this.rogueCurrentGameInfo_.Add(other.rogueCurrentGameInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x000473E1 File Offset: 0x000455E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x000473EC File Offset: 0x000455EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
						{
							if (this.rogueAeonInfo_ == null)
							{
								this.RogueAeonInfo = new ChessRogueAeonInfo();
							}
							input.ReadMessage(this.RogueAeonInfo);
							continue;
						}
						if (num == 18U)
						{
							if (this.rogueDiceInfo_ == null)
							{
								this.RogueDiceInfo = new ChessRogueDiceInfo();
							}
							input.ReadMessage(this.RogueDiceInfo);
							continue;
						}
						if (num == 26U)
						{
							if (this.pendingAction_ == null)
							{
								this.PendingAction = new RogueCommonPendingAction();
							}
							input.ReadMessage(this.PendingAction);
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 34U)
						{
							if (this.levelInfo_ == null)
							{
								this.LevelInfo = new ChessRogueLevelInfo();
							}
							input.ReadMessage(this.LevelInfo);
							continue;
						}
						if (num == 42U)
						{
							if (this.storyInfo_ == null)
							{
								this.StoryInfo = new JIIOHNDIHAM();
							}
							input.ReadMessage(this.StoryInfo);
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.rogueVirtualItemInfo_ == null)
							{
								this.RogueVirtualItemInfo = new OICEICJKOCM();
							}
							input.ReadMessage(this.RogueVirtualItemInfo);
							continue;
						}
						if (num == 58U)
						{
							if (this.rogueLineupInfo_ == null)
							{
								this.RogueLineupInfo = new ChessRogueLineupInfo();
							}
							input.ReadMessage(this.RogueLineupInfo);
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num <= 74U)
					{
						if (num == 64U)
						{
							this.RogueSubMode = input.ReadUInt32();
							continue;
						}
						if (num == 74U)
						{
							if (this.nousValueInfo_ == null)
							{
								this.NousValueInfo = new ChessRogueNousValueInfo();
							}
							input.ReadMessage(this.NousValueInfo);
							continue;
						}
					}
					else
					{
						if (num == 82U)
						{
							if (this.rogueStoryInfo_ == null)
							{
								this.RogueStoryInfo = new ChessRogueStoryInfo();
							}
							input.ReadMessage(this.RogueStoryInfo);
							continue;
						}
						if (num == 90U)
						{
							if (this.rogueBuffInfo_ == null)
							{
								this.RogueBuffInfo = new ChessRogueBuffInfo();
							}
							input.ReadMessage(this.RogueBuffInfo);
							continue;
						}
					}
				}
				else if (num <= 106U)
				{
					if (num == 98U)
					{
						if (this.gameMiracleInfo_ == null)
						{
							this.GameMiracleInfo = new ChessRogueMiracleInfo();
						}
						input.ReadMessage(this.GameMiracleInfo);
						continue;
					}
					if (num == 106U)
					{
						this.rogueCurrentGameInfo_.AddEntriesFrom(ref input, ChessRogueGameInfo._repeated_rogueCurrentGameInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.virtualItemInfo_ == null)
						{
							this.VirtualItemInfo = new RogueVirtualItem();
						}
						input.ReadMessage(this.VirtualItemInfo);
						continue;
					}
					if (num == 4306U)
					{
						if (this.rogueDifficultyInfo_ == null)
						{
							this.RogueDifficultyInfo = new ChessRogueCurrentDifficultyInfo();
						}
						input.ReadMessage(this.RogueDifficultyInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A5C RID: 2652
		private static readonly MessageParser<ChessRogueGameInfo> _parser = new MessageParser<ChessRogueGameInfo>(() => new ChessRogueGameInfo());

		// Token: 0x04000A5D RID: 2653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A5E RID: 2654
		public const int NousValueInfoFieldNumber = 9;

		// Token: 0x04000A5F RID: 2655
		private ChessRogueNousValueInfo nousValueInfo_;

		// Token: 0x04000A60 RID: 2656
		public const int RogueLineupInfoFieldNumber = 7;

		// Token: 0x04000A61 RID: 2657
		private ChessRogueLineupInfo rogueLineupInfo_;

		// Token: 0x04000A62 RID: 2658
		public const int PendingActionFieldNumber = 3;

		// Token: 0x04000A63 RID: 2659
		private RogueCommonPendingAction pendingAction_;

		// Token: 0x04000A64 RID: 2660
		public const int GameMiracleInfoFieldNumber = 12;

		// Token: 0x04000A65 RID: 2661
		private ChessRogueMiracleInfo gameMiracleInfo_;

		// Token: 0x04000A66 RID: 2662
		public const int RogueBuffInfoFieldNumber = 11;

		// Token: 0x04000A67 RID: 2663
		private ChessRogueBuffInfo rogueBuffInfo_;

		// Token: 0x04000A68 RID: 2664
		public const int StoryInfoFieldNumber = 5;

		// Token: 0x04000A69 RID: 2665
		private JIIOHNDIHAM storyInfo_;

		// Token: 0x04000A6A RID: 2666
		public const int RogueDifficultyInfoFieldNumber = 538;

		// Token: 0x04000A6B RID: 2667
		private ChessRogueCurrentDifficultyInfo rogueDifficultyInfo_;

		// Token: 0x04000A6C RID: 2668
		public const int RogueVirtualItemInfoFieldNumber = 6;

		// Token: 0x04000A6D RID: 2669
		private OICEICJKOCM rogueVirtualItemInfo_;

		// Token: 0x04000A6E RID: 2670
		public const int RogueSubModeFieldNumber = 8;

		// Token: 0x04000A6F RID: 2671
		private uint rogueSubMode_;

		// Token: 0x04000A70 RID: 2672
		public const int LevelInfoFieldNumber = 4;

		// Token: 0x04000A71 RID: 2673
		private ChessRogueLevelInfo levelInfo_;

		// Token: 0x04000A72 RID: 2674
		public const int RogueAeonInfoFieldNumber = 1;

		// Token: 0x04000A73 RID: 2675
		private ChessRogueAeonInfo rogueAeonInfo_;

		// Token: 0x04000A74 RID: 2676
		public const int RogueStoryInfoFieldNumber = 10;

		// Token: 0x04000A75 RID: 2677
		private ChessRogueStoryInfo rogueStoryInfo_;

		// Token: 0x04000A76 RID: 2678
		public const int VirtualItemInfoFieldNumber = 14;

		// Token: 0x04000A77 RID: 2679
		private RogueVirtualItem virtualItemInfo_;

		// Token: 0x04000A78 RID: 2680
		public const int RogueDiceInfoFieldNumber = 2;

		// Token: 0x04000A79 RID: 2681
		private ChessRogueDiceInfo rogueDiceInfo_;

		// Token: 0x04000A7A RID: 2682
		public const int RogueCurrentGameInfoFieldNumber = 13;

		// Token: 0x04000A7B RID: 2683
		private static readonly FieldCodec<RogueGameInfo> _repeated_rogueCurrentGameInfo_codec = FieldCodec.ForMessage<RogueGameInfo>(106U, RogueGameInfo.Parser);

		// Token: 0x04000A7C RID: 2684
		private readonly RepeatedField<RogueGameInfo> rogueCurrentGameInfo_ = new RepeatedField<RogueGameInfo>();
	}
}
