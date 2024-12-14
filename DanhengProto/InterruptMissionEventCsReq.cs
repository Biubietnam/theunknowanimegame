using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200093F RID: 2367
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InterruptMissionEventCsReq : IMessage<InterruptMissionEventCsReq>, IMessage, IEquatable<InterruptMissionEventCsReq>, IDeepCloneable<InterruptMissionEventCsReq>, IBufferMessage
	{
		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x060069A0 RID: 27040 RVA: 0x00119EEC File Offset: 0x001180EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InterruptMissionEventCsReq> Parser
		{
			get
			{
				return InterruptMissionEventCsReq._parser;
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x060069A1 RID: 27041 RVA: 0x00119EF3 File Offset: 0x001180F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InterruptMissionEventCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x060069A2 RID: 27042 RVA: 0x00119F05 File Offset: 0x00118105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InterruptMissionEventCsReq.Descriptor;
			}
		}

		// Token: 0x060069A3 RID: 27043 RVA: 0x00119F0C File Offset: 0x0011810C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptMissionEventCsReq()
		{
		}

		// Token: 0x060069A4 RID: 27044 RVA: 0x00119F14 File Offset: 0x00118114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptMissionEventCsReq(InterruptMissionEventCsReq other) : this()
		{
			this.missionEventId_ = other.missionEventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069A5 RID: 27045 RVA: 0x00119F39 File Offset: 0x00118139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptMissionEventCsReq Clone()
		{
			return new InterruptMissionEventCsReq(this);
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x060069A6 RID: 27046 RVA: 0x00119F41 File Offset: 0x00118141
		// (set) Token: 0x060069A7 RID: 27047 RVA: 0x00119F49 File Offset: 0x00118149
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

		// Token: 0x060069A8 RID: 27048 RVA: 0x00119F52 File Offset: 0x00118152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InterruptMissionEventCsReq);
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x00119F60 File Offset: 0x00118160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InterruptMissionEventCsReq other)
		{
			return other != null && (other == this || (this.MissionEventId == other.MissionEventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x00119F90 File Offset: 0x00118190
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

		// Token: 0x060069AB RID: 27051 RVA: 0x00119FCF File Offset: 0x001181CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x00119FD7 File Offset: 0x001181D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x00119FE0 File Offset: 0x001181E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MissionEventId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MissionEventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x0011A014 File Offset: 0x00118214
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

		// Token: 0x060069AF RID: 27055 RVA: 0x0011A052 File Offset: 0x00118252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InterruptMissionEventCsReq other)
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

		// Token: 0x060069B0 RID: 27056 RVA: 0x0011A083 File Offset: 0x00118283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x0011A08C File Offset: 0x0011828C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MissionEventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002878 RID: 10360
		private static readonly MessageParser<InterruptMissionEventCsReq> _parser = new MessageParser<InterruptMissionEventCsReq>(() => new InterruptMissionEventCsReq());

		// Token: 0x04002879 RID: 10361
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400287A RID: 10362
		public const int MissionEventIdFieldNumber = 2;

		// Token: 0x0400287B RID: 10363
		private uint missionEventId_;
	}
}
