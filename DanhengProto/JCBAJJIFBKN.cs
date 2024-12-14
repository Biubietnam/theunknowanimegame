using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000959 RID: 2393
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JCBAJJIFBKN : IMessage<JCBAJJIFBKN>, IMessage, IEquatable<JCBAJJIFBKN>, IDeepCloneable<JCBAJJIFBKN>, IBufferMessage
	{
		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x06006AD6 RID: 27350 RVA: 0x0011CE5D File Offset: 0x0011B05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JCBAJJIFBKN> Parser
		{
			get
			{
				return JCBAJJIFBKN._parser;
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x06006AD7 RID: 27351 RVA: 0x0011CE64 File Offset: 0x0011B064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JCBAJJIFBKNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x06006AD8 RID: 27352 RVA: 0x0011CE76 File Offset: 0x0011B076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JCBAJJIFBKN.Descriptor;
			}
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x0011CE7D File Offset: 0x0011B07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JCBAJJIFBKN()
		{
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x0011CE85 File Offset: 0x0011B085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JCBAJJIFBKN(JCBAJJIFBKN other) : this()
		{
			this.pHHAHKBJLOB_ = other.pHHAHKBJLOB_;
			this.mGOCICCJGFE_ = other.mGOCICCJGFE_;
			this.nGOMMCJKOEM_ = other.nGOMMCJKOEM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x0011CEC2 File Offset: 0x0011B0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JCBAJJIFBKN Clone()
		{
			return new JCBAJJIFBKN(this);
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x06006ADC RID: 27356 RVA: 0x0011CECA File Offset: 0x0011B0CA
		// (set) Token: 0x06006ADD RID: 27357 RVA: 0x0011CED2 File Offset: 0x0011B0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHHAHKBJLOB
		{
			get
			{
				return this.pHHAHKBJLOB_;
			}
			set
			{
				this.pHHAHKBJLOB_ = value;
			}
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x06006ADE RID: 27358 RVA: 0x0011CEDB File Offset: 0x0011B0DB
		// (set) Token: 0x06006ADF RID: 27359 RVA: 0x0011CEE3 File Offset: 0x0011B0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MGOCICCJGFE
		{
			get
			{
				return this.mGOCICCJGFE_;
			}
			set
			{
				this.mGOCICCJGFE_ = value;
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x06006AE0 RID: 27360 RVA: 0x0011CEEC File Offset: 0x0011B0EC
		// (set) Token: 0x06006AE1 RID: 27361 RVA: 0x0011CEF4 File Offset: 0x0011B0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NGOMMCJKOEM
		{
			get
			{
				return this.nGOMMCJKOEM_;
			}
			set
			{
				this.nGOMMCJKOEM_ = value;
			}
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x0011CEFD File Offset: 0x0011B0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JCBAJJIFBKN);
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x0011CF0C File Offset: 0x0011B10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JCBAJJIFBKN other)
		{
			return other != null && (other == this || (this.PHHAHKBJLOB == other.PHHAHKBJLOB && this.MGOCICCJGFE == other.MGOCICCJGFE && this.NGOMMCJKOEM == other.NGOMMCJKOEM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x0011CF68 File Offset: 0x0011B168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PHHAHKBJLOB != 0U)
			{
				num ^= this.PHHAHKBJLOB.GetHashCode();
			}
			if (this.MGOCICCJGFE != 0U)
			{
				num ^= this.MGOCICCJGFE.GetHashCode();
			}
			if (this.NGOMMCJKOEM)
			{
				num ^= this.NGOMMCJKOEM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x0011CFD9 File Offset: 0x0011B1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x0011CFE1 File Offset: 0x0011B1E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x0011CFEC File Offset: 0x0011B1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PHHAHKBJLOB != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PHHAHKBJLOB);
			}
			if (this.NGOMMCJKOEM)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.NGOMMCJKOEM);
			}
			if (this.MGOCICCJGFE != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MGOCICCJGFE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x0011D064 File Offset: 0x0011B264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PHHAHKBJLOB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHHAHKBJLOB);
			}
			if (this.MGOCICCJGFE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MGOCICCJGFE);
			}
			if (this.NGOMMCJKOEM)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x0011D0C8 File Offset: 0x0011B2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JCBAJJIFBKN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PHHAHKBJLOB != 0U)
			{
				this.PHHAHKBJLOB = other.PHHAHKBJLOB;
			}
			if (other.MGOCICCJGFE != 0U)
			{
				this.MGOCICCJGFE = other.MGOCICCJGFE;
			}
			if (other.NGOMMCJKOEM)
			{
				this.NGOMMCJKOEM = other.NGOMMCJKOEM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x0011D12C File Offset: 0x0011B32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x0011D138 File Offset: 0x0011B338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 56U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MGOCICCJGFE = input.ReadUInt32();
						}
					}
					else
					{
						this.NGOMMCJKOEM = input.ReadBool();
					}
				}
				else
				{
					this.PHHAHKBJLOB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040028E4 RID: 10468
		private static readonly MessageParser<JCBAJJIFBKN> _parser = new MessageParser<JCBAJJIFBKN>(() => new JCBAJJIFBKN());

		// Token: 0x040028E5 RID: 10469
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028E6 RID: 10470
		public const int PHHAHKBJLOBFieldNumber = 2;

		// Token: 0x040028E7 RID: 10471
		private uint pHHAHKBJLOB_;

		// Token: 0x040028E8 RID: 10472
		public const int MGOCICCJGFEFieldNumber = 9;

		// Token: 0x040028E9 RID: 10473
		private uint mGOCICCJGFE_;

		// Token: 0x040028EA RID: 10474
		public const int NGOMMCJKOEMFieldNumber = 7;

		// Token: 0x040028EB RID: 10475
		private bool nGOMMCJKOEM_;
	}
}
