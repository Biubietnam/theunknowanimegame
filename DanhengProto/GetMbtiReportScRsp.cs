using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200071B RID: 1819
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMbtiReportScRsp : IMessage<GetMbtiReportScRsp>, IMessage, IEquatable<GetMbtiReportScRsp>, IDeepCloneable<GetMbtiReportScRsp>, IBufferMessage
	{
		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06005141 RID: 20801 RVA: 0x000DAB83 File Offset: 0x000D8D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMbtiReportScRsp> Parser
		{
			get
			{
				return GetMbtiReportScRsp._parser;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06005142 RID: 20802 RVA: 0x000DAB8A File Offset: 0x000D8D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMbtiReportScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06005143 RID: 20803 RVA: 0x000DAB9C File Offset: 0x000D8D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMbtiReportScRsp.Descriptor;
			}
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x000DABA3 File Offset: 0x000D8DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMbtiReportScRsp()
		{
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x000DABC4 File Offset: 0x000D8DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMbtiReportScRsp(GetMbtiReportScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.pPNMMPFAMDA_ = other.pPNMMPFAMDA_;
			this.isTakenReward_ = other.isTakenReward_;
			this.kLHMMAAHANI_ = other.kLHMMAAHANI_;
			this.jLAFELNGAKD_ = other.jLAFELNGAKD_;
			this.progress_ = other.progress_;
			this.aKJJGCIEJMP_ = other.aKJJGCIEJMP_.Clone();
			this.pHAKIBBELNK_ = other.pHAKIBBELNK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x000DAC52 File Offset: 0x000D8E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMbtiReportScRsp Clone()
		{
			return new GetMbtiReportScRsp(this);
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x000DAC5A File Offset: 0x000D8E5A
		// (set) Token: 0x06005148 RID: 20808 RVA: 0x000DAC62 File Offset: 0x000D8E62
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

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06005149 RID: 20809 RVA: 0x000DAC6B File Offset: 0x000D8E6B
		// (set) Token: 0x0600514A RID: 20810 RVA: 0x000DAC73 File Offset: 0x000D8E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PPNMMPFAMDA
		{
			get
			{
				return this.pPNMMPFAMDA_;
			}
			set
			{
				this.pPNMMPFAMDA_ = value;
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x0600514B RID: 20811 RVA: 0x000DAC7C File Offset: 0x000D8E7C
		// (set) Token: 0x0600514C RID: 20812 RVA: 0x000DAC84 File Offset: 0x000D8E84
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

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x0600514D RID: 20813 RVA: 0x000DAC8D File Offset: 0x000D8E8D
		// (set) Token: 0x0600514E RID: 20814 RVA: 0x000DAC95 File Offset: 0x000D8E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KLHMMAAHANI
		{
			get
			{
				return this.kLHMMAAHANI_;
			}
			set
			{
				this.kLHMMAAHANI_ = value;
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x0600514F RID: 20815 RVA: 0x000DAC9E File Offset: 0x000D8E9E
		// (set) Token: 0x06005150 RID: 20816 RVA: 0x000DACA6 File Offset: 0x000D8EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int JLAFELNGAKD
		{
			get
			{
				return this.jLAFELNGAKD_;
			}
			set
			{
				this.jLAFELNGAKD_ = value;
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06005151 RID: 20817 RVA: 0x000DACAF File Offset: 0x000D8EAF
		// (set) Token: 0x06005152 RID: 20818 RVA: 0x000DACB7 File Offset: 0x000D8EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06005153 RID: 20819 RVA: 0x000DACC0 File Offset: 0x000D8EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BFGPPMDHKJH> AKJJGCIEJMP
		{
			get
			{
				return this.aKJJGCIEJMP_;
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06005154 RID: 20820 RVA: 0x000DACC8 File Offset: 0x000D8EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GODFNMFIENL> PHAKIBBELNK
		{
			get
			{
				return this.pHAKIBBELNK_;
			}
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x000DACD0 File Offset: 0x000D8ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMbtiReportScRsp);
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x000DACE0 File Offset: 0x000D8EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMbtiReportScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.PPNMMPFAMDA == other.PPNMMPFAMDA && this.IsTakenReward == other.IsTakenReward && this.KLHMMAAHANI == other.KLHMMAAHANI && this.JLAFELNGAKD == other.JLAFELNGAKD && this.Progress == other.Progress && this.aKJJGCIEJMP_.Equals(other.aKJJGCIEJMP_) && this.pHAKIBBELNK_.Equals(other.pHAKIBBELNK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x000DAD94 File Offset: 0x000D8F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.PPNMMPFAMDA)
			{
				num ^= this.PPNMMPFAMDA.GetHashCode();
			}
			if (this.IsTakenReward)
			{
				num ^= this.IsTakenReward.GetHashCode();
			}
			if (this.KLHMMAAHANI != 0)
			{
				num ^= this.KLHMMAAHANI.GetHashCode();
			}
			if (this.JLAFELNGAKD != 0)
			{
				num ^= this.JLAFELNGAKD.GetHashCode();
			}
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			num ^= this.aKJJGCIEJMP_.GetHashCode();
			num ^= this.pHAKIBBELNK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x000DAE6C File Offset: 0x000D906C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x000DAE74 File Offset: 0x000D9074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x000DAE80 File Offset: 0x000D9080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JLAFELNGAKD != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.JLAFELNGAKD);
			}
			if (this.PPNMMPFAMDA)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.PPNMMPFAMDA);
			}
			if (this.IsTakenReward)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsTakenReward);
			}
			this.aKJJGCIEJMP_.WriteTo(ref output, GetMbtiReportScRsp._repeated_aKJJGCIEJMP_codec);
			this.pHAKIBBELNK_.WriteTo(ref output, GetMbtiReportScRsp._repeated_pHAKIBBELNK_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.KLHMMAAHANI != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.KLHMMAAHANI);
			}
			if (this.Progress != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Progress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x000DAF6C File Offset: 0x000D916C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.PPNMMPFAMDA)
			{
				num += 2;
			}
			if (this.IsTakenReward)
			{
				num += 2;
			}
			if (this.KLHMMAAHANI != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KLHMMAAHANI);
			}
			if (this.JLAFELNGAKD != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.JLAFELNGAKD);
			}
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			num += this.aKJJGCIEJMP_.CalculateSize(GetMbtiReportScRsp._repeated_aKJJGCIEJMP_codec);
			num += this.pHAKIBBELNK_.CalculateSize(GetMbtiReportScRsp._repeated_pHAKIBBELNK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x000DB030 File Offset: 0x000D9230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMbtiReportScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.PPNMMPFAMDA)
			{
				this.PPNMMPFAMDA = other.PPNMMPFAMDA;
			}
			if (other.IsTakenReward)
			{
				this.IsTakenReward = other.IsTakenReward;
			}
			if (other.KLHMMAAHANI != 0)
			{
				this.KLHMMAAHANI = other.KLHMMAAHANI;
			}
			if (other.JLAFELNGAKD != 0)
			{
				this.JLAFELNGAKD = other.JLAFELNGAKD;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			this.aKJJGCIEJMP_.Add(other.aKJJGCIEJMP_);
			this.pHAKIBBELNK_.Add(other.pHAKIBBELNK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x000DB0F2 File Offset: 0x000D92F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x000DB0FC File Offset: 0x000D92FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num <= 32U)
					{
						if (num == 8U)
						{
							this.JLAFELNGAKD = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.PPNMMPFAMDA = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.IsTakenReward = input.ReadBool();
							continue;
						}
						if (num == 50U)
						{
							this.aKJJGCIEJMP_.AddEntriesFrom(ref input, GetMbtiReportScRsp._repeated_aKJJGCIEJMP_codec);
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 66U)
					{
						this.pHAKIBBELNK_.AddEntriesFrom(ref input, GetMbtiReportScRsp._repeated_pHAKIBBELNK_codec);
						continue;
					}
					if (num == 80U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.KLHMMAAHANI = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Progress = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FE7 RID: 8167
		private static readonly MessageParser<GetMbtiReportScRsp> _parser = new MessageParser<GetMbtiReportScRsp>(() => new GetMbtiReportScRsp());

		// Token: 0x04001FE8 RID: 8168
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FE9 RID: 8169
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04001FEA RID: 8170
		private uint retcode_;

		// Token: 0x04001FEB RID: 8171
		public const int PPNMMPFAMDAFieldNumber = 4;

		// Token: 0x04001FEC RID: 8172
		private bool pPNMMPFAMDA_;

		// Token: 0x04001FED RID: 8173
		public const int IsTakenRewardFieldNumber = 5;

		// Token: 0x04001FEE RID: 8174
		private bool isTakenReward_;

		// Token: 0x04001FEF RID: 8175
		public const int KLHMMAAHANIFieldNumber = 11;

		// Token: 0x04001FF0 RID: 8176
		private int kLHMMAAHANI_;

		// Token: 0x04001FF1 RID: 8177
		public const int JLAFELNGAKDFieldNumber = 1;

		// Token: 0x04001FF2 RID: 8178
		private int jLAFELNGAKD_;

		// Token: 0x04001FF3 RID: 8179
		public const int ProgressFieldNumber = 14;

		// Token: 0x04001FF4 RID: 8180
		private uint progress_;

		// Token: 0x04001FF5 RID: 8181
		public const int AKJJGCIEJMPFieldNumber = 6;

		// Token: 0x04001FF6 RID: 8182
		private static readonly FieldCodec<BFGPPMDHKJH> _repeated_aKJJGCIEJMP_codec = FieldCodec.ForMessage<BFGPPMDHKJH>(50U, BFGPPMDHKJH.Parser);

		// Token: 0x04001FF7 RID: 8183
		private readonly RepeatedField<BFGPPMDHKJH> aKJJGCIEJMP_ = new RepeatedField<BFGPPMDHKJH>();

		// Token: 0x04001FF8 RID: 8184
		public const int PHAKIBBELNKFieldNumber = 8;

		// Token: 0x04001FF9 RID: 8185
		private static readonly FieldCodec<GODFNMFIENL> _repeated_pHAKIBBELNK_codec = FieldCodec.ForMessage<GODFNMFIENL>(66U, GODFNMFIENL.Parser);

		// Token: 0x04001FFA RID: 8186
		private readonly RepeatedField<GODFNMFIENL> pHAKIBBELNK_ = new RepeatedField<GODFNMFIENL>();
	}
}
