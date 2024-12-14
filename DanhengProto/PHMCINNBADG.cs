using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C95 RID: 3221
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PHMCINNBADG : IMessage<PHMCINNBADG>, IMessage, IEquatable<PHMCINNBADG>, IDeepCloneable<PHMCINNBADG>, IBufferMessage
	{
		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x06008F3E RID: 36670 RVA: 0x0017AA4A File Offset: 0x00178C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PHMCINNBADG> Parser
		{
			get
			{
				return PHMCINNBADG._parser;
			}
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x06008F3F RID: 36671 RVA: 0x0017AA51 File Offset: 0x00178C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PHMCINNBADGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x06008F40 RID: 36672 RVA: 0x0017AA63 File Offset: 0x00178C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PHMCINNBADG.Descriptor;
			}
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x0017AA6A File Offset: 0x00178C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PHMCINNBADG()
		{
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x0017AA72 File Offset: 0x00178C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PHMCINNBADG(PHMCINNBADG other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x0017AA8B File Offset: 0x00178C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PHMCINNBADG Clone()
		{
			return new PHMCINNBADG(this);
		}

		// Token: 0x06008F44 RID: 36676 RVA: 0x0017AA93 File Offset: 0x00178C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PHMCINNBADG);
		}

		// Token: 0x06008F45 RID: 36677 RVA: 0x0017AAA1 File Offset: 0x00178CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PHMCINNBADG other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008F46 RID: 36678 RVA: 0x0017AAC0 File Offset: 0x00178CC0
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

		// Token: 0x06008F47 RID: 36679 RVA: 0x0017AAE6 File Offset: 0x00178CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F48 RID: 36680 RVA: 0x0017AAEE File Offset: 0x00178CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F49 RID: 36681 RVA: 0x0017AAF7 File Offset: 0x00178CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F4A RID: 36682 RVA: 0x0017AB10 File Offset: 0x00178D10
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

		// Token: 0x06008F4B RID: 36683 RVA: 0x0017AB36 File Offset: 0x00178D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PHMCINNBADG other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F4C RID: 36684 RVA: 0x0017AB53 File Offset: 0x00178D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F4D RID: 36685 RVA: 0x0017AB5C File Offset: 0x00178D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003708 RID: 14088
		private static readonly MessageParser<PHMCINNBADG> _parser = new MessageParser<PHMCINNBADG>(() => new PHMCINNBADG());

		// Token: 0x04003709 RID: 14089
		private UnknownFieldSet _unknownFields;
	}
}
