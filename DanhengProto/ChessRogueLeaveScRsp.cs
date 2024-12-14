using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000239 RID: 569
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueLeaveScRsp : IMessage<ChessRogueLeaveScRsp>, IMessage, IEquatable<ChessRogueLeaveScRsp>, IDeepCloneable<ChessRogueLeaveScRsp>, IBufferMessage
	{
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x0004A714 File Offset: 0x00048914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueLeaveScRsp> Parser
		{
			get
			{
				return ChessRogueLeaveScRsp._parser;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x0004A71B File Offset: 0x0004891B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueLeaveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x0004A72D File Offset: 0x0004892D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueLeaveScRsp.Descriptor;
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0004A734 File Offset: 0x00048934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLeaveScRsp()
		{
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0004A73C File Offset: 0x0004893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLeaveScRsp(ChessRogueLeaveScRsp other) : this()
		{
			this.rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.rogueAeonInfo_ = ((other.rogueAeonInfo_ != null) ? other.rogueAeonInfo_.Clone() : null);
			this.queryInfo_ = ((other.queryInfo_ != null) ? other.queryInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0004A7DC File Offset: 0x000489DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLeaveScRsp Clone()
		{
			return new ChessRogueLeaveScRsp(this);
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x0004A7E4 File Offset: 0x000489E4
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x0004A7EC File Offset: 0x000489EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGetInfo RogueGetInfo
		{
			get
			{
				return this.rogueGetInfo_;
			}
			set
			{
				this.rogueGetInfo_ = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x0004A7F5 File Offset: 0x000489F5
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x0004A7FD File Offset: 0x000489FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueInfo StageInfo
		{
			get
			{
				return this.stageInfo_;
			}
			set
			{
				this.stageInfo_ = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x0004A806 File Offset: 0x00048A06
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x0004A80E File Offset: 0x00048A0E
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

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0004A817 File Offset: 0x00048A17
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0004A81F File Offset: 0x00048A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueAeonInfo RogueAeonInfo
		{
			get
			{
				return this.rogueAeonInfo_;
			}
			set
			{
				this.rogueAeonInfo_ = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x0004A828 File Offset: 0x00048A28
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x0004A830 File Offset: 0x00048A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryInfo QueryInfo
		{
			get
			{
				return this.queryInfo_;
			}
			set
			{
				this.queryInfo_ = value;
			}
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0004A839 File Offset: 0x00048A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueLeaveScRsp);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x0004A848 File Offset: 0x00048A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueLeaveScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueGetInfo, other.RogueGetInfo) && object.Equals(this.StageInfo, other.StageInfo) && this.Retcode == other.Retcode && object.Equals(this.RogueAeonInfo, other.RogueAeonInfo) && object.Equals(this.QueryInfo, other.QueryInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0004A8D8 File Offset: 0x00048AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueGetInfo_ != null)
			{
				num ^= this.RogueGetInfo.GetHashCode();
			}
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueAeonInfo_ != null)
			{
				num ^= this.RogueAeonInfo.GetHashCode();
			}
			if (this.queryInfo_ != null)
			{
				num ^= this.QueryInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0004A96F File Offset: 0x00048B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0004A977 File Offset: 0x00048B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0004A980 File Offset: 0x00048B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueAeonInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueAeonInfo);
			}
			if (this.rogueGetInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueGetInfo);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.StageInfo);
			}
			if (this.queryInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.QueryInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0004AA30 File Offset: 0x00048C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueGetInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGetInfo);
			}
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAeonInfo);
			}
			if (this.queryInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QueryInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0004AAD0 File Offset: 0x00048CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueLeaveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueGetInfo_ != null)
			{
				if (this.rogueGetInfo_ == null)
				{
					this.RogueGetInfo = new ChessRogueGetInfo();
				}
				this.RogueGetInfo.MergeFrom(other.RogueGetInfo);
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new ChessRogueInfo();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueAeonInfo_ != null)
			{
				if (this.rogueAeonInfo_ == null)
				{
					this.RogueAeonInfo = new ChessRogueAeonInfo();
				}
				this.RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
			}
			if (other.queryInfo_ != null)
			{
				if (this.queryInfo_ == null)
				{
					this.QueryInfo = new ChessRogueQueryInfo();
				}
				this.QueryInfo.MergeFrom(other.QueryInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0004ABBC File Offset: 0x00048DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0004ABC8 File Offset: 0x00048DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 42U)
					{
						if (this.rogueAeonInfo_ == null)
						{
							this.RogueAeonInfo = new ChessRogueAeonInfo();
						}
						input.ReadMessage(this.RogueAeonInfo);
						continue;
					}
					if (num == 50U)
					{
						if (this.rogueGetInfo_ == null)
						{
							this.RogueGetInfo = new ChessRogueGetInfo();
						}
						input.ReadMessage(this.RogueGetInfo);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.stageInfo_ == null)
						{
							this.StageInfo = new ChessRogueInfo();
						}
						input.ReadMessage(this.StageInfo);
						continue;
					}
					if (num == 90U)
					{
						if (this.queryInfo_ == null)
						{
							this.QueryInfo = new ChessRogueQueryInfo();
						}
						input.ReadMessage(this.QueryInfo);
						continue;
					}
					if (num == 104U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000AE0 RID: 2784
		private static readonly MessageParser<ChessRogueLeaveScRsp> _parser = new MessageParser<ChessRogueLeaveScRsp>(() => new ChessRogueLeaveScRsp());

		// Token: 0x04000AE1 RID: 2785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AE2 RID: 2786
		public const int RogueGetInfoFieldNumber = 6;

		// Token: 0x04000AE3 RID: 2787
		private ChessRogueGetInfo rogueGetInfo_;

		// Token: 0x04000AE4 RID: 2788
		public const int StageInfoFieldNumber = 9;

		// Token: 0x04000AE5 RID: 2789
		private ChessRogueInfo stageInfo_;

		// Token: 0x04000AE6 RID: 2790
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04000AE7 RID: 2791
		private uint retcode_;

		// Token: 0x04000AE8 RID: 2792
		public const int RogueAeonInfoFieldNumber = 5;

		// Token: 0x04000AE9 RID: 2793
		private ChessRogueAeonInfo rogueAeonInfo_;

		// Token: 0x04000AEA RID: 2794
		public const int QueryInfoFieldNumber = 11;

		// Token: 0x04000AEB RID: 2795
		private ChessRogueQueryInfo queryInfo_;
	}
}
