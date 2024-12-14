using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F4F RID: 3919
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueModifierDelNotify : IMessage<RogueModifierDelNotify>, IMessage, IEquatable<RogueModifierDelNotify>, IDeepCloneable<RogueModifierDelNotify>, IBufferMessage
	{
		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x0600AECF RID: 44751 RVA: 0x001D60BC File Offset: 0x001D42BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueModifierDelNotify> Parser
		{
			get
			{
				return RogueModifierDelNotify._parser;
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x0600AED0 RID: 44752 RVA: 0x001D60C3 File Offset: 0x001D42C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueModifierDelNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x0600AED1 RID: 44753 RVA: 0x001D60D5 File Offset: 0x001D42D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueModifierDelNotify.Descriptor;
			}
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x001D60DC File Offset: 0x001D42DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierDelNotify()
		{
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x001D60E4 File Offset: 0x001D42E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierDelNotify(RogueModifierDelNotify other) : this()
		{
			this.mainModifierEffect_ = other.mainModifierEffect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x001D6109 File Offset: 0x001D4309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierDelNotify Clone()
		{
			return new RogueModifierDelNotify(this);
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x0600AED5 RID: 44757 RVA: 0x001D6111 File Offset: 0x001D4311
		// (set) Token: 0x0600AED6 RID: 44758 RVA: 0x001D6119 File Offset: 0x001D4319
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

		// Token: 0x0600AED7 RID: 44759 RVA: 0x001D6122 File Offset: 0x001D4322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueModifierDelNotify);
		}

		// Token: 0x0600AED8 RID: 44760 RVA: 0x001D6130 File Offset: 0x001D4330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueModifierDelNotify other)
		{
			return other != null && (other == this || (this.MainModifierEffect == other.MainModifierEffect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AED9 RID: 44761 RVA: 0x001D6160 File Offset: 0x001D4360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MainModifierEffect != 0UL)
			{
				num ^= this.MainModifierEffect.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEDA RID: 44762 RVA: 0x001D619F File Offset: 0x001D439F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AEDB RID: 44763 RVA: 0x001D61A7 File Offset: 0x001D43A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x001D61B0 File Offset: 0x001D43B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainModifierEffect != 0UL)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.MainModifierEffect);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x001D61E4 File Offset: 0x001D43E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MainModifierEffect != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.MainModifierEffect);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x001D6222 File Offset: 0x001D4422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueModifierDelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MainModifierEffect != 0UL)
			{
				this.MainModifierEffect = other.MainModifierEffect;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x001D6253 File Offset: 0x001D4453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x001D625C File Offset: 0x001D445C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MainModifierEffect = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004725 RID: 18213
		private static readonly MessageParser<RogueModifierDelNotify> _parser = new MessageParser<RogueModifierDelNotify>(() => new RogueModifierDelNotify());

		// Token: 0x04004726 RID: 18214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004727 RID: 18215
		public const int MainModifierEffectFieldNumber = 1;

		// Token: 0x04004728 RID: 18216
		private ulong mainModifierEffect_;
	}
}
