using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001055 RID: 4181
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneCastSkillCsReq : IMessage<SceneCastSkillCsReq>, IMessage, IEquatable<SceneCastSkillCsReq>, IDeepCloneable<SceneCastSkillCsReq>, IBufferMessage
	{
		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x0600BA1B RID: 47643 RVA: 0x001F400B File Offset: 0x001F220B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneCastSkillCsReq> Parser
		{
			get
			{
				return SceneCastSkillCsReq._parser;
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0600BA1C RID: 47644 RVA: 0x001F4012 File Offset: 0x001F2212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneCastSkillCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0600BA1D RID: 47645 RVA: 0x001F4024 File Offset: 0x001F2224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneCastSkillCsReq.Descriptor;
			}
		}

		// Token: 0x0600BA1E RID: 47646 RVA: 0x001F402C File Offset: 0x001F222C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillCsReq()
		{
		}

		// Token: 0x0600BA1F RID: 47647 RVA: 0x001F4084 File Offset: 0x001F2284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillCsReq(SceneCastSkillCsReq other) : this()
		{
			this.assistMonsterEntityInfo_ = other.assistMonsterEntityInfo_.Clone();
			this.assistMonsterEntityIdList_ = other.assistMonsterEntityIdList_.Clone();
			this.attackedByEntityId_ = other.attackedByEntityId_;
			this.dynamicValues_ = other.dynamicValues_.Clone();
			this.mazeAbilityStr_ = other.mazeAbilityStr_;
			this.castEntityId_ = other.castEntityId_;
			this.hitTargetEntityIdList_ = other.hitTargetEntityIdList_.Clone();
			this.skillIndex_ = other.skillIndex_;
			this.targetMotion_ = ((other.targetMotion_ != null) ? other.targetMotion_.Clone() : null);
			this.gOJHHBLMAEB_ = other.gOJHHBLMAEB_;
			this.skillExtraTags_ = other.skillExtraTags_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA20 RID: 47648 RVA: 0x001F4155 File Offset: 0x001F2355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillCsReq Clone()
		{
			return new SceneCastSkillCsReq(this);
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0600BA21 RID: 47649 RVA: 0x001F415D File Offset: 0x001F235D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AssistMonsterEntityInfo> AssistMonsterEntityInfo
		{
			get
			{
				return this.assistMonsterEntityInfo_;
			}
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0600BA22 RID: 47650 RVA: 0x001F4165 File Offset: 0x001F2365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AssistMonsterEntityIdList
		{
			get
			{
				return this.assistMonsterEntityIdList_;
			}
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0600BA23 RID: 47651 RVA: 0x001F416D File Offset: 0x001F236D
		// (set) Token: 0x0600BA24 RID: 47652 RVA: 0x001F4175 File Offset: 0x001F2375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AttackedByEntityId
		{
			get
			{
				return this.attackedByEntityId_;
			}
			set
			{
				this.attackedByEntityId_ = value;
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0600BA25 RID: 47653 RVA: 0x001F417E File Offset: 0x001F237E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ALDDPHFCMGG> DynamicValues
		{
			get
			{
				return this.dynamicValues_;
			}
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600BA26 RID: 47654 RVA: 0x001F4186 File Offset: 0x001F2386
		// (set) Token: 0x0600BA27 RID: 47655 RVA: 0x001F418E File Offset: 0x001F238E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MazeAbilityStr
		{
			get
			{
				return this.mazeAbilityStr_;
			}
			set
			{
				this.mazeAbilityStr_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600BA28 RID: 47656 RVA: 0x001F41A1 File Offset: 0x001F23A1
		// (set) Token: 0x0600BA29 RID: 47657 RVA: 0x001F41A9 File Offset: 0x001F23A9
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

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0600BA2A RID: 47658 RVA: 0x001F41B2 File Offset: 0x001F23B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HitTargetEntityIdList
		{
			get
			{
				return this.hitTargetEntityIdList_;
			}
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0600BA2B RID: 47659 RVA: 0x001F41BA File Offset: 0x001F23BA
		// (set) Token: 0x0600BA2C RID: 47660 RVA: 0x001F41C2 File Offset: 0x001F23C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillIndex
		{
			get
			{
				return this.skillIndex_;
			}
			set
			{
				this.skillIndex_ = value;
			}
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0600BA2D RID: 47661 RVA: 0x001F41CB File Offset: 0x001F23CB
		// (set) Token: 0x0600BA2E RID: 47662 RVA: 0x001F41D3 File Offset: 0x001F23D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo TargetMotion
		{
			get
			{
				return this.targetMotion_;
			}
			set
			{
				this.targetMotion_ = value;
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0600BA2F RID: 47663 RVA: 0x001F41DC File Offset: 0x001F23DC
		// (set) Token: 0x0600BA30 RID: 47664 RVA: 0x001F41E4 File Offset: 0x001F23E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GOJHHBLMAEB
		{
			get
			{
				return this.gOJHHBLMAEB_;
			}
			set
			{
				this.gOJHHBLMAEB_ = value;
			}
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0600BA31 RID: 47665 RVA: 0x001F41ED File Offset: 0x001F23ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillExtraTag> SkillExtraTags
		{
			get
			{
				return this.skillExtraTags_;
			}
		}

		// Token: 0x0600BA32 RID: 47666 RVA: 0x001F41F5 File Offset: 0x001F23F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneCastSkillCsReq);
		}

		// Token: 0x0600BA33 RID: 47667 RVA: 0x001F4204 File Offset: 0x001F2404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneCastSkillCsReq other)
		{
			return other != null && (other == this || (this.assistMonsterEntityInfo_.Equals(other.assistMonsterEntityInfo_) && this.assistMonsterEntityIdList_.Equals(other.assistMonsterEntityIdList_) && this.AttackedByEntityId == other.AttackedByEntityId && this.dynamicValues_.Equals(other.dynamicValues_) && !(this.MazeAbilityStr != other.MazeAbilityStr) && this.CastEntityId == other.CastEntityId && this.hitTargetEntityIdList_.Equals(other.hitTargetEntityIdList_) && this.SkillIndex == other.SkillIndex && object.Equals(this.TargetMotion, other.TargetMotion) && this.GOJHHBLMAEB == other.GOJHHBLMAEB && this.skillExtraTags_.Equals(other.skillExtraTags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA34 RID: 47668 RVA: 0x001F4300 File Offset: 0x001F2500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.assistMonsterEntityInfo_.GetHashCode();
			num ^= this.assistMonsterEntityIdList_.GetHashCode();
			if (this.AttackedByEntityId != 0U)
			{
				num ^= this.AttackedByEntityId.GetHashCode();
			}
			num ^= this.dynamicValues_.GetHashCode();
			if (this.MazeAbilityStr.Length != 0)
			{
				num ^= this.MazeAbilityStr.GetHashCode();
			}
			if (this.CastEntityId != 0U)
			{
				num ^= this.CastEntityId.GetHashCode();
			}
			num ^= this.hitTargetEntityIdList_.GetHashCode();
			if (this.SkillIndex != 0U)
			{
				num ^= this.SkillIndex.GetHashCode();
			}
			if (this.targetMotion_ != null)
			{
				num ^= this.TargetMotion.GetHashCode();
			}
			if (this.GOJHHBLMAEB != 0U)
			{
				num ^= this.GOJHHBLMAEB.GetHashCode();
			}
			num ^= this.skillExtraTags_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA35 RID: 47669 RVA: 0x001F4401 File Offset: 0x001F2601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x001F4409 File Offset: 0x001F2609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x001F4414 File Offset: 0x001F2614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillIndex != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.SkillIndex);
			}
			if (this.AttackedByEntityId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AttackedByEntityId);
			}
			this.skillExtraTags_.WriteTo(ref output, SceneCastSkillCsReq._repeated_skillExtraTags_codec);
			this.assistMonsterEntityInfo_.WriteTo(ref output, SceneCastSkillCsReq._repeated_assistMonsterEntityInfo_codec);
			this.dynamicValues_.WriteTo(ref output, SceneCastSkillCsReq._repeated_dynamicValues_codec);
			if (this.targetMotion_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.TargetMotion);
			}
			if (this.GOJHHBLMAEB != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GOJHHBLMAEB);
			}
			this.assistMonsterEntityIdList_.WriteTo(ref output, SceneCastSkillCsReq._repeated_assistMonsterEntityIdList_codec);
			if (this.CastEntityId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.CastEntityId);
			}
			this.hitTargetEntityIdList_.WriteTo(ref output, SceneCastSkillCsReq._repeated_hitTargetEntityIdList_codec);
			if (this.MazeAbilityStr.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.MazeAbilityStr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA38 RID: 47672 RVA: 0x001F4538 File Offset: 0x001F2738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.assistMonsterEntityInfo_.CalculateSize(SceneCastSkillCsReq._repeated_assistMonsterEntityInfo_codec);
			num += this.assistMonsterEntityIdList_.CalculateSize(SceneCastSkillCsReq._repeated_assistMonsterEntityIdList_codec);
			if (this.AttackedByEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AttackedByEntityId);
			}
			num += this.dynamicValues_.CalculateSize(SceneCastSkillCsReq._repeated_dynamicValues_codec);
			if (this.MazeAbilityStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MazeAbilityStr);
			}
			if (this.CastEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CastEntityId);
			}
			num += this.hitTargetEntityIdList_.CalculateSize(SceneCastSkillCsReq._repeated_hitTargetEntityIdList_codec);
			if (this.SkillIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillIndex);
			}
			if (this.targetMotion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetMotion);
			}
			if (this.GOJHHBLMAEB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GOJHHBLMAEB);
			}
			num += this.skillExtraTags_.CalculateSize(SceneCastSkillCsReq._repeated_skillExtraTags_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA39 RID: 47673 RVA: 0x001F4654 File Offset: 0x001F2854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneCastSkillCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.assistMonsterEntityInfo_.Add(other.assistMonsterEntityInfo_);
			this.assistMonsterEntityIdList_.Add(other.assistMonsterEntityIdList_);
			if (other.AttackedByEntityId != 0U)
			{
				this.AttackedByEntityId = other.AttackedByEntityId;
			}
			this.dynamicValues_.Add(other.dynamicValues_);
			if (other.MazeAbilityStr.Length != 0)
			{
				this.MazeAbilityStr = other.MazeAbilityStr;
			}
			if (other.CastEntityId != 0U)
			{
				this.CastEntityId = other.CastEntityId;
			}
			this.hitTargetEntityIdList_.Add(other.hitTargetEntityIdList_);
			if (other.SkillIndex != 0U)
			{
				this.SkillIndex = other.SkillIndex;
			}
			if (other.targetMotion_ != null)
			{
				if (this.targetMotion_ == null)
				{
					this.TargetMotion = new MotionInfo();
				}
				this.TargetMotion.MergeFrom(other.TargetMotion);
			}
			if (other.GOJHHBLMAEB != 0U)
			{
				this.GOJHHBLMAEB = other.GOJHHBLMAEB;
			}
			this.skillExtraTags_.Add(other.skillExtraTags_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA3A RID: 47674 RVA: 0x001F4766 File Offset: 0x001F2966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA3B RID: 47675 RVA: 0x001F4770 File Offset: 0x001F2970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num <= 56U)
					{
						if (num == 24U)
						{
							this.SkillIndex = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.AttackedByEntityId = input.ReadUInt32();
							continue;
						}
						if (num != 56U)
						{
							goto IL_98;
						}
					}
					else if (num <= 66U)
					{
						if (num != 58U)
						{
							if (num != 66U)
							{
								goto IL_98;
							}
							this.assistMonsterEntityInfo_.AddEntriesFrom(ref input, SceneCastSkillCsReq._repeated_assistMonsterEntityInfo_codec);
							continue;
						}
					}
					else
					{
						if (num == 74U)
						{
							this.dynamicValues_.AddEntriesFrom(ref input, SceneCastSkillCsReq._repeated_dynamicValues_codec);
							continue;
						}
						if (num != 82U)
						{
							goto IL_98;
						}
						if (this.targetMotion_ == null)
						{
							this.TargetMotion = new MotionInfo();
						}
						input.ReadMessage(this.TargetMotion);
						continue;
					}
					this.skillExtraTags_.AddEntriesFrom(ref input, SceneCastSkillCsReq._repeated_skillExtraTags_codec);
					continue;
				}
				if (num > 98U)
				{
					if (num <= 112U)
					{
						if (num == 104U)
						{
							this.CastEntityId = input.ReadUInt32();
							continue;
						}
						if (num != 112U)
						{
							goto IL_98;
						}
					}
					else if (num != 114U)
					{
						if (num != 122U)
						{
							goto IL_98;
						}
						this.MazeAbilityStr = input.ReadString();
						continue;
					}
					this.hitTargetEntityIdList_.AddEntriesFrom(ref input, SceneCastSkillCsReq._repeated_hitTargetEntityIdList_codec);
					continue;
				}
				if (num == 88U)
				{
					this.GOJHHBLMAEB = input.ReadUInt32();
					continue;
				}
				if (num == 96U || num == 98U)
				{
					this.assistMonsterEntityIdList_.AddEntriesFrom(ref input, SceneCastSkillCsReq._repeated_assistMonsterEntityIdList_codec);
					continue;
				}
				IL_98:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004B6C RID: 19308
		private static readonly MessageParser<SceneCastSkillCsReq> _parser = new MessageParser<SceneCastSkillCsReq>(() => new SceneCastSkillCsReq());

		// Token: 0x04004B6D RID: 19309
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B6E RID: 19310
		public const int AssistMonsterEntityInfoFieldNumber = 8;

		// Token: 0x04004B6F RID: 19311
		private static readonly FieldCodec<AssistMonsterEntityInfo> _repeated_assistMonsterEntityInfo_codec = FieldCodec.ForMessage<AssistMonsterEntityInfo>(66U, EggLink.DanhengServer.Proto.AssistMonsterEntityInfo.Parser);

		// Token: 0x04004B70 RID: 19312
		private readonly RepeatedField<AssistMonsterEntityInfo> assistMonsterEntityInfo_ = new RepeatedField<AssistMonsterEntityInfo>();

		// Token: 0x04004B71 RID: 19313
		public const int AssistMonsterEntityIdListFieldNumber = 12;

		// Token: 0x04004B72 RID: 19314
		private static readonly FieldCodec<uint> _repeated_assistMonsterEntityIdList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04004B73 RID: 19315
		private readonly RepeatedField<uint> assistMonsterEntityIdList_ = new RepeatedField<uint>();

		// Token: 0x04004B74 RID: 19316
		public const int AttackedByEntityIdFieldNumber = 4;

		// Token: 0x04004B75 RID: 19317
		private uint attackedByEntityId_;

		// Token: 0x04004B76 RID: 19318
		public const int DynamicValuesFieldNumber = 9;

		// Token: 0x04004B77 RID: 19319
		private static readonly FieldCodec<ALDDPHFCMGG> _repeated_dynamicValues_codec = FieldCodec.ForMessage<ALDDPHFCMGG>(74U, ALDDPHFCMGG.Parser);

		// Token: 0x04004B78 RID: 19320
		private readonly RepeatedField<ALDDPHFCMGG> dynamicValues_ = new RepeatedField<ALDDPHFCMGG>();

		// Token: 0x04004B79 RID: 19321
		public const int MazeAbilityStrFieldNumber = 15;

		// Token: 0x04004B7A RID: 19322
		private string mazeAbilityStr_ = "";

		// Token: 0x04004B7B RID: 19323
		public const int CastEntityIdFieldNumber = 13;

		// Token: 0x04004B7C RID: 19324
		private uint castEntityId_;

		// Token: 0x04004B7D RID: 19325
		public const int HitTargetEntityIdListFieldNumber = 14;

		// Token: 0x04004B7E RID: 19326
		private static readonly FieldCodec<uint> _repeated_hitTargetEntityIdList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04004B7F RID: 19327
		private readonly RepeatedField<uint> hitTargetEntityIdList_ = new RepeatedField<uint>();

		// Token: 0x04004B80 RID: 19328
		public const int SkillIndexFieldNumber = 3;

		// Token: 0x04004B81 RID: 19329
		private uint skillIndex_;

		// Token: 0x04004B82 RID: 19330
		public const int TargetMotionFieldNumber = 10;

		// Token: 0x04004B83 RID: 19331
		private MotionInfo targetMotion_;

		// Token: 0x04004B84 RID: 19332
		public const int GOJHHBLMAEBFieldNumber = 11;

		// Token: 0x04004B85 RID: 19333
		private uint gOJHHBLMAEB_;

		// Token: 0x04004B86 RID: 19334
		public const int SkillExtraTagsFieldNumber = 7;

		// Token: 0x04004B87 RID: 19335
		private static readonly FieldCodec<SkillExtraTag> _repeated_skillExtraTags_codec = FieldCodec.ForEnum<SkillExtraTag>(58U, (SkillExtraTag x) => (int)x, (int x) => (SkillExtraTag)x);

		// Token: 0x04004B88 RID: 19336
		private readonly RepeatedField<SkillExtraTag> skillExtraTags_ = new RepeatedField<SkillExtraTag>();
	}
}
