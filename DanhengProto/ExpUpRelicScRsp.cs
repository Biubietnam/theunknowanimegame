using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004EF RID: 1263
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExpUpRelicScRsp : IMessage<ExpUpRelicScRsp>, IMessage, IEquatable<ExpUpRelicScRsp>, IDeepCloneable<ExpUpRelicScRsp>, IBufferMessage
	{
		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600387C RID: 14460 RVA: 0x0009ABDD File Offset: 0x00098DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpUpRelicScRsp> Parser
		{
			get
			{
				return ExpUpRelicScRsp._parser;
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x0009ABE4 File Offset: 0x00098DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExpUpRelicScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x0009ABF6 File Offset: 0x00098DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpUpRelicScRsp.Descriptor;
			}
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x0009ABFD File Offset: 0x00098DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpRelicScRsp()
		{
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0009AC10 File Offset: 0x00098E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpRelicScRsp(ExpUpRelicScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.returnItemList_ = other.returnItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x0009AC46 File Offset: 0x00098E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpRelicScRsp Clone()
		{
			return new ExpUpRelicScRsp(this);
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x0009AC4E File Offset: 0x00098E4E
		// (set) Token: 0x06003883 RID: 14467 RVA: 0x0009AC56 File Offset: 0x00098E56
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

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x0009AC5F File Offset: 0x00098E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PileItem> ReturnItemList
		{
			get
			{
				return this.returnItemList_;
			}
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x0009AC67 File Offset: 0x00098E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpUpRelicScRsp);
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x0009AC78 File Offset: 0x00098E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpUpRelicScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.returnItemList_.Equals(other.returnItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x0009ACC8 File Offset: 0x00098EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.returnItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x0009AD15 File Offset: 0x00098F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x0009AD1D File Offset: 0x00098F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x0009AD28 File Offset: 0x00098F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.returnItemList_.WriteTo(ref output, ExpUpRelicScRsp._repeated_returnItemList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x0009AD78 File Offset: 0x00098F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.returnItemList_.CalculateSize(ExpUpRelicScRsp._repeated_returnItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x0009ADCC File Offset: 0x00098FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExpUpRelicScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.returnItemList_.Add(other.returnItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x0009AE19 File Offset: 0x00099019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x0009AE24 File Offset: 0x00099024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.returnItemList_.AddEntriesFrom(ref input, ExpUpRelicScRsp._repeated_returnItemList_codec);
				}
			}
		}

		// Token: 0x04001657 RID: 5719
		private static readonly MessageParser<ExpUpRelicScRsp> _parser = new MessageParser<ExpUpRelicScRsp>(() => new ExpUpRelicScRsp());

		// Token: 0x04001658 RID: 5720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001659 RID: 5721
		public const int RetcodeFieldNumber = 5;

		// Token: 0x0400165A RID: 5722
		private uint retcode_;

		// Token: 0x0400165B RID: 5723
		public const int ReturnItemListFieldNumber = 1;

		// Token: 0x0400165C RID: 5724
		private static readonly FieldCodec<PileItem> _repeated_returnItemList_codec = FieldCodec.ForMessage<PileItem>(10U, PileItem.Parser);

		// Token: 0x0400165D RID: 5725
		private readonly RepeatedField<PileItem> returnItemList_ = new RepeatedField<PileItem>();
	}
}
