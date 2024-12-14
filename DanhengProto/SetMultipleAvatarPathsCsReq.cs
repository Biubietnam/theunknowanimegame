using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001119 RID: 4377
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetMultipleAvatarPathsCsReq : IMessage<SetMultipleAvatarPathsCsReq>, IMessage, IEquatable<SetMultipleAvatarPathsCsReq>, IDeepCloneable<SetMultipleAvatarPathsCsReq>, IBufferMessage
	{
		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x0600C329 RID: 49961 RVA: 0x0020BE25 File Offset: 0x0020A025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetMultipleAvatarPathsCsReq> Parser
		{
			get
			{
				return SetMultipleAvatarPathsCsReq._parser;
			}
		}

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x0600C32A RID: 49962 RVA: 0x0020BE2C File Offset: 0x0020A02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetMultipleAvatarPathsCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x0600C32B RID: 49963 RVA: 0x0020BE3E File Offset: 0x0020A03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetMultipleAvatarPathsCsReq.Descriptor;
			}
		}

		// Token: 0x0600C32C RID: 49964 RVA: 0x0020BE45 File Offset: 0x0020A045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMultipleAvatarPathsCsReq()
		{
		}

		// Token: 0x0600C32D RID: 49965 RVA: 0x0020BE58 File Offset: 0x0020A058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMultipleAvatarPathsCsReq(SetMultipleAvatarPathsCsReq other) : this()
		{
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C32E RID: 49966 RVA: 0x0020BE82 File Offset: 0x0020A082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMultipleAvatarPathsCsReq Clone()
		{
			return new SetMultipleAvatarPathsCsReq(this);
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x0600C32F RID: 49967 RVA: 0x0020BE8A File Offset: 0x0020A08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MultiPathAvatarType> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x0600C330 RID: 49968 RVA: 0x0020BE92 File Offset: 0x0020A092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetMultipleAvatarPathsCsReq);
		}

		// Token: 0x0600C331 RID: 49969 RVA: 0x0020BEA0 File Offset: 0x0020A0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetMultipleAvatarPathsCsReq other)
		{
			return other != null && (other == this || (this.avatarIdList_.Equals(other.avatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C332 RID: 49970 RVA: 0x0020BED4 File Offset: 0x0020A0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C333 RID: 49971 RVA: 0x0020BF08 File Offset: 0x0020A108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C334 RID: 49972 RVA: 0x0020BF10 File Offset: 0x0020A110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C335 RID: 49973 RVA: 0x0020BF19 File Offset: 0x0020A119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarIdList_.WriteTo(ref output, SetMultipleAvatarPathsCsReq._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C336 RID: 49974 RVA: 0x0020BF40 File Offset: 0x0020A140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarIdList_.CalculateSize(SetMultipleAvatarPathsCsReq._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C337 RID: 49975 RVA: 0x0020BF79 File Offset: 0x0020A179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetMultipleAvatarPathsCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C338 RID: 49976 RVA: 0x0020BFA7 File Offset: 0x0020A1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C339 RID: 49977 RVA: 0x0020BFB0 File Offset: 0x0020A1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.avatarIdList_.AddEntriesFrom(ref input, SetMultipleAvatarPathsCsReq._repeated_avatarIdList_codec);
				}
			}
		}

		// Token: 0x04004EDE RID: 20190
		private static readonly MessageParser<SetMultipleAvatarPathsCsReq> _parser = new MessageParser<SetMultipleAvatarPathsCsReq>(() => new SetMultipleAvatarPathsCsReq());

		// Token: 0x04004EDF RID: 20191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EE0 RID: 20192
		public const int AvatarIdListFieldNumber = 14;

		// Token: 0x04004EE1 RID: 20193
		private static readonly FieldCodec<MultiPathAvatarType> _repeated_avatarIdList_codec = FieldCodec.ForEnum<MultiPathAvatarType>(114U, (MultiPathAvatarType x) => (int)x, (int x) => (MultiPathAvatarType)x);

		// Token: 0x04004EE2 RID: 20194
		private readonly RepeatedField<MultiPathAvatarType> avatarIdList_ = new RepeatedField<MultiPathAvatarType>();
	}
}
