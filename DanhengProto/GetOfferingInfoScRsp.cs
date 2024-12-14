using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000757 RID: 1879
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetOfferingInfoScRsp : IMessage<GetOfferingInfoScRsp>, IMessage, IEquatable<GetOfferingInfoScRsp>, IDeepCloneable<GetOfferingInfoScRsp>, IBufferMessage
	{
		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x060053FA RID: 21498 RVA: 0x000E2005 File Offset: 0x000E0205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetOfferingInfoScRsp> Parser
		{
			get
			{
				return GetOfferingInfoScRsp._parser;
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x060053FB RID: 21499 RVA: 0x000E200C File Offset: 0x000E020C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetOfferingInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x000E201E File Offset: 0x000E021E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetOfferingInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x000E2025 File Offset: 0x000E0225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetOfferingInfoScRsp()
		{
		}

		// Token: 0x060053FE RID: 21502 RVA: 0x000E2038 File Offset: 0x000E0238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetOfferingInfoScRsp(GetOfferingInfoScRsp other) : this()
		{
			this.fCCHPONGKHH_ = other.fCCHPONGKHH_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053FF RID: 21503 RVA: 0x000E206E File Offset: 0x000E026E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetOfferingInfoScRsp Clone()
		{
			return new GetOfferingInfoScRsp(this);
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x000E2076 File Offset: 0x000E0276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<POPDHFEBLPG> FCCHPONGKHH
		{
			get
			{
				return this.fCCHPONGKHH_;
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06005401 RID: 21505 RVA: 0x000E207E File Offset: 0x000E027E
		// (set) Token: 0x06005402 RID: 21506 RVA: 0x000E2086 File Offset: 0x000E0286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x000E208F File Offset: 0x000E028F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetOfferingInfoScRsp);
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x000E20A0 File Offset: 0x000E02A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetOfferingInfoScRsp other)
		{
			return other != null && (other == this || (this.fCCHPONGKHH_.Equals(other.fCCHPONGKHH_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x000E20F0 File Offset: 0x000E02F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fCCHPONGKHH_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x000E213D File Offset: 0x000E033D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x000E2145 File Offset: 0x000E0345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x000E2150 File Offset: 0x000E0350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.fCCHPONGKHH_.WriteTo(ref output, GetOfferingInfoScRsp._repeated_fCCHPONGKHH_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x000E21A0 File Offset: 0x000E03A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fCCHPONGKHH_.CalculateSize(GetOfferingInfoScRsp._repeated_fCCHPONGKHH_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x000E21F4 File Offset: 0x000E03F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetOfferingInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.fCCHPONGKHH_.Add(other.fCCHPONGKHH_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x000E2241 File Offset: 0x000E0441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x000E224C File Offset: 0x000E044C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.fCCHPONGKHH_.AddEntriesFrom(ref input, GetOfferingInfoScRsp._repeated_fCCHPONGKHH_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040020FE RID: 8446
		private static readonly MessageParser<GetOfferingInfoScRsp> _parser = new MessageParser<GetOfferingInfoScRsp>(() => new GetOfferingInfoScRsp());

		// Token: 0x040020FF RID: 8447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002100 RID: 8448
		public const int FCCHPONGKHHFieldNumber = 3;

		// Token: 0x04002101 RID: 8449
		private static readonly FieldCodec<POPDHFEBLPG> _repeated_fCCHPONGKHH_codec = FieldCodec.ForMessage<POPDHFEBLPG>(26U, POPDHFEBLPG.Parser);

		// Token: 0x04002102 RID: 8450
		private readonly RepeatedField<POPDHFEBLPG> fCCHPONGKHH_ = new RepeatedField<POPDHFEBLPG>();

		// Token: 0x04002103 RID: 8451
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04002104 RID: 8452
		private uint retcode_;
	}
}
