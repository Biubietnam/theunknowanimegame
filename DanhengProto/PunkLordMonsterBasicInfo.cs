using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D27 RID: 3367
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordMonsterBasicInfo : IMessage<PunkLordMonsterBasicInfo>, IMessage, IEquatable<PunkLordMonsterBasicInfo>, IDeepCloneable<PunkLordMonsterBasicInfo>, IBufferMessage
	{
		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x06009667 RID: 38503 RVA: 0x0019017C File Offset: 0x0018E37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordMonsterBasicInfo> Parser
		{
			get
			{
				return PunkLordMonsterBasicInfo._parser;
			}
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x06009668 RID: 38504 RVA: 0x00190183 File Offset: 0x0018E383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordMonsterBasicInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x06009669 RID: 38505 RVA: 0x00190195 File Offset: 0x0018E395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordMonsterBasicInfo.Descriptor;
			}
		}

		// Token: 0x0600966A RID: 38506 RVA: 0x0019019C File Offset: 0x0018E39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterBasicInfo()
		{
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x001901A4 File Offset: 0x0018E3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterBasicInfo(PunkLordMonsterBasicInfo other) : this()
		{
			this.uid_ = other.uid_;
			this.monsterId_ = other.monsterId_;
			this.configId_ = other.configId_;
			this.worldLevel_ = other.worldLevel_;
			this.createTime_ = other.createTime_;
			this.leftHp_ = other.leftHp_;
			this.attackerNum_ = other.attackerNum_;
			this.shareType_ = other.shareType_;
			this.mMBAOCGFBLI_ = other.mMBAOCGFBLI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x00190234 File Offset: 0x0018E434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterBasicInfo Clone()
		{
			return new PunkLordMonsterBasicInfo(this);
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x0600966D RID: 38509 RVA: 0x0019023C File Offset: 0x0018E43C
		// (set) Token: 0x0600966E RID: 38510 RVA: 0x00190244 File Offset: 0x0018E444
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

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x0600966F RID: 38511 RVA: 0x0019024D File Offset: 0x0018E44D
		// (set) Token: 0x06009670 RID: 38512 RVA: 0x00190255 File Offset: 0x0018E455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x06009671 RID: 38513 RVA: 0x0019025E File Offset: 0x0018E45E
		// (set) Token: 0x06009672 RID: 38514 RVA: 0x00190266 File Offset: 0x0018E466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x06009673 RID: 38515 RVA: 0x0019026F File Offset: 0x0018E46F
		// (set) Token: 0x06009674 RID: 38516 RVA: 0x00190277 File Offset: 0x0018E477
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

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x06009675 RID: 38517 RVA: 0x00190280 File Offset: 0x0018E480
		// (set) Token: 0x06009676 RID: 38518 RVA: 0x00190288 File Offset: 0x0018E488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreateTime
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

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x06009677 RID: 38519 RVA: 0x00190291 File Offset: 0x0018E491
		// (set) Token: 0x06009678 RID: 38520 RVA: 0x00190299 File Offset: 0x0018E499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LeftHp
		{
			get
			{
				return this.leftHp_;
			}
			set
			{
				this.leftHp_ = value;
			}
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x06009679 RID: 38521 RVA: 0x001902A2 File Offset: 0x0018E4A2
		// (set) Token: 0x0600967A RID: 38522 RVA: 0x001902AA File Offset: 0x0018E4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AttackerNum
		{
			get
			{
				return this.attackerNum_;
			}
			set
			{
				this.attackerNum_ = value;
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x0600967B RID: 38523 RVA: 0x001902B3 File Offset: 0x0018E4B3
		// (set) Token: 0x0600967C RID: 38524 RVA: 0x001902BB File Offset: 0x0018E4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordShareType ShareType
		{
			get
			{
				return this.shareType_;
			}
			set
			{
				this.shareType_ = value;
			}
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x0600967D RID: 38525 RVA: 0x001902C4 File Offset: 0x0018E4C4
		// (set) Token: 0x0600967E RID: 38526 RVA: 0x001902CC File Offset: 0x0018E4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MMBAOCGFBLI
		{
			get
			{
				return this.mMBAOCGFBLI_;
			}
			set
			{
				this.mMBAOCGFBLI_ = value;
			}
		}

		// Token: 0x0600967F RID: 38527 RVA: 0x001902D5 File Offset: 0x0018E4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordMonsterBasicInfo);
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x001902E4 File Offset: 0x0018E4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordMonsterBasicInfo other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.MonsterId == other.MonsterId && this.ConfigId == other.ConfigId && this.WorldLevel == other.WorldLevel && this.CreateTime == other.CreateTime && this.LeftHp == other.LeftHp && this.AttackerNum == other.AttackerNum && this.ShareType == other.ShareType && this.MMBAOCGFBLI == other.MMBAOCGFBLI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x001903A0 File Offset: 0x0018E5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.ConfigId != 0U)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.CreateTime != 0L)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this.LeftHp != 0U)
			{
				num ^= this.LeftHp.GetHashCode();
			}
			if (this.AttackerNum != 0U)
			{
				num ^= this.AttackerNum.GetHashCode();
			}
			if (this.ShareType != PunkLordShareType.None)
			{
				num ^= this.ShareType.GetHashCode();
			}
			if (this.MMBAOCGFBLI)
			{
				num ^= this.MMBAOCGFBLI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009682 RID: 38530 RVA: 0x001904AE File Offset: 0x0018E6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009683 RID: 38531 RVA: 0x001904B6 File Offset: 0x0018E6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x001904C0 File Offset: 0x0018E6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Uid);
			}
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MonsterId);
			}
			if (this.ConfigId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ConfigId);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.CreateTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.CreateTime);
			}
			if (this.LeftHp != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.LeftHp);
			}
			if (this.AttackerNum != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AttackerNum);
			}
			if (this.ShareType != PunkLordShareType.None)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ShareType);
			}
			if (this.MMBAOCGFBLI)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.MMBAOCGFBLI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009685 RID: 38533 RVA: 0x001905DC File Offset: 0x0018E7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this.ConfigId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConfigId);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.CreateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreateTime);
			}
			if (this.LeftHp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LeftHp);
			}
			if (this.AttackerNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AttackerNum);
			}
			if (this.ShareType != PunkLordShareType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ShareType);
			}
			if (this.MMBAOCGFBLI)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009686 RID: 38534 RVA: 0x001906D0 File Offset: 0x0018E8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordMonsterBasicInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.ConfigId != 0U)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.CreateTime != 0L)
			{
				this.CreateTime = other.CreateTime;
			}
			if (other.LeftHp != 0U)
			{
				this.LeftHp = other.LeftHp;
			}
			if (other.AttackerNum != 0U)
			{
				this.AttackerNum = other.AttackerNum;
			}
			if (other.ShareType != PunkLordShareType.None)
			{
				this.ShareType = other.ShareType;
			}
			if (other.MMBAOCGFBLI)
			{
				this.MMBAOCGFBLI = other.MMBAOCGFBLI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009687 RID: 38535 RVA: 0x001907AC File Offset: 0x0018E9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x001907B8 File Offset: 0x0018E9B8
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
							this.MonsterId = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.ConfigId = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.WorldLevel = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.CreateTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.LeftHp = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.AttackerNum = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ShareType = (PunkLordShareType)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.MMBAOCGFBLI = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A54 RID: 14932
		private static readonly MessageParser<PunkLordMonsterBasicInfo> _parser = new MessageParser<PunkLordMonsterBasicInfo>(() => new PunkLordMonsterBasicInfo());

		// Token: 0x04003A55 RID: 14933
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A56 RID: 14934
		public const int UidFieldNumber = 1;

		// Token: 0x04003A57 RID: 14935
		private uint uid_;

		// Token: 0x04003A58 RID: 14936
		public const int MonsterIdFieldNumber = 2;

		// Token: 0x04003A59 RID: 14937
		private uint monsterId_;

		// Token: 0x04003A5A RID: 14938
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x04003A5B RID: 14939
		private uint configId_;

		// Token: 0x04003A5C RID: 14940
		public const int WorldLevelFieldNumber = 4;

		// Token: 0x04003A5D RID: 14941
		private uint worldLevel_;

		// Token: 0x04003A5E RID: 14942
		public const int CreateTimeFieldNumber = 5;

		// Token: 0x04003A5F RID: 14943
		private long createTime_;

		// Token: 0x04003A60 RID: 14944
		public const int LeftHpFieldNumber = 6;

		// Token: 0x04003A61 RID: 14945
		private uint leftHp_;

		// Token: 0x04003A62 RID: 14946
		public const int AttackerNumFieldNumber = 7;

		// Token: 0x04003A63 RID: 14947
		private uint attackerNum_;

		// Token: 0x04003A64 RID: 14948
		public const int ShareTypeFieldNumber = 8;

		// Token: 0x04003A65 RID: 14949
		private PunkLordShareType shareType_;

		// Token: 0x04003A66 RID: 14950
		public const int MMBAOCGFBLIFieldNumber = 9;

		// Token: 0x04003A67 RID: 14951
		private bool mMBAOCGFBLI_;
	}
}
