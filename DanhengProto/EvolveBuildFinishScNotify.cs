using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004A3 RID: 1187
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildFinishScNotify : IMessage<EvolveBuildFinishScNotify>, IMessage, IEquatable<EvolveBuildFinishScNotify>, IDeepCloneable<EvolveBuildFinishScNotify>, IBufferMessage
	{
		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06003503 RID: 13571 RVA: 0x00092140 File Offset: 0x00090340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildFinishScNotify> Parser
		{
			get
			{
				return EvolveBuildFinishScNotify._parser;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x00092147 File Offset: 0x00090347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildFinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06003505 RID: 13573 RVA: 0x00092159 File Offset: 0x00090359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildFinishScNotify.Descriptor;
			}
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00092160 File Offset: 0x00090360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildFinishScNotify()
		{
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00092168 File Offset: 0x00090368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildFinishScNotify(EvolveBuildFinishScNotify other) : this()
		{
			this.battleResultType_ = other.battleResultType_;
			this.coin_ = other.coin_;
			this.score_ = other.score_;
			this.isLose_ = other.isLose_;
			this.wave_ = other.wave_;
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this.exp_ = other.exp_;
			this.levelId_ = other.levelId_;
			this.curPeriodType_ = other.curPeriodType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00092208 File Offset: 0x00090408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildFinishScNotify Clone()
		{
			return new EvolveBuildFinishScNotify(this);
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x00092210 File Offset: 0x00090410
		// (set) Token: 0x0600350A RID: 13578 RVA: 0x00092218 File Offset: 0x00090418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HBHDIGOPDMP BattleResultType
		{
			get
			{
				return this.battleResultType_;
			}
			set
			{
				this.battleResultType_ = value;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x00092221 File Offset: 0x00090421
		// (set) Token: 0x0600350C RID: 13580 RVA: 0x00092229 File Offset: 0x00090429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Coin
		{
			get
			{
				return this.coin_;
			}
			set
			{
				this.coin_ = value;
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x00092232 File Offset: 0x00090432
		// (set) Token: 0x0600350E RID: 13582 RVA: 0x0009223A File Offset: 0x0009043A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x00092243 File Offset: 0x00090443
		// (set) Token: 0x06003510 RID: 13584 RVA: 0x0009224B File Offset: 0x0009044B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLose
		{
			get
			{
				return this.isLose_;
			}
			set
			{
				this.isLose_ = value;
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x00092254 File Offset: 0x00090454
		// (set) Token: 0x06003512 RID: 13586 RVA: 0x0009225C File Offset: 0x0009045C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Wave
		{
			get
			{
				return this.wave_;
			}
			set
			{
				this.wave_ = value;
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x00092265 File Offset: 0x00090465
		// (set) Token: 0x06003514 RID: 13588 RVA: 0x0009226D File Offset: 0x0009046D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06003515 RID: 13589 RVA: 0x00092276 File Offset: 0x00090476
		// (set) Token: 0x06003516 RID: 13590 RVA: 0x0009227E File Offset: 0x0009047E
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

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x00092287 File Offset: 0x00090487
		// (set) Token: 0x06003518 RID: 13592 RVA: 0x0009228F File Offset: 0x0009048F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x00092298 File Offset: 0x00090498
		// (set) Token: 0x0600351A RID: 13594 RVA: 0x000922A0 File Offset: 0x000904A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurPeriodType
		{
			get
			{
				return this.curPeriodType_;
			}
			set
			{
				this.curPeriodType_ = value;
			}
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x000922A9 File Offset: 0x000904A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildFinishScNotify);
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x000922B8 File Offset: 0x000904B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildFinishScNotify other)
		{
			return other != null && (other == this || (this.BattleResultType == other.BattleResultType && this.Coin == other.Coin && this.Score == other.Score && this.IsLose == other.IsLose && this.Wave == other.Wave && object.Equals(this.LevelInfo, other.LevelInfo) && this.Exp == other.Exp && this.LevelId == other.LevelId && this.CurPeriodType == other.CurPeriodType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x00092378 File Offset: 0x00090578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleResultType != HBHDIGOPDMP.EvolveBattleResultNone)
			{
				num ^= this.BattleResultType.GetHashCode();
			}
			if (this.Coin != 0U)
			{
				num ^= this.Coin.GetHashCode();
			}
			if (this.Score != 0U)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.IsLose)
			{
				num ^= this.IsLose.GetHashCode();
			}
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.CurPeriodType != 0U)
			{
				num ^= this.CurPeriodType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x00092482 File Offset: 0x00090682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x0009248A File Offset: 0x0009068A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x00092494 File Offset: 0x00090694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.LevelId);
			}
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.LevelInfo);
			}
			if (this.CurPeriodType != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CurPeriodType);
			}
			if (this.Score != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Score);
			}
			if (this.Coin != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Coin);
			}
			if (this.IsLose)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsLose);
			}
			if (this.Wave != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Wave);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Exp);
			}
			if (this.BattleResultType != HBHDIGOPDMP.EvolveBattleResultNone)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.BattleResultType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x000925B0 File Offset: 0x000907B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleResultType != HBHDIGOPDMP.EvolveBattleResultNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BattleResultType);
			}
			if (this.Coin != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Coin);
			}
			if (this.Score != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Score);
			}
			if (this.IsLose)
			{
				num += 2;
			}
			if (this.Wave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this.CurPeriodType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurPeriodType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x000926A4 File Offset: 0x000908A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildFinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleResultType != HBHDIGOPDMP.EvolveBattleResultNone)
			{
				this.BattleResultType = other.BattleResultType;
			}
			if (other.Coin != 0U)
			{
				this.Coin = other.Coin;
			}
			if (other.Score != 0U)
			{
				this.Score = other.Score;
			}
			if (other.IsLose)
			{
				this.IsLose = other.IsLose;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new EvolveBuildLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			if (other.CurPeriodType != 0U)
			{
				this.CurPeriodType = other.CurPeriodType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x00092798 File Offset: 0x00090998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x000927A4 File Offset: 0x000909A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.LevelId = input.ReadUInt32();
							continue;
						}
						if (num == 26U)
						{
							if (this.levelInfo_ == null)
							{
								this.LevelInfo = new EvolveBuildLevelInfo();
							}
							input.ReadMessage(this.LevelInfo);
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.CurPeriodType = input.ReadUInt32();
							continue;
						}
						if (num == 40U)
						{
							this.Score = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 48U)
					{
						this.Coin = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.IsLose = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Wave = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.BattleResultType = (HBHDIGOPDMP)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001528 RID: 5416
		private static readonly MessageParser<EvolveBuildFinishScNotify> _parser = new MessageParser<EvolveBuildFinishScNotify>(() => new EvolveBuildFinishScNotify());

		// Token: 0x04001529 RID: 5417
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400152A RID: 5418
		public const int BattleResultTypeFieldNumber = 15;

		// Token: 0x0400152B RID: 5419
		private HBHDIGOPDMP battleResultType_;

		// Token: 0x0400152C RID: 5420
		public const int CoinFieldNumber = 6;

		// Token: 0x0400152D RID: 5421
		private uint coin_;

		// Token: 0x0400152E RID: 5422
		public const int ScoreFieldNumber = 5;

		// Token: 0x0400152F RID: 5423
		private uint score_;

		// Token: 0x04001530 RID: 5424
		public const int IsLoseFieldNumber = 8;

		// Token: 0x04001531 RID: 5425
		private bool isLose_;

		// Token: 0x04001532 RID: 5426
		public const int WaveFieldNumber = 10;

		// Token: 0x04001533 RID: 5427
		private uint wave_;

		// Token: 0x04001534 RID: 5428
		public const int LevelInfoFieldNumber = 3;

		// Token: 0x04001535 RID: 5429
		private EvolveBuildLevelInfo levelInfo_;

		// Token: 0x04001536 RID: 5430
		public const int ExpFieldNumber = 11;

		// Token: 0x04001537 RID: 5431
		private uint exp_;

		// Token: 0x04001538 RID: 5432
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04001539 RID: 5433
		private uint levelId_;

		// Token: 0x0400153A RID: 5434
		public const int CurPeriodTypeFieldNumber = 4;

		// Token: 0x0400153B RID: 5435
		private uint curPeriodType_;
	}
}
