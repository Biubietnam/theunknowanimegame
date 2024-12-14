using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000105 RID: 261
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleStatistics : IMessage<BattleStatistics>, IMessage, IEquatable<BattleStatistics>, IDeepCloneable<BattleStatistics>, IBufferMessage
	{
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x000226FB File Offset: 0x000208FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleStatistics> Parser
		{
			get
			{
				return BattleStatistics._parser;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x00022702 File Offset: 0x00020902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleStatisticsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00022714 File Offset: 0x00020914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleStatistics.Descriptor;
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0002271C File Offset: 0x0002091C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStatistics()
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x000227CC File Offset: 0x000209CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStatistics(BattleStatistics other) : this()
		{
			this.totalBattleTurns_ = other.totalBattleTurns_;
			this.totalAutoTurns_ = other.totalAutoTurns_;
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this.ultraCnt_ = other.ultraCnt_;
			this.totalDelayCumulate_ = other.totalDelayCumulate_;
			this.costTime_ = other.costTime_;
			this.battleAvatarList_ = other.battleAvatarList_.Clone();
			this.monsterList_ = other.monsterList_.Clone();
			this.roundCnt_ = other.roundCnt_;
			this.cocoonDeadWave_ = other.cocoonDeadWave_;
			this.avatarBattleTurns_ = other.avatarBattleTurns_;
			this.monsterBattleTurns_ = other.monsterBattleTurns_;
			this.customValues_ = other.customValues_.Clone();
			this.challengeScore_ = other.challengeScore_;
			this.pDCIAMOLIGP_ = other.pDCIAMOLIGP_.Clone();
			this.endReason_ = other.endReason_;
			this.bMIIGBIFHHL_ = other.bMIIGBIFHHL_.Clone();
			this.pMJLBECBODD_ = other.pMJLBECBODD_.Clone();
			this.bBPCNIOBIBG_ = other.bBPCNIOBIBG_.Clone();
			this.cCMJKDINJDD_ = other.cCMJKDINJDD_.Clone();
			this.dKIBBPJFDOI_ = other.dKIBBPJFDOI_.Clone();
			this.battleTargetInfo_ = other.battleTargetInfo_.Clone();
			this.kIAHIAHPPLE_ = other.kIAHIAHPPLE_.Clone();
			this.oAHDOLHBPFK_ = ((other.oAHDOLHBPFK_ != null) ? other.oAHDOLHBPFK_.Clone() : null);
			this.dFNGHNEHIIG_ = ((other.dFNGHNEHIIG_ != null) ? other.dFNGHNEHIIG_.Clone() : null);
			this.pIINHCIMOGD_ = other.pIINHCIMOGD_;
			this.lAOJOPBEIBC_ = other.lAOJOPBEIBC_.Clone();
			this.lLOEBKKLNOB_ = other.lLOEBKKLNOB_.Clone();
			this.cLNABFDPIKJ_ = other.cLNABFDPIKJ_;
			this.nFJKLODFIIL_ = ((other.nFJKLODFIIL_ != null) ? other.nFJKLODFIIL_.Clone() : null);
			this.gCCJOBNNFCA_ = ((other.gCCJOBNNFCA_ != null) ? other.gCCJOBNNFCA_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000229EA File Offset: 0x00020BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStatistics Clone()
		{
			return new BattleStatistics(this);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x000229F2 File Offset: 0x00020BF2
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x000229FA File Offset: 0x00020BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TotalBattleTurns
		{
			get
			{
				return this.totalBattleTurns_;
			}
			set
			{
				this.totalBattleTurns_ = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00022A03 File Offset: 0x00020C03
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00022A0B File Offset: 0x00020C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TotalAutoTurns
		{
			get
			{
				return this.totalAutoTurns_;
			}
			set
			{
				this.totalAutoTurns_ = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00022A14 File Offset: 0x00020C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00022A1C File Offset: 0x00020C1C
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x00022A24 File Offset: 0x00020C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UltraCnt
		{
			get
			{
				return this.ultraCnt_;
			}
			set
			{
				this.ultraCnt_ = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x00022A2D File Offset: 0x00020C2D
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x00022A35 File Offset: 0x00020C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalDelayCumulate
		{
			get
			{
				return this.totalDelayCumulate_;
			}
			set
			{
				this.totalDelayCumulate_ = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x00022A3E File Offset: 0x00020C3E
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x00022A46 File Offset: 0x00020C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00022A4F File Offset: 0x00020C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AvatarBattleInfo> BattleAvatarList
		{
			get
			{
				return this.battleAvatarList_;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00022A57 File Offset: 0x00020C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterBattleInfo> MonsterList
		{
			get
			{
				return this.monsterList_;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00022A5F File Offset: 0x00020C5F
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00022A67 File Offset: 0x00020C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoundCnt
		{
			get
			{
				return this.roundCnt_;
			}
			set
			{
				this.roundCnt_ = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x00022A70 File Offset: 0x00020C70
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x00022A78 File Offset: 0x00020C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CocoonDeadWave
		{
			get
			{
				return this.cocoonDeadWave_;
			}
			set
			{
				this.cocoonDeadWave_ = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00022A81 File Offset: 0x00020C81
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x00022A89 File Offset: 0x00020C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarBattleTurns
		{
			get
			{
				return this.avatarBattleTurns_;
			}
			set
			{
				this.avatarBattleTurns_ = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00022A92 File Offset: 0x00020C92
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x00022A9A File Offset: 0x00020C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterBattleTurns
		{
			get
			{
				return this.monsterBattleTurns_;
			}
			set
			{
				this.monsterBattleTurns_ = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00022AA3 File Offset: 0x00020CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, float> CustomValues
		{
			get
			{
				return this.customValues_;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00022AAB File Offset: 0x00020CAB
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x00022AB3 File Offset: 0x00020CB3
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

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00022ABC File Offset: 0x00020CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleEventBattleInfo> PDCIAMOLIGP
		{
			get
			{
				return this.pDCIAMOLIGP_;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00022AC4 File Offset: 0x00020CC4
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x00022ACC File Offset: 0x00020CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEndReason EndReason
		{
			get
			{
				return this.endReason_;
			}
			set
			{
				this.endReason_ = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00022AD5 File Offset: 0x00020CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GOFLJKMHPMP> BMIIGBIFHHL
		{
			get
			{
				return this.bMIIGBIFHHL_;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00022ADD File Offset: 0x00020CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PMJLBECBODD
		{
			get
			{
				return this.pMJLBECBODD_;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00022AE5 File Offset: 0x00020CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EHOJLJMGOGL> BBPCNIOBIBG
		{
			get
			{
				return this.bBPCNIOBIBG_;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00022AED File Offset: 0x00020CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NGHOLIKIEPB> CCMJKDINJDD
		{
			get
			{
				return this.cCMJKDINJDD_;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00022AF5 File Offset: 0x00020CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HLOJFCDPGBE> DKIBBPJFDOI
		{
			get
			{
				return this.dKIBBPJFDOI_;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00022AFD File Offset: 0x00020CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, BattleTargetList> BattleTargetInfo
		{
			get
			{
				return this.battleTargetInfo_;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00022B05 File Offset: 0x00020D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EOLOFLGJCIP> KIAHIAHPPLE
		{
			get
			{
				return this.kIAHIAHPPLE_;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00022B0D File Offset: 0x00020D0D
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x00022B15 File Offset: 0x00020D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildBattleInfo OAHDOLHBPFK
		{
			get
			{
				return this.oAHDOLHBPFK_;
			}
			set
			{
				this.oAHDOLHBPFK_ = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00022B1E File Offset: 0x00020D1E
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00022B26 File Offset: 0x00020D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HJJDFBODGFD DFNGHNEHIIG
		{
			get
			{
				return this.dFNGHNEHIIG_;
			}
			set
			{
				this.dFNGHNEHIIG_ = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00022B2F File Offset: 0x00020D2F
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00022B37 File Offset: 0x00020D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PIINHCIMOGD
		{
			get
			{
				return this.pIINHCIMOGD_;
			}
			set
			{
				this.pIINHCIMOGD_ = value;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00022B40 File Offset: 0x00020D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MKGIECKGJEP> LAOJOPBEIBC
		{
			get
			{
				return this.lAOJOPBEIBC_;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00022B48 File Offset: 0x00020D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DPHPAMKKMHP> LLOEBKKLNOB
		{
			get
			{
				return this.lLOEBKKLNOB_;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00022B50 File Offset: 0x00020D50
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00022B58 File Offset: 0x00020D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CLNABFDPIKJ
		{
			get
			{
				return this.cLNABFDPIKJ_;
			}
			set
			{
				this.cLNABFDPIKJ_ = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00022B61 File Offset: 0x00020D61
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00022B69 File Offset: 0x00020D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KFECMKLOBMF NFJKLODFIIL
		{
			get
			{
				return this.nFJKLODFIIL_;
			}
			set
			{
				this.nFJKLODFIIL_ = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00022B72 File Offset: 0x00020D72
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00022B7A File Offset: 0x00020D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KDDJNOPHPJF GCCJOBNNFCA
		{
			get
			{
				return this.gCCJOBNNFCA_;
			}
			set
			{
				this.gCCJOBNNFCA_ = value;
			}
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00022B83 File Offset: 0x00020D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleStatistics);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00022B94 File Offset: 0x00020D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleStatistics other)
		{
			return other != null && (other == this || (this.TotalBattleTurns == other.TotalBattleTurns && this.TotalAutoTurns == other.TotalAutoTurns && this.avatarIdList_.Equals(other.avatarIdList_) && this.UltraCnt == other.UltraCnt && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalDelayCumulate, other.TotalDelayCumulate) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.CostTime, other.CostTime) && this.battleAvatarList_.Equals(other.battleAvatarList_) && this.monsterList_.Equals(other.monsterList_) && this.RoundCnt == other.RoundCnt && this.CocoonDeadWave == other.CocoonDeadWave && this.AvatarBattleTurns == other.AvatarBattleTurns && this.MonsterBattleTurns == other.MonsterBattleTurns && this.CustomValues.Equals(other.CustomValues) && this.ChallengeScore == other.ChallengeScore && this.pDCIAMOLIGP_.Equals(other.pDCIAMOLIGP_) && this.EndReason == other.EndReason && this.bMIIGBIFHHL_.Equals(other.bMIIGBIFHHL_) && this.pMJLBECBODD_.Equals(other.pMJLBECBODD_) && this.bBPCNIOBIBG_.Equals(other.bBPCNIOBIBG_) && this.cCMJKDINJDD_.Equals(other.cCMJKDINJDD_) && this.dKIBBPJFDOI_.Equals(other.dKIBBPJFDOI_) && this.BattleTargetInfo.Equals(other.BattleTargetInfo) && this.kIAHIAHPPLE_.Equals(other.kIAHIAHPPLE_) && object.Equals(this.OAHDOLHBPFK, other.OAHDOLHBPFK) && object.Equals(this.DFNGHNEHIIG, other.DFNGHNEHIIG) && this.PIINHCIMOGD == other.PIINHCIMOGD && this.lAOJOPBEIBC_.Equals(other.lAOJOPBEIBC_) && this.lLOEBKKLNOB_.Equals(other.lLOEBKKLNOB_) && this.CLNABFDPIKJ == other.CLNABFDPIKJ && object.Equals(this.NFJKLODFIIL, other.NFJKLODFIIL) && object.Equals(this.GCCJOBNNFCA, other.GCCJOBNNFCA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00022E1C File Offset: 0x0002101C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalBattleTurns != 0U)
			{
				num ^= this.TotalBattleTurns.GetHashCode();
			}
			if (this.TotalAutoTurns != 0U)
			{
				num ^= this.TotalAutoTurns.GetHashCode();
			}
			num ^= this.avatarIdList_.GetHashCode();
			if (this.UltraCnt != 0U)
			{
				num ^= this.UltraCnt.GetHashCode();
			}
			if (this.TotalDelayCumulate != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalDelayCumulate);
			}
			if (this.CostTime != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.CostTime);
			}
			num ^= this.battleAvatarList_.GetHashCode();
			num ^= this.monsterList_.GetHashCode();
			if (this.RoundCnt != 0U)
			{
				num ^= this.RoundCnt.GetHashCode();
			}
			if (this.CocoonDeadWave != 0U)
			{
				num ^= this.CocoonDeadWave.GetHashCode();
			}
			if (this.AvatarBattleTurns != 0U)
			{
				num ^= this.AvatarBattleTurns.GetHashCode();
			}
			if (this.MonsterBattleTurns != 0U)
			{
				num ^= this.MonsterBattleTurns.GetHashCode();
			}
			num ^= this.CustomValues.GetHashCode();
			if (this.ChallengeScore != 0U)
			{
				num ^= this.ChallengeScore.GetHashCode();
			}
			num ^= this.pDCIAMOLIGP_.GetHashCode();
			if (this.EndReason != BattleEndReason.None)
			{
				num ^= this.EndReason.GetHashCode();
			}
			num ^= this.bMIIGBIFHHL_.GetHashCode();
			num ^= this.pMJLBECBODD_.GetHashCode();
			num ^= this.bBPCNIOBIBG_.GetHashCode();
			num ^= this.cCMJKDINJDD_.GetHashCode();
			num ^= this.dKIBBPJFDOI_.GetHashCode();
			num ^= this.BattleTargetInfo.GetHashCode();
			num ^= this.kIAHIAHPPLE_.GetHashCode();
			if (this.oAHDOLHBPFK_ != null)
			{
				num ^= this.OAHDOLHBPFK.GetHashCode();
			}
			if (this.dFNGHNEHIIG_ != null)
			{
				num ^= this.DFNGHNEHIIG.GetHashCode();
			}
			if (this.PIINHCIMOGD)
			{
				num ^= this.PIINHCIMOGD.GetHashCode();
			}
			num ^= this.lAOJOPBEIBC_.GetHashCode();
			num ^= this.lLOEBKKLNOB_.GetHashCode();
			if (this.CLNABFDPIKJ != 0U)
			{
				num ^= this.CLNABFDPIKJ.GetHashCode();
			}
			if (this.nFJKLODFIIL_ != null)
			{
				num ^= this.NFJKLODFIIL.GetHashCode();
			}
			if (this.gCCJOBNNFCA_ != null)
			{
				num ^= this.GCCJOBNNFCA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000230BF File Offset: 0x000212BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x000230C7 File Offset: 0x000212C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000230D0 File Offset: 0x000212D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalBattleTurns != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TotalBattleTurns);
			}
			if (this.TotalAutoTurns != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TotalAutoTurns);
			}
			this.avatarIdList_.WriteTo(ref output, BattleStatistics._repeated_avatarIdList_codec);
			if (this.UltraCnt != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.UltraCnt);
			}
			if (this.TotalDelayCumulate != 0.0)
			{
				output.WriteRawTag(41);
				output.WriteDouble(this.TotalDelayCumulate);
			}
			if (this.CostTime != 0.0)
			{
				output.WriteRawTag(49);
				output.WriteDouble(this.CostTime);
			}
			this.battleAvatarList_.WriteTo(ref output, BattleStatistics._repeated_battleAvatarList_codec);
			this.monsterList_.WriteTo(ref output, BattleStatistics._repeated_monsterList_codec);
			if (this.RoundCnt != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.RoundCnt);
			}
			if (this.CocoonDeadWave != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CocoonDeadWave);
			}
			if (this.AvatarBattleTurns != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.AvatarBattleTurns);
			}
			if (this.MonsterBattleTurns != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MonsterBattleTurns);
			}
			this.customValues_.WriteTo(ref output, BattleStatistics._map_customValues_codec);
			if (this.ChallengeScore != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ChallengeScore);
			}
			this.pDCIAMOLIGP_.WriteTo(ref output, BattleStatistics._repeated_pDCIAMOLIGP_codec);
			if (this.EndReason != BattleEndReason.None)
			{
				output.WriteRawTag(152, 1);
				output.WriteEnum((int)this.EndReason);
			}
			this.bMIIGBIFHHL_.WriteTo(ref output, BattleStatistics._repeated_bMIIGBIFHHL_codec);
			this.pMJLBECBODD_.WriteTo(ref output, BattleStatistics._repeated_pMJLBECBODD_codec);
			this.bBPCNIOBIBG_.WriteTo(ref output, BattleStatistics._repeated_bBPCNIOBIBG_codec);
			this.cCMJKDINJDD_.WriteTo(ref output, BattleStatistics._repeated_cCMJKDINJDD_codec);
			this.dKIBBPJFDOI_.WriteTo(ref output, BattleStatistics._repeated_dKIBBPJFDOI_codec);
			this.battleTargetInfo_.WriteTo(ref output, BattleStatistics._map_battleTargetInfo_codec);
			this.kIAHIAHPPLE_.WriteTo(ref output, BattleStatistics._repeated_kIAHIAHPPLE_codec);
			if (this.oAHDOLHBPFK_ != null)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.OAHDOLHBPFK);
			}
			if (this.dFNGHNEHIIG_ != null)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.DFNGHNEHIIG);
			}
			if (this.PIINHCIMOGD)
			{
				output.WriteRawTag(128, 2);
				output.WriteBool(this.PIINHCIMOGD);
			}
			this.lAOJOPBEIBC_.WriteTo(ref output, BattleStatistics._repeated_lAOJOPBEIBC_codec);
			this.lLOEBKKLNOB_.WriteTo(ref output, BattleStatistics._repeated_lLOEBKKLNOB_codec);
			if (this.CLNABFDPIKJ != 0U)
			{
				output.WriteRawTag(152, 2);
				output.WriteUInt32(this.CLNABFDPIKJ);
			}
			if (this.nFJKLODFIIL_ != null)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.NFJKLODFIIL);
			}
			if (this.gCCJOBNNFCA_ != null)
			{
				output.WriteRawTag(170, 2);
				output.WriteMessage(this.GCCJOBNNFCA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000233E8 File Offset: 0x000215E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalBattleTurns != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TotalBattleTurns);
			}
			if (this.TotalAutoTurns != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TotalAutoTurns);
			}
			num += this.avatarIdList_.CalculateSize(BattleStatistics._repeated_avatarIdList_codec);
			if (this.UltraCnt != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UltraCnt);
			}
			if (this.TotalDelayCumulate != 0.0)
			{
				num += 9;
			}
			if (this.CostTime != 0.0)
			{
				num += 9;
			}
			num += this.battleAvatarList_.CalculateSize(BattleStatistics._repeated_battleAvatarList_codec);
			num += this.monsterList_.CalculateSize(BattleStatistics._repeated_monsterList_codec);
			if (this.RoundCnt != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoundCnt);
			}
			if (this.CocoonDeadWave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CocoonDeadWave);
			}
			if (this.AvatarBattleTurns != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarBattleTurns);
			}
			if (this.MonsterBattleTurns != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterBattleTurns);
			}
			num += this.customValues_.CalculateSize(BattleStatistics._map_customValues_codec);
			if (this.ChallengeScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeScore);
			}
			num += this.pDCIAMOLIGP_.CalculateSize(BattleStatistics._repeated_pDCIAMOLIGP_codec);
			if (this.EndReason != BattleEndReason.None)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.EndReason);
			}
			num += this.bMIIGBIFHHL_.CalculateSize(BattleStatistics._repeated_bMIIGBIFHHL_codec);
			num += this.pMJLBECBODD_.CalculateSize(BattleStatistics._repeated_pMJLBECBODD_codec);
			num += this.bBPCNIOBIBG_.CalculateSize(BattleStatistics._repeated_bBPCNIOBIBG_codec);
			num += this.cCMJKDINJDD_.CalculateSize(BattleStatistics._repeated_cCMJKDINJDD_codec);
			num += this.dKIBBPJFDOI_.CalculateSize(BattleStatistics._repeated_dKIBBPJFDOI_codec);
			num += this.battleTargetInfo_.CalculateSize(BattleStatistics._map_battleTargetInfo_codec);
			num += this.kIAHIAHPPLE_.CalculateSize(BattleStatistics._repeated_kIAHIAHPPLE_codec);
			if (this.oAHDOLHBPFK_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OAHDOLHBPFK);
			}
			if (this.dFNGHNEHIIG_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DFNGHNEHIIG);
			}
			if (this.PIINHCIMOGD)
			{
				num += 3;
			}
			num += this.lAOJOPBEIBC_.CalculateSize(BattleStatistics._repeated_lAOJOPBEIBC_codec);
			num += this.lLOEBKKLNOB_.CalculateSize(BattleStatistics._repeated_lLOEBKKLNOB_codec);
			if (this.CLNABFDPIKJ != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.CLNABFDPIKJ);
			}
			if (this.nFJKLODFIIL_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NFJKLODFIIL);
			}
			if (this.gCCJOBNNFCA_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GCCJOBNNFCA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x000236A0 File Offset: 0x000218A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleStatistics other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalBattleTurns != 0U)
			{
				this.TotalBattleTurns = other.TotalBattleTurns;
			}
			if (other.TotalAutoTurns != 0U)
			{
				this.TotalAutoTurns = other.TotalAutoTurns;
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			if (other.UltraCnt != 0U)
			{
				this.UltraCnt = other.UltraCnt;
			}
			if (other.TotalDelayCumulate != 0.0)
			{
				this.TotalDelayCumulate = other.TotalDelayCumulate;
			}
			if (other.CostTime != 0.0)
			{
				this.CostTime = other.CostTime;
			}
			this.battleAvatarList_.Add(other.battleAvatarList_);
			this.monsterList_.Add(other.monsterList_);
			if (other.RoundCnt != 0U)
			{
				this.RoundCnt = other.RoundCnt;
			}
			if (other.CocoonDeadWave != 0U)
			{
				this.CocoonDeadWave = other.CocoonDeadWave;
			}
			if (other.AvatarBattleTurns != 0U)
			{
				this.AvatarBattleTurns = other.AvatarBattleTurns;
			}
			if (other.MonsterBattleTurns != 0U)
			{
				this.MonsterBattleTurns = other.MonsterBattleTurns;
			}
			this.customValues_.MergeFrom(other.customValues_);
			if (other.ChallengeScore != 0U)
			{
				this.ChallengeScore = other.ChallengeScore;
			}
			this.pDCIAMOLIGP_.Add(other.pDCIAMOLIGP_);
			if (other.EndReason != BattleEndReason.None)
			{
				this.EndReason = other.EndReason;
			}
			this.bMIIGBIFHHL_.Add(other.bMIIGBIFHHL_);
			this.pMJLBECBODD_.Add(other.pMJLBECBODD_);
			this.bBPCNIOBIBG_.Add(other.bBPCNIOBIBG_);
			this.cCMJKDINJDD_.Add(other.cCMJKDINJDD_);
			this.dKIBBPJFDOI_.Add(other.dKIBBPJFDOI_);
			this.battleTargetInfo_.MergeFrom(other.battleTargetInfo_);
			this.kIAHIAHPPLE_.Add(other.kIAHIAHPPLE_);
			if (other.oAHDOLHBPFK_ != null)
			{
				if (this.oAHDOLHBPFK_ == null)
				{
					this.OAHDOLHBPFK = new EvolveBuildBattleInfo();
				}
				this.OAHDOLHBPFK.MergeFrom(other.OAHDOLHBPFK);
			}
			if (other.dFNGHNEHIIG_ != null)
			{
				if (this.dFNGHNEHIIG_ == null)
				{
					this.DFNGHNEHIIG = new HJJDFBODGFD();
				}
				this.DFNGHNEHIIG.MergeFrom(other.DFNGHNEHIIG);
			}
			if (other.PIINHCIMOGD)
			{
				this.PIINHCIMOGD = other.PIINHCIMOGD;
			}
			this.lAOJOPBEIBC_.Add(other.lAOJOPBEIBC_);
			this.lLOEBKKLNOB_.Add(other.lLOEBKKLNOB_);
			if (other.CLNABFDPIKJ != 0U)
			{
				this.CLNABFDPIKJ = other.CLNABFDPIKJ;
			}
			if (other.nFJKLODFIIL_ != null)
			{
				if (this.nFJKLODFIIL_ == null)
				{
					this.NFJKLODFIIL = new KFECMKLOBMF();
				}
				this.NFJKLODFIIL.MergeFrom(other.NFJKLODFIIL);
			}
			if (other.gCCJOBNNFCA_ != null)
			{
				if (this.gCCJOBNNFCA_ == null)
				{
					this.GCCJOBNNFCA = new KDDJNOPHPJF();
				}
				this.GCCJOBNNFCA.MergeFrom(other.GCCJOBNNFCA);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0002397C File Offset: 0x00021B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00023988 File Offset: 0x00021B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 130U)
				{
					if (num <= 58U)
					{
						if (num <= 26U)
						{
							if (num <= 16U)
							{
								if (num == 8U)
								{
									this.TotalBattleTurns = input.ReadUInt32();
									continue;
								}
								if (num == 16U)
								{
									this.TotalAutoTurns = input.ReadUInt32();
									continue;
								}
							}
							else if (num == 24U || num == 26U)
							{
								this.avatarIdList_.AddEntriesFrom(ref input, BattleStatistics._repeated_avatarIdList_codec);
								continue;
							}
						}
						else if (num <= 41U)
						{
							if (num == 32U)
							{
								this.UltraCnt = input.ReadUInt32();
								continue;
							}
							if (num == 41U)
							{
								this.TotalDelayCumulate = input.ReadDouble();
								continue;
							}
						}
						else
						{
							if (num == 49U)
							{
								this.CostTime = input.ReadDouble();
								continue;
							}
							if (num == 58U)
							{
								this.battleAvatarList_.AddEntriesFrom(ref input, BattleStatistics._repeated_battleAvatarList_codec);
								continue;
							}
						}
					}
					else if (num <= 88U)
					{
						if (num <= 72U)
						{
							if (num == 66U)
							{
								this.monsterList_.AddEntriesFrom(ref input, BattleStatistics._repeated_monsterList_codec);
								continue;
							}
							if (num == 72U)
							{
								this.RoundCnt = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 80U)
							{
								this.CocoonDeadWave = input.ReadUInt32();
								continue;
							}
							if (num == 88U)
							{
								this.AvatarBattleTurns = input.ReadUInt32();
								continue;
							}
						}
					}
					else if (num <= 106U)
					{
						if (num == 96U)
						{
							this.MonsterBattleTurns = input.ReadUInt32();
							continue;
						}
						if (num == 106U)
						{
							this.customValues_.AddEntriesFrom(ref input, BattleStatistics._map_customValues_codec);
							continue;
						}
					}
					else
					{
						if (num == 112U)
						{
							this.ChallengeScore = input.ReadUInt32();
							continue;
						}
						if (num == 130U)
						{
							this.pDCIAMOLIGP_.AddEntriesFrom(ref input, BattleStatistics._repeated_pDCIAMOLIGP_codec);
							continue;
						}
					}
				}
				else if (num <= 226U)
				{
					if (num <= 178U)
					{
						if (num <= 170U)
						{
							if (num == 152U)
							{
								this.EndReason = (BattleEndReason)input.ReadEnum();
								continue;
							}
							if (num == 170U)
							{
								this.bMIIGBIFHHL_.AddEntriesFrom(ref input, BattleStatistics._repeated_bMIIGBIFHHL_codec);
								continue;
							}
						}
						else if (num == 176U || num == 178U)
						{
							this.pMJLBECBODD_.AddEntriesFrom(ref input, BattleStatistics._repeated_pMJLBECBODD_codec);
							continue;
						}
					}
					else if (num <= 210U)
					{
						if (num == 186U)
						{
							this.bBPCNIOBIBG_.AddEntriesFrom(ref input, BattleStatistics._repeated_bBPCNIOBIBG_codec);
							continue;
						}
						if (num == 210U)
						{
							this.cCMJKDINJDD_.AddEntriesFrom(ref input, BattleStatistics._repeated_cCMJKDINJDD_codec);
							continue;
						}
					}
					else
					{
						if (num == 218U)
						{
							this.dKIBBPJFDOI_.AddEntriesFrom(ref input, BattleStatistics._repeated_dKIBBPJFDOI_codec);
							continue;
						}
						if (num == 226U)
						{
							this.battleTargetInfo_.AddEntriesFrom(ref input, BattleStatistics._map_battleTargetInfo_codec);
							continue;
						}
					}
				}
				else if (num <= 256U)
				{
					if (num <= 242U)
					{
						if (num == 234U)
						{
							this.kIAHIAHPPLE_.AddEntriesFrom(ref input, BattleStatistics._repeated_kIAHIAHPPLE_codec);
							continue;
						}
						if (num == 242U)
						{
							if (this.oAHDOLHBPFK_ == null)
							{
								this.OAHDOLHBPFK = new EvolveBuildBattleInfo();
							}
							input.ReadMessage(this.OAHDOLHBPFK);
							continue;
						}
					}
					else
					{
						if (num == 250U)
						{
							if (this.dFNGHNEHIIG_ == null)
							{
								this.DFNGHNEHIIG = new HJJDFBODGFD();
							}
							input.ReadMessage(this.DFNGHNEHIIG);
							continue;
						}
						if (num == 256U)
						{
							this.PIINHCIMOGD = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 274U)
				{
					if (num == 266U)
					{
						this.lAOJOPBEIBC_.AddEntriesFrom(ref input, BattleStatistics._repeated_lAOJOPBEIBC_codec);
						continue;
					}
					if (num == 274U)
					{
						this.lLOEBKKLNOB_.AddEntriesFrom(ref input, BattleStatistics._repeated_lLOEBKKLNOB_codec);
						continue;
					}
				}
				else
				{
					if (num == 280U)
					{
						this.CLNABFDPIKJ = input.ReadUInt32();
						continue;
					}
					if (num == 290U)
					{
						if (this.nFJKLODFIIL_ == null)
						{
							this.NFJKLODFIIL = new KFECMKLOBMF();
						}
						input.ReadMessage(this.NFJKLODFIIL);
						continue;
					}
					if (num == 298U)
					{
						if (this.gCCJOBNNFCA_ == null)
						{
							this.GCCJOBNNFCA = new KDDJNOPHPJF();
						}
						input.ReadMessage(this.GCCJOBNNFCA);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040004E6 RID: 1254
		private static readonly MessageParser<BattleStatistics> _parser = new MessageParser<BattleStatistics>(() => new BattleStatistics());

		// Token: 0x040004E7 RID: 1255
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004E8 RID: 1256
		public const int TotalBattleTurnsFieldNumber = 1;

		// Token: 0x040004E9 RID: 1257
		private uint totalBattleTurns_;

		// Token: 0x040004EA RID: 1258
		public const int TotalAutoTurnsFieldNumber = 2;

		// Token: 0x040004EB RID: 1259
		private uint totalAutoTurns_;

		// Token: 0x040004EC RID: 1260
		public const int AvatarIdListFieldNumber = 3;

		// Token: 0x040004ED RID: 1261
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x040004EE RID: 1262
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

		// Token: 0x040004EF RID: 1263
		public const int UltraCntFieldNumber = 4;

		// Token: 0x040004F0 RID: 1264
		private uint ultraCnt_;

		// Token: 0x040004F1 RID: 1265
		public const int TotalDelayCumulateFieldNumber = 5;

		// Token: 0x040004F2 RID: 1266
		private double totalDelayCumulate_;

		// Token: 0x040004F3 RID: 1267
		public const int CostTimeFieldNumber = 6;

		// Token: 0x040004F4 RID: 1268
		private double costTime_;

		// Token: 0x040004F5 RID: 1269
		public const int BattleAvatarListFieldNumber = 7;

		// Token: 0x040004F6 RID: 1270
		private static readonly FieldCodec<AvatarBattleInfo> _repeated_battleAvatarList_codec = FieldCodec.ForMessage<AvatarBattleInfo>(58U, AvatarBattleInfo.Parser);

		// Token: 0x040004F7 RID: 1271
		private readonly RepeatedField<AvatarBattleInfo> battleAvatarList_ = new RepeatedField<AvatarBattleInfo>();

		// Token: 0x040004F8 RID: 1272
		public const int MonsterListFieldNumber = 8;

		// Token: 0x040004F9 RID: 1273
		private static readonly FieldCodec<MonsterBattleInfo> _repeated_monsterList_codec = FieldCodec.ForMessage<MonsterBattleInfo>(66U, MonsterBattleInfo.Parser);

		// Token: 0x040004FA RID: 1274
		private readonly RepeatedField<MonsterBattleInfo> monsterList_ = new RepeatedField<MonsterBattleInfo>();

		// Token: 0x040004FB RID: 1275
		public const int RoundCntFieldNumber = 9;

		// Token: 0x040004FC RID: 1276
		private uint roundCnt_;

		// Token: 0x040004FD RID: 1277
		public const int CocoonDeadWaveFieldNumber = 10;

		// Token: 0x040004FE RID: 1278
		private uint cocoonDeadWave_;

		// Token: 0x040004FF RID: 1279
		public const int AvatarBattleTurnsFieldNumber = 11;

		// Token: 0x04000500 RID: 1280
		private uint avatarBattleTurns_;

		// Token: 0x04000501 RID: 1281
		public const int MonsterBattleTurnsFieldNumber = 12;

		// Token: 0x04000502 RID: 1282
		private uint monsterBattleTurns_;

		// Token: 0x04000503 RID: 1283
		public const int CustomValuesFieldNumber = 13;

		// Token: 0x04000504 RID: 1284
		private static readonly MapField<string, float>.Codec _map_customValues_codec = new MapField<string, float>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForFloat(21U, 0f), 106U);

		// Token: 0x04000505 RID: 1285
		private readonly MapField<string, float> customValues_ = new MapField<string, float>();

		// Token: 0x04000506 RID: 1286
		public const int ChallengeScoreFieldNumber = 14;

		// Token: 0x04000507 RID: 1287
		private uint challengeScore_;

		// Token: 0x04000508 RID: 1288
		public const int PDCIAMOLIGPFieldNumber = 16;

		// Token: 0x04000509 RID: 1289
		private static readonly FieldCodec<BattleEventBattleInfo> _repeated_pDCIAMOLIGP_codec = FieldCodec.ForMessage<BattleEventBattleInfo>(130U, BattleEventBattleInfo.Parser);

		// Token: 0x0400050A RID: 1290
		private readonly RepeatedField<BattleEventBattleInfo> pDCIAMOLIGP_ = new RepeatedField<BattleEventBattleInfo>();

		// Token: 0x0400050B RID: 1291
		public const int EndReasonFieldNumber = 19;

		// Token: 0x0400050C RID: 1292
		private BattleEndReason endReason_;

		// Token: 0x0400050D RID: 1293
		public const int BMIIGBIFHHLFieldNumber = 21;

		// Token: 0x0400050E RID: 1294
		private static readonly FieldCodec<GOFLJKMHPMP> _repeated_bMIIGBIFHHL_codec = FieldCodec.ForMessage<GOFLJKMHPMP>(170U, GOFLJKMHPMP.Parser);

		// Token: 0x0400050F RID: 1295
		private readonly RepeatedField<GOFLJKMHPMP> bMIIGBIFHHL_ = new RepeatedField<GOFLJKMHPMP>();

		// Token: 0x04000510 RID: 1296
		public const int PMJLBECBODDFieldNumber = 22;

		// Token: 0x04000511 RID: 1297
		private static readonly FieldCodec<int> _repeated_pMJLBECBODD_codec = FieldCodec.ForInt32(178U);

		// Token: 0x04000512 RID: 1298
		private readonly RepeatedField<int> pMJLBECBODD_ = new RepeatedField<int>();

		// Token: 0x04000513 RID: 1299
		public const int BBPCNIOBIBGFieldNumber = 23;

		// Token: 0x04000514 RID: 1300
		private static readonly FieldCodec<EHOJLJMGOGL> _repeated_bBPCNIOBIBG_codec = FieldCodec.ForMessage<EHOJLJMGOGL>(186U, EHOJLJMGOGL.Parser);

		// Token: 0x04000515 RID: 1301
		private readonly RepeatedField<EHOJLJMGOGL> bBPCNIOBIBG_ = new RepeatedField<EHOJLJMGOGL>();

		// Token: 0x04000516 RID: 1302
		public const int CCMJKDINJDDFieldNumber = 26;

		// Token: 0x04000517 RID: 1303
		private static readonly FieldCodec<NGHOLIKIEPB> _repeated_cCMJKDINJDD_codec = FieldCodec.ForMessage<NGHOLIKIEPB>(210U, NGHOLIKIEPB.Parser);

		// Token: 0x04000518 RID: 1304
		private readonly RepeatedField<NGHOLIKIEPB> cCMJKDINJDD_ = new RepeatedField<NGHOLIKIEPB>();

		// Token: 0x04000519 RID: 1305
		public const int DKIBBPJFDOIFieldNumber = 27;

		// Token: 0x0400051A RID: 1306
		private static readonly FieldCodec<HLOJFCDPGBE> _repeated_dKIBBPJFDOI_codec = FieldCodec.ForMessage<HLOJFCDPGBE>(218U, HLOJFCDPGBE.Parser);

		// Token: 0x0400051B RID: 1307
		private readonly RepeatedField<HLOJFCDPGBE> dKIBBPJFDOI_ = new RepeatedField<HLOJFCDPGBE>();

		// Token: 0x0400051C RID: 1308
		public const int BattleTargetInfoFieldNumber = 28;

		// Token: 0x0400051D RID: 1309
		private static readonly MapField<uint, BattleTargetList>.Codec _map_battleTargetInfo_codec = new MapField<uint, BattleTargetList>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<BattleTargetList>(18U, BattleTargetList.Parser), 226U);

		// Token: 0x0400051E RID: 1310
		private readonly MapField<uint, BattleTargetList> battleTargetInfo_ = new MapField<uint, BattleTargetList>();

		// Token: 0x0400051F RID: 1311
		public const int KIAHIAHPPLEFieldNumber = 29;

		// Token: 0x04000520 RID: 1312
		private static readonly FieldCodec<EOLOFLGJCIP> _repeated_kIAHIAHPPLE_codec = FieldCodec.ForMessage<EOLOFLGJCIP>(234U, EOLOFLGJCIP.Parser);

		// Token: 0x04000521 RID: 1313
		private readonly RepeatedField<EOLOFLGJCIP> kIAHIAHPPLE_ = new RepeatedField<EOLOFLGJCIP>();

		// Token: 0x04000522 RID: 1314
		public const int OAHDOLHBPFKFieldNumber = 30;

		// Token: 0x04000523 RID: 1315
		private EvolveBuildBattleInfo oAHDOLHBPFK_;

		// Token: 0x04000524 RID: 1316
		public const int DFNGHNEHIIGFieldNumber = 31;

		// Token: 0x04000525 RID: 1317
		private HJJDFBODGFD dFNGHNEHIIG_;

		// Token: 0x04000526 RID: 1318
		public const int PIINHCIMOGDFieldNumber = 32;

		// Token: 0x04000527 RID: 1319
		private bool pIINHCIMOGD_;

		// Token: 0x04000528 RID: 1320
		public const int LAOJOPBEIBCFieldNumber = 33;

		// Token: 0x04000529 RID: 1321
		private static readonly FieldCodec<MKGIECKGJEP> _repeated_lAOJOPBEIBC_codec = FieldCodec.ForMessage<MKGIECKGJEP>(266U, MKGIECKGJEP.Parser);

		// Token: 0x0400052A RID: 1322
		private readonly RepeatedField<MKGIECKGJEP> lAOJOPBEIBC_ = new RepeatedField<MKGIECKGJEP>();

		// Token: 0x0400052B RID: 1323
		public const int LLOEBKKLNOBFieldNumber = 34;

		// Token: 0x0400052C RID: 1324
		private static readonly FieldCodec<DPHPAMKKMHP> _repeated_lLOEBKKLNOB_codec = FieldCodec.ForMessage<DPHPAMKKMHP>(274U, DPHPAMKKMHP.Parser);

		// Token: 0x0400052D RID: 1325
		private readonly RepeatedField<DPHPAMKKMHP> lLOEBKKLNOB_ = new RepeatedField<DPHPAMKKMHP>();

		// Token: 0x0400052E RID: 1326
		public const int CLNABFDPIKJFieldNumber = 35;

		// Token: 0x0400052F RID: 1327
		private uint cLNABFDPIKJ_;

		// Token: 0x04000530 RID: 1328
		public const int NFJKLODFIILFieldNumber = 36;

		// Token: 0x04000531 RID: 1329
		private KFECMKLOBMF nFJKLODFIIL_;

		// Token: 0x04000532 RID: 1330
		public const int GCCJOBNNFCAFieldNumber = 37;

		// Token: 0x04000533 RID: 1331
		private KDDJNOPHPJF gCCJOBNNFCA_;
	}
}
