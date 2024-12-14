using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002DB RID: 731
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientMailAttachmentItem : IMessage<ClientMailAttachmentItem>, IMessage, IEquatable<ClientMailAttachmentItem>, IDeepCloneable<ClientMailAttachmentItem>, IBufferMessage
	{
		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x0005CEC8 File Offset: 0x0005B0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientMailAttachmentItem> Parser
		{
			get
			{
				return ClientMailAttachmentItem._parser;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x0005CECF File Offset: 0x0005B0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMailAttachmentItemReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0005CEE1 File Offset: 0x0005B0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientMailAttachmentItem.Descriptor;
			}
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x0005CEE8 File Offset: 0x0005B0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientMailAttachmentItem()
		{
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0005CEF0 File Offset: 0x0005B0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientMailAttachmentItem(ClientMailAttachmentItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.mailId_ = other.mailId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0005CF21 File Offset: 0x0005B121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientMailAttachmentItem Clone()
		{
			return new ClientMailAttachmentItem(this);
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x0005CF29 File Offset: 0x0005B129
		// (set) Token: 0x060020A5 RID: 8357 RVA: 0x0005CF31 File Offset: 0x0005B131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0005CF3A File Offset: 0x0005B13A
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x0005CF42 File Offset: 0x0005B142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MailId
		{
			get
			{
				return this.mailId_;
			}
			set
			{
				this.mailId_ = value;
			}
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0005CF4B File Offset: 0x0005B14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientMailAttachmentItem);
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0005CF59 File Offset: 0x0005B159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientMailAttachmentItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.MailId == other.MailId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0005CF98 File Offset: 0x0005B198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.MailId != 0U)
			{
				num ^= this.MailId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0005CFF0 File Offset: 0x0005B1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0005CFF8 File Offset: 0x0005B1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x0005D004 File Offset: 0x0005B204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MailId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MailId);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x0005D060 File Offset: 0x0005B260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.MailId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MailId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0005D0B8 File Offset: 0x0005B2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientMailAttachmentItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.MailId != 0U)
			{
				this.MailId = other.MailId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0005D108 File Offset: 0x0005B308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0005D114 File Offset: 0x0005B314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemId = input.ReadUInt32();
					}
				}
				else
				{
					this.MailId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000D81 RID: 3457
		private static readonly MessageParser<ClientMailAttachmentItem> _parser = new MessageParser<ClientMailAttachmentItem>(() => new ClientMailAttachmentItem());

		// Token: 0x04000D82 RID: 3458
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D83 RID: 3459
		public const int ItemIdFieldNumber = 11;

		// Token: 0x04000D84 RID: 3460
		private uint itemId_;

		// Token: 0x04000D85 RID: 3461
		public const int MailIdFieldNumber = 10;

		// Token: 0x04000D86 RID: 3462
		private uint mailId_;
	}
}
