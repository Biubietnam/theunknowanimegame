using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C25 RID: 3109
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NNCOHNDNMJJ : IMessage<NNCOHNDNMJJ>, IMessage, IEquatable<NNCOHNDNMJJ>, IDeepCloneable<NNCOHNDNMJJ>, IBufferMessage
	{
		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x060089BA RID: 35258 RVA: 0x0016BB03 File Offset: 0x00169D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NNCOHNDNMJJ> Parser
		{
			get
			{
				return NNCOHNDNMJJ._parser;
			}
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x060089BB RID: 35259 RVA: 0x0016BB0A File Offset: 0x00169D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NNCOHNDNMJJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x060089BC RID: 35260 RVA: 0x0016BB1C File Offset: 0x00169D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NNCOHNDNMJJ.Descriptor;
			}
		}

		// Token: 0x060089BD RID: 35261 RVA: 0x0016BB23 File Offset: 0x00169D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NNCOHNDNMJJ()
		{
		}

		// Token: 0x060089BE RID: 35262 RVA: 0x0016BB38 File Offset: 0x00169D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NNCOHNDNMJJ(NNCOHNDNMJJ other) : this()
		{
			this.wave_ = other.wave_;
			this.scoreId_ = other.scoreId_;
			this.fJBICABJMKO_ = other.fJBICABJMKO_;
			this.bMHGALCIECK_ = other.bMHGALCIECK_.Clone();
			this.nLMOBJCCDEL_ = other.nLMOBJCCDEL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089BF RID: 35263 RVA: 0x0016BB9D File Offset: 0x00169D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NNCOHNDNMJJ Clone()
		{
			return new NNCOHNDNMJJ(this);
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x060089C0 RID: 35264 RVA: 0x0016BBA5 File Offset: 0x00169DA5
		// (set) Token: 0x060089C1 RID: 35265 RVA: 0x0016BBAD File Offset: 0x00169DAD
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

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x060089C2 RID: 35266 RVA: 0x0016BBB6 File Offset: 0x00169DB6
		// (set) Token: 0x060089C3 RID: 35267 RVA: 0x0016BBBE File Offset: 0x00169DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x060089C4 RID: 35268 RVA: 0x0016BBC7 File Offset: 0x00169DC7
		// (set) Token: 0x060089C5 RID: 35269 RVA: 0x0016BBCF File Offset: 0x00169DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FJBICABJMKO
		{
			get
			{
				return this.fJBICABJMKO_;
			}
			set
			{
				this.fJBICABJMKO_ = value;
			}
		}

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x060089C6 RID: 35270 RVA: 0x0016BBD8 File Offset: 0x00169DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NGIKGHKMAHA> BMHGALCIECK
		{
			get
			{
				return this.bMHGALCIECK_;
			}
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x060089C7 RID: 35271 RVA: 0x0016BBE0 File Offset: 0x00169DE0
		// (set) Token: 0x060089C8 RID: 35272 RVA: 0x0016BBE8 File Offset: 0x00169DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float NLMOBJCCDEL
		{
			get
			{
				return this.nLMOBJCCDEL_;
			}
			set
			{
				this.nLMOBJCCDEL_ = value;
			}
		}

		// Token: 0x060089C9 RID: 35273 RVA: 0x0016BBF1 File Offset: 0x00169DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NNCOHNDNMJJ);
		}

		// Token: 0x060089CA RID: 35274 RVA: 0x0016BC00 File Offset: 0x00169E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NNCOHNDNMJJ other)
		{
			return other != null && (other == this || (this.Wave == other.Wave && this.ScoreId == other.ScoreId && this.FJBICABJMKO == other.FJBICABJMKO && this.bMHGALCIECK_.Equals(other.bMHGALCIECK_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.NLMOBJCCDEL, other.NLMOBJCCDEL) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089CB RID: 35275 RVA: 0x0016BC88 File Offset: 0x00169E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.FJBICABJMKO != 0U)
			{
				num ^= this.FJBICABJMKO.GetHashCode();
			}
			num ^= this.bMHGALCIECK_.GetHashCode();
			if (this.NLMOBJCCDEL != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.NLMOBJCCDEL);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060089CC RID: 35276 RVA: 0x0016BD27 File Offset: 0x00169F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060089CD RID: 35277 RVA: 0x0016BD2F File Offset: 0x00169F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089CE RID: 35278 RVA: 0x0016BD38 File Offset: 0x00169F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Wave != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Wave);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.FJBICABJMKO != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.FJBICABJMKO);
			}
			this.bMHGALCIECK_.WriteTo(ref output, NNCOHNDNMJJ._repeated_bMHGALCIECK_codec);
			if (this.NLMOBJCCDEL != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.NLMOBJCCDEL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089CF RID: 35279 RVA: 0x0016BDE0 File Offset: 0x00169FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Wave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.FJBICABJMKO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FJBICABJMKO);
			}
			num += this.bMHGALCIECK_.CalculateSize(NNCOHNDNMJJ._repeated_bMHGALCIECK_codec);
			if (this.NLMOBJCCDEL != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060089D0 RID: 35280 RVA: 0x0016BE74 File Offset: 0x0016A074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NNCOHNDNMJJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.FJBICABJMKO != 0U)
			{
				this.FJBICABJMKO = other.FJBICABJMKO;
			}
			this.bMHGALCIECK_.Add(other.bMHGALCIECK_);
			if (other.NLMOBJCCDEL != 0f)
			{
				this.NLMOBJCCDEL = other.NLMOBJCCDEL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060089D1 RID: 35281 RVA: 0x0016BF02 File Offset: 0x0016A102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089D2 RID: 35282 RVA: 0x0016BF0C File Offset: 0x0016A10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Wave = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.FJBICABJMKO = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						this.bMHGALCIECK_.AddEntriesFrom(ref input, NNCOHNDNMJJ._repeated_bMHGALCIECK_codec);
						continue;
					}
					if (num == 45U)
					{
						this.NLMOBJCCDEL = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034D0 RID: 13520
		private static readonly MessageParser<NNCOHNDNMJJ> _parser = new MessageParser<NNCOHNDNMJJ>(() => new NNCOHNDNMJJ());

		// Token: 0x040034D1 RID: 13521
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034D2 RID: 13522
		public const int WaveFieldNumber = 1;

		// Token: 0x040034D3 RID: 13523
		private uint wave_;

		// Token: 0x040034D4 RID: 13524
		public const int ScoreIdFieldNumber = 2;

		// Token: 0x040034D5 RID: 13525
		private uint scoreId_;

		// Token: 0x040034D6 RID: 13526
		public const int FJBICABJMKOFieldNumber = 3;

		// Token: 0x040034D7 RID: 13527
		private uint fJBICABJMKO_;

		// Token: 0x040034D8 RID: 13528
		public const int BMHGALCIECKFieldNumber = 4;

		// Token: 0x040034D9 RID: 13529
		private static readonly FieldCodec<NGIKGHKMAHA> _repeated_bMHGALCIECK_codec = FieldCodec.ForMessage<NGIKGHKMAHA>(34U, NGIKGHKMAHA.Parser);

		// Token: 0x040034DA RID: 13530
		private readonly RepeatedField<NGIKGHKMAHA> bMHGALCIECK_ = new RepeatedField<NGIKGHKMAHA>();

		// Token: 0x040034DB RID: 13531
		public const int NLMOBJCCDELFieldNumber = 5;

		// Token: 0x040034DC RID: 13532
		private float nLMOBJCCDEL_;
	}
}
