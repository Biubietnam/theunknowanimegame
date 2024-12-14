using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200078F RID: 1935
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRaidInfoScRsp : IMessage<GetRaidInfoScRsp>, IMessage, IEquatable<GetRaidInfoScRsp>, IDeepCloneable<GetRaidInfoScRsp>, IBufferMessage
	{
		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06005669 RID: 22121 RVA: 0x000E7BAF File Offset: 0x000E5DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRaidInfoScRsp> Parser
		{
			get
			{
				return GetRaidInfoScRsp._parser;
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x0600566A RID: 22122 RVA: 0x000E7BB6 File Offset: 0x000E5DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRaidInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x0600566B RID: 22123 RVA: 0x000E7BC8 File Offset: 0x000E5DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRaidInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x000E7BCF File Offset: 0x000E5DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRaidInfoScRsp()
		{
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x000E7BF8 File Offset: 0x000E5DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRaidInfoScRsp(GetRaidInfoScRsp other) : this()
		{
			this.challengeRaidList_ = other.challengeRaidList_.Clone();
			this.finishedRaidInfoList_ = other.finishedRaidInfoList_.Clone();
			this.retcode_ = other.retcode_;
			this.challengeTakenRewardIdList_ = other.challengeTakenRewardIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x000E7C5B File Offset: 0x000E5E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRaidInfoScRsp Clone()
		{
			return new GetRaidInfoScRsp(this);
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x0600566F RID: 22127 RVA: 0x000E7C63 File Offset: 0x000E5E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChallengeRaid> ChallengeRaidList
		{
			get
			{
				return this.challengeRaidList_;
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06005670 RID: 22128 RVA: 0x000E7C6B File Offset: 0x000E5E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FinishedRaidInfo> FinishedRaidInfoList
		{
			get
			{
				return this.finishedRaidInfoList_;
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06005671 RID: 22129 RVA: 0x000E7C73 File Offset: 0x000E5E73
		// (set) Token: 0x06005672 RID: 22130 RVA: 0x000E7C7B File Offset: 0x000E5E7B
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

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06005673 RID: 22131 RVA: 0x000E7C84 File Offset: 0x000E5E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ChallengeTakenRewardIdList
		{
			get
			{
				return this.challengeTakenRewardIdList_;
			}
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x000E7C8C File Offset: 0x000E5E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRaidInfoScRsp);
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x000E7C9C File Offset: 0x000E5E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRaidInfoScRsp other)
		{
			return other != null && (other == this || (this.challengeRaidList_.Equals(other.challengeRaidList_) && this.finishedRaidInfoList_.Equals(other.finishedRaidInfoList_) && this.Retcode == other.Retcode && this.challengeTakenRewardIdList_.Equals(other.challengeTakenRewardIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x000E7D14 File Offset: 0x000E5F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challengeRaidList_.GetHashCode();
			num ^= this.finishedRaidInfoList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.challengeTakenRewardIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x000E7D7D File Offset: 0x000E5F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x000E7D85 File Offset: 0x000E5F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x000E7D90 File Offset: 0x000E5F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeTakenRewardIdList_.WriteTo(ref output, GetRaidInfoScRsp._repeated_challengeTakenRewardIdList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			this.finishedRaidInfoList_.WriteTo(ref output, GetRaidInfoScRsp._repeated_finishedRaidInfoList_codec);
			this.challengeRaidList_.WriteTo(ref output, GetRaidInfoScRsp._repeated_challengeRaidList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x000E7E00 File Offset: 0x000E6000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challengeRaidList_.CalculateSize(GetRaidInfoScRsp._repeated_challengeRaidList_codec);
			num += this.finishedRaidInfoList_.CalculateSize(GetRaidInfoScRsp._repeated_finishedRaidInfoList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.challengeTakenRewardIdList_.CalculateSize(GetRaidInfoScRsp._repeated_challengeTakenRewardIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600567B RID: 22139 RVA: 0x000E7E78 File Offset: 0x000E6078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRaidInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.challengeRaidList_.Add(other.challengeRaidList_);
			this.finishedRaidInfoList_.Add(other.finishedRaidInfoList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.challengeTakenRewardIdList_.Add(other.challengeTakenRewardIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x000E7EE7 File Offset: 0x000E60E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x000E7EF0 File Offset: 0x000E60F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.challengeTakenRewardIdList_.AddEntriesFrom(ref input, GetRaidInfoScRsp._repeated_challengeTakenRewardIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						this.finishedRaidInfoList_.AddEntriesFrom(ref input, GetRaidInfoScRsp._repeated_finishedRaidInfoList_codec);
						continue;
					}
					if (num == 114U)
					{
						this.challengeRaidList_.AddEntriesFrom(ref input, GetRaidInfoScRsp._repeated_challengeRaidList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021CF RID: 8655
		private static readonly MessageParser<GetRaidInfoScRsp> _parser = new MessageParser<GetRaidInfoScRsp>(() => new GetRaidInfoScRsp());

		// Token: 0x040021D0 RID: 8656
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021D1 RID: 8657
		public const int ChallengeRaidListFieldNumber = 14;

		// Token: 0x040021D2 RID: 8658
		private static readonly FieldCodec<ChallengeRaid> _repeated_challengeRaidList_codec = FieldCodec.ForMessage<ChallengeRaid>(114U, ChallengeRaid.Parser);

		// Token: 0x040021D3 RID: 8659
		private readonly RepeatedField<ChallengeRaid> challengeRaidList_ = new RepeatedField<ChallengeRaid>();

		// Token: 0x040021D4 RID: 8660
		public const int FinishedRaidInfoListFieldNumber = 13;

		// Token: 0x040021D5 RID: 8661
		private static readonly FieldCodec<FinishedRaidInfo> _repeated_finishedRaidInfoList_codec = FieldCodec.ForMessage<FinishedRaidInfo>(106U, FinishedRaidInfo.Parser);

		// Token: 0x040021D6 RID: 8662
		private readonly RepeatedField<FinishedRaidInfo> finishedRaidInfoList_ = new RepeatedField<FinishedRaidInfo>();

		// Token: 0x040021D7 RID: 8663
		public const int RetcodeFieldNumber = 10;

		// Token: 0x040021D8 RID: 8664
		private uint retcode_;

		// Token: 0x040021D9 RID: 8665
		public const int ChallengeTakenRewardIdListFieldNumber = 2;

		// Token: 0x040021DA RID: 8666
		private static readonly FieldCodec<uint> _repeated_challengeTakenRewardIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040021DB RID: 8667
		private readonly RepeatedField<uint> challengeTakenRewardIdList_ = new RepeatedField<uint>();
	}
}
