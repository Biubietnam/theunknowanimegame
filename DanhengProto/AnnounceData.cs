using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000A3 RID: 163
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AnnounceData : IMessage<AnnounceData>, IMessage, IEquatable<AnnounceData>, IDeepCloneable<AnnounceData>, IBufferMessage
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000138C8 File Offset: 0x00011AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AnnounceData> Parser
		{
			get
			{
				return AnnounceData._parser;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x000138CF File Offset: 0x00011ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AnnounceDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x000138E1 File Offset: 0x00011AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnnounceData.Descriptor;
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000138E8 File Offset: 0x00011AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnnounceData()
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00013914 File Offset: 0x00011B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnnounceData(AnnounceData other) : this()
		{
			this.bNGDKIBJHMD_ = other.bNGDKIBJHMD_;
			this.cENCAKDHHHA_ = other.cENCAKDHHHA_;
			this.jOCJAFILDGH_ = other.jOCJAFILDGH_;
			this.beginTime_ = other.beginTime_;
			this.jCLHPKIEDIA_ = other.jCLHPKIEDIA_;
			this.endTime_ = other.endTime_;
			this.configId_ = other.configId_;
			this.oDBEELGCENI_ = other.oDBEELGCENI_;
			this.nFOIIBJPFFG_ = other.nFOIIBJPFFG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000139A4 File Offset: 0x00011BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnnounceData Clone()
		{
			return new AnnounceData(this);
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x000139AC File Offset: 0x00011BAC
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x000139B4 File Offset: 0x00011BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BNGDKIBJHMD
		{
			get
			{
				return this.bNGDKIBJHMD_;
			}
			set
			{
				this.bNGDKIBJHMD_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x000139C7 File Offset: 0x00011BC7
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x000139CF File Offset: 0x00011BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CENCAKDHHHA
		{
			get
			{
				return this.cENCAKDHHHA_;
			}
			set
			{
				this.cENCAKDHHHA_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x000139E2 File Offset: 0x00011BE2
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x000139EA File Offset: 0x00011BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JOCJAFILDGH
		{
			get
			{
				return this.jOCJAFILDGH_;
			}
			set
			{
				this.jOCJAFILDGH_ = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x000139F3 File Offset: 0x00011BF3
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x000139FB File Offset: 0x00011BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00013A04 File Offset: 0x00011C04
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00013A0C File Offset: 0x00011C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JCLHPKIEDIA
		{
			get
			{
				return this.jCLHPKIEDIA_;
			}
			set
			{
				this.jCLHPKIEDIA_ = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00013A15 File Offset: 0x00011C15
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00013A1D File Offset: 0x00011C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00013A26 File Offset: 0x00011C26
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00013A2E File Offset: 0x00011C2E
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

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00013A37 File Offset: 0x00011C37
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00013A3F File Offset: 0x00011C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ODBEELGCENI
		{
			get
			{
				return this.oDBEELGCENI_;
			}
			set
			{
				this.oDBEELGCENI_ = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00013A48 File Offset: 0x00011C48
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00013A50 File Offset: 0x00011C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string NFOIIBJPFFG
		{
			get
			{
				return this.nFOIIBJPFFG_;
			}
			set
			{
				this.nFOIIBJPFFG_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00013A63 File Offset: 0x00011C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnnounceData);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00013A74 File Offset: 0x00011C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnnounceData other)
		{
			return other != null && (other == this || (!(this.BNGDKIBJHMD != other.BNGDKIBJHMD) && !(this.CENCAKDHHHA != other.CENCAKDHHHA) && this.JOCJAFILDGH == other.JOCJAFILDGH && this.BeginTime == other.BeginTime && this.JCLHPKIEDIA == other.JCLHPKIEDIA && this.EndTime == other.EndTime && this.ConfigId == other.ConfigId && this.ODBEELGCENI == other.ODBEELGCENI && !(this.NFOIIBJPFFG != other.NFOIIBJPFFG) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00013B3C File Offset: 0x00011D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BNGDKIBJHMD.Length != 0)
			{
				num ^= this.BNGDKIBJHMD.GetHashCode();
			}
			if (this.CENCAKDHHHA.Length != 0)
			{
				num ^= this.CENCAKDHHHA.GetHashCode();
			}
			if (this.JOCJAFILDGH)
			{
				num ^= this.JOCJAFILDGH.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.JCLHPKIEDIA != 0U)
			{
				num ^= this.JCLHPKIEDIA.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.ConfigId != 0U)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.ODBEELGCENI != 0U)
			{
				num ^= this.ODBEELGCENI.GetHashCode();
			}
			if (this.NFOIIBJPFFG.Length != 0)
			{
				num ^= this.NFOIIBJPFFG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00013C49 File Offset: 0x00011E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00013C51 File Offset: 0x00011E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00013C5C File Offset: 0x00011E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ODBEELGCENI != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ODBEELGCENI);
			}
			if (this.JOCJAFILDGH)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.JOCJAFILDGH);
			}
			if (this.CENCAKDHHHA.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.CENCAKDHHHA);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EndTime);
			}
			if (this.NFOIIBJPFFG.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.NFOIIBJPFFG);
			}
			if (this.ConfigId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ConfigId);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.BeginTime);
			}
			if (this.JCLHPKIEDIA != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.JCLHPKIEDIA);
			}
			if (this.BNGDKIBJHMD.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.BNGDKIBJHMD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00013D88 File Offset: 0x00011F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BNGDKIBJHMD.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BNGDKIBJHMD);
			}
			if (this.CENCAKDHHHA.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CENCAKDHHHA);
			}
			if (this.JOCJAFILDGH)
			{
				num += 2;
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.JCLHPKIEDIA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JCLHPKIEDIA);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.ConfigId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConfigId);
			}
			if (this.ODBEELGCENI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ODBEELGCENI);
			}
			if (this.NFOIIBJPFFG.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.NFOIIBJPFFG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00013E8C File Offset: 0x0001208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnnounceData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BNGDKIBJHMD.Length != 0)
			{
				this.BNGDKIBJHMD = other.BNGDKIBJHMD;
			}
			if (other.CENCAKDHHHA.Length != 0)
			{
				this.CENCAKDHHHA = other.CENCAKDHHHA;
			}
			if (other.JOCJAFILDGH)
			{
				this.JOCJAFILDGH = other.JOCJAFILDGH;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.JCLHPKIEDIA != 0U)
			{
				this.JCLHPKIEDIA = other.JCLHPKIEDIA;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.ConfigId != 0U)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.ODBEELGCENI != 0U)
			{
				this.ODBEELGCENI = other.ODBEELGCENI;
			}
			if (other.NFOIIBJPFFG.Length != 0)
			{
				this.NFOIIBJPFFG = other.NFOIIBJPFFG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00013F77 File Offset: 0x00012177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00013F80 File Offset: 0x00012180
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
							this.ODBEELGCENI = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.JOCJAFILDGH = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							this.CENCAKDHHHA = input.ReadString();
							continue;
						}
						if (num == 56U)
						{
							this.EndTime = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 66U)
					{
						this.NFOIIBJPFFG = input.ReadString();
						continue;
					}
					if (num == 72U)
					{
						this.ConfigId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.JCLHPKIEDIA = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						this.BNGDKIBJHMD = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400028C RID: 652
		private static readonly MessageParser<AnnounceData> _parser = new MessageParser<AnnounceData>(() => new AnnounceData());

		// Token: 0x0400028D RID: 653
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400028E RID: 654
		public const int BNGDKIBJHMDFieldNumber = 15;

		// Token: 0x0400028F RID: 655
		private string bNGDKIBJHMD_ = "";

		// Token: 0x04000290 RID: 656
		public const int CENCAKDHHHAFieldNumber = 5;

		// Token: 0x04000291 RID: 657
		private string cENCAKDHHHA_ = "";

		// Token: 0x04000292 RID: 658
		public const int JOCJAFILDGHFieldNumber = 4;

		// Token: 0x04000293 RID: 659
		private bool jOCJAFILDGH_;

		// Token: 0x04000294 RID: 660
		public const int BeginTimeFieldNumber = 11;

		// Token: 0x04000295 RID: 661
		private long beginTime_;

		// Token: 0x04000296 RID: 662
		public const int JCLHPKIEDIAFieldNumber = 14;

		// Token: 0x04000297 RID: 663
		private uint jCLHPKIEDIA_;

		// Token: 0x04000298 RID: 664
		public const int EndTimeFieldNumber = 7;

		// Token: 0x04000299 RID: 665
		private long endTime_;

		// Token: 0x0400029A RID: 666
		public const int ConfigIdFieldNumber = 9;

		// Token: 0x0400029B RID: 667
		private uint configId_;

		// Token: 0x0400029C RID: 668
		public const int ODBEELGCENIFieldNumber = 1;

		// Token: 0x0400029D RID: 669
		private uint oDBEELGCENI_;

		// Token: 0x0400029E RID: 670
		public const int NFOIIBJPFFGFieldNumber = 8;

		// Token: 0x0400029F RID: 671
		private string nFOIIBJPFFG_ = "";
	}
}
