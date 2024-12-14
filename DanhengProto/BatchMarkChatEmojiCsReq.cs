using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000D5 RID: 213
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BatchMarkChatEmojiCsReq : IMessage<BatchMarkChatEmojiCsReq>, IMessage, IEquatable<BatchMarkChatEmojiCsReq>, IDeepCloneable<BatchMarkChatEmojiCsReq>, IBufferMessage
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0001BE6C File Offset: 0x0001A06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BatchMarkChatEmojiCsReq> Parser
		{
			get
			{
				return BatchMarkChatEmojiCsReq._parser;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0001BE73 File Offset: 0x0001A073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BatchMarkChatEmojiCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0001BE85 File Offset: 0x0001A085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchMarkChatEmojiCsReq.Descriptor;
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0001BE8C File Offset: 0x0001A08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMarkChatEmojiCsReq()
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0001BE9F File Offset: 0x0001A09F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMarkChatEmojiCsReq(BatchMarkChatEmojiCsReq other) : this()
		{
			this.markedEmojiIdList_ = other.markedEmojiIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0001BEC9 File Offset: 0x0001A0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMarkChatEmojiCsReq Clone()
		{
			return new BatchMarkChatEmojiCsReq(this);
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0001BED1 File Offset: 0x0001A0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MarkedEmojiIdList
		{
			get
			{
				return this.markedEmojiIdList_;
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0001BED9 File Offset: 0x0001A0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchMarkChatEmojiCsReq);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0001BEE7 File Offset: 0x0001A0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchMarkChatEmojiCsReq other)
		{
			return other != null && (other == this || (this.markedEmojiIdList_.Equals(other.markedEmojiIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0001BF1C File Offset: 0x0001A11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.markedEmojiIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0001BF50 File Offset: 0x0001A150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0001BF58 File Offset: 0x0001A158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0001BF61 File Offset: 0x0001A161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markedEmojiIdList_.WriteTo(ref output, BatchMarkChatEmojiCsReq._repeated_markedEmojiIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0001BF88 File Offset: 0x0001A188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.markedEmojiIdList_.CalculateSize(BatchMarkChatEmojiCsReq._repeated_markedEmojiIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0001BFC1 File Offset: 0x0001A1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchMarkChatEmojiCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.markedEmojiIdList_.Add(other.markedEmojiIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0001BFEF File Offset: 0x0001A1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0001BFF8 File Offset: 0x0001A1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.markedEmojiIdList_.AddEntriesFrom(ref input, BatchMarkChatEmojiCsReq._repeated_markedEmojiIdList_codec);
				}
			}
		}

		// Token: 0x040003DE RID: 990
		private static readonly MessageParser<BatchMarkChatEmojiCsReq> _parser = new MessageParser<BatchMarkChatEmojiCsReq>(() => new BatchMarkChatEmojiCsReq());

		// Token: 0x040003DF RID: 991
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003E0 RID: 992
		public const int MarkedEmojiIdListFieldNumber = 1;

		// Token: 0x040003E1 RID: 993
		private static readonly FieldCodec<uint> _repeated_markedEmojiIdList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x040003E2 RID: 994
		private readonly RepeatedField<uint> markedEmojiIdList_ = new RepeatedField<uint>();
	}
}
