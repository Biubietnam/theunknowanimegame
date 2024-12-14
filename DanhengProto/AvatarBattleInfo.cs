using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000BD RID: 189
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AvatarBattleInfo : IMessage<AvatarBattleInfo>, IMessage, IEquatable<AvatarBattleInfo>, IDeepCloneable<AvatarBattleInfo>, IBufferMessage
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00017702 File Offset: 0x00015902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AvatarBattleInfo> Parser
		{
			get
			{
				return AvatarBattleInfo._parser;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00017709 File Offset: 0x00015909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarBattleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x0001771B File Offset: 0x0001591B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarBattleInfo.Descriptor;
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00017724 File Offset: 0x00015924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarBattleInfo()
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000177A8 File Offset: 0x000159A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarBattleInfo(AvatarBattleInfo other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.id_ = other.id_;
			this.avatarLevel_ = other.avatarLevel_;
			this.avatarRank_ = other.avatarRank_;
			this.avatarPromotion_ = other.avatarPromotion_;
			this.avatarStatus_ = ((other.avatarStatus_ != null) ? other.avatarStatus_.Clone() : null);
			this.avatarSkill_ = other.avatarSkill_.Clone();
			this.avatarEquipment_ = other.avatarEquipment_.Clone();
			this.totalTurns_ = other.totalTurns_;
			this.totalDamage_ = other.totalDamage_;
			this.totalHeal_ = other.totalHeal_;
			this.totalDamageTaken_ = other.totalDamageTaken_;
			this.totalHpRecover_ = other.totalHpRecover_;
			this.totalSpCost_ = other.totalSpCost_;
			this.stageId_ = other.stageId_;
			this.stageType_ = other.stageType_;
			this.totalBreakDamage_ = other.totalBreakDamage_;
			this.attackTypeDamage_ = other.attackTypeDamage_.Clone();
			this.attackTypeBreakDamage_ = other.attackTypeBreakDamage_.Clone();
			this.attackTypeMaxDamage_ = other.attackTypeMaxDamage_.Clone();
			this.skillTimes_ = other.skillTimes_.Clone();
			this.delayCumulate_ = other.delayCumulate_;
			this.totalSpAdd_ = other.totalSpAdd_;
			this.spAddSource_ = other.spAddSource_.Clone();
			this.totalBpCost_ = other.totalBpCost_;
			this.dieTimes_ = other.dieTimes_;
			this.reviveTimes_ = other.reviveTimes_;
			this.breakTimes_ = other.breakTimes_;
			this.extraTurns_ = other.extraTurns_;
			this.totalShield_ = other.totalShield_;
			this.totalShieldTaken_ = other.totalShieldTaken_;
			this.totalShieldDamage_ = other.totalShieldDamage_;
			this.initialStatus_ = ((other.initialStatus_ != null) ? other.initialStatus_.Clone() : null);
			this.relics_ = other.relics_.Clone();
			this.assistUid_ = other.assistUid_;
			this.eLJGKKANLDI_ = other.eLJGKKANLDI_.Clone();
			this.cALNPMADJBG_ = other.cALNPMADJBG_;
			this.nBNJMLLGFIL_ = other.nBNJMLLGFIL_;
			this.oLADIJEDBPJ_ = other.oLADIJEDBPJ_;
			this.hHJFDGDHLOP_ = other.hHJFDGDHLOP_;
			this.pPAPOLPPKBH_ = other.pPAPOLPPKBH_.Clone();
			this.pADBNMLAGMM_ = other.pADBNMLAGMM_;
			this.kDFLCJLALEH_ = other.kDFLCJLALEH_;
			this.nIHFBGGIKIM_ = other.nIHFBGGIKIM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00017A2E File Offset: 0x00015C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarBattleInfo Clone()
		{
			return new AvatarBattleInfo(this);
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00017A36 File Offset: 0x00015C36
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00017A3E File Offset: 0x00015C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00017A47 File Offset: 0x00015C47
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00017A4F File Offset: 0x00015C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00017A58 File Offset: 0x00015C58
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x00017A60 File Offset: 0x00015C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarLevel
		{
			get
			{
				return this.avatarLevel_;
			}
			set
			{
				this.avatarLevel_ = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00017A69 File Offset: 0x00015C69
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x00017A71 File Offset: 0x00015C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarRank
		{
			get
			{
				return this.avatarRank_;
			}
			set
			{
				this.avatarRank_ = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00017A7A File Offset: 0x00015C7A
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x00017A82 File Offset: 0x00015C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarPromotion
		{
			get
			{
				return this.avatarPromotion_;
			}
			set
			{
				this.avatarPromotion_ = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00017A8B File Offset: 0x00015C8B
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00017A93 File Offset: 0x00015C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarProperty AvatarStatus
		{
			get
			{
				return this.avatarStatus_;
			}
			set
			{
				this.avatarStatus_ = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00017A9C File Offset: 0x00015C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AvatarSkillTree> AvatarSkill
		{
			get
			{
				return this.avatarSkill_;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00017AA4 File Offset: 0x00015CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EquipmentProperty> AvatarEquipment
		{
			get
			{
				return this.avatarEquipment_;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00017AAC File Offset: 0x00015CAC
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00017AB4 File Offset: 0x00015CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TotalTurns
		{
			get
			{
				return this.totalTurns_;
			}
			set
			{
				this.totalTurns_ = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00017ABD File Offset: 0x00015CBD
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x00017AC5 File Offset: 0x00015CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalDamage
		{
			get
			{
				return this.totalDamage_;
			}
			set
			{
				this.totalDamage_ = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00017ACE File Offset: 0x00015CCE
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x00017AD6 File Offset: 0x00015CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalHeal
		{
			get
			{
				return this.totalHeal_;
			}
			set
			{
				this.totalHeal_ = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00017ADF File Offset: 0x00015CDF
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x00017AE7 File Offset: 0x00015CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalDamageTaken
		{
			get
			{
				return this.totalDamageTaken_;
			}
			set
			{
				this.totalDamageTaken_ = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00017AF0 File Offset: 0x00015CF0
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x00017AF8 File Offset: 0x00015CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalHpRecover
		{
			get
			{
				return this.totalHpRecover_;
			}
			set
			{
				this.totalHpRecover_ = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00017B01 File Offset: 0x00015D01
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00017B09 File Offset: 0x00015D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalSpCost
		{
			get
			{
				return this.totalSpCost_;
			}
			set
			{
				this.totalSpCost_ = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00017B12 File Offset: 0x00015D12
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00017B1A File Offset: 0x00015D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00017B23 File Offset: 0x00015D23
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x00017B2B File Offset: 0x00015D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageType
		{
			get
			{
				return this.stageType_;
			}
			set
			{
				this.stageType_ = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00017B34 File Offset: 0x00015D34
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x00017B3C File Offset: 0x00015D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalBreakDamage
		{
			get
			{
				return this.totalBreakDamage_;
			}
			set
			{
				this.totalBreakDamage_ = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00017B45 File Offset: 0x00015D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AttackDamageProperty> AttackTypeDamage
		{
			get
			{
				return this.attackTypeDamage_;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00017B4D File Offset: 0x00015D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AttackDamageProperty> AttackTypeBreakDamage
		{
			get
			{
				return this.attackTypeBreakDamage_;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00017B55 File Offset: 0x00015D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AttackDamageProperty> AttackTypeMaxDamage
		{
			get
			{
				return this.attackTypeMaxDamage_;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00017B5D File Offset: 0x00015D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillUseProperty> SkillTimes
		{
			get
			{
				return this.skillTimes_;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00017B65 File Offset: 0x00015D65
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x00017B6D File Offset: 0x00015D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double DelayCumulate
		{
			get
			{
				return this.delayCumulate_;
			}
			set
			{
				this.delayCumulate_ = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00017B76 File Offset: 0x00015D76
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00017B7E File Offset: 0x00015D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TotalSpAdd
		{
			get
			{
				return this.totalSpAdd_;
			}
			set
			{
				this.totalSpAdd_ = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00017B87 File Offset: 0x00015D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpAddSource> SpAddSource
		{
			get
			{
				return this.spAddSource_;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00017B8F File Offset: 0x00015D8F
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00017B97 File Offset: 0x00015D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TotalBpCost
		{
			get
			{
				return this.totalBpCost_;
			}
			set
			{
				this.totalBpCost_ = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00017BA0 File Offset: 0x00015DA0
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00017BA8 File Offset: 0x00015DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DieTimes
		{
			get
			{
				return this.dieTimes_;
			}
			set
			{
				this.dieTimes_ = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00017BB1 File Offset: 0x00015DB1
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00017BB9 File Offset: 0x00015DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ReviveTimes
		{
			get
			{
				return this.reviveTimes_;
			}
			set
			{
				this.reviveTimes_ = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00017BC2 File Offset: 0x00015DC2
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00017BCA File Offset: 0x00015DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BreakTimes
		{
			get
			{
				return this.breakTimes_;
			}
			set
			{
				this.breakTimes_ = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00017BD3 File Offset: 0x00015DD3
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00017BDB File Offset: 0x00015DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ExtraTurns
		{
			get
			{
				return this.extraTurns_;
			}
			set
			{
				this.extraTurns_ = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00017BE4 File Offset: 0x00015DE4
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00017BEC File Offset: 0x00015DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalShield
		{
			get
			{
				return this.totalShield_;
			}
			set
			{
				this.totalShield_ = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00017BF5 File Offset: 0x00015DF5
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00017BFD File Offset: 0x00015DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalShieldTaken
		{
			get
			{
				return this.totalShieldTaken_;
			}
			set
			{
				this.totalShieldTaken_ = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00017C06 File Offset: 0x00015E06
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00017C0E File Offset: 0x00015E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalShieldDamage
		{
			get
			{
				return this.totalShieldDamage_;
			}
			set
			{
				this.totalShieldDamage_ = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00017C17 File Offset: 0x00015E17
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x00017C1F File Offset: 0x00015E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarProperty InitialStatus
		{
			get
			{
				return this.initialStatus_;
			}
			set
			{
				this.initialStatus_ = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00017C28 File Offset: 0x00015E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleRelic> Relics
		{
			get
			{
				return this.relics_;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00017C30 File Offset: 0x00015E30
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00017C38 File Offset: 0x00015E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AssistUid
		{
			get
			{
				return this.assistUid_;
			}
			set
			{
				this.assistUid_ = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00017C41 File Offset: 0x00015E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AttackDamageProperty> ELJGKKANLDI
		{
			get
			{
				return this.eLJGKKANLDI_;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00017C49 File Offset: 0x00015E49
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00017C51 File Offset: 0x00015E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double CALNPMADJBG
		{
			get
			{
				return this.cALNPMADJBG_;
			}
			set
			{
				this.cALNPMADJBG_ = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00017C5A File Offset: 0x00015E5A
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00017C62 File Offset: 0x00015E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double NBNJMLLGFIL
		{
			get
			{
				return this.nBNJMLLGFIL_;
			}
			set
			{
				this.nBNJMLLGFIL_ = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00017C6B File Offset: 0x00015E6B
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00017C73 File Offset: 0x00015E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double OLADIJEDBPJ
		{
			get
			{
				return this.oLADIJEDBPJ_;
			}
			set
			{
				this.oLADIJEDBPJ_ = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00017C7C File Offset: 0x00015E7C
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00017C84 File Offset: 0x00015E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double HHJFDGDHLOP
		{
			get
			{
				return this.hHJFDGDHLOP_;
			}
			set
			{
				this.hHJFDGDHLOP_ = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00017C8D File Offset: 0x00015E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbilityUseStt> PPAPOLPPKBH
		{
			get
			{
				return this.pPAPOLPPKBH_;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x00017C95 File Offset: 0x00015E95
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x00017C9D File Offset: 0x00015E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PADBNMLAGMM
		{
			get
			{
				return this.pADBNMLAGMM_;
			}
			set
			{
				this.pADBNMLAGMM_ = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x00017CA6 File Offset: 0x00015EA6
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x00017CAE File Offset: 0x00015EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KDFLCJLALEH
		{
			get
			{
				return this.kDFLCJLALEH_;
			}
			set
			{
				this.kDFLCJLALEH_ = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x00017CB7 File Offset: 0x00015EB7
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x00017CBF File Offset: 0x00015EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double NIHFBGGIKIM
		{
			get
			{
				return this.nIHFBGGIKIM_;
			}
			set
			{
				this.nIHFBGGIKIM_ = value;
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00017CC8 File Offset: 0x00015EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarBattleInfo);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00017CD8 File Offset: 0x00015ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarBattleInfo other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.Id == other.Id && this.AvatarLevel == other.AvatarLevel && this.AvatarRank == other.AvatarRank && this.AvatarPromotion == other.AvatarPromotion && object.Equals(this.AvatarStatus, other.AvatarStatus) && this.avatarSkill_.Equals(other.avatarSkill_) && this.avatarEquipment_.Equals(other.avatarEquipment_) && this.TotalTurns == other.TotalTurns && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalDamage, other.TotalDamage) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalHeal, other.TotalHeal) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalDamageTaken, other.TotalDamageTaken) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalHpRecover, other.TotalHpRecover) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalSpCost, other.TotalSpCost) && this.StageId == other.StageId && this.StageType == other.StageType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalBreakDamage, other.TotalBreakDamage) && this.attackTypeDamage_.Equals(other.attackTypeDamage_) && this.attackTypeBreakDamage_.Equals(other.attackTypeBreakDamage_) && this.attackTypeMaxDamage_.Equals(other.attackTypeMaxDamage_) && this.skillTimes_.Equals(other.skillTimes_) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.DelayCumulate, other.DelayCumulate) && this.TotalSpAdd == other.TotalSpAdd && this.spAddSource_.Equals(other.spAddSource_) && this.TotalBpCost == other.TotalBpCost && this.DieTimes == other.DieTimes && this.ReviveTimes == other.ReviveTimes && this.BreakTimes == other.BreakTimes && this.ExtraTurns == other.ExtraTurns && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalShield, other.TotalShield) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalShieldTaken, other.TotalShieldTaken) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalShieldDamage, other.TotalShieldDamage) && object.Equals(this.InitialStatus, other.InitialStatus) && this.relics_.Equals(other.relics_) && this.AssistUid == other.AssistUid && this.eLJGKKANLDI_.Equals(other.eLJGKKANLDI_) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.CALNPMADJBG, other.CALNPMADJBG) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.NBNJMLLGFIL, other.NBNJMLLGFIL) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.OLADIJEDBPJ, other.OLADIJEDBPJ) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.HHJFDGDHLOP, other.HHJFDGDHLOP) && this.pPAPOLPPKBH_.Equals(other.pPAPOLPPKBH_) && this.PADBNMLAGMM == other.PADBNMLAGMM && this.KDFLCJLALEH == other.KDFLCJLALEH && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.NIHFBGGIKIM, other.NIHFBGGIKIM) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00018094 File Offset: 0x00016294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.AvatarLevel != 0U)
			{
				num ^= this.AvatarLevel.GetHashCode();
			}
			if (this.AvatarRank != 0U)
			{
				num ^= this.AvatarRank.GetHashCode();
			}
			if (this.AvatarPromotion != 0U)
			{
				num ^= this.AvatarPromotion.GetHashCode();
			}
			if (this.avatarStatus_ != null)
			{
				num ^= this.AvatarStatus.GetHashCode();
			}
			num ^= this.avatarSkill_.GetHashCode();
			num ^= this.avatarEquipment_.GetHashCode();
			if (this.TotalTurns != 0U)
			{
				num ^= this.TotalTurns.GetHashCode();
			}
			if (this.TotalDamage != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalDamage);
			}
			if (this.TotalHeal != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalHeal);
			}
			if (this.TotalDamageTaken != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalDamageTaken);
			}
			if (this.TotalHpRecover != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalHpRecover);
			}
			if (this.TotalSpCost != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalSpCost);
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.StageType != 0U)
			{
				num ^= this.StageType.GetHashCode();
			}
			if (this.TotalBreakDamage != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalBreakDamage);
			}
			num ^= this.attackTypeDamage_.GetHashCode();
			num ^= this.attackTypeBreakDamage_.GetHashCode();
			num ^= this.attackTypeMaxDamage_.GetHashCode();
			num ^= this.skillTimes_.GetHashCode();
			if (this.DelayCumulate != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.DelayCumulate);
			}
			if (this.TotalSpAdd != 0U)
			{
				num ^= this.TotalSpAdd.GetHashCode();
			}
			num ^= this.spAddSource_.GetHashCode();
			if (this.TotalBpCost != 0U)
			{
				num ^= this.TotalBpCost.GetHashCode();
			}
			if (this.DieTimes != 0U)
			{
				num ^= this.DieTimes.GetHashCode();
			}
			if (this.ReviveTimes != 0U)
			{
				num ^= this.ReviveTimes.GetHashCode();
			}
			if (this.BreakTimes != 0U)
			{
				num ^= this.BreakTimes.GetHashCode();
			}
			if (this.ExtraTurns != 0U)
			{
				num ^= this.ExtraTurns.GetHashCode();
			}
			if (this.TotalShield != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalShield);
			}
			if (this.TotalShieldTaken != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalShieldTaken);
			}
			if (this.TotalShieldDamage != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalShieldDamage);
			}
			if (this.initialStatus_ != null)
			{
				num ^= this.InitialStatus.GetHashCode();
			}
			num ^= this.relics_.GetHashCode();
			if (this.AssistUid != 0U)
			{
				num ^= this.AssistUid.GetHashCode();
			}
			num ^= this.eLJGKKANLDI_.GetHashCode();
			if (this.CALNPMADJBG != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.CALNPMADJBG);
			}
			if (this.NBNJMLLGFIL != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.NBNJMLLGFIL);
			}
			if (this.OLADIJEDBPJ != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.OLADIJEDBPJ);
			}
			if (this.HHJFDGDHLOP != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.HHJFDGDHLOP);
			}
			num ^= this.pPAPOLPPKBH_.GetHashCode();
			if (this.PADBNMLAGMM != 0U)
			{
				num ^= this.PADBNMLAGMM.GetHashCode();
			}
			if (this.KDFLCJLALEH != 0U)
			{
				num ^= this.KDFLCJLALEH.GetHashCode();
			}
			if (this.NIHFBGGIKIM != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.NIHFBGGIKIM);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0001853D File Offset: 0x0001673D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00018545 File Offset: 0x00016745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00018550 File Offset: 0x00016750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Id);
			}
			if (this.AvatarLevel != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AvatarLevel);
			}
			if (this.AvatarRank != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AvatarRank);
			}
			if (this.AvatarPromotion != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AvatarPromotion);
			}
			if (this.avatarStatus_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.AvatarStatus);
			}
			this.avatarSkill_.WriteTo(ref output, AvatarBattleInfo._repeated_avatarSkill_codec);
			this.avatarEquipment_.WriteTo(ref output, AvatarBattleInfo._repeated_avatarEquipment_codec);
			if (this.TotalTurns != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.TotalTurns);
			}
			if (this.TotalDamage != 0.0)
			{
				output.WriteRawTag(81);
				output.WriteDouble(this.TotalDamage);
			}
			if (this.TotalHeal != 0.0)
			{
				output.WriteRawTag(89);
				output.WriteDouble(this.TotalHeal);
			}
			if (this.TotalDamageTaken != 0.0)
			{
				output.WriteRawTag(97);
				output.WriteDouble(this.TotalDamageTaken);
			}
			if (this.TotalHpRecover != 0.0)
			{
				output.WriteRawTag(105);
				output.WriteDouble(this.TotalHpRecover);
			}
			if (this.TotalSpCost != 0.0)
			{
				output.WriteRawTag(113);
				output.WriteDouble(this.TotalSpCost);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.StageId);
			}
			if (this.StageType != 0U)
			{
				output.WriteRawTag(128, 1);
				output.WriteUInt32(this.StageType);
			}
			if (this.TotalBreakDamage != 0.0)
			{
				output.WriteRawTag(137, 1);
				output.WriteDouble(this.TotalBreakDamage);
			}
			this.attackTypeDamage_.WriteTo(ref output, AvatarBattleInfo._repeated_attackTypeDamage_codec);
			this.attackTypeBreakDamage_.WriteTo(ref output, AvatarBattleInfo._repeated_attackTypeBreakDamage_codec);
			this.attackTypeMaxDamage_.WriteTo(ref output, AvatarBattleInfo._repeated_attackTypeMaxDamage_codec);
			this.skillTimes_.WriteTo(ref output, AvatarBattleInfo._repeated_skillTimes_codec);
			if (this.DelayCumulate != 0.0)
			{
				output.WriteRawTag(177, 1);
				output.WriteDouble(this.DelayCumulate);
			}
			if (this.TotalSpAdd != 0U)
			{
				output.WriteRawTag(184, 1);
				output.WriteUInt32(this.TotalSpAdd);
			}
			this.spAddSource_.WriteTo(ref output, AvatarBattleInfo._repeated_spAddSource_codec);
			if (this.TotalBpCost != 0U)
			{
				output.WriteRawTag(200, 1);
				output.WriteUInt32(this.TotalBpCost);
			}
			if (this.DieTimes != 0U)
			{
				output.WriteRawTag(208, 1);
				output.WriteUInt32(this.DieTimes);
			}
			if (this.ReviveTimes != 0U)
			{
				output.WriteRawTag(216, 1);
				output.WriteUInt32(this.ReviveTimes);
			}
			if (this.BreakTimes != 0U)
			{
				output.WriteRawTag(224, 1);
				output.WriteUInt32(this.BreakTimes);
			}
			if (this.ExtraTurns != 0U)
			{
				output.WriteRawTag(232, 1);
				output.WriteUInt32(this.ExtraTurns);
			}
			if (this.TotalShield != 0.0)
			{
				output.WriteRawTag(241, 1);
				output.WriteDouble(this.TotalShield);
			}
			if (this.TotalShieldTaken != 0.0)
			{
				output.WriteRawTag(249, 1);
				output.WriteDouble(this.TotalShieldTaken);
			}
			if (this.TotalShieldDamage != 0.0)
			{
				output.WriteRawTag(129, 2);
				output.WriteDouble(this.TotalShieldDamage);
			}
			if (this.initialStatus_ != null)
			{
				output.WriteRawTag(138, 2);
				output.WriteMessage(this.InitialStatus);
			}
			this.relics_.WriteTo(ref output, AvatarBattleInfo._repeated_relics_codec);
			if (this.AssistUid != 0U)
			{
				output.WriteRawTag(152, 2);
				output.WriteUInt32(this.AssistUid);
			}
			this.eLJGKKANLDI_.WriteTo(ref output, AvatarBattleInfo._repeated_eLJGKKANLDI_codec);
			if (this.CALNPMADJBG != 0.0)
			{
				output.WriteRawTag(169, 2);
				output.WriteDouble(this.CALNPMADJBG);
			}
			if (this.NBNJMLLGFIL != 0.0)
			{
				output.WriteRawTag(177, 2);
				output.WriteDouble(this.NBNJMLLGFIL);
			}
			if (this.OLADIJEDBPJ != 0.0)
			{
				output.WriteRawTag(185, 2);
				output.WriteDouble(this.OLADIJEDBPJ);
			}
			if (this.HHJFDGDHLOP != 0.0)
			{
				output.WriteRawTag(193, 2);
				output.WriteDouble(this.HHJFDGDHLOP);
			}
			this.pPAPOLPPKBH_.WriteTo(ref output, AvatarBattleInfo._repeated_pPAPOLPPKBH_codec);
			if (this.PADBNMLAGMM != 0U)
			{
				output.WriteRawTag(208, 2);
				output.WriteUInt32(this.PADBNMLAGMM);
			}
			if (this.KDFLCJLALEH != 0U)
			{
				output.WriteRawTag(216, 2);
				output.WriteUInt32(this.KDFLCJLALEH);
			}
			if (this.NIHFBGGIKIM != 0.0)
			{
				output.WriteRawTag(225, 2);
				output.WriteDouble(this.NIHFBGGIKIM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00018AB0 File Offset: 0x00016CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.AvatarLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarLevel);
			}
			if (this.AvatarRank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarRank);
			}
			if (this.AvatarPromotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarPromotion);
			}
			if (this.avatarStatus_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AvatarStatus);
			}
			num += this.avatarSkill_.CalculateSize(AvatarBattleInfo._repeated_avatarSkill_codec);
			num += this.avatarEquipment_.CalculateSize(AvatarBattleInfo._repeated_avatarEquipment_codec);
			if (this.TotalTurns != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TotalTurns);
			}
			if (this.TotalDamage != 0.0)
			{
				num += 9;
			}
			if (this.TotalHeal != 0.0)
			{
				num += 9;
			}
			if (this.TotalDamageTaken != 0.0)
			{
				num += 9;
			}
			if (this.TotalHpRecover != 0.0)
			{
				num += 9;
			}
			if (this.TotalSpCost != 0.0)
			{
				num += 9;
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.StageType != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.StageType);
			}
			if (this.TotalBreakDamage != 0.0)
			{
				num += 10;
			}
			num += this.attackTypeDamage_.CalculateSize(AvatarBattleInfo._repeated_attackTypeDamage_codec);
			num += this.attackTypeBreakDamage_.CalculateSize(AvatarBattleInfo._repeated_attackTypeBreakDamage_codec);
			num += this.attackTypeMaxDamage_.CalculateSize(AvatarBattleInfo._repeated_attackTypeMaxDamage_codec);
			num += this.skillTimes_.CalculateSize(AvatarBattleInfo._repeated_skillTimes_codec);
			if (this.DelayCumulate != 0.0)
			{
				num += 10;
			}
			if (this.TotalSpAdd != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.TotalSpAdd);
			}
			num += this.spAddSource_.CalculateSize(AvatarBattleInfo._repeated_spAddSource_codec);
			if (this.TotalBpCost != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.TotalBpCost);
			}
			if (this.DieTimes != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.DieTimes);
			}
			if (this.ReviveTimes != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ReviveTimes);
			}
			if (this.BreakTimes != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.BreakTimes);
			}
			if (this.ExtraTurns != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ExtraTurns);
			}
			if (this.TotalShield != 0.0)
			{
				num += 10;
			}
			if (this.TotalShieldTaken != 0.0)
			{
				num += 10;
			}
			if (this.TotalShieldDamage != 0.0)
			{
				num += 10;
			}
			if (this.initialStatus_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.InitialStatus);
			}
			num += this.relics_.CalculateSize(AvatarBattleInfo._repeated_relics_codec);
			if (this.AssistUid != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.AssistUid);
			}
			num += this.eLJGKKANLDI_.CalculateSize(AvatarBattleInfo._repeated_eLJGKKANLDI_codec);
			if (this.CALNPMADJBG != 0.0)
			{
				num += 10;
			}
			if (this.NBNJMLLGFIL != 0.0)
			{
				num += 10;
			}
			if (this.OLADIJEDBPJ != 0.0)
			{
				num += 10;
			}
			if (this.HHJFDGDHLOP != 0.0)
			{
				num += 10;
			}
			num += this.pPAPOLPPKBH_.CalculateSize(AvatarBattleInfo._repeated_pPAPOLPPKBH_codec);
			if (this.PADBNMLAGMM != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.PADBNMLAGMM);
			}
			if (this.KDFLCJLALEH != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.KDFLCJLALEH);
			}
			if (this.NIHFBGGIKIM != 0.0)
			{
				num += 10;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00018EA8 File Offset: 0x000170A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvatarBattleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.AvatarLevel != 0U)
			{
				this.AvatarLevel = other.AvatarLevel;
			}
			if (other.AvatarRank != 0U)
			{
				this.AvatarRank = other.AvatarRank;
			}
			if (other.AvatarPromotion != 0U)
			{
				this.AvatarPromotion = other.AvatarPromotion;
			}
			if (other.avatarStatus_ != null)
			{
				if (this.avatarStatus_ == null)
				{
					this.AvatarStatus = new AvatarProperty();
				}
				this.AvatarStatus.MergeFrom(other.AvatarStatus);
			}
			this.avatarSkill_.Add(other.avatarSkill_);
			this.avatarEquipment_.Add(other.avatarEquipment_);
			if (other.TotalTurns != 0U)
			{
				this.TotalTurns = other.TotalTurns;
			}
			if (other.TotalDamage != 0.0)
			{
				this.TotalDamage = other.TotalDamage;
			}
			if (other.TotalHeal != 0.0)
			{
				this.TotalHeal = other.TotalHeal;
			}
			if (other.TotalDamageTaken != 0.0)
			{
				this.TotalDamageTaken = other.TotalDamageTaken;
			}
			if (other.TotalHpRecover != 0.0)
			{
				this.TotalHpRecover = other.TotalHpRecover;
			}
			if (other.TotalSpCost != 0.0)
			{
				this.TotalSpCost = other.TotalSpCost;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.StageType != 0U)
			{
				this.StageType = other.StageType;
			}
			if (other.TotalBreakDamage != 0.0)
			{
				this.TotalBreakDamage = other.TotalBreakDamage;
			}
			this.attackTypeDamage_.Add(other.attackTypeDamage_);
			this.attackTypeBreakDamage_.Add(other.attackTypeBreakDamage_);
			this.attackTypeMaxDamage_.Add(other.attackTypeMaxDamage_);
			this.skillTimes_.Add(other.skillTimes_);
			if (other.DelayCumulate != 0.0)
			{
				this.DelayCumulate = other.DelayCumulate;
			}
			if (other.TotalSpAdd != 0U)
			{
				this.TotalSpAdd = other.TotalSpAdd;
			}
			this.spAddSource_.Add(other.spAddSource_);
			if (other.TotalBpCost != 0U)
			{
				this.TotalBpCost = other.TotalBpCost;
			}
			if (other.DieTimes != 0U)
			{
				this.DieTimes = other.DieTimes;
			}
			if (other.ReviveTimes != 0U)
			{
				this.ReviveTimes = other.ReviveTimes;
			}
			if (other.BreakTimes != 0U)
			{
				this.BreakTimes = other.BreakTimes;
			}
			if (other.ExtraTurns != 0U)
			{
				this.ExtraTurns = other.ExtraTurns;
			}
			if (other.TotalShield != 0.0)
			{
				this.TotalShield = other.TotalShield;
			}
			if (other.TotalShieldTaken != 0.0)
			{
				this.TotalShieldTaken = other.TotalShieldTaken;
			}
			if (other.TotalShieldDamage != 0.0)
			{
				this.TotalShieldDamage = other.TotalShieldDamage;
			}
			if (other.initialStatus_ != null)
			{
				if (this.initialStatus_ == null)
				{
					this.InitialStatus = new AvatarProperty();
				}
				this.InitialStatus.MergeFrom(other.InitialStatus);
			}
			this.relics_.Add(other.relics_);
			if (other.AssistUid != 0U)
			{
				this.AssistUid = other.AssistUid;
			}
			this.eLJGKKANLDI_.Add(other.eLJGKKANLDI_);
			if (other.CALNPMADJBG != 0.0)
			{
				this.CALNPMADJBG = other.CALNPMADJBG;
			}
			if (other.NBNJMLLGFIL != 0.0)
			{
				this.NBNJMLLGFIL = other.NBNJMLLGFIL;
			}
			if (other.OLADIJEDBPJ != 0.0)
			{
				this.OLADIJEDBPJ = other.OLADIJEDBPJ;
			}
			if (other.HHJFDGDHLOP != 0.0)
			{
				this.HHJFDGDHLOP = other.HHJFDGDHLOP;
			}
			this.pPAPOLPPKBH_.Add(other.pPAPOLPPKBH_);
			if (other.PADBNMLAGMM != 0U)
			{
				this.PADBNMLAGMM = other.PADBNMLAGMM;
			}
			if (other.KDFLCJLALEH != 0U)
			{
				this.KDFLCJLALEH = other.KDFLCJLALEH;
			}
			if (other.NIHFBGGIKIM != 0.0)
			{
				this.NIHFBGGIKIM = other.NIHFBGGIKIM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000192D9 File Offset: 0x000174D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000192E4 File Offset: 0x000174E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 177U)
				{
					if (num <= 89U)
					{
						if (num <= 40U)
						{
							if (num <= 16U)
							{
								if (num == 8U)
								{
									this.AvatarType = (AvatarType)input.ReadEnum();
									continue;
								}
								if (num == 16U)
								{
									this.Id = input.ReadUInt32();
									continue;
								}
							}
							else
							{
								if (num == 24U)
								{
									this.AvatarLevel = input.ReadUInt32();
									continue;
								}
								if (num == 32U)
								{
									this.AvatarRank = input.ReadUInt32();
									continue;
								}
								if (num == 40U)
								{
									this.AvatarPromotion = input.ReadUInt32();
									continue;
								}
							}
						}
						else if (num <= 66U)
						{
							if (num == 50U)
							{
								if (this.avatarStatus_ == null)
								{
									this.AvatarStatus = new AvatarProperty();
								}
								input.ReadMessage(this.AvatarStatus);
								continue;
							}
							if (num == 58U)
							{
								this.avatarSkill_.AddEntriesFrom(ref input, AvatarBattleInfo._repeated_avatarSkill_codec);
								continue;
							}
							if (num == 66U)
							{
								this.avatarEquipment_.AddEntriesFrom(ref input, AvatarBattleInfo._repeated_avatarEquipment_codec);
								continue;
							}
						}
						else
						{
							if (num == 72U)
							{
								this.TotalTurns = input.ReadUInt32();
								continue;
							}
							if (num == 81U)
							{
								this.TotalDamage = input.ReadDouble();
								continue;
							}
							if (num == 89U)
							{
								this.TotalHeal = input.ReadDouble();
								continue;
							}
						}
					}
					else if (num <= 128U)
					{
						if (num <= 105U)
						{
							if (num == 97U)
							{
								this.TotalDamageTaken = input.ReadDouble();
								continue;
							}
							if (num == 105U)
							{
								this.TotalHpRecover = input.ReadDouble();
								continue;
							}
						}
						else
						{
							if (num == 113U)
							{
								this.TotalSpCost = input.ReadDouble();
								continue;
							}
							if (num == 120U)
							{
								this.StageId = input.ReadUInt32();
								continue;
							}
							if (num == 128U)
							{
								this.StageType = input.ReadUInt32();
								continue;
							}
						}
					}
					else if (num <= 154U)
					{
						if (num == 137U)
						{
							this.TotalBreakDamage = input.ReadDouble();
							continue;
						}
						if (num == 146U)
						{
							this.attackTypeDamage_.AddEntriesFrom(ref input, AvatarBattleInfo._repeated_attackTypeDamage_codec);
							continue;
						}
						if (num == 154U)
						{
							this.attackTypeBreakDamage_.AddEntriesFrom(ref input, AvatarBattleInfo._repeated_attackTypeBreakDamage_codec);
							continue;
						}
					}
					else
					{
						if (num == 162U)
						{
							this.attackTypeMaxDamage_.AddEntriesFrom(ref input, AvatarBattleInfo._repeated_attackTypeMaxDamage_codec);
							continue;
						}
						if (num == 170U)
						{
							this.skillTimes_.AddEntriesFrom(ref input, AvatarBattleInfo._repeated_skillTimes_codec);
							continue;
						}
						if (num == 177U)
						{
							this.DelayCumulate = input.ReadDouble();
							continue;
						}
					}
				}
				else if (num <= 266U)
				{
					if (num <= 216U)
					{
						if (num <= 194U)
						{
							if (num == 184U)
							{
								this.TotalSpAdd = input.ReadUInt32();
								continue;
							}
							if (num == 194U)
							{
								this.spAddSource_.AddEntriesFrom(ref input, AvatarBattleInfo._repeated_spAddSource_codec);
								continue;
							}
						}
						else
						{
							if (num == 200U)
							{
								this.TotalBpCost = input.ReadUInt32();
								continue;
							}
							if (num == 208U)
							{
								this.DieTimes = input.ReadUInt32();
								continue;
							}
							if (num == 216U)
							{
								this.ReviveTimes = input.ReadUInt32();
								continue;
							}
						}
					}
					else if (num <= 241U)
					{
						if (num == 224U)
						{
							this.BreakTimes = input.ReadUInt32();
							continue;
						}
						if (num == 232U)
						{
							this.ExtraTurns = input.ReadUInt32();
							continue;
						}
						if (num == 241U)
						{
							this.TotalShield = input.ReadDouble();
							continue;
						}
					}
					else
					{
						if (num == 249U)
						{
							this.TotalShieldTaken = input.ReadDouble();
							continue;
						}
						if (num == 257U)
						{
							this.TotalShieldDamage = input.ReadDouble();
							continue;
						}
						if (num == 266U)
						{
							if (this.initialStatus_ == null)
							{
								this.InitialStatus = new AvatarProperty();
							}
							input.ReadMessage(this.InitialStatus);
							continue;
						}
					}
				}
				else if (num <= 305U)
				{
					if (num <= 280U)
					{
						if (num == 274U)
						{
							this.relics_.AddEntriesFrom(ref input, AvatarBattleInfo._repeated_relics_codec);
							continue;
						}
						if (num == 280U)
						{
							this.AssistUid = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 290U)
						{
							this.eLJGKKANLDI_.AddEntriesFrom(ref input, AvatarBattleInfo._repeated_eLJGKKANLDI_codec);
							continue;
						}
						if (num == 297U)
						{
							this.CALNPMADJBG = input.ReadDouble();
							continue;
						}
						if (num == 305U)
						{
							this.NBNJMLLGFIL = input.ReadDouble();
							continue;
						}
					}
				}
				else if (num <= 330U)
				{
					if (num == 313U)
					{
						this.OLADIJEDBPJ = input.ReadDouble();
						continue;
					}
					if (num == 321U)
					{
						this.HHJFDGDHLOP = input.ReadDouble();
						continue;
					}
					if (num == 330U)
					{
						this.pPAPOLPPKBH_.AddEntriesFrom(ref input, AvatarBattleInfo._repeated_pPAPOLPPKBH_codec);
						continue;
					}
				}
				else
				{
					if (num == 336U)
					{
						this.PADBNMLAGMM = input.ReadUInt32();
						continue;
					}
					if (num == 344U)
					{
						this.KDFLCJLALEH = input.ReadUInt32();
						continue;
					}
					if (num == 353U)
					{
						this.NIHFBGGIKIM = input.ReadDouble();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000320 RID: 800
		private static readonly MessageParser<AvatarBattleInfo> _parser = new MessageParser<AvatarBattleInfo>(() => new AvatarBattleInfo());

		// Token: 0x04000321 RID: 801
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000322 RID: 802
		public const int AvatarTypeFieldNumber = 1;

		// Token: 0x04000323 RID: 803
		private AvatarType avatarType_;

		// Token: 0x04000324 RID: 804
		public const int IdFieldNumber = 2;

		// Token: 0x04000325 RID: 805
		private uint id_;

		// Token: 0x04000326 RID: 806
		public const int AvatarLevelFieldNumber = 3;

		// Token: 0x04000327 RID: 807
		private uint avatarLevel_;

		// Token: 0x04000328 RID: 808
		public const int AvatarRankFieldNumber = 4;

		// Token: 0x04000329 RID: 809
		private uint avatarRank_;

		// Token: 0x0400032A RID: 810
		public const int AvatarPromotionFieldNumber = 5;

		// Token: 0x0400032B RID: 811
		private uint avatarPromotion_;

		// Token: 0x0400032C RID: 812
		public const int AvatarStatusFieldNumber = 6;

		// Token: 0x0400032D RID: 813
		private AvatarProperty avatarStatus_;

		// Token: 0x0400032E RID: 814
		public const int AvatarSkillFieldNumber = 7;

		// Token: 0x0400032F RID: 815
		private static readonly FieldCodec<AvatarSkillTree> _repeated_avatarSkill_codec = FieldCodec.ForMessage<AvatarSkillTree>(58U, AvatarSkillTree.Parser);

		// Token: 0x04000330 RID: 816
		private readonly RepeatedField<AvatarSkillTree> avatarSkill_ = new RepeatedField<AvatarSkillTree>();

		// Token: 0x04000331 RID: 817
		public const int AvatarEquipmentFieldNumber = 8;

		// Token: 0x04000332 RID: 818
		private static readonly FieldCodec<EquipmentProperty> _repeated_avatarEquipment_codec = FieldCodec.ForMessage<EquipmentProperty>(66U, EquipmentProperty.Parser);

		// Token: 0x04000333 RID: 819
		private readonly RepeatedField<EquipmentProperty> avatarEquipment_ = new RepeatedField<EquipmentProperty>();

		// Token: 0x04000334 RID: 820
		public const int TotalTurnsFieldNumber = 9;

		// Token: 0x04000335 RID: 821
		private uint totalTurns_;

		// Token: 0x04000336 RID: 822
		public const int TotalDamageFieldNumber = 10;

		// Token: 0x04000337 RID: 823
		private double totalDamage_;

		// Token: 0x04000338 RID: 824
		public const int TotalHealFieldNumber = 11;

		// Token: 0x04000339 RID: 825
		private double totalHeal_;

		// Token: 0x0400033A RID: 826
		public const int TotalDamageTakenFieldNumber = 12;

		// Token: 0x0400033B RID: 827
		private double totalDamageTaken_;

		// Token: 0x0400033C RID: 828
		public const int TotalHpRecoverFieldNumber = 13;

		// Token: 0x0400033D RID: 829
		private double totalHpRecover_;

		// Token: 0x0400033E RID: 830
		public const int TotalSpCostFieldNumber = 14;

		// Token: 0x0400033F RID: 831
		private double totalSpCost_;

		// Token: 0x04000340 RID: 832
		public const int StageIdFieldNumber = 15;

		// Token: 0x04000341 RID: 833
		private uint stageId_;

		// Token: 0x04000342 RID: 834
		public const int StageTypeFieldNumber = 16;

		// Token: 0x04000343 RID: 835
		private uint stageType_;

		// Token: 0x04000344 RID: 836
		public const int TotalBreakDamageFieldNumber = 17;

		// Token: 0x04000345 RID: 837
		private double totalBreakDamage_;

		// Token: 0x04000346 RID: 838
		public const int AttackTypeDamageFieldNumber = 18;

		// Token: 0x04000347 RID: 839
		private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeDamage_codec = FieldCodec.ForMessage<AttackDamageProperty>(146U, AttackDamageProperty.Parser);

		// Token: 0x04000348 RID: 840
		private readonly RepeatedField<AttackDamageProperty> attackTypeDamage_ = new RepeatedField<AttackDamageProperty>();

		// Token: 0x04000349 RID: 841
		public const int AttackTypeBreakDamageFieldNumber = 19;

		// Token: 0x0400034A RID: 842
		private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeBreakDamage_codec = FieldCodec.ForMessage<AttackDamageProperty>(154U, AttackDamageProperty.Parser);

		// Token: 0x0400034B RID: 843
		private readonly RepeatedField<AttackDamageProperty> attackTypeBreakDamage_ = new RepeatedField<AttackDamageProperty>();

		// Token: 0x0400034C RID: 844
		public const int AttackTypeMaxDamageFieldNumber = 20;

		// Token: 0x0400034D RID: 845
		private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeMaxDamage_codec = FieldCodec.ForMessage<AttackDamageProperty>(162U, AttackDamageProperty.Parser);

		// Token: 0x0400034E RID: 846
		private readonly RepeatedField<AttackDamageProperty> attackTypeMaxDamage_ = new RepeatedField<AttackDamageProperty>();

		// Token: 0x0400034F RID: 847
		public const int SkillTimesFieldNumber = 21;

		// Token: 0x04000350 RID: 848
		private static readonly FieldCodec<SkillUseProperty> _repeated_skillTimes_codec = FieldCodec.ForMessage<SkillUseProperty>(170U, SkillUseProperty.Parser);

		// Token: 0x04000351 RID: 849
		private readonly RepeatedField<SkillUseProperty> skillTimes_ = new RepeatedField<SkillUseProperty>();

		// Token: 0x04000352 RID: 850
		public const int DelayCumulateFieldNumber = 22;

		// Token: 0x04000353 RID: 851
		private double delayCumulate_;

		// Token: 0x04000354 RID: 852
		public const int TotalSpAddFieldNumber = 23;

		// Token: 0x04000355 RID: 853
		private uint totalSpAdd_;

		// Token: 0x04000356 RID: 854
		public const int SpAddSourceFieldNumber = 24;

		// Token: 0x04000357 RID: 855
		private static readonly FieldCodec<SpAddSource> _repeated_spAddSource_codec = FieldCodec.ForMessage<SpAddSource>(194U, EggLink.DanhengServer.Proto.SpAddSource.Parser);

		// Token: 0x04000358 RID: 856
		private readonly RepeatedField<SpAddSource> spAddSource_ = new RepeatedField<SpAddSource>();

		// Token: 0x04000359 RID: 857
		public const int TotalBpCostFieldNumber = 25;

		// Token: 0x0400035A RID: 858
		private uint totalBpCost_;

		// Token: 0x0400035B RID: 859
		public const int DieTimesFieldNumber = 26;

		// Token: 0x0400035C RID: 860
		private uint dieTimes_;

		// Token: 0x0400035D RID: 861
		public const int ReviveTimesFieldNumber = 27;

		// Token: 0x0400035E RID: 862
		private uint reviveTimes_;

		// Token: 0x0400035F RID: 863
		public const int BreakTimesFieldNumber = 28;

		// Token: 0x04000360 RID: 864
		private uint breakTimes_;

		// Token: 0x04000361 RID: 865
		public const int ExtraTurnsFieldNumber = 29;

		// Token: 0x04000362 RID: 866
		private uint extraTurns_;

		// Token: 0x04000363 RID: 867
		public const int TotalShieldFieldNumber = 30;

		// Token: 0x04000364 RID: 868
		private double totalShield_;

		// Token: 0x04000365 RID: 869
		public const int TotalShieldTakenFieldNumber = 31;

		// Token: 0x04000366 RID: 870
		private double totalShieldTaken_;

		// Token: 0x04000367 RID: 871
		public const int TotalShieldDamageFieldNumber = 32;

		// Token: 0x04000368 RID: 872
		private double totalShieldDamage_;

		// Token: 0x04000369 RID: 873
		public const int InitialStatusFieldNumber = 33;

		// Token: 0x0400036A RID: 874
		private AvatarProperty initialStatus_;

		// Token: 0x0400036B RID: 875
		public const int RelicsFieldNumber = 34;

		// Token: 0x0400036C RID: 876
		private static readonly FieldCodec<BattleRelic> _repeated_relics_codec = FieldCodec.ForMessage<BattleRelic>(274U, BattleRelic.Parser);

		// Token: 0x0400036D RID: 877
		private readonly RepeatedField<BattleRelic> relics_ = new RepeatedField<BattleRelic>();

		// Token: 0x0400036E RID: 878
		public const int AssistUidFieldNumber = 35;

		// Token: 0x0400036F RID: 879
		private uint assistUid_;

		// Token: 0x04000370 RID: 880
		public const int ELJGKKANLDIFieldNumber = 36;

		// Token: 0x04000371 RID: 881
		private static readonly FieldCodec<AttackDamageProperty> _repeated_eLJGKKANLDI_codec = FieldCodec.ForMessage<AttackDamageProperty>(290U, AttackDamageProperty.Parser);

		// Token: 0x04000372 RID: 882
		private readonly RepeatedField<AttackDamageProperty> eLJGKKANLDI_ = new RepeatedField<AttackDamageProperty>();

		// Token: 0x04000373 RID: 883
		public const int CALNPMADJBGFieldNumber = 37;

		// Token: 0x04000374 RID: 884
		private double cALNPMADJBG_;

		// Token: 0x04000375 RID: 885
		public const int NBNJMLLGFILFieldNumber = 38;

		// Token: 0x04000376 RID: 886
		private double nBNJMLLGFIL_;

		// Token: 0x04000377 RID: 887
		public const int OLADIJEDBPJFieldNumber = 39;

		// Token: 0x04000378 RID: 888
		private double oLADIJEDBPJ_;

		// Token: 0x04000379 RID: 889
		public const int HHJFDGDHLOPFieldNumber = 40;

		// Token: 0x0400037A RID: 890
		private double hHJFDGDHLOP_;

		// Token: 0x0400037B RID: 891
		public const int PPAPOLPPKBHFieldNumber = 41;

		// Token: 0x0400037C RID: 892
		private static readonly FieldCodec<AbilityUseStt> _repeated_pPAPOLPPKBH_codec = FieldCodec.ForMessage<AbilityUseStt>(330U, AbilityUseStt.Parser);

		// Token: 0x0400037D RID: 893
		private readonly RepeatedField<AbilityUseStt> pPAPOLPPKBH_ = new RepeatedField<AbilityUseStt>();

		// Token: 0x0400037E RID: 894
		public const int PADBNMLAGMMFieldNumber = 42;

		// Token: 0x0400037F RID: 895
		private uint pADBNMLAGMM_;

		// Token: 0x04000380 RID: 896
		public const int KDFLCJLALEHFieldNumber = 43;

		// Token: 0x04000381 RID: 897
		private uint kDFLCJLALEH_;

		// Token: 0x04000382 RID: 898
		public const int NIHFBGGIKIMFieldNumber = 44;

		// Token: 0x04000383 RID: 899
		private double nIHFBGGIKIM_;
	}
}
