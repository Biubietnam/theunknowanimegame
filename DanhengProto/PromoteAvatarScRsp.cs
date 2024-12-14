using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D0B RID: 3339
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PromoteAvatarScRsp : IMessage<PromoteAvatarScRsp>, IMessage, IEquatable<PromoteAvatarScRsp>, IDeepCloneable<PromoteAvatarScRsp>, IBufferMessage
	{
		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x0600951A RID: 38170 RVA: 0x0018C64C File Offset: 0x0018A84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PromoteAvatarScRsp> Parser
		{
			get
			{
				return PromoteAvatarScRsp._parser;
			}
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x0600951B RID: 38171 RVA: 0x0018C653 File Offset: 0x0018A853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PromoteAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x0600951C RID: 38172 RVA: 0x0018C665 File Offset: 0x0018A865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PromoteAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x0018C66C File Offset: 0x0018A86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteAvatarScRsp()
		{
		}

		// Token: 0x0600951E RID: 38174 RVA: 0x0018C674 File Offset: 0x0018A874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteAvatarScRsp(PromoteAvatarScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600951F RID: 38175 RVA: 0x0018C699 File Offset: 0x0018A899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteAvatarScRsp Clone()
		{
			return new PromoteAvatarScRsp(this);
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x06009520 RID: 38176 RVA: 0x0018C6A1 File Offset: 0x0018A8A1
		// (set) Token: 0x06009521 RID: 38177 RVA: 0x0018C6A9 File Offset: 0x0018A8A9
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

		// Token: 0x06009522 RID: 38178 RVA: 0x0018C6B2 File Offset: 0x0018A8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PromoteAvatarScRsp);
		}

		// Token: 0x06009523 RID: 38179 RVA: 0x0018C6C0 File Offset: 0x0018A8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PromoteAvatarScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009524 RID: 38180 RVA: 0x0018C6F0 File Offset: 0x0018A8F0
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

		// Token: 0x06009525 RID: 38181 RVA: 0x0018C72F File Offset: 0x0018A92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x0018C737 File Offset: 0x0018A937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x0018C740 File Offset: 0x0018A940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x0018C774 File Offset: 0x0018A974
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

		// Token: 0x06009529 RID: 38185 RVA: 0x0018C7B2 File Offset: 0x0018A9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PromoteAvatarScRsp other)
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

		// Token: 0x0600952A RID: 38186 RVA: 0x0018C7E3 File Offset: 0x0018A9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x0018C7EC File Offset: 0x0018A9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040039CF RID: 14799
		private static readonly MessageParser<PromoteAvatarScRsp> _parser = new MessageParser<PromoteAvatarScRsp>(() => new PromoteAvatarScRsp());

		// Token: 0x040039D0 RID: 14800
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039D1 RID: 14801
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040039D2 RID: 14802
		private uint retcode_;
	}
}
