using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012B5 RID: 4789
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeAllRewardScRsp : IMessage<TakeAllRewardScRsp>, IMessage, IEquatable<TakeAllRewardScRsp>, IDeepCloneable<TakeAllRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x0600D59C RID: 54684 RVA: 0x0023A0BD File Offset: 0x002382BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeAllRewardScRsp> Parser
		{
			get
			{
				return TakeAllRewardScRsp._parser;
			}
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x0600D59D RID: 54685 RVA: 0x0023A0C4 File Offset: 0x002382C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeAllRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0600D59E RID: 54686 RVA: 0x0023A0D6 File Offset: 0x002382D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeAllRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D59F RID: 54687 RVA: 0x0023A0DD File Offset: 0x002382DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllRewardScRsp()
		{
		}

		// Token: 0x0600D5A0 RID: 54688 RVA: 0x0023A0E8 File Offset: 0x002382E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllRewardScRsp(TakeAllRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5A1 RID: 54689 RVA: 0x0023A134 File Offset: 0x00238334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllRewardScRsp Clone()
		{
			return new TakeAllRewardScRsp(this);
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x0600D5A2 RID: 54690 RVA: 0x0023A13C File Offset: 0x0023833C
		// (set) Token: 0x0600D5A3 RID: 54691 RVA: 0x0023A144 File Offset: 0x00238344
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

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x0600D5A4 RID: 54692 RVA: 0x0023A14D File Offset: 0x0023834D
		// (set) Token: 0x0600D5A5 RID: 54693 RVA: 0x0023A155 File Offset: 0x00238355
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

		// Token: 0x0600D5A6 RID: 54694 RVA: 0x0023A15E File Offset: 0x0023835E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeAllRewardScRsp);
		}

		// Token: 0x0600D5A7 RID: 54695 RVA: 0x0023A16C File Offset: 0x0023836C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeAllRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5A8 RID: 54696 RVA: 0x0023A1BC File Offset: 0x002383BC
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D5A9 RID: 54697 RVA: 0x0023A211 File Offset: 0x00238411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D5AA RID: 54698 RVA: 0x0023A219 File Offset: 0x00238419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5AB RID: 54699 RVA: 0x0023A224 File Offset: 0x00238424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5AC RID: 54700 RVA: 0x0023A280 File Offset: 0x00238480
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D5AD RID: 54701 RVA: 0x0023A2D8 File Offset: 0x002384D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeAllRewardScRsp other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D5AE RID: 54702 RVA: 0x0023A340 File Offset: 0x00238540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5AF RID: 54703 RVA: 0x0023A34C File Offset: 0x0023854C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					if (num != 104U)
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

		// Token: 0x04005560 RID: 21856
		private static readonly MessageParser<TakeAllRewardScRsp> _parser = new MessageParser<TakeAllRewardScRsp>(() => new TakeAllRewardScRsp());

		// Token: 0x04005561 RID: 21857
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005562 RID: 21858
		public const int RewardFieldNumber = 11;

		// Token: 0x04005563 RID: 21859
		private ItemList reward_;

		// Token: 0x04005564 RID: 21860
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04005565 RID: 21861
		private uint retcode_;
	}
}
