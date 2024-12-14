using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200009B RID: 155
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyTakeEventRewardScRsp : IMessage<AlleyTakeEventRewardScRsp>, IMessage, IEquatable<AlleyTakeEventRewardScRsp>, IDeepCloneable<AlleyTakeEventRewardScRsp>, IBufferMessage
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00012AD9 File Offset: 0x00010CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyTakeEventRewardScRsp> Parser
		{
			get
			{
				return AlleyTakeEventRewardScRsp._parser;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00012AE0 File Offset: 0x00010CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyTakeEventRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00012AF2 File Offset: 0x00010CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyTakeEventRewardScRsp.Descriptor;
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00012AF9 File Offset: 0x00010CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyTakeEventRewardScRsp()
		{
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00012B04 File Offset: 0x00010D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyTakeEventRewardScRsp(AlleyTakeEventRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00012B50 File Offset: 0x00010D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyTakeEventRewardScRsp Clone()
		{
			return new AlleyTakeEventRewardScRsp(this);
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00012B58 File Offset: 0x00010D58
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00012B60 File Offset: 0x00010D60
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

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00012B69 File Offset: 0x00010D69
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00012B71 File Offset: 0x00010D71
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

		// Token: 0x0600069D RID: 1693 RVA: 0x00012B7A File Offset: 0x00010D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyTakeEventRewardScRsp);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00012B88 File Offset: 0x00010D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyTakeEventRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00012BD8 File Offset: 0x00010DD8
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

		// Token: 0x060006A0 RID: 1696 RVA: 0x00012C2D File Offset: 0x00010E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00012C35 File Offset: 0x00010E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00012C40 File Offset: 0x00010E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00012C9C File Offset: 0x00010E9C
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

		// Token: 0x060006A4 RID: 1700 RVA: 0x00012CF4 File Offset: 0x00010EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyTakeEventRewardScRsp other)
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

		// Token: 0x060006A5 RID: 1701 RVA: 0x00012D5C File Offset: 0x00010F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00012D68 File Offset: 0x00010F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					if (num != 112U)
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
		}

		// Token: 0x04000270 RID: 624
		private static readonly MessageParser<AlleyTakeEventRewardScRsp> _parser = new MessageParser<AlleyTakeEventRewardScRsp>(() => new AlleyTakeEventRewardScRsp());

		// Token: 0x04000271 RID: 625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000272 RID: 626
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04000273 RID: 627
		private uint retcode_;

		// Token: 0x04000274 RID: 628
		public const int RewardFieldNumber = 8;

		// Token: 0x04000275 RID: 629
		private ItemList reward_;
	}
}
