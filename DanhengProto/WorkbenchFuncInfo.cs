using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200143F RID: 5183
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchFuncInfo : IMessage<WorkbenchFuncInfo>, IMessage, IEquatable<WorkbenchFuncInfo>, IDeepCloneable<WorkbenchFuncInfo>, IBufferMessage
	{
		// Token: 0x170040E6 RID: 16614
		// (get) Token: 0x0600E739 RID: 59193 RVA: 0x002667D6 File Offset: 0x002649D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchFuncInfo> Parser
		{
			get
			{
				return WorkbenchFuncInfo._parser;
			}
		}

		// Token: 0x170040E7 RID: 16615
		// (get) Token: 0x0600E73A RID: 59194 RVA: 0x002667DD File Offset: 0x002649DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchFuncInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040E8 RID: 16616
		// (get) Token: 0x0600E73B RID: 59195 RVA: 0x002667EF File Offset: 0x002649EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchFuncInfo.Descriptor;
			}
		}

		// Token: 0x0600E73C RID: 59196 RVA: 0x002667F6 File Offset: 0x002649F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchFuncInfo()
		{
		}

		// Token: 0x0600E73D RID: 59197 RVA: 0x00266800 File Offset: 0x00264A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchFuncInfo(WorkbenchFuncInfo other) : this()
		{
			this.reforgeBuffFunc_ = ((other.reforgeBuffFunc_ != null) ? other.reforgeBuffFunc_.Clone() : null);
			this.reforgeFormulaFunc_ = ((other.reforgeFormulaFunc_ != null) ? other.reforgeFormulaFunc_.Clone() : null);
			this.enhanceBuffFunc_ = ((other.enhanceBuffFunc_ != null) ? other.enhanceBuffFunc_.Clone() : null);
			this.composeMiracleFunc_ = ((other.composeMiracleFunc_ != null) ? other.composeMiracleFunc_.Clone() : null);
			this.reforgeHexAvatarFunc_ = ((other.reforgeHexAvatarFunc_ != null) ? other.reforgeHexAvatarFunc_.Clone() : null);
			this.magicItem_ = ((other.magicItem_ != null) ? other.magicItem_.Clone() : null);
			this.gameMagicUnit_ = ((other.gameMagicUnit_ != null) ? other.gameMagicUnit_.Clone() : null);
			this.cEPLFBBJIGK_ = ((other.cEPLFBBJIGK_ != null) ? other.cEPLFBBJIGK_.Clone() : null);
			this.mOJKOEDKGAO_ = ((other.mOJKOEDKGAO_ != null) ? other.mOJKOEDKGAO_.Clone() : null);
			this.dCPPMNOKCOC_ = ((other.dCPPMNOKCOC_ != null) ? other.dCPPMNOKCOC_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E73E RID: 59198 RVA: 0x0026693C File Offset: 0x00264B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchFuncInfo Clone()
		{
			return new WorkbenchFuncInfo(this);
		}

		// Token: 0x170040E9 RID: 16617
		// (get) Token: 0x0600E73F RID: 59199 RVA: 0x00266944 File Offset: 0x00264B44
		// (set) Token: 0x0600E740 RID: 59200 RVA: 0x0026694C File Offset: 0x00264B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeBuffFuncInfo ReforgeBuffFunc
		{
			get
			{
				return this.reforgeBuffFunc_;
			}
			set
			{
				this.reforgeBuffFunc_ = value;
			}
		}

		// Token: 0x170040EA RID: 16618
		// (get) Token: 0x0600E741 RID: 59201 RVA: 0x00266955 File Offset: 0x00264B55
		// (set) Token: 0x0600E742 RID: 59202 RVA: 0x0026695D File Offset: 0x00264B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeFormulaFuncInfo ReforgeFormulaFunc
		{
			get
			{
				return this.reforgeFormulaFunc_;
			}
			set
			{
				this.reforgeFormulaFunc_ = value;
			}
		}

		// Token: 0x170040EB RID: 16619
		// (get) Token: 0x0600E743 RID: 59203 RVA: 0x00266966 File Offset: 0x00264B66
		// (set) Token: 0x0600E744 RID: 59204 RVA: 0x0026696E File Offset: 0x00264B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchEnhanceBuffFuncInfo EnhanceBuffFunc
		{
			get
			{
				return this.enhanceBuffFunc_;
			}
			set
			{
				this.enhanceBuffFunc_ = value;
			}
		}

		// Token: 0x170040EC RID: 16620
		// (get) Token: 0x0600E745 RID: 59205 RVA: 0x00266977 File Offset: 0x00264B77
		// (set) Token: 0x0600E746 RID: 59206 RVA: 0x0026697F File Offset: 0x00264B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchComposeMiracleFunc ComposeMiracleFunc
		{
			get
			{
				return this.composeMiracleFunc_;
			}
			set
			{
				this.composeMiracleFunc_ = value;
			}
		}

		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x0600E747 RID: 59207 RVA: 0x00266988 File Offset: 0x00264B88
		// (set) Token: 0x0600E748 RID: 59208 RVA: 0x00266990 File Offset: 0x00264B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeHexAvatarFunc ReforgeHexAvatarFunc
		{
			get
			{
				return this.reforgeHexAvatarFunc_;
			}
			set
			{
				this.reforgeHexAvatarFunc_ = value;
			}
		}

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x0600E749 RID: 59209 RVA: 0x00266999 File Offset: 0x00264B99
		// (set) Token: 0x0600E74A RID: 59210 RVA: 0x002669A1 File Offset: 0x00264BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MIMLAKLPCPL MagicItem
		{
			get
			{
				return this.magicItem_;
			}
			set
			{
				this.magicItem_ = value;
			}
		}

		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x0600E74B RID: 59211 RVA: 0x002669AA File Offset: 0x00264BAA
		// (set) Token: 0x0600E74C RID: 59212 RVA: 0x002669B2 File Offset: 0x00264BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LAGHMBLEMJJ GameMagicUnit
		{
			get
			{
				return this.gameMagicUnit_;
			}
			set
			{
				this.gameMagicUnit_ = value;
			}
		}

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x0600E74D RID: 59213 RVA: 0x002669BB File Offset: 0x00264BBB
		// (set) Token: 0x0600E74E RID: 59214 RVA: 0x002669C3 File Offset: 0x00264BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAOPAFHNNAH CEPLFBBJIGK
		{
			get
			{
				return this.cEPLFBBJIGK_;
			}
			set
			{
				this.cEPLFBBJIGK_ = value;
			}
		}

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x0600E74F RID: 59215 RVA: 0x002669CC File Offset: 0x00264BCC
		// (set) Token: 0x0600E750 RID: 59216 RVA: 0x002669D4 File Offset: 0x00264BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FHEJDFGDPMO MOJKOEDKGAO
		{
			get
			{
				return this.mOJKOEDKGAO_;
			}
			set
			{
				this.mOJKOEDKGAO_ = value;
			}
		}

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x0600E751 RID: 59217 RVA: 0x002669DD File Offset: 0x00264BDD
		// (set) Token: 0x0600E752 RID: 59218 RVA: 0x002669E5 File Offset: 0x00264BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LEPMIKONNPH DCPPMNOKCOC
		{
			get
			{
				return this.dCPPMNOKCOC_;
			}
			set
			{
				this.dCPPMNOKCOC_ = value;
			}
		}

		// Token: 0x0600E753 RID: 59219 RVA: 0x002669EE File Offset: 0x00264BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchFuncInfo);
		}

		// Token: 0x0600E754 RID: 59220 RVA: 0x002669FC File Offset: 0x00264BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchFuncInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ReforgeBuffFunc, other.ReforgeBuffFunc) && object.Equals(this.ReforgeFormulaFunc, other.ReforgeFormulaFunc) && object.Equals(this.EnhanceBuffFunc, other.EnhanceBuffFunc) && object.Equals(this.ComposeMiracleFunc, other.ComposeMiracleFunc) && object.Equals(this.ReforgeHexAvatarFunc, other.ReforgeHexAvatarFunc) && object.Equals(this.MagicItem, other.MagicItem) && object.Equals(this.GameMagicUnit, other.GameMagicUnit) && object.Equals(this.CEPLFBBJIGK, other.CEPLFBBJIGK) && object.Equals(this.MOJKOEDKGAO, other.MOJKOEDKGAO) && object.Equals(this.DCPPMNOKCOC, other.DCPPMNOKCOC) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E755 RID: 59221 RVA: 0x00266AF8 File Offset: 0x00264CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reforgeBuffFunc_ != null)
			{
				num ^= this.ReforgeBuffFunc.GetHashCode();
			}
			if (this.reforgeFormulaFunc_ != null)
			{
				num ^= this.ReforgeFormulaFunc.GetHashCode();
			}
			if (this.enhanceBuffFunc_ != null)
			{
				num ^= this.EnhanceBuffFunc.GetHashCode();
			}
			if (this.composeMiracleFunc_ != null)
			{
				num ^= this.ComposeMiracleFunc.GetHashCode();
			}
			if (this.reforgeHexAvatarFunc_ != null)
			{
				num ^= this.ReforgeHexAvatarFunc.GetHashCode();
			}
			if (this.magicItem_ != null)
			{
				num ^= this.MagicItem.GetHashCode();
			}
			if (this.gameMagicUnit_ != null)
			{
				num ^= this.GameMagicUnit.GetHashCode();
			}
			if (this.cEPLFBBJIGK_ != null)
			{
				num ^= this.CEPLFBBJIGK.GetHashCode();
			}
			if (this.mOJKOEDKGAO_ != null)
			{
				num ^= this.MOJKOEDKGAO.GetHashCode();
			}
			if (this.dCPPMNOKCOC_ != null)
			{
				num ^= this.DCPPMNOKCOC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E756 RID: 59222 RVA: 0x00266BFA File Offset: 0x00264DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E757 RID: 59223 RVA: 0x00266C02 File Offset: 0x00264E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E758 RID: 59224 RVA: 0x00266C0C File Offset: 0x00264E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reforgeFormulaFunc_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ReforgeFormulaFunc);
			}
			if (this.mOJKOEDKGAO_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MOJKOEDKGAO);
			}
			if (this.reforgeBuffFunc_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ReforgeBuffFunc);
			}
			if (this.composeMiracleFunc_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ComposeMiracleFunc);
			}
			if (this.enhanceBuffFunc_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.EnhanceBuffFunc);
			}
			if (this.reforgeHexAvatarFunc_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ReforgeHexAvatarFunc);
			}
			if (this.magicItem_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MagicItem);
			}
			if (this.gameMagicUnit_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.GameMagicUnit);
			}
			if (this.dCPPMNOKCOC_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.DCPPMNOKCOC);
			}
			if (this.cEPLFBBJIGK_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.CEPLFBBJIGK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E759 RID: 59225 RVA: 0x00266D48 File Offset: 0x00264F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reforgeBuffFunc_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReforgeBuffFunc);
			}
			if (this.reforgeFormulaFunc_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReforgeFormulaFunc);
			}
			if (this.enhanceBuffFunc_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnhanceBuffFunc);
			}
			if (this.composeMiracleFunc_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ComposeMiracleFunc);
			}
			if (this.reforgeHexAvatarFunc_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReforgeHexAvatarFunc);
			}
			if (this.magicItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MagicItem);
			}
			if (this.gameMagicUnit_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameMagicUnit);
			}
			if (this.cEPLFBBJIGK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CEPLFBBJIGK);
			}
			if (this.mOJKOEDKGAO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MOJKOEDKGAO);
			}
			if (this.dCPPMNOKCOC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DCPPMNOKCOC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E75A RID: 59226 RVA: 0x00266E60 File Offset: 0x00265060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchFuncInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reforgeBuffFunc_ != null)
			{
				if (this.reforgeBuffFunc_ == null)
				{
					this.ReforgeBuffFunc = new WorkbenchReforgeBuffFuncInfo();
				}
				this.ReforgeBuffFunc.MergeFrom(other.ReforgeBuffFunc);
			}
			if (other.reforgeFormulaFunc_ != null)
			{
				if (this.reforgeFormulaFunc_ == null)
				{
					this.ReforgeFormulaFunc = new WorkbenchReforgeFormulaFuncInfo();
				}
				this.ReforgeFormulaFunc.MergeFrom(other.ReforgeFormulaFunc);
			}
			if (other.enhanceBuffFunc_ != null)
			{
				if (this.enhanceBuffFunc_ == null)
				{
					this.EnhanceBuffFunc = new WorkbenchEnhanceBuffFuncInfo();
				}
				this.EnhanceBuffFunc.MergeFrom(other.EnhanceBuffFunc);
			}
			if (other.composeMiracleFunc_ != null)
			{
				if (this.composeMiracleFunc_ == null)
				{
					this.ComposeMiracleFunc = new WorkbenchComposeMiracleFunc();
				}
				this.ComposeMiracleFunc.MergeFrom(other.ComposeMiracleFunc);
			}
			if (other.reforgeHexAvatarFunc_ != null)
			{
				if (this.reforgeHexAvatarFunc_ == null)
				{
					this.ReforgeHexAvatarFunc = new WorkbenchReforgeHexAvatarFunc();
				}
				this.ReforgeHexAvatarFunc.MergeFrom(other.ReforgeHexAvatarFunc);
			}
			if (other.magicItem_ != null)
			{
				if (this.magicItem_ == null)
				{
					this.MagicItem = new MIMLAKLPCPL();
				}
				this.MagicItem.MergeFrom(other.MagicItem);
			}
			if (other.gameMagicUnit_ != null)
			{
				if (this.gameMagicUnit_ == null)
				{
					this.GameMagicUnit = new LAGHMBLEMJJ();
				}
				this.GameMagicUnit.MergeFrom(other.GameMagicUnit);
			}
			if (other.cEPLFBBJIGK_ != null)
			{
				if (this.cEPLFBBJIGK_ == null)
				{
					this.CEPLFBBJIGK = new DAOPAFHNNAH();
				}
				this.CEPLFBBJIGK.MergeFrom(other.CEPLFBBJIGK);
			}
			if (other.mOJKOEDKGAO_ != null)
			{
				if (this.mOJKOEDKGAO_ == null)
				{
					this.MOJKOEDKGAO = new FHEJDFGDPMO();
				}
				this.MOJKOEDKGAO.MergeFrom(other.MOJKOEDKGAO);
			}
			if (other.dCPPMNOKCOC_ != null)
			{
				if (this.dCPPMNOKCOC_ == null)
				{
					this.DCPPMNOKCOC = new LEPMIKONNPH();
				}
				this.DCPPMNOKCOC.MergeFrom(other.DCPPMNOKCOC);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E75B RID: 59227 RVA: 0x00267040 File Offset: 0x00265240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E75C RID: 59228 RVA: 0x0026704C File Offset: 0x0026524C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num <= 34U)
					{
						if (num == 26U)
						{
							if (this.reforgeFormulaFunc_ == null)
							{
								this.ReforgeFormulaFunc = new WorkbenchReforgeFormulaFuncInfo();
							}
							input.ReadMessage(this.ReforgeFormulaFunc);
							continue;
						}
						if (num == 34U)
						{
							if (this.mOJKOEDKGAO_ == null)
							{
								this.MOJKOEDKGAO = new FHEJDFGDPMO();
							}
							input.ReadMessage(this.MOJKOEDKGAO);
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							if (this.reforgeBuffFunc_ == null)
							{
								this.ReforgeBuffFunc = new WorkbenchReforgeBuffFuncInfo();
							}
							input.ReadMessage(this.ReforgeBuffFunc);
							continue;
						}
						if (num == 66U)
						{
							if (this.composeMiracleFunc_ == null)
							{
								this.ComposeMiracleFunc = new WorkbenchComposeMiracleFunc();
							}
							input.ReadMessage(this.ComposeMiracleFunc);
							continue;
						}
						if (num == 74U)
						{
							if (this.enhanceBuffFunc_ == null)
							{
								this.EnhanceBuffFunc = new WorkbenchEnhanceBuffFuncInfo();
							}
							input.ReadMessage(this.EnhanceBuffFunc);
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num == 82U)
					{
						if (this.reforgeHexAvatarFunc_ == null)
						{
							this.ReforgeHexAvatarFunc = new WorkbenchReforgeHexAvatarFunc();
						}
						input.ReadMessage(this.ReforgeHexAvatarFunc);
						continue;
					}
					if (num == 98U)
					{
						if (this.magicItem_ == null)
						{
							this.MagicItem = new MIMLAKLPCPL();
						}
						input.ReadMessage(this.MagicItem);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.gameMagicUnit_ == null)
						{
							this.GameMagicUnit = new LAGHMBLEMJJ();
						}
						input.ReadMessage(this.GameMagicUnit);
						continue;
					}
					if (num == 114U)
					{
						if (this.dCPPMNOKCOC_ == null)
						{
							this.DCPPMNOKCOC = new LEPMIKONNPH();
						}
						input.ReadMessage(this.DCPPMNOKCOC);
						continue;
					}
					if (num == 122U)
					{
						if (this.cEPLFBBJIGK_ == null)
						{
							this.CEPLFBBJIGK = new DAOPAFHNNAH();
						}
						input.ReadMessage(this.CEPLFBBJIGK);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005BB9 RID: 23481
		private static readonly MessageParser<WorkbenchFuncInfo> _parser = new MessageParser<WorkbenchFuncInfo>(() => new WorkbenchFuncInfo());

		// Token: 0x04005BBA RID: 23482
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BBB RID: 23483
		public const int ReforgeBuffFuncFieldNumber = 7;

		// Token: 0x04005BBC RID: 23484
		private WorkbenchReforgeBuffFuncInfo reforgeBuffFunc_;

		// Token: 0x04005BBD RID: 23485
		public const int ReforgeFormulaFuncFieldNumber = 3;

		// Token: 0x04005BBE RID: 23486
		private WorkbenchReforgeFormulaFuncInfo reforgeFormulaFunc_;

		// Token: 0x04005BBF RID: 23487
		public const int EnhanceBuffFuncFieldNumber = 9;

		// Token: 0x04005BC0 RID: 23488
		private WorkbenchEnhanceBuffFuncInfo enhanceBuffFunc_;

		// Token: 0x04005BC1 RID: 23489
		public const int ComposeMiracleFuncFieldNumber = 8;

		// Token: 0x04005BC2 RID: 23490
		private WorkbenchComposeMiracleFunc composeMiracleFunc_;

		// Token: 0x04005BC3 RID: 23491
		public const int ReforgeHexAvatarFuncFieldNumber = 10;

		// Token: 0x04005BC4 RID: 23492
		private WorkbenchReforgeHexAvatarFunc reforgeHexAvatarFunc_;

		// Token: 0x04005BC5 RID: 23493
		public const int MagicItemFieldNumber = 12;

		// Token: 0x04005BC6 RID: 23494
		private MIMLAKLPCPL magicItem_;

		// Token: 0x04005BC7 RID: 23495
		public const int GameMagicUnitFieldNumber = 13;

		// Token: 0x04005BC8 RID: 23496
		private LAGHMBLEMJJ gameMagicUnit_;

		// Token: 0x04005BC9 RID: 23497
		public const int CEPLFBBJIGKFieldNumber = 15;

		// Token: 0x04005BCA RID: 23498
		private DAOPAFHNNAH cEPLFBBJIGK_;

		// Token: 0x04005BCB RID: 23499
		public const int MOJKOEDKGAOFieldNumber = 4;

		// Token: 0x04005BCC RID: 23500
		private FHEJDFGDPMO mOJKOEDKGAO_;

		// Token: 0x04005BCD RID: 23501
		public const int DCPPMNOKCOCFieldNumber = 14;

		// Token: 0x04005BCE RID: 23502
		private LEPMIKONNPH dCPPMNOKCOC_;
	}
}
