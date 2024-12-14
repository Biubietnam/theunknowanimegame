using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200031B RID: 795
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ComposeItemScRsp : IMessage<ComposeItemScRsp>, IMessage, IEquatable<ComposeItemScRsp>, IDeepCloneable<ComposeItemScRsp>, IBufferMessage
	{
		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x00065377 File Offset: 0x00063577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ComposeItemScRsp> Parser
		{
			get
			{
				return ComposeItemScRsp._parser;
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x0006537E File Offset: 0x0006357E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ComposeItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x00065390 File Offset: 0x00063590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ComposeItemScRsp.Descriptor;
			}
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x00065397 File Offset: 0x00063597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeItemScRsp()
		{
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x000653A0 File Offset: 0x000635A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeItemScRsp(ComposeItemScRsp other) : this()
		{
			this.returnItemList_ = ((other.returnItemList_ != null) ? other.returnItemList_.Clone() : null);
			this.count_ = other.count_;
			this.retcode_ = other.retcode_;
			this.composeId_ = other.composeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00065404 File Offset: 0x00063604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeItemScRsp Clone()
		{
			return new ComposeItemScRsp(this);
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x0006540C File Offset: 0x0006360C
		// (set) Token: 0x060023A8 RID: 9128 RVA: 0x00065414 File Offset: 0x00063614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ReturnItemList
		{
			get
			{
				return this.returnItemList_;
			}
			set
			{
				this.returnItemList_ = value;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x0006541D File Offset: 0x0006361D
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x00065425 File Offset: 0x00063625
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

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x0006542E File Offset: 0x0006362E
		// (set) Token: 0x060023AC RID: 9132 RVA: 0x00065436 File Offset: 0x00063636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x0006543F File Offset: 0x0006363F
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x00065447 File Offset: 0x00063647
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

		// Token: 0x060023AF RID: 9135 RVA: 0x00065450 File Offset: 0x00063650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ComposeItemScRsp);
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00065460 File Offset: 0x00063660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ComposeItemScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.ReturnItemList, other.ReturnItemList) && this.Count == other.Count && this.Retcode == other.Retcode && this.ComposeId == other.ComposeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x000654D0 File Offset: 0x000636D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.returnItemList_ != null)
			{
				num ^= this.ReturnItemList.GetHashCode();
			}
			if (this.Count != 0U)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ComposeId != 0U)
			{
				num ^= this.ComposeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00065557 File Offset: 0x00063757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0006555F File Offset: 0x0006375F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00065568 File Offset: 0x00063768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Count);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ComposeId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ComposeId);
			}
			if (this.returnItemList_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ReturnItemList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x000655FC File Offset: 0x000637FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.returnItemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReturnItemList);
			}
			if (this.Count != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ComposeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ComposeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00065684 File Offset: 0x00063884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ComposeItemScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.returnItemList_ != null)
			{
				if (this.returnItemList_ == null)
				{
					this.ReturnItemList = new ItemList();
				}
				this.ReturnItemList.MergeFrom(other.ReturnItemList);
			}
			if (other.Count != 0U)
			{
				this.Count = other.Count;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ComposeId != 0U)
			{
				this.ComposeId = other.ComposeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00065714 File Offset: 0x00063914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00065720 File Offset: 0x00063920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.Count = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ComposeId = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.returnItemList_ == null)
						{
							this.ReturnItemList = new ItemList();
						}
						input.ReadMessage(this.ReturnItemList);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000EA0 RID: 3744
		private static readonly MessageParser<ComposeItemScRsp> _parser = new MessageParser<ComposeItemScRsp>(() => new ComposeItemScRsp());

		// Token: 0x04000EA1 RID: 3745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EA2 RID: 3746
		public const int ReturnItemListFieldNumber = 14;

		// Token: 0x04000EA3 RID: 3747
		private ItemList returnItemList_;

		// Token: 0x04000EA4 RID: 3748
		public const int CountFieldNumber = 2;

		// Token: 0x04000EA5 RID: 3749
		private uint count_;

		// Token: 0x04000EA6 RID: 3750
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04000EA7 RID: 3751
		private uint retcode_;

		// Token: 0x04000EA8 RID: 3752
		public const int ComposeIdFieldNumber = 7;

		// Token: 0x04000EA9 RID: 3753
		private uint composeId_;
	}
}
