using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200049F RID: 1183
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildBattleInfo : IMessage<EvolveBuildBattleInfo>, IMessage, IEquatable<EvolveBuildBattleInfo>, IDeepCloneable<EvolveBuildBattleInfo>, IBufferMessage
	{
		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x060034B5 RID: 13493 RVA: 0x00090C1D File Offset: 0x0008EE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildBattleInfo> Parser
		{
			get
			{
				return EvolveBuildBattleInfo._parser;
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x00090C24 File Offset: 0x0008EE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildBattleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x060034B7 RID: 13495 RVA: 0x00090C36 File Offset: 0x0008EE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildBattleInfo.Descriptor;
			}
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00090C40 File Offset: 0x0008EE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildBattleInfo()
		{
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00090CAC File Offset: 0x0008EEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildBattleInfo(EvolveBuildBattleInfo other) : this()
		{
			this.curLevelId_ = other.curLevelId_;
			this.curPeriod_ = other.curPeriod_;
			this.curCoin_ = other.curCoin_;
			this.weaponSlotList_ = other.weaponSlotList_.Clone();
			this.accessorySlotList_ = other.accessorySlotList_.Clone();
			this.banGearList_ = other.banGearList_.Clone();
			this.collection_ = ((other.collection_ != null) ? other.collection_.Clone() : null);
			this.allowedGearList_ = other.allowedGearList_.Clone();
			this.curExp_ = other.curExp_;
			this.curReroll_ = other.curReroll_;
			this.curTreasureMissCnt_ = other.curTreasureMissCnt_;
			this.periodIdList_ = other.periodIdList_.Clone();
			this.curGearLostCnt_ = other.curGearLostCnt_;
			this.curWave_ = other.curWave_;
			this.isUnlockGearReroll_ = other.isUnlockGearReroll_;
			this.isUnlockGearBan_ = other.isUnlockGearBan_;
			this.cardList_ = other.cardList_.Clone();
			this.gearDamageList_ = other.gearDamageList_.Clone();
			this.statParams_ = other.statParams_.Clone();
			this.isGiveup_ = other.isGiveup_;
			this.curUnusedRoundCnt_ = other.curUnusedRoundCnt_;
			this.statLogInfo_ = ((other.statLogInfo_ != null) ? other.statLogInfo_.Clone() : null);
			this.periodFirstRandomSeed_ = other.periodFirstRandomSeed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00090E2C File Offset: 0x0008F02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildBattleInfo Clone()
		{
			return new EvolveBuildBattleInfo(this);
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x060034BB RID: 13499 RVA: 0x00090E34 File Offset: 0x0008F034
		// (set) Token: 0x060034BC RID: 13500 RVA: 0x00090E3C File Offset: 0x0008F03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurLevelId
		{
			get
			{
				return this.curLevelId_;
			}
			set
			{
				this.curLevelId_ = value;
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x00090E45 File Offset: 0x0008F045
		// (set) Token: 0x060034BE RID: 13502 RVA: 0x00090E4D File Offset: 0x0008F04D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurPeriod
		{
			get
			{
				return this.curPeriod_;
			}
			set
			{
				this.curPeriod_ = value;
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x060034BF RID: 13503 RVA: 0x00090E56 File Offset: 0x0008F056
		// (set) Token: 0x060034C0 RID: 13504 RVA: 0x00090E5E File Offset: 0x0008F05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurCoin
		{
			get
			{
				return this.curCoin_;
			}
			set
			{
				this.curCoin_ = value;
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x060034C1 RID: 13505 RVA: 0x00090E67 File Offset: 0x0008F067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HHPPNNGGPIA> WeaponSlotList
		{
			get
			{
				return this.weaponSlotList_;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x00090E6F File Offset: 0x0008F06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HHPPNNGGPIA> AccessorySlotList
		{
			get
			{
				return this.accessorySlotList_;
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x060034C3 RID: 13507 RVA: 0x00090E77 File Offset: 0x0008F077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BanGearList
		{
			get
			{
				return this.banGearList_;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x00090E7F File Offset: 0x0008F07F
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x00090E87 File Offset: 0x0008F087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FEPIAGGKNKN Collection
		{
			get
			{
				return this.collection_;
			}
			set
			{
				this.collection_ = value;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x00090E90 File Offset: 0x0008F090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AllowedGearList
		{
			get
			{
				return this.allowedGearList_;
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x060034C7 RID: 13511 RVA: 0x00090E98 File Offset: 0x0008F098
		// (set) Token: 0x060034C8 RID: 13512 RVA: 0x00090EA0 File Offset: 0x0008F0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurExp
		{
			get
			{
				return this.curExp_;
			}
			set
			{
				this.curExp_ = value;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x060034C9 RID: 13513 RVA: 0x00090EA9 File Offset: 0x0008F0A9
		// (set) Token: 0x060034CA RID: 13514 RVA: 0x00090EB1 File Offset: 0x0008F0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurReroll
		{
			get
			{
				return this.curReroll_;
			}
			set
			{
				this.curReroll_ = value;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x060034CB RID: 13515 RVA: 0x00090EBA File Offset: 0x0008F0BA
		// (set) Token: 0x060034CC RID: 13516 RVA: 0x00090EC2 File Offset: 0x0008F0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurTreasureMissCnt
		{
			get
			{
				return this.curTreasureMissCnt_;
			}
			set
			{
				this.curTreasureMissCnt_ = value;
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x00090ECB File Offset: 0x0008F0CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PeriodIdList
		{
			get
			{
				return this.periodIdList_;
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x060034CE RID: 13518 RVA: 0x00090ED3 File Offset: 0x0008F0D3
		// (set) Token: 0x060034CF RID: 13519 RVA: 0x00090EDB File Offset: 0x0008F0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurGearLostCnt
		{
			get
			{
				return this.curGearLostCnt_;
			}
			set
			{
				this.curGearLostCnt_ = value;
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x060034D0 RID: 13520 RVA: 0x00090EE4 File Offset: 0x0008F0E4
		// (set) Token: 0x060034D1 RID: 13521 RVA: 0x00090EEC File Offset: 0x0008F0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurWave
		{
			get
			{
				return this.curWave_;
			}
			set
			{
				this.curWave_ = value;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x060034D2 RID: 13522 RVA: 0x00090EF5 File Offset: 0x0008F0F5
		// (set) Token: 0x060034D3 RID: 13523 RVA: 0x00090EFD File Offset: 0x0008F0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlockGearReroll
		{
			get
			{
				return this.isUnlockGearReroll_;
			}
			set
			{
				this.isUnlockGearReroll_ = value;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x060034D4 RID: 13524 RVA: 0x00090F06 File Offset: 0x0008F106
		// (set) Token: 0x060034D5 RID: 13525 RVA: 0x00090F0E File Offset: 0x0008F10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlockGearBan
		{
			get
			{
				return this.isUnlockGearBan_;
			}
			set
			{
				this.isUnlockGearBan_ = value;
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x060034D6 RID: 13526 RVA: 0x00090F17 File Offset: 0x0008F117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LCLJMJAFHOE> CardList
		{
			get
			{
				return this.cardList_;
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x060034D7 RID: 13527 RVA: 0x00090F1F File Offset: 0x0008F11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EvolveBuildGearDamageInfo> GearDamageList
		{
			get
			{
				return this.gearDamageList_;
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x00090F27 File Offset: 0x0008F127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> StatParams
		{
			get
			{
				return this.statParams_;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x00090F2F File Offset: 0x0008F12F
		// (set) Token: 0x060034DA RID: 13530 RVA: 0x00090F37 File Offset: 0x0008F137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsGiveup
		{
			get
			{
				return this.isGiveup_;
			}
			set
			{
				this.isGiveup_ = value;
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x00090F40 File Offset: 0x0008F140
		// (set) Token: 0x060034DC RID: 13532 RVA: 0x00090F48 File Offset: 0x0008F148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurUnusedRoundCnt
		{
			get
			{
				return this.curUnusedRoundCnt_;
			}
			set
			{
				this.curUnusedRoundCnt_ = value;
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x00090F51 File Offset: 0x0008F151
		// (set) Token: 0x060034DE RID: 13534 RVA: 0x00090F59 File Offset: 0x0008F159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BBDFLCJIEEJ StatLogInfo
		{
			get
			{
				return this.statLogInfo_;
			}
			set
			{
				this.statLogInfo_ = value;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x060034DF RID: 13535 RVA: 0x00090F62 File Offset: 0x0008F162
		// (set) Token: 0x060034E0 RID: 13536 RVA: 0x00090F6A File Offset: 0x0008F16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PeriodFirstRandomSeed
		{
			get
			{
				return this.periodFirstRandomSeed_;
			}
			set
			{
				this.periodFirstRandomSeed_ = value;
			}
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x00090F73 File Offset: 0x0008F173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildBattleInfo);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00090F84 File Offset: 0x0008F184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildBattleInfo other)
		{
			return other != null && (other == this || (this.CurLevelId == other.CurLevelId && this.CurPeriod == other.CurPeriod && this.CurCoin == other.CurCoin && this.weaponSlotList_.Equals(other.weaponSlotList_) && this.accessorySlotList_.Equals(other.accessorySlotList_) && this.banGearList_.Equals(other.banGearList_) && object.Equals(this.Collection, other.Collection) && this.allowedGearList_.Equals(other.allowedGearList_) && this.CurExp == other.CurExp && this.CurReroll == other.CurReroll && this.CurTreasureMissCnt == other.CurTreasureMissCnt && this.periodIdList_.Equals(other.periodIdList_) && this.CurGearLostCnt == other.CurGearLostCnt && this.CurWave == other.CurWave && this.IsUnlockGearReroll == other.IsUnlockGearReroll && this.IsUnlockGearBan == other.IsUnlockGearBan && this.cardList_.Equals(other.cardList_) && this.gearDamageList_.Equals(other.gearDamageList_) && this.statParams_.Equals(other.statParams_) && this.IsGiveup == other.IsGiveup && this.CurUnusedRoundCnt == other.CurUnusedRoundCnt && object.Equals(this.StatLogInfo, other.StatLogInfo) && this.PeriodFirstRandomSeed == other.PeriodFirstRandomSeed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00091150 File Offset: 0x0008F350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurLevelId != 0U)
			{
				num ^= this.CurLevelId.GetHashCode();
			}
			if (this.CurPeriod != 0U)
			{
				num ^= this.CurPeriod.GetHashCode();
			}
			if (this.CurCoin != 0U)
			{
				num ^= this.CurCoin.GetHashCode();
			}
			num ^= this.weaponSlotList_.GetHashCode();
			num ^= this.accessorySlotList_.GetHashCode();
			num ^= this.banGearList_.GetHashCode();
			if (this.collection_ != null)
			{
				num ^= this.Collection.GetHashCode();
			}
			num ^= this.allowedGearList_.GetHashCode();
			if (this.CurExp != 0U)
			{
				num ^= this.CurExp.GetHashCode();
			}
			if (this.CurReroll != 0U)
			{
				num ^= this.CurReroll.GetHashCode();
			}
			if (this.CurTreasureMissCnt != 0U)
			{
				num ^= this.CurTreasureMissCnt.GetHashCode();
			}
			num ^= this.periodIdList_.GetHashCode();
			if (this.CurGearLostCnt != 0U)
			{
				num ^= this.CurGearLostCnt.GetHashCode();
			}
			if (this.CurWave != 0U)
			{
				num ^= this.CurWave.GetHashCode();
			}
			if (this.IsUnlockGearReroll)
			{
				num ^= this.IsUnlockGearReroll.GetHashCode();
			}
			if (this.IsUnlockGearBan)
			{
				num ^= this.IsUnlockGearBan.GetHashCode();
			}
			num ^= this.cardList_.GetHashCode();
			num ^= this.gearDamageList_.GetHashCode();
			num ^= this.statParams_.GetHashCode();
			if (this.IsGiveup)
			{
				num ^= this.IsGiveup.GetHashCode();
			}
			if (this.CurUnusedRoundCnt != 0U)
			{
				num ^= this.CurUnusedRoundCnt.GetHashCode();
			}
			if (this.statLogInfo_ != null)
			{
				num ^= this.StatLogInfo.GetHashCode();
			}
			if (this.PeriodFirstRandomSeed != 0U)
			{
				num ^= this.PeriodFirstRandomSeed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00091357 File Offset: 0x0008F557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x0009135F File Offset: 0x0008F55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00091368 File Offset: 0x0008F568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurLevelId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CurLevelId);
			}
			if (this.CurPeriod != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CurPeriod);
			}
			if (this.CurCoin != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CurCoin);
			}
			this.weaponSlotList_.WriteTo(ref output, EvolveBuildBattleInfo._repeated_weaponSlotList_codec);
			this.accessorySlotList_.WriteTo(ref output, EvolveBuildBattleInfo._repeated_accessorySlotList_codec);
			this.banGearList_.WriteTo(ref output, EvolveBuildBattleInfo._repeated_banGearList_codec);
			if (this.collection_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Collection);
			}
			this.allowedGearList_.WriteTo(ref output, EvolveBuildBattleInfo._repeated_allowedGearList_codec);
			if (this.CurExp != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CurExp);
			}
			if (this.CurReroll != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CurReroll);
			}
			if (this.CurTreasureMissCnt != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CurTreasureMissCnt);
			}
			this.periodIdList_.WriteTo(ref output, EvolveBuildBattleInfo._repeated_periodIdList_codec);
			if (this.CurGearLostCnt != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.CurGearLostCnt);
			}
			if (this.CurWave != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.CurWave);
			}
			if (this.IsUnlockGearReroll)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsUnlockGearReroll);
			}
			if (this.IsUnlockGearBan)
			{
				output.WriteRawTag(128, 1);
				output.WriteBool(this.IsUnlockGearBan);
			}
			this.cardList_.WriteTo(ref output, EvolveBuildBattleInfo._repeated_cardList_codec);
			this.gearDamageList_.WriteTo(ref output, EvolveBuildBattleInfo._repeated_gearDamageList_codec);
			this.statParams_.WriteTo(ref output, EvolveBuildBattleInfo._repeated_statParams_codec);
			if (this.IsGiveup)
			{
				output.WriteRawTag(160, 1);
				output.WriteBool(this.IsGiveup);
			}
			if (this.CurUnusedRoundCnt != 0U)
			{
				output.WriteRawTag(168, 1);
				output.WriteUInt32(this.CurUnusedRoundCnt);
			}
			if (this.statLogInfo_ != null)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.StatLogInfo);
			}
			if (this.PeriodFirstRandomSeed != 0U)
			{
				output.WriteRawTag(184, 1);
				output.WriteUInt32(this.PeriodFirstRandomSeed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x000915C8 File Offset: 0x0008F7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurLevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurLevelId);
			}
			if (this.CurPeriod != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurPeriod);
			}
			if (this.CurCoin != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurCoin);
			}
			num += this.weaponSlotList_.CalculateSize(EvolveBuildBattleInfo._repeated_weaponSlotList_codec);
			num += this.accessorySlotList_.CalculateSize(EvolveBuildBattleInfo._repeated_accessorySlotList_codec);
			num += this.banGearList_.CalculateSize(EvolveBuildBattleInfo._repeated_banGearList_codec);
			if (this.collection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Collection);
			}
			num += this.allowedGearList_.CalculateSize(EvolveBuildBattleInfo._repeated_allowedGearList_codec);
			if (this.CurExp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurExp);
			}
			if (this.CurReroll != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurReroll);
			}
			if (this.CurTreasureMissCnt != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurTreasureMissCnt);
			}
			num += this.periodIdList_.CalculateSize(EvolveBuildBattleInfo._repeated_periodIdList_codec);
			if (this.CurGearLostCnt != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurGearLostCnt);
			}
			if (this.CurWave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurWave);
			}
			if (this.IsUnlockGearReroll)
			{
				num += 2;
			}
			if (this.IsUnlockGearBan)
			{
				num += 3;
			}
			num += this.cardList_.CalculateSize(EvolveBuildBattleInfo._repeated_cardList_codec);
			num += this.gearDamageList_.CalculateSize(EvolveBuildBattleInfo._repeated_gearDamageList_codec);
			num += this.statParams_.CalculateSize(EvolveBuildBattleInfo._repeated_statParams_codec);
			if (this.IsGiveup)
			{
				num += 3;
			}
			if (this.CurUnusedRoundCnt != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.CurUnusedRoundCnt);
			}
			if (this.statLogInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.StatLogInfo);
			}
			if (this.PeriodFirstRandomSeed != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.PeriodFirstRandomSeed);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x000917CC File Offset: 0x0008F9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildBattleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurLevelId != 0U)
			{
				this.CurLevelId = other.CurLevelId;
			}
			if (other.CurPeriod != 0U)
			{
				this.CurPeriod = other.CurPeriod;
			}
			if (other.CurCoin != 0U)
			{
				this.CurCoin = other.CurCoin;
			}
			this.weaponSlotList_.Add(other.weaponSlotList_);
			this.accessorySlotList_.Add(other.accessorySlotList_);
			this.banGearList_.Add(other.banGearList_);
			if (other.collection_ != null)
			{
				if (this.collection_ == null)
				{
					this.Collection = new FEPIAGGKNKN();
				}
				this.Collection.MergeFrom(other.Collection);
			}
			this.allowedGearList_.Add(other.allowedGearList_);
			if (other.CurExp != 0U)
			{
				this.CurExp = other.CurExp;
			}
			if (other.CurReroll != 0U)
			{
				this.CurReroll = other.CurReroll;
			}
			if (other.CurTreasureMissCnt != 0U)
			{
				this.CurTreasureMissCnt = other.CurTreasureMissCnt;
			}
			this.periodIdList_.Add(other.periodIdList_);
			if (other.CurGearLostCnt != 0U)
			{
				this.CurGearLostCnt = other.CurGearLostCnt;
			}
			if (other.CurWave != 0U)
			{
				this.CurWave = other.CurWave;
			}
			if (other.IsUnlockGearReroll)
			{
				this.IsUnlockGearReroll = other.IsUnlockGearReroll;
			}
			if (other.IsUnlockGearBan)
			{
				this.IsUnlockGearBan = other.IsUnlockGearBan;
			}
			this.cardList_.Add(other.cardList_);
			this.gearDamageList_.Add(other.gearDamageList_);
			this.statParams_.Add(other.statParams_);
			if (other.IsGiveup)
			{
				this.IsGiveup = other.IsGiveup;
			}
			if (other.CurUnusedRoundCnt != 0U)
			{
				this.CurUnusedRoundCnt = other.CurUnusedRoundCnt;
			}
			if (other.statLogInfo_ != null)
			{
				if (this.statLogInfo_ == null)
				{
					this.StatLogInfo = new BBDFLCJIEEJ();
				}
				this.StatLogInfo.MergeFrom(other.StatLogInfo);
			}
			if (other.PeriodFirstRandomSeed != 0U)
			{
				this.PeriodFirstRandomSeed = other.PeriodFirstRandomSeed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x000919D8 File Offset: 0x0008FBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x000919E4 File Offset: 0x0008FBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num > 48U)
					{
						if (num <= 64U)
						{
							if (num == 50U)
							{
								goto IL_1D1;
							}
							if (num == 58U)
							{
								if (this.collection_ == null)
								{
									this.Collection = new FEPIAGGKNKN();
								}
								input.ReadMessage(this.Collection);
								continue;
							}
							if (num != 64U)
							{
								goto IL_15B;
							}
						}
						else if (num <= 72U)
						{
							if (num != 66U)
							{
								if (num != 72U)
								{
									goto IL_15B;
								}
								this.CurExp = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 80U)
							{
								this.CurReroll = input.ReadUInt32();
								continue;
							}
							if (num != 88U)
							{
								goto IL_15B;
							}
							this.CurTreasureMissCnt = input.ReadUInt32();
							continue;
						}
						this.allowedGearList_.AddEntriesFrom(ref input, EvolveBuildBattleInfo._repeated_allowedGearList_codec);
						continue;
					}
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.CurLevelId = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.CurPeriod = input.ReadUInt32();
							continue;
						}
						if (num != 24U)
						{
							goto IL_15B;
						}
						this.CurCoin = input.ReadUInt32();
						continue;
					}
					else
					{
						if (num == 34U)
						{
							this.weaponSlotList_.AddEntriesFrom(ref input, EvolveBuildBattleInfo._repeated_weaponSlotList_codec);
							continue;
						}
						if (num == 42U)
						{
							this.accessorySlotList_.AddEntriesFrom(ref input, EvolveBuildBattleInfo._repeated_accessorySlotList_codec);
							continue;
						}
						if (num != 48U)
						{
							goto IL_15B;
						}
					}
					IL_1D1:
					this.banGearList_.AddEntriesFrom(ref input, EvolveBuildBattleInfo._repeated_banGearList_codec);
					continue;
				}
				if (num <= 138U)
				{
					if (num <= 104U)
					{
						if (num == 96U || num == 98U)
						{
							this.periodIdList_.AddEntriesFrom(ref input, EvolveBuildBattleInfo._repeated_periodIdList_codec);
							continue;
						}
						if (num == 104U)
						{
							this.CurGearLostCnt = input.ReadUInt32();
							continue;
						}
					}
					else if (num <= 120U)
					{
						if (num == 112U)
						{
							this.CurWave = input.ReadUInt32();
							continue;
						}
						if (num == 120U)
						{
							this.IsUnlockGearReroll = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 128U)
						{
							this.IsUnlockGearBan = input.ReadBool();
							continue;
						}
						if (num == 138U)
						{
							this.cardList_.AddEntriesFrom(ref input, EvolveBuildBattleInfo._repeated_cardList_codec);
							continue;
						}
					}
				}
				else if (num <= 154U)
				{
					if (num == 146U)
					{
						this.gearDamageList_.AddEntriesFrom(ref input, EvolveBuildBattleInfo._repeated_gearDamageList_codec);
						continue;
					}
					if (num == 152U || num == 154U)
					{
						this.statParams_.AddEntriesFrom(ref input, EvolveBuildBattleInfo._repeated_statParams_codec);
						continue;
					}
				}
				else if (num <= 168U)
				{
					if (num == 160U)
					{
						this.IsGiveup = input.ReadBool();
						continue;
					}
					if (num == 168U)
					{
						this.CurUnusedRoundCnt = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 178U)
					{
						if (this.statLogInfo_ == null)
						{
							this.StatLogInfo = new BBDFLCJIEEJ();
						}
						input.ReadMessage(this.StatLogInfo);
						continue;
					}
					if (num == 184U)
					{
						this.PeriodFirstRandomSeed = input.ReadUInt32();
						continue;
					}
				}
				IL_15B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040014EA RID: 5354
		private static readonly MessageParser<EvolveBuildBattleInfo> _parser = new MessageParser<EvolveBuildBattleInfo>(() => new EvolveBuildBattleInfo());

		// Token: 0x040014EB RID: 5355
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014EC RID: 5356
		public const int CurLevelIdFieldNumber = 1;

		// Token: 0x040014ED RID: 5357
		private uint curLevelId_;

		// Token: 0x040014EE RID: 5358
		public const int CurPeriodFieldNumber = 2;

		// Token: 0x040014EF RID: 5359
		private uint curPeriod_;

		// Token: 0x040014F0 RID: 5360
		public const int CurCoinFieldNumber = 3;

		// Token: 0x040014F1 RID: 5361
		private uint curCoin_;

		// Token: 0x040014F2 RID: 5362
		public const int WeaponSlotListFieldNumber = 4;

		// Token: 0x040014F3 RID: 5363
		private static readonly FieldCodec<HHPPNNGGPIA> _repeated_weaponSlotList_codec = FieldCodec.ForMessage<HHPPNNGGPIA>(34U, HHPPNNGGPIA.Parser);

		// Token: 0x040014F4 RID: 5364
		private readonly RepeatedField<HHPPNNGGPIA> weaponSlotList_ = new RepeatedField<HHPPNNGGPIA>();

		// Token: 0x040014F5 RID: 5365
		public const int AccessorySlotListFieldNumber = 5;

		// Token: 0x040014F6 RID: 5366
		private static readonly FieldCodec<HHPPNNGGPIA> _repeated_accessorySlotList_codec = FieldCodec.ForMessage<HHPPNNGGPIA>(42U, HHPPNNGGPIA.Parser);

		// Token: 0x040014F7 RID: 5367
		private readonly RepeatedField<HHPPNNGGPIA> accessorySlotList_ = new RepeatedField<HHPPNNGGPIA>();

		// Token: 0x040014F8 RID: 5368
		public const int BanGearListFieldNumber = 6;

		// Token: 0x040014F9 RID: 5369
		private static readonly FieldCodec<uint> _repeated_banGearList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x040014FA RID: 5370
		private readonly RepeatedField<uint> banGearList_ = new RepeatedField<uint>();

		// Token: 0x040014FB RID: 5371
		public const int CollectionFieldNumber = 7;

		// Token: 0x040014FC RID: 5372
		private FEPIAGGKNKN collection_;

		// Token: 0x040014FD RID: 5373
		public const int AllowedGearListFieldNumber = 8;

		// Token: 0x040014FE RID: 5374
		private static readonly FieldCodec<uint> _repeated_allowedGearList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x040014FF RID: 5375
		private readonly RepeatedField<uint> allowedGearList_ = new RepeatedField<uint>();

		// Token: 0x04001500 RID: 5376
		public const int CurExpFieldNumber = 9;

		// Token: 0x04001501 RID: 5377
		private uint curExp_;

		// Token: 0x04001502 RID: 5378
		public const int CurRerollFieldNumber = 10;

		// Token: 0x04001503 RID: 5379
		private uint curReroll_;

		// Token: 0x04001504 RID: 5380
		public const int CurTreasureMissCntFieldNumber = 11;

		// Token: 0x04001505 RID: 5381
		private uint curTreasureMissCnt_;

		// Token: 0x04001506 RID: 5382
		public const int PeriodIdListFieldNumber = 12;

		// Token: 0x04001507 RID: 5383
		private static readonly FieldCodec<uint> _repeated_periodIdList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04001508 RID: 5384
		private readonly RepeatedField<uint> periodIdList_ = new RepeatedField<uint>();

		// Token: 0x04001509 RID: 5385
		public const int CurGearLostCntFieldNumber = 13;

		// Token: 0x0400150A RID: 5386
		private uint curGearLostCnt_;

		// Token: 0x0400150B RID: 5387
		public const int CurWaveFieldNumber = 14;

		// Token: 0x0400150C RID: 5388
		private uint curWave_;

		// Token: 0x0400150D RID: 5389
		public const int IsUnlockGearRerollFieldNumber = 15;

		// Token: 0x0400150E RID: 5390
		private bool isUnlockGearReroll_;

		// Token: 0x0400150F RID: 5391
		public const int IsUnlockGearBanFieldNumber = 16;

		// Token: 0x04001510 RID: 5392
		private bool isUnlockGearBan_;

		// Token: 0x04001511 RID: 5393
		public const int CardListFieldNumber = 17;

		// Token: 0x04001512 RID: 5394
		private static readonly FieldCodec<LCLJMJAFHOE> _repeated_cardList_codec = FieldCodec.ForMessage<LCLJMJAFHOE>(138U, LCLJMJAFHOE.Parser);

		// Token: 0x04001513 RID: 5395
		private readonly RepeatedField<LCLJMJAFHOE> cardList_ = new RepeatedField<LCLJMJAFHOE>();

		// Token: 0x04001514 RID: 5396
		public const int GearDamageListFieldNumber = 18;

		// Token: 0x04001515 RID: 5397
		private static readonly FieldCodec<EvolveBuildGearDamageInfo> _repeated_gearDamageList_codec = FieldCodec.ForMessage<EvolveBuildGearDamageInfo>(146U, EvolveBuildGearDamageInfo.Parser);

		// Token: 0x04001516 RID: 5398
		private readonly RepeatedField<EvolveBuildGearDamageInfo> gearDamageList_ = new RepeatedField<EvolveBuildGearDamageInfo>();

		// Token: 0x04001517 RID: 5399
		public const int StatParamsFieldNumber = 19;

		// Token: 0x04001518 RID: 5400
		private static readonly FieldCodec<uint> _repeated_statParams_codec = FieldCodec.ForUInt32(154U);

		// Token: 0x04001519 RID: 5401
		private readonly RepeatedField<uint> statParams_ = new RepeatedField<uint>();

		// Token: 0x0400151A RID: 5402
		public const int IsGiveupFieldNumber = 20;

		// Token: 0x0400151B RID: 5403
		private bool isGiveup_;

		// Token: 0x0400151C RID: 5404
		public const int CurUnusedRoundCntFieldNumber = 21;

		// Token: 0x0400151D RID: 5405
		private uint curUnusedRoundCnt_;

		// Token: 0x0400151E RID: 5406
		public const int StatLogInfoFieldNumber = 22;

		// Token: 0x0400151F RID: 5407
		private BBDFLCJIEEJ statLogInfo_;

		// Token: 0x04001520 RID: 5408
		public const int PeriodFirstRandomSeedFieldNumber = 23;

		// Token: 0x04001521 RID: 5409
		private uint periodFirstRandomSeed_;
	}
}
