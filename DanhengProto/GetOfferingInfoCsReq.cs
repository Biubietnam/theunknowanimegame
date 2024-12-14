using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000755 RID: 1877
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetOfferingInfoCsReq : IMessage<GetOfferingInfoCsReq>, IMessage, IEquatable<GetOfferingInfoCsReq>, IDeepCloneable<GetOfferingInfoCsReq>, IBufferMessage
	{
		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x000E1D80 File Offset: 0x000DFF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetOfferingInfoCsReq> Parser
		{
			get
			{
				return GetOfferingInfoCsReq._parser;
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x060053E7 RID: 21479 RVA: 0x000E1D87 File Offset: 0x000DFF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetOfferingInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x000E1D99 File Offset: 0x000DFF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetOfferingInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x000E1DA0 File Offset: 0x000DFFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetOfferingInfoCsReq()
		{
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x000E1DB3 File Offset: 0x000DFFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetOfferingInfoCsReq(GetOfferingInfoCsReq other) : this()
		{
			this.cCNELJBEOBI_ = other.cCNELJBEOBI_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x000E1DDD File Offset: 0x000DFFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetOfferingInfoCsReq Clone()
		{
			return new GetOfferingInfoCsReq(this);
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x060053EC RID: 21484 RVA: 0x000E1DE5 File Offset: 0x000DFFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> CCNELJBEOBI
		{
			get
			{
				return this.cCNELJBEOBI_;
			}
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x000E1DED File Offset: 0x000DFFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetOfferingInfoCsReq);
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x000E1DFB File Offset: 0x000DFFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetOfferingInfoCsReq other)
		{
			return other != null && (other == this || (this.cCNELJBEOBI_.Equals(other.cCNELJBEOBI_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x000E1E30 File Offset: 0x000E0030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cCNELJBEOBI_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x000E1E64 File Offset: 0x000E0064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x000E1E6C File Offset: 0x000E006C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x000E1E75 File Offset: 0x000E0075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cCNELJBEOBI_.WriteTo(ref output, GetOfferingInfoCsReq._repeated_cCNELJBEOBI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x000E1E9C File Offset: 0x000E009C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cCNELJBEOBI_.CalculateSize(GetOfferingInfoCsReq._repeated_cCNELJBEOBI_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x000E1ED5 File Offset: 0x000E00D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetOfferingInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.cCNELJBEOBI_.Add(other.cCNELJBEOBI_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x000E1F03 File Offset: 0x000E0103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x000E1F0C File Offset: 0x000E010C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cCNELJBEOBI_.AddEntriesFrom(ref input, GetOfferingInfoCsReq._repeated_cCNELJBEOBI_codec);
				}
			}
		}

		// Token: 0x040020F8 RID: 8440
		private static readonly MessageParser<GetOfferingInfoCsReq> _parser = new MessageParser<GetOfferingInfoCsReq>(() => new GetOfferingInfoCsReq());

		// Token: 0x040020F9 RID: 8441
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020FA RID: 8442
		public const int CCNELJBEOBIFieldNumber = 5;

		// Token: 0x040020FB RID: 8443
		private static readonly FieldCodec<uint> _repeated_cCNELJBEOBI_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040020FC RID: 8444
		private readonly RepeatedField<uint> cCNELJBEOBI_ = new RepeatedField<uint>();
	}
}
