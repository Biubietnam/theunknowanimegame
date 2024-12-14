using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001295 RID: 4757
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueMapRoomScNotify : IMessage<SyncRogueMapRoomScNotify>, IMessage, IEquatable<SyncRogueMapRoomScNotify>, IDeepCloneable<SyncRogueMapRoomScNotify>, IBufferMessage
	{
		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x0600D438 RID: 54328 RVA: 0x00236B91 File Offset: 0x00234D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueMapRoomScNotify> Parser
		{
			get
			{
				return SyncRogueMapRoomScNotify._parser;
			}
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x0600D439 RID: 54329 RVA: 0x00236B98 File Offset: 0x00234D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueMapRoomScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0600D43A RID: 54330 RVA: 0x00236BAA File Offset: 0x00234DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueMapRoomScNotify.Descriptor;
			}
		}

		// Token: 0x0600D43B RID: 54331 RVA: 0x00236BB1 File Offset: 0x00234DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueMapRoomScNotify()
		{
		}

		// Token: 0x0600D43C RID: 54332 RVA: 0x00236BBC File Offset: 0x00234DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueMapRoomScNotify(SyncRogueMapRoomScNotify other) : this()
		{
			this.curRoom_ = ((other.curRoom_ != null) ? other.curRoom_.Clone() : null);
			this.mapId_ = other.mapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D43D RID: 54333 RVA: 0x00236C08 File Offset: 0x00234E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueMapRoomScNotify Clone()
		{
			return new SyncRogueMapRoomScNotify(this);
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0600D43E RID: 54334 RVA: 0x00236C10 File Offset: 0x00234E10
		// (set) Token: 0x0600D43F RID: 54335 RVA: 0x00236C18 File Offset: 0x00234E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoom CurRoom
		{
			get
			{
				return this.curRoom_;
			}
			set
			{
				this.curRoom_ = value;
			}
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0600D440 RID: 54336 RVA: 0x00236C21 File Offset: 0x00234E21
		// (set) Token: 0x0600D441 RID: 54337 RVA: 0x00236C29 File Offset: 0x00234E29
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

		// Token: 0x0600D442 RID: 54338 RVA: 0x00236C32 File Offset: 0x00234E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueMapRoomScNotify);
		}

		// Token: 0x0600D443 RID: 54339 RVA: 0x00236C40 File Offset: 0x00234E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueMapRoomScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CurRoom, other.CurRoom) && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D444 RID: 54340 RVA: 0x00236C90 File Offset: 0x00234E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.curRoom_ != null)
			{
				num ^= this.CurRoom.GetHashCode();
			}
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D445 RID: 54341 RVA: 0x00236CE5 File Offset: 0x00234EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D446 RID: 54342 RVA: 0x00236CED File Offset: 0x00234EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D447 RID: 54343 RVA: 0x00236CF8 File Offset: 0x00234EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MapId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MapId);
			}
			if (this.curRoom_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CurRoom);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D448 RID: 54344 RVA: 0x00236D54 File Offset: 0x00234F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.curRoom_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurRoom);
			}
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D449 RID: 54345 RVA: 0x00236DAC File Offset: 0x00234FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueMapRoomScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.curRoom_ != null)
			{
				if (this.curRoom_ == null)
				{
					this.CurRoom = new RogueRoom();
				}
				this.CurRoom.MergeFrom(other.CurRoom);
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D44A RID: 54346 RVA: 0x00236E14 File Offset: 0x00235014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D44B RID: 54347 RVA: 0x00236E20 File Offset: 0x00235020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.curRoom_ == null)
						{
							this.CurRoom = new RogueRoom();
						}
						input.ReadMessage(this.CurRoom);
					}
				}
				else
				{
					this.MapId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040054F0 RID: 21744
		private static readonly MessageParser<SyncRogueMapRoomScNotify> _parser = new MessageParser<SyncRogueMapRoomScNotify>(() => new SyncRogueMapRoomScNotify());

		// Token: 0x040054F1 RID: 21745
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054F2 RID: 21746
		public const int CurRoomFieldNumber = 7;

		// Token: 0x040054F3 RID: 21747
		private RogueRoom curRoom_;

		// Token: 0x040054F4 RID: 21748
		public const int MapIdFieldNumber = 2;

		// Token: 0x040054F5 RID: 21749
		private uint mapId_;
	}
}
