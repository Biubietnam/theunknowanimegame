using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000961 RID: 2401
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JDOCCKOMOEG : IMessage<JDOCCKOMOEG>, IMessage, IEquatable<JDOCCKOMOEG>, IDeepCloneable<JDOCCKOMOEG>, IBufferMessage
	{
		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06006B3E RID: 27454 RVA: 0x0011E0CF File Offset: 0x0011C2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JDOCCKOMOEG> Parser
		{
			get
			{
				return JDOCCKOMOEG._parser;
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x06006B3F RID: 27455 RVA: 0x0011E0D6 File Offset: 0x0011C2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JDOCCKOMOEGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x06006B40 RID: 27456 RVA: 0x0011E0E8 File Offset: 0x0011C2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JDOCCKOMOEG.Descriptor;
			}
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x0011E0EF File Offset: 0x0011C2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDOCCKOMOEG()
		{
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x0011E110 File Offset: 0x0011C310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDOCCKOMOEG(JDOCCKOMOEG other) : this()
		{
			this.ePLDEIBMADF_ = other.ePLDEIBMADF_.Clone();
			this.nHKDHIFGPKO_ = other.nHKDHIFGPKO_.Clone();
			this.pOLJKEFBHKM_ = other.pOLJKEFBHKM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x0011E162 File Offset: 0x0011C362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDOCCKOMOEG Clone()
		{
			return new JDOCCKOMOEG(this);
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x06006B44 RID: 27460 RVA: 0x0011E16A File Offset: 0x0011C36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EPLDEIBMADF
		{
			get
			{
				return this.ePLDEIBMADF_;
			}
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x06006B45 RID: 27461 RVA: 0x0011E172 File Offset: 0x0011C372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MGLKKPJKBLJ> NHKDHIFGPKO
		{
			get
			{
				return this.nHKDHIFGPKO_;
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x06006B46 RID: 27462 RVA: 0x0011E17A File Offset: 0x0011C37A
		// (set) Token: 0x06006B47 RID: 27463 RVA: 0x0011E182 File Offset: 0x0011C382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDailyPhaseType POLJKEFBHKM
		{
			get
			{
				return this.pOLJKEFBHKM_;
			}
			set
			{
				this.pOLJKEFBHKM_ = value;
			}
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x0011E18B File Offset: 0x0011C38B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JDOCCKOMOEG);
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x0011E19C File Offset: 0x0011C39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JDOCCKOMOEG other)
		{
			return other != null && (other == this || (this.ePLDEIBMADF_.Equals(other.ePLDEIBMADF_) && this.nHKDHIFGPKO_.Equals(other.nHKDHIFGPKO_) && this.POLJKEFBHKM == other.POLJKEFBHKM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x0011E200 File Offset: 0x0011C400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ePLDEIBMADF_.GetHashCode();
			num ^= this.nHKDHIFGPKO_.GetHashCode();
			if (this.POLJKEFBHKM != SwordTrainingDailyPhaseType.None)
			{
				num ^= this.POLJKEFBHKM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B4B RID: 27467 RVA: 0x0011E261 File Offset: 0x0011C461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x0011E269 File Offset: 0x0011C469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B4D RID: 27469 RVA: 0x0011E274 File Offset: 0x0011C474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.POLJKEFBHKM != SwordTrainingDailyPhaseType.None)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.POLJKEFBHKM);
			}
			this.ePLDEIBMADF_.WriteTo(ref output, JDOCCKOMOEG._repeated_ePLDEIBMADF_codec);
			this.nHKDHIFGPKO_.WriteTo(ref output, JDOCCKOMOEG._repeated_nHKDHIFGPKO_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B4E RID: 27470 RVA: 0x0011E2D4 File Offset: 0x0011C4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ePLDEIBMADF_.CalculateSize(JDOCCKOMOEG._repeated_ePLDEIBMADF_codec);
			num += this.nHKDHIFGPKO_.CalculateSize(JDOCCKOMOEG._repeated_nHKDHIFGPKO_codec);
			if (this.POLJKEFBHKM != SwordTrainingDailyPhaseType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.POLJKEFBHKM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B4F RID: 27471 RVA: 0x0011E338 File Offset: 0x0011C538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JDOCCKOMOEG other)
		{
			if (other == null)
			{
				return;
			}
			this.ePLDEIBMADF_.Add(other.ePLDEIBMADF_);
			this.nHKDHIFGPKO_.Add(other.nHKDHIFGPKO_);
			if (other.POLJKEFBHKM != SwordTrainingDailyPhaseType.None)
			{
				this.POLJKEFBHKM = other.POLJKEFBHKM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x0011E396 File Offset: 0x0011C596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x0011E3A0 File Offset: 0x0011C5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 40U)
					{
						this.POLJKEFBHKM = (SwordTrainingDailyPhaseType)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						goto IL_3F;
					}
				}
				else
				{
					if (num == 50U)
					{
						goto IL_3F;
					}
					if (num == 122U)
					{
						this.nHKDHIFGPKO_.AddEntriesFrom(ref input, JDOCCKOMOEG._repeated_nHKDHIFGPKO_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_3F:
				this.ePLDEIBMADF_.AddEntriesFrom(ref input, JDOCCKOMOEG._repeated_ePLDEIBMADF_codec);
			}
		}

		// Token: 0x04002910 RID: 10512
		private static readonly MessageParser<JDOCCKOMOEG> _parser = new MessageParser<JDOCCKOMOEG>(() => new JDOCCKOMOEG());

		// Token: 0x04002911 RID: 10513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002912 RID: 10514
		public const int EPLDEIBMADFFieldNumber = 6;

		// Token: 0x04002913 RID: 10515
		private static readonly FieldCodec<uint> _repeated_ePLDEIBMADF_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04002914 RID: 10516
		private readonly RepeatedField<uint> ePLDEIBMADF_ = new RepeatedField<uint>();

		// Token: 0x04002915 RID: 10517
		public const int NHKDHIFGPKOFieldNumber = 15;

		// Token: 0x04002916 RID: 10518
		private static readonly FieldCodec<MGLKKPJKBLJ> _repeated_nHKDHIFGPKO_codec = FieldCodec.ForMessage<MGLKKPJKBLJ>(122U, MGLKKPJKBLJ.Parser);

		// Token: 0x04002917 RID: 10519
		private readonly RepeatedField<MGLKKPJKBLJ> nHKDHIFGPKO_ = new RepeatedField<MGLKKPJKBLJ>();

		// Token: 0x04002918 RID: 10520
		public const int POLJKEFBHKMFieldNumber = 5;

		// Token: 0x04002919 RID: 10521
		private SwordTrainingDailyPhaseType pOLJKEFBHKM_;
	}
}
