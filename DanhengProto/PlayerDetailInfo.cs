using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CB5 RID: 3253
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerDetailInfo : IMessage<PlayerDetailInfo>, IMessage, IEquatable<PlayerDetailInfo>, IDeepCloneable<PlayerDetailInfo>, IBufferMessage
	{
		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x060090A3 RID: 37027 RVA: 0x0017E345 File Offset: 0x0017C545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerDetailInfo> Parser
		{
			get
			{
				return PlayerDetailInfo._parser;
			}
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x060090A4 RID: 37028 RVA: 0x0017E34C File Offset: 0x0017C54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerDetailInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x060090A5 RID: 37029 RVA: 0x0017E35E File Offset: 0x0017C55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerDetailInfo.Descriptor;
			}
		}

		// Token: 0x060090A6 RID: 37030 RVA: 0x0017E368 File Offset: 0x0017C568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetailInfo()
		{
		}

		// Token: 0x060090A7 RID: 37031 RVA: 0x0017E3C0 File Offset: 0x0017C5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetailInfo(PlayerDetailInfo other) : this()
		{
			this.worldLevel_ = other.worldLevel_;
			this.isBanned_ = other.isBanned_;
			this.level_ = other.level_;
			this.signature_ = other.signature_;
			this.pLCLJEFAHIM_ = ((other.pLCLJEFAHIM_ != null) ? other.pLCLJEFAHIM_.Clone() : null);
			this.mEODGCCAPLF_ = other.mEODGCCAPLF_;
			this.platform_ = other.platform_;
			this.headIcon_ = other.headIcon_;
			this.uid_ = other.uid_;
			this.assistAvatarList_ = other.assistAvatarList_.Clone();
			this.fLFKCIHCENF_ = other.fLFKCIHCENF_;
			this.privacySettings_ = ((other.privacySettings_ != null) ? other.privacySettings_.Clone() : null);
			this.displayAvatarList_ = other.displayAvatarList_.Clone();
			this.hFHGPLMEFGJ_ = other.hFHGPLMEFGJ_;
			this.pMPLHMENMPI_ = other.pMPLHMENMPI_;
			this.recordInfo_ = ((other.recordInfo_ != null) ? other.recordInfo_.Clone() : null);
			this.nickname_ = other.nickname_;
			this.eJHPPHPCIEM_ = other.eJHPPHPCIEM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090A8 RID: 37032 RVA: 0x0017E4F6 File Offset: 0x0017C6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetailInfo Clone()
		{
			return new PlayerDetailInfo(this);
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x060090A9 RID: 37033 RVA: 0x0017E4FE File Offset: 0x0017C6FE
		// (set) Token: 0x060090AA RID: 37034 RVA: 0x0017E506 File Offset: 0x0017C706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x060090AB RID: 37035 RVA: 0x0017E50F File Offset: 0x0017C70F
		// (set) Token: 0x060090AC RID: 37036 RVA: 0x0017E517 File Offset: 0x0017C717
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

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x060090AD RID: 37037 RVA: 0x0017E520 File Offset: 0x0017C720
		// (set) Token: 0x060090AE RID: 37038 RVA: 0x0017E528 File Offset: 0x0017C728
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

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x060090AF RID: 37039 RVA: 0x0017E531 File Offset: 0x0017C731
		// (set) Token: 0x060090B0 RID: 37040 RVA: 0x0017E539 File Offset: 0x0017C739
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

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x060090B1 RID: 37041 RVA: 0x0017E54C File Offset: 0x0017C74C
		// (set) Token: 0x060090B2 RID: 37042 RVA: 0x0017E554 File Offset: 0x0017C754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDisplaySettings PLCLJEFAHIM
		{
			get
			{
				return this.pLCLJEFAHIM_;
			}
			set
			{
				this.pLCLJEFAHIM_ = value;
			}
		}

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x060090B3 RID: 37043 RVA: 0x0017E55D File Offset: 0x0017C75D
		// (set) Token: 0x060090B4 RID: 37044 RVA: 0x0017E565 File Offset: 0x0017C765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MEODGCCAPLF
		{
			get
			{
				return this.mEODGCCAPLF_;
			}
			set
			{
				this.mEODGCCAPLF_ = value;
			}
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x060090B5 RID: 37045 RVA: 0x0017E56E File Offset: 0x0017C76E
		// (set) Token: 0x060090B6 RID: 37046 RVA: 0x0017E576 File Offset: 0x0017C776
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

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x060090B7 RID: 37047 RVA: 0x0017E57F File Offset: 0x0017C77F
		// (set) Token: 0x060090B8 RID: 37048 RVA: 0x0017E587 File Offset: 0x0017C787
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

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x060090B9 RID: 37049 RVA: 0x0017E590 File Offset: 0x0017C790
		// (set) Token: 0x060090BA RID: 37050 RVA: 0x0017E598 File Offset: 0x0017C798
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

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x060090BB RID: 37051 RVA: 0x0017E5A1 File Offset: 0x0017C7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DisplayAvatarDetailInfo> AssistAvatarList
		{
			get
			{
				return this.assistAvatarList_;
			}
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x060090BC RID: 37052 RVA: 0x0017E5A9 File Offset: 0x0017C7A9
		// (set) Token: 0x060090BD RID: 37053 RVA: 0x0017E5B1 File Offset: 0x0017C7B1
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

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x060090BE RID: 37054 RVA: 0x0017E5C4 File Offset: 0x0017C7C4
		// (set) Token: 0x060090BF RID: 37055 RVA: 0x0017E5CC File Offset: 0x0017C7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivacySettings PrivacySettings
		{
			get
			{
				return this.privacySettings_;
			}
			set
			{
				this.privacySettings_ = value;
			}
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x060090C0 RID: 37056 RVA: 0x0017E5D5 File Offset: 0x0017C7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DisplayAvatarDetailInfo> DisplayAvatarList
		{
			get
			{
				return this.displayAvatarList_;
			}
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x060090C1 RID: 37057 RVA: 0x0017E5DD File Offset: 0x0017C7DD
		// (set) Token: 0x060090C2 RID: 37058 RVA: 0x0017E5E5 File Offset: 0x0017C7E5
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

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x060090C3 RID: 37059 RVA: 0x0017E5F8 File Offset: 0x0017C7F8
		// (set) Token: 0x060090C4 RID: 37060 RVA: 0x0017E600 File Offset: 0x0017C800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PMPLHMENMPI
		{
			get
			{
				return this.pMPLHMENMPI_;
			}
			set
			{
				this.pMPLHMENMPI_ = value;
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x060090C5 RID: 37061 RVA: 0x0017E609 File Offset: 0x0017C809
		// (set) Token: 0x060090C6 RID: 37062 RVA: 0x0017E611 File Offset: 0x0017C811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRecordInfo RecordInfo
		{
			get
			{
				return this.recordInfo_;
			}
			set
			{
				this.recordInfo_ = value;
			}
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x060090C7 RID: 37063 RVA: 0x0017E61A File Offset: 0x0017C81A
		// (set) Token: 0x060090C8 RID: 37064 RVA: 0x0017E622 File Offset: 0x0017C822
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

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x060090C9 RID: 37065 RVA: 0x0017E635 File Offset: 0x0017C835
		// (set) Token: 0x060090CA RID: 37066 RVA: 0x0017E63D File Offset: 0x0017C83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EJHPPHPCIEM
		{
			get
			{
				return this.eJHPPHPCIEM_;
			}
			set
			{
				this.eJHPPHPCIEM_ = value;
			}
		}

		// Token: 0x060090CB RID: 37067 RVA: 0x0017E646 File Offset: 0x0017C846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerDetailInfo);
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x0017E654 File Offset: 0x0017C854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerDetailInfo other)
		{
			return other != null && (other == this || (this.WorldLevel == other.WorldLevel && this.IsBanned == other.IsBanned && this.Level == other.Level && !(this.Signature != other.Signature) && object.Equals(this.PLCLJEFAHIM, other.PLCLJEFAHIM) && this.MEODGCCAPLF == other.MEODGCCAPLF && this.Platform == other.Platform && this.HeadIcon == other.HeadIcon && this.Uid == other.Uid && this.assistAvatarList_.Equals(other.assistAvatarList_) && !(this.FLFKCIHCENF != other.FLFKCIHCENF) && object.Equals(this.PrivacySettings, other.PrivacySettings) && this.displayAvatarList_.Equals(other.displayAvatarList_) && !(this.HFHGPLMEFGJ != other.HFHGPLMEFGJ) && this.PMPLHMENMPI == other.PMPLHMENMPI && object.Equals(this.RecordInfo, other.RecordInfo) && !(this.Nickname != other.Nickname) && this.EJHPPHPCIEM == other.EJHPPHPCIEM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x0017E7CC File Offset: 0x0017C9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.IsBanned)
			{
				num ^= this.IsBanned.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this.pLCLJEFAHIM_ != null)
			{
				num ^= this.PLCLJEFAHIM.GetHashCode();
			}
			if (this.MEODGCCAPLF != 0U)
			{
				num ^= this.MEODGCCAPLF.GetHashCode();
			}
			if (this.Platform != PlatformType.Editor)
			{
				num ^= this.Platform.GetHashCode();
			}
			if (this.HeadIcon != 0U)
			{
				num ^= this.HeadIcon.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			num ^= this.assistAvatarList_.GetHashCode();
			if (this.FLFKCIHCENF.Length != 0)
			{
				num ^= this.FLFKCIHCENF.GetHashCode();
			}
			if (this.privacySettings_ != null)
			{
				num ^= this.PrivacySettings.GetHashCode();
			}
			num ^= this.displayAvatarList_.GetHashCode();
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				num ^= this.HFHGPLMEFGJ.GetHashCode();
			}
			if (this.PMPLHMENMPI)
			{
				num ^= this.PMPLHMENMPI.GetHashCode();
			}
			if (this.recordInfo_ != null)
			{
				num ^= this.RecordInfo.GetHashCode();
			}
			if (this.Nickname.Length != 0)
			{
				num ^= this.Nickname.GetHashCode();
			}
			if (this.EJHPPHPCIEM != 0U)
			{
				num ^= this.EJHPPHPCIEM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x0017E9A3 File Offset: 0x0017CBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x0017E9AB File Offset: 0x0017CBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x0017E9B4 File Offset: 0x0017CBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Nickname.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Nickname);
			}
			if (this.HeadIcon != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.HeadIcon);
			}
			if (this.PMPLHMENMPI)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.PMPLHMENMPI);
			}
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Signature);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Uid);
			}
			if (this.FLFKCIHCENF.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.FLFKCIHCENF);
			}
			if (this.MEODGCCAPLF != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MEODGCCAPLF);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.EJHPPHPCIEM != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.EJHPPHPCIEM);
			}
			if (this.Platform != PlatformType.Editor)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Platform);
			}
			if (this.recordInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RecordInfo);
			}
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.HFHGPLMEFGJ);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Level);
			}
			this.assistAvatarList_.WriteTo(ref output, PlayerDetailInfo._repeated_assistAvatarList_codec);
			if (this.IsBanned)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsBanned);
			}
			this.displayAvatarList_.WriteTo(ref output, PlayerDetailInfo._repeated_displayAvatarList_codec);
			if (this.privacySettings_ != null)
			{
				output.WriteRawTag(218, 31);
				output.WriteMessage(this.PrivacySettings);
			}
			if (this.pLCLJEFAHIM_ != null)
			{
				output.WriteRawTag(130, 105);
				output.WriteMessage(this.PLCLJEFAHIM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090D1 RID: 37073 RVA: 0x0017EBD8 File Offset: 0x0017CDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.IsBanned)
			{
				num += 2;
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this.pLCLJEFAHIM_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PLCLJEFAHIM);
			}
			if (this.MEODGCCAPLF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MEODGCCAPLF);
			}
			if (this.Platform != PlatformType.Editor)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Platform);
			}
			if (this.HeadIcon != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HeadIcon);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			num += this.assistAvatarList_.CalculateSize(PlayerDetailInfo._repeated_assistAvatarList_codec);
			if (this.FLFKCIHCENF.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FLFKCIHCENF);
			}
			if (this.privacySettings_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PrivacySettings);
			}
			num += this.displayAvatarList_.CalculateSize(PlayerDetailInfo._repeated_displayAvatarList_codec);
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HFHGPLMEFGJ);
			}
			if (this.PMPLHMENMPI)
			{
				num += 2;
			}
			if (this.recordInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RecordInfo);
			}
			if (this.Nickname.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Nickname);
			}
			if (this.EJHPPHPCIEM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EJHPPHPCIEM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060090D2 RID: 37074 RVA: 0x0017EDA0 File Offset: 0x0017CFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerDetailInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.IsBanned)
			{
				this.IsBanned = other.IsBanned;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			if (other.pLCLJEFAHIM_ != null)
			{
				if (this.pLCLJEFAHIM_ == null)
				{
					this.PLCLJEFAHIM = new PlayerDisplaySettings();
				}
				this.PLCLJEFAHIM.MergeFrom(other.PLCLJEFAHIM);
			}
			if (other.MEODGCCAPLF != 0U)
			{
				this.MEODGCCAPLF = other.MEODGCCAPLF;
			}
			if (other.Platform != PlatformType.Editor)
			{
				this.Platform = other.Platform;
			}
			if (other.HeadIcon != 0U)
			{
				this.HeadIcon = other.HeadIcon;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this.assistAvatarList_.Add(other.assistAvatarList_);
			if (other.FLFKCIHCENF.Length != 0)
			{
				this.FLFKCIHCENF = other.FLFKCIHCENF;
			}
			if (other.privacySettings_ != null)
			{
				if (this.privacySettings_ == null)
				{
					this.PrivacySettings = new PrivacySettings();
				}
				this.PrivacySettings.MergeFrom(other.PrivacySettings);
			}
			this.displayAvatarList_.Add(other.displayAvatarList_);
			if (other.HFHGPLMEFGJ.Length != 0)
			{
				this.HFHGPLMEFGJ = other.HFHGPLMEFGJ;
			}
			if (other.PMPLHMENMPI)
			{
				this.PMPLHMENMPI = other.PMPLHMENMPI;
			}
			if (other.recordInfo_ != null)
			{
				if (this.recordInfo_ == null)
				{
					this.RecordInfo = new PlayerRecordInfo();
				}
				this.RecordInfo.MergeFrom(other.RecordInfo);
			}
			if (other.Nickname.Length != 0)
			{
				this.Nickname = other.Nickname;
			}
			if (other.EJHPPHPCIEM != 0U)
			{
				this.EJHPPHPCIEM = other.EJHPPHPCIEM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x0017EF86 File Offset: 0x0017D186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090D4 RID: 37076 RVA: 0x0017EF90 File Offset: 0x0017D190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num <= 34U)
					{
						if (num <= 16U)
						{
							if (num == 10U)
							{
								this.Nickname = input.ReadString();
								continue;
							}
							if (num == 16U)
							{
								this.HeadIcon = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.PMPLHMENMPI = input.ReadBool();
								continue;
							}
							if (num == 34U)
							{
								this.Signature = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 50U)
					{
						if (num == 40U)
						{
							this.Uid = input.ReadUInt32();
							continue;
						}
						if (num == 50U)
						{
							this.FLFKCIHCENF = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.MEODGCCAPLF = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							this.WorldLevel = input.ReadUInt32();
							continue;
						}
						if (num == 72U)
						{
							this.EJHPPHPCIEM = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num <= 90U)
					{
						if (num == 80U)
						{
							this.Platform = (PlatformType)input.ReadEnum();
							continue;
						}
						if (num == 90U)
						{
							if (this.recordInfo_ == null)
							{
								this.RecordInfo = new PlayerRecordInfo();
							}
							input.ReadMessage(this.RecordInfo);
							continue;
						}
					}
					else
					{
						if (num == 98U)
						{
							this.HFHGPLMEFGJ = input.ReadString();
							continue;
						}
						if (num == 104U)
						{
							this.Level = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 120U)
				{
					if (num == 114U)
					{
						this.assistAvatarList_.AddEntriesFrom(ref input, PlayerDetailInfo._repeated_assistAvatarList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.IsBanned = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 2722U)
					{
						this.displayAvatarList_.AddEntriesFrom(ref input, PlayerDetailInfo._repeated_displayAvatarList_codec);
						continue;
					}
					if (num == 4058U)
					{
						if (this.privacySettings_ == null)
						{
							this.PrivacySettings = new PrivacySettings();
						}
						input.ReadMessage(this.PrivacySettings);
						continue;
					}
					if (num == 13442U)
					{
						if (this.pLCLJEFAHIM_ == null)
						{
							this.PLCLJEFAHIM = new PlayerDisplaySettings();
						}
						input.ReadMessage(this.PLCLJEFAHIM);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400379D RID: 14237
		private static readonly MessageParser<PlayerDetailInfo> _parser = new MessageParser<PlayerDetailInfo>(() => new PlayerDetailInfo());

		// Token: 0x0400379E RID: 14238
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400379F RID: 14239
		public const int WorldLevelFieldNumber = 8;

		// Token: 0x040037A0 RID: 14240
		private uint worldLevel_;

		// Token: 0x040037A1 RID: 14241
		public const int IsBannedFieldNumber = 15;

		// Token: 0x040037A2 RID: 14242
		private bool isBanned_;

		// Token: 0x040037A3 RID: 14243
		public const int LevelFieldNumber = 13;

		// Token: 0x040037A4 RID: 14244
		private uint level_;

		// Token: 0x040037A5 RID: 14245
		public const int SignatureFieldNumber = 4;

		// Token: 0x040037A6 RID: 14246
		private string signature_ = "";

		// Token: 0x040037A7 RID: 14247
		public const int PLCLJEFAHIMFieldNumber = 1680;

		// Token: 0x040037A8 RID: 14248
		private PlayerDisplaySettings pLCLJEFAHIM_;

		// Token: 0x040037A9 RID: 14249
		public const int MEODGCCAPLFFieldNumber = 7;

		// Token: 0x040037AA RID: 14250
		private uint mEODGCCAPLF_;

		// Token: 0x040037AB RID: 14251
		public const int PlatformFieldNumber = 10;

		// Token: 0x040037AC RID: 14252
		private PlatformType platform_;

		// Token: 0x040037AD RID: 14253
		public const int HeadIconFieldNumber = 2;

		// Token: 0x040037AE RID: 14254
		private uint headIcon_;

		// Token: 0x040037AF RID: 14255
		public const int UidFieldNumber = 5;

		// Token: 0x040037B0 RID: 14256
		private uint uid_;

		// Token: 0x040037B1 RID: 14257
		public const int AssistAvatarListFieldNumber = 14;

		// Token: 0x040037B2 RID: 14258
		private static readonly FieldCodec<DisplayAvatarDetailInfo> _repeated_assistAvatarList_codec = FieldCodec.ForMessage<DisplayAvatarDetailInfo>(114U, DisplayAvatarDetailInfo.Parser);

		// Token: 0x040037B3 RID: 14259
		private readonly RepeatedField<DisplayAvatarDetailInfo> assistAvatarList_ = new RepeatedField<DisplayAvatarDetailInfo>();

		// Token: 0x040037B4 RID: 14260
		public const int FLFKCIHCENFFieldNumber = 6;

		// Token: 0x040037B5 RID: 14261
		private string fLFKCIHCENF_ = "";

		// Token: 0x040037B6 RID: 14262
		public const int PrivacySettingsFieldNumber = 507;

		// Token: 0x040037B7 RID: 14263
		private PrivacySettings privacySettings_;

		// Token: 0x040037B8 RID: 14264
		public const int DisplayAvatarListFieldNumber = 340;

		// Token: 0x040037B9 RID: 14265
		private static readonly FieldCodec<DisplayAvatarDetailInfo> _repeated_displayAvatarList_codec = FieldCodec.ForMessage<DisplayAvatarDetailInfo>(2722U, DisplayAvatarDetailInfo.Parser);

		// Token: 0x040037BA RID: 14266
		private readonly RepeatedField<DisplayAvatarDetailInfo> displayAvatarList_ = new RepeatedField<DisplayAvatarDetailInfo>();

		// Token: 0x040037BB RID: 14267
		public const int HFHGPLMEFGJFieldNumber = 12;

		// Token: 0x040037BC RID: 14268
		private string hFHGPLMEFGJ_ = "";

		// Token: 0x040037BD RID: 14269
		public const int PMPLHMENMPIFieldNumber = 3;

		// Token: 0x040037BE RID: 14270
		private bool pMPLHMENMPI_;

		// Token: 0x040037BF RID: 14271
		public const int RecordInfoFieldNumber = 11;

		// Token: 0x040037C0 RID: 14272
		private PlayerRecordInfo recordInfo_;

		// Token: 0x040037C1 RID: 14273
		public const int NicknameFieldNumber = 1;

		// Token: 0x040037C2 RID: 14274
		private string nickname_ = "";

		// Token: 0x040037C3 RID: 14275
		public const int EJHPPHPCIEMFieldNumber = 9;

		// Token: 0x040037C4 RID: 14276
		private uint eJHPPHPCIEM_;
	}
}
