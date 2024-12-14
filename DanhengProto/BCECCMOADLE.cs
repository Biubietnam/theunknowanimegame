using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000111 RID: 273
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BCECCMOADLE : IMessage<BCECCMOADLE>, IMessage, IEquatable<BCECCMOADLE>, IDeepCloneable<BCECCMOADLE>, IBufferMessage
	{
		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x000250D7 File Offset: 0x000232D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BCECCMOADLE> Parser
		{
			get
			{
				return BCECCMOADLE._parser;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x000250DE File Offset: 0x000232DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BCECCMOADLEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x000250F0 File Offset: 0x000232F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BCECCMOADLE.Descriptor;
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x000250F7 File Offset: 0x000232F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BCECCMOADLE()
		{
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00025120 File Offset: 0x00023320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BCECCMOADLE(BCECCMOADLE other) : this()
		{
			this.uid_ = other.uid_;
			this.level_ = other.level_;
			this.nickname_ = other.nickname_;
			this.lMNDOGAFOGC_ = other.lMNDOGAFOGC_;
			this.platform_ = other.platform_;
			this.fLFKCIHCENF_ = other.fLFKCIHCENF_;
			this.kDCLOCAPBGE_ = other.kDCLOCAPBGE_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x000251A4 File Offset: 0x000233A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BCECCMOADLE Clone()
		{
			return new BCECCMOADLE(this);
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000251AC File Offset: 0x000233AC
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x000251B4 File Offset: 0x000233B4
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

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x000251BD File Offset: 0x000233BD
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x000251C5 File Offset: 0x000233C5
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x000251CE File Offset: 0x000233CE
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x000251D6 File Offset: 0x000233D6
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

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x000251E9 File Offset: 0x000233E9
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x000251F1 File Offset: 0x000233F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LMNDOGAFOGC
		{
			get
			{
				return this.lMNDOGAFOGC_;
			}
			set
			{
				this.lMNDOGAFOGC_ = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x000251FA File Offset: 0x000233FA
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00025202 File Offset: 0x00023402
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

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0002520B File Offset: 0x0002340B
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x00025213 File Offset: 0x00023413
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

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00025226 File Offset: 0x00023426
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x0002522E File Offset: 0x0002342E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string KDCLOCAPBGE
		{
			get
			{
				return this.kDCLOCAPBGE_;
			}
			set
			{
				this.kDCLOCAPBGE_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00025241 File Offset: 0x00023441
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x00025249 File Offset: 0x00023449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00025252 File Offset: 0x00023452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BCECCMOADLE);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00025260 File Offset: 0x00023460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BCECCMOADLE other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.Level == other.Level && !(this.Nickname != other.Nickname) && this.LMNDOGAFOGC == other.LMNDOGAFOGC && this.Platform == other.Platform && !(this.FLFKCIHCENF != other.FLFKCIHCENF) && !(this.KDCLOCAPBGE != other.KDCLOCAPBGE) && this.Version == other.Version && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00025318 File Offset: 0x00023518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Nickname.Length != 0)
			{
				num ^= this.Nickname.GetHashCode();
			}
			if (this.LMNDOGAFOGC != 0U)
			{
				num ^= this.LMNDOGAFOGC.GetHashCode();
			}
			if (this.Platform != PlatformType.Editor)
			{
				num ^= this.Platform.GetHashCode();
			}
			if (this.FLFKCIHCENF.Length != 0)
			{
				num ^= this.FLFKCIHCENF.GetHashCode();
			}
			if (this.KDCLOCAPBGE.Length != 0)
			{
				num ^= this.KDCLOCAPBGE.GetHashCode();
			}
			if (this.Version != 0UL)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00025412 File Offset: 0x00023612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0002541A File Offset: 0x0002361A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00025424 File Offset: 0x00023624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Uid);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.Nickname.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Nickname);
			}
			if (this.LMNDOGAFOGC != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.LMNDOGAFOGC);
			}
			if (this.Platform != PlatformType.Editor)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Platform);
			}
			if (this.FLFKCIHCENF.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.FLFKCIHCENF);
			}
			if (this.KDCLOCAPBGE.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.KDCLOCAPBGE);
			}
			if (this.Version != 0UL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00025534 File Offset: 0x00023734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Nickname.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Nickname);
			}
			if (this.LMNDOGAFOGC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LMNDOGAFOGC);
			}
			if (this.Platform != PlatformType.Editor)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Platform);
			}
			if (this.FLFKCIHCENF.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FLFKCIHCENF);
			}
			if (this.KDCLOCAPBGE.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.KDCLOCAPBGE);
			}
			if (this.Version != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0002562C File Offset: 0x0002382C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BCECCMOADLE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Nickname.Length != 0)
			{
				this.Nickname = other.Nickname;
			}
			if (other.LMNDOGAFOGC != 0U)
			{
				this.LMNDOGAFOGC = other.LMNDOGAFOGC;
			}
			if (other.Platform != PlatformType.Editor)
			{
				this.Platform = other.Platform;
			}
			if (other.FLFKCIHCENF.Length != 0)
			{
				this.FLFKCIHCENF = other.FLFKCIHCENF;
			}
			if (other.KDCLOCAPBGE.Length != 0)
			{
				this.KDCLOCAPBGE = other.KDCLOCAPBGE;
			}
			if (other.Version != 0UL)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00025703 File Offset: 0x00023903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0002570C File Offset: 0x0002390C
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
						if (num == 8U)
						{
							this.Uid = input.ReadUInt32();
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
						if (num == 26U)
						{
							this.Nickname = input.ReadString();
							continue;
						}
						if (num == 32U)
						{
							this.LMNDOGAFOGC = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.Platform = (PlatformType)input.ReadEnum();
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
					if (num == 58U)
					{
						this.KDCLOCAPBGE = input.ReadString();
						continue;
					}
					if (num == 64U)
					{
						this.Version = input.ReadUInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400055D RID: 1373
		private static readonly MessageParser<BCECCMOADLE> _parser = new MessageParser<BCECCMOADLE>(() => new BCECCMOADLE());

		// Token: 0x0400055E RID: 1374
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400055F RID: 1375
		public const int UidFieldNumber = 1;

		// Token: 0x04000560 RID: 1376
		private uint uid_;

		// Token: 0x04000561 RID: 1377
		public const int LevelFieldNumber = 2;

		// Token: 0x04000562 RID: 1378
		private uint level_;

		// Token: 0x04000563 RID: 1379
		public const int NicknameFieldNumber = 3;

		// Token: 0x04000564 RID: 1380
		private string nickname_ = "";

		// Token: 0x04000565 RID: 1381
		public const int LMNDOGAFOGCFieldNumber = 4;

		// Token: 0x04000566 RID: 1382
		private uint lMNDOGAFOGC_;

		// Token: 0x04000567 RID: 1383
		public const int PlatformFieldNumber = 5;

		// Token: 0x04000568 RID: 1384
		private PlatformType platform_;

		// Token: 0x04000569 RID: 1385
		public const int FLFKCIHCENFFieldNumber = 6;

		// Token: 0x0400056A RID: 1386
		private string fLFKCIHCENF_ = "";

		// Token: 0x0400056B RID: 1387
		public const int KDCLOCAPBGEFieldNumber = 7;

		// Token: 0x0400056C RID: 1388
		private string kDCLOCAPBGE_ = "";

		// Token: 0x0400056D RID: 1389
		public const int VersionFieldNumber = 8;

		// Token: 0x0400056E RID: 1390
		private ulong version_;
	}
}
