using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200100F RID: 4111
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournRoomList : IMessage<RogueTournRoomList>, IMessage, IEquatable<RogueTournRoomList>, IDeepCloneable<RogueTournRoomList>, IBufferMessage
	{
		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600B6E6 RID: 46822 RVA: 0x001EA9AF File Offset: 0x001E8BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournRoomList> Parser
		{
			get
			{
				return RogueTournRoomList._parser;
			}
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600B6E7 RID: 46823 RVA: 0x001EA9B6 File Offset: 0x001E8BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournRoomListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600B6E8 RID: 46824 RVA: 0x001EA9C8 File Offset: 0x001E8BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournRoomList.Descriptor;
			}
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x001EA9CF File Offset: 0x001E8BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournRoomList()
		{
		}

		// Token: 0x0600B6EA RID: 46826 RVA: 0x001EA9D8 File Offset: 0x001E8BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournRoomList(RogueTournRoomList other) : this()
		{
			this.roomId_ = other.roomId_;
			this.status_ = other.status_;
			this.fGIHHAAHGDA_ = other.fGIHHAAHGDA_;
			this.roomIndex_ = other.roomIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x001EAA2C File Offset: 0x001E8C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournRoomList Clone()
		{
			return new RogueTournRoomList(this);
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600B6EC RID: 46828 RVA: 0x001EAA34 File Offset: 0x001E8C34
		// (set) Token: 0x0600B6ED RID: 46829 RVA: 0x001EAA3C File Offset: 0x001E8C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600B6EE RID: 46830 RVA: 0x001EAA45 File Offset: 0x001E8C45
		// (set) Token: 0x0600B6EF RID: 46831 RVA: 0x001EAA4D File Offset: 0x001E8C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournRoomStatus Status
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

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600B6F0 RID: 46832 RVA: 0x001EAA56 File Offset: 0x001E8C56
		// (set) Token: 0x0600B6F1 RID: 46833 RVA: 0x001EAA5E File Offset: 0x001E8C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FGIHHAAHGDA
		{
			get
			{
				return this.fGIHHAAHGDA_;
			}
			set
			{
				this.fGIHHAAHGDA_ = value;
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600B6F2 RID: 46834 RVA: 0x001EAA67 File Offset: 0x001E8C67
		// (set) Token: 0x0600B6F3 RID: 46835 RVA: 0x001EAA6F File Offset: 0x001E8C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoomIndex
		{
			get
			{
				return this.roomIndex_;
			}
			set
			{
				this.roomIndex_ = value;
			}
		}

		// Token: 0x0600B6F4 RID: 46836 RVA: 0x001EAA78 File Offset: 0x001E8C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournRoomList);
		}

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x001EAA88 File Offset: 0x001E8C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournRoomList other)
		{
			return other != null && (other == this || (this.RoomId == other.RoomId && this.Status == other.Status && this.FGIHHAAHGDA == other.FGIHHAAHGDA && this.RoomIndex == other.RoomIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6F6 RID: 46838 RVA: 0x001EAAF4 File Offset: 0x001E8CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.Status != RogueTournRoomStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.FGIHHAAHGDA != 0U)
			{
				num ^= this.FGIHHAAHGDA.GetHashCode();
			}
			if (this.RoomIndex != 0U)
			{
				num ^= this.RoomIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6F7 RID: 46839 RVA: 0x001EAB84 File Offset: 0x001E8D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B6F8 RID: 46840 RVA: 0x001EAB8C File Offset: 0x001E8D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x001EAB98 File Offset: 0x001E8D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.RoomId);
			}
			if (this.Status != RogueTournRoomStatus.None)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Status);
			}
			if (this.RoomIndex != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.RoomIndex);
			}
			if (this.FGIHHAAHGDA != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.FGIHHAAHGDA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6FA RID: 46842 RVA: 0x001EAC2C File Offset: 0x001E8E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this.Status != RogueTournRoomStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.FGIHHAAHGDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FGIHHAAHGDA);
			}
			if (this.RoomIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x001EACB4 File Offset: 0x001E8EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournRoomList other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			if (other.Status != RogueTournRoomStatus.None)
			{
				this.Status = other.Status;
			}
			if (other.FGIHHAAHGDA != 0U)
			{
				this.FGIHHAAHGDA = other.FGIHHAAHGDA;
			}
			if (other.RoomIndex != 0U)
			{
				this.RoomIndex = other.RoomIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x001EAD2C File Offset: 0x001E8F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x001EAD38 File Offset: 0x001E8F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 40U)
					{
						this.RoomId = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Status = (RogueTournRoomStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.RoomIndex = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.FGIHHAAHGDA = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A10 RID: 18960
		private static readonly MessageParser<RogueTournRoomList> _parser = new MessageParser<RogueTournRoomList>(() => new RogueTournRoomList());

		// Token: 0x04004A11 RID: 18961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A12 RID: 18962
		public const int RoomIdFieldNumber = 5;

		// Token: 0x04004A13 RID: 18963
		private uint roomId_;

		// Token: 0x04004A14 RID: 18964
		public const int StatusFieldNumber = 7;

		// Token: 0x04004A15 RID: 18965
		private RogueTournRoomStatus status_;

		// Token: 0x04004A16 RID: 18966
		public const int FGIHHAAHGDAFieldNumber = 12;

		// Token: 0x04004A17 RID: 18967
		private uint fGIHHAAHGDA_;

		// Token: 0x04004A18 RID: 18968
		public const int RoomIndexFieldNumber = 8;

		// Token: 0x04004A19 RID: 18969
		private uint roomIndex_;
	}
}
