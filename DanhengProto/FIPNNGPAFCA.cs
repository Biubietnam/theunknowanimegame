using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005A7 RID: 1447
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FIPNNGPAFCA : IMessage<FIPNNGPAFCA>, IMessage, IEquatable<FIPNNGPAFCA>, IDeepCloneable<FIPNNGPAFCA>, IBufferMessage
	{
		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06004095 RID: 16533 RVA: 0x000AFDD3 File Offset: 0x000ADFD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FIPNNGPAFCA> Parser
		{
			get
			{
				return FIPNNGPAFCA._parser;
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06004096 RID: 16534 RVA: 0x000AFDDA File Offset: 0x000ADFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FIPNNGPAFCAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06004097 RID: 16535 RVA: 0x000AFDEC File Offset: 0x000ADFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FIPNNGPAFCA.Descriptor;
			}
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x000AFDF3 File Offset: 0x000ADFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPNNGPAFCA()
		{
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x000AFDFC File Offset: 0x000ADFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPNNGPAFCA(FIPNNGPAFCA other) : this()
		{
			this.gFDGGCBGGGD_ = other.gFDGGCBGGGD_;
			this.iCMDONMEJGE_ = other.iCMDONMEJGE_;
			this.configId_ = other.configId_;
			this.dGGLJECCBMB_ = ((other.dGGLJECCBMB_ != null) ? other.dGGLJECCBMB_.Clone() : null);
			this.kIOAHBIDMPC_ = ((other.kIOAHBIDMPC_ != null) ? other.kIOAHBIDMPC_.Clone() : null);
			this.kIODDJOCDML_ = ((other.kIODDJOCDML_ != null) ? other.kIODDJOCDML_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x000AFE98 File Offset: 0x000AE098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPNNGPAFCA Clone()
		{
			return new FIPNNGPAFCA(this);
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x0600409B RID: 16539 RVA: 0x000AFEA0 File Offset: 0x000AE0A0
		// (set) Token: 0x0600409C RID: 16540 RVA: 0x000AFEA8 File Offset: 0x000AE0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GFDGGCBGGGD
		{
			get
			{
				return this.gFDGGCBGGGD_;
			}
			set
			{
				this.gFDGGCBGGGD_ = value;
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x0600409D RID: 16541 RVA: 0x000AFEB1 File Offset: 0x000AE0B1
		// (set) Token: 0x0600409E RID: 16542 RVA: 0x000AFEB9 File Offset: 0x000AE0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ICMDONMEJGE
		{
			get
			{
				return this.iCMDONMEJGE_;
			}
			set
			{
				this.iCMDONMEJGE_ = value;
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x000AFEC2 File Offset: 0x000AE0C2
		// (set) Token: 0x060040A0 RID: 16544 RVA: 0x000AFECA File Offset: 0x000AE0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x060040A1 RID: 16545 RVA: 0x000AFED3 File Offset: 0x000AE0D3
		// (set) Token: 0x060040A2 RID: 16546 RVA: 0x000AFEDB File Offset: 0x000AE0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PNCEOHPFFON DGGLJECCBMB
		{
			get
			{
				return this.dGGLJECCBMB_;
			}
			set
			{
				this.dGGLJECCBMB_ = value;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x000AFEE4 File Offset: 0x000AE0E4
		// (set) Token: 0x060040A4 RID: 16548 RVA: 0x000AFEEC File Offset: 0x000AE0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HELBEIHMGKK KIOAHBIDMPC
		{
			get
			{
				return this.kIOAHBIDMPC_;
			}
			set
			{
				this.kIOAHBIDMPC_ = value;
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x060040A5 RID: 16549 RVA: 0x000AFEF5 File Offset: 0x000AE0F5
		// (set) Token: 0x060040A6 RID: 16550 RVA: 0x000AFEFD File Offset: 0x000AE0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JCBAJJIFBKN KIODDJOCDML
		{
			get
			{
				return this.kIODDJOCDML_;
			}
			set
			{
				this.kIODDJOCDML_ = value;
			}
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x000AFF06 File Offset: 0x000AE106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FIPNNGPAFCA);
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x000AFF14 File Offset: 0x000AE114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FIPNNGPAFCA other)
		{
			return other != null && (other == this || (this.GFDGGCBGGGD == other.GFDGGCBGGGD && this.ICMDONMEJGE == other.ICMDONMEJGE && this.ConfigId == other.ConfigId && object.Equals(this.DGGLJECCBMB, other.DGGLJECCBMB) && object.Equals(this.KIOAHBIDMPC, other.KIOAHBIDMPC) && object.Equals(this.KIODDJOCDML, other.KIODDJOCDML) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x000AFFAC File Offset: 0x000AE1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GFDGGCBGGGD != 0U)
			{
				num ^= this.GFDGGCBGGGD.GetHashCode();
			}
			if (this.ICMDONMEJGE != 0U)
			{
				num ^= this.ICMDONMEJGE.GetHashCode();
			}
			if (this.ConfigId != 0U)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.dGGLJECCBMB_ != null)
			{
				num ^= this.DGGLJECCBMB.GetHashCode();
			}
			if (this.kIOAHBIDMPC_ != null)
			{
				num ^= this.KIOAHBIDMPC.GetHashCode();
			}
			if (this.kIODDJOCDML_ != null)
			{
				num ^= this.KIODDJOCDML.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x000B005F File Offset: 0x000AE25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x000B0067 File Offset: 0x000AE267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x000B0070 File Offset: 0x000AE270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dGGLJECCBMB_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.DGGLJECCBMB);
			}
			if (this.kIODDJOCDML_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.KIODDJOCDML);
			}
			if (this.kIOAHBIDMPC_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.KIOAHBIDMPC);
			}
			if (this.ConfigId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ConfigId);
			}
			if (this.ICMDONMEJGE != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ICMDONMEJGE);
			}
			if (this.GFDGGCBGGGD != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GFDGGCBGGGD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x000B013C File Offset: 0x000AE33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GFDGGCBGGGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GFDGGCBGGGD);
			}
			if (this.ICMDONMEJGE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ICMDONMEJGE);
			}
			if (this.ConfigId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConfigId);
			}
			if (this.dGGLJECCBMB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DGGLJECCBMB);
			}
			if (this.kIOAHBIDMPC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KIOAHBIDMPC);
			}
			if (this.kIODDJOCDML_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KIODDJOCDML);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x000B01F4 File Offset: 0x000AE3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FIPNNGPAFCA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GFDGGCBGGGD != 0U)
			{
				this.GFDGGCBGGGD = other.GFDGGCBGGGD;
			}
			if (other.ICMDONMEJGE != 0U)
			{
				this.ICMDONMEJGE = other.ICMDONMEJGE;
			}
			if (other.ConfigId != 0U)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.dGGLJECCBMB_ != null)
			{
				if (this.dGGLJECCBMB_ == null)
				{
					this.DGGLJECCBMB = new PNCEOHPFFON();
				}
				this.DGGLJECCBMB.MergeFrom(other.DGGLJECCBMB);
			}
			if (other.kIOAHBIDMPC_ != null)
			{
				if (this.kIOAHBIDMPC_ == null)
				{
					this.KIOAHBIDMPC = new HELBEIHMGKK();
				}
				this.KIOAHBIDMPC.MergeFrom(other.KIOAHBIDMPC);
			}
			if (other.kIODDJOCDML_ != null)
			{
				if (this.kIODDJOCDML_ == null)
				{
					this.KIODDJOCDML = new JCBAJJIFBKN();
				}
				this.KIODDJOCDML.MergeFrom(other.KIODDJOCDML);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x000B02DC File Offset: 0x000AE4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x000B02E8 File Offset: 0x000AE4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 26U)
					{
						if (this.dGGLJECCBMB_ == null)
						{
							this.DGGLJECCBMB = new PNCEOHPFFON();
						}
						input.ReadMessage(this.DGGLJECCBMB);
						continue;
					}
					if (num == 58U)
					{
						if (this.kIODDJOCDML_ == null)
						{
							this.KIODDJOCDML = new JCBAJJIFBKN();
						}
						input.ReadMessage(this.KIODDJOCDML);
						continue;
					}
					if (num == 74U)
					{
						if (this.kIOAHBIDMPC_ == null)
						{
							this.KIOAHBIDMPC = new HELBEIHMGKK();
						}
						input.ReadMessage(this.KIOAHBIDMPC);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ConfigId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ICMDONMEJGE = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.GFDGGCBGGGD = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400199E RID: 6558
		private static readonly MessageParser<FIPNNGPAFCA> _parser = new MessageParser<FIPNNGPAFCA>(() => new FIPNNGPAFCA());

		// Token: 0x0400199F RID: 6559
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019A0 RID: 6560
		public const int GFDGGCBGGGDFieldNumber = 14;

		// Token: 0x040019A1 RID: 6561
		private uint gFDGGCBGGGD_;

		// Token: 0x040019A2 RID: 6562
		public const int ICMDONMEJGEFieldNumber = 12;

		// Token: 0x040019A3 RID: 6563
		private uint iCMDONMEJGE_;

		// Token: 0x040019A4 RID: 6564
		public const int ConfigIdFieldNumber = 10;

		// Token: 0x040019A5 RID: 6565
		private uint configId_;

		// Token: 0x040019A6 RID: 6566
		public const int DGGLJECCBMBFieldNumber = 3;

		// Token: 0x040019A7 RID: 6567
		private PNCEOHPFFON dGGLJECCBMB_;

		// Token: 0x040019A8 RID: 6568
		public const int KIOAHBIDMPCFieldNumber = 9;

		// Token: 0x040019A9 RID: 6569
		private HELBEIHMGKK kIOAHBIDMPC_;

		// Token: 0x040019AA RID: 6570
		public const int KIODDJOCDMLFieldNumber = 7;

		// Token: 0x040019AB RID: 6571
		private JCBAJJIFBKN kIODDJOCDML_;
	}
}
