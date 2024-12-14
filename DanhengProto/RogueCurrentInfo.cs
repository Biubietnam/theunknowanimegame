using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E6B RID: 3691
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCurrentInfo : IMessage<RogueCurrentInfo>, IMessage, IEquatable<RogueCurrentInfo>, IDeepCloneable<RogueCurrentInfo>, IBufferMessage
	{
		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x0600A49A RID: 42138 RVA: 0x001BA4EA File Offset: 0x001B86EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCurrentInfo> Parser
		{
			get
			{
				return RogueCurrentInfo._parser;
			}
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0600A49B RID: 42139 RVA: 0x001BA4F1 File Offset: 0x001B86F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCurrentInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0600A49C RID: 42140 RVA: 0x001BA503 File Offset: 0x001B8703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCurrentInfo.Descriptor;
			}
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x001BA50A File Offset: 0x001B870A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCurrentInfo()
		{
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x001BA514 File Offset: 0x001B8714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCurrentInfo(RogueCurrentInfo other) : this()
		{
			this.gameMiracleInfo_ = ((other.gameMiracleInfo_ != null) ? other.gameMiracleInfo_.Clone() : null);
			this.rogueLineupInfo_ = ((other.rogueLineupInfo_ != null) ? other.rogueLineupInfo_.Clone() : null);
			this.rogueAeonInfo_ = ((other.rogueAeonInfo_ != null) ? other.rogueAeonInfo_.Clone() : null);
			this.pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
			this.rogueBuffInfo_ = ((other.rogueBuffInfo_ != null) ? other.rogueBuffInfo_.Clone() : null);
			this.isExploreWin_ = other.isExploreWin_;
			this.virtualItemInfo_ = ((other.virtualItemInfo_ != null) ? other.virtualItemInfo_.Clone() : null);
			this.moduleInfo_ = ((other.moduleInfo_ != null) ? other.moduleInfo_.Clone() : null);
			this.roomMap_ = ((other.roomMap_ != null) ? other.roomMap_.Clone() : null);
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x001BA630 File Offset: 0x001B8830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCurrentInfo Clone()
		{
			return new RogueCurrentInfo(this);
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x0600A4A0 RID: 42144 RVA: 0x001BA638 File Offset: 0x001B8838
		// (set) Token: 0x0600A4A1 RID: 42145 RVA: 0x001BA640 File Offset: 0x001B8840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameMiracleInfo GameMiracleInfo
		{
			get
			{
				return this.gameMiracleInfo_;
			}
			set
			{
				this.gameMiracleInfo_ = value;
			}
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x0600A4A2 RID: 42146 RVA: 0x001BA649 File Offset: 0x001B8849
		// (set) Token: 0x0600A4A3 RID: 42147 RVA: 0x001BA651 File Offset: 0x001B8851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLineupInfo RogueLineupInfo
		{
			get
			{
				return this.rogueLineupInfo_;
			}
			set
			{
				this.rogueLineupInfo_ = value;
			}
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0600A4A4 RID: 42148 RVA: 0x001BA65A File Offset: 0x001B885A
		// (set) Token: 0x0600A4A5 RID: 42149 RVA: 0x001BA662 File Offset: 0x001B8862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameAeonInfo RogueAeonInfo
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

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0600A4A6 RID: 42150 RVA: 0x001BA66B File Offset: 0x001B886B
		// (set) Token: 0x0600A4A7 RID: 42151 RVA: 0x001BA673 File Offset: 0x001B8873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonPendingAction PendingAction
		{
			get
			{
				return this.pendingAction_;
			}
			set
			{
				this.pendingAction_ = value;
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0600A4A8 RID: 42152 RVA: 0x001BA67C File Offset: 0x001B887C
		// (set) Token: 0x0600A4A9 RID: 42153 RVA: 0x001BA684 File Offset: 0x001B8884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffInfo RogueBuffInfo
		{
			get
			{
				return this.rogueBuffInfo_;
			}
			set
			{
				this.rogueBuffInfo_ = value;
			}
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x0600A4AA RID: 42154 RVA: 0x001BA68D File Offset: 0x001B888D
		// (set) Token: 0x0600A4AB RID: 42155 RVA: 0x001BA695 File Offset: 0x001B8895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsExploreWin
		{
			get
			{
				return this.isExploreWin_;
			}
			set
			{
				this.isExploreWin_ = value;
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x0600A4AC RID: 42156 RVA: 0x001BA69E File Offset: 0x001B889E
		// (set) Token: 0x0600A4AD RID: 42157 RVA: 0x001BA6A6 File Offset: 0x001B88A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueVirtualItem VirtualItemInfo
		{
			get
			{
				return this.virtualItemInfo_;
			}
			set
			{
				this.virtualItemInfo_ = value;
			}
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x0600A4AE RID: 42158 RVA: 0x001BA6AF File Offset: 0x001B88AF
		// (set) Token: 0x0600A4AF RID: 42159 RVA: 0x001BA6B7 File Offset: 0x001B88B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModuleInfo ModuleInfo
		{
			get
			{
				return this.moduleInfo_;
			}
			set
			{
				this.moduleInfo_ = value;
			}
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x0600A4B0 RID: 42160 RVA: 0x001BA6C0 File Offset: 0x001B88C0
		// (set) Token: 0x0600A4B1 RID: 42161 RVA: 0x001BA6C8 File Offset: 0x001B88C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMapInfo RoomMap
		{
			get
			{
				return this.roomMap_;
			}
			set
			{
				this.roomMap_ = value;
			}
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x0600A4B2 RID: 42162 RVA: 0x001BA6D1 File Offset: 0x001B88D1
		// (set) Token: 0x0600A4B3 RID: 42163 RVA: 0x001BA6D9 File Offset: 0x001B88D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x001BA6E2 File Offset: 0x001B88E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCurrentInfo);
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x001BA6F0 File Offset: 0x001B88F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCurrentInfo other)
		{
			return other != null && (other == this || (object.Equals(this.GameMiracleInfo, other.GameMiracleInfo) && object.Equals(this.RogueLineupInfo, other.RogueLineupInfo) && object.Equals(this.RogueAeonInfo, other.RogueAeonInfo) && object.Equals(this.PendingAction, other.PendingAction) && object.Equals(this.RogueBuffInfo, other.RogueBuffInfo) && this.IsExploreWin == other.IsExploreWin && object.Equals(this.VirtualItemInfo, other.VirtualItemInfo) && object.Equals(this.ModuleInfo, other.ModuleInfo) && object.Equals(this.RoomMap, other.RoomMap) && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x001BA7E4 File Offset: 0x001B89E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gameMiracleInfo_ != null)
			{
				num ^= this.GameMiracleInfo.GetHashCode();
			}
			if (this.rogueLineupInfo_ != null)
			{
				num ^= this.RogueLineupInfo.GetHashCode();
			}
			if (this.rogueAeonInfo_ != null)
			{
				num ^= this.RogueAeonInfo.GetHashCode();
			}
			if (this.pendingAction_ != null)
			{
				num ^= this.PendingAction.GetHashCode();
			}
			if (this.rogueBuffInfo_ != null)
			{
				num ^= this.RogueBuffInfo.GetHashCode();
			}
			if (this.IsExploreWin)
			{
				num ^= this.IsExploreWin.GetHashCode();
			}
			if (this.virtualItemInfo_ != null)
			{
				num ^= this.VirtualItemInfo.GetHashCode();
			}
			if (this.moduleInfo_ != null)
			{
				num ^= this.ModuleInfo.GetHashCode();
			}
			if (this.roomMap_ != null)
			{
				num ^= this.RoomMap.GetHashCode();
			}
			if (this.Status != RogueStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x001BA8F2 File Offset: 0x001B8AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x001BA8FA File Offset: 0x001B8AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4B9 RID: 42169 RVA: 0x001BA904 File Offset: 0x001B8B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsExploreWin)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsExploreWin);
			}
			if (this.pendingAction_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PendingAction);
			}
			if (this.virtualItemInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.VirtualItemInfo);
			}
			if (this.roomMap_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RoomMap);
			}
			if (this.rogueLineupInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueLineupInfo);
			}
			if (this.rogueBuffInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RogueBuffInfo);
			}
			if (this.rogueAeonInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RogueAeonInfo);
			}
			if (this.Status != RogueStatus.None)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Status);
			}
			if (this.moduleInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ModuleInfo);
			}
			if (this.gameMiracleInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.GameMiracleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4BA RID: 42170 RVA: 0x001BAA3C File Offset: 0x001B8C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gameMiracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameMiracleInfo);
			}
			if (this.rogueLineupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueLineupInfo);
			}
			if (this.rogueAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAeonInfo);
			}
			if (this.pendingAction_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PendingAction);
			}
			if (this.rogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuffInfo);
			}
			if (this.IsExploreWin)
			{
				num += 2;
			}
			if (this.virtualItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VirtualItemInfo);
			}
			if (this.moduleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ModuleInfo);
			}
			if (this.roomMap_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoomMap);
			}
			if (this.Status != RogueStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A4BB RID: 42171 RVA: 0x001BAB48 File Offset: 0x001B8D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCurrentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gameMiracleInfo_ != null)
			{
				if (this.gameMiracleInfo_ == null)
				{
					this.GameMiracleInfo = new GameMiracleInfo();
				}
				this.GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
			}
			if (other.rogueLineupInfo_ != null)
			{
				if (this.rogueLineupInfo_ == null)
				{
					this.RogueLineupInfo = new RogueLineupInfo();
				}
				this.RogueLineupInfo.MergeFrom(other.RogueLineupInfo);
			}
			if (other.rogueAeonInfo_ != null)
			{
				if (this.rogueAeonInfo_ == null)
				{
					this.RogueAeonInfo = new GameAeonInfo();
				}
				this.RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
			}
			if (other.pendingAction_ != null)
			{
				if (this.pendingAction_ == null)
				{
					this.PendingAction = new RogueCommonPendingAction();
				}
				this.PendingAction.MergeFrom(other.PendingAction);
			}
			if (other.rogueBuffInfo_ != null)
			{
				if (this.rogueBuffInfo_ == null)
				{
					this.RogueBuffInfo = new RogueBuffInfo();
				}
				this.RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
			}
			if (other.IsExploreWin)
			{
				this.IsExploreWin = other.IsExploreWin;
			}
			if (other.virtualItemInfo_ != null)
			{
				if (this.virtualItemInfo_ == null)
				{
					this.VirtualItemInfo = new RogueVirtualItem();
				}
				this.VirtualItemInfo.MergeFrom(other.VirtualItemInfo);
			}
			if (other.moduleInfo_ != null)
			{
				if (this.moduleInfo_ == null)
				{
					this.ModuleInfo = new RogueModuleInfo();
				}
				this.ModuleInfo.MergeFrom(other.ModuleInfo);
			}
			if (other.roomMap_ != null)
			{
				if (this.roomMap_ == null)
				{
					this.RoomMap = new RogueMapInfo();
				}
				this.RoomMap.MergeFrom(other.RoomMap);
			}
			if (other.Status != RogueStatus.None)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A4BC RID: 42172 RVA: 0x001BACF8 File Offset: 0x001B8EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4BD RID: 42173 RVA: 0x001BAD04 File Offset: 0x001B8F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num <= 34U)
					{
						if (num == 8U)
						{
							this.IsExploreWin = input.ReadBool();
							continue;
						}
						if (num == 34U)
						{
							if (this.pendingAction_ == null)
							{
								this.PendingAction = new RogueCommonPendingAction();
							}
							input.ReadMessage(this.PendingAction);
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							if (this.virtualItemInfo_ == null)
							{
								this.VirtualItemInfo = new RogueVirtualItem();
							}
							input.ReadMessage(this.VirtualItemInfo);
							continue;
						}
						if (num == 50U)
						{
							if (this.roomMap_ == null)
							{
								this.RoomMap = new RogueMapInfo();
							}
							input.ReadMessage(this.RoomMap);
							continue;
						}
						if (num == 58U)
						{
							if (this.rogueLineupInfo_ == null)
							{
								this.RogueLineupInfo = new RogueLineupInfo();
							}
							input.ReadMessage(this.RogueLineupInfo);
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 74U)
					{
						if (this.rogueBuffInfo_ == null)
						{
							this.RogueBuffInfo = new RogueBuffInfo();
						}
						input.ReadMessage(this.RogueBuffInfo);
						continue;
					}
					if (num == 90U)
					{
						if (this.rogueAeonInfo_ == null)
						{
							this.RogueAeonInfo = new GameAeonInfo();
						}
						input.ReadMessage(this.RogueAeonInfo);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Status = (RogueStatus)input.ReadEnum();
						continue;
					}
					if (num == 106U)
					{
						if (this.moduleInfo_ == null)
						{
							this.ModuleInfo = new RogueModuleInfo();
						}
						input.ReadMessage(this.ModuleInfo);
						continue;
					}
					if (num == 114U)
					{
						if (this.gameMiracleInfo_ == null)
						{
							this.GameMiracleInfo = new GameMiracleInfo();
						}
						input.ReadMessage(this.GameMiracleInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400433E RID: 17214
		private static readonly MessageParser<RogueCurrentInfo> _parser = new MessageParser<RogueCurrentInfo>(() => new RogueCurrentInfo());

		// Token: 0x0400433F RID: 17215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004340 RID: 17216
		public const int GameMiracleInfoFieldNumber = 14;

		// Token: 0x04004341 RID: 17217
		private GameMiracleInfo gameMiracleInfo_;

		// Token: 0x04004342 RID: 17218
		public const int RogueLineupInfoFieldNumber = 7;

		// Token: 0x04004343 RID: 17219
		private RogueLineupInfo rogueLineupInfo_;

		// Token: 0x04004344 RID: 17220
		public const int RogueAeonInfoFieldNumber = 11;

		// Token: 0x04004345 RID: 17221
		private GameAeonInfo rogueAeonInfo_;

		// Token: 0x04004346 RID: 17222
		public const int PendingActionFieldNumber = 4;

		// Token: 0x04004347 RID: 17223
		private RogueCommonPendingAction pendingAction_;

		// Token: 0x04004348 RID: 17224
		public const int RogueBuffInfoFieldNumber = 9;

		// Token: 0x04004349 RID: 17225
		private RogueBuffInfo rogueBuffInfo_;

		// Token: 0x0400434A RID: 17226
		public const int IsExploreWinFieldNumber = 1;

		// Token: 0x0400434B RID: 17227
		private bool isExploreWin_;

		// Token: 0x0400434C RID: 17228
		public const int VirtualItemInfoFieldNumber = 5;

		// Token: 0x0400434D RID: 17229
		private RogueVirtualItem virtualItemInfo_;

		// Token: 0x0400434E RID: 17230
		public const int ModuleInfoFieldNumber = 13;

		// Token: 0x0400434F RID: 17231
		private RogueModuleInfo moduleInfo_;

		// Token: 0x04004350 RID: 17232
		public const int RoomMapFieldNumber = 6;

		// Token: 0x04004351 RID: 17233
		private RogueMapInfo roomMap_;

		// Token: 0x04004352 RID: 17234
		public const int StatusFieldNumber = 12;

		// Token: 0x04004353 RID: 17235
		private RogueStatus status_;
	}
}
