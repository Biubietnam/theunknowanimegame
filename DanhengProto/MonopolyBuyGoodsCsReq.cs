using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B0B RID: 2827
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyBuyGoodsCsReq : IMessage<MonopolyBuyGoodsCsReq>, IMessage, IEquatable<MonopolyBuyGoodsCsReq>, IDeepCloneable<MonopolyBuyGoodsCsReq>, IBufferMessage
	{
		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x06007D24 RID: 32036 RVA: 0x0014B65C File Offset: 0x0014985C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyBuyGoodsCsReq> Parser
		{
			get
			{
				return MonopolyBuyGoodsCsReq._parser;
			}
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x06007D25 RID: 32037 RVA: 0x0014B663 File Offset: 0x00149863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyBuyGoodsCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x06007D26 RID: 32038 RVA: 0x0014B675 File Offset: 0x00149875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyBuyGoodsCsReq.Descriptor;
			}
		}

		// Token: 0x06007D27 RID: 32039 RVA: 0x0014B67C File Offset: 0x0014987C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyBuyGoodsCsReq()
		{
		}

		// Token: 0x06007D28 RID: 32040 RVA: 0x0014B684 File Offset: 0x00149884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyBuyGoodsCsReq(MonopolyBuyGoodsCsReq other) : this()
		{
			this.shopId_ = other.shopId_;
			this.goodsId_ = other.goodsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D29 RID: 32041 RVA: 0x0014B6B5 File Offset: 0x001498B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyBuyGoodsCsReq Clone()
		{
			return new MonopolyBuyGoodsCsReq(this);
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x06007D2A RID: 32042 RVA: 0x0014B6BD File Offset: 0x001498BD
		// (set) Token: 0x06007D2B RID: 32043 RVA: 0x0014B6C5 File Offset: 0x001498C5
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

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x06007D2C RID: 32044 RVA: 0x0014B6CE File Offset: 0x001498CE
		// (set) Token: 0x06007D2D RID: 32045 RVA: 0x0014B6D6 File Offset: 0x001498D6
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

		// Token: 0x06007D2E RID: 32046 RVA: 0x0014B6DF File Offset: 0x001498DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyBuyGoodsCsReq);
		}

		// Token: 0x06007D2F RID: 32047 RVA: 0x0014B6ED File Offset: 0x001498ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyBuyGoodsCsReq other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.GoodsId == other.GoodsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D30 RID: 32048 RVA: 0x0014B72C File Offset: 0x0014992C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D31 RID: 32049 RVA: 0x0014B784 File Offset: 0x00149984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D32 RID: 32050 RVA: 0x0014B78C File Offset: 0x0014998C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D33 RID: 32051 RVA: 0x0014B798 File Offset: 0x00149998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GoodsId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GoodsId);
			}
			if (this.ShopId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ShopId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D34 RID: 32052 RVA: 0x0014B7F4 File Offset: 0x001499F4
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D35 RID: 32053 RVA: 0x0014B84C File Offset: 0x00149A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyBuyGoodsCsReq other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x0014B89C File Offset: 0x00149A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x0014B8A8 File Offset: 0x00149AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ShopId = input.ReadUInt32();
					}
				}
				else
				{
					this.GoodsId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400301B RID: 12315
		private static readonly MessageParser<MonopolyBuyGoodsCsReq> _parser = new MessageParser<MonopolyBuyGoodsCsReq>(() => new MonopolyBuyGoodsCsReq());

		// Token: 0x0400301C RID: 12316
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400301D RID: 12317
		public const int ShopIdFieldNumber = 7;

		// Token: 0x0400301E RID: 12318
		private uint shopId_;

		// Token: 0x0400301F RID: 12319
		public const int GoodsIdFieldNumber = 6;

		// Token: 0x04003020 RID: 12320
		private uint goodsId_;
	}
}
