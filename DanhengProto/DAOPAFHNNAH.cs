using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200035B RID: 859
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DAOPAFHNNAH : IMessage<DAOPAFHNNAH>, IMessage, IEquatable<DAOPAFHNNAH>, IDeepCloneable<DAOPAFHNNAH>, IBufferMessage
	{
		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002653 RID: 9811 RVA: 0x0006BA5B File Offset: 0x00069C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DAOPAFHNNAH> Parser
		{
			get
			{
				return DAOPAFHNNAH._parser;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x0006BA62 File Offset: 0x00069C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DAOPAFHNNAHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x0006BA74 File Offset: 0x00069C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DAOPAFHNNAH.Descriptor;
			}
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x0006BA7B File Offset: 0x00069C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAOPAFHNNAH()
		{
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x0006BA84 File Offset: 0x00069C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAOPAFHNNAH(DAOPAFHNNAH other) : this()
		{
			this.freeReforgeNum_ = other.freeReforgeNum_;
			this.intReforgeNumValue_ = other.intReforgeNumValue_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x0006BADC File Offset: 0x00069CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAOPAFHNNAH Clone()
		{
			return new DAOPAFHNNAH(this);
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x0006BAE4 File Offset: 0x00069CE4
		// (set) Token: 0x0600265A RID: 9818 RVA: 0x0006BAEC File Offset: 0x00069CEC
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

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x0600265B RID: 9819 RVA: 0x0006BAF5 File Offset: 0x00069CF5
		// (set) Token: 0x0600265C RID: 9820 RVA: 0x0006BAFD File Offset: 0x00069CFD
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

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x0006BB06 File Offset: 0x00069D06
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x0006BB0E File Offset: 0x00069D0E
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

		// Token: 0x0600265F RID: 9823 RVA: 0x0006BB17 File Offset: 0x00069D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DAOPAFHNNAH);
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x0006BB28 File Offset: 0x00069D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DAOPAFHNNAH other)
		{
			return other != null && (other == this || (this.FreeReforgeNum == other.FreeReforgeNum && this.IntReforgeNumValue == other.IntReforgeNumValue && object.Equals(this.CostData, other.CostData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x0006BB88 File Offset: 0x00069D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FreeReforgeNum != 0U)
			{
				num ^= this.FreeReforgeNum.GetHashCode();
			}
			if (this.IntReforgeNumValue != 0)
			{
				num ^= this.IntReforgeNumValue.GetHashCode();
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

		// Token: 0x06002662 RID: 9826 RVA: 0x0006BBF6 File Offset: 0x00069DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x0006BBFE File Offset: 0x00069DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x0006BC08 File Offset: 0x00069E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IntReforgeNumValue != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IntReforgeNumValue);
			}
			if (this.FreeReforgeNum != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.FreeReforgeNum);
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

		// Token: 0x06002665 RID: 9829 RVA: 0x0006BC80 File Offset: 0x00069E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FreeReforgeNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FreeReforgeNum);
			}
			if (this.IntReforgeNumValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IntReforgeNumValue);
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

		// Token: 0x06002666 RID: 9830 RVA: 0x0006BCF0 File Offset: 0x00069EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DAOPAFHNNAH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FreeReforgeNum != 0U)
			{
				this.FreeReforgeNum = other.FreeReforgeNum;
			}
			if (other.IntReforgeNumValue != 0)
			{
				this.IntReforgeNumValue = other.IntReforgeNumValue;
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

		// Token: 0x06002667 RID: 9831 RVA: 0x0006BD6C File Offset: 0x00069F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x0006BD78 File Offset: 0x00069F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 72U)
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
						this.FreeReforgeNum = input.ReadUInt32();
					}
				}
				else
				{
					this.IntReforgeNumValue = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000F8B RID: 3979
		private static readonly MessageParser<DAOPAFHNNAH> _parser = new MessageParser<DAOPAFHNNAH>(() => new DAOPAFHNNAH());

		// Token: 0x04000F8C RID: 3980
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F8D RID: 3981
		public const int FreeReforgeNumFieldNumber = 9;

		// Token: 0x04000F8E RID: 3982
		private uint freeReforgeNum_;

		// Token: 0x04000F8F RID: 3983
		public const int IntReforgeNumValueFieldNumber = 5;

		// Token: 0x04000F90 RID: 3984
		private int intReforgeNumValue_;

		// Token: 0x04000F91 RID: 3985
		public const int CostDataFieldNumber = 13;

		// Token: 0x04000F92 RID: 3986
		private ItemCostData costData_;
	}
}
