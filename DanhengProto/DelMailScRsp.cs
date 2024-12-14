using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000383 RID: 899
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DelMailScRsp : IMessage<DelMailScRsp>, IMessage, IEquatable<DelMailScRsp>, IDeepCloneable<DelMailScRsp>, IBufferMessage
	{
		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x0006F470 File Offset: 0x0006D670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DelMailScRsp> Parser
		{
			get
			{
				return DelMailScRsp._parser;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x0006F477 File Offset: 0x0006D677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DelMailScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x0006F489 File Offset: 0x0006D689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DelMailScRsp.Descriptor;
			}
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x0006F490 File Offset: 0x0006D690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DelMailScRsp()
		{
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x0006F4A3 File Offset: 0x0006D6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DelMailScRsp(DelMailScRsp other) : this()
		{
			this.idList_ = other.idList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x0006F4D9 File Offset: 0x0006D6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DelMailScRsp Clone()
		{
			return new DelMailScRsp(this);
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x0006F4E1 File Offset: 0x0006D6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IdList
		{
			get
			{
				return this.idList_;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x0006F4E9 File Offset: 0x0006D6E9
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x0006F4F1 File Offset: 0x0006D6F1
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

		// Token: 0x06002800 RID: 10240 RVA: 0x0006F4FA File Offset: 0x0006D6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DelMailScRsp);
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x0006F508 File Offset: 0x0006D708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DelMailScRsp other)
		{
			return other != null && (other == this || (this.idList_.Equals(other.idList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x0006F558 File Offset: 0x0006D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.idList_.GetHashCode();
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

		// Token: 0x06002803 RID: 10243 RVA: 0x0006F5A5 File Offset: 0x0006D7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x0006F5AD File Offset: 0x0006D7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x0006F5B8 File Offset: 0x0006D7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			this.idList_.WriteTo(ref output, DelMailScRsp._repeated_idList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x0006F608 File Offset: 0x0006D808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.idList_.CalculateSize(DelMailScRsp._repeated_idList_codec);
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

		// Token: 0x06002807 RID: 10247 RVA: 0x0006F65C File Offset: 0x0006D85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DelMailScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.idList_.Add(other.idList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x0006F6A9 File Offset: 0x0006D8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x0006F6B4 File Offset: 0x0006D8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U && num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.idList_.AddEntriesFrom(ref input, DelMailScRsp._repeated_idList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001015 RID: 4117
		private static readonly MessageParser<DelMailScRsp> _parser = new MessageParser<DelMailScRsp>(() => new DelMailScRsp());

		// Token: 0x04001016 RID: 4118
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001017 RID: 4119
		public const int IdListFieldNumber = 11;

		// Token: 0x04001018 RID: 4120
		private static readonly FieldCodec<uint> _repeated_idList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04001019 RID: 4121
		private readonly RepeatedField<uint> idList_ = new RepeatedField<uint>();

		// Token: 0x0400101A RID: 4122
		public const int RetcodeFieldNumber = 3;

		// Token: 0x0400101B RID: 4123
		private uint retcode_;
	}
}
