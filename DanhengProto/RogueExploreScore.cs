using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E81 RID: 3713
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueExploreScore : IMessage<RogueExploreScore>, IMessage, IEquatable<RogueExploreScore>, IDeepCloneable<RogueExploreScore>, IBufferMessage
	{
		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x0600A59F RID: 42399 RVA: 0x001BD399 File Offset: 0x001BB599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueExploreScore> Parser
		{
			get
			{
				return RogueExploreScore._parser;
			}
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x0600A5A0 RID: 42400 RVA: 0x001BD3A0 File Offset: 0x001BB5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueExploreScoreReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x0600A5A1 RID: 42401 RVA: 0x001BD3B2 File Offset: 0x001BB5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueExploreScore.Descriptor;
			}
		}

		// Token: 0x0600A5A2 RID: 42402 RVA: 0x001BD3B9 File Offset: 0x001BB5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueExploreScore()
		{
		}

		// Token: 0x0600A5A3 RID: 42403 RVA: 0x001BD3C1 File Offset: 0x001BB5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueExploreScore(RogueExploreScore other) : this()
		{
			this.scoreId_ = other.scoreId_;
			this.mHGGDOMFBKD_ = other.mHGGDOMFBKD_;
			this.lADFPCEPLIJ_ = other.lADFPCEPLIJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x001BD3FE File Offset: 0x001BB5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueExploreScore Clone()
		{
			return new RogueExploreScore(this);
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x0600A5A5 RID: 42405 RVA: 0x001BD406 File Offset: 0x001BB606
		// (set) Token: 0x0600A5A6 RID: 42406 RVA: 0x001BD40E File Offset: 0x001BB60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0600A5A7 RID: 42407 RVA: 0x001BD417 File Offset: 0x001BB617
		// (set) Token: 0x0600A5A8 RID: 42408 RVA: 0x001BD41F File Offset: 0x001BB61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MHGGDOMFBKD
		{
			get
			{
				return this.mHGGDOMFBKD_;
			}
			set
			{
				this.mHGGDOMFBKD_ = value;
			}
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0600A5A9 RID: 42409 RVA: 0x001BD428 File Offset: 0x001BB628
		// (set) Token: 0x0600A5AA RID: 42410 RVA: 0x001BD430 File Offset: 0x001BB630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LADFPCEPLIJ
		{
			get
			{
				return this.lADFPCEPLIJ_;
			}
			set
			{
				this.lADFPCEPLIJ_ = value;
			}
		}

		// Token: 0x0600A5AB RID: 42411 RVA: 0x001BD439 File Offset: 0x001BB639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueExploreScore);
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x001BD448 File Offset: 0x001BB648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueExploreScore other)
		{
			return other != null && (other == this || (this.ScoreId == other.ScoreId && this.MHGGDOMFBKD == other.MHGGDOMFBKD && this.LADFPCEPLIJ == other.LADFPCEPLIJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x001BD4A4 File Offset: 0x001BB6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.MHGGDOMFBKD != 0U)
			{
				num ^= this.MHGGDOMFBKD.GetHashCode();
			}
			if (this.LADFPCEPLIJ != 0U)
			{
				num ^= this.LADFPCEPLIJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5AE RID: 42414 RVA: 0x001BD515 File Offset: 0x001BB715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A5AF RID: 42415 RVA: 0x001BD51D File Offset: 0x001BB71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x001BD528 File Offset: 0x001BB728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MHGGDOMFBKD != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MHGGDOMFBKD);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.LADFPCEPLIJ != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.LADFPCEPLIJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x001BD5A0 File Offset: 0x001BB7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.MHGGDOMFBKD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MHGGDOMFBKD);
			}
			if (this.LADFPCEPLIJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LADFPCEPLIJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x001BD610 File Offset: 0x001BB810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueExploreScore other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.MHGGDOMFBKD != 0U)
			{
				this.MHGGDOMFBKD = other.MHGGDOMFBKD;
			}
			if (other.LADFPCEPLIJ != 0U)
			{
				this.LADFPCEPLIJ = other.LADFPCEPLIJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x001BD674 File Offset: 0x001BB874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x001BD680 File Offset: 0x001BB880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LADFPCEPLIJ = input.ReadUInt32();
						}
					}
					else
					{
						this.ScoreId = input.ReadUInt32();
					}
				}
				else
				{
					this.MHGGDOMFBKD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040043A8 RID: 17320
		private static readonly MessageParser<RogueExploreScore> _parser = new MessageParser<RogueExploreScore>(() => new RogueExploreScore());

		// Token: 0x040043A9 RID: 17321
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043AA RID: 17322
		public const int ScoreIdFieldNumber = 8;

		// Token: 0x040043AB RID: 17323
		private uint scoreId_;

		// Token: 0x040043AC RID: 17324
		public const int MHGGDOMFBKDFieldNumber = 3;

		// Token: 0x040043AD RID: 17325
		private uint mHGGDOMFBKD_;

		// Token: 0x040043AE RID: 17326
		public const int LADFPCEPLIJFieldNumber = 12;

		// Token: 0x040043AF RID: 17327
		private uint lADFPCEPLIJ_;
	}
}
