using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AC5 RID: 2757
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MessageItem : IMessage<MessageItem>, IMessage, IEquatable<MessageItem>, IDeepCloneable<MessageItem>, IBufferMessage
	{
		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x06007A33 RID: 31283 RVA: 0x00143AE8 File Offset: 0x00141CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MessageItem> Parser
		{
			get
			{
				return MessageItem._parser;
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x06007A34 RID: 31284 RVA: 0x00143AEF File Offset: 0x00141CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MessageItemReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x06007A35 RID: 31285 RVA: 0x00143B01 File Offset: 0x00141D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MessageItem.Descriptor;
			}
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x00143B08 File Offset: 0x00141D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageItem()
		{
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x00143B10 File Offset: 0x00141D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageItem(MessageItem other) : this()
		{
			this.textId_ = other.textId_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x00143B41 File Offset: 0x00141D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageItem Clone()
		{
			return new MessageItem(this);
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x06007A39 RID: 31289 RVA: 0x00143B49 File Offset: 0x00141D49
		// (set) Token: 0x06007A3A RID: 31290 RVA: 0x00143B51 File Offset: 0x00141D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TextId
		{
			get
			{
				return this.textId_;
			}
			set
			{
				this.textId_ = value;
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x06007A3B RID: 31291 RVA: 0x00143B5A File Offset: 0x00141D5A
		// (set) Token: 0x06007A3C RID: 31292 RVA: 0x00143B62 File Offset: 0x00141D62
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

		// Token: 0x06007A3D RID: 31293 RVA: 0x00143B6B File Offset: 0x00141D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MessageItem);
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x00143B79 File Offset: 0x00141D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MessageItem other)
		{
			return other != null && (other == this || (this.TextId == other.TextId && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x00143BB8 File Offset: 0x00141DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TextId != 0U)
			{
				num ^= this.TextId.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x00143C10 File Offset: 0x00141E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x00143C18 File Offset: 0x00141E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x00143C24 File Offset: 0x00141E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ItemId);
			}
			if (this.TextId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.TextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x00143C80 File Offset: 0x00141E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TextId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextId);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A44 RID: 31300 RVA: 0x00143CD8 File Offset: 0x00141ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MessageItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TextId != 0U)
			{
				this.TextId = other.TextId;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x00143D28 File Offset: 0x00141F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x00143D34 File Offset: 0x00141F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TextId = input.ReadUInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002EE6 RID: 12006
		private static readonly MessageParser<MessageItem> _parser = new MessageParser<MessageItem>(() => new MessageItem());

		// Token: 0x04002EE7 RID: 12007
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EE8 RID: 12008
		public const int TextIdFieldNumber = 7;

		// Token: 0x04002EE9 RID: 12009
		private uint textId_;

		// Token: 0x04002EEA RID: 12010
		public const int ItemIdFieldNumber = 4;

		// Token: 0x04002EEB RID: 12011
		private uint itemId_;
	}
}
