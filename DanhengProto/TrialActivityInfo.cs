using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013A3 RID: 5027
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TrialActivityInfo : IMessage<TrialActivityInfo>, IMessage, IEquatable<TrialActivityInfo>, IDeepCloneable<TrialActivityInfo>, IBufferMessage
	{
		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x0600E062 RID: 57442 RVA: 0x00255A10 File Offset: 0x00253C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrialActivityInfo> Parser
		{
			get
			{
				return TrialActivityInfo._parser;
			}
		}

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x0600E063 RID: 57443 RVA: 0x00255A17 File Offset: 0x00253C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TrialActivityInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x0600E064 RID: 57444 RVA: 0x00255A29 File Offset: 0x00253C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600E065 RID: 57445 RVA: 0x00255A30 File Offset: 0x00253C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialActivityInfo()
		{
		}

		// Token: 0x0600E066 RID: 57446 RVA: 0x00255A38 File Offset: 0x00253C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialActivityInfo(TrialActivityInfo other) : this()
		{
			this.takenReward_ = other.takenReward_;
			this.stageId_ = other.stageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E067 RID: 57447 RVA: 0x00255A69 File Offset: 0x00253C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialActivityInfo Clone()
		{
			return new TrialActivityInfo(this);
		}

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x0600E068 RID: 57448 RVA: 0x00255A71 File Offset: 0x00253C71
		// (set) Token: 0x0600E069 RID: 57449 RVA: 0x00255A79 File Offset: 0x00253C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TakenReward
		{
			get
			{
				return this.takenReward_;
			}
			set
			{
				this.takenReward_ = value;
			}
		}

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x0600E06A RID: 57450 RVA: 0x00255A82 File Offset: 0x00253C82
		// (set) Token: 0x0600E06B RID: 57451 RVA: 0x00255A8A File Offset: 0x00253C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x0600E06C RID: 57452 RVA: 0x00255A93 File Offset: 0x00253C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialActivityInfo);
		}

		// Token: 0x0600E06D RID: 57453 RVA: 0x00255AA1 File Offset: 0x00253CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialActivityInfo other)
		{
			return other != null && (other == this || (this.TakenReward == other.TakenReward && this.StageId == other.StageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E06E RID: 57454 RVA: 0x00255AE0 File Offset: 0x00253CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TakenReward)
			{
				num ^= this.TakenReward.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E06F RID: 57455 RVA: 0x00255B38 File Offset: 0x00253D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E070 RID: 57456 RVA: 0x00255B40 File Offset: 0x00253D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E071 RID: 57457 RVA: 0x00255B4C File Offset: 0x00253D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.StageId);
			}
			if (this.TakenReward)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.TakenReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E072 RID: 57458 RVA: 0x00255BA8 File Offset: 0x00253DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TakenReward)
			{
				num += 2;
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E073 RID: 57459 RVA: 0x00255BF4 File Offset: 0x00253DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TakenReward)
			{
				this.TakenReward = other.TakenReward;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E074 RID: 57460 RVA: 0x00255C44 File Offset: 0x00253E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E075 RID: 57461 RVA: 0x00255C50 File Offset: 0x00253E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TakenReward = input.ReadBool();
					}
				}
				else
				{
					this.StageId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400595E RID: 22878
		private static readonly MessageParser<TrialActivityInfo> _parser = new MessageParser<TrialActivityInfo>(() => new TrialActivityInfo());

		// Token: 0x0400595F RID: 22879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005960 RID: 22880
		public const int TakenRewardFieldNumber = 13;

		// Token: 0x04005961 RID: 22881
		private bool takenReward_;

		// Token: 0x04005962 RID: 22882
		public const int StageIdFieldNumber = 11;

		// Token: 0x04005963 RID: 22883
		private uint stageId_;
	}
}
