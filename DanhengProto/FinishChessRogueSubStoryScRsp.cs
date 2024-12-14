using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200056B RID: 1387
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishChessRogueSubStoryScRsp : IMessage<FinishChessRogueSubStoryScRsp>, IMessage, IEquatable<FinishChessRogueSubStoryScRsp>, IDeepCloneable<FinishChessRogueSubStoryScRsp>, IBufferMessage
	{
		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06003DD8 RID: 15832 RVA: 0x000A93CB File Offset: 0x000A75CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishChessRogueSubStoryScRsp> Parser
		{
			get
			{
				return FinishChessRogueSubStoryScRsp._parser;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06003DD9 RID: 15833 RVA: 0x000A93D2 File Offset: 0x000A75D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishChessRogueSubStoryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x000A93E4 File Offset: 0x000A75E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishChessRogueSubStoryScRsp.Descriptor;
			}
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x000A93EB File Offset: 0x000A75EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueSubStoryScRsp()
		{
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x000A93F4 File Offset: 0x000A75F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueSubStoryScRsp(FinishChessRogueSubStoryScRsp other) : this()
		{
			this.gKEJFEAKPAH_ = other.gKEJFEAKPAH_;
			this.chessRogueMainStoryId_ = other.chessRogueMainStoryId_;
			this.retcode_ = other.retcode_;
			this.lONLLBIHMID_ = other.lONLLBIHMID_;
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x000A9454 File Offset: 0x000A7654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueSubStoryScRsp Clone()
		{
			return new FinishChessRogueSubStoryScRsp(this);
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x000A945C File Offset: 0x000A765C
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x000A9464 File Offset: 0x000A7664
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

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06003DE0 RID: 15840 RVA: 0x000A946D File Offset: 0x000A766D
		// (set) Token: 0x06003DE1 RID: 15841 RVA: 0x000A9475 File Offset: 0x000A7675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChessRogueMainStoryId
		{
			get
			{
				return this.chessRogueMainStoryId_;
			}
			set
			{
				this.chessRogueMainStoryId_ = value;
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x000A947E File Offset: 0x000A767E
		// (set) Token: 0x06003DE3 RID: 15843 RVA: 0x000A9486 File Offset: 0x000A7686
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

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x000A948F File Offset: 0x000A768F
		// (set) Token: 0x06003DE5 RID: 15845 RVA: 0x000A9497 File Offset: 0x000A7697
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

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x000A94A0 File Offset: 0x000A76A0
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x000A94A8 File Offset: 0x000A76A8
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

		// Token: 0x06003DE8 RID: 15848 RVA: 0x000A94B1 File Offset: 0x000A76B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishChessRogueSubStoryScRsp);
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x000A94C0 File Offset: 0x000A76C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishChessRogueSubStoryScRsp other)
		{
			return other != null && (other == this || (this.GKEJFEAKPAH == other.GKEJFEAKPAH && this.ChessRogueMainStoryId == other.ChessRogueMainStoryId && this.Retcode == other.Retcode && this.LONLLBIHMID == other.LONLLBIHMID && this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x000A953C File Offset: 0x000A773C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GKEJFEAKPAH != 0U)
			{
				num ^= this.GKEJFEAKPAH.GetHashCode();
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				num ^= this.ChessRogueMainStoryId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.LONLLBIHMID != 0U)
			{
				num ^= this.LONLLBIHMID.GetHashCode();
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				num ^= this.ChessRogueSubStoryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x000A95DF File Offset: 0x000A77DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x000A95E7 File Offset: 0x000A77E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x000A95F0 File Offset: 0x000A77F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GKEJFEAKPAH != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GKEJFEAKPAH);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.LONLLBIHMID != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.LONLLBIHMID);
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ChessRogueSubStoryId);
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ChessRogueMainStoryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x000A969C File Offset: 0x000A789C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GKEJFEAKPAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKEJFEAKPAH);
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueMainStoryId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.LONLLBIHMID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LONLLBIHMID);
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueSubStoryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x000A973C File Offset: 0x000A793C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishChessRogueSubStoryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GKEJFEAKPAH != 0U)
			{
				this.GKEJFEAKPAH = other.GKEJFEAKPAH;
			}
			if (other.ChessRogueMainStoryId != 0U)
			{
				this.ChessRogueMainStoryId = other.ChessRogueMainStoryId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.LONLLBIHMID != 0U)
			{
				this.LONLLBIHMID = other.LONLLBIHMID;
			}
			if (other.ChessRogueSubStoryId != 0U)
			{
				this.ChessRogueSubStoryId = other.ChessRogueSubStoryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x000A97C8 File Offset: 0x000A79C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x000A97D4 File Offset: 0x000A79D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.GKEJFEAKPAH = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.LONLLBIHMID = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ChessRogueSubStoryId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ChessRogueMainStoryId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040018B7 RID: 6327
		private static readonly MessageParser<FinishChessRogueSubStoryScRsp> _parser = new MessageParser<FinishChessRogueSubStoryScRsp>(() => new FinishChessRogueSubStoryScRsp());

		// Token: 0x040018B8 RID: 6328
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018B9 RID: 6329
		public const int GKEJFEAKPAHFieldNumber = 1;

		// Token: 0x040018BA RID: 6330
		private uint gKEJFEAKPAH_;

		// Token: 0x040018BB RID: 6331
		public const int ChessRogueMainStoryIdFieldNumber = 14;

		// Token: 0x040018BC RID: 6332
		private uint chessRogueMainStoryId_;

		// Token: 0x040018BD RID: 6333
		public const int RetcodeFieldNumber = 6;

		// Token: 0x040018BE RID: 6334
		private uint retcode_;

		// Token: 0x040018BF RID: 6335
		public const int LONLLBIHMIDFieldNumber = 7;

		// Token: 0x040018C0 RID: 6336
		private uint lONLLBIHMID_;

		// Token: 0x040018C1 RID: 6337
		public const int ChessRogueSubStoryIdFieldNumber = 13;

		// Token: 0x040018C2 RID: 6338
		private uint chessRogueSubStoryId_;
	}
}
