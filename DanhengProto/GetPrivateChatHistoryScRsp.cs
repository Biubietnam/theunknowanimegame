using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000777 RID: 1911
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPrivateChatHistoryScRsp : IMessage<GetPrivateChatHistoryScRsp>, IMessage, IEquatable<GetPrivateChatHistoryScRsp>, IDeepCloneable<GetPrivateChatHistoryScRsp>, IBufferMessage
	{
		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x0600555C RID: 21852 RVA: 0x000E5417 File Offset: 0x000E3617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPrivateChatHistoryScRsp> Parser
		{
			get
			{
				return GetPrivateChatHistoryScRsp._parser;
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x0600555D RID: 21853 RVA: 0x000E541E File Offset: 0x000E361E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPrivateChatHistoryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x0600555E RID: 21854 RVA: 0x000E5430 File Offset: 0x000E3630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPrivateChatHistoryScRsp.Descriptor;
			}
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x000E5437 File Offset: 0x000E3637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPrivateChatHistoryScRsp()
		{
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x000E544C File Offset: 0x000E364C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPrivateChatHistoryScRsp(GetPrivateChatHistoryScRsp other) : this()
		{
			this.targetUid_ = other.targetUid_;
			this.chatMessageList_ = other.chatMessageList_.Clone();
			this.retcode_ = other.retcode_;
			this.contactId_ = other.contactId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x000E54A5 File Offset: 0x000E36A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPrivateChatHistoryScRsp Clone()
		{
			return new GetPrivateChatHistoryScRsp(this);
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06005562 RID: 21858 RVA: 0x000E54AD File Offset: 0x000E36AD
		// (set) Token: 0x06005563 RID: 21859 RVA: 0x000E54B5 File Offset: 0x000E36B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetUid
		{
			get
			{
				return this.targetUid_;
			}
			set
			{
				this.targetUid_ = value;
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06005564 RID: 21860 RVA: 0x000E54BE File Offset: 0x000E36BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChatMessageData> ChatMessageList
		{
			get
			{
				return this.chatMessageList_;
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06005565 RID: 21861 RVA: 0x000E54C6 File Offset: 0x000E36C6
		// (set) Token: 0x06005566 RID: 21862 RVA: 0x000E54CE File Offset: 0x000E36CE
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

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06005567 RID: 21863 RVA: 0x000E54D7 File Offset: 0x000E36D7
		// (set) Token: 0x06005568 RID: 21864 RVA: 0x000E54DF File Offset: 0x000E36DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContactId
		{
			get
			{
				return this.contactId_;
			}
			set
			{
				this.contactId_ = value;
			}
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x000E54E8 File Offset: 0x000E36E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPrivateChatHistoryScRsp);
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x000E54F8 File Offset: 0x000E36F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPrivateChatHistoryScRsp other)
		{
			return other != null && (other == this || (this.TargetUid == other.TargetUid && this.chatMessageList_.Equals(other.chatMessageList_) && this.Retcode == other.Retcode && this.ContactId == other.ContactId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x000E5568 File Offset: 0x000E3768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetUid != 0U)
			{
				num ^= this.TargetUid.GetHashCode();
			}
			num ^= this.chatMessageList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ContactId != 0U)
			{
				num ^= this.ContactId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x000E55E7 File Offset: 0x000E37E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x000E55EF File Offset: 0x000E37EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x000E55F8 File Offset: 0x000E37F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContactId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ContactId);
			}
			this.chatMessageList_.WriteTo(ref output, GetPrivateChatHistoryScRsp._repeated_chatMessageList_codec);
			if (this.TargetUid != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.TargetUid);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x000E5680 File Offset: 0x000E3880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetUid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetUid);
			}
			num += this.chatMessageList_.CalculateSize(GetPrivateChatHistoryScRsp._repeated_chatMessageList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ContactId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContactId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x000E5704 File Offset: 0x000E3904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPrivateChatHistoryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetUid != 0U)
			{
				this.TargetUid = other.TargetUid;
			}
			this.chatMessageList_.Add(other.chatMessageList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ContactId != 0U)
			{
				this.ContactId = other.ContactId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x000E5779 File Offset: 0x000E3979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x000E5784 File Offset: 0x000E3984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 32U)
					{
						this.ContactId = input.ReadUInt32();
						continue;
					}
					if (num == 42U)
					{
						this.chatMessageList_.AddEntriesFrom(ref input, GetPrivateChatHistoryScRsp._repeated_chatMessageList_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.TargetUid = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002174 RID: 8564
		private static readonly MessageParser<GetPrivateChatHistoryScRsp> _parser = new MessageParser<GetPrivateChatHistoryScRsp>(() => new GetPrivateChatHistoryScRsp());

		// Token: 0x04002175 RID: 8565
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002176 RID: 8566
		public const int TargetUidFieldNumber = 8;

		// Token: 0x04002177 RID: 8567
		private uint targetUid_;

		// Token: 0x04002178 RID: 8568
		public const int ChatMessageListFieldNumber = 5;

		// Token: 0x04002179 RID: 8569
		private static readonly FieldCodec<ChatMessageData> _repeated_chatMessageList_codec = FieldCodec.ForMessage<ChatMessageData>(42U, ChatMessageData.Parser);

		// Token: 0x0400217A RID: 8570
		private readonly RepeatedField<ChatMessageData> chatMessageList_ = new RepeatedField<ChatMessageData>();

		// Token: 0x0400217B RID: 8571
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400217C RID: 8572
		private uint retcode_;

		// Token: 0x0400217D RID: 8573
		public const int ContactIdFieldNumber = 4;

		// Token: 0x0400217E RID: 8574
		private uint contactId_;
	}
}
