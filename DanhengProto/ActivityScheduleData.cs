using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200003B RID: 59
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActivityScheduleData : IMessage<ActivityScheduleData>, IMessage, IEquatable<ActivityScheduleData>, IDeepCloneable<ActivityScheduleData>, IBufferMessage
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00007891 File Offset: 0x00005A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityScheduleData> Parser
		{
			get
			{
				return ActivityScheduleData._parser;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00007898 File Offset: 0x00005A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ActivityScheduleDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000078AA File Offset: 0x00005AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityScheduleData.Descriptor;
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000078B1 File Offset: 0x00005AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityScheduleData()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000078BC File Offset: 0x00005ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityScheduleData(ActivityScheduleData other) : this()
		{
			this.activityId_ = other.activityId_;
			this.panelId_ = other.panelId_;
			this.endTime_ = other.endTime_;
			this.beginTime_ = other.beginTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00007910 File Offset: 0x00005B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityScheduleData Clone()
		{
			return new ActivityScheduleData(this);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00007918 File Offset: 0x00005B18
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00007920 File Offset: 0x00005B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00007929 File Offset: 0x00005B29
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00007931 File Offset: 0x00005B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PanelId
		{
			get
			{
				return this.panelId_;
			}
			set
			{
				this.panelId_ = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000793A File Offset: 0x00005B3A
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00007942 File Offset: 0x00005B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000794B File Offset: 0x00005B4B
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00007953 File Offset: 0x00005B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000795C File Offset: 0x00005B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityScheduleData);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000796C File Offset: 0x00005B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityScheduleData other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.PanelId == other.PanelId && this.EndTime == other.EndTime && this.BeginTime == other.BeginTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000079D8 File Offset: 0x00005BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0U)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.PanelId != 0U)
			{
				num ^= this.PanelId.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00007A62 File Offset: 0x00005C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00007A6A File Offset: 0x00005C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00007A74 File Offset: 0x00005C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PanelId);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.BeginTime);
			}
			if (this.ActivityId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ActivityId);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00007B04 File Offset: 0x00005D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ActivityId);
			}
			if (this.PanelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PanelId);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00007B8C File Offset: 0x00005D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityScheduleData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0U)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00007C04 File Offset: 0x00005E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00007C10 File Offset: 0x00005E10
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
						this.PanelId = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ActivityId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000D0 RID: 208
		private static readonly MessageParser<ActivityScheduleData> _parser = new MessageParser<ActivityScheduleData>(() => new ActivityScheduleData());

		// Token: 0x040000D1 RID: 209
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000D2 RID: 210
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x040000D3 RID: 211
		private uint activityId_;

		// Token: 0x040000D4 RID: 212
		public const int PanelIdFieldNumber = 1;

		// Token: 0x040000D5 RID: 213
		private uint panelId_;

		// Token: 0x040000D6 RID: 214
		public const int EndTimeFieldNumber = 15;

		// Token: 0x040000D7 RID: 215
		private long endTime_;

		// Token: 0x040000D8 RID: 216
		public const int BeginTimeFieldNumber = 6;

		// Token: 0x040000D9 RID: 217
		private long beginTime_;
	}
}
