using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002A3 RID: 675
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueStoryInfo : IMessage<ChessRogueStoryInfo>, IMessage, IEquatable<ChessRogueStoryInfo>, IDeepCloneable<ChessRogueStoryInfo>, IBufferMessage
	{
		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x000567EB File Offset: 0x000549EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueStoryInfo> Parser
		{
			get
			{
				return ChessRogueStoryInfo._parser;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x000567F2 File Offset: 0x000549F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueStoryInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00056804 File Offset: 0x00054A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueStoryInfo.Descriptor;
			}
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0005680B File Offset: 0x00054A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueStoryInfo()
		{
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00056834 File Offset: 0x00054A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueStoryInfo(ChessRogueStoryInfo other) : this()
		{
			this.lONJGNHJBKD_ = other.lONJGNHJBKD_.Clone();
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this.gAKCKDNKJCD_ = other.gAKCKDNKJCD_.Clone();
			this.lEJEKIBLCPN_ = other.lEJEKIBLCPN_;
			this.chessRogueMainStoryId_ = other.chessRogueMainStoryId_;
			this.storyIdList_ = other.storyIdList_.Clone();
			this.lJMHFFIONBI_ = other.lJMHFFIONBI_;
			this.mIELJMANDKC_ = other.mIELJMANDKC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x000568C7 File Offset: 0x00054AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueStoryInfo Clone()
		{
			return new ChessRogueStoryInfo(this);
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x000568CF File Offset: 0x00054ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LONJGNHJBKD
		{
			get
			{
				return this.lONJGNHJBKD_;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x000568D7 File Offset: 0x00054AD7
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x000568DF File Offset: 0x00054ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChessRogueSubStoryId
		{
			get
			{
				return this.chessRogueSubStoryId_;
			}
			set
			{
				this.chessRogueSubStoryId_ = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x000568E8 File Offset: 0x00054AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GAKCKDNKJCD
		{
			get
			{
				return this.gAKCKDNKJCD_;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x000568F0 File Offset: 0x00054AF0
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x000568F8 File Offset: 0x00054AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LEJEKIBLCPN
		{
			get
			{
				return this.lEJEKIBLCPN_;
			}
			set
			{
				this.lEJEKIBLCPN_ = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x00056901 File Offset: 0x00054B01
		// (set) Token: 0x06001E32 RID: 7730 RVA: 0x00056909 File Offset: 0x00054B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChessRogueMainStoryId
		{
			get
			{
				return this.chessRogueMainStoryId_;
			}
			set
			{
				this.chessRogueMainStoryId_ = value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x00056912 File Offset: 0x00054B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> StoryIdList
		{
			get
			{
				return this.storyIdList_;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x0005691A File Offset: 0x00054B1A
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x00056922 File Offset: 0x00054B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LJMHFFIONBI
		{
			get
			{
				return this.lJMHFFIONBI_;
			}
			set
			{
				this.lJMHFFIONBI_ = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x0005692B File Offset: 0x00054B2B
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x00056933 File Offset: 0x00054B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MIELJMANDKC
		{
			get
			{
				return this.mIELJMANDKC_;
			}
			set
			{
				this.mIELJMANDKC_ = value;
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0005693C File Offset: 0x00054B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueStoryInfo);
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0005694C File Offset: 0x00054B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueStoryInfo other)
		{
			return other != null && (other == this || (this.lONJGNHJBKD_.Equals(other.lONJGNHJBKD_) && this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && this.gAKCKDNKJCD_.Equals(other.gAKCKDNKJCD_) && this.LEJEKIBLCPN == other.LEJEKIBLCPN && this.ChessRogueMainStoryId == other.ChessRogueMainStoryId && this.storyIdList_.Equals(other.storyIdList_) && this.LJMHFFIONBI == other.LJMHFFIONBI && this.MIELJMANDKC == other.MIELJMANDKC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00056A04 File Offset: 0x00054C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lONJGNHJBKD_.GetHashCode();
			if (this.ChessRogueSubStoryId != 0U)
			{
				num ^= this.ChessRogueSubStoryId.GetHashCode();
			}
			num ^= this.gAKCKDNKJCD_.GetHashCode();
			if (this.LEJEKIBLCPN)
			{
				num ^= this.LEJEKIBLCPN.GetHashCode();
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				num ^= this.ChessRogueMainStoryId.GetHashCode();
			}
			num ^= this.storyIdList_.GetHashCode();
			if (this.LJMHFFIONBI)
			{
				num ^= this.LJMHFFIONBI.GetHashCode();
			}
			if (this.MIELJMANDKC != 0U)
			{
				num ^= this.MIELJMANDKC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00056AD1 File Offset: 0x00054CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00056AD9 File Offset: 0x00054CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00056AE4 File Offset: 0x00054CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lONJGNHJBKD_.WriteTo(ref output, ChessRogueStoryInfo._repeated_lONJGNHJBKD_codec);
			if (this.MIELJMANDKC != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MIELJMANDKC);
			}
			this.storyIdList_.WriteTo(ref output, ChessRogueStoryInfo._repeated_storyIdList_codec);
			if (this.LJMHFFIONBI)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.LJMHFFIONBI);
			}
			if (this.LEJEKIBLCPN)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.LEJEKIBLCPN);
			}
			this.gAKCKDNKJCD_.WriteTo(ref output, ChessRogueStoryInfo._repeated_gAKCKDNKJCD_codec);
			if (this.ChessRogueSubStoryId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ChessRogueSubStoryId);
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ChessRogueMainStoryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00056BC4 File Offset: 0x00054DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lONJGNHJBKD_.CalculateSize(ChessRogueStoryInfo._repeated_lONJGNHJBKD_codec);
			if (this.ChessRogueSubStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueSubStoryId);
			}
			num += this.gAKCKDNKJCD_.CalculateSize(ChessRogueStoryInfo._repeated_gAKCKDNKJCD_codec);
			if (this.LEJEKIBLCPN)
			{
				num += 2;
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueMainStoryId);
			}
			num += this.storyIdList_.CalculateSize(ChessRogueStoryInfo._repeated_storyIdList_codec);
			if (this.LJMHFFIONBI)
			{
				num += 2;
			}
			if (this.MIELJMANDKC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MIELJMANDKC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00056C84 File Offset: 0x00054E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueStoryInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.lONJGNHJBKD_.Add(other.lONJGNHJBKD_);
			if (other.ChessRogueSubStoryId != 0U)
			{
				this.ChessRogueSubStoryId = other.ChessRogueSubStoryId;
			}
			this.gAKCKDNKJCD_.Add(other.gAKCKDNKJCD_);
			if (other.LEJEKIBLCPN)
			{
				this.LEJEKIBLCPN = other.LEJEKIBLCPN;
			}
			if (other.ChessRogueMainStoryId != 0U)
			{
				this.ChessRogueMainStoryId = other.ChessRogueMainStoryId;
			}
			this.storyIdList_.Add(other.storyIdList_);
			if (other.LJMHFFIONBI)
			{
				this.LJMHFFIONBI = other.LJMHFFIONBI;
			}
			if (other.MIELJMANDKC != 0U)
			{
				this.MIELJMANDKC = other.MIELJMANDKC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00056D43 File Offset: 0x00054F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00056D4C File Offset: 0x00054F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 34U)
				{
					if (num <= 56U)
					{
						if (num == 40U)
						{
							this.LJMHFFIONBI = input.ReadBool();
							continue;
						}
						if (num == 48U)
						{
							this.LEJEKIBLCPN = input.ReadBool();
							continue;
						}
						if (num != 56U)
						{
							goto IL_53;
						}
					}
					else if (num != 58U)
					{
						if (num == 80U)
						{
							this.ChessRogueSubStoryId = input.ReadUInt32();
							continue;
						}
						if (num != 112U)
						{
							goto IL_53;
						}
						this.ChessRogueMainStoryId = input.ReadUInt32();
						continue;
					}
					this.gAKCKDNKJCD_.AddEntriesFrom(ref input, ChessRogueStoryInfo._repeated_gAKCKDNKJCD_codec);
					continue;
				}
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.lONJGNHJBKD_.AddEntriesFrom(ref input, ChessRogueStoryInfo._repeated_lONJGNHJBKD_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MIELJMANDKC = input.ReadUInt32();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.storyIdList_.AddEntriesFrom(ref input, ChessRogueStoryInfo._repeated_storyIdList_codec);
						continue;
					}
				}
				IL_53:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000C94 RID: 3220
		private static readonly MessageParser<ChessRogueStoryInfo> _parser = new MessageParser<ChessRogueStoryInfo>(() => new ChessRogueStoryInfo());

		// Token: 0x04000C95 RID: 3221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C96 RID: 3222
		public const int LONJGNHJBKDFieldNumber = 1;

		// Token: 0x04000C97 RID: 3223
		private static readonly FieldCodec<uint> _repeated_lONJGNHJBKD_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04000C98 RID: 3224
		private readonly RepeatedField<uint> lONJGNHJBKD_ = new RepeatedField<uint>();

		// Token: 0x04000C99 RID: 3225
		public const int ChessRogueSubStoryIdFieldNumber = 10;

		// Token: 0x04000C9A RID: 3226
		private uint chessRogueSubStoryId_;

		// Token: 0x04000C9B RID: 3227
		public const int GAKCKDNKJCDFieldNumber = 7;

		// Token: 0x04000C9C RID: 3228
		private static readonly FieldCodec<uint> _repeated_gAKCKDNKJCD_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04000C9D RID: 3229
		private readonly RepeatedField<uint> gAKCKDNKJCD_ = new RepeatedField<uint>();

		// Token: 0x04000C9E RID: 3230
		public const int LEJEKIBLCPNFieldNumber = 6;

		// Token: 0x04000C9F RID: 3231
		private bool lEJEKIBLCPN_;

		// Token: 0x04000CA0 RID: 3232
		public const int ChessRogueMainStoryIdFieldNumber = 14;

		// Token: 0x04000CA1 RID: 3233
		private uint chessRogueMainStoryId_;

		// Token: 0x04000CA2 RID: 3234
		public const int StoryIdListFieldNumber = 4;

		// Token: 0x04000CA3 RID: 3235
		private static readonly FieldCodec<uint> _repeated_storyIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04000CA4 RID: 3236
		private readonly RepeatedField<uint> storyIdList_ = new RepeatedField<uint>();

		// Token: 0x04000CA5 RID: 3237
		public const int LJMHFFIONBIFieldNumber = 5;

		// Token: 0x04000CA6 RID: 3238
		private bool lJMHFFIONBI_;

		// Token: 0x04000CA7 RID: 3239
		public const int MIELJMANDKCFieldNumber = 3;

		// Token: 0x04000CA8 RID: 3240
		private uint mIELJMANDKC_;
	}
}
