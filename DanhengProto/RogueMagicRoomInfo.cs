using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EFD RID: 3837
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicRoomInfo : IMessage<RogueMagicRoomInfo>, IMessage, IEquatable<RogueMagicRoomInfo>, IDeepCloneable<RogueMagicRoomInfo>, IBufferMessage
	{
		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x001CD967 File Offset: 0x001CBB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicRoomInfo> Parser
		{
			get
			{
				return RogueMagicRoomInfo._parser;
			}
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x0600AB5F RID: 43871 RVA: 0x001CD96E File Offset: 0x001CBB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicRoomInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x0600AB60 RID: 43872 RVA: 0x001CD980 File Offset: 0x001CBB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicRoomInfo.Descriptor;
			}
		}

		// Token: 0x0600AB61 RID: 43873 RVA: 0x001CD987 File Offset: 0x001CBB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicRoomInfo()
		{
		}

		// Token: 0x0600AB62 RID: 43874 RVA: 0x001CD990 File Offset: 0x001CBB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicRoomInfo(RogueMagicRoomInfo other) : this()
		{
			this.roomId_ = other.roomId_;
			this.status_ = other.status_;
			this.fGIHHAAHGDA_ = other.fGIHHAAHGDA_;
			this.roomIndex_ = other.roomIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB63 RID: 43875 RVA: 0x001CD9E4 File Offset: 0x001CBBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicRoomInfo Clone()
		{
			return new RogueMagicRoomInfo(this);
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x0600AB64 RID: 43876 RVA: 0x001CD9EC File Offset: 0x001CBBEC
		// (set) Token: 0x0600AB65 RID: 43877 RVA: 0x001CD9F4 File Offset: 0x001CBBF4
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

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x0600AB66 RID: 43878 RVA: 0x001CD9FD File Offset: 0x001CBBFD
		// (set) Token: 0x0600AB67 RID: 43879 RVA: 0x001CDA05 File Offset: 0x001CBC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicRoomStatus Status
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

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x0600AB68 RID: 43880 RVA: 0x001CDA0E File Offset: 0x001CBC0E
		// (set) Token: 0x0600AB69 RID: 43881 RVA: 0x001CDA16 File Offset: 0x001CBC16
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

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x0600AB6A RID: 43882 RVA: 0x001CDA1F File Offset: 0x001CBC1F
		// (set) Token: 0x0600AB6B RID: 43883 RVA: 0x001CDA27 File Offset: 0x001CBC27
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

		// Token: 0x0600AB6C RID: 43884 RVA: 0x001CDA30 File Offset: 0x001CBC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicRoomInfo);
		}

		// Token: 0x0600AB6D RID: 43885 RVA: 0x001CDA40 File Offset: 0x001CBC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicRoomInfo other)
		{
			return other != null && (other == this || (this.RoomId == other.RoomId && this.Status == other.Status && this.FGIHHAAHGDA == other.FGIHHAAHGDA && this.RoomIndex == other.RoomIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB6E RID: 43886 RVA: 0x001CDAAC File Offset: 0x001CBCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.Status != RogueMagicRoomStatus.None)
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

		// Token: 0x0600AB6F RID: 43887 RVA: 0x001CDB3C File Offset: 0x001CBD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB70 RID: 43888 RVA: 0x001CDB44 File Offset: 0x001CBD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB71 RID: 43889 RVA: 0x001CDB50 File Offset: 0x001CBD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FGIHHAAHGDA != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.FGIHHAAHGDA);
			}
			if (this.Status != RogueMagicRoomStatus.None)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Status);
			}
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.RoomId);
			}
			if (this.RoomIndex != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.RoomIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB72 RID: 43890 RVA: 0x001CDBE0 File Offset: 0x001CBDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this.Status != RogueMagicRoomStatus.None)
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

		// Token: 0x0600AB73 RID: 43891 RVA: 0x001CDC68 File Offset: 0x001CBE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicRoomInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			if (other.Status != RogueMagicRoomStatus.None)
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

		// Token: 0x0600AB74 RID: 43892 RVA: 0x001CDCE0 File Offset: 0x001CBEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB75 RID: 43893 RVA: 0x001CDCEC File Offset: 0x001CBEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 8U)
					{
						this.FGIHHAAHGDA = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Status = (RogueMagicRoomStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.RoomId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.RoomIndex = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045EC RID: 17900
		private static readonly MessageParser<RogueMagicRoomInfo> _parser = new MessageParser<RogueMagicRoomInfo>(() => new RogueMagicRoomInfo());

		// Token: 0x040045ED RID: 17901
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045EE RID: 17902
		public const int RoomIdFieldNumber = 11;

		// Token: 0x040045EF RID: 17903
		private uint roomId_;

		// Token: 0x040045F0 RID: 17904
		public const int StatusFieldNumber = 10;

		// Token: 0x040045F1 RID: 17905
		private RogueMagicRoomStatus status_;

		// Token: 0x040045F2 RID: 17906
		public const int FGIHHAAHGDAFieldNumber = 1;

		// Token: 0x040045F3 RID: 17907
		private uint fGIHHAAHGDA_;

		// Token: 0x040045F4 RID: 17908
		public const int RoomIndexFieldNumber = 15;

		// Token: 0x040045F5 RID: 17909
		private uint roomIndex_;
	}
}
