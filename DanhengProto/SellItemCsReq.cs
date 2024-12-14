using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010B7 RID: 4279
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SellItemCsReq : IMessage<SellItemCsReq>, IMessage, IEquatable<SellItemCsReq>, IDeepCloneable<SellItemCsReq>, IBufferMessage
	{
		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0600BECE RID: 48846 RVA: 0x00201EC5 File Offset: 0x002000C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SellItemCsReq> Parser
		{
			get
			{
				return SellItemCsReq._parser;
			}
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0600BECF RID: 48847 RVA: 0x00201ECC File Offset: 0x002000CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SellItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0600BED0 RID: 48848 RVA: 0x00201EDE File Offset: 0x002000DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SellItemCsReq.Descriptor;
			}
		}

		// Token: 0x0600BED1 RID: 48849 RVA: 0x00201EE5 File Offset: 0x002000E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SellItemCsReq()
		{
		}

		// Token: 0x0600BED2 RID: 48850 RVA: 0x00201EF0 File Offset: 0x002000F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SellItemCsReq(SellItemCsReq other) : this()
		{
			this.toMaterial_ = other.toMaterial_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BED3 RID: 48851 RVA: 0x00201F3C File Offset: 0x0020013C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SellItemCsReq Clone()
		{
			return new SellItemCsReq(this);
		}

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0600BED4 RID: 48852 RVA: 0x00201F44 File Offset: 0x00200144
		// (set) Token: 0x0600BED5 RID: 48853 RVA: 0x00201F4C File Offset: 0x0020014C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ToMaterial
		{
			get
			{
				return this.toMaterial_;
			}
			set
			{
				this.toMaterial_ = value;
			}
		}

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0600BED6 RID: 48854 RVA: 0x00201F55 File Offset: 0x00200155
		// (set) Token: 0x0600BED7 RID: 48855 RVA: 0x00201F5D File Offset: 0x0020015D
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

		// Token: 0x0600BED8 RID: 48856 RVA: 0x00201F66 File Offset: 0x00200166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SellItemCsReq);
		}

		// Token: 0x0600BED9 RID: 48857 RVA: 0x00201F74 File Offset: 0x00200174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SellItemCsReq other)
		{
			return other != null && (other == this || (this.ToMaterial == other.ToMaterial && object.Equals(this.CostData, other.CostData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEDA RID: 48858 RVA: 0x00201FC4 File Offset: 0x002001C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ToMaterial)
			{
				num ^= this.ToMaterial.GetHashCode();
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

		// Token: 0x0600BEDB RID: 48859 RVA: 0x00202019 File Offset: 0x00200219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BEDC RID: 48860 RVA: 0x00202021 File Offset: 0x00200221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEDD RID: 48861 RVA: 0x0020202C File Offset: 0x0020022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToMaterial)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ToMaterial);
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

		// Token: 0x0600BEDE RID: 48862 RVA: 0x00202084 File Offset: 0x00200284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ToMaterial)
			{
				num += 2;
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

		// Token: 0x0600BEDF RID: 48863 RVA: 0x002020D0 File Offset: 0x002002D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SellItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ToMaterial)
			{
				this.ToMaterial = other.ToMaterial;
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

		// Token: 0x0600BEE0 RID: 48864 RVA: 0x00202138 File Offset: 0x00200338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEE1 RID: 48865 RVA: 0x00202144 File Offset: 0x00200344
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
					this.ToMaterial = input.ReadBool();
				}
			}
		}

		// Token: 0x04004D83 RID: 19843
		private static readonly MessageParser<SellItemCsReq> _parser = new MessageParser<SellItemCsReq>(() => new SellItemCsReq());

		// Token: 0x04004D84 RID: 19844
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D85 RID: 19845
		public const int ToMaterialFieldNumber = 1;

		// Token: 0x04004D86 RID: 19846
		private bool toMaterial_;

		// Token: 0x04004D87 RID: 19847
		public const int CostDataFieldNumber = 14;

		// Token: 0x04004D88 RID: 19848
		private ItemCostData costData_;
	}
}
