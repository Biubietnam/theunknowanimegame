using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000357 RID: 855
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DailyTask : IMessage<DailyTask>, IMessage, IEquatable<DailyTask>, IDeepCloneable<DailyTask>, IBufferMessage
	{
		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x0006B3B0 File Offset: 0x000695B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyTask> Parser
		{
			get
			{
				return DailyTask._parser;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x0006B3B7 File Offset: 0x000695B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyTaskReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x0006B3C9 File Offset: 0x000695C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyTask.Descriptor;
			}
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x0006B3D0 File Offset: 0x000695D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyTask()
		{
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x0006B3D8 File Offset: 0x000695D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyTask(DailyTask other) : this()
		{
			this.isFinished_ = other.isFinished_;
			this.mainMissionId_ = other.mainMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x0006B409 File Offset: 0x00069609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyTask Clone()
		{
			return new DailyTask(this);
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x0006B411 File Offset: 0x00069611
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x0006B419 File Offset: 0x00069619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinished
		{
			get
			{
				return this.isFinished_;
			}
			set
			{
				this.isFinished_ = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x0006B422 File Offset: 0x00069622
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x0006B42A File Offset: 0x0006962A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainMissionId
		{
			get
			{
				return this.mainMissionId_;
			}
			set
			{
				this.mainMissionId_ = value;
			}
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x0006B433 File Offset: 0x00069633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyTask);
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x0006B441 File Offset: 0x00069641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyTask other)
		{
			return other != null && (other == this || (this.IsFinished == other.IsFinished && this.MainMissionId == other.MainMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x0006B480 File Offset: 0x00069680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsFinished)
			{
				num ^= this.IsFinished.GetHashCode();
			}
			if (this.MainMissionId != 0U)
			{
				num ^= this.MainMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x0006B4D8 File Offset: 0x000696D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x0006B4E0 File Offset: 0x000696E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x0006B4EC File Offset: 0x000696EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainMissionId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MainMissionId);
			}
			if (this.IsFinished)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsFinished);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x0006B548 File Offset: 0x00069748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsFinished)
			{
				num += 2;
			}
			if (this.MainMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x0006B594 File Offset: 0x00069794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsFinished)
			{
				this.IsFinished = other.IsFinished;
			}
			if (other.MainMissionId != 0U)
			{
				this.MainMissionId = other.MainMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x0006B5E4 File Offset: 0x000697E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x0006B5F0 File Offset: 0x000697F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsFinished = input.ReadBool();
					}
				}
				else
				{
					this.MainMissionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000F7C RID: 3964
		private static readonly MessageParser<DailyTask> _parser = new MessageParser<DailyTask>(() => new DailyTask());

		// Token: 0x04000F7D RID: 3965
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F7E RID: 3966
		public const int IsFinishedFieldNumber = 7;

		// Token: 0x04000F7F RID: 3967
		private bool isFinished_;

		// Token: 0x04000F80 RID: 3968
		public const int MainMissionIdFieldNumber = 3;

		// Token: 0x04000F81 RID: 3969
		private uint mainMissionId_;
	}
}
