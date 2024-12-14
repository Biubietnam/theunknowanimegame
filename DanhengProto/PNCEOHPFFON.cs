using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CF3 RID: 3315
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PNCEOHPFFON : IMessage<PNCEOHPFFON>, IMessage, IEquatable<PNCEOHPFFON>, IDeepCloneable<PNCEOHPFFON>, IBufferMessage
	{
		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x0600940F RID: 37903 RVA: 0x00189AC1 File Offset: 0x00187CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PNCEOHPFFON> Parser
		{
			get
			{
				return PNCEOHPFFON._parser;
			}
		}

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x06009410 RID: 37904 RVA: 0x00189AC8 File Offset: 0x00187CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PNCEOHPFFONReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x06009411 RID: 37905 RVA: 0x00189ADA File Offset: 0x00187CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PNCEOHPFFON.Descriptor;
			}
		}

		// Token: 0x06009412 RID: 37906 RVA: 0x00189AE1 File Offset: 0x00187CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PNCEOHPFFON()
		{
		}

		// Token: 0x06009413 RID: 37907 RVA: 0x00189B0C File Offset: 0x00187D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PNCEOHPFFON(PNCEOHPFFON other) : this()
		{
			this.nLGPPCJHJKM_ = other.nLGPPCJHJKM_.Clone();
			this.jCNPAENAPBM_ = other.jCNPAENAPBM_.Clone();
			this.lPPHCCHIKFG_ = other.lPPHCCHIKFG_;
			this.aFFCKBCJCPH_ = other.aFFCKBCJCPH_;
			this.dFPOPHBKELB_ = other.dFPOPHBKELB_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x00189B7B File Offset: 0x00187D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PNCEOHPFFON Clone()
		{
			return new PNCEOHPFFON(this);
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x06009415 RID: 37909 RVA: 0x00189B83 File Offset: 0x00187D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NLGPPCJHJKM
		{
			get
			{
				return this.nLGPPCJHJKM_;
			}
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x06009416 RID: 37910 RVA: 0x00189B8B File Offset: 0x00187D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> JCNPAENAPBM
		{
			get
			{
				return this.jCNPAENAPBM_;
			}
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x06009417 RID: 37911 RVA: 0x00189B93 File Offset: 0x00187D93
		// (set) Token: 0x06009418 RID: 37912 RVA: 0x00189B9B File Offset: 0x00187D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LPPHCCHIKFG
		{
			get
			{
				return this.lPPHCCHIKFG_;
			}
			set
			{
				this.lPPHCCHIKFG_ = value;
			}
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x06009419 RID: 37913 RVA: 0x00189BA4 File Offset: 0x00187DA4
		// (set) Token: 0x0600941A RID: 37914 RVA: 0x00189BAC File Offset: 0x00187DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AFFCKBCJCPH
		{
			get
			{
				return this.aFFCKBCJCPH_;
			}
			set
			{
				this.aFFCKBCJCPH_ = value;
			}
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x0600941B RID: 37915 RVA: 0x00189BB5 File Offset: 0x00187DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DFPOPHBKELB
		{
			get
			{
				return this.dFPOPHBKELB_;
			}
		}

		// Token: 0x0600941C RID: 37916 RVA: 0x00189BBD File Offset: 0x00187DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PNCEOHPFFON);
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x00189BCC File Offset: 0x00187DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PNCEOHPFFON other)
		{
			return other != null && (other == this || (this.nLGPPCJHJKM_.Equals(other.nLGPPCJHJKM_) && this.jCNPAENAPBM_.Equals(other.jCNPAENAPBM_) && this.LPPHCCHIKFG == other.LPPHCCHIKFG && this.AFFCKBCJCPH == other.AFFCKBCJCPH && this.dFPOPHBKELB_.Equals(other.dFPOPHBKELB_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600941E RID: 37918 RVA: 0x00189C54 File Offset: 0x00187E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nLGPPCJHJKM_.GetHashCode();
			num ^= this.jCNPAENAPBM_.GetHashCode();
			if (this.LPPHCCHIKFG)
			{
				num ^= this.LPPHCCHIKFG.GetHashCode();
			}
			if (this.AFFCKBCJCPH != 0U)
			{
				num ^= this.AFFCKBCJCPH.GetHashCode();
			}
			num ^= this.dFPOPHBKELB_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x00189CD6 File Offset: 0x00187ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x00189CDE File Offset: 0x00187EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009421 RID: 37921 RVA: 0x00189CE8 File Offset: 0x00187EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jCNPAENAPBM_.WriteTo(ref output, PNCEOHPFFON._repeated_jCNPAENAPBM_codec);
			if (this.LPPHCCHIKFG)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.LPPHCCHIKFG);
			}
			if (this.AFFCKBCJCPH != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.AFFCKBCJCPH);
			}
			this.nLGPPCJHJKM_.WriteTo(ref output, PNCEOHPFFON._repeated_nLGPPCJHJKM_codec);
			this.dFPOPHBKELB_.WriteTo(ref output, PNCEOHPFFON._repeated_dFPOPHBKELB_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009422 RID: 37922 RVA: 0x00189D74 File Offset: 0x00187F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nLGPPCJHJKM_.CalculateSize(PNCEOHPFFON._repeated_nLGPPCJHJKM_codec);
			num += this.jCNPAENAPBM_.CalculateSize(PNCEOHPFFON._repeated_jCNPAENAPBM_codec);
			if (this.LPPHCCHIKFG)
			{
				num += 2;
			}
			if (this.AFFCKBCJCPH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AFFCKBCJCPH);
			}
			num += this.dFPOPHBKELB_.CalculateSize(PNCEOHPFFON._repeated_dFPOPHBKELB_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x00189DF8 File Offset: 0x00187FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PNCEOHPFFON other)
		{
			if (other == null)
			{
				return;
			}
			this.nLGPPCJHJKM_.Add(other.nLGPPCJHJKM_);
			this.jCNPAENAPBM_.Add(other.jCNPAENAPBM_);
			if (other.LPPHCCHIKFG)
			{
				this.LPPHCCHIKFG = other.LPPHCCHIKFG;
			}
			if (other.AFFCKBCJCPH != 0U)
			{
				this.AFFCKBCJCPH = other.AFFCKBCJCPH;
			}
			this.dFPOPHBKELB_.Add(other.dFPOPHBKELB_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x00189E7B File Offset: 0x0018807B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x00189E84 File Offset: 0x00188084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 34U)
					{
						if (num == 32U || num == 34U)
						{
							this.jCNPAENAPBM_.AddEntriesFrom(ref input, PNCEOHPFFON._repeated_jCNPAENAPBM_codec);
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.LPPHCCHIKFG = input.ReadBool();
							continue;
						}
						if (num == 64U)
						{
							this.AFFCKBCJCPH = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 106U)
				{
					if (num == 104U || num == 106U)
					{
						this.nLGPPCJHJKM_.AddEntriesFrom(ref input, PNCEOHPFFON._repeated_nLGPPCJHJKM_codec);
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.dFPOPHBKELB_.AddEntriesFrom(ref input, PNCEOHPFFON._repeated_dFPOPHBKELB_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400395A RID: 14682
		private static readonly MessageParser<PNCEOHPFFON> _parser = new MessageParser<PNCEOHPFFON>(() => new PNCEOHPFFON());

		// Token: 0x0400395B RID: 14683
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400395C RID: 14684
		public const int NLGPPCJHJKMFieldNumber = 13;

		// Token: 0x0400395D RID: 14685
		private static readonly FieldCodec<uint> _repeated_nLGPPCJHJKM_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x0400395E RID: 14686
		private readonly RepeatedField<uint> nLGPPCJHJKM_ = new RepeatedField<uint>();

		// Token: 0x0400395F RID: 14687
		public const int JCNPAENAPBMFieldNumber = 4;

		// Token: 0x04003960 RID: 14688
		private static readonly FieldCodec<uint> _repeated_jCNPAENAPBM_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04003961 RID: 14689
		private readonly RepeatedField<uint> jCNPAENAPBM_ = new RepeatedField<uint>();

		// Token: 0x04003962 RID: 14690
		public const int LPPHCCHIKFGFieldNumber = 7;

		// Token: 0x04003963 RID: 14691
		private bool lPPHCCHIKFG_;

		// Token: 0x04003964 RID: 14692
		public const int AFFCKBCJCPHFieldNumber = 8;

		// Token: 0x04003965 RID: 14693
		private uint aFFCKBCJCPH_;

		// Token: 0x04003966 RID: 14694
		public const int DFPOPHBKELBFieldNumber = 14;

		// Token: 0x04003967 RID: 14695
		private static readonly FieldCodec<uint> _repeated_dFPOPHBKELB_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04003968 RID: 14696
		private readonly RepeatedField<uint> dFPOPHBKELB_ = new RepeatedField<uint>();
	}
}
