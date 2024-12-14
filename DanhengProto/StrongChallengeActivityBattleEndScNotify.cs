using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011EB RID: 4587
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StrongChallengeActivityBattleEndScNotify : IMessage<StrongChallengeActivityBattleEndScNotify>, IMessage, IEquatable<StrongChallengeActivityBattleEndScNotify>, IDeepCloneable<StrongChallengeActivityBattleEndScNotify>, IBufferMessage
	{
		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x0600CCF6 RID: 52470 RVA: 0x00226137 File Offset: 0x00224337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StrongChallengeActivityBattleEndScNotify> Parser
		{
			get
			{
				return StrongChallengeActivityBattleEndScNotify._parser;
			}
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x0600CCF7 RID: 52471 RVA: 0x0022613E File Offset: 0x0022433E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StrongChallengeActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x0600CCF8 RID: 52472 RVA: 0x00226150 File Offset: 0x00224350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StrongChallengeActivityBattleEndScNotify.Descriptor;
			}
		}

		// Token: 0x0600CCF9 RID: 52473 RVA: 0x00226157 File Offset: 0x00224357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeActivityBattleEndScNotify()
		{
		}

		// Token: 0x0600CCFA RID: 52474 RVA: 0x00226160 File Offset: 0x00224360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeActivityBattleEndScNotify(StrongChallengeActivityBattleEndScNotify other) : this()
		{
			this.gOCJFIAEMKB_ = other.gOCJFIAEMKB_;
			this.totalDamage_ = other.totalDamage_;
			this.maxScore_ = other.maxScore_;
			this.eMGLBFMFBLN_ = other.eMGLBFMFBLN_;
			this.bHBEBKFDKEO_ = other.bHBEBKFDKEO_;
			this.scoreId_ = other.scoreId_;
			this.stageId_ = other.stageId_;
			this.endStatus_ = other.endStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCFB RID: 52475 RVA: 0x002261E4 File Offset: 0x002243E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeActivityBattleEndScNotify Clone()
		{
			return new StrongChallengeActivityBattleEndScNotify(this);
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x0600CCFC RID: 52476 RVA: 0x002261EC File Offset: 0x002243EC
		// (set) Token: 0x0600CCFD RID: 52477 RVA: 0x002261F4 File Offset: 0x002243F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GOCJFIAEMKB
		{
			get
			{
				return this.gOCJFIAEMKB_;
			}
			set
			{
				this.gOCJFIAEMKB_ = value;
			}
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x0600CCFE RID: 52478 RVA: 0x002261FD File Offset: 0x002243FD
		// (set) Token: 0x0600CCFF RID: 52479 RVA: 0x00226205 File Offset: 0x00224405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TotalDamage
		{
			get
			{
				return this.totalDamage_;
			}
			set
			{
				this.totalDamage_ = value;
			}
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x0600CD00 RID: 52480 RVA: 0x0022620E File Offset: 0x0022440E
		// (set) Token: 0x0600CD01 RID: 52481 RVA: 0x00226216 File Offset: 0x00224416
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

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x0600CD02 RID: 52482 RVA: 0x0022621F File Offset: 0x0022441F
		// (set) Token: 0x0600CD03 RID: 52483 RVA: 0x00226227 File Offset: 0x00224427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EMGLBFMFBLN
		{
			get
			{
				return this.eMGLBFMFBLN_;
			}
			set
			{
				this.eMGLBFMFBLN_ = value;
			}
		}

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x0600CD04 RID: 52484 RVA: 0x00226230 File Offset: 0x00224430
		// (set) Token: 0x0600CD05 RID: 52485 RVA: 0x00226238 File Offset: 0x00224438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BHBEBKFDKEO
		{
			get
			{
				return this.bHBEBKFDKEO_;
			}
			set
			{
				this.bHBEBKFDKEO_ = value;
			}
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x0600CD06 RID: 52486 RVA: 0x00226241 File Offset: 0x00224441
		// (set) Token: 0x0600CD07 RID: 52487 RVA: 0x00226249 File Offset: 0x00224449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x0600CD08 RID: 52488 RVA: 0x00226252 File Offset: 0x00224452
		// (set) Token: 0x0600CD09 RID: 52489 RVA: 0x0022625A File Offset: 0x0022445A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x0600CD0A RID: 52490 RVA: 0x00226263 File Offset: 0x00224463
		// (set) Token: 0x0600CD0B RID: 52491 RVA: 0x0022626B File Offset: 0x0022446B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEndStatus EndStatus
		{
			get
			{
				return this.endStatus_;
			}
			set
			{
				this.endStatus_ = value;
			}
		}

		// Token: 0x0600CD0C RID: 52492 RVA: 0x00226274 File Offset: 0x00224474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StrongChallengeActivityBattleEndScNotify);
		}

		// Token: 0x0600CD0D RID: 52493 RVA: 0x00226284 File Offset: 0x00224484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StrongChallengeActivityBattleEndScNotify other)
		{
			return other != null && (other == this || (this.GOCJFIAEMKB == other.GOCJFIAEMKB && this.TotalDamage == other.TotalDamage && this.MaxScore == other.MaxScore && this.EMGLBFMFBLN == other.EMGLBFMFBLN && this.BHBEBKFDKEO == other.BHBEBKFDKEO && this.ScoreId == other.ScoreId && this.StageId == other.StageId && this.EndStatus == other.EndStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD0E RID: 52494 RVA: 0x00226330 File Offset: 0x00224530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GOCJFIAEMKB != 0U)
			{
				num ^= this.GOCJFIAEMKB.GetHashCode();
			}
			if (this.TotalDamage != 0U)
			{
				num ^= this.TotalDamage.GetHashCode();
			}
			if (this.MaxScore != 0U)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.EMGLBFMFBLN != 0U)
			{
				num ^= this.EMGLBFMFBLN.GetHashCode();
			}
			if (this.BHBEBKFDKEO != 0U)
			{
				num ^= this.BHBEBKFDKEO.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.EndStatus != BattleEndStatus.BattleEndNone)
			{
				num ^= this.EndStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD0F RID: 52495 RVA: 0x00226424 File Offset: 0x00224624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CD10 RID: 52496 RVA: 0x0022642C File Offset: 0x0022462C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD11 RID: 52497 RVA: 0x00226438 File Offset: 0x00224638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.StageId);
			}
			if (this.MaxScore != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MaxScore);
			}
			if (this.EMGLBFMFBLN != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.EMGLBFMFBLN);
			}
			if (this.GOCJFIAEMKB != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GOCJFIAEMKB);
			}
			if (this.BHBEBKFDKEO != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.BHBEBKFDKEO);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.EndStatus != BattleEndStatus.BattleEndNone)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.EndStatus);
			}
			if (this.TotalDamage != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.TotalDamage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD12 RID: 52498 RVA: 0x0022653C File Offset: 0x0022473C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GOCJFIAEMKB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GOCJFIAEMKB);
			}
			if (this.TotalDamage != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TotalDamage);
			}
			if (this.MaxScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxScore);
			}
			if (this.EMGLBFMFBLN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EMGLBFMFBLN);
			}
			if (this.BHBEBKFDKEO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BHBEBKFDKEO);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.EndStatus != BattleEndStatus.BattleEndNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EndStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD13 RID: 52499 RVA: 0x00226624 File Offset: 0x00224824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StrongChallengeActivityBattleEndScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GOCJFIAEMKB != 0U)
			{
				this.GOCJFIAEMKB = other.GOCJFIAEMKB;
			}
			if (other.TotalDamage != 0U)
			{
				this.TotalDamage = other.TotalDamage;
			}
			if (other.MaxScore != 0U)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.EMGLBFMFBLN != 0U)
			{
				this.EMGLBFMFBLN = other.EMGLBFMFBLN;
			}
			if (other.BHBEBKFDKEO != 0U)
			{
				this.BHBEBKFDKEO = other.BHBEBKFDKEO;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.EndStatus != BattleEndStatus.BattleEndNone)
			{
				this.EndStatus = other.EndStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD14 RID: 52500 RVA: 0x002266EC File Offset: 0x002248EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD15 RID: 52501 RVA: 0x002266F8 File Offset: 0x002248F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 32U)
					{
						if (num == 16U)
						{
							this.StageId = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.MaxScore = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.EMGLBFMFBLN = input.ReadUInt32();
							continue;
						}
						if (num == 64U)
						{
							this.GOCJFIAEMKB = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 72U)
					{
						this.BHBEBKFDKEO = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.EndStatus = (BattleEndStatus)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.TotalDamage = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040052A6 RID: 21158
		private static readonly MessageParser<StrongChallengeActivityBattleEndScNotify> _parser = new MessageParser<StrongChallengeActivityBattleEndScNotify>(() => new StrongChallengeActivityBattleEndScNotify());

		// Token: 0x040052A7 RID: 21159
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052A8 RID: 21160
		public const int GOCJFIAEMKBFieldNumber = 8;

		// Token: 0x040052A9 RID: 21161
		private uint gOCJFIAEMKB_;

		// Token: 0x040052AA RID: 21162
		public const int TotalDamageFieldNumber = 14;

		// Token: 0x040052AB RID: 21163
		private uint totalDamage_;

		// Token: 0x040052AC RID: 21164
		public const int MaxScoreFieldNumber = 4;

		// Token: 0x040052AD RID: 21165
		private uint maxScore_;

		// Token: 0x040052AE RID: 21166
		public const int EMGLBFMFBLNFieldNumber = 7;

		// Token: 0x040052AF RID: 21167
		private uint eMGLBFMFBLN_;

		// Token: 0x040052B0 RID: 21168
		public const int BHBEBKFDKEOFieldNumber = 9;

		// Token: 0x040052B1 RID: 21169
		private uint bHBEBKFDKEO_;

		// Token: 0x040052B2 RID: 21170
		public const int ScoreIdFieldNumber = 12;

		// Token: 0x040052B3 RID: 21171
		private uint scoreId_;

		// Token: 0x040052B4 RID: 21172
		public const int StageIdFieldNumber = 2;

		// Token: 0x040052B5 RID: 21173
		private uint stageId_;

		// Token: 0x040052B6 RID: 21174
		public const int EndStatusFieldNumber = 13;

		// Token: 0x040052B7 RID: 21175
		private BattleEndStatus endStatus_;
	}
}
