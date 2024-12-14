using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E0F RID: 3599
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBonusSelectCallback : IMessage<RogueBonusSelectCallback>, IMessage, IEquatable<RogueBonusSelectCallback>, IDeepCloneable<RogueBonusSelectCallback>, IBufferMessage
	{
		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x0600A0DA RID: 41178 RVA: 0x001AF89F File Offset: 0x001ADA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBonusSelectCallback> Parser
		{
			get
			{
				return RogueBonusSelectCallback._parser;
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x0600A0DB RID: 41179 RVA: 0x001AF8A6 File Offset: 0x001ADAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBonusSelectCallbackReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x0600A0DC RID: 41180 RVA: 0x001AF8B8 File Offset: 0x001ADAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBonusSelectCallback.Descriptor;
			}
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x001AF8BF File Offset: 0x001ADABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectCallback()
		{
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x001AF8C7 File Offset: 0x001ADAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectCallback(RogueBonusSelectCallback other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x001AF8E0 File Offset: 0x001ADAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectCallback Clone()
		{
			return new RogueBonusSelectCallback(this);
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x001AF8E8 File Offset: 0x001ADAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBonusSelectCallback);
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x001AF8F6 File Offset: 0x001ADAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBonusSelectCallback other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x001AF914 File Offset: 0x001ADB14
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

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x001AF93A File Offset: 0x001ADB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A0E4 RID: 41188 RVA: 0x001AF942 File Offset: 0x001ADB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x001AF94B File Offset: 0x001ADB4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x001AF964 File Offset: 0x001ADB64
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

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x001AF98A File Offset: 0x001ADB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBonusSelectCallback other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x001AF9A7 File Offset: 0x001ADBA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0E9 RID: 41193 RVA: 0x001AF9B0 File Offset: 0x001ADBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040041E3 RID: 16867
		private static readonly MessageParser<RogueBonusSelectCallback> _parser = new MessageParser<RogueBonusSelectCallback>(() => new RogueBonusSelectCallback());

		// Token: 0x040041E4 RID: 16868
		private UnknownFieldSet _unknownFields;
	}
}
