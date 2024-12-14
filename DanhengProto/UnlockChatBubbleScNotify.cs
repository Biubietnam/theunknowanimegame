using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013C1 RID: 5057
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockChatBubbleScNotify : IMessage<UnlockChatBubbleScNotify>, IMessage, IEquatable<UnlockChatBubbleScNotify>, IDeepCloneable<UnlockChatBubbleScNotify>, IBufferMessage
	{
		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x0600E171 RID: 57713 RVA: 0x0025800C File Offset: 0x0025620C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockChatBubbleScNotify> Parser
		{
			get
			{
				return UnlockChatBubbleScNotify._parser;
			}
		}

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x0600E172 RID: 57714 RVA: 0x00258013 File Offset: 0x00256213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockChatBubbleScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x0600E173 RID: 57715 RVA: 0x00258025 File Offset: 0x00256225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockChatBubbleScNotify.Descriptor;
			}
		}

		// Token: 0x0600E174 RID: 57716 RVA: 0x0025802C File Offset: 0x0025622C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockChatBubbleScNotify()
		{
		}

		// Token: 0x0600E175 RID: 57717 RVA: 0x00258034 File Offset: 0x00256234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockChatBubbleScNotify(UnlockChatBubbleScNotify other) : this()
		{
			this.bubbleId_ = other.bubbleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E176 RID: 57718 RVA: 0x00258059 File Offset: 0x00256259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockChatBubbleScNotify Clone()
		{
			return new UnlockChatBubbleScNotify(this);
		}

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x0600E177 RID: 57719 RVA: 0x00258061 File Offset: 0x00256261
		// (set) Token: 0x0600E178 RID: 57720 RVA: 0x00258069 File Offset: 0x00256269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BubbleId
		{
			get
			{
				return this.bubbleId_;
			}
			set
			{
				this.bubbleId_ = value;
			}
		}

		// Token: 0x0600E179 RID: 57721 RVA: 0x00258072 File Offset: 0x00256272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockChatBubbleScNotify);
		}

		// Token: 0x0600E17A RID: 57722 RVA: 0x00258080 File Offset: 0x00256280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockChatBubbleScNotify other)
		{
			return other != null && (other == this || (this.BubbleId == other.BubbleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E17B RID: 57723 RVA: 0x002580B0 File Offset: 0x002562B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BubbleId != 0U)
			{
				num ^= this.BubbleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E17C RID: 57724 RVA: 0x002580EF File Offset: 0x002562EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E17D RID: 57725 RVA: 0x002580F7 File Offset: 0x002562F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E17E RID: 57726 RVA: 0x00258100 File Offset: 0x00256300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BubbleId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.BubbleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E17F RID: 57727 RVA: 0x00258134 File Offset: 0x00256334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BubbleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BubbleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E180 RID: 57728 RVA: 0x00258172 File Offset: 0x00256372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockChatBubbleScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BubbleId != 0U)
			{
				this.BubbleId = other.BubbleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E181 RID: 57729 RVA: 0x002581A3 File Offset: 0x002563A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E182 RID: 57730 RVA: 0x002581AC File Offset: 0x002563AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BubbleId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040059BF RID: 22975
		private static readonly MessageParser<UnlockChatBubbleScNotify> _parser = new MessageParser<UnlockChatBubbleScNotify>(() => new UnlockChatBubbleScNotify());

		// Token: 0x040059C0 RID: 22976
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059C1 RID: 22977
		public const int BubbleIdFieldNumber = 8;

		// Token: 0x040059C2 RID: 22978
		private uint bubbleId_;
	}
}
