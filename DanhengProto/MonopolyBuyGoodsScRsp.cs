using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B0D RID: 2829
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyBuyGoodsScRsp : IMessage<MonopolyBuyGoodsScRsp>, IMessage, IEquatable<MonopolyBuyGoodsScRsp>, IDeepCloneable<MonopolyBuyGoodsScRsp>, IBufferMessage
	{
		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x06007D3B RID: 32059 RVA: 0x0014B99D File Offset: 0x00149B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyBuyGoodsScRsp> Parser
		{
			get
			{
				return MonopolyBuyGoodsScRsp._parser;
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x06007D3C RID: 32060 RVA: 0x0014B9A4 File Offset: 0x00149BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyBuyGoodsScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x06007D3D RID: 32061 RVA: 0x0014B9B6 File Offset: 0x00149BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyBuyGoodsScRsp.Descriptor;
			}
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x0014B9BD File Offset: 0x00149BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyBuyGoodsScRsp()
		{
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x0014B9C5 File Offset: 0x00149BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyBuyGoodsScRsp(MonopolyBuyGoodsScRsp other) : this()
		{
			this.shopId_ = other.shopId_;
			this.goodsId_ = other.goodsId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D40 RID: 32064 RVA: 0x0014BA02 File Offset: 0x00149C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyBuyGoodsScRsp Clone()
		{
			return new MonopolyBuyGoodsScRsp(this);
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x06007D41 RID: 32065 RVA: 0x0014BA0A File Offset: 0x00149C0A
		// (set) Token: 0x06007D42 RID: 32066 RVA: 0x0014BA12 File Offset: 0x00149C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x06007D43 RID: 32067 RVA: 0x0014BA1B File Offset: 0x00149C1B
		// (set) Token: 0x06007D44 RID: 32068 RVA: 0x0014BA23 File Offset: 0x00149C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GoodsId
		{
			get
			{
				return this.goodsId_;
			}
			set
			{
				this.goodsId_ = value;
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x06007D45 RID: 32069 RVA: 0x0014BA2C File Offset: 0x00149C2C
		// (set) Token: 0x06007D46 RID: 32070 RVA: 0x0014BA34 File Offset: 0x00149C34
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

		// Token: 0x06007D47 RID: 32071 RVA: 0x0014BA3D File Offset: 0x00149C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyBuyGoodsScRsp);
		}

		// Token: 0x06007D48 RID: 32072 RVA: 0x0014BA4C File Offset: 0x00149C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyBuyGoodsScRsp other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.GoodsId == other.GoodsId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D49 RID: 32073 RVA: 0x0014BAA8 File Offset: 0x00149CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0U)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.GoodsId != 0U)
			{
				num ^= this.GoodsId.GetHashCode();
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

		// Token: 0x06007D4A RID: 32074 RVA: 0x0014BB19 File Offset: 0x00149D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D4B RID: 32075 RVA: 0x0014BB21 File Offset: 0x00149D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x0014BB2C File Offset: 0x00149D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ShopId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GoodsId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GoodsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x0014BBA4 File Offset: 0x00149DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShopId);
			}
			if (this.GoodsId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GoodsId);
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

		// Token: 0x06007D4E RID: 32078 RVA: 0x0014BC14 File Offset: 0x00149E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyBuyGoodsScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0U)
			{
				this.ShopId = other.ShopId;
			}
			if (other.GoodsId != 0U)
			{
				this.GoodsId = other.GoodsId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x0014BC78 File Offset: 0x00149E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x0014BC84 File Offset: 0x00149E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 72U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GoodsId = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.ShopId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003022 RID: 12322
		private static readonly MessageParser<MonopolyBuyGoodsScRsp> _parser = new MessageParser<MonopolyBuyGoodsScRsp>(() => new MonopolyBuyGoodsScRsp());

		// Token: 0x04003023 RID: 12323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003024 RID: 12324
		public const int ShopIdFieldNumber = 5;

		// Token: 0x04003025 RID: 12325
		private uint shopId_;

		// Token: 0x04003026 RID: 12326
		public const int GoodsIdFieldNumber = 13;

		// Token: 0x04003027 RID: 12327
		private uint goodsId_;

		// Token: 0x04003028 RID: 12328
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04003029 RID: 12329
		private uint retcode_;
	}
}
