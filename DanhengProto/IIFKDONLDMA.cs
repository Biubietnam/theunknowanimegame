using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000923 RID: 2339
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IIFKDONLDMA : IMessage<IIFKDONLDMA>, IMessage, IEquatable<IIFKDONLDMA>, IDeepCloneable<IIFKDONLDMA>, IBufferMessage
	{
		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06006854 RID: 26708 RVA: 0x001169FD File Offset: 0x00114BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IIFKDONLDMA> Parser
		{
			get
			{
				return IIFKDONLDMA._parser;
			}
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06006855 RID: 26709 RVA: 0x00116A04 File Offset: 0x00114C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IIFKDONLDMAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06006856 RID: 26710 RVA: 0x00116A16 File Offset: 0x00114C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IIFKDONLDMA.Descriptor;
			}
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x00116A1D File Offset: 0x00114C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IIFKDONLDMA()
		{
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x00116A25 File Offset: 0x00114C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IIFKDONLDMA(IIFKDONLDMA other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x00116A56 File Offset: 0x00114C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IIFKDONLDMA Clone()
		{
			return new IIFKDONLDMA(this);
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x00116A5E File Offset: 0x00114C5E
		// (set) Token: 0x0600685B RID: 26715 RVA: 0x00116A66 File Offset: 0x00114C66
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

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x0600685C RID: 26716 RVA: 0x00116A6F File Offset: 0x00114C6F
		// (set) Token: 0x0600685D RID: 26717 RVA: 0x00116A77 File Offset: 0x00114C77
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

		// Token: 0x0600685E RID: 26718 RVA: 0x00116A80 File Offset: 0x00114C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IIFKDONLDMA);
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x00116A8E File Offset: 0x00114C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IIFKDONLDMA other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x00116ACC File Offset: 0x00114CCC
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

		// Token: 0x06006861 RID: 26721 RVA: 0x00116B2A File Offset: 0x00114D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x00116B32 File Offset: 0x00114D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00116B3C File Offset: 0x00114D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x00116B98 File Offset: 0x00114D98
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

		// Token: 0x06006865 RID: 26725 RVA: 0x00116BF0 File Offset: 0x00114DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IIFKDONLDMA other)
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

		// Token: 0x06006866 RID: 26726 RVA: 0x00116C40 File Offset: 0x00114E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x00116C4C File Offset: 0x00114E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvatarId = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarType = (AvatarType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002808 RID: 10248
		private static readonly MessageParser<IIFKDONLDMA> _parser = new MessageParser<IIFKDONLDMA>(() => new IIFKDONLDMA());

		// Token: 0x04002809 RID: 10249
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400280A RID: 10250
		public const int AvatarTypeFieldNumber = 9;

		// Token: 0x0400280B RID: 10251
		private AvatarType avatarType_;

		// Token: 0x0400280C RID: 10252
		public const int AvatarIdFieldNumber = 10;

		// Token: 0x0400280D RID: 10253
		private uint avatarId_;
	}
}
