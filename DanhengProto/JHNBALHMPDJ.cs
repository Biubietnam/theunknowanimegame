using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000969 RID: 2409
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JHNBALHMPDJ : IMessage<JHNBALHMPDJ>, IMessage, IEquatable<JHNBALHMPDJ>, IDeepCloneable<JHNBALHMPDJ>, IBufferMessage
	{
		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x06006B93 RID: 27539 RVA: 0x0011EC35 File Offset: 0x0011CE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JHNBALHMPDJ> Parser
		{
			get
			{
				return JHNBALHMPDJ._parser;
			}
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x06006B94 RID: 27540 RVA: 0x0011EC3C File Offset: 0x0011CE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JHNBALHMPDJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x06006B95 RID: 27541 RVA: 0x0011EC4E File Offset: 0x0011CE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JHNBALHMPDJ.Descriptor;
			}
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x0011EC55 File Offset: 0x0011CE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHNBALHMPDJ()
		{
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x0011EC60 File Offset: 0x0011CE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHNBALHMPDJ(JHNBALHMPDJ other) : this()
		{
			this.itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
			this.pHHAHKBJLOB_ = other.pHHAHKBJLOB_;
			this.mCOHIKAOHDL_ = other.mCOHIKAOHDL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x0011ECB8 File Offset: 0x0011CEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHNBALHMPDJ Clone()
		{
			return new JHNBALHMPDJ(this);
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06006B99 RID: 27545 RVA: 0x0011ECC0 File Offset: 0x0011CEC0
		// (set) Token: 0x06006B9A RID: 27546 RVA: 0x0011ECC8 File Offset: 0x0011CEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ItemList
		{
			get
			{
				return this.itemList_;
			}
			set
			{
				this.itemList_ = value;
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x06006B9B RID: 27547 RVA: 0x0011ECD1 File Offset: 0x0011CED1
		// (set) Token: 0x06006B9C RID: 27548 RVA: 0x0011ECD9 File Offset: 0x0011CED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHHAHKBJLOB
		{
			get
			{
				return this.pHHAHKBJLOB_;
			}
			set
			{
				this.pHHAHKBJLOB_ = value;
			}
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x06006B9D RID: 27549 RVA: 0x0011ECE2 File Offset: 0x0011CEE2
		// (set) Token: 0x06006B9E RID: 27550 RVA: 0x0011ECEA File Offset: 0x0011CEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MCOHIKAOHDL
		{
			get
			{
				return this.mCOHIKAOHDL_;
			}
			set
			{
				this.mCOHIKAOHDL_ = value;
			}
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x0011ECF3 File Offset: 0x0011CEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JHNBALHMPDJ);
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x0011ED04 File Offset: 0x0011CF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JHNBALHMPDJ other)
		{
			return other != null && (other == this || (object.Equals(this.ItemList, other.ItemList) && this.PHHAHKBJLOB == other.PHHAHKBJLOB && this.MCOHIKAOHDL == other.MCOHIKAOHDL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x0011ED64 File Offset: 0x0011CF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.itemList_ != null)
			{
				num ^= this.ItemList.GetHashCode();
			}
			if (this.PHHAHKBJLOB != 0U)
			{
				num ^= this.PHHAHKBJLOB.GetHashCode();
			}
			if (this.MCOHIKAOHDL != 0U)
			{
				num ^= this.MCOHIKAOHDL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x0011EDD2 File Offset: 0x0011CFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x0011EDDA File Offset: 0x0011CFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BA4 RID: 27556 RVA: 0x0011EDE4 File Offset: 0x0011CFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PHHAHKBJLOB != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PHHAHKBJLOB);
			}
			if (this.MCOHIKAOHDL != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MCOHIKAOHDL);
			}
			if (this.itemList_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ItemList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BA5 RID: 27557 RVA: 0x0011EE5C File Offset: 0x0011D05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.itemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemList);
			}
			if (this.PHHAHKBJLOB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHHAHKBJLOB);
			}
			if (this.MCOHIKAOHDL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MCOHIKAOHDL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x0011EECC File Offset: 0x0011D0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JHNBALHMPDJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.itemList_ != null)
			{
				if (this.itemList_ == null)
				{
					this.ItemList = new ItemList();
				}
				this.ItemList.MergeFrom(other.ItemList);
			}
			if (other.PHHAHKBJLOB != 0U)
			{
				this.PHHAHKBJLOB = other.PHHAHKBJLOB;
			}
			if (other.MCOHIKAOHDL != 0U)
			{
				this.MCOHIKAOHDL = other.MCOHIKAOHDL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x0011EF48 File Offset: 0x0011D148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x0011EF54 File Offset: 0x0011D154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 104U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.itemList_ == null)
							{
								this.ItemList = new ItemList();
							}
							input.ReadMessage(this.ItemList);
						}
					}
					else
					{
						this.MCOHIKAOHDL = input.ReadUInt32();
					}
				}
				else
				{
					this.PHHAHKBJLOB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400292B RID: 10539
		private static readonly MessageParser<JHNBALHMPDJ> _parser = new MessageParser<JHNBALHMPDJ>(() => new JHNBALHMPDJ());

		// Token: 0x0400292C RID: 10540
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400292D RID: 10541
		public const int ItemListFieldNumber = 14;

		// Token: 0x0400292E RID: 10542
		private ItemList itemList_;

		// Token: 0x0400292F RID: 10543
		public const int PHHAHKBJLOBFieldNumber = 2;

		// Token: 0x04002930 RID: 10544
		private uint pHHAHKBJLOB_;

		// Token: 0x04002931 RID: 10545
		public const int MCOHIKAOHDLFieldNumber = 13;

		// Token: 0x04002932 RID: 10546
		private uint mCOHIKAOHDL_;
	}
}
