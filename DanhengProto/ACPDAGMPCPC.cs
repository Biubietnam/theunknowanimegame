using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200002F RID: 47
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ACPDAGMPCPC : IMessage<ACPDAGMPCPC>, IMessage, IEquatable<ACPDAGMPCPC>, IDeepCloneable<ACPDAGMPCPC>, IBufferMessage
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00005B33 File Offset: 0x00003D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ACPDAGMPCPC> Parser
		{
			get
			{
				return ACPDAGMPCPC._parser;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00005B3A File Offset: 0x00003D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ACPDAGMPCPCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00005B4C File Offset: 0x00003D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ACPDAGMPCPC.Descriptor;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00005B53 File Offset: 0x00003D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACPDAGMPCPC()
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00005B7C File Offset: 0x00003D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACPDAGMPCPC(ACPDAGMPCPC other) : this()
		{
			this.platform_ = other.platform_;
			this.level_ = other.level_;
			this.headIcon_ = other.headIcon_;
			this.uid_ = other.uid_;
			this.remarkName_ = other.remarkName_;
			this.hFHGPLMEFGJ_ = other.hFHGPLMEFGJ_;
			this.mHCKOEADGEL_ = other.mHCKOEADGEL_;
			this.nickname_ = other.nickname_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00005C00 File Offset: 0x00003E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACPDAGMPCPC Clone()
		{
			return new ACPDAGMPCPC(this);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00005C08 File Offset: 0x00003E08
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00005C10 File Offset: 0x00003E10
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00005C19 File Offset: 0x00003E19
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00005C21 File Offset: 0x00003E21
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00005C2A File Offset: 0x00003E2A
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00005C32 File Offset: 0x00003E32
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00005C3B File Offset: 0x00003E3B
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00005C43 File Offset: 0x00003E43
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00005C4C File Offset: 0x00003E4C
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00005C54 File Offset: 0x00003E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RemarkName
		{
			get
			{
				return this.remarkName_;
			}
			set
			{
				this.remarkName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00005C67 File Offset: 0x00003E67
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00005C6F File Offset: 0x00003E6F
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00005C82 File Offset: 0x00003E82
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00005C8A File Offset: 0x00003E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MHCKOEADGEL
		{
			get
			{
				return this.mHCKOEADGEL_;
			}
			set
			{
				this.mHCKOEADGEL_ = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00005C93 File Offset: 0x00003E93
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00005C9B File Offset: 0x00003E9B
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

		// Token: 0x060001BE RID: 446 RVA: 0x00005CAE File Offset: 0x00003EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ACPDAGMPCPC);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00005CBC File Offset: 0x00003EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ACPDAGMPCPC other)
		{
			return other != null && (other == this || (this.Platform == other.Platform && this.Level == other.Level && this.HeadIcon == other.HeadIcon && this.Uid == other.Uid && !(this.RemarkName != other.RemarkName) && !(this.HFHGPLMEFGJ != other.HFHGPLMEFGJ) && this.MHCKOEADGEL == other.MHCKOEADGEL && !(this.Nickname != other.Nickname) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00005D74 File Offset: 0x00003F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Platform != PlatformType.Editor)
			{
				num ^= this.Platform.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.HeadIcon != 0U)
			{
				num ^= this.HeadIcon.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.RemarkName.Length != 0)
			{
				num ^= this.RemarkName.GetHashCode();
			}
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				num ^= this.HFHGPLMEFGJ.GetHashCode();
			}
			if (this.MHCKOEADGEL != 0U)
			{
				num ^= this.MHCKOEADGEL.GetHashCode();
			}
			if (this.Nickname.Length != 0)
			{
				num ^= this.Nickname.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00005E6E File Offset: 0x0000406E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00005E76 File Offset: 0x00004076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00005E80 File Offset: 0x00004080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Nickname.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Nickname);
			}
			if (this.RemarkName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.RemarkName);
			}
			if (this.Platform != PlatformType.Editor)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Platform);
			}
			if (this.MHCKOEADGEL != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MHCKOEADGEL);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Level);
			}
			if (this.HeadIcon != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.HeadIcon);
			}
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.HFHGPLMEFGJ);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00005F90 File Offset: 0x00004190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Platform != PlatformType.Editor)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Platform);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.HeadIcon != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HeadIcon);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.RemarkName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RemarkName);
			}
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HFHGPLMEFGJ);
			}
			if (this.MHCKOEADGEL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MHCKOEADGEL);
			}
			if (this.Nickname.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Nickname);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00006088 File Offset: 0x00004288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ACPDAGMPCPC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Platform != PlatformType.Editor)
			{
				this.Platform = other.Platform;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.HeadIcon != 0U)
			{
				this.HeadIcon = other.HeadIcon;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.RemarkName.Length != 0)
			{
				this.RemarkName = other.RemarkName;
			}
			if (other.HFHGPLMEFGJ.Length != 0)
			{
				this.HFHGPLMEFGJ = other.HFHGPLMEFGJ;
			}
			if (other.MHCKOEADGEL != 0U)
			{
				this.MHCKOEADGEL = other.MHCKOEADGEL;
			}
			if (other.Nickname.Length != 0)
			{
				this.Nickname = other.Nickname;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000615F File Offset: 0x0000435F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00006168 File Offset: 0x00004368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num <= 26U)
					{
						if (num == 18U)
						{
							this.Nickname = input.ReadString();
							continue;
						}
						if (num == 26U)
						{
							this.RemarkName = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.Platform = (PlatformType)input.ReadEnum();
							continue;
						}
						if (num == 72U)
						{
							this.MHCKOEADGEL = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.HeadIcon = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.HFHGPLMEFGJ = input.ReadString();
						continue;
					}
					if (num == 120U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400008B RID: 139
		private static readonly MessageParser<ACPDAGMPCPC> _parser = new MessageParser<ACPDAGMPCPC>(() => new ACPDAGMPCPC());

		// Token: 0x0400008C RID: 140
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400008D RID: 141
		public const int PlatformFieldNumber = 7;

		// Token: 0x0400008E RID: 142
		private PlatformType platform_;

		// Token: 0x0400008F RID: 143
		public const int LevelFieldNumber = 10;

		// Token: 0x04000090 RID: 144
		private uint level_;

		// Token: 0x04000091 RID: 145
		public const int HeadIconFieldNumber = 11;

		// Token: 0x04000092 RID: 146
		private uint headIcon_;

		// Token: 0x04000093 RID: 147
		public const int UidFieldNumber = 15;

		// Token: 0x04000094 RID: 148
		private uint uid_;

		// Token: 0x04000095 RID: 149
		public const int RemarkNameFieldNumber = 3;

		// Token: 0x04000096 RID: 150
		private string remarkName_ = "";

		// Token: 0x04000097 RID: 151
		public const int HFHGPLMEFGJFieldNumber = 13;

		// Token: 0x04000098 RID: 152
		private string hFHGPLMEFGJ_ = "";

		// Token: 0x04000099 RID: 153
		public const int MHCKOEADGELFieldNumber = 9;

		// Token: 0x0400009A RID: 154
		private uint mHCKOEADGEL_;

		// Token: 0x0400009B RID: 155
		public const int NicknameFieldNumber = 2;

		// Token: 0x0400009C RID: 156
		private string nickname_ = "";
	}
}
