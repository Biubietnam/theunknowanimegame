using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000D7 RID: 215
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BatchMarkChatEmojiScRsp : IMessage<BatchMarkChatEmojiScRsp>, IMessage, IEquatable<BatchMarkChatEmojiScRsp>, IDeepCloneable<BatchMarkChatEmojiScRsp>, IBufferMessage
	{
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0001C0E9 File Offset: 0x0001A2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BatchMarkChatEmojiScRsp> Parser
		{
			get
			{
				return BatchMarkChatEmojiScRsp._parser;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0001C0F0 File Offset: 0x0001A2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BatchMarkChatEmojiScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0001C102 File Offset: 0x0001A302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchMarkChatEmojiScRsp.Descriptor;
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0001C109 File Offset: 0x0001A309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMarkChatEmojiScRsp()
		{
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0001C11C File Offset: 0x0001A31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMarkChatEmojiScRsp(BatchMarkChatEmojiScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.markedEmojiIdList_ = other.markedEmojiIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0001C152 File Offset: 0x0001A352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMarkChatEmojiScRsp Clone()
		{
			return new BatchMarkChatEmojiScRsp(this);
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x0001C15A File Offset: 0x0001A35A
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x0001C162 File Offset: 0x0001A362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0001C16B File Offset: 0x0001A36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MarkedEmojiIdList
		{
			get
			{
				return this.markedEmojiIdList_;
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0001C173 File Offset: 0x0001A373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchMarkChatEmojiScRsp);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0001C184 File Offset: 0x0001A384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchMarkChatEmojiScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.markedEmojiIdList_.Equals(other.markedEmojiIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0001C1D4 File Offset: 0x0001A3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.markedEmojiIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0001C221 File Offset: 0x0001A421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0001C229 File Offset: 0x0001A429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0001C234 File Offset: 0x0001A434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.markedEmojiIdList_.WriteTo(ref output, BatchMarkChatEmojiScRsp._repeated_markedEmojiIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0001C284 File Offset: 0x0001A484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.markedEmojiIdList_.CalculateSize(BatchMarkChatEmojiScRsp._repeated_markedEmojiIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0001C2D8 File Offset: 0x0001A4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchMarkChatEmojiScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.markedEmojiIdList_.Add(other.markedEmojiIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0001C325 File Offset: 0x0001A525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0001C330 File Offset: 0x0001A530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.markedEmojiIdList_.AddEntriesFrom(ref input, BatchMarkChatEmojiScRsp._repeated_markedEmojiIdList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040003E4 RID: 996
		private static readonly MessageParser<BatchMarkChatEmojiScRsp> _parser = new MessageParser<BatchMarkChatEmojiScRsp>(() => new BatchMarkChatEmojiScRsp());

		// Token: 0x040003E5 RID: 997
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003E6 RID: 998
		public const int RetcodeFieldNumber = 1;

		// Token: 0x040003E7 RID: 999
		private uint retcode_;

		// Token: 0x040003E8 RID: 1000
		public const int MarkedEmojiIdListFieldNumber = 10;

		// Token: 0x040003E9 RID: 1001
		private static readonly FieldCodec<uint> _repeated_markedEmojiIdList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x040003EA RID: 1002
		private readonly RepeatedField<uint> markedEmojiIdList_ = new RepeatedField<uint>();
	}
}
