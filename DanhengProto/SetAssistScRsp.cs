using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010CF RID: 4303
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetAssistScRsp : IMessage<SetAssistScRsp>, IMessage, IEquatable<SetAssistScRsp>, IDeepCloneable<SetAssistScRsp>, IBufferMessage
	{
		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600BFE0 RID: 49120 RVA: 0x0020485C File Offset: 0x00202A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetAssistScRsp> Parser
		{
			get
			{
				return SetAssistScRsp._parser;
			}
		}

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600BFE1 RID: 49121 RVA: 0x00204863 File Offset: 0x00202A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetAssistScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600BFE2 RID: 49122 RVA: 0x00204875 File Offset: 0x00202A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAssistScRsp.Descriptor;
			}
		}

		// Token: 0x0600BFE3 RID: 49123 RVA: 0x0020487C File Offset: 0x00202A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistScRsp()
		{
		}

		// Token: 0x0600BFE4 RID: 49124 RVA: 0x00204884 File Offset: 0x00202A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistScRsp(SetAssistScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.avatarId_ = other.avatarId_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFE5 RID: 49125 RVA: 0x002048C1 File Offset: 0x00202AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistScRsp Clone()
		{
			return new SetAssistScRsp(this);
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0600BFE6 RID: 49126 RVA: 0x002048C9 File Offset: 0x00202AC9
		// (set) Token: 0x0600BFE7 RID: 49127 RVA: 0x002048D1 File Offset: 0x00202AD1
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

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0600BFE8 RID: 49128 RVA: 0x002048DA File Offset: 0x00202ADA
		// (set) Token: 0x0600BFE9 RID: 49129 RVA: 0x002048E2 File Offset: 0x00202AE2
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

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0600BFEA RID: 49130 RVA: 0x002048EB File Offset: 0x00202AEB
		// (set) Token: 0x0600BFEB RID: 49131 RVA: 0x002048F3 File Offset: 0x00202AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x0600BFEC RID: 49132 RVA: 0x002048FC File Offset: 0x00202AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAssistScRsp);
		}

		// Token: 0x0600BFED RID: 49133 RVA: 0x0020490C File Offset: 0x00202B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAssistScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.AvatarId == other.AvatarId && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFEE RID: 49134 RVA: 0x00204968 File Offset: 0x00202B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BFEF RID: 49135 RVA: 0x002049D9 File Offset: 0x00202BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x002049E1 File Offset: 0x00202BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x002049EC File Offset: 0x00202BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BFF2 RID: 49138 RVA: 0x00204A64 File Offset: 0x00202C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BFF3 RID: 49139 RVA: 0x00204AD4 File Offset: 0x00202CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAssistScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BFF4 RID: 49140 RVA: 0x00204B38 File Offset: 0x00202D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFF5 RID: 49141 RVA: 0x00204B44 File Offset: 0x00202D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 72U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Uid = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004DDD RID: 19933
		private static readonly MessageParser<SetAssistScRsp> _parser = new MessageParser<SetAssistScRsp>(() => new SetAssistScRsp());

		// Token: 0x04004DDE RID: 19934
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DDF RID: 19935
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04004DE0 RID: 19936
		private uint retcode_;

		// Token: 0x04004DE1 RID: 19937
		public const int AvatarIdFieldNumber = 2;

		// Token: 0x04004DE2 RID: 19938
		private uint avatarId_;

		// Token: 0x04004DE3 RID: 19939
		public const int UidFieldNumber = 10;

		// Token: 0x04004DE4 RID: 19940
		private uint uid_;
	}
}
