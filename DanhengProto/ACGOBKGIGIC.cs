using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000029 RID: 41
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ACGOBKGIGIC : IMessage<ACGOBKGIGIC>, IMessage, IEquatable<ACGOBKGIGIC>, IDeepCloneable<ACGOBKGIGIC>, IBufferMessage
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000563E File Offset: 0x0000383E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ACGOBKGIGIC> Parser
		{
			get
			{
				return ACGOBKGIGIC._parser;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00005645 File Offset: 0x00003845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ACGOBKGIGICReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00005657 File Offset: 0x00003857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ACGOBKGIGIC.Descriptor;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000565E File Offset: 0x0000385E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACGOBKGIGIC()
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00005666 File Offset: 0x00003866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACGOBKGIGIC(ACGOBKGIGIC other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000567F File Offset: 0x0000387F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACGOBKGIGIC Clone()
		{
			return new ACGOBKGIGIC(this);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00005687 File Offset: 0x00003887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ACGOBKGIGIC);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00005695 File Offset: 0x00003895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ACGOBKGIGIC other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000056B4 File Offset: 0x000038B4
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

		// Token: 0x06000188 RID: 392 RVA: 0x000056DA File Offset: 0x000038DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000056E2 File Offset: 0x000038E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000056EB File Offset: 0x000038EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005704 File Offset: 0x00003904
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

		// Token: 0x0600018C RID: 396 RVA: 0x0000572A File Offset: 0x0000392A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ACGOBKGIGIC other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00005747 File Offset: 0x00003947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005750 File Offset: 0x00003950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400007D RID: 125
		private static readonly MessageParser<ACGOBKGIGIC> _parser = new MessageParser<ACGOBKGIGIC>(() => new ACGOBKGIGIC());

		// Token: 0x0400007E RID: 126
		private UnknownFieldSet _unknownFields;
	}
}
