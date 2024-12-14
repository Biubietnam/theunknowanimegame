using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000271 RID: 625
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryBpCsReq : IMessage<ChessRogueQueryBpCsReq>, IMessage, IEquatable<ChessRogueQueryBpCsReq>, IDeepCloneable<ChessRogueQueryBpCsReq>, IBufferMessage
	{
		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x0004FF9B File Offset: 0x0004E19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryBpCsReq> Parser
		{
			get
			{
				return ChessRogueQueryBpCsReq._parser;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x0004FFA2 File Offset: 0x0004E1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryBpCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x0004FFB4 File Offset: 0x0004E1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryBpCsReq.Descriptor;
			}
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0004FFBB File Offset: 0x0004E1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryBpCsReq()
		{
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0004FFC3 File Offset: 0x0004E1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryBpCsReq(ChessRogueQueryBpCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0004FFDC File Offset: 0x0004E1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryBpCsReq Clone()
		{
			return new ChessRogueQueryBpCsReq(this);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0004FFE4 File Offset: 0x0004E1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryBpCsReq);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0004FFF2 File Offset: 0x0004E1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryBpCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00050010 File Offset: 0x0004E210
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

		// Token: 0x06001BE6 RID: 7142 RVA: 0x00050036 File Offset: 0x0004E236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0005003E File Offset: 0x0004E23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00050047 File Offset: 0x0004E247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00050060 File Offset: 0x0004E260
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

		// Token: 0x06001BEA RID: 7146 RVA: 0x00050086 File Offset: 0x0004E286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryBpCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x000500A3 File Offset: 0x0004E2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x000500AC File Offset: 0x0004E2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000BAE RID: 2990
		private static readonly MessageParser<ChessRogueQueryBpCsReq> _parser = new MessageParser<ChessRogueQueryBpCsReq>(() => new ChessRogueQueryBpCsReq());

		// Token: 0x04000BAF RID: 2991
		private UnknownFieldSet _unknownFields;
	}
}
