using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004F7 RID: 1271
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExtraScoreInfo : IMessage<ExtraScoreInfo>, IMessage, IEquatable<ExtraScoreInfo>, IDeepCloneable<ExtraScoreInfo>, IBufferMessage
	{
		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x060038CA RID: 14538 RVA: 0x0009BA5D File Offset: 0x00099C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExtraScoreInfo> Parser
		{
			get
			{
				return ExtraScoreInfo._parser;
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x0009BA64 File Offset: 0x00099C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExtraScoreInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x060038CC RID: 14540 RVA: 0x0009BA76 File Offset: 0x00099C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExtraScoreInfo.Descriptor;
			}
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x0009BA7D File Offset: 0x00099C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraScoreInfo()
		{
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x0009BA88 File Offset: 0x00099C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraScoreInfo(ExtraScoreInfo other) : this()
		{
			this.isFinish_ = other.isFinish_;
			this.gLHDMJCLFFH_ = other.gLHDMJCLFFH_;
			this.endTime_ = other.endTime_;
			this.week_ = other.week_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x0009BADC File Offset: 0x00099CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraScoreInfo Clone()
		{
			return new ExtraScoreInfo(this);
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x060038D0 RID: 14544 RVA: 0x0009BAE4 File Offset: 0x00099CE4
		// (set) Token: 0x060038D1 RID: 14545 RVA: 0x0009BAEC File Offset: 0x00099CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x060038D2 RID: 14546 RVA: 0x0009BAF5 File Offset: 0x00099CF5
		// (set) Token: 0x060038D3 RID: 14547 RVA: 0x0009BAFD File Offset: 0x00099CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GLHDMJCLFFH
		{
			get
			{
				return this.gLHDMJCLFFH_;
			}
			set
			{
				this.gLHDMJCLFFH_ = value;
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x060038D4 RID: 14548 RVA: 0x0009BB06 File Offset: 0x00099D06
		// (set) Token: 0x060038D5 RID: 14549 RVA: 0x0009BB0E File Offset: 0x00099D0E
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

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x060038D6 RID: 14550 RVA: 0x0009BB17 File Offset: 0x00099D17
		// (set) Token: 0x060038D7 RID: 14551 RVA: 0x0009BB1F File Offset: 0x00099D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Week
		{
			get
			{
				return this.week_;
			}
			set
			{
				this.week_ = value;
			}
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x0009BB28 File Offset: 0x00099D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExtraScoreInfo);
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x0009BB38 File Offset: 0x00099D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExtraScoreInfo other)
		{
			return other != null && (other == this || (this.IsFinish == other.IsFinish && this.GLHDMJCLFFH == other.GLHDMJCLFFH && this.EndTime == other.EndTime && this.Week == other.Week && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x0009BBA4 File Offset: 0x00099DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this.GLHDMJCLFFH != 0U)
			{
				num ^= this.GLHDMJCLFFH.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.Week != 0U)
			{
				num ^= this.Week.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0009BC2E File Offset: 0x00099E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x0009BC36 File Offset: 0x00099E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x0009BC40 File Offset: 0x00099E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GLHDMJCLFFH != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GLHDMJCLFFH);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsFinish);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EndTime);
			}
			if (this.Week != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Week);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x0009BCD4 File Offset: 0x00099ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this.GLHDMJCLFFH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GLHDMJCLFFH);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.Week != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Week);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0009BD50 File Offset: 0x00099F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExtraScoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			if (other.GLHDMJCLFFH != 0U)
			{
				this.GLHDMJCLFFH = other.GLHDMJCLFFH;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.Week != 0U)
			{
				this.Week = other.Week;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x0009BDC8 File Offset: 0x00099FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0009BDD4 File Offset: 0x00099FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 16U)
					{
						this.GLHDMJCLFFH = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.Week = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001688 RID: 5768
		private static readonly MessageParser<ExtraScoreInfo> _parser = new MessageParser<ExtraScoreInfo>(() => new ExtraScoreInfo());

		// Token: 0x04001689 RID: 5769
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400168A RID: 5770
		public const int IsFinishFieldNumber = 6;

		// Token: 0x0400168B RID: 5771
		private bool isFinish_;

		// Token: 0x0400168C RID: 5772
		public const int GLHDMJCLFFHFieldNumber = 2;

		// Token: 0x0400168D RID: 5773
		private uint gLHDMJCLFFH_;

		// Token: 0x0400168E RID: 5774
		public const int EndTimeFieldNumber = 7;

		// Token: 0x0400168F RID: 5775
		private long endTime_;

		// Token: 0x04001690 RID: 5776
		public const int WeekFieldNumber = 9;

		// Token: 0x04001691 RID: 5777
		private uint week_;
	}
}
