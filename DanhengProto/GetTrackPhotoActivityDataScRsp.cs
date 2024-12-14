using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000827 RID: 2087
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTrackPhotoActivityDataScRsp : IMessage<GetTrackPhotoActivityDataScRsp>, IMessage, IEquatable<GetTrackPhotoActivityDataScRsp>, IDeepCloneable<GetTrackPhotoActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x06005CE9 RID: 23785 RVA: 0x000F6BDF File Offset: 0x000F4DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTrackPhotoActivityDataScRsp> Parser
		{
			get
			{
				return GetTrackPhotoActivityDataScRsp._parser;
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x06005CEA RID: 23786 RVA: 0x000F6BE6 File Offset: 0x000F4DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTrackPhotoActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06005CEB RID: 23787 RVA: 0x000F6BF8 File Offset: 0x000F4DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTrackPhotoActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x000F6BFF File Offset: 0x000F4DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrackPhotoActivityDataScRsp()
		{
		}

		// Token: 0x06005CED RID: 23789 RVA: 0x000F6C12 File Offset: 0x000F4E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrackPhotoActivityDataScRsp(GetTrackPhotoActivityDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.oHKHAGDEFMN_ = other.oHKHAGDEFMN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x000F6C48 File Offset: 0x000F4E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrackPhotoActivityDataScRsp Clone()
		{
			return new GetTrackPhotoActivityDataScRsp(this);
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06005CEF RID: 23791 RVA: 0x000F6C50 File Offset: 0x000F4E50
		// (set) Token: 0x06005CF0 RID: 23792 RVA: 0x000F6C58 File Offset: 0x000F4E58
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

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06005CF1 RID: 23793 RVA: 0x000F6C61 File Offset: 0x000F4E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KGHIOAHHLGK> OHKHAGDEFMN
		{
			get
			{
				return this.oHKHAGDEFMN_;
			}
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x000F6C69 File Offset: 0x000F4E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTrackPhotoActivityDataScRsp);
		}

		// Token: 0x06005CF3 RID: 23795 RVA: 0x000F6C78 File Offset: 0x000F4E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTrackPhotoActivityDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.oHKHAGDEFMN_.Equals(other.oHKHAGDEFMN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x000F6CC8 File Offset: 0x000F4EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.oHKHAGDEFMN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x000F6D15 File Offset: 0x000F4F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x000F6D1D File Offset: 0x000F4F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x000F6D28 File Offset: 0x000F4F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.oHKHAGDEFMN_.WriteTo(ref output, GetTrackPhotoActivityDataScRsp._repeated_oHKHAGDEFMN_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x000F6D78 File Offset: 0x000F4F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.oHKHAGDEFMN_.CalculateSize(GetTrackPhotoActivityDataScRsp._repeated_oHKHAGDEFMN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x000F6DCC File Offset: 0x000F4FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTrackPhotoActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.oHKHAGDEFMN_.Add(other.oHKHAGDEFMN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x000F6E19 File Offset: 0x000F5019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x000F6E24 File Offset: 0x000F5024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 48U)
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
					this.oHKHAGDEFMN_.AddEntriesFrom(ref input, GetTrackPhotoActivityDataScRsp._repeated_oHKHAGDEFMN_codec);
				}
			}
		}

		// Token: 0x040023E8 RID: 9192
		private static readonly MessageParser<GetTrackPhotoActivityDataScRsp> _parser = new MessageParser<GetTrackPhotoActivityDataScRsp>(() => new GetTrackPhotoActivityDataScRsp());

		// Token: 0x040023E9 RID: 9193
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023EA RID: 9194
		public const int RetcodeFieldNumber = 6;

		// Token: 0x040023EB RID: 9195
		private uint retcode_;

		// Token: 0x040023EC RID: 9196
		public const int OHKHAGDEFMNFieldNumber = 2;

		// Token: 0x040023ED RID: 9197
		private static readonly FieldCodec<KGHIOAHHLGK> _repeated_oHKHAGDEFMN_codec = FieldCodec.ForMessage<KGHIOAHHLGK>(18U, KGHIOAHHLGK.Parser);

		// Token: 0x040023EE RID: 9198
		private readonly RepeatedField<KGHIOAHHLGK> oHKHAGDEFMN_ = new RepeatedField<KGHIOAHHLGK>();
	}
}
