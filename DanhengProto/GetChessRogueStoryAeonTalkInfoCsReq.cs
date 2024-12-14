using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200065F RID: 1631
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChessRogueStoryAeonTalkInfoCsReq : IMessage<GetChessRogueStoryAeonTalkInfoCsReq>, IMessage, IEquatable<GetChessRogueStoryAeonTalkInfoCsReq>, IDeepCloneable<GetChessRogueStoryAeonTalkInfoCsReq>, IBufferMessage
	{
		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x0600491E RID: 18718 RVA: 0x000C79A1 File Offset: 0x000C5BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChessRogueStoryAeonTalkInfoCsReq> Parser
		{
			get
			{
				return GetChessRogueStoryAeonTalkInfoCsReq._parser;
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x0600491F RID: 18719 RVA: 0x000C79A8 File Offset: 0x000C5BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChessRogueStoryAeonTalkInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x000C79BA File Offset: 0x000C5BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChessRogueStoryAeonTalkInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x000C79C1 File Offset: 0x000C5BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryAeonTalkInfoCsReq()
		{
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x000C79C9 File Offset: 0x000C5BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryAeonTalkInfoCsReq(GetChessRogueStoryAeonTalkInfoCsReq other) : this()
		{
			this.talkDialogueId_ = other.talkDialogueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x000C79EE File Offset: 0x000C5BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueStoryAeonTalkInfoCsReq Clone()
		{
			return new GetChessRogueStoryAeonTalkInfoCsReq(this);
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06004924 RID: 18724 RVA: 0x000C79F6 File Offset: 0x000C5BF6
		// (set) Token: 0x06004925 RID: 18725 RVA: 0x000C79FE File Offset: 0x000C5BFE
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

		// Token: 0x06004926 RID: 18726 RVA: 0x000C7A07 File Offset: 0x000C5C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChessRogueStoryAeonTalkInfoCsReq);
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x000C7A15 File Offset: 0x000C5C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChessRogueStoryAeonTalkInfoCsReq other)
		{
			return other != null && (other == this || (this.TalkDialogueId == other.TalkDialogueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x000C7A44 File Offset: 0x000C5C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalkDialogueId != 0U)
			{
				num ^= this.TalkDialogueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x000C7A83 File Offset: 0x000C5C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x000C7A8B File Offset: 0x000C5C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x000C7A94 File Offset: 0x000C5C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalkDialogueId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.TalkDialogueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x000C7AC8 File Offset: 0x000C5CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalkDialogueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalkDialogueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x000C7B06 File Offset: 0x000C5D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChessRogueStoryAeonTalkInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalkDialogueId != 0U)
			{
				this.TalkDialogueId = other.TalkDialogueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x000C7B37 File Offset: 0x000C5D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x000C7B40 File Offset: 0x000C5D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TalkDialogueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001D26 RID: 7462
		private static readonly MessageParser<GetChessRogueStoryAeonTalkInfoCsReq> _parser = new MessageParser<GetChessRogueStoryAeonTalkInfoCsReq>(() => new GetChessRogueStoryAeonTalkInfoCsReq());

		// Token: 0x04001D27 RID: 7463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D28 RID: 7464
		public const int TalkDialogueIdFieldNumber = 10;

		// Token: 0x04001D29 RID: 7465
		private uint talkDialogueId_;
	}
}
