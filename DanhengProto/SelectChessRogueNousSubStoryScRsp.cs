using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010A5 RID: 4261
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectChessRogueNousSubStoryScRsp : IMessage<SelectChessRogueNousSubStoryScRsp>, IMessage, IEquatable<SelectChessRogueNousSubStoryScRsp>, IDeepCloneable<SelectChessRogueNousSubStoryScRsp>, IBufferMessage
	{
		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x0600BDEC RID: 48620 RVA: 0x001FFA2B File Offset: 0x001FDC2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectChessRogueNousSubStoryScRsp> Parser
		{
			get
			{
				return SelectChessRogueNousSubStoryScRsp._parser;
			}
		}

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x0600BDED RID: 48621 RVA: 0x001FFA32 File Offset: 0x001FDC32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectChessRogueNousSubStoryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x0600BDEE RID: 48622 RVA: 0x001FFA44 File Offset: 0x001FDC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectChessRogueNousSubStoryScRsp.Descriptor;
			}
		}

		// Token: 0x0600BDEF RID: 48623 RVA: 0x001FFA4B File Offset: 0x001FDC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueNousSubStoryScRsp()
		{
		}

		// Token: 0x0600BDF0 RID: 48624 RVA: 0x001FFA54 File Offset: 0x001FDC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueNousSubStoryScRsp(SelectChessRogueNousSubStoryScRsp other) : this()
		{
			this.gKEJFEAKPAH_ = other.gKEJFEAKPAH_;
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this.rogueDialogueEventId_ = other.rogueDialogueEventId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDF1 RID: 48625 RVA: 0x001FFAA8 File Offset: 0x001FDCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueNousSubStoryScRsp Clone()
		{
			return new SelectChessRogueNousSubStoryScRsp(this);
		}

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0600BDF2 RID: 48626 RVA: 0x001FFAB0 File Offset: 0x001FDCB0
		// (set) Token: 0x0600BDF3 RID: 48627 RVA: 0x001FFAB8 File Offset: 0x001FDCB8
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

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0600BDF4 RID: 48628 RVA: 0x001FFAC1 File Offset: 0x001FDCC1
		// (set) Token: 0x0600BDF5 RID: 48629 RVA: 0x001FFAC9 File Offset: 0x001FDCC9
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

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x0600BDF6 RID: 48630 RVA: 0x001FFAD2 File Offset: 0x001FDCD2
		// (set) Token: 0x0600BDF7 RID: 48631 RVA: 0x001FFADA File Offset: 0x001FDCDA
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

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0600BDF8 RID: 48632 RVA: 0x001FFAE3 File Offset: 0x001FDCE3
		// (set) Token: 0x0600BDF9 RID: 48633 RVA: 0x001FFAEB File Offset: 0x001FDCEB
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

		// Token: 0x0600BDFA RID: 48634 RVA: 0x001FFAF4 File Offset: 0x001FDCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectChessRogueNousSubStoryScRsp);
		}

		// Token: 0x0600BDFB RID: 48635 RVA: 0x001FFB04 File Offset: 0x001FDD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectChessRogueNousSubStoryScRsp other)
		{
			return other != null && (other == this || (this.GKEJFEAKPAH == other.GKEJFEAKPAH && this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && this.RogueDialogueEventId == other.RogueDialogueEventId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDFC RID: 48636 RVA: 0x001FFB70 File Offset: 0x001FDD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GKEJFEAKPAH != 0U)
			{
				num ^= this.GKEJFEAKPAH.GetHashCode();
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				num ^= this.ChessRogueSubStoryId.GetHashCode();
			}
			if (this.RogueDialogueEventId != 0U)
			{
				num ^= this.RogueDialogueEventId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BDFD RID: 48637 RVA: 0x001FFBFA File Offset: 0x001FDDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BDFE RID: 48638 RVA: 0x001FFC02 File Offset: 0x001FDE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDFF RID: 48639 RVA: 0x001FFC0C File Offset: 0x001FDE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GKEJFEAKPAH != 0U)
			{
				output.WriteRawTag(32);
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

		// Token: 0x0600BE00 RID: 48640 RVA: 0x001FFCA0 File Offset: 0x001FDEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GKEJFEAKPAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKEJFEAKPAH);
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueSubStoryId);
			}
			if (this.RogueDialogueEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueDialogueEventId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE01 RID: 48641 RVA: 0x001FFD28 File Offset: 0x001FDF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectChessRogueNousSubStoryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GKEJFEAKPAH != 0U)
			{
				this.GKEJFEAKPAH = other.GKEJFEAKPAH;
			}
			if (other.ChessRogueSubStoryId != 0U)
			{
				this.ChessRogueSubStoryId = other.ChessRogueSubStoryId;
			}
			if (other.RogueDialogueEventId != 0U)
			{
				this.RogueDialogueEventId = other.RogueDialogueEventId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE02 RID: 48642 RVA: 0x001FFDA0 File Offset: 0x001FDFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE03 RID: 48643 RVA: 0x001FFDAC File Offset: 0x001FDFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
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

		// Token: 0x04004D2F RID: 19759
		private static readonly MessageParser<SelectChessRogueNousSubStoryScRsp> _parser = new MessageParser<SelectChessRogueNousSubStoryScRsp>(() => new SelectChessRogueNousSubStoryScRsp());

		// Token: 0x04004D30 RID: 19760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D31 RID: 19761
		public const int GKEJFEAKPAHFieldNumber = 4;

		// Token: 0x04004D32 RID: 19762
		private uint gKEJFEAKPAH_;

		// Token: 0x04004D33 RID: 19763
		public const int ChessRogueSubStoryIdFieldNumber = 14;

		// Token: 0x04004D34 RID: 19764
		private uint chessRogueSubStoryId_;

		// Token: 0x04004D35 RID: 19765
		public const int RogueDialogueEventIdFieldNumber = 15;

		// Token: 0x04004D36 RID: 19766
		private uint rogueDialogueEventId_;

		// Token: 0x04004D37 RID: 19767
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04004D38 RID: 19768
		private uint retcode_;
	}
}
