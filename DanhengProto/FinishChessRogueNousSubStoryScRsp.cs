using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000567 RID: 1383
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishChessRogueNousSubStoryScRsp : IMessage<FinishChessRogueNousSubStoryScRsp>, IMessage, IEquatable<FinishChessRogueNousSubStoryScRsp>, IDeepCloneable<FinishChessRogueNousSubStoryScRsp>, IBufferMessage
	{
		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06003DA6 RID: 15782 RVA: 0x000A8B9B File Offset: 0x000A6D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishChessRogueNousSubStoryScRsp> Parser
		{
			get
			{
				return FinishChessRogueNousSubStoryScRsp._parser;
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06003DA7 RID: 15783 RVA: 0x000A8BA2 File Offset: 0x000A6DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishChessRogueNousSubStoryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06003DA8 RID: 15784 RVA: 0x000A8BB4 File Offset: 0x000A6DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishChessRogueNousSubStoryScRsp.Descriptor;
			}
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x000A8BBB File Offset: 0x000A6DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueNousSubStoryScRsp()
		{
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x000A8BC3 File Offset: 0x000A6DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueNousSubStoryScRsp(FinishChessRogueNousSubStoryScRsp other) : this()
		{
			this.gKEJFEAKPAH_ = other.gKEJFEAKPAH_;
			this.retcode_ = other.retcode_;
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x000A8C00 File Offset: 0x000A6E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueNousSubStoryScRsp Clone()
		{
			return new FinishChessRogueNousSubStoryScRsp(this);
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06003DAC RID: 15788 RVA: 0x000A8C08 File Offset: 0x000A6E08
		// (set) Token: 0x06003DAD RID: 15789 RVA: 0x000A8C10 File Offset: 0x000A6E10
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

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x000A8C19 File Offset: 0x000A6E19
		// (set) Token: 0x06003DAF RID: 15791 RVA: 0x000A8C21 File Offset: 0x000A6E21
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

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x000A8C2A File Offset: 0x000A6E2A
		// (set) Token: 0x06003DB1 RID: 15793 RVA: 0x000A8C32 File Offset: 0x000A6E32
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

		// Token: 0x06003DB2 RID: 15794 RVA: 0x000A8C3B File Offset: 0x000A6E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishChessRogueNousSubStoryScRsp);
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x000A8C4C File Offset: 0x000A6E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishChessRogueNousSubStoryScRsp other)
		{
			return other != null && (other == this || (this.GKEJFEAKPAH == other.GKEJFEAKPAH && this.Retcode == other.Retcode && this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x000A8CA8 File Offset: 0x000A6EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GKEJFEAKPAH != 0U)
			{
				num ^= this.GKEJFEAKPAH.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
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

		// Token: 0x06003DB5 RID: 15797 RVA: 0x000A8D19 File Offset: 0x000A6F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x000A8D21 File Offset: 0x000A6F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x000A8D2C File Offset: 0x000A6F2C
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
				output.WriteRawTag(104);
				output.WriteUInt32(this.GKEJFEAKPAH);
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ChessRogueSubStoryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x000A8DA4 File Offset: 0x000A6FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GKEJFEAKPAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKEJFEAKPAH);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
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

		// Token: 0x06003DB9 RID: 15801 RVA: 0x000A8E14 File Offset: 0x000A7014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishChessRogueNousSubStoryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GKEJFEAKPAH != 0U)
			{
				this.GKEJFEAKPAH = other.GKEJFEAKPAH;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ChessRogueSubStoryId != 0U)
			{
				this.ChessRogueSubStoryId = other.ChessRogueSubStoryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x000A8E78 File Offset: 0x000A7078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x000A8E84 File Offset: 0x000A7084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ChessRogueSubStoryId = input.ReadUInt32();
						}
					}
					else
					{
						this.GKEJFEAKPAH = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040018A5 RID: 6309
		private static readonly MessageParser<FinishChessRogueNousSubStoryScRsp> _parser = new MessageParser<FinishChessRogueNousSubStoryScRsp>(() => new FinishChessRogueNousSubStoryScRsp());

		// Token: 0x040018A6 RID: 6310
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018A7 RID: 6311
		public const int GKEJFEAKPAHFieldNumber = 13;

		// Token: 0x040018A8 RID: 6312
		private uint gKEJFEAKPAH_;

		// Token: 0x040018A9 RID: 6313
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040018AA RID: 6314
		private uint retcode_;

		// Token: 0x040018AB RID: 6315
		public const int ChessRogueSubStoryIdFieldNumber = 14;

		// Token: 0x040018AC RID: 6316
		private uint chessRogueSubStoryId_;
	}
}
