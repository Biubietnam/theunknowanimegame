using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E03 RID: 3587
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueArcadeStartCsReq : IMessage<RogueArcadeStartCsReq>, IMessage, IEquatable<RogueArcadeStartCsReq>, IDeepCloneable<RogueArcadeStartCsReq>, IBufferMessage
	{
		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x0600A061 RID: 41057 RVA: 0x001AE529 File Offset: 0x001AC729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArcadeStartCsReq> Parser
		{
			get
			{
				return RogueArcadeStartCsReq._parser;
			}
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x0600A062 RID: 41058 RVA: 0x001AE530 File Offset: 0x001AC730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueArcadeStartCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x0600A063 RID: 41059 RVA: 0x001AE542 File Offset: 0x001AC742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArcadeStartCsReq.Descriptor;
			}
		}

		// Token: 0x0600A064 RID: 41060 RVA: 0x001AE549 File Offset: 0x001AC749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeStartCsReq()
		{
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x001AE55C File Offset: 0x001AC75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeStartCsReq(RogueArcadeStartCsReq other) : this()
		{
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.roomId_ = other.roomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A066 RID: 41062 RVA: 0x001AE592 File Offset: 0x001AC792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeStartCsReq Clone()
		{
			return new RogueArcadeStartCsReq(this);
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x0600A067 RID: 41063 RVA: 0x001AE59A File Offset: 0x001AC79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x0600A068 RID: 41064 RVA: 0x001AE5A2 File Offset: 0x001AC7A2
		// (set) Token: 0x0600A069 RID: 41065 RVA: 0x001AE5AA File Offset: 0x001AC7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x0600A06A RID: 41066 RVA: 0x001AE5B3 File Offset: 0x001AC7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArcadeStartCsReq);
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x001AE5C4 File Offset: 0x001AC7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArcadeStartCsReq other)
		{
			return other != null && (other == this || (this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.RoomId == other.RoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A06C RID: 41068 RVA: 0x001AE614 File Offset: 0x001AC814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x001AE661 File Offset: 0x001AC861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x001AE669 File Offset: 0x001AC869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A06F RID: 41071 RVA: 0x001AE674 File Offset: 0x001AC874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.baseAvatarIdList_.WriteTo(ref output, RogueArcadeStartCsReq._repeated_baseAvatarIdList_codec);
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A070 RID: 41072 RVA: 0x001AE6C4 File Offset: 0x001AC8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.baseAvatarIdList_.CalculateSize(RogueArcadeStartCsReq._repeated_baseAvatarIdList_codec);
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x001AE718 File Offset: 0x001AC918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArcadeStartCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x001AE765 File Offset: 0x001AC965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A073 RID: 41075 RVA: 0x001AE770 File Offset: 0x001AC970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U && num != 34U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoomId = input.ReadUInt32();
					}
				}
				else
				{
					this.baseAvatarIdList_.AddEntriesFrom(ref input, RogueArcadeStartCsReq._repeated_baseAvatarIdList_codec);
				}
			}
		}

		// Token: 0x040041B2 RID: 16818
		private static readonly MessageParser<RogueArcadeStartCsReq> _parser = new MessageParser<RogueArcadeStartCsReq>(() => new RogueArcadeStartCsReq());

		// Token: 0x040041B3 RID: 16819
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041B4 RID: 16820
		public const int BaseAvatarIdListFieldNumber = 4;

		// Token: 0x040041B5 RID: 16821
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040041B6 RID: 16822
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x040041B7 RID: 16823
		public const int RoomIdFieldNumber = 5;

		// Token: 0x040041B8 RID: 16824
		private uint roomId_;
	}
}
