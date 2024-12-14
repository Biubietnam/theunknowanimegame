using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009A5 RID: 2469
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KHKLKHNGDOG : IMessage<KHKLKHNGDOG>, IMessage, IEquatable<KHKLKHNGDOG>, IDeepCloneable<KHKLKHNGDOG>, IBufferMessage
	{
		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06006E61 RID: 28257 RVA: 0x00126DFF File Offset: 0x00124FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KHKLKHNGDOG> Parser
		{
			get
			{
				return KHKLKHNGDOG._parser;
			}
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06006E62 RID: 28258 RVA: 0x00126E06 File Offset: 0x00125006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KHKLKHNGDOGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06006E63 RID: 28259 RVA: 0x00126E18 File Offset: 0x00125018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KHKLKHNGDOG.Descriptor;
			}
		}

		// Token: 0x06006E64 RID: 28260 RVA: 0x00126E1F File Offset: 0x0012501F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KHKLKHNGDOG()
		{
		}

		// Token: 0x06006E65 RID: 28261 RVA: 0x00126E34 File Offset: 0x00125034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KHKLKHNGDOG(KHKLKHNGDOG other) : this()
		{
			this.oMAIGFIHMOK_ = other.oMAIGFIHMOK_;
			this.fLGOOENCPIB_ = other.fLGOOENCPIB_.Clone();
			this.bBKJHABIOMI_ = other.bBKJHABIOMI_;
			this.eDIAHLBLDFM_ = other.eDIAHLBLDFM_;
			this.nMAKNJMFFJN_ = other.nMAKNJMFFJN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E66 RID: 28262 RVA: 0x00126E99 File Offset: 0x00125099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KHKLKHNGDOG Clone()
		{
			return new KHKLKHNGDOG(this);
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06006E67 RID: 28263 RVA: 0x00126EA1 File Offset: 0x001250A1
		// (set) Token: 0x06006E68 RID: 28264 RVA: 0x00126EA9 File Offset: 0x001250A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EOMGGDBKNFH OMAIGFIHMOK
		{
			get
			{
				return this.oMAIGFIHMOK_;
			}
			set
			{
				this.oMAIGFIHMOK_ = value;
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06006E69 RID: 28265 RVA: 0x00126EB2 File Offset: 0x001250B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PMPGCOMJKMM> FLGOOENCPIB
		{
			get
			{
				return this.fLGOOENCPIB_;
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x06006E6A RID: 28266 RVA: 0x00126EBA File Offset: 0x001250BA
		// (set) Token: 0x06006E6B RID: 28267 RVA: 0x00126EC2 File Offset: 0x001250C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BBKJHABIOMI
		{
			get
			{
				return this.bBKJHABIOMI_;
			}
			set
			{
				this.bBKJHABIOMI_ = value;
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x06006E6C RID: 28268 RVA: 0x00126ECB File Offset: 0x001250CB
		// (set) Token: 0x06006E6D RID: 28269 RVA: 0x00126ED3 File Offset: 0x001250D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DNJIJPCJIOD EDIAHLBLDFM
		{
			get
			{
				return this.eDIAHLBLDFM_;
			}
			set
			{
				this.eDIAHLBLDFM_ = value;
			}
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x00126EDC File Offset: 0x001250DC
		// (set) Token: 0x06006E6F RID: 28271 RVA: 0x00126EE4 File Offset: 0x001250E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NMAKNJMFFJN
		{
			get
			{
				return this.nMAKNJMFFJN_;
			}
			set
			{
				this.nMAKNJMFFJN_ = value;
			}
		}

		// Token: 0x06006E70 RID: 28272 RVA: 0x00126EED File Offset: 0x001250ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KHKLKHNGDOG);
		}

		// Token: 0x06006E71 RID: 28273 RVA: 0x00126EFC File Offset: 0x001250FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KHKLKHNGDOG other)
		{
			return other != null && (other == this || (this.OMAIGFIHMOK == other.OMAIGFIHMOK && this.fLGOOENCPIB_.Equals(other.fLGOOENCPIB_) && this.BBKJHABIOMI == other.BBKJHABIOMI && this.EDIAHLBLDFM == other.EDIAHLBLDFM && this.NMAKNJMFFJN == other.NMAKNJMFFJN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E72 RID: 28274 RVA: 0x00126F7C File Offset: 0x0012517C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OMAIGFIHMOK != EOMGGDBKNFH.PageNone)
			{
				num ^= this.OMAIGFIHMOK.GetHashCode();
			}
			num ^= this.fLGOOENCPIB_.GetHashCode();
			if (this.BBKJHABIOMI != 0U)
			{
				num ^= this.BBKJHABIOMI.GetHashCode();
			}
			if (this.EDIAHLBLDFM != DNJIJPCJIOD.PageDescNone)
			{
				num ^= this.EDIAHLBLDFM.GetHashCode();
			}
			if (this.NMAKNJMFFJN != 0U)
			{
				num ^= this.NMAKNJMFFJN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E73 RID: 28275 RVA: 0x00127020 File Offset: 0x00125220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E74 RID: 28276 RVA: 0x00127028 File Offset: 0x00125228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x00127034 File Offset: 0x00125234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BBKJHABIOMI != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BBKJHABIOMI);
			}
			this.fLGOOENCPIB_.WriteTo(ref output, KHKLKHNGDOG._repeated_fLGOOENCPIB_codec);
			if (this.NMAKNJMFFJN != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.NMAKNJMFFJN);
			}
			if (this.OMAIGFIHMOK != EOMGGDBKNFH.PageNone)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.OMAIGFIHMOK);
			}
			if (this.EDIAHLBLDFM != DNJIJPCJIOD.PageDescNone)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.EDIAHLBLDFM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E76 RID: 28278 RVA: 0x001270D8 File Offset: 0x001252D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OMAIGFIHMOK != EOMGGDBKNFH.PageNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OMAIGFIHMOK);
			}
			num += this.fLGOOENCPIB_.CalculateSize(KHKLKHNGDOG._repeated_fLGOOENCPIB_codec);
			if (this.BBKJHABIOMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BBKJHABIOMI);
			}
			if (this.EDIAHLBLDFM != DNJIJPCJIOD.PageDescNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EDIAHLBLDFM);
			}
			if (this.NMAKNJMFFJN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NMAKNJMFFJN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x00127174 File Offset: 0x00125374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KHKLKHNGDOG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OMAIGFIHMOK != EOMGGDBKNFH.PageNone)
			{
				this.OMAIGFIHMOK = other.OMAIGFIHMOK;
			}
			this.fLGOOENCPIB_.Add(other.fLGOOENCPIB_);
			if (other.BBKJHABIOMI != 0U)
			{
				this.BBKJHABIOMI = other.BBKJHABIOMI;
			}
			if (other.EDIAHLBLDFM != DNJIJPCJIOD.PageDescNone)
			{
				this.EDIAHLBLDFM = other.EDIAHLBLDFM;
			}
			if (other.NMAKNJMFFJN != 0U)
			{
				this.NMAKNJMFFJN = other.NMAKNJMFFJN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E78 RID: 28280 RVA: 0x001271FD File Offset: 0x001253FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E79 RID: 28281 RVA: 0x00127208 File Offset: 0x00125408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 16U)
					{
						this.BBKJHABIOMI = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						this.fLGOOENCPIB_.AddEntriesFrom(ref input, KHKLKHNGDOG._repeated_fLGOOENCPIB_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.NMAKNJMFFJN = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.OMAIGFIHMOK = (EOMGGDBKNFH)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.EDIAHLBLDFM = (DNJIJPCJIOD)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A62 RID: 10850
		private static readonly MessageParser<KHKLKHNGDOG> _parser = new MessageParser<KHKLKHNGDOG>(() => new KHKLKHNGDOG());

		// Token: 0x04002A63 RID: 10851
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A64 RID: 10852
		public const int OMAIGFIHMOKFieldNumber = 14;

		// Token: 0x04002A65 RID: 10853
		private EOMGGDBKNFH oMAIGFIHMOK_;

		// Token: 0x04002A66 RID: 10854
		public const int FLGOOENCPIBFieldNumber = 4;

		// Token: 0x04002A67 RID: 10855
		private static readonly FieldCodec<PMPGCOMJKMM> _repeated_fLGOOENCPIB_codec = FieldCodec.ForMessage<PMPGCOMJKMM>(34U, PMPGCOMJKMM.Parser);

		// Token: 0x04002A68 RID: 10856
		private readonly RepeatedField<PMPGCOMJKMM> fLGOOENCPIB_ = new RepeatedField<PMPGCOMJKMM>();

		// Token: 0x04002A69 RID: 10857
		public const int BBKJHABIOMIFieldNumber = 2;

		// Token: 0x04002A6A RID: 10858
		private uint bBKJHABIOMI_;

		// Token: 0x04002A6B RID: 10859
		public const int EDIAHLBLDFMFieldNumber = 15;

		// Token: 0x04002A6C RID: 10860
		private DNJIJPCJIOD eDIAHLBLDFM_;

		// Token: 0x04002A6D RID: 10861
		public const int NMAKNJMFFJNFieldNumber = 9;

		// Token: 0x04002A6E RID: 10862
		private uint nMAKNJMFFJN_;
	}
}
