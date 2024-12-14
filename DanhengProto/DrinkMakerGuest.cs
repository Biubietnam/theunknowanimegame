using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003E5 RID: 997
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DrinkMakerGuest : IMessage<DrinkMakerGuest>, IMessage, IEquatable<DrinkMakerGuest>, IDeepCloneable<DrinkMakerGuest>, IBufferMessage
	{
		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x0007B1F1 File Offset: 0x000793F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DrinkMakerGuest> Parser
		{
			get
			{
				return DrinkMakerGuest._parser;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x0007B1F8 File Offset: 0x000793F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DrinkMakerGuestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x0007B20A File Offset: 0x0007940A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrinkMakerGuest.Descriptor;
			}
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x0007B211 File Offset: 0x00079411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerGuest()
		{
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x0007B224 File Offset: 0x00079424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerGuest(DrinkMakerGuest other) : this()
		{
			this.faith_ = other.faith_;
			this.unlockedFavorTagList_ = other.unlockedFavorTagList_.Clone();
			this.guestId_ = other.guestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x0007B271 File Offset: 0x00079471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerGuest Clone()
		{
			return new DrinkMakerGuest(this);
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x0007B279 File Offset: 0x00079479
		// (set) Token: 0x06002C67 RID: 11367 RVA: 0x0007B281 File Offset: 0x00079481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Faith
		{
			get
			{
				return this.faith_;
			}
			set
			{
				this.faith_ = value;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x0007B28A File Offset: 0x0007948A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockedFavorTagList
		{
			get
			{
				return this.unlockedFavorTagList_;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x0007B292 File Offset: 0x00079492
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x0007B29A File Offset: 0x0007949A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GuestId
		{
			get
			{
				return this.guestId_;
			}
			set
			{
				this.guestId_ = value;
			}
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x0007B2A3 File Offset: 0x000794A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrinkMakerGuest);
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x0007B2B4 File Offset: 0x000794B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrinkMakerGuest other)
		{
			return other != null && (other == this || (this.Faith == other.Faith && this.unlockedFavorTagList_.Equals(other.unlockedFavorTagList_) && this.GuestId == other.GuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x0007B314 File Offset: 0x00079514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Faith != 0U)
			{
				num ^= this.Faith.GetHashCode();
			}
			num ^= this.unlockedFavorTagList_.GetHashCode();
			if (this.GuestId != 0U)
			{
				num ^= this.GuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x0007B37A File Offset: 0x0007957A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x0007B382 File Offset: 0x00079582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x0007B38C File Offset: 0x0007958C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GuestId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GuestId);
			}
			if (this.Faith != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Faith);
			}
			this.unlockedFavorTagList_.WriteTo(ref output, DrinkMakerGuest._repeated_unlockedFavorTagList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x0007B3F8 File Offset: 0x000795F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Faith != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Faith);
			}
			num += this.unlockedFavorTagList_.CalculateSize(DrinkMakerGuest._repeated_unlockedFavorTagList_codec);
			if (this.GuestId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x0007B464 File Offset: 0x00079664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrinkMakerGuest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Faith != 0U)
			{
				this.Faith = other.Faith;
			}
			this.unlockedFavorTagList_.Add(other.unlockedFavorTagList_);
			if (other.GuestId != 0U)
			{
				this.GuestId = other.GuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x0007B4C5 File Offset: 0x000796C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x0007B4D0 File Offset: 0x000796D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 32U)
					{
						this.GuestId = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Faith = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 72U || num == 74U)
				{
					this.unlockedFavorTagList_.AddEntriesFrom(ref input, DrinkMakerGuest._repeated_unlockedFavorTagList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040011E8 RID: 4584
		private static readonly MessageParser<DrinkMakerGuest> _parser = new MessageParser<DrinkMakerGuest>(() => new DrinkMakerGuest());

		// Token: 0x040011E9 RID: 4585
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011EA RID: 4586
		public const int FaithFieldNumber = 8;

		// Token: 0x040011EB RID: 4587
		private uint faith_;

		// Token: 0x040011EC RID: 4588
		public const int UnlockedFavorTagListFieldNumber = 9;

		// Token: 0x040011ED RID: 4589
		private static readonly FieldCodec<uint> _repeated_unlockedFavorTagList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x040011EE RID: 4590
		private readonly RepeatedField<uint> unlockedFavorTagList_ = new RepeatedField<uint>();

		// Token: 0x040011EF RID: 4591
		public const int GuestIdFieldNumber = 4;

		// Token: 0x040011F0 RID: 4592
		private uint guestId_;
	}
}
