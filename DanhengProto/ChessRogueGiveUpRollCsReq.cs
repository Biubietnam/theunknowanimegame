using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000225 RID: 549
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueGiveUpRollCsReq : IMessage<ChessRogueGiveUpRollCsReq>, IMessage, IEquatable<ChessRogueGiveUpRollCsReq>, IDeepCloneable<ChessRogueGiveUpRollCsReq>, IBufferMessage
	{
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x00048083 File Offset: 0x00046283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueGiveUpRollCsReq> Parser
		{
			get
			{
				return ChessRogueGiveUpRollCsReq._parser;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x0004808A File Offset: 0x0004628A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueGiveUpRollCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x0004809C File Offset: 0x0004629C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueGiveUpRollCsReq.Descriptor;
			}
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x000480A3 File Offset: 0x000462A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpRollCsReq()
		{
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000480AB File Offset: 0x000462AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpRollCsReq(ChessRogueGiveUpRollCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000480C4 File Offset: 0x000462C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpRollCsReq Clone()
		{
			return new ChessRogueGiveUpRollCsReq(this);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000480CC File Offset: 0x000462CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueGiveUpRollCsReq);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x000480DA File Offset: 0x000462DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueGiveUpRollCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000480F8 File Offset: 0x000462F8
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

		// Token: 0x060018BB RID: 6331 RVA: 0x0004811E File Offset: 0x0004631E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00048126 File Offset: 0x00046326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0004812F File Offset: 0x0004632F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00048148 File Offset: 0x00046348
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

		// Token: 0x060018BF RID: 6335 RVA: 0x0004816E File Offset: 0x0004636E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueGiveUpRollCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0004818B File Offset: 0x0004638B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00048194 File Offset: 0x00046394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A92 RID: 2706
		private static readonly MessageParser<ChessRogueGiveUpRollCsReq> _parser = new MessageParser<ChessRogueGiveUpRollCsReq>(() => new ChessRogueGiveUpRollCsReq());

		// Token: 0x04000A93 RID: 2707
		private UnknownFieldSet _unknownFields;
	}
}
