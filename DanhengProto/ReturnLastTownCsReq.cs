using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DD9 RID: 3545
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReturnLastTownCsReq : IMessage<ReturnLastTownCsReq>, IMessage, IEquatable<ReturnLastTownCsReq>, IDeepCloneable<ReturnLastTownCsReq>, IBufferMessage
	{
		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x06009E67 RID: 40551 RVA: 0x001A7CDE File Offset: 0x001A5EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReturnLastTownCsReq> Parser
		{
			get
			{
				return ReturnLastTownCsReq._parser;
			}
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x06009E68 RID: 40552 RVA: 0x001A7CE5 File Offset: 0x001A5EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReturnLastTownCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x06009E69 RID: 40553 RVA: 0x001A7CF7 File Offset: 0x001A5EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReturnLastTownCsReq.Descriptor;
			}
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x001A7CFE File Offset: 0x001A5EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReturnLastTownCsReq()
		{
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x001A7D06 File Offset: 0x001A5F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReturnLastTownCsReq(ReturnLastTownCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x001A7D1F File Offset: 0x001A5F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReturnLastTownCsReq Clone()
		{
			return new ReturnLastTownCsReq(this);
		}

		// Token: 0x06009E6D RID: 40557 RVA: 0x001A7D27 File Offset: 0x001A5F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReturnLastTownCsReq);
		}

		// Token: 0x06009E6E RID: 40558 RVA: 0x001A7D35 File Offset: 0x001A5F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReturnLastTownCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009E6F RID: 40559 RVA: 0x001A7D54 File Offset: 0x001A5F54
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

		// Token: 0x06009E70 RID: 40560 RVA: 0x001A7D7A File Offset: 0x001A5F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E71 RID: 40561 RVA: 0x001A7D82 File Offset: 0x001A5F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E72 RID: 40562 RVA: 0x001A7D8B File Offset: 0x001A5F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x001A7DA4 File Offset: 0x001A5FA4
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

		// Token: 0x06009E74 RID: 40564 RVA: 0x001A7DCA File Offset: 0x001A5FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReturnLastTownCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x001A7DE7 File Offset: 0x001A5FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x001A7DF0 File Offset: 0x001A5FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004102 RID: 16642
		private static readonly MessageParser<ReturnLastTownCsReq> _parser = new MessageParser<ReturnLastTownCsReq>(() => new ReturnLastTownCsReq());

		// Token: 0x04004103 RID: 16643
		private UnknownFieldSet _unknownFields;
	}
}
