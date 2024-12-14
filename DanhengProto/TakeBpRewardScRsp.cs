using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012C1 RID: 4801
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeBpRewardScRsp : IMessage<TakeBpRewardScRsp>, IMessage, IEquatable<TakeBpRewardScRsp>, IDeepCloneable<TakeBpRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x0600D625 RID: 54821 RVA: 0x0023B51D File Offset: 0x0023971D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeBpRewardScRsp> Parser
		{
			get
			{
				return TakeBpRewardScRsp._parser;
			}
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x0600D626 RID: 54822 RVA: 0x0023B524 File Offset: 0x00239724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeBpRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x0600D627 RID: 54823 RVA: 0x0023B536 File Offset: 0x00239736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeBpRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D628 RID: 54824 RVA: 0x0023B53D File Offset: 0x0023973D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeBpRewardScRsp()
		{
		}

		// Token: 0x0600D629 RID: 54825 RVA: 0x0023B548 File Offset: 0x00239748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeBpRewardScRsp(TakeBpRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D62A RID: 54826 RVA: 0x0023B594 File Offset: 0x00239794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeBpRewardScRsp Clone()
		{
			return new TakeBpRewardScRsp(this);
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x0600D62B RID: 54827 RVA: 0x0023B59C File Offset: 0x0023979C
		// (set) Token: 0x0600D62C RID: 54828 RVA: 0x0023B5A4 File Offset: 0x002397A4
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

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x0600D62D RID: 54829 RVA: 0x0023B5AD File Offset: 0x002397AD
		// (set) Token: 0x0600D62E RID: 54830 RVA: 0x0023B5B5 File Offset: 0x002397B5
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

		// Token: 0x0600D62F RID: 54831 RVA: 0x0023B5BE File Offset: 0x002397BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeBpRewardScRsp);
		}

		// Token: 0x0600D630 RID: 54832 RVA: 0x0023B5CC File Offset: 0x002397CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeBpRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D631 RID: 54833 RVA: 0x0023B61C File Offset: 0x0023981C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600D632 RID: 54834 RVA: 0x0023B671 File Offset: 0x00239871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D633 RID: 54835 RVA: 0x0023B679 File Offset: 0x00239879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D634 RID: 54836 RVA: 0x0023B684 File Offset: 0x00239884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D635 RID: 54837 RVA: 0x0023B6E0 File Offset: 0x002398E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600D636 RID: 54838 RVA: 0x0023B738 File Offset: 0x00239938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeBpRewardScRsp other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0600D637 RID: 54839 RVA: 0x0023B7A0 File Offset: 0x002399A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D638 RID: 54840 RVA: 0x0023B7AC File Offset: 0x002399AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 114U)
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
		}

		// Token: 0x0400558B RID: 21899
		private static readonly MessageParser<TakeBpRewardScRsp> _parser = new MessageParser<TakeBpRewardScRsp>(() => new TakeBpRewardScRsp());

		// Token: 0x0400558C RID: 21900
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400558D RID: 21901
		public const int RetcodeFieldNumber = 10;

		// Token: 0x0400558E RID: 21902
		private uint retcode_;

		// Token: 0x0400558F RID: 21903
		public const int RewardFieldNumber = 14;

		// Token: 0x04005590 RID: 21904
		private ItemList reward_;
	}
}
