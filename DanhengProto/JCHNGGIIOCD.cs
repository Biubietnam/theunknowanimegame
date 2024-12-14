using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200095B RID: 2395
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JCHNGGIIOCD : IMessage<JCHNGGIIOCD>, IMessage, IEquatable<JCHNGGIIOCD>, IDeepCloneable<JCHNGGIIOCD>, IBufferMessage
	{
		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x06006AEF RID: 27375 RVA: 0x0011D273 File Offset: 0x0011B473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JCHNGGIIOCD> Parser
		{
			get
			{
				return JCHNGGIIOCD._parser;
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x06006AF0 RID: 27376 RVA: 0x0011D27A File Offset: 0x0011B47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JCHNGGIIOCDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x06006AF1 RID: 27377 RVA: 0x0011D28C File Offset: 0x0011B48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JCHNGGIIOCD.Descriptor;
			}
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x0011D293 File Offset: 0x0011B493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JCHNGGIIOCD()
		{
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x0011D2B4 File Offset: 0x0011B4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JCHNGGIIOCD(JCHNGGIIOCD other) : this()
		{
			this.pBFEIKIDGMO_ = other.pBFEIKIDGMO_.Clone();
			this.cPNGFNJEAJK_ = other.cPNGFNJEAJK_;
			this.oPDJCBFOOEC_ = other.oPDJCBFOOEC_;
			this.mBPFMFHJDJI_ = other.mBPFMFHJDJI_;
			this.bBJJJFFEGDD_ = other.bBJJJFFEGDD_;
			this.iOPGCHEAMPI_ = other.iOPGCHEAMPI_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x0011D32A File Offset: 0x0011B52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JCHNGGIIOCD Clone()
		{
			return new JCHNGGIIOCD(this);
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x0011D332 File Offset: 0x0011B532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PBFEIKIDGMO
		{
			get
			{
				return this.pBFEIKIDGMO_;
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x06006AF6 RID: 27382 RVA: 0x0011D33A File Offset: 0x0011B53A
		// (set) Token: 0x06006AF7 RID: 27383 RVA: 0x0011D342 File Offset: 0x0011B542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CPNGFNJEAJK
		{
			get
			{
				return this.cPNGFNJEAJK_;
			}
			set
			{
				this.cPNGFNJEAJK_ = value;
			}
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x06006AF8 RID: 27384 RVA: 0x0011D34B File Offset: 0x0011B54B
		// (set) Token: 0x06006AF9 RID: 27385 RVA: 0x0011D353 File Offset: 0x0011B553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OPDJCBFOOEC
		{
			get
			{
				return this.oPDJCBFOOEC_;
			}
			set
			{
				this.oPDJCBFOOEC_ = value;
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x06006AFA RID: 27386 RVA: 0x0011D35C File Offset: 0x0011B55C
		// (set) Token: 0x06006AFB RID: 27387 RVA: 0x0011D364 File Offset: 0x0011B564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MBPFMFHJDJI
		{
			get
			{
				return this.mBPFMFHJDJI_;
			}
			set
			{
				this.mBPFMFHJDJI_ = value;
			}
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x06006AFC RID: 27388 RVA: 0x0011D36D File Offset: 0x0011B56D
		// (set) Token: 0x06006AFD RID: 27389 RVA: 0x0011D375 File Offset: 0x0011B575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BBJJJFFEGDD
		{
			get
			{
				return this.bBJJJFFEGDD_;
			}
			set
			{
				this.bBJJJFFEGDD_ = value;
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x06006AFE RID: 27390 RVA: 0x0011D37E File Offset: 0x0011B57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IOPGCHEAMPI
		{
			get
			{
				return this.iOPGCHEAMPI_;
			}
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x0011D386 File Offset: 0x0011B586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JCHNGGIIOCD);
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x0011D394 File Offset: 0x0011B594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JCHNGGIIOCD other)
		{
			return other != null && (other == this || (this.pBFEIKIDGMO_.Equals(other.pBFEIKIDGMO_) && this.CPNGFNJEAJK == other.CPNGFNJEAJK && this.OPDJCBFOOEC == other.OPDJCBFOOEC && this.MBPFMFHJDJI == other.MBPFMFHJDJI && this.BBJJJFFEGDD == other.BBJJJFFEGDD && this.iOPGCHEAMPI_.Equals(other.iOPGCHEAMPI_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x0011D428 File Offset: 0x0011B628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pBFEIKIDGMO_.GetHashCode();
			if (this.CPNGFNJEAJK != 0U)
			{
				num ^= this.CPNGFNJEAJK.GetHashCode();
			}
			if (this.OPDJCBFOOEC)
			{
				num ^= this.OPDJCBFOOEC.GetHashCode();
			}
			if (this.MBPFMFHJDJI != 0U)
			{
				num ^= this.MBPFMFHJDJI.GetHashCode();
			}
			if (this.BBJJJFFEGDD != 0U)
			{
				num ^= this.BBJJJFFEGDD.GetHashCode();
			}
			num ^= this.iOPGCHEAMPI_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B02 RID: 27394 RVA: 0x0011D4CE File Offset: 0x0011B6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x0011D4D6 File Offset: 0x0011B6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x0011D4E0 File Offset: 0x0011B6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OPDJCBFOOEC)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.OPDJCBFOOEC);
			}
			this.iOPGCHEAMPI_.WriteTo(ref output, JCHNGGIIOCD._repeated_iOPGCHEAMPI_codec);
			this.pBFEIKIDGMO_.WriteTo(ref output, JCHNGGIIOCD._repeated_pBFEIKIDGMO_codec);
			if (this.CPNGFNJEAJK != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CPNGFNJEAJK);
			}
			if (this.BBJJJFFEGDD != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BBJJJFFEGDD);
			}
			if (this.MBPFMFHJDJI != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MBPFMFHJDJI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x0011D594 File Offset: 0x0011B794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pBFEIKIDGMO_.CalculateSize(JCHNGGIIOCD._repeated_pBFEIKIDGMO_codec);
			if (this.CPNGFNJEAJK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CPNGFNJEAJK);
			}
			if (this.OPDJCBFOOEC)
			{
				num += 2;
			}
			if (this.MBPFMFHJDJI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MBPFMFHJDJI);
			}
			if (this.BBJJJFFEGDD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BBJJJFFEGDD);
			}
			num += this.iOPGCHEAMPI_.CalculateSize(JCHNGGIIOCD._repeated_iOPGCHEAMPI_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B06 RID: 27398 RVA: 0x0011D634 File Offset: 0x0011B834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JCHNGGIIOCD other)
		{
			if (other == null)
			{
				return;
			}
			this.pBFEIKIDGMO_.Add(other.pBFEIKIDGMO_);
			if (other.CPNGFNJEAJK != 0U)
			{
				this.CPNGFNJEAJK = other.CPNGFNJEAJK;
			}
			if (other.OPDJCBFOOEC)
			{
				this.OPDJCBFOOEC = other.OPDJCBFOOEC;
			}
			if (other.MBPFMFHJDJI != 0U)
			{
				this.MBPFMFHJDJI = other.MBPFMFHJDJI;
			}
			if (other.BBJJJFFEGDD != 0U)
			{
				this.BBJJJFFEGDD = other.BBJJJFFEGDD;
			}
			this.iOPGCHEAMPI_.Add(other.iOPGCHEAMPI_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B07 RID: 27399 RVA: 0x0011D6CE File Offset: 0x0011B8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x0011D6D8 File Offset: 0x0011B8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 32U)
					{
						if (num == 24U)
						{
							this.OPDJCBFOOEC = input.ReadBool();
							continue;
						}
						if (num != 32U)
						{
							goto IL_42;
						}
					}
					else if (num != 34U)
					{
						if (num != 48U)
						{
							goto IL_42;
						}
						goto IL_77;
					}
					this.iOPGCHEAMPI_.AddEntriesFrom(ref input, JCHNGGIIOCD._repeated_iOPGCHEAMPI_codec);
					continue;
				}
				if (num <= 64U)
				{
					if (num == 50U)
					{
						goto IL_77;
					}
					if (num == 64U)
					{
						this.CPNGFNJEAJK = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.BBJJJFFEGDD = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.MBPFMFHJDJI = input.ReadUInt32();
						continue;
					}
				}
				IL_42:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_77:
				this.pBFEIKIDGMO_.AddEntriesFrom(ref input, JCHNGGIIOCD._repeated_pBFEIKIDGMO_codec);
			}
		}

		// Token: 0x040028ED RID: 10477
		private static readonly MessageParser<JCHNGGIIOCD> _parser = new MessageParser<JCHNGGIIOCD>(() => new JCHNGGIIOCD());

		// Token: 0x040028EE RID: 10478
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028EF RID: 10479
		public const int PBFEIKIDGMOFieldNumber = 6;

		// Token: 0x040028F0 RID: 10480
		private static readonly FieldCodec<uint> _repeated_pBFEIKIDGMO_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x040028F1 RID: 10481
		private readonly RepeatedField<uint> pBFEIKIDGMO_ = new RepeatedField<uint>();

		// Token: 0x040028F2 RID: 10482
		public const int CPNGFNJEAJKFieldNumber = 8;

		// Token: 0x040028F3 RID: 10483
		private uint cPNGFNJEAJK_;

		// Token: 0x040028F4 RID: 10484
		public const int OPDJCBFOOECFieldNumber = 3;

		// Token: 0x040028F5 RID: 10485
		private bool oPDJCBFOOEC_;

		// Token: 0x040028F6 RID: 10486
		public const int MBPFMFHJDJIFieldNumber = 14;

		// Token: 0x040028F7 RID: 10487
		private uint mBPFMFHJDJI_;

		// Token: 0x040028F8 RID: 10488
		public const int BBJJJFFEGDDFieldNumber = 13;

		// Token: 0x040028F9 RID: 10489
		private uint bBJJJFFEGDD_;

		// Token: 0x040028FA RID: 10490
		public const int IOPGCHEAMPIFieldNumber = 4;

		// Token: 0x040028FB RID: 10491
		private static readonly FieldCodec<uint> _repeated_iOPGCHEAMPI_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040028FC RID: 10492
		private readonly RepeatedField<uint> iOPGCHEAMPI_ = new RepeatedField<uint>();
	}
}
