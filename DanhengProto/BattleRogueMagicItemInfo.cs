using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000F9 RID: 249
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleRogueMagicItemInfo : IMessage<BattleRogueMagicItemInfo>, IMessage, IEquatable<BattleRogueMagicItemInfo>, IDeepCloneable<BattleRogueMagicItemInfo>, IBufferMessage
	{
		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x00020FDF File Offset: 0x0001F1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleRogueMagicItemInfo> Parser
		{
			get
			{
				return BattleRogueMagicItemInfo._parser;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00020FE6 File Offset: 0x0001F1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicItemInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00020FF8 File Offset: 0x0001F1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleRogueMagicItemInfo.Descriptor;
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00020FFF File Offset: 0x0001F1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicItemInfo()
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00021014 File Offset: 0x0001F214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicItemInfo(BattleRogueMagicItemInfo other) : this()
		{
			this.battleRoundCount_ = ((other.battleRoundCount_ != null) ? other.battleRoundCount_.Clone() : null);
			this.battleScepterList_ = other.battleScepterList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00021065 File Offset: 0x0001F265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicItemInfo Clone()
		{
			return new BattleRogueMagicItemInfo(this);
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0002106D File Offset: 0x0001F26D
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00021075 File Offset: 0x0001F275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicRoundCount BattleRoundCount
		{
			get
			{
				return this.battleRoundCount_;
			}
			set
			{
				this.battleRoundCount_ = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0002107E File Offset: 0x0001F27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleRogueMagicScepter> BattleScepterList
		{
			get
			{
				return this.battleScepterList_;
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00021086 File Offset: 0x0001F286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleRogueMagicItemInfo);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00021094 File Offset: 0x0001F294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleRogueMagicItemInfo other)
		{
			return other != null && (other == this || (object.Equals(this.BattleRoundCount, other.BattleRoundCount) && this.battleScepterList_.Equals(other.battleScepterList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x000210E8 File Offset: 0x0001F2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleRoundCount_ != null)
			{
				num ^= this.BattleRoundCount.GetHashCode();
			}
			num ^= this.battleScepterList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00021132 File Offset: 0x0001F332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0002113A File Offset: 0x0001F33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00021144 File Offset: 0x0001F344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleRoundCount_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BattleRoundCount);
			}
			this.battleScepterList_.WriteTo(ref output, BattleRogueMagicItemInfo._repeated_battleScepterList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00021194 File Offset: 0x0001F394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleRoundCount_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleRoundCount);
			}
			num += this.battleScepterList_.CalculateSize(BattleRogueMagicItemInfo._repeated_battleScepterList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x000211E8 File Offset: 0x0001F3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleRogueMagicItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleRoundCount_ != null)
			{
				if (this.battleRoundCount_ == null)
				{
					this.BattleRoundCount = new BattleRogueMagicRoundCount();
				}
				this.BattleRoundCount.MergeFrom(other.BattleRoundCount);
			}
			this.battleScepterList_.Add(other.battleScepterList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0002124D File Offset: 0x0001F44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00021258 File Offset: 0x0001F458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.battleScepterList_.AddEntriesFrom(ref input, BattleRogueMagicItemInfo._repeated_battleScepterList_codec);
					}
				}
				else
				{
					if (this.battleRoundCount_ == null)
					{
						this.BattleRoundCount = new BattleRogueMagicRoundCount();
					}
					input.ReadMessage(this.BattleRoundCount);
				}
			}
		}

		// Token: 0x040004AF RID: 1199
		private static readonly MessageParser<BattleRogueMagicItemInfo> _parser = new MessageParser<BattleRogueMagicItemInfo>(() => new BattleRogueMagicItemInfo());

		// Token: 0x040004B0 RID: 1200
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004B1 RID: 1201
		public const int BattleRoundCountFieldNumber = 1;

		// Token: 0x040004B2 RID: 1202
		private BattleRogueMagicRoundCount battleRoundCount_;

		// Token: 0x040004B3 RID: 1203
		public const int BattleScepterListFieldNumber = 2;

		// Token: 0x040004B4 RID: 1204
		private static readonly FieldCodec<BattleRogueMagicScepter> _repeated_battleScepterList_codec = FieldCodec.ForMessage<BattleRogueMagicScepter>(18U, BattleRogueMagicScepter.Parser);

		// Token: 0x040004B5 RID: 1205
		private readonly RepeatedField<BattleRogueMagicScepter> battleScepterList_ = new RepeatedField<BattleRogueMagicScepter>();
	}
}
