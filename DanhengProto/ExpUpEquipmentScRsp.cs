using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004EB RID: 1259
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExpUpEquipmentScRsp : IMessage<ExpUpEquipmentScRsp>, IMessage, IEquatable<ExpUpEquipmentScRsp>, IDeepCloneable<ExpUpEquipmentScRsp>, IBufferMessage
	{
		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x0600384F RID: 14415 RVA: 0x0009A4F1 File Offset: 0x000986F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpUpEquipmentScRsp> Parser
		{
			get
			{
				return ExpUpEquipmentScRsp._parser;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06003850 RID: 14416 RVA: 0x0009A4F8 File Offset: 0x000986F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExpUpEquipmentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x0009A50A File Offset: 0x0009870A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpUpEquipmentScRsp.Descriptor;
			}
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x0009A511 File Offset: 0x00098711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpEquipmentScRsp()
		{
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x0009A524 File Offset: 0x00098724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpEquipmentScRsp(ExpUpEquipmentScRsp other) : this()
		{
			this.returnItemList_ = other.returnItemList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x0009A55A File Offset: 0x0009875A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpUpEquipmentScRsp Clone()
		{
			return new ExpUpEquipmentScRsp(this);
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x0009A562 File Offset: 0x00098762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PileItem> ReturnItemList
		{
			get
			{
				return this.returnItemList_;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x0009A56A File Offset: 0x0009876A
		// (set) Token: 0x06003857 RID: 14423 RVA: 0x0009A572 File Offset: 0x00098772
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

		// Token: 0x06003858 RID: 14424 RVA: 0x0009A57B File Offset: 0x0009877B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpUpEquipmentScRsp);
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x0009A58C File Offset: 0x0009878C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpUpEquipmentScRsp other)
		{
			return other != null && (other == this || (this.returnItemList_.Equals(other.returnItemList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x0009A5DC File Offset: 0x000987DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.returnItemList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x0009A629 File Offset: 0x00098829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x0009A631 File Offset: 0x00098831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x0009A63C File Offset: 0x0009883C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.returnItemList_.WriteTo(ref output, ExpUpEquipmentScRsp._repeated_returnItemList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x0009A68C File Offset: 0x0009888C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.returnItemList_.CalculateSize(ExpUpEquipmentScRsp._repeated_returnItemList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x0009A6E0 File Offset: 0x000988E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExpUpEquipmentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.returnItemList_.Add(other.returnItemList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x0009A72D File Offset: 0x0009892D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x0009A738 File Offset: 0x00098938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 72U)
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
					this.returnItemList_.AddEntriesFrom(ref input, ExpUpEquipmentScRsp._repeated_returnItemList_codec);
				}
			}
		}

		// Token: 0x04001648 RID: 5704
		private static readonly MessageParser<ExpUpEquipmentScRsp> _parser = new MessageParser<ExpUpEquipmentScRsp>(() => new ExpUpEquipmentScRsp());

		// Token: 0x04001649 RID: 5705
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400164A RID: 5706
		public const int ReturnItemListFieldNumber = 4;

		// Token: 0x0400164B RID: 5707
		private static readonly FieldCodec<PileItem> _repeated_returnItemList_codec = FieldCodec.ForMessage<PileItem>(34U, PileItem.Parser);

		// Token: 0x0400164C RID: 5708
		private readonly RepeatedField<PileItem> returnItemList_ = new RepeatedField<PileItem>();

		// Token: 0x0400164D RID: 5709
		public const int RetcodeFieldNumber = 9;

		// Token: 0x0400164E RID: 5710
		private uint retcode_;
	}
}
