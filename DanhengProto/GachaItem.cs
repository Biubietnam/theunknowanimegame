using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005D3 RID: 1491
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GachaItem : IMessage<GachaItem>, IMessage, IEquatable<GachaItem>, IDeepCloneable<GachaItem>, IBufferMessage
	{
		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x000B569F File Offset: 0x000B389F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaItem> Parser
		{
			get
			{
				return GachaItem._parser;
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x000B56A6 File Offset: 0x000B38A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GachaItemReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x000B56B8 File Offset: 0x000B38B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaItem.Descriptor;
			}
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x000B56BF File Offset: 0x000B38BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaItem()
		{
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x000B56C8 File Offset: 0x000B38C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaItem(GachaItem other) : this()
		{
			this.transferItemList_ = ((other.transferItemList_ != null) ? other.transferItemList_.Clone() : null);
			this.gachaItem_ = ((other.gachaItem_ != null) ? other.gachaItem_.Clone() : null);
			this.isNew_ = other.isNew_;
			this.tokenItem_ = ((other.tokenItem_ != null) ? other.tokenItem_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x000B574C File Offset: 0x000B394C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaItem Clone()
		{
			return new GachaItem(this);
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06004298 RID: 17048 RVA: 0x000B5754 File Offset: 0x000B3954
		// (set) Token: 0x06004299 RID: 17049 RVA: 0x000B575C File Offset: 0x000B395C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList TransferItemList
		{
			get
			{
				return this.transferItemList_;
			}
			set
			{
				this.transferItemList_ = value;
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x0600429A RID: 17050 RVA: 0x000B5765 File Offset: 0x000B3965
		// (set) Token: 0x0600429B RID: 17051 RVA: 0x000B576D File Offset: 0x000B396D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Item GachaItem_
		{
			get
			{
				return this.gachaItem_;
			}
			set
			{
				this.gachaItem_ = value;
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x000B5776 File Offset: 0x000B3976
		// (set) Token: 0x0600429D RID: 17053 RVA: 0x000B577E File Offset: 0x000B397E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x000B5787 File Offset: 0x000B3987
		// (set) Token: 0x0600429F RID: 17055 RVA: 0x000B578F File Offset: 0x000B398F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList TokenItem
		{
			get
			{
				return this.tokenItem_;
			}
			set
			{
				this.tokenItem_ = value;
			}
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x000B5798 File Offset: 0x000B3998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaItem);
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x000B57A8 File Offset: 0x000B39A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaItem other)
		{
			return other != null && (other == this || (object.Equals(this.TransferItemList, other.TransferItemList) && object.Equals(this.GachaItem_, other.GachaItem_) && this.IsNew == other.IsNew && object.Equals(this.TokenItem, other.TokenItem) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x000B5820 File Offset: 0x000B3A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.transferItemList_ != null)
			{
				num ^= this.TransferItemList.GetHashCode();
			}
			if (this.gachaItem_ != null)
			{
				num ^= this.GachaItem_.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this.tokenItem_ != null)
			{
				num ^= this.TokenItem.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x000B58A1 File Offset: 0x000B3AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x000B58A9 File Offset: 0x000B3AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x000B58B4 File Offset: 0x000B3AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gachaItem_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GachaItem_);
			}
			if (this.IsNew)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsNew);
			}
			if (this.transferItemList_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.TransferItemList);
			}
			if (this.tokenItem_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.TokenItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x000B5948 File Offset: 0x000B3B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.transferItemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransferItemList);
			}
			if (this.gachaItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaItem_);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this.tokenItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TokenItem);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x000B59C4 File Offset: 0x000B3BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.transferItemList_ != null)
			{
				if (this.transferItemList_ == null)
				{
					this.TransferItemList = new ItemList();
				}
				this.TransferItemList.MergeFrom(other.TransferItemList);
			}
			if (other.gachaItem_ != null)
			{
				if (this.gachaItem_ == null)
				{
					this.GachaItem_ = new Item();
				}
				this.GachaItem_.MergeFrom(other.GachaItem_);
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			if (other.tokenItem_ != null)
			{
				if (this.tokenItem_ == null)
				{
					this.TokenItem = new ItemList();
				}
				this.TokenItem.MergeFrom(other.TokenItem);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x000B5A84 File Offset: 0x000B3C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x000B5A90 File Offset: 0x000B3C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 26U)
					{
						if (this.gachaItem_ == null)
						{
							this.GachaItem_ = new Item();
						}
						input.ReadMessage(this.GachaItem_);
						continue;
					}
					if (num == 72U)
					{
						this.IsNew = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.transferItemList_ == null)
						{
							this.TransferItemList = new ItemList();
						}
						input.ReadMessage(this.TransferItemList);
						continue;
					}
					if (num == 114U)
					{
						if (this.tokenItem_ == null)
						{
							this.TokenItem = new ItemList();
						}
						input.ReadMessage(this.TokenItem);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001A76 RID: 6774
		private static readonly MessageParser<GachaItem> _parser = new MessageParser<GachaItem>(() => new GachaItem());

		// Token: 0x04001A77 RID: 6775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A78 RID: 6776
		public const int TransferItemListFieldNumber = 12;

		// Token: 0x04001A79 RID: 6777
		private ItemList transferItemList_;

		// Token: 0x04001A7A RID: 6778
		public const int GachaItem_FieldNumber = 3;

		// Token: 0x04001A7B RID: 6779
		private Item gachaItem_;

		// Token: 0x04001A7C RID: 6780
		public const int IsNewFieldNumber = 9;

		// Token: 0x04001A7D RID: 6781
		private bool isNew_;

		// Token: 0x04001A7E RID: 6782
		public const int TokenItemFieldNumber = 14;

		// Token: 0x04001A7F RID: 6783
		private ItemList tokenItem_;
	}
}
