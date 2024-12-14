using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000615 RID: 1557
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAllServerPrefsDataScRsp : IMessage<GetAllServerPrefsDataScRsp>, IMessage, IEquatable<GetAllServerPrefsDataScRsp>, IDeepCloneable<GetAllServerPrefsDataScRsp>, IBufferMessage
	{
		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x000BF4BF File Offset: 0x000BD6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAllServerPrefsDataScRsp> Parser
		{
			get
			{
				return GetAllServerPrefsDataScRsp._parser;
			}
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x060045D1 RID: 17873 RVA: 0x000BF4C6 File Offset: 0x000BD6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAllServerPrefsDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x000BF4D8 File Offset: 0x000BD6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllServerPrefsDataScRsp.Descriptor;
			}
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x000BF4DF File Offset: 0x000BD6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllServerPrefsDataScRsp()
		{
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x000BF4F2 File Offset: 0x000BD6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllServerPrefsDataScRsp(GetAllServerPrefsDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.serverPrefsList_ = other.serverPrefsList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x000BF528 File Offset: 0x000BD728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllServerPrefsDataScRsp Clone()
		{
			return new GetAllServerPrefsDataScRsp(this);
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060045D6 RID: 17878 RVA: 0x000BF530 File Offset: 0x000BD730
		// (set) Token: 0x060045D7 RID: 17879 RVA: 0x000BF538 File Offset: 0x000BD738
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

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060045D8 RID: 17880 RVA: 0x000BF541 File Offset: 0x000BD741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ServerPrefs> ServerPrefsList
		{
			get
			{
				return this.serverPrefsList_;
			}
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x000BF549 File Offset: 0x000BD749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllServerPrefsDataScRsp);
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x000BF558 File Offset: 0x000BD758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAllServerPrefsDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.serverPrefsList_.Equals(other.serverPrefsList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x000BF5A8 File Offset: 0x000BD7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.serverPrefsList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x000BF5F5 File Offset: 0x000BD7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x000BF5FD File Offset: 0x000BD7FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x000BF608 File Offset: 0x000BD808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			this.serverPrefsList_.WriteTo(ref output, GetAllServerPrefsDataScRsp._repeated_serverPrefsList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x000BF658 File Offset: 0x000BD858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.serverPrefsList_.CalculateSize(GetAllServerPrefsDataScRsp._repeated_serverPrefsList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x000BF6AC File Offset: 0x000BD8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAllServerPrefsDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.serverPrefsList_.Add(other.serverPrefsList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x000BF6F9 File Offset: 0x000BD8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x000BF704 File Offset: 0x000BD904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.serverPrefsList_.AddEntriesFrom(ref input, GetAllServerPrefsDataScRsp._repeated_serverPrefsList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001BED RID: 7149
		private static readonly MessageParser<GetAllServerPrefsDataScRsp> _parser = new MessageParser<GetAllServerPrefsDataScRsp>(() => new GetAllServerPrefsDataScRsp());

		// Token: 0x04001BEE RID: 7150
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BEF RID: 7151
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04001BF0 RID: 7152
		private uint retcode_;

		// Token: 0x04001BF1 RID: 7153
		public const int ServerPrefsListFieldNumber = 14;

		// Token: 0x04001BF2 RID: 7154
		private static readonly FieldCodec<ServerPrefs> _repeated_serverPrefsList_codec = FieldCodec.ForMessage<ServerPrefs>(114U, ServerPrefs.Parser);

		// Token: 0x04001BF3 RID: 7155
		private readonly RepeatedField<ServerPrefs> serverPrefsList_ = new RepeatedField<ServerPrefs>();
	}
}
