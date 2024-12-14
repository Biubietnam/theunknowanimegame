using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200050B RID: 1291
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FDBDOCPEICN : IMessage<FDBDOCPEICN>, IMessage, IEquatable<FDBDOCPEICN>, IDeepCloneable<FDBDOCPEICN>, IBufferMessage
	{
		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x060039D8 RID: 14808 RVA: 0x0009F25F File Offset: 0x0009D45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FDBDOCPEICN> Parser
		{
			get
			{
				return FDBDOCPEICN._parser;
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x060039D9 RID: 14809 RVA: 0x0009F266 File Offset: 0x0009D466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FDBDOCPEICNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060039DA RID: 14810 RVA: 0x0009F278 File Offset: 0x0009D478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FDBDOCPEICN.Descriptor;
			}
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x0009F27F File Offset: 0x0009D47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FDBDOCPEICN()
		{
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x0009F294 File Offset: 0x0009D494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FDBDOCPEICN(FDBDOCPEICN other) : this()
		{
			this.level_ = other.level_;
			this.fMPDCAGMDMI_ = other.fMPDCAGMDMI_;
			this.nBMHEIFBBMO_ = other.nBMHEIFBBMO_;
			this.fOFHPBEAAFE_ = other.fOFHPBEAAFE_.Clone();
			this.areaId_ = other.areaId_;
			this.jJHAPFCCAHA_ = other.jJHAPFCCAHA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x0009F305 File Offset: 0x0009D505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FDBDOCPEICN Clone()
		{
			return new FDBDOCPEICN(this);
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060039DE RID: 14814 RVA: 0x0009F30D File Offset: 0x0009D50D
		// (set) Token: 0x060039DF RID: 14815 RVA: 0x0009F315 File Offset: 0x0009D515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x0009F31E File Offset: 0x0009D51E
		// (set) Token: 0x060039E1 RID: 14817 RVA: 0x0009F326 File Offset: 0x0009D526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FMPDCAGMDMI
		{
			get
			{
				return this.fMPDCAGMDMI_;
			}
			set
			{
				this.fMPDCAGMDMI_ = value;
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x0009F32F File Offset: 0x0009D52F
		// (set) Token: 0x060039E3 RID: 14819 RVA: 0x0009F337 File Offset: 0x0009D537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NBMHEIFBBMO
		{
			get
			{
				return this.nBMHEIFBBMO_;
			}
			set
			{
				this.nBMHEIFBBMO_ = value;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x060039E4 RID: 14820 RVA: 0x0009F340 File Offset: 0x0009D540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KIKAEAHENKH> FOFHPBEAAFE
		{
			get
			{
				return this.fOFHPBEAAFE_;
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x060039E5 RID: 14821 RVA: 0x0009F348 File Offset: 0x0009D548
		// (set) Token: 0x060039E6 RID: 14822 RVA: 0x0009F350 File Offset: 0x0009D550
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

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x060039E7 RID: 14823 RVA: 0x0009F359 File Offset: 0x0009D559
		// (set) Token: 0x060039E8 RID: 14824 RVA: 0x0009F361 File Offset: 0x0009D561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JJHAPFCCAHA
		{
			get
			{
				return this.jJHAPFCCAHA_;
			}
			set
			{
				this.jJHAPFCCAHA_ = value;
			}
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x0009F36A File Offset: 0x0009D56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FDBDOCPEICN);
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x0009F378 File Offset: 0x0009D578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FDBDOCPEICN other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.FMPDCAGMDMI == other.FMPDCAGMDMI && this.NBMHEIFBBMO == other.NBMHEIFBBMO && this.fOFHPBEAAFE_.Equals(other.fOFHPBEAAFE_) && this.AreaId == other.AreaId && this.JJHAPFCCAHA == other.JJHAPFCCAHA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x0009F408 File Offset: 0x0009D608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.FMPDCAGMDMI != 0U)
			{
				num ^= this.FMPDCAGMDMI.GetHashCode();
			}
			if (this.NBMHEIFBBMO != 0U)
			{
				num ^= this.NBMHEIFBBMO.GetHashCode();
			}
			num ^= this.fOFHPBEAAFE_.GetHashCode();
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.JJHAPFCCAHA != 0U)
			{
				num ^= this.JJHAPFCCAHA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x0009F4B9 File Offset: 0x0009D6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x0009F4C1 File Offset: 0x0009D6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x0009F4CC File Offset: 0x0009D6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NBMHEIFBBMO != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.NBMHEIFBBMO);
			}
			if (this.FMPDCAGMDMI != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.FMPDCAGMDMI);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Level);
			}
			this.fOFHPBEAAFE_.WriteTo(ref output, FDBDOCPEICN._repeated_fOFHPBEAAFE_codec);
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.AreaId);
			}
			if (this.JJHAPFCCAHA != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.JJHAPFCCAHA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x0009F58C File Offset: 0x0009D78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.FMPDCAGMDMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FMPDCAGMDMI);
			}
			if (this.NBMHEIFBBMO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NBMHEIFBBMO);
			}
			num += this.fOFHPBEAAFE_.CalculateSize(FDBDOCPEICN._repeated_fOFHPBEAAFE_codec);
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.JJHAPFCCAHA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JJHAPFCCAHA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x0009F640 File Offset: 0x0009D840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FDBDOCPEICN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.FMPDCAGMDMI != 0U)
			{
				this.FMPDCAGMDMI = other.FMPDCAGMDMI;
			}
			if (other.NBMHEIFBBMO != 0U)
			{
				this.NBMHEIFBBMO = other.NBMHEIFBBMO;
			}
			this.fOFHPBEAAFE_.Add(other.fOFHPBEAAFE_);
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.JJHAPFCCAHA != 0U)
			{
				this.JJHAPFCCAHA = other.JJHAPFCCAHA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x0009F6DD File Offset: 0x0009D8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x0009F6E8 File Offset: 0x0009D8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.NBMHEIFBBMO = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.FMPDCAGMDMI = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.fOFHPBEAAFE_.AddEntriesFrom(ref input, FDBDOCPEICN._repeated_fOFHPBEAAFE_codec);
						continue;
					}
					if (num == 88U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.JJHAPFCCAHA = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400170A RID: 5898
		private static readonly MessageParser<FDBDOCPEICN> _parser = new MessageParser<FDBDOCPEICN>(() => new FDBDOCPEICN());

		// Token: 0x0400170B RID: 5899
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400170C RID: 5900
		public const int LevelFieldNumber = 7;

		// Token: 0x0400170D RID: 5901
		private uint level_;

		// Token: 0x0400170E RID: 5902
		public const int FMPDCAGMDMIFieldNumber = 6;

		// Token: 0x0400170F RID: 5903
		private uint fMPDCAGMDMI_;

		// Token: 0x04001710 RID: 5904
		public const int NBMHEIFBBMOFieldNumber = 2;

		// Token: 0x04001711 RID: 5905
		private uint nBMHEIFBBMO_;

		// Token: 0x04001712 RID: 5906
		public const int FOFHPBEAAFEFieldNumber = 8;

		// Token: 0x04001713 RID: 5907
		private static readonly FieldCodec<KIKAEAHENKH> _repeated_fOFHPBEAAFE_codec = FieldCodec.ForMessage<KIKAEAHENKH>(66U, KIKAEAHENKH.Parser);

		// Token: 0x04001714 RID: 5908
		private readonly RepeatedField<KIKAEAHENKH> fOFHPBEAAFE_ = new RepeatedField<KIKAEAHENKH>();

		// Token: 0x04001715 RID: 5909
		public const int AreaIdFieldNumber = 11;

		// Token: 0x04001716 RID: 5910
		private uint areaId_;

		// Token: 0x04001717 RID: 5911
		public const int JJHAPFCCAHAFieldNumber = 15;

		// Token: 0x04001718 RID: 5912
		private uint jJHAPFCCAHA_;
	}
}
