using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008B7 RID: 2231
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusChallengeLineup : IMessage<HeliobusChallengeLineup>, IMessage, IEquatable<HeliobusChallengeLineup>, IDeepCloneable<HeliobusChallengeLineup>, IBufferMessage
	{
		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06006374 RID: 25460 RVA: 0x0010A7C1 File Offset: 0x001089C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusChallengeLineup> Parser
		{
			get
			{
				return HeliobusChallengeLineup._parser;
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06006375 RID: 25461 RVA: 0x0010A7C8 File Offset: 0x001089C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusChallengeLineupReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06006376 RID: 25462 RVA: 0x0010A7DA File Offset: 0x001089DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusChallengeLineup.Descriptor;
			}
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x0010A7E1 File Offset: 0x001089E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusChallengeLineup()
		{
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x0010A7F4 File Offset: 0x001089F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusChallengeLineup(HeliobusChallengeLineup other) : this()
		{
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this.skillId_ = other.skillId_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x0010A841 File Offset: 0x00108A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusChallengeLineup Clone()
		{
			return new HeliobusChallengeLineup(this);
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x0600637A RID: 25466 RVA: 0x0010A849 File Offset: 0x00108A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x0600637B RID: 25467 RVA: 0x0010A851 File Offset: 0x00108A51
		// (set) Token: 0x0600637C RID: 25468 RVA: 0x0010A859 File Offset: 0x00108A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x0600637D RID: 25469 RVA: 0x0010A862 File Offset: 0x00108A62
		// (set) Token: 0x0600637E RID: 25470 RVA: 0x0010A86A File Offset: 0x00108A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600637F RID: 25471 RVA: 0x0010A873 File Offset: 0x00108A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusChallengeLineup);
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x0010A884 File Offset: 0x00108A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusChallengeLineup other)
		{
			return other != null && (other == this || (this.avatarIdList_.Equals(other.avatarIdList_) && this.SkillId == other.SkillId && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x0010A8E4 File Offset: 0x00108AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarIdList_.GetHashCode();
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006382 RID: 25474 RVA: 0x0010A94A File Offset: 0x00108B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x0010A952 File Offset: 0x00108B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x0010A95C File Offset: 0x00108B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.SkillId);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GroupId);
			}
			this.avatarIdList_.WriteTo(ref output, HeliobusChallengeLineup._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x0010A9C8 File Offset: 0x00108BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarIdList_.CalculateSize(HeliobusChallengeLineup._repeated_avatarIdList_codec);
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x0010AA34 File Offset: 0x00108C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusChallengeLineup other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x0010AA95 File Offset: 0x00108C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x0010AAA0 File Offset: 0x00108CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 104U)
				{
					if (num == 24U)
					{
						this.SkillId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.avatarIdList_.AddEntriesFrom(ref input, HeliobusChallengeLineup._repeated_avatarIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400265B RID: 9819
		private static readonly MessageParser<HeliobusChallengeLineup> _parser = new MessageParser<HeliobusChallengeLineup>(() => new HeliobusChallengeLineup());

		// Token: 0x0400265C RID: 9820
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400265D RID: 9821
		public const int AvatarIdListFieldNumber = 15;

		// Token: 0x0400265E RID: 9822
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x0400265F RID: 9823
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04002660 RID: 9824
		public const int SkillIdFieldNumber = 3;

		// Token: 0x04002661 RID: 9825
		private uint skillId_;

		// Token: 0x04002662 RID: 9826
		public const int GroupIdFieldNumber = 13;

		// Token: 0x04002663 RID: 9827
		private uint groupId_;
	}
}
