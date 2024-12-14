using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001D9 RID: 473
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChatMessageData : IMessage<ChatMessageData>, IMessage, IEquatable<ChatMessageData>, IDeepCloneable<ChatMessageData>, IBufferMessage
	{
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x0003CBF7 File Offset: 0x0003ADF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChatMessageData> Parser
		{
			get
			{
				return ChatMessageData._parser;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x0003CBFE File Offset: 0x0003ADFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChatMessageDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x0003CC10 File Offset: 0x0003AE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatMessageData.Descriptor;
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0003CC17 File Offset: 0x0003AE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMessageData()
		{
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0003CC2C File Offset: 0x0003AE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMessageData(ChatMessageData other) : this()
		{
			this.bNABNCCMILM_ = ((other.bNABNCCMILM_ != null) ? other.bNABNCCMILM_.Clone() : null);
			this.extraId_ = other.extraId_;
			this.senderId_ = other.senderId_;
			this.content_ = other.content_;
			this.createTime_ = other.createTime_;
			this.messageType_ = other.messageType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0003CCA8 File Offset: 0x0003AEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMessageData Clone()
		{
			return new ChatMessageData(this);
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x0003CCB0 File Offset: 0x0003AEB0
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x0003CCB8 File Offset: 0x0003AEB8
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

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x0003CCC1 File Offset: 0x0003AEC1
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x0003CCC9 File Offset: 0x0003AEC9
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

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x0003CCD2 File Offset: 0x0003AED2
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x0003CCDA File Offset: 0x0003AEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SenderId
		{
			get
			{
				return this.senderId_;
			}
			set
			{
				this.senderId_ = value;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0003CCE3 File Offset: 0x0003AEE3
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x0003CCEB File Offset: 0x0003AEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
		{
			get
			{
				return this.content_;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x0003CCFE File Offset: 0x0003AEFE
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x0003CD06 File Offset: 0x0003AF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				this.createTime_ = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x0003CD0F File Offset: 0x0003AF0F
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x0003CD17 File Offset: 0x0003AF17
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

		// Token: 0x06001549 RID: 5449 RVA: 0x0003CD20 File Offset: 0x0003AF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatMessageData);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0003CD30 File Offset: 0x0003AF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatMessageData other)
		{
			return other != null && (other == this || (object.Equals(this.BNABNCCMILM, other.BNABNCCMILM) && this.ExtraId == other.ExtraId && this.SenderId == other.SenderId && !(this.Content != other.Content) && this.CreateTime == other.CreateTime && this.MessageType == other.MessageType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0003CDC4 File Offset: 0x0003AFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bNABNCCMILM_ != null)
			{
				num ^= this.BNABNCCMILM.GetHashCode();
			}
			if (this.ExtraId != 0U)
			{
				num ^= this.ExtraId.GetHashCode();
			}
			if (this.SenderId != 0U)
			{
				num ^= this.SenderId.GetHashCode();
			}
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			if (this.CreateTime != 0UL)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this.MessageType != MsgType.None)
			{
				num ^= this.MessageType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0003CE85 File Offset: 0x0003B085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0003CE8D File Offset: 0x0003B08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0003CE98 File Offset: 0x0003B098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bNABNCCMILM_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BNABNCCMILM);
			}
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Content);
			}
			if (this.SenderId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.SenderId);
			}
			if (this.MessageType != MsgType.None)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.MessageType);
			}
			if (this.ExtraId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ExtraId);
			}
			if (this.CreateTime != 0UL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.CreateTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0003CF68 File Offset: 0x0003B168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bNABNCCMILM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BNABNCCMILM);
			}
			if (this.ExtraId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExtraId);
			}
			if (this.SenderId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SenderId);
			}
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			if (this.CreateTime != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreateTime);
			}
			if (this.MessageType != MsgType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MessageType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0003D024 File Offset: 0x0003B224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChatMessageData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bNABNCCMILM_ != null)
			{
				if (this.bNABNCCMILM_ == null)
				{
					this.BNABNCCMILM = new LFCKPPDLIJI();
				}
				this.BNABNCCMILM.MergeFrom(other.BNABNCCMILM);
			}
			if (other.ExtraId != 0U)
			{
				this.ExtraId = other.ExtraId;
			}
			if (other.SenderId != 0U)
			{
				this.SenderId = other.SenderId;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			if (other.CreateTime != 0UL)
			{
				this.CreateTime = other.CreateTime;
			}
			if (other.MessageType != MsgType.None)
			{
				this.MessageType = other.MessageType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0003D0E1 File Offset: 0x0003B2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0003D0EC File Offset: 0x0003B2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 26U)
					{
						if (this.bNABNCCMILM_ == null)
						{
							this.BNABNCCMILM = new LFCKPPDLIJI();
						}
						input.ReadMessage(this.BNABNCCMILM);
						continue;
					}
					if (num == 34U)
					{
						this.Content = input.ReadString();
						continue;
					}
					if (num == 56U)
					{
						this.SenderId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.MessageType = (MsgType)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.ExtraId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.CreateTime = input.ReadUInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040008E0 RID: 2272
		private static readonly MessageParser<ChatMessageData> _parser = new MessageParser<ChatMessageData>(() => new ChatMessageData());

		// Token: 0x040008E1 RID: 2273
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008E2 RID: 2274
		public const int BNABNCCMILMFieldNumber = 3;

		// Token: 0x040008E3 RID: 2275
		private LFCKPPDLIJI bNABNCCMILM_;

		// Token: 0x040008E4 RID: 2276
		public const int ExtraIdFieldNumber = 13;

		// Token: 0x040008E5 RID: 2277
		private uint extraId_;

		// Token: 0x040008E6 RID: 2278
		public const int SenderIdFieldNumber = 7;

		// Token: 0x040008E7 RID: 2279
		private uint senderId_;

		// Token: 0x040008E8 RID: 2280
		public const int ContentFieldNumber = 4;

		// Token: 0x040008E9 RID: 2281
		private string content_ = "";

		// Token: 0x040008EA RID: 2282
		public const int CreateTimeFieldNumber = 14;

		// Token: 0x040008EB RID: 2283
		private ulong createTime_;

		// Token: 0x040008EC RID: 2284
		public const int MessageTypeFieldNumber = 11;

		// Token: 0x040008ED RID: 2285
		private MsgType messageType_;
	}
}
