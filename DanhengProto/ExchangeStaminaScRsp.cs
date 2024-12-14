using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004E5 RID: 1253
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeStaminaScRsp : IMessage<ExchangeStaminaScRsp>, IMessage, IEquatable<ExchangeStaminaScRsp>, IDeepCloneable<ExchangeStaminaScRsp>, IBufferMessage
	{
		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06003803 RID: 14339 RVA: 0x0009965F File Offset: 0x0009785F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeStaminaScRsp> Parser
		{
			get
			{
				return ExchangeStaminaScRsp._parser;
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x00099666 File Offset: 0x00097866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExchangeStaminaScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x00099678 File Offset: 0x00097878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeStaminaScRsp.Descriptor;
			}
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x0009967F File Offset: 0x0009787F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeStaminaScRsp()
		{
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x00099694 File Offset: 0x00097894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeStaminaScRsp(ExchangeStaminaScRsp other) : this()
		{
			this.lastRecoverTime_ = other.lastRecoverTime_;
			this.staminaAdd_ = other.staminaAdd_;
			this.exchangeTimes_ = other.exchangeTimes_;
			this.itemCostList_ = other.itemCostList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x000996F9 File Offset: 0x000978F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeStaminaScRsp Clone()
		{
			return new ExchangeStaminaScRsp(this);
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x00099701 File Offset: 0x00097901
		// (set) Token: 0x0600380A RID: 14346 RVA: 0x00099709 File Offset: 0x00097909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastRecoverTime
		{
			get
			{
				return this.lastRecoverTime_;
			}
			set
			{
				this.lastRecoverTime_ = value;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x00099712 File Offset: 0x00097912
		// (set) Token: 0x0600380C RID: 14348 RVA: 0x0009971A File Offset: 0x0009791A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StaminaAdd
		{
			get
			{
				return this.staminaAdd_;
			}
			set
			{
				this.staminaAdd_ = value;
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x00099723 File Offset: 0x00097923
		// (set) Token: 0x0600380E RID: 14350 RVA: 0x0009972B File Offset: 0x0009792B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ExchangeTimes
		{
			get
			{
				return this.exchangeTimes_;
			}
			set
			{
				this.exchangeTimes_ = value;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x00099734 File Offset: 0x00097934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemCost> ItemCostList
		{
			get
			{
				return this.itemCostList_;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06003810 RID: 14352 RVA: 0x0009973C File Offset: 0x0009793C
		// (set) Token: 0x06003811 RID: 14353 RVA: 0x00099744 File Offset: 0x00097944
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

		// Token: 0x06003812 RID: 14354 RVA: 0x0009974D File Offset: 0x0009794D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeStaminaScRsp);
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x0009975C File Offset: 0x0009795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeStaminaScRsp other)
		{
			return other != null && (other == this || (this.LastRecoverTime == other.LastRecoverTime && this.StaminaAdd == other.StaminaAdd && this.ExchangeTimes == other.ExchangeTimes && this.itemCostList_.Equals(other.itemCostList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x000997DC File Offset: 0x000979DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LastRecoverTime != 0L)
			{
				num ^= this.LastRecoverTime.GetHashCode();
			}
			if (this.StaminaAdd != 0U)
			{
				num ^= this.StaminaAdd.GetHashCode();
			}
			if (this.ExchangeTimes != 0U)
			{
				num ^= this.ExchangeTimes.GetHashCode();
			}
			num ^= this.itemCostList_.GetHashCode();
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

		// Token: 0x06003815 RID: 14357 RVA: 0x00099874 File Offset: 0x00097A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x0009987C File Offset: 0x00097A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00099888 File Offset: 0x00097A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LastRecoverTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.LastRecoverTime);
			}
			this.itemCostList_.WriteTo(ref output, ExchangeStaminaScRsp._repeated_itemCostList_codec);
			if (this.ExchangeTimes != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ExchangeTimes);
			}
			if (this.StaminaAdd != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.StaminaAdd);
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

		// Token: 0x06003818 RID: 14360 RVA: 0x0009992C File Offset: 0x00097B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LastRecoverTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastRecoverTime);
			}
			if (this.StaminaAdd != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StaminaAdd);
			}
			if (this.ExchangeTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExchangeTimes);
			}
			num += this.itemCostList_.CalculateSize(ExchangeStaminaScRsp._repeated_itemCostList_codec);
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

		// Token: 0x06003819 RID: 14361 RVA: 0x000999C8 File Offset: 0x00097BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeStaminaScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LastRecoverTime != 0L)
			{
				this.LastRecoverTime = other.LastRecoverTime;
			}
			if (other.StaminaAdd != 0U)
			{
				this.StaminaAdd = other.StaminaAdd;
			}
			if (other.ExchangeTimes != 0U)
			{
				this.ExchangeTimes = other.ExchangeTimes;
			}
			this.itemCostList_.Add(other.itemCostList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x00099A51 File Offset: 0x00097C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x00099A5C File Offset: 0x00097C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.LastRecoverTime = input.ReadInt64();
						continue;
					}
					if (num == 26U)
					{
						this.itemCostList_.AddEntriesFrom(ref input, ExchangeStaminaScRsp._repeated_itemCostList_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ExchangeTimes = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.StaminaAdd = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001622 RID: 5666
		private static readonly MessageParser<ExchangeStaminaScRsp> _parser = new MessageParser<ExchangeStaminaScRsp>(() => new ExchangeStaminaScRsp());

		// Token: 0x04001623 RID: 5667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001624 RID: 5668
		public const int LastRecoverTimeFieldNumber = 1;

		// Token: 0x04001625 RID: 5669
		private long lastRecoverTime_;

		// Token: 0x04001626 RID: 5670
		public const int StaminaAddFieldNumber = 8;

		// Token: 0x04001627 RID: 5671
		private uint staminaAdd_;

		// Token: 0x04001628 RID: 5672
		public const int ExchangeTimesFieldNumber = 7;

		// Token: 0x04001629 RID: 5673
		private uint exchangeTimes_;

		// Token: 0x0400162A RID: 5674
		public const int ItemCostListFieldNumber = 3;

		// Token: 0x0400162B RID: 5675
		private static readonly FieldCodec<ItemCost> _repeated_itemCostList_codec = FieldCodec.ForMessage<ItemCost>(26U, ItemCost.Parser);

		// Token: 0x0400162C RID: 5676
		private readonly RepeatedField<ItemCost> itemCostList_ = new RepeatedField<ItemCost>();

		// Token: 0x0400162D RID: 5677
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400162E RID: 5678
		private uint retcode_;
	}
}
