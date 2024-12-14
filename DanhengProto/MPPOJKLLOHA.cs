using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B9D RID: 2973
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MPPOJKLLOHA : IMessage<MPPOJKLLOHA>, IMessage, IEquatable<MPPOJKLLOHA>, IDeepCloneable<MPPOJKLLOHA>, IBufferMessage
	{
		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x060083AF RID: 33711 RVA: 0x0015BB00 File Offset: 0x00159D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MPPOJKLLOHA> Parser
		{
			get
			{
				return MPPOJKLLOHA._parser;
			}
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x060083B0 RID: 33712 RVA: 0x0015BB07 File Offset: 0x00159D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MPPOJKLLOHAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x060083B1 RID: 33713 RVA: 0x0015BB19 File Offset: 0x00159D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MPPOJKLLOHA.Descriptor;
			}
		}

		// Token: 0x060083B2 RID: 33714 RVA: 0x0015BB20 File Offset: 0x00159D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MPPOJKLLOHA()
		{
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x0015BB28 File Offset: 0x00159D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MPPOJKLLOHA(MPPOJKLLOHA other) : this()
		{
			this.kLKJAHFIBDP_ = other.kLKJAHFIBDP_;
			this.nILIJIOMJOL_ = other.nILIJIOMJOL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x0015BB59 File Offset: 0x00159D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MPPOJKLLOHA Clone()
		{
			return new MPPOJKLLOHA(this);
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x060083B5 RID: 33717 RVA: 0x0015BB61 File Offset: 0x00159D61
		// (set) Token: 0x060083B6 RID: 33718 RVA: 0x0015BB69 File Offset: 0x00159D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KLKJAHFIBDP
		{
			get
			{
				return this.kLKJAHFIBDP_;
			}
			set
			{
				this.kLKJAHFIBDP_ = value;
			}
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x060083B7 RID: 33719 RVA: 0x0015BB72 File Offset: 0x00159D72
		// (set) Token: 0x060083B8 RID: 33720 RVA: 0x0015BB7A File Offset: 0x00159D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NILIJIOMJOL
		{
			get
			{
				return this.nILIJIOMJOL_;
			}
			set
			{
				this.nILIJIOMJOL_ = value;
			}
		}

		// Token: 0x060083B9 RID: 33721 RVA: 0x0015BB83 File Offset: 0x00159D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MPPOJKLLOHA);
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x0015BB91 File Offset: 0x00159D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MPPOJKLLOHA other)
		{
			return other != null && (other == this || (this.KLKJAHFIBDP == other.KLKJAHFIBDP && this.NILIJIOMJOL == other.NILIJIOMJOL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083BB RID: 33723 RVA: 0x0015BBD0 File Offset: 0x00159DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KLKJAHFIBDP != 0U)
			{
				num ^= this.KLKJAHFIBDP.GetHashCode();
			}
			if (this.NILIJIOMJOL != 0U)
			{
				num ^= this.NILIJIOMJOL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x0015BC28 File Offset: 0x00159E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x0015BC30 File Offset: 0x00159E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083BE RID: 33726 RVA: 0x0015BC3C File Offset: 0x00159E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NILIJIOMJOL != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.NILIJIOMJOL);
			}
			if (this.KLKJAHFIBDP != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.KLKJAHFIBDP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083BF RID: 33727 RVA: 0x0015BC98 File Offset: 0x00159E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KLKJAHFIBDP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KLKJAHFIBDP);
			}
			if (this.NILIJIOMJOL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NILIJIOMJOL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x0015BCF0 File Offset: 0x00159EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MPPOJKLLOHA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KLKJAHFIBDP != 0U)
			{
				this.KLKJAHFIBDP = other.KLKJAHFIBDP;
			}
			if (other.NILIJIOMJOL != 0U)
			{
				this.NILIJIOMJOL = other.NILIJIOMJOL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x0015BD40 File Offset: 0x00159F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x0015BD4C File Offset: 0x00159F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.KLKJAHFIBDP = input.ReadUInt32();
					}
				}
				else
				{
					this.NILIJIOMJOL = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003263 RID: 12899
		private static readonly MessageParser<MPPOJKLLOHA> _parser = new MessageParser<MPPOJKLLOHA>(() => new MPPOJKLLOHA());

		// Token: 0x04003264 RID: 12900
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003265 RID: 12901
		public const int KLKJAHFIBDPFieldNumber = 13;

		// Token: 0x04003266 RID: 12902
		private uint kLKJAHFIBDP_;

		// Token: 0x04003267 RID: 12903
		public const int NILIJIOMJOLFieldNumber = 9;

		// Token: 0x04003268 RID: 12904
		private uint nILIJIOMJOL_;
	}
}
