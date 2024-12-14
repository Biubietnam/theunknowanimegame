using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200020F RID: 527
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueEnterCellScRsp : IMessage<ChessRogueEnterCellScRsp>, IMessage, IEquatable<ChessRogueEnterCellScRsp>, IDeepCloneable<ChessRogueEnterCellScRsp>, IBufferMessage
	{
		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x0004362F File Offset: 0x0004182F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueEnterCellScRsp> Parser
		{
			get
			{
				return ChessRogueEnterCellScRsp._parser;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x00043636 File Offset: 0x00041836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueEnterCellScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00043648 File Offset: 0x00041848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueEnterCellScRsp.Descriptor;
			}
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0004364F File Offset: 0x0004184F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterCellScRsp()
		{
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00043658 File Offset: 0x00041858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterCellScRsp(ChessRogueEnterCellScRsp other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.cellId_ = other.cellId_;
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.rogueCurrentInfo_ = ((other.rogueCurrentInfo_ != null) ? other.rogueCurrentInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x000436E8 File Offset: 0x000418E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterCellScRsp Clone()
		{
			return new ChessRogueEnterCellScRsp(this);
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x000436F0 File Offset: 0x000418F0
		// (set) Token: 0x06001772 RID: 6002 RVA: 0x000436F8 File Offset: 0x000418F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGameInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x00043701 File Offset: 0x00041901
		// (set) Token: 0x06001774 RID: 6004 RVA: 0x00043709 File Offset: 0x00041909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CellId
		{
			get
			{
				return this.cellId_;
			}
			set
			{
				this.cellId_ = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x00043712 File Offset: 0x00041912
		// (set) Token: 0x06001776 RID: 6006 RVA: 0x0004371A File Offset: 0x0004191A
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

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x00043723 File Offset: 0x00041923
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x0004372B File Offset: 0x0004192B
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

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x00043734 File Offset: 0x00041934
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x0004373C File Offset: 0x0004193C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCurrentInfo RogueCurrentInfo
		{
			get
			{
				return this.rogueCurrentInfo_;
			}
			set
			{
				this.rogueCurrentInfo_ = value;
			}
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00043745 File Offset: 0x00041945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueEnterCellScRsp);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00043754 File Offset: 0x00041954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueEnterCellScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.CellId == other.CellId && object.Equals(this.StageInfo, other.StageInfo) && this.Retcode == other.Retcode && object.Equals(this.RogueCurrentInfo, other.RogueCurrentInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x000437DC File Offset: 0x000419DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueCurrentInfo_ != null)
			{
				num ^= this.RogueCurrentInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00043876 File Offset: 0x00041A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0004387E File Offset: 0x00041A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00043888 File Offset: 0x00041A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.StageInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CellId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CellId);
			}
			if (this.rogueCurrentInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueCurrentInfo);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00043938 File Offset: 0x00041B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueCurrentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueCurrentInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x000439D8 File Offset: 0x00041BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueEnterCellScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new ChessRogueGameInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
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
			if (other.rogueCurrentInfo_ != null)
			{
				if (this.rogueCurrentInfo_ == null)
				{
					this.RogueCurrentInfo = new ChessRogueCurrentInfo();
				}
				this.RogueCurrentInfo.MergeFrom(other.RogueCurrentInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00043AAC File Offset: 0x00041CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00043AB8 File Offset: 0x00041CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 18U)
					{
						if (this.stageInfo_ == null)
						{
							this.StageInfo = new ChessRogueInfo();
						}
						input.ReadMessage(this.StageInfo);
						continue;
					}
					if (num == 32U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.CellId = input.ReadUInt32();
						continue;
					}
					if (num == 82U)
					{
						if (this.rogueCurrentInfo_ == null)
						{
							this.RogueCurrentInfo = new ChessRogueCurrentInfo();
						}
						input.ReadMessage(this.RogueCurrentInfo);
						continue;
					}
					if (num == 122U)
					{
						if (this.info_ == null)
						{
							this.Info = new ChessRogueGameInfo();
						}
						input.ReadMessage(this.Info);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040009F3 RID: 2547
		private static readonly MessageParser<ChessRogueEnterCellScRsp> _parser = new MessageParser<ChessRogueEnterCellScRsp>(() => new ChessRogueEnterCellScRsp());

		// Token: 0x040009F4 RID: 2548
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009F5 RID: 2549
		public const int InfoFieldNumber = 15;

		// Token: 0x040009F6 RID: 2550
		private ChessRogueGameInfo info_;

		// Token: 0x040009F7 RID: 2551
		public const int CellIdFieldNumber = 6;

		// Token: 0x040009F8 RID: 2552
		private uint cellId_;

		// Token: 0x040009F9 RID: 2553
		public const int StageInfoFieldNumber = 2;

		// Token: 0x040009FA RID: 2554
		private ChessRogueInfo stageInfo_;

		// Token: 0x040009FB RID: 2555
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040009FC RID: 2556
		private uint retcode_;

		// Token: 0x040009FD RID: 2557
		public const int RogueCurrentInfoFieldNumber = 10;

		// Token: 0x040009FE RID: 2558
		private ChessRogueCurrentInfo rogueCurrentInfo_;
	}
}
