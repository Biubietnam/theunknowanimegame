using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001227 RID: 4647
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingDialogueSelectOptionScRsp : IMessage<SwordTrainingDialogueSelectOptionScRsp>, IMessage, IEquatable<SwordTrainingDialogueSelectOptionScRsp>, IDeepCloneable<SwordTrainingDialogueSelectOptionScRsp>, IBufferMessage
	{
		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x0600CF9B RID: 53147 RVA: 0x0022C5D1 File Offset: 0x0022A7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingDialogueSelectOptionScRsp> Parser
		{
			get
			{
				return SwordTrainingDialogueSelectOptionScRsp._parser;
			}
		}

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x0600CF9C RID: 53148 RVA: 0x0022C5D8 File Offset: 0x0022A7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingDialogueSelectOptionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x0600CF9D RID: 53149 RVA: 0x0022C5EA File Offset: 0x0022A7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingDialogueSelectOptionScRsp.Descriptor;
			}
		}

		// Token: 0x0600CF9E RID: 53150 RVA: 0x0022C5F1 File Offset: 0x0022A7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDialogueSelectOptionScRsp()
		{
		}

		// Token: 0x0600CF9F RID: 53151 RVA: 0x0022C5F9 File Offset: 0x0022A7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDialogueSelectOptionScRsp(SwordTrainingDialogueSelectOptionScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFA0 RID: 53152 RVA: 0x0022C61E File Offset: 0x0022A81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDialogueSelectOptionScRsp Clone()
		{
			return new SwordTrainingDialogueSelectOptionScRsp(this);
		}

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x0600CFA1 RID: 53153 RVA: 0x0022C626 File Offset: 0x0022A826
		// (set) Token: 0x0600CFA2 RID: 53154 RVA: 0x0022C62E File Offset: 0x0022A82E
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

		// Token: 0x0600CFA3 RID: 53155 RVA: 0x0022C637 File Offset: 0x0022A837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingDialogueSelectOptionScRsp);
		}

		// Token: 0x0600CFA4 RID: 53156 RVA: 0x0022C645 File Offset: 0x0022A845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingDialogueSelectOptionScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFA5 RID: 53157 RVA: 0x0022C674 File Offset: 0x0022A874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600CFA6 RID: 53158 RVA: 0x0022C6B3 File Offset: 0x0022A8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CFA7 RID: 53159 RVA: 0x0022C6BB File Offset: 0x0022A8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFA8 RID: 53160 RVA: 0x0022C6C4 File Offset: 0x0022A8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFA9 RID: 53161 RVA: 0x0022C6F8 File Offset: 0x0022A8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600CFAA RID: 53162 RVA: 0x0022C736 File Offset: 0x0022A936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingDialogueSelectOptionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CFAB RID: 53163 RVA: 0x0022C767 File Offset: 0x0022A967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFAC RID: 53164 RVA: 0x0022C770 File Offset: 0x0022A970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005388 RID: 21384
		private static readonly MessageParser<SwordTrainingDialogueSelectOptionScRsp> _parser = new MessageParser<SwordTrainingDialogueSelectOptionScRsp>(() => new SwordTrainingDialogueSelectOptionScRsp());

		// Token: 0x04005389 RID: 21385
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400538A RID: 21386
		public const int RetcodeFieldNumber = 4;

		// Token: 0x0400538B RID: 21387
		private uint retcode_;
	}
}
