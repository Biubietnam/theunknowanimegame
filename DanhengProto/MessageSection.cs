using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AC7 RID: 2759
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MessageSection : IMessage<MessageSection>, IMessage, IEquatable<MessageSection>, IDeepCloneable<MessageSection>, IBufferMessage
	{
		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x06007A4A RID: 31306 RVA: 0x00143E6B File Offset: 0x0014206B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MessageSection> Parser
		{
			get
			{
				return MessageSection._parser;
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x06007A4B RID: 31307 RVA: 0x00143E72 File Offset: 0x00142072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MessageSectionReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x06007A4C RID: 31308 RVA: 0x00143E84 File Offset: 0x00142084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MessageSection.Descriptor;
			}
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x00143E8B File Offset: 0x0014208B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageSection()
		{
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x00143EAC File Offset: 0x001420AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageSection(MessageSection other) : this()
		{
			this.frozenItemId_ = other.frozenItemId_;
			this.messageItemList_ = other.messageItemList_.Clone();
			this.status_ = other.status_;
			this.itemList_ = other.itemList_.Clone();
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x00143F16 File Offset: 0x00142116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageSection Clone()
		{
			return new MessageSection(this);
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x06007A50 RID: 31312 RVA: 0x00143F1E File Offset: 0x0014211E
		// (set) Token: 0x06007A51 RID: 31313 RVA: 0x00143F26 File Offset: 0x00142126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FrozenItemId
		{
			get
			{
				return this.frozenItemId_;
			}
			set
			{
				this.frozenItemId_ = value;
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x06007A52 RID: 31314 RVA: 0x00143F2F File Offset: 0x0014212F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MessageItemList
		{
			get
			{
				return this.messageItemList_;
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x06007A53 RID: 31315 RVA: 0x00143F37 File Offset: 0x00142137
		// (set) Token: 0x06007A54 RID: 31316 RVA: 0x00143F3F File Offset: 0x0014213F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageSectionStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x06007A55 RID: 31317 RVA: 0x00143F48 File Offset: 0x00142148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MessageItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x06007A56 RID: 31318 RVA: 0x00143F50 File Offset: 0x00142150
		// (set) Token: 0x06007A57 RID: 31319 RVA: 0x00143F58 File Offset: 0x00142158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x00143F61 File Offset: 0x00142161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MessageSection);
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x00143F70 File Offset: 0x00142170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MessageSection other)
		{
			return other != null && (other == this || (this.FrozenItemId == other.FrozenItemId && this.messageItemList_.Equals(other.messageItemList_) && this.Status == other.Status && this.itemList_.Equals(other.itemList_) && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x00143FF4 File Offset: 0x001421F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FrozenItemId != 0U)
			{
				num ^= this.FrozenItemId.GetHashCode();
			}
			num ^= this.messageItemList_.GetHashCode();
			if (this.Status != MessageSectionStatus.MessageSectionNone)
			{
				num ^= this.Status.GetHashCode();
			}
			num ^= this.itemList_.GetHashCode();
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x00144087 File Offset: 0x00142287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x0014408F File Offset: 0x0014228F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A5D RID: 31325 RVA: 0x00144098 File Offset: 0x00142298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Id);
			}
			this.messageItemList_.WriteTo(ref output, MessageSection._repeated_messageItemList_codec);
			if (this.Status != MessageSectionStatus.MessageSectionNone)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Status);
			}
			if (this.FrozenItemId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.FrozenItemId);
			}
			this.itemList_.WriteTo(ref output, MessageSection._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x00144130 File Offset: 0x00142330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FrozenItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FrozenItemId);
			}
			num += this.messageItemList_.CalculateSize(MessageSection._repeated_messageItemList_codec);
			if (this.Status != MessageSectionStatus.MessageSectionNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			num += this.itemList_.CalculateSize(MessageSection._repeated_itemList_codec);
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x001441C4 File Offset: 0x001423C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MessageSection other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FrozenItemId != 0U)
			{
				this.FrozenItemId = other.FrozenItemId;
			}
			this.messageItemList_.Add(other.messageItemList_);
			if (other.Status != MessageSectionStatus.MessageSectionNone)
			{
				this.Status = other.Status;
			}
			this.itemList_.Add(other.itemList_);
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x0014424A File Offset: 0x0014244A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x00144254 File Offset: 0x00142454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 24U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 72U || num == 74U)
					{
						this.messageItemList_.AddEntriesFrom(ref input, MessageSection._repeated_messageItemList_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Status = (MessageSectionStatus)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.FrozenItemId = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						this.itemList_.AddEntriesFrom(ref input, MessageSection._repeated_itemList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002EED RID: 12013
		private static readonly MessageParser<MessageSection> _parser = new MessageParser<MessageSection>(() => new MessageSection());

		// Token: 0x04002EEE RID: 12014
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EEF RID: 12015
		public const int FrozenItemIdFieldNumber = 14;

		// Token: 0x04002EF0 RID: 12016
		private uint frozenItemId_;

		// Token: 0x04002EF1 RID: 12017
		public const int MessageItemListFieldNumber = 9;

		// Token: 0x04002EF2 RID: 12018
		private static readonly FieldCodec<uint> _repeated_messageItemList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04002EF3 RID: 12019
		private readonly RepeatedField<uint> messageItemList_ = new RepeatedField<uint>();

		// Token: 0x04002EF4 RID: 12020
		public const int StatusFieldNumber = 10;

		// Token: 0x04002EF5 RID: 12021
		private MessageSectionStatus status_;

		// Token: 0x04002EF6 RID: 12022
		public const int ItemListFieldNumber = 15;

		// Token: 0x04002EF7 RID: 12023
		private static readonly FieldCodec<MessageItem> _repeated_itemList_codec = FieldCodec.ForMessage<MessageItem>(122U, MessageItem.Parser);

		// Token: 0x04002EF8 RID: 12024
		private readonly RepeatedField<MessageItem> itemList_ = new RepeatedField<MessageItem>();

		// Token: 0x04002EF9 RID: 12025
		public const int IdFieldNumber = 3;

		// Token: 0x04002EFA RID: 12026
		private uint id_;
	}
}
