using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001129 RID: 4393
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetRogueCollectionScRsp : IMessage<SetRogueCollectionScRsp>, IMessage, IEquatable<SetRogueCollectionScRsp>, IDeepCloneable<SetRogueCollectionScRsp>, IBufferMessage
	{
		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x0600C3E9 RID: 50153 RVA: 0x0020DE37 File Offset: 0x0020C037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetRogueCollectionScRsp> Parser
		{
			get
			{
				return SetRogueCollectionScRsp._parser;
			}
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x0600C3EA RID: 50154 RVA: 0x0020DE3E File Offset: 0x0020C03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetRogueCollectionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x0600C3EB RID: 50155 RVA: 0x0020DE50 File Offset: 0x0020C050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetRogueCollectionScRsp.Descriptor;
			}
		}

		// Token: 0x0600C3EC RID: 50156 RVA: 0x0020DE57 File Offset: 0x0020C057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueCollectionScRsp()
		{
		}

		// Token: 0x0600C3ED RID: 50157 RVA: 0x0020DE78 File Offset: 0x0020C078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueCollectionScRsp(SetRogueCollectionScRsp other) : this()
		{
			this.iNKHJFOPNAK_ = other.iNKHJFOPNAK_.Clone();
			this.retcode_ = other.retcode_;
			this.pKHKABEGPJF_ = other.pKHKABEGPJF_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3EE RID: 50158 RVA: 0x0020DECA File Offset: 0x0020C0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueCollectionScRsp Clone()
		{
			return new SetRogueCollectionScRsp(this);
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x0600C3EF RID: 50159 RVA: 0x0020DED2 File Offset: 0x0020C0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LAOKOJAIOPD> INKHJFOPNAK
		{
			get
			{
				return this.iNKHJFOPNAK_;
			}
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x0600C3F0 RID: 50160 RVA: 0x0020DEDA File Offset: 0x0020C0DA
		// (set) Token: 0x0600C3F1 RID: 50161 RVA: 0x0020DEE2 File Offset: 0x0020C0E2
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

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x0600C3F2 RID: 50162 RVA: 0x0020DEEB File Offset: 0x0020C0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HKMBKGENKBG> PKHKABEGPJF
		{
			get
			{
				return this.pKHKABEGPJF_;
			}
		}

		// Token: 0x0600C3F3 RID: 50163 RVA: 0x0020DEF3 File Offset: 0x0020C0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetRogueCollectionScRsp);
		}

		// Token: 0x0600C3F4 RID: 50164 RVA: 0x0020DF04 File Offset: 0x0020C104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetRogueCollectionScRsp other)
		{
			return other != null && (other == this || (this.iNKHJFOPNAK_.Equals(other.iNKHJFOPNAK_) && this.Retcode == other.Retcode && this.pKHKABEGPJF_.Equals(other.pKHKABEGPJF_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3F5 RID: 50165 RVA: 0x0020DF68 File Offset: 0x0020C168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.iNKHJFOPNAK_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.pKHKABEGPJF_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C3F6 RID: 50166 RVA: 0x0020DFC3 File Offset: 0x0020C1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C3F7 RID: 50167 RVA: 0x0020DFCB File Offset: 0x0020C1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3F8 RID: 50168 RVA: 0x0020DFD4 File Offset: 0x0020C1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pKHKABEGPJF_.WriteTo(ref output, SetRogueCollectionScRsp._repeated_pKHKABEGPJF_codec);
			this.iNKHJFOPNAK_.WriteTo(ref output, SetRogueCollectionScRsp._repeated_iNKHJFOPNAK_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3F9 RID: 50169 RVA: 0x0020E034 File Offset: 0x0020C234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.iNKHJFOPNAK_.CalculateSize(SetRogueCollectionScRsp._repeated_iNKHJFOPNAK_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.pKHKABEGPJF_.CalculateSize(SetRogueCollectionScRsp._repeated_pKHKABEGPJF_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C3FA RID: 50170 RVA: 0x0020E098 File Offset: 0x0020C298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetRogueCollectionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.iNKHJFOPNAK_.Add(other.iNKHJFOPNAK_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.pKHKABEGPJF_.Add(other.pKHKABEGPJF_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3FB RID: 50171 RVA: 0x0020E0F6 File Offset: 0x0020C2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3FC RID: 50172 RVA: 0x0020E100 File Offset: 0x0020C300
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
						if (num != 88U)
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
						this.iNKHJFOPNAK_.AddEntriesFrom(ref input, SetRogueCollectionScRsp._repeated_iNKHJFOPNAK_codec);
					}
				}
				else
				{
					this.pKHKABEGPJF_.AddEntriesFrom(ref input, SetRogueCollectionScRsp._repeated_pKHKABEGPJF_codec);
				}
			}
		}

		// Token: 0x04004F2A RID: 20266
		private static readonly MessageParser<SetRogueCollectionScRsp> _parser = new MessageParser<SetRogueCollectionScRsp>(() => new SetRogueCollectionScRsp());

		// Token: 0x04004F2B RID: 20267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F2C RID: 20268
		public const int INKHJFOPNAKFieldNumber = 6;

		// Token: 0x04004F2D RID: 20269
		private static readonly FieldCodec<LAOKOJAIOPD> _repeated_iNKHJFOPNAK_codec = FieldCodec.ForMessage<LAOKOJAIOPD>(50U, LAOKOJAIOPD.Parser);

		// Token: 0x04004F2E RID: 20270
		private readonly RepeatedField<LAOKOJAIOPD> iNKHJFOPNAK_ = new RepeatedField<LAOKOJAIOPD>();

		// Token: 0x04004F2F RID: 20271
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04004F30 RID: 20272
		private uint retcode_;

		// Token: 0x04004F31 RID: 20273
		public const int PKHKABEGPJFFieldNumber = 3;

		// Token: 0x04004F32 RID: 20274
		private static readonly FieldCodec<HKMBKGENKBG> _repeated_pKHKABEGPJF_codec = FieldCodec.ForMessage<HKMBKGENKBG>(26U, HKMBKGENKBG.Parser);

		// Token: 0x04004F33 RID: 20275
		private readonly RepeatedField<HKMBKGENKBG> pKHKABEGPJF_ = new RepeatedField<HKMBKGENKBG>();
	}
}
