using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000A1 RID: 161
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AMMDINMBHPF : IMessage<AMMDINMBHPF>, IMessage, IEquatable<AMMDINMBHPF>, IDeepCloneable<AMMDINMBHPF>, IBufferMessage
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x000134DD File Offset: 0x000116DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AMMDINMBHPF> Parser
		{
			get
			{
				return AMMDINMBHPF._parser;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x000134E4 File Offset: 0x000116E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AMMDINMBHPFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000134F6 File Offset: 0x000116F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AMMDINMBHPF.Descriptor;
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000134FD File Offset: 0x000116FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AMMDINMBHPF()
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00013508 File Offset: 0x00011708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AMMDINMBHPF(AMMDINMBHPF other) : this()
		{
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this.scepterId_ = other.scepterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00013554 File Offset: 0x00011754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AMMDINMBHPF Clone()
		{
			return new AMMDINMBHPF(this);
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001355C File Offset: 0x0001175C
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00013564 File Offset: 0x00011764
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0001356D File Offset: 0x0001176D
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00013575 File Offset: 0x00011775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScepterId
		{
			get
			{
				return this.scepterId_;
			}
			set
			{
				this.scepterId_ = value;
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001357E File Offset: 0x0001177E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AMMDINMBHPF);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0001358C File Offset: 0x0001178C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AMMDINMBHPF other)
		{
			return other != null && (other == this || (object.Equals(this.CostData, other.CostData) && this.ScepterId == other.ScepterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000135DC File Offset: 0x000117DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
			}
			if (this.ScepterId != 0U)
			{
				num ^= this.ScepterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00013631 File Offset: 0x00011831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00013639 File Offset: 0x00011839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00013644 File Offset: 0x00011844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScepterId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ScepterId);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CostData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000136A0 File Offset: 0x000118A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
			}
			if (this.ScepterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScepterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000136F8 File Offset: 0x000118F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AMMDINMBHPF other)
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
			if (other.ScepterId != 0U)
			{
				this.ScepterId = other.ScepterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00013760 File Offset: 0x00011960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0001376C File Offset: 0x0001196C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 106U)
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
					this.ScepterId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000285 RID: 645
		private static readonly MessageParser<AMMDINMBHPF> _parser = new MessageParser<AMMDINMBHPF>(() => new AMMDINMBHPF());

		// Token: 0x04000286 RID: 646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000287 RID: 647
		public const int CostDataFieldNumber = 13;

		// Token: 0x04000288 RID: 648
		private ItemCostData costData_;

		// Token: 0x04000289 RID: 649
		public const int ScepterIdFieldNumber = 12;

		// Token: 0x0400028A RID: 650
		private uint scepterId_;
	}
}
