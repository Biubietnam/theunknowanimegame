using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EA1 RID: 3745
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueHexAvatarSelectCallback : IMessage<RogueHexAvatarSelectCallback>, IMessage, IEquatable<RogueHexAvatarSelectCallback>, IDeepCloneable<RogueHexAvatarSelectCallback>, IBufferMessage
	{
		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x0600A753 RID: 42835 RVA: 0x001C2C83 File Offset: 0x001C0E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueHexAvatarSelectCallback> Parser
		{
			get
			{
				return RogueHexAvatarSelectCallback._parser;
			}
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x0600A754 RID: 42836 RVA: 0x001C2C8A File Offset: 0x001C0E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueHexAvatarSelectCallbackReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x0600A755 RID: 42837 RVA: 0x001C2C9C File Offset: 0x001C0E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueHexAvatarSelectCallback.Descriptor;
			}
		}

		// Token: 0x0600A756 RID: 42838 RVA: 0x001C2CA3 File Offset: 0x001C0EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectCallback()
		{
		}

		// Token: 0x0600A757 RID: 42839 RVA: 0x001C2CAB File Offset: 0x001C0EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectCallback(RogueHexAvatarSelectCallback other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A758 RID: 42840 RVA: 0x001C2CC4 File Offset: 0x001C0EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectCallback Clone()
		{
			return new RogueHexAvatarSelectCallback(this);
		}

		// Token: 0x0600A759 RID: 42841 RVA: 0x001C2CCC File Offset: 0x001C0ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueHexAvatarSelectCallback);
		}

		// Token: 0x0600A75A RID: 42842 RVA: 0x001C2CDA File Offset: 0x001C0EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueHexAvatarSelectCallback other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x001C2CF8 File Offset: 0x001C0EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x001C2D1E File Offset: 0x001C0F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A75D RID: 42845 RVA: 0x001C2D26 File Offset: 0x001C0F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x001C2D2F File Offset: 0x001C0F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x001C2D48 File Offset: 0x001C0F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x001C2D6E File Offset: 0x001C0F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueHexAvatarSelectCallback other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x001C2D8B File Offset: 0x001C0F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x001C2D94 File Offset: 0x001C0F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004470 RID: 17520
		private static readonly MessageParser<RogueHexAvatarSelectCallback> _parser = new MessageParser<RogueHexAvatarSelectCallback>(() => new RogueHexAvatarSelectCallback());

		// Token: 0x04004471 RID: 17521
		private UnknownFieldSet _unknownFields;
	}
}
