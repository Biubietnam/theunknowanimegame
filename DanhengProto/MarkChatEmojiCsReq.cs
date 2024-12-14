using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A85 RID: 2693
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MarkChatEmojiCsReq : IMessage<MarkChatEmojiCsReq>, IMessage, IEquatable<MarkChatEmojiCsReq>, IDeepCloneable<MarkChatEmojiCsReq>, IBufferMessage
	{
		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x06007760 RID: 30560 RVA: 0x0013CA94 File Offset: 0x0013AC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkChatEmojiCsReq> Parser
		{
			get
			{
				return MarkChatEmojiCsReq._parser;
			}
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x06007761 RID: 30561 RVA: 0x0013CA9B File Offset: 0x0013AC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MarkChatEmojiCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x06007762 RID: 30562 RVA: 0x0013CAAD File Offset: 0x0013ACAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkChatEmojiCsReq.Descriptor;
			}
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x0013CAB4 File Offset: 0x0013ACB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkChatEmojiCsReq()
		{
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x0013CABC File Offset: 0x0013ACBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkChatEmojiCsReq(MarkChatEmojiCsReq other) : this()
		{
			this.extraId_ = other.extraId_;
			this.isRemoveId_ = other.isRemoveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x0013CAED File Offset: 0x0013ACED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkChatEmojiCsReq Clone()
		{
			return new MarkChatEmojiCsReq(this);
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06007766 RID: 30566 RVA: 0x0013CAF5 File Offset: 0x0013ACF5
		// (set) Token: 0x06007767 RID: 30567 RVA: 0x0013CAFD File Offset: 0x0013ACFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ExtraId
		{
			get
			{
				return this.extraId_;
			}
			set
			{
				this.extraId_ = value;
			}
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06007768 RID: 30568 RVA: 0x0013CB06 File Offset: 0x0013AD06
		// (set) Token: 0x06007769 RID: 30569 RVA: 0x0013CB0E File Offset: 0x0013AD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRemoveId
		{
			get
			{
				return this.isRemoveId_;
			}
			set
			{
				this.isRemoveId_ = value;
			}
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x0013CB17 File Offset: 0x0013AD17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkChatEmojiCsReq);
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x0013CB25 File Offset: 0x0013AD25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkChatEmojiCsReq other)
		{
			return other != null && (other == this || (this.ExtraId == other.ExtraId && this.IsRemoveId == other.IsRemoveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x0013CB64 File Offset: 0x0013AD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExtraId != 0U)
			{
				num ^= this.ExtraId.GetHashCode();
			}
			if (this.IsRemoveId)
			{
				num ^= this.IsRemoveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x0013CBBC File Offset: 0x0013ADBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x0013CBC4 File Offset: 0x0013ADC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x0013CBD0 File Offset: 0x0013ADD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsRemoveId)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsRemoveId);
			}
			if (this.ExtraId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ExtraId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x0013CC2C File Offset: 0x0013AE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExtraId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExtraId);
			}
			if (this.IsRemoveId)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x0013CC78 File Offset: 0x0013AE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkChatEmojiCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExtraId != 0U)
			{
				this.ExtraId = other.ExtraId;
			}
			if (other.IsRemoveId)
			{
				this.IsRemoveId = other.IsRemoveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x0013CCC8 File Offset: 0x0013AEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x0013CCD4 File Offset: 0x0013AED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ExtraId = input.ReadUInt32();
					}
				}
				else
				{
					this.IsRemoveId = input.ReadBool();
				}
			}
		}

		// Token: 0x04002DD8 RID: 11736
		private static readonly MessageParser<MarkChatEmojiCsReq> _parser = new MessageParser<MarkChatEmojiCsReq>(() => new MarkChatEmojiCsReq());

		// Token: 0x04002DD9 RID: 11737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DDA RID: 11738
		public const int ExtraIdFieldNumber = 15;

		// Token: 0x04002DDB RID: 11739
		private uint extraId_;

		// Token: 0x04002DDC RID: 11740
		public const int IsRemoveIdFieldNumber = 4;

		// Token: 0x04002DDD RID: 11741
		private bool isRemoveId_;
	}
}
