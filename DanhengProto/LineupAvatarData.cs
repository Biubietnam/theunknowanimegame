using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A11 RID: 2577
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LineupAvatarData : IMessage<LineupAvatarData>, IMessage, IEquatable<LineupAvatarData>, IDeepCloneable<LineupAvatarData>, IBufferMessage
	{
		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x0600726A RID: 29290 RVA: 0x00130699 File Offset: 0x0012E899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LineupAvatarData> Parser
		{
			get
			{
				return LineupAvatarData._parser;
			}
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x0600726B RID: 29291 RVA: 0x001306A0 File Offset: 0x0012E8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LineupAvatarDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x0600726C RID: 29292 RVA: 0x001306B2 File Offset: 0x0012E8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineupAvatarData.Descriptor;
			}
		}

		// Token: 0x0600726D RID: 29293 RVA: 0x001306B9 File Offset: 0x0012E8B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupAvatarData()
		{
		}

		// Token: 0x0600726E RID: 29294 RVA: 0x001306C1 File Offset: 0x0012E8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupAvatarData(LineupAvatarData other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.hp_ = other.hp_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x001306FE File Offset: 0x0012E8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupAvatarData Clone()
		{
			return new LineupAvatarData(this);
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x06007270 RID: 29296 RVA: 0x00130706 File Offset: 0x0012E906
		// (set) Token: 0x06007271 RID: 29297 RVA: 0x0013070E File Offset: 0x0012E90E
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

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x06007272 RID: 29298 RVA: 0x00130717 File Offset: 0x0012E917
		// (set) Token: 0x06007273 RID: 29299 RVA: 0x0013071F File Offset: 0x0012E91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Hp
		{
			get
			{
				return this.hp_;
			}
			set
			{
				this.hp_ = value;
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06007274 RID: 29300 RVA: 0x00130728 File Offset: 0x0012E928
		// (set) Token: 0x06007275 RID: 29301 RVA: 0x00130730 File Offset: 0x0012E930
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

		// Token: 0x06007276 RID: 29302 RVA: 0x00130739 File Offset: 0x0012E939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineupAvatarData);
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x00130748 File Offset: 0x0012E948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineupAvatarData other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.Hp == other.Hp && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x001307A4 File Offset: 0x0012E9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.Hp != 0U)
			{
				num ^= this.Hp.GetHashCode();
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

		// Token: 0x06007279 RID: 29305 RVA: 0x0013081B File Offset: 0x0012EA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x00130823 File Offset: 0x0012EA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x0013082C File Offset: 0x0012EA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Id);
			}
			if (this.Hp != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Hp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x001308A4 File Offset: 0x0012EAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.Hp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Hp);
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

		// Token: 0x0600727D RID: 29309 RVA: 0x00130914 File Offset: 0x0012EB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineupAvatarData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.Hp != 0U)
			{
				this.Hp = other.Hp;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x00130978 File Offset: 0x0012EB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600727F RID: 29311 RVA: 0x00130984 File Offset: 0x0012EB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 72U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Hp = input.ReadUInt32();
						}
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarType = (AvatarType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002BF9 RID: 11257
		private static readonly MessageParser<LineupAvatarData> _parser = new MessageParser<LineupAvatarData>(() => new LineupAvatarData());

		// Token: 0x04002BFA RID: 11258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BFB RID: 11259
		public const int AvatarTypeFieldNumber = 3;

		// Token: 0x04002BFC RID: 11260
		private AvatarType avatarType_;

		// Token: 0x04002BFD RID: 11261
		public const int HpFieldNumber = 14;

		// Token: 0x04002BFE RID: 11262
		private uint hp_;

		// Token: 0x04002BFF RID: 11263
		public const int IdFieldNumber = 9;

		// Token: 0x04002C00 RID: 11264
		private uint id_;
	}
}
