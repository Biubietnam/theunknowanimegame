using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005AD RID: 1453
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FKLCCJDPHEI : IMessage<FKLCCJDPHEI>, IMessage, IEquatable<FKLCCJDPHEI>, IDeepCloneable<FKLCCJDPHEI>, IBufferMessage
	{
		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060040DF RID: 16607 RVA: 0x000B0A57 File Offset: 0x000AEC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FKLCCJDPHEI> Parser
		{
			get
			{
				return FKLCCJDPHEI._parser;
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060040E0 RID: 16608 RVA: 0x000B0A5E File Offset: 0x000AEC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FKLCCJDPHEIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060040E1 RID: 16609 RVA: 0x000B0A70 File Offset: 0x000AEC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FKLCCJDPHEI.Descriptor;
			}
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x000B0A77 File Offset: 0x000AEC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FKLCCJDPHEI()
		{
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x000B0A80 File Offset: 0x000AEC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FKLCCJDPHEI(FKLCCJDPHEI other) : this()
		{
			this.fCDGOMCIOKM_ = other.fCDGOMCIOKM_;
			this.mBMGMOJOAKN_ = other.mBMGMOJOAKN_;
			this.jMMHKNGFOCN_ = other.jMMHKNGFOCN_;
			this.wave_ = other.wave_;
			this.kKCHCLOLPMB_ = other.kKCHCLOLPMB_;
			this.pDPGDMPGOBM_ = other.pDPGDMPGOBM_;
			this.cFPOKHPIDPL_ = other.cFPOKHPIDPL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x000B0AF8 File Offset: 0x000AECF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FKLCCJDPHEI Clone()
		{
			return new FKLCCJDPHEI(this);
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060040E5 RID: 16613 RVA: 0x000B0B00 File Offset: 0x000AED00
		// (set) Token: 0x060040E6 RID: 16614 RVA: 0x000B0B08 File Offset: 0x000AED08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FCDGOMCIOKM
		{
			get
			{
				return this.fCDGOMCIOKM_;
			}
			set
			{
				this.fCDGOMCIOKM_ = value;
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060040E7 RID: 16615 RVA: 0x000B0B11 File Offset: 0x000AED11
		// (set) Token: 0x060040E8 RID: 16616 RVA: 0x000B0B19 File Offset: 0x000AED19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double MBMGMOJOAKN
		{
			get
			{
				return this.mBMGMOJOAKN_;
			}
			set
			{
				this.mBMGMOJOAKN_ = value;
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060040E9 RID: 16617 RVA: 0x000B0B22 File Offset: 0x000AED22
		// (set) Token: 0x060040EA RID: 16618 RVA: 0x000B0B2A File Offset: 0x000AED2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double JMMHKNGFOCN
		{
			get
			{
				return this.jMMHKNGFOCN_;
			}
			set
			{
				this.jMMHKNGFOCN_ = value;
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060040EB RID: 16619 RVA: 0x000B0B33 File Offset: 0x000AED33
		// (set) Token: 0x060040EC RID: 16620 RVA: 0x000B0B3B File Offset: 0x000AED3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Wave
		{
			get
			{
				return this.wave_;
			}
			set
			{
				this.wave_ = value;
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060040ED RID: 16621 RVA: 0x000B0B44 File Offset: 0x000AED44
		// (set) Token: 0x060040EE RID: 16622 RVA: 0x000B0B4C File Offset: 0x000AED4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KKCHCLOLPMB
		{
			get
			{
				return this.kKCHCLOLPMB_;
			}
			set
			{
				this.kKCHCLOLPMB_ = value;
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060040EF RID: 16623 RVA: 0x000B0B55 File Offset: 0x000AED55
		// (set) Token: 0x060040F0 RID: 16624 RVA: 0x000B0B5D File Offset: 0x000AED5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double PDPGDMPGOBM
		{
			get
			{
				return this.pDPGDMPGOBM_;
			}
			set
			{
				this.pDPGDMPGOBM_ = value;
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x000B0B66 File Offset: 0x000AED66
		// (set) Token: 0x060040F2 RID: 16626 RVA: 0x000B0B6E File Offset: 0x000AED6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double CFPOKHPIDPL
		{
			get
			{
				return this.cFPOKHPIDPL_;
			}
			set
			{
				this.cFPOKHPIDPL_ = value;
			}
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x000B0B77 File Offset: 0x000AED77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FKLCCJDPHEI);
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x000B0B88 File Offset: 0x000AED88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FKLCCJDPHEI other)
		{
			return other != null && (other == this || (this.FCDGOMCIOKM == other.FCDGOMCIOKM && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MBMGMOJOAKN, other.MBMGMOJOAKN) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.JMMHKNGFOCN, other.JMMHKNGFOCN) && this.Wave == other.Wave && this.KKCHCLOLPMB == other.KKCHCLOLPMB && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PDPGDMPGOBM, other.PDPGDMPGOBM) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.CFPOKHPIDPL, other.CFPOKHPIDPL) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x000B0C4C File Offset: 0x000AEE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FCDGOMCIOKM != 0U)
			{
				num ^= this.FCDGOMCIOKM.GetHashCode();
			}
			if (this.MBMGMOJOAKN != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MBMGMOJOAKN);
			}
			if (this.JMMHKNGFOCN != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.JMMHKNGFOCN);
			}
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.KKCHCLOLPMB != 0U)
			{
				num ^= this.KKCHCLOLPMB.GetHashCode();
			}
			if (this.PDPGDMPGOBM != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PDPGDMPGOBM);
			}
			if (this.CFPOKHPIDPL != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.CFPOKHPIDPL);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x000B0D4D File Offset: 0x000AEF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x000B0D55 File Offset: 0x000AEF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x000B0D60 File Offset: 0x000AEF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FCDGOMCIOKM != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.FCDGOMCIOKM);
			}
			if (this.MBMGMOJOAKN != 0.0)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.MBMGMOJOAKN);
			}
			if (this.JMMHKNGFOCN != 0.0)
			{
				output.WriteRawTag(25);
				output.WriteDouble(this.JMMHKNGFOCN);
			}
			if (this.Wave != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Wave);
			}
			if (this.KKCHCLOLPMB != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.KKCHCLOLPMB);
			}
			if (this.PDPGDMPGOBM != 0.0)
			{
				output.WriteRawTag(49);
				output.WriteDouble(this.PDPGDMPGOBM);
			}
			if (this.CFPOKHPIDPL != 0.0)
			{
				output.WriteRawTag(57);
				output.WriteDouble(this.CFPOKHPIDPL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x000B0E68 File Offset: 0x000AF068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FCDGOMCIOKM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FCDGOMCIOKM);
			}
			if (this.MBMGMOJOAKN != 0.0)
			{
				num += 9;
			}
			if (this.JMMHKNGFOCN != 0.0)
			{
				num += 9;
			}
			if (this.Wave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this.KKCHCLOLPMB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KKCHCLOLPMB);
			}
			if (this.PDPGDMPGOBM != 0.0)
			{
				num += 9;
			}
			if (this.CFPOKHPIDPL != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x000B0F30 File Offset: 0x000AF130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FKLCCJDPHEI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FCDGOMCIOKM != 0U)
			{
				this.FCDGOMCIOKM = other.FCDGOMCIOKM;
			}
			if (other.MBMGMOJOAKN != 0.0)
			{
				this.MBMGMOJOAKN = other.MBMGMOJOAKN;
			}
			if (other.JMMHKNGFOCN != 0.0)
			{
				this.JMMHKNGFOCN = other.JMMHKNGFOCN;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			if (other.KKCHCLOLPMB != 0U)
			{
				this.KKCHCLOLPMB = other.KKCHCLOLPMB;
			}
			if (other.PDPGDMPGOBM != 0.0)
			{
				this.PDPGDMPGOBM = other.PDPGDMPGOBM;
			}
			if (other.CFPOKHPIDPL != 0.0)
			{
				this.CFPOKHPIDPL = other.CFPOKHPIDPL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x000B1008 File Offset: 0x000AF208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x000B1014 File Offset: 0x000AF214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 25U)
				{
					if (num == 8U)
					{
						this.FCDGOMCIOKM = input.ReadUInt32();
						continue;
					}
					if (num == 17U)
					{
						this.MBMGMOJOAKN = input.ReadDouble();
						continue;
					}
					if (num == 25U)
					{
						this.JMMHKNGFOCN = input.ReadDouble();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.Wave = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.KKCHCLOLPMB = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 49U)
					{
						this.PDPGDMPGOBM = input.ReadDouble();
						continue;
					}
					if (num == 57U)
					{
						this.CFPOKHPIDPL = input.ReadDouble();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040019BA RID: 6586
		private static readonly MessageParser<FKLCCJDPHEI> _parser = new MessageParser<FKLCCJDPHEI>(() => new FKLCCJDPHEI());

		// Token: 0x040019BB RID: 6587
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019BC RID: 6588
		public const int FCDGOMCIOKMFieldNumber = 1;

		// Token: 0x040019BD RID: 6589
		private uint fCDGOMCIOKM_;

		// Token: 0x040019BE RID: 6590
		public const int MBMGMOJOAKNFieldNumber = 2;

		// Token: 0x040019BF RID: 6591
		private double mBMGMOJOAKN_;

		// Token: 0x040019C0 RID: 6592
		public const int JMMHKNGFOCNFieldNumber = 3;

		// Token: 0x040019C1 RID: 6593
		private double jMMHKNGFOCN_;

		// Token: 0x040019C2 RID: 6594
		public const int WaveFieldNumber = 4;

		// Token: 0x040019C3 RID: 6595
		private uint wave_;

		// Token: 0x040019C4 RID: 6596
		public const int KKCHCLOLPMBFieldNumber = 5;

		// Token: 0x040019C5 RID: 6597
		private uint kKCHCLOLPMB_;

		// Token: 0x040019C6 RID: 6598
		public const int PDPGDMPGOBMFieldNumber = 6;

		// Token: 0x040019C7 RID: 6599
		private double pDPGDMPGOBM_;

		// Token: 0x040019C8 RID: 6600
		public const int CFPOKHPIDPLFieldNumber = 7;

		// Token: 0x040019C9 RID: 6601
		private double cFPOKHPIDPL_;
	}
}
