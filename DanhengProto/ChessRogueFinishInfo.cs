using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200021B RID: 539
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueFinishInfo : IMessage<ChessRogueFinishInfo>, IMessage, IEquatable<ChessRogueFinishInfo>, IDeepCloneable<ChessRogueFinishInfo>, IBufferMessage
	{
		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00045224 File Offset: 0x00043424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueFinishInfo> Parser
		{
			get
			{
				return ChessRogueFinishInfo._parser;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0004522B File Offset: 0x0004342B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueFinishInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x0004523D File Offset: 0x0004343D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueFinishInfo.Descriptor;
			}
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00045244 File Offset: 0x00043444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueFinishInfo()
		{
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00045258 File Offset: 0x00043458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueFinishInfo(ChessRogueFinishInfo other) : this()
		{
			this.quitReason_ = other.quitReason_;
			this.isFinish_ = other.isFinish_;
			this.bNMNFEKMCNM_ = other.bNMNFEKMCNM_;
			this.oEPFGHBAJOO_ = ((other.oEPFGHBAJOO_ != null) ? other.oEPFGHBAJOO_.Clone() : null);
			this.chessRogueMainStoryId_ = other.chessRogueMainStoryId_;
			this.rogueLineup_ = ((other.rogueLineup_ != null) ? other.rogueLineup_.Clone() : null);
			this.hBLHPOLEDGA_ = other.hBLHPOLEDGA_.Clone();
			this.difficultyLevel_ = other.difficultyLevel_;
			this.hLCDOADEIJI_ = other.hLCDOADEIJI_;
			this.rogueBuffInfo_ = ((other.rogueBuffInfo_ != null) ? other.rogueBuffInfo_.Clone() : null);
			this.fGGJEGFMMAO_ = other.fGGJEGFMMAO_;
			this.rogueStoryInfo_ = ((other.rogueStoryInfo_ != null) ? other.rogueStoryInfo_.Clone() : null);
			this.oAKCHBDNEIC_ = other.oAKCHBDNEIC_;
			this.gEFPJKGJLEO_ = other.gEFPJKGJLEO_;
			this.gameMiracleInfo_ = ((other.gameMiracleInfo_ != null) ? other.gameMiracleInfo_.Clone() : null);
			this.scoreId_ = other.scoreId_;
			this.hMGHMJLLHKC_ = other.hMGHMJLLHKC_;
			this.gAFCODOPAMF_ = other.gAFCODOPAMF_;
			this.rogueSubMode_ = other.rogueSubMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x000453B5 File Offset: 0x000435B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueFinishInfo Clone()
		{
			return new ChessRogueFinishInfo(this);
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x000453BD File Offset: 0x000435BD
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x000453C5 File Offset: 0x000435C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQuitReason QuitReason
		{
			get
			{
				return this.quitReason_;
			}
			set
			{
				this.quitReason_ = value;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x000453CE File Offset: 0x000435CE
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x000453D6 File Offset: 0x000435D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x000453DF File Offset: 0x000435DF
		// (set) Token: 0x0600180C RID: 6156 RVA: 0x000453E7 File Offset: 0x000435E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BNMNFEKMCNM
		{
			get
			{
				return this.bNMNFEKMCNM_;
			}
			set
			{
				this.bNMNFEKMCNM_ = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x000453F0 File Offset: 0x000435F0
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x000453F8 File Offset: 0x000435F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList OEPFGHBAJOO
		{
			get
			{
				return this.oEPFGHBAJOO_;
			}
			set
			{
				this.oEPFGHBAJOO_ = value;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x00045401 File Offset: 0x00043601
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x00045409 File Offset: 0x00043609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChessRogueMainStoryId
		{
			get
			{
				return this.chessRogueMainStoryId_;
			}
			set
			{
				this.chessRogueMainStoryId_ = value;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x00045412 File Offset: 0x00043612
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x0004541A File Offset: 0x0004361A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo RogueLineup
		{
			get
			{
				return this.rogueLineup_;
			}
			set
			{
				this.rogueLineup_ = value;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x00045423 File Offset: 0x00043623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HBLHPOLEDGA
		{
			get
			{
				return this.hBLHPOLEDGA_;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x0004542B File Offset: 0x0004362B
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x00045433 File Offset: 0x00043633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DifficultyLevel
		{
			get
			{
				return this.difficultyLevel_;
			}
			set
			{
				this.difficultyLevel_ = value;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x0004543C File Offset: 0x0004363C
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x00045444 File Offset: 0x00043644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HLCDOADEIJI
		{
			get
			{
				return this.hLCDOADEIJI_;
			}
			set
			{
				this.hLCDOADEIJI_ = value;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x0004544D File Offset: 0x0004364D
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x00045455 File Offset: 0x00043655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuff RogueBuffInfo
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

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x0004545E File Offset: 0x0004365E
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x00045466 File Offset: 0x00043666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FGGJEGFMMAO
		{
			get
			{
				return this.fGGJEGFMMAO_;
			}
			set
			{
				this.fGGJEGFMMAO_ = value;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x0004546F File Offset: 0x0004366F
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x00045477 File Offset: 0x00043677
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

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x00045480 File Offset: 0x00043680
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x00045488 File Offset: 0x00043688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OAKCHBDNEIC
		{
			get
			{
				return this.oAKCHBDNEIC_;
			}
			set
			{
				this.oAKCHBDNEIC_ = value;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x00045491 File Offset: 0x00043691
		// (set) Token: 0x06001821 RID: 6177 RVA: 0x00045499 File Offset: 0x00043699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GEFPJKGJLEO
		{
			get
			{
				return this.gEFPJKGJLEO_;
			}
			set
			{
				this.gEFPJKGJLEO_ = value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x000454A2 File Offset: 0x000436A2
		// (set) Token: 0x06001823 RID: 6179 RVA: 0x000454AA File Offset: 0x000436AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracle GameMiracleInfo
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

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x000454B3 File Offset: 0x000436B3
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x000454BB File Offset: 0x000436BB
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

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x000454C4 File Offset: 0x000436C4
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x000454CC File Offset: 0x000436CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HMGHMJLLHKC
		{
			get
			{
				return this.hMGHMJLLHKC_;
			}
			set
			{
				this.hMGHMJLLHKC_ = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x000454D5 File Offset: 0x000436D5
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x000454DD File Offset: 0x000436DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GAFCODOPAMF
		{
			get
			{
				return this.gAFCODOPAMF_;
			}
			set
			{
				this.gAFCODOPAMF_ = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x000454E6 File Offset: 0x000436E6
		// (set) Token: 0x0600182B RID: 6187 RVA: 0x000454EE File Offset: 0x000436EE
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

		// Token: 0x0600182C RID: 6188 RVA: 0x000454F7 File Offset: 0x000436F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueFinishInfo);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00045508 File Offset: 0x00043708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueFinishInfo other)
		{
			return other != null && (other == this || (this.QuitReason == other.QuitReason && this.IsFinish == other.IsFinish && this.BNMNFEKMCNM == other.BNMNFEKMCNM && object.Equals(this.OEPFGHBAJOO, other.OEPFGHBAJOO) && this.ChessRogueMainStoryId == other.ChessRogueMainStoryId && object.Equals(this.RogueLineup, other.RogueLineup) && this.hBLHPOLEDGA_.Equals(other.hBLHPOLEDGA_) && this.DifficultyLevel == other.DifficultyLevel && this.HLCDOADEIJI == other.HLCDOADEIJI && object.Equals(this.RogueBuffInfo, other.RogueBuffInfo) && this.FGGJEGFMMAO == other.FGGJEGFMMAO && object.Equals(this.RogueStoryInfo, other.RogueStoryInfo) && this.OAKCHBDNEIC == other.OAKCHBDNEIC && this.GEFPJKGJLEO == other.GEFPJKGJLEO && object.Equals(this.GameMiracleInfo, other.GameMiracleInfo) && this.ScoreId == other.ScoreId && this.HMGHMJLLHKC == other.HMGHMJLLHKC && this.GAFCODOPAMF == other.GAFCODOPAMF && this.RogueSubMode == other.RogueSubMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00045680 File Offset: 0x00043880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuitReason != ChessRogueQuitReason.ChessRogueAccountByNone)
			{
				num ^= this.QuitReason.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this.BNMNFEKMCNM != 0U)
			{
				num ^= this.BNMNFEKMCNM.GetHashCode();
			}
			if (this.oEPFGHBAJOO_ != null)
			{
				num ^= this.OEPFGHBAJOO.GetHashCode();
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				num ^= this.ChessRogueMainStoryId.GetHashCode();
			}
			if (this.rogueLineup_ != null)
			{
				num ^= this.RogueLineup.GetHashCode();
			}
			num ^= this.hBLHPOLEDGA_.GetHashCode();
			if (this.DifficultyLevel != 0U)
			{
				num ^= this.DifficultyLevel.GetHashCode();
			}
			if (this.HLCDOADEIJI != 0U)
			{
				num ^= this.HLCDOADEIJI.GetHashCode();
			}
			if (this.rogueBuffInfo_ != null)
			{
				num ^= this.RogueBuffInfo.GetHashCode();
			}
			if (this.FGGJEGFMMAO != 0U)
			{
				num ^= this.FGGJEGFMMAO.GetHashCode();
			}
			if (this.rogueStoryInfo_ != null)
			{
				num ^= this.RogueStoryInfo.GetHashCode();
			}
			if (this.OAKCHBDNEIC != 0U)
			{
				num ^= this.OAKCHBDNEIC.GetHashCode();
			}
			if (this.GEFPJKGJLEO != 0U)
			{
				num ^= this.GEFPJKGJLEO.GetHashCode();
			}
			if (this.gameMiracleInfo_ != null)
			{
				num ^= this.GameMiracleInfo.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.HMGHMJLLHKC != 0U)
			{
				num ^= this.HMGHMJLLHKC.GetHashCode();
			}
			if (this.GAFCODOPAMF != 0U)
			{
				num ^= this.GAFCODOPAMF.GetHashCode();
			}
			if (this.RogueSubMode != 0U)
			{
				num ^= this.RogueSubMode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0004586D File Offset: 0x00043A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00045875 File Offset: 0x00043A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00045880 File Offset: 0x00043A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFinish)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsFinish);
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ChessRogueMainStoryId);
			}
			if (this.DifficultyLevel != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.DifficultyLevel);
			}
			if (this.HLCDOADEIJI != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.HLCDOADEIJI);
			}
			if (this.rogueLineup_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueLineup);
			}
			if (this.OAKCHBDNEIC != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.OAKCHBDNEIC);
			}
			if (this.oEPFGHBAJOO_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.OEPFGHBAJOO);
			}
			if (this.FGGJEGFMMAO != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.FGGJEGFMMAO);
			}
			this.hBLHPOLEDGA_.WriteTo(ref output, ChessRogueFinishInfo._repeated_hBLHPOLEDGA_codec);
			if (this.QuitReason != ChessRogueQuitReason.ChessRogueAccountByNone)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.QuitReason);
			}
			if (this.GAFCODOPAMF != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.GAFCODOPAMF);
			}
			if (this.rogueBuffInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueBuffInfo);
			}
			if (this.gameMiracleInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GameMiracleInfo);
			}
			if (this.rogueStoryInfo_ != null)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.RogueStoryInfo);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(128, 12);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.BNMNFEKMCNM != 0U)
			{
				output.WriteRawTag(152, 76);
				output.WriteUInt32(this.BNMNFEKMCNM);
			}
			if (this.RogueSubMode != 0U)
			{
				output.WriteRawTag(184, 82);
				output.WriteUInt32(this.RogueSubMode);
			}
			if (this.HMGHMJLLHKC != 0U)
			{
				output.WriteRawTag(136, 87);
				output.WriteUInt32(this.HMGHMJLLHKC);
			}
			if (this.GEFPJKGJLEO != 0U)
			{
				output.WriteRawTag(208, 96);
				output.WriteUInt32(this.GEFPJKGJLEO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00045AC8 File Offset: 0x00043CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuitReason != ChessRogueQuitReason.ChessRogueAccountByNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.QuitReason);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this.BNMNFEKMCNM != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.BNMNFEKMCNM);
			}
			if (this.oEPFGHBAJOO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OEPFGHBAJOO);
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueMainStoryId);
			}
			if (this.rogueLineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueLineup);
			}
			num += this.hBLHPOLEDGA_.CalculateSize(ChessRogueFinishInfo._repeated_hBLHPOLEDGA_codec);
			if (this.DifficultyLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DifficultyLevel);
			}
			if (this.HLCDOADEIJI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HLCDOADEIJI);
			}
			if (this.rogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuffInfo);
			}
			if (this.FGGJEGFMMAO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FGGJEGFMMAO);
			}
			if (this.rogueStoryInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueStoryInfo);
			}
			if (this.OAKCHBDNEIC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OAKCHBDNEIC);
			}
			if (this.GEFPJKGJLEO != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.GEFPJKGJLEO);
			}
			if (this.gameMiracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameMiracleInfo);
			}
			if (this.ScoreId != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.HMGHMJLLHKC != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.HMGHMJLLHKC);
			}
			if (this.GAFCODOPAMF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GAFCODOPAMF);
			}
			if (this.RogueSubMode != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.RogueSubMode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00045CA8 File Offset: 0x00043EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueFinishInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuitReason != ChessRogueQuitReason.ChessRogueAccountByNone)
			{
				this.QuitReason = other.QuitReason;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			if (other.BNMNFEKMCNM != 0U)
			{
				this.BNMNFEKMCNM = other.BNMNFEKMCNM;
			}
			if (other.oEPFGHBAJOO_ != null)
			{
				if (this.oEPFGHBAJOO_ == null)
				{
					this.OEPFGHBAJOO = new ItemList();
				}
				this.OEPFGHBAJOO.MergeFrom(other.OEPFGHBAJOO);
			}
			if (other.ChessRogueMainStoryId != 0U)
			{
				this.ChessRogueMainStoryId = other.ChessRogueMainStoryId;
			}
			if (other.rogueLineup_ != null)
			{
				if (this.rogueLineup_ == null)
				{
					this.RogueLineup = new LineupInfo();
				}
				this.RogueLineup.MergeFrom(other.RogueLineup);
			}
			this.hBLHPOLEDGA_.Add(other.hBLHPOLEDGA_);
			if (other.DifficultyLevel != 0U)
			{
				this.DifficultyLevel = other.DifficultyLevel;
			}
			if (other.HLCDOADEIJI != 0U)
			{
				this.HLCDOADEIJI = other.HLCDOADEIJI;
			}
			if (other.rogueBuffInfo_ != null)
			{
				if (this.rogueBuffInfo_ == null)
				{
					this.RogueBuffInfo = new ChessRogueBuff();
				}
				this.RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
			}
			if (other.FGGJEGFMMAO != 0U)
			{
				this.FGGJEGFMMAO = other.FGGJEGFMMAO;
			}
			if (other.rogueStoryInfo_ != null)
			{
				if (this.rogueStoryInfo_ == null)
				{
					this.RogueStoryInfo = new ChessRogueStoryInfo();
				}
				this.RogueStoryInfo.MergeFrom(other.RogueStoryInfo);
			}
			if (other.OAKCHBDNEIC != 0U)
			{
				this.OAKCHBDNEIC = other.OAKCHBDNEIC;
			}
			if (other.GEFPJKGJLEO != 0U)
			{
				this.GEFPJKGJLEO = other.GEFPJKGJLEO;
			}
			if (other.gameMiracleInfo_ != null)
			{
				if (this.gameMiracleInfo_ == null)
				{
					this.GameMiracleInfo = new ChessRogueMiracle();
				}
				this.GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.HMGHMJLLHKC != 0U)
			{
				this.HMGHMJLLHKC = other.HMGHMJLLHKC;
			}
			if (other.GAFCODOPAMF != 0U)
			{
				this.GAFCODOPAMF = other.GAFCODOPAMF;
			}
			if (other.RogueSubMode != 0U)
			{
				this.RogueSubMode = other.RogueSubMode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00045EC1 File Offset: 0x000440C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00045ECC File Offset: 0x000440CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num <= 42U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.IsFinish = input.ReadBool();
								continue;
							}
							if (num == 16U)
							{
								this.ChessRogueMainStoryId = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.DifficultyLevel = input.ReadUInt32();
								continue;
							}
							if (num == 32U)
							{
								this.HLCDOADEIJI = input.ReadUInt32();
								continue;
							}
							if (num == 42U)
							{
								if (this.rogueLineup_ == null)
								{
									this.RogueLineup = new LineupInfo();
								}
								input.ReadMessage(this.RogueLineup);
								continue;
							}
						}
					}
					else if (num <= 66U)
					{
						if (num == 56U)
						{
							this.OAKCHBDNEIC = input.ReadUInt32();
							continue;
						}
						if (num == 66U)
						{
							if (this.oEPFGHBAJOO_ == null)
							{
								this.OEPFGHBAJOO = new ItemList();
							}
							input.ReadMessage(this.OEPFGHBAJOO);
							continue;
						}
					}
					else
					{
						if (num == 72U)
						{
							this.FGGJEGFMMAO = input.ReadUInt32();
							continue;
						}
						if (num == 80U || num == 82U)
						{
							this.hBLHPOLEDGA_.AddEntriesFrom(ref input, ChessRogueFinishInfo._repeated_hBLHPOLEDGA_codec);
							continue;
						}
					}
				}
				else if (num <= 370U)
				{
					if (num <= 96U)
					{
						if (num == 88U)
						{
							this.QuitReason = (ChessRogueQuitReason)input.ReadEnum();
							continue;
						}
						if (num == 96U)
						{
							this.GAFCODOPAMF = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 106U)
						{
							if (this.rogueBuffInfo_ == null)
							{
								this.RogueBuffInfo = new ChessRogueBuff();
							}
							input.ReadMessage(this.RogueBuffInfo);
							continue;
						}
						if (num == 122U)
						{
							if (this.gameMiracleInfo_ == null)
							{
								this.GameMiracleInfo = new ChessRogueMiracle();
							}
							input.ReadMessage(this.GameMiracleInfo);
							continue;
						}
						if (num == 370U)
						{
							if (this.rogueStoryInfo_ == null)
							{
								this.RogueStoryInfo = new ChessRogueStoryInfo();
							}
							input.ReadMessage(this.RogueStoryInfo);
							continue;
						}
					}
				}
				else if (num <= 9752U)
				{
					if (num == 1536U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
					if (num == 9752U)
					{
						this.BNMNFEKMCNM = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 10552U)
					{
						this.RogueSubMode = input.ReadUInt32();
						continue;
					}
					if (num == 11144U)
					{
						this.HMGHMJLLHKC = input.ReadUInt32();
						continue;
					}
					if (num == 12368U)
					{
						this.GEFPJKGJLEO = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A29 RID: 2601
		private static readonly MessageParser<ChessRogueFinishInfo> _parser = new MessageParser<ChessRogueFinishInfo>(() => new ChessRogueFinishInfo());

		// Token: 0x04000A2A RID: 2602
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A2B RID: 2603
		public const int QuitReasonFieldNumber = 11;

		// Token: 0x04000A2C RID: 2604
		private ChessRogueQuitReason quitReason_;

		// Token: 0x04000A2D RID: 2605
		public const int IsFinishFieldNumber = 1;

		// Token: 0x04000A2E RID: 2606
		private bool isFinish_;

		// Token: 0x04000A2F RID: 2607
		public const int BNMNFEKMCNMFieldNumber = 1219;

		// Token: 0x04000A30 RID: 2608
		private uint bNMNFEKMCNM_;

		// Token: 0x04000A31 RID: 2609
		public const int OEPFGHBAJOOFieldNumber = 8;

		// Token: 0x04000A32 RID: 2610
		private ItemList oEPFGHBAJOO_;

		// Token: 0x04000A33 RID: 2611
		public const int ChessRogueMainStoryIdFieldNumber = 2;

		// Token: 0x04000A34 RID: 2612
		private uint chessRogueMainStoryId_;

		// Token: 0x04000A35 RID: 2613
		public const int RogueLineupFieldNumber = 5;

		// Token: 0x04000A36 RID: 2614
		private LineupInfo rogueLineup_;

		// Token: 0x04000A37 RID: 2615
		public const int HBLHPOLEDGAFieldNumber = 10;

		// Token: 0x04000A38 RID: 2616
		private static readonly FieldCodec<uint> _repeated_hBLHPOLEDGA_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04000A39 RID: 2617
		private readonly RepeatedField<uint> hBLHPOLEDGA_ = new RepeatedField<uint>();

		// Token: 0x04000A3A RID: 2618
		public const int DifficultyLevelFieldNumber = 3;

		// Token: 0x04000A3B RID: 2619
		private uint difficultyLevel_;

		// Token: 0x04000A3C RID: 2620
		public const int HLCDOADEIJIFieldNumber = 4;

		// Token: 0x04000A3D RID: 2621
		private uint hLCDOADEIJI_;

		// Token: 0x04000A3E RID: 2622
		public const int RogueBuffInfoFieldNumber = 13;

		// Token: 0x04000A3F RID: 2623
		private ChessRogueBuff rogueBuffInfo_;

		// Token: 0x04000A40 RID: 2624
		public const int FGGJEGFMMAOFieldNumber = 9;

		// Token: 0x04000A41 RID: 2625
		private uint fGGJEGFMMAO_;

		// Token: 0x04000A42 RID: 2626
		public const int RogueStoryInfoFieldNumber = 46;

		// Token: 0x04000A43 RID: 2627
		private ChessRogueStoryInfo rogueStoryInfo_;

		// Token: 0x04000A44 RID: 2628
		public const int OAKCHBDNEICFieldNumber = 7;

		// Token: 0x04000A45 RID: 2629
		private uint oAKCHBDNEIC_;

		// Token: 0x04000A46 RID: 2630
		public const int GEFPJKGJLEOFieldNumber = 1546;

		// Token: 0x04000A47 RID: 2631
		private uint gEFPJKGJLEO_;

		// Token: 0x04000A48 RID: 2632
		public const int GameMiracleInfoFieldNumber = 15;

		// Token: 0x04000A49 RID: 2633
		private ChessRogueMiracle gameMiracleInfo_;

		// Token: 0x04000A4A RID: 2634
		public const int ScoreIdFieldNumber = 192;

		// Token: 0x04000A4B RID: 2635
		private uint scoreId_;

		// Token: 0x04000A4C RID: 2636
		public const int HMGHMJLLHKCFieldNumber = 1393;

		// Token: 0x04000A4D RID: 2637
		private uint hMGHMJLLHKC_;

		// Token: 0x04000A4E RID: 2638
		public const int GAFCODOPAMFFieldNumber = 12;

		// Token: 0x04000A4F RID: 2639
		private uint gAFCODOPAMF_;

		// Token: 0x04000A50 RID: 2640
		public const int RogueSubModeFieldNumber = 1319;

		// Token: 0x04000A51 RID: 2641
		private uint rogueSubMode_;
	}
}
