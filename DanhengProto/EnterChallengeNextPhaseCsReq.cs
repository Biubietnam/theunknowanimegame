using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000437 RID: 1079
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterChallengeNextPhaseCsReq : IMessage<EnterChallengeNextPhaseCsReq>, IMessage, IEquatable<EnterChallengeNextPhaseCsReq>, IDeepCloneable<EnterChallengeNextPhaseCsReq>, IBufferMessage
	{
		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x00083E87 File Offset: 0x00082087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterChallengeNextPhaseCsReq> Parser
		{
			get
			{
				return EnterChallengeNextPhaseCsReq._parser;
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x00083E8E File Offset: 0x0008208E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterChallengeNextPhaseCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x00083EA0 File Offset: 0x000820A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterChallengeNextPhaseCsReq.Descriptor;
			}
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x00083EA7 File Offset: 0x000820A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChallengeNextPhaseCsReq()
		{
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x00083EAF File Offset: 0x000820AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChallengeNextPhaseCsReq(EnterChallengeNextPhaseCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x00083EC8 File Offset: 0x000820C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChallengeNextPhaseCsReq Clone()
		{
			return new EnterChallengeNextPhaseCsReq(this);
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x00083ED0 File Offset: 0x000820D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterChallengeNextPhaseCsReq);
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x00083EDE File Offset: 0x000820DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterChallengeNextPhaseCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x00083EFC File Offset: 0x000820FC
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

		// Token: 0x06002FF9 RID: 12281 RVA: 0x00083F22 File Offset: 0x00082122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x00083F2A File Offset: 0x0008212A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x00083F33 File Offset: 0x00082133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x00083F4C File Offset: 0x0008214C
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

		// Token: 0x06002FFD RID: 12285 RVA: 0x00083F72 File Offset: 0x00082172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterChallengeNextPhaseCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00083F8F File Offset: 0x0008218F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00083F98 File Offset: 0x00082198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400131F RID: 4895
		private static readonly MessageParser<EnterChallengeNextPhaseCsReq> _parser = new MessageParser<EnterChallengeNextPhaseCsReq>(() => new EnterChallengeNextPhaseCsReq());

		// Token: 0x04001320 RID: 4896
		private UnknownFieldSet _unknownFields;
	}
}
