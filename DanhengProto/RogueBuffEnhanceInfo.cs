using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E19 RID: 3609
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBuffEnhanceInfo : IMessage<RogueBuffEnhanceInfo>, IMessage, IEquatable<RogueBuffEnhanceInfo>, IDeepCloneable<RogueBuffEnhanceInfo>, IBufferMessage
	{
		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x0600A12F RID: 41263 RVA: 0x001B0307 File Offset: 0x001AE507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBuffEnhanceInfo> Parser
		{
			get
			{
				return RogueBuffEnhanceInfo._parser;
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x0600A130 RID: 41264 RVA: 0x001B030E File Offset: 0x001AE50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBuffEnhanceInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x0600A131 RID: 41265 RVA: 0x001B0320 File Offset: 0x001AE520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBuffEnhanceInfo.Descriptor;
			}
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x001B0327 File Offset: 0x001AE527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffEnhanceInfo()
		{
		}

		// Token: 0x0600A133 RID: 41267 RVA: 0x001B0330 File Offset: 0x001AE530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffEnhanceInfo(RogueBuffEnhanceInfo other) : this()
		{
			this.buffId_ = other.buffId_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this.mAAHFKMKMMI_ = other.mAAHFKMKMMI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A134 RID: 41268 RVA: 0x001B0388 File Offset: 0x001AE588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffEnhanceInfo Clone()
		{
			return new RogueBuffEnhanceInfo(this);
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x0600A135 RID: 41269 RVA: 0x001B0390 File Offset: 0x001AE590
		// (set) Token: 0x0600A136 RID: 41270 RVA: 0x001B0398 File Offset: 0x001AE598
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

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x0600A137 RID: 41271 RVA: 0x001B03A1 File Offset: 0x001AE5A1
		// (set) Token: 0x0600A138 RID: 41272 RVA: 0x001B03A9 File Offset: 0x001AE5A9
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

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0600A139 RID: 41273 RVA: 0x001B03B2 File Offset: 0x001AE5B2
		// (set) Token: 0x0600A13A RID: 41274 RVA: 0x001B03BA File Offset: 0x001AE5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float MAAHFKMKMMI
		{
			get
			{
				return this.mAAHFKMKMMI_;
			}
			set
			{
				this.mAAHFKMKMMI_ = value;
			}
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x001B03C3 File Offset: 0x001AE5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBuffEnhanceInfo);
		}

		// Token: 0x0600A13C RID: 41276 RVA: 0x001B03D4 File Offset: 0x001AE5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBuffEnhanceInfo other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && object.Equals(this.CostData, other.CostData) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MAAHFKMKMMI, other.MAAHFKMKMMI) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A13D RID: 41277 RVA: 0x001B043C File Offset: 0x001AE63C
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
			if (this.MAAHFKMKMMI != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MAAHFKMKMMI);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A13E RID: 41278 RVA: 0x001B04B1 File Offset: 0x001AE6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A13F RID: 41279 RVA: 0x001B04B9 File Offset: 0x001AE6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x001B04C4 File Offset: 0x001AE6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MAAHFKMKMMI != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.MAAHFKMKMMI);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CostData);
			}
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x001B0540 File Offset: 0x001AE740
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
			if (this.MAAHFKMKMMI != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A142 RID: 41282 RVA: 0x001B05A8 File Offset: 0x001AE7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBuffEnhanceInfo other)
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
			if (other.MAAHFKMKMMI != 0f)
			{
				this.MAAHFKMKMMI = other.MAAHFKMKMMI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A143 RID: 41283 RVA: 0x001B0629 File Offset: 0x001AE829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A144 RID: 41284 RVA: 0x001B0634 File Offset: 0x001AE834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 29U)
				{
					if (num != 34U)
					{
						if (num != 40U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BuffId = input.ReadUInt32();
						}
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
					this.MAAHFKMKMMI = input.ReadFloat();
				}
			}
		}

		// Token: 0x040041FD RID: 16893
		private static readonly MessageParser<RogueBuffEnhanceInfo> _parser = new MessageParser<RogueBuffEnhanceInfo>(() => new RogueBuffEnhanceInfo());

		// Token: 0x040041FE RID: 16894
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041FF RID: 16895
		public const int BuffIdFieldNumber = 5;

		// Token: 0x04004200 RID: 16896
		private uint buffId_;

		// Token: 0x04004201 RID: 16897
		public const int CostDataFieldNumber = 4;

		// Token: 0x04004202 RID: 16898
		private ItemCostData costData_;

		// Token: 0x04004203 RID: 16899
		public const int MAAHFKMKMMIFieldNumber = 3;

		// Token: 0x04004204 RID: 16900
		private float mAAHFKMKMMI_;
	}
}
