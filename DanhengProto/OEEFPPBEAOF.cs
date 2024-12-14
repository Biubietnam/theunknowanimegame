using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C4B RID: 3147
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OEEFPPBEAOF : IMessage<OEEFPPBEAOF>, IMessage, IEquatable<OEEFPPBEAOF>, IDeepCloneable<OEEFPPBEAOF>, IBufferMessage
	{
		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x06008BA5 RID: 35749 RVA: 0x00171088 File Offset: 0x0016F288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OEEFPPBEAOF> Parser
		{
			get
			{
				return OEEFPPBEAOF._parser;
			}
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x06008BA6 RID: 35750 RVA: 0x0017108F File Offset: 0x0016F28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OEEFPPBEAOFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x06008BA7 RID: 35751 RVA: 0x001710A1 File Offset: 0x0016F2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OEEFPPBEAOF.Descriptor;
			}
		}

		// Token: 0x06008BA8 RID: 35752 RVA: 0x001710A8 File Offset: 0x0016F2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEEFPPBEAOF()
		{
		}

		// Token: 0x06008BA9 RID: 35753 RVA: 0x001710B0 File Offset: 0x0016F2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEEFPPBEAOF(OEEFPPBEAOF other) : this()
		{
			this.oKLINBBACBJ_ = other.oKLINBBACBJ_;
			this.aIAFDNMOCNP_ = other.aIAFDNMOCNP_;
			this.dEOGEMOONHO_ = other.dEOGEMOONHO_;
			this.dMECAAFMHLN_ = other.dMECAAFMHLN_;
			this.aJOGDNJBJOH_ = other.aJOGDNJBJOH_;
			this.oAMDIMJJFFB_ = other.oAMDIMJJFFB_;
			this.gPACHKLFGPC_ = other.gPACHKLFGPC_;
			this.fJHEAFKHFGH_ = other.fJHEAFKHFGH_;
			this.fBABHLPMKBK_ = other.fBABHLPMKBK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BAA RID: 35754 RVA: 0x00171140 File Offset: 0x0016F340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEEFPPBEAOF Clone()
		{
			return new OEEFPPBEAOF(this);
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x06008BAB RID: 35755 RVA: 0x00171148 File Offset: 0x0016F348
		// (set) Token: 0x06008BAC RID: 35756 RVA: 0x00171150 File Offset: 0x0016F350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OKLINBBACBJ
		{
			get
			{
				return this.oKLINBBACBJ_;
			}
			set
			{
				this.oKLINBBACBJ_ = value;
			}
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x06008BAD RID: 35757 RVA: 0x00171159 File Offset: 0x0016F359
		// (set) Token: 0x06008BAE RID: 35758 RVA: 0x00171161 File Offset: 0x0016F361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AIAFDNMOCNP
		{
			get
			{
				return this.aIAFDNMOCNP_;
			}
			set
			{
				this.aIAFDNMOCNP_ = value;
			}
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x06008BAF RID: 35759 RVA: 0x0017116A File Offset: 0x0016F36A
		// (set) Token: 0x06008BB0 RID: 35760 RVA: 0x00171172 File Offset: 0x0016F372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DEOGEMOONHO
		{
			get
			{
				return this.dEOGEMOONHO_;
			}
			set
			{
				this.dEOGEMOONHO_ = value;
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x06008BB1 RID: 35761 RVA: 0x0017117B File Offset: 0x0016F37B
		// (set) Token: 0x06008BB2 RID: 35762 RVA: 0x00171183 File Offset: 0x0016F383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DMECAAFMHLN
		{
			get
			{
				return this.dMECAAFMHLN_;
			}
			set
			{
				this.dMECAAFMHLN_ = value;
			}
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x06008BB3 RID: 35763 RVA: 0x0017118C File Offset: 0x0016F38C
		// (set) Token: 0x06008BB4 RID: 35764 RVA: 0x00171194 File Offset: 0x0016F394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AJOGDNJBJOH
		{
			get
			{
				return this.aJOGDNJBJOH_;
			}
			set
			{
				this.aJOGDNJBJOH_ = value;
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x06008BB5 RID: 35765 RVA: 0x0017119D File Offset: 0x0016F39D
		// (set) Token: 0x06008BB6 RID: 35766 RVA: 0x001711A5 File Offset: 0x0016F3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OAMDIMJJFFB
		{
			get
			{
				return this.oAMDIMJJFFB_;
			}
			set
			{
				this.oAMDIMJJFFB_ = value;
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x06008BB7 RID: 35767 RVA: 0x001711AE File Offset: 0x0016F3AE
		// (set) Token: 0x06008BB8 RID: 35768 RVA: 0x001711B6 File Offset: 0x0016F3B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GPACHKLFGPC
		{
			get
			{
				return this.gPACHKLFGPC_;
			}
			set
			{
				this.gPACHKLFGPC_ = value;
			}
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x06008BB9 RID: 35769 RVA: 0x001711BF File Offset: 0x0016F3BF
		// (set) Token: 0x06008BBA RID: 35770 RVA: 0x001711C7 File Offset: 0x0016F3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FJHEAFKHFGH
		{
			get
			{
				return this.fJHEAFKHFGH_;
			}
			set
			{
				this.fJHEAFKHFGH_ = value;
			}
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x06008BBB RID: 35771 RVA: 0x001711D0 File Offset: 0x0016F3D0
		// (set) Token: 0x06008BBC RID: 35772 RVA: 0x001711D8 File Offset: 0x0016F3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FBABHLPMKBK
		{
			get
			{
				return this.fBABHLPMKBK_;
			}
			set
			{
				this.fBABHLPMKBK_ = value;
			}
		}

		// Token: 0x06008BBD RID: 35773 RVA: 0x001711E1 File Offset: 0x0016F3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OEEFPPBEAOF);
		}

		// Token: 0x06008BBE RID: 35774 RVA: 0x001711F0 File Offset: 0x0016F3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OEEFPPBEAOF other)
		{
			return other != null && (other == this || (this.OKLINBBACBJ == other.OKLINBBACBJ && this.AIAFDNMOCNP == other.AIAFDNMOCNP && this.DEOGEMOONHO == other.DEOGEMOONHO && this.DMECAAFMHLN == other.DMECAAFMHLN && this.AJOGDNJBJOH == other.AJOGDNJBJOH && this.OAMDIMJJFFB == other.OAMDIMJJFFB && this.GPACHKLFGPC == other.GPACHKLFGPC && this.FJHEAFKHFGH == other.FJHEAFKHFGH && this.FBABHLPMKBK == other.FBABHLPMKBK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BBF RID: 35775 RVA: 0x001712AC File Offset: 0x0016F4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OKLINBBACBJ != 0U)
			{
				num ^= this.OKLINBBACBJ.GetHashCode();
			}
			if (this.AIAFDNMOCNP != 0U)
			{
				num ^= this.AIAFDNMOCNP.GetHashCode();
			}
			if (this.DEOGEMOONHO)
			{
				num ^= this.DEOGEMOONHO.GetHashCode();
			}
			if (this.DMECAAFMHLN != 0U)
			{
				num ^= this.DMECAAFMHLN.GetHashCode();
			}
			if (this.AJOGDNJBJOH != 0U)
			{
				num ^= this.AJOGDNJBJOH.GetHashCode();
			}
			if (this.OAMDIMJJFFB != 0U)
			{
				num ^= this.OAMDIMJJFFB.GetHashCode();
			}
			if (this.GPACHKLFGPC != 0U)
			{
				num ^= this.GPACHKLFGPC.GetHashCode();
			}
			if (this.FJHEAFKHFGH != 0U)
			{
				num ^= this.FJHEAFKHFGH.GetHashCode();
			}
			if (this.FBABHLPMKBK != 0U)
			{
				num ^= this.FBABHLPMKBK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008BC0 RID: 35776 RVA: 0x001713B3 File Offset: 0x0016F5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008BC1 RID: 35777 RVA: 0x001713BB File Offset: 0x0016F5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BC2 RID: 35778 RVA: 0x001713C4 File Offset: 0x0016F5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FJHEAFKHFGH != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.FJHEAFKHFGH);
			}
			if (this.DEOGEMOONHO)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.DEOGEMOONHO);
			}
			if (this.FBABHLPMKBK != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.FBABHLPMKBK);
			}
			if (this.DMECAAFMHLN != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.DMECAAFMHLN);
			}
			if (this.GPACHKLFGPC != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GPACHKLFGPC);
			}
			if (this.AJOGDNJBJOH != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.AJOGDNJBJOH);
			}
			if (this.AIAFDNMOCNP != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.AIAFDNMOCNP);
			}
			if (this.OAMDIMJJFFB != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.OAMDIMJJFFB);
			}
			if (this.OKLINBBACBJ != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.OKLINBBACBJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x001714E0 File Offset: 0x0016F6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OKLINBBACBJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OKLINBBACBJ);
			}
			if (this.AIAFDNMOCNP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AIAFDNMOCNP);
			}
			if (this.DEOGEMOONHO)
			{
				num += 2;
			}
			if (this.DMECAAFMHLN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DMECAAFMHLN);
			}
			if (this.AJOGDNJBJOH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AJOGDNJBJOH);
			}
			if (this.OAMDIMJJFFB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OAMDIMJJFFB);
			}
			if (this.GPACHKLFGPC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GPACHKLFGPC);
			}
			if (this.FJHEAFKHFGH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FJHEAFKHFGH);
			}
			if (this.FBABHLPMKBK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FBABHLPMKBK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x001715D4 File Offset: 0x0016F7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OEEFPPBEAOF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OKLINBBACBJ != 0U)
			{
				this.OKLINBBACBJ = other.OKLINBBACBJ;
			}
			if (other.AIAFDNMOCNP != 0U)
			{
				this.AIAFDNMOCNP = other.AIAFDNMOCNP;
			}
			if (other.DEOGEMOONHO)
			{
				this.DEOGEMOONHO = other.DEOGEMOONHO;
			}
			if (other.DMECAAFMHLN != 0U)
			{
				this.DMECAAFMHLN = other.DMECAAFMHLN;
			}
			if (other.AJOGDNJBJOH != 0U)
			{
				this.AJOGDNJBJOH = other.AJOGDNJBJOH;
			}
			if (other.OAMDIMJJFFB != 0U)
			{
				this.OAMDIMJJFFB = other.OAMDIMJJFFB;
			}
			if (other.GPACHKLFGPC != 0U)
			{
				this.GPACHKLFGPC = other.GPACHKLFGPC;
			}
			if (other.FJHEAFKHFGH != 0U)
			{
				this.FJHEAFKHFGH = other.FJHEAFKHFGH;
			}
			if (other.FBABHLPMKBK != 0U)
			{
				this.FBABHLPMKBK = other.FBABHLPMKBK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008BC5 RID: 35781 RVA: 0x001716B0 File Offset: 0x0016F8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BC6 RID: 35782 RVA: 0x001716BC File Offset: 0x0016F8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.FJHEAFKHFGH = input.ReadUInt32();
							continue;
						}
						if (num == 24U)
						{
							this.DEOGEMOONHO = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.FBABHLPMKBK = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.DMECAAFMHLN = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 48U)
					{
						this.GPACHKLFGPC = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.AJOGDNJBJOH = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.AIAFDNMOCNP = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.OAMDIMJJFFB = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.OKLINBBACBJ = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400359B RID: 13723
		private static readonly MessageParser<OEEFPPBEAOF> _parser = new MessageParser<OEEFPPBEAOF>(() => new OEEFPPBEAOF());

		// Token: 0x0400359C RID: 13724
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400359D RID: 13725
		public const int OKLINBBACBJFieldNumber = 13;

		// Token: 0x0400359E RID: 13726
		private uint oKLINBBACBJ_;

		// Token: 0x0400359F RID: 13727
		public const int AIAFDNMOCNPFieldNumber = 11;

		// Token: 0x040035A0 RID: 13728
		private uint aIAFDNMOCNP_;

		// Token: 0x040035A1 RID: 13729
		public const int DEOGEMOONHOFieldNumber = 3;

		// Token: 0x040035A2 RID: 13730
		private bool dEOGEMOONHO_;

		// Token: 0x040035A3 RID: 13731
		public const int DMECAAFMHLNFieldNumber = 5;

		// Token: 0x040035A4 RID: 13732
		private uint dMECAAFMHLN_;

		// Token: 0x040035A5 RID: 13733
		public const int AJOGDNJBJOHFieldNumber = 10;

		// Token: 0x040035A6 RID: 13734
		private uint aJOGDNJBJOH_;

		// Token: 0x040035A7 RID: 13735
		public const int OAMDIMJJFFBFieldNumber = 12;

		// Token: 0x040035A8 RID: 13736
		private uint oAMDIMJJFFB_;

		// Token: 0x040035A9 RID: 13737
		public const int GPACHKLFGPCFieldNumber = 6;

		// Token: 0x040035AA RID: 13738
		private uint gPACHKLFGPC_;

		// Token: 0x040035AB RID: 13739
		public const int FJHEAFKHFGHFieldNumber = 1;

		// Token: 0x040035AC RID: 13740
		private uint fJHEAFKHFGH_;

		// Token: 0x040035AD RID: 13741
		public const int FBABHLPMKBKFieldNumber = 4;

		// Token: 0x040035AE RID: 13742
		private uint fBABHLPMKBK_;
	}
}
