using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012C5 RID: 4805
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeChallengeRaidRewardScRsp : IMessage<TakeChallengeRaidRewardScRsp>, IMessage, IEquatable<TakeChallengeRaidRewardScRsp>, IDeepCloneable<TakeChallengeRaidRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x0600D651 RID: 54865 RVA: 0x0023BB47 File Offset: 0x00239D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeChallengeRaidRewardScRsp> Parser
		{
			get
			{
				return TakeChallengeRaidRewardScRsp._parser;
			}
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x0600D652 RID: 54866 RVA: 0x0023BB4E File Offset: 0x00239D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeChallengeRaidRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x0600D653 RID: 54867 RVA: 0x0023BB60 File Offset: 0x00239D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeChallengeRaidRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D654 RID: 54868 RVA: 0x0023BB67 File Offset: 0x00239D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRaidRewardScRsp()
		{
		}

		// Token: 0x0600D655 RID: 54869 RVA: 0x0023BB70 File Offset: 0x00239D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRaidRewardScRsp(TakeChallengeRaidRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rewardId_ = other.rewardId_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D656 RID: 54870 RVA: 0x0023BBC8 File Offset: 0x00239DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRaidRewardScRsp Clone()
		{
			return new TakeChallengeRaidRewardScRsp(this);
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x0600D657 RID: 54871 RVA: 0x0023BBD0 File Offset: 0x00239DD0
		// (set) Token: 0x0600D658 RID: 54872 RVA: 0x0023BBD8 File Offset: 0x00239DD8
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

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x0600D659 RID: 54873 RVA: 0x0023BBE1 File Offset: 0x00239DE1
		// (set) Token: 0x0600D65A RID: 54874 RVA: 0x0023BBE9 File Offset: 0x00239DE9
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

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x0600D65B RID: 54875 RVA: 0x0023BBF2 File Offset: 0x00239DF2
		// (set) Token: 0x0600D65C RID: 54876 RVA: 0x0023BBFA File Offset: 0x00239DFA
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

		// Token: 0x0600D65D RID: 54877 RVA: 0x0023BC03 File Offset: 0x00239E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeChallengeRaidRewardScRsp);
		}

		// Token: 0x0600D65E RID: 54878 RVA: 0x0023BC14 File Offset: 0x00239E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeChallengeRaidRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.RewardId == other.RewardId && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D65F RID: 54879 RVA: 0x0023BC74 File Offset: 0x00239E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.RewardId != 0U)
			{
				num ^= this.RewardId.GetHashCode();
			}
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

		// Token: 0x0600D660 RID: 54880 RVA: 0x0023BCE2 File Offset: 0x00239EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D661 RID: 54881 RVA: 0x0023BCEA File Offset: 0x00239EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D662 RID: 54882 RVA: 0x0023BCF4 File Offset: 0x00239EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Reward);
			}
			if (this.RewardId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.RewardId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D663 RID: 54883 RVA: 0x0023BD6C File Offset: 0x00239F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.RewardId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RewardId);
			}
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

		// Token: 0x0600D664 RID: 54884 RVA: 0x0023BDDC File Offset: 0x00239FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeChallengeRaidRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.RewardId != 0U)
			{
				this.RewardId = other.RewardId;
			}
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

		// Token: 0x0600D665 RID: 54885 RVA: 0x0023BE58 File Offset: 0x0023A058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D666 RID: 54886 RVA: 0x0023BE64 File Offset: 0x0023A064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 80U)
					{
						if (num != 120U)
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
						this.RewardId = input.ReadUInt32();
					}
				}
				else
				{
					if (this.reward_ == null)
					{
						this.Reward = new ItemList();
					}
					input.ReadMessage(this.Reward);
				}
			}
		}

		// Token: 0x04005597 RID: 21911
		private static readonly MessageParser<TakeChallengeRaidRewardScRsp> _parser = new MessageParser<TakeChallengeRaidRewardScRsp>(() => new TakeChallengeRaidRewardScRsp());

		// Token: 0x04005598 RID: 21912
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005599 RID: 21913
		public const int RetcodeFieldNumber = 15;

		// Token: 0x0400559A RID: 21914
		private uint retcode_;

		// Token: 0x0400559B RID: 21915
		public const int RewardIdFieldNumber = 10;

		// Token: 0x0400559C RID: 21916
		private uint rewardId_;

		// Token: 0x0400559D RID: 21917
		public const int RewardFieldNumber = 9;

		// Token: 0x0400559E RID: 21918
		private ItemList reward_;
	}
}
