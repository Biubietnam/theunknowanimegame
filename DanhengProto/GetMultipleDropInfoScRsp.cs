using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000743 RID: 1859
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMultipleDropInfoScRsp : IMessage<GetMultipleDropInfoScRsp>, IMessage, IEquatable<GetMultipleDropInfoScRsp>, IDeepCloneable<GetMultipleDropInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06005311 RID: 21265 RVA: 0x000DF9DF File Offset: 0x000DDBDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMultipleDropInfoScRsp> Parser
		{
			get
			{
				return GetMultipleDropInfoScRsp._parser;
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06005312 RID: 21266 RVA: 0x000DF9E6 File Offset: 0x000DDBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMultipleDropInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06005313 RID: 21267 RVA: 0x000DF9F8 File Offset: 0x000DDBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMultipleDropInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x000DF9FF File Offset: 0x000DDBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultipleDropInfoScRsp()
		{
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x000DFA20 File Offset: 0x000DDC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultipleDropInfoScRsp(GetMultipleDropInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.nEFAKDOLPED_ = other.nEFAKDOLPED_.Clone();
			this.aHMGFCCBCBN_ = other.aHMGFCCBCBN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x000DFA72 File Offset: 0x000DDC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMultipleDropInfoScRsp Clone()
		{
			return new GetMultipleDropInfoScRsp(this);
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06005317 RID: 21271 RVA: 0x000DFA7A File Offset: 0x000DDC7A
		// (set) Token: 0x06005318 RID: 21272 RVA: 0x000DFA82 File Offset: 0x000DDC82
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

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x000DFA8B File Offset: 0x000DDC8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KNOAKLPPLOM> NEFAKDOLPED
		{
			get
			{
				return this.nEFAKDOLPED_;
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x0600531A RID: 21274 RVA: 0x000DFA93 File Offset: 0x000DDC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HMDAGOFFLED> AHMGFCCBCBN
		{
			get
			{
				return this.aHMGFCCBCBN_;
			}
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x000DFA9B File Offset: 0x000DDC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMultipleDropInfoScRsp);
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x000DFAAC File Offset: 0x000DDCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMultipleDropInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.nEFAKDOLPED_.Equals(other.nEFAKDOLPED_) && this.aHMGFCCBCBN_.Equals(other.aHMGFCCBCBN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x000DFB10 File Offset: 0x000DDD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.nEFAKDOLPED_.GetHashCode();
			num ^= this.aHMGFCCBCBN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600531E RID: 21278 RVA: 0x000DFB6B File Offset: 0x000DDD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x000DFB73 File Offset: 0x000DDD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x000DFB7C File Offset: 0x000DDD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nEFAKDOLPED_.WriteTo(ref output, GetMultipleDropInfoScRsp._repeated_nEFAKDOLPED_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			this.aHMGFCCBCBN_.WriteTo(ref output, GetMultipleDropInfoScRsp._repeated_aHMGFCCBCBN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x000DFBDC File Offset: 0x000DDDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.nEFAKDOLPED_.CalculateSize(GetMultipleDropInfoScRsp._repeated_nEFAKDOLPED_codec);
			num += this.aHMGFCCBCBN_.CalculateSize(GetMultipleDropInfoScRsp._repeated_aHMGFCCBCBN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x000DFC40 File Offset: 0x000DDE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMultipleDropInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.nEFAKDOLPED_.Add(other.nEFAKDOLPED_);
			this.aHMGFCCBCBN_.Add(other.aHMGFCCBCBN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x000DFC9E File Offset: 0x000DDE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x000DFCA8 File Offset: 0x000DDEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 80U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.aHMGFCCBCBN_.AddEntriesFrom(ref input, GetMultipleDropInfoScRsp._repeated_aHMGFCCBCBN_codec);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.nEFAKDOLPED_.AddEntriesFrom(ref input, GetMultipleDropInfoScRsp._repeated_nEFAKDOLPED_codec);
				}
			}
		}

		// Token: 0x0400209F RID: 8351
		private static readonly MessageParser<GetMultipleDropInfoScRsp> _parser = new MessageParser<GetMultipleDropInfoScRsp>(() => new GetMultipleDropInfoScRsp());

		// Token: 0x040020A0 RID: 8352
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020A1 RID: 8353
		public const int RetcodeFieldNumber = 10;

		// Token: 0x040020A2 RID: 8354
		private uint retcode_;

		// Token: 0x040020A3 RID: 8355
		public const int NEFAKDOLPEDFieldNumber = 1;

		// Token: 0x040020A4 RID: 8356
		private static readonly FieldCodec<KNOAKLPPLOM> _repeated_nEFAKDOLPED_codec = FieldCodec.ForMessage<KNOAKLPPLOM>(10U, KNOAKLPPLOM.Parser);

		// Token: 0x040020A5 RID: 8357
		private readonly RepeatedField<KNOAKLPPLOM> nEFAKDOLPED_ = new RepeatedField<KNOAKLPPLOM>();

		// Token: 0x040020A6 RID: 8358
		public const int AHMGFCCBCBNFieldNumber = 13;

		// Token: 0x040020A7 RID: 8359
		private static readonly FieldCodec<HMDAGOFFLED> _repeated_aHMGFCCBCBN_codec = FieldCodec.ForMessage<HMDAGOFFLED>(106U, HMDAGOFFLED.Parser);

		// Token: 0x040020A8 RID: 8360
		private readonly RepeatedField<HMDAGOFFLED> aHMGFCCBCBN_ = new RepeatedField<HMDAGOFFLED>();
	}
}
