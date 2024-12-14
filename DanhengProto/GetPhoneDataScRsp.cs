using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200075F RID: 1887
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPhoneDataScRsp : IMessage<GetPhoneDataScRsp>, IMessage, IEquatable<GetPhoneDataScRsp>, IDeepCloneable<GetPhoneDataScRsp>, IBufferMessage
	{
		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x0600544E RID: 21582 RVA: 0x000E2AE7 File Offset: 0x000E0CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPhoneDataScRsp> Parser
		{
			get
			{
				return GetPhoneDataScRsp._parser;
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x0600544F RID: 21583 RVA: 0x000E2AEE File Offset: 0x000E0CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPhoneDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06005450 RID: 21584 RVA: 0x000E2B00 File Offset: 0x000E0D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPhoneDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x000E2B07 File Offset: 0x000E0D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPhoneDataScRsp()
		{
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x000E2B28 File Offset: 0x000E0D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPhoneDataScRsp(GetPhoneDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.ownedPhoneThemes_ = other.ownedPhoneThemes_.Clone();
			this.ownedChatBubbles_ = other.ownedChatBubbles_.Clone();
			this.curPhoneTheme_ = other.curPhoneTheme_;
			this.curChatBubble_ = other.curChatBubble_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x000E2B92 File Offset: 0x000E0D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPhoneDataScRsp Clone()
		{
			return new GetPhoneDataScRsp(this);
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06005454 RID: 21588 RVA: 0x000E2B9A File Offset: 0x000E0D9A
		// (set) Token: 0x06005455 RID: 21589 RVA: 0x000E2BA2 File Offset: 0x000E0DA2
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

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06005456 RID: 21590 RVA: 0x000E2BAB File Offset: 0x000E0DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> OwnedPhoneThemes
		{
			get
			{
				return this.ownedPhoneThemes_;
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06005457 RID: 21591 RVA: 0x000E2BB3 File Offset: 0x000E0DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> OwnedChatBubbles
		{
			get
			{
				return this.ownedChatBubbles_;
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06005458 RID: 21592 RVA: 0x000E2BBB File Offset: 0x000E0DBB
		// (set) Token: 0x06005459 RID: 21593 RVA: 0x000E2BC3 File Offset: 0x000E0DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurPhoneTheme
		{
			get
			{
				return this.curPhoneTheme_;
			}
			set
			{
				this.curPhoneTheme_ = value;
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x0600545A RID: 21594 RVA: 0x000E2BCC File Offset: 0x000E0DCC
		// (set) Token: 0x0600545B RID: 21595 RVA: 0x000E2BD4 File Offset: 0x000E0DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurChatBubble
		{
			get
			{
				return this.curChatBubble_;
			}
			set
			{
				this.curChatBubble_ = value;
			}
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x000E2BDD File Offset: 0x000E0DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPhoneDataScRsp);
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x000E2BEC File Offset: 0x000E0DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPhoneDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.ownedPhoneThemes_.Equals(other.ownedPhoneThemes_) && this.ownedChatBubbles_.Equals(other.ownedChatBubbles_) && this.CurPhoneTheme == other.CurPhoneTheme && this.CurChatBubble == other.CurChatBubble && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x000E2C70 File Offset: 0x000E0E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.ownedPhoneThemes_.GetHashCode();
			num ^= this.ownedChatBubbles_.GetHashCode();
			if (this.CurPhoneTheme != 0U)
			{
				num ^= this.CurPhoneTheme.GetHashCode();
			}
			if (this.CurChatBubble != 0U)
			{
				num ^= this.CurChatBubble.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x000E2CFD File Offset: 0x000E0EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x000E2D05 File Offset: 0x000E0F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x000E2D10 File Offset: 0x000E0F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ownedPhoneThemes_.WriteTo(ref output, GetPhoneDataScRsp._repeated_ownedPhoneThemes_codec);
			if (this.CurPhoneTheme != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.CurPhoneTheme);
			}
			this.ownedChatBubbles_.WriteTo(ref output, GetPhoneDataScRsp._repeated_ownedChatBubbles_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CurChatBubble != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.CurChatBubble);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x000E2DA8 File Offset: 0x000E0FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.ownedPhoneThemes_.CalculateSize(GetPhoneDataScRsp._repeated_ownedPhoneThemes_codec);
			num += this.ownedChatBubbles_.CalculateSize(GetPhoneDataScRsp._repeated_ownedChatBubbles_codec);
			if (this.CurPhoneTheme != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurPhoneTheme);
			}
			if (this.CurChatBubble != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurChatBubble);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x000E2E3C File Offset: 0x000E103C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPhoneDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.ownedPhoneThemes_.Add(other.ownedPhoneThemes_);
			this.ownedChatBubbles_.Add(other.ownedChatBubbles_);
			if (other.CurPhoneTheme != 0U)
			{
				this.CurPhoneTheme = other.CurPhoneTheme;
			}
			if (other.CurChatBubble != 0U)
			{
				this.CurChatBubble = other.CurChatBubble;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x000E2EC2 File Offset: 0x000E10C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x000E2ECC File Offset: 0x000E10CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 8U || num == 10U)
					{
						this.ownedPhoneThemes_.AddEntriesFrom(ref input, GetPhoneDataScRsp._repeated_ownedPhoneThemes_codec);
						continue;
					}
					if (num == 40U)
					{
						this.CurPhoneTheme = input.ReadUInt32();
						continue;
					}
				}
				else if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.ownedChatBubbles_.AddEntriesFrom(ref input, GetPhoneDataScRsp._repeated_ownedChatBubbles_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.CurChatBubble = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002116 RID: 8470
		private static readonly MessageParser<GetPhoneDataScRsp> _parser = new MessageParser<GetPhoneDataScRsp>(() => new GetPhoneDataScRsp());

		// Token: 0x04002117 RID: 8471
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002118 RID: 8472
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04002119 RID: 8473
		private uint retcode_;

		// Token: 0x0400211A RID: 8474
		public const int OwnedPhoneThemesFieldNumber = 1;

		// Token: 0x0400211B RID: 8475
		private static readonly FieldCodec<uint> _repeated_ownedPhoneThemes_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400211C RID: 8476
		private readonly RepeatedField<uint> ownedPhoneThemes_ = new RepeatedField<uint>();

		// Token: 0x0400211D RID: 8477
		public const int OwnedChatBubblesFieldNumber = 7;

		// Token: 0x0400211E RID: 8478
		private static readonly FieldCodec<uint> _repeated_ownedChatBubbles_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x0400211F RID: 8479
		private readonly RepeatedField<uint> ownedChatBubbles_ = new RepeatedField<uint>();

		// Token: 0x04002120 RID: 8480
		public const int CurPhoneThemeFieldNumber = 5;

		// Token: 0x04002121 RID: 8481
		private uint curPhoneTheme_;

		// Token: 0x04002122 RID: 8482
		public const int CurChatBubbleFieldNumber = 13;

		// Token: 0x04002123 RID: 8483
		private uint curChatBubble_;
	}
}
