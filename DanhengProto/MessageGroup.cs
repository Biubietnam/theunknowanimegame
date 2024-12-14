using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AC1 RID: 2753
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MessageGroup : IMessage<MessageGroup>, IMessage, IEquatable<MessageGroup>, IDeepCloneable<MessageGroup>, IBufferMessage
	{
		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x06007A15 RID: 31253 RVA: 0x0014352F File Offset: 0x0014172F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MessageGroup> Parser
		{
			get
			{
				return MessageGroup._parser;
			}
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x06007A16 RID: 31254 RVA: 0x00143536 File Offset: 0x00141736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MessageGroupReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x06007A17 RID: 31255 RVA: 0x00143548 File Offset: 0x00141748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MessageGroup.Descriptor;
			}
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x0014354F File Offset: 0x0014174F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageGroup()
		{
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x00143564 File Offset: 0x00141764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageGroup(MessageGroup other) : this()
		{
			this.messageSectionList_ = other.messageSectionList_.Clone();
			this.status_ = other.status_;
			this.refreshTime_ = other.refreshTime_;
			this.id_ = other.id_;
			this.messageSectionId_ = other.messageSectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A1A RID: 31258 RVA: 0x001435C9 File Offset: 0x001417C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageGroup Clone()
		{
			return new MessageGroup(this);
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x06007A1B RID: 31259 RVA: 0x001435D1 File Offset: 0x001417D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MessageSection> MessageSectionList
		{
			get
			{
				return this.messageSectionList_;
			}
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x06007A1C RID: 31260 RVA: 0x001435D9 File Offset: 0x001417D9
		// (set) Token: 0x06007A1D RID: 31261 RVA: 0x001435E1 File Offset: 0x001417E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageGroupStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x06007A1E RID: 31262 RVA: 0x001435EA File Offset: 0x001417EA
		// (set) Token: 0x06007A1F RID: 31263 RVA: 0x001435F2 File Offset: 0x001417F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RefreshTime
		{
			get
			{
				return this.refreshTime_;
			}
			set
			{
				this.refreshTime_ = value;
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x06007A20 RID: 31264 RVA: 0x001435FB File Offset: 0x001417FB
		// (set) Token: 0x06007A21 RID: 31265 RVA: 0x00143603 File Offset: 0x00141803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x06007A22 RID: 31266 RVA: 0x0014360C File Offset: 0x0014180C
		// (set) Token: 0x06007A23 RID: 31267 RVA: 0x00143614 File Offset: 0x00141814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MessageSectionId
		{
			get
			{
				return this.messageSectionId_;
			}
			set
			{
				this.messageSectionId_ = value;
			}
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x0014361D File Offset: 0x0014181D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MessageGroup);
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x0014362C File Offset: 0x0014182C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MessageGroup other)
		{
			return other != null && (other == this || (this.messageSectionList_.Equals(other.messageSectionList_) && this.Status == other.Status && this.RefreshTime == other.RefreshTime && this.Id == other.Id && this.MessageSectionId == other.MessageSectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x001436AC File Offset: 0x001418AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.messageSectionList_.GetHashCode();
			if (this.Status != MessageGroupStatus.MessageGroupNone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.RefreshTime != 0L)
			{
				num ^= this.RefreshTime.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MessageSectionId != 0U)
			{
				num ^= this.MessageSectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x0014374A File Offset: 0x0014194A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x00143752 File Offset: 0x00141952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x0014375C File Offset: 0x0014195C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RefreshTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.RefreshTime);
			}
			if (this.MessageSectionId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MessageSectionId);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Id);
			}
			this.messageSectionList_.WriteTo(ref output, MessageGroup._repeated_messageSectionList_codec);
			if (this.Status != MessageGroupStatus.MessageGroupNone)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x00143800 File Offset: 0x00141A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.messageSectionList_.CalculateSize(MessageGroup._repeated_messageSectionList_codec);
			if (this.Status != MessageGroupStatus.MessageGroupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.RefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RefreshTime);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.MessageSectionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MessageSectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x0014389C File Offset: 0x00141A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MessageGroup other)
		{
			if (other == null)
			{
				return;
			}
			this.messageSectionList_.Add(other.messageSectionList_);
			if (other.Status != MessageGroupStatus.MessageGroupNone)
			{
				this.Status = other.Status;
			}
			if (other.RefreshTime != 0L)
			{
				this.RefreshTime = other.RefreshTime;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.MessageSectionId != 0U)
			{
				this.MessageSectionId = other.MessageSectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x00143925 File Offset: 0x00141B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x00143930 File Offset: 0x00141B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.RefreshTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.MessageSectionId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						this.messageSectionList_.AddEntriesFrom(ref input, MessageGroup._repeated_messageSectionList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.Status = (MessageGroupStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002ED2 RID: 11986
		private static readonly MessageParser<MessageGroup> _parser = new MessageParser<MessageGroup>(() => new MessageGroup());

		// Token: 0x04002ED3 RID: 11987
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ED4 RID: 11988
		public const int MessageSectionListFieldNumber = 11;

		// Token: 0x04002ED5 RID: 11989
		private static readonly FieldCodec<MessageSection> _repeated_messageSectionList_codec = FieldCodec.ForMessage<MessageSection>(90U, MessageSection.Parser);

		// Token: 0x04002ED6 RID: 11990
		private readonly RepeatedField<MessageSection> messageSectionList_ = new RepeatedField<MessageSection>();

		// Token: 0x04002ED7 RID: 11991
		public const int StatusFieldNumber = 15;

		// Token: 0x04002ED8 RID: 11992
		private MessageGroupStatus status_;

		// Token: 0x04002ED9 RID: 11993
		public const int RefreshTimeFieldNumber = 1;

		// Token: 0x04002EDA RID: 11994
		private long refreshTime_;

		// Token: 0x04002EDB RID: 11995
		public const int IdFieldNumber = 10;

		// Token: 0x04002EDC RID: 11996
		private uint id_;

		// Token: 0x04002EDD RID: 11997
		public const int MessageSectionIdFieldNumber = 6;

		// Token: 0x04002EDE RID: 11998
		private uint messageSectionId_;
	}
}
