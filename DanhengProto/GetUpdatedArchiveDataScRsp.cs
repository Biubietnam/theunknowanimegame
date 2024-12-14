using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000847 RID: 2119
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetUpdatedArchiveDataScRsp : IMessage<GetUpdatedArchiveDataScRsp>, IMessage, IEquatable<GetUpdatedArchiveDataScRsp>, IDeepCloneable<GetUpdatedArchiveDataScRsp>, IBufferMessage
	{
		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06005E38 RID: 24120 RVA: 0x000F9811 File Offset: 0x000F7A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetUpdatedArchiveDataScRsp> Parser
		{
			get
			{
				return GetUpdatedArchiveDataScRsp._parser;
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06005E39 RID: 24121 RVA: 0x000F9818 File Offset: 0x000F7A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetUpdatedArchiveDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06005E3A RID: 24122 RVA: 0x000F982A File Offset: 0x000F7A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetUpdatedArchiveDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x000F9831 File Offset: 0x000F7A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUpdatedArchiveDataScRsp()
		{
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x000F983C File Offset: 0x000F7A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUpdatedArchiveDataScRsp(GetUpdatedArchiveDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.archiveData_ = ((other.archiveData_ != null) ? other.archiveData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x000F9888 File Offset: 0x000F7A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUpdatedArchiveDataScRsp Clone()
		{
			return new GetUpdatedArchiveDataScRsp(this);
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06005E3E RID: 24126 RVA: 0x000F9890 File Offset: 0x000F7A90
		// (set) Token: 0x06005E3F RID: 24127 RVA: 0x000F9898 File Offset: 0x000F7A98
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

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06005E40 RID: 24128 RVA: 0x000F98A1 File Offset: 0x000F7AA1
		// (set) Token: 0x06005E41 RID: 24129 RVA: 0x000F98A9 File Offset: 0x000F7AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveData ArchiveData
		{
			get
			{
				return this.archiveData_;
			}
			set
			{
				this.archiveData_ = value;
			}
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x000F98B2 File Offset: 0x000F7AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetUpdatedArchiveDataScRsp);
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x000F98C0 File Offset: 0x000F7AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetUpdatedArchiveDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.ArchiveData, other.ArchiveData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x000F9910 File Offset: 0x000F7B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.archiveData_ != null)
			{
				num ^= this.ArchiveData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x000F9965 File Offset: 0x000F7B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x000F996D File Offset: 0x000F7B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x000F9978 File Offset: 0x000F7B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.archiveData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ArchiveData);
			}
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

		// Token: 0x06005E48 RID: 24136 RVA: 0x000F99D4 File Offset: 0x000F7BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.archiveData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ArchiveData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x000F9A2C File Offset: 0x000F7C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetUpdatedArchiveDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.archiveData_ != null)
			{
				if (this.archiveData_ == null)
				{
					this.ArchiveData = new ArchiveData();
				}
				this.ArchiveData.MergeFrom(other.ArchiveData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x000F9A94 File Offset: 0x000F7C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x000F9AA0 File Offset: 0x000F7CA0
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
					if (this.archiveData_ == null)
					{
						this.ArchiveData = new ArchiveData();
					}
					input.ReadMessage(this.ArchiveData);
				}
			}
		}

		// Token: 0x0400244D RID: 9293
		private static readonly MessageParser<GetUpdatedArchiveDataScRsp> _parser = new MessageParser<GetUpdatedArchiveDataScRsp>(() => new GetUpdatedArchiveDataScRsp());

		// Token: 0x0400244E RID: 9294
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400244F RID: 9295
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04002450 RID: 9296
		private uint retcode_;

		// Token: 0x04002451 RID: 9297
		public const int ArchiveDataFieldNumber = 6;

		// Token: 0x04002452 RID: 9298
		private ArchiveData archiveData_;
	}
}
