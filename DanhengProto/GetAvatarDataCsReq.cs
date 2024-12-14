using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000627 RID: 1575
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAvatarDataCsReq : IMessage<GetAvatarDataCsReq>, IMessage, IEquatable<GetAvatarDataCsReq>, IDeepCloneable<GetAvatarDataCsReq>, IBufferMessage
	{
		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x000C14C1 File Offset: 0x000BF6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAvatarDataCsReq> Parser
		{
			get
			{
				return GetAvatarDataCsReq._parser;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x000C14C8 File Offset: 0x000BF6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAvatarDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x060046A4 RID: 18084 RVA: 0x000C14DA File Offset: 0x000BF6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAvatarDataCsReq.Descriptor;
			}
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x000C14E1 File Offset: 0x000BF6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAvatarDataCsReq()
		{
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x000C14F4 File Offset: 0x000BF6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAvatarDataCsReq(GetAvatarDataCsReq other) : this()
		{
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.isGetAll_ = other.isGetAll_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x000C152A File Offset: 0x000BF72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAvatarDataCsReq Clone()
		{
			return new GetAvatarDataCsReq(this);
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x000C1532 File Offset: 0x000BF732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x000C153A File Offset: 0x000BF73A
		// (set) Token: 0x060046AA RID: 18090 RVA: 0x000C1542 File Offset: 0x000BF742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsGetAll
		{
			get
			{
				return this.isGetAll_;
			}
			set
			{
				this.isGetAll_ = value;
			}
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x000C154B File Offset: 0x000BF74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAvatarDataCsReq);
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x000C155C File Offset: 0x000BF75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAvatarDataCsReq other)
		{
			return other != null && (other == this || (this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.IsGetAll == other.IsGetAll && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x000C15AC File Offset: 0x000BF7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this.IsGetAll)
			{
				num ^= this.IsGetAll.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x000C15F9 File Offset: 0x000BF7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x000C1601 File Offset: 0x000BF801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x000C160C File Offset: 0x000BF80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.baseAvatarIdList_.WriteTo(ref output, GetAvatarDataCsReq._repeated_baseAvatarIdList_codec);
			if (this.IsGetAll)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsGetAll);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x000C165C File Offset: 0x000BF85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.baseAvatarIdList_.CalculateSize(GetAvatarDataCsReq._repeated_baseAvatarIdList_codec);
			if (this.IsGetAll)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x000C16A4 File Offset: 0x000BF8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAvatarDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.IsGetAll)
			{
				this.IsGetAll = other.IsGetAll;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x000C16F1 File Offset: 0x000BF8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x000C16FC File Offset: 0x000BF8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U && num != 34U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsGetAll = input.ReadBool();
					}
				}
				else
				{
					this.baseAvatarIdList_.AddEntriesFrom(ref input, GetAvatarDataCsReq._repeated_baseAvatarIdList_codec);
				}
			}
		}

		// Token: 0x04001C35 RID: 7221
		private static readonly MessageParser<GetAvatarDataCsReq> _parser = new MessageParser<GetAvatarDataCsReq>(() => new GetAvatarDataCsReq());

		// Token: 0x04001C36 RID: 7222
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C37 RID: 7223
		public const int BaseAvatarIdListFieldNumber = 4;

		// Token: 0x04001C38 RID: 7224
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04001C39 RID: 7225
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04001C3A RID: 7226
		public const int IsGetAllFieldNumber = 8;

		// Token: 0x04001C3B RID: 7227
		private bool isGetAll_;
	}
}
