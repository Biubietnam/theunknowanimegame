using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000747 RID: 1863
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMuseumInfoScRsp : IMessage<GetMuseumInfoScRsp>, IMessage, IEquatable<GetMuseumInfoScRsp>, IDeepCloneable<GetMuseumInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x0600533B RID: 21307 RVA: 0x000E0061 File Offset: 0x000DE261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMuseumInfoScRsp> Parser
		{
			get
			{
				return GetMuseumInfoScRsp._parser;
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x0600533C RID: 21308 RVA: 0x000E0068 File Offset: 0x000DE268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMuseumInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x0600533D RID: 21309 RVA: 0x000E007A File Offset: 0x000DE27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMuseumInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x000E0081 File Offset: 0x000DE281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMuseumInfoScRsp()
		{
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x000E00B8 File Offset: 0x000DE2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMuseumInfoScRsp(GetMuseumInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.jCBEHHMALNP_ = other.jCBEHHMALNP_;
			this.gKFDGDNNEEO_ = other.gKFDGDNNEEO_;
			this.mGMLHMFJCMB_ = ((other.mGMLHMFJCMB_ != null) ? other.mGMLHMFJCMB_.Clone() : null);
			this.oBKJOCMKICE_ = other.oBKJOCMKICE_.Clone();
			this.fOFHPBEAAFE_ = other.fOFHPBEAAFE_.Clone();
			this.dOAPPNKFLPL_ = other.dOAPPNKFLPL_.Clone();
			this.mMIDJEHMHMP_ = other.mMIDJEHMHMP_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.dMENOFHEGFK_ = other.dMENOFHEGFK_;
			this.nEJENNBOOBH_ = other.nEJENNBOOBH_;
			this.pIDAMMINCFB_ = ((other.pIDAMMINCFB_ != null) ? other.pIDAMMINCFB_.Clone() : null);
			this.iKHGKNMLHCN_ = other.iKHGKNMLHCN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x000E01B8 File Offset: 0x000DE3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMuseumInfoScRsp Clone()
		{
			return new GetMuseumInfoScRsp(this);
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06005341 RID: 21313 RVA: 0x000E01C0 File Offset: 0x000DE3C0
		// (set) Token: 0x06005342 RID: 21314 RVA: 0x000E01C8 File Offset: 0x000DE3C8
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

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06005343 RID: 21315 RVA: 0x000E01D1 File Offset: 0x000DE3D1
		// (set) Token: 0x06005344 RID: 21316 RVA: 0x000E01D9 File Offset: 0x000DE3D9
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

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06005345 RID: 21317 RVA: 0x000E01E2 File Offset: 0x000DE3E2
		// (set) Token: 0x06005346 RID: 21318 RVA: 0x000E01EA File Offset: 0x000DE3EA
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

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06005347 RID: 21319 RVA: 0x000E01F3 File Offset: 0x000DE3F3
		// (set) Token: 0x06005348 RID: 21320 RVA: 0x000E01FB File Offset: 0x000DE3FB
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

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06005349 RID: 21321 RVA: 0x000E0204 File Offset: 0x000DE404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> OBKJOCMKICE
		{
			get
			{
				return this.oBKJOCMKICE_;
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x0600534A RID: 21322 RVA: 0x000E020C File Offset: 0x000DE40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MBGFFCELGHO> FOFHPBEAAFE
		{
			get
			{
				return this.fOFHPBEAAFE_;
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x0600534B RID: 21323 RVA: 0x000E0214 File Offset: 0x000DE414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FDBDOCPEICN> DOAPPNKFLPL
		{
			get
			{
				return this.dOAPPNKFLPL_;
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x0600534C RID: 21324 RVA: 0x000E021C File Offset: 0x000DE41C
		// (set) Token: 0x0600534D RID: 21325 RVA: 0x000E0224 File Offset: 0x000DE424
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

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x0600534E RID: 21326 RVA: 0x000E022D File Offset: 0x000DE42D
		// (set) Token: 0x0600534F RID: 21327 RVA: 0x000E0235 File Offset: 0x000DE435
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

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x000E023E File Offset: 0x000DE43E
		// (set) Token: 0x06005351 RID: 21329 RVA: 0x000E0246 File Offset: 0x000DE446
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

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06005352 RID: 21330 RVA: 0x000E024F File Offset: 0x000DE44F
		// (set) Token: 0x06005353 RID: 21331 RVA: 0x000E0257 File Offset: 0x000DE457
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

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06005354 RID: 21332 RVA: 0x000E0260 File Offset: 0x000DE460
		// (set) Token: 0x06005355 RID: 21333 RVA: 0x000E0268 File Offset: 0x000DE468
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

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06005356 RID: 21334 RVA: 0x000E0271 File Offset: 0x000DE471
		// (set) Token: 0x06005357 RID: 21335 RVA: 0x000E0279 File Offset: 0x000DE479
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

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06005358 RID: 21336 RVA: 0x000E0282 File Offset: 0x000DE482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IKHGKNMLHCN
		{
			get
			{
				return this.iKHGKNMLHCN_;
			}
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x000E028A File Offset: 0x000DE48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMuseumInfoScRsp);
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x000E0298 File Offset: 0x000DE498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMuseumInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.JCBEHHMALNP == other.JCBEHHMALNP && this.GKFDGDNNEEO == other.GKFDGDNNEEO && object.Equals(this.MGMLHMFJCMB, other.MGMLHMFJCMB) && this.oBKJOCMKICE_.Equals(other.oBKJOCMKICE_) && this.fOFHPBEAAFE_.Equals(other.fOFHPBEAAFE_) && this.dOAPPNKFLPL_.Equals(other.dOAPPNKFLPL_) && this.MMIDJEHMHMP == other.MMIDJEHMHMP && this.Level == other.Level && this.Exp == other.Exp && this.DMENOFHEGFK == other.DMENOFHEGFK && this.NEJENNBOOBH == other.NEJENNBOOBH && object.Equals(this.PIDAMMINCFB, other.PIDAMMINCFB) && this.iKHGKNMLHCN_.Equals(other.iKHGKNMLHCN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x000E03C0 File Offset: 0x000DE5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.JCBEHHMALNP != 0U)
			{
				num ^= this.JCBEHHMALNP.GetHashCode();
			}
			if (this.GKFDGDNNEEO != 0U)
			{
				num ^= this.GKFDGDNNEEO.GetHashCode();
			}
			if (this.mGMLHMFJCMB_ != null)
			{
				num ^= this.MGMLHMFJCMB.GetHashCode();
			}
			num ^= this.oBKJOCMKICE_.GetHashCode();
			num ^= this.fOFHPBEAAFE_.GetHashCode();
			num ^= this.dOAPPNKFLPL_.GetHashCode();
			if (this.MMIDJEHMHMP != 0U)
			{
				num ^= this.MMIDJEHMHMP.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.DMENOFHEGFK != 0U)
			{
				num ^= this.DMENOFHEGFK.GetHashCode();
			}
			if (this.NEJENNBOOBH != 0U)
			{
				num ^= this.NEJENNBOOBH.GetHashCode();
			}
			if (this.pIDAMMINCFB_ != null)
			{
				num ^= this.PIDAMMINCFB.GetHashCode();
			}
			num ^= this.iKHGKNMLHCN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x000E0512 File Offset: 0x000DE712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x000E051A File Offset: 0x000DE71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x000E0524 File Offset: 0x000DE724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pIDAMMINCFB_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PIDAMMINCFB);
			}
			if (this.GKFDGDNNEEO != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GKFDGDNNEEO);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Exp);
			}
			if (this.MMIDJEHMHMP != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MMIDJEHMHMP);
			}
			this.iKHGKNMLHCN_.WriteTo(ref output, GetMuseumInfoScRsp._repeated_iKHGKNMLHCN_codec);
			if (this.DMENOFHEGFK != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DMENOFHEGFK);
			}
			if (this.mGMLHMFJCMB_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.MGMLHMFJCMB);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			this.dOAPPNKFLPL_.WriteTo(ref output, GetMuseumInfoScRsp._repeated_dOAPPNKFLPL_codec);
			if (this.JCBEHHMALNP != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.JCBEHHMALNP);
			}
			this.fOFHPBEAAFE_.WriteTo(ref output, GetMuseumInfoScRsp._repeated_fOFHPBEAAFE_codec);
			if (this.NEJENNBOOBH != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.NEJENNBOOBH);
			}
			this.oBKJOCMKICE_.WriteTo(ref output, GetMuseumInfoScRsp._repeated_oBKJOCMKICE_codec);
			if (this.Level != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x000E06A4 File Offset: 0x000DE8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.JCBEHHMALNP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JCBEHHMALNP);
			}
			if (this.GKFDGDNNEEO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKFDGDNNEEO);
			}
			if (this.mGMLHMFJCMB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MGMLHMFJCMB);
			}
			num += this.oBKJOCMKICE_.CalculateSize(GetMuseumInfoScRsp._repeated_oBKJOCMKICE_codec);
			num += this.fOFHPBEAAFE_.CalculateSize(GetMuseumInfoScRsp._repeated_fOFHPBEAAFE_codec);
			num += this.dOAPPNKFLPL_.CalculateSize(GetMuseumInfoScRsp._repeated_dOAPPNKFLPL_codec);
			if (this.MMIDJEHMHMP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMIDJEHMHMP);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.DMENOFHEGFK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DMENOFHEGFK);
			}
			if (this.NEJENNBOOBH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NEJENNBOOBH);
			}
			if (this.pIDAMMINCFB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PIDAMMINCFB);
			}
			num += this.iKHGKNMLHCN_.CalculateSize(GetMuseumInfoScRsp._repeated_iKHGKNMLHCN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x000E0808 File Offset: 0x000DEA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMuseumInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.JCBEHHMALNP != 0U)
			{
				this.JCBEHHMALNP = other.JCBEHHMALNP;
			}
			if (other.GKFDGDNNEEO != 0U)
			{
				this.GKFDGDNNEEO = other.GKFDGDNNEEO;
			}
			if (other.mGMLHMFJCMB_ != null)
			{
				if (this.mGMLHMFJCMB_ == null)
				{
					this.MGMLHMFJCMB = new FMDGFCNOKMN();
				}
				this.MGMLHMFJCMB.MergeFrom(other.MGMLHMFJCMB);
			}
			this.oBKJOCMKICE_.Add(other.oBKJOCMKICE_);
			this.fOFHPBEAAFE_.Add(other.fOFHPBEAAFE_);
			this.dOAPPNKFLPL_.Add(other.dOAPPNKFLPL_);
			if (other.MMIDJEHMHMP != 0U)
			{
				this.MMIDJEHMHMP = other.MMIDJEHMHMP;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.DMENOFHEGFK != 0U)
			{
				this.DMENOFHEGFK = other.DMENOFHEGFK;
			}
			if (other.NEJENNBOOBH != 0U)
			{
				this.NEJENNBOOBH = other.NEJENNBOOBH;
			}
			if (other.pIDAMMINCFB_ != null)
			{
				if (this.pIDAMMINCFB_ == null)
				{
					this.PIDAMMINCFB = new GFIBLHPDGNE();
				}
				this.PIDAMMINCFB.MergeFrom(other.PIDAMMINCFB);
			}
			this.iKHGKNMLHCN_.Add(other.iKHGKNMLHCN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x000E096C File Offset: 0x000DEB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x000E0978 File Offset: 0x000DEB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num <= 32U)
					{
						if (num <= 16U)
						{
							if (num == 10U)
							{
								if (this.pIDAMMINCFB_ == null)
								{
									this.PIDAMMINCFB = new GFIBLHPDGNE();
								}
								input.ReadMessage(this.PIDAMMINCFB);
								continue;
							}
							if (num == 16U)
							{
								this.GKFDGDNNEEO = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.Exp = input.ReadUInt32();
								continue;
							}
							if (num == 32U)
							{
								this.MMIDJEHMHMP = input.ReadUInt32();
								continue;
							}
						}
					}
					else if (num <= 42U)
					{
						if (num == 40U || num == 42U)
						{
							this.iKHGKNMLHCN_.AddEntriesFrom(ref input, GetMuseumInfoScRsp._repeated_iKHGKNMLHCN_codec);
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.DMENOFHEGFK = input.ReadUInt32();
							continue;
						}
						if (num == 58U)
						{
							if (this.mGMLHMFJCMB_ == null)
							{
								this.MGMLHMFJCMB = new FMDGFCNOKMN();
							}
							input.ReadMessage(this.MGMLHMFJCMB);
							continue;
						}
					}
				}
				else
				{
					if (num > 90U)
					{
						if (num <= 112U)
						{
							if (num == 104U)
							{
								this.NEJENNBOOBH = input.ReadUInt32();
								continue;
							}
							if (num != 112U)
							{
								goto IL_B9;
							}
						}
						else if (num != 114U)
						{
							if (num != 120U)
							{
								goto IL_B9;
							}
							this.Level = input.ReadUInt32();
							continue;
						}
						this.oBKJOCMKICE_.AddEntriesFrom(ref input, GetMuseumInfoScRsp._repeated_oBKJOCMKICE_codec);
						continue;
					}
					if (num <= 74U)
					{
						if (num == 64U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
						if (num == 74U)
						{
							this.dOAPPNKFLPL_.AddEntriesFrom(ref input, GetMuseumInfoScRsp._repeated_dOAPPNKFLPL_codec);
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.JCBEHHMALNP = input.ReadUInt32();
							continue;
						}
						if (num == 90U)
						{
							this.fOFHPBEAAFE_.AddEntriesFrom(ref input, GetMuseumInfoScRsp._repeated_fOFHPBEAAFE_codec);
							continue;
						}
					}
				}
				IL_B9:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020AD RID: 8365
		private static readonly MessageParser<GetMuseumInfoScRsp> _parser = new MessageParser<GetMuseumInfoScRsp>(() => new GetMuseumInfoScRsp());

		// Token: 0x040020AE RID: 8366
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020AF RID: 8367
		public const int RetcodeFieldNumber = 8;

		// Token: 0x040020B0 RID: 8368
		private uint retcode_;

		// Token: 0x040020B1 RID: 8369
		public const int JCBEHHMALNPFieldNumber = 10;

		// Token: 0x040020B2 RID: 8370
		private uint jCBEHHMALNP_;

		// Token: 0x040020B3 RID: 8371
		public const int GKFDGDNNEEOFieldNumber = 2;

		// Token: 0x040020B4 RID: 8372
		private uint gKFDGDNNEEO_;

		// Token: 0x040020B5 RID: 8373
		public const int MGMLHMFJCMBFieldNumber = 7;

		// Token: 0x040020B6 RID: 8374
		private FMDGFCNOKMN mGMLHMFJCMB_;

		// Token: 0x040020B7 RID: 8375
		public const int OBKJOCMKICEFieldNumber = 14;

		// Token: 0x040020B8 RID: 8376
		private static readonly FieldCodec<uint> _repeated_oBKJOCMKICE_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x040020B9 RID: 8377
		private readonly RepeatedField<uint> oBKJOCMKICE_ = new RepeatedField<uint>();

		// Token: 0x040020BA RID: 8378
		public const int FOFHPBEAAFEFieldNumber = 11;

		// Token: 0x040020BB RID: 8379
		private static readonly FieldCodec<MBGFFCELGHO> _repeated_fOFHPBEAAFE_codec = FieldCodec.ForMessage<MBGFFCELGHO>(90U, MBGFFCELGHO.Parser);

		// Token: 0x040020BC RID: 8380
		private readonly RepeatedField<MBGFFCELGHO> fOFHPBEAAFE_ = new RepeatedField<MBGFFCELGHO>();

		// Token: 0x040020BD RID: 8381
		public const int DOAPPNKFLPLFieldNumber = 9;

		// Token: 0x040020BE RID: 8382
		private static readonly FieldCodec<FDBDOCPEICN> _repeated_dOAPPNKFLPL_codec = FieldCodec.ForMessage<FDBDOCPEICN>(74U, FDBDOCPEICN.Parser);

		// Token: 0x040020BF RID: 8383
		private readonly RepeatedField<FDBDOCPEICN> dOAPPNKFLPL_ = new RepeatedField<FDBDOCPEICN>();

		// Token: 0x040020C0 RID: 8384
		public const int MMIDJEHMHMPFieldNumber = 4;

		// Token: 0x040020C1 RID: 8385
		private uint mMIDJEHMHMP_;

		// Token: 0x040020C2 RID: 8386
		public const int LevelFieldNumber = 15;

		// Token: 0x040020C3 RID: 8387
		private uint level_;

		// Token: 0x040020C4 RID: 8388
		public const int ExpFieldNumber = 3;

		// Token: 0x040020C5 RID: 8389
		private uint exp_;

		// Token: 0x040020C6 RID: 8390
		public const int DMENOFHEGFKFieldNumber = 6;

		// Token: 0x040020C7 RID: 8391
		private uint dMENOFHEGFK_;

		// Token: 0x040020C8 RID: 8392
		public const int NEJENNBOOBHFieldNumber = 13;

		// Token: 0x040020C9 RID: 8393
		private uint nEJENNBOOBH_;

		// Token: 0x040020CA RID: 8394
		public const int PIDAMMINCFBFieldNumber = 1;

		// Token: 0x040020CB RID: 8395
		private GFIBLHPDGNE pIDAMMINCFB_;

		// Token: 0x040020CC RID: 8396
		public const int IKHGKNMLHCNFieldNumber = 5;

		// Token: 0x040020CD RID: 8397
		private static readonly FieldCodec<uint> _repeated_iKHGKNMLHCN_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040020CE RID: 8398
		private readonly RepeatedField<uint> iKHGKNMLHCN_ = new RepeatedField<uint>();
	}
}
