using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001363 RID: 4963
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TrainVisitorBehaviorFinishScRsp : IMessage<TrainVisitorBehaviorFinishScRsp>, IMessage, IEquatable<TrainVisitorBehaviorFinishScRsp>, IDeepCloneable<TrainVisitorBehaviorFinishScRsp>, IBufferMessage
	{
		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x0600DD6D RID: 56685 RVA: 0x0024D63F File Offset: 0x0024B83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrainVisitorBehaviorFinishScRsp> Parser
		{
			get
			{
				return TrainVisitorBehaviorFinishScRsp._parser;
			}
		}

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x0600DD6E RID: 56686 RVA: 0x0024D646 File Offset: 0x0024B846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TrainVisitorBehaviorFinishScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x0600DD6F RID: 56687 RVA: 0x0024D658 File Offset: 0x0024B858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrainVisitorBehaviorFinishScRsp.Descriptor;
			}
		}

		// Token: 0x0600DD70 RID: 56688 RVA: 0x0024D65F File Offset: 0x0024B85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorBehaviorFinishScRsp()
		{
		}

		// Token: 0x0600DD71 RID: 56689 RVA: 0x0024D668 File Offset: 0x0024B868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorBehaviorFinishScRsp(TrainVisitorBehaviorFinishScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.dJLKCHKMNMI_ = other.dJLKCHKMNMI_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD72 RID: 56690 RVA: 0x0024D6C0 File Offset: 0x0024B8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorBehaviorFinishScRsp Clone()
		{
			return new TrainVisitorBehaviorFinishScRsp(this);
		}

		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x0600DD73 RID: 56691 RVA: 0x0024D6C8 File Offset: 0x0024B8C8
		// (set) Token: 0x0600DD74 RID: 56692 RVA: 0x0024D6D0 File Offset: 0x0024B8D0
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

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x0600DD75 RID: 56693 RVA: 0x0024D6D9 File Offset: 0x0024B8D9
		// (set) Token: 0x0600DD76 RID: 56694 RVA: 0x0024D6E1 File Offset: 0x0024B8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DJLKCHKMNMI
		{
			get
			{
				return this.dJLKCHKMNMI_;
			}
			set
			{
				this.dJLKCHKMNMI_ = value;
			}
		}

		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x0600DD77 RID: 56695 RVA: 0x0024D6EA File Offset: 0x0024B8EA
		// (set) Token: 0x0600DD78 RID: 56696 RVA: 0x0024D6F2 File Offset: 0x0024B8F2
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

		// Token: 0x0600DD79 RID: 56697 RVA: 0x0024D6FB File Offset: 0x0024B8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrainVisitorBehaviorFinishScRsp);
		}

		// Token: 0x0600DD7A RID: 56698 RVA: 0x0024D70C File Offset: 0x0024B90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrainVisitorBehaviorFinishScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.DJLKCHKMNMI == other.DJLKCHKMNMI && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD7B RID: 56699 RVA: 0x0024D76C File Offset: 0x0024B96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.DJLKCHKMNMI != 0U)
			{
				num ^= this.DJLKCHKMNMI.GetHashCode();
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

		// Token: 0x0600DD7C RID: 56700 RVA: 0x0024D7DA File Offset: 0x0024B9DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DD7D RID: 56701 RVA: 0x0024D7E2 File Offset: 0x0024B9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD7E RID: 56702 RVA: 0x0024D7EC File Offset: 0x0024B9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DJLKCHKMNMI != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.DJLKCHKMNMI);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD7F RID: 56703 RVA: 0x0024D864 File Offset: 0x0024BA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.DJLKCHKMNMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DJLKCHKMNMI);
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

		// Token: 0x0600DD80 RID: 56704 RVA: 0x0024D8D4 File Offset: 0x0024BAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrainVisitorBehaviorFinishScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.DJLKCHKMNMI != 0U)
			{
				this.DJLKCHKMNMI = other.DJLKCHKMNMI;
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

		// Token: 0x0600DD81 RID: 56705 RVA: 0x0024D950 File Offset: 0x0024BB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD82 RID: 56706 RVA: 0x0024D95C File Offset: 0x0024BB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 74U)
					{
						if (num != 88U)
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
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
					}
				}
				else
				{
					this.DJLKCHKMNMI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400580F RID: 22543
		private static readonly MessageParser<TrainVisitorBehaviorFinishScRsp> _parser = new MessageParser<TrainVisitorBehaviorFinishScRsp>(() => new TrainVisitorBehaviorFinishScRsp());

		// Token: 0x04005810 RID: 22544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005811 RID: 22545
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04005812 RID: 22546
		private uint retcode_;

		// Token: 0x04005813 RID: 22547
		public const int DJLKCHKMNMIFieldNumber = 5;

		// Token: 0x04005814 RID: 22548
		private uint dJLKCHKMNMI_;

		// Token: 0x04005815 RID: 22549
		public const int RewardFieldNumber = 9;

		// Token: 0x04005816 RID: 22550
		private ItemList reward_;
	}
}
