using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D6F RID: 3439
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RaidKickByServerScNotify : IMessage<RaidKickByServerScNotify>, IMessage, IEquatable<RaidKickByServerScNotify>, IDeepCloneable<RaidKickByServerScNotify>, IBufferMessage
	{
		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x060099B0 RID: 39344 RVA: 0x00199327 File Offset: 0x00197527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RaidKickByServerScNotify> Parser
		{
			get
			{
				return RaidKickByServerScNotify._parser;
			}
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x060099B1 RID: 39345 RVA: 0x0019932E File Offset: 0x0019752E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RaidKickByServerScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x060099B2 RID: 39346 RVA: 0x00199340 File Offset: 0x00197540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RaidKickByServerScNotify.Descriptor;
			}
		}

		// Token: 0x060099B3 RID: 39347 RVA: 0x00199347 File Offset: 0x00197547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidKickByServerScNotify()
		{
		}

		// Token: 0x060099B4 RID: 39348 RVA: 0x00199350 File Offset: 0x00197550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidKickByServerScNotify(RaidKickByServerScNotify other) : this()
		{
			this.raidId_ = other.raidId_;
			this.worldLevel_ = other.worldLevel_;
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.reason_ = other.reason_;
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099B5 RID: 39349 RVA: 0x001993D0 File Offset: 0x001975D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidKickByServerScNotify Clone()
		{
			return new RaidKickByServerScNotify(this);
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x060099B6 RID: 39350 RVA: 0x001993D8 File Offset: 0x001975D8
		// (set) Token: 0x060099B7 RID: 39351 RVA: 0x001993E0 File Offset: 0x001975E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RaidId
		{
			get
			{
				return this.raidId_;
			}
			set
			{
				this.raidId_ = value;
			}
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x060099B8 RID: 39352 RVA: 0x001993E9 File Offset: 0x001975E9
		// (set) Token: 0x060099B9 RID: 39353 RVA: 0x001993F1 File Offset: 0x001975F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x060099BA RID: 39354 RVA: 0x001993FA File Offset: 0x001975FA
		// (set) Token: 0x060099BB RID: 39355 RVA: 0x00199402 File Offset: 0x00197602
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

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x060099BC RID: 39356 RVA: 0x0019940B File Offset: 0x0019760B
		// (set) Token: 0x060099BD RID: 39357 RVA: 0x00199413 File Offset: 0x00197613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EGHDABBBNJO Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x060099BE RID: 39358 RVA: 0x0019941C File Offset: 0x0019761C
		// (set) Token: 0x060099BF RID: 39359 RVA: 0x00199424 File Offset: 0x00197624
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

		// Token: 0x060099C0 RID: 39360 RVA: 0x0019942D File Offset: 0x0019762D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RaidKickByServerScNotify);
		}

		// Token: 0x060099C1 RID: 39361 RVA: 0x0019943C File Offset: 0x0019763C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RaidKickByServerScNotify other)
		{
			return other != null && (other == this || (this.RaidId == other.RaidId && this.WorldLevel == other.WorldLevel && object.Equals(this.Scene, other.Scene) && this.Reason == other.Reason && object.Equals(this.Lineup, other.Lineup) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099C2 RID: 39362 RVA: 0x001994C0 File Offset: 0x001976C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this.Reason != EGHDABBBNJO.RaidKickReasonNone)
			{
				num ^= this.Reason.GetHashCode();
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

		// Token: 0x060099C3 RID: 39363 RVA: 0x00199563 File Offset: 0x00197763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060099C4 RID: 39364 RVA: 0x0019956B File Offset: 0x0019776B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099C5 RID: 39365 RVA: 0x00199574 File Offset: 0x00197774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.scene_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Scene);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Lineup);
			}
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.RaidId);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.Reason != EGHDABBBNJO.RaidKickReasonNone)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099C6 RID: 39366 RVA: 0x00199624 File Offset: 0x00197824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this.Reason != EGHDABBBNJO.RaidKickReasonNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
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

		// Token: 0x060099C7 RID: 39367 RVA: 0x001996C4 File Offset: 0x001978C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RaidKickByServerScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.Reason != EGHDABBBNJO.RaidKickReasonNone)
			{
				this.Reason = other.Reason;
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

		// Token: 0x060099C8 RID: 39368 RVA: 0x00199780 File Offset: 0x00197980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099C9 RID: 39369 RVA: 0x0019978C File Offset: 0x0019798C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 58U)
					{
						if (this.scene_ == null)
						{
							this.Scene = new SceneInfo();
						}
						input.ReadMessage(this.Scene);
						continue;
					}
					if (num == 74U)
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new LineupInfo();
						}
						input.ReadMessage(this.Lineup);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.RaidId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Reason = (EGHDABBBNJO)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003BAD RID: 15277
		private static readonly MessageParser<RaidKickByServerScNotify> _parser = new MessageParser<RaidKickByServerScNotify>(() => new RaidKickByServerScNotify());

		// Token: 0x04003BAE RID: 15278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BAF RID: 15279
		public const int RaidIdFieldNumber = 11;

		// Token: 0x04003BB0 RID: 15280
		private uint raidId_;

		// Token: 0x04003BB1 RID: 15281
		public const int WorldLevelFieldNumber = 12;

		// Token: 0x04003BB2 RID: 15282
		private uint worldLevel_;

		// Token: 0x04003BB3 RID: 15283
		public const int SceneFieldNumber = 7;

		// Token: 0x04003BB4 RID: 15284
		private SceneInfo scene_;

		// Token: 0x04003BB5 RID: 15285
		public const int ReasonFieldNumber = 14;

		// Token: 0x04003BB6 RID: 15286
		private EGHDABBBNJO reason_;

		// Token: 0x04003BB7 RID: 15287
		public const int LineupFieldNumber = 9;

		// Token: 0x04003BB8 RID: 15288
		private LineupInfo lineup_;
	}
}
