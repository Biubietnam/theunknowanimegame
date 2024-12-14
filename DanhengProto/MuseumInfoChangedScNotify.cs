using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BBF RID: 3007
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumInfoChangedScNotify : IMessage<MuseumInfoChangedScNotify>, IMessage, IEquatable<MuseumInfoChangedScNotify>, IDeepCloneable<MuseumInfoChangedScNotify>, IBufferMessage
	{
		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x0600850C RID: 34060 RVA: 0x0015F26F File Offset: 0x0015D46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumInfoChangedScNotify> Parser
		{
			get
			{
				return MuseumInfoChangedScNotify._parser;
			}
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x0015F276 File Offset: 0x0015D476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumInfoChangedScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x0600850E RID: 34062 RVA: 0x0015F288 File Offset: 0x0015D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumInfoChangedScNotify.Descriptor;
			}
		}

		// Token: 0x0600850F RID: 34063 RVA: 0x0015F28F File Offset: 0x0015D48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumInfoChangedScNotify()
		{
		}

		// Token: 0x06008510 RID: 34064 RVA: 0x0015F2C4 File Offset: 0x0015D4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumInfoChangedScNotify(MuseumInfoChangedScNotify other) : this()
		{
			this.iKHGKNMLHCN_ = other.iKHGKNMLHCN_.Clone();
			this.gKFDGDNNEEO_ = other.gKFDGDNNEEO_;
			this.level_ = other.level_;
			this.dOAPPNKFLPL_ = other.dOAPPNKFLPL_.Clone();
			this.dMENOFHEGFK_ = other.dMENOFHEGFK_;
			this.fOFHPBEAAFE_ = other.fOFHPBEAAFE_.Clone();
			this.nEJENNBOOBH_ = other.nEJENNBOOBH_;
			this.mMIDJEHMHMP_ = other.mMIDJEHMHMP_;
			this.oBKJOCMKICE_ = other.oBKJOCMKICE_.Clone();
			this.jCBEHHMALNP_ = other.jCBEHHMALNP_;
			this.pIDAMMINCFB_ = ((other.pIDAMMINCFB_ != null) ? other.pIDAMMINCFB_.Clone() : null);
			this.exp_ = other.exp_;
			this.mGMLHMFJCMB_ = ((other.mGMLHMFJCMB_ != null) ? other.mGMLHMFJCMB_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008511 RID: 34065 RVA: 0x0015F3B8 File Offset: 0x0015D5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumInfoChangedScNotify Clone()
		{
			return new MuseumInfoChangedScNotify(this);
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x06008512 RID: 34066 RVA: 0x0015F3C0 File Offset: 0x0015D5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IKHGKNMLHCN
		{
			get
			{
				return this.iKHGKNMLHCN_;
			}
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x06008513 RID: 34067 RVA: 0x0015F3C8 File Offset: 0x0015D5C8
		// (set) Token: 0x06008514 RID: 34068 RVA: 0x0015F3D0 File Offset: 0x0015D5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GKFDGDNNEEO
		{
			get
			{
				return this.gKFDGDNNEEO_;
			}
			set
			{
				this.gKFDGDNNEEO_ = value;
			}
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x06008515 RID: 34069 RVA: 0x0015F3D9 File Offset: 0x0015D5D9
		// (set) Token: 0x06008516 RID: 34070 RVA: 0x0015F3E1 File Offset: 0x0015D5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x06008517 RID: 34071 RVA: 0x0015F3EA File Offset: 0x0015D5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FDBDOCPEICN> DOAPPNKFLPL
		{
			get
			{
				return this.dOAPPNKFLPL_;
			}
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x06008518 RID: 34072 RVA: 0x0015F3F2 File Offset: 0x0015D5F2
		// (set) Token: 0x06008519 RID: 34073 RVA: 0x0015F3FA File Offset: 0x0015D5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DMENOFHEGFK
		{
			get
			{
				return this.dMENOFHEGFK_;
			}
			set
			{
				this.dMENOFHEGFK_ = value;
			}
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x0600851A RID: 34074 RVA: 0x0015F403 File Offset: 0x0015D603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MBGFFCELGHO> FOFHPBEAAFE
		{
			get
			{
				return this.fOFHPBEAAFE_;
			}
		}

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x0600851B RID: 34075 RVA: 0x0015F40B File Offset: 0x0015D60B
		// (set) Token: 0x0600851C RID: 34076 RVA: 0x0015F413 File Offset: 0x0015D613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NEJENNBOOBH
		{
			get
			{
				return this.nEJENNBOOBH_;
			}
			set
			{
				this.nEJENNBOOBH_ = value;
			}
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x0600851D RID: 34077 RVA: 0x0015F41C File Offset: 0x0015D61C
		// (set) Token: 0x0600851E RID: 34078 RVA: 0x0015F424 File Offset: 0x0015D624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMIDJEHMHMP
		{
			get
			{
				return this.mMIDJEHMHMP_;
			}
			set
			{
				this.mMIDJEHMHMP_ = value;
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x0600851F RID: 34079 RVA: 0x0015F42D File Offset: 0x0015D62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> OBKJOCMKICE
		{
			get
			{
				return this.oBKJOCMKICE_;
			}
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x06008520 RID: 34080 RVA: 0x0015F435 File Offset: 0x0015D635
		// (set) Token: 0x06008521 RID: 34081 RVA: 0x0015F43D File Offset: 0x0015D63D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JCBEHHMALNP
		{
			get
			{
				return this.jCBEHHMALNP_;
			}
			set
			{
				this.jCBEHHMALNP_ = value;
			}
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x06008522 RID: 34082 RVA: 0x0015F446 File Offset: 0x0015D646
		// (set) Token: 0x06008523 RID: 34083 RVA: 0x0015F44E File Offset: 0x0015D64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GFIBLHPDGNE PIDAMMINCFB
		{
			get
			{
				return this.pIDAMMINCFB_;
			}
			set
			{
				this.pIDAMMINCFB_ = value;
			}
		}

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x06008524 RID: 34084 RVA: 0x0015F457 File Offset: 0x0015D657
		// (set) Token: 0x06008525 RID: 34085 RVA: 0x0015F45F File Offset: 0x0015D65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x06008526 RID: 34086 RVA: 0x0015F468 File Offset: 0x0015D668
		// (set) Token: 0x06008527 RID: 34087 RVA: 0x0015F470 File Offset: 0x0015D670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FMDGFCNOKMN MGMLHMFJCMB
		{
			get
			{
				return this.mGMLHMFJCMB_;
			}
			set
			{
				this.mGMLHMFJCMB_ = value;
			}
		}

		// Token: 0x06008528 RID: 34088 RVA: 0x0015F479 File Offset: 0x0015D679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumInfoChangedScNotify);
		}

		// Token: 0x06008529 RID: 34089 RVA: 0x0015F488 File Offset: 0x0015D688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumInfoChangedScNotify other)
		{
			return other != null && (other == this || (this.iKHGKNMLHCN_.Equals(other.iKHGKNMLHCN_) && this.GKFDGDNNEEO == other.GKFDGDNNEEO && this.Level == other.Level && this.dOAPPNKFLPL_.Equals(other.dOAPPNKFLPL_) && this.DMENOFHEGFK == other.DMENOFHEGFK && this.fOFHPBEAAFE_.Equals(other.fOFHPBEAAFE_) && this.NEJENNBOOBH == other.NEJENNBOOBH && this.MMIDJEHMHMP == other.MMIDJEHMHMP && this.oBKJOCMKICE_.Equals(other.oBKJOCMKICE_) && this.JCBEHHMALNP == other.JCBEHHMALNP && object.Equals(this.PIDAMMINCFB, other.PIDAMMINCFB) && this.Exp == other.Exp && object.Equals(this.MGMLHMFJCMB, other.MGMLHMFJCMB) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600852A RID: 34090 RVA: 0x0015F5A0 File Offset: 0x0015D7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.iKHGKNMLHCN_.GetHashCode();
			if (this.GKFDGDNNEEO != 0U)
			{
				num ^= this.GKFDGDNNEEO.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			num ^= this.dOAPPNKFLPL_.GetHashCode();
			if (this.DMENOFHEGFK != 0U)
			{
				num ^= this.DMENOFHEGFK.GetHashCode();
			}
			num ^= this.fOFHPBEAAFE_.GetHashCode();
			if (this.NEJENNBOOBH != 0U)
			{
				num ^= this.NEJENNBOOBH.GetHashCode();
			}
			if (this.MMIDJEHMHMP != 0U)
			{
				num ^= this.MMIDJEHMHMP.GetHashCode();
			}
			num ^= this.oBKJOCMKICE_.GetHashCode();
			if (this.JCBEHHMALNP != 0U)
			{
				num ^= this.JCBEHHMALNP.GetHashCode();
			}
			if (this.pIDAMMINCFB_ != null)
			{
				num ^= this.PIDAMMINCFB.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.mGMLHMFJCMB_ != null)
			{
				num ^= this.MGMLHMFJCMB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600852B RID: 34091 RVA: 0x0015F6D9 File Offset: 0x0015D8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600852C RID: 34092 RVA: 0x0015F6E1 File Offset: 0x0015D8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600852D RID: 34093 RVA: 0x0015F6EC File Offset: 0x0015D8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GKFDGDNNEEO != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GKFDGDNNEEO);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Exp);
			}
			this.oBKJOCMKICE_.WriteTo(ref output, MuseumInfoChangedScNotify._repeated_oBKJOCMKICE_codec);
			if (this.Level != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Level);
			}
			this.dOAPPNKFLPL_.WriteTo(ref output, MuseumInfoChangedScNotify._repeated_dOAPPNKFLPL_codec);
			if (this.MMIDJEHMHMP != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MMIDJEHMHMP);
			}
			if (this.pIDAMMINCFB_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PIDAMMINCFB);
			}
			if (this.mGMLHMFJCMB_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.MGMLHMFJCMB);
			}
			this.iKHGKNMLHCN_.WriteTo(ref output, MuseumInfoChangedScNotify._repeated_iKHGKNMLHCN_codec);
			if (this.NEJENNBOOBH != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.NEJENNBOOBH);
			}
			if (this.JCBEHHMALNP != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.JCBEHHMALNP);
			}
			this.fOFHPBEAAFE_.WriteTo(ref output, MuseumInfoChangedScNotify._repeated_fOFHPBEAAFE_codec);
			if (this.DMENOFHEGFK != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.DMENOFHEGFK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600852E RID: 34094 RVA: 0x0015F84C File Offset: 0x0015DA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.iKHGKNMLHCN_.CalculateSize(MuseumInfoChangedScNotify._repeated_iKHGKNMLHCN_codec);
			if (this.GKFDGDNNEEO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKFDGDNNEEO);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			num += this.dOAPPNKFLPL_.CalculateSize(MuseumInfoChangedScNotify._repeated_dOAPPNKFLPL_codec);
			if (this.DMENOFHEGFK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DMENOFHEGFK);
			}
			num += this.fOFHPBEAAFE_.CalculateSize(MuseumInfoChangedScNotify._repeated_fOFHPBEAAFE_codec);
			if (this.NEJENNBOOBH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NEJENNBOOBH);
			}
			if (this.MMIDJEHMHMP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMIDJEHMHMP);
			}
			num += this.oBKJOCMKICE_.CalculateSize(MuseumInfoChangedScNotify._repeated_oBKJOCMKICE_codec);
			if (this.JCBEHHMALNP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JCBEHHMALNP);
			}
			if (this.pIDAMMINCFB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PIDAMMINCFB);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.mGMLHMFJCMB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MGMLHMFJCMB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600852F RID: 34095 RVA: 0x0015F998 File Offset: 0x0015DB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumInfoChangedScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.iKHGKNMLHCN_.Add(other.iKHGKNMLHCN_);
			if (other.GKFDGDNNEEO != 0U)
			{
				this.GKFDGDNNEEO = other.GKFDGDNNEEO;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this.dOAPPNKFLPL_.Add(other.dOAPPNKFLPL_);
			if (other.DMENOFHEGFK != 0U)
			{
				this.DMENOFHEGFK = other.DMENOFHEGFK;
			}
			this.fOFHPBEAAFE_.Add(other.fOFHPBEAAFE_);
			if (other.NEJENNBOOBH != 0U)
			{
				this.NEJENNBOOBH = other.NEJENNBOOBH;
			}
			if (other.MMIDJEHMHMP != 0U)
			{
				this.MMIDJEHMHMP = other.MMIDJEHMHMP;
			}
			this.oBKJOCMKICE_.Add(other.oBKJOCMKICE_);
			if (other.JCBEHHMALNP != 0U)
			{
				this.JCBEHHMALNP = other.JCBEHHMALNP;
			}
			if (other.pIDAMMINCFB_ != null)
			{
				if (this.pIDAMMINCFB_ == null)
				{
					this.PIDAMMINCFB = new GFIBLHPDGNE();
				}
				this.PIDAMMINCFB.MergeFrom(other.PIDAMMINCFB);
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.mGMLHMFJCMB_ != null)
			{
				if (this.mGMLHMFJCMB_ == null)
				{
					this.MGMLHMFJCMB = new FMDGFCNOKMN();
				}
				this.MGMLHMFJCMB.MergeFrom(other.MGMLHMFJCMB);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008530 RID: 34096 RVA: 0x0015FAE8 File Offset: 0x0015DCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008531 RID: 34097 RVA: 0x0015FAF4 File Offset: 0x0015DCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 32U)
					{
						if (num == 8U)
						{
							this.GKFDGDNNEEO = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Exp = input.ReadUInt32();
							continue;
						}
						if (num != 32U)
						{
							goto IL_A6;
						}
					}
					else if (num <= 40U)
					{
						if (num != 34U)
						{
							if (num != 40U)
							{
								goto IL_A6;
							}
							this.Level = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							this.dOAPPNKFLPL_.AddEntriesFrom(ref input, MuseumInfoChangedScNotify._repeated_dOAPPNKFLPL_codec);
							continue;
						}
						if (num != 56U)
						{
							goto IL_A6;
						}
						this.MMIDJEHMHMP = input.ReadUInt32();
						continue;
					}
					this.oBKJOCMKICE_.AddEntriesFrom(ref input, MuseumInfoChangedScNotify._repeated_oBKJOCMKICE_codec);
					continue;
				}
				if (num <= 82U)
				{
					if (num <= 74U)
					{
						if (num == 66U)
						{
							if (this.pIDAMMINCFB_ == null)
							{
								this.PIDAMMINCFB = new GFIBLHPDGNE();
							}
							input.ReadMessage(this.PIDAMMINCFB);
							continue;
						}
						if (num == 74U)
						{
							if (this.mGMLHMFJCMB_ == null)
							{
								this.MGMLHMFJCMB = new FMDGFCNOKMN();
							}
							input.ReadMessage(this.MGMLHMFJCMB);
							continue;
						}
					}
					else if (num == 80U || num == 82U)
					{
						this.iKHGKNMLHCN_.AddEntriesFrom(ref input, MuseumInfoChangedScNotify._repeated_iKHGKNMLHCN_codec);
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.NEJENNBOOBH = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.JCBEHHMALNP = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.fOFHPBEAAFE_.AddEntriesFrom(ref input, MuseumInfoChangedScNotify._repeated_fOFHPBEAAFE_codec);
						continue;
					}
					if (num == 120U)
					{
						this.DMENOFHEGFK = input.ReadUInt32();
						continue;
					}
				}
				IL_A6:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032ED RID: 13037
		private static readonly MessageParser<MuseumInfoChangedScNotify> _parser = new MessageParser<MuseumInfoChangedScNotify>(() => new MuseumInfoChangedScNotify());

		// Token: 0x040032EE RID: 13038
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032EF RID: 13039
		public const int IKHGKNMLHCNFieldNumber = 10;

		// Token: 0x040032F0 RID: 13040
		private static readonly FieldCodec<uint> _repeated_iKHGKNMLHCN_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x040032F1 RID: 13041
		private readonly RepeatedField<uint> iKHGKNMLHCN_ = new RepeatedField<uint>();

		// Token: 0x040032F2 RID: 13042
		public const int GKFDGDNNEEOFieldNumber = 1;

		// Token: 0x040032F3 RID: 13043
		private uint gKFDGDNNEEO_;

		// Token: 0x040032F4 RID: 13044
		public const int LevelFieldNumber = 5;

		// Token: 0x040032F5 RID: 13045
		private uint level_;

		// Token: 0x040032F6 RID: 13046
		public const int DOAPPNKFLPLFieldNumber = 6;

		// Token: 0x040032F7 RID: 13047
		private static readonly FieldCodec<FDBDOCPEICN> _repeated_dOAPPNKFLPL_codec = FieldCodec.ForMessage<FDBDOCPEICN>(50U, FDBDOCPEICN.Parser);

		// Token: 0x040032F8 RID: 13048
		private readonly RepeatedField<FDBDOCPEICN> dOAPPNKFLPL_ = new RepeatedField<FDBDOCPEICN>();

		// Token: 0x040032F9 RID: 13049
		public const int DMENOFHEGFKFieldNumber = 15;

		// Token: 0x040032FA RID: 13050
		private uint dMENOFHEGFK_;

		// Token: 0x040032FB RID: 13051
		public const int FOFHPBEAAFEFieldNumber = 14;

		// Token: 0x040032FC RID: 13052
		private static readonly FieldCodec<MBGFFCELGHO> _repeated_fOFHPBEAAFE_codec = FieldCodec.ForMessage<MBGFFCELGHO>(114U, MBGFFCELGHO.Parser);

		// Token: 0x040032FD RID: 13053
		private readonly RepeatedField<MBGFFCELGHO> fOFHPBEAAFE_ = new RepeatedField<MBGFFCELGHO>();

		// Token: 0x040032FE RID: 13054
		public const int NEJENNBOOBHFieldNumber = 12;

		// Token: 0x040032FF RID: 13055
		private uint nEJENNBOOBH_;

		// Token: 0x04003300 RID: 13056
		public const int MMIDJEHMHMPFieldNumber = 7;

		// Token: 0x04003301 RID: 13057
		private uint mMIDJEHMHMP_;

		// Token: 0x04003302 RID: 13058
		public const int OBKJOCMKICEFieldNumber = 4;

		// Token: 0x04003303 RID: 13059
		private static readonly FieldCodec<uint> _repeated_oBKJOCMKICE_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04003304 RID: 13060
		private readonly RepeatedField<uint> oBKJOCMKICE_ = new RepeatedField<uint>();

		// Token: 0x04003305 RID: 13061
		public const int JCBEHHMALNPFieldNumber = 13;

		// Token: 0x04003306 RID: 13062
		private uint jCBEHHMALNP_;

		// Token: 0x04003307 RID: 13063
		public const int PIDAMMINCFBFieldNumber = 8;

		// Token: 0x04003308 RID: 13064
		private GFIBLHPDGNE pIDAMMINCFB_;

		// Token: 0x04003309 RID: 13065
		public const int ExpFieldNumber = 2;

		// Token: 0x0400330A RID: 13066
		private uint exp_;

		// Token: 0x0400330B RID: 13067
		public const int MGMLHMFJCMBFieldNumber = 9;

		// Token: 0x0400330C RID: 13068
		private FMDGFCNOKMN mGMLHMFJCMB_;
	}
}
