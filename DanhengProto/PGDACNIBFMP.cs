using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C8F RID: 3215
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PGDACNIBFMP : IMessage<PGDACNIBFMP>, IMessage, IEquatable<PGDACNIBFMP>, IDeepCloneable<PGDACNIBFMP>, IBufferMessage
	{
		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x06008EF3 RID: 36595 RVA: 0x00179D6D File Offset: 0x00177F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PGDACNIBFMP> Parser
		{
			get
			{
				return PGDACNIBFMP._parser;
			}
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x06008EF4 RID: 36596 RVA: 0x00179D74 File Offset: 0x00177F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PGDACNIBFMPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x06008EF5 RID: 36597 RVA: 0x00179D86 File Offset: 0x00177F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PGDACNIBFMP.Descriptor;
			}
		}

		// Token: 0x06008EF6 RID: 36598 RVA: 0x00179D8D File Offset: 0x00177F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGDACNIBFMP()
		{
		}

		// Token: 0x06008EF7 RID: 36599 RVA: 0x00179DA0 File Offset: 0x00177FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGDACNIBFMP(PGDACNIBFMP other) : this()
		{
			this.dBKEFLILOEK_ = other.dBKEFLILOEK_.Clone();
			this.hPBOPHPGAHK_ = other.hPBOPHPGAHK_;
			this.bFJLLNDKNCJ_ = ((other.bFJLLNDKNCJ_ != null) ? other.bFJLLNDKNCJ_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EF8 RID: 36600 RVA: 0x00179DFD File Offset: 0x00177FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGDACNIBFMP Clone()
		{
			return new PGDACNIBFMP(this);
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x00179E05 File Offset: 0x00178005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> DBKEFLILOEK
		{
			get
			{
				return this.dBKEFLILOEK_;
			}
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x06008EFA RID: 36602 RVA: 0x00179E0D File Offset: 0x0017800D
		// (set) Token: 0x06008EFB RID: 36603 RVA: 0x00179E15 File Offset: 0x00178015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HPBOPHPGAHK
		{
			get
			{
				return this.hPBOPHPGAHK_;
			}
			set
			{
				this.hPBOPHPGAHK_ = value;
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x06008EFC RID: 36604 RVA: 0x00179E1E File Offset: 0x0017801E
		// (set) Token: 0x06008EFD RID: 36605 RVA: 0x00179E26 File Offset: 0x00178026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMLPKGJNAJK BFJLLNDKNCJ
		{
			get
			{
				return this.bFJLLNDKNCJ_;
			}
			set
			{
				this.bFJLLNDKNCJ_ = value;
			}
		}

		// Token: 0x06008EFE RID: 36606 RVA: 0x00179E2F File Offset: 0x0017802F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PGDACNIBFMP);
		}

		// Token: 0x06008EFF RID: 36607 RVA: 0x00179E40 File Offset: 0x00178040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PGDACNIBFMP other)
		{
			return other != null && (other == this || (this.dBKEFLILOEK_.Equals(other.dBKEFLILOEK_) && this.HPBOPHPGAHK == other.HPBOPHPGAHK && object.Equals(this.BFJLLNDKNCJ, other.BFJLLNDKNCJ) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x00179EA4 File Offset: 0x001780A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dBKEFLILOEK_.GetHashCode();
			if (this.HPBOPHPGAHK)
			{
				num ^= this.HPBOPHPGAHK.GetHashCode();
			}
			if (this.bFJLLNDKNCJ_ != null)
			{
				num ^= this.BFJLLNDKNCJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F01 RID: 36609 RVA: 0x00179F07 File Offset: 0x00178107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x00179F0F File Offset: 0x0017810F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x00179F18 File Offset: 0x00178118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dBKEFLILOEK_.WriteTo(ref output, PGDACNIBFMP._repeated_dBKEFLILOEK_codec);
			if (this.HPBOPHPGAHK)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.HPBOPHPGAHK);
			}
			if (this.bFJLLNDKNCJ_ != null)
			{
				output.WriteRawTag(202, 62);
				output.WriteMessage(this.BFJLLNDKNCJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x00179F88 File Offset: 0x00178188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dBKEFLILOEK_.CalculateSize(PGDACNIBFMP._repeated_dBKEFLILOEK_codec);
			if (this.HPBOPHPGAHK)
			{
				num += 2;
			}
			if (this.bFJLLNDKNCJ_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BFJLLNDKNCJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F05 RID: 36613 RVA: 0x00179FE8 File Offset: 0x001781E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PGDACNIBFMP other)
		{
			if (other == null)
			{
				return;
			}
			this.dBKEFLILOEK_.Add(other.dBKEFLILOEK_);
			if (other.HPBOPHPGAHK)
			{
				this.HPBOPHPGAHK = other.HPBOPHPGAHK;
			}
			if (other.bFJLLNDKNCJ_ != null)
			{
				if (this.bFJLLNDKNCJ_ == null)
				{
					this.BFJLLNDKNCJ = new EMLPKGJNAJK();
				}
				this.BFJLLNDKNCJ.MergeFrom(other.BFJLLNDKNCJ);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F06 RID: 36614 RVA: 0x0017A061 File Offset: 0x00178261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F07 RID: 36615 RVA: 0x0017A06C File Offset: 0x0017826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 8010U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.bFJLLNDKNCJ_ == null)
							{
								this.BFJLLNDKNCJ = new EMLPKGJNAJK();
							}
							input.ReadMessage(this.BFJLLNDKNCJ);
						}
					}
					else
					{
						this.HPBOPHPGAHK = input.ReadBool();
					}
				}
				else
				{
					this.dBKEFLILOEK_.AddEntriesFrom(ref input, PGDACNIBFMP._repeated_dBKEFLILOEK_codec);
				}
			}
		}

		// Token: 0x040036E9 RID: 14057
		private static readonly MessageParser<PGDACNIBFMP> _parser = new MessageParser<PGDACNIBFMP>(() => new PGDACNIBFMP());

		// Token: 0x040036EA RID: 14058
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036EB RID: 14059
		public const int DBKEFLILOEKFieldNumber = 1;

		// Token: 0x040036EC RID: 14060
		private static readonly FieldCodec<string> _repeated_dBKEFLILOEK_codec = FieldCodec.ForString(10U);

		// Token: 0x040036ED RID: 14061
		private readonly RepeatedField<string> dBKEFLILOEK_ = new RepeatedField<string>();

		// Token: 0x040036EE RID: 14062
		public const int HPBOPHPGAHKFieldNumber = 2;

		// Token: 0x040036EF RID: 14063
		private bool hPBOPHPGAHK_;

		// Token: 0x040036F0 RID: 14064
		public const int BFJLLNDKNCJFieldNumber = 1001;

		// Token: 0x040036F1 RID: 14065
		private EMLPKGJNAJK bFJLLNDKNCJ_;
	}
}
