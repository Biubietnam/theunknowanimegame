using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B49 RID: 2889
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGetRegionProgressCsReq : IMessage<MonopolyGetRegionProgressCsReq>, IMessage, IEquatable<MonopolyGetRegionProgressCsReq>, IDeepCloneable<MonopolyGetRegionProgressCsReq>, IBufferMessage
	{
		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x06007FE4 RID: 32740 RVA: 0x00151C8B File Offset: 0x0014FE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGetRegionProgressCsReq> Parser
		{
			get
			{
				return MonopolyGetRegionProgressCsReq._parser;
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x06007FE5 RID: 32741 RVA: 0x00151C92 File Offset: 0x0014FE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGetRegionProgressCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x06007FE6 RID: 32742 RVA: 0x00151CA4 File Offset: 0x0014FEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGetRegionProgressCsReq.Descriptor;
			}
		}

		// Token: 0x06007FE7 RID: 32743 RVA: 0x00151CAB File Offset: 0x0014FEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRegionProgressCsReq()
		{
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x00151CB3 File Offset: 0x0014FEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRegionProgressCsReq(MonopolyGetRegionProgressCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FE9 RID: 32745 RVA: 0x00151CCC File Offset: 0x0014FECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRegionProgressCsReq Clone()
		{
			return new MonopolyGetRegionProgressCsReq(this);
		}

		// Token: 0x06007FEA RID: 32746 RVA: 0x00151CD4 File Offset: 0x0014FED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGetRegionProgressCsReq);
		}

		// Token: 0x06007FEB RID: 32747 RVA: 0x00151CE2 File Offset: 0x0014FEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGetRegionProgressCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007FEC RID: 32748 RVA: 0x00151D00 File Offset: 0x0014FF00
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

		// Token: 0x06007FED RID: 32749 RVA: 0x00151D26 File Offset: 0x0014FF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x00151D2E File Offset: 0x0014FF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x00151D37 File Offset: 0x0014FF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x00151D50 File Offset: 0x0014FF50
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

		// Token: 0x06007FF1 RID: 32753 RVA: 0x00151D76 File Offset: 0x0014FF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGetRegionProgressCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007FF2 RID: 32754 RVA: 0x00151D93 File Offset: 0x0014FF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FF3 RID: 32755 RVA: 0x00151D9C File Offset: 0x0014FF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040030F5 RID: 12533
		private static readonly MessageParser<MonopolyGetRegionProgressCsReq> _parser = new MessageParser<MonopolyGetRegionProgressCsReq>(() => new MonopolyGetRegionProgressCsReq());

		// Token: 0x040030F6 RID: 12534
		private UnknownFieldSet _unknownFields;
	}
}
