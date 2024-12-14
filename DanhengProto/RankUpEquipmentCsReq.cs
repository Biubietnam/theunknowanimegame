using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D79 RID: 3449
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RankUpEquipmentCsReq : IMessage<RankUpEquipmentCsReq>, IMessage, IEquatable<RankUpEquipmentCsReq>, IDeepCloneable<RankUpEquipmentCsReq>, IBufferMessage
	{
		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x06009A16 RID: 39446 RVA: 0x0019A3F9 File Offset: 0x001985F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RankUpEquipmentCsReq> Parser
		{
			get
			{
				return RankUpEquipmentCsReq._parser;
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x06009A17 RID: 39447 RVA: 0x0019A400 File Offset: 0x00198600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RankUpEquipmentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x06009A18 RID: 39448 RVA: 0x0019A412 File Offset: 0x00198612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RankUpEquipmentCsReq.Descriptor;
			}
		}

		// Token: 0x06009A19 RID: 39449 RVA: 0x0019A419 File Offset: 0x00198619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpEquipmentCsReq()
		{
		}

		// Token: 0x06009A1A RID: 39450 RVA: 0x0019A424 File Offset: 0x00198624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpEquipmentCsReq(RankUpEquipmentCsReq other) : this()
		{
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this.equipmentUniqueId_ = other.equipmentUniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A1B RID: 39451 RVA: 0x0019A470 File Offset: 0x00198670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpEquipmentCsReq Clone()
		{
			return new RankUpEquipmentCsReq(this);
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x06009A1C RID: 39452 RVA: 0x0019A478 File Offset: 0x00198678
		// (set) Token: 0x06009A1D RID: 39453 RVA: 0x0019A480 File Offset: 0x00198680
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

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x06009A1E RID: 39454 RVA: 0x0019A489 File Offset: 0x00198689
		// (set) Token: 0x06009A1F RID: 39455 RVA: 0x0019A491 File Offset: 0x00198691
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

		// Token: 0x06009A20 RID: 39456 RVA: 0x0019A49A File Offset: 0x0019869A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RankUpEquipmentCsReq);
		}

		// Token: 0x06009A21 RID: 39457 RVA: 0x0019A4A8 File Offset: 0x001986A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RankUpEquipmentCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.CostData, other.CostData) && this.EquipmentUniqueId == other.EquipmentUniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A22 RID: 39458 RVA: 0x0019A4F8 File Offset: 0x001986F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
			}
			if (this.EquipmentUniqueId != 0U)
			{
				num ^= this.EquipmentUniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A23 RID: 39459 RVA: 0x0019A54D File Offset: 0x0019874D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A24 RID: 39460 RVA: 0x0019A555 File Offset: 0x00198755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A25 RID: 39461 RVA: 0x0019A560 File Offset: 0x00198760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EquipmentUniqueId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EquipmentUniqueId);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CostData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A26 RID: 39462 RVA: 0x0019A5BC File Offset: 0x001987BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
			}
			if (this.EquipmentUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EquipmentUniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A27 RID: 39463 RVA: 0x0019A614 File Offset: 0x00198814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RankUpEquipmentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.costData_ != null)
			{
				if (this.costData_ == null)
				{
					this.CostData = new ItemCostData();
				}
				this.CostData.MergeFrom(other.CostData);
			}
			if (other.EquipmentUniqueId != 0U)
			{
				this.EquipmentUniqueId = other.EquipmentUniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A28 RID: 39464 RVA: 0x0019A67C File Offset: 0x0019887C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A29 RID: 39465 RVA: 0x0019A688 File Offset: 0x00198888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 66U)
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

		// Token: 0x04003BD7 RID: 15319
		private static readonly MessageParser<RankUpEquipmentCsReq> _parser = new MessageParser<RankUpEquipmentCsReq>(() => new RankUpEquipmentCsReq());

		// Token: 0x04003BD8 RID: 15320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BD9 RID: 15321
		public const int CostDataFieldNumber = 8;

		// Token: 0x04003BDA RID: 15322
		private ItemCostData costData_;

		// Token: 0x04003BDB RID: 15323
		public const int EquipmentUniqueIdFieldNumber = 3;

		// Token: 0x04003BDC RID: 15324
		private uint equipmentUniqueId_;
	}
}
