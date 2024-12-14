using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200085D RID: 2141
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GIPDAFLPJNN : IMessage<GIPDAFLPJNN>, IMessage, IEquatable<GIPDAFLPJNN>, IDeepCloneable<GIPDAFLPJNN>, IBufferMessage
	{
		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06005F3B RID: 24379 RVA: 0x000FC0F4 File Offset: 0x000FA2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GIPDAFLPJNN> Parser
		{
			get
			{
				return GIPDAFLPJNN._parser;
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06005F3C RID: 24380 RVA: 0x000FC0FB File Offset: 0x000FA2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GIPDAFLPJNNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06005F3D RID: 24381 RVA: 0x000FC10D File Offset: 0x000FA30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GIPDAFLPJNN.Descriptor;
			}
		}

		// Token: 0x06005F3E RID: 24382 RVA: 0x000FC114 File Offset: 0x000FA314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GIPDAFLPJNN()
		{
		}

		// Token: 0x06005F3F RID: 24383 RVA: 0x000FC11C File Offset: 0x000FA31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GIPDAFLPJNN(GIPDAFLPJNN other) : this()
		{
			this.dialogueId_ = other.dialogueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F40 RID: 24384 RVA: 0x000FC141 File Offset: 0x000FA341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GIPDAFLPJNN Clone()
		{
			return new GIPDAFLPJNN(this);
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06005F41 RID: 24385 RVA: 0x000FC149 File Offset: 0x000FA349
		// (set) Token: 0x06005F42 RID: 24386 RVA: 0x000FC151 File Offset: 0x000FA351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DialogueId
		{
			get
			{
				return this.dialogueId_;
			}
			set
			{
				this.dialogueId_ = value;
			}
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x000FC15A File Offset: 0x000FA35A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GIPDAFLPJNN);
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x000FC168 File Offset: 0x000FA368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GIPDAFLPJNN other)
		{
			return other != null && (other == this || (this.DialogueId == other.DialogueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x000FC198 File Offset: 0x000FA398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DialogueId != 0U)
			{
				num ^= this.DialogueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x000FC1D7 File Offset: 0x000FA3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x000FC1DF File Offset: 0x000FA3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x000FC1E8 File Offset: 0x000FA3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DialogueId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.DialogueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x000FC21C File Offset: 0x000FA41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DialogueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DialogueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x000FC25A File Offset: 0x000FA45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GIPDAFLPJNN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DialogueId != 0U)
			{
				this.DialogueId = other.DialogueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x000FC28B File Offset: 0x000FA48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F4C RID: 24396 RVA: 0x000FC294 File Offset: 0x000FA494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DialogueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040024A8 RID: 9384
		private static readonly MessageParser<GIPDAFLPJNN> _parser = new MessageParser<GIPDAFLPJNN>(() => new GIPDAFLPJNN());

		// Token: 0x040024A9 RID: 9385
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024AA RID: 9386
		public const int DialogueIdFieldNumber = 9;

		// Token: 0x040024AB RID: 9387
		private uint dialogueId_;
	}
}
