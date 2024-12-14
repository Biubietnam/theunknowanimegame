using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F47 RID: 3911
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueModifier : IMessage<RogueModifier>, IMessage, IEquatable<RogueModifier>, IDeepCloneable<RogueModifier>, IBufferMessage
	{
		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x0600AE84 RID: 44676 RVA: 0x001D5463 File Offset: 0x001D3663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueModifier> Parser
		{
			get
			{
				return RogueModifier._parser;
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x0600AE85 RID: 44677 RVA: 0x001D546A File Offset: 0x001D366A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueModifierReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x0600AE86 RID: 44678 RVA: 0x001D547C File Offset: 0x001D367C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueModifier.Descriptor;
			}
		}

		// Token: 0x0600AE87 RID: 44679 RVA: 0x001D5483 File Offset: 0x001D3683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifier()
		{
		}

		// Token: 0x0600AE88 RID: 44680 RVA: 0x001D548C File Offset: 0x001D368C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifier(RogueModifier other) : this()
		{
			this.mainModifierEffect_ = other.mainModifierEffect_;
			this.modifierContent_ = ((other.modifierContent_ != null) ? other.modifierContent_.Clone() : null);
			this.modifierSourceType_ = other.modifierSourceType_;
			this.modifierInfo_ = ((other.modifierInfo_ != null) ? other.modifierInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE89 RID: 44681 RVA: 0x001D5500 File Offset: 0x001D3700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifier Clone()
		{
			return new RogueModifier(this);
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x0600AE8A RID: 44682 RVA: 0x001D5508 File Offset: 0x001D3708
		// (set) Token: 0x0600AE8B RID: 44683 RVA: 0x001D5510 File Offset: 0x001D3710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong MainModifierEffect
		{
			get
			{
				return this.mainModifierEffect_;
			}
			set
			{
				this.mainModifierEffect_ = value;
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x0600AE8C RID: 44684 RVA: 0x001D5519 File Offset: 0x001D3719
		// (set) Token: 0x0600AE8D RID: 44685 RVA: 0x001D5521 File Offset: 0x001D3721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierContent ModifierContent
		{
			get
			{
				return this.modifierContent_;
			}
			set
			{
				this.modifierContent_ = value;
			}
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x0600AE8E RID: 44686 RVA: 0x001D552A File Offset: 0x001D372A
		// (set) Token: 0x0600AE8F RID: 44687 RVA: 0x001D5532 File Offset: 0x001D3732
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

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x0600AE90 RID: 44688 RVA: 0x001D553B File Offset: 0x001D373B
		// (set) Token: 0x0600AE91 RID: 44689 RVA: 0x001D5543 File Offset: 0x001D3743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueModifierInfo ModifierInfo
		{
			get
			{
				return this.modifierInfo_;
			}
			set
			{
				this.modifierInfo_ = value;
			}
		}

		// Token: 0x0600AE92 RID: 44690 RVA: 0x001D554C File Offset: 0x001D374C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueModifier);
		}

		// Token: 0x0600AE93 RID: 44691 RVA: 0x001D555C File Offset: 0x001D375C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueModifier other)
		{
			return other != null && (other == this || (this.MainModifierEffect == other.MainModifierEffect && object.Equals(this.ModifierContent, other.ModifierContent) && this.ModifierSourceType == other.ModifierSourceType && object.Equals(this.ModifierInfo, other.ModifierInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE94 RID: 44692 RVA: 0x001D55D0 File Offset: 0x001D37D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MainModifierEffect != 0UL)
			{
				num ^= this.MainModifierEffect.GetHashCode();
			}
			if (this.modifierContent_ != null)
			{
				num ^= this.ModifierContent.GetHashCode();
			}
			if (this.ModifierSourceType != RogueModifierSourceType.RogueModifierSourceNone)
			{
				num ^= this.ModifierSourceType.GetHashCode();
			}
			if (this.modifierInfo_ != null)
			{
				num ^= this.ModifierInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE95 RID: 44693 RVA: 0x001D565A File Offset: 0x001D385A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE96 RID: 44694 RVA: 0x001D5662 File Offset: 0x001D3862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE97 RID: 44695 RVA: 0x001D566C File Offset: 0x001D386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainModifierEffect != 0UL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.MainModifierEffect);
			}
			if (this.modifierContent_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ModifierContent);
			}
			if (this.ModifierSourceType != RogueModifierSourceType.RogueModifierSourceNone)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ModifierSourceType);
			}
			if (this.modifierInfo_ != null)
			{
				output.WriteRawTag(186, 116);
				output.WriteMessage(this.ModifierInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE98 RID: 44696 RVA: 0x001D5704 File Offset: 0x001D3904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MainModifierEffect != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.MainModifierEffect);
			}
			if (this.modifierContent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ModifierContent);
			}
			if (this.ModifierSourceType != RogueModifierSourceType.RogueModifierSourceNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ModifierSourceType);
			}
			if (this.modifierInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ModifierInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE99 RID: 44697 RVA: 0x001D578C File Offset: 0x001D398C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueModifier other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MainModifierEffect != 0UL)
			{
				this.MainModifierEffect = other.MainModifierEffect;
			}
			if (other.modifierContent_ != null)
			{
				if (this.modifierContent_ == null)
				{
					this.ModifierContent = new RogueModifierContent();
				}
				this.ModifierContent.MergeFrom(other.ModifierContent);
			}
			if (other.ModifierSourceType != RogueModifierSourceType.RogueModifierSourceNone)
			{
				this.ModifierSourceType = other.ModifierSourceType;
			}
			if (other.modifierInfo_ != null)
			{
				if (this.modifierInfo_ == null)
				{
					this.ModifierInfo = new ChessRogueModifierInfo();
				}
				this.ModifierInfo.MergeFrom(other.ModifierInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE9A RID: 44698 RVA: 0x001D5834 File Offset: 0x001D3A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE9B RID: 44699 RVA: 0x001D5840 File Offset: 0x001D3A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.MainModifierEffect = input.ReadUInt64();
						continue;
					}
					if (num == 50U)
					{
						if (this.modifierContent_ == null)
						{
							this.ModifierContent = new RogueModifierContent();
						}
						input.ReadMessage(this.ModifierContent);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ModifierSourceType = (RogueModifierSourceType)input.ReadEnum();
						continue;
					}
					if (num == 14906U)
					{
						if (this.modifierInfo_ == null)
						{
							this.ModifierInfo = new ChessRogueModifierInfo();
						}
						input.ReadMessage(this.ModifierInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004708 RID: 18184
		private static readonly MessageParser<RogueModifier> _parser = new MessageParser<RogueModifier>(() => new RogueModifier());

		// Token: 0x04004709 RID: 18185
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400470A RID: 18186
		public const int MainModifierEffectFieldNumber = 2;

		// Token: 0x0400470B RID: 18187
		private ulong mainModifierEffect_;

		// Token: 0x0400470C RID: 18188
		public const int ModifierContentFieldNumber = 6;

		// Token: 0x0400470D RID: 18189
		private RogueModifierContent modifierContent_;

		// Token: 0x0400470E RID: 18190
		public const int ModifierSourceTypeFieldNumber = 8;

		// Token: 0x0400470F RID: 18191
		private RogueModifierSourceType modifierSourceType_;

		// Token: 0x04004710 RID: 18192
		public const int ModifierInfoFieldNumber = 1863;

		// Token: 0x04004711 RID: 18193
		private ChessRogueModifierInfo modifierInfo_;
	}
}
