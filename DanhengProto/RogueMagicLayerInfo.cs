using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EE7 RID: 3815
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicLayerInfo : IMessage<RogueMagicLayerInfo>, IMessage, IEquatable<RogueMagicLayerInfo>, IDeepCloneable<RogueMagicLayerInfo>, IBufferMessage
	{
		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x0600AA88 RID: 43656 RVA: 0x001CB6EF File Offset: 0x001C98EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicLayerInfo> Parser
		{
			get
			{
				return RogueMagicLayerInfo._parser;
			}
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x0600AA89 RID: 43657 RVA: 0x001CB6F6 File Offset: 0x001C98F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicLayerInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x0600AA8A RID: 43658 RVA: 0x001CB708 File Offset: 0x001C9908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicLayerInfo.Descriptor;
			}
		}

		// Token: 0x0600AA8B RID: 43659 RVA: 0x001CB70F File Offset: 0x001C990F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLayerInfo()
		{
		}

		// Token: 0x0600AA8C RID: 43660 RVA: 0x001CB724 File Offset: 0x001C9924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLayerInfo(RogueMagicLayerInfo other) : this()
		{
			this.tournRoomList_ = other.tournRoomList_.Clone();
			this.levelIndex_ = other.levelIndex_;
			this.layerId_ = other.layerId_;
			this.curRoomIndex_ = other.curRoomIndex_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x001CB789 File Offset: 0x001C9989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLayerInfo Clone()
		{
			return new RogueMagicLayerInfo(this);
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x0600AA8E RID: 43662 RVA: 0x001CB791 File Offset: 0x001C9991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicRoomInfo> TournRoomList
		{
			get
			{
				return this.tournRoomList_;
			}
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x0600AA8F RID: 43663 RVA: 0x001CB799 File Offset: 0x001C9999
		// (set) Token: 0x0600AA90 RID: 43664 RVA: 0x001CB7A1 File Offset: 0x001C99A1
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

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x0600AA91 RID: 43665 RVA: 0x001CB7AA File Offset: 0x001C99AA
		// (set) Token: 0x0600AA92 RID: 43666 RVA: 0x001CB7B2 File Offset: 0x001C99B2
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

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x0600AA93 RID: 43667 RVA: 0x001CB7BB File Offset: 0x001C99BB
		// (set) Token: 0x0600AA94 RID: 43668 RVA: 0x001CB7C3 File Offset: 0x001C99C3
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

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x0600AA95 RID: 43669 RVA: 0x001CB7CC File Offset: 0x001C99CC
		// (set) Token: 0x0600AA96 RID: 43670 RVA: 0x001CB7D4 File Offset: 0x001C99D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLayerStatus Status
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

		// Token: 0x0600AA97 RID: 43671 RVA: 0x001CB7DD File Offset: 0x001C99DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicLayerInfo);
		}

		// Token: 0x0600AA98 RID: 43672 RVA: 0x001CB7EC File Offset: 0x001C99EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicLayerInfo other)
		{
			return other != null && (other == this || (this.tournRoomList_.Equals(other.tournRoomList_) && this.LevelIndex == other.LevelIndex && this.LayerId == other.LayerId && this.CurRoomIndex == other.CurRoomIndex && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA99 RID: 43673 RVA: 0x001CB86C File Offset: 0x001C9A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tournRoomList_.GetHashCode();
			if (this.LevelIndex != 0U)
			{
				num ^= this.LevelIndex.GetHashCode();
			}
			if (this.LayerId != 0U)
			{
				num ^= this.LayerId.GetHashCode();
			}
			if (this.CurRoomIndex != 0U)
			{
				num ^= this.CurRoomIndex.GetHashCode();
			}
			if (this.Status != RogueMagicLayerStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA9A RID: 43674 RVA: 0x001CB90A File Offset: 0x001C9B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AA9B RID: 43675 RVA: 0x001CB912 File Offset: 0x001C9B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA9C RID: 43676 RVA: 0x001CB91C File Offset: 0x001C9B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelIndex != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.LevelIndex);
			}
			if (this.CurRoomIndex != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CurRoomIndex);
			}
			if (this.Status != RogueMagicLayerStatus.None)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Status);
			}
			if (this.LayerId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.LayerId);
			}
			this.tournRoomList_.WriteTo(ref output, RogueMagicLayerInfo._repeated_tournRoomList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA9D RID: 43677 RVA: 0x001CB9C0 File Offset: 0x001C9BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tournRoomList_.CalculateSize(RogueMagicLayerInfo._repeated_tournRoomList_codec);
			if (this.LevelIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelIndex);
			}
			if (this.LayerId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LayerId);
			}
			if (this.CurRoomIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurRoomIndex);
			}
			if (this.Status != RogueMagicLayerStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA9E RID: 43678 RVA: 0x001CBA5C File Offset: 0x001C9C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicLayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.tournRoomList_.Add(other.tournRoomList_);
			if (other.LevelIndex != 0U)
			{
				this.LevelIndex = other.LevelIndex;
			}
			if (other.LayerId != 0U)
			{
				this.LayerId = other.LayerId;
			}
			if (other.CurRoomIndex != 0U)
			{
				this.CurRoomIndex = other.CurRoomIndex;
			}
			if (other.Status != RogueMagicLayerStatus.None)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA9F RID: 43679 RVA: 0x001CBAE5 File Offset: 0x001C9CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAA0 RID: 43680 RVA: 0x001CBAF0 File Offset: 0x001C9CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 8U)
					{
						this.LevelIndex = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.CurRoomIndex = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Status = (RogueMagicLayerStatus)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.LayerId = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						this.tournRoomList_.AddEntriesFrom(ref input, RogueMagicLayerInfo._repeated_tournRoomList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004599 RID: 17817
		private static readonly MessageParser<RogueMagicLayerInfo> _parser = new MessageParser<RogueMagicLayerInfo>(() => new RogueMagicLayerInfo());

		// Token: 0x0400459A RID: 17818
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400459B RID: 17819
		public const int TournRoomListFieldNumber = 14;

		// Token: 0x0400459C RID: 17820
		private static readonly FieldCodec<RogueMagicRoomInfo> _repeated_tournRoomList_codec = FieldCodec.ForMessage<RogueMagicRoomInfo>(114U, RogueMagicRoomInfo.Parser);

		// Token: 0x0400459D RID: 17821
		private readonly RepeatedField<RogueMagicRoomInfo> tournRoomList_ = new RepeatedField<RogueMagicRoomInfo>();

		// Token: 0x0400459E RID: 17822
		public const int LevelIndexFieldNumber = 1;

		// Token: 0x0400459F RID: 17823
		private uint levelIndex_;

		// Token: 0x040045A0 RID: 17824
		public const int LayerIdFieldNumber = 13;

		// Token: 0x040045A1 RID: 17825
		private uint layerId_;

		// Token: 0x040045A2 RID: 17826
		public const int CurRoomIndexFieldNumber = 8;

		// Token: 0x040045A3 RID: 17827
		private uint curRoomIndex_;

		// Token: 0x040045A4 RID: 17828
		public const int StatusFieldNumber = 12;

		// Token: 0x040045A5 RID: 17829
		private RogueMagicLayerStatus status_;
	}
}
