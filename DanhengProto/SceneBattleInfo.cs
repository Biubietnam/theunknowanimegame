using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200104F RID: 4175
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneBattleInfo : IMessage<SceneBattleInfo>, IMessage, IEquatable<SceneBattleInfo>, IDeepCloneable<SceneBattleInfo>, IBufferMessage
	{
		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600B9BD RID: 47549 RVA: 0x001F2A22 File Offset: 0x001F0C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneBattleInfo> Parser
		{
			get
			{
				return SceneBattleInfo._parser;
			}
		}

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600B9BE RID: 47550 RVA: 0x001F2A29 File Offset: 0x001F0C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneBattleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600B9BF RID: 47551 RVA: 0x001F2A3B File Offset: 0x001F0C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBattleInfo.Descriptor;
			}
		}

		// Token: 0x0600B9C0 RID: 47552 RVA: 0x001F2A42 File Offset: 0x001F0C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo()
		{
		}

		// Token: 0x0600B9C1 RID: 47553 RVA: 0x001F2A84 File Offset: 0x001F0C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo(SceneBattleInfo other) : this()
		{
			this.battleEvent_ = other.battleEvent_.Clone();
			this.battleAvatarList_ = other.battleAvatarList_.Clone();
			this.lKAHLGNIECF_ = other.lKAHLGNIECF_;
			this.logicRandomSeed_ = other.logicRandomSeed_;
			this.worldLevel_ = other.worldLevel_;
			this.oAHDOLHBPFK_ = ((other.oAHDOLHBPFK_ != null) ? other.oAHDOLHBPFK_.Clone() : null);
			this.monsterWaveList_ = other.monsterWaveList_.Clone();
			this.buffList_ = other.buffList_.Clone();
			this.battleId_ = other.battleId_;
			this.roundsLimit_ = other.roundsLimit_;
			this.gIOGKGLBACA_ = ((other.gIOGKGLBACA_ != null) ? other.gIOGKGLBACA_.Clone() : null);
			this.stageId_ = other.stageId_;
			this.battleRogueMagicInfo_ = ((other.battleRogueMagicInfo_ != null) ? other.battleRogueMagicInfo_.Clone() : null);
			this.cGOBLNLGCMO_ = ((other.cGOBLNLGCMO_ != null) ? other.cGOBLNLGCMO_.Clone() : null);
			this.battleTargetInfo_ = other.battleTargetInfo_.Clone();
			this.aFHKNCHFNLE_ = other.aFHKNCHFNLE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9C2 RID: 47554 RVA: 0x001F2BC1 File Offset: 0x001F0DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo Clone()
		{
			return new SceneBattleInfo(this);
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0600B9C3 RID: 47555 RVA: 0x001F2BC9 File Offset: 0x001F0DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleEventBattleInfo> BattleEvent
		{
			get
			{
				return this.battleEvent_;
			}
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0600B9C4 RID: 47556 RVA: 0x001F2BD1 File Offset: 0x001F0DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleAvatar> BattleAvatarList
		{
			get
			{
				return this.battleAvatarList_;
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0600B9C5 RID: 47557 RVA: 0x001F2BD9 File Offset: 0x001F0DD9
		// (set) Token: 0x0600B9C6 RID: 47558 RVA: 0x001F2BE1 File Offset: 0x001F0DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LKAHLGNIECF
		{
			get
			{
				return this.lKAHLGNIECF_;
			}
			set
			{
				this.lKAHLGNIECF_ = value;
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0600B9C7 RID: 47559 RVA: 0x001F2BEA File Offset: 0x001F0DEA
		// (set) Token: 0x0600B9C8 RID: 47560 RVA: 0x001F2BF2 File Offset: 0x001F0DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LogicRandomSeed
		{
			get
			{
				return this.logicRandomSeed_;
			}
			set
			{
				this.logicRandomSeed_ = value;
			}
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0600B9C9 RID: 47561 RVA: 0x001F2BFB File Offset: 0x001F0DFB
		// (set) Token: 0x0600B9CA RID: 47562 RVA: 0x001F2C03 File Offset: 0x001F0E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0600B9CB RID: 47563 RVA: 0x001F2C0C File Offset: 0x001F0E0C
		// (set) Token: 0x0600B9CC RID: 47564 RVA: 0x001F2C14 File Offset: 0x001F0E14
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

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0600B9CD RID: 47565 RVA: 0x001F2C1D File Offset: 0x001F0E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneMonsterWave> MonsterWaveList
		{
			get
			{
				return this.monsterWaveList_;
			}
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0600B9CE RID: 47566 RVA: 0x001F2C25 File Offset: 0x001F0E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleBuff> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0600B9CF RID: 47567 RVA: 0x001F2C2D File Offset: 0x001F0E2D
		// (set) Token: 0x0600B9D0 RID: 47568 RVA: 0x001F2C35 File Offset: 0x001F0E35
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

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0600B9D1 RID: 47569 RVA: 0x001F2C3E File Offset: 0x001F0E3E
		// (set) Token: 0x0600B9D2 RID: 47570 RVA: 0x001F2C46 File Offset: 0x001F0E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoundsLimit
		{
			get
			{
				return this.roundsLimit_;
			}
			set
			{
				this.roundsLimit_ = value;
			}
		}

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0600B9D3 RID: 47571 RVA: 0x001F2C4F File Offset: 0x001F0E4F
		// (set) Token: 0x0600B9D4 RID: 47572 RVA: 0x001F2C57 File Offset: 0x001F0E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPDPLEMGEFN GIOGKGLBACA
		{
			get
			{
				return this.gIOGKGLBACA_;
			}
			set
			{
				this.gIOGKGLBACA_ = value;
			}
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0600B9D5 RID: 47573 RVA: 0x001F2C60 File Offset: 0x001F0E60
		// (set) Token: 0x0600B9D6 RID: 47574 RVA: 0x001F2C68 File Offset: 0x001F0E68
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

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0600B9D7 RID: 47575 RVA: 0x001F2C71 File Offset: 0x001F0E71
		// (set) Token: 0x0600B9D8 RID: 47576 RVA: 0x001F2C79 File Offset: 0x001F0E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicInfo BattleRogueMagicInfo
		{
			get
			{
				return this.battleRogueMagicInfo_;
			}
			set
			{
				this.battleRogueMagicInfo_ = value;
			}
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x0600B9D9 RID: 47577 RVA: 0x001F2C82 File Offset: 0x001F0E82
		// (set) Token: 0x0600B9DA RID: 47578 RVA: 0x001F2C8A File Offset: 0x001F0E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDHEDNKIELE CGOBLNLGCMO
		{
			get
			{
				return this.cGOBLNLGCMO_;
			}
			set
			{
				this.cGOBLNLGCMO_ = value;
			}
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x0600B9DB RID: 47579 RVA: 0x001F2C93 File Offset: 0x001F0E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, BattleTargetList> BattleTargetInfo
		{
			get
			{
				return this.battleTargetInfo_;
			}
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0600B9DC RID: 47580 RVA: 0x001F2C9B File Offset: 0x001F0E9B
		// (set) Token: 0x0600B9DD RID: 47581 RVA: 0x001F2CA3 File Offset: 0x001F0EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AFHKNCHFNLE
		{
			get
			{
				return this.aFHKNCHFNLE_;
			}
			set
			{
				this.aFHKNCHFNLE_ = value;
			}
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x001F2CAC File Offset: 0x001F0EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBattleInfo);
		}

		// Token: 0x0600B9DF RID: 47583 RVA: 0x001F2CBC File Offset: 0x001F0EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBattleInfo other)
		{
			return other != null && (other == this || (this.battleEvent_.Equals(other.battleEvent_) && this.battleAvatarList_.Equals(other.battleAvatarList_) && this.LKAHLGNIECF == other.LKAHLGNIECF && this.LogicRandomSeed == other.LogicRandomSeed && this.WorldLevel == other.WorldLevel && object.Equals(this.OAHDOLHBPFK, other.OAHDOLHBPFK) && this.monsterWaveList_.Equals(other.monsterWaveList_) && this.buffList_.Equals(other.buffList_) && this.BattleId == other.BattleId && this.RoundsLimit == other.RoundsLimit && object.Equals(this.GIOGKGLBACA, other.GIOGKGLBACA) && this.StageId == other.StageId && object.Equals(this.BattleRogueMagicInfo, other.BattleRogueMagicInfo) && object.Equals(this.CGOBLNLGCMO, other.CGOBLNLGCMO) && this.BattleTargetInfo.Equals(other.BattleTargetInfo) && this.AFHKNCHFNLE == other.AFHKNCHFNLE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9E0 RID: 47584 RVA: 0x001F2E14 File Offset: 0x001F1014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.battleEvent_.GetHashCode();
			num ^= this.battleAvatarList_.GetHashCode();
			if (this.LKAHLGNIECF)
			{
				num ^= this.LKAHLGNIECF.GetHashCode();
			}
			if (this.LogicRandomSeed != 0U)
			{
				num ^= this.LogicRandomSeed.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.oAHDOLHBPFK_ != null)
			{
				num ^= this.OAHDOLHBPFK.GetHashCode();
			}
			num ^= this.monsterWaveList_.GetHashCode();
			num ^= this.buffList_.GetHashCode();
			if (this.BattleId != 0U)
			{
				num ^= this.BattleId.GetHashCode();
			}
			if (this.RoundsLimit != 0U)
			{
				num ^= this.RoundsLimit.GetHashCode();
			}
			if (this.gIOGKGLBACA_ != null)
			{
				num ^= this.GIOGKGLBACA.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.battleRogueMagicInfo_ != null)
			{
				num ^= this.BattleRogueMagicInfo.GetHashCode();
			}
			if (this.cGOBLNLGCMO_ != null)
			{
				num ^= this.CGOBLNLGCMO.GetHashCode();
			}
			num ^= this.BattleTargetInfo.GetHashCode();
			if (this.AFHKNCHFNLE != 0U)
			{
				num ^= this.AFHKNCHFNLE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B9E1 RID: 47585 RVA: 0x001F2F87 File Offset: 0x001F1187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B9E2 RID: 47586 RVA: 0x001F2F8F File Offset: 0x001F118F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9E3 RID: 47587 RVA: 0x001F2F98 File Offset: 0x001F1198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AFHKNCHFNLE != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AFHKNCHFNLE);
			}
			if (this.RoundsLimit != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.RoundsLimit);
			}
			this.battleAvatarList_.WriteTo(ref output, SceneBattleInfo._repeated_battleAvatarList_codec);
			this.monsterWaveList_.WriteTo(ref output, SceneBattleInfo._repeated_monsterWaveList_codec);
			if (this.StageId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.StageId);
			}
			this.buffList_.WriteTo(ref output, SceneBattleInfo._repeated_buffList_codec);
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.LKAHLGNIECF)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.LKAHLGNIECF);
			}
			if (this.LogicRandomSeed != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LogicRandomSeed);
			}
			if (this.BattleId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.BattleId);
			}
			this.battleTargetInfo_.WriteTo(ref output, SceneBattleInfo._map_battleTargetInfo_codec);
			if (this.battleRogueMagicInfo_ != null)
			{
				output.WriteRawTag(242, 12);
				output.WriteMessage(this.BattleRogueMagicInfo);
			}
			if (this.oAHDOLHBPFK_ != null)
			{
				output.WriteRawTag(170, 54);
				output.WriteMessage(this.OAHDOLHBPFK);
			}
			this.battleEvent_.WriteTo(ref output, SceneBattleInfo._repeated_battleEvent_codec);
			if (this.gIOGKGLBACA_ != null)
			{
				output.WriteRawTag(226, 88);
				output.WriteMessage(this.GIOGKGLBACA);
			}
			if (this.cGOBLNLGCMO_ != null)
			{
				output.WriteRawTag(234, 94);
				output.WriteMessage(this.CGOBLNLGCMO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9E4 RID: 47588 RVA: 0x001F3158 File Offset: 0x001F1358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.battleEvent_.CalculateSize(SceneBattleInfo._repeated_battleEvent_codec);
			num += this.battleAvatarList_.CalculateSize(SceneBattleInfo._repeated_battleAvatarList_codec);
			if (this.LKAHLGNIECF)
			{
				num += 2;
			}
			if (this.LogicRandomSeed != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LogicRandomSeed);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.oAHDOLHBPFK_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OAHDOLHBPFK);
			}
			num += this.monsterWaveList_.CalculateSize(SceneBattleInfo._repeated_monsterWaveList_codec);
			num += this.buffList_.CalculateSize(SceneBattleInfo._repeated_buffList_codec);
			if (this.BattleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleId);
			}
			if (this.RoundsLimit != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoundsLimit);
			}
			if (this.gIOGKGLBACA_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GIOGKGLBACA);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.battleRogueMagicInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BattleRogueMagicInfo);
			}
			if (this.cGOBLNLGCMO_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CGOBLNLGCMO);
			}
			num += this.battleTargetInfo_.CalculateSize(SceneBattleInfo._map_battleTargetInfo_codec);
			if (this.AFHKNCHFNLE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AFHKNCHFNLE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B9E5 RID: 47589 RVA: 0x001F32DC File Offset: 0x001F14DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneBattleInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.battleEvent_.Add(other.battleEvent_);
			this.battleAvatarList_.Add(other.battleAvatarList_);
			if (other.LKAHLGNIECF)
			{
				this.LKAHLGNIECF = other.LKAHLGNIECF;
			}
			if (other.LogicRandomSeed != 0U)
			{
				this.LogicRandomSeed = other.LogicRandomSeed;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.oAHDOLHBPFK_ != null)
			{
				if (this.oAHDOLHBPFK_ == null)
				{
					this.OAHDOLHBPFK = new EvolveBuildBattleInfo();
				}
				this.OAHDOLHBPFK.MergeFrom(other.OAHDOLHBPFK);
			}
			this.monsterWaveList_.Add(other.monsterWaveList_);
			this.buffList_.Add(other.buffList_);
			if (other.BattleId != 0U)
			{
				this.BattleId = other.BattleId;
			}
			if (other.RoundsLimit != 0U)
			{
				this.RoundsLimit = other.RoundsLimit;
			}
			if (other.gIOGKGLBACA_ != null)
			{
				if (this.gIOGKGLBACA_ == null)
				{
					this.GIOGKGLBACA = new NPDPLEMGEFN();
				}
				this.GIOGKGLBACA.MergeFrom(other.GIOGKGLBACA);
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.battleRogueMagicInfo_ != null)
			{
				if (this.battleRogueMagicInfo_ == null)
				{
					this.BattleRogueMagicInfo = new BattleRogueMagicInfo();
				}
				this.BattleRogueMagicInfo.MergeFrom(other.BattleRogueMagicInfo);
			}
			if (other.cGOBLNLGCMO_ != null)
			{
				if (this.cGOBLNLGCMO_ == null)
				{
					this.CGOBLNLGCMO = new GDHEDNKIELE();
				}
				this.CGOBLNLGCMO.MergeFrom(other.CGOBLNLGCMO);
			}
			this.battleTargetInfo_.MergeFrom(other.battleTargetInfo_);
			if (other.AFHKNCHFNLE != 0U)
			{
				this.AFHKNCHFNLE = other.AFHKNCHFNLE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x001F3495 File Offset: 0x001F1695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9E7 RID: 47591 RVA: 0x001F34A0 File Offset: 0x001F16A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 104U)
				{
					if (num <= 58U)
					{
						if (num <= 40U)
						{
							if (num == 8U)
							{
								this.AFHKNCHFNLE = input.ReadUInt32();
								continue;
							}
							if (num == 40U)
							{
								this.RoundsLimit = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 50U)
							{
								this.battleAvatarList_.AddEntriesFrom(ref input, SceneBattleInfo._repeated_battleAvatarList_codec);
								continue;
							}
							if (num == 58U)
							{
								this.monsterWaveList_.AddEntriesFrom(ref input, SceneBattleInfo._repeated_monsterWaveList_codec);
								continue;
							}
						}
					}
					else if (num <= 74U)
					{
						if (num == 64U)
						{
							this.StageId = input.ReadUInt32();
							continue;
						}
						if (num == 74U)
						{
							this.buffList_.AddEntriesFrom(ref input, SceneBattleInfo._repeated_buffList_codec);
							continue;
						}
					}
					else
					{
						if (num == 96U)
						{
							this.WorldLevel = input.ReadUInt32();
							continue;
						}
						if (num == 104U)
						{
							this.LKAHLGNIECF = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 1650U)
				{
					if (num <= 120U)
					{
						if (num == 112U)
						{
							this.LogicRandomSeed = input.ReadUInt32();
							continue;
						}
						if (num == 120U)
						{
							this.BattleId = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 1034U)
						{
							this.battleTargetInfo_.AddEntriesFrom(ref input, SceneBattleInfo._map_battleTargetInfo_codec);
							continue;
						}
						if (num == 1650U)
						{
							if (this.battleRogueMagicInfo_ == null)
							{
								this.BattleRogueMagicInfo = new BattleRogueMagicInfo();
							}
							input.ReadMessage(this.BattleRogueMagicInfo);
							continue;
						}
					}
				}
				else if (num <= 10834U)
				{
					if (num == 6954U)
					{
						if (this.oAHDOLHBPFK_ == null)
						{
							this.OAHDOLHBPFK = new EvolveBuildBattleInfo();
						}
						input.ReadMessage(this.OAHDOLHBPFK);
						continue;
					}
					if (num == 10834U)
					{
						this.battleEvent_.AddEntriesFrom(ref input, SceneBattleInfo._repeated_battleEvent_codec);
						continue;
					}
				}
				else
				{
					if (num == 11362U)
					{
						if (this.gIOGKGLBACA_ == null)
						{
							this.GIOGKGLBACA = new NPDPLEMGEFN();
						}
						input.ReadMessage(this.GIOGKGLBACA);
						continue;
					}
					if (num == 12138U)
					{
						if (this.cGOBLNLGCMO_ == null)
						{
							this.CGOBLNLGCMO = new GDHEDNKIELE();
						}
						input.ReadMessage(this.CGOBLNLGCMO);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004B34 RID: 19252
		private static readonly MessageParser<SceneBattleInfo> _parser = new MessageParser<SceneBattleInfo>(() => new SceneBattleInfo());

		// Token: 0x04004B35 RID: 19253
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B36 RID: 19254
		public const int BattleEventFieldNumber = 1354;

		// Token: 0x04004B37 RID: 19255
		private static readonly FieldCodec<BattleEventBattleInfo> _repeated_battleEvent_codec = FieldCodec.ForMessage<BattleEventBattleInfo>(10834U, BattleEventBattleInfo.Parser);

		// Token: 0x04004B38 RID: 19256
		private readonly RepeatedField<BattleEventBattleInfo> battleEvent_ = new RepeatedField<BattleEventBattleInfo>();

		// Token: 0x04004B39 RID: 19257
		public const int BattleAvatarListFieldNumber = 6;

		// Token: 0x04004B3A RID: 19258
		private static readonly FieldCodec<BattleAvatar> _repeated_battleAvatarList_codec = FieldCodec.ForMessage<BattleAvatar>(50U, BattleAvatar.Parser);

		// Token: 0x04004B3B RID: 19259
		private readonly RepeatedField<BattleAvatar> battleAvatarList_ = new RepeatedField<BattleAvatar>();

		// Token: 0x04004B3C RID: 19260
		public const int LKAHLGNIECFFieldNumber = 13;

		// Token: 0x04004B3D RID: 19261
		private bool lKAHLGNIECF_;

		// Token: 0x04004B3E RID: 19262
		public const int LogicRandomSeedFieldNumber = 14;

		// Token: 0x04004B3F RID: 19263
		private uint logicRandomSeed_;

		// Token: 0x04004B40 RID: 19264
		public const int WorldLevelFieldNumber = 12;

		// Token: 0x04004B41 RID: 19265
		private uint worldLevel_;

		// Token: 0x04004B42 RID: 19266
		public const int OAHDOLHBPFKFieldNumber = 869;

		// Token: 0x04004B43 RID: 19267
		private EvolveBuildBattleInfo oAHDOLHBPFK_;

		// Token: 0x04004B44 RID: 19268
		public const int MonsterWaveListFieldNumber = 7;

		// Token: 0x04004B45 RID: 19269
		private static readonly FieldCodec<SceneMonsterWave> _repeated_monsterWaveList_codec = FieldCodec.ForMessage<SceneMonsterWave>(58U, SceneMonsterWave.Parser);

		// Token: 0x04004B46 RID: 19270
		private readonly RepeatedField<SceneMonsterWave> monsterWaveList_ = new RepeatedField<SceneMonsterWave>();

		// Token: 0x04004B47 RID: 19271
		public const int BuffListFieldNumber = 9;

		// Token: 0x04004B48 RID: 19272
		private static readonly FieldCodec<BattleBuff> _repeated_buffList_codec = FieldCodec.ForMessage<BattleBuff>(74U, BattleBuff.Parser);

		// Token: 0x04004B49 RID: 19273
		private readonly RepeatedField<BattleBuff> buffList_ = new RepeatedField<BattleBuff>();

		// Token: 0x04004B4A RID: 19274
		public const int BattleIdFieldNumber = 15;

		// Token: 0x04004B4B RID: 19275
		private uint battleId_;

		// Token: 0x04004B4C RID: 19276
		public const int RoundsLimitFieldNumber = 5;

		// Token: 0x04004B4D RID: 19277
		private uint roundsLimit_;

		// Token: 0x04004B4E RID: 19278
		public const int GIOGKGLBACAFieldNumber = 1420;

		// Token: 0x04004B4F RID: 19279
		private NPDPLEMGEFN gIOGKGLBACA_;

		// Token: 0x04004B50 RID: 19280
		public const int StageIdFieldNumber = 8;

		// Token: 0x04004B51 RID: 19281
		private uint stageId_;

		// Token: 0x04004B52 RID: 19282
		public const int BattleRogueMagicInfoFieldNumber = 206;

		// Token: 0x04004B53 RID: 19283
		private BattleRogueMagicInfo battleRogueMagicInfo_;

		// Token: 0x04004B54 RID: 19284
		public const int CGOBLNLGCMOFieldNumber = 1517;

		// Token: 0x04004B55 RID: 19285
		private GDHEDNKIELE cGOBLNLGCMO_;

		// Token: 0x04004B56 RID: 19286
		public const int BattleTargetInfoFieldNumber = 129;

		// Token: 0x04004B57 RID: 19287
		private static readonly MapField<uint, BattleTargetList>.Codec _map_battleTargetInfo_codec = new MapField<uint, BattleTargetList>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<BattleTargetList>(18U, BattleTargetList.Parser), 1034U);

		// Token: 0x04004B58 RID: 19288
		private readonly MapField<uint, BattleTargetList> battleTargetInfo_ = new MapField<uint, BattleTargetList>();

		// Token: 0x04004B59 RID: 19289
		public const int AFHKNCHFNLEFieldNumber = 1;

		// Token: 0x04004B5A RID: 19290
		private uint aFHKNCHFNLE_;
	}
}
