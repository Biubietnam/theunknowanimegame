using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200034B RID: 843
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DailyActivityInfo : IMessage<DailyActivityInfo>, IMessage, IEquatable<DailyActivityInfo>, IDeepCloneable<DailyActivityInfo>, IBufferMessage
	{
		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x0006A121 File Offset: 0x00068321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyActivityInfo> Parser
		{
			get
			{
				return DailyActivityInfo._parser;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x0006A128 File Offset: 0x00068328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyActivityInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x0006A13A File Offset: 0x0006833A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyActivityInfo.Descriptor;
			}
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x0006A141 File Offset: 0x00068341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyActivityInfo()
		{
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x0006A14C File Offset: 0x0006834C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyActivityInfo(DailyActivityInfo other) : this()
		{
			this.worldLevel_ = other.worldLevel_;
			this.dailyActivePoint_ = other.dailyActivePoint_;
			this.isHasTaken_ = other.isHasTaken_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x0006A1A0 File Offset: 0x000683A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyActivityInfo Clone()
		{
			return new DailyActivityInfo(this);
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x0006A1A8 File Offset: 0x000683A8
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x0006A1B0 File Offset: 0x000683B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x0006A1B9 File Offset: 0x000683B9
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x0006A1C1 File Offset: 0x000683C1
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

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x0006A1CA File Offset: 0x000683CA
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x0006A1D2 File Offset: 0x000683D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsHasTaken
		{
			get
			{
				return this.isHasTaken_;
			}
			set
			{
				this.isHasTaken_ = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x0006A1DB File Offset: 0x000683DB
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x0006A1E3 File Offset: 0x000683E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x0006A1EC File Offset: 0x000683EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyActivityInfo);
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x0006A1FC File Offset: 0x000683FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyActivityInfo other)
		{
			return other != null && (other == this || (this.WorldLevel == other.WorldLevel && this.DailyActivePoint == other.DailyActivePoint && this.IsHasTaken == other.IsHasTaken && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x0006A268 File Offset: 0x00068468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.DailyActivePoint != 0U)
			{
				num ^= this.DailyActivePoint.GetHashCode();
			}
			if (this.IsHasTaken)
			{
				num ^= this.IsHasTaken.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x0006A2F2 File Offset: 0x000684F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x0006A2FA File Offset: 0x000684FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x0006A304 File Offset: 0x00068504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DailyActivePoint != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.DailyActivePoint);
			}
			if (this.IsHasTaken)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsHasTaken);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Level);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x0006A398 File Offset: 0x00068598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.DailyActivePoint != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DailyActivePoint);
			}
			if (this.IsHasTaken)
			{
				num += 2;
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x0006A414 File Offset: 0x00068614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.DailyActivePoint != 0U)
			{
				this.DailyActivePoint = other.DailyActivePoint;
			}
			if (other.IsHasTaken)
			{
				this.IsHasTaken = other.IsHasTaken;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x0006A48C File Offset: 0x0006868C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x0006A498 File Offset: 0x00068698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.DailyActivePoint = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsHasTaken = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F54 RID: 3924
		private static readonly MessageParser<DailyActivityInfo> _parser = new MessageParser<DailyActivityInfo>(() => new DailyActivityInfo());

		// Token: 0x04000F55 RID: 3925
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F56 RID: 3926
		public const int WorldLevelFieldNumber = 15;

		// Token: 0x04000F57 RID: 3927
		private uint worldLevel_;

		// Token: 0x04000F58 RID: 3928
		public const int DailyActivePointFieldNumber = 3;

		// Token: 0x04000F59 RID: 3929
		private uint dailyActivePoint_;

		// Token: 0x04000F5A RID: 3930
		public const int IsHasTakenFieldNumber = 4;

		// Token: 0x04000F5B RID: 3931
		private bool isHasTaken_;

		// Token: 0x04000F5C RID: 3932
		public const int LevelFieldNumber = 11;

		// Token: 0x04000F5D RID: 3933
		private uint level_;
	}
}
