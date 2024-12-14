using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FEB RID: 4075
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournLevel : IMessage<RogueTournLevel>, IMessage, IEquatable<RogueTournLevel>, IDeepCloneable<RogueTournLevel>, IBufferMessage
	{
		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600B55E RID: 46430 RVA: 0x001E6CC7 File Offset: 0x001E4EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournLevel> Parser
		{
			get
			{
				return RogueTournLevel._parser;
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600B55F RID: 46431 RVA: 0x001E6CCE File Offset: 0x001E4ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournLevelReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600B560 RID: 46432 RVA: 0x001E6CE0 File Offset: 0x001E4EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournLevel.Descriptor;
			}
		}

		// Token: 0x0600B561 RID: 46433 RVA: 0x001E6CE7 File Offset: 0x001E4EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevel()
		{
		}

		// Token: 0x0600B562 RID: 46434 RVA: 0x001E6CFC File Offset: 0x001E4EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevel(RogueTournLevel other) : this()
		{
			this.layerId_ = other.layerId_;
			this.tournRoomList_ = other.tournRoomList_.Clone();
			this.levelIndex_ = other.levelIndex_;
			this.status_ = other.status_;
			this.curRoomIndex_ = other.curRoomIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B563 RID: 46435 RVA: 0x001E6D61 File Offset: 0x001E4F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevel Clone()
		{
			return new RogueTournLevel(this);
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600B564 RID: 46436 RVA: 0x001E6D69 File Offset: 0x001E4F69
		// (set) Token: 0x0600B565 RID: 46437 RVA: 0x001E6D71 File Offset: 0x001E4F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LayerId
		{
			get
			{
				return this.layerId_;
			}
			set
			{
				this.layerId_ = value;
			}
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600B566 RID: 46438 RVA: 0x001E6D7A File Offset: 0x001E4F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTournRoomList> TournRoomList
		{
			get
			{
				return this.tournRoomList_;
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600B567 RID: 46439 RVA: 0x001E6D82 File Offset: 0x001E4F82
		// (set) Token: 0x0600B568 RID: 46440 RVA: 0x001E6D8A File Offset: 0x001E4F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelIndex
		{
			get
			{
				return this.levelIndex_;
			}
			set
			{
				this.levelIndex_ = value;
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600B569 RID: 46441 RVA: 0x001E6D93 File Offset: 0x001E4F93
		// (set) Token: 0x0600B56A RID: 46442 RVA: 0x001E6D9B File Offset: 0x001E4F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLayerStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600B56B RID: 46443 RVA: 0x001E6DA4 File Offset: 0x001E4FA4
		// (set) Token: 0x0600B56C RID: 46444 RVA: 0x001E6DAC File Offset: 0x001E4FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurRoomIndex
		{
			get
			{
				return this.curRoomIndex_;
			}
			set
			{
				this.curRoomIndex_ = value;
			}
		}

		// Token: 0x0600B56D RID: 46445 RVA: 0x001E6DB5 File Offset: 0x001E4FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournLevel);
		}

		// Token: 0x0600B56E RID: 46446 RVA: 0x001E6DC4 File Offset: 0x001E4FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournLevel other)
		{
			return other != null && (other == this || (this.LayerId == other.LayerId && this.tournRoomList_.Equals(other.tournRoomList_) && this.LevelIndex == other.LevelIndex && this.Status == other.Status && this.CurRoomIndex == other.CurRoomIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B56F RID: 46447 RVA: 0x001E6E44 File Offset: 0x001E5044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LayerId != 0U)
			{
				num ^= this.LayerId.GetHashCode();
			}
			num ^= this.tournRoomList_.GetHashCode();
			if (this.LevelIndex != 0U)
			{
				num ^= this.LevelIndex.GetHashCode();
			}
			if (this.Status != RogueTournLayerStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.CurRoomIndex != 0U)
			{
				num ^= this.CurRoomIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B570 RID: 46448 RVA: 0x001E6EE2 File Offset: 0x001E50E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B571 RID: 46449 RVA: 0x001E6EEA File Offset: 0x001E50EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B572 RID: 46450 RVA: 0x001E6EF4 File Offset: 0x001E50F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurRoomIndex != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CurRoomIndex);
			}
			if (this.LayerId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LayerId);
			}
			this.tournRoomList_.WriteTo(ref output, RogueTournLevel._repeated_tournRoomList_codec);
			if (this.LevelIndex != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LevelIndex);
			}
			if (this.Status != RogueTournLayerStatus.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B573 RID: 46451 RVA: 0x001E6F98 File Offset: 0x001E5198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LayerId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LayerId);
			}
			num += this.tournRoomList_.CalculateSize(RogueTournLevel._repeated_tournRoomList_codec);
			if (this.LevelIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelIndex);
			}
			if (this.Status != RogueTournLayerStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.CurRoomIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurRoomIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B574 RID: 46452 RVA: 0x001E7034 File Offset: 0x001E5234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LayerId != 0U)
			{
				this.LayerId = other.LayerId;
			}
			this.tournRoomList_.Add(other.tournRoomList_);
			if (other.LevelIndex != 0U)
			{
				this.LevelIndex = other.LevelIndex;
			}
			if (other.Status != RogueTournLayerStatus.None)
			{
				this.Status = other.Status;
			}
			if (other.CurRoomIndex != 0U)
			{
				this.CurRoomIndex = other.CurRoomIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B575 RID: 46453 RVA: 0x001E70BD File Offset: 0x001E52BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B576 RID: 46454 RVA: 0x001E70C8 File Offset: 0x001E52C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.CurRoomIndex = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.LayerId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.tournRoomList_.AddEntriesFrom(ref input, RogueTournLevel._repeated_tournRoomList_codec);
						continue;
					}
					if (num == 112U)
					{
						this.LevelIndex = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Status = (RogueTournLayerStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400498A RID: 18826
		private static readonly MessageParser<RogueTournLevel> _parser = new MessageParser<RogueTournLevel>(() => new RogueTournLevel());

		// Token: 0x0400498B RID: 18827
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400498C RID: 18828
		public const int LayerIdFieldNumber = 3;

		// Token: 0x0400498D RID: 18829
		private uint layerId_;

		// Token: 0x0400498E RID: 18830
		public const int TournRoomListFieldNumber = 5;

		// Token: 0x0400498F RID: 18831
		private static readonly FieldCodec<RogueTournRoomList> _repeated_tournRoomList_codec = FieldCodec.ForMessage<RogueTournRoomList>(42U, RogueTournRoomList.Parser);

		// Token: 0x04004990 RID: 18832
		private readonly RepeatedField<RogueTournRoomList> tournRoomList_ = new RepeatedField<RogueTournRoomList>();

		// Token: 0x04004991 RID: 18833
		public const int LevelIndexFieldNumber = 14;

		// Token: 0x04004992 RID: 18834
		private uint levelIndex_;

		// Token: 0x04004993 RID: 18835
		public const int StatusFieldNumber = 15;

		// Token: 0x04004994 RID: 18836
		private RogueTournLayerStatus status_;

		// Token: 0x04004995 RID: 18837
		public const int CurRoomIndexFieldNumber = 1;

		// Token: 0x04004996 RID: 18838
		private uint curRoomIndex_;
	}
}
