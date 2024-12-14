using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011A7 RID: 4519
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartChallengeScRsp : IMessage<StartChallengeScRsp>, IMessage, IEquatable<StartChallengeScRsp>, IDeepCloneable<StartChallengeScRsp>, IBufferMessage
	{
		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600C9BB RID: 51643 RVA: 0x0021D0AB File Offset: 0x0021B2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartChallengeScRsp> Parser
		{
			get
			{
				return StartChallengeScRsp._parser;
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600C9BC RID: 51644 RVA: 0x0021D0B2 File Offset: 0x0021B2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartChallengeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600C9BD RID: 51645 RVA: 0x0021D0C4 File Offset: 0x0021B2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartChallengeScRsp.Descriptor;
			}
		}

		// Token: 0x0600C9BE RID: 51646 RVA: 0x0021D0CB File Offset: 0x0021B2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartChallengeScRsp()
		{
		}

		// Token: 0x0600C9BF RID: 51647 RVA: 0x0021D0E0 File Offset: 0x0021B2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartChallengeScRsp(StartChallengeScRsp other) : this()
		{
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.lineupList_ = other.lineupList_.Clone();
			this.curChallenge_ = ((other.curChallenge_ != null) ? other.curChallenge_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9C0 RID: 51648 RVA: 0x0021D175 File Offset: 0x0021B375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartChallengeScRsp Clone()
		{
			return new StartChallengeScRsp(this);
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600C9C1 RID: 51649 RVA: 0x0021D17D File Offset: 0x0021B37D
		// (set) Token: 0x0600C9C2 RID: 51650 RVA: 0x0021D185 File Offset: 0x0021B385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStageInfo StageInfo
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

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600C9C3 RID: 51651 RVA: 0x0021D18E File Offset: 0x0021B38E
		// (set) Token: 0x0600C9C4 RID: 51652 RVA: 0x0021D196 File Offset: 0x0021B396
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

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600C9C5 RID: 51653 RVA: 0x0021D19F File Offset: 0x0021B39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LineupInfo> LineupList
		{
			get
			{
				return this.lineupList_;
			}
		}

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600C9C6 RID: 51654 RVA: 0x0021D1A7 File Offset: 0x0021B3A7
		// (set) Token: 0x0600C9C7 RID: 51655 RVA: 0x0021D1AF File Offset: 0x0021B3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurChallenge CurChallenge
		{
			get
			{
				return this.curChallenge_;
			}
			set
			{
				this.curChallenge_ = value;
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600C9C8 RID: 51656 RVA: 0x0021D1B8 File Offset: 0x0021B3B8
		// (set) Token: 0x0600C9C9 RID: 51657 RVA: 0x0021D1C0 File Offset: 0x0021B3C0
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

		// Token: 0x0600C9CA RID: 51658 RVA: 0x0021D1C9 File Offset: 0x0021B3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartChallengeScRsp);
		}

		// Token: 0x0600C9CB RID: 51659 RVA: 0x0021D1D8 File Offset: 0x0021B3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartChallengeScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.StageInfo, other.StageInfo) && object.Equals(this.Scene, other.Scene) && this.lineupList_.Equals(other.lineupList_) && object.Equals(this.CurChallenge, other.CurChallenge) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9CC RID: 51660 RVA: 0x0021D268 File Offset: 0x0021B468
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
			num ^= this.lineupList_.GetHashCode();
			if (this.curChallenge_ != null)
			{
				num ^= this.CurChallenge.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C9CD RID: 51661 RVA: 0x0021D2F7 File Offset: 0x0021B4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C9CE RID: 51662 RVA: 0x0021D2FF File Offset: 0x0021B4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9CF RID: 51663 RVA: 0x0021D308 File Offset: 0x0021B508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.scene_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Scene);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.curChallenge_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CurChallenge);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.StageInfo);
			}
			this.lineupList_.WriteTo(ref output, StartChallengeScRsp._repeated_lineupList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C9D0 RID: 51664 RVA: 0x0021D3AC File Offset: 0x0021B5AC
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
			num += this.lineupList_.CalculateSize(StartChallengeScRsp._repeated_lineupList_codec);
			if (this.curChallenge_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurChallenge);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C9D1 RID: 51665 RVA: 0x0021D448 File Offset: 0x0021B648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartChallengeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new ChallengeStageInfo();
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
			this.lineupList_.Add(other.lineupList_);
			if (other.curChallenge_ != null)
			{
				if (this.curChallenge_ == null)
				{
					this.CurChallenge = new CurChallenge();
				}
				this.CurChallenge.MergeFrom(other.CurChallenge);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C9D2 RID: 51666 RVA: 0x0021D519 File Offset: 0x0021B719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9D3 RID: 51667 RVA: 0x0021D524 File Offset: 0x0021B724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 18U)
					{
						if (this.scene_ == null)
						{
							this.Scene = new SceneInfo();
						}
						input.ReadMessage(this.Scene);
						continue;
					}
					if (num == 24U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						if (this.curChallenge_ == null)
						{
							this.CurChallenge = new CurChallenge();
						}
						input.ReadMessage(this.CurChallenge);
						continue;
					}
					if (num == 66U)
					{
						if (this.stageInfo_ == null)
						{
							this.StageInfo = new ChallengeStageInfo();
						}
						input.ReadMessage(this.StageInfo);
						continue;
					}
					if (num == 98U)
					{
						this.lineupList_.AddEntriesFrom(ref input, StartChallengeScRsp._repeated_lineupList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400515B RID: 20827
		private static readonly MessageParser<StartChallengeScRsp> _parser = new MessageParser<StartChallengeScRsp>(() => new StartChallengeScRsp());

		// Token: 0x0400515C RID: 20828
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400515D RID: 20829
		public const int StageInfoFieldNumber = 8;

		// Token: 0x0400515E RID: 20830
		private ChallengeStageInfo stageInfo_;

		// Token: 0x0400515F RID: 20831
		public const int SceneFieldNumber = 2;

		// Token: 0x04005160 RID: 20832
		private SceneInfo scene_;

		// Token: 0x04005161 RID: 20833
		public const int LineupListFieldNumber = 12;

		// Token: 0x04005162 RID: 20834
		private static readonly FieldCodec<LineupInfo> _repeated_lineupList_codec = FieldCodec.ForMessage<LineupInfo>(98U, LineupInfo.Parser);

		// Token: 0x04005163 RID: 20835
		private readonly RepeatedField<LineupInfo> lineupList_ = new RepeatedField<LineupInfo>();

		// Token: 0x04005164 RID: 20836
		public const int CurChallengeFieldNumber = 6;

		// Token: 0x04005165 RID: 20837
		private CurChallenge curChallenge_;

		// Token: 0x04005166 RID: 20838
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04005167 RID: 20839
		private uint retcode_;
	}
}
