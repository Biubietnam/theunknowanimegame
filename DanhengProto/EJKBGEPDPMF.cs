using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000407 RID: 1031
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EJKBGEPDPMF : IMessage<EJKBGEPDPMF>, IMessage, IEquatable<EJKBGEPDPMF>, IDeepCloneable<EJKBGEPDPMF>, IBufferMessage
	{
		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x0007E7EC File Offset: 0x0007C9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EJKBGEPDPMF> Parser
		{
			get
			{
				return EJKBGEPDPMF._parser;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002DBD RID: 11709 RVA: 0x0007E7F3 File Offset: 0x0007C9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EJKBGEPDPMFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x0007E805 File Offset: 0x0007CA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EJKBGEPDPMF.Descriptor;
			}
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x0007E80C File Offset: 0x0007CA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EJKBGEPDPMF()
		{
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x0007E814 File Offset: 0x0007CA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EJKBGEPDPMF(EJKBGEPDPMF other) : this()
		{
			this.kHHFCELAFJA_ = other.kHHFCELAFJA_;
			this.maxScore_ = other.maxScore_;
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x0007E851 File Offset: 0x0007CA51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EJKBGEPDPMF Clone()
		{
			return new EJKBGEPDPMF(this);
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002DC2 RID: 11714 RVA: 0x0007E859 File Offset: 0x0007CA59
		// (set) Token: 0x06002DC3 RID: 11715 RVA: 0x0007E861 File Offset: 0x0007CA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KHHFCELAFJA
		{
			get
			{
				return this.kHHFCELAFJA_;
			}
			set
			{
				this.kHHFCELAFJA_ = value;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x0007E86A File Offset: 0x0007CA6A
		// (set) Token: 0x06002DC5 RID: 11717 RVA: 0x0007E872 File Offset: 0x0007CA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x0007E87B File Offset: 0x0007CA7B
		// (set) Token: 0x06002DC7 RID: 11719 RVA: 0x0007E883 File Offset: 0x0007CA83
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

		// Token: 0x06002DC8 RID: 11720 RVA: 0x0007E88C File Offset: 0x0007CA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EJKBGEPDPMF);
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x0007E89C File Offset: 0x0007CA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EJKBGEPDPMF other)
		{
			return other != null && (other == this || (this.KHHFCELAFJA == other.KHHFCELAFJA && this.MaxScore == other.MaxScore && this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x0007E8F8 File Offset: 0x0007CAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KHHFCELAFJA != 0U)
			{
				num ^= this.KHHFCELAFJA.GetHashCode();
			}
			if (this.MaxScore != 0U)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x0007E969 File Offset: 0x0007CB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x0007E971 File Offset: 0x0007CB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x0007E97C File Offset: 0x0007CB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxScore != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MaxScore);
			}
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.LevelId);
			}
			if (this.KHHFCELAFJA != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.KHHFCELAFJA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x0007E9F4 File Offset: 0x0007CBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KHHFCELAFJA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KHHFCELAFJA);
			}
			if (this.MaxScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxScore);
			}
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x0007EA64 File Offset: 0x0007CC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EJKBGEPDPMF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KHHFCELAFJA != 0U)
			{
				this.KHHFCELAFJA = other.KHHFCELAFJA;
			}
			if (other.MaxScore != 0U)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x0007EAC8 File Offset: 0x0007CCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x0007EAD4 File Offset: 0x0007CCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.KHHFCELAFJA = input.ReadUInt32();
						}
					}
					else
					{
						this.LevelId = input.ReadUInt32();
					}
				}
				else
				{
					this.MaxScore = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001267 RID: 4711
		private static readonly MessageParser<EJKBGEPDPMF> _parser = new MessageParser<EJKBGEPDPMF>(() => new EJKBGEPDPMF());

		// Token: 0x04001268 RID: 4712
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001269 RID: 4713
		public const int KHHFCELAFJAFieldNumber = 13;

		// Token: 0x0400126A RID: 4714
		private uint kHHFCELAFJA_;

		// Token: 0x0400126B RID: 4715
		public const int MaxScoreFieldNumber = 3;

		// Token: 0x0400126C RID: 4716
		private uint maxScore_;

		// Token: 0x0400126D RID: 4717
		public const int LevelIdFieldNumber = 11;

		// Token: 0x0400126E RID: 4718
		private uint levelId_;
	}
}
