using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001435 RID: 5173
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchComposeMiracleFunc : IMessage<WorkbenchComposeMiracleFunc>, IMessage, IEquatable<WorkbenchComposeMiracleFunc>, IDeepCloneable<WorkbenchComposeMiracleFunc>, IBufferMessage
	{
		// Token: 0x170040C7 RID: 16583
		// (get) Token: 0x0600E6C7 RID: 59079 RVA: 0x0026557C File Offset: 0x0026377C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchComposeMiracleFunc> Parser
		{
			get
			{
				return WorkbenchComposeMiracleFunc._parser;
			}
		}

		// Token: 0x170040C8 RID: 16584
		// (get) Token: 0x0600E6C8 RID: 59080 RVA: 0x00265583 File Offset: 0x00263783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchComposeMiracleFuncReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040C9 RID: 16585
		// (get) Token: 0x0600E6C9 RID: 59081 RVA: 0x00265595 File Offset: 0x00263795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchComposeMiracleFunc.Descriptor;
			}
		}

		// Token: 0x0600E6CA RID: 59082 RVA: 0x0026559C File Offset: 0x0026379C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchComposeMiracleFunc()
		{
		}

		// Token: 0x0600E6CB RID: 59083 RVA: 0x002655B0 File Offset: 0x002637B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchComposeMiracleFunc(WorkbenchComposeMiracleFunc other) : this()
		{
			this.intReforgeNumValue_ = other.intReforgeNumValue_;
			this.freeReforgeNum_ = other.freeReforgeNum_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this.allowToComposeMap_ = other.allowToComposeMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E6CC RID: 59084 RVA: 0x00265619 File Offset: 0x00263819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchComposeMiracleFunc Clone()
		{
			return new WorkbenchComposeMiracleFunc(this);
		}

		// Token: 0x170040CA RID: 16586
		// (get) Token: 0x0600E6CD RID: 59085 RVA: 0x00265621 File Offset: 0x00263821
		// (set) Token: 0x0600E6CE RID: 59086 RVA: 0x00265629 File Offset: 0x00263829
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

		// Token: 0x170040CB RID: 16587
		// (get) Token: 0x0600E6CF RID: 59087 RVA: 0x00265632 File Offset: 0x00263832
		// (set) Token: 0x0600E6D0 RID: 59088 RVA: 0x0026563A File Offset: 0x0026383A
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

		// Token: 0x170040CC RID: 16588
		// (get) Token: 0x0600E6D1 RID: 59089 RVA: 0x00265643 File Offset: 0x00263843
		// (set) Token: 0x0600E6D2 RID: 59090 RVA: 0x0026564B File Offset: 0x0026384B
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

		// Token: 0x170040CD RID: 16589
		// (get) Token: 0x0600E6D3 RID: 59091 RVA: 0x00265654 File Offset: 0x00263854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, bool> AllowToComposeMap
		{
			get
			{
				return this.allowToComposeMap_;
			}
		}

		// Token: 0x0600E6D4 RID: 59092 RVA: 0x0026565C File Offset: 0x0026385C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchComposeMiracleFunc);
		}

		// Token: 0x0600E6D5 RID: 59093 RVA: 0x0026566C File Offset: 0x0026386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchComposeMiracleFunc other)
		{
			return other != null && (other == this || (this.IntReforgeNumValue == other.IntReforgeNumValue && this.FreeReforgeNum == other.FreeReforgeNum && object.Equals(this.CostData, other.CostData) && this.AllowToComposeMap.Equals(other.AllowToComposeMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6D6 RID: 59094 RVA: 0x002656E0 File Offset: 0x002638E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IntReforgeNumValue != 0)
			{
				num ^= this.IntReforgeNumValue.GetHashCode();
			}
			if (this.FreeReforgeNum != 0U)
			{
				num ^= this.FreeReforgeNum.GetHashCode();
			}
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
			}
			num ^= this.AllowToComposeMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E6D7 RID: 59095 RVA: 0x0026575C File Offset: 0x0026395C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E6D8 RID: 59096 RVA: 0x00265764 File Offset: 0x00263964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6D9 RID: 59097 RVA: 0x00265770 File Offset: 0x00263970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.allowToComposeMap_.WriteTo(ref output, WorkbenchComposeMiracleFunc._map_allowToComposeMap_codec);
			if (this.IntReforgeNumValue != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IntReforgeNumValue);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.CostData);
			}
			if (this.FreeReforgeNum != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.FreeReforgeNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6DA RID: 59098 RVA: 0x002657F8 File Offset: 0x002639F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IntReforgeNumValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IntReforgeNumValue);
			}
			if (this.FreeReforgeNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FreeReforgeNum);
			}
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
			}
			num += this.allowToComposeMap_.CalculateSize(WorkbenchComposeMiracleFunc._map_allowToComposeMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E6DB RID: 59099 RVA: 0x0026587C File Offset: 0x00263A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchComposeMiracleFunc other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IntReforgeNumValue != 0)
			{
				this.IntReforgeNumValue = other.IntReforgeNumValue;
			}
			if (other.FreeReforgeNum != 0U)
			{
				this.FreeReforgeNum = other.FreeReforgeNum;
			}
			if (other.costData_ != null)
			{
				if (this.costData_ == null)
				{
					this.CostData = new ItemCostData();
				}
				this.CostData.MergeFrom(other.CostData);
			}
			this.allowToComposeMap_.MergeFrom(other.allowToComposeMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E6DC RID: 59100 RVA: 0x00265909 File Offset: 0x00263B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6DD RID: 59101 RVA: 0x00265914 File Offset: 0x00263B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num == 66U)
					{
						this.allowToComposeMap_.AddEntriesFrom(ref input, WorkbenchComposeMiracleFunc._map_allowToComposeMap_codec);
						continue;
					}
					if (num == 88U)
					{
						this.IntReforgeNumValue = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.costData_ == null)
						{
							this.CostData = new ItemCostData();
						}
						input.ReadMessage(this.CostData);
						continue;
					}
					if (num == 120U)
					{
						this.FreeReforgeNum = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005B91 RID: 23441
		private static readonly MessageParser<WorkbenchComposeMiracleFunc> _parser = new MessageParser<WorkbenchComposeMiracleFunc>(() => new WorkbenchComposeMiracleFunc());

		// Token: 0x04005B92 RID: 23442
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B93 RID: 23443
		public const int IntReforgeNumValueFieldNumber = 11;

		// Token: 0x04005B94 RID: 23444
		private int intReforgeNumValue_;

		// Token: 0x04005B95 RID: 23445
		public const int FreeReforgeNumFieldNumber = 15;

		// Token: 0x04005B96 RID: 23446
		private uint freeReforgeNum_;

		// Token: 0x04005B97 RID: 23447
		public const int CostDataFieldNumber = 12;

		// Token: 0x04005B98 RID: 23448
		private ItemCostData costData_;

		// Token: 0x04005B99 RID: 23449
		public const int AllowToComposeMapFieldNumber = 8;

		// Token: 0x04005B9A RID: 23450
		private static readonly MapField<uint, bool>.Codec _map_allowToComposeMap_codec = new MapField<uint, bool>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForBool(16U, false), 66U);

		// Token: 0x04005B9B RID: 23451
		private readonly MapField<uint, bool> allowToComposeMap_ = new MapField<uint, bool>();
	}
}
