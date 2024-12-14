using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B39 RID: 2873
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGameRaiseRatioScRsp : IMessage<MonopolyGameRaiseRatioScRsp>, IMessage, IEquatable<MonopolyGameRaiseRatioScRsp>, IDeepCloneable<MonopolyGameRaiseRatioScRsp>, IBufferMessage
	{
		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x06007F27 RID: 32551 RVA: 0x0014FF4D File Offset: 0x0014E14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGameRaiseRatioScRsp> Parser
		{
			get
			{
				return MonopolyGameRaiseRatioScRsp._parser;
			}
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x06007F28 RID: 32552 RVA: 0x0014FF54 File Offset: 0x0014E154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGameRaiseRatioScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x06007F29 RID: 32553 RVA: 0x0014FF66 File Offset: 0x0014E166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGameRaiseRatioScRsp.Descriptor;
			}
		}

		// Token: 0x06007F2A RID: 32554 RVA: 0x0014FF6D File Offset: 0x0014E16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameRaiseRatioScRsp()
		{
		}

		// Token: 0x06007F2B RID: 32555 RVA: 0x0014FF75 File Offset: 0x0014E175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameRaiseRatioScRsp(MonopolyGameRaiseRatioScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.ratio_ = other.ratio_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F2C RID: 32556 RVA: 0x0014FFA6 File Offset: 0x0014E1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameRaiseRatioScRsp Clone()
		{
			return new MonopolyGameRaiseRatioScRsp(this);
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x06007F2D RID: 32557 RVA: 0x0014FFAE File Offset: 0x0014E1AE
		// (set) Token: 0x06007F2E RID: 32558 RVA: 0x0014FFB6 File Offset: 0x0014E1B6
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

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x06007F2F RID: 32559 RVA: 0x0014FFBF File Offset: 0x0014E1BF
		// (set) Token: 0x06007F30 RID: 32560 RVA: 0x0014FFC7 File Offset: 0x0014E1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Ratio
		{
			get
			{
				return this.ratio_;
			}
			set
			{
				this.ratio_ = value;
			}
		}

		// Token: 0x06007F31 RID: 32561 RVA: 0x0014FFD0 File Offset: 0x0014E1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGameRaiseRatioScRsp);
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x0014FFDE File Offset: 0x0014E1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGameRaiseRatioScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Ratio == other.Ratio && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x0015001C File Offset: 0x0014E21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Ratio != 0U)
			{
				num ^= this.Ratio.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x00150074 File Offset: 0x0014E274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F35 RID: 32565 RVA: 0x0015007C File Offset: 0x0014E27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F36 RID: 32566 RVA: 0x00150088 File Offset: 0x0014E288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Ratio != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Ratio);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x001500E4 File Offset: 0x0014E2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Ratio != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Ratio);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F38 RID: 32568 RVA: 0x0015013C File Offset: 0x0014E33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGameRaiseRatioScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Ratio != 0U)
			{
				this.Ratio = other.Ratio;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F39 RID: 32569 RVA: 0x0015018C File Offset: 0x0014E38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x00150198 File Offset: 0x0014E398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Ratio = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040030B6 RID: 12470
		private static readonly MessageParser<MonopolyGameRaiseRatioScRsp> _parser = new MessageParser<MonopolyGameRaiseRatioScRsp>(() => new MonopolyGameRaiseRatioScRsp());

		// Token: 0x040030B7 RID: 12471
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030B8 RID: 12472
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040030B9 RID: 12473
		private uint retcode_;

		// Token: 0x040030BA RID: 12474
		public const int RatioFieldNumber = 11;

		// Token: 0x040030BB RID: 12475
		private uint ratio_;
	}
}
