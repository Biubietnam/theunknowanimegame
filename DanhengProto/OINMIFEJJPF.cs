using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C57 RID: 3159
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OINMIFEJJPF : IMessage<OINMIFEJJPF>, IMessage, IEquatable<OINMIFEJJPF>, IDeepCloneable<OINMIFEJJPF>, IBufferMessage
	{
		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x06008C43 RID: 35907 RVA: 0x00172BD8 File Offset: 0x00170DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OINMIFEJJPF> Parser
		{
			get
			{
				return OINMIFEJJPF._parser;
			}
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x06008C44 RID: 35908 RVA: 0x00172BDF File Offset: 0x00170DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OINMIFEJJPFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x06008C45 RID: 35909 RVA: 0x00172BF1 File Offset: 0x00170DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OINMIFEJJPF.Descriptor;
			}
		}

		// Token: 0x06008C46 RID: 35910 RVA: 0x00172BF8 File Offset: 0x00170DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OINMIFEJJPF()
		{
		}

		// Token: 0x06008C47 RID: 35911 RVA: 0x00172C18 File Offset: 0x00170E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OINMIFEJJPF(OINMIFEJJPF other) : this()
		{
			this.finishTime_ = other.finishTime_;
			this.isTakenReward_ = other.isTakenReward_;
			this.status_ = other.status_;
			this.lHBLFMFEGMM_ = other.lHBLFMFEGMM_;
			this.eCMAMMPKAGN_ = other.eCMAMMPKAGN_;
			this.hDDGPMMNICD_ = other.hDDGPMMNICD_;
			this.pMJLDMLNEJG_ = other.pMJLDMLNEJG_;
			this.nOFCPIPLKOI_ = other.nOFCPIPLKOI_.Clone();
			this.mEEFIIHPBHG_ = other.mEEFIIHPBHG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C48 RID: 35912 RVA: 0x00172CB2 File Offset: 0x00170EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OINMIFEJJPF Clone()
		{
			return new OINMIFEJJPF(this);
		}

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x06008C49 RID: 35913 RVA: 0x00172CBA File Offset: 0x00170EBA
		// (set) Token: 0x06008C4A RID: 35914 RVA: 0x00172CC2 File Offset: 0x00170EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FinishTime
		{
			get
			{
				return this.finishTime_;
			}
			set
			{
				this.finishTime_ = value;
			}
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x06008C4B RID: 35915 RVA: 0x00172CCB File Offset: 0x00170ECB
		// (set) Token: 0x06008C4C RID: 35916 RVA: 0x00172CD3 File Offset: 0x00170ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTakenReward
		{
			get
			{
				return this.isTakenReward_;
			}
			set
			{
				this.isTakenReward_ = value;
			}
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x06008C4D RID: 35917 RVA: 0x00172CDC File Offset: 0x00170EDC
		// (set) Token: 0x06008C4E RID: 35918 RVA: 0x00172CE4 File Offset: 0x00170EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KPHNHCHPCBJ Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x06008C4F RID: 35919 RVA: 0x00172CED File Offset: 0x00170EED
		// (set) Token: 0x06008C50 RID: 35920 RVA: 0x00172CF5 File Offset: 0x00170EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LHBLFMFEGMM
		{
			get
			{
				return this.lHBLFMFEGMM_;
			}
			set
			{
				this.lHBLFMFEGMM_ = value;
			}
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x06008C51 RID: 35921 RVA: 0x00172CFE File Offset: 0x00170EFE
		// (set) Token: 0x06008C52 RID: 35922 RVA: 0x00172D06 File Offset: 0x00170F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ECMAMMPKAGN
		{
			get
			{
				return this.eCMAMMPKAGN_;
			}
			set
			{
				this.eCMAMMPKAGN_ = value;
			}
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x06008C53 RID: 35923 RVA: 0x00172D0F File Offset: 0x00170F0F
		// (set) Token: 0x06008C54 RID: 35924 RVA: 0x00172D17 File Offset: 0x00170F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HDDGPMMNICD
		{
			get
			{
				return this.hDDGPMMNICD_;
			}
			set
			{
				this.hDDGPMMNICD_ = value;
			}
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x06008C55 RID: 35925 RVA: 0x00172D20 File Offset: 0x00170F20
		// (set) Token: 0x06008C56 RID: 35926 RVA: 0x00172D28 File Offset: 0x00170F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PMJLDMLNEJG
		{
			get
			{
				return this.pMJLDMLNEJG_;
			}
			set
			{
				this.pMJLDMLNEJG_ = value;
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x06008C57 RID: 35927 RVA: 0x00172D31 File Offset: 0x00170F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NOFCPIPLKOI
		{
			get
			{
				return this.nOFCPIPLKOI_;
			}
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x06008C58 RID: 35928 RVA: 0x00172D39 File Offset: 0x00170F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MEEFIIHPBHG
		{
			get
			{
				return this.mEEFIIHPBHG_;
			}
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x00172D41 File Offset: 0x00170F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OINMIFEJJPF);
		}

		// Token: 0x06008C5A RID: 35930 RVA: 0x00172D50 File Offset: 0x00170F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OINMIFEJJPF other)
		{
			return other != null && (other == this || (this.FinishTime == other.FinishTime && this.IsTakenReward == other.IsTakenReward && this.Status == other.Status && this.LHBLFMFEGMM == other.LHBLFMFEGMM && this.ECMAMMPKAGN == other.ECMAMMPKAGN && this.HDDGPMMNICD == other.HDDGPMMNICD && this.PMJLDMLNEJG == other.PMJLDMLNEJG && this.nOFCPIPLKOI_.Equals(other.nOFCPIPLKOI_) && this.mEEFIIHPBHG_.Equals(other.mEEFIIHPBHG_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x00172E14 File Offset: 0x00171014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FinishTime != 0L)
			{
				num ^= this.FinishTime.GetHashCode();
			}
			if (this.IsTakenReward)
			{
				num ^= this.IsTakenReward.GetHashCode();
			}
			if (this.Status != KPHNHCHPCBJ.PlayerReturnNone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.LHBLFMFEGMM != 0U)
			{
				num ^= this.LHBLFMFEGMM.GetHashCode();
			}
			if (this.ECMAMMPKAGN != 0U)
			{
				num ^= this.ECMAMMPKAGN.GetHashCode();
			}
			if (this.HDDGPMMNICD != 0U)
			{
				num ^= this.HDDGPMMNICD.GetHashCode();
			}
			if (this.PMJLDMLNEJG != 0L)
			{
				num ^= this.PMJLDMLNEJG.GetHashCode();
			}
			num ^= this.nOFCPIPLKOI_.GetHashCode();
			num ^= this.mEEFIIHPBHG_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C5C RID: 35932 RVA: 0x00172F0E File Offset: 0x0017110E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C5D RID: 35933 RVA: 0x00172F16 File Offset: 0x00171116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C5E RID: 35934 RVA: 0x00172F20 File Offset: 0x00171120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PMJLDMLNEJG != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.PMJLDMLNEJG);
			}
			if (this.IsTakenReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsTakenReward);
			}
			if (this.LHBLFMFEGMM != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.LHBLFMFEGMM);
			}
			this.nOFCPIPLKOI_.WriteTo(ref output, OINMIFEJJPF._repeated_nOFCPIPLKOI_codec);
			if (this.HDDGPMMNICD != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.HDDGPMMNICD);
			}
			if (this.Status != KPHNHCHPCBJ.PlayerReturnNone)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Status);
			}
			this.mEEFIIHPBHG_.WriteTo(ref output, OINMIFEJJPF._repeated_mEEFIIHPBHG_codec);
			if (this.ECMAMMPKAGN != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ECMAMMPKAGN);
			}
			if (this.FinishTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.FinishTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C5F RID: 35935 RVA: 0x00173028 File Offset: 0x00171228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FinishTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FinishTime);
			}
			if (this.IsTakenReward)
			{
				num += 2;
			}
			if (this.Status != KPHNHCHPCBJ.PlayerReturnNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.LHBLFMFEGMM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LHBLFMFEGMM);
			}
			if (this.ECMAMMPKAGN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ECMAMMPKAGN);
			}
			if (this.HDDGPMMNICD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HDDGPMMNICD);
			}
			if (this.PMJLDMLNEJG != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PMJLDMLNEJG);
			}
			num += this.nOFCPIPLKOI_.CalculateSize(OINMIFEJJPF._repeated_nOFCPIPLKOI_codec);
			num += this.mEEFIIHPBHG_.CalculateSize(OINMIFEJJPF._repeated_mEEFIIHPBHG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C60 RID: 35936 RVA: 0x00173110 File Offset: 0x00171310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OINMIFEJJPF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FinishTime != 0L)
			{
				this.FinishTime = other.FinishTime;
			}
			if (other.IsTakenReward)
			{
				this.IsTakenReward = other.IsTakenReward;
			}
			if (other.Status != KPHNHCHPCBJ.PlayerReturnNone)
			{
				this.Status = other.Status;
			}
			if (other.LHBLFMFEGMM != 0U)
			{
				this.LHBLFMFEGMM = other.LHBLFMFEGMM;
			}
			if (other.ECMAMMPKAGN != 0U)
			{
				this.ECMAMMPKAGN = other.ECMAMMPKAGN;
			}
			if (other.HDDGPMMNICD != 0U)
			{
				this.HDDGPMMNICD = other.HDDGPMMNICD;
			}
			if (other.PMJLDMLNEJG != 0L)
			{
				this.PMJLDMLNEJG = other.PMJLDMLNEJG;
			}
			this.nOFCPIPLKOI_.Add(other.nOFCPIPLKOI_);
			this.mEEFIIHPBHG_.Add(other.mEEFIIHPBHG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C61 RID: 35937 RVA: 0x001731E6 File Offset: 0x001713E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C62 RID: 35938 RVA: 0x001731F0 File Offset: 0x001713F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 42U)
				{
					if (num <= 88U)
					{
						if (num == 56U)
						{
							this.HDDGPMMNICD = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							this.Status = (KPHNHCHPCBJ)input.ReadEnum();
							continue;
						}
						if (num != 88U)
						{
							goto IL_5F;
						}
					}
					else if (num != 90U)
					{
						if (num == 96U)
						{
							this.ECMAMMPKAGN = input.ReadUInt32();
							continue;
						}
						if (num != 112U)
						{
							goto IL_5F;
						}
						this.FinishTime = input.ReadInt64();
						continue;
					}
					this.mEEFIIHPBHG_.AddEntriesFrom(ref input, OINMIFEJJPF._repeated_mEEFIIHPBHG_codec);
					continue;
				}
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.PMJLDMLNEJG = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.IsTakenReward = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.LHBLFMFEGMM = input.ReadUInt32();
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.nOFCPIPLKOI_.AddEntriesFrom(ref input, OINMIFEJJPF._repeated_nOFCPIPLKOI_codec);
						continue;
					}
				}
				IL_5F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040035D9 RID: 13785
		private static readonly MessageParser<OINMIFEJJPF> _parser = new MessageParser<OINMIFEJJPF>(() => new OINMIFEJJPF());

		// Token: 0x040035DA RID: 13786
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035DB RID: 13787
		public const int FinishTimeFieldNumber = 14;

		// Token: 0x040035DC RID: 13788
		private long finishTime_;

		// Token: 0x040035DD RID: 13789
		public const int IsTakenRewardFieldNumber = 2;

		// Token: 0x040035DE RID: 13790
		private bool isTakenReward_;

		// Token: 0x040035DF RID: 13791
		public const int StatusFieldNumber = 8;

		// Token: 0x040035E0 RID: 13792
		private KPHNHCHPCBJ status_;

		// Token: 0x040035E1 RID: 13793
		public const int LHBLFMFEGMMFieldNumber = 4;

		// Token: 0x040035E2 RID: 13794
		private uint lHBLFMFEGMM_;

		// Token: 0x040035E3 RID: 13795
		public const int ECMAMMPKAGNFieldNumber = 12;

		// Token: 0x040035E4 RID: 13796
		private uint eCMAMMPKAGN_;

		// Token: 0x040035E5 RID: 13797
		public const int HDDGPMMNICDFieldNumber = 7;

		// Token: 0x040035E6 RID: 13798
		private uint hDDGPMMNICD_;

		// Token: 0x040035E7 RID: 13799
		public const int PMJLDMLNEJGFieldNumber = 1;

		// Token: 0x040035E8 RID: 13800
		private long pMJLDMLNEJG_;

		// Token: 0x040035E9 RID: 13801
		public const int NOFCPIPLKOIFieldNumber = 5;

		// Token: 0x040035EA RID: 13802
		private static readonly FieldCodec<uint> _repeated_nOFCPIPLKOI_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040035EB RID: 13803
		private readonly RepeatedField<uint> nOFCPIPLKOI_ = new RepeatedField<uint>();

		// Token: 0x040035EC RID: 13804
		public const int MEEFIIHPBHGFieldNumber = 11;

		// Token: 0x040035ED RID: 13805
		private static readonly FieldCodec<uint> _repeated_mEEFIIHPBHG_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x040035EE RID: 13806
		private readonly RepeatedField<uint> mEEFIIHPBHG_ = new RepeatedField<uint>();
	}
}
