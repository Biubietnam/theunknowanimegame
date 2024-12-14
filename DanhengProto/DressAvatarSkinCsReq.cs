using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003D5 RID: 981
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DressAvatarSkinCsReq : IMessage<DressAvatarSkinCsReq>, IMessage, IEquatable<DressAvatarSkinCsReq>, IDeepCloneable<DressAvatarSkinCsReq>, IBufferMessage
	{
		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x00079844 File Offset: 0x00077A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DressAvatarSkinCsReq> Parser
		{
			get
			{
				return DressAvatarSkinCsReq._parser;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x0007984B File Offset: 0x00077A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DressAvatarSkinCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x0007985D File Offset: 0x00077A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DressAvatarSkinCsReq.Descriptor;
			}
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00079864 File Offset: 0x00077A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarSkinCsReq()
		{
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x0007986C File Offset: 0x00077A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarSkinCsReq(DressAvatarSkinCsReq other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x0007989D File Offset: 0x00077A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarSkinCsReq Clone()
		{
			return new DressAvatarSkinCsReq(this);
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x000798A5 File Offset: 0x00077AA5
		// (set) Token: 0x06002BB2 RID: 11186 RVA: 0x000798AD File Offset: 0x00077AAD
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

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x000798B6 File Offset: 0x00077AB6
		// (set) Token: 0x06002BB4 RID: 11188 RVA: 0x000798BE File Offset: 0x00077ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000798C7 File Offset: 0x00077AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DressAvatarSkinCsReq);
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000798D5 File Offset: 0x00077AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DressAvatarSkinCsReq other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00079914 File Offset: 0x00077B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.SkinId != 0U)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0007996C File Offset: 0x00077B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x00079974 File Offset: 0x00077B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x00079980 File Offset: 0x00077B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.SkinId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000799DC File Offset: 0x00077BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.SkinId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x00079A34 File Offset: 0x00077C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DressAvatarSkinCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.SkinId != 0U)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x00079A84 File Offset: 0x00077C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x00079A90 File Offset: 0x00077C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkinId = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040011B1 RID: 4529
		private static readonly MessageParser<DressAvatarSkinCsReq> _parser = new MessageParser<DressAvatarSkinCsReq>(() => new DressAvatarSkinCsReq());

		// Token: 0x040011B2 RID: 4530
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011B3 RID: 4531
		public const int AvatarIdFieldNumber = 3;

		// Token: 0x040011B4 RID: 4532
		private uint avatarId_;

		// Token: 0x040011B5 RID: 4533
		public const int SkinIdFieldNumber = 12;

		// Token: 0x040011B6 RID: 4534
		private uint skinId_;
	}
}
