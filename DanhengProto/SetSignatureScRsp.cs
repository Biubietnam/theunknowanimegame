using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001131 RID: 4401
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetSignatureScRsp : IMessage<SetSignatureScRsp>, IMessage, IEquatable<SetSignatureScRsp>, IDeepCloneable<SetSignatureScRsp>, IBufferMessage
	{
		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x0600C442 RID: 50242 RVA: 0x0020ED4C File Offset: 0x0020CF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetSignatureScRsp> Parser
		{
			get
			{
				return SetSignatureScRsp._parser;
			}
		}

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x0600C443 RID: 50243 RVA: 0x0020ED53 File Offset: 0x0020CF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetSignatureScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x0600C444 RID: 50244 RVA: 0x0020ED65 File Offset: 0x0020CF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetSignatureScRsp.Descriptor;
			}
		}

		// Token: 0x0600C445 RID: 50245 RVA: 0x0020ED6C File Offset: 0x0020CF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSignatureScRsp()
		{
		}

		// Token: 0x0600C446 RID: 50246 RVA: 0x0020ED7F File Offset: 0x0020CF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSignatureScRsp(SetSignatureScRsp other) : this()
		{
			this.signature_ = other.signature_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C447 RID: 50247 RVA: 0x0020EDB0 File Offset: 0x0020CFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetSignatureScRsp Clone()
		{
			return new SetSignatureScRsp(this);
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x0600C448 RID: 50248 RVA: 0x0020EDB8 File Offset: 0x0020CFB8
		// (set) Token: 0x0600C449 RID: 50249 RVA: 0x0020EDC0 File Offset: 0x0020CFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0600C44A RID: 50250 RVA: 0x0020EDD3 File Offset: 0x0020CFD3
		// (set) Token: 0x0600C44B RID: 50251 RVA: 0x0020EDDB File Offset: 0x0020CFDB
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

		// Token: 0x0600C44C RID: 50252 RVA: 0x0020EDE4 File Offset: 0x0020CFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetSignatureScRsp);
		}

		// Token: 0x0600C44D RID: 50253 RVA: 0x0020EDF4 File Offset: 0x0020CFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetSignatureScRsp other)
		{
			return other != null && (other == this || (!(this.Signature != other.Signature) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C44E RID: 50254 RVA: 0x0020EE44 File Offset: 0x0020D044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
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

		// Token: 0x0600C44F RID: 50255 RVA: 0x0020EE9E File Offset: 0x0020D09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C450 RID: 50256 RVA: 0x0020EEA6 File Offset: 0x0020D0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C451 RID: 50257 RVA: 0x0020EEB0 File Offset: 0x0020D0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Signature);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C452 RID: 50258 RVA: 0x0020EF10 File Offset: 0x0020D110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
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

		// Token: 0x0600C453 RID: 50259 RVA: 0x0020EF6C File Offset: 0x0020D16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetSignatureScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C454 RID: 50260 RVA: 0x0020EFC1 File Offset: 0x0020D1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C455 RID: 50261 RVA: 0x0020EFCC File Offset: 0x0020D1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Signature = input.ReadString();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004F51 RID: 20305
		private static readonly MessageParser<SetSignatureScRsp> _parser = new MessageParser<SetSignatureScRsp>(() => new SetSignatureScRsp());

		// Token: 0x04004F52 RID: 20306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F53 RID: 20307
		public const int SignatureFieldNumber = 15;

		// Token: 0x04004F54 RID: 20308
		private string signature_ = "";

		// Token: 0x04004F55 RID: 20309
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04004F56 RID: 20310
		private uint retcode_;
	}
}
