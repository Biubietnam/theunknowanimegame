using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007B7 RID: 1975
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueEndlessActivityDataScRsp : IMessage<GetRogueEndlessActivityDataScRsp>, IMessage, IEquatable<GetRogueEndlessActivityDataScRsp>, IDeepCloneable<GetRogueEndlessActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x0600581E RID: 22558 RVA: 0x000EBA07 File Offset: 0x000E9C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueEndlessActivityDataScRsp> Parser
		{
			get
			{
				return GetRogueEndlessActivityDataScRsp._parser;
			}
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x0600581F RID: 22559 RVA: 0x000EBA0E File Offset: 0x000E9C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueEndlessActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06005820 RID: 22560 RVA: 0x000EBA20 File Offset: 0x000E9C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueEndlessActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x000EBA27 File Offset: 0x000E9C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueEndlessActivityDataScRsp()
		{
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x000EBA48 File Offset: 0x000E9C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueEndlessActivityDataScRsp(GetRogueEndlessActivityDataScRsp other) : this()
		{
			this.cJNMEIOKFAB_ = other.cJNMEIOKFAB_;
			this.lHFDCBAFJGK_ = other.lHFDCBAFJGK_.Clone();
			this.aPGBCNNPHMB_ = other.aPGBCNNPHMB_;
			this.retcode_ = other.retcode_;
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x000EBAB2 File Offset: 0x000E9CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueEndlessActivityDataScRsp Clone()
		{
			return new GetRogueEndlessActivityDataScRsp(this);
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06005824 RID: 22564 RVA: 0x000EBABA File Offset: 0x000E9CBA
		// (set) Token: 0x06005825 RID: 22565 RVA: 0x000EBAC2 File Offset: 0x000E9CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CJNMEIOKFAB
		{
			get
			{
				return this.cJNMEIOKFAB_;
			}
			set
			{
				this.cJNMEIOKFAB_ = value;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x000EBACB File Offset: 0x000E9CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LHFDCBAFJGK
		{
			get
			{
				return this.lHFDCBAFJGK_;
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06005827 RID: 22567 RVA: 0x000EBAD3 File Offset: 0x000E9CD3
		// (set) Token: 0x06005828 RID: 22568 RVA: 0x000EBADB File Offset: 0x000E9CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint APGBCNNPHMB
		{
			get
			{
				return this.aPGBCNNPHMB_;
			}
			set
			{
				this.aPGBCNNPHMB_ = value;
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06005829 RID: 22569 RVA: 0x000EBAE4 File Offset: 0x000E9CE4
		// (set) Token: 0x0600582A RID: 22570 RVA: 0x000EBAEC File Offset: 0x000E9CEC
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

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600582B RID: 22571 RVA: 0x000EBAF5 File Offset: 0x000E9CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueEndlessAreaData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x000EBAFD File Offset: 0x000E9CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueEndlessActivityDataScRsp);
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x000EBB0C File Offset: 0x000E9D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueEndlessActivityDataScRsp other)
		{
			return other != null && (other == this || (this.CJNMEIOKFAB == other.CJNMEIOKFAB && this.lHFDCBAFJGK_.Equals(other.lHFDCBAFJGK_) && this.APGBCNNPHMB == other.APGBCNNPHMB && this.Retcode == other.Retcode && this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x000EBB90 File Offset: 0x000E9D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CJNMEIOKFAB != 0U)
			{
				num ^= this.CJNMEIOKFAB.GetHashCode();
			}
			num ^= this.lHFDCBAFJGK_.GetHashCode();
			if (this.APGBCNNPHMB != 0U)
			{
				num ^= this.APGBCNNPHMB.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.data_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x000EBC1D File Offset: 0x000E9E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x000EBC25 File Offset: 0x000E9E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x000EBC30 File Offset: 0x000E9E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.lHFDCBAFJGK_.WriteTo(ref output, GetRogueEndlessActivityDataScRsp._repeated_lHFDCBAFJGK_codec);
			if (this.CJNMEIOKFAB != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CJNMEIOKFAB);
			}
			this.data_.WriteTo(ref output, GetRogueEndlessActivityDataScRsp._repeated_data_codec);
			if (this.APGBCNNPHMB != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.APGBCNNPHMB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x000EBCC8 File Offset: 0x000E9EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CJNMEIOKFAB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CJNMEIOKFAB);
			}
			num += this.lHFDCBAFJGK_.CalculateSize(GetRogueEndlessActivityDataScRsp._repeated_lHFDCBAFJGK_codec);
			if (this.APGBCNNPHMB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.APGBCNNPHMB);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.data_.CalculateSize(GetRogueEndlessActivityDataScRsp._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x000EBD5C File Offset: 0x000E9F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueEndlessActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CJNMEIOKFAB != 0U)
			{
				this.CJNMEIOKFAB = other.CJNMEIOKFAB;
			}
			this.lHFDCBAFJGK_.Add(other.lHFDCBAFJGK_);
			if (other.APGBCNNPHMB != 0U)
			{
				this.APGBCNNPHMB = other.APGBCNNPHMB;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x000EBDE2 File Offset: 0x000E9FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x000EBDEC File Offset: 0x000E9FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.lHFDCBAFJGK_.AddEntriesFrom(ref input, GetRogueEndlessActivityDataScRsp._repeated_lHFDCBAFJGK_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.CJNMEIOKFAB = input.ReadUInt32();
						continue;
					}
					if (num == 42U)
					{
						this.data_.AddEntriesFrom(ref input, GetRogueEndlessActivityDataScRsp._repeated_data_codec);
						continue;
					}
					if (num == 48U)
					{
						this.APGBCNNPHMB = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400225A RID: 8794
		private static readonly MessageParser<GetRogueEndlessActivityDataScRsp> _parser = new MessageParser<GetRogueEndlessActivityDataScRsp>(() => new GetRogueEndlessActivityDataScRsp());

		// Token: 0x0400225B RID: 8795
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400225C RID: 8796
		public const int CJNMEIOKFABFieldNumber = 4;

		// Token: 0x0400225D RID: 8797
		private uint cJNMEIOKFAB_;

		// Token: 0x0400225E RID: 8798
		public const int LHFDCBAFJGKFieldNumber = 2;

		// Token: 0x0400225F RID: 8799
		private static readonly FieldCodec<uint> _repeated_lHFDCBAFJGK_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04002260 RID: 8800
		private readonly RepeatedField<uint> lHFDCBAFJGK_ = new RepeatedField<uint>();

		// Token: 0x04002261 RID: 8801
		public const int APGBCNNPHMBFieldNumber = 6;

		// Token: 0x04002262 RID: 8802
		private uint aPGBCNNPHMB_;

		// Token: 0x04002263 RID: 8803
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04002264 RID: 8804
		private uint retcode_;

		// Token: 0x04002265 RID: 8805
		public const int DataFieldNumber = 5;

		// Token: 0x04002266 RID: 8806
		private static readonly FieldCodec<RogueEndlessAreaData> _repeated_data_codec = FieldCodec.ForMessage<RogueEndlessAreaData>(42U, RogueEndlessAreaData.Parser);

		// Token: 0x04002267 RID: 8807
		private readonly RepeatedField<RogueEndlessAreaData> data_ = new RepeatedField<RogueEndlessAreaData>();
	}
}
