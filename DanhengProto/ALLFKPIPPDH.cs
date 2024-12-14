using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200009D RID: 157
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ALLFKPIPPDH : IMessage<ALLFKPIPPDH>, IMessage, IEquatable<ALLFKPIPPDH>, IDeepCloneable<ALLFKPIPPDH>, IBufferMessage
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00012E71 File Offset: 0x00011071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ALLFKPIPPDH> Parser
		{
			get
			{
				return ALLFKPIPPDH._parser;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00012E78 File Offset: 0x00011078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ALLFKPIPPDHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00012E8A File Offset: 0x0001108A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ALLFKPIPPDH.Descriptor;
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00012E91 File Offset: 0x00011091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ALLFKPIPPDH()
		{
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00012E99 File Offset: 0x00011099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ALLFKPIPPDH(ALLFKPIPPDH other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00012ECA File Offset: 0x000110CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ALLFKPIPPDH Clone()
		{
			return new ALLFKPIPPDH(this);
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00012ED2 File Offset: 0x000110D2
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00012EDA File Offset: 0x000110DA
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

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00012EE3 File Offset: 0x000110E3
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00012EEB File Offset: 0x000110EB
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

		// Token: 0x060006B4 RID: 1716 RVA: 0x00012EF4 File Offset: 0x000110F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ALLFKPIPPDH);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00012F02 File Offset: 0x00011102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ALLFKPIPPDH other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00012F40 File Offset: 0x00011140
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

		// Token: 0x060006B7 RID: 1719 RVA: 0x00012F9E File Offset: 0x0001119E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00012FA6 File Offset: 0x000111A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00012FB0 File Offset: 0x000111B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(40);
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

		// Token: 0x060006BA RID: 1722 RVA: 0x0001300C File Offset: 0x0001120C
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

		// Token: 0x060006BB RID: 1723 RVA: 0x00013064 File Offset: 0x00011264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ALLFKPIPPDH other)
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

		// Token: 0x060006BC RID: 1724 RVA: 0x000130B4 File Offset: 0x000112B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000130C0 File Offset: 0x000112C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
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

		// Token: 0x04000277 RID: 631
		private static readonly MessageParser<ALLFKPIPPDH> _parser = new MessageParser<ALLFKPIPPDH>(() => new ALLFKPIPPDH());

		// Token: 0x04000278 RID: 632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000279 RID: 633
		public const int AvatarTypeFieldNumber = 12;

		// Token: 0x0400027A RID: 634
		private AvatarType avatarType_;

		// Token: 0x0400027B RID: 635
		public const int AvatarIdFieldNumber = 5;

		// Token: 0x0400027C RID: 636
		private uint avatarId_;
	}
}
