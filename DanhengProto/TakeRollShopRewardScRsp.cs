using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001337 RID: 4919
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRollShopRewardScRsp : IMessage<TakeRollShopRewardScRsp>, IMessage, IEquatable<TakeRollShopRewardScRsp>, IDeepCloneable<TakeRollShopRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x0600DB80 RID: 56192 RVA: 0x00248A03 File Offset: 0x00246C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRollShopRewardScRsp> Parser
		{
			get
			{
				return TakeRollShopRewardScRsp._parser;
			}
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x0600DB81 RID: 56193 RVA: 0x00248A0A File Offset: 0x00246C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRollShopRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x0600DB82 RID: 56194 RVA: 0x00248A1C File Offset: 0x00246C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRollShopRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DB83 RID: 56195 RVA: 0x00248A23 File Offset: 0x00246C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRollShopRewardScRsp()
		{
		}

		// Token: 0x0600DB84 RID: 56196 RVA: 0x00248A2C File Offset: 0x00246C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRollShopRewardScRsp(TakeRollShopRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rollShopId_ = other.rollShopId_;
			this.groupType_ = other.groupType_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB85 RID: 56197 RVA: 0x00248A90 File Offset: 0x00246C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRollShopRewardScRsp Clone()
		{
			return new TakeRollShopRewardScRsp(this);
		}

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x0600DB86 RID: 56198 RVA: 0x00248A98 File Offset: 0x00246C98
		// (set) Token: 0x0600DB87 RID: 56199 RVA: 0x00248AA0 File Offset: 0x00246CA0
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

		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x0600DB88 RID: 56200 RVA: 0x00248AA9 File Offset: 0x00246CA9
		// (set) Token: 0x0600DB89 RID: 56201 RVA: 0x00248AB1 File Offset: 0x00246CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollShopId
		{
			get
			{
				return this.rollShopId_;
			}
			set
			{
				this.rollShopId_ = value;
			}
		}

		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x0600DB8A RID: 56202 RVA: 0x00248ABA File Offset: 0x00246CBA
		// (set) Token: 0x0600DB8B RID: 56203 RVA: 0x00248AC2 File Offset: 0x00246CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupType
		{
			get
			{
				return this.groupType_;
			}
			set
			{
				this.groupType_ = value;
			}
		}

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x0600DB8C RID: 56204 RVA: 0x00248ACB File Offset: 0x00246CCB
		// (set) Token: 0x0600DB8D RID: 56205 RVA: 0x00248AD3 File Offset: 0x00246CD3
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

		// Token: 0x0600DB8E RID: 56206 RVA: 0x00248ADC File Offset: 0x00246CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRollShopRewardScRsp);
		}

		// Token: 0x0600DB8F RID: 56207 RVA: 0x00248AEC File Offset: 0x00246CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRollShopRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.RollShopId == other.RollShopId && this.GroupType == other.GroupType && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB90 RID: 56208 RVA: 0x00248B5C File Offset: 0x00246D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.RollShopId != 0U)
			{
				num ^= this.RollShopId.GetHashCode();
			}
			if (this.GroupType != 0U)
			{
				num ^= this.GroupType.GetHashCode();
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

		// Token: 0x0600DB91 RID: 56209 RVA: 0x00248BE3 File Offset: 0x00246DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DB92 RID: 56210 RVA: 0x00248BEB File Offset: 0x00246DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB93 RID: 56211 RVA: 0x00248BF4 File Offset: 0x00246DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RollShopId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RollShopId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Reward);
			}
			if (this.GroupType != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GroupType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB94 RID: 56212 RVA: 0x00248C84 File Offset: 0x00246E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.RollShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollShopId);
			}
			if (this.GroupType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupType);
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

		// Token: 0x0600DB95 RID: 56213 RVA: 0x00248D0C File Offset: 0x00246F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRollShopRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.RollShopId != 0U)
			{
				this.RollShopId = other.RollShopId;
			}
			if (other.GroupType != 0U)
			{
				this.GroupType = other.GroupType;
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

		// Token: 0x0600DB96 RID: 56214 RVA: 0x00248D9C File Offset: 0x00246F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB97 RID: 56215 RVA: 0x00248DA8 File Offset: 0x00246FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.RollShopId = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 88U)
					{
						this.GroupType = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005762 RID: 22370
		private static readonly MessageParser<TakeRollShopRewardScRsp> _parser = new MessageParser<TakeRollShopRewardScRsp>(() => new TakeRollShopRewardScRsp());

		// Token: 0x04005763 RID: 22371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005764 RID: 22372
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04005765 RID: 22373
		private uint retcode_;

		// Token: 0x04005766 RID: 22374
		public const int RollShopIdFieldNumber = 1;

		// Token: 0x04005767 RID: 22375
		private uint rollShopId_;

		// Token: 0x04005768 RID: 22376
		public const int GroupTypeFieldNumber = 11;

		// Token: 0x04005769 RID: 22377
		private uint groupType_;

		// Token: 0x0400576A RID: 22378
		public const int RewardFieldNumber = 8;

		// Token: 0x0400576B RID: 22379
		private ItemList reward_;
	}
}
