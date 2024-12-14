using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008EB RID: 2283
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HHPPNNGGPIA : IMessage<HHPPNNGGPIA>, IMessage, IEquatable<HHPPNNGGPIA>, IDeepCloneable<HHPPNNGGPIA>, IBufferMessage
	{
		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x060065D0 RID: 26064 RVA: 0x001102B9 File Offset: 0x0010E4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HHPPNNGGPIA> Parser
		{
			get
			{
				return HHPPNNGGPIA._parser;
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x060065D1 RID: 26065 RVA: 0x001102C0 File Offset: 0x0010E4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HHPPNNGGPIAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x060065D2 RID: 26066 RVA: 0x001102D2 File Offset: 0x0010E4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HHPPNNGGPIA.Descriptor;
			}
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x001102D9 File Offset: 0x0010E4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HHPPNNGGPIA()
		{
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x001102E4 File Offset: 0x0010E4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HHPPNNGGPIA(HHPPNNGGPIA other) : this()
		{
			this.pAGNDMKMFHE_ = other.pAGNDMKMFHE_;
			this.dCEDNGLAOJI_ = other.dCEDNGLAOJI_;
			this.hPFMCFMICOG_ = ((other.hPFMCFMICOG_ != null) ? other.hPFMCFMICOG_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x0011033C File Offset: 0x0010E53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HHPPNNGGPIA Clone()
		{
			return new HHPPNNGGPIA(this);
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x060065D6 RID: 26070 RVA: 0x00110344 File Offset: 0x0010E544
		// (set) Token: 0x060065D7 RID: 26071 RVA: 0x0011034C File Offset: 0x0010E54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PAGNDMKMFHE
		{
			get
			{
				return this.pAGNDMKMFHE_;
			}
			set
			{
				this.pAGNDMKMFHE_ = value;
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x060065D8 RID: 26072 RVA: 0x00110355 File Offset: 0x0010E555
		// (set) Token: 0x060065D9 RID: 26073 RVA: 0x0011035D File Offset: 0x0010E55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DCEDNGLAOJI
		{
			get
			{
				return this.dCEDNGLAOJI_;
			}
			set
			{
				this.dCEDNGLAOJI_ = value;
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x060065DA RID: 26074 RVA: 0x00110366 File Offset: 0x0010E566
		// (set) Token: 0x060065DB RID: 26075 RVA: 0x0011036E File Offset: 0x0010E56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGIKGHKMAHA HPFMCFMICOG
		{
			get
			{
				return this.hPFMCFMICOG_;
			}
			set
			{
				this.hPFMCFMICOG_ = value;
			}
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x00110377 File Offset: 0x0010E577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HHPPNNGGPIA);
		}

		// Token: 0x060065DD RID: 26077 RVA: 0x00110388 File Offset: 0x0010E588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HHPPNNGGPIA other)
		{
			return other != null && (other == this || (this.PAGNDMKMFHE == other.PAGNDMKMFHE && this.DCEDNGLAOJI == other.DCEDNGLAOJI && object.Equals(this.HPFMCFMICOG, other.HPFMCFMICOG) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065DE RID: 26078 RVA: 0x001103E8 File Offset: 0x0010E5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PAGNDMKMFHE != 0U)
			{
				num ^= this.PAGNDMKMFHE.GetHashCode();
			}
			if (this.DCEDNGLAOJI)
			{
				num ^= this.DCEDNGLAOJI.GetHashCode();
			}
			if (this.hPFMCFMICOG_ != null)
			{
				num ^= this.HPFMCFMICOG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065DF RID: 26079 RVA: 0x00110456 File Offset: 0x0010E656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x0011045E File Offset: 0x0010E65E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x00110468 File Offset: 0x0010E668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PAGNDMKMFHE != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PAGNDMKMFHE);
			}
			if (this.DCEDNGLAOJI)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.DCEDNGLAOJI);
			}
			if (this.hPFMCFMICOG_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.HPFMCFMICOG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x001104DC File Offset: 0x0010E6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PAGNDMKMFHE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PAGNDMKMFHE);
			}
			if (this.DCEDNGLAOJI)
			{
				num += 2;
			}
			if (this.hPFMCFMICOG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HPFMCFMICOG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x00110540 File Offset: 0x0010E740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HHPPNNGGPIA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PAGNDMKMFHE != 0U)
			{
				this.PAGNDMKMFHE = other.PAGNDMKMFHE;
			}
			if (other.DCEDNGLAOJI)
			{
				this.DCEDNGLAOJI = other.DCEDNGLAOJI;
			}
			if (other.hPFMCFMICOG_ != null)
			{
				if (this.hPFMCFMICOG_ == null)
				{
					this.HPFMCFMICOG = new NGIKGHKMAHA();
				}
				this.HPFMCFMICOG.MergeFrom(other.HPFMCFMICOG);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x001105BC File Offset: 0x0010E7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x001105C8 File Offset: 0x0010E7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.hPFMCFMICOG_ == null)
							{
								this.HPFMCFMICOG = new NGIKGHKMAHA();
							}
							input.ReadMessage(this.HPFMCFMICOG);
						}
					}
					else
					{
						this.DCEDNGLAOJI = input.ReadBool();
					}
				}
				else
				{
					this.PAGNDMKMFHE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002727 RID: 10023
		private static readonly MessageParser<HHPPNNGGPIA> _parser = new MessageParser<HHPPNNGGPIA>(() => new HHPPNNGGPIA());

		// Token: 0x04002728 RID: 10024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002729 RID: 10025
		public const int PAGNDMKMFHEFieldNumber = 1;

		// Token: 0x0400272A RID: 10026
		private uint pAGNDMKMFHE_;

		// Token: 0x0400272B RID: 10027
		public const int DCEDNGLAOJIFieldNumber = 2;

		// Token: 0x0400272C RID: 10028
		private bool dCEDNGLAOJI_;

		// Token: 0x0400272D RID: 10029
		public const int HPFMCFMICOGFieldNumber = 3;

		// Token: 0x0400272E RID: 10030
		private NGIKGHKMAHA hPFMCFMICOG_;
	}
}
