using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BBB RID: 3003
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumDispatchFinishedScNotify : IMessage<MuseumDispatchFinishedScNotify>, IMessage, IEquatable<MuseumDispatchFinishedScNotify>, IDeepCloneable<MuseumDispatchFinishedScNotify>, IBufferMessage
	{
		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x060084DC RID: 34012 RVA: 0x0015EA97 File Offset: 0x0015CC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumDispatchFinishedScNotify> Parser
		{
			get
			{
				return MuseumDispatchFinishedScNotify._parser;
			}
		}

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x060084DD RID: 34013 RVA: 0x0015EA9E File Offset: 0x0015CC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumDispatchFinishedScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x060084DE RID: 34014 RVA: 0x0015EAB0 File Offset: 0x0015CCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumDispatchFinishedScNotify.Descriptor;
			}
		}

		// Token: 0x060084DF RID: 34015 RVA: 0x0015EAB7 File Offset: 0x0015CCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumDispatchFinishedScNotify()
		{
		}

		// Token: 0x060084E0 RID: 34016 RVA: 0x0015EAC0 File Offset: 0x0015CCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumDispatchFinishedScNotify(MuseumDispatchFinishedScNotify other) : this()
		{
			this.cFCPIKEMPIO_ = other.cFCPIKEMPIO_;
			this.mMIDJEHMHMP_ = other.mMIDJEHMHMP_;
			this.pEPNGHDEDHG_ = other.pEPNGHDEDHG_;
			this.pOEDFMELAKE_ = other.pOEDFMELAKE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084E1 RID: 34017 RVA: 0x0015EB14 File Offset: 0x0015CD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumDispatchFinishedScNotify Clone()
		{
			return new MuseumDispatchFinishedScNotify(this);
		}

		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x060084E2 RID: 34018 RVA: 0x0015EB1C File Offset: 0x0015CD1C
		// (set) Token: 0x060084E3 RID: 34019 RVA: 0x0015EB24 File Offset: 0x0015CD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CFCPIKEMPIO
		{
			get
			{
				return this.cFCPIKEMPIO_;
			}
			set
			{
				this.cFCPIKEMPIO_ = value;
			}
		}

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x060084E4 RID: 34020 RVA: 0x0015EB2D File Offset: 0x0015CD2D
		// (set) Token: 0x060084E5 RID: 34021 RVA: 0x0015EB35 File Offset: 0x0015CD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMIDJEHMHMP
		{
			get
			{
				return this.mMIDJEHMHMP_;
			}
			set
			{
				this.mMIDJEHMHMP_ = value;
			}
		}

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x060084E6 RID: 34022 RVA: 0x0015EB3E File Offset: 0x0015CD3E
		// (set) Token: 0x060084E7 RID: 34023 RVA: 0x0015EB46 File Offset: 0x0015CD46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PEPNGHDEDHG
		{
			get
			{
				return this.pEPNGHDEDHG_;
			}
			set
			{
				this.pEPNGHDEDHG_ = value;
			}
		}

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x060084E8 RID: 34024 RVA: 0x0015EB4F File Offset: 0x0015CD4F
		// (set) Token: 0x060084E9 RID: 34025 RVA: 0x0015EB57 File Offset: 0x0015CD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POEDFMELAKE
		{
			get
			{
				return this.pOEDFMELAKE_;
			}
			set
			{
				this.pOEDFMELAKE_ = value;
			}
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x0015EB60 File Offset: 0x0015CD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumDispatchFinishedScNotify);
		}

		// Token: 0x060084EB RID: 34027 RVA: 0x0015EB70 File Offset: 0x0015CD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumDispatchFinishedScNotify other)
		{
			return other != null && (other == this || (this.CFCPIKEMPIO == other.CFCPIKEMPIO && this.MMIDJEHMHMP == other.MMIDJEHMHMP && this.PEPNGHDEDHG == other.PEPNGHDEDHG && this.POEDFMELAKE == other.POEDFMELAKE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084EC RID: 34028 RVA: 0x0015EBDC File Offset: 0x0015CDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CFCPIKEMPIO != 0U)
			{
				num ^= this.CFCPIKEMPIO.GetHashCode();
			}
			if (this.MMIDJEHMHMP != 0U)
			{
				num ^= this.MMIDJEHMHMP.GetHashCode();
			}
			if (this.PEPNGHDEDHG != 0U)
			{
				num ^= this.PEPNGHDEDHG.GetHashCode();
			}
			if (this.POEDFMELAKE != 0U)
			{
				num ^= this.POEDFMELAKE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x0015EC66 File Offset: 0x0015CE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060084EE RID: 34030 RVA: 0x0015EC6E File Offset: 0x0015CE6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x0015EC78 File Offset: 0x0015CE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MMIDJEHMHMP != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MMIDJEHMHMP);
			}
			if (this.POEDFMELAKE != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.POEDFMELAKE);
			}
			if (this.CFCPIKEMPIO != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CFCPIKEMPIO);
			}
			if (this.PEPNGHDEDHG != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.PEPNGHDEDHG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x0015ED0C File Offset: 0x0015CF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CFCPIKEMPIO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CFCPIKEMPIO);
			}
			if (this.MMIDJEHMHMP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMIDJEHMHMP);
			}
			if (this.PEPNGHDEDHG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PEPNGHDEDHG);
			}
			if (this.POEDFMELAKE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POEDFMELAKE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084F1 RID: 34033 RVA: 0x0015ED94 File Offset: 0x0015CF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumDispatchFinishedScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CFCPIKEMPIO != 0U)
			{
				this.CFCPIKEMPIO = other.CFCPIKEMPIO;
			}
			if (other.MMIDJEHMHMP != 0U)
			{
				this.MMIDJEHMHMP = other.MMIDJEHMHMP;
			}
			if (other.PEPNGHDEDHG != 0U)
			{
				this.PEPNGHDEDHG = other.PEPNGHDEDHG;
			}
			if (other.POEDFMELAKE != 0U)
			{
				this.POEDFMELAKE = other.POEDFMELAKE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060084F2 RID: 34034 RVA: 0x0015EE0C File Offset: 0x0015D00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084F3 RID: 34035 RVA: 0x0015EE18 File Offset: 0x0015D018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.MMIDJEHMHMP = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.POEDFMELAKE = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.CFCPIKEMPIO = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.PEPNGHDEDHG = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032DD RID: 13021
		private static readonly MessageParser<MuseumDispatchFinishedScNotify> _parser = new MessageParser<MuseumDispatchFinishedScNotify>(() => new MuseumDispatchFinishedScNotify());

		// Token: 0x040032DE RID: 13022
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032DF RID: 13023
		public const int CFCPIKEMPIOFieldNumber = 8;

		// Token: 0x040032E0 RID: 13024
		private uint cFCPIKEMPIO_;

		// Token: 0x040032E1 RID: 13025
		public const int MMIDJEHMHMPFieldNumber = 4;

		// Token: 0x040032E2 RID: 13026
		private uint mMIDJEHMHMP_;

		// Token: 0x040032E3 RID: 13027
		public const int PEPNGHDEDHGFieldNumber = 15;

		// Token: 0x040032E4 RID: 13028
		private uint pEPNGHDEDHG_;

		// Token: 0x040032E5 RID: 13029
		public const int POEDFMELAKEFieldNumber = 7;

		// Token: 0x040032E6 RID: 13030
		private uint pOEDFMELAKE_;
	}
}
