using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EB1 RID: 3761
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicAutoDressInUnitCsReq : IMessage<RogueMagicAutoDressInUnitCsReq>, IMessage, IEquatable<RogueMagicAutoDressInUnitCsReq>, IDeepCloneable<RogueMagicAutoDressInUnitCsReq>, IBufferMessage
	{
		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x0600A80B RID: 43019 RVA: 0x001C4A2D File Offset: 0x001C2C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicAutoDressInUnitCsReq> Parser
		{
			get
			{
				return RogueMagicAutoDressInUnitCsReq._parser;
			}
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x0600A80C RID: 43020 RVA: 0x001C4A34 File Offset: 0x001C2C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicAutoDressInUnitCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x0600A80D RID: 43021 RVA: 0x001C4A46 File Offset: 0x001C2C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicAutoDressInUnitCsReq.Descriptor;
			}
		}

		// Token: 0x0600A80E RID: 43022 RVA: 0x001C4A4D File Offset: 0x001C2C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAutoDressInUnitCsReq()
		{
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x001C4A60 File Offset: 0x001C2C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAutoDressInUnitCsReq(RogueMagicAutoDressInUnitCsReq other) : this()
		{
			this.magicUnitIdList_ = other.magicUnitIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A810 RID: 43024 RVA: 0x001C4A8A File Offset: 0x001C2C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAutoDressInUnitCsReq Clone()
		{
			return new RogueMagicAutoDressInUnitCsReq(this);
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x0600A811 RID: 43025 RVA: 0x001C4A92 File Offset: 0x001C2C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MagicUnitIdList
		{
			get
			{
				return this.magicUnitIdList_;
			}
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x001C4A9A File Offset: 0x001C2C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicAutoDressInUnitCsReq);
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x001C4AA8 File Offset: 0x001C2CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicAutoDressInUnitCsReq other)
		{
			return other != null && (other == this || (this.magicUnitIdList_.Equals(other.magicUnitIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x001C4ADC File Offset: 0x001C2CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.magicUnitIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A815 RID: 43029 RVA: 0x001C4B10 File Offset: 0x001C2D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A816 RID: 43030 RVA: 0x001C4B18 File Offset: 0x001C2D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A817 RID: 43031 RVA: 0x001C4B21 File Offset: 0x001C2D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.magicUnitIdList_.WriteTo(ref output, RogueMagicAutoDressInUnitCsReq._repeated_magicUnitIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A818 RID: 43032 RVA: 0x001C4B48 File Offset: 0x001C2D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.magicUnitIdList_.CalculateSize(RogueMagicAutoDressInUnitCsReq._repeated_magicUnitIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A819 RID: 43033 RVA: 0x001C4B81 File Offset: 0x001C2D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicAutoDressInUnitCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.magicUnitIdList_.Add(other.magicUnitIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A81A RID: 43034 RVA: 0x001C4BAF File Offset: 0x001C2DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A81B RID: 43035 RVA: 0x001C4BB8 File Offset: 0x001C2DB8
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
					this.magicUnitIdList_.AddEntriesFrom(ref input, RogueMagicAutoDressInUnitCsReq._repeated_magicUnitIdList_codec);
				}
			}
		}

		// Token: 0x040044B4 RID: 17588
		private static readonly MessageParser<RogueMagicAutoDressInUnitCsReq> _parser = new MessageParser<RogueMagicAutoDressInUnitCsReq>(() => new RogueMagicAutoDressInUnitCsReq());

		// Token: 0x040044B5 RID: 17589
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044B6 RID: 17590
		public const int MagicUnitIdListFieldNumber = 5;

		// Token: 0x040044B7 RID: 17591
		private static readonly FieldCodec<uint> _repeated_magicUnitIdList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040044B8 RID: 17592
		private readonly RepeatedField<uint> magicUnitIdList_ = new RepeatedField<uint>();
	}
}
