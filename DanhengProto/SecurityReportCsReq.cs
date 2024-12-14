using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200109B RID: 4251
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SecurityReportCsReq : IMessage<SecurityReportCsReq>, IMessage, IEquatable<SecurityReportCsReq>, IDeepCloneable<SecurityReportCsReq>, IBufferMessage
	{
		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x0600BD7B RID: 48507 RVA: 0x001FEA7C File Offset: 0x001FCC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SecurityReportCsReq> Parser
		{
			get
			{
				return SecurityReportCsReq._parser;
			}
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0600BD7C RID: 48508 RVA: 0x001FEA83 File Offset: 0x001FCC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SecurityReportCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0600BD7D RID: 48509 RVA: 0x001FEA95 File Offset: 0x001FCC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecurityReportCsReq.Descriptor;
			}
		}

		// Token: 0x0600BD7E RID: 48510 RVA: 0x001FEA9C File Offset: 0x001FCC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecurityReportCsReq()
		{
		}

		// Token: 0x0600BD7F RID: 48511 RVA: 0x001FEAAF File Offset: 0x001FCCAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecurityReportCsReq(SecurityReportCsReq other) : this()
		{
			this.cGOCHPPAAKM_ = other.cGOCHPPAAKM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD80 RID: 48512 RVA: 0x001FEAD4 File Offset: 0x001FCCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecurityReportCsReq Clone()
		{
			return new SecurityReportCsReq(this);
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0600BD81 RID: 48513 RVA: 0x001FEADC File Offset: 0x001FCCDC
		// (set) Token: 0x0600BD82 RID: 48514 RVA: 0x001FEAE4 File Offset: 0x001FCCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CGOCHPPAAKM
		{
			get
			{
				return this.cGOCHPPAAKM_;
			}
			set
			{
				this.cGOCHPPAAKM_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600BD83 RID: 48515 RVA: 0x001FEAF7 File Offset: 0x001FCCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecurityReportCsReq);
		}

		// Token: 0x0600BD84 RID: 48516 RVA: 0x001FEB05 File Offset: 0x001FCD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecurityReportCsReq other)
		{
			return other != null && (other == this || (!(this.CGOCHPPAAKM != other.CGOCHPPAAKM) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD85 RID: 48517 RVA: 0x001FEB38 File Offset: 0x001FCD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CGOCHPPAAKM.Length != 0)
			{
				num ^= this.CGOCHPPAAKM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD86 RID: 48518 RVA: 0x001FEB79 File Offset: 0x001FCD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BD87 RID: 48519 RVA: 0x001FEB81 File Offset: 0x001FCD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD88 RID: 48520 RVA: 0x001FEB8A File Offset: 0x001FCD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CGOCHPPAAKM.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.CGOCHPPAAKM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD89 RID: 48521 RVA: 0x001FEBC4 File Offset: 0x001FCDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CGOCHPPAAKM.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CGOCHPPAAKM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD8A RID: 48522 RVA: 0x001FEC07 File Offset: 0x001FCE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecurityReportCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CGOCHPPAAKM.Length != 0)
			{
				this.CGOCHPPAAKM = other.CGOCHPPAAKM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD8B RID: 48523 RVA: 0x001FEC3D File Offset: 0x001FCE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD8C RID: 48524 RVA: 0x001FEC48 File Offset: 0x001FCE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CGOCHPPAAKM = input.ReadString();
				}
			}
		}

		// Token: 0x04004D0E RID: 19726
		private static readonly MessageParser<SecurityReportCsReq> _parser = new MessageParser<SecurityReportCsReq>(() => new SecurityReportCsReq());

		// Token: 0x04004D0F RID: 19727
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D10 RID: 19728
		public const int CGOCHPPAAKMFieldNumber = 4;

		// Token: 0x04004D11 RID: 19729
		private string cGOCHPPAAKM_ = "";
	}
}
