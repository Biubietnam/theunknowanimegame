using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000821 RID: 2081
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTelevisionActivityDataCsReq : IMessage<GetTelevisionActivityDataCsReq>, IMessage, IEquatable<GetTelevisionActivityDataCsReq>, IDeepCloneable<GetTelevisionActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06005CAD RID: 23725 RVA: 0x000F64CF File Offset: 0x000F46CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTelevisionActivityDataCsReq> Parser
		{
			get
			{
				return GetTelevisionActivityDataCsReq._parser;
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06005CAE RID: 23726 RVA: 0x000F64D6 File Offset: 0x000F46D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTelevisionActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06005CAF RID: 23727 RVA: 0x000F64E8 File Offset: 0x000F46E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTelevisionActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x000F64EF File Offset: 0x000F46EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTelevisionActivityDataCsReq()
		{
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x000F64F7 File Offset: 0x000F46F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTelevisionActivityDataCsReq(GetTelevisionActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x000F6510 File Offset: 0x000F4710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTelevisionActivityDataCsReq Clone()
		{
			return new GetTelevisionActivityDataCsReq(this);
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x000F6518 File Offset: 0x000F4718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTelevisionActivityDataCsReq);
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x000F6526 File Offset: 0x000F4726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTelevisionActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x000F6544 File Offset: 0x000F4744
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

		// Token: 0x06005CB6 RID: 23734 RVA: 0x000F656A File Offset: 0x000F476A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x000F6572 File Offset: 0x000F4772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x000F657B File Offset: 0x000F477B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x000F6594 File Offset: 0x000F4794
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

		// Token: 0x06005CBA RID: 23738 RVA: 0x000F65BA File Offset: 0x000F47BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTelevisionActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x000F65D7 File Offset: 0x000F47D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x000F65E0 File Offset: 0x000F47E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040023DA RID: 9178
		private static readonly MessageParser<GetTelevisionActivityDataCsReq> _parser = new MessageParser<GetTelevisionActivityDataCsReq>(() => new GetTelevisionActivityDataCsReq());

		// Token: 0x040023DB RID: 9179
		private UnknownFieldSet _unknownFields;
	}
}
