using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F6D RID: 3949
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueRoom : IMessage<RogueRoom>, IMessage, IEquatable<RogueRoom>, IDeepCloneable<RogueRoom>, IBufferMessage
	{
		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0600B004 RID: 45060 RVA: 0x001D8CB7 File Offset: 0x001D6EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueRoom> Parser
		{
			get
			{
				return RogueRoom._parser;
			}
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0600B005 RID: 45061 RVA: 0x001D8CBE File Offset: 0x001D6EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueRoomReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600B006 RID: 45062 RVA: 0x001D8CD0 File Offset: 0x001D6ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueRoom.Descriptor;
			}
		}

		// Token: 0x0600B007 RID: 45063 RVA: 0x001D8CD7 File Offset: 0x001D6ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoom()
		{
		}

		// Token: 0x0600B008 RID: 45064 RVA: 0x001D8CE0 File Offset: 0x001D6EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoom(RogueRoom other) : this()
		{
			this.eHDFJGODBBD_ = other.eHDFJGODBBD_;
			this.fHHHADKHHEF_ = other.fHHHADKHHEF_;
			this.curStatus_ = other.curStatus_;
			this.siteId_ = other.siteId_;
			this.roomId_ = other.roomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B009 RID: 45065 RVA: 0x001D8D40 File Offset: 0x001D6F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoom Clone()
		{
			return new RogueRoom(this);
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600B00A RID: 45066 RVA: 0x001D8D48 File Offset: 0x001D6F48
		// (set) Token: 0x0600B00B RID: 45067 RVA: 0x001D8D50 File Offset: 0x001D6F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EHDFJGODBBD
		{
			get
			{
				return this.eHDFJGODBBD_;
			}
			set
			{
				this.eHDFJGODBBD_ = value;
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600B00C RID: 45068 RVA: 0x001D8D59 File Offset: 0x001D6F59
		// (set) Token: 0x0600B00D RID: 45069 RVA: 0x001D8D61 File Offset: 0x001D6F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoomStatus FHHHADKHHEF
		{
			get
			{
				return this.fHHHADKHHEF_;
			}
			set
			{
				this.fHHHADKHHEF_ = value;
			}
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600B00E RID: 45070 RVA: 0x001D8D6A File Offset: 0x001D6F6A
		// (set) Token: 0x0600B00F RID: 45071 RVA: 0x001D8D72 File Offset: 0x001D6F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoomStatus CurStatus
		{
			get
			{
				return this.curStatus_;
			}
			set
			{
				this.curStatus_ = value;
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600B010 RID: 45072 RVA: 0x001D8D7B File Offset: 0x001D6F7B
		// (set) Token: 0x0600B011 RID: 45073 RVA: 0x001D8D83 File Offset: 0x001D6F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SiteId
		{
			get
			{
				return this.siteId_;
			}
			set
			{
				this.siteId_ = value;
			}
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600B012 RID: 45074 RVA: 0x001D8D8C File Offset: 0x001D6F8C
		// (set) Token: 0x0600B013 RID: 45075 RVA: 0x001D8D94 File Offset: 0x001D6F94
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

		// Token: 0x0600B014 RID: 45076 RVA: 0x001D8D9D File Offset: 0x001D6F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueRoom);
		}

		// Token: 0x0600B015 RID: 45077 RVA: 0x001D8DAC File Offset: 0x001D6FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueRoom other)
		{
			return other != null && (other == this || (this.EHDFJGODBBD == other.EHDFJGODBBD && this.FHHHADKHHEF == other.FHHHADKHHEF && this.CurStatus == other.CurStatus && this.SiteId == other.SiteId && this.RoomId == other.RoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B016 RID: 45078 RVA: 0x001D8E28 File Offset: 0x001D7028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EHDFJGODBBD != 0U)
			{
				num ^= this.EHDFJGODBBD.GetHashCode();
			}
			if (this.FHHHADKHHEF != RogueRoomStatus.None)
			{
				num ^= this.FHHHADKHHEF.GetHashCode();
			}
			if (this.CurStatus != RogueRoomStatus.None)
			{
				num ^= this.CurStatus.GetHashCode();
			}
			if (this.SiteId != 0U)
			{
				num ^= this.SiteId.GetHashCode();
			}
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B017 RID: 45079 RVA: 0x001D8ED7 File Offset: 0x001D70D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B018 RID: 45080 RVA: 0x001D8EDF File Offset: 0x001D70DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B019 RID: 45081 RVA: 0x001D8EE8 File Offset: 0x001D70E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.RoomId);
			}
			if (this.SiteId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.SiteId);
			}
			if (this.CurStatus != RogueRoomStatus.None)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.CurStatus);
			}
			if (this.EHDFJGODBBD != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EHDFJGODBBD);
			}
			if (this.FHHHADKHHEF != RogueRoomStatus.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.FHHHADKHHEF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B01A RID: 45082 RVA: 0x001D8F98 File Offset: 0x001D7198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EHDFJGODBBD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EHDFJGODBBD);
			}
			if (this.FHHHADKHHEF != RogueRoomStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FHHHADKHHEF);
			}
			if (this.CurStatus != RogueRoomStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CurStatus);
			}
			if (this.SiteId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SiteId);
			}
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B01B RID: 45083 RVA: 0x001D9038 File Offset: 0x001D7238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueRoom other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EHDFJGODBBD != 0U)
			{
				this.EHDFJGODBBD = other.EHDFJGODBBD;
			}
			if (other.FHHHADKHHEF != RogueRoomStatus.None)
			{
				this.FHHHADKHHEF = other.FHHHADKHHEF;
			}
			if (other.CurStatus != RogueRoomStatus.None)
			{
				this.CurStatus = other.CurStatus;
			}
			if (other.SiteId != 0U)
			{
				this.SiteId = other.SiteId;
			}
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x001D90C4 File Offset: 0x001D72C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B01D RID: 45085 RVA: 0x001D90D0 File Offset: 0x001D72D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 24U)
					{
						this.RoomId = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.SiteId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.CurStatus = (RogueRoomStatus)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.EHDFJGODBBD = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.FHHHADKHHEF = (RogueRoomStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400478E RID: 18318
		private static readonly MessageParser<RogueRoom> _parser = new MessageParser<RogueRoom>(() => new RogueRoom());

		// Token: 0x0400478F RID: 18319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004790 RID: 18320
		public const int EHDFJGODBBDFieldNumber = 14;

		// Token: 0x04004791 RID: 18321
		private uint eHDFJGODBBD_;

		// Token: 0x04004792 RID: 18322
		public const int FHHHADKHHEFFieldNumber = 15;

		// Token: 0x04004793 RID: 18323
		private RogueRoomStatus fHHHADKHHEF_;

		// Token: 0x04004794 RID: 18324
		public const int CurStatusFieldNumber = 12;

		// Token: 0x04004795 RID: 18325
		private RogueRoomStatus curStatus_;

		// Token: 0x04004796 RID: 18326
		public const int SiteIdFieldNumber = 8;

		// Token: 0x04004797 RID: 18327
		private uint siteId_;

		// Token: 0x04004798 RID: 18328
		public const int RoomIdFieldNumber = 3;

		// Token: 0x04004799 RID: 18329
		private uint roomId_;
	}
}
