using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004ED RID: 1261
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExpUpRelicCsReq : IMessage<ExpUpRelicCsReq>, IMessage, IEquatable<ExpUpRelicCsReq>, IDeepCloneable<ExpUpRelicCsReq>, IBufferMessage
	{
		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x0009A845 File Offset: 0x00098A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpUpRelicCsReq> Parser
		{
			get
			{
				return ExpUpRelicCsReq._parser;
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06003866 RID: 14438 RVA: 0x0009A84C File Offset: 0x00098A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExpUpRelicCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x0009A85E File Offset: 0x00098A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpUpRelicCsReq.Descriptor;
			}
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x0009A865 File Offset: 0x00098A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpRelicCsReq()
		{
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x0009A870 File Offset: 0x00098A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpRelicCsReq(ExpUpRelicCsReq other) : this()
		{
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this.relicUniqueId_ = other.relicUniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x0009A8BC File Offset: 0x00098ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpRelicCsReq Clone()
		{
			return new ExpUpRelicCsReq(this);
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x0009A8C4 File Offset: 0x00098AC4
		// (set) Token: 0x0600386C RID: 14444 RVA: 0x0009A8CC File Offset: 0x00098ACC
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

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x0600386D RID: 14445 RVA: 0x0009A8D5 File Offset: 0x00098AD5
		// (set) Token: 0x0600386E RID: 14446 RVA: 0x0009A8DD File Offset: 0x00098ADD
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

		// Token: 0x0600386F RID: 14447 RVA: 0x0009A8E6 File Offset: 0x00098AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpUpRelicCsReq);
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x0009A8F4 File Offset: 0x00098AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpUpRelicCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.CostData, other.CostData) && this.RelicUniqueId == other.RelicUniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x0009A944 File Offset: 0x00098B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
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

		// Token: 0x06003872 RID: 14450 RVA: 0x0009A999 File Offset: 0x00098B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x0009A9A1 File Offset: 0x00098BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x0009A9AC File Offset: 0x00098BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RelicUniqueId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.RelicUniqueId);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CostData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x0009AA08 File Offset: 0x00098C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
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

		// Token: 0x06003876 RID: 14454 RVA: 0x0009AA60 File Offset: 0x00098C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExpUpRelicCsReq other)
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
			if (other.RelicUniqueId != 0U)
			{
				this.RelicUniqueId = other.RelicUniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x0009AAC8 File Offset: 0x00098CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x0009AAD4 File Offset: 0x00098CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 90U)
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
					this.RelicUniqueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001650 RID: 5712
		private static readonly MessageParser<ExpUpRelicCsReq> _parser = new MessageParser<ExpUpRelicCsReq>(() => new ExpUpRelicCsReq());

		// Token: 0x04001651 RID: 5713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001652 RID: 5714
		public const int CostDataFieldNumber = 11;

		// Token: 0x04001653 RID: 5715
		private ItemCostData costData_;

		// Token: 0x04001654 RID: 5716
		public const int RelicUniqueIdFieldNumber = 10;

		// Token: 0x04001655 RID: 5717
		private uint relicUniqueId_;
	}
}
