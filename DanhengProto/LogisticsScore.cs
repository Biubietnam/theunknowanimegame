using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A6B RID: 2667
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LogisticsScore : IMessage<LogisticsScore>, IMessage, IEquatable<LogisticsScore>, IDeepCloneable<LogisticsScore>, IBufferMessage
	{
		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x0600763A RID: 30266 RVA: 0x00139BA3 File Offset: 0x00137DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogisticsScore> Parser
		{
			get
			{
				return LogisticsScore._parser;
			}
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x0600763B RID: 30267 RVA: 0x00139BAA File Offset: 0x00137DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LogisticsScoreReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x0600763C RID: 30268 RVA: 0x00139BBC File Offset: 0x00137DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogisticsScore.Descriptor;
			}
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00139BC3 File Offset: 0x00137DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsScore()
		{
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00139BCC File Offset: 0x00137DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsScore(LogisticsScore other) : this()
		{
			this.unlockLevel_ = other.unlockLevel_;
			this.maxScore_ = other.maxScore_;
			this.lastMaxScore_ = other.lastMaxScore_;
			this.lastLevel_ = other.lastLevel_;
			this.mapId_ = other.mapId_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.curScore_ = other.curScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x00139C54 File Offset: 0x00137E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsScore Clone()
		{
			return new LogisticsScore(this);
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x06007640 RID: 30272 RVA: 0x00139C5C File Offset: 0x00137E5C
		// (set) Token: 0x06007641 RID: 30273 RVA: 0x00139C64 File Offset: 0x00137E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UnlockLevel
		{
			get
			{
				return this.unlockLevel_;
			}
			set
			{
				this.unlockLevel_ = value;
			}
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x06007642 RID: 30274 RVA: 0x00139C6D File Offset: 0x00137E6D
		// (set) Token: 0x06007643 RID: 30275 RVA: 0x00139C75 File Offset: 0x00137E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x06007644 RID: 30276 RVA: 0x00139C7E File Offset: 0x00137E7E
		// (set) Token: 0x06007645 RID: 30277 RVA: 0x00139C86 File Offset: 0x00137E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LastMaxScore
		{
			get
			{
				return this.lastMaxScore_;
			}
			set
			{
				this.lastMaxScore_ = value;
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x06007646 RID: 30278 RVA: 0x00139C8F File Offset: 0x00137E8F
		// (set) Token: 0x06007647 RID: 30279 RVA: 0x00139C97 File Offset: 0x00137E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LastLevel
		{
			get
			{
				return this.lastLevel_;
			}
			set
			{
				this.lastLevel_ = value;
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x06007648 RID: 30280 RVA: 0x00139CA0 File Offset: 0x00137EA0
		// (set) Token: 0x06007649 RID: 30281 RVA: 0x00139CA8 File Offset: 0x00137EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x0600764A RID: 30282 RVA: 0x00139CB1 File Offset: 0x00137EB1
		// (set) Token: 0x0600764B RID: 30283 RVA: 0x00139CB9 File Offset: 0x00137EB9
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

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x0600764C RID: 30284 RVA: 0x00139CC2 File Offset: 0x00137EC2
		// (set) Token: 0x0600764D RID: 30285 RVA: 0x00139CCA File Offset: 0x00137ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurScore
		{
			get
			{
				return this.curScore_;
			}
			set
			{
				this.curScore_ = value;
			}
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x00139CD3 File Offset: 0x00137ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogisticsScore);
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x00139CE4 File Offset: 0x00137EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogisticsScore other)
		{
			return other != null && (other == this || (this.UnlockLevel == other.UnlockLevel && this.MaxScore == other.MaxScore && this.LastMaxScore == other.LastMaxScore && this.LastLevel == other.LastLevel && this.MapId == other.MapId && object.Equals(this.Reward, other.Reward) && this.CurScore == other.CurScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x00139D84 File Offset: 0x00137F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UnlockLevel != 0U)
			{
				num ^= this.UnlockLevel.GetHashCode();
			}
			if (this.MaxScore != 0U)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.LastMaxScore != 0U)
			{
				num ^= this.LastMaxScore.GetHashCode();
			}
			if (this.LastLevel != 0U)
			{
				num ^= this.LastLevel.GetHashCode();
			}
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.CurScore != 0U)
			{
				num ^= this.CurScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x00139E56 File Offset: 0x00138056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x00139E5E File Offset: 0x0013805E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00139E68 File Offset: 0x00138068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnlockLevel != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.UnlockLevel);
			}
			if (this.MaxScore != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MaxScore);
			}
			if (this.LastLevel != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.LastLevel);
			}
			if (this.CurScore != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CurScore);
			}
			if (this.MapId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MapId);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Reward);
			}
			if (this.LastMaxScore != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.LastMaxScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00139F4C File Offset: 0x0013814C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UnlockLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UnlockLevel);
			}
			if (this.MaxScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxScore);
			}
			if (this.LastMaxScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastMaxScore);
			}
			if (this.LastLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastLevel);
			}
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.CurScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x0013A01C File Offset: 0x0013821C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogisticsScore other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UnlockLevel != 0U)
			{
				this.UnlockLevel = other.UnlockLevel;
			}
			if (other.MaxScore != 0U)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.LastMaxScore != 0U)
			{
				this.LastMaxScore = other.LastMaxScore;
			}
			if (other.LastLevel != 0U)
			{
				this.LastLevel = other.LastLevel;
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.CurScore != 0U)
			{
				this.CurScore = other.CurScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x0013A0E8 File Offset: 0x001382E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x0013A0F4 File Offset: 0x001382F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.UnlockLevel = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.MaxScore = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LastLevel = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 64U)
					{
						this.CurScore = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.MapId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 120U)
					{
						this.LastMaxScore = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D6C RID: 11628
		private static readonly MessageParser<LogisticsScore> _parser = new MessageParser<LogisticsScore>(() => new LogisticsScore());

		// Token: 0x04002D6D RID: 11629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D6E RID: 11630
		public const int UnlockLevelFieldNumber = 1;

		// Token: 0x04002D6F RID: 11631
		private uint unlockLevel_;

		// Token: 0x04002D70 RID: 11632
		public const int MaxScoreFieldNumber = 3;

		// Token: 0x04002D71 RID: 11633
		private uint maxScore_;

		// Token: 0x04002D72 RID: 11634
		public const int LastMaxScoreFieldNumber = 15;

		// Token: 0x04002D73 RID: 11635
		private uint lastMaxScore_;

		// Token: 0x04002D74 RID: 11636
		public const int LastLevelFieldNumber = 5;

		// Token: 0x04002D75 RID: 11637
		private uint lastLevel_;

		// Token: 0x04002D76 RID: 11638
		public const int MapIdFieldNumber = 13;

		// Token: 0x04002D77 RID: 11639
		private uint mapId_;

		// Token: 0x04002D78 RID: 11640
		public const int RewardFieldNumber = 14;

		// Token: 0x04002D79 RID: 11641
		private ItemList reward_;

		// Token: 0x04002D7A RID: 11642
		public const int CurScoreFieldNumber = 8;

		// Token: 0x04002D7B RID: 11643
		private uint curScore_;
	}
}
