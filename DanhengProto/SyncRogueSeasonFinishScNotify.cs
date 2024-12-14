using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200129D RID: 4765
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueSeasonFinishScNotify : IMessage<SyncRogueSeasonFinishScNotify>, IMessage, IEquatable<SyncRogueSeasonFinishScNotify>, IDeepCloneable<SyncRogueSeasonFinishScNotify>, IBufferMessage
	{
		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x0600D48E RID: 54414 RVA: 0x0023786C File Offset: 0x00235A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueSeasonFinishScNotify> Parser
		{
			get
			{
				return SyncRogueSeasonFinishScNotify._parser;
			}
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x0600D48F RID: 54415 RVA: 0x00237873 File Offset: 0x00235A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueSeasonFinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x0600D490 RID: 54416 RVA: 0x00237885 File Offset: 0x00235A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueSeasonFinishScNotify.Descriptor;
			}
		}

		// Token: 0x0600D491 RID: 54417 RVA: 0x0023788C File Offset: 0x00235A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueSeasonFinishScNotify()
		{
		}

		// Token: 0x0600D492 RID: 54418 RVA: 0x00237894 File Offset: 0x00235A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueSeasonFinishScNotify(SyncRogueSeasonFinishScNotify other) : this()
		{
			this.rogueFinishInfo_ = ((other.rogueFinishInfo_ != null) ? other.rogueFinishInfo_.Clone() : null);
			this.rogueScoreRewardInfo_ = ((other.rogueScoreRewardInfo_ != null) ? other.rogueScoreRewardInfo_.Clone() : null);
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.jIBBIOIGHIC_ = other.jIBBIOIGHIC_;
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D493 RID: 54419 RVA: 0x00237934 File Offset: 0x00235B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueSeasonFinishScNotify Clone()
		{
			return new SyncRogueSeasonFinishScNotify(this);
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x0600D494 RID: 54420 RVA: 0x0023793C File Offset: 0x00235B3C
		// (set) Token: 0x0600D495 RID: 54421 RVA: 0x00237944 File Offset: 0x00235B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFinishInfo RogueFinishInfo
		{
			get
			{
				return this.rogueFinishInfo_;
			}
			set
			{
				this.rogueFinishInfo_ = value;
			}
		}

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x0600D496 RID: 54422 RVA: 0x0023794D File Offset: 0x00235B4D
		// (set) Token: 0x0600D497 RID: 54423 RVA: 0x00237955 File Offset: 0x00235B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo RogueScoreRewardInfo
		{
			get
			{
				return this.rogueScoreRewardInfo_;
			}
			set
			{
				this.rogueScoreRewardInfo_ = value;
			}
		}

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x0600D498 RID: 54424 RVA: 0x0023795E File Offset: 0x00235B5E
		// (set) Token: 0x0600D499 RID: 54425 RVA: 0x00237966 File Offset: 0x00235B66
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

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x0600D49A RID: 54426 RVA: 0x0023796F File Offset: 0x00235B6F
		// (set) Token: 0x0600D49B RID: 54427 RVA: 0x00237977 File Offset: 0x00235B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JIBBIOIGHIC
		{
			get
			{
				return this.jIBBIOIGHIC_;
			}
			set
			{
				this.jIBBIOIGHIC_ = value;
			}
		}

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x0600D49C RID: 54428 RVA: 0x00237980 File Offset: 0x00235B80
		// (set) Token: 0x0600D49D RID: 54429 RVA: 0x00237988 File Offset: 0x00235B88
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

		// Token: 0x0600D49E RID: 54430 RVA: 0x00237991 File Offset: 0x00235B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueSeasonFinishScNotify);
		}

		// Token: 0x0600D49F RID: 54431 RVA: 0x002379A0 File Offset: 0x00235BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueSeasonFinishScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueFinishInfo, other.RogueFinishInfo) && object.Equals(this.RogueScoreRewardInfo, other.RogueScoreRewardInfo) && object.Equals(this.Scene, other.Scene) && this.JIBBIOIGHIC == other.JIBBIOIGHIC && object.Equals(this.Lineup, other.Lineup) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4A0 RID: 54432 RVA: 0x00237A30 File Offset: 0x00235C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueFinishInfo_ != null)
			{
				num ^= this.RogueFinishInfo.GetHashCode();
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				num ^= this.RogueScoreRewardInfo.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this.JIBBIOIGHIC)
			{
				num ^= this.JIBBIOIGHIC.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D4A1 RID: 54433 RVA: 0x00237AC7 File Offset: 0x00235CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D4A2 RID: 54434 RVA: 0x00237ACF File Offset: 0x00235CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4A3 RID: 54435 RVA: 0x00237AD8 File Offset: 0x00235CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lineup_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Lineup);
			}
			if (this.rogueFinishInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueFinishInfo);
			}
			if (this.JIBBIOIGHIC)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.JIBBIOIGHIC);
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RogueScoreRewardInfo);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4A4 RID: 54436 RVA: 0x00237B88 File Offset: 0x00235D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueFinishInfo);
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueScoreRewardInfo);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this.JIBBIOIGHIC)
			{
				num += 2;
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D4A5 RID: 54437 RVA: 0x00237C1C File Offset: 0x00235E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueSeasonFinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueFinishInfo_ != null)
			{
				if (this.rogueFinishInfo_ == null)
				{
					this.RogueFinishInfo = new RogueFinishInfo();
				}
				this.RogueFinishInfo.MergeFrom(other.RogueFinishInfo);
			}
			if (other.rogueScoreRewardInfo_ != null)
			{
				if (this.rogueScoreRewardInfo_ == null)
				{
					this.RogueScoreRewardInfo = new RogueScoreRewardInfo();
				}
				this.RogueScoreRewardInfo.MergeFrom(other.RogueScoreRewardInfo);
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.JIBBIOIGHIC)
			{
				this.JIBBIOIGHIC = other.JIBBIOIGHIC;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4A6 RID: 54438 RVA: 0x00237D08 File Offset: 0x00235F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4A7 RID: 54439 RVA: 0x00237D14 File Offset: 0x00235F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 10U)
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new LineupInfo();
						}
						input.ReadMessage(this.Lineup);
						continue;
					}
					if (num == 50U)
					{
						if (this.rogueFinishInfo_ == null)
						{
							this.RogueFinishInfo = new RogueFinishInfo();
						}
						input.ReadMessage(this.RogueFinishInfo);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.JIBBIOIGHIC = input.ReadBool();
						continue;
					}
					if (num == 66U)
					{
						if (this.rogueScoreRewardInfo_ == null)
						{
							this.RogueScoreRewardInfo = new RogueScoreRewardInfo();
						}
						input.ReadMessage(this.RogueScoreRewardInfo);
						continue;
					}
					if (num == 82U)
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

		// Token: 0x0400550A RID: 21770
		private static readonly MessageParser<SyncRogueSeasonFinishScNotify> _parser = new MessageParser<SyncRogueSeasonFinishScNotify>(() => new SyncRogueSeasonFinishScNotify());

		// Token: 0x0400550B RID: 21771
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400550C RID: 21772
		public const int RogueFinishInfoFieldNumber = 6;

		// Token: 0x0400550D RID: 21773
		private RogueFinishInfo rogueFinishInfo_;

		// Token: 0x0400550E RID: 21774
		public const int RogueScoreRewardInfoFieldNumber = 8;

		// Token: 0x0400550F RID: 21775
		private RogueScoreRewardInfo rogueScoreRewardInfo_;

		// Token: 0x04005510 RID: 21776
		public const int SceneFieldNumber = 10;

		// Token: 0x04005511 RID: 21777
		private SceneInfo scene_;

		// Token: 0x04005512 RID: 21778
		public const int JIBBIOIGHICFieldNumber = 7;

		// Token: 0x04005513 RID: 21779
		private bool jIBBIOIGHIC_;

		// Token: 0x04005514 RID: 21780
		public const int LineupFieldNumber = 1;

		// Token: 0x04005515 RID: 21781
		private LineupInfo lineup_;
	}
}
