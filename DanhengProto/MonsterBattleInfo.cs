using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B8B RID: 2955
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonsterBattleInfo : IMessage<MonsterBattleInfo>, IMessage, IEquatable<MonsterBattleInfo>, IDeepCloneable<MonsterBattleInfo>, IBufferMessage
	{
		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x060082C7 RID: 33479 RVA: 0x00158702 File Offset: 0x00156902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterBattleInfo> Parser
		{
			get
			{
				return MonsterBattleInfo._parser;
			}
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x060082C8 RID: 33480 RVA: 0x00158709 File Offset: 0x00156909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonsterBattleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x060082C9 RID: 33481 RVA: 0x0015871B File Offset: 0x0015691B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterBattleInfo.Descriptor;
			}
		}

		// Token: 0x060082CA RID: 33482 RVA: 0x00158722 File Offset: 0x00156922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBattleInfo()
		{
		}

		// Token: 0x060082CB RID: 33483 RVA: 0x00158758 File Offset: 0x00156958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBattleInfo(MonsterBattleInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.monsterId_ = other.monsterId_;
			this.lGIOKJPJOFN_ = other.lGIOKJPJOFN_;
			this.oDBNBKCDDPC_ = other.oDBNBKCDDPC_;
			this.eMPDGGAALDC_ = ((other.eMPDGGAALDC_ != null) ? other.eMPDGGAALDC_.Clone() : null);
			this.totalTurns_ = other.totalTurns_;
			this.totalDamage_ = other.totalDamage_;
			this.totalHeal_ = other.totalHeal_;
			this.totalDamageTaken_ = other.totalDamageTaken_;
			this.aCNAAGPOIME_ = other.aCNAAGPOIME_;
			this.totalHpRecover_ = other.totalHpRecover_;
			this.stageId_ = other.stageId_;
			this.battleId_ = other.battleId_;
			this.gEHICNBDNFP_ = other.gEHICNBDNFP_;
			this.attackTypeDamage_ = other.attackTypeDamage_.Clone();
			this.skillTimes_ = other.skillTimes_.Clone();
			this.stageType_ = other.stageType_;
			this.jGABGKLPPBA_ = other.jGABGKLPPBA_;
			this.delayCumulate_ = other.delayCumulate_;
			this.gCBMMMDLDKN_ = other.gCBMMMDLDKN_;
			this.wave_ = other.wave_;
			this.bIDMILFDKIK_ = other.bIDMILFDKIK_;
			this.phase_ = other.phase_;
			this.dFJHDKKMPMM_ = other.dFJHDKKMPMM_;
			this.mLCDMBECDJM_ = other.mLCDMBECDJM_;
			this.skillInfo_ = other.skillInfo_.Clone();
			this.oKGKMLGGMDO_ = other.oKGKMLGGMDO_;
			this.kEPDCEILLJF_ = other.kEPDCEILLJF_.Clone();
			this.jGHNPEBHBDK_ = other.jGHNPEBHBDK_;
			this.lANOIPJHKAC_ = other.lANOIPJHKAC_;
			this.aMLAAOLDKCL_ = other.aMLAAOLDKCL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082CC RID: 33484 RVA: 0x00158914 File Offset: 0x00156B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBattleInfo Clone()
		{
			return new MonsterBattleInfo(this);
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x060082CD RID: 33485 RVA: 0x0015891C File Offset: 0x00156B1C
		// (set) Token: 0x060082CE RID: 33486 RVA: 0x00158924 File Offset: 0x00156B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x060082CF RID: 33487 RVA: 0x0015892D File Offset: 0x00156B2D
		// (set) Token: 0x060082D0 RID: 33488 RVA: 0x00158935 File Offset: 0x00156B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x060082D1 RID: 33489 RVA: 0x0015893E File Offset: 0x00156B3E
		// (set) Token: 0x060082D2 RID: 33490 RVA: 0x00158946 File Offset: 0x00156B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LGIOKJPJOFN
		{
			get
			{
				return this.lGIOKJPJOFN_;
			}
			set
			{
				this.lGIOKJPJOFN_ = value;
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x060082D3 RID: 33491 RVA: 0x0015894F File Offset: 0x00156B4F
		// (set) Token: 0x060082D4 RID: 33492 RVA: 0x00158957 File Offset: 0x00156B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ODBNBKCDDPC
		{
			get
			{
				return this.oDBNBKCDDPC_;
			}
			set
			{
				this.oDBNBKCDDPC_ = value;
			}
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x060082D5 RID: 33493 RVA: 0x00158960 File Offset: 0x00156B60
		// (set) Token: 0x060082D6 RID: 33494 RVA: 0x00158968 File Offset: 0x00156B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterProperty EMPDGGAALDC
		{
			get
			{
				return this.eMPDGGAALDC_;
			}
			set
			{
				this.eMPDGGAALDC_ = value;
			}
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x060082D7 RID: 33495 RVA: 0x00158971 File Offset: 0x00156B71
		// (set) Token: 0x060082D8 RID: 33496 RVA: 0x00158979 File Offset: 0x00156B79
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

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x060082D9 RID: 33497 RVA: 0x00158982 File Offset: 0x00156B82
		// (set) Token: 0x060082DA RID: 33498 RVA: 0x0015898A File Offset: 0x00156B8A
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

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x060082DB RID: 33499 RVA: 0x00158993 File Offset: 0x00156B93
		// (set) Token: 0x060082DC RID: 33500 RVA: 0x0015899B File Offset: 0x00156B9B
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

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x060082DD RID: 33501 RVA: 0x001589A4 File Offset: 0x00156BA4
		// (set) Token: 0x060082DE RID: 33502 RVA: 0x001589AC File Offset: 0x00156BAC
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

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x060082DF RID: 33503 RVA: 0x001589B5 File Offset: 0x00156BB5
		// (set) Token: 0x060082E0 RID: 33504 RVA: 0x001589BD File Offset: 0x00156BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double ACNAAGPOIME
		{
			get
			{
				return this.aCNAAGPOIME_;
			}
			set
			{
				this.aCNAAGPOIME_ = value;
			}
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x060082E1 RID: 33505 RVA: 0x001589C6 File Offset: 0x00156BC6
		// (set) Token: 0x060082E2 RID: 33506 RVA: 0x001589CE File Offset: 0x00156BCE
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

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x060082E3 RID: 33507 RVA: 0x001589D7 File Offset: 0x00156BD7
		// (set) Token: 0x060082E4 RID: 33508 RVA: 0x001589DF File Offset: 0x00156BDF
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

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x060082E5 RID: 33509 RVA: 0x001589E8 File Offset: 0x00156BE8
		// (set) Token: 0x060082E6 RID: 33510 RVA: 0x001589F0 File Offset: 0x00156BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleId
		{
			get
			{
				return this.battleId_;
			}
			set
			{
				this.battleId_ = value;
			}
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x060082E7 RID: 33511 RVA: 0x001589F9 File Offset: 0x00156BF9
		// (set) Token: 0x060082E8 RID: 33512 RVA: 0x00158A01 File Offset: 0x00156C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GEHICNBDNFP
		{
			get
			{
				return this.gEHICNBDNFP_;
			}
			set
			{
				this.gEHICNBDNFP_ = value;
			}
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x060082E9 RID: 33513 RVA: 0x00158A0A File Offset: 0x00156C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AttackDamageProperty> AttackTypeDamage
		{
			get
			{
				return this.attackTypeDamage_;
			}
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x060082EA RID: 33514 RVA: 0x00158A12 File Offset: 0x00156C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillUseProperty> SkillTimes
		{
			get
			{
				return this.skillTimes_;
			}
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x060082EB RID: 33515 RVA: 0x00158A1A File Offset: 0x00156C1A
		// (set) Token: 0x060082EC RID: 33516 RVA: 0x00158A22 File Offset: 0x00156C22
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

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x060082ED RID: 33517 RVA: 0x00158A2B File Offset: 0x00156C2B
		// (set) Token: 0x060082EE RID: 33518 RVA: 0x00158A33 File Offset: 0x00156C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double JGABGKLPPBA
		{
			get
			{
				return this.jGABGKLPPBA_;
			}
			set
			{
				this.jGABGKLPPBA_ = value;
			}
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x060082EF RID: 33519 RVA: 0x00158A3C File Offset: 0x00156C3C
		// (set) Token: 0x060082F0 RID: 33520 RVA: 0x00158A44 File Offset: 0x00156C44
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

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x060082F1 RID: 33521 RVA: 0x00158A4D File Offset: 0x00156C4D
		// (set) Token: 0x060082F2 RID: 33522 RVA: 0x00158A55 File Offset: 0x00156C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeathSource GCBMMMDLDKN
		{
			get
			{
				return this.gCBMMMDLDKN_;
			}
			set
			{
				this.gCBMMMDLDKN_ = value;
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x060082F3 RID: 33523 RVA: 0x00158A5E File Offset: 0x00156C5E
		// (set) Token: 0x060082F4 RID: 33524 RVA: 0x00158A66 File Offset: 0x00156C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Wave
		{
			get
			{
				return this.wave_;
			}
			set
			{
				this.wave_ = value;
			}
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x060082F5 RID: 33525 RVA: 0x00158A6F File Offset: 0x00156C6F
		// (set) Token: 0x060082F6 RID: 33526 RVA: 0x00158A77 File Offset: 0x00156C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BIDMILFDKIK
		{
			get
			{
				return this.bIDMILFDKIK_;
			}
			set
			{
				this.bIDMILFDKIK_ = value;
			}
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x060082F7 RID: 33527 RVA: 0x00158A80 File Offset: 0x00156C80
		// (set) Token: 0x060082F8 RID: 33528 RVA: 0x00158A88 File Offset: 0x00156C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Phase
		{
			get
			{
				return this.phase_;
			}
			set
			{
				this.phase_ = value;
			}
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x060082F9 RID: 33529 RVA: 0x00158A91 File Offset: 0x00156C91
		// (set) Token: 0x060082FA RID: 33530 RVA: 0x00158A99 File Offset: 0x00156C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DFJHDKKMPMM
		{
			get
			{
				return this.dFJHDKKMPMM_;
			}
			set
			{
				this.dFJHDKKMPMM_ = value;
			}
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x060082FB RID: 33531 RVA: 0x00158AA2 File Offset: 0x00156CA2
		// (set) Token: 0x060082FC RID: 33532 RVA: 0x00158AAA File Offset: 0x00156CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleTag MLCDMBECDJM
		{
			get
			{
				return this.mLCDMBECDJM_;
			}
			set
			{
				this.mLCDMBECDJM_ = value;
			}
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x060082FD RID: 33533 RVA: 0x00158AB3 File Offset: 0x00156CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PHKMLOMCNMN> SkillInfo
		{
			get
			{
				return this.skillInfo_;
			}
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x060082FE RID: 33534 RVA: 0x00158ABB File Offset: 0x00156CBB
		// (set) Token: 0x060082FF RID: 33535 RVA: 0x00158AC3 File Offset: 0x00156CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OKGKMLGGMDO
		{
			get
			{
				return this.oKGKMLGGMDO_;
			}
			set
			{
				this.oKGKMLGGMDO_ = value;
			}
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x06008300 RID: 33536 RVA: 0x00158ACC File Offset: 0x00156CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterPhaseStt> KEPDCEILLJF
		{
			get
			{
				return this.kEPDCEILLJF_;
			}
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x06008301 RID: 33537 RVA: 0x00158AD4 File Offset: 0x00156CD4
		// (set) Token: 0x06008302 RID: 33538 RVA: 0x00158ADC File Offset: 0x00156CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JGHNPEBHBDK
		{
			get
			{
				return this.jGHNPEBHBDK_;
			}
			set
			{
				this.jGHNPEBHBDK_ = value;
			}
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x06008303 RID: 33539 RVA: 0x00158AE5 File Offset: 0x00156CE5
		// (set) Token: 0x06008304 RID: 33540 RVA: 0x00158AED File Offset: 0x00156CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LANOIPJHKAC
		{
			get
			{
				return this.lANOIPJHKAC_;
			}
			set
			{
				this.lANOIPJHKAC_ = value;
			}
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x06008305 RID: 33541 RVA: 0x00158AF6 File Offset: 0x00156CF6
		// (set) Token: 0x06008306 RID: 33542 RVA: 0x00158AFE File Offset: 0x00156CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LBNOGHIMDMG AMLAAOLDKCL
		{
			get
			{
				return this.aMLAAOLDKCL_;
			}
			set
			{
				this.aMLAAOLDKCL_ = value;
			}
		}

		// Token: 0x06008307 RID: 33543 RVA: 0x00158B07 File Offset: 0x00156D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterBattleInfo);
		}

		// Token: 0x06008308 RID: 33544 RVA: 0x00158B18 File Offset: 0x00156D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterBattleInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.MonsterId == other.MonsterId && this.LGIOKJPJOFN == other.LGIOKJPJOFN && this.ODBNBKCDDPC == other.ODBNBKCDDPC && object.Equals(this.EMPDGGAALDC, other.EMPDGGAALDC) && this.TotalTurns == other.TotalTurns && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalDamage, other.TotalDamage) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalHeal, other.TotalHeal) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalDamageTaken, other.TotalDamageTaken) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.ACNAAGPOIME, other.ACNAAGPOIME) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalHpRecover, other.TotalHpRecover) && this.StageId == other.StageId && this.BattleId == other.BattleId && this.GEHICNBDNFP == other.GEHICNBDNFP && this.attackTypeDamage_.Equals(other.attackTypeDamage_) && this.skillTimes_.Equals(other.skillTimes_) && this.StageType == other.StageType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.JGABGKLPPBA, other.JGABGKLPPBA) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.DelayCumulate, other.DelayCumulate) && this.GCBMMMDLDKN == other.GCBMMMDLDKN && this.Wave == other.Wave && this.BIDMILFDKIK == other.BIDMILFDKIK && this.Phase == other.Phase && this.DFJHDKKMPMM == other.DFJHDKKMPMM && this.MLCDMBECDJM == other.MLCDMBECDJM && this.skillInfo_.Equals(other.skillInfo_) && this.OKGKMLGGMDO == other.OKGKMLGGMDO && this.kEPDCEILLJF_.Equals(other.kEPDCEILLJF_) && this.JGHNPEBHBDK == other.JGHNPEBHBDK && this.LANOIPJHKAC == other.LANOIPJHKAC && this.AMLAAOLDKCL == other.AMLAAOLDKCL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008309 RID: 33545 RVA: 0x00158D90 File Offset: 0x00156F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.LGIOKJPJOFN != 0U)
			{
				num ^= this.LGIOKJPJOFN.GetHashCode();
			}
			if (this.ODBNBKCDDPC != 0U)
			{
				num ^= this.ODBNBKCDDPC.GetHashCode();
			}
			if (this.eMPDGGAALDC_ != null)
			{
				num ^= this.EMPDGGAALDC.GetHashCode();
			}
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
			if (this.ACNAAGPOIME != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.ACNAAGPOIME);
			}
			if (this.TotalHpRecover != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalHpRecover);
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.BattleId != 0U)
			{
				num ^= this.BattleId.GetHashCode();
			}
			if (this.GEHICNBDNFP != 0U)
			{
				num ^= this.GEHICNBDNFP.GetHashCode();
			}
			num ^= this.attackTypeDamage_.GetHashCode();
			num ^= this.skillTimes_.GetHashCode();
			if (this.StageType != 0U)
			{
				num ^= this.StageType.GetHashCode();
			}
			if (this.JGABGKLPPBA != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.JGABGKLPPBA);
			}
			if (this.DelayCumulate != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.DelayCumulate);
			}
			if (this.GCBMMMDLDKN != DeathSource.Unknown)
			{
				num ^= this.GCBMMMDLDKN.GetHashCode();
			}
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.BIDMILFDKIK != 0)
			{
				num ^= this.BIDMILFDKIK.GetHashCode();
			}
			if (this.Phase != 0U)
			{
				num ^= this.Phase.GetHashCode();
			}
			if (this.DFJHDKKMPMM != 0U)
			{
				num ^= this.DFJHDKKMPMM.GetHashCode();
			}
			if (this.MLCDMBECDJM != BattleTag.TagNone)
			{
				num ^= this.MLCDMBECDJM.GetHashCode();
			}
			num ^= this.skillInfo_.GetHashCode();
			if (this.OKGKMLGGMDO != 0U)
			{
				num ^= this.OKGKMLGGMDO.GetHashCode();
			}
			num ^= this.kEPDCEILLJF_.GetHashCode();
			if (this.JGHNPEBHBDK != 0U)
			{
				num ^= this.JGHNPEBHBDK.GetHashCode();
			}
			if (this.LANOIPJHKAC != 0U)
			{
				num ^= this.LANOIPJHKAC.GetHashCode();
			}
			if (this.AMLAAOLDKCL != LBNOGHIMDMG.NormalCreate)
			{
				num ^= this.AMLAAOLDKCL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600830A RID: 33546 RVA: 0x001590EF File Offset: 0x001572EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600830B RID: 33547 RVA: 0x001590F7 File Offset: 0x001572F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600830C RID: 33548 RVA: 0x00159100 File Offset: 0x00157300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EntityId);
			}
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MonsterId);
			}
			if (this.LGIOKJPJOFN != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LGIOKJPJOFN);
			}
			if (this.ODBNBKCDDPC != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ODBNBKCDDPC);
			}
			if (this.eMPDGGAALDC_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.EMPDGGAALDC);
			}
			if (this.TotalTurns != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TotalTurns);
			}
			if (this.TotalDamage != 0.0)
			{
				output.WriteRawTag(57);
				output.WriteDouble(this.TotalDamage);
			}
			if (this.TotalHeal != 0.0)
			{
				output.WriteRawTag(65);
				output.WriteDouble(this.TotalHeal);
			}
			if (this.TotalDamageTaken != 0.0)
			{
				output.WriteRawTag(73);
				output.WriteDouble(this.TotalDamageTaken);
			}
			if (this.ACNAAGPOIME != 0.0)
			{
				output.WriteRawTag(81);
				output.WriteDouble(this.ACNAAGPOIME);
			}
			if (this.TotalHpRecover != 0.0)
			{
				output.WriteRawTag(89);
				output.WriteDouble(this.TotalHpRecover);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.StageId);
			}
			if (this.BattleId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BattleId);
			}
			if (this.GEHICNBDNFP != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GEHICNBDNFP);
			}
			this.attackTypeDamage_.WriteTo(ref output, MonsterBattleInfo._repeated_attackTypeDamage_codec);
			this.skillTimes_.WriteTo(ref output, MonsterBattleInfo._repeated_skillTimes_codec);
			if (this.StageType != 0U)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.StageType);
			}
			if (this.JGABGKLPPBA != 0.0)
			{
				output.WriteRawTag(145, 1);
				output.WriteDouble(this.JGABGKLPPBA);
			}
			if (this.DelayCumulate != 0.0)
			{
				output.WriteRawTag(153, 1);
				output.WriteDouble(this.DelayCumulate);
			}
			if (this.GCBMMMDLDKN != DeathSource.Unknown)
			{
				output.WriteRawTag(160, 1);
				output.WriteEnum((int)this.GCBMMMDLDKN);
			}
			if (this.Wave != 0U)
			{
				output.WriteRawTag(168, 1);
				output.WriteUInt32(this.Wave);
			}
			if (this.BIDMILFDKIK != 0)
			{
				output.WriteRawTag(176, 1);
				output.WriteInt32(this.BIDMILFDKIK);
			}
			if (this.Phase != 0U)
			{
				output.WriteRawTag(184, 1);
				output.WriteUInt32(this.Phase);
			}
			if (this.DFJHDKKMPMM != 0U)
			{
				output.WriteRawTag(192, 1);
				output.WriteUInt32(this.DFJHDKKMPMM);
			}
			if (this.MLCDMBECDJM != BattleTag.TagNone)
			{
				output.WriteRawTag(200, 1);
				output.WriteEnum((int)this.MLCDMBECDJM);
			}
			this.skillInfo_.WriteTo(ref output, MonsterBattleInfo._repeated_skillInfo_codec);
			if (this.OKGKMLGGMDO != 0U)
			{
				output.WriteRawTag(216, 1);
				output.WriteUInt32(this.OKGKMLGGMDO);
			}
			this.kEPDCEILLJF_.WriteTo(ref output, MonsterBattleInfo._repeated_kEPDCEILLJF_codec);
			if (this.JGHNPEBHBDK != 0U)
			{
				output.WriteRawTag(232, 1);
				output.WriteUInt32(this.JGHNPEBHBDK);
			}
			if (this.LANOIPJHKAC != 0U)
			{
				output.WriteRawTag(240, 1);
				output.WriteUInt32(this.LANOIPJHKAC);
			}
			if (this.AMLAAOLDKCL != LBNOGHIMDMG.NormalCreate)
			{
				output.WriteRawTag(248, 1);
				output.WriteEnum((int)this.AMLAAOLDKCL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600830D RID: 33549 RVA: 0x001594CC File Offset: 0x001576CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this.LGIOKJPJOFN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LGIOKJPJOFN);
			}
			if (this.ODBNBKCDDPC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ODBNBKCDDPC);
			}
			if (this.eMPDGGAALDC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EMPDGGAALDC);
			}
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
			if (this.ACNAAGPOIME != 0.0)
			{
				num += 9;
			}
			if (this.TotalHpRecover != 0.0)
			{
				num += 9;
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.BattleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleId);
			}
			if (this.GEHICNBDNFP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GEHICNBDNFP);
			}
			num += this.attackTypeDamage_.CalculateSize(MonsterBattleInfo._repeated_attackTypeDamage_codec);
			num += this.skillTimes_.CalculateSize(MonsterBattleInfo._repeated_skillTimes_codec);
			if (this.StageType != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.StageType);
			}
			if (this.JGABGKLPPBA != 0.0)
			{
				num += 10;
			}
			if (this.DelayCumulate != 0.0)
			{
				num += 10;
			}
			if (this.GCBMMMDLDKN != DeathSource.Unknown)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.GCBMMMDLDKN);
			}
			if (this.Wave != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this.BIDMILFDKIK != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BIDMILFDKIK);
			}
			if (this.Phase != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.Phase);
			}
			if (this.DFJHDKKMPMM != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.DFJHDKKMPMM);
			}
			if (this.MLCDMBECDJM != BattleTag.TagNone)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.MLCDMBECDJM);
			}
			num += this.skillInfo_.CalculateSize(MonsterBattleInfo._repeated_skillInfo_codec);
			if (this.OKGKMLGGMDO != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.OKGKMLGGMDO);
			}
			num += this.kEPDCEILLJF_.CalculateSize(MonsterBattleInfo._repeated_kEPDCEILLJF_codec);
			if (this.JGHNPEBHBDK != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.JGHNPEBHBDK);
			}
			if (this.LANOIPJHKAC != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LANOIPJHKAC);
			}
			if (this.AMLAAOLDKCL != LBNOGHIMDMG.NormalCreate)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.AMLAAOLDKCL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600830E RID: 33550 RVA: 0x001597B8 File Offset: 0x001579B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterBattleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.LGIOKJPJOFN != 0U)
			{
				this.LGIOKJPJOFN = other.LGIOKJPJOFN;
			}
			if (other.ODBNBKCDDPC != 0U)
			{
				this.ODBNBKCDDPC = other.ODBNBKCDDPC;
			}
			if (other.eMPDGGAALDC_ != null)
			{
				if (this.eMPDGGAALDC_ == null)
				{
					this.EMPDGGAALDC = new MonsterProperty();
				}
				this.EMPDGGAALDC.MergeFrom(other.EMPDGGAALDC);
			}
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
			if (other.ACNAAGPOIME != 0.0)
			{
				this.ACNAAGPOIME = other.ACNAAGPOIME;
			}
			if (other.TotalHpRecover != 0.0)
			{
				this.TotalHpRecover = other.TotalHpRecover;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.BattleId != 0U)
			{
				this.BattleId = other.BattleId;
			}
			if (other.GEHICNBDNFP != 0U)
			{
				this.GEHICNBDNFP = other.GEHICNBDNFP;
			}
			this.attackTypeDamage_.Add(other.attackTypeDamage_);
			this.skillTimes_.Add(other.skillTimes_);
			if (other.StageType != 0U)
			{
				this.StageType = other.StageType;
			}
			if (other.JGABGKLPPBA != 0.0)
			{
				this.JGABGKLPPBA = other.JGABGKLPPBA;
			}
			if (other.DelayCumulate != 0.0)
			{
				this.DelayCumulate = other.DelayCumulate;
			}
			if (other.GCBMMMDLDKN != DeathSource.Unknown)
			{
				this.GCBMMMDLDKN = other.GCBMMMDLDKN;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			if (other.BIDMILFDKIK != 0)
			{
				this.BIDMILFDKIK = other.BIDMILFDKIK;
			}
			if (other.Phase != 0U)
			{
				this.Phase = other.Phase;
			}
			if (other.DFJHDKKMPMM != 0U)
			{
				this.DFJHDKKMPMM = other.DFJHDKKMPMM;
			}
			if (other.MLCDMBECDJM != BattleTag.TagNone)
			{
				this.MLCDMBECDJM = other.MLCDMBECDJM;
			}
			this.skillInfo_.Add(other.skillInfo_);
			if (other.OKGKMLGGMDO != 0U)
			{
				this.OKGKMLGGMDO = other.OKGKMLGGMDO;
			}
			this.kEPDCEILLJF_.Add(other.kEPDCEILLJF_);
			if (other.JGHNPEBHBDK != 0U)
			{
				this.JGHNPEBHBDK = other.JGHNPEBHBDK;
			}
			if (other.LANOIPJHKAC != 0U)
			{
				this.LANOIPJHKAC = other.LANOIPJHKAC;
			}
			if (other.AMLAAOLDKCL != LBNOGHIMDMG.NormalCreate)
			{
				this.AMLAAOLDKCL = other.AMLAAOLDKCL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600830F RID: 33551 RVA: 0x00159A97 File Offset: 0x00157C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008310 RID: 33552 RVA: 0x00159AA0 File Offset: 0x00157CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 122U)
				{
					if (num <= 57U)
					{
						if (num <= 24U)
						{
							if (num == 8U)
							{
								this.EntityId = input.ReadUInt32();
								continue;
							}
							if (num == 16U)
							{
								this.MonsterId = input.ReadUInt32();
								continue;
							}
							if (num == 24U)
							{
								this.LGIOKJPJOFN = input.ReadUInt32();
								continue;
							}
						}
						else if (num <= 42U)
						{
							if (num == 32U)
							{
								this.ODBNBKCDDPC = input.ReadUInt32();
								continue;
							}
							if (num == 42U)
							{
								if (this.eMPDGGAALDC_ == null)
								{
									this.EMPDGGAALDC = new MonsterProperty();
								}
								input.ReadMessage(this.EMPDGGAALDC);
								continue;
							}
						}
						else
						{
							if (num == 48U)
							{
								this.TotalTurns = input.ReadUInt32();
								continue;
							}
							if (num == 57U)
							{
								this.TotalDamage = input.ReadDouble();
								continue;
							}
						}
					}
					else if (num <= 89U)
					{
						if (num <= 73U)
						{
							if (num == 65U)
							{
								this.TotalHeal = input.ReadDouble();
								continue;
							}
							if (num == 73U)
							{
								this.TotalDamageTaken = input.ReadDouble();
								continue;
							}
						}
						else
						{
							if (num == 81U)
							{
								this.ACNAAGPOIME = input.ReadDouble();
								continue;
							}
							if (num == 89U)
							{
								this.TotalHpRecover = input.ReadDouble();
								continue;
							}
						}
					}
					else if (num <= 104U)
					{
						if (num == 96U)
						{
							this.StageId = input.ReadUInt32();
							continue;
						}
						if (num == 104U)
						{
							this.BattleId = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 112U)
						{
							this.GEHICNBDNFP = input.ReadUInt32();
							continue;
						}
						if (num == 122U)
						{
							this.attackTypeDamage_.AddEntriesFrom(ref input, MonsterBattleInfo._repeated_attackTypeDamage_codec);
							continue;
						}
					}
				}
				else if (num <= 184U)
				{
					if (num <= 153U)
					{
						if (num <= 136U)
						{
							if (num == 130U)
							{
								this.skillTimes_.AddEntriesFrom(ref input, MonsterBattleInfo._repeated_skillTimes_codec);
								continue;
							}
							if (num == 136U)
							{
								this.StageType = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 145U)
							{
								this.JGABGKLPPBA = input.ReadDouble();
								continue;
							}
							if (num == 153U)
							{
								this.DelayCumulate = input.ReadDouble();
								continue;
							}
						}
					}
					else if (num <= 168U)
					{
						if (num == 160U)
						{
							this.GCBMMMDLDKN = (DeathSource)input.ReadEnum();
							continue;
						}
						if (num == 168U)
						{
							this.Wave = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 176U)
						{
							this.BIDMILFDKIK = input.ReadInt32();
							continue;
						}
						if (num == 184U)
						{
							this.Phase = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 216U)
				{
					if (num <= 200U)
					{
						if (num == 192U)
						{
							this.DFJHDKKMPMM = input.ReadUInt32();
							continue;
						}
						if (num == 200U)
						{
							this.MLCDMBECDJM = (BattleTag)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 210U)
						{
							this.skillInfo_.AddEntriesFrom(ref input, MonsterBattleInfo._repeated_skillInfo_codec);
							continue;
						}
						if (num == 216U)
						{
							this.OKGKMLGGMDO = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 232U)
				{
					if (num == 226U)
					{
						this.kEPDCEILLJF_.AddEntriesFrom(ref input, MonsterBattleInfo._repeated_kEPDCEILLJF_codec);
						continue;
					}
					if (num == 232U)
					{
						this.JGHNPEBHBDK = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 240U)
					{
						this.LANOIPJHKAC = input.ReadUInt32();
						continue;
					}
					if (num == 248U)
					{
						this.AMLAAOLDKCL = (LBNOGHIMDMG)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031D8 RID: 12760
		private static readonly MessageParser<MonsterBattleInfo> _parser = new MessageParser<MonsterBattleInfo>(() => new MonsterBattleInfo());

		// Token: 0x040031D9 RID: 12761
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031DA RID: 12762
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040031DB RID: 12763
		private uint entityId_;

		// Token: 0x040031DC RID: 12764
		public const int MonsterIdFieldNumber = 2;

		// Token: 0x040031DD RID: 12765
		private uint monsterId_;

		// Token: 0x040031DE RID: 12766
		public const int LGIOKJPJOFNFieldNumber = 3;

		// Token: 0x040031DF RID: 12767
		private uint lGIOKJPJOFN_;

		// Token: 0x040031E0 RID: 12768
		public const int ODBNBKCDDPCFieldNumber = 4;

		// Token: 0x040031E1 RID: 12769
		private uint oDBNBKCDDPC_;

		// Token: 0x040031E2 RID: 12770
		public const int EMPDGGAALDCFieldNumber = 5;

		// Token: 0x040031E3 RID: 12771
		private MonsterProperty eMPDGGAALDC_;

		// Token: 0x040031E4 RID: 12772
		public const int TotalTurnsFieldNumber = 6;

		// Token: 0x040031E5 RID: 12773
		private uint totalTurns_;

		// Token: 0x040031E6 RID: 12774
		public const int TotalDamageFieldNumber = 7;

		// Token: 0x040031E7 RID: 12775
		private double totalDamage_;

		// Token: 0x040031E8 RID: 12776
		public const int TotalHealFieldNumber = 8;

		// Token: 0x040031E9 RID: 12777
		private double totalHeal_;

		// Token: 0x040031EA RID: 12778
		public const int TotalDamageTakenFieldNumber = 9;

		// Token: 0x040031EB RID: 12779
		private double totalDamageTaken_;

		// Token: 0x040031EC RID: 12780
		public const int ACNAAGPOIMEFieldNumber = 10;

		// Token: 0x040031ED RID: 12781
		private double aCNAAGPOIME_;

		// Token: 0x040031EE RID: 12782
		public const int TotalHpRecoverFieldNumber = 11;

		// Token: 0x040031EF RID: 12783
		private double totalHpRecover_;

		// Token: 0x040031F0 RID: 12784
		public const int StageIdFieldNumber = 12;

		// Token: 0x040031F1 RID: 12785
		private uint stageId_;

		// Token: 0x040031F2 RID: 12786
		public const int BattleIdFieldNumber = 13;

		// Token: 0x040031F3 RID: 12787
		private uint battleId_;

		// Token: 0x040031F4 RID: 12788
		public const int GEHICNBDNFPFieldNumber = 14;

		// Token: 0x040031F5 RID: 12789
		private uint gEHICNBDNFP_;

		// Token: 0x040031F6 RID: 12790
		public const int AttackTypeDamageFieldNumber = 15;

		// Token: 0x040031F7 RID: 12791
		private static readonly FieldCodec<AttackDamageProperty> _repeated_attackTypeDamage_codec = FieldCodec.ForMessage<AttackDamageProperty>(122U, AttackDamageProperty.Parser);

		// Token: 0x040031F8 RID: 12792
		private readonly RepeatedField<AttackDamageProperty> attackTypeDamage_ = new RepeatedField<AttackDamageProperty>();

		// Token: 0x040031F9 RID: 12793
		public const int SkillTimesFieldNumber = 16;

		// Token: 0x040031FA RID: 12794
		private static readonly FieldCodec<SkillUseProperty> _repeated_skillTimes_codec = FieldCodec.ForMessage<SkillUseProperty>(130U, SkillUseProperty.Parser);

		// Token: 0x040031FB RID: 12795
		private readonly RepeatedField<SkillUseProperty> skillTimes_ = new RepeatedField<SkillUseProperty>();

		// Token: 0x040031FC RID: 12796
		public const int StageTypeFieldNumber = 17;

		// Token: 0x040031FD RID: 12797
		private uint stageType_;

		// Token: 0x040031FE RID: 12798
		public const int JGABGKLPPBAFieldNumber = 18;

		// Token: 0x040031FF RID: 12799
		private double jGABGKLPPBA_;

		// Token: 0x04003200 RID: 12800
		public const int DelayCumulateFieldNumber = 19;

		// Token: 0x04003201 RID: 12801
		private double delayCumulate_;

		// Token: 0x04003202 RID: 12802
		public const int GCBMMMDLDKNFieldNumber = 20;

		// Token: 0x04003203 RID: 12803
		private DeathSource gCBMMMDLDKN_;

		// Token: 0x04003204 RID: 12804
		public const int WaveFieldNumber = 21;

		// Token: 0x04003205 RID: 12805
		private uint wave_;

		// Token: 0x04003206 RID: 12806
		public const int BIDMILFDKIKFieldNumber = 22;

		// Token: 0x04003207 RID: 12807
		private int bIDMILFDKIK_;

		// Token: 0x04003208 RID: 12808
		public const int PhaseFieldNumber = 23;

		// Token: 0x04003209 RID: 12809
		private uint phase_;

		// Token: 0x0400320A RID: 12810
		public const int DFJHDKKMPMMFieldNumber = 24;

		// Token: 0x0400320B RID: 12811
		private uint dFJHDKKMPMM_;

		// Token: 0x0400320C RID: 12812
		public const int MLCDMBECDJMFieldNumber = 25;

		// Token: 0x0400320D RID: 12813
		private BattleTag mLCDMBECDJM_;

		// Token: 0x0400320E RID: 12814
		public const int SkillInfoFieldNumber = 26;

		// Token: 0x0400320F RID: 12815
		private static readonly FieldCodec<PHKMLOMCNMN> _repeated_skillInfo_codec = FieldCodec.ForMessage<PHKMLOMCNMN>(210U, PHKMLOMCNMN.Parser);

		// Token: 0x04003210 RID: 12816
		private readonly RepeatedField<PHKMLOMCNMN> skillInfo_ = new RepeatedField<PHKMLOMCNMN>();

		// Token: 0x04003211 RID: 12817
		public const int OKGKMLGGMDOFieldNumber = 27;

		// Token: 0x04003212 RID: 12818
		private uint oKGKMLGGMDO_;

		// Token: 0x04003213 RID: 12819
		public const int KEPDCEILLJFFieldNumber = 28;

		// Token: 0x04003214 RID: 12820
		private static readonly FieldCodec<MonsterPhaseStt> _repeated_kEPDCEILLJF_codec = FieldCodec.ForMessage<MonsterPhaseStt>(226U, MonsterPhaseStt.Parser);

		// Token: 0x04003215 RID: 12821
		private readonly RepeatedField<MonsterPhaseStt> kEPDCEILLJF_ = new RepeatedField<MonsterPhaseStt>();

		// Token: 0x04003216 RID: 12822
		public const int JGHNPEBHBDKFieldNumber = 29;

		// Token: 0x04003217 RID: 12823
		private uint jGHNPEBHBDK_;

		// Token: 0x04003218 RID: 12824
		public const int LANOIPJHKACFieldNumber = 30;

		// Token: 0x04003219 RID: 12825
		private uint lANOIPJHKAC_;

		// Token: 0x0400321A RID: 12826
		public const int AMLAAOLDKCLFieldNumber = 31;

		// Token: 0x0400321B RID: 12827
		private LBNOGHIMDMG aMLAAOLDKCL_;
	}
}
