using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FED RID: 4077
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournLevelInfo : IMessage<RogueTournLevelInfo>, IMessage, IEquatable<RogueTournLevelInfo>, IDeepCloneable<RogueTournLevelInfo>, IBufferMessage
	{
		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600B57A RID: 46458 RVA: 0x001E7267 File Offset: 0x001E5467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournLevelInfo> Parser
		{
			get
			{
				return RogueTournLevelInfo._parser;
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600B57B RID: 46459 RVA: 0x001E726E File Offset: 0x001E546E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournLevelInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600B57C RID: 46460 RVA: 0x001E7280 File Offset: 0x001E5480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600B57D RID: 46461 RVA: 0x001E7287 File Offset: 0x001E5487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevelInfo()
		{
		}

		// Token: 0x0600B57E RID: 46462 RVA: 0x001E729C File Offset: 0x001E549C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevelInfo(RogueTournLevelInfo other) : this()
		{
			this.levelInfoList_ = other.levelInfoList_.Clone();
			this.curLevelIndex_ = other.curLevelIndex_;
			this.status_ = other.status_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B57F RID: 46463 RVA: 0x001E72F5 File Offset: 0x001E54F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLevelInfo Clone()
		{
			return new RogueTournLevelInfo(this);
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600B580 RID: 46464 RVA: 0x001E72FD File Offset: 0x001E54FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTournLevel> LevelInfoList
		{
			get
			{
				return this.levelInfoList_;
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600B581 RID: 46465 RVA: 0x001E7305 File Offset: 0x001E5505
		// (set) Token: 0x0600B582 RID: 46466 RVA: 0x001E730D File Offset: 0x001E550D
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

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600B583 RID: 46467 RVA: 0x001E7316 File Offset: 0x001E5516
		// (set) Token: 0x0600B584 RID: 46468 RVA: 0x001E731E File Offset: 0x001E551E
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

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600B585 RID: 46469 RVA: 0x001E7327 File Offset: 0x001E5527
		// (set) Token: 0x0600B586 RID: 46470 RVA: 0x001E732F File Offset: 0x001E552F
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

		// Token: 0x0600B587 RID: 46471 RVA: 0x001E7338 File Offset: 0x001E5538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournLevelInfo);
		}

		// Token: 0x0600B588 RID: 46472 RVA: 0x001E7348 File Offset: 0x001E5548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournLevelInfo other)
		{
			return other != null && (other == this || (this.levelInfoList_.Equals(other.levelInfoList_) && this.CurLevelIndex == other.CurLevelIndex && this.Status == other.Status && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B589 RID: 46473 RVA: 0x001E73B8 File Offset: 0x001E55B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.levelInfoList_.GetHashCode();
			if (this.CurLevelIndex != 0U)
			{
				num ^= this.CurLevelIndex.GetHashCode();
			}
			if (this.Status != RogueTournLevelStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.Reason != RogueTournSettleReason.None)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B58A RID: 46474 RVA: 0x001E7443 File Offset: 0x001E5643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B58B RID: 46475 RVA: 0x001E744B File Offset: 0x001E564B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B58C RID: 46476 RVA: 0x001E7454 File Offset: 0x001E5654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != RogueTournSettleReason.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Reason);
			}
			if (this.Status != RogueTournLevelStatus.None)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Status);
			}
			if (this.CurLevelIndex != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CurLevelIndex);
			}
			this.levelInfoList_.WriteTo(ref output, RogueTournLevelInfo._repeated_levelInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B58D RID: 46477 RVA: 0x001E74DC File Offset: 0x001E56DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.levelInfoList_.CalculateSize(RogueTournLevelInfo._repeated_levelInfoList_codec);
			if (this.CurLevelIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurLevelIndex);
			}
			if (this.Status != RogueTournLevelStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.Reason != RogueTournSettleReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B58E RID: 46478 RVA: 0x001E7560 File Offset: 0x001E5760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.levelInfoList_.Add(other.levelInfoList_);
			if (other.CurLevelIndex != 0U)
			{
				this.CurLevelIndex = other.CurLevelIndex;
			}
			if (other.Status != RogueTournLevelStatus.None)
			{
				this.Status = other.Status;
			}
			if (other.Reason != RogueTournSettleReason.None)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B58F RID: 46479 RVA: 0x001E75D5 File Offset: 0x001E57D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B590 RID: 46480 RVA: 0x001E75E0 File Offset: 0x001E57E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.Reason = (RogueTournSettleReason)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						this.Status = (RogueTournLevelStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.CurLevelIndex = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						this.levelInfoList_.AddEntriesFrom(ref input, RogueTournLevelInfo._repeated_levelInfoList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004998 RID: 18840
		private static readonly MessageParser<RogueTournLevelInfo> _parser = new MessageParser<RogueTournLevelInfo>(() => new RogueTournLevelInfo());

		// Token: 0x04004999 RID: 18841
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400499A RID: 18842
		public const int LevelInfoListFieldNumber = 13;

		// Token: 0x0400499B RID: 18843
		private static readonly FieldCodec<RogueTournLevel> _repeated_levelInfoList_codec = FieldCodec.ForMessage<RogueTournLevel>(106U, RogueTournLevel.Parser);

		// Token: 0x0400499C RID: 18844
		private readonly RepeatedField<RogueTournLevel> levelInfoList_ = new RepeatedField<RogueTournLevel>();

		// Token: 0x0400499D RID: 18845
		public const int CurLevelIndexFieldNumber = 8;

		// Token: 0x0400499E RID: 18846
		private uint curLevelIndex_;

		// Token: 0x0400499F RID: 18847
		public const int StatusFieldNumber = 6;

		// Token: 0x040049A0 RID: 18848
		private RogueTournLevelStatus status_;

		// Token: 0x040049A1 RID: 18849
		public const int ReasonFieldNumber = 1;

		// Token: 0x040049A2 RID: 18850
		private RogueTournSettleReason reason_;
	}
}
