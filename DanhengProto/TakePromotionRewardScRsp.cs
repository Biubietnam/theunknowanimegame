using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200130F RID: 4879
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakePromotionRewardScRsp : IMessage<TakePromotionRewardScRsp>, IMessage, IEquatable<TakePromotionRewardScRsp>, IDeepCloneable<TakePromotionRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x0600D9A9 RID: 55721 RVA: 0x00243E49 File Offset: 0x00242049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakePromotionRewardScRsp> Parser
		{
			get
			{
				return TakePromotionRewardScRsp._parser;
			}
		}

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x0600D9AA RID: 55722 RVA: 0x00243E50 File Offset: 0x00242050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakePromotionRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x0600D9AB RID: 55723 RVA: 0x00243E62 File Offset: 0x00242062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakePromotionRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D9AC RID: 55724 RVA: 0x00243E69 File Offset: 0x00242069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePromotionRewardScRsp()
		{
		}

		// Token: 0x0600D9AD RID: 55725 RVA: 0x00243E74 File Offset: 0x00242074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePromotionRewardScRsp(TakePromotionRewardScRsp other) : this()
		{
			this.rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9AE RID: 55726 RVA: 0x00243EC0 File Offset: 0x002420C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePromotionRewardScRsp Clone()
		{
			return new TakePromotionRewardScRsp(this);
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x0600D9AF RID: 55727 RVA: 0x00243EC8 File Offset: 0x002420C8
		// (set) Token: 0x0600D9B0 RID: 55728 RVA: 0x00243ED0 File Offset: 0x002420D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList RewardList
		{
			get
			{
				return this.rewardList_;
			}
			set
			{
				this.rewardList_ = value;
			}
		}

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x0600D9B1 RID: 55729 RVA: 0x00243ED9 File Offset: 0x002420D9
		// (set) Token: 0x0600D9B2 RID: 55730 RVA: 0x00243EE1 File Offset: 0x002420E1
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

		// Token: 0x0600D9B3 RID: 55731 RVA: 0x00243EEA File Offset: 0x002420EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakePromotionRewardScRsp);
		}

		// Token: 0x0600D9B4 RID: 55732 RVA: 0x00243EF8 File Offset: 0x002420F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakePromotionRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RewardList, other.RewardList) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9B5 RID: 55733 RVA: 0x00243F48 File Offset: 0x00242148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rewardList_ != null)
			{
				num ^= this.RewardList.GetHashCode();
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

		// Token: 0x0600D9B6 RID: 55734 RVA: 0x00243F9D File Offset: 0x0024219D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D9B7 RID: 55735 RVA: 0x00243FA5 File Offset: 0x002421A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9B8 RID: 55736 RVA: 0x00243FB0 File Offset: 0x002421B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardList_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RewardList);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D9B9 RID: 55737 RVA: 0x0024400C File Offset: 0x0024220C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rewardList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardList);
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

		// Token: 0x0600D9BA RID: 55738 RVA: 0x00244064 File Offset: 0x00242264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakePromotionRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rewardList_ != null)
			{
				if (this.rewardList_ == null)
				{
					this.RewardList = new ItemList();
				}
				this.RewardList.MergeFrom(other.RewardList);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D9BB RID: 55739 RVA: 0x002440CC File Offset: 0x002422CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9BC RID: 55740 RVA: 0x002440D8 File Offset: 0x002422D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 96U)
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
					if (this.rewardList_ == null)
					{
						this.RewardList = new ItemList();
					}
					input.ReadMessage(this.RewardList);
				}
			}
		}

		// Token: 0x040056B9 RID: 22201
		private static readonly MessageParser<TakePromotionRewardScRsp> _parser = new MessageParser<TakePromotionRewardScRsp>(() => new TakePromotionRewardScRsp());

		// Token: 0x040056BA RID: 22202
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056BB RID: 22203
		public const int RewardListFieldNumber = 1;

		// Token: 0x040056BC RID: 22204
		private ItemList rewardList_;

		// Token: 0x040056BD RID: 22205
		public const int RetcodeFieldNumber = 12;

		// Token: 0x040056BE RID: 22206
		private uint retcode_;
	}
}
