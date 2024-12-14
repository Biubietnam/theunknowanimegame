using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010A7 RID: 4263
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectChessRogueSubStoryCsReq : IMessage<SelectChessRogueSubStoryCsReq>, IMessage, IEquatable<SelectChessRogueSubStoryCsReq>, IDeepCloneable<SelectChessRogueSubStoryCsReq>, IBufferMessage
	{
		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0600BE07 RID: 48647 RVA: 0x001FFEF3 File Offset: 0x001FE0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectChessRogueSubStoryCsReq> Parser
		{
			get
			{
				return SelectChessRogueSubStoryCsReq._parser;
			}
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0600BE08 RID: 48648 RVA: 0x001FFEFA File Offset: 0x001FE0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectChessRogueSubStoryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0600BE09 RID: 48649 RVA: 0x001FFF0C File Offset: 0x001FE10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectChessRogueSubStoryCsReq.Descriptor;
			}
		}

		// Token: 0x0600BE0A RID: 48650 RVA: 0x001FFF13 File Offset: 0x001FE113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueSubStoryCsReq()
		{
		}

		// Token: 0x0600BE0B RID: 48651 RVA: 0x001FFF1C File Offset: 0x001FE11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueSubStoryCsReq(SelectChessRogueSubStoryCsReq other) : this()
		{
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this.rogueDialogueEventId_ = other.rogueDialogueEventId_;
			this.gKEJFEAKPAH_ = other.gKEJFEAKPAH_;
			this.lONLLBIHMID_ = other.lONLLBIHMID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE0C RID: 48652 RVA: 0x001FFF70 File Offset: 0x001FE170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueSubStoryCsReq Clone()
		{
			return new SelectChessRogueSubStoryCsReq(this);
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x0600BE0D RID: 48653 RVA: 0x001FFF78 File Offset: 0x001FE178
		// (set) Token: 0x0600BE0E RID: 48654 RVA: 0x001FFF80 File Offset: 0x001FE180
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

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0600BE0F RID: 48655 RVA: 0x001FFF89 File Offset: 0x001FE189
		// (set) Token: 0x0600BE10 RID: 48656 RVA: 0x001FFF91 File Offset: 0x001FE191
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

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0600BE11 RID: 48657 RVA: 0x001FFF9A File Offset: 0x001FE19A
		// (set) Token: 0x0600BE12 RID: 48658 RVA: 0x001FFFA2 File Offset: 0x001FE1A2
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

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0600BE13 RID: 48659 RVA: 0x001FFFAB File Offset: 0x001FE1AB
		// (set) Token: 0x0600BE14 RID: 48660 RVA: 0x001FFFB3 File Offset: 0x001FE1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LONLLBIHMID
		{
			get
			{
				return this.lONLLBIHMID_;
			}
			set
			{
				this.lONLLBIHMID_ = value;
			}
		}

		// Token: 0x0600BE15 RID: 48661 RVA: 0x001FFFBC File Offset: 0x001FE1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectChessRogueSubStoryCsReq);
		}

		// Token: 0x0600BE16 RID: 48662 RVA: 0x001FFFCC File Offset: 0x001FE1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectChessRogueSubStoryCsReq other)
		{
			return other != null && (other == this || (this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && this.RogueDialogueEventId == other.RogueDialogueEventId && this.GKEJFEAKPAH == other.GKEJFEAKPAH && this.LONLLBIHMID == other.LONLLBIHMID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE17 RID: 48663 RVA: 0x00200038 File Offset: 0x001FE238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChessRogueSubStoryId != 0U)
			{
				num ^= this.ChessRogueSubStoryId.GetHashCode();
			}
			if (this.RogueDialogueEventId != 0U)
			{
				num ^= this.RogueDialogueEventId.GetHashCode();
			}
			if (this.GKEJFEAKPAH != 0U)
			{
				num ^= this.GKEJFEAKPAH.GetHashCode();
			}
			if (this.LONLLBIHMID != 0U)
			{
				num ^= this.LONLLBIHMID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE18 RID: 48664 RVA: 0x002000C2 File Offset: 0x001FE2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BE19 RID: 48665 RVA: 0x002000CA File Offset: 0x001FE2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE1A RID: 48666 RVA: 0x002000D4 File Offset: 0x001FE2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LONLLBIHMID != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.LONLLBIHMID);
			}
			if (this.GKEJFEAKPAH != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GKEJFEAKPAH);
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ChessRogueSubStoryId);
			}
			if (this.RogueDialogueEventId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.RogueDialogueEventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE1B RID: 48667 RVA: 0x00200168 File Offset: 0x001FE368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChessRogueSubStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueSubStoryId);
			}
			if (this.RogueDialogueEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueDialogueEventId);
			}
			if (this.GKEJFEAKPAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKEJFEAKPAH);
			}
			if (this.LONLLBIHMID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LONLLBIHMID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE1C RID: 48668 RVA: 0x002001F0 File Offset: 0x001FE3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectChessRogueSubStoryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChessRogueSubStoryId != 0U)
			{
				this.ChessRogueSubStoryId = other.ChessRogueSubStoryId;
			}
			if (other.RogueDialogueEventId != 0U)
			{
				this.RogueDialogueEventId = other.RogueDialogueEventId;
			}
			if (other.GKEJFEAKPAH != 0U)
			{
				this.GKEJFEAKPAH = other.GKEJFEAKPAH;
			}
			if (other.LONLLBIHMID != 0U)
			{
				this.LONLLBIHMID = other.LONLLBIHMID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE1D RID: 48669 RVA: 0x00200268 File Offset: 0x001FE468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE1E RID: 48670 RVA: 0x00200274 File Offset: 0x001FE474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.LONLLBIHMID = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.GKEJFEAKPAH = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.ChessRogueSubStoryId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.RogueDialogueEventId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D3A RID: 19770
		private static readonly MessageParser<SelectChessRogueSubStoryCsReq> _parser = new MessageParser<SelectChessRogueSubStoryCsReq>(() => new SelectChessRogueSubStoryCsReq());

		// Token: 0x04004D3B RID: 19771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D3C RID: 19772
		public const int ChessRogueSubStoryIdFieldNumber = 14;

		// Token: 0x04004D3D RID: 19773
		private uint chessRogueSubStoryId_;

		// Token: 0x04004D3E RID: 19774
		public const int RogueDialogueEventIdFieldNumber = 15;

		// Token: 0x04004D3F RID: 19775
		private uint rogueDialogueEventId_;

		// Token: 0x04004D40 RID: 19776
		public const int GKEJFEAKPAHFieldNumber = 6;

		// Token: 0x04004D41 RID: 19777
		private uint gKEJFEAKPAH_;

		// Token: 0x04004D42 RID: 19778
		public const int LONLLBIHMIDFieldNumber = 4;

		// Token: 0x04004D43 RID: 19779
		private uint lONLLBIHMID_;
	}
}
