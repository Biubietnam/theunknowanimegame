using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000733 RID: 1843
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMonopolyInfoScRsp : IMessage<GetMonopolyInfoScRsp>, IMessage, IEquatable<GetMonopolyInfoScRsp>, IDeepCloneable<GetMonopolyInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06005254 RID: 21076 RVA: 0x000DD947 File Offset: 0x000DBB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMonopolyInfoScRsp> Parser
		{
			get
			{
				return GetMonopolyInfoScRsp._parser;
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06005255 RID: 21077 RVA: 0x000DD94E File Offset: 0x000DBB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMonopolyInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06005256 RID: 21078 RVA: 0x000DD960 File Offset: 0x000DBB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMonopolyInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x000DD967 File Offset: 0x000DBB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyInfoScRsp()
		{
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x000DD97C File Offset: 0x000DBB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyInfoScRsp(GetMonopolyInfoScRsp other) : this()
		{
			this.roomMap_ = ((other.roomMap_ != null) ? other.roomMap_.Clone() : null);
			this.iBJOOCKCFHF_ = ((other.iBJOOCKCFHF_ != null) ? other.iBJOOCKCFHF_.Clone() : null);
			this.rogueBuffInfo_ = ((other.rogueBuffInfo_ != null) ? other.rogueBuffInfo_.Clone() : null);
			this.oCJONDAINGB_ = ((other.oCJONDAINGB_ != null) ? other.oCJONDAINGB_.Clone() : null);
			this.bCNOIFKDEFO_ = ((other.bCNOIFKDEFO_ != null) ? other.bCNOIFKDEFO_.Clone() : null);
			this.dMBOMNEILKG_ = ((other.dMBOMNEILKG_ != null) ? other.dMBOMNEILKG_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.pOJBLJNDABI_ = other.pOJBLJNDABI_.Clone();
			this.pCOEFKDDBOE_ = ((other.pCOEFKDDBOE_ != null) ? other.pCOEFKDDBOE_.Clone() : null);
			this.oBBICMBHBMO_ = ((other.oBBICMBHBMO_ != null) ? other.oBBICMBHBMO_.Clone() : null);
			this.aLAGJNMDPEN_ = ((other.aLAGJNMDPEN_ != null) ? other.aLAGJNMDPEN_.Clone() : null);
			this.kLNPKPIMKHJ_ = ((other.kLNPKPIMKHJ_ != null) ? other.kLNPKPIMKHJ_.Clone() : null);
			this.stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x000DDAF1 File Offset: 0x000DBCF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyInfoScRsp Clone()
		{
			return new GetMonopolyInfoScRsp(this);
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0600525A RID: 21082 RVA: 0x000DDAF9 File Offset: 0x000DBCF9
		// (set) Token: 0x0600525B RID: 21083 RVA: 0x000DDB01 File Offset: 0x000DBD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMICCBDOCGG RoomMap
		{
			get
			{
				return this.roomMap_;
			}
			set
			{
				this.roomMap_ = value;
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x0600525C RID: 21084 RVA: 0x000DDB0A File Offset: 0x000DBD0A
		// (set) Token: 0x0600525D RID: 21085 RVA: 0x000DDB12 File Offset: 0x000DBD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NHMKOHAACCC IBJOOCKCFHF
		{
			get
			{
				return this.iBJOOCKCFHF_;
			}
			set
			{
				this.iBJOOCKCFHF_ = value;
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x0600525E RID: 21086 RVA: 0x000DDB1B File Offset: 0x000DBD1B
		// (set) Token: 0x0600525F RID: 21087 RVA: 0x000DDB23 File Offset: 0x000DBD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HHPGOCKNJCN RogueBuffInfo
		{
			get
			{
				return this.rogueBuffInfo_;
			}
			set
			{
				this.rogueBuffInfo_ = value;
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06005260 RID: 21088 RVA: 0x000DDB2C File Offset: 0x000DBD2C
		// (set) Token: 0x06005261 RID: 21089 RVA: 0x000DDB34 File Offset: 0x000DBD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AAOIINGJMGB OCJONDAINGB
		{
			get
			{
				return this.oCJONDAINGB_;
			}
			set
			{
				this.oCJONDAINGB_ = value;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06005262 RID: 21090 RVA: 0x000DDB3D File Offset: 0x000DBD3D
		// (set) Token: 0x06005263 RID: 21091 RVA: 0x000DDB45 File Offset: 0x000DBD45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPPOBBBBJJ BCNOIFKDEFO
		{
			get
			{
				return this.bCNOIFKDEFO_;
			}
			set
			{
				this.bCNOIFKDEFO_ = value;
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06005264 RID: 21092 RVA: 0x000DDB4E File Offset: 0x000DBD4E
		// (set) Token: 0x06005265 RID: 21093 RVA: 0x000DDB56 File Offset: 0x000DBD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KCLICGHKKPH DMBOMNEILKG
		{
			get
			{
				return this.dMBOMNEILKG_;
			}
			set
			{
				this.dMBOMNEILKG_ = value;
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06005266 RID: 21094 RVA: 0x000DDB5F File Offset: 0x000DBD5F
		// (set) Token: 0x06005267 RID: 21095 RVA: 0x000DDB67 File Offset: 0x000DBD67
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

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06005268 RID: 21096 RVA: 0x000DDB70 File Offset: 0x000DBD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> POJBLJNDABI
		{
			get
			{
				return this.pOJBLJNDABI_;
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06005269 RID: 21097 RVA: 0x000DDB78 File Offset: 0x000DBD78
		// (set) Token: 0x0600526A RID: 21098 RVA: 0x000DDB80 File Offset: 0x000DBD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEEFPPBEAOF PCOEFKDDBOE
		{
			get
			{
				return this.pCOEFKDDBOE_;
			}
			set
			{
				this.pCOEFKDDBOE_ = value;
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x0600526B RID: 21099 RVA: 0x000DDB89 File Offset: 0x000DBD89
		// (set) Token: 0x0600526C RID: 21100 RVA: 0x000DDB91 File Offset: 0x000DBD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GGFPEEMILPL OBBICMBHBMO
		{
			get
			{
				return this.oBBICMBHBMO_;
			}
			set
			{
				this.oBBICMBHBMO_ = value;
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x0600526D RID: 21101 RVA: 0x000DDB9A File Offset: 0x000DBD9A
		// (set) Token: 0x0600526E RID: 21102 RVA: 0x000DDBA2 File Offset: 0x000DBDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BEJAIEGKJCN ALAGJNMDPEN
		{
			get
			{
				return this.aLAGJNMDPEN_;
			}
			set
			{
				this.aLAGJNMDPEN_ = value;
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x0600526F RID: 21103 RVA: 0x000DDBAB File Offset: 0x000DBDAB
		// (set) Token: 0x06005270 RID: 21104 RVA: 0x000DDBB3 File Offset: 0x000DBDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AFFKECMGPEI KLNPKPIMKHJ
		{
			get
			{
				return this.kLNPKPIMKHJ_;
			}
			set
			{
				this.kLNPKPIMKHJ_ = value;
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06005271 RID: 21105 RVA: 0x000DDBBC File Offset: 0x000DBDBC
		// (set) Token: 0x06005272 RID: 21106 RVA: 0x000DDBC4 File Offset: 0x000DBDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAPEPLFDCON Stt
		{
			get
			{
				return this.stt_;
			}
			set
			{
				this.stt_ = value;
			}
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x000DDBCD File Offset: 0x000DBDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMonopolyInfoScRsp);
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x000DDBDC File Offset: 0x000DBDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMonopolyInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RoomMap, other.RoomMap) && object.Equals(this.IBJOOCKCFHF, other.IBJOOCKCFHF) && object.Equals(this.RogueBuffInfo, other.RogueBuffInfo) && object.Equals(this.OCJONDAINGB, other.OCJONDAINGB) && object.Equals(this.BCNOIFKDEFO, other.BCNOIFKDEFO) && object.Equals(this.DMBOMNEILKG, other.DMBOMNEILKG) && this.Retcode == other.Retcode && this.pOJBLJNDABI_.Equals(other.pOJBLJNDABI_) && object.Equals(this.PCOEFKDDBOE, other.PCOEFKDDBOE) && object.Equals(this.OBBICMBHBMO, other.OBBICMBHBMO) && object.Equals(this.ALAGJNMDPEN, other.ALAGJNMDPEN) && object.Equals(this.KLNPKPIMKHJ, other.KLNPKPIMKHJ) && object.Equals(this.Stt, other.Stt) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x000DDD14 File Offset: 0x000DBF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roomMap_ != null)
			{
				num ^= this.RoomMap.GetHashCode();
			}
			if (this.iBJOOCKCFHF_ != null)
			{
				num ^= this.IBJOOCKCFHF.GetHashCode();
			}
			if (this.rogueBuffInfo_ != null)
			{
				num ^= this.RogueBuffInfo.GetHashCode();
			}
			if (this.oCJONDAINGB_ != null)
			{
				num ^= this.OCJONDAINGB.GetHashCode();
			}
			if (this.bCNOIFKDEFO_ != null)
			{
				num ^= this.BCNOIFKDEFO.GetHashCode();
			}
			if (this.dMBOMNEILKG_ != null)
			{
				num ^= this.DMBOMNEILKG.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.pOJBLJNDABI_.GetHashCode();
			if (this.pCOEFKDDBOE_ != null)
			{
				num ^= this.PCOEFKDDBOE.GetHashCode();
			}
			if (this.oBBICMBHBMO_ != null)
			{
				num ^= this.OBBICMBHBMO.GetHashCode();
			}
			if (this.aLAGJNMDPEN_ != null)
			{
				num ^= this.ALAGJNMDPEN.GetHashCode();
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				num ^= this.KLNPKPIMKHJ.GetHashCode();
			}
			if (this.stt_ != null)
			{
				num ^= this.Stt.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x000DDE53 File Offset: 0x000DC053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x000DDE5B File Offset: 0x000DC05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x000DDE64 File Offset: 0x000DC064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pOJBLJNDABI_.WriteTo(ref output, GetMonopolyInfoScRsp._repeated_pOJBLJNDABI_codec);
			if (this.kLNPKPIMKHJ_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.KLNPKPIMKHJ);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueBuffInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueBuffInfo);
			}
			if (this.dMBOMNEILKG_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.DMBOMNEILKG);
			}
			if (this.roomMap_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RoomMap);
			}
			if (this.pCOEFKDDBOE_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PCOEFKDDBOE);
			}
			if (this.stt_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Stt);
			}
			if (this.iBJOOCKCFHF_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.IBJOOCKCFHF);
			}
			if (this.aLAGJNMDPEN_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ALAGJNMDPEN);
			}
			if (this.oCJONDAINGB_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.OCJONDAINGB);
			}
			if (this.oBBICMBHBMO_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.OBBICMBHBMO);
			}
			if (this.bCNOIFKDEFO_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.BCNOIFKDEFO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x000DDFE8 File Offset: 0x000DC1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roomMap_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoomMap);
			}
			if (this.iBJOOCKCFHF_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IBJOOCKCFHF);
			}
			if (this.rogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuffInfo);
			}
			if (this.oCJONDAINGB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OCJONDAINGB);
			}
			if (this.bCNOIFKDEFO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BCNOIFKDEFO);
			}
			if (this.dMBOMNEILKG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DMBOMNEILKG);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.pOJBLJNDABI_.CalculateSize(GetMonopolyInfoScRsp._repeated_pOJBLJNDABI_codec);
			if (this.pCOEFKDDBOE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PCOEFKDDBOE);
			}
			if (this.oBBICMBHBMO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OBBICMBHBMO);
			}
			if (this.aLAGJNMDPEN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ALAGJNMDPEN);
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KLNPKPIMKHJ);
			}
			if (this.stt_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Stt);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x000DE144 File Offset: 0x000DC344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMonopolyInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roomMap_ != null)
			{
				if (this.roomMap_ == null)
				{
					this.RoomMap = new BMICCBDOCGG();
				}
				this.RoomMap.MergeFrom(other.RoomMap);
			}
			if (other.iBJOOCKCFHF_ != null)
			{
				if (this.iBJOOCKCFHF_ == null)
				{
					this.IBJOOCKCFHF = new NHMKOHAACCC();
				}
				this.IBJOOCKCFHF.MergeFrom(other.IBJOOCKCFHF);
			}
			if (other.rogueBuffInfo_ != null)
			{
				if (this.rogueBuffInfo_ == null)
				{
					this.RogueBuffInfo = new HHPGOCKNJCN();
				}
				this.RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
			}
			if (other.oCJONDAINGB_ != null)
			{
				if (this.oCJONDAINGB_ == null)
				{
					this.OCJONDAINGB = new AAOIINGJMGB();
				}
				this.OCJONDAINGB.MergeFrom(other.OCJONDAINGB);
			}
			if (other.bCNOIFKDEFO_ != null)
			{
				if (this.bCNOIFKDEFO_ == null)
				{
					this.BCNOIFKDEFO = new FIPPOBBBBJJ();
				}
				this.BCNOIFKDEFO.MergeFrom(other.BCNOIFKDEFO);
			}
			if (other.dMBOMNEILKG_ != null)
			{
				if (this.dMBOMNEILKG_ == null)
				{
					this.DMBOMNEILKG = new KCLICGHKKPH();
				}
				this.DMBOMNEILKG.MergeFrom(other.DMBOMNEILKG);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.pOJBLJNDABI_.Add(other.pOJBLJNDABI_);
			if (other.pCOEFKDDBOE_ != null)
			{
				if (this.pCOEFKDDBOE_ == null)
				{
					this.PCOEFKDDBOE = new OEEFPPBEAOF();
				}
				this.PCOEFKDDBOE.MergeFrom(other.PCOEFKDDBOE);
			}
			if (other.oBBICMBHBMO_ != null)
			{
				if (this.oBBICMBHBMO_ == null)
				{
					this.OBBICMBHBMO = new GGFPEEMILPL();
				}
				this.OBBICMBHBMO.MergeFrom(other.OBBICMBHBMO);
			}
			if (other.aLAGJNMDPEN_ != null)
			{
				if (this.aLAGJNMDPEN_ == null)
				{
					this.ALAGJNMDPEN = new BEJAIEGKJCN();
				}
				this.ALAGJNMDPEN.MergeFrom(other.ALAGJNMDPEN);
			}
			if (other.kLNPKPIMKHJ_ != null)
			{
				if (this.kLNPKPIMKHJ_ == null)
				{
					this.KLNPKPIMKHJ = new AFFKECMGPEI();
				}
				this.KLNPKPIMKHJ.MergeFrom(other.KLNPKPIMKHJ);
			}
			if (other.stt_ != null)
			{
				if (this.stt_ == null)
				{
					this.Stt = new PAPEPLFDCON();
				}
				this.Stt.MergeFrom(other.Stt);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x000DE375 File Offset: 0x000DC575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x000DE380 File Offset: 0x000DC580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num <= 18U)
					{
						if (num == 8U || num == 10U)
						{
							this.pOJBLJNDABI_.AddEntriesFrom(ref input, GetMonopolyInfoScRsp._repeated_pOJBLJNDABI_codec);
							continue;
						}
						if (num == 18U)
						{
							if (this.kLNPKPIMKHJ_ == null)
							{
								this.KLNPKPIMKHJ = new AFFKECMGPEI();
							}
							input.ReadMessage(this.KLNPKPIMKHJ);
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 32U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
						if (num == 42U)
						{
							if (this.rogueBuffInfo_ == null)
							{
								this.RogueBuffInfo = new HHPGOCKNJCN();
							}
							input.ReadMessage(this.RogueBuffInfo);
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.dMBOMNEILKG_ == null)
							{
								this.DMBOMNEILKG = new KCLICGHKKPH();
							}
							input.ReadMessage(this.DMBOMNEILKG);
							continue;
						}
						if (num == 58U)
						{
							if (this.roomMap_ == null)
							{
								this.RoomMap = new BMICCBDOCGG();
							}
							input.ReadMessage(this.RoomMap);
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 66U)
					{
						if (this.pCOEFKDDBOE_ == null)
						{
							this.PCOEFKDDBOE = new OEEFPPBEAOF();
						}
						input.ReadMessage(this.PCOEFKDDBOE);
						continue;
					}
					if (num == 74U)
					{
						if (this.stt_ == null)
						{
							this.Stt = new PAPEPLFDCON();
						}
						input.ReadMessage(this.Stt);
						continue;
					}
					if (num == 82U)
					{
						if (this.iBJOOCKCFHF_ == null)
						{
							this.IBJOOCKCFHF = new NHMKOHAACCC();
						}
						input.ReadMessage(this.IBJOOCKCFHF);
						continue;
					}
				}
				else if (num <= 98U)
				{
					if (num == 90U)
					{
						if (this.aLAGJNMDPEN_ == null)
						{
							this.ALAGJNMDPEN = new BEJAIEGKJCN();
						}
						input.ReadMessage(this.ALAGJNMDPEN);
						continue;
					}
					if (num == 98U)
					{
						if (this.oCJONDAINGB_ == null)
						{
							this.OCJONDAINGB = new AAOIINGJMGB();
						}
						input.ReadMessage(this.OCJONDAINGB);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.oBBICMBHBMO_ == null)
						{
							this.OBBICMBHBMO = new GGFPEEMILPL();
						}
						input.ReadMessage(this.OBBICMBHBMO);
						continue;
					}
					if (num == 114U)
					{
						if (this.bCNOIFKDEFO_ == null)
						{
							this.BCNOIFKDEFO = new FIPPOBBBBJJ();
						}
						input.ReadMessage(this.BCNOIFKDEFO);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002058 RID: 8280
		private static readonly MessageParser<GetMonopolyInfoScRsp> _parser = new MessageParser<GetMonopolyInfoScRsp>(() => new GetMonopolyInfoScRsp());

		// Token: 0x04002059 RID: 8281
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400205A RID: 8282
		public const int RoomMapFieldNumber = 7;

		// Token: 0x0400205B RID: 8283
		private BMICCBDOCGG roomMap_;

		// Token: 0x0400205C RID: 8284
		public const int IBJOOCKCFHFFieldNumber = 10;

		// Token: 0x0400205D RID: 8285
		private NHMKOHAACCC iBJOOCKCFHF_;

		// Token: 0x0400205E RID: 8286
		public const int RogueBuffInfoFieldNumber = 5;

		// Token: 0x0400205F RID: 8287
		private HHPGOCKNJCN rogueBuffInfo_;

		// Token: 0x04002060 RID: 8288
		public const int OCJONDAINGBFieldNumber = 12;

		// Token: 0x04002061 RID: 8289
		private AAOIINGJMGB oCJONDAINGB_;

		// Token: 0x04002062 RID: 8290
		public const int BCNOIFKDEFOFieldNumber = 14;

		// Token: 0x04002063 RID: 8291
		private FIPPOBBBBJJ bCNOIFKDEFO_;

		// Token: 0x04002064 RID: 8292
		public const int DMBOMNEILKGFieldNumber = 6;

		// Token: 0x04002065 RID: 8293
		private KCLICGHKKPH dMBOMNEILKG_;

		// Token: 0x04002066 RID: 8294
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04002067 RID: 8295
		private uint retcode_;

		// Token: 0x04002068 RID: 8296
		public const int POJBLJNDABIFieldNumber = 1;

		// Token: 0x04002069 RID: 8297
		private static readonly FieldCodec<uint> _repeated_pOJBLJNDABI_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400206A RID: 8298
		private readonly RepeatedField<uint> pOJBLJNDABI_ = new RepeatedField<uint>();

		// Token: 0x0400206B RID: 8299
		public const int PCOEFKDDBOEFieldNumber = 8;

		// Token: 0x0400206C RID: 8300
		private OEEFPPBEAOF pCOEFKDDBOE_;

		// Token: 0x0400206D RID: 8301
		public const int OBBICMBHBMOFieldNumber = 13;

		// Token: 0x0400206E RID: 8302
		private GGFPEEMILPL oBBICMBHBMO_;

		// Token: 0x0400206F RID: 8303
		public const int ALAGJNMDPENFieldNumber = 11;

		// Token: 0x04002070 RID: 8304
		private BEJAIEGKJCN aLAGJNMDPEN_;

		// Token: 0x04002071 RID: 8305
		public const int KLNPKPIMKHJFieldNumber = 2;

		// Token: 0x04002072 RID: 8306
		private AFFKECMGPEI kLNPKPIMKHJ_;

		// Token: 0x04002073 RID: 8307
		public const int SttFieldNumber = 9;

		// Token: 0x04002074 RID: 8308
		private PAPEPLFDCON stt_;
	}
}
