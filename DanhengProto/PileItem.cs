using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C9D RID: 3229
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PileItem : IMessage<PileItem>, IMessage, IEquatable<PileItem>, IDeepCloneable<PileItem>, IBufferMessage
	{
		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x06008F94 RID: 36756 RVA: 0x0017B68C File Offset: 0x0017988C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PileItem> Parser
		{
			get
			{
				return PileItem._parser;
			}
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x06008F95 RID: 36757 RVA: 0x0017B693 File Offset: 0x00179893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PileItemReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x06008F96 RID: 36758 RVA: 0x0017B6A5 File Offset: 0x001798A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PileItem.Descriptor;
			}
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x0017B6AC File Offset: 0x001798AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PileItem()
		{
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x0017B6B4 File Offset: 0x001798B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PileItem(PileItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemNum_ = other.itemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F99 RID: 36761 RVA: 0x0017B6E5 File Offset: 0x001798E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PileItem Clone()
		{
			return new PileItem(this);
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x06008F9A RID: 36762 RVA: 0x0017B6ED File Offset: 0x001798ED
		// (set) Token: 0x06008F9B RID: 36763 RVA: 0x0017B6F5 File Offset: 0x001798F5
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

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x06008F9C RID: 36764 RVA: 0x0017B6FE File Offset: 0x001798FE
		// (set) Token: 0x06008F9D RID: 36765 RVA: 0x0017B706 File Offset: 0x00179906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemNum
		{
			get
			{
				return this.itemNum_;
			}
			set
			{
				this.itemNum_ = value;
			}
		}

		// Token: 0x06008F9E RID: 36766 RVA: 0x0017B70F File Offset: 0x0017990F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PileItem);
		}

		// Token: 0x06008F9F RID: 36767 RVA: 0x0017B71D File Offset: 0x0017991D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PileItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FA0 RID: 36768 RVA: 0x0017B75C File Offset: 0x0017995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemNum != 0U)
			{
				num ^= this.ItemNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FA1 RID: 36769 RVA: 0x0017B7B4 File Offset: 0x001799B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008FA2 RID: 36770 RVA: 0x0017B7BC File Offset: 0x001799BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FA3 RID: 36771 RVA: 0x0017B7C8 File Offset: 0x001799C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ItemId);
			}
			if (this.ItemNum != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ItemNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x0017B824 File Offset: 0x00179A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.ItemNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FA5 RID: 36773 RVA: 0x0017B87C File Offset: 0x00179A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PileItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemNum != 0U)
			{
				this.ItemNum = other.ItemNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008FA6 RID: 36774 RVA: 0x0017B8CC File Offset: 0x00179ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FA7 RID: 36775 RVA: 0x0017B8D8 File Offset: 0x00179AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemNum = input.ReadUInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003726 RID: 14118
		private static readonly MessageParser<PileItem> _parser = new MessageParser<PileItem>(() => new PileItem());

		// Token: 0x04003727 RID: 14119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003728 RID: 14120
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04003729 RID: 14121
		private uint itemId_;

		// Token: 0x0400372A RID: 14122
		public const int ItemNumFieldNumber = 4;

		// Token: 0x0400372B RID: 14123
		private uint itemNum_;
	}
}
