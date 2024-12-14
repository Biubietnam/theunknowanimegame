using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200107D RID: 4221
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneMonsterWave : IMessage<SceneMonsterWave>, IMessage, IEquatable<SceneMonsterWave>, IDeepCloneable<SceneMonsterWave>, IBufferMessage
	{
		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0600BC1C RID: 48156 RVA: 0x001FAE37 File Offset: 0x001F9037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneMonsterWave> Parser
		{
			get
			{
				return SceneMonsterWave._parser;
			}
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x0600BC1D RID: 48157 RVA: 0x001FAE3E File Offset: 0x001F903E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneMonsterWaveReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x0600BC1E RID: 48158 RVA: 0x001FAE50 File Offset: 0x001F9050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneMonsterWave.Descriptor;
			}
		}

		// Token: 0x0600BC1F RID: 48159 RVA: 0x001FAE57 File Offset: 0x001F9057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterWave()
		{
		}

		// Token: 0x0600BC20 RID: 48160 RVA: 0x001FAE78 File Offset: 0x001F9078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterWave(SceneMonsterWave other) : this()
		{
			this.battleWaveId_ = other.battleWaveId_;
			this.dropList_ = other.dropList_.Clone();
			this.monsterList_ = other.monsterList_.Clone();
			this.monsterParam_ = ((other.monsterParam_ != null) ? other.monsterParam_.Clone() : null);
			this.battleStageId_ = other.battleStageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC21 RID: 48161 RVA: 0x001FAEF2 File Offset: 0x001F90F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterWave Clone()
		{
			return new SceneMonsterWave(this);
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x0600BC22 RID: 48162 RVA: 0x001FAEFA File Offset: 0x001F90FA
		// (set) Token: 0x0600BC23 RID: 48163 RVA: 0x001FAF02 File Offset: 0x001F9102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleWaveId
		{
			get
			{
				return this.battleWaveId_;
			}
			set
			{
				this.battleWaveId_ = value;
			}
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x0600BC24 RID: 48164 RVA: 0x001FAF0B File Offset: 0x001F910B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemList> DropList
		{
			get
			{
				return this.dropList_;
			}
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x0600BC25 RID: 48165 RVA: 0x001FAF13 File Offset: 0x001F9113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneMonster> MonsterList
		{
			get
			{
				return this.monsterList_;
			}
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0600BC26 RID: 48166 RVA: 0x001FAF1B File Offset: 0x001F911B
		// (set) Token: 0x0600BC27 RID: 48167 RVA: 0x001FAF23 File Offset: 0x001F9123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterWaveParam MonsterParam
		{
			get
			{
				return this.monsterParam_;
			}
			set
			{
				this.monsterParam_ = value;
			}
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0600BC28 RID: 48168 RVA: 0x001FAF2C File Offset: 0x001F912C
		// (set) Token: 0x0600BC29 RID: 48169 RVA: 0x001FAF34 File Offset: 0x001F9134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleStageId
		{
			get
			{
				return this.battleStageId_;
			}
			set
			{
				this.battleStageId_ = value;
			}
		}

		// Token: 0x0600BC2A RID: 48170 RVA: 0x001FAF3D File Offset: 0x001F913D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneMonsterWave);
		}

		// Token: 0x0600BC2B RID: 48171 RVA: 0x001FAF4C File Offset: 0x001F914C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneMonsterWave other)
		{
			return other != null && (other == this || (this.BattleWaveId == other.BattleWaveId && this.dropList_.Equals(other.dropList_) && this.monsterList_.Equals(other.monsterList_) && object.Equals(this.MonsterParam, other.MonsterParam) && this.BattleStageId == other.BattleStageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC2C RID: 48172 RVA: 0x001FAFD4 File Offset: 0x001F91D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleWaveId != 0U)
			{
				num ^= this.BattleWaveId.GetHashCode();
			}
			num ^= this.dropList_.GetHashCode();
			num ^= this.monsterList_.GetHashCode();
			if (this.monsterParam_ != null)
			{
				num ^= this.MonsterParam.GetHashCode();
			}
			if (this.BattleStageId != 0U)
			{
				num ^= this.BattleStageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC2D RID: 48173 RVA: 0x001FB05E File Offset: 0x001F925E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BC2E RID: 48174 RVA: 0x001FB066 File Offset: 0x001F9266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC2F RID: 48175 RVA: 0x001FB070 File Offset: 0x001F9270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BattleStageId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BattleStageId);
			}
			if (this.monsterParam_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.MonsterParam);
			}
			if (this.BattleWaveId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.BattleWaveId);
			}
			this.monsterList_.WriteTo(ref output, SceneMonsterWave._repeated_monsterList_codec);
			this.dropList_.WriteTo(ref output, SceneMonsterWave._repeated_dropList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC30 RID: 48176 RVA: 0x001FB108 File Offset: 0x001F9308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleWaveId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleWaveId);
			}
			num += this.dropList_.CalculateSize(SceneMonsterWave._repeated_dropList_codec);
			num += this.monsterList_.CalculateSize(SceneMonsterWave._repeated_monsterList_codec);
			if (this.monsterParam_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MonsterParam);
			}
			if (this.BattleStageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleStageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC31 RID: 48177 RVA: 0x001FB19C File Offset: 0x001F939C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneMonsterWave other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleWaveId != 0U)
			{
				this.BattleWaveId = other.BattleWaveId;
			}
			this.dropList_.Add(other.dropList_);
			this.monsterList_.Add(other.monsterList_);
			if (other.monsterParam_ != null)
			{
				if (this.monsterParam_ == null)
				{
					this.MonsterParam = new SceneMonsterWaveParam();
				}
				this.MonsterParam.MergeFrom(other.MonsterParam);
			}
			if (other.BattleStageId != 0U)
			{
				this.BattleStageId = other.BattleStageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC32 RID: 48178 RVA: 0x001FB23A File Offset: 0x001F943A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC33 RID: 48179 RVA: 0x001FB244 File Offset: 0x001F9444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.BattleStageId = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
					{
						if (this.monsterParam_ == null)
						{
							this.MonsterParam = new SceneMonsterWaveParam();
						}
						input.ReadMessage(this.MonsterParam);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.BattleWaveId = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
					{
						this.monsterList_.AddEntriesFrom(ref input, SceneMonsterWave._repeated_monsterList_codec);
						continue;
					}
					if (num == 90U)
					{
						this.dropList_.AddEntriesFrom(ref input, SceneMonsterWave._repeated_dropList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C7D RID: 19581
		private static readonly MessageParser<SceneMonsterWave> _parser = new MessageParser<SceneMonsterWave>(() => new SceneMonsterWave());

		// Token: 0x04004C7E RID: 19582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C7F RID: 19583
		public const int BattleWaveIdFieldNumber = 7;

		// Token: 0x04004C80 RID: 19584
		private uint battleWaveId_;

		// Token: 0x04004C81 RID: 19585
		public const int DropListFieldNumber = 11;

		// Token: 0x04004C82 RID: 19586
		private static readonly FieldCodec<ItemList> _repeated_dropList_codec = FieldCodec.ForMessage<ItemList>(90U, ItemList.Parser);

		// Token: 0x04004C83 RID: 19587
		private readonly RepeatedField<ItemList> dropList_ = new RepeatedField<ItemList>();

		// Token: 0x04004C84 RID: 19588
		public const int MonsterListFieldNumber = 9;

		// Token: 0x04004C85 RID: 19589
		private static readonly FieldCodec<SceneMonster> _repeated_monsterList_codec = FieldCodec.ForMessage<SceneMonster>(74U, SceneMonster.Parser);

		// Token: 0x04004C86 RID: 19590
		private readonly RepeatedField<SceneMonster> monsterList_ = new RepeatedField<SceneMonster>();

		// Token: 0x04004C87 RID: 19591
		public const int MonsterParamFieldNumber = 6;

		// Token: 0x04004C88 RID: 19592
		private SceneMonsterWaveParam monsterParam_;

		// Token: 0x04004C89 RID: 19593
		public const int BattleStageIdFieldNumber = 2;

		// Token: 0x04004C8A RID: 19594
		private uint battleStageId_;
	}
}
