using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009C1 RID: 2497
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KLIKDPDIJMI : IMessage<KLIKDPDIJMI>, IMessage, IEquatable<KLIKDPDIJMI>, IDeepCloneable<KLIKDPDIJMI>, IBufferMessage
	{
		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x06006F6B RID: 28523 RVA: 0x001296B9 File Offset: 0x001278B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KLIKDPDIJMI> Parser
		{
			get
			{
				return KLIKDPDIJMI._parser;
			}
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x06006F6C RID: 28524 RVA: 0x001296C0 File Offset: 0x001278C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KLIKDPDIJMIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x06006F6D RID: 28525 RVA: 0x001296D2 File Offset: 0x001278D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KLIKDPDIJMI.Descriptor;
			}
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x001296D9 File Offset: 0x001278D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KLIKDPDIJMI()
		{
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x001296E1 File Offset: 0x001278E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KLIKDPDIJMI(KLIKDPDIJMI other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x00129712 File Offset: 0x00127912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KLIKDPDIJMI Clone()
		{
			return new KLIKDPDIJMI(this);
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x06006F71 RID: 28529 RVA: 0x0012971A File Offset: 0x0012791A
		// (set) Token: 0x06006F72 RID: 28530 RVA: 0x00129722 File Offset: 0x00127922
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

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x06006F73 RID: 28531 RVA: 0x0012972B File Offset: 0x0012792B
		// (set) Token: 0x06006F74 RID: 28532 RVA: 0x00129733 File Offset: 0x00127933
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

		// Token: 0x06006F75 RID: 28533 RVA: 0x0012973C File Offset: 0x0012793C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KLIKDPDIJMI);
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x0012974A File Offset: 0x0012794A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KLIKDPDIJMI other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x00129788 File Offset: 0x00127988
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

		// Token: 0x06006F78 RID: 28536 RVA: 0x001297E6 File Offset: 0x001279E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x001297EE File Offset: 0x001279EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x001297F8 File Offset: 0x001279F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x00129854 File Offset: 0x00127A54
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

		// Token: 0x06006F7C RID: 28540 RVA: 0x001298AC File Offset: 0x00127AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KLIKDPDIJMI other)
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

		// Token: 0x06006F7D RID: 28541 RVA: 0x001298FC File Offset: 0x00127AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x00129908 File Offset: 0x00127B08
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
						this.AvatarId = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarType = (AvatarType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002AD5 RID: 10965
		private static readonly MessageParser<KLIKDPDIJMI> _parser = new MessageParser<KLIKDPDIJMI>(() => new KLIKDPDIJMI());

		// Token: 0x04002AD6 RID: 10966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AD7 RID: 10967
		public const int AvatarTypeFieldNumber = 3;

		// Token: 0x04002AD8 RID: 10968
		private AvatarType avatarType_;

		// Token: 0x04002AD9 RID: 10969
		public const int AvatarIdFieldNumber = 11;

		// Token: 0x04002ADA RID: 10970
		private uint avatarId_;
	}
}
