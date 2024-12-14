using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A61 RID: 2657
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LogisticsDetonateStarSkiffCsReq : IMessage<LogisticsDetonateStarSkiffCsReq>, IMessage, IEquatable<LogisticsDetonateStarSkiffCsReq>, IDeepCloneable<LogisticsDetonateStarSkiffCsReq>, IBufferMessage
	{
		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x060075CD RID: 30157 RVA: 0x00138C43 File Offset: 0x00136E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogisticsDetonateStarSkiffCsReq> Parser
		{
			get
			{
				return LogisticsDetonateStarSkiffCsReq._parser;
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x060075CE RID: 30158 RVA: 0x00138C4A File Offset: 0x00136E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LogisticsDetonateStarSkiffCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x060075CF RID: 30159 RVA: 0x00138C5C File Offset: 0x00136E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogisticsDetonateStarSkiffCsReq.Descriptor;
			}
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00138C63 File Offset: 0x00136E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsDetonateStarSkiffCsReq()
		{
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x00138C6B File Offset: 0x00136E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsDetonateStarSkiffCsReq(LogisticsDetonateStarSkiffCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00138C84 File Offset: 0x00136E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsDetonateStarSkiffCsReq Clone()
		{
			return new LogisticsDetonateStarSkiffCsReq(this);
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x00138C8C File Offset: 0x00136E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogisticsDetonateStarSkiffCsReq);
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x00138C9A File Offset: 0x00136E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogisticsDetonateStarSkiffCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00138CB8 File Offset: 0x00136EB8
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

		// Token: 0x060075D6 RID: 30166 RVA: 0x00138CDE File Offset: 0x00136EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x00138CE6 File Offset: 0x00136EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x00138CEF File Offset: 0x00136EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x00138D08 File Offset: 0x00136F08
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

		// Token: 0x060075DA RID: 30170 RVA: 0x00138D2E File Offset: 0x00136F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogisticsDetonateStarSkiffCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x00138D4B File Offset: 0x00136F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x00138D54 File Offset: 0x00136F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D4B RID: 11595
		private static readonly MessageParser<LogisticsDetonateStarSkiffCsReq> _parser = new MessageParser<LogisticsDetonateStarSkiffCsReq>(() => new LogisticsDetonateStarSkiffCsReq());

		// Token: 0x04002D4C RID: 11596
		private UnknownFieldSet _unknownFields;
	}
}
