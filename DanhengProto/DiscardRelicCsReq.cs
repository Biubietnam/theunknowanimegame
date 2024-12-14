using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003A5 RID: 933
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DiscardRelicCsReq : IMessage<DiscardRelicCsReq>, IMessage, IEquatable<DiscardRelicCsReq>, IDeepCloneable<DiscardRelicCsReq>, IBufferMessage
	{
		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x00073161 File Offset: 0x00071361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DiscardRelicCsReq> Parser
		{
			get
			{
				return DiscardRelicCsReq._parser;
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002969 RID: 10601 RVA: 0x00073168 File Offset: 0x00071368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DiscardRelicCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x0007317A File Offset: 0x0007137A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiscardRelicCsReq.Descriptor;
			}
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00073181 File Offset: 0x00071381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardRelicCsReq()
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00073194 File Offset: 0x00071394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardRelicCsReq(DiscardRelicCsReq other) : this()
		{
			this.isDiscard_ = other.isDiscard_;
			this.oKKJFIBNGCE_ = other.oKKJFIBNGCE_;
			this.relicUniqueIdList_ = other.relicUniqueIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x000731E1 File Offset: 0x000713E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardRelicCsReq Clone()
		{
			return new DiscardRelicCsReq(this);
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x000731E9 File Offset: 0x000713E9
		// (set) Token: 0x0600296F RID: 10607 RVA: 0x000731F1 File Offset: 0x000713F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDiscard
		{
			get
			{
				return this.isDiscard_;
			}
			set
			{
				this.isDiscard_ = value;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x000731FA File Offset: 0x000713FA
		// (set) Token: 0x06002971 RID: 10609 RVA: 0x00073202 File Offset: 0x00071402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OKKJFIBNGCE
		{
			get
			{
				return this.oKKJFIBNGCE_;
			}
			set
			{
				this.oKKJFIBNGCE_ = value;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x0007320B File Offset: 0x0007140B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> RelicUniqueIdList
		{
			get
			{
				return this.relicUniqueIdList_;
			}
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00073213 File Offset: 0x00071413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiscardRelicCsReq);
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00073224 File Offset: 0x00071424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DiscardRelicCsReq other)
		{
			return other != null && (other == this || (this.IsDiscard == other.IsDiscard && this.OKKJFIBNGCE == other.OKKJFIBNGCE && this.relicUniqueIdList_.Equals(other.relicUniqueIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00073284 File Offset: 0x00071484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsDiscard)
			{
				num ^= this.IsDiscard.GetHashCode();
			}
			if (this.OKKJFIBNGCE)
			{
				num ^= this.OKKJFIBNGCE.GetHashCode();
			}
			num ^= this.relicUniqueIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000732EA File Offset: 0x000714EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000732F2 File Offset: 0x000714F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000732FC File Offset: 0x000714FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsDiscard)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsDiscard);
			}
			this.relicUniqueIdList_.WriteTo(ref output, DiscardRelicCsReq._repeated_relicUniqueIdList_codec);
			if (this.OKKJFIBNGCE)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.OKKJFIBNGCE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00073368 File Offset: 0x00071568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsDiscard)
			{
				num += 2;
			}
			if (this.OKKJFIBNGCE)
			{
				num += 2;
			}
			num += this.relicUniqueIdList_.CalculateSize(DiscardRelicCsReq._repeated_relicUniqueIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000733BC File Offset: 0x000715BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DiscardRelicCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsDiscard)
			{
				this.IsDiscard = other.IsDiscard;
			}
			if (other.OKKJFIBNGCE)
			{
				this.OKKJFIBNGCE = other.OKKJFIBNGCE;
			}
			this.relicUniqueIdList_.Add(other.relicUniqueIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x0007341D File Offset: 0x0007161D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00073428 File Offset: 0x00071628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 24U)
					{
						this.IsDiscard = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						goto IL_3F;
					}
				}
				else
				{
					if (num == 82U)
					{
						goto IL_3F;
					}
					if (num == 88U)
					{
						this.OKKJFIBNGCE = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_3F:
				this.relicUniqueIdList_.AddEntriesFrom(ref input, DiscardRelicCsReq._repeated_relicUniqueIdList_codec);
			}
		}

		// Token: 0x040010B2 RID: 4274
		private static readonly MessageParser<DiscardRelicCsReq> _parser = new MessageParser<DiscardRelicCsReq>(() => new DiscardRelicCsReq());

		// Token: 0x040010B3 RID: 4275
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010B4 RID: 4276
		public const int IsDiscardFieldNumber = 3;

		// Token: 0x040010B5 RID: 4277
		private bool isDiscard_;

		// Token: 0x040010B6 RID: 4278
		public const int OKKJFIBNGCEFieldNumber = 11;

		// Token: 0x040010B7 RID: 4279
		private bool oKKJFIBNGCE_;

		// Token: 0x040010B8 RID: 4280
		public const int RelicUniqueIdListFieldNumber = 10;

		// Token: 0x040010B9 RID: 4281
		private static readonly FieldCodec<uint> _repeated_relicUniqueIdList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x040010BA RID: 4282
		private readonly RepeatedField<uint> relicUniqueIdList_ = new RepeatedField<uint>();
	}
}
