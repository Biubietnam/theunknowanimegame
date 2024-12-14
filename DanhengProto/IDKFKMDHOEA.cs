using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000919 RID: 2329
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IDKFKMDHOEA : IMessage<IDKFKMDHOEA>, IMessage, IEquatable<IDKFKMDHOEA>, IDeepCloneable<IDKFKMDHOEA>, IBufferMessage
	{
		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x060067DF RID: 26591 RVA: 0x001158E5 File Offset: 0x00113AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IDKFKMDHOEA> Parser
		{
			get
			{
				return IDKFKMDHOEA._parser;
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x060067E0 RID: 26592 RVA: 0x001158EC File Offset: 0x00113AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IDKFKMDHOEAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x001158FE File Offset: 0x00113AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IDKFKMDHOEA.Descriptor;
			}
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x00115905 File Offset: 0x00113B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDKFKMDHOEA()
		{
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x0011590D File Offset: 0x00113B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDKFKMDHOEA(IDKFKMDHOEA other) : this()
		{
			this.gMIADHCIJDO_ = other.gMIADHCIJDO_;
			this.gPNPIDKNPFL_ = other.gPNPIDKNPFL_;
			this.mJIIBAOPBPO_ = other.mJIIBAOPBPO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x0011594A File Offset: 0x00113B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDKFKMDHOEA Clone()
		{
			return new IDKFKMDHOEA(this);
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x060067E5 RID: 26597 RVA: 0x00115952 File Offset: 0x00113B52
		// (set) Token: 0x060067E6 RID: 26598 RVA: 0x0011595A File Offset: 0x00113B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GMIADHCIJDO
		{
			get
			{
				return this.gMIADHCIJDO_;
			}
			set
			{
				this.gMIADHCIJDO_ = value;
			}
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x060067E7 RID: 26599 RVA: 0x00115963 File Offset: 0x00113B63
		// (set) Token: 0x060067E8 RID: 26600 RVA: 0x0011596B File Offset: 0x00113B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GPNPIDKNPFL
		{
			get
			{
				return this.gPNPIDKNPFL_;
			}
			set
			{
				this.gPNPIDKNPFL_ = value;
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x060067E9 RID: 26601 RVA: 0x00115974 File Offset: 0x00113B74
		// (set) Token: 0x060067EA RID: 26602 RVA: 0x0011597C File Offset: 0x00113B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MJIIBAOPBPO
		{
			get
			{
				return this.mJIIBAOPBPO_;
			}
			set
			{
				this.mJIIBAOPBPO_ = value;
			}
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x00115985 File Offset: 0x00113B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IDKFKMDHOEA);
		}

		// Token: 0x060067EC RID: 26604 RVA: 0x00115994 File Offset: 0x00113B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IDKFKMDHOEA other)
		{
			return other != null && (other == this || (this.GMIADHCIJDO == other.GMIADHCIJDO && this.GPNPIDKNPFL == other.GPNPIDKNPFL && this.MJIIBAOPBPO == other.MJIIBAOPBPO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x001159F0 File Offset: 0x00113BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GMIADHCIJDO != 0U)
			{
				num ^= this.GMIADHCIJDO.GetHashCode();
			}
			if (this.GPNPIDKNPFL != 0U)
			{
				num ^= this.GPNPIDKNPFL.GetHashCode();
			}
			if (this.MJIIBAOPBPO != 0U)
			{
				num ^= this.MJIIBAOPBPO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x00115A61 File Offset: 0x00113C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x00115A69 File Offset: 0x00113C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x00115A74 File Offset: 0x00113C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GPNPIDKNPFL != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GPNPIDKNPFL);
			}
			if (this.MJIIBAOPBPO != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MJIIBAOPBPO);
			}
			if (this.GMIADHCIJDO != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GMIADHCIJDO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x00115AEC File Offset: 0x00113CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GMIADHCIJDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GMIADHCIJDO);
			}
			if (this.GPNPIDKNPFL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GPNPIDKNPFL);
			}
			if (this.MJIIBAOPBPO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MJIIBAOPBPO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060067F2 RID: 26610 RVA: 0x00115B5C File Offset: 0x00113D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IDKFKMDHOEA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GMIADHCIJDO != 0U)
			{
				this.GMIADHCIJDO = other.GMIADHCIJDO;
			}
			if (other.GPNPIDKNPFL != 0U)
			{
				this.GPNPIDKNPFL = other.GPNPIDKNPFL;
			}
			if (other.MJIIBAOPBPO != 0U)
			{
				this.MJIIBAOPBPO = other.MJIIBAOPBPO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x00115BC0 File Offset: 0x00113DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067F4 RID: 26612 RVA: 0x00115BCC File Offset: 0x00113DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GMIADHCIJDO = input.ReadUInt32();
						}
					}
					else
					{
						this.MJIIBAOPBPO = input.ReadUInt32();
					}
				}
				else
				{
					this.GPNPIDKNPFL = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040027E3 RID: 10211
		private static readonly MessageParser<IDKFKMDHOEA> _parser = new MessageParser<IDKFKMDHOEA>(() => new IDKFKMDHOEA());

		// Token: 0x040027E4 RID: 10212
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027E5 RID: 10213
		public const int GMIADHCIJDOFieldNumber = 15;

		// Token: 0x040027E6 RID: 10214
		private uint gMIADHCIJDO_;

		// Token: 0x040027E7 RID: 10215
		public const int GPNPIDKNPFLFieldNumber = 8;

		// Token: 0x040027E8 RID: 10216
		private uint gPNPIDKNPFL_;

		// Token: 0x040027E9 RID: 10217
		public const int MJIIBAOPBPOFieldNumber = 10;

		// Token: 0x040027EA RID: 10218
		private uint mJIIBAOPBPO_;
	}
}
