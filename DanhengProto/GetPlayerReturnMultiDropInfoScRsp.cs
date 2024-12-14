using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000773 RID: 1907
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPlayerReturnMultiDropInfoScRsp : IMessage<GetPlayerReturnMultiDropInfoScRsp>, IMessage, IEquatable<GetPlayerReturnMultiDropInfoScRsp>, IDeepCloneable<GetPlayerReturnMultiDropInfoScRsp>, IBufferMessage
	{
		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x0600552D RID: 21805 RVA: 0x000E4C73 File Offset: 0x000E2E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPlayerReturnMultiDropInfoScRsp> Parser
		{
			get
			{
				return GetPlayerReturnMultiDropInfoScRsp._parser;
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x0600552E RID: 21806 RVA: 0x000E4C7A File Offset: 0x000E2E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPlayerReturnMultiDropInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x0600552F RID: 21807 RVA: 0x000E4C8C File Offset: 0x000E2E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerReturnMultiDropInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x000E4C93 File Offset: 0x000E2E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReturnMultiDropInfoScRsp()
		{
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x000E4CA8 File Offset: 0x000E2EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReturnMultiDropInfoScRsp(GetPlayerReturnMultiDropInfoScRsp other) : this()
		{
			this.aHMGFCCBCBN_ = other.aHMGFCCBCBN_.Clone();
			this.mENNNHOCNCC_ = ((other.mENNNHOCNCC_ != null) ? other.mENNNHOCNCC_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x000E4D05 File Offset: 0x000E2F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReturnMultiDropInfoScRsp Clone()
		{
			return new GetPlayerReturnMultiDropInfoScRsp(this);
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06005533 RID: 21811 RVA: 0x000E4D0D File Offset: 0x000E2F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HMDAGOFFLED> AHMGFCCBCBN
		{
			get
			{
				return this.aHMGFCCBCBN_;
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06005534 RID: 21812 RVA: 0x000E4D15 File Offset: 0x000E2F15
		// (set) Token: 0x06005535 RID: 21813 RVA: 0x000E4D1D File Offset: 0x000E2F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BJKLPGEPCPO MENNNHOCNCC
		{
			get
			{
				return this.mENNNHOCNCC_;
			}
			set
			{
				this.mENNNHOCNCC_ = value;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06005536 RID: 21814 RVA: 0x000E4D26 File Offset: 0x000E2F26
		// (set) Token: 0x06005537 RID: 21815 RVA: 0x000E4D2E File Offset: 0x000E2F2E
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

		// Token: 0x06005538 RID: 21816 RVA: 0x000E4D37 File Offset: 0x000E2F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerReturnMultiDropInfoScRsp);
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x000E4D48 File Offset: 0x000E2F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPlayerReturnMultiDropInfoScRsp other)
		{
			return other != null && (other == this || (this.aHMGFCCBCBN_.Equals(other.aHMGFCCBCBN_) && object.Equals(this.MENNNHOCNCC, other.MENNNHOCNCC) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x000E4DAC File Offset: 0x000E2FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aHMGFCCBCBN_.GetHashCode();
			if (this.mENNNHOCNCC_ != null)
			{
				num ^= this.MENNNHOCNCC.GetHashCode();
			}
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

		// Token: 0x0600553B RID: 21819 RVA: 0x000E4E0F File Offset: 0x000E300F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x000E4E17 File Offset: 0x000E3017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x000E4E20 File Offset: 0x000E3020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mENNNHOCNCC_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MENNNHOCNCC);
			}
			this.aHMGFCCBCBN_.WriteTo(ref output, GetPlayerReturnMultiDropInfoScRsp._repeated_aHMGFCCBCBN_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x000E4E8C File Offset: 0x000E308C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aHMGFCCBCBN_.CalculateSize(GetPlayerReturnMultiDropInfoScRsp._repeated_aHMGFCCBCBN_codec);
			if (this.mENNNHOCNCC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MENNNHOCNCC);
			}
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

		// Token: 0x0600553F RID: 21823 RVA: 0x000E4EF8 File Offset: 0x000E30F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPlayerReturnMultiDropInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.aHMGFCCBCBN_.Add(other.aHMGFCCBCBN_);
			if (other.mENNNHOCNCC_ != null)
			{
				if (this.mENNNHOCNCC_ == null)
				{
					this.MENNNHOCNCC = new BJKLPGEPCPO();
				}
				this.MENNNHOCNCC.MergeFrom(other.MENNNHOCNCC);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x000E4F71 File Offset: 0x000E3171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x000E4F7C File Offset: 0x000E317C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 50U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.aHMGFCCBCBN_.AddEntriesFrom(ref input, GetPlayerReturnMultiDropInfoScRsp._repeated_aHMGFCCBCBN_codec);
					}
				}
				else
				{
					if (this.mENNNHOCNCC_ == null)
					{
						this.MENNNHOCNCC = new BJKLPGEPCPO();
					}
					input.ReadMessage(this.MENNNHOCNCC);
				}
			}
		}

		// Token: 0x04002163 RID: 8547
		private static readonly MessageParser<GetPlayerReturnMultiDropInfoScRsp> _parser = new MessageParser<GetPlayerReturnMultiDropInfoScRsp>(() => new GetPlayerReturnMultiDropInfoScRsp());

		// Token: 0x04002164 RID: 8548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002165 RID: 8549
		public const int AHMGFCCBCBNFieldNumber = 6;

		// Token: 0x04002166 RID: 8550
		private static readonly FieldCodec<HMDAGOFFLED> _repeated_aHMGFCCBCBN_codec = FieldCodec.ForMessage<HMDAGOFFLED>(50U, HMDAGOFFLED.Parser);

		// Token: 0x04002167 RID: 8551
		private readonly RepeatedField<HMDAGOFFLED> aHMGFCCBCBN_ = new RepeatedField<HMDAGOFFLED>();

		// Token: 0x04002168 RID: 8552
		public const int MENNNHOCNCCFieldNumber = 3;

		// Token: 0x04002169 RID: 8553
		private BJKLPGEPCPO mENNNHOCNCC_;

		// Token: 0x0400216A RID: 8554
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400216B RID: 8555
		private uint retcode_;
	}
}
