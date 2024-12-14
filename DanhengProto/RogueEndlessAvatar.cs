using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E7B RID: 3707
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueEndlessAvatar : IMessage<RogueEndlessAvatar>, IMessage, IEquatable<RogueEndlessAvatar>, IDeepCloneable<RogueEndlessAvatar>, IBufferMessage
	{
		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x0600A563 RID: 42339 RVA: 0x001BC865 File Offset: 0x001BAA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueEndlessAvatar> Parser
		{
			get
			{
				return RogueEndlessAvatar._parser;
			}
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x0600A564 RID: 42340 RVA: 0x001BC86C File Offset: 0x001BAA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueEndlessAvatarReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x0600A565 RID: 42341 RVA: 0x001BC87E File Offset: 0x001BAA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueEndlessAvatar.Descriptor;
			}
		}

		// Token: 0x0600A566 RID: 42342 RVA: 0x001BC885 File Offset: 0x001BAA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessAvatar()
		{
		}

		// Token: 0x0600A567 RID: 42343 RVA: 0x001BC88D File Offset: 0x001BAA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessAvatar(RogueEndlessAvatar other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A568 RID: 42344 RVA: 0x001BC8BE File Offset: 0x001BAABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessAvatar Clone()
		{
			return new RogueEndlessAvatar(this);
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x0600A569 RID: 42345 RVA: 0x001BC8C6 File Offset: 0x001BAAC6
		// (set) Token: 0x0600A56A RID: 42346 RVA: 0x001BC8CE File Offset: 0x001BAACE
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

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x0600A56B RID: 42347 RVA: 0x001BC8D7 File Offset: 0x001BAAD7
		// (set) Token: 0x0600A56C RID: 42348 RVA: 0x001BC8DF File Offset: 0x001BAADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x0600A56D RID: 42349 RVA: 0x001BC8E8 File Offset: 0x001BAAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueEndlessAvatar);
		}

		// Token: 0x0600A56E RID: 42350 RVA: 0x001BC8F6 File Offset: 0x001BAAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueEndlessAvatar other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A56F RID: 42351 RVA: 0x001BC934 File Offset: 0x001BAB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A570 RID: 42352 RVA: 0x001BC992 File Offset: 0x001BAB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A571 RID: 42353 RVA: 0x001BC99A File Offset: 0x001BAB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A572 RID: 42354 RVA: 0x001BC9A4 File Offset: 0x001BABA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x001BC9FC File Offset: 0x001BABFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x001BCA54 File Offset: 0x001BAC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueEndlessAvatar other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x001BCAA4 File Offset: 0x001BACA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A576 RID: 42358 RVA: 0x001BCAB0 File Offset: 0x001BACB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004389 RID: 17289
		private static readonly MessageParser<RogueEndlessAvatar> _parser = new MessageParser<RogueEndlessAvatar>(() => new RogueEndlessAvatar());

		// Token: 0x0400438A RID: 17290
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400438B RID: 17291
		public const int AvatarTypeFieldNumber = 12;

		// Token: 0x0400438C RID: 17292
		private AvatarType avatarType_;

		// Token: 0x0400438D RID: 17293
		public const int AvatarIdFieldNumber = 1;

		// Token: 0x0400438E RID: 17294
		private uint avatarId_;
	}
}
