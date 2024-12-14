using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001087 RID: 4231
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ScenePropInfo : IMessage<ScenePropInfo>, IMessage, IEquatable<ScenePropInfo>, IDeepCloneable<ScenePropInfo>, IBufferMessage
	{
		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x0600BCA3 RID: 48291 RVA: 0x001FC867 File Offset: 0x001FAA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ScenePropInfo> Parser
		{
			get
			{
				return ScenePropInfo._parser;
			}
		}

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x0600BCA4 RID: 48292 RVA: 0x001FC86E File Offset: 0x001FAA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ScenePropInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x0600BCA5 RID: 48293 RVA: 0x001FC880 File Offset: 0x001FAA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScenePropInfo.Descriptor;
			}
		}

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x001FC887 File Offset: 0x001FAA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePropInfo()
		{
		}

		// Token: 0x0600BCA7 RID: 48295 RVA: 0x001FC89C File Offset: 0x001FAA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePropInfo(ScenePropInfo other) : this()
		{
			this.propState_ = other.propState_;
			this.createTimeMs_ = other.createTimeMs_;
			this.propId_ = other.propId_;
			this.extraInfo_ = ((other.extraInfo_ != null) ? other.extraInfo_.Clone() : null);
			this.lifeTimeMs_ = other.lifeTimeMs_;
			this.triggerNameList_ = other.triggerNameList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCA8 RID: 48296 RVA: 0x001FC91D File Offset: 0x001FAB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePropInfo Clone()
		{
			return new ScenePropInfo(this);
		}

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x0600BCA9 RID: 48297 RVA: 0x001FC925 File Offset: 0x001FAB25
		// (set) Token: 0x0600BCAA RID: 48298 RVA: 0x001FC92D File Offset: 0x001FAB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropState
		{
			get
			{
				return this.propState_;
			}
			set
			{
				this.propState_ = value;
			}
		}

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x0600BCAB RID: 48299 RVA: 0x001FC936 File Offset: 0x001FAB36
		// (set) Token: 0x0600BCAC RID: 48300 RVA: 0x001FC93E File Offset: 0x001FAB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong CreateTimeMs
		{
			get
			{
				return this.createTimeMs_;
			}
			set
			{
				this.createTimeMs_ = value;
			}
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x0600BCAD RID: 48301 RVA: 0x001FC947 File Offset: 0x001FAB47
		// (set) Token: 0x0600BCAE RID: 48302 RVA: 0x001FC94F File Offset: 0x001FAB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropId
		{
			get
			{
				return this.propId_;
			}
			set
			{
				this.propId_ = value;
			}
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0600BCAF RID: 48303 RVA: 0x001FC958 File Offset: 0x001FAB58
		// (set) Token: 0x0600BCB0 RID: 48304 RVA: 0x001FC960 File Offset: 0x001FAB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropExtraInfo ExtraInfo
		{
			get
			{
				return this.extraInfo_;
			}
			set
			{
				this.extraInfo_ = value;
			}
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0600BCB1 RID: 48305 RVA: 0x001FC969 File Offset: 0x001FAB69
		// (set) Token: 0x0600BCB2 RID: 48306 RVA: 0x001FC971 File Offset: 0x001FAB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LifeTimeMs
		{
			get
			{
				return this.lifeTimeMs_;
			}
			set
			{
				this.lifeTimeMs_ = value;
			}
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0600BCB3 RID: 48307 RVA: 0x001FC97A File Offset: 0x001FAB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> TriggerNameList
		{
			get
			{
				return this.triggerNameList_;
			}
		}

		// Token: 0x0600BCB4 RID: 48308 RVA: 0x001FC982 File Offset: 0x001FAB82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScenePropInfo);
		}

		// Token: 0x0600BCB5 RID: 48309 RVA: 0x001FC990 File Offset: 0x001FAB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScenePropInfo other)
		{
			return other != null && (other == this || (this.PropState == other.PropState && this.CreateTimeMs == other.CreateTimeMs && this.PropId == other.PropId && object.Equals(this.ExtraInfo, other.ExtraInfo) && this.LifeTimeMs == other.LifeTimeMs && this.triggerNameList_.Equals(other.triggerNameList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCB6 RID: 48310 RVA: 0x001FCA24 File Offset: 0x001FAC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PropState != 0U)
			{
				num ^= this.PropState.GetHashCode();
			}
			if (this.CreateTimeMs != 0UL)
			{
				num ^= this.CreateTimeMs.GetHashCode();
			}
			if (this.PropId != 0U)
			{
				num ^= this.PropId.GetHashCode();
			}
			if (this.extraInfo_ != null)
			{
				num ^= this.ExtraInfo.GetHashCode();
			}
			if (this.LifeTimeMs != 0U)
			{
				num ^= this.LifeTimeMs.GetHashCode();
			}
			num ^= this.triggerNameList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BCB7 RID: 48311 RVA: 0x001FCAD2 File Offset: 0x001FACD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BCB8 RID: 48312 RVA: 0x001FCADA File Offset: 0x001FACDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCB9 RID: 48313 RVA: 0x001FCAE4 File Offset: 0x001FACE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.triggerNameList_.WriteTo(ref output, ScenePropInfo._repeated_triggerNameList_codec);
			if (this.PropState != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PropState);
			}
			if (this.PropId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.PropId);
			}
			if (this.extraInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ExtraInfo);
			}
			if (this.LifeTimeMs != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.LifeTimeMs);
			}
			if (this.CreateTimeMs != 0UL)
			{
				output.WriteRawTag(104);
				output.WriteUInt64(this.CreateTimeMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BCBA RID: 48314 RVA: 0x001FCBA4 File Offset: 0x001FADA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PropState != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropState);
			}
			if (this.CreateTimeMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreateTimeMs);
			}
			if (this.PropId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropId);
			}
			if (this.extraInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ExtraInfo);
			}
			if (this.LifeTimeMs != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LifeTimeMs);
			}
			num += this.triggerNameList_.CalculateSize(ScenePropInfo._repeated_triggerNameList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BCBB RID: 48315 RVA: 0x001FCC58 File Offset: 0x001FAE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScenePropInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PropState != 0U)
			{
				this.PropState = other.PropState;
			}
			if (other.CreateTimeMs != 0UL)
			{
				this.CreateTimeMs = other.CreateTimeMs;
			}
			if (other.PropId != 0U)
			{
				this.PropId = other.PropId;
			}
			if (other.extraInfo_ != null)
			{
				if (this.extraInfo_ == null)
				{
					this.ExtraInfo = new PropExtraInfo();
				}
				this.ExtraInfo.MergeFrom(other.ExtraInfo);
			}
			if (other.LifeTimeMs != 0U)
			{
				this.LifeTimeMs = other.LifeTimeMs;
			}
			this.triggerNameList_.Add(other.triggerNameList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BCBC RID: 48316 RVA: 0x001FCD0D File Offset: 0x001FAF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCBD RID: 48317 RVA: 0x001FCD18 File Offset: 0x001FAF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 10U)
					{
						this.triggerNameList_.AddEntriesFrom(ref input, ScenePropInfo._repeated_triggerNameList_codec);
						continue;
					}
					if (num == 40U)
					{
						this.PropState = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PropId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.extraInfo_ == null)
						{
							this.ExtraInfo = new PropExtraInfo();
						}
						input.ReadMessage(this.ExtraInfo);
						continue;
					}
					if (num == 96U)
					{
						this.LifeTimeMs = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.CreateTimeMs = input.ReadUInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CB8 RID: 19640
		private static readonly MessageParser<ScenePropInfo> _parser = new MessageParser<ScenePropInfo>(() => new ScenePropInfo());

		// Token: 0x04004CB9 RID: 19641
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CBA RID: 19642
		public const int PropStateFieldNumber = 5;

		// Token: 0x04004CBB RID: 19643
		private uint propState_;

		// Token: 0x04004CBC RID: 19644
		public const int CreateTimeMsFieldNumber = 13;

		// Token: 0x04004CBD RID: 19645
		private ulong createTimeMs_;

		// Token: 0x04004CBE RID: 19646
		public const int PropIdFieldNumber = 7;

		// Token: 0x04004CBF RID: 19647
		private uint propId_;

		// Token: 0x04004CC0 RID: 19648
		public const int ExtraInfoFieldNumber = 11;

		// Token: 0x04004CC1 RID: 19649
		private PropExtraInfo extraInfo_;

		// Token: 0x04004CC2 RID: 19650
		public const int LifeTimeMsFieldNumber = 12;

		// Token: 0x04004CC3 RID: 19651
		private uint lifeTimeMs_;

		// Token: 0x04004CC4 RID: 19652
		public const int TriggerNameListFieldNumber = 1;

		// Token: 0x04004CC5 RID: 19653
		private static readonly FieldCodec<string> _repeated_triggerNameList_codec = FieldCodec.ForString(10U);

		// Token: 0x04004CC6 RID: 19654
		private readonly RepeatedField<string> triggerNameList_ = new RepeatedField<string>();
	}
}
