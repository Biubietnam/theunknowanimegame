using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001047 RID: 4167
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SaveLogisticsCsReq : IMessage<SaveLogisticsCsReq>, IMessage, IEquatable<SaveLogisticsCsReq>, IDeepCloneable<SaveLogisticsCsReq>, IBufferMessage
	{
		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600B961 RID: 47457 RVA: 0x001F1AD9 File Offset: 0x001EFCD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SaveLogisticsCsReq> Parser
		{
			get
			{
				return SaveLogisticsCsReq._parser;
			}
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600B962 RID: 47458 RVA: 0x001F1AE0 File Offset: 0x001EFCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SaveLogisticsCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600B963 RID: 47459 RVA: 0x001F1AF2 File Offset: 0x001EFCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SaveLogisticsCsReq.Descriptor;
			}
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x001F1AF9 File Offset: 0x001EFCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SaveLogisticsCsReq()
		{
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x001F1B0C File Offset: 0x001EFD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SaveLogisticsCsReq(SaveLogisticsCsReq other) : this()
		{
			this.aACPHJGMNDF_ = other.aACPHJGMNDF_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B966 RID: 47462 RVA: 0x001F1B36 File Offset: 0x001EFD36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SaveLogisticsCsReq Clone()
		{
			return new SaveLogisticsCsReq(this);
		}

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600B967 RID: 47463 RVA: 0x001F1B3E File Offset: 0x001EFD3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HGGCNNJOEPH> AACPHJGMNDF
		{
			get
			{
				return this.aACPHJGMNDF_;
			}
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x001F1B46 File Offset: 0x001EFD46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SaveLogisticsCsReq);
		}

		// Token: 0x0600B969 RID: 47465 RVA: 0x001F1B54 File Offset: 0x001EFD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SaveLogisticsCsReq other)
		{
			return other != null && (other == this || (this.aACPHJGMNDF_.Equals(other.aACPHJGMNDF_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B96A RID: 47466 RVA: 0x001F1B88 File Offset: 0x001EFD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aACPHJGMNDF_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B96B RID: 47467 RVA: 0x001F1BBC File Offset: 0x001EFDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B96C RID: 47468 RVA: 0x001F1BC4 File Offset: 0x001EFDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B96D RID: 47469 RVA: 0x001F1BCD File Offset: 0x001EFDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aACPHJGMNDF_.WriteTo(ref output, SaveLogisticsCsReq._repeated_aACPHJGMNDF_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B96E RID: 47470 RVA: 0x001F1BF4 File Offset: 0x001EFDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aACPHJGMNDF_.CalculateSize(SaveLogisticsCsReq._repeated_aACPHJGMNDF_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B96F RID: 47471 RVA: 0x001F1C2D File Offset: 0x001EFE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SaveLogisticsCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.aACPHJGMNDF_.Add(other.aACPHJGMNDF_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B970 RID: 47472 RVA: 0x001F1C5B File Offset: 0x001EFE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B971 RID: 47473 RVA: 0x001F1C64 File Offset: 0x001EFE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.aACPHJGMNDF_.AddEntriesFrom(ref input, SaveLogisticsCsReq._repeated_aACPHJGMNDF_codec);
				}
			}
		}

		// Token: 0x04004B14 RID: 19220
		private static readonly MessageParser<SaveLogisticsCsReq> _parser = new MessageParser<SaveLogisticsCsReq>(() => new SaveLogisticsCsReq());

		// Token: 0x04004B15 RID: 19221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B16 RID: 19222
		public const int AACPHJGMNDFFieldNumber = 15;

		// Token: 0x04004B17 RID: 19223
		private static readonly FieldCodec<HGGCNNJOEPH> _repeated_aACPHJGMNDF_codec = FieldCodec.ForMessage<HGGCNNJOEPH>(122U, HGGCNNJOEPH.Parser);

		// Token: 0x04004B18 RID: 19224
		private readonly RepeatedField<HGGCNNJOEPH> aACPHJGMNDF_ = new RepeatedField<HGGCNNJOEPH>();
	}
}
