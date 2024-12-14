using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007CF RID: 1999
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueShopBuffInfoScRsp : IMessage<GetRogueShopBuffInfoScRsp>, IMessage, IEquatable<GetRogueShopBuffInfoScRsp>, IDeepCloneable<GetRogueShopBuffInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06005922 RID: 22818 RVA: 0x000EDDF3 File Offset: 0x000EBFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueShopBuffInfoScRsp> Parser
		{
			get
			{
				return GetRogueShopBuffInfoScRsp._parser;
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x06005923 RID: 22819 RVA: 0x000EDDFA File Offset: 0x000EBFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueShopBuffInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06005924 RID: 22820 RVA: 0x000EDE0C File Offset: 0x000EC00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueShopBuffInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x000EDE13 File Offset: 0x000EC013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopBuffInfoScRsp()
		{
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x000EDE1C File Offset: 0x000EC01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopBuffInfoScRsp(GetRogueShopBuffInfoScRsp other) : this()
		{
			this.nGOGFEDLLOO_ = other.nGOGFEDLLOO_;
			this.bDNLGEANGAO_ = ((other.bDNLGEANGAO_ != null) ? other.bDNLGEANGAO_.Clone() : null);
			this.rogueBuffInfo_ = ((other.rogueBuffInfo_ != null) ? other.rogueBuffInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x000EDE90 File Offset: 0x000EC090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopBuffInfoScRsp Clone()
		{
			return new GetRogueShopBuffInfoScRsp(this);
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06005928 RID: 22824 RVA: 0x000EDE98 File Offset: 0x000EC098
		// (set) Token: 0x06005929 RID: 22825 RVA: 0x000EDEA0 File Offset: 0x000EC0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NGOGFEDLLOO
		{
			get
			{
				return this.nGOGFEDLLOO_;
			}
			set
			{
				this.nGOGFEDLLOO_ = value;
			}
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x0600592A RID: 22826 RVA: 0x000EDEA9 File Offset: 0x000EC0A9
		// (set) Token: 0x0600592B RID: 22827 RVA: 0x000EDEB1 File Offset: 0x000EC0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData BDNLGEANGAO
		{
			get
			{
				return this.bDNLGEANGAO_;
			}
			set
			{
				this.bDNLGEANGAO_ = value;
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x0600592C RID: 22828 RVA: 0x000EDEBA File Offset: 0x000EC0BA
		// (set) Token: 0x0600592D RID: 22829 RVA: 0x000EDEC2 File Offset: 0x000EC0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JFKLIEHKDDE RogueBuffInfo
		{
			get
			{
				return this.rogueBuffInfo_;
			}
			set
			{
				this.rogueBuffInfo_ = value;
			}
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x0600592E RID: 22830 RVA: 0x000EDECB File Offset: 0x000EC0CB
		// (set) Token: 0x0600592F RID: 22831 RVA: 0x000EDED3 File Offset: 0x000EC0D3
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

		// Token: 0x06005930 RID: 22832 RVA: 0x000EDEDC File Offset: 0x000EC0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueShopBuffInfoScRsp);
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x000EDEEC File Offset: 0x000EC0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueShopBuffInfoScRsp other)
		{
			return other != null && (other == this || (this.NGOGFEDLLOO == other.NGOGFEDLLOO && object.Equals(this.BDNLGEANGAO, other.BDNLGEANGAO) && object.Equals(this.RogueBuffInfo, other.RogueBuffInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x000EDF60 File Offset: 0x000EC160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NGOGFEDLLOO)
			{
				num ^= this.NGOGFEDLLOO.GetHashCode();
			}
			if (this.bDNLGEANGAO_ != null)
			{
				num ^= this.BDNLGEANGAO.GetHashCode();
			}
			if (this.rogueBuffInfo_ != null)
			{
				num ^= this.RogueBuffInfo.GetHashCode();
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

		// Token: 0x06005933 RID: 22835 RVA: 0x000EDFE4 File Offset: 0x000EC1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x000EDFEC File Offset: 0x000EC1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x000EDFF8 File Offset: 0x000EC1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueBuffInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueBuffInfo);
			}
			if (this.bDNLGEANGAO_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BDNLGEANGAO);
			}
			if (this.NGOGFEDLLOO)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.NGOGFEDLLOO);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x000EE08C File Offset: 0x000EC28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NGOGFEDLLOO)
			{
				num += 2;
			}
			if (this.bDNLGEANGAO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BDNLGEANGAO);
			}
			if (this.rogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuffInfo);
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

		// Token: 0x06005937 RID: 22839 RVA: 0x000EE108 File Offset: 0x000EC308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueShopBuffInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NGOGFEDLLOO)
			{
				this.NGOGFEDLLOO = other.NGOGFEDLLOO;
			}
			if (other.bDNLGEANGAO_ != null)
			{
				if (this.bDNLGEANGAO_ == null)
				{
					this.BDNLGEANGAO = new ItemCostData();
				}
				this.BDNLGEANGAO.MergeFrom(other.BDNLGEANGAO);
			}
			if (other.rogueBuffInfo_ != null)
			{
				if (this.rogueBuffInfo_ == null)
				{
					this.RogueBuffInfo = new JFKLIEHKDDE();
				}
				this.RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x000EE1B0 File Offset: 0x000EC3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x000EE1BC File Offset: 0x000EC3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 18U)
					{
						if (this.rogueBuffInfo_ == null)
						{
							this.RogueBuffInfo = new JFKLIEHKDDE();
						}
						input.ReadMessage(this.RogueBuffInfo);
						continue;
					}
					if (num == 26U)
					{
						if (this.bDNLGEANGAO_ == null)
						{
							this.BDNLGEANGAO = new ItemCostData();
						}
						input.ReadMessage(this.BDNLGEANGAO);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.NGOGFEDLLOO = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022A6 RID: 8870
		private static readonly MessageParser<GetRogueShopBuffInfoScRsp> _parser = new MessageParser<GetRogueShopBuffInfoScRsp>(() => new GetRogueShopBuffInfoScRsp());

		// Token: 0x040022A7 RID: 8871
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022A8 RID: 8872
		public const int NGOGFEDLLOOFieldNumber = 8;

		// Token: 0x040022A9 RID: 8873
		private bool nGOGFEDLLOO_;

		// Token: 0x040022AA RID: 8874
		public const int BDNLGEANGAOFieldNumber = 3;

		// Token: 0x040022AB RID: 8875
		private ItemCostData bDNLGEANGAO_;

		// Token: 0x040022AC RID: 8876
		public const int RogueBuffInfoFieldNumber = 2;

		// Token: 0x040022AD RID: 8877
		private JFKLIEHKDDE rogueBuffInfo_;

		// Token: 0x040022AE RID: 8878
		public const int RetcodeFieldNumber = 14;

		// Token: 0x040022AF RID: 8879
		private uint retcode_;
	}
}
