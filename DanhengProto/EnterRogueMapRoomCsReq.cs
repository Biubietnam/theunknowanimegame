using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000459 RID: 1113
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterRogueMapRoomCsReq : IMessage<EnterRogueMapRoomCsReq>, IMessage, IEquatable<EnterRogueMapRoomCsReq>, IDeepCloneable<EnterRogueMapRoomCsReq>, IBufferMessage
	{
		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x00088328 File Offset: 0x00086528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterRogueMapRoomCsReq> Parser
		{
			get
			{
				return EnterRogueMapRoomCsReq._parser;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x0008832F File Offset: 0x0008652F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterRogueMapRoomCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x00088341 File Offset: 0x00086541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterRogueMapRoomCsReq.Descriptor;
			}
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x00088348 File Offset: 0x00086548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueMapRoomCsReq()
		{
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x00088350 File Offset: 0x00086550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueMapRoomCsReq(EnterRogueMapRoomCsReq other) : this()
		{
			this.roomId_ = other.roomId_;
			this.siteId_ = other.siteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x00088381 File Offset: 0x00086581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueMapRoomCsReq Clone()
		{
			return new EnterRogueMapRoomCsReq(this);
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x00088389 File Offset: 0x00086589
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x00088391 File Offset: 0x00086591
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

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x0008839A File Offset: 0x0008659A
		// (set) Token: 0x06003192 RID: 12690 RVA: 0x000883A2 File Offset: 0x000865A2
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

		// Token: 0x06003193 RID: 12691 RVA: 0x000883AB File Offset: 0x000865AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterRogueMapRoomCsReq);
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x000883B9 File Offset: 0x000865B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterRogueMapRoomCsReq other)
		{
			return other != null && (other == this || (this.RoomId == other.RoomId && this.SiteId == other.SiteId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x000883F8 File Offset: 0x000865F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.SiteId != 0U)
			{
				num ^= this.SiteId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x00088450 File Offset: 0x00086650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x00088458 File Offset: 0x00086658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x00088464 File Offset: 0x00086664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.RoomId);
			}
			if (this.SiteId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.SiteId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x000884C0 File Offset: 0x000866C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this.SiteId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SiteId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x00088518 File Offset: 0x00086718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterRogueMapRoomCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			if (other.SiteId != 0U)
			{
				this.SiteId = other.SiteId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x00088568 File Offset: 0x00086768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x00088574 File Offset: 0x00086774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SiteId = input.ReadUInt32();
					}
				}
				else
				{
					this.RoomId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040013B8 RID: 5048
		private static readonly MessageParser<EnterRogueMapRoomCsReq> _parser = new MessageParser<EnterRogueMapRoomCsReq>(() => new EnterRogueMapRoomCsReq());

		// Token: 0x040013B9 RID: 5049
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013BA RID: 5050
		public const int RoomIdFieldNumber = 10;

		// Token: 0x040013BB RID: 5051
		private uint roomId_;

		// Token: 0x040013BC RID: 5052
		public const int SiteIdFieldNumber = 13;

		// Token: 0x040013BD RID: 5053
		private uint siteId_;
	}
}
