using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A91 RID: 2705
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MarkRelicFilterPlanCsReq : IMessage<MarkRelicFilterPlanCsReq>, IMessage, IEquatable<MarkRelicFilterPlanCsReq>, IDeepCloneable<MarkRelicFilterPlanCsReq>, IBufferMessage
	{
		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x060077EC RID: 30700 RVA: 0x0013DE59 File Offset: 0x0013C059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkRelicFilterPlanCsReq> Parser
		{
			get
			{
				return MarkRelicFilterPlanCsReq._parser;
			}
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x060077ED RID: 30701 RVA: 0x0013DE60 File Offset: 0x0013C060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MarkRelicFilterPlanCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x060077EE RID: 30702 RVA: 0x0013DE72 File Offset: 0x0013C072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkRelicFilterPlanCsReq.Descriptor;
			}
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x0013DE79 File Offset: 0x0013C079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkRelicFilterPlanCsReq()
		{
		}

		// Token: 0x060077F0 RID: 30704 RVA: 0x0013DE8C File Offset: 0x0013C08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkRelicFilterPlanCsReq(MarkRelicFilterPlanCsReq other) : this()
		{
			this.isMark_ = other.isMark_;
			this.slotIndexList_ = other.slotIndexList_.Clone();
			this.isBatchOp_ = other.isBatchOp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x0013DED9 File Offset: 0x0013C0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkRelicFilterPlanCsReq Clone()
		{
			return new MarkRelicFilterPlanCsReq(this);
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x060077F2 RID: 30706 RVA: 0x0013DEE1 File Offset: 0x0013C0E1
		// (set) Token: 0x060077F3 RID: 30707 RVA: 0x0013DEE9 File Offset: 0x0013C0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMark
		{
			get
			{
				return this.isMark_;
			}
			set
			{
				this.isMark_ = value;
			}
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x060077F4 RID: 30708 RVA: 0x0013DEF2 File Offset: 0x0013C0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SlotIndexList
		{
			get
			{
				return this.slotIndexList_;
			}
		}

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x060077F5 RID: 30709 RVA: 0x0013DEFA File Offset: 0x0013C0FA
		// (set) Token: 0x060077F6 RID: 30710 RVA: 0x0013DF02 File Offset: 0x0013C102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBatchOp
		{
			get
			{
				return this.isBatchOp_;
			}
			set
			{
				this.isBatchOp_ = value;
			}
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x0013DF0B File Offset: 0x0013C10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkRelicFilterPlanCsReq);
		}

		// Token: 0x060077F8 RID: 30712 RVA: 0x0013DF1C File Offset: 0x0013C11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkRelicFilterPlanCsReq other)
		{
			return other != null && (other == this || (this.IsMark == other.IsMark && this.slotIndexList_.Equals(other.slotIndexList_) && this.IsBatchOp == other.IsBatchOp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x0013DF7C File Offset: 0x0013C17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsMark)
			{
				num ^= this.IsMark.GetHashCode();
			}
			num ^= this.slotIndexList_.GetHashCode();
			if (this.IsBatchOp)
			{
				num ^= this.IsBatchOp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x0013DFE2 File Offset: 0x0013C1E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x0013DFEA File Offset: 0x0013C1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x0013DFF4 File Offset: 0x0013C1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slotIndexList_.WriteTo(ref output, MarkRelicFilterPlanCsReq._repeated_slotIndexList_codec);
			if (this.IsBatchOp)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsBatchOp);
			}
			if (this.IsMark)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsMark);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x0013E060 File Offset: 0x0013C260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsMark)
			{
				num += 2;
			}
			num += this.slotIndexList_.CalculateSize(MarkRelicFilterPlanCsReq._repeated_slotIndexList_codec);
			if (this.IsBatchOp)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x0013E0B4 File Offset: 0x0013C2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkRelicFilterPlanCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsMark)
			{
				this.IsMark = other.IsMark;
			}
			this.slotIndexList_.Add(other.slotIndexList_);
			if (other.IsBatchOp)
			{
				this.IsBatchOp = other.IsBatchOp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x0013E115 File Offset: 0x0013C315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x0013E120 File Offset: 0x0013C320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 72U || num == 74U)
					{
						this.slotIndexList_.AddEntriesFrom(ref input, MarkRelicFilterPlanCsReq._repeated_slotIndexList_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.IsBatchOp = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.IsMark = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E04 RID: 11780
		private static readonly MessageParser<MarkRelicFilterPlanCsReq> _parser = new MessageParser<MarkRelicFilterPlanCsReq>(() => new MarkRelicFilterPlanCsReq());

		// Token: 0x04002E05 RID: 11781
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E06 RID: 11782
		public const int IsMarkFieldNumber = 14;

		// Token: 0x04002E07 RID: 11783
		private bool isMark_;

		// Token: 0x04002E08 RID: 11784
		public const int SlotIndexListFieldNumber = 9;

		// Token: 0x04002E09 RID: 11785
		private static readonly FieldCodec<uint> _repeated_slotIndexList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04002E0A RID: 11786
		private readonly RepeatedField<uint> slotIndexList_ = new RepeatedField<uint>();

		// Token: 0x04002E0B RID: 11787
		public const int IsBatchOpFieldNumber = 11;

		// Token: 0x04002E0C RID: 11788
		private bool isBatchOp_;
	}
}
