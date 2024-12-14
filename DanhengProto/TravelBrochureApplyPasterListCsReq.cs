using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200136D RID: 4973
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureApplyPasterListCsReq : IMessage<TravelBrochureApplyPasterListCsReq>, IMessage, IEquatable<TravelBrochureApplyPasterListCsReq>, IDeepCloneable<TravelBrochureApplyPasterListCsReq>, IBufferMessage
	{
		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x0600DDDC RID: 56796 RVA: 0x0024EB1F File Offset: 0x0024CD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureApplyPasterListCsReq> Parser
		{
			get
			{
				return TravelBrochureApplyPasterListCsReq._parser;
			}
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x0600DDDD RID: 56797 RVA: 0x0024EB26 File Offset: 0x0024CD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureApplyPasterListCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x0600DDDE RID: 56798 RVA: 0x0024EB38 File Offset: 0x0024CD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureApplyPasterListCsReq.Descriptor;
			}
		}

		// Token: 0x0600DDDF RID: 56799 RVA: 0x0024EB3F File Offset: 0x0024CD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterListCsReq()
		{
		}

		// Token: 0x0600DDE0 RID: 56800 RVA: 0x0024EB52 File Offset: 0x0024CD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterListCsReq(TravelBrochureApplyPasterListCsReq other) : this()
		{
			this.mOMOPGIHNKC_ = other.mOMOPGIHNKC_.Clone();
			this.nMAKNJMFFJN_ = other.nMAKNJMFFJN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDE1 RID: 56801 RVA: 0x0024EB88 File Offset: 0x0024CD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterListCsReq Clone()
		{
			return new TravelBrochureApplyPasterListCsReq(this);
		}

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x0600DDE2 RID: 56802 RVA: 0x0024EB90 File Offset: 0x0024CD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IOIHIDJEGJJ> MOMOPGIHNKC
		{
			get
			{
				return this.mOMOPGIHNKC_;
			}
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x0600DDE3 RID: 56803 RVA: 0x0024EB98 File Offset: 0x0024CD98
		// (set) Token: 0x0600DDE4 RID: 56804 RVA: 0x0024EBA0 File Offset: 0x0024CDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NMAKNJMFFJN
		{
			get
			{
				return this.nMAKNJMFFJN_;
			}
			set
			{
				this.nMAKNJMFFJN_ = value;
			}
		}

		// Token: 0x0600DDE5 RID: 56805 RVA: 0x0024EBA9 File Offset: 0x0024CDA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureApplyPasterListCsReq);
		}

		// Token: 0x0600DDE6 RID: 56806 RVA: 0x0024EBB8 File Offset: 0x0024CDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureApplyPasterListCsReq other)
		{
			return other != null && (other == this || (this.mOMOPGIHNKC_.Equals(other.mOMOPGIHNKC_) && this.NMAKNJMFFJN == other.NMAKNJMFFJN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDE7 RID: 56807 RVA: 0x0024EC08 File Offset: 0x0024CE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mOMOPGIHNKC_.GetHashCode();
			if (this.NMAKNJMFFJN != 0U)
			{
				num ^= this.NMAKNJMFFJN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DDE8 RID: 56808 RVA: 0x0024EC55 File Offset: 0x0024CE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DDE9 RID: 56809 RVA: 0x0024EC5D File Offset: 0x0024CE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDEA RID: 56810 RVA: 0x0024EC68 File Offset: 0x0024CE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NMAKNJMFFJN != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.NMAKNJMFFJN);
			}
			this.mOMOPGIHNKC_.WriteTo(ref output, TravelBrochureApplyPasterListCsReq._repeated_mOMOPGIHNKC_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DDEB RID: 56811 RVA: 0x0024ECB8 File Offset: 0x0024CEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mOMOPGIHNKC_.CalculateSize(TravelBrochureApplyPasterListCsReq._repeated_mOMOPGIHNKC_codec);
			if (this.NMAKNJMFFJN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NMAKNJMFFJN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DDEC RID: 56812 RVA: 0x0024ED0C File Offset: 0x0024CF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureApplyPasterListCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.mOMOPGIHNKC_.Add(other.mOMOPGIHNKC_);
			if (other.NMAKNJMFFJN != 0U)
			{
				this.NMAKNJMFFJN = other.NMAKNJMFFJN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DDED RID: 56813 RVA: 0x0024ED59 File Offset: 0x0024CF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDEE RID: 56814 RVA: 0x0024ED64 File Offset: 0x0024CF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.mOMOPGIHNKC_.AddEntriesFrom(ref input, TravelBrochureApplyPasterListCsReq._repeated_mOMOPGIHNKC_codec);
					}
				}
				else
				{
					this.NMAKNJMFFJN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005844 RID: 22596
		private static readonly MessageParser<TravelBrochureApplyPasterListCsReq> _parser = new MessageParser<TravelBrochureApplyPasterListCsReq>(() => new TravelBrochureApplyPasterListCsReq());

		// Token: 0x04005845 RID: 22597
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005846 RID: 22598
		public const int MOMOPGIHNKCFieldNumber = 5;

		// Token: 0x04005847 RID: 22599
		private static readonly FieldCodec<IOIHIDJEGJJ> _repeated_mOMOPGIHNKC_codec = FieldCodec.ForMessage<IOIHIDJEGJJ>(42U, IOIHIDJEGJJ.Parser);

		// Token: 0x04005848 RID: 22600
		private readonly RepeatedField<IOIHIDJEGJJ> mOMOPGIHNKC_ = new RepeatedField<IOIHIDJEGJJ>();

		// Token: 0x04005849 RID: 22601
		public const int NMAKNJMFFJNFieldNumber = 2;

		// Token: 0x0400584A RID: 22602
		private uint nMAKNJMFFJN_;
	}
}
