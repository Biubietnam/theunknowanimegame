using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007E9 RID: 2025
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSecretKeyInfoCsReq : IMessage<GetSecretKeyInfoCsReq>, IMessage, IEquatable<GetSecretKeyInfoCsReq>, IDeepCloneable<GetSecretKeyInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06005A56 RID: 23126 RVA: 0x000F0E9C File Offset: 0x000EF09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSecretKeyInfoCsReq> Parser
		{
			get
			{
				return GetSecretKeyInfoCsReq._parser;
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x06005A57 RID: 23127 RVA: 0x000F0EA3 File Offset: 0x000EF0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSecretKeyInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x06005A58 RID: 23128 RVA: 0x000F0EB5 File Offset: 0x000EF0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSecretKeyInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x000F0EBC File Offset: 0x000EF0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSecretKeyInfoCsReq()
		{
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x000F0ECF File Offset: 0x000EF0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSecretKeyInfoCsReq(GetSecretKeyInfoCsReq other) : this()
		{
			this.lCBNDHECNAC_ = other.lCBNDHECNAC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x000F0EF4 File Offset: 0x000EF0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSecretKeyInfoCsReq Clone()
		{
			return new GetSecretKeyInfoCsReq(this);
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06005A5C RID: 23132 RVA: 0x000F0EFC File Offset: 0x000EF0FC
		// (set) Token: 0x06005A5D RID: 23133 RVA: 0x000F0F04 File Offset: 0x000EF104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString LCBNDHECNAC
		{
			get
			{
				return this.lCBNDHECNAC_;
			}
			set
			{
				this.lCBNDHECNAC_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x000F0F17 File Offset: 0x000EF117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSecretKeyInfoCsReq);
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x000F0F25 File Offset: 0x000EF125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSecretKeyInfoCsReq other)
		{
			return other != null && (other == this || (!(this.LCBNDHECNAC != other.LCBNDHECNAC) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A60 RID: 23136 RVA: 0x000F0F58 File Offset: 0x000EF158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LCBNDHECNAC.Length != 0)
			{
				num ^= this.LCBNDHECNAC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A61 RID: 23137 RVA: 0x000F0F99 File Offset: 0x000EF199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A62 RID: 23138 RVA: 0x000F0FA1 File Offset: 0x000EF1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x000F0FAA File Offset: 0x000EF1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LCBNDHECNAC.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteBytes(this.LCBNDHECNAC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x000F0FE4 File Offset: 0x000EF1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LCBNDHECNAC.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.LCBNDHECNAC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x000F1027 File Offset: 0x000EF227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSecretKeyInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LCBNDHECNAC.Length != 0)
			{
				this.LCBNDHECNAC = other.LCBNDHECNAC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x000F105D File Offset: 0x000EF25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A67 RID: 23143 RVA: 0x000F1068 File Offset: 0x000EF268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LCBNDHECNAC = input.ReadBytes();
				}
			}
		}

		// Token: 0x04002314 RID: 8980
		private static readonly MessageParser<GetSecretKeyInfoCsReq> _parser = new MessageParser<GetSecretKeyInfoCsReq>(() => new GetSecretKeyInfoCsReq());

		// Token: 0x04002315 RID: 8981
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002316 RID: 8982
		public const int LCBNDHECNACFieldNumber = 15;

		// Token: 0x04002317 RID: 8983
		private ByteString lCBNDHECNAC_ = ByteString.Empty;
	}
}
