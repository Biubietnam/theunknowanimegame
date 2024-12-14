using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D35 RID: 3381
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PVEBattleResultCsReq : IMessage<PVEBattleResultCsReq>, IMessage, IEquatable<PVEBattleResultCsReq>, IDeepCloneable<PVEBattleResultCsReq>, IBufferMessage
	{
		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x060096EB RID: 38635 RVA: 0x0019199D File Offset: 0x0018FB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PVEBattleResultCsReq> Parser
		{
			get
			{
				return PVEBattleResultCsReq._parser;
			}
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x060096EC RID: 38636 RVA: 0x001919A4 File Offset: 0x0018FBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PVEBattleResultCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x060096ED RID: 38637 RVA: 0x001919B6 File Offset: 0x0018FBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PVEBattleResultCsReq.Descriptor;
			}
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x001919BD File Offset: 0x0018FBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PVEBattleResultCsReq()
		{
		}

		// Token: 0x060096EF RID: 38639 RVA: 0x001919F4 File Offset: 0x0018FBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PVEBattleResultCsReq(PVEBattleResultCsReq other) : this()
		{
			this.lAOIGBICBAO_ = other.lAOIGBICBAO_.Clone();
			this.costTime_ = other.costTime_;
			this.endStatus_ = other.endStatus_;
			this.kNFEGGDGFGC_ = other.kNFEGGDGFGC_;
			this.resVersion_ = other.resVersion_;
			this.stageId_ = other.stageId_;
			this.isAutoFight_ = other.isAutoFight_;
			this.battleId_ = other.battleId_;
			this.stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
			this.debugExtraInfo_ = other.debugExtraInfo_;
			this.clientVersion_ = other.clientVersion_;
			this.opList_ = other.opList_.Clone();
			this.eJELPBGNINF_ = other.eJELPBGNINF_;
			this.turnSnapshotHash_ = other.turnSnapshotHash_;
			this.isAiConsiderUltraSkill_ = other.isAiConsiderUltraSkill_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096F0 RID: 38640 RVA: 0x00191AE6 File Offset: 0x0018FCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PVEBattleResultCsReq Clone()
		{
			return new PVEBattleResultCsReq(this);
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x060096F1 RID: 38641 RVA: 0x00191AEE File Offset: 0x0018FCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, uint> LAOIGBICBAO
		{
			get
			{
				return this.lAOIGBICBAO_;
			}
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x060096F2 RID: 38642 RVA: 0x00191AF6 File Offset: 0x0018FCF6
		// (set) Token: 0x060096F3 RID: 38643 RVA: 0x00191AFE File Offset: 0x0018FCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CostTime
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

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x060096F4 RID: 38644 RVA: 0x00191B07 File Offset: 0x0018FD07
		// (set) Token: 0x060096F5 RID: 38645 RVA: 0x00191B0F File Offset: 0x0018FD0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEndStatus EndStatus
		{
			get
			{
				return this.endStatus_;
			}
			set
			{
				this.endStatus_ = value;
			}
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x060096F6 RID: 38646 RVA: 0x00191B18 File Offset: 0x0018FD18
		// (set) Token: 0x060096F7 RID: 38647 RVA: 0x00191B20 File Offset: 0x0018FD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool KNFEGGDGFGC
		{
			get
			{
				return this.kNFEGGDGFGC_;
			}
			set
			{
				this.kNFEGGDGFGC_ = value;
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x060096F8 RID: 38648 RVA: 0x00191B29 File Offset: 0x0018FD29
		// (set) Token: 0x060096F9 RID: 38649 RVA: 0x00191B31 File Offset: 0x0018FD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ResVersion
		{
			get
			{
				return this.resVersion_;
			}
			set
			{
				this.resVersion_ = value;
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x060096FA RID: 38650 RVA: 0x00191B3A File Offset: 0x0018FD3A
		// (set) Token: 0x060096FB RID: 38651 RVA: 0x00191B42 File Offset: 0x0018FD42
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

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x060096FC RID: 38652 RVA: 0x00191B4B File Offset: 0x0018FD4B
		// (set) Token: 0x060096FD RID: 38653 RVA: 0x00191B53 File Offset: 0x0018FD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAutoFight
		{
			get
			{
				return this.isAutoFight_;
			}
			set
			{
				this.isAutoFight_ = value;
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x060096FE RID: 38654 RVA: 0x00191B5C File Offset: 0x0018FD5C
		// (set) Token: 0x060096FF RID: 38655 RVA: 0x00191B64 File Offset: 0x0018FD64
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

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x06009700 RID: 38656 RVA: 0x00191B6D File Offset: 0x0018FD6D
		// (set) Token: 0x06009701 RID: 38657 RVA: 0x00191B75 File Offset: 0x0018FD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStatistics Stt
		{
			get
			{
				return this.stt_;
			}
			set
			{
				this.stt_ = value;
			}
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x06009702 RID: 38658 RVA: 0x00191B7E File Offset: 0x0018FD7E
		// (set) Token: 0x06009703 RID: 38659 RVA: 0x00191B86 File Offset: 0x0018FD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DebugExtraInfo
		{
			get
			{
				return this.debugExtraInfo_;
			}
			set
			{
				this.debugExtraInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x06009704 RID: 38660 RVA: 0x00191B99 File Offset: 0x0018FD99
		// (set) Token: 0x06009705 RID: 38661 RVA: 0x00191BA1 File Offset: 0x0018FDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ClientVersion
		{
			get
			{
				return this.clientVersion_;
			}
			set
			{
				this.clientVersion_ = value;
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x06009706 RID: 38662 RVA: 0x00191BAA File Offset: 0x0018FDAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleOp> OpList
		{
			get
			{
				return this.opList_;
			}
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x06009707 RID: 38663 RVA: 0x00191BB2 File Offset: 0x0018FDB2
		// (set) Token: 0x06009708 RID: 38664 RVA: 0x00191BBA File Offset: 0x0018FDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EJELPBGNINF
		{
			get
			{
				return this.eJELPBGNINF_;
			}
			set
			{
				this.eJELPBGNINF_ = value;
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x06009709 RID: 38665 RVA: 0x00191BC3 File Offset: 0x0018FDC3
		// (set) Token: 0x0600970A RID: 38666 RVA: 0x00191BCB File Offset: 0x0018FDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString TurnSnapshotHash
		{
			get
			{
				return this.turnSnapshotHash_;
			}
			set
			{
				this.turnSnapshotHash_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x0600970B RID: 38667 RVA: 0x00191BDE File Offset: 0x0018FDDE
		// (set) Token: 0x0600970C RID: 38668 RVA: 0x00191BE6 File Offset: 0x0018FDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAiConsiderUltraSkill
		{
			get
			{
				return this.isAiConsiderUltraSkill_;
			}
			set
			{
				this.isAiConsiderUltraSkill_ = value;
			}
		}

		// Token: 0x0600970D RID: 38669 RVA: 0x00191BEF File Offset: 0x0018FDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PVEBattleResultCsReq);
		}

		// Token: 0x0600970E RID: 38670 RVA: 0x00191C00 File Offset: 0x0018FE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PVEBattleResultCsReq other)
		{
			return other != null && (other == this || (this.LAOIGBICBAO.Equals(other.LAOIGBICBAO) && this.CostTime == other.CostTime && this.EndStatus == other.EndStatus && this.KNFEGGDGFGC == other.KNFEGGDGFGC && this.ResVersion == other.ResVersion && this.StageId == other.StageId && this.IsAutoFight == other.IsAutoFight && this.BattleId == other.BattleId && object.Equals(this.Stt, other.Stt) && !(this.DebugExtraInfo != other.DebugExtraInfo) && this.ClientVersion == other.ClientVersion && this.opList_.Equals(other.opList_) && this.EJELPBGNINF == other.EJELPBGNINF && !(this.TurnSnapshotHash != other.TurnSnapshotHash) && this.IsAiConsiderUltraSkill == other.IsAiConsiderUltraSkill && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600970F RID: 38671 RVA: 0x00191D34 File Offset: 0x0018FF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.LAOIGBICBAO.GetHashCode();
			if (this.CostTime != 0U)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this.EndStatus != BattleEndStatus.BattleEndNone)
			{
				num ^= this.EndStatus.GetHashCode();
			}
			if (this.KNFEGGDGFGC)
			{
				num ^= this.KNFEGGDGFGC.GetHashCode();
			}
			if (this.ResVersion != 0U)
			{
				num ^= this.ResVersion.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.IsAutoFight)
			{
				num ^= this.IsAutoFight.GetHashCode();
			}
			if (this.BattleId != 0U)
			{
				num ^= this.BattleId.GetHashCode();
			}
			if (this.stt_ != null)
			{
				num ^= this.Stt.GetHashCode();
			}
			if (this.DebugExtraInfo.Length != 0)
			{
				num ^= this.DebugExtraInfo.GetHashCode();
			}
			if (this.ClientVersion != 0U)
			{
				num ^= this.ClientVersion.GetHashCode();
			}
			num ^= this.opList_.GetHashCode();
			if (this.EJELPBGNINF != 0U)
			{
				num ^= this.EJELPBGNINF.GetHashCode();
			}
			if (this.TurnSnapshotHash.Length != 0)
			{
				num ^= this.TurnSnapshotHash.GetHashCode();
			}
			if (this.IsAiConsiderUltraSkill)
			{
				num ^= this.IsAiConsiderUltraSkill.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009710 RID: 38672 RVA: 0x00191EC2 File Offset: 0x001900C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009711 RID: 38673 RVA: 0x00191ECA File Offset: 0x001900CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009712 RID: 38674 RVA: 0x00191ED4 File Offset: 0x001900D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BattleId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BattleId);
			}
			if (this.CostTime != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CostTime);
			}
			this.opList_.WriteTo(ref output, PVEBattleResultCsReq._repeated_opList_codec);
			this.lAOIGBICBAO_.WriteTo(ref output, PVEBattleResultCsReq._map_lAOIGBICBAO_codec);
			if (this.DebugExtraInfo.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.DebugExtraInfo);
			}
			if (this.EJELPBGNINF != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EJELPBGNINF);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.StageId);
			}
			if (this.IsAiConsiderUltraSkill)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsAiConsiderUltraSkill);
			}
			if (this.EndStatus != BattleEndStatus.BattleEndNone)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.EndStatus);
			}
			if (this.ClientVersion != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ClientVersion);
			}
			if (this.IsAutoFight)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsAutoFight);
			}
			if (this.TurnSnapshotHash.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteBytes(this.TurnSnapshotHash);
			}
			if (this.ResVersion != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ResVersion);
			}
			if (this.stt_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Stt);
			}
			if (this.KNFEGGDGFGC)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.KNFEGGDGFGC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009713 RID: 38675 RVA: 0x0019208C File Offset: 0x0019028C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lAOIGBICBAO_.CalculateSize(PVEBattleResultCsReq._map_lAOIGBICBAO_codec);
			if (this.CostTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CostTime);
			}
			if (this.EndStatus != BattleEndStatus.BattleEndNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EndStatus);
			}
			if (this.KNFEGGDGFGC)
			{
				num += 2;
			}
			if (this.ResVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ResVersion);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.IsAutoFight)
			{
				num += 2;
			}
			if (this.BattleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleId);
			}
			if (this.stt_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Stt);
			}
			if (this.DebugExtraInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DebugExtraInfo);
			}
			if (this.ClientVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClientVersion);
			}
			num += this.opList_.CalculateSize(PVEBattleResultCsReq._repeated_opList_codec);
			if (this.EJELPBGNINF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EJELPBGNINF);
			}
			if (this.TurnSnapshotHash.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.TurnSnapshotHash);
			}
			if (this.IsAiConsiderUltraSkill)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009714 RID: 38676 RVA: 0x001921F8 File Offset: 0x001903F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PVEBattleResultCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.lAOIGBICBAO_.MergeFrom(other.lAOIGBICBAO_);
			if (other.CostTime != 0U)
			{
				this.CostTime = other.CostTime;
			}
			if (other.EndStatus != BattleEndStatus.BattleEndNone)
			{
				this.EndStatus = other.EndStatus;
			}
			if (other.KNFEGGDGFGC)
			{
				this.KNFEGGDGFGC = other.KNFEGGDGFGC;
			}
			if (other.ResVersion != 0U)
			{
				this.ResVersion = other.ResVersion;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.IsAutoFight)
			{
				this.IsAutoFight = other.IsAutoFight;
			}
			if (other.BattleId != 0U)
			{
				this.BattleId = other.BattleId;
			}
			if (other.stt_ != null)
			{
				if (this.stt_ == null)
				{
					this.Stt = new BattleStatistics();
				}
				this.Stt.MergeFrom(other.Stt);
			}
			if (other.DebugExtraInfo.Length != 0)
			{
				this.DebugExtraInfo = other.DebugExtraInfo;
			}
			if (other.ClientVersion != 0U)
			{
				this.ClientVersion = other.ClientVersion;
			}
			this.opList_.Add(other.opList_);
			if (other.EJELPBGNINF != 0U)
			{
				this.EJELPBGNINF = other.EJELPBGNINF;
			}
			if (other.TurnSnapshotHash.Length != 0)
			{
				this.TurnSnapshotHash = other.TurnSnapshotHash;
			}
			if (other.IsAiConsiderUltraSkill)
			{
				this.IsAiConsiderUltraSkill = other.IsAiConsiderUltraSkill;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009715 RID: 38677 RVA: 0x00192368 File Offset: 0x00190568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009716 RID: 38678 RVA: 0x00192374 File Offset: 0x00190574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.BattleId = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.CostTime = input.ReadUInt32();
							continue;
						}
						if (num == 26U)
						{
							this.opList_.AddEntriesFrom(ref input, PVEBattleResultCsReq._repeated_opList_codec);
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 34U)
						{
							this.lAOIGBICBAO_.AddEntriesFrom(ref input, PVEBattleResultCsReq._map_lAOIGBICBAO_codec);
							continue;
						}
						if (num == 42U)
						{
							this.DebugExtraInfo = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.EJELPBGNINF = input.ReadUInt32();
							continue;
						}
						if (num == 56U)
						{
							this.StageId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num <= 72U)
					{
						if (num == 64U)
						{
							this.IsAiConsiderUltraSkill = input.ReadBool();
							continue;
						}
						if (num == 72U)
						{
							this.EndStatus = (BattleEndStatus)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.ClientVersion = input.ReadUInt32();
							continue;
						}
						if (num == 88U)
						{
							this.IsAutoFight = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 98U)
					{
						this.TurnSnapshotHash = input.ReadBytes();
						continue;
					}
					if (num == 104U)
					{
						this.ResVersion = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.stt_ == null)
						{
							this.Stt = new BattleStatistics();
						}
						input.ReadMessage(this.Stt);
						continue;
					}
					if (num == 120U)
					{
						this.KNFEGGDGFGC = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A91 RID: 14993
		private static readonly MessageParser<PVEBattleResultCsReq> _parser = new MessageParser<PVEBattleResultCsReq>(() => new PVEBattleResultCsReq());

		// Token: 0x04003A92 RID: 14994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A93 RID: 14995
		public const int LAOIGBICBAOFieldNumber = 4;

		// Token: 0x04003A94 RID: 14996
		private static readonly MapField<string, uint>.Codec _map_lAOIGBICBAO_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForUInt32(16U, 0U), 34U);

		// Token: 0x04003A95 RID: 14997
		private readonly MapField<string, uint> lAOIGBICBAO_ = new MapField<string, uint>();

		// Token: 0x04003A96 RID: 14998
		public const int CostTimeFieldNumber = 2;

		// Token: 0x04003A97 RID: 14999
		private uint costTime_;

		// Token: 0x04003A98 RID: 15000
		public const int EndStatusFieldNumber = 9;

		// Token: 0x04003A99 RID: 15001
		private BattleEndStatus endStatus_;

		// Token: 0x04003A9A RID: 15002
		public const int KNFEGGDGFGCFieldNumber = 15;

		// Token: 0x04003A9B RID: 15003
		private bool kNFEGGDGFGC_;

		// Token: 0x04003A9C RID: 15004
		public const int ResVersionFieldNumber = 13;

		// Token: 0x04003A9D RID: 15005
		private uint resVersion_;

		// Token: 0x04003A9E RID: 15006
		public const int StageIdFieldNumber = 7;

		// Token: 0x04003A9F RID: 15007
		private uint stageId_;

		// Token: 0x04003AA0 RID: 15008
		public const int IsAutoFightFieldNumber = 11;

		// Token: 0x04003AA1 RID: 15009
		private bool isAutoFight_;

		// Token: 0x04003AA2 RID: 15010
		public const int BattleIdFieldNumber = 1;

		// Token: 0x04003AA3 RID: 15011
		private uint battleId_;

		// Token: 0x04003AA4 RID: 15012
		public const int SttFieldNumber = 14;

		// Token: 0x04003AA5 RID: 15013
		private BattleStatistics stt_;

		// Token: 0x04003AA6 RID: 15014
		public const int DebugExtraInfoFieldNumber = 5;

		// Token: 0x04003AA7 RID: 15015
		private string debugExtraInfo_ = "";

		// Token: 0x04003AA8 RID: 15016
		public const int ClientVersionFieldNumber = 10;

		// Token: 0x04003AA9 RID: 15017
		private uint clientVersion_;

		// Token: 0x04003AAA RID: 15018
		public const int OpListFieldNumber = 3;

		// Token: 0x04003AAB RID: 15019
		private static readonly FieldCodec<BattleOp> _repeated_opList_codec = FieldCodec.ForMessage<BattleOp>(26U, BattleOp.Parser);

		// Token: 0x04003AAC RID: 15020
		private readonly RepeatedField<BattleOp> opList_ = new RepeatedField<BattleOp>();

		// Token: 0x04003AAD RID: 15021
		public const int EJELPBGNINFFieldNumber = 6;

		// Token: 0x04003AAE RID: 15022
		private uint eJELPBGNINF_;

		// Token: 0x04003AAF RID: 15023
		public const int TurnSnapshotHashFieldNumber = 12;

		// Token: 0x04003AB0 RID: 15024
		private ByteString turnSnapshotHash_ = ByteString.Empty;

		// Token: 0x04003AB1 RID: 15025
		public const int IsAiConsiderUltraSkillFieldNumber = 8;

		// Token: 0x04003AB2 RID: 15026
		private bool isAiConsiderUltraSkill_;
	}
}
