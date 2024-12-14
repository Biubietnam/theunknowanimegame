using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200008D RID: 141
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyPlacingGameCsReq : IMessage<AlleyPlacingGameCsReq>, IMessage, IEquatable<AlleyPlacingGameCsReq>, IDeepCloneable<AlleyPlacingGameCsReq>, IBufferMessage
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00010D9C File Offset: 0x0000EF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyPlacingGameCsReq> Parser
		{
			get
			{
				return AlleyPlacingGameCsReq._parser;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00010DA3 File Offset: 0x0000EFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyPlacingGameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00010DB5 File Offset: 0x0000EFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyPlacingGameCsReq.Descriptor;
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00010DBC File Offset: 0x0000EFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingGameCsReq()
		{
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingGameCsReq(AlleyPlacingGameCsReq other) : this()
		{
			this.hJFAJPDPPCO_ = other.hJFAJPDPPCO_;
			this.gJBEINMDEIC_ = other.gJBEINMDEIC_;
			this.costTime_ = other.costTime_;
			this.kKLABDFIIKJ_ = other.kKLABDFIIKJ_;
			this.mEOAIBDFFIB_ = other.mEOAIBDFFIB_;
			this.jLDHAKPMJNM_ = ((other.jLDHAKPMJNM_ != null) ? other.jLDHAKPMJNM_.Clone() : null);
			this.oKPEFKACCCI_ = other.oKPEFKACCCI_;
			this.mHJBFLBMGMH_ = other.mHJBFLBMGMH_;
			this.nGKJIPICMPG_ = other.nGKJIPICMPG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00010E64 File Offset: 0x0000F064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingGameCsReq Clone()
		{
			return new AlleyPlacingGameCsReq(this);
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00010E6C File Offset: 0x0000F06C
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00010E74 File Offset: 0x0000F074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HJFAJPDPPCO
		{
			get
			{
				return this.hJFAJPDPPCO_;
			}
			set
			{
				this.hJFAJPDPPCO_ = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00010E7D File Offset: 0x0000F07D
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00010E85 File Offset: 0x0000F085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GJBEINMDEIC
		{
			get
			{
				return this.gJBEINMDEIC_;
			}
			set
			{
				this.gJBEINMDEIC_ = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00010E8E File Offset: 0x0000F08E
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00010E96 File Offset: 0x0000F096
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

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00010E9F File Offset: 0x0000F09F
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00010EA7 File Offset: 0x0000F0A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KKLABDFIIKJ
		{
			get
			{
				return this.kKLABDFIIKJ_;
			}
			set
			{
				this.kKLABDFIIKJ_ = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MEOAIBDFFIB
		{
			get
			{
				return this.mEOAIBDFFIB_;
			}
			set
			{
				this.mEOAIBDFFIB_ = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00010EC1 File Offset: 0x0000F0C1
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00010EC9 File Offset: 0x0000F0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingShip JLDHAKPMJNM
		{
			get
			{
				return this.jLDHAKPMJNM_;
			}
			set
			{
				this.jLDHAKPMJNM_ = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00010ED2 File Offset: 0x0000F0D2
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00010EDA File Offset: 0x0000F0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OKPEFKACCCI
		{
			get
			{
				return this.oKPEFKACCCI_;
			}
			set
			{
				this.oKPEFKACCCI_ = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00010EE3 File Offset: 0x0000F0E3
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00010EEB File Offset: 0x0000F0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MHJBFLBMGMH
		{
			get
			{
				return this.mHJBFLBMGMH_;
			}
			set
			{
				this.mHJBFLBMGMH_ = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00010EF4 File Offset: 0x0000F0F4
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00010EFC File Offset: 0x0000F0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NGKJIPICMPG
		{
			get
			{
				return this.nGKJIPICMPG_;
			}
			set
			{
				this.nGKJIPICMPG_ = value;
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00010F05 File Offset: 0x0000F105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyPlacingGameCsReq);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00010F14 File Offset: 0x0000F114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyPlacingGameCsReq other)
		{
			return other != null && (other == this || (this.HJFAJPDPPCO == other.HJFAJPDPPCO && this.GJBEINMDEIC == other.GJBEINMDEIC && this.CostTime == other.CostTime && this.KKLABDFIIKJ == other.KKLABDFIIKJ && this.MEOAIBDFFIB == other.MEOAIBDFFIB && object.Equals(this.JLDHAKPMJNM, other.JLDHAKPMJNM) && this.OKPEFKACCCI == other.OKPEFKACCCI && this.MHJBFLBMGMH == other.MHJBFLBMGMH && this.NGKJIPICMPG == other.NGKJIPICMPG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00010FD4 File Offset: 0x0000F1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HJFAJPDPPCO != 0U)
			{
				num ^= this.HJFAJPDPPCO.GetHashCode();
			}
			if (this.GJBEINMDEIC != 0U)
			{
				num ^= this.GJBEINMDEIC.GetHashCode();
			}
			if (this.CostTime != 0U)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this.KKLABDFIIKJ != 0U)
			{
				num ^= this.KKLABDFIIKJ.GetHashCode();
			}
			if (this.MEOAIBDFFIB != 0U)
			{
				num ^= this.MEOAIBDFFIB.GetHashCode();
			}
			if (this.jLDHAKPMJNM_ != null)
			{
				num ^= this.JLDHAKPMJNM.GetHashCode();
			}
			if (this.OKPEFKACCCI != 0U)
			{
				num ^= this.OKPEFKACCCI.GetHashCode();
			}
			if (this.MHJBFLBMGMH != 0U)
			{
				num ^= this.MHJBFLBMGMH.GetHashCode();
			}
			if (this.NGKJIPICMPG != 0U)
			{
				num ^= this.NGKJIPICMPG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000110D8 File Offset: 0x0000F2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000110E0 File Offset: 0x0000F2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000110EC File Offset: 0x0000F2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KKLABDFIIKJ != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.KKLABDFIIKJ);
			}
			if (this.HJFAJPDPPCO != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.HJFAJPDPPCO);
			}
			if (this.CostTime != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CostTime);
			}
			if (this.NGKJIPICMPG != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.NGKJIPICMPG);
			}
			if (this.GJBEINMDEIC != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.GJBEINMDEIC);
			}
			if (this.MHJBFLBMGMH != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MHJBFLBMGMH);
			}
			if (this.jLDHAKPMJNM_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.JLDHAKPMJNM);
			}
			if (this.MEOAIBDFFIB != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MEOAIBDFFIB);
			}
			if (this.OKPEFKACCCI != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.OKPEFKACCCI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0001120C File Offset: 0x0000F40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HJFAJPDPPCO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HJFAJPDPPCO);
			}
			if (this.GJBEINMDEIC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GJBEINMDEIC);
			}
			if (this.CostTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CostTime);
			}
			if (this.KKLABDFIIKJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KKLABDFIIKJ);
			}
			if (this.MEOAIBDFFIB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MEOAIBDFFIB);
			}
			if (this.jLDHAKPMJNM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JLDHAKPMJNM);
			}
			if (this.OKPEFKACCCI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OKPEFKACCCI);
			}
			if (this.MHJBFLBMGMH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MHJBFLBMGMH);
			}
			if (this.NGKJIPICMPG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NGKJIPICMPG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001130C File Offset: 0x0000F50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyPlacingGameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HJFAJPDPPCO != 0U)
			{
				this.HJFAJPDPPCO = other.HJFAJPDPPCO;
			}
			if (other.GJBEINMDEIC != 0U)
			{
				this.GJBEINMDEIC = other.GJBEINMDEIC;
			}
			if (other.CostTime != 0U)
			{
				this.CostTime = other.CostTime;
			}
			if (other.KKLABDFIIKJ != 0U)
			{
				this.KKLABDFIIKJ = other.KKLABDFIIKJ;
			}
			if (other.MEOAIBDFFIB != 0U)
			{
				this.MEOAIBDFFIB = other.MEOAIBDFFIB;
			}
			if (other.jLDHAKPMJNM_ != null)
			{
				if (this.jLDHAKPMJNM_ == null)
				{
					this.JLDHAKPMJNM = new AlleyPlacingShip();
				}
				this.JLDHAKPMJNM.MergeFrom(other.JLDHAKPMJNM);
			}
			if (other.OKPEFKACCCI != 0U)
			{
				this.OKPEFKACCCI = other.OKPEFKACCCI;
			}
			if (other.MHJBFLBMGMH != 0U)
			{
				this.MHJBFLBMGMH = other.MHJBFLBMGMH;
			}
			if (other.NGKJIPICMPG != 0U)
			{
				this.NGKJIPICMPG = other.NGKJIPICMPG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00011400 File Offset: 0x0000F600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001140C File Offset: 0x0000F60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 40U)
					{
						if (num == 32U)
						{
							this.KKLABDFIIKJ = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.HJFAJPDPPCO = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.CostTime = input.ReadUInt32();
							continue;
						}
						if (num == 56U)
						{
							this.NGKJIPICMPG = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 72U)
					{
						this.GJBEINMDEIC = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.MHJBFLBMGMH = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.jLDHAKPMJNM_ == null)
						{
							this.JLDHAKPMJNM = new AlleyPlacingShip();
						}
						input.ReadMessage(this.JLDHAKPMJNM);
						continue;
					}
					if (num == 112U)
					{
						this.MEOAIBDFFIB = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.OKPEFKACCCI = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400022B RID: 555
		private static readonly MessageParser<AlleyPlacingGameCsReq> _parser = new MessageParser<AlleyPlacingGameCsReq>(() => new AlleyPlacingGameCsReq());

		// Token: 0x0400022C RID: 556
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400022D RID: 557
		public const int HJFAJPDPPCOFieldNumber = 5;

		// Token: 0x0400022E RID: 558
		private uint hJFAJPDPPCO_;

		// Token: 0x0400022F RID: 559
		public const int GJBEINMDEICFieldNumber = 9;

		// Token: 0x04000230 RID: 560
		private uint gJBEINMDEIC_;

		// Token: 0x04000231 RID: 561
		public const int CostTimeFieldNumber = 6;

		// Token: 0x04000232 RID: 562
		private uint costTime_;

		// Token: 0x04000233 RID: 563
		public const int KKLABDFIIKJFieldNumber = 4;

		// Token: 0x04000234 RID: 564
		private uint kKLABDFIIKJ_;

		// Token: 0x04000235 RID: 565
		public const int MEOAIBDFFIBFieldNumber = 14;

		// Token: 0x04000236 RID: 566
		private uint mEOAIBDFFIB_;

		// Token: 0x04000237 RID: 567
		public const int JLDHAKPMJNMFieldNumber = 13;

		// Token: 0x04000238 RID: 568
		private AlleyPlacingShip jLDHAKPMJNM_;

		// Token: 0x04000239 RID: 569
		public const int OKPEFKACCCIFieldNumber = 15;

		// Token: 0x0400023A RID: 570
		private uint oKPEFKACCCI_;

		// Token: 0x0400023B RID: 571
		public const int MHJBFLBMGMHFieldNumber = 12;

		// Token: 0x0400023C RID: 572
		private uint mHJBFLBMGMH_;

		// Token: 0x0400023D RID: 573
		public const int NGKJIPICMPGFieldNumber = 7;

		// Token: 0x0400023E RID: 574
		private uint nGKJIPICMPG_;
	}
}
