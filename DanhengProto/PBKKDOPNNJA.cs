using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C83 RID: 3203
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PBKKDOPNNJA : IMessage<PBKKDOPNNJA>, IMessage, IEquatable<PBKKDOPNNJA>, IDeepCloneable<PBKKDOPNNJA>, IBufferMessage
	{
		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x06008E57 RID: 36439 RVA: 0x0017808D File Offset: 0x0017628D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PBKKDOPNNJA> Parser
		{
			get
			{
				return PBKKDOPNNJA._parser;
			}
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x06008E58 RID: 36440 RVA: 0x00178094 File Offset: 0x00176294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PBKKDOPNNJAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x06008E59 RID: 36441 RVA: 0x001780A6 File Offset: 0x001762A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PBKKDOPNNJA.Descriptor;
			}
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x001780AD File Offset: 0x001762AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PBKKDOPNNJA()
		{
		}

		// Token: 0x06008E5B RID: 36443 RVA: 0x001780E4 File Offset: 0x001762E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PBKKDOPNNJA(PBKKDOPNNJA other) : this()
		{
			this.aNGGCHDGMBH_ = other.aNGGCHDGMBH_.Clone();
			this.aCBMBACFCCN_ = other.aCBMBACFCCN_.Clone();
			this.lFKJJABHKIO_ = other.lFKJJABHKIO_.Clone();
			this.fIJFIHENFBN_ = other.fIJFIHENFBN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E5C RID: 36444 RVA: 0x0017814C File Offset: 0x0017634C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PBKKDOPNNJA Clone()
		{
			return new PBKKDOPNNJA(this);
		}

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x06008E5D RID: 36445 RVA: 0x00178154 File Offset: 0x00176354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> ANGGCHDGMBH
		{
			get
			{
				return this.aNGGCHDGMBH_;
			}
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x06008E5E RID: 36446 RVA: 0x0017815C File Offset: 0x0017635C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> ACBMBACFCCN
		{
			get
			{
				return this.aCBMBACFCCN_;
			}
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x06008E5F RID: 36447 RVA: 0x00178164 File Offset: 0x00176364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FNJFGLPKKIJ> LFKJJABHKIO
		{
			get
			{
				return this.lFKJJABHKIO_;
			}
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x06008E60 RID: 36448 RVA: 0x0017816C File Offset: 0x0017636C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GDLKFOJLGMG> FIJFIHENFBN
		{
			get
			{
				return this.fIJFIHENFBN_;
			}
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x00178174 File Offset: 0x00176374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PBKKDOPNNJA);
		}

		// Token: 0x06008E62 RID: 36450 RVA: 0x00178184 File Offset: 0x00176384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PBKKDOPNNJA other)
		{
			return other != null && (other == this || (this.ANGGCHDGMBH.Equals(other.ANGGCHDGMBH) && this.ACBMBACFCCN.Equals(other.ACBMBACFCCN) && this.lFKJJABHKIO_.Equals(other.lFKJJABHKIO_) && this.fIJFIHENFBN_.Equals(other.fIJFIHENFBN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E63 RID: 36451 RVA: 0x00178204 File Offset: 0x00176404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ANGGCHDGMBH.GetHashCode();
			num ^= this.ACBMBACFCCN.GetHashCode();
			num ^= this.lFKJJABHKIO_.GetHashCode();
			num ^= this.fIJFIHENFBN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E64 RID: 36452 RVA: 0x00178262 File Offset: 0x00176462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E65 RID: 36453 RVA: 0x0017826A File Offset: 0x0017646A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E66 RID: 36454 RVA: 0x00178274 File Offset: 0x00176474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lFKJJABHKIO_.WriteTo(ref output, PBKKDOPNNJA._repeated_lFKJJABHKIO_codec);
			this.aCBMBACFCCN_.WriteTo(ref output, PBKKDOPNNJA._map_aCBMBACFCCN_codec);
			this.aNGGCHDGMBH_.WriteTo(ref output, PBKKDOPNNJA._map_aNGGCHDGMBH_codec);
			this.fIJFIHENFBN_.WriteTo(ref output, PBKKDOPNNJA._repeated_fIJFIHENFBN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E67 RID: 36455 RVA: 0x001782DC File Offset: 0x001764DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aNGGCHDGMBH_.CalculateSize(PBKKDOPNNJA._map_aNGGCHDGMBH_codec);
			num += this.aCBMBACFCCN_.CalculateSize(PBKKDOPNNJA._map_aCBMBACFCCN_codec);
			num += this.lFKJJABHKIO_.CalculateSize(PBKKDOPNNJA._repeated_lFKJJABHKIO_codec);
			num += this.fIJFIHENFBN_.CalculateSize(PBKKDOPNNJA._repeated_fIJFIHENFBN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E68 RID: 36456 RVA: 0x00178350 File Offset: 0x00176550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PBKKDOPNNJA other)
		{
			if (other == null)
			{
				return;
			}
			this.aNGGCHDGMBH_.MergeFrom(other.aNGGCHDGMBH_);
			this.aCBMBACFCCN_.MergeFrom(other.aCBMBACFCCN_);
			this.lFKJJABHKIO_.Add(other.lFKJJABHKIO_);
			this.fIJFIHENFBN_.Add(other.fIJFIHENFBN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E69 RID: 36457 RVA: 0x001783BC File Offset: 0x001765BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x001783C8 File Offset: 0x001765C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 42U)
					{
						this.lFKJJABHKIO_.AddEntriesFrom(ref input, PBKKDOPNNJA._repeated_lFKJJABHKIO_codec);
						continue;
					}
					if (num == 50U)
					{
						this.aCBMBACFCCN_.AddEntriesFrom(ref input, PBKKDOPNNJA._map_aCBMBACFCCN_codec);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.aNGGCHDGMBH_.AddEntriesFrom(ref input, PBKKDOPNNJA._map_aNGGCHDGMBH_codec);
						continue;
					}
					if (num == 122U)
					{
						this.fIJFIHENFBN_.AddEntriesFrom(ref input, PBKKDOPNNJA._repeated_fIJFIHENFBN_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040036A1 RID: 13985
		private static readonly MessageParser<PBKKDOPNNJA> _parser = new MessageParser<PBKKDOPNNJA>(() => new PBKKDOPNNJA());

		// Token: 0x040036A2 RID: 13986
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036A3 RID: 13987
		public const int ANGGCHDGMBHFieldNumber = 12;

		// Token: 0x040036A4 RID: 13988
		private static readonly MapField<uint, uint>.Codec _map_aNGGCHDGMBH_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 98U);

		// Token: 0x040036A5 RID: 13989
		private readonly MapField<uint, uint> aNGGCHDGMBH_ = new MapField<uint, uint>();

		// Token: 0x040036A6 RID: 13990
		public const int ACBMBACFCCNFieldNumber = 6;

		// Token: 0x040036A7 RID: 13991
		private static readonly MapField<uint, uint>.Codec _map_aCBMBACFCCN_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 50U);

		// Token: 0x040036A8 RID: 13992
		private readonly MapField<uint, uint> aCBMBACFCCN_ = new MapField<uint, uint>();

		// Token: 0x040036A9 RID: 13993
		public const int LFKJJABHKIOFieldNumber = 5;

		// Token: 0x040036AA RID: 13994
		private static readonly FieldCodec<FNJFGLPKKIJ> _repeated_lFKJJABHKIO_codec = FieldCodec.ForMessage<FNJFGLPKKIJ>(42U, FNJFGLPKKIJ.Parser);

		// Token: 0x040036AB RID: 13995
		private readonly RepeatedField<FNJFGLPKKIJ> lFKJJABHKIO_ = new RepeatedField<FNJFGLPKKIJ>();

		// Token: 0x040036AC RID: 13996
		public const int FIJFIHENFBNFieldNumber = 15;

		// Token: 0x040036AD RID: 13997
		private static readonly FieldCodec<GDLKFOJLGMG> _repeated_fIJFIHENFBN_codec = FieldCodec.ForMessage<GDLKFOJLGMG>(122U, GDLKFOJLGMG.Parser);

		// Token: 0x040036AE RID: 13998
		private readonly RepeatedField<GDLKFOJLGMG> fIJFIHENFBN_ = new RepeatedField<GDLKFOJLGMG>();
	}
}
