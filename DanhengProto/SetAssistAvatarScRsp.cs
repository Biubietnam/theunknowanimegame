using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010CB RID: 4299
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetAssistAvatarScRsp : IMessage<SetAssistAvatarScRsp>, IMessage, IEquatable<SetAssistAvatarScRsp>, IDeepCloneable<SetAssistAvatarScRsp>, IBufferMessage
	{
		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0600BFB1 RID: 49073 RVA: 0x00204129 File Offset: 0x00202329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetAssistAvatarScRsp> Parser
		{
			get
			{
				return SetAssistAvatarScRsp._parser;
			}
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600BFB2 RID: 49074 RVA: 0x00204130 File Offset: 0x00202330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetAssistAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600BFB3 RID: 49075 RVA: 0x00204142 File Offset: 0x00202342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAssistAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x0600BFB4 RID: 49076 RVA: 0x00204149 File Offset: 0x00202349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistAvatarScRsp()
		{
		}

		// Token: 0x0600BFB5 RID: 49077 RVA: 0x0020415C File Offset: 0x0020235C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistAvatarScRsp(SetAssistAvatarScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.avatarId_ = other.avatarId_;
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFB6 RID: 49078 RVA: 0x002041A9 File Offset: 0x002023A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAssistAvatarScRsp Clone()
		{
			return new SetAssistAvatarScRsp(this);
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600BFB7 RID: 49079 RVA: 0x002041B1 File Offset: 0x002023B1
		// (set) Token: 0x0600BFB8 RID: 49080 RVA: 0x002041B9 File Offset: 0x002023B9
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

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0600BFB9 RID: 49081 RVA: 0x002041C2 File Offset: 0x002023C2
		// (set) Token: 0x0600BFBA RID: 49082 RVA: 0x002041CA File Offset: 0x002023CA
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

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0600BFBB RID: 49083 RVA: 0x002041D3 File Offset: 0x002023D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x0600BFBC RID: 49084 RVA: 0x002041DB File Offset: 0x002023DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAssistAvatarScRsp);
		}

		// Token: 0x0600BFBD RID: 49085 RVA: 0x002041EC File Offset: 0x002023EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAssistAvatarScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.AvatarId == other.AvatarId && this.avatarIdList_.Equals(other.avatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFBE RID: 49086 RVA: 0x0020424C File Offset: 0x0020244C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			num ^= this.avatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BFBF RID: 49087 RVA: 0x002042B2 File Offset: 0x002024B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BFC0 RID: 49088 RVA: 0x002042BA File Offset: 0x002024BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFC1 RID: 49089 RVA: 0x002042C4 File Offset: 0x002024C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AvatarId);
			}
			this.avatarIdList_.WriteTo(ref output, SetAssistAvatarScRsp._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BFC2 RID: 49090 RVA: 0x00204330 File Offset: 0x00202530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			num += this.avatarIdList_.CalculateSize(SetAssistAvatarScRsp._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BFC3 RID: 49091 RVA: 0x0020439C File Offset: 0x0020259C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAssistAvatarScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BFC4 RID: 49092 RVA: 0x002043FD File Offset: 0x002025FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFC5 RID: 49093 RVA: 0x00204408 File Offset: 0x00202608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.AvatarId = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 104U || num == 106U)
				{
					this.avatarIdList_.AddEntriesFrom(ref input, SetAssistAvatarScRsp._repeated_avatarIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004DCC RID: 19916
		private static readonly MessageParser<SetAssistAvatarScRsp> _parser = new MessageParser<SetAssistAvatarScRsp>(() => new SetAssistAvatarScRsp());

		// Token: 0x04004DCD RID: 19917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DCE RID: 19918
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04004DCF RID: 19919
		private uint retcode_;

		// Token: 0x04004DD0 RID: 19920
		public const int AvatarIdFieldNumber = 7;

		// Token: 0x04004DD1 RID: 19921
		private uint avatarId_;

		// Token: 0x04004DD2 RID: 19922
		public const int AvatarIdListFieldNumber = 13;

		// Token: 0x04004DD3 RID: 19923
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04004DD4 RID: 19924
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();
	}
}
