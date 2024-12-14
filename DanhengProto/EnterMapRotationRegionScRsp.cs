using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000451 RID: 1105
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterMapRotationRegionScRsp : IMessage<EnterMapRotationRegionScRsp>, IMessage, IEquatable<EnterMapRotationRegionScRsp>, IDeepCloneable<EnterMapRotationRegionScRsp>, IBufferMessage
	{
		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x0008717F File Offset: 0x0008537F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterMapRotationRegionScRsp> Parser
		{
			get
			{
				return EnterMapRotationRegionScRsp._parser;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06003125 RID: 12581 RVA: 0x00087186 File Offset: 0x00085386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterMapRotationRegionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x00087198 File Offset: 0x00085398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterMapRotationRegionScRsp.Descriptor;
			}
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x0008719F File Offset: 0x0008539F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMapRotationRegionScRsp()
		{
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x000871A8 File Offset: 0x000853A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMapRotationRegionScRsp(EnterMapRotationRegionScRsp other) : this()
		{
			this.cHJMODIMLDA_ = other.cHJMODIMLDA_;
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
			this.iPFOFHHKJKP_ = other.iPFOFHHKJKP_;
			this.clientPosVersion_ = other.clientPosVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x00087234 File Offset: 0x00085434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMapRotationRegionScRsp Clone()
		{
			return new EnterMapRotationRegionScRsp(this);
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x0008723C File Offset: 0x0008543C
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x00087244 File Offset: 0x00085444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CHJMODIMLDA
		{
			get
			{
				return this.cHJMODIMLDA_;
			}
			set
			{
				this.cHJMODIMLDA_ = value;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x0008724D File Offset: 0x0008544D
		// (set) Token: 0x0600312D RID: 12589 RVA: 0x00087255 File Offset: 0x00085455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x0008725E File Offset: 0x0008545E
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x00087266 File Offset: 0x00085466
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

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x0008726F File Offset: 0x0008546F
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x00087277 File Offset: 0x00085477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterEnergyInfo EnergyInfo
		{
			get
			{
				return this.energyInfo_;
			}
			set
			{
				this.energyInfo_ = value;
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x00087280 File Offset: 0x00085480
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x00087288 File Offset: 0x00085488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IPFOFHHKJKP
		{
			get
			{
				return this.iPFOFHHKJKP_;
			}
			set
			{
				this.iPFOFHHKJKP_ = value;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06003134 RID: 12596 RVA: 0x00087291 File Offset: 0x00085491
		// (set) Token: 0x06003135 RID: 12597 RVA: 0x00087299 File Offset: 0x00085499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ClientPosVersion
		{
			get
			{
				return this.clientPosVersion_;
			}
			set
			{
				this.clientPosVersion_ = value;
			}
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x000872A2 File Offset: 0x000854A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterMapRotationRegionScRsp);
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x000872B0 File Offset: 0x000854B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterMapRotationRegionScRsp other)
		{
			return other != null && (other == this || (this.CHJMODIMLDA == other.CHJMODIMLDA && object.Equals(this.Motion, other.Motion) && this.Retcode == other.Retcode && object.Equals(this.EnergyInfo, other.EnergyInfo) && this.IPFOFHHKJKP == other.IPFOFHHKJKP && this.ClientPosVersion == other.ClientPosVersion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x00087344 File Offset: 0x00085544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CHJMODIMLDA != 0U)
			{
				num ^= this.CHJMODIMLDA.GetHashCode();
			}
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.energyInfo_ != null)
			{
				num ^= this.EnergyInfo.GetHashCode();
			}
			if (this.IPFOFHHKJKP != 0U)
			{
				num ^= this.IPFOFHHKJKP.GetHashCode();
			}
			if (this.ClientPosVersion != 0U)
			{
				num ^= this.ClientPosVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x000873FA File Offset: 0x000855FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x00087402 File Offset: 0x00085602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x0008740C File Offset: 0x0008560C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motion_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Motion);
			}
			if (this.IPFOFHHKJKP != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.IPFOFHHKJKP);
			}
			if (this.energyInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.EnergyInfo);
			}
			if (this.ClientPosVersion != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ClientPosVersion);
			}
			if (this.CHJMODIMLDA != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.CHJMODIMLDA);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x000874D8 File Offset: 0x000856D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CHJMODIMLDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CHJMODIMLDA);
			}
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.energyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnergyInfo);
			}
			if (this.IPFOFHHKJKP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IPFOFHHKJKP);
			}
			if (this.ClientPosVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClientPosVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x00087590 File Offset: 0x00085790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterMapRotationRegionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CHJMODIMLDA != 0U)
			{
				this.CHJMODIMLDA = other.CHJMODIMLDA;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.energyInfo_ != null)
			{
				if (this.energyInfo_ == null)
				{
					this.EnergyInfo = new RotaterEnergyInfo();
				}
				this.EnergyInfo.MergeFrom(other.EnergyInfo);
			}
			if (other.IPFOFHHKJKP != 0U)
			{
				this.IPFOFHHKJKP = other.IPFOFHHKJKP;
			}
			if (other.ClientPosVersion != 0U)
			{
				this.ClientPosVersion = other.ClientPosVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x00087660 File Offset: 0x00085860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x0008766C File Offset: 0x0008586C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 18U)
					{
						if (this.motion_ == null)
						{
							this.Motion = new MotionInfo();
						}
						input.ReadMessage(this.Motion);
						continue;
					}
					if (num == 56U)
					{
						this.IPFOFHHKJKP = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
					{
						if (this.energyInfo_ == null)
						{
							this.EnergyInfo = new RotaterEnergyInfo();
						}
						input.ReadMessage(this.EnergyInfo);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ClientPosVersion = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.CHJMODIMLDA = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001391 RID: 5009
		private static readonly MessageParser<EnterMapRotationRegionScRsp> _parser = new MessageParser<EnterMapRotationRegionScRsp>(() => new EnterMapRotationRegionScRsp());

		// Token: 0x04001392 RID: 5010
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001393 RID: 5011
		public const int CHJMODIMLDAFieldNumber = 12;

		// Token: 0x04001394 RID: 5012
		private uint cHJMODIMLDA_;

		// Token: 0x04001395 RID: 5013
		public const int MotionFieldNumber = 2;

		// Token: 0x04001396 RID: 5014
		private MotionInfo motion_;

		// Token: 0x04001397 RID: 5015
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04001398 RID: 5016
		private uint retcode_;

		// Token: 0x04001399 RID: 5017
		public const int EnergyInfoFieldNumber = 9;

		// Token: 0x0400139A RID: 5018
		private RotaterEnergyInfo energyInfo_;

		// Token: 0x0400139B RID: 5019
		public const int IPFOFHHKJKPFieldNumber = 7;

		// Token: 0x0400139C RID: 5020
		private uint iPFOFHHKJKP_;

		// Token: 0x0400139D RID: 5021
		public const int ClientPosVersionFieldNumber = 11;

		// Token: 0x0400139E RID: 5022
		private uint clientPosVersion_;
	}
}
