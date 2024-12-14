using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005B1 RID: 1457
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FMDGFCNOKMN : IMessage<FMDGFCNOKMN>, IMessage, IEquatable<FMDGFCNOKMN>, IDeepCloneable<FMDGFCNOKMN>, IBufferMessage
	{
		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06004123 RID: 16675 RVA: 0x000B1909 File Offset: 0x000AFB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FMDGFCNOKMN> Parser
		{
			get
			{
				return FMDGFCNOKMN._parser;
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06004124 RID: 16676 RVA: 0x000B1910 File Offset: 0x000AFB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FMDGFCNOKMNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x000B1922 File Offset: 0x000AFB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FMDGFCNOKMN.Descriptor;
			}
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x000B1929 File Offset: 0x000AFB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FMDGFCNOKMN()
		{
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x000B1948 File Offset: 0x000AFB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FMDGFCNOKMN(FMDGFCNOKMN other) : this()
		{
			this.lOIEFKHFOBE_ = other.lOIEFKHFOBE_.Clone();
			this.iCECOGMBECA_ = other.iCECOGMBECA_;
			this.oLDHNGGKABL_ = other.oLDHNGGKABL_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x000B199A File Offset: 0x000AFB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FMDGFCNOKMN Clone()
		{
			return new FMDGFCNOKMN(this);
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06004129 RID: 16681 RVA: 0x000B19A2 File Offset: 0x000AFBA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LOIEFKHFOBE
		{
			get
			{
				return this.lOIEFKHFOBE_;
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x000B19AA File Offset: 0x000AFBAA
		// (set) Token: 0x0600412B RID: 16683 RVA: 0x000B19B2 File Offset: 0x000AFBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ICECOGMBECA
		{
			get
			{
				return this.iCECOGMBECA_;
			}
			set
			{
				this.iCECOGMBECA_ = value;
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x000B19BB File Offset: 0x000AFBBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OPEMMBHKCFD> OLDHNGGKABL
		{
			get
			{
				return this.oLDHNGGKABL_;
			}
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x000B19C3 File Offset: 0x000AFBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FMDGFCNOKMN);
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x000B19D4 File Offset: 0x000AFBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FMDGFCNOKMN other)
		{
			return other != null && (other == this || (this.lOIEFKHFOBE_.Equals(other.lOIEFKHFOBE_) && this.ICECOGMBECA == other.ICECOGMBECA && this.oLDHNGGKABL_.Equals(other.oLDHNGGKABL_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x000B1A38 File Offset: 0x000AFC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lOIEFKHFOBE_.GetHashCode();
			if (this.ICECOGMBECA != 0U)
			{
				num ^= this.ICECOGMBECA.GetHashCode();
			}
			num ^= this.oLDHNGGKABL_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x000B1A93 File Offset: 0x000AFC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x000B1A9B File Offset: 0x000AFC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x000B1AA4 File Offset: 0x000AFCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.oLDHNGGKABL_.WriteTo(ref output, FMDGFCNOKMN._repeated_oLDHNGGKABL_codec);
			this.lOIEFKHFOBE_.WriteTo(ref output, FMDGFCNOKMN._repeated_lOIEFKHFOBE_codec);
			if (this.ICECOGMBECA != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ICECOGMBECA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x000B1B04 File Offset: 0x000AFD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lOIEFKHFOBE_.CalculateSize(FMDGFCNOKMN._repeated_lOIEFKHFOBE_codec);
			if (this.ICECOGMBECA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ICECOGMBECA);
			}
			num += this.oLDHNGGKABL_.CalculateSize(FMDGFCNOKMN._repeated_oLDHNGGKABL_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x000B1B68 File Offset: 0x000AFD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FMDGFCNOKMN other)
		{
			if (other == null)
			{
				return;
			}
			this.lOIEFKHFOBE_.Add(other.lOIEFKHFOBE_);
			if (other.ICECOGMBECA != 0U)
			{
				this.ICECOGMBECA = other.ICECOGMBECA;
			}
			this.oLDHNGGKABL_.Add(other.oLDHNGGKABL_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x000B1BC6 File Offset: 0x000AFDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x000B1BD0 File Offset: 0x000AFDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 26U)
					{
						this.oLDHNGGKABL_.AddEntriesFrom(ref input, FMDGFCNOKMN._repeated_oLDHNGGKABL_codec);
						continue;
					}
					if (num == 40U)
					{
						goto IL_44;
					}
				}
				else
				{
					if (num == 42U)
					{
						goto IL_44;
					}
					if (num == 96U)
					{
						this.ICECOGMBECA = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_44:
				this.lOIEFKHFOBE_.AddEntriesFrom(ref input, FMDGFCNOKMN._repeated_lOIEFKHFOBE_codec);
			}
		}

		// Token: 0x040019DE RID: 6622
		private static readonly MessageParser<FMDGFCNOKMN> _parser = new MessageParser<FMDGFCNOKMN>(() => new FMDGFCNOKMN());

		// Token: 0x040019DF RID: 6623
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019E0 RID: 6624
		public const int LOIEFKHFOBEFieldNumber = 5;

		// Token: 0x040019E1 RID: 6625
		private static readonly FieldCodec<uint> _repeated_lOIEFKHFOBE_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040019E2 RID: 6626
		private readonly RepeatedField<uint> lOIEFKHFOBE_ = new RepeatedField<uint>();

		// Token: 0x040019E3 RID: 6627
		public const int ICECOGMBECAFieldNumber = 12;

		// Token: 0x040019E4 RID: 6628
		private uint iCECOGMBECA_;

		// Token: 0x040019E5 RID: 6629
		public const int OLDHNGGKABLFieldNumber = 3;

		// Token: 0x040019E6 RID: 6630
		private static readonly FieldCodec<OPEMMBHKCFD> _repeated_oLDHNGGKABL_codec = FieldCodec.ForMessage<OPEMMBHKCFD>(26U, OPEMMBHKCFD.Parser);

		// Token: 0x040019E7 RID: 6631
		private readonly RepeatedField<OPEMMBHKCFD> oLDHNGGKABL_ = new RepeatedField<OPEMMBHKCFD>();
	}
}
