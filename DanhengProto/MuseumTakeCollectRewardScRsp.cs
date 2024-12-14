using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BCF RID: 3023
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumTakeCollectRewardScRsp : IMessage<MuseumTakeCollectRewardScRsp>, IMessage, IEquatable<MuseumTakeCollectRewardScRsp>, IDeepCloneable<MuseumTakeCollectRewardScRsp>, IBufferMessage
	{
		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x060085BD RID: 34237 RVA: 0x001610B3 File Offset: 0x0015F2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumTakeCollectRewardScRsp> Parser
		{
			get
			{
				return MuseumTakeCollectRewardScRsp._parser;
			}
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x060085BE RID: 34238 RVA: 0x001610BA File Offset: 0x0015F2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumTakeCollectRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x060085BF RID: 34239 RVA: 0x001610CC File Offset: 0x0015F2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumTakeCollectRewardScRsp.Descriptor;
			}
		}

		// Token: 0x060085C0 RID: 34240 RVA: 0x001610D3 File Offset: 0x0015F2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTakeCollectRewardScRsp()
		{
		}

		// Token: 0x060085C1 RID: 34241 RVA: 0x001610DC File Offset: 0x0015F2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTakeCollectRewardScRsp(MuseumTakeCollectRewardScRsp other) : this()
		{
			this.itemId_ = other.itemId_;
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085C2 RID: 34242 RVA: 0x00161134 File Offset: 0x0015F334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTakeCollectRewardScRsp Clone()
		{
			return new MuseumTakeCollectRewardScRsp(this);
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x060085C3 RID: 34243 RVA: 0x0016113C File Offset: 0x0015F33C
		// (set) Token: 0x060085C4 RID: 34244 RVA: 0x00161144 File Offset: 0x0015F344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x060085C5 RID: 34245 RVA: 0x0016114D File Offset: 0x0015F34D
		// (set) Token: 0x060085C6 RID: 34246 RVA: 0x00161155 File Offset: 0x0015F355
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

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x060085C7 RID: 34247 RVA: 0x0016115E File Offset: 0x0015F35E
		// (set) Token: 0x060085C8 RID: 34248 RVA: 0x00161166 File Offset: 0x0015F366
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

		// Token: 0x060085C9 RID: 34249 RVA: 0x0016116F File Offset: 0x0015F36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumTakeCollectRewardScRsp);
		}

		// Token: 0x060085CA RID: 34250 RVA: 0x00161180 File Offset: 0x0015F380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumTakeCollectRewardScRsp other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085CB RID: 34251 RVA: 0x001611E0 File Offset: 0x0015F3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085CC RID: 34252 RVA: 0x0016124E File Offset: 0x0015F44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060085CD RID: 34253 RVA: 0x00161256 File Offset: 0x0015F456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085CE RID: 34254 RVA: 0x00161260 File Offset: 0x0015F460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085CF RID: 34255 RVA: 0x001612D8 File Offset: 0x0015F4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085D0 RID: 34256 RVA: 0x00161348 File Offset: 0x0015F548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumTakeCollectRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060085D1 RID: 34257 RVA: 0x001613C4 File Offset: 0x0015F5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085D2 RID: 34258 RVA: 0x001613D0 File Offset: 0x0015F5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemId = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.reward_ == null)
					{
						this.Reward = new ItemList();
					}
					input.ReadMessage(this.Reward);
				}
			}
		}

		// Token: 0x0400333A RID: 13114
		private static readonly MessageParser<MuseumTakeCollectRewardScRsp> _parser = new MessageParser<MuseumTakeCollectRewardScRsp>(() => new MuseumTakeCollectRewardScRsp());

		// Token: 0x0400333B RID: 13115
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400333C RID: 13116
		public const int ItemIdFieldNumber = 14;

		// Token: 0x0400333D RID: 13117
		private uint itemId_;

		// Token: 0x0400333E RID: 13118
		public const int RetcodeFieldNumber = 12;

		// Token: 0x0400333F RID: 13119
		private uint retcode_;

		// Token: 0x04003340 RID: 13120
		public const int RewardFieldNumber = 1;

		// Token: 0x04003341 RID: 13121
		private ItemList reward_;
	}
}
