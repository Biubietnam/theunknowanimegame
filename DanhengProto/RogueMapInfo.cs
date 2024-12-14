using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F39 RID: 3897
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMapInfo : IMessage<RogueMapInfo>, IMessage, IEquatable<RogueMapInfo>, IDeepCloneable<RogueMapInfo>, IBufferMessage
	{
		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x0600ADD6 RID: 44502 RVA: 0x001D3563 File Offset: 0x001D1763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMapInfo> Parser
		{
			get
			{
				return RogueMapInfo._parser;
			}
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x0600ADD7 RID: 44503 RVA: 0x001D356A File Offset: 0x001D176A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMapInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x0600ADD8 RID: 44504 RVA: 0x001D357C File Offset: 0x001D177C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMapInfo.Descriptor;
			}
		}

		// Token: 0x0600ADD9 RID: 44505 RVA: 0x001D3583 File Offset: 0x001D1783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMapInfo()
		{
		}

		// Token: 0x0600ADDA RID: 44506 RVA: 0x001D3598 File Offset: 0x001D1798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMapInfo(RogueMapInfo other) : this()
		{
			this.curRoomId_ = other.curRoomId_;
			this.curSiteId_ = other.curSiteId_;
			this.mapId_ = other.mapId_;
			this.areaId_ = other.areaId_;
			this.roomList_ = other.roomList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADDB RID: 44507 RVA: 0x001D35FD File Offset: 0x001D17FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMapInfo Clone()
		{
			return new RogueMapInfo(this);
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x0600ADDC RID: 44508 RVA: 0x001D3605 File Offset: 0x001D1805
		// (set) Token: 0x0600ADDD RID: 44509 RVA: 0x001D360D File Offset: 0x001D180D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurRoomId
		{
			get
			{
				return this.curRoomId_;
			}
			set
			{
				this.curRoomId_ = value;
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x0600ADDE RID: 44510 RVA: 0x001D3616 File Offset: 0x001D1816
		// (set) Token: 0x0600ADDF RID: 44511 RVA: 0x001D361E File Offset: 0x001D181E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurSiteId
		{
			get
			{
				return this.curSiteId_;
			}
			set
			{
				this.curSiteId_ = value;
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x0600ADE0 RID: 44512 RVA: 0x001D3627 File Offset: 0x001D1827
		// (set) Token: 0x0600ADE1 RID: 44513 RVA: 0x001D362F File Offset: 0x001D182F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x0600ADE2 RID: 44514 RVA: 0x001D3638 File Offset: 0x001D1838
		// (set) Token: 0x0600ADE3 RID: 44515 RVA: 0x001D3640 File Offset: 0x001D1840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x0600ADE4 RID: 44516 RVA: 0x001D3649 File Offset: 0x001D1849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueRoom> RoomList
		{
			get
			{
				return this.roomList_;
			}
		}

		// Token: 0x0600ADE5 RID: 44517 RVA: 0x001D3651 File Offset: 0x001D1851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMapInfo);
		}

		// Token: 0x0600ADE6 RID: 44518 RVA: 0x001D3660 File Offset: 0x001D1860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMapInfo other)
		{
			return other != null && (other == this || (this.CurRoomId == other.CurRoomId && this.CurSiteId == other.CurSiteId && this.MapId == other.MapId && this.AreaId == other.AreaId && this.roomList_.Equals(other.roomList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADE7 RID: 44519 RVA: 0x001D36E0 File Offset: 0x001D18E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurRoomId != 0U)
			{
				num ^= this.CurRoomId.GetHashCode();
			}
			if (this.CurSiteId != 0U)
			{
				num ^= this.CurSiteId.GetHashCode();
			}
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			num ^= this.roomList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADE8 RID: 44520 RVA: 0x001D3778 File Offset: 0x001D1978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ADE9 RID: 44521 RVA: 0x001D3780 File Offset: 0x001D1980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADEA RID: 44522 RVA: 0x001D378C File Offset: 0x001D198C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurSiteId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CurSiteId);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AreaId);
			}
			if (this.CurRoomId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CurRoomId);
			}
			if (this.MapId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MapId);
			}
			this.roomList_.WriteTo(ref output, RogueMapInfo._repeated_roomList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADEB RID: 44523 RVA: 0x001D3830 File Offset: 0x001D1A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurRoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurRoomId);
			}
			if (this.CurSiteId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurSiteId);
			}
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			num += this.roomList_.CalculateSize(RogueMapInfo._repeated_roomList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADEC RID: 44524 RVA: 0x001D38CC File Offset: 0x001D1ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMapInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurRoomId != 0U)
			{
				this.CurRoomId = other.CurRoomId;
			}
			if (other.CurSiteId != 0U)
			{
				this.CurSiteId = other.CurSiteId;
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this.roomList_.Add(other.roomList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADED RID: 44525 RVA: 0x001D3955 File Offset: 0x001D1B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADEE RID: 44526 RVA: 0x001D3960 File Offset: 0x001D1B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.CurSiteId = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.CurRoomId = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.MapId = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						this.roomList_.AddEntriesFrom(ref input, RogueMapInfo._repeated_roomList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046BC RID: 18108
		private static readonly MessageParser<RogueMapInfo> _parser = new MessageParser<RogueMapInfo>(() => new RogueMapInfo());

		// Token: 0x040046BD RID: 18109
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046BE RID: 18110
		public const int CurRoomIdFieldNumber = 9;

		// Token: 0x040046BF RID: 18111
		private uint curRoomId_;

		// Token: 0x040046C0 RID: 18112
		public const int CurSiteIdFieldNumber = 1;

		// Token: 0x040046C1 RID: 18113
		private uint curSiteId_;

		// Token: 0x040046C2 RID: 18114
		public const int MapIdFieldNumber = 10;

		// Token: 0x040046C3 RID: 18115
		private uint mapId_;

		// Token: 0x040046C4 RID: 18116
		public const int AreaIdFieldNumber = 4;

		// Token: 0x040046C5 RID: 18117
		private uint areaId_;

		// Token: 0x040046C6 RID: 18118
		public const int RoomListFieldNumber = 14;

		// Token: 0x040046C7 RID: 18119
		private static readonly FieldCodec<RogueRoom> _repeated_roomList_codec = FieldCodec.ForMessage<RogueRoom>(114U, RogueRoom.Parser);

		// Token: 0x040046C8 RID: 18120
		private readonly RepeatedField<RogueRoom> roomList_ = new RepeatedField<RogueRoom>();
	}
}
