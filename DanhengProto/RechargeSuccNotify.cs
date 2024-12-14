using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D87 RID: 3463
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RechargeSuccNotify : IMessage<RechargeSuccNotify>, IMessage, IEquatable<RechargeSuccNotify>, IDeepCloneable<RechargeSuccNotify>, IBufferMessage
	{
		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x06009A9E RID: 39582 RVA: 0x0019B733 File Offset: 0x00199933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RechargeSuccNotify> Parser
		{
			get
			{
				return RechargeSuccNotify._parser;
			}
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x06009A9F RID: 39583 RVA: 0x0019B73A File Offset: 0x0019993A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RechargeSuccNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x06009AA0 RID: 39584 RVA: 0x0019B74C File Offset: 0x0019994C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RechargeSuccNotify.Descriptor;
			}
		}

		// Token: 0x06009AA1 RID: 39585 RVA: 0x0019B753 File Offset: 0x00199953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RechargeSuccNotify()
		{
		}

		// Token: 0x06009AA2 RID: 39586 RVA: 0x0019B774 File Offset: 0x00199974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RechargeSuccNotify(RechargeSuccNotify other) : this()
		{
			this.productId_ = other.productId_;
			this.itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
			this.channelOrderNo_ = other.channelOrderNo_;
			this.monthCardOutdateTime_ = other.monthCardOutdateTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x0019B7D8 File Offset: 0x001999D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RechargeSuccNotify Clone()
		{
			return new RechargeSuccNotify(this);
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x06009AA4 RID: 39588 RVA: 0x0019B7E0 File Offset: 0x001999E0
		// (set) Token: 0x06009AA5 RID: 39589 RVA: 0x0019B7E8 File Offset: 0x001999E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ProductId
		{
			get
			{
				return this.productId_;
			}
			set
			{
				this.productId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x06009AA6 RID: 39590 RVA: 0x0019B7FB File Offset: 0x001999FB
		// (set) Token: 0x06009AA7 RID: 39591 RVA: 0x0019B803 File Offset: 0x00199A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ItemList
		{
			get
			{
				return this.itemList_;
			}
			set
			{
				this.itemList_ = value;
			}
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x06009AA8 RID: 39592 RVA: 0x0019B80C File Offset: 0x00199A0C
		// (set) Token: 0x06009AA9 RID: 39593 RVA: 0x0019B814 File Offset: 0x00199A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ChannelOrderNo
		{
			get
			{
				return this.channelOrderNo_;
			}
			set
			{
				this.channelOrderNo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x06009AAA RID: 39594 RVA: 0x0019B827 File Offset: 0x00199A27
		// (set) Token: 0x06009AAB RID: 39595 RVA: 0x0019B82F File Offset: 0x00199A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong MonthCardOutdateTime
		{
			get
			{
				return this.monthCardOutdateTime_;
			}
			set
			{
				this.monthCardOutdateTime_ = value;
			}
		}

		// Token: 0x06009AAC RID: 39596 RVA: 0x0019B838 File Offset: 0x00199A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RechargeSuccNotify);
		}

		// Token: 0x06009AAD RID: 39597 RVA: 0x0019B848 File Offset: 0x00199A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RechargeSuccNotify other)
		{
			return other != null && (other == this || (!(this.ProductId != other.ProductId) && object.Equals(this.ItemList, other.ItemList) && !(this.ChannelOrderNo != other.ChannelOrderNo) && this.MonthCardOutdateTime == other.MonthCardOutdateTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009AAE RID: 39598 RVA: 0x0019B8C0 File Offset: 0x00199AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ProductId.Length != 0)
			{
				num ^= this.ProductId.GetHashCode();
			}
			if (this.itemList_ != null)
			{
				num ^= this.ItemList.GetHashCode();
			}
			if (this.ChannelOrderNo.Length != 0)
			{
				num ^= this.ChannelOrderNo.GetHashCode();
			}
			if (this.MonthCardOutdateTime != 0UL)
			{
				num ^= this.MonthCardOutdateTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009AAF RID: 39599 RVA: 0x0019B94B File Offset: 0x00199B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009AB0 RID: 39600 RVA: 0x0019B953 File Offset: 0x00199B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AB1 RID: 39601 RVA: 0x0019B95C File Offset: 0x00199B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.itemList_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ItemList);
			}
			if (this.ChannelOrderNo.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ChannelOrderNo);
			}
			if (this.MonthCardOutdateTime != 0UL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.MonthCardOutdateTime);
			}
			if (this.ProductId.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.ProductId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AB2 RID: 39602 RVA: 0x0019B9F8 File Offset: 0x00199BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ProductId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ProductId);
			}
			if (this.itemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemList);
			}
			if (this.ChannelOrderNo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelOrderNo);
			}
			if (this.MonthCardOutdateTime != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.MonthCardOutdateTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009AB3 RID: 39603 RVA: 0x0019BA88 File Offset: 0x00199C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RechargeSuccNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ProductId.Length != 0)
			{
				this.ProductId = other.ProductId;
			}
			if (other.itemList_ != null)
			{
				if (this.itemList_ == null)
				{
					this.ItemList = new ItemList();
				}
				this.ItemList.MergeFrom(other.ItemList);
			}
			if (other.ChannelOrderNo.Length != 0)
			{
				this.ChannelOrderNo = other.ChannelOrderNo;
			}
			if (other.MonthCardOutdateTime != 0UL)
			{
				this.MonthCardOutdateTime = other.MonthCardOutdateTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009AB4 RID: 39604 RVA: 0x0019BB22 File Offset: 0x00199D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AB5 RID: 39605 RVA: 0x0019BB2C File Offset: 0x00199D2C
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
						if (this.itemList_ == null)
						{
							this.ItemList = new ItemList();
						}
						input.ReadMessage(this.ItemList);
						continue;
					}
					if (num == 50U)
					{
						this.ChannelOrderNo = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.MonthCardOutdateTime = input.ReadUInt64();
						continue;
					}
					if (num == 114U)
					{
						this.ProductId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C06 RID: 15366
		private static readonly MessageParser<RechargeSuccNotify> _parser = new MessageParser<RechargeSuccNotify>(() => new RechargeSuccNotify());

		// Token: 0x04003C07 RID: 15367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C08 RID: 15368
		public const int ProductIdFieldNumber = 14;

		// Token: 0x04003C09 RID: 15369
		private string productId_ = "";

		// Token: 0x04003C0A RID: 15370
		public const int ItemListFieldNumber = 5;

		// Token: 0x04003C0B RID: 15371
		private ItemList itemList_;

		// Token: 0x04003C0C RID: 15372
		public const int ChannelOrderNoFieldNumber = 6;

		// Token: 0x04003C0D RID: 15373
		private string channelOrderNo_ = "";

		// Token: 0x04003C0E RID: 15374
		public const int MonthCardOutdateTimeFieldNumber = 11;

		// Token: 0x04003C0F RID: 15375
		private ulong monthCardOutdateTime_;
	}
}
