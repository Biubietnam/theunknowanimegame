using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000957 RID: 2391
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JBPJHLMNHEG : IMessage<JBPJHLMNHEG>, IMessage, IEquatable<JBPJHLMNHEG>, IDeepCloneable<JBPJHLMNHEG>, IBufferMessage
	{
		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x06006AC2 RID: 27330 RVA: 0x0011CBD8 File Offset: 0x0011ADD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JBPJHLMNHEG> Parser
		{
			get
			{
				return JBPJHLMNHEG._parser;
			}
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06006AC3 RID: 27331 RVA: 0x0011CBDF File Offset: 0x0011ADDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JBPJHLMNHEGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x06006AC4 RID: 27332 RVA: 0x0011CBF1 File Offset: 0x0011ADF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JBPJHLMNHEG.Descriptor;
			}
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x0011CBF8 File Offset: 0x0011ADF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBPJHLMNHEG()
		{
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x0011CC0B File Offset: 0x0011AE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBPJHLMNHEG(JBPJHLMNHEG other) : this()
		{
			this.aIFEIFEPIGB_ = other.aIFEIFEPIGB_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x0011CC35 File Offset: 0x0011AE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBPJHLMNHEG Clone()
		{
			return new JBPJHLMNHEG(this);
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x06006AC8 RID: 27336 RVA: 0x0011CC3D File Offset: 0x0011AE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AIFEIFEPIGB
		{
			get
			{
				return this.aIFEIFEPIGB_;
			}
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x0011CC45 File Offset: 0x0011AE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JBPJHLMNHEG);
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x0011CC53 File Offset: 0x0011AE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JBPJHLMNHEG other)
		{
			return other != null && (other == this || (this.aIFEIFEPIGB_.Equals(other.aIFEIFEPIGB_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x0011CC88 File Offset: 0x0011AE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aIFEIFEPIGB_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x0011CCBC File Offset: 0x0011AEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x0011CCC4 File Offset: 0x0011AEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x0011CCCD File Offset: 0x0011AECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aIFEIFEPIGB_.WriteTo(ref output, JBPJHLMNHEG._repeated_aIFEIFEPIGB_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x0011CCF4 File Offset: 0x0011AEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aIFEIFEPIGB_.CalculateSize(JBPJHLMNHEG._repeated_aIFEIFEPIGB_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x0011CD2D File Offset: 0x0011AF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JBPJHLMNHEG other)
		{
			if (other == null)
			{
				return;
			}
			this.aIFEIFEPIGB_.Add(other.aIFEIFEPIGB_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x0011CD5B File Offset: 0x0011AF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x0011CD64 File Offset: 0x0011AF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.aIFEIFEPIGB_.AddEntriesFrom(ref input, JBPJHLMNHEG._repeated_aIFEIFEPIGB_codec);
				}
			}
		}

		// Token: 0x040028DE RID: 10462
		private static readonly MessageParser<JBPJHLMNHEG> _parser = new MessageParser<JBPJHLMNHEG>(() => new JBPJHLMNHEG());

		// Token: 0x040028DF RID: 10463
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028E0 RID: 10464
		public const int AIFEIFEPIGBFieldNumber = 5;

		// Token: 0x040028E1 RID: 10465
		private static readonly FieldCodec<uint> _repeated_aIFEIFEPIGB_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040028E2 RID: 10466
		private readonly RepeatedField<uint> aIFEIFEPIGB_ = new RepeatedField<uint>();
	}
}
