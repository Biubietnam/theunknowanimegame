using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200069F RID: 1695
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFeverTimeActivityDataScRsp : IMessage<GetFeverTimeActivityDataScRsp>, IMessage, IEquatable<GetFeverTimeActivityDataScRsp>, IDeepCloneable<GetFeverTimeActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06004BE1 RID: 19425 RVA: 0x000CE03B File Offset: 0x000CC23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFeverTimeActivityDataScRsp> Parser
		{
			get
			{
				return GetFeverTimeActivityDataScRsp._parser;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06004BE2 RID: 19426 RVA: 0x000CE042 File Offset: 0x000CC242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFeverTimeActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06004BE3 RID: 19427 RVA: 0x000CE054 File Offset: 0x000CC254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFeverTimeActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x000CE05B File Offset: 0x000CC25B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFeverTimeActivityDataScRsp()
		{
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x000CE06E File Offset: 0x000CC26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFeverTimeActivityDataScRsp(GetFeverTimeActivityDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.kECKGLJLILM_ = other.kECKGLJLILM_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BE6 RID: 19430 RVA: 0x000CE0A4 File Offset: 0x000CC2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFeverTimeActivityDataScRsp Clone()
		{
			return new GetFeverTimeActivityDataScRsp(this);
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x000CE0AC File Offset: 0x000CC2AC
		// (set) Token: 0x06004BE8 RID: 19432 RVA: 0x000CE0B4 File Offset: 0x000CC2B4
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

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x000CE0BD File Offset: 0x000CC2BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FeverTimeActivityData> KECKGLJLILM
		{
			get
			{
				return this.kECKGLJLILM_;
			}
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x000CE0C5 File Offset: 0x000CC2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFeverTimeActivityDataScRsp);
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x000CE0D4 File Offset: 0x000CC2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFeverTimeActivityDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.kECKGLJLILM_.Equals(other.kECKGLJLILM_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x000CE124 File Offset: 0x000CC324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.kECKGLJLILM_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x000CE171 File Offset: 0x000CC371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x000CE179 File Offset: 0x000CC379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x000CE184 File Offset: 0x000CC384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kECKGLJLILM_.WriteTo(ref output, GetFeverTimeActivityDataScRsp._repeated_kECKGLJLILM_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x000CE1D4 File Offset: 0x000CC3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.kECKGLJLILM_.CalculateSize(GetFeverTimeActivityDataScRsp._repeated_kECKGLJLILM_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x000CE228 File Offset: 0x000CC428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFeverTimeActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.kECKGLJLILM_.Add(other.kECKGLJLILM_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x000CE275 File Offset: 0x000CC475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x000CE280 File Offset: 0x000CC480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.kECKGLJLILM_.AddEntriesFrom(ref input, GetFeverTimeActivityDataScRsp._repeated_kECKGLJLILM_codec);
				}
			}
		}

		// Token: 0x04001E0B RID: 7691
		private static readonly MessageParser<GetFeverTimeActivityDataScRsp> _parser = new MessageParser<GetFeverTimeActivityDataScRsp>(() => new GetFeverTimeActivityDataScRsp());

		// Token: 0x04001E0C RID: 7692
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E0D RID: 7693
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04001E0E RID: 7694
		private uint retcode_;

		// Token: 0x04001E0F RID: 7695
		public const int KECKGLJLILMFieldNumber = 2;

		// Token: 0x04001E10 RID: 7696
		private static readonly FieldCodec<FeverTimeActivityData> _repeated_kECKGLJLILM_codec = FieldCodec.ForMessage<FeverTimeActivityData>(18U, FeverTimeActivityData.Parser);

		// Token: 0x04001E11 RID: 7697
		private readonly RepeatedField<FeverTimeActivityData> kECKGLJLILM_ = new RepeatedField<FeverTimeActivityData>();
	}
}
