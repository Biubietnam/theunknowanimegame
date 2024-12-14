using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000855 RID: 2133
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GFIBLHPDGNE : IMessage<GFIBLHPDGNE>, IMessage, IEquatable<GFIBLHPDGNE>, IDeepCloneable<GFIBLHPDGNE>, IBufferMessage
	{
		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x06005ED3 RID: 24275 RVA: 0x000FAE9B File Offset: 0x000F909B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GFIBLHPDGNE> Parser
		{
			get
			{
				return GFIBLHPDGNE._parser;
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06005ED4 RID: 24276 RVA: 0x000FAEA2 File Offset: 0x000F90A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GFIBLHPDGNEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06005ED5 RID: 24277 RVA: 0x000FAEB4 File Offset: 0x000F90B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GFIBLHPDGNE.Descriptor;
			}
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x000FAEBB File Offset: 0x000F90BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GFIBLHPDGNE()
		{
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x000FAED0 File Offset: 0x000F90D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GFIBLHPDGNE(GFIBLHPDGNE other) : this()
		{
			this.dDDJFPIOPFB_ = other.dDDJFPIOPFB_;
			this.lILOPAJMFMM_ = other.lILOPAJMFMM_;
			this.pHLFJPFKFOF_ = other.pHLFJPFKFOF_;
			this.oOJEAFPOLAG_ = other.oOJEAFPOLAG_;
			this.nDEDBBCHHOO_ = other.nDEDBBCHHOO_.Clone();
			this.oIIJGEKJNGL_ = other.oIIJGEKJNGL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x000FAF41 File Offset: 0x000F9141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GFIBLHPDGNE Clone()
		{
			return new GFIBLHPDGNE(this);
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06005ED9 RID: 24281 RVA: 0x000FAF49 File Offset: 0x000F9149
		// (set) Token: 0x06005EDA RID: 24282 RVA: 0x000FAF51 File Offset: 0x000F9151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DDDJFPIOPFB
		{
			get
			{
				return this.dDDJFPIOPFB_;
			}
			set
			{
				this.dDDJFPIOPFB_ = value;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06005EDB RID: 24283 RVA: 0x000FAF5A File Offset: 0x000F915A
		// (set) Token: 0x06005EDC RID: 24284 RVA: 0x000FAF62 File Offset: 0x000F9162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LILOPAJMFMM
		{
			get
			{
				return this.lILOPAJMFMM_;
			}
			set
			{
				this.lILOPAJMFMM_ = value;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06005EDD RID: 24285 RVA: 0x000FAF6B File Offset: 0x000F916B
		// (set) Token: 0x06005EDE RID: 24286 RVA: 0x000FAF73 File Offset: 0x000F9173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHLFJPFKFOF
		{
			get
			{
				return this.pHLFJPFKFOF_;
			}
			set
			{
				this.pHLFJPFKFOF_ = value;
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06005EDF RID: 24287 RVA: 0x000FAF7C File Offset: 0x000F917C
		// (set) Token: 0x06005EE0 RID: 24288 RVA: 0x000FAF84 File Offset: 0x000F9184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OOJEAFPOLAG
		{
			get
			{
				return this.oOJEAFPOLAG_;
			}
			set
			{
				this.oOJEAFPOLAG_ = value;
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06005EE1 RID: 24289 RVA: 0x000FAF8D File Offset: 0x000F918D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ABNNODDPNDM> NDEDBBCHHOO
		{
			get
			{
				return this.nDEDBBCHHOO_;
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x06005EE2 RID: 24290 RVA: 0x000FAF95 File Offset: 0x000F9195
		// (set) Token: 0x06005EE3 RID: 24291 RVA: 0x000FAF9D File Offset: 0x000F919D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OIIJGEKJNGL
		{
			get
			{
				return this.oIIJGEKJNGL_;
			}
			set
			{
				this.oIIJGEKJNGL_ = value;
			}
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x000FAFA6 File Offset: 0x000F91A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GFIBLHPDGNE);
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x000FAFB4 File Offset: 0x000F91B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GFIBLHPDGNE other)
		{
			return other != null && (other == this || (this.DDDJFPIOPFB == other.DDDJFPIOPFB && this.LILOPAJMFMM == other.LILOPAJMFMM && this.PHLFJPFKFOF == other.PHLFJPFKFOF && this.OOJEAFPOLAG == other.OOJEAFPOLAG && this.nDEDBBCHHOO_.Equals(other.nDEDBBCHHOO_) && this.OIIJGEKJNGL == other.OIIJGEKJNGL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x000FB044 File Offset: 0x000F9244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DDDJFPIOPFB != 0U)
			{
				num ^= this.DDDJFPIOPFB.GetHashCode();
			}
			if (this.LILOPAJMFMM != 0U)
			{
				num ^= this.LILOPAJMFMM.GetHashCode();
			}
			if (this.PHLFJPFKFOF != 0U)
			{
				num ^= this.PHLFJPFKFOF.GetHashCode();
			}
			if (this.OOJEAFPOLAG != 0U)
			{
				num ^= this.OOJEAFPOLAG.GetHashCode();
			}
			num ^= this.nDEDBBCHHOO_.GetHashCode();
			if (this.OIIJGEKJNGL != 0U)
			{
				num ^= this.OIIJGEKJNGL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x000FB0F5 File Offset: 0x000F92F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x000FB0FD File Offset: 0x000F92FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EE9 RID: 24297 RVA: 0x000FB108 File Offset: 0x000F9308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OOJEAFPOLAG != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.OOJEAFPOLAG);
			}
			if (this.DDDJFPIOPFB != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.DDDJFPIOPFB);
			}
			if (this.PHLFJPFKFOF != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PHLFJPFKFOF);
			}
			if (this.LILOPAJMFMM != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.LILOPAJMFMM);
			}
			this.nDEDBBCHHOO_.WriteTo(ref output, GFIBLHPDGNE._repeated_nDEDBBCHHOO_codec);
			if (this.OIIJGEKJNGL != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.OIIJGEKJNGL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x000FB1C8 File Offset: 0x000F93C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DDDJFPIOPFB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DDDJFPIOPFB);
			}
			if (this.LILOPAJMFMM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LILOPAJMFMM);
			}
			if (this.PHLFJPFKFOF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHLFJPFKFOF);
			}
			if (this.OOJEAFPOLAG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OOJEAFPOLAG);
			}
			num += this.nDEDBBCHHOO_.CalculateSize(GFIBLHPDGNE._repeated_nDEDBBCHHOO_codec);
			if (this.OIIJGEKJNGL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OIIJGEKJNGL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x000FB27C File Offset: 0x000F947C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GFIBLHPDGNE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DDDJFPIOPFB != 0U)
			{
				this.DDDJFPIOPFB = other.DDDJFPIOPFB;
			}
			if (other.LILOPAJMFMM != 0U)
			{
				this.LILOPAJMFMM = other.LILOPAJMFMM;
			}
			if (other.PHLFJPFKFOF != 0U)
			{
				this.PHLFJPFKFOF = other.PHLFJPFKFOF;
			}
			if (other.OOJEAFPOLAG != 0U)
			{
				this.OOJEAFPOLAG = other.OOJEAFPOLAG;
			}
			this.nDEDBBCHHOO_.Add(other.nDEDBBCHHOO_);
			if (other.OIIJGEKJNGL != 0U)
			{
				this.OIIJGEKJNGL = other.OIIJGEKJNGL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x000FB319 File Offset: 0x000F9519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x000FB324 File Offset: 0x000F9524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.OOJEAFPOLAG = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.DDDJFPIOPFB = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.PHLFJPFKFOF = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.LILOPAJMFMM = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						this.nDEDBBCHHOO_.AddEntriesFrom(ref input, GFIBLHPDGNE._repeated_nDEDBBCHHOO_codec);
						continue;
					}
					if (num == 120U)
					{
						this.OIIJGEKJNGL = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400247C RID: 9340
		private static readonly MessageParser<GFIBLHPDGNE> _parser = new MessageParser<GFIBLHPDGNE>(() => new GFIBLHPDGNE());

		// Token: 0x0400247D RID: 9341
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400247E RID: 9342
		public const int DDDJFPIOPFBFieldNumber = 5;

		// Token: 0x0400247F RID: 9343
		private uint dDDJFPIOPFB_;

		// Token: 0x04002480 RID: 9344
		public const int LILOPAJMFMMFieldNumber = 9;

		// Token: 0x04002481 RID: 9345
		private uint lILOPAJMFMM_;

		// Token: 0x04002482 RID: 9346
		public const int PHLFJPFKFOFFieldNumber = 6;

		// Token: 0x04002483 RID: 9347
		private uint pHLFJPFKFOF_;

		// Token: 0x04002484 RID: 9348
		public const int OOJEAFPOLAGFieldNumber = 4;

		// Token: 0x04002485 RID: 9349
		private uint oOJEAFPOLAG_;

		// Token: 0x04002486 RID: 9350
		public const int NDEDBBCHHOOFieldNumber = 11;

		// Token: 0x04002487 RID: 9351
		private static readonly FieldCodec<ABNNODDPNDM> _repeated_nDEDBBCHHOO_codec = FieldCodec.ForMessage<ABNNODDPNDM>(90U, ABNNODDPNDM.Parser);

		// Token: 0x04002488 RID: 9352
		private readonly RepeatedField<ABNNODDPNDM> nDEDBBCHHOO_ = new RepeatedField<ABNNODDPNDM>();

		// Token: 0x04002489 RID: 9353
		public const int OIIJGEKJNGLFieldNumber = 15;

		// Token: 0x0400248A RID: 9354
		private uint oIIJGEKJNGL_;
	}
}
