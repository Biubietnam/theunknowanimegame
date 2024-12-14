using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F63 RID: 3939
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueRecordInfo : IMessage<RogueRecordInfo>, IMessage, IEquatable<RogueRecordInfo>, IDeepCloneable<RogueRecordInfo>, IBufferMessage
	{
		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0600AF97 RID: 44951 RVA: 0x001D7C4F File Offset: 0x001D5E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueRecordInfo> Parser
		{
			get
			{
				return RogueRecordInfo._parser;
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x0600AF98 RID: 44952 RVA: 0x001D7C56 File Offset: 0x001D5E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueRecordInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0600AF99 RID: 44953 RVA: 0x001D7C68 File Offset: 0x001D5E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueRecordInfo.Descriptor;
			}
		}

		// Token: 0x0600AF9A RID: 44954 RVA: 0x001D7C6F File Offset: 0x001D5E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRecordInfo()
		{
		}

		// Token: 0x0600AF9B RID: 44955 RVA: 0x001D7C98 File Offset: 0x001D5E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRecordInfo(RogueRecordInfo other) : this()
		{
			this.buffList_ = other.buffList_.Clone();
			this.avatarList_ = other.avatarList_.Clone();
			this.miracleList_ = other.miracleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF9C RID: 44956 RVA: 0x001D7CEF File Offset: 0x001D5EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRecordInfo Clone()
		{
			return new RogueRecordInfo(this);
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0600AF9D RID: 44957 RVA: 0x001D7CF7 File Offset: 0x001D5EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueBuff> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0600AF9E RID: 44958 RVA: 0x001D7CFF File Offset: 0x001D5EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueRecordAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x0600AF9F RID: 44959 RVA: 0x001D7D07 File Offset: 0x001D5F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MiracleList
		{
			get
			{
				return this.miracleList_;
			}
		}

		// Token: 0x0600AFA0 RID: 44960 RVA: 0x001D7D0F File Offset: 0x001D5F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueRecordInfo);
		}

		// Token: 0x0600AFA1 RID: 44961 RVA: 0x001D7D20 File Offset: 0x001D5F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueRecordInfo other)
		{
			return other != null && (other == this || (this.buffList_.Equals(other.buffList_) && this.avatarList_.Equals(other.avatarList_) && this.miracleList_.Equals(other.miracleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFA2 RID: 44962 RVA: 0x001D7D88 File Offset: 0x001D5F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffList_.GetHashCode();
			num ^= this.avatarList_.GetHashCode();
			num ^= this.miracleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFA3 RID: 44963 RVA: 0x001D7DD8 File Offset: 0x001D5FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AFA4 RID: 44964 RVA: 0x001D7DE0 File Offset: 0x001D5FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFA5 RID: 44965 RVA: 0x001D7DEC File Offset: 0x001D5FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffList_.WriteTo(ref output, RogueRecordInfo._repeated_buffList_codec);
			this.miracleList_.WriteTo(ref output, RogueRecordInfo._repeated_miracleList_codec);
			this.avatarList_.WriteTo(ref output, RogueRecordInfo._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFA6 RID: 44966 RVA: 0x001D7E40 File Offset: 0x001D6040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffList_.CalculateSize(RogueRecordInfo._repeated_buffList_codec);
			num += this.avatarList_.CalculateSize(RogueRecordInfo._repeated_avatarList_codec);
			num += this.miracleList_.CalculateSize(RogueRecordInfo._repeated_miracleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFA7 RID: 44967 RVA: 0x001D7EA0 File Offset: 0x001D60A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueRecordInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.buffList_.Add(other.buffList_);
			this.avatarList_.Add(other.avatarList_);
			this.miracleList_.Add(other.miracleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AFA8 RID: 44968 RVA: 0x001D7EFB File Offset: 0x001D60FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFA9 RID: 44969 RVA: 0x001D7F04 File Offset: 0x001D6104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 96U)
				{
					if (num == 42U)
					{
						this.buffList_.AddEntriesFrom(ref input, RogueRecordInfo._repeated_buffList_codec);
						continue;
					}
					if (num == 96U)
					{
						goto IL_44;
					}
				}
				else
				{
					if (num == 98U)
					{
						goto IL_44;
					}
					if (num == 114U)
					{
						this.avatarList_.AddEntriesFrom(ref input, RogueRecordInfo._repeated_avatarList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_44:
				this.miracleList_.AddEntriesFrom(ref input, RogueRecordInfo._repeated_miracleList_codec);
			}
		}

		// Token: 0x04004769 RID: 18281
		private static readonly MessageParser<RogueRecordInfo> _parser = new MessageParser<RogueRecordInfo>(() => new RogueRecordInfo());

		// Token: 0x0400476A RID: 18282
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400476B RID: 18283
		public const int BuffListFieldNumber = 5;

		// Token: 0x0400476C RID: 18284
		private static readonly FieldCodec<RogueBuff> _repeated_buffList_codec = FieldCodec.ForMessage<RogueBuff>(42U, RogueBuff.Parser);

		// Token: 0x0400476D RID: 18285
		private readonly RepeatedField<RogueBuff> buffList_ = new RepeatedField<RogueBuff>();

		// Token: 0x0400476E RID: 18286
		public const int AvatarListFieldNumber = 14;

		// Token: 0x0400476F RID: 18287
		private static readonly FieldCodec<RogueRecordAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<RogueRecordAvatar>(114U, RogueRecordAvatar.Parser);

		// Token: 0x04004770 RID: 18288
		private readonly RepeatedField<RogueRecordAvatar> avatarList_ = new RepeatedField<RogueRecordAvatar>();

		// Token: 0x04004771 RID: 18289
		public const int MiracleListFieldNumber = 12;

		// Token: 0x04004772 RID: 18290
		private static readonly FieldCodec<uint> _repeated_miracleList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04004773 RID: 18291
		private readonly RepeatedField<uint> miracleList_ = new RepeatedField<uint>();
	}
}
