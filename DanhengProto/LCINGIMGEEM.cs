using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009E9 RID: 2537
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LCINGIMGEEM : IMessage<LCINGIMGEEM>, IMessage, IEquatable<LCINGIMGEEM>, IDeepCloneable<LCINGIMGEEM>, IBufferMessage
	{
		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x060070A5 RID: 28837 RVA: 0x0012C5ED File Offset: 0x0012A7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LCINGIMGEEM> Parser
		{
			get
			{
				return LCINGIMGEEM._parser;
			}
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x060070A6 RID: 28838 RVA: 0x0012C5F4 File Offset: 0x0012A7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LCINGIMGEEMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x060070A7 RID: 28839 RVA: 0x0012C606 File Offset: 0x0012A806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LCINGIMGEEM.Descriptor;
			}
		}

		// Token: 0x060070A8 RID: 28840 RVA: 0x0012C60D File Offset: 0x0012A80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCINGIMGEEM()
		{
		}

		// Token: 0x060070A9 RID: 28841 RVA: 0x0012C620 File Offset: 0x0012A820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCINGIMGEEM(LCINGIMGEEM other) : this()
		{
			this.levelId_ = other.levelId_;
			this.hOAMCDKDELJ_ = other.hOAMCDKDELJ_;
			this.nEKECKBBFMH_ = other.nEKECKBBFMH_.Clone();
			this.pBBEHNBHIIM_ = other.pBBEHNBHIIM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070AA RID: 28842 RVA: 0x0012C679 File Offset: 0x0012A879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCINGIMGEEM Clone()
		{
			return new LCINGIMGEEM(this);
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x060070AB RID: 28843 RVA: 0x0012C681 File Offset: 0x0012A881
		// (set) Token: 0x060070AC RID: 28844 RVA: 0x0012C689 File Offset: 0x0012A889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x060070AD RID: 28845 RVA: 0x0012C692 File Offset: 0x0012A892
		// (set) Token: 0x060070AE RID: 28846 RVA: 0x0012C69A File Offset: 0x0012A89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HOAMCDKDELJ
		{
			get
			{
				return this.hOAMCDKDELJ_;
			}
			set
			{
				this.hOAMCDKDELJ_ = value;
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x060070AF RID: 28847 RVA: 0x0012C6A3 File Offset: 0x0012A8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NEKECKBBFMH
		{
			get
			{
				return this.nEKECKBBFMH_;
			}
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x060070B0 RID: 28848 RVA: 0x0012C6AB File Offset: 0x0012A8AB
		// (set) Token: 0x060070B1 RID: 28849 RVA: 0x0012C6B3 File Offset: 0x0012A8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PBBEHNBHIIM
		{
			get
			{
				return this.pBBEHNBHIIM_;
			}
			set
			{
				this.pBBEHNBHIIM_ = value;
			}
		}

		// Token: 0x060070B2 RID: 28850 RVA: 0x0012C6BC File Offset: 0x0012A8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LCINGIMGEEM);
		}

		// Token: 0x060070B3 RID: 28851 RVA: 0x0012C6CC File Offset: 0x0012A8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LCINGIMGEEM other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.HOAMCDKDELJ == other.HOAMCDKDELJ && this.nEKECKBBFMH_.Equals(other.nEKECKBBFMH_) && this.PBBEHNBHIIM == other.PBBEHNBHIIM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x0012C73C File Offset: 0x0012A93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.HOAMCDKDELJ)
			{
				num ^= this.HOAMCDKDELJ.GetHashCode();
			}
			num ^= this.nEKECKBBFMH_.GetHashCode();
			if (this.PBBEHNBHIIM)
			{
				num ^= this.PBBEHNBHIIM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x0012C7BB File Offset: 0x0012A9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x0012C7C3 File Offset: 0x0012A9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x0012C7CC File Offset: 0x0012A9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nEKECKBBFMH_.WriteTo(ref output, LCINGIMGEEM._repeated_nEKECKBBFMH_codec);
			if (this.PBBEHNBHIIM)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.PBBEHNBHIIM);
			}
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.LevelId);
			}
			if (this.HOAMCDKDELJ)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.HOAMCDKDELJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x0012C854 File Offset: 0x0012AA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this.HOAMCDKDELJ)
			{
				num += 2;
			}
			num += this.nEKECKBBFMH_.CalculateSize(LCINGIMGEEM._repeated_nEKECKBBFMH_codec);
			if (this.PBBEHNBHIIM)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x0012C8C0 File Offset: 0x0012AAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LCINGIMGEEM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			if (other.HOAMCDKDELJ)
			{
				this.HOAMCDKDELJ = other.HOAMCDKDELJ;
			}
			this.nEKECKBBFMH_.Add(other.nEKECKBBFMH_);
			if (other.PBBEHNBHIIM)
			{
				this.PBBEHNBHIIM = other.PBBEHNBHIIM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x0012C935 File Offset: 0x0012AB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x0012C940 File Offset: 0x0012AB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.nEKECKBBFMH_.AddEntriesFrom(ref input, LCINGIMGEEM._repeated_nEKECKBBFMH_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.PBBEHNBHIIM = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.LevelId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.HOAMCDKDELJ = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B6E RID: 11118
		private static readonly MessageParser<LCINGIMGEEM> _parser = new MessageParser<LCINGIMGEEM>(() => new LCINGIMGEEM());

		// Token: 0x04002B6F RID: 11119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B70 RID: 11120
		public const int LevelIdFieldNumber = 11;

		// Token: 0x04002B71 RID: 11121
		private uint levelId_;

		// Token: 0x04002B72 RID: 11122
		public const int HOAMCDKDELJFieldNumber = 12;

		// Token: 0x04002B73 RID: 11123
		private bool hOAMCDKDELJ_;

		// Token: 0x04002B74 RID: 11124
		public const int NEKECKBBFMHFieldNumber = 5;

		// Token: 0x04002B75 RID: 11125
		private static readonly FieldCodec<uint> _repeated_nEKECKBBFMH_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04002B76 RID: 11126
		private readonly RepeatedField<uint> nEKECKBBFMH_ = new RepeatedField<uint>();

		// Token: 0x04002B77 RID: 11127
		public const int PBBEHNBHIIMFieldNumber = 9;

		// Token: 0x04002B78 RID: 11128
		private bool pBBEHNBHIIM_;
	}
}
