using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AA1 RID: 2721
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchThreeLevelEndCsReq : IMessage<MatchThreeLevelEndCsReq>, IMessage, IEquatable<MatchThreeLevelEndCsReq>, IDeepCloneable<MatchThreeLevelEndCsReq>, IBufferMessage
	{
		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x0600788E RID: 30862 RVA: 0x0013F80C File Offset: 0x0013DA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchThreeLevelEndCsReq> Parser
		{
			get
			{
				return MatchThreeLevelEndCsReq._parser;
			}
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x0600788F RID: 30863 RVA: 0x0013F813 File Offset: 0x0013DA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MatchThreeLevelEndCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x06007890 RID: 30864 RVA: 0x0013F825 File Offset: 0x0013DA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeLevelEndCsReq.Descriptor;
			}
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x0013F82C File Offset: 0x0013DA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelEndCsReq()
		{
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x0013F858 File Offset: 0x0013DA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelEndCsReq(MatchThreeLevelEndCsReq other) : this()
		{
			this.jKGBGFOPMHM_ = other.jKGBGFOPMHM_;
			this.mHPCLHBGCDC_ = other.mHPCLHBGCDC_.Clone();
			this.nIEPAOBBFJF_ = other.nIEPAOBBFJF_;
			this.mBFKOHNGMPJ_ = other.mBFKOHNGMPJ_;
			this.levelId_ = other.levelId_;
			this.kIFPFCDEAAE_ = other.kIFPFCDEAAE_;
			this.aCBMBACFCCN_ = other.aCBMBACFCCN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x0013F8DA File Offset: 0x0013DADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelEndCsReq Clone()
		{
			return new MatchThreeLevelEndCsReq(this);
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x06007894 RID: 30868 RVA: 0x0013F8E2 File Offset: 0x0013DAE2
		// (set) Token: 0x06007895 RID: 30869 RVA: 0x0013F8EA File Offset: 0x0013DAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JKGBGFOPMHM
		{
			get
			{
				return this.jKGBGFOPMHM_;
			}
			set
			{
				this.jKGBGFOPMHM_ = value;
			}
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x06007896 RID: 30870 RVA: 0x0013F8F3 File Offset: 0x0013DAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MHPCLHBGCDC
		{
			get
			{
				return this.mHPCLHBGCDC_;
			}
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x06007897 RID: 30871 RVA: 0x0013F8FB File Offset: 0x0013DAFB
		// (set) Token: 0x06007898 RID: 30872 RVA: 0x0013F903 File Offset: 0x0013DB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string NIEPAOBBFJF
		{
			get
			{
				return this.nIEPAOBBFJF_;
			}
			set
			{
				this.nIEPAOBBFJF_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x06007899 RID: 30873 RVA: 0x0013F916 File Offset: 0x0013DB16
		// (set) Token: 0x0600789A RID: 30874 RVA: 0x0013F91E File Offset: 0x0013DB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MBFKOHNGMPJ
		{
			get
			{
				return this.mBFKOHNGMPJ_;
			}
			set
			{
				this.mBFKOHNGMPJ_ = value;
			}
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x0600789B RID: 30875 RVA: 0x0013F927 File Offset: 0x0013DB27
		// (set) Token: 0x0600789C RID: 30876 RVA: 0x0013F92F File Offset: 0x0013DB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x0600789D RID: 30877 RVA: 0x0013F938 File Offset: 0x0013DB38
		// (set) Token: 0x0600789E RID: 30878 RVA: 0x0013F940 File Offset: 0x0013DB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KIFPFCDEAAE
		{
			get
			{
				return this.kIFPFCDEAAE_;
			}
			set
			{
				this.kIFPFCDEAAE_ = value;
			}
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x0600789F RID: 30879 RVA: 0x0013F949 File Offset: 0x0013DB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> ACBMBACFCCN
		{
			get
			{
				return this.aCBMBACFCCN_;
			}
		}

		// Token: 0x060078A0 RID: 30880 RVA: 0x0013F951 File Offset: 0x0013DB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeLevelEndCsReq);
		}

		// Token: 0x060078A1 RID: 30881 RVA: 0x0013F960 File Offset: 0x0013DB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeLevelEndCsReq other)
		{
			return other != null && (other == this || (this.JKGBGFOPMHM == other.JKGBGFOPMHM && this.mHPCLHBGCDC_.Equals(other.mHPCLHBGCDC_) && !(this.NIEPAOBBFJF != other.NIEPAOBBFJF) && this.MBFKOHNGMPJ == other.MBFKOHNGMPJ && this.LevelId == other.LevelId && this.KIFPFCDEAAE == other.KIFPFCDEAAE && this.ACBMBACFCCN.Equals(other.ACBMBACFCCN) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078A2 RID: 30882 RVA: 0x0013FA08 File Offset: 0x0013DC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JKGBGFOPMHM != 0U)
			{
				num ^= this.JKGBGFOPMHM.GetHashCode();
			}
			num ^= this.mHPCLHBGCDC_.GetHashCode();
			if (this.NIEPAOBBFJF.Length != 0)
			{
				num ^= this.NIEPAOBBFJF.GetHashCode();
			}
			if (this.MBFKOHNGMPJ != 0U)
			{
				num ^= this.MBFKOHNGMPJ.GetHashCode();
			}
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.KIFPFCDEAAE != 0U)
			{
				num ^= this.KIFPFCDEAAE.GetHashCode();
			}
			num ^= this.ACBMBACFCCN.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078A3 RID: 30883 RVA: 0x0013FAC9 File Offset: 0x0013DCC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060078A4 RID: 30884 RVA: 0x0013FAD1 File Offset: 0x0013DCD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x0013FADC File Offset: 0x0013DCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MBFKOHNGMPJ != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MBFKOHNGMPJ);
			}
			if (this.KIFPFCDEAAE != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.KIFPFCDEAAE);
			}
			if (this.JKGBGFOPMHM != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.JKGBGFOPMHM);
			}
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.LevelId);
			}
			if (this.NIEPAOBBFJF.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.NIEPAOBBFJF);
			}
			this.mHPCLHBGCDC_.WriteTo(ref output, MatchThreeLevelEndCsReq._repeated_mHPCLHBGCDC_codec);
			this.aCBMBACFCCN_.WriteTo(ref output, MatchThreeLevelEndCsReq._map_aCBMBACFCCN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x0013FBB0 File Offset: 0x0013DDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JKGBGFOPMHM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JKGBGFOPMHM);
			}
			num += this.mHPCLHBGCDC_.CalculateSize(MatchThreeLevelEndCsReq._repeated_mHPCLHBGCDC_codec);
			if (this.NIEPAOBBFJF.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.NIEPAOBBFJF);
			}
			if (this.MBFKOHNGMPJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MBFKOHNGMPJ);
			}
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this.KIFPFCDEAAE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KIFPFCDEAAE);
			}
			num += this.aCBMBACFCCN_.CalculateSize(MatchThreeLevelEndCsReq._map_aCBMBACFCCN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x0013FC7C File Offset: 0x0013DE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeLevelEndCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JKGBGFOPMHM != 0U)
			{
				this.JKGBGFOPMHM = other.JKGBGFOPMHM;
			}
			this.mHPCLHBGCDC_.Add(other.mHPCLHBGCDC_);
			if (other.NIEPAOBBFJF.Length != 0)
			{
				this.NIEPAOBBFJF = other.NIEPAOBBFJF;
			}
			if (other.MBFKOHNGMPJ != 0U)
			{
				this.MBFKOHNGMPJ = other.MBFKOHNGMPJ;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			if (other.KIFPFCDEAAE != 0U)
			{
				this.KIFPFCDEAAE = other.KIFPFCDEAAE;
			}
			this.aCBMBACFCCN_.MergeFrom(other.aCBMBACFCCN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x0013FD2F File Offset: 0x0013DF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x0013FD38 File Offset: 0x0013DF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 40U)
				{
					if (num <= 88U)
					{
						if (num == 50U)
						{
							this.NIEPAOBBFJF = input.ReadString();
							continue;
						}
						if (num != 88U)
						{
							goto IL_41;
						}
					}
					else if (num != 90U)
					{
						if (num != 122U)
						{
							goto IL_41;
						}
						this.aCBMBACFCCN_.AddEntriesFrom(ref input, MatchThreeLevelEndCsReq._map_aCBMBACFCCN_codec);
						continue;
					}
					this.mHPCLHBGCDC_.AddEntriesFrom(ref input, MatchThreeLevelEndCsReq._repeated_mHPCLHBGCDC_codec);
					continue;
				}
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.MBFKOHNGMPJ = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.KIFPFCDEAAE = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.JKGBGFOPMHM = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LevelId = input.ReadUInt32();
						continue;
					}
				}
				IL_41:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E45 RID: 11845
		private static readonly MessageParser<MatchThreeLevelEndCsReq> _parser = new MessageParser<MatchThreeLevelEndCsReq>(() => new MatchThreeLevelEndCsReq());

		// Token: 0x04002E46 RID: 11846
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E47 RID: 11847
		public const int JKGBGFOPMHMFieldNumber = 3;

		// Token: 0x04002E48 RID: 11848
		private uint jKGBGFOPMHM_;

		// Token: 0x04002E49 RID: 11849
		public const int MHPCLHBGCDCFieldNumber = 11;

		// Token: 0x04002E4A RID: 11850
		private static readonly FieldCodec<uint> _repeated_mHPCLHBGCDC_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04002E4B RID: 11851
		private readonly RepeatedField<uint> mHPCLHBGCDC_ = new RepeatedField<uint>();

		// Token: 0x04002E4C RID: 11852
		public const int NIEPAOBBFJFFieldNumber = 6;

		// Token: 0x04002E4D RID: 11853
		private string nIEPAOBBFJF_ = "";

		// Token: 0x04002E4E RID: 11854
		public const int MBFKOHNGMPJFieldNumber = 1;

		// Token: 0x04002E4F RID: 11855
		private uint mBFKOHNGMPJ_;

		// Token: 0x04002E50 RID: 11856
		public const int LevelIdFieldNumber = 5;

		// Token: 0x04002E51 RID: 11857
		private uint levelId_;

		// Token: 0x04002E52 RID: 11858
		public const int KIFPFCDEAAEFieldNumber = 2;

		// Token: 0x04002E53 RID: 11859
		private uint kIFPFCDEAAE_;

		// Token: 0x04002E54 RID: 11860
		public const int ACBMBACFCCNFieldNumber = 15;

		// Token: 0x04002E55 RID: 11861
		private static readonly MapField<uint, uint>.Codec _map_aCBMBACFCCN_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 122U);

		// Token: 0x04002E56 RID: 11862
		private readonly MapField<uint, uint> aCBMBACFCCN_ = new MapField<uint, uint>();
	}
}
