using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007F7 RID: 2039
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetShopListScRsp : IMessage<GetShopListScRsp>, IMessage, IEquatable<GetShopListScRsp>, IDeepCloneable<GetShopListScRsp>, IBufferMessage
	{
		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06005AED RID: 23277 RVA: 0x000F231D File Offset: 0x000F051D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetShopListScRsp> Parser
		{
			get
			{
				return GetShopListScRsp._parser;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06005AEE RID: 23278 RVA: 0x000F2324 File Offset: 0x000F0524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetShopListScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06005AEF RID: 23279 RVA: 0x000F2336 File Offset: 0x000F0536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetShopListScRsp.Descriptor;
			}
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x000F233D File Offset: 0x000F053D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShopListScRsp()
		{
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x000F2350 File Offset: 0x000F0550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShopListScRsp(GetShopListScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.shopList_ = other.shopList_.Clone();
			this.shopType_ = other.shopType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x000F239D File Offset: 0x000F059D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShopListScRsp Clone()
		{
			return new GetShopListScRsp(this);
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06005AF3 RID: 23283 RVA: 0x000F23A5 File Offset: 0x000F05A5
		// (set) Token: 0x06005AF4 RID: 23284 RVA: 0x000F23AD File Offset: 0x000F05AD
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

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06005AF5 RID: 23285 RVA: 0x000F23B6 File Offset: 0x000F05B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Shop> ShopList
		{
			get
			{
				return this.shopList_;
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06005AF6 RID: 23286 RVA: 0x000F23BE File Offset: 0x000F05BE
		// (set) Token: 0x06005AF7 RID: 23287 RVA: 0x000F23C6 File Offset: 0x000F05C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ShopType
		{
			get
			{
				return this.shopType_;
			}
			set
			{
				this.shopType_ = value;
			}
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x000F23CF File Offset: 0x000F05CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetShopListScRsp);
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x000F23E0 File Offset: 0x000F05E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetShopListScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.shopList_.Equals(other.shopList_) && this.ShopType == other.ShopType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x000F2440 File Offset: 0x000F0640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.shopList_.GetHashCode();
			if (this.ShopType != 0U)
			{
				num ^= this.ShopType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x000F24A6 File Offset: 0x000F06A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x000F24AE File Offset: 0x000F06AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x000F24B8 File Offset: 0x000F06B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shopList_.WriteTo(ref output, GetShopListScRsp._repeated_shopList_codec);
			if (this.ShopType != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ShopType);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x000F2524 File Offset: 0x000F0724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.shopList_.CalculateSize(GetShopListScRsp._repeated_shopList_codec);
			if (this.ShopType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShopType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x000F2590 File Offset: 0x000F0790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetShopListScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.shopList_.Add(other.shopList_);
			if (other.ShopType != 0U)
			{
				this.ShopType = other.ShopType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x000F25F1 File Offset: 0x000F07F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x000F25FC File Offset: 0x000F07FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 40U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.ShopType = input.ReadUInt32();
					}
				}
				else
				{
					this.shopList_.AddEntriesFrom(ref input, GetShopListScRsp._repeated_shopList_codec);
				}
			}
		}

		// Token: 0x0400233F RID: 9023
		private static readonly MessageParser<GetShopListScRsp> _parser = new MessageParser<GetShopListScRsp>(() => new GetShopListScRsp());

		// Token: 0x04002340 RID: 9024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002341 RID: 9025
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04002342 RID: 9026
		private uint retcode_;

		// Token: 0x04002343 RID: 9027
		public const int ShopListFieldNumber = 1;

		// Token: 0x04002344 RID: 9028
		private static readonly FieldCodec<Shop> _repeated_shopList_codec = FieldCodec.ForMessage<Shop>(10U, Shop.Parser);

		// Token: 0x04002345 RID: 9029
		private readonly RepeatedField<Shop> shopList_ = new RepeatedField<Shop>();

		// Token: 0x04002346 RID: 9030
		public const int ShopTypeFieldNumber = 5;

		// Token: 0x04002347 RID: 9031
		private uint shopType_;
	}
}
