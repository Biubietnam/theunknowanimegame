using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000215 RID: 533
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueEnterNextLayerScRsp : IMessage<ChessRogueEnterNextLayerScRsp>, IMessage, IEquatable<ChessRogueEnterNextLayerScRsp>, IDeepCloneable<ChessRogueEnterNextLayerScRsp>, IBufferMessage
	{
		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0004417D File Offset: 0x0004237D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueEnterNextLayerScRsp> Parser
		{
			get
			{
				return ChessRogueEnterNextLayerScRsp._parser;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00044184 File Offset: 0x00042384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueEnterNextLayerScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00044196 File Offset: 0x00042396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueEnterNextLayerScRsp.Descriptor;
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x0004419D File Offset: 0x0004239D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterNextLayerScRsp()
		{
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000441A8 File Offset: 0x000423A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterNextLayerScRsp(ChessRogueEnterNextLayerScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueCurrentInfo_ = ((other.rogueCurrentInfo_ != null) ? other.rogueCurrentInfo_.Clone() : null);
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.boardEventInfo_ = ((other.boardEventInfo_ != null) ? other.boardEventInfo_.Clone() : null);
			this.rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00044248 File Offset: 0x00042448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterNextLayerScRsp Clone()
		{
			return new ChessRogueEnterNextLayerScRsp(this);
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x00044250 File Offset: 0x00042450
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x00044258 File Offset: 0x00042458
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

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x00044261 File Offset: 0x00042461
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x00044269 File Offset: 0x00042469
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

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x00044272 File Offset: 0x00042472
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x0004427A File Offset: 0x0004247A
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

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x00044283 File Offset: 0x00042483
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x0004428B File Offset: 0x0004248B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLayerInitialEventInfo BoardEventInfo
		{
			get
			{
				return this.boardEventInfo_;
			}
			set
			{
				this.boardEventInfo_ = value;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00044294 File Offset: 0x00042494
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0004429C File Offset: 0x0004249C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGameInfo RogueGameInfo
		{
			get
			{
				return this.rogueGameInfo_;
			}
			set
			{
				this.rogueGameInfo_ = value;
			}
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000442A5 File Offset: 0x000424A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueEnterNextLayerScRsp);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000442B4 File Offset: 0x000424B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueEnterNextLayerScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueCurrentInfo, other.RogueCurrentInfo) && object.Equals(this.StageInfo, other.StageInfo) && object.Equals(this.BoardEventInfo, other.BoardEventInfo) && object.Equals(this.RogueGameInfo, other.RogueGameInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00044344 File Offset: 0x00042544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueCurrentInfo_ != null)
			{
				num ^= this.RogueCurrentInfo.GetHashCode();
			}
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this.boardEventInfo_ != null)
			{
				num ^= this.BoardEventInfo.GetHashCode();
			}
			if (this.rogueGameInfo_ != null)
			{
				num ^= this.RogueGameInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x000443DB File Offset: 0x000425DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x000443E3 File Offset: 0x000425E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x000443EC File Offset: 0x000425EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueGameInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueGameInfo);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.StageInfo);
			}
			if (this.rogueCurrentInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueCurrentInfo);
			}
			if (this.boardEventInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.BoardEventInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0004449C File Offset: 0x0004269C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueCurrentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueCurrentInfo);
			}
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this.boardEventInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BoardEventInfo);
			}
			if (this.rogueGameInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGameInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0004453C File Offset: 0x0004273C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueEnterNextLayerScRsp other)
		{
			if (other == null)
			{
				return;
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
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new ChessRogueInfo();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			if (other.boardEventInfo_ != null)
			{
				if (this.boardEventInfo_ == null)
				{
					this.BoardEventInfo = new ChessRogueLayerInitialEventInfo();
				}
				this.BoardEventInfo.MergeFrom(other.BoardEventInfo);
			}
			if (other.rogueGameInfo_ != null)
			{
				if (this.rogueGameInfo_ == null)
				{
					this.RogueGameInfo = new ChessRogueGameInfo();
				}
				this.RogueGameInfo.MergeFrom(other.RogueGameInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00044628 File Offset: 0x00042828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00044634 File Offset: 0x00042834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 26U)
					{
						if (this.rogueGameInfo_ == null)
						{
							this.RogueGameInfo = new ChessRogueGameInfo();
						}
						input.ReadMessage(this.RogueGameInfo);
						continue;
					}
					if (num == 34U)
					{
						if (this.stageInfo_ == null)
						{
							this.StageInfo = new ChessRogueInfo();
						}
						input.ReadMessage(this.StageInfo);
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.rogueCurrentInfo_ == null)
						{
							this.RogueCurrentInfo = new ChessRogueCurrentInfo();
						}
						input.ReadMessage(this.RogueCurrentInfo);
						continue;
					}
					if (num == 114U)
					{
						if (this.boardEventInfo_ == null)
						{
							this.BoardEventInfo = new ChessRogueLayerInitialEventInfo();
						}
						input.ReadMessage(this.BoardEventInfo);
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A0A RID: 2570
		private static readonly MessageParser<ChessRogueEnterNextLayerScRsp> _parser = new MessageParser<ChessRogueEnterNextLayerScRsp>(() => new ChessRogueEnterNextLayerScRsp());

		// Token: 0x04000A0B RID: 2571
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A0C RID: 2572
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04000A0D RID: 2573
		private uint retcode_;

		// Token: 0x04000A0E RID: 2574
		public const int RogueCurrentInfoFieldNumber = 10;

		// Token: 0x04000A0F RID: 2575
		private ChessRogueCurrentInfo rogueCurrentInfo_;

		// Token: 0x04000A10 RID: 2576
		public const int StageInfoFieldNumber = 4;

		// Token: 0x04000A11 RID: 2577
		private ChessRogueInfo stageInfo_;

		// Token: 0x04000A12 RID: 2578
		public const int BoardEventInfoFieldNumber = 14;

		// Token: 0x04000A13 RID: 2579
		private ChessRogueLayerInitialEventInfo boardEventInfo_;

		// Token: 0x04000A14 RID: 2580
		public const int RogueGameInfoFieldNumber = 3;

		// Token: 0x04000A15 RID: 2581
		private ChessRogueGameInfo rogueGameInfo_;
	}
}
