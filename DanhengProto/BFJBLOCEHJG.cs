using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200011B RID: 283
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BFJBLOCEHJG : IMessage<BFJBLOCEHJG>, IMessage, IEquatable<BFJBLOCEHJG>, IDeepCloneable<BFJBLOCEHJG>, IBufferMessage
	{
		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00026551 File Offset: 0x00024751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BFJBLOCEHJG> Parser
		{
			get
			{
				return BFJBLOCEHJG._parser;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00026558 File Offset: 0x00024758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BFJBLOCEHJGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0002656A File Offset: 0x0002476A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BFJBLOCEHJG.Descriptor;
			}
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00026571 File Offset: 0x00024771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFJBLOCEHJG()
		{
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00026579 File Offset: 0x00024779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFJBLOCEHJG(BFJBLOCEHJG other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.avatarType_ = other.avatarType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000265AA File Offset: 0x000247AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFJBLOCEHJG Clone()
		{
			return new BFJBLOCEHJG(this);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x000265B2 File Offset: 0x000247B2
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x000265BA File Offset: 0x000247BA
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

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x000265C3 File Offset: 0x000247C3
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x000265CB File Offset: 0x000247CB
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

		// Token: 0x06000CC0 RID: 3264 RVA: 0x000265D4 File Offset: 0x000247D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BFJBLOCEHJG);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x000265E2 File Offset: 0x000247E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BFJBLOCEHJG other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.AvatarType == other.AvatarType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00026620 File Offset: 0x00024820
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

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0002667E File Offset: 0x0002487E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00026686 File Offset: 0x00024886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00026690 File Offset: 0x00024890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000266EC File Offset: 0x000248EC
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

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00026744 File Offset: 0x00024944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BFJBLOCEHJG other)
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

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00026794 File Offset: 0x00024994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x000267A0 File Offset: 0x000249A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 72U)
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

		// Token: 0x0400058B RID: 1419
		private static readonly MessageParser<BFJBLOCEHJG> _parser = new MessageParser<BFJBLOCEHJG>(() => new BFJBLOCEHJG());

		// Token: 0x0400058C RID: 1420
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400058D RID: 1421
		public const int AvatarIdFieldNumber = 9;

		// Token: 0x0400058E RID: 1422
		private uint avatarId_;

		// Token: 0x0400058F RID: 1423
		public const int AvatarTypeFieldNumber = 6;

		// Token: 0x04000590 RID: 1424
		private AvatarType avatarType_;
	}
}
