using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002F1 RID: 753
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkGetOngoingScriptInfoScRsp : IMessage<ClockParkGetOngoingScriptInfoScRsp>, IMessage, IEquatable<ClockParkGetOngoingScriptInfoScRsp>, IDeepCloneable<ClockParkGetOngoingScriptInfoScRsp>, IBufferMessage
	{
		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x0005F37E File Offset: 0x0005D57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkGetOngoingScriptInfoScRsp> Parser
		{
			get
			{
				return ClockParkGetOngoingScriptInfoScRsp._parser;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x0005F385 File Offset: 0x0005D585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkGetOngoingScriptInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x0005F397 File Offset: 0x0005D597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkGetOngoingScriptInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0005F39E File Offset: 0x0005D59E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetOngoingScriptInfoScRsp()
		{
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x0005F3BC File Offset: 0x0005D5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetOngoingScriptInfoScRsp(ClockParkGetOngoingScriptInfoScRsp other) : this()
		{
			this.fMPDFFAGKFO_ = other.fMPDFFAGKFO_;
			this.retcode_ = other.retcode_;
			this.rogueBuffInfo_ = ((other.rogueBuffInfo_ != null) ? other.rogueBuffInfo_.Clone() : null);
			this.jFMPKBHGOPE_ = other.jFMPKBHGOPE_;
			this.gKEADPKKANG_ = other.gKEADPKKANG_.Clone();
			this.oCBBEAJPFGF_ = ((other.oCBBEAJPFGF_ != null) ? other.oCBBEAJPFGF_.Clone() : null);
			this.fIHJEFNGFEK_ = ((other.fIHJEFNGFEK_ != null) ? other.fIHJEFNGFEK_.Clone() : null);
			this.fMHJAGNLOFD_ = other.fMHJAGNLOFD_;
			this.iBFECHKNJAL_ = other.iBFECHKNJAL_;
			this.gAKDAENACOD_ = other.gAKDAENACOD_;
			this.cIGPMMBDEJD_ = other.cIGPMMBDEJD_;
			this.scriptId_ = other.scriptId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0005F4A5 File Offset: 0x0005D6A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetOngoingScriptInfoScRsp Clone()
		{
			return new ClockParkGetOngoingScriptInfoScRsp(this);
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x0005F4AD File Offset: 0x0005D6AD
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x0005F4B5 File Offset: 0x0005D6B5
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

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x0005F4BE File Offset: 0x0005D6BE
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x0005F4C6 File Offset: 0x0005D6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x0005F4CF File Offset: 0x0005D6CF
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x0005F4D7 File Offset: 0x0005D6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKIOOBNBDEB RogueBuffInfo
		{
			get
			{
				return this.rogueBuffInfo_;
			}
			set
			{
				this.rogueBuffInfo_ = value;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x0005F4E0 File Offset: 0x0005D6E0
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x0005F4E8 File Offset: 0x0005D6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JFMPKBHGOPE
		{
			get
			{
				return this.jFMPKBHGOPE_;
			}
			set
			{
				this.jFMPKBHGOPE_ = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x0005F4F1 File Offset: 0x0005D6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GKEADPKKANG
		{
			get
			{
				return this.gKEADPKKANG_;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x0005F4F9 File Offset: 0x0005D6F9
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x0005F501 File Offset: 0x0005D701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IMJPKICFBLI OCBBEAJPFGF
		{
			get
			{
				return this.oCBBEAJPFGF_;
			}
			set
			{
				this.oCBBEAJPFGF_ = value;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x0005F50A File Offset: 0x0005D70A
		// (set) Token: 0x060021A7 RID: 8615 RVA: 0x0005F512 File Offset: 0x0005D712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CMEBMINNJON FIHJEFNGFEK
		{
			get
			{
				return this.fIHJEFNGFEK_;
			}
			set
			{
				this.fIHJEFNGFEK_ = value;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x0005F51B File Offset: 0x0005D71B
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x0005F523 File Offset: 0x0005D723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FMHJAGNLOFD
		{
			get
			{
				return this.fMHJAGNLOFD_;
			}
			set
			{
				this.fMHJAGNLOFD_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x0005F536 File Offset: 0x0005D736
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x0005F53E File Offset: 0x0005D73E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IBFECHKNJAL
		{
			get
			{
				return this.iBFECHKNJAL_;
			}
			set
			{
				this.iBFECHKNJAL_ = value;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x0005F547 File Offset: 0x0005D747
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x0005F54F File Offset: 0x0005D74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GAKDAENACOD
		{
			get
			{
				return this.gAKDAENACOD_;
			}
			set
			{
				this.gAKDAENACOD_ = value;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x0005F558 File Offset: 0x0005D758
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x0005F560 File Offset: 0x0005D760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CIGPMMBDEJD
		{
			get
			{
				return this.cIGPMMBDEJD_;
			}
			set
			{
				this.cIGPMMBDEJD_ = value;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x0005F569 File Offset: 0x0005D769
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x0005F571 File Offset: 0x0005D771
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

		// Token: 0x060021B2 RID: 8626 RVA: 0x0005F57A File Offset: 0x0005D77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkGetOngoingScriptInfoScRsp);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0005F588 File Offset: 0x0005D788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkGetOngoingScriptInfoScRsp other)
		{
			return other != null && (other == this || (this.FMPDFFAGKFO == other.FMPDFFAGKFO && this.Retcode == other.Retcode && object.Equals(this.RogueBuffInfo, other.RogueBuffInfo) && this.JFMPKBHGOPE == other.JFMPKBHGOPE && this.gKEADPKKANG_.Equals(other.gKEADPKKANG_) && object.Equals(this.OCBBEAJPFGF, other.OCBBEAJPFGF) && object.Equals(this.FIHJEFNGFEK, other.FIHJEFNGFEK) && !(this.FMHJAGNLOFD != other.FMHJAGNLOFD) && this.IBFECHKNJAL == other.IBFECHKNJAL && this.GAKDAENACOD == other.GAKDAENACOD && this.CIGPMMBDEJD == other.CIGPMMBDEJD && this.ScriptId == other.ScriptId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x0005F68C File Offset: 0x0005D88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FMPDFFAGKFO != 0U)
			{
				num ^= this.FMPDFFAGKFO.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueBuffInfo_ != null)
			{
				num ^= this.RogueBuffInfo.GetHashCode();
			}
			if (this.JFMPKBHGOPE != 0U)
			{
				num ^= this.JFMPKBHGOPE.GetHashCode();
			}
			num ^= this.gKEADPKKANG_.GetHashCode();
			if (this.oCBBEAJPFGF_ != null)
			{
				num ^= this.OCBBEAJPFGF.GetHashCode();
			}
			if (this.fIHJEFNGFEK_ != null)
			{
				num ^= this.FIHJEFNGFEK.GetHashCode();
			}
			if (this.FMHJAGNLOFD.Length != 0)
			{
				num ^= this.FMHJAGNLOFD.GetHashCode();
			}
			if (this.IBFECHKNJAL != 0U)
			{
				num ^= this.IBFECHKNJAL.GetHashCode();
			}
			if (this.GAKDAENACOD != 0U)
			{
				num ^= this.GAKDAENACOD.GetHashCode();
			}
			if (this.CIGPMMBDEJD != 0U)
			{
				num ^= this.CIGPMMBDEJD.GetHashCode();
			}
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x0005F7CC File Offset: 0x0005D9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0005F7D4 File Offset: 0x0005D9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0005F7E0 File Offset: 0x0005D9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IBFECHKNJAL != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.IBFECHKNJAL);
			}
			if (this.FMHJAGNLOFD.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.FMHJAGNLOFD);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ScriptId);
			}
			if (this.CIGPMMBDEJD != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CIGPMMBDEJD);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.FMPDFFAGKFO != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.FMPDFFAGKFO);
			}
			if (this.rogueBuffInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RogueBuffInfo);
			}
			if (this.oCBBEAJPFGF_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.OCBBEAJPFGF);
			}
			this.gKEADPKKANG_.WriteTo(ref output, ClockParkGetOngoingScriptInfoScRsp._repeated_gKEADPKKANG_codec);
			if (this.fIHJEFNGFEK_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.FIHJEFNGFEK);
			}
			if (this.GAKDAENACOD != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.GAKDAENACOD);
			}
			if (this.JFMPKBHGOPE != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.JFMPKBHGOPE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x0005F94C File Offset: 0x0005DB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FMPDFFAGKFO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FMPDFFAGKFO);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuffInfo);
			}
			if (this.JFMPKBHGOPE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JFMPKBHGOPE);
			}
			num += this.gKEADPKKANG_.CalculateSize(ClockParkGetOngoingScriptInfoScRsp._repeated_gKEADPKKANG_codec);
			if (this.oCBBEAJPFGF_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OCBBEAJPFGF);
			}
			if (this.fIHJEFNGFEK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FIHJEFNGFEK);
			}
			if (this.FMHJAGNLOFD.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FMHJAGNLOFD);
			}
			if (this.IBFECHKNJAL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IBFECHKNJAL);
			}
			if (this.GAKDAENACOD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GAKDAENACOD);
			}
			if (this.CIGPMMBDEJD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CIGPMMBDEJD);
			}
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0005FA94 File Offset: 0x0005DC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkGetOngoingScriptInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FMPDFFAGKFO != 0U)
			{
				this.FMPDFFAGKFO = other.FMPDFFAGKFO;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueBuffInfo_ != null)
			{
				if (this.rogueBuffInfo_ == null)
				{
					this.RogueBuffInfo = new OKIOOBNBDEB();
				}
				this.RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
			}
			if (other.JFMPKBHGOPE != 0U)
			{
				this.JFMPKBHGOPE = other.JFMPKBHGOPE;
			}
			this.gKEADPKKANG_.Add(other.gKEADPKKANG_);
			if (other.oCBBEAJPFGF_ != null)
			{
				if (this.oCBBEAJPFGF_ == null)
				{
					this.OCBBEAJPFGF = new IMJPKICFBLI();
				}
				this.OCBBEAJPFGF.MergeFrom(other.OCBBEAJPFGF);
			}
			if (other.fIHJEFNGFEK_ != null)
			{
				if (this.fIHJEFNGFEK_ == null)
				{
					this.FIHJEFNGFEK = new CMEBMINNJON();
				}
				this.FIHJEFNGFEK.MergeFrom(other.FIHJEFNGFEK);
			}
			if (other.FMHJAGNLOFD.Length != 0)
			{
				this.FMHJAGNLOFD = other.FMHJAGNLOFD;
			}
			if (other.IBFECHKNJAL != 0U)
			{
				this.IBFECHKNJAL = other.IBFECHKNJAL;
			}
			if (other.GAKDAENACOD != 0U)
			{
				this.GAKDAENACOD = other.GAKDAENACOD;
			}
			if (other.CIGPMMBDEJD != 0U)
			{
				this.CIGPMMBDEJD = other.CIGPMMBDEJD;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0005FBF6 File Offset: 0x0005DDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x0005FC00 File Offset: 0x0005DE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 48U)
				{
					if (num <= 80U)
					{
						if (num == 66U)
						{
							if (this.rogueBuffInfo_ == null)
							{
								this.RogueBuffInfo = new OKIOOBNBDEB();
							}
							input.ReadMessage(this.RogueBuffInfo);
							continue;
						}
						if (num == 74U)
						{
							if (this.oCBBEAJPFGF_ == null)
							{
								this.OCBBEAJPFGF = new IMJPKICFBLI();
							}
							input.ReadMessage(this.OCBBEAJPFGF);
							continue;
						}
						if (num != 80U)
						{
							goto IL_88;
						}
					}
					else if (num <= 90U)
					{
						if (num != 82U)
						{
							if (num != 90U)
							{
								goto IL_88;
							}
							if (this.fIHJEFNGFEK_ == null)
							{
								this.FIHJEFNGFEK = new CMEBMINNJON();
							}
							input.ReadMessage(this.FIHJEFNGFEK);
							continue;
						}
					}
					else
					{
						if (num == 96U)
						{
							this.GAKDAENACOD = input.ReadUInt32();
							continue;
						}
						if (num != 120U)
						{
							goto IL_88;
						}
						this.JFMPKBHGOPE = input.ReadUInt32();
						continue;
					}
					this.gKEADPKKANG_.AddEntriesFrom(ref input, ClockParkGetOngoingScriptInfoScRsp._repeated_gKEADPKKANG_codec);
					continue;
				}
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.IBFECHKNJAL = input.ReadUInt32();
						continue;
					}
					if (num == 18U)
					{
						this.FMHJAGNLOFD = input.ReadString();
						continue;
					}
					if (num == 24U)
					{
						this.ScriptId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.CIGPMMBDEJD = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.FMPDFFAGKFO = input.ReadUInt32();
						continue;
					}
				}
				IL_88:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000DCC RID: 3532
		private static readonly MessageParser<ClockParkGetOngoingScriptInfoScRsp> _parser = new MessageParser<ClockParkGetOngoingScriptInfoScRsp>(() => new ClockParkGetOngoingScriptInfoScRsp());

		// Token: 0x04000DCD RID: 3533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DCE RID: 3534
		public const int FMPDFFAGKFOFieldNumber = 6;

		// Token: 0x04000DCF RID: 3535
		private uint fMPDFFAGKFO_;

		// Token: 0x04000DD0 RID: 3536
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04000DD1 RID: 3537
		private uint retcode_;

		// Token: 0x04000DD2 RID: 3538
		public const int RogueBuffInfoFieldNumber = 8;

		// Token: 0x04000DD3 RID: 3539
		private OKIOOBNBDEB rogueBuffInfo_;

		// Token: 0x04000DD4 RID: 3540
		public const int JFMPKBHGOPEFieldNumber = 15;

		// Token: 0x04000DD5 RID: 3541
		private uint jFMPKBHGOPE_;

		// Token: 0x04000DD6 RID: 3542
		public const int GKEADPKKANGFieldNumber = 10;

		// Token: 0x04000DD7 RID: 3543
		private static readonly FieldCodec<uint> _repeated_gKEADPKKANG_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04000DD8 RID: 3544
		private readonly RepeatedField<uint> gKEADPKKANG_ = new RepeatedField<uint>();

		// Token: 0x04000DD9 RID: 3545
		public const int OCBBEAJPFGFFieldNumber = 9;

		// Token: 0x04000DDA RID: 3546
		private IMJPKICFBLI oCBBEAJPFGF_;

		// Token: 0x04000DDB RID: 3547
		public const int FIHJEFNGFEKFieldNumber = 11;

		// Token: 0x04000DDC RID: 3548
		private CMEBMINNJON fIHJEFNGFEK_;

		// Token: 0x04000DDD RID: 3549
		public const int FMHJAGNLOFDFieldNumber = 2;

		// Token: 0x04000DDE RID: 3550
		private string fMHJAGNLOFD_ = "";

		// Token: 0x04000DDF RID: 3551
		public const int IBFECHKNJALFieldNumber = 1;

		// Token: 0x04000DE0 RID: 3552
		private uint iBFECHKNJAL_;

		// Token: 0x04000DE1 RID: 3553
		public const int GAKDAENACODFieldNumber = 12;

		// Token: 0x04000DE2 RID: 3554
		private uint gAKDAENACOD_;

		// Token: 0x04000DE3 RID: 3555
		public const int CIGPMMBDEJDFieldNumber = 4;

		// Token: 0x04000DE4 RID: 3556
		private uint cIGPMMBDEJD_;

		// Token: 0x04000DE5 RID: 3557
		public const int ScriptIdFieldNumber = 3;

		// Token: 0x04000DE6 RID: 3558
		private uint scriptId_;
	}
}
