using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000903 RID: 2307
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HNPELFOBMFO : IMessage<HNPELFOBMFO>, IMessage, IEquatable<HNPELFOBMFO>, IDeepCloneable<HNPELFOBMFO>, IBufferMessage
	{
		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x060066E8 RID: 26344 RVA: 0x00112D09 File Offset: 0x00110F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HNPELFOBMFO> Parser
		{
			get
			{
				return HNPELFOBMFO._parser;
			}
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x060066E9 RID: 26345 RVA: 0x00112D10 File Offset: 0x00110F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HNPELFOBMFOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x060066EA RID: 26346 RVA: 0x00112D22 File Offset: 0x00110F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HNPELFOBMFO.Descriptor;
			}
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x00112D29 File Offset: 0x00110F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HNPELFOBMFO()
		{
		}

		// Token: 0x060066EC RID: 26348 RVA: 0x00112D3C File Offset: 0x00110F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HNPELFOBMFO(HNPELFOBMFO other) : this()
		{
			this.lJLFOINGCEE_ = other.lJLFOINGCEE_;
			this.eKCNOMIIEBM_ = other.eKCNOMIIEBM_;
			this.bCOCOKEPOLA_ = other.bCOCOKEPOLA_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x00112D89 File Offset: 0x00110F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HNPELFOBMFO Clone()
		{
			return new HNPELFOBMFO(this);
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x060066EE RID: 26350 RVA: 0x00112D91 File Offset: 0x00110F91
		// (set) Token: 0x060066EF RID: 26351 RVA: 0x00112D99 File Offset: 0x00110F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LJLFOINGCEE
		{
			get
			{
				return this.lJLFOINGCEE_;
			}
			set
			{
				this.lJLFOINGCEE_ = value;
			}
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x00112DA2 File Offset: 0x00110FA2
		// (set) Token: 0x060066F1 RID: 26353 RVA: 0x00112DAA File Offset: 0x00110FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EKCNOMIIEBM
		{
			get
			{
				return this.eKCNOMIIEBM_;
			}
			set
			{
				this.eKCNOMIIEBM_ = value;
			}
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x060066F2 RID: 26354 RVA: 0x00112DB3 File Offset: 0x00110FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BCOCOKEPOLA
		{
			get
			{
				return this.bCOCOKEPOLA_;
			}
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x00112DBB File Offset: 0x00110FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HNPELFOBMFO);
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x00112DCC File Offset: 0x00110FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HNPELFOBMFO other)
		{
			return other != null && (other == this || (this.LJLFOINGCEE == other.LJLFOINGCEE && this.EKCNOMIIEBM == other.EKCNOMIIEBM && this.bCOCOKEPOLA_.Equals(other.bCOCOKEPOLA_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x00112E2C File Offset: 0x0011102C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LJLFOINGCEE != 0U)
			{
				num ^= this.LJLFOINGCEE.GetHashCode();
			}
			if (this.EKCNOMIIEBM != 0U)
			{
				num ^= this.EKCNOMIIEBM.GetHashCode();
			}
			num ^= this.bCOCOKEPOLA_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x00112E92 File Offset: 0x00111092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x00112E9A File Offset: 0x0011109A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x00112EA4 File Offset: 0x001110A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bCOCOKEPOLA_.WriteTo(ref output, HNPELFOBMFO._repeated_bCOCOKEPOLA_codec);
			if (this.EKCNOMIIEBM != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.EKCNOMIIEBM);
			}
			if (this.LJLFOINGCEE != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.LJLFOINGCEE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x00112F10 File Offset: 0x00111110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LJLFOINGCEE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LJLFOINGCEE);
			}
			if (this.EKCNOMIIEBM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EKCNOMIIEBM);
			}
			num += this.bCOCOKEPOLA_.CalculateSize(HNPELFOBMFO._repeated_bCOCOKEPOLA_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x00112F7C File Offset: 0x0011117C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HNPELFOBMFO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LJLFOINGCEE != 0U)
			{
				this.LJLFOINGCEE = other.LJLFOINGCEE;
			}
			if (other.EKCNOMIIEBM != 0U)
			{
				this.EKCNOMIIEBM = other.EKCNOMIIEBM;
			}
			this.bCOCOKEPOLA_.Add(other.bCOCOKEPOLA_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x00112FDD File Offset: 0x001111DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x00112FE8 File Offset: 0x001111E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.bCOCOKEPOLA_.AddEntriesFrom(ref input, HNPELFOBMFO._repeated_bCOCOKEPOLA_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.EKCNOMIIEBM = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.LJLFOINGCEE = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002783 RID: 10115
		private static readonly MessageParser<HNPELFOBMFO> _parser = new MessageParser<HNPELFOBMFO>(() => new HNPELFOBMFO());

		// Token: 0x04002784 RID: 10116
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002785 RID: 10117
		public const int LJLFOINGCEEFieldNumber = 13;

		// Token: 0x04002786 RID: 10118
		private uint lJLFOINGCEE_;

		// Token: 0x04002787 RID: 10119
		public const int EKCNOMIIEBMFieldNumber = 9;

		// Token: 0x04002788 RID: 10120
		private uint eKCNOMIIEBM_;

		// Token: 0x04002789 RID: 10121
		public const int BCOCOKEPOLAFieldNumber = 4;

		// Token: 0x0400278A RID: 10122
		private static readonly FieldCodec<uint> _repeated_bCOCOKEPOLA_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x0400278B RID: 10123
		private readonly RepeatedField<uint> bCOCOKEPOLA_ = new RepeatedField<uint>();
	}
}
