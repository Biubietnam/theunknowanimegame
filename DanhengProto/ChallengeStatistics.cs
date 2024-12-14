using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001B9 RID: 441
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeStatistics : IMessage<ChallengeStatistics>, IMessage, IEquatable<ChallengeStatistics>, IDeepCloneable<ChallengeStatistics>, IBufferMessage
	{
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0003959F File Offset: 0x0003779F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeStatistics> Parser
		{
			get
			{
				return ChallengeStatistics._parser;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x000395A6 File Offset: 0x000377A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeStatisticsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x000395B8 File Offset: 0x000377B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeStatistics.Descriptor;
			}
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000395BF File Offset: 0x000377BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStatistics()
		{
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x000395C8 File Offset: 0x000377C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStatistics(ChallengeStatistics other) : this()
		{
			this.stageTertinggi_ = ((other.stageTertinggi_ != null) ? other.stageTertinggi_.Clone() : null);
			this.recordId_ = other.recordId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00039614 File Offset: 0x00037814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStatistics Clone()
		{
			return new ChallengeStatistics(this);
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0003961C File Offset: 0x0003781C
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x00039624 File Offset: 0x00037824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStageTertinggi StageTertinggi
		{
			get
			{
				return this.stageTertinggi_;
			}
			set
			{
				this.stageTertinggi_ = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0003962D File Offset: 0x0003782D
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x00039635 File Offset: 0x00037835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RecordId
		{
			get
			{
				return this.recordId_;
			}
			set
			{
				this.recordId_ = value;
			}
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0003963E File Offset: 0x0003783E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeStatistics);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0003964C File Offset: 0x0003784C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeStatistics other)
		{
			return other != null && (other == this || (object.Equals(this.StageTertinggi, other.StageTertinggi) && this.RecordId == other.RecordId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0003969C File Offset: 0x0003789C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stageTertinggi_ != null)
			{
				num ^= this.StageTertinggi.GetHashCode();
			}
			if (this.RecordId != 0U)
			{
				num ^= this.RecordId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x000396F1 File Offset: 0x000378F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x000396F9 File Offset: 0x000378F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00039704 File Offset: 0x00037904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stageTertinggi_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.StageTertinggi);
			}
			if (this.RecordId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.RecordId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00039760 File Offset: 0x00037960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stageTertinggi_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageTertinggi);
			}
			if (this.RecordId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RecordId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x000397B8 File Offset: 0x000379B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeStatistics other)
		{
			if (other == null)
			{
				return;
			}
			if (other.stageTertinggi_ != null)
			{
				if (this.stageTertinggi_ == null)
				{
					this.StageTertinggi = new ChallengeStageTertinggi();
				}
				this.StageTertinggi.MergeFrom(other.StageTertinggi);
			}
			if (other.RecordId != 0U)
			{
				this.RecordId = other.RecordId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00039820 File Offset: 0x00037A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0003982C File Offset: 0x00037A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RecordId = input.ReadUInt32();
					}
				}
				else
				{
					if (this.stageTertinggi_ == null)
					{
						this.StageTertinggi = new ChallengeStageTertinggi();
					}
					input.ReadMessage(this.StageTertinggi);
				}
			}
		}

		// Token: 0x0400085E RID: 2142
		private static readonly MessageParser<ChallengeStatistics> _parser = new MessageParser<ChallengeStatistics>(() => new ChallengeStatistics());

		// Token: 0x0400085F RID: 2143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000860 RID: 2144
		public const int StageTertinggiFieldNumber = 5;

		// Token: 0x04000861 RID: 2145
		private ChallengeStageTertinggi stageTertinggi_;

		// Token: 0x04000862 RID: 2146
		public const int RecordIdFieldNumber = 13;

		// Token: 0x04000863 RID: 2147
		private uint recordId_;
	}
}
