using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F61 RID: 3937
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueRecordAvatar : IMessage<RogueRecordAvatar>, IMessage, IEquatable<RogueRecordAvatar>, IDeepCloneable<RogueRecordAvatar>, IBufferMessage
	{
		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0600AF7C RID: 44924 RVA: 0x001D7775 File Offset: 0x001D5975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueRecordAvatar> Parser
		{
			get
			{
				return RogueRecordAvatar._parser;
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x0600AF7D RID: 44925 RVA: 0x001D777C File Offset: 0x001D597C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueRecordAvatarReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x0600AF7E RID: 44926 RVA: 0x001D778E File Offset: 0x001D598E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueRecordAvatar.Descriptor;
			}
		}

		// Token: 0x0600AF7F RID: 44927 RVA: 0x001D7795 File Offset: 0x001D5995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRecordAvatar()
		{
		}

		// Token: 0x0600AF80 RID: 44928 RVA: 0x001D77A0 File Offset: 0x001D59A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRecordAvatar(RogueRecordAvatar other) : this()
		{
			this.slot_ = other.slot_;
			this.avatarType_ = other.avatarType_;
			this.id_ = other.id_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF81 RID: 44929 RVA: 0x001D77F4 File Offset: 0x001D59F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRecordAvatar Clone()
		{
			return new RogueRecordAvatar(this);
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x0600AF82 RID: 44930 RVA: 0x001D77FC File Offset: 0x001D59FC
		// (set) Token: 0x0600AF83 RID: 44931 RVA: 0x001D7804 File Offset: 0x001D5A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x0600AF84 RID: 44932 RVA: 0x001D780D File Offset: 0x001D5A0D
		// (set) Token: 0x0600AF85 RID: 44933 RVA: 0x001D7815 File Offset: 0x001D5A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x0600AF86 RID: 44934 RVA: 0x001D781E File Offset: 0x001D5A1E
		// (set) Token: 0x0600AF87 RID: 44935 RVA: 0x001D7826 File Offset: 0x001D5A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0600AF88 RID: 44936 RVA: 0x001D782F File Offset: 0x001D5A2F
		// (set) Token: 0x0600AF89 RID: 44937 RVA: 0x001D7837 File Offset: 0x001D5A37
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

		// Token: 0x0600AF8A RID: 44938 RVA: 0x001D7840 File Offset: 0x001D5A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueRecordAvatar);
		}

		// Token: 0x0600AF8B RID: 44939 RVA: 0x001D7850 File Offset: 0x001D5A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueRecordAvatar other)
		{
			return other != null && (other == this || (this.Slot == other.Slot && this.AvatarType == other.AvatarType && this.Id == other.Id && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF8C RID: 44940 RVA: 0x001D78BC File Offset: 0x001D5ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Slot != 0U)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF8D RID: 44941 RVA: 0x001D794C File Offset: 0x001D5B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF8E RID: 44942 RVA: 0x001D7954 File Offset: 0x001D5B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF8F RID: 44943 RVA: 0x001D7960 File Offset: 0x001D5B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Slot != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Slot);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Id);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Level);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF90 RID: 44944 RVA: 0x001D79F4 File Offset: 0x001D5BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Slot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Slot);
			}
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF91 RID: 44945 RVA: 0x001D7A7C File Offset: 0x001D5C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueRecordAvatar other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF92 RID: 44946 RVA: 0x001D7AF4 File Offset: 0x001D5CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF93 RID: 44947 RVA: 0x001D7B00 File Offset: 0x001D5D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 40U)
					{
						this.Slot = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400475E RID: 18270
		private static readonly MessageParser<RogueRecordAvatar> _parser = new MessageParser<RogueRecordAvatar>(() => new RogueRecordAvatar());

		// Token: 0x0400475F RID: 18271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004760 RID: 18272
		public const int SlotFieldNumber = 5;

		// Token: 0x04004761 RID: 18273
		private uint slot_;

		// Token: 0x04004762 RID: 18274
		public const int AvatarTypeFieldNumber = 14;

		// Token: 0x04004763 RID: 18275
		private AvatarType avatarType_;

		// Token: 0x04004764 RID: 18276
		public const int IdFieldNumber = 6;

		// Token: 0x04004765 RID: 18277
		private uint id_;

		// Token: 0x04004766 RID: 18278
		public const int LevelFieldNumber = 11;

		// Token: 0x04004767 RID: 18279
		private uint level_;
	}
}
