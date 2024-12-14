using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000643 RID: 1603
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChallengeRaidInfoScRsp : IMessage<GetChallengeRaidInfoScRsp>, IMessage, IEquatable<GetChallengeRaidInfoScRsp>, IDeepCloneable<GetChallengeRaidInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x060047EF RID: 18415 RVA: 0x000C4E37 File Offset: 0x000C3037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChallengeRaidInfoScRsp> Parser
		{
			get
			{
				return GetChallengeRaidInfoScRsp._parser;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x060047F0 RID: 18416 RVA: 0x000C4E3E File Offset: 0x000C303E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChallengeRaidInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x060047F1 RID: 18417 RVA: 0x000C4E50 File Offset: 0x000C3050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChallengeRaidInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x000C4E57 File Offset: 0x000C3057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRaidInfoScRsp()
		{
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x000C4E78 File Offset: 0x000C3078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRaidInfoScRsp(GetChallengeRaidInfoScRsp other) : this()
		{
			this.takenRewardIdList_ = other.takenRewardIdList_.Clone();
			this.challengeRaidDataList_ = other.challengeRaidDataList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x000C4ECA File Offset: 0x000C30CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRaidInfoScRsp Clone()
		{
			return new GetChallengeRaidInfoScRsp(this);
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x060047F5 RID: 18421 RVA: 0x000C4ED2 File Offset: 0x000C30D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TakenRewardIdList
		{
			get
			{
				return this.takenRewardIdList_;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x060047F6 RID: 18422 RVA: 0x000C4EDA File Offset: 0x000C30DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChallengeRaid> ChallengeRaidDataList
		{
			get
			{
				return this.challengeRaidDataList_;
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x000C4EE2 File Offset: 0x000C30E2
		// (set) Token: 0x060047F8 RID: 18424 RVA: 0x000C4EEA File Offset: 0x000C30EA
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

		// Token: 0x060047F9 RID: 18425 RVA: 0x000C4EF3 File Offset: 0x000C30F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChallengeRaidInfoScRsp);
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x000C4F04 File Offset: 0x000C3104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChallengeRaidInfoScRsp other)
		{
			return other != null && (other == this || (this.takenRewardIdList_.Equals(other.takenRewardIdList_) && this.challengeRaidDataList_.Equals(other.challengeRaidDataList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x000C4F68 File Offset: 0x000C3168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.takenRewardIdList_.GetHashCode();
			num ^= this.challengeRaidDataList_.GetHashCode();
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

		// Token: 0x060047FC RID: 18428 RVA: 0x000C4FC3 File Offset: 0x000C31C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x000C4FCB File Offset: 0x000C31CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x000C4FD4 File Offset: 0x000C31D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeRaidDataList_.WriteTo(ref output, GetChallengeRaidInfoScRsp._repeated_challengeRaidDataList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.takenRewardIdList_.WriteTo(ref output, GetChallengeRaidInfoScRsp._repeated_takenRewardIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x000C5034 File Offset: 0x000C3234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.takenRewardIdList_.CalculateSize(GetChallengeRaidInfoScRsp._repeated_takenRewardIdList_codec);
			num += this.challengeRaidDataList_.CalculateSize(GetChallengeRaidInfoScRsp._repeated_challengeRaidDataList_codec);
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

		// Token: 0x06004800 RID: 18432 RVA: 0x000C5098 File Offset: 0x000C3298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChallengeRaidInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.takenRewardIdList_.Add(other.takenRewardIdList_);
			this.challengeRaidDataList_.Add(other.challengeRaidDataList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x000C50F6 File Offset: 0x000C32F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x000C5100 File Offset: 0x000C3300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.challengeRaidDataList_.AddEntriesFrom(ref input, GetChallengeRaidInfoScRsp._repeated_challengeRaidDataList_codec);
						continue;
					}
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 88U || num == 90U)
				{
					this.takenRewardIdList_.AddEntriesFrom(ref input, GetChallengeRaidInfoScRsp._repeated_takenRewardIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001CC1 RID: 7361
		private static readonly MessageParser<GetChallengeRaidInfoScRsp> _parser = new MessageParser<GetChallengeRaidInfoScRsp>(() => new GetChallengeRaidInfoScRsp());

		// Token: 0x04001CC2 RID: 7362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CC3 RID: 7363
		public const int TakenRewardIdListFieldNumber = 11;

		// Token: 0x04001CC4 RID: 7364
		private static readonly FieldCodec<uint> _repeated_takenRewardIdList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04001CC5 RID: 7365
		private readonly RepeatedField<uint> takenRewardIdList_ = new RepeatedField<uint>();

		// Token: 0x04001CC6 RID: 7366
		public const int ChallengeRaidDataListFieldNumber = 1;

		// Token: 0x04001CC7 RID: 7367
		private static readonly FieldCodec<ChallengeRaid> _repeated_challengeRaidDataList_codec = FieldCodec.ForMessage<ChallengeRaid>(10U, ChallengeRaid.Parser);

		// Token: 0x04001CC8 RID: 7368
		private readonly RepeatedField<ChallengeRaid> challengeRaidDataList_ = new RepeatedField<ChallengeRaid>();

		// Token: 0x04001CC9 RID: 7369
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04001CCA RID: 7370
		private uint retcode_;
	}
}
