using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012B9 RID: 4793
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeApRewardScRsp : IMessage<TakeApRewardScRsp>, IMessage, IEquatable<TakeApRewardScRsp>, IDeepCloneable<TakeApRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x0600D5C8 RID: 54728 RVA: 0x0023A6CD File Offset: 0x002388CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeApRewardScRsp> Parser
		{
			get
			{
				return TakeApRewardScRsp._parser;
			}
		}

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x0600D5C9 RID: 54729 RVA: 0x0023A6D4 File Offset: 0x002388D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeApRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x0600D5CA RID: 54730 RVA: 0x0023A6E6 File Offset: 0x002388E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeApRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D5CB RID: 54731 RVA: 0x0023A6ED File Offset: 0x002388ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeApRewardScRsp()
		{
		}

		// Token: 0x0600D5CC RID: 54732 RVA: 0x0023A6F8 File Offset: 0x002388F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeApRewardScRsp(TakeApRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5CD RID: 54733 RVA: 0x0023A750 File Offset: 0x00238950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeApRewardScRsp Clone()
		{
			return new TakeApRewardScRsp(this);
		}

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x0600D5CE RID: 54734 RVA: 0x0023A758 File Offset: 0x00238958
		// (set) Token: 0x0600D5CF RID: 54735 RVA: 0x0023A760 File Offset: 0x00238960
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

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x0600D5D0 RID: 54736 RVA: 0x0023A769 File Offset: 0x00238969
		// (set) Token: 0x0600D5D1 RID: 54737 RVA: 0x0023A771 File Offset: 0x00238971
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

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x0600D5D2 RID: 54738 RVA: 0x0023A77A File Offset: 0x0023897A
		// (set) Token: 0x0600D5D3 RID: 54739 RVA: 0x0023A782 File Offset: 0x00238982
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

		// Token: 0x0600D5D4 RID: 54740 RVA: 0x0023A78B File Offset: 0x0023898B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeApRewardScRsp);
		}

		// Token: 0x0600D5D5 RID: 54741 RVA: 0x0023A79C File Offset: 0x0023899C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeApRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5D6 RID: 54742 RVA: 0x0023A7FC File Offset: 0x002389FC
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
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D5D7 RID: 54743 RVA: 0x0023A86A File Offset: 0x00238A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D5D8 RID: 54744 RVA: 0x0023A872 File Offset: 0x00238A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5D9 RID: 54745 RVA: 0x0023A87C File Offset: 0x00238A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Level);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5DA RID: 54746 RVA: 0x0023A8F4 File Offset: 0x00238AF4
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
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D5DB RID: 54747 RVA: 0x0023A964 File Offset: 0x00238B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeApRewardScRsp other)
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
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D5DC RID: 54748 RVA: 0x0023A9E0 File Offset: 0x00238BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5DD RID: 54749 RVA: 0x0023A9EC File Offset: 0x00238BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 72U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400556C RID: 21868
		private static readonly MessageParser<TakeApRewardScRsp> _parser = new MessageParser<TakeApRewardScRsp>(() => new TakeApRewardScRsp());

		// Token: 0x0400556D RID: 21869
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400556E RID: 21870
		public const int RewardFieldNumber = 11;

		// Token: 0x0400556F RID: 21871
		private ItemList reward_;

		// Token: 0x04005570 RID: 21872
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04005571 RID: 21873
		private uint retcode_;

		// Token: 0x04005572 RID: 21874
		public const int LevelFieldNumber = 6;

		// Token: 0x04005573 RID: 21875
		private uint level_;
	}
}
