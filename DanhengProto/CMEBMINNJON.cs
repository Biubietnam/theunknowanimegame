using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000309 RID: 777
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CMEBMINNJON : IMessage<CMEBMINNJON>, IMessage, IEquatable<CMEBMINNJON>, IDeepCloneable<CMEBMINNJON>, IBufferMessage
	{
		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x00062DF7 File Offset: 0x00060FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CMEBMINNJON> Parser
		{
			get
			{
				return CMEBMINNJON._parser;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00062DFE File Offset: 0x00060FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CMEBMINNJONReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x00062E10 File Offset: 0x00061010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CMEBMINNJON.Descriptor;
			}
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00062E17 File Offset: 0x00061017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CMEBMINNJON()
		{
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x00062E20 File Offset: 0x00061020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CMEBMINNJON(CMEBMINNJON other) : this()
		{
			this.hIAGEINLAHL_ = other.hIAGEINLAHL_;
			this.fBBEHFHPOPD_ = ((other.fBBEHFHPOPD_ != null) ? other.fBBEHFHPOPD_.Clone() : null);
			this.nGBMDKDKBGG_ = ((other.nGBMDKDKBGG_ != null) ? other.nGBMDKDKBGG_.Clone() : null);
			this.iMFFNDDABLB_ = ((other.iMFFNDDABLB_ != null) ? other.iMFFNDDABLB_.Clone() : null);
			this.fCFHJBPPBLO_ = ((other.fCFHJBPPBLO_ != null) ? other.fCFHJBPPBLO_.Clone() : null);
			this.fLJFEHGOBDB_ = ((other.fLJFEHGOBDB_ != null) ? other.fLJFEHGOBDB_.Clone() : null);
			this.mCBGNPDEOBN_ = ((other.mCBGNPDEOBN_ != null) ? other.mCBGNPDEOBN_.Clone() : null);
			this.aGPJDEJALFH_ = ((other.aGPJDEJALFH_ != null) ? other.aGPJDEJALFH_.Clone() : null);
			this.aEKEHEMKPID_ = other.aEKEHEMKPID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00062F20 File Offset: 0x00061120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CMEBMINNJON Clone()
		{
			return new CMEBMINNJON(this);
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x00062F28 File Offset: 0x00061128
		// (set) Token: 0x060022CB RID: 8907 RVA: 0x00062F30 File Offset: 0x00061130
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

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x00062F39 File Offset: 0x00061139
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x00062F41 File Offset: 0x00061141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DCMFOFEBFAK FBBEHFHPOPD
		{
			get
			{
				return this.fBBEHFHPOPD_;
			}
			set
			{
				this.fBBEHFHPOPD_ = value;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x00062F4A File Offset: 0x0006114A
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x00062F52 File Offset: 0x00061152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DGPMABEJOMJ NGBMDKDKBGG
		{
			get
			{
				return this.nGBMDKDKBGG_;
			}
			set
			{
				this.nGBMDKDKBGG_ = value;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00062F5B File Offset: 0x0006115B
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x00062F63 File Offset: 0x00061163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELBENNKHNLC IMFFNDDABLB
		{
			get
			{
				return this.iMFFNDDABLB_;
			}
			set
			{
				this.iMFFNDDABLB_ = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x00062F6C File Offset: 0x0006116C
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x00062F74 File Offset: 0x00061174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDELAMMCOII FCFHJBPPBLO
		{
			get
			{
				return this.fCFHJBPPBLO_;
			}
			set
			{
				this.fCFHJBPPBLO_ = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x00062F7D File Offset: 0x0006117D
		// (set) Token: 0x060022D5 RID: 8917 RVA: 0x00062F85 File Offset: 0x00061185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DKPPCLLGIMC FLJFEHGOBDB
		{
			get
			{
				return this.fLJFEHGOBDB_;
			}
			set
			{
				this.fLJFEHGOBDB_ = value;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x00062F8E File Offset: 0x0006118E
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x00062F96 File Offset: 0x00061196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAFOJMLECPG MCBGNPDEOBN
		{
			get
			{
				return this.mCBGNPDEOBN_;
			}
			set
			{
				this.mCBGNPDEOBN_ = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x00062F9F File Offset: 0x0006119F
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x00062FA7 File Offset: 0x000611A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CMNFMIHMGID AGPJDEJALFH
		{
			get
			{
				return this.aGPJDEJALFH_;
			}
			set
			{
				this.aGPJDEJALFH_ = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x00062FB0 File Offset: 0x000611B0
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x00062FB8 File Offset: 0x000611B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AEKEHEMKPID
		{
			get
			{
				return this.aEKEHEMKPID_;
			}
			set
			{
				this.aEKEHEMKPID_ = value;
			}
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00062FC1 File Offset: 0x000611C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CMEBMINNJON);
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x00062FD0 File Offset: 0x000611D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CMEBMINNJON other)
		{
			return other != null && (other == this || (this.HIAGEINLAHL == other.HIAGEINLAHL && object.Equals(this.FBBEHFHPOPD, other.FBBEHFHPOPD) && object.Equals(this.NGBMDKDKBGG, other.NGBMDKDKBGG) && object.Equals(this.IMFFNDDABLB, other.IMFFNDDABLB) && object.Equals(this.FCFHJBPPBLO, other.FCFHJBPPBLO) && object.Equals(this.FLJFEHGOBDB, other.FLJFEHGOBDB) && object.Equals(this.MCBGNPDEOBN, other.MCBGNPDEOBN) && object.Equals(this.AGPJDEJALFH, other.AGPJDEJALFH) && this.AEKEHEMKPID == other.AEKEHEMKPID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x000630AC File Offset: 0x000612AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HIAGEINLAHL != 0U)
			{
				num ^= this.HIAGEINLAHL.GetHashCode();
			}
			if (this.fBBEHFHPOPD_ != null)
			{
				num ^= this.FBBEHFHPOPD.GetHashCode();
			}
			if (this.nGBMDKDKBGG_ != null)
			{
				num ^= this.NGBMDKDKBGG.GetHashCode();
			}
			if (this.iMFFNDDABLB_ != null)
			{
				num ^= this.IMFFNDDABLB.GetHashCode();
			}
			if (this.fCFHJBPPBLO_ != null)
			{
				num ^= this.FCFHJBPPBLO.GetHashCode();
			}
			if (this.fLJFEHGOBDB_ != null)
			{
				num ^= this.FLJFEHGOBDB.GetHashCode();
			}
			if (this.mCBGNPDEOBN_ != null)
			{
				num ^= this.MCBGNPDEOBN.GetHashCode();
			}
			if (this.aGPJDEJALFH_ != null)
			{
				num ^= this.AGPJDEJALFH.GetHashCode();
			}
			if (this.AEKEHEMKPID)
			{
				num ^= this.AEKEHEMKPID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x0006319E File Offset: 0x0006139E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x000631A6 File Offset: 0x000613A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x000631B0 File Offset: 0x000613B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HIAGEINLAHL != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.HIAGEINLAHL);
			}
			if (this.fLJFEHGOBDB_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.FLJFEHGOBDB);
			}
			if (this.mCBGNPDEOBN_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.MCBGNPDEOBN);
			}
			if (this.iMFFNDDABLB_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.IMFFNDDABLB);
			}
			if (this.fBBEHFHPOPD_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.FBBEHFHPOPD);
			}
			if (this.fCFHJBPPBLO_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FCFHJBPPBLO);
			}
			if (this.AEKEHEMKPID)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.AEKEHEMKPID);
			}
			if (this.nGBMDKDKBGG_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.NGBMDKDKBGG);
			}
			if (this.aGPJDEJALFH_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.AGPJDEJALFH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x000632D0 File Offset: 0x000614D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HIAGEINLAHL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HIAGEINLAHL);
			}
			if (this.fBBEHFHPOPD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FBBEHFHPOPD);
			}
			if (this.nGBMDKDKBGG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NGBMDKDKBGG);
			}
			if (this.iMFFNDDABLB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IMFFNDDABLB);
			}
			if (this.fCFHJBPPBLO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FCFHJBPPBLO);
			}
			if (this.fLJFEHGOBDB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FLJFEHGOBDB);
			}
			if (this.mCBGNPDEOBN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MCBGNPDEOBN);
			}
			if (this.aGPJDEJALFH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AGPJDEJALFH);
			}
			if (this.AEKEHEMKPID)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x000633C4 File Offset: 0x000615C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CMEBMINNJON other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HIAGEINLAHL != 0U)
			{
				this.HIAGEINLAHL = other.HIAGEINLAHL;
			}
			if (other.fBBEHFHPOPD_ != null)
			{
				if (this.fBBEHFHPOPD_ == null)
				{
					this.FBBEHFHPOPD = new DCMFOFEBFAK();
				}
				this.FBBEHFHPOPD.MergeFrom(other.FBBEHFHPOPD);
			}
			if (other.nGBMDKDKBGG_ != null)
			{
				if (this.nGBMDKDKBGG_ == null)
				{
					this.NGBMDKDKBGG = new DGPMABEJOMJ();
				}
				this.NGBMDKDKBGG.MergeFrom(other.NGBMDKDKBGG);
			}
			if (other.iMFFNDDABLB_ != null)
			{
				if (this.iMFFNDDABLB_ == null)
				{
					this.IMFFNDDABLB = new ELBENNKHNLC();
				}
				this.IMFFNDDABLB.MergeFrom(other.IMFFNDDABLB);
			}
			if (other.fCFHJBPPBLO_ != null)
			{
				if (this.fCFHJBPPBLO_ == null)
				{
					this.FCFHJBPPBLO = new IDELAMMCOII();
				}
				this.FCFHJBPPBLO.MergeFrom(other.FCFHJBPPBLO);
			}
			if (other.fLJFEHGOBDB_ != null)
			{
				if (this.fLJFEHGOBDB_ == null)
				{
					this.FLJFEHGOBDB = new DKPPCLLGIMC();
				}
				this.FLJFEHGOBDB.MergeFrom(other.FLJFEHGOBDB);
			}
			if (other.mCBGNPDEOBN_ != null)
			{
				if (this.mCBGNPDEOBN_ == null)
				{
					this.MCBGNPDEOBN = new FAFOJMLECPG();
				}
				this.MCBGNPDEOBN.MergeFrom(other.MCBGNPDEOBN);
			}
			if (other.aGPJDEJALFH_ != null)
			{
				if (this.aGPJDEJALFH_ == null)
				{
					this.AGPJDEJALFH = new CMNFMIHMGID();
				}
				this.AGPJDEJALFH.MergeFrom(other.AGPJDEJALFH);
			}
			if (other.AEKEHEMKPID)
			{
				this.AEKEHEMKPID = other.AEKEHEMKPID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00063548 File Offset: 0x00061748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00063554 File Offset: 0x00061754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 66U)
				{
					if (num <= 50U)
					{
						if (num == 40U)
						{
							this.HIAGEINLAHL = input.ReadUInt32();
							continue;
						}
						if (num == 50U)
						{
							if (this.fLJFEHGOBDB_ == null)
							{
								this.FLJFEHGOBDB = new DKPPCLLGIMC();
							}
							input.ReadMessage(this.FLJFEHGOBDB);
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							if (this.mCBGNPDEOBN_ == null)
							{
								this.MCBGNPDEOBN = new FAFOJMLECPG();
							}
							input.ReadMessage(this.MCBGNPDEOBN);
							continue;
						}
						if (num == 66U)
						{
							if (this.iMFFNDDABLB_ == null)
							{
								this.IMFFNDDABLB = new ELBENNKHNLC();
							}
							input.ReadMessage(this.IMFFNDDABLB);
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 74U)
					{
						if (this.fBBEHFHPOPD_ == null)
						{
							this.FBBEHFHPOPD = new DCMFOFEBFAK();
						}
						input.ReadMessage(this.FBBEHFHPOPD);
						continue;
					}
					if (num == 82U)
					{
						if (this.fCFHJBPPBLO_ == null)
						{
							this.FCFHJBPPBLO = new IDELAMMCOII();
						}
						input.ReadMessage(this.FCFHJBPPBLO);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.AEKEHEMKPID = input.ReadBool();
						continue;
					}
					if (num == 106U)
					{
						if (this.nGBMDKDKBGG_ == null)
						{
							this.NGBMDKDKBGG = new DGPMABEJOMJ();
						}
						input.ReadMessage(this.NGBMDKDKBGG);
						continue;
					}
					if (num == 122U)
					{
						if (this.aGPJDEJALFH_ == null)
						{
							this.AGPJDEJALFH = new CMNFMIHMGID();
						}
						input.ReadMessage(this.AGPJDEJALFH);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000E53 RID: 3667
		private static readonly MessageParser<CMEBMINNJON> _parser = new MessageParser<CMEBMINNJON>(() => new CMEBMINNJON());

		// Token: 0x04000E54 RID: 3668
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E55 RID: 3669
		public const int HIAGEINLAHLFieldNumber = 5;

		// Token: 0x04000E56 RID: 3670
		private uint hIAGEINLAHL_;

		// Token: 0x04000E57 RID: 3671
		public const int FBBEHFHPOPDFieldNumber = 9;

		// Token: 0x04000E58 RID: 3672
		private DCMFOFEBFAK fBBEHFHPOPD_;

		// Token: 0x04000E59 RID: 3673
		public const int NGBMDKDKBGGFieldNumber = 13;

		// Token: 0x04000E5A RID: 3674
		private DGPMABEJOMJ nGBMDKDKBGG_;

		// Token: 0x04000E5B RID: 3675
		public const int IMFFNDDABLBFieldNumber = 8;

		// Token: 0x04000E5C RID: 3676
		private ELBENNKHNLC iMFFNDDABLB_;

		// Token: 0x04000E5D RID: 3677
		public const int FCFHJBPPBLOFieldNumber = 10;

		// Token: 0x04000E5E RID: 3678
		private IDELAMMCOII fCFHJBPPBLO_;

		// Token: 0x04000E5F RID: 3679
		public const int FLJFEHGOBDBFieldNumber = 6;

		// Token: 0x04000E60 RID: 3680
		private DKPPCLLGIMC fLJFEHGOBDB_;

		// Token: 0x04000E61 RID: 3681
		public const int MCBGNPDEOBNFieldNumber = 7;

		// Token: 0x04000E62 RID: 3682
		private FAFOJMLECPG mCBGNPDEOBN_;

		// Token: 0x04000E63 RID: 3683
		public const int AGPJDEJALFHFieldNumber = 15;

		// Token: 0x04000E64 RID: 3684
		private CMNFMIHMGID aGPJDEJALFH_;

		// Token: 0x04000E65 RID: 3685
		public const int AEKEHEMKPIDFieldNumber = 12;

		// Token: 0x04000E66 RID: 3686
		private bool aEKEHEMKPID_;
	}
}
