using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002C9 RID: 713
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CityShopInfoScNotify : IMessage<CityShopInfoScNotify>, IMessage, IEquatable<CityShopInfoScNotify>, IDeepCloneable<CityShopInfoScNotify>, IBufferMessage
	{
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0005A261 File Offset: 0x00058461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CityShopInfoScNotify> Parser
		{
			get
			{
				return CityShopInfoScNotify._parser;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x0005A268 File Offset: 0x00058468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CityShopInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0005A27A File Offset: 0x0005847A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CityShopInfoScNotify.Descriptor;
			}
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0005A281 File Offset: 0x00058481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CityShopInfoScNotify()
		{
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x0005A28C File Offset: 0x0005848C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CityShopInfoScNotify(CityShopInfoScNotify other) : this()
		{
			this.shopId_ = other.shopId_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.takenLevelReward_ = other.takenLevelReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x0005A2E0 File Offset: 0x000584E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CityShopInfoScNotify Clone()
		{
			return new CityShopInfoScNotify(this);
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0005A2E8 File Offset: 0x000584E8
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x0005A2F0 File Offset: 0x000584F0
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

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0005A2F9 File Offset: 0x000584F9
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x0005A301 File Offset: 0x00058501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0005A30A File Offset: 0x0005850A
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x0005A312 File Offset: 0x00058512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0005A31B File Offset: 0x0005851B
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x0005A323 File Offset: 0x00058523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong TakenLevelReward
		{
			get
			{
				return this.takenLevelReward_;
			}
			set
			{
				this.takenLevelReward_ = value;
			}
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x0005A32C File Offset: 0x0005852C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CityShopInfoScNotify);
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x0005A33C File Offset: 0x0005853C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CityShopInfoScNotify other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.Level == other.Level && this.Exp == other.Exp && this.TakenLevelReward == other.TakenLevelReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x0005A3A8 File Offset: 0x000585A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0U)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.TakenLevelReward != 0UL)
			{
				num ^= this.TakenLevelReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x0005A432 File Offset: 0x00058632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x0005A43A File Offset: 0x0005863A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x0005A444 File Offset: 0x00058644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Exp != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Exp);
			}
			if (this.ShopId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ShopId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Level);
			}
			if (this.TakenLevelReward != 0UL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.TakenLevelReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x0005A4D8 File Offset: 0x000586D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShopId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.TakenLevelReward != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.TakenLevelReward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0005A560 File Offset: 0x00058760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CityShopInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0U)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.TakenLevelReward != 0UL)
			{
				this.TakenLevelReward = other.TakenLevelReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0005A5D8 File Offset: 0x000587D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0005A5E4 File Offset: 0x000587E4
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
						this.Exp = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ShopId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.TakenLevelReward = input.ReadUInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000D1A RID: 3354
		private static readonly MessageParser<CityShopInfoScNotify> _parser = new MessageParser<CityShopInfoScNotify>(() => new CityShopInfoScNotify());

		// Token: 0x04000D1B RID: 3355
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D1C RID: 3356
		public const int ShopIdFieldNumber = 6;

		// Token: 0x04000D1D RID: 3357
		private uint shopId_;

		// Token: 0x04000D1E RID: 3358
		public const int LevelFieldNumber = 8;

		// Token: 0x04000D1F RID: 3359
		private uint level_;

		// Token: 0x04000D20 RID: 3360
		public const int ExpFieldNumber = 2;

		// Token: 0x04000D21 RID: 3361
		private uint exp_;

		// Token: 0x04000D22 RID: 3362
		public const int TakenLevelRewardFieldNumber = 11;

		// Token: 0x04000D23 RID: 3363
		private ulong takenLevelReward_;
	}
}
