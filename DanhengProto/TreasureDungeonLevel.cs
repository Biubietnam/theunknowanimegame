using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200139B RID: 5019
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureDungeonLevel : IMessage<TreasureDungeonLevel>, IMessage, IEquatable<TreasureDungeonLevel>, IDeepCloneable<TreasureDungeonLevel>, IBufferMessage
	{
		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x0600DFFE RID: 57342 RVA: 0x00254211 File Offset: 0x00252411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureDungeonLevel> Parser
		{
			get
			{
				return TreasureDungeonLevel._parser;
			}
		}

		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x0600DFFF RID: 57343 RVA: 0x00254218 File Offset: 0x00252418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TreasureDungeonLevelReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x0600E000 RID: 57344 RVA: 0x0025422A File Offset: 0x0025242A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureDungeonLevel.Descriptor;
			}
		}

		// Token: 0x0600E001 RID: 57345 RVA: 0x00254234 File Offset: 0x00252434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonLevel()
		{
		}

		// Token: 0x0600E002 RID: 57346 RVA: 0x00254294 File Offset: 0x00252494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonLevel(TreasureDungeonLevel other) : this()
		{
			this.pMDADNCKJIA_ = other.pMDADNCKJIA_;
			this.cNIJGAPOPAH_ = other.cNIJGAPOPAH_;
			this.itemList_ = other.itemList_.Clone();
			this.mapId_ = other.mapId_;
			this.bKCBHFNPNDB_ = other.bKCBHFNPNDB_.Clone();
			this.avatarList_ = other.avatarList_.Clone();
			this.oJJLBIPFMAP_ = other.oJJLBIPFMAP_;
			this.buffList_ = other.buffList_.Clone();
			this.nONCAHOJMIL_ = other.nONCAHOJMIL_;
			this.gDMHDNHIBIF_ = other.gDMHDNHIBIF_.Clone();
			this.aNMGHMCILLM_ = other.aNMGHMCILLM_;
			this.nHLIFOPDKGM_ = other.nHLIFOPDKGM_.Clone();
			this.dHLPHKJBMHB_ = other.dHLPHKJBMHB_;
			this.fDIPCGICJKF_ = other.fDIPCGICJKF_;
			this.kHGLEILELJP_ = other.kHGLEILELJP_;
			this.iOOLNIOPGBJ_ = other.iOOLNIOPGBJ_;
			this.kCAOCAEKGMK_ = other.kCAOCAEKGMK_.Clone();
			this.nCFAJPAMBGD_ = other.nCFAJPAMBGD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E003 RID: 57347 RVA: 0x002543B3 File Offset: 0x002525B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonLevel Clone()
		{
			return new TreasureDungeonLevel(this);
		}

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x0600E004 RID: 57348 RVA: 0x002543BB File Offset: 0x002525BB
		// (set) Token: 0x0600E005 RID: 57349 RVA: 0x002543C3 File Offset: 0x002525C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PMDADNCKJIA
		{
			get
			{
				return this.pMDADNCKJIA_;
			}
			set
			{
				this.pMDADNCKJIA_ = value;
			}
		}

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x0600E006 RID: 57350 RVA: 0x002543CC File Offset: 0x002525CC
		// (set) Token: 0x0600E007 RID: 57351 RVA: 0x002543D4 File Offset: 0x002525D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CNIJGAPOPAH
		{
			get
			{
				return this.cNIJGAPOPAH_;
			}
			set
			{
				this.cNIJGAPOPAH_ = value;
			}
		}

		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x0600E008 RID: 57352 RVA: 0x002543DD File Offset: 0x002525DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OPMPNHEDCHB> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x0600E009 RID: 57353 RVA: 0x002543E5 File Offset: 0x002525E5
		// (set) Token: 0x0600E00A RID: 57354 RVA: 0x002543ED File Offset: 0x002525ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x0600E00B RID: 57355 RVA: 0x002543F6 File Offset: 0x002525F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GGCPLONEAEG> BKCBHFNPNDB
		{
			get
			{
				return this.bKCBHFNPNDB_;
			}
		}

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x0600E00C RID: 57356 RVA: 0x002543FE File Offset: 0x002525FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<APFBCEPJLDC> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x0600E00D RID: 57357 RVA: 0x00254406 File Offset: 0x00252606
		// (set) Token: 0x0600E00E RID: 57358 RVA: 0x0025440E File Offset: 0x0025260E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OJJLBIPFMAP
		{
			get
			{
				return this.oJJLBIPFMAP_;
			}
			set
			{
				this.oJJLBIPFMAP_ = value;
			}
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x0600E00F RID: 57359 RVA: 0x00254417 File Offset: 0x00252617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GKHIKGFLEHO> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x0600E010 RID: 57360 RVA: 0x0025441F File Offset: 0x0025261F
		// (set) Token: 0x0600E011 RID: 57361 RVA: 0x00254427 File Offset: 0x00252627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NONCAHOJMIL
		{
			get
			{
				return this.nONCAHOJMIL_;
			}
			set
			{
				this.nONCAHOJMIL_ = value;
			}
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x0600E012 RID: 57362 RVA: 0x00254430 File Offset: 0x00252630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreasureDungeonRecordData> GDMHDNHIBIF
		{
			get
			{
				return this.gDMHDNHIBIF_;
			}
		}

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x0600E013 RID: 57363 RVA: 0x00254438 File Offset: 0x00252638
		// (set) Token: 0x0600E014 RID: 57364 RVA: 0x00254440 File Offset: 0x00252640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ANMGHMCILLM
		{
			get
			{
				return this.aNMGHMCILLM_;
			}
			set
			{
				this.aNMGHMCILLM_ = value;
			}
		}

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x0600E015 RID: 57365 RVA: 0x00254449 File Offset: 0x00252649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CJLIFBJOOAJ> NHLIFOPDKGM
		{
			get
			{
				return this.nHLIFOPDKGM_;
			}
		}

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x0600E016 RID: 57366 RVA: 0x00254451 File Offset: 0x00252651
		// (set) Token: 0x0600E017 RID: 57367 RVA: 0x00254459 File Offset: 0x00252659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DHLPHKJBMHB
		{
			get
			{
				return this.dHLPHKJBMHB_;
			}
			set
			{
				this.dHLPHKJBMHB_ = value;
			}
		}

		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x0600E018 RID: 57368 RVA: 0x00254462 File Offset: 0x00252662
		// (set) Token: 0x0600E019 RID: 57369 RVA: 0x0025446A File Offset: 0x0025266A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FDIPCGICJKF
		{
			get
			{
				return this.fDIPCGICJKF_;
			}
			set
			{
				this.fDIPCGICJKF_ = value;
			}
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x0600E01A RID: 57370 RVA: 0x00254473 File Offset: 0x00252673
		// (set) Token: 0x0600E01B RID: 57371 RVA: 0x0025447B File Offset: 0x0025267B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool KHGLEILELJP
		{
			get
			{
				return this.kHGLEILELJP_;
			}
			set
			{
				this.kHGLEILELJP_ = value;
			}
		}

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x0600E01C RID: 57372 RVA: 0x00254484 File Offset: 0x00252684
		// (set) Token: 0x0600E01D RID: 57373 RVA: 0x0025448C File Offset: 0x0025268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IOOLNIOPGBJ
		{
			get
			{
				return this.iOOLNIOPGBJ_;
			}
			set
			{
				this.iOOLNIOPGBJ_ = value;
			}
		}

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x0600E01E RID: 57374 RVA: 0x00254495 File Offset: 0x00252695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<APFBCEPJLDC> KCAOCAEKGMK
		{
			get
			{
				return this.kCAOCAEKGMK_;
			}
		}

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x0600E01F RID: 57375 RVA: 0x0025449D File Offset: 0x0025269D
		// (set) Token: 0x0600E020 RID: 57376 RVA: 0x002544A5 File Offset: 0x002526A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCFAJPAMBGD
		{
			get
			{
				return this.nCFAJPAMBGD_;
			}
			set
			{
				this.nCFAJPAMBGD_ = value;
			}
		}

		// Token: 0x0600E021 RID: 57377 RVA: 0x002544AE File Offset: 0x002526AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureDungeonLevel);
		}

		// Token: 0x0600E022 RID: 57378 RVA: 0x002544BC File Offset: 0x002526BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureDungeonLevel other)
		{
			return other != null && (other == this || (this.PMDADNCKJIA == other.PMDADNCKJIA && this.CNIJGAPOPAH == other.CNIJGAPOPAH && this.itemList_.Equals(other.itemList_) && this.MapId == other.MapId && this.bKCBHFNPNDB_.Equals(other.bKCBHFNPNDB_) && this.avatarList_.Equals(other.avatarList_) && this.OJJLBIPFMAP == other.OJJLBIPFMAP && this.buffList_.Equals(other.buffList_) && this.NONCAHOJMIL == other.NONCAHOJMIL && this.gDMHDNHIBIF_.Equals(other.gDMHDNHIBIF_) && this.ANMGHMCILLM == other.ANMGHMCILLM && this.nHLIFOPDKGM_.Equals(other.nHLIFOPDKGM_) && this.DHLPHKJBMHB == other.DHLPHKJBMHB && this.FDIPCGICJKF == other.FDIPCGICJKF && this.KHGLEILELJP == other.KHGLEILELJP && this.IOOLNIOPGBJ == other.IOOLNIOPGBJ && this.kCAOCAEKGMK_.Equals(other.kCAOCAEKGMK_) && this.NCFAJPAMBGD == other.NCFAJPAMBGD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E023 RID: 57379 RVA: 0x00254628 File Offset: 0x00252828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PMDADNCKJIA != 0U)
			{
				num ^= this.PMDADNCKJIA.GetHashCode();
			}
			if (this.CNIJGAPOPAH != 0U)
			{
				num ^= this.CNIJGAPOPAH.GetHashCode();
			}
			num ^= this.itemList_.GetHashCode();
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			num ^= this.bKCBHFNPNDB_.GetHashCode();
			num ^= this.avatarList_.GetHashCode();
			if (this.OJJLBIPFMAP != 0U)
			{
				num ^= this.OJJLBIPFMAP.GetHashCode();
			}
			num ^= this.buffList_.GetHashCode();
			if (this.NONCAHOJMIL)
			{
				num ^= this.NONCAHOJMIL.GetHashCode();
			}
			num ^= this.gDMHDNHIBIF_.GetHashCode();
			if (this.ANMGHMCILLM != 0U)
			{
				num ^= this.ANMGHMCILLM.GetHashCode();
			}
			num ^= this.nHLIFOPDKGM_.GetHashCode();
			if (this.DHLPHKJBMHB != 0U)
			{
				num ^= this.DHLPHKJBMHB.GetHashCode();
			}
			if (this.FDIPCGICJKF != 0U)
			{
				num ^= this.FDIPCGICJKF.GetHashCode();
			}
			if (this.KHGLEILELJP)
			{
				num ^= this.KHGLEILELJP.GetHashCode();
			}
			if (this.IOOLNIOPGBJ)
			{
				num ^= this.IOOLNIOPGBJ.GetHashCode();
			}
			num ^= this.kCAOCAEKGMK_.GetHashCode();
			if (this.NCFAJPAMBGD != 0U)
			{
				num ^= this.NCFAJPAMBGD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E024 RID: 57380 RVA: 0x002547C3 File Offset: 0x002529C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E025 RID: 57381 RVA: 0x002547CB File Offset: 0x002529CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E026 RID: 57382 RVA: 0x002547D4 File Offset: 0x002529D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nHLIFOPDKGM_.WriteTo(ref output, TreasureDungeonLevel._repeated_nHLIFOPDKGM_codec);
			if (this.FDIPCGICJKF != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FDIPCGICJKF);
			}
			this.gDMHDNHIBIF_.WriteTo(ref output, TreasureDungeonLevel._repeated_gDMHDNHIBIF_codec);
			if (this.DHLPHKJBMHB != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DHLPHKJBMHB);
			}
			if (this.CNIJGAPOPAH != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CNIJGAPOPAH);
			}
			if (this.ANMGHMCILLM != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ANMGHMCILLM);
			}
			if (this.OJJLBIPFMAP != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.OJJLBIPFMAP);
			}
			if (this.MapId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MapId);
			}
			if (this.NCFAJPAMBGD != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.NCFAJPAMBGD);
			}
			if (this.IOOLNIOPGBJ)
			{
				output.WriteRawTag(224, 11);
				output.WriteBool(this.IOOLNIOPGBJ);
			}
			this.kCAOCAEKGMK_.WriteTo(ref output, TreasureDungeonLevel._repeated_kCAOCAEKGMK_codec);
			if (this.PMDADNCKJIA != 0U)
			{
				output.WriteRawTag(128, 57);
				output.WriteUInt32(this.PMDADNCKJIA);
			}
			this.itemList_.WriteTo(ref output, TreasureDungeonLevel._repeated_itemList_codec);
			if (this.KHGLEILELJP)
			{
				output.WriteRawTag(200, 82);
				output.WriteBool(this.KHGLEILELJP);
			}
			if (this.NONCAHOJMIL)
			{
				output.WriteRawTag(144, 95);
				output.WriteBool(this.NONCAHOJMIL);
			}
			this.buffList_.WriteTo(ref output, TreasureDungeonLevel._repeated_buffList_codec);
			this.bKCBHFNPNDB_.WriteTo(ref output, TreasureDungeonLevel._repeated_bKCBHFNPNDB_codec);
			this.avatarList_.WriteTo(ref output, TreasureDungeonLevel._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E027 RID: 57383 RVA: 0x002549B4 File Offset: 0x00252BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PMDADNCKJIA != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.PMDADNCKJIA);
			}
			if (this.CNIJGAPOPAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CNIJGAPOPAH);
			}
			num += this.itemList_.CalculateSize(TreasureDungeonLevel._repeated_itemList_codec);
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			num += this.bKCBHFNPNDB_.CalculateSize(TreasureDungeonLevel._repeated_bKCBHFNPNDB_codec);
			num += this.avatarList_.CalculateSize(TreasureDungeonLevel._repeated_avatarList_codec);
			if (this.OJJLBIPFMAP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OJJLBIPFMAP);
			}
			num += this.buffList_.CalculateSize(TreasureDungeonLevel._repeated_buffList_codec);
			if (this.NONCAHOJMIL)
			{
				num += 3;
			}
			num += this.gDMHDNHIBIF_.CalculateSize(TreasureDungeonLevel._repeated_gDMHDNHIBIF_codec);
			if (this.ANMGHMCILLM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ANMGHMCILLM);
			}
			num += this.nHLIFOPDKGM_.CalculateSize(TreasureDungeonLevel._repeated_nHLIFOPDKGM_codec);
			if (this.DHLPHKJBMHB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DHLPHKJBMHB);
			}
			if (this.FDIPCGICJKF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FDIPCGICJKF);
			}
			if (this.KHGLEILELJP)
			{
				num += 3;
			}
			if (this.IOOLNIOPGBJ)
			{
				num += 3;
			}
			num += this.kCAOCAEKGMK_.CalculateSize(TreasureDungeonLevel._repeated_kCAOCAEKGMK_codec);
			if (this.NCFAJPAMBGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCFAJPAMBGD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E028 RID: 57384 RVA: 0x00254B44 File Offset: 0x00252D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureDungeonLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PMDADNCKJIA != 0U)
			{
				this.PMDADNCKJIA = other.PMDADNCKJIA;
			}
			if (other.CNIJGAPOPAH != 0U)
			{
				this.CNIJGAPOPAH = other.CNIJGAPOPAH;
			}
			this.itemList_.Add(other.itemList_);
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			this.bKCBHFNPNDB_.Add(other.bKCBHFNPNDB_);
			this.avatarList_.Add(other.avatarList_);
			if (other.OJJLBIPFMAP != 0U)
			{
				this.OJJLBIPFMAP = other.OJJLBIPFMAP;
			}
			this.buffList_.Add(other.buffList_);
			if (other.NONCAHOJMIL)
			{
				this.NONCAHOJMIL = other.NONCAHOJMIL;
			}
			this.gDMHDNHIBIF_.Add(other.gDMHDNHIBIF_);
			if (other.ANMGHMCILLM != 0U)
			{
				this.ANMGHMCILLM = other.ANMGHMCILLM;
			}
			this.nHLIFOPDKGM_.Add(other.nHLIFOPDKGM_);
			if (other.DHLPHKJBMHB != 0U)
			{
				this.DHLPHKJBMHB = other.DHLPHKJBMHB;
			}
			if (other.FDIPCGICJKF != 0U)
			{
				this.FDIPCGICJKF = other.FDIPCGICJKF;
			}
			if (other.KHGLEILELJP)
			{
				this.KHGLEILELJP = other.KHGLEILELJP;
			}
			if (other.IOOLNIOPGBJ)
			{
				this.IOOLNIOPGBJ = other.IOOLNIOPGBJ;
			}
			this.kCAOCAEKGMK_.Add(other.kCAOCAEKGMK_);
			if (other.NCFAJPAMBGD != 0U)
			{
				this.NCFAJPAMBGD = other.NCFAJPAMBGD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E029 RID: 57385 RVA: 0x00254CBF File Offset: 0x00252EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E02A RID: 57386 RVA: 0x00254CC8 File Offset: 0x00252EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 120U)
				{
					if (num <= 48U)
					{
						if (num <= 16U)
						{
							if (num == 10U)
							{
								this.nHLIFOPDKGM_.AddEntriesFrom(ref input, TreasureDungeonLevel._repeated_nHLIFOPDKGM_codec);
								continue;
							}
							if (num == 16U)
							{
								this.FDIPCGICJKF = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 26U)
							{
								this.gDMHDNHIBIF_.AddEntriesFrom(ref input, TreasureDungeonLevel._repeated_gDMHDNHIBIF_codec);
								continue;
							}
							if (num == 48U)
							{
								this.DHLPHKJBMHB = input.ReadUInt32();
								continue;
							}
						}
					}
					else if (num <= 80U)
					{
						if (num == 72U)
						{
							this.CNIJGAPOPAH = input.ReadUInt32();
							continue;
						}
						if (num == 80U)
						{
							this.ANMGHMCILLM = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 104U)
						{
							this.OJJLBIPFMAP = input.ReadUInt32();
							continue;
						}
						if (num == 112U)
						{
							this.MapId = input.ReadUInt32();
							continue;
						}
						if (num == 120U)
						{
							this.NCFAJPAMBGD = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 7706U)
				{
					if (num <= 3930U)
					{
						if (num == 1504U)
						{
							this.IOOLNIOPGBJ = input.ReadBool();
							continue;
						}
						if (num == 3930U)
						{
							this.kCAOCAEKGMK_.AddEntriesFrom(ref input, TreasureDungeonLevel._repeated_kCAOCAEKGMK_codec);
							continue;
						}
					}
					else
					{
						if (num == 7296U)
						{
							this.PMDADNCKJIA = input.ReadUInt32();
							continue;
						}
						if (num == 7706U)
						{
							this.itemList_.AddEntriesFrom(ref input, TreasureDungeonLevel._repeated_itemList_codec);
							continue;
						}
					}
				}
				else if (num <= 12176U)
				{
					if (num == 10568U)
					{
						this.KHGLEILELJP = input.ReadBool();
						continue;
					}
					if (num == 12176U)
					{
						this.NONCAHOJMIL = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 12378U)
					{
						this.buffList_.AddEntriesFrom(ref input, TreasureDungeonLevel._repeated_buffList_codec);
						continue;
					}
					if (num == 13058U)
					{
						this.bKCBHFNPNDB_.AddEntriesFrom(ref input, TreasureDungeonLevel._repeated_bKCBHFNPNDB_codec);
						continue;
					}
					if (num == 14450U)
					{
						this.avatarList_.AddEntriesFrom(ref input, TreasureDungeonLevel._repeated_avatarList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005900 RID: 22784
		private static readonly MessageParser<TreasureDungeonLevel> _parser = new MessageParser<TreasureDungeonLevel>(() => new TreasureDungeonLevel());

		// Token: 0x04005901 RID: 22785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005902 RID: 22786
		public const int PMDADNCKJIAFieldNumber = 912;

		// Token: 0x04005903 RID: 22787
		private uint pMDADNCKJIA_;

		// Token: 0x04005904 RID: 22788
		public const int CNIJGAPOPAHFieldNumber = 9;

		// Token: 0x04005905 RID: 22789
		private uint cNIJGAPOPAH_;

		// Token: 0x04005906 RID: 22790
		public const int ItemListFieldNumber = 963;

		// Token: 0x04005907 RID: 22791
		private static readonly FieldCodec<OPMPNHEDCHB> _repeated_itemList_codec = FieldCodec.ForMessage<OPMPNHEDCHB>(7706U, OPMPNHEDCHB.Parser);

		// Token: 0x04005908 RID: 22792
		private readonly RepeatedField<OPMPNHEDCHB> itemList_ = new RepeatedField<OPMPNHEDCHB>();

		// Token: 0x04005909 RID: 22793
		public const int MapIdFieldNumber = 14;

		// Token: 0x0400590A RID: 22794
		private uint mapId_;

		// Token: 0x0400590B RID: 22795
		public const int BKCBHFNPNDBFieldNumber = 1632;

		// Token: 0x0400590C RID: 22796
		private static readonly FieldCodec<GGCPLONEAEG> _repeated_bKCBHFNPNDB_codec = FieldCodec.ForMessage<GGCPLONEAEG>(13058U, GGCPLONEAEG.Parser);

		// Token: 0x0400590D RID: 22797
		private readonly RepeatedField<GGCPLONEAEG> bKCBHFNPNDB_ = new RepeatedField<GGCPLONEAEG>();

		// Token: 0x0400590E RID: 22798
		public const int AvatarListFieldNumber = 1806;

		// Token: 0x0400590F RID: 22799
		private static readonly FieldCodec<APFBCEPJLDC> _repeated_avatarList_codec = FieldCodec.ForMessage<APFBCEPJLDC>(14450U, APFBCEPJLDC.Parser);

		// Token: 0x04005910 RID: 22800
		private readonly RepeatedField<APFBCEPJLDC> avatarList_ = new RepeatedField<APFBCEPJLDC>();

		// Token: 0x04005911 RID: 22801
		public const int OJJLBIPFMAPFieldNumber = 13;

		// Token: 0x04005912 RID: 22802
		private uint oJJLBIPFMAP_;

		// Token: 0x04005913 RID: 22803
		public const int BuffListFieldNumber = 1547;

		// Token: 0x04005914 RID: 22804
		private static readonly FieldCodec<GKHIKGFLEHO> _repeated_buffList_codec = FieldCodec.ForMessage<GKHIKGFLEHO>(12378U, GKHIKGFLEHO.Parser);

		// Token: 0x04005915 RID: 22805
		private readonly RepeatedField<GKHIKGFLEHO> buffList_ = new RepeatedField<GKHIKGFLEHO>();

		// Token: 0x04005916 RID: 22806
		public const int NONCAHOJMILFieldNumber = 1522;

		// Token: 0x04005917 RID: 22807
		private bool nONCAHOJMIL_;

		// Token: 0x04005918 RID: 22808
		public const int GDMHDNHIBIFFieldNumber = 3;

		// Token: 0x04005919 RID: 22809
		private static readonly FieldCodec<TreasureDungeonRecordData> _repeated_gDMHDNHIBIF_codec = FieldCodec.ForMessage<TreasureDungeonRecordData>(26U, TreasureDungeonRecordData.Parser);

		// Token: 0x0400591A RID: 22810
		private readonly RepeatedField<TreasureDungeonRecordData> gDMHDNHIBIF_ = new RepeatedField<TreasureDungeonRecordData>();

		// Token: 0x0400591B RID: 22811
		public const int ANMGHMCILLMFieldNumber = 10;

		// Token: 0x0400591C RID: 22812
		private uint aNMGHMCILLM_;

		// Token: 0x0400591D RID: 22813
		public const int NHLIFOPDKGMFieldNumber = 1;

		// Token: 0x0400591E RID: 22814
		private static readonly FieldCodec<CJLIFBJOOAJ> _repeated_nHLIFOPDKGM_codec = FieldCodec.ForMessage<CJLIFBJOOAJ>(10U, CJLIFBJOOAJ.Parser);

		// Token: 0x0400591F RID: 22815
		private readonly RepeatedField<CJLIFBJOOAJ> nHLIFOPDKGM_ = new RepeatedField<CJLIFBJOOAJ>();

		// Token: 0x04005920 RID: 22816
		public const int DHLPHKJBMHBFieldNumber = 6;

		// Token: 0x04005921 RID: 22817
		private uint dHLPHKJBMHB_;

		// Token: 0x04005922 RID: 22818
		public const int FDIPCGICJKFFieldNumber = 2;

		// Token: 0x04005923 RID: 22819
		private uint fDIPCGICJKF_;

		// Token: 0x04005924 RID: 22820
		public const int KHGLEILELJPFieldNumber = 1321;

		// Token: 0x04005925 RID: 22821
		private bool kHGLEILELJP_;

		// Token: 0x04005926 RID: 22822
		public const int IOOLNIOPGBJFieldNumber = 188;

		// Token: 0x04005927 RID: 22823
		private bool iOOLNIOPGBJ_;

		// Token: 0x04005928 RID: 22824
		public const int KCAOCAEKGMKFieldNumber = 491;

		// Token: 0x04005929 RID: 22825
		private static readonly FieldCodec<APFBCEPJLDC> _repeated_kCAOCAEKGMK_codec = FieldCodec.ForMessage<APFBCEPJLDC>(3930U, APFBCEPJLDC.Parser);

		// Token: 0x0400592A RID: 22826
		private readonly RepeatedField<APFBCEPJLDC> kCAOCAEKGMK_ = new RepeatedField<APFBCEPJLDC>();

		// Token: 0x0400592B RID: 22827
		public const int NCFAJPAMBGDFieldNumber = 15;

		// Token: 0x0400592C RID: 22828
		private uint nCFAJPAMBGD_;
	}
}
