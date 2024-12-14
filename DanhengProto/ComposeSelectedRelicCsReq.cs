using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000321 RID: 801
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ComposeSelectedRelicCsReq : IMessage<ComposeSelectedRelicCsReq>, IMessage, IEquatable<ComposeSelectedRelicCsReq>, IDeepCloneable<ComposeSelectedRelicCsReq>, IBufferMessage
	{
		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x00065DD3 File Offset: 0x00063FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ComposeSelectedRelicCsReq> Parser
		{
			get
			{
				return ComposeSelectedRelicCsReq._parser;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x00065DDA File Offset: 0x00063FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ComposeSelectedRelicCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x00065DEC File Offset: 0x00063FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ComposeSelectedRelicCsReq.Descriptor;
			}
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00065DF3 File Offset: 0x00063FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeSelectedRelicCsReq()
		{
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00065DFC File Offset: 0x00063FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeSelectedRelicCsReq(ComposeSelectedRelicCsReq other) : this()
		{
			this.composeId_ = other.composeId_;
			this.composeRelicId_ = other.composeRelicId_;
			this.composeItemList_ = ((other.composeItemList_ != null) ? other.composeItemList_.Clone() : null);
			this.count_ = other.count_;
			this.mainAffixId_ = other.mainAffixId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00065E6C File Offset: 0x0006406C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeSelectedRelicCsReq Clone()
		{
			return new ComposeSelectedRelicCsReq(this);
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x00065E74 File Offset: 0x00064074
		// (set) Token: 0x060023EC RID: 9196 RVA: 0x00065E7C File Offset: 0x0006407C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ComposeId
		{
			get
			{
				return this.composeId_;
			}
			set
			{
				this.composeId_ = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x00065E85 File Offset: 0x00064085
		// (set) Token: 0x060023EE RID: 9198 RVA: 0x00065E8D File Offset: 0x0006408D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ComposeRelicId
		{
			get
			{
				return this.composeRelicId_;
			}
			set
			{
				this.composeRelicId_ = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x00065E96 File Offset: 0x00064096
		// (set) Token: 0x060023F0 RID: 9200 RVA: 0x00065E9E File Offset: 0x0006409E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData ComposeItemList
		{
			get
			{
				return this.composeItemList_;
			}
			set
			{
				this.composeItemList_ = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x00065EA7 File Offset: 0x000640A7
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x00065EAF File Offset: 0x000640AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x00065EB8 File Offset: 0x000640B8
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x00065EC0 File Offset: 0x000640C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainAffixId
		{
			get
			{
				return this.mainAffixId_;
			}
			set
			{
				this.mainAffixId_ = value;
			}
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x00065EC9 File Offset: 0x000640C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ComposeSelectedRelicCsReq);
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x00065ED8 File Offset: 0x000640D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ComposeSelectedRelicCsReq other)
		{
			return other != null && (other == this || (this.ComposeId == other.ComposeId && this.ComposeRelicId == other.ComposeRelicId && object.Equals(this.ComposeItemList, other.ComposeItemList) && this.Count == other.Count && this.MainAffixId == other.MainAffixId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x00065F58 File Offset: 0x00064158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ComposeId != 0U)
			{
				num ^= this.ComposeId.GetHashCode();
			}
			if (this.ComposeRelicId != 0U)
			{
				num ^= this.ComposeRelicId.GetHashCode();
			}
			if (this.composeItemList_ != null)
			{
				num ^= this.ComposeItemList.GetHashCode();
			}
			if (this.Count != 0U)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.MainAffixId != 0U)
			{
				num ^= this.MainAffixId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00065FF8 File Offset: 0x000641F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00066000 File Offset: 0x00064200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x0006600C File Offset: 0x0006420C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ComposeRelicId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ComposeRelicId);
			}
			if (this.MainAffixId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MainAffixId);
			}
			if (this.Count != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Count);
			}
			if (this.ComposeId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ComposeId);
			}
			if (this.composeItemList_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ComposeItemList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x000660BC File Offset: 0x000642BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ComposeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ComposeId);
			}
			if (this.ComposeRelicId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ComposeRelicId);
			}
			if (this.composeItemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ComposeItemList);
			}
			if (this.Count != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
			}
			if (this.MainAffixId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainAffixId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x0006615C File Offset: 0x0006435C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ComposeSelectedRelicCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ComposeId != 0U)
			{
				this.ComposeId = other.ComposeId;
			}
			if (other.ComposeRelicId != 0U)
			{
				this.ComposeRelicId = other.ComposeRelicId;
			}
			if (other.composeItemList_ != null)
			{
				if (this.composeItemList_ == null)
				{
					this.ComposeItemList = new ItemCostData();
				}
				this.ComposeItemList.MergeFrom(other.ComposeItemList);
			}
			if (other.Count != 0U)
			{
				this.Count = other.Count;
			}
			if (other.MainAffixId != 0U)
			{
				this.MainAffixId = other.MainAffixId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00066200 File Offset: 0x00064400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0006620C File Offset: 0x0006440C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.ComposeRelicId = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.MainAffixId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Count = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ComposeId = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.composeItemList_ == null)
						{
							this.ComposeItemList = new ItemCostData();
						}
						input.ReadMessage(this.ComposeItemList);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000EB6 RID: 3766
		private static readonly MessageParser<ComposeSelectedRelicCsReq> _parser = new MessageParser<ComposeSelectedRelicCsReq>(() => new ComposeSelectedRelicCsReq());

		// Token: 0x04000EB7 RID: 3767
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EB8 RID: 3768
		public const int ComposeIdFieldNumber = 9;

		// Token: 0x04000EB9 RID: 3769
		private uint composeId_;

		// Token: 0x04000EBA RID: 3770
		public const int ComposeRelicIdFieldNumber = 4;

		// Token: 0x04000EBB RID: 3771
		private uint composeRelicId_;

		// Token: 0x04000EBC RID: 3772
		public const int ComposeItemListFieldNumber = 13;

		// Token: 0x04000EBD RID: 3773
		private ItemCostData composeItemList_;

		// Token: 0x04000EBE RID: 3774
		public const int CountFieldNumber = 7;

		// Token: 0x04000EBF RID: 3775
		private uint count_;

		// Token: 0x04000EC0 RID: 3776
		public const int MainAffixIdFieldNumber = 5;

		// Token: 0x04000EC1 RID: 3777
		private uint mainAffixId_;
	}
}
