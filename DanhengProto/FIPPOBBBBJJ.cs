using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005A9 RID: 1449
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FIPPOBBBBJJ : IMessage<FIPPOBBBBJJ>, IMessage, IEquatable<FIPPOBBBBJJ>, IDeepCloneable<FIPPOBBBBJJ>, IBufferMessage
	{
		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x000B0470 File Offset: 0x000AE670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FIPPOBBBBJJ> Parser
		{
			get
			{
				return FIPPOBBBBJJ._parser;
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060040B5 RID: 16565 RVA: 0x000B0477 File Offset: 0x000AE677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FIPPOBBBBJJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060040B6 RID: 16566 RVA: 0x000B0489 File Offset: 0x000AE689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FIPPOBBBBJJ.Descriptor;
			}
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x000B0490 File Offset: 0x000AE690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPPOBBBBJJ()
		{
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x000B04A3 File Offset: 0x000AE6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPPOBBBBJJ(FIPPOBBBBJJ other) : this()
		{
			this.hDKPFMDCCKG_ = other.hDKPFMDCCKG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x000B04CD File Offset: 0x000AE6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPPOBBBBJJ Clone()
		{
			return new FIPPOBBBBJJ(this);
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x000B04D5 File Offset: 0x000AE6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NABJDLFFNAF> HDKPFMDCCKG
		{
			get
			{
				return this.hDKPFMDCCKG_;
			}
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x000B04DD File Offset: 0x000AE6DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FIPPOBBBBJJ);
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x000B04EB File Offset: 0x000AE6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FIPPOBBBBJJ other)
		{
			return other != null && (other == this || (this.hDKPFMDCCKG_.Equals(other.hDKPFMDCCKG_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x000B0520 File Offset: 0x000AE720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hDKPFMDCCKG_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x000B0554 File Offset: 0x000AE754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x000B055C File Offset: 0x000AE75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x000B0565 File Offset: 0x000AE765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hDKPFMDCCKG_.WriteTo(ref output, FIPPOBBBBJJ._repeated_hDKPFMDCCKG_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x000B058C File Offset: 0x000AE78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hDKPFMDCCKG_.CalculateSize(FIPPOBBBBJJ._repeated_hDKPFMDCCKG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x000B05C5 File Offset: 0x000AE7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FIPPOBBBBJJ other)
		{
			if (other == null)
			{
				return;
			}
			this.hDKPFMDCCKG_.Add(other.hDKPFMDCCKG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x000B05F3 File Offset: 0x000AE7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x000B05FC File Offset: 0x000AE7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hDKPFMDCCKG_.AddEntriesFrom(ref input, FIPPOBBBBJJ._repeated_hDKPFMDCCKG_codec);
				}
			}
		}

		// Token: 0x040019AD RID: 6573
		private static readonly MessageParser<FIPPOBBBBJJ> _parser = new MessageParser<FIPPOBBBBJJ>(() => new FIPPOBBBBJJ());

		// Token: 0x040019AE RID: 6574
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019AF RID: 6575
		public const int HDKPFMDCCKGFieldNumber = 10;

		// Token: 0x040019B0 RID: 6576
		private static readonly FieldCodec<NABJDLFFNAF> _repeated_hDKPFMDCCKG_codec = FieldCodec.ForMessage<NABJDLFFNAF>(82U, NABJDLFFNAF.Parser);

		// Token: 0x040019B1 RID: 6577
		private readonly RepeatedField<NABJDLFFNAF> hDKPFMDCCKG_ = new RepeatedField<NABJDLFFNAF>();
	}
}
