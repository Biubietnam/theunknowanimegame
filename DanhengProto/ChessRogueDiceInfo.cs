using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000205 RID: 517
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueDiceInfo : IMessage<ChessRogueDiceInfo>, IMessage, IEquatable<ChessRogueDiceInfo>, IDeepCloneable<ChessRogueDiceInfo>, IBufferMessage
	{
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x0004204C File Offset: 0x0004024C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueDiceInfo> Parser
		{
			get
			{
				return ChessRogueDiceInfo._parser;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x00042053 File Offset: 0x00040253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueDiceInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00042065 File Offset: 0x00040265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueDiceInfo.Descriptor;
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0004206C File Offset: 0x0004026C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceInfo()
		{
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00042080 File Offset: 0x00040280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceInfo(ChessRogueDiceInfo other) : this()
		{
			this.cheatTimes_ = other.cheatTimes_;
			this.gameDiceBranchId_ = other.gameDiceBranchId_;
			this.hHCJNJKJIKF_ = other.hHCJNJKJIKF_;
			this.hELCMBDCECH_ = other.hELCMBDCECH_;
			this.aMFBDDACHKB_ = other.aMFBDDACHKB_;
			this.iPNFHJEFGAM_ = ((other.iPNFHJEFGAM_ != null) ? other.iPNFHJEFGAM_.Clone() : null);
			this.dice_ = ((other.dice_ != null) ? other.dice_.Clone() : null);
			this.lJDDCBNKEBN_ = other.lJDDCBNKEBN_;
			this.rerollTimes_ = other.rerollTimes_;
			this.canRerollDice_ = other.canRerollDice_;
			this.diceStatus_ = other.diceStatus_;
			this.diceType_ = other.diceType_;
			this.curSurfaceId_ = other.curSurfaceId_;
			this.curSurfaceSlotId_ = other.curSurfaceSlotId_;
			this.diceModifier_ = ((other.diceModifier_ != null) ? other.diceModifier_.Clone() : null);
			this.aJMLGICAGBD_ = other.aJMLGICAGBD_.Clone();
			this.gameBranchId_ = other.gameBranchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x000421A5 File Offset: 0x000403A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceInfo Clone()
		{
			return new ChessRogueDiceInfo(this);
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x000421AD File Offset: 0x000403AD
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x000421B5 File Offset: 0x000403B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CheatTimes
		{
			get
			{
				return this.cheatTimes_;
			}
			set
			{
				this.cheatTimes_ = value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x000421BE File Offset: 0x000403BE
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x000421C6 File Offset: 0x000403C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameDiceBranchId
		{
			get
			{
				return this.gameDiceBranchId_;
			}
			set
			{
				this.gameDiceBranchId_ = value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x000421CF File Offset: 0x000403CF
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x000421D7 File Offset: 0x000403D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HHCJNJKJIKF
		{
			get
			{
				return this.hHCJNJKJIKF_;
			}
			set
			{
				this.hHCJNJKJIKF_ = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x000421E0 File Offset: 0x000403E0
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x000421E8 File Offset: 0x000403E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HELCMBDCECH
		{
			get
			{
				return this.hELCMBDCECH_;
			}
			set
			{
				this.hELCMBDCECH_ = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x000421F1 File Offset: 0x000403F1
		// (set) Token: 0x06001714 RID: 5908 RVA: 0x000421F9 File Offset: 0x000403F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AMFBDDACHKB
		{
			get
			{
				return this.aMFBDDACHKB_;
			}
			set
			{
				this.aMFBDDACHKB_ = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x00042202 File Offset: 0x00040402
		// (set) Token: 0x06001716 RID: 5910 RVA: 0x0004220A File Offset: 0x0004040A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPEGOGNDPJJ IPNFHJEFGAM
		{
			get
			{
				return this.iPNFHJEFGAM_;
			}
			set
			{
				this.iPNFHJEFGAM_ = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x00042213 File Offset: 0x00040413
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x0004221B File Offset: 0x0004041B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDice Dice
		{
			get
			{
				return this.dice_;
			}
			set
			{
				this.dice_ = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x00042224 File Offset: 0x00040424
		// (set) Token: 0x0600171A RID: 5914 RVA: 0x0004222C File Offset: 0x0004042C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LJDDCBNKEBN
		{
			get
			{
				return this.lJDDCBNKEBN_;
			}
			set
			{
				this.lJDDCBNKEBN_ = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x00042235 File Offset: 0x00040435
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x0004223D File Offset: 0x0004043D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RerollTimes
		{
			get
			{
				return this.rerollTimes_;
			}
			set
			{
				this.rerollTimes_ = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00042246 File Offset: 0x00040446
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x0004224E File Offset: 0x0004044E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanRerollDice
		{
			get
			{
				return this.canRerollDice_;
			}
			set
			{
				this.canRerollDice_ = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00042257 File Offset: 0x00040457
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x0004225F File Offset: 0x0004045F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceStatus DiceStatus
		{
			get
			{
				return this.diceStatus_;
			}
			set
			{
				this.diceStatus_ = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x00042268 File Offset: 0x00040468
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x00042270 File Offset: 0x00040470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceType DiceType
		{
			get
			{
				return this.diceType_;
			}
			set
			{
				this.diceType_ = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x00042279 File Offset: 0x00040479
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x00042281 File Offset: 0x00040481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurSurfaceId
		{
			get
			{
				return this.curSurfaceId_;
			}
			set
			{
				this.curSurfaceId_ = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x0004228A File Offset: 0x0004048A
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x00042292 File Offset: 0x00040492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurSurfaceSlotId
		{
			get
			{
				return this.curSurfaceSlotId_;
			}
			set
			{
				this.curSurfaceSlotId_ = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x0004229B File Offset: 0x0004049B
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x000422A3 File Offset: 0x000404A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifier DiceModifier
		{
			get
			{
				return this.diceModifier_;
			}
			set
			{
				this.diceModifier_ = value;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x000422AC File Offset: 0x000404AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AJMLGICAGBD
		{
			get
			{
				return this.aJMLGICAGBD_;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000422B4 File Offset: 0x000404B4
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x000422BC File Offset: 0x000404BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameBranchId
		{
			get
			{
				return this.gameBranchId_;
			}
			set
			{
				this.gameBranchId_ = value;
			}
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x000422C5 File Offset: 0x000404C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueDiceInfo);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000422D4 File Offset: 0x000404D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueDiceInfo other)
		{
			return other != null && (other == this || (this.CheatTimes == other.CheatTimes && this.GameDiceBranchId == other.GameDiceBranchId && this.HHCJNJKJIKF == other.HHCJNJKJIKF && this.HELCMBDCECH == other.HELCMBDCECH && this.AMFBDDACHKB == other.AMFBDDACHKB && object.Equals(this.IPNFHJEFGAM, other.IPNFHJEFGAM) && object.Equals(this.Dice, other.Dice) && this.LJDDCBNKEBN == other.LJDDCBNKEBN && this.RerollTimes == other.RerollTimes && this.CanRerollDice == other.CanRerollDice && this.DiceStatus == other.DiceStatus && this.DiceType == other.DiceType && this.CurSurfaceId == other.CurSurfaceId && this.CurSurfaceSlotId == other.CurSurfaceSlotId && object.Equals(this.DiceModifier, other.DiceModifier) && this.aJMLGICAGBD_.Equals(other.aJMLGICAGBD_) && this.GameBranchId == other.GameBranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00042424 File Offset: 0x00040624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CheatTimes != 0U)
			{
				num ^= this.CheatTimes.GetHashCode();
			}
			if (this.GameDiceBranchId != 0U)
			{
				num ^= this.GameDiceBranchId.GetHashCode();
			}
			if (this.HHCJNJKJIKF != 0)
			{
				num ^= this.HHCJNJKJIKF.GetHashCode();
			}
			if (this.HELCMBDCECH != 0U)
			{
				num ^= this.HELCMBDCECH.GetHashCode();
			}
			if (this.AMFBDDACHKB)
			{
				num ^= this.AMFBDDACHKB.GetHashCode();
			}
			if (this.iPNFHJEFGAM_ != null)
			{
				num ^= this.IPNFHJEFGAM.GetHashCode();
			}
			if (this.dice_ != null)
			{
				num ^= this.Dice.GetHashCode();
			}
			if (this.LJDDCBNKEBN != 0U)
			{
				num ^= this.LJDDCBNKEBN.GetHashCode();
			}
			if (this.RerollTimes != 0U)
			{
				num ^= this.RerollTimes.GetHashCode();
			}
			if (this.CanRerollDice)
			{
				num ^= this.CanRerollDice.GetHashCode();
			}
			if (this.DiceStatus != ChessRogueDiceStatus.ChessRogueDiceIdle)
			{
				num ^= this.DiceStatus.GetHashCode();
			}
			if (this.DiceType != ChessRogueDiceType.ChessRogueDiceFixed)
			{
				num ^= this.DiceType.GetHashCode();
			}
			if (this.CurSurfaceId != 0U)
			{
				num ^= this.CurSurfaceId.GetHashCode();
			}
			if (this.CurSurfaceSlotId != 0U)
			{
				num ^= this.CurSurfaceSlotId.GetHashCode();
			}
			if (this.diceModifier_ != null)
			{
				num ^= this.DiceModifier.GetHashCode();
			}
			num ^= this.aJMLGICAGBD_.GetHashCode();
			if (this.GameBranchId != 0U)
			{
				num ^= this.GameBranchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x000425ED File Offset: 0x000407ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000425F5 File Offset: 0x000407F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00042600 File Offset: 0x00040800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurSurfaceSlotId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CurSurfaceSlotId);
			}
			if (this.CurSurfaceId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CurSurfaceId);
			}
			if (this.DiceType != ChessRogueDiceType.ChessRogueDiceFixed)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.DiceType);
			}
			if (this.RerollTimes != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.RerollTimes);
			}
			if (this.HELCMBDCECH != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.HELCMBDCECH);
			}
			if (this.DiceStatus != ChessRogueDiceStatus.ChessRogueDiceIdle)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.DiceStatus);
			}
			if (this.AMFBDDACHKB)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.AMFBDDACHKB);
			}
			if (this.GameBranchId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.GameBranchId);
			}
			if (this.CheatTimes != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CheatTimes);
			}
			if (this.GameDiceBranchId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GameDiceBranchId);
			}
			if (this.LJDDCBNKEBN != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LJDDCBNKEBN);
			}
			this.aJMLGICAGBD_.WriteTo(ref output, ChessRogueDiceInfo._repeated_aJMLGICAGBD_codec);
			if (this.HHCJNJKJIKF != 0)
			{
				output.WriteRawTag(240, 22);
				output.WriteInt32(this.HHCJNJKJIKF);
			}
			if (this.dice_ != null)
			{
				output.WriteRawTag(226, 32);
				output.WriteMessage(this.Dice);
			}
			if (this.diceModifier_ != null)
			{
				output.WriteRawTag(218, 62);
				output.WriteMessage(this.DiceModifier);
			}
			if (this.CanRerollDice)
			{
				output.WriteRawTag(144, 81);
				output.WriteBool(this.CanRerollDice);
			}
			if (this.iPNFHJEFGAM_ != null)
			{
				output.WriteRawTag(226, 86);
				output.WriteMessage(this.IPNFHJEFGAM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0004280C File Offset: 0x00040A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CheatTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CheatTimes);
			}
			if (this.GameDiceBranchId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameDiceBranchId);
			}
			if (this.HHCJNJKJIKF != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.HHCJNJKJIKF);
			}
			if (this.HELCMBDCECH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HELCMBDCECH);
			}
			if (this.AMFBDDACHKB)
			{
				num += 2;
			}
			if (this.iPNFHJEFGAM_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.IPNFHJEFGAM);
			}
			if (this.dice_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Dice);
			}
			if (this.LJDDCBNKEBN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LJDDCBNKEBN);
			}
			if (this.RerollTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RerollTimes);
			}
			if (this.CanRerollDice)
			{
				num += 3;
			}
			if (this.DiceStatus != ChessRogueDiceStatus.ChessRogueDiceIdle)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DiceStatus);
			}
			if (this.DiceType != ChessRogueDiceType.ChessRogueDiceFixed)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DiceType);
			}
			if (this.CurSurfaceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurSurfaceId);
			}
			if (this.CurSurfaceSlotId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurSurfaceSlotId);
			}
			if (this.diceModifier_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DiceModifier);
			}
			num += this.aJMLGICAGBD_.CalculateSize(ChessRogueDiceInfo._repeated_aJMLGICAGBD_codec);
			if (this.GameBranchId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameBranchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000429B0 File Offset: 0x00040BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueDiceInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CheatTimes != 0U)
			{
				this.CheatTimes = other.CheatTimes;
			}
			if (other.GameDiceBranchId != 0U)
			{
				this.GameDiceBranchId = other.GameDiceBranchId;
			}
			if (other.HHCJNJKJIKF != 0)
			{
				this.HHCJNJKJIKF = other.HHCJNJKJIKF;
			}
			if (other.HELCMBDCECH != 0U)
			{
				this.HELCMBDCECH = other.HELCMBDCECH;
			}
			if (other.AMFBDDACHKB)
			{
				this.AMFBDDACHKB = other.AMFBDDACHKB;
			}
			if (other.iPNFHJEFGAM_ != null)
			{
				if (this.iPNFHJEFGAM_ == null)
				{
					this.IPNFHJEFGAM = new JPEGOGNDPJJ();
				}
				this.IPNFHJEFGAM.MergeFrom(other.IPNFHJEFGAM);
			}
			if (other.dice_ != null)
			{
				if (this.dice_ == null)
				{
					this.Dice = new ChessRogueDice();
				}
				this.Dice.MergeFrom(other.Dice);
			}
			if (other.LJDDCBNKEBN != 0U)
			{
				this.LJDDCBNKEBN = other.LJDDCBNKEBN;
			}
			if (other.RerollTimes != 0U)
			{
				this.RerollTimes = other.RerollTimes;
			}
			if (other.CanRerollDice)
			{
				this.CanRerollDice = other.CanRerollDice;
			}
			if (other.DiceStatus != ChessRogueDiceStatus.ChessRogueDiceIdle)
			{
				this.DiceStatus = other.DiceStatus;
			}
			if (other.DiceType != ChessRogueDiceType.ChessRogueDiceFixed)
			{
				this.DiceType = other.DiceType;
			}
			if (other.CurSurfaceId != 0U)
			{
				this.CurSurfaceId = other.CurSurfaceId;
			}
			if (other.CurSurfaceSlotId != 0U)
			{
				this.CurSurfaceSlotId = other.CurSurfaceSlotId;
			}
			if (other.diceModifier_ != null)
			{
				if (this.diceModifier_ == null)
				{
					this.DiceModifier = new RogueModifier();
				}
				this.DiceModifier.MergeFrom(other.DiceModifier);
			}
			this.aJMLGICAGBD_.Add(other.aJMLGICAGBD_);
			if (other.GameBranchId != 0U)
			{
				this.GameBranchId = other.GameBranchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00042B71 File Offset: 0x00040D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00042B7C File Offset: 0x00040D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num <= 40U)
					{
						if (num <= 24U)
						{
							if (num == 16U)
							{
								this.CurSurfaceSlotId = input.ReadUInt32();
								continue;
							}
							if (num == 24U)
							{
								this.CurSurfaceId = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 32U)
							{
								this.DiceType = (ChessRogueDiceType)input.ReadEnum();
								continue;
							}
							if (num == 40U)
							{
								this.RerollTimes = input.ReadUInt32();
								continue;
							}
						}
					}
					else if (num <= 56U)
					{
						if (num == 48U)
						{
							this.HELCMBDCECH = input.ReadUInt32();
							continue;
						}
						if (num == 56U)
						{
							this.DiceStatus = (ChessRogueDiceStatus)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 72U)
						{
							this.AMFBDDACHKB = input.ReadBool();
							continue;
						}
						if (num == 80U)
						{
							this.GameBranchId = input.ReadUInt32();
							continue;
						}
						if (num == 88U)
						{
							this.CheatTimes = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 2706U)
				{
					if (num <= 112U)
					{
						if (num == 104U)
						{
							this.GameDiceBranchId = input.ReadUInt32();
							continue;
						}
						if (num == 112U)
						{
							this.LJDDCBNKEBN = input.ReadUInt32();
							continue;
						}
					}
					else if (num == 2704U || num == 2706U)
					{
						this.aJMLGICAGBD_.AddEntriesFrom(ref input, ChessRogueDiceInfo._repeated_aJMLGICAGBD_codec);
						continue;
					}
				}
				else if (num <= 4194U)
				{
					if (num == 2928U)
					{
						this.HHCJNJKJIKF = input.ReadInt32();
						continue;
					}
					if (num == 4194U)
					{
						if (this.dice_ == null)
						{
							this.Dice = new ChessRogueDice();
						}
						input.ReadMessage(this.Dice);
						continue;
					}
				}
				else
				{
					if (num == 8026U)
					{
						if (this.diceModifier_ == null)
						{
							this.DiceModifier = new RogueModifier();
						}
						input.ReadMessage(this.DiceModifier);
						continue;
					}
					if (num == 10384U)
					{
						this.CanRerollDice = input.ReadBool();
						continue;
					}
					if (num == 11106U)
					{
						if (this.iPNFHJEFGAM_ == null)
						{
							this.IPNFHJEFGAM = new JPEGOGNDPJJ();
						}
						input.ReadMessage(this.IPNFHJEFGAM);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040009B5 RID: 2485
		private static readonly MessageParser<ChessRogueDiceInfo> _parser = new MessageParser<ChessRogueDiceInfo>(() => new ChessRogueDiceInfo());

		// Token: 0x040009B6 RID: 2486
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009B7 RID: 2487
		public const int CheatTimesFieldNumber = 11;

		// Token: 0x040009B8 RID: 2488
		private uint cheatTimes_;

		// Token: 0x040009B9 RID: 2489
		public const int GameDiceBranchIdFieldNumber = 13;

		// Token: 0x040009BA RID: 2490
		private uint gameDiceBranchId_;

		// Token: 0x040009BB RID: 2491
		public const int HHCJNJKJIKFFieldNumber = 366;

		// Token: 0x040009BC RID: 2492
		private int hHCJNJKJIKF_;

		// Token: 0x040009BD RID: 2493
		public const int HELCMBDCECHFieldNumber = 6;

		// Token: 0x040009BE RID: 2494
		private uint hELCMBDCECH_;

		// Token: 0x040009BF RID: 2495
		public const int AMFBDDACHKBFieldNumber = 9;

		// Token: 0x040009C0 RID: 2496
		private bool aMFBDDACHKB_;

		// Token: 0x040009C1 RID: 2497
		public const int IPNFHJEFGAMFieldNumber = 1388;

		// Token: 0x040009C2 RID: 2498
		private JPEGOGNDPJJ iPNFHJEFGAM_;

		// Token: 0x040009C3 RID: 2499
		public const int DiceFieldNumber = 524;

		// Token: 0x040009C4 RID: 2500
		private ChessRogueDice dice_;

		// Token: 0x040009C5 RID: 2501
		public const int LJDDCBNKEBNFieldNumber = 14;

		// Token: 0x040009C6 RID: 2502
		private uint lJDDCBNKEBN_;

		// Token: 0x040009C7 RID: 2503
		public const int RerollTimesFieldNumber = 5;

		// Token: 0x040009C8 RID: 2504
		private uint rerollTimes_;

		// Token: 0x040009C9 RID: 2505
		public const int CanRerollDiceFieldNumber = 1298;

		// Token: 0x040009CA RID: 2506
		private bool canRerollDice_;

		// Token: 0x040009CB RID: 2507
		public const int DiceStatusFieldNumber = 7;

		// Token: 0x040009CC RID: 2508
		private ChessRogueDiceStatus diceStatus_;

		// Token: 0x040009CD RID: 2509
		public const int DiceTypeFieldNumber = 4;

		// Token: 0x040009CE RID: 2510
		private ChessRogueDiceType diceType_;

		// Token: 0x040009CF RID: 2511
		public const int CurSurfaceIdFieldNumber = 3;

		// Token: 0x040009D0 RID: 2512
		private uint curSurfaceId_;

		// Token: 0x040009D1 RID: 2513
		public const int CurSurfaceSlotIdFieldNumber = 2;

		// Token: 0x040009D2 RID: 2514
		private uint curSurfaceSlotId_;

		// Token: 0x040009D3 RID: 2515
		public const int DiceModifierFieldNumber = 1003;

		// Token: 0x040009D4 RID: 2516
		private RogueModifier diceModifier_;

		// Token: 0x040009D5 RID: 2517
		public const int AJMLGICAGBDFieldNumber = 338;

		// Token: 0x040009D6 RID: 2518
		private static readonly FieldCodec<uint> _repeated_aJMLGICAGBD_codec = FieldCodec.ForUInt32(2706U);

		// Token: 0x040009D7 RID: 2519
		private readonly RepeatedField<uint> aJMLGICAGBD_ = new RepeatedField<uint>();

		// Token: 0x040009D8 RID: 2520
		public const int GameBranchIdFieldNumber = 10;

		// Token: 0x040009D9 RID: 2521
		private uint gameBranchId_;
	}
}
