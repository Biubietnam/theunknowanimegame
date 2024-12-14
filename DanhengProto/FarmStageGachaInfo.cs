using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000503 RID: 1283
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FarmStageGachaInfo : IMessage<FarmStageGachaInfo>, IMessage, IEquatable<FarmStageGachaInfo>, IDeepCloneable<FarmStageGachaInfo>, IBufferMessage
	{
		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x0600397C RID: 14716 RVA: 0x0009E311 File Offset: 0x0009C511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FarmStageGachaInfo> Parser
		{
			get
			{
				return FarmStageGachaInfo._parser;
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x0009E318 File Offset: 0x0009C518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FarmStageGachaInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600397E RID: 14718 RVA: 0x0009E32A File Offset: 0x0009C52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmStageGachaInfo.Descriptor;
			}
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x0009E331 File Offset: 0x0009C531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmStageGachaInfo()
		{
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x0009E339 File Offset: 0x0009C539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmStageGachaInfo(FarmStageGachaInfo other) : this()
		{
			this.beginTime_ = other.beginTime_;
			this.gachaId_ = other.gachaId_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x0009E376 File Offset: 0x0009C576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmStageGachaInfo Clone()
		{
			return new FarmStageGachaInfo(this);
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06003982 RID: 14722 RVA: 0x0009E37E File Offset: 0x0009C57E
		// (set) Token: 0x06003983 RID: 14723 RVA: 0x0009E386 File Offset: 0x0009C586
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

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06003984 RID: 14724 RVA: 0x0009E38F File Offset: 0x0009C58F
		// (set) Token: 0x06003985 RID: 14725 RVA: 0x0009E397 File Offset: 0x0009C597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06003986 RID: 14726 RVA: 0x0009E3A0 File Offset: 0x0009C5A0
		// (set) Token: 0x06003987 RID: 14727 RVA: 0x0009E3A8 File Offset: 0x0009C5A8
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

		// Token: 0x06003988 RID: 14728 RVA: 0x0009E3B1 File Offset: 0x0009C5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmStageGachaInfo);
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x0009E3C0 File Offset: 0x0009C5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmStageGachaInfo other)
		{
			return other != null && (other == this || (this.BeginTime == other.BeginTime && this.GachaId == other.GachaId && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x0009E41C File Offset: 0x0009C61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.GachaId != 0U)
			{
				num ^= this.GachaId.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x0009E48D File Offset: 0x0009C68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x0009E495 File Offset: 0x0009C695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x0009E4A0 File Offset: 0x0009C6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GachaId);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x0009E518 File Offset: 0x0009C718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.GachaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaId);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x0009E588 File Offset: 0x0009C788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmStageGachaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.GachaId != 0U)
			{
				this.GachaId = other.GachaId;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x0009E5EC File Offset: 0x0009C7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x0009E5F8 File Offset: 0x0009C7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EndTime = input.ReadInt64();
						}
					}
					else
					{
						this.BeginTime = input.ReadInt64();
					}
				}
				else
				{
					this.GachaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040016E6 RID: 5862
		private static readonly MessageParser<FarmStageGachaInfo> _parser = new MessageParser<FarmStageGachaInfo>(() => new FarmStageGachaInfo());

		// Token: 0x040016E7 RID: 5863
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016E8 RID: 5864
		public const int BeginTimeFieldNumber = 11;

		// Token: 0x040016E9 RID: 5865
		private long beginTime_;

		// Token: 0x040016EA RID: 5866
		public const int GachaIdFieldNumber = 4;

		// Token: 0x040016EB RID: 5867
		private uint gachaId_;

		// Token: 0x040016EC RID: 5868
		public const int EndTimeFieldNumber = 14;

		// Token: 0x040016ED RID: 5869
		private long endTime_;
	}
}
