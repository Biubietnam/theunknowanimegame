using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200130D RID: 4877
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakePromotionRewardCsReq : IMessage<TakePromotionRewardCsReq>, IMessage, IEquatable<TakePromotionRewardCsReq>, IDeepCloneable<TakePromotionRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x0600D992 RID: 55698 RVA: 0x00243B09 File Offset: 0x00241D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakePromotionRewardCsReq> Parser
		{
			get
			{
				return TakePromotionRewardCsReq._parser;
			}
		}

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x0600D993 RID: 55699 RVA: 0x00243B10 File Offset: 0x00241D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakePromotionRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x0600D994 RID: 55700 RVA: 0x00243B22 File Offset: 0x00241D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakePromotionRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D995 RID: 55701 RVA: 0x00243B29 File Offset: 0x00241D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePromotionRewardCsReq()
		{
		}

		// Token: 0x0600D996 RID: 55702 RVA: 0x00243B31 File Offset: 0x00241D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePromotionRewardCsReq(TakePromotionRewardCsReq other) : this()
		{
			this.baseAvatarId_ = other.baseAvatarId_;
			this.promotion_ = other.promotion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D997 RID: 55703 RVA: 0x00243B62 File Offset: 0x00241D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePromotionRewardCsReq Clone()
		{
			return new TakePromotionRewardCsReq(this);
		}

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x0600D998 RID: 55704 RVA: 0x00243B6A File Offset: 0x00241D6A
		// (set) Token: 0x0600D999 RID: 55705 RVA: 0x00243B72 File Offset: 0x00241D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x0600D99A RID: 55706 RVA: 0x00243B7B File Offset: 0x00241D7B
		// (set) Token: 0x0600D99B RID: 55707 RVA: 0x00243B83 File Offset: 0x00241D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Promotion
		{
			get
			{
				return this.promotion_;
			}
			set
			{
				this.promotion_ = value;
			}
		}

		// Token: 0x0600D99C RID: 55708 RVA: 0x00243B8C File Offset: 0x00241D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakePromotionRewardCsReq);
		}

		// Token: 0x0600D99D RID: 55709 RVA: 0x00243B9A File Offset: 0x00241D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakePromotionRewardCsReq other)
		{
			return other != null && (other == this || (this.BaseAvatarId == other.BaseAvatarId && this.Promotion == other.Promotion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D99E RID: 55710 RVA: 0x00243BD8 File Offset: 0x00241DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D99F RID: 55711 RVA: 0x00243C30 File Offset: 0x00241E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D9A0 RID: 55712 RVA: 0x00243C38 File Offset: 0x00241E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9A1 RID: 55713 RVA: 0x00243C44 File Offset: 0x00241E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Promotion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D9A2 RID: 55714 RVA: 0x00243CA0 File Offset: 0x00241EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D9A3 RID: 55715 RVA: 0x00243CF8 File Offset: 0x00241EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakePromotionRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D9A4 RID: 55716 RVA: 0x00243D48 File Offset: 0x00241F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9A5 RID: 55717 RVA: 0x00243D54 File Offset: 0x00241F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Promotion = input.ReadUInt32();
					}
				}
				else
				{
					this.BaseAvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040056B2 RID: 22194
		private static readonly MessageParser<TakePromotionRewardCsReq> _parser = new MessageParser<TakePromotionRewardCsReq>(() => new TakePromotionRewardCsReq());

		// Token: 0x040056B3 RID: 22195
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056B4 RID: 22196
		public const int BaseAvatarIdFieldNumber = 9;

		// Token: 0x040056B5 RID: 22197
		private uint baseAvatarId_;

		// Token: 0x040056B6 RID: 22198
		public const int PromotionFieldNumber = 13;

		// Token: 0x040056B7 RID: 22199
		private uint promotion_;
	}
}
