using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001445 RID: 5189
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchReforgeFormulaFuncInfo : IMessage<WorkbenchReforgeFormulaFuncInfo>, IMessage, IEquatable<WorkbenchReforgeFormulaFuncInfo>, IDeepCloneable<WorkbenchReforgeFormulaFuncInfo>, IBufferMessage
	{
		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x0600E792 RID: 59282 RVA: 0x00267B53 File Offset: 0x00265D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchReforgeFormulaFuncInfo> Parser
		{
			get
			{
				return WorkbenchReforgeFormulaFuncInfo._parser;
			}
		}

		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x0600E793 RID: 59283 RVA: 0x00267B5A File Offset: 0x00265D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchReforgeFormulaFuncInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004104 RID: 16644
		// (get) Token: 0x0600E794 RID: 59284 RVA: 0x00267B6C File Offset: 0x00265D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchReforgeFormulaFuncInfo.Descriptor;
			}
		}

		// Token: 0x0600E795 RID: 59285 RVA: 0x00267B73 File Offset: 0x00265D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeFormulaFuncInfo()
		{
		}

		// Token: 0x0600E796 RID: 59286 RVA: 0x00267B7C File Offset: 0x00265D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeFormulaFuncInfo(WorkbenchReforgeFormulaFuncInfo other) : this()
		{
			this.uintReforgeNumValue_ = other.uintReforgeNumValue_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this.intReforgeNumValue_ = other.intReforgeNumValue_;
			this.canFreeReforge_ = other.canFreeReforge_;
			this.freeReforgeNum_ = other.freeReforgeNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E797 RID: 59287 RVA: 0x00267BEC File Offset: 0x00265DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeFormulaFuncInfo Clone()
		{
			return new WorkbenchReforgeFormulaFuncInfo(this);
		}

		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x0600E798 RID: 59288 RVA: 0x00267BF4 File Offset: 0x00265DF4
		// (set) Token: 0x0600E799 RID: 59289 RVA: 0x00267BFC File Offset: 0x00265DFC
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

		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x0600E79A RID: 59290 RVA: 0x00267C05 File Offset: 0x00265E05
		// (set) Token: 0x0600E79B RID: 59291 RVA: 0x00267C0D File Offset: 0x00265E0D
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

		// Token: 0x17004107 RID: 16647
		// (get) Token: 0x0600E79C RID: 59292 RVA: 0x00267C16 File Offset: 0x00265E16
		// (set) Token: 0x0600E79D RID: 59293 RVA: 0x00267C1E File Offset: 0x00265E1E
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

		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x0600E79E RID: 59294 RVA: 0x00267C27 File Offset: 0x00265E27
		// (set) Token: 0x0600E79F RID: 59295 RVA: 0x00267C2F File Offset: 0x00265E2F
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

		// Token: 0x17004109 RID: 16649
		// (get) Token: 0x0600E7A0 RID: 59296 RVA: 0x00267C38 File Offset: 0x00265E38
		// (set) Token: 0x0600E7A1 RID: 59297 RVA: 0x00267C40 File Offset: 0x00265E40
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

		// Token: 0x0600E7A2 RID: 59298 RVA: 0x00267C49 File Offset: 0x00265E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchReforgeFormulaFuncInfo);
		}

		// Token: 0x0600E7A3 RID: 59299 RVA: 0x00267C58 File Offset: 0x00265E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchReforgeFormulaFuncInfo other)
		{
			return other != null && (other == this || (this.UintReforgeNumValue == other.UintReforgeNumValue && object.Equals(this.CostData, other.CostData) && this.IntReforgeNumValue == other.IntReforgeNumValue && this.CanFreeReforge == other.CanFreeReforge && this.FreeReforgeNum == other.FreeReforgeNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7A4 RID: 59300 RVA: 0x00267CD8 File Offset: 0x00265ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UintReforgeNumValue != 0U)
			{
				num ^= this.UintReforgeNumValue.GetHashCode();
			}
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
			}
			if (this.IntReforgeNumValue != 0)
			{
				num ^= this.IntReforgeNumValue.GetHashCode();
			}
			if (this.CanFreeReforge)
			{
				num ^= this.CanFreeReforge.GetHashCode();
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

		// Token: 0x0600E7A5 RID: 59301 RVA: 0x00267D78 File Offset: 0x00265F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E7A6 RID: 59302 RVA: 0x00267D80 File Offset: 0x00265F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7A7 RID: 59303 RVA: 0x00267D8C File Offset: 0x00265F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IntReforgeNumValue != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IntReforgeNumValue);
			}
			if (this.UintReforgeNumValue != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.UintReforgeNumValue);
			}
			if (this.CanFreeReforge)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.CanFreeReforge);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CostData);
			}
			if (this.FreeReforgeNum != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.FreeReforgeNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7A8 RID: 59304 RVA: 0x00267E3C File Offset: 0x0026603C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UintReforgeNumValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UintReforgeNumValue);
			}
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
			}
			if (this.IntReforgeNumValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IntReforgeNumValue);
			}
			if (this.CanFreeReforge)
			{
				num += 2;
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

		// Token: 0x0600E7A9 RID: 59305 RVA: 0x00267ED0 File Offset: 0x002660D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchReforgeFormulaFuncInfo other)
		{
			if (other == null)
			{
				return;
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
			if (other.IntReforgeNumValue != 0)
			{
				this.IntReforgeNumValue = other.IntReforgeNumValue;
			}
			if (other.CanFreeReforge)
			{
				this.CanFreeReforge = other.CanFreeReforge;
			}
			if (other.FreeReforgeNum != 0U)
			{
				this.FreeReforgeNum = other.FreeReforgeNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E7AA RID: 59306 RVA: 0x00267F74 File Offset: 0x00266174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7AB RID: 59307 RVA: 0x00267F80 File Offset: 0x00266180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.IntReforgeNumValue = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.UintReforgeNumValue = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.CanFreeReforge = input.ReadBool();
						continue;
					}
					if (num == 106U)
					{
						if (this.costData_ == null)
						{
							this.CostData = new ItemCostData();
						}
						input.ReadMessage(this.CostData);
						continue;
					}
					if (num == 112U)
					{
						this.FreeReforgeNum = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005BE2 RID: 23522
		private static readonly MessageParser<WorkbenchReforgeFormulaFuncInfo> _parser = new MessageParser<WorkbenchReforgeFormulaFuncInfo>(() => new WorkbenchReforgeFormulaFuncInfo());

		// Token: 0x04005BE3 RID: 23523
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BE4 RID: 23524
		public const int UintReforgeNumValueFieldNumber = 7;

		// Token: 0x04005BE5 RID: 23525
		private uint uintReforgeNumValue_;

		// Token: 0x04005BE6 RID: 23526
		public const int CostDataFieldNumber = 13;

		// Token: 0x04005BE7 RID: 23527
		private ItemCostData costData_;

		// Token: 0x04005BE8 RID: 23528
		public const int IntReforgeNumValueFieldNumber = 2;

		// Token: 0x04005BE9 RID: 23529
		private int intReforgeNumValue_;

		// Token: 0x04005BEA RID: 23530
		public const int CanFreeReforgeFieldNumber = 10;

		// Token: 0x04005BEB RID: 23531
		private bool canFreeReforge_;

		// Token: 0x04005BEC RID: 23532
		public const int FreeReforgeNumFieldNumber = 14;

		// Token: 0x04005BED RID: 23533
		private uint freeReforgeNum_;
	}
}
