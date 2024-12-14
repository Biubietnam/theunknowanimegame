using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AF1 RID: 2801
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MKACCPKNCKI : IMessage<MKACCPKNCKI>, IMessage, IEquatable<MKACCPKNCKI>, IDeepCloneable<MKACCPKNCKI>, IBufferMessage
	{
		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x06007BEA RID: 31722 RVA: 0x0014831F File Offset: 0x0014651F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MKACCPKNCKI> Parser
		{
			get
			{
				return MKACCPKNCKI._parser;
			}
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x06007BEB RID: 31723 RVA: 0x00148326 File Offset: 0x00146526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MKACCPKNCKIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x06007BEC RID: 31724 RVA: 0x00148338 File Offset: 0x00146538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MKACCPKNCKI.Descriptor;
			}
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x0014833F File Offset: 0x0014653F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKACCPKNCKI()
		{
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x00148348 File Offset: 0x00146548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKACCPKNCKI(MKACCPKNCKI other) : this()
		{
			this.iKCMKIIEBFG_ = other.iKCMKIIEBFG_;
			this.gLOAAHIMEHA_ = ((other.gLOAAHIMEHA_ != null) ? other.gLOAAHIMEHA_.Clone() : null);
			this.nALGCLKBBAJ_ = ((other.nALGCLKBBAJ_ != null) ? other.nALGCLKBBAJ_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BEF RID: 31727 RVA: 0x001483B0 File Offset: 0x001465B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKACCPKNCKI Clone()
		{
			return new MKACCPKNCKI(this);
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x06007BF0 RID: 31728 RVA: 0x001483B8 File Offset: 0x001465B8
		// (set) Token: 0x06007BF1 RID: 31729 RVA: 0x001483C0 File Offset: 0x001465C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IKCMKIIEBFG
		{
			get
			{
				return this.iKCMKIIEBFG_;
			}
			set
			{
				this.iKCMKIIEBFG_ = value;
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x06007BF2 RID: 31730 RVA: 0x001483C9 File Offset: 0x001465C9
		// (set) Token: 0x06007BF3 RID: 31731 RVA: 0x001483D1 File Offset: 0x001465D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDOCCKOMOEG GLOAAHIMEHA
		{
			get
			{
				return this.gLOAAHIMEHA_;
			}
			set
			{
				this.gLOAAHIMEHA_ = value;
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x06007BF4 RID: 31732 RVA: 0x001483DA File Offset: 0x001465DA
		// (set) Token: 0x06007BF5 RID: 31733 RVA: 0x001483E2 File Offset: 0x001465E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MAKKMBLOHHO NALGCLKBBAJ
		{
			get
			{
				return this.nALGCLKBBAJ_;
			}
			set
			{
				this.nALGCLKBBAJ_ = value;
			}
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x001483EB File Offset: 0x001465EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MKACCPKNCKI);
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x001483FC File Offset: 0x001465FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MKACCPKNCKI other)
		{
			return other != null && (other == this || (this.IKCMKIIEBFG == other.IKCMKIIEBFG && object.Equals(this.GLOAAHIMEHA, other.GLOAAHIMEHA) && object.Equals(this.NALGCLKBBAJ, other.NALGCLKBBAJ) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x00148460 File Offset: 0x00146660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IKCMKIIEBFG != 0U)
			{
				num ^= this.IKCMKIIEBFG.GetHashCode();
			}
			if (this.gLOAAHIMEHA_ != null)
			{
				num ^= this.GLOAAHIMEHA.GetHashCode();
			}
			if (this.nALGCLKBBAJ_ != null)
			{
				num ^= this.NALGCLKBBAJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BF9 RID: 31737 RVA: 0x001484CB File Offset: 0x001466CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x001484D3 File Offset: 0x001466D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x001484DC File Offset: 0x001466DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nALGCLKBBAJ_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.NALGCLKBBAJ);
			}
			if (this.gLOAAHIMEHA_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.GLOAAHIMEHA);
			}
			if (this.IKCMKIIEBFG != 0U)
			{
				output.WriteRawTag(144, 78);
				output.WriteUInt32(this.IKCMKIIEBFG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x00148558 File Offset: 0x00146758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IKCMKIIEBFG != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.IKCMKIIEBFG);
			}
			if (this.gLOAAHIMEHA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GLOAAHIMEHA);
			}
			if (this.nALGCLKBBAJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NALGCLKBBAJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x001485C8 File Offset: 0x001467C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MKACCPKNCKI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IKCMKIIEBFG != 0U)
			{
				this.IKCMKIIEBFG = other.IKCMKIIEBFG;
			}
			if (other.gLOAAHIMEHA_ != null)
			{
				if (this.gLOAAHIMEHA_ == null)
				{
					this.GLOAAHIMEHA = new JDOCCKOMOEG();
				}
				this.GLOAAHIMEHA.MergeFrom(other.GLOAAHIMEHA);
			}
			if (other.nALGCLKBBAJ_ != null)
			{
				if (this.nALGCLKBBAJ_ == null)
				{
					this.NALGCLKBBAJ = new MAKKMBLOHHO();
				}
				this.NALGCLKBBAJ.MergeFrom(other.NALGCLKBBAJ);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007BFE RID: 31742 RVA: 0x0014865C File Offset: 0x0014685C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x00148668 File Offset: 0x00146868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 58U)
					{
						if (num != 10000U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IKCMKIIEBFG = input.ReadUInt32();
						}
					}
					else
					{
						if (this.gLOAAHIMEHA_ == null)
						{
							this.GLOAAHIMEHA = new JDOCCKOMOEG();
						}
						input.ReadMessage(this.GLOAAHIMEHA);
					}
				}
				else
				{
					if (this.nALGCLKBBAJ_ == null)
					{
						this.NALGCLKBBAJ = new MAKKMBLOHHO();
					}
					input.ReadMessage(this.NALGCLKBBAJ);
				}
			}
		}

		// Token: 0x04002FAB RID: 12203
		private static readonly MessageParser<MKACCPKNCKI> _parser = new MessageParser<MKACCPKNCKI>(() => new MKACCPKNCKI());

		// Token: 0x04002FAC RID: 12204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FAD RID: 12205
		public const int IKCMKIIEBFGFieldNumber = 1250;

		// Token: 0x04002FAE RID: 12206
		private uint iKCMKIIEBFG_;

		// Token: 0x04002FAF RID: 12207
		public const int GLOAAHIMEHAFieldNumber = 7;

		// Token: 0x04002FB0 RID: 12208
		private JDOCCKOMOEG gLOAAHIMEHA_;

		// Token: 0x04002FB1 RID: 12209
		public const int NALGCLKBBAJFieldNumber = 4;

		// Token: 0x04002FB2 RID: 12210
		private MAKKMBLOHHO nALGCLKBBAJ_;
	}
}
