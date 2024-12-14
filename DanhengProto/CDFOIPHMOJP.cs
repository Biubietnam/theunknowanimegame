using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000175 RID: 373
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CDFOIPHMOJP : IMessage<CDFOIPHMOJP>, IMessage, IEquatable<CDFOIPHMOJP>, IDeepCloneable<CDFOIPHMOJP>, IBufferMessage
	{
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00030111 File Offset: 0x0002E311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CDFOIPHMOJP> Parser
		{
			get
			{
				return CDFOIPHMOJP._parser;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00030118 File Offset: 0x0002E318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CDFOIPHMOJPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0003012A File Offset: 0x0002E32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CDFOIPHMOJP.Descriptor;
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00030131 File Offset: 0x0002E331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CDFOIPHMOJP()
		{
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00030139 File Offset: 0x0002E339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CDFOIPHMOJP(CDFOIPHMOJP other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.avatarType_ = other.avatarType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0003016A File Offset: 0x0002E36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CDFOIPHMOJP Clone()
		{
			return new CDFOIPHMOJP(this);
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00030172 File Offset: 0x0002E372
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x0003017A File Offset: 0x0002E37A
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x00030183 File Offset: 0x0002E383
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x0003018B File Offset: 0x0002E38B
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

		// Token: 0x060010AA RID: 4266 RVA: 0x00030194 File Offset: 0x0002E394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CDFOIPHMOJP);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000301A2 File Offset: 0x0002E3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CDFOIPHMOJP other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.AvatarType == other.AvatarType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000301E0 File Offset: 0x0002E3E0
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

		// Token: 0x060010AD RID: 4269 RVA: 0x0003023E File Offset: 0x0002E43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00030246 File Offset: 0x0002E446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00030250 File Offset: 0x0002E450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x000302AC File Offset: 0x0002E4AC
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

		// Token: 0x060010B1 RID: 4273 RVA: 0x00030304 File Offset: 0x0002E504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CDFOIPHMOJP other)
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

		// Token: 0x060010B2 RID: 4274 RVA: 0x00030354 File Offset: 0x0002E554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00030360 File Offset: 0x0002E560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 104U)
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

		// Token: 0x040006FA RID: 1786
		private static readonly MessageParser<CDFOIPHMOJP> _parser = new MessageParser<CDFOIPHMOJP>(() => new CDFOIPHMOJP());

		// Token: 0x040006FB RID: 1787
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006FC RID: 1788
		public const int AvatarIdFieldNumber = 6;

		// Token: 0x040006FD RID: 1789
		private uint avatarId_;

		// Token: 0x040006FE RID: 1790
		public const int AvatarTypeFieldNumber = 13;

		// Token: 0x040006FF RID: 1791
		private AvatarType avatarType_;
	}
}
