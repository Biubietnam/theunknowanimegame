using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001DD RID: 477
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CHBBGEIDOGB : IMessage<CHBBGEIDOGB>, IMessage, IEquatable<CHBBGEIDOGB>, IDeepCloneable<CHBBGEIDOGB>, IBufferMessage
	{
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x0003D2D7 File Offset: 0x0003B4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CHBBGEIDOGB> Parser
		{
			get
			{
				return CHBBGEIDOGB._parser;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x0003D2DE File Offset: 0x0003B4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CHBBGEIDOGBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x0003D2F0 File Offset: 0x0003B4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CHBBGEIDOGB.Descriptor;
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0003D2F7 File Offset: 0x0003B4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CHBBGEIDOGB()
		{
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0003D318 File Offset: 0x0003B518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CHBBGEIDOGB(CHBBGEIDOGB other) : this()
		{
			this.kLKJAHFIBDP_ = other.kLKJAHFIBDP_;
			this.oAMALOBBAAO_ = other.oAMALOBBAAO_;
			this.uniqueId_ = other.uniqueId_;
			this.aAHPIPPPBCN_ = other.aAHPIPPPBCN_.Clone();
			this.gDLLHHELILE_ = other.gDLLHHELILE_;
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0003D38E File Offset: 0x0003B58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CHBBGEIDOGB Clone()
		{
			return new CHBBGEIDOGB(this);
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x0003D396 File Offset: 0x0003B596
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x0003D39E File Offset: 0x0003B59E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KLKJAHFIBDP
		{
			get
			{
				return this.kLKJAHFIBDP_;
			}
			set
			{
				this.kLKJAHFIBDP_ = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x0003D3A7 File Offset: 0x0003B5A7
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x0003D3AF File Offset: 0x0003B5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OAMALOBBAAO
		{
			get
			{
				return this.oAMALOBBAAO_;
			}
			set
			{
				this.oAMALOBBAAO_ = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0003D3B8 File Offset: 0x0003B5B8
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x0003D3C0 File Offset: 0x0003B5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0003D3C9 File Offset: 0x0003B5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AAHPIPPPBCN
		{
			get
			{
				return this.aAHPIPPPBCN_;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x0003D3D1 File Offset: 0x0003B5D1
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x0003D3D9 File Offset: 0x0003B5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GDLLHHELILE
		{
			get
			{
				return this.gDLLHHELILE_;
			}
			set
			{
				this.gDLLHHELILE_ = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x0003D3E2 File Offset: 0x0003B5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0003D3EA File Offset: 0x0003B5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CHBBGEIDOGB);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x0003D3F8 File Offset: 0x0003B5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CHBBGEIDOGB other)
		{
			return other != null && (other == this || (this.KLKJAHFIBDP == other.KLKJAHFIBDP && this.OAMALOBBAAO == other.OAMALOBBAAO && this.UniqueId == other.UniqueId && this.aAHPIPPPBCN_.Equals(other.aAHPIPPPBCN_) && this.GDLLHHELILE == other.GDLLHHELILE && this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0003D48C File Offset: 0x0003B68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KLKJAHFIBDP != 0U)
			{
				num ^= this.KLKJAHFIBDP.GetHashCode();
			}
			if (this.OAMALOBBAAO)
			{
				num ^= this.OAMALOBBAAO.GetHashCode();
			}
			if (this.UniqueId != 0U)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			num ^= this.aAHPIPPPBCN_.GetHashCode();
			if (this.GDLLHHELILE != 0U)
			{
				num ^= this.GDLLHHELILE.GetHashCode();
			}
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0003D532 File Offset: 0x0003B732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0003D53A File Offset: 0x0003B73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0003D544 File Offset: 0x0003B744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KLKJAHFIBDP != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.KLKJAHFIBDP);
			}
			this.aAHPIPPPBCN_.WriteTo(ref output, CHBBGEIDOGB._repeated_aAHPIPPPBCN_codec);
			if (this.GDLLHHELILE != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GDLLHHELILE);
			}
			if (this.OAMALOBBAAO)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.OAMALOBBAAO);
			}
			if (this.UniqueId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.UniqueId);
			}
			this.itemList_.WriteTo(ref output, CHBBGEIDOGB._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0003D5F8 File Offset: 0x0003B7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KLKJAHFIBDP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KLKJAHFIBDP);
			}
			if (this.OAMALOBBAAO)
			{
				num += 2;
			}
			if (this.UniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UniqueId);
			}
			num += this.aAHPIPPPBCN_.CalculateSize(CHBBGEIDOGB._repeated_aAHPIPPPBCN_codec);
			if (this.GDLLHHELILE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GDLLHHELILE);
			}
			num += this.itemList_.CalculateSize(CHBBGEIDOGB._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0003D698 File Offset: 0x0003B898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CHBBGEIDOGB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KLKJAHFIBDP != 0U)
			{
				this.KLKJAHFIBDP = other.KLKJAHFIBDP;
			}
			if (other.OAMALOBBAAO)
			{
				this.OAMALOBBAAO = other.OAMALOBBAAO;
			}
			if (other.UniqueId != 0U)
			{
				this.UniqueId = other.UniqueId;
			}
			this.aAHPIPPPBCN_.Add(other.aAHPIPPPBCN_);
			if (other.GDLLHHELILE != 0U)
			{
				this.GDLLHHELILE = other.GDLLHHELILE;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0003D732 File Offset: 0x0003B932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0003D73C File Offset: 0x0003B93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 32U)
					{
						if (num == 8U)
						{
							this.KLKJAHFIBDP = input.ReadUInt32();
							continue;
						}
						if (num != 32U)
						{
							goto IL_41;
						}
					}
					else if (num != 34U)
					{
						if (num != 40U)
						{
							goto IL_41;
						}
						this.GDLLHHELILE = input.ReadUInt32();
						continue;
					}
					this.aAHPIPPPBCN_.AddEntriesFrom(ref input, CHBBGEIDOGB._repeated_aAHPIPPPBCN_codec);
					continue;
				}
				if (num <= 72U)
				{
					if (num == 48U)
					{
						this.OAMALOBBAAO = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.UniqueId = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 104U || num == 106U)
				{
					this.itemList_.AddEntriesFrom(ref input, CHBBGEIDOGB._repeated_itemList_codec);
					continue;
				}
				IL_41:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040008F4 RID: 2292
		private static readonly MessageParser<CHBBGEIDOGB> _parser = new MessageParser<CHBBGEIDOGB>(() => new CHBBGEIDOGB());

		// Token: 0x040008F5 RID: 2293
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008F6 RID: 2294
		public const int KLKJAHFIBDPFieldNumber = 1;

		// Token: 0x040008F7 RID: 2295
		private uint kLKJAHFIBDP_;

		// Token: 0x040008F8 RID: 2296
		public const int OAMALOBBAAOFieldNumber = 6;

		// Token: 0x040008F9 RID: 2297
		private bool oAMALOBBAAO_;

		// Token: 0x040008FA RID: 2298
		public const int UniqueIdFieldNumber = 9;

		// Token: 0x040008FB RID: 2299
		private uint uniqueId_;

		// Token: 0x040008FC RID: 2300
		public const int AAHPIPPPBCNFieldNumber = 4;

		// Token: 0x040008FD RID: 2301
		private static readonly FieldCodec<uint> _repeated_aAHPIPPPBCN_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040008FE RID: 2302
		private readonly RepeatedField<uint> aAHPIPPPBCN_ = new RepeatedField<uint>();

		// Token: 0x040008FF RID: 2303
		public const int GDLLHHELILEFieldNumber = 5;

		// Token: 0x04000900 RID: 2304
		private uint gDLLHHELILE_;

		// Token: 0x04000901 RID: 2305
		public const int ItemListFieldNumber = 13;

		// Token: 0x04000902 RID: 2306
		private static readonly FieldCodec<uint> _repeated_itemList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04000903 RID: 2307
		private readonly RepeatedField<uint> itemList_ = new RepeatedField<uint>();
	}
}
