using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000349 RID: 841
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DailyActiveInfoNotify : IMessage<DailyActiveInfoNotify>, IMessage, IEquatable<DailyActiveInfoNotify>, IDeepCloneable<DailyActiveInfoNotify>, IBufferMessage
	{
		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x00069D13 File Offset: 0x00067F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyActiveInfoNotify> Parser
		{
			get
			{
				return DailyActiveInfoNotify._parser;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x00069D1A File Offset: 0x00067F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyActiveInfoNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x00069D2C File Offset: 0x00067F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyActiveInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00069D33 File Offset: 0x00067F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyActiveInfoNotify()
		{
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00069D54 File Offset: 0x00067F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyActiveInfoNotify(DailyActiveInfoNotify other) : this()
		{
			this.dailyActivePoint_ = other.dailyActivePoint_;
			this.dailyActiveLevelList_ = other.dailyActiveLevelList_.Clone();
			this.dailyActiveQuestIdList_ = other.dailyActiveQuestIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00069DA6 File Offset: 0x00067FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyActiveInfoNotify Clone()
		{
			return new DailyActiveInfoNotify(this);
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x00069DAE File Offset: 0x00067FAE
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x00069DB6 File Offset: 0x00067FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DailyActivePoint
		{
			get
			{
				return this.dailyActivePoint_;
			}
			set
			{
				this.dailyActivePoint_ = value;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x00069DBF File Offset: 0x00067FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DailyActivityInfo> DailyActiveLevelList
		{
			get
			{
				return this.dailyActiveLevelList_;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x00069DC7 File Offset: 0x00067FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DailyActiveQuestIdList
		{
			get
			{
				return this.dailyActiveQuestIdList_;
			}
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00069DCF File Offset: 0x00067FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyActiveInfoNotify);
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00069DE0 File Offset: 0x00067FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyActiveInfoNotify other)
		{
			return other != null && (other == this || (this.DailyActivePoint == other.DailyActivePoint && this.dailyActiveLevelList_.Equals(other.dailyActiveLevelList_) && this.dailyActiveQuestIdList_.Equals(other.dailyActiveQuestIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00069E44 File Offset: 0x00068044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DailyActivePoint != 0U)
			{
				num ^= this.DailyActivePoint.GetHashCode();
			}
			num ^= this.dailyActiveLevelList_.GetHashCode();
			num ^= this.dailyActiveQuestIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00069E9F File Offset: 0x0006809F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x00069EA7 File Offset: 0x000680A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00069EB0 File Offset: 0x000680B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dailyActiveQuestIdList_.WriteTo(ref output, DailyActiveInfoNotify._repeated_dailyActiveQuestIdList_codec);
			if (this.DailyActivePoint != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.DailyActivePoint);
			}
			this.dailyActiveLevelList_.WriteTo(ref output, DailyActiveInfoNotify._repeated_dailyActiveLevelList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00069F10 File Offset: 0x00068110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DailyActivePoint != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DailyActivePoint);
			}
			num += this.dailyActiveLevelList_.CalculateSize(DailyActiveInfoNotify._repeated_dailyActiveLevelList_codec);
			num += this.dailyActiveQuestIdList_.CalculateSize(DailyActiveInfoNotify._repeated_dailyActiveQuestIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00069F74 File Offset: 0x00068174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyActiveInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DailyActivePoint != 0U)
			{
				this.DailyActivePoint = other.DailyActivePoint;
			}
			this.dailyActiveLevelList_.Add(other.dailyActiveLevelList_);
			this.dailyActiveQuestIdList_.Add(other.dailyActiveQuestIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00069FD2 File Offset: 0x000681D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00069FDC File Offset: 0x000681DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.dailyActiveQuestIdList_.AddEntriesFrom(ref input, DailyActiveInfoNotify._repeated_dailyActiveQuestIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.DailyActivePoint = input.ReadUInt32();
						continue;
					}
					if (num == 98U)
					{
						this.dailyActiveLevelList_.AddEntriesFrom(ref input, DailyActiveInfoNotify._repeated_dailyActiveLevelList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F49 RID: 3913
		private static readonly MessageParser<DailyActiveInfoNotify> _parser = new MessageParser<DailyActiveInfoNotify>(() => new DailyActiveInfoNotify());

		// Token: 0x04000F4A RID: 3914
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F4B RID: 3915
		public const int DailyActivePointFieldNumber = 9;

		// Token: 0x04000F4C RID: 3916
		private uint dailyActivePoint_;

		// Token: 0x04000F4D RID: 3917
		public const int DailyActiveLevelListFieldNumber = 12;

		// Token: 0x04000F4E RID: 3918
		private static readonly FieldCodec<DailyActivityInfo> _repeated_dailyActiveLevelList_codec = FieldCodec.ForMessage<DailyActivityInfo>(98U, DailyActivityInfo.Parser);

		// Token: 0x04000F4F RID: 3919
		private readonly RepeatedField<DailyActivityInfo> dailyActiveLevelList_ = new RepeatedField<DailyActivityInfo>();

		// Token: 0x04000F50 RID: 3920
		public const int DailyActiveQuestIdListFieldNumber = 2;

		// Token: 0x04000F51 RID: 3921
		private static readonly FieldCodec<uint> _repeated_dailyActiveQuestIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04000F52 RID: 3922
		private readonly RepeatedField<uint> dailyActiveQuestIdList_ = new RepeatedField<uint>();
	}
}
