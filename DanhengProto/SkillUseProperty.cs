using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001155 RID: 4437
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SkillUseProperty : IMessage<SkillUseProperty>, IMessage, IEquatable<SkillUseProperty>, IDeepCloneable<SkillUseProperty>, IBufferMessage
	{
		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x0600C5DF RID: 50655 RVA: 0x00213014 File Offset: 0x00211214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkillUseProperty> Parser
		{
			get
			{
				return SkillUseProperty._parser;
			}
		}

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0600C5E0 RID: 50656 RVA: 0x0021301B File Offset: 0x0021121B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SkillUsePropertyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0600C5E1 RID: 50657 RVA: 0x0021302D File Offset: 0x0021122D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillUseProperty.Descriptor;
			}
		}

		// Token: 0x0600C5E2 RID: 50658 RVA: 0x00213034 File Offset: 0x00211234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillUseProperty()
		{
		}

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x00213048 File Offset: 0x00211248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillUseProperty(SkillUseProperty other) : this()
		{
			this.skillId_ = other.skillId_;
			this.skillType_ = other.skillType_;
			this.skillLevel_ = other.skillLevel_;
			this.skillUseCount_ = other.skillUseCount_;
			this.eKCKCPEEOPM_ = other.eKCKCPEEOPM_;
			this.kHCMDHBLHFO_ = other.kHCMDHBLHFO_;
			this.mPHKEOMGHKD_ = other.mPHKEOMGHKD_;
			this.cHJCDMJNCED_ = other.cHJCDMJNCED_;
			this.eGEPPOIHFLG_ = other.eGEPPOIHFLG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5E4 RID: 50660 RVA: 0x002130D8 File Offset: 0x002112D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillUseProperty Clone()
		{
			return new SkillUseProperty(this);
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0600C5E5 RID: 50661 RVA: 0x002130E0 File Offset: 0x002112E0
		// (set) Token: 0x0600C5E6 RID: 50662 RVA: 0x002130E8 File Offset: 0x002112E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0600C5E7 RID: 50663 RVA: 0x002130F1 File Offset: 0x002112F1
		// (set) Token: 0x0600C5E8 RID: 50664 RVA: 0x002130F9 File Offset: 0x002112F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SkillType
		{
			get
			{
				return this.skillType_;
			}
			set
			{
				this.skillType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0600C5E9 RID: 50665 RVA: 0x0021310C File Offset: 0x0021130C
		// (set) Token: 0x0600C5EA RID: 50666 RVA: 0x00213114 File Offset: 0x00211314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillLevel
		{
			get
			{
				return this.skillLevel_;
			}
			set
			{
				this.skillLevel_ = value;
			}
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0600C5EB RID: 50667 RVA: 0x0021311D File Offset: 0x0021131D
		// (set) Token: 0x0600C5EC RID: 50668 RVA: 0x00213125 File Offset: 0x00211325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillUseCount
		{
			get
			{
				return this.skillUseCount_;
			}
			set
			{
				this.skillUseCount_ = value;
			}
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0600C5ED RID: 50669 RVA: 0x0021312E File Offset: 0x0021132E
		// (set) Token: 0x0600C5EE RID: 50670 RVA: 0x00213136 File Offset: 0x00211336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EKCKCPEEOPM
		{
			get
			{
				return this.eKCKCPEEOPM_;
			}
			set
			{
				this.eKCKCPEEOPM_ = value;
			}
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0600C5EF RID: 50671 RVA: 0x0021313F File Offset: 0x0021133F
		// (set) Token: 0x0600C5F0 RID: 50672 RVA: 0x00213147 File Offset: 0x00211347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KHCMDHBLHFO
		{
			get
			{
				return this.kHCMDHBLHFO_;
			}
			set
			{
				this.kHCMDHBLHFO_ = value;
			}
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0600C5F1 RID: 50673 RVA: 0x00213150 File Offset: 0x00211350
		// (set) Token: 0x0600C5F2 RID: 50674 RVA: 0x00213158 File Offset: 0x00211358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MPHKEOMGHKD
		{
			get
			{
				return this.mPHKEOMGHKD_;
			}
			set
			{
				this.mPHKEOMGHKD_ = value;
			}
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x00213161 File Offset: 0x00211361
		// (set) Token: 0x0600C5F4 RID: 50676 RVA: 0x00213169 File Offset: 0x00211369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CHJCDMJNCED
		{
			get
			{
				return this.cHJCDMJNCED_;
			}
			set
			{
				this.cHJCDMJNCED_ = value;
			}
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0600C5F5 RID: 50677 RVA: 0x00213172 File Offset: 0x00211372
		// (set) Token: 0x0600C5F6 RID: 50678 RVA: 0x0021317A File Offset: 0x0021137A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EGEPPOIHFLG
		{
			get
			{
				return this.eGEPPOIHFLG_;
			}
			set
			{
				this.eGEPPOIHFLG_ = value;
			}
		}

		// Token: 0x0600C5F7 RID: 50679 RVA: 0x00213183 File Offset: 0x00211383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillUseProperty);
		}

		// Token: 0x0600C5F8 RID: 50680 RVA: 0x00213194 File Offset: 0x00211394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillUseProperty other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && !(this.SkillType != other.SkillType) && this.SkillLevel == other.SkillLevel && this.SkillUseCount == other.SkillUseCount && this.EKCKCPEEOPM == other.EKCKCPEEOPM && this.KHCMDHBLHFO == other.KHCMDHBLHFO && this.MPHKEOMGHKD == other.MPHKEOMGHKD && this.CHJCDMJNCED == other.CHJCDMJNCED && this.EGEPPOIHFLG == other.EGEPPOIHFLG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5F9 RID: 50681 RVA: 0x00213254 File Offset: 0x00211454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.SkillType.Length != 0)
			{
				num ^= this.SkillType.GetHashCode();
			}
			if (this.SkillLevel != 0U)
			{
				num ^= this.SkillLevel.GetHashCode();
			}
			if (this.SkillUseCount != 0U)
			{
				num ^= this.SkillUseCount.GetHashCode();
			}
			if (this.EKCKCPEEOPM != 0U)
			{
				num ^= this.EKCKCPEEOPM.GetHashCode();
			}
			if (this.KHCMDHBLHFO != 0U)
			{
				num ^= this.KHCMDHBLHFO.GetHashCode();
			}
			if (this.MPHKEOMGHKD != 0U)
			{
				num ^= this.MPHKEOMGHKD.GetHashCode();
			}
			if (this.CHJCDMJNCED != 0U)
			{
				num ^= this.CHJCDMJNCED.GetHashCode();
			}
			if (this.EGEPPOIHFLG != 0U)
			{
				num ^= this.EGEPPOIHFLG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C5FA RID: 50682 RVA: 0x0021335D File Offset: 0x0021155D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C5FB RID: 50683 RVA: 0x00213365 File Offset: 0x00211565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5FC RID: 50684 RVA: 0x00213370 File Offset: 0x00211570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.SkillId);
			}
			if (this.SkillType.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.SkillType);
			}
			if (this.SkillLevel != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.SkillLevel);
			}
			if (this.SkillUseCount != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.SkillUseCount);
			}
			if (this.EKCKCPEEOPM != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.EKCKCPEEOPM);
			}
			if (this.KHCMDHBLHFO != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.KHCMDHBLHFO);
			}
			if (this.MPHKEOMGHKD != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MPHKEOMGHKD);
			}
			if (this.CHJCDMJNCED != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CHJCDMJNCED);
			}
			if (this.EGEPPOIHFLG != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.EGEPPOIHFLG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x00213494 File Offset: 0x00211694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
			}
			if (this.SkillType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SkillType);
			}
			if (this.SkillLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillLevel);
			}
			if (this.SkillUseCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillUseCount);
			}
			if (this.EKCKCPEEOPM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EKCKCPEEOPM);
			}
			if (this.KHCMDHBLHFO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KHCMDHBLHFO);
			}
			if (this.MPHKEOMGHKD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MPHKEOMGHKD);
			}
			if (this.CHJCDMJNCED != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CHJCDMJNCED);
			}
			if (this.EGEPPOIHFLG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EGEPPOIHFLG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C5FE RID: 50686 RVA: 0x00213598 File Offset: 0x00211798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillUseProperty other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			if (other.SkillType.Length != 0)
			{
				this.SkillType = other.SkillType;
			}
			if (other.SkillLevel != 0U)
			{
				this.SkillLevel = other.SkillLevel;
			}
			if (other.SkillUseCount != 0U)
			{
				this.SkillUseCount = other.SkillUseCount;
			}
			if (other.EKCKCPEEOPM != 0U)
			{
				this.EKCKCPEEOPM = other.EKCKCPEEOPM;
			}
			if (other.KHCMDHBLHFO != 0U)
			{
				this.KHCMDHBLHFO = other.KHCMDHBLHFO;
			}
			if (other.MPHKEOMGHKD != 0U)
			{
				this.MPHKEOMGHKD = other.MPHKEOMGHKD;
			}
			if (other.CHJCDMJNCED != 0U)
			{
				this.CHJCDMJNCED = other.CHJCDMJNCED;
			}
			if (other.EGEPPOIHFLG != 0U)
			{
				this.EGEPPOIHFLG = other.EGEPPOIHFLG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C5FF RID: 50687 RVA: 0x00213679 File Offset: 0x00211879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C600 RID: 50688 RVA: 0x00213684 File Offset: 0x00211884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.SkillId = input.ReadUInt32();
							continue;
						}
						if (num == 18U)
						{
							this.SkillType = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.SkillLevel = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.SkillUseCount = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.EKCKCPEEOPM = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.KHCMDHBLHFO = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.MPHKEOMGHKD = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.CHJCDMJNCED = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.EGEPPOIHFLG = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004FE9 RID: 20457
		private static readonly MessageParser<SkillUseProperty> _parser = new MessageParser<SkillUseProperty>(() => new SkillUseProperty());

		// Token: 0x04004FEA RID: 20458
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FEB RID: 20459
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04004FEC RID: 20460
		private uint skillId_;

		// Token: 0x04004FED RID: 20461
		public const int SkillTypeFieldNumber = 2;

		// Token: 0x04004FEE RID: 20462
		private string skillType_ = "";

		// Token: 0x04004FEF RID: 20463
		public const int SkillLevelFieldNumber = 3;

		// Token: 0x04004FF0 RID: 20464
		private uint skillLevel_;

		// Token: 0x04004FF1 RID: 20465
		public const int SkillUseCountFieldNumber = 4;

		// Token: 0x04004FF2 RID: 20466
		private uint skillUseCount_;

		// Token: 0x04004FF3 RID: 20467
		public const int EKCKCPEEOPMFieldNumber = 5;

		// Token: 0x04004FF4 RID: 20468
		private uint eKCKCPEEOPM_;

		// Token: 0x04004FF5 RID: 20469
		public const int KHCMDHBLHFOFieldNumber = 6;

		// Token: 0x04004FF6 RID: 20470
		private uint kHCMDHBLHFO_;

		// Token: 0x04004FF7 RID: 20471
		public const int MPHKEOMGHKDFieldNumber = 7;

		// Token: 0x04004FF8 RID: 20472
		private uint mPHKEOMGHKD_;

		// Token: 0x04004FF9 RID: 20473
		public const int CHJCDMJNCEDFieldNumber = 8;

		// Token: 0x04004FFA RID: 20474
		private uint cHJCDMJNCED_;

		// Token: 0x04004FFB RID: 20475
		public const int EGEPPOIHFLGFieldNumber = 9;

		// Token: 0x04004FFC RID: 20476
		private uint eGEPPOIHFLG_;
	}
}
