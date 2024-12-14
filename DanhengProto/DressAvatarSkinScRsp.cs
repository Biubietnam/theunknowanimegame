using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003D7 RID: 983
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DressAvatarSkinScRsp : IMessage<DressAvatarSkinScRsp>, IMessage, IEquatable<DressAvatarSkinScRsp>, IDeepCloneable<DressAvatarSkinScRsp>, IBufferMessage
	{
		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x00079B70 File Offset: 0x00077D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DressAvatarSkinScRsp> Parser
		{
			get
			{
				return DressAvatarSkinScRsp._parser;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x00079B77 File Offset: 0x00077D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DressAvatarSkinScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x00079B89 File Offset: 0x00077D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DressAvatarSkinScRsp.Descriptor;
			}
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x00079B90 File Offset: 0x00077D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarSkinScRsp()
		{
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x00079B98 File Offset: 0x00077D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarSkinScRsp(DressAvatarSkinScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x00079BBD File Offset: 0x00077DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarSkinScRsp Clone()
		{
			return new DressAvatarSkinScRsp(this);
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x00079BC5 File Offset: 0x00077DC5
		// (set) Token: 0x06002BC9 RID: 11209 RVA: 0x00079BCD File Offset: 0x00077DCD
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

		// Token: 0x06002BCA RID: 11210 RVA: 0x00079BD6 File Offset: 0x00077DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DressAvatarSkinScRsp);
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00079BE4 File Offset: 0x00077DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DressAvatarSkinScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x00079C14 File Offset: 0x00077E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06002BCD RID: 11213 RVA: 0x00079C53 File Offset: 0x00077E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x00079C5B File Offset: 0x00077E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00079C64 File Offset: 0x00077E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00079C98 File Offset: 0x00077E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00079CD6 File Offset: 0x00077ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DressAvatarSkinScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x00079D07 File Offset: 0x00077F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x00079D10 File Offset: 0x00077F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040011B8 RID: 4536
		private static readonly MessageParser<DressAvatarSkinScRsp> _parser = new MessageParser<DressAvatarSkinScRsp>(() => new DressAvatarSkinScRsp());

		// Token: 0x040011B9 RID: 4537
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011BA RID: 4538
		public const int RetcodeFieldNumber = 7;

		// Token: 0x040011BB RID: 4539
		private uint retcode_;
	}
}
