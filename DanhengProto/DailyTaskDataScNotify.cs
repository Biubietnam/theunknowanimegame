using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000359 RID: 857
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DailyTaskDataScNotify : IMessage<DailyTaskDataScNotify>, IMessage, IEquatable<DailyTaskDataScNotify>, IDeepCloneable<DailyTaskDataScNotify>, IBufferMessage
	{
		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x0600263D RID: 9789 RVA: 0x0006B6E5 File Offset: 0x000698E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyTaskDataScNotify> Parser
		{
			get
			{
				return DailyTaskDataScNotify._parser;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x0006B6EC File Offset: 0x000698EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyTaskDataScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x0006B6FE File Offset: 0x000698FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyTaskDataScNotify.Descriptor;
			}
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0006B705 File Offset: 0x00069905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyTaskDataScNotify()
		{
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x0006B718 File Offset: 0x00069918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyTaskDataScNotify(DailyTaskDataScNotify other) : this()
		{
			this.finishedNum_ = other.finishedNum_;
			this.dailyTaskList_ = other.dailyTaskList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x0006B74E File Offset: 0x0006994E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyTaskDataScNotify Clone()
		{
			return new DailyTaskDataScNotify(this);
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x0006B756 File Offset: 0x00069956
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x0006B75E File Offset: 0x0006995E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FinishedNum
		{
			get
			{
				return this.finishedNum_;
			}
			set
			{
				this.finishedNum_ = value;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x0006B767 File Offset: 0x00069967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DailyTask> DailyTaskList
		{
			get
			{
				return this.dailyTaskList_;
			}
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x0006B76F File Offset: 0x0006996F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyTaskDataScNotify);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x0006B780 File Offset: 0x00069980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyTaskDataScNotify other)
		{
			return other != null && (other == this || (this.FinishedNum == other.FinishedNum && this.dailyTaskList_.Equals(other.dailyTaskList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x0006B7D0 File Offset: 0x000699D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FinishedNum != 0U)
			{
				num ^= this.FinishedNum.GetHashCode();
			}
			num ^= this.dailyTaskList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x0006B81D File Offset: 0x00069A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x0006B825 File Offset: 0x00069A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x0006B830 File Offset: 0x00069A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dailyTaskList_.WriteTo(ref output, DailyTaskDataScNotify._repeated_dailyTaskList_codec);
			if (this.FinishedNum != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.FinishedNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x0006B880 File Offset: 0x00069A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FinishedNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FinishedNum);
			}
			num += this.dailyTaskList_.CalculateSize(DailyTaskDataScNotify._repeated_dailyTaskList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x0006B8D4 File Offset: 0x00069AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyTaskDataScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FinishedNum != 0U)
			{
				this.FinishedNum = other.FinishedNum;
			}
			this.dailyTaskList_.Add(other.dailyTaskList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x0006B921 File Offset: 0x00069B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x0006B92C File Offset: 0x00069B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FinishedNum = input.ReadUInt32();
					}
				}
				else
				{
					this.dailyTaskList_.AddEntriesFrom(ref input, DailyTaskDataScNotify._repeated_dailyTaskList_codec);
				}
			}
		}

		// Token: 0x04000F83 RID: 3971
		private static readonly MessageParser<DailyTaskDataScNotify> _parser = new MessageParser<DailyTaskDataScNotify>(() => new DailyTaskDataScNotify());

		// Token: 0x04000F84 RID: 3972
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F85 RID: 3973
		public const int FinishedNumFieldNumber = 11;

		// Token: 0x04000F86 RID: 3974
		private uint finishedNum_;

		// Token: 0x04000F87 RID: 3975
		public const int DailyTaskListFieldNumber = 3;

		// Token: 0x04000F88 RID: 3976
		private static readonly FieldCodec<DailyTask> _repeated_dailyTaskList_codec = FieldCodec.ForMessage<DailyTask>(26U, DailyTask.Parser);

		// Token: 0x04000F89 RID: 3977
		private readonly RepeatedField<DailyTask> dailyTaskList_ = new RepeatedField<DailyTask>();
	}
}
