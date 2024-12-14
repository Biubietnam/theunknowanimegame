using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000375 RID: 885
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeleteRelicFilterPlanCsReq : IMessage<DeleteRelicFilterPlanCsReq>, IMessage, IEquatable<DeleteRelicFilterPlanCsReq>, IDeepCloneable<DeleteRelicFilterPlanCsReq>, IBufferMessage
	{
		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x0006DF59 File Offset: 0x0006C159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeleteRelicFilterPlanCsReq> Parser
		{
			get
			{
				return DeleteRelicFilterPlanCsReq._parser;
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x0006DF60 File Offset: 0x0006C160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeleteRelicFilterPlanCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x0006DF72 File Offset: 0x0006C172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteRelicFilterPlanCsReq.Descriptor;
			}
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x0006DF79 File Offset: 0x0006C179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteRelicFilterPlanCsReq()
		{
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x0006DF8C File Offset: 0x0006C18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteRelicFilterPlanCsReq(DeleteRelicFilterPlanCsReq other) : this()
		{
			this.isBatchOp_ = other.isBatchOp_;
			this.slotIndexList_ = other.slotIndexList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0006DFC2 File Offset: 0x0006C1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteRelicFilterPlanCsReq Clone()
		{
			return new DeleteRelicFilterPlanCsReq(this);
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x0006DFCA File Offset: 0x0006C1CA
		// (set) Token: 0x06002768 RID: 10088 RVA: 0x0006DFD2 File Offset: 0x0006C1D2
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

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x0006DFDB File Offset: 0x0006C1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SlotIndexList
		{
			get
			{
				return this.slotIndexList_;
			}
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x0006DFE3 File Offset: 0x0006C1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteRelicFilterPlanCsReq);
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x0006DFF4 File Offset: 0x0006C1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteRelicFilterPlanCsReq other)
		{
			return other != null && (other == this || (this.IsBatchOp == other.IsBatchOp && this.slotIndexList_.Equals(other.slotIndexList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0006E044 File Offset: 0x0006C244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsBatchOp)
			{
				num ^= this.IsBatchOp.GetHashCode();
			}
			num ^= this.slotIndexList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x0006E091 File Offset: 0x0006C291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0006E099 File Offset: 0x0006C299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x0006E0A4 File Offset: 0x0006C2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slotIndexList_.WriteTo(ref output, DeleteRelicFilterPlanCsReq._repeated_slotIndexList_codec);
			if (this.IsBatchOp)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsBatchOp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x0006E0F4 File Offset: 0x0006C2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsBatchOp)
			{
				num += 2;
			}
			num += this.slotIndexList_.CalculateSize(DeleteRelicFilterPlanCsReq._repeated_slotIndexList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x0006E13C File Offset: 0x0006C33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteRelicFilterPlanCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsBatchOp)
			{
				this.IsBatchOp = other.IsBatchOp;
			}
			this.slotIndexList_.Add(other.slotIndexList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x0006E189 File Offset: 0x0006C389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x0006E194 File Offset: 0x0006C394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsBatchOp = input.ReadBool();
					}
				}
				else
				{
					this.slotIndexList_.AddEntriesFrom(ref input, DeleteRelicFilterPlanCsReq._repeated_slotIndexList_codec);
				}
			}
		}

		// Token: 0x04000FE1 RID: 4065
		private static readonly MessageParser<DeleteRelicFilterPlanCsReq> _parser = new MessageParser<DeleteRelicFilterPlanCsReq>(() => new DeleteRelicFilterPlanCsReq());

		// Token: 0x04000FE2 RID: 4066
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FE3 RID: 4067
		public const int IsBatchOpFieldNumber = 10;

		// Token: 0x04000FE4 RID: 4068
		private bool isBatchOp_;

		// Token: 0x04000FE5 RID: 4069
		public const int SlotIndexListFieldNumber = 1;

		// Token: 0x04000FE6 RID: 4070
		private static readonly FieldCodec<uint> _repeated_slotIndexList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04000FE7 RID: 4071
		private readonly RepeatedField<uint> slotIndexList_ = new RepeatedField<uint>();
	}
}
