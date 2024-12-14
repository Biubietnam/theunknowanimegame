using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200140B RID: 5131
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UseItemScRsp : IMessage<UseItemScRsp>, IMessage, IEquatable<UseItemScRsp>, IDeepCloneable<UseItemScRsp>, IBufferMessage
	{
		// Token: 0x17004041 RID: 16449
		// (get) Token: 0x0600E4DA RID: 58586 RVA: 0x002608AF File Offset: 0x0025EAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UseItemScRsp> Parser
		{
			get
			{
				return UseItemScRsp._parser;
			}
		}

		// Token: 0x17004042 RID: 16450
		// (get) Token: 0x0600E4DB RID: 58587 RVA: 0x002608B6 File Offset: 0x0025EAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UseItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004043 RID: 16451
		// (get) Token: 0x0600E4DC RID: 58588 RVA: 0x002608C8 File Offset: 0x0025EAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseItemScRsp.Descriptor;
			}
		}

		// Token: 0x0600E4DD RID: 58589 RVA: 0x002608CF File Offset: 0x0025EACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemScRsp()
		{
		}

		// Token: 0x0600E4DE RID: 58590 RVA: 0x002608D8 File Offset: 0x0025EAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemScRsp(UseItemScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.returnData_ = ((other.returnData_ != null) ? other.returnData_.Clone() : null);
			this.gNGOKFEMCMI_ = other.gNGOKFEMCMI_;
			this.useItemId_ = other.useItemId_;
			this.useItemCount_ = other.useItemCount_;
			this.formulaId_ = other.formulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4DF RID: 58591 RVA: 0x00260954 File Offset: 0x0025EB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemScRsp Clone()
		{
			return new UseItemScRsp(this);
		}

		// Token: 0x17004044 RID: 16452
		// (get) Token: 0x0600E4E0 RID: 58592 RVA: 0x0026095C File Offset: 0x0025EB5C
		// (set) Token: 0x0600E4E1 RID: 58593 RVA: 0x00260964 File Offset: 0x0025EB64
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

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x0600E4E2 RID: 58594 RVA: 0x0026096D File Offset: 0x0025EB6D
		// (set) Token: 0x0600E4E3 RID: 58595 RVA: 0x00260975 File Offset: 0x0025EB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ReturnData
		{
			get
			{
				return this.returnData_;
			}
			set
			{
				this.returnData_ = value;
			}
		}

		// Token: 0x17004046 RID: 16454
		// (get) Token: 0x0600E4E4 RID: 58596 RVA: 0x0026097E File Offset: 0x0025EB7E
		// (set) Token: 0x0600E4E5 RID: 58597 RVA: 0x00260986 File Offset: 0x0025EB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong GNGOKFEMCMI
		{
			get
			{
				return this.gNGOKFEMCMI_;
			}
			set
			{
				this.gNGOKFEMCMI_ = value;
			}
		}

		// Token: 0x17004047 RID: 16455
		// (get) Token: 0x0600E4E6 RID: 58598 RVA: 0x0026098F File Offset: 0x0025EB8F
		// (set) Token: 0x0600E4E7 RID: 58599 RVA: 0x00260997 File Offset: 0x0025EB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UseItemId
		{
			get
			{
				return this.useItemId_;
			}
			set
			{
				this.useItemId_ = value;
			}
		}

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x0600E4E8 RID: 58600 RVA: 0x002609A0 File Offset: 0x0025EBA0
		// (set) Token: 0x0600E4E9 RID: 58601 RVA: 0x002609A8 File Offset: 0x0025EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UseItemCount
		{
			get
			{
				return this.useItemCount_;
			}
			set
			{
				this.useItemCount_ = value;
			}
		}

		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x0600E4EA RID: 58602 RVA: 0x002609B1 File Offset: 0x0025EBB1
		// (set) Token: 0x0600E4EB RID: 58603 RVA: 0x002609B9 File Offset: 0x0025EBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FormulaId
		{
			get
			{
				return this.formulaId_;
			}
			set
			{
				this.formulaId_ = value;
			}
		}

		// Token: 0x0600E4EC RID: 58604 RVA: 0x002609C2 File Offset: 0x0025EBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseItemScRsp);
		}

		// Token: 0x0600E4ED RID: 58605 RVA: 0x002609D0 File Offset: 0x0025EBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseItemScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.ReturnData, other.ReturnData) && this.GNGOKFEMCMI == other.GNGOKFEMCMI && this.UseItemId == other.UseItemId && this.UseItemCount == other.UseItemCount && this.FormulaId == other.FormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4EE RID: 58606 RVA: 0x00260A60 File Offset: 0x0025EC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.returnData_ != null)
			{
				num ^= this.ReturnData.GetHashCode();
			}
			if (this.GNGOKFEMCMI != 0UL)
			{
				num ^= this.GNGOKFEMCMI.GetHashCode();
			}
			if (this.UseItemId != 0U)
			{
				num ^= this.UseItemId.GetHashCode();
			}
			if (this.UseItemCount != 0U)
			{
				num ^= this.UseItemCount.GetHashCode();
			}
			if (this.FormulaId != 0U)
			{
				num ^= this.FormulaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E4EF RID: 58607 RVA: 0x00260B19 File Offset: 0x0025ED19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E4F0 RID: 58608 RVA: 0x00260B21 File Offset: 0x0025ED21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4F1 RID: 58609 RVA: 0x00260B2C File Offset: 0x0025ED2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GNGOKFEMCMI != 0UL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.GNGOKFEMCMI);
			}
			if (this.FormulaId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.FormulaId);
			}
			if (this.returnData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ReturnData);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.UseItemId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.UseItemId);
			}
			if (this.UseItemCount != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.UseItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E4F2 RID: 58610 RVA: 0x00260BF8 File Offset: 0x0025EDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.returnData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReturnData);
			}
			if (this.GNGOKFEMCMI != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GNGOKFEMCMI);
			}
			if (this.UseItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UseItemId);
			}
			if (this.UseItemCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UseItemCount);
			}
			if (this.FormulaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FormulaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E4F3 RID: 58611 RVA: 0x00260CB0 File Offset: 0x0025EEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseItemScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.returnData_ != null)
			{
				if (this.returnData_ == null)
				{
					this.ReturnData = new ItemList();
				}
				this.ReturnData.MergeFrom(other.ReturnData);
			}
			if (other.GNGOKFEMCMI != 0UL)
			{
				this.GNGOKFEMCMI = other.GNGOKFEMCMI;
			}
			if (other.UseItemId != 0U)
			{
				this.UseItemId = other.UseItemId;
			}
			if (other.UseItemCount != 0U)
			{
				this.UseItemCount = other.UseItemCount;
			}
			if (other.FormulaId != 0U)
			{
				this.FormulaId = other.FormulaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E4F4 RID: 58612 RVA: 0x00260D68 File Offset: 0x0025EF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4F5 RID: 58613 RVA: 0x00260D74 File Offset: 0x0025EF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 16U)
					{
						this.GNGOKFEMCMI = input.ReadUInt64();
						continue;
					}
					if (num == 48U)
					{
						this.FormulaId = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.returnData_ == null)
						{
							this.ReturnData = new ItemList();
						}
						input.ReadMessage(this.ReturnData);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.UseItemId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.UseItemCount = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005AE8 RID: 23272
		private static readonly MessageParser<UseItemScRsp> _parser = new MessageParser<UseItemScRsp>(() => new UseItemScRsp());

		// Token: 0x04005AE9 RID: 23273
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AEA RID: 23274
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04005AEB RID: 23275
		private uint retcode_;

		// Token: 0x04005AEC RID: 23276
		public const int ReturnDataFieldNumber = 7;

		// Token: 0x04005AED RID: 23277
		private ItemList returnData_;

		// Token: 0x04005AEE RID: 23278
		public const int GNGOKFEMCMIFieldNumber = 2;

		// Token: 0x04005AEF RID: 23279
		private ulong gNGOKFEMCMI_;

		// Token: 0x04005AF0 RID: 23280
		public const int UseItemIdFieldNumber = 13;

		// Token: 0x04005AF1 RID: 23281
		private uint useItemId_;

		// Token: 0x04005AF2 RID: 23282
		public const int UseItemCountFieldNumber = 14;

		// Token: 0x04005AF3 RID: 23283
		private uint useItemCount_;

		// Token: 0x04005AF4 RID: 23284
		public const int FormulaIdFieldNumber = 6;

		// Token: 0x04005AF5 RID: 23285
		private uint formulaId_;
	}
}
