using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004AF RID: 1199
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildLevelInfo : IMessage<EvolveBuildLevelInfo>, IMessage, IEquatable<EvolveBuildLevelInfo>, IDeepCloneable<EvolveBuildLevelInfo>, IBufferMessage
	{
		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x000938C7 File Offset: 0x00091AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildLevelInfo> Parser
		{
			get
			{
				return EvolveBuildLevelInfo._parser;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x000938CE File Offset: 0x00091ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildLevelInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x000938E0 File Offset: 0x00091AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildLevelInfo.Descriptor;
			}
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x000938E7 File Offset: 0x00091AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLevelInfo()
		{
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00093910 File Offset: 0x00091B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLevelInfo(EvolveBuildLevelInfo other) : this()
		{
			this.avatarList_ = other.avatarList_.Clone();
			this.periodIdList_ = other.periodIdList_.Clone();
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.curGameExp_ = other.curGameExp_;
			this.roundCnt_ = other.roundCnt_;
			this.battleTargetList_ = other.battleTargetList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x0009399B File Offset: 0x00091B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLevelInfo Clone()
		{
			return new EvolveBuildLevelInfo(this);
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x0600359B RID: 13723 RVA: 0x000939A3 File Offset: 0x00091BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EvolveBuildAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x000939AB File Offset: 0x00091BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PeriodIdList
		{
			get
			{
				return this.periodIdList_;
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x000939B3 File Offset: 0x00091BB3
		// (set) Token: 0x0600359E RID: 13726 RVA: 0x000939BB File Offset: 0x00091BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x000939C4 File Offset: 0x00091BC4
		// (set) Token: 0x060035A0 RID: 13728 RVA: 0x000939CC File Offset: 0x00091BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurGameExp
		{
			get
			{
				return this.curGameExp_;
			}
			set
			{
				this.curGameExp_ = value;
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x060035A1 RID: 13729 RVA: 0x000939D5 File Offset: 0x00091BD5
		// (set) Token: 0x060035A2 RID: 13730 RVA: 0x000939DD File Offset: 0x00091BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoundCnt
		{
			get
			{
				return this.roundCnt_;
			}
			set
			{
				this.roundCnt_ = value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x060035A3 RID: 13731 RVA: 0x000939E6 File Offset: 0x00091BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleTarget> BattleTargetList
		{
			get
			{
				return this.battleTargetList_;
			}
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x000939EE File Offset: 0x00091BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildLevelInfo);
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x000939FC File Offset: 0x00091BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildLevelInfo other)
		{
			return other != null && (other == this || (this.avatarList_.Equals(other.avatarList_) && this.periodIdList_.Equals(other.periodIdList_) && object.Equals(this.BattleInfo, other.BattleInfo) && this.CurGameExp == other.CurGameExp && this.RoundCnt == other.RoundCnt && this.battleTargetList_.Equals(other.battleTargetList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x00093A9C File Offset: 0x00091C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarList_.GetHashCode();
			num ^= this.periodIdList_.GetHashCode();
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.CurGameExp != 0U)
			{
				num ^= this.CurGameExp.GetHashCode();
			}
			if (this.RoundCnt != 0U)
			{
				num ^= this.RoundCnt.GetHashCode();
			}
			num ^= this.battleTargetList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x00093B34 File Offset: 0x00091D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x00093B3C File Offset: 0x00091D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x00093B48 File Offset: 0x00091D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoundCnt != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.RoundCnt);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BattleInfo);
			}
			this.battleTargetList_.WriteTo(ref output, EvolveBuildLevelInfo._repeated_battleTargetList_codec);
			this.avatarList_.WriteTo(ref output, EvolveBuildLevelInfo._repeated_avatarList_codec);
			this.periodIdList_.WriteTo(ref output, EvolveBuildLevelInfo._repeated_periodIdList_codec);
			if (this.CurGameExp != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.CurGameExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x00093BF0 File Offset: 0x00091DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarList_.CalculateSize(EvolveBuildLevelInfo._repeated_avatarList_codec);
			num += this.periodIdList_.CalculateSize(EvolveBuildLevelInfo._repeated_periodIdList_codec);
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.CurGameExp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurGameExp);
			}
			if (this.RoundCnt != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoundCnt);
			}
			num += this.battleTargetList_.CalculateSize(EvolveBuildLevelInfo._repeated_battleTargetList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x00093C98 File Offset: 0x00091E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarList_.Add(other.avatarList_);
			this.periodIdList_.Add(other.periodIdList_);
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new EvolveBuildBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.CurGameExp != 0U)
			{
				this.CurGameExp = other.CurGameExp;
			}
			if (other.RoundCnt != 0U)
			{
				this.RoundCnt = other.RoundCnt;
			}
			this.battleTargetList_.Add(other.battleTargetList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x00093D47 File Offset: 0x00091F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x00093D50 File Offset: 0x00091F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 42U)
				{
					if (num <= 64U)
					{
						if (num == 50U)
						{
							this.avatarList_.AddEntriesFrom(ref input, EvolveBuildLevelInfo._repeated_avatarList_codec);
							continue;
						}
						if (num != 64U)
						{
							goto IL_36;
						}
					}
					else if (num != 66U)
					{
						if (num != 104U)
						{
							goto IL_36;
						}
						this.CurGameExp = input.ReadUInt32();
						continue;
					}
					this.periodIdList_.AddEntriesFrom(ref input, EvolveBuildLevelInfo._repeated_periodIdList_codec);
					continue;
				}
				if (num == 16U)
				{
					this.RoundCnt = input.ReadUInt32();
					continue;
				}
				if (num == 26U)
				{
					if (this.battleInfo_ == null)
					{
						this.BattleInfo = new EvolveBuildBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
					continue;
				}
				if (num == 42U)
				{
					this.battleTargetList_.AddEntriesFrom(ref input, EvolveBuildLevelInfo._repeated_battleTargetList_codec);
					continue;
				}
				IL_36:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400155A RID: 5466
		private static readonly MessageParser<EvolveBuildLevelInfo> _parser = new MessageParser<EvolveBuildLevelInfo>(() => new EvolveBuildLevelInfo());

		// Token: 0x0400155B RID: 5467
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400155C RID: 5468
		public const int AvatarListFieldNumber = 6;

		// Token: 0x0400155D RID: 5469
		private static readonly FieldCodec<EvolveBuildAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<EvolveBuildAvatar>(50U, EvolveBuildAvatar.Parser);

		// Token: 0x0400155E RID: 5470
		private readonly RepeatedField<EvolveBuildAvatar> avatarList_ = new RepeatedField<EvolveBuildAvatar>();

		// Token: 0x0400155F RID: 5471
		public const int PeriodIdListFieldNumber = 8;

		// Token: 0x04001560 RID: 5472
		private static readonly FieldCodec<uint> _repeated_periodIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04001561 RID: 5473
		private readonly RepeatedField<uint> periodIdList_ = new RepeatedField<uint>();

		// Token: 0x04001562 RID: 5474
		public const int BattleInfoFieldNumber = 3;

		// Token: 0x04001563 RID: 5475
		private EvolveBuildBattleInfo battleInfo_;

		// Token: 0x04001564 RID: 5476
		public const int CurGameExpFieldNumber = 13;

		// Token: 0x04001565 RID: 5477
		private uint curGameExp_;

		// Token: 0x04001566 RID: 5478
		public const int RoundCntFieldNumber = 2;

		// Token: 0x04001567 RID: 5479
		private uint roundCnt_;

		// Token: 0x04001568 RID: 5480
		public const int BattleTargetListFieldNumber = 5;

		// Token: 0x04001569 RID: 5481
		private static readonly FieldCodec<BattleTarget> _repeated_battleTargetList_codec = FieldCodec.ForMessage<BattleTarget>(42U, BattleTarget.Parser);

		// Token: 0x0400156A RID: 5482
		private readonly RepeatedField<BattleTarget> battleTargetList_ = new RepeatedField<BattleTarget>();
	}
}
