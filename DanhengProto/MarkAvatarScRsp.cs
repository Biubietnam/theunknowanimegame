using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A83 RID: 2691
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MarkAvatarScRsp : IMessage<MarkAvatarScRsp>, IMessage, IEquatable<MarkAvatarScRsp>, IDeepCloneable<MarkAvatarScRsp>, IBufferMessage
	{
		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06007747 RID: 30535 RVA: 0x0013C6BD File Offset: 0x0013A8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkAvatarScRsp> Parser
		{
			get
			{
				return MarkAvatarScRsp._parser;
			}
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06007748 RID: 30536 RVA: 0x0013C6C4 File Offset: 0x0013A8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MarkAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06007749 RID: 30537 RVA: 0x0013C6D6 File Offset: 0x0013A8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x0013C6DD File Offset: 0x0013A8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkAvatarScRsp()
		{
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x0013C6E5 File Offset: 0x0013A8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkAvatarScRsp(MarkAvatarScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.isMarked_ = other.isMarked_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x0013C722 File Offset: 0x0013A922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkAvatarScRsp Clone()
		{
			return new MarkAvatarScRsp(this);
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x0600774D RID: 30541 RVA: 0x0013C72A File Offset: 0x0013A92A
		// (set) Token: 0x0600774E RID: 30542 RVA: 0x0013C732 File Offset: 0x0013A932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x0600774F RID: 30543 RVA: 0x0013C73B File Offset: 0x0013A93B
		// (set) Token: 0x06007750 RID: 30544 RVA: 0x0013C743 File Offset: 0x0013A943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMarked
		{
			get
			{
				return this.isMarked_;
			}
			set
			{
				this.isMarked_ = value;
			}
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06007751 RID: 30545 RVA: 0x0013C74C File Offset: 0x0013A94C
		// (set) Token: 0x06007752 RID: 30546 RVA: 0x0013C754 File Offset: 0x0013A954
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

		// Token: 0x06007753 RID: 30547 RVA: 0x0013C75D File Offset: 0x0013A95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkAvatarScRsp);
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x0013C76C File Offset: 0x0013A96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkAvatarScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.IsMarked == other.IsMarked && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x0013C7C8 File Offset: 0x0013A9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.IsMarked)
			{
				num ^= this.IsMarked.GetHashCode();
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

		// Token: 0x06007756 RID: 30550 RVA: 0x0013C839 File Offset: 0x0013AA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x0013C841 File Offset: 0x0013AA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x0013C84C File Offset: 0x0013AA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsMarked)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsMarked);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
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

		// Token: 0x06007759 RID: 30553 RVA: 0x0013C8C4 File Offset: 0x0013AAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.IsMarked)
			{
				num += 2;
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

		// Token: 0x0600775A RID: 30554 RVA: 0x0013C928 File Offset: 0x0013AB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkAvatarScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.IsMarked)
			{
				this.IsMarked = other.IsMarked;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x0013C98C File Offset: 0x0013AB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x0013C998 File Offset: 0x0013AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 72U)
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
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.IsMarked = input.ReadBool();
				}
			}
		}

		// Token: 0x04002DCF RID: 11727
		private static readonly MessageParser<MarkAvatarScRsp> _parser = new MessageParser<MarkAvatarScRsp>(() => new MarkAvatarScRsp());

		// Token: 0x04002DD0 RID: 11728
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DD1 RID: 11729
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04002DD2 RID: 11730
		private uint retcode_;

		// Token: 0x04002DD3 RID: 11731
		public const int IsMarkedFieldNumber = 7;

		// Token: 0x04002DD4 RID: 11732
		private bool isMarked_;

		// Token: 0x04002DD5 RID: 11733
		public const int AvatarIdFieldNumber = 11;

		// Token: 0x04002DD6 RID: 11734
		private uint avatarId_;
	}
}
