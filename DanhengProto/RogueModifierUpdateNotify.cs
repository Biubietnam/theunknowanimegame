using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F59 RID: 3929
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueModifierUpdateNotify : IMessage<RogueModifierUpdateNotify>, IMessage, IEquatable<RogueModifierUpdateNotify>, IDeepCloneable<RogueModifierUpdateNotify>, IBufferMessage
	{
		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x0600AF29 RID: 44841 RVA: 0x001D6D49 File Offset: 0x001D4F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueModifierUpdateNotify> Parser
		{
			get
			{
				return RogueModifierUpdateNotify._parser;
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x0600AF2A RID: 44842 RVA: 0x001D6D50 File Offset: 0x001D4F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueModifierUpdateNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x0600AF2B RID: 44843 RVA: 0x001D6D62 File Offset: 0x001D4F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueModifierUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AF2C RID: 44844 RVA: 0x001D6D69 File Offset: 0x001D4F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierUpdateNotify()
		{
		}

		// Token: 0x0600AF2D RID: 44845 RVA: 0x001D6D71 File Offset: 0x001D4F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierUpdateNotify(RogueModifierUpdateNotify other) : this()
		{
			this.modifier_ = ((other.modifier_ != null) ? other.modifier_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x001D6DA6 File Offset: 0x001D4FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierUpdateNotify Clone()
		{
			return new RogueModifierUpdateNotify(this);
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x0600AF2F RID: 44847 RVA: 0x001D6DAE File Offset: 0x001D4FAE
		// (set) Token: 0x0600AF30 RID: 44848 RVA: 0x001D6DB6 File Offset: 0x001D4FB6
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

		// Token: 0x0600AF31 RID: 44849 RVA: 0x001D6DBF File Offset: 0x001D4FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueModifierUpdateNotify);
		}

		// Token: 0x0600AF32 RID: 44850 RVA: 0x001D6DCD File Offset: 0x001D4FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueModifierUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Modifier, other.Modifier) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF33 RID: 44851 RVA: 0x001D6E00 File Offset: 0x001D5000
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

		// Token: 0x0600AF34 RID: 44852 RVA: 0x001D6E3C File Offset: 0x001D503C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF35 RID: 44853 RVA: 0x001D6E44 File Offset: 0x001D5044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF36 RID: 44854 RVA: 0x001D6E4D File Offset: 0x001D504D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.modifier_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Modifier);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF37 RID: 44855 RVA: 0x001D6E80 File Offset: 0x001D5080
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

		// Token: 0x0600AF38 RID: 44856 RVA: 0x001D6EC0 File Offset: 0x001D50C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueModifierUpdateNotify other)
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

		// Token: 0x0600AF39 RID: 44857 RVA: 0x001D6F14 File Offset: 0x001D5114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF3A RID: 44858 RVA: 0x001D6F20 File Offset: 0x001D5120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 122U)
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

		// Token: 0x04004749 RID: 18249
		private static readonly MessageParser<RogueModifierUpdateNotify> _parser = new MessageParser<RogueModifierUpdateNotify>(() => new RogueModifierUpdateNotify());

		// Token: 0x0400474A RID: 18250
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400474B RID: 18251
		public const int ModifierFieldNumber = 15;

		// Token: 0x0400474C RID: 18252
		private RogueModifier modifier_;
	}
}
