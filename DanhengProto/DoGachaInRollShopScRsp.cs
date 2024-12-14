using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003C5 RID: 965
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DoGachaInRollShopScRsp : IMessage<DoGachaInRollShopScRsp>, IMessage, IEquatable<DoGachaInRollShopScRsp>, IDeepCloneable<DoGachaInRollShopScRsp>, IBufferMessage
	{
		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x00077877 File Offset: 0x00075A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DoGachaInRollShopScRsp> Parser
		{
			get
			{
				return DoGachaInRollShopScRsp._parser;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x0007787E File Offset: 0x00075A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DoGachaInRollShopScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x00077890 File Offset: 0x00075A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DoGachaInRollShopScRsp.Descriptor;
			}
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x00077897 File Offset: 0x00075A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaInRollShopScRsp()
		{
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000778A0 File Offset: 0x00075AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaInRollShopScRsp(DoGachaInRollShopScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.rollShopId_ = other.rollShopId_;
			this.rewardDisplayType_ = other.rewardDisplayType_;
			this.retcode_ = other.retcode_;
			this.kEACGMLKBDK_ = other.kEACGMLKBDK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x00077910 File Offset: 0x00075B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaInRollShopScRsp Clone()
		{
			return new DoGachaInRollShopScRsp(this);
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x00077918 File Offset: 0x00075B18
		// (set) Token: 0x06002AED RID: 10989 RVA: 0x00077920 File Offset: 0x00075B20
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

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x00077929 File Offset: 0x00075B29
		// (set) Token: 0x06002AEF RID: 10991 RVA: 0x00077931 File Offset: 0x00075B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollShopId
		{
			get
			{
				return this.rollShopId_;
			}
			set
			{
				this.rollShopId_ = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x0007793A File Offset: 0x00075B3A
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x00077942 File Offset: 0x00075B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RewardDisplayType
		{
			get
			{
				return this.rewardDisplayType_;
			}
			set
			{
				this.rewardDisplayType_ = value;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x0007794B File Offset: 0x00075B4B
		// (set) Token: 0x06002AF3 RID: 10995 RVA: 0x00077953 File Offset: 0x00075B53
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

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x0007795C File Offset: 0x00075B5C
		// (set) Token: 0x06002AF5 RID: 10997 RVA: 0x00077964 File Offset: 0x00075B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KEACGMLKBDK
		{
			get
			{
				return this.kEACGMLKBDK_;
			}
			set
			{
				this.kEACGMLKBDK_ = value;
			}
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0007796D File Offset: 0x00075B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DoGachaInRollShopScRsp);
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x0007797C File Offset: 0x00075B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DoGachaInRollShopScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.RollShopId == other.RollShopId && this.RewardDisplayType == other.RewardDisplayType && this.Retcode == other.Retcode && this.KEACGMLKBDK == other.KEACGMLKBDK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x000779FC File Offset: 0x00075BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.RollShopId != 0U)
			{
				num ^= this.RollShopId.GetHashCode();
			}
			if (this.RewardDisplayType != 0U)
			{
				num ^= this.RewardDisplayType.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.KEACGMLKBDK != 0U)
			{
				num ^= this.KEACGMLKBDK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x00077A9C File Offset: 0x00075C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00077AA4 File Offset: 0x00075CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00077AB0 File Offset: 0x00075CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KEACGMLKBDK != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.KEACGMLKBDK);
			}
			if (this.RewardDisplayType != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RewardDisplayType);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.RollShopId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.RollShopId);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00077B5C File Offset: 0x00075D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.RollShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollShopId);
			}
			if (this.RewardDisplayType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RewardDisplayType);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.KEACGMLKBDK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KEACGMLKBDK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00077BFC File Offset: 0x00075DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DoGachaInRollShopScRsp other)
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
			if (other.RollShopId != 0U)
			{
				this.RollShopId = other.RollShopId;
			}
			if (other.RewardDisplayType != 0U)
			{
				this.RewardDisplayType = other.RewardDisplayType;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.KEACGMLKBDK != 0U)
			{
				this.KEACGMLKBDK = other.KEACGMLKBDK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00077CA0 File Offset: 0x00075EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00077CAC File Offset: 0x00075EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.KEACGMLKBDK = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.RewardDisplayType = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.RollShopId = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001166 RID: 4454
		private static readonly MessageParser<DoGachaInRollShopScRsp> _parser = new MessageParser<DoGachaInRollShopScRsp>(() => new DoGachaInRollShopScRsp());

		// Token: 0x04001167 RID: 4455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001168 RID: 4456
		public const int RewardFieldNumber = 15;

		// Token: 0x04001169 RID: 4457
		private ItemList reward_;

		// Token: 0x0400116A RID: 4458
		public const int RollShopIdFieldNumber = 13;

		// Token: 0x0400116B RID: 4459
		private uint rollShopId_;

		// Token: 0x0400116C RID: 4460
		public const int RewardDisplayTypeFieldNumber = 4;

		// Token: 0x0400116D RID: 4461
		private uint rewardDisplayType_;

		// Token: 0x0400116E RID: 4462
		public const int RetcodeFieldNumber = 9;

		// Token: 0x0400116F RID: 4463
		private uint retcode_;

		// Token: 0x04001170 RID: 4464
		public const int KEACGMLKBDKFieldNumber = 1;

		// Token: 0x04001171 RID: 4465
		private uint kEACGMLKBDK_;
	}
}
