using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CED RID: 3309
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PMCFMHJGKCE : IMessage<PMCFMHJGKCE>, IMessage, IEquatable<PMCFMHJGKCE>, IDeepCloneable<PMCFMHJGKCE>, IBufferMessage
	{
		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x060093C4 RID: 37828 RVA: 0x00188EE5 File Offset: 0x001870E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PMCFMHJGKCE> Parser
		{
			get
			{
				return PMCFMHJGKCE._parser;
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x00188EEC File Offset: 0x001870EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PMCFMHJGKCEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x060093C6 RID: 37830 RVA: 0x00188EFE File Offset: 0x001870FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PMCFMHJGKCE.Descriptor;
			}
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x00188F05 File Offset: 0x00187105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMCFMHJGKCE()
		{
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x00188F0D File Offset: 0x0018710D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMCFMHJGKCE(PMCFMHJGKCE other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x00188F3E File Offset: 0x0018713E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMCFMHJGKCE Clone()
		{
			return new PMCFMHJGKCE(this);
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x060093CA RID: 37834 RVA: 0x00188F46 File Offset: 0x00187146
		// (set) Token: 0x060093CB RID: 37835 RVA: 0x00188F4E File Offset: 0x0018714E
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

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x060093CC RID: 37836 RVA: 0x00188F57 File Offset: 0x00187157
		// (set) Token: 0x060093CD RID: 37837 RVA: 0x00188F5F File Offset: 0x0018715F
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

		// Token: 0x060093CE RID: 37838 RVA: 0x00188F68 File Offset: 0x00187168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PMCFMHJGKCE);
		}

		// Token: 0x060093CF RID: 37839 RVA: 0x00188F76 File Offset: 0x00187176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PMCFMHJGKCE other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x00188FB4 File Offset: 0x001871B4
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

		// Token: 0x060093D1 RID: 37841 RVA: 0x00189012 File Offset: 0x00187212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060093D2 RID: 37842 RVA: 0x0018901A File Offset: 0x0018721A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093D3 RID: 37843 RVA: 0x00189024 File Offset: 0x00187224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093D4 RID: 37844 RVA: 0x00189080 File Offset: 0x00187280
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

		// Token: 0x060093D5 RID: 37845 RVA: 0x001890D8 File Offset: 0x001872D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PMCFMHJGKCE other)
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

		// Token: 0x060093D6 RID: 37846 RVA: 0x00189128 File Offset: 0x00187328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093D7 RID: 37847 RVA: 0x00189134 File Offset: 0x00187334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 40U)
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

		// Token: 0x0400393F RID: 14655
		private static readonly MessageParser<PMCFMHJGKCE> _parser = new MessageParser<PMCFMHJGKCE>(() => new PMCFMHJGKCE());

		// Token: 0x04003940 RID: 14656
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003941 RID: 14657
		public const int AvatarTypeFieldNumber = 2;

		// Token: 0x04003942 RID: 14658
		private AvatarType avatarType_;

		// Token: 0x04003943 RID: 14659
		public const int AvatarIdFieldNumber = 5;

		// Token: 0x04003944 RID: 14660
		private uint avatarId_;
	}
}
