using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200008F RID: 143
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyPlacingGameScRsp : IMessage<AlleyPlacingGameScRsp>, IMessage, IEquatable<AlleyPlacingGameScRsp>, IDeepCloneable<AlleyPlacingGameScRsp>, IBufferMessage
	{
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001160B File Offset: 0x0000F80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyPlacingGameScRsp> Parser
		{
			get
			{
				return AlleyPlacingGameScRsp._parser;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00011612 File Offset: 0x0000F812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyPlacingGameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00011624 File Offset: 0x0000F824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyPlacingGameScRsp.Descriptor;
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0001162B File Offset: 0x0000F82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingGameScRsp()
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00011634 File Offset: 0x0000F834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingGameScRsp(AlleyPlacingGameScRsp other) : this()
		{
			this.iOMGNNBMCDC_ = other.iOMGNNBMCDC_;
			this.aKHLIBFGLBO_ = other.aKHLIBFGLBO_;
			this.lFNFOBHMGML_ = other.lFNFOBHMGML_;
			this.hAECOJINNDC_ = other.hAECOJINNDC_;
			this.lOHNCLANBBI_ = other.lOHNCLANBBI_;
			this.eventId_ = other.eventId_;
			this.retcode_ = other.retcode_;
			this.fELCJEININH_ = other.fELCJEININH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000116B8 File Offset: 0x0000F8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingGameScRsp Clone()
		{
			return new AlleyPlacingGameScRsp(this);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x000116C0 File Offset: 0x0000F8C0
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x000116C8 File Offset: 0x0000F8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IOMGNNBMCDC
		{
			get
			{
				return this.iOMGNNBMCDC_;
			}
			set
			{
				this.iOMGNNBMCDC_ = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x000116D1 File Offset: 0x0000F8D1
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x000116D9 File Offset: 0x0000F8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AKHLIBFGLBO
		{
			get
			{
				return this.aKHLIBFGLBO_;
			}
			set
			{
				this.aKHLIBFGLBO_ = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x000116E2 File Offset: 0x0000F8E2
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x000116EA File Offset: 0x0000F8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LFNFOBHMGML
		{
			get
			{
				return this.lFNFOBHMGML_;
			}
			set
			{
				this.lFNFOBHMGML_ = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x000116F3 File Offset: 0x0000F8F3
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x000116FB File Offset: 0x0000F8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HAECOJINNDC
		{
			get
			{
				return this.hAECOJINNDC_;
			}
			set
			{
				this.hAECOJINNDC_ = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00011704 File Offset: 0x0000F904
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x0001170C File Offset: 0x0000F90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LOHNCLANBBI
		{
			get
			{
				return this.lOHNCLANBBI_;
			}
			set
			{
				this.lOHNCLANBBI_ = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00011715 File Offset: 0x0000F915
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x0001171D File Offset: 0x0000F91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00011726 File Offset: 0x0000F926
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x0001172E File Offset: 0x0000F92E
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

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00011737 File Offset: 0x0000F937
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x0001173F File Offset: 0x0000F93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FELCJEININH
		{
			get
			{
				return this.fELCJEININH_;
			}
			set
			{
				this.fELCJEININH_ = value;
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00011748 File Offset: 0x0000F948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyPlacingGameScRsp);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00011758 File Offset: 0x0000F958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyPlacingGameScRsp other)
		{
			return other != null && (other == this || (this.IOMGNNBMCDC == other.IOMGNNBMCDC && this.AKHLIBFGLBO == other.AKHLIBFGLBO && this.LFNFOBHMGML == other.LFNFOBHMGML && this.HAECOJINNDC == other.HAECOJINNDC && this.LOHNCLANBBI == other.LOHNCLANBBI && this.EventId == other.EventId && this.Retcode == other.Retcode && this.FELCJEININH == other.FELCJEININH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00011804 File Offset: 0x0000FA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IOMGNNBMCDC != 0U)
			{
				num ^= this.IOMGNNBMCDC.GetHashCode();
			}
			if (this.AKHLIBFGLBO != 0U)
			{
				num ^= this.AKHLIBFGLBO.GetHashCode();
			}
			if (this.LFNFOBHMGML != 0U)
			{
				num ^= this.LFNFOBHMGML.GetHashCode();
			}
			if (this.HAECOJINNDC != 0U)
			{
				num ^= this.HAECOJINNDC.GetHashCode();
			}
			if (this.LOHNCLANBBI != 0U)
			{
				num ^= this.LOHNCLANBBI.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.FELCJEININH != 0U)
			{
				num ^= this.FELCJEININH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000118F2 File Offset: 0x0000FAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000118FA File Offset: 0x0000FAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00011904 File Offset: 0x0000FB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AKHLIBFGLBO != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AKHLIBFGLBO);
			}
			if (this.LOHNCLANBBI != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.LOHNCLANBBI);
			}
			if (this.LFNFOBHMGML != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LFNFOBHMGML);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.FELCJEININH != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.FELCJEININH);
			}
			if (this.IOMGNNBMCDC != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.IOMGNNBMCDC);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EventId);
			}
			if (this.HAECOJINNDC != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.HAECOJINNDC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00011A04 File Offset: 0x0000FC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IOMGNNBMCDC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IOMGNNBMCDC);
			}
			if (this.AKHLIBFGLBO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AKHLIBFGLBO);
			}
			if (this.LFNFOBHMGML != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LFNFOBHMGML);
			}
			if (this.HAECOJINNDC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HAECOJINNDC);
			}
			if (this.LOHNCLANBBI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LOHNCLANBBI);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.FELCJEININH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FELCJEININH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00011AEC File Offset: 0x0000FCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyPlacingGameScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IOMGNNBMCDC != 0U)
			{
				this.IOMGNNBMCDC = other.IOMGNNBMCDC;
			}
			if (other.AKHLIBFGLBO != 0U)
			{
				this.AKHLIBFGLBO = other.AKHLIBFGLBO;
			}
			if (other.LFNFOBHMGML != 0U)
			{
				this.LFNFOBHMGML = other.LFNFOBHMGML;
			}
			if (other.HAECOJINNDC != 0U)
			{
				this.HAECOJINNDC = other.HAECOJINNDC;
			}
			if (other.LOHNCLANBBI != 0U)
			{
				this.LOHNCLANBBI = other.LOHNCLANBBI;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.FELCJEININH != 0U)
			{
				this.FELCJEININH = other.FELCJEININH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00011BB4 File Offset: 0x0000FDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00011BC0 File Offset: 0x0000FDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.AKHLIBFGLBO = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.LOHNCLANBBI = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.LFNFOBHMGML = input.ReadUInt32();
							continue;
						}
						if (num == 72U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.FELCJEININH = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.IOMGNNBMCDC = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.EventId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.HAECOJINNDC = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000240 RID: 576
		private static readonly MessageParser<AlleyPlacingGameScRsp> _parser = new MessageParser<AlleyPlacingGameScRsp>(() => new AlleyPlacingGameScRsp());

		// Token: 0x04000241 RID: 577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000242 RID: 578
		public const int IOMGNNBMCDCFieldNumber = 11;

		// Token: 0x04000243 RID: 579
		private uint iOMGNNBMCDC_;

		// Token: 0x04000244 RID: 580
		public const int AKHLIBFGLBOFieldNumber = 1;

		// Token: 0x04000245 RID: 581
		private uint aKHLIBFGLBO_;

		// Token: 0x04000246 RID: 582
		public const int LFNFOBHMGMLFieldNumber = 3;

		// Token: 0x04000247 RID: 583
		private uint lFNFOBHMGML_;

		// Token: 0x04000248 RID: 584
		public const int HAECOJINNDCFieldNumber = 14;

		// Token: 0x04000249 RID: 585
		private uint hAECOJINNDC_;

		// Token: 0x0400024A RID: 586
		public const int LOHNCLANBBIFieldNumber = 2;

		// Token: 0x0400024B RID: 587
		private uint lOHNCLANBBI_;

		// Token: 0x0400024C RID: 588
		public const int EventIdFieldNumber = 12;

		// Token: 0x0400024D RID: 589
		private uint eventId_;

		// Token: 0x0400024E RID: 590
		public const int RetcodeFieldNumber = 9;

		// Token: 0x0400024F RID: 591
		private uint retcode_;

		// Token: 0x04000250 RID: 592
		public const int FELCJEININHFieldNumber = 10;

		// Token: 0x04000251 RID: 593
		private uint fELCJEININH_;
	}
}
