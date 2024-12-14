using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200064F RID: 1615
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChatEmojiListCsReq : IMessage<GetChatEmojiListCsReq>, IMessage, IEquatable<GetChatEmojiListCsReq>, IDeepCloneable<GetChatEmojiListCsReq>, IBufferMessage
	{
		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06004878 RID: 18552 RVA: 0x000C6417 File Offset: 0x000C4617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChatEmojiListCsReq> Parser
		{
			get
			{
				return GetChatEmojiListCsReq._parser;
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06004879 RID: 18553 RVA: 0x000C641E File Offset: 0x000C461E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChatEmojiListCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600487A RID: 18554 RVA: 0x000C6430 File Offset: 0x000C4630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChatEmojiListCsReq.Descriptor;
			}
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x000C6437 File Offset: 0x000C4637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatEmojiListCsReq()
		{
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x000C643F File Offset: 0x000C463F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatEmojiListCsReq(GetChatEmojiListCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x000C6458 File Offset: 0x000C4658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatEmojiListCsReq Clone()
		{
			return new GetChatEmojiListCsReq(this);
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x000C6460 File Offset: 0x000C4660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChatEmojiListCsReq);
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x000C646E File Offset: 0x000C466E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChatEmojiListCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x000C648C File Offset: 0x000C468C
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

		// Token: 0x06004881 RID: 18561 RVA: 0x000C64B2 File Offset: 0x000C46B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x000C64BA File Offset: 0x000C46BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x000C64C3 File Offset: 0x000C46C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x000C64DC File Offset: 0x000C46DC
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

		// Token: 0x06004885 RID: 18565 RVA: 0x000C6502 File Offset: 0x000C4702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChatEmojiListCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x000C651F File Offset: 0x000C471F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x000C6528 File Offset: 0x000C4728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001CF8 RID: 7416
		private static readonly MessageParser<GetChatEmojiListCsReq> _parser = new MessageParser<GetChatEmojiListCsReq>(() => new GetChatEmojiListCsReq());

		// Token: 0x04001CF9 RID: 7417
		private UnknownFieldSet _unknownFields;
	}
}
