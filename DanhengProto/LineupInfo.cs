using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A13 RID: 2579
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LineupInfo : IMessage<LineupInfo>, IMessage, IEquatable<LineupInfo>, IDeepCloneable<LineupInfo>, IBufferMessage
	{
		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06007283 RID: 29315 RVA: 0x00130B3F File Offset: 0x0012ED3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LineupInfo> Parser
		{
			get
			{
				return LineupInfo._parser;
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06007284 RID: 29316 RVA: 0x00130B46 File Offset: 0x0012ED46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LineupInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06007285 RID: 29317 RVA: 0x00130B58 File Offset: 0x0012ED58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineupInfo.Descriptor;
			}
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x00130B5F File Offset: 0x0012ED5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo()
		{
		}

		// Token: 0x06007287 RID: 29319 RVA: 0x00130BA0 File Offset: 0x0012EDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo(LineupInfo other) : this()
		{
			this.isVirtual_ = other.isVirtual_;
			this.gANLNDBNHLD_ = other.gANLNDBNHLD_;
			this.storyLineAvatarIdList_ = other.storyLineAvatarIdList_.Clone();
			this.mp_ = other.mp_;
			this.avatarList_ = other.avatarList_.Clone();
			this.gameStoryLineId_ = other.gameStoryLineId_;
			this.index_ = other.index_;
			this.extraLineupType_ = other.extraLineupType_;
			this.leaderSlot_ = other.leaderSlot_;
			this.gGHCBPBEFFJ_ = other.gGHCBPBEFFJ_.Clone();
			this.name_ = other.name_;
			this.kBEOKEDNENE_ = other.kBEOKEDNENE_.Clone();
			this.planeId_ = other.planeId_;
			this.maxMp_ = other.maxMp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007288 RID: 29320 RVA: 0x00130C80 File Offset: 0x0012EE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo Clone()
		{
			return new LineupInfo(this);
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06007289 RID: 29321 RVA: 0x00130C88 File Offset: 0x0012EE88
		// (set) Token: 0x0600728A RID: 29322 RVA: 0x00130C90 File Offset: 0x0012EE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVirtual
		{
			get
			{
				return this.isVirtual_;
			}
			set
			{
				this.isVirtual_ = value;
			}
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x0600728B RID: 29323 RVA: 0x00130C99 File Offset: 0x0012EE99
		// (set) Token: 0x0600728C RID: 29324 RVA: 0x00130CA1 File Offset: 0x0012EEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GANLNDBNHLD
		{
			get
			{
				return this.gANLNDBNHLD_;
			}
			set
			{
				this.gANLNDBNHLD_ = value;
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x0600728D RID: 29325 RVA: 0x00130CAA File Offset: 0x0012EEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> StoryLineAvatarIdList
		{
			get
			{
				return this.storyLineAvatarIdList_;
			}
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x0600728E RID: 29326 RVA: 0x00130CB2 File Offset: 0x0012EEB2
		// (set) Token: 0x0600728F RID: 29327 RVA: 0x00130CBA File Offset: 0x0012EEBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Mp
		{
			get
			{
				return this.mp_;
			}
			set
			{
				this.mp_ = value;
			}
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06007290 RID: 29328 RVA: 0x00130CC3 File Offset: 0x0012EEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LineupAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06007291 RID: 29329 RVA: 0x00130CCB File Offset: 0x0012EECB
		// (set) Token: 0x06007292 RID: 29330 RVA: 0x00130CD3 File Offset: 0x0012EED3
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

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06007293 RID: 29331 RVA: 0x00130CDC File Offset: 0x0012EEDC
		// (set) Token: 0x06007294 RID: 29332 RVA: 0x00130CE4 File Offset: 0x0012EEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06007295 RID: 29333 RVA: 0x00130CED File Offset: 0x0012EEED
		// (set) Token: 0x06007296 RID: 29334 RVA: 0x00130CF5 File Offset: 0x0012EEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraLineupType ExtraLineupType
		{
			get
			{
				return this.extraLineupType_;
			}
			set
			{
				this.extraLineupType_ = value;
			}
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06007297 RID: 29335 RVA: 0x00130CFE File Offset: 0x0012EEFE
		// (set) Token: 0x06007298 RID: 29336 RVA: 0x00130D06 File Offset: 0x0012EF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LeaderSlot
		{
			get
			{
				return this.leaderSlot_;
			}
			set
			{
				this.leaderSlot_ = value;
			}
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06007299 RID: 29337 RVA: 0x00130D0F File Offset: 0x0012EF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GGHCBPBEFFJ
		{
			get
			{
				return this.gGHCBPBEFFJ_;
			}
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600729A RID: 29338 RVA: 0x00130D17 File Offset: 0x0012EF17
		// (set) Token: 0x0600729B RID: 29339 RVA: 0x00130D1F File Offset: 0x0012EF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x0600729C RID: 29340 RVA: 0x00130D32 File Offset: 0x0012EF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KBEOKEDNENE
		{
			get
			{
				return this.kBEOKEDNENE_;
			}
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x0600729D RID: 29341 RVA: 0x00130D3A File Offset: 0x0012EF3A
		// (set) Token: 0x0600729E RID: 29342 RVA: 0x00130D42 File Offset: 0x0012EF42
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

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x0600729F RID: 29343 RVA: 0x00130D4B File Offset: 0x0012EF4B
		// (set) Token: 0x060072A0 RID: 29344 RVA: 0x00130D53 File Offset: 0x0012EF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxMp
		{
			get
			{
				return this.maxMp_;
			}
			set
			{
				this.maxMp_ = value;
			}
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x00130D5C File Offset: 0x0012EF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineupInfo);
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x00130D6C File Offset: 0x0012EF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineupInfo other)
		{
			return other != null && (other == this || (this.IsVirtual == other.IsVirtual && this.GANLNDBNHLD == other.GANLNDBNHLD && this.storyLineAvatarIdList_.Equals(other.storyLineAvatarIdList_) && this.Mp == other.Mp && this.avatarList_.Equals(other.avatarList_) && this.GameStoryLineId == other.GameStoryLineId && this.Index == other.Index && this.ExtraLineupType == other.ExtraLineupType && this.LeaderSlot == other.LeaderSlot && this.gGHCBPBEFFJ_.Equals(other.gGHCBPBEFFJ_) && !(this.Name != other.Name) && this.kBEOKEDNENE_.Equals(other.kBEOKEDNENE_) && this.PlaneId == other.PlaneId && this.MaxMp == other.MaxMp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x00130E90 File Offset: 0x0012F090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsVirtual)
			{
				num ^= this.IsVirtual.GetHashCode();
			}
			if (this.GANLNDBNHLD)
			{
				num ^= this.GANLNDBNHLD.GetHashCode();
			}
			num ^= this.storyLineAvatarIdList_.GetHashCode();
			if (this.Mp != 0U)
			{
				num ^= this.Mp.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this.GameStoryLineId != 0U)
			{
				num ^= this.GameStoryLineId.GetHashCode();
			}
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num ^= this.ExtraLineupType.GetHashCode();
			}
			if (this.LeaderSlot != 0U)
			{
				num ^= this.LeaderSlot.GetHashCode();
			}
			num ^= this.gGHCBPBEFFJ_.GetHashCode();
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			num ^= this.kBEOKEDNENE_.GetHashCode();
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this.MaxMp != 0U)
			{
				num ^= this.MaxMp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x00130FF0 File Offset: 0x0012F1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x00130FF8 File Offset: 0x0012F1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072A6 RID: 29350 RVA: 0x00131004 File Offset: 0x0012F204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kBEOKEDNENE_.WriteTo(ref output, LineupInfo._repeated_kBEOKEDNENE_codec);
			if (this.GANLNDBNHLD)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.GANLNDBNHLD);
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ExtraLineupType);
			}
			this.avatarList_.WriteTo(ref output, LineupInfo._repeated_avatarList_codec);
			if (this.MaxMp != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MaxMp);
			}
			if (this.GameStoryLineId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GameStoryLineId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Name);
			}
			this.gGHCBPBEFFJ_.WriteTo(ref output, LineupInfo._repeated_gGHCBPBEFFJ_codec);
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.PlaneId);
			}
			if (this.Index != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Index);
			}
			if (this.LeaderSlot != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.LeaderSlot);
			}
			if (this.IsVirtual)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsVirtual);
			}
			this.storyLineAvatarIdList_.WriteTo(ref output, LineupInfo._repeated_storyLineAvatarIdList_codec);
			if (this.Mp != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Mp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x00131188 File Offset: 0x0012F388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsVirtual)
			{
				num += 2;
			}
			if (this.GANLNDBNHLD)
			{
				num += 2;
			}
			num += this.storyLineAvatarIdList_.CalculateSize(LineupInfo._repeated_storyLineAvatarIdList_codec);
			if (this.Mp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Mp);
			}
			num += this.avatarList_.CalculateSize(LineupInfo._repeated_avatarList_codec);
			if (this.GameStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameStoryLineId);
			}
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ExtraLineupType);
			}
			if (this.LeaderSlot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LeaderSlot);
			}
			num += this.gGHCBPBEFFJ_.CalculateSize(LineupInfo._repeated_gGHCBPBEFFJ_codec);
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.kBEOKEDNENE_.CalculateSize(LineupInfo._repeated_kBEOKEDNENE_codec);
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this.MaxMp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxMp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x001312D8 File Offset: 0x0012F4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsVirtual)
			{
				this.IsVirtual = other.IsVirtual;
			}
			if (other.GANLNDBNHLD)
			{
				this.GANLNDBNHLD = other.GANLNDBNHLD;
			}
			this.storyLineAvatarIdList_.Add(other.storyLineAvatarIdList_);
			if (other.Mp != 0U)
			{
				this.Mp = other.Mp;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.GameStoryLineId != 0U)
			{
				this.GameStoryLineId = other.GameStoryLineId;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				this.ExtraLineupType = other.ExtraLineupType;
			}
			if (other.LeaderSlot != 0U)
			{
				this.LeaderSlot = other.LeaderSlot;
			}
			this.gGHCBPBEFFJ_.Add(other.gGHCBPBEFFJ_);
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this.kBEOKEDNENE_.Add(other.kBEOKEDNENE_);
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			if (other.MaxMp != 0U)
			{
				this.MaxMp = other.MaxMp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x00131411 File Offset: 0x0012F611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x0013141C File Offset: 0x0012F61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num <= 24U)
					{
						if (num <= 10U)
						{
							if (num == 8U || num == 10U)
							{
								this.kBEOKEDNENE_.AddEntriesFrom(ref input, LineupInfo._repeated_kBEOKEDNENE_codec);
								continue;
							}
						}
						else
						{
							if (num == 16U)
							{
								this.GANLNDBNHLD = input.ReadBool();
								continue;
							}
							if (num == 24U)
							{
								this.ExtraLineupType = (ExtraLineupType)input.ReadEnum();
								continue;
							}
						}
					}
					else if (num <= 40U)
					{
						if (num == 34U)
						{
							this.avatarList_.AddEntriesFrom(ref input, LineupInfo._repeated_avatarList_codec);
							continue;
						}
						if (num == 40U)
						{
							this.MaxMp = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.GameStoryLineId = input.ReadUInt32();
							continue;
						}
						if (num == 58U)
						{
							this.Name = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num <= 66U)
					{
						if (num == 64U || num == 66U)
						{
							this.gGHCBPBEFFJ_.AddEntriesFrom(ref input, LineupInfo._repeated_gGHCBPBEFFJ_codec);
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
						if (num == 80U)
						{
							this.Index = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.LeaderSlot = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.IsVirtual = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 112U || num == 114U)
					{
						this.storyLineAvatarIdList_.AddEntriesFrom(ref input, LineupInfo._repeated_storyLineAvatarIdList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.Mp = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C02 RID: 11266
		private static readonly MessageParser<LineupInfo> _parser = new MessageParser<LineupInfo>(() => new LineupInfo());

		// Token: 0x04002C03 RID: 11267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C04 RID: 11268
		public const int IsVirtualFieldNumber = 13;

		// Token: 0x04002C05 RID: 11269
		private bool isVirtual_;

		// Token: 0x04002C06 RID: 11270
		public const int GANLNDBNHLDFieldNumber = 2;

		// Token: 0x04002C07 RID: 11271
		private bool gANLNDBNHLD_;

		// Token: 0x04002C08 RID: 11272
		public const int StoryLineAvatarIdListFieldNumber = 14;

		// Token: 0x04002C09 RID: 11273
		private static readonly FieldCodec<uint> _repeated_storyLineAvatarIdList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04002C0A RID: 11274
		private readonly RepeatedField<uint> storyLineAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04002C0B RID: 11275
		public const int MpFieldNumber = 15;

		// Token: 0x04002C0C RID: 11276
		private uint mp_;

		// Token: 0x04002C0D RID: 11277
		public const int AvatarListFieldNumber = 4;

		// Token: 0x04002C0E RID: 11278
		private static readonly FieldCodec<LineupAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<LineupAvatar>(34U, LineupAvatar.Parser);

		// Token: 0x04002C0F RID: 11279
		private readonly RepeatedField<LineupAvatar> avatarList_ = new RepeatedField<LineupAvatar>();

		// Token: 0x04002C10 RID: 11280
		public const int GameStoryLineIdFieldNumber = 6;

		// Token: 0x04002C11 RID: 11281
		private uint gameStoryLineId_;

		// Token: 0x04002C12 RID: 11282
		public const int IndexFieldNumber = 10;

		// Token: 0x04002C13 RID: 11283
		private uint index_;

		// Token: 0x04002C14 RID: 11284
		public const int ExtraLineupTypeFieldNumber = 3;

		// Token: 0x04002C15 RID: 11285
		private ExtraLineupType extraLineupType_;

		// Token: 0x04002C16 RID: 11286
		public const int LeaderSlotFieldNumber = 12;

		// Token: 0x04002C17 RID: 11287
		private uint leaderSlot_;

		// Token: 0x04002C18 RID: 11288
		public const int GGHCBPBEFFJFieldNumber = 8;

		// Token: 0x04002C19 RID: 11289
		private static readonly FieldCodec<uint> _repeated_gGHCBPBEFFJ_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04002C1A RID: 11290
		private readonly RepeatedField<uint> gGHCBPBEFFJ_ = new RepeatedField<uint>();

		// Token: 0x04002C1B RID: 11291
		public const int NameFieldNumber = 7;

		// Token: 0x04002C1C RID: 11292
		private string name_ = "";

		// Token: 0x04002C1D RID: 11293
		public const int KBEOKEDNENEFieldNumber = 1;

		// Token: 0x04002C1E RID: 11294
		private static readonly FieldCodec<uint> _repeated_kBEOKEDNENE_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04002C1F RID: 11295
		private readonly RepeatedField<uint> kBEOKEDNENE_ = new RepeatedField<uint>();

		// Token: 0x04002C20 RID: 11296
		public const int PlaneIdFieldNumber = 9;

		// Token: 0x04002C21 RID: 11297
		private uint planeId_;

		// Token: 0x04002C22 RID: 11298
		public const int MaxMpFieldNumber = 5;

		// Token: 0x04002C23 RID: 11299
		private uint maxMp_;
	}
}
