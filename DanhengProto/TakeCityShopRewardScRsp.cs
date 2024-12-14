using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012D1 RID: 4817
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeCityShopRewardScRsp : IMessage<TakeCityShopRewardScRsp>, IMessage, IEquatable<TakeCityShopRewardScRsp>, IDeepCloneable<TakeCityShopRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x0600D6DE RID: 55006 RVA: 0x0023D09B File Offset: 0x0023B29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeCityShopRewardScRsp> Parser
		{
			get
			{
				return TakeCityShopRewardScRsp._parser;
			}
		}

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x0600D6DF RID: 55007 RVA: 0x0023D0A2 File Offset: 0x0023B2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeCityShopRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x0600D6E0 RID: 55008 RVA: 0x0023D0B4 File Offset: 0x0023B2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeCityShopRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D6E1 RID: 55009 RVA: 0x0023D0BB File Offset: 0x0023B2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeCityShopRewardScRsp()
		{
		}

		// Token: 0x0600D6E2 RID: 55010 RVA: 0x0023D0C4 File Offset: 0x0023B2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeCityShopRewardScRsp(TakeCityShopRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.level_ = other.level_;
			this.shopId_ = other.shopId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6E3 RID: 55011 RVA: 0x0023D128 File Offset: 0x0023B328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeCityShopRewardScRsp Clone()
		{
			return new TakeCityShopRewardScRsp(this);
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x0600D6E4 RID: 55012 RVA: 0x0023D130 File Offset: 0x0023B330
		// (set) Token: 0x0600D6E5 RID: 55013 RVA: 0x0023D138 File Offset: 0x0023B338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x0600D6E6 RID: 55014 RVA: 0x0023D141 File Offset: 0x0023B341
		// (set) Token: 0x0600D6E7 RID: 55015 RVA: 0x0023D149 File Offset: 0x0023B349
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

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x0600D6E8 RID: 55016 RVA: 0x0023D152 File Offset: 0x0023B352
		// (set) Token: 0x0600D6E9 RID: 55017 RVA: 0x0023D15A File Offset: 0x0023B35A
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

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x0600D6EA RID: 55018 RVA: 0x0023D163 File Offset: 0x0023B363
		// (set) Token: 0x0600D6EB RID: 55019 RVA: 0x0023D16B File Offset: 0x0023B36B
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

		// Token: 0x0600D6EC RID: 55020 RVA: 0x0023D174 File Offset: 0x0023B374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeCityShopRewardScRsp);
		}

		// Token: 0x0600D6ED RID: 55021 RVA: 0x0023D184 File Offset: 0x0023B384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeCityShopRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.Level == other.Level && this.ShopId == other.ShopId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6EE RID: 55022 RVA: 0x0023D1F4 File Offset: 0x0023B3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.ShopId != 0U)
			{
				num ^= this.ShopId.GetHashCode();
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

		// Token: 0x0600D6EF RID: 55023 RVA: 0x0023D27B File Offset: 0x0023B47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D6F0 RID: 55024 RVA: 0x0023D283 File Offset: 0x0023B483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6F1 RID: 55025 RVA: 0x0023D28C File Offset: 0x0023B48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Reward);
			}
			if (this.ShopId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ShopId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6F2 RID: 55026 RVA: 0x0023D320 File Offset: 0x0023B520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.ShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShopId);
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

		// Token: 0x0600D6F3 RID: 55027 RVA: 0x0023D3A8 File Offset: 0x0023B5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeCityShopRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.ShopId != 0U)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6F4 RID: 55028 RVA: 0x0023D438 File Offset: 0x0023B638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6F5 RID: 55029 RVA: 0x0023D444 File Offset: 0x0023B644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ShopId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040055C6 RID: 21958
		private static readonly MessageParser<TakeCityShopRewardScRsp> _parser = new MessageParser<TakeCityShopRewardScRsp>(() => new TakeCityShopRewardScRsp());

		// Token: 0x040055C7 RID: 21959
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055C8 RID: 21960
		public const int RewardFieldNumber = 9;

		// Token: 0x040055C9 RID: 21961
		private ItemList reward_;

		// Token: 0x040055CA RID: 21962
		public const int LevelFieldNumber = 15;

		// Token: 0x040055CB RID: 21963
		private uint level_;

		// Token: 0x040055CC RID: 21964
		public const int ShopIdFieldNumber = 12;

		// Token: 0x040055CD RID: 21965
		private uint shopId_;

		// Token: 0x040055CE RID: 21966
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040055CF RID: 21967
		private uint retcode_;
	}
}
