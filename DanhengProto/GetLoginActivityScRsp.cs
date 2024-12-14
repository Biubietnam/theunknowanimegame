using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006FF RID: 1791
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetLoginActivityScRsp : IMessage<GetLoginActivityScRsp>, IMessage, IEquatable<GetLoginActivityScRsp>, IDeepCloneable<GetLoginActivityScRsp>, IBufferMessage
	{
		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x0600500B RID: 20491 RVA: 0x000D7DC7 File Offset: 0x000D5FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetLoginActivityScRsp> Parser
		{
			get
			{
				return GetLoginActivityScRsp._parser;
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x000D7DCE File Offset: 0x000D5FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetLoginActivityScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x0600500D RID: 20493 RVA: 0x000D7DE0 File Offset: 0x000D5FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLoginActivityScRsp.Descriptor;
			}
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x000D7DE7 File Offset: 0x000D5FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginActivityScRsp()
		{
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x000D7DFA File Offset: 0x000D5FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginActivityScRsp(GetLoginActivityScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.loginActivityList_ = other.loginActivityList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x000D7E30 File Offset: 0x000D6030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLoginActivityScRsp Clone()
		{
			return new GetLoginActivityScRsp(this);
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06005011 RID: 20497 RVA: 0x000D7E38 File Offset: 0x000D6038
		// (set) Token: 0x06005012 RID: 20498 RVA: 0x000D7E40 File Offset: 0x000D6040
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

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06005013 RID: 20499 RVA: 0x000D7E49 File Offset: 0x000D6049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LoginActivityData> LoginActivityList
		{
			get
			{
				return this.loginActivityList_;
			}
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x000D7E51 File Offset: 0x000D6051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLoginActivityScRsp);
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x000D7E60 File Offset: 0x000D6060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLoginActivityScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.loginActivityList_.Equals(other.loginActivityList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x000D7EB0 File Offset: 0x000D60B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.loginActivityList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x000D7EFD File Offset: 0x000D60FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x000D7F05 File Offset: 0x000D6105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x000D7F10 File Offset: 0x000D6110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			this.loginActivityList_.WriteTo(ref output, GetLoginActivityScRsp._repeated_loginActivityList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x000D7F60 File Offset: 0x000D6160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.loginActivityList_.CalculateSize(GetLoginActivityScRsp._repeated_loginActivityList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x000D7FB4 File Offset: 0x000D61B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLoginActivityScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.loginActivityList_.Add(other.loginActivityList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x000D8001 File Offset: 0x000D6201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x000D800C File Offset: 0x000D620C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.loginActivityList_.AddEntriesFrom(ref input, GetLoginActivityScRsp._repeated_loginActivityList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F7D RID: 8061
		private static readonly MessageParser<GetLoginActivityScRsp> _parser = new MessageParser<GetLoginActivityScRsp>(() => new GetLoginActivityScRsp());

		// Token: 0x04001F7E RID: 8062
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F7F RID: 8063
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001F80 RID: 8064
		private uint retcode_;

		// Token: 0x04001F81 RID: 8065
		public const int LoginActivityListFieldNumber = 6;

		// Token: 0x04001F82 RID: 8066
		private static readonly FieldCodec<LoginActivityData> _repeated_loginActivityList_codec = FieldCodec.ForMessage<LoginActivityData>(50U, LoginActivityData.Parser);

		// Token: 0x04001F83 RID: 8067
		private readonly RepeatedField<LoginActivityData> loginActivityList_ = new RepeatedField<LoginActivityData>();
	}
}
