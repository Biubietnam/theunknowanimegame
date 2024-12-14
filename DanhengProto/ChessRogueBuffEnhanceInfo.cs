using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001E7 RID: 487
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueBuffEnhanceInfo : IMessage<ChessRogueBuffEnhanceInfo>, IMessage, IEquatable<ChessRogueBuffEnhanceInfo>, IDeepCloneable<ChessRogueBuffEnhanceInfo>, IBufferMessage
	{
		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x0003E959 File Offset: 0x0003CB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueBuffEnhanceInfo> Parser
		{
			get
			{
				return ChessRogueBuffEnhanceInfo._parser;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x0003E960 File Offset: 0x0003CB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueBuffEnhanceInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x0003E972 File Offset: 0x0003CB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueBuffEnhanceInfo.Descriptor;
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0003E979 File Offset: 0x0003CB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffEnhanceInfo()
		{
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0003E984 File Offset: 0x0003CB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffEnhanceInfo(ChessRogueBuffEnhanceInfo other) : this()
		{
			this.buffId_ = other.buffId_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0003E9D0 File Offset: 0x0003CBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffEnhanceInfo Clone()
		{
			return new ChessRogueBuffEnhanceInfo(this);
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x0003E9D8 File Offset: 0x0003CBD8
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x0003E9E0 File Offset: 0x0003CBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x0003E9E9 File Offset: 0x0003CBE9
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x0003E9F1 File Offset: 0x0003CBF1
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

		// Token: 0x060015D0 RID: 5584 RVA: 0x0003E9FA File Offset: 0x0003CBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueBuffEnhanceInfo);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0003EA08 File Offset: 0x0003CC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueBuffEnhanceInfo other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && object.Equals(this.CostData, other.CostData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0003EA58 File Offset: 0x0003CC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
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

		// Token: 0x060015D3 RID: 5587 RVA: 0x0003EAAD File Offset: 0x0003CCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x0003EAB5 File Offset: 0x0003CCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0003EAC0 File Offset: 0x0003CCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.BuffId);
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

		// Token: 0x060015D6 RID: 5590 RVA: 0x0003EB1C File Offset: 0x0003CD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
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

		// Token: 0x060015D7 RID: 5591 RVA: 0x0003EB74 File Offset: 0x0003CD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueBuffEnhanceInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
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

		// Token: 0x060015D8 RID: 5592 RVA: 0x0003EBDC File Offset: 0x0003CDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x0003EBE8 File Offset: 0x0003CDE8
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
					this.BuffId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000932 RID: 2354
		private static readonly MessageParser<ChessRogueBuffEnhanceInfo> _parser = new MessageParser<ChessRogueBuffEnhanceInfo>(() => new ChessRogueBuffEnhanceInfo());

		// Token: 0x04000933 RID: 2355
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000934 RID: 2356
		public const int BuffIdFieldNumber = 10;

		// Token: 0x04000935 RID: 2357
		private uint buffId_;

		// Token: 0x04000936 RID: 2358
		public const int CostDataFieldNumber = 14;

		// Token: 0x04000937 RID: 2359
		private ItemCostData costData_;
	}
}
