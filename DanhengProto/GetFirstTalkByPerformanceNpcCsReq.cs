using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006A9 RID: 1705
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFirstTalkByPerformanceNpcCsReq : IMessage<GetFirstTalkByPerformanceNpcCsReq>, IMessage, IEquatable<GetFirstTalkByPerformanceNpcCsReq>, IDeepCloneable<GetFirstTalkByPerformanceNpcCsReq>, IBufferMessage
	{
		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x000CF215 File Offset: 0x000CD415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFirstTalkByPerformanceNpcCsReq> Parser
		{
			get
			{
				return GetFirstTalkByPerformanceNpcCsReq._parser;
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06004C54 RID: 19540 RVA: 0x000CF21C File Offset: 0x000CD41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFirstTalkByPerformanceNpcCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06004C55 RID: 19541 RVA: 0x000CF22E File Offset: 0x000CD42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFirstTalkByPerformanceNpcCsReq.Descriptor;
			}
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x000CF235 File Offset: 0x000CD435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkByPerformanceNpcCsReq()
		{
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x000CF248 File Offset: 0x000CD448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkByPerformanceNpcCsReq(GetFirstTalkByPerformanceNpcCsReq other) : this()
		{
			this.performanceIdList_ = other.performanceIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x000CF272 File Offset: 0x000CD472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkByPerformanceNpcCsReq Clone()
		{
			return new GetFirstTalkByPerformanceNpcCsReq(this);
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06004C59 RID: 19545 RVA: 0x000CF27A File Offset: 0x000CD47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PerformanceIdList
		{
			get
			{
				return this.performanceIdList_;
			}
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x000CF282 File Offset: 0x000CD482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFirstTalkByPerformanceNpcCsReq);
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x000CF290 File Offset: 0x000CD490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFirstTalkByPerformanceNpcCsReq other)
		{
			return other != null && (other == this || (this.performanceIdList_.Equals(other.performanceIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x000CF2C4 File Offset: 0x000CD4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.performanceIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x000CF2F8 File Offset: 0x000CD4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x000CF300 File Offset: 0x000CD500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x000CF309 File Offset: 0x000CD509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.performanceIdList_.WriteTo(ref output, GetFirstTalkByPerformanceNpcCsReq._repeated_performanceIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x000CF330 File Offset: 0x000CD530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.performanceIdList_.CalculateSize(GetFirstTalkByPerformanceNpcCsReq._repeated_performanceIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x000CF369 File Offset: 0x000CD569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFirstTalkByPerformanceNpcCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.performanceIdList_.Add(other.performanceIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x000CF397 File Offset: 0x000CD597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x000CF3A0 File Offset: 0x000CD5A0
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
					this.performanceIdList_.AddEntriesFrom(ref input, GetFirstTalkByPerformanceNpcCsReq._repeated_performanceIdList_codec);
				}
			}
		}

		// Token: 0x04001E37 RID: 7735
		private static readonly MessageParser<GetFirstTalkByPerformanceNpcCsReq> _parser = new MessageParser<GetFirstTalkByPerformanceNpcCsReq>(() => new GetFirstTalkByPerformanceNpcCsReq());

		// Token: 0x04001E38 RID: 7736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E39 RID: 7737
		public const int PerformanceIdListFieldNumber = 5;

		// Token: 0x04001E3A RID: 7738
		private static readonly FieldCodec<uint> _repeated_performanceIdList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04001E3B RID: 7739
		private readonly RepeatedField<uint> performanceIdList_ = new RepeatedField<uint>();
	}
}
