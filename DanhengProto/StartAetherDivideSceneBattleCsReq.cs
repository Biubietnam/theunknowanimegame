using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001191 RID: 4497
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartAetherDivideSceneBattleCsReq : IMessage<StartAetherDivideSceneBattleCsReq>, IMessage, IEquatable<StartAetherDivideSceneBattleCsReq>, IDeepCloneable<StartAetherDivideSceneBattleCsReq>, IBufferMessage
	{
		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0600C8BA RID: 51386 RVA: 0x0021A827 File Offset: 0x00218A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartAetherDivideSceneBattleCsReq> Parser
		{
			get
			{
				return StartAetherDivideSceneBattleCsReq._parser;
			}
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0600C8BB RID: 51387 RVA: 0x0021A82E File Offset: 0x00218A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartAetherDivideSceneBattleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0600C8BC RID: 51388 RVA: 0x0021A840 File Offset: 0x00218A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartAetherDivideSceneBattleCsReq.Descriptor;
			}
		}

		// Token: 0x0600C8BD RID: 51389 RVA: 0x0021A847 File Offset: 0x00218A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideSceneBattleCsReq()
		{
		}

		// Token: 0x0600C8BE RID: 51390 RVA: 0x0021A868 File Offset: 0x00218A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideSceneBattleCsReq(StartAetherDivideSceneBattleCsReq other) : this()
		{
			this.skillIndex_ = other.skillIndex_;
			this.assistMonsterEntityInfo_ = other.assistMonsterEntityInfo_.Clone();
			this.attackedByEntityId_ = other.attackedByEntityId_;
			this.assistMonsterEntityIdList_ = other.assistMonsterEntityIdList_.Clone();
			this.castEntityId_ = other.castEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8BF RID: 51391 RVA: 0x0021A8D2 File Offset: 0x00218AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideSceneBattleCsReq Clone()
		{
			return new StartAetherDivideSceneBattleCsReq(this);
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0600C8C0 RID: 51392 RVA: 0x0021A8DA File Offset: 0x00218ADA
		// (set) Token: 0x0600C8C1 RID: 51393 RVA: 0x0021A8E2 File Offset: 0x00218AE2
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

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0600C8C2 RID: 51394 RVA: 0x0021A8EB File Offset: 0x00218AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AssistMonsterEntityInfo> AssistMonsterEntityInfo
		{
			get
			{
				return this.assistMonsterEntityInfo_;
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0600C8C3 RID: 51395 RVA: 0x0021A8F3 File Offset: 0x00218AF3
		// (set) Token: 0x0600C8C4 RID: 51396 RVA: 0x0021A8FB File Offset: 0x00218AFB
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

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0600C8C5 RID: 51397 RVA: 0x0021A904 File Offset: 0x00218B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AssistMonsterEntityIdList
		{
			get
			{
				return this.assistMonsterEntityIdList_;
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0600C8C6 RID: 51398 RVA: 0x0021A90C File Offset: 0x00218B0C
		// (set) Token: 0x0600C8C7 RID: 51399 RVA: 0x0021A914 File Offset: 0x00218B14
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

		// Token: 0x0600C8C8 RID: 51400 RVA: 0x0021A91D File Offset: 0x00218B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartAetherDivideSceneBattleCsReq);
		}

		// Token: 0x0600C8C9 RID: 51401 RVA: 0x0021A92C File Offset: 0x00218B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartAetherDivideSceneBattleCsReq other)
		{
			return other != null && (other == this || (this.SkillIndex == other.SkillIndex && this.assistMonsterEntityInfo_.Equals(other.assistMonsterEntityInfo_) && this.AttackedByEntityId == other.AttackedByEntityId && this.assistMonsterEntityIdList_.Equals(other.assistMonsterEntityIdList_) && this.CastEntityId == other.CastEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8CA RID: 51402 RVA: 0x0021A9B0 File Offset: 0x00218BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillIndex != 0U)
			{
				num ^= this.SkillIndex.GetHashCode();
			}
			num ^= this.assistMonsterEntityInfo_.GetHashCode();
			if (this.AttackedByEntityId != 0U)
			{
				num ^= this.AttackedByEntityId.GetHashCode();
			}
			num ^= this.assistMonsterEntityIdList_.GetHashCode();
			if (this.CastEntityId != 0U)
			{
				num ^= this.CastEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C8CB RID: 51403 RVA: 0x0021AA3D File Offset: 0x00218C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C8CC RID: 51404 RVA: 0x0021AA45 File Offset: 0x00218C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8CD RID: 51405 RVA: 0x0021AA50 File Offset: 0x00218C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.assistMonsterEntityIdList_.WriteTo(ref output, StartAetherDivideSceneBattleCsReq._repeated_assistMonsterEntityIdList_codec);
			if (this.CastEntityId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CastEntityId);
			}
			this.assistMonsterEntityInfo_.WriteTo(ref output, StartAetherDivideSceneBattleCsReq._repeated_assistMonsterEntityInfo_codec);
			if (this.AttackedByEntityId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.AttackedByEntityId);
			}
			if (this.SkillIndex != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.SkillIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C8CE RID: 51406 RVA: 0x0021AAE8 File Offset: 0x00218CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillIndex);
			}
			num += this.assistMonsterEntityInfo_.CalculateSize(StartAetherDivideSceneBattleCsReq._repeated_assistMonsterEntityInfo_codec);
			if (this.AttackedByEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AttackedByEntityId);
			}
			num += this.assistMonsterEntityIdList_.CalculateSize(StartAetherDivideSceneBattleCsReq._repeated_assistMonsterEntityIdList_codec);
			if (this.CastEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CastEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C8CF RID: 51407 RVA: 0x0021AB7C File Offset: 0x00218D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartAetherDivideSceneBattleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillIndex != 0U)
			{
				this.SkillIndex = other.SkillIndex;
			}
			this.assistMonsterEntityInfo_.Add(other.assistMonsterEntityInfo_);
			if (other.AttackedByEntityId != 0U)
			{
				this.AttackedByEntityId = other.AttackedByEntityId;
			}
			this.assistMonsterEntityIdList_.Add(other.assistMonsterEntityIdList_);
			if (other.CastEntityId != 0U)
			{
				this.CastEntityId = other.CastEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C8D0 RID: 51408 RVA: 0x0021AC02 File Offset: 0x00218E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8D1 RID: 51409 RVA: 0x0021AC0C File Offset: 0x00218E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 32U || num == 34U)
					{
						this.assistMonsterEntityIdList_.AddEntriesFrom(ref input, StartAetherDivideSceneBattleCsReq._repeated_assistMonsterEntityIdList_codec);
						continue;
					}
					if (num == 48U)
					{
						this.CastEntityId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.assistMonsterEntityInfo_.AddEntriesFrom(ref input, StartAetherDivideSceneBattleCsReq._repeated_assistMonsterEntityInfo_codec);
						continue;
					}
					if (num == 64U)
					{
						this.AttackedByEntityId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.SkillIndex = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005102 RID: 20738
		private static readonly MessageParser<StartAetherDivideSceneBattleCsReq> _parser = new MessageParser<StartAetherDivideSceneBattleCsReq>(() => new StartAetherDivideSceneBattleCsReq());

		// Token: 0x04005103 RID: 20739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005104 RID: 20740
		public const int SkillIndexFieldNumber = 14;

		// Token: 0x04005105 RID: 20741
		private uint skillIndex_;

		// Token: 0x04005106 RID: 20742
		public const int AssistMonsterEntityInfoFieldNumber = 7;

		// Token: 0x04005107 RID: 20743
		private static readonly FieldCodec<AssistMonsterEntityInfo> _repeated_assistMonsterEntityInfo_codec = FieldCodec.ForMessage<AssistMonsterEntityInfo>(58U, EggLink.DanhengServer.Proto.AssistMonsterEntityInfo.Parser);

		// Token: 0x04005108 RID: 20744
		private readonly RepeatedField<AssistMonsterEntityInfo> assistMonsterEntityInfo_ = new RepeatedField<AssistMonsterEntityInfo>();

		// Token: 0x04005109 RID: 20745
		public const int AttackedByEntityIdFieldNumber = 8;

		// Token: 0x0400510A RID: 20746
		private uint attackedByEntityId_;

		// Token: 0x0400510B RID: 20747
		public const int AssistMonsterEntityIdListFieldNumber = 4;

		// Token: 0x0400510C RID: 20748
		private static readonly FieldCodec<uint> _repeated_assistMonsterEntityIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x0400510D RID: 20749
		private readonly RepeatedField<uint> assistMonsterEntityIdList_ = new RepeatedField<uint>();

		// Token: 0x0400510E RID: 20750
		public const int CastEntityIdFieldNumber = 6;

		// Token: 0x0400510F RID: 20751
		private uint castEntityId_;
	}
}
