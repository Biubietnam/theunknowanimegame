using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000875 RID: 2165
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GOFLJKMHPMP : IMessage<GOFLJKMHPMP>, IMessage, IEquatable<GOFLJKMHPMP>, IDeepCloneable<GOFLJKMHPMP>, IBufferMessage
	{
		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x06006030 RID: 24624 RVA: 0x000FE220 File Offset: 0x000FC420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GOFLJKMHPMP> Parser
		{
			get
			{
				return GOFLJKMHPMP._parser;
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06006031 RID: 24625 RVA: 0x000FE227 File Offset: 0x000FC427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GOFLJKMHPMPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x06006032 RID: 24626 RVA: 0x000FE239 File Offset: 0x000FC439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GOFLJKMHPMP.Descriptor;
			}
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x000FE240 File Offset: 0x000FC440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOFLJKMHPMP()
		{
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x000FE260 File Offset: 0x000FC460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOFLJKMHPMP(GOFLJKMHPMP other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.lAJFCJALNMH_ = other.lAJFCJALNMH_.Clone();
			this.source_ = other.source_;
			this.damage_ = other.damage_;
			this.aPFDBCJLPKP_ = other.aPFDBCJLPKP_.Clone();
			this.lIIFHHAEPMJ_ = other.lIIFHHAEPMJ_;
			this.iPEDNEAFKNA_ = other.iPEDNEAFKNA_;
			this.bCKBOHJPJDI_ = other.bCKBOHJPJDI_;
			this.wave_ = other.wave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x000FE2FA File Offset: 0x000FC4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOFLJKMHPMP Clone()
		{
			return new GOFLJKMHPMP(this);
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06006036 RID: 24630 RVA: 0x000FE302 File Offset: 0x000FC502
		// (set) Token: 0x06006037 RID: 24631 RVA: 0x000FE30A File Offset: 0x000FC50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06006038 RID: 24632 RVA: 0x000FE313 File Offset: 0x000FC513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LAJFCJALNMH
		{
			get
			{
				return this.lAJFCJALNMH_;
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06006039 RID: 24633 RVA: 0x000FE31B File Offset: 0x000FC51B
		// (set) Token: 0x0600603A RID: 24634 RVA: 0x000FE323 File Offset: 0x000FC523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Source
		{
			get
			{
				return this.source_;
			}
			set
			{
				this.source_ = value;
			}
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x0600603B RID: 24635 RVA: 0x000FE32C File Offset: 0x000FC52C
		// (set) Token: 0x0600603C RID: 24636 RVA: 0x000FE334 File Offset: 0x000FC534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x0600603D RID: 24637 RVA: 0x000FE33D File Offset: 0x000FC53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> APFDBCJLPKP
		{
			get
			{
				return this.aPFDBCJLPKP_;
			}
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x0600603E RID: 24638 RVA: 0x000FE345 File Offset: 0x000FC545
		// (set) Token: 0x0600603F RID: 24639 RVA: 0x000FE34D File Offset: 0x000FC54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LIIFHHAEPMJ
		{
			get
			{
				return this.lIIFHHAEPMJ_;
			}
			set
			{
				this.lIIFHHAEPMJ_ = value;
			}
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06006040 RID: 24640 RVA: 0x000FE356 File Offset: 0x000FC556
		// (set) Token: 0x06006041 RID: 24641 RVA: 0x000FE35E File Offset: 0x000FC55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double IPEDNEAFKNA
		{
			get
			{
				return this.iPEDNEAFKNA_;
			}
			set
			{
				this.iPEDNEAFKNA_ = value;
			}
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06006042 RID: 24642 RVA: 0x000FE367 File Offset: 0x000FC567
		// (set) Token: 0x06006043 RID: 24643 RVA: 0x000FE36F File Offset: 0x000FC56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BCKBOHJPJDI
		{
			get
			{
				return this.bCKBOHJPJDI_;
			}
			set
			{
				this.bCKBOHJPJDI_ = value;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06006044 RID: 24644 RVA: 0x000FE378 File Offset: 0x000FC578
		// (set) Token: 0x06006045 RID: 24645 RVA: 0x000FE380 File Offset: 0x000FC580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Wave
		{
			get
			{
				return this.wave_;
			}
			set
			{
				this.wave_ = value;
			}
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x000FE389 File Offset: 0x000FC589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GOFLJKMHPMP);
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x000FE398 File Offset: 0x000FC598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GOFLJKMHPMP other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.lAJFCJALNMH_.Equals(other.lAJFCJALNMH_) && this.Source == other.Source && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Damage, other.Damage) && this.aPFDBCJLPKP_.Equals(other.aPFDBCJLPKP_) && this.LIIFHHAEPMJ == other.LIIFHHAEPMJ && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.IPEDNEAFKNA, other.IPEDNEAFKNA) && this.BCKBOHJPJDI == other.BCKBOHJPJDI && this.Wave == other.Wave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x000FE470 File Offset: 0x000FC670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			num ^= this.lAJFCJALNMH_.GetHashCode();
			if (this.Source != 0U)
			{
				num ^= this.Source.GetHashCode();
			}
			if (this.Damage != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Damage);
			}
			num ^= this.aPFDBCJLPKP_.GetHashCode();
			if (this.LIIFHHAEPMJ != 0)
			{
				num ^= this.LIIFHHAEPMJ.GetHashCode();
			}
			if (this.IPEDNEAFKNA != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.IPEDNEAFKNA);
			}
			if (this.BCKBOHJPJDI != 0U)
			{
				num ^= this.BCKBOHJPJDI.GetHashCode();
			}
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x000FE577 File Offset: 0x000FC777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x000FE57F File Offset: 0x000FC77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x000FE588 File Offset: 0x000FC788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AvatarId);
			}
			this.lAJFCJALNMH_.WriteTo(ref output, GOFLJKMHPMP._repeated_lAJFCJALNMH_codec);
			if (this.Source != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Source);
			}
			if (this.Damage != 0.0)
			{
				output.WriteRawTag(33);
				output.WriteDouble(this.Damage);
			}
			this.aPFDBCJLPKP_.WriteTo(ref output, GOFLJKMHPMP._repeated_aPFDBCJLPKP_codec);
			if (this.LIIFHHAEPMJ != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LIIFHHAEPMJ);
			}
			if (this.IPEDNEAFKNA != 0.0)
			{
				output.WriteRawTag(57);
				output.WriteDouble(this.IPEDNEAFKNA);
			}
			if (this.BCKBOHJPJDI != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.BCKBOHJPJDI);
			}
			if (this.Wave != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Wave);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x000FE6A0 File Offset: 0x000FC8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			num += this.lAJFCJALNMH_.CalculateSize(GOFLJKMHPMP._repeated_lAJFCJALNMH_codec);
			if (this.Source != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Source);
			}
			if (this.Damage != 0.0)
			{
				num += 9;
			}
			num += this.aPFDBCJLPKP_.CalculateSize(GOFLJKMHPMP._repeated_aPFDBCJLPKP_codec);
			if (this.LIIFHHAEPMJ != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LIIFHHAEPMJ);
			}
			if (this.IPEDNEAFKNA != 0.0)
			{
				num += 9;
			}
			if (this.BCKBOHJPJDI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BCKBOHJPJDI);
			}
			if (this.Wave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x000FE790 File Offset: 0x000FC990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GOFLJKMHPMP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this.lAJFCJALNMH_.Add(other.lAJFCJALNMH_);
			if (other.Source != 0U)
			{
				this.Source = other.Source;
			}
			if (other.Damage != 0.0)
			{
				this.Damage = other.Damage;
			}
			this.aPFDBCJLPKP_.Add(other.aPFDBCJLPKP_);
			if (other.LIIFHHAEPMJ != 0)
			{
				this.LIIFHHAEPMJ = other.LIIFHHAEPMJ;
			}
			if (other.IPEDNEAFKNA != 0.0)
			{
				this.IPEDNEAFKNA = other.IPEDNEAFKNA;
			}
			if (other.BCKBOHJPJDI != 0U)
			{
				this.BCKBOHJPJDI = other.BCKBOHJPJDI;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x000FE878 File Offset: 0x000FCA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x000FE884 File Offset: 0x000FCA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 33U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.AvatarId = input.ReadUInt32();
							continue;
						}
						if (num != 16U)
						{
							goto IL_5C;
						}
					}
					else if (num != 18U)
					{
						if (num == 24U)
						{
							this.Source = input.ReadUInt32();
							continue;
						}
						if (num != 33U)
						{
							goto IL_5C;
						}
						this.Damage = input.ReadDouble();
						continue;
					}
					this.lAJFCJALNMH_.AddEntriesFrom(ref input, GOFLJKMHPMP._repeated_lAJFCJALNMH_codec);
					continue;
				}
				if (num <= 48U)
				{
					if (num == 40U || num == 42U)
					{
						this.aPFDBCJLPKP_.AddEntriesFrom(ref input, GOFLJKMHPMP._repeated_aPFDBCJLPKP_codec);
						continue;
					}
					if (num == 48U)
					{
						this.LIIFHHAEPMJ = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 57U)
					{
						this.IPEDNEAFKNA = input.ReadDouble();
						continue;
					}
					if (num == 64U)
					{
						this.BCKBOHJPJDI = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Wave = input.ReadUInt32();
						continue;
					}
				}
				IL_5C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040024F0 RID: 9456
		private static readonly MessageParser<GOFLJKMHPMP> _parser = new MessageParser<GOFLJKMHPMP>(() => new GOFLJKMHPMP());

		// Token: 0x040024F1 RID: 9457
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024F2 RID: 9458
		public const int AvatarIdFieldNumber = 1;

		// Token: 0x040024F3 RID: 9459
		private uint avatarId_;

		// Token: 0x040024F4 RID: 9460
		public const int LAJFCJALNMHFieldNumber = 2;

		// Token: 0x040024F5 RID: 9461
		private static readonly FieldCodec<uint> _repeated_lAJFCJALNMH_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040024F6 RID: 9462
		private readonly RepeatedField<uint> lAJFCJALNMH_ = new RepeatedField<uint>();

		// Token: 0x040024F7 RID: 9463
		public const int SourceFieldNumber = 3;

		// Token: 0x040024F8 RID: 9464
		private uint source_;

		// Token: 0x040024F9 RID: 9465
		public const int DamageFieldNumber = 4;

		// Token: 0x040024FA RID: 9466
		private double damage_;

		// Token: 0x040024FB RID: 9467
		public const int APFDBCJLPKPFieldNumber = 5;

		// Token: 0x040024FC RID: 9468
		private static readonly FieldCodec<uint> _repeated_aPFDBCJLPKP_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040024FD RID: 9469
		private readonly RepeatedField<uint> aPFDBCJLPKP_ = new RepeatedField<uint>();

		// Token: 0x040024FE RID: 9470
		public const int LIIFHHAEPMJFieldNumber = 6;

		// Token: 0x040024FF RID: 9471
		private int lIIFHHAEPMJ_;

		// Token: 0x04002500 RID: 9472
		public const int IPEDNEAFKNAFieldNumber = 7;

		// Token: 0x04002501 RID: 9473
		private double iPEDNEAFKNA_;

		// Token: 0x04002502 RID: 9474
		public const int BCKBOHJPJDIFieldNumber = 8;

		// Token: 0x04002503 RID: 9475
		private uint bCKBOHJPJDI_;

		// Token: 0x04002504 RID: 9476
		public const int WaveFieldNumber = 9;

		// Token: 0x04002505 RID: 9477
		private uint wave_;
	}
}
