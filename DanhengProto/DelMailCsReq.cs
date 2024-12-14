using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000381 RID: 897
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DelMailCsReq : IMessage<DelMailCsReq>, IMessage, IEquatable<DelMailCsReq>, IDeepCloneable<DelMailCsReq>, IBufferMessage
	{
		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x0006F1F8 File Offset: 0x0006D3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DelMailCsReq> Parser
		{
			get
			{
				return DelMailCsReq._parser;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x0006F1FF File Offset: 0x0006D3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DelMailCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x0006F211 File Offset: 0x0006D411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DelMailCsReq.Descriptor;
			}
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x0006F218 File Offset: 0x0006D418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DelMailCsReq()
		{
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x0006F22B File Offset: 0x0006D42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DelMailCsReq(DelMailCsReq other) : this()
		{
			this.idList_ = other.idList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x0006F255 File Offset: 0x0006D455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DelMailCsReq Clone()
		{
			return new DelMailCsReq(this);
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x0006F25D File Offset: 0x0006D45D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IdList
		{
			get
			{
				return this.idList_;
			}
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x0006F265 File Offset: 0x0006D465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DelMailCsReq);
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x0006F273 File Offset: 0x0006D473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DelMailCsReq other)
		{
			return other != null && (other == this || (this.idList_.Equals(other.idList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x0006F2A8 File Offset: 0x0006D4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.idList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x0006F2DC File Offset: 0x0006D4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x0006F2E4 File Offset: 0x0006D4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x0006F2ED File Offset: 0x0006D4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.idList_.WriteTo(ref output, DelMailCsReq._repeated_idList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x0006F314 File Offset: 0x0006D514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.idList_.CalculateSize(DelMailCsReq._repeated_idList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x0006F34D File Offset: 0x0006D54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DelMailCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.idList_.Add(other.idList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x0006F37B File Offset: 0x0006D57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x0006F384 File Offset: 0x0006D584
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
					this.idList_.AddEntriesFrom(ref input, DelMailCsReq._repeated_idList_codec);
				}
			}
		}

		// Token: 0x0400100F RID: 4111
		private static readonly MessageParser<DelMailCsReq> _parser = new MessageParser<DelMailCsReq>(() => new DelMailCsReq());

		// Token: 0x04001010 RID: 4112
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001011 RID: 4113
		public const int IdListFieldNumber = 5;

		// Token: 0x04001012 RID: 4114
		private static readonly FieldCodec<uint> _repeated_idList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04001013 RID: 4115
		private readonly RepeatedField<uint> idList_ = new RepeatedField<uint>();
	}
}
