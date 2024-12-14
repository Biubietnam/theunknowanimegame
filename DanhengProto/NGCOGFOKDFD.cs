using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C13 RID: 3091
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NGCOGFOKDFD : IMessage<NGCOGFOKDFD>, IMessage, IEquatable<NGCOGFOKDFD>, IDeepCloneable<NGCOGFOKDFD>, IBufferMessage
	{
		// Token: 0x17002665 RID: 9829
		// (get) Token: 0x060088DE RID: 35038 RVA: 0x00169602 File Offset: 0x00167802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NGCOGFOKDFD> Parser
		{
			get
			{
				return NGCOGFOKDFD._parser;
			}
		}

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x060088DF RID: 35039 RVA: 0x00169609 File Offset: 0x00167809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NGCOGFOKDFDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x060088E0 RID: 35040 RVA: 0x0016961B File Offset: 0x0016781B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NGCOGFOKDFD.Descriptor;
			}
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x00169622 File Offset: 0x00167822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGCOGFOKDFD()
		{
		}

		// Token: 0x060088E2 RID: 35042 RVA: 0x0016962A File Offset: 0x0016782A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGCOGFOKDFD(NGCOGFOKDFD other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x00169643 File Offset: 0x00167843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGCOGFOKDFD Clone()
		{
			return new NGCOGFOKDFD(this);
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x0016964B File Offset: 0x0016784B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NGCOGFOKDFD);
		}

		// Token: 0x060088E5 RID: 35045 RVA: 0x00169659 File Offset: 0x00167859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NGCOGFOKDFD other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x00169678 File Offset: 0x00167878
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

		// Token: 0x060088E7 RID: 35047 RVA: 0x0016969E File Offset: 0x0016789E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060088E8 RID: 35048 RVA: 0x001696A6 File Offset: 0x001678A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088E9 RID: 35049 RVA: 0x001696AF File Offset: 0x001678AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x001696C8 File Offset: 0x001678C8
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

		// Token: 0x060088EB RID: 35051 RVA: 0x001696EE File Offset: 0x001678EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NGCOGFOKDFD other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060088EC RID: 35052 RVA: 0x0016970B File Offset: 0x0016790B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088ED RID: 35053 RVA: 0x00169714 File Offset: 0x00167914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003476 RID: 13430
		private static readonly MessageParser<NGCOGFOKDFD> _parser = new MessageParser<NGCOGFOKDFD>(() => new NGCOGFOKDFD());

		// Token: 0x04003477 RID: 13431
		private UnknownFieldSet _unknownFields;
	}
}
