using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F0B RID: 3851
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicScepterSelectCallback : IMessage<RogueMagicScepterSelectCallback>, IMessage, IEquatable<RogueMagicScepterSelectCallback>, IDeepCloneable<RogueMagicScepterSelectCallback>, IBufferMessage
	{
		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x0600ABEE RID: 44014 RVA: 0x001CEECF File Offset: 0x001CD0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicScepterSelectCallback> Parser
		{
			get
			{
				return RogueMagicScepterSelectCallback._parser;
			}
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x0600ABEF RID: 44015 RVA: 0x001CEED6 File Offset: 0x001CD0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterSelectCallbackReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x0600ABF0 RID: 44016 RVA: 0x001CEEE8 File Offset: 0x001CD0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicScepterSelectCallback.Descriptor;
			}
		}

		// Token: 0x0600ABF1 RID: 44017 RVA: 0x001CEEEF File Offset: 0x001CD0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectCallback()
		{
		}

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x001CEEF7 File Offset: 0x001CD0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectCallback(RogueMagicScepterSelectCallback other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x001CEF10 File Offset: 0x001CD110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectCallback Clone()
		{
			return new RogueMagicScepterSelectCallback(this);
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x001CEF18 File Offset: 0x001CD118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicScepterSelectCallback);
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x001CEF26 File Offset: 0x001CD126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicScepterSelectCallback other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x001CEF44 File Offset: 0x001CD144
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

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x001CEF6A File Offset: 0x001CD16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ABF8 RID: 44024 RVA: 0x001CEF72 File Offset: 0x001CD172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABF9 RID: 44025 RVA: 0x001CEF7B File Offset: 0x001CD17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABFA RID: 44026 RVA: 0x001CEF94 File Offset: 0x001CD194
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

		// Token: 0x0600ABFB RID: 44027 RVA: 0x001CEFBA File Offset: 0x001CD1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicScepterSelectCallback other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ABFC RID: 44028 RVA: 0x001CEFD7 File Offset: 0x001CD1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABFD RID: 44029 RVA: 0x001CEFE0 File Offset: 0x001CD1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004620 RID: 17952
		private static readonly MessageParser<RogueMagicScepterSelectCallback> _parser = new MessageParser<RogueMagicScepterSelectCallback>(() => new RogueMagicScepterSelectCallback());

		// Token: 0x04004621 RID: 17953
		private UnknownFieldSet _unknownFields;
	}
}
