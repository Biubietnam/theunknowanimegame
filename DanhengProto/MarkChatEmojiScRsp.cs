using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A87 RID: 2695
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MarkChatEmojiScRsp : IMessage<MarkChatEmojiScRsp>, IMessage, IEquatable<MarkChatEmojiScRsp>, IDeepCloneable<MarkChatEmojiScRsp>, IBufferMessage
	{
		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06007777 RID: 30583 RVA: 0x0013CDC9 File Offset: 0x0013AFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkChatEmojiScRsp> Parser
		{
			get
			{
				return MarkChatEmojiScRsp._parser;
			}
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x06007778 RID: 30584 RVA: 0x0013CDD0 File Offset: 0x0013AFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MarkChatEmojiScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x06007779 RID: 30585 RVA: 0x0013CDE2 File Offset: 0x0013AFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkChatEmojiScRsp.Descriptor;
			}
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x0013CDE9 File Offset: 0x0013AFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkChatEmojiScRsp()
		{
		}

		// Token: 0x0600777B RID: 30587 RVA: 0x0013CDF1 File Offset: 0x0013AFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkChatEmojiScRsp(MarkChatEmojiScRsp other) : this()
		{
			this.extraId_ = other.extraId_;
			this.retcode_ = other.retcode_;
			this.isRemoveId_ = other.isRemoveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600777C RID: 30588 RVA: 0x0013CE2E File Offset: 0x0013B02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkChatEmojiScRsp Clone()
		{
			return new MarkChatEmojiScRsp(this);
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x0600777D RID: 30589 RVA: 0x0013CE36 File Offset: 0x0013B036
		// (set) Token: 0x0600777E RID: 30590 RVA: 0x0013CE3E File Offset: 0x0013B03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ExtraId
		{
			get
			{
				return this.extraId_;
			}
			set
			{
				this.extraId_ = value;
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x0600777F RID: 30591 RVA: 0x0013CE47 File Offset: 0x0013B047
		// (set) Token: 0x06007780 RID: 30592 RVA: 0x0013CE4F File Offset: 0x0013B04F
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

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06007781 RID: 30593 RVA: 0x0013CE58 File Offset: 0x0013B058
		// (set) Token: 0x06007782 RID: 30594 RVA: 0x0013CE60 File Offset: 0x0013B060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRemoveId
		{
			get
			{
				return this.isRemoveId_;
			}
			set
			{
				this.isRemoveId_ = value;
			}
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x0013CE69 File Offset: 0x0013B069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkChatEmojiScRsp);
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x0013CE78 File Offset: 0x0013B078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkChatEmojiScRsp other)
		{
			return other != null && (other == this || (this.ExtraId == other.ExtraId && this.Retcode == other.Retcode && this.IsRemoveId == other.IsRemoveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x0013CED4 File Offset: 0x0013B0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExtraId != 0U)
			{
				num ^= this.ExtraId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.IsRemoveId)
			{
				num ^= this.IsRemoveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x0013CF45 File Offset: 0x0013B145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x0013CF4D File Offset: 0x0013B14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007788 RID: 30600 RVA: 0x0013CF58 File Offset: 0x0013B158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExtraId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ExtraId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.IsRemoveId)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsRemoveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x0013CFD0 File Offset: 0x0013B1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExtraId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExtraId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.IsRemoveId)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x0013D034 File Offset: 0x0013B234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkChatEmojiScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExtraId != 0U)
			{
				this.ExtraId = other.ExtraId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.IsRemoveId)
			{
				this.IsRemoveId = other.IsRemoveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x0013D098 File Offset: 0x0013B298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x0013D0A4 File Offset: 0x0013B2A4
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
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsRemoveId = input.ReadBool();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.ExtraId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002DDF RID: 11743
		private static readonly MessageParser<MarkChatEmojiScRsp> _parser = new MessageParser<MarkChatEmojiScRsp>(() => new MarkChatEmojiScRsp());

		// Token: 0x04002DE0 RID: 11744
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DE1 RID: 11745
		public const int ExtraIdFieldNumber = 6;

		// Token: 0x04002DE2 RID: 11746
		private uint extraId_;

		// Token: 0x04002DE3 RID: 11747
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04002DE4 RID: 11748
		private uint retcode_;

		// Token: 0x04002DE5 RID: 11749
		public const int IsRemoveIdFieldNumber = 15;

		// Token: 0x04002DE6 RID: 11750
		private bool isRemoveId_;
	}
}
