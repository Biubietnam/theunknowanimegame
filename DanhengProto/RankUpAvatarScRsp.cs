using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D77 RID: 3447
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RankUpAvatarScRsp : IMessage<RankUpAvatarScRsp>, IMessage, IEquatable<RankUpAvatarScRsp>, IDeepCloneable<RankUpAvatarScRsp>, IBufferMessage
	{
		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x06009A01 RID: 39425 RVA: 0x0019A174 File Offset: 0x00198374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RankUpAvatarScRsp> Parser
		{
			get
			{
				return RankUpAvatarScRsp._parser;
			}
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x06009A02 RID: 39426 RVA: 0x0019A17B File Offset: 0x0019837B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RankUpAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x06009A03 RID: 39427 RVA: 0x0019A18D File Offset: 0x0019838D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RankUpAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x06009A04 RID: 39428 RVA: 0x0019A194 File Offset: 0x00198394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpAvatarScRsp()
		{
		}

		// Token: 0x06009A05 RID: 39429 RVA: 0x0019A19C File Offset: 0x0019839C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpAvatarScRsp(RankUpAvatarScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A06 RID: 39430 RVA: 0x0019A1C1 File Offset: 0x001983C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpAvatarScRsp Clone()
		{
			return new RankUpAvatarScRsp(this);
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x06009A07 RID: 39431 RVA: 0x0019A1C9 File Offset: 0x001983C9
		// (set) Token: 0x06009A08 RID: 39432 RVA: 0x0019A1D1 File Offset: 0x001983D1
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

		// Token: 0x06009A09 RID: 39433 RVA: 0x0019A1DA File Offset: 0x001983DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RankUpAvatarScRsp);
		}

		// Token: 0x06009A0A RID: 39434 RVA: 0x0019A1E8 File Offset: 0x001983E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RankUpAvatarScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A0B RID: 39435 RVA: 0x0019A218 File Offset: 0x00198418
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

		// Token: 0x06009A0C RID: 39436 RVA: 0x0019A257 File Offset: 0x00198457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A0D RID: 39437 RVA: 0x0019A25F File Offset: 0x0019845F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A0E RID: 39438 RVA: 0x0019A268 File Offset: 0x00198468
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

		// Token: 0x06009A0F RID: 39439 RVA: 0x0019A29C File Offset: 0x0019849C
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

		// Token: 0x06009A10 RID: 39440 RVA: 0x0019A2DA File Offset: 0x001984DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RankUpAvatarScRsp other)
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

		// Token: 0x06009A11 RID: 39441 RVA: 0x0019A30B File Offset: 0x0019850B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x0019A314 File Offset: 0x00198514
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

		// Token: 0x04003BD2 RID: 15314
		private static readonly MessageParser<RankUpAvatarScRsp> _parser = new MessageParser<RankUpAvatarScRsp>(() => new RankUpAvatarScRsp());

		// Token: 0x04003BD3 RID: 15315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BD4 RID: 15316
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04003BD5 RID: 15317
		private uint retcode_;
	}
}
