using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D9B RID: 3483
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Relic : IMessage<Relic>, IMessage, IEquatable<Relic>, IDeepCloneable<Relic>, IBufferMessage
	{
		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x06009B92 RID: 39826 RVA: 0x0019E064 File Offset: 0x0019C264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Relic> Parser
		{
			get
			{
				return Relic._parser;
			}
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x06009B93 RID: 39827 RVA: 0x0019E06B File Offset: 0x0019C26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x06009B94 RID: 39828 RVA: 0x0019E07D File Offset: 0x0019C27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Relic.Descriptor;
			}
		}

		// Token: 0x06009B95 RID: 39829 RVA: 0x0019E084 File Offset: 0x0019C284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Relic()
		{
		}

		// Token: 0x06009B96 RID: 39830 RVA: 0x0019E098 File Offset: 0x0019C298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Relic(Relic other) : this()
		{
			this.dressAvatarId_ = other.dressAvatarId_;
			this.level_ = other.level_;
			this.mainAffixId_ = other.mainAffixId_;
			this.uniqueId_ = other.uniqueId_;
			this.tid_ = other.tid_;
			this.subAffixList_ = other.subAffixList_.Clone();
			this.isDiscarded_ = other.isDiscarded_;
			this.exp_ = other.exp_;
			this.isProtected_ = other.isProtected_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B97 RID: 39831 RVA: 0x0019E12D File Offset: 0x0019C32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Relic Clone()
		{
			return new Relic(this);
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x06009B98 RID: 39832 RVA: 0x0019E135 File Offset: 0x0019C335
		// (set) Token: 0x06009B99 RID: 39833 RVA: 0x0019E13D File Offset: 0x0019C33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DressAvatarId
		{
			get
			{
				return this.dressAvatarId_;
			}
			set
			{
				this.dressAvatarId_ = value;
			}
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x06009B9A RID: 39834 RVA: 0x0019E146 File Offset: 0x0019C346
		// (set) Token: 0x06009B9B RID: 39835 RVA: 0x0019E14E File Offset: 0x0019C34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x06009B9C RID: 39836 RVA: 0x0019E157 File Offset: 0x0019C357
		// (set) Token: 0x06009B9D RID: 39837 RVA: 0x0019E15F File Offset: 0x0019C35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainAffixId
		{
			get
			{
				return this.mainAffixId_;
			}
			set
			{
				this.mainAffixId_ = value;
			}
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x06009B9E RID: 39838 RVA: 0x0019E168 File Offset: 0x0019C368
		// (set) Token: 0x06009B9F RID: 39839 RVA: 0x0019E170 File Offset: 0x0019C370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x06009BA0 RID: 39840 RVA: 0x0019E179 File Offset: 0x0019C379
		// (set) Token: 0x06009BA1 RID: 39841 RVA: 0x0019E181 File Offset: 0x0019C381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Tid
		{
			get
			{
				return this.tid_;
			}
			set
			{
				this.tid_ = value;
			}
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x06009BA2 RID: 39842 RVA: 0x0019E18A File Offset: 0x0019C38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RelicAffix> SubAffixList
		{
			get
			{
				return this.subAffixList_;
			}
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x06009BA3 RID: 39843 RVA: 0x0019E192 File Offset: 0x0019C392
		// (set) Token: 0x06009BA4 RID: 39844 RVA: 0x0019E19A File Offset: 0x0019C39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDiscarded
		{
			get
			{
				return this.isDiscarded_;
			}
			set
			{
				this.isDiscarded_ = value;
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x06009BA5 RID: 39845 RVA: 0x0019E1A3 File Offset: 0x0019C3A3
		// (set) Token: 0x06009BA6 RID: 39846 RVA: 0x0019E1AB File Offset: 0x0019C3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x06009BA7 RID: 39847 RVA: 0x0019E1B4 File Offset: 0x0019C3B4
		// (set) Token: 0x06009BA8 RID: 39848 RVA: 0x0019E1BC File Offset: 0x0019C3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsProtected
		{
			get
			{
				return this.isProtected_;
			}
			set
			{
				this.isProtected_ = value;
			}
		}

		// Token: 0x06009BA9 RID: 39849 RVA: 0x0019E1C5 File Offset: 0x0019C3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Relic);
		}

		// Token: 0x06009BAA RID: 39850 RVA: 0x0019E1D4 File Offset: 0x0019C3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Relic other)
		{
			return other != null && (other == this || (this.DressAvatarId == other.DressAvatarId && this.Level == other.Level && this.MainAffixId == other.MainAffixId && this.UniqueId == other.UniqueId && this.Tid == other.Tid && this.subAffixList_.Equals(other.subAffixList_) && this.IsDiscarded == other.IsDiscarded && this.Exp == other.Exp && this.IsProtected == other.IsProtected && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009BAB RID: 39851 RVA: 0x0019E294 File Offset: 0x0019C494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DressAvatarId != 0U)
			{
				num ^= this.DressAvatarId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MainAffixId != 0U)
			{
				num ^= this.MainAffixId.GetHashCode();
			}
			if (this.UniqueId != 0U)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			num ^= this.subAffixList_.GetHashCode();
			if (this.IsDiscarded)
			{
				num ^= this.IsDiscarded.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.IsProtected)
			{
				num ^= this.IsProtected.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009BAC RID: 39852 RVA: 0x0019E390 File Offset: 0x0019C590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009BAD RID: 39853 RVA: 0x0019E398 File Offset: 0x0019C598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BAE RID: 39854 RVA: 0x0019E3A4 File Offset: 0x0019C5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Tid != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Tid);
			}
			this.subAffixList_.WriteTo(ref output, Relic._repeated_subAffixList_codec);
			if (this.MainAffixId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MainAffixId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Level);
			}
			if (this.DressAvatarId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.DressAvatarId);
			}
			if (this.UniqueId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.UniqueId);
			}
			if (this.IsDiscarded)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsDiscarded);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Exp);
			}
			if (this.IsProtected)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsProtected);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BAF RID: 39855 RVA: 0x0019E4B8 File Offset: 0x0019C6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DressAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DressAvatarId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.MainAffixId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainAffixId);
			}
			if (this.UniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UniqueId);
			}
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			num += this.subAffixList_.CalculateSize(Relic._repeated_subAffixList_codec);
			if (this.IsDiscarded)
			{
				num += 2;
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.IsProtected)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009BB0 RID: 39856 RVA: 0x0019E59C File Offset: 0x0019C79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Relic other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DressAvatarId != 0U)
			{
				this.DressAvatarId = other.DressAvatarId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.MainAffixId != 0U)
			{
				this.MainAffixId = other.MainAffixId;
			}
			if (other.UniqueId != 0U)
			{
				this.UniqueId = other.UniqueId;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			this.subAffixList_.Add(other.subAffixList_);
			if (other.IsDiscarded)
			{
				this.IsDiscarded = other.IsDiscarded;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.IsProtected)
			{
				this.IsProtected = other.IsProtected;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009BB1 RID: 39857 RVA: 0x0019E675 File Offset: 0x0019C875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x0019E680 File Offset: 0x0019C880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 42U)
					{
						if (num == 8U)
						{
							this.Tid = input.ReadUInt32();
							continue;
						}
						if (num == 42U)
						{
							this.subAffixList_.AddEntriesFrom(ref input, Relic._repeated_subAffixList_codec);
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.MainAffixId = input.ReadUInt32();
							continue;
						}
						if (num == 56U)
						{
							this.Level = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 64U)
					{
						this.DressAvatarId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.UniqueId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.IsDiscarded = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IsProtected = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C5E RID: 15454
		private static readonly MessageParser<Relic> _parser = new MessageParser<Relic>(() => new Relic());

		// Token: 0x04003C5F RID: 15455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C60 RID: 15456
		public const int DressAvatarIdFieldNumber = 8;

		// Token: 0x04003C61 RID: 15457
		private uint dressAvatarId_;

		// Token: 0x04003C62 RID: 15458
		public const int LevelFieldNumber = 7;

		// Token: 0x04003C63 RID: 15459
		private uint level_;

		// Token: 0x04003C64 RID: 15460
		public const int MainAffixIdFieldNumber = 6;

		// Token: 0x04003C65 RID: 15461
		private uint mainAffixId_;

		// Token: 0x04003C66 RID: 15462
		public const int UniqueIdFieldNumber = 11;

		// Token: 0x04003C67 RID: 15463
		private uint uniqueId_;

		// Token: 0x04003C68 RID: 15464
		public const int TidFieldNumber = 1;

		// Token: 0x04003C69 RID: 15465
		private uint tid_;

		// Token: 0x04003C6A RID: 15466
		public const int SubAffixListFieldNumber = 5;

		// Token: 0x04003C6B RID: 15467
		private static readonly FieldCodec<RelicAffix> _repeated_subAffixList_codec = FieldCodec.ForMessage<RelicAffix>(42U, RelicAffix.Parser);

		// Token: 0x04003C6C RID: 15468
		private readonly RepeatedField<RelicAffix> subAffixList_ = new RepeatedField<RelicAffix>();

		// Token: 0x04003C6D RID: 15469
		public const int IsDiscardedFieldNumber = 13;

		// Token: 0x04003C6E RID: 15470
		private bool isDiscarded_;

		// Token: 0x04003C6F RID: 15471
		public const int ExpFieldNumber = 14;

		// Token: 0x04003C70 RID: 15472
		private uint exp_;

		// Token: 0x04003C71 RID: 15473
		public const int IsProtectedFieldNumber = 15;

		// Token: 0x04003C72 RID: 15474
		private bool isProtected_;
	}
}
