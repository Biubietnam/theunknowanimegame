using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200001D RID: 29
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptMissionEventCsReq : IMessage<AcceptMissionEventCsReq>, IMessage, IEquatable<AcceptMissionEventCsReq>, IDeepCloneable<AcceptMissionEventCsReq>, IBufferMessage
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000448C File Offset: 0x0000268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptMissionEventCsReq> Parser
		{
			get
			{
				return AcceptMissionEventCsReq._parser;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00004493 File Offset: 0x00002693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptMissionEventCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000044A5 File Offset: 0x000026A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptMissionEventCsReq.Descriptor;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000044AC File Offset: 0x000026AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMissionEventCsReq()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000044B4 File Offset: 0x000026B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMissionEventCsReq(AcceptMissionEventCsReq other) : this()
		{
			this.missionEventId_ = other.missionEventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000044D9 File Offset: 0x000026D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMissionEventCsReq Clone()
		{
			return new AcceptMissionEventCsReq(this);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000044E1 File Offset: 0x000026E1
		// (set) Token: 0x06000104 RID: 260 RVA: 0x000044E9 File Offset: 0x000026E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MissionEventId
		{
			get
			{
				return this.missionEventId_;
			}
			set
			{
				this.missionEventId_ = value;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000044F2 File Offset: 0x000026F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptMissionEventCsReq);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004500 File Offset: 0x00002700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptMissionEventCsReq other)
		{
			return other != null && (other == this || (this.MissionEventId == other.MissionEventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004530 File Offset: 0x00002730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MissionEventId != 0U)
			{
				num ^= this.MissionEventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000456F File Offset: 0x0000276F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004577 File Offset: 0x00002777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004580 File Offset: 0x00002780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MissionEventId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MissionEventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000045B4 File Offset: 0x000027B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MissionEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MissionEventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000045F2 File Offset: 0x000027F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptMissionEventCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MissionEventId != 0U)
			{
				this.MissionEventId = other.MissionEventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004623 File Offset: 0x00002823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000462C File Offset: 0x0000282C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MissionEventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000057 RID: 87
		private static readonly MessageParser<AcceptMissionEventCsReq> _parser = new MessageParser<AcceptMissionEventCsReq>(() => new AcceptMissionEventCsReq());

		// Token: 0x04000058 RID: 88
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000059 RID: 89
		public const int MissionEventIdFieldNumber = 1;

		// Token: 0x0400005A RID: 90
		private uint missionEventId_;
	}
}
