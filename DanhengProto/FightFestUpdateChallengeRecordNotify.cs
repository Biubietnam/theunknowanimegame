using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000531 RID: 1329
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightFestUpdateChallengeRecordNotify : IMessage<FightFestUpdateChallengeRecordNotify>, IMessage, IEquatable<FightFestUpdateChallengeRecordNotify>, IDeepCloneable<FightFestUpdateChallengeRecordNotify>, IBufferMessage
	{
		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06003B62 RID: 15202 RVA: 0x000A341F File Offset: 0x000A161F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightFestUpdateChallengeRecordNotify> Parser
		{
			get
			{
				return FightFestUpdateChallengeRecordNotify._parser;
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06003B63 RID: 15203 RVA: 0x000A3426 File Offset: 0x000A1626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightFestUpdateChallengeRecordNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06003B64 RID: 15204 RVA: 0x000A3438 File Offset: 0x000A1638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightFestUpdateChallengeRecordNotify.Descriptor;
			}
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x000A343F File Offset: 0x000A163F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestUpdateChallengeRecordNotify()
		{
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x000A3448 File Offset: 0x000A1648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestUpdateChallengeRecordNotify(FightFestUpdateChallengeRecordNotify other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.ePJPMBMOKAJ_ = other.ePJPMBMOKAJ_;
			this.rank_ = other.rank_;
			this.bFADHPMMODP_ = other.bFADHPMMODP_;
			this.oLKEDEOECOD_ = other.oLKEDEOECOD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x000A34A8 File Offset: 0x000A16A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestUpdateChallengeRecordNotify Clone()
		{
			return new FightFestUpdateChallengeRecordNotify(this);
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x000A34B0 File Offset: 0x000A16B0
		// (set) Token: 0x06003B69 RID: 15209 RVA: 0x000A34B8 File Offset: 0x000A16B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06003B6A RID: 15210 RVA: 0x000A34C1 File Offset: 0x000A16C1
		// (set) Token: 0x06003B6B RID: 15211 RVA: 0x000A34C9 File Offset: 0x000A16C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EPJPMBMOKAJ
		{
			get
			{
				return this.ePJPMBMOKAJ_;
			}
			set
			{
				this.ePJPMBMOKAJ_ = value;
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x000A34D2 File Offset: 0x000A16D2
		// (set) Token: 0x06003B6D RID: 15213 RVA: 0x000A34DA File Offset: 0x000A16DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AAAIFJOAAGO Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06003B6E RID: 15214 RVA: 0x000A34E3 File Offset: 0x000A16E3
		// (set) Token: 0x06003B6F RID: 15215 RVA: 0x000A34EB File Offset: 0x000A16EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BFADHPMMODP
		{
			get
			{
				return this.bFADHPMMODP_;
			}
			set
			{
				this.bFADHPMMODP_ = value;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06003B70 RID: 15216 RVA: 0x000A34F4 File Offset: 0x000A16F4
		// (set) Token: 0x06003B71 RID: 15217 RVA: 0x000A34FC File Offset: 0x000A16FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AAAIFJOAAGO OLKEDEOECOD
		{
			get
			{
				return this.oLKEDEOECOD_;
			}
			set
			{
				this.oLKEDEOECOD_ = value;
			}
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x000A3505 File Offset: 0x000A1705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightFestUpdateChallengeRecordNotify);
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x000A3514 File Offset: 0x000A1714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightFestUpdateChallengeRecordNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.EPJPMBMOKAJ == other.EPJPMBMOKAJ && this.Rank == other.Rank && this.BFADHPMMODP == other.BFADHPMMODP && this.OLKEDEOECOD == other.OLKEDEOECOD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x000A3590 File Offset: 0x000A1790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.EPJPMBMOKAJ != 0U)
			{
				num ^= this.EPJPMBMOKAJ.GetHashCode();
			}
			if (this.Rank != AAAIFJOAAGO.FightFestBattleRankC)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.BFADHPMMODP != 0U)
			{
				num ^= this.BFADHPMMODP.GetHashCode();
			}
			if (this.OLKEDEOECOD != AAAIFJOAAGO.FightFestBattleRankC)
			{
				num ^= this.OLKEDEOECOD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x000A363F File Offset: 0x000A183F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x000A3647 File Offset: 0x000A1847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x000A3650 File Offset: 0x000A1850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.OLKEDEOECOD != AAAIFJOAAGO.FightFestBattleRankC)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.OLKEDEOECOD);
			}
			if (this.Rank != AAAIFJOAAGO.FightFestBattleRankC)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Rank);
			}
			if (this.EPJPMBMOKAJ != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EPJPMBMOKAJ);
			}
			if (this.BFADHPMMODP != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BFADHPMMODP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x000A3700 File Offset: 0x000A1900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.EPJPMBMOKAJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EPJPMBMOKAJ);
			}
			if (this.Rank != AAAIFJOAAGO.FightFestBattleRankC)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Rank);
			}
			if (this.BFADHPMMODP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BFADHPMMODP);
			}
			if (this.OLKEDEOECOD != AAAIFJOAAGO.FightFestBattleRankC)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OLKEDEOECOD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x000A37A0 File Offset: 0x000A19A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightFestUpdateChallengeRecordNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.EPJPMBMOKAJ != 0U)
			{
				this.EPJPMBMOKAJ = other.EPJPMBMOKAJ;
			}
			if (other.Rank != AAAIFJOAAGO.FightFestBattleRankC)
			{
				this.Rank = other.Rank;
			}
			if (other.BFADHPMMODP != 0U)
			{
				this.BFADHPMMODP = other.BFADHPMMODP;
			}
			if (other.OLKEDEOECOD != AAAIFJOAAGO.FightFestBattleRankC)
			{
				this.OLKEDEOECOD = other.OLKEDEOECOD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x000A382C File Offset: 0x000A1A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x000A3838 File Offset: 0x000A1A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.ChallengeId = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.OLKEDEOECOD = (AAAIFJOAAGO)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Rank = (AAAIFJOAAGO)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.EPJPMBMOKAJ = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.BFADHPMMODP = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040017E4 RID: 6116
		private static readonly MessageParser<FightFestUpdateChallengeRecordNotify> _parser = new MessageParser<FightFestUpdateChallengeRecordNotify>(() => new FightFestUpdateChallengeRecordNotify());

		// Token: 0x040017E5 RID: 6117
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017E6 RID: 6118
		public const int ChallengeIdFieldNumber = 2;

		// Token: 0x040017E7 RID: 6119
		private uint challengeId_;

		// Token: 0x040017E8 RID: 6120
		public const int EPJPMBMOKAJFieldNumber = 12;

		// Token: 0x040017E9 RID: 6121
		private uint ePJPMBMOKAJ_;

		// Token: 0x040017EA RID: 6122
		public const int RankFieldNumber = 11;

		// Token: 0x040017EB RID: 6123
		private AAAIFJOAAGO rank_;

		// Token: 0x040017EC RID: 6124
		public const int BFADHPMMODPFieldNumber = 13;

		// Token: 0x040017ED RID: 6125
		private uint bFADHPMMODP_;

		// Token: 0x040017EE RID: 6126
		public const int OLKEDEOECODFieldNumber = 4;

		// Token: 0x040017EF RID: 6127
		private AAAIFJOAAGO oLKEDEOECOD_;
	}
}
