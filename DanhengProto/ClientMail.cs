using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002D9 RID: 729
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientMail : IMessage<ClientMail>, IMessage, IEquatable<ClientMail>, IDeepCloneable<ClientMail>, IBufferMessage
	{
		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x0005C4DE File Offset: 0x0005A6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientMail> Parser
		{
			get
			{
				return ClientMail._parser;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0005C4E5 File Offset: 0x0005A6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMailReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x0005C4F7 File Offset: 0x0005A6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientMail.Descriptor;
			}
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x0005C4FE File Offset: 0x0005A6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientMail()
		{
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x0005C534 File Offset: 0x0005A734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientMail(ClientMail other) : this()
		{
			this.title_ = other.title_;
			this.content_ = other.content_;
			this.id_ = other.id_;
			this.sender_ = other.sender_;
			this.mailType_ = other.mailType_;
			this.expireTime_ = other.expireTime_;
			this.isRead_ = other.isRead_;
			this.templateId_ = other.templateId_;
			this.attachment_ = ((other.attachment_ != null) ? other.attachment_.Clone() : null);
			this.paraList_ = other.paraList_.Clone();
			this.time_ = other.time_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x0005C5F1 File Offset: 0x0005A7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientMail Clone()
		{
			return new ClientMail(this);
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x0005C5F9 File Offset: 0x0005A7F9
		// (set) Token: 0x0600207D RID: 8317 RVA: 0x0005C601 File Offset: 0x0005A801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Title
		{
			get
			{
				return this.title_;
			}
			set
			{
				this.title_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x0005C614 File Offset: 0x0005A814
		// (set) Token: 0x0600207F RID: 8319 RVA: 0x0005C61C File Offset: 0x0005A81C
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

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x0005C62F File Offset: 0x0005A82F
		// (set) Token: 0x06002081 RID: 8321 RVA: 0x0005C637 File Offset: 0x0005A837
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

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x0005C640 File Offset: 0x0005A840
		// (set) Token: 0x06002083 RID: 8323 RVA: 0x0005C648 File Offset: 0x0005A848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Sender
		{
			get
			{
				return this.sender_;
			}
			set
			{
				this.sender_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x0005C65B File Offset: 0x0005A85B
		// (set) Token: 0x06002085 RID: 8325 RVA: 0x0005C663 File Offset: 0x0005A863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailType MailType
		{
			get
			{
				return this.mailType_;
			}
			set
			{
				this.mailType_ = value;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x0005C66C File Offset: 0x0005A86C
		// (set) Token: 0x06002087 RID: 8327 RVA: 0x0005C674 File Offset: 0x0005A874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExpireTime
		{
			get
			{
				return this.expireTime_;
			}
			set
			{
				this.expireTime_ = value;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x0005C67D File Offset: 0x0005A87D
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x0005C685 File Offset: 0x0005A885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRead
		{
			get
			{
				return this.isRead_;
			}
			set
			{
				this.isRead_ = value;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0005C68E File Offset: 0x0005A88E
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x0005C696 File Offset: 0x0005A896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TemplateId
		{
			get
			{
				return this.templateId_;
			}
			set
			{
				this.templateId_ = value;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x0005C69F File Offset: 0x0005A89F
		// (set) Token: 0x0600208D RID: 8333 RVA: 0x0005C6A7 File Offset: 0x0005A8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Attachment
		{
			get
			{
				return this.attachment_;
			}
			set
			{
				this.attachment_ = value;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x0005C6B0 File Offset: 0x0005A8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ParaList
		{
			get
			{
				return this.paraList_;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0005C6B8 File Offset: 0x0005A8B8
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x0005C6C0 File Offset: 0x0005A8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Time
		{
			get
			{
				return this.time_;
			}
			set
			{
				this.time_ = value;
			}
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x0005C6C9 File Offset: 0x0005A8C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientMail);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x0005C6D8 File Offset: 0x0005A8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientMail other)
		{
			return other != null && (other == this || (!(this.Title != other.Title) && !(this.Content != other.Content) && this.Id == other.Id && !(this.Sender != other.Sender) && this.MailType == other.MailType && this.ExpireTime == other.ExpireTime && this.IsRead == other.IsRead && this.TemplateId == other.TemplateId && object.Equals(this.Attachment, other.Attachment) && this.paraList_.Equals(other.paraList_) && this.Time == other.Time && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0005C7CC File Offset: 0x0005A9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Title.Length != 0)
			{
				num ^= this.Title.GetHashCode();
			}
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Sender.Length != 0)
			{
				num ^= this.Sender.GetHashCode();
			}
			if (this.MailType != MailType.Normal)
			{
				num ^= this.MailType.GetHashCode();
			}
			if (this.ExpireTime != 0L)
			{
				num ^= this.ExpireTime.GetHashCode();
			}
			if (this.IsRead)
			{
				num ^= this.IsRead.GetHashCode();
			}
			if (this.TemplateId != 0U)
			{
				num ^= this.TemplateId.GetHashCode();
			}
			if (this.attachment_ != null)
			{
				num ^= this.Attachment.GetHashCode();
			}
			num ^= this.paraList_.GetHashCode();
			if (this.Time != 0L)
			{
				num ^= this.Time.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x0005C904 File Offset: 0x0005AB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x0005C90C File Offset: 0x0005AB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x0005C918 File Offset: 0x0005AB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MailType != MailType.Normal)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.MailType);
			}
			if (this.attachment_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Attachment);
			}
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Content);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Id);
			}
			if (this.Sender.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Sender);
			}
			if (this.Time != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Time);
			}
			if (this.ExpireTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.ExpireTime);
			}
			if (this.IsRead)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsRead);
			}
			this.paraList_.WriteTo(ref output, ClientMail._repeated_paraList_codec);
			if (this.TemplateId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.TemplateId);
			}
			if (this.Title.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Title);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x0005CA70 File Offset: 0x0005AC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Title.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Title);
			}
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Sender.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Sender);
			}
			if (this.MailType != MailType.Normal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MailType);
			}
			if (this.ExpireTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ExpireTime);
			}
			if (this.IsRead)
			{
				num += 2;
			}
			if (this.TemplateId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TemplateId);
			}
			if (this.attachment_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Attachment);
			}
			num += this.paraList_.CalculateSize(ClientMail._repeated_paraList_codec);
			if (this.Time != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Time);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0005CB9C File Offset: 0x0005AD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientMail other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Title.Length != 0)
			{
				this.Title = other.Title;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Sender.Length != 0)
			{
				this.Sender = other.Sender;
			}
			if (other.MailType != MailType.Normal)
			{
				this.MailType = other.MailType;
			}
			if (other.ExpireTime != 0L)
			{
				this.ExpireTime = other.ExpireTime;
			}
			if (other.IsRead)
			{
				this.IsRead = other.IsRead;
			}
			if (other.TemplateId != 0U)
			{
				this.TemplateId = other.TemplateId;
			}
			if (other.attachment_ != null)
			{
				if (this.attachment_ == null)
				{
					this.Attachment = new ItemList();
				}
				this.Attachment.MergeFrom(other.Attachment);
			}
			this.paraList_.Add(other.paraList_);
			if (other.Time != 0L)
			{
				this.Time = other.Time;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x0005CCC4 File Offset: 0x0005AEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0005CCD0 File Offset: 0x0005AED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.MailType = (MailType)input.ReadEnum();
							continue;
						}
						if (num == 18U)
						{
							if (this.attachment_ == null)
							{
								this.Attachment = new ItemList();
							}
							input.ReadMessage(this.Attachment);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							this.Content = input.ReadString();
							continue;
						}
						if (num == 32U)
						{
							this.Id = input.ReadUInt32();
							continue;
						}
						if (num == 42U)
						{
							this.Sender = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 48U)
					{
						this.Time = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.ExpireTime = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.IsRead = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.paraList_.AddEntriesFrom(ref input, ClientMail._repeated_paraList_codec);
						continue;
					}
					if (num == 88U)
					{
						this.TemplateId = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						this.Title = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000D67 RID: 3431
		private static readonly MessageParser<ClientMail> _parser = new MessageParser<ClientMail>(() => new ClientMail());

		// Token: 0x04000D68 RID: 3432
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D69 RID: 3433
		public const int TitleFieldNumber = 14;

		// Token: 0x04000D6A RID: 3434
		private string title_ = "";

		// Token: 0x04000D6B RID: 3435
		public const int ContentFieldNumber = 3;

		// Token: 0x04000D6C RID: 3436
		private string content_ = "";

		// Token: 0x04000D6D RID: 3437
		public const int IdFieldNumber = 4;

		// Token: 0x04000D6E RID: 3438
		private uint id_;

		// Token: 0x04000D6F RID: 3439
		public const int SenderFieldNumber = 5;

		// Token: 0x04000D70 RID: 3440
		private string sender_ = "";

		// Token: 0x04000D71 RID: 3441
		public const int MailTypeFieldNumber = 1;

		// Token: 0x04000D72 RID: 3442
		private MailType mailType_;

		// Token: 0x04000D73 RID: 3443
		public const int ExpireTimeFieldNumber = 7;

		// Token: 0x04000D74 RID: 3444
		private long expireTime_;

		// Token: 0x04000D75 RID: 3445
		public const int IsReadFieldNumber = 8;

		// Token: 0x04000D76 RID: 3446
		private bool isRead_;

		// Token: 0x04000D77 RID: 3447
		public const int TemplateIdFieldNumber = 11;

		// Token: 0x04000D78 RID: 3448
		private uint templateId_;

		// Token: 0x04000D79 RID: 3449
		public const int AttachmentFieldNumber = 2;

		// Token: 0x04000D7A RID: 3450
		private ItemList attachment_;

		// Token: 0x04000D7B RID: 3451
		public const int ParaListFieldNumber = 10;

		// Token: 0x04000D7C RID: 3452
		private static readonly FieldCodec<string> _repeated_paraList_codec = FieldCodec.ForString(82U);

		// Token: 0x04000D7D RID: 3453
		private readonly RepeatedField<string> paraList_ = new RepeatedField<string>();

		// Token: 0x04000D7E RID: 3454
		public const int TimeFieldNumber = 6;

		// Token: 0x04000D7F RID: 3455
		private long time_;
	}
}
