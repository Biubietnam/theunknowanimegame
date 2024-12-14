using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000AB RID: 171
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ApplyFriendScRsp : IMessage<ApplyFriendScRsp>, IMessage, IEquatable<ApplyFriendScRsp>, IDeepCloneable<ApplyFriendScRsp>, IBufferMessage
	{
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00014E44 File Offset: 0x00013044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ApplyFriendScRsp> Parser
		{
			get
			{
				return ApplyFriendScRsp._parser;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00014E4B File Offset: 0x0001304B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ApplyFriendScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00014E5D File Offset: 0x0001305D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyFriendScRsp.Descriptor;
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00014E64 File Offset: 0x00013064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyFriendScRsp()
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00014E6C File Offset: 0x0001306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyFriendScRsp(ApplyFriendScRsp other) : this()
		{
			this.uid_ = other.uid_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00014E9D File Offset: 0x0001309D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyFriendScRsp Clone()
		{
			return new ApplyFriendScRsp(this);
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00014EA5 File Offset: 0x000130A5
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00014EAD File Offset: 0x000130AD
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

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00014EB6 File Offset: 0x000130B6
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00014EBE File Offset: 0x000130BE
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

		// Token: 0x0600076B RID: 1899 RVA: 0x00014EC7 File Offset: 0x000130C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyFriendScRsp);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00014ED5 File Offset: 0x000130D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyFriendScRsp other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00014F14 File Offset: 0x00013114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00014F6C File Offset: 0x0001316C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00014F74 File Offset: 0x00013174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00014F80 File Offset: 0x00013180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00014FDC File Offset: 0x000131DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00015034 File Offset: 0x00013234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyFriendScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00015084 File Offset: 0x00013284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00015090 File Offset: 0x00013290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 64U)
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

		// Token: 0x040002BE RID: 702
		private static readonly MessageParser<ApplyFriendScRsp> _parser = new MessageParser<ApplyFriendScRsp>(() => new ApplyFriendScRsp());

		// Token: 0x040002BF RID: 703
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002C0 RID: 704
		public const int UidFieldNumber = 8;

		// Token: 0x040002C1 RID: 705
		private uint uid_;

		// Token: 0x040002C2 RID: 706
		public const int RetcodeFieldNumber = 7;

		// Token: 0x040002C3 RID: 707
		private uint retcode_;
	}
}
