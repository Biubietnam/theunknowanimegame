using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001023 RID: 4131
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournTakeExpRewardScRsp : IMessage<RogueTournTakeExpRewardScRsp>, IMessage, IEquatable<RogueTournTakeExpRewardScRsp>, IDeepCloneable<RogueTournTakeExpRewardScRsp>, IBufferMessage
	{
		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600B7B3 RID: 47027 RVA: 0x001ECE93 File Offset: 0x001EB093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournTakeExpRewardScRsp> Parser
		{
			get
			{
				return RogueTournTakeExpRewardScRsp._parser;
			}
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600B7B4 RID: 47028 RVA: 0x001ECE9A File Offset: 0x001EB09A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournTakeExpRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600B7B5 RID: 47029 RVA: 0x001ECEAC File Offset: 0x001EB0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournTakeExpRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600B7B6 RID: 47030 RVA: 0x001ECEB3 File Offset: 0x001EB0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournTakeExpRewardScRsp()
		{
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x001ECEC8 File Offset: 0x001EB0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournTakeExpRewardScRsp(RogueTournTakeExpRewardScRsp other) : this()
		{
			this.exp_ = other.exp_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.takenLevelRewards_ = other.takenLevelRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7B8 RID: 47032 RVA: 0x001ECF31 File Offset: 0x001EB131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournTakeExpRewardScRsp Clone()
		{
			return new RogueTournTakeExpRewardScRsp(this);
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600B7B9 RID: 47033 RVA: 0x001ECF39 File Offset: 0x001EB139
		// (set) Token: 0x0600B7BA RID: 47034 RVA: 0x001ECF41 File Offset: 0x001EB141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600B7BB RID: 47035 RVA: 0x001ECF4A File Offset: 0x001EB14A
		// (set) Token: 0x0600B7BC RID: 47036 RVA: 0x001ECF52 File Offset: 0x001EB152
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

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600B7BD RID: 47037 RVA: 0x001ECF5B File Offset: 0x001EB15B
		// (set) Token: 0x0600B7BE RID: 47038 RVA: 0x001ECF63 File Offset: 0x001EB163
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

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600B7BF RID: 47039 RVA: 0x001ECF6C File Offset: 0x001EB16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TakenLevelRewards
		{
			get
			{
				return this.takenLevelRewards_;
			}
		}

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x001ECF74 File Offset: 0x001EB174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournTakeExpRewardScRsp);
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x001ECF84 File Offset: 0x001EB184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournTakeExpRewardScRsp other)
		{
			return other != null && (other == this || (this.Exp == other.Exp && object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && this.takenLevelRewards_.Equals(other.takenLevelRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7C2 RID: 47042 RVA: 0x001ECFF8 File Offset: 0x001EB1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.takenLevelRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x001ED074 File Offset: 0x001EB274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x001ED07C File Offset: 0x001EB27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x001ED088 File Offset: 0x001EB288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.takenLevelRewards_.WriteTo(ref output, RogueTournTakeExpRewardScRsp._repeated_takenLevelRewards_codec);
			if (this.reward_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Exp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x001ED110 File Offset: 0x001EB310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.takenLevelRewards_.CalculateSize(RogueTournTakeExpRewardScRsp._repeated_takenLevelRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x001ED194 File Offset: 0x001EB394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournTakeExpRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.takenLevelRewards_.Add(other.takenLevelRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x001ED221 File Offset: 0x001EB421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7C9 RID: 47049 RVA: 0x001ED22C File Offset: 0x001EB42C
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
						this.takenLevelRewards_.AddEntriesFrom(ref input, RogueTournTakeExpRewardScRsp._repeated_takenLevelRewards_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 72U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A6B RID: 19051
		private static readonly MessageParser<RogueTournTakeExpRewardScRsp> _parser = new MessageParser<RogueTournTakeExpRewardScRsp>(() => new RogueTournTakeExpRewardScRsp());

		// Token: 0x04004A6C RID: 19052
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A6D RID: 19053
		public const int ExpFieldNumber = 15;

		// Token: 0x04004A6E RID: 19054
		private uint exp_;

		// Token: 0x04004A6F RID: 19055
		public const int RewardFieldNumber = 4;

		// Token: 0x04004A70 RID: 19056
		private ItemList reward_;

		// Token: 0x04004A71 RID: 19057
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04004A72 RID: 19058
		private uint retcode_;

		// Token: 0x04004A73 RID: 19059
		public const int TakenLevelRewardsFieldNumber = 2;

		// Token: 0x04004A74 RID: 19060
		private static readonly FieldCodec<uint> _repeated_takenLevelRewards_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04004A75 RID: 19061
		private readonly RepeatedField<uint> takenLevelRewards_ = new RepeatedField<uint>();
	}
}
