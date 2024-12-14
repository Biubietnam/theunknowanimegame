using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C5B RID: 3163
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OKCIHJIHBAN : IMessage<OKCIHJIHBAN>, IMessage, IEquatable<OKCIHJIHBAN>, IDeepCloneable<OKCIHJIHBAN>, IBufferMessage
	{
		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x06008C79 RID: 35961 RVA: 0x001735A7 File Offset: 0x001717A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OKCIHJIHBAN> Parser
		{
			get
			{
				return OKCIHJIHBAN._parser;
			}
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x06008C7A RID: 35962 RVA: 0x001735AE File Offset: 0x001717AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OKCIHJIHBANReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x06008C7B RID: 35963 RVA: 0x001735C0 File Offset: 0x001717C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OKCIHJIHBAN.Descriptor;
			}
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x001735C7 File Offset: 0x001717C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKCIHJIHBAN()
		{
		}

		// Token: 0x06008C7D RID: 35965 RVA: 0x001735DC File Offset: 0x001717DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKCIHJIHBAN(OKCIHJIHBAN other) : this()
		{
			this.exp_ = other.exp_;
			this.subAffixList_ = other.subAffixList_.Clone();
			this.mainAffixId_ = other.mainAffixId_;
			this.level_ = other.level_;
			this.tid_ = other.tid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C7E RID: 35966 RVA: 0x00173641 File Offset: 0x00171841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKCIHJIHBAN Clone()
		{
			return new OKCIHJIHBAN(this);
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x06008C7F RID: 35967 RVA: 0x00173649 File Offset: 0x00171849
		// (set) Token: 0x06008C80 RID: 35968 RVA: 0x00173651 File Offset: 0x00171851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x06008C81 RID: 35969 RVA: 0x0017365A File Offset: 0x0017185A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RelicAffix> SubAffixList
		{
			get
			{
				return this.subAffixList_;
			}
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x06008C82 RID: 35970 RVA: 0x00173662 File Offset: 0x00171862
		// (set) Token: 0x06008C83 RID: 35971 RVA: 0x0017366A File Offset: 0x0017186A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainAffixId
		{
			get
			{
				return this.mainAffixId_;
			}
			set
			{
				this.mainAffixId_ = value;
			}
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x06008C84 RID: 35972 RVA: 0x00173673 File Offset: 0x00171873
		// (set) Token: 0x06008C85 RID: 35973 RVA: 0x0017367B File Offset: 0x0017187B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x06008C86 RID: 35974 RVA: 0x00173684 File Offset: 0x00171884
		// (set) Token: 0x06008C87 RID: 35975 RVA: 0x0017368C File Offset: 0x0017188C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Tid
		{
			get
			{
				return this.tid_;
			}
			set
			{
				this.tid_ = value;
			}
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x00173695 File Offset: 0x00171895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OKCIHJIHBAN);
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x001736A4 File Offset: 0x001718A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OKCIHJIHBAN other)
		{
			return other != null && (other == this || (this.Exp == other.Exp && this.subAffixList_.Equals(other.subAffixList_) && this.MainAffixId == other.MainAffixId && this.Level == other.Level && this.Tid == other.Tid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x00173724 File Offset: 0x00171924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			num ^= this.subAffixList_.GetHashCode();
			if (this.MainAffixId != 0U)
			{
				num ^= this.MainAffixId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x001737BC File Offset: 0x001719BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x001737C4 File Offset: 0x001719C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C8D RID: 35981 RVA: 0x001737D0 File Offset: 0x001719D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Exp != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Exp);
			}
			if (this.MainAffixId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MainAffixId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Level);
			}
			this.subAffixList_.WriteTo(ref output, OKCIHJIHBAN._repeated_subAffixList_codec);
			if (this.Tid != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Tid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C8E RID: 35982 RVA: 0x00173874 File Offset: 0x00171A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			num += this.subAffixList_.CalculateSize(OKCIHJIHBAN._repeated_subAffixList_codec);
			if (this.MainAffixId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainAffixId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C8F RID: 35983 RVA: 0x00173910 File Offset: 0x00171B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OKCIHJIHBAN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			this.subAffixList_.Add(other.subAffixList_);
			if (other.MainAffixId != 0U)
			{
				this.MainAffixId = other.MainAffixId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x00173999 File Offset: 0x00171B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C91 RID: 35985 RVA: 0x001739A4 File Offset: 0x00171BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 40U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.MainAffixId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						this.subAffixList_.AddEntriesFrom(ref input, OKCIHJIHBAN._repeated_subAffixList_codec);
						continue;
					}
					if (num == 96U)
					{
						this.Tid = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040035F3 RID: 13811
		private static readonly MessageParser<OKCIHJIHBAN> _parser = new MessageParser<OKCIHJIHBAN>(() => new OKCIHJIHBAN());

		// Token: 0x040035F4 RID: 13812
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035F5 RID: 13813
		public const int ExpFieldNumber = 5;

		// Token: 0x040035F6 RID: 13814
		private uint exp_;

		// Token: 0x040035F7 RID: 13815
		public const int SubAffixListFieldNumber = 11;

		// Token: 0x040035F8 RID: 13816
		private static readonly FieldCodec<RelicAffix> _repeated_subAffixList_codec = FieldCodec.ForMessage<RelicAffix>(90U, RelicAffix.Parser);

		// Token: 0x040035F9 RID: 13817
		private readonly RepeatedField<RelicAffix> subAffixList_ = new RepeatedField<RelicAffix>();

		// Token: 0x040035FA RID: 13818
		public const int MainAffixIdFieldNumber = 9;

		// Token: 0x040035FB RID: 13819
		private uint mainAffixId_;

		// Token: 0x040035FC RID: 13820
		public const int LevelFieldNumber = 10;

		// Token: 0x040035FD RID: 13821
		private uint level_;

		// Token: 0x040035FE RID: 13822
		public const int TidFieldNumber = 12;

		// Token: 0x040035FF RID: 13823
		private uint tid_;
	}
}
