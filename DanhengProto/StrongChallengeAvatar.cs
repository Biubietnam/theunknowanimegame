using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011F1 RID: 4593
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StrongChallengeAvatar : IMessage<StrongChallengeAvatar>, IMessage, IEquatable<StrongChallengeAvatar>, IDeepCloneable<StrongChallengeAvatar>, IBufferMessage
	{
		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x0600CD4A RID: 52554 RVA: 0x002270FD File Offset: 0x002252FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StrongChallengeAvatar> Parser
		{
			get
			{
				return StrongChallengeAvatar._parser;
			}
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x0600CD4B RID: 52555 RVA: 0x00227104 File Offset: 0x00225304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StrongChallengeAvatarReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x0600CD4C RID: 52556 RVA: 0x00227116 File Offset: 0x00225316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StrongChallengeAvatar.Descriptor;
			}
		}

		// Token: 0x0600CD4D RID: 52557 RVA: 0x0022711D File Offset: 0x0022531D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeAvatar()
		{
		}

		// Token: 0x0600CD4E RID: 52558 RVA: 0x00227125 File Offset: 0x00225325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeAvatar(StrongChallengeAvatar other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.avatarType_ = other.avatarType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD4F RID: 52559 RVA: 0x00227156 File Offset: 0x00225356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeAvatar Clone()
		{
			return new StrongChallengeAvatar(this);
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x0600CD50 RID: 52560 RVA: 0x0022715E File Offset: 0x0022535E
		// (set) Token: 0x0600CD51 RID: 52561 RVA: 0x00227166 File Offset: 0x00225366
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

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x0600CD52 RID: 52562 RVA: 0x0022716F File Offset: 0x0022536F
		// (set) Token: 0x0600CD53 RID: 52563 RVA: 0x00227177 File Offset: 0x00225377
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

		// Token: 0x0600CD54 RID: 52564 RVA: 0x00227180 File Offset: 0x00225380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StrongChallengeAvatar);
		}

		// Token: 0x0600CD55 RID: 52565 RVA: 0x0022718E File Offset: 0x0022538E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StrongChallengeAvatar other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.AvatarType == other.AvatarType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD56 RID: 52566 RVA: 0x002271CC File Offset: 0x002253CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD57 RID: 52567 RVA: 0x0022722A File Offset: 0x0022542A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CD58 RID: 52568 RVA: 0x00227232 File Offset: 0x00225432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD59 RID: 52569 RVA: 0x0022723C File Offset: 0x0022543C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(88);
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

		// Token: 0x0600CD5A RID: 52570 RVA: 0x00227298 File Offset: 0x00225498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD5B RID: 52571 RVA: 0x002272F0 File Offset: 0x002254F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StrongChallengeAvatar other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD5C RID: 52572 RVA: 0x00227340 File Offset: 0x00225540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD5D RID: 52573 RVA: 0x0022734C File Offset: 0x0022554C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
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

		// Token: 0x040052CC RID: 21196
		private static readonly MessageParser<StrongChallengeAvatar> _parser = new MessageParser<StrongChallengeAvatar>(() => new StrongChallengeAvatar());

		// Token: 0x040052CD RID: 21197
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052CE RID: 21198
		public const int AvatarIdFieldNumber = 11;

		// Token: 0x040052CF RID: 21199
		private uint avatarId_;

		// Token: 0x040052D0 RID: 21200
		public const int AvatarTypeFieldNumber = 12;

		// Token: 0x040052D1 RID: 21201
		private AvatarType avatarType_;
	}
}
