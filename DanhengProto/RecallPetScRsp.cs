using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D85 RID: 3461
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RecallPetScRsp : IMessage<RecallPetScRsp>, IMessage, IEquatable<RecallPetScRsp>, IDeepCloneable<RecallPetScRsp>, IBufferMessage
	{
		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x06009A85 RID: 39557 RVA: 0x0019B319 File Offset: 0x00199519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecallPetScRsp> Parser
		{
			get
			{
				return RecallPetScRsp._parser;
			}
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x06009A86 RID: 39558 RVA: 0x0019B320 File Offset: 0x00199520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecallPetScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x06009A87 RID: 39559 RVA: 0x0019B332 File Offset: 0x00199532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallPetScRsp.Descriptor;
			}
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x0019B339 File Offset: 0x00199539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallPetScRsp()
		{
		}

		// Token: 0x06009A89 RID: 39561 RVA: 0x0019B341 File Offset: 0x00199541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallPetScRsp(RecallPetScRsp other) : this()
		{
			this.curPetId_ = other.curPetId_;
			this.retcode_ = other.retcode_;
			this.newPetId_ = other.newPetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A8A RID: 39562 RVA: 0x0019B37E File Offset: 0x0019957E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallPetScRsp Clone()
		{
			return new RecallPetScRsp(this);
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x06009A8B RID: 39563 RVA: 0x0019B386 File Offset: 0x00199586
		// (set) Token: 0x06009A8C RID: 39564 RVA: 0x0019B38E File Offset: 0x0019958E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurPetId
		{
			get
			{
				return this.curPetId_;
			}
			set
			{
				this.curPetId_ = value;
			}
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x06009A8D RID: 39565 RVA: 0x0019B397 File Offset: 0x00199597
		// (set) Token: 0x06009A8E RID: 39566 RVA: 0x0019B39F File Offset: 0x0019959F
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

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x06009A8F RID: 39567 RVA: 0x0019B3A8 File Offset: 0x001995A8
		// (set) Token: 0x06009A90 RID: 39568 RVA: 0x0019B3B0 File Offset: 0x001995B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NewPetId
		{
			get
			{
				return this.newPetId_;
			}
			set
			{
				this.newPetId_ = value;
			}
		}

		// Token: 0x06009A91 RID: 39569 RVA: 0x0019B3B9 File Offset: 0x001995B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallPetScRsp);
		}

		// Token: 0x06009A92 RID: 39570 RVA: 0x0019B3C8 File Offset: 0x001995C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallPetScRsp other)
		{
			return other != null && (other == this || (this.CurPetId == other.CurPetId && this.Retcode == other.Retcode && this.NewPetId == other.NewPetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A93 RID: 39571 RVA: 0x0019B424 File Offset: 0x00199624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurPetId != 0U)
			{
				num ^= this.CurPetId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.NewPetId != 0U)
			{
				num ^= this.NewPetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A94 RID: 39572 RVA: 0x0019B495 File Offset: 0x00199695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A95 RID: 39573 RVA: 0x0019B49D File Offset: 0x0019969D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A96 RID: 39574 RVA: 0x0019B4A8 File Offset: 0x001996A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CurPetId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CurPetId);
			}
			if (this.NewPetId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.NewPetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A97 RID: 39575 RVA: 0x0019B520 File Offset: 0x00199720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurPetId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurPetId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.NewPetId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NewPetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A98 RID: 39576 RVA: 0x0019B590 File Offset: 0x00199790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallPetScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurPetId != 0U)
			{
				this.CurPetId = other.CurPetId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.NewPetId != 0U)
			{
				this.NewPetId = other.NewPetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A99 RID: 39577 RVA: 0x0019B5F4 File Offset: 0x001997F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x0019B600 File Offset: 0x00199800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NewPetId = input.ReadUInt32();
						}
					}
					else
					{
						this.CurPetId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003BFD RID: 15357
		private static readonly MessageParser<RecallPetScRsp> _parser = new MessageParser<RecallPetScRsp>(() => new RecallPetScRsp());

		// Token: 0x04003BFE RID: 15358
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BFF RID: 15359
		public const int CurPetIdFieldNumber = 6;

		// Token: 0x04003C00 RID: 15360
		private uint curPetId_;

		// Token: 0x04003C01 RID: 15361
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04003C02 RID: 15362
		private uint retcode_;

		// Token: 0x04003C03 RID: 15363
		public const int NewPetIdFieldNumber = 8;

		// Token: 0x04003C04 RID: 15364
		private uint newPetId_;
	}
}
