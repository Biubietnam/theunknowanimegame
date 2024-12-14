using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000717 RID: 1815
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMaterialSubmitActivityDataScRsp : IMessage<GetMaterialSubmitActivityDataScRsp>, IMessage, IEquatable<GetMaterialSubmitActivityDataScRsp>, IDeepCloneable<GetMaterialSubmitActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06005118 RID: 20760 RVA: 0x000DA617 File Offset: 0x000D8817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMaterialSubmitActivityDataScRsp> Parser
		{
			get
			{
				return GetMaterialSubmitActivityDataScRsp._parser;
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06005119 RID: 20761 RVA: 0x000DA61E File Offset: 0x000D881E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMaterialSubmitActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x0600511A RID: 20762 RVA: 0x000DA630 File Offset: 0x000D8830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMaterialSubmitActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x000DA637 File Offset: 0x000D8837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMaterialSubmitActivityDataScRsp()
		{
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x000DA64A File Offset: 0x000D884A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMaterialSubmitActivityDataScRsp(GetMaterialSubmitActivityDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.mIDJLJELJHD_ = other.mIDJLJELJHD_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x000DA680 File Offset: 0x000D8880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMaterialSubmitActivityDataScRsp Clone()
		{
			return new GetMaterialSubmitActivityDataScRsp(this);
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x000DA688 File Offset: 0x000D8888
		// (set) Token: 0x0600511F RID: 20767 RVA: 0x000DA690 File Offset: 0x000D8890
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

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x000DA699 File Offset: 0x000D8899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ONLKNGEBBIE> MIDJLJELJHD
		{
			get
			{
				return this.mIDJLJELJHD_;
			}
		}

		// Token: 0x06005121 RID: 20769 RVA: 0x000DA6A1 File Offset: 0x000D88A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMaterialSubmitActivityDataScRsp);
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x000DA6B0 File Offset: 0x000D88B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMaterialSubmitActivityDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.mIDJLJELJHD_.Equals(other.mIDJLJELJHD_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005123 RID: 20771 RVA: 0x000DA700 File Offset: 0x000D8900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.mIDJLJELJHD_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005124 RID: 20772 RVA: 0x000DA74D File Offset: 0x000D894D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x000DA755 File Offset: 0x000D8955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x000DA760 File Offset: 0x000D8960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mIDJLJELJHD_.WriteTo(ref output, GetMaterialSubmitActivityDataScRsp._repeated_mIDJLJELJHD_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x000DA7B0 File Offset: 0x000D89B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.mIDJLJELJHD_.CalculateSize(GetMaterialSubmitActivityDataScRsp._repeated_mIDJLJELJHD_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x000DA804 File Offset: 0x000D8A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMaterialSubmitActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.mIDJLJELJHD_.Add(other.mIDJLJELJHD_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x000DA851 File Offset: 0x000D8A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x000DA85C File Offset: 0x000D8A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 80U)
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
					this.mIDJLJELJHD_.AddEntriesFrom(ref input, GetMaterialSubmitActivityDataScRsp._repeated_mIDJLJELJHD_codec);
				}
			}
		}

		// Token: 0x04001FDC RID: 8156
		private static readonly MessageParser<GetMaterialSubmitActivityDataScRsp> _parser = new MessageParser<GetMaterialSubmitActivityDataScRsp>(() => new GetMaterialSubmitActivityDataScRsp());

		// Token: 0x04001FDD RID: 8157
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FDE RID: 8158
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04001FDF RID: 8159
		private uint retcode_;

		// Token: 0x04001FE0 RID: 8160
		public const int MIDJLJELJHDFieldNumber = 6;

		// Token: 0x04001FE1 RID: 8161
		private static readonly FieldCodec<ONLKNGEBBIE> _repeated_mIDJLJELJHD_codec = FieldCodec.ForMessage<ONLKNGEBBIE>(50U, ONLKNGEBBIE.Parser);

		// Token: 0x04001FE2 RID: 8162
		private readonly RepeatedField<ONLKNGEBBIE> mIDJLJELJHD_ = new RepeatedField<ONLKNGEBBIE>();
	}
}
