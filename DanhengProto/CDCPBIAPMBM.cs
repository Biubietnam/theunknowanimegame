using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000173 RID: 371
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CDCPBIAPMBM : IMessage<CDCPBIAPMBM>, IMessage, IEquatable<CDCPBIAPMBM>, IDeepCloneable<CDCPBIAPMBM>, IBufferMessage
	{
		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0002FC79 File Offset: 0x0002DE79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CDCPBIAPMBM> Parser
		{
			get
			{
				return CDCPBIAPMBM._parser;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x0002FC80 File Offset: 0x0002DE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CDCPBIAPMBMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0002FC92 File Offset: 0x0002DE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CDCPBIAPMBM.Descriptor;
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0002FC99 File Offset: 0x0002DE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CDCPBIAPMBM()
		{
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0002FCAC File Offset: 0x0002DEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CDCPBIAPMBM(CDCPBIAPMBM other) : this()
		{
			this.cFGJLLGAOPB_ = other.cFGJLLGAOPB_;
			this.mGPPBKGIIEF_ = other.mGPPBKGIIEF_.Clone();
			this.iCEKHAEIIGK_ = other.iCEKHAEIIGK_;
			this.eGNDNNJLOOO_ = other.eGNDNNJLOOO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0002FD05 File Offset: 0x0002DF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CDCPBIAPMBM Clone()
		{
			return new CDCPBIAPMBM(this);
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0002FD0D File Offset: 0x0002DF0D
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x0002FD15 File Offset: 0x0002DF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CFGJLLGAOPB
		{
			get
			{
				return this.cFGJLLGAOPB_;
			}
			set
			{
				this.cFGJLLGAOPB_ = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x0002FD1E File Offset: 0x0002DF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MGPPBKGIIEF
		{
			get
			{
				return this.mGPPBKGIIEF_;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0002FD26 File Offset: 0x0002DF26
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x0002FD2E File Offset: 0x0002DF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ICEKHAEIIGK
		{
			get
			{
				return this.iCEKHAEIIGK_;
			}
			set
			{
				this.iCEKHAEIIGK_ = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0002FD37 File Offset: 0x0002DF37
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x0002FD3F File Offset: 0x0002DF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EGNDNNJLOOO
		{
			get
			{
				return this.eGNDNNJLOOO_;
			}
			set
			{
				this.eGNDNNJLOOO_ = value;
			}
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0002FD48 File Offset: 0x0002DF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CDCPBIAPMBM);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0002FD58 File Offset: 0x0002DF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CDCPBIAPMBM other)
		{
			return other != null && (other == this || (this.CFGJLLGAOPB == other.CFGJLLGAOPB && this.mGPPBKGIIEF_.Equals(other.mGPPBKGIIEF_) && this.ICEKHAEIIGK == other.ICEKHAEIIGK && this.EGNDNNJLOOO == other.EGNDNNJLOOO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0002FDC8 File Offset: 0x0002DFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CFGJLLGAOPB)
			{
				num ^= this.CFGJLLGAOPB.GetHashCode();
			}
			num ^= this.mGPPBKGIIEF_.GetHashCode();
			if (this.ICEKHAEIIGK != 0U)
			{
				num ^= this.ICEKHAEIIGK.GetHashCode();
			}
			if (this.EGNDNNJLOOO != 0U)
			{
				num ^= this.EGNDNNJLOOO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0002FE47 File Offset: 0x0002E047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0002FE4F File Offset: 0x0002E04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0002FE58 File Offset: 0x0002E058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CFGJLLGAOPB)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.CFGJLLGAOPB);
			}
			this.mGPPBKGIIEF_.WriteTo(ref output, CDCPBIAPMBM._repeated_mGPPBKGIIEF_codec);
			if (this.ICEKHAEIIGK != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ICEKHAEIIGK);
			}
			if (this.EGNDNNJLOOO != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.EGNDNNJLOOO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0002FEE0 File Offset: 0x0002E0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CFGJLLGAOPB)
			{
				num += 2;
			}
			num += this.mGPPBKGIIEF_.CalculateSize(CDCPBIAPMBM._repeated_mGPPBKGIIEF_codec);
			if (this.ICEKHAEIIGK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ICEKHAEIIGK);
			}
			if (this.EGNDNNJLOOO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EGNDNNJLOOO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0002FF58 File Offset: 0x0002E158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CDCPBIAPMBM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CFGJLLGAOPB)
			{
				this.CFGJLLGAOPB = other.CFGJLLGAOPB;
			}
			this.mGPPBKGIIEF_.Add(other.mGPPBKGIIEF_);
			if (other.ICEKHAEIIGK != 0U)
			{
				this.ICEKHAEIIGK = other.ICEKHAEIIGK;
			}
			if (other.EGNDNNJLOOO != 0U)
			{
				this.EGNDNNJLOOO = other.EGNDNNJLOOO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0002FFCD File Offset: 0x0002E1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0002FFD8 File Offset: 0x0002E1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.CFGJLLGAOPB = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						goto IL_43;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_43;
					}
					if (num == 24U)
					{
						this.ICEKHAEIIGK = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.EGNDNNJLOOO = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_43:
				this.mGPPBKGIIEF_.AddEntriesFrom(ref input, CDCPBIAPMBM._repeated_mGPPBKGIIEF_codec);
			}
		}

		// Token: 0x040006EE RID: 1774
		private static readonly MessageParser<CDCPBIAPMBM> _parser = new MessageParser<CDCPBIAPMBM>(() => new CDCPBIAPMBM());

		// Token: 0x040006EF RID: 1775
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006F0 RID: 1776
		public const int CFGJLLGAOPBFieldNumber = 1;

		// Token: 0x040006F1 RID: 1777
		private bool cFGJLLGAOPB_;

		// Token: 0x040006F2 RID: 1778
		public const int MGPPBKGIIEFFieldNumber = 2;

		// Token: 0x040006F3 RID: 1779
		private static readonly FieldCodec<uint> _repeated_mGPPBKGIIEF_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040006F4 RID: 1780
		private readonly RepeatedField<uint> mGPPBKGIIEF_ = new RepeatedField<uint>();

		// Token: 0x040006F5 RID: 1781
		public const int ICEKHAEIIGKFieldNumber = 3;

		// Token: 0x040006F6 RID: 1782
		private uint iCEKHAEIIGK_;

		// Token: 0x040006F7 RID: 1783
		public const int EGNDNNJLOOOFieldNumber = 4;

		// Token: 0x040006F8 RID: 1784
		private uint eGNDNNJLOOO_;
	}
}
