using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B7F RID: 2943
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyTakePhaseRewardCsReq : IMessage<MonopolyTakePhaseRewardCsReq>, IMessage, IEquatable<MonopolyTakePhaseRewardCsReq>, IDeepCloneable<MonopolyTakePhaseRewardCsReq>, IBufferMessage
	{
		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x0600823D RID: 33341 RVA: 0x00157034 File Offset: 0x00155234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyTakePhaseRewardCsReq> Parser
		{
			get
			{
				return MonopolyTakePhaseRewardCsReq._parser;
			}
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x0600823E RID: 33342 RVA: 0x0015703B File Offset: 0x0015523B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyTakePhaseRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x0600823F RID: 33343 RVA: 0x0015704D File Offset: 0x0015524D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyTakePhaseRewardCsReq.Descriptor;
			}
		}

		// Token: 0x06008240 RID: 33344 RVA: 0x00157054 File Offset: 0x00155254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakePhaseRewardCsReq()
		{
		}

		// Token: 0x06008241 RID: 33345 RVA: 0x00157067 File Offset: 0x00155267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakePhaseRewardCsReq(MonopolyTakePhaseRewardCsReq other) : this()
		{
			this.hAHPDCCHMHB_ = other.hAHPDCCHMHB_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008242 RID: 33346 RVA: 0x00157091 File Offset: 0x00155291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakePhaseRewardCsReq Clone()
		{
			return new MonopolyTakePhaseRewardCsReq(this);
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x06008243 RID: 33347 RVA: 0x00157099 File Offset: 0x00155299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HAHPDCCHMHB
		{
			get
			{
				return this.hAHPDCCHMHB_;
			}
		}

		// Token: 0x06008244 RID: 33348 RVA: 0x001570A1 File Offset: 0x001552A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyTakePhaseRewardCsReq);
		}

		// Token: 0x06008245 RID: 33349 RVA: 0x001570AF File Offset: 0x001552AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyTakePhaseRewardCsReq other)
		{
			return other != null && (other == this || (this.hAHPDCCHMHB_.Equals(other.hAHPDCCHMHB_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008246 RID: 33350 RVA: 0x001570E4 File Offset: 0x001552E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hAHPDCCHMHB_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008247 RID: 33351 RVA: 0x00157118 File Offset: 0x00155318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008248 RID: 33352 RVA: 0x00157120 File Offset: 0x00155320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008249 RID: 33353 RVA: 0x00157129 File Offset: 0x00155329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hAHPDCCHMHB_.WriteTo(ref output, MonopolyTakePhaseRewardCsReq._repeated_hAHPDCCHMHB_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600824A RID: 33354 RVA: 0x00157150 File Offset: 0x00155350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hAHPDCCHMHB_.CalculateSize(MonopolyTakePhaseRewardCsReq._repeated_hAHPDCCHMHB_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600824B RID: 33355 RVA: 0x00157189 File Offset: 0x00155389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyTakePhaseRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.hAHPDCCHMHB_.Add(other.hAHPDCCHMHB_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600824C RID: 33356 RVA: 0x001571B7 File Offset: 0x001553B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x001571C0 File Offset: 0x001553C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hAHPDCCHMHB_.AddEntriesFrom(ref input, MonopolyTakePhaseRewardCsReq._repeated_hAHPDCCHMHB_codec);
				}
			}
		}

		// Token: 0x040031AA RID: 12714
		private static readonly MessageParser<MonopolyTakePhaseRewardCsReq> _parser = new MessageParser<MonopolyTakePhaseRewardCsReq>(() => new MonopolyTakePhaseRewardCsReq());

		// Token: 0x040031AB RID: 12715
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031AC RID: 12716
		public const int HAHPDCCHMHBFieldNumber = 11;

		// Token: 0x040031AD RID: 12717
		private static readonly FieldCodec<uint> _repeated_hAHPDCCHMHB_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x040031AE RID: 12718
		private readonly RepeatedField<uint> hAHPDCCHMHB_ = new RepeatedField<uint>();
	}
}
