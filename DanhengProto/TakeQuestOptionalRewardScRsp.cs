using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001317 RID: 4887
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeQuestOptionalRewardScRsp : IMessage<TakeQuestOptionalRewardScRsp>, IMessage, IEquatable<TakeQuestOptionalRewardScRsp>, IDeepCloneable<TakeQuestOptionalRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x0600DA09 RID: 55817 RVA: 0x00244D67 File Offset: 0x00242F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeQuestOptionalRewardScRsp> Parser
		{
			get
			{
				return TakeQuestOptionalRewardScRsp._parser;
			}
		}

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x0600DA0A RID: 55818 RVA: 0x00244D6E File Offset: 0x00242F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeQuestOptionalRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x0600DA0B RID: 55819 RVA: 0x00244D80 File Offset: 0x00242F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeQuestOptionalRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DA0C RID: 55820 RVA: 0x00244D87 File Offset: 0x00242F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestOptionalRewardScRsp()
		{
		}

		// Token: 0x0600DA0D RID: 55821 RVA: 0x00244D90 File Offset: 0x00242F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestOptionalRewardScRsp(TakeQuestOptionalRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA0E RID: 55822 RVA: 0x00244DE8 File Offset: 0x00242FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestOptionalRewardScRsp Clone()
		{
			return new TakeQuestOptionalRewardScRsp(this);
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x0600DA0F RID: 55823 RVA: 0x00244DF0 File Offset: 0x00242FF0
		// (set) Token: 0x0600DA10 RID: 55824 RVA: 0x00244DF8 File Offset: 0x00242FF8
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

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x0600DA11 RID: 55825 RVA: 0x00244E01 File Offset: 0x00243001
		// (set) Token: 0x0600DA12 RID: 55826 RVA: 0x00244E09 File Offset: 0x00243009
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

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x0600DA13 RID: 55827 RVA: 0x00244E12 File Offset: 0x00243012
		// (set) Token: 0x0600DA14 RID: 55828 RVA: 0x00244E1A File Offset: 0x0024301A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x0600DA15 RID: 55829 RVA: 0x00244E23 File Offset: 0x00243023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeQuestOptionalRewardScRsp);
		}

		// Token: 0x0600DA16 RID: 55830 RVA: 0x00244E34 File Offset: 0x00243034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeQuestOptionalRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA17 RID: 55831 RVA: 0x00244E94 File Offset: 0x00243094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.QuestId != 0U)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA18 RID: 55832 RVA: 0x00244F02 File Offset: 0x00243102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DA19 RID: 55833 RVA: 0x00244F0A File Offset: 0x0024310A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA1A RID: 55834 RVA: 0x00244F14 File Offset: 0x00243114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Reward);
			}
			if (this.QuestId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA1B RID: 55835 RVA: 0x00244F88 File Offset: 0x00243188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.QuestId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA1C RID: 55836 RVA: 0x00244FF8 File Offset: 0x002431F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeQuestOptionalRewardScRsp other)
		{
			if (other == null)
			{
				return;
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
			if (other.QuestId != 0U)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA1D RID: 55837 RVA: 0x00245074 File Offset: 0x00243274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA1E RID: 55838 RVA: 0x00245080 File Offset: 0x00243280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 114U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.QuestId = input.ReadUInt32();
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
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040056D9 RID: 22233
		private static readonly MessageParser<TakeQuestOptionalRewardScRsp> _parser = new MessageParser<TakeQuestOptionalRewardScRsp>(() => new TakeQuestOptionalRewardScRsp());

		// Token: 0x040056DA RID: 22234
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056DB RID: 22235
		public const int RewardFieldNumber = 14;

		// Token: 0x040056DC RID: 22236
		private ItemList reward_;

		// Token: 0x040056DD RID: 22237
		public const int RetcodeFieldNumber = 1;

		// Token: 0x040056DE RID: 22238
		private uint retcode_;

		// Token: 0x040056DF RID: 22239
		public const int QuestIdFieldNumber = 15;

		// Token: 0x040056E0 RID: 22240
		private uint questId_;
	}
}
