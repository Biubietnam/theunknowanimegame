using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C55 RID: 3157
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OIKHAJADEMG : IMessage<OIKHAJADEMG>, IMessage, IEquatable<OIKHAJADEMG>, IDeepCloneable<OIKHAJADEMG>, IBufferMessage
	{
		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x06008C28 RID: 35880 RVA: 0x001726D5 File Offset: 0x001708D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OIKHAJADEMG> Parser
		{
			get
			{
				return OIKHAJADEMG._parser;
			}
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x06008C29 RID: 35881 RVA: 0x001726DC File Offset: 0x001708DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OIKHAJADEMGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x06008C2A RID: 35882 RVA: 0x001726EE File Offset: 0x001708EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OIKHAJADEMG.Descriptor;
			}
		}

		// Token: 0x06008C2B RID: 35883 RVA: 0x001726F5 File Offset: 0x001708F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIKHAJADEMG()
		{
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x00172700 File Offset: 0x00170900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIKHAJADEMG(OIKHAJADEMG other) : this()
		{
			this.dNDLFECFMNI_ = other.dNDLFECFMNI_;
			this.iNOGEEHKJMO_ = other.iNOGEEHKJMO_;
			this.pLKJNGEPIAH_ = other.pLKJNGEPIAH_;
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C2D RID: 35885 RVA: 0x00172754 File Offset: 0x00170954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIKHAJADEMG Clone()
		{
			return new OIKHAJADEMG(this);
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x06008C2E RID: 35886 RVA: 0x0017275C File Offset: 0x0017095C
		// (set) Token: 0x06008C2F RID: 35887 RVA: 0x00172764 File Offset: 0x00170964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DNDLFECFMNI
		{
			get
			{
				return this.dNDLFECFMNI_;
			}
			set
			{
				this.dNDLFECFMNI_ = value;
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x06008C30 RID: 35888 RVA: 0x0017276D File Offset: 0x0017096D
		// (set) Token: 0x06008C31 RID: 35889 RVA: 0x00172775 File Offset: 0x00170975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint INOGEEHKJMO
		{
			get
			{
				return this.iNOGEEHKJMO_;
			}
			set
			{
				this.iNOGEEHKJMO_ = value;
			}
		}

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x06008C32 RID: 35890 RVA: 0x0017277E File Offset: 0x0017097E
		// (set) Token: 0x06008C33 RID: 35891 RVA: 0x00172786 File Offset: 0x00170986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PLKJNGEPIAH
		{
			get
			{
				return this.pLKJNGEPIAH_;
			}
			set
			{
				this.pLKJNGEPIAH_ = value;
			}
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x06008C34 RID: 35892 RVA: 0x0017278F File Offset: 0x0017098F
		// (set) Token: 0x06008C35 RID: 35893 RVA: 0x00172797 File Offset: 0x00170997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x06008C36 RID: 35894 RVA: 0x001727A0 File Offset: 0x001709A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OIKHAJADEMG);
		}

		// Token: 0x06008C37 RID: 35895 RVA: 0x001727B0 File Offset: 0x001709B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OIKHAJADEMG other)
		{
			return other != null && (other == this || (this.DNDLFECFMNI == other.DNDLFECFMNI && this.INOGEEHKJMO == other.INOGEEHKJMO && this.PLKJNGEPIAH == other.PLKJNGEPIAH && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C38 RID: 35896 RVA: 0x0017281C File Offset: 0x00170A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DNDLFECFMNI != 0U)
			{
				num ^= this.DNDLFECFMNI.GetHashCode();
			}
			if (this.INOGEEHKJMO != 0U)
			{
				num ^= this.INOGEEHKJMO.GetHashCode();
			}
			if (this.PLKJNGEPIAH != 0U)
			{
				num ^= this.PLKJNGEPIAH.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C39 RID: 35897 RVA: 0x001728A6 File Offset: 0x00170AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C3A RID: 35898 RVA: 0x001728AE File Offset: 0x00170AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C3B RID: 35899 RVA: 0x001728B8 File Offset: 0x00170AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.INOGEEHKJMO != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.INOGEEHKJMO);
			}
			if (this.DNDLFECFMNI != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.DNDLFECFMNI);
			}
			if (this.PLKJNGEPIAH != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PLKJNGEPIAH);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C3C RID: 35900 RVA: 0x00172948 File Offset: 0x00170B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DNDLFECFMNI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DNDLFECFMNI);
			}
			if (this.INOGEEHKJMO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.INOGEEHKJMO);
			}
			if (this.PLKJNGEPIAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PLKJNGEPIAH);
			}
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C3D RID: 35901 RVA: 0x001729D0 File Offset: 0x00170BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OIKHAJADEMG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DNDLFECFMNI != 0U)
			{
				this.DNDLFECFMNI = other.DNDLFECFMNI;
			}
			if (other.INOGEEHKJMO != 0U)
			{
				this.INOGEEHKJMO = other.INOGEEHKJMO;
			}
			if (other.PLKJNGEPIAH != 0U)
			{
				this.PLKJNGEPIAH = other.PLKJNGEPIAH;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C3E RID: 35902 RVA: 0x00172A48 File Offset: 0x00170C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C3F RID: 35903 RVA: 0x00172A54 File Offset: 0x00170C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.INOGEEHKJMO = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.DNDLFECFMNI = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.PLKJNGEPIAH = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040035CE RID: 13774
		private static readonly MessageParser<OIKHAJADEMG> _parser = new MessageParser<OIKHAJADEMG>(() => new OIKHAJADEMG());

		// Token: 0x040035CF RID: 13775
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035D0 RID: 13776
		public const int DNDLFECFMNIFieldNumber = 4;

		// Token: 0x040035D1 RID: 13777
		private uint dNDLFECFMNI_;

		// Token: 0x040035D2 RID: 13778
		public const int INOGEEHKJMOFieldNumber = 1;

		// Token: 0x040035D3 RID: 13779
		private uint iNOGEEHKJMO_;

		// Token: 0x040035D4 RID: 13780
		public const int PLKJNGEPIAHFieldNumber = 5;

		// Token: 0x040035D5 RID: 13781
		private uint pLKJNGEPIAH_;

		// Token: 0x040035D6 RID: 13782
		public const int AreaIdFieldNumber = 7;

		// Token: 0x040035D7 RID: 13783
		private uint areaId_;
	}
}
