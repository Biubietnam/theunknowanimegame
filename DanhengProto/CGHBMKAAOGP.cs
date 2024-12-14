using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200018B RID: 395
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CGHBMKAAOGP : IMessage<CGHBMKAAOGP>, IMessage, IEquatable<CGHBMKAAOGP>, IDeepCloneable<CGHBMKAAOGP>, IBufferMessage
	{
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00032A91 File Offset: 0x00030C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CGHBMKAAOGP> Parser
		{
			get
			{
				return CGHBMKAAOGP._parser;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00032A98 File Offset: 0x00030C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CGHBMKAAOGPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00032AAA File Offset: 0x00030CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CGHBMKAAOGP.Descriptor;
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00032AB1 File Offset: 0x00030CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CGHBMKAAOGP()
		{
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00032AB9 File Offset: 0x00030CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CGHBMKAAOGP(CGHBMKAAOGP other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00032AEA File Offset: 0x00030CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CGHBMKAAOGP Clone()
		{
			return new CGHBMKAAOGP(this);
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x00032AF2 File Offset: 0x00030CF2
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x00032AFA File Offset: 0x00030CFA
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

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00032B03 File Offset: 0x00030D03
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x00032B0B File Offset: 0x00030D0B
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

		// Token: 0x0600119C RID: 4508 RVA: 0x00032B14 File Offset: 0x00030D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CGHBMKAAOGP);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00032B22 File Offset: 0x00030D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CGHBMKAAOGP other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00032B60 File Offset: 0x00030D60
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

		// Token: 0x0600119F RID: 4511 RVA: 0x00032BBE File Offset: 0x00030DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00032BC6 File Offset: 0x00030DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00032BD0 File Offset: 0x00030DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00032C2C File Offset: 0x00030E2C
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

		// Token: 0x060011A3 RID: 4515 RVA: 0x00032C84 File Offset: 0x00030E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CGHBMKAAOGP other)
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

		// Token: 0x060011A4 RID: 4516 RVA: 0x00032CD4 File Offset: 0x00030ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00032CE0 File Offset: 0x00030EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 80U)
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

		// Token: 0x04000763 RID: 1891
		private static readonly MessageParser<CGHBMKAAOGP> _parser = new MessageParser<CGHBMKAAOGP>(() => new CGHBMKAAOGP());

		// Token: 0x04000764 RID: 1892
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000765 RID: 1893
		public const int AvatarTypeFieldNumber = 10;

		// Token: 0x04000766 RID: 1894
		private AvatarType avatarType_;

		// Token: 0x04000767 RID: 1895
		public const int AvatarIdFieldNumber = 8;

		// Token: 0x04000768 RID: 1896
		private uint avatarId_;
	}
}
