using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200094F RID: 2383
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ItemList : IMessage<ItemList>, IMessage, IEquatable<ItemList>, IDeepCloneable<ItemList>, IBufferMessage
	{
		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06006A6B RID: 27243 RVA: 0x0011C08C File Offset: 0x0011A28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemList> Parser
		{
			get
			{
				return ItemList._parser;
			}
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06006A6C RID: 27244 RVA: 0x0011C093 File Offset: 0x0011A293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06006A6D RID: 27245 RVA: 0x0011C0A5 File Offset: 0x0011A2A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemList.Descriptor;
			}
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x0011C0AC File Offset: 0x0011A2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList()
		{
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x0011C0BF File Offset: 0x0011A2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList(ItemList other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x0011C0E9 File Offset: 0x0011A2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Clone()
		{
			return new ItemList(this);
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06006A71 RID: 27249 RVA: 0x0011C0F1 File Offset: 0x0011A2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Item> ItemList_
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x0011C0F9 File Offset: 0x0011A2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemList);
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x0011C107 File Offset: 0x0011A307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemList other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x0011C13C File Offset: 0x0011A33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x0011C170 File Offset: 0x0011A370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x0011C178 File Offset: 0x0011A378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x0011C181 File Offset: 0x0011A381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ItemList._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x0011C1A8 File Offset: 0x0011A3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(ItemList._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x0011C1E1 File Offset: 0x0011A3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemList other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x0011C20F File Offset: 0x0011A40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x0011C218 File Offset: 0x0011A418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, ItemList._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x040028C5 RID: 10437
		private static readonly MessageParser<ItemList> _parser = new MessageParser<ItemList>(() => new ItemList());

		// Token: 0x040028C6 RID: 10438
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028C7 RID: 10439
		public const int ItemList_FieldNumber = 12;

		// Token: 0x040028C8 RID: 10440
		private static readonly FieldCodec<Item> _repeated_itemList_codec = FieldCodec.ForMessage<Item>(98U, Item.Parser);

		// Token: 0x040028C9 RID: 10441
		private readonly RepeatedField<Item> itemList_ = new RepeatedField<Item>();
	}
}
