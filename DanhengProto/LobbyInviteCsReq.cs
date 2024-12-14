using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A3B RID: 2619
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyInviteCsReq : IMessage<LobbyInviteCsReq>, IMessage, IEquatable<LobbyInviteCsReq>, IDeepCloneable<LobbyInviteCsReq>, IBufferMessage
	{
		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06007438 RID: 29752 RVA: 0x00135198 File Offset: 0x00133398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyInviteCsReq> Parser
		{
			get
			{
				return LobbyInviteCsReq._parser;
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06007439 RID: 29753 RVA: 0x0013519F File Offset: 0x0013339F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyInviteCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x0600743A RID: 29754 RVA: 0x001351B1 File Offset: 0x001333B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyInviteCsReq.Descriptor;
			}
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x001351B8 File Offset: 0x001333B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyInviteCsReq()
		{
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x001351CB File Offset: 0x001333CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyInviteCsReq(LobbyInviteCsReq other) : this()
		{
			this.uidList_ = other.uidList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x001351F5 File Offset: 0x001333F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyInviteCsReq Clone()
		{
			return new LobbyInviteCsReq(this);
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x0600743E RID: 29758 RVA: 0x001351FD File Offset: 0x001333FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UidList
		{
			get
			{
				return this.uidList_;
			}
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x00135205 File Offset: 0x00133405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyInviteCsReq);
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x00135213 File Offset: 0x00133413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyInviteCsReq other)
		{
			return other != null && (other == this || (this.uidList_.Equals(other.uidList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x00135248 File Offset: 0x00133448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.uidList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x0013527C File Offset: 0x0013347C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x00135284 File Offset: 0x00133484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x0013528D File Offset: 0x0013348D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.uidList_.WriteTo(ref output, LobbyInviteCsReq._repeated_uidList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x001352B4 File Offset: 0x001334B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.uidList_.CalculateSize(LobbyInviteCsReq._repeated_uidList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x001352ED File Offset: 0x001334ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyInviteCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.uidList_.Add(other.uidList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x0013531B File Offset: 0x0013351B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x00135324 File Offset: 0x00133524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.uidList_.AddEntriesFrom(ref input, LobbyInviteCsReq._repeated_uidList_codec);
				}
			}
		}

		// Token: 0x04002CB8 RID: 11448
		private static readonly MessageParser<LobbyInviteCsReq> _parser = new MessageParser<LobbyInviteCsReq>(() => new LobbyInviteCsReq());

		// Token: 0x04002CB9 RID: 11449
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CBA RID: 11450
		public const int UidListFieldNumber = 1;

		// Token: 0x04002CBB RID: 11451
		private static readonly FieldCodec<uint> _repeated_uidList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04002CBC RID: 11452
		private readonly RepeatedField<uint> uidList_ = new RepeatedField<uint>();
	}
}
