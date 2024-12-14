using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007A7 RID: 1959
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueAeonInfoScRsp : IMessage<GetRogueAeonInfoScRsp>, IMessage, IEquatable<GetRogueAeonInfoScRsp>, IDeepCloneable<GetRogueAeonInfoScRsp>, IBufferMessage
	{
		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x000EA465 File Offset: 0x000E8665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueAeonInfoScRsp> Parser
		{
			get
			{
				return GetRogueAeonInfoScRsp._parser;
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06005779 RID: 22393 RVA: 0x000EA46C File Offset: 0x000E866C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueAeonInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x000EA47E File Offset: 0x000E867E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueAeonInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x000EA485 File Offset: 0x000E8685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAeonInfoScRsp()
		{
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x000EA498 File Offset: 0x000E8698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAeonInfoScRsp(GetRogueAeonInfoScRsp other) : this()
		{
			this.mKEENINMLEP_ = other.mKEENINMLEP_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x000EA4CE File Offset: 0x000E86CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAeonInfoScRsp Clone()
		{
			return new GetRogueAeonInfoScRsp(this);
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x0600577E RID: 22398 RVA: 0x000EA4D6 File Offset: 0x000E86D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ALFJMIPDIBO> MKEENINMLEP
		{
			get
			{
				return this.mKEENINMLEP_;
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x0600577F RID: 22399 RVA: 0x000EA4DE File Offset: 0x000E86DE
		// (set) Token: 0x06005780 RID: 22400 RVA: 0x000EA4E6 File Offset: 0x000E86E6
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

		// Token: 0x06005781 RID: 22401 RVA: 0x000EA4EF File Offset: 0x000E86EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueAeonInfoScRsp);
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x000EA500 File Offset: 0x000E8700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueAeonInfoScRsp other)
		{
			return other != null && (other == this || (this.mKEENINMLEP_.Equals(other.mKEENINMLEP_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x000EA550 File Offset: 0x000E8750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mKEENINMLEP_.GetHashCode();
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

		// Token: 0x06005784 RID: 22404 RVA: 0x000EA59D File Offset: 0x000E879D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x000EA5A5 File Offset: 0x000E87A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x000EA5B0 File Offset: 0x000E87B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.mKEENINMLEP_.WriteTo(ref output, GetRogueAeonInfoScRsp._repeated_mKEENINMLEP_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005787 RID: 22407 RVA: 0x000EA600 File Offset: 0x000E8800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mKEENINMLEP_.CalculateSize(GetRogueAeonInfoScRsp._repeated_mKEENINMLEP_codec);
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

		// Token: 0x06005788 RID: 22408 RVA: 0x000EA654 File Offset: 0x000E8854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueAeonInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.mKEENINMLEP_.Add(other.mKEENINMLEP_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005789 RID: 22409 RVA: 0x000EA6A1 File Offset: 0x000E88A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600578A RID: 22410 RVA: 0x000EA6AC File Offset: 0x000E88AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.mKEENINMLEP_.AddEntriesFrom(ref input, GetRogueAeonInfoScRsp._repeated_mKEENINMLEP_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400222C RID: 8748
		private static readonly MessageParser<GetRogueAeonInfoScRsp> _parser = new MessageParser<GetRogueAeonInfoScRsp>(() => new GetRogueAeonInfoScRsp());

		// Token: 0x0400222D RID: 8749
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400222E RID: 8750
		public const int MKEENINMLEPFieldNumber = 13;

		// Token: 0x0400222F RID: 8751
		private static readonly FieldCodec<ALFJMIPDIBO> _repeated_mKEENINMLEP_codec = FieldCodec.ForMessage<ALFJMIPDIBO>(106U, ALFJMIPDIBO.Parser);

		// Token: 0x04002230 RID: 8752
		private readonly RepeatedField<ALFJMIPDIBO> mKEENINMLEP_ = new RepeatedField<ALFJMIPDIBO>();

		// Token: 0x04002231 RID: 8753
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04002232 RID: 8754
		private uint retcode_;
	}
}
