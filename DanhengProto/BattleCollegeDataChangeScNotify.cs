using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000DD RID: 221
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleCollegeDataChangeScNotify : IMessage<BattleCollegeDataChangeScNotify>, IMessage, IEquatable<BattleCollegeDataChangeScNotify>, IDeepCloneable<BattleCollegeDataChangeScNotify>, IBufferMessage
	{
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0001D853 File Offset: 0x0001BA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleCollegeDataChangeScNotify> Parser
		{
			get
			{
				return BattleCollegeDataChangeScNotify._parser;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0001D85A File Offset: 0x0001BA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleCollegeDataChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0001D86C File Offset: 0x0001BA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleCollegeDataChangeScNotify.Descriptor;
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0001D873 File Offset: 0x0001BA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleCollegeDataChangeScNotify()
		{
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0001D888 File Offset: 0x0001BA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleCollegeDataChangeScNotify(BattleCollegeDataChangeScNotify other) : this()
		{
			this.hDDGPMMNICD_ = other.hDDGPMMNICD_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.finishedCollegeIdList_ = other.finishedCollegeIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0001D8E5 File Offset: 0x0001BAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleCollegeDataChangeScNotify Clone()
		{
			return new BattleCollegeDataChangeScNotify(this);
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0001D8ED File Offset: 0x0001BAED
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x0001D8F5 File Offset: 0x0001BAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HDDGPMMNICD
		{
			get
			{
				return this.hDDGPMMNICD_;
			}
			set
			{
				this.hDDGPMMNICD_ = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0001D8FE File Offset: 0x0001BAFE
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x0001D906 File Offset: 0x0001BB06
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

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0001D90F File Offset: 0x0001BB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FinishedCollegeIdList
		{
			get
			{
				return this.finishedCollegeIdList_;
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0001D917 File Offset: 0x0001BB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleCollegeDataChangeScNotify);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0001D928 File Offset: 0x0001BB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleCollegeDataChangeScNotify other)
		{
			return other != null && (other == this || (this.HDDGPMMNICD == other.HDDGPMMNICD && object.Equals(this.Reward, other.Reward) && this.finishedCollegeIdList_.Equals(other.finishedCollegeIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0001D98C File Offset: 0x0001BB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HDDGPMMNICD != 0U)
			{
				num ^= this.HDDGPMMNICD.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			num ^= this.finishedCollegeIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0001D9EF File Offset: 0x0001BBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0001D9F7 File Offset: 0x0001BBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0001DA00 File Offset: 0x0001BC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.finishedCollegeIdList_.WriteTo(ref output, BattleCollegeDataChangeScNotify._repeated_finishedCollegeIdList_codec);
			if (this.HDDGPMMNICD != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.HDDGPMMNICD);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0001DA6C File Offset: 0x0001BC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HDDGPMMNICD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HDDGPMMNICD);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			num += this.finishedCollegeIdList_.CalculateSize(BattleCollegeDataChangeScNotify._repeated_finishedCollegeIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleCollegeDataChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HDDGPMMNICD != 0U)
			{
				this.HDDGPMMNICD = other.HDDGPMMNICD;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this.finishedCollegeIdList_.Add(other.finishedCollegeIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0001DB51 File Offset: 0x0001BD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0001DB5C File Offset: 0x0001BD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.finishedCollegeIdList_.AddEntriesFrom(ref input, BattleCollegeDataChangeScNotify._repeated_finishedCollegeIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.HDDGPMMNICD = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
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

		// Token: 0x04000421 RID: 1057
		private static readonly MessageParser<BattleCollegeDataChangeScNotify> _parser = new MessageParser<BattleCollegeDataChangeScNotify>(() => new BattleCollegeDataChangeScNotify());

		// Token: 0x04000422 RID: 1058
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000423 RID: 1059
		public const int HDDGPMMNICDFieldNumber = 7;

		// Token: 0x04000424 RID: 1060
		private uint hDDGPMMNICD_;

		// Token: 0x04000425 RID: 1061
		public const int RewardFieldNumber = 13;

		// Token: 0x04000426 RID: 1062
		private ItemList reward_;

		// Token: 0x04000427 RID: 1063
		public const int FinishedCollegeIdListFieldNumber = 3;

		// Token: 0x04000428 RID: 1064
		private static readonly FieldCodec<uint> _repeated_finishedCollegeIdList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04000429 RID: 1065
		private readonly RepeatedField<uint> finishedCollegeIdList_ = new RepeatedField<uint>();
	}
}
