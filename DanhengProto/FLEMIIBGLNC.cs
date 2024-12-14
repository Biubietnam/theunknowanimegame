using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005AF RID: 1455
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FLEMIIBGLNC : IMessage<FLEMIIBGLNC>, IMessage, IEquatable<FLEMIIBGLNC>, IDeepCloneable<FLEMIIBGLNC>, IBufferMessage
	{
		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06004100 RID: 16640 RVA: 0x000B11CF File Offset: 0x000AF3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FLEMIIBGLNC> Parser
		{
			get
			{
				return FLEMIIBGLNC._parser;
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x000B11D6 File Offset: 0x000AF3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FLEMIIBGLNCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06004102 RID: 16642 RVA: 0x000B11E8 File Offset: 0x000AF3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FLEMIIBGLNC.Descriptor;
			}
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x000B11EF File Offset: 0x000AF3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FLEMIIBGLNC()
		{
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x000B11F8 File Offset: 0x000AF3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FLEMIIBGLNC(FLEMIIBGLNC other) : this()
		{
			this.state_ = other.state_;
			this.oOGAPOKFKAI_ = other.oOGAPOKFKAI_;
			this.rank_ = other.rank_;
			this.gCCIOHEJPNE_ = other.gCCIOHEJPNE_;
			this.scoreId_ = other.scoreId_;
			this.hp_ = other.hp_;
			this.dNAMDNCLOJC_ = other.dNAMDNCLOJC_;
			this.eKFPKFECMGC_ = other.eKFPKFECMGC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x000B127C File Offset: 0x000AF47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FLEMIIBGLNC Clone()
		{
			return new FLEMIIBGLNC(this);
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06004106 RID: 16646 RVA: 0x000B1284 File Offset: 0x000AF484
		// (set) Token: 0x06004107 RID: 16647 RVA: 0x000B128C File Offset: 0x000AF48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BLBJBAMDNBN State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06004108 RID: 16648 RVA: 0x000B1295 File Offset: 0x000AF495
		// (set) Token: 0x06004109 RID: 16649 RVA: 0x000B129D File Offset: 0x000AF49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OOGAPOKFKAI
		{
			get
			{
				return this.oOGAPOKFKAI_;
			}
			set
			{
				this.oOGAPOKFKAI_ = value;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x0600410A RID: 16650 RVA: 0x000B12A6 File Offset: 0x000AF4A6
		// (set) Token: 0x0600410B RID: 16651 RVA: 0x000B12AE File Offset: 0x000AF4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x0600410C RID: 16652 RVA: 0x000B12B7 File Offset: 0x000AF4B7
		// (set) Token: 0x0600410D RID: 16653 RVA: 0x000B12BF File Offset: 0x000AF4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GCCIOHEJPNE
		{
			get
			{
				return this.gCCIOHEJPNE_;
			}
			set
			{
				this.gCCIOHEJPNE_ = value;
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x0600410E RID: 16654 RVA: 0x000B12C8 File Offset: 0x000AF4C8
		// (set) Token: 0x0600410F RID: 16655 RVA: 0x000B12D0 File Offset: 0x000AF4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x000B12D9 File Offset: 0x000AF4D9
		// (set) Token: 0x06004111 RID: 16657 RVA: 0x000B12E1 File Offset: 0x000AF4E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Hp
		{
			get
			{
				return this.hp_;
			}
			set
			{
				this.hp_ = value;
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06004112 RID: 16658 RVA: 0x000B12EA File Offset: 0x000AF4EA
		// (set) Token: 0x06004113 RID: 16659 RVA: 0x000B12F2 File Offset: 0x000AF4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DNAMDNCLOJC
		{
			get
			{
				return this.dNAMDNCLOJC_;
			}
			set
			{
				this.dNAMDNCLOJC_ = value;
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06004114 RID: 16660 RVA: 0x000B12FB File Offset: 0x000AF4FB
		// (set) Token: 0x06004115 RID: 16661 RVA: 0x000B1303 File Offset: 0x000AF503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EKFPKFECMGC
		{
			get
			{
				return this.eKFPKFECMGC_;
			}
			set
			{
				this.eKFPKFECMGC_ = value;
			}
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x000B130C File Offset: 0x000AF50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FLEMIIBGLNC);
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x000B131C File Offset: 0x000AF51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FLEMIIBGLNC other)
		{
			return other != null && (other == this || (this.State == other.State && this.OOGAPOKFKAI == other.OOGAPOKFKAI && this.Rank == other.Rank && this.GCCIOHEJPNE == other.GCCIOHEJPNE && this.ScoreId == other.ScoreId && this.Hp == other.Hp && this.DNAMDNCLOJC == other.DNAMDNCLOJC && this.EKFPKFECMGC == other.EKFPKFECMGC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x000B13C8 File Offset: 0x000AF5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.State != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.OOGAPOKFKAI != 0U)
			{
				num ^= this.OOGAPOKFKAI.GetHashCode();
			}
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.GCCIOHEJPNE != 0U)
			{
				num ^= this.GCCIOHEJPNE.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.Hp != 0U)
			{
				num ^= this.Hp.GetHashCode();
			}
			if (this.DNAMDNCLOJC != 0U)
			{
				num ^= this.DNAMDNCLOJC.GetHashCode();
			}
			if (this.EKFPKFECMGC)
			{
				num ^= this.EKFPKFECMGC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x000B14BC File Offset: 0x000AF6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x000B14C4 File Offset: 0x000AF6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x000B14D0 File Offset: 0x000AF6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Rank != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Rank);
			}
			if (this.EKFPKFECMGC)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.EKFPKFECMGC);
			}
			if (this.GCCIOHEJPNE != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GCCIOHEJPNE);
			}
			if (this.DNAMDNCLOJC != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DNAMDNCLOJC);
			}
			if (this.OOGAPOKFKAI != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.OOGAPOKFKAI);
			}
			if (this.Hp != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Hp);
			}
			if (this.State != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.State);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ScoreId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x000B15D0 File Offset: 0x000AF7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.State != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.OOGAPOKFKAI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OOGAPOKFKAI);
			}
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.GCCIOHEJPNE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GCCIOHEJPNE);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.Hp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Hp);
			}
			if (this.DNAMDNCLOJC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DNAMDNCLOJC);
			}
			if (this.EKFPKFECMGC)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x000B16AC File Offset: 0x000AF8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FLEMIIBGLNC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.State != BLBJBAMDNBN.Match3PlayerStateAlive)
			{
				this.State = other.State;
			}
			if (other.OOGAPOKFKAI != 0U)
			{
				this.OOGAPOKFKAI = other.OOGAPOKFKAI;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.GCCIOHEJPNE != 0U)
			{
				this.GCCIOHEJPNE = other.GCCIOHEJPNE;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.Hp != 0U)
			{
				this.Hp = other.Hp;
			}
			if (other.DNAMDNCLOJC != 0U)
			{
				this.DNAMDNCLOJC = other.DNAMDNCLOJC;
			}
			if (other.EKFPKFECMGC)
			{
				this.EKFPKFECMGC = other.EKFPKFECMGC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x000B1774 File Offset: 0x000AF974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x000B1780 File Offset: 0x000AF980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num <= 40U)
					{
						if (num == 8U)
						{
							this.Rank = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.EKFPKFECMGC = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 64U)
						{
							this.GCCIOHEJPNE = input.ReadUInt32();
							continue;
						}
						if (num == 88U)
						{
							this.DNAMDNCLOJC = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.OOGAPOKFKAI = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Hp = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.State = (BLBJBAMDNBN)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040019CB RID: 6603
		private static readonly MessageParser<FLEMIIBGLNC> _parser = new MessageParser<FLEMIIBGLNC>(() => new FLEMIIBGLNC());

		// Token: 0x040019CC RID: 6604
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019CD RID: 6605
		public const int StateFieldNumber = 14;

		// Token: 0x040019CE RID: 6606
		private BLBJBAMDNBN state_;

		// Token: 0x040019CF RID: 6607
		public const int OOGAPOKFKAIFieldNumber = 12;

		// Token: 0x040019D0 RID: 6608
		private uint oOGAPOKFKAI_;

		// Token: 0x040019D1 RID: 6609
		public const int RankFieldNumber = 1;

		// Token: 0x040019D2 RID: 6610
		private uint rank_;

		// Token: 0x040019D3 RID: 6611
		public const int GCCIOHEJPNEFieldNumber = 8;

		// Token: 0x040019D4 RID: 6612
		private uint gCCIOHEJPNE_;

		// Token: 0x040019D5 RID: 6613
		public const int ScoreIdFieldNumber = 15;

		// Token: 0x040019D6 RID: 6614
		private uint scoreId_;

		// Token: 0x040019D7 RID: 6615
		public const int HpFieldNumber = 13;

		// Token: 0x040019D8 RID: 6616
		private uint hp_;

		// Token: 0x040019D9 RID: 6617
		public const int DNAMDNCLOJCFieldNumber = 11;

		// Token: 0x040019DA RID: 6618
		private uint dNAMDNCLOJC_;

		// Token: 0x040019DB RID: 6619
		public const int EKFPKFECMGCFieldNumber = 5;

		// Token: 0x040019DC RID: 6620
		private bool eKFPKFECMGC_;
	}
}
