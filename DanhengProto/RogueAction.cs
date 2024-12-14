using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DE3 RID: 3555
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAction : IMessage<RogueAction>, IMessage, IEquatable<RogueAction>, IDeepCloneable<RogueAction>, IBufferMessage
	{
		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x06009EE8 RID: 40680 RVA: 0x001A97FA File Offset: 0x001A79FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAction> Parser
		{
			get
			{
				return RogueAction._parser;
			}
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x06009EE9 RID: 40681 RVA: 0x001A9801 File Offset: 0x001A7A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueActionReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x06009EEA RID: 40682 RVA: 0x001A9813 File Offset: 0x001A7A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAction.Descriptor;
			}
		}

		// Token: 0x06009EEB RID: 40683 RVA: 0x001A981A File Offset: 0x001A7A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAction()
		{
		}

		// Token: 0x06009EEC RID: 40684 RVA: 0x001A9824 File Offset: 0x001A7A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAction(RogueAction other) : this()
		{
			RogueAction.ActionOneofCase actionCase = other.ActionCase;
			if (actionCase <= RogueAction.ActionOneofCase.RogueFormulaSelectInfo)
			{
				if (actionCase <= RogueAction.ActionOneofCase.EHIHHECNPGN)
				{
					if (actionCase <= RogueAction.ActionOneofCase.BuffSelectInfo)
					{
						if (actionCase != RogueAction.ActionOneofCase.MagicUnitSelectInfo)
						{
							if (actionCase != RogueAction.ActionOneofCase.ComposeMiracleSelectInfo)
							{
								if (actionCase == RogueAction.ActionOneofCase.BuffSelectInfo)
								{
									this.BuffSelectInfo = other.BuffSelectInfo.Clone();
								}
							}
							else
							{
								this.ComposeMiracleSelectInfo = other.ComposeMiracleSelectInfo.Clone();
							}
						}
						else
						{
							this.MagicUnitSelectInfo = other.MagicUnitSelectInfo.Clone();
						}
					}
					else if (actionCase != RogueAction.ActionOneofCase.ScepterSelectInfo)
					{
						if (actionCase != RogueAction.ActionOneofCase.KGFLENGNFNP)
						{
							if (actionCase == RogueAction.ActionOneofCase.EHIHHECNPGN)
							{
								this.EHIHHECNPGN = other.EHIHHECNPGN.Clone();
							}
						}
						else
						{
							this.KGFLENGNFNP = other.KGFLENGNFNP.Clone();
						}
					}
					else
					{
						this.ScepterSelectInfo = other.ScepterSelectInfo.Clone();
					}
				}
				else if (actionCase <= RogueAction.ActionOneofCase.BCHBIBOMEPE)
				{
					if (actionCase != RogueAction.ActionOneofCase.KEBOMHDMCEA)
					{
						if (actionCase != RogueAction.ActionOneofCase.KFMEODPLFIK)
						{
							if (actionCase == RogueAction.ActionOneofCase.BCHBIBOMEPE)
							{
								this.BCHBIBOMEPE = other.BCHBIBOMEPE.Clone();
							}
						}
						else
						{
							this.KFMEODPLFIK = other.KFMEODPLFIK.Clone();
						}
					}
					else
					{
						this.KEBOMHDMCEA = other.KEBOMHDMCEA.Clone();
					}
				}
				else if (actionCase <= RogueAction.ActionOneofCase.BonusSelectInfo)
				{
					if (actionCase != RogueAction.ActionOneofCase.EMCJEPOJPAI)
					{
						if (actionCase == RogueAction.ActionOneofCase.BonusSelectInfo)
						{
							this.BonusSelectInfo = other.BonusSelectInfo.Clone();
						}
					}
					else
					{
						this.EMCJEPOJPAI = other.EMCJEPOJPAI.Clone();
					}
				}
				else if (actionCase != RogueAction.ActionOneofCase.IALFJGKDPAK)
				{
					if (actionCase == RogueAction.ActionOneofCase.RogueFormulaSelectInfo)
					{
						this.RogueFormulaSelectInfo = other.RogueFormulaSelectInfo.Clone();
					}
				}
				else
				{
					this.IALFJGKDPAK = other.IALFJGKDPAK.Clone();
				}
			}
			else if (actionCase <= RogueAction.ActionOneofCase.KLNIIJKJEKF)
			{
				if (actionCase <= RogueAction.ActionOneofCase.KGICGMLDGHD)
				{
					if (actionCase != RogueAction.ActionOneofCase.EDDHKBBHCEN)
					{
						if (actionCase != RogueAction.ActionOneofCase.IEODNFDGPOH)
						{
							if (actionCase == RogueAction.ActionOneofCase.KGICGMLDGHD)
							{
								this.KGICGMLDGHD = other.KGICGMLDGHD.Clone();
							}
						}
						else
						{
							this.IEODNFDGPOH = other.IEODNFDGPOH.Clone();
						}
					}
					else
					{
						this.EDDHKBBHCEN = other.EDDHKBBHCEN.Clone();
					}
				}
				else if (actionCase != RogueAction.ActionOneofCase.MJGMJDLLEJP)
				{
					if (actionCase != RogueAction.ActionOneofCase.HexAvatarSelectInfo)
					{
						if (actionCase == RogueAction.ActionOneofCase.KLNIIJKJEKF)
						{
							this.KLNIIJKJEKF = other.KLNIIJKJEKF.Clone();
						}
					}
					else
					{
						this.HexAvatarSelectInfo = other.HexAvatarSelectInfo.Clone();
					}
				}
				else
				{
					this.MJGMJDLLEJP = other.MJGMJDLLEJP.Clone();
				}
			}
			else if (actionCase <= RogueAction.ActionOneofCase.MPPOOKADLFL)
			{
				if (actionCase != RogueAction.ActionOneofCase.KHCBEFJJMPI)
				{
					if (actionCase != RogueAction.ActionOneofCase.BuffReforgeSelectInfo)
					{
						if (actionCase == RogueAction.ActionOneofCase.MPPOOKADLFL)
						{
							this.MPPOOKADLFL = other.MPPOOKADLFL.Clone();
						}
					}
					else
					{
						this.BuffReforgeSelectInfo = other.BuffReforgeSelectInfo.Clone();
					}
				}
				else
				{
					this.KHCBEFJJMPI = other.KHCBEFJJMPI.Clone();
				}
			}
			else if (actionCase <= RogueAction.ActionOneofCase.MiracleSelectInfo)
			{
				if (actionCase != RogueAction.ActionOneofCase.PNGAAMIAKAD)
				{
					if (actionCase == RogueAction.ActionOneofCase.MiracleSelectInfo)
					{
						this.MiracleSelectInfo = other.MiracleSelectInfo.Clone();
					}
				}
				else
				{
					this.PNGAAMIAKAD = other.PNGAAMIAKAD.Clone();
				}
			}
			else if (actionCase != RogueAction.ActionOneofCase.DFKFJAOMNLP)
			{
				if (actionCase == RogueAction.ActionOneofCase.ReforgeFormulaSelectInfo)
				{
					this.ReforgeFormulaSelectInfo = other.ReforgeFormulaSelectInfo.Clone();
				}
			}
			else
			{
				this.DFKFJAOMNLP = other.DFKFJAOMNLP.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EED RID: 40685 RVA: 0x001A9BFD File Offset: 0x001A7DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAction Clone()
		{
			return new RogueAction(this);
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x06009EEE RID: 40686 RVA: 0x001A9C05 File Offset: 0x001A7E05
		// (set) Token: 0x06009EEF RID: 40687 RVA: 0x001A9C1E File Offset: 0x001A7E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuffSelectInfo BuffSelectInfo
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.BuffSelectInfo)
				{
					return null;
				}
				return (RogueCommonBuffSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.BuffSelectInfo);
			}
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x06009EF0 RID: 40688 RVA: 0x001A9C35 File Offset: 0x001A7E35
		// (set) Token: 0x06009EF1 RID: 40689 RVA: 0x001A9C51 File Offset: 0x001A7E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IMBNANICJLH DFKFJAOMNLP
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.DFKFJAOMNLP)
				{
					return null;
				}
				return (IMBNANICJLH)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.DFKFJAOMNLP);
			}
		}

		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x06009EF2 RID: 40690 RVA: 0x001A9C6B File Offset: 0x001A7E6B
		// (set) Token: 0x06009EF3 RID: 40691 RVA: 0x001A9C87 File Offset: 0x001A7E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDIOJBCALHB EMCJEPOJPAI
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.EMCJEPOJPAI)
				{
					return null;
				}
				return (EDIOJBCALHB)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.EMCJEPOJPAI);
			}
		}

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x06009EF4 RID: 40692 RVA: 0x001A9CA1 File Offset: 0x001A7EA1
		// (set) Token: 0x06009EF5 RID: 40693 RVA: 0x001A9CBD File Offset: 0x001A7EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuffReforgeSelectInfo BuffReforgeSelectInfo
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.BuffReforgeSelectInfo)
				{
					return null;
				}
				return (RogueCommonBuffReforgeSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.BuffReforgeSelectInfo);
			}
		}

		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x06009EF6 RID: 40694 RVA: 0x001A9CD7 File Offset: 0x001A7ED7
		// (set) Token: 0x06009EF7 RID: 40695 RVA: 0x001A9CF3 File Offset: 0x001A7EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectInfo MiracleSelectInfo
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.MiracleSelectInfo)
				{
					return null;
				}
				return (RogueMiracleSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.MiracleSelectInfo);
			}
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x06009EF8 RID: 40696 RVA: 0x001A9D0D File Offset: 0x001A7F0D
		// (set) Token: 0x06009EF9 RID: 40697 RVA: 0x001A9D29 File Offset: 0x001A7F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BOEHIOPOPAF BCHBIBOMEPE
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.BCHBIBOMEPE)
				{
					return null;
				}
				return (BOEHIOPOPAF)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.BCHBIBOMEPE);
			}
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x06009EFA RID: 40698 RVA: 0x001A9D43 File Offset: 0x001A7F43
		// (set) Token: 0x06009EFB RID: 40699 RVA: 0x001A9D5F File Offset: 0x001A7F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PBBBGAMJGID IALFJGKDPAK
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.IALFJGKDPAK)
				{
					return null;
				}
				return (PBBBGAMJGID)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.IALFJGKDPAK);
			}
		}

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x06009EFC RID: 40700 RVA: 0x001A9D79 File Offset: 0x001A7F79
		// (set) Token: 0x06009EFD RID: 40701 RVA: 0x001A9D95 File Offset: 0x001A7F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FBGCMFJANMH IEODNFDGPOH
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.IEODNFDGPOH)
				{
					return null;
				}
				return (FBGCMFJANMH)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.IEODNFDGPOH);
			}
		}

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x06009EFE RID: 40702 RVA: 0x001A9DAF File Offset: 0x001A7FAF
		// (set) Token: 0x06009EFF RID: 40703 RVA: 0x001A9DCB File Offset: 0x001A7FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PIMBOBLCAJF KFMEODPLFIK
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.KFMEODPLFIK)
				{
					return null;
				}
				return (PIMBOBLCAJF)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.KFMEODPLFIK);
			}
		}

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x06009F00 RID: 40704 RVA: 0x001A9DE5 File Offset: 0x001A7FE5
		// (set) Token: 0x06009F01 RID: 40705 RVA: 0x001A9E01 File Offset: 0x001A8001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EEDHHFNHLBH MJGMJDLLEJP
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.MJGMJDLLEJP)
				{
					return null;
				}
				return (EEDHHFNHLBH)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.MJGMJDLLEJP);
			}
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x06009F02 RID: 40706 RVA: 0x001A9E1B File Offset: 0x001A801B
		// (set) Token: 0x06009F03 RID: 40707 RVA: 0x001A9E34 File Offset: 0x001A8034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueComposeMiracleSelectInfo ComposeMiracleSelectInfo
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.ComposeMiracleSelectInfo)
				{
					return null;
				}
				return (RogueComposeMiracleSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.ComposeMiracleSelectInfo);
			}
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x06009F04 RID: 40708 RVA: 0x001A9E4B File Offset: 0x001A804B
		// (set) Token: 0x06009F05 RID: 40709 RVA: 0x001A9E67 File Offset: 0x001A8067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectInfo HexAvatarSelectInfo
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.HexAvatarSelectInfo)
				{
					return null;
				}
				return (RogueHexAvatarSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.HexAvatarSelectInfo);
			}
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x06009F06 RID: 40710 RVA: 0x001A9E81 File Offset: 0x001A8081
		// (set) Token: 0x06009F07 RID: 40711 RVA: 0x001A9E9D File Offset: 0x001A809D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectInfo BonusSelectInfo
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.BonusSelectInfo)
				{
					return null;
				}
				return (RogueBonusSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.BonusSelectInfo);
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x06009F08 RID: 40712 RVA: 0x001A9EB7 File Offset: 0x001A80B7
		// (set) Token: 0x06009F09 RID: 40713 RVA: 0x001A9ED3 File Offset: 0x001A80D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFormulaSelectInfo RogueFormulaSelectInfo
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.RogueFormulaSelectInfo)
				{
					return null;
				}
				return (RogueFormulaSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.RogueFormulaSelectInfo);
			}
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x06009F0A RID: 40714 RVA: 0x001A9EED File Offset: 0x001A80ED
		// (set) Token: 0x06009F0B RID: 40715 RVA: 0x001A9F09 File Offset: 0x001A8109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BGCNBANPDDM PNGAAMIAKAD
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.PNGAAMIAKAD)
				{
					return null;
				}
				return (BGCNBANPDDM)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.PNGAAMIAKAD);
			}
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x06009F0C RID: 40716 RVA: 0x001A9F23 File Offset: 0x001A8123
		// (set) Token: 0x06009F0D RID: 40717 RVA: 0x001A9F3F File Offset: 0x001A813F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectInfo ReforgeFormulaSelectInfo
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.ReforgeFormulaSelectInfo)
				{
					return null;
				}
				return (RogueReforgeFormulaSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.ReforgeFormulaSelectInfo);
			}
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x06009F0E RID: 40718 RVA: 0x001A9F59 File Offset: 0x001A8159
		// (set) Token: 0x06009F0F RID: 40719 RVA: 0x001A9F72 File Offset: 0x001A8172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectInfo MagicUnitSelectInfo
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.MagicUnitSelectInfo)
				{
					return null;
				}
				return (RogueMagicUnitSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.MagicUnitSelectInfo);
			}
		}

		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x06009F10 RID: 40720 RVA: 0x001A9F89 File Offset: 0x001A8189
		// (set) Token: 0x06009F11 RID: 40721 RVA: 0x001A9FA5 File Offset: 0x001A81A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterSelectInfo ScepterSelectInfo
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.ScepterSelectInfo)
				{
					return null;
				}
				return (RogueMagicScepterSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.ScepterSelectInfo);
			}
		}

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x06009F12 RID: 40722 RVA: 0x001A9FBF File Offset: 0x001A81BF
		// (set) Token: 0x06009F13 RID: 40723 RVA: 0x001A9FDB File Offset: 0x001A81DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDGBFNHLADP KHCBEFJJMPI
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.KHCBEFJJMPI)
				{
					return null;
				}
				return (JDGBFNHLADP)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.KHCBEFJJMPI);
			}
		}

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x06009F14 RID: 40724 RVA: 0x001A9FF5 File Offset: 0x001A81F5
		// (set) Token: 0x06009F15 RID: 40725 RVA: 0x001AA011 File Offset: 0x001A8211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectInfo KGFLENGNFNP
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.KGFLENGNFNP)
				{
					return null;
				}
				return (RogueMagicUnitSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.KGFLENGNFNP);
			}
		}

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x06009F16 RID: 40726 RVA: 0x001AA02B File Offset: 0x001A822B
		// (set) Token: 0x06009F17 RID: 40727 RVA: 0x001AA047 File Offset: 0x001A8247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectInfo KGICGMLDGHD
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.KGICGMLDGHD)
				{
					return null;
				}
				return (RogueMagicUnitSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.KGICGMLDGHD);
			}
		}

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x06009F18 RID: 40728 RVA: 0x001AA061 File Offset: 0x001A8261
		// (set) Token: 0x06009F19 RID: 40729 RVA: 0x001AA07D File Offset: 0x001A827D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectInfo EHIHHECNPGN
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.EHIHHECNPGN)
				{
					return null;
				}
				return (RogueMagicUnitSelectInfo)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.EHIHHECNPGN);
			}
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x06009F1A RID: 40730 RVA: 0x001AA097 File Offset: 0x001A8297
		// (set) Token: 0x06009F1B RID: 40731 RVA: 0x001AA0B3 File Offset: 0x001A82B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CBDOEBJHECH MPPOOKADLFL
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.MPPOOKADLFL)
				{
					return null;
				}
				return (CBDOEBJHECH)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.MPPOOKADLFL);
			}
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x06009F1C RID: 40732 RVA: 0x001AA0CD File Offset: 0x001A82CD
		// (set) Token: 0x06009F1D RID: 40733 RVA: 0x001AA0E9 File Offset: 0x001A82E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CBDOEBJHECH EDDHKBBHCEN
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.EDDHKBBHCEN)
				{
					return null;
				}
				return (CBDOEBJHECH)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.EDDHKBBHCEN);
			}
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x06009F1E RID: 40734 RVA: 0x001AA103 File Offset: 0x001A8303
		// (set) Token: 0x06009F1F RID: 40735 RVA: 0x001AA11F File Offset: 0x001A831F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CBDOEBJHECH KLNIIJKJEKF
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.KLNIIJKJEKF)
				{
					return null;
				}
				return (CBDOEBJHECH)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.KLNIIJKJEKF);
			}
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x06009F20 RID: 40736 RVA: 0x001AA139 File Offset: 0x001A8339
		// (set) Token: 0x06009F21 RID: 40737 RVA: 0x001AA155 File Offset: 0x001A8355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PIKBKJJKHBP KEBOMHDMCEA
		{
			get
			{
				if (this.actionCase_ != RogueAction.ActionOneofCase.KEBOMHDMCEA)
				{
					return null;
				}
				return (PIKBKJJKHBP)this.action_;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = ((value == null) ? RogueAction.ActionOneofCase.None : RogueAction.ActionOneofCase.KEBOMHDMCEA);
			}
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x06009F22 RID: 40738 RVA: 0x001AA16F File Offset: 0x001A836F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAction.ActionOneofCase ActionCase
		{
			get
			{
				return this.actionCase_;
			}
		}

		// Token: 0x06009F23 RID: 40739 RVA: 0x001AA177 File Offset: 0x001A8377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAction()
		{
			this.actionCase_ = RogueAction.ActionOneofCase.None;
			this.action_ = null;
		}

		// Token: 0x06009F24 RID: 40740 RVA: 0x001AA187 File Offset: 0x001A8387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAction);
		}

		// Token: 0x06009F25 RID: 40741 RVA: 0x001AA198 File Offset: 0x001A8398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAction other)
		{
			return other != null && (other == this || (object.Equals(this.BuffSelectInfo, other.BuffSelectInfo) && object.Equals(this.DFKFJAOMNLP, other.DFKFJAOMNLP) && object.Equals(this.EMCJEPOJPAI, other.EMCJEPOJPAI) && object.Equals(this.BuffReforgeSelectInfo, other.BuffReforgeSelectInfo) && object.Equals(this.MiracleSelectInfo, other.MiracleSelectInfo) && object.Equals(this.BCHBIBOMEPE, other.BCHBIBOMEPE) && object.Equals(this.IALFJGKDPAK, other.IALFJGKDPAK) && object.Equals(this.IEODNFDGPOH, other.IEODNFDGPOH) && object.Equals(this.KFMEODPLFIK, other.KFMEODPLFIK) && object.Equals(this.MJGMJDLLEJP, other.MJGMJDLLEJP) && object.Equals(this.ComposeMiracleSelectInfo, other.ComposeMiracleSelectInfo) && object.Equals(this.HexAvatarSelectInfo, other.HexAvatarSelectInfo) && object.Equals(this.BonusSelectInfo, other.BonusSelectInfo) && object.Equals(this.RogueFormulaSelectInfo, other.RogueFormulaSelectInfo) && object.Equals(this.PNGAAMIAKAD, other.PNGAAMIAKAD) && object.Equals(this.ReforgeFormulaSelectInfo, other.ReforgeFormulaSelectInfo) && object.Equals(this.MagicUnitSelectInfo, other.MagicUnitSelectInfo) && object.Equals(this.ScepterSelectInfo, other.ScepterSelectInfo) && object.Equals(this.KHCBEFJJMPI, other.KHCBEFJJMPI) && object.Equals(this.KGFLENGNFNP, other.KGFLENGNFNP) && object.Equals(this.KGICGMLDGHD, other.KGICGMLDGHD) && object.Equals(this.EHIHHECNPGN, other.EHIHHECNPGN) && object.Equals(this.MPPOOKADLFL, other.MPPOOKADLFL) && object.Equals(this.EDDHKBBHCEN, other.EDDHKBBHCEN) && object.Equals(this.KLNIIJKJEKF, other.KLNIIJKJEKF) && object.Equals(this.KEBOMHDMCEA, other.KEBOMHDMCEA) && this.ActionCase == other.ActionCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x001AA3F4 File Offset: 0x001A85F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.actionCase_ == RogueAction.ActionOneofCase.BuffSelectInfo)
			{
				num ^= this.BuffSelectInfo.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.DFKFJAOMNLP)
			{
				num ^= this.DFKFJAOMNLP.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.EMCJEPOJPAI)
			{
				num ^= this.EMCJEPOJPAI.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.BuffReforgeSelectInfo)
			{
				num ^= this.BuffReforgeSelectInfo.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MiracleSelectInfo)
			{
				num ^= this.MiracleSelectInfo.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.BCHBIBOMEPE)
			{
				num ^= this.BCHBIBOMEPE.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.IALFJGKDPAK)
			{
				num ^= this.IALFJGKDPAK.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.IEODNFDGPOH)
			{
				num ^= this.IEODNFDGPOH.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KFMEODPLFIK)
			{
				num ^= this.KFMEODPLFIK.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MJGMJDLLEJP)
			{
				num ^= this.MJGMJDLLEJP.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.ComposeMiracleSelectInfo)
			{
				num ^= this.ComposeMiracleSelectInfo.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.HexAvatarSelectInfo)
			{
				num ^= this.HexAvatarSelectInfo.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.BonusSelectInfo)
			{
				num ^= this.BonusSelectInfo.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.RogueFormulaSelectInfo)
			{
				num ^= this.RogueFormulaSelectInfo.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.PNGAAMIAKAD)
			{
				num ^= this.PNGAAMIAKAD.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.ReforgeFormulaSelectInfo)
			{
				num ^= this.ReforgeFormulaSelectInfo.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MagicUnitSelectInfo)
			{
				num ^= this.MagicUnitSelectInfo.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.ScepterSelectInfo)
			{
				num ^= this.ScepterSelectInfo.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KHCBEFJJMPI)
			{
				num ^= this.KHCBEFJJMPI.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KGFLENGNFNP)
			{
				num ^= this.KGFLENGNFNP.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KGICGMLDGHD)
			{
				num ^= this.KGICGMLDGHD.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.EHIHHECNPGN)
			{
				num ^= this.EHIHHECNPGN.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MPPOOKADLFL)
			{
				num ^= this.MPPOOKADLFL.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.EDDHKBBHCEN)
			{
				num ^= this.EDDHKBBHCEN.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KLNIIJKJEKF)
			{
				num ^= this.KLNIIJKJEKF.GetHashCode();
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KEBOMHDMCEA)
			{
				num ^= this.KEBOMHDMCEA.GetHashCode();
			}
			num ^= (int)this.actionCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F27 RID: 40743 RVA: 0x001AA6D8 File Offset: 0x001A88D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F28 RID: 40744 RVA: 0x001AA6E0 File Offset: 0x001A88E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x001AA6EC File Offset: 0x001A88EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.actionCase_ == RogueAction.ActionOneofCase.MagicUnitSelectInfo)
			{
				output.WriteRawTag(146, 3);
				output.WriteMessage(this.MagicUnitSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.ComposeMiracleSelectInfo)
			{
				output.WriteRawTag(202, 3);
				output.WriteMessage(this.ComposeMiracleSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.BuffSelectInfo)
			{
				output.WriteRawTag(130, 7);
				output.WriteMessage(this.BuffSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.ScepterSelectInfo)
			{
				output.WriteRawTag(226, 16);
				output.WriteMessage(this.ScepterSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KGFLENGNFNP)
			{
				output.WriteRawTag(194, 26);
				output.WriteMessage(this.KGFLENGNFNP);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.EHIHHECNPGN)
			{
				output.WriteRawTag(250, 26);
				output.WriteMessage(this.EHIHHECNPGN);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KEBOMHDMCEA)
			{
				output.WriteRawTag(250, 28);
				output.WriteMessage(this.KEBOMHDMCEA);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KFMEODPLFIK)
			{
				output.WriteRawTag(234, 34);
				output.WriteMessage(this.KFMEODPLFIK);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.BCHBIBOMEPE)
			{
				output.WriteRawTag(218, 35);
				output.WriteMessage(this.BCHBIBOMEPE);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.EMCJEPOJPAI)
			{
				output.WriteRawTag(242, 40);
				output.WriteMessage(this.EMCJEPOJPAI);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.BonusSelectInfo)
			{
				output.WriteRawTag(146, 53);
				output.WriteMessage(this.BonusSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.IALFJGKDPAK)
			{
				output.WriteRawTag(162, 54);
				output.WriteMessage(this.IALFJGKDPAK);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.RogueFormulaSelectInfo)
			{
				output.WriteRawTag(242, 55);
				output.WriteMessage(this.RogueFormulaSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.EDDHKBBHCEN)
			{
				output.WriteRawTag(202, 57);
				output.WriteMessage(this.EDDHKBBHCEN);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.IEODNFDGPOH)
			{
				output.WriteRawTag(226, 64);
				output.WriteMessage(this.IEODNFDGPOH);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KGICGMLDGHD)
			{
				output.WriteRawTag(138, 70);
				output.WriteMessage(this.KGICGMLDGHD);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MJGMJDLLEJP)
			{
				output.WriteRawTag(242, 71);
				output.WriteMessage(this.MJGMJDLLEJP);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.HexAvatarSelectInfo)
			{
				output.WriteRawTag(226, 78);
				output.WriteMessage(this.HexAvatarSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KLNIIJKJEKF)
			{
				output.WriteRawTag(210, 80);
				output.WriteMessage(this.KLNIIJKJEKF);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KHCBEFJJMPI)
			{
				output.WriteRawTag(226, 87);
				output.WriteMessage(this.KHCBEFJJMPI);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.BuffReforgeSelectInfo)
			{
				output.WriteRawTag(210, 98);
				output.WriteMessage(this.BuffReforgeSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MPPOOKADLFL)
			{
				output.WriteRawTag(178, 99);
				output.WriteMessage(this.MPPOOKADLFL);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.PNGAAMIAKAD)
			{
				output.WriteRawTag(138, 107);
				output.WriteMessage(this.PNGAAMIAKAD);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MiracleSelectInfo)
			{
				output.WriteRawTag(146, 107);
				output.WriteMessage(this.MiracleSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.DFKFJAOMNLP)
			{
				output.WriteRawTag(154, 114);
				output.WriteMessage(this.DFKFJAOMNLP);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.ReforgeFormulaSelectInfo)
			{
				output.WriteRawTag(202, 127);
				output.WriteMessage(this.ReforgeFormulaSelectInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x001AAAE0 File Offset: 0x001A8CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.actionCase_ == RogueAction.ActionOneofCase.BuffSelectInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.DFKFJAOMNLP)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DFKFJAOMNLP);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.EMCJEPOJPAI)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EMCJEPOJPAI);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.BuffReforgeSelectInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffReforgeSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MiracleSelectInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MiracleSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.BCHBIBOMEPE)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BCHBIBOMEPE);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.IALFJGKDPAK)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.IALFJGKDPAK);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.IEODNFDGPOH)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.IEODNFDGPOH);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KFMEODPLFIK)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KFMEODPLFIK);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MJGMJDLLEJP)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MJGMJDLLEJP);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.ComposeMiracleSelectInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ComposeMiracleSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.HexAvatarSelectInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HexAvatarSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.BonusSelectInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BonusSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.RogueFormulaSelectInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueFormulaSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.PNGAAMIAKAD)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PNGAAMIAKAD);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.ReforgeFormulaSelectInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ReforgeFormulaSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MagicUnitSelectInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MagicUnitSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.ScepterSelectInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ScepterSelectInfo);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KHCBEFJJMPI)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KHCBEFJJMPI);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KGFLENGNFNP)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KGFLENGNFNP);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KGICGMLDGHD)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KGICGMLDGHD);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.EHIHHECNPGN)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EHIHHECNPGN);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.MPPOOKADLFL)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MPPOOKADLFL);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.EDDHKBBHCEN)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EDDHKBBHCEN);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KLNIIJKJEKF)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KLNIIJKJEKF);
			}
			if (this.actionCase_ == RogueAction.ActionOneofCase.KEBOMHDMCEA)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KEBOMHDMCEA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F2B RID: 40747 RVA: 0x001AADF0 File Offset: 0x001A8FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAction other)
		{
			if (other == null)
			{
				return;
			}
			RogueAction.ActionOneofCase actionCase = other.ActionCase;
			if (actionCase <= RogueAction.ActionOneofCase.RogueFormulaSelectInfo)
			{
				if (actionCase <= RogueAction.ActionOneofCase.EHIHHECNPGN)
				{
					if (actionCase <= RogueAction.ActionOneofCase.BuffSelectInfo)
					{
						if (actionCase != RogueAction.ActionOneofCase.MagicUnitSelectInfo)
						{
							if (actionCase != RogueAction.ActionOneofCase.ComposeMiracleSelectInfo)
							{
								if (actionCase == RogueAction.ActionOneofCase.BuffSelectInfo)
								{
									if (this.BuffSelectInfo == null)
									{
										this.BuffSelectInfo = new RogueCommonBuffSelectInfo();
									}
									this.BuffSelectInfo.MergeFrom(other.BuffSelectInfo);
								}
							}
							else
							{
								if (this.ComposeMiracleSelectInfo == null)
								{
									this.ComposeMiracleSelectInfo = new RogueComposeMiracleSelectInfo();
								}
								this.ComposeMiracleSelectInfo.MergeFrom(other.ComposeMiracleSelectInfo);
							}
						}
						else
						{
							if (this.MagicUnitSelectInfo == null)
							{
								this.MagicUnitSelectInfo = new RogueMagicUnitSelectInfo();
							}
							this.MagicUnitSelectInfo.MergeFrom(other.MagicUnitSelectInfo);
						}
					}
					else if (actionCase != RogueAction.ActionOneofCase.ScepterSelectInfo)
					{
						if (actionCase != RogueAction.ActionOneofCase.KGFLENGNFNP)
						{
							if (actionCase == RogueAction.ActionOneofCase.EHIHHECNPGN)
							{
								if (this.EHIHHECNPGN == null)
								{
									this.EHIHHECNPGN = new RogueMagicUnitSelectInfo();
								}
								this.EHIHHECNPGN.MergeFrom(other.EHIHHECNPGN);
							}
						}
						else
						{
							if (this.KGFLENGNFNP == null)
							{
								this.KGFLENGNFNP = new RogueMagicUnitSelectInfo();
							}
							this.KGFLENGNFNP.MergeFrom(other.KGFLENGNFNP);
						}
					}
					else
					{
						if (this.ScepterSelectInfo == null)
						{
							this.ScepterSelectInfo = new RogueMagicScepterSelectInfo();
						}
						this.ScepterSelectInfo.MergeFrom(other.ScepterSelectInfo);
					}
				}
				else if (actionCase <= RogueAction.ActionOneofCase.BCHBIBOMEPE)
				{
					if (actionCase != RogueAction.ActionOneofCase.KEBOMHDMCEA)
					{
						if (actionCase != RogueAction.ActionOneofCase.KFMEODPLFIK)
						{
							if (actionCase == RogueAction.ActionOneofCase.BCHBIBOMEPE)
							{
								if (this.BCHBIBOMEPE == null)
								{
									this.BCHBIBOMEPE = new BOEHIOPOPAF();
								}
								this.BCHBIBOMEPE.MergeFrom(other.BCHBIBOMEPE);
							}
						}
						else
						{
							if (this.KFMEODPLFIK == null)
							{
								this.KFMEODPLFIK = new PIMBOBLCAJF();
							}
							this.KFMEODPLFIK.MergeFrom(other.KFMEODPLFIK);
						}
					}
					else
					{
						if (this.KEBOMHDMCEA == null)
						{
							this.KEBOMHDMCEA = new PIKBKJJKHBP();
						}
						this.KEBOMHDMCEA.MergeFrom(other.KEBOMHDMCEA);
					}
				}
				else if (actionCase <= RogueAction.ActionOneofCase.BonusSelectInfo)
				{
					if (actionCase != RogueAction.ActionOneofCase.EMCJEPOJPAI)
					{
						if (actionCase == RogueAction.ActionOneofCase.BonusSelectInfo)
						{
							if (this.BonusSelectInfo == null)
							{
								this.BonusSelectInfo = new RogueBonusSelectInfo();
							}
							this.BonusSelectInfo.MergeFrom(other.BonusSelectInfo);
						}
					}
					else
					{
						if (this.EMCJEPOJPAI == null)
						{
							this.EMCJEPOJPAI = new EDIOJBCALHB();
						}
						this.EMCJEPOJPAI.MergeFrom(other.EMCJEPOJPAI);
					}
				}
				else if (actionCase != RogueAction.ActionOneofCase.IALFJGKDPAK)
				{
					if (actionCase == RogueAction.ActionOneofCase.RogueFormulaSelectInfo)
					{
						if (this.RogueFormulaSelectInfo == null)
						{
							this.RogueFormulaSelectInfo = new RogueFormulaSelectInfo();
						}
						this.RogueFormulaSelectInfo.MergeFrom(other.RogueFormulaSelectInfo);
					}
				}
				else
				{
					if (this.IALFJGKDPAK == null)
					{
						this.IALFJGKDPAK = new PBBBGAMJGID();
					}
					this.IALFJGKDPAK.MergeFrom(other.IALFJGKDPAK);
				}
			}
			else if (actionCase <= RogueAction.ActionOneofCase.KLNIIJKJEKF)
			{
				if (actionCase <= RogueAction.ActionOneofCase.KGICGMLDGHD)
				{
					if (actionCase != RogueAction.ActionOneofCase.EDDHKBBHCEN)
					{
						if (actionCase != RogueAction.ActionOneofCase.IEODNFDGPOH)
						{
							if (actionCase == RogueAction.ActionOneofCase.KGICGMLDGHD)
							{
								if (this.KGICGMLDGHD == null)
								{
									this.KGICGMLDGHD = new RogueMagicUnitSelectInfo();
								}
								this.KGICGMLDGHD.MergeFrom(other.KGICGMLDGHD);
							}
						}
						else
						{
							if (this.IEODNFDGPOH == null)
							{
								this.IEODNFDGPOH = new FBGCMFJANMH();
							}
							this.IEODNFDGPOH.MergeFrom(other.IEODNFDGPOH);
						}
					}
					else
					{
						if (this.EDDHKBBHCEN == null)
						{
							this.EDDHKBBHCEN = new CBDOEBJHECH();
						}
						this.EDDHKBBHCEN.MergeFrom(other.EDDHKBBHCEN);
					}
				}
				else if (actionCase != RogueAction.ActionOneofCase.MJGMJDLLEJP)
				{
					if (actionCase != RogueAction.ActionOneofCase.HexAvatarSelectInfo)
					{
						if (actionCase == RogueAction.ActionOneofCase.KLNIIJKJEKF)
						{
							if (this.KLNIIJKJEKF == null)
							{
								this.KLNIIJKJEKF = new CBDOEBJHECH();
							}
							this.KLNIIJKJEKF.MergeFrom(other.KLNIIJKJEKF);
						}
					}
					else
					{
						if (this.HexAvatarSelectInfo == null)
						{
							this.HexAvatarSelectInfo = new RogueHexAvatarSelectInfo();
						}
						this.HexAvatarSelectInfo.MergeFrom(other.HexAvatarSelectInfo);
					}
				}
				else
				{
					if (this.MJGMJDLLEJP == null)
					{
						this.MJGMJDLLEJP = new EEDHHFNHLBH();
					}
					this.MJGMJDLLEJP.MergeFrom(other.MJGMJDLLEJP);
				}
			}
			else if (actionCase <= RogueAction.ActionOneofCase.MPPOOKADLFL)
			{
				if (actionCase != RogueAction.ActionOneofCase.KHCBEFJJMPI)
				{
					if (actionCase != RogueAction.ActionOneofCase.BuffReforgeSelectInfo)
					{
						if (actionCase == RogueAction.ActionOneofCase.MPPOOKADLFL)
						{
							if (this.MPPOOKADLFL == null)
							{
								this.MPPOOKADLFL = new CBDOEBJHECH();
							}
							this.MPPOOKADLFL.MergeFrom(other.MPPOOKADLFL);
						}
					}
					else
					{
						if (this.BuffReforgeSelectInfo == null)
						{
							this.BuffReforgeSelectInfo = new RogueCommonBuffReforgeSelectInfo();
						}
						this.BuffReforgeSelectInfo.MergeFrom(other.BuffReforgeSelectInfo);
					}
				}
				else
				{
					if (this.KHCBEFJJMPI == null)
					{
						this.KHCBEFJJMPI = new JDGBFNHLADP();
					}
					this.KHCBEFJJMPI.MergeFrom(other.KHCBEFJJMPI);
				}
			}
			else if (actionCase <= RogueAction.ActionOneofCase.MiracleSelectInfo)
			{
				if (actionCase != RogueAction.ActionOneofCase.PNGAAMIAKAD)
				{
					if (actionCase == RogueAction.ActionOneofCase.MiracleSelectInfo)
					{
						if (this.MiracleSelectInfo == null)
						{
							this.MiracleSelectInfo = new RogueMiracleSelectInfo();
						}
						this.MiracleSelectInfo.MergeFrom(other.MiracleSelectInfo);
					}
				}
				else
				{
					if (this.PNGAAMIAKAD == null)
					{
						this.PNGAAMIAKAD = new BGCNBANPDDM();
					}
					this.PNGAAMIAKAD.MergeFrom(other.PNGAAMIAKAD);
				}
			}
			else if (actionCase != RogueAction.ActionOneofCase.DFKFJAOMNLP)
			{
				if (actionCase == RogueAction.ActionOneofCase.ReforgeFormulaSelectInfo)
				{
					if (this.ReforgeFormulaSelectInfo == null)
					{
						this.ReforgeFormulaSelectInfo = new RogueReforgeFormulaSelectInfo();
					}
					this.ReforgeFormulaSelectInfo.MergeFrom(other.ReforgeFormulaSelectInfo);
				}
			}
			else
			{
				if (this.DFKFJAOMNLP == null)
				{
					this.DFKFJAOMNLP = new IMBNANICJLH();
				}
				this.DFKFJAOMNLP.MergeFrom(other.DFKFJAOMNLP);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x001AB3C7 File Offset: 0x001A95C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F2D RID: 40749 RVA: 0x001AB3D0 File Offset: 0x001A95D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 7154U)
				{
					if (num <= 3450U)
					{
						if (num <= 898U)
						{
							if (num == 402U)
							{
								RogueMagicUnitSelectInfo rogueMagicUnitSelectInfo = new RogueMagicUnitSelectInfo();
								if (this.actionCase_ == RogueAction.ActionOneofCase.MagicUnitSelectInfo)
								{
									rogueMagicUnitSelectInfo.MergeFrom(this.MagicUnitSelectInfo);
								}
								input.ReadMessage(rogueMagicUnitSelectInfo);
								this.MagicUnitSelectInfo = rogueMagicUnitSelectInfo;
								continue;
							}
							if (num == 458U)
							{
								RogueComposeMiracleSelectInfo rogueComposeMiracleSelectInfo = new RogueComposeMiracleSelectInfo();
								if (this.actionCase_ == RogueAction.ActionOneofCase.ComposeMiracleSelectInfo)
								{
									rogueComposeMiracleSelectInfo.MergeFrom(this.ComposeMiracleSelectInfo);
								}
								input.ReadMessage(rogueComposeMiracleSelectInfo);
								this.ComposeMiracleSelectInfo = rogueComposeMiracleSelectInfo;
								continue;
							}
							if (num == 898U)
							{
								RogueCommonBuffSelectInfo rogueCommonBuffSelectInfo = new RogueCommonBuffSelectInfo();
								if (this.actionCase_ == RogueAction.ActionOneofCase.BuffSelectInfo)
								{
									rogueCommonBuffSelectInfo.MergeFrom(this.BuffSelectInfo);
								}
								input.ReadMessage(rogueCommonBuffSelectInfo);
								this.BuffSelectInfo = rogueCommonBuffSelectInfo;
								continue;
							}
						}
						else
						{
							if (num == 2146U)
							{
								RogueMagicScepterSelectInfo rogueMagicScepterSelectInfo = new RogueMagicScepterSelectInfo();
								if (this.actionCase_ == RogueAction.ActionOneofCase.ScepterSelectInfo)
								{
									rogueMagicScepterSelectInfo.MergeFrom(this.ScepterSelectInfo);
								}
								input.ReadMessage(rogueMagicScepterSelectInfo);
								this.ScepterSelectInfo = rogueMagicScepterSelectInfo;
								continue;
							}
							if (num == 3394U)
							{
								RogueMagicUnitSelectInfo rogueMagicUnitSelectInfo2 = new RogueMagicUnitSelectInfo();
								if (this.actionCase_ == RogueAction.ActionOneofCase.KGFLENGNFNP)
								{
									rogueMagicUnitSelectInfo2.MergeFrom(this.KGFLENGNFNP);
								}
								input.ReadMessage(rogueMagicUnitSelectInfo2);
								this.KGFLENGNFNP = rogueMagicUnitSelectInfo2;
								continue;
							}
							if (num == 3450U)
							{
								RogueMagicUnitSelectInfo rogueMagicUnitSelectInfo3 = new RogueMagicUnitSelectInfo();
								if (this.actionCase_ == RogueAction.ActionOneofCase.EHIHHECNPGN)
								{
									rogueMagicUnitSelectInfo3.MergeFrom(this.EHIHHECNPGN);
								}
								input.ReadMessage(rogueMagicUnitSelectInfo3);
								this.EHIHHECNPGN = rogueMagicUnitSelectInfo3;
								continue;
							}
						}
					}
					else if (num <= 4570U)
					{
						if (num == 3706U)
						{
							PIKBKJJKHBP pikbkjjkhbp = new PIKBKJJKHBP();
							if (this.actionCase_ == RogueAction.ActionOneofCase.KEBOMHDMCEA)
							{
								pikbkjjkhbp.MergeFrom(this.KEBOMHDMCEA);
							}
							input.ReadMessage(pikbkjjkhbp);
							this.KEBOMHDMCEA = pikbkjjkhbp;
							continue;
						}
						if (num == 4458U)
						{
							PIMBOBLCAJF pimboblcajf = new PIMBOBLCAJF();
							if (this.actionCase_ == RogueAction.ActionOneofCase.KFMEODPLFIK)
							{
								pimboblcajf.MergeFrom(this.KFMEODPLFIK);
							}
							input.ReadMessage(pimboblcajf);
							this.KFMEODPLFIK = pimboblcajf;
							continue;
						}
						if (num == 4570U)
						{
							BOEHIOPOPAF boehiopopaf = new BOEHIOPOPAF();
							if (this.actionCase_ == RogueAction.ActionOneofCase.BCHBIBOMEPE)
							{
								boehiopopaf.MergeFrom(this.BCHBIBOMEPE);
							}
							input.ReadMessage(boehiopopaf);
							this.BCHBIBOMEPE = boehiopopaf;
							continue;
						}
					}
					else if (num <= 6802U)
					{
						if (num == 5234U)
						{
							EDIOJBCALHB ediojbcalhb = new EDIOJBCALHB();
							if (this.actionCase_ == RogueAction.ActionOneofCase.EMCJEPOJPAI)
							{
								ediojbcalhb.MergeFrom(this.EMCJEPOJPAI);
							}
							input.ReadMessage(ediojbcalhb);
							this.EMCJEPOJPAI = ediojbcalhb;
							continue;
						}
						if (num == 6802U)
						{
							RogueBonusSelectInfo rogueBonusSelectInfo = new RogueBonusSelectInfo();
							if (this.actionCase_ == RogueAction.ActionOneofCase.BonusSelectInfo)
							{
								rogueBonusSelectInfo.MergeFrom(this.BonusSelectInfo);
							}
							input.ReadMessage(rogueBonusSelectInfo);
							this.BonusSelectInfo = rogueBonusSelectInfo;
							continue;
						}
					}
					else
					{
						if (num == 6946U)
						{
							PBBBGAMJGID pbbbgamjgid = new PBBBGAMJGID();
							if (this.actionCase_ == RogueAction.ActionOneofCase.IALFJGKDPAK)
							{
								pbbbgamjgid.MergeFrom(this.IALFJGKDPAK);
							}
							input.ReadMessage(pbbbgamjgid);
							this.IALFJGKDPAK = pbbbgamjgid;
							continue;
						}
						if (num == 7154U)
						{
							RogueFormulaSelectInfo rogueFormulaSelectInfo = new RogueFormulaSelectInfo();
							if (this.actionCase_ == RogueAction.ActionOneofCase.RogueFormulaSelectInfo)
							{
								rogueFormulaSelectInfo.MergeFrom(this.RogueFormulaSelectInfo);
							}
							input.ReadMessage(rogueFormulaSelectInfo);
							this.RogueFormulaSelectInfo = rogueFormulaSelectInfo;
							continue;
						}
					}
				}
				else if (num <= 10322U)
				{
					if (num <= 8970U)
					{
						if (num == 7370U)
						{
							CBDOEBJHECH cbdoebjhech = new CBDOEBJHECH();
							if (this.actionCase_ == RogueAction.ActionOneofCase.EDDHKBBHCEN)
							{
								cbdoebjhech.MergeFrom(this.EDDHKBBHCEN);
							}
							input.ReadMessage(cbdoebjhech);
							this.EDDHKBBHCEN = cbdoebjhech;
							continue;
						}
						if (num == 8290U)
						{
							FBGCMFJANMH fbgcmfjanmh = new FBGCMFJANMH();
							if (this.actionCase_ == RogueAction.ActionOneofCase.IEODNFDGPOH)
							{
								fbgcmfjanmh.MergeFrom(this.IEODNFDGPOH);
							}
							input.ReadMessage(fbgcmfjanmh);
							this.IEODNFDGPOH = fbgcmfjanmh;
							continue;
						}
						if (num == 8970U)
						{
							RogueMagicUnitSelectInfo rogueMagicUnitSelectInfo4 = new RogueMagicUnitSelectInfo();
							if (this.actionCase_ == RogueAction.ActionOneofCase.KGICGMLDGHD)
							{
								rogueMagicUnitSelectInfo4.MergeFrom(this.KGICGMLDGHD);
							}
							input.ReadMessage(rogueMagicUnitSelectInfo4);
							this.KGICGMLDGHD = rogueMagicUnitSelectInfo4;
							continue;
						}
					}
					else
					{
						if (num == 9202U)
						{
							EEDHHFNHLBH eedhhfnhlbh = new EEDHHFNHLBH();
							if (this.actionCase_ == RogueAction.ActionOneofCase.MJGMJDLLEJP)
							{
								eedhhfnhlbh.MergeFrom(this.MJGMJDLLEJP);
							}
							input.ReadMessage(eedhhfnhlbh);
							this.MJGMJDLLEJP = eedhhfnhlbh;
							continue;
						}
						if (num == 10082U)
						{
							RogueHexAvatarSelectInfo rogueHexAvatarSelectInfo = new RogueHexAvatarSelectInfo();
							if (this.actionCase_ == RogueAction.ActionOneofCase.HexAvatarSelectInfo)
							{
								rogueHexAvatarSelectInfo.MergeFrom(this.HexAvatarSelectInfo);
							}
							input.ReadMessage(rogueHexAvatarSelectInfo);
							this.HexAvatarSelectInfo = rogueHexAvatarSelectInfo;
							continue;
						}
						if (num == 10322U)
						{
							CBDOEBJHECH cbdoebjhech2 = new CBDOEBJHECH();
							if (this.actionCase_ == RogueAction.ActionOneofCase.KLNIIJKJEKF)
							{
								cbdoebjhech2.MergeFrom(this.KLNIIJKJEKF);
							}
							input.ReadMessage(cbdoebjhech2);
							this.KLNIIJKJEKF = cbdoebjhech2;
							continue;
						}
					}
				}
				else if (num <= 12722U)
				{
					if (num == 11234U)
					{
						JDGBFNHLADP jdgbfnhladp = new JDGBFNHLADP();
						if (this.actionCase_ == RogueAction.ActionOneofCase.KHCBEFJJMPI)
						{
							jdgbfnhladp.MergeFrom(this.KHCBEFJJMPI);
						}
						input.ReadMessage(jdgbfnhladp);
						this.KHCBEFJJMPI = jdgbfnhladp;
						continue;
					}
					if (num == 12626U)
					{
						RogueCommonBuffReforgeSelectInfo rogueCommonBuffReforgeSelectInfo = new RogueCommonBuffReforgeSelectInfo();
						if (this.actionCase_ == RogueAction.ActionOneofCase.BuffReforgeSelectInfo)
						{
							rogueCommonBuffReforgeSelectInfo.MergeFrom(this.BuffReforgeSelectInfo);
						}
						input.ReadMessage(rogueCommonBuffReforgeSelectInfo);
						this.BuffReforgeSelectInfo = rogueCommonBuffReforgeSelectInfo;
						continue;
					}
					if (num == 12722U)
					{
						CBDOEBJHECH cbdoebjhech3 = new CBDOEBJHECH();
						if (this.actionCase_ == RogueAction.ActionOneofCase.MPPOOKADLFL)
						{
							cbdoebjhech3.MergeFrom(this.MPPOOKADLFL);
						}
						input.ReadMessage(cbdoebjhech3);
						this.MPPOOKADLFL = cbdoebjhech3;
						continue;
					}
				}
				else if (num <= 13714U)
				{
					if (num == 13706U)
					{
						BGCNBANPDDM bgcnbanpddm = new BGCNBANPDDM();
						if (this.actionCase_ == RogueAction.ActionOneofCase.PNGAAMIAKAD)
						{
							bgcnbanpddm.MergeFrom(this.PNGAAMIAKAD);
						}
						input.ReadMessage(bgcnbanpddm);
						this.PNGAAMIAKAD = bgcnbanpddm;
						continue;
					}
					if (num == 13714U)
					{
						RogueMiracleSelectInfo rogueMiracleSelectInfo = new RogueMiracleSelectInfo();
						if (this.actionCase_ == RogueAction.ActionOneofCase.MiracleSelectInfo)
						{
							rogueMiracleSelectInfo.MergeFrom(this.MiracleSelectInfo);
						}
						input.ReadMessage(rogueMiracleSelectInfo);
						this.MiracleSelectInfo = rogueMiracleSelectInfo;
						continue;
					}
				}
				else
				{
					if (num == 14618U)
					{
						IMBNANICJLH imbnanicjlh = new IMBNANICJLH();
						if (this.actionCase_ == RogueAction.ActionOneofCase.DFKFJAOMNLP)
						{
							imbnanicjlh.MergeFrom(this.DFKFJAOMNLP);
						}
						input.ReadMessage(imbnanicjlh);
						this.DFKFJAOMNLP = imbnanicjlh;
						continue;
					}
					if (num == 16330U)
					{
						RogueReforgeFormulaSelectInfo rogueReforgeFormulaSelectInfo = new RogueReforgeFormulaSelectInfo();
						if (this.actionCase_ == RogueAction.ActionOneofCase.ReforgeFormulaSelectInfo)
						{
							rogueReforgeFormulaSelectInfo.MergeFrom(this.ReforgeFormulaSelectInfo);
						}
						input.ReadMessage(rogueReforgeFormulaSelectInfo);
						this.ReforgeFormulaSelectInfo = rogueReforgeFormulaSelectInfo;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400413B RID: 16699
		private static readonly MessageParser<RogueAction> _parser = new MessageParser<RogueAction>(() => new RogueAction());

		// Token: 0x0400413C RID: 16700
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400413D RID: 16701
		public const int BuffSelectInfoFieldNumber = 112;

		// Token: 0x0400413E RID: 16702
		public const int DFKFJAOMNLPFieldNumber = 1827;

		// Token: 0x0400413F RID: 16703
		public const int EMCJEPOJPAIFieldNumber = 654;

		// Token: 0x04004140 RID: 16704
		public const int BuffReforgeSelectInfoFieldNumber = 1578;

		// Token: 0x04004141 RID: 16705
		public const int MiracleSelectInfoFieldNumber = 1714;

		// Token: 0x04004142 RID: 16706
		public const int BCHBIBOMEPEFieldNumber = 571;

		// Token: 0x04004143 RID: 16707
		public const int IALFJGKDPAKFieldNumber = 868;

		// Token: 0x04004144 RID: 16708
		public const int IEODNFDGPOHFieldNumber = 1036;

		// Token: 0x04004145 RID: 16709
		public const int KFMEODPLFIKFieldNumber = 557;

		// Token: 0x04004146 RID: 16710
		public const int MJGMJDLLEJPFieldNumber = 1150;

		// Token: 0x04004147 RID: 16711
		public const int ComposeMiracleSelectInfoFieldNumber = 57;

		// Token: 0x04004148 RID: 16712
		public const int HexAvatarSelectInfoFieldNumber = 1260;

		// Token: 0x04004149 RID: 16713
		public const int BonusSelectInfoFieldNumber = 850;

		// Token: 0x0400414A RID: 16714
		public const int RogueFormulaSelectInfoFieldNumber = 894;

		// Token: 0x0400414B RID: 16715
		public const int PNGAAMIAKADFieldNumber = 1713;

		// Token: 0x0400414C RID: 16716
		public const int ReforgeFormulaSelectInfoFieldNumber = 2041;

		// Token: 0x0400414D RID: 16717
		public const int MagicUnitSelectInfoFieldNumber = 50;

		// Token: 0x0400414E RID: 16718
		public const int ScepterSelectInfoFieldNumber = 268;

		// Token: 0x0400414F RID: 16719
		public const int KHCBEFJJMPIFieldNumber = 1404;

		// Token: 0x04004150 RID: 16720
		public const int KGFLENGNFNPFieldNumber = 424;

		// Token: 0x04004151 RID: 16721
		public const int KGICGMLDGHDFieldNumber = 1121;

		// Token: 0x04004152 RID: 16722
		public const int EHIHHECNPGNFieldNumber = 431;

		// Token: 0x04004153 RID: 16723
		public const int MPPOOKADLFLFieldNumber = 1590;

		// Token: 0x04004154 RID: 16724
		public const int EDDHKBBHCENFieldNumber = 921;

		// Token: 0x04004155 RID: 16725
		public const int KLNIIJKJEKFFieldNumber = 1290;

		// Token: 0x04004156 RID: 16726
		public const int KEBOMHDMCEAFieldNumber = 463;

		// Token: 0x04004157 RID: 16727
		private object action_;

		// Token: 0x04004158 RID: 16728
		private RogueAction.ActionOneofCase actionCase_;

		// Token: 0x02001ADD RID: 6877
		public enum ActionOneofCase
		{
			// Token: 0x040062CE RID: 25294
			None,
			// Token: 0x040062CF RID: 25295
			BuffSelectInfo = 112,
			// Token: 0x040062D0 RID: 25296
			DFKFJAOMNLP = 1827,
			// Token: 0x040062D1 RID: 25297
			EMCJEPOJPAI = 654,
			// Token: 0x040062D2 RID: 25298
			BuffReforgeSelectInfo = 1578,
			// Token: 0x040062D3 RID: 25299
			MiracleSelectInfo = 1714,
			// Token: 0x040062D4 RID: 25300
			BCHBIBOMEPE = 571,
			// Token: 0x040062D5 RID: 25301
			IALFJGKDPAK = 868,
			// Token: 0x040062D6 RID: 25302
			IEODNFDGPOH = 1036,
			// Token: 0x040062D7 RID: 25303
			KFMEODPLFIK = 557,
			// Token: 0x040062D8 RID: 25304
			MJGMJDLLEJP = 1150,
			// Token: 0x040062D9 RID: 25305
			ComposeMiracleSelectInfo = 57,
			// Token: 0x040062DA RID: 25306
			HexAvatarSelectInfo = 1260,
			// Token: 0x040062DB RID: 25307
			BonusSelectInfo = 850,
			// Token: 0x040062DC RID: 25308
			RogueFormulaSelectInfo = 894,
			// Token: 0x040062DD RID: 25309
			PNGAAMIAKAD = 1713,
			// Token: 0x040062DE RID: 25310
			ReforgeFormulaSelectInfo = 2041,
			// Token: 0x040062DF RID: 25311
			MagicUnitSelectInfo = 50,
			// Token: 0x040062E0 RID: 25312
			ScepterSelectInfo = 268,
			// Token: 0x040062E1 RID: 25313
			KHCBEFJJMPI = 1404,
			// Token: 0x040062E2 RID: 25314
			KGFLENGNFNP = 424,
			// Token: 0x040062E3 RID: 25315
			KGICGMLDGHD = 1121,
			// Token: 0x040062E4 RID: 25316
			EHIHHECNPGN = 431,
			// Token: 0x040062E5 RID: 25317
			MPPOOKADLFL = 1590,
			// Token: 0x040062E6 RID: 25318
			EDDHKBBHCEN = 921,
			// Token: 0x040062E7 RID: 25319
			KLNIIJKJEKF = 1290,
			// Token: 0x040062E8 RID: 25320
			KEBOMHDMCEA = 463
		}
	}
}
