using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000223 RID: 547
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueGiveUpCsReq : IMessage<ChessRogueGiveUpCsReq>, IMessage, IEquatable<ChessRogueGiveUpCsReq>, IDeepCloneable<ChessRogueGiveUpCsReq>, IBufferMessage
	{
		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x00047ECF File Offset: 0x000460CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueGiveUpCsReq> Parser
		{
			get
			{
				return ChessRogueGiveUpCsReq._parser;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x00047ED6 File Offset: 0x000460D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueGiveUpCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00047EE8 File Offset: 0x000460E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueGiveUpCsReq.Descriptor;
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00047EEF File Offset: 0x000460EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpCsReq()
		{
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00047EF7 File Offset: 0x000460F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpCsReq(ChessRogueGiveUpCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00047F10 File Offset: 0x00046110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpCsReq Clone()
		{
			return new ChessRogueGiveUpCsReq(this);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00047F18 File Offset: 0x00046118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueGiveUpCsReq);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00047F26 File Offset: 0x00046126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueGiveUpCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00047F44 File Offset: 0x00046144
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

		// Token: 0x060018A8 RID: 6312 RVA: 0x00047F6A File Offset: 0x0004616A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00047F72 File Offset: 0x00046172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00047F7B File Offset: 0x0004617B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00047F94 File Offset: 0x00046194
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

		// Token: 0x060018AC RID: 6316 RVA: 0x00047FBA File Offset: 0x000461BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueGiveUpCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00047FD7 File Offset: 0x000461D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00047FE0 File Offset: 0x000461E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A8F RID: 2703
		private static readonly MessageParser<ChessRogueGiveUpCsReq> _parser = new MessageParser<ChessRogueGiveUpCsReq>(() => new ChessRogueGiveUpCsReq());

		// Token: 0x04000A90 RID: 2704
		private UnknownFieldSet _unknownFields;
	}
}
