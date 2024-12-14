using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200088F RID: 2191
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HandleRogueCommonPendingActionScRsp : IMessage<HandleRogueCommonPendingActionScRsp>, IMessage, IEquatable<HandleRogueCommonPendingActionScRsp>, IDeepCloneable<HandleRogueCommonPendingActionScRsp>, IBufferMessage
	{
		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x060061AF RID: 25007 RVA: 0x0010443C File Offset: 0x0010263C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HandleRogueCommonPendingActionScRsp> Parser
		{
			get
			{
				return HandleRogueCommonPendingActionScRsp._parser;
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x060061B0 RID: 25008 RVA: 0x00104443 File Offset: 0x00102643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HandleRogueCommonPendingActionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x060061B1 RID: 25009 RVA: 0x00104455 File Offset: 0x00102655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandleRogueCommonPendingActionScRsp.Descriptor;
			}
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x0010445C File Offset: 0x0010265C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleRogueCommonPendingActionScRsp()
		{
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x00104464 File Offset: 0x00102664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleRogueCommonPendingActionScRsp(HandleRogueCommonPendingActionScRsp other) : this()
		{
			this.queuePosition_ = other.queuePosition_;
			this.queueLocation_ = other.queueLocation_;
			this.retcode_ = other.retcode_;
			HandleRogueCommonPendingActionScRsp.ActionOneofCase actionCase = other.ActionCase;
			if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.KOAGLGFNBOA)
			{
				if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.ScepterSelectCallback)
				{
					if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.GAFOPMBKBOA)
					{
						if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffSelectCallback)
						{
							if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.ReforgeMiracleSelectCallback)
							{
								if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GAFOPMBKBOA)
								{
									this.GAFOPMBKBOA = other.GAFOPMBKBOA.Clone();
								}
							}
							else
							{
								this.ReforgeMiracleSelectCallback = other.ReforgeMiracleSelectCallback.Clone();
							}
						}
						else
						{
							this.BuffSelectCallback = other.BuffSelectCallback.Clone();
						}
					}
					else if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.HexAvatarSelectCallback)
					{
						if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.FMADNIJOPHB)
						{
							if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ScepterSelectCallback)
							{
								this.ScepterSelectCallback = other.ScepterSelectCallback.Clone();
							}
						}
						else
						{
							this.FMADNIJOPHB = other.FMADNIJOPHB.Clone();
						}
					}
					else
					{
						this.HexAvatarSelectCallback = other.HexAvatarSelectCallback.Clone();
					}
				}
				else if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.EJENNEPAHDI)
				{
					if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.CBMKJHHLAMH)
					{
						if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.GHOIPBKDEEJ)
						{
							if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.EJENNEPAHDI)
							{
								this.EJENNEPAHDI = other.EJENNEPAHDI.Clone();
							}
						}
						else
						{
							this.GHOIPBKDEEJ = other.GHOIPBKDEEJ.Clone();
						}
					}
					else
					{
						this.CBMKJHHLAMH = other.CBMKJHHLAMH.Clone();
					}
				}
				else if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.GPLEFKFBPGF)
				{
					if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.JICIPLJDNAL)
					{
						if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KOAGLGFNBOA)
						{
							this.KOAGLGFNBOA = other.KOAGLGFNBOA.Clone();
						}
					}
					else
					{
						this.JICIPLJDNAL = other.JICIPLJDNAL.Clone();
					}
				}
				else
				{
					this.GPLEFKFBPGF = other.GPLEFKFBPGF.Clone();
				}
			}
			else if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.ECKIGPOCGCA)
			{
				if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.FGJFGKKDMJO)
				{
					if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.MiracleSelectCallback)
					{
						if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BonusSelectCallback)
						{
							if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.FGJFGKKDMJO)
							{
								this.FGJFGKKDMJO = other.FGJFGKKDMJO.Clone();
							}
						}
						else
						{
							this.BonusSelectCallback = other.BonusSelectCallback.Clone();
						}
					}
					else
					{
						this.MiracleSelectCallback = other.MiracleSelectCallback.Clone();
					}
				}
				else if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.MagicUnitSelectCallback)
				{
					if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffRerollCallback)
					{
						if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ECKIGPOCGCA)
						{
							this.ECKIGPOCGCA = other.ECKIGPOCGCA.Clone();
						}
					}
					else
					{
						this.BuffRerollCallback = other.BuffRerollCallback.Clone();
					}
				}
				else
				{
					this.MagicUnitSelectCallback = other.MagicUnitSelectCallback.Clone();
				}
			}
			else if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.RogueTournFormulaCallback)
			{
				if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffReforgeSelectCallback)
				{
					if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.KBEAJGOPPDH)
					{
						if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.RogueTournFormulaCallback)
						{
							this.RogueTournFormulaCallback = other.RogueTournFormulaCallback.Clone();
						}
					}
					else
					{
						this.KBEAJGOPPDH = other.KBEAJGOPPDH.Clone();
					}
				}
				else
				{
					this.BuffReforgeSelectCallback = other.BuffReforgeSelectCallback.Clone();
				}
			}
			else if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.GMKLEHMJIII)
			{
				if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.AFBIIHAFLOA)
				{
					if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KODMIGGOJKO)
					{
						this.KODMIGGOJKO = other.KODMIGGOJKO.Clone();
					}
				}
				else
				{
					this.AFBIIHAFLOA = other.AFBIIHAFLOA.Clone();
				}
			}
			else
			{
				this.GMKLEHMJIII = other.GMKLEHMJIII.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x00104814 File Offset: 0x00102A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleRogueCommonPendingActionScRsp Clone()
		{
			return new HandleRogueCommonPendingActionScRsp(this);
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x060061B5 RID: 25013 RVA: 0x0010481C File Offset: 0x00102A1C
		// (set) Token: 0x060061B6 RID: 25014 RVA: 0x00104824 File Offset: 0x00102A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint QueuePosition
		{
			get
			{
				return this.queuePosition_;
			}
			set
			{
				this.queuePosition_ = value;
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x060061B7 RID: 25015 RVA: 0x0010482D File Offset: 0x00102A2D
		// (set) Token: 0x060061B8 RID: 25016 RVA: 0x00104835 File Offset: 0x00102A35
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

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x060061B9 RID: 25017 RVA: 0x0010483E File Offset: 0x00102A3E
		// (set) Token: 0x060061BA RID: 25018 RVA: 0x00104846 File Offset: 0x00102A46
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

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x060061BB RID: 25019 RVA: 0x0010484F File Offset: 0x00102A4F
		// (set) Token: 0x060061BC RID: 25020 RVA: 0x00104868 File Offset: 0x00102A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffSelectCallback BuffSelectCallback
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffSelectCallback)
				{
					return null;
				}
				return (RogueBuffSelectCallback)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffSelectCallback);
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x060061BD RID: 25021 RVA: 0x0010487F File Offset: 0x00102A7F
		// (set) Token: 0x060061BE RID: 25022 RVA: 0x0010489B File Offset: 0x00102A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIANHJOCBOO KOAGLGFNBOA
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.KOAGLGFNBOA)
				{
					return null;
				}
				return (FIANHJOCBOO)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.KOAGLGFNBOA);
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x060061BF RID: 25023 RVA: 0x001048B5 File Offset: 0x00102AB5
		// (set) Token: 0x060061C0 RID: 25024 RVA: 0x001048D1 File Offset: 0x00102AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HKIPEMDOMMD JICIPLJDNAL
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.JICIPLJDNAL)
				{
					return null;
				}
				return (HKIPEMDOMMD)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.JICIPLJDNAL);
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x060061C1 RID: 25025 RVA: 0x001048EB File Offset: 0x00102AEB
		// (set) Token: 0x060061C2 RID: 25026 RVA: 0x00104907 File Offset: 0x00102B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffRerollCallback BuffRerollCallback
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffRerollCallback)
				{
					return null;
				}
				return (RogueBuffRerollCallback)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffRerollCallback);
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x060061C3 RID: 25027 RVA: 0x00104921 File Offset: 0x00102B21
		// (set) Token: 0x060061C4 RID: 25028 RVA: 0x0010493D File Offset: 0x00102B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffReforgeSelectCallback BuffReforgeSelectCallback
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffReforgeSelectCallback)
				{
					return null;
				}
				return (RogueBuffReforgeSelectCallback)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffReforgeSelectCallback);
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x060061C5 RID: 25029 RVA: 0x00104957 File Offset: 0x00102B57
		// (set) Token: 0x060061C6 RID: 25030 RVA: 0x00104973 File Offset: 0x00102B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectCallback MiracleSelectCallback
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.MiracleSelectCallback)
				{
					return null;
				}
				return (RogueMiracleSelectCallback)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.MiracleSelectCallback);
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x060061C7 RID: 25031 RVA: 0x0010498D File Offset: 0x00102B8D
		// (set) Token: 0x060061C8 RID: 25032 RVA: 0x001049A9 File Offset: 0x00102BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EPGECECNMGI AFBIIHAFLOA
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.AFBIIHAFLOA)
				{
					return null;
				}
				return (EPGECECNMGI)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.AFBIIHAFLOA);
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x060061C9 RID: 25033 RVA: 0x001049C3 File Offset: 0x00102BC3
		// (set) Token: 0x060061CA RID: 25034 RVA: 0x001049DF File Offset: 0x00102BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public INJNELLMNAC ECKIGPOCGCA
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.ECKIGPOCGCA)
				{
					return null;
				}
				return (INJNELLMNAC)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.ECKIGPOCGCA);
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x060061CB RID: 25035 RVA: 0x001049F9 File Offset: 0x00102BF9
		// (set) Token: 0x060061CC RID: 25036 RVA: 0x00104A15 File Offset: 0x00102C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMADCCJOCCP KODMIGGOJKO
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.KODMIGGOJKO)
				{
					return null;
				}
				return (LMADCCJOCCP)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.KODMIGGOJKO);
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x060061CD RID: 25037 RVA: 0x00104A2F File Offset: 0x00102C2F
		// (set) Token: 0x060061CE RID: 25038 RVA: 0x00104A4B File Offset: 0x00102C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIOBNBAINGF GAFOPMBKBOA
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.GAFOPMBKBOA)
				{
					return null;
				}
				return (OIOBNBAINGF)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.GAFOPMBKBOA);
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x060061CF RID: 25039 RVA: 0x00104A65 File Offset: 0x00102C65
		// (set) Token: 0x060061D0 RID: 25040 RVA: 0x00104A81 File Offset: 0x00102C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MMENILLOPPJ FMADNIJOPHB
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.FMADNIJOPHB)
				{
					return null;
				}
				return (MMENILLOPPJ)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.FMADNIJOPHB);
			}
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x060061D1 RID: 25041 RVA: 0x00104A9B File Offset: 0x00102C9B
		// (set) Token: 0x060061D2 RID: 25042 RVA: 0x00104AB7 File Offset: 0x00102CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectCallback HexAvatarSelectCallback
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.HexAvatarSelectCallback)
				{
					return null;
				}
				return (RogueHexAvatarSelectCallback)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.HexAvatarSelectCallback);
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x060061D3 RID: 25043 RVA: 0x00104AD1 File Offset: 0x00102CD1
		// (set) Token: 0x060061D4 RID: 25044 RVA: 0x00104AED File Offset: 0x00102CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectCallback BonusSelectCallback
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BonusSelectCallback)
				{
					return null;
				}
				return (RogueBonusSelectCallback)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.BonusSelectCallback);
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x060061D5 RID: 25045 RVA: 0x00104B07 File Offset: 0x00102D07
		// (set) Token: 0x060061D6 RID: 25046 RVA: 0x00104B23 File Offset: 0x00102D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaCallback RogueTournFormulaCallback
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.RogueTournFormulaCallback)
				{
					return null;
				}
				return (RogueTournFormulaCallback)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.RogueTournFormulaCallback);
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x060061D7 RID: 25047 RVA: 0x00104B3D File Offset: 0x00102D3D
		// (set) Token: 0x060061D8 RID: 25048 RVA: 0x00104B59 File Offset: 0x00102D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFNOJBILKBG FGJFGKKDMJO
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.FGJFGKKDMJO)
				{
					return null;
				}
				return (CFNOJBILKBG)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.FGJFGKKDMJO);
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x060061D9 RID: 25049 RVA: 0x00104B73 File Offset: 0x00102D73
		// (set) Token: 0x060061DA RID: 25050 RVA: 0x00104B8F File Offset: 0x00102D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ECHPHBKEOLG EJENNEPAHDI
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.EJENNEPAHDI)
				{
					return null;
				}
				return (ECHPHBKEOLG)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.EJENNEPAHDI);
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x00104BA9 File Offset: 0x00102DA9
		// (set) Token: 0x060061DC RID: 25052 RVA: 0x00104BC5 File Offset: 0x00102DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectCallback ReforgeMiracleSelectCallback
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.ReforgeMiracleSelectCallback)
				{
					return null;
				}
				return (RogueReforgeFormulaSelectCallback)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.ReforgeMiracleSelectCallback);
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x060061DD RID: 25053 RVA: 0x00104BDF File Offset: 0x00102DDF
		// (set) Token: 0x060061DE RID: 25054 RVA: 0x00104BFB File Offset: 0x00102DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectCallback MagicUnitSelectCallback
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.MagicUnitSelectCallback)
				{
					return null;
				}
				return (RogueMagicUnitSelectCallback)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.MagicUnitSelectCallback);
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x060061DF RID: 25055 RVA: 0x00104C15 File Offset: 0x00102E15
		// (set) Token: 0x060061E0 RID: 25056 RVA: 0x00104C31 File Offset: 0x00102E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectCallback ScepterSelectCallback
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.ScepterSelectCallback)
				{
					return null;
				}
				return (RogueMagicScepterSelectCallback)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.ScepterSelectCallback);
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x060061E1 RID: 25057 RVA: 0x00104C4B File Offset: 0x00102E4B
		// (set) Token: 0x060061E2 RID: 25058 RVA: 0x00104C67 File Offset: 0x00102E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDBPJBLHAGN GPLEFKFBPGF
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.GPLEFKFBPGF)
				{
					return null;
				}
				return (IDBPJBLHAGN)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.GPLEFKFBPGF);
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x060061E3 RID: 25059 RVA: 0x00104C81 File Offset: 0x00102E81
		// (set) Token: 0x060061E4 RID: 25060 RVA: 0x00104C9D File Offset: 0x00102E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PHMCINNBADG GMKLEHMJIII
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.GMKLEHMJIII)
				{
					return null;
				}
				return (PHMCINNBADG)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.GMKLEHMJIII);
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x060061E5 RID: 25061 RVA: 0x00104CB7 File Offset: 0x00102EB7
		// (set) Token: 0x060061E6 RID: 25062 RVA: 0x00104CD3 File Offset: 0x00102ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOEBPLEJBAK KBEAJGOPPDH
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.KBEAJGOPPDH)
				{
					return null;
				}
				return (GOEBPLEJBAK)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.KBEAJGOPPDH);
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x060061E7 RID: 25063 RVA: 0x00104CED File Offset: 0x00102EED
		// (set) Token: 0x060061E8 RID: 25064 RVA: 0x00104D09 File Offset: 0x00102F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGCOGFOKDFD CBMKJHHLAMH
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.CBMKJHHLAMH)
				{
					return null;
				}
				return (NGCOGFOKDFD)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.CBMKJHHLAMH);
			}
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x060061E9 RID: 25065 RVA: 0x00104D23 File Offset: 0x00102F23
		// (set) Token: 0x060061EA RID: 25066 RVA: 0x00104D3F File Offset: 0x00102F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMAMDMCFCLJ GHOIPBKDEEJ
		{
			get
			{
				if (this.actionCase_ != HandleRogueCommonPendingActionScRsp.ActionOneofCase.GHOIPBKDEEJ)
				{
					return null;
				}
				return (EMAMDMCFCLJ)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? HandleRogueCommonPendingActionScRsp.ActionOneofCase.None : HandleRogueCommonPendingActionScRsp.ActionOneofCase.GHOIPBKDEEJ);
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x060061EB RID: 25067 RVA: 0x00104D59 File Offset: 0x00102F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandleRogueCommonPendingActionScRsp.ActionOneofCase ActionCase
		{
			get
			{
				return this.actionCase_;
			}
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x00104D61 File Offset: 0x00102F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAction()
		{
			this.actionCase_ = HandleRogueCommonPendingActionScRsp.ActionOneofCase.None;
			this.action_ = null;
		}

		// Token: 0x060061ED RID: 25069 RVA: 0x00104D71 File Offset: 0x00102F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandleRogueCommonPendingActionScRsp);
		}

		// Token: 0x060061EE RID: 25070 RVA: 0x00104D80 File Offset: 0x00102F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandleRogueCommonPendingActionScRsp other)
		{
			return other != null && (other == this || (this.QueuePosition == other.QueuePosition && this.QueueLocation == other.QueueLocation && this.Retcode == other.Retcode && object.Equals(this.BuffSelectCallback, other.BuffSelectCallback) && object.Equals(this.KOAGLGFNBOA, other.KOAGLGFNBOA) && object.Equals(this.JICIPLJDNAL, other.JICIPLJDNAL) && object.Equals(this.BuffRerollCallback, other.BuffRerollCallback) && object.Equals(this.BuffReforgeSelectCallback, other.BuffReforgeSelectCallback) && object.Equals(this.MiracleSelectCallback, other.MiracleSelectCallback) && object.Equals(this.AFBIIHAFLOA, other.AFBIIHAFLOA) && object.Equals(this.ECKIGPOCGCA, other.ECKIGPOCGCA) && object.Equals(this.KODMIGGOJKO, other.KODMIGGOJKO) && object.Equals(this.GAFOPMBKBOA, other.GAFOPMBKBOA) && object.Equals(this.FMADNIJOPHB, other.FMADNIJOPHB) && object.Equals(this.HexAvatarSelectCallback, other.HexAvatarSelectCallback) && object.Equals(this.BonusSelectCallback, other.BonusSelectCallback) && object.Equals(this.RogueTournFormulaCallback, other.RogueTournFormulaCallback) && object.Equals(this.FGJFGKKDMJO, other.FGJFGKKDMJO) && object.Equals(this.EJENNEPAHDI, other.EJENNEPAHDI) && object.Equals(this.ReforgeMiracleSelectCallback, other.ReforgeMiracleSelectCallback) && object.Equals(this.MagicUnitSelectCallback, other.MagicUnitSelectCallback) && object.Equals(this.ScepterSelectCallback, other.ScepterSelectCallback) && object.Equals(this.GPLEFKFBPGF, other.GPLEFKFBPGF) && object.Equals(this.GMKLEHMJIII, other.GMKLEHMJIII) && object.Equals(this.KBEAJGOPPDH, other.KBEAJGOPPDH) && object.Equals(this.CBMKJHHLAMH, other.CBMKJHHLAMH) && object.Equals(this.GHOIPBKDEEJ, other.GHOIPBKDEEJ) && this.ActionCase == other.ActionCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x00104FE4 File Offset: 0x001031E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QueuePosition != 0U)
			{
				num ^= this.QueuePosition.GetHashCode();
			}
			if (this.QueueLocation != 0U)
			{
				num ^= this.QueueLocation.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffSelectCallback)
			{
				num ^= this.BuffSelectCallback.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KOAGLGFNBOA)
			{
				num ^= this.KOAGLGFNBOA.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.JICIPLJDNAL)
			{
				num ^= this.JICIPLJDNAL.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffRerollCallback)
			{
				num ^= this.BuffRerollCallback.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffReforgeSelectCallback)
			{
				num ^= this.BuffReforgeSelectCallback.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.MiracleSelectCallback)
			{
				num ^= this.MiracleSelectCallback.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.AFBIIHAFLOA)
			{
				num ^= this.AFBIIHAFLOA.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ECKIGPOCGCA)
			{
				num ^= this.ECKIGPOCGCA.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KODMIGGOJKO)
			{
				num ^= this.KODMIGGOJKO.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GAFOPMBKBOA)
			{
				num ^= this.GAFOPMBKBOA.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.FMADNIJOPHB)
			{
				num ^= this.FMADNIJOPHB.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.HexAvatarSelectCallback)
			{
				num ^= this.HexAvatarSelectCallback.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BonusSelectCallback)
			{
				num ^= this.BonusSelectCallback.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.RogueTournFormulaCallback)
			{
				num ^= this.RogueTournFormulaCallback.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.FGJFGKKDMJO)
			{
				num ^= this.FGJFGKKDMJO.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.EJENNEPAHDI)
			{
				num ^= this.EJENNEPAHDI.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ReforgeMiracleSelectCallback)
			{
				num ^= this.ReforgeMiracleSelectCallback.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.MagicUnitSelectCallback)
			{
				num ^= this.MagicUnitSelectCallback.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ScepterSelectCallback)
			{
				num ^= this.ScepterSelectCallback.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GPLEFKFBPGF)
			{
				num ^= this.GPLEFKFBPGF.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GMKLEHMJIII)
			{
				num ^= this.GMKLEHMJIII.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KBEAJGOPPDH)
			{
				num ^= this.KBEAJGOPPDH.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.CBMKJHHLAMH)
			{
				num ^= this.CBMKJHHLAMH.GetHashCode();
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GHOIPBKDEEJ)
			{
				num ^= this.GHOIPBKDEEJ.GetHashCode();
			}
			num ^= (int)this.actionCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x001052E3 File Offset: 0x001034E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060061F1 RID: 25073 RVA: 0x001052EB File Offset: 0x001034EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061F2 RID: 25074 RVA: 0x001052F4 File Offset: 0x001034F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QueuePosition != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.QueuePosition);
			}
			if (this.QueueLocation != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.QueueLocation);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffSelectCallback)
			{
				output.WriteRawTag(170, 4);
				output.WriteMessage(this.BuffSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ReforgeMiracleSelectCallback)
			{
				output.WriteRawTag(242, 18);
				output.WriteMessage(this.ReforgeMiracleSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GAFOPMBKBOA)
			{
				output.WriteRawTag(186, 21);
				output.WriteMessage(this.GAFOPMBKBOA);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.HexAvatarSelectCallback)
			{
				output.WriteRawTag(146, 30);
				output.WriteMessage(this.HexAvatarSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.FMADNIJOPHB)
			{
				output.WriteRawTag(234, 31);
				output.WriteMessage(this.FMADNIJOPHB);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ScepterSelectCallback)
			{
				output.WriteRawTag(242, 37);
				output.WriteMessage(this.ScepterSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.CBMKJHHLAMH)
			{
				output.WriteRawTag(130, 40);
				output.WriteMessage(this.CBMKJHHLAMH);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GHOIPBKDEEJ)
			{
				output.WriteRawTag(178, 45);
				output.WriteMessage(this.GHOIPBKDEEJ);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.EJENNEPAHDI)
			{
				output.WriteRawTag(130, 46);
				output.WriteMessage(this.EJENNEPAHDI);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GPLEFKFBPGF)
			{
				output.WriteRawTag(138, 64);
				output.WriteMessage(this.GPLEFKFBPGF);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.JICIPLJDNAL)
			{
				output.WriteRawTag(162, 64);
				output.WriteMessage(this.JICIPLJDNAL);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KOAGLGFNBOA)
			{
				output.WriteRawTag(234, 68);
				output.WriteMessage(this.KOAGLGFNBOA);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.MiracleSelectCallback)
			{
				output.WriteRawTag(130, 69);
				output.WriteMessage(this.MiracleSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BonusSelectCallback)
			{
				output.WriteRawTag(170, 72);
				output.WriteMessage(this.BonusSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.FGJFGKKDMJO)
			{
				output.WriteRawTag(162, 74);
				output.WriteMessage(this.FGJFGKKDMJO);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.MagicUnitSelectCallback)
			{
				output.WriteRawTag(170, 80);
				output.WriteMessage(this.MagicUnitSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffRerollCallback)
			{
				output.WriteRawTag(178, 95);
				output.WriteMessage(this.BuffRerollCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ECKIGPOCGCA)
			{
				output.WriteRawTag(218, 99);
				output.WriteMessage(this.ECKIGPOCGCA);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffReforgeSelectCallback)
			{
				output.WriteRawTag(146, 106);
				output.WriteMessage(this.BuffReforgeSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KBEAJGOPPDH)
			{
				output.WriteRawTag(130, 107);
				output.WriteMessage(this.KBEAJGOPPDH);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.RogueTournFormulaCallback)
			{
				output.WriteRawTag(130, 108);
				output.WriteMessage(this.RogueTournFormulaCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GMKLEHMJIII)
			{
				output.WriteRawTag(242, 110);
				output.WriteMessage(this.GMKLEHMJIII);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.AFBIIHAFLOA)
			{
				output.WriteRawTag(186, 119);
				output.WriteMessage(this.AFBIIHAFLOA);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KODMIGGOJKO)
			{
				output.WriteRawTag(250, 124);
				output.WriteMessage(this.KODMIGGOJKO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061F3 RID: 25075 RVA: 0x001056F8 File Offset: 0x001038F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QueuePosition != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QueuePosition);
			}
			if (this.QueueLocation != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QueueLocation);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffSelectCallback)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KOAGLGFNBOA)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KOAGLGFNBOA);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.JICIPLJDNAL)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.JICIPLJDNAL);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffRerollCallback)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffRerollCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffReforgeSelectCallback)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffReforgeSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.MiracleSelectCallback)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MiracleSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.AFBIIHAFLOA)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AFBIIHAFLOA);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ECKIGPOCGCA)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ECKIGPOCGCA);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KODMIGGOJKO)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KODMIGGOJKO);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GAFOPMBKBOA)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GAFOPMBKBOA);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.FMADNIJOPHB)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FMADNIJOPHB);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.HexAvatarSelectCallback)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HexAvatarSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BonusSelectCallback)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BonusSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.RogueTournFormulaCallback)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueTournFormulaCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.FGJFGKKDMJO)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FGJFGKKDMJO);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.EJENNEPAHDI)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EJENNEPAHDI);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ReforgeMiracleSelectCallback)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ReforgeMiracleSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.MagicUnitSelectCallback)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MagicUnitSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ScepterSelectCallback)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ScepterSelectCallback);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GPLEFKFBPGF)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GPLEFKFBPGF);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GMKLEHMJIII)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GMKLEHMJIII);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KBEAJGOPPDH)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KBEAJGOPPDH);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.CBMKJHHLAMH)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CBMKJHHLAMH);
			}
			if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GHOIPBKDEEJ)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GHOIPBKDEEJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060061F4 RID: 25076 RVA: 0x00105A1C File Offset: 0x00103C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandleRogueCommonPendingActionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QueuePosition != 0U)
			{
				this.QueuePosition = other.QueuePosition;
			}
			if (other.QueueLocation != 0U)
			{
				this.QueueLocation = other.QueueLocation;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			HandleRogueCommonPendingActionScRsp.ActionOneofCase actionCase = other.ActionCase;
			if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.KOAGLGFNBOA)
			{
				if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.ScepterSelectCallback)
				{
					if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.GAFOPMBKBOA)
					{
						if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffSelectCallback)
						{
							if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.ReforgeMiracleSelectCallback)
							{
								if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GAFOPMBKBOA)
								{
									if (this.GAFOPMBKBOA == null)
									{
										this.GAFOPMBKBOA = new OIOBNBAINGF();
									}
									this.GAFOPMBKBOA.MergeFrom(other.GAFOPMBKBOA);
								}
							}
							else
							{
								if (this.ReforgeMiracleSelectCallback == null)
								{
									this.ReforgeMiracleSelectCallback = new RogueReforgeFormulaSelectCallback();
								}
								this.ReforgeMiracleSelectCallback.MergeFrom(other.ReforgeMiracleSelectCallback);
							}
						}
						else
						{
							if (this.BuffSelectCallback == null)
							{
								this.BuffSelectCallback = new RogueBuffSelectCallback();
							}
							this.BuffSelectCallback.MergeFrom(other.BuffSelectCallback);
						}
					}
					else if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.HexAvatarSelectCallback)
					{
						if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.FMADNIJOPHB)
						{
							if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ScepterSelectCallback)
							{
								if (this.ScepterSelectCallback == null)
								{
									this.ScepterSelectCallback = new RogueMagicScepterSelectCallback();
								}
								this.ScepterSelectCallback.MergeFrom(other.ScepterSelectCallback);
							}
						}
						else
						{
							if (this.FMADNIJOPHB == null)
							{
								this.FMADNIJOPHB = new MMENILLOPPJ();
							}
							this.FMADNIJOPHB.MergeFrom(other.FMADNIJOPHB);
						}
					}
					else
					{
						if (this.HexAvatarSelectCallback == null)
						{
							this.HexAvatarSelectCallback = new RogueHexAvatarSelectCallback();
						}
						this.HexAvatarSelectCallback.MergeFrom(other.HexAvatarSelectCallback);
					}
				}
				else if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.EJENNEPAHDI)
				{
					if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.CBMKJHHLAMH)
					{
						if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.GHOIPBKDEEJ)
						{
							if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.EJENNEPAHDI)
							{
								if (this.EJENNEPAHDI == null)
								{
									this.EJENNEPAHDI = new ECHPHBKEOLG();
								}
								this.EJENNEPAHDI.MergeFrom(other.EJENNEPAHDI);
							}
						}
						else
						{
							if (this.GHOIPBKDEEJ == null)
							{
								this.GHOIPBKDEEJ = new EMAMDMCFCLJ();
							}
							this.GHOIPBKDEEJ.MergeFrom(other.GHOIPBKDEEJ);
						}
					}
					else
					{
						if (this.CBMKJHHLAMH == null)
						{
							this.CBMKJHHLAMH = new NGCOGFOKDFD();
						}
						this.CBMKJHHLAMH.MergeFrom(other.CBMKJHHLAMH);
					}
				}
				else if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.GPLEFKFBPGF)
				{
					if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.JICIPLJDNAL)
					{
						if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KOAGLGFNBOA)
						{
							if (this.KOAGLGFNBOA == null)
							{
								this.KOAGLGFNBOA = new FIANHJOCBOO();
							}
							this.KOAGLGFNBOA.MergeFrom(other.KOAGLGFNBOA);
						}
					}
					else
					{
						if (this.JICIPLJDNAL == null)
						{
							this.JICIPLJDNAL = new HKIPEMDOMMD();
						}
						this.JICIPLJDNAL.MergeFrom(other.JICIPLJDNAL);
					}
				}
				else
				{
					if (this.GPLEFKFBPGF == null)
					{
						this.GPLEFKFBPGF = new IDBPJBLHAGN();
					}
					this.GPLEFKFBPGF.MergeFrom(other.GPLEFKFBPGF);
				}
			}
			else if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.ECKIGPOCGCA)
			{
				if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.FGJFGKKDMJO)
				{
					if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.MiracleSelectCallback)
					{
						if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BonusSelectCallback)
						{
							if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.FGJFGKKDMJO)
							{
								if (this.FGJFGKKDMJO == null)
								{
									this.FGJFGKKDMJO = new CFNOJBILKBG();
								}
								this.FGJFGKKDMJO.MergeFrom(other.FGJFGKKDMJO);
							}
						}
						else
						{
							if (this.BonusSelectCallback == null)
							{
								this.BonusSelectCallback = new RogueBonusSelectCallback();
							}
							this.BonusSelectCallback.MergeFrom(other.BonusSelectCallback);
						}
					}
					else
					{
						if (this.MiracleSelectCallback == null)
						{
							this.MiracleSelectCallback = new RogueMiracleSelectCallback();
						}
						this.MiracleSelectCallback.MergeFrom(other.MiracleSelectCallback);
					}
				}
				else if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.MagicUnitSelectCallback)
				{
					if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffRerollCallback)
					{
						if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ECKIGPOCGCA)
						{
							if (this.ECKIGPOCGCA == null)
							{
								this.ECKIGPOCGCA = new INJNELLMNAC();
							}
							this.ECKIGPOCGCA.MergeFrom(other.ECKIGPOCGCA);
						}
					}
					else
					{
						if (this.BuffRerollCallback == null)
						{
							this.BuffRerollCallback = new RogueBuffRerollCallback();
						}
						this.BuffRerollCallback.MergeFrom(other.BuffRerollCallback);
					}
				}
				else
				{
					if (this.MagicUnitSelectCallback == null)
					{
						this.MagicUnitSelectCallback = new RogueMagicUnitSelectCallback();
					}
					this.MagicUnitSelectCallback.MergeFrom(other.MagicUnitSelectCallback);
				}
			}
			else if (actionCase <= HandleRogueCommonPendingActionScRsp.ActionOneofCase.RogueTournFormulaCallback)
			{
				if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffReforgeSelectCallback)
				{
					if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.KBEAJGOPPDH)
					{
						if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.RogueTournFormulaCallback)
						{
							if (this.RogueTournFormulaCallback == null)
							{
								this.RogueTournFormulaCallback = new RogueTournFormulaCallback();
							}
							this.RogueTournFormulaCallback.MergeFrom(other.RogueTournFormulaCallback);
						}
					}
					else
					{
						if (this.KBEAJGOPPDH == null)
						{
							this.KBEAJGOPPDH = new GOEBPLEJBAK();
						}
						this.KBEAJGOPPDH.MergeFrom(other.KBEAJGOPPDH);
					}
				}
				else
				{
					if (this.BuffReforgeSelectCallback == null)
					{
						this.BuffReforgeSelectCallback = new RogueBuffReforgeSelectCallback();
					}
					this.BuffReforgeSelectCallback.MergeFrom(other.BuffReforgeSelectCallback);
				}
			}
			else if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.GMKLEHMJIII)
			{
				if (actionCase != HandleRogueCommonPendingActionScRsp.ActionOneofCase.AFBIIHAFLOA)
				{
					if (actionCase == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KODMIGGOJKO)
					{
						if (this.KODMIGGOJKO == null)
						{
							this.KODMIGGOJKO = new LMADCCJOCCP();
						}
						this.KODMIGGOJKO.MergeFrom(other.KODMIGGOJKO);
					}
				}
				else
				{
					if (this.AFBIIHAFLOA == null)
					{
						this.AFBIIHAFLOA = new EPGECECNMGI();
					}
					this.AFBIIHAFLOA.MergeFrom(other.AFBIIHAFLOA);
				}
			}
			else
			{
				if (this.GMKLEHMJIII == null)
				{
					this.GMKLEHMJIII = new PHMCINNBADG();
				}
				this.GMKLEHMJIII.MergeFrom(other.GMKLEHMJIII);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060061F5 RID: 25077 RVA: 0x00105FB9 File Offset: 0x001041B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061F6 RID: 25078 RVA: 0x00105FC4 File Offset: 0x001041C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 8202U)
				{
					if (num <= 2746U)
					{
						if (num <= 96U)
						{
							if (num == 24U)
							{
								this.QueuePosition = input.ReadUInt32();
								continue;
							}
							if (num == 40U)
							{
								this.QueueLocation = input.ReadUInt32();
								continue;
							}
							if (num == 96U)
							{
								this.Retcode = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 554U)
							{
								RogueBuffSelectCallback rogueBuffSelectCallback = new RogueBuffSelectCallback();
								if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffSelectCallback)
								{
									rogueBuffSelectCallback.MergeFrom(this.BuffSelectCallback);
								}
								input.ReadMessage(rogueBuffSelectCallback);
								this.BuffSelectCallback = rogueBuffSelectCallback;
								continue;
							}
							if (num == 2418U)
							{
								RogueReforgeFormulaSelectCallback rogueReforgeFormulaSelectCallback = new RogueReforgeFormulaSelectCallback();
								if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ReforgeMiracleSelectCallback)
								{
									rogueReforgeFormulaSelectCallback.MergeFrom(this.ReforgeMiracleSelectCallback);
								}
								input.ReadMessage(rogueReforgeFormulaSelectCallback);
								this.ReforgeMiracleSelectCallback = rogueReforgeFormulaSelectCallback;
								continue;
							}
							if (num == 2746U)
							{
								OIOBNBAINGF oiobnbaingf = new OIOBNBAINGF();
								if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GAFOPMBKBOA)
								{
									oiobnbaingf.MergeFrom(this.GAFOPMBKBOA);
								}
								input.ReadMessage(oiobnbaingf);
								this.GAFOPMBKBOA = oiobnbaingf;
								continue;
							}
						}
					}
					else if (num <= 4850U)
					{
						if (num == 3858U)
						{
							RogueHexAvatarSelectCallback rogueHexAvatarSelectCallback = new RogueHexAvatarSelectCallback();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.HexAvatarSelectCallback)
							{
								rogueHexAvatarSelectCallback.MergeFrom(this.HexAvatarSelectCallback);
							}
							input.ReadMessage(rogueHexAvatarSelectCallback);
							this.HexAvatarSelectCallback = rogueHexAvatarSelectCallback;
							continue;
						}
						if (num == 4074U)
						{
							MMENILLOPPJ mmenilloppj = new MMENILLOPPJ();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.FMADNIJOPHB)
							{
								mmenilloppj.MergeFrom(this.FMADNIJOPHB);
							}
							input.ReadMessage(mmenilloppj);
							this.FMADNIJOPHB = mmenilloppj;
							continue;
						}
						if (num == 4850U)
						{
							RogueMagicScepterSelectCallback rogueMagicScepterSelectCallback = new RogueMagicScepterSelectCallback();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ScepterSelectCallback)
							{
								rogueMagicScepterSelectCallback.MergeFrom(this.ScepterSelectCallback);
							}
							input.ReadMessage(rogueMagicScepterSelectCallback);
							this.ScepterSelectCallback = rogueMagicScepterSelectCallback;
							continue;
						}
					}
					else if (num <= 5810U)
					{
						if (num == 5122U)
						{
							NGCOGFOKDFD ngcogfokdfd = new NGCOGFOKDFD();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.CBMKJHHLAMH)
							{
								ngcogfokdfd.MergeFrom(this.CBMKJHHLAMH);
							}
							input.ReadMessage(ngcogfokdfd);
							this.CBMKJHHLAMH = ngcogfokdfd;
							continue;
						}
						if (num == 5810U)
						{
							EMAMDMCFCLJ emamdmcfclj = new EMAMDMCFCLJ();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GHOIPBKDEEJ)
							{
								emamdmcfclj.MergeFrom(this.GHOIPBKDEEJ);
							}
							input.ReadMessage(emamdmcfclj);
							this.GHOIPBKDEEJ = emamdmcfclj;
							continue;
						}
					}
					else
					{
						if (num == 5890U)
						{
							ECHPHBKEOLG echphbkeolg = new ECHPHBKEOLG();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.EJENNEPAHDI)
							{
								echphbkeolg.MergeFrom(this.EJENNEPAHDI);
							}
							input.ReadMessage(echphbkeolg);
							this.EJENNEPAHDI = echphbkeolg;
							continue;
						}
						if (num == 8202U)
						{
							IDBPJBLHAGN idbpjblhagn = new IDBPJBLHAGN();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GPLEFKFBPGF)
							{
								idbpjblhagn.MergeFrom(this.GPLEFKFBPGF);
							}
							input.ReadMessage(idbpjblhagn);
							this.GPLEFKFBPGF = idbpjblhagn;
							continue;
						}
					}
				}
				else if (num <= 12210U)
				{
					if (num <= 8834U)
					{
						if (num == 8226U)
						{
							HKIPEMDOMMD hkipemdommd = new HKIPEMDOMMD();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.JICIPLJDNAL)
							{
								hkipemdommd.MergeFrom(this.JICIPLJDNAL);
							}
							input.ReadMessage(hkipemdommd);
							this.JICIPLJDNAL = hkipemdommd;
							continue;
						}
						if (num == 8810U)
						{
							FIANHJOCBOO fianhjocboo = new FIANHJOCBOO();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KOAGLGFNBOA)
							{
								fianhjocboo.MergeFrom(this.KOAGLGFNBOA);
							}
							input.ReadMessage(fianhjocboo);
							this.KOAGLGFNBOA = fianhjocboo;
							continue;
						}
						if (num == 8834U)
						{
							RogueMiracleSelectCallback rogueMiracleSelectCallback = new RogueMiracleSelectCallback();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.MiracleSelectCallback)
							{
								rogueMiracleSelectCallback.MergeFrom(this.MiracleSelectCallback);
							}
							input.ReadMessage(rogueMiracleSelectCallback);
							this.MiracleSelectCallback = rogueMiracleSelectCallback;
							continue;
						}
					}
					else if (num <= 9506U)
					{
						if (num == 9258U)
						{
							RogueBonusSelectCallback rogueBonusSelectCallback = new RogueBonusSelectCallback();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BonusSelectCallback)
							{
								rogueBonusSelectCallback.MergeFrom(this.BonusSelectCallback);
							}
							input.ReadMessage(rogueBonusSelectCallback);
							this.BonusSelectCallback = rogueBonusSelectCallback;
							continue;
						}
						if (num == 9506U)
						{
							CFNOJBILKBG cfnojbilkbg = new CFNOJBILKBG();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.FGJFGKKDMJO)
							{
								cfnojbilkbg.MergeFrom(this.FGJFGKKDMJO);
							}
							input.ReadMessage(cfnojbilkbg);
							this.FGJFGKKDMJO = cfnojbilkbg;
							continue;
						}
					}
					else
					{
						if (num == 10282U)
						{
							RogueMagicUnitSelectCallback rogueMagicUnitSelectCallback = new RogueMagicUnitSelectCallback();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.MagicUnitSelectCallback)
							{
								rogueMagicUnitSelectCallback.MergeFrom(this.MagicUnitSelectCallback);
							}
							input.ReadMessage(rogueMagicUnitSelectCallback);
							this.MagicUnitSelectCallback = rogueMagicUnitSelectCallback;
							continue;
						}
						if (num == 12210U)
						{
							RogueBuffRerollCallback rogueBuffRerollCallback = new RogueBuffRerollCallback();
							if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffRerollCallback)
							{
								rogueBuffRerollCallback.MergeFrom(this.BuffRerollCallback);
							}
							input.ReadMessage(rogueBuffRerollCallback);
							this.BuffRerollCallback = rogueBuffRerollCallback;
							continue;
						}
					}
				}
				else if (num <= 13698U)
				{
					if (num == 12762U)
					{
						INJNELLMNAC injnellmnac = new INJNELLMNAC();
						if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.ECKIGPOCGCA)
						{
							injnellmnac.MergeFrom(this.ECKIGPOCGCA);
						}
						input.ReadMessage(injnellmnac);
						this.ECKIGPOCGCA = injnellmnac;
						continue;
					}
					if (num == 13586U)
					{
						RogueBuffReforgeSelectCallback rogueBuffReforgeSelectCallback = new RogueBuffReforgeSelectCallback();
						if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.BuffReforgeSelectCallback)
						{
							rogueBuffReforgeSelectCallback.MergeFrom(this.BuffReforgeSelectCallback);
						}
						input.ReadMessage(rogueBuffReforgeSelectCallback);
						this.BuffReforgeSelectCallback = rogueBuffReforgeSelectCallback;
						continue;
					}
					if (num == 13698U)
					{
						GOEBPLEJBAK goebplejbak = new GOEBPLEJBAK();
						if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KBEAJGOPPDH)
						{
							goebplejbak.MergeFrom(this.KBEAJGOPPDH);
						}
						input.ReadMessage(goebplejbak);
						this.KBEAJGOPPDH = goebplejbak;
						continue;
					}
				}
				else if (num <= 14194U)
				{
					if (num == 13826U)
					{
						RogueTournFormulaCallback rogueTournFormulaCallback = new RogueTournFormulaCallback();
						if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.RogueTournFormulaCallback)
						{
							rogueTournFormulaCallback.MergeFrom(this.RogueTournFormulaCallback);
						}
						input.ReadMessage(rogueTournFormulaCallback);
						this.RogueTournFormulaCallback = rogueTournFormulaCallback;
						continue;
					}
					if (num == 14194U)
					{
						PHMCINNBADG phmcinnbadg = new PHMCINNBADG();
						if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.GMKLEHMJIII)
						{
							phmcinnbadg.MergeFrom(this.GMKLEHMJIII);
						}
						input.ReadMessage(phmcinnbadg);
						this.GMKLEHMJIII = phmcinnbadg;
						continue;
					}
				}
				else
				{
					if (num == 15290U)
					{
						EPGECECNMGI epgececnmgi = new EPGECECNMGI();
						if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.AFBIIHAFLOA)
						{
							epgececnmgi.MergeFrom(this.AFBIIHAFLOA);
						}
						input.ReadMessage(epgececnmgi);
						this.AFBIIHAFLOA = epgececnmgi;
						continue;
					}
					if (num == 15994U)
					{
						LMADCCJOCCP lmadccjoccp = new LMADCCJOCCP();
						if (this.actionCase_ == HandleRogueCommonPendingActionScRsp.ActionOneofCase.KODMIGGOJKO)
						{
							lmadccjoccp.MergeFrom(this.KODMIGGOJKO);
						}
						input.ReadMessage(lmadccjoccp);
						this.KODMIGGOJKO = lmadccjoccp;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400258A RID: 9610
		private static readonly MessageParser<HandleRogueCommonPendingActionScRsp> _parser = new MessageParser<HandleRogueCommonPendingActionScRsp>(() => new HandleRogueCommonPendingActionScRsp());

		// Token: 0x0400258B RID: 9611
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400258C RID: 9612
		public const int QueuePositionFieldNumber = 3;

		// Token: 0x0400258D RID: 9613
		private uint queuePosition_;

		// Token: 0x0400258E RID: 9614
		public const int QueueLocationFieldNumber = 5;

		// Token: 0x0400258F RID: 9615
		private uint queueLocation_;

		// Token: 0x04002590 RID: 9616
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04002591 RID: 9617
		private uint retcode_;

		// Token: 0x04002592 RID: 9618
		public const int BuffSelectCallbackFieldNumber = 69;

		// Token: 0x04002593 RID: 9619
		public const int KOAGLGFNBOAFieldNumber = 1101;

		// Token: 0x04002594 RID: 9620
		public const int JICIPLJDNALFieldNumber = 1028;

		// Token: 0x04002595 RID: 9621
		public const int BuffRerollCallbackFieldNumber = 1526;

		// Token: 0x04002596 RID: 9622
		public const int BuffReforgeSelectCallbackFieldNumber = 1698;

		// Token: 0x04002597 RID: 9623
		public const int MiracleSelectCallbackFieldNumber = 1104;

		// Token: 0x04002598 RID: 9624
		public const int AFBIIHAFLOAFieldNumber = 1911;

		// Token: 0x04002599 RID: 9625
		public const int ECKIGPOCGCAFieldNumber = 1595;

		// Token: 0x0400259A RID: 9626
		public const int KODMIGGOJKOFieldNumber = 1999;

		// Token: 0x0400259B RID: 9627
		public const int GAFOPMBKBOAFieldNumber = 343;

		// Token: 0x0400259C RID: 9628
		public const int FMADNIJOPHBFieldNumber = 509;

		// Token: 0x0400259D RID: 9629
		public const int HexAvatarSelectCallbackFieldNumber = 482;

		// Token: 0x0400259E RID: 9630
		public const int BonusSelectCallbackFieldNumber = 1157;

		// Token: 0x0400259F RID: 9631
		public const int RogueTournFormulaCallbackFieldNumber = 1728;

		// Token: 0x040025A0 RID: 9632
		public const int FGJFGKKDMJOFieldNumber = 1188;

		// Token: 0x040025A1 RID: 9633
		public const int EJENNEPAHDIFieldNumber = 736;

		// Token: 0x040025A2 RID: 9634
		public const int ReforgeMiracleSelectCallbackFieldNumber = 302;

		// Token: 0x040025A3 RID: 9635
		public const int MagicUnitSelectCallbackFieldNumber = 1285;

		// Token: 0x040025A4 RID: 9636
		public const int ScepterSelectCallbackFieldNumber = 606;

		// Token: 0x040025A5 RID: 9637
		public const int GPLEFKFBPGFFieldNumber = 1025;

		// Token: 0x040025A6 RID: 9638
		public const int GMKLEHMJIIIFieldNumber = 1774;

		// Token: 0x040025A7 RID: 9639
		public const int KBEAJGOPPDHFieldNumber = 1712;

		// Token: 0x040025A8 RID: 9640
		public const int CBMKJHHLAMHFieldNumber = 640;

		// Token: 0x040025A9 RID: 9641
		public const int GHOIPBKDEEJFieldNumber = 726;

		// Token: 0x040025AA RID: 9642
		private object action_;

		// Token: 0x040025AB RID: 9643
		private HandleRogueCommonPendingActionScRsp.ActionOneofCase actionCase_;

		// Token: 0x0200185D RID: 6237
		public enum ActionOneofCase
		{
			// Token: 0x04006035 RID: 24629
			None,
			// Token: 0x04006036 RID: 24630
			BuffSelectCallback = 69,
			// Token: 0x04006037 RID: 24631
			KOAGLGFNBOA = 1101,
			// Token: 0x04006038 RID: 24632
			JICIPLJDNAL = 1028,
			// Token: 0x04006039 RID: 24633
			BuffRerollCallback = 1526,
			// Token: 0x0400603A RID: 24634
			BuffReforgeSelectCallback = 1698,
			// Token: 0x0400603B RID: 24635
			MiracleSelectCallback = 1104,
			// Token: 0x0400603C RID: 24636
			AFBIIHAFLOA = 1911,
			// Token: 0x0400603D RID: 24637
			ECKIGPOCGCA = 1595,
			// Token: 0x0400603E RID: 24638
			KODMIGGOJKO = 1999,
			// Token: 0x0400603F RID: 24639
			GAFOPMBKBOA = 343,
			// Token: 0x04006040 RID: 24640
			FMADNIJOPHB = 509,
			// Token: 0x04006041 RID: 24641
			HexAvatarSelectCallback = 482,
			// Token: 0x04006042 RID: 24642
			BonusSelectCallback = 1157,
			// Token: 0x04006043 RID: 24643
			RogueTournFormulaCallback = 1728,
			// Token: 0x04006044 RID: 24644
			FGJFGKKDMJO = 1188,
			// Token: 0x04006045 RID: 24645
			EJENNEPAHDI = 736,
			// Token: 0x04006046 RID: 24646
			ReforgeMiracleSelectCallback = 302,
			// Token: 0x04006047 RID: 24647
			MagicUnitSelectCallback = 1285,
			// Token: 0x04006048 RID: 24648
			ScepterSelectCallback = 606,
			// Token: 0x04006049 RID: 24649
			GPLEFKFBPGF = 1025,
			// Token: 0x0400604A RID: 24650
			GMKLEHMJIII = 1774,
			// Token: 0x0400604B RID: 24651
			KBEAJGOPPDH = 1712,
			// Token: 0x0400604C RID: 24652
			CBMKJHHLAMH = 640,
			// Token: 0x0400604D RID: 24653
			GHOIPBKDEEJ = 726
		}
	}
}
