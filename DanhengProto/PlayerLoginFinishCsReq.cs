using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CC5 RID: 3269
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerLoginFinishCsReq : IMessage<PlayerLoginFinishCsReq>, IMessage, IEquatable<PlayerLoginFinishCsReq>, IDeepCloneable<PlayerLoginFinishCsReq>, IBufferMessage
	{
		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x060091C0 RID: 37312 RVA: 0x00182977 File Offset: 0x00180B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerLoginFinishCsReq> Parser
		{
			get
			{
				return PlayerLoginFinishCsReq._parser;
			}
		}

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x060091C1 RID: 37313 RVA: 0x0018297E File Offset: 0x00180B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerLoginFinishCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x060091C2 RID: 37314 RVA: 0x00182990 File Offset: 0x00180B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLoginFinishCsReq.Descriptor;
			}
		}

		// Token: 0x060091C3 RID: 37315 RVA: 0x00182997 File Offset: 0x00180B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginFinishCsReq()
		{
		}

		// Token: 0x060091C4 RID: 37316 RVA: 0x0018299F File Offset: 0x00180B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginFinishCsReq(PlayerLoginFinishCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091C5 RID: 37317 RVA: 0x001829B8 File Offset: 0x00180BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginFinishCsReq Clone()
		{
			return new PlayerLoginFinishCsReq(this);
		}

		// Token: 0x060091C6 RID: 37318 RVA: 0x001829C0 File Offset: 0x00180BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLoginFinishCsReq);
		}

		// Token: 0x060091C7 RID: 37319 RVA: 0x001829CE File Offset: 0x00180BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLoginFinishCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060091C8 RID: 37320 RVA: 0x001829EC File Offset: 0x00180BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060091C9 RID: 37321 RVA: 0x00182A12 File Offset: 0x00180C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060091CA RID: 37322 RVA: 0x00182A1A File Offset: 0x00180C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091CB RID: 37323 RVA: 0x00182A23 File Offset: 0x00180C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091CC RID: 37324 RVA: 0x00182A3C File Offset: 0x00180C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060091CD RID: 37325 RVA: 0x00182A62 File Offset: 0x00180C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerLoginFinishCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060091CE RID: 37326 RVA: 0x00182A7F File Offset: 0x00180C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091CF RID: 37327 RVA: 0x00182A88 File Offset: 0x00180C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003840 RID: 14400
		private static readonly MessageParser<PlayerLoginFinishCsReq> _parser = new MessageParser<PlayerLoginFinishCsReq>(() => new PlayerLoginFinishCsReq());

		// Token: 0x04003841 RID: 14401
		private UnknownFieldSet _unknownFields;
	}
}
