using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001A3 RID: 419
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBossStatistics : IMessage<ChallengeBossStatistics>, IMessage, IEquatable<ChallengeBossStatistics>, IDeepCloneable<ChallengeBossStatistics>, IBufferMessage
	{
		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00036A7B File Offset: 0x00034C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBossStatistics> Parser
		{
			get
			{
				return ChallengeBossStatistics._parser;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00036A82 File Offset: 0x00034C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBossStatisticsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x00036A94 File Offset: 0x00034C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBossStatistics.Descriptor;
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00036A9B File Offset: 0x00034C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossStatistics()
		{
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00036AA4 File Offset: 0x00034CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossStatistics(ChallengeBossStatistics other) : this()
		{
			this.stageTertinggi_ = ((other.stageTertinggi_ != null) ? other.stageTertinggi_.Clone() : null);
			this.recordId_ = other.recordId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00036AF0 File Offset: 0x00034CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossStatistics Clone()
		{
			return new ChallengeBossStatistics(this);
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00036AF8 File Offset: 0x00034CF8
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x00036B00 File Offset: 0x00034D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossStageTertinggi StageTertinggi
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00036B09 File Offset: 0x00034D09
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00036B11 File Offset: 0x00034D11
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

		// Token: 0x060012E7 RID: 4839 RVA: 0x00036B1A File Offset: 0x00034D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBossStatistics);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00036B28 File Offset: 0x00034D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBossStatistics other)
		{
			return other != null && (other == this || (object.Equals(this.StageTertinggi, other.StageTertinggi) && this.RecordId == other.RecordId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00036B78 File Offset: 0x00034D78
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

		// Token: 0x060012EA RID: 4842 RVA: 0x00036BCD File Offset: 0x00034DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00036BD5 File Offset: 0x00034DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00036BE0 File Offset: 0x00034DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecordId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.RecordId);
			}
			if (this.stageTertinggi_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.StageTertinggi);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00036C3C File Offset: 0x00034E3C
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

		// Token: 0x060012EE RID: 4846 RVA: 0x00036C94 File Offset: 0x00034E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBossStatistics other)
		{
			if (other == null)
			{
				return;
			}
			if (other.stageTertinggi_ != null)
			{
				if (this.stageTertinggi_ == null)
				{
					this.StageTertinggi = new ChallengeBossStageTertinggi();
				}
				this.StageTertinggi.MergeFrom(other.StageTertinggi);
			}
			if (other.RecordId != 0U)
			{
				this.RecordId = other.RecordId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00036CFC File Offset: 0x00034EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00036D08 File Offset: 0x00034F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.stageTertinggi_ == null)
						{
							this.StageTertinggi = new ChallengeBossStageTertinggi();
						}
						input.ReadMessage(this.StageTertinggi);
					}
				}
				else
				{
					this.RecordId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000800 RID: 2048
		private static readonly MessageParser<ChallengeBossStatistics> _parser = new MessageParser<ChallengeBossStatistics>(() => new ChallengeBossStatistics());

		// Token: 0x04000801 RID: 2049
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000802 RID: 2050
		public const int StageTertinggiFieldNumber = 7;

		// Token: 0x04000803 RID: 2051
		private ChallengeBossStageTertinggi stageTertinggi_;

		// Token: 0x04000804 RID: 2052
		public const int RecordIdFieldNumber = 2;

		// Token: 0x04000805 RID: 2053
		private uint recordId_;
	}
}
