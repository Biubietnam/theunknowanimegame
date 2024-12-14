using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200094B RID: 2379
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ItemCost : IMessage<ItemCost>, IMessage, IEquatable<ItemCost>, IDeepCloneable<ItemCost>, IBufferMessage
	{
		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x06006A3E RID: 27198 RVA: 0x0011B9E5 File Offset: 0x00119BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemCost> Parser
		{
			get
			{
				return ItemCost._parser;
			}
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06006A3F RID: 27199 RVA: 0x0011B9EC File Offset: 0x00119BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemCostReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x06006A40 RID: 27200 RVA: 0x0011B9FE File Offset: 0x00119BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemCost.Descriptor;
			}
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x0011BA05 File Offset: 0x00119C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCost()
		{
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x0011BA10 File Offset: 0x00119C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCost(ItemCost other) : this()
		{
			this.pileItem_ = ((other.pileItem_ != null) ? other.pileItem_.Clone() : null);
			this.equipmentUniqueId_ = other.equipmentUniqueId_;
			this.relicUniqueId_ = other.relicUniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x0011BA68 File Offset: 0x00119C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCost Clone()
		{
			return new ItemCost(this);
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06006A44 RID: 27204 RVA: 0x0011BA70 File Offset: 0x00119C70
		// (set) Token: 0x06006A45 RID: 27205 RVA: 0x0011BA78 File Offset: 0x00119C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PileItem PileItem
		{
			get
			{
				return this.pileItem_;
			}
			set
			{
				this.pileItem_ = value;
			}
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06006A46 RID: 27206 RVA: 0x0011BA81 File Offset: 0x00119C81
		// (set) Token: 0x06006A47 RID: 27207 RVA: 0x0011BA89 File Offset: 0x00119C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EquipmentUniqueId
		{
			get
			{
				return this.equipmentUniqueId_;
			}
			set
			{
				this.equipmentUniqueId_ = value;
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06006A48 RID: 27208 RVA: 0x0011BA92 File Offset: 0x00119C92
		// (set) Token: 0x06006A49 RID: 27209 RVA: 0x0011BA9A File Offset: 0x00119C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RelicUniqueId
		{
			get
			{
				return this.relicUniqueId_;
			}
			set
			{
				this.relicUniqueId_ = value;
			}
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x0011BAA3 File Offset: 0x00119CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemCost);
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x0011BAB4 File Offset: 0x00119CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemCost other)
		{
			return other != null && (other == this || (object.Equals(this.PileItem, other.PileItem) && this.EquipmentUniqueId == other.EquipmentUniqueId && this.RelicUniqueId == other.RelicUniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x0011BB14 File Offset: 0x00119D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pileItem_ != null)
			{
				num ^= this.PileItem.GetHashCode();
			}
			if (this.EquipmentUniqueId != 0U)
			{
				num ^= this.EquipmentUniqueId.GetHashCode();
			}
			if (this.RelicUniqueId != 0U)
			{
				num ^= this.RelicUniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x0011BB82 File Offset: 0x00119D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x0011BB8A File Offset: 0x00119D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x0011BB94 File Offset: 0x00119D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EquipmentUniqueId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.EquipmentUniqueId);
			}
			if (this.pileItem_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PileItem);
			}
			if (this.RelicUniqueId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.RelicUniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x0011BC0C File Offset: 0x00119E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pileItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PileItem);
			}
			if (this.EquipmentUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EquipmentUniqueId);
			}
			if (this.RelicUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RelicUniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x0011BC7C File Offset: 0x00119E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemCost other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pileItem_ != null)
			{
				if (this.pileItem_ == null)
				{
					this.PileItem = new PileItem();
				}
				this.PileItem.MergeFrom(other.PileItem);
			}
			if (other.EquipmentUniqueId != 0U)
			{
				this.EquipmentUniqueId = other.EquipmentUniqueId;
			}
			if (other.RelicUniqueId != 0U)
			{
				this.RelicUniqueId = other.RelicUniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A52 RID: 27218 RVA: 0x0011BCF8 File Offset: 0x00119EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x0011BD04 File Offset: 0x00119F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 50U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RelicUniqueId = input.ReadUInt32();
						}
					}
					else
					{
						if (this.pileItem_ == null)
						{
							this.PileItem = new PileItem();
						}
						input.ReadMessage(this.PileItem);
					}
				}
				else
				{
					this.EquipmentUniqueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040028B6 RID: 10422
		private static readonly MessageParser<ItemCost> _parser = new MessageParser<ItemCost>(() => new ItemCost());

		// Token: 0x040028B7 RID: 10423
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028B8 RID: 10424
		public const int PileItemFieldNumber = 6;

		// Token: 0x040028B9 RID: 10425
		private PileItem pileItem_;

		// Token: 0x040028BA RID: 10426
		public const int EquipmentUniqueIdFieldNumber = 2;

		// Token: 0x040028BB RID: 10427
		private uint equipmentUniqueId_;

		// Token: 0x040028BC RID: 10428
		public const int RelicUniqueIdFieldNumber = 14;

		// Token: 0x040028BD RID: 10429
		private uint relicUniqueId_;
	}
}
