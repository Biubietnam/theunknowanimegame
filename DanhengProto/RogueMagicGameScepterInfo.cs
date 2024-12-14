using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ED7 RID: 3799
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGameScepterInfo : IMessage<RogueMagicGameScepterInfo>, IMessage, IEquatable<RogueMagicGameScepterInfo>, IDeepCloneable<RogueMagicGameScepterInfo>, IBufferMessage
	{
		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x0600A9D1 RID: 43473 RVA: 0x001C97C7 File Offset: 0x001C79C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGameScepterInfo> Parser
		{
			get
			{
				return RogueMagicGameScepterInfo._parser;
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x0600A9D2 RID: 43474 RVA: 0x001C97CE File Offset: 0x001C79CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameScepterInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x0600A9D3 RID: 43475 RVA: 0x001C97E0 File Offset: 0x001C79E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGameScepterInfo.Descriptor;
			}
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x001C97E7 File Offset: 0x001C79E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameScepterInfo()
		{
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x001C9810 File Offset: 0x001C7A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameScepterInfo(RogueMagicGameScepterInfo other) : this()
		{
			this.trenchCount_ = other.trenchCount_.Clone();
			this.lockedMagicUnitList_ = other.lockedMagicUnitList_.Clone();
			this.modifierContent_ = ((other.modifierContent_ != null) ? other.modifierContent_.Clone() : null);
			this.scepterDressInfo_ = other.scepterDressInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9D6 RID: 43478 RVA: 0x001C9883 File Offset: 0x001C7A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameScepterInfo Clone()
		{
			return new RogueMagicGameScepterInfo(this);
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x0600A9D7 RID: 43479 RVA: 0x001C988B File Offset: 0x001C7A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> TrenchCount
		{
			get
			{
				return this.trenchCount_;
			}
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x0600A9D8 RID: 43480 RVA: 0x001C9893 File Offset: 0x001C7A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicGameUnit> LockedMagicUnitList
		{
			get
			{
				return this.lockedMagicUnitList_;
			}
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x0600A9D9 RID: 43481 RVA: 0x001C989B File Offset: 0x001C7A9B
		// (set) Token: 0x0600A9DA RID: 43482 RVA: 0x001C98A3 File Offset: 0x001C7AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepter ModifierContent
		{
			get
			{
				return this.modifierContent_;
			}
			set
			{
				this.modifierContent_ = value;
			}
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x0600A9DB RID: 43483 RVA: 0x001C98AC File Offset: 0x001C7AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicScepterDressInfo> ScepterDressInfo
		{
			get
			{
				return this.scepterDressInfo_;
			}
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x001C98B4 File Offset: 0x001C7AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGameScepterInfo);
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x001C98C4 File Offset: 0x001C7AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGameScepterInfo other)
		{
			return other != null && (other == this || (this.TrenchCount.Equals(other.TrenchCount) && this.lockedMagicUnitList_.Equals(other.lockedMagicUnitList_) && object.Equals(this.ModifierContent, other.ModifierContent) && this.scepterDressInfo_.Equals(other.scepterDressInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x001C9944 File Offset: 0x001C7B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.TrenchCount.GetHashCode();
			num ^= this.lockedMagicUnitList_.GetHashCode();
			if (this.modifierContent_ != null)
			{
				num ^= this.ModifierContent.GetHashCode();
			}
			num ^= this.scepterDressInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x001C99AA File Offset: 0x001C7BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x001C99B2 File Offset: 0x001C7BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x001C99BC File Offset: 0x001C7BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trenchCount_.WriteTo(ref output, RogueMagicGameScepterInfo._map_trenchCount_codec);
			this.scepterDressInfo_.WriteTo(ref output, RogueMagicGameScepterInfo._repeated_scepterDressInfo_codec);
			if (this.modifierContent_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ModifierContent);
			}
			this.lockedMagicUnitList_.WriteTo(ref output, RogueMagicGameScepterInfo._repeated_lockedMagicUnitList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x001C9A2C File Offset: 0x001C7C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trenchCount_.CalculateSize(RogueMagicGameScepterInfo._map_trenchCount_codec);
			num += this.lockedMagicUnitList_.CalculateSize(RogueMagicGameScepterInfo._repeated_lockedMagicUnitList_codec);
			if (this.modifierContent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ModifierContent);
			}
			num += this.scepterDressInfo_.CalculateSize(RogueMagicGameScepterInfo._repeated_scepterDressInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A9E3 RID: 43491 RVA: 0x001C9AA4 File Offset: 0x001C7CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGameScepterInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.trenchCount_.MergeFrom(other.trenchCount_);
			this.lockedMagicUnitList_.Add(other.lockedMagicUnitList_);
			if (other.modifierContent_ != null)
			{
				if (this.modifierContent_ == null)
				{
					this.ModifierContent = new RogueMagicScepter();
				}
				this.ModifierContent.MergeFrom(other.ModifierContent);
			}
			this.scepterDressInfo_.Add(other.scepterDressInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A9E4 RID: 43492 RVA: 0x001C9B2B File Offset: 0x001C7D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9E5 RID: 43493 RVA: 0x001C9B34 File Offset: 0x001C7D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 34U)
					{
						this.trenchCount_.AddEntriesFrom(ref input, RogueMagicGameScepterInfo._map_trenchCount_codec);
						continue;
					}
					if (num == 42U)
					{
						this.scepterDressInfo_.AddEntriesFrom(ref input, RogueMagicGameScepterInfo._repeated_scepterDressInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.modifierContent_ == null)
						{
							this.ModifierContent = new RogueMagicScepter();
						}
						input.ReadMessage(this.ModifierContent);
						continue;
					}
					if (num == 82U)
					{
						this.lockedMagicUnitList_.AddEntriesFrom(ref input, RogueMagicGameScepterInfo._repeated_lockedMagicUnitList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004554 RID: 17748
		private static readonly MessageParser<RogueMagicGameScepterInfo> _parser = new MessageParser<RogueMagicGameScepterInfo>(() => new RogueMagicGameScepterInfo());

		// Token: 0x04004555 RID: 17749
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004556 RID: 17750
		public const int TrenchCountFieldNumber = 4;

		// Token: 0x04004557 RID: 17751
		private static readonly MapField<uint, uint>.Codec _map_trenchCount_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 34U);

		// Token: 0x04004558 RID: 17752
		private readonly MapField<uint, uint> trenchCount_ = new MapField<uint, uint>();

		// Token: 0x04004559 RID: 17753
		public const int LockedMagicUnitListFieldNumber = 10;

		// Token: 0x0400455A RID: 17754
		private static readonly FieldCodec<RogueMagicGameUnit> _repeated_lockedMagicUnitList_codec = FieldCodec.ForMessage<RogueMagicGameUnit>(82U, RogueMagicGameUnit.Parser);

		// Token: 0x0400455B RID: 17755
		private readonly RepeatedField<RogueMagicGameUnit> lockedMagicUnitList_ = new RepeatedField<RogueMagicGameUnit>();

		// Token: 0x0400455C RID: 17756
		public const int ModifierContentFieldNumber = 8;

		// Token: 0x0400455D RID: 17757
		private RogueMagicScepter modifierContent_;

		// Token: 0x0400455E RID: 17758
		public const int ScepterDressInfoFieldNumber = 5;

		// Token: 0x0400455F RID: 17759
		private static readonly FieldCodec<RogueMagicScepterDressInfo> _repeated_scepterDressInfo_codec = FieldCodec.ForMessage<RogueMagicScepterDressInfo>(42U, RogueMagicScepterDressInfo.Parser);

		// Token: 0x04004560 RID: 17760
		private readonly RepeatedField<RogueMagicScepterDressInfo> scepterDressInfo_ = new RepeatedField<RogueMagicScepterDressInfo>();
	}
}
