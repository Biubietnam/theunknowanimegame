using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A4F RID: 2639
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyQuitCsReq : IMessage<LobbyQuitCsReq>, IMessage, IEquatable<LobbyQuitCsReq>, IDeepCloneable<LobbyQuitCsReq>, IBufferMessage
	{
		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x06007506 RID: 29958 RVA: 0x00137052 File Offset: 0x00135252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyQuitCsReq> Parser
		{
			get
			{
				return LobbyQuitCsReq._parser;
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x06007507 RID: 29959 RVA: 0x00137059 File Offset: 0x00135259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyQuitCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x06007508 RID: 29960 RVA: 0x0013706B File Offset: 0x0013526B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyQuitCsReq.Descriptor;
			}
		}

		// Token: 0x06007509 RID: 29961 RVA: 0x00137072 File Offset: 0x00135272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQuitCsReq()
		{
		}

		// Token: 0x0600750A RID: 29962 RVA: 0x0013707A File Offset: 0x0013527A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQuitCsReq(LobbyQuitCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x00137093 File Offset: 0x00135293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQuitCsReq Clone()
		{
			return new LobbyQuitCsReq(this);
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x0013709B File Offset: 0x0013529B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyQuitCsReq);
		}

		// Token: 0x0600750D RID: 29965 RVA: 0x001370A9 File Offset: 0x001352A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyQuitCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600750E RID: 29966 RVA: 0x001370C8 File Offset: 0x001352C8
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

		// Token: 0x0600750F RID: 29967 RVA: 0x001370EE File Offset: 0x001352EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x001370F6 File Offset: 0x001352F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007511 RID: 29969 RVA: 0x001370FF File Offset: 0x001352FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x00137118 File Offset: 0x00135318
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

		// Token: 0x06007513 RID: 29971 RVA: 0x0013713E File Offset: 0x0013533E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyQuitCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x0013715B File Offset: 0x0013535B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x00137164 File Offset: 0x00135364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D0C RID: 11532
		private static readonly MessageParser<LobbyQuitCsReq> _parser = new MessageParser<LobbyQuitCsReq>(() => new LobbyQuitCsReq());

		// Token: 0x04002D0D RID: 11533
		private UnknownFieldSet _unknownFields;
	}
}
