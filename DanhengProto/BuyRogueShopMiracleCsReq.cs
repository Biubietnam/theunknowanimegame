using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000155 RID: 341
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BuyRogueShopMiracleCsReq : IMessage<BuyRogueShopMiracleCsReq>, IMessage, IEquatable<BuyRogueShopMiracleCsReq>, IDeepCloneable<BuyRogueShopMiracleCsReq>, IBufferMessage
	{
		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x0002CEB9 File Offset: 0x0002B0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuyRogueShopMiracleCsReq> Parser
		{
			get
			{
				return BuyRogueShopMiracleCsReq._parser;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0002CEC0 File Offset: 0x0002B0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BuyRogueShopMiracleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x0002CED2 File Offset: 0x0002B0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuyRogueShopMiracleCsReq.Descriptor;
			}
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0002CED9 File Offset: 0x0002B0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyRogueShopMiracleCsReq()
		{
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x0002CEEC File Offset: 0x0002B0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyRogueShopMiracleCsReq(BuyRogueShopMiracleCsReq other) : this()
		{
			this.buffIdList_ = other.buffIdList_.Clone();
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0002CF22 File Offset: 0x0002B122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyRogueShopMiracleCsReq Clone()
		{
			return new BuyRogueShopMiracleCsReq(this);
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x0002CF2A File Offset: 0x0002B12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BuffIdList
		{
			get
			{
				return this.buffIdList_;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0002CF32 File Offset: 0x0002B132
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x0002CF3A File Offset: 0x0002B13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0002CF43 File Offset: 0x0002B143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuyRogueShopMiracleCsReq);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0002CF54 File Offset: 0x0002B154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuyRogueShopMiracleCsReq other)
		{
			return other != null && (other == this || (this.buffIdList_.Equals(other.buffIdList_) && this.InteractedPropEntityId == other.InteractedPropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0002CFA4 File Offset: 0x0002B1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffIdList_.GetHashCode();
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0002CFF1 File Offset: 0x0002B1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0002CFF9 File Offset: 0x0002B1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0002D004 File Offset: 0x0002B204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			this.buffIdList_.WriteTo(ref output, BuyRogueShopMiracleCsReq._repeated_buffIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0002D054 File Offset: 0x0002B254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffIdList_.CalculateSize(BuyRogueShopMiracleCsReq._repeated_buffIdList_codec);
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0002D0A8 File Offset: 0x0002B2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuyRogueShopMiracleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.buffIdList_.Add(other.buffIdList_);
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0002D0F5 File Offset: 0x0002B2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0002D100 File Offset: 0x0002B300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.buffIdList_.AddEntriesFrom(ref input, BuyRogueShopMiracleCsReq._repeated_buffIdList_codec);
					}
				}
				else
				{
					this.InteractedPropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400068D RID: 1677
		private static readonly MessageParser<BuyRogueShopMiracleCsReq> _parser = new MessageParser<BuyRogueShopMiracleCsReq>(() => new BuyRogueShopMiracleCsReq());

		// Token: 0x0400068E RID: 1678
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400068F RID: 1679
		public const int BuffIdListFieldNumber = 10;

		// Token: 0x04000690 RID: 1680
		private static readonly FieldCodec<uint> _repeated_buffIdList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04000691 RID: 1681
		private readonly RepeatedField<uint> buffIdList_ = new RepeatedField<uint>();

		// Token: 0x04000692 RID: 1682
		public const int InteractedPropEntityIdFieldNumber = 7;

		// Token: 0x04000693 RID: 1683
		private uint interactedPropEntityId_;
	}
}
