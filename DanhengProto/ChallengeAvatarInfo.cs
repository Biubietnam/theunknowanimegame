using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200018F RID: 399
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeAvatarInfo : IMessage<ChallengeAvatarInfo>, IMessage, IEquatable<ChallengeAvatarInfo>, IDeepCloneable<ChallengeAvatarInfo>, IBufferMessage
	{
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x000335CF File Offset: 0x000317CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeAvatarInfo> Parser
		{
			get
			{
				return ChallengeAvatarInfo._parser;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x000335D6 File Offset: 0x000317D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeAvatarInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x000335E8 File Offset: 0x000317E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeAvatarInfo.Descriptor;
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x000335EF File Offset: 0x000317EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeAvatarInfo()
		{
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x000335F8 File Offset: 0x000317F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeAvatarInfo(ChallengeAvatarInfo other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0003364C File Offset: 0x0003184C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeAvatarInfo Clone()
		{
			return new ChallengeAvatarInfo(this);
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00033654 File Offset: 0x00031854
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x0003365C File Offset: 0x0003185C
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

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00033665 File Offset: 0x00031865
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x0003366D File Offset: 0x0003186D
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

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00033676 File Offset: 0x00031876
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x0003367E File Offset: 0x0003187E
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

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00033687 File Offset: 0x00031887
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x0003368F File Offset: 0x0003188F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00033698 File Offset: 0x00031898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeAvatarInfo);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x000336A8 File Offset: 0x000318A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeAvatarInfo other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.Id == other.Id && this.Level == other.Level && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00033714 File Offset: 0x00031914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x000337A4 File Offset: 0x000319A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x000337AC File Offset: 0x000319AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x000337B8 File Offset: 0x000319B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Id);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Level);
			}
			if (this.Index != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Index);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0003384C File Offset: 0x00031A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x000338D4 File Offset: 0x00031AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeAvatarInfo other)
		{
			if (other == null)
			{
				return;
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
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0003394C File Offset: 0x00031B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00033958 File Offset: 0x00031B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 32U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Index = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400077D RID: 1917
		private static readonly MessageParser<ChallengeAvatarInfo> _parser = new MessageParser<ChallengeAvatarInfo>(() => new ChallengeAvatarInfo());

		// Token: 0x0400077E RID: 1918
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400077F RID: 1919
		public const int AvatarTypeFieldNumber = 15;

		// Token: 0x04000780 RID: 1920
		private AvatarType avatarType_;

		// Token: 0x04000781 RID: 1921
		public const int IdFieldNumber = 4;

		// Token: 0x04000782 RID: 1922
		private uint id_;

		// Token: 0x04000783 RID: 1923
		public const int LevelFieldNumber = 10;

		// Token: 0x04000784 RID: 1924
		private uint level_;

		// Token: 0x04000785 RID: 1925
		public const int IndexFieldNumber = 12;

		// Token: 0x04000786 RID: 1926
		private uint index_;
	}
}
