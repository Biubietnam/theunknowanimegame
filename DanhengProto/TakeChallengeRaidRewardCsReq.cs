using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012C3 RID: 4803
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeChallengeRaidRewardCsReq : IMessage<TakeChallengeRaidRewardCsReq>, IMessage, IEquatable<TakeChallengeRaidRewardCsReq>, IDeepCloneable<TakeChallengeRaidRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x0600D63C RID: 54844 RVA: 0x0023B8A0 File Offset: 0x00239AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeChallengeRaidRewardCsReq> Parser
		{
			get
			{
				return TakeChallengeRaidRewardCsReq._parser;
			}
		}

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x0600D63D RID: 54845 RVA: 0x0023B8A7 File Offset: 0x00239AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeChallengeRaidRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x0600D63E RID: 54846 RVA: 0x0023B8B9 File Offset: 0x00239AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeChallengeRaidRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D63F RID: 54847 RVA: 0x0023B8C0 File Offset: 0x00239AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRaidRewardCsReq()
		{
		}

		// Token: 0x0600D640 RID: 54848 RVA: 0x0023B8C8 File Offset: 0x00239AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRaidRewardCsReq(TakeChallengeRaidRewardCsReq other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D641 RID: 54849 RVA: 0x0023B8ED File Offset: 0x00239AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRaidRewardCsReq Clone()
		{
			return new TakeChallengeRaidRewardCsReq(this);
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x0600D642 RID: 54850 RVA: 0x0023B8F5 File Offset: 0x00239AF5
		// (set) Token: 0x0600D643 RID: 54851 RVA: 0x0023B8FD File Offset: 0x00239AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x0600D644 RID: 54852 RVA: 0x0023B906 File Offset: 0x00239B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeChallengeRaidRewardCsReq);
		}

		// Token: 0x0600D645 RID: 54853 RVA: 0x0023B914 File Offset: 0x00239B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeChallengeRaidRewardCsReq other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D646 RID: 54854 RVA: 0x0023B944 File Offset: 0x00239B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardId != 0U)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D647 RID: 54855 RVA: 0x0023B983 File Offset: 0x00239B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D648 RID: 54856 RVA: 0x0023B98B File Offset: 0x00239B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D649 RID: 54857 RVA: 0x0023B994 File Offset: 0x00239B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D64A RID: 54858 RVA: 0x0023B9C8 File Offset: 0x00239BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D64B RID: 54859 RVA: 0x0023BA06 File Offset: 0x00239C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeChallengeRaidRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardId != 0U)
			{
				this.RewardId = other.RewardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D64C RID: 54860 RVA: 0x0023BA37 File Offset: 0x00239C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D64D RID: 54861 RVA: 0x0023BA40 File Offset: 0x00239C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RewardId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005592 RID: 21906
		private static readonly MessageParser<TakeChallengeRaidRewardCsReq> _parser = new MessageParser<TakeChallengeRaidRewardCsReq>(() => new TakeChallengeRaidRewardCsReq());

		// Token: 0x04005593 RID: 21907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005594 RID: 21908
		public const int RewardIdFieldNumber = 4;

		// Token: 0x04005595 RID: 21909
		private uint rewardId_;
	}
}
