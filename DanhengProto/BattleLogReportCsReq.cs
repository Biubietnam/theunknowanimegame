using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000E9 RID: 233
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleLogReportCsReq : IMessage<BattleLogReportCsReq>, IMessage, IEquatable<BattleLogReportCsReq>, IDeepCloneable<BattleLogReportCsReq>, IBufferMessage
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0001E8FF File Offset: 0x0001CAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleLogReportCsReq> Parser
		{
			get
			{
				return BattleLogReportCsReq._parser;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0001E906 File Offset: 0x0001CB06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleLogReportCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0001E918 File Offset: 0x0001CB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleLogReportCsReq.Descriptor;
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0001E91F File Offset: 0x0001CB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogReportCsReq()
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0001E927 File Offset: 0x0001CB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogReportCsReq(BattleLogReportCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0001E940 File Offset: 0x0001CB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogReportCsReq Clone()
		{
			return new BattleLogReportCsReq(this);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0001E948 File Offset: 0x0001CB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleLogReportCsReq);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0001E956 File Offset: 0x0001CB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleLogReportCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0001E974 File Offset: 0x0001CB74
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

		// Token: 0x06000A5B RID: 2651 RVA: 0x0001E99A File Offset: 0x0001CB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0001E9A2 File Offset: 0x0001CBA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0001E9AB File Offset: 0x0001CBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0001E9C4 File Offset: 0x0001CBC4
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

		// Token: 0x06000A5F RID: 2655 RVA: 0x0001E9EA File Offset: 0x0001CBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleLogReportCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0001EA07 File Offset: 0x0001CC07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0001EA10 File Offset: 0x0001CC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000450 RID: 1104
		private static readonly MessageParser<BattleLogReportCsReq> _parser = new MessageParser<BattleLogReportCsReq>(() => new BattleLogReportCsReq());

		// Token: 0x04000451 RID: 1105
		private UnknownFieldSet _unknownFields;
	}
}
