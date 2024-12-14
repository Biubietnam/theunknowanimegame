using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006DB RID: 1755
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetGachaInfoScRsp : IMessage<GetGachaInfoScRsp>, IMessage, IEquatable<GetGachaInfoScRsp>, IDeepCloneable<GetGachaInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06004E82 RID: 20098 RVA: 0x000D45BB File Offset: 0x000D27BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetGachaInfoScRsp> Parser
		{
			get
			{
				return GetGachaInfoScRsp._parser;
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06004E83 RID: 20099 RVA: 0x000D45C2 File Offset: 0x000D27C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetGachaInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06004E84 RID: 20100 RVA: 0x000D45D4 File Offset: 0x000D27D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGachaInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x000D45DB File Offset: 0x000D27DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaInfoScRsp()
		{
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x000D45F0 File Offset: 0x000D27F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaInfoScRsp(GetGachaInfoScRsp other) : this()
		{
			this.pJAFIMMCPDF_ = other.pJAFIMMCPDF_;
			this.hDFMNLHCOME_ = other.hDFMNLHCOME_;
			this.hJFLGCNEKKK_ = other.hJFLGCNEKKK_;
			this.gachaInfoList_ = other.gachaInfoList_.Clone();
			this.gachaRandom_ = other.gachaRandom_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x000D4661 File Offset: 0x000D2861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaInfoScRsp Clone()
		{
			return new GetGachaInfoScRsp(this);
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06004E88 RID: 20104 RVA: 0x000D4669 File Offset: 0x000D2869
		// (set) Token: 0x06004E89 RID: 20105 RVA: 0x000D4671 File Offset: 0x000D2871
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

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06004E8A RID: 20106 RVA: 0x000D467A File Offset: 0x000D287A
		// (set) Token: 0x06004E8B RID: 20107 RVA: 0x000D4682 File Offset: 0x000D2882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HDFMNLHCOME
		{
			get
			{
				return this.hDFMNLHCOME_;
			}
			set
			{
				this.hDFMNLHCOME_ = value;
			}
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06004E8C RID: 20108 RVA: 0x000D468B File Offset: 0x000D288B
		// (set) Token: 0x06004E8D RID: 20109 RVA: 0x000D4693 File Offset: 0x000D2893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HJFLGCNEKKK
		{
			get
			{
				return this.hJFLGCNEKKK_;
			}
			set
			{
				this.hJFLGCNEKKK_ = value;
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06004E8E RID: 20110 RVA: 0x000D469C File Offset: 0x000D289C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaInfo> GachaInfoList
		{
			get
			{
				return this.gachaInfoList_;
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06004E8F RID: 20111 RVA: 0x000D46A4 File Offset: 0x000D28A4
		// (set) Token: 0x06004E90 RID: 20112 RVA: 0x000D46AC File Offset: 0x000D28AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaRandom
		{
			get
			{
				return this.gachaRandom_;
			}
			set
			{
				this.gachaRandom_ = value;
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06004E91 RID: 20113 RVA: 0x000D46B5 File Offset: 0x000D28B5
		// (set) Token: 0x06004E92 RID: 20114 RVA: 0x000D46BD File Offset: 0x000D28BD
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

		// Token: 0x06004E93 RID: 20115 RVA: 0x000D46C6 File Offset: 0x000D28C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGachaInfoScRsp);
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x000D46D4 File Offset: 0x000D28D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetGachaInfoScRsp other)
		{
			return other != null && (other == this || (this.PJAFIMMCPDF == other.PJAFIMMCPDF && this.HDFMNLHCOME == other.HDFMNLHCOME && this.HJFLGCNEKKK == other.HJFLGCNEKKK && this.gachaInfoList_.Equals(other.gachaInfoList_) && this.GachaRandom == other.GachaRandom && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x000D4764 File Offset: 0x000D2964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PJAFIMMCPDF != 0U)
			{
				num ^= this.PJAFIMMCPDF.GetHashCode();
			}
			if (this.HDFMNLHCOME != 0U)
			{
				num ^= this.HDFMNLHCOME.GetHashCode();
			}
			if (this.HJFLGCNEKKK != 0U)
			{
				num ^= this.HJFLGCNEKKK.GetHashCode();
			}
			num ^= this.gachaInfoList_.GetHashCode();
			if (this.GachaRandom != 0U)
			{
				num ^= this.GachaRandom.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x000D4815 File Offset: 0x000D2A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x000D481D File Offset: 0x000D2A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x000D4828 File Offset: 0x000D2A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaRandom != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GachaRandom);
			}
			if (this.HDFMNLHCOME != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.HDFMNLHCOME);
			}
			if (this.PJAFIMMCPDF != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PJAFIMMCPDF);
			}
			this.gachaInfoList_.WriteTo(ref output, GetGachaInfoScRsp._repeated_gachaInfoList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.HJFLGCNEKKK != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.HJFLGCNEKKK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x000D48E8 File Offset: 0x000D2AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PJAFIMMCPDF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PJAFIMMCPDF);
			}
			if (this.HDFMNLHCOME != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HDFMNLHCOME);
			}
			if (this.HJFLGCNEKKK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HJFLGCNEKKK);
			}
			num += this.gachaInfoList_.CalculateSize(GetGachaInfoScRsp._repeated_gachaInfoList_codec);
			if (this.GachaRandom != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaRandom);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x000D499C File Offset: 0x000D2B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetGachaInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PJAFIMMCPDF != 0U)
			{
				this.PJAFIMMCPDF = other.PJAFIMMCPDF;
			}
			if (other.HDFMNLHCOME != 0U)
			{
				this.HDFMNLHCOME = other.HDFMNLHCOME;
			}
			if (other.HJFLGCNEKKK != 0U)
			{
				this.HJFLGCNEKKK = other.HJFLGCNEKKK;
			}
			this.gachaInfoList_.Add(other.gachaInfoList_);
			if (other.GachaRandom != 0U)
			{
				this.GachaRandom = other.GachaRandom;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x000D4A39 File Offset: 0x000D2C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x000D4A44 File Offset: 0x000D2C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 16U)
					{
						this.GachaRandom = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.HDFMNLHCOME = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.PJAFIMMCPDF = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.gachaInfoList_.AddEntriesFrom(ref input, GetGachaInfoScRsp._repeated_gachaInfoList_codec);
						continue;
					}
					if (num == 72U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.HJFLGCNEKKK = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001EFA RID: 7930
		private static readonly MessageParser<GetGachaInfoScRsp> _parser = new MessageParser<GetGachaInfoScRsp>(() => new GetGachaInfoScRsp());

		// Token: 0x04001EFB RID: 7931
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EFC RID: 7932
		public const int PJAFIMMCPDFFieldNumber = 6;

		// Token: 0x04001EFD RID: 7933
		private uint pJAFIMMCPDF_;

		// Token: 0x04001EFE RID: 7934
		public const int HDFMNLHCOMEFieldNumber = 5;

		// Token: 0x04001EFF RID: 7935
		private uint hDFMNLHCOME_;

		// Token: 0x04001F00 RID: 7936
		public const int HJFLGCNEKKKFieldNumber = 12;

		// Token: 0x04001F01 RID: 7937
		private uint hJFLGCNEKKK_;

		// Token: 0x04001F02 RID: 7938
		public const int GachaInfoListFieldNumber = 8;

		// Token: 0x04001F03 RID: 7939
		private static readonly FieldCodec<GachaInfo> _repeated_gachaInfoList_codec = FieldCodec.ForMessage<GachaInfo>(66U, GachaInfo.Parser);

		// Token: 0x04001F04 RID: 7940
		private readonly RepeatedField<GachaInfo> gachaInfoList_ = new RepeatedField<GachaInfo>();

		// Token: 0x04001F05 RID: 7941
		public const int GachaRandomFieldNumber = 2;

		// Token: 0x04001F06 RID: 7942
		private uint gachaRandom_;

		// Token: 0x04001F07 RID: 7943
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04001F08 RID: 7944
		private uint retcode_;
	}
}
