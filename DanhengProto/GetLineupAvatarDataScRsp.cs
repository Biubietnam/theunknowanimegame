using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006FB RID: 1787
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetLineupAvatarDataScRsp : IMessage<GetLineupAvatarDataScRsp>, IMessage, IEquatable<GetLineupAvatarDataScRsp>, IDeepCloneable<GetLineupAvatarDataScRsp>, IBufferMessage
	{
		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06004FE2 RID: 20450 RVA: 0x000D78A7 File Offset: 0x000D5AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetLineupAvatarDataScRsp> Parser
		{
			get
			{
				return GetLineupAvatarDataScRsp._parser;
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x000D78AE File Offset: 0x000D5AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetLineupAvatarDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06004FE4 RID: 20452 RVA: 0x000D78C0 File Offset: 0x000D5AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLineupAvatarDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x000D78C7 File Offset: 0x000D5AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLineupAvatarDataScRsp()
		{
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x000D78DA File Offset: 0x000D5ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLineupAvatarDataScRsp(GetLineupAvatarDataScRsp other) : this()
		{
			this.avatarDataList_ = other.avatarDataList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x000D7910 File Offset: 0x000D5B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLineupAvatarDataScRsp Clone()
		{
			return new GetLineupAvatarDataScRsp(this);
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06004FE8 RID: 20456 RVA: 0x000D7918 File Offset: 0x000D5B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LineupAvatarData> AvatarDataList
		{
			get
			{
				return this.avatarDataList_;
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x000D7920 File Offset: 0x000D5B20
		// (set) Token: 0x06004FEA RID: 20458 RVA: 0x000D7928 File Offset: 0x000D5B28
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

		// Token: 0x06004FEB RID: 20459 RVA: 0x000D7931 File Offset: 0x000D5B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLineupAvatarDataScRsp);
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x000D7940 File Offset: 0x000D5B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLineupAvatarDataScRsp other)
		{
			return other != null && (other == this || (this.avatarDataList_.Equals(other.avatarDataList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x000D7990 File Offset: 0x000D5B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarDataList_.GetHashCode();
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

		// Token: 0x06004FEE RID: 20462 RVA: 0x000D79DD File Offset: 0x000D5BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x000D79E5 File Offset: 0x000D5BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x000D79F0 File Offset: 0x000D5BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			this.avatarDataList_.WriteTo(ref output, GetLineupAvatarDataScRsp._repeated_avatarDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x000D7A40 File Offset: 0x000D5C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarDataList_.CalculateSize(GetLineupAvatarDataScRsp._repeated_avatarDataList_codec);
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

		// Token: 0x06004FF2 RID: 20466 RVA: 0x000D7A94 File Offset: 0x000D5C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLineupAvatarDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarDataList_.Add(other.avatarDataList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x000D7AE1 File Offset: 0x000D5CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x000D7AEC File Offset: 0x000D5CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.avatarDataList_.AddEntriesFrom(ref input, GetLineupAvatarDataScRsp._repeated_avatarDataList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F72 RID: 8050
		private static readonly MessageParser<GetLineupAvatarDataScRsp> _parser = new MessageParser<GetLineupAvatarDataScRsp>(() => new GetLineupAvatarDataScRsp());

		// Token: 0x04001F73 RID: 8051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F74 RID: 8052
		public const int AvatarDataListFieldNumber = 15;

		// Token: 0x04001F75 RID: 8053
		private static readonly FieldCodec<LineupAvatarData> _repeated_avatarDataList_codec = FieldCodec.ForMessage<LineupAvatarData>(122U, LineupAvatarData.Parser);

		// Token: 0x04001F76 RID: 8054
		private readonly RepeatedField<LineupAvatarData> avatarDataList_ = new RepeatedField<LineupAvatarData>();

		// Token: 0x04001F77 RID: 8055
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04001F78 RID: 8056
		private uint retcode_;
	}
}
