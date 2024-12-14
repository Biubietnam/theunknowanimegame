using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001059 RID: 4185
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneCastSkillScRsp : IMessage<SceneCastSkillScRsp>, IMessage, IEquatable<SceneCastSkillScRsp>, IDeepCloneable<SceneCastSkillScRsp>, IBufferMessage
	{
		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0600BA56 RID: 47702 RVA: 0x001F4D97 File Offset: 0x001F2F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneCastSkillScRsp> Parser
		{
			get
			{
				return SceneCastSkillScRsp._parser;
			}
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x0600BA57 RID: 47703 RVA: 0x001F4D9E File Offset: 0x001F2F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneCastSkillScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x0600BA58 RID: 47704 RVA: 0x001F4DB0 File Offset: 0x001F2FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneCastSkillScRsp.Descriptor;
			}
		}

		// Token: 0x0600BA59 RID: 47705 RVA: 0x001F4DB7 File Offset: 0x001F2FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillScRsp()
		{
		}

		// Token: 0x0600BA5A RID: 47706 RVA: 0x001F4DCC File Offset: 0x001F2FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillScRsp(SceneCastSkillScRsp other) : this()
		{
			this.castEntityId_ = other.castEntityId_;
			this.monsterBattleInfo_ = other.monsterBattleInfo_.Clone();
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA5B RID: 47707 RVA: 0x001F4E35 File Offset: 0x001F3035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillScRsp Clone()
		{
			return new SceneCastSkillScRsp(this);
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x0600BA5C RID: 47708 RVA: 0x001F4E3D File Offset: 0x001F303D
		// (set) Token: 0x0600BA5D RID: 47709 RVA: 0x001F4E45 File Offset: 0x001F3045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CastEntityId
		{
			get
			{
				return this.castEntityId_;
			}
			set
			{
				this.castEntityId_ = value;
			}
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x0600BA5E RID: 47710 RVA: 0x001F4E4E File Offset: 0x001F304E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HitMonsterBattleInfo> MonsterBattleInfo
		{
			get
			{
				return this.monsterBattleInfo_;
			}
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600BA5F RID: 47711 RVA: 0x001F4E56 File Offset: 0x001F3056
		// (set) Token: 0x0600BA60 RID: 47712 RVA: 0x001F4E5E File Offset: 0x001F305E
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

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0600BA61 RID: 47713 RVA: 0x001F4E67 File Offset: 0x001F3067
		// (set) Token: 0x0600BA62 RID: 47714 RVA: 0x001F4E6F File Offset: 0x001F306F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
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

		// Token: 0x0600BA63 RID: 47715 RVA: 0x001F4E78 File Offset: 0x001F3078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneCastSkillScRsp);
		}

		// Token: 0x0600BA64 RID: 47716 RVA: 0x001F4E88 File Offset: 0x001F3088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneCastSkillScRsp other)
		{
			return other != null && (other == this || (this.CastEntityId == other.CastEntityId && this.monsterBattleInfo_.Equals(other.monsterBattleInfo_) && this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA65 RID: 47717 RVA: 0x001F4EFC File Offset: 0x001F30FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CastEntityId != 0U)
			{
				num ^= this.CastEntityId.GetHashCode();
			}
			num ^= this.monsterBattleInfo_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA66 RID: 47718 RVA: 0x001F4F78 File Offset: 0x001F3178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BA67 RID: 47719 RVA: 0x001F4F80 File Offset: 0x001F3180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA68 RID: 47720 RVA: 0x001F4F8C File Offset: 0x001F318C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CastEntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CastEntityId);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.BattleInfo);
			}
			this.monsterBattleInfo_.WriteTo(ref output, SceneCastSkillScRsp._repeated_monsterBattleInfo_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA69 RID: 47721 RVA: 0x001F5014 File Offset: 0x001F3214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CastEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CastEntityId);
			}
			num += this.monsterBattleInfo_.CalculateSize(SceneCastSkillScRsp._repeated_monsterBattleInfo_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA6A RID: 47722 RVA: 0x001F5098 File Offset: 0x001F3298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneCastSkillScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CastEntityId != 0U)
			{
				this.CastEntityId = other.CastEntityId;
			}
			this.monsterBattleInfo_.Add(other.monsterBattleInfo_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA6B RID: 47723 RVA: 0x001F5125 File Offset: 0x001F3325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA6C RID: 47724 RVA: 0x001F5130 File Offset: 0x001F3330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 8U)
					{
						this.CastEntityId = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.monsterBattleInfo_.AddEntriesFrom(ref input, SceneCastSkillScRsp._repeated_monsterBattleInfo_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004B91 RID: 19345
		private static readonly MessageParser<SceneCastSkillScRsp> _parser = new MessageParser<SceneCastSkillScRsp>(() => new SceneCastSkillScRsp());

		// Token: 0x04004B92 RID: 19346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B93 RID: 19347
		public const int CastEntityIdFieldNumber = 1;

		// Token: 0x04004B94 RID: 19348
		private uint castEntityId_;

		// Token: 0x04004B95 RID: 19349
		public const int MonsterBattleInfoFieldNumber = 9;

		// Token: 0x04004B96 RID: 19350
		private static readonly FieldCodec<HitMonsterBattleInfo> _repeated_monsterBattleInfo_codec = FieldCodec.ForMessage<HitMonsterBattleInfo>(74U, HitMonsterBattleInfo.Parser);

		// Token: 0x04004B97 RID: 19351
		private readonly RepeatedField<HitMonsterBattleInfo> monsterBattleInfo_ = new RepeatedField<HitMonsterBattleInfo>();

		// Token: 0x04004B98 RID: 19352
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04004B99 RID: 19353
		private uint retcode_;

		// Token: 0x04004B9A RID: 19354
		public const int BattleInfoFieldNumber = 7;

		// Token: 0x04004B9B RID: 19355
		private SceneBattleInfo battleInfo_;
	}
}
