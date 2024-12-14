using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010BB RID: 4283
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SendMsgCsReq : IMessage<SendMsgCsReq>, IMessage, IEquatable<SendMsgCsReq>, IDeepCloneable<SendMsgCsReq>, IBufferMessage
	{
		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0600BEFC RID: 48892 RVA: 0x0020263F File Offset: 0x0020083F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SendMsgCsReq> Parser
		{
			get
			{
				return SendMsgCsReq._parser;
			}
		}

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0600BEFD RID: 48893 RVA: 0x00202646 File Offset: 0x00200846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SendMsgCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0600BEFE RID: 48894 RVA: 0x00202658 File Offset: 0x00200858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendMsgCsReq.Descriptor;
			}
		}

		// Token: 0x0600BEFF RID: 48895 RVA: 0x0020265F File Offset: 0x0020085F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SendMsgCsReq()
		{
		}

		// Token: 0x0600BF00 RID: 48896 RVA: 0x00202680 File Offset: 0x00200880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SendMsgCsReq(SendMsgCsReq other) : this()
		{
			this.messageType_ = other.messageType_;
			this.extraId_ = other.extraId_;
			this.bNABNCCMILM_ = ((other.bNABNCCMILM_ != null) ? other.bNABNCCMILM_.Clone() : null);
			this.messageText_ = other.messageText_;
			this.targetList_ = other.targetList_.Clone();
			this.chatType_ = other.chatType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF01 RID: 48897 RVA: 0x00202701 File Offset: 0x00200901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SendMsgCsReq Clone()
		{
			return new SendMsgCsReq(this);
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0600BF02 RID: 48898 RVA: 0x00202709 File Offset: 0x00200909
		// (set) Token: 0x0600BF03 RID: 48899 RVA: 0x00202711 File Offset: 0x00200911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MsgType MessageType
		{
			get
			{
				return this.messageType_;
			}
			set
			{
				this.messageType_ = value;
			}
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0600BF04 RID: 48900 RVA: 0x0020271A File Offset: 0x0020091A
		// (set) Token: 0x0600BF05 RID: 48901 RVA: 0x00202722 File Offset: 0x00200922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ExtraId
		{
			get
			{
				return this.extraId_;
			}
			set
			{
				this.extraId_ = value;
			}
		}

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0600BF06 RID: 48902 RVA: 0x0020272B File Offset: 0x0020092B
		// (set) Token: 0x0600BF07 RID: 48903 RVA: 0x00202733 File Offset: 0x00200933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LFCKPPDLIJI BNABNCCMILM
		{
			get
			{
				return this.bNABNCCMILM_;
			}
			set
			{
				this.bNABNCCMILM_ = value;
			}
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0600BF08 RID: 48904 RVA: 0x0020273C File Offset: 0x0020093C
		// (set) Token: 0x0600BF09 RID: 48905 RVA: 0x00202744 File Offset: 0x00200944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MessageText
		{
			get
			{
				return this.messageText_;
			}
			set
			{
				this.messageText_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0600BF0A RID: 48906 RVA: 0x00202757 File Offset: 0x00200957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TargetList
		{
			get
			{
				return this.targetList_;
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0600BF0B RID: 48907 RVA: 0x0020275F File Offset: 0x0020095F
		// (set) Token: 0x0600BF0C RID: 48908 RVA: 0x00202767 File Offset: 0x00200967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatType ChatType
		{
			get
			{
				return this.chatType_;
			}
			set
			{
				this.chatType_ = value;
			}
		}

		// Token: 0x0600BF0D RID: 48909 RVA: 0x00202770 File Offset: 0x00200970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendMsgCsReq);
		}

		// Token: 0x0600BF0E RID: 48910 RVA: 0x00202780 File Offset: 0x00200980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SendMsgCsReq other)
		{
			return other != null && (other == this || (this.MessageType == other.MessageType && this.ExtraId == other.ExtraId && object.Equals(this.BNABNCCMILM, other.BNABNCCMILM) && !(this.MessageText != other.MessageText) && this.targetList_.Equals(other.targetList_) && this.ChatType == other.ChatType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF0F RID: 48911 RVA: 0x00202818 File Offset: 0x00200A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MessageType != MsgType.None)
			{
				num ^= this.MessageType.GetHashCode();
			}
			if (this.ExtraId != 0U)
			{
				num ^= this.ExtraId.GetHashCode();
			}
			if (this.bNABNCCMILM_ != null)
			{
				num ^= this.BNABNCCMILM.GetHashCode();
			}
			if (this.MessageText.Length != 0)
			{
				num ^= this.MessageText.GetHashCode();
			}
			num ^= this.targetList_.GetHashCode();
			if (this.ChatType != ChatType.None)
			{
				num ^= this.ChatType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF10 RID: 48912 RVA: 0x002028D4 File Offset: 0x00200AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BF11 RID: 48913 RVA: 0x002028DC File Offset: 0x00200ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF12 RID: 48914 RVA: 0x002028E8 File Offset: 0x00200AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.targetList_.WriteTo(ref output, SendMsgCsReq._repeated_targetList_codec);
			if (this.ChatType != ChatType.None)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ChatType);
			}
			if (this.MessageType != MsgType.None)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.MessageType);
			}
			if (this.MessageText.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.MessageText);
			}
			if (this.ExtraId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ExtraId);
			}
			if (this.bNABNCCMILM_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.BNABNCCMILM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF13 RID: 48915 RVA: 0x002029AC File Offset: 0x00200BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MessageType != MsgType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MessageType);
			}
			if (this.ExtraId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExtraId);
			}
			if (this.bNABNCCMILM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BNABNCCMILM);
			}
			if (this.MessageText.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MessageText);
			}
			num += this.targetList_.CalculateSize(SendMsgCsReq._repeated_targetList_codec);
			if (this.ChatType != ChatType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChatType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF14 RID: 48916 RVA: 0x00202A64 File Offset: 0x00200C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SendMsgCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MessageType != MsgType.None)
			{
				this.MessageType = other.MessageType;
			}
			if (other.ExtraId != 0U)
			{
				this.ExtraId = other.ExtraId;
			}
			if (other.bNABNCCMILM_ != null)
			{
				if (this.bNABNCCMILM_ == null)
				{
					this.BNABNCCMILM = new LFCKPPDLIJI();
				}
				this.BNABNCCMILM.MergeFrom(other.BNABNCCMILM);
			}
			if (other.MessageText.Length != 0)
			{
				this.MessageText = other.MessageText;
			}
			this.targetList_.Add(other.targetList_);
			if (other.ChatType != ChatType.None)
			{
				this.ChatType = other.ChatType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF15 RID: 48917 RVA: 0x00202B1E File Offset: 0x00200D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF16 RID: 48918 RVA: 0x00202B28 File Offset: 0x00200D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U || num == 10U)
					{
						this.targetList_.AddEntriesFrom(ref input, SendMsgCsReq._repeated_targetList_codec);
						continue;
					}
					if (num == 16U)
					{
						this.ChatType = (ChatType)input.ReadEnum();
						continue;
					}
				}
				else if (num <= 50U)
				{
					if (num == 32U)
					{
						this.MessageType = (MsgType)input.ReadEnum();
						continue;
					}
					if (num == 50U)
					{
						this.MessageText = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ExtraId = input.ReadUInt32();
						continue;
					}
					if (num == 66U)
					{
						if (this.bNABNCCMILM_ == null)
						{
							this.BNABNCCMILM = new LFCKPPDLIJI();
						}
						input.ReadMessage(this.BNABNCCMILM);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D91 RID: 19857
		private static readonly MessageParser<SendMsgCsReq> _parser = new MessageParser<SendMsgCsReq>(() => new SendMsgCsReq());

		// Token: 0x04004D92 RID: 19858
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D93 RID: 19859
		public const int MessageTypeFieldNumber = 4;

		// Token: 0x04004D94 RID: 19860
		private MsgType messageType_;

		// Token: 0x04004D95 RID: 19861
		public const int ExtraIdFieldNumber = 7;

		// Token: 0x04004D96 RID: 19862
		private uint extraId_;

		// Token: 0x04004D97 RID: 19863
		public const int BNABNCCMILMFieldNumber = 8;

		// Token: 0x04004D98 RID: 19864
		private LFCKPPDLIJI bNABNCCMILM_;

		// Token: 0x04004D99 RID: 19865
		public const int MessageTextFieldNumber = 6;

		// Token: 0x04004D9A RID: 19866
		private string messageText_ = "";

		// Token: 0x04004D9B RID: 19867
		public const int TargetListFieldNumber = 1;

		// Token: 0x04004D9C RID: 19868
		private static readonly FieldCodec<uint> _repeated_targetList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04004D9D RID: 19869
		private readonly RepeatedField<uint> targetList_ = new RepeatedField<uint>();

		// Token: 0x04004D9E RID: 19870
		public const int ChatTypeFieldNumber = 2;

		// Token: 0x04004D9F RID: 19871
		private ChatType chatType_;
	}
}
