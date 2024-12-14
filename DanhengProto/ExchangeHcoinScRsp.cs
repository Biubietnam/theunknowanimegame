using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004D9 RID: 1241
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeHcoinScRsp : IMessage<ExchangeHcoinScRsp>, IMessage, IEquatable<ExchangeHcoinScRsp>, IDeepCloneable<ExchangeHcoinScRsp>, IBufferMessage
	{
		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x000984A4 File Offset: 0x000966A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeHcoinScRsp> Parser
		{
			get
			{
				return ExchangeHcoinScRsp._parser;
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06003780 RID: 14208 RVA: 0x000984AB File Offset: 0x000966AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExchangeHcoinScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06003781 RID: 14209 RVA: 0x000984BD File Offset: 0x000966BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeHcoinScRsp.Descriptor;
			}
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x000984C4 File Offset: 0x000966C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeHcoinScRsp()
		{
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x000984CC File Offset: 0x000966CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeHcoinScRsp(ExchangeHcoinScRsp other) : this()
		{
			this.num_ = other.num_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x000984FD File Offset: 0x000966FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeHcoinScRsp Clone()
		{
			return new ExchangeHcoinScRsp(this);
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06003785 RID: 14213 RVA: 0x00098505 File Offset: 0x00096705
		// (set) Token: 0x06003786 RID: 14214 RVA: 0x0009850D File Offset: 0x0009670D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x00098516 File Offset: 0x00096716
		// (set) Token: 0x06003788 RID: 14216 RVA: 0x0009851E File Offset: 0x0009671E
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

		// Token: 0x06003789 RID: 14217 RVA: 0x00098527 File Offset: 0x00096727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeHcoinScRsp);
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x00098535 File Offset: 0x00096735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeHcoinScRsp other)
		{
			return other != null && (other == this || (this.Num == other.Num && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00098574 File Offset: 0x00096774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
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

		// Token: 0x0600378C RID: 14220 RVA: 0x000985CC File Offset: 0x000967CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x000985D4 File Offset: 0x000967D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x000985E0 File Offset: 0x000967E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Num != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x0009863C File Offset: 0x0009683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
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

		// Token: 0x06003790 RID: 14224 RVA: 0x00098694 File Offset: 0x00096894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeHcoinScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x000986E4 File Offset: 0x000968E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x000986F0 File Offset: 0x000968F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Num = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040015FE RID: 5630
		private static readonly MessageParser<ExchangeHcoinScRsp> _parser = new MessageParser<ExchangeHcoinScRsp>(() => new ExchangeHcoinScRsp());

		// Token: 0x040015FF RID: 5631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001600 RID: 5632
		public const int NumFieldNumber = 15;

		// Token: 0x04001601 RID: 5633
		private uint num_;

		// Token: 0x04001602 RID: 5634
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04001603 RID: 5635
		private uint retcode_;
	}
}
