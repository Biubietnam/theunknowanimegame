using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000267 RID: 615
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRoguePickAvatarScRsp : IMessage<ChessRoguePickAvatarScRsp>, IMessage, IEquatable<ChessRoguePickAvatarScRsp>, IDeepCloneable<ChessRoguePickAvatarScRsp>, IBufferMessage
	{
		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x0004F067 File Offset: 0x0004D267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRoguePickAvatarScRsp> Parser
		{
			get
			{
				return ChessRoguePickAvatarScRsp._parser;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x0004F06E File Offset: 0x0004D26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRoguePickAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x0004F080 File Offset: 0x0004D280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRoguePickAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0004F087 File Offset: 0x0004D287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRoguePickAvatarScRsp()
		{
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0004F09C File Offset: 0x0004D29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRoguePickAvatarScRsp(ChessRoguePickAvatarScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueLineupInfo_ = ((other.rogueLineupInfo_ != null) ? other.rogueLineupInfo_.Clone() : null);
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0004F0F9 File Offset: 0x0004D2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRoguePickAvatarScRsp Clone()
		{
			return new ChessRoguePickAvatarScRsp(this);
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x0004F101 File Offset: 0x0004D301
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0004F109 File Offset: 0x0004D309
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

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x0004F112 File Offset: 0x0004D312
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0004F11A File Offset: 0x0004D31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLineupInfo RogueLineupInfo
		{
			get
			{
				return this.rogueLineupInfo_;
			}
			set
			{
				this.rogueLineupInfo_ = value;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x0004F123 File Offset: 0x0004D323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0004F12B File Offset: 0x0004D32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRoguePickAvatarScRsp);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0004F13C File Offset: 0x0004D33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRoguePickAvatarScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueLineupInfo, other.RogueLineupInfo) && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueLineupInfo_ != null)
			{
				num ^= this.RogueLineupInfo.GetHashCode();
			}
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0004F203 File Offset: 0x0004D403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0004F20B File Offset: 0x0004D40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0004F214 File Offset: 0x0004D414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueLineupInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueLineupInfo);
			}
			this.baseAvatarIdList_.WriteTo(ref output, ChessRoguePickAvatarScRsp._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0004F280 File Offset: 0x0004D480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueLineupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueLineupInfo);
			}
			num += this.baseAvatarIdList_.CalculateSize(ChessRoguePickAvatarScRsp._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0004F2EC File Offset: 0x0004D4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRoguePickAvatarScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueLineupInfo_ != null)
			{
				if (this.rogueLineupInfo_ == null)
				{
					this.RogueLineupInfo = new ChessRogueLineupInfo();
				}
				this.RogueLineupInfo.MergeFrom(other.RogueLineupInfo);
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0004F365 File Offset: 0x0004D565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0004F370 File Offset: 0x0004D570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 106U)
				{
					if (num == 32U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.rogueLineupInfo_ == null)
						{
							this.RogueLineupInfo = new ChessRogueLineupInfo();
						}
						input.ReadMessage(this.RogueLineupInfo);
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.baseAvatarIdList_.AddEntriesFrom(ref input, ChessRoguePickAvatarScRsp._repeated_baseAvatarIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000B8D RID: 2957
		private static readonly MessageParser<ChessRoguePickAvatarScRsp> _parser = new MessageParser<ChessRoguePickAvatarScRsp>(() => new ChessRoguePickAvatarScRsp());

		// Token: 0x04000B8E RID: 2958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B8F RID: 2959
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04000B90 RID: 2960
		private uint retcode_;

		// Token: 0x04000B91 RID: 2961
		public const int RogueLineupInfoFieldNumber = 13;

		// Token: 0x04000B92 RID: 2962
		private ChessRogueLineupInfo rogueLineupInfo_;

		// Token: 0x04000B93 RID: 2963
		public const int BaseAvatarIdListFieldNumber = 14;

		// Token: 0x04000B94 RID: 2964
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04000B95 RID: 2965
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();
	}
}
