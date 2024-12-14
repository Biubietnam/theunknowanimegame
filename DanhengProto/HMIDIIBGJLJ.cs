using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008FF RID: 2303
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HMIDIIBGJLJ : IMessage<HMIDIIBGJLJ>, IMessage, IEquatable<HMIDIIBGJLJ>, IDeepCloneable<HMIDIIBGJLJ>, IBufferMessage
	{
		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x060066C2 RID: 26306 RVA: 0x00112982 File Offset: 0x00110B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HMIDIIBGJLJ> Parser
		{
			get
			{
				return HMIDIIBGJLJ._parser;
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x060066C3 RID: 26307 RVA: 0x00112989 File Offset: 0x00110B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HMIDIIBGJLJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x060066C4 RID: 26308 RVA: 0x0011299B File Offset: 0x00110B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HMIDIIBGJLJ.Descriptor;
			}
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x001129A2 File Offset: 0x00110BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMIDIIBGJLJ()
		{
		}

		// Token: 0x060066C6 RID: 26310 RVA: 0x001129AA File Offset: 0x00110BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMIDIIBGJLJ(HMIDIIBGJLJ other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x001129C3 File Offset: 0x00110BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMIDIIBGJLJ Clone()
		{
			return new HMIDIIBGJLJ(this);
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x001129CB File Offset: 0x00110BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HMIDIIBGJLJ);
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x001129D9 File Offset: 0x00110BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HMIDIIBGJLJ other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x001129F8 File Offset: 0x00110BF8
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

		// Token: 0x060066CB RID: 26315 RVA: 0x00112A1E File Offset: 0x00110C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x00112A26 File Offset: 0x00110C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x00112A2F File Offset: 0x00110C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x00112A48 File Offset: 0x00110C48
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

		// Token: 0x060066CF RID: 26319 RVA: 0x00112A6E File Offset: 0x00110C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HMIDIIBGJLJ other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x00112A8B File Offset: 0x00110C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x00112A94 File Offset: 0x00110C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400277D RID: 10109
		private static readonly MessageParser<HMIDIIBGJLJ> _parser = new MessageParser<HMIDIIBGJLJ>(() => new HMIDIIBGJLJ());

		// Token: 0x0400277E RID: 10110
		private UnknownFieldSet _unknownFields;
	}
}
