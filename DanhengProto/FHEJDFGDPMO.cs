using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200051F RID: 1311
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FHEJDFGDPMO : IMessage<FHEJDFGDPMO>, IMessage, IEquatable<FHEJDFGDPMO>, IDeepCloneable<FHEJDFGDPMO>, IBufferMessage
	{
		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06003A98 RID: 15000 RVA: 0x000A11C4 File Offset: 0x0009F3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FHEJDFGDPMO> Parser
		{
			get
			{
				return FHEJDFGDPMO._parser;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06003A99 RID: 15001 RVA: 0x000A11CB File Offset: 0x0009F3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FHEJDFGDPMOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06003A9A RID: 15002 RVA: 0x000A11DD File Offset: 0x0009F3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FHEJDFGDPMO.Descriptor;
			}
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x000A11E4 File Offset: 0x0009F3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FHEJDFGDPMO()
		{
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x000A11F8 File Offset: 0x0009F3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FHEJDFGDPMO(FHEJDFGDPMO other) : this()
		{
			this.intReforgeNumValue_ = other.intReforgeNumValue_;
			this.fBDBGKNHLGM_ = ((other.fBDBGKNHLGM_ != null) ? other.fBDBGKNHLGM_.Clone() : null);
			this.cKHCKOMEEKO_ = other.cKHCKOMEEKO_.Clone();
			this.freeReforgeNum_ = other.freeReforgeNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x000A1261 File Offset: 0x0009F461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FHEJDFGDPMO Clone()
		{
			return new FHEJDFGDPMO(this);
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06003A9E RID: 15006 RVA: 0x000A1269 File Offset: 0x0009F469
		// (set) Token: 0x06003A9F RID: 15007 RVA: 0x000A1271 File Offset: 0x0009F471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IntReforgeNumValue
		{
			get
			{
				return this.intReforgeNumValue_;
			}
			set
			{
				this.intReforgeNumValue_ = value;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06003AA0 RID: 15008 RVA: 0x000A127A File Offset: 0x0009F47A
		// (set) Token: 0x06003AA1 RID: 15009 RVA: 0x000A1282 File Offset: 0x0009F482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData FBDBGKNHLGM
		{
			get
			{
				return this.fBDBGKNHLGM_;
			}
			set
			{
				this.fBDBGKNHLGM_ = value;
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x000A128B File Offset: 0x0009F48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, ItemCostData> CKHCKOMEEKO
		{
			get
			{
				return this.cKHCKOMEEKO_;
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x000A1293 File Offset: 0x0009F493
		// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x000A129B File Offset: 0x0009F49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FreeReforgeNum
		{
			get
			{
				return this.freeReforgeNum_;
			}
			set
			{
				this.freeReforgeNum_ = value;
			}
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x000A12A4 File Offset: 0x0009F4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FHEJDFGDPMO);
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x000A12B4 File Offset: 0x0009F4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FHEJDFGDPMO other)
		{
			return other != null && (other == this || (this.IntReforgeNumValue == other.IntReforgeNumValue && object.Equals(this.FBDBGKNHLGM, other.FBDBGKNHLGM) && this.CKHCKOMEEKO.Equals(other.CKHCKOMEEKO) && this.FreeReforgeNum == other.FreeReforgeNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x000A1328 File Offset: 0x0009F528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IntReforgeNumValue != 0)
			{
				num ^= this.IntReforgeNumValue.GetHashCode();
			}
			if (this.fBDBGKNHLGM_ != null)
			{
				num ^= this.FBDBGKNHLGM.GetHashCode();
			}
			num ^= this.CKHCKOMEEKO.GetHashCode();
			if (this.FreeReforgeNum != 0U)
			{
				num ^= this.FreeReforgeNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x000A13A4 File Offset: 0x0009F5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x000A13AC File Offset: 0x0009F5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x000A13B8 File Offset: 0x0009F5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cKHCKOMEEKO_.WriteTo(ref output, FHEJDFGDPMO._map_cKHCKOMEEKO_codec);
			if (this.fBDBGKNHLGM_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FBDBGKNHLGM);
			}
			if (this.FreeReforgeNum != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.FreeReforgeNum);
			}
			if (this.IntReforgeNumValue != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IntReforgeNumValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x000A1440 File Offset: 0x0009F640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IntReforgeNumValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IntReforgeNumValue);
			}
			if (this.fBDBGKNHLGM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FBDBGKNHLGM);
			}
			num += this.cKHCKOMEEKO_.CalculateSize(FHEJDFGDPMO._map_cKHCKOMEEKO_codec);
			if (this.FreeReforgeNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FreeReforgeNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x000A14C4 File Offset: 0x0009F6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FHEJDFGDPMO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IntReforgeNumValue != 0)
			{
				this.IntReforgeNumValue = other.IntReforgeNumValue;
			}
			if (other.fBDBGKNHLGM_ != null)
			{
				if (this.fBDBGKNHLGM_ == null)
				{
					this.FBDBGKNHLGM = new ItemCostData();
				}
				this.FBDBGKNHLGM.MergeFrom(other.FBDBGKNHLGM);
			}
			this.cKHCKOMEEKO_.MergeFrom(other.cKHCKOMEEKO_);
			if (other.FreeReforgeNum != 0U)
			{
				this.FreeReforgeNum = other.FreeReforgeNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x000A1551 File Offset: 0x0009F751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x000A155C File Offset: 0x0009F75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 34U)
					{
						this.cKHCKOMEEKO_.AddEntriesFrom(ref input, FHEJDFGDPMO._map_cKHCKOMEEKO_codec);
						continue;
					}
					if (num == 42U)
					{
						if (this.fBDBGKNHLGM_ == null)
						{
							this.FBDBGKNHLGM = new ItemCostData();
						}
						input.ReadMessage(this.FBDBGKNHLGM);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.FreeReforgeNum = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.IntReforgeNumValue = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400178D RID: 6029
		private static readonly MessageParser<FHEJDFGDPMO> _parser = new MessageParser<FHEJDFGDPMO>(() => new FHEJDFGDPMO());

		// Token: 0x0400178E RID: 6030
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400178F RID: 6031
		public const int IntReforgeNumValueFieldNumber = 11;

		// Token: 0x04001790 RID: 6032
		private int intReforgeNumValue_;

		// Token: 0x04001791 RID: 6033
		public const int FBDBGKNHLGMFieldNumber = 5;

		// Token: 0x04001792 RID: 6034
		private ItemCostData fBDBGKNHLGM_;

		// Token: 0x04001793 RID: 6035
		public const int CKHCKOMEEKOFieldNumber = 4;

		// Token: 0x04001794 RID: 6036
		private static readonly MapField<uint, ItemCostData>.Codec _map_cKHCKOMEEKO_codec = new MapField<uint, ItemCostData>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<ItemCostData>(18U, ItemCostData.Parser), 34U);

		// Token: 0x04001795 RID: 6037
		private readonly MapField<uint, ItemCostData> cKHCKOMEEKO_ = new MapField<uint, ItemCostData>();

		// Token: 0x04001796 RID: 6038
		public const int FreeReforgeNumFieldNumber = 7;

		// Token: 0x04001797 RID: 6039
		private uint freeReforgeNum_;
	}
}
