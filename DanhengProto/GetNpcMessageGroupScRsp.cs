using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200074B RID: 1867
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetNpcMessageGroupScRsp : IMessage<GetNpcMessageGroupScRsp>, IMessage, IEquatable<GetNpcMessageGroupScRsp>, IDeepCloneable<GetNpcMessageGroupScRsp>, IBufferMessage
	{
		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x0600537A RID: 21370 RVA: 0x000E0EC9 File Offset: 0x000DF0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetNpcMessageGroupScRsp> Parser
		{
			get
			{
				return GetNpcMessageGroupScRsp._parser;
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x0600537B RID: 21371 RVA: 0x000E0ED0 File Offset: 0x000DF0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetNpcMessageGroupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x0600537C RID: 21372 RVA: 0x000E0EE2 File Offset: 0x000DF0E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetNpcMessageGroupScRsp.Descriptor;
			}
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x000E0EE9 File Offset: 0x000DF0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcMessageGroupScRsp()
		{
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x000E0EFC File Offset: 0x000DF0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcMessageGroupScRsp(GetNpcMessageGroupScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.messageGroupList_ = other.messageGroupList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x000E0F32 File Offset: 0x000DF132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcMessageGroupScRsp Clone()
		{
			return new GetNpcMessageGroupScRsp(this);
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06005380 RID: 21376 RVA: 0x000E0F3A File Offset: 0x000DF13A
		// (set) Token: 0x06005381 RID: 21377 RVA: 0x000E0F42 File Offset: 0x000DF142
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

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06005382 RID: 21378 RVA: 0x000E0F4B File Offset: 0x000DF14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MessageGroup> MessageGroupList
		{
			get
			{
				return this.messageGroupList_;
			}
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x000E0F53 File Offset: 0x000DF153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetNpcMessageGroupScRsp);
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x000E0F64 File Offset: 0x000DF164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetNpcMessageGroupScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.messageGroupList_.Equals(other.messageGroupList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x000E0FB4 File Offset: 0x000DF1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.messageGroupList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x000E1001 File Offset: 0x000DF201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x000E1009 File Offset: 0x000DF209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x000E1014 File Offset: 0x000DF214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.messageGroupList_.WriteTo(ref output, GetNpcMessageGroupScRsp._repeated_messageGroupList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x000E1064 File Offset: 0x000DF264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.messageGroupList_.CalculateSize(GetNpcMessageGroupScRsp._repeated_messageGroupList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x000E10B8 File Offset: 0x000DF2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetNpcMessageGroupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.messageGroupList_.Add(other.messageGroupList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x000E1105 File Offset: 0x000DF305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x000E1110 File Offset: 0x000DF310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.messageGroupList_.AddEntriesFrom(ref input, GetNpcMessageGroupScRsp._repeated_messageGroupList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040020D6 RID: 8406
		private static readonly MessageParser<GetNpcMessageGroupScRsp> _parser = new MessageParser<GetNpcMessageGroupScRsp>(() => new GetNpcMessageGroupScRsp());

		// Token: 0x040020D7 RID: 8407
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020D8 RID: 8408
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040020D9 RID: 8409
		private uint retcode_;

		// Token: 0x040020DA RID: 8410
		public const int MessageGroupListFieldNumber = 13;

		// Token: 0x040020DB RID: 8411
		private static readonly FieldCodec<MessageGroup> _repeated_messageGroupList_codec = FieldCodec.ForMessage<MessageGroup>(106U, MessageGroup.Parser);

		// Token: 0x040020DC RID: 8412
		private readonly RepeatedField<MessageGroup> messageGroupList_ = new RepeatedField<MessageGroup>();
	}
}
