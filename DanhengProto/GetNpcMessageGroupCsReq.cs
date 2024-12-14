using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000749 RID: 1865
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetNpcMessageGroupCsReq : IMessage<GetNpcMessageGroupCsReq>, IMessage, IEquatable<GetNpcMessageGroupCsReq>, IDeepCloneable<GetNpcMessageGroupCsReq>, IBufferMessage
	{
		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06005366 RID: 21350 RVA: 0x000E0C44 File Offset: 0x000DEE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetNpcMessageGroupCsReq> Parser
		{
			get
			{
				return GetNpcMessageGroupCsReq._parser;
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06005367 RID: 21351 RVA: 0x000E0C4B File Offset: 0x000DEE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetNpcMessageGroupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06005368 RID: 21352 RVA: 0x000E0C5D File Offset: 0x000DEE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetNpcMessageGroupCsReq.Descriptor;
			}
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x000E0C64 File Offset: 0x000DEE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcMessageGroupCsReq()
		{
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x000E0C77 File Offset: 0x000DEE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcMessageGroupCsReq(GetNpcMessageGroupCsReq other) : this()
		{
			this.contactIdList_ = other.contactIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x000E0CA1 File Offset: 0x000DEEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcMessageGroupCsReq Clone()
		{
			return new GetNpcMessageGroupCsReq(this);
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x000E0CA9 File Offset: 0x000DEEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ContactIdList
		{
			get
			{
				return this.contactIdList_;
			}
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x000E0CB1 File Offset: 0x000DEEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetNpcMessageGroupCsReq);
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x000E0CBF File Offset: 0x000DEEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetNpcMessageGroupCsReq other)
		{
			return other != null && (other == this || (this.contactIdList_.Equals(other.contactIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x000E0CF4 File Offset: 0x000DEEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.contactIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x000E0D28 File Offset: 0x000DEF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x000E0D30 File Offset: 0x000DEF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x000E0D39 File Offset: 0x000DEF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.contactIdList_.WriteTo(ref output, GetNpcMessageGroupCsReq._repeated_contactIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x000E0D60 File Offset: 0x000DEF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.contactIdList_.CalculateSize(GetNpcMessageGroupCsReq._repeated_contactIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x000E0D99 File Offset: 0x000DEF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetNpcMessageGroupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.contactIdList_.Add(other.contactIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x000E0DC7 File Offset: 0x000DEFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x000E0DD0 File Offset: 0x000DEFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.contactIdList_.AddEntriesFrom(ref input, GetNpcMessageGroupCsReq._repeated_contactIdList_codec);
				}
			}
		}

		// Token: 0x040020D0 RID: 8400
		private static readonly MessageParser<GetNpcMessageGroupCsReq> _parser = new MessageParser<GetNpcMessageGroupCsReq>(() => new GetNpcMessageGroupCsReq());

		// Token: 0x040020D1 RID: 8401
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020D2 RID: 8402
		public const int ContactIdListFieldNumber = 15;

		// Token: 0x040020D3 RID: 8403
		private static readonly FieldCodec<uint> _repeated_contactIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x040020D4 RID: 8404
		private readonly RepeatedField<uint> contactIdList_ = new RepeatedField<uint>();
	}
}
