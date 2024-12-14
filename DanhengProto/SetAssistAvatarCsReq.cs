using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010C9 RID: 4297
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetAssistAvatarCsReq : IMessage<SetAssistAvatarCsReq>, IMessage, IEquatable<SetAssistAvatarCsReq>, IDeepCloneable<SetAssistAvatarCsReq>, IBufferMessage
	{
		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0600BF9B RID: 49051 RVA: 0x00203DD8 File Offset: 0x00201FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetAssistAvatarCsReq> Parser
		{
			get
			{
				return SetAssistAvatarCsReq._parser;
			}
		}

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0600BF9C RID: 49052 RVA: 0x00203DDF File Offset: 0x00201FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetAssistAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0600BF9D RID: 49053 RVA: 0x00203DF1 File Offset: 0x00201FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAssistAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x0600BF9E RID: 49054 RVA: 0x00203DF8 File Offset: 0x00201FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistAvatarCsReq()
		{
		}

		// Token: 0x0600BF9F RID: 49055 RVA: 0x00203E0B File Offset: 0x0020200B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistAvatarCsReq(SetAssistAvatarCsReq other) : this()
		{
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFA0 RID: 49056 RVA: 0x00203E41 File Offset: 0x00202041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistAvatarCsReq Clone()
		{
			return new SetAssistAvatarCsReq(this);
		}

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0600BFA1 RID: 49057 RVA: 0x00203E49 File Offset: 0x00202049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0600BFA2 RID: 49058 RVA: 0x00203E51 File Offset: 0x00202051
		// (set) Token: 0x0600BFA3 RID: 49059 RVA: 0x00203E59 File Offset: 0x00202059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x00203E62 File Offset: 0x00202062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAssistAvatarCsReq);
		}

		// Token: 0x0600BFA5 RID: 49061 RVA: 0x00203E70 File Offset: 0x00202070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAssistAvatarCsReq other)
		{
			return other != null && (other == this || (this.avatarIdList_.Equals(other.avatarIdList_) && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFA6 RID: 49062 RVA: 0x00203EC0 File Offset: 0x002020C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarIdList_.GetHashCode();
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BFA7 RID: 49063 RVA: 0x00203F0D File Offset: 0x0020210D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x00203F15 File Offset: 0x00202115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFA9 RID: 49065 RVA: 0x00203F20 File Offset: 0x00202120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarIdList_.WriteTo(ref output, SetAssistAvatarCsReq._repeated_avatarIdList_codec);
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BFAA RID: 49066 RVA: 0x00203F70 File Offset: 0x00202170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarIdList_.CalculateSize(SetAssistAvatarCsReq._repeated_avatarIdList_codec);
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BFAB RID: 49067 RVA: 0x00203FC4 File Offset: 0x002021C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAssistAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BFAC RID: 49068 RVA: 0x00204011 File Offset: 0x00202211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFAD RID: 49069 RVA: 0x0020401C File Offset: 0x0020221C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U && num != 18U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvatarId = input.ReadUInt32();
					}
				}
				else
				{
					this.avatarIdList_.AddEntriesFrom(ref input, SetAssistAvatarCsReq._repeated_avatarIdList_codec);
				}
			}
		}

		// Token: 0x04004DC4 RID: 19908
		private static readonly MessageParser<SetAssistAvatarCsReq> _parser = new MessageParser<SetAssistAvatarCsReq>(() => new SetAssistAvatarCsReq());

		// Token: 0x04004DC5 RID: 19909
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DC6 RID: 19910
		public const int AvatarIdListFieldNumber = 2;

		// Token: 0x04004DC7 RID: 19911
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04004DC8 RID: 19912
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04004DC9 RID: 19913
		public const int AvatarIdFieldNumber = 10;

		// Token: 0x04004DCA RID: 19914
		private uint avatarId_;
	}
}
