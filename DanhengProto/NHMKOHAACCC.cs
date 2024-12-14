using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C1D RID: 3101
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NHMKOHAACCC : IMessage<NHMKOHAACCC>, IMessage, IEquatable<NHMKOHAACCC>, IDeepCloneable<NHMKOHAACCC>, IBufferMessage
	{
		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x06008961 RID: 35169 RVA: 0x0016ADEC File Offset: 0x00168FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NHMKOHAACCC> Parser
		{
			get
			{
				return NHMKOHAACCC._parser;
			}
		}

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x06008962 RID: 35170 RVA: 0x0016ADF3 File Offset: 0x00168FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NHMKOHAACCCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x06008963 RID: 35171 RVA: 0x0016AE05 File Offset: 0x00169005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NHMKOHAACCC.Descriptor;
			}
		}

		// Token: 0x06008964 RID: 35172 RVA: 0x0016AE0C File Offset: 0x0016900C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NHMKOHAACCC()
		{
		}

		// Token: 0x06008965 RID: 35173 RVA: 0x0016AE1F File Offset: 0x0016901F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NHMKOHAACCC(NHMKOHAACCC other) : this()
		{
			this.lMGOPDMMOAJ_ = other.lMGOPDMMOAJ_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008966 RID: 35174 RVA: 0x0016AE49 File Offset: 0x00169049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NHMKOHAACCC Clone()
		{
			return new NHMKOHAACCC(this);
		}

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x06008967 RID: 35175 RVA: 0x0016AE51 File Offset: 0x00169051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LMGOPDMMOAJ
		{
			get
			{
				return this.lMGOPDMMOAJ_;
			}
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x0016AE59 File Offset: 0x00169059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NHMKOHAACCC);
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x0016AE67 File Offset: 0x00169067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NHMKOHAACCC other)
		{
			return other != null && (other == this || (this.lMGOPDMMOAJ_.Equals(other.lMGOPDMMOAJ_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600896A RID: 35178 RVA: 0x0016AE9C File Offset: 0x0016909C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lMGOPDMMOAJ_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x0016AED0 File Offset: 0x001690D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600896C RID: 35180 RVA: 0x0016AED8 File Offset: 0x001690D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600896D RID: 35181 RVA: 0x0016AEE1 File Offset: 0x001690E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lMGOPDMMOAJ_.WriteTo(ref output, NHMKOHAACCC._repeated_lMGOPDMMOAJ_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600896E RID: 35182 RVA: 0x0016AF08 File Offset: 0x00169108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lMGOPDMMOAJ_.CalculateSize(NHMKOHAACCC._repeated_lMGOPDMMOAJ_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600896F RID: 35183 RVA: 0x0016AF41 File Offset: 0x00169141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NHMKOHAACCC other)
		{
			if (other == null)
			{
				return;
			}
			this.lMGOPDMMOAJ_.Add(other.lMGOPDMMOAJ_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008970 RID: 35184 RVA: 0x0016AF6F File Offset: 0x0016916F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008971 RID: 35185 RVA: 0x0016AF78 File Offset: 0x00169178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.lMGOPDMMOAJ_.AddEntriesFrom(ref input, NHMKOHAACCC._repeated_lMGOPDMMOAJ_codec);
				}
			}
		}

		// Token: 0x040034B1 RID: 13489
		private static readonly MessageParser<NHMKOHAACCC> _parser = new MessageParser<NHMKOHAACCC>(() => new NHMKOHAACCC());

		// Token: 0x040034B2 RID: 13490
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034B3 RID: 13491
		public const int LMGOPDMMOAJFieldNumber = 8;

		// Token: 0x040034B4 RID: 13492
		private static readonly FieldCodec<uint> _repeated_lMGOPDMMOAJ_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x040034B5 RID: 13493
		private readonly RepeatedField<uint> lMGOPDMMOAJ_ = new RepeatedField<uint>();
	}
}
