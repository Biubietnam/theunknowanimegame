using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000185 RID: 389
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CFHPMBOAHLA : IMessage<CFHPMBOAHLA>, IMessage, IEquatable<CFHPMBOAHLA>, IDeepCloneable<CFHPMBOAHLA>, IBufferMessage
	{
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00031E7B File Offset: 0x0003007B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CFHPMBOAHLA> Parser
		{
			get
			{
				return CFHPMBOAHLA._parser;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00031E82 File Offset: 0x00030082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CFHPMBOAHLAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x00031E94 File Offset: 0x00030094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CFHPMBOAHLA.Descriptor;
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00031E9B File Offset: 0x0003009B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFHPMBOAHLA()
		{
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00031EBC File Offset: 0x000300BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFHPMBOAHLA(CFHPMBOAHLA other) : this()
		{
			this.eCHDMBOJOPG_ = other.eCHDMBOJOPG_;
			this.gKLKADILBJO_ = ((other.gKLKADILBJO_ != null) ? other.gKLKADILBJO_.Clone() : null);
			this.gGEIPPODPDL_ = other.gGEIPPODPDL_.Clone();
			this.lOPEOEFEONH_ = other.lOPEOEFEONH_;
			this.pPJLNEDNDAH_ = other.pPJLNEDNDAH_;
			this.cGBNDODFNHK_ = other.cGBNDODFNHK_.Clone();
			this.aNEMNIMLLNJ_ = other.aNEMNIMLLNJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00031F4E File Offset: 0x0003014E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFHPMBOAHLA Clone()
		{
			return new CFHPMBOAHLA(this);
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00031F56 File Offset: 0x00030156
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x00031F5E File Offset: 0x0003015E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ECHDMBOJOPG
		{
			get
			{
				return this.eCHDMBOJOPG_;
			}
			set
			{
				this.eCHDMBOJOPG_ = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00031F67 File Offset: 0x00030167
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x00031F6F File Offset: 0x0003016F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KAKPHLOPDAN GKLKADILBJO
		{
			get
			{
				return this.gKLKADILBJO_;
			}
			set
			{
				this.gKLKADILBJO_ = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x00031F78 File Offset: 0x00030178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GGEIPPODPDL
		{
			get
			{
				return this.gGEIPPODPDL_;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00031F80 File Offset: 0x00030180
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x00031F88 File Offset: 0x00030188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LAKKMDLDAGD LOPEOEFEONH
		{
			get
			{
				return this.lOPEOEFEONH_;
			}
			set
			{
				this.lOPEOEFEONH_ = value;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00031F91 File Offset: 0x00030191
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x00031F99 File Offset: 0x00030199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PPJLNEDNDAH
		{
			get
			{
				return this.pPJLNEDNDAH_;
			}
			set
			{
				this.pPJLNEDNDAH_ = value;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00031FA2 File Offset: 0x000301A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FLEMIIBGLNC> CGBNDODFNHK
		{
			get
			{
				return this.cGBNDODFNHK_;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00031FAA File Offset: 0x000301AA
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x00031FB2 File Offset: 0x000301B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ANEMNIMLLNJ
		{
			get
			{
				return this.aNEMNIMLLNJ_;
			}
			set
			{
				this.aNEMNIMLLNJ_ = value;
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00031FBB File Offset: 0x000301BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CFHPMBOAHLA);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00031FCC File Offset: 0x000301CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CFHPMBOAHLA other)
		{
			return other != null && (other == this || (this.ECHDMBOJOPG == other.ECHDMBOJOPG && object.Equals(this.GKLKADILBJO, other.GKLKADILBJO) && this.gGEIPPODPDL_.Equals(other.gGEIPPODPDL_) && this.LOPEOEFEONH == other.LOPEOEFEONH && this.PPJLNEDNDAH == other.PPJLNEDNDAH && this.cGBNDODFNHK_.Equals(other.cGBNDODFNHK_) && this.ANEMNIMLLNJ == other.ANEMNIMLLNJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00032074 File Offset: 0x00030274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ECHDMBOJOPG != 0)
			{
				num ^= this.ECHDMBOJOPG.GetHashCode();
			}
			if (this.gKLKADILBJO_ != null)
			{
				num ^= this.GKLKADILBJO.GetHashCode();
			}
			num ^= this.gGEIPPODPDL_.GetHashCode();
			if (this.LOPEOEFEONH != LAKKMDLDAGD.Match3StateIdle)
			{
				num ^= this.LOPEOEFEONH.GetHashCode();
			}
			if (this.PPJLNEDNDAH != 0U)
			{
				num ^= this.PPJLNEDNDAH.GetHashCode();
			}
			num ^= this.cGBNDODFNHK_.GetHashCode();
			if (this.ANEMNIMLLNJ != 0UL)
			{
				num ^= this.ANEMNIMLLNJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00032137 File Offset: 0x00030337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0003213F File Offset: 0x0003033F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00032148 File Offset: 0x00030348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gGEIPPODPDL_.WriteTo(ref output, CFHPMBOAHLA._repeated_gGEIPPODPDL_codec);
			this.cGBNDODFNHK_.WriteTo(ref output, CFHPMBOAHLA._repeated_cGBNDODFNHK_codec);
			if (this.gKLKADILBJO_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.GKLKADILBJO);
			}
			if (this.ECHDMBOJOPG != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ECHDMBOJOPG);
			}
			if (this.PPJLNEDNDAH != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.PPJLNEDNDAH);
			}
			if (this.LOPEOEFEONH != LAKKMDLDAGD.Match3StateIdle)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.LOPEOEFEONH);
			}
			if (this.ANEMNIMLLNJ != 0UL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.ANEMNIMLLNJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00032218 File Offset: 0x00030418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ECHDMBOJOPG != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ECHDMBOJOPG);
			}
			if (this.gKLKADILBJO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GKLKADILBJO);
			}
			num += this.gGEIPPODPDL_.CalculateSize(CFHPMBOAHLA._repeated_gGEIPPODPDL_codec);
			if (this.LOPEOEFEONH != LAKKMDLDAGD.Match3StateIdle)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LOPEOEFEONH);
			}
			if (this.PPJLNEDNDAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PPJLNEDNDAH);
			}
			num += this.cGBNDODFNHK_.CalculateSize(CFHPMBOAHLA._repeated_cGBNDODFNHK_codec);
			if (this.ANEMNIMLLNJ != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ANEMNIMLLNJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x000322DC File Offset: 0x000304DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CFHPMBOAHLA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ECHDMBOJOPG != 0)
			{
				this.ECHDMBOJOPG = other.ECHDMBOJOPG;
			}
			if (other.gKLKADILBJO_ != null)
			{
				if (this.gKLKADILBJO_ == null)
				{
					this.GKLKADILBJO = new KAKPHLOPDAN();
				}
				this.GKLKADILBJO.MergeFrom(other.GKLKADILBJO);
			}
			this.gGEIPPODPDL_.Add(other.gGEIPPODPDL_);
			if (other.LOPEOEFEONH != LAKKMDLDAGD.Match3StateIdle)
			{
				this.LOPEOEFEONH = other.LOPEOEFEONH;
			}
			if (other.PPJLNEDNDAH != 0U)
			{
				this.PPJLNEDNDAH = other.PPJLNEDNDAH;
			}
			this.cGBNDODFNHK_.Add(other.cGBNDODFNHK_);
			if (other.ANEMNIMLLNJ != 0UL)
			{
				this.ANEMNIMLLNJ = other.ANEMNIMLLNJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x000323A2 File Offset: 0x000305A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000323AC File Offset: 0x000305AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.gGEIPPODPDL_.AddEntriesFrom(ref input, CFHPMBOAHLA._repeated_gGEIPPODPDL_codec);
							continue;
						}
					}
					else
					{
						if (num == 18U)
						{
							this.cGBNDODFNHK_.AddEntriesFrom(ref input, CFHPMBOAHLA._repeated_cGBNDODFNHK_codec);
							continue;
						}
						if (num == 42U)
						{
							if (this.gKLKADILBJO_ == null)
							{
								this.GKLKADILBJO = new KAKPHLOPDAN();
							}
							input.ReadMessage(this.GKLKADILBJO);
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 56U)
					{
						this.ECHDMBOJOPG = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.PPJLNEDNDAH = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.LOPEOEFEONH = (LAKKMDLDAGD)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.ANEMNIMLLNJ = input.ReadUInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000746 RID: 1862
		private static readonly MessageParser<CFHPMBOAHLA> _parser = new MessageParser<CFHPMBOAHLA>(() => new CFHPMBOAHLA());

		// Token: 0x04000747 RID: 1863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000748 RID: 1864
		public const int ECHDMBOJOPGFieldNumber = 7;

		// Token: 0x04000749 RID: 1865
		private int eCHDMBOJOPG_;

		// Token: 0x0400074A RID: 1866
		public const int GKLKADILBJOFieldNumber = 5;

		// Token: 0x0400074B RID: 1867
		private KAKPHLOPDAN gKLKADILBJO_;

		// Token: 0x0400074C RID: 1868
		public const int GGEIPPODPDLFieldNumber = 1;

		// Token: 0x0400074D RID: 1869
		private static readonly FieldCodec<uint> _repeated_gGEIPPODPDL_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400074E RID: 1870
		private readonly RepeatedField<uint> gGEIPPODPDL_ = new RepeatedField<uint>();

		// Token: 0x0400074F RID: 1871
		public const int LOPEOEFEONHFieldNumber = 10;

		// Token: 0x04000750 RID: 1872
		private LAKKMDLDAGD lOPEOEFEONH_;

		// Token: 0x04000751 RID: 1873
		public const int PPJLNEDNDAHFieldNumber = 9;

		// Token: 0x04000752 RID: 1874
		private uint pPJLNEDNDAH_;

		// Token: 0x04000753 RID: 1875
		public const int CGBNDODFNHKFieldNumber = 2;

		// Token: 0x04000754 RID: 1876
		private static readonly FieldCodec<FLEMIIBGLNC> _repeated_cGBNDODFNHK_codec = FieldCodec.ForMessage<FLEMIIBGLNC>(18U, FLEMIIBGLNC.Parser);

		// Token: 0x04000755 RID: 1877
		private readonly RepeatedField<FLEMIIBGLNC> cGBNDODFNHK_ = new RepeatedField<FLEMIIBGLNC>();

		// Token: 0x04000756 RID: 1878
		public const int ANEMNIMLLNJFieldNumber = 14;

		// Token: 0x04000757 RID: 1879
		private ulong aNEMNIMLLNJ_;
	}
}
