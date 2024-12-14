using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000051 RID: 81
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideBattleInfo : IMessage<AetherDivideBattleInfo>, IMessage, IEquatable<AetherDivideBattleInfo>, IDeepCloneable<AetherDivideBattleInfo>, IBufferMessage
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000A780 File Offset: 0x00008980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideBattleInfo> Parser
		{
			get
			{
				return AetherDivideBattleInfo._parser;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600034D RID: 845 RVA: 0x0000A787 File Offset: 0x00008987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideBattleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000A799 File Offset: 0x00008999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideBattleInfo.Descriptor;
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideBattleInfo()
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000A7CC File Offset: 0x000089CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideBattleInfo(AetherDivideBattleInfo other) : this()
		{
			this.battleId_ = other.battleId_;
			this.stageId_ = other.stageId_;
			this.logicRandomSeed_ = other.logicRandomSeed_;
			this.buffList_ = other.buffList_.Clone();
			this.battleAvatarList_ = other.battleAvatarList_.Clone();
			this.lKAHLGNIECF_ = other.lKAHLGNIECF_;
			this.monsterWaveList_ = other.monsterWaveList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000A853 File Offset: 0x00008A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideBattleInfo Clone()
		{
			return new AetherDivideBattleInfo(this);
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000A85B File Offset: 0x00008A5B
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0000A863 File Offset: 0x00008A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleId
		{
			get
			{
				return this.battleId_;
			}
			set
			{
				this.battleId_ = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000A86C File Offset: 0x00008A6C
		// (set) Token: 0x06000355 RID: 853 RVA: 0x0000A874 File Offset: 0x00008A74
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000A87D File Offset: 0x00008A7D
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000A885 File Offset: 0x00008A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LogicRandomSeed
		{
			get
			{
				return this.logicRandomSeed_;
			}
			set
			{
				this.logicRandomSeed_ = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000A88E File Offset: 0x00008A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleBuff> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000A896 File Offset: 0x00008A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AetherAvatarInfo> BattleAvatarList
		{
			get
			{
				return this.battleAvatarList_;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000A89E File Offset: 0x00008A9E
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000A8A6 File Offset: 0x00008AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LKAHLGNIECF
		{
			get
			{
				return this.lKAHLGNIECF_;
			}
			set
			{
				this.lKAHLGNIECF_ = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0000A8AF File Offset: 0x00008AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneMonsterWave> MonsterWaveList
		{
			get
			{
				return this.monsterWaveList_;
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000A8B7 File Offset: 0x00008AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideBattleInfo);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000A8C8 File Offset: 0x00008AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideBattleInfo other)
		{
			return other != null && (other == this || (this.BattleId == other.BattleId && this.StageId == other.StageId && this.LogicRandomSeed == other.LogicRandomSeed && this.buffList_.Equals(other.buffList_) && this.battleAvatarList_.Equals(other.battleAvatarList_) && this.LKAHLGNIECF == other.LKAHLGNIECF && this.monsterWaveList_.Equals(other.monsterWaveList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000A970 File Offset: 0x00008B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleId != 0U)
			{
				num ^= this.BattleId.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.LogicRandomSeed != 0U)
			{
				num ^= this.LogicRandomSeed.GetHashCode();
			}
			num ^= this.buffList_.GetHashCode();
			num ^= this.battleAvatarList_.GetHashCode();
			if (this.LKAHLGNIECF)
			{
				num ^= this.LKAHLGNIECF.GetHashCode();
			}
			num ^= this.monsterWaveList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000AA24 File Offset: 0x00008C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000AA2C File Offset: 0x00008C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000AA38 File Offset: 0x00008C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffList_.WriteTo(ref output, AetherDivideBattleInfo._repeated_buffList_codec);
			if (this.BattleId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BattleId);
			}
			if (this.LKAHLGNIECF)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.LKAHLGNIECF);
			}
			this.battleAvatarList_.WriteTo(ref output, AetherDivideBattleInfo._repeated_battleAvatarList_codec);
			this.monsterWaveList_.WriteTo(ref output, AetherDivideBattleInfo._repeated_monsterWaveList_codec);
			if (this.StageId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.StageId);
			}
			if (this.LogicRandomSeed != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.LogicRandomSeed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000AAFC File Offset: 0x00008CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleId);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.LogicRandomSeed != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LogicRandomSeed);
			}
			num += this.buffList_.CalculateSize(AetherDivideBattleInfo._repeated_buffList_codec);
			num += this.battleAvatarList_.CalculateSize(AetherDivideBattleInfo._repeated_battleAvatarList_codec);
			if (this.LKAHLGNIECF)
			{
				num += 2;
			}
			num += this.monsterWaveList_.CalculateSize(AetherDivideBattleInfo._repeated_monsterWaveList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideBattleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleId != 0U)
			{
				this.BattleId = other.BattleId;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.LogicRandomSeed != 0U)
			{
				this.LogicRandomSeed = other.LogicRandomSeed;
			}
			this.buffList_.Add(other.buffList_);
			this.battleAvatarList_.Add(other.battleAvatarList_);
			if (other.LKAHLGNIECF)
			{
				this.LKAHLGNIECF = other.LKAHLGNIECF;
			}
			this.monsterWaveList_.Add(other.monsterWaveList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000AC5B File Offset: 0x00008E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000AC64 File Offset: 0x00008E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 34U)
					{
						this.buffList_.AddEntriesFrom(ref input, AetherDivideBattleInfo._repeated_buffList_codec);
						continue;
					}
					if (num == 40U)
					{
						this.BattleId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.LKAHLGNIECF = input.ReadBool();
						continue;
					}
				}
				else if (num <= 106U)
				{
					if (num == 98U)
					{
						this.battleAvatarList_.AddEntriesFrom(ref input, AetherDivideBattleInfo._repeated_battleAvatarList_codec);
						continue;
					}
					if (num == 106U)
					{
						this.monsterWaveList_.AddEntriesFrom(ref input, AetherDivideBattleInfo._repeated_monsterWaveList_codec);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.StageId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.LogicRandomSeed = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400013E RID: 318
		private static readonly MessageParser<AetherDivideBattleInfo> _parser = new MessageParser<AetherDivideBattleInfo>(() => new AetherDivideBattleInfo());

		// Token: 0x0400013F RID: 319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000140 RID: 320
		public const int BattleIdFieldNumber = 5;

		// Token: 0x04000141 RID: 321
		private uint battleId_;

		// Token: 0x04000142 RID: 322
		public const int StageIdFieldNumber = 14;

		// Token: 0x04000143 RID: 323
		private uint stageId_;

		// Token: 0x04000144 RID: 324
		public const int LogicRandomSeedFieldNumber = 15;

		// Token: 0x04000145 RID: 325
		private uint logicRandomSeed_;

		// Token: 0x04000146 RID: 326
		public const int BuffListFieldNumber = 4;

		// Token: 0x04000147 RID: 327
		private static readonly FieldCodec<BattleBuff> _repeated_buffList_codec = FieldCodec.ForMessage<BattleBuff>(34U, BattleBuff.Parser);

		// Token: 0x04000148 RID: 328
		private readonly RepeatedField<BattleBuff> buffList_ = new RepeatedField<BattleBuff>();

		// Token: 0x04000149 RID: 329
		public const int BattleAvatarListFieldNumber = 12;

		// Token: 0x0400014A RID: 330
		private static readonly FieldCodec<AetherAvatarInfo> _repeated_battleAvatarList_codec = FieldCodec.ForMessage<AetherAvatarInfo>(98U, AetherAvatarInfo.Parser);

		// Token: 0x0400014B RID: 331
		private readonly RepeatedField<AetherAvatarInfo> battleAvatarList_ = new RepeatedField<AetherAvatarInfo>();

		// Token: 0x0400014C RID: 332
		public const int LKAHLGNIECFFieldNumber = 9;

		// Token: 0x0400014D RID: 333
		private bool lKAHLGNIECF_;

		// Token: 0x0400014E RID: 334
		public const int MonsterWaveListFieldNumber = 13;

		// Token: 0x0400014F RID: 335
		private static readonly FieldCodec<SceneMonsterWave> _repeated_monsterWaveList_codec = FieldCodec.ForMessage<SceneMonsterWave>(106U, SceneMonsterWave.Parser);

		// Token: 0x04000150 RID: 336
		private readonly RepeatedField<SceneMonsterWave> monsterWaveList_ = new RepeatedField<SceneMonsterWave>();
	}
}
