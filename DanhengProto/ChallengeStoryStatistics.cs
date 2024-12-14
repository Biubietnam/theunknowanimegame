using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001C5 RID: 453
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeStoryStatistics : IMessage<ChallengeStoryStatistics>, IMessage, IEquatable<ChallengeStoryStatistics>, IDeepCloneable<ChallengeStoryStatistics>, IBufferMessage
	{
		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0003A97B File Offset: 0x00038B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeStoryStatistics> Parser
		{
			get
			{
				return ChallengeStoryStatistics._parser;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0003A982 File Offset: 0x00038B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeStoryStatisticsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0003A994 File Offset: 0x00038B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeStoryStatistics.Descriptor;
			}
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0003A99B File Offset: 0x00038B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryStatistics()
		{
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0003A9A4 File Offset: 0x00038BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryStatistics(ChallengeStoryStatistics other) : this()
		{
			this.stageTertinggi_ = ((other.stageTertinggi_ != null) ? other.stageTertinggi_.Clone() : null);
			this.recordId_ = other.recordId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0003A9F0 File Offset: 0x00038BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryStatistics Clone()
		{
			return new ChallengeStoryStatistics(this);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0003A9F8 File Offset: 0x00038BF8
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x0003AA00 File Offset: 0x00038C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryStageTertinggi StageTertinggi
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

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0003AA09 File Offset: 0x00038C09
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x0003AA11 File Offset: 0x00038C11
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

		// Token: 0x06001468 RID: 5224 RVA: 0x0003AA1A File Offset: 0x00038C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeStoryStatistics);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0003AA28 File Offset: 0x00038C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeStoryStatistics other)
		{
			return other != null && (other == this || (object.Equals(this.StageTertinggi, other.StageTertinggi) && this.RecordId == other.RecordId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0003AA78 File Offset: 0x00038C78
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

		// Token: 0x0600146B RID: 5227 RVA: 0x0003AACD File Offset: 0x00038CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0003AAD5 File Offset: 0x00038CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0003AAE0 File Offset: 0x00038CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stageTertinggi_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.StageTertinggi);
			}
			if (this.RecordId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RecordId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0003AB3C File Offset: 0x00038D3C
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

		// Token: 0x0600146F RID: 5231 RVA: 0x0003AB94 File Offset: 0x00038D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeStoryStatistics other)
		{
			if (other == null)
			{
				return;
			}
			if (other.stageTertinggi_ != null)
			{
				if (this.stageTertinggi_ == null)
				{
					this.StageTertinggi = new ChallengeStoryStageTertinggi();
				}
				this.StageTertinggi.MergeFrom(other.StageTertinggi);
			}
			if (other.RecordId != 0U)
			{
				this.RecordId = other.RecordId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0003ABFC File Offset: 0x00038DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0003AC08 File Offset: 0x00038E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 32U)
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
						this.StageTertinggi = new ChallengeStoryStageTertinggi();
					}
					input.ReadMessage(this.StageTertinggi);
				}
			}
		}

		// Token: 0x0400088F RID: 2191
		private static readonly MessageParser<ChallengeStoryStatistics> _parser = new MessageParser<ChallengeStoryStatistics>(() => new ChallengeStoryStatistics());

		// Token: 0x04000890 RID: 2192
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000891 RID: 2193
		public const int StageTertinggiFieldNumber = 3;

		// Token: 0x04000892 RID: 2194
		private ChallengeStoryStageTertinggi stageTertinggi_;

		// Token: 0x04000893 RID: 2195
		public const int RecordIdFieldNumber = 4;

		// Token: 0x04000894 RID: 2196
		private uint recordId_;
	}
}
