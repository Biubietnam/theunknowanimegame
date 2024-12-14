using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001225 RID: 4645
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingDialogueSelectOptionCsReq : IMessage<SwordTrainingDialogueSelectOptionCsReq>, IMessage, IEquatable<SwordTrainingDialogueSelectOptionCsReq>, IDeepCloneable<SwordTrainingDialogueSelectOptionCsReq>, IBufferMessage
	{
		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x0600CF86 RID: 53126 RVA: 0x0022C35D File Offset: 0x0022A55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingDialogueSelectOptionCsReq> Parser
		{
			get
			{
				return SwordTrainingDialogueSelectOptionCsReq._parser;
			}
		}

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x0600CF87 RID: 53127 RVA: 0x0022C364 File Offset: 0x0022A564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingDialogueSelectOptionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x0600CF88 RID: 53128 RVA: 0x0022C376 File Offset: 0x0022A576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingDialogueSelectOptionCsReq.Descriptor;
			}
		}

		// Token: 0x0600CF89 RID: 53129 RVA: 0x0022C37D File Offset: 0x0022A57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDialogueSelectOptionCsReq()
		{
		}

		// Token: 0x0600CF8A RID: 53130 RVA: 0x0022C385 File Offset: 0x0022A585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDialogueSelectOptionCsReq(SwordTrainingDialogueSelectOptionCsReq other) : this()
		{
			this.optionId_ = other.optionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF8B RID: 53131 RVA: 0x0022C3AA File Offset: 0x0022A5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDialogueSelectOptionCsReq Clone()
		{
			return new SwordTrainingDialogueSelectOptionCsReq(this);
		}

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x0600CF8C RID: 53132 RVA: 0x0022C3B2 File Offset: 0x0022A5B2
		// (set) Token: 0x0600CF8D RID: 53133 RVA: 0x0022C3BA File Offset: 0x0022A5BA
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

		// Token: 0x0600CF8E RID: 53134 RVA: 0x0022C3C3 File Offset: 0x0022A5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingDialogueSelectOptionCsReq);
		}

		// Token: 0x0600CF8F RID: 53135 RVA: 0x0022C3D1 File Offset: 0x0022A5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingDialogueSelectOptionCsReq other)
		{
			return other != null && (other == this || (this.OptionId == other.OptionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF90 RID: 53136 RVA: 0x0022C400 File Offset: 0x0022A600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600CF91 RID: 53137 RVA: 0x0022C43F File Offset: 0x0022A63F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CF92 RID: 53138 RVA: 0x0022C447 File Offset: 0x0022A647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF93 RID: 53139 RVA: 0x0022C450 File Offset: 0x0022A650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.OptionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF94 RID: 53140 RVA: 0x0022C484 File Offset: 0x0022A684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600CF95 RID: 53141 RVA: 0x0022C4C2 File Offset: 0x0022A6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingDialogueSelectOptionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OptionId != 0U)
			{
				this.OptionId = other.OptionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF96 RID: 53142 RVA: 0x0022C4F3 File Offset: 0x0022A6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF97 RID: 53143 RVA: 0x0022C4FC File Offset: 0x0022A6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.OptionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005383 RID: 21379
		private static readonly MessageParser<SwordTrainingDialogueSelectOptionCsReq> _parser = new MessageParser<SwordTrainingDialogueSelectOptionCsReq>(() => new SwordTrainingDialogueSelectOptionCsReq());

		// Token: 0x04005384 RID: 21380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005385 RID: 21381
		public const int OptionIdFieldNumber = 3;

		// Token: 0x04005386 RID: 21382
		private uint optionId_;
	}
}
