using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003D3 RID: 979
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DressAvatarScRsp : IMessage<DressAvatarScRsp>, IMessage, IEquatable<DressAvatarScRsp>, IDeepCloneable<DressAvatarScRsp>, IBufferMessage
	{
		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x000795CC File Offset: 0x000777CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DressAvatarScRsp> Parser
		{
			get
			{
				return DressAvatarScRsp._parser;
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x000795D3 File Offset: 0x000777D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DressAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x000795E5 File Offset: 0x000777E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DressAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000795EC File Offset: 0x000777EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarScRsp()
		{
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x000795F4 File Offset: 0x000777F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarScRsp(DressAvatarScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00079619 File Offset: 0x00077819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressAvatarScRsp Clone()
		{
			return new DressAvatarScRsp(this);
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002B9C RID: 11164 RVA: 0x00079621 File Offset: 0x00077821
		// (set) Token: 0x06002B9D RID: 11165 RVA: 0x00079629 File Offset: 0x00077829
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

		// Token: 0x06002B9E RID: 11166 RVA: 0x00079632 File Offset: 0x00077832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DressAvatarScRsp);
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x00079640 File Offset: 0x00077840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DressAvatarScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00079670 File Offset: 0x00077870
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

		// Token: 0x06002BA1 RID: 11169 RVA: 0x000796AF File Offset: 0x000778AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x000796B7 File Offset: 0x000778B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x000796C0 File Offset: 0x000778C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x000796F4 File Offset: 0x000778F4
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

		// Token: 0x06002BA5 RID: 11173 RVA: 0x00079732 File Offset: 0x00077932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DressAvatarScRsp other)
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

		// Token: 0x06002BA6 RID: 11174 RVA: 0x00079763 File Offset: 0x00077963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x0007976C File Offset: 0x0007796C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040011AC RID: 4524
		private static readonly MessageParser<DressAvatarScRsp> _parser = new MessageParser<DressAvatarScRsp>(() => new DressAvatarScRsp());

		// Token: 0x040011AD RID: 4525
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011AE RID: 4526
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040011AF RID: 4527
		private uint retcode_;
	}
}
