using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A6D RID: 2669
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LogisticsScoreRewardSyncInfoScNotify : IMessage<LogisticsScoreRewardSyncInfoScNotify>, IMessage, IEquatable<LogisticsScoreRewardSyncInfoScNotify>, IDeepCloneable<LogisticsScoreRewardSyncInfoScNotify>, IBufferMessage
	{
		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x0600765B RID: 30299 RVA: 0x0013A283 File Offset: 0x00138483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogisticsScoreRewardSyncInfoScNotify> Parser
		{
			get
			{
				return LogisticsScoreRewardSyncInfoScNotify._parser;
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x0600765C RID: 30300 RVA: 0x0013A28A File Offset: 0x0013848A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LogisticsScoreRewardSyncInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x0600765D RID: 30301 RVA: 0x0013A29C File Offset: 0x0013849C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogisticsScoreRewardSyncInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x0013A2A3 File Offset: 0x001384A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsScoreRewardSyncInfoScNotify()
		{
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x0013A2B6 File Offset: 0x001384B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsScoreRewardSyncInfoScNotify(LogisticsScoreRewardSyncInfoScNotify other) : this()
		{
			this.pDBOKHNHPNA_ = other.pDBOKHNHPNA_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x0013A2E0 File Offset: 0x001384E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsScoreRewardSyncInfoScNotify Clone()
		{
			return new LogisticsScoreRewardSyncInfoScNotify(this);
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06007661 RID: 30305 RVA: 0x0013A2E8 File Offset: 0x001384E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogisticsScore> PDBOKHNHPNA
		{
			get
			{
				return this.pDBOKHNHPNA_;
			}
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x0013A2F0 File Offset: 0x001384F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogisticsScoreRewardSyncInfoScNotify);
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x0013A2FE File Offset: 0x001384FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogisticsScoreRewardSyncInfoScNotify other)
		{
			return other != null && (other == this || (this.pDBOKHNHPNA_.Equals(other.pDBOKHNHPNA_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x0013A334 File Offset: 0x00138534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pDBOKHNHPNA_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x0013A368 File Offset: 0x00138568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007666 RID: 30310 RVA: 0x0013A370 File Offset: 0x00138570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007667 RID: 30311 RVA: 0x0013A379 File Offset: 0x00138579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pDBOKHNHPNA_.WriteTo(ref output, LogisticsScoreRewardSyncInfoScNotify._repeated_pDBOKHNHPNA_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x0013A3A0 File Offset: 0x001385A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pDBOKHNHPNA_.CalculateSize(LogisticsScoreRewardSyncInfoScNotify._repeated_pDBOKHNHPNA_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x0013A3D9 File Offset: 0x001385D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogisticsScoreRewardSyncInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.pDBOKHNHPNA_.Add(other.pDBOKHNHPNA_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x0013A407 File Offset: 0x00138607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x0013A410 File Offset: 0x00138610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pDBOKHNHPNA_.AddEntriesFrom(ref input, LogisticsScoreRewardSyncInfoScNotify._repeated_pDBOKHNHPNA_codec);
				}
			}
		}

		// Token: 0x04002D7D RID: 11645
		private static readonly MessageParser<LogisticsScoreRewardSyncInfoScNotify> _parser = new MessageParser<LogisticsScoreRewardSyncInfoScNotify>(() => new LogisticsScoreRewardSyncInfoScNotify());

		// Token: 0x04002D7E RID: 11646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D7F RID: 11647
		public const int PDBOKHNHPNAFieldNumber = 11;

		// Token: 0x04002D80 RID: 11648
		private static readonly FieldCodec<LogisticsScore> _repeated_pDBOKHNHPNA_codec = FieldCodec.ForMessage<LogisticsScore>(90U, LogisticsScore.Parser);

		// Token: 0x04002D81 RID: 11649
		private readonly RepeatedField<LogisticsScore> pDBOKHNHPNA_ = new RepeatedField<LogisticsScore>();
	}
}
