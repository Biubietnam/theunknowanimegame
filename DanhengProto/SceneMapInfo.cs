using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001079 RID: 4217
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneMapInfo : IMessage<SceneMapInfo>, IMessage, IEquatable<SceneMapInfo>, IDeepCloneable<SceneMapInfo>, IBufferMessage
	{
		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600BBDD RID: 48093 RVA: 0x001F9F0B File Offset: 0x001F810B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneMapInfo> Parser
		{
			get
			{
				return SceneMapInfo._parser;
			}
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600BBDE RID: 48094 RVA: 0x001F9F12 File Offset: 0x001F8112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneMapInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0600BBDF RID: 48095 RVA: 0x001F9F24 File Offset: 0x001F8124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneMapInfo.Descriptor;
			}
		}

		// Token: 0x0600BBE0 RID: 48096 RVA: 0x001F9F2C File Offset: 0x001F812C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMapInfo()
		{
		}

		// Token: 0x0600BBE1 RID: 48097 RVA: 0x001F9F8C File Offset: 0x001F818C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMapInfo(SceneMapInfo other) : this()
		{
			this.chestList_ = other.chestList_.Clone();
			this.contentId_ = other.contentId_;
			this.lightenSectionList_ = other.lightenSectionList_.Clone();
			this.mazePropList_ = other.mazePropList_.Clone();
			this.dimensionId_ = other.dimensionId_;
			this.entryId_ = other.entryId_;
			this.floorSavedData_ = other.floorSavedData_.Clone();
			this.gCELHDACAJK_ = other.gCELHDACAJK_.Clone();
			this.unlockTeleportList_ = other.unlockTeleportList_.Clone();
			this.entryStoryLineId_ = other.entryStoryLineId_;
			this.mazeGroupList_ = other.mazeGroupList_.Clone();
			this.retcode_ = other.retcode_;
			this.curMapEntryId_ = other.curMapEntryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBE2 RID: 48098 RVA: 0x001FA06F File Offset: 0x001F826F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMapInfo Clone()
		{
			return new SceneMapInfo(this);
		}

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0600BBE3 RID: 48099 RVA: 0x001FA077 File Offset: 0x001F8277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChestInfo> ChestList
		{
			get
			{
				return this.chestList_;
			}
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0600BBE4 RID: 48100 RVA: 0x001FA07F File Offset: 0x001F827F
		// (set) Token: 0x0600BBE5 RID: 48101 RVA: 0x001FA087 File Offset: 0x001F8287
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

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0600BBE6 RID: 48102 RVA: 0x001FA090 File Offset: 0x001F8290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LightenSectionList
		{
			get
			{
				return this.lightenSectionList_;
			}
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0600BBE7 RID: 48103 RVA: 0x001FA098 File Offset: 0x001F8298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MazePropState> MazePropList
		{
			get
			{
				return this.mazePropList_;
			}
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0600BBE8 RID: 48104 RVA: 0x001FA0A0 File Offset: 0x001F82A0
		// (set) Token: 0x0600BBE9 RID: 48105 RVA: 0x001FA0A8 File Offset: 0x001F82A8
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

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0600BBEA RID: 48106 RVA: 0x001FA0B1 File Offset: 0x001F82B1
		// (set) Token: 0x0600BBEB RID: 48107 RVA: 0x001FA0B9 File Offset: 0x001F82B9
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

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0600BBEC RID: 48108 RVA: 0x001FA0C2 File Offset: 0x001F82C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> FloorSavedData
		{
			get
			{
				return this.floorSavedData_;
			}
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0600BBED RID: 48109 RVA: 0x001FA0CA File Offset: 0x001F82CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BKCEKEKHJCA> GCELHDACAJK
		{
			get
			{
				return this.gCELHDACAJK_;
			}
		}

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0600BBEE RID: 48110 RVA: 0x001FA0D2 File Offset: 0x001F82D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockTeleportList
		{
			get
			{
				return this.unlockTeleportList_;
			}
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x0600BBEF RID: 48111 RVA: 0x001FA0DA File Offset: 0x001F82DA
		// (set) Token: 0x0600BBF0 RID: 48112 RVA: 0x001FA0E2 File Offset: 0x001F82E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntryStoryLineId
		{
			get
			{
				return this.entryStoryLineId_;
			}
			set
			{
				this.entryStoryLineId_ = value;
			}
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x0600BBF1 RID: 48113 RVA: 0x001FA0EB File Offset: 0x001F82EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MazeGroup> MazeGroupList
		{
			get
			{
				return this.mazeGroupList_;
			}
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0600BBF2 RID: 48114 RVA: 0x001FA0F3 File Offset: 0x001F82F3
		// (set) Token: 0x0600BBF3 RID: 48115 RVA: 0x001FA0FB File Offset: 0x001F82FB
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

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0600BBF4 RID: 48116 RVA: 0x001FA104 File Offset: 0x001F8304
		// (set) Token: 0x0600BBF5 RID: 48117 RVA: 0x001FA10C File Offset: 0x001F830C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurMapEntryId
		{
			get
			{
				return this.curMapEntryId_;
			}
			set
			{
				this.curMapEntryId_ = value;
			}
		}

		// Token: 0x0600BBF6 RID: 48118 RVA: 0x001FA115 File Offset: 0x001F8315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneMapInfo);
		}

		// Token: 0x0600BBF7 RID: 48119 RVA: 0x001FA124 File Offset: 0x001F8324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneMapInfo other)
		{
			return other != null && (other == this || (this.chestList_.Equals(other.chestList_) && this.ContentId == other.ContentId && this.lightenSectionList_.Equals(other.lightenSectionList_) && this.mazePropList_.Equals(other.mazePropList_) && this.DimensionId == other.DimensionId && this.EntryId == other.EntryId && this.FloorSavedData.Equals(other.FloorSavedData) && this.gCELHDACAJK_.Equals(other.gCELHDACAJK_) && this.unlockTeleportList_.Equals(other.unlockTeleportList_) && this.EntryStoryLineId == other.EntryStoryLineId && this.mazeGroupList_.Equals(other.mazeGroupList_) && this.Retcode == other.Retcode && this.CurMapEntryId == other.CurMapEntryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBF8 RID: 48120 RVA: 0x001FA240 File Offset: 0x001F8440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.chestList_.GetHashCode();
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
			}
			num ^= this.lightenSectionList_.GetHashCode();
			num ^= this.mazePropList_.GetHashCode();
			if (this.DimensionId != 0U)
			{
				num ^= this.DimensionId.GetHashCode();
			}
			if (this.EntryId != 0U)
			{
				num ^= this.EntryId.GetHashCode();
			}
			num ^= this.FloorSavedData.GetHashCode();
			num ^= this.gCELHDACAJK_.GetHashCode();
			num ^= this.unlockTeleportList_.GetHashCode();
			if (this.EntryStoryLineId != 0U)
			{
				num ^= this.EntryStoryLineId.GetHashCode();
			}
			num ^= this.mazeGroupList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CurMapEntryId != 0U)
			{
				num ^= this.CurMapEntryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BBF9 RID: 48121 RVA: 0x001FA35E File Offset: 0x001F855E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BBFA RID: 48122 RVA: 0x001FA366 File Offset: 0x001F8566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBFB RID: 48123 RVA: 0x001FA370 File Offset: 0x001F8570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ContentId);
			}
			if (this.DimensionId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.DimensionId);
			}
			this.mazeGroupList_.WriteTo(ref output, SceneMapInfo._repeated_mazeGroupList_codec);
			if (this.CurMapEntryId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CurMapEntryId);
			}
			this.mazePropList_.WriteTo(ref output, SceneMapInfo._repeated_mazePropList_codec);
			this.unlockTeleportList_.WriteTo(ref output, SceneMapInfo._repeated_unlockTeleportList_codec);
			this.floorSavedData_.WriteTo(ref output, SceneMapInfo._map_floorSavedData_codec);
			this.gCELHDACAJK_.WriteTo(ref output, SceneMapInfo._repeated_gCELHDACAJK_codec);
			if (this.EntryId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.EntryId);
			}
			this.chestList_.WriteTo(ref output, SceneMapInfo._repeated_chestList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EntryStoryLineId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.EntryStoryLineId);
			}
			this.lightenSectionList_.WriteTo(ref output, SceneMapInfo._repeated_lightenSectionList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBFC RID: 48124 RVA: 0x001FA4B0 File Offset: 0x001F86B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.chestList_.CalculateSize(SceneMapInfo._repeated_chestList_codec);
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
			}
			num += this.lightenSectionList_.CalculateSize(SceneMapInfo._repeated_lightenSectionList_codec);
			num += this.mazePropList_.CalculateSize(SceneMapInfo._repeated_mazePropList_codec);
			if (this.DimensionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DimensionId);
			}
			if (this.EntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryId);
			}
			num += this.floorSavedData_.CalculateSize(SceneMapInfo._map_floorSavedData_codec);
			num += this.gCELHDACAJK_.CalculateSize(SceneMapInfo._repeated_gCELHDACAJK_codec);
			num += this.unlockTeleportList_.CalculateSize(SceneMapInfo._repeated_unlockTeleportList_codec);
			if (this.EntryStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryStoryLineId);
			}
			num += this.mazeGroupList_.CalculateSize(SceneMapInfo._repeated_mazeGroupList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CurMapEntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurMapEntryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BBFD RID: 48125 RVA: 0x001FA5EC File Offset: 0x001F87EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneMapInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.chestList_.Add(other.chestList_);
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			this.lightenSectionList_.Add(other.lightenSectionList_);
			this.mazePropList_.Add(other.mazePropList_);
			if (other.DimensionId != 0U)
			{
				this.DimensionId = other.DimensionId;
			}
			if (other.EntryId != 0U)
			{
				this.EntryId = other.EntryId;
			}
			this.floorSavedData_.MergeFrom(other.floorSavedData_);
			this.gCELHDACAJK_.Add(other.gCELHDACAJK_);
			this.unlockTeleportList_.Add(other.unlockTeleportList_);
			if (other.EntryStoryLineId != 0U)
			{
				this.EntryStoryLineId = other.EntryStoryLineId;
			}
			this.mazeGroupList_.Add(other.mazeGroupList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CurMapEntryId != 0U)
			{
				this.CurMapEntryId = other.CurMapEntryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BBFE RID: 48126 RVA: 0x001FA703 File Offset: 0x001F8903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBFF RID: 48127 RVA: 0x001FA70C File Offset: 0x001F890C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.ContentId = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.DimensionId = input.ReadUInt32();
							continue;
						}
						if (num == 26U)
						{
							this.mazeGroupList_.AddEntriesFrom(ref input, SceneMapInfo._repeated_mazeGroupList_codec);
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 32U)
						{
							this.CurMapEntryId = input.ReadUInt32();
							continue;
						}
						if (num == 42U)
						{
							this.mazePropList_.AddEntriesFrom(ref input, SceneMapInfo._repeated_mazePropList_codec);
							continue;
						}
					}
					else if (num == 48U || num == 50U)
					{
						this.unlockTeleportList_.AddEntriesFrom(ref input, SceneMapInfo._repeated_unlockTeleportList_codec);
						continue;
					}
				}
				else if (num <= 90U)
				{
					if (num <= 74U)
					{
						if (num == 66U)
						{
							this.floorSavedData_.AddEntriesFrom(ref input, SceneMapInfo._map_floorSavedData_codec);
							continue;
						}
						if (num == 74U)
						{
							this.gCELHDACAJK_.AddEntriesFrom(ref input, SceneMapInfo._repeated_gCELHDACAJK_codec);
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.EntryId = input.ReadUInt32();
							continue;
						}
						if (num == 90U)
						{
							this.chestList_.AddEntriesFrom(ref input, SceneMapInfo._repeated_chestList_codec);
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.EntryStoryLineId = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.lightenSectionList_.AddEntriesFrom(ref input, SceneMapInfo._repeated_lightenSectionList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C50 RID: 19536
		private static readonly MessageParser<SceneMapInfo> _parser = new MessageParser<SceneMapInfo>(() => new SceneMapInfo());

		// Token: 0x04004C51 RID: 19537
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C52 RID: 19538
		public const int ChestListFieldNumber = 11;

		// Token: 0x04004C53 RID: 19539
		private static readonly FieldCodec<ChestInfo> _repeated_chestList_codec = FieldCodec.ForMessage<ChestInfo>(90U, ChestInfo.Parser);

		// Token: 0x04004C54 RID: 19540
		private readonly RepeatedField<ChestInfo> chestList_ = new RepeatedField<ChestInfo>();

		// Token: 0x04004C55 RID: 19541
		public const int ContentIdFieldNumber = 1;

		// Token: 0x04004C56 RID: 19542
		private uint contentId_;

		// Token: 0x04004C57 RID: 19543
		public const int LightenSectionListFieldNumber = 15;

		// Token: 0x04004C58 RID: 19544
		private static readonly FieldCodec<uint> _repeated_lightenSectionList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04004C59 RID: 19545
		private readonly RepeatedField<uint> lightenSectionList_ = new RepeatedField<uint>();

		// Token: 0x04004C5A RID: 19546
		public const int MazePropListFieldNumber = 5;

		// Token: 0x04004C5B RID: 19547
		private static readonly FieldCodec<MazePropState> _repeated_mazePropList_codec = FieldCodec.ForMessage<MazePropState>(42U, MazePropState.Parser);

		// Token: 0x04004C5C RID: 19548
		private readonly RepeatedField<MazePropState> mazePropList_ = new RepeatedField<MazePropState>();

		// Token: 0x04004C5D RID: 19549
		public const int DimensionIdFieldNumber = 2;

		// Token: 0x04004C5E RID: 19550
		private uint dimensionId_;

		// Token: 0x04004C5F RID: 19551
		public const int EntryIdFieldNumber = 10;

		// Token: 0x04004C60 RID: 19552
		private uint entryId_;

		// Token: 0x04004C61 RID: 19553
		public const int FloorSavedDataFieldNumber = 8;

		// Token: 0x04004C62 RID: 19554
		private static readonly MapField<string, int>.Codec _map_floorSavedData_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x04004C63 RID: 19555
		private readonly MapField<string, int> floorSavedData_ = new MapField<string, int>();

		// Token: 0x04004C64 RID: 19556
		public const int GCELHDACAJKFieldNumber = 9;

		// Token: 0x04004C65 RID: 19557
		private static readonly FieldCodec<BKCEKEKHJCA> _repeated_gCELHDACAJK_codec = FieldCodec.ForMessage<BKCEKEKHJCA>(74U, BKCEKEKHJCA.Parser);

		// Token: 0x04004C66 RID: 19558
		private readonly RepeatedField<BKCEKEKHJCA> gCELHDACAJK_ = new RepeatedField<BKCEKEKHJCA>();

		// Token: 0x04004C67 RID: 19559
		public const int UnlockTeleportListFieldNumber = 6;

		// Token: 0x04004C68 RID: 19560
		private static readonly FieldCodec<uint> _repeated_unlockTeleportList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04004C69 RID: 19561
		private readonly RepeatedField<uint> unlockTeleportList_ = new RepeatedField<uint>();

		// Token: 0x04004C6A RID: 19562
		public const int EntryStoryLineIdFieldNumber = 13;

		// Token: 0x04004C6B RID: 19563
		private uint entryStoryLineId_;

		// Token: 0x04004C6C RID: 19564
		public const int MazeGroupListFieldNumber = 3;

		// Token: 0x04004C6D RID: 19565
		private static readonly FieldCodec<MazeGroup> _repeated_mazeGroupList_codec = FieldCodec.ForMessage<MazeGroup>(26U, MazeGroup.Parser);

		// Token: 0x04004C6E RID: 19566
		private readonly RepeatedField<MazeGroup> mazeGroupList_ = new RepeatedField<MazeGroup>();

		// Token: 0x04004C6F RID: 19567
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04004C70 RID: 19568
		private uint retcode_;

		// Token: 0x04004C71 RID: 19569
		public const int CurMapEntryIdFieldNumber = 4;

		// Token: 0x04004C72 RID: 19570
		private uint curMapEntryId_;
	}
}
