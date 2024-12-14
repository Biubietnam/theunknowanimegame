using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001323 RID: 4899
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueEndlessActivityAllBonusRewardScRsp : IMessage<TakeRogueEndlessActivityAllBonusRewardScRsp>, IMessage, IEquatable<TakeRogueEndlessActivityAllBonusRewardScRsp>, IDeepCloneable<TakeRogueEndlessActivityAllBonusRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x0600DA93 RID: 55955 RVA: 0x00246287 File Offset: 0x00244487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp> Parser
		{
			get
			{
				return TakeRogueEndlessActivityAllBonusRewardScRsp._parser;
			}
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x0600DA94 RID: 55956 RVA: 0x0024628E File Offset: 0x0024448E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueEndlessActivityAllBonusRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x0600DA95 RID: 55957 RVA: 0x002462A0 File Offset: 0x002444A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueEndlessActivityAllBonusRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DA96 RID: 55958 RVA: 0x002462A7 File Offset: 0x002444A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityAllBonusRewardScRsp()
		{
		}

		// Token: 0x0600DA97 RID: 55959 RVA: 0x002462BC File Offset: 0x002444BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityAllBonusRewardScRsp(TakeRogueEndlessActivityAllBonusRewardScRsp other) : this()
		{
			this.aPGBCNNPHMB_ = other.aPGBCNNPHMB_;
			this.retcode_ = other.retcode_;
			this.lHFDCBAFJGK_ = other.lHFDCBAFJGK_.Clone();
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA98 RID: 55960 RVA: 0x00246325 File Offset: 0x00244525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityAllBonusRewardScRsp Clone()
		{
			return new TakeRogueEndlessActivityAllBonusRewardScRsp(this);
		}

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x0600DA99 RID: 55961 RVA: 0x0024632D File Offset: 0x0024452D
		// (set) Token: 0x0600DA9A RID: 55962 RVA: 0x00246335 File Offset: 0x00244535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint APGBCNNPHMB
		{
			get
			{
				return this.aPGBCNNPHMB_;
			}
			set
			{
				this.aPGBCNNPHMB_ = value;
			}
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x0600DA9B RID: 55963 RVA: 0x0024633E File Offset: 0x0024453E
		// (set) Token: 0x0600DA9C RID: 55964 RVA: 0x00246346 File Offset: 0x00244546
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

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x0600DA9D RID: 55965 RVA: 0x0024634F File Offset: 0x0024454F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LHFDCBAFJGK
		{
			get
			{
				return this.lHFDCBAFJGK_;
			}
		}

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x0600DA9E RID: 55966 RVA: 0x00246357 File Offset: 0x00244557
		// (set) Token: 0x0600DA9F RID: 55967 RVA: 0x0024635F File Offset: 0x0024455F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x0600DAA0 RID: 55968 RVA: 0x00246368 File Offset: 0x00244568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueEndlessActivityAllBonusRewardScRsp);
		}

		// Token: 0x0600DAA1 RID: 55969 RVA: 0x00246378 File Offset: 0x00244578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueEndlessActivityAllBonusRewardScRsp other)
		{
			return other != null && (other == this || (this.APGBCNNPHMB == other.APGBCNNPHMB && this.Retcode == other.Retcode && this.lHFDCBAFJGK_.Equals(other.lHFDCBAFJGK_) && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DAA2 RID: 55970 RVA: 0x002463EC File Offset: 0x002445EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.APGBCNNPHMB != 0U)
			{
				num ^= this.APGBCNNPHMB.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.lHFDCBAFJGK_.GetHashCode();
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DAA3 RID: 55971 RVA: 0x00246468 File Offset: 0x00244668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DAA4 RID: 55972 RVA: 0x00246470 File Offset: 0x00244670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DAA5 RID: 55973 RVA: 0x0024647C File Offset: 0x0024467C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lHFDCBAFJGK_.WriteTo(ref output, TakeRogueEndlessActivityAllBonusRewardScRsp._repeated_lHFDCBAFJGK_codec);
			if (this.APGBCNNPHMB != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.APGBCNNPHMB);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DAA6 RID: 55974 RVA: 0x00246504 File Offset: 0x00244704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.APGBCNNPHMB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.APGBCNNPHMB);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.lHFDCBAFJGK_.CalculateSize(TakeRogueEndlessActivityAllBonusRewardScRsp._repeated_lHFDCBAFJGK_codec);
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DAA7 RID: 55975 RVA: 0x00246588 File Offset: 0x00244788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueEndlessActivityAllBonusRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.APGBCNNPHMB != 0U)
			{
				this.APGBCNNPHMB = other.APGBCNNPHMB;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.lHFDCBAFJGK_.Add(other.lHFDCBAFJGK_);
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DAA8 RID: 55976 RVA: 0x00246615 File Offset: 0x00244815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DAA9 RID: 55977 RVA: 0x00246620 File Offset: 0x00244820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.lHFDCBAFJGK_.AddEntriesFrom(ref input, TakeRogueEndlessActivityAllBonusRewardScRsp._repeated_lHFDCBAFJGK_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.APGBCNNPHMB = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 98U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005707 RID: 22279
		private static readonly MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp> _parser = new MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp>(() => new TakeRogueEndlessActivityAllBonusRewardScRsp());

		// Token: 0x04005708 RID: 22280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005709 RID: 22281
		public const int APGBCNNPHMBFieldNumber = 6;

		// Token: 0x0400570A RID: 22282
		private uint aPGBCNNPHMB_;

		// Token: 0x0400570B RID: 22283
		public const int RetcodeFieldNumber = 7;

		// Token: 0x0400570C RID: 22284
		private uint retcode_;

		// Token: 0x0400570D RID: 22285
		public const int LHFDCBAFJGKFieldNumber = 1;

		// Token: 0x0400570E RID: 22286
		private static readonly FieldCodec<uint> _repeated_lHFDCBAFJGK_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400570F RID: 22287
		private readonly RepeatedField<uint> lHFDCBAFJGK_ = new RepeatedField<uint>();

		// Token: 0x04005710 RID: 22288
		public const int RewardFieldNumber = 12;

		// Token: 0x04005711 RID: 22289
		private ItemList reward_;
	}
}
