using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003DB RID: 987
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DressRelicAvatarScRsp : IMessage<DressRelicAvatarScRsp>, IMessage, IEquatable<DressRelicAvatarScRsp>, IDeepCloneable<DressRelicAvatarScRsp>, IBufferMessage
	{
		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x0007A134 File Offset: 0x00078334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DressRelicAvatarScRsp> Parser
		{
			get
			{
				return DressRelicAvatarScRsp._parser;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x0007A13B File Offset: 0x0007833B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DressRelicAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x0007A14D File Offset: 0x0007834D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DressRelicAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x0007A154 File Offset: 0x00078354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressRelicAvatarScRsp()
		{
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0007A15C File Offset: 0x0007835C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressRelicAvatarScRsp(DressRelicAvatarScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x0007A181 File Offset: 0x00078381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressRelicAvatarScRsp Clone()
		{
			return new DressRelicAvatarScRsp(this);
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x0007A189 File Offset: 0x00078389
		// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x0007A191 File Offset: 0x00078391
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

		// Token: 0x06002BF5 RID: 11253 RVA: 0x0007A19A File Offset: 0x0007839A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DressRelicAvatarScRsp);
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x0007A1A8 File Offset: 0x000783A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DressRelicAvatarScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x0007A1D8 File Offset: 0x000783D8
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

		// Token: 0x06002BF8 RID: 11256 RVA: 0x0007A217 File Offset: 0x00078417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x0007A21F File Offset: 0x0007841F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x0007A228 File Offset: 0x00078428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x0007A25C File Offset: 0x0007845C
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

		// Token: 0x06002BFC RID: 11260 RVA: 0x0007A29A File Offset: 0x0007849A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DressRelicAvatarScRsp other)
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

		// Token: 0x06002BFD RID: 11261 RVA: 0x0007A2CB File Offset: 0x000784CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x0007A2D4 File Offset: 0x000784D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040011C5 RID: 4549
		private static readonly MessageParser<DressRelicAvatarScRsp> _parser = new MessageParser<DressRelicAvatarScRsp>(() => new DressRelicAvatarScRsp());

		// Token: 0x040011C6 RID: 4550
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011C7 RID: 4551
		public const int RetcodeFieldNumber = 9;

		// Token: 0x040011C8 RID: 4552
		private uint retcode_;
	}
}
