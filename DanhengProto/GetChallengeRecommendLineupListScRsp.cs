using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000647 RID: 1607
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChallengeRecommendLineupListScRsp : IMessage<GetChallengeRecommendLineupListScRsp>, IMessage, IEquatable<GetChallengeRecommendLineupListScRsp>, IDeepCloneable<GetChallengeRecommendLineupListScRsp>, IBufferMessage
	{
		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x0600481B RID: 18459 RVA: 0x000C54D3 File Offset: 0x000C36D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChallengeRecommendLineupListScRsp> Parser
		{
			get
			{
				return GetChallengeRecommendLineupListScRsp._parser;
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x0600481C RID: 18460 RVA: 0x000C54DA File Offset: 0x000C36DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChallengeRecommendLineupListScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x000C54EC File Offset: 0x000C36EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChallengeRecommendLineupListScRsp.Descriptor;
			}
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x000C54F3 File Offset: 0x000C36F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRecommendLineupListScRsp()
		{
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x000C5508 File Offset: 0x000C3708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRecommendLineupListScRsp(GetChallengeRecommendLineupListScRsp other) : this()
		{
			this.pPAGGONDPCF_ = other.pPAGGONDPCF_.Clone();
			this.retcode_ = other.retcode_;
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004820 RID: 18464 RVA: 0x000C5555 File Offset: 0x000C3755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeRecommendLineupListScRsp Clone()
		{
			return new GetChallengeRecommendLineupListScRsp(this);
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06004821 RID: 18465 RVA: 0x000C555D File Offset: 0x000C375D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EACINHCCCMI> PPAGGONDPCF
		{
			get
			{
				return this.pPAGGONDPCF_;
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06004822 RID: 18466 RVA: 0x000C5565 File Offset: 0x000C3765
		// (set) Token: 0x06004823 RID: 18467 RVA: 0x000C556D File Offset: 0x000C376D
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

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06004824 RID: 18468 RVA: 0x000C5576 File Offset: 0x000C3776
		// (set) Token: 0x06004825 RID: 18469 RVA: 0x000C557E File Offset: 0x000C377E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x000C5587 File Offset: 0x000C3787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChallengeRecommendLineupListScRsp);
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x000C5598 File Offset: 0x000C3798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChallengeRecommendLineupListScRsp other)
		{
			return other != null && (other == this || (this.pPAGGONDPCF_.Equals(other.pPAGGONDPCF_) && this.Retcode == other.Retcode && this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x000C55F8 File Offset: 0x000C37F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pPAGGONDPCF_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x000C565E File Offset: 0x000C385E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x000C5666 File Offset: 0x000C3866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x000C5670 File Offset: 0x000C3870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pPAGGONDPCF_.WriteTo(ref output, GetChallengeRecommendLineupListScRsp._repeated_pPAGGONDPCF_codec);
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x000C56DC File Offset: 0x000C38DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pPAGGONDPCF_.CalculateSize(GetChallengeRecommendLineupListScRsp._repeated_pPAGGONDPCF_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x000C5748 File Offset: 0x000C3948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChallengeRecommendLineupListScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.pPAGGONDPCF_.Add(other.pPAGGONDPCF_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x000C57A9 File Offset: 0x000C39A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x000C57B4 File Offset: 0x000C39B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 48U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.ChallengeId = input.ReadUInt32();
					}
				}
				else
				{
					this.pPAGGONDPCF_.AddEntriesFrom(ref input, GetChallengeRecommendLineupListScRsp._repeated_pPAGGONDPCF_codec);
				}
			}
		}

		// Token: 0x04001CD1 RID: 7377
		private static readonly MessageParser<GetChallengeRecommendLineupListScRsp> _parser = new MessageParser<GetChallengeRecommendLineupListScRsp>(() => new GetChallengeRecommendLineupListScRsp());

		// Token: 0x04001CD2 RID: 7378
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CD3 RID: 7379
		public const int PPAGGONDPCFFieldNumber = 5;

		// Token: 0x04001CD4 RID: 7380
		private static readonly FieldCodec<EACINHCCCMI> _repeated_pPAGGONDPCF_codec = FieldCodec.ForMessage<EACINHCCCMI>(42U, EACINHCCCMI.Parser);

		// Token: 0x04001CD5 RID: 7381
		private readonly RepeatedField<EACINHCCCMI> pPAGGONDPCF_ = new RepeatedField<EACINHCCCMI>();

		// Token: 0x04001CD6 RID: 7382
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04001CD7 RID: 7383
		private uint retcode_;

		// Token: 0x04001CD8 RID: 7384
		public const int ChallengeIdFieldNumber = 6;

		// Token: 0x04001CD9 RID: 7385
		private uint challengeId_;
	}
}
