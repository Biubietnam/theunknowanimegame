using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000565 RID: 1381
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishChessRogueNousSubStoryCsReq : IMessage<FinishChessRogueNousSubStoryCsReq>, IMessage, IEquatable<FinishChessRogueNousSubStoryCsReq>, IDeepCloneable<FinishChessRogueNousSubStoryCsReq>, IBufferMessage
	{
		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x000A8841 File Offset: 0x000A6A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishChessRogueNousSubStoryCsReq> Parser
		{
			get
			{
				return FinishChessRogueNousSubStoryCsReq._parser;
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06003D90 RID: 15760 RVA: 0x000A8848 File Offset: 0x000A6A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishChessRogueNousSubStoryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06003D91 RID: 15761 RVA: 0x000A885A File Offset: 0x000A6A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishChessRogueNousSubStoryCsReq.Descriptor;
			}
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x000A8861 File Offset: 0x000A6A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueNousSubStoryCsReq()
		{
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x000A8869 File Offset: 0x000A6A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueNousSubStoryCsReq(FinishChessRogueNousSubStoryCsReq other) : this()
		{
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this.gKEJFEAKPAH_ = other.gKEJFEAKPAH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x000A889A File Offset: 0x000A6A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueNousSubStoryCsReq Clone()
		{
			return new FinishChessRogueNousSubStoryCsReq(this);
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x000A88A2 File Offset: 0x000A6AA2
		// (set) Token: 0x06003D96 RID: 15766 RVA: 0x000A88AA File Offset: 0x000A6AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChessRogueSubStoryId
		{
			get
			{
				return this.chessRogueSubStoryId_;
			}
			set
			{
				this.chessRogueSubStoryId_ = value;
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06003D97 RID: 15767 RVA: 0x000A88B3 File Offset: 0x000A6AB3
		// (set) Token: 0x06003D98 RID: 15768 RVA: 0x000A88BB File Offset: 0x000A6ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GKEJFEAKPAH
		{
			get
			{
				return this.gKEJFEAKPAH_;
			}
			set
			{
				this.gKEJFEAKPAH_ = value;
			}
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x000A88C4 File Offset: 0x000A6AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishChessRogueNousSubStoryCsReq);
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x000A88D2 File Offset: 0x000A6AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishChessRogueNousSubStoryCsReq other)
		{
			return other != null && (other == this || (this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && this.GKEJFEAKPAH == other.GKEJFEAKPAH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x000A8910 File Offset: 0x000A6B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChessRogueSubStoryId != 0U)
			{
				num ^= this.ChessRogueSubStoryId.GetHashCode();
			}
			if (this.GKEJFEAKPAH != 0U)
			{
				num ^= this.GKEJFEAKPAH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x000A8968 File Offset: 0x000A6B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x000A8970 File Offset: 0x000A6B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x000A897C File Offset: 0x000A6B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChessRogueSubStoryId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ChessRogueSubStoryId);
			}
			if (this.GKEJFEAKPAH != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GKEJFEAKPAH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x000A89D8 File Offset: 0x000A6BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChessRogueSubStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueSubStoryId);
			}
			if (this.GKEJFEAKPAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKEJFEAKPAH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x000A8A30 File Offset: 0x000A6C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishChessRogueNousSubStoryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChessRogueSubStoryId != 0U)
			{
				this.ChessRogueSubStoryId = other.ChessRogueSubStoryId;
			}
			if (other.GKEJFEAKPAH != 0U)
			{
				this.GKEJFEAKPAH = other.GKEJFEAKPAH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x000A8A80 File Offset: 0x000A6C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x000A8A8C File Offset: 0x000A6C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GKEJFEAKPAH = input.ReadUInt32();
					}
				}
				else
				{
					this.ChessRogueSubStoryId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400189E RID: 6302
		private static readonly MessageParser<FinishChessRogueNousSubStoryCsReq> _parser = new MessageParser<FinishChessRogueNousSubStoryCsReq>(() => new FinishChessRogueNousSubStoryCsReq());

		// Token: 0x0400189F RID: 6303
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018A0 RID: 6304
		public const int ChessRogueSubStoryIdFieldNumber = 9;

		// Token: 0x040018A1 RID: 6305
		private uint chessRogueSubStoryId_;

		// Token: 0x040018A2 RID: 6306
		public const int GKEJFEAKPAHFieldNumber = 14;

		// Token: 0x040018A3 RID: 6307
		private uint gKEJFEAKPAH_;
	}
}
