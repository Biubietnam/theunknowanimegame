using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007EB RID: 2027
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSecretKeyInfoScRsp : IMessage<GetSecretKeyInfoScRsp>, IMessage, IEquatable<GetSecretKeyInfoScRsp>, IDeepCloneable<GetSecretKeyInfoScRsp>, IBufferMessage
	{
		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x06005A6B RID: 23147 RVA: 0x000F116F File Offset: 0x000EF36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSecretKeyInfoScRsp> Parser
		{
			get
			{
				return GetSecretKeyInfoScRsp._parser;
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x06005A6C RID: 23148 RVA: 0x000F1176 File Offset: 0x000EF376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSecretKeyInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x06005A6D RID: 23149 RVA: 0x000F1188 File Offset: 0x000EF388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSecretKeyInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x000F118F File Offset: 0x000EF38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSecretKeyInfoScRsp()
		{
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x000F11B0 File Offset: 0x000EF3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSecretKeyInfoScRsp(GetSecretKeyInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.lIBNNLNDHCN_ = other.lIBNNLNDHCN_;
			this.secretInfo_ = other.secretInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x000F11FD File Offset: 0x000EF3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSecretKeyInfoScRsp Clone()
		{
			return new GetSecretKeyInfoScRsp(this);
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x06005A71 RID: 23153 RVA: 0x000F1205 File Offset: 0x000EF405
		// (set) Token: 0x06005A72 RID: 23154 RVA: 0x000F120D File Offset: 0x000EF40D
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

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06005A73 RID: 23155 RVA: 0x000F1216 File Offset: 0x000EF416
		// (set) Token: 0x06005A74 RID: 23156 RVA: 0x000F121E File Offset: 0x000EF41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString LIBNNLNDHCN
		{
			get
			{
				return this.lIBNNLNDHCN_;
			}
			set
			{
				this.lIBNNLNDHCN_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x06005A75 RID: 23157 RVA: 0x000F1231 File Offset: 0x000EF431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SecretKeyInfo> SecretInfo
		{
			get
			{
				return this.secretInfo_;
			}
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x000F1239 File Offset: 0x000EF439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSecretKeyInfoScRsp);
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x000F1248 File Offset: 0x000EF448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSecretKeyInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && !(this.LIBNNLNDHCN != other.LIBNNLNDHCN) && this.secretInfo_.Equals(other.secretInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x000F12AC File Offset: 0x000EF4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.LIBNNLNDHCN.Length != 0)
			{
				num ^= this.LIBNNLNDHCN.GetHashCode();
			}
			num ^= this.secretInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x000F1314 File Offset: 0x000EF514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x000F131C File Offset: 0x000EF51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x000F1328 File Offset: 0x000EF528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.secretInfo_.WriteTo(ref output, GetSecretKeyInfoScRsp._repeated_secretInfo_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.LIBNNLNDHCN.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.LIBNNLNDHCN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x000F1398 File Offset: 0x000EF598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.LIBNNLNDHCN.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.LIBNNLNDHCN);
			}
			num += this.secretInfo_.CalculateSize(GetSecretKeyInfoScRsp._repeated_secretInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A7D RID: 23165 RVA: 0x000F1408 File Offset: 0x000EF608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSecretKeyInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.LIBNNLNDHCN.Length != 0)
			{
				this.LIBNNLNDHCN = other.LIBNNLNDHCN;
			}
			this.secretInfo_.Add(other.secretInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x000F146E File Offset: 0x000EF66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x000F1478 File Offset: 0x000EF678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 48U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LIBNNLNDHCN = input.ReadBytes();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.secretInfo_.AddEntriesFrom(ref input, GetSecretKeyInfoScRsp._repeated_secretInfo_codec);
				}
			}
		}

		// Token: 0x04002319 RID: 8985
		private static readonly MessageParser<GetSecretKeyInfoScRsp> _parser = new MessageParser<GetSecretKeyInfoScRsp>(() => new GetSecretKeyInfoScRsp());

		// Token: 0x0400231A RID: 8986
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400231B RID: 8987
		public const int RetcodeFieldNumber = 6;

		// Token: 0x0400231C RID: 8988
		private uint retcode_;

		// Token: 0x0400231D RID: 8989
		public const int LIBNNLNDHCNFieldNumber = 7;

		// Token: 0x0400231E RID: 8990
		private ByteString lIBNNLNDHCN_ = ByteString.Empty;

		// Token: 0x0400231F RID: 8991
		public const int SecretInfoFieldNumber = 3;

		// Token: 0x04002320 RID: 8992
		private static readonly FieldCodec<SecretKeyInfo> _repeated_secretInfo_codec = FieldCodec.ForMessage<SecretKeyInfo>(26U, SecretKeyInfo.Parser);

		// Token: 0x04002321 RID: 8993
		private readonly RepeatedField<SecretKeyInfo> secretInfo_ = new RepeatedField<SecretKeyInfo>();
	}
}
