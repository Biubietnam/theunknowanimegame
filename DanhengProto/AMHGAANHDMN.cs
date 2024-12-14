using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200009F RID: 159
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AMHGAANHDMN : IMessage<AMHGAANHDMN>, IMessage, IEquatable<AMHGAANHDMN>, IDeepCloneable<AMHGAANHDMN>, IBufferMessage
	{
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x000131A8 File Offset: 0x000113A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AMHGAANHDMN> Parser
		{
			get
			{
				return AMHGAANHDMN._parser;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x000131AF File Offset: 0x000113AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AMHGAANHDMNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x000131C1 File Offset: 0x000113C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AMHGAANHDMN.Descriptor;
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000131C8 File Offset: 0x000113C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AMHGAANHDMN()
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000131D0 File Offset: 0x000113D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AMHGAANHDMN(AMHGAANHDMN other) : this()
		{
			this.cOJGEGHIADI_ = other.cOJGEGHIADI_;
			this.lEKIELODPOI_ = other.lEKIELODPOI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00013201 File Offset: 0x00011401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AMHGAANHDMN Clone()
		{
			return new AMHGAANHDMN(this);
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00013209 File Offset: 0x00011409
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00013211 File Offset: 0x00011411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint COJGEGHIADI
		{
			get
			{
				return this.cOJGEGHIADI_;
			}
			set
			{
				this.cOJGEGHIADI_ = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0001321A File Offset: 0x0001141A
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00013222 File Offset: 0x00011422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LEKIELODPOI
		{
			get
			{
				return this.lEKIELODPOI_;
			}
			set
			{
				this.lEKIELODPOI_ = value;
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001322B File Offset: 0x0001142B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AMHGAANHDMN);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00013239 File Offset: 0x00011439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AMHGAANHDMN other)
		{
			return other != null && (other == this || (this.COJGEGHIADI == other.COJGEGHIADI && this.LEKIELODPOI == other.LEKIELODPOI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00013278 File Offset: 0x00011478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.COJGEGHIADI != 0U)
			{
				num ^= this.COJGEGHIADI.GetHashCode();
			}
			if (this.LEKIELODPOI)
			{
				num ^= this.LEKIELODPOI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000132D0 File Offset: 0x000114D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000132D8 File Offset: 0x000114D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x000132E4 File Offset: 0x000114E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LEKIELODPOI)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.LEKIELODPOI);
			}
			if (this.COJGEGHIADI != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00013340 File Offset: 0x00011540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.COJGEGHIADI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COJGEGHIADI);
			}
			if (this.LEKIELODPOI)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0001338C File Offset: 0x0001158C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AMHGAANHDMN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.COJGEGHIADI != 0U)
			{
				this.COJGEGHIADI = other.COJGEGHIADI;
			}
			if (other.LEKIELODPOI)
			{
				this.LEKIELODPOI = other.LEKIELODPOI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000133DC File Offset: 0x000115DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000133E8 File Offset: 0x000115E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.COJGEGHIADI = input.ReadUInt32();
					}
				}
				else
				{
					this.LEKIELODPOI = input.ReadBool();
				}
			}
		}

		// Token: 0x0400027E RID: 638
		private static readonly MessageParser<AMHGAANHDMN> _parser = new MessageParser<AMHGAANHDMN>(() => new AMHGAANHDMN());

		// Token: 0x0400027F RID: 639
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000280 RID: 640
		public const int COJGEGHIADIFieldNumber = 12;

		// Token: 0x04000281 RID: 641
		private uint cOJGEGHIADI_;

		// Token: 0x04000282 RID: 642
		public const int LEKIELODPOIFieldNumber = 4;

		// Token: 0x04000283 RID: 643
		private bool lEKIELODPOI_;
	}
}
