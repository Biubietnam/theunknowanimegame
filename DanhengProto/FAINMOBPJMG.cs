using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004FB RID: 1275
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FAINMOBPJMG : IMessage<FAINMOBPJMG>, IMessage, IEquatable<FAINMOBPJMG>, IDeepCloneable<FAINMOBPJMG>, IBufferMessage
	{
		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x0009C23C File Offset: 0x0009A43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FAINMOBPJMG> Parser
		{
			get
			{
				return FAINMOBPJMG._parser;
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x0009C243 File Offset: 0x0009A443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FAINMOBPJMGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x060038FC RID: 14588 RVA: 0x0009C255 File Offset: 0x0009A455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FAINMOBPJMG.Descriptor;
			}
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x0009C25C File Offset: 0x0009A45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAINMOBPJMG()
		{
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x0009C264 File Offset: 0x0009A464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAINMOBPJMG(FAINMOBPJMG other) : this()
		{
			this.oGDMEGCODHO_ = other.oGDMEGCODHO_;
			this.time_ = other.time_;
			this.jMLMHKFCOGJ_ = ((other.jMLMHKFCOGJ_ != null) ? other.jMLMHKFCOGJ_.Clone() : null);
			this.eHFCDIAADJE_ = ((other.eHFCDIAADJE_ != null) ? other.eHFCDIAADJE_.Clone() : null);
			this.avatarId_ = other.avatarId_;
			this.eGNDMKMFPIN_ = other.eGNDMKMFPIN_;
			this.bAEAKJGMOGA_ = other.bAEAKJGMOGA_;
			this.pHLBMNLJAGE_ = ((other.pHLBMNLJAGE_ != null) ? other.pHLBMNLJAGE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x0009C318 File Offset: 0x0009A518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FAINMOBPJMG Clone()
		{
			return new FAINMOBPJMG(this);
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x0009C320 File Offset: 0x0009A520
		// (set) Token: 0x06003901 RID: 14593 RVA: 0x0009C328 File Offset: 0x0009A528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DevelopmentType OGDMEGCODHO
		{
			get
			{
				return this.oGDMEGCODHO_;
			}
			set
			{
				this.oGDMEGCODHO_ = value;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06003902 RID: 14594 RVA: 0x0009C331 File Offset: 0x0009A531
		// (set) Token: 0x06003903 RID: 14595 RVA: 0x0009C339 File Offset: 0x0009A539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Time
		{
			get
			{
				return this.time_;
			}
			set
			{
				this.time_ = value;
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06003904 RID: 14596 RVA: 0x0009C342 File Offset: 0x0009A542
		// (set) Token: 0x06003905 RID: 14597 RVA: 0x0009C34A File Offset: 0x0009A54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EGBPFBMGIPF JMLMHKFCOGJ
		{
			get
			{
				return this.jMLMHKFCOGJ_;
			}
			set
			{
				this.jMLMHKFCOGJ_ = value;
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06003906 RID: 14598 RVA: 0x0009C353 File Offset: 0x0009A553
		// (set) Token: 0x06003907 RID: 14599 RVA: 0x0009C35B File Offset: 0x0009A55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KJIFKKLHIJB EHFCDIAADJE
		{
			get
			{
				return this.eHFCDIAADJE_;
			}
			set
			{
				this.eHFCDIAADJE_ = value;
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06003908 RID: 14600 RVA: 0x0009C364 File Offset: 0x0009A564
		// (set) Token: 0x06003909 RID: 14601 RVA: 0x0009C36C File Offset: 0x0009A56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x0600390A RID: 14602 RVA: 0x0009C375 File Offset: 0x0009A575
		// (set) Token: 0x0600390B RID: 14603 RVA: 0x0009C37D File Offset: 0x0009A57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EGNDMKMFPIN
		{
			get
			{
				return this.eGNDMKMFPIN_;
			}
			set
			{
				this.eGNDMKMFPIN_ = value;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x0600390C RID: 14604 RVA: 0x0009C386 File Offset: 0x0009A586
		// (set) Token: 0x0600390D RID: 14605 RVA: 0x0009C38E File Offset: 0x0009A58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BAEAKJGMOGA
		{
			get
			{
				return this.bAEAKJGMOGA_;
			}
			set
			{
				this.bAEAKJGMOGA_ = value;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x0600390E RID: 14606 RVA: 0x0009C397 File Offset: 0x0009A597
		// (set) Token: 0x0600390F RID: 14607 RVA: 0x0009C39F File Offset: 0x0009A59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICDLIMEEGBC PHLBMNLJAGE
		{
			get
			{
				return this.pHLBMNLJAGE_;
			}
			set
			{
				this.pHLBMNLJAGE_ = value;
			}
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x0009C3A8 File Offset: 0x0009A5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FAINMOBPJMG);
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x0009C3B8 File Offset: 0x0009A5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FAINMOBPJMG other)
		{
			return other != null && (other == this || (this.OGDMEGCODHO == other.OGDMEGCODHO && this.Time == other.Time && object.Equals(this.JMLMHKFCOGJ, other.JMLMHKFCOGJ) && object.Equals(this.EHFCDIAADJE, other.EHFCDIAADJE) && this.AvatarId == other.AvatarId && this.EGNDMKMFPIN == other.EGNDMKMFPIN && this.BAEAKJGMOGA == other.BAEAKJGMOGA && object.Equals(this.PHLBMNLJAGE, other.PHLBMNLJAGE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x0009C470 File Offset: 0x0009A670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OGDMEGCODHO != DevelopmentType.DevelopmentNone)
			{
				num ^= this.OGDMEGCODHO.GetHashCode();
			}
			if (this.Time != 0L)
			{
				num ^= this.Time.GetHashCode();
			}
			if (this.jMLMHKFCOGJ_ != null)
			{
				num ^= this.JMLMHKFCOGJ.GetHashCode();
			}
			if (this.eHFCDIAADJE_ != null)
			{
				num ^= this.EHFCDIAADJE.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.EGNDMKMFPIN != 0U)
			{
				num ^= this.EGNDMKMFPIN.GetHashCode();
			}
			if (this.BAEAKJGMOGA != 0U)
			{
				num ^= this.BAEAKJGMOGA.GetHashCode();
			}
			if (this.pHLBMNLJAGE_ != null)
			{
				num ^= this.PHLBMNLJAGE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x0009C55B File Offset: 0x0009A75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x0009C563 File Offset: 0x0009A763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x0009C56C File Offset: 0x0009A76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OGDMEGCODHO != DevelopmentType.DevelopmentNone)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.OGDMEGCODHO);
			}
			if (this.Time != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Time);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(176, 41);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.BAEAKJGMOGA != 0U)
			{
				output.WriteRawTag(200, 41);
				output.WriteUInt32(this.BAEAKJGMOGA);
			}
			if (this.EGNDMKMFPIN != 0U)
			{
				output.WriteRawTag(144, 52);
				output.WriteUInt32(this.EGNDMKMFPIN);
			}
			if (this.jMLMHKFCOGJ_ != null)
			{
				output.WriteRawTag(242, 72);
				output.WriteMessage(this.JMLMHKFCOGJ);
			}
			if (this.eHFCDIAADJE_ != null)
			{
				output.WriteRawTag(178, 84);
				output.WriteMessage(this.EHFCDIAADJE);
			}
			if (this.pHLBMNLJAGE_ != null)
			{
				output.WriteRawTag(138, 121);
				output.WriteMessage(this.PHLBMNLJAGE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x0009C68C File Offset: 0x0009A88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OGDMEGCODHO != DevelopmentType.DevelopmentNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OGDMEGCODHO);
			}
			if (this.Time != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Time);
			}
			if (this.jMLMHKFCOGJ_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.JMLMHKFCOGJ);
			}
			if (this.eHFCDIAADJE_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EHFCDIAADJE);
			}
			if (this.AvatarId != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.EGNDMKMFPIN != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.EGNDMKMFPIN);
			}
			if (this.BAEAKJGMOGA != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.BAEAKJGMOGA);
			}
			if (this.pHLBMNLJAGE_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PHLBMNLJAGE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x0009C774 File Offset: 0x0009A974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FAINMOBPJMG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OGDMEGCODHO != DevelopmentType.DevelopmentNone)
			{
				this.OGDMEGCODHO = other.OGDMEGCODHO;
			}
			if (other.Time != 0L)
			{
				this.Time = other.Time;
			}
			if (other.jMLMHKFCOGJ_ != null)
			{
				if (this.jMLMHKFCOGJ_ == null)
				{
					this.JMLMHKFCOGJ = new EGBPFBMGIPF();
				}
				this.JMLMHKFCOGJ.MergeFrom(other.JMLMHKFCOGJ);
			}
			if (other.eHFCDIAADJE_ != null)
			{
				if (this.eHFCDIAADJE_ == null)
				{
					this.EHFCDIAADJE = new KJIFKKLHIJB();
				}
				this.EHFCDIAADJE.MergeFrom(other.EHFCDIAADJE);
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.EGNDMKMFPIN != 0U)
			{
				this.EGNDMKMFPIN = other.EGNDMKMFPIN;
			}
			if (other.BAEAKJGMOGA != 0U)
			{
				this.BAEAKJGMOGA = other.BAEAKJGMOGA;
			}
			if (other.pHLBMNLJAGE_ != null)
			{
				if (this.pHLBMNLJAGE_ == null)
				{
					this.PHLBMNLJAGE = new ICDLIMEEGBC();
				}
				this.PHLBMNLJAGE.MergeFrom(other.PHLBMNLJAGE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x0009C884 File Offset: 0x0009AA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x0009C890 File Offset: 0x0009AA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 5320U)
				{
					if (num <= 80U)
					{
						if (num == 8U)
						{
							this.OGDMEGCODHO = (DevelopmentType)input.ReadEnum();
							continue;
						}
						if (num == 80U)
						{
							this.Time = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 5296U)
						{
							this.AvatarId = input.ReadUInt32();
							continue;
						}
						if (num == 5320U)
						{
							this.BAEAKJGMOGA = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 9330U)
				{
					if (num == 6672U)
					{
						this.EGNDMKMFPIN = input.ReadUInt32();
						continue;
					}
					if (num == 9330U)
					{
						if (this.jMLMHKFCOGJ_ == null)
						{
							this.JMLMHKFCOGJ = new EGBPFBMGIPF();
						}
						input.ReadMessage(this.JMLMHKFCOGJ);
						continue;
					}
				}
				else
				{
					if (num == 10802U)
					{
						if (this.eHFCDIAADJE_ == null)
						{
							this.EHFCDIAADJE = new KJIFKKLHIJB();
						}
						input.ReadMessage(this.EHFCDIAADJE);
						continue;
					}
					if (num == 15498U)
					{
						if (this.pHLBMNLJAGE_ == null)
						{
							this.PHLBMNLJAGE = new ICDLIMEEGBC();
						}
						input.ReadMessage(this.PHLBMNLJAGE);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001698 RID: 5784
		private static readonly MessageParser<FAINMOBPJMG> _parser = new MessageParser<FAINMOBPJMG>(() => new FAINMOBPJMG());

		// Token: 0x04001699 RID: 5785
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400169A RID: 5786
		public const int OGDMEGCODHOFieldNumber = 1;

		// Token: 0x0400169B RID: 5787
		private DevelopmentType oGDMEGCODHO_;

		// Token: 0x0400169C RID: 5788
		public const int TimeFieldNumber = 10;

		// Token: 0x0400169D RID: 5789
		private long time_;

		// Token: 0x0400169E RID: 5790
		public const int JMLMHKFCOGJFieldNumber = 1166;

		// Token: 0x0400169F RID: 5791
		private EGBPFBMGIPF jMLMHKFCOGJ_;

		// Token: 0x040016A0 RID: 5792
		public const int EHFCDIAADJEFieldNumber = 1350;

		// Token: 0x040016A1 RID: 5793
		private KJIFKKLHIJB eHFCDIAADJE_;

		// Token: 0x040016A2 RID: 5794
		public const int AvatarIdFieldNumber = 662;

		// Token: 0x040016A3 RID: 5795
		private uint avatarId_;

		// Token: 0x040016A4 RID: 5796
		public const int EGNDMKMFPINFieldNumber = 834;

		// Token: 0x040016A5 RID: 5797
		private uint eGNDMKMFPIN_;

		// Token: 0x040016A6 RID: 5798
		public const int BAEAKJGMOGAFieldNumber = 665;

		// Token: 0x040016A7 RID: 5799
		private uint bAEAKJGMOGA_;

		// Token: 0x040016A8 RID: 5800
		public const int PHLBMNLJAGEFieldNumber = 1937;

		// Token: 0x040016A9 RID: 5801
		private ICDLIMEEGBC pHLBMNLJAGE_;
	}
}
