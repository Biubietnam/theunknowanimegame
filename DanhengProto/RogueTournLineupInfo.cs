using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FF3 RID: 4083
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournLineupInfo : IMessage<RogueTournLineupInfo>, IMessage, IEquatable<RogueTournLineupInfo>, IDeepCloneable<RogueTournLineupInfo>, IBufferMessage
	{
		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600B5B0 RID: 46512 RVA: 0x001E7C9D File Offset: 0x001E5E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournLineupInfo> Parser
		{
			get
			{
				return RogueTournLineupInfo._parser;
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600B5B1 RID: 46513 RVA: 0x001E7CA4 File Offset: 0x001E5EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournLineupInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600B5B2 RID: 46514 RVA: 0x001E7CB6 File Offset: 0x001E5EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournLineupInfo.Descriptor;
			}
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x001E7CBD File Offset: 0x001E5EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLineupInfo()
		{
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x001E7CD0 File Offset: 0x001E5ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLineupInfo(RogueTournLineupInfo other) : this()
		{
			this.rogueReviveCost_ = ((other.rogueReviveCost_ != null) ? other.rogueReviveCost_.Clone() : null);
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5B5 RID: 46517 RVA: 0x001E7D21 File Offset: 0x001E5F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLineupInfo Clone()
		{
			return new RogueTournLineupInfo(this);
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600B5B6 RID: 46518 RVA: 0x001E7D29 File Offset: 0x001E5F29
		// (set) Token: 0x0600B5B7 RID: 46519 RVA: 0x001E7D31 File Offset: 0x001E5F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData RogueReviveCost
		{
			get
			{
				return this.rogueReviveCost_;
			}
			set
			{
				this.rogueReviveCost_ = value;
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600B5B8 RID: 46520 RVA: 0x001E7D3A File Offset: 0x001E5F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x0600B5B9 RID: 46521 RVA: 0x001E7D42 File Offset: 0x001E5F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournLineupInfo);
		}

		// Token: 0x0600B5BA RID: 46522 RVA: 0x001E7D50 File Offset: 0x001E5F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournLineupInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueReviveCost, other.RogueReviveCost) && this.avatarIdList_.Equals(other.avatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B5BB RID: 46523 RVA: 0x001E7DA4 File Offset: 0x001E5FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueReviveCost_ != null)
			{
				num ^= this.RogueReviveCost.GetHashCode();
			}
			num ^= this.avatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B5BC RID: 46524 RVA: 0x001E7DEE File Offset: 0x001E5FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B5BD RID: 46525 RVA: 0x001E7DF6 File Offset: 0x001E5FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5BE RID: 46526 RVA: 0x001E7E00 File Offset: 0x001E6000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarIdList_.WriteTo(ref output, RogueTournLineupInfo._repeated_avatarIdList_codec);
			if (this.rogueReviveCost_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RogueReviveCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5BF RID: 46527 RVA: 0x001E7E50 File Offset: 0x001E6050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueReviveCost_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueReviveCost);
			}
			num += this.avatarIdList_.CalculateSize(RogueTournLineupInfo._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B5C0 RID: 46528 RVA: 0x001E7EA4 File Offset: 0x001E60A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournLineupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueReviveCost_ != null)
			{
				if (this.rogueReviveCost_ == null)
				{
					this.RogueReviveCost = new ItemCostData();
				}
				this.RogueReviveCost.MergeFrom(other.RogueReviveCost);
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5C1 RID: 46529 RVA: 0x001E7F09 File Offset: 0x001E6109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5C2 RID: 46530 RVA: 0x001E7F14 File Offset: 0x001E6114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U && num != 34U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueReviveCost_ == null)
						{
							this.RogueReviveCost = new ItemCostData();
						}
						input.ReadMessage(this.RogueReviveCost);
					}
				}
				else
				{
					this.avatarIdList_.AddEntriesFrom(ref input, RogueTournLineupInfo._repeated_avatarIdList_codec);
				}
			}
		}

		// Token: 0x040049B6 RID: 18870
		private static readonly MessageParser<RogueTournLineupInfo> _parser = new MessageParser<RogueTournLineupInfo>(() => new RogueTournLineupInfo());

		// Token: 0x040049B7 RID: 18871
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049B8 RID: 18872
		public const int RogueReviveCostFieldNumber = 11;

		// Token: 0x040049B9 RID: 18873
		private ItemCostData rogueReviveCost_;

		// Token: 0x040049BA RID: 18874
		public const int AvatarIdListFieldNumber = 4;

		// Token: 0x040049BB RID: 18875
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040049BC RID: 18876
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();
	}
}
