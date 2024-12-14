using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200090B RID: 2315
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HPPHNMBHEEJ : IMessage<HPPHNMBHEEJ>, IMessage, IEquatable<HPPHNMBHEEJ>, IDeepCloneable<HPPHNMBHEEJ>, IBufferMessage
	{
		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x0600674F RID: 26447 RVA: 0x00114145 File Offset: 0x00112345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HPPHNMBHEEJ> Parser
		{
			get
			{
				return HPPHNMBHEEJ._parser;
			}
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06006750 RID: 26448 RVA: 0x0011414C File Offset: 0x0011234C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HPPHNMBHEEJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06006751 RID: 26449 RVA: 0x0011415E File Offset: 0x0011235E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HPPHNMBHEEJ.Descriptor;
			}
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x00114165 File Offset: 0x00112365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPPHNMBHEEJ()
		{
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x00114178 File Offset: 0x00112378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPPHNMBHEEJ(HPPHNMBHEEJ other) : this()
		{
			this.eACCGOKFCDH_ = ((other.eACCGOKFCDH_ != null) ? other.eACCGOKFCDH_.Clone() : null);
			this.cKGCGAKOBIO_ = other.cKGCGAKOBIO_.Clone();
			this.fDDLABHFDED_ = ((other.fDDLABHFDED_ != null) ? other.fDDLABHFDED_.Clone() : null);
			this.gLPBIBPFLDB_ = ((other.gLPBIBPFLDB_ != null) ? other.gLPBIBPFLDB_.Clone() : null);
			this.jGKJJKFBLCF_ = other.jGKJJKFBLCF_;
			this.nNMAEGJLIMK_ = ((other.nNMAEGJLIMK_ != null) ? other.nNMAEGJLIMK_.Clone() : null);
			this.skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
			this.pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006754 RID: 26452 RVA: 0x00114261 File Offset: 0x00112461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPPHNMBHEEJ Clone()
		{
			return new HPPHNMBHEEJ(this);
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06006755 RID: 26453 RVA: 0x00114269 File Offset: 0x00112469
		// (set) Token: 0x06006756 RID: 26454 RVA: 0x00114271 File Offset: 0x00112471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELEJIEDDFHL EACCGOKFCDH
		{
			get
			{
				return this.eACCGOKFCDH_;
			}
			set
			{
				this.eACCGOKFCDH_ = value;
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06006757 RID: 26455 RVA: 0x0011427A File Offset: 0x0011247A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> CKGCGAKOBIO
		{
			get
			{
				return this.cKGCGAKOBIO_;
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06006758 RID: 26456 RVA: 0x00114282 File Offset: 0x00112482
		// (set) Token: 0x06006759 RID: 26457 RVA: 0x0011428A File Offset: 0x0011248A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAJMDOHPIIK FDDLABHFDED
		{
			get
			{
				return this.fDDLABHFDED_;
			}
			set
			{
				this.fDDLABHFDED_ = value;
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x00114293 File Offset: 0x00112493
		// (set) Token: 0x0600675B RID: 26459 RVA: 0x0011429B File Offset: 0x0011249B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKACCPKNCKI GLPBIBPFLDB
		{
			get
			{
				return this.gLPBIBPFLDB_;
			}
			set
			{
				this.gLPBIBPFLDB_ = value;
			}
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x001142A4 File Offset: 0x001124A4
		// (set) Token: 0x0600675D RID: 26461 RVA: 0x001142AC File Offset: 0x001124AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JGKJJKFBLCF
		{
			get
			{
				return this.jGKJJKFBLCF_;
			}
			set
			{
				this.jGKJJKFBLCF_ = value;
			}
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x001142B5 File Offset: 0x001124B5
		// (set) Token: 0x0600675F RID: 26463 RVA: 0x001142BD File Offset: 0x001124BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKFEGNBJLGI NNMAEGJLIMK
		{
			get
			{
				return this.nNMAEGJLIMK_;
			}
			set
			{
				this.nNMAEGJLIMK_ = value;
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x001142C6 File Offset: 0x001124C6
		// (set) Token: 0x06006761 RID: 26465 RVA: 0x001142CE File Offset: 0x001124CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HNPELFOBMFO SkillInfo
		{
			get
			{
				return this.skillInfo_;
			}
			set
			{
				this.skillInfo_ = value;
			}
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06006762 RID: 26466 RVA: 0x001142D7 File Offset: 0x001124D7
		// (set) Token: 0x06006763 RID: 26467 RVA: 0x001142DF File Offset: 0x001124DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPACKIIECGI PendingAction
		{
			get
			{
				return this.pendingAction_;
			}
			set
			{
				this.pendingAction_ = value;
			}
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x001142E8 File Offset: 0x001124E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HPPHNMBHEEJ);
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x001142F8 File Offset: 0x001124F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HPPHNMBHEEJ other)
		{
			return other != null && (other == this || (object.Equals(this.EACCGOKFCDH, other.EACCGOKFCDH) && this.cKGCGAKOBIO_.Equals(other.cKGCGAKOBIO_) && object.Equals(this.FDDLABHFDED, other.FDDLABHFDED) && object.Equals(this.GLPBIBPFLDB, other.GLPBIBPFLDB) && this.JGKJJKFBLCF == other.JGKJJKFBLCF && object.Equals(this.NNMAEGJLIMK, other.NNMAEGJLIMK) && object.Equals(this.SkillInfo, other.SkillInfo) && object.Equals(this.PendingAction, other.PendingAction) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x001143C4 File Offset: 0x001125C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.eACCGOKFCDH_ != null)
			{
				num ^= this.EACCGOKFCDH.GetHashCode();
			}
			num ^= this.cKGCGAKOBIO_.GetHashCode();
			if (this.fDDLABHFDED_ != null)
			{
				num ^= this.FDDLABHFDED.GetHashCode();
			}
			if (this.gLPBIBPFLDB_ != null)
			{
				num ^= this.GLPBIBPFLDB.GetHashCode();
			}
			if (this.JGKJJKFBLCF != 0U)
			{
				num ^= this.JGKJJKFBLCF.GetHashCode();
			}
			if (this.nNMAEGJLIMK_ != null)
			{
				num ^= this.NNMAEGJLIMK.GetHashCode();
			}
			if (this.skillInfo_ != null)
			{
				num ^= this.SkillInfo.GetHashCode();
			}
			if (this.pendingAction_ != null)
			{
				num ^= this.PendingAction.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x00114495 File Offset: 0x00112695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x0011449D File Offset: 0x0011269D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006769 RID: 26473 RVA: 0x001144A8 File Offset: 0x001126A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cKGCGAKOBIO_.WriteTo(ref output, HPPHNMBHEEJ._repeated_cKGCGAKOBIO_codec);
			if (this.pendingAction_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PendingAction);
			}
			if (this.skillInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SkillInfo);
			}
			if (this.nNMAEGJLIMK_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.NNMAEGJLIMK);
			}
			if (this.gLPBIBPFLDB_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.GLPBIBPFLDB);
			}
			if (this.JGKJJKFBLCF != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.JGKJJKFBLCF);
			}
			if (this.fDDLABHFDED_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.FDDLABHFDED);
			}
			if (this.eACCGOKFCDH_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.EACCGOKFCDH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x001145A0 File Offset: 0x001127A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.eACCGOKFCDH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EACCGOKFCDH);
			}
			num += this.cKGCGAKOBIO_.CalculateSize(HPPHNMBHEEJ._repeated_cKGCGAKOBIO_codec);
			if (this.fDDLABHFDED_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FDDLABHFDED);
			}
			if (this.gLPBIBPFLDB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GLPBIBPFLDB);
			}
			if (this.JGKJJKFBLCF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JGKJJKFBLCF);
			}
			if (this.nNMAEGJLIMK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NNMAEGJLIMK);
			}
			if (this.skillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillInfo);
			}
			if (this.pendingAction_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PendingAction);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x00114684 File Offset: 0x00112884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HPPHNMBHEEJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.eACCGOKFCDH_ != null)
			{
				if (this.eACCGOKFCDH_ == null)
				{
					this.EACCGOKFCDH = new ELEJIEDDFHL();
				}
				this.EACCGOKFCDH.MergeFrom(other.EACCGOKFCDH);
			}
			this.cKGCGAKOBIO_.Add(other.cKGCGAKOBIO_);
			if (other.fDDLABHFDED_ != null)
			{
				if (this.fDDLABHFDED_ == null)
				{
					this.FDDLABHFDED = new PAJMDOHPIIK();
				}
				this.FDDLABHFDED.MergeFrom(other.FDDLABHFDED);
			}
			if (other.gLPBIBPFLDB_ != null)
			{
				if (this.gLPBIBPFLDB_ == null)
				{
					this.GLPBIBPFLDB = new MKACCPKNCKI();
				}
				this.GLPBIBPFLDB.MergeFrom(other.GLPBIBPFLDB);
			}
			if (other.JGKJJKFBLCF != 0U)
			{
				this.JGKJJKFBLCF = other.JGKJJKFBLCF;
			}
			if (other.nNMAEGJLIMK_ != null)
			{
				if (this.nNMAEGJLIMK_ == null)
				{
					this.NNMAEGJLIMK = new MKFEGNBJLGI();
				}
				this.NNMAEGJLIMK.MergeFrom(other.NNMAEGJLIMK);
			}
			if (other.skillInfo_ != null)
			{
				if (this.skillInfo_ == null)
				{
					this.SkillInfo = new HNPELFOBMFO();
				}
				this.SkillInfo.MergeFrom(other.SkillInfo);
			}
			if (other.pendingAction_ != null)
			{
				if (this.pendingAction_ == null)
				{
					this.PendingAction = new HPACKIIECGI();
				}
				this.PendingAction.MergeFrom(other.PendingAction);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x001147D9 File Offset: 0x001129D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x001147E4 File Offset: 0x001129E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.cKGCGAKOBIO_.AddEntriesFrom(ref input, HPPHNMBHEEJ._repeated_cKGCGAKOBIO_codec);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							if (this.pendingAction_ == null)
							{
								this.PendingAction = new HPACKIIECGI();
							}
							input.ReadMessage(this.PendingAction);
							continue;
						}
						if (num == 42U)
						{
							if (this.skillInfo_ == null)
							{
								this.SkillInfo = new HNPELFOBMFO();
							}
							input.ReadMessage(this.SkillInfo);
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 66U)
					{
						if (this.nNMAEGJLIMK_ == null)
						{
							this.NNMAEGJLIMK = new MKFEGNBJLGI();
						}
						input.ReadMessage(this.NNMAEGJLIMK);
						continue;
					}
					if (num == 82U)
					{
						if (this.gLPBIBPFLDB_ == null)
						{
							this.GLPBIBPFLDB = new MKACCPKNCKI();
						}
						input.ReadMessage(this.GLPBIBPFLDB);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.JGKJJKFBLCF = input.ReadUInt32();
						continue;
					}
					if (num == 98U)
					{
						if (this.fDDLABHFDED_ == null)
						{
							this.FDDLABHFDED = new PAJMDOHPIIK();
						}
						input.ReadMessage(this.FDDLABHFDED);
						continue;
					}
					if (num == 114U)
					{
						if (this.eACCGOKFCDH_ == null)
						{
							this.EACCGOKFCDH = new ELEJIEDDFHL();
						}
						input.ReadMessage(this.EACCGOKFCDH);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040027AC RID: 10156
		private static readonly MessageParser<HPPHNMBHEEJ> _parser = new MessageParser<HPPHNMBHEEJ>(() => new HPPHNMBHEEJ());

		// Token: 0x040027AD RID: 10157
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027AE RID: 10158
		public const int EACCGOKFCDHFieldNumber = 14;

		// Token: 0x040027AF RID: 10159
		private ELEJIEDDFHL eACCGOKFCDH_;

		// Token: 0x040027B0 RID: 10160
		public const int CKGCGAKOBIOFieldNumber = 1;

		// Token: 0x040027B1 RID: 10161
		private static readonly FieldCodec<uint> _repeated_cKGCGAKOBIO_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x040027B2 RID: 10162
		private readonly RepeatedField<uint> cKGCGAKOBIO_ = new RepeatedField<uint>();

		// Token: 0x040027B3 RID: 10163
		public const int FDDLABHFDEDFieldNumber = 12;

		// Token: 0x040027B4 RID: 10164
		private PAJMDOHPIIK fDDLABHFDED_;

		// Token: 0x040027B5 RID: 10165
		public const int GLPBIBPFLDBFieldNumber = 10;

		// Token: 0x040027B6 RID: 10166
		private MKACCPKNCKI gLPBIBPFLDB_;

		// Token: 0x040027B7 RID: 10167
		public const int JGKJJKFBLCFFieldNumber = 11;

		// Token: 0x040027B8 RID: 10168
		private uint jGKJJKFBLCF_;

		// Token: 0x040027B9 RID: 10169
		public const int NNMAEGJLIMKFieldNumber = 8;

		// Token: 0x040027BA RID: 10170
		private MKFEGNBJLGI nNMAEGJLIMK_;

		// Token: 0x040027BB RID: 10171
		public const int SkillInfoFieldNumber = 5;

		// Token: 0x040027BC RID: 10172
		private HNPELFOBMFO skillInfo_;

		// Token: 0x040027BD RID: 10173
		public const int PendingActionFieldNumber = 3;

		// Token: 0x040027BE RID: 10174
		private HPACKIIECGI pendingAction_;
	}
}
