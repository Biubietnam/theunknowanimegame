using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005E7 RID: 1511
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GateServer : IMessage<GateServer>, IMessage, IEquatable<GateServer>, IDeepCloneable<GateServer>, IBufferMessage
	{
		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x000B7A97 File Offset: 0x000B5C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GateServer> Parser
		{
			get
			{
				return GateServer._parser;
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x000B7A9E File Offset: 0x000B5C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GateServerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x000B7AB0 File Offset: 0x000B5CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GateServer.Descriptor;
			}
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x000B7AB8 File Offset: 0x000B5CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GateServer()
		{
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x000B7C70 File Offset: 0x000B5E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GateServer(GateServer other) : this()
		{
			this.lKDFCHNEFBB_ = other.lKDFCHNEFBB_;
			this.lHGKDGDJIHC_ = other.lHGKDGDJIHC_;
			this.enableVersionUpdate_ = other.enableVersionUpdate_;
			this.enableCdnIpv6_ = other.enableCdnIpv6_;
			this.enableWatermark_ = other.enableWatermark_;
			this.msg_ = other.msg_;
			this.ifixUrl_ = other.ifixUrl_;
			this.mtpSwitch_ = other.mtpSwitch_;
			this.iALOEKGOJOC_ = other.iALOEKGOJOC_;
			this.bJOCANIBBKI_ = other.bJOCANIBBKI_;
			this.enableAndroidMiddlePackage_ = other.enableAndroidMiddlePackage_;
			this.ifixVersion_ = other.ifixVersion_;
			this.iIJLFILFMDF_ = other.iIJLFILFMDF_;
			this.fIOHEKDJNCG_ = other.fIOHEKDJNCG_;
			this.loginWhiteMsg_ = other.loginWhiteMsg_;
			this.aPJECJMGAKC_ = other.aPJECJMGAKC_;
			this.designDataReloginDesc_ = other.designDataReloginDesc_;
			this.mdkResVersion_ = other.mdkResVersion_;
			this.clientSecretKey_ = other.clientSecretKey_;
			this.ipv6Address_ = other.ipv6Address_;
			this.pMABNNEDCCG_ = other.pMABNNEDCCG_;
			this.kLIAGHGOFML_ = other.kLIAGHGOFML_;
			this.eventTrackingOpen_ = other.eventTrackingOpen_;
			this.oDOCFCJMBCL_ = other.oDOCFCJMBCL_;
			this.nPIGPBEKEKO_ = other.nPIGPBEKEKO_;
			this.ip_ = other.ip_;
			this.regionName_ = other.regionName_;
			this.kDBAGALHEDC_ = other.kDBAGALHEDC_;
			this.closeRedeemCode_ = other.closeRedeemCode_;
			this.regionStopStart_ = other.regionStopStart_;
			this.useTcp_ = other.useTcp_;
			this.fDGFFCMALPI_ = other.fDGFFCMALPI_;
			this.exResourceUrl_ = other.exResourceUrl_;
			this.fHALNCIHMGA_ = other.fHALNCIHMGA_;
			this.playerReturnQuestionnaireAUrl_ = other.playerReturnQuestionnaireAUrl_;
			this.retcode_ = other.retcode_;
			this.iPKLAMMKNNG_ = other.iPKLAMMKNNG_;
			this.playerReturnInviteH5Url_ = other.playerReturnInviteH5Url_;
			this.asbReloginType_ = other.asbReloginType_;
			this.cNAKLGMDLPE_ = other.cNAKLGMDLPE_;
			this.luaUrl_ = other.luaUrl_;
			this.preDownloadUrl_ = other.preDownloadUrl_;
			this.forbidRecharge_ = other.forbidRecharge_;
			this.enableUploadBattleLog_ = other.enableUploadBattleLog_;
			this.onlineReplayDownloadUrl_ = other.onlineReplayDownloadUrl_;
			this.networkDiagnostic_ = other.networkDiagnostic_;
			this.assetBundleUrl_ = other.assetBundleUrl_;
			this.bBFOAJGLLBC_ = other.bBFOAJGLLBC_;
			this.onlineReplayUploadUrl_ = other.onlineReplayUploadUrl_;
			this.gBONLDEMBEN_ = other.gBONLDEMBEN_.Clone();
			this.playerReturnQuestionnaireBUrl_ = other.playerReturnQuestionnaireBUrl_;
			this.asbReloginDesc_ = other.asbReloginDesc_;
			this.iosExam_ = other.iosExam_;
			this.kKHFKMIKFIB_ = other.kKHFKMIKFIB_;
			this.mDKDJLNHGKN_ = other.mDKDJLNHGKN_;
			this.eLJIMGJLHBC_ = other.eLJIMGJLHBC_;
			this.regionStopEnd_ = other.regionStopEnd_;
			this.serverDescription_ = other.serverDescription_;
			this.designDataReloginType_ = other.designDataReloginType_;
			this.port_ = other.port_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x000B7F69 File Offset: 0x000B6169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GateServer Clone()
		{
			return new GateServer(this);
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x000B7F71 File Offset: 0x000B6171
		// (set) Token: 0x0600436F RID: 17263 RVA: 0x000B7F79 File Offset: 0x000B6179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LKDFCHNEFBB
		{
			get
			{
				return this.lKDFCHNEFBB_;
			}
			set
			{
				this.lKDFCHNEFBB_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x000B7F8C File Offset: 0x000B618C
		// (set) Token: 0x06004371 RID: 17265 RVA: 0x000B7F94 File Offset: 0x000B6194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LHGKDGDJIHC
		{
			get
			{
				return this.lHGKDGDJIHC_;
			}
			set
			{
				this.lHGKDGDJIHC_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x000B7FA7 File Offset: 0x000B61A7
		// (set) Token: 0x06004373 RID: 17267 RVA: 0x000B7FAF File Offset: 0x000B61AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableVersionUpdate
		{
			get
			{
				return this.enableVersionUpdate_;
			}
			set
			{
				this.enableVersionUpdate_ = value;
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06004374 RID: 17268 RVA: 0x000B7FB8 File Offset: 0x000B61B8
		// (set) Token: 0x06004375 RID: 17269 RVA: 0x000B7FC0 File Offset: 0x000B61C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EnableCdnIpv6
		{
			get
			{
				return this.enableCdnIpv6_;
			}
			set
			{
				this.enableCdnIpv6_ = value;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06004376 RID: 17270 RVA: 0x000B7FC9 File Offset: 0x000B61C9
		// (set) Token: 0x06004377 RID: 17271 RVA: 0x000B7FD1 File Offset: 0x000B61D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableWatermark
		{
			get
			{
				return this.enableWatermark_;
			}
			set
			{
				this.enableWatermark_ = value;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06004378 RID: 17272 RVA: 0x000B7FDA File Offset: 0x000B61DA
		// (set) Token: 0x06004379 RID: 17273 RVA: 0x000B7FE2 File Offset: 0x000B61E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Msg
		{
			get
			{
				return this.msg_;
			}
			set
			{
				this.msg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x000B7FF5 File Offset: 0x000B61F5
		// (set) Token: 0x0600437B RID: 17275 RVA: 0x000B7FFD File Offset: 0x000B61FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IfixUrl
		{
			get
			{
				return this.ifixUrl_;
			}
			set
			{
				this.ifixUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x000B8010 File Offset: 0x000B6210
		// (set) Token: 0x0600437D RID: 17277 RVA: 0x000B8018 File Offset: 0x000B6218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MtpSwitch
		{
			get
			{
				return this.mtpSwitch_;
			}
			set
			{
				this.mtpSwitch_ = value;
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x000B8021 File Offset: 0x000B6221
		// (set) Token: 0x0600437F RID: 17279 RVA: 0x000B8029 File Offset: 0x000B6229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IALOEKGOJOC
		{
			get
			{
				return this.iALOEKGOJOC_;
			}
			set
			{
				this.iALOEKGOJOC_ = value;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x000B8032 File Offset: 0x000B6232
		// (set) Token: 0x06004381 RID: 17281 RVA: 0x000B803A File Offset: 0x000B623A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BJOCANIBBKI
		{
			get
			{
				return this.bJOCANIBBKI_;
			}
			set
			{
				this.bJOCANIBBKI_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x000B804D File Offset: 0x000B624D
		// (set) Token: 0x06004383 RID: 17283 RVA: 0x000B8055 File Offset: 0x000B6255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableAndroidMiddlePackage
		{
			get
			{
				return this.enableAndroidMiddlePackage_;
			}
			set
			{
				this.enableAndroidMiddlePackage_ = value;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x000B805E File Offset: 0x000B625E
		// (set) Token: 0x06004385 RID: 17285 RVA: 0x000B8066 File Offset: 0x000B6266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IfixVersion
		{
			get
			{
				return this.ifixVersion_;
			}
			set
			{
				this.ifixVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x000B8079 File Offset: 0x000B6279
		// (set) Token: 0x06004387 RID: 17287 RVA: 0x000B8081 File Offset: 0x000B6281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IIJLFILFMDF
		{
			get
			{
				return this.iIJLFILFMDF_;
			}
			set
			{
				this.iIJLFILFMDF_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06004388 RID: 17288 RVA: 0x000B8094 File Offset: 0x000B6294
		// (set) Token: 0x06004389 RID: 17289 RVA: 0x000B809C File Offset: 0x000B629C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FIOHEKDJNCG
		{
			get
			{
				return this.fIOHEKDJNCG_;
			}
			set
			{
				this.fIOHEKDJNCG_ = value;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x000B80A5 File Offset: 0x000B62A5
		// (set) Token: 0x0600438B RID: 17291 RVA: 0x000B80AD File Offset: 0x000B62AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LoginWhiteMsg
		{
			get
			{
				return this.loginWhiteMsg_;
			}
			set
			{
				this.loginWhiteMsg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x0600438C RID: 17292 RVA: 0x000B80C0 File Offset: 0x000B62C0
		// (set) Token: 0x0600438D RID: 17293 RVA: 0x000B80C8 File Offset: 0x000B62C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool APJECJMGAKC
		{
			get
			{
				return this.aPJECJMGAKC_;
			}
			set
			{
				this.aPJECJMGAKC_ = value;
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x000B80D1 File Offset: 0x000B62D1
		// (set) Token: 0x0600438F RID: 17295 RVA: 0x000B80D9 File Offset: 0x000B62D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DesignDataReloginDesc
		{
			get
			{
				return this.designDataReloginDesc_;
			}
			set
			{
				this.designDataReloginDesc_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x000B80EC File Offset: 0x000B62EC
		// (set) Token: 0x06004391 RID: 17297 RVA: 0x000B80F4 File Offset: 0x000B62F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MdkResVersion
		{
			get
			{
				return this.mdkResVersion_;
			}
			set
			{
				this.mdkResVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x000B8107 File Offset: 0x000B6307
		// (set) Token: 0x06004393 RID: 17299 RVA: 0x000B810F File Offset: 0x000B630F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ClientSecretKey
		{
			get
			{
				return this.clientSecretKey_;
			}
			set
			{
				this.clientSecretKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x000B8122 File Offset: 0x000B6322
		// (set) Token: 0x06004395 RID: 17301 RVA: 0x000B812A File Offset: 0x000B632A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Ipv6Address
		{
			get
			{
				return this.ipv6Address_;
			}
			set
			{
				this.ipv6Address_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06004396 RID: 17302 RVA: 0x000B813D File Offset: 0x000B633D
		// (set) Token: 0x06004397 RID: 17303 RVA: 0x000B8145 File Offset: 0x000B6345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PMABNNEDCCG
		{
			get
			{
				return this.pMABNNEDCCG_;
			}
			set
			{
				this.pMABNNEDCCG_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06004398 RID: 17304 RVA: 0x000B8158 File Offset: 0x000B6358
		// (set) Token: 0x06004399 RID: 17305 RVA: 0x000B8160 File Offset: 0x000B6360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string KLIAGHGOFML
		{
			get
			{
				return this.kLIAGHGOFML_;
			}
			set
			{
				this.kLIAGHGOFML_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x0600439A RID: 17306 RVA: 0x000B8173 File Offset: 0x000B6373
		// (set) Token: 0x0600439B RID: 17307 RVA: 0x000B817B File Offset: 0x000B637B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EventTrackingOpen
		{
			get
			{
				return this.eventTrackingOpen_;
			}
			set
			{
				this.eventTrackingOpen_ = value;
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x0600439C RID: 17308 RVA: 0x000B8184 File Offset: 0x000B6384
		// (set) Token: 0x0600439D RID: 17309 RVA: 0x000B818C File Offset: 0x000B638C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ODOCFCJMBCL
		{
			get
			{
				return this.oDOCFCJMBCL_;
			}
			set
			{
				this.oDOCFCJMBCL_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x000B819F File Offset: 0x000B639F
		// (set) Token: 0x0600439F RID: 17311 RVA: 0x000B81A7 File Offset: 0x000B63A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string NPIGPBEKEKO
		{
			get
			{
				return this.nPIGPBEKEKO_;
			}
			set
			{
				this.nPIGPBEKEKO_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x060043A0 RID: 17312 RVA: 0x000B81BA File Offset: 0x000B63BA
		// (set) Token: 0x060043A1 RID: 17313 RVA: 0x000B81C2 File Offset: 0x000B63C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Ip
		{
			get
			{
				return this.ip_;
			}
			set
			{
				this.ip_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x060043A2 RID: 17314 RVA: 0x000B81D5 File Offset: 0x000B63D5
		// (set) Token: 0x060043A3 RID: 17315 RVA: 0x000B81DD File Offset: 0x000B63DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RegionName
		{
			get
			{
				return this.regionName_;
			}
			set
			{
				this.regionName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x000B81F0 File Offset: 0x000B63F0
		// (set) Token: 0x060043A5 RID: 17317 RVA: 0x000B81F8 File Offset: 0x000B63F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string KDBAGALHEDC
		{
			get
			{
				return this.kDBAGALHEDC_;
			}
			set
			{
				this.kDBAGALHEDC_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x060043A6 RID: 17318 RVA: 0x000B820B File Offset: 0x000B640B
		// (set) Token: 0x060043A7 RID: 17319 RVA: 0x000B8213 File Offset: 0x000B6413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CloseRedeemCode
		{
			get
			{
				return this.closeRedeemCode_;
			}
			set
			{
				this.closeRedeemCode_ = value;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x060043A8 RID: 17320 RVA: 0x000B821C File Offset: 0x000B641C
		// (set) Token: 0x060043A9 RID: 17321 RVA: 0x000B8224 File Offset: 0x000B6424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RegionStopStart
		{
			get
			{
				return this.regionStopStart_;
			}
			set
			{
				this.regionStopStart_ = value;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x060043AA RID: 17322 RVA: 0x000B822D File Offset: 0x000B642D
		// (set) Token: 0x060043AB RID: 17323 RVA: 0x000B8235 File Offset: 0x000B6435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UseTcp
		{
			get
			{
				return this.useTcp_;
			}
			set
			{
				this.useTcp_ = value;
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x060043AC RID: 17324 RVA: 0x000B823E File Offset: 0x000B643E
		// (set) Token: 0x060043AD RID: 17325 RVA: 0x000B8246 File Offset: 0x000B6446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FDGFFCMALPI
		{
			get
			{
				return this.fDGFFCMALPI_;
			}
			set
			{
				this.fDGFFCMALPI_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x060043AE RID: 17326 RVA: 0x000B8259 File Offset: 0x000B6459
		// (set) Token: 0x060043AF RID: 17327 RVA: 0x000B8261 File Offset: 0x000B6461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ExResourceUrl
		{
			get
			{
				return this.exResourceUrl_;
			}
			set
			{
				this.exResourceUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x060043B0 RID: 17328 RVA: 0x000B8274 File Offset: 0x000B6474
		// (set) Token: 0x060043B1 RID: 17329 RVA: 0x000B827C File Offset: 0x000B647C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FHALNCIHMGA
		{
			get
			{
				return this.fHALNCIHMGA_;
			}
			set
			{
				this.fHALNCIHMGA_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x060043B2 RID: 17330 RVA: 0x000B828F File Offset: 0x000B648F
		// (set) Token: 0x060043B3 RID: 17331 RVA: 0x000B8297 File Offset: 0x000B6497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerReturnQuestionnaireAUrl
		{
			get
			{
				return this.playerReturnQuestionnaireAUrl_;
			}
			set
			{
				this.playerReturnQuestionnaireAUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x060043B4 RID: 17332 RVA: 0x000B82AA File Offset: 0x000B64AA
		// (set) Token: 0x060043B5 RID: 17333 RVA: 0x000B82B2 File Offset: 0x000B64B2
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

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x060043B6 RID: 17334 RVA: 0x000B82BB File Offset: 0x000B64BB
		// (set) Token: 0x060043B7 RID: 17335 RVA: 0x000B82C3 File Offset: 0x000B64C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IPKLAMMKNNG
		{
			get
			{
				return this.iPKLAMMKNNG_;
			}
			set
			{
				this.iPKLAMMKNNG_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x060043B8 RID: 17336 RVA: 0x000B82D6 File Offset: 0x000B64D6
		// (set) Token: 0x060043B9 RID: 17337 RVA: 0x000B82DE File Offset: 0x000B64DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerReturnInviteH5Url
		{
			get
			{
				return this.playerReturnInviteH5Url_;
			}
			set
			{
				this.playerReturnInviteH5Url_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x060043BA RID: 17338 RVA: 0x000B82F1 File Offset: 0x000B64F1
		// (set) Token: 0x060043BB RID: 17339 RVA: 0x000B82F9 File Offset: 0x000B64F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AsbReloginType
		{
			get
			{
				return this.asbReloginType_;
			}
			set
			{
				this.asbReloginType_ = value;
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x060043BC RID: 17340 RVA: 0x000B8302 File Offset: 0x000B6502
		// (set) Token: 0x060043BD RID: 17341 RVA: 0x000B830A File Offset: 0x000B650A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CNAKLGMDLPE
		{
			get
			{
				return this.cNAKLGMDLPE_;
			}
			set
			{
				this.cNAKLGMDLPE_ = value;
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x060043BE RID: 17342 RVA: 0x000B8313 File Offset: 0x000B6513
		// (set) Token: 0x060043BF RID: 17343 RVA: 0x000B831B File Offset: 0x000B651B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LuaUrl
		{
			get
			{
				return this.luaUrl_;
			}
			set
			{
				this.luaUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x060043C0 RID: 17344 RVA: 0x000B832E File Offset: 0x000B652E
		// (set) Token: 0x060043C1 RID: 17345 RVA: 0x000B8336 File Offset: 0x000B6536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PreDownloadUrl
		{
			get
			{
				return this.preDownloadUrl_;
			}
			set
			{
				this.preDownloadUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x060043C2 RID: 17346 RVA: 0x000B8349 File Offset: 0x000B6549
		// (set) Token: 0x060043C3 RID: 17347 RVA: 0x000B8351 File Offset: 0x000B6551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ForbidRecharge
		{
			get
			{
				return this.forbidRecharge_;
			}
			set
			{
				this.forbidRecharge_ = value;
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x000B835A File Offset: 0x000B655A
		// (set) Token: 0x060043C5 RID: 17349 RVA: 0x000B8362 File Offset: 0x000B6562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableUploadBattleLog
		{
			get
			{
				return this.enableUploadBattleLog_;
			}
			set
			{
				this.enableUploadBattleLog_ = value;
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x060043C6 RID: 17350 RVA: 0x000B836B File Offset: 0x000B656B
		// (set) Token: 0x060043C7 RID: 17351 RVA: 0x000B8373 File Offset: 0x000B6573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OnlineReplayDownloadUrl
		{
			get
			{
				return this.onlineReplayDownloadUrl_;
			}
			set
			{
				this.onlineReplayDownloadUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x060043C8 RID: 17352 RVA: 0x000B8386 File Offset: 0x000B6586
		// (set) Token: 0x060043C9 RID: 17353 RVA: 0x000B838E File Offset: 0x000B658E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NetworkDiagnostic
		{
			get
			{
				return this.networkDiagnostic_;
			}
			set
			{
				this.networkDiagnostic_ = value;
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x060043CA RID: 17354 RVA: 0x000B8397 File Offset: 0x000B6597
		// (set) Token: 0x060043CB RID: 17355 RVA: 0x000B839F File Offset: 0x000B659F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AssetBundleUrl
		{
			get
			{
				return this.assetBundleUrl_;
			}
			set
			{
				this.assetBundleUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x060043CC RID: 17356 RVA: 0x000B83B2 File Offset: 0x000B65B2
		// (set) Token: 0x060043CD RID: 17357 RVA: 0x000B83BA File Offset: 0x000B65BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BBFOAJGLLBC
		{
			get
			{
				return this.bBFOAJGLLBC_;
			}
			set
			{
				this.bBFOAJGLLBC_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x060043CE RID: 17358 RVA: 0x000B83CD File Offset: 0x000B65CD
		// (set) Token: 0x060043CF RID: 17359 RVA: 0x000B83D5 File Offset: 0x000B65D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OnlineReplayUploadUrl
		{
			get
			{
				return this.onlineReplayUploadUrl_;
			}
			set
			{
				this.onlineReplayUploadUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x060043D0 RID: 17360 RVA: 0x000B83E8 File Offset: 0x000B65E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> GBONLDEMBEN
		{
			get
			{
				return this.gBONLDEMBEN_;
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x000B83F0 File Offset: 0x000B65F0
		// (set) Token: 0x060043D2 RID: 17362 RVA: 0x000B83F8 File Offset: 0x000B65F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerReturnQuestionnaireBUrl
		{
			get
			{
				return this.playerReturnQuestionnaireBUrl_;
			}
			set
			{
				this.playerReturnQuestionnaireBUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x000B840B File Offset: 0x000B660B
		// (set) Token: 0x060043D4 RID: 17364 RVA: 0x000B8413 File Offset: 0x000B6613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AsbReloginDesc
		{
			get
			{
				return this.asbReloginDesc_;
			}
			set
			{
				this.asbReloginDesc_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x000B8426 File Offset: 0x000B6626
		// (set) Token: 0x060043D6 RID: 17366 RVA: 0x000B842E File Offset: 0x000B662E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IosExam
		{
			get
			{
				return this.iosExam_;
			}
			set
			{
				this.iosExam_ = value;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x000B8437 File Offset: 0x000B6637
		// (set) Token: 0x060043D8 RID: 17368 RVA: 0x000B843F File Offset: 0x000B663F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string KKHFKMIKFIB
		{
			get
			{
				return this.kKHFKMIKFIB_;
			}
			set
			{
				this.kKHFKMIKFIB_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x000B8452 File Offset: 0x000B6652
		// (set) Token: 0x060043DA RID: 17370 RVA: 0x000B845A File Offset: 0x000B665A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MDKDJLNHGKN
		{
			get
			{
				return this.mDKDJLNHGKN_;
			}
			set
			{
				this.mDKDJLNHGKN_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x000B846D File Offset: 0x000B666D
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x000B8475 File Offset: 0x000B6675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ELJIMGJLHBC
		{
			get
			{
				return this.eLJIMGJLHBC_;
			}
			set
			{
				this.eLJIMGJLHBC_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x060043DD RID: 17373 RVA: 0x000B8488 File Offset: 0x000B6688
		// (set) Token: 0x060043DE RID: 17374 RVA: 0x000B8490 File Offset: 0x000B6690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RegionStopEnd
		{
			get
			{
				return this.regionStopEnd_;
			}
			set
			{
				this.regionStopEnd_ = value;
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x000B8499 File Offset: 0x000B6699
		// (set) Token: 0x060043E0 RID: 17376 RVA: 0x000B84A1 File Offset: 0x000B66A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ServerDescription
		{
			get
			{
				return this.serverDescription_;
			}
			set
			{
				this.serverDescription_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x000B84B4 File Offset: 0x000B66B4
		// (set) Token: 0x060043E2 RID: 17378 RVA: 0x000B84BC File Offset: 0x000B66BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DesignDataReloginType
		{
			get
			{
				return this.designDataReloginType_;
			}
			set
			{
				this.designDataReloginType_ = value;
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x000B84C5 File Offset: 0x000B66C5
		// (set) Token: 0x060043E4 RID: 17380 RVA: 0x000B84CD File Offset: 0x000B66CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Port
		{
			get
			{
				return this.port_;
			}
			set
			{
				this.port_ = value;
			}
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x000B84D6 File Offset: 0x000B66D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GateServer);
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x000B84E4 File Offset: 0x000B66E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GateServer other)
		{
			return other != null && (other == this || (!(this.LKDFCHNEFBB != other.LKDFCHNEFBB) && !(this.LHGKDGDJIHC != other.LHGKDGDJIHC) && this.EnableVersionUpdate == other.EnableVersionUpdate && this.EnableCdnIpv6 == other.EnableCdnIpv6 && this.EnableWatermark == other.EnableWatermark && !(this.Msg != other.Msg) && !(this.IfixUrl != other.IfixUrl) && this.MtpSwitch == other.MtpSwitch && this.IALOEKGOJOC == other.IALOEKGOJOC && !(this.BJOCANIBBKI != other.BJOCANIBBKI) && this.EnableAndroidMiddlePackage == other.EnableAndroidMiddlePackage && !(this.IfixVersion != other.IfixVersion) && !(this.IIJLFILFMDF != other.IIJLFILFMDF) && this.FIOHEKDJNCG == other.FIOHEKDJNCG && !(this.LoginWhiteMsg != other.LoginWhiteMsg) && this.APJECJMGAKC == other.APJECJMGAKC && !(this.DesignDataReloginDesc != other.DesignDataReloginDesc) && !(this.MdkResVersion != other.MdkResVersion) && !(this.ClientSecretKey != other.ClientSecretKey) && !(this.Ipv6Address != other.Ipv6Address) && !(this.PMABNNEDCCG != other.PMABNNEDCCG) && !(this.KLIAGHGOFML != other.KLIAGHGOFML) && this.EventTrackingOpen == other.EventTrackingOpen && !(this.ODOCFCJMBCL != other.ODOCFCJMBCL) && !(this.NPIGPBEKEKO != other.NPIGPBEKEKO) && !(this.Ip != other.Ip) && !(this.RegionName != other.RegionName) && !(this.KDBAGALHEDC != other.KDBAGALHEDC) && this.CloseRedeemCode == other.CloseRedeemCode && this.RegionStopStart == other.RegionStopStart && this.UseTcp == other.UseTcp && !(this.FDGFFCMALPI != other.FDGFFCMALPI) && !(this.ExResourceUrl != other.ExResourceUrl) && !(this.FHALNCIHMGA != other.FHALNCIHMGA) && !(this.PlayerReturnQuestionnaireAUrl != other.PlayerReturnQuestionnaireAUrl) && this.Retcode == other.Retcode && !(this.IPKLAMMKNNG != other.IPKLAMMKNNG) && !(this.PlayerReturnInviteH5Url != other.PlayerReturnInviteH5Url) && this.AsbReloginType == other.AsbReloginType && this.CNAKLGMDLPE == other.CNAKLGMDLPE && !(this.LuaUrl != other.LuaUrl) && !(this.PreDownloadUrl != other.PreDownloadUrl) && this.ForbidRecharge == other.ForbidRecharge && this.EnableUploadBattleLog == other.EnableUploadBattleLog && !(this.OnlineReplayDownloadUrl != other.OnlineReplayDownloadUrl) && this.NetworkDiagnostic == other.NetworkDiagnostic && !(this.AssetBundleUrl != other.AssetBundleUrl) && !(this.BBFOAJGLLBC != other.BBFOAJGLLBC) && !(this.OnlineReplayUploadUrl != other.OnlineReplayUploadUrl) && this.gBONLDEMBEN_.Equals(other.gBONLDEMBEN_) && !(this.PlayerReturnQuestionnaireBUrl != other.PlayerReturnQuestionnaireBUrl) && !(this.AsbReloginDesc != other.AsbReloginDesc) && this.IosExam == other.IosExam && !(this.KKHFKMIKFIB != other.KKHFKMIKFIB) && !(this.MDKDJLNHGKN != other.MDKDJLNHGKN) && !(this.ELJIMGJLHBC != other.ELJIMGJLHBC) && this.RegionStopEnd == other.RegionStopEnd && !(this.ServerDescription != other.ServerDescription) && this.DesignDataReloginType == other.DesignDataReloginType && this.Port == other.Port && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x000B898C File Offset: 0x000B6B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LKDFCHNEFBB.Length != 0)
			{
				num ^= this.LKDFCHNEFBB.GetHashCode();
			}
			if (this.LHGKDGDJIHC.Length != 0)
			{
				num ^= this.LHGKDGDJIHC.GetHashCode();
			}
			if (this.EnableVersionUpdate)
			{
				num ^= this.EnableVersionUpdate.GetHashCode();
			}
			if (this.EnableCdnIpv6 != 0U)
			{
				num ^= this.EnableCdnIpv6.GetHashCode();
			}
			if (this.EnableWatermark)
			{
				num ^= this.EnableWatermark.GetHashCode();
			}
			if (this.Msg.Length != 0)
			{
				num ^= this.Msg.GetHashCode();
			}
			if (this.IfixUrl.Length != 0)
			{
				num ^= this.IfixUrl.GetHashCode();
			}
			if (this.MtpSwitch)
			{
				num ^= this.MtpSwitch.GetHashCode();
			}
			if (this.IALOEKGOJOC)
			{
				num ^= this.IALOEKGOJOC.GetHashCode();
			}
			if (this.BJOCANIBBKI.Length != 0)
			{
				num ^= this.BJOCANIBBKI.GetHashCode();
			}
			if (this.EnableAndroidMiddlePackage)
			{
				num ^= this.EnableAndroidMiddlePackage.GetHashCode();
			}
			if (this.IfixVersion.Length != 0)
			{
				num ^= this.IfixVersion.GetHashCode();
			}
			if (this.IIJLFILFMDF.Length != 0)
			{
				num ^= this.IIJLFILFMDF.GetHashCode();
			}
			if (this.FIOHEKDJNCG)
			{
				num ^= this.FIOHEKDJNCG.GetHashCode();
			}
			if (this.LoginWhiteMsg.Length != 0)
			{
				num ^= this.LoginWhiteMsg.GetHashCode();
			}
			if (this.APJECJMGAKC)
			{
				num ^= this.APJECJMGAKC.GetHashCode();
			}
			if (this.DesignDataReloginDesc.Length != 0)
			{
				num ^= this.DesignDataReloginDesc.GetHashCode();
			}
			if (this.MdkResVersion.Length != 0)
			{
				num ^= this.MdkResVersion.GetHashCode();
			}
			if (this.ClientSecretKey.Length != 0)
			{
				num ^= this.ClientSecretKey.GetHashCode();
			}
			if (this.Ipv6Address.Length != 0)
			{
				num ^= this.Ipv6Address.GetHashCode();
			}
			if (this.PMABNNEDCCG.Length != 0)
			{
				num ^= this.PMABNNEDCCG.GetHashCode();
			}
			if (this.KLIAGHGOFML.Length != 0)
			{
				num ^= this.KLIAGHGOFML.GetHashCode();
			}
			if (this.EventTrackingOpen)
			{
				num ^= this.EventTrackingOpen.GetHashCode();
			}
			if (this.ODOCFCJMBCL.Length != 0)
			{
				num ^= this.ODOCFCJMBCL.GetHashCode();
			}
			if (this.NPIGPBEKEKO.Length != 0)
			{
				num ^= this.NPIGPBEKEKO.GetHashCode();
			}
			if (this.Ip.Length != 0)
			{
				num ^= this.Ip.GetHashCode();
			}
			if (this.RegionName.Length != 0)
			{
				num ^= this.RegionName.GetHashCode();
			}
			if (this.KDBAGALHEDC.Length != 0)
			{
				num ^= this.KDBAGALHEDC.GetHashCode();
			}
			if (this.CloseRedeemCode)
			{
				num ^= this.CloseRedeemCode.GetHashCode();
			}
			if (this.RegionStopStart != 0L)
			{
				num ^= this.RegionStopStart.GetHashCode();
			}
			if (this.UseTcp)
			{
				num ^= this.UseTcp.GetHashCode();
			}
			if (this.FDGFFCMALPI.Length != 0)
			{
				num ^= this.FDGFFCMALPI.GetHashCode();
			}
			if (this.ExResourceUrl.Length != 0)
			{
				num ^= this.ExResourceUrl.GetHashCode();
			}
			if (this.FHALNCIHMGA.Length != 0)
			{
				num ^= this.FHALNCIHMGA.GetHashCode();
			}
			if (this.PlayerReturnQuestionnaireAUrl.Length != 0)
			{
				num ^= this.PlayerReturnQuestionnaireAUrl.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.IPKLAMMKNNG.Length != 0)
			{
				num ^= this.IPKLAMMKNNG.GetHashCode();
			}
			if (this.PlayerReturnInviteH5Url.Length != 0)
			{
				num ^= this.PlayerReturnInviteH5Url.GetHashCode();
			}
			if (this.AsbReloginType != 0U)
			{
				num ^= this.AsbReloginType.GetHashCode();
			}
			if (this.CNAKLGMDLPE)
			{
				num ^= this.CNAKLGMDLPE.GetHashCode();
			}
			if (this.LuaUrl.Length != 0)
			{
				num ^= this.LuaUrl.GetHashCode();
			}
			if (this.PreDownloadUrl.Length != 0)
			{
				num ^= this.PreDownloadUrl.GetHashCode();
			}
			if (this.ForbidRecharge)
			{
				num ^= this.ForbidRecharge.GetHashCode();
			}
			if (this.EnableUploadBattleLog)
			{
				num ^= this.EnableUploadBattleLog.GetHashCode();
			}
			if (this.OnlineReplayDownloadUrl.Length != 0)
			{
				num ^= this.OnlineReplayDownloadUrl.GetHashCode();
			}
			if (this.NetworkDiagnostic)
			{
				num ^= this.NetworkDiagnostic.GetHashCode();
			}
			if (this.AssetBundleUrl.Length != 0)
			{
				num ^= this.AssetBundleUrl.GetHashCode();
			}
			if (this.BBFOAJGLLBC.Length != 0)
			{
				num ^= this.BBFOAJGLLBC.GetHashCode();
			}
			if (this.OnlineReplayUploadUrl.Length != 0)
			{
				num ^= this.OnlineReplayUploadUrl.GetHashCode();
			}
			num ^= this.gBONLDEMBEN_.GetHashCode();
			if (this.PlayerReturnQuestionnaireBUrl.Length != 0)
			{
				num ^= this.PlayerReturnQuestionnaireBUrl.GetHashCode();
			}
			if (this.AsbReloginDesc.Length != 0)
			{
				num ^= this.AsbReloginDesc.GetHashCode();
			}
			if (this.IosExam)
			{
				num ^= this.IosExam.GetHashCode();
			}
			if (this.KKHFKMIKFIB.Length != 0)
			{
				num ^= this.KKHFKMIKFIB.GetHashCode();
			}
			if (this.MDKDJLNHGKN.Length != 0)
			{
				num ^= this.MDKDJLNHGKN.GetHashCode();
			}
			if (this.ELJIMGJLHBC.Length != 0)
			{
				num ^= this.ELJIMGJLHBC.GetHashCode();
			}
			if (this.RegionStopEnd != 0L)
			{
				num ^= this.RegionStopEnd.GetHashCode();
			}
			if (this.ServerDescription.Length != 0)
			{
				num ^= this.ServerDescription.GetHashCode();
			}
			if (this.DesignDataReloginType != 0U)
			{
				num ^= this.DesignDataReloginType.GetHashCode();
			}
			if (this.Port != 0U)
			{
				num ^= this.Port.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x000B8FCD File Offset: 0x000B71CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x000B8FD5 File Offset: 0x000B71D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x000B8FE0 File Offset: 0x000B71E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExResourceUrl.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ExResourceUrl);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.LuaUrl.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.LuaUrl);
			}
			if (this.RegionStopStart != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.RegionStopStart);
			}
			if (this.Ip.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Ip);
			}
			if (this.IALOEKGOJOC)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IALOEKGOJOC);
			}
			if (this.DesignDataReloginType != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.DesignDataReloginType);
			}
			if (this.Msg.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Msg);
			}
			if (this.AssetBundleUrl.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.AssetBundleUrl);
			}
			if (this.EnableVersionUpdate)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.EnableVersionUpdate);
			}
			if (this.Port != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Port);
			}
			if (this.RegionName.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.RegionName);
			}
			if (this.AsbReloginType != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.AsbReloginType);
			}
			if (this.AsbReloginDesc.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.AsbReloginDesc);
			}
			if (this.RegionStopEnd != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.RegionStopEnd);
			}
			if (this.ServerDescription.Length != 0)
			{
				output.WriteRawTag(162, 1);
				output.WriteString(this.ServerDescription);
			}
			if (this.CloseRedeemCode)
			{
				output.WriteRawTag(240, 3);
				output.WriteBool(this.CloseRedeemCode);
			}
			if (this.IPKLAMMKNNG.Length != 0)
			{
				output.WriteRawTag(170, 7);
				output.WriteString(this.IPKLAMMKNNG);
			}
			if (this.IIJLFILFMDF.Length != 0)
			{
				output.WriteRawTag(210, 8);
				output.WriteString(this.IIJLFILFMDF);
			}
			if (this.EnableWatermark)
			{
				output.WriteRawTag(176, 20);
				output.WriteBool(this.EnableWatermark);
			}
			if (this.ODOCFCJMBCL.Length != 0)
			{
				output.WriteRawTag(138, 21);
				output.WriteString(this.ODOCFCJMBCL);
			}
			if (this.EnableUploadBattleLog)
			{
				output.WriteRawTag(160, 21);
				output.WriteBool(this.EnableUploadBattleLog);
			}
			if (this.BBFOAJGLLBC.Length != 0)
			{
				output.WriteRawTag(154, 22);
				output.WriteString(this.BBFOAJGLLBC);
			}
			if (this.KKHFKMIKFIB.Length != 0)
			{
				output.WriteRawTag(210, 22);
				output.WriteString(this.KKHFKMIKFIB);
			}
			if (this.PreDownloadUrl.Length != 0)
			{
				output.WriteRawTag(234, 22);
				output.WriteString(this.PreDownloadUrl);
			}
			if (this.IfixUrl.Length != 0)
			{
				output.WriteRawTag(146, 23);
				output.WriteString(this.IfixUrl);
			}
			if (this.CNAKLGMDLPE)
			{
				output.WriteRawTag(176, 26);
				output.WriteBool(this.CNAKLGMDLPE);
			}
			if (this.ClientSecretKey.Length != 0)
			{
				output.WriteRawTag(162, 28);
				output.WriteString(this.ClientSecretKey);
			}
			if (this.NPIGPBEKEKO.Length != 0)
			{
				output.WriteRawTag(130, 29);
				output.WriteString(this.NPIGPBEKEKO);
			}
			if (this.IfixVersion.Length != 0)
			{
				output.WriteRawTag(202, 35);
				output.WriteString(this.IfixVersion);
			}
			if (this.APJECJMGAKC)
			{
				output.WriteRawTag(136, 36);
				output.WriteBool(this.APJECJMGAKC);
			}
			if (this.FHALNCIHMGA.Length != 0)
			{
				output.WriteRawTag(130, 37);
				output.WriteString(this.FHALNCIHMGA);
			}
			if (this.LKDFCHNEFBB.Length != 0)
			{
				output.WriteRawTag(178, 38);
				output.WriteString(this.LKDFCHNEFBB);
			}
			if (this.LoginWhiteMsg.Length != 0)
			{
				output.WriteRawTag(154, 41);
				output.WriteString(this.LoginWhiteMsg);
			}
			if (this.UseTcp)
			{
				output.WriteRawTag(136, 42);
				output.WriteBool(this.UseTcp);
			}
			if (this.LHGKDGDJIHC.Length != 0)
			{
				output.WriteRawTag(130, 49);
				output.WriteString(this.LHGKDGDJIHC);
			}
			if (this.FIOHEKDJNCG)
			{
				output.WriteRawTag(168, 52);
				output.WriteBool(this.FIOHEKDJNCG);
			}
			if (this.OnlineReplayDownloadUrl.Length != 0)
			{
				output.WriteRawTag(146, 60);
				output.WriteString(this.OnlineReplayDownloadUrl);
			}
			if (this.PMABNNEDCCG.Length != 0)
			{
				output.WriteRawTag(162, 63);
				output.WriteString(this.PMABNNEDCCG);
			}
			if (this.DesignDataReloginDesc.Length != 0)
			{
				output.WriteRawTag(218, 64);
				output.WriteString(this.DesignDataReloginDesc);
			}
			if (this.KDBAGALHEDC.Length != 0)
			{
				output.WriteRawTag(146, 70);
				output.WriteString(this.KDBAGALHEDC);
			}
			if (this.FDGFFCMALPI.Length != 0)
			{
				output.WriteRawTag(242, 70);
				output.WriteString(this.FDGFFCMALPI);
			}
			if (this.EnableCdnIpv6 != 0U)
			{
				output.WriteRawTag(216, 77);
				output.WriteUInt32(this.EnableCdnIpv6);
			}
			if (this.KLIAGHGOFML.Length != 0)
			{
				output.WriteRawTag(234, 77);
				output.WriteString(this.KLIAGHGOFML);
			}
			if (this.OnlineReplayUploadUrl.Length != 0)
			{
				output.WriteRawTag(218, 81);
				output.WriteString(this.OnlineReplayUploadUrl);
			}
			if (this.BJOCANIBBKI.Length != 0)
			{
				output.WriteRawTag(162, 83);
				output.WriteString(this.BJOCANIBBKI);
			}
			if (this.PlayerReturnQuestionnaireBUrl.Length != 0)
			{
				output.WriteRawTag(178, 83);
				output.WriteString(this.PlayerReturnQuestionnaireBUrl);
			}
			if (this.MdkResVersion.Length != 0)
			{
				output.WriteRawTag(250, 84);
				output.WriteString(this.MdkResVersion);
			}
			if (this.PlayerReturnInviteH5Url.Length != 0)
			{
				output.WriteRawTag(162, 97);
				output.WriteString(this.PlayerReturnInviteH5Url);
			}
			if (this.EnableAndroidMiddlePackage)
			{
				output.WriteRawTag(176, 98);
				output.WriteBool(this.EnableAndroidMiddlePackage);
			}
			if (this.IosExam)
			{
				output.WriteRawTag(184, 98);
				output.WriteBool(this.IosExam);
			}
			this.gBONLDEMBEN_.WriteTo(ref output, GateServer._repeated_gBONLDEMBEN_codec);
			if (this.MDKDJLNHGKN.Length != 0)
			{
				output.WriteRawTag(194, 101);
				output.WriteString(this.MDKDJLNHGKN);
			}
			if (this.ForbidRecharge)
			{
				output.WriteRawTag(184, 106);
				output.WriteBool(this.ForbidRecharge);
			}
			if (this.ELJIMGJLHBC.Length != 0)
			{
				output.WriteRawTag(154, 111);
				output.WriteString(this.ELJIMGJLHBC);
			}
			if (this.NetworkDiagnostic)
			{
				output.WriteRawTag(176, 111);
				output.WriteBool(this.NetworkDiagnostic);
			}
			if (this.EventTrackingOpen)
			{
				output.WriteRawTag(208, 116);
				output.WriteBool(this.EventTrackingOpen);
			}
			if (this.PlayerReturnQuestionnaireAUrl.Length != 0)
			{
				output.WriteRawTag(170, 118);
				output.WriteString(this.PlayerReturnQuestionnaireAUrl);
			}
			if (this.Ipv6Address.Length != 0)
			{
				output.WriteRawTag(130, 122);
				output.WriteString(this.Ipv6Address);
			}
			if (this.MtpSwitch)
			{
				output.WriteRawTag(144, 126);
				output.WriteBool(this.MtpSwitch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x000B9818 File Offset: 0x000B7A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LKDFCHNEFBB.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LKDFCHNEFBB);
			}
			if (this.LHGKDGDJIHC.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LHGKDGDJIHC);
			}
			if (this.EnableVersionUpdate)
			{
				num += 2;
			}
			if (this.EnableCdnIpv6 != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.EnableCdnIpv6);
			}
			if (this.EnableWatermark)
			{
				num += 3;
			}
			if (this.Msg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Msg);
			}
			if (this.IfixUrl.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.IfixUrl);
			}
			if (this.MtpSwitch)
			{
				num += 3;
			}
			if (this.IALOEKGOJOC)
			{
				num += 2;
			}
			if (this.BJOCANIBBKI.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.BJOCANIBBKI);
			}
			if (this.EnableAndroidMiddlePackage)
			{
				num += 3;
			}
			if (this.IfixVersion.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.IfixVersion);
			}
			if (this.IIJLFILFMDF.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.IIJLFILFMDF);
			}
			if (this.FIOHEKDJNCG)
			{
				num += 3;
			}
			if (this.LoginWhiteMsg.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LoginWhiteMsg);
			}
			if (this.APJECJMGAKC)
			{
				num += 3;
			}
			if (this.DesignDataReloginDesc.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.DesignDataReloginDesc);
			}
			if (this.MdkResVersion.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.MdkResVersion);
			}
			if (this.ClientSecretKey.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ClientSecretKey);
			}
			if (this.Ipv6Address.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Ipv6Address);
			}
			if (this.PMABNNEDCCG.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PMABNNEDCCG);
			}
			if (this.KLIAGHGOFML.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.KLIAGHGOFML);
			}
			if (this.EventTrackingOpen)
			{
				num += 3;
			}
			if (this.ODOCFCJMBCL.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ODOCFCJMBCL);
			}
			if (this.NPIGPBEKEKO.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.NPIGPBEKEKO);
			}
			if (this.Ip.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Ip);
			}
			if (this.RegionName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RegionName);
			}
			if (this.KDBAGALHEDC.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.KDBAGALHEDC);
			}
			if (this.CloseRedeemCode)
			{
				num += 3;
			}
			if (this.RegionStopStart != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RegionStopStart);
			}
			if (this.UseTcp)
			{
				num += 3;
			}
			if (this.FDGFFCMALPI.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.FDGFFCMALPI);
			}
			if (this.ExResourceUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ExResourceUrl);
			}
			if (this.FHALNCIHMGA.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.FHALNCIHMGA);
			}
			if (this.PlayerReturnQuestionnaireAUrl.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PlayerReturnQuestionnaireAUrl);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.IPKLAMMKNNG.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.IPKLAMMKNNG);
			}
			if (this.PlayerReturnInviteH5Url.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PlayerReturnInviteH5Url);
			}
			if (this.AsbReloginType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AsbReloginType);
			}
			if (this.CNAKLGMDLPE)
			{
				num += 3;
			}
			if (this.LuaUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LuaUrl);
			}
			if (this.PreDownloadUrl.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PreDownloadUrl);
			}
			if (this.ForbidRecharge)
			{
				num += 3;
			}
			if (this.EnableUploadBattleLog)
			{
				num += 3;
			}
			if (this.OnlineReplayDownloadUrl.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.OnlineReplayDownloadUrl);
			}
			if (this.NetworkDiagnostic)
			{
				num += 3;
			}
			if (this.AssetBundleUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AssetBundleUrl);
			}
			if (this.BBFOAJGLLBC.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.BBFOAJGLLBC);
			}
			if (this.OnlineReplayUploadUrl.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.OnlineReplayUploadUrl);
			}
			num += this.gBONLDEMBEN_.CalculateSize(GateServer._repeated_gBONLDEMBEN_codec);
			if (this.PlayerReturnQuestionnaireBUrl.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PlayerReturnQuestionnaireBUrl);
			}
			if (this.AsbReloginDesc.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AsbReloginDesc);
			}
			if (this.IosExam)
			{
				num += 3;
			}
			if (this.KKHFKMIKFIB.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.KKHFKMIKFIB);
			}
			if (this.MDKDJLNHGKN.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.MDKDJLNHGKN);
			}
			if (this.ELJIMGJLHBC.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ELJIMGJLHBC);
			}
			if (this.RegionStopEnd != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RegionStopEnd);
			}
			if (this.ServerDescription.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ServerDescription);
			}
			if (this.DesignDataReloginType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DesignDataReloginType);
			}
			if (this.Port != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Port);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x000B9DE0 File Offset: 0x000B7FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GateServer other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LKDFCHNEFBB.Length != 0)
			{
				this.LKDFCHNEFBB = other.LKDFCHNEFBB;
			}
			if (other.LHGKDGDJIHC.Length != 0)
			{
				this.LHGKDGDJIHC = other.LHGKDGDJIHC;
			}
			if (other.EnableVersionUpdate)
			{
				this.EnableVersionUpdate = other.EnableVersionUpdate;
			}
			if (other.EnableCdnIpv6 != 0U)
			{
				this.EnableCdnIpv6 = other.EnableCdnIpv6;
			}
			if (other.EnableWatermark)
			{
				this.EnableWatermark = other.EnableWatermark;
			}
			if (other.Msg.Length != 0)
			{
				this.Msg = other.Msg;
			}
			if (other.IfixUrl.Length != 0)
			{
				this.IfixUrl = other.IfixUrl;
			}
			if (other.MtpSwitch)
			{
				this.MtpSwitch = other.MtpSwitch;
			}
			if (other.IALOEKGOJOC)
			{
				this.IALOEKGOJOC = other.IALOEKGOJOC;
			}
			if (other.BJOCANIBBKI.Length != 0)
			{
				this.BJOCANIBBKI = other.BJOCANIBBKI;
			}
			if (other.EnableAndroidMiddlePackage)
			{
				this.EnableAndroidMiddlePackage = other.EnableAndroidMiddlePackage;
			}
			if (other.IfixVersion.Length != 0)
			{
				this.IfixVersion = other.IfixVersion;
			}
			if (other.IIJLFILFMDF.Length != 0)
			{
				this.IIJLFILFMDF = other.IIJLFILFMDF;
			}
			if (other.FIOHEKDJNCG)
			{
				this.FIOHEKDJNCG = other.FIOHEKDJNCG;
			}
			if (other.LoginWhiteMsg.Length != 0)
			{
				this.LoginWhiteMsg = other.LoginWhiteMsg;
			}
			if (other.APJECJMGAKC)
			{
				this.APJECJMGAKC = other.APJECJMGAKC;
			}
			if (other.DesignDataReloginDesc.Length != 0)
			{
				this.DesignDataReloginDesc = other.DesignDataReloginDesc;
			}
			if (other.MdkResVersion.Length != 0)
			{
				this.MdkResVersion = other.MdkResVersion;
			}
			if (other.ClientSecretKey.Length != 0)
			{
				this.ClientSecretKey = other.ClientSecretKey;
			}
			if (other.Ipv6Address.Length != 0)
			{
				this.Ipv6Address = other.Ipv6Address;
			}
			if (other.PMABNNEDCCG.Length != 0)
			{
				this.PMABNNEDCCG = other.PMABNNEDCCG;
			}
			if (other.KLIAGHGOFML.Length != 0)
			{
				this.KLIAGHGOFML = other.KLIAGHGOFML;
			}
			if (other.EventTrackingOpen)
			{
				this.EventTrackingOpen = other.EventTrackingOpen;
			}
			if (other.ODOCFCJMBCL.Length != 0)
			{
				this.ODOCFCJMBCL = other.ODOCFCJMBCL;
			}
			if (other.NPIGPBEKEKO.Length != 0)
			{
				this.NPIGPBEKEKO = other.NPIGPBEKEKO;
			}
			if (other.Ip.Length != 0)
			{
				this.Ip = other.Ip;
			}
			if (other.RegionName.Length != 0)
			{
				this.RegionName = other.RegionName;
			}
			if (other.KDBAGALHEDC.Length != 0)
			{
				this.KDBAGALHEDC = other.KDBAGALHEDC;
			}
			if (other.CloseRedeemCode)
			{
				this.CloseRedeemCode = other.CloseRedeemCode;
			}
			if (other.RegionStopStart != 0L)
			{
				this.RegionStopStart = other.RegionStopStart;
			}
			if (other.UseTcp)
			{
				this.UseTcp = other.UseTcp;
			}
			if (other.FDGFFCMALPI.Length != 0)
			{
				this.FDGFFCMALPI = other.FDGFFCMALPI;
			}
			if (other.ExResourceUrl.Length != 0)
			{
				this.ExResourceUrl = other.ExResourceUrl;
			}
			if (other.FHALNCIHMGA.Length != 0)
			{
				this.FHALNCIHMGA = other.FHALNCIHMGA;
			}
			if (other.PlayerReturnQuestionnaireAUrl.Length != 0)
			{
				this.PlayerReturnQuestionnaireAUrl = other.PlayerReturnQuestionnaireAUrl;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.IPKLAMMKNNG.Length != 0)
			{
				this.IPKLAMMKNNG = other.IPKLAMMKNNG;
			}
			if (other.PlayerReturnInviteH5Url.Length != 0)
			{
				this.PlayerReturnInviteH5Url = other.PlayerReturnInviteH5Url;
			}
			if (other.AsbReloginType != 0U)
			{
				this.AsbReloginType = other.AsbReloginType;
			}
			if (other.CNAKLGMDLPE)
			{
				this.CNAKLGMDLPE = other.CNAKLGMDLPE;
			}
			if (other.LuaUrl.Length != 0)
			{
				this.LuaUrl = other.LuaUrl;
			}
			if (other.PreDownloadUrl.Length != 0)
			{
				this.PreDownloadUrl = other.PreDownloadUrl;
			}
			if (other.ForbidRecharge)
			{
				this.ForbidRecharge = other.ForbidRecharge;
			}
			if (other.EnableUploadBattleLog)
			{
				this.EnableUploadBattleLog = other.EnableUploadBattleLog;
			}
			if (other.OnlineReplayDownloadUrl.Length != 0)
			{
				this.OnlineReplayDownloadUrl = other.OnlineReplayDownloadUrl;
			}
			if (other.NetworkDiagnostic)
			{
				this.NetworkDiagnostic = other.NetworkDiagnostic;
			}
			if (other.AssetBundleUrl.Length != 0)
			{
				this.AssetBundleUrl = other.AssetBundleUrl;
			}
			if (other.BBFOAJGLLBC.Length != 0)
			{
				this.BBFOAJGLLBC = other.BBFOAJGLLBC;
			}
			if (other.OnlineReplayUploadUrl.Length != 0)
			{
				this.OnlineReplayUploadUrl = other.OnlineReplayUploadUrl;
			}
			this.gBONLDEMBEN_.Add(other.gBONLDEMBEN_);
			if (other.PlayerReturnQuestionnaireBUrl.Length != 0)
			{
				this.PlayerReturnQuestionnaireBUrl = other.PlayerReturnQuestionnaireBUrl;
			}
			if (other.AsbReloginDesc.Length != 0)
			{
				this.AsbReloginDesc = other.AsbReloginDesc;
			}
			if (other.IosExam)
			{
				this.IosExam = other.IosExam;
			}
			if (other.KKHFKMIKFIB.Length != 0)
			{
				this.KKHFKMIKFIB = other.KKHFKMIKFIB;
			}
			if (other.MDKDJLNHGKN.Length != 0)
			{
				this.MDKDJLNHGKN = other.MDKDJLNHGKN;
			}
			if (other.ELJIMGJLHBC.Length != 0)
			{
				this.ELJIMGJLHBC = other.ELJIMGJLHBC;
			}
			if (other.RegionStopEnd != 0L)
			{
				this.RegionStopEnd = other.RegionStopEnd;
			}
			if (other.ServerDescription.Length != 0)
			{
				this.ServerDescription = other.ServerDescription;
			}
			if (other.DesignDataReloginType != 0U)
			{
				this.DesignDataReloginType = other.DesignDataReloginType;
			}
			if (other.Port != 0U)
			{
				this.Port = other.Port;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x000BA36E File Offset: 0x000B856E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x000BA378 File Offset: 0x000B8578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 4554U)
				{
					if (num <= 120U)
					{
						if (num <= 56U)
						{
							if (num <= 26U)
							{
								if (num == 10U)
								{
									this.ExResourceUrl = input.ReadString();
									continue;
								}
								if (num == 16U)
								{
									this.Retcode = input.ReadUInt32();
									continue;
								}
								if (num == 26U)
								{
									this.LuaUrl = input.ReadString();
									continue;
								}
							}
							else if (num <= 42U)
							{
								if (num == 32U)
								{
									this.RegionStopStart = input.ReadInt64();
									continue;
								}
								if (num == 42U)
								{
									this.Ip = input.ReadString();
									continue;
								}
							}
							else
							{
								if (num == 48U)
								{
									this.IALOEKGOJOC = input.ReadBool();
									continue;
								}
								if (num == 56U)
								{
									this.DesignDataReloginType = input.ReadUInt32();
									continue;
								}
							}
						}
						else if (num <= 88U)
						{
							if (num <= 74U)
							{
								if (num == 66U)
								{
									this.Msg = input.ReadString();
									continue;
								}
								if (num == 74U)
								{
									this.AssetBundleUrl = input.ReadString();
									continue;
								}
							}
							else
							{
								if (num == 80U)
								{
									this.EnableVersionUpdate = input.ReadBool();
									continue;
								}
								if (num == 88U)
								{
									this.Port = input.ReadUInt32();
									continue;
								}
							}
						}
						else if (num <= 104U)
						{
							if (num == 98U)
							{
								this.RegionName = input.ReadString();
								continue;
							}
							if (num == 104U)
							{
								this.AsbReloginType = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 114U)
							{
								this.AsbReloginDesc = input.ReadString();
								continue;
							}
							if (num == 120U)
							{
								this.RegionStopEnd = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 2720U)
					{
						if (num <= 938U)
						{
							if (num == 162U)
							{
								this.ServerDescription = input.ReadString();
								continue;
							}
							if (num == 496U)
							{
								this.CloseRedeemCode = input.ReadBool();
								continue;
							}
							if (num == 938U)
							{
								this.IPKLAMMKNNG = input.ReadString();
								continue;
							}
						}
						else if (num <= 2608U)
						{
							if (num == 1106U)
							{
								this.IIJLFILFMDF = input.ReadString();
								continue;
							}
							if (num == 2608U)
							{
								this.EnableWatermark = input.ReadBool();
								continue;
							}
						}
						else
						{
							if (num == 2698U)
							{
								this.ODOCFCJMBCL = input.ReadString();
								continue;
							}
							if (num == 2720U)
							{
								this.EnableUploadBattleLog = input.ReadBool();
								continue;
							}
						}
					}
					else if (num <= 2962U)
					{
						if (num <= 2898U)
						{
							if (num == 2842U)
							{
								this.BBFOAJGLLBC = input.ReadString();
								continue;
							}
							if (num == 2898U)
							{
								this.KKHFKMIKFIB = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 2922U)
							{
								this.PreDownloadUrl = input.ReadString();
								continue;
							}
							if (num == 2962U)
							{
								this.IfixUrl = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 3618U)
					{
						if (num == 3376U)
						{
							this.CNAKLGMDLPE = input.ReadBool();
							continue;
						}
						if (num == 3618U)
						{
							this.ClientSecretKey = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 3714U)
						{
							this.NPIGPBEKEKO = input.ReadString();
							continue;
						}
						if (num == 4554U)
						{
							this.IfixVersion = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 10458U)
				{
					if (num <= 6696U)
					{
						if (num <= 4914U)
						{
							if (num == 4616U)
							{
								this.APJECJMGAKC = input.ReadBool();
								continue;
							}
							if (num == 4738U)
							{
								this.FHALNCIHMGA = input.ReadString();
								continue;
							}
							if (num == 4914U)
							{
								this.LKDFCHNEFBB = input.ReadString();
								continue;
							}
						}
						else if (num <= 5384U)
						{
							if (num == 5274U)
							{
								this.LoginWhiteMsg = input.ReadString();
								continue;
							}
							if (num == 5384U)
							{
								this.UseTcp = input.ReadBool();
								continue;
							}
						}
						else
						{
							if (num == 6274U)
							{
								this.LHGKDGDJIHC = input.ReadString();
								continue;
							}
							if (num == 6696U)
							{
								this.FIOHEKDJNCG = input.ReadBool();
								continue;
							}
						}
					}
					else if (num <= 8978U)
					{
						if (num <= 8098U)
						{
							if (num == 7698U)
							{
								this.OnlineReplayDownloadUrl = input.ReadString();
								continue;
							}
							if (num == 8098U)
							{
								this.PMABNNEDCCG = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 8282U)
							{
								this.DesignDataReloginDesc = input.ReadString();
								continue;
							}
							if (num == 8978U)
							{
								this.KDBAGALHEDC = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 9944U)
					{
						if (num == 9074U)
						{
							this.FDGFFCMALPI = input.ReadString();
							continue;
						}
						if (num == 9944U)
						{
							this.EnableCdnIpv6 = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 9962U)
						{
							this.KLIAGHGOFML = input.ReadString();
							continue;
						}
						if (num == 10458U)
						{
							this.OnlineReplayUploadUrl = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 12706U)
				{
					if (num <= 10874U)
					{
						if (num == 10658U)
						{
							this.BJOCANIBBKI = input.ReadString();
							continue;
						}
						if (num == 10674U)
						{
							this.PlayerReturnQuestionnaireBUrl = input.ReadString();
							continue;
						}
						if (num == 10874U)
						{
							this.MdkResVersion = input.ReadString();
							continue;
						}
					}
					else if (num <= 12592U)
					{
						if (num == 12450U)
						{
							this.PlayerReturnInviteH5Url = input.ReadString();
							continue;
						}
						if (num == 12592U)
						{
							this.EnableAndroidMiddlePackage = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 12600U)
						{
							this.IosExam = input.ReadBool();
							continue;
						}
						if (num == 12706U)
						{
							this.gBONLDEMBEN_.AddEntriesFrom(ref input, GateServer._repeated_gBONLDEMBEN_codec);
							continue;
						}
					}
				}
				else if (num <= 14256U)
				{
					if (num <= 13624U)
					{
						if (num == 12994U)
						{
							this.MDKDJLNHGKN = input.ReadString();
							continue;
						}
						if (num == 13624U)
						{
							this.ForbidRecharge = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 14234U)
						{
							this.ELJIMGJLHBC = input.ReadString();
							continue;
						}
						if (num == 14256U)
						{
							this.NetworkDiagnostic = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 15146U)
				{
					if (num == 14928U)
					{
						this.EventTrackingOpen = input.ReadBool();
						continue;
					}
					if (num == 15146U)
					{
						this.PlayerReturnQuestionnaireAUrl = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 15618U)
					{
						this.Ipv6Address = input.ReadString();
						continue;
					}
					if (num == 16144U)
					{
						this.MtpSwitch = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001AC2 RID: 6850
		private static readonly MessageParser<GateServer> _parser = new MessageParser<GateServer>(() => new GateServer());

		// Token: 0x04001AC3 RID: 6851
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AC4 RID: 6852
		public const int LKDFCHNEFBBFieldNumber = 614;

		// Token: 0x04001AC5 RID: 6853
		private string lKDFCHNEFBB_ = "";

		// Token: 0x04001AC6 RID: 6854
		public const int LHGKDGDJIHCFieldNumber = 784;

		// Token: 0x04001AC7 RID: 6855
		private string lHGKDGDJIHC_ = "";

		// Token: 0x04001AC8 RID: 6856
		public const int EnableVersionUpdateFieldNumber = 10;

		// Token: 0x04001AC9 RID: 6857
		private bool enableVersionUpdate_;

		// Token: 0x04001ACA RID: 6858
		public const int EnableCdnIpv6FieldNumber = 1243;

		// Token: 0x04001ACB RID: 6859
		private uint enableCdnIpv6_;

		// Token: 0x04001ACC RID: 6860
		public const int EnableWatermarkFieldNumber = 326;

		// Token: 0x04001ACD RID: 6861
		private bool enableWatermark_;

		// Token: 0x04001ACE RID: 6862
		public const int MsgFieldNumber = 8;

		// Token: 0x04001ACF RID: 6863
		private string msg_ = "";

		// Token: 0x04001AD0 RID: 6864
		public const int IfixUrlFieldNumber = 370;

		// Token: 0x04001AD1 RID: 6865
		private string ifixUrl_ = "";

		// Token: 0x04001AD2 RID: 6866
		public const int MtpSwitchFieldNumber = 2018;

		// Token: 0x04001AD3 RID: 6867
		private bool mtpSwitch_;

		// Token: 0x04001AD4 RID: 6868
		public const int IALOEKGOJOCFieldNumber = 6;

		// Token: 0x04001AD5 RID: 6869
		private bool iALOEKGOJOC_;

		// Token: 0x04001AD6 RID: 6870
		public const int BJOCANIBBKIFieldNumber = 1332;

		// Token: 0x04001AD7 RID: 6871
		private string bJOCANIBBKI_ = "";

		// Token: 0x04001AD8 RID: 6872
		public const int EnableAndroidMiddlePackageFieldNumber = 1574;

		// Token: 0x04001AD9 RID: 6873
		private bool enableAndroidMiddlePackage_;

		// Token: 0x04001ADA RID: 6874
		public const int IfixVersionFieldNumber = 569;

		// Token: 0x04001ADB RID: 6875
		private string ifixVersion_ = "";

		// Token: 0x04001ADC RID: 6876
		public const int IIJLFILFMDFFieldNumber = 138;

		// Token: 0x04001ADD RID: 6877
		private string iIJLFILFMDF_ = "";

		// Token: 0x04001ADE RID: 6878
		public const int FIOHEKDJNCGFieldNumber = 837;

		// Token: 0x04001ADF RID: 6879
		private bool fIOHEKDJNCG_;

		// Token: 0x04001AE0 RID: 6880
		public const int LoginWhiteMsgFieldNumber = 659;

		// Token: 0x04001AE1 RID: 6881
		private string loginWhiteMsg_ = "";

		// Token: 0x04001AE2 RID: 6882
		public const int APJECJMGAKCFieldNumber = 577;

		// Token: 0x04001AE3 RID: 6883
		private bool aPJECJMGAKC_;

		// Token: 0x04001AE4 RID: 6884
		public const int DesignDataReloginDescFieldNumber = 1035;

		// Token: 0x04001AE5 RID: 6885
		private string designDataReloginDesc_ = "";

		// Token: 0x04001AE6 RID: 6886
		public const int MdkResVersionFieldNumber = 1359;

		// Token: 0x04001AE7 RID: 6887
		private string mdkResVersion_ = "";

		// Token: 0x04001AE8 RID: 6888
		public const int ClientSecretKeyFieldNumber = 452;

		// Token: 0x04001AE9 RID: 6889
		private string clientSecretKey_ = "";

		// Token: 0x04001AEA RID: 6890
		public const int Ipv6AddressFieldNumber = 1952;

		// Token: 0x04001AEB RID: 6891
		private string ipv6Address_ = "";

		// Token: 0x04001AEC RID: 6892
		public const int PMABNNEDCCGFieldNumber = 1012;

		// Token: 0x04001AED RID: 6893
		private string pMABNNEDCCG_ = "";

		// Token: 0x04001AEE RID: 6894
		public const int KLIAGHGOFMLFieldNumber = 1245;

		// Token: 0x04001AEF RID: 6895
		private string kLIAGHGOFML_ = "";

		// Token: 0x04001AF0 RID: 6896
		public const int EventTrackingOpenFieldNumber = 1866;

		// Token: 0x04001AF1 RID: 6897
		private bool eventTrackingOpen_;

		// Token: 0x04001AF2 RID: 6898
		public const int ODOCFCJMBCLFieldNumber = 337;

		// Token: 0x04001AF3 RID: 6899
		private string oDOCFCJMBCL_ = "";

		// Token: 0x04001AF4 RID: 6900
		public const int NPIGPBEKEKOFieldNumber = 464;

		// Token: 0x04001AF5 RID: 6901
		private string nPIGPBEKEKO_ = "";

		// Token: 0x04001AF6 RID: 6902
		public const int IpFieldNumber = 5;

		// Token: 0x04001AF7 RID: 6903
		private string ip_ = "";

		// Token: 0x04001AF8 RID: 6904
		public const int RegionNameFieldNumber = 12;

		// Token: 0x04001AF9 RID: 6905
		private string regionName_ = "";

		// Token: 0x04001AFA RID: 6906
		public const int KDBAGALHEDCFieldNumber = 1122;

		// Token: 0x04001AFB RID: 6907
		private string kDBAGALHEDC_ = "";

		// Token: 0x04001AFC RID: 6908
		public const int CloseRedeemCodeFieldNumber = 62;

		// Token: 0x04001AFD RID: 6909
		private bool closeRedeemCode_;

		// Token: 0x04001AFE RID: 6910
		public const int RegionStopStartFieldNumber = 4;

		// Token: 0x04001AFF RID: 6911
		private long regionStopStart_;

		// Token: 0x04001B00 RID: 6912
		public const int UseTcpFieldNumber = 673;

		// Token: 0x04001B01 RID: 6913
		private bool useTcp_;

		// Token: 0x04001B02 RID: 6914
		public const int FDGFFCMALPIFieldNumber = 1134;

		// Token: 0x04001B03 RID: 6915
		private string fDGFFCMALPI_ = "";

		// Token: 0x04001B04 RID: 6916
		public const int ExResourceUrlFieldNumber = 1;

		// Token: 0x04001B05 RID: 6917
		private string exResourceUrl_ = "";

		// Token: 0x04001B06 RID: 6918
		public const int FHALNCIHMGAFieldNumber = 592;

		// Token: 0x04001B07 RID: 6919
		private string fHALNCIHMGA_ = "";

		// Token: 0x04001B08 RID: 6920
		public const int PlayerReturnQuestionnaireAUrlFieldNumber = 1893;

		// Token: 0x04001B09 RID: 6921
		private string playerReturnQuestionnaireAUrl_ = "";

		// Token: 0x04001B0A RID: 6922
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04001B0B RID: 6923
		private uint retcode_;

		// Token: 0x04001B0C RID: 6924
		public const int IPKLAMMKNNGFieldNumber = 117;

		// Token: 0x04001B0D RID: 6925
		private string iPKLAMMKNNG_ = "";

		// Token: 0x04001B0E RID: 6926
		public const int PlayerReturnInviteH5UrlFieldNumber = 1556;

		// Token: 0x04001B0F RID: 6927
		private string playerReturnInviteH5Url_ = "";

		// Token: 0x04001B10 RID: 6928
		public const int AsbReloginTypeFieldNumber = 13;

		// Token: 0x04001B11 RID: 6929
		private uint asbReloginType_;

		// Token: 0x04001B12 RID: 6930
		public const int CNAKLGMDLPEFieldNumber = 422;

		// Token: 0x04001B13 RID: 6931
		private bool cNAKLGMDLPE_;

		// Token: 0x04001B14 RID: 6932
		public const int LuaUrlFieldNumber = 3;

		// Token: 0x04001B15 RID: 6933
		private string luaUrl_ = "";

		// Token: 0x04001B16 RID: 6934
		public const int PreDownloadUrlFieldNumber = 365;

		// Token: 0x04001B17 RID: 6935
		private string preDownloadUrl_ = "";

		// Token: 0x04001B18 RID: 6936
		public const int ForbidRechargeFieldNumber = 1703;

		// Token: 0x04001B19 RID: 6937
		private bool forbidRecharge_;

		// Token: 0x04001B1A RID: 6938
		public const int EnableUploadBattleLogFieldNumber = 340;

		// Token: 0x04001B1B RID: 6939
		private bool enableUploadBattleLog_;

		// Token: 0x04001B1C RID: 6940
		public const int OnlineReplayDownloadUrlFieldNumber = 962;

		// Token: 0x04001B1D RID: 6941
		private string onlineReplayDownloadUrl_ = "";

		// Token: 0x04001B1E RID: 6942
		public const int NetworkDiagnosticFieldNumber = 1782;

		// Token: 0x04001B1F RID: 6943
		private bool networkDiagnostic_;

		// Token: 0x04001B20 RID: 6944
		public const int AssetBundleUrlFieldNumber = 9;

		// Token: 0x04001B21 RID: 6945
		private string assetBundleUrl_ = "";

		// Token: 0x04001B22 RID: 6946
		public const int BBFOAJGLLBCFieldNumber = 355;

		// Token: 0x04001B23 RID: 6947
		private string bBFOAJGLLBC_ = "";

		// Token: 0x04001B24 RID: 6948
		public const int OnlineReplayUploadUrlFieldNumber = 1307;

		// Token: 0x04001B25 RID: 6949
		private string onlineReplayUploadUrl_ = "";

		// Token: 0x04001B26 RID: 6950
		public const int GBONLDEMBENFieldNumber = 1588;

		// Token: 0x04001B27 RID: 6951
		private static readonly FieldCodec<string> _repeated_gBONLDEMBEN_codec = FieldCodec.ForString(12706U);

		// Token: 0x04001B28 RID: 6952
		private readonly RepeatedField<string> gBONLDEMBEN_ = new RepeatedField<string>();

		// Token: 0x04001B29 RID: 6953
		public const int PlayerReturnQuestionnaireBUrlFieldNumber = 1334;

		// Token: 0x04001B2A RID: 6954
		private string playerReturnQuestionnaireBUrl_ = "";

		// Token: 0x04001B2B RID: 6955
		public const int AsbReloginDescFieldNumber = 14;

		// Token: 0x04001B2C RID: 6956
		private string asbReloginDesc_ = "";

		// Token: 0x04001B2D RID: 6957
		public const int IosExamFieldNumber = 1575;

		// Token: 0x04001B2E RID: 6958
		private bool iosExam_;

		// Token: 0x04001B2F RID: 6959
		public const int KKHFKMIKFIBFieldNumber = 362;

		// Token: 0x04001B30 RID: 6960
		private string kKHFKMIKFIB_ = "";

		// Token: 0x04001B31 RID: 6961
		public const int MDKDJLNHGKNFieldNumber = 1624;

		// Token: 0x04001B32 RID: 6962
		private string mDKDJLNHGKN_ = "";

		// Token: 0x04001B33 RID: 6963
		public const int ELJIMGJLHBCFieldNumber = 1779;

		// Token: 0x04001B34 RID: 6964
		private string eLJIMGJLHBC_ = "";

		// Token: 0x04001B35 RID: 6965
		public const int RegionStopEndFieldNumber = 15;

		// Token: 0x04001B36 RID: 6966
		private long regionStopEnd_;

		// Token: 0x04001B37 RID: 6967
		public const int ServerDescriptionFieldNumber = 20;

		// Token: 0x04001B38 RID: 6968
		private string serverDescription_ = "";

		// Token: 0x04001B39 RID: 6969
		public const int DesignDataReloginTypeFieldNumber = 7;

		// Token: 0x04001B3A RID: 6970
		private uint designDataReloginType_;

		// Token: 0x04001B3B RID: 6971
		public const int PortFieldNumber = 11;

		// Token: 0x04001B3C RID: 6972
		private uint port_;
	}
}
