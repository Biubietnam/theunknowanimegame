using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200127D RID: 4733
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueAeonLevelUpRewardScNotify : IMessage<SyncRogueAeonLevelUpRewardScNotify>, IMessage, IEquatable<SyncRogueAeonLevelUpRewardScNotify>, IDeepCloneable<SyncRogueAeonLevelUpRewardScNotify>, IBufferMessage
	{
		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x0600D32A RID: 54058 RVA: 0x00234087 File Offset: 0x00232287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueAeonLevelUpRewardScNotify> Parser
		{
			get
			{
				return SyncRogueAeonLevelUpRewardScNotify._parser;
			}
		}

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x0600D32B RID: 54059 RVA: 0x0023408E File Offset: 0x0023228E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueAeonLevelUpRewardScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x0600D32C RID: 54060 RVA: 0x002340A0 File Offset: 0x002322A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueAeonLevelUpRewardScNotify.Descriptor;
			}
		}

		// Token: 0x0600D32D RID: 54061 RVA: 0x002340A7 File Offset: 0x002322A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAeonLevelUpRewardScNotify()
		{
		}

		// Token: 0x0600D32E RID: 54062 RVA: 0x002340B0 File Offset: 0x002322B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAeonLevelUpRewardScNotify(SyncRogueAeonLevelUpRewardScNotify other) : this()
		{
			this.level_ = other.level_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.aeonId_ = other.aeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D32F RID: 54063 RVA: 0x00234108 File Offset: 0x00232308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAeonLevelUpRewardScNotify Clone()
		{
			return new SyncRogueAeonLevelUpRewardScNotify(this);
		}

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x0600D330 RID: 54064 RVA: 0x00234110 File Offset: 0x00232310
		// (set) Token: 0x0600D331 RID: 54065 RVA: 0x00234118 File Offset: 0x00232318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x0600D332 RID: 54066 RVA: 0x00234121 File Offset: 0x00232321
		// (set) Token: 0x0600D333 RID: 54067 RVA: 0x00234129 File Offset: 0x00232329
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

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x0600D334 RID: 54068 RVA: 0x00234132 File Offset: 0x00232332
		// (set) Token: 0x0600D335 RID: 54069 RVA: 0x0023413A File Offset: 0x0023233A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x0600D336 RID: 54070 RVA: 0x00234143 File Offset: 0x00232343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueAeonLevelUpRewardScNotify);
		}

		// Token: 0x0600D337 RID: 54071 RVA: 0x00234154 File Offset: 0x00232354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueAeonLevelUpRewardScNotify other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this.Reward, other.Reward) && this.AeonId == other.AeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D338 RID: 54072 RVA: 0x002341B4 File Offset: 0x002323B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D339 RID: 54073 RVA: 0x00234222 File Offset: 0x00232422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D33A RID: 54074 RVA: 0x0023422A File Offset: 0x0023242A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D33B RID: 54075 RVA: 0x00234234 File Offset: 0x00232434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Reward);
			}
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.AeonId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D33C RID: 54076 RVA: 0x002342AC File Offset: 0x002324AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D33D RID: 54077 RVA: 0x0023431C File Offset: 0x0023251C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueAeonLevelUpRewardScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D33E RID: 54078 RVA: 0x00234398 File Offset: 0x00232598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D33F RID: 54079 RVA: 0x002343A4 File Offset: 0x002325A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					if (num != 96U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Level = input.ReadUInt32();
						}
					}
					else
					{
						this.AeonId = input.ReadUInt32();
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

		// Token: 0x04005492 RID: 21650
		private static readonly MessageParser<SyncRogueAeonLevelUpRewardScNotify> _parser = new MessageParser<SyncRogueAeonLevelUpRewardScNotify>(() => new SyncRogueAeonLevelUpRewardScNotify());

		// Token: 0x04005493 RID: 21651
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005494 RID: 21652
		public const int LevelFieldNumber = 13;

		// Token: 0x04005495 RID: 21653
		private uint level_;

		// Token: 0x04005496 RID: 21654
		public const int RewardFieldNumber = 11;

		// Token: 0x04005497 RID: 21655
		private ItemList reward_;

		// Token: 0x04005498 RID: 21656
		public const int AeonIdFieldNumber = 12;

		// Token: 0x04005499 RID: 21657
		private uint aeonId_;
	}
}
