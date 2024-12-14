using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000589 RID: 1417
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishPerformSectionIdScRsp : IMessage<FinishPerformSectionIdScRsp>, IMessage, IEquatable<FinishPerformSectionIdScRsp>, IDeepCloneable<FinishPerformSectionIdScRsp>, IBufferMessage
	{
		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06003F3B RID: 16187 RVA: 0x000AC9C7 File Offset: 0x000AABC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishPerformSectionIdScRsp> Parser
		{
			get
			{
				return FinishPerformSectionIdScRsp._parser;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x06003F3C RID: 16188 RVA: 0x000AC9CE File Offset: 0x000AABCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishPerformSectionIdScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06003F3D RID: 16189 RVA: 0x000AC9E0 File Offset: 0x000AABE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishPerformSectionIdScRsp.Descriptor;
			}
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x000AC9E7 File Offset: 0x000AABE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPerformSectionIdScRsp()
		{
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x000AC9FC File Offset: 0x000AABFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPerformSectionIdScRsp(FinishPerformSectionIdScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.itemList_ = other.itemList_.Clone();
			this.retcode_ = other.retcode_;
			this.sectionId_ = other.sectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x000ACA65 File Offset: 0x000AAC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPerformSectionIdScRsp Clone()
		{
			return new FinishPerformSectionIdScRsp(this);
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06003F41 RID: 16193 RVA: 0x000ACA6D File Offset: 0x000AAC6D
		// (set) Token: 0x06003F42 RID: 16194 RVA: 0x000ACA75 File Offset: 0x000AAC75
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

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06003F43 RID: 16195 RVA: 0x000ACA7E File Offset: 0x000AAC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MessageItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x000ACA86 File Offset: 0x000AAC86
		// (set) Token: 0x06003F45 RID: 16197 RVA: 0x000ACA8E File Offset: 0x000AAC8E
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

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06003F46 RID: 16198 RVA: 0x000ACA97 File Offset: 0x000AAC97
		// (set) Token: 0x06003F47 RID: 16199 RVA: 0x000ACA9F File Offset: 0x000AAC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SectionId
		{
			get
			{
				return this.sectionId_;
			}
			set
			{
				this.sectionId_ = value;
			}
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x000ACAA8 File Offset: 0x000AACA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishPerformSectionIdScRsp);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x000ACAB8 File Offset: 0x000AACB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishPerformSectionIdScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.itemList_.Equals(other.itemList_) && this.Retcode == other.Retcode && this.SectionId == other.SectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x000ACB2C File Offset: 0x000AAD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			num ^= this.itemList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.SectionId != 0U)
			{
				num ^= this.SectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x000ACBA8 File Offset: 0x000AADA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x000ACBB0 File Offset: 0x000AADB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x000ACBBC File Offset: 0x000AADBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Reward);
			}
			this.itemList_.WriteTo(ref output, FinishPerformSectionIdScRsp._repeated_itemList_codec);
			if (this.SectionId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.SectionId);
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

		// Token: 0x06003F4E RID: 16206 RVA: 0x000ACC44 File Offset: 0x000AAE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			num += this.itemList_.CalculateSize(FinishPerformSectionIdScRsp._repeated_itemList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.SectionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x000ACCC8 File Offset: 0x000AAEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishPerformSectionIdScRsp other)
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
			this.itemList_.Add(other.itemList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.SectionId != 0U)
			{
				this.SectionId = other.SectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x000ACD55 File Offset: 0x000AAF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x000ACD60 File Offset: 0x000AAF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 90U)
				{
					if (num == 34U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 90U)
					{
						this.itemList_.AddEntriesFrom(ref input, FinishPerformSectionIdScRsp._repeated_itemList_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.SectionId = input.ReadUInt32();
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

		// Token: 0x0400192E RID: 6446
		private static readonly MessageParser<FinishPerformSectionIdScRsp> _parser = new MessageParser<FinishPerformSectionIdScRsp>(() => new FinishPerformSectionIdScRsp());

		// Token: 0x0400192F RID: 6447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001930 RID: 6448
		public const int RewardFieldNumber = 4;

		// Token: 0x04001931 RID: 6449
		private ItemList reward_;

		// Token: 0x04001932 RID: 6450
		public const int ItemListFieldNumber = 11;

		// Token: 0x04001933 RID: 6451
		private static readonly FieldCodec<MessageItem> _repeated_itemList_codec = FieldCodec.ForMessage<MessageItem>(90U, MessageItem.Parser);

		// Token: 0x04001934 RID: 6452
		private readonly RepeatedField<MessageItem> itemList_ = new RepeatedField<MessageItem>();

		// Token: 0x04001935 RID: 6453
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04001936 RID: 6454
		private uint retcode_;

		// Token: 0x04001937 RID: 6455
		public const int SectionIdFieldNumber = 12;

		// Token: 0x04001938 RID: 6456
		private uint sectionId_;
	}
}
