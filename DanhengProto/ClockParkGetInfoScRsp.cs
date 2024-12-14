using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002ED RID: 749
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkGetInfoScRsp : IMessage<ClockParkGetInfoScRsp>, IMessage, IEquatable<ClockParkGetInfoScRsp>, IDeepCloneable<ClockParkGetInfoScRsp>, IBufferMessage
	{
		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x0005EB27 File Offset: 0x0005CD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkGetInfoScRsp> Parser
		{
			get
			{
				return ClockParkGetInfoScRsp._parser;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x0005EB2E File Offset: 0x0005CD2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkGetInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x0005EB40 File Offset: 0x0005CD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkGetInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x0005EB47 File Offset: 0x0005CD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetInfoScRsp()
		{
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x0005EB68 File Offset: 0x0005CD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetInfoScRsp(ClockParkGetInfoScRsp other) : this()
		{
			this.aGJOFICCDGC_ = other.aGJOFICCDGC_.Clone();
			this.hGBGFJCIKOL_ = other.hGBGFJCIKOL_;
			this.hEIMLGPNICE_ = other.hEIMLGPNICE_.Clone();
			this.retcode_ = other.retcode_;
			this.progress_ = other.progress_;
			this.jKLKEMABMLF_ = other.jKLKEMABMLF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x0005EBDE File Offset: 0x0005CDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetInfoScRsp Clone()
		{
			return new ClockParkGetInfoScRsp(this);
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x0005EBE6 File Offset: 0x0005CDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AGJOFICCDGC
		{
			get
			{
				return this.aGJOFICCDGC_;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x0005EBEE File Offset: 0x0005CDEE
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x0005EBF6 File Offset: 0x0005CDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HGBGFJCIKOL
		{
			get
			{
				return this.hGBGFJCIKOL_;
			}
			set
			{
				this.hGBGFJCIKOL_ = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x0005EBFF File Offset: 0x0005CDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NMGJCHNEGGF> HEIMLGPNICE
		{
			get
			{
				return this.hEIMLGPNICE_;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x0005EC07 File Offset: 0x0005CE07
		// (set) Token: 0x06002170 RID: 8560 RVA: 0x0005EC0F File Offset: 0x0005CE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x0005EC18 File Offset: 0x0005CE18
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x0005EC20 File Offset: 0x0005CE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x0005EC29 File Offset: 0x0005CE29
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x0005EC31 File Offset: 0x0005CE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JKLKEMABMLF
		{
			get
			{
				return this.jKLKEMABMLF_;
			}
			set
			{
				this.jKLKEMABMLF_ = value;
			}
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0005EC3A File Offset: 0x0005CE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkGetInfoScRsp);
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0005EC48 File Offset: 0x0005CE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkGetInfoScRsp other)
		{
			return other != null && (other == this || (this.aGJOFICCDGC_.Equals(other.aGJOFICCDGC_) && this.HGBGFJCIKOL == other.HGBGFJCIKOL && this.hEIMLGPNICE_.Equals(other.hEIMLGPNICE_) && this.Retcode == other.Retcode && this.Progress == other.Progress && this.JKLKEMABMLF == other.JKLKEMABMLF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x0005ECDC File Offset: 0x0005CEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aGJOFICCDGC_.GetHashCode();
			if (this.HGBGFJCIKOL != 0U)
			{
				num ^= this.HGBGFJCIKOL.GetHashCode();
			}
			num ^= this.hEIMLGPNICE_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.JKLKEMABMLF != 0U)
			{
				num ^= this.JKLKEMABMLF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x0005ED82 File Offset: 0x0005CF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x0005ED8A File Offset: 0x0005CF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x0005ED94 File Offset: 0x0005CF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JKLKEMABMLF != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.JKLKEMABMLF);
			}
			if (this.HGBGFJCIKOL != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.HGBGFJCIKOL);
			}
			if (this.Progress != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Progress);
			}
			this.hEIMLGPNICE_.WriteTo(ref output, ClockParkGetInfoScRsp._repeated_hEIMLGPNICE_codec);
			this.aGJOFICCDGC_.WriteTo(ref output, ClockParkGetInfoScRsp._repeated_aGJOFICCDGC_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x0005EE48 File Offset: 0x0005D048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aGJOFICCDGC_.CalculateSize(ClockParkGetInfoScRsp._repeated_aGJOFICCDGC_codec);
			if (this.HGBGFJCIKOL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HGBGFJCIKOL);
			}
			num += this.hEIMLGPNICE_.CalculateSize(ClockParkGetInfoScRsp._repeated_hEIMLGPNICE_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this.JKLKEMABMLF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JKLKEMABMLF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x0005EEF4 File Offset: 0x0005D0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkGetInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.aGJOFICCDGC_.Add(other.aGJOFICCDGC_);
			if (other.HGBGFJCIKOL != 0U)
			{
				this.HGBGFJCIKOL = other.HGBGFJCIKOL;
			}
			this.hEIMLGPNICE_.Add(other.hEIMLGPNICE_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			if (other.JKLKEMABMLF != 0U)
			{
				this.JKLKEMABMLF = other.JKLKEMABMLF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x0005EF8E File Offset: 0x0005D18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x0005EF98 File Offset: 0x0005D198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 32U)
				{
					if (num <= 56U)
					{
						if (num == 42U)
						{
							this.hEIMLGPNICE_.AddEntriesFrom(ref input, ClockParkGetInfoScRsp._repeated_hEIMLGPNICE_codec);
							continue;
						}
						if (num != 56U)
						{
							goto IL_35;
						}
					}
					else if (num != 58U)
					{
						if (num != 120U)
						{
							goto IL_35;
						}
						this.Retcode = input.ReadUInt32();
						continue;
					}
					this.aGJOFICCDGC_.AddEntriesFrom(ref input, ClockParkGetInfoScRsp._repeated_aGJOFICCDGC_codec);
					continue;
				}
				if (num == 8U)
				{
					this.JKLKEMABMLF = input.ReadUInt32();
					continue;
				}
				if (num == 16U)
				{
					this.HGBGFJCIKOL = input.ReadUInt32();
					continue;
				}
				if (num == 32U)
				{
					this.Progress = input.ReadUInt32();
					continue;
				}
				IL_35:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000DB8 RID: 3512
		private static readonly MessageParser<ClockParkGetInfoScRsp> _parser = new MessageParser<ClockParkGetInfoScRsp>(() => new ClockParkGetInfoScRsp());

		// Token: 0x04000DB9 RID: 3513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DBA RID: 3514
		public const int AGJOFICCDGCFieldNumber = 7;

		// Token: 0x04000DBB RID: 3515
		private static readonly FieldCodec<uint> _repeated_aGJOFICCDGC_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04000DBC RID: 3516
		private readonly RepeatedField<uint> aGJOFICCDGC_ = new RepeatedField<uint>();

		// Token: 0x04000DBD RID: 3517
		public const int HGBGFJCIKOLFieldNumber = 2;

		// Token: 0x04000DBE RID: 3518
		private uint hGBGFJCIKOL_;

		// Token: 0x04000DBF RID: 3519
		public const int HEIMLGPNICEFieldNumber = 5;

		// Token: 0x04000DC0 RID: 3520
		private static readonly FieldCodec<NMGJCHNEGGF> _repeated_hEIMLGPNICE_codec = FieldCodec.ForMessage<NMGJCHNEGGF>(42U, NMGJCHNEGGF.Parser);

		// Token: 0x04000DC1 RID: 3521
		private readonly RepeatedField<NMGJCHNEGGF> hEIMLGPNICE_ = new RepeatedField<NMGJCHNEGGF>();

		// Token: 0x04000DC2 RID: 3522
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04000DC3 RID: 3523
		private uint retcode_;

		// Token: 0x04000DC4 RID: 3524
		public const int ProgressFieldNumber = 4;

		// Token: 0x04000DC5 RID: 3525
		private uint progress_;

		// Token: 0x04000DC6 RID: 3526
		public const int JKLKEMABMLFFieldNumber = 1;

		// Token: 0x04000DC7 RID: 3527
		private uint jKLKEMABMLF_;
	}
}
