using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000EF RID: 239
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattlePassInfoNotify : IMessage<BattlePassInfoNotify>, IMessage, IEquatable<BattlePassInfoNotify>, IDeepCloneable<BattlePassInfoNotify>, IBufferMessage
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0001F645 File Offset: 0x0001D845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattlePassInfoNotify> Parser
		{
			get
			{
				return BattlePassInfoNotify._parser;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0001F64C File Offset: 0x0001D84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattlePassInfoNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0001F65E File Offset: 0x0001D85E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassInfoNotify.Descriptor;
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0001F665 File Offset: 0x0001D865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassInfoNotify()
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0001F670 File Offset: 0x0001D870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassInfoNotify(BattlePassInfoNotify other) : this()
		{
			this.level_ = other.level_;
			this.cKNFMIFFAHI_ = other.cKNFMIFFAHI_;
			this.eLPGEDMBCNB_ = other.eLPGEDMBCNB_;
			this.bAAIAFIJFAF_ = other.bAAIAFIJFAF_;
			this.exp_ = other.exp_;
			this.nPMCPLGFOHL_ = other.nPMCPLGFOHL_;
			this.fJIDIKAJMJI_ = other.fJIDIKAJMJI_;
			this.pFFMENBDHJC_ = other.pFFMENBDHJC_;
			this.oLOBAGLBGHG_ = other.oLOBAGLBGHG_;
			this.bpTierType_ = other.bpTierType_;
			this.gMBNOJBOHKK_ = other.gMBNOJBOHKK_;
			this.oFGGAMHLPMP_ = other.oFGGAMHLPMP_;
			this.hMBAFEEKNAJ_ = other.hMBAFEEKNAJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0001F730 File Offset: 0x0001D930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassInfoNotify Clone()
		{
			return new BattlePassInfoNotify(this);
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0001F738 File Offset: 0x0001D938
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0001F740 File Offset: 0x0001D940
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

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0001F749 File Offset: 0x0001D949
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0001F751 File Offset: 0x0001D951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong CKNFMIFFAHI
		{
			get
			{
				return this.cKNFMIFFAHI_;
			}
			set
			{
				this.cKNFMIFFAHI_ = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0001F75A File Offset: 0x0001D95A
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x0001F762 File Offset: 0x0001D962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ELPGEDMBCNB
		{
			get
			{
				return this.eLPGEDMBCNB_;
			}
			set
			{
				this.eLPGEDMBCNB_ = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0001F76B File Offset: 0x0001D96B
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0001F773 File Offset: 0x0001D973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong BAAIAFIJFAF
		{
			get
			{
				return this.bAAIAFIJFAF_;
			}
			set
			{
				this.bAAIAFIJFAF_ = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0001F77C File Offset: 0x0001D97C
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0001F784 File Offset: 0x0001D984
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0001F78D File Offset: 0x0001D98D
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0001F795 File Offset: 0x0001D995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NPMCPLGFOHL
		{
			get
			{
				return this.nPMCPLGFOHL_;
			}
			set
			{
				this.nPMCPLGFOHL_ = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0001F79E File Offset: 0x0001D99E
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0001F7A6 File Offset: 0x0001D9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong FJIDIKAJMJI
		{
			get
			{
				return this.fJIDIKAJMJI_;
			}
			set
			{
				this.fJIDIKAJMJI_ = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0001F7AF File Offset: 0x0001D9AF
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0001F7B7 File Offset: 0x0001D9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong PFFMENBDHJC
		{
			get
			{
				return this.pFFMENBDHJC_;
			}
			set
			{
				this.pFFMENBDHJC_ = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0001F7C0 File Offset: 0x0001D9C0
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0001F7C8 File Offset: 0x0001D9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong OLOBAGLBGHG
		{
			get
			{
				return this.oLOBAGLBGHG_;
			}
			set
			{
				this.oLOBAGLBGHG_ = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0001F7D1 File Offset: 0x0001D9D1
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0001F7D9 File Offset: 0x0001D9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BpTierType BpTierType
		{
			get
			{
				return this.bpTierType_;
			}
			set
			{
				this.bpTierType_ = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0001F7E2 File Offset: 0x0001D9E2
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0001F7EA File Offset: 0x0001D9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong GMBNOJBOHKK
		{
			get
			{
				return this.gMBNOJBOHKK_;
			}
			set
			{
				this.gMBNOJBOHKK_ = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0001F7F3 File Offset: 0x0001D9F3
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0001F7FB File Offset: 0x0001D9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OFGGAMHLPMP
		{
			get
			{
				return this.oFGGAMHLPMP_;
			}
			set
			{
				this.oFGGAMHLPMP_ = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0001F804 File Offset: 0x0001DA04
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x0001F80C File Offset: 0x0001DA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong HMBAFEEKNAJ
		{
			get
			{
				return this.hMBAFEEKNAJ_;
			}
			set
			{
				this.hMBAFEEKNAJ_ = value;
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0001F815 File Offset: 0x0001DA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassInfoNotify);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0001F824 File Offset: 0x0001DA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassInfoNotify other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.CKNFMIFFAHI == other.CKNFMIFFAHI && this.ELPGEDMBCNB == other.ELPGEDMBCNB && this.BAAIAFIJFAF == other.BAAIAFIJFAF && this.Exp == other.Exp && this.NPMCPLGFOHL == other.NPMCPLGFOHL && this.FJIDIKAJMJI == other.FJIDIKAJMJI && this.PFFMENBDHJC == other.PFFMENBDHJC && this.OLOBAGLBGHG == other.OLOBAGLBGHG && this.BpTierType == other.BpTierType && this.GMBNOJBOHKK == other.GMBNOJBOHKK && this.OFGGAMHLPMP == other.OFGGAMHLPMP && this.HMBAFEEKNAJ == other.HMBAFEEKNAJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0001F920 File Offset: 0x0001DB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.CKNFMIFFAHI != 0UL)
			{
				num ^= this.CKNFMIFFAHI.GetHashCode();
			}
			if (this.ELPGEDMBCNB != 0UL)
			{
				num ^= this.ELPGEDMBCNB.GetHashCode();
			}
			if (this.BAAIAFIJFAF != 0UL)
			{
				num ^= this.BAAIAFIJFAF.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.NPMCPLGFOHL != 0U)
			{
				num ^= this.NPMCPLGFOHL.GetHashCode();
			}
			if (this.FJIDIKAJMJI != 0UL)
			{
				num ^= this.FJIDIKAJMJI.GetHashCode();
			}
			if (this.PFFMENBDHJC != 0UL)
			{
				num ^= this.PFFMENBDHJC.GetHashCode();
			}
			if (this.OLOBAGLBGHG != 0UL)
			{
				num ^= this.OLOBAGLBGHG.GetHashCode();
			}
			if (this.BpTierType != BpTierType.None)
			{
				num ^= this.BpTierType.GetHashCode();
			}
			if (this.GMBNOJBOHKK != 0UL)
			{
				num ^= this.GMBNOJBOHKK.GetHashCode();
			}
			if (this.OFGGAMHLPMP != 0U)
			{
				num ^= this.OFGGAMHLPMP.GetHashCode();
			}
			if (this.HMBAFEEKNAJ != 0UL)
			{
				num ^= this.HMBAFEEKNAJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0001FA91 File Offset: 0x0001DC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0001FA99 File Offset: 0x0001DC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0001FAA4 File Offset: 0x0001DCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PFFMENBDHJC != 0UL)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.PFFMENBDHJC);
			}
			if (this.OFGGAMHLPMP != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.OFGGAMHLPMP);
			}
			if (this.GMBNOJBOHKK != 0UL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.GMBNOJBOHKK);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Level);
			}
			if (this.HMBAFEEKNAJ != 0UL)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.HMBAFEEKNAJ);
			}
			if (this.OLOBAGLBGHG != 0UL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.OLOBAGLBGHG);
			}
			if (this.NPMCPLGFOHL != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.NPMCPLGFOHL);
			}
			if (this.ELPGEDMBCNB != 0UL)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.ELPGEDMBCNB);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Exp);
			}
			if (this.CKNFMIFFAHI != 0UL)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.CKNFMIFFAHI);
			}
			if (this.FJIDIKAJMJI != 0UL)
			{
				output.WriteRawTag(104);
				output.WriteUInt64(this.FJIDIKAJMJI);
			}
			if (this.BAAIAFIJFAF != 0UL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.BAAIAFIJFAF);
			}
			if (this.BpTierType != BpTierType.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.BpTierType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001FC30 File Offset: 0x0001DE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.CKNFMIFFAHI != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CKNFMIFFAHI);
			}
			if (this.ELPGEDMBCNB != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ELPGEDMBCNB);
			}
			if (this.BAAIAFIJFAF != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.BAAIAFIJFAF);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.NPMCPLGFOHL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NPMCPLGFOHL);
			}
			if (this.FJIDIKAJMJI != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.FJIDIKAJMJI);
			}
			if (this.PFFMENBDHJC != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.PFFMENBDHJC);
			}
			if (this.OLOBAGLBGHG != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.OLOBAGLBGHG);
			}
			if (this.BpTierType != BpTierType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BpTierType);
			}
			if (this.GMBNOJBOHKK != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GMBNOJBOHKK);
			}
			if (this.OFGGAMHLPMP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OFGGAMHLPMP);
			}
			if (this.HMBAFEEKNAJ != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.HMBAFEEKNAJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001FD90 File Offset: 0x0001DF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.CKNFMIFFAHI != 0UL)
			{
				this.CKNFMIFFAHI = other.CKNFMIFFAHI;
			}
			if (other.ELPGEDMBCNB != 0UL)
			{
				this.ELPGEDMBCNB = other.ELPGEDMBCNB;
			}
			if (other.BAAIAFIJFAF != 0UL)
			{
				this.BAAIAFIJFAF = other.BAAIAFIJFAF;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.NPMCPLGFOHL != 0U)
			{
				this.NPMCPLGFOHL = other.NPMCPLGFOHL;
			}
			if (other.FJIDIKAJMJI != 0UL)
			{
				this.FJIDIKAJMJI = other.FJIDIKAJMJI;
			}
			if (other.PFFMENBDHJC != 0UL)
			{
				this.PFFMENBDHJC = other.PFFMENBDHJC;
			}
			if (other.OLOBAGLBGHG != 0UL)
			{
				this.OLOBAGLBGHG = other.OLOBAGLBGHG;
			}
			if (other.BpTierType != BpTierType.None)
			{
				this.BpTierType = other.BpTierType;
			}
			if (other.GMBNOJBOHKK != 0UL)
			{
				this.GMBNOJBOHKK = other.GMBNOJBOHKK;
			}
			if (other.OFGGAMHLPMP != 0U)
			{
				this.OFGGAMHLPMP = other.OFGGAMHLPMP;
			}
			if (other.HMBAFEEKNAJ != 0UL)
			{
				this.HMBAFEEKNAJ = other.HMBAFEEKNAJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0001FEBC File Offset: 0x0001E0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 40U)
					{
						if (num == 8U)
						{
							this.PFFMENBDHJC = input.ReadUInt64();
							continue;
						}
						if (num == 24U)
						{
							this.OFGGAMHLPMP = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.GMBNOJBOHKK = input.ReadUInt64();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.Level = input.ReadUInt32();
							continue;
						}
						if (num == 56U)
						{
							this.HMBAFEEKNAJ = input.ReadUInt64();
							continue;
						}
						if (num == 64U)
						{
							this.OLOBAGLBGHG = input.ReadUInt64();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.NPMCPLGFOHL = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ELPGEDMBCNB = input.ReadUInt64();
						continue;
					}
					if (num == 88U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.CKNFMIFFAHI = input.ReadUInt64();
						continue;
					}
					if (num == 104U)
					{
						this.FJIDIKAJMJI = input.ReadUInt64();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.BAAIAFIJFAF = input.ReadUInt64();
						continue;
					}
					if (num == 120U)
					{
						this.BpTierType = (BpTierType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400046D RID: 1133
		private static readonly MessageParser<BattlePassInfoNotify> _parser = new MessageParser<BattlePassInfoNotify>(() => new BattlePassInfoNotify());

		// Token: 0x0400046E RID: 1134
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400046F RID: 1135
		public const int LevelFieldNumber = 6;

		// Token: 0x04000470 RID: 1136
		private uint level_;

		// Token: 0x04000471 RID: 1137
		public const int CKNFMIFFAHIFieldNumber = 12;

		// Token: 0x04000472 RID: 1138
		private ulong cKNFMIFFAHI_;

		// Token: 0x04000473 RID: 1139
		public const int ELPGEDMBCNBFieldNumber = 10;

		// Token: 0x04000474 RID: 1140
		private ulong eLPGEDMBCNB_;

		// Token: 0x04000475 RID: 1141
		public const int BAAIAFIJFAFFieldNumber = 14;

		// Token: 0x04000476 RID: 1142
		private ulong bAAIAFIJFAF_;

		// Token: 0x04000477 RID: 1143
		public const int ExpFieldNumber = 11;

		// Token: 0x04000478 RID: 1144
		private uint exp_;

		// Token: 0x04000479 RID: 1145
		public const int NPMCPLGFOHLFieldNumber = 9;

		// Token: 0x0400047A RID: 1146
		private uint nPMCPLGFOHL_;

		// Token: 0x0400047B RID: 1147
		public const int FJIDIKAJMJIFieldNumber = 13;

		// Token: 0x0400047C RID: 1148
		private ulong fJIDIKAJMJI_;

		// Token: 0x0400047D RID: 1149
		public const int PFFMENBDHJCFieldNumber = 1;

		// Token: 0x0400047E RID: 1150
		private ulong pFFMENBDHJC_;

		// Token: 0x0400047F RID: 1151
		public const int OLOBAGLBGHGFieldNumber = 8;

		// Token: 0x04000480 RID: 1152
		private ulong oLOBAGLBGHG_;

		// Token: 0x04000481 RID: 1153
		public const int BpTierTypeFieldNumber = 15;

		// Token: 0x04000482 RID: 1154
		private BpTierType bpTierType_;

		// Token: 0x04000483 RID: 1155
		public const int GMBNOJBOHKKFieldNumber = 5;

		// Token: 0x04000484 RID: 1156
		private ulong gMBNOJBOHKK_;

		// Token: 0x04000485 RID: 1157
		public const int OFGGAMHLPMPFieldNumber = 3;

		// Token: 0x04000486 RID: 1158
		private uint oFGGAMHLPMP_;

		// Token: 0x04000487 RID: 1159
		public const int HMBAFEEKNAJFieldNumber = 7;

		// Token: 0x04000488 RID: 1160
		private ulong hMBAFEEKNAJ_;
	}
}
