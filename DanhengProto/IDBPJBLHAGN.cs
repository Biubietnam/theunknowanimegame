using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000915 RID: 2325
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IDBPJBLHAGN : IMessage<IDBPJBLHAGN>, IMessage, IEquatable<IDBPJBLHAGN>, IDeepCloneable<IDBPJBLHAGN>, IBufferMessage
	{
		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x060067B7 RID: 26551 RVA: 0x0011544E File Offset: 0x0011364E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IDBPJBLHAGN> Parser
		{
			get
			{
				return IDBPJBLHAGN._parser;
			}
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x060067B8 RID: 26552 RVA: 0x00115455 File Offset: 0x00113655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IDBPJBLHAGNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x060067B9 RID: 26553 RVA: 0x00115467 File Offset: 0x00113667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IDBPJBLHAGN.Descriptor;
			}
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x0011546E File Offset: 0x0011366E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDBPJBLHAGN()
		{
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x00115476 File Offset: 0x00113676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDBPJBLHAGN(IDBPJBLHAGN other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067BC RID: 26556 RVA: 0x0011548F File Offset: 0x0011368F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDBPJBLHAGN Clone()
		{
			return new IDBPJBLHAGN(this);
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x00115497 File Offset: 0x00113697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IDBPJBLHAGN);
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x001154A5 File Offset: 0x001136A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IDBPJBLHAGN other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x001154C4 File Offset: 0x001136C4
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

		// Token: 0x060067C0 RID: 26560 RVA: 0x001154EA File Offset: 0x001136EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060067C1 RID: 26561 RVA: 0x001154F2 File Offset: 0x001136F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067C2 RID: 26562 RVA: 0x001154FB File Offset: 0x001136FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x00115514 File Offset: 0x00113714
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

		// Token: 0x060067C4 RID: 26564 RVA: 0x0011553A File Offset: 0x0011373A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IDBPJBLHAGN other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x00115557 File Offset: 0x00113757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x00115560 File Offset: 0x00113760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040027DB RID: 10203
		private static readonly MessageParser<IDBPJBLHAGN> _parser = new MessageParser<IDBPJBLHAGN>(() => new IDBPJBLHAGN());

		// Token: 0x040027DC RID: 10204
		private UnknownFieldSet _unknownFields;
	}
}
