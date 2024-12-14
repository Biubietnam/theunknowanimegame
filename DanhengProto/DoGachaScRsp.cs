using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003C7 RID: 967
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DoGachaScRsp : IMessage<DoGachaScRsp>, IMessage, IEquatable<DoGachaScRsp>, IDeepCloneable<DoGachaScRsp>, IBufferMessage
	{
		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x00077E5C File Offset: 0x0007605C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DoGachaScRsp> Parser
		{
			get
			{
				return DoGachaScRsp._parser;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x00077E63 File Offset: 0x00076063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DoGachaScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x00077E75 File Offset: 0x00076075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DoGachaScRsp.Descriptor;
			}
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00077E7C File Offset: 0x0007607C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaScRsp()
		{
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00077E90 File Offset: 0x00076090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaScRsp(DoGachaScRsp other) : this()
		{
			this.kEACGMLKBDK_ = other.kEACGMLKBDK_;
			this.pJAFIMMCPDF_ = other.pJAFIMMCPDF_;
			this.hNPCPDJPGLL_ = other.hNPCPDJPGLL_;
			this.gachaNum_ = other.gachaNum_;
			this.gachaId_ = other.gachaId_;
			this.ceilingNum_ = other.ceilingNum_;
			this.lHMBNMIOKHB_ = other.lHMBNMIOKHB_;
			this.retcode_ = other.retcode_;
			this.gachaItemList_ = other.gachaItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x00077F25 File Offset: 0x00076125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaScRsp Clone()
		{
			return new DoGachaScRsp(this);
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x00077F2D File Offset: 0x0007612D
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x00077F35 File Offset: 0x00076135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KEACGMLKBDK
		{
			get
			{
				return this.kEACGMLKBDK_;
			}
			set
			{
				this.kEACGMLKBDK_ = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x00077F3E File Offset: 0x0007613E
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x00077F46 File Offset: 0x00076146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PJAFIMMCPDF
		{
			get
			{
				return this.pJAFIMMCPDF_;
			}
			set
			{
				this.pJAFIMMCPDF_ = value;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x00077F4F File Offset: 0x0007614F
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x00077F57 File Offset: 0x00076157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HNPCPDJPGLL
		{
			get
			{
				return this.hNPCPDJPGLL_;
			}
			set
			{
				this.hNPCPDJPGLL_ = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x00077F60 File Offset: 0x00076160
		// (set) Token: 0x06002B10 RID: 11024 RVA: 0x00077F68 File Offset: 0x00076168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaNum
		{
			get
			{
				return this.gachaNum_;
			}
			set
			{
				this.gachaNum_ = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002B11 RID: 11025 RVA: 0x00077F71 File Offset: 0x00076171
		// (set) Token: 0x06002B12 RID: 11026 RVA: 0x00077F79 File Offset: 0x00076179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002B13 RID: 11027 RVA: 0x00077F82 File Offset: 0x00076182
		// (set) Token: 0x06002B14 RID: 11028 RVA: 0x00077F8A File Offset: 0x0007618A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CeilingNum
		{
			get
			{
				return this.ceilingNum_;
			}
			set
			{
				this.ceilingNum_ = value;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x00077F93 File Offset: 0x00076193
		// (set) Token: 0x06002B16 RID: 11030 RVA: 0x00077F9B File Offset: 0x0007619B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LHMBNMIOKHB
		{
			get
			{
				return this.lHMBNMIOKHB_;
			}
			set
			{
				this.lHMBNMIOKHB_ = value;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002B17 RID: 11031 RVA: 0x00077FA4 File Offset: 0x000761A4
		// (set) Token: 0x06002B18 RID: 11032 RVA: 0x00077FAC File Offset: 0x000761AC
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

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002B19 RID: 11033 RVA: 0x00077FB5 File Offset: 0x000761B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaItem> GachaItemList
		{
			get
			{
				return this.gachaItemList_;
			}
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00077FBD File Offset: 0x000761BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DoGachaScRsp);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x00077FCC File Offset: 0x000761CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DoGachaScRsp other)
		{
			return other != null && (other == this || (this.KEACGMLKBDK == other.KEACGMLKBDK && this.PJAFIMMCPDF == other.PJAFIMMCPDF && this.HNPCPDJPGLL == other.HNPCPDJPGLL && this.GachaNum == other.GachaNum && this.GachaId == other.GachaId && this.CeilingNum == other.CeilingNum && this.LHMBNMIOKHB == other.LHMBNMIOKHB && this.Retcode == other.Retcode && this.gachaItemList_.Equals(other.gachaItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x0007808C File Offset: 0x0007628C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KEACGMLKBDK != 0U)
			{
				num ^= this.KEACGMLKBDK.GetHashCode();
			}
			if (this.PJAFIMMCPDF != 0U)
			{
				num ^= this.PJAFIMMCPDF.GetHashCode();
			}
			if (this.HNPCPDJPGLL != 0U)
			{
				num ^= this.HNPCPDJPGLL.GetHashCode();
			}
			if (this.GachaNum != 0U)
			{
				num ^= this.GachaNum.GetHashCode();
			}
			if (this.GachaId != 0U)
			{
				num ^= this.GachaId.GetHashCode();
			}
			if (this.CeilingNum != 0U)
			{
				num ^= this.CeilingNum.GetHashCode();
			}
			if (this.LHMBNMIOKHB != 0U)
			{
				num ^= this.LHMBNMIOKHB.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.gachaItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00078188 File Offset: 0x00076388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00078190 File Offset: 0x00076390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x0007819C File Offset: 0x0007639C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CeilingNum != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CeilingNum);
			}
			if (this.PJAFIMMCPDF != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PJAFIMMCPDF);
			}
			if (this.GachaId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GachaId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			this.gachaItemList_.WriteTo(ref output, DoGachaScRsp._repeated_gachaItemList_codec);
			if (this.GachaNum != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GachaNum);
			}
			if (this.HNPCPDJPGLL != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.HNPCPDJPGLL);
			}
			if (this.KEACGMLKBDK != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.KEACGMLKBDK);
			}
			if (this.LHMBNMIOKHB != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.LHMBNMIOKHB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x000782B0 File Offset: 0x000764B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KEACGMLKBDK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KEACGMLKBDK);
			}
			if (this.PJAFIMMCPDF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PJAFIMMCPDF);
			}
			if (this.HNPCPDJPGLL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HNPCPDJPGLL);
			}
			if (this.GachaNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaNum);
			}
			if (this.GachaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaId);
			}
			if (this.CeilingNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CeilingNum);
			}
			if (this.LHMBNMIOKHB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LHMBNMIOKHB);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.gachaItemList_.CalculateSize(DoGachaScRsp._repeated_gachaItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x000783AC File Offset: 0x000765AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DoGachaScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KEACGMLKBDK != 0U)
			{
				this.KEACGMLKBDK = other.KEACGMLKBDK;
			}
			if (other.PJAFIMMCPDF != 0U)
			{
				this.PJAFIMMCPDF = other.PJAFIMMCPDF;
			}
			if (other.HNPCPDJPGLL != 0U)
			{
				this.HNPCPDJPGLL = other.HNPCPDJPGLL;
			}
			if (other.GachaNum != 0U)
			{
				this.GachaNum = other.GachaNum;
			}
			if (other.GachaId != 0U)
			{
				this.GachaId = other.GachaId;
			}
			if (other.CeilingNum != 0U)
			{
				this.CeilingNum = other.CeilingNum;
			}
			if (other.LHMBNMIOKHB != 0U)
			{
				this.LHMBNMIOKHB = other.LHMBNMIOKHB;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.gachaItemList_.Add(other.gachaItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00078485 File Offset: 0x00076685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x00078490 File Offset: 0x00076690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.CeilingNum = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.PJAFIMMCPDF = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.GachaId = input.ReadUInt32();
							continue;
						}
						if (num == 48U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 66U)
					{
						this.gachaItemList_.AddEntriesFrom(ref input, DoGachaScRsp._repeated_gachaItemList_codec);
						continue;
					}
					if (num == 88U)
					{
						this.GachaNum = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.HNPCPDJPGLL = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.KEACGMLKBDK = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.LHMBNMIOKHB = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001173 RID: 4467
		private static readonly MessageParser<DoGachaScRsp> _parser = new MessageParser<DoGachaScRsp>(() => new DoGachaScRsp());

		// Token: 0x04001174 RID: 4468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001175 RID: 4469
		public const int KEACGMLKBDKFieldNumber = 14;

		// Token: 0x04001176 RID: 4470
		private uint kEACGMLKBDK_;

		// Token: 0x04001177 RID: 4471
		public const int PJAFIMMCPDFFieldNumber = 2;

		// Token: 0x04001178 RID: 4472
		private uint pJAFIMMCPDF_;

		// Token: 0x04001179 RID: 4473
		public const int HNPCPDJPGLLFieldNumber = 13;

		// Token: 0x0400117A RID: 4474
		private uint hNPCPDJPGLL_;

		// Token: 0x0400117B RID: 4475
		public const int GachaNumFieldNumber = 11;

		// Token: 0x0400117C RID: 4476
		private uint gachaNum_;

		// Token: 0x0400117D RID: 4477
		public const int GachaIdFieldNumber = 5;

		// Token: 0x0400117E RID: 4478
		private uint gachaId_;

		// Token: 0x0400117F RID: 4479
		public const int CeilingNumFieldNumber = 1;

		// Token: 0x04001180 RID: 4480
		private uint ceilingNum_;

		// Token: 0x04001181 RID: 4481
		public const int LHMBNMIOKHBFieldNumber = 15;

		// Token: 0x04001182 RID: 4482
		private uint lHMBNMIOKHB_;

		// Token: 0x04001183 RID: 4483
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04001184 RID: 4484
		private uint retcode_;

		// Token: 0x04001185 RID: 4485
		public const int GachaItemListFieldNumber = 8;

		// Token: 0x04001186 RID: 4486
		private static readonly FieldCodec<GachaItem> _repeated_gachaItemList_codec = FieldCodec.ForMessage<GachaItem>(66U, GachaItem.Parser);

		// Token: 0x04001187 RID: 4487
		private readonly RepeatedField<GachaItem> gachaItemList_ = new RepeatedField<GachaItem>();
	}
}
