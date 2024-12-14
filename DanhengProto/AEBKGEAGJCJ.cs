using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200004D RID: 77
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AEBKGEAGJCJ : IMessage<AEBKGEAGJCJ>, IMessage, IEquatable<AEBKGEAGJCJ>, IDeepCloneable<AEBKGEAGJCJ>, IBufferMessage
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00009BBF File Offset: 0x00007DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AEBKGEAGJCJ> Parser
		{
			get
			{
				return AEBKGEAGJCJ._parser;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00009BC6 File Offset: 0x00007DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AEBKGEAGJCJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00009BD8 File Offset: 0x00007DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AEBKGEAGJCJ.Descriptor;
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00009BDF File Offset: 0x00007DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AEBKGEAGJCJ()
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00009C14 File Offset: 0x00007E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AEBKGEAGJCJ(AEBKGEAGJCJ other) : this()
		{
			this.hJFIDJAHMJG_ = other.hJFIDJAHMJG_.Clone();
			this.fILMNFDLMNI_ = other.fILMNFDLMNI_.Clone();
			this.pJIMDPOODDJ_ = other.pJIMDPOODDJ_.Clone();
			this.pDBOKHNHPNA_ = other.pDBOKHNHPNA_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00009C7C File Offset: 0x00007E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AEBKGEAGJCJ Clone()
		{
			return new AEBKGEAGJCJ(this);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00009C84 File Offset: 0x00007E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HGGCNNJOEPH> HJFIDJAHMJG
		{
			get
			{
				return this.hJFIDJAHMJG_;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00009C8C File Offset: 0x00007E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OEDMPCBKCJD> FILMNFDLMNI
		{
			get
			{
				return this.fILMNFDLMNI_;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00009C94 File Offset: 0x00007E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PJIMDPOODDJ
		{
			get
			{
				return this.pJIMDPOODDJ_;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00009C9C File Offset: 0x00007E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogisticsScore> PDBOKHNHPNA
		{
			get
			{
				return this.pDBOKHNHPNA_;
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00009CA4 File Offset: 0x00007EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AEBKGEAGJCJ);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00009CB4 File Offset: 0x00007EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AEBKGEAGJCJ other)
		{
			return other != null && (other == this || (this.hJFIDJAHMJG_.Equals(other.hJFIDJAHMJG_) && this.fILMNFDLMNI_.Equals(other.fILMNFDLMNI_) && this.pJIMDPOODDJ_.Equals(other.pJIMDPOODDJ_) && this.pDBOKHNHPNA_.Equals(other.pDBOKHNHPNA_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00009D34 File Offset: 0x00007F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hJFIDJAHMJG_.GetHashCode();
			num ^= this.fILMNFDLMNI_.GetHashCode();
			num ^= this.pJIMDPOODDJ_.GetHashCode();
			num ^= this.pDBOKHNHPNA_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00009D92 File Offset: 0x00007F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00009D9A File Offset: 0x00007F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00009DA4 File Offset: 0x00007FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fILMNFDLMNI_.WriteTo(ref output, AEBKGEAGJCJ._repeated_fILMNFDLMNI_codec);
			this.pDBOKHNHPNA_.WriteTo(ref output, AEBKGEAGJCJ._repeated_pDBOKHNHPNA_codec);
			this.pJIMDPOODDJ_.WriteTo(ref output, AEBKGEAGJCJ._repeated_pJIMDPOODDJ_codec);
			this.hJFIDJAHMJG_.WriteTo(ref output, AEBKGEAGJCJ._repeated_hJFIDJAHMJG_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00009E0C File Offset: 0x0000800C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hJFIDJAHMJG_.CalculateSize(AEBKGEAGJCJ._repeated_hJFIDJAHMJG_codec);
			num += this.fILMNFDLMNI_.CalculateSize(AEBKGEAGJCJ._repeated_fILMNFDLMNI_codec);
			num += this.pJIMDPOODDJ_.CalculateSize(AEBKGEAGJCJ._repeated_pJIMDPOODDJ_codec);
			num += this.pDBOKHNHPNA_.CalculateSize(AEBKGEAGJCJ._repeated_pDBOKHNHPNA_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00009E80 File Offset: 0x00008080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AEBKGEAGJCJ other)
		{
			if (other == null)
			{
				return;
			}
			this.hJFIDJAHMJG_.Add(other.hJFIDJAHMJG_);
			this.fILMNFDLMNI_.Add(other.fILMNFDLMNI_);
			this.pJIMDPOODDJ_.Add(other.pJIMDPOODDJ_);
			this.pDBOKHNHPNA_.Add(other.pDBOKHNHPNA_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00009EEC File Offset: 0x000080EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00009EF8 File Offset: 0x000080F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 90U)
				{
					if (num == 74U)
					{
						this.fILMNFDLMNI_.AddEntriesFrom(ref input, AEBKGEAGJCJ._repeated_fILMNFDLMNI_codec);
						continue;
					}
					if (num == 90U)
					{
						this.pDBOKHNHPNA_.AddEntriesFrom(ref input, AEBKGEAGJCJ._repeated_pDBOKHNHPNA_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U || num == 106U)
					{
						this.pJIMDPOODDJ_.AddEntriesFrom(ref input, AEBKGEAGJCJ._repeated_pJIMDPOODDJ_codec);
						continue;
					}
					if (num == 114U)
					{
						this.hJFIDJAHMJG_.AddEntriesFrom(ref input, AEBKGEAGJCJ._repeated_hJFIDJAHMJG_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400011F RID: 287
		private static readonly MessageParser<AEBKGEAGJCJ> _parser = new MessageParser<AEBKGEAGJCJ>(() => new AEBKGEAGJCJ());

		// Token: 0x04000120 RID: 288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000121 RID: 289
		public const int HJFIDJAHMJGFieldNumber = 14;

		// Token: 0x04000122 RID: 290
		private static readonly FieldCodec<HGGCNNJOEPH> _repeated_hJFIDJAHMJG_codec = FieldCodec.ForMessage<HGGCNNJOEPH>(114U, HGGCNNJOEPH.Parser);

		// Token: 0x04000123 RID: 291
		private readonly RepeatedField<HGGCNNJOEPH> hJFIDJAHMJG_ = new RepeatedField<HGGCNNJOEPH>();

		// Token: 0x04000124 RID: 292
		public const int FILMNFDLMNIFieldNumber = 9;

		// Token: 0x04000125 RID: 293
		private static readonly FieldCodec<OEDMPCBKCJD> _repeated_fILMNFDLMNI_codec = FieldCodec.ForMessage<OEDMPCBKCJD>(74U, OEDMPCBKCJD.Parser);

		// Token: 0x04000126 RID: 294
		private readonly RepeatedField<OEDMPCBKCJD> fILMNFDLMNI_ = new RepeatedField<OEDMPCBKCJD>();

		// Token: 0x04000127 RID: 295
		public const int PJIMDPOODDJFieldNumber = 13;

		// Token: 0x04000128 RID: 296
		private static readonly FieldCodec<uint> _repeated_pJIMDPOODDJ_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04000129 RID: 297
		private readonly RepeatedField<uint> pJIMDPOODDJ_ = new RepeatedField<uint>();

		// Token: 0x0400012A RID: 298
		public const int PDBOKHNHPNAFieldNumber = 11;

		// Token: 0x0400012B RID: 299
		private static readonly FieldCodec<LogisticsScore> _repeated_pDBOKHNHPNA_codec = FieldCodec.ForMessage<LogisticsScore>(90U, LogisticsScore.Parser);

		// Token: 0x0400012C RID: 300
		private readonly RepeatedField<LogisticsScore> pDBOKHNHPNA_ = new RepeatedField<LogisticsScore>();
	}
}
