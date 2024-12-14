using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D1D RID: 3357
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordBattleRecord : IMessage<PunkLordBattleRecord>, IMessage, IEquatable<PunkLordBattleRecord>, IDeepCloneable<PunkLordBattleRecord>, IBufferMessage
	{
		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x060095E2 RID: 38370 RVA: 0x0018E8CC File Offset: 0x0018CACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordBattleRecord> Parser
		{
			get
			{
				return PunkLordBattleRecord._parser;
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x060095E3 RID: 38371 RVA: 0x0018E8D3 File Offset: 0x0018CAD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordBattleRecordReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x060095E4 RID: 38372 RVA: 0x0018E8E5 File Offset: 0x0018CAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordBattleRecord.Descriptor;
			}
		}

		// Token: 0x060095E5 RID: 38373 RVA: 0x0018E8EC File Offset: 0x0018CAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleRecord()
		{
		}

		// Token: 0x060095E6 RID: 38374 RVA: 0x0018E90C File Offset: 0x0018CB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleRecord(PunkLordBattleRecord other) : this()
		{
			this.uid_ = other.uid_;
			this.damageHp_ = other.damageHp_;
			this.isFinalHit_ = other.isFinalHit_;
			this.overKillDamageHp_ = other.overKillDamageHp_;
			this.battleReplayKey_ = other.battleReplayKey_;
			this.avatarList_ = other.avatarList_.Clone();
			this.assistScore_ = other.assistScore_;
			this.damageScore_ = other.damageScore_;
			this.finalHitScore_ = other.finalHitScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095E7 RID: 38375 RVA: 0x0018E9A1 File Offset: 0x0018CBA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleRecord Clone()
		{
			return new PunkLordBattleRecord(this);
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x060095E8 RID: 38376 RVA: 0x0018E9A9 File Offset: 0x0018CBA9
		// (set) Token: 0x060095E9 RID: 38377 RVA: 0x0018E9B1 File Offset: 0x0018CBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x060095EA RID: 38378 RVA: 0x0018E9BA File Offset: 0x0018CBBA
		// (set) Token: 0x060095EB RID: 38379 RVA: 0x0018E9C2 File Offset: 0x0018CBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DamageHp
		{
			get
			{
				return this.damageHp_;
			}
			set
			{
				this.damageHp_ = value;
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x060095EC RID: 38380 RVA: 0x0018E9CB File Offset: 0x0018CBCB
		// (set) Token: 0x060095ED RID: 38381 RVA: 0x0018E9D3 File Offset: 0x0018CBD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinalHit
		{
			get
			{
				return this.isFinalHit_;
			}
			set
			{
				this.isFinalHit_ = value;
			}
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x060095EE RID: 38382 RVA: 0x0018E9DC File Offset: 0x0018CBDC
		// (set) Token: 0x060095EF RID: 38383 RVA: 0x0018E9E4 File Offset: 0x0018CBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OverKillDamageHp
		{
			get
			{
				return this.overKillDamageHp_;
			}
			set
			{
				this.overKillDamageHp_ = value;
			}
		}

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x060095F0 RID: 38384 RVA: 0x0018E9ED File Offset: 0x0018CBED
		// (set) Token: 0x060095F1 RID: 38385 RVA: 0x0018E9F5 File Offset: 0x0018CBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BattleReplayKey
		{
			get
			{
				return this.battleReplayKey_;
			}
			set
			{
				this.battleReplayKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x060095F2 RID: 38386 RVA: 0x0018EA08 File Offset: 0x0018CC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PunkLordBattleAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x060095F3 RID: 38387 RVA: 0x0018EA10 File Offset: 0x0018CC10
		// (set) Token: 0x060095F4 RID: 38388 RVA: 0x0018EA18 File Offset: 0x0018CC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AssistScore
		{
			get
			{
				return this.assistScore_;
			}
			set
			{
				this.assistScore_ = value;
			}
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x060095F5 RID: 38389 RVA: 0x0018EA21 File Offset: 0x0018CC21
		// (set) Token: 0x060095F6 RID: 38390 RVA: 0x0018EA29 File Offset: 0x0018CC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DamageScore
		{
			get
			{
				return this.damageScore_;
			}
			set
			{
				this.damageScore_ = value;
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x060095F7 RID: 38391 RVA: 0x0018EA32 File Offset: 0x0018CC32
		// (set) Token: 0x060095F8 RID: 38392 RVA: 0x0018EA3A File Offset: 0x0018CC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FinalHitScore
		{
			get
			{
				return this.finalHitScore_;
			}
			set
			{
				this.finalHitScore_ = value;
			}
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x0018EA43 File Offset: 0x0018CC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordBattleRecord);
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x0018EA54 File Offset: 0x0018CC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordBattleRecord other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.DamageHp == other.DamageHp && this.IsFinalHit == other.IsFinalHit && this.OverKillDamageHp == other.OverKillDamageHp && !(this.BattleReplayKey != other.BattleReplayKey) && this.avatarList_.Equals(other.avatarList_) && this.AssistScore == other.AssistScore && this.DamageScore == other.DamageScore && this.FinalHitScore == other.FinalHitScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095FB RID: 38395 RVA: 0x0018EB18 File Offset: 0x0018CD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.DamageHp != 0U)
			{
				num ^= this.DamageHp.GetHashCode();
			}
			if (this.IsFinalHit)
			{
				num ^= this.IsFinalHit.GetHashCode();
			}
			if (this.OverKillDamageHp != 0U)
			{
				num ^= this.OverKillDamageHp.GetHashCode();
			}
			if (this.BattleReplayKey.Length != 0)
			{
				num ^= this.BattleReplayKey.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this.AssistScore != 0U)
			{
				num ^= this.AssistScore.GetHashCode();
			}
			if (this.DamageScore != 0U)
			{
				num ^= this.DamageScore.GetHashCode();
			}
			if (this.FinalHitScore != 0U)
			{
				num ^= this.FinalHitScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095FC RID: 38396 RVA: 0x0018EC16 File Offset: 0x0018CE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060095FD RID: 38397 RVA: 0x0018EC1E File Offset: 0x0018CE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095FE RID: 38398 RVA: 0x0018EC28 File Offset: 0x0018CE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Uid);
			}
			if (this.DamageHp != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.DamageHp);
			}
			if (this.IsFinalHit)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinalHit);
			}
			if (this.OverKillDamageHp != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.OverKillDamageHp);
			}
			if (this.BattleReplayKey.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.BattleReplayKey);
			}
			this.avatarList_.WriteTo(ref output, PunkLordBattleRecord._repeated_avatarList_codec);
			if (this.AssistScore != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AssistScore);
			}
			if (this.DamageScore != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.DamageScore);
			}
			if (this.FinalHitScore != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.FinalHitScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095FF RID: 38399 RVA: 0x0018ED40 File Offset: 0x0018CF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.DamageHp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DamageHp);
			}
			if (this.IsFinalHit)
			{
				num += 2;
			}
			if (this.OverKillDamageHp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OverKillDamageHp);
			}
			if (this.BattleReplayKey.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleReplayKey);
			}
			num += this.avatarList_.CalculateSize(PunkLordBattleRecord._repeated_avatarList_codec);
			if (this.AssistScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AssistScore);
			}
			if (this.DamageScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DamageScore);
			}
			if (this.FinalHitScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FinalHitScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x0018EE34 File Offset: 0x0018D034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordBattleRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.DamageHp != 0U)
			{
				this.DamageHp = other.DamageHp;
			}
			if (other.IsFinalHit)
			{
				this.IsFinalHit = other.IsFinalHit;
			}
			if (other.OverKillDamageHp != 0U)
			{
				this.OverKillDamageHp = other.OverKillDamageHp;
			}
			if (other.BattleReplayKey.Length != 0)
			{
				this.BattleReplayKey = other.BattleReplayKey;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.AssistScore != 0U)
			{
				this.AssistScore = other.AssistScore;
			}
			if (other.DamageScore != 0U)
			{
				this.DamageScore = other.DamageScore;
			}
			if (other.FinalHitScore != 0U)
			{
				this.FinalHitScore = other.FinalHitScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009601 RID: 38401 RVA: 0x0018EF12 File Offset: 0x0018D112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009602 RID: 38402 RVA: 0x0018EF1C File Offset: 0x0018D11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Uid = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.DamageHp = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.IsFinalHit = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.OverKillDamageHp = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 42U)
					{
						this.BattleReplayKey = input.ReadString();
						continue;
					}
					if (num == 50U)
					{
						this.avatarList_.AddEntriesFrom(ref input, PunkLordBattleRecord._repeated_avatarList_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.AssistScore = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.DamageScore = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.FinalHitScore = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A1B RID: 14875
		private static readonly MessageParser<PunkLordBattleRecord> _parser = new MessageParser<PunkLordBattleRecord>(() => new PunkLordBattleRecord());

		// Token: 0x04003A1C RID: 14876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A1D RID: 14877
		public const int UidFieldNumber = 1;

		// Token: 0x04003A1E RID: 14878
		private uint uid_;

		// Token: 0x04003A1F RID: 14879
		public const int DamageHpFieldNumber = 2;

		// Token: 0x04003A20 RID: 14880
		private uint damageHp_;

		// Token: 0x04003A21 RID: 14881
		public const int IsFinalHitFieldNumber = 3;

		// Token: 0x04003A22 RID: 14882
		private bool isFinalHit_;

		// Token: 0x04003A23 RID: 14883
		public const int OverKillDamageHpFieldNumber = 4;

		// Token: 0x04003A24 RID: 14884
		private uint overKillDamageHp_;

		// Token: 0x04003A25 RID: 14885
		public const int BattleReplayKeyFieldNumber = 5;

		// Token: 0x04003A26 RID: 14886
		private string battleReplayKey_ = "";

		// Token: 0x04003A27 RID: 14887
		public const int AvatarListFieldNumber = 6;

		// Token: 0x04003A28 RID: 14888
		private static readonly FieldCodec<PunkLordBattleAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<PunkLordBattleAvatar>(50U, PunkLordBattleAvatar.Parser);

		// Token: 0x04003A29 RID: 14889
		private readonly RepeatedField<PunkLordBattleAvatar> avatarList_ = new RepeatedField<PunkLordBattleAvatar>();

		// Token: 0x04003A2A RID: 14890
		public const int AssistScoreFieldNumber = 7;

		// Token: 0x04003A2B RID: 14891
		private uint assistScore_;

		// Token: 0x04003A2C RID: 14892
		public const int DamageScoreFieldNumber = 8;

		// Token: 0x04003A2D RID: 14893
		private uint damageScore_;

		// Token: 0x04003A2E RID: 14894
		public const int FinalHitScoreFieldNumber = 9;

		// Token: 0x04003A2F RID: 14895
		private uint finalHitScore_;
	}
}
