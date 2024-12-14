using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001441 RID: 5185
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchReforgeBuffFuncInfo : IMessage<WorkbenchReforgeBuffFuncInfo>, IMessage, IEquatable<WorkbenchReforgeBuffFuncInfo>, IDeepCloneable<WorkbenchReforgeBuffFuncInfo>, IBufferMessage
	{
		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x0600E760 RID: 59232 RVA: 0x00267327 File Offset: 0x00265527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchReforgeBuffFuncInfo> Parser
		{
			get
			{
				return WorkbenchReforgeBuffFuncInfo._parser;
			}
		}

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x0600E761 RID: 59233 RVA: 0x0026732E File Offset: 0x0026552E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchReforgeBuffFuncInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x0600E762 RID: 59234 RVA: 0x00267340 File Offset: 0x00265540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchReforgeBuffFuncInfo.Descriptor;
			}
		}

		// Token: 0x0600E763 RID: 59235 RVA: 0x00267347 File Offset: 0x00265547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeBuffFuncInfo()
		{
		}

		// Token: 0x0600E764 RID: 59236 RVA: 0x00267350 File Offset: 0x00265550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeBuffFuncInfo(WorkbenchReforgeBuffFuncInfo other) : this()
		{
			this.canFreeReforge_ = other.canFreeReforge_;
			this.intReforgeNumValue_ = other.intReforgeNumValue_;
			this.uintReforgeNumValue_ = other.uintReforgeNumValue_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this.freeReforgeNum_ = other.freeReforgeNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E765 RID: 59237 RVA: 0x002673C0 File Offset: 0x002655C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeBuffFuncInfo Clone()
		{
			return new WorkbenchReforgeBuffFuncInfo(this);
		}

		// Token: 0x170040F7 RID: 16631
		// (get) Token: 0x0600E766 RID: 59238 RVA: 0x002673C8 File Offset: 0x002655C8
		// (set) Token: 0x0600E767 RID: 59239 RVA: 0x002673D0 File Offset: 0x002655D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanFreeReforge
		{
			get
			{
				return this.canFreeReforge_;
			}
			set
			{
				this.canFreeReforge_ = value;
			}
		}

		// Token: 0x170040F8 RID: 16632
		// (get) Token: 0x0600E768 RID: 59240 RVA: 0x002673D9 File Offset: 0x002655D9
		// (set) Token: 0x0600E769 RID: 59241 RVA: 0x002673E1 File Offset: 0x002655E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IntReforgeNumValue
		{
			get
			{
				return this.intReforgeNumValue_;
			}
			set
			{
				this.intReforgeNumValue_ = value;
			}
		}

		// Token: 0x170040F9 RID: 16633
		// (get) Token: 0x0600E76A RID: 59242 RVA: 0x002673EA File Offset: 0x002655EA
		// (set) Token: 0x0600E76B RID: 59243 RVA: 0x002673F2 File Offset: 0x002655F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UintReforgeNumValue
		{
			get
			{
				return this.uintReforgeNumValue_;
			}
			set
			{
				this.uintReforgeNumValue_ = value;
			}
		}

		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x0600E76C RID: 59244 RVA: 0x002673FB File Offset: 0x002655FB
		// (set) Token: 0x0600E76D RID: 59245 RVA: 0x00267403 File Offset: 0x00265603
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

		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x0600E76E RID: 59246 RVA: 0x0026740C File Offset: 0x0026560C
		// (set) Token: 0x0600E76F RID: 59247 RVA: 0x00267414 File Offset: 0x00265614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FreeReforgeNum
		{
			get
			{
				return this.freeReforgeNum_;
			}
			set
			{
				this.freeReforgeNum_ = value;
			}
		}

		// Token: 0x0600E770 RID: 59248 RVA: 0x0026741D File Offset: 0x0026561D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchReforgeBuffFuncInfo);
		}

		// Token: 0x0600E771 RID: 59249 RVA: 0x0026742C File Offset: 0x0026562C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchReforgeBuffFuncInfo other)
		{
			return other != null && (other == this || (this.CanFreeReforge == other.CanFreeReforge && this.IntReforgeNumValue == other.IntReforgeNumValue && this.UintReforgeNumValue == other.UintReforgeNumValue && object.Equals(this.CostData, other.CostData) && this.FreeReforgeNum == other.FreeReforgeNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E772 RID: 59250 RVA: 0x002674AC File Offset: 0x002656AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CanFreeReforge)
			{
				num ^= this.CanFreeReforge.GetHashCode();
			}
			if (this.IntReforgeNumValue != 0)
			{
				num ^= this.IntReforgeNumValue.GetHashCode();
			}
			if (this.UintReforgeNumValue != 0U)
			{
				num ^= this.UintReforgeNumValue.GetHashCode();
			}
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
			}
			if (this.FreeReforgeNum != 0U)
			{
				num ^= this.FreeReforgeNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E773 RID: 59251 RVA: 0x0026754C File Offset: 0x0026574C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E774 RID: 59252 RVA: 0x00267554 File Offset: 0x00265754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E775 RID: 59253 RVA: 0x00267560 File Offset: 0x00265760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CanFreeReforge)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.CanFreeReforge);
			}
			if (this.IntReforgeNumValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IntReforgeNumValue);
			}
			if (this.FreeReforgeNum != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.FreeReforgeNum);
			}
			if (this.UintReforgeNumValue != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.UintReforgeNumValue);
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

		// Token: 0x0600E776 RID: 59254 RVA: 0x0026760C File Offset: 0x0026580C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CanFreeReforge)
			{
				num += 2;
			}
			if (this.IntReforgeNumValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IntReforgeNumValue);
			}
			if (this.UintReforgeNumValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UintReforgeNumValue);
			}
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
			}
			if (this.FreeReforgeNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FreeReforgeNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E777 RID: 59255 RVA: 0x002676A0 File Offset: 0x002658A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchReforgeBuffFuncInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CanFreeReforge)
			{
				this.CanFreeReforge = other.CanFreeReforge;
			}
			if (other.IntReforgeNumValue != 0)
			{
				this.IntReforgeNumValue = other.IntReforgeNumValue;
			}
			if (other.UintReforgeNumValue != 0U)
			{
				this.UintReforgeNumValue = other.UintReforgeNumValue;
			}
			if (other.costData_ != null)
			{
				if (this.costData_ == null)
				{
					this.CostData = new ItemCostData();
				}
				this.CostData.MergeFrom(other.CostData);
			}
			if (other.FreeReforgeNum != 0U)
			{
				this.FreeReforgeNum = other.FreeReforgeNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E778 RID: 59256 RVA: 0x00267744 File Offset: 0x00265944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E779 RID: 59257 RVA: 0x00267750 File Offset: 0x00265950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.CanFreeReforge = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.IntReforgeNumValue = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.FreeReforgeNum = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.UintReforgeNumValue = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.costData_ == null)
						{
							this.CostData = new ItemCostData();
						}
						input.ReadMessage(this.CostData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005BD0 RID: 23504
		private static readonly MessageParser<WorkbenchReforgeBuffFuncInfo> _parser = new MessageParser<WorkbenchReforgeBuffFuncInfo>(() => new WorkbenchReforgeBuffFuncInfo());

		// Token: 0x04005BD1 RID: 23505
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BD2 RID: 23506
		public const int CanFreeReforgeFieldNumber = 1;

		// Token: 0x04005BD3 RID: 23507
		private bool canFreeReforge_;

		// Token: 0x04005BD4 RID: 23508
		public const int IntReforgeNumValueFieldNumber = 3;

		// Token: 0x04005BD5 RID: 23509
		private int intReforgeNumValue_;

		// Token: 0x04005BD6 RID: 23510
		public const int UintReforgeNumValueFieldNumber = 12;

		// Token: 0x04005BD7 RID: 23511
		private uint uintReforgeNumValue_;

		// Token: 0x04005BD8 RID: 23512
		public const int CostDataFieldNumber = 14;

		// Token: 0x04005BD9 RID: 23513
		private ItemCostData costData_;

		// Token: 0x04005BDA RID: 23514
		public const int FreeReforgeNumFieldNumber = 9;

		// Token: 0x04005BDB RID: 23515
		private uint freeReforgeNum_;
	}
}
