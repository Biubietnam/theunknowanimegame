using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001333 RID: 4915
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueScoreRewardScRsp : IMessage<TakeRogueScoreRewardScRsp>, IMessage, IEquatable<TakeRogueScoreRewardScRsp>, IDeepCloneable<TakeRogueScoreRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x0600DB50 RID: 56144 RVA: 0x00248243 File Offset: 0x00246443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueScoreRewardScRsp> Parser
		{
			get
			{
				return TakeRogueScoreRewardScRsp._parser;
			}
		}

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x0600DB51 RID: 56145 RVA: 0x0024824A File Offset: 0x0024644A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueScoreRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x0600DB52 RID: 56146 RVA: 0x0024825C File Offset: 0x0024645C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueScoreRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DB53 RID: 56147 RVA: 0x00248263 File Offset: 0x00246463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueScoreRewardScRsp()
		{
		}

		// Token: 0x0600DB54 RID: 56148 RVA: 0x0024826C File Offset: 0x0024646C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueScoreRewardScRsp(TakeRogueScoreRewardScRsp other) : this()
		{
			this.poolId_ = other.poolId_;
			this.rogueScoreRewardInfo_ = ((other.rogueScoreRewardInfo_ != null) ? other.rogueScoreRewardInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB55 RID: 56149 RVA: 0x002482E0 File Offset: 0x002464E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueScoreRewardScRsp Clone()
		{
			return new TakeRogueScoreRewardScRsp(this);
		}

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x0600DB56 RID: 56150 RVA: 0x002482E8 File Offset: 0x002464E8
		// (set) Token: 0x0600DB57 RID: 56151 RVA: 0x002482F0 File Offset: 0x002464F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PoolId
		{
			get
			{
				return this.poolId_;
			}
			set
			{
				this.poolId_ = value;
			}
		}

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x0600DB58 RID: 56152 RVA: 0x002482F9 File Offset: 0x002464F9
		// (set) Token: 0x0600DB59 RID: 56153 RVA: 0x00248301 File Offset: 0x00246501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo RogueScoreRewardInfo
		{
			get
			{
				return this.rogueScoreRewardInfo_;
			}
			set
			{
				this.rogueScoreRewardInfo_ = value;
			}
		}

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x0600DB5A RID: 56154 RVA: 0x0024830A File Offset: 0x0024650A
		// (set) Token: 0x0600DB5B RID: 56155 RVA: 0x00248312 File Offset: 0x00246512
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

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x0600DB5C RID: 56156 RVA: 0x0024831B File Offset: 0x0024651B
		// (set) Token: 0x0600DB5D RID: 56157 RVA: 0x00248323 File Offset: 0x00246523
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

		// Token: 0x0600DB5E RID: 56158 RVA: 0x0024832C File Offset: 0x0024652C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueScoreRewardScRsp);
		}

		// Token: 0x0600DB5F RID: 56159 RVA: 0x0024833C File Offset: 0x0024653C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueScoreRewardScRsp other)
		{
			return other != null && (other == this || (this.PoolId == other.PoolId && object.Equals(this.RogueScoreRewardInfo, other.RogueScoreRewardInfo) && this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB60 RID: 56160 RVA: 0x002483B0 File Offset: 0x002465B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PoolId != 0U)
			{
				num ^= this.PoolId.GetHashCode();
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				num ^= this.RogueScoreRewardInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
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

		// Token: 0x0600DB61 RID: 56161 RVA: 0x00248434 File Offset: 0x00246634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DB62 RID: 56162 RVA: 0x0024843C File Offset: 0x0024663C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB63 RID: 56163 RVA: 0x00248448 File Offset: 0x00246648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueScoreRewardInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueScoreRewardInfo);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.PoolId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB64 RID: 56164 RVA: 0x002484DC File Offset: 0x002466DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PoolId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PoolId);
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueScoreRewardInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
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

		// Token: 0x0600DB65 RID: 56165 RVA: 0x00248564 File Offset: 0x00246764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueScoreRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PoolId != 0U)
			{
				this.PoolId = other.PoolId;
			}
			if (other.rogueScoreRewardInfo_ != null)
			{
				if (this.rogueScoreRewardInfo_ == null)
				{
					this.RogueScoreRewardInfo = new RogueScoreRewardInfo();
				}
				this.RogueScoreRewardInfo.MergeFrom(other.RogueScoreRewardInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
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

		// Token: 0x0600DB66 RID: 56166 RVA: 0x0024860C File Offset: 0x0024680C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB67 RID: 56167 RVA: 0x00248618 File Offset: 0x00246818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 42U)
					{
						if (this.rogueScoreRewardInfo_ == null)
						{
							this.RogueScoreRewardInfo = new RogueScoreRewardInfo();
						}
						input.ReadMessage(this.RogueScoreRewardInfo);
						continue;
					}
					if (num == 50U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
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
					if (num == 96U)
					{
						this.PoolId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005752 RID: 22354
		private static readonly MessageParser<TakeRogueScoreRewardScRsp> _parser = new MessageParser<TakeRogueScoreRewardScRsp>(() => new TakeRogueScoreRewardScRsp());

		// Token: 0x04005753 RID: 22355
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005754 RID: 22356
		public const int PoolIdFieldNumber = 12;

		// Token: 0x04005755 RID: 22357
		private uint poolId_;

		// Token: 0x04005756 RID: 22358
		public const int RogueScoreRewardInfoFieldNumber = 5;

		// Token: 0x04005757 RID: 22359
		private RogueScoreRewardInfo rogueScoreRewardInfo_;

		// Token: 0x04005758 RID: 22360
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04005759 RID: 22361
		private uint retcode_;

		// Token: 0x0400575A RID: 22362
		public const int RewardFieldNumber = 6;

		// Token: 0x0400575B RID: 22363
		private ItemList reward_;
	}
}
