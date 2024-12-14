using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009C3 RID: 2499
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KLMFIBACKFD : IMessage<KLMFIBACKFD>, IMessage, IEquatable<KLMFIBACKFD>, IDeepCloneable<KLMFIBACKFD>, IBufferMessage
	{
		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x06006F82 RID: 28546 RVA: 0x00129A57 File Offset: 0x00127C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KLMFIBACKFD> Parser
		{
			get
			{
				return KLMFIBACKFD._parser;
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x06006F83 RID: 28547 RVA: 0x00129A5E File Offset: 0x00127C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KLMFIBACKFDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x06006F84 RID: 28548 RVA: 0x00129A70 File Offset: 0x00127C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KLMFIBACKFD.Descriptor;
			}
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x00129A77 File Offset: 0x00127C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KLMFIBACKFD()
		{
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x00129A98 File Offset: 0x00127C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KLMFIBACKFD(KLMFIBACKFD other) : this()
		{
			this.buffOne_ = other.buffOne_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this.buffTwo_ = other.buffTwo_;
			this.lineupList_ = other.lineupList_.Clone();
			this.remarkName_ = other.remarkName_;
			this.scoreId_ = other.scoreId_;
			this.pPMKDMINBNH_ = other.pPMKDMINBNH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x00129B25 File Offset: 0x00127D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KLMFIBACKFD Clone()
		{
			return new KLMFIBACKFD(this);
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x06006F88 RID: 28552 RVA: 0x00129B2D File Offset: 0x00127D2D
		// (set) Token: 0x06006F89 RID: 28553 RVA: 0x00129B35 File Offset: 0x00127D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffOne
		{
			get
			{
				return this.buffOne_;
			}
			set
			{
				this.buffOne_ = value;
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06006F8A RID: 28554 RVA: 0x00129B3E File Offset: 0x00127D3E
		// (set) Token: 0x06006F8B RID: 28555 RVA: 0x00129B46 File Offset: 0x00127D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSimpleInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x06006F8C RID: 28556 RVA: 0x00129B4F File Offset: 0x00127D4F
		// (set) Token: 0x06006F8D RID: 28557 RVA: 0x00129B57 File Offset: 0x00127D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffTwo
		{
			get
			{
				return this.buffTwo_;
			}
			set
			{
				this.buffTwo_ = value;
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x06006F8E RID: 28558 RVA: 0x00129B60 File Offset: 0x00127D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChallengeLineupList> LineupList
		{
			get
			{
				return this.lineupList_;
			}
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x06006F8F RID: 28559 RVA: 0x00129B68 File Offset: 0x00127D68
		// (set) Token: 0x06006F90 RID: 28560 RVA: 0x00129B70 File Offset: 0x00127D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RemarkName
		{
			get
			{
				return this.remarkName_;
			}
			set
			{
				this.remarkName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06006F91 RID: 28561 RVA: 0x00129B83 File Offset: 0x00127D83
		// (set) Token: 0x06006F92 RID: 28562 RVA: 0x00129B8B File Offset: 0x00127D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06006F93 RID: 28563 RVA: 0x00129B94 File Offset: 0x00127D94
		// (set) Token: 0x06006F94 RID: 28564 RVA: 0x00129B9C File Offset: 0x00127D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PPMKDMINBNH
		{
			get
			{
				return this.pPMKDMINBNH_;
			}
			set
			{
				this.pPMKDMINBNH_ = value;
			}
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x00129BA5 File Offset: 0x00127DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KLMFIBACKFD);
		}

		// Token: 0x06006F96 RID: 28566 RVA: 0x00129BB4 File Offset: 0x00127DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KLMFIBACKFD other)
		{
			return other != null && (other == this || (this.BuffOne == other.BuffOne && object.Equals(this.PlayerInfo, other.PlayerInfo) && this.BuffTwo == other.BuffTwo && this.lineupList_.Equals(other.lineupList_) && !(this.RemarkName != other.RemarkName) && this.ScoreId == other.ScoreId && this.PPMKDMINBNH == other.PPMKDMINBNH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F97 RID: 28567 RVA: 0x00129C5C File Offset: 0x00127E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffOne != 0U)
			{
				num ^= this.BuffOne.GetHashCode();
			}
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this.BuffTwo != 0U)
			{
				num ^= this.BuffTwo.GetHashCode();
			}
			num ^= this.lineupList_.GetHashCode();
			if (this.RemarkName.Length != 0)
			{
				num ^= this.RemarkName.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.PPMKDMINBNH != 0U)
			{
				num ^= this.PPMKDMINBNH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F98 RID: 28568 RVA: 0x00129D25 File Offset: 0x00127F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F99 RID: 28569 RVA: 0x00129D2D File Offset: 0x00127F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F9A RID: 28570 RVA: 0x00129D38 File Offset: 0x00127F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ScoreId);
			}
			this.lineupList_.WriteTo(ref output, KLMFIBACKFD._repeated_lineupList_codec);
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this.PPMKDMINBNH != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.PPMKDMINBNH);
			}
			if (this.BuffTwo != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BuffTwo);
			}
			if (this.RemarkName.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.RemarkName);
			}
			if (this.BuffOne != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.BuffOne);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x00129E18 File Offset: 0x00128018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffOne != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffOne);
			}
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this.BuffTwo != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffTwo);
			}
			num += this.lineupList_.CalculateSize(KLMFIBACKFD._repeated_lineupList_codec);
			if (this.RemarkName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RemarkName);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.PPMKDMINBNH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PPMKDMINBNH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x00129EE8 File Offset: 0x001280E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KLMFIBACKFD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffOne != 0U)
			{
				this.BuffOne = other.BuffOne;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new PlayerSimpleInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			if (other.BuffTwo != 0U)
			{
				this.BuffTwo = other.BuffTwo;
			}
			this.lineupList_.Add(other.lineupList_);
			if (other.RemarkName.Length != 0)
			{
				this.RemarkName = other.RemarkName;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.PPMKDMINBNH != 0U)
			{
				this.PPMKDMINBNH = other.PPMKDMINBNH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x00129FB6 File Offset: 0x001281B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x00129FC0 File Offset: 0x001281C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 16U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						this.lineupList_.AddEntriesFrom(ref input, KLMFIBACKFD._repeated_lineupList_codec);
						continue;
					}
					if (num == 74U)
					{
						if (this.playerInfo_ == null)
						{
							this.PlayerInfo = new PlayerSimpleInfo();
						}
						input.ReadMessage(this.PlayerInfo);
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.PPMKDMINBNH = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.BuffTwo = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.RemarkName = input.ReadString();
						continue;
					}
					if (num == 120U)
					{
						this.BuffOne = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002ADC RID: 10972
		private static readonly MessageParser<KLMFIBACKFD> _parser = new MessageParser<KLMFIBACKFD>(() => new KLMFIBACKFD());

		// Token: 0x04002ADD RID: 10973
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ADE RID: 10974
		public const int BuffOneFieldNumber = 15;

		// Token: 0x04002ADF RID: 10975
		private uint buffOne_;

		// Token: 0x04002AE0 RID: 10976
		public const int PlayerInfoFieldNumber = 9;

		// Token: 0x04002AE1 RID: 10977
		private PlayerSimpleInfo playerInfo_;

		// Token: 0x04002AE2 RID: 10978
		public const int BuffTwoFieldNumber = 13;

		// Token: 0x04002AE3 RID: 10979
		private uint buffTwo_;

		// Token: 0x04002AE4 RID: 10980
		public const int LineupListFieldNumber = 4;

		// Token: 0x04002AE5 RID: 10981
		private static readonly FieldCodec<ChallengeLineupList> _repeated_lineupList_codec = FieldCodec.ForMessage<ChallengeLineupList>(34U, ChallengeLineupList.Parser);

		// Token: 0x04002AE6 RID: 10982
		private readonly RepeatedField<ChallengeLineupList> lineupList_ = new RepeatedField<ChallengeLineupList>();

		// Token: 0x04002AE7 RID: 10983
		public const int RemarkNameFieldNumber = 14;

		// Token: 0x04002AE8 RID: 10984
		private string remarkName_ = "";

		// Token: 0x04002AE9 RID: 10985
		public const int ScoreIdFieldNumber = 2;

		// Token: 0x04002AEA RID: 10986
		private uint scoreId_;

		// Token: 0x04002AEB RID: 10987
		public const int PPMKDMINBNHFieldNumber = 12;

		// Token: 0x04002AEC RID: 10988
		private uint pPMKDMINBNH_;
	}
}
