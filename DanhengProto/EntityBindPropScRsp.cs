using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000485 RID: 1157
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntityBindPropScRsp : IMessage<EntityBindPropScRsp>, IMessage, IEquatable<EntityBindPropScRsp>, IDeepCloneable<EntityBindPropScRsp>, IBufferMessage
	{
		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x0008D978 File Offset: 0x0008BB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityBindPropScRsp> Parser
		{
			get
			{
				return EntityBindPropScRsp._parser;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06003389 RID: 13193 RVA: 0x0008D97F File Offset: 0x0008BB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EntityBindPropScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x0008D991 File Offset: 0x0008BB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBindPropScRsp.Descriptor;
			}
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x0008D998 File Offset: 0x0008BB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBindPropScRsp()
		{
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x0008D9A0 File Offset: 0x0008BBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBindPropScRsp(EntityBindPropScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x0008D9C5 File Offset: 0x0008BBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBindPropScRsp Clone()
		{
			return new EntityBindPropScRsp(this);
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x0008D9CD File Offset: 0x0008BBCD
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x0008D9D5 File Offset: 0x0008BBD5
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

		// Token: 0x06003390 RID: 13200 RVA: 0x0008D9DE File Offset: 0x0008BBDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBindPropScRsp);
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x0008D9EC File Offset: 0x0008BBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBindPropScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x0008DA1C File Offset: 0x0008BC1C
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

		// Token: 0x06003393 RID: 13203 RVA: 0x0008DA5B File Offset: 0x0008BC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x0008DA63 File Offset: 0x0008BC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x0008DA6C File Offset: 0x0008BC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x0008DAA0 File Offset: 0x0008BCA0
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

		// Token: 0x06003397 RID: 13207 RVA: 0x0008DADE File Offset: 0x0008BCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBindPropScRsp other)
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

		// Token: 0x06003398 RID: 13208 RVA: 0x0008DB0F File Offset: 0x0008BD0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x0008DB18 File Offset: 0x0008BD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001478 RID: 5240
		private static readonly MessageParser<EntityBindPropScRsp> _parser = new MessageParser<EntityBindPropScRsp>(() => new EntityBindPropScRsp());

		// Token: 0x04001479 RID: 5241
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400147A RID: 5242
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400147B RID: 5243
		private uint retcode_;
	}
}
