using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001077 RID: 4215
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneInfo : IMessage<SceneInfo>, IMessage, IEquatable<SceneInfo>, IDeepCloneable<SceneInfo>, IBufferMessage
	{
		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600BBAA RID: 48042 RVA: 0x001F8D5A File Offset: 0x001F6F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneInfo> Parser
		{
			get
			{
				return SceneInfo._parser;
			}
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600BBAB RID: 48043 RVA: 0x001F8D61 File Offset: 0x001F6F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600BBAC RID: 48044 RVA: 0x001F8D73 File Offset: 0x001F6F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneInfo.Descriptor;
			}
		}

		// Token: 0x0600BBAD RID: 48045 RVA: 0x001F8D7C File Offset: 0x001F6F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo()
		{
		}

		// Token: 0x0600BBAE RID: 48046 RVA: 0x001F8E00 File Offset: 0x001F7000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo(SceneInfo other) : this()
		{
			this.clientPosVersion_ = other.clientPosVersion_;
			this.lightenSectionList_ = other.lightenSectionList_.Clone();
			this.entityGroupList_ = other.entityGroupList_.Clone();
			this.gameStoryLineId_ = other.gameStoryLineId_;
			this.floorId_ = other.floorId_;
			this.sceneBuffInfoList_ = other.sceneBuffInfoList_.Clone();
			this.entityBuffInfoList_ = other.entityBuffInfoList_.Clone();
			this.entryId_ = other.entryId_;
			this.sceneMissionInfo_ = ((other.sceneMissionInfo_ != null) ? other.sceneMissionInfo_.Clone() : null);
			this.groupStateList_ = other.groupStateList_.Clone();
			this.floorSavedData_ = other.floorSavedData_.Clone();
			this.leaderEntityId_ = other.leaderEntityId_;
			this.entityList_ = other.entityList_.Clone();
			this.dimensionId_ = other.dimensionId_;
			this.groupIdList_ = other.groupIdList_.Clone();
			this.gameModeType_ = other.gameModeType_;
			this.contentId_ = other.contentId_;
			this.customDataList_ = other.customDataList_.Clone();
			this.lFFPPBPNOAC_ = other.lFFPPBPNOAC_.Clone();
			this.worldId_ = other.worldId_;
			this.planeId_ = other.planeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBAF RID: 48047 RVA: 0x001F8F62 File Offset: 0x001F7162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo Clone()
		{
			return new SceneInfo(this);
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600BBB0 RID: 48048 RVA: 0x001F8F6A File Offset: 0x001F716A
		// (set) Token: 0x0600BBB1 RID: 48049 RVA: 0x001F8F72 File Offset: 0x001F7172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ClientPosVersion
		{
			get
			{
				return this.clientPosVersion_;
			}
			set
			{
				this.clientPosVersion_ = value;
			}
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600BBB2 RID: 48050 RVA: 0x001F8F7B File Offset: 0x001F717B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LightenSectionList
		{
			get
			{
				return this.lightenSectionList_;
			}
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600BBB3 RID: 48051 RVA: 0x001F8F83 File Offset: 0x001F7183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneEntityGroupInfo> EntityGroupList
		{
			get
			{
				return this.entityGroupList_;
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600BBB4 RID: 48052 RVA: 0x001F8F8B File Offset: 0x001F718B
		// (set) Token: 0x0600BBB5 RID: 48053 RVA: 0x001F8F93 File Offset: 0x001F7193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameStoryLineId
		{
			get
			{
				return this.gameStoryLineId_;
			}
			set
			{
				this.gameStoryLineId_ = value;
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600BBB6 RID: 48054 RVA: 0x001F8F9C File Offset: 0x001F719C
		// (set) Token: 0x0600BBB7 RID: 48055 RVA: 0x001F8FA4 File Offset: 0x001F71A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FloorId
		{
			get
			{
				return this.floorId_;
			}
			set
			{
				this.floorId_ = value;
			}
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600BBB8 RID: 48056 RVA: 0x001F8FAD File Offset: 0x001F71AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuffInfo> SceneBuffInfoList
		{
			get
			{
				return this.sceneBuffInfoList_;
			}
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0600BBB9 RID: 48057 RVA: 0x001F8FB5 File Offset: 0x001F71B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityBuffInfo> EntityBuffInfoList
		{
			get
			{
				return this.entityBuffInfoList_;
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0600BBBA RID: 48058 RVA: 0x001F8FBD File Offset: 0x001F71BD
		// (set) Token: 0x0600BBBB RID: 48059 RVA: 0x001F8FC5 File Offset: 0x001F71C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntryId
		{
			get
			{
				return this.entryId_;
			}
			set
			{
				this.entryId_ = value;
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0600BBBC RID: 48060 RVA: 0x001F8FCE File Offset: 0x001F71CE
		// (set) Token: 0x0600BBBD RID: 48061 RVA: 0x001F8FD6 File Offset: 0x001F71D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionStatusBySceneInfo SceneMissionInfo
		{
			get
			{
				return this.sceneMissionInfo_;
			}
			set
			{
				this.sceneMissionInfo_ = value;
			}
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600BBBE RID: 48062 RVA: 0x001F8FDF File Offset: 0x001F71DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneGroupState> GroupStateList
		{
			get
			{
				return this.groupStateList_;
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600BBBF RID: 48063 RVA: 0x001F8FE7 File Offset: 0x001F71E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> FloorSavedData
		{
			get
			{
				return this.floorSavedData_;
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600BBC0 RID: 48064 RVA: 0x001F8FEF File Offset: 0x001F71EF
		// (set) Token: 0x0600BBC1 RID: 48065 RVA: 0x001F8FF7 File Offset: 0x001F71F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LeaderEntityId
		{
			get
			{
				return this.leaderEntityId_;
			}
			set
			{
				this.leaderEntityId_ = value;
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600BBC2 RID: 48066 RVA: 0x001F9000 File Offset: 0x001F7200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneEntityInfo> EntityList
		{
			get
			{
				return this.entityList_;
			}
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600BBC3 RID: 48067 RVA: 0x001F9008 File Offset: 0x001F7208
		// (set) Token: 0x0600BBC4 RID: 48068 RVA: 0x001F9010 File Offset: 0x001F7210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DimensionId
		{
			get
			{
				return this.dimensionId_;
			}
			set
			{
				this.dimensionId_ = value;
			}
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600BBC5 RID: 48069 RVA: 0x001F9019 File Offset: 0x001F7219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GroupIdList
		{
			get
			{
				return this.groupIdList_;
			}
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600BBC6 RID: 48070 RVA: 0x001F9021 File Offset: 0x001F7221
		// (set) Token: 0x0600BBC7 RID: 48071 RVA: 0x001F9029 File Offset: 0x001F7229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameModeType
		{
			get
			{
				return this.gameModeType_;
			}
			set
			{
				this.gameModeType_ = value;
			}
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600BBC8 RID: 48072 RVA: 0x001F9032 File Offset: 0x001F7232
		// (set) Token: 0x0600BBC9 RID: 48073 RVA: 0x001F903A File Offset: 0x001F723A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentId
		{
			get
			{
				return this.contentId_;
			}
			set
			{
				this.contentId_ = value;
			}
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600BBCA RID: 48074 RVA: 0x001F9043 File Offset: 0x001F7243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CustomSaveData> CustomDataList
		{
			get
			{
				return this.customDataList_;
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600BBCB RID: 48075 RVA: 0x001F904B File Offset: 0x001F724B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, JBEOFMHCOIC> LFFPPBPNOAC
		{
			get
			{
				return this.lFFPPBPNOAC_;
			}
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600BBCC RID: 48076 RVA: 0x001F9053 File Offset: 0x001F7253
		// (set) Token: 0x0600BBCD RID: 48077 RVA: 0x001F905B File Offset: 0x001F725B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldId
		{
			get
			{
				return this.worldId_;
			}
			set
			{
				this.worldId_ = value;
			}
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600BBCE RID: 48078 RVA: 0x001F9064 File Offset: 0x001F7264
		// (set) Token: 0x0600BBCF RID: 48079 RVA: 0x001F906C File Offset: 0x001F726C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlaneId
		{
			get
			{
				return this.planeId_;
			}
			set
			{
				this.planeId_ = value;
			}
		}

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x001F9075 File Offset: 0x001F7275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneInfo);
		}

		// Token: 0x0600BBD1 RID: 48081 RVA: 0x001F9084 File Offset: 0x001F7284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneInfo other)
		{
			return other != null && (other == this || (this.ClientPosVersion == other.ClientPosVersion && this.lightenSectionList_.Equals(other.lightenSectionList_) && this.entityGroupList_.Equals(other.entityGroupList_) && this.GameStoryLineId == other.GameStoryLineId && this.FloorId == other.FloorId && this.sceneBuffInfoList_.Equals(other.sceneBuffInfoList_) && this.entityBuffInfoList_.Equals(other.entityBuffInfoList_) && this.EntryId == other.EntryId && object.Equals(this.SceneMissionInfo, other.SceneMissionInfo) && this.groupStateList_.Equals(other.groupStateList_) && this.FloorSavedData.Equals(other.FloorSavedData) && this.LeaderEntityId == other.LeaderEntityId && this.entityList_.Equals(other.entityList_) && this.DimensionId == other.DimensionId && this.groupIdList_.Equals(other.groupIdList_) && this.GameModeType == other.GameModeType && this.ContentId == other.ContentId && this.customDataList_.Equals(other.customDataList_) && this.LFFPPBPNOAC.Equals(other.LFFPPBPNOAC) && this.WorldId == other.WorldId && this.PlaneId == other.PlaneId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBD2 RID: 48082 RVA: 0x001F9234 File Offset: 0x001F7434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientPosVersion != 0U)
			{
				num ^= this.ClientPosVersion.GetHashCode();
			}
			num ^= this.lightenSectionList_.GetHashCode();
			num ^= this.entityGroupList_.GetHashCode();
			if (this.GameStoryLineId != 0U)
			{
				num ^= this.GameStoryLineId.GetHashCode();
			}
			if (this.FloorId != 0U)
			{
				num ^= this.FloorId.GetHashCode();
			}
			num ^= this.sceneBuffInfoList_.GetHashCode();
			num ^= this.entityBuffInfoList_.GetHashCode();
			if (this.EntryId != 0U)
			{
				num ^= this.EntryId.GetHashCode();
			}
			if (this.sceneMissionInfo_ != null)
			{
				num ^= this.SceneMissionInfo.GetHashCode();
			}
			num ^= this.groupStateList_.GetHashCode();
			num ^= this.FloorSavedData.GetHashCode();
			if (this.LeaderEntityId != 0U)
			{
				num ^= this.LeaderEntityId.GetHashCode();
			}
			num ^= this.entityList_.GetHashCode();
			if (this.DimensionId != 0U)
			{
				num ^= this.DimensionId.GetHashCode();
			}
			num ^= this.groupIdList_.GetHashCode();
			if (this.GameModeType != 0U)
			{
				num ^= this.GameModeType.GetHashCode();
			}
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
			}
			num ^= this.customDataList_.GetHashCode();
			num ^= this.LFFPPBPNOAC.GetHashCode();
			if (this.WorldId != 0U)
			{
				num ^= this.WorldId.GetHashCode();
			}
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BBD3 RID: 48083 RVA: 0x001F93F6 File Offset: 0x001F75F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BBD4 RID: 48084 RVA: 0x001F93FE File Offset: 0x001F75FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBD5 RID: 48085 RVA: 0x001F9408 File Offset: 0x001F7608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityBuffInfoList_.WriteTo(ref output, SceneInfo._repeated_entityBuffInfoList_codec);
			this.entityList_.WriteTo(ref output, SceneInfo._repeated_entityList_codec);
			if (this.FloorId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.FloorId);
			}
			if (this.GameModeType != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GameModeType);
			}
			this.lightenSectionList_.WriteTo(ref output, SceneInfo._repeated_lightenSectionList_codec);
			if (this.LeaderEntityId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.LeaderEntityId);
			}
			if (this.EntryId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.EntryId);
			}
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.PlaneId);
			}
			this.groupIdList_.WriteTo(ref output, SceneInfo._repeated_groupIdList_codec);
			this.sceneBuffInfoList_.WriteTo(ref output, SceneInfo._repeated_sceneBuffInfoList_codec);
			if (this.ClientPosVersion != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ClientPosVersion);
			}
			this.lFFPPBPNOAC_.WriteTo(ref output, SceneInfo._map_lFFPPBPNOAC_codec);
			if (this.WorldId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.WorldId);
			}
			this.customDataList_.WriteTo(ref output, SceneInfo._repeated_customDataList_codec);
			this.floorSavedData_.WriteTo(ref output, SceneInfo._map_floorSavedData_codec);
			this.entityGroupList_.WriteTo(ref output, SceneInfo._repeated_entityGroupList_codec);
			if (this.DimensionId != 0U)
			{
				output.WriteRawTag(232, 25);
				output.WriteUInt32(this.DimensionId);
			}
			this.groupStateList_.WriteTo(ref output, SceneInfo._repeated_groupStateList_codec);
			if (this.sceneMissionInfo_ != null)
			{
				output.WriteRawTag(170, 41);
				output.WriteMessage(this.SceneMissionInfo);
			}
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(160, 86);
				output.WriteUInt32(this.ContentId);
			}
			if (this.GameStoryLineId != 0U)
			{
				output.WriteRawTag(168, 109);
				output.WriteUInt32(this.GameStoryLineId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBD6 RID: 48086 RVA: 0x001F961C File Offset: 0x001F781C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientPosVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClientPosVersion);
			}
			num += this.lightenSectionList_.CalculateSize(SceneInfo._repeated_lightenSectionList_codec);
			num += this.entityGroupList_.CalculateSize(SceneInfo._repeated_entityGroupList_codec);
			if (this.GameStoryLineId != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.GameStoryLineId);
			}
			if (this.FloorId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FloorId);
			}
			num += this.sceneBuffInfoList_.CalculateSize(SceneInfo._repeated_sceneBuffInfoList_codec);
			num += this.entityBuffInfoList_.CalculateSize(SceneInfo._repeated_entityBuffInfoList_codec);
			if (this.EntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryId);
			}
			if (this.sceneMissionInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SceneMissionInfo);
			}
			num += this.groupStateList_.CalculateSize(SceneInfo._repeated_groupStateList_codec);
			num += this.floorSavedData_.CalculateSize(SceneInfo._map_floorSavedData_codec);
			if (this.LeaderEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LeaderEntityId);
			}
			num += this.entityList_.CalculateSize(SceneInfo._repeated_entityList_codec);
			if (this.DimensionId != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.DimensionId);
			}
			num += this.groupIdList_.CalculateSize(SceneInfo._repeated_groupIdList_codec);
			if (this.GameModeType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameModeType);
			}
			if (this.ContentId != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
			}
			num += this.customDataList_.CalculateSize(SceneInfo._repeated_customDataList_codec);
			num += this.lFFPPBPNOAC_.CalculateSize(SceneInfo._map_lFFPPBPNOAC_codec);
			if (this.WorldId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldId);
			}
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BBD7 RID: 48087 RVA: 0x001F9808 File Offset: 0x001F7A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClientPosVersion != 0U)
			{
				this.ClientPosVersion = other.ClientPosVersion;
			}
			this.lightenSectionList_.Add(other.lightenSectionList_);
			this.entityGroupList_.Add(other.entityGroupList_);
			if (other.GameStoryLineId != 0U)
			{
				this.GameStoryLineId = other.GameStoryLineId;
			}
			if (other.FloorId != 0U)
			{
				this.FloorId = other.FloorId;
			}
			this.sceneBuffInfoList_.Add(other.sceneBuffInfoList_);
			this.entityBuffInfoList_.Add(other.entityBuffInfoList_);
			if (other.EntryId != 0U)
			{
				this.EntryId = other.EntryId;
			}
			if (other.sceneMissionInfo_ != null)
			{
				if (this.sceneMissionInfo_ == null)
				{
					this.SceneMissionInfo = new MissionStatusBySceneInfo();
				}
				this.SceneMissionInfo.MergeFrom(other.SceneMissionInfo);
			}
			this.groupStateList_.Add(other.groupStateList_);
			this.floorSavedData_.MergeFrom(other.floorSavedData_);
			if (other.LeaderEntityId != 0U)
			{
				this.LeaderEntityId = other.LeaderEntityId;
			}
			this.entityList_.Add(other.entityList_);
			if (other.DimensionId != 0U)
			{
				this.DimensionId = other.DimensionId;
			}
			this.groupIdList_.Add(other.groupIdList_);
			if (other.GameModeType != 0U)
			{
				this.GameModeType = other.GameModeType;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			this.customDataList_.Add(other.customDataList_);
			this.lFFPPBPNOAC_.MergeFrom(other.lFFPPBPNOAC_);
			if (other.WorldId != 0U)
			{
				this.WorldId = other.WorldId;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BBD8 RID: 48088 RVA: 0x001F99CE File Offset: 0x001F7BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBD9 RID: 48089 RVA: 0x001F99D8 File Offset: 0x001F7BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num <= 40U)
					{
						if (num <= 18U)
						{
							if (num == 10U)
							{
								this.entityBuffInfoList_.AddEntriesFrom(ref input, SceneInfo._repeated_entityBuffInfoList_codec);
								continue;
							}
							if (num != 18U)
							{
								goto IL_115;
							}
							this.entityList_.AddEntriesFrom(ref input, SceneInfo._repeated_entityList_codec);
							continue;
						}
						else
						{
							if (num == 24U)
							{
								this.FloorId = input.ReadUInt32();
								continue;
							}
							if (num == 32U)
							{
								this.GameModeType = input.ReadUInt32();
								continue;
							}
							if (num != 40U)
							{
								goto IL_115;
							}
						}
					}
					else if (num <= 64U)
					{
						if (num != 42U)
						{
							if (num == 56U)
							{
								this.LeaderEntityId = input.ReadUInt32();
								continue;
							}
							if (num != 64U)
							{
								goto IL_115;
							}
							this.EntryId = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 72U)
						{
							this.PlaneId = input.ReadUInt32();
							continue;
						}
						if (num != 80U && num != 82U)
						{
							goto IL_115;
						}
						this.groupIdList_.AddEntriesFrom(ref input, SceneInfo._repeated_groupIdList_codec);
						continue;
					}
					this.lightenSectionList_.AddEntriesFrom(ref input, SceneInfo._repeated_lightenSectionList_codec);
					continue;
				}
				if (num <= 194U)
				{
					if (num <= 106U)
					{
						if (num == 90U)
						{
							this.sceneBuffInfoList_.AddEntriesFrom(ref input, SceneInfo._repeated_sceneBuffInfoList_codec);
							continue;
						}
						if (num == 96U)
						{
							this.ClientPosVersion = input.ReadUInt32();
							continue;
						}
						if (num == 106U)
						{
							this.lFFPPBPNOAC_.AddEntriesFrom(ref input, SceneInfo._map_lFFPPBPNOAC_codec);
							continue;
						}
					}
					else
					{
						if (num == 112U)
						{
							this.WorldId = input.ReadUInt32();
							continue;
						}
						if (num == 122U)
						{
							this.customDataList_.AddEntriesFrom(ref input, SceneInfo._repeated_customDataList_codec);
							continue;
						}
						if (num == 194U)
						{
							this.floorSavedData_.AddEntriesFrom(ref input, SceneInfo._map_floorSavedData_codec);
							continue;
						}
					}
				}
				else if (num <= 4482U)
				{
					if (num == 2442U)
					{
						this.entityGroupList_.AddEntriesFrom(ref input, SceneInfo._repeated_entityGroupList_codec);
						continue;
					}
					if (num == 3304U)
					{
						this.DimensionId = input.ReadUInt32();
						continue;
					}
					if (num == 4482U)
					{
						this.groupStateList_.AddEntriesFrom(ref input, SceneInfo._repeated_groupStateList_codec);
						continue;
					}
				}
				else
				{
					if (num == 5290U)
					{
						if (this.sceneMissionInfo_ == null)
						{
							this.SceneMissionInfo = new MissionStatusBySceneInfo();
						}
						input.ReadMessage(this.SceneMissionInfo);
						continue;
					}
					if (num == 11040U)
					{
						this.ContentId = input.ReadUInt32();
						continue;
					}
					if (num == 13992U)
					{
						this.GameStoryLineId = input.ReadUInt32();
						continue;
					}
				}
				IL_115:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C19 RID: 19481
		private static readonly MessageParser<SceneInfo> _parser = new MessageParser<SceneInfo>(() => new SceneInfo());

		// Token: 0x04004C1A RID: 19482
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C1B RID: 19483
		public const int ClientPosVersionFieldNumber = 12;

		// Token: 0x04004C1C RID: 19484
		private uint clientPosVersion_;

		// Token: 0x04004C1D RID: 19485
		public const int LightenSectionListFieldNumber = 5;

		// Token: 0x04004C1E RID: 19486
		private static readonly FieldCodec<uint> _repeated_lightenSectionList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04004C1F RID: 19487
		private readonly RepeatedField<uint> lightenSectionList_ = new RepeatedField<uint>();

		// Token: 0x04004C20 RID: 19488
		public const int EntityGroupListFieldNumber = 305;

		// Token: 0x04004C21 RID: 19489
		private static readonly FieldCodec<SceneEntityGroupInfo> _repeated_entityGroupList_codec = FieldCodec.ForMessage<SceneEntityGroupInfo>(2442U, SceneEntityGroupInfo.Parser);

		// Token: 0x04004C22 RID: 19490
		private readonly RepeatedField<SceneEntityGroupInfo> entityGroupList_ = new RepeatedField<SceneEntityGroupInfo>();

		// Token: 0x04004C23 RID: 19491
		public const int GameStoryLineIdFieldNumber = 1749;

		// Token: 0x04004C24 RID: 19492
		private uint gameStoryLineId_;

		// Token: 0x04004C25 RID: 19493
		public const int FloorIdFieldNumber = 3;

		// Token: 0x04004C26 RID: 19494
		private uint floorId_;

		// Token: 0x04004C27 RID: 19495
		public const int SceneBuffInfoListFieldNumber = 11;

		// Token: 0x04004C28 RID: 19496
		private static readonly FieldCodec<BuffInfo> _repeated_sceneBuffInfoList_codec = FieldCodec.ForMessage<BuffInfo>(90U, BuffInfo.Parser);

		// Token: 0x04004C29 RID: 19497
		private readonly RepeatedField<BuffInfo> sceneBuffInfoList_ = new RepeatedField<BuffInfo>();

		// Token: 0x04004C2A RID: 19498
		public const int EntityBuffInfoListFieldNumber = 1;

		// Token: 0x04004C2B RID: 19499
		private static readonly FieldCodec<EntityBuffInfo> _repeated_entityBuffInfoList_codec = FieldCodec.ForMessage<EntityBuffInfo>(10U, EntityBuffInfo.Parser);

		// Token: 0x04004C2C RID: 19500
		private readonly RepeatedField<EntityBuffInfo> entityBuffInfoList_ = new RepeatedField<EntityBuffInfo>();

		// Token: 0x04004C2D RID: 19501
		public const int EntryIdFieldNumber = 8;

		// Token: 0x04004C2E RID: 19502
		private uint entryId_;

		// Token: 0x04004C2F RID: 19503
		public const int SceneMissionInfoFieldNumber = 661;

		// Token: 0x04004C30 RID: 19504
		private MissionStatusBySceneInfo sceneMissionInfo_;

		// Token: 0x04004C31 RID: 19505
		public const int GroupStateListFieldNumber = 560;

		// Token: 0x04004C32 RID: 19506
		private static readonly FieldCodec<SceneGroupState> _repeated_groupStateList_codec = FieldCodec.ForMessage<SceneGroupState>(4482U, SceneGroupState.Parser);

		// Token: 0x04004C33 RID: 19507
		private readonly RepeatedField<SceneGroupState> groupStateList_ = new RepeatedField<SceneGroupState>();

		// Token: 0x04004C34 RID: 19508
		public const int FloorSavedDataFieldNumber = 24;

		// Token: 0x04004C35 RID: 19509
		private static readonly MapField<string, int>.Codec _map_floorSavedData_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 194U);

		// Token: 0x04004C36 RID: 19510
		private readonly MapField<string, int> floorSavedData_ = new MapField<string, int>();

		// Token: 0x04004C37 RID: 19511
		public const int LeaderEntityIdFieldNumber = 7;

		// Token: 0x04004C38 RID: 19512
		private uint leaderEntityId_;

		// Token: 0x04004C39 RID: 19513
		public const int EntityListFieldNumber = 2;

		// Token: 0x04004C3A RID: 19514
		private static readonly FieldCodec<SceneEntityInfo> _repeated_entityList_codec = FieldCodec.ForMessage<SceneEntityInfo>(18U, SceneEntityInfo.Parser);

		// Token: 0x04004C3B RID: 19515
		private readonly RepeatedField<SceneEntityInfo> entityList_ = new RepeatedField<SceneEntityInfo>();

		// Token: 0x04004C3C RID: 19516
		public const int DimensionIdFieldNumber = 413;

		// Token: 0x04004C3D RID: 19517
		private uint dimensionId_;

		// Token: 0x04004C3E RID: 19518
		public const int GroupIdListFieldNumber = 10;

		// Token: 0x04004C3F RID: 19519
		private static readonly FieldCodec<uint> _repeated_groupIdList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04004C40 RID: 19520
		private readonly RepeatedField<uint> groupIdList_ = new RepeatedField<uint>();

		// Token: 0x04004C41 RID: 19521
		public const int GameModeTypeFieldNumber = 4;

		// Token: 0x04004C42 RID: 19522
		private uint gameModeType_;

		// Token: 0x04004C43 RID: 19523
		public const int ContentIdFieldNumber = 1380;

		// Token: 0x04004C44 RID: 19524
		private uint contentId_;

		// Token: 0x04004C45 RID: 19525
		public const int CustomDataListFieldNumber = 15;

		// Token: 0x04004C46 RID: 19526
		private static readonly FieldCodec<CustomSaveData> _repeated_customDataList_codec = FieldCodec.ForMessage<CustomSaveData>(122U, CustomSaveData.Parser);

		// Token: 0x04004C47 RID: 19527
		private readonly RepeatedField<CustomSaveData> customDataList_ = new RepeatedField<CustomSaveData>();

		// Token: 0x04004C48 RID: 19528
		public const int LFFPPBPNOACFieldNumber = 13;

		// Token: 0x04004C49 RID: 19529
		private static readonly MapField<uint, JBEOFMHCOIC>.Codec _map_lFFPPBPNOAC_codec = new MapField<uint, JBEOFMHCOIC>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<JBEOFMHCOIC>(18U, JBEOFMHCOIC.Parser), 106U);

		// Token: 0x04004C4A RID: 19530
		private readonly MapField<uint, JBEOFMHCOIC> lFFPPBPNOAC_ = new MapField<uint, JBEOFMHCOIC>();

		// Token: 0x04004C4B RID: 19531
		public const int WorldIdFieldNumber = 14;

		// Token: 0x04004C4C RID: 19532
		private uint worldId_;

		// Token: 0x04004C4D RID: 19533
		public const int PlaneIdFieldNumber = 9;

		// Token: 0x04004C4E RID: 19534
		private uint planeId_;
	}
}
