using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F4B RID: 3915
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueModifierContent : IMessage<RogueModifierContent>, IMessage, IEquatable<RogueModifierContent>, IDeepCloneable<RogueModifierContent>, IBufferMessage
	{
		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x0600AEB4 RID: 44724 RVA: 0x001D5C7F File Offset: 0x001D3E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueModifierContent> Parser
		{
			get
			{
				return RogueModifierContent._parser;
			}
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x0600AEB5 RID: 44725 RVA: 0x001D5C86 File Offset: 0x001D3E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueModifierContentReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x0600AEB6 RID: 44726 RVA: 0x001D5C98 File Offset: 0x001D3E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueModifierContent.Descriptor;
			}
		}

		// Token: 0x0600AEB7 RID: 44727 RVA: 0x001D5C9F File Offset: 0x001D3E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierContent()
		{
		}

		// Token: 0x0600AEB8 RID: 44728 RVA: 0x001D5CA7 File Offset: 0x001D3EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierContent(RogueModifierContent other) : this()
		{
			this.contentModifierEffectId_ = other.contentModifierEffectId_;
			this.modifierContentType_ = other.modifierContentType_;
			this.gFDNEJLPCMB_ = other.gFDNEJLPCMB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEB9 RID: 44729 RVA: 0x001D5CE4 File Offset: 0x001D3EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierContent Clone()
		{
			return new RogueModifierContent(this);
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x0600AEBA RID: 44730 RVA: 0x001D5CEC File Offset: 0x001D3EEC
		// (set) Token: 0x0600AEBB RID: 44731 RVA: 0x001D5CF4 File Offset: 0x001D3EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentModifierEffectId
		{
			get
			{
				return this.contentModifierEffectId_;
			}
			set
			{
				this.contentModifierEffectId_ = value;
			}
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x0600AEBC RID: 44732 RVA: 0x001D5CFD File Offset: 0x001D3EFD
		// (set) Token: 0x0600AEBD RID: 44733 RVA: 0x001D5D05 File Offset: 0x001D3F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierContentType ModifierContentType
		{
			get
			{
				return this.modifierContentType_;
			}
			set
			{
				this.modifierContentType_ = value;
			}
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x0600AEBE RID: 44734 RVA: 0x001D5D0E File Offset: 0x001D3F0E
		// (set) Token: 0x0600AEBF RID: 44735 RVA: 0x001D5D16 File Offset: 0x001D3F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GFDNEJLPCMB
		{
			get
			{
				return this.gFDNEJLPCMB_;
			}
			set
			{
				this.gFDNEJLPCMB_ = value;
			}
		}

		// Token: 0x0600AEC0 RID: 44736 RVA: 0x001D5D1F File Offset: 0x001D3F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueModifierContent);
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x001D5D30 File Offset: 0x001D3F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueModifierContent other)
		{
			return other != null && (other == this || (this.ContentModifierEffectId == other.ContentModifierEffectId && this.ModifierContentType == other.ModifierContentType && this.GFDNEJLPCMB == other.GFDNEJLPCMB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AEC2 RID: 44738 RVA: 0x001D5D8C File Offset: 0x001D3F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContentModifierEffectId != 0U)
			{
				num ^= this.ContentModifierEffectId.GetHashCode();
			}
			if (this.ModifierContentType != RogueModifierContentType.RogueModifierContentDefinite)
			{
				num ^= this.ModifierContentType.GetHashCode();
			}
			if (this.GFDNEJLPCMB != 0U)
			{
				num ^= this.GFDNEJLPCMB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x001D5E03 File Offset: 0x001D4003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x001D5E0B File Offset: 0x001D400B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x001D5E14 File Offset: 0x001D4014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContentModifierEffectId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ContentModifierEffectId);
			}
			if (this.ModifierContentType != RogueModifierContentType.RogueModifierContentDefinite)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ModifierContentType);
			}
			if (this.GFDNEJLPCMB != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GFDNEJLPCMB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x001D5E8C File Offset: 0x001D408C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContentModifierEffectId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentModifierEffectId);
			}
			if (this.ModifierContentType != RogueModifierContentType.RogueModifierContentDefinite)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ModifierContentType);
			}
			if (this.GFDNEJLPCMB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GFDNEJLPCMB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x001D5EFC File Offset: 0x001D40FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueModifierContent other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContentModifierEffectId != 0U)
			{
				this.ContentModifierEffectId = other.ContentModifierEffectId;
			}
			if (other.ModifierContentType != RogueModifierContentType.RogueModifierContentDefinite)
			{
				this.ModifierContentType = other.ModifierContentType;
			}
			if (other.GFDNEJLPCMB != 0U)
			{
				this.GFDNEJLPCMB = other.GFDNEJLPCMB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x001D5F60 File Offset: 0x001D4160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x001D5F6C File Offset: 0x001D416C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 56U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GFDNEJLPCMB = input.ReadUInt32();
						}
					}
					else
					{
						this.ModifierContentType = (RogueModifierContentType)input.ReadEnum();
					}
				}
				else
				{
					this.ContentModifierEffectId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004718 RID: 18200
		private static readonly MessageParser<RogueModifierContent> _parser = new MessageParser<RogueModifierContent>(() => new RogueModifierContent());

		// Token: 0x04004719 RID: 18201
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400471A RID: 18202
		public const int ContentModifierEffectIdFieldNumber = 3;

		// Token: 0x0400471B RID: 18203
		private uint contentModifierEffectId_;

		// Token: 0x0400471C RID: 18204
		public const int ModifierContentTypeFieldNumber = 7;

		// Token: 0x0400471D RID: 18205
		private RogueModifierContentType modifierContentType_;

		// Token: 0x0400471E RID: 18206
		public const int GFDNEJLPCMBFieldNumber = 14;

		// Token: 0x0400471F RID: 18207
		private uint gFDNEJLPCMB_;
	}
}
