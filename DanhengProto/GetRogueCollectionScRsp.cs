using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007AF RID: 1967
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueCollectionScRsp : IMessage<GetRogueCollectionScRsp>, IMessage, IEquatable<GetRogueCollectionScRsp>, IDeepCloneable<GetRogueCollectionScRsp>, IBufferMessage
	{
		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x060057CB RID: 22475 RVA: 0x000EAEFB File Offset: 0x000E90FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueCollectionScRsp> Parser
		{
			get
			{
				return GetRogueCollectionScRsp._parser;
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x060057CC RID: 22476 RVA: 0x000EAF02 File Offset: 0x000E9102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueCollectionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x060057CD RID: 22477 RVA: 0x000EAF14 File Offset: 0x000E9114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueCollectionScRsp.Descriptor;
			}
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x000EAF1B File Offset: 0x000E911B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCollectionScRsp()
		{
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x000EAF3C File Offset: 0x000E913C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCollectionScRsp(GetRogueCollectionScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.iNKHJFOPNAK_ = other.iNKHJFOPNAK_.Clone();
			this.pKHKABEGPJF_ = other.pKHKABEGPJF_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x000EAF8E File Offset: 0x000E918E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCollectionScRsp Clone()
		{
			return new GetRogueCollectionScRsp(this);
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x060057D1 RID: 22481 RVA: 0x000EAF96 File Offset: 0x000E9196
		// (set) Token: 0x060057D2 RID: 22482 RVA: 0x000EAF9E File Offset: 0x000E919E
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

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x060057D3 RID: 22483 RVA: 0x000EAFA7 File Offset: 0x000E91A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LAOKOJAIOPD> INKHJFOPNAK
		{
			get
			{
				return this.iNKHJFOPNAK_;
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x060057D4 RID: 22484 RVA: 0x000EAFAF File Offset: 0x000E91AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HKMBKGENKBG> PKHKABEGPJF
		{
			get
			{
				return this.pKHKABEGPJF_;
			}
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x000EAFB7 File Offset: 0x000E91B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueCollectionScRsp);
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x000EAFC8 File Offset: 0x000E91C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueCollectionScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.iNKHJFOPNAK_.Equals(other.iNKHJFOPNAK_) && this.pKHKABEGPJF_.Equals(other.pKHKABEGPJF_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x000EB02C File Offset: 0x000E922C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.iNKHJFOPNAK_.GetHashCode();
			num ^= this.pKHKABEGPJF_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x000EB087 File Offset: 0x000E9287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x000EB08F File Offset: 0x000E928F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x000EB098 File Offset: 0x000E9298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			this.pKHKABEGPJF_.WriteTo(ref output, GetRogueCollectionScRsp._repeated_pKHKABEGPJF_codec);
			this.iNKHJFOPNAK_.WriteTo(ref output, GetRogueCollectionScRsp._repeated_iNKHJFOPNAK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x000EB0F8 File Offset: 0x000E92F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.iNKHJFOPNAK_.CalculateSize(GetRogueCollectionScRsp._repeated_iNKHJFOPNAK_codec);
			num += this.pKHKABEGPJF_.CalculateSize(GetRogueCollectionScRsp._repeated_pKHKABEGPJF_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x000EB15C File Offset: 0x000E935C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueCollectionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.iNKHJFOPNAK_.Add(other.iNKHJFOPNAK_);
			this.pKHKABEGPJF_.Add(other.pKHKABEGPJF_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x000EB1BA File Offset: 0x000E93BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x000EB1C4 File Offset: 0x000E93C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 58U)
					{
						if (num != 66U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.iNKHJFOPNAK_.AddEntriesFrom(ref input, GetRogueCollectionScRsp._repeated_iNKHJFOPNAK_codec);
						}
					}
					else
					{
						this.pKHKABEGPJF_.AddEntriesFrom(ref input, GetRogueCollectionScRsp._repeated_pKHKABEGPJF_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002241 RID: 8769
		private static readonly MessageParser<GetRogueCollectionScRsp> _parser = new MessageParser<GetRogueCollectionScRsp>(() => new GetRogueCollectionScRsp());

		// Token: 0x04002242 RID: 8770
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002243 RID: 8771
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04002244 RID: 8772
		private uint retcode_;

		// Token: 0x04002245 RID: 8773
		public const int INKHJFOPNAKFieldNumber = 8;

		// Token: 0x04002246 RID: 8774
		private static readonly FieldCodec<LAOKOJAIOPD> _repeated_iNKHJFOPNAK_codec = FieldCodec.ForMessage<LAOKOJAIOPD>(66U, LAOKOJAIOPD.Parser);

		// Token: 0x04002247 RID: 8775
		private readonly RepeatedField<LAOKOJAIOPD> iNKHJFOPNAK_ = new RepeatedField<LAOKOJAIOPD>();

		// Token: 0x04002248 RID: 8776
		public const int PKHKABEGPJFFieldNumber = 7;

		// Token: 0x04002249 RID: 8777
		private static readonly FieldCodec<HKMBKGENKBG> _repeated_pKHKABEGPJF_codec = FieldCodec.ForMessage<HKMBKGENKBG>(58U, HKMBKGENKBG.Parser);

		// Token: 0x0400224A RID: 8778
		private readonly RepeatedField<HKMBKGENKBG> pKHKABEGPJF_ = new RepeatedField<HKMBKGENKBG>();
	}
}
