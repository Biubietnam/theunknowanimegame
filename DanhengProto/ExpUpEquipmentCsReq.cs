using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004E9 RID: 1257
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExpUpEquipmentCsReq : IMessage<ExpUpEquipmentCsReq>, IMessage, IEquatable<ExpUpEquipmentCsReq>, IDeepCloneable<ExpUpEquipmentCsReq>, IBufferMessage
	{
		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06003838 RID: 14392 RVA: 0x0009A15D File Offset: 0x0009835D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpUpEquipmentCsReq> Parser
		{
			get
			{
				return ExpUpEquipmentCsReq._parser;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06003839 RID: 14393 RVA: 0x0009A164 File Offset: 0x00098364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExpUpEquipmentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x0009A176 File Offset: 0x00098376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpUpEquipmentCsReq.Descriptor;
			}
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x0009A17D File Offset: 0x0009837D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpEquipmentCsReq()
		{
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x0009A188 File Offset: 0x00098388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpEquipmentCsReq(ExpUpEquipmentCsReq other) : this()
		{
			this.equipmentUniqueId_ = other.equipmentUniqueId_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x0009A1D4 File Offset: 0x000983D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpEquipmentCsReq Clone()
		{
			return new ExpUpEquipmentCsReq(this);
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x0600383E RID: 14398 RVA: 0x0009A1DC File Offset: 0x000983DC
		// (set) Token: 0x0600383F RID: 14399 RVA: 0x0009A1E4 File Offset: 0x000983E4
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

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06003840 RID: 14400 RVA: 0x0009A1ED File Offset: 0x000983ED
		// (set) Token: 0x06003841 RID: 14401 RVA: 0x0009A1F5 File Offset: 0x000983F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData CostData
		{
			get
			{
				return this.costData_;
			}
			set
			{
				this.costData_ = value;
			}
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x0009A1FE File Offset: 0x000983FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpUpEquipmentCsReq);
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x0009A20C File Offset: 0x0009840C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpUpEquipmentCsReq other)
		{
			return other != null && (other == this || (this.EquipmentUniqueId == other.EquipmentUniqueId && object.Equals(this.CostData, other.CostData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x0009A25C File Offset: 0x0009845C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EquipmentUniqueId != 0U)
			{
				num ^= this.EquipmentUniqueId.GetHashCode();
			}
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x0009A2B1 File Offset: 0x000984B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x0009A2B9 File Offset: 0x000984B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x0009A2C4 File Offset: 0x000984C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EquipmentUniqueId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EquipmentUniqueId);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CostData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x0009A31C File Offset: 0x0009851C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EquipmentUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EquipmentUniqueId);
			}
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x0009A374 File Offset: 0x00098574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExpUpEquipmentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EquipmentUniqueId != 0U)
			{
				this.EquipmentUniqueId = other.EquipmentUniqueId;
			}
			if (other.costData_ != null)
			{
				if (this.costData_ == null)
				{
					this.CostData = new ItemCostData();
				}
				this.CostData.MergeFrom(other.CostData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x0009A3DC File Offset: 0x000985DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x0009A3E8 File Offset: 0x000985E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.costData_ == null)
						{
							this.CostData = new ItemCostData();
						}
						input.ReadMessage(this.CostData);
					}
				}
				else
				{
					this.EquipmentUniqueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001641 RID: 5697
		private static readonly MessageParser<ExpUpEquipmentCsReq> _parser = new MessageParser<ExpUpEquipmentCsReq>(() => new ExpUpEquipmentCsReq());

		// Token: 0x04001642 RID: 5698
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001643 RID: 5699
		public const int EquipmentUniqueIdFieldNumber = 1;

		// Token: 0x04001644 RID: 5700
		private uint equipmentUniqueId_;

		// Token: 0x04001645 RID: 5701
		public const int CostDataFieldNumber = 14;

		// Token: 0x04001646 RID: 5702
		private ItemCostData costData_;
	}
}
