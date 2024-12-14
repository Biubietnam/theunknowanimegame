using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000401 RID: 1025
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EHOJLJMGOGL : IMessage<EHOJLJMGOGL>, IMessage, IEquatable<EHOJLJMGOGL>, IDeepCloneable<EHOJLJMGOGL>, IBufferMessage
	{
		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x0007DCDF File Offset: 0x0007BEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EHOJLJMGOGL> Parser
		{
			get
			{
				return EHOJLJMGOGL._parser;
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06002D78 RID: 11640 RVA: 0x0007DCE6 File Offset: 0x0007BEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EHOJLJMGOGLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x0007DCF8 File Offset: 0x0007BEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EHOJLJMGOGL.Descriptor;
			}
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x0007DCFF File Offset: 0x0007BEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EHOJLJMGOGL()
		{
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x0007DD14 File Offset: 0x0007BF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EHOJLJMGOGL(EHOJLJMGOGL other) : this()
		{
			this.nAGBMPFECGG_ = other.nAGBMPFECGG_;
			this.monsterId_ = other.monsterId_;
			this.hCKOMMJEOEK_ = other.hCKOMMJEOEK_.Clone();
			this.nLMOBJCCDEL_ = other.nLMOBJCCDEL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x0007DD6D File Offset: 0x0007BF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EHOJLJMGOGL Clone()
		{
			return new EHOJLJMGOGL(this);
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x0007DD75 File Offset: 0x0007BF75
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x0007DD7D File Offset: 0x0007BF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NAGBMPFECGG
		{
			get
			{
				return this.nAGBMPFECGG_;
			}
			set
			{
				this.nAGBMPFECGG_ = value;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x0007DD86 File Offset: 0x0007BF86
		// (set) Token: 0x06002D80 RID: 11648 RVA: 0x0007DD8E File Offset: 0x0007BF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x0007DD97 File Offset: 0x0007BF97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NEKKDMCDGPK> HCKOMMJEOEK
		{
			get
			{
				return this.hCKOMMJEOEK_;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x0007DD9F File Offset: 0x0007BF9F
		// (set) Token: 0x06002D83 RID: 11651 RVA: 0x0007DDA7 File Offset: 0x0007BFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NLMOBJCCDEL
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

		// Token: 0x06002D84 RID: 11652 RVA: 0x0007DDB0 File Offset: 0x0007BFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EHOJLJMGOGL);
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x0007DDC0 File Offset: 0x0007BFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EHOJLJMGOGL other)
		{
			return other != null && (other == this || (this.NAGBMPFECGG == other.NAGBMPFECGG && this.MonsterId == other.MonsterId && this.hCKOMMJEOEK_.Equals(other.hCKOMMJEOEK_) && this.NLMOBJCCDEL == other.NLMOBJCCDEL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x0007DE30 File Offset: 0x0007C030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NAGBMPFECGG != 0U)
			{
				num ^= this.NAGBMPFECGG.GetHashCode();
			}
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			num ^= this.hCKOMMJEOEK_.GetHashCode();
			if (this.NLMOBJCCDEL != 0U)
			{
				num ^= this.NLMOBJCCDEL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x0007DEAF File Offset: 0x0007C0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x0007DEB7 File Offset: 0x0007C0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x0007DEC0 File Offset: 0x0007C0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NAGBMPFECGG != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.NAGBMPFECGG);
			}
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MonsterId);
			}
			this.hCKOMMJEOEK_.WriteTo(ref output, EHOJLJMGOGL._repeated_hCKOMMJEOEK_codec);
			if (this.NLMOBJCCDEL != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.NLMOBJCCDEL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x0007DF48 File Offset: 0x0007C148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NAGBMPFECGG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NAGBMPFECGG);
			}
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			num += this.hCKOMMJEOEK_.CalculateSize(EHOJLJMGOGL._repeated_hCKOMMJEOEK_codec);
			if (this.NLMOBJCCDEL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NLMOBJCCDEL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x0007DFCC File Offset: 0x0007C1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EHOJLJMGOGL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NAGBMPFECGG != 0U)
			{
				this.NAGBMPFECGG = other.NAGBMPFECGG;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			this.hCKOMMJEOEK_.Add(other.hCKOMMJEOEK_);
			if (other.NLMOBJCCDEL != 0U)
			{
				this.NLMOBJCCDEL = other.NLMOBJCCDEL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x0007E041 File Offset: 0x0007C241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x0007E04C File Offset: 0x0007C24C
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
						this.NAGBMPFECGG = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.MonsterId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.hCKOMMJEOEK_.AddEntriesFrom(ref input, EHOJLJMGOGL._repeated_hCKOMMJEOEK_codec);
						continue;
					}
					if (num == 32U)
					{
						this.NLMOBJCCDEL = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400124E RID: 4686
		private static readonly MessageParser<EHOJLJMGOGL> _parser = new MessageParser<EHOJLJMGOGL>(() => new EHOJLJMGOGL());

		// Token: 0x0400124F RID: 4687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001250 RID: 4688
		public const int NAGBMPFECGGFieldNumber = 1;

		// Token: 0x04001251 RID: 4689
		private uint nAGBMPFECGG_;

		// Token: 0x04001252 RID: 4690
		public const int MonsterIdFieldNumber = 2;

		// Token: 0x04001253 RID: 4691
		private uint monsterId_;

		// Token: 0x04001254 RID: 4692
		public const int HCKOMMJEOEKFieldNumber = 3;

		// Token: 0x04001255 RID: 4693
		private static readonly FieldCodec<NEKKDMCDGPK> _repeated_hCKOMMJEOEK_codec = FieldCodec.ForMessage<NEKKDMCDGPK>(26U, NEKKDMCDGPK.Parser);

		// Token: 0x04001256 RID: 4694
		private readonly RepeatedField<NEKKDMCDGPK> hCKOMMJEOEK_ = new RepeatedField<NEKKDMCDGPK>();

		// Token: 0x04001257 RID: 4695
		public const int NLMOBJCCDELFieldNumber = 4;

		// Token: 0x04001258 RID: 4696
		private uint nLMOBJCCDEL_;
	}
}
