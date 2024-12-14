using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E83 RID: 3715
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueExploreScoreInfo : IMessage<RogueExploreScoreInfo>, IMessage, IEquatable<RogueExploreScoreInfo>, IDeepCloneable<RogueExploreScoreInfo>, IBufferMessage
	{
		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x0600A5B8 RID: 42424 RVA: 0x001BD7AB File Offset: 0x001BB9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueExploreScoreInfo> Parser
		{
			get
			{
				return RogueExploreScoreInfo._parser;
			}
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x0600A5B9 RID: 42425 RVA: 0x001BD7B2 File Offset: 0x001BB9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueExploreScoreInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x0600A5BA RID: 42426 RVA: 0x001BD7C4 File Offset: 0x001BB9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueExploreScoreInfo.Descriptor;
			}
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x001BD7CB File Offset: 0x001BB9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueExploreScoreInfo()
		{
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x001BD7E0 File Offset: 0x001BB9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueExploreScoreInfo(RogueExploreScoreInfo other) : this()
		{
			this.bBKDCNDIJLN_ = other.bBKDCNDIJLN_;
			this.iLEFJACLICG_ = other.iLEFJACLICG_;
			this.scoreList_ = other.scoreList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x001BD82D File Offset: 0x001BBA2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueExploreScoreInfo Clone()
		{
			return new RogueExploreScoreInfo(this);
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x0600A5BE RID: 42430 RVA: 0x001BD835 File Offset: 0x001BBA35
		// (set) Token: 0x0600A5BF RID: 42431 RVA: 0x001BD83D File Offset: 0x001BBA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BBKDCNDIJLN
		{
			get
			{
				return this.bBKDCNDIJLN_;
			}
			set
			{
				this.bBKDCNDIJLN_ = value;
			}
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x0600A5C0 RID: 42432 RVA: 0x001BD846 File Offset: 0x001BBA46
		// (set) Token: 0x0600A5C1 RID: 42433 RVA: 0x001BD84E File Offset: 0x001BBA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ILEFJACLICG
		{
			get
			{
				return this.iLEFJACLICG_;
			}
			set
			{
				this.iLEFJACLICG_ = value;
			}
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x0600A5C2 RID: 42434 RVA: 0x001BD857 File Offset: 0x001BBA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueExploreScore> ScoreList
		{
			get
			{
				return this.scoreList_;
			}
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x001BD85F File Offset: 0x001BBA5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueExploreScoreInfo);
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x001BD870 File Offset: 0x001BBA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueExploreScoreInfo other)
		{
			return other != null && (other == this || (this.BBKDCNDIJLN == other.BBKDCNDIJLN && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ILEFJACLICG, other.ILEFJACLICG) && this.scoreList_.Equals(other.scoreList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x001BD8D8 File Offset: 0x001BBAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BBKDCNDIJLN != 0U)
			{
				num ^= this.BBKDCNDIJLN.GetHashCode();
			}
			if (this.ILEFJACLICG != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ILEFJACLICG);
			}
			num ^= this.scoreList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x001BD945 File Offset: 0x001BBB45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x001BD94D File Offset: 0x001BBB4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x001BD958 File Offset: 0x001BBB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ILEFJACLICG != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.ILEFJACLICG);
			}
			this.scoreList_.WriteTo(ref output, RogueExploreScoreInfo._repeated_scoreList_codec);
			if (this.BBKDCNDIJLN != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.BBKDCNDIJLN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x001BD9C8 File Offset: 0x001BBBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BBKDCNDIJLN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BBKDCNDIJLN);
			}
			if (this.ILEFJACLICG != 0f)
			{
				num += 5;
			}
			num += this.scoreList_.CalculateSize(RogueExploreScoreInfo._repeated_scoreList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x001BDA2C File Offset: 0x001BBC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueExploreScoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BBKDCNDIJLN != 0U)
			{
				this.BBKDCNDIJLN = other.BBKDCNDIJLN;
			}
			if (other.ILEFJACLICG != 0f)
			{
				this.ILEFJACLICG = other.ILEFJACLICG;
			}
			this.scoreList_.Add(other.scoreList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A5CB RID: 42443 RVA: 0x001BDA92 File Offset: 0x001BBC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x001BDA9C File Offset: 0x001BBC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 45U)
				{
					if (num != 66U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BBKDCNDIJLN = input.ReadUInt32();
						}
					}
					else
					{
						this.scoreList_.AddEntriesFrom(ref input, RogueExploreScoreInfo._repeated_scoreList_codec);
					}
				}
				else
				{
					this.ILEFJACLICG = input.ReadFloat();
				}
			}
		}

		// Token: 0x040043B1 RID: 17329
		private static readonly MessageParser<RogueExploreScoreInfo> _parser = new MessageParser<RogueExploreScoreInfo>(() => new RogueExploreScoreInfo());

		// Token: 0x040043B2 RID: 17330
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043B3 RID: 17331
		public const int BBKDCNDIJLNFieldNumber = 14;

		// Token: 0x040043B4 RID: 17332
		private uint bBKDCNDIJLN_;

		// Token: 0x040043B5 RID: 17333
		public const int ILEFJACLICGFieldNumber = 5;

		// Token: 0x040043B6 RID: 17334
		private float iLEFJACLICG_;

		// Token: 0x040043B7 RID: 17335
		public const int ScoreListFieldNumber = 8;

		// Token: 0x040043B8 RID: 17336
		private static readonly FieldCodec<RogueExploreScore> _repeated_scoreList_codec = FieldCodec.ForMessage<RogueExploreScore>(66U, RogueExploreScore.Parser);

		// Token: 0x040043B9 RID: 17337
		private readonly RepeatedField<RogueExploreScore> scoreList_ = new RepeatedField<RogueExploreScore>();
	}
}
