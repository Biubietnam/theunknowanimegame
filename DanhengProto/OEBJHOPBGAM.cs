using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C47 RID: 3143
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OEBJHOPBGAM : IMessage<OEBJHOPBGAM>, IMessage, IEquatable<OEBJHOPBGAM>, IDeepCloneable<OEBJHOPBGAM>, IBufferMessage
	{
		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x06008B71 RID: 35697 RVA: 0x001707B9 File Offset: 0x0016E9B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OEBJHOPBGAM> Parser
		{
			get
			{
				return OEBJHOPBGAM._parser;
			}
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x06008B72 RID: 35698 RVA: 0x001707C0 File Offset: 0x0016E9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OEBJHOPBGAMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x06008B73 RID: 35699 RVA: 0x001707D2 File Offset: 0x0016E9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OEBJHOPBGAM.Descriptor;
			}
		}

		// Token: 0x06008B74 RID: 35700 RVA: 0x001707D9 File Offset: 0x0016E9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEBJHOPBGAM()
		{
		}

		// Token: 0x06008B75 RID: 35701 RVA: 0x001707E4 File Offset: 0x0016E9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEBJHOPBGAM(OEBJHOPBGAM other) : this()
		{
			this.promotion_ = other.promotion_;
			this.rank_ = other.rank_;
			this.exp_ = other.exp_;
			this.tid_ = other.tid_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B76 RID: 35702 RVA: 0x00170844 File Offset: 0x0016EA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEBJHOPBGAM Clone()
		{
			return new OEBJHOPBGAM(this);
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x06008B77 RID: 35703 RVA: 0x0017084C File Offset: 0x0016EA4C
		// (set) Token: 0x06008B78 RID: 35704 RVA: 0x00170854 File Offset: 0x0016EA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Promotion
		{
			get
			{
				return this.promotion_;
			}
			set
			{
				this.promotion_ = value;
			}
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x06008B79 RID: 35705 RVA: 0x0017085D File Offset: 0x0016EA5D
		// (set) Token: 0x06008B7A RID: 35706 RVA: 0x00170865 File Offset: 0x0016EA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x06008B7B RID: 35707 RVA: 0x0017086E File Offset: 0x0016EA6E
		// (set) Token: 0x06008B7C RID: 35708 RVA: 0x00170876 File Offset: 0x0016EA76
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

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x06008B7D RID: 35709 RVA: 0x0017087F File Offset: 0x0016EA7F
		// (set) Token: 0x06008B7E RID: 35710 RVA: 0x00170887 File Offset: 0x0016EA87
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

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x06008B7F RID: 35711 RVA: 0x00170890 File Offset: 0x0016EA90
		// (set) Token: 0x06008B80 RID: 35712 RVA: 0x00170898 File Offset: 0x0016EA98
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

		// Token: 0x06008B81 RID: 35713 RVA: 0x001708A1 File Offset: 0x0016EAA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OEBJHOPBGAM);
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x001708B0 File Offset: 0x0016EAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OEBJHOPBGAM other)
		{
			return other != null && (other == this || (this.Promotion == other.Promotion && this.Rank == other.Rank && this.Exp == other.Exp && this.Tid == other.Tid && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x0017092C File Offset: 0x0016EB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Promotion != 0U)
			{
				num ^= this.Promotion.GetHashCode();
			}
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x001709CF File Offset: 0x0016EBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x001709D7 File Offset: 0x0016EBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x001709E0 File Offset: 0x0016EBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Rank != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Rank);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Exp);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Level);
			}
			if (this.Promotion != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Promotion);
			}
			if (this.Tid != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Tid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B87 RID: 35719 RVA: 0x00170A90 File Offset: 0x0016EC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Promotion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Promotion);
			}
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B88 RID: 35720 RVA: 0x00170B30 File Offset: 0x0016ED30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OEBJHOPBGAM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Promotion != 0U)
			{
				this.Promotion = other.Promotion;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B89 RID: 35721 RVA: 0x00170BBC File Offset: 0x0016EDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x00170BC8 File Offset: 0x0016EDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.Rank = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Promotion = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Tid = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003587 RID: 13703
		private static readonly MessageParser<OEBJHOPBGAM> _parser = new MessageParser<OEBJHOPBGAM>(() => new OEBJHOPBGAM());

		// Token: 0x04003588 RID: 13704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003589 RID: 13705
		public const int PromotionFieldNumber = 12;

		// Token: 0x0400358A RID: 13706
		private uint promotion_;

		// Token: 0x0400358B RID: 13707
		public const int RankFieldNumber = 4;

		// Token: 0x0400358C RID: 13708
		private uint rank_;

		// Token: 0x0400358D RID: 13709
		public const int ExpFieldNumber = 6;

		// Token: 0x0400358E RID: 13710
		private uint exp_;

		// Token: 0x0400358F RID: 13711
		public const int TidFieldNumber = 15;

		// Token: 0x04003590 RID: 13712
		private uint tid_;

		// Token: 0x04003591 RID: 13713
		public const int LevelFieldNumber = 11;

		// Token: 0x04003592 RID: 13714
		private uint level_;
	}
}
