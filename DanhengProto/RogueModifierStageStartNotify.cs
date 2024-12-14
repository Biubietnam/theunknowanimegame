using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F57 RID: 3927
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueModifierStageStartNotify : IMessage<RogueModifierStageStartNotify>, IMessage, IEquatable<RogueModifierStageStartNotify>, IDeepCloneable<RogueModifierStageStartNotify>, IBufferMessage
	{
		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x0600AF14 RID: 44820 RVA: 0x001D6AC7 File Offset: 0x001D4CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueModifierStageStartNotify> Parser
		{
			get
			{
				return RogueModifierStageStartNotify._parser;
			}
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x0600AF15 RID: 44821 RVA: 0x001D6ACE File Offset: 0x001D4CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueModifierStageStartNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x0600AF16 RID: 44822 RVA: 0x001D6AE0 File Offset: 0x001D4CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueModifierStageStartNotify.Descriptor;
			}
		}

		// Token: 0x0600AF17 RID: 44823 RVA: 0x001D6AE7 File Offset: 0x001D4CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierStageStartNotify()
		{
		}

		// Token: 0x0600AF18 RID: 44824 RVA: 0x001D6AEF File Offset: 0x001D4CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierStageStartNotify(RogueModifierStageStartNotify other) : this()
		{
			this.modifierSourceType_ = other.modifierSourceType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF19 RID: 44825 RVA: 0x001D6B14 File Offset: 0x001D4D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierStageStartNotify Clone()
		{
			return new RogueModifierStageStartNotify(this);
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x0600AF1A RID: 44826 RVA: 0x001D6B1C File Offset: 0x001D4D1C
		// (set) Token: 0x0600AF1B RID: 44827 RVA: 0x001D6B24 File Offset: 0x001D4D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierSourceType ModifierSourceType
		{
			get
			{
				return this.modifierSourceType_;
			}
			set
			{
				this.modifierSourceType_ = value;
			}
		}

		// Token: 0x0600AF1C RID: 44828 RVA: 0x001D6B2D File Offset: 0x001D4D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueModifierStageStartNotify);
		}

		// Token: 0x0600AF1D RID: 44829 RVA: 0x001D6B3B File Offset: 0x001D4D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueModifierStageStartNotify other)
		{
			return other != null && (other == this || (this.ModifierSourceType == other.ModifierSourceType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF1E RID: 44830 RVA: 0x001D6B6C File Offset: 0x001D4D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ModifierSourceType != RogueModifierSourceType.RogueModifierSourceNone)
			{
				num ^= this.ModifierSourceType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF1F RID: 44831 RVA: 0x001D6BB1 File Offset: 0x001D4DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF20 RID: 44832 RVA: 0x001D6BB9 File Offset: 0x001D4DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF21 RID: 44833 RVA: 0x001D6BC2 File Offset: 0x001D4DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ModifierSourceType != RogueModifierSourceType.RogueModifierSourceNone)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ModifierSourceType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF22 RID: 44834 RVA: 0x001D6BF4 File Offset: 0x001D4DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ModifierSourceType != RogueModifierSourceType.RogueModifierSourceNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ModifierSourceType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF23 RID: 44835 RVA: 0x001D6C32 File Offset: 0x001D4E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueModifierStageStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ModifierSourceType != RogueModifierSourceType.RogueModifierSourceNone)
			{
				this.ModifierSourceType = other.ModifierSourceType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF24 RID: 44836 RVA: 0x001D6C63 File Offset: 0x001D4E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF25 RID: 44837 RVA: 0x001D6C6C File Offset: 0x001D4E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ModifierSourceType = (RogueModifierSourceType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004744 RID: 18244
		private static readonly MessageParser<RogueModifierStageStartNotify> _parser = new MessageParser<RogueModifierStageStartNotify>(() => new RogueModifierStageStartNotify());

		// Token: 0x04004745 RID: 18245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004746 RID: 18246
		public const int ModifierSourceTypeFieldNumber = 2;

		// Token: 0x04004747 RID: 18247
		private RogueModifierSourceType modifierSourceType_;
	}
}
