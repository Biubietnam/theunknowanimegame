using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F49 RID: 3913
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueModifierAddNotify : IMessage<RogueModifierAddNotify>, IMessage, IEquatable<RogueModifierAddNotify>, IDeepCloneable<RogueModifierAddNotify>, IBufferMessage
	{
		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x0600AE9F RID: 44703 RVA: 0x001D5989 File Offset: 0x001D3B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueModifierAddNotify> Parser
		{
			get
			{
				return RogueModifierAddNotify._parser;
			}
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x0600AEA0 RID: 44704 RVA: 0x001D5990 File Offset: 0x001D3B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueModifierAddNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x0600AEA1 RID: 44705 RVA: 0x001D59A2 File Offset: 0x001D3BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueModifierAddNotify.Descriptor;
			}
		}

		// Token: 0x0600AEA2 RID: 44706 RVA: 0x001D59A9 File Offset: 0x001D3BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierAddNotify()
		{
		}

		// Token: 0x0600AEA3 RID: 44707 RVA: 0x001D59B1 File Offset: 0x001D3BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierAddNotify(RogueModifierAddNotify other) : this()
		{
			this.modifier_ = ((other.modifier_ != null) ? other.modifier_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEA4 RID: 44708 RVA: 0x001D59E6 File Offset: 0x001D3BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierAddNotify Clone()
		{
			return new RogueModifierAddNotify(this);
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x0600AEA5 RID: 44709 RVA: 0x001D59EE File Offset: 0x001D3BEE
		// (set) Token: 0x0600AEA6 RID: 44710 RVA: 0x001D59F6 File Offset: 0x001D3BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifier Modifier
		{
			get
			{
				return this.modifier_;
			}
			set
			{
				this.modifier_ = value;
			}
		}

		// Token: 0x0600AEA7 RID: 44711 RVA: 0x001D59FF File Offset: 0x001D3BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueModifierAddNotify);
		}

		// Token: 0x0600AEA8 RID: 44712 RVA: 0x001D5A0D File Offset: 0x001D3C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueModifierAddNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Modifier, other.Modifier) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AEA9 RID: 44713 RVA: 0x001D5A40 File Offset: 0x001D3C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.modifier_ != null)
			{
				num ^= this.Modifier.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEAA RID: 44714 RVA: 0x001D5A7C File Offset: 0x001D3C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AEAB RID: 44715 RVA: 0x001D5A84 File Offset: 0x001D3C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEAC RID: 44716 RVA: 0x001D5A8D File Offset: 0x001D3C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.modifier_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Modifier);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEAD RID: 44717 RVA: 0x001D5AC0 File Offset: 0x001D3CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.modifier_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Modifier);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEAE RID: 44718 RVA: 0x001D5B00 File Offset: 0x001D3D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueModifierAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.modifier_ != null)
			{
				if (this.modifier_ == null)
				{
					this.Modifier = new RogueModifier();
				}
				this.Modifier.MergeFrom(other.Modifier);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEAF RID: 44719 RVA: 0x001D5B54 File Offset: 0x001D3D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEB0 RID: 44720 RVA: 0x001D5B60 File Offset: 0x001D3D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.modifier_ == null)
					{
						this.Modifier = new RogueModifier();
					}
					input.ReadMessage(this.Modifier);
				}
			}
		}

		// Token: 0x04004713 RID: 18195
		private static readonly MessageParser<RogueModifierAddNotify> _parser = new MessageParser<RogueModifierAddNotify>(() => new RogueModifierAddNotify());

		// Token: 0x04004714 RID: 18196
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004715 RID: 18197
		public const int ModifierFieldNumber = 5;

		// Token: 0x04004716 RID: 18198
		private RogueModifier modifier_;
	}
}
