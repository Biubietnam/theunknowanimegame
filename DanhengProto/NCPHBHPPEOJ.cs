using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C07 RID: 3079
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NCPHBHPPEOJ : IMessage<NCPHBHPPEOJ>, IMessage, IEquatable<NCPHBHPPEOJ>, IDeepCloneable<NCPHBHPPEOJ>, IBufferMessage
	{
		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x0600884B RID: 34891 RVA: 0x00167CDC File Offset: 0x00165EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NCPHBHPPEOJ> Parser
		{
			get
			{
				return NCPHBHPPEOJ._parser;
			}
		}

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x0600884C RID: 34892 RVA: 0x00167CE3 File Offset: 0x00165EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NCPHBHPPEOJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x0600884D RID: 34893 RVA: 0x00167CF5 File Offset: 0x00165EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NCPHBHPPEOJ.Descriptor;
			}
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x00167CFC File Offset: 0x00165EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCPHBHPPEOJ()
		{
		}

		// Token: 0x0600884F RID: 34895 RVA: 0x00167D04 File Offset: 0x00165F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCPHBHPPEOJ(NCPHBHPPEOJ other) : this()
		{
			this.scepterId_ = other.scepterId_;
			this.level_ = other.level_;
			this.totalDamage_ = other.totalDamage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x00167D41 File Offset: 0x00165F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NCPHBHPPEOJ Clone()
		{
			return new NCPHBHPPEOJ(this);
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x06008851 RID: 34897 RVA: 0x00167D49 File Offset: 0x00165F49
		// (set) Token: 0x06008852 RID: 34898 RVA: 0x00167D51 File Offset: 0x00165F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScepterId
		{
			get
			{
				return this.scepterId_;
			}
			set
			{
				this.scepterId_ = value;
			}
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x06008853 RID: 34899 RVA: 0x00167D5A File Offset: 0x00165F5A
		// (set) Token: 0x06008854 RID: 34900 RVA: 0x00167D62 File Offset: 0x00165F62
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

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x06008855 RID: 34901 RVA: 0x00167D6B File Offset: 0x00165F6B
		// (set) Token: 0x06008856 RID: 34902 RVA: 0x00167D73 File Offset: 0x00165F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalDamage
		{
			get
			{
				return this.totalDamage_;
			}
			set
			{
				this.totalDamage_ = value;
			}
		}

		// Token: 0x06008857 RID: 34903 RVA: 0x00167D7C File Offset: 0x00165F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NCPHBHPPEOJ);
		}

		// Token: 0x06008858 RID: 34904 RVA: 0x00167D8C File Offset: 0x00165F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NCPHBHPPEOJ other)
		{
			return other != null && (other == this || (this.ScepterId == other.ScepterId && this.Level == other.Level && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalDamage, other.TotalDamage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x00167DF0 File Offset: 0x00165FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScepterId != 0U)
			{
				num ^= this.ScepterId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.TotalDamage != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalDamage);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x00167E6C File Offset: 0x0016606C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x00167E74 File Offset: 0x00166074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600885C RID: 34908 RVA: 0x00167E80 File Offset: 0x00166080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScepterId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ScepterId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.TotalDamage != 0.0)
			{
				output.WriteRawTag(25);
				output.WriteDouble(this.TotalDamage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600885D RID: 34909 RVA: 0x00167F00 File Offset: 0x00166100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScepterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScepterId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.TotalDamage != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600885E RID: 34910 RVA: 0x00167F6C File Offset: 0x0016616C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NCPHBHPPEOJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScepterId != 0U)
			{
				this.ScepterId = other.ScepterId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.TotalDamage != 0.0)
			{
				this.TotalDamage = other.TotalDamage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600885F RID: 34911 RVA: 0x00167FD9 File Offset: 0x001661D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008860 RID: 34912 RVA: 0x00167FE4 File Offset: 0x001661E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 25U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TotalDamage = input.ReadDouble();
						}
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.ScepterId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003441 RID: 13377
		private static readonly MessageParser<NCPHBHPPEOJ> _parser = new MessageParser<NCPHBHPPEOJ>(() => new NCPHBHPPEOJ());

		// Token: 0x04003442 RID: 13378
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003443 RID: 13379
		public const int ScepterIdFieldNumber = 1;

		// Token: 0x04003444 RID: 13380
		private uint scepterId_;

		// Token: 0x04003445 RID: 13381
		public const int LevelFieldNumber = 2;

		// Token: 0x04003446 RID: 13382
		private uint level_;

		// Token: 0x04003447 RID: 13383
		public const int TotalDamageFieldNumber = 3;

		// Token: 0x04003448 RID: 13384
		private double totalDamage_;
	}
}
