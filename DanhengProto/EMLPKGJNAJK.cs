using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000413 RID: 1043
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EMLPKGJNAJK : IMessage<EMLPKGJNAJK>, IMessage, IEquatable<EMLPKGJNAJK>, IDeepCloneable<EMLPKGJNAJK>, IBufferMessage
	{
		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x0007FE85 File Offset: 0x0007E085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EMLPKGJNAJK> Parser
		{
			get
			{
				return EMLPKGJNAJK._parser;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06002E4C RID: 11852 RVA: 0x0007FE8C File Offset: 0x0007E08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EMLPKGJNAJKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x0007FE9E File Offset: 0x0007E09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EMLPKGJNAJK.Descriptor;
			}
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x0007FEA5 File Offset: 0x0007E0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMLPKGJNAJK()
		{
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x0007FEB0 File Offset: 0x0007E0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMLPKGJNAJK(EMLPKGJNAJK other) : this()
		{
			this.jKGBGFOPMHM_ = other.jKGBGFOPMHM_;
			this.mHFMCEICFPJ_ = other.mHFMCEICFPJ_;
			this.mCNHHCHABOA_ = other.mCNHHCHABOA_;
			this.fINCLAOCOGH_ = other.fINCLAOCOGH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x0007FF04 File Offset: 0x0007E104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMLPKGJNAJK Clone()
		{
			return new EMLPKGJNAJK(this);
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x0007FF0C File Offset: 0x0007E10C
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x0007FF14 File Offset: 0x0007E114
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

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x0007FF1D File Offset: 0x0007E11D
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x0007FF25 File Offset: 0x0007E125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MHFMCEICFPJ
		{
			get
			{
				return this.mHFMCEICFPJ_;
			}
			set
			{
				this.mHFMCEICFPJ_ = value;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x0007FF2E File Offset: 0x0007E12E
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x0007FF36 File Offset: 0x0007E136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MCNHHCHABOA
		{
			get
			{
				return this.mCNHHCHABOA_;
			}
			set
			{
				this.mCNHHCHABOA_ = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x0007FF3F File Offset: 0x0007E13F
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x0007FF47 File Offset: 0x0007E147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FINCLAOCOGH
		{
			get
			{
				return this.fINCLAOCOGH_;
			}
			set
			{
				this.fINCLAOCOGH_ = value;
			}
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x0007FF50 File Offset: 0x0007E150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EMLPKGJNAJK);
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x0007FF60 File Offset: 0x0007E160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EMLPKGJNAJK other)
		{
			return other != null && (other == this || (this.JKGBGFOPMHM == other.JKGBGFOPMHM && this.MHFMCEICFPJ == other.MHFMCEICFPJ && this.MCNHHCHABOA == other.MCNHHCHABOA && this.FINCLAOCOGH == other.FINCLAOCOGH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x0007FFCC File Offset: 0x0007E1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JKGBGFOPMHM != 0U)
			{
				num ^= this.JKGBGFOPMHM.GetHashCode();
			}
			if (this.MHFMCEICFPJ)
			{
				num ^= this.MHFMCEICFPJ.GetHashCode();
			}
			if (this.MCNHHCHABOA != 0U)
			{
				num ^= this.MCNHHCHABOA.GetHashCode();
			}
			if (this.FINCLAOCOGH != 0U)
			{
				num ^= this.FINCLAOCOGH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00080056 File Offset: 0x0007E256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x0008005E File Offset: 0x0007E25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x00080068 File Offset: 0x0007E268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JKGBGFOPMHM != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.JKGBGFOPMHM);
			}
			if (this.MHFMCEICFPJ)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.MHFMCEICFPJ);
			}
			if (this.MCNHHCHABOA != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MCNHHCHABOA);
			}
			if (this.FINCLAOCOGH != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.FINCLAOCOGH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000800F8 File Offset: 0x0007E2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JKGBGFOPMHM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JKGBGFOPMHM);
			}
			if (this.MHFMCEICFPJ)
			{
				num += 2;
			}
			if (this.MCNHHCHABOA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MCNHHCHABOA);
			}
			if (this.FINCLAOCOGH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FINCLAOCOGH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00080174 File Offset: 0x0007E374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EMLPKGJNAJK other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JKGBGFOPMHM != 0U)
			{
				this.JKGBGFOPMHM = other.JKGBGFOPMHM;
			}
			if (other.MHFMCEICFPJ)
			{
				this.MHFMCEICFPJ = other.MHFMCEICFPJ;
			}
			if (other.MCNHHCHABOA != 0U)
			{
				this.MCNHHCHABOA = other.MCNHHCHABOA;
			}
			if (other.FINCLAOCOGH != 0U)
			{
				this.FINCLAOCOGH = other.FINCLAOCOGH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000801EC File Offset: 0x0007E3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000801F8 File Offset: 0x0007E3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.JKGBGFOPMHM = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.MHFMCEICFPJ = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MCNHHCHABOA = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.FINCLAOCOGH = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001298 RID: 4760
		private static readonly MessageParser<EMLPKGJNAJK> _parser = new MessageParser<EMLPKGJNAJK>(() => new EMLPKGJNAJK());

		// Token: 0x04001299 RID: 4761
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400129A RID: 4762
		public const int JKGBGFOPMHMFieldNumber = 1;

		// Token: 0x0400129B RID: 4763
		private uint jKGBGFOPMHM_;

		// Token: 0x0400129C RID: 4764
		public const int MHFMCEICFPJFieldNumber = 2;

		// Token: 0x0400129D RID: 4765
		private bool mHFMCEICFPJ_;

		// Token: 0x0400129E RID: 4766
		public const int MCNHHCHABOAFieldNumber = 3;

		// Token: 0x0400129F RID: 4767
		private uint mCNHHCHABOA_;

		// Token: 0x040012A0 RID: 4768
		public const int FINCLAOCOGHFieldNumber = 4;

		// Token: 0x040012A1 RID: 4769
		private uint fINCLAOCOGH_;
	}
}
