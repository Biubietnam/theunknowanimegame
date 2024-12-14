using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001161 RID: 4449
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooDataScRsp : IMessage<SpaceZooDataScRsp>, IMessage, IEquatable<SpaceZooDataScRsp>, IDeepCloneable<SpaceZooDataScRsp>, IBufferMessage
	{
		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x0600C67A RID: 50810 RVA: 0x00214B54 File Offset: 0x00212D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooDataScRsp> Parser
		{
			get
			{
				return SpaceZooDataScRsp._parser;
			}
		}

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x0600C67B RID: 50811 RVA: 0x00214B5B File Offset: 0x00212D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x0600C67C RID: 50812 RVA: 0x00214B6D File Offset: 0x00212D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600C67D RID: 50813 RVA: 0x00214B74 File Offset: 0x00212D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDataScRsp()
		{
		}

		// Token: 0x0600C67E RID: 50814 RVA: 0x00214BD4 File Offset: 0x00212DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDataScRsp(SpaceZooDataScRsp other) : this()
		{
			this.dNEHACGCPPI_ = other.dNEHACGCPPI_.Clone();
			this.dPMMKGLFBAJ_ = other.dPMMKGLFBAJ_.Clone();
			this.pNKEOHGMJIE_ = other.pNKEOHGMJIE_.Clone();
			this.iKNGDCEDMEB_ = other.iKNGDCEDMEB_.Clone();
			this.fCKIFFMOOOF_ = other.fCKIFFMOOOF_.Clone();
			this.hFCJGDCEPPE_ = other.hFCJGDCEPPE_;
			this.jFCFEOIIPPL_ = other.jFCFEOIIPPL_.Clone();
			this.nGPOKINOGAL_ = other.nGPOKINOGAL_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C67F RID: 50815 RVA: 0x00214C87 File Offset: 0x00212E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDataScRsp Clone()
		{
			return new SpaceZooDataScRsp(this);
		}

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x0600C680 RID: 50816 RVA: 0x00214C8F File Offset: 0x00212E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CHBBGEIDOGB> DNEHACGCPPI
		{
			get
			{
				return this.dNEHACGCPPI_;
			}
		}

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x0600C681 RID: 50817 RVA: 0x00214C97 File Offset: 0x00212E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DPMMKGLFBAJ
		{
			get
			{
				return this.dPMMKGLFBAJ_;
			}
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x0600C682 RID: 50818 RVA: 0x00214C9F File Offset: 0x00212E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PNKEOHGMJIE
		{
			get
			{
				return this.pNKEOHGMJIE_;
			}
		}

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x0600C683 RID: 50819 RVA: 0x00214CA7 File Offset: 0x00212EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IKNGDCEDMEB
		{
			get
			{
				return this.iKNGDCEDMEB_;
			}
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x0600C684 RID: 50820 RVA: 0x00214CAF File Offset: 0x00212EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FCKIFFMOOOF
		{
			get
			{
				return this.fCKIFFMOOOF_;
			}
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x0600C685 RID: 50821 RVA: 0x00214CB7 File Offset: 0x00212EB7
		// (set) Token: 0x0600C686 RID: 50822 RVA: 0x00214CBF File Offset: 0x00212EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HFCJGDCEPPE
		{
			get
			{
				return this.hFCJGDCEPPE_;
			}
			set
			{
				this.hFCJGDCEPPE_ = value;
			}
		}

		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x0600C687 RID: 50823 RVA: 0x00214CC8 File Offset: 0x00212EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> JFCFEOIIPPL
		{
			get
			{
				return this.jFCFEOIIPPL_;
			}
		}

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x0600C688 RID: 50824 RVA: 0x00214CD0 File Offset: 0x00212ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MPPOJKLLOHA> NGPOKINOGAL
		{
			get
			{
				return this.nGPOKINOGAL_;
			}
		}

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x0600C689 RID: 50825 RVA: 0x00214CD8 File Offset: 0x00212ED8
		// (set) Token: 0x0600C68A RID: 50826 RVA: 0x00214CE0 File Offset: 0x00212EE0
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

		// Token: 0x0600C68B RID: 50827 RVA: 0x00214CE9 File Offset: 0x00212EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooDataScRsp);
		}

		// Token: 0x0600C68C RID: 50828 RVA: 0x00214CF8 File Offset: 0x00212EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooDataScRsp other)
		{
			return other != null && (other == this || (this.dNEHACGCPPI_.Equals(other.dNEHACGCPPI_) && this.dPMMKGLFBAJ_.Equals(other.dPMMKGLFBAJ_) && this.pNKEOHGMJIE_.Equals(other.pNKEOHGMJIE_) && this.iKNGDCEDMEB_.Equals(other.iKNGDCEDMEB_) && this.fCKIFFMOOOF_.Equals(other.fCKIFFMOOOF_) && this.HFCJGDCEPPE == other.HFCJGDCEPPE && this.jFCFEOIIPPL_.Equals(other.jFCFEOIIPPL_) && this.nGPOKINOGAL_.Equals(other.nGPOKINOGAL_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C68D RID: 50829 RVA: 0x00214DD4 File Offset: 0x00212FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dNEHACGCPPI_.GetHashCode();
			num ^= this.dPMMKGLFBAJ_.GetHashCode();
			num ^= this.pNKEOHGMJIE_.GetHashCode();
			num ^= this.iKNGDCEDMEB_.GetHashCode();
			num ^= this.fCKIFFMOOOF_.GetHashCode();
			if (this.HFCJGDCEPPE != 0U)
			{
				num ^= this.HFCJGDCEPPE.GetHashCode();
			}
			num ^= this.jFCFEOIIPPL_.GetHashCode();
			num ^= this.nGPOKINOGAL_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C68E RID: 50830 RVA: 0x00214E8E File Offset: 0x0021308E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C68F RID: 50831 RVA: 0x00214E96 File Offset: 0x00213096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C690 RID: 50832 RVA: 0x00214EA0 File Offset: 0x002130A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.dPMMKGLFBAJ_.WriteTo(ref output, SpaceZooDataScRsp._repeated_dPMMKGLFBAJ_codec);
			this.jFCFEOIIPPL_.WriteTo(ref output, SpaceZooDataScRsp._repeated_jFCFEOIIPPL_codec);
			if (this.HFCJGDCEPPE != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.HFCJGDCEPPE);
			}
			this.iKNGDCEDMEB_.WriteTo(ref output, SpaceZooDataScRsp._repeated_iKNGDCEDMEB_codec);
			this.fCKIFFMOOOF_.WriteTo(ref output, SpaceZooDataScRsp._repeated_fCKIFFMOOOF_codec);
			this.nGPOKINOGAL_.WriteTo(ref output, SpaceZooDataScRsp._repeated_nGPOKINOGAL_codec);
			this.dNEHACGCPPI_.WriteTo(ref output, SpaceZooDataScRsp._repeated_dNEHACGCPPI_codec);
			this.pNKEOHGMJIE_.WriteTo(ref output, SpaceZooDataScRsp._repeated_pNKEOHGMJIE_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C691 RID: 50833 RVA: 0x00214F70 File Offset: 0x00213170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dNEHACGCPPI_.CalculateSize(SpaceZooDataScRsp._repeated_dNEHACGCPPI_codec);
			num += this.dPMMKGLFBAJ_.CalculateSize(SpaceZooDataScRsp._repeated_dPMMKGLFBAJ_codec);
			num += this.pNKEOHGMJIE_.CalculateSize(SpaceZooDataScRsp._repeated_pNKEOHGMJIE_codec);
			num += this.iKNGDCEDMEB_.CalculateSize(SpaceZooDataScRsp._repeated_iKNGDCEDMEB_codec);
			num += this.fCKIFFMOOOF_.CalculateSize(SpaceZooDataScRsp._repeated_fCKIFFMOOOF_codec);
			if (this.HFCJGDCEPPE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HFCJGDCEPPE);
			}
			num += this.jFCFEOIIPPL_.CalculateSize(SpaceZooDataScRsp._repeated_jFCFEOIIPPL_codec);
			num += this.nGPOKINOGAL_.CalculateSize(SpaceZooDataScRsp._repeated_nGPOKINOGAL_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C692 RID: 50834 RVA: 0x0021504C File Offset: 0x0021324C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.dNEHACGCPPI_.Add(other.dNEHACGCPPI_);
			this.dPMMKGLFBAJ_.Add(other.dPMMKGLFBAJ_);
			this.pNKEOHGMJIE_.Add(other.pNKEOHGMJIE_);
			this.iKNGDCEDMEB_.Add(other.iKNGDCEDMEB_);
			this.fCKIFFMOOOF_.Add(other.fCKIFFMOOOF_);
			if (other.HFCJGDCEPPE != 0U)
			{
				this.HFCJGDCEPPE = other.HFCJGDCEPPE;
			}
			this.jFCFEOIIPPL_.Add(other.jFCFEOIIPPL_);
			this.nGPOKINOGAL_.Add(other.nGPOKINOGAL_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C693 RID: 50835 RVA: 0x00215113 File Offset: 0x00213313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C694 RID: 50836 RVA: 0x0021511C File Offset: 0x0021331C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 42U)
					{
						if (num == 8U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
						if (num == 40U || num == 42U)
						{
							this.dPMMKGLFBAJ_.AddEntriesFrom(ref input, SpaceZooDataScRsp._repeated_dPMMKGLFBAJ_codec);
							continue;
						}
					}
					else if (num <= 50U)
					{
						if (num == 48U || num == 50U)
						{
							this.jFCFEOIIPPL_.AddEntriesFrom(ref input, SpaceZooDataScRsp._repeated_jFCFEOIIPPL_codec);
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.HFCJGDCEPPE = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							goto IL_F3;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 66U)
					{
						goto IL_F3;
					}
					if (num == 72U || num == 74U)
					{
						this.fCKIFFMOOOF_.AddEntriesFrom(ref input, SpaceZooDataScRsp._repeated_fCKIFFMOOOF_codec);
						continue;
					}
				}
				else if (num <= 98U)
				{
					if (num == 82U)
					{
						this.nGPOKINOGAL_.AddEntriesFrom(ref input, SpaceZooDataScRsp._repeated_nGPOKINOGAL_codec);
						continue;
					}
					if (num == 98U)
					{
						this.dNEHACGCPPI_.AddEntriesFrom(ref input, SpaceZooDataScRsp._repeated_dNEHACGCPPI_codec);
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.pNKEOHGMJIE_.AddEntriesFrom(ref input, SpaceZooDataScRsp._repeated_pNKEOHGMJIE_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_F3:
				this.iKNGDCEDMEB_.AddEntriesFrom(ref input, SpaceZooDataScRsp._repeated_iKNGDCEDMEB_codec);
			}
		}

		// Token: 0x0400502A RID: 20522
		private static readonly MessageParser<SpaceZooDataScRsp> _parser = new MessageParser<SpaceZooDataScRsp>(() => new SpaceZooDataScRsp());

		// Token: 0x0400502B RID: 20523
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400502C RID: 20524
		public const int DNEHACGCPPIFieldNumber = 12;

		// Token: 0x0400502D RID: 20525
		private static readonly FieldCodec<CHBBGEIDOGB> _repeated_dNEHACGCPPI_codec = FieldCodec.ForMessage<CHBBGEIDOGB>(98U, CHBBGEIDOGB.Parser);

		// Token: 0x0400502E RID: 20526
		private readonly RepeatedField<CHBBGEIDOGB> dNEHACGCPPI_ = new RepeatedField<CHBBGEIDOGB>();

		// Token: 0x0400502F RID: 20527
		public const int DPMMKGLFBAJFieldNumber = 5;

		// Token: 0x04005030 RID: 20528
		private static readonly FieldCodec<uint> _repeated_dPMMKGLFBAJ_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04005031 RID: 20529
		private readonly RepeatedField<uint> dPMMKGLFBAJ_ = new RepeatedField<uint>();

		// Token: 0x04005032 RID: 20530
		public const int PNKEOHGMJIEFieldNumber = 14;

		// Token: 0x04005033 RID: 20531
		private static readonly FieldCodec<uint> _repeated_pNKEOHGMJIE_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04005034 RID: 20532
		private readonly RepeatedField<uint> pNKEOHGMJIE_ = new RepeatedField<uint>();

		// Token: 0x04005035 RID: 20533
		public const int IKNGDCEDMEBFieldNumber = 8;

		// Token: 0x04005036 RID: 20534
		private static readonly FieldCodec<uint> _repeated_iKNGDCEDMEB_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04005037 RID: 20535
		private readonly RepeatedField<uint> iKNGDCEDMEB_ = new RepeatedField<uint>();

		// Token: 0x04005038 RID: 20536
		public const int FCKIFFMOOOFFieldNumber = 9;

		// Token: 0x04005039 RID: 20537
		private static readonly FieldCodec<uint> _repeated_fCKIFFMOOOF_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x0400503A RID: 20538
		private readonly RepeatedField<uint> fCKIFFMOOOF_ = new RepeatedField<uint>();

		// Token: 0x0400503B RID: 20539
		public const int HFCJGDCEPPEFieldNumber = 7;

		// Token: 0x0400503C RID: 20540
		private uint hFCJGDCEPPE_;

		// Token: 0x0400503D RID: 20541
		public const int JFCFEOIIPPLFieldNumber = 6;

		// Token: 0x0400503E RID: 20542
		private static readonly FieldCodec<uint> _repeated_jFCFEOIIPPL_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x0400503F RID: 20543
		private readonly RepeatedField<uint> jFCFEOIIPPL_ = new RepeatedField<uint>();

		// Token: 0x04005040 RID: 20544
		public const int NGPOKINOGALFieldNumber = 10;

		// Token: 0x04005041 RID: 20545
		private static readonly FieldCodec<MPPOJKLLOHA> _repeated_nGPOKINOGAL_codec = FieldCodec.ForMessage<MPPOJKLLOHA>(82U, MPPOJKLLOHA.Parser);

		// Token: 0x04005042 RID: 20546
		private readonly RepeatedField<MPPOJKLLOHA> nGPOKINOGAL_ = new RepeatedField<MPPOJKLLOHA>();

		// Token: 0x04005043 RID: 20547
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04005044 RID: 20548
		private uint retcode_;
	}
}
