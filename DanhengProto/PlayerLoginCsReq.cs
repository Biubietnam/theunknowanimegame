using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CC3 RID: 3267
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerLoginCsReq : IMessage<PlayerLoginCsReq>, IMessage, IEquatable<PlayerLoginCsReq>, IDeepCloneable<PlayerLoginCsReq>, IBufferMessage
	{
		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x06009179 RID: 37241 RVA: 0x001812F6 File Offset: 0x0017F4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerLoginCsReq> Parser
		{
			get
			{
				return PlayerLoginCsReq._parser;
			}
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x0600917A RID: 37242 RVA: 0x001812FD File Offset: 0x0017F4FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerLoginCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x0600917B RID: 37243 RVA: 0x0018130F File Offset: 0x0017F50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLoginCsReq.Descriptor;
			}
		}

		// Token: 0x0600917C RID: 37244 RVA: 0x00181318 File Offset: 0x0017F518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginCsReq()
		{
		}

		// Token: 0x0600917D RID: 37245 RVA: 0x001813DC File Offset: 0x0017F5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginCsReq(PlayerLoginCsReq other) : this()
		{
			this.resVersion_ = other.resVersion_;
			this.cEKOLCPLBED_ = other.cEKOLCPLBED_;
			this.channelId_ = other.channelId_;
			this.hFHGPLMEFGJ_ = other.hFHGPLMEFGJ_;
			this.rogueGetInfo_ = other.rogueGetInfo_;
			this.nMDMJEFOPKB_ = other.nMDMJEFOPKB_;
			this.oPNLMMDFFLL_ = other.oPNLMMDFFLL_;
			this.aCMBPIIJKFL_ = other.aCMBPIIJKFL_;
			this.fKFJDGCNDII_ = other.fKFJDGCNDII_;
			this.platform_ = other.platform_;
			this.clientVersion_ = other.clientVersion_;
			this.signature_ = other.signature_;
			this.mJAJBCHKDFP_ = other.mJAJBCHKDFP_;
			this.oGKGOLNAICH_ = ((other.oGKGOLNAICH_ != null) ? other.oGKGOLNAICH_.Clone() : null);
			this.oPNBNKJAIKD_ = other.oPNBNKJAIKD_;
			this.jJDBFAMDEPP_ = other.jJDBFAMDEPP_;
			this.eIFPHAMMIEG_ = other.eIFPHAMMIEG_;
			this.hDPJMCHLGCM_ = other.hDPJMCHLGCM_;
			this.iIAHICGOMKP_ = other.iIAHICGOMKP_;
			this.kOGIIKIEJIJ_ = other.kOGIIKIEJIJ_;
			this.aIEONDBHNDC_ = other.aIEONDBHNDC_;
			this.gLNBFFILPNA_ = other.gLNBFFILPNA_;
			this.loginRandom_ = other.loginRandom_;
			this.language_ = other.language_;
			this.bMCBOCGEKBF_ = other.bMCBOCGEKBF_;
			this.fLFKCIHCENF_ = other.fLFKCIHCENF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600917E RID: 37246 RVA: 0x00181548 File Offset: 0x0017F748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginCsReq Clone()
		{
			return new PlayerLoginCsReq(this);
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x0600917F RID: 37247 RVA: 0x00181550 File Offset: 0x0017F750
		// (set) Token: 0x06009180 RID: 37248 RVA: 0x00181558 File Offset: 0x0017F758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ResVersion
		{
			get
			{
				return this.resVersion_;
			}
			set
			{
				this.resVersion_ = value;
			}
		}

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x06009181 RID: 37249 RVA: 0x00181561 File Offset: 0x0017F761
		// (set) Token: 0x06009182 RID: 37250 RVA: 0x00181569 File Offset: 0x0017F769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CEKOLCPLBED
		{
			get
			{
				return this.cEKOLCPLBED_;
			}
			set
			{
				this.cEKOLCPLBED_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x06009183 RID: 37251 RVA: 0x0018157C File Offset: 0x0017F77C
		// (set) Token: 0x06009184 RID: 37252 RVA: 0x00181584 File Offset: 0x0017F784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x06009185 RID: 37253 RVA: 0x0018158D File Offset: 0x0017F78D
		// (set) Token: 0x06009186 RID: 37254 RVA: 0x00181595 File Offset: 0x0017F795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string HFHGPLMEFGJ
		{
			get
			{
				return this.hFHGPLMEFGJ_;
			}
			set
			{
				this.hFHGPLMEFGJ_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x06009187 RID: 37255 RVA: 0x001815A8 File Offset: 0x0017F7A8
		// (set) Token: 0x06009188 RID: 37256 RVA: 0x001815B0 File Offset: 0x0017F7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RogueGetInfo
		{
			get
			{
				return this.rogueGetInfo_;
			}
			set
			{
				this.rogueGetInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x06009189 RID: 37257 RVA: 0x001815C3 File Offset: 0x0017F7C3
		// (set) Token: 0x0600918A RID: 37258 RVA: 0x001815CB File Offset: 0x0017F7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NMDMJEFOPKB
		{
			get
			{
				return this.nMDMJEFOPKB_;
			}
			set
			{
				this.nMDMJEFOPKB_ = value;
			}
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x0600918B RID: 37259 RVA: 0x001815D4 File Offset: 0x0017F7D4
		// (set) Token: 0x0600918C RID: 37260 RVA: 0x001815DC File Offset: 0x0017F7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OPNLMMDFFLL
		{
			get
			{
				return this.oPNLMMDFFLL_;
			}
			set
			{
				this.oPNLMMDFFLL_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x0600918D RID: 37261 RVA: 0x001815EF File Offset: 0x0017F7EF
		// (set) Token: 0x0600918E RID: 37262 RVA: 0x001815F7 File Offset: 0x0017F7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ACMBPIIJKFL
		{
			get
			{
				return this.aCMBPIIJKFL_;
			}
			set
			{
				this.aCMBPIIJKFL_ = value;
			}
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x0600918F RID: 37263 RVA: 0x00181600 File Offset: 0x0017F800
		// (set) Token: 0x06009190 RID: 37264 RVA: 0x00181608 File Offset: 0x0017F808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FKFJDGCNDII
		{
			get
			{
				return this.fKFJDGCNDII_;
			}
			set
			{
				this.fKFJDGCNDII_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x06009191 RID: 37265 RVA: 0x0018161B File Offset: 0x0017F81B
		// (set) Token: 0x06009192 RID: 37266 RVA: 0x00181623 File Offset: 0x0017F823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlatformType Platform
		{
			get
			{
				return this.platform_;
			}
			set
			{
				this.platform_ = value;
			}
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x06009193 RID: 37267 RVA: 0x0018162C File Offset: 0x0017F82C
		// (set) Token: 0x06009194 RID: 37268 RVA: 0x00181634 File Offset: 0x0017F834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ClientVersion
		{
			get
			{
				return this.clientVersion_;
			}
			set
			{
				this.clientVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x06009195 RID: 37269 RVA: 0x00181647 File Offset: 0x0017F847
		// (set) Token: 0x06009196 RID: 37270 RVA: 0x0018164F File Offset: 0x0017F84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x06009197 RID: 37271 RVA: 0x00181662 File Offset: 0x0017F862
		// (set) Token: 0x06009198 RID: 37272 RVA: 0x0018166A File Offset: 0x0017F86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MJAJBCHKDFP
		{
			get
			{
				return this.mJAJBCHKDFP_;
			}
			set
			{
				this.mJAJBCHKDFP_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x06009199 RID: 37273 RVA: 0x0018167D File Offset: 0x0017F87D
		// (set) Token: 0x0600919A RID: 37274 RVA: 0x00181685 File Offset: 0x0017F885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeviceInfo OGKGOLNAICH
		{
			get
			{
				return this.oGKGOLNAICH_;
			}
			set
			{
				this.oGKGOLNAICH_ = value;
			}
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600919B RID: 37275 RVA: 0x0018168E File Offset: 0x0017F88E
		// (set) Token: 0x0600919C RID: 37276 RVA: 0x00181696 File Offset: 0x0017F896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OPNBNKJAIKD
		{
			get
			{
				return this.oPNBNKJAIKD_;
			}
			set
			{
				this.oPNBNKJAIKD_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x0600919D RID: 37277 RVA: 0x001816A9 File Offset: 0x0017F8A9
		// (set) Token: 0x0600919E RID: 37278 RVA: 0x001816B1 File Offset: 0x0017F8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JJDBFAMDEPP
		{
			get
			{
				return this.jJDBFAMDEPP_;
			}
			set
			{
				this.jJDBFAMDEPP_ = value;
			}
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x0600919F RID: 37279 RVA: 0x001816BA File Offset: 0x0017F8BA
		// (set) Token: 0x060091A0 RID: 37280 RVA: 0x001816C2 File Offset: 0x0017F8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string EIFPHAMMIEG
		{
			get
			{
				return this.eIFPHAMMIEG_;
			}
			set
			{
				this.eIFPHAMMIEG_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x060091A1 RID: 37281 RVA: 0x001816D5 File Offset: 0x0017F8D5
		// (set) Token: 0x060091A2 RID: 37282 RVA: 0x001816DD File Offset: 0x0017F8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string HDPJMCHLGCM
		{
			get
			{
				return this.hDPJMCHLGCM_;
			}
			set
			{
				this.hDPJMCHLGCM_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x060091A3 RID: 37283 RVA: 0x001816F0 File Offset: 0x0017F8F0
		// (set) Token: 0x060091A4 RID: 37284 RVA: 0x001816F8 File Offset: 0x0017F8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IIAHICGOMKP
		{
			get
			{
				return this.iIAHICGOMKP_;
			}
			set
			{
				this.iIAHICGOMKP_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x060091A5 RID: 37285 RVA: 0x0018170B File Offset: 0x0017F90B
		// (set) Token: 0x060091A6 RID: 37286 RVA: 0x00181713 File Offset: 0x0017F913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string KOGIIKIEJIJ
		{
			get
			{
				return this.kOGIIKIEJIJ_;
			}
			set
			{
				this.kOGIIKIEJIJ_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x060091A7 RID: 37287 RVA: 0x00181726 File Offset: 0x0017F926
		// (set) Token: 0x060091A8 RID: 37288 RVA: 0x0018172E File Offset: 0x0017F92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AIEONDBHNDC
		{
			get
			{
				return this.aIEONDBHNDC_;
			}
			set
			{
				this.aIEONDBHNDC_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x060091A9 RID: 37289 RVA: 0x00181741 File Offset: 0x0017F941
		// (set) Token: 0x060091AA RID: 37290 RVA: 0x00181749 File Offset: 0x0017F949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GLNBFFILPNA
		{
			get
			{
				return this.gLNBFFILPNA_;
			}
			set
			{
				this.gLNBFFILPNA_ = value;
			}
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x060091AB RID: 37291 RVA: 0x00181752 File Offset: 0x0017F952
		// (set) Token: 0x060091AC RID: 37292 RVA: 0x0018175A File Offset: 0x0017F95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong LoginRandom
		{
			get
			{
				return this.loginRandom_;
			}
			set
			{
				this.loginRandom_ = value;
			}
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x060091AD RID: 37293 RVA: 0x00181763 File Offset: 0x0017F963
		// (set) Token: 0x060091AE RID: 37294 RVA: 0x0018176B File Offset: 0x0017F96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageType Language
		{
			get
			{
				return this.language_;
			}
			set
			{
				this.language_ = value;
			}
		}

		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x060091AF RID: 37295 RVA: 0x00181774 File Offset: 0x0017F974
		// (set) Token: 0x060091B0 RID: 37296 RVA: 0x0018177C File Offset: 0x0017F97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BMCBOCGEKBF
		{
			get
			{
				return this.bMCBOCGEKBF_;
			}
			set
			{
				this.bMCBOCGEKBF_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x060091B1 RID: 37297 RVA: 0x0018178F File Offset: 0x0017F98F
		// (set) Token: 0x060091B2 RID: 37298 RVA: 0x00181797 File Offset: 0x0017F997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FLFKCIHCENF
		{
			get
			{
				return this.fLFKCIHCENF_;
			}
			set
			{
				this.fLFKCIHCENF_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060091B3 RID: 37299 RVA: 0x001817AA File Offset: 0x0017F9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLoginCsReq);
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x001817B8 File Offset: 0x0017F9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLoginCsReq other)
		{
			return other != null && (other == this || (this.ResVersion == other.ResVersion && !(this.CEKOLCPLBED != other.CEKOLCPLBED) && this.ChannelId == other.ChannelId && !(this.HFHGPLMEFGJ != other.HFHGPLMEFGJ) && !(this.RogueGetInfo != other.RogueGetInfo) && this.NMDMJEFOPKB == other.NMDMJEFOPKB && !(this.OPNLMMDFFLL != other.OPNLMMDFFLL) && this.ACMBPIIJKFL == other.ACMBPIIJKFL && !(this.FKFJDGCNDII != other.FKFJDGCNDII) && this.Platform == other.Platform && !(this.ClientVersion != other.ClientVersion) && !(this.Signature != other.Signature) && !(this.MJAJBCHKDFP != other.MJAJBCHKDFP) && object.Equals(this.OGKGOLNAICH, other.OGKGOLNAICH) && !(this.OPNBNKJAIKD != other.OPNBNKJAIKD) && this.JJDBFAMDEPP == other.JJDBFAMDEPP && !(this.EIFPHAMMIEG != other.EIFPHAMMIEG) && !(this.HDPJMCHLGCM != other.HDPJMCHLGCM) && !(this.IIAHICGOMKP != other.IIAHICGOMKP) && !(this.KOGIIKIEJIJ != other.KOGIIKIEJIJ) && !(this.AIEONDBHNDC != other.AIEONDBHNDC) && this.GLNBFFILPNA == other.GLNBFFILPNA && this.LoginRandom == other.LoginRandom && this.Language == other.Language && !(this.BMCBOCGEKBF != other.BMCBOCGEKBF) && !(this.FLFKCIHCENF != other.FLFKCIHCENF) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x001819D8 File Offset: 0x0017FBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResVersion != 0U)
			{
				num ^= this.ResVersion.GetHashCode();
			}
			if (this.CEKOLCPLBED.Length != 0)
			{
				num ^= this.CEKOLCPLBED.GetHashCode();
			}
			if (this.ChannelId != 0U)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				num ^= this.HFHGPLMEFGJ.GetHashCode();
			}
			if (this.RogueGetInfo.Length != 0)
			{
				num ^= this.RogueGetInfo.GetHashCode();
			}
			if (this.NMDMJEFOPKB != 0U)
			{
				num ^= this.NMDMJEFOPKB.GetHashCode();
			}
			if (this.OPNLMMDFFLL.Length != 0)
			{
				num ^= this.OPNLMMDFFLL.GetHashCode();
			}
			if (this.ACMBPIIJKFL != 0U)
			{
				num ^= this.ACMBPIIJKFL.GetHashCode();
			}
			if (this.FKFJDGCNDII.Length != 0)
			{
				num ^= this.FKFJDGCNDII.GetHashCode();
			}
			if (this.Platform != PlatformType.Editor)
			{
				num ^= this.Platform.GetHashCode();
			}
			if (this.ClientVersion.Length != 0)
			{
				num ^= this.ClientVersion.GetHashCode();
			}
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this.MJAJBCHKDFP.Length != 0)
			{
				num ^= this.MJAJBCHKDFP.GetHashCode();
			}
			if (this.oGKGOLNAICH_ != null)
			{
				num ^= this.OGKGOLNAICH.GetHashCode();
			}
			if (this.OPNBNKJAIKD.Length != 0)
			{
				num ^= this.OPNBNKJAIKD.GetHashCode();
			}
			if (this.JJDBFAMDEPP)
			{
				num ^= this.JJDBFAMDEPP.GetHashCode();
			}
			if (this.EIFPHAMMIEG.Length != 0)
			{
				num ^= this.EIFPHAMMIEG.GetHashCode();
			}
			if (this.HDPJMCHLGCM.Length != 0)
			{
				num ^= this.HDPJMCHLGCM.GetHashCode();
			}
			if (this.IIAHICGOMKP.Length != 0)
			{
				num ^= this.IIAHICGOMKP.GetHashCode();
			}
			if (this.KOGIIKIEJIJ.Length != 0)
			{
				num ^= this.KOGIIKIEJIJ.GetHashCode();
			}
			if (this.AIEONDBHNDC.Length != 0)
			{
				num ^= this.AIEONDBHNDC.GetHashCode();
			}
			if (this.GLNBFFILPNA)
			{
				num ^= this.GLNBFFILPNA.GetHashCode();
			}
			if (this.LoginRandom != 0UL)
			{
				num ^= this.LoginRandom.GetHashCode();
			}
			if (this.Language != LanguageType.LanguageNone)
			{
				num ^= this.Language.GetHashCode();
			}
			if (this.BMCBOCGEKBF.Length != 0)
			{
				num ^= this.BMCBOCGEKBF.GetHashCode();
			}
			if (this.FLFKCIHCENF.Length != 0)
			{
				num ^= this.FLFKCIHCENF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060091B6 RID: 37302 RVA: 0x00181CB3 File Offset: 0x0017FEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060091B7 RID: 37303 RVA: 0x00181CBB File Offset: 0x0017FEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091B8 RID: 37304 RVA: 0x00181CC4 File Offset: 0x0017FEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IIAHICGOMKP.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.IIAHICGOMKP);
			}
			if (this.AIEONDBHNDC.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.AIEONDBHNDC);
			}
			if (this.ClientVersion.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ClientVersion);
			}
			if (this.OPNLMMDFFLL.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.OPNLMMDFFLL);
			}
			if (this.RogueGetInfo.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.RogueGetInfo);
			}
			if (this.CEKOLCPLBED.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.CEKOLCPLBED);
			}
			if (this.LoginRandom != 0UL)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.LoginRandom);
			}
			if (this.ResVersion != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ResVersion);
			}
			if (this.OPNBNKJAIKD.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.OPNBNKJAIKD);
			}
			if (this.EIFPHAMMIEG.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.EIFPHAMMIEG);
			}
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Signature);
			}
			if (this.NMDMJEFOPKB != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.NMDMJEFOPKB);
			}
			if (this.Platform != PlatformType.Editor)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Platform);
			}
			if (this.HDPJMCHLGCM.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.HDPJMCHLGCM);
			}
			if (this.Language != LanguageType.LanguageNone)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Language);
			}
			if (this.BMCBOCGEKBF.Length != 0)
			{
				output.WriteRawTag(178, 21);
				output.WriteString(this.BMCBOCGEKBF);
			}
			if (this.FKFJDGCNDII.Length != 0)
			{
				output.WriteRawTag(242, 21);
				output.WriteString(this.FKFJDGCNDII);
			}
			if (this.GLNBFFILPNA)
			{
				output.WriteRawTag(192, 26);
				output.WriteBool(this.GLNBFFILPNA);
			}
			if (this.ChannelId != 0U)
			{
				output.WriteRawTag(240, 36);
				output.WriteUInt32(this.ChannelId);
			}
			if (this.MJAJBCHKDFP.Length != 0)
			{
				output.WriteRawTag(186, 65);
				output.WriteString(this.MJAJBCHKDFP);
			}
			if (this.FLFKCIHCENF.Length != 0)
			{
				output.WriteRawTag(138, 69);
				output.WriteString(this.FLFKCIHCENF);
			}
			if (this.KOGIIKIEJIJ.Length != 0)
			{
				output.WriteRawTag(186, 78);
				output.WriteString(this.KOGIIKIEJIJ);
			}
			if (this.oGKGOLNAICH_ != null)
			{
				output.WriteRawTag(170, 80);
				output.WriteMessage(this.OGKGOLNAICH);
			}
			if (this.ACMBPIIJKFL != 0U)
			{
				output.WriteRawTag(232, 87);
				output.WriteUInt32(this.ACMBPIIJKFL);
			}
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				output.WriteRawTag(130, 89);
				output.WriteString(this.HFHGPLMEFGJ);
			}
			if (this.JJDBFAMDEPP)
			{
				output.WriteRawTag(216, 91);
				output.WriteBool(this.JJDBFAMDEPP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091B9 RID: 37305 RVA: 0x00182044 File Offset: 0x00180244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ResVersion);
			}
			if (this.CEKOLCPLBED.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CEKOLCPLBED);
			}
			if (this.ChannelId != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ChannelId);
			}
			if (this.HFHGPLMEFGJ.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.HFHGPLMEFGJ);
			}
			if (this.RogueGetInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RogueGetInfo);
			}
			if (this.NMDMJEFOPKB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NMDMJEFOPKB);
			}
			if (this.OPNLMMDFFLL.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OPNLMMDFFLL);
			}
			if (this.ACMBPIIJKFL != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ACMBPIIJKFL);
			}
			if (this.FKFJDGCNDII.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.FKFJDGCNDII);
			}
			if (this.Platform != PlatformType.Editor)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Platform);
			}
			if (this.ClientVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientVersion);
			}
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this.MJAJBCHKDFP.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.MJAJBCHKDFP);
			}
			if (this.oGKGOLNAICH_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OGKGOLNAICH);
			}
			if (this.OPNBNKJAIKD.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OPNBNKJAIKD);
			}
			if (this.JJDBFAMDEPP)
			{
				num += 3;
			}
			if (this.EIFPHAMMIEG.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EIFPHAMMIEG);
			}
			if (this.HDPJMCHLGCM.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HDPJMCHLGCM);
			}
			if (this.IIAHICGOMKP.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.IIAHICGOMKP);
			}
			if (this.KOGIIKIEJIJ.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.KOGIIKIEJIJ);
			}
			if (this.AIEONDBHNDC.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AIEONDBHNDC);
			}
			if (this.GLNBFFILPNA)
			{
				num += 3;
			}
			if (this.LoginRandom != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LoginRandom);
			}
			if (this.Language != LanguageType.LanguageNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Language);
			}
			if (this.BMCBOCGEKBF.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.BMCBOCGEKBF);
			}
			if (this.FLFKCIHCENF.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.FLFKCIHCENF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060091BA RID: 37306 RVA: 0x00182314 File Offset: 0x00180514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerLoginCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResVersion != 0U)
			{
				this.ResVersion = other.ResVersion;
			}
			if (other.CEKOLCPLBED.Length != 0)
			{
				this.CEKOLCPLBED = other.CEKOLCPLBED;
			}
			if (other.ChannelId != 0U)
			{
				this.ChannelId = other.ChannelId;
			}
			if (other.HFHGPLMEFGJ.Length != 0)
			{
				this.HFHGPLMEFGJ = other.HFHGPLMEFGJ;
			}
			if (other.RogueGetInfo.Length != 0)
			{
				this.RogueGetInfo = other.RogueGetInfo;
			}
			if (other.NMDMJEFOPKB != 0U)
			{
				this.NMDMJEFOPKB = other.NMDMJEFOPKB;
			}
			if (other.OPNLMMDFFLL.Length != 0)
			{
				this.OPNLMMDFFLL = other.OPNLMMDFFLL;
			}
			if (other.ACMBPIIJKFL != 0U)
			{
				this.ACMBPIIJKFL = other.ACMBPIIJKFL;
			}
			if (other.FKFJDGCNDII.Length != 0)
			{
				this.FKFJDGCNDII = other.FKFJDGCNDII;
			}
			if (other.Platform != PlatformType.Editor)
			{
				this.Platform = other.Platform;
			}
			if (other.ClientVersion.Length != 0)
			{
				this.ClientVersion = other.ClientVersion;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			if (other.MJAJBCHKDFP.Length != 0)
			{
				this.MJAJBCHKDFP = other.MJAJBCHKDFP;
			}
			if (other.oGKGOLNAICH_ != null)
			{
				if (this.oGKGOLNAICH_ == null)
				{
					this.OGKGOLNAICH = new ExtraDeviceInfo();
				}
				this.OGKGOLNAICH.MergeFrom(other.OGKGOLNAICH);
			}
			if (other.OPNBNKJAIKD.Length != 0)
			{
				this.OPNBNKJAIKD = other.OPNBNKJAIKD;
			}
			if (other.JJDBFAMDEPP)
			{
				this.JJDBFAMDEPP = other.JJDBFAMDEPP;
			}
			if (other.EIFPHAMMIEG.Length != 0)
			{
				this.EIFPHAMMIEG = other.EIFPHAMMIEG;
			}
			if (other.HDPJMCHLGCM.Length != 0)
			{
				this.HDPJMCHLGCM = other.HDPJMCHLGCM;
			}
			if (other.IIAHICGOMKP.Length != 0)
			{
				this.IIAHICGOMKP = other.IIAHICGOMKP;
			}
			if (other.KOGIIKIEJIJ.Length != 0)
			{
				this.KOGIIKIEJIJ = other.KOGIIKIEJIJ;
			}
			if (other.AIEONDBHNDC.Length != 0)
			{
				this.AIEONDBHNDC = other.AIEONDBHNDC;
			}
			if (other.GLNBFFILPNA)
			{
				this.GLNBFFILPNA = other.GLNBFFILPNA;
			}
			if (other.LoginRandom != 0UL)
			{
				this.LoginRandom = other.LoginRandom;
			}
			if (other.Language != LanguageType.LanguageNone)
			{
				this.Language = other.Language;
			}
			if (other.BMCBOCGEKBF.Length != 0)
			{
				this.BMCBOCGEKBF = other.BMCBOCGEKBF;
			}
			if (other.FLFKCIHCENF.Length != 0)
			{
				this.FLFKCIHCENF = other.FLFKCIHCENF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060091BB RID: 37307 RVA: 0x001825AC File Offset: 0x001807AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x001825B8 File Offset: 0x001807B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 104U)
				{
					if (num <= 50U)
					{
						if (num <= 26U)
						{
							if (num == 10U)
							{
								this.IIAHICGOMKP = input.ReadString();
								continue;
							}
							if (num == 18U)
							{
								this.AIEONDBHNDC = input.ReadString();
								continue;
							}
							if (num == 26U)
							{
								this.ClientVersion = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 34U)
							{
								this.OPNLMMDFFLL = input.ReadString();
								continue;
							}
							if (num == 42U)
							{
								this.RogueGetInfo = input.ReadString();
								continue;
							}
							if (num == 50U)
							{
								this.CEKOLCPLBED = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 74U)
					{
						if (num == 56U)
						{
							this.LoginRandom = input.ReadUInt64();
							continue;
						}
						if (num == 64U)
						{
							this.ResVersion = input.ReadUInt32();
							continue;
						}
						if (num == 74U)
						{
							this.OPNBNKJAIKD = input.ReadString();
							continue;
						}
					}
					else if (num <= 90U)
					{
						if (num == 82U)
						{
							this.EIFPHAMMIEG = input.ReadString();
							continue;
						}
						if (num == 90U)
						{
							this.Signature = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 96U)
						{
							this.NMDMJEFOPKB = input.ReadUInt32();
							continue;
						}
						if (num == 104U)
						{
							this.Platform = (PlatformType)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 4720U)
				{
					if (num <= 2738U)
					{
						if (num == 114U)
						{
							this.HDPJMCHLGCM = input.ReadString();
							continue;
						}
						if (num == 120U)
						{
							this.Language = (LanguageType)input.ReadEnum();
							continue;
						}
						if (num == 2738U)
						{
							this.BMCBOCGEKBF = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 2802U)
						{
							this.FKFJDGCNDII = input.ReadString();
							continue;
						}
						if (num == 3392U)
						{
							this.GLNBFFILPNA = input.ReadBool();
							continue;
						}
						if (num == 4720U)
						{
							this.ChannelId = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 10042U)
				{
					if (num == 8378U)
					{
						this.MJAJBCHKDFP = input.ReadString();
						continue;
					}
					if (num == 8842U)
					{
						this.FLFKCIHCENF = input.ReadString();
						continue;
					}
					if (num == 10042U)
					{
						this.KOGIIKIEJIJ = input.ReadString();
						continue;
					}
				}
				else if (num <= 11240U)
				{
					if (num == 10282U)
					{
						if (this.oGKGOLNAICH_ == null)
						{
							this.OGKGOLNAICH = new ExtraDeviceInfo();
						}
						input.ReadMessage(this.OGKGOLNAICH);
						continue;
					}
					if (num == 11240U)
					{
						this.ACMBPIIJKFL = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 11394U)
					{
						this.HFHGPLMEFGJ = input.ReadString();
						continue;
					}
					if (num == 11736U)
					{
						this.JJDBFAMDEPP = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003809 RID: 14345
		private static readonly MessageParser<PlayerLoginCsReq> _parser = new MessageParser<PlayerLoginCsReq>(() => new PlayerLoginCsReq());

		// Token: 0x0400380A RID: 14346
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400380B RID: 14347
		public const int ResVersionFieldNumber = 8;

		// Token: 0x0400380C RID: 14348
		private uint resVersion_;

		// Token: 0x0400380D RID: 14349
		public const int CEKOLCPLBEDFieldNumber = 6;

		// Token: 0x0400380E RID: 14350
		private string cEKOLCPLBED_ = "";

		// Token: 0x0400380F RID: 14351
		public const int ChannelIdFieldNumber = 590;

		// Token: 0x04003810 RID: 14352
		private uint channelId_;

		// Token: 0x04003811 RID: 14353
		public const int HFHGPLMEFGJFieldNumber = 1424;

		// Token: 0x04003812 RID: 14354
		private string hFHGPLMEFGJ_ = "";

		// Token: 0x04003813 RID: 14355
		public const int RogueGetInfoFieldNumber = 5;

		// Token: 0x04003814 RID: 14356
		private string rogueGetInfo_ = "";

		// Token: 0x04003815 RID: 14357
		public const int NMDMJEFOPKBFieldNumber = 12;

		// Token: 0x04003816 RID: 14358
		private uint nMDMJEFOPKB_;

		// Token: 0x04003817 RID: 14359
		public const int OPNLMMDFFLLFieldNumber = 4;

		// Token: 0x04003818 RID: 14360
		private string oPNLMMDFFLL_ = "";

		// Token: 0x04003819 RID: 14361
		public const int ACMBPIIJKFLFieldNumber = 1405;

		// Token: 0x0400381A RID: 14362
		private uint aCMBPIIJKFL_;

		// Token: 0x0400381B RID: 14363
		public const int FKFJDGCNDIIFieldNumber = 350;

		// Token: 0x0400381C RID: 14364
		private string fKFJDGCNDII_ = "";

		// Token: 0x0400381D RID: 14365
		public const int PlatformFieldNumber = 13;

		// Token: 0x0400381E RID: 14366
		private PlatformType platform_;

		// Token: 0x0400381F RID: 14367
		public const int ClientVersionFieldNumber = 3;

		// Token: 0x04003820 RID: 14368
		private string clientVersion_ = "";

		// Token: 0x04003821 RID: 14369
		public const int SignatureFieldNumber = 11;

		// Token: 0x04003822 RID: 14370
		private string signature_ = "";

		// Token: 0x04003823 RID: 14371
		public const int MJAJBCHKDFPFieldNumber = 1047;

		// Token: 0x04003824 RID: 14372
		private string mJAJBCHKDFP_ = "";

		// Token: 0x04003825 RID: 14373
		public const int OGKGOLNAICHFieldNumber = 1285;

		// Token: 0x04003826 RID: 14374
		private ExtraDeviceInfo oGKGOLNAICH_;

		// Token: 0x04003827 RID: 14375
		public const int OPNBNKJAIKDFieldNumber = 9;

		// Token: 0x04003828 RID: 14376
		private string oPNBNKJAIKD_ = "";

		// Token: 0x04003829 RID: 14377
		public const int JJDBFAMDEPPFieldNumber = 1467;

		// Token: 0x0400382A RID: 14378
		private bool jJDBFAMDEPP_;

		// Token: 0x0400382B RID: 14379
		public const int EIFPHAMMIEGFieldNumber = 10;

		// Token: 0x0400382C RID: 14380
		private string eIFPHAMMIEG_ = "";

		// Token: 0x0400382D RID: 14381
		public const int HDPJMCHLGCMFieldNumber = 14;

		// Token: 0x0400382E RID: 14382
		private string hDPJMCHLGCM_ = "";

		// Token: 0x0400382F RID: 14383
		public const int IIAHICGOMKPFieldNumber = 1;

		// Token: 0x04003830 RID: 14384
		private string iIAHICGOMKP_ = "";

		// Token: 0x04003831 RID: 14385
		public const int KOGIIKIEJIJFieldNumber = 1255;

		// Token: 0x04003832 RID: 14386
		private string kOGIIKIEJIJ_ = "";

		// Token: 0x04003833 RID: 14387
		public const int AIEONDBHNDCFieldNumber = 2;

		// Token: 0x04003834 RID: 14388
		private string aIEONDBHNDC_ = "";

		// Token: 0x04003835 RID: 14389
		public const int GLNBFFILPNAFieldNumber = 424;

		// Token: 0x04003836 RID: 14390
		private bool gLNBFFILPNA_;

		// Token: 0x04003837 RID: 14391
		public const int LoginRandomFieldNumber = 7;

		// Token: 0x04003838 RID: 14392
		private ulong loginRandom_;

		// Token: 0x04003839 RID: 14393
		public const int LanguageFieldNumber = 15;

		// Token: 0x0400383A RID: 14394
		private LanguageType language_;

		// Token: 0x0400383B RID: 14395
		public const int BMCBOCGEKBFFieldNumber = 342;

		// Token: 0x0400383C RID: 14396
		private string bMCBOCGEKBF_ = "";

		// Token: 0x0400383D RID: 14397
		public const int FLFKCIHCENFFieldNumber = 1105;

		// Token: 0x0400383E RID: 14398
		private string fLFKCIHCENF_ = "";
	}
}
