using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E31 RID: 3633
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonActionResultData : IMessage<RogueCommonActionResultData>, IMessage, IEquatable<RogueCommonActionResultData>, IDeepCloneable<RogueCommonActionResultData>, IBufferMessage
	{
		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x0600A203 RID: 41475 RVA: 0x001B20F9 File Offset: 0x001B02F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonActionResultData> Parser
		{
			get
			{
				return RogueCommonActionResultData._parser;
			}
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x0600A204 RID: 41476 RVA: 0x001B2100 File Offset: 0x001B0300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonActionResultDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x0600A205 RID: 41477 RVA: 0x001B2112 File Offset: 0x001B0312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonActionResultData.Descriptor;
			}
		}

		// Token: 0x0600A206 RID: 41478 RVA: 0x001B2119 File Offset: 0x001B0319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonActionResultData()
		{
		}

		// Token: 0x0600A207 RID: 41479 RVA: 0x001B2124 File Offset: 0x001B0324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonActionResultData(RogueCommonActionResultData other) : this()
		{
			RogueCommonActionResultData.ResultDataOneofCase resultDataCase = other.ResultDataCase;
			if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.GetMiracleList)
			{
				if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.OCMBNDKBAPI)
				{
					if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.ExpandFormulaList)
					{
						if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.RemoveItemList)
						{
							if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.GetItemList)
							{
								if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.ExpandFormulaList)
								{
									this.ExpandFormulaList = other.ExpandFormulaList.Clone();
								}
							}
							else
							{
								this.GetItemList = other.GetItemList.Clone();
							}
						}
						else
						{
							this.RemoveItemList = other.RemoveItemList.Clone();
						}
					}
					else if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.GetBuffList)
					{
						if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.RemoveBuffList)
						{
							if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.OCMBNDKBAPI)
							{
								this.OCMBNDKBAPI = other.OCMBNDKBAPI.Clone();
							}
						}
						else
						{
							this.RemoveBuffList = other.RemoveBuffList.Clone();
						}
					}
					else
					{
						this.GetBuffList = other.GetBuffList.Clone();
					}
				}
				else if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.ELOANPJBFJH)
				{
					if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.RemoveFormulaList)
					{
						if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE)
						{
							if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.ELOANPJBFJH)
							{
								this.ELOANPJBFJH = other.ELOANPJBFJH.Clone();
							}
						}
						else
						{
							this.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE = other.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE.Clone();
						}
					}
					else
					{
						this.RemoveFormulaList = other.RemoveFormulaList.Clone();
					}
				}
				else if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.DressScepterList)
				{
					if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.GetMagicUnitList)
					{
						if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.DressScepterList)
						{
							this.DressScepterList = other.DressScepterList.Clone();
						}
					}
					else
					{
						this.GetMagicUnitList = other.GetMagicUnitList.Clone();
					}
				}
				else if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.FGMCCFFGFFK)
				{
					if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.GetMiracleList)
					{
						this.GetMiracleList = other.GetMiracleList.Clone();
					}
				}
				else
				{
					this.FGMCCFFGFFK = other.FGMCCFFGFFK.Clone();
				}
			}
			else if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.RemoveMiracleList)
			{
				if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.RemoveKeywordList)
				{
					if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.BJMFLAFIKJB)
					{
						if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.GetScepterList)
						{
							if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.RemoveKeywordList)
							{
								this.RemoveKeywordList = other.RemoveKeywordList.Clone();
							}
						}
						else
						{
							this.GetScepterList = other.GetScepterList.Clone();
						}
					}
					else
					{
						this.BJMFLAFIKJB = other.BJMFLAFIKJB.Clone();
					}
				}
				else if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.DNICOFFFDEJ)
				{
					if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.MAFECNCNOCB)
					{
						if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.RemoveMiracleList)
						{
							this.RemoveMiracleList = other.RemoveMiracleList.Clone();
						}
					}
					else
					{
						this.MAFECNCNOCB = other.MAFECNCNOCB.Clone();
					}
				}
				else
				{
					this.DNICOFFFDEJ = other.DNICOFFFDEJ.Clone();
				}
			}
			else if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.ContractFormulaList)
			{
				if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.HBPPAPIOFBC)
				{
					if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.POCBCJLLGAB)
					{
						if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.ContractFormulaList)
						{
							this.ContractFormulaList = other.ContractFormulaList.Clone();
						}
					}
					else
					{
						this.POCBCJLLGAB = other.POCBCJLLGAB.Clone();
					}
				}
				else
				{
					this.HBPPAPIOFBC = other.HBPPAPIOFBC.Clone();
				}
			}
			else if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.GetFormulaList)
			{
				if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.GetKeywordList)
				{
					if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.GetFormulaList)
					{
						this.GetFormulaList = other.GetFormulaList.Clone();
					}
				}
				else
				{
					this.GetKeywordList = other.GetKeywordList.Clone();
				}
			}
			else if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.RemoveMagicUnitList)
			{
				if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.PathBuffList)
				{
					this.PathBuffList = other.PathBuffList.Clone();
				}
			}
			else
			{
				this.RemoveMagicUnitList = other.RemoveMagicUnitList.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A208 RID: 41480 RVA: 0x001B2500 File Offset: 0x001B0700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonActionResultData Clone()
		{
			return new RogueCommonActionResultData(this);
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x0600A209 RID: 41481 RVA: 0x001B2508 File Offset: 0x001B0708
		// (set) Token: 0x0600A20A RID: 41482 RVA: 0x001B2521 File Offset: 0x001B0721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonMoney GetItemList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.GetItemList)
				{
					return null;
				}
				return (RogueCommonMoney)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.GetItemList);
			}
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x0600A20B RID: 41483 RVA: 0x001B2538 File Offset: 0x001B0738
		// (set) Token: 0x0600A20C RID: 41484 RVA: 0x001B2551 File Offset: 0x001B0751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonMoney RemoveItemList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.RemoveItemList)
				{
					return null;
				}
				return (RogueCommonMoney)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.RemoveItemList);
			}
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x0600A20D RID: 41485 RVA: 0x001B2568 File Offset: 0x001B0768
		// (set) Token: 0x0600A20E RID: 41486 RVA: 0x001B2581 File Offset: 0x001B0781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuff GetBuffList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.GetBuffList)
				{
					return null;
				}
				return (RogueCommonBuff)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.GetBuffList);
			}
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x0600A20F RID: 41487 RVA: 0x001B2598 File Offset: 0x001B0798
		// (set) Token: 0x0600A210 RID: 41488 RVA: 0x001B25B4 File Offset: 0x001B07B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuff RemoveBuffList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.RemoveBuffList)
				{
					return null;
				}
				return (RogueCommonBuff)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.RemoveBuffList);
			}
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x0600A211 RID: 41489 RVA: 0x001B25CE File Offset: 0x001B07CE
		// (set) Token: 0x0600A212 RID: 41490 RVA: 0x001B25EA File Offset: 0x001B07EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonMiracle GetMiracleList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.GetMiracleList)
				{
					return null;
				}
				return (RogueCommonMiracle)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.GetMiracleList);
			}
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x0600A213 RID: 41491 RVA: 0x001B2604 File Offset: 0x001B0804
		// (set) Token: 0x0600A214 RID: 41492 RVA: 0x001B2620 File Offset: 0x001B0820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveMiracle RemoveMiracleList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.RemoveMiracleList)
				{
					return null;
				}
				return (RogueCommonRemoveMiracle)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.RemoveMiracleList);
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x0600A215 RID: 41493 RVA: 0x001B263A File Offset: 0x001B083A
		// (set) Token: 0x0600A216 RID: 41494 RVA: 0x001B2656 File Offset: 0x001B0856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EKKHDLKGMDH HBPPAPIOFBC
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.HBPPAPIOFBC)
				{
					return null;
				}
				return (EKKHDLKGMDH)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.HBPPAPIOFBC);
			}
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x0600A217 RID: 41495 RVA: 0x001B2670 File Offset: 0x001B0870
		// (set) Token: 0x0600A218 RID: 41496 RVA: 0x001B268C File Offset: 0x001B088C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HIEBMNLCFBB POCBCJLLGAB
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.POCBCJLLGAB)
				{
					return null;
				}
				return (HIEBMNLCFBB)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.POCBCJLLGAB);
			}
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x0600A219 RID: 41497 RVA: 0x001B26A6 File Offset: 0x001B08A6
		// (set) Token: 0x0600A21A RID: 41498 RVA: 0x001B26C2 File Offset: 0x001B08C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJFBDHHDPOM FGMCCFFGFFK
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.FGMCCFFGFFK)
				{
					return null;
				}
				return (LJFBDHHDPOM)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.FGMCCFFGFFK);
			}
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x0600A21B RID: 41499 RVA: 0x001B26DC File Offset: 0x001B08DC
		// (set) Token: 0x0600A21C RID: 41500 RVA: 0x001B26F8 File Offset: 0x001B08F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NPGDAKGFGJO DNICOFFFDEJ
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.DNICOFFFDEJ)
				{
					return null;
				}
				return (NPGDAKGFGJO)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.DNICOFFFDEJ);
			}
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x0600A21D RID: 41501 RVA: 0x001B2712 File Offset: 0x001B0912
		// (set) Token: 0x0600A21E RID: 41502 RVA: 0x001B272E File Offset: 0x001B092E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CGHBMKAAOGP ELOANPJBFJH
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.ELOANPJBFJH)
				{
					return null;
				}
				return (CGHBMKAAOGP)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.ELOANPJBFJH);
			}
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x0600A21F RID: 41503 RVA: 0x001B2748 File Offset: 0x001B0948
		// (set) Token: 0x0600A220 RID: 41504 RVA: 0x001B2764 File Offset: 0x001B0964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonFormula GetFormulaList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.GetFormulaList)
				{
					return null;
				}
				return (RogueCommonFormula)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.GetFormulaList);
			}
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x0600A221 RID: 41505 RVA: 0x001B277E File Offset: 0x001B097E
		// (set) Token: 0x0600A222 RID: 41506 RVA: 0x001B279A File Offset: 0x001B099A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveFormula RemoveFormulaList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.RemoveFormulaList)
				{
					return null;
				}
				return (RogueCommonRemoveFormula)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.RemoveFormulaList);
			}
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0600A223 RID: 41507 RVA: 0x001B27B4 File Offset: 0x001B09B4
		// (set) Token: 0x0600A224 RID: 41508 RVA: 0x001B27CD File Offset: 0x001B09CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonExpandedFormula ExpandFormulaList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.ExpandFormulaList)
				{
					return null;
				}
				return (RogueCommonExpandedFormula)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.ExpandFormulaList);
			}
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x0600A225 RID: 41509 RVA: 0x001B27E4 File Offset: 0x001B09E4
		// (set) Token: 0x0600A226 RID: 41510 RVA: 0x001B2800 File Offset: 0x001B0A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonContractFormula ContractFormulaList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.ContractFormulaList)
				{
					return null;
				}
				return (RogueCommonContractFormula)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.ContractFormulaList);
			}
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x0600A227 RID: 41511 RVA: 0x001B281A File Offset: 0x001B0A1A
		// (set) Token: 0x0600A228 RID: 41512 RVA: 0x001B2836 File Offset: 0x001B0A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPathBuff PathBuffList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.PathBuffList)
				{
					return null;
				}
				return (RogueCommonPathBuff)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.PathBuffList);
			}
		}

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x0600A229 RID: 41513 RVA: 0x001B2850 File Offset: 0x001B0A50
		// (set) Token: 0x0600A22A RID: 41514 RVA: 0x001B286C File Offset: 0x001B0A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonKeyword GetKeywordList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.GetKeywordList)
				{
					return null;
				}
				return (RogueCommonKeyword)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.GetKeywordList);
			}
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x0600A22B RID: 41515 RVA: 0x001B2886 File Offset: 0x001B0A86
		// (set) Token: 0x0600A22C RID: 41516 RVA: 0x001B28A2 File Offset: 0x001B0AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveKeyword RemoveKeywordList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.RemoveKeywordList)
				{
					return null;
				}
				return (RogueCommonRemoveKeyword)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.RemoveKeywordList);
			}
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x0600A22D RID: 41517 RVA: 0x001B28BC File Offset: 0x001B0ABC
		// (set) Token: 0x0600A22E RID: 41518 RVA: 0x001B28D8 File Offset: 0x001B0AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDressScepter DressScepterList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.DressScepterList)
				{
					return null;
				}
				return (RogueCommonDressScepter)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.DressScepterList);
			}
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x0600A22F RID: 41519 RVA: 0x001B28F2 File Offset: 0x001B0AF2
		// (set) Token: 0x0600A230 RID: 41520 RVA: 0x001B290E File Offset: 0x001B0B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonGetScepter GetScepterList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.GetScepterList)
				{
					return null;
				}
				return (RogueCommonGetScepter)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.GetScepterList);
			}
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x0600A231 RID: 41521 RVA: 0x001B2928 File Offset: 0x001B0B28
		// (set) Token: 0x0600A232 RID: 41522 RVA: 0x001B2944 File Offset: 0x001B0B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCBIADHLKGN BJMFLAFIKJB
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.BJMFLAFIKJB)
				{
					return null;
				}
				return (NCBIADHLKGN)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.BJMFLAFIKJB);
			}
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x0600A233 RID: 41523 RVA: 0x001B295E File Offset: 0x001B0B5E
		// (set) Token: 0x0600A234 RID: 41524 RVA: 0x001B297A File Offset: 0x001B0B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnitInfo GetMagicUnitList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.GetMagicUnitList)
				{
					return null;
				}
				return (RogueMagicGameUnitInfo)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.GetMagicUnitList);
			}
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x0600A235 RID: 41525 RVA: 0x001B2994 File Offset: 0x001B0B94
		// (set) Token: 0x0600A236 RID: 41526 RVA: 0x001B29B0 File Offset: 0x001B0BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnitInfo RemoveMagicUnitList
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.RemoveMagicUnitList)
				{
					return null;
				}
				return (RogueMagicGameUnitInfo)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.RemoveMagicUnitList);
			}
		}

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x0600A237 RID: 41527 RVA: 0x001B29CA File Offset: 0x001B0BCA
		// (set) Token: 0x0600A238 RID: 41528 RVA: 0x001B29E6 File Offset: 0x001B0BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnitInfo OCMBNDKBAPI
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.OCMBNDKBAPI)
				{
					return null;
				}
				return (RogueMagicGameUnitInfo)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.OCMBNDKBAPI);
			}
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x0600A239 RID: 41529 RVA: 0x001B2A00 File Offset: 0x001B0C00
		// (set) Token: 0x0600A23A RID: 41530 RVA: 0x001B2A1C File Offset: 0x001B0C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameScepterInfo MAFECNCNOCB
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.MAFECNCNOCB)
				{
					return null;
				}
				return (RogueMagicGameScepterInfo)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.MAFECNCNOCB);
			}
		}

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x0600A23B RID: 41531 RVA: 0x001B2A36 File Offset: 0x001B0C36
		// (set) Token: 0x0600A23C RID: 41532 RVA: 0x001B2A52 File Offset: 0x001B0C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICPOMOHLCMD ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE
		{
			get
			{
				if (this.resultDataCase_ != RogueCommonActionResultData.ResultDataOneofCase.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE)
				{
					return null;
				}
				return (ICPOMOHLCMD)this.resultData_;
			}
			set
			{
				this.resultData_ = value;
				this.resultDataCase_ = ((value == null) ? RogueCommonActionResultData.ResultDataOneofCase.None : RogueCommonActionResultData.ResultDataOneofCase.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE);
			}
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x0600A23D RID: 41533 RVA: 0x001B2A6C File Offset: 0x001B0C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonActionResultData.ResultDataOneofCase ResultDataCase
		{
			get
			{
				return this.resultDataCase_;
			}
		}

		// Token: 0x0600A23E RID: 41534 RVA: 0x001B2A74 File Offset: 0x001B0C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearResultData()
		{
			this.resultDataCase_ = RogueCommonActionResultData.ResultDataOneofCase.None;
			this.resultData_ = null;
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x001B2A84 File Offset: 0x001B0C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonActionResultData);
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x001B2A94 File Offset: 0x001B0C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonActionResultData other)
		{
			return other != null && (other == this || (object.Equals(this.GetItemList, other.GetItemList) && object.Equals(this.RemoveItemList, other.RemoveItemList) && object.Equals(this.GetBuffList, other.GetBuffList) && object.Equals(this.RemoveBuffList, other.RemoveBuffList) && object.Equals(this.GetMiracleList, other.GetMiracleList) && object.Equals(this.RemoveMiracleList, other.RemoveMiracleList) && object.Equals(this.HBPPAPIOFBC, other.HBPPAPIOFBC) && object.Equals(this.POCBCJLLGAB, other.POCBCJLLGAB) && object.Equals(this.FGMCCFFGFFK, other.FGMCCFFGFFK) && object.Equals(this.DNICOFFFDEJ, other.DNICOFFFDEJ) && object.Equals(this.ELOANPJBFJH, other.ELOANPJBFJH) && object.Equals(this.GetFormulaList, other.GetFormulaList) && object.Equals(this.RemoveFormulaList, other.RemoveFormulaList) && object.Equals(this.ExpandFormulaList, other.ExpandFormulaList) && object.Equals(this.ContractFormulaList, other.ContractFormulaList) && object.Equals(this.PathBuffList, other.PathBuffList) && object.Equals(this.GetKeywordList, other.GetKeywordList) && object.Equals(this.RemoveKeywordList, other.RemoveKeywordList) && object.Equals(this.DressScepterList, other.DressScepterList) && object.Equals(this.GetScepterList, other.GetScepterList) && object.Equals(this.BJMFLAFIKJB, other.BJMFLAFIKJB) && object.Equals(this.GetMagicUnitList, other.GetMagicUnitList) && object.Equals(this.RemoveMagicUnitList, other.RemoveMagicUnitList) && object.Equals(this.OCMBNDKBAPI, other.OCMBNDKBAPI) && object.Equals(this.MAFECNCNOCB, other.MAFECNCNOCB) && object.Equals(this.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE, other.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE) && this.ResultDataCase == other.ResultDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x001B2CF0 File Offset: 0x001B0EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetItemList)
			{
				num ^= this.GetItemList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveItemList)
			{
				num ^= this.RemoveItemList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetBuffList)
			{
				num ^= this.GetBuffList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveBuffList)
			{
				num ^= this.RemoveBuffList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetMiracleList)
			{
				num ^= this.GetMiracleList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveMiracleList)
			{
				num ^= this.RemoveMiracleList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.HBPPAPIOFBC)
			{
				num ^= this.HBPPAPIOFBC.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.POCBCJLLGAB)
			{
				num ^= this.POCBCJLLGAB.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.FGMCCFFGFFK)
			{
				num ^= this.FGMCCFFGFFK.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.DNICOFFFDEJ)
			{
				num ^= this.DNICOFFFDEJ.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ELOANPJBFJH)
			{
				num ^= this.ELOANPJBFJH.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetFormulaList)
			{
				num ^= this.GetFormulaList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveFormulaList)
			{
				num ^= this.RemoveFormulaList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ExpandFormulaList)
			{
				num ^= this.ExpandFormulaList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ContractFormulaList)
			{
				num ^= this.ContractFormulaList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.PathBuffList)
			{
				num ^= this.PathBuffList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetKeywordList)
			{
				num ^= this.GetKeywordList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveKeywordList)
			{
				num ^= this.RemoveKeywordList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.DressScepterList)
			{
				num ^= this.DressScepterList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetScepterList)
			{
				num ^= this.GetScepterList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.BJMFLAFIKJB)
			{
				num ^= this.BJMFLAFIKJB.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetMagicUnitList)
			{
				num ^= this.GetMagicUnitList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveMagicUnitList)
			{
				num ^= this.RemoveMagicUnitList.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.OCMBNDKBAPI)
			{
				num ^= this.OCMBNDKBAPI.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.MAFECNCNOCB)
			{
				num ^= this.MAFECNCNOCB.GetHashCode();
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE)
			{
				num ^= this.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE.GetHashCode();
			}
			num ^= (int)this.resultDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x001B2FD1 File Offset: 0x001B11D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x001B2FD9 File Offset: 0x001B11D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x001B2FE4 File Offset: 0x001B11E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveItemList)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RemoveItemList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetItemList)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.GetItemList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ExpandFormulaList)
			{
				output.WriteRawTag(138, 4);
				output.WriteMessage(this.ExpandFormulaList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetBuffList)
			{
				output.WriteRawTag(138, 6);
				output.WriteMessage(this.GetBuffList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveBuffList)
			{
				output.WriteRawTag(210, 9);
				output.WriteMessage(this.RemoveBuffList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.OCMBNDKBAPI)
			{
				output.WriteRawTag(162, 17);
				output.WriteMessage(this.OCMBNDKBAPI);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveFormulaList)
			{
				output.WriteRawTag(194, 18);
				output.WriteMessage(this.RemoveFormulaList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE)
			{
				output.WriteRawTag(186, 32);
				output.WriteMessage(this.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ELOANPJBFJH)
			{
				output.WriteRawTag(170, 37);
				output.WriteMessage(this.ELOANPJBFJH);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetMagicUnitList)
			{
				output.WriteRawTag(202, 48);
				output.WriteMessage(this.GetMagicUnitList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.DressScepterList)
			{
				output.WriteRawTag(154, 54);
				output.WriteMessage(this.DressScepterList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.FGMCCFFGFFK)
			{
				output.WriteRawTag(170, 58);
				output.WriteMessage(this.FGMCCFFGFFK);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetMiracleList)
			{
				output.WriteRawTag(130, 65);
				output.WriteMessage(this.GetMiracleList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.BJMFLAFIKJB)
			{
				output.WriteRawTag(250, 70);
				output.WriteMessage(this.BJMFLAFIKJB);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetScepterList)
			{
				output.WriteRawTag(218, 74);
				output.WriteMessage(this.GetScepterList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveKeywordList)
			{
				output.WriteRawTag(194, 82);
				output.WriteMessage(this.RemoveKeywordList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.DNICOFFFDEJ)
			{
				output.WriteRawTag(170, 84);
				output.WriteMessage(this.DNICOFFFDEJ);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.MAFECNCNOCB)
			{
				output.WriteRawTag(146, 91);
				output.WriteMessage(this.MAFECNCNOCB);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveMiracleList)
			{
				output.WriteRawTag(242, 100);
				output.WriteMessage(this.RemoveMiracleList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.HBPPAPIOFBC)
			{
				output.WriteRawTag(170, 101);
				output.WriteMessage(this.HBPPAPIOFBC);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.POCBCJLLGAB)
			{
				output.WriteRawTag(178, 117);
				output.WriteMessage(this.POCBCJLLGAB);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ContractFormulaList)
			{
				output.WriteRawTag(130, 119);
				output.WriteMessage(this.ContractFormulaList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetKeywordList)
			{
				output.WriteRawTag(218, 120);
				output.WriteMessage(this.GetKeywordList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetFormulaList)
			{
				output.WriteRawTag(210, 121);
				output.WriteMessage(this.GetFormulaList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveMagicUnitList)
			{
				output.WriteRawTag(138, 123);
				output.WriteMessage(this.RemoveMagicUnitList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.PathBuffList)
			{
				output.WriteRawTag(154, 123);
				output.WriteMessage(this.PathBuffList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A245 RID: 41541 RVA: 0x001B33CC File Offset: 0x001B15CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetItemList)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GetItemList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveItemList)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemoveItemList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetBuffList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GetBuffList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveBuffList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RemoveBuffList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetMiracleList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GetMiracleList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveMiracleList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RemoveMiracleList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.HBPPAPIOFBC)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HBPPAPIOFBC);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.POCBCJLLGAB)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.POCBCJLLGAB);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.FGMCCFFGFFK)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FGMCCFFGFFK);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.DNICOFFFDEJ)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DNICOFFFDEJ);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ELOANPJBFJH)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ELOANPJBFJH);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetFormulaList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GetFormulaList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveFormulaList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RemoveFormulaList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ExpandFormulaList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExpandFormulaList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ContractFormulaList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ContractFormulaList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.PathBuffList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PathBuffList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetKeywordList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GetKeywordList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveKeywordList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RemoveKeywordList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.DressScepterList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DressScepterList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetScepterList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GetScepterList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.BJMFLAFIKJB)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BJMFLAFIKJB);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetMagicUnitList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GetMagicUnitList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveMagicUnitList)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RemoveMagicUnitList);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.OCMBNDKBAPI)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OCMBNDKBAPI);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.MAFECNCNOCB)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MAFECNCNOCB);
			}
			if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A246 RID: 41542 RVA: 0x001B36D8 File Offset: 0x001B18D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonActionResultData other)
		{
			if (other == null)
			{
				return;
			}
			RogueCommonActionResultData.ResultDataOneofCase resultDataCase = other.ResultDataCase;
			if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.GetMiracleList)
			{
				if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.OCMBNDKBAPI)
				{
					if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.ExpandFormulaList)
					{
						if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.RemoveItemList)
						{
							if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.GetItemList)
							{
								if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.ExpandFormulaList)
								{
									if (this.ExpandFormulaList == null)
									{
										this.ExpandFormulaList = new RogueCommonExpandedFormula();
									}
									this.ExpandFormulaList.MergeFrom(other.ExpandFormulaList);
								}
							}
							else
							{
								if (this.GetItemList == null)
								{
									this.GetItemList = new RogueCommonMoney();
								}
								this.GetItemList.MergeFrom(other.GetItemList);
							}
						}
						else
						{
							if (this.RemoveItemList == null)
							{
								this.RemoveItemList = new RogueCommonMoney();
							}
							this.RemoveItemList.MergeFrom(other.RemoveItemList);
						}
					}
					else if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.GetBuffList)
					{
						if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.RemoveBuffList)
						{
							if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.OCMBNDKBAPI)
							{
								if (this.OCMBNDKBAPI == null)
								{
									this.OCMBNDKBAPI = new RogueMagicGameUnitInfo();
								}
								this.OCMBNDKBAPI.MergeFrom(other.OCMBNDKBAPI);
							}
						}
						else
						{
							if (this.RemoveBuffList == null)
							{
								this.RemoveBuffList = new RogueCommonBuff();
							}
							this.RemoveBuffList.MergeFrom(other.RemoveBuffList);
						}
					}
					else
					{
						if (this.GetBuffList == null)
						{
							this.GetBuffList = new RogueCommonBuff();
						}
						this.GetBuffList.MergeFrom(other.GetBuffList);
					}
				}
				else if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.ELOANPJBFJH)
				{
					if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.RemoveFormulaList)
					{
						if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE)
						{
							if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.ELOANPJBFJH)
							{
								if (this.ELOANPJBFJH == null)
								{
									this.ELOANPJBFJH = new CGHBMKAAOGP();
								}
								this.ELOANPJBFJH.MergeFrom(other.ELOANPJBFJH);
							}
						}
						else
						{
							if (this.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE == null)
							{
								this.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE = new ICPOMOHLCMD();
							}
							this.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE.MergeFrom(other.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE);
						}
					}
					else
					{
						if (this.RemoveFormulaList == null)
						{
							this.RemoveFormulaList = new RogueCommonRemoveFormula();
						}
						this.RemoveFormulaList.MergeFrom(other.RemoveFormulaList);
					}
				}
				else if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.DressScepterList)
				{
					if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.GetMagicUnitList)
					{
						if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.DressScepterList)
						{
							if (this.DressScepterList == null)
							{
								this.DressScepterList = new RogueCommonDressScepter();
							}
							this.DressScepterList.MergeFrom(other.DressScepterList);
						}
					}
					else
					{
						if (this.GetMagicUnitList == null)
						{
							this.GetMagicUnitList = new RogueMagicGameUnitInfo();
						}
						this.GetMagicUnitList.MergeFrom(other.GetMagicUnitList);
					}
				}
				else if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.FGMCCFFGFFK)
				{
					if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.GetMiracleList)
					{
						if (this.GetMiracleList == null)
						{
							this.GetMiracleList = new RogueCommonMiracle();
						}
						this.GetMiracleList.MergeFrom(other.GetMiracleList);
					}
				}
				else
				{
					if (this.FGMCCFFGFFK == null)
					{
						this.FGMCCFFGFFK = new LJFBDHHDPOM();
					}
					this.FGMCCFFGFFK.MergeFrom(other.FGMCCFFGFFK);
				}
			}
			else if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.RemoveMiracleList)
			{
				if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.RemoveKeywordList)
				{
					if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.BJMFLAFIKJB)
					{
						if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.GetScepterList)
						{
							if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.RemoveKeywordList)
							{
								if (this.RemoveKeywordList == null)
								{
									this.RemoveKeywordList = new RogueCommonRemoveKeyword();
								}
								this.RemoveKeywordList.MergeFrom(other.RemoveKeywordList);
							}
						}
						else
						{
							if (this.GetScepterList == null)
							{
								this.GetScepterList = new RogueCommonGetScepter();
							}
							this.GetScepterList.MergeFrom(other.GetScepterList);
						}
					}
					else
					{
						if (this.BJMFLAFIKJB == null)
						{
							this.BJMFLAFIKJB = new NCBIADHLKGN();
						}
						this.BJMFLAFIKJB.MergeFrom(other.BJMFLAFIKJB);
					}
				}
				else if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.DNICOFFFDEJ)
				{
					if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.MAFECNCNOCB)
					{
						if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.RemoveMiracleList)
						{
							if (this.RemoveMiracleList == null)
							{
								this.RemoveMiracleList = new RogueCommonRemoveMiracle();
							}
							this.RemoveMiracleList.MergeFrom(other.RemoveMiracleList);
						}
					}
					else
					{
						if (this.MAFECNCNOCB == null)
						{
							this.MAFECNCNOCB = new RogueMagicGameScepterInfo();
						}
						this.MAFECNCNOCB.MergeFrom(other.MAFECNCNOCB);
					}
				}
				else
				{
					if (this.DNICOFFFDEJ == null)
					{
						this.DNICOFFFDEJ = new NPGDAKGFGJO();
					}
					this.DNICOFFFDEJ.MergeFrom(other.DNICOFFFDEJ);
				}
			}
			else if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.ContractFormulaList)
			{
				if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.HBPPAPIOFBC)
				{
					if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.POCBCJLLGAB)
					{
						if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.ContractFormulaList)
						{
							if (this.ContractFormulaList == null)
							{
								this.ContractFormulaList = new RogueCommonContractFormula();
							}
							this.ContractFormulaList.MergeFrom(other.ContractFormulaList);
						}
					}
					else
					{
						if (this.POCBCJLLGAB == null)
						{
							this.POCBCJLLGAB = new HIEBMNLCFBB();
						}
						this.POCBCJLLGAB.MergeFrom(other.POCBCJLLGAB);
					}
				}
				else
				{
					if (this.HBPPAPIOFBC == null)
					{
						this.HBPPAPIOFBC = new EKKHDLKGMDH();
					}
					this.HBPPAPIOFBC.MergeFrom(other.HBPPAPIOFBC);
				}
			}
			else if (resultDataCase <= RogueCommonActionResultData.ResultDataOneofCase.GetFormulaList)
			{
				if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.GetKeywordList)
				{
					if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.GetFormulaList)
					{
						if (this.GetFormulaList == null)
						{
							this.GetFormulaList = new RogueCommonFormula();
						}
						this.GetFormulaList.MergeFrom(other.GetFormulaList);
					}
				}
				else
				{
					if (this.GetKeywordList == null)
					{
						this.GetKeywordList = new RogueCommonKeyword();
					}
					this.GetKeywordList.MergeFrom(other.GetKeywordList);
				}
			}
			else if (resultDataCase != RogueCommonActionResultData.ResultDataOneofCase.RemoveMagicUnitList)
			{
				if (resultDataCase == RogueCommonActionResultData.ResultDataOneofCase.PathBuffList)
				{
					if (this.PathBuffList == null)
					{
						this.PathBuffList = new RogueCommonPathBuff();
					}
					this.PathBuffList.MergeFrom(other.PathBuffList);
				}
			}
			else
			{
				if (this.RemoveMagicUnitList == null)
				{
					this.RemoveMagicUnitList = new RogueMagicGameUnitInfo();
				}
				this.RemoveMagicUnitList.MergeFrom(other.RemoveMagicUnitList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A247 RID: 41543 RVA: 0x001B3CAF File Offset: 0x001B1EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A248 RID: 41544 RVA: 0x001B3CB8 File Offset: 0x001B1EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 8322U)
				{
					if (num <= 2210U)
					{
						if (num <= 522U)
						{
							if (num == 74U)
							{
								RogueCommonMoney rogueCommonMoney = new RogueCommonMoney();
								if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveItemList)
								{
									rogueCommonMoney.MergeFrom(this.RemoveItemList);
								}
								input.ReadMessage(rogueCommonMoney);
								this.RemoveItemList = rogueCommonMoney;
								continue;
							}
							if (num == 114U)
							{
								RogueCommonMoney rogueCommonMoney2 = new RogueCommonMoney();
								if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetItemList)
								{
									rogueCommonMoney2.MergeFrom(this.GetItemList);
								}
								input.ReadMessage(rogueCommonMoney2);
								this.GetItemList = rogueCommonMoney2;
								continue;
							}
							if (num == 522U)
							{
								RogueCommonExpandedFormula rogueCommonExpandedFormula = new RogueCommonExpandedFormula();
								if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ExpandFormulaList)
								{
									rogueCommonExpandedFormula.MergeFrom(this.ExpandFormulaList);
								}
								input.ReadMessage(rogueCommonExpandedFormula);
								this.ExpandFormulaList = rogueCommonExpandedFormula;
								continue;
							}
						}
						else
						{
							if (num == 778U)
							{
								RogueCommonBuff rogueCommonBuff = new RogueCommonBuff();
								if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetBuffList)
								{
									rogueCommonBuff.MergeFrom(this.GetBuffList);
								}
								input.ReadMessage(rogueCommonBuff);
								this.GetBuffList = rogueCommonBuff;
								continue;
							}
							if (num == 1234U)
							{
								RogueCommonBuff rogueCommonBuff2 = new RogueCommonBuff();
								if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveBuffList)
								{
									rogueCommonBuff2.MergeFrom(this.RemoveBuffList);
								}
								input.ReadMessage(rogueCommonBuff2);
								this.RemoveBuffList = rogueCommonBuff2;
								continue;
							}
							if (num == 2210U)
							{
								RogueMagicGameUnitInfo rogueMagicGameUnitInfo = new RogueMagicGameUnitInfo();
								if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.OCMBNDKBAPI)
								{
									rogueMagicGameUnitInfo.MergeFrom(this.OCMBNDKBAPI);
								}
								input.ReadMessage(rogueMagicGameUnitInfo);
								this.OCMBNDKBAPI = rogueMagicGameUnitInfo;
								continue;
							}
						}
					}
					else if (num <= 4778U)
					{
						if (num == 2370U)
						{
							RogueCommonRemoveFormula rogueCommonRemoveFormula = new RogueCommonRemoveFormula();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveFormulaList)
							{
								rogueCommonRemoveFormula.MergeFrom(this.RemoveFormulaList);
							}
							input.ReadMessage(rogueCommonRemoveFormula);
							this.RemoveFormulaList = rogueCommonRemoveFormula;
							continue;
						}
						if (num == 4154U)
						{
							ICPOMOHLCMD icpomohlcmd = new ICPOMOHLCMD();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE)
							{
								icpomohlcmd.MergeFrom(this.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE);
							}
							input.ReadMessage(icpomohlcmd);
							this.ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE = icpomohlcmd;
							continue;
						}
						if (num == 4778U)
						{
							CGHBMKAAOGP cghbmkaaogp = new CGHBMKAAOGP();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ELOANPJBFJH)
							{
								cghbmkaaogp.MergeFrom(this.ELOANPJBFJH);
							}
							input.ReadMessage(cghbmkaaogp);
							this.ELOANPJBFJH = cghbmkaaogp;
							continue;
						}
					}
					else if (num <= 6938U)
					{
						if (num == 6218U)
						{
							RogueMagicGameUnitInfo rogueMagicGameUnitInfo2 = new RogueMagicGameUnitInfo();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetMagicUnitList)
							{
								rogueMagicGameUnitInfo2.MergeFrom(this.GetMagicUnitList);
							}
							input.ReadMessage(rogueMagicGameUnitInfo2);
							this.GetMagicUnitList = rogueMagicGameUnitInfo2;
							continue;
						}
						if (num == 6938U)
						{
							RogueCommonDressScepter rogueCommonDressScepter = new RogueCommonDressScepter();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.DressScepterList)
							{
								rogueCommonDressScepter.MergeFrom(this.DressScepterList);
							}
							input.ReadMessage(rogueCommonDressScepter);
							this.DressScepterList = rogueCommonDressScepter;
							continue;
						}
					}
					else
					{
						if (num == 7466U)
						{
							LJFBDHHDPOM ljfbdhhdpom = new LJFBDHHDPOM();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.FGMCCFFGFFK)
							{
								ljfbdhhdpom.MergeFrom(this.FGMCCFFGFFK);
							}
							input.ReadMessage(ljfbdhhdpom);
							this.FGMCCFFGFFK = ljfbdhhdpom;
							continue;
						}
						if (num == 8322U)
						{
							RogueCommonMiracle rogueCommonMiracle = new RogueCommonMiracle();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetMiracleList)
							{
								rogueCommonMiracle.MergeFrom(this.GetMiracleList);
							}
							input.ReadMessage(rogueCommonMiracle);
							this.GetMiracleList = rogueCommonMiracle;
							continue;
						}
					}
				}
				else if (num <= 12914U)
				{
					if (num <= 10562U)
					{
						if (num == 9082U)
						{
							NCBIADHLKGN ncbiadhlkgn = new NCBIADHLKGN();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.BJMFLAFIKJB)
							{
								ncbiadhlkgn.MergeFrom(this.BJMFLAFIKJB);
							}
							input.ReadMessage(ncbiadhlkgn);
							this.BJMFLAFIKJB = ncbiadhlkgn;
							continue;
						}
						if (num == 9562U)
						{
							RogueCommonGetScepter rogueCommonGetScepter = new RogueCommonGetScepter();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetScepterList)
							{
								rogueCommonGetScepter.MergeFrom(this.GetScepterList);
							}
							input.ReadMessage(rogueCommonGetScepter);
							this.GetScepterList = rogueCommonGetScepter;
							continue;
						}
						if (num == 10562U)
						{
							RogueCommonRemoveKeyword rogueCommonRemoveKeyword = new RogueCommonRemoveKeyword();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveKeywordList)
							{
								rogueCommonRemoveKeyword.MergeFrom(this.RemoveKeywordList);
							}
							input.ReadMessage(rogueCommonRemoveKeyword);
							this.RemoveKeywordList = rogueCommonRemoveKeyword;
							continue;
						}
					}
					else
					{
						if (num == 10794U)
						{
							NPGDAKGFGJO npgdakgfgjo = new NPGDAKGFGJO();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.DNICOFFFDEJ)
							{
								npgdakgfgjo.MergeFrom(this.DNICOFFFDEJ);
							}
							input.ReadMessage(npgdakgfgjo);
							this.DNICOFFFDEJ = npgdakgfgjo;
							continue;
						}
						if (num == 11666U)
						{
							RogueMagicGameScepterInfo rogueMagicGameScepterInfo = new RogueMagicGameScepterInfo();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.MAFECNCNOCB)
							{
								rogueMagicGameScepterInfo.MergeFrom(this.MAFECNCNOCB);
							}
							input.ReadMessage(rogueMagicGameScepterInfo);
							this.MAFECNCNOCB = rogueMagicGameScepterInfo;
							continue;
						}
						if (num == 12914U)
						{
							RogueCommonRemoveMiracle rogueCommonRemoveMiracle = new RogueCommonRemoveMiracle();
							if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveMiracleList)
							{
								rogueCommonRemoveMiracle.MergeFrom(this.RemoveMiracleList);
							}
							input.ReadMessage(rogueCommonRemoveMiracle);
							this.RemoveMiracleList = rogueCommonRemoveMiracle;
							continue;
						}
					}
				}
				else if (num <= 15234U)
				{
					if (num == 12970U)
					{
						EKKHDLKGMDH ekkhdlkgmdh = new EKKHDLKGMDH();
						if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.HBPPAPIOFBC)
						{
							ekkhdlkgmdh.MergeFrom(this.HBPPAPIOFBC);
						}
						input.ReadMessage(ekkhdlkgmdh);
						this.HBPPAPIOFBC = ekkhdlkgmdh;
						continue;
					}
					if (num == 15026U)
					{
						HIEBMNLCFBB hiebmnlcfbb = new HIEBMNLCFBB();
						if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.POCBCJLLGAB)
						{
							hiebmnlcfbb.MergeFrom(this.POCBCJLLGAB);
						}
						input.ReadMessage(hiebmnlcfbb);
						this.POCBCJLLGAB = hiebmnlcfbb;
						continue;
					}
					if (num == 15234U)
					{
						RogueCommonContractFormula rogueCommonContractFormula = new RogueCommonContractFormula();
						if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.ContractFormulaList)
						{
							rogueCommonContractFormula.MergeFrom(this.ContractFormulaList);
						}
						input.ReadMessage(rogueCommonContractFormula);
						this.ContractFormulaList = rogueCommonContractFormula;
						continue;
					}
				}
				else if (num <= 15570U)
				{
					if (num == 15450U)
					{
						RogueCommonKeyword rogueCommonKeyword = new RogueCommonKeyword();
						if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetKeywordList)
						{
							rogueCommonKeyword.MergeFrom(this.GetKeywordList);
						}
						input.ReadMessage(rogueCommonKeyword);
						this.GetKeywordList = rogueCommonKeyword;
						continue;
					}
					if (num == 15570U)
					{
						RogueCommonFormula rogueCommonFormula = new RogueCommonFormula();
						if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.GetFormulaList)
						{
							rogueCommonFormula.MergeFrom(this.GetFormulaList);
						}
						input.ReadMessage(rogueCommonFormula);
						this.GetFormulaList = rogueCommonFormula;
						continue;
					}
				}
				else
				{
					if (num == 15754U)
					{
						RogueMagicGameUnitInfo rogueMagicGameUnitInfo3 = new RogueMagicGameUnitInfo();
						if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.RemoveMagicUnitList)
						{
							rogueMagicGameUnitInfo3.MergeFrom(this.RemoveMagicUnitList);
						}
						input.ReadMessage(rogueMagicGameUnitInfo3);
						this.RemoveMagicUnitList = rogueMagicGameUnitInfo3;
						continue;
					}
					if (num == 15770U)
					{
						RogueCommonPathBuff rogueCommonPathBuff = new RogueCommonPathBuff();
						if (this.resultDataCase_ == RogueCommonActionResultData.ResultDataOneofCase.PathBuffList)
						{
							rogueCommonPathBuff.MergeFrom(this.PathBuffList);
						}
						input.ReadMessage(rogueCommonPathBuff);
						this.PathBuffList = rogueCommonPathBuff;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400423B RID: 16955
		private static readonly MessageParser<RogueCommonActionResultData> _parser = new MessageParser<RogueCommonActionResultData>(() => new RogueCommonActionResultData());

		// Token: 0x0400423C RID: 16956
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400423D RID: 16957
		public const int GetItemListFieldNumber = 14;

		// Token: 0x0400423E RID: 16958
		public const int RemoveItemListFieldNumber = 9;

		// Token: 0x0400423F RID: 16959
		public const int GetBuffListFieldNumber = 97;

		// Token: 0x04004240 RID: 16960
		public const int RemoveBuffListFieldNumber = 154;

		// Token: 0x04004241 RID: 16961
		public const int GetMiracleListFieldNumber = 1040;

		// Token: 0x04004242 RID: 16962
		public const int RemoveMiracleListFieldNumber = 1614;

		// Token: 0x04004243 RID: 16963
		public const int HBPPAPIOFBCFieldNumber = 1621;

		// Token: 0x04004244 RID: 16964
		public const int POCBCJLLGABFieldNumber = 1878;

		// Token: 0x04004245 RID: 16965
		public const int FGMCCFFGFFKFieldNumber = 933;

		// Token: 0x04004246 RID: 16966
		public const int DNICOFFFDEJFieldNumber = 1349;

		// Token: 0x04004247 RID: 16967
		public const int ELOANPJBFJHFieldNumber = 597;

		// Token: 0x04004248 RID: 16968
		public const int GetFormulaListFieldNumber = 1946;

		// Token: 0x04004249 RID: 16969
		public const int RemoveFormulaListFieldNumber = 296;

		// Token: 0x0400424A RID: 16970
		public const int ExpandFormulaListFieldNumber = 65;

		// Token: 0x0400424B RID: 16971
		public const int ContractFormulaListFieldNumber = 1904;

		// Token: 0x0400424C RID: 16972
		public const int PathBuffListFieldNumber = 1971;

		// Token: 0x0400424D RID: 16973
		public const int GetKeywordListFieldNumber = 1931;

		// Token: 0x0400424E RID: 16974
		public const int RemoveKeywordListFieldNumber = 1320;

		// Token: 0x0400424F RID: 16975
		public const int DressScepterListFieldNumber = 867;

		// Token: 0x04004250 RID: 16976
		public const int GetScepterListFieldNumber = 1195;

		// Token: 0x04004251 RID: 16977
		public const int BJMFLAFIKJBFieldNumber = 1135;

		// Token: 0x04004252 RID: 16978
		public const int GetMagicUnitListFieldNumber = 777;

		// Token: 0x04004253 RID: 16979
		public const int RemoveMagicUnitListFieldNumber = 1969;

		// Token: 0x04004254 RID: 16980
		public const int OCMBNDKBAPIFieldNumber = 276;

		// Token: 0x04004255 RID: 16981
		public const int MAFECNCNOCBFieldNumber = 1458;

		// Token: 0x04004256 RID: 16982
		public const int ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSEFieldNumber = 519;

		// Token: 0x04004257 RID: 16983
		private object resultData_;

		// Token: 0x04004258 RID: 16984
		private RogueCommonActionResultData.ResultDataOneofCase resultDataCase_;

		// Token: 0x02001B00 RID: 6912
		public enum ResultDataOneofCase
		{
			// Token: 0x0400630C RID: 25356
			None,
			// Token: 0x0400630D RID: 25357
			GetItemList = 14,
			// Token: 0x0400630E RID: 25358
			RemoveItemList = 9,
			// Token: 0x0400630F RID: 25359
			GetBuffList = 97,
			// Token: 0x04006310 RID: 25360
			RemoveBuffList = 154,
			// Token: 0x04006311 RID: 25361
			GetMiracleList = 1040,
			// Token: 0x04006312 RID: 25362
			RemoveMiracleList = 1614,
			// Token: 0x04006313 RID: 25363
			HBPPAPIOFBC = 1621,
			// Token: 0x04006314 RID: 25364
			POCBCJLLGAB = 1878,
			// Token: 0x04006315 RID: 25365
			FGMCCFFGFFK = 933,
			// Token: 0x04006316 RID: 25366
			DNICOFFFDEJ = 1349,
			// Token: 0x04006317 RID: 25367
			ELOANPJBFJH = 597,
			// Token: 0x04006318 RID: 25368
			GetFormulaList = 1946,
			// Token: 0x04006319 RID: 25369
			RemoveFormulaList = 296,
			// Token: 0x0400631A RID: 25370
			ExpandFormulaList = 65,
			// Token: 0x0400631B RID: 25371
			ContractFormulaList = 1904,
			// Token: 0x0400631C RID: 25372
			PathBuffList = 1971,
			// Token: 0x0400631D RID: 25373
			GetKeywordList = 1931,
			// Token: 0x0400631E RID: 25374
			RemoveKeywordList = 1320,
			// Token: 0x0400631F RID: 25375
			DressScepterList = 867,
			// Token: 0x04006320 RID: 25376
			GetScepterList = 1195,
			// Token: 0x04006321 RID: 25377
			BJMFLAFIKJB = 1135,
			// Token: 0x04006322 RID: 25378
			GetMagicUnitList = 777,
			// Token: 0x04006323 RID: 25379
			RemoveMagicUnitList = 1969,
			// Token: 0x04006324 RID: 25380
			OCMBNDKBAPI = 276,
			// Token: 0x04006325 RID: 25381
			MAFECNCNOCB = 1458,
			// Token: 0x04006326 RID: 25382
			ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE = 519
		}
	}
}
