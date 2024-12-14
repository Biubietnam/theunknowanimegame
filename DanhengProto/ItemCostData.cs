using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200094D RID: 2381
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ItemCostData : IMessage<ItemCostData>, IMessage, IEquatable<ItemCostData>, IDeepCloneable<ItemCostData>, IBufferMessage
	{
		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x06006A57 RID: 27223 RVA: 0x0011BE14 File Offset: 0x0011A014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemCostData> Parser
		{
			get
			{
				return ItemCostData._parser;
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x06006A58 RID: 27224 RVA: 0x0011BE1B File Offset: 0x0011A01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemCostDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x06006A59 RID: 27225 RVA: 0x0011BE2D File Offset: 0x0011A02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemCostData.Descriptor;
			}
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x0011BE34 File Offset: 0x0011A034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData()
		{
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x0011BE47 File Offset: 0x0011A047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData(ItemCostData other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x0011BE71 File Offset: 0x0011A071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData Clone()
		{
			return new ItemCostData(this);
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x06006A5D RID: 27229 RVA: 0x0011BE79 File Offset: 0x0011A079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemCost> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x0011BE81 File Offset: 0x0011A081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemCostData);
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x0011BE8F File Offset: 0x0011A08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemCostData other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x0011BEC4 File Offset: 0x0011A0C4
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

		// Token: 0x06006A61 RID: 27233 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x0011BF00 File Offset: 0x0011A100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x0011BF09 File Offset: 0x0011A109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ItemCostData._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x0011BF30 File Offset: 0x0011A130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(ItemCostData._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x0011BF69 File Offset: 0x0011A169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemCostData other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x0011BF97 File Offset: 0x0011A197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x0011BFA0 File Offset: 0x0011A1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, ItemCostData._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x040028BF RID: 10431
		private static readonly MessageParser<ItemCostData> _parser = new MessageParser<ItemCostData>(() => new ItemCostData());

		// Token: 0x040028C0 RID: 10432
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028C1 RID: 10433
		public const int ItemListFieldNumber = 13;

		// Token: 0x040028C2 RID: 10434
		private static readonly FieldCodec<ItemCost> _repeated_itemList_codec = FieldCodec.ForMessage<ItemCost>(106U, ItemCost.Parser);

		// Token: 0x040028C3 RID: 10435
		private readonly RepeatedField<ItemCost> itemList_ = new RepeatedField<ItemCost>();
	}
}
