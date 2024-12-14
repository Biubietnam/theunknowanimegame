using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E9D RID: 3741
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueHandbook : IMessage<RogueHandbook>, IMessage, IEquatable<RogueHandbook>, IDeepCloneable<RogueHandbook>, IBufferMessage
	{
		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x0600A727 RID: 42791 RVA: 0x001C256F File Offset: 0x001C076F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueHandbook> Parser
		{
			get
			{
				return RogueHandbook._parser;
			}
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x0600A728 RID: 42792 RVA: 0x001C2576 File Offset: 0x001C0776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueHandbookReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x0600A729 RID: 42793 RVA: 0x001C2588 File Offset: 0x001C0788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueHandbook.Descriptor;
			}
		}

		// Token: 0x0600A72A RID: 42794 RVA: 0x001C258F File Offset: 0x001C078F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHandbook()
		{
		}

		// Token: 0x0600A72B RID: 42795 RVA: 0x001C25C4 File Offset: 0x001C07C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHandbook(RogueHandbook other) : this()
		{
			this.buffList_ = other.buffList_.Clone();
			this.oLDHNGGKABL_ = other.oLDHNGGKABL_.Clone();
			this.miracleList_ = other.miracleList_.Clone();
			this.mKEENINMLEP_ = other.mKEENINMLEP_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x001C262C File Offset: 0x001C082C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHandbook Clone()
		{
			return new RogueHandbook(this);
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x0600A72D RID: 42797 RVA: 0x001C2634 File Offset: 0x001C0834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueHandbookMazeBuff> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x0600A72E RID: 42798 RVA: 0x001C263C File Offset: 0x001C083C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DMDEOGJEGPI> OLDHNGGKABL
		{
			get
			{
				return this.oLDHNGGKABL_;
			}
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x0600A72F RID: 42799 RVA: 0x001C2644 File Offset: 0x001C0844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BFDCJNAGBCH> MiracleList
		{
			get
			{
				return this.miracleList_;
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x0600A730 RID: 42800 RVA: 0x001C264C File Offset: 0x001C084C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NPEHHMFPLCA> MKEENINMLEP
		{
			get
			{
				return this.mKEENINMLEP_;
			}
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x001C2654 File Offset: 0x001C0854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueHandbook);
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x001C2664 File Offset: 0x001C0864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueHandbook other)
		{
			return other != null && (other == this || (this.buffList_.Equals(other.buffList_) && this.oLDHNGGKABL_.Equals(other.oLDHNGGKABL_) && this.miracleList_.Equals(other.miracleList_) && this.mKEENINMLEP_.Equals(other.mKEENINMLEP_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x001C26E4 File Offset: 0x001C08E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffList_.GetHashCode();
			num ^= this.oLDHNGGKABL_.GetHashCode();
			num ^= this.miracleList_.GetHashCode();
			num ^= this.mKEENINMLEP_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A734 RID: 42804 RVA: 0x001C2742 File Offset: 0x001C0942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A735 RID: 42805 RVA: 0x001C274A File Offset: 0x001C094A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A736 RID: 42806 RVA: 0x001C2754 File Offset: 0x001C0954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mKEENINMLEP_.WriteTo(ref output, RogueHandbook._repeated_mKEENINMLEP_codec);
			this.miracleList_.WriteTo(ref output, RogueHandbook._repeated_miracleList_codec);
			this.oLDHNGGKABL_.WriteTo(ref output, RogueHandbook._repeated_oLDHNGGKABL_codec);
			this.buffList_.WriteTo(ref output, RogueHandbook._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x001C27BC File Offset: 0x001C09BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffList_.CalculateSize(RogueHandbook._repeated_buffList_codec);
			num += this.oLDHNGGKABL_.CalculateSize(RogueHandbook._repeated_oLDHNGGKABL_codec);
			num += this.miracleList_.CalculateSize(RogueHandbook._repeated_miracleList_codec);
			num += this.mKEENINMLEP_.CalculateSize(RogueHandbook._repeated_mKEENINMLEP_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A738 RID: 42808 RVA: 0x001C2830 File Offset: 0x001C0A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueHandbook other)
		{
			if (other == null)
			{
				return;
			}
			this.buffList_.Add(other.buffList_);
			this.oLDHNGGKABL_.Add(other.oLDHNGGKABL_);
			this.miracleList_.Add(other.miracleList_);
			this.mKEENINMLEP_.Add(other.mKEENINMLEP_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A739 RID: 42809 RVA: 0x001C289C File Offset: 0x001C0A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x001C28A8 File Offset: 0x001C0AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 98U)
				{
					if (num == 66U)
					{
						this.mKEENINMLEP_.AddEntriesFrom(ref input, RogueHandbook._repeated_mKEENINMLEP_codec);
						continue;
					}
					if (num == 98U)
					{
						this.miracleList_.AddEntriesFrom(ref input, RogueHandbook._repeated_miracleList_codec);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.oLDHNGGKABL_.AddEntriesFrom(ref input, RogueHandbook._repeated_oLDHNGGKABL_codec);
						continue;
					}
					if (num == 122U)
					{
						this.buffList_.AddEntriesFrom(ref input, RogueHandbook._repeated_buffList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400445C RID: 17500
		private static readonly MessageParser<RogueHandbook> _parser = new MessageParser<RogueHandbook>(() => new RogueHandbook());

		// Token: 0x0400445D RID: 17501
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400445E RID: 17502
		public const int BuffListFieldNumber = 15;

		// Token: 0x0400445F RID: 17503
		private static readonly FieldCodec<RogueHandbookMazeBuff> _repeated_buffList_codec = FieldCodec.ForMessage<RogueHandbookMazeBuff>(122U, RogueHandbookMazeBuff.Parser);

		// Token: 0x04004460 RID: 17504
		private readonly RepeatedField<RogueHandbookMazeBuff> buffList_ = new RepeatedField<RogueHandbookMazeBuff>();

		// Token: 0x04004461 RID: 17505
		public const int OLDHNGGKABLFieldNumber = 14;

		// Token: 0x04004462 RID: 17506
		private static readonly FieldCodec<DMDEOGJEGPI> _repeated_oLDHNGGKABL_codec = FieldCodec.ForMessage<DMDEOGJEGPI>(114U, DMDEOGJEGPI.Parser);

		// Token: 0x04004463 RID: 17507
		private readonly RepeatedField<DMDEOGJEGPI> oLDHNGGKABL_ = new RepeatedField<DMDEOGJEGPI>();

		// Token: 0x04004464 RID: 17508
		public const int MiracleListFieldNumber = 12;

		// Token: 0x04004465 RID: 17509
		private static readonly FieldCodec<BFDCJNAGBCH> _repeated_miracleList_codec = FieldCodec.ForMessage<BFDCJNAGBCH>(98U, BFDCJNAGBCH.Parser);

		// Token: 0x04004466 RID: 17510
		private readonly RepeatedField<BFDCJNAGBCH> miracleList_ = new RepeatedField<BFDCJNAGBCH>();

		// Token: 0x04004467 RID: 17511
		public const int MKEENINMLEPFieldNumber = 8;

		// Token: 0x04004468 RID: 17512
		private static readonly FieldCodec<NPEHHMFPLCA> _repeated_mKEENINMLEP_codec = FieldCodec.ForMessage<NPEHHMFPLCA>(66U, NPEHHMFPLCA.Parser);

		// Token: 0x04004469 RID: 17513
		private readonly RepeatedField<NPEHHMFPLCA> mKEENINMLEP_ = new RepeatedField<NPEHHMFPLCA>();
	}
}
