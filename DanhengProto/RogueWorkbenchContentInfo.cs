using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001031 RID: 4145
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueWorkbenchContentInfo : IMessage<RogueWorkbenchContentInfo>, IMessage, IEquatable<RogueWorkbenchContentInfo>, IDeepCloneable<RogueWorkbenchContentInfo>, IBufferMessage
	{
		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600B849 RID: 47177 RVA: 0x001EE8B7 File Offset: 0x001ECAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWorkbenchContentInfo> Parser
		{
			get
			{
				return RogueWorkbenchContentInfo._parser;
			}
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600B84A RID: 47178 RVA: 0x001EE8BE File Offset: 0x001ECABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchContentInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600B84B RID: 47179 RVA: 0x001EE8D0 File Offset: 0x001ECAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWorkbenchContentInfo.Descriptor;
			}
		}

		// Token: 0x0600B84C RID: 47180 RVA: 0x001EE8D7 File Offset: 0x001ECAD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchContentInfo()
		{
		}

		// Token: 0x0600B84D RID: 47181 RVA: 0x001EE8E0 File Offset: 0x001ECAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchContentInfo(RogueWorkbenchContentInfo other) : this()
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

		// Token: 0x0600B84E RID: 47182 RVA: 0x001EEA1C File Offset: 0x001ECC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchContentInfo Clone()
		{
			return new RogueWorkbenchContentInfo(this);
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600B84F RID: 47183 RVA: 0x001EEA24 File Offset: 0x001ECC24
		// (set) Token: 0x0600B850 RID: 47184 RVA: 0x001EEA2C File Offset: 0x001ECC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeBuffTargetInfo ReforgeBuffFunc
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

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600B851 RID: 47185 RVA: 0x001EEA35 File Offset: 0x001ECC35
		// (set) Token: 0x0600B852 RID: 47186 RVA: 0x001EEA3D File Offset: 0x001ECC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeFormulaTargetInfo ReforgeFormulaFunc
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

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600B853 RID: 47187 RVA: 0x001EEA46 File Offset: 0x001ECC46
		// (set) Token: 0x0600B854 RID: 47188 RVA: 0x001EEA4E File Offset: 0x001ECC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchEnhanceBuffTargetInfo EnhanceBuffFunc
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

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600B855 RID: 47189 RVA: 0x001EEA57 File Offset: 0x001ECC57
		// (set) Token: 0x0600B856 RID: 47190 RVA: 0x001EEA5F File Offset: 0x001ECC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchComposeMiracleTargetInfo ComposeMiracleFunc
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

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600B857 RID: 47191 RVA: 0x001EEA68 File Offset: 0x001ECC68
		// (set) Token: 0x0600B858 RID: 47192 RVA: 0x001EEA70 File Offset: 0x001ECC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeHexAvatarTargetInfo ReforgeHexAvatarFunc
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

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600B859 RID: 47193 RVA: 0x001EEA79 File Offset: 0x001ECC79
		// (set) Token: 0x0600B85A RID: 47194 RVA: 0x001EEA81 File Offset: 0x001ECC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MEJJNDLFMPP MagicItem
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

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600B85B RID: 47195 RVA: 0x001EEA8A File Offset: 0x001ECC8A
		// (set) Token: 0x0600B85C RID: 47196 RVA: 0x001EEA92 File Offset: 0x001ECC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPGHBOBAMCI GameMagicUnit
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

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600B85D RID: 47197 RVA: 0x001EEA9B File Offset: 0x001ECC9B
		// (set) Token: 0x0600B85E RID: 47198 RVA: 0x001EEAA3 File Offset: 0x001ECCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBPJHLMNHEG CEPLFBBJIGK
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

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600B85F RID: 47199 RVA: 0x001EEAAC File Offset: 0x001ECCAC
		// (set) Token: 0x0600B860 RID: 47200 RVA: 0x001EEAB4 File Offset: 0x001ECCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PKHPNIINCLD MOJKOEDKGAO
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

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600B861 RID: 47201 RVA: 0x001EEABD File Offset: 0x001ECCBD
		// (set) Token: 0x0600B862 RID: 47202 RVA: 0x001EEAC5 File Offset: 0x001ECCC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJHGBBKHAHO DCPPMNOKCOC
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

		// Token: 0x0600B863 RID: 47203 RVA: 0x001EEACE File Offset: 0x001ECCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWorkbenchContentInfo);
		}

		// Token: 0x0600B864 RID: 47204 RVA: 0x001EEADC File Offset: 0x001ECCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWorkbenchContentInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ReforgeBuffFunc, other.ReforgeBuffFunc) && object.Equals(this.ReforgeFormulaFunc, other.ReforgeFormulaFunc) && object.Equals(this.EnhanceBuffFunc, other.EnhanceBuffFunc) && object.Equals(this.ComposeMiracleFunc, other.ComposeMiracleFunc) && object.Equals(this.ReforgeHexAvatarFunc, other.ReforgeHexAvatarFunc) && object.Equals(this.MagicItem, other.MagicItem) && object.Equals(this.GameMagicUnit, other.GameMagicUnit) && object.Equals(this.CEPLFBBJIGK, other.CEPLFBBJIGK) && object.Equals(this.MOJKOEDKGAO, other.MOJKOEDKGAO) && object.Equals(this.DCPPMNOKCOC, other.DCPPMNOKCOC) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B865 RID: 47205 RVA: 0x001EEBD8 File Offset: 0x001ECDD8
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

		// Token: 0x0600B866 RID: 47206 RVA: 0x001EECDA File Offset: 0x001ECEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B867 RID: 47207 RVA: 0x001EECE2 File Offset: 0x001ECEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B868 RID: 47208 RVA: 0x001EECEC File Offset: 0x001ECEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.composeMiracleFunc_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ComposeMiracleFunc);
			}
			if (this.reforgeHexAvatarFunc_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ReforgeHexAvatarFunc);
			}
			if (this.reforgeFormulaFunc_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ReforgeFormulaFunc);
			}
			if (this.reforgeBuffFunc_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ReforgeBuffFunc);
			}
			if (this.dCPPMNOKCOC_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.DCPPMNOKCOC);
			}
			if (this.mOJKOEDKGAO_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.MOJKOEDKGAO);
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
			if (this.enhanceBuffFunc_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.EnhanceBuffFunc);
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

		// Token: 0x0600B869 RID: 47209 RVA: 0x001EEE28 File Offset: 0x001ED028
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

		// Token: 0x0600B86A RID: 47210 RVA: 0x001EEF40 File Offset: 0x001ED140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWorkbenchContentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reforgeBuffFunc_ != null)
			{
				if (this.reforgeBuffFunc_ == null)
				{
					this.ReforgeBuffFunc = new WorkbenchReforgeBuffTargetInfo();
				}
				this.ReforgeBuffFunc.MergeFrom(other.ReforgeBuffFunc);
			}
			if (other.reforgeFormulaFunc_ != null)
			{
				if (this.reforgeFormulaFunc_ == null)
				{
					this.ReforgeFormulaFunc = new WorkbenchReforgeFormulaTargetInfo();
				}
				this.ReforgeFormulaFunc.MergeFrom(other.ReforgeFormulaFunc);
			}
			if (other.enhanceBuffFunc_ != null)
			{
				if (this.enhanceBuffFunc_ == null)
				{
					this.EnhanceBuffFunc = new WorkbenchEnhanceBuffTargetInfo();
				}
				this.EnhanceBuffFunc.MergeFrom(other.EnhanceBuffFunc);
			}
			if (other.composeMiracleFunc_ != null)
			{
				if (this.composeMiracleFunc_ == null)
				{
					this.ComposeMiracleFunc = new WorkbenchComposeMiracleTargetInfo();
				}
				this.ComposeMiracleFunc.MergeFrom(other.ComposeMiracleFunc);
			}
			if (other.reforgeHexAvatarFunc_ != null)
			{
				if (this.reforgeHexAvatarFunc_ == null)
				{
					this.ReforgeHexAvatarFunc = new WorkbenchReforgeHexAvatarTargetInfo();
				}
				this.ReforgeHexAvatarFunc.MergeFrom(other.ReforgeHexAvatarFunc);
			}
			if (other.magicItem_ != null)
			{
				if (this.magicItem_ == null)
				{
					this.MagicItem = new MEJJNDLFMPP();
				}
				this.MagicItem.MergeFrom(other.MagicItem);
			}
			if (other.gameMagicUnit_ != null)
			{
				if (this.gameMagicUnit_ == null)
				{
					this.GameMagicUnit = new OPGHBOBAMCI();
				}
				this.GameMagicUnit.MergeFrom(other.GameMagicUnit);
			}
			if (other.cEPLFBBJIGK_ != null)
			{
				if (this.cEPLFBBJIGK_ == null)
				{
					this.CEPLFBBJIGK = new JBPJHLMNHEG();
				}
				this.CEPLFBBJIGK.MergeFrom(other.CEPLFBBJIGK);
			}
			if (other.mOJKOEDKGAO_ != null)
			{
				if (this.mOJKOEDKGAO_ == null)
				{
					this.MOJKOEDKGAO = new PKHPNIINCLD();
				}
				this.MOJKOEDKGAO.MergeFrom(other.MOJKOEDKGAO);
			}
			if (other.dCPPMNOKCOC_ != null)
			{
				if (this.dCPPMNOKCOC_ == null)
				{
					this.DCPPMNOKCOC = new LJHGBBKHAHO();
				}
				this.DCPPMNOKCOC.MergeFrom(other.DCPPMNOKCOC);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B86B RID: 47211 RVA: 0x001EF120 File Offset: 0x001ED320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B86C RID: 47212 RVA: 0x001EF12C File Offset: 0x001ED32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 66U)
				{
					if (num <= 34U)
					{
						if (num == 18U)
						{
							if (this.composeMiracleFunc_ == null)
							{
								this.ComposeMiracleFunc = new WorkbenchComposeMiracleTargetInfo();
							}
							input.ReadMessage(this.ComposeMiracleFunc);
							continue;
						}
						if (num == 34U)
						{
							if (this.reforgeHexAvatarFunc_ == null)
							{
								this.ReforgeHexAvatarFunc = new WorkbenchReforgeHexAvatarTargetInfo();
							}
							input.ReadMessage(this.ReforgeHexAvatarFunc);
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.reforgeFormulaFunc_ == null)
							{
								this.ReforgeFormulaFunc = new WorkbenchReforgeFormulaTargetInfo();
							}
							input.ReadMessage(this.ReforgeFormulaFunc);
							continue;
						}
						if (num == 58U)
						{
							if (this.reforgeBuffFunc_ == null)
							{
								this.ReforgeBuffFunc = new WorkbenchReforgeBuffTargetInfo();
							}
							input.ReadMessage(this.ReforgeBuffFunc);
							continue;
						}
						if (num == 66U)
						{
							if (this.dCPPMNOKCOC_ == null)
							{
								this.DCPPMNOKCOC = new LJHGBBKHAHO();
							}
							input.ReadMessage(this.DCPPMNOKCOC);
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num == 74U)
					{
						if (this.mOJKOEDKGAO_ == null)
						{
							this.MOJKOEDKGAO = new PKHPNIINCLD();
						}
						input.ReadMessage(this.MOJKOEDKGAO);
						continue;
					}
					if (num == 98U)
					{
						if (this.magicItem_ == null)
						{
							this.MagicItem = new MEJJNDLFMPP();
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
							this.GameMagicUnit = new OPGHBOBAMCI();
						}
						input.ReadMessage(this.GameMagicUnit);
						continue;
					}
					if (num == 114U)
					{
						if (this.enhanceBuffFunc_ == null)
						{
							this.EnhanceBuffFunc = new WorkbenchEnhanceBuffTargetInfo();
						}
						input.ReadMessage(this.EnhanceBuffFunc);
						continue;
					}
					if (num == 122U)
					{
						if (this.cEPLFBBJIGK_ == null)
						{
							this.CEPLFBBJIGK = new JBPJHLMNHEG();
						}
						input.ReadMessage(this.CEPLFBBJIGK);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004AAA RID: 19114
		private static readonly MessageParser<RogueWorkbenchContentInfo> _parser = new MessageParser<RogueWorkbenchContentInfo>(() => new RogueWorkbenchContentInfo());

		// Token: 0x04004AAB RID: 19115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AAC RID: 19116
		public const int ReforgeBuffFuncFieldNumber = 7;

		// Token: 0x04004AAD RID: 19117
		private WorkbenchReforgeBuffTargetInfo reforgeBuffFunc_;

		// Token: 0x04004AAE RID: 19118
		public const int ReforgeFormulaFuncFieldNumber = 6;

		// Token: 0x04004AAF RID: 19119
		private WorkbenchReforgeFormulaTargetInfo reforgeFormulaFunc_;

		// Token: 0x04004AB0 RID: 19120
		public const int EnhanceBuffFuncFieldNumber = 14;

		// Token: 0x04004AB1 RID: 19121
		private WorkbenchEnhanceBuffTargetInfo enhanceBuffFunc_;

		// Token: 0x04004AB2 RID: 19122
		public const int ComposeMiracleFuncFieldNumber = 2;

		// Token: 0x04004AB3 RID: 19123
		private WorkbenchComposeMiracleTargetInfo composeMiracleFunc_;

		// Token: 0x04004AB4 RID: 19124
		public const int ReforgeHexAvatarFuncFieldNumber = 4;

		// Token: 0x04004AB5 RID: 19125
		private WorkbenchReforgeHexAvatarTargetInfo reforgeHexAvatarFunc_;

		// Token: 0x04004AB6 RID: 19126
		public const int MagicItemFieldNumber = 12;

		// Token: 0x04004AB7 RID: 19127
		private MEJJNDLFMPP magicItem_;

		// Token: 0x04004AB8 RID: 19128
		public const int GameMagicUnitFieldNumber = 13;

		// Token: 0x04004AB9 RID: 19129
		private OPGHBOBAMCI gameMagicUnit_;

		// Token: 0x04004ABA RID: 19130
		public const int CEPLFBBJIGKFieldNumber = 15;

		// Token: 0x04004ABB RID: 19131
		private JBPJHLMNHEG cEPLFBBJIGK_;

		// Token: 0x04004ABC RID: 19132
		public const int MOJKOEDKGAOFieldNumber = 9;

		// Token: 0x04004ABD RID: 19133
		private PKHPNIINCLD mOJKOEDKGAO_;

		// Token: 0x04004ABE RID: 19134
		public const int DCPPMNOKCOCFieldNumber = 8;

		// Token: 0x04004ABF RID: 19135
		private LJHGBBKHAHO dCPPMNOKCOC_;
	}
}
