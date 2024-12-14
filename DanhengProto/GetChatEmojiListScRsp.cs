using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000651 RID: 1617
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChatEmojiListScRsp : IMessage<GetChatEmojiListScRsp>, IMessage, IEquatable<GetChatEmojiListScRsp>, IDeepCloneable<GetChatEmojiListScRsp>, IBufferMessage
	{
		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x0600488B RID: 18571 RVA: 0x000C65E5 File Offset: 0x000C47E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChatEmojiListScRsp> Parser
		{
			get
			{
				return GetChatEmojiListScRsp._parser;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x0600488C RID: 18572 RVA: 0x000C65EC File Offset: 0x000C47EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChatEmojiListScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x0600488D RID: 18573 RVA: 0x000C65FE File Offset: 0x000C47FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChatEmojiListScRsp.Descriptor;
			}
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x000C6605 File Offset: 0x000C4805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatEmojiListScRsp()
		{
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x000C6618 File Offset: 0x000C4818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatEmojiListScRsp(GetChatEmojiListScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.chatEmojiList_ = other.chatEmojiList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x000C664E File Offset: 0x000C484E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChatEmojiListScRsp Clone()
		{
			return new GetChatEmojiListScRsp(this);
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06004891 RID: 18577 RVA: 0x000C6656 File Offset: 0x000C4856
		// (set) Token: 0x06004892 RID: 18578 RVA: 0x000C665E File Offset: 0x000C485E
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

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06004893 RID: 18579 RVA: 0x000C6667 File Offset: 0x000C4867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ChatEmojiList
		{
			get
			{
				return this.chatEmojiList_;
			}
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x000C666F File Offset: 0x000C486F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChatEmojiListScRsp);
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x000C6680 File Offset: 0x000C4880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChatEmojiListScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.chatEmojiList_.Equals(other.chatEmojiList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x000C66D0 File Offset: 0x000C48D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.chatEmojiList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x000C671D File Offset: 0x000C491D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x000C6725 File Offset: 0x000C4925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x000C6730 File Offset: 0x000C4930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chatEmojiList_.WriteTo(ref output, GetChatEmojiListScRsp._repeated_chatEmojiList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x000C6780 File Offset: 0x000C4980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.chatEmojiList_.CalculateSize(GetChatEmojiListScRsp._repeated_chatEmojiList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x000C67D4 File Offset: 0x000C49D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChatEmojiListScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.chatEmojiList_.Add(other.chatEmojiList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x000C6821 File Offset: 0x000C4A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x000C682C File Offset: 0x000C4A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U && num != 26U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.chatEmojiList_.AddEntriesFrom(ref input, GetChatEmojiListScRsp._repeated_chatEmojiList_codec);
				}
			}
		}

		// Token: 0x04001CFB RID: 7419
		private static readonly MessageParser<GetChatEmojiListScRsp> _parser = new MessageParser<GetChatEmojiListScRsp>(() => new GetChatEmojiListScRsp());

		// Token: 0x04001CFC RID: 7420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CFD RID: 7421
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04001CFE RID: 7422
		private uint retcode_;

		// Token: 0x04001CFF RID: 7423
		public const int ChatEmojiListFieldNumber = 3;

		// Token: 0x04001D00 RID: 7424
		private static readonly FieldCodec<uint> _repeated_chatEmojiList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04001D01 RID: 7425
		private readonly RepeatedField<uint> chatEmojiList_ = new RepeatedField<uint>();
	}
}
