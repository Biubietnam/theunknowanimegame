using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000907 RID: 2311
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HPACKIIECGI : IMessage<HPACKIIECGI>, IMessage, IEquatable<HPACKIIECGI>, IDeepCloneable<HPACKIIECGI>, IBufferMessage
	{
		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06006717 RID: 26391 RVA: 0x001134F3 File Offset: 0x001116F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HPACKIIECGI> Parser
		{
			get
			{
				return HPACKIIECGI._parser;
			}
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06006718 RID: 26392 RVA: 0x001134FA File Offset: 0x001116FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HPACKIIECGIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06006719 RID: 26393 RVA: 0x0011350C File Offset: 0x0011170C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HPACKIIECGI.Descriptor;
			}
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x00113513 File Offset: 0x00111713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPACKIIECGI()
		{
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x0011351C File Offset: 0x0011171C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPACKIIECGI(HPACKIIECGI other) : this()
		{
			this.jMDIKHHFHOL_ = ((other.jMDIKHHFHOL_ != null) ? other.jMDIKHHFHOL_.Clone() : null);
			this.aHHOJCJBPFJ_ = ((other.aHHOJCJBPFJ_ != null) ? other.aHHOJCJBPFJ_.Clone() : null);
			this.iLJELJIFLHA_ = ((other.iLJELJIFLHA_ != null) ? other.iLJELJIFLHA_.Clone() : null);
			this.bHBMJNIHINK_ = ((other.bHBMJNIHINK_ != null) ? other.bHBMJNIHINK_.Clone() : null);
			this.pBMJABBAGMM_ = ((other.pBMJABBAGMM_ != null) ? other.pBMJABBAGMM_.Clone() : null);
			this.eNNMPOCKOEI_ = ((other.eNNMPOCKOEI_ != null) ? other.eNNMPOCKOEI_.Clone() : null);
			this.oPINEILCLOJ_ = ((other.oPINEILCLOJ_ != null) ? other.oPINEILCLOJ_.Clone() : null);
			this.hCJIDCPLOGD_ = ((other.hCJIDCPLOGD_ != null) ? other.hCJIDCPLOGD_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x00113620 File Offset: 0x00111820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPACKIIECGI Clone()
		{
			return new HPACKIIECGI(this);
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x0600671D RID: 26397 RVA: 0x00113628 File Offset: 0x00111828
		// (set) Token: 0x0600671E RID: 26398 RVA: 0x00113630 File Offset: 0x00111830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJBCEMNDHDH JMDIKHHFHOL
		{
			get
			{
				return this.jMDIKHHFHOL_;
			}
			set
			{
				this.jMDIKHHFHOL_ = value;
			}
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x0600671F RID: 26399 RVA: 0x00113639 File Offset: 0x00111839
		// (set) Token: 0x06006720 RID: 26400 RVA: 0x00113641 File Offset: 0x00111841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HNNKHMPLHFL AHHOJCJBPFJ
		{
			get
			{
				return this.aHHOJCJBPFJ_;
			}
			set
			{
				this.aHHOJCJBPFJ_ = value;
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06006721 RID: 26401 RVA: 0x0011364A File Offset: 0x0011184A
		// (set) Token: 0x06006722 RID: 26402 RVA: 0x00113652 File Offset: 0x00111852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOAMENEAPNI ILJELJIFLHA
		{
			get
			{
				return this.iLJELJIFLHA_;
			}
			set
			{
				this.iLJELJIFLHA_ = value;
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06006723 RID: 26403 RVA: 0x0011365B File Offset: 0x0011185B
		// (set) Token: 0x06006724 RID: 26404 RVA: 0x00113663 File Offset: 0x00111863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JBBIBKOIEDB BHBMJNIHINK
		{
			get
			{
				return this.bHBMJNIHINK_;
			}
			set
			{
				this.bHBMJNIHINK_ = value;
			}
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06006725 RID: 26405 RVA: 0x0011366C File Offset: 0x0011186C
		// (set) Token: 0x06006726 RID: 26406 RVA: 0x00113674 File Offset: 0x00111874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AMHGAANHDMN PBMJABBAGMM
		{
			get
			{
				return this.pBMJABBAGMM_;
			}
			set
			{
				this.pBMJABBAGMM_ = value;
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06006727 RID: 26407 RVA: 0x0011367D File Offset: 0x0011187D
		// (set) Token: 0x06006728 RID: 26408 RVA: 0x00113685 File Offset: 0x00111885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMIDIIBGJLJ ENNMPOCKOEI
		{
			get
			{
				return this.eNNMPOCKOEI_;
			}
			set
			{
				this.eNNMPOCKOEI_ = value;
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06006729 RID: 26409 RVA: 0x0011368E File Offset: 0x0011188E
		// (set) Token: 0x0600672A RID: 26410 RVA: 0x00113696 File Offset: 0x00111896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHEMAFBELBK OPINEILCLOJ
		{
			get
			{
				return this.oPINEILCLOJ_;
			}
			set
			{
				this.oPINEILCLOJ_ = value;
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x0600672B RID: 26411 RVA: 0x0011369F File Offset: 0x0011189F
		// (set) Token: 0x0600672C RID: 26412 RVA: 0x001136A7 File Offset: 0x001118A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JHHKEBFANLL HCJIDCPLOGD
		{
			get
			{
				return this.hCJIDCPLOGD_;
			}
			set
			{
				this.hCJIDCPLOGD_ = value;
			}
		}

		// Token: 0x0600672D RID: 26413 RVA: 0x001136B0 File Offset: 0x001118B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HPACKIIECGI);
		}

		// Token: 0x0600672E RID: 26414 RVA: 0x001136C0 File Offset: 0x001118C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HPACKIIECGI other)
		{
			return other != null && (other == this || (object.Equals(this.JMDIKHHFHOL, other.JMDIKHHFHOL) && object.Equals(this.AHHOJCJBPFJ, other.AHHOJCJBPFJ) && object.Equals(this.ILJELJIFLHA, other.ILJELJIFLHA) && object.Equals(this.BHBMJNIHINK, other.BHBMJNIHINK) && object.Equals(this.PBMJABBAGMM, other.PBMJABBAGMM) && object.Equals(this.ENNMPOCKOEI, other.ENNMPOCKOEI) && object.Equals(this.OPINEILCLOJ, other.OPINEILCLOJ) && object.Equals(this.HCJIDCPLOGD, other.HCJIDCPLOGD) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600672F RID: 26415 RVA: 0x00113794 File Offset: 0x00111994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.jMDIKHHFHOL_ != null)
			{
				num ^= this.JMDIKHHFHOL.GetHashCode();
			}
			if (this.aHHOJCJBPFJ_ != null)
			{
				num ^= this.AHHOJCJBPFJ.GetHashCode();
			}
			if (this.iLJELJIFLHA_ != null)
			{
				num ^= this.ILJELJIFLHA.GetHashCode();
			}
			if (this.bHBMJNIHINK_ != null)
			{
				num ^= this.BHBMJNIHINK.GetHashCode();
			}
			if (this.pBMJABBAGMM_ != null)
			{
				num ^= this.PBMJABBAGMM.GetHashCode();
			}
			if (this.eNNMPOCKOEI_ != null)
			{
				num ^= this.ENNMPOCKOEI.GetHashCode();
			}
			if (this.oPINEILCLOJ_ != null)
			{
				num ^= this.OPINEILCLOJ.GetHashCode();
			}
			if (this.hCJIDCPLOGD_ != null)
			{
				num ^= this.HCJIDCPLOGD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006730 RID: 26416 RVA: 0x0011386A File Offset: 0x00111A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x00113872 File Offset: 0x00111A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x0011387C File Offset: 0x00111A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aHHOJCJBPFJ_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AHHOJCJBPFJ);
			}
			if (this.pBMJABBAGMM_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PBMJABBAGMM);
			}
			if (this.hCJIDCPLOGD_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.HCJIDCPLOGD);
			}
			if (this.iLJELJIFLHA_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ILJELJIFLHA);
			}
			if (this.eNNMPOCKOEI_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ENNMPOCKOEI);
			}
			if (this.oPINEILCLOJ_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.OPINEILCLOJ);
			}
			if (this.jMDIKHHFHOL_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.JMDIKHHFHOL);
			}
			if (this.bHBMJNIHINK_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.BHBMJNIHINK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006733 RID: 26419 RVA: 0x00113980 File Offset: 0x00111B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.jMDIKHHFHOL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JMDIKHHFHOL);
			}
			if (this.aHHOJCJBPFJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AHHOJCJBPFJ);
			}
			if (this.iLJELJIFLHA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ILJELJIFLHA);
			}
			if (this.bHBMJNIHINK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BHBMJNIHINK);
			}
			if (this.pBMJABBAGMM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PBMJABBAGMM);
			}
			if (this.eNNMPOCKOEI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ENNMPOCKOEI);
			}
			if (this.oPINEILCLOJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OPINEILCLOJ);
			}
			if (this.hCJIDCPLOGD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HCJIDCPLOGD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006734 RID: 26420 RVA: 0x00113A68 File Offset: 0x00111C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HPACKIIECGI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.jMDIKHHFHOL_ != null)
			{
				if (this.jMDIKHHFHOL_ == null)
				{
					this.JMDIKHHFHOL = new JJBCEMNDHDH();
				}
				this.JMDIKHHFHOL.MergeFrom(other.JMDIKHHFHOL);
			}
			if (other.aHHOJCJBPFJ_ != null)
			{
				if (this.aHHOJCJBPFJ_ == null)
				{
					this.AHHOJCJBPFJ = new HNNKHMPLHFL();
				}
				this.AHHOJCJBPFJ.MergeFrom(other.AHHOJCJBPFJ);
			}
			if (other.iLJELJIFLHA_ != null)
			{
				if (this.iLJELJIFLHA_ == null)
				{
					this.ILJELJIFLHA = new GOAMENEAPNI();
				}
				this.ILJELJIFLHA.MergeFrom(other.ILJELJIFLHA);
			}
			if (other.bHBMJNIHINK_ != null)
			{
				if (this.bHBMJNIHINK_ == null)
				{
					this.BHBMJNIHINK = new JBBIBKOIEDB();
				}
				this.BHBMJNIHINK.MergeFrom(other.BHBMJNIHINK);
			}
			if (other.pBMJABBAGMM_ != null)
			{
				if (this.pBMJABBAGMM_ == null)
				{
					this.PBMJABBAGMM = new AMHGAANHDMN();
				}
				this.PBMJABBAGMM.MergeFrom(other.PBMJABBAGMM);
			}
			if (other.eNNMPOCKOEI_ != null)
			{
				if (this.eNNMPOCKOEI_ == null)
				{
					this.ENNMPOCKOEI = new HMIDIIBGJLJ();
				}
				this.ENNMPOCKOEI.MergeFrom(other.ENNMPOCKOEI);
			}
			if (other.oPINEILCLOJ_ != null)
			{
				if (this.oPINEILCLOJ_ == null)
				{
					this.OPINEILCLOJ = new JHEMAFBELBK();
				}
				this.OPINEILCLOJ.MergeFrom(other.OPINEILCLOJ);
			}
			if (other.hCJIDCPLOGD_ != null)
			{
				if (this.hCJIDCPLOGD_ == null)
				{
					this.HCJIDCPLOGD = new JHHKEBFANLL();
				}
				this.HCJIDCPLOGD.MergeFrom(other.HCJIDCPLOGD);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006735 RID: 26421 RVA: 0x00113BF0 File Offset: 0x00111DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006736 RID: 26422 RVA: 0x00113BFC File Offset: 0x00111DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
						{
							if (this.aHHOJCJBPFJ_ == null)
							{
								this.AHHOJCJBPFJ = new HNNKHMPLHFL();
							}
							input.ReadMessage(this.AHHOJCJBPFJ);
							continue;
						}
						if (num == 26U)
						{
							if (this.pBMJABBAGMM_ == null)
							{
								this.PBMJABBAGMM = new AMHGAANHDMN();
							}
							input.ReadMessage(this.PBMJABBAGMM);
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.hCJIDCPLOGD_ == null)
							{
								this.HCJIDCPLOGD = new JHHKEBFANLL();
							}
							input.ReadMessage(this.HCJIDCPLOGD);
							continue;
						}
						if (num == 42U)
						{
							if (this.iLJELJIFLHA_ == null)
							{
								this.ILJELJIFLHA = new GOAMENEAPNI();
							}
							input.ReadMessage(this.ILJELJIFLHA);
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 66U)
					{
						if (this.eNNMPOCKOEI_ == null)
						{
							this.ENNMPOCKOEI = new HMIDIIBGJLJ();
						}
						input.ReadMessage(this.ENNMPOCKOEI);
						continue;
					}
					if (num == 74U)
					{
						if (this.oPINEILCLOJ_ == null)
						{
							this.OPINEILCLOJ = new JHEMAFBELBK();
						}
						input.ReadMessage(this.OPINEILCLOJ);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.jMDIKHHFHOL_ == null)
						{
							this.JMDIKHHFHOL = new JJBCEMNDHDH();
						}
						input.ReadMessage(this.JMDIKHHFHOL);
						continue;
					}
					if (num == 122U)
					{
						if (this.bHBMJNIHINK_ == null)
						{
							this.BHBMJNIHINK = new JBBIBKOIEDB();
						}
						input.ReadMessage(this.BHBMJNIHINK);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002794 RID: 10132
		private static readonly MessageParser<HPACKIIECGI> _parser = new MessageParser<HPACKIIECGI>(() => new HPACKIIECGI());

		// Token: 0x04002795 RID: 10133
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002796 RID: 10134
		public const int JMDIKHHFHOLFieldNumber = 13;

		// Token: 0x04002797 RID: 10135
		private JJBCEMNDHDH jMDIKHHFHOL_;

		// Token: 0x04002798 RID: 10136
		public const int AHHOJCJBPFJFieldNumber = 1;

		// Token: 0x04002799 RID: 10137
		private HNNKHMPLHFL aHHOJCJBPFJ_;

		// Token: 0x0400279A RID: 10138
		public const int ILJELJIFLHAFieldNumber = 5;

		// Token: 0x0400279B RID: 10139
		private GOAMENEAPNI iLJELJIFLHA_;

		// Token: 0x0400279C RID: 10140
		public const int BHBMJNIHINKFieldNumber = 15;

		// Token: 0x0400279D RID: 10141
		private JBBIBKOIEDB bHBMJNIHINK_;

		// Token: 0x0400279E RID: 10142
		public const int PBMJABBAGMMFieldNumber = 3;

		// Token: 0x0400279F RID: 10143
		private AMHGAANHDMN pBMJABBAGMM_;

		// Token: 0x040027A0 RID: 10144
		public const int ENNMPOCKOEIFieldNumber = 8;

		// Token: 0x040027A1 RID: 10145
		private HMIDIIBGJLJ eNNMPOCKOEI_;

		// Token: 0x040027A2 RID: 10146
		public const int OPINEILCLOJFieldNumber = 9;

		// Token: 0x040027A3 RID: 10147
		private JHEMAFBELBK oPINEILCLOJ_;

		// Token: 0x040027A4 RID: 10148
		public const int HCJIDCPLOGDFieldNumber = 4;

		// Token: 0x040027A5 RID: 10149
		private JHHKEBFANLL hCJIDCPLOGD_;
	}
}
