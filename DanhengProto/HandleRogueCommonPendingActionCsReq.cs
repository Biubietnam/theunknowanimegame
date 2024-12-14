using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200088D RID: 2189
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HandleRogueCommonPendingActionCsReq : IMessage<HandleRogueCommonPendingActionCsReq>, IMessage, IEquatable<HandleRogueCommonPendingActionCsReq>, IDeepCloneable<HandleRogueCommonPendingActionCsReq>, IBufferMessage
	{
		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x0600615E RID: 24926 RVA: 0x0010187F File Offset: 0x000FFA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HandleRogueCommonPendingActionCsReq> Parser
		{
			get
			{
				return HandleRogueCommonPendingActionCsReq._parser;
			}
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x0600615F RID: 24927 RVA: 0x00101886 File Offset: 0x000FFA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HandleRogueCommonPendingActionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06006160 RID: 24928 RVA: 0x00101898 File Offset: 0x000FFA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandleRogueCommonPendingActionCsReq.Descriptor;
			}
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x0010189F File Offset: 0x000FFA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleRogueCommonPendingActionCsReq()
		{
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x001018A8 File Offset: 0x000FFAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleRogueCommonPendingActionCsReq(HandleRogueCommonPendingActionCsReq other) : this()
		{
			this.queueLocation_ = other.queueLocation_;
			HandleRogueCommonPendingActionCsReq.ActionOneofCase actionCase = other.ActionCase;
			if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.DOGGLNJPPOF)
			{
				if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.ScepterSelectResult)
				{
					if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.AEGJEPMOIGF)
					{
						if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.MagicUnitSelectResult)
						{
							if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.NBHANEIENMG)
							{
								if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.AEGJEPMOIGF)
								{
									this.AEGJEPMOIGF = other.AEGJEPMOIGF.Clone();
								}
							}
							else
							{
								this.NBHANEIENMG = other.NBHANEIENMG.Clone();
							}
						}
						else
						{
							this.MagicUnitSelectResult = other.MagicUnitSelectResult.Clone();
						}
					}
					else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.MKAMHMNHJGC)
					{
						if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.CDIJGFLFDHA)
						{
							if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MKAMHMNHJGC)
							{
								this.MKAMHMNHJGC = other.MKAMHMNHJGC.Clone();
							}
						}
						else
						{
							this.CDIJGFLFDHA = other.CDIJGFLFDHA.Clone();
						}
					}
					else if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.CENOHDHPJKN)
					{
						if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.ScepterSelectResult)
						{
							this.ScepterSelectResult = other.ScepterSelectResult.Clone();
						}
					}
					else
					{
						this.CENOHDHPJKN = other.CENOHDHPJKN.Clone();
					}
				}
				else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.BonusSelectResult)
				{
					if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.HHPIEEFAJGM)
					{
						if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffSelectResult)
						{
							if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BonusSelectResult)
							{
								this.BonusSelectResult = other.BonusSelectResult.Clone();
							}
						}
						else
						{
							this.BuffSelectResult = other.BuffSelectResult.Clone();
						}
					}
					else
					{
						this.HHPIEEFAJGM = other.HHPIEEFAJGM.Clone();
					}
				}
				else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.KLMFACOCJLI)
				{
					if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffReforgeSelectResult)
					{
						if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.KLMFACOCJLI)
						{
							this.KLMFACOCJLI = other.KLMFACOCJLI.Clone();
						}
					}
					else
					{
						this.BuffReforgeSelectResult = other.BuffReforgeSelectResult.Clone();
					}
				}
				else if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BFAJANPJCJD)
				{
					if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DOGGLNJPPOF)
					{
						this.DOGGLNJPPOF = other.DOGGLNJPPOF.Clone();
					}
				}
				else
				{
					this.BFAJANPJCJD = other.BFAJANPJCJD.Clone();
				}
			}
			else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.IBNMCEPKGDB)
			{
				if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.RogueTournFormulaResult)
				{
					if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.JLNECBLCJIP)
					{
						if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BMJAJGEAGKK)
						{
							if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.RogueTournFormulaResult)
							{
								this.RogueTournFormulaResult = other.RogueTournFormulaResult.Clone();
							}
						}
						else
						{
							this.BMJAJGEAGKK = other.BMJAJGEAGKK.Clone();
						}
					}
					else
					{
						this.JLNECBLCJIP = other.JLNECBLCJIP.Clone();
					}
				}
				else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.HexAvatarSelectResult)
				{
					if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.KNBHJLNPBKG)
					{
						if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HexAvatarSelectResult)
						{
							this.HexAvatarSelectResult = other.HexAvatarSelectResult.Clone();
						}
					}
					else
					{
						this.KNBHJLNPBKG = other.KNBHJLNPBKG.Clone();
					}
				}
				else if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.FOEJLBGIHKD)
				{
					if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.IBNMCEPKGDB)
					{
						this.IBNMCEPKGDB = other.IBNMCEPKGDB.Clone();
					}
				}
				else
				{
					this.FOEJLBGIHKD = other.FOEJLBGIHKD.Clone();
				}
			}
			else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.HLIOMNNOPGC)
			{
				if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.MiracleSelectResult)
				{
					if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.DALFHAFMBDB)
					{
						if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MiracleSelectResult)
						{
							this.MiracleSelectResult = other.MiracleSelectResult.Clone();
						}
					}
					else
					{
						this.DALFHAFMBDB = other.DALFHAFMBDB.Clone();
					}
				}
				else if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffRerollSelectResult)
				{
					if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HLIOMNNOPGC)
					{
						this.HLIOMNNOPGC = other.HLIOMNNOPGC.Clone();
					}
				}
				else
				{
					this.BuffRerollSelectResult = other.BuffRerollSelectResult.Clone();
				}
			}
			else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.DCMBKMNHOLN)
			{
				if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.ReforgeMiracleSelectResult)
				{
					if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DCMBKMNHOLN)
					{
						this.DCMBKMNHOLN = other.DCMBKMNHOLN.Clone();
					}
				}
				else
				{
					this.ReforgeMiracleSelectResult = other.ReforgeMiracleSelectResult.Clone();
				}
			}
			else if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.HCOLFMIHNKO)
			{
				if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.GIGDIBIFDCA)
				{
					this.GIGDIBIFDCA = other.GIGDIBIFDCA.Clone();
				}
			}
			else
			{
				this.HCOLFMIHNKO = other.HCOLFMIHNKO.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x00101D1D File Offset: 0x000FFF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleRogueCommonPendingActionCsReq Clone()
		{
			return new HandleRogueCommonPendingActionCsReq(this);
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06006164 RID: 24932 RVA: 0x00101D25 File Offset: 0x000FFF25
		// (set) Token: 0x06006165 RID: 24933 RVA: 0x00101D2D File Offset: 0x000FFF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint QueueLocation
		{
			get
			{
				return this.queueLocation_;
			}
			set
			{
				this.queueLocation_ = value;
			}
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06006166 RID: 24934 RVA: 0x00101D36 File Offset: 0x000FFF36
		// (set) Token: 0x06006167 RID: 24935 RVA: 0x00101D52 File Offset: 0x000FFF52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffSelectResult BuffSelectResult
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffSelectResult)
				{
					return null;
				}
				return (RogueBuffSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffSelectResult);
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06006168 RID: 24936 RVA: 0x00101D6C File Offset: 0x000FFF6C
		// (set) Token: 0x06006169 RID: 24937 RVA: 0x00101D88 File Offset: 0x000FFF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HACELJDPNIG FOEJLBGIHKD
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.FOEJLBGIHKD)
				{
					return null;
				}
				return (HACELJDPNIG)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.FOEJLBGIHKD);
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x0600616A RID: 24938 RVA: 0x00101DA2 File Offset: 0x000FFFA2
		// (set) Token: 0x0600616B RID: 24939 RVA: 0x00101DBE File Offset: 0x000FFFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFFJMFGNHKO KLMFACOCJLI
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.KLMFACOCJLI)
				{
					return null;
				}
				return (NFFJMFGNHKO)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.KLMFACOCJLI);
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x0600616C RID: 24940 RVA: 0x00101DD8 File Offset: 0x000FFFD8
		// (set) Token: 0x0600616D RID: 24941 RVA: 0x00101DF4 File Offset: 0x000FFFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffRerollResult BuffRerollSelectResult
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffRerollSelectResult)
				{
					return null;
				}
				return (RogueBuffRerollResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffRerollSelectResult);
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x0600616E RID: 24942 RVA: 0x00101E0E File Offset: 0x0010000E
		// (set) Token: 0x0600616F RID: 24943 RVA: 0x00101E2A File Offset: 0x0010002A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffReforgeSelectResult BuffReforgeSelectResult
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffReforgeSelectResult)
				{
					return null;
				}
				return (RogueBuffReforgeSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffReforgeSelectResult);
			}
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06006170 RID: 24944 RVA: 0x00101E44 File Offset: 0x00100044
		// (set) Token: 0x06006171 RID: 24945 RVA: 0x00101E60 File Offset: 0x00100060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectResult MiracleSelectResult
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.MiracleSelectResult)
				{
					return null;
				}
				return (RogueMiracleSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.MiracleSelectResult);
			}
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06006172 RID: 24946 RVA: 0x00101E7A File Offset: 0x0010007A
		// (set) Token: 0x06006173 RID: 24947 RVA: 0x00101E96 File Offset: 0x00100096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NBDOJHIJJGD CENOHDHPJKN
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.CENOHDHPJKN)
				{
					return null;
				}
				return (NBDOJHIJJGD)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.CENOHDHPJKN);
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06006174 RID: 24948 RVA: 0x00101EB0 File Offset: 0x001000B0
		// (set) Token: 0x06006175 RID: 24949 RVA: 0x00101EC9 File Offset: 0x001000C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CGDINMIJHLB AEGJEPMOIGF
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.AEGJEPMOIGF)
				{
					return null;
				}
				return (CGDINMIJHLB)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.AEGJEPMOIGF);
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06006176 RID: 24950 RVA: 0x00101EE0 File Offset: 0x001000E0
		// (set) Token: 0x06006177 RID: 24951 RVA: 0x00101EFC File Offset: 0x001000FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDNMMBOGLDI BMJAJGEAGKK
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BMJAJGEAGKK)
				{
					return null;
				}
				return (GDNMMBOGLDI)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.BMJAJGEAGKK);
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06006178 RID: 24952 RVA: 0x00101F16 File Offset: 0x00100116
		// (set) Token: 0x06006179 RID: 24953 RVA: 0x00101F32 File Offset: 0x00100132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMOILLMGHBO DOGGLNJPPOF
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.DOGGLNJPPOF)
				{
					return null;
				}
				return (LMOILLMGHBO)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.DOGGLNJPPOF);
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x0600617A RID: 24954 RVA: 0x00101F4C File Offset: 0x0010014C
		// (set) Token: 0x0600617B RID: 24955 RVA: 0x00101F65 File Offset: 0x00100165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IGKDCOEOPMD NBHANEIENMG
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.NBHANEIENMG)
				{
					return null;
				}
				return (IGKDCOEOPMD)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.NBHANEIENMG);
			}
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x0600617C RID: 24956 RVA: 0x00101F7C File Offset: 0x0010017C
		// (set) Token: 0x0600617D RID: 24957 RVA: 0x00101F98 File Offset: 0x00100198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectResult HexAvatarSelectResult
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.HexAvatarSelectResult)
				{
					return null;
				}
				return (RogueHexAvatarSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.HexAvatarSelectResult);
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x0600617E RID: 24958 RVA: 0x00101FB2 File Offset: 0x001001B2
		// (set) Token: 0x0600617F RID: 24959 RVA: 0x00101FCE File Offset: 0x001001CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectResult BonusSelectResult
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BonusSelectResult)
				{
					return null;
				}
				return (RogueBonusSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.BonusSelectResult);
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06006180 RID: 24960 RVA: 0x00101FE8 File Offset: 0x001001E8
		// (set) Token: 0x06006181 RID: 24961 RVA: 0x00102004 File Offset: 0x00100204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaResult RogueTournFormulaResult
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.RogueTournFormulaResult)
				{
					return null;
				}
				return (RogueTournFormulaResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.RogueTournFormulaResult);
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06006182 RID: 24962 RVA: 0x0010201E File Offset: 0x0010021E
		// (set) Token: 0x06006183 RID: 24963 RVA: 0x0010203A File Offset: 0x0010023A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACGOBKGIGIC MKAMHMNHJGC
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.MKAMHMNHJGC)
				{
					return null;
				}
				return (ACGOBKGIGIC)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.MKAMHMNHJGC);
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06006184 RID: 24964 RVA: 0x00102054 File Offset: 0x00100254
		// (set) Token: 0x06006185 RID: 24965 RVA: 0x00102070 File Offset: 0x00100270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BMJJCBINGBK HHPIEEFAJGM
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.HHPIEEFAJGM)
				{
					return null;
				}
				return (BMJJCBINGBK)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.HHPIEEFAJGM);
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06006186 RID: 24966 RVA: 0x0010208A File Offset: 0x0010028A
		// (set) Token: 0x06006187 RID: 24967 RVA: 0x001020A6 File Offset: 0x001002A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectResult ReforgeMiracleSelectResult
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.ReforgeMiracleSelectResult)
				{
					return null;
				}
				return (RogueReforgeFormulaSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.ReforgeMiracleSelectResult);
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06006188 RID: 24968 RVA: 0x001020C0 File Offset: 0x001002C0
		// (set) Token: 0x06006189 RID: 24969 RVA: 0x001020D9 File Offset: 0x001002D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectResult MagicUnitSelectResult
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.MagicUnitSelectResult)
				{
					return null;
				}
				return (RogueMagicUnitSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.MagicUnitSelectResult);
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x0600618A RID: 24970 RVA: 0x001020F0 File Offset: 0x001002F0
		// (set) Token: 0x0600618B RID: 24971 RVA: 0x0010210C File Offset: 0x0010030C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectResult ScepterSelectResult
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.ScepterSelectResult)
				{
					return null;
				}
				return (RogueMagicScepterSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.ScepterSelectResult);
			}
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x0600618C RID: 24972 RVA: 0x00102126 File Offset: 0x00100326
		// (set) Token: 0x0600618D RID: 24973 RVA: 0x00102142 File Offset: 0x00100342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIAFEAMDFOE BFAJANPJCJD
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BFAJANPJCJD)
				{
					return null;
				}
				return (KIAFEAMDFOE)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.BFAJANPJCJD);
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x0600618E RID: 24974 RVA: 0x0010215C File Offset: 0x0010035C
		// (set) Token: 0x0600618F RID: 24975 RVA: 0x00102178 File Offset: 0x00100378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectResult DCMBKMNHOLN
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.DCMBKMNHOLN)
				{
					return null;
				}
				return (RogueMagicUnitSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.DCMBKMNHOLN);
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06006190 RID: 24976 RVA: 0x00102192 File Offset: 0x00100392
		// (set) Token: 0x06006191 RID: 24977 RVA: 0x001021AE File Offset: 0x001003AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectResult IBNMCEPKGDB
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.IBNMCEPKGDB)
				{
					return null;
				}
				return (RogueMagicUnitSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.IBNMCEPKGDB);
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06006192 RID: 24978 RVA: 0x001021C8 File Offset: 0x001003C8
		// (set) Token: 0x06006193 RID: 24979 RVA: 0x001021E4 File Offset: 0x001003E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectResult CDIJGFLFDHA
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.CDIJGFLFDHA)
				{
					return null;
				}
				return (RogueMagicUnitSelectResult)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.CDIJGFLFDHA);
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06006194 RID: 24980 RVA: 0x001021FE File Offset: 0x001003FE
		// (set) Token: 0x06006195 RID: 24981 RVA: 0x0010221A File Offset: 0x0010041A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KDIEOAKOFOP JLNECBLCJIP
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.JLNECBLCJIP)
				{
					return null;
				}
				return (KDIEOAKOFOP)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.JLNECBLCJIP);
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06006196 RID: 24982 RVA: 0x00102234 File Offset: 0x00100434
		// (set) Token: 0x06006197 RID: 24983 RVA: 0x00102250 File Offset: 0x00100450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KDIEOAKOFOP KNBHJLNPBKG
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.KNBHJLNPBKG)
				{
					return null;
				}
				return (KDIEOAKOFOP)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.KNBHJLNPBKG);
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06006198 RID: 24984 RVA: 0x0010226A File Offset: 0x0010046A
		// (set) Token: 0x06006199 RID: 24985 RVA: 0x00102286 File Offset: 0x00100486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KDIEOAKOFOP HLIOMNNOPGC
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.HLIOMNNOPGC)
				{
					return null;
				}
				return (KDIEOAKOFOP)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.HLIOMNNOPGC);
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x0600619A RID: 24986 RVA: 0x001022A0 File Offset: 0x001004A0
		// (set) Token: 0x0600619B RID: 24987 RVA: 0x001022BC File Offset: 0x001004BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KMGAOPBLBDE DALFHAFMBDB
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.DALFHAFMBDB)
				{
					return null;
				}
				return (KMGAOPBLBDE)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.DALFHAFMBDB);
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x0600619C RID: 24988 RVA: 0x001022D6 File Offset: 0x001004D6
		// (set) Token: 0x0600619D RID: 24989 RVA: 0x001022F2 File Offset: 0x001004F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HJHFNELKEOI HCOLFMIHNKO
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.HCOLFMIHNKO)
				{
					return null;
				}
				return (HJHFNELKEOI)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.HCOLFMIHNKO);
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x0600619E RID: 24990 RVA: 0x0010230C File Offset: 0x0010050C
		// (set) Token: 0x0600619F RID: 24991 RVA: 0x00102328 File Offset: 0x00100528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPHCAAAEOMO GIGDIBIFDCA
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionCsReq.ActionOneofCase.GIGDIBIFDCA)
				{
					return null;
				}
				return (HPHCAAAEOMO)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionCsReq.ActionOneofCase.None : HandleRogueCommonPendingActionCsReq.ActionOneofCase.GIGDIBIFDCA);
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x060061A0 RID: 24992 RVA: 0x00102342 File Offset: 0x00100542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleRogueCommonPendingActionCsReq.ActionOneofCase ActionCase
		{
			get
			{
				return this.actionCase_;
			}
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x0010234A File Offset: 0x0010054A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAction()
		{
			this.actionCase_ = HandleRogueCommonPendingActionCsReq.ActionOneofCase.None;
			this.action_ = null;
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x0010235A File Offset: 0x0010055A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandleRogueCommonPendingActionCsReq);
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x00102368 File Offset: 0x00100568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandleRogueCommonPendingActionCsReq other)
		{
			return other != null && (other == this || (this.QueueLocation == other.QueueLocation && object.Equals(this.BuffSelectResult, other.BuffSelectResult) && object.Equals(this.FOEJLBGIHKD, other.FOEJLBGIHKD) && object.Equals(this.KLMFACOCJLI, other.KLMFACOCJLI) && object.Equals(this.BuffRerollSelectResult, other.BuffRerollSelectResult) && object.Equals(this.BuffReforgeSelectResult, other.BuffReforgeSelectResult) && object.Equals(this.MiracleSelectResult, other.MiracleSelectResult) && object.Equals(this.CENOHDHPJKN, other.CENOHDHPJKN) && object.Equals(this.AEGJEPMOIGF, other.AEGJEPMOIGF) && object.Equals(this.BMJAJGEAGKK, other.BMJAJGEAGKK) && object.Equals(this.DOGGLNJPPOF, other.DOGGLNJPPOF) && object.Equals(this.NBHANEIENMG, other.NBHANEIENMG) && object.Equals(this.HexAvatarSelectResult, other.HexAvatarSelectResult) && object.Equals(this.BonusSelectResult, other.BonusSelectResult) && object.Equals(this.RogueTournFormulaResult, other.RogueTournFormulaResult) && object.Equals(this.MKAMHMNHJGC, other.MKAMHMNHJGC) && object.Equals(this.HHPIEEFAJGM, other.HHPIEEFAJGM) && object.Equals(this.ReforgeMiracleSelectResult, other.ReforgeMiracleSelectResult) && object.Equals(this.MagicUnitSelectResult, other.MagicUnitSelectResult) && object.Equals(this.ScepterSelectResult, other.ScepterSelectResult) && object.Equals(this.BFAJANPJCJD, other.BFAJANPJCJD) && object.Equals(this.DCMBKMNHOLN, other.DCMBKMNHOLN) && object.Equals(this.IBNMCEPKGDB, other.IBNMCEPKGDB) && object.Equals(this.CDIJGFLFDHA, other.CDIJGFLFDHA) && object.Equals(this.JLNECBLCJIP, other.JLNECBLCJIP) && object.Equals(this.KNBHJLNPBKG, other.KNBHJLNPBKG) && object.Equals(this.HLIOMNNOPGC, other.HLIOMNNOPGC) && object.Equals(this.DALFHAFMBDB, other.DALFHAFMBDB) && object.Equals(this.HCOLFMIHNKO, other.HCOLFMIHNKO) && object.Equals(this.GIGDIBIFDCA, other.GIGDIBIFDCA) && this.ActionCase == other.ActionCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x00102614 File Offset: 0x00100814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QueueLocation != 0U)
			{
				num ^= this.QueueLocation.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffSelectResult)
			{
				num ^= this.BuffSelectResult.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.FOEJLBGIHKD)
			{
				num ^= this.FOEJLBGIHKD.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.KLMFACOCJLI)
			{
				num ^= this.KLMFACOCJLI.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffRerollSelectResult)
			{
				num ^= this.BuffRerollSelectResult.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffReforgeSelectResult)
			{
				num ^= this.BuffReforgeSelectResult.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MiracleSelectResult)
			{
				num ^= this.MiracleSelectResult.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.CENOHDHPJKN)
			{
				num ^= this.CENOHDHPJKN.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.AEGJEPMOIGF)
			{
				num ^= this.AEGJEPMOIGF.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BMJAJGEAGKK)
			{
				num ^= this.BMJAJGEAGKK.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DOGGLNJPPOF)
			{
				num ^= this.DOGGLNJPPOF.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.NBHANEIENMG)
			{
				num ^= this.NBHANEIENMG.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HexAvatarSelectResult)
			{
				num ^= this.HexAvatarSelectResult.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BonusSelectResult)
			{
				num ^= this.BonusSelectResult.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.RogueTournFormulaResult)
			{
				num ^= this.RogueTournFormulaResult.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MKAMHMNHJGC)
			{
				num ^= this.MKAMHMNHJGC.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HHPIEEFAJGM)
			{
				num ^= this.HHPIEEFAJGM.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.ReforgeMiracleSelectResult)
			{
				num ^= this.ReforgeMiracleSelectResult.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MagicUnitSelectResult)
			{
				num ^= this.MagicUnitSelectResult.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.ScepterSelectResult)
			{
				num ^= this.ScepterSelectResult.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BFAJANPJCJD)
			{
				num ^= this.BFAJANPJCJD.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DCMBKMNHOLN)
			{
				num ^= this.DCMBKMNHOLN.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.IBNMCEPKGDB)
			{
				num ^= this.IBNMCEPKGDB.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.CDIJGFLFDHA)
			{
				num ^= this.CDIJGFLFDHA.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.JLNECBLCJIP)
			{
				num ^= this.JLNECBLCJIP.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.KNBHJLNPBKG)
			{
				num ^= this.KNBHJLNPBKG.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HLIOMNNOPGC)
			{
				num ^= this.HLIOMNNOPGC.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DALFHAFMBDB)
			{
				num ^= this.DALFHAFMBDB.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HCOLFMIHNKO)
			{
				num ^= this.HCOLFMIHNKO.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.GIGDIBIFDCA)
			{
				num ^= this.GIGDIBIFDCA.GetHashCode();
			}
			num ^= (int)this.actionCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x00102962 File Offset: 0x00100B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x0010296A File Offset: 0x00100B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x00102974 File Offset: 0x00100B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QueueLocation != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.QueueLocation);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MagicUnitSelectResult)
			{
				output.WriteRawTag(146, 2);
				output.WriteMessage(this.MagicUnitSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.NBHANEIENMG)
			{
				output.WriteRawTag(130, 4);
				output.WriteMessage(this.NBHANEIENMG);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.AEGJEPMOIGF)
			{
				output.WriteRawTag(138, 5);
				output.WriteMessage(this.AEGJEPMOIGF);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.CDIJGFLFDHA)
			{
				output.WriteRawTag(186, 15);
				output.WriteMessage(this.CDIJGFLFDHA);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MKAMHMNHJGC)
			{
				output.WriteRawTag(226, 17);
				output.WriteMessage(this.MKAMHMNHJGC);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.CENOHDHPJKN)
			{
				output.WriteRawTag(250, 17);
				output.WriteMessage(this.CENOHDHPJKN);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.ScepterSelectResult)
			{
				output.WriteRawTag(154, 28);
				output.WriteMessage(this.ScepterSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HHPIEEFAJGM)
			{
				output.WriteRawTag(154, 32);
				output.WriteMessage(this.HHPIEEFAJGM);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffSelectResult)
			{
				output.WriteRawTag(242, 38);
				output.WriteMessage(this.BuffSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BonusSelectResult)
			{
				output.WriteRawTag(194, 39);
				output.WriteMessage(this.BonusSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffReforgeSelectResult)
			{
				output.WriteRawTag(162, 43);
				output.WriteMessage(this.BuffReforgeSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.KLMFACOCJLI)
			{
				output.WriteRawTag(170, 48);
				output.WriteMessage(this.KLMFACOCJLI);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BFAJANPJCJD)
			{
				output.WriteRawTag(178, 54);
				output.WriteMessage(this.BFAJANPJCJD);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DOGGLNJPPOF)
			{
				output.WriteRawTag(130, 59);
				output.WriteMessage(this.DOGGLNJPPOF);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.JLNECBLCJIP)
			{
				output.WriteRawTag(210, 60);
				output.WriteMessage(this.JLNECBLCJIP);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BMJAJGEAGKK)
			{
				output.WriteRawTag(154, 61);
				output.WriteMessage(this.BMJAJGEAGKK);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.RogueTournFormulaResult)
			{
				output.WriteRawTag(178, 64);
				output.WriteMessage(this.RogueTournFormulaResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.KNBHJLNPBKG)
			{
				output.WriteRawTag(234, 69);
				output.WriteMessage(this.KNBHJLNPBKG);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HexAvatarSelectResult)
			{
				output.WriteRawTag(186, 70);
				output.WriteMessage(this.HexAvatarSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.FOEJLBGIHKD)
			{
				output.WriteRawTag(146, 72);
				output.WriteMessage(this.FOEJLBGIHKD);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.IBNMCEPKGDB)
			{
				output.WriteRawTag(138, 78);
				output.WriteMessage(this.IBNMCEPKGDB);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DALFHAFMBDB)
			{
				output.WriteRawTag(234, 80);
				output.WriteMessage(this.DALFHAFMBDB);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MiracleSelectResult)
			{
				output.WriteRawTag(202, 88);
				output.WriteMessage(this.MiracleSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffRerollSelectResult)
			{
				output.WriteRawTag(154, 92);
				output.WriteMessage(this.BuffRerollSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HLIOMNNOPGC)
			{
				output.WriteRawTag(178, 92);
				output.WriteMessage(this.HLIOMNNOPGC);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.ReforgeMiracleSelectResult)
			{
				output.WriteRawTag(218, 109);
				output.WriteMessage(this.ReforgeMiracleSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DCMBKMNHOLN)
			{
				output.WriteRawTag(146, 122);
				output.WriteMessage(this.DCMBKMNHOLN);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HCOLFMIHNKO)
			{
				output.WriteRawTag(130, 205, 109);
				output.WriteMessage(this.HCOLFMIHNKO);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.GIGDIBIFDCA)
			{
				output.WriteRawTag(202, 133, 111);
				output.WriteMessage(this.GIGDIBIFDCA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x00102E00 File Offset: 0x00101000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QueueLocation != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QueueLocation);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffSelectResult)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.FOEJLBGIHKD)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FOEJLBGIHKD);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.KLMFACOCJLI)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KLMFACOCJLI);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffRerollSelectResult)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffRerollSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffReforgeSelectResult)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffReforgeSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MiracleSelectResult)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MiracleSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.CENOHDHPJKN)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CENOHDHPJKN);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.AEGJEPMOIGF)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AEGJEPMOIGF);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BMJAJGEAGKK)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BMJAJGEAGKK);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DOGGLNJPPOF)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DOGGLNJPPOF);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.NBHANEIENMG)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NBHANEIENMG);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HexAvatarSelectResult)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HexAvatarSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BonusSelectResult)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BonusSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.RogueTournFormulaResult)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueTournFormulaResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MKAMHMNHJGC)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MKAMHMNHJGC);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HHPIEEFAJGM)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HHPIEEFAJGM);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.ReforgeMiracleSelectResult)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ReforgeMiracleSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MagicUnitSelectResult)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MagicUnitSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.ScepterSelectResult)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ScepterSelectResult);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BFAJANPJCJD)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BFAJANPJCJD);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DCMBKMNHOLN)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DCMBKMNHOLN);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.IBNMCEPKGDB)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.IBNMCEPKGDB);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.CDIJGFLFDHA)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CDIJGFLFDHA);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.JLNECBLCJIP)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.JLNECBLCJIP);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.KNBHJLNPBKG)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KNBHJLNPBKG);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HLIOMNNOPGC)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HLIOMNNOPGC);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DALFHAFMBDB)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DALFHAFMBDB);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HCOLFMIHNKO)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.HCOLFMIHNKO);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.GIGDIBIFDCA)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.GIGDIBIFDCA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x00103180 File Offset: 0x00101380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandleRogueCommonPendingActionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QueueLocation != 0U)
			{
				this.QueueLocation = other.QueueLocation;
			}
			HandleRogueCommonPendingActionCsReq.ActionOneofCase actionCase = other.ActionCase;
			if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.DOGGLNJPPOF)
			{
				if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.ScepterSelectResult)
				{
					if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.AEGJEPMOIGF)
					{
						if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.MagicUnitSelectResult)
						{
							if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.NBHANEIENMG)
							{
								if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.AEGJEPMOIGF)
								{
									if (this.AEGJEPMOIGF == null)
									{
										this.AEGJEPMOIGF = new CGDINMIJHLB();
									}
									this.AEGJEPMOIGF.MergeFrom(other.AEGJEPMOIGF);
								}
							}
							else
							{
								if (this.NBHANEIENMG == null)
								{
									this.NBHANEIENMG = new IGKDCOEOPMD();
								}
								this.NBHANEIENMG.MergeFrom(other.NBHANEIENMG);
							}
						}
						else
						{
							if (this.MagicUnitSelectResult == null)
							{
								this.MagicUnitSelectResult = new RogueMagicUnitSelectResult();
							}
							this.MagicUnitSelectResult.MergeFrom(other.MagicUnitSelectResult);
						}
					}
					else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.MKAMHMNHJGC)
					{
						if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.CDIJGFLFDHA)
						{
							if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MKAMHMNHJGC)
							{
								if (this.MKAMHMNHJGC == null)
								{
									this.MKAMHMNHJGC = new ACGOBKGIGIC();
								}
								this.MKAMHMNHJGC.MergeFrom(other.MKAMHMNHJGC);
							}
						}
						else
						{
							if (this.CDIJGFLFDHA == null)
							{
								this.CDIJGFLFDHA = new RogueMagicUnitSelectResult();
							}
							this.CDIJGFLFDHA.MergeFrom(other.CDIJGFLFDHA);
						}
					}
					else if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.CENOHDHPJKN)
					{
						if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.ScepterSelectResult)
						{
							if (this.ScepterSelectResult == null)
							{
								this.ScepterSelectResult = new RogueMagicScepterSelectResult();
							}
							this.ScepterSelectResult.MergeFrom(other.ScepterSelectResult);
						}
					}
					else
					{
						if (this.CENOHDHPJKN == null)
						{
							this.CENOHDHPJKN = new NBDOJHIJJGD();
						}
						this.CENOHDHPJKN.MergeFrom(other.CENOHDHPJKN);
					}
				}
				else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.BonusSelectResult)
				{
					if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.HHPIEEFAJGM)
					{
						if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffSelectResult)
						{
							if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BonusSelectResult)
							{
								if (this.BonusSelectResult == null)
								{
									this.BonusSelectResult = new RogueBonusSelectResult();
								}
								this.BonusSelectResult.MergeFrom(other.BonusSelectResult);
							}
						}
						else
						{
							if (this.BuffSelectResult == null)
							{
								this.BuffSelectResult = new RogueBuffSelectResult();
							}
							this.BuffSelectResult.MergeFrom(other.BuffSelectResult);
						}
					}
					else
					{
						if (this.HHPIEEFAJGM == null)
						{
							this.HHPIEEFAJGM = new BMJJCBINGBK();
						}
						this.HHPIEEFAJGM.MergeFrom(other.HHPIEEFAJGM);
					}
				}
				else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.KLMFACOCJLI)
				{
					if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffReforgeSelectResult)
					{
						if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.KLMFACOCJLI)
						{
							if (this.KLMFACOCJLI == null)
							{
								this.KLMFACOCJLI = new NFFJMFGNHKO();
							}
							this.KLMFACOCJLI.MergeFrom(other.KLMFACOCJLI);
						}
					}
					else
					{
						if (this.BuffReforgeSelectResult == null)
						{
							this.BuffReforgeSelectResult = new RogueBuffReforgeSelectResult();
						}
						this.BuffReforgeSelectResult.MergeFrom(other.BuffReforgeSelectResult);
					}
				}
				else if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BFAJANPJCJD)
				{
					if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DOGGLNJPPOF)
					{
						if (this.DOGGLNJPPOF == null)
						{
							this.DOGGLNJPPOF = new LMOILLMGHBO();
						}
						this.DOGGLNJPPOF.MergeFrom(other.DOGGLNJPPOF);
					}
				}
				else
				{
					if (this.BFAJANPJCJD == null)
					{
						this.BFAJANPJCJD = new KIAFEAMDFOE();
					}
					this.BFAJANPJCJD.MergeFrom(other.BFAJANPJCJD);
				}
			}
			else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.IBNMCEPKGDB)
			{
				if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.RogueTournFormulaResult)
				{
					if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.JLNECBLCJIP)
					{
						if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BMJAJGEAGKK)
						{
							if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.RogueTournFormulaResult)
							{
								if (this.RogueTournFormulaResult == null)
								{
									this.RogueTournFormulaResult = new RogueTournFormulaResult();
								}
								this.RogueTournFormulaResult.MergeFrom(other.RogueTournFormulaResult);
							}
						}
						else
						{
							if (this.BMJAJGEAGKK == null)
							{
								this.BMJAJGEAGKK = new GDNMMBOGLDI();
							}
							this.BMJAJGEAGKK.MergeFrom(other.BMJAJGEAGKK);
						}
					}
					else
					{
						if (this.JLNECBLCJIP == null)
						{
							this.JLNECBLCJIP = new KDIEOAKOFOP();
						}
						this.JLNECBLCJIP.MergeFrom(other.JLNECBLCJIP);
					}
				}
				else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.HexAvatarSelectResult)
				{
					if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.KNBHJLNPBKG)
					{
						if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HexAvatarSelectResult)
						{
							if (this.HexAvatarSelectResult == null)
							{
								this.HexAvatarSelectResult = new RogueHexAvatarSelectResult();
							}
							this.HexAvatarSelectResult.MergeFrom(other.HexAvatarSelectResult);
						}
					}
					else
					{
						if (this.KNBHJLNPBKG == null)
						{
							this.KNBHJLNPBKG = new KDIEOAKOFOP();
						}
						this.KNBHJLNPBKG.MergeFrom(other.KNBHJLNPBKG);
					}
				}
				else if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.FOEJLBGIHKD)
				{
					if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.IBNMCEPKGDB)
					{
						if (this.IBNMCEPKGDB == null)
						{
							this.IBNMCEPKGDB = new RogueMagicUnitSelectResult();
						}
						this.IBNMCEPKGDB.MergeFrom(other.IBNMCEPKGDB);
					}
				}
				else
				{
					if (this.FOEJLBGIHKD == null)
					{
						this.FOEJLBGIHKD = new HACELJDPNIG();
					}
					this.FOEJLBGIHKD.MergeFrom(other.FOEJLBGIHKD);
				}
			}
			else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.HLIOMNNOPGC)
			{
				if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.MiracleSelectResult)
				{
					if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.DALFHAFMBDB)
					{
						if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MiracleSelectResult)
						{
							if (this.MiracleSelectResult == null)
							{
								this.MiracleSelectResult = new RogueMiracleSelectResult();
							}
							this.MiracleSelectResult.MergeFrom(other.MiracleSelectResult);
						}
					}
					else
					{
						if (this.DALFHAFMBDB == null)
						{
							this.DALFHAFMBDB = new KMGAOPBLBDE();
						}
						this.DALFHAFMBDB.MergeFrom(other.DALFHAFMBDB);
					}
				}
				else if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffRerollSelectResult)
				{
					if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HLIOMNNOPGC)
					{
						if (this.HLIOMNNOPGC == null)
						{
							this.HLIOMNNOPGC = new KDIEOAKOFOP();
						}
						this.HLIOMNNOPGC.MergeFrom(other.HLIOMNNOPGC);
					}
				}
				else
				{
					if (this.BuffRerollSelectResult == null)
					{
						this.BuffRerollSelectResult = new RogueBuffRerollResult();
					}
					this.BuffRerollSelectResult.MergeFrom(other.BuffRerollSelectResult);
				}
			}
			else if (actionCase <= HandleRogueCommonPendingActionCsReq.ActionOneofCase.DCMBKMNHOLN)
			{
				if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.ReforgeMiracleSelectResult)
				{
					if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DCMBKMNHOLN)
					{
						if (this.DCMBKMNHOLN == null)
						{
							this.DCMBKMNHOLN = new RogueMagicUnitSelectResult();
						}
						this.DCMBKMNHOLN.MergeFrom(other.DCMBKMNHOLN);
					}
				}
				else
				{
					if (this.ReforgeMiracleSelectResult == null)
					{
						this.ReforgeMiracleSelectResult = new RogueReforgeFormulaSelectResult();
					}
					this.ReforgeMiracleSelectResult.MergeFrom(other.ReforgeMiracleSelectResult);
				}
			}
			else if (actionCase != HandleRogueCommonPendingActionCsReq.ActionOneofCase.HCOLFMIHNKO)
			{
				if (actionCase == HandleRogueCommonPendingActionCsReq.ActionOneofCase.GIGDIBIFDCA)
				{
					if (this.GIGDIBIFDCA == null)
					{
						this.GIGDIBIFDCA = new HPHCAAAEOMO();
					}
					this.GIGDIBIFDCA.MergeFrom(other.GIGDIBIFDCA);
				}
			}
			else
			{
				if (this.HCOLFMIHNKO == null)
				{
					this.HCOLFMIHNKO = new HJHFNELKEOI();
				}
				this.HCOLFMIHNKO.MergeFrom(other.HCOLFMIHNKO);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x00103831 File Offset: 0x00101A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x0010383C File Offset: 0x00101A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 7554U)
				{
					if (num <= 2298U)
					{
						if (num <= 514U)
						{
							if (num == 64U)
							{
								this.QueueLocation = input.ReadUInt32();
								continue;
							}
							if (num == 274U)
							{
								RogueMagicUnitSelectResult rogueMagicUnitSelectResult = new RogueMagicUnitSelectResult();
								if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MagicUnitSelectResult)
								{
									rogueMagicUnitSelectResult.MergeFrom(this.MagicUnitSelectResult);
								}
								input.ReadMessage(rogueMagicUnitSelectResult);
								this.MagicUnitSelectResult = rogueMagicUnitSelectResult;
								continue;
							}
							if (num == 514U)
							{
								IGKDCOEOPMD igkdcoeopmd = new IGKDCOEOPMD();
								if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.NBHANEIENMG)
								{
									igkdcoeopmd.MergeFrom(this.NBHANEIENMG);
								}
								input.ReadMessage(igkdcoeopmd);
								this.NBHANEIENMG = igkdcoeopmd;
								continue;
							}
						}
						else if (num <= 1978U)
						{
							if (num == 650U)
							{
								CGDINMIJHLB cgdinmijhlb = new CGDINMIJHLB();
								if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.AEGJEPMOIGF)
								{
									cgdinmijhlb.MergeFrom(this.AEGJEPMOIGF);
								}
								input.ReadMessage(cgdinmijhlb);
								this.AEGJEPMOIGF = cgdinmijhlb;
								continue;
							}
							if (num == 1978U)
							{
								RogueMagicUnitSelectResult rogueMagicUnitSelectResult2 = new RogueMagicUnitSelectResult();
								if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.CDIJGFLFDHA)
								{
									rogueMagicUnitSelectResult2.MergeFrom(this.CDIJGFLFDHA);
								}
								input.ReadMessage(rogueMagicUnitSelectResult2);
								this.CDIJGFLFDHA = rogueMagicUnitSelectResult2;
								continue;
							}
						}
						else
						{
							if (num == 2274U)
							{
								ACGOBKGIGIC acgobkgigic = new ACGOBKGIGIC();
								if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MKAMHMNHJGC)
								{
									acgobkgigic.MergeFrom(this.MKAMHMNHJGC);
								}
								input.ReadMessage(acgobkgigic);
								this.MKAMHMNHJGC = acgobkgigic;
								continue;
							}
							if (num == 2298U)
							{
								NBDOJHIJJGD nbdojhijjgd = new NBDOJHIJJGD();
								if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.CENOHDHPJKN)
								{
									nbdojhijjgd.MergeFrom(this.CENOHDHPJKN);
								}
								input.ReadMessage(nbdojhijjgd);
								this.CENOHDHPJKN = nbdojhijjgd;
								continue;
							}
						}
					}
					else if (num <= 5058U)
					{
						if (num <= 4122U)
						{
							if (num == 3610U)
							{
								RogueMagicScepterSelectResult rogueMagicScepterSelectResult = new RogueMagicScepterSelectResult();
								if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.ScepterSelectResult)
								{
									rogueMagicScepterSelectResult.MergeFrom(this.ScepterSelectResult);
								}
								input.ReadMessage(rogueMagicScepterSelectResult);
								this.ScepterSelectResult = rogueMagicScepterSelectResult;
								continue;
							}
							if (num == 4122U)
							{
								BMJJCBINGBK bmjjcbingbk = new BMJJCBINGBK();
								if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HHPIEEFAJGM)
								{
									bmjjcbingbk.MergeFrom(this.HHPIEEFAJGM);
								}
								input.ReadMessage(bmjjcbingbk);
								this.HHPIEEFAJGM = bmjjcbingbk;
								continue;
							}
						}
						else
						{
							if (num == 4978U)
							{
								RogueBuffSelectResult rogueBuffSelectResult = new RogueBuffSelectResult();
								if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffSelectResult)
								{
									rogueBuffSelectResult.MergeFrom(this.BuffSelectResult);
								}
								input.ReadMessage(rogueBuffSelectResult);
								this.BuffSelectResult = rogueBuffSelectResult;
								continue;
							}
							if (num == 5058U)
							{
								RogueBonusSelectResult rogueBonusSelectResult = new RogueBonusSelectResult();
								if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BonusSelectResult)
								{
									rogueBonusSelectResult.MergeFrom(this.BonusSelectResult);
								}
								input.ReadMessage(rogueBonusSelectResult);
								this.BonusSelectResult = rogueBonusSelectResult;
								continue;
							}
						}
					}
					else if (num <= 6186U)
					{
						if (num == 5538U)
						{
							RogueBuffReforgeSelectResult rogueBuffReforgeSelectResult = new RogueBuffReforgeSelectResult();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffReforgeSelectResult)
							{
								rogueBuffReforgeSelectResult.MergeFrom(this.BuffReforgeSelectResult);
							}
							input.ReadMessage(rogueBuffReforgeSelectResult);
							this.BuffReforgeSelectResult = rogueBuffReforgeSelectResult;
							continue;
						}
						if (num == 6186U)
						{
							NFFJMFGNHKO nffjmfgnhko = new NFFJMFGNHKO();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.KLMFACOCJLI)
							{
								nffjmfgnhko.MergeFrom(this.KLMFACOCJLI);
							}
							input.ReadMessage(nffjmfgnhko);
							this.KLMFACOCJLI = nffjmfgnhko;
							continue;
						}
					}
					else
					{
						if (num == 6962U)
						{
							KIAFEAMDFOE kiafeamdfoe = new KIAFEAMDFOE();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BFAJANPJCJD)
							{
								kiafeamdfoe.MergeFrom(this.BFAJANPJCJD);
							}
							input.ReadMessage(kiafeamdfoe);
							this.BFAJANPJCJD = kiafeamdfoe;
							continue;
						}
						if (num == 7554U)
						{
							LMOILLMGHBO lmoillmghbo = new LMOILLMGHBO();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DOGGLNJPPOF)
							{
								lmoillmghbo.MergeFrom(this.DOGGLNJPPOF);
							}
							input.ReadMessage(lmoillmghbo);
							this.DOGGLNJPPOF = lmoillmghbo;
							continue;
						}
					}
				}
				else if (num <= 9994U)
				{
					if (num <= 8242U)
					{
						if (num == 7762U)
						{
							KDIEOAKOFOP kdieoakofop = new KDIEOAKOFOP();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.JLNECBLCJIP)
							{
								kdieoakofop.MergeFrom(this.JLNECBLCJIP);
							}
							input.ReadMessage(kdieoakofop);
							this.JLNECBLCJIP = kdieoakofop;
							continue;
						}
						if (num == 7834U)
						{
							GDNMMBOGLDI gdnmmbogldi = new GDNMMBOGLDI();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BMJAJGEAGKK)
							{
								gdnmmbogldi.MergeFrom(this.BMJAJGEAGKK);
							}
							input.ReadMessage(gdnmmbogldi);
							this.BMJAJGEAGKK = gdnmmbogldi;
							continue;
						}
						if (num == 8242U)
						{
							RogueTournFormulaResult rogueTournFormulaResult = new RogueTournFormulaResult();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.RogueTournFormulaResult)
							{
								rogueTournFormulaResult.MergeFrom(this.RogueTournFormulaResult);
							}
							input.ReadMessage(rogueTournFormulaResult);
							this.RogueTournFormulaResult = rogueTournFormulaResult;
							continue;
						}
					}
					else if (num <= 9018U)
					{
						if (num == 8938U)
						{
							KDIEOAKOFOP kdieoakofop2 = new KDIEOAKOFOP();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.KNBHJLNPBKG)
							{
								kdieoakofop2.MergeFrom(this.KNBHJLNPBKG);
							}
							input.ReadMessage(kdieoakofop2);
							this.KNBHJLNPBKG = kdieoakofop2;
							continue;
						}
						if (num == 9018U)
						{
							RogueHexAvatarSelectResult rogueHexAvatarSelectResult = new RogueHexAvatarSelectResult();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HexAvatarSelectResult)
							{
								rogueHexAvatarSelectResult.MergeFrom(this.HexAvatarSelectResult);
							}
							input.ReadMessage(rogueHexAvatarSelectResult);
							this.HexAvatarSelectResult = rogueHexAvatarSelectResult;
							continue;
						}
					}
					else
					{
						if (num == 9234U)
						{
							HACELJDPNIG haceljdpnig = new HACELJDPNIG();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.FOEJLBGIHKD)
							{
								haceljdpnig.MergeFrom(this.FOEJLBGIHKD);
							}
							input.ReadMessage(haceljdpnig);
							this.FOEJLBGIHKD = haceljdpnig;
							continue;
						}
						if (num == 9994U)
						{
							RogueMagicUnitSelectResult rogueMagicUnitSelectResult3 = new RogueMagicUnitSelectResult();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.IBNMCEPKGDB)
							{
								rogueMagicUnitSelectResult3.MergeFrom(this.IBNMCEPKGDB);
							}
							input.ReadMessage(rogueMagicUnitSelectResult3);
							this.IBNMCEPKGDB = rogueMagicUnitSelectResult3;
							continue;
						}
					}
				}
				else if (num <= 11826U)
				{
					if (num <= 11338U)
					{
						if (num == 10346U)
						{
							KMGAOPBLBDE kmgaopblbde = new KMGAOPBLBDE();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DALFHAFMBDB)
							{
								kmgaopblbde.MergeFrom(this.DALFHAFMBDB);
							}
							input.ReadMessage(kmgaopblbde);
							this.DALFHAFMBDB = kmgaopblbde;
							continue;
						}
						if (num == 11338U)
						{
							RogueMiracleSelectResult rogueMiracleSelectResult = new RogueMiracleSelectResult();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.MiracleSelectResult)
							{
								rogueMiracleSelectResult.MergeFrom(this.MiracleSelectResult);
							}
							input.ReadMessage(rogueMiracleSelectResult);
							this.MiracleSelectResult = rogueMiracleSelectResult;
							continue;
						}
					}
					else
					{
						if (num == 11802U)
						{
							RogueBuffRerollResult rogueBuffRerollResult = new RogueBuffRerollResult();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.BuffRerollSelectResult)
							{
								rogueBuffRerollResult.MergeFrom(this.BuffRerollSelectResult);
							}
							input.ReadMessage(rogueBuffRerollResult);
							this.BuffRerollSelectResult = rogueBuffRerollResult;
							continue;
						}
						if (num == 11826U)
						{
							KDIEOAKOFOP kdieoakofop3 = new KDIEOAKOFOP();
							if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HLIOMNNOPGC)
							{
								kdieoakofop3.MergeFrom(this.HLIOMNNOPGC);
							}
							input.ReadMessage(kdieoakofop3);
							this.HLIOMNNOPGC = kdieoakofop3;
							continue;
						}
					}
				}
				else if (num <= 15634U)
				{
					if (num == 14042U)
					{
						RogueReforgeFormulaSelectResult rogueReforgeFormulaSelectResult = new RogueReforgeFormulaSelectResult();
						if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.ReforgeMiracleSelectResult)
						{
							rogueReforgeFormulaSelectResult.MergeFrom(this.ReforgeMiracleSelectResult);
						}
						input.ReadMessage(rogueReforgeFormulaSelectResult);
						this.ReforgeMiracleSelectResult = rogueReforgeFormulaSelectResult;
						continue;
					}
					if (num == 15634U)
					{
						RogueMagicUnitSelectResult rogueMagicUnitSelectResult4 = new RogueMagicUnitSelectResult();
						if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.DCMBKMNHOLN)
						{
							rogueMagicUnitSelectResult4.MergeFrom(this.DCMBKMNHOLN);
						}
						input.ReadMessage(rogueMagicUnitSelectResult4);
						this.DCMBKMNHOLN = rogueMagicUnitSelectResult4;
						continue;
					}
				}
				else
				{
					if (num == 1795714U)
					{
						HJHFNELKEOI hjhfnelkeoi = new HJHFNELKEOI();
						if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.HCOLFMIHNKO)
						{
							hjhfnelkeoi.MergeFrom(this.HCOLFMIHNKO);
						}
						input.ReadMessage(hjhfnelkeoi);
						this.HCOLFMIHNKO = hjhfnelkeoi;
						continue;
					}
					if (num == 1819338U)
					{
						HPHCAAAEOMO hphcaaaeomo = new HPHCAAAEOMO();
						if (this.actionCase_ == HandleRogueCommonPendingActionCsReq.ActionOneofCase.GIGDIBIFDCA)
						{
							hphcaaaeomo.MergeFrom(this.GIGDIBIFDCA);
						}
						input.ReadMessage(hphcaaaeomo);
						this.GIGDIBIFDCA = hphcaaaeomo;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002566 RID: 9574
		private static readonly MessageParser<HandleRogueCommonPendingActionCsReq> _parser = new MessageParser<HandleRogueCommonPendingActionCsReq>(() => new HandleRogueCommonPendingActionCsReq());

		// Token: 0x04002567 RID: 9575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002568 RID: 9576
		public const int QueueLocationFieldNumber = 8;

		// Token: 0x04002569 RID: 9577
		private uint queueLocation_;

		// Token: 0x0400256A RID: 9578
		public const int BuffSelectResultFieldNumber = 622;

		// Token: 0x0400256B RID: 9579
		public const int FOEJLBGIHKDFieldNumber = 1154;

		// Token: 0x0400256C RID: 9580
		public const int KLMFACOCJLIFieldNumber = 773;

		// Token: 0x0400256D RID: 9581
		public const int BuffRerollSelectResultFieldNumber = 1475;

		// Token: 0x0400256E RID: 9582
		public const int BuffReforgeSelectResultFieldNumber = 692;

		// Token: 0x0400256F RID: 9583
		public const int MiracleSelectResultFieldNumber = 1417;

		// Token: 0x04002570 RID: 9584
		public const int CENOHDHPJKNFieldNumber = 287;

		// Token: 0x04002571 RID: 9585
		public const int AEGJEPMOIGFFieldNumber = 81;

		// Token: 0x04002572 RID: 9586
		public const int BMJAJGEAGKKFieldNumber = 979;

		// Token: 0x04002573 RID: 9587
		public const int DOGGLNJPPOFFieldNumber = 944;

		// Token: 0x04002574 RID: 9588
		public const int NBHANEIENMGFieldNumber = 64;

		// Token: 0x04002575 RID: 9589
		public const int HexAvatarSelectResultFieldNumber = 1127;

		// Token: 0x04002576 RID: 9590
		public const int BonusSelectResultFieldNumber = 632;

		// Token: 0x04002577 RID: 9591
		public const int RogueTournFormulaResultFieldNumber = 1030;

		// Token: 0x04002578 RID: 9592
		public const int MKAMHMNHJGCFieldNumber = 284;

		// Token: 0x04002579 RID: 9593
		public const int HHPIEEFAJGMFieldNumber = 515;

		// Token: 0x0400257A RID: 9594
		public const int ReforgeMiracleSelectResultFieldNumber = 1755;

		// Token: 0x0400257B RID: 9595
		public const int MagicUnitSelectResultFieldNumber = 34;

		// Token: 0x0400257C RID: 9596
		public const int ScepterSelectResultFieldNumber = 451;

		// Token: 0x0400257D RID: 9597
		public const int BFAJANPJCJDFieldNumber = 870;

		// Token: 0x0400257E RID: 9598
		public const int DCMBKMNHOLNFieldNumber = 1954;

		// Token: 0x0400257F RID: 9599
		public const int IBNMCEPKGDBFieldNumber = 1249;

		// Token: 0x04002580 RID: 9600
		public const int CDIJGFLFDHAFieldNumber = 247;

		// Token: 0x04002581 RID: 9601
		public const int JLNECBLCJIPFieldNumber = 970;

		// Token: 0x04002582 RID: 9602
		public const int KNBHJLNPBKGFieldNumber = 1117;

		// Token: 0x04002583 RID: 9603
		public const int HLIOMNNOPGCFieldNumber = 1478;

		// Token: 0x04002584 RID: 9604
		public const int DALFHAFMBDBFieldNumber = 1293;

		// Token: 0x04002585 RID: 9605
		public const int HCOLFMIHNKOFieldNumber = 224464;

		// Token: 0x04002586 RID: 9606
		public const int GIGDIBIFDCAFieldNumber = 227417;

		// Token: 0x04002587 RID: 9607
		private object action_;

		// Token: 0x04002588 RID: 9608
		private HandleRogueCommonPendingActionCsReq.ActionOneofCase actionCase_;

		// Token: 0x0200185B RID: 6235
		public enum ActionOneofCase
		{
			// Token: 0x04006015 RID: 24597
			None,
			// Token: 0x04006016 RID: 24598
			BuffSelectResult = 622,
			// Token: 0x04006017 RID: 24599
			FOEJLBGIHKD = 1154,
			// Token: 0x04006018 RID: 24600
			KLMFACOCJLI = 773,
			// Token: 0x04006019 RID: 24601
			BuffRerollSelectResult = 1475,
			// Token: 0x0400601A RID: 24602
			BuffReforgeSelectResult = 692,
			// Token: 0x0400601B RID: 24603
			MiracleSelectResult = 1417,
			// Token: 0x0400601C RID: 24604
			CENOHDHPJKN = 287,
			// Token: 0x0400601D RID: 24605
			AEGJEPMOIGF = 81,
			// Token: 0x0400601E RID: 24606
			BMJAJGEAGKK = 979,
			// Token: 0x0400601F RID: 24607
			DOGGLNJPPOF = 944,
			// Token: 0x04006020 RID: 24608
			NBHANEIENMG = 64,
			// Token: 0x04006021 RID: 24609
			HexAvatarSelectResult = 1127,
			// Token: 0x04006022 RID: 24610
			BonusSelectResult = 632,
			// Token: 0x04006023 RID: 24611
			RogueTournFormulaResult = 1030,
			// Token: 0x04006024 RID: 24612
			MKAMHMNHJGC = 284,
			// Token: 0x04006025 RID: 24613
			HHPIEEFAJGM = 515,
			// Token: 0x04006026 RID: 24614
			ReforgeMiracleSelectResult = 1755,
			// Token: 0x04006027 RID: 24615
			MagicUnitSelectResult = 34,
			// Token: 0x04006028 RID: 24616
			ScepterSelectResult = 451,
			// Token: 0x04006029 RID: 24617
			BFAJANPJCJD = 870,
			// Token: 0x0400602A RID: 24618
			DCMBKMNHOLN = 1954,
			// Token: 0x0400602B RID: 24619
			IBNMCEPKGDB = 1249,
			// Token: 0x0400602C RID: 24620
			CDIJGFLFDHA = 247,
			// Token: 0x0400602D RID: 24621
			JLNECBLCJIP = 970,
			// Token: 0x0400602E RID: 24622
			KNBHJLNPBKG = 1117,
			// Token: 0x0400602F RID: 24623
			HLIOMNNOPGC = 1478,
			// Token: 0x04006030 RID: 24624
			DALFHAFMBDB = 1293,
			// Token: 0x04006031 RID: 24625
			HCOLFMIHNKO = 224464,
			// Token: 0x04006032 RID: 24626
			GIGDIBIFDCA = 227417
		}
	}
}
