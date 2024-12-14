using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CE7 RID: 3303
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerSimpleInfo : IMessage<PlayerSimpleInfo>, IMessage, IEquatable<PlayerSimpleInfo>, IDeepCloneable<PlayerSimpleInfo>, IBufferMessage
	{
		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x06009364 RID: 37732 RVA: 0x00186DB3 File Offset: 0x00184FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSimpleInfo> Parser
		{
			get
			{
				return PlayerSimpleInfo._parser;
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x06009365 RID: 37733 RVA: 0x00186DBA File Offset: 0x00184FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerSimpleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x06009366 RID: 37734 RVA: 0x00186DCC File Offset: 0x00184FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSimpleInfo.Descriptor;
			}
		}

		// Token: 0x06009367 RID: 37735 RVA: 0x00186DD3 File Offset: 0x00184FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSimpleInfo()
		{
		}

		// Token: 0x06009368 RID: 37736 RVA: 0x00186E14 File Offset: 0x00185014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSimpleInfo(PlayerSimpleInfo other) : this()
		{
			this.assistSimpleInfoList_ = other.assistSimpleInfoList_.Clone();
			this.onlineStatus_ = other.onlineStatus_;
			this.headIcon_ = other.headIcon_;
			this.platform_ = other.platform_;
			this.signature_ = other.signature_;
			this.isBanned_ = other.isBanned_;
			this.level_ = other.level_;
			this.nickname_ = other.nickname_;
			this.lastActiveTime_ = other.lastActiveTime_;
			this.uid_ = other.uid_;
			this.fLFKCIHCENF_ = other.fLFKCIHCENF_;
			this.chatBubbleId_ = other.chatBubbleId_;
			this.hFHGPLMEFGJ_ = other.hFHGPLMEFGJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009369 RID: 37737 RVA: 0x00186ED9 File Offset: 0x001850D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSimpleInfo Clone()
		{
			return new PlayerSimpleInfo(this);
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x0600936A RID: 37738 RVA: 0x00186EE1 File Offset: 0x001850E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AssistSimpleInfo> AssistSimpleInfoList
		{
			get
			{
				return this.assistSimpleInfoList_;
			}
		}

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x0600936B RID: 37739 RVA: 0x00186EE9 File Offset: 0x001850E9
		// (set) Token: 0x0600936C RID: 37740 RVA: 0x00186EF1 File Offset: 0x001850F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendOnlineStatus OnlineStatus
		{
			get
			{
				return this.onlineStatus_;
			}
			set
			{
				this.onlineStatus_ = value;
			}
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x0600936D RID: 37741 RVA: 0x00186EFA File Offset: 0x001850FA
		// (set) Token: 0x0600936E RID: 37742 RVA: 0x00186F02 File Offset: 0x00185102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HeadIcon
		{
			get
			{
				return this.headIcon_;
			}
			set
			{
				this.headIcon_ = value;
			}
		}

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x0600936F RID: 37743 RVA: 0x00186F0B File Offset: 0x0018510B
		// (set) Token: 0x06009370 RID: 37744 RVA: 0x00186F13 File Offset: 0x00185113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlatformType Platform
		{
			get
			{
				return this.platform_;
			}
			set
			{
				this.platform_ = value;
			}
		}

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x06009371 RID: 37745 RVA: 0x00186F1C File Offset: 0x0018511C
		// (set) Token: 0x06009372 RID: 37746 RVA: 0x00186F24 File Offset: 0x00185124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x06009373 RID: 37747 RVA: 0x00186F37 File Offset: 0x00185137
		// (set) Token: 0x06009374 RID: 37748 RVA: 0x00186F3F File Offset: 0x0018513F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBanned
		{
			get
			{
				return this.isBanned_;
			}
			set
			{
				this.isBanned_ = value;
			}
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x06009375 RID: 37749 RVA: 0x00186F48 File Offset: 0x00185148
		// (set) Token: 0x06009376 RID: 37750 RVA: 0x00186F50 File Offset: 0x00185150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x06009377 RID: 37751 RVA: 0x00186F59 File Offset: 0x00185159
		// (set) Token: 0x06009378 RID: 37752 RVA: 0x00186F61 File Offset: 0x00185161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Nickname
		{
			get
			{
				return this.nickname_;
			}
			set
			{
				this.nickname_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x06009379 RID: 37753 RVA: 0x00186F74 File Offset: 0x00185174
		// (set) Token: 0x0600937A RID: 37754 RVA: 0x00186F7C File Offset: 0x0018517C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastActiveTime
		{
			get
			{
				return this.lastActiveTime_;
			}
			set
			{
				this.lastActiveTime_ = value;
			}
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x0600937B RID: 37755 RVA: 0x00186F85 File Offset: 0x00185185
		// (set) Token: 0x0600937C RID: 37756 RVA: 0x00186F8D File Offset: 0x0018518D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x0600937D RID: 37757 RVA: 0x00186F96 File Offset: 0x00185196
		// (set) Token: 0x0600937E RID: 37758 RVA: 0x00186F9E File Offset: 0x0018519E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FLFKCIHCENF
		{
			get
			{
				return this.fLFKCIHCENF_;
			}
			set
			{
				this.fLFKCIHCENF_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x0600937F RID: 37759 RVA: 0x00186FB1 File Offset: 0x001851B1
		// (set) Token: 0x06009380 RID: 37760 RVA: 0x00186FB9 File Offset: 0x001851B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChatBubbleId
		{
			get
			{
				return this.chatBubbleId_;
			}
			set
			{
				this.chatBubbleId_ = value;
			}
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x06009381 RID: 37761 RVA: 0x00186FC2 File Offset: 0x001851C2
		// (set) Token: 0x06009382 RID: 37762 RVA: 0x00186FCA File Offset: 0x001851CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string HFHGPLMEFGJ
		{
			get
			{
				return this.hFHGPLMEFGJ_;
			}
			set
			{
				this.hFHGPLMEFGJ_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x00186FDD File Offset: 0x001851DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSimpleInfo);
		}

		// Token: 0x06009384 RID: 37764 RVA: 0x00186FEC File Offset: 0x001851EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSimpleInfo other)
		{
			return other != null && (other == this || (this.assistSimpleInfoList_.Equals(other.assistSimpleInfoList_) && this.OnlineStatus == other.OnlineStatus && this.HeadIcon == other.HeadIcon && this.Platform == other.Platform && !(this.Signature != other.Signature) && this.IsBanned == other.IsBanned && this.Level == other.Level && !(this.Nickname != other.Nickname) && this.LastActiveTime == other.LastActiveTime && this.Uid == other.Uid && !(this.FLFKCIHCENF != other.FLFKCIHCENF) && this.ChatBubbleId == other.ChatBubbleId && !(this.HFHGPLMEFGJ != other.HFHGPLMEFGJ) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009385 RID: 37765 RVA: 0x00187100 File Offset: 0x00185300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.assistSimpleInfoList_.GetHashCode();
			if (this.OnlineStatus != FriendOnlineStatus.Offline)
			{
				num ^= this.OnlineStatus.GetHashCode();
			}
			if (this.HeadIcon != 0U)
			{
				num ^= this.HeadIcon.GetHashCode();
			}
			if (this.Platform != PlatformType.Editor)
			{
				num ^= this.Platform.GetHashCode();
			}
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this.IsBanned)
			{
				num ^= this.IsBanned.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Nickname.Length != 0)
			{
				num ^= this.Nickname.GetHashCode();
			}
			if (this.LastActiveTime != 0L)
			{
				num ^= this.LastActiveTime.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.FLFKCIHCENF.Length != 0)
			{
				num ^= this.FLFKCIHCENF.GetHashCode();
			}
			if (this.ChatBubbleId != 0U)
			{
				num ^= this.ChatBubbleId.GetHashCode();
			}
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				num ^= this.HFHGPLMEFGJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x00187276 File Offset: 0x00185476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x0018727E File Offset: 0x0018547E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x00187288 File Offset: 0x00185488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.assistSimpleInfoList_.WriteTo(ref output, PlayerSimpleInfo._repeated_assistSimpleInfoList_codec);
			if (this.HeadIcon != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.HeadIcon);
			}
			if (this.OnlineStatus != FriendOnlineStatus.Offline)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.OnlineStatus);
			}
			if (this.Platform != PlatformType.Editor)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Platform);
			}
			if (this.FLFKCIHCENF.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.FLFKCIHCENF);
			}
			if (this.Nickname.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Nickname);
			}
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Signature);
			}
			if (this.ChatBubbleId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ChatBubbleId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Level);
			}
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.HFHGPLMEFGJ);
			}
			if (this.LastActiveTime != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.LastActiveTime);
			}
			if (this.IsBanned)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsBanned);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x00187420 File Offset: 0x00185620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.assistSimpleInfoList_.CalculateSize(PlayerSimpleInfo._repeated_assistSimpleInfoList_codec);
			if (this.OnlineStatus != FriendOnlineStatus.Offline)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OnlineStatus);
			}
			if (this.HeadIcon != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HeadIcon);
			}
			if (this.Platform != PlatformType.Editor)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Platform);
			}
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this.IsBanned)
			{
				num += 2;
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Nickname.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Nickname);
			}
			if (this.LastActiveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastActiveTime);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.FLFKCIHCENF.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FLFKCIHCENF);
			}
			if (this.ChatBubbleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChatBubbleId);
			}
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HFHGPLMEFGJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600938A RID: 37770 RVA: 0x00187584 File Offset: 0x00185784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerSimpleInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.assistSimpleInfoList_.Add(other.assistSimpleInfoList_);
			if (other.OnlineStatus != FriendOnlineStatus.Offline)
			{
				this.OnlineStatus = other.OnlineStatus;
			}
			if (other.HeadIcon != 0U)
			{
				this.HeadIcon = other.HeadIcon;
			}
			if (other.Platform != PlatformType.Editor)
			{
				this.Platform = other.Platform;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			if (other.IsBanned)
			{
				this.IsBanned = other.IsBanned;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Nickname.Length != 0)
			{
				this.Nickname = other.Nickname;
			}
			if (other.LastActiveTime != 0L)
			{
				this.LastActiveTime = other.LastActiveTime;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.FLFKCIHCENF.Length != 0)
			{
				this.FLFKCIHCENF = other.FLFKCIHCENF;
			}
			if (other.ChatBubbleId != 0U)
			{
				this.ChatBubbleId = other.ChatBubbleId;
			}
			if (other.HFHGPLMEFGJ.Length != 0)
			{
				this.HFHGPLMEFGJ = other.HFHGPLMEFGJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x001876C1 File Offset: 0x001858C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x001876CC File Offset: 0x001858CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num <= 24U)
					{
						if (num == 10U)
						{
							this.assistSimpleInfoList_.AddEntriesFrom(ref input, PlayerSimpleInfo._repeated_assistSimpleInfoList_codec);
							continue;
						}
						if (num == 16U)
						{
							this.HeadIcon = input.ReadUInt32();
							continue;
						}
						if (num == 24U)
						{
							this.OnlineStatus = (FriendOnlineStatus)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.Platform = (PlatformType)input.ReadEnum();
							continue;
						}
						if (num == 42U)
						{
							this.FLFKCIHCENF = input.ReadString();
							continue;
						}
						if (num == 50U)
						{
							this.Nickname = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 58U)
					{
						this.Signature = input.ReadString();
						continue;
					}
					if (num == 64U)
					{
						this.ChatBubbleId = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 96U)
				{
					if (num == 90U)
					{
						this.HFHGPLMEFGJ = input.ReadString();
						continue;
					}
					if (num == 96U)
					{
						this.LastActiveTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.IsBanned = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038DA RID: 14554
		private static readonly MessageParser<PlayerSimpleInfo> _parser = new MessageParser<PlayerSimpleInfo>(() => new PlayerSimpleInfo());

		// Token: 0x040038DB RID: 14555
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038DC RID: 14556
		public const int AssistSimpleInfoListFieldNumber = 1;

		// Token: 0x040038DD RID: 14557
		private static readonly FieldCodec<AssistSimpleInfo> _repeated_assistSimpleInfoList_codec = FieldCodec.ForMessage<AssistSimpleInfo>(10U, AssistSimpleInfo.Parser);

		// Token: 0x040038DE RID: 14558
		private readonly RepeatedField<AssistSimpleInfo> assistSimpleInfoList_ = new RepeatedField<AssistSimpleInfo>();

		// Token: 0x040038DF RID: 14559
		public const int OnlineStatusFieldNumber = 3;

		// Token: 0x040038E0 RID: 14560
		private FriendOnlineStatus onlineStatus_;

		// Token: 0x040038E1 RID: 14561
		public const int HeadIconFieldNumber = 2;

		// Token: 0x040038E2 RID: 14562
		private uint headIcon_;

		// Token: 0x040038E3 RID: 14563
		public const int PlatformFieldNumber = 4;

		// Token: 0x040038E4 RID: 14564
		private PlatformType platform_;

		// Token: 0x040038E5 RID: 14565
		public const int SignatureFieldNumber = 7;

		// Token: 0x040038E6 RID: 14566
		private string signature_ = "";

		// Token: 0x040038E7 RID: 14567
		public const int IsBannedFieldNumber = 13;

		// Token: 0x040038E8 RID: 14568
		private bool isBanned_;

		// Token: 0x040038E9 RID: 14569
		public const int LevelFieldNumber = 10;

		// Token: 0x040038EA RID: 14570
		private uint level_;

		// Token: 0x040038EB RID: 14571
		public const int NicknameFieldNumber = 6;

		// Token: 0x040038EC RID: 14572
		private string nickname_ = "";

		// Token: 0x040038ED RID: 14573
		public const int LastActiveTimeFieldNumber = 12;

		// Token: 0x040038EE RID: 14574
		private long lastActiveTime_;

		// Token: 0x040038EF RID: 14575
		public const int UidFieldNumber = 14;

		// Token: 0x040038F0 RID: 14576
		private uint uid_;

		// Token: 0x040038F1 RID: 14577
		public const int FLFKCIHCENFFieldNumber = 5;

		// Token: 0x040038F2 RID: 14578
		private string fLFKCIHCENF_ = "";

		// Token: 0x040038F3 RID: 14579
		public const int ChatBubbleIdFieldNumber = 8;

		// Token: 0x040038F4 RID: 14580
		private uint chatBubbleId_;

		// Token: 0x040038F5 RID: 14581
		public const int HFHGPLMEFGJFieldNumber = 11;

		// Token: 0x040038F6 RID: 14582
		private string hFHGPLMEFGJ_ = "";
	}
}
