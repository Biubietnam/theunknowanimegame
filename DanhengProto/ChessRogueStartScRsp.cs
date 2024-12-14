using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002A1 RID: 673
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueStartScRsp : IMessage<ChessRogueStartScRsp>, IMessage, IEquatable<ChessRogueStartScRsp>, IDeepCloneable<ChessRogueStartScRsp>, IBufferMessage
	{
		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00055F7F File Offset: 0x0005417F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueStartScRsp> Parser
		{
			get
			{
				return ChessRogueStartScRsp._parser;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x00055F86 File Offset: 0x00054186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueStartScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00055F98 File Offset: 0x00054198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueStartScRsp.Descriptor;
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00055F9F File Offset: 0x0005419F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueStartScRsp()
		{
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00055FA8 File Offset: 0x000541A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueStartScRsp(ChessRogueStartScRsp other) : this()
		{
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.boardEventInfo_ = ((other.boardEventInfo_ != null) ? other.boardEventInfo_.Clone() : null);
			this.rogueCurrentInfo_ = ((other.rogueCurrentInfo_ != null) ? other.rogueCurrentInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00056080 File Offset: 0x00054280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueStartScRsp Clone()
		{
			return new ChessRogueStartScRsp(this);
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x00056088 File Offset: 0x00054288
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x00056090 File Offset: 0x00054290
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

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x00056099 File Offset: 0x00054299
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x000560A1 File Offset: 0x000542A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x000560AA File Offset: 0x000542AA
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x000560B2 File Offset: 0x000542B2
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

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x000560BB File Offset: 0x000542BB
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x000560C3 File Offset: 0x000542C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x000560CC File Offset: 0x000542CC
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x000560D4 File Offset: 0x000542D4
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

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x000560DD File Offset: 0x000542DD
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x000560E5 File Offset: 0x000542E5
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

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x000560EE File Offset: 0x000542EE
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x000560F6 File Offset: 0x000542F6
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

		// Token: 0x06001E18 RID: 7704 RVA: 0x000560FF File Offset: 0x000542FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueStartScRsp);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00056110 File Offset: 0x00054310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueStartScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.StageInfo, other.StageInfo) && object.Equals(this.Scene, other.Scene) && this.Retcode == other.Retcode && object.Equals(this.Lineup, other.Lineup) && object.Equals(this.Info, other.Info) && object.Equals(this.BoardEventInfo, other.BoardEventInfo) && object.Equals(this.RogueCurrentInfo, other.RogueCurrentInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x000561C8 File Offset: 0x000543C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.boardEventInfo_ != null)
			{
				num ^= this.BoardEventInfo.GetHashCode();
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

		// Token: 0x06001E1B RID: 7707 RVA: 0x0005628B File Offset: 0x0005448B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00056293 File Offset: 0x00054493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x0005629C File Offset: 0x0005449C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueCurrentInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueCurrentInfo);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Lineup);
			}
			if (this.boardEventInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BoardEventInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.StageInfo);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Info);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00056384 File Offset: 0x00054584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.boardEventInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BoardEventInfo);
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

		// Token: 0x06001E1F RID: 7711 RVA: 0x00056454 File Offset: 0x00054654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueStartScRsp other)
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
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new ChessRogueGameInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.boardEventInfo_ != null)
			{
				if (this.boardEventInfo_ == null)
				{
					this.BoardEventInfo = new ChessRogueLayerInitialEventInfo();
				}
				this.BoardEventInfo.MergeFrom(other.BoardEventInfo);
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

		// Token: 0x06001E20 RID: 7712 RVA: 0x00056598 File Offset: 0x00054798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x000565A4 File Offset: 0x000547A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
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
						if (this.lineup_ == null)
						{
							this.Lineup = new LineupInfo();
						}
						input.ReadMessage(this.Lineup);
						continue;
					}
					if (num == 34U)
					{
						if (this.boardEventInfo_ == null)
						{
							this.BoardEventInfo = new ChessRogueLayerInitialEventInfo();
						}
						input.ReadMessage(this.BoardEventInfo);
						continue;
					}
				}
				else if (num <= 74U)
				{
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
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
					if (num == 114U)
					{
						if (this.info_ == null)
						{
							this.Info = new ChessRogueGameInfo();
						}
						input.ReadMessage(this.Info);
						continue;
					}
					if (num == 122U)
					{
						if (this.scene_ == null)
						{
							this.Scene = new SceneInfo();
						}
						input.ReadMessage(this.Scene);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000C83 RID: 3203
		private static readonly MessageParser<ChessRogueStartScRsp> _parser = new MessageParser<ChessRogueStartScRsp>(() => new ChessRogueStartScRsp());

		// Token: 0x04000C84 RID: 3204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C85 RID: 3205
		public const int StageInfoFieldNumber = 9;

		// Token: 0x04000C86 RID: 3206
		private ChessRogueInfo stageInfo_;

		// Token: 0x04000C87 RID: 3207
		public const int SceneFieldNumber = 15;

		// Token: 0x04000C88 RID: 3208
		private SceneInfo scene_;

		// Token: 0x04000C89 RID: 3209
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04000C8A RID: 3210
		private uint retcode_;

		// Token: 0x04000C8B RID: 3211
		public const int LineupFieldNumber = 3;

		// Token: 0x04000C8C RID: 3212
		private LineupInfo lineup_;

		// Token: 0x04000C8D RID: 3213
		public const int InfoFieldNumber = 14;

		// Token: 0x04000C8E RID: 3214
		private ChessRogueGameInfo info_;

		// Token: 0x04000C8F RID: 3215
		public const int BoardEventInfoFieldNumber = 4;

		// Token: 0x04000C90 RID: 3216
		private ChessRogueLayerInitialEventInfo boardEventInfo_;

		// Token: 0x04000C91 RID: 3217
		public const int RogueCurrentInfoFieldNumber = 2;

		// Token: 0x04000C92 RID: 3218
		private ChessRogueCurrentInfo rogueCurrentInfo_;
	}
}
