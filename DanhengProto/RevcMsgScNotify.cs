using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DDD RID: 3549
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RevcMsgScNotify : IMessage<RevcMsgScNotify>, IMessage, IEquatable<RevcMsgScNotify>, IDeepCloneable<RevcMsgScNotify>, IBufferMessage
	{
		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x06009E91 RID: 40593 RVA: 0x001A82AF File Offset: 0x001A64AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RevcMsgScNotify> Parser
		{
			get
			{
				return RevcMsgScNotify._parser;
			}
		}

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x06009E92 RID: 40594 RVA: 0x001A82B6 File Offset: 0x001A64B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RevcMsgScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x06009E93 RID: 40595 RVA: 0x001A82C8 File Offset: 0x001A64C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RevcMsgScNotify.Descriptor;
			}
		}

		// Token: 0x06009E94 RID: 40596 RVA: 0x001A82CF File Offset: 0x001A64CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RevcMsgScNotify()
		{
		}

		// Token: 0x06009E95 RID: 40597 RVA: 0x001A82E4 File Offset: 0x001A64E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RevcMsgScNotify(RevcMsgScNotify other) : this()
		{
			this.messageText_ = other.messageText_;
			this.chatType_ = other.chatType_;
			this.sourceUid_ = other.sourceUid_;
			this.targetUid_ = other.targetUid_;
			this.messageType_ = other.messageType_;
			this.extraId_ = other.extraId_;
			this.bNABNCCMILM_ = ((other.bNABNCCMILM_ != null) ? other.bNABNCCMILM_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x001A836C File Offset: 0x001A656C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RevcMsgScNotify Clone()
		{
			return new RevcMsgScNotify(this);
		}

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x06009E97 RID: 40599 RVA: 0x001A8374 File Offset: 0x001A6574
		// (set) Token: 0x06009E98 RID: 40600 RVA: 0x001A837C File Offset: 0x001A657C
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

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x06009E99 RID: 40601 RVA: 0x001A838F File Offset: 0x001A658F
		// (set) Token: 0x06009E9A RID: 40602 RVA: 0x001A8397 File Offset: 0x001A6597
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

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x06009E9B RID: 40603 RVA: 0x001A83A0 File Offset: 0x001A65A0
		// (set) Token: 0x06009E9C RID: 40604 RVA: 0x001A83A8 File Offset: 0x001A65A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SourceUid
		{
			get
			{
				return this.sourceUid_;
			}
			set
			{
				this.sourceUid_ = value;
			}
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x06009E9D RID: 40605 RVA: 0x001A83B1 File Offset: 0x001A65B1
		// (set) Token: 0x06009E9E RID: 40606 RVA: 0x001A83B9 File Offset: 0x001A65B9
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

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x06009E9F RID: 40607 RVA: 0x001A83C2 File Offset: 0x001A65C2
		// (set) Token: 0x06009EA0 RID: 40608 RVA: 0x001A83CA File Offset: 0x001A65CA
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

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x06009EA1 RID: 40609 RVA: 0x001A83D3 File Offset: 0x001A65D3
		// (set) Token: 0x06009EA2 RID: 40610 RVA: 0x001A83DB File Offset: 0x001A65DB
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

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x06009EA3 RID: 40611 RVA: 0x001A83E4 File Offset: 0x001A65E4
		// (set) Token: 0x06009EA4 RID: 40612 RVA: 0x001A83EC File Offset: 0x001A65EC
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

		// Token: 0x06009EA5 RID: 40613 RVA: 0x001A83F5 File Offset: 0x001A65F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RevcMsgScNotify);
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x001A8404 File Offset: 0x001A6604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RevcMsgScNotify other)
		{
			return other != null && (other == this || (!(this.MessageText != other.MessageText) && this.ChatType == other.ChatType && this.SourceUid == other.SourceUid && this.TargetUid == other.TargetUid && this.MessageType == other.MessageType && this.ExtraId == other.ExtraId && object.Equals(this.BNABNCCMILM, other.BNABNCCMILM) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x001A84A8 File Offset: 0x001A66A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MessageText.Length != 0)
			{
				num ^= this.MessageText.GetHashCode();
			}
			if (this.ChatType != ChatType.None)
			{
				num ^= this.ChatType.GetHashCode();
			}
			if (this.SourceUid != 0U)
			{
				num ^= this.SourceUid.GetHashCode();
			}
			if (this.TargetUid != 0U)
			{
				num ^= this.TargetUid.GetHashCode();
			}
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009EA8 RID: 40616 RVA: 0x001A8588 File Offset: 0x001A6788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x001A8590 File Offset: 0x001A6790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x001A859C File Offset: 0x001A679C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bNABNCCMILM_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BNABNCCMILM);
			}
			if (this.MessageText.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.MessageText);
			}
			if (this.MessageType != MsgType.None)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.MessageType);
			}
			if (this.ExtraId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ExtraId);
			}
			if (this.TargetUid != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.TargetUid);
			}
			if (this.SourceUid != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.SourceUid);
			}
			if (this.ChatType != ChatType.None)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ChatType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EAB RID: 40619 RVA: 0x001A8688 File Offset: 0x001A6888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MessageText.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MessageText);
			}
			if (this.ChatType != ChatType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChatType);
			}
			if (this.SourceUid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SourceUid);
			}
			if (this.TargetUid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetUid);
			}
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009EAC RID: 40620 RVA: 0x001A875C File Offset: 0x001A695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RevcMsgScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MessageText.Length != 0)
			{
				this.MessageText = other.MessageText;
			}
			if (other.ChatType != ChatType.None)
			{
				this.ChatType = other.ChatType;
			}
			if (other.SourceUid != 0U)
			{
				this.SourceUid = other.SourceUid;
			}
			if (other.TargetUid != 0U)
			{
				this.TargetUid = other.TargetUid;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009EAD RID: 40621 RVA: 0x001A882D File Offset: 0x001A6A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EAE RID: 40622 RVA: 0x001A8838 File Offset: 0x001A6A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 10U)
					{
						if (this.bNABNCCMILM_ == null)
						{
							this.BNABNCCMILM = new LFCKPPDLIJI();
						}
						input.ReadMessage(this.BNABNCCMILM);
						continue;
					}
					if (num == 18U)
					{
						this.MessageText = input.ReadString();
						continue;
					}
					if (num == 24U)
					{
						this.MessageType = (MsgType)input.ReadEnum();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.ExtraId = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.TargetUid = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.SourceUid = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.ChatType = (ChatType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400410C RID: 16652
		private static readonly MessageParser<RevcMsgScNotify> _parser = new MessageParser<RevcMsgScNotify>(() => new RevcMsgScNotify());

		// Token: 0x0400410D RID: 16653
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400410E RID: 16654
		public const int MessageTextFieldNumber = 2;

		// Token: 0x0400410F RID: 16655
		private string messageText_ = "";

		// Token: 0x04004110 RID: 16656
		public const int ChatTypeFieldNumber = 11;

		// Token: 0x04004111 RID: 16657
		private ChatType chatType_;

		// Token: 0x04004112 RID: 16658
		public const int SourceUidFieldNumber = 10;

		// Token: 0x04004113 RID: 16659
		private uint sourceUid_;

		// Token: 0x04004114 RID: 16660
		public const int TargetUidFieldNumber = 5;

		// Token: 0x04004115 RID: 16661
		private uint targetUid_;

		// Token: 0x04004116 RID: 16662
		public const int MessageTypeFieldNumber = 3;

		// Token: 0x04004117 RID: 16663
		private MsgType messageType_;

		// Token: 0x04004118 RID: 16664
		public const int ExtraIdFieldNumber = 4;

		// Token: 0x04004119 RID: 16665
		private uint extraId_;

		// Token: 0x0400411A RID: 16666
		public const int BNABNCCMILMFieldNumber = 1;

		// Token: 0x0400411B RID: 16667
		private LFCKPPDLIJI bNABNCCMILM_;
	}
}
