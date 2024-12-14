using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000711 RID: 1809
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMarkItemListCsReq : IMessage<GetMarkItemListCsReq>, IMessage, IEquatable<GetMarkItemListCsReq>, IDeepCloneable<GetMarkItemListCsReq>, IBufferMessage
	{
		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x060050DC RID: 20700 RVA: 0x000D9F2F File Offset: 0x000D812F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMarkItemListCsReq> Parser
		{
			get
			{
				return GetMarkItemListCsReq._parser;
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x060050DD RID: 20701 RVA: 0x000D9F36 File Offset: 0x000D8136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMarkItemListCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x060050DE RID: 20702 RVA: 0x000D9F48 File Offset: 0x000D8148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMarkItemListCsReq.Descriptor;
			}
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x000D9F4F File Offset: 0x000D814F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMarkItemListCsReq()
		{
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x000D9F57 File Offset: 0x000D8157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMarkItemListCsReq(GetMarkItemListCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x000D9F70 File Offset: 0x000D8170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMarkItemListCsReq Clone()
		{
			return new GetMarkItemListCsReq(this);
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x000D9F78 File Offset: 0x000D8178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMarkItemListCsReq);
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x000D9F86 File Offset: 0x000D8186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMarkItemListCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x000D9FA4 File Offset: 0x000D81A4
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

		// Token: 0x060050E5 RID: 20709 RVA: 0x000D9FCA File Offset: 0x000D81CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x000D9FD2 File Offset: 0x000D81D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x000D9FDB File Offset: 0x000D81DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x000D9FF4 File Offset: 0x000D81F4
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

		// Token: 0x060050E9 RID: 20713 RVA: 0x000DA01A File Offset: 0x000D821A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMarkItemListCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x000DA037 File Offset: 0x000D8237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x000DA040 File Offset: 0x000D8240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FCE RID: 8142
		private static readonly MessageParser<GetMarkItemListCsReq> _parser = new MessageParser<GetMarkItemListCsReq>(() => new GetMarkItemListCsReq());

		// Token: 0x04001FCF RID: 8143
		private UnknownFieldSet _unknownFields;
	}
}
