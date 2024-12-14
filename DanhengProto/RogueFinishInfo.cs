using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E85 RID: 3717
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueFinishInfo : IMessage<RogueFinishInfo>, IMessage, IEquatable<RogueFinishInfo>, IDeepCloneable<RogueFinishInfo>, IBufferMessage
	{
		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0600A5D0 RID: 42448 RVA: 0x001BDCD8 File Offset: 0x001BBED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueFinishInfo> Parser
		{
			get
			{
				return RogueFinishInfo._parser;
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x0600A5D1 RID: 42449 RVA: 0x001BDCDF File Offset: 0x001BBEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueFinishInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x0600A5D2 RID: 42450 RVA: 0x001BDCF1 File Offset: 0x001BBEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueFinishInfo.Descriptor;
			}
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x001BDCF8 File Offset: 0x001BBEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFinishInfo()
		{
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x001BDD00 File Offset: 0x001BBF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFinishInfo(RogueFinishInfo other) : this()
		{
			this.gNLCJMJDKNC_ = other.gNLCJMJDKNC_;
			this.oLLFFPHGOLH_ = ((other.oLLFFPHGOLH_ != null) ? other.oLLFFPHGOLH_.Clone() : null);
			this.aPBHNOKGEHH_ = other.aPBHNOKGEHH_;
			this.bPDBKNPHLDF_ = other.bPDBKNPHLDF_;
			this.lEMBCFHPIKC_ = other.lEMBCFHPIKC_;
			this.mGFOCDPEGKP_ = other.mGFOCDPEGKP_;
			this.pLJEMKLKMPG_ = ((other.pLJEMKLKMPG_ != null) ? other.pLJEMKLKMPG_.Clone() : null);
			this.jKDEKDLFIHG_ = ((other.jKDEKDLFIHG_ != null) ? other.jKDEKDLFIHG_.Clone() : null);
			this.areaId_ = other.areaId_;
			this.isWin_ = other.isWin_;
			this.nPENEDFJFNI_ = ((other.nPENEDFJFNI_ != null) ? other.nPENEDFJFNI_.Clone() : null);
			this.pNANNPJKKAJ_ = other.pNANNPJKKAJ_;
			this.recordInfo_ = ((other.recordInfo_ != null) ? other.recordInfo_.Clone() : null);
			this.scoreId_ = other.scoreId_;
			this.iLOPGMAHFAE_ = ((other.iLOPGMAHFAE_ != null) ? other.iLOPGMAHFAE_.Clone() : null);
			this.cLOOABBKDPL_ = ((other.cLOOABBKDPL_ != null) ? other.cLOOABBKDPL_.Clone() : null);
			this.dCGAGPDHOKB_ = ((other.dCGAGPDHOKB_ != null) ? other.dCGAGPDHOKB_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x001BDE70 File Offset: 0x001BC070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFinishInfo Clone()
		{
			return new RogueFinishInfo(this);
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x0600A5D6 RID: 42454 RVA: 0x001BDE78 File Offset: 0x001BC078
		// (set) Token: 0x0600A5D7 RID: 42455 RVA: 0x001BDE80 File Offset: 0x001BC080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GNLCJMJDKNC
		{
			get
			{
				return this.gNLCJMJDKNC_;
			}
			set
			{
				this.gNLCJMJDKNC_ = value;
			}
		}

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x0600A5D8 RID: 42456 RVA: 0x001BDE89 File Offset: 0x001BC089
		// (set) Token: 0x0600A5D9 RID: 42457 RVA: 0x001BDE91 File Offset: 0x001BC091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList OLLFFPHGOLH
		{
			get
			{
				return this.oLLFFPHGOLH_;
			}
			set
			{
				this.oLLFFPHGOLH_ = value;
			}
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x0600A5DA RID: 42458 RVA: 0x001BDE9A File Offset: 0x001BC09A
		// (set) Token: 0x0600A5DB RID: 42459 RVA: 0x001BDEA2 File Offset: 0x001BC0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint APBHNOKGEHH
		{
			get
			{
				return this.aPBHNOKGEHH_;
			}
			set
			{
				this.aPBHNOKGEHH_ = value;
			}
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x0600A5DC RID: 42460 RVA: 0x001BDEAB File Offset: 0x001BC0AB
		// (set) Token: 0x0600A5DD RID: 42461 RVA: 0x001BDEB3 File Offset: 0x001BC0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BPDBKNPHLDF
		{
			get
			{
				return this.bPDBKNPHLDF_;
			}
			set
			{
				this.bPDBKNPHLDF_ = value;
			}
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x0600A5DE RID: 42462 RVA: 0x001BDEBC File Offset: 0x001BC0BC
		// (set) Token: 0x0600A5DF RID: 42463 RVA: 0x001BDEC4 File Offset: 0x001BC0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LEMBCFHPIKC
		{
			get
			{
				return this.lEMBCFHPIKC_;
			}
			set
			{
				this.lEMBCFHPIKC_ = value;
			}
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0600A5E0 RID: 42464 RVA: 0x001BDECD File Offset: 0x001BC0CD
		// (set) Token: 0x0600A5E1 RID: 42465 RVA: 0x001BDED5 File Offset: 0x001BC0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MGFOCDPEGKP
		{
			get
			{
				return this.mGFOCDPEGKP_;
			}
			set
			{
				this.mGFOCDPEGKP_ = value;
			}
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0600A5E2 RID: 42466 RVA: 0x001BDEDE File Offset: 0x001BC0DE
		// (set) Token: 0x0600A5E3 RID: 42467 RVA: 0x001BDEE6 File Offset: 0x001BC0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList PLJEMKLKMPG
		{
			get
			{
				return this.pLJEMKLKMPG_;
			}
			set
			{
				this.pLJEMKLKMPG_ = value;
			}
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x001BDEEF File Offset: 0x001BC0EF
		// (set) Token: 0x0600A5E5 RID: 42469 RVA: 0x001BDEF7 File Offset: 0x001BC0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueExploreScoreInfo JKDEKDLFIHG
		{
			get
			{
				return this.jKDEKDLFIHG_;
			}
			set
			{
				this.jKDEKDLFIHG_ = value;
			}
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x0600A5E6 RID: 42470 RVA: 0x001BDF00 File Offset: 0x001BC100
		// (set) Token: 0x0600A5E7 RID: 42471 RVA: 0x001BDF08 File Offset: 0x001BC108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x001BDF11 File Offset: 0x001BC111
		// (set) Token: 0x0600A5E9 RID: 42473 RVA: 0x001BDF19 File Offset: 0x001BC119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x0600A5EA RID: 42474 RVA: 0x001BDF22 File Offset: 0x001BC122
		// (set) Token: 0x0600A5EB RID: 42475 RVA: 0x001BDF2A File Offset: 0x001BC12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EJHLGGLFNLO NPENEDFJFNI
		{
			get
			{
				return this.nPENEDFJFNI_;
			}
			set
			{
				this.nPENEDFJFNI_ = value;
			}
		}

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x0600A5EC RID: 42476 RVA: 0x001BDF33 File Offset: 0x001BC133
		// (set) Token: 0x0600A5ED RID: 42477 RVA: 0x001BDF3B File Offset: 0x001BC13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PNANNPJKKAJ
		{
			get
			{
				return this.pNANNPJKKAJ_;
			}
			set
			{
				this.pNANNPJKKAJ_ = value;
			}
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x0600A5EE RID: 42478 RVA: 0x001BDF44 File Offset: 0x001BC144
		// (set) Token: 0x0600A5EF RID: 42479 RVA: 0x001BDF4C File Offset: 0x001BC14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRecordInfo RecordInfo
		{
			get
			{
				return this.recordInfo_;
			}
			set
			{
				this.recordInfo_ = value;
			}
		}

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x0600A5F0 RID: 42480 RVA: 0x001BDF55 File Offset: 0x001BC155
		// (set) Token: 0x0600A5F1 RID: 42481 RVA: 0x001BDF5D File Offset: 0x001BC15D
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

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0600A5F2 RID: 42482 RVA: 0x001BDF66 File Offset: 0x001BC166
		// (set) Token: 0x0600A5F3 RID: 42483 RVA: 0x001BDF6E File Offset: 0x001BC16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo ILOPGMAHFAE
		{
			get
			{
				return this.iLOPGMAHFAE_;
			}
			set
			{
				this.iLOPGMAHFAE_ = value;
			}
		}

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x0600A5F4 RID: 42484 RVA: 0x001BDF77 File Offset: 0x001BC177
		// (set) Token: 0x0600A5F5 RID: 42485 RVA: 0x001BDF7F File Offset: 0x001BC17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo CLOOABBKDPL
		{
			get
			{
				return this.cLOOABBKDPL_;
			}
			set
			{
				this.cLOOABBKDPL_ = value;
			}
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x0600A5F6 RID: 42486 RVA: 0x001BDF88 File Offset: 0x001BC188
		// (set) Token: 0x0600A5F7 RID: 42487 RVA: 0x001BDF90 File Offset: 0x001BC190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList DCGAGPDHOKB
		{
			get
			{
				return this.dCGAGPDHOKB_;
			}
			set
			{
				this.dCGAGPDHOKB_ = value;
			}
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x001BDF99 File Offset: 0x001BC199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueFinishInfo);
		}

		// Token: 0x0600A5F9 RID: 42489 RVA: 0x001BDFA8 File Offset: 0x001BC1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueFinishInfo other)
		{
			return other != null && (other == this || (this.GNLCJMJDKNC == other.GNLCJMJDKNC && object.Equals(this.OLLFFPHGOLH, other.OLLFFPHGOLH) && this.APBHNOKGEHH == other.APBHNOKGEHH && this.BPDBKNPHLDF == other.BPDBKNPHLDF && this.LEMBCFHPIKC == other.LEMBCFHPIKC && this.MGFOCDPEGKP == other.MGFOCDPEGKP && object.Equals(this.PLJEMKLKMPG, other.PLJEMKLKMPG) && object.Equals(this.JKDEKDLFIHG, other.JKDEKDLFIHG) && this.AreaId == other.AreaId && this.IsWin == other.IsWin && object.Equals(this.NPENEDFJFNI, other.NPENEDFJFNI) && this.PNANNPJKKAJ == other.PNANNPJKKAJ && object.Equals(this.RecordInfo, other.RecordInfo) && this.ScoreId == other.ScoreId && object.Equals(this.ILOPGMAHFAE, other.ILOPGMAHFAE) && object.Equals(this.CLOOABBKDPL, other.CLOOABBKDPL) && object.Equals(this.DCGAGPDHOKB, other.DCGAGPDHOKB) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5FA RID: 42490 RVA: 0x001BE10C File Offset: 0x001BC30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GNLCJMJDKNC)
			{
				num ^= this.GNLCJMJDKNC.GetHashCode();
			}
			if (this.oLLFFPHGOLH_ != null)
			{
				num ^= this.OLLFFPHGOLH.GetHashCode();
			}
			if (this.APBHNOKGEHH != 0U)
			{
				num ^= this.APBHNOKGEHH.GetHashCode();
			}
			if (this.BPDBKNPHLDF != 0U)
			{
				num ^= this.BPDBKNPHLDF.GetHashCode();
			}
			if (this.LEMBCFHPIKC != 0U)
			{
				num ^= this.LEMBCFHPIKC.GetHashCode();
			}
			if (this.MGFOCDPEGKP != 0U)
			{
				num ^= this.MGFOCDPEGKP.GetHashCode();
			}
			if (this.pLJEMKLKMPG_ != null)
			{
				num ^= this.PLJEMKLKMPG.GetHashCode();
			}
			if (this.jKDEKDLFIHG_ != null)
			{
				num ^= this.JKDEKDLFIHG.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this.nPENEDFJFNI_ != null)
			{
				num ^= this.NPENEDFJFNI.GetHashCode();
			}
			if (this.PNANNPJKKAJ != 0U)
			{
				num ^= this.PNANNPJKKAJ.GetHashCode();
			}
			if (this.recordInfo_ != null)
			{
				num ^= this.RecordInfo.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.iLOPGMAHFAE_ != null)
			{
				num ^= this.ILOPGMAHFAE.GetHashCode();
			}
			if (this.cLOOABBKDPL_ != null)
			{
				num ^= this.CLOOABBKDPL.GetHashCode();
			}
			if (this.dCGAGPDHOKB_ != null)
			{
				num ^= this.DCGAGPDHOKB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5FB RID: 42491 RVA: 0x001BE2C3 File Offset: 0x001BC4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A5FC RID: 42492 RVA: 0x001BE2CB File Offset: 0x001BC4CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5FD RID: 42493 RVA: 0x001BE2D4 File Offset: 0x001BC4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iLOPGMAHFAE_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ILOPGMAHFAE);
			}
			if (this.oLLFFPHGOLH_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.OLLFFPHGOLH);
			}
			if (this.BPDBKNPHLDF != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.BPDBKNPHLDF);
			}
			if (this.jKDEKDLFIHG_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.JKDEKDLFIHG);
			}
			if (this.GNLCJMJDKNC)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.GNLCJMJDKNC);
			}
			if (this.nPENEDFJFNI_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.NPENEDFJFNI);
			}
			if (this.dCGAGPDHOKB_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.DCGAGPDHOKB);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.MGFOCDPEGKP != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MGFOCDPEGKP);
			}
			if (this.cLOOABBKDPL_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CLOOABBKDPL);
			}
			if (this.recordInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RecordInfo);
			}
			if (this.PNANNPJKKAJ != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.PNANNPJKKAJ);
			}
			if (this.APBHNOKGEHH != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.APBHNOKGEHH);
			}
			if (this.pLJEMKLKMPG_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PLJEMKLKMPG);
			}
			if (this.IsWin)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsWin);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(216, 12);
				output.WriteUInt32(this.AreaId);
			}
			if (this.LEMBCFHPIKC != 0U)
			{
				output.WriteRawTag(176, 63);
				output.WriteUInt32(this.LEMBCFHPIKC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5FE RID: 42494 RVA: 0x001BE4DC File Offset: 0x001BC6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GNLCJMJDKNC)
			{
				num += 2;
			}
			if (this.oLLFFPHGOLH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OLLFFPHGOLH);
			}
			if (this.APBHNOKGEHH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.APBHNOKGEHH);
			}
			if (this.BPDBKNPHLDF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BPDBKNPHLDF);
			}
			if (this.LEMBCFHPIKC != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LEMBCFHPIKC);
			}
			if (this.MGFOCDPEGKP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MGFOCDPEGKP);
			}
			if (this.pLJEMKLKMPG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PLJEMKLKMPG);
			}
			if (this.jKDEKDLFIHG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JKDEKDLFIHG);
			}
			if (this.AreaId != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.IsWin)
			{
				num += 2;
			}
			if (this.nPENEDFJFNI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NPENEDFJFNI);
			}
			if (this.PNANNPJKKAJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PNANNPJKKAJ);
			}
			if (this.recordInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RecordInfo);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.iLOPGMAHFAE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ILOPGMAHFAE);
			}
			if (this.cLOOABBKDPL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CLOOABBKDPL);
			}
			if (this.dCGAGPDHOKB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DCGAGPDHOKB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5FF RID: 42495 RVA: 0x001BE684 File Offset: 0x001BC884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueFinishInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GNLCJMJDKNC)
			{
				this.GNLCJMJDKNC = other.GNLCJMJDKNC;
			}
			if (other.oLLFFPHGOLH_ != null)
			{
				if (this.oLLFFPHGOLH_ == null)
				{
					this.OLLFFPHGOLH = new ItemList();
				}
				this.OLLFFPHGOLH.MergeFrom(other.OLLFFPHGOLH);
			}
			if (other.APBHNOKGEHH != 0U)
			{
				this.APBHNOKGEHH = other.APBHNOKGEHH;
			}
			if (other.BPDBKNPHLDF != 0U)
			{
				this.BPDBKNPHLDF = other.BPDBKNPHLDF;
			}
			if (other.LEMBCFHPIKC != 0U)
			{
				this.LEMBCFHPIKC = other.LEMBCFHPIKC;
			}
			if (other.MGFOCDPEGKP != 0U)
			{
				this.MGFOCDPEGKP = other.MGFOCDPEGKP;
			}
			if (other.pLJEMKLKMPG_ != null)
			{
				if (this.pLJEMKLKMPG_ == null)
				{
					this.PLJEMKLKMPG = new ItemList();
				}
				this.PLJEMKLKMPG.MergeFrom(other.PLJEMKLKMPG);
			}
			if (other.jKDEKDLFIHG_ != null)
			{
				if (this.jKDEKDLFIHG_ == null)
				{
					this.JKDEKDLFIHG = new RogueExploreScoreInfo();
				}
				this.JKDEKDLFIHG.MergeFrom(other.JKDEKDLFIHG);
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			if (other.nPENEDFJFNI_ != null)
			{
				if (this.nPENEDFJFNI_ == null)
				{
					this.NPENEDFJFNI = new EJHLGGLFNLO();
				}
				this.NPENEDFJFNI.MergeFrom(other.NPENEDFJFNI);
			}
			if (other.PNANNPJKKAJ != 0U)
			{
				this.PNANNPJKKAJ = other.PNANNPJKKAJ;
			}
			if (other.recordInfo_ != null)
			{
				if (this.recordInfo_ == null)
				{
					this.RecordInfo = new RogueRecordInfo();
				}
				this.RecordInfo.MergeFrom(other.RecordInfo);
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.iLOPGMAHFAE_ != null)
			{
				if (this.iLOPGMAHFAE_ == null)
				{
					this.ILOPGMAHFAE = new RogueScoreRewardInfo();
				}
				this.ILOPGMAHFAE.MergeFrom(other.ILOPGMAHFAE);
			}
			if (other.cLOOABBKDPL_ != null)
			{
				if (this.cLOOABBKDPL_ == null)
				{
					this.CLOOABBKDPL = new RogueScoreRewardInfo();
				}
				this.CLOOABBKDPL.MergeFrom(other.CLOOABBKDPL);
			}
			if (other.dCGAGPDHOKB_ != null)
			{
				if (this.dCGAGPDHOKB_ == null)
				{
					this.DCGAGPDHOKB = new ItemList();
				}
				this.DCGAGPDHOKB.MergeFrom(other.DCGAGPDHOKB);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A600 RID: 42496 RVA: 0x001BE8C0 File Offset: 0x001BCAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A601 RID: 42497 RVA: 0x001BE8CC File Offset: 0x001BCACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 34U)
					{
						if (num <= 18U)
						{
							if (num == 10U)
							{
								if (this.iLOPGMAHFAE_ == null)
								{
									this.ILOPGMAHFAE = new RogueScoreRewardInfo();
								}
								input.ReadMessage(this.ILOPGMAHFAE);
								continue;
							}
							if (num == 18U)
							{
								if (this.oLLFFPHGOLH_ == null)
								{
									this.OLLFFPHGOLH = new ItemList();
								}
								input.ReadMessage(this.OLLFFPHGOLH);
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.BPDBKNPHLDF = input.ReadUInt32();
								continue;
							}
							if (num == 34U)
							{
								if (this.jKDEKDLFIHG_ == null)
								{
									this.JKDEKDLFIHG = new RogueExploreScoreInfo();
								}
								input.ReadMessage(this.JKDEKDLFIHG);
								continue;
							}
						}
					}
					else if (num <= 50U)
					{
						if (num == 40U)
						{
							this.GNLCJMJDKNC = input.ReadBool();
							continue;
						}
						if (num == 50U)
						{
							if (this.nPENEDFJFNI_ == null)
							{
								this.NPENEDFJFNI = new EJHLGGLFNLO();
							}
							input.ReadMessage(this.NPENEDFJFNI);
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							if (this.dCGAGPDHOKB_ == null)
							{
								this.DCGAGPDHOKB = new ItemList();
							}
							input.ReadMessage(this.DCGAGPDHOKB);
							continue;
						}
						if (num == 64U)
						{
							this.ScoreId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num <= 82U)
					{
						if (num == 72U)
						{
							this.MGFOCDPEGKP = input.ReadUInt32();
							continue;
						}
						if (num == 82U)
						{
							if (this.cLOOABBKDPL_ == null)
							{
								this.CLOOABBKDPL = new RogueScoreRewardInfo();
							}
							input.ReadMessage(this.CLOOABBKDPL);
							continue;
						}
					}
					else
					{
						if (num == 90U)
						{
							if (this.recordInfo_ == null)
							{
								this.RecordInfo = new RogueRecordInfo();
							}
							input.ReadMessage(this.RecordInfo);
							continue;
						}
						if (num == 96U)
						{
							this.PNANNPJKKAJ = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 114U)
				{
					if (num == 104U)
					{
						this.APBHNOKGEHH = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.pLJEMKLKMPG_ == null)
						{
							this.PLJEMKLKMPG = new ItemList();
						}
						input.ReadMessage(this.PLJEMKLKMPG);
						continue;
					}
				}
				else
				{
					if (num == 120U)
					{
						this.IsWin = input.ReadBool();
						continue;
					}
					if (num == 1624U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
					if (num == 8112U)
					{
						this.LEMBCFHPIKC = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040043BB RID: 17339
		private static readonly MessageParser<RogueFinishInfo> _parser = new MessageParser<RogueFinishInfo>(() => new RogueFinishInfo());

		// Token: 0x040043BC RID: 17340
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043BD RID: 17341
		public const int GNLCJMJDKNCFieldNumber = 5;

		// Token: 0x040043BE RID: 17342
		private bool gNLCJMJDKNC_;

		// Token: 0x040043BF RID: 17343
		public const int OLLFFPHGOLHFieldNumber = 2;

		// Token: 0x040043C0 RID: 17344
		private ItemList oLLFFPHGOLH_;

		// Token: 0x040043C1 RID: 17345
		public const int APBHNOKGEHHFieldNumber = 13;

		// Token: 0x040043C2 RID: 17346
		private uint aPBHNOKGEHH_;

		// Token: 0x040043C3 RID: 17347
		public const int BPDBKNPHLDFFieldNumber = 3;

		// Token: 0x040043C4 RID: 17348
		private uint bPDBKNPHLDF_;

		// Token: 0x040043C5 RID: 17349
		public const int LEMBCFHPIKCFieldNumber = 1014;

		// Token: 0x040043C6 RID: 17350
		private uint lEMBCFHPIKC_;

		// Token: 0x040043C7 RID: 17351
		public const int MGFOCDPEGKPFieldNumber = 9;

		// Token: 0x040043C8 RID: 17352
		private uint mGFOCDPEGKP_;

		// Token: 0x040043C9 RID: 17353
		public const int PLJEMKLKMPGFieldNumber = 14;

		// Token: 0x040043CA RID: 17354
		private ItemList pLJEMKLKMPG_;

		// Token: 0x040043CB RID: 17355
		public const int JKDEKDLFIHGFieldNumber = 4;

		// Token: 0x040043CC RID: 17356
		private RogueExploreScoreInfo jKDEKDLFIHG_;

		// Token: 0x040043CD RID: 17357
		public const int AreaIdFieldNumber = 203;

		// Token: 0x040043CE RID: 17358
		private uint areaId_;

		// Token: 0x040043CF RID: 17359
		public const int IsWinFieldNumber = 15;

		// Token: 0x040043D0 RID: 17360
		private bool isWin_;

		// Token: 0x040043D1 RID: 17361
		public const int NPENEDFJFNIFieldNumber = 6;

		// Token: 0x040043D2 RID: 17362
		private EJHLGGLFNLO nPENEDFJFNI_;

		// Token: 0x040043D3 RID: 17363
		public const int PNANNPJKKAJFieldNumber = 12;

		// Token: 0x040043D4 RID: 17364
		private uint pNANNPJKKAJ_;

		// Token: 0x040043D5 RID: 17365
		public const int RecordInfoFieldNumber = 11;

		// Token: 0x040043D6 RID: 17366
		private RogueRecordInfo recordInfo_;

		// Token: 0x040043D7 RID: 17367
		public const int ScoreIdFieldNumber = 8;

		// Token: 0x040043D8 RID: 17368
		private uint scoreId_;

		// Token: 0x040043D9 RID: 17369
		public const int ILOPGMAHFAEFieldNumber = 1;

		// Token: 0x040043DA RID: 17370
		private RogueScoreRewardInfo iLOPGMAHFAE_;

		// Token: 0x040043DB RID: 17371
		public const int CLOOABBKDPLFieldNumber = 10;

		// Token: 0x040043DC RID: 17372
		private RogueScoreRewardInfo cLOOABBKDPL_;

		// Token: 0x040043DD RID: 17373
		public const int DCGAGPDHOKBFieldNumber = 7;

		// Token: 0x040043DE RID: 17374
		private ItemList dCGAGPDHOKB_;
	}
}
