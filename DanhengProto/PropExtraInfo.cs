using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D15 RID: 3349
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PropExtraInfo : IMessage<PropExtraInfo>, IMessage, IEquatable<PropExtraInfo>, IDeepCloneable<PropExtraInfo>, IBufferMessage
	{
		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x0600958B RID: 38283 RVA: 0x0018D6BA File Offset: 0x0018B8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PropExtraInfo> Parser
		{
			get
			{
				return PropExtraInfo._parser;
			}
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x0600958C RID: 38284 RVA: 0x0018D6C1 File Offset: 0x0018B8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PropExtraInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x0600958D RID: 38285 RVA: 0x0018D6D3 File Offset: 0x0018B8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PropExtraInfo.Descriptor;
			}
		}

		// Token: 0x0600958E RID: 38286 RVA: 0x0018D6DA File Offset: 0x0018B8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropExtraInfo()
		{
		}

		// Token: 0x0600958F RID: 38287 RVA: 0x0018D6E4 File Offset: 0x0018B8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropExtraInfo(PropExtraInfo other) : this()
		{
			this.rogueInfo_ = ((other.rogueInfo_ != null) ? other.rogueInfo_.Clone() : null);
			this.aeonInfo_ = ((other.aeonInfo_ != null) ? other.aeonInfo_.Clone() : null);
			this.chessRogueInfo_ = ((other.chessRogueInfo_ != null) ? other.chessRogueInfo_.Clone() : null);
			this.rogueTournDoorInfo_ = ((other.rogueTournDoorInfo_ != null) ? other.rogueTournDoorInfo_.Clone() : null);
			this.rogueTournWorkbenchInfo_ = ((other.rogueTournWorkbenchInfo_ != null) ? other.rogueTournWorkbenchInfo_.Clone() : null);
			this.rogueGambleMachineInfo_ = ((other.rogueGambleMachineInfo_ != null) ? other.rogueGambleMachineInfo_.Clone() : null);
			this.rogueCurseChestInfo_ = ((other.rogueCurseChestInfo_ != null) ? other.rogueCurseChestInfo_.Clone() : null);
			this.rogueMagicDoorInfo_ = ((other.rogueMagicDoorInfo_ != null) ? other.rogueMagicDoorInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009590 RID: 38288 RVA: 0x0018D7E8 File Offset: 0x0018B9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropExtraInfo Clone()
		{
			return new PropExtraInfo(this);
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x06009591 RID: 38289 RVA: 0x0018D7F0 File Offset: 0x0018B9F0
		// (set) Token: 0x06009592 RID: 38290 RVA: 0x0018D7F8 File Offset: 0x0018B9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropRogueInfo RogueInfo
		{
			get
			{
				return this.rogueInfo_;
			}
			set
			{
				this.rogueInfo_ = value;
			}
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x06009593 RID: 38291 RVA: 0x0018D801 File Offset: 0x0018BA01
		// (set) Token: 0x06009594 RID: 38292 RVA: 0x0018D809 File Offset: 0x0018BA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropAeonInfo AeonInfo
		{
			get
			{
				return this.aeonInfo_;
			}
			set
			{
				this.aeonInfo_ = value;
			}
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x06009595 RID: 38293 RVA: 0x0018D812 File Offset: 0x0018BA12
		// (set) Token: 0x06009596 RID: 38294 RVA: 0x0018D81A File Offset: 0x0018BA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropChessRogueInfo ChessRogueInfo
		{
			get
			{
				return this.chessRogueInfo_;
			}
			set
			{
				this.chessRogueInfo_ = value;
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x06009597 RID: 38295 RVA: 0x0018D823 File Offset: 0x0018BA23
		// (set) Token: 0x06009598 RID: 38296 RVA: 0x0018D82B File Offset: 0x0018BA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDoorInfo RogueTournDoorInfo
		{
			get
			{
				return this.rogueTournDoorInfo_;
			}
			set
			{
				this.rogueTournDoorInfo_ = value;
			}
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x06009599 RID: 38297 RVA: 0x0018D834 File Offset: 0x0018BA34
		// (set) Token: 0x0600959A RID: 38298 RVA: 0x0018D83C File Offset: 0x0018BA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournWorkbenchInfo RogueTournWorkbenchInfo
		{
			get
			{
				return this.rogueTournWorkbenchInfo_;
			}
			set
			{
				this.rogueTournWorkbenchInfo_ = value;
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x0600959B RID: 38299 RVA: 0x0018D845 File Offset: 0x0018BA45
		// (set) Token: 0x0600959C RID: 38300 RVA: 0x0018D84D File Offset: 0x0018BA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleMachineInfo RogueGambleMachineInfo
		{
			get
			{
				return this.rogueGambleMachineInfo_;
			}
			set
			{
				this.rogueGambleMachineInfo_ = value;
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x0600959D RID: 38301 RVA: 0x0018D856 File Offset: 0x0018BA56
		// (set) Token: 0x0600959E RID: 38302 RVA: 0x0018D85E File Offset: 0x0018BA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCurseChestInfo RogueCurseChestInfo
		{
			get
			{
				return this.rogueCurseChestInfo_;
			}
			set
			{
				this.rogueCurseChestInfo_ = value;
			}
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x0600959F RID: 38303 RVA: 0x0018D867 File Offset: 0x0018BA67
		// (set) Token: 0x060095A0 RID: 38304 RVA: 0x0018D86F File Offset: 0x0018BA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicDoorInfo RogueMagicDoorInfo
		{
			get
			{
				return this.rogueMagicDoorInfo_;
			}
			set
			{
				this.rogueMagicDoorInfo_ = value;
			}
		}

		// Token: 0x060095A1 RID: 38305 RVA: 0x0018D878 File Offset: 0x0018BA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PropExtraInfo);
		}

		// Token: 0x060095A2 RID: 38306 RVA: 0x0018D888 File Offset: 0x0018BA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PropExtraInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueInfo, other.RogueInfo) && object.Equals(this.AeonInfo, other.AeonInfo) && object.Equals(this.ChessRogueInfo, other.ChessRogueInfo) && object.Equals(this.RogueTournDoorInfo, other.RogueTournDoorInfo) && object.Equals(this.RogueTournWorkbenchInfo, other.RogueTournWorkbenchInfo) && object.Equals(this.RogueGambleMachineInfo, other.RogueGambleMachineInfo) && object.Equals(this.RogueCurseChestInfo, other.RogueCurseChestInfo) && object.Equals(this.RogueMagicDoorInfo, other.RogueMagicDoorInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095A3 RID: 38307 RVA: 0x0018D95C File Offset: 0x0018BB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueInfo_ != null)
			{
				num ^= this.RogueInfo.GetHashCode();
			}
			if (this.aeonInfo_ != null)
			{
				num ^= this.AeonInfo.GetHashCode();
			}
			if (this.chessRogueInfo_ != null)
			{
				num ^= this.ChessRogueInfo.GetHashCode();
			}
			if (this.rogueTournDoorInfo_ != null)
			{
				num ^= this.RogueTournDoorInfo.GetHashCode();
			}
			if (this.rogueTournWorkbenchInfo_ != null)
			{
				num ^= this.RogueTournWorkbenchInfo.GetHashCode();
			}
			if (this.rogueGambleMachineInfo_ != null)
			{
				num ^= this.RogueGambleMachineInfo.GetHashCode();
			}
			if (this.rogueCurseChestInfo_ != null)
			{
				num ^= this.RogueCurseChestInfo.GetHashCode();
			}
			if (this.rogueMagicDoorInfo_ != null)
			{
				num ^= this.RogueMagicDoorInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x0018DA32 File Offset: 0x0018BC32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060095A5 RID: 38309 RVA: 0x0018DA3A File Offset: 0x0018BC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095A6 RID: 38310 RVA: 0x0018DA44 File Offset: 0x0018BC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aeonInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AeonInfo);
			}
			if (this.rogueMagicDoorInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueMagicDoorInfo);
			}
			if (this.rogueTournWorkbenchInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueTournWorkbenchInfo);
			}
			if (this.chessRogueInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ChessRogueInfo);
			}
			if (this.rogueTournDoorInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueTournDoorInfo);
			}
			if (this.rogueCurseChestInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RogueCurseChestInfo);
			}
			if (this.rogueGambleMachineInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueGambleMachineInfo);
			}
			if (this.rogueInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095A7 RID: 38311 RVA: 0x0018DB48 File Offset: 0x0018BD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueInfo);
			}
			if (this.aeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AeonInfo);
			}
			if (this.chessRogueInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChessRogueInfo);
			}
			if (this.rogueTournDoorInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournDoorInfo);
			}
			if (this.rogueTournWorkbenchInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournWorkbenchInfo);
			}
			if (this.rogueGambleMachineInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGambleMachineInfo);
			}
			if (this.rogueCurseChestInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueCurseChestInfo);
			}
			if (this.rogueMagicDoorInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueMagicDoorInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095A8 RID: 38312 RVA: 0x0018DC30 File Offset: 0x0018BE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PropExtraInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueInfo_ != null)
			{
				if (this.rogueInfo_ == null)
				{
					this.RogueInfo = new PropRogueInfo();
				}
				this.RogueInfo.MergeFrom(other.RogueInfo);
			}
			if (other.aeonInfo_ != null)
			{
				if (this.aeonInfo_ == null)
				{
					this.AeonInfo = new PropAeonInfo();
				}
				this.AeonInfo.MergeFrom(other.AeonInfo);
			}
			if (other.chessRogueInfo_ != null)
			{
				if (this.chessRogueInfo_ == null)
				{
					this.ChessRogueInfo = new PropChessRogueInfo();
				}
				this.ChessRogueInfo.MergeFrom(other.ChessRogueInfo);
			}
			if (other.rogueTournDoorInfo_ != null)
			{
				if (this.rogueTournDoorInfo_ == null)
				{
					this.RogueTournDoorInfo = new RogueTournDoorInfo();
				}
				this.RogueTournDoorInfo.MergeFrom(other.RogueTournDoorInfo);
			}
			if (other.rogueTournWorkbenchInfo_ != null)
			{
				if (this.rogueTournWorkbenchInfo_ == null)
				{
					this.RogueTournWorkbenchInfo = new RogueTournWorkbenchInfo();
				}
				this.RogueTournWorkbenchInfo.MergeFrom(other.RogueTournWorkbenchInfo);
			}
			if (other.rogueGambleMachineInfo_ != null)
			{
				if (this.rogueGambleMachineInfo_ == null)
				{
					this.RogueGambleMachineInfo = new RogueGambleMachineInfo();
				}
				this.RogueGambleMachineInfo.MergeFrom(other.RogueGambleMachineInfo);
			}
			if (other.rogueCurseChestInfo_ != null)
			{
				if (this.rogueCurseChestInfo_ == null)
				{
					this.RogueCurseChestInfo = new RogueCurseChestInfo();
				}
				this.RogueCurseChestInfo.MergeFrom(other.RogueCurseChestInfo);
			}
			if (other.rogueMagicDoorInfo_ != null)
			{
				if (this.rogueMagicDoorInfo_ == null)
				{
					this.RogueMagicDoorInfo = new RogueMagicDoorInfo();
				}
				this.RogueMagicDoorInfo.MergeFrom(other.RogueMagicDoorInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060095A9 RID: 38313 RVA: 0x0018DDB8 File Offset: 0x0018BFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095AA RID: 38314 RVA: 0x0018DDC4 File Offset: 0x0018BFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num <= 26U)
					{
						if (num == 18U)
						{
							if (this.aeonInfo_ == null)
							{
								this.AeonInfo = new PropAeonInfo();
							}
							input.ReadMessage(this.AeonInfo);
							continue;
						}
						if (num == 26U)
						{
							if (this.rogueMagicDoorInfo_ == null)
							{
								this.RogueMagicDoorInfo = new RogueMagicDoorInfo();
							}
							input.ReadMessage(this.RogueMagicDoorInfo);
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.rogueTournWorkbenchInfo_ == null)
							{
								this.RogueTournWorkbenchInfo = new RogueTournWorkbenchInfo();
							}
							input.ReadMessage(this.RogueTournWorkbenchInfo);
							continue;
						}
						if (num == 50U)
						{
							if (this.chessRogueInfo_ == null)
							{
								this.ChessRogueInfo = new PropChessRogueInfo();
							}
							input.ReadMessage(this.ChessRogueInfo);
							continue;
						}
					}
				}
				else if (num <= 66U)
				{
					if (num == 58U)
					{
						if (this.rogueTournDoorInfo_ == null)
						{
							this.RogueTournDoorInfo = new RogueTournDoorInfo();
						}
						input.ReadMessage(this.RogueTournDoorInfo);
						continue;
					}
					if (num == 66U)
					{
						if (this.rogueCurseChestInfo_ == null)
						{
							this.RogueCurseChestInfo = new RogueCurseChestInfo();
						}
						input.ReadMessage(this.RogueCurseChestInfo);
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.rogueGambleMachineInfo_ == null)
						{
							this.RogueGambleMachineInfo = new RogueGambleMachineInfo();
						}
						input.ReadMessage(this.RogueGambleMachineInfo);
						continue;
					}
					if (num == 106U)
					{
						if (this.rogueInfo_ == null)
						{
							this.RogueInfo = new PropRogueInfo();
						}
						input.ReadMessage(this.RogueInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040039F0 RID: 14832
		private static readonly MessageParser<PropExtraInfo> _parser = new MessageParser<PropExtraInfo>(() => new PropExtraInfo());

		// Token: 0x040039F1 RID: 14833
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039F2 RID: 14834
		public const int RogueInfoFieldNumber = 13;

		// Token: 0x040039F3 RID: 14835
		private PropRogueInfo rogueInfo_;

		// Token: 0x040039F4 RID: 14836
		public const int AeonInfoFieldNumber = 2;

		// Token: 0x040039F5 RID: 14837
		private PropAeonInfo aeonInfo_;

		// Token: 0x040039F6 RID: 14838
		public const int ChessRogueInfoFieldNumber = 6;

		// Token: 0x040039F7 RID: 14839
		private PropChessRogueInfo chessRogueInfo_;

		// Token: 0x040039F8 RID: 14840
		public const int RogueTournDoorInfoFieldNumber = 7;

		// Token: 0x040039F9 RID: 14841
		private RogueTournDoorInfo rogueTournDoorInfo_;

		// Token: 0x040039FA RID: 14842
		public const int RogueTournWorkbenchInfoFieldNumber = 4;

		// Token: 0x040039FB RID: 14843
		private RogueTournWorkbenchInfo rogueTournWorkbenchInfo_;

		// Token: 0x040039FC RID: 14844
		public const int RogueGambleMachineInfoFieldNumber = 10;

		// Token: 0x040039FD RID: 14845
		private RogueGambleMachineInfo rogueGambleMachineInfo_;

		// Token: 0x040039FE RID: 14846
		public const int RogueCurseChestInfoFieldNumber = 8;

		// Token: 0x040039FF RID: 14847
		private RogueCurseChestInfo rogueCurseChestInfo_;

		// Token: 0x04003A00 RID: 14848
		public const int RogueMagicDoorInfoFieldNumber = 3;

		// Token: 0x04003A01 RID: 14849
		private RogueMagicDoorInfo rogueMagicDoorInfo_;
	}
}
