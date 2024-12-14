using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200036F RID: 879
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeleteBlacklistScRsp : IMessage<DeleteBlacklistScRsp>, IMessage, IEquatable<DeleteBlacklistScRsp>, IDeepCloneable<DeleteBlacklistScRsp>, IBufferMessage
	{
		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x0006D5BC File Offset: 0x0006B7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeleteBlacklistScRsp> Parser
		{
			get
			{
				return DeleteBlacklistScRsp._parser;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x0006D5C3 File Offset: 0x0006B7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeleteBlacklistScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x0006D5D5 File Offset: 0x0006B7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteBlacklistScRsp.Descriptor;
			}
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0006D5DC File Offset: 0x0006B7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteBlacklistScRsp()
		{
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x0006D5E4 File Offset: 0x0006B7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteBlacklistScRsp(DeleteBlacklistScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x0006D615 File Offset: 0x0006B815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteBlacklistScRsp Clone()
		{
			return new DeleteBlacklistScRsp(this);
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x0006D61D File Offset: 0x0006B81D
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x0006D625 File Offset: 0x0006B825
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

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x0006D62E File Offset: 0x0006B82E
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x0006D636 File Offset: 0x0006B836
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

		// Token: 0x06002726 RID: 10022 RVA: 0x0006D63F File Offset: 0x0006B83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteBlacklistScRsp);
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x0006D64D File Offset: 0x0006B84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteBlacklistScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x0006D68C File Offset: 0x0006B88C
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

		// Token: 0x06002729 RID: 10025 RVA: 0x0006D6E4 File Offset: 0x0006B8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x0006D6EC File Offset: 0x0006B8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0006D6F8 File Offset: 0x0006B8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x0006D754 File Offset: 0x0006B954
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

		// Token: 0x0600272D RID: 10029 RVA: 0x0006D7AC File Offset: 0x0006B9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteBlacklistScRsp other)
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

		// Token: 0x0600272E RID: 10030 RVA: 0x0006D7FC File Offset: 0x0006B9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x0006D808 File Offset: 0x0006BA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 120U)
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
		}

		// Token: 0x04000FCC RID: 4044
		private static readonly MessageParser<DeleteBlacklistScRsp> _parser = new MessageParser<DeleteBlacklistScRsp>(() => new DeleteBlacklistScRsp());

		// Token: 0x04000FCD RID: 4045
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FCE RID: 4046
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04000FCF RID: 4047
		private uint retcode_;

		// Token: 0x04000FD0 RID: 4048
		public const int UidFieldNumber = 15;

		// Token: 0x04000FD1 RID: 4049
		private uint uid_;
	}
}
