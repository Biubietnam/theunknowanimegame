using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200108D RID: 4237
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneSummonUnitInfo : IMessage<SceneSummonUnitInfo>, IMessage, IEquatable<SceneSummonUnitInfo>, IDeepCloneable<SceneSummonUnitInfo>, IBufferMessage
	{
		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0600BCEB RID: 48363 RVA: 0x001FD3B7 File Offset: 0x001FB5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneSummonUnitInfo> Parser
		{
			get
			{
				return SceneSummonUnitInfo._parser;
			}
		}

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0600BCEC RID: 48364 RVA: 0x001FD3BE File Offset: 0x001FB5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneSummonUnitInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0600BCED RID: 48365 RVA: 0x001FD3D0 File Offset: 0x001FB5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneSummonUnitInfo.Descriptor;
			}
		}

		// Token: 0x0600BCEE RID: 48366 RVA: 0x001FD3D7 File Offset: 0x001FB5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSummonUnitInfo()
		{
		}

		// Token: 0x0600BCEF RID: 48367 RVA: 0x001FD3EC File Offset: 0x001FB5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSummonUnitInfo(SceneSummonUnitInfo other) : this()
		{
			this.attachEntityId_ = other.attachEntityId_;
			this.createTimeMs_ = other.createTimeMs_;
			this.casterEntityId_ = other.casterEntityId_;
			this.lifeTimeMs_ = other.lifeTimeMs_;
			this.triggerNameList_ = other.triggerNameList_.Clone();
			this.summonUnitId_ = other.summonUnitId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCF0 RID: 48368 RVA: 0x001FD45D File Offset: 0x001FB65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSummonUnitInfo Clone()
		{
			return new SceneSummonUnitInfo(this);
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0600BCF1 RID: 48369 RVA: 0x001FD465 File Offset: 0x001FB665
		// (set) Token: 0x0600BCF2 RID: 48370 RVA: 0x001FD46D File Offset: 0x001FB66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AttachEntityId
		{
			get
			{
				return this.attachEntityId_;
			}
			set
			{
				this.attachEntityId_ = value;
			}
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0600BCF3 RID: 48371 RVA: 0x001FD476 File Offset: 0x001FB676
		// (set) Token: 0x0600BCF4 RID: 48372 RVA: 0x001FD47E File Offset: 0x001FB67E
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

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x0600BCF5 RID: 48373 RVA: 0x001FD487 File Offset: 0x001FB687
		// (set) Token: 0x0600BCF6 RID: 48374 RVA: 0x001FD48F File Offset: 0x001FB68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CasterEntityId
		{
			get
			{
				return this.casterEntityId_;
			}
			set
			{
				this.casterEntityId_ = value;
			}
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0600BCF7 RID: 48375 RVA: 0x001FD498 File Offset: 0x001FB698
		// (set) Token: 0x0600BCF8 RID: 48376 RVA: 0x001FD4A0 File Offset: 0x001FB6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LifeTimeMs
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

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0600BCF9 RID: 48377 RVA: 0x001FD4A9 File Offset: 0x001FB6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> TriggerNameList
		{
			get
			{
				return this.triggerNameList_;
			}
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0600BCFA RID: 48378 RVA: 0x001FD4B1 File Offset: 0x001FB6B1
		// (set) Token: 0x0600BCFB RID: 48379 RVA: 0x001FD4B9 File Offset: 0x001FB6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SummonUnitId
		{
			get
			{
				return this.summonUnitId_;
			}
			set
			{
				this.summonUnitId_ = value;
			}
		}

		// Token: 0x0600BCFC RID: 48380 RVA: 0x001FD4C2 File Offset: 0x001FB6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneSummonUnitInfo);
		}

		// Token: 0x0600BCFD RID: 48381 RVA: 0x001FD4D0 File Offset: 0x001FB6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneSummonUnitInfo other)
		{
			return other != null && (other == this || (this.AttachEntityId == other.AttachEntityId && this.CreateTimeMs == other.CreateTimeMs && this.CasterEntityId == other.CasterEntityId && this.LifeTimeMs == other.LifeTimeMs && this.triggerNameList_.Equals(other.triggerNameList_) && this.SummonUnitId == other.SummonUnitId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCFE RID: 48382 RVA: 0x001FD560 File Offset: 0x001FB760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttachEntityId != 0U)
			{
				num ^= this.AttachEntityId.GetHashCode();
			}
			if (this.CreateTimeMs != 0UL)
			{
				num ^= this.CreateTimeMs.GetHashCode();
			}
			if (this.CasterEntityId != 0U)
			{
				num ^= this.CasterEntityId.GetHashCode();
			}
			if (this.LifeTimeMs != 0)
			{
				num ^= this.LifeTimeMs.GetHashCode();
			}
			num ^= this.triggerNameList_.GetHashCode();
			if (this.SummonUnitId != 0U)
			{
				num ^= this.SummonUnitId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BCFF RID: 48383 RVA: 0x001FD611 File Offset: 0x001FB811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BD00 RID: 48384 RVA: 0x001FD619 File Offset: 0x001FB819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD01 RID: 48385 RVA: 0x001FD624 File Offset: 0x001FB824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LifeTimeMs != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LifeTimeMs);
			}
			this.triggerNameList_.WriteTo(ref output, SceneSummonUnitInfo._repeated_triggerNameList_codec);
			if (this.AttachEntityId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AttachEntityId);
			}
			if (this.SummonUnitId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.SummonUnitId);
			}
			if (this.CreateTimeMs != 0UL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.CreateTimeMs);
			}
			if (this.CasterEntityId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.CasterEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD02 RID: 48386 RVA: 0x001FD6E4 File Offset: 0x001FB8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttachEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AttachEntityId);
			}
			if (this.CreateTimeMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreateTimeMs);
			}
			if (this.CasterEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CasterEntityId);
			}
			if (this.LifeTimeMs != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LifeTimeMs);
			}
			num += this.triggerNameList_.CalculateSize(SceneSummonUnitInfo._repeated_triggerNameList_codec);
			if (this.SummonUnitId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SummonUnitId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD03 RID: 48387 RVA: 0x001FD798 File Offset: 0x001FB998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneSummonUnitInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttachEntityId != 0U)
			{
				this.AttachEntityId = other.AttachEntityId;
			}
			if (other.CreateTimeMs != 0UL)
			{
				this.CreateTimeMs = other.CreateTimeMs;
			}
			if (other.CasterEntityId != 0U)
			{
				this.CasterEntityId = other.CasterEntityId;
			}
			if (other.LifeTimeMs != 0)
			{
				this.LifeTimeMs = other.LifeTimeMs;
			}
			this.triggerNameList_.Add(other.triggerNameList_);
			if (other.SummonUnitId != 0U)
			{
				this.SummonUnitId = other.SummonUnitId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD04 RID: 48388 RVA: 0x001FD835 File Offset: 0x001FBA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD05 RID: 48389 RVA: 0x001FD840 File Offset: 0x001FBA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.LifeTimeMs = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.triggerNameList_.AddEntriesFrom(ref input, SceneSummonUnitInfo._repeated_triggerNameList_codec);
						continue;
					}
					if (num == 32U)
					{
						this.AttachEntityId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.SummonUnitId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.CreateTimeMs = input.ReadUInt64();
						continue;
					}
					if (num == 96U)
					{
						this.CasterEntityId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CD2 RID: 19666
		private static readonly MessageParser<SceneSummonUnitInfo> _parser = new MessageParser<SceneSummonUnitInfo>(() => new SceneSummonUnitInfo());

		// Token: 0x04004CD3 RID: 19667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CD4 RID: 19668
		public const int AttachEntityIdFieldNumber = 4;

		// Token: 0x04004CD5 RID: 19669
		private uint attachEntityId_;

		// Token: 0x04004CD6 RID: 19670
		public const int CreateTimeMsFieldNumber = 11;

		// Token: 0x04004CD7 RID: 19671
		private ulong createTimeMs_;

		// Token: 0x04004CD8 RID: 19672
		public const int CasterEntityIdFieldNumber = 12;

		// Token: 0x04004CD9 RID: 19673
		private uint casterEntityId_;

		// Token: 0x04004CDA RID: 19674
		public const int LifeTimeMsFieldNumber = 1;

		// Token: 0x04004CDB RID: 19675
		private int lifeTimeMs_;

		// Token: 0x04004CDC RID: 19676
		public const int TriggerNameListFieldNumber = 2;

		// Token: 0x04004CDD RID: 19677
		private static readonly FieldCodec<string> _repeated_triggerNameList_codec = FieldCodec.ForString(18U);

		// Token: 0x04004CDE RID: 19678
		private readonly RepeatedField<string> triggerNameList_ = new RepeatedField<string>();

		// Token: 0x04004CDF RID: 19679
		public const int SummonUnitIdFieldNumber = 5;

		// Token: 0x04004CE0 RID: 19680
		private uint summonUnitId_;
	}
}
