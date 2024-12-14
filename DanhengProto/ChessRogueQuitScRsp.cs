using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000285 RID: 645
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQuitScRsp : IMessage<ChessRogueQuitScRsp>, IMessage, IEquatable<ChessRogueQuitScRsp>, IDeepCloneable<ChessRogueQuitScRsp>, IBufferMessage
	{
		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x000524EB File Offset: 0x000506EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQuitScRsp> Parser
		{
			get
			{
				return ChessRogueQuitScRsp._parser;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x000524F2 File Offset: 0x000506F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQuitScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00052504 File Offset: 0x00050704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQuitScRsp.Descriptor;
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0005250B File Offset: 0x0005070B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQuitScRsp()
		{
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00052514 File Offset: 0x00050714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQuitScRsp(ChessRogueQuitScRsp other) : this()
		{
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.rogueAeonInfo_ = ((other.rogueAeonInfo_ != null) ? other.rogueAeonInfo_.Clone() : null);
			this.finishInfo_ = ((other.finishInfo_ != null) ? other.finishInfo_.Clone() : null);
			this.queryInfo_ = ((other.queryInfo_ != null) ? other.queryInfo_.Clone() : null);
			this.rogueCurrentInfo_ = ((other.rogueCurrentInfo_ != null) ? other.rogueCurrentInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00052624 File Offset: 0x00050824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQuitScRsp Clone()
		{
			return new ChessRogueQuitScRsp(this);
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0005262C File Offset: 0x0005082C
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x00052634 File Offset: 0x00050834
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

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0005263D File Offset: 0x0005083D
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00052645 File Offset: 0x00050845
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

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0005264E File Offset: 0x0005084E
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x00052656 File Offset: 0x00050856
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

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0005265F File Offset: 0x0005085F
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x00052667 File Offset: 0x00050867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x00052670 File Offset: 0x00050870
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x00052678 File Offset: 0x00050878
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

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x00052681 File Offset: 0x00050881
		// (set) Token: 0x06001CC1 RID: 7361 RVA: 0x00052689 File Offset: 0x00050889
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

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x00052692 File Offset: 0x00050892
		// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x0005269A File Offset: 0x0005089A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueFinishInfo FinishInfo
		{
			get
			{
				return this.finishInfo_;
			}
			set
			{
				this.finishInfo_ = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x000526A3 File Offset: 0x000508A3
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x000526AB File Offset: 0x000508AB
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

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x000526B4 File Offset: 0x000508B4
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x000526BC File Offset: 0x000508BC
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

		// Token: 0x06001CC8 RID: 7368 RVA: 0x000526C5 File Offset: 0x000508C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQuitScRsp);
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x000526D4 File Offset: 0x000508D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQuitScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.StageInfo, other.StageInfo) && object.Equals(this.Info, other.Info) && object.Equals(this.RogueGetInfo, other.RogueGetInfo) && object.Equals(this.LevelInfo, other.LevelInfo) && this.Retcode == other.Retcode && object.Equals(this.RogueAeonInfo, other.RogueAeonInfo) && object.Equals(this.FinishInfo, other.FinishInfo) && object.Equals(this.QueryInfo, other.QueryInfo) && object.Equals(this.RogueCurrentInfo, other.RogueCurrentInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x000527B8 File Offset: 0x000509B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.rogueGetInfo_ != null)
			{
				num ^= this.RogueGetInfo.GetHashCode();
			}
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueAeonInfo_ != null)
			{
				num ^= this.RogueAeonInfo.GetHashCode();
			}
			if (this.finishInfo_ != null)
			{
				num ^= this.FinishInfo.GetHashCode();
			}
			if (this.queryInfo_ != null)
			{
				num ^= this.QueryInfo.GetHashCode();
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

		// Token: 0x06001CCB RID: 7371 RVA: 0x000528A7 File Offset: 0x00050AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x000528AF File Offset: 0x00050AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x000528B8 File Offset: 0x00050AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueCurrentInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueCurrentInfo);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.StageInfo);
			}
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.LevelInfo);
			}
			if (this.rogueGetInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueGetInfo);
			}
			if (this.rogueAeonInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueAeonInfo);
			}
			if (this.finishInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.FinishInfo);
			}
			if (this.queryInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.QueryInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000529D8 File Offset: 0x00050BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.rogueGetInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGetInfo);
			}
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAeonInfo);
			}
			if (this.finishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FinishInfo);
			}
			if (this.queryInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QueryInfo);
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

		// Token: 0x06001CCF RID: 7375 RVA: 0x00052AD8 File Offset: 0x00050CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQuitScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new ChessRogueInfo();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new ChessRogueGameInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.rogueGetInfo_ != null)
			{
				if (this.rogueGetInfo_ == null)
				{
					this.RogueGetInfo = new ChessRogueGetInfo();
				}
				this.RogueGetInfo.MergeFrom(other.RogueGetInfo);
			}
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new ChessRogueLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
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
			if (other.finishInfo_ != null)
			{
				if (this.finishInfo_ == null)
				{
					this.FinishInfo = new ChessRogueFinishInfo();
				}
				this.FinishInfo.MergeFrom(other.FinishInfo);
			}
			if (other.queryInfo_ != null)
			{
				if (this.queryInfo_ == null)
				{
					this.QueryInfo = new ChessRogueQueryInfo();
				}
				this.QueryInfo.MergeFrom(other.QueryInfo);
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

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00052C74 File Offset: 0x00050E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00052C80 File Offset: 0x00050E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 26U)
					{
						if (num == 18U)
						{
							if (this.rogueCurrentInfo_ == null)
							{
								this.RogueCurrentInfo = new ChessRogueCurrentInfo();
							}
							input.ReadMessage(this.RogueCurrentInfo);
							continue;
						}
						if (num == 26U)
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
						if (num == 34U)
						{
							if (this.levelInfo_ == null)
							{
								this.LevelInfo = new ChessRogueLevelInfo();
							}
							input.ReadMessage(this.LevelInfo);
							continue;
						}
						if (num == 42U)
						{
							if (this.rogueGetInfo_ == null)
							{
								this.RogueGetInfo = new ChessRogueGetInfo();
							}
							input.ReadMessage(this.RogueGetInfo);
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						if (this.rogueAeonInfo_ == null)
						{
							this.RogueAeonInfo = new ChessRogueAeonInfo();
						}
						input.ReadMessage(this.RogueAeonInfo);
						continue;
					}
					if (num == 58U)
					{
						if (this.finishInfo_ == null)
						{
							this.FinishInfo = new ChessRogueFinishInfo();
						}
						input.ReadMessage(this.FinishInfo);
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.queryInfo_ == null)
						{
							this.QueryInfo = new ChessRogueQueryInfo();
						}
						input.ReadMessage(this.QueryInfo);
						continue;
					}
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
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

		// Token: 0x04000C03 RID: 3075
		private static readonly MessageParser<ChessRogueQuitScRsp> _parser = new MessageParser<ChessRogueQuitScRsp>(() => new ChessRogueQuitScRsp());

		// Token: 0x04000C04 RID: 3076
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C05 RID: 3077
		public const int StageInfoFieldNumber = 3;

		// Token: 0x04000C06 RID: 3078
		private ChessRogueInfo stageInfo_;

		// Token: 0x04000C07 RID: 3079
		public const int InfoFieldNumber = 13;

		// Token: 0x04000C08 RID: 3080
		private ChessRogueGameInfo info_;

		// Token: 0x04000C09 RID: 3081
		public const int RogueGetInfoFieldNumber = 5;

		// Token: 0x04000C0A RID: 3082
		private ChessRogueGetInfo rogueGetInfo_;

		// Token: 0x04000C0B RID: 3083
		public const int LevelInfoFieldNumber = 4;

		// Token: 0x04000C0C RID: 3084
		private ChessRogueLevelInfo levelInfo_;

		// Token: 0x04000C0D RID: 3085
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04000C0E RID: 3086
		private uint retcode_;

		// Token: 0x04000C0F RID: 3087
		public const int RogueAeonInfoFieldNumber = 6;

		// Token: 0x04000C10 RID: 3088
		private ChessRogueAeonInfo rogueAeonInfo_;

		// Token: 0x04000C11 RID: 3089
		public const int FinishInfoFieldNumber = 7;

		// Token: 0x04000C12 RID: 3090
		private ChessRogueFinishInfo finishInfo_;

		// Token: 0x04000C13 RID: 3091
		public const int QueryInfoFieldNumber = 11;

		// Token: 0x04000C14 RID: 3092
		private ChessRogueQueryInfo queryInfo_;

		// Token: 0x04000C15 RID: 3093
		public const int RogueCurrentInfoFieldNumber = 2;

		// Token: 0x04000C16 RID: 3094
		private ChessRogueCurrentInfo rogueCurrentInfo_;
	}
}
