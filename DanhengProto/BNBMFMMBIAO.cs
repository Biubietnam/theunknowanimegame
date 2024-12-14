using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000137 RID: 311
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BNBMFMMBIAO : IMessage<BNBMFMMBIAO>, IMessage, IEquatable<BNBMFMMBIAO>, IDeepCloneable<BNBMFMMBIAO>, IBufferMessage
	{
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00029B45 File Offset: 0x00027D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BNBMFMMBIAO> Parser
		{
			get
			{
				return BNBMFMMBIAO._parser;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00029B4C File Offset: 0x00027D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BNBMFMMBIAOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00029B5E File Offset: 0x00027D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BNBMFMMBIAO.Descriptor;
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00029B65 File Offset: 0x00027D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BNBMFMMBIAO()
		{
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00029B6D File Offset: 0x00027D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BNBMFMMBIAO(BNBMFMMBIAO other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00029B9E File Offset: 0x00027D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BNBMFMMBIAO Clone()
		{
			return new BNBMFMMBIAO(this);
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00029BA6 File Offset: 0x00027DA6
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x00029BAE File Offset: 0x00027DAE
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

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00029BB7 File Offset: 0x00027DB7
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x00029BBF File Offset: 0x00027DBF
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

		// Token: 0x06000E07 RID: 3591 RVA: 0x00029BC8 File Offset: 0x00027DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BNBMFMMBIAO);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00029BD6 File Offset: 0x00027DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BNBMFMMBIAO other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00029C14 File Offset: 0x00027E14
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00029C72 File Offset: 0x00027E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00029C7A File Offset: 0x00027E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00029C84 File Offset: 0x00027E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Id);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00029CE0 File Offset: 0x00027EE0
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00029D38 File Offset: 0x00027F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BNBMFMMBIAO other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00029D88 File Offset: 0x00027F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00029D94 File Offset: 0x00027F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
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
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400060E RID: 1550
		private static readonly MessageParser<BNBMFMMBIAO> _parser = new MessageParser<BNBMFMMBIAO>(() => new BNBMFMMBIAO());

		// Token: 0x0400060F RID: 1551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000610 RID: 1552
		public const int AvatarTypeFieldNumber = 11;

		// Token: 0x04000611 RID: 1553
		private AvatarType avatarType_;

		// Token: 0x04000612 RID: 1554
		public const int IdFieldNumber = 3;

		// Token: 0x04000613 RID: 1555
		private uint id_;
	}
}
