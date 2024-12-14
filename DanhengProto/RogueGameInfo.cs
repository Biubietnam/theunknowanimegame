using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E91 RID: 3729
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueGameInfo : IMessage<RogueGameInfo>, IMessage, IEquatable<RogueGameInfo>, IDeepCloneable<RogueGameInfo>, IBufferMessage
	{
		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x0600A690 RID: 42640 RVA: 0x001C08EF File Offset: 0x001BEAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGameInfo> Parser
		{
			get
			{
				return RogueGameInfo._parser;
			}
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x0600A691 RID: 42641 RVA: 0x001C08F6 File Offset: 0x001BEAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueGameInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x0600A692 RID: 42642 RVA: 0x001C0908 File Offset: 0x001BEB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGameInfo.Descriptor;
			}
		}

		// Token: 0x0600A693 RID: 42643 RVA: 0x001C090F File Offset: 0x001BEB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGameInfo()
		{
		}

		// Token: 0x0600A694 RID: 42644 RVA: 0x001C0918 File Offset: 0x001BEB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGameInfo(RogueGameInfo other) : this()
		{
			this.rogueBuffInfo_ = ((other.rogueBuffInfo_ != null) ? other.rogueBuffInfo_.Clone() : null);
			this.gameMiracleInfo_ = ((other.gameMiracleInfo_ != null) ? other.gameMiracleInfo_.Clone() : null);
			this.gameItemValue_ = ((other.gameItemValue_ != null) ? other.gameItemValue_.Clone() : null);
			this.rogueAeonInfo_ = ((other.rogueAeonInfo_ != null) ? other.rogueAeonInfo_.Clone() : null);
			this.rogueDifficultyInfo_ = ((other.rogueDifficultyInfo_ != null) ? other.rogueDifficultyInfo_.Clone() : null);
			this.cHMELADEMMM_ = ((other.cHMELADEMMM_ != null) ? other.cHMELADEMMM_.Clone() : null);
			this.mOGLLMLEMIP_ = ((other.mOGLLMLEMIP_ != null) ? other.mOGLLMLEMIP_.Clone() : null);
			this.rogueLineupInfo_ = ((other.rogueLineupInfo_ != null) ? other.rogueLineupInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A695 RID: 42645 RVA: 0x001C0A1C File Offset: 0x001BEC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGameInfo Clone()
		{
			return new RogueGameInfo(this);
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x0600A696 RID: 42646 RVA: 0x001C0A24 File Offset: 0x001BEC24
		// (set) Token: 0x0600A697 RID: 42647 RVA: 0x001C0A2C File Offset: 0x001BEC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffInfo RogueBuffInfo
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

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x0600A698 RID: 42648 RVA: 0x001C0A35 File Offset: 0x001BEC35
		// (set) Token: 0x0600A699 RID: 42649 RVA: 0x001C0A3D File Offset: 0x001BEC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracleInfo GameMiracleInfo
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

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x0600A69A RID: 42650 RVA: 0x001C0A46 File Offset: 0x001BEC46
		// (set) Token: 0x0600A69B RID: 42651 RVA: 0x001C0A4E File Offset: 0x001BEC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGameItemValue GameItemValue
		{
			get
			{
				return this.gameItemValue_;
			}
			set
			{
				this.gameItemValue_ = value;
			}
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x0600A69C RID: 42652 RVA: 0x001C0A57 File Offset: 0x001BEC57
		// (set) Token: 0x0600A69D RID: 42653 RVA: 0x001C0A5F File Offset: 0x001BEC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGameAeonInfo RogueAeonInfo
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

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x0600A69E RID: 42654 RVA: 0x001C0A68 File Offset: 0x001BEC68
		// (set) Token: 0x0600A69F RID: 42655 RVA: 0x001C0A70 File Offset: 0x001BEC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDifficultyLevelInfo RogueDifficultyInfo
		{
			get
			{
				return this.rogueDifficultyInfo_;
			}
			set
			{
				this.rogueDifficultyInfo_ = value;
			}
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x0600A6A0 RID: 42656 RVA: 0x001C0A79 File Offset: 0x001BEC79
		// (set) Token: 0x0600A6A1 RID: 42657 RVA: 0x001C0A81 File Offset: 0x001BEC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaInfo CHMELADEMMM
		{
			get
			{
				return this.cHMELADEMMM_;
			}
			set
			{
				this.cHMELADEMMM_ = value;
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x0600A6A2 RID: 42658 RVA: 0x001C0A8A File Offset: 0x001BEC8A
		// (set) Token: 0x0600A6A3 RID: 42659 RVA: 0x001C0A92 File Offset: 0x001BEC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KeywordUnlockValue MOGLLMLEMIP
		{
			get
			{
				return this.mOGLLMLEMIP_;
			}
			set
			{
				this.mOGLLMLEMIP_ = value;
			}
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x0600A6A4 RID: 42660 RVA: 0x001C0A9B File Offset: 0x001BEC9B
		// (set) Token: 0x0600A6A5 RID: 42661 RVA: 0x001C0AA3 File Offset: 0x001BECA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLineupInfo RogueLineupInfo
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

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x001C0AAC File Offset: 0x001BECAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGameInfo);
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x001C0ABC File Offset: 0x001BECBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGameInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueBuffInfo, other.RogueBuffInfo) && object.Equals(this.GameMiracleInfo, other.GameMiracleInfo) && object.Equals(this.GameItemValue, other.GameItemValue) && object.Equals(this.RogueAeonInfo, other.RogueAeonInfo) && object.Equals(this.RogueDifficultyInfo, other.RogueDifficultyInfo) && object.Equals(this.CHMELADEMMM, other.CHMELADEMMM) && object.Equals(this.MOGLLMLEMIP, other.MOGLLMLEMIP) && object.Equals(this.RogueLineupInfo, other.RogueLineupInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x001C0B90 File Offset: 0x001BED90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueBuffInfo_ != null)
			{
				num ^= this.RogueBuffInfo.GetHashCode();
			}
			if (this.gameMiracleInfo_ != null)
			{
				num ^= this.GameMiracleInfo.GetHashCode();
			}
			if (this.gameItemValue_ != null)
			{
				num ^= this.GameItemValue.GetHashCode();
			}
			if (this.rogueAeonInfo_ != null)
			{
				num ^= this.RogueAeonInfo.GetHashCode();
			}
			if (this.rogueDifficultyInfo_ != null)
			{
				num ^= this.RogueDifficultyInfo.GetHashCode();
			}
			if (this.cHMELADEMMM_ != null)
			{
				num ^= this.CHMELADEMMM.GetHashCode();
			}
			if (this.mOGLLMLEMIP_ != null)
			{
				num ^= this.MOGLLMLEMIP.GetHashCode();
			}
			if (this.rogueLineupInfo_ != null)
			{
				num ^= this.RogueLineupInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x001C0C66 File Offset: 0x001BEE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x001C0C6E File Offset: 0x001BEE6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x001C0C78 File Offset: 0x001BEE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gameItemValue_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameItemValue);
			}
			if (this.rogueAeonInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueAeonInfo);
			}
			if (this.mOGLLMLEMIP_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.MOGLLMLEMIP);
			}
			if (this.rogueLineupInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RogueLineupInfo);
			}
			if (this.rogueBuffInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RogueBuffInfo);
			}
			if (this.gameMiracleInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.GameMiracleInfo);
			}
			if (this.rogueDifficultyInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueDifficultyInfo);
			}
			if (this.cHMELADEMMM_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.CHMELADEMMM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6AC RID: 42668 RVA: 0x001C0D7C File Offset: 0x001BEF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuffInfo);
			}
			if (this.gameMiracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameMiracleInfo);
			}
			if (this.gameItemValue_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameItemValue);
			}
			if (this.rogueAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAeonInfo);
			}
			if (this.rogueDifficultyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueDifficultyInfo);
			}
			if (this.cHMELADEMMM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CHMELADEMMM);
			}
			if (this.mOGLLMLEMIP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MOGLLMLEMIP);
			}
			if (this.rogueLineupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueLineupInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x001C0E64 File Offset: 0x001BF064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGameInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueBuffInfo_ != null)
			{
				if (this.rogueBuffInfo_ == null)
				{
					this.RogueBuffInfo = new ChessRogueBuffInfo();
				}
				this.RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
			}
			if (other.gameMiracleInfo_ != null)
			{
				if (this.gameMiracleInfo_ == null)
				{
					this.GameMiracleInfo = new ChessRogueMiracleInfo();
				}
				this.GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
			}
			if (other.gameItemValue_ != null)
			{
				if (this.gameItemValue_ == null)
				{
					this.GameItemValue = new RogueGameItemValue();
				}
				this.GameItemValue.MergeFrom(other.GameItemValue);
			}
			if (other.rogueAeonInfo_ != null)
			{
				if (this.rogueAeonInfo_ == null)
				{
					this.RogueAeonInfo = new ChessRogueGameAeonInfo();
				}
				this.RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
			}
			if (other.rogueDifficultyInfo_ != null)
			{
				if (this.rogueDifficultyInfo_ == null)
				{
					this.RogueDifficultyInfo = new RogueDifficultyLevelInfo();
				}
				this.RogueDifficultyInfo.MergeFrom(other.RogueDifficultyInfo);
			}
			if (other.cHMELADEMMM_ != null)
			{
				if (this.cHMELADEMMM_ == null)
				{
					this.CHMELADEMMM = new RogueTournFormulaInfo();
				}
				this.CHMELADEMMM.MergeFrom(other.CHMELADEMMM);
			}
			if (other.mOGLLMLEMIP_ != null)
			{
				if (this.mOGLLMLEMIP_ == null)
				{
					this.MOGLLMLEMIP = new KeywordUnlockValue();
				}
				this.MOGLLMLEMIP.MergeFrom(other.MOGLLMLEMIP);
			}
			if (other.rogueLineupInfo_ != null)
			{
				if (this.rogueLineupInfo_ == null)
				{
					this.RogueLineupInfo = new RogueTournLineupInfo();
				}
				this.RogueLineupInfo.MergeFrom(other.RogueLineupInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A6AE RID: 42670 RVA: 0x001C0FEC File Offset: 0x001BF1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6AF RID: 42671 RVA: 0x001C0FF8 File Offset: 0x001BF1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 66U)
				{
					if (num <= 34U)
					{
						if (num == 10U)
						{
							if (this.gameItemValue_ == null)
							{
								this.GameItemValue = new RogueGameItemValue();
							}
							input.ReadMessage(this.GameItemValue);
							continue;
						}
						if (num == 34U)
						{
							if (this.rogueAeonInfo_ == null)
							{
								this.RogueAeonInfo = new ChessRogueGameAeonInfo();
							}
							input.ReadMessage(this.RogueAeonInfo);
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							if (this.mOGLLMLEMIP_ == null)
							{
								this.MOGLLMLEMIP = new KeywordUnlockValue();
							}
							input.ReadMessage(this.MOGLLMLEMIP);
							continue;
						}
						if (num == 66U)
						{
							if (this.rogueLineupInfo_ == null)
							{
								this.RogueLineupInfo = new RogueTournLineupInfo();
							}
							input.ReadMessage(this.RogueLineupInfo);
							continue;
						}
					}
				}
				else if (num <= 106U)
				{
					if (num == 74U)
					{
						if (this.rogueBuffInfo_ == null)
						{
							this.RogueBuffInfo = new ChessRogueBuffInfo();
						}
						input.ReadMessage(this.RogueBuffInfo);
						continue;
					}
					if (num == 106U)
					{
						if (this.gameMiracleInfo_ == null)
						{
							this.GameMiracleInfo = new ChessRogueMiracleInfo();
						}
						input.ReadMessage(this.GameMiracleInfo);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.rogueDifficultyInfo_ == null)
						{
							this.RogueDifficultyInfo = new RogueDifficultyLevelInfo();
						}
						input.ReadMessage(this.RogueDifficultyInfo);
						continue;
					}
					if (num == 122U)
					{
						if (this.cHMELADEMMM_ == null)
						{
							this.CHMELADEMMM = new RogueTournFormulaInfo();
						}
						input.ReadMessage(this.CHMELADEMMM);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004423 RID: 17443
		private static readonly MessageParser<RogueGameInfo> _parser = new MessageParser<RogueGameInfo>(() => new RogueGameInfo());

		// Token: 0x04004424 RID: 17444
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004425 RID: 17445
		public const int RogueBuffInfoFieldNumber = 9;

		// Token: 0x04004426 RID: 17446
		private ChessRogueBuffInfo rogueBuffInfo_;

		// Token: 0x04004427 RID: 17447
		public const int GameMiracleInfoFieldNumber = 13;

		// Token: 0x04004428 RID: 17448
		private ChessRogueMiracleInfo gameMiracleInfo_;

		// Token: 0x04004429 RID: 17449
		public const int GameItemValueFieldNumber = 1;

		// Token: 0x0400442A RID: 17450
		private RogueGameItemValue gameItemValue_;

		// Token: 0x0400442B RID: 17451
		public const int RogueAeonInfoFieldNumber = 4;

		// Token: 0x0400442C RID: 17452
		private ChessRogueGameAeonInfo rogueAeonInfo_;

		// Token: 0x0400442D RID: 17453
		public const int RogueDifficultyInfoFieldNumber = 14;

		// Token: 0x0400442E RID: 17454
		private RogueDifficultyLevelInfo rogueDifficultyInfo_;

		// Token: 0x0400442F RID: 17455
		public const int CHMELADEMMMFieldNumber = 15;

		// Token: 0x04004430 RID: 17456
		private RogueTournFormulaInfo cHMELADEMMM_;

		// Token: 0x04004431 RID: 17457
		public const int MOGLLMLEMIPFieldNumber = 7;

		// Token: 0x04004432 RID: 17458
		private KeywordUnlockValue mOGLLMLEMIP_;

		// Token: 0x04004433 RID: 17459
		public const int RogueLineupInfoFieldNumber = 8;

		// Token: 0x04004434 RID: 17460
		private RogueTournLineupInfo rogueLineupInfo_;
	}
}
