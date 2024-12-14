using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000649 RID: 1609
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChallengeScRsp : IMessage<GetChallengeScRsp>, IMessage, IEquatable<GetChallengeScRsp>, IDeepCloneable<GetChallengeScRsp>, IBufferMessage
	{
		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06004833 RID: 18483 RVA: 0x000C5927 File Offset: 0x000C3B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChallengeScRsp> Parser
		{
			get
			{
				return GetChallengeScRsp._parser;
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x000C592E File Offset: 0x000C3B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChallengeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06004835 RID: 18485 RVA: 0x000C5940 File Offset: 0x000C3B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChallengeScRsp.Descriptor;
			}
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x000C5947 File Offset: 0x000C3B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeScRsp()
		{
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x000C5970 File Offset: 0x000C3B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeScRsp(GetChallengeScRsp other) : this()
		{
			this.gGBCPNCDMFA_ = other.gGBCPNCDMFA_;
			this.retcode_ = other.retcode_;
			this.gPHCPLPHNNM_ = other.gPHCPLPHNNM_.Clone();
			this.challengeGroupList_ = other.challengeGroupList_.Clone();
			this.challengeList_ = other.challengeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x000C59DF File Offset: 0x000C3BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeScRsp Clone()
		{
			return new GetChallengeScRsp(this);
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x000C59E7 File Offset: 0x000C3BE7
		// (set) Token: 0x0600483A RID: 18490 RVA: 0x000C59EF File Offset: 0x000C3BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GGBCPNCDMFA
		{
			get
			{
				return this.gGBCPNCDMFA_;
			}
			set
			{
				this.gGBCPNCDMFA_ = value;
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x0600483B RID: 18491 RVA: 0x000C59F8 File Offset: 0x000C3BF8
		// (set) Token: 0x0600483C RID: 18492 RVA: 0x000C5A00 File Offset: 0x000C3C00
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

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x000C5A09 File Offset: 0x000C3C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OMPDJIJNNBP> GPHCPLPHNNM
		{
			get
			{
				return this.gPHCPLPHNNM_;
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x000C5A11 File Offset: 0x000C3C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChallengeGroup> ChallengeGroupList
		{
			get
			{
				return this.challengeGroupList_;
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x0600483F RID: 18495 RVA: 0x000C5A19 File Offset: 0x000C3C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Challenge> ChallengeList
		{
			get
			{
				return this.challengeList_;
			}
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x000C5A21 File Offset: 0x000C3C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChallengeScRsp);
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x000C5A30 File Offset: 0x000C3C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChallengeScRsp other)
		{
			return other != null && (other == this || (this.GGBCPNCDMFA == other.GGBCPNCDMFA && this.Retcode == other.Retcode && this.gPHCPLPHNNM_.Equals(other.gPHCPLPHNNM_) && this.challengeGroupList_.Equals(other.challengeGroupList_) && this.challengeList_.Equals(other.challengeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x000C5AB8 File Offset: 0x000C3CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GGBCPNCDMFA != 0U)
			{
				num ^= this.GGBCPNCDMFA.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.gPHCPLPHNNM_.GetHashCode();
			num ^= this.challengeGroupList_.GetHashCode();
			num ^= this.challengeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x000C5B3A File Offset: 0x000C3D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x000C5B42 File Offset: 0x000C3D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x000C5B4C File Offset: 0x000C3D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			this.challengeGroupList_.WriteTo(ref output, GetChallengeScRsp._repeated_challengeGroupList_codec);
			if (this.GGBCPNCDMFA != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.GGBCPNCDMFA);
			}
			this.gPHCPLPHNNM_.WriteTo(ref output, GetChallengeScRsp._repeated_gPHCPLPHNNM_codec);
			this.challengeList_.WriteTo(ref output, GetChallengeScRsp._repeated_challengeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x000C5BD8 File Offset: 0x000C3DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GGBCPNCDMFA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GGBCPNCDMFA);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.gPHCPLPHNNM_.CalculateSize(GetChallengeScRsp._repeated_gPHCPLPHNNM_codec);
			num += this.challengeGroupList_.CalculateSize(GetChallengeScRsp._repeated_challengeGroupList_codec);
			num += this.challengeList_.CalculateSize(GetChallengeScRsp._repeated_challengeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x000C5C68 File Offset: 0x000C3E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChallengeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GGBCPNCDMFA != 0U)
			{
				this.GGBCPNCDMFA = other.GGBCPNCDMFA;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.gPHCPLPHNNM_.Add(other.gPHCPLPHNNM_);
			this.challengeGroupList_.Add(other.challengeGroupList_);
			this.challengeList_.Add(other.challengeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x000C5CEB File Offset: 0x000C3EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x000C5CF4 File Offset: 0x000C3EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
					{
						this.challengeGroupList_.AddEntriesFrom(ref input, GetChallengeScRsp._repeated_challengeGroupList_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.GGBCPNCDMFA = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						this.gPHCPLPHNNM_.AddEntriesFrom(ref input, GetChallengeScRsp._repeated_gPHCPLPHNNM_codec);
						continue;
					}
					if (num == 122U)
					{
						this.challengeList_.AddEntriesFrom(ref input, GetChallengeScRsp._repeated_challengeList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001CDB RID: 7387
		private static readonly MessageParser<GetChallengeScRsp> _parser = new MessageParser<GetChallengeScRsp>(() => new GetChallengeScRsp());

		// Token: 0x04001CDC RID: 7388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CDD RID: 7389
		public const int GGBCPNCDMFAFieldNumber = 12;

		// Token: 0x04001CDE RID: 7390
		private uint gGBCPNCDMFA_;

		// Token: 0x04001CDF RID: 7391
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001CE0 RID: 7392
		private uint retcode_;

		// Token: 0x04001CE1 RID: 7393
		public const int GPHCPLPHNNMFieldNumber = 13;

		// Token: 0x04001CE2 RID: 7394
		private static readonly FieldCodec<OMPDJIJNNBP> _repeated_gPHCPLPHNNM_codec = FieldCodec.ForMessage<OMPDJIJNNBP>(106U, OMPDJIJNNBP.Parser);

		// Token: 0x04001CE3 RID: 7395
		private readonly RepeatedField<OMPDJIJNNBP> gPHCPLPHNNM_ = new RepeatedField<OMPDJIJNNBP>();

		// Token: 0x04001CE4 RID: 7396
		public const int ChallengeGroupListFieldNumber = 9;

		// Token: 0x04001CE5 RID: 7397
		private static readonly FieldCodec<ChallengeGroup> _repeated_challengeGroupList_codec = FieldCodec.ForMessage<ChallengeGroup>(74U, ChallengeGroup.Parser);

		// Token: 0x04001CE6 RID: 7398
		private readonly RepeatedField<ChallengeGroup> challengeGroupList_ = new RepeatedField<ChallengeGroup>();

		// Token: 0x04001CE7 RID: 7399
		public const int ChallengeListFieldNumber = 15;

		// Token: 0x04001CE8 RID: 7400
		private static readonly FieldCodec<Challenge> _repeated_challengeList_codec = FieldCodec.ForMessage<Challenge>(122U, Challenge.Parser);

		// Token: 0x04001CE9 RID: 7401
		private readonly RepeatedField<Challenge> challengeList_ = new RepeatedField<Challenge>();
	}
}
