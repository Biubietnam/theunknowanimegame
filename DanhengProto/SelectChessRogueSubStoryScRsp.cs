using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010A9 RID: 4265
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectChessRogueSubStoryScRsp : IMessage<SelectChessRogueSubStoryScRsp>, IMessage, IEquatable<SelectChessRogueSubStoryScRsp>, IDeepCloneable<SelectChessRogueSubStoryScRsp>, IBufferMessage
	{
		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x0600BE22 RID: 48674 RVA: 0x002003CB File Offset: 0x001FE5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectChessRogueSubStoryScRsp> Parser
		{
			get
			{
				return SelectChessRogueSubStoryScRsp._parser;
			}
		}

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0600BE23 RID: 48675 RVA: 0x002003D2 File Offset: 0x001FE5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectChessRogueSubStoryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0600BE24 RID: 48676 RVA: 0x002003E4 File Offset: 0x001FE5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectChessRogueSubStoryScRsp.Descriptor;
			}
		}

		// Token: 0x0600BE25 RID: 48677 RVA: 0x002003EB File Offset: 0x001FE5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueSubStoryScRsp()
		{
		}

		// Token: 0x0600BE26 RID: 48678 RVA: 0x002003F4 File Offset: 0x001FE5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueSubStoryScRsp(SelectChessRogueSubStoryScRsp other) : this()
		{
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this.lONLLBIHMID_ = other.lONLLBIHMID_;
			this.rogueDialogueEventId_ = other.rogueDialogueEventId_;
			this.retcode_ = other.retcode_;
			this.gKEJFEAKPAH_ = other.gKEJFEAKPAH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE27 RID: 48679 RVA: 0x00200454 File Offset: 0x001FE654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectChessRogueSubStoryScRsp Clone()
		{
			return new SelectChessRogueSubStoryScRsp(this);
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0600BE28 RID: 48680 RVA: 0x0020045C File Offset: 0x001FE65C
		// (set) Token: 0x0600BE29 RID: 48681 RVA: 0x00200464 File Offset: 0x001FE664
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

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0600BE2A RID: 48682 RVA: 0x0020046D File Offset: 0x001FE66D
		// (set) Token: 0x0600BE2B RID: 48683 RVA: 0x00200475 File Offset: 0x001FE675
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

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x0600BE2C RID: 48684 RVA: 0x0020047E File Offset: 0x001FE67E
		// (set) Token: 0x0600BE2D RID: 48685 RVA: 0x00200486 File Offset: 0x001FE686
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

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0600BE2E RID: 48686 RVA: 0x0020048F File Offset: 0x001FE68F
		// (set) Token: 0x0600BE2F RID: 48687 RVA: 0x00200497 File Offset: 0x001FE697
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

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0600BE30 RID: 48688 RVA: 0x002004A0 File Offset: 0x001FE6A0
		// (set) Token: 0x0600BE31 RID: 48689 RVA: 0x002004A8 File Offset: 0x001FE6A8
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

		// Token: 0x0600BE32 RID: 48690 RVA: 0x002004B1 File Offset: 0x001FE6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectChessRogueSubStoryScRsp);
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x002004C0 File Offset: 0x001FE6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectChessRogueSubStoryScRsp other)
		{
			return other != null && (other == this || (this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && this.LONLLBIHMID == other.LONLLBIHMID && this.RogueDialogueEventId == other.RogueDialogueEventId && this.Retcode == other.Retcode && this.GKEJFEAKPAH == other.GKEJFEAKPAH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE34 RID: 48692 RVA: 0x0020053C File Offset: 0x001FE73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChessRogueSubStoryId != 0U)
			{
				num ^= this.ChessRogueSubStoryId.GetHashCode();
			}
			if (this.LONLLBIHMID != 0U)
			{
				num ^= this.LONLLBIHMID.GetHashCode();
			}
			if (this.RogueDialogueEventId != 0U)
			{
				num ^= this.RogueDialogueEventId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
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

		// Token: 0x0600BE35 RID: 48693 RVA: 0x002005DF File Offset: 0x001FE7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BE36 RID: 48694 RVA: 0x002005E7 File Offset: 0x001FE7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE37 RID: 48695 RVA: 0x002005F0 File Offset: 0x001FE7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChessRogueSubStoryId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ChessRogueSubStoryId);
			}
			if (this.GKEJFEAKPAH != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GKEJFEAKPAH);
			}
			if (this.RogueDialogueEventId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.RogueDialogueEventId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.LONLLBIHMID != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LONLLBIHMID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE38 RID: 48696 RVA: 0x002006A0 File Offset: 0x001FE8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChessRogueSubStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueSubStoryId);
			}
			if (this.LONLLBIHMID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LONLLBIHMID);
			}
			if (this.RogueDialogueEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueDialogueEventId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
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

		// Token: 0x0600BE39 RID: 48697 RVA: 0x00200740 File Offset: 0x001FE940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectChessRogueSubStoryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChessRogueSubStoryId != 0U)
			{
				this.ChessRogueSubStoryId = other.ChessRogueSubStoryId;
			}
			if (other.LONLLBIHMID != 0U)
			{
				this.LONLLBIHMID = other.LONLLBIHMID;
			}
			if (other.RogueDialogueEventId != 0U)
			{
				this.RogueDialogueEventId = other.RogueDialogueEventId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.GKEJFEAKPAH != 0U)
			{
				this.GKEJFEAKPAH = other.GKEJFEAKPAH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE3A RID: 48698 RVA: 0x002007CC File Offset: 0x001FE9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE3B RID: 48699 RVA: 0x002007D8 File Offset: 0x001FE9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.ChessRogueSubStoryId = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.GKEJFEAKPAH = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.RogueDialogueEventId = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.LONLLBIHMID = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D45 RID: 19781
		private static readonly MessageParser<SelectChessRogueSubStoryScRsp> _parser = new MessageParser<SelectChessRogueSubStoryScRsp>(() => new SelectChessRogueSubStoryScRsp());

		// Token: 0x04004D46 RID: 19782
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D47 RID: 19783
		public const int ChessRogueSubStoryIdFieldNumber = 4;

		// Token: 0x04004D48 RID: 19784
		private uint chessRogueSubStoryId_;

		// Token: 0x04004D49 RID: 19785
		public const int LONLLBIHMIDFieldNumber = 14;

		// Token: 0x04004D4A RID: 19786
		private uint lONLLBIHMID_;

		// Token: 0x04004D4B RID: 19787
		public const int RogueDialogueEventIdFieldNumber = 7;

		// Token: 0x04004D4C RID: 19788
		private uint rogueDialogueEventId_;

		// Token: 0x04004D4D RID: 19789
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004D4E RID: 19790
		private uint retcode_;

		// Token: 0x04004D4F RID: 19791
		public const int GKEJFEAKPAHFieldNumber = 5;

		// Token: 0x04004D50 RID: 19792
		private uint gKEJFEAKPAH_;
	}
}
