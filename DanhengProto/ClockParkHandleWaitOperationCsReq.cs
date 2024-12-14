using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002F3 RID: 755
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkHandleWaitOperationCsReq : IMessage<ClockParkHandleWaitOperationCsReq>, IMessage, IEquatable<ClockParkHandleWaitOperationCsReq>, IDeepCloneable<ClockParkHandleWaitOperationCsReq>, IBufferMessage
	{
		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x0005FF32 File Offset: 0x0005E132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkHandleWaitOperationCsReq> Parser
		{
			get
			{
				return ClockParkHandleWaitOperationCsReq._parser;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x0005FF39 File Offset: 0x0005E139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkHandleWaitOperationCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x0005FF4B File Offset: 0x0005E14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkHandleWaitOperationCsReq.Descriptor;
			}
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0005FF52 File Offset: 0x0005E152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkHandleWaitOperationCsReq()
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0005FF5C File Offset: 0x0005E15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkHandleWaitOperationCsReq(ClockParkHandleWaitOperationCsReq other) : this()
		{
			this.scriptId_ = other.scriptId_;
			this.hIAGEINLAHL_ = other.hIAGEINLAHL_;
			this.dBHAFLBPODA_ = ((other.dBHAFLBPODA_ != null) ? other.dBHAFLBPODA_.Clone() : null);
			this.eMJEDJFEFHJ_ = ((other.eMJEDJFEFHJ_ != null) ? other.eMJEDJFEFHJ_.Clone() : null);
			this.oNMPCHLDDGA_ = ((other.oNMPCHLDDGA_ != null) ? other.oNMPCHLDDGA_.Clone() : null);
			this.eNCLLODMEJH_ = ((other.eNCLLODMEJH_ != null) ? other.eNCLLODMEJH_.Clone() : null);
			this.mHEGJKOFOLB_ = ((other.mHEGJKOFOLB_ != null) ? other.mHEGJKOFOLB_.Clone() : null);
			this.kEKMKBFHEED_ = ((other.kEKMKBFHEED_ != null) ? other.kEKMKBFHEED_.Clone() : null);
			this.fHBOCHDINAB_ = ((other.fHBOCHDINAB_ != null) ? other.fHBOCHDINAB_.Clone() : null);
			this.fMPDFFAGKFO_ = other.fMPDFFAGKFO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00060068 File Offset: 0x0005E268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkHandleWaitOperationCsReq Clone()
		{
			return new ClockParkHandleWaitOperationCsReq(this);
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x00060070 File Offset: 0x0005E270
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x00060078 File Offset: 0x0005E278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x00060081 File Offset: 0x0005E281
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x00060089 File Offset: 0x0005E289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HIAGEINLAHL
		{
			get
			{
				return this.hIAGEINLAHL_;
			}
			set
			{
				this.hIAGEINLAHL_ = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x00060092 File Offset: 0x0005E292
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x0006009A File Offset: 0x0005E29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMCBNBOMNKK DBHAFLBPODA
		{
			get
			{
				return this.dBHAFLBPODA_;
			}
			set
			{
				this.dBHAFLBPODA_ = value;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x000600A3 File Offset: 0x0005E2A3
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x000600AB File Offset: 0x0005E2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CAHPBPEEPGB EMJEDJFEFHJ
		{
			get
			{
				return this.eMJEDJFEFHJ_;
			}
			set
			{
				this.eMJEDJFEFHJ_ = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x000600B4 File Offset: 0x0005E2B4
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x000600BC File Offset: 0x0005E2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AJBFJOEIMDM ONMPCHLDDGA
		{
			get
			{
				return this.oNMPCHLDDGA_;
			}
			set
			{
				this.oNMPCHLDDGA_ = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x000600C5 File Offset: 0x0005E2C5
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x000600CD File Offset: 0x0005E2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACJICCNKCLK ENCLLODMEJH
		{
			get
			{
				return this.eNCLLODMEJH_;
			}
			set
			{
				this.eNCLLODMEJH_ = value;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x000600D6 File Offset: 0x0005E2D6
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x000600DE File Offset: 0x0005E2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBHPHEIJPMG MHEGJKOFOLB
		{
			get
			{
				return this.mHEGJKOFOLB_;
			}
			set
			{
				this.mHEGJKOFOLB_ = value;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x000600E7 File Offset: 0x0005E2E7
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x000600EF File Offset: 0x0005E2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KFJJAGAICDE KEKMKBFHEED
		{
			get
			{
				return this.kEKMKBFHEED_;
			}
			set
			{
				this.kEKMKBFHEED_ = value;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x000600F8 File Offset: 0x0005E2F8
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00060100 File Offset: 0x0005E300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DBIACBDCPHE FHBOCHDINAB
		{
			get
			{
				return this.fHBOCHDINAB_;
			}
			set
			{
				this.fHBOCHDINAB_ = value;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x00060109 File Offset: 0x0005E309
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x00060111 File Offset: 0x0005E311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FMPDFFAGKFO
		{
			get
			{
				return this.fMPDFFAGKFO_;
			}
			set
			{
				this.fMPDFFAGKFO_ = value;
			}
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0006011A File Offset: 0x0005E31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkHandleWaitOperationCsReq);
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00060128 File Offset: 0x0005E328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkHandleWaitOperationCsReq other)
		{
			return other != null && (other == this || (this.ScriptId == other.ScriptId && this.HIAGEINLAHL == other.HIAGEINLAHL && object.Equals(this.DBHAFLBPODA, other.DBHAFLBPODA) && object.Equals(this.EMJEDJFEFHJ, other.EMJEDJFEFHJ) && object.Equals(this.ONMPCHLDDGA, other.ONMPCHLDDGA) && object.Equals(this.ENCLLODMEJH, other.ENCLLODMEJH) && object.Equals(this.MHEGJKOFOLB, other.MHEGJKOFOLB) && object.Equals(this.KEKMKBFHEED, other.KEKMKBFHEED) && object.Equals(this.FHBOCHDINAB, other.FHBOCHDINAB) && this.FMPDFFAGKFO == other.FMPDFFAGKFO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00060214 File Offset: 0x0005E414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.HIAGEINLAHL != 0U)
			{
				num ^= this.HIAGEINLAHL.GetHashCode();
			}
			if (this.dBHAFLBPODA_ != null)
			{
				num ^= this.DBHAFLBPODA.GetHashCode();
			}
			if (this.eMJEDJFEFHJ_ != null)
			{
				num ^= this.EMJEDJFEFHJ.GetHashCode();
			}
			if (this.oNMPCHLDDGA_ != null)
			{
				num ^= this.ONMPCHLDDGA.GetHashCode();
			}
			if (this.eNCLLODMEJH_ != null)
			{
				num ^= this.ENCLLODMEJH.GetHashCode();
			}
			if (this.mHEGJKOFOLB_ != null)
			{
				num ^= this.MHEGJKOFOLB.GetHashCode();
			}
			if (this.kEKMKBFHEED_ != null)
			{
				num ^= this.KEKMKBFHEED.GetHashCode();
			}
			if (this.fHBOCHDINAB_ != null)
			{
				num ^= this.FHBOCHDINAB.GetHashCode();
			}
			if (this.FMPDFFAGKFO != 0U)
			{
				num ^= this.FMPDFFAGKFO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0006031F File Offset: 0x0005E51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x00060327 File Offset: 0x0005E527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00060330 File Offset: 0x0005E530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FMPDFFAGKFO != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FMPDFFAGKFO);
			}
			if (this.kEKMKBFHEED_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.KEKMKBFHEED);
			}
			if (this.fHBOCHDINAB_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.FHBOCHDINAB);
			}
			if (this.eNCLLODMEJH_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ENCLLODMEJH);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ScriptId);
			}
			if (this.eMJEDJFEFHJ_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.EMJEDJFEFHJ);
			}
			if (this.oNMPCHLDDGA_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ONMPCHLDDGA);
			}
			if (this.HIAGEINLAHL != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.HIAGEINLAHL);
			}
			if (this.dBHAFLBPODA_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.DBHAFLBPODA);
			}
			if (this.mHEGJKOFOLB_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MHEGJKOFOLB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0006046C File Offset: 0x0005E66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this.HIAGEINLAHL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HIAGEINLAHL);
			}
			if (this.dBHAFLBPODA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DBHAFLBPODA);
			}
			if (this.eMJEDJFEFHJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EMJEDJFEFHJ);
			}
			if (this.oNMPCHLDDGA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ONMPCHLDDGA);
			}
			if (this.eNCLLODMEJH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ENCLLODMEJH);
			}
			if (this.mHEGJKOFOLB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MHEGJKOFOLB);
			}
			if (this.kEKMKBFHEED_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KEKMKBFHEED);
			}
			if (this.fHBOCHDINAB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FHBOCHDINAB);
			}
			if (this.FMPDFFAGKFO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FMPDFFAGKFO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00060584 File Offset: 0x0005E784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkHandleWaitOperationCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.HIAGEINLAHL != 0U)
			{
				this.HIAGEINLAHL = other.HIAGEINLAHL;
			}
			if (other.dBHAFLBPODA_ != null)
			{
				if (this.dBHAFLBPODA_ == null)
				{
					this.DBHAFLBPODA = new LMCBNBOMNKK();
				}
				this.DBHAFLBPODA.MergeFrom(other.DBHAFLBPODA);
			}
			if (other.eMJEDJFEFHJ_ != null)
			{
				if (this.eMJEDJFEFHJ_ == null)
				{
					this.EMJEDJFEFHJ = new CAHPBPEEPGB();
				}
				this.EMJEDJFEFHJ.MergeFrom(other.EMJEDJFEFHJ);
			}
			if (other.oNMPCHLDDGA_ != null)
			{
				if (this.oNMPCHLDDGA_ == null)
				{
					this.ONMPCHLDDGA = new AJBFJOEIMDM();
				}
				this.ONMPCHLDDGA.MergeFrom(other.ONMPCHLDDGA);
			}
			if (other.eNCLLODMEJH_ != null)
			{
				if (this.eNCLLODMEJH_ == null)
				{
					this.ENCLLODMEJH = new ACJICCNKCLK();
				}
				this.ENCLLODMEJH.MergeFrom(other.ENCLLODMEJH);
			}
			if (other.mHEGJKOFOLB_ != null)
			{
				if (this.mHEGJKOFOLB_ == null)
				{
					this.MHEGJKOFOLB = new MBHPHEIJPMG();
				}
				this.MHEGJKOFOLB.MergeFrom(other.MHEGJKOFOLB);
			}
			if (other.kEKMKBFHEED_ != null)
			{
				if (this.kEKMKBFHEED_ == null)
				{
					this.KEKMKBFHEED = new KFJJAGAICDE();
				}
				this.KEKMKBFHEED.MergeFrom(other.KEKMKBFHEED);
			}
			if (other.fHBOCHDINAB_ != null)
			{
				if (this.fHBOCHDINAB_ == null)
				{
					this.FHBOCHDINAB = new DBIACBDCPHE();
				}
				this.FHBOCHDINAB.MergeFrom(other.FHBOCHDINAB);
			}
			if (other.FMPDFFAGKFO != 0U)
			{
				this.FMPDFFAGKFO = other.FMPDFFAGKFO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0006071C File Offset: 0x0005E91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00060728 File Offset: 0x0005E928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 26U)
					{
						if (num == 16U)
						{
							this.FMPDFFAGKFO = input.ReadUInt32();
							continue;
						}
						if (num == 26U)
						{
							if (this.kEKMKBFHEED_ == null)
							{
								this.KEKMKBFHEED = new KFJJAGAICDE();
							}
							input.ReadMessage(this.KEKMKBFHEED);
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.fHBOCHDINAB_ == null)
							{
								this.FHBOCHDINAB = new DBIACBDCPHE();
							}
							input.ReadMessage(this.FHBOCHDINAB);
							continue;
						}
						if (num == 42U)
						{
							if (this.eNCLLODMEJH_ == null)
							{
								this.ENCLLODMEJH = new ACJICCNKCLK();
							}
							input.ReadMessage(this.ENCLLODMEJH);
							continue;
						}
						if (num == 64U)
						{
							this.ScriptId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 74U)
					{
						if (this.eMJEDJFEFHJ_ == null)
						{
							this.EMJEDJFEFHJ = new CAHPBPEEPGB();
						}
						input.ReadMessage(this.EMJEDJFEFHJ);
						continue;
					}
					if (num == 82U)
					{
						if (this.oNMPCHLDDGA_ == null)
						{
							this.ONMPCHLDDGA = new AJBFJOEIMDM();
						}
						input.ReadMessage(this.ONMPCHLDDGA);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.HIAGEINLAHL = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.dBHAFLBPODA_ == null)
						{
							this.DBHAFLBPODA = new LMCBNBOMNKK();
						}
						input.ReadMessage(this.DBHAFLBPODA);
						continue;
					}
					if (num == 114U)
					{
						if (this.mHEGJKOFOLB_ == null)
						{
							this.MHEGJKOFOLB = new MBHPHEIJPMG();
						}
						input.ReadMessage(this.MHEGJKOFOLB);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000DE8 RID: 3560
		private static readonly MessageParser<ClockParkHandleWaitOperationCsReq> _parser = new MessageParser<ClockParkHandleWaitOperationCsReq>(() => new ClockParkHandleWaitOperationCsReq());

		// Token: 0x04000DE9 RID: 3561
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DEA RID: 3562
		public const int ScriptIdFieldNumber = 8;

		// Token: 0x04000DEB RID: 3563
		private uint scriptId_;

		// Token: 0x04000DEC RID: 3564
		public const int HIAGEINLAHLFieldNumber = 12;

		// Token: 0x04000DED RID: 3565
		private uint hIAGEINLAHL_;

		// Token: 0x04000DEE RID: 3566
		public const int DBHAFLBPODAFieldNumber = 13;

		// Token: 0x04000DEF RID: 3567
		private LMCBNBOMNKK dBHAFLBPODA_;

		// Token: 0x04000DF0 RID: 3568
		public const int EMJEDJFEFHJFieldNumber = 9;

		// Token: 0x04000DF1 RID: 3569
		private CAHPBPEEPGB eMJEDJFEFHJ_;

		// Token: 0x04000DF2 RID: 3570
		public const int ONMPCHLDDGAFieldNumber = 10;

		// Token: 0x04000DF3 RID: 3571
		private AJBFJOEIMDM oNMPCHLDDGA_;

		// Token: 0x04000DF4 RID: 3572
		public const int ENCLLODMEJHFieldNumber = 5;

		// Token: 0x04000DF5 RID: 3573
		private ACJICCNKCLK eNCLLODMEJH_;

		// Token: 0x04000DF6 RID: 3574
		public const int MHEGJKOFOLBFieldNumber = 14;

		// Token: 0x04000DF7 RID: 3575
		private MBHPHEIJPMG mHEGJKOFOLB_;

		// Token: 0x04000DF8 RID: 3576
		public const int KEKMKBFHEEDFieldNumber = 3;

		// Token: 0x04000DF9 RID: 3577
		private KFJJAGAICDE kEKMKBFHEED_;

		// Token: 0x04000DFA RID: 3578
		public const int FHBOCHDINABFieldNumber = 4;

		// Token: 0x04000DFB RID: 3579
		private DBIACBDCPHE fHBOCHDINAB_;

		// Token: 0x04000DFC RID: 3580
		public const int FMPDFFAGKFOFieldNumber = 2;

		// Token: 0x04000DFD RID: 3581
		private uint fMPDFFAGKFO_;
	}
}
