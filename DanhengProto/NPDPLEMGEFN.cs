using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C3B RID: 3131
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NPDPLEMGEFN : IMessage<NPDPLEMGEFN>, IMessage, IEquatable<NPDPLEMGEFN>, IDeepCloneable<NPDPLEMGEFN>, IBufferMessage
	{
		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x06008AD0 RID: 35536 RVA: 0x0016EABC File Offset: 0x0016CCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NPDPLEMGEFN> Parser
		{
			get
			{
				return NPDPLEMGEFN._parser;
			}
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x06008AD1 RID: 35537 RVA: 0x0016EAC3 File Offset: 0x0016CCC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NPDPLEMGEFNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x06008AD2 RID: 35538 RVA: 0x0016EAD5 File Offset: 0x0016CCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NPDPLEMGEFN.Descriptor;
			}
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x0016EADC File Offset: 0x0016CCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPDPLEMGEFN()
		{
		}

		// Token: 0x06008AD4 RID: 35540 RVA: 0x0016EAF0 File Offset: 0x0016CCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPDPLEMGEFN(NPDPLEMGEFN other) : this()
		{
			this.aLJCMLCLGDO_ = other.aLJCMLCLGDO_.Clone();
			this.pOHANHABPIG_ = other.pOHANHABPIG_;
			this.eKMJPPGFBIN_ = other.eKMJPPGFBIN_;
			this.jIIOJGOAEDD_ = other.jIIOJGOAEDD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x0016EB49 File Offset: 0x0016CD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPDPLEMGEFN Clone()
		{
			return new NPDPLEMGEFN(this);
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x06008AD6 RID: 35542 RVA: 0x0016EB51 File Offset: 0x0016CD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> ALJCMLCLGDO
		{
			get
			{
				return this.aLJCMLCLGDO_;
			}
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x06008AD7 RID: 35543 RVA: 0x0016EB59 File Offset: 0x0016CD59
		// (set) Token: 0x06008AD8 RID: 35544 RVA: 0x0016EB61 File Offset: 0x0016CD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POHANHABPIG
		{
			get
			{
				return this.pOHANHABPIG_;
			}
			set
			{
				this.pOHANHABPIG_ = value;
			}
		}

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x06008AD9 RID: 35545 RVA: 0x0016EB6A File Offset: 0x0016CD6A
		// (set) Token: 0x06008ADA RID: 35546 RVA: 0x0016EB72 File Offset: 0x0016CD72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EKMJPPGFBIN
		{
			get
			{
				return this.eKMJPPGFBIN_;
			}
			set
			{
				this.eKMJPPGFBIN_ = value;
			}
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x06008ADB RID: 35547 RVA: 0x0016EB7B File Offset: 0x0016CD7B
		// (set) Token: 0x06008ADC RID: 35548 RVA: 0x0016EB83 File Offset: 0x0016CD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JIIOJGOAEDD
		{
			get
			{
				return this.jIIOJGOAEDD_;
			}
			set
			{
				this.jIIOJGOAEDD_ = value;
			}
		}

		// Token: 0x06008ADD RID: 35549 RVA: 0x0016EB8C File Offset: 0x0016CD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPDPLEMGEFN);
		}

		// Token: 0x06008ADE RID: 35550 RVA: 0x0016EB9C File Offset: 0x0016CD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NPDPLEMGEFN other)
		{
			return other != null && (other == this || (this.ALJCMLCLGDO.Equals(other.ALJCMLCLGDO) && this.POHANHABPIG == other.POHANHABPIG && this.EKMJPPGFBIN == other.EKMJPPGFBIN && this.JIIOJGOAEDD == other.JIIOJGOAEDD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008ADF RID: 35551 RVA: 0x0016EC0C File Offset: 0x0016CE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ALJCMLCLGDO.GetHashCode();
			if (this.POHANHABPIG != 0U)
			{
				num ^= this.POHANHABPIG.GetHashCode();
			}
			if (this.EKMJPPGFBIN != 0U)
			{
				num ^= this.EKMJPPGFBIN.GetHashCode();
			}
			if (this.JIIOJGOAEDD != 0U)
			{
				num ^= this.JIIOJGOAEDD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x0016EC8B File Offset: 0x0016CE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008AE1 RID: 35553 RVA: 0x0016EC93 File Offset: 0x0016CE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x0016EC9C File Offset: 0x0016CE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aLJCMLCLGDO_.WriteTo(ref output, NPDPLEMGEFN._map_aLJCMLCLGDO_codec);
			if (this.POHANHABPIG != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.POHANHABPIG);
			}
			if (this.EKMJPPGFBIN != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EKMJPPGFBIN);
			}
			if (this.JIIOJGOAEDD != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.JIIOJGOAEDD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x0016ED24 File Offset: 0x0016CF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aLJCMLCLGDO_.CalculateSize(NPDPLEMGEFN._map_aLJCMLCLGDO_codec);
			if (this.POHANHABPIG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POHANHABPIG);
			}
			if (this.EKMJPPGFBIN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EKMJPPGFBIN);
			}
			if (this.JIIOJGOAEDD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JIIOJGOAEDD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x0016EDA8 File Offset: 0x0016CFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NPDPLEMGEFN other)
		{
			if (other == null)
			{
				return;
			}
			this.aLJCMLCLGDO_.MergeFrom(other.aLJCMLCLGDO_);
			if (other.POHANHABPIG != 0U)
			{
				this.POHANHABPIG = other.POHANHABPIG;
			}
			if (other.EKMJPPGFBIN != 0U)
			{
				this.EKMJPPGFBIN = other.EKMJPPGFBIN;
			}
			if (other.JIIOJGOAEDD != 0U)
			{
				this.JIIOJGOAEDD = other.JIIOJGOAEDD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x0016EE1D File Offset: 0x0016D01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x0016EE28 File Offset: 0x0016D028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.aLJCMLCLGDO_.AddEntriesFrom(ref input, NPDPLEMGEFN._map_aLJCMLCLGDO_codec);
						continue;
					}
					if (num == 16U)
					{
						this.POHANHABPIG = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.EKMJPPGFBIN = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.JIIOJGOAEDD = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003540 RID: 13632
		private static readonly MessageParser<NPDPLEMGEFN> _parser = new MessageParser<NPDPLEMGEFN>(() => new NPDPLEMGEFN());

		// Token: 0x04003541 RID: 13633
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003542 RID: 13634
		public const int ALJCMLCLGDOFieldNumber = 1;

		// Token: 0x04003543 RID: 13635
		private static readonly MapField<uint, uint>.Codec _map_aLJCMLCLGDO_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 10U);

		// Token: 0x04003544 RID: 13636
		private readonly MapField<uint, uint> aLJCMLCLGDO_ = new MapField<uint, uint>();

		// Token: 0x04003545 RID: 13637
		public const int POHANHABPIGFieldNumber = 2;

		// Token: 0x04003546 RID: 13638
		private uint pOHANHABPIG_;

		// Token: 0x04003547 RID: 13639
		public const int EKMJPPGFBINFieldNumber = 3;

		// Token: 0x04003548 RID: 13640
		private uint eKMJPPGFBIN_;

		// Token: 0x04003549 RID: 13641
		public const int JIIOJGOAEDDFieldNumber = 4;

		// Token: 0x0400354A RID: 13642
		private uint jIIOJGOAEDD_;
	}
}
