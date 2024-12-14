using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007D3 RID: 2003
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueShopMiracleInfoScRsp : IMessage<GetRogueShopMiracleInfoScRsp>, IMessage, IEquatable<GetRogueShopMiracleInfoScRsp>, IDeepCloneable<GetRogueShopMiracleInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06005954 RID: 22868 RVA: 0x000EE673 File Offset: 0x000EC873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueShopMiracleInfoScRsp> Parser
		{
			get
			{
				return GetRogueShopMiracleInfoScRsp._parser;
			}
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06005955 RID: 22869 RVA: 0x000EE67A File Offset: 0x000EC87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueShopMiracleInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06005956 RID: 22870 RVA: 0x000EE68C File Offset: 0x000EC88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueShopMiracleInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x000EE693 File Offset: 0x000EC893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopMiracleInfoScRsp()
		{
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x000EE69C File Offset: 0x000EC89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopMiracleInfoScRsp(GetRogueShopMiracleInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.nGOGFEDLLOO_ = other.nGOGFEDLLOO_;
			this.gameMiracleInfo_ = ((other.gameMiracleInfo_ != null) ? other.gameMiracleInfo_.Clone() : null);
			this.bDNLGEANGAO_ = ((other.bDNLGEANGAO_ != null) ? other.bDNLGEANGAO_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x000EE710 File Offset: 0x000EC910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopMiracleInfoScRsp Clone()
		{
			return new GetRogueShopMiracleInfoScRsp(this);
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x0600595A RID: 22874 RVA: 0x000EE718 File Offset: 0x000EC918
		// (set) Token: 0x0600595B RID: 22875 RVA: 0x000EE720 File Offset: 0x000EC920
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

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x0600595C RID: 22876 RVA: 0x000EE729 File Offset: 0x000EC929
		// (set) Token: 0x0600595D RID: 22877 RVA: 0x000EE731 File Offset: 0x000EC931
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

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x0600595E RID: 22878 RVA: 0x000EE73A File Offset: 0x000EC93A
		// (set) Token: 0x0600595F RID: 22879 RVA: 0x000EE742 File Offset: 0x000EC942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COOCBDAINLK GameMiracleInfo
		{
			get
			{
				return this.gameMiracleInfo_;
			}
			set
			{
				this.gameMiracleInfo_ = value;
			}
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06005960 RID: 22880 RVA: 0x000EE74B File Offset: 0x000EC94B
		// (set) Token: 0x06005961 RID: 22881 RVA: 0x000EE753 File Offset: 0x000EC953
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

		// Token: 0x06005962 RID: 22882 RVA: 0x000EE75C File Offset: 0x000EC95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueShopMiracleInfoScRsp);
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x000EE76C File Offset: 0x000EC96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueShopMiracleInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.NGOGFEDLLOO == other.NGOGFEDLLOO && object.Equals(this.GameMiracleInfo, other.GameMiracleInfo) && object.Equals(this.BDNLGEANGAO, other.BDNLGEANGAO) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x000EE7E0 File Offset: 0x000EC9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.NGOGFEDLLOO)
			{
				num ^= this.NGOGFEDLLOO.GetHashCode();
			}
			if (this.gameMiracleInfo_ != null)
			{
				num ^= this.GameMiracleInfo.GetHashCode();
			}
			if (this.bDNLGEANGAO_ != null)
			{
				num ^= this.BDNLGEANGAO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x000EE864 File Offset: 0x000ECA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x000EE86C File Offset: 0x000ECA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x000EE878 File Offset: 0x000ECA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bDNLGEANGAO_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.BDNLGEANGAO);
			}
			if (this.NGOGFEDLLOO)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.NGOGFEDLLOO);
			}
			if (this.gameMiracleInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.GameMiracleInfo);
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

		// Token: 0x06005968 RID: 22888 RVA: 0x000EE90C File Offset: 0x000ECB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.NGOGFEDLLOO)
			{
				num += 2;
			}
			if (this.gameMiracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameMiracleInfo);
			}
			if (this.bDNLGEANGAO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BDNLGEANGAO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x000EE988 File Offset: 0x000ECB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueShopMiracleInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.NGOGFEDLLOO)
			{
				this.NGOGFEDLLOO = other.NGOGFEDLLOO;
			}
			if (other.gameMiracleInfo_ != null)
			{
				if (this.gameMiracleInfo_ == null)
				{
					this.GameMiracleInfo = new COOCBDAINLK();
				}
				this.GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
			}
			if (other.bDNLGEANGAO_ != null)
			{
				if (this.bDNLGEANGAO_ == null)
				{
					this.BDNLGEANGAO = new ItemCostData();
				}
				this.BDNLGEANGAO.MergeFrom(other.BDNLGEANGAO);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x000EEA30 File Offset: 0x000ECC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x000EEA3C File Offset: 0x000ECC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 18U)
					{
						if (this.bDNLGEANGAO_ == null)
						{
							this.BDNLGEANGAO = new ItemCostData();
						}
						input.ReadMessage(this.BDNLGEANGAO);
						continue;
					}
					if (num == 40U)
					{
						this.NGOGFEDLLOO = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.gameMiracleInfo_ == null)
						{
							this.GameMiracleInfo = new COOCBDAINLK();
						}
						input.ReadMessage(this.GameMiracleInfo);
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

		// Token: 0x040022B8 RID: 8888
		private static readonly MessageParser<GetRogueShopMiracleInfoScRsp> _parser = new MessageParser<GetRogueShopMiracleInfoScRsp>(() => new GetRogueShopMiracleInfoScRsp());

		// Token: 0x040022B9 RID: 8889
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022BA RID: 8890
		public const int RetcodeFieldNumber = 14;

		// Token: 0x040022BB RID: 8891
		private uint retcode_;

		// Token: 0x040022BC RID: 8892
		public const int NGOGFEDLLOOFieldNumber = 5;

		// Token: 0x040022BD RID: 8893
		private bool nGOGFEDLLOO_;

		// Token: 0x040022BE RID: 8894
		public const int GameMiracleInfoFieldNumber = 8;

		// Token: 0x040022BF RID: 8895
		private COOCBDAINLK gameMiracleInfo_;

		// Token: 0x040022C0 RID: 8896
		public const int BDNLGEANGAOFieldNumber = 2;

		// Token: 0x040022C1 RID: 8897
		private ItemCostData bDNLGEANGAO_;
	}
}
