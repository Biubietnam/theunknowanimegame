using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B85 RID: 2949
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyTakeRaffleTicketRewardScRsp : IMessage<MonopolyTakeRaffleTicketRewardScRsp>, IMessage, IEquatable<MonopolyTakeRaffleTicketRewardScRsp>, IDeepCloneable<MonopolyTakeRaffleTicketRewardScRsp>, IBufferMessage
	{
		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x06008280 RID: 33408 RVA: 0x00157A7F File Offset: 0x00155C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyTakeRaffleTicketRewardScRsp> Parser
		{
			get
			{
				return MonopolyTakeRaffleTicketRewardScRsp._parser;
			}
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x06008281 RID: 33409 RVA: 0x00157A86 File Offset: 0x00155C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyTakeRaffleTicketRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x06008282 RID: 33410 RVA: 0x00157A98 File Offset: 0x00155C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyTakeRaffleTicketRewardScRsp.Descriptor;
			}
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x00157A9F File Offset: 0x00155C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakeRaffleTicketRewardScRsp()
		{
		}

		// Token: 0x06008284 RID: 33412 RVA: 0x00157AA8 File Offset: 0x00155CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakeRaffleTicketRewardScRsp(MonopolyTakeRaffleTicketRewardScRsp other) : this()
		{
			this.rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.cFAABCLGKGB_ = other.cFAABCLGKGB_;
			this.poolId_ = other.poolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x00157B0C File Offset: 0x00155D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakeRaffleTicketRewardScRsp Clone()
		{
			return new MonopolyTakeRaffleTicketRewardScRsp(this);
		}

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x06008286 RID: 33414 RVA: 0x00157B14 File Offset: 0x00155D14
		// (set) Token: 0x06008287 RID: 33415 RVA: 0x00157B1C File Offset: 0x00155D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList RewardList
		{
			get
			{
				return this.rewardList_;
			}
			set
			{
				this.rewardList_ = value;
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x06008288 RID: 33416 RVA: 0x00157B25 File Offset: 0x00155D25
		// (set) Token: 0x06008289 RID: 33417 RVA: 0x00157B2D File Offset: 0x00155D2D
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

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x0600828A RID: 33418 RVA: 0x00157B36 File Offset: 0x00155D36
		// (set) Token: 0x0600828B RID: 33419 RVA: 0x00157B3E File Offset: 0x00155D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CFAABCLGKGB
		{
			get
			{
				return this.cFAABCLGKGB_;
			}
			set
			{
				this.cFAABCLGKGB_ = value;
			}
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x0600828C RID: 33420 RVA: 0x00157B47 File Offset: 0x00155D47
		// (set) Token: 0x0600828D RID: 33421 RVA: 0x00157B4F File Offset: 0x00155D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PoolId
		{
			get
			{
				return this.poolId_;
			}
			set
			{
				this.poolId_ = value;
			}
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x00157B58 File Offset: 0x00155D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyTakeRaffleTicketRewardScRsp);
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x00157B68 File Offset: 0x00155D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyTakeRaffleTicketRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RewardList, other.RewardList) && this.Retcode == other.Retcode && this.CFAABCLGKGB == other.CFAABCLGKGB && this.PoolId == other.PoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x00157BD8 File Offset: 0x00155DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rewardList_ != null)
			{
				num ^= this.RewardList.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CFAABCLGKGB != 0U)
			{
				num ^= this.CFAABCLGKGB.GetHashCode();
			}
			if (this.PoolId != 0U)
			{
				num ^= this.PoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008291 RID: 33425 RVA: 0x00157C5F File Offset: 0x00155E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008292 RID: 33426 RVA: 0x00157C67 File Offset: 0x00155E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008293 RID: 33427 RVA: 0x00157C70 File Offset: 0x00155E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardList_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RewardList);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CFAABCLGKGB != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CFAABCLGKGB);
			}
			if (this.PoolId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008294 RID: 33428 RVA: 0x00157D04 File Offset: 0x00155F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rewardList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardList);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CFAABCLGKGB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CFAABCLGKGB);
			}
			if (this.PoolId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008295 RID: 33429 RVA: 0x00157D8C File Offset: 0x00155F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyTakeRaffleTicketRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rewardList_ != null)
			{
				if (this.rewardList_ == null)
				{
					this.RewardList = new ItemList();
				}
				this.RewardList.MergeFrom(other.RewardList);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CFAABCLGKGB != 0U)
			{
				this.CFAABCLGKGB = other.CFAABCLGKGB;
			}
			if (other.PoolId != 0U)
			{
				this.PoolId = other.PoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008296 RID: 33430 RVA: 0x00157E1C File Offset: 0x0015601C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x00157E28 File Offset: 0x00156028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 10U)
					{
						if (this.rewardList_ == null)
						{
							this.RewardList = new ItemList();
						}
						input.ReadMessage(this.RewardList);
						continue;
					}
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.CFAABCLGKGB = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.PoolId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031C1 RID: 12737
		private static readonly MessageParser<MonopolyTakeRaffleTicketRewardScRsp> _parser = new MessageParser<MonopolyTakeRaffleTicketRewardScRsp>(() => new MonopolyTakeRaffleTicketRewardScRsp());

		// Token: 0x040031C2 RID: 12738
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031C3 RID: 12739
		public const int RewardListFieldNumber = 1;

		// Token: 0x040031C4 RID: 12740
		private ItemList rewardList_;

		// Token: 0x040031C5 RID: 12741
		public const int RetcodeFieldNumber = 5;

		// Token: 0x040031C6 RID: 12742
		private uint retcode_;

		// Token: 0x040031C7 RID: 12743
		public const int CFAABCLGKGBFieldNumber = 10;

		// Token: 0x040031C8 RID: 12744
		private uint cFAABCLGKGB_;

		// Token: 0x040031C9 RID: 12745
		public const int PoolIdFieldNumber = 11;

		// Token: 0x040031CA RID: 12746
		private uint poolId_;
	}
}
