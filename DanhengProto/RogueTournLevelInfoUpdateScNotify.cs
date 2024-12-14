using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FEF RID: 4079
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournLevelInfoUpdateScNotify : IMessage<RogueTournLevelInfoUpdateScNotify>, IMessage, IEquatable<RogueTournLevelInfoUpdateScNotify>, IDeepCloneable<RogueTournLevelInfoUpdateScNotify>, IBufferMessage
	{
		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600B594 RID: 46484 RVA: 0x001E776B File Offset: 0x001E596B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournLevelInfoUpdateScNotify> Parser
		{
			get
			{
				return RogueTournLevelInfoUpdateScNotify._parser;
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600B595 RID: 46485 RVA: 0x001E7772 File Offset: 0x001E5972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournLevelInfoUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600B596 RID: 46486 RVA: 0x001E7784 File Offset: 0x001E5984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournLevelInfoUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600B597 RID: 46487 RVA: 0x001E778B File Offset: 0x001E598B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevelInfoUpdateScNotify()
		{
		}

		// Token: 0x0600B598 RID: 46488 RVA: 0x001E77A0 File Offset: 0x001E59A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevelInfoUpdateScNotify(RogueTournLevelInfoUpdateScNotify other) : this()
		{
			this.status_ = other.status_;
			this.reason_ = other.reason_;
			this.levelInfoList_ = other.levelInfoList_.Clone();
			this.curLevelIndex_ = other.curLevelIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B599 RID: 46489 RVA: 0x001E77F9 File Offset: 0x001E59F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevelInfoUpdateScNotify Clone()
		{
			return new RogueTournLevelInfoUpdateScNotify(this);
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600B59A RID: 46490 RVA: 0x001E7801 File Offset: 0x001E5A01
		// (set) Token: 0x0600B59B RID: 46491 RVA: 0x001E7809 File Offset: 0x001E5A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevelStatus Status
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

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600B59C RID: 46492 RVA: 0x001E7812 File Offset: 0x001E5A12
		// (set) Token: 0x0600B59D RID: 46493 RVA: 0x001E781A File Offset: 0x001E5A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSettleReason Reason
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

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600B59E RID: 46494 RVA: 0x001E7823 File Offset: 0x001E5A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTournLevel> LevelInfoList
		{
			get
			{
				return this.levelInfoList_;
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600B59F RID: 46495 RVA: 0x001E782B File Offset: 0x001E5A2B
		// (set) Token: 0x0600B5A0 RID: 46496 RVA: 0x001E7833 File Offset: 0x001E5A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurLevelIndex
		{
			get
			{
				return this.curLevelIndex_;
			}
			set
			{
				this.curLevelIndex_ = value;
			}
		}

		// Token: 0x0600B5A1 RID: 46497 RVA: 0x001E783C File Offset: 0x001E5A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournLevelInfoUpdateScNotify);
		}

		// Token: 0x0600B5A2 RID: 46498 RVA: 0x001E784C File Offset: 0x001E5A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournLevelInfoUpdateScNotify other)
		{
			return other != null && (other == this || (this.Status == other.Status && this.Reason == other.Reason && this.levelInfoList_.Equals(other.levelInfoList_) && this.CurLevelIndex == other.CurLevelIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B5A3 RID: 46499 RVA: 0x001E78BC File Offset: 0x001E5ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Status != RogueTournLevelStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.Reason != RogueTournSettleReason.None)
			{
				num ^= this.Reason.GetHashCode();
			}
			num ^= this.levelInfoList_.GetHashCode();
			if (this.CurLevelIndex != 0U)
			{
				num ^= this.CurLevelIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B5A4 RID: 46500 RVA: 0x001E7947 File Offset: 0x001E5B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B5A5 RID: 46501 RVA: 0x001E794F File Offset: 0x001E5B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5A6 RID: 46502 RVA: 0x001E7958 File Offset: 0x001E5B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != RogueTournSettleReason.None)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Reason);
			}
			if (this.Status != RogueTournLevelStatus.None)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Status);
			}
			this.levelInfoList_.WriteTo(ref output, RogueTournLevelInfoUpdateScNotify._repeated_levelInfoList_codec);
			if (this.CurLevelIndex != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CurLevelIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x001E79E0 File Offset: 0x001E5BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Status != RogueTournLevelStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.Reason != RogueTournSettleReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			num += this.levelInfoList_.CalculateSize(RogueTournLevelInfoUpdateScNotify._repeated_levelInfoList_codec);
			if (this.CurLevelIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurLevelIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B5A8 RID: 46504 RVA: 0x001E7A64 File Offset: 0x001E5C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournLevelInfoUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Status != RogueTournLevelStatus.None)
			{
				this.Status = other.Status;
			}
			if (other.Reason != RogueTournSettleReason.None)
			{
				this.Reason = other.Reason;
			}
			this.levelInfoList_.Add(other.levelInfoList_);
			if (other.CurLevelIndex != 0U)
			{
				this.CurLevelIndex = other.CurLevelIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5A9 RID: 46505 RVA: 0x001E7AD9 File Offset: 0x001E5CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5AA RID: 46506 RVA: 0x001E7AE4 File Offset: 0x001E5CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.Reason = (RogueTournSettleReason)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.Status = (RogueTournLevelStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.levelInfoList_.AddEntriesFrom(ref input, RogueTournLevelInfoUpdateScNotify._repeated_levelInfoList_codec);
						continue;
					}
					if (num == 72U)
					{
						this.CurLevelIndex = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040049A4 RID: 18852
		private static readonly MessageParser<RogueTournLevelInfoUpdateScNotify> _parser = new MessageParser<RogueTournLevelInfoUpdateScNotify>(() => new RogueTournLevelInfoUpdateScNotify());

		// Token: 0x040049A5 RID: 18853
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049A6 RID: 18854
		public const int StatusFieldNumber = 5;

		// Token: 0x040049A7 RID: 18855
		private RogueTournLevelStatus status_;

		// Token: 0x040049A8 RID: 18856
		public const int ReasonFieldNumber = 4;

		// Token: 0x040049A9 RID: 18857
		private RogueTournSettleReason reason_;

		// Token: 0x040049AA RID: 18858
		public const int LevelInfoListFieldNumber = 8;

		// Token: 0x040049AB RID: 18859
		private static readonly FieldCodec<RogueTournLevel> _repeated_levelInfoList_codec = FieldCodec.ForMessage<RogueTournLevel>(66U, RogueTournLevel.Parser);

		// Token: 0x040049AC RID: 18860
		private readonly RepeatedField<RogueTournLevel> levelInfoList_ = new RepeatedField<RogueTournLevel>();

		// Token: 0x040049AD RID: 18861
		public const int CurLevelIndexFieldNumber = 9;

		// Token: 0x040049AE RID: 18862
		private uint curLevelIndex_;
	}
}
