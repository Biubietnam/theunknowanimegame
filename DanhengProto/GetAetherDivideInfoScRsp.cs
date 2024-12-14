using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000601 RID: 1537
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAetherDivideInfoScRsp : IMessage<GetAetherDivideInfoScRsp>, IMessage, IEquatable<GetAetherDivideInfoScRsp>, IDeepCloneable<GetAetherDivideInfoScRsp>, IBufferMessage
	{
		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x000BCD9A File Offset: 0x000BAF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAetherDivideInfoScRsp> Parser
		{
			get
			{
				return GetAetherDivideInfoScRsp._parser;
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x000BCDA1 File Offset: 0x000BAFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAetherDivideInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x000BCDB3 File Offset: 0x000BAFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAetherDivideInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x000BCDBA File Offset: 0x000BAFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideInfoScRsp()
		{
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x000BCDE4 File Offset: 0x000BAFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideInfoScRsp(GetAetherDivideInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.oICGLINCBBJ_ = other.oICGLINCBBJ_;
			this.nPGOMLFGBJM_ = other.nPGOMLFGBJM_;
			this.gOOHJJJOMEJ_ = other.gOOHJJJOMEJ_;
			this.pHPCDGEMAGD_ = other.pHPCDGEMAGD_;
			this.aetherSkillList_ = other.aetherSkillList_.Clone();
			this.bDIGKFPHLHK_ = other.bDIGKFPHLHK_;
			this.lineupList_ = other.lineupList_.Clone();
			this.avatarList_ = other.avatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x000BCE83 File Offset: 0x000BB083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideInfoScRsp Clone()
		{
			return new GetAetherDivideInfoScRsp(this);
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x000BCE8B File Offset: 0x000BB08B
		// (set) Token: 0x060044EC RID: 17644 RVA: 0x000BCE93 File Offset: 0x000BB093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x060044ED RID: 17645 RVA: 0x000BCE9C File Offset: 0x000BB09C
		// (set) Token: 0x060044EE RID: 17646 RVA: 0x000BCEA4 File Offset: 0x000BB0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OICGLINCBBJ
		{
			get
			{
				return this.oICGLINCBBJ_;
			}
			set
			{
				this.oICGLINCBBJ_ = value;
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x060044EF RID: 17647 RVA: 0x000BCEAD File Offset: 0x000BB0AD
		// (set) Token: 0x060044F0 RID: 17648 RVA: 0x000BCEB5 File Offset: 0x000BB0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NPGOMLFGBJM
		{
			get
			{
				return this.nPGOMLFGBJM_;
			}
			set
			{
				this.nPGOMLFGBJM_ = value;
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x060044F1 RID: 17649 RVA: 0x000BCEBE File Offset: 0x000BB0BE
		// (set) Token: 0x060044F2 RID: 17650 RVA: 0x000BCEC6 File Offset: 0x000BB0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GOOHJJJOMEJ
		{
			get
			{
				return this.gOOHJJJOMEJ_;
			}
			set
			{
				this.gOOHJJJOMEJ_ = value;
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x000BCECF File Offset: 0x000BB0CF
		// (set) Token: 0x060044F4 RID: 17652 RVA: 0x000BCED7 File Offset: 0x000BB0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHPCDGEMAGD
		{
			get
			{
				return this.pHPCDGEMAGD_;
			}
			set
			{
				this.pHPCDGEMAGD_ = value;
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x000BCEE0 File Offset: 0x000BB0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AetherSkillInfo> AetherSkillList
		{
			get
			{
				return this.aetherSkillList_;
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x000BCEE8 File Offset: 0x000BB0E8
		// (set) Token: 0x060044F7 RID: 17655 RVA: 0x000BCEF0 File Offset: 0x000BB0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BDIGKFPHLHK
		{
			get
			{
				return this.bDIGKFPHLHK_;
			}
			set
			{
				this.bDIGKFPHLHK_ = value;
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x000BCEF9 File Offset: 0x000BB0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AetherDivideLineupInfo> LineupList
		{
			get
			{
				return this.lineupList_;
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x060044F9 RID: 17657 RVA: 0x000BCF01 File Offset: 0x000BB101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AetherDivideSpiritInfo> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x000BCF09 File Offset: 0x000BB109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAetherDivideInfoScRsp);
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x000BCF18 File Offset: 0x000BB118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAetherDivideInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.OICGLINCBBJ == other.OICGLINCBBJ && this.NPGOMLFGBJM == other.NPGOMLFGBJM && this.GOOHJJJOMEJ == other.GOOHJJJOMEJ && this.PHPCDGEMAGD == other.PHPCDGEMAGD && this.aetherSkillList_.Equals(other.aetherSkillList_) && this.BDIGKFPHLHK == other.BDIGKFPHLHK && this.lineupList_.Equals(other.lineupList_) && this.avatarList_.Equals(other.avatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x000BCFE0 File Offset: 0x000BB1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.OICGLINCBBJ != 0U)
			{
				num ^= this.OICGLINCBBJ.GetHashCode();
			}
			if (this.NPGOMLFGBJM != 0U)
			{
				num ^= this.NPGOMLFGBJM.GetHashCode();
			}
			if (this.GOOHJJJOMEJ != 0U)
			{
				num ^= this.GOOHJJJOMEJ.GetHashCode();
			}
			if (this.PHPCDGEMAGD != 0U)
			{
				num ^= this.PHPCDGEMAGD.GetHashCode();
			}
			num ^= this.aetherSkillList_.GetHashCode();
			if (this.BDIGKFPHLHK != 0U)
			{
				num ^= this.BDIGKFPHLHK.GetHashCode();
			}
			num ^= this.lineupList_.GetHashCode();
			num ^= this.avatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x000BD0C6 File Offset: 0x000BB2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x000BD0CE File Offset: 0x000BB2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x000BD0D8 File Offset: 0x000BB2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GOOHJJJOMEJ != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GOOHJJJOMEJ);
			}
			if (this.OICGLINCBBJ != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.OICGLINCBBJ);
			}
			if (this.PHPCDGEMAGD != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PHPCDGEMAGD);
			}
			if (this.NPGOMLFGBJM != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.NPGOMLFGBJM);
			}
			this.aetherSkillList_.WriteTo(ref output, GetAetherDivideInfoScRsp._repeated_aetherSkillList_codec);
			this.lineupList_.WriteTo(ref output, GetAetherDivideInfoScRsp._repeated_lineupList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			this.avatarList_.WriteTo(ref output, GetAetherDivideInfoScRsp._repeated_avatarList_codec);
			if (this.BDIGKFPHLHK != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.BDIGKFPHLHK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x000BD1D4 File Offset: 0x000BB3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.OICGLINCBBJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OICGLINCBBJ);
			}
			if (this.NPGOMLFGBJM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NPGOMLFGBJM);
			}
			if (this.GOOHJJJOMEJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GOOHJJJOMEJ);
			}
			if (this.PHPCDGEMAGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHPCDGEMAGD);
			}
			num += this.aetherSkillList_.CalculateSize(GetAetherDivideInfoScRsp._repeated_aetherSkillList_codec);
			if (this.BDIGKFPHLHK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BDIGKFPHLHK);
			}
			num += this.lineupList_.CalculateSize(GetAetherDivideInfoScRsp._repeated_lineupList_codec);
			num += this.avatarList_.CalculateSize(GetAetherDivideInfoScRsp._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x000BD2C4 File Offset: 0x000BB4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAetherDivideInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.OICGLINCBBJ != 0U)
			{
				this.OICGLINCBBJ = other.OICGLINCBBJ;
			}
			if (other.NPGOMLFGBJM != 0U)
			{
				this.NPGOMLFGBJM = other.NPGOMLFGBJM;
			}
			if (other.GOOHJJJOMEJ != 0U)
			{
				this.GOOHJJJOMEJ = other.GOOHJJJOMEJ;
			}
			if (other.PHPCDGEMAGD != 0U)
			{
				this.PHPCDGEMAGD = other.PHPCDGEMAGD;
			}
			this.aetherSkillList_.Add(other.aetherSkillList_);
			if (other.BDIGKFPHLHK != 0U)
			{
				this.BDIGKFPHLHK = other.BDIGKFPHLHK;
			}
			this.lineupList_.Add(other.lineupList_);
			this.avatarList_.Add(other.avatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x000BD397 File Offset: 0x000BB597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x000BD3A0 File Offset: 0x000BB5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 32U)
					{
						if (num == 8U)
						{
							this.GOOHJJJOMEJ = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.OICGLINCBBJ = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.PHPCDGEMAGD = input.ReadUInt32();
							continue;
						}
						if (num == 56U)
						{
							this.NPGOMLFGBJM = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 82U)
					{
						this.aetherSkillList_.AddEntriesFrom(ref input, GetAetherDivideInfoScRsp._repeated_aetherSkillList_codec);
						continue;
					}
					if (num == 90U)
					{
						this.lineupList_.AddEntriesFrom(ref input, GetAetherDivideInfoScRsp._repeated_lineupList_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						this.avatarList_.AddEntriesFrom(ref input, GetAetherDivideInfoScRsp._repeated_avatarList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.BDIGKFPHLHK = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B8C RID: 7052
		private static readonly MessageParser<GetAetherDivideInfoScRsp> _parser = new MessageParser<GetAetherDivideInfoScRsp>(() => new GetAetherDivideInfoScRsp());

		// Token: 0x04001B8D RID: 7053
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B8E RID: 7054
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04001B8F RID: 7055
		private uint retcode_;

		// Token: 0x04001B90 RID: 7056
		public const int OICGLINCBBJFieldNumber = 4;

		// Token: 0x04001B91 RID: 7057
		private uint oICGLINCBBJ_;

		// Token: 0x04001B92 RID: 7058
		public const int NPGOMLFGBJMFieldNumber = 7;

		// Token: 0x04001B93 RID: 7059
		private uint nPGOMLFGBJM_;

		// Token: 0x04001B94 RID: 7060
		public const int GOOHJJJOMEJFieldNumber = 1;

		// Token: 0x04001B95 RID: 7061
		private uint gOOHJJJOMEJ_;

		// Token: 0x04001B96 RID: 7062
		public const int PHPCDGEMAGDFieldNumber = 6;

		// Token: 0x04001B97 RID: 7063
		private uint pHPCDGEMAGD_;

		// Token: 0x04001B98 RID: 7064
		public const int AetherSkillListFieldNumber = 10;

		// Token: 0x04001B99 RID: 7065
		private static readonly FieldCodec<AetherSkillInfo> _repeated_aetherSkillList_codec = FieldCodec.ForMessage<AetherSkillInfo>(82U, AetherSkillInfo.Parser);

		// Token: 0x04001B9A RID: 7066
		private readonly RepeatedField<AetherSkillInfo> aetherSkillList_ = new RepeatedField<AetherSkillInfo>();

		// Token: 0x04001B9B RID: 7067
		public const int BDIGKFPHLHKFieldNumber = 15;

		// Token: 0x04001B9C RID: 7068
		private uint bDIGKFPHLHK_;

		// Token: 0x04001B9D RID: 7069
		public const int LineupListFieldNumber = 11;

		// Token: 0x04001B9E RID: 7070
		private static readonly FieldCodec<AetherDivideLineupInfo> _repeated_lineupList_codec = FieldCodec.ForMessage<AetherDivideLineupInfo>(90U, AetherDivideLineupInfo.Parser);

		// Token: 0x04001B9F RID: 7071
		private readonly RepeatedField<AetherDivideLineupInfo> lineupList_ = new RepeatedField<AetherDivideLineupInfo>();

		// Token: 0x04001BA0 RID: 7072
		public const int AvatarListFieldNumber = 13;

		// Token: 0x04001BA1 RID: 7073
		private static readonly FieldCodec<AetherDivideSpiritInfo> _repeated_avatarList_codec = FieldCodec.ForMessage<AetherDivideSpiritInfo>(106U, AetherDivideSpiritInfo.Parser);

		// Token: 0x04001BA2 RID: 7074
		private readonly RepeatedField<AetherDivideSpiritInfo> avatarList_ = new RepeatedField<AetherDivideSpiritInfo>();
	}
}
