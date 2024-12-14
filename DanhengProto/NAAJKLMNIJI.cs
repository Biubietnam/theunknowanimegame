using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BF5 RID: 3061
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NAAJKLMNIJI : IMessage<NAAJKLMNIJI>, IMessage, IEquatable<NAAJKLMNIJI>, IDeepCloneable<NAAJKLMNIJI>, IBufferMessage
	{
		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x06008775 RID: 34677 RVA: 0x001653C3 File Offset: 0x001635C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NAAJKLMNIJI> Parser
		{
			get
			{
				return NAAJKLMNIJI._parser;
			}
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x06008776 RID: 34678 RVA: 0x001653CA File Offset: 0x001635CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NAAJKLMNIJIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x06008777 RID: 34679 RVA: 0x001653DC File Offset: 0x001635DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NAAJKLMNIJI.Descriptor;
			}
		}

		// Token: 0x06008778 RID: 34680 RVA: 0x001653E3 File Offset: 0x001635E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NAAJKLMNIJI()
		{
		}

		// Token: 0x06008779 RID: 34681 RVA: 0x001653EC File Offset: 0x001635EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NAAJKLMNIJI(NAAJKLMNIJI other) : this()
		{
			this.jICKDPMEDIB_ = ((other.jICKDPMEDIB_ != null) ? other.jICKDPMEDIB_.Clone() : null);
			this.aDAPKPJKOJM_ = ((other.aDAPKPJKOJM_ != null) ? other.aDAPKPJKOJM_.Clone() : null);
			this.displayType_ = other.displayType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600877A RID: 34682 RVA: 0x00165454 File Offset: 0x00163654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NAAJKLMNIJI Clone()
		{
			return new NAAJKLMNIJI(this);
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x0600877B RID: 34683 RVA: 0x0016545C File Offset: 0x0016365C
		// (set) Token: 0x0600877C RID: 34684 RVA: 0x00165464 File Offset: 0x00163664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GHHNONNKCKJ JICKDPMEDIB
		{
			get
			{
				return this.jICKDPMEDIB_;
			}
			set
			{
				this.jICKDPMEDIB_ = value;
			}
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x0600877D RID: 34685 RVA: 0x0016546D File Offset: 0x0016366D
		// (set) Token: 0x0600877E RID: 34686 RVA: 0x00165475 File Offset: 0x00163675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFAMGMKCPLN ADAPKPJKOJM
		{
			get
			{
				return this.aDAPKPJKOJM_;
			}
			set
			{
				this.aDAPKPJKOJM_ = value;
			}
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x0600877F RID: 34687 RVA: 0x0016547E File Offset: 0x0016367E
		// (set) Token: 0x06008780 RID: 34688 RVA: 0x00165486 File Offset: 0x00163686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRecordType DisplayType
		{
			get
			{
				return this.displayType_;
			}
			set
			{
				this.displayType_ = value;
			}
		}

		// Token: 0x06008781 RID: 34689 RVA: 0x0016548F File Offset: 0x0016368F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NAAJKLMNIJI);
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x001654A0 File Offset: 0x001636A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NAAJKLMNIJI other)
		{
			return other != null && (other == this || (object.Equals(this.JICKDPMEDIB, other.JICKDPMEDIB) && object.Equals(this.ADAPKPJKOJM, other.ADAPKPJKOJM) && this.DisplayType == other.DisplayType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x00165504 File Offset: 0x00163704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.jICKDPMEDIB_ != null)
			{
				num ^= this.JICKDPMEDIB.GetHashCode();
			}
			if (this.aDAPKPJKOJM_ != null)
			{
				num ^= this.ADAPKPJKOJM.GetHashCode();
			}
			if (this.DisplayType != BattleRecordType.BattleRecordNone)
			{
				num ^= this.DisplayType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x00165575 File Offset: 0x00163775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x0016557D File Offset: 0x0016377D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x00165588 File Offset: 0x00163788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DisplayType != BattleRecordType.BattleRecordNone)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.DisplayType);
			}
			if (this.aDAPKPJKOJM_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ADAPKPJKOJM);
			}
			if (this.jICKDPMEDIB_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.JICKDPMEDIB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x00165600 File Offset: 0x00163800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.jICKDPMEDIB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JICKDPMEDIB);
			}
			if (this.aDAPKPJKOJM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ADAPKPJKOJM);
			}
			if (this.DisplayType != BattleRecordType.BattleRecordNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DisplayType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x00165670 File Offset: 0x00163870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NAAJKLMNIJI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.jICKDPMEDIB_ != null)
			{
				if (this.jICKDPMEDIB_ == null)
				{
					this.JICKDPMEDIB = new GHHNONNKCKJ();
				}
				this.JICKDPMEDIB.MergeFrom(other.JICKDPMEDIB);
			}
			if (other.aDAPKPJKOJM_ != null)
			{
				if (this.aDAPKPJKOJM_ == null)
				{
					this.ADAPKPJKOJM = new BFAMGMKCPLN();
				}
				this.ADAPKPJKOJM.MergeFrom(other.ADAPKPJKOJM);
			}
			if (other.DisplayType != BattleRecordType.BattleRecordNone)
			{
				this.DisplayType = other.DisplayType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008789 RID: 34697 RVA: 0x00165704 File Offset: 0x00163904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600878A RID: 34698 RVA: 0x00165710 File Offset: 0x00163910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 90U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.jICKDPMEDIB_ == null)
							{
								this.JICKDPMEDIB = new GHHNONNKCKJ();
							}
							input.ReadMessage(this.JICKDPMEDIB);
						}
					}
					else
					{
						if (this.aDAPKPJKOJM_ == null)
						{
							this.ADAPKPJKOJM = new BFAMGMKCPLN();
						}
						input.ReadMessage(this.ADAPKPJKOJM);
					}
				}
				else
				{
					this.DisplayType = (BattleRecordType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040033D8 RID: 13272
		private static readonly MessageParser<NAAJKLMNIJI> _parser = new MessageParser<NAAJKLMNIJI>(() => new NAAJKLMNIJI());

		// Token: 0x040033D9 RID: 13273
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033DA RID: 13274
		public const int JICKDPMEDIBFieldNumber = 14;

		// Token: 0x040033DB RID: 13275
		private GHHNONNKCKJ jICKDPMEDIB_;

		// Token: 0x040033DC RID: 13276
		public const int ADAPKPJKOJMFieldNumber = 11;

		// Token: 0x040033DD RID: 13277
		private BFAMGMKCPLN aDAPKPJKOJM_;

		// Token: 0x040033DE RID: 13278
		public const int DisplayTypeFieldNumber = 7;

		// Token: 0x040033DF RID: 13279
		private BattleRecordType displayType_;
	}
}
