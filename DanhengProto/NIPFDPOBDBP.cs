using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C1F RID: 3103
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NIPFDPOBDBP : IMessage<NIPFDPOBDBP>, IMessage, IEquatable<NIPFDPOBDBP>, IDeepCloneable<NIPFDPOBDBP>, IBufferMessage
	{
		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x06008975 RID: 35189 RVA: 0x0016B079 File Offset: 0x00169279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NIPFDPOBDBP> Parser
		{
			get
			{
				return NIPFDPOBDBP._parser;
			}
		}

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x06008976 RID: 35190 RVA: 0x0016B080 File Offset: 0x00169280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NIPFDPOBDBPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x06008977 RID: 35191 RVA: 0x0016B092 File Offset: 0x00169292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NIPFDPOBDBP.Descriptor;
			}
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x0016B099 File Offset: 0x00169299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NIPFDPOBDBP()
		{
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x0016B0AC File Offset: 0x001692AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NIPFDPOBDBP(NIPFDPOBDBP other) : this()
		{
			this.optionId_ = other.optionId_;
			this.kFJCGMAFANN_ = other.kFJCGMAFANN_.Clone();
			this.bINLNAGFFEP_ = other.bINLNAGFFEP_;
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x0016B105 File Offset: 0x00169305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NIPFDPOBDBP Clone()
		{
			return new NIPFDPOBDBP(this);
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x0600897B RID: 35195 RVA: 0x0016B10D File Offset: 0x0016930D
		// (set) Token: 0x0600897C RID: 35196 RVA: 0x0016B115 File Offset: 0x00169315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionId
		{
			get
			{
				return this.optionId_;
			}
			set
			{
				this.optionId_ = value;
			}
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x0600897D RID: 35197 RVA: 0x0016B11E File Offset: 0x0016931E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KFJCGMAFANN
		{
			get
			{
				return this.kFJCGMAFANN_;
			}
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x0600897E RID: 35198 RVA: 0x0016B126 File Offset: 0x00169326
		// (set) Token: 0x0600897F RID: 35199 RVA: 0x0016B12E File Offset: 0x0016932E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BINLNAGFFEP
		{
			get
			{
				return this.bINLNAGFFEP_;
			}
			set
			{
				this.bINLNAGFFEP_ = value;
			}
		}

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x06008980 RID: 35200 RVA: 0x0016B137 File Offset: 0x00169337
		// (set) Token: 0x06008981 RID: 35201 RVA: 0x0016B13F File Offset: 0x0016933F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x0016B148 File Offset: 0x00169348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NIPFDPOBDBP);
		}

		// Token: 0x06008983 RID: 35203 RVA: 0x0016B158 File Offset: 0x00169358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NIPFDPOBDBP other)
		{
			return other != null && (other == this || (this.OptionId == other.OptionId && this.kFJCGMAFANN_.Equals(other.kFJCGMAFANN_) && this.BINLNAGFFEP == other.BINLNAGFFEP && this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008984 RID: 35204 RVA: 0x0016B1C8 File Offset: 0x001693C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OptionId != 0U)
			{
				num ^= this.OptionId.GetHashCode();
			}
			num ^= this.kFJCGMAFANN_.GetHashCode();
			if (this.BINLNAGFFEP != 0U)
			{
				num ^= this.BINLNAGFFEP.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008985 RID: 35205 RVA: 0x0016B247 File Offset: 0x00169447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x0016B24F File Offset: 0x0016944F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008987 RID: 35207 RVA: 0x0016B258 File Offset: 0x00169458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.OptionId);
			}
			if (this.BINLNAGFFEP != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.BINLNAGFFEP);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.EventId);
			}
			this.kFJCGMAFANN_.WriteTo(ref output, NIPFDPOBDBP._repeated_kFJCGMAFANN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x0016B2E0 File Offset: 0x001694E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OptionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionId);
			}
			num += this.kFJCGMAFANN_.CalculateSize(NIPFDPOBDBP._repeated_kFJCGMAFANN_codec);
			if (this.BINLNAGFFEP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BINLNAGFFEP);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x0016B364 File Offset: 0x00169564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NIPFDPOBDBP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OptionId != 0U)
			{
				this.OptionId = other.OptionId;
			}
			this.kFJCGMAFANN_.Add(other.kFJCGMAFANN_);
			if (other.BINLNAGFFEP != 0U)
			{
				this.BINLNAGFFEP = other.BINLNAGFFEP;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x0016B3D9 File Offset: 0x001695D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x0016B3E4 File Offset: 0x001695E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.OptionId = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BINLNAGFFEP = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.EventId = input.ReadUInt32();
						continue;
					}
					if (num == 88U || num == 90U)
					{
						this.kFJCGMAFANN_.AddEntriesFrom(ref input, NIPFDPOBDBP._repeated_kFJCGMAFANN_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034B7 RID: 13495
		private static readonly MessageParser<NIPFDPOBDBP> _parser = new MessageParser<NIPFDPOBDBP>(() => new NIPFDPOBDBP());

		// Token: 0x040034B8 RID: 13496
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034B9 RID: 13497
		public const int OptionIdFieldNumber = 1;

		// Token: 0x040034BA RID: 13498
		private uint optionId_;

		// Token: 0x040034BB RID: 13499
		public const int KFJCGMAFANNFieldNumber = 11;

		// Token: 0x040034BC RID: 13500
		private static readonly FieldCodec<uint> _repeated_kFJCGMAFANN_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x040034BD RID: 13501
		private readonly RepeatedField<uint> kFJCGMAFANN_ = new RepeatedField<uint>();

		// Token: 0x040034BE RID: 13502
		public const int BINLNAGFFEPFieldNumber = 4;

		// Token: 0x040034BF RID: 13503
		private uint bINLNAGFFEP_;

		// Token: 0x040034C0 RID: 13504
		public const int EventIdFieldNumber = 9;

		// Token: 0x040034C1 RID: 13505
		private uint eventId_;
	}
}
