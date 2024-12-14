using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010B3 RID: 4275
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectRogueCommonDialogueOptionCsReq : IMessage<SelectRogueCommonDialogueOptionCsReq>, IMessage, IEquatable<SelectRogueCommonDialogueOptionCsReq>, IDeepCloneable<SelectRogueCommonDialogueOptionCsReq>, IBufferMessage
	{
		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x0600BE99 RID: 48793 RVA: 0x00201511 File Offset: 0x001FF711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectRogueCommonDialogueOptionCsReq> Parser
		{
			get
			{
				return SelectRogueCommonDialogueOptionCsReq._parser;
			}
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0600BE9A RID: 48794 RVA: 0x00201518 File Offset: 0x001FF718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectRogueCommonDialogueOptionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0600BE9B RID: 48795 RVA: 0x0020152A File Offset: 0x001FF72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectRogueCommonDialogueOptionCsReq.Descriptor;
			}
		}

		// Token: 0x0600BE9C RID: 48796 RVA: 0x00201531 File Offset: 0x001FF731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectRogueCommonDialogueOptionCsReq()
		{
		}

		// Token: 0x0600BE9D RID: 48797 RVA: 0x00201539 File Offset: 0x001FF739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectRogueCommonDialogueOptionCsReq(SelectRogueCommonDialogueOptionCsReq other) : this()
		{
			this.eventUniqueId_ = other.eventUniqueId_;
			this.optionId_ = other.optionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE9E RID: 48798 RVA: 0x0020156A File Offset: 0x001FF76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectRogueCommonDialogueOptionCsReq Clone()
		{
			return new SelectRogueCommonDialogueOptionCsReq(this);
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0600BE9F RID: 48799 RVA: 0x00201572 File Offset: 0x001FF772
		// (set) Token: 0x0600BEA0 RID: 48800 RVA: 0x0020157A File Offset: 0x001FF77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventUniqueId
		{
			get
			{
				return this.eventUniqueId_;
			}
			set
			{
				this.eventUniqueId_ = value;
			}
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0600BEA1 RID: 48801 RVA: 0x00201583 File Offset: 0x001FF783
		// (set) Token: 0x0600BEA2 RID: 48802 RVA: 0x0020158B File Offset: 0x001FF78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionId
		{
			get
			{
				return this.optionId_;
			}
			set
			{
				this.optionId_ = value;
			}
		}

		// Token: 0x0600BEA3 RID: 48803 RVA: 0x00201594 File Offset: 0x001FF794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectRogueCommonDialogueOptionCsReq);
		}

		// Token: 0x0600BEA4 RID: 48804 RVA: 0x002015A2 File Offset: 0x001FF7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectRogueCommonDialogueOptionCsReq other)
		{
			return other != null && (other == this || (this.EventUniqueId == other.EventUniqueId && this.OptionId == other.OptionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEA5 RID: 48805 RVA: 0x002015E0 File Offset: 0x001FF7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventUniqueId != 0U)
			{
				num ^= this.EventUniqueId.GetHashCode();
			}
			if (this.OptionId != 0U)
			{
				num ^= this.OptionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BEA6 RID: 48806 RVA: 0x00201638 File Offset: 0x001FF838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BEA7 RID: 48807 RVA: 0x00201640 File Offset: 0x001FF840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEA8 RID: 48808 RVA: 0x0020164C File Offset: 0x001FF84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventUniqueId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EventUniqueId);
			}
			if (this.OptionId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.OptionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BEA9 RID: 48809 RVA: 0x002016A8 File Offset: 0x001FF8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventUniqueId);
			}
			if (this.OptionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BEAA RID: 48810 RVA: 0x00201700 File Offset: 0x001FF900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectRogueCommonDialogueOptionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventUniqueId != 0U)
			{
				this.EventUniqueId = other.EventUniqueId;
			}
			if (other.OptionId != 0U)
			{
				this.OptionId = other.OptionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BEAB RID: 48811 RVA: 0x00201750 File Offset: 0x001FF950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEAC RID: 48812 RVA: 0x0020175C File Offset: 0x001FF95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OptionId = input.ReadUInt32();
					}
				}
				else
				{
					this.EventUniqueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D6C RID: 19820
		private static readonly MessageParser<SelectRogueCommonDialogueOptionCsReq> _parser = new MessageParser<SelectRogueCommonDialogueOptionCsReq>(() => new SelectRogueCommonDialogueOptionCsReq());

		// Token: 0x04004D6D RID: 19821
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D6E RID: 19822
		public const int EventUniqueIdFieldNumber = 6;

		// Token: 0x04004D6F RID: 19823
		private uint eventUniqueId_;

		// Token: 0x04004D70 RID: 19824
		public const int OptionIdFieldNumber = 10;

		// Token: 0x04004D71 RID: 19825
		private uint optionId_;
	}
}
