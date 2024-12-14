using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001449 RID: 5193
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchReforgeHexAvatarFunc : IMessage<WorkbenchReforgeHexAvatarFunc>, IMessage, IEquatable<WorkbenchReforgeHexAvatarFunc>, IDeepCloneable<WorkbenchReforgeHexAvatarFunc>, IBufferMessage
	{
		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x0600E7C4 RID: 59332 RVA: 0x00268367 File Offset: 0x00266567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchReforgeHexAvatarFunc> Parser
		{
			get
			{
				return WorkbenchReforgeHexAvatarFunc._parser;
			}
		}

		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x0600E7C5 RID: 59333 RVA: 0x0026836E File Offset: 0x0026656E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchReforgeHexAvatarFuncReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x0600E7C6 RID: 59334 RVA: 0x00268380 File Offset: 0x00266580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchReforgeHexAvatarFunc.Descriptor;
			}
		}

		// Token: 0x0600E7C7 RID: 59335 RVA: 0x00268387 File Offset: 0x00266587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeHexAvatarFunc()
		{
		}

		// Token: 0x0600E7C8 RID: 59336 RVA: 0x00268390 File Offset: 0x00266590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeHexAvatarFunc(WorkbenchReforgeHexAvatarFunc other) : this()
		{
			this.freeReforgeNum_ = other.freeReforgeNum_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this.intReforgeNumValue_ = other.intReforgeNumValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E7C9 RID: 59337 RVA: 0x002683E8 File Offset: 0x002665E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeHexAvatarFunc Clone()
		{
			return new WorkbenchReforgeHexAvatarFunc(this);
		}

		// Token: 0x17004113 RID: 16659
		// (get) Token: 0x0600E7CA RID: 59338 RVA: 0x002683F0 File Offset: 0x002665F0
		// (set) Token: 0x0600E7CB RID: 59339 RVA: 0x002683F8 File Offset: 0x002665F8
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

		// Token: 0x17004114 RID: 16660
		// (get) Token: 0x0600E7CC RID: 59340 RVA: 0x00268401 File Offset: 0x00266601
		// (set) Token: 0x0600E7CD RID: 59341 RVA: 0x00268409 File Offset: 0x00266609
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

		// Token: 0x17004115 RID: 16661
		// (get) Token: 0x0600E7CE RID: 59342 RVA: 0x00268412 File Offset: 0x00266612
		// (set) Token: 0x0600E7CF RID: 59343 RVA: 0x0026841A File Offset: 0x0026661A
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

		// Token: 0x0600E7D0 RID: 59344 RVA: 0x00268423 File Offset: 0x00266623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchReforgeHexAvatarFunc);
		}

		// Token: 0x0600E7D1 RID: 59345 RVA: 0x00268434 File Offset: 0x00266634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchReforgeHexAvatarFunc other)
		{
			return other != null && (other == this || (this.FreeReforgeNum == other.FreeReforgeNum && object.Equals(this.CostData, other.CostData) && this.IntReforgeNumValue == other.IntReforgeNumValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7D2 RID: 59346 RVA: 0x00268494 File Offset: 0x00266694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FreeReforgeNum != 0U)
			{
				num ^= this.FreeReforgeNum.GetHashCode();
			}
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
			}
			if (this.IntReforgeNumValue != 0)
			{
				num ^= this.IntReforgeNumValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E7D3 RID: 59347 RVA: 0x00268502 File Offset: 0x00266702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E7D4 RID: 59348 RVA: 0x0026850A File Offset: 0x0026670A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7D5 RID: 59349 RVA: 0x00268514 File Offset: 0x00266714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FreeReforgeNum != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.FreeReforgeNum);
			}
			if (this.IntReforgeNumValue != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IntReforgeNumValue);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CostData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7D6 RID: 59350 RVA: 0x00268588 File Offset: 0x00266788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FreeReforgeNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FreeReforgeNum);
			}
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
			}
			if (this.IntReforgeNumValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IntReforgeNumValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E7D7 RID: 59351 RVA: 0x002685F8 File Offset: 0x002667F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchReforgeHexAvatarFunc other)
		{
			if (other == null)
			{
				return;
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
			if (other.IntReforgeNumValue != 0)
			{
				this.IntReforgeNumValue = other.IntReforgeNumValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E7D8 RID: 59352 RVA: 0x00268674 File Offset: 0x00266874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7D9 RID: 59353 RVA: 0x00268680 File Offset: 0x00266880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 40U)
					{
						if (num != 82U)
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
						this.IntReforgeNumValue = input.ReadInt32();
					}
				}
				else
				{
					this.FreeReforgeNum = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005BF4 RID: 23540
		private static readonly MessageParser<WorkbenchReforgeHexAvatarFunc> _parser = new MessageParser<WorkbenchReforgeHexAvatarFunc>(() => new WorkbenchReforgeHexAvatarFunc());

		// Token: 0x04005BF5 RID: 23541
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BF6 RID: 23542
		public const int FreeReforgeNumFieldNumber = 1;

		// Token: 0x04005BF7 RID: 23543
		private uint freeReforgeNum_;

		// Token: 0x04005BF8 RID: 23544
		public const int CostDataFieldNumber = 10;

		// Token: 0x04005BF9 RID: 23545
		private ItemCostData costData_;

		// Token: 0x04005BFA RID: 23546
		public const int IntReforgeNumValueFieldNumber = 5;

		// Token: 0x04005BFB RID: 23547
		private int intReforgeNumValue_;
	}
}
