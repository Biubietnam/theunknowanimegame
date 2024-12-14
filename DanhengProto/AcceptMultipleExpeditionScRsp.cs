using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000023 RID: 35
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptMultipleExpeditionScRsp : IMessage<AcceptMultipleExpeditionScRsp>, IMessage, IEquatable<AcceptMultipleExpeditionScRsp>, IDeepCloneable<AcceptMultipleExpeditionScRsp>, IBufferMessage
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00004D3B File Offset: 0x00002F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptMultipleExpeditionScRsp> Parser
		{
			get
			{
				return AcceptMultipleExpeditionScRsp._parser;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00004D42 File Offset: 0x00002F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptMultipleExpeditionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00004D54 File Offset: 0x00002F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptMultipleExpeditionScRsp.Descriptor;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004D5B File Offset: 0x00002F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMultipleExpeditionScRsp()
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004D6E File Offset: 0x00002F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMultipleExpeditionScRsp(AcceptMultipleExpeditionScRsp other) : this()
		{
			this.gAHHPNGKLFH_ = other.gAHHPNGKLFH_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004DA4 File Offset: 0x00002FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMultipleExpeditionScRsp Clone()
		{
			return new AcceptMultipleExpeditionScRsp(this);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00004DAC File Offset: 0x00002FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JLHHCIJPOPD> GAHHPNGKLFH
		{
			get
			{
				return this.gAHHPNGKLFH_;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00004DB4 File Offset: 0x00002FB4
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00004DBC File Offset: 0x00002FBC
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

		// Token: 0x06000146 RID: 326 RVA: 0x00004DC5 File Offset: 0x00002FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptMultipleExpeditionScRsp);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00004DD4 File Offset: 0x00002FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptMultipleExpeditionScRsp other)
		{
			return other != null && (other == this || (this.gAHHPNGKLFH_.Equals(other.gAHHPNGKLFH_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00004E24 File Offset: 0x00003024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gAHHPNGKLFH_.GetHashCode();
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

		// Token: 0x06000149 RID: 329 RVA: 0x00004E71 File Offset: 0x00003071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00004E79 File Offset: 0x00003079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004E84 File Offset: 0x00003084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.gAHHPNGKLFH_.WriteTo(ref output, AcceptMultipleExpeditionScRsp._repeated_gAHHPNGKLFH_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00004ED4 File Offset: 0x000030D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gAHHPNGKLFH_.CalculateSize(AcceptMultipleExpeditionScRsp._repeated_gAHHPNGKLFH_codec);
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

		// Token: 0x0600014D RID: 333 RVA: 0x00004F28 File Offset: 0x00003128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptMultipleExpeditionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.gAHHPNGKLFH_.Add(other.gAHHPNGKLFH_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00004F75 File Offset: 0x00003175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00004F80 File Offset: 0x00003180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gAHHPNGKLFH_.AddEntriesFrom(ref input, AcceptMultipleExpeditionScRsp._repeated_gAHHPNGKLFH_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000069 RID: 105
		private static readonly MessageParser<AcceptMultipleExpeditionScRsp> _parser = new MessageParser<AcceptMultipleExpeditionScRsp>(() => new AcceptMultipleExpeditionScRsp());

		// Token: 0x0400006A RID: 106
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400006B RID: 107
		public const int GAHHPNGKLFHFieldNumber = 7;

		// Token: 0x0400006C RID: 108
		private static readonly FieldCodec<JLHHCIJPOPD> _repeated_gAHHPNGKLFH_codec = FieldCodec.ForMessage<JLHHCIJPOPD>(58U, JLHHCIJPOPD.Parser);

		// Token: 0x0400006D RID: 109
		private readonly RepeatedField<JLHHCIJPOPD> gAHHPNGKLFH_ = new RepeatedField<JLHHCIJPOPD>();

		// Token: 0x0400006E RID: 110
		public const int RetcodeFieldNumber = 4;

		// Token: 0x0400006F RID: 111
		private uint retcode_;
	}
}
