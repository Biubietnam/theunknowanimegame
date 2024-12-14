using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CAF RID: 3247
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerBasicInfo : IMessage<PlayerBasicInfo>, IMessage, IEquatable<PlayerBasicInfo>, IDeepCloneable<PlayerBasicInfo>, IBufferMessage
	{
		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x0600904B RID: 36939 RVA: 0x0017D10B File Offset: 0x0017B30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerBasicInfo> Parser
		{
			get
			{
				return PlayerBasicInfo._parser;
			}
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x0600904C RID: 36940 RVA: 0x0017D112 File Offset: 0x0017B312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerBasicInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x0600904D RID: 36941 RVA: 0x0017D124 File Offset: 0x0017B324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerBasicInfo.Descriptor;
			}
		}

		// Token: 0x0600904E RID: 36942 RVA: 0x0017D12B File Offset: 0x0017B32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfo()
		{
		}

		// Token: 0x0600904F RID: 36943 RVA: 0x0017D140 File Offset: 0x0017B340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfo(PlayerBasicInfo other) : this()
		{
			this.nickname_ = other.nickname_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.stamina_ = other.stamina_;
			this.mcoin_ = other.mcoin_;
			this.hcoin_ = other.hcoin_;
			this.scoin_ = other.scoin_;
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009050 RID: 36944 RVA: 0x0017D1C4 File Offset: 0x0017B3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfo Clone()
		{
			return new PlayerBasicInfo(this);
		}

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x06009051 RID: 36945 RVA: 0x0017D1CC File Offset: 0x0017B3CC
		// (set) Token: 0x06009052 RID: 36946 RVA: 0x0017D1D4 File Offset: 0x0017B3D4
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

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x06009053 RID: 36947 RVA: 0x0017D1E7 File Offset: 0x0017B3E7
		// (set) Token: 0x06009054 RID: 36948 RVA: 0x0017D1EF File Offset: 0x0017B3EF
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

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x06009055 RID: 36949 RVA: 0x0017D1F8 File Offset: 0x0017B3F8
		// (set) Token: 0x06009056 RID: 36950 RVA: 0x0017D200 File Offset: 0x0017B400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x06009057 RID: 36951 RVA: 0x0017D209 File Offset: 0x0017B409
		// (set) Token: 0x06009058 RID: 36952 RVA: 0x0017D211 File Offset: 0x0017B411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Stamina
		{
			get
			{
				return this.stamina_;
			}
			set
			{
				this.stamina_ = value;
			}
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x06009059 RID: 36953 RVA: 0x0017D21A File Offset: 0x0017B41A
		// (set) Token: 0x0600905A RID: 36954 RVA: 0x0017D222 File Offset: 0x0017B422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Mcoin
		{
			get
			{
				return this.mcoin_;
			}
			set
			{
				this.mcoin_ = value;
			}
		}

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x0600905B RID: 36955 RVA: 0x0017D22B File Offset: 0x0017B42B
		// (set) Token: 0x0600905C RID: 36956 RVA: 0x0017D233 File Offset: 0x0017B433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Hcoin
		{
			get
			{
				return this.hcoin_;
			}
			set
			{
				this.hcoin_ = value;
			}
		}

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x0600905D RID: 36957 RVA: 0x0017D23C File Offset: 0x0017B43C
		// (set) Token: 0x0600905E RID: 36958 RVA: 0x0017D244 File Offset: 0x0017B444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Scoin
		{
			get
			{
				return this.scoin_;
			}
			set
			{
				this.scoin_ = value;
			}
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x0600905F RID: 36959 RVA: 0x0017D24D File Offset: 0x0017B44D
		// (set) Token: 0x06009060 RID: 36960 RVA: 0x0017D255 File Offset: 0x0017B455
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

		// Token: 0x06009061 RID: 36961 RVA: 0x0017D25E File Offset: 0x0017B45E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerBasicInfo);
		}

		// Token: 0x06009062 RID: 36962 RVA: 0x0017D26C File Offset: 0x0017B46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerBasicInfo other)
		{
			return other != null && (other == this || (!(this.Nickname != other.Nickname) && this.Level == other.Level && this.Exp == other.Exp && this.Stamina == other.Stamina && this.Mcoin == other.Mcoin && this.Hcoin == other.Hcoin && this.Scoin == other.Scoin && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009063 RID: 36963 RVA: 0x0017D31C File Offset: 0x0017B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Nickname.Length != 0)
			{
				num ^= this.Nickname.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Stamina != 0U)
			{
				num ^= this.Stamina.GetHashCode();
			}
			if (this.Mcoin != 0U)
			{
				num ^= this.Mcoin.GetHashCode();
			}
			if (this.Hcoin != 0U)
			{
				num ^= this.Hcoin.GetHashCode();
			}
			if (this.Scoin != 0U)
			{
				num ^= this.Scoin.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009064 RID: 36964 RVA: 0x0017D40C File Offset: 0x0017B60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009065 RID: 36965 RVA: 0x0017D414 File Offset: 0x0017B614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009066 RID: 36966 RVA: 0x0017D420 File Offset: 0x0017B620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Nickname.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Nickname);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Exp);
			}
			if (this.Stamina != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Stamina);
			}
			if (this.Mcoin != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Mcoin);
			}
			if (this.Hcoin != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Hcoin);
			}
			if (this.Scoin != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Scoin);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009067 RID: 36967 RVA: 0x0017D528 File Offset: 0x0017B728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Nickname.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Nickname);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.Stamina != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Stamina);
			}
			if (this.Mcoin != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Mcoin);
			}
			if (this.Hcoin != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Hcoin);
			}
			if (this.Scoin != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Scoin);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009068 RID: 36968 RVA: 0x0017D614 File Offset: 0x0017B814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerBasicInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Nickname.Length != 0)
			{
				this.Nickname = other.Nickname;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.Stamina != 0U)
			{
				this.Stamina = other.Stamina;
			}
			if (other.Mcoin != 0U)
			{
				this.Mcoin = other.Mcoin;
			}
			if (other.Hcoin != 0U)
			{
				this.Hcoin = other.Hcoin;
			}
			if (other.Scoin != 0U)
			{
				this.Scoin = other.Scoin;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009069 RID: 36969 RVA: 0x0017D6E1 File Offset: 0x0017B8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600906A RID: 36970 RVA: 0x0017D6EC File Offset: 0x0017B8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
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
							this.Level = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Exp = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.Stamina = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.Mcoin = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Hcoin = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Scoin = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003773 RID: 14195
		private static readonly MessageParser<PlayerBasicInfo> _parser = new MessageParser<PlayerBasicInfo>(() => new PlayerBasicInfo());

		// Token: 0x04003774 RID: 14196
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003775 RID: 14197
		public const int NicknameFieldNumber = 1;

		// Token: 0x04003776 RID: 14198
		private string nickname_ = "";

		// Token: 0x04003777 RID: 14199
		public const int LevelFieldNumber = 2;

		// Token: 0x04003778 RID: 14200
		private uint level_;

		// Token: 0x04003779 RID: 14201
		public const int ExpFieldNumber = 3;

		// Token: 0x0400377A RID: 14202
		private uint exp_;

		// Token: 0x0400377B RID: 14203
		public const int StaminaFieldNumber = 4;

		// Token: 0x0400377C RID: 14204
		private uint stamina_;

		// Token: 0x0400377D RID: 14205
		public const int McoinFieldNumber = 5;

		// Token: 0x0400377E RID: 14206
		private uint mcoin_;

		// Token: 0x0400377F RID: 14207
		public const int HcoinFieldNumber = 6;

		// Token: 0x04003780 RID: 14208
		private uint hcoin_;

		// Token: 0x04003781 RID: 14209
		public const int ScoinFieldNumber = 7;

		// Token: 0x04003782 RID: 14210
		private uint scoin_;

		// Token: 0x04003783 RID: 14211
		public const int WorldLevelFieldNumber = 8;

		// Token: 0x04003784 RID: 14212
		private uint worldLevel_;
	}
}
