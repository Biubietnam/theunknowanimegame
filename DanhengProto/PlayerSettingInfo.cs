using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CE5 RID: 3301
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerSettingInfo : IMessage<PlayerSettingInfo>, IMessage, IEquatable<PlayerSettingInfo>, IDeepCloneable<PlayerSettingInfo>, IBufferMessage
	{
		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x0600933F RID: 37695 RVA: 0x00186588 File Offset: 0x00184788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSettingInfo> Parser
		{
			get
			{
				return PlayerSettingInfo._parser;
			}
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x06009340 RID: 37696 RVA: 0x0018658F File Offset: 0x0018478F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerSettingInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x06009341 RID: 37697 RVA: 0x001865A1 File Offset: 0x001847A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSettingInfo.Descriptor;
			}
		}

		// Token: 0x06009342 RID: 37698 RVA: 0x001865A8 File Offset: 0x001847A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSettingInfo()
		{
		}

		// Token: 0x06009343 RID: 37699 RVA: 0x001865B0 File Offset: 0x001847B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSettingInfo(PlayerSettingInfo other) : this()
		{
			this.jMBAGBFIKCM_ = other.jMBAGBFIKCM_;
			this.aNEAAKIDPFL_ = other.aNEAAKIDPFL_;
			this.cGADMDEKIAC_ = other.cGADMDEKIAC_;
			this.gNOHNPJBFJC_ = other.gNOHNPJBFJC_;
			this.nMJDBOIPFIC_ = other.nMJDBOIPFIC_;
			this.nENGEIIJJCB_ = other.nENGEIIJJCB_;
			this.pJILEMMBLFG_ = other.pJILEMMBLFG_;
			this.cPEEEPDBBPH_ = other.cPEEEPDBBPH_;
			this.mCLJBLKACMP_ = other.mCLJBLKACMP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009344 RID: 37700 RVA: 0x00186640 File Offset: 0x00184840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSettingInfo Clone()
		{
			return new PlayerSettingInfo(this);
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x06009345 RID: 37701 RVA: 0x00186648 File Offset: 0x00184848
		// (set) Token: 0x06009346 RID: 37702 RVA: 0x00186650 File Offset: 0x00184850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JMBAGBFIKCM
		{
			get
			{
				return this.jMBAGBFIKCM_;
			}
			set
			{
				this.jMBAGBFIKCM_ = value;
			}
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x06009347 RID: 37703 RVA: 0x00186659 File Offset: 0x00184859
		// (set) Token: 0x06009348 RID: 37704 RVA: 0x00186661 File Offset: 0x00184861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ANEAAKIDPFL
		{
			get
			{
				return this.aNEAAKIDPFL_;
			}
			set
			{
				this.aNEAAKIDPFL_ = value;
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x06009349 RID: 37705 RVA: 0x0018666A File Offset: 0x0018486A
		// (set) Token: 0x0600934A RID: 37706 RVA: 0x00186672 File Offset: 0x00184872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CGADMDEKIAC
		{
			get
			{
				return this.cGADMDEKIAC_;
			}
			set
			{
				this.cGADMDEKIAC_ = value;
			}
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x0600934B RID: 37707 RVA: 0x0018667B File Offset: 0x0018487B
		// (set) Token: 0x0600934C RID: 37708 RVA: 0x00186683 File Offset: 0x00184883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GNOHNPJBFJC
		{
			get
			{
				return this.gNOHNPJBFJC_;
			}
			set
			{
				this.gNOHNPJBFJC_ = value;
			}
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x0600934D RID: 37709 RVA: 0x0018668C File Offset: 0x0018488C
		// (set) Token: 0x0600934E RID: 37710 RVA: 0x00186694 File Offset: 0x00184894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NMJDBOIPFIC
		{
			get
			{
				return this.nMJDBOIPFIC_;
			}
			set
			{
				this.nMJDBOIPFIC_ = value;
			}
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x0600934F RID: 37711 RVA: 0x0018669D File Offset: 0x0018489D
		// (set) Token: 0x06009350 RID: 37712 RVA: 0x001866A5 File Offset: 0x001848A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NENGEIIJJCB
		{
			get
			{
				return this.nENGEIIJJCB_;
			}
			set
			{
				this.nENGEIIJJCB_ = value;
			}
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x06009351 RID: 37713 RVA: 0x001866AE File Offset: 0x001848AE
		// (set) Token: 0x06009352 RID: 37714 RVA: 0x001866B6 File Offset: 0x001848B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PJILEMMBLFG
		{
			get
			{
				return this.pJILEMMBLFG_;
			}
			set
			{
				this.pJILEMMBLFG_ = value;
			}
		}

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x06009353 RID: 37715 RVA: 0x001866BF File Offset: 0x001848BF
		// (set) Token: 0x06009354 RID: 37716 RVA: 0x001866C7 File Offset: 0x001848C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CPEEEPDBBPH
		{
			get
			{
				return this.cPEEEPDBBPH_;
			}
			set
			{
				this.cPEEEPDBBPH_ = value;
			}
		}

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x06009355 RID: 37717 RVA: 0x001866D0 File Offset: 0x001848D0
		// (set) Token: 0x06009356 RID: 37718 RVA: 0x001866D8 File Offset: 0x001848D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MCLJBLKACMP
		{
			get
			{
				return this.mCLJBLKACMP_;
			}
			set
			{
				this.mCLJBLKACMP_ = value;
			}
		}

		// Token: 0x06009357 RID: 37719 RVA: 0x001866E1 File Offset: 0x001848E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSettingInfo);
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x001866F0 File Offset: 0x001848F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSettingInfo other)
		{
			return other != null && (other == this || (this.JMBAGBFIKCM == other.JMBAGBFIKCM && this.ANEAAKIDPFL == other.ANEAAKIDPFL && this.CGADMDEKIAC == other.CGADMDEKIAC && this.GNOHNPJBFJC == other.GNOHNPJBFJC && this.NMJDBOIPFIC == other.NMJDBOIPFIC && this.NENGEIIJJCB == other.NENGEIIJJCB && this.PJILEMMBLFG == other.PJILEMMBLFG && this.CPEEEPDBBPH == other.CPEEEPDBBPH && this.MCLJBLKACMP == other.MCLJBLKACMP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009359 RID: 37721 RVA: 0x001867AC File Offset: 0x001849AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JMBAGBFIKCM)
			{
				num ^= this.JMBAGBFIKCM.GetHashCode();
			}
			if (this.ANEAAKIDPFL)
			{
				num ^= this.ANEAAKIDPFL.GetHashCode();
			}
			if (this.CGADMDEKIAC)
			{
				num ^= this.CGADMDEKIAC.GetHashCode();
			}
			if (this.GNOHNPJBFJC)
			{
				num ^= this.GNOHNPJBFJC.GetHashCode();
			}
			if (this.NMJDBOIPFIC)
			{
				num ^= this.NMJDBOIPFIC.GetHashCode();
			}
			if (this.NENGEIIJJCB)
			{
				num ^= this.NENGEIIJJCB.GetHashCode();
			}
			if (this.PJILEMMBLFG)
			{
				num ^= this.PJILEMMBLFG.GetHashCode();
			}
			if (this.CPEEEPDBBPH)
			{
				num ^= this.CPEEEPDBBPH.GetHashCode();
			}
			if (this.MCLJBLKACMP)
			{
				num ^= this.MCLJBLKACMP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600935A RID: 37722 RVA: 0x001868B3 File Offset: 0x00184AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x001868BB File Offset: 0x00184ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600935C RID: 37724 RVA: 0x001868C4 File Offset: 0x00184AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CPEEEPDBBPH)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.CPEEEPDBBPH);
			}
			if (this.GNOHNPJBFJC)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.GNOHNPJBFJC);
			}
			if (this.MCLJBLKACMP)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.MCLJBLKACMP);
			}
			if (this.NMJDBOIPFIC)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.NMJDBOIPFIC);
			}
			if (this.PJILEMMBLFG)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.PJILEMMBLFG);
			}
			if (this.JMBAGBFIKCM)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.JMBAGBFIKCM);
			}
			if (this.CGADMDEKIAC)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.CGADMDEKIAC);
			}
			if (this.ANEAAKIDPFL)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.ANEAAKIDPFL);
			}
			if (this.NENGEIIJJCB)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.NENGEIIJJCB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600935D RID: 37725 RVA: 0x001869E4 File Offset: 0x00184BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JMBAGBFIKCM)
			{
				num += 2;
			}
			if (this.ANEAAKIDPFL)
			{
				num += 2;
			}
			if (this.CGADMDEKIAC)
			{
				num += 2;
			}
			if (this.GNOHNPJBFJC)
			{
				num += 2;
			}
			if (this.NMJDBOIPFIC)
			{
				num += 2;
			}
			if (this.NENGEIIJJCB)
			{
				num += 2;
			}
			if (this.PJILEMMBLFG)
			{
				num += 2;
			}
			if (this.CPEEEPDBBPH)
			{
				num += 2;
			}
			if (this.MCLJBLKACMP)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600935E RID: 37726 RVA: 0x00186A78 File Offset: 0x00184C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerSettingInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JMBAGBFIKCM)
			{
				this.JMBAGBFIKCM = other.JMBAGBFIKCM;
			}
			if (other.ANEAAKIDPFL)
			{
				this.ANEAAKIDPFL = other.ANEAAKIDPFL;
			}
			if (other.CGADMDEKIAC)
			{
				this.CGADMDEKIAC = other.CGADMDEKIAC;
			}
			if (other.GNOHNPJBFJC)
			{
				this.GNOHNPJBFJC = other.GNOHNPJBFJC;
			}
			if (other.NMJDBOIPFIC)
			{
				this.NMJDBOIPFIC = other.NMJDBOIPFIC;
			}
			if (other.NENGEIIJJCB)
			{
				this.NENGEIIJJCB = other.NENGEIIJJCB;
			}
			if (other.PJILEMMBLFG)
			{
				this.PJILEMMBLFG = other.PJILEMMBLFG;
			}
			if (other.CPEEEPDBBPH)
			{
				this.CPEEEPDBBPH = other.CPEEEPDBBPH;
			}
			if (other.MCLJBLKACMP)
			{
				this.MCLJBLKACMP = other.MCLJBLKACMP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600935F RID: 37727 RVA: 0x00186B54 File Offset: 0x00184D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009360 RID: 37728 RVA: 0x00186B60 File Offset: 0x00184D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 32U)
					{
						if (num == 24U)
						{
							this.CPEEEPDBBPH = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.GNOHNPJBFJC = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.MCLJBLKACMP = input.ReadBool();
							continue;
						}
						if (num == 48U)
						{
							this.NMJDBOIPFIC = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 56U)
					{
						this.PJILEMMBLFG = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.JMBAGBFIKCM = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.CGADMDEKIAC = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.ANEAAKIDPFL = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.NENGEIIJJCB = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038C5 RID: 14533
		private static readonly MessageParser<PlayerSettingInfo> _parser = new MessageParser<PlayerSettingInfo>(() => new PlayerSettingInfo());

		// Token: 0x040038C6 RID: 14534
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038C7 RID: 14535
		public const int JMBAGBFIKCMFieldNumber = 9;

		// Token: 0x040038C8 RID: 14536
		private bool jMBAGBFIKCM_;

		// Token: 0x040038C9 RID: 14537
		public const int ANEAAKIDPFLFieldNumber = 13;

		// Token: 0x040038CA RID: 14538
		private bool aNEAAKIDPFL_;

		// Token: 0x040038CB RID: 14539
		public const int CGADMDEKIACFieldNumber = 12;

		// Token: 0x040038CC RID: 14540
		private bool cGADMDEKIAC_;

		// Token: 0x040038CD RID: 14541
		public const int GNOHNPJBFJCFieldNumber = 4;

		// Token: 0x040038CE RID: 14542
		private bool gNOHNPJBFJC_;

		// Token: 0x040038CF RID: 14543
		public const int NMJDBOIPFICFieldNumber = 6;

		// Token: 0x040038D0 RID: 14544
		private bool nMJDBOIPFIC_;

		// Token: 0x040038D1 RID: 14545
		public const int NENGEIIJJCBFieldNumber = 14;

		// Token: 0x040038D2 RID: 14546
		private bool nENGEIIJJCB_;

		// Token: 0x040038D3 RID: 14547
		public const int PJILEMMBLFGFieldNumber = 7;

		// Token: 0x040038D4 RID: 14548
		private bool pJILEMMBLFG_;

		// Token: 0x040038D5 RID: 14549
		public const int CPEEEPDBBPHFieldNumber = 3;

		// Token: 0x040038D6 RID: 14550
		private bool cPEEEPDBBPH_;

		// Token: 0x040038D7 RID: 14551
		public const int MCLJBLKACMPFieldNumber = 5;

		// Token: 0x040038D8 RID: 14552
		private bool mCLJBLKACMP_;
	}
}
