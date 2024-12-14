using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000373 RID: 883
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeleteFriendScRsp : IMessage<DeleteFriendScRsp>, IMessage, IEquatable<DeleteFriendScRsp>, IDeepCloneable<DeleteFriendScRsp>, IBufferMessage
	{
		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x0006DC24 File Offset: 0x0006BE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeleteFriendScRsp> Parser
		{
			get
			{
				return DeleteFriendScRsp._parser;
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x0006DC2B File Offset: 0x0006BE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeleteFriendScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x0006DC3D File Offset: 0x0006BE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteFriendScRsp.Descriptor;
			}
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x0006DC44 File Offset: 0x0006BE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteFriendScRsp()
		{
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0006DC4C File Offset: 0x0006BE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteFriendScRsp(DeleteFriendScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x0006DC7D File Offset: 0x0006BE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteFriendScRsp Clone()
		{
			return new DeleteFriendScRsp(this);
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x0006DC85 File Offset: 0x0006BE85
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x0006DC8D File Offset: 0x0006BE8D
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

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x0006DC96 File Offset: 0x0006BE96
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x0006DC9E File Offset: 0x0006BE9E
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

		// Token: 0x06002754 RID: 10068 RVA: 0x0006DCA7 File Offset: 0x0006BEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteFriendScRsp);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0006DCB5 File Offset: 0x0006BEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteFriendScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x0006DCF4 File Offset: 0x0006BEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
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

		// Token: 0x06002757 RID: 10071 RVA: 0x0006DD4C File Offset: 0x0006BF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x0006DD54 File Offset: 0x0006BF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x0006DD60 File Offset: 0x0006BF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Uid);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0006DDB8 File Offset: 0x0006BFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
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

		// Token: 0x0600275B RID: 10075 RVA: 0x0006DE10 File Offset: 0x0006C010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteFriendScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x0006DE60 File Offset: 0x0006C060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x0006DE6C File Offset: 0x0006C06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000FDA RID: 4058
		private static readonly MessageParser<DeleteFriendScRsp> _parser = new MessageParser<DeleteFriendScRsp>(() => new DeleteFriendScRsp());

		// Token: 0x04000FDB RID: 4059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FDC RID: 4060
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04000FDD RID: 4061
		private uint retcode_;

		// Token: 0x04000FDE RID: 4062
		public const int UidFieldNumber = 1;

		// Token: 0x04000FDF RID: 4063
		private uint uid_;
	}
}
