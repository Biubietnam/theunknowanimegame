using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200012D RID: 301
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BlackInfo : IMessage<BlackInfo>, IMessage, IEquatable<BlackInfo>, IDeepCloneable<BlackInfo>, IBufferMessage
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00028A11 File Offset: 0x00026C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BlackInfo> Parser
		{
			get
			{
				return BlackInfo._parser;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00028A18 File Offset: 0x00026C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlackInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00028A2A File Offset: 0x00026C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackInfo.Descriptor;
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00028A31 File Offset: 0x00026C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackInfo()
		{
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00028A3C File Offset: 0x00026C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackInfo(BlackInfo other) : this()
		{
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.limitLevel_ = other.limitLevel_;
			this.banType_ = other.banType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00028A90 File Offset: 0x00026C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackInfo Clone()
		{
			return new BlackInfo(this);
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00028A98 File Offset: 0x00026C98
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00028AA0 File Offset: 0x00026CA0
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

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00028AA9 File Offset: 0x00026CA9
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x00028AB1 File Offset: 0x00026CB1
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00028ABA File Offset: 0x00026CBA
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x00028AC2 File Offset: 0x00026CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LimitLevel
		{
			get
			{
				return this.limitLevel_;
			}
			set
			{
				this.limitLevel_ = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00028ACB File Offset: 0x00026CCB
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x00028AD3 File Offset: 0x00026CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BanType
		{
			get
			{
				return this.banType_;
			}
			set
			{
				this.banType_ = value;
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00028ADC File Offset: 0x00026CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackInfo);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00028AEC File Offset: 0x00026CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackInfo other)
		{
			return other != null && (other == this || (this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.LimitLevel == other.LimitLevel && this.BanType == other.BanType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00028B58 File Offset: 0x00026D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.LimitLevel != 0U)
			{
				num ^= this.LimitLevel.GetHashCode();
			}
			if (this.BanType != 0U)
			{
				num ^= this.BanType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00028BE2 File Offset: 0x00026DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00028BEA File Offset: 0x00026DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00028BF4 File Offset: 0x00026DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EndTime);
			}
			if (this.LimitLevel != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LimitLevel);
			}
			if (this.BanType != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.BanType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00028C84 File Offset: 0x00026E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.LimitLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LimitLevel);
			}
			if (this.BanType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BanType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00028D0C File Offset: 0x00026F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.LimitLevel != 0U)
			{
				this.LimitLevel = other.LimitLevel;
			}
			if (other.BanType != 0U)
			{
				this.BanType = other.BanType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00028D84 File Offset: 0x00026F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00028D90 File Offset: 0x00026F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.LimitLevel = input.ReadUInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BanType = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040005E0 RID: 1504
		private static readonly MessageParser<BlackInfo> _parser = new MessageParser<BlackInfo>(() => new BlackInfo());

		// Token: 0x040005E1 RID: 1505
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005E2 RID: 1506
		public const int BeginTimeFieldNumber = 1;

		// Token: 0x040005E3 RID: 1507
		private long beginTime_;

		// Token: 0x040005E4 RID: 1508
		public const int EndTimeFieldNumber = 2;

		// Token: 0x040005E5 RID: 1509
		private long endTime_;

		// Token: 0x040005E6 RID: 1510
		public const int LimitLevelFieldNumber = 3;

		// Token: 0x040005E7 RID: 1511
		private uint limitLevel_;

		// Token: 0x040005E8 RID: 1512
		public const int BanTypeFieldNumber = 4;

		// Token: 0x040005E9 RID: 1513
		private uint banType_;
	}
}
