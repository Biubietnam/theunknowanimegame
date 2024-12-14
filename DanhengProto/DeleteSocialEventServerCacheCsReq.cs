using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000379 RID: 889
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeleteSocialEventServerCacheCsReq : IMessage<DeleteSocialEventServerCacheCsReq>, IMessage, IEquatable<DeleteSocialEventServerCacheCsReq>, IDeepCloneable<DeleteSocialEventServerCacheCsReq>, IBufferMessage
	{
		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x0006E689 File Offset: 0x0006C889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeleteSocialEventServerCacheCsReq> Parser
		{
			get
			{
				return DeleteSocialEventServerCacheCsReq._parser;
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x0006E690 File Offset: 0x0006C890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeleteSocialEventServerCacheCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x0006E6A2 File Offset: 0x0006C8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteSocialEventServerCacheCsReq.Descriptor;
			}
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x0006E6A9 File Offset: 0x0006C8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSocialEventServerCacheCsReq()
		{
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x0006E6BC File Offset: 0x0006C8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSocialEventServerCacheCsReq(DeleteSocialEventServerCacheCsReq other) : this()
		{
			this.cFGEBGPMGAN_ = other.cFGEBGPMGAN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x0006E6E6 File Offset: 0x0006C8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSocialEventServerCacheCsReq Clone()
		{
			return new DeleteSocialEventServerCacheCsReq(this);
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x0006E6EE File Offset: 0x0006C8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> CFGEBGPMGAN
		{
			get
			{
				return this.cFGEBGPMGAN_;
			}
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x0006E6F6 File Offset: 0x0006C8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteSocialEventServerCacheCsReq);
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x0006E704 File Offset: 0x0006C904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteSocialEventServerCacheCsReq other)
		{
			return other != null && (other == this || (this.cFGEBGPMGAN_.Equals(other.cFGEBGPMGAN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x0006E738 File Offset: 0x0006C938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cFGEBGPMGAN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x0006E76C File Offset: 0x0006C96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x0006E774 File Offset: 0x0006C974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x0006E77D File Offset: 0x0006C97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cFGEBGPMGAN_.WriteTo(ref output, DeleteSocialEventServerCacheCsReq._repeated_cFGEBGPMGAN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x0006E7A4 File Offset: 0x0006C9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cFGEBGPMGAN_.CalculateSize(DeleteSocialEventServerCacheCsReq._repeated_cFGEBGPMGAN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x0006E7DD File Offset: 0x0006C9DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteSocialEventServerCacheCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.cFGEBGPMGAN_.Add(other.cFGEBGPMGAN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x0006E80B File Offset: 0x0006CA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x0006E814 File Offset: 0x0006CA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cFGEBGPMGAN_.AddEntriesFrom(ref input, DeleteSocialEventServerCacheCsReq._repeated_cFGEBGPMGAN_codec);
				}
			}
		}

		// Token: 0x04000FF3 RID: 4083
		private static readonly MessageParser<DeleteSocialEventServerCacheCsReq> _parser = new MessageParser<DeleteSocialEventServerCacheCsReq>(() => new DeleteSocialEventServerCacheCsReq());

		// Token: 0x04000FF4 RID: 4084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FF5 RID: 4085
		public const int CFGEBGPMGANFieldNumber = 7;

		// Token: 0x04000FF6 RID: 4086
		private static readonly FieldCodec<uint> _repeated_cFGEBGPMGAN_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04000FF7 RID: 4087
		private readonly RepeatedField<uint> cFGEBGPMGAN_ = new RepeatedField<uint>();
	}
}
