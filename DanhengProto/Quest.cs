using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D3D RID: 3389
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Quest : IMessage<Quest>, IMessage, IEquatable<Quest>, IDeepCloneable<Quest>, IBufferMessage
	{
		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x0600977B RID: 38779 RVA: 0x00193C7F File Offset: 0x00191E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Quest> Parser
		{
			get
			{
				return Quest._parser;
			}
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x0600977C RID: 38780 RVA: 0x00193C86 File Offset: 0x00191E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x0600977D RID: 38781 RVA: 0x00193C98 File Offset: 0x00191E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Quest.Descriptor;
			}
		}

		// Token: 0x0600977E RID: 38782 RVA: 0x00193C9F File Offset: 0x00191E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Quest()
		{
		}

		// Token: 0x0600977F RID: 38783 RVA: 0x00193CB4 File Offset: 0x00191EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Quest(Quest other) : this()
		{
			this.finishTime_ = other.finishTime_;
			this.status_ = other.status_;
			this.id_ = other.id_;
			this.iAMIDOAFKKD_ = other.iAMIDOAFKKD_.Clone();
			this.progress_ = other.progress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009780 RID: 38784 RVA: 0x00193D19 File Offset: 0x00191F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Quest Clone()
		{
			return new Quest(this);
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x06009781 RID: 38785 RVA: 0x00193D21 File Offset: 0x00191F21
		// (set) Token: 0x06009782 RID: 38786 RVA: 0x00193D29 File Offset: 0x00191F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FinishTime
		{
			get
			{
				return this.finishTime_;
			}
			set
			{
				this.finishTime_ = value;
			}
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x06009783 RID: 38787 RVA: 0x00193D32 File Offset: 0x00191F32
		// (set) Token: 0x06009784 RID: 38788 RVA: 0x00193D3A File Offset: 0x00191F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestStatus Status
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

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x06009785 RID: 38789 RVA: 0x00193D43 File Offset: 0x00191F43
		// (set) Token: 0x06009786 RID: 38790 RVA: 0x00193D4B File Offset: 0x00191F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x06009787 RID: 38791 RVA: 0x00193D54 File Offset: 0x00191F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IAMIDOAFKKD
		{
			get
			{
				return this.iAMIDOAFKKD_;
			}
		}

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x06009788 RID: 38792 RVA: 0x00193D5C File Offset: 0x00191F5C
		// (set) Token: 0x06009789 RID: 38793 RVA: 0x00193D64 File Offset: 0x00191F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x00193D6D File Offset: 0x00191F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Quest);
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x00193D7C File Offset: 0x00191F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Quest other)
		{
			return other != null && (other == this || (this.FinishTime == other.FinishTime && this.Status == other.Status && this.Id == other.Id && this.iAMIDOAFKKD_.Equals(other.iAMIDOAFKKD_) && this.Progress == other.Progress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x00193DFC File Offset: 0x00191FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FinishTime != 0L)
			{
				num ^= this.FinishTime.GetHashCode();
			}
			if (this.Status != QuestStatus.QuestNone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.iAMIDOAFKKD_.GetHashCode();
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x00193E9A File Offset: 0x0019209A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x00193EA2 File Offset: 0x001920A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600978F RID: 38799 RVA: 0x00193EAC File Offset: 0x001920AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != QuestStatus.QuestNone)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Status);
			}
			if (this.Progress != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Progress);
			}
			this.iAMIDOAFKKD_.WriteTo(ref output, Quest._repeated_iAMIDOAFKKD_codec);
			if (this.FinishTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.FinishTime);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009790 RID: 38800 RVA: 0x00193F50 File Offset: 0x00192150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FinishTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FinishTime);
			}
			if (this.Status != QuestStatus.QuestNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			num += this.iAMIDOAFKKD_.CalculateSize(Quest._repeated_iAMIDOAFKKD_codec);
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009791 RID: 38801 RVA: 0x00193FEC File Offset: 0x001921EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Quest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FinishTime != 0L)
			{
				this.FinishTime = other.FinishTime;
			}
			if (other.Status != QuestStatus.QuestNone)
			{
				this.Status = other.Status;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this.iAMIDOAFKKD_.Add(other.iAMIDOAFKKD_);
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009792 RID: 38802 RVA: 0x00194075 File Offset: 0x00192275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009793 RID: 38803 RVA: 0x00194080 File Offset: 0x00192280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 104U)
				{
					if (num == 48U)
					{
						this.Status = (QuestStatus)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.Progress = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						goto IL_5A;
					}
				}
				else
				{
					if (num == 106U)
					{
						goto IL_5A;
					}
					if (num == 112U)
					{
						this.FinishTime = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_5A:
				this.iAMIDOAFKKD_.AddEntriesFrom(ref input, Quest._repeated_iAMIDOAFKKD_codec);
			}
		}

		// Token: 0x04003AE9 RID: 15081
		private static readonly MessageParser<Quest> _parser = new MessageParser<Quest>(() => new Quest());

		// Token: 0x04003AEA RID: 15082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AEB RID: 15083
		public const int FinishTimeFieldNumber = 14;

		// Token: 0x04003AEC RID: 15084
		private long finishTime_;

		// Token: 0x04003AED RID: 15085
		public const int StatusFieldNumber = 6;

		// Token: 0x04003AEE RID: 15086
		private QuestStatus status_;

		// Token: 0x04003AEF RID: 15087
		public const int IdFieldNumber = 15;

		// Token: 0x04003AF0 RID: 15088
		private uint id_;

		// Token: 0x04003AF1 RID: 15089
		public const int IAMIDOAFKKDFieldNumber = 13;

		// Token: 0x04003AF2 RID: 15090
		private static readonly FieldCodec<uint> _repeated_iAMIDOAFKKD_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04003AF3 RID: 15091
		private readonly RepeatedField<uint> iAMIDOAFKKD_ = new RepeatedField<uint>();

		// Token: 0x04003AF4 RID: 15092
		public const int ProgressFieldNumber = 12;

		// Token: 0x04003AF5 RID: 15093
		private uint progress_;
	}
}
