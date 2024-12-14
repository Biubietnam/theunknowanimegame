using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DBD RID: 3517
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReplayInfo : IMessage<ReplayInfo>, IMessage, IEquatable<ReplayInfo>, IDeepCloneable<ReplayInfo>, IBufferMessage
	{
		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x06009D46 RID: 40262 RVA: 0x001A2FC9 File Offset: 0x001A11C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReplayInfo> Parser
		{
			get
			{
				return ReplayInfo._parser;
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x06009D47 RID: 40263 RVA: 0x001A2FD0 File Offset: 0x001A11D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReplayInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x06009D48 RID: 40264 RVA: 0x001A2FE2 File Offset: 0x001A11E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReplayInfo.Descriptor;
			}
		}

		// Token: 0x06009D49 RID: 40265 RVA: 0x001A2FE9 File Offset: 0x001A11E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplayInfo()
		{
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x001A3008 File Offset: 0x001A1208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplayInfo(ReplayInfo other) : this()
		{
			this.iAJEDIFPEIK_ = other.iAJEDIFPEIK_;
			this.replayType_ = other.replayType_;
			this.stageId_ = other.stageId_;
			this.uid_ = other.uid_;
			this.nickname_ = other.nickname_;
			this.headIcon_ = other.headIcon_;
			this.replayName_ = other.replayName_;
			this.createTime_ = other.createTime_;
			this.lDEABGLLEEK_ = other.lDEABGLLEEK_;
			this.eHOAOABENLA_ = other.eHOAOABENLA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D4B RID: 40267 RVA: 0x001A30A4 File Offset: 0x001A12A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplayInfo Clone()
		{
			return new ReplayInfo(this);
		}

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x06009D4C RID: 40268 RVA: 0x001A30AC File Offset: 0x001A12AC
		// (set) Token: 0x06009D4D RID: 40269 RVA: 0x001A30B4 File Offset: 0x001A12B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong IAJEDIFPEIK
		{
			get
			{
				return this.iAJEDIFPEIK_;
			}
			set
			{
				this.iAJEDIFPEIK_ = value;
			}
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x06009D4E RID: 40270 RVA: 0x001A30BD File Offset: 0x001A12BD
		// (set) Token: 0x06009D4F RID: 40271 RVA: 0x001A30C5 File Offset: 0x001A12C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplayType ReplayType
		{
			get
			{
				return this.replayType_;
			}
			set
			{
				this.replayType_ = value;
			}
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x06009D50 RID: 40272 RVA: 0x001A30CE File Offset: 0x001A12CE
		// (set) Token: 0x06009D51 RID: 40273 RVA: 0x001A30D6 File Offset: 0x001A12D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x06009D52 RID: 40274 RVA: 0x001A30DF File Offset: 0x001A12DF
		// (set) Token: 0x06009D53 RID: 40275 RVA: 0x001A30E7 File Offset: 0x001A12E7
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

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x06009D54 RID: 40276 RVA: 0x001A30F0 File Offset: 0x001A12F0
		// (set) Token: 0x06009D55 RID: 40277 RVA: 0x001A30F8 File Offset: 0x001A12F8
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

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x06009D56 RID: 40278 RVA: 0x001A310B File Offset: 0x001A130B
		// (set) Token: 0x06009D57 RID: 40279 RVA: 0x001A3113 File Offset: 0x001A1313
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

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x06009D58 RID: 40280 RVA: 0x001A311C File Offset: 0x001A131C
		// (set) Token: 0x06009D59 RID: 40281 RVA: 0x001A3124 File Offset: 0x001A1324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ReplayName
		{
			get
			{
				return this.replayName_;
			}
			set
			{
				this.replayName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x06009D5A RID: 40282 RVA: 0x001A3137 File Offset: 0x001A1337
		// (set) Token: 0x06009D5B RID: 40283 RVA: 0x001A313F File Offset: 0x001A133F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong CreateTime
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

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x06009D5C RID: 40284 RVA: 0x001A3148 File Offset: 0x001A1348
		// (set) Token: 0x06009D5D RID: 40285 RVA: 0x001A3150 File Offset: 0x001A1350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LDEABGLLEEK
		{
			get
			{
				return this.lDEABGLLEEK_;
			}
			set
			{
				this.lDEABGLLEEK_ = value;
			}
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x06009D5E RID: 40286 RVA: 0x001A3159 File Offset: 0x001A1359
		// (set) Token: 0x06009D5F RID: 40287 RVA: 0x001A3161 File Offset: 0x001A1361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EHOAOABENLA
		{
			get
			{
				return this.eHOAOABENLA_;
			}
			set
			{
				this.eHOAOABENLA_ = value;
			}
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x001A316A File Offset: 0x001A136A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReplayInfo);
		}

		// Token: 0x06009D61 RID: 40289 RVA: 0x001A3178 File Offset: 0x001A1378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReplayInfo other)
		{
			return other != null && (other == this || (this.IAJEDIFPEIK == other.IAJEDIFPEIK && this.ReplayType == other.ReplayType && this.StageId == other.StageId && this.Uid == other.Uid && !(this.Nickname != other.Nickname) && this.HeadIcon == other.HeadIcon && !(this.ReplayName != other.ReplayName) && this.CreateTime == other.CreateTime && this.LDEABGLLEEK == other.LDEABGLLEEK && this.EHOAOABENLA == other.EHOAOABENLA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D62 RID: 40290 RVA: 0x001A324C File Offset: 0x001A144C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IAJEDIFPEIK != 0UL)
			{
				num ^= this.IAJEDIFPEIK.GetHashCode();
			}
			if (this.ReplayType != ReplayType.None)
			{
				num ^= this.ReplayType.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.Nickname.Length != 0)
			{
				num ^= this.Nickname.GetHashCode();
			}
			if (this.HeadIcon != 0U)
			{
				num ^= this.HeadIcon.GetHashCode();
			}
			if (this.ReplayName.Length != 0)
			{
				num ^= this.ReplayName.GetHashCode();
			}
			if (this.CreateTime != 0UL)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this.LDEABGLLEEK != 0U)
			{
				num ^= this.LDEABGLLEEK.GetHashCode();
			}
			if (this.EHOAOABENLA != 0U)
			{
				num ^= this.EHOAOABENLA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D63 RID: 40291 RVA: 0x001A3376 File Offset: 0x001A1576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D64 RID: 40292 RVA: 0x001A337E File Offset: 0x001A157E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D65 RID: 40293 RVA: 0x001A3388 File Offset: 0x001A1588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IAJEDIFPEIK != 0UL)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.IAJEDIFPEIK);
			}
			if (this.ReplayType != ReplayType.None)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ReplayType);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.StageId);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Uid);
			}
			if (this.Nickname.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Nickname);
			}
			if (this.HeadIcon != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.HeadIcon);
			}
			if (this.ReplayName.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.ReplayName);
			}
			if (this.CreateTime != 0UL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.CreateTime);
			}
			if (this.LDEABGLLEEK != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.LDEABGLLEEK);
			}
			if (this.EHOAOABENLA != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.EHOAOABENLA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D66 RID: 40294 RVA: 0x001A34CC File Offset: 0x001A16CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IAJEDIFPEIK != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.IAJEDIFPEIK);
			}
			if (this.ReplayType != ReplayType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ReplayType);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.Nickname.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Nickname);
			}
			if (this.HeadIcon != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HeadIcon);
			}
			if (this.ReplayName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReplayName);
			}
			if (this.CreateTime != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreateTime);
			}
			if (this.LDEABGLLEEK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LDEABGLLEEK);
			}
			if (this.EHOAOABENLA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EHOAOABENLA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D67 RID: 40295 RVA: 0x001A35EC File Offset: 0x001A17EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReplayInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IAJEDIFPEIK != 0UL)
			{
				this.IAJEDIFPEIK = other.IAJEDIFPEIK;
			}
			if (other.ReplayType != ReplayType.None)
			{
				this.ReplayType = other.ReplayType;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.Nickname.Length != 0)
			{
				this.Nickname = other.Nickname;
			}
			if (other.HeadIcon != 0U)
			{
				this.HeadIcon = other.HeadIcon;
			}
			if (other.ReplayName.Length != 0)
			{
				this.ReplayName = other.ReplayName;
			}
			if (other.CreateTime != 0UL)
			{
				this.CreateTime = other.CreateTime;
			}
			if (other.LDEABGLLEEK != 0U)
			{
				this.LDEABGLLEEK = other.LDEABGLLEEK;
			}
			if (other.EHOAOABENLA != 0U)
			{
				this.EHOAOABENLA = other.EHOAOABENLA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x001A36E6 File Offset: 0x001A18E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x001A36F0 File Offset: 0x001A18F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.IAJEDIFPEIK = input.ReadUInt64();
							continue;
						}
						if (num == 16U)
						{
							this.ReplayType = (ReplayType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.StageId = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.Uid = input.ReadUInt32();
							continue;
						}
						if (num == 42U)
						{
							this.Nickname = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 48U)
					{
						this.HeadIcon = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						this.ReplayName = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.CreateTime = input.ReadUInt64();
						continue;
					}
					if (num == 72U)
					{
						this.LDEABGLLEEK = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.EHOAOABENLA = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D24 RID: 15652
		private static readonly MessageParser<ReplayInfo> _parser = new MessageParser<ReplayInfo>(() => new ReplayInfo());

		// Token: 0x04003D25 RID: 15653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D26 RID: 15654
		public const int IAJEDIFPEIKFieldNumber = 1;

		// Token: 0x04003D27 RID: 15655
		private ulong iAJEDIFPEIK_;

		// Token: 0x04003D28 RID: 15656
		public const int ReplayTypeFieldNumber = 2;

		// Token: 0x04003D29 RID: 15657
		private ReplayType replayType_;

		// Token: 0x04003D2A RID: 15658
		public const int StageIdFieldNumber = 3;

		// Token: 0x04003D2B RID: 15659
		private uint stageId_;

		// Token: 0x04003D2C RID: 15660
		public const int UidFieldNumber = 4;

		// Token: 0x04003D2D RID: 15661
		private uint uid_;

		// Token: 0x04003D2E RID: 15662
		public const int NicknameFieldNumber = 5;

		// Token: 0x04003D2F RID: 15663
		private string nickname_ = "";

		// Token: 0x04003D30 RID: 15664
		public const int HeadIconFieldNumber = 6;

		// Token: 0x04003D31 RID: 15665
		private uint headIcon_;

		// Token: 0x04003D32 RID: 15666
		public const int ReplayNameFieldNumber = 7;

		// Token: 0x04003D33 RID: 15667
		private string replayName_ = "";

		// Token: 0x04003D34 RID: 15668
		public const int CreateTimeFieldNumber = 8;

		// Token: 0x04003D35 RID: 15669
		private ulong createTime_;

		// Token: 0x04003D36 RID: 15670
		public const int LDEABGLLEEKFieldNumber = 9;

		// Token: 0x04003D37 RID: 15671
		private uint lDEABGLLEEK_;

		// Token: 0x04003D38 RID: 15672
		public const int EHOAOABENLAFieldNumber = 10;

		// Token: 0x04003D39 RID: 15673
		private uint eHOAOABENLA_;
	}
}
