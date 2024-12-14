using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D0D RID: 3341
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PromoteEquipmentCsReq : IMessage<PromoteEquipmentCsReq>, IMessage, IEquatable<PromoteEquipmentCsReq>, IDeepCloneable<PromoteEquipmentCsReq>, IBufferMessage
	{
		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x0600952F RID: 38191 RVA: 0x0018C8D1 File Offset: 0x0018AAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PromoteEquipmentCsReq> Parser
		{
			get
			{
				return PromoteEquipmentCsReq._parser;
			}
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x06009530 RID: 38192 RVA: 0x0018C8D8 File Offset: 0x0018AAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PromoteEquipmentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x06009531 RID: 38193 RVA: 0x0018C8EA File Offset: 0x0018AAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PromoteEquipmentCsReq.Descriptor;
			}
		}

		// Token: 0x06009532 RID: 38194 RVA: 0x0018C8F1 File Offset: 0x0018AAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteEquipmentCsReq()
		{
		}

		// Token: 0x06009533 RID: 38195 RVA: 0x0018C8FC File Offset: 0x0018AAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteEquipmentCsReq(PromoteEquipmentCsReq other) : this()
		{
			this.equipmentUniqueId_ = other.equipmentUniqueId_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009534 RID: 38196 RVA: 0x0018C948 File Offset: 0x0018AB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteEquipmentCsReq Clone()
		{
			return new PromoteEquipmentCsReq(this);
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x06009535 RID: 38197 RVA: 0x0018C950 File Offset: 0x0018AB50
		// (set) Token: 0x06009536 RID: 38198 RVA: 0x0018C958 File Offset: 0x0018AB58
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

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x06009537 RID: 38199 RVA: 0x0018C961 File Offset: 0x0018AB61
		// (set) Token: 0x06009538 RID: 38200 RVA: 0x0018C969 File Offset: 0x0018AB69
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

		// Token: 0x06009539 RID: 38201 RVA: 0x0018C972 File Offset: 0x0018AB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PromoteEquipmentCsReq);
		}

		// Token: 0x0600953A RID: 38202 RVA: 0x0018C980 File Offset: 0x0018AB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PromoteEquipmentCsReq other)
		{
			return other != null && (other == this || (this.EquipmentUniqueId == other.EquipmentUniqueId && object.Equals(this.CostData, other.CostData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600953B RID: 38203 RVA: 0x0018C9D0 File Offset: 0x0018ABD0
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

		// Token: 0x0600953C RID: 38204 RVA: 0x0018CA25 File Offset: 0x0018AC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x0018CA2D File Offset: 0x0018AC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x0018CA38 File Offset: 0x0018AC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EquipmentUniqueId != 0U)
			{
				output.WriteRawTag(80);
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

		// Token: 0x0600953F RID: 38207 RVA: 0x0018CA94 File Offset: 0x0018AC94
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

		// Token: 0x06009540 RID: 38208 RVA: 0x0018CAEC File Offset: 0x0018ACEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PromoteEquipmentCsReq other)
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

		// Token: 0x06009541 RID: 38209 RVA: 0x0018CB54 File Offset: 0x0018AD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009542 RID: 38210 RVA: 0x0018CB60 File Offset: 0x0018AD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
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

		// Token: 0x040039D4 RID: 14804
		private static readonly MessageParser<PromoteEquipmentCsReq> _parser = new MessageParser<PromoteEquipmentCsReq>(() => new PromoteEquipmentCsReq());

		// Token: 0x040039D5 RID: 14805
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039D6 RID: 14806
		public const int EquipmentUniqueIdFieldNumber = 10;

		// Token: 0x040039D7 RID: 14807
		private uint equipmentUniqueId_;

		// Token: 0x040039D8 RID: 14808
		public const int CostDataFieldNumber = 14;

		// Token: 0x040039D9 RID: 14809
		private ItemCostData costData_;
	}
}
