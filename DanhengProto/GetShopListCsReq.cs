using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007F5 RID: 2037
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetShopListCsReq : IMessage<GetShopListCsReq>, IMessage, IEquatable<GetShopListCsReq>, IDeepCloneable<GetShopListCsReq>, IBufferMessage
	{
		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06005AD8 RID: 23256 RVA: 0x000F2090 File Offset: 0x000F0290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetShopListCsReq> Parser
		{
			get
			{
				return GetShopListCsReq._parser;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06005AD9 RID: 23257 RVA: 0x000F2097 File Offset: 0x000F0297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetShopListCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06005ADA RID: 23258 RVA: 0x000F20A9 File Offset: 0x000F02A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetShopListCsReq.Descriptor;
			}
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x000F20B0 File Offset: 0x000F02B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShopListCsReq()
		{
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x000F20B8 File Offset: 0x000F02B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShopListCsReq(GetShopListCsReq other) : this()
		{
			this.shopType_ = other.shopType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x000F20DD File Offset: 0x000F02DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetShopListCsReq Clone()
		{
			return new GetShopListCsReq(this);
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06005ADE RID: 23262 RVA: 0x000F20E5 File Offset: 0x000F02E5
		// (set) Token: 0x06005ADF RID: 23263 RVA: 0x000F20ED File Offset: 0x000F02ED
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

		// Token: 0x06005AE0 RID: 23264 RVA: 0x000F20F6 File Offset: 0x000F02F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetShopListCsReq);
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x000F2104 File Offset: 0x000F0304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetShopListCsReq other)
		{
			return other != null && (other == this || (this.ShopType == other.ShopType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x000F2134 File Offset: 0x000F0334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06005AE3 RID: 23267 RVA: 0x000F2173 File Offset: 0x000F0373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x000F217B File Offset: 0x000F037B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x000F2184 File Offset: 0x000F0384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopType != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ShopType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x000F21B8 File Offset: 0x000F03B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06005AE7 RID: 23271 RVA: 0x000F21F6 File Offset: 0x000F03F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetShopListCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopType != 0U)
			{
				this.ShopType = other.ShopType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x000F2227 File Offset: 0x000F0427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x000F2230 File Offset: 0x000F0430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ShopType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400233A RID: 9018
		private static readonly MessageParser<GetShopListCsReq> _parser = new MessageParser<GetShopListCsReq>(() => new GetShopListCsReq());

		// Token: 0x0400233B RID: 9019
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400233C RID: 9020
		public const int ShopTypeFieldNumber = 4;

		// Token: 0x0400233D RID: 9021
		private uint shopType_;
	}
}
