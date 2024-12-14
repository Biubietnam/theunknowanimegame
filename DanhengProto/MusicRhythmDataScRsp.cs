using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BDB RID: 3035
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmDataScRsp : IMessage<MusicRhythmDataScRsp>, IMessage, IEquatable<MusicRhythmDataScRsp>, IDeepCloneable<MusicRhythmDataScRsp>, IBufferMessage
	{
		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x0600864A RID: 34378 RVA: 0x0016260D File Offset: 0x0016080D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmDataScRsp> Parser
		{
			get
			{
				return MusicRhythmDataScRsp._parser;
			}
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x0600864B RID: 34379 RVA: 0x00162614 File Offset: 0x00160814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x0600864C RID: 34380 RVA: 0x00162626 File Offset: 0x00160826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600864D RID: 34381 RVA: 0x0016262D File Offset: 0x0016082D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmDataScRsp()
		{
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x0016266C File Offset: 0x0016086C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmDataScRsp(MusicRhythmDataScRsp other) : this()
		{
			this.unlockSongList_ = other.unlockSongList_.Clone();
			this.curSongId_ = other.curSongId_;
			this.unlockTrackList_ = other.unlockTrackList_.Clone();
			this.unlockPhaseList_ = other.unlockPhaseList_.Clone();
			this.showHint_ = other.showHint_;
			this.musicGroup_ = other.musicGroup_.Clone();
			this.musicLevel_ = other.musicLevel_.Clone();
			this.curLevelId_ = other.curLevelId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600864F RID: 34383 RVA: 0x00162715 File Offset: 0x00160915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmDataScRsp Clone()
		{
			return new MusicRhythmDataScRsp(this);
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x06008650 RID: 34384 RVA: 0x0016271D File Offset: 0x0016091D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockSongList
		{
			get
			{
				return this.unlockSongList_;
			}
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x06008651 RID: 34385 RVA: 0x00162725 File Offset: 0x00160925
		// (set) Token: 0x06008652 RID: 34386 RVA: 0x0016272D File Offset: 0x0016092D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurSongId
		{
			get
			{
				return this.curSongId_;
			}
			set
			{
				this.curSongId_ = value;
			}
		}

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x06008653 RID: 34387 RVA: 0x00162736 File Offset: 0x00160936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockTrackList
		{
			get
			{
				return this.unlockTrackList_;
			}
		}

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x06008654 RID: 34388 RVA: 0x0016273E File Offset: 0x0016093E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockPhaseList
		{
			get
			{
				return this.unlockPhaseList_;
			}
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x06008655 RID: 34389 RVA: 0x00162746 File Offset: 0x00160946
		// (set) Token: 0x06008656 RID: 34390 RVA: 0x0016274E File Offset: 0x0016094E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowHint
		{
			get
			{
				return this.showHint_;
			}
			set
			{
				this.showHint_ = value;
			}
		}

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x06008657 RID: 34391 RVA: 0x00162757 File Offset: 0x00160957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MusicRhythmGroup> MusicGroup
		{
			get
			{
				return this.musicGroup_;
			}
		}

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x06008658 RID: 34392 RVA: 0x0016275F File Offset: 0x0016095F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MusicRhythmLevel> MusicLevel
		{
			get
			{
				return this.musicLevel_;
			}
		}

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x06008659 RID: 34393 RVA: 0x00162767 File Offset: 0x00160967
		// (set) Token: 0x0600865A RID: 34394 RVA: 0x0016276F File Offset: 0x0016096F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurLevelId
		{
			get
			{
				return this.curLevelId_;
			}
			set
			{
				this.curLevelId_ = value;
			}
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x0600865B RID: 34395 RVA: 0x00162778 File Offset: 0x00160978
		// (set) Token: 0x0600865C RID: 34396 RVA: 0x00162780 File Offset: 0x00160980
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

		// Token: 0x0600865D RID: 34397 RVA: 0x00162789 File Offset: 0x00160989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmDataScRsp);
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x00162798 File Offset: 0x00160998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmDataScRsp other)
		{
			return other != null && (other == this || (this.unlockSongList_.Equals(other.unlockSongList_) && this.CurSongId == other.CurSongId && this.unlockTrackList_.Equals(other.unlockTrackList_) && this.unlockPhaseList_.Equals(other.unlockPhaseList_) && this.ShowHint == other.ShowHint && this.musicGroup_.Equals(other.musicGroup_) && this.musicLevel_.Equals(other.musicLevel_) && this.CurLevelId == other.CurLevelId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600865F RID: 34399 RVA: 0x0016286C File Offset: 0x00160A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockSongList_.GetHashCode();
			if (this.CurSongId != 0U)
			{
				num ^= this.CurSongId.GetHashCode();
			}
			num ^= this.unlockTrackList_.GetHashCode();
			num ^= this.unlockPhaseList_.GetHashCode();
			if (this.ShowHint)
			{
				num ^= this.ShowHint.GetHashCode();
			}
			num ^= this.musicGroup_.GetHashCode();
			num ^= this.musicLevel_.GetHashCode();
			if (this.CurLevelId != 0U)
			{
				num ^= this.CurLevelId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008660 RID: 34400 RVA: 0x0016293C File Offset: 0x00160B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x00162944 File Offset: 0x00160B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008662 RID: 34402 RVA: 0x00162950 File Offset: 0x00160B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.musicGroup_.WriteTo(ref output, MusicRhythmDataScRsp._repeated_musicGroup_codec);
			if (this.CurSongId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CurSongId);
			}
			this.unlockPhaseList_.WriteTo(ref output, MusicRhythmDataScRsp._repeated_unlockPhaseList_codec);
			if (this.ShowHint)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ShowHint);
			}
			this.unlockTrackList_.WriteTo(ref output, MusicRhythmDataScRsp._repeated_unlockTrackList_codec);
			if (this.CurLevelId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CurLevelId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			this.musicLevel_.WriteTo(ref output, MusicRhythmDataScRsp._repeated_musicLevel_codec);
			this.unlockSongList_.WriteTo(ref output, MusicRhythmDataScRsp._repeated_unlockSongList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008663 RID: 34403 RVA: 0x00162A38 File Offset: 0x00160C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockSongList_.CalculateSize(MusicRhythmDataScRsp._repeated_unlockSongList_codec);
			if (this.CurSongId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurSongId);
			}
			num += this.unlockTrackList_.CalculateSize(MusicRhythmDataScRsp._repeated_unlockTrackList_codec);
			num += this.unlockPhaseList_.CalculateSize(MusicRhythmDataScRsp._repeated_unlockPhaseList_codec);
			if (this.ShowHint)
			{
				num += 2;
			}
			num += this.musicGroup_.CalculateSize(MusicRhythmDataScRsp._repeated_musicGroup_codec);
			num += this.musicLevel_.CalculateSize(MusicRhythmDataScRsp._repeated_musicLevel_codec);
			if (this.CurLevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurLevelId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008664 RID: 34404 RVA: 0x00162B14 File Offset: 0x00160D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockSongList_.Add(other.unlockSongList_);
			if (other.CurSongId != 0U)
			{
				this.CurSongId = other.CurSongId;
			}
			this.unlockTrackList_.Add(other.unlockTrackList_);
			this.unlockPhaseList_.Add(other.unlockPhaseList_);
			if (other.ShowHint)
			{
				this.ShowHint = other.ShowHint;
			}
			this.musicGroup_.Add(other.musicGroup_);
			this.musicLevel_.Add(other.musicLevel_);
			if (other.CurLevelId != 0U)
			{
				this.CurLevelId = other.CurLevelId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008665 RID: 34405 RVA: 0x00162BE1 File Offset: 0x00160DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008666 RID: 34406 RVA: 0x00162BEC File Offset: 0x00160DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num <= 40U)
					{
						if (num == 10U)
						{
							this.musicGroup_.AddEntriesFrom(ref input, MusicRhythmDataScRsp._repeated_musicGroup_codec);
							continue;
						}
						if (num == 16U)
						{
							this.CurSongId = input.ReadUInt32();
							continue;
						}
						if (num != 40U)
						{
							goto IL_77;
						}
					}
					else if (num != 42U)
					{
						if (num == 48U)
						{
							this.ShowHint = input.ReadBool();
							continue;
						}
						if (num != 64U)
						{
							goto IL_77;
						}
						goto IL_D3;
					}
					this.unlockPhaseList_.AddEntriesFrom(ref input, MusicRhythmDataScRsp._repeated_unlockPhaseList_codec);
					continue;
				}
				if (num <= 96U)
				{
					if (num == 66U)
					{
						goto IL_D3;
					}
					if (num == 80U)
					{
						this.CurLevelId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.musicLevel_.AddEntriesFrom(ref input, MusicRhythmDataScRsp._repeated_musicLevel_codec);
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.unlockSongList_.AddEntriesFrom(ref input, MusicRhythmDataScRsp._repeated_unlockSongList_codec);
						continue;
					}
				}
				IL_77:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_D3:
				this.unlockTrackList_.AddEntriesFrom(ref input, MusicRhythmDataScRsp._repeated_unlockTrackList_codec);
			}
		}

		// Token: 0x04003369 RID: 13161
		private static readonly MessageParser<MusicRhythmDataScRsp> _parser = new MessageParser<MusicRhythmDataScRsp>(() => new MusicRhythmDataScRsp());

		// Token: 0x0400336A RID: 13162
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400336B RID: 13163
		public const int UnlockSongListFieldNumber = 15;

		// Token: 0x0400336C RID: 13164
		private static readonly FieldCodec<uint> _repeated_unlockSongList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x0400336D RID: 13165
		private readonly RepeatedField<uint> unlockSongList_ = new RepeatedField<uint>();

		// Token: 0x0400336E RID: 13166
		public const int CurSongIdFieldNumber = 2;

		// Token: 0x0400336F RID: 13167
		private uint curSongId_;

		// Token: 0x04003370 RID: 13168
		public const int UnlockTrackListFieldNumber = 8;

		// Token: 0x04003371 RID: 13169
		private static readonly FieldCodec<uint> _repeated_unlockTrackList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04003372 RID: 13170
		private readonly RepeatedField<uint> unlockTrackList_ = new RepeatedField<uint>();

		// Token: 0x04003373 RID: 13171
		public const int UnlockPhaseListFieldNumber = 5;

		// Token: 0x04003374 RID: 13172
		private static readonly FieldCodec<uint> _repeated_unlockPhaseList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04003375 RID: 13173
		private readonly RepeatedField<uint> unlockPhaseList_ = new RepeatedField<uint>();

		// Token: 0x04003376 RID: 13174
		public const int ShowHintFieldNumber = 6;

		// Token: 0x04003377 RID: 13175
		private bool showHint_;

		// Token: 0x04003378 RID: 13176
		public const int MusicGroupFieldNumber = 1;

		// Token: 0x04003379 RID: 13177
		private static readonly FieldCodec<MusicRhythmGroup> _repeated_musicGroup_codec = FieldCodec.ForMessage<MusicRhythmGroup>(10U, MusicRhythmGroup.Parser);

		// Token: 0x0400337A RID: 13178
		private readonly RepeatedField<MusicRhythmGroup> musicGroup_ = new RepeatedField<MusicRhythmGroup>();

		// Token: 0x0400337B RID: 13179
		public const int MusicLevelFieldNumber = 13;

		// Token: 0x0400337C RID: 13180
		private static readonly FieldCodec<MusicRhythmLevel> _repeated_musicLevel_codec = FieldCodec.ForMessage<MusicRhythmLevel>(106U, MusicRhythmLevel.Parser);

		// Token: 0x0400337D RID: 13181
		private readonly RepeatedField<MusicRhythmLevel> musicLevel_ = new RepeatedField<MusicRhythmLevel>();

		// Token: 0x0400337E RID: 13182
		public const int CurLevelIdFieldNumber = 10;

		// Token: 0x0400337F RID: 13183
		private uint curLevelId_;

		// Token: 0x04003380 RID: 13184
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04003381 RID: 13185
		private uint retcode_;
	}
}
