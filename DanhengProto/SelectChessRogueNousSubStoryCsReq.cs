using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010A3 RID: 4259
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectChessRogueNousSubStoryCsReq : IMessage<SelectChessRogueNousSubStoryCsReq>, IMessage, IEquatable<SelectChessRogueNousSubStoryCsReq>, IDeepCloneable<SelectChessRogueNousSubStoryCsReq>, IBufferMessage
	{
		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x0600BDD3 RID: 48595 RVA: 0x001FF617 File Offset: 0x001FD817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectChessRogueNousSubStoryCsReq> Parser
		{
			get
			{
				return SelectChessRogueNousSubStoryCsReq._parser;
			}
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0600BDD4 RID: 48596 RVA: 0x001FF61E File Offset: 0x001FD81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectChessRogueNousSubStoryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0600BDD5 RID: 48597 RVA: 0x001FF630 File Offset: 0x001FD830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectChessRogueNousSubStoryCsReq.Descriptor;
			}
		}

		// Token: 0x0600BDD6 RID: 48598 RVA: 0x001FF637 File Offset: 0x001FD837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueNousSubStoryCsReq()
		{
		}

		// Token: 0x0600BDD7 RID: 48599 RVA: 0x001FF63F File Offset: 0x001FD83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueNousSubStoryCsReq(SelectChessRogueNousSubStoryCsReq other) : this()
		{
			this.rogueDialogueEventId_ = other.rogueDialogueEventId_;
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this.gKEJFEAKPAH_ = other.gKEJFEAKPAH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDD8 RID: 48600 RVA: 0x001FF67C File Offset: 0x001FD87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueNousSubStoryCsReq Clone()
		{
			return new SelectChessRogueNousSubStoryCsReq(this);
		}

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0600BDD9 RID: 48601 RVA: 0x001FF684 File Offset: 0x001FD884
		// (set) Token: 0x0600BDDA RID: 48602 RVA: 0x001FF68C File Offset: 0x001FD88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueDialogueEventId
		{
			get
			{
				return this.rogueDialogueEventId_;
			}
			set
			{
				this.rogueDialogueEventId_ = value;
			}
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0600BDDB RID: 48603 RVA: 0x001FF695 File Offset: 0x001FD895
		// (set) Token: 0x0600BDDC RID: 48604 RVA: 0x001FF69D File Offset: 0x001FD89D
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

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x0600BDDD RID: 48605 RVA: 0x001FF6A6 File Offset: 0x001FD8A6
		// (set) Token: 0x0600BDDE RID: 48606 RVA: 0x001FF6AE File Offset: 0x001FD8AE
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

		// Token: 0x0600BDDF RID: 48607 RVA: 0x001FF6B7 File Offset: 0x001FD8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectChessRogueNousSubStoryCsReq);
		}

		// Token: 0x0600BDE0 RID: 48608 RVA: 0x001FF6C8 File Offset: 0x001FD8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectChessRogueNousSubStoryCsReq other)
		{
			return other != null && (other == this || (this.RogueDialogueEventId == other.RogueDialogueEventId && this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && this.GKEJFEAKPAH == other.GKEJFEAKPAH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x001FF724 File Offset: 0x001FD924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RogueDialogueEventId != 0U)
			{
				num ^= this.RogueDialogueEventId.GetHashCode();
			}
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

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x001FF795 File Offset: 0x001FD995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BDE3 RID: 48611 RVA: 0x001FF79D File Offset: 0x001FD99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x001FF7A8 File Offset: 0x001FD9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RogueDialogueEventId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.RogueDialogueEventId);
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ChessRogueSubStoryId);
			}
			if (this.GKEJFEAKPAH != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GKEJFEAKPAH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x001FF820 File Offset: 0x001FDA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RogueDialogueEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueDialogueEventId);
			}
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

		// Token: 0x0600BDE6 RID: 48614 RVA: 0x001FF890 File Offset: 0x001FDA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectChessRogueNousSubStoryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RogueDialogueEventId != 0U)
			{
				this.RogueDialogueEventId = other.RogueDialogueEventId;
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

		// Token: 0x0600BDE7 RID: 48615 RVA: 0x001FF8F4 File Offset: 0x001FDAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDE8 RID: 48616 RVA: 0x001FF900 File Offset: 0x001FDB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 88U)
					{
						if (num != 104U)
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
				else
				{
					this.RogueDialogueEventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D26 RID: 19750
		private static readonly MessageParser<SelectChessRogueNousSubStoryCsReq> _parser = new MessageParser<SelectChessRogueNousSubStoryCsReq>(() => new SelectChessRogueNousSubStoryCsReq());

		// Token: 0x04004D27 RID: 19751
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D28 RID: 19752
		public const int RogueDialogueEventIdFieldNumber = 6;

		// Token: 0x04004D29 RID: 19753
		private uint rogueDialogueEventId_;

		// Token: 0x04004D2A RID: 19754
		public const int ChessRogueSubStoryIdFieldNumber = 11;

		// Token: 0x04004D2B RID: 19755
		private uint chessRogueSubStoryId_;

		// Token: 0x04004D2C RID: 19756
		public const int GKEJFEAKPAHFieldNumber = 13;

		// Token: 0x04004D2D RID: 19757
		private uint gKEJFEAKPAH_;
	}
}
