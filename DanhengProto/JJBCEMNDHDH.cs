using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200096D RID: 2413
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JJBCEMNDHDH : IMessage<JJBCEMNDHDH>, IMessage, IEquatable<JJBCEMNDHDH>, IDeepCloneable<JJBCEMNDHDH>, IBufferMessage
	{
		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06006BC6 RID: 27590 RVA: 0x0011F4EA File Offset: 0x0011D6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JJBCEMNDHDH> Parser
		{
			get
			{
				return JJBCEMNDHDH._parser;
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x0011F4F1 File Offset: 0x0011D6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JJBCEMNDHDHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06006BC8 RID: 27592 RVA: 0x0011F503 File Offset: 0x0011D703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JJBCEMNDHDH.Descriptor;
			}
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x0011F50A File Offset: 0x0011D70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJBCEMNDHDH()
		{
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x0011F512 File Offset: 0x0011D712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJBCEMNDHDH(JJBCEMNDHDH other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x0011F52B File Offset: 0x0011D72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJBCEMNDHDH Clone()
		{
			return new JJBCEMNDHDH(this);
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x0011F533 File Offset: 0x0011D733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JJBCEMNDHDH);
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x0011F541 File Offset: 0x0011D741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JJBCEMNDHDH other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x0011F560 File Offset: 0x0011D760
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

		// Token: 0x06006BCF RID: 27599 RVA: 0x0011F586 File Offset: 0x0011D786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x0011F58E File Offset: 0x0011D78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x0011F597 File Offset: 0x0011D797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x0011F5B0 File Offset: 0x0011D7B0
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

		// Token: 0x06006BD3 RID: 27603 RVA: 0x0011F5D6 File Offset: 0x0011D7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JJBCEMNDHDH other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x0011F5F3 File Offset: 0x0011D7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x0011F5FC File Offset: 0x0011D7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002940 RID: 10560
		private static readonly MessageParser<JJBCEMNDHDH> _parser = new MessageParser<JJBCEMNDHDH>(() => new JJBCEMNDHDH());

		// Token: 0x04002941 RID: 10561
		private UnknownFieldSet _unknownFields;
	}
}
