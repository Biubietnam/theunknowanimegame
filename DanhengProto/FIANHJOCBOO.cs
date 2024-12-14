using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000521 RID: 1313
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FIANHJOCBOO : IMessage<FIANHJOCBOO>, IMessage, IEquatable<FIANHJOCBOO>, IDeepCloneable<FIANHJOCBOO>, IBufferMessage
	{
		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x000A1692 File Offset: 0x0009F892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FIANHJOCBOO> Parser
		{
			get
			{
				return FIANHJOCBOO._parser;
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x000A1699 File Offset: 0x0009F899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FIANHJOCBOOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06003AB4 RID: 15028 RVA: 0x000A16AB File Offset: 0x0009F8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FIANHJOCBOO.Descriptor;
			}
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x000A16B2 File Offset: 0x0009F8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIANHJOCBOO()
		{
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x000A16BA File Offset: 0x0009F8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIANHJOCBOO(FIANHJOCBOO other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x000A16D3 File Offset: 0x0009F8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIANHJOCBOO Clone()
		{
			return new FIANHJOCBOO(this);
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x000A16DB File Offset: 0x0009F8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FIANHJOCBOO);
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x000A16E9 File Offset: 0x0009F8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FIANHJOCBOO other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x000A1708 File Offset: 0x0009F908
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

		// Token: 0x06003ABB RID: 15035 RVA: 0x000A172E File Offset: 0x0009F92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x000A1736 File Offset: 0x0009F936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x000A173F File Offset: 0x0009F93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x000A1758 File Offset: 0x0009F958
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

		// Token: 0x06003ABF RID: 15039 RVA: 0x000A177E File Offset: 0x0009F97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FIANHJOCBOO other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x000A179B File Offset: 0x0009F99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x000A17A4 File Offset: 0x0009F9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001799 RID: 6041
		private static readonly MessageParser<FIANHJOCBOO> _parser = new MessageParser<FIANHJOCBOO>(() => new FIANHJOCBOO());

		// Token: 0x0400179A RID: 6042
		private UnknownFieldSet _unknownFields;
	}
}
