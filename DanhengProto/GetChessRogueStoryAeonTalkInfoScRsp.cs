using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000661 RID: 1633
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChessRogueStoryAeonTalkInfoScRsp : IMessage<GetChessRogueStoryAeonTalkInfoScRsp>, IMessage, IEquatable<GetChessRogueStoryAeonTalkInfoScRsp>, IDeepCloneable<GetChessRogueStoryAeonTalkInfoScRsp>, IBufferMessage
	{
		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x000C7C54 File Offset: 0x000C5E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChessRogueStoryAeonTalkInfoScRsp> Parser
		{
			get
			{
				return GetChessRogueStoryAeonTalkInfoScRsp._parser;
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06004934 RID: 18740 RVA: 0x000C7C5B File Offset: 0x000C5E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChessRogueStoryAeonTalkInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x000C7C6D File Offset: 0x000C5E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChessRogueStoryAeonTalkInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x000C7C74 File Offset: 0x000C5E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryAeonTalkInfoScRsp()
		{
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x000C7C88 File Offset: 0x000C5E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryAeonTalkInfoScRsp(GetChessRogueStoryAeonTalkInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.talkDialogueId_ = other.talkDialogueId_;
			this.lFEPBAJOCPE_ = other.lFEPBAJOCPE_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x000C7CD5 File Offset: 0x000C5ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryAeonTalkInfoScRsp Clone()
		{
			return new GetChessRogueStoryAeonTalkInfoScRsp(this);
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06004939 RID: 18745 RVA: 0x000C7CDD File Offset: 0x000C5EDD
		// (set) Token: 0x0600493A RID: 18746 RVA: 0x000C7CE5 File Offset: 0x000C5EE5
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

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x0600493B RID: 18747 RVA: 0x000C7CEE File Offset: 0x000C5EEE
		// (set) Token: 0x0600493C RID: 18748 RVA: 0x000C7CF6 File Offset: 0x000C5EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TalkDialogueId
		{
			get
			{
				return this.talkDialogueId_;
			}
			set
			{
				this.talkDialogueId_ = value;
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600493D RID: 18749 RVA: 0x000C7CFF File Offset: 0x000C5EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> LFEPBAJOCPE
		{
			get
			{
				return this.lFEPBAJOCPE_;
			}
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x000C7D07 File Offset: 0x000C5F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChessRogueStoryAeonTalkInfoScRsp);
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x000C7D18 File Offset: 0x000C5F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChessRogueStoryAeonTalkInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.TalkDialogueId == other.TalkDialogueId && this.LFEPBAJOCPE.Equals(other.LFEPBAJOCPE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x000C7D78 File Offset: 0x000C5F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.TalkDialogueId != 0U)
			{
				num ^= this.TalkDialogueId.GetHashCode();
			}
			num ^= this.LFEPBAJOCPE.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x000C7DDE File Offset: 0x000C5FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x000C7DE6 File Offset: 0x000C5FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x000C7DF0 File Offset: 0x000C5FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalkDialogueId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.TalkDialogueId);
			}
			this.lFEPBAJOCPE_.WriteTo(ref output, GetChessRogueStoryAeonTalkInfoScRsp._map_lFEPBAJOCPE_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x000C7E5C File Offset: 0x000C605C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.TalkDialogueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalkDialogueId);
			}
			num += this.lFEPBAJOCPE_.CalculateSize(GetChessRogueStoryAeonTalkInfoScRsp._map_lFEPBAJOCPE_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x000C7EC8 File Offset: 0x000C60C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChessRogueStoryAeonTalkInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.TalkDialogueId != 0U)
			{
				this.TalkDialogueId = other.TalkDialogueId;
			}
			this.lFEPBAJOCPE_.MergeFrom(other.lFEPBAJOCPE_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x000C7F29 File Offset: 0x000C6129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x000C7F34 File Offset: 0x000C6134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 90U)
					{
						if (num != 96U)
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
						this.lFEPBAJOCPE_.AddEntriesFrom(ref input, GetChessRogueStoryAeonTalkInfoScRsp._map_lFEPBAJOCPE_codec);
					}
				}
				else
				{
					this.TalkDialogueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001D2B RID: 7467
		private static readonly MessageParser<GetChessRogueStoryAeonTalkInfoScRsp> _parser = new MessageParser<GetChessRogueStoryAeonTalkInfoScRsp>(() => new GetChessRogueStoryAeonTalkInfoScRsp());

		// Token: 0x04001D2C RID: 7468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D2D RID: 7469
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04001D2E RID: 7470
		private uint retcode_;

		// Token: 0x04001D2F RID: 7471
		public const int TalkDialogueIdFieldNumber = 7;

		// Token: 0x04001D30 RID: 7472
		private uint talkDialogueId_;

		// Token: 0x04001D31 RID: 7473
		public const int LFEPBAJOCPEFieldNumber = 11;

		// Token: 0x04001D32 RID: 7474
		private static readonly MapField<uint, uint>.Codec _map_lFEPBAJOCPE_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 90U);

		// Token: 0x04001D33 RID: 7475
		private readonly MapField<uint, uint> lFEPBAJOCPE_ = new MapField<uint, uint>();
	}
}
