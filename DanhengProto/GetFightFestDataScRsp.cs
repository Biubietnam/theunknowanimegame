using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006A7 RID: 1703
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFightFestDataScRsp : IMessage<GetFightFestDataScRsp>, IMessage, IEquatable<GetFightFestDataScRsp>, IDeepCloneable<GetFightFestDataScRsp>, IBufferMessage
	{
		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06004C38 RID: 19512 RVA: 0x000CECD7 File Offset: 0x000CCED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFightFestDataScRsp> Parser
		{
			get
			{
				return GetFightFestDataScRsp._parser;
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06004C39 RID: 19513 RVA: 0x000CECDE File Offset: 0x000CCEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFightFestDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06004C3A RID: 19514 RVA: 0x000CECF0 File Offset: 0x000CCEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFightFestDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x000CECF7 File Offset: 0x000CCEF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightFestDataScRsp()
		{
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x000CED18 File Offset: 0x000CCF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightFestDataScRsp(GetFightFestDataScRsp other) : this()
		{
			this.scoreId_ = other.scoreId_;
			this.jJIPJBEAJIH_ = other.jJIPJBEAJIH_.Clone();
			this.itemValue_ = other.itemValue_;
			this.challengeList_ = other.challengeList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x000CED82 File Offset: 0x000CCF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightFestDataScRsp Clone()
		{
			return new GetFightFestDataScRsp(this);
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06004C3E RID: 19518 RVA: 0x000CED8A File Offset: 0x000CCF8A
		// (set) Token: 0x06004C3F RID: 19519 RVA: 0x000CED92 File Offset: 0x000CCF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06004C40 RID: 19520 RVA: 0x000CED9B File Offset: 0x000CCF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> JJIPJBEAJIH
		{
			get
			{
				return this.jJIPJBEAJIH_;
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06004C41 RID: 19521 RVA: 0x000CEDA3 File Offset: 0x000CCFA3
		// (set) Token: 0x06004C42 RID: 19522 RVA: 0x000CEDAB File Offset: 0x000CCFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemValue
		{
			get
			{
				return this.itemValue_;
			}
			set
			{
				this.itemValue_ = value;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06004C43 RID: 19523 RVA: 0x000CEDB4 File Offset: 0x000CCFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JMDAEBFHNAI> ChallengeList
		{
			get
			{
				return this.challengeList_;
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06004C44 RID: 19524 RVA: 0x000CEDBC File Offset: 0x000CCFBC
		// (set) Token: 0x06004C45 RID: 19525 RVA: 0x000CEDC4 File Offset: 0x000CCFC4
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

		// Token: 0x06004C46 RID: 19526 RVA: 0x000CEDCD File Offset: 0x000CCFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFightFestDataScRsp);
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x000CEDDC File Offset: 0x000CCFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFightFestDataScRsp other)
		{
			return other != null && (other == this || (this.ScoreId == other.ScoreId && this.jJIPJBEAJIH_.Equals(other.jJIPJBEAJIH_) && this.ItemValue == other.ItemValue && this.challengeList_.Equals(other.challengeList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x000CEE60 File Offset: 0x000CD060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			num ^= this.jJIPJBEAJIH_.GetHashCode();
			if (this.ItemValue != 0U)
			{
				num ^= this.ItemValue.GetHashCode();
			}
			num ^= this.challengeList_.GetHashCode();
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

		// Token: 0x06004C49 RID: 19529 RVA: 0x000CEEED File Offset: 0x000CD0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x000CEEF5 File Offset: 0x000CD0F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x000CEF00 File Offset: 0x000CD100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemValue != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ItemValue);
			}
			this.challengeList_.WriteTo(ref output, GetFightFestDataScRsp._repeated_challengeList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ScoreId);
			}
			this.jJIPJBEAJIH_.WriteTo(ref output, GetFightFestDataScRsp._repeated_jJIPJBEAJIH_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x000CEF98 File Offset: 0x000CD198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			num += this.jJIPJBEAJIH_.CalculateSize(GetFightFestDataScRsp._repeated_jJIPJBEAJIH_codec);
			if (this.ItemValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemValue);
			}
			num += this.challengeList_.CalculateSize(GetFightFestDataScRsp._repeated_challengeList_codec);
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

		// Token: 0x06004C4D RID: 19533 RVA: 0x000CF02C File Offset: 0x000CD22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFightFestDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			this.jJIPJBEAJIH_.Add(other.jJIPJBEAJIH_);
			if (other.ItemValue != 0U)
			{
				this.ItemValue = other.ItemValue;
			}
			this.challengeList_.Add(other.challengeList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x000CF0B2 File Offset: 0x000CD2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x000CF0BC File Offset: 0x000CD2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.ItemValue = input.ReadUInt32();
						continue;
					}
					if (num == 42U)
					{
						this.challengeList_.AddEntriesFrom(ref input, GetFightFestDataScRsp._repeated_challengeList_codec);
						continue;
					}
					if (num == 56U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
					if (num == 80U || num == 82U)
					{
						this.jJIPJBEAJIH_.AddEntriesFrom(ref input, GetFightFestDataScRsp._repeated_jJIPJBEAJIH_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E28 RID: 7720
		private static readonly MessageParser<GetFightFestDataScRsp> _parser = new MessageParser<GetFightFestDataScRsp>(() => new GetFightFestDataScRsp());

		// Token: 0x04001E29 RID: 7721
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E2A RID: 7722
		public const int ScoreIdFieldNumber = 8;

		// Token: 0x04001E2B RID: 7723
		private uint scoreId_;

		// Token: 0x04001E2C RID: 7724
		public const int JJIPJBEAJIHFieldNumber = 10;

		// Token: 0x04001E2D RID: 7725
		private static readonly FieldCodec<uint> _repeated_jJIPJBEAJIH_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04001E2E RID: 7726
		private readonly RepeatedField<uint> jJIPJBEAJIH_ = new RepeatedField<uint>();

		// Token: 0x04001E2F RID: 7727
		public const int ItemValueFieldNumber = 4;

		// Token: 0x04001E30 RID: 7728
		private uint itemValue_;

		// Token: 0x04001E31 RID: 7729
		public const int ChallengeListFieldNumber = 5;

		// Token: 0x04001E32 RID: 7730
		private static readonly FieldCodec<JMDAEBFHNAI> _repeated_challengeList_codec = FieldCodec.ForMessage<JMDAEBFHNAI>(42U, JMDAEBFHNAI.Parser);

		// Token: 0x04001E33 RID: 7731
		private readonly RepeatedField<JMDAEBFHNAI> challengeList_ = new RepeatedField<JMDAEBFHNAI>();

		// Token: 0x04001E34 RID: 7732
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04001E35 RID: 7733
		private uint retcode_;
	}
}
