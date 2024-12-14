using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AB3 RID: 2739
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MBFIICLMKKD : IMessage<MBFIICLMKKD>, IMessage, IEquatable<MBFIICLMKKD>, IDeepCloneable<MBFIICLMKKD>, IBufferMessage
	{
		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x06007970 RID: 31088 RVA: 0x00141D3D File Offset: 0x0013FF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MBFIICLMKKD> Parser
		{
			get
			{
				return MBFIICLMKKD._parser;
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x06007971 RID: 31089 RVA: 0x00141D44 File Offset: 0x0013FF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MBFIICLMKKDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x06007972 RID: 31090 RVA: 0x00141D56 File Offset: 0x0013FF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MBFIICLMKKD.Descriptor;
			}
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x00141D5D File Offset: 0x0013FF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBFIICLMKKD()
		{
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x00141D68 File Offset: 0x0013FF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBFIICLMKKD(MBFIICLMKKD other) : this()
		{
			this.jJNFBPMOHDJ_ = other.jJNFBPMOHDJ_;
			this.buffId_ = other.buffId_;
			this.mCMGKPLCAAP_ = other.mCMGKPLCAAP_;
			this.cGJBCPOMNHE_ = other.cGJBCPOMNHE_;
			this.eEEABJCNKDO_ = other.eEEABJCNKDO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x00141DC8 File Offset: 0x0013FFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBFIICLMKKD Clone()
		{
			return new MBFIICLMKKD(this);
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x06007976 RID: 31094 RVA: 0x00141DD0 File Offset: 0x0013FFD0
		// (set) Token: 0x06007977 RID: 31095 RVA: 0x00141DD8 File Offset: 0x0013FFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JJNFBPMOHDJ
		{
			get
			{
				return this.jJNFBPMOHDJ_;
			}
			set
			{
				this.jJNFBPMOHDJ_ = value;
			}
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x06007978 RID: 31096 RVA: 0x00141DE1 File Offset: 0x0013FFE1
		// (set) Token: 0x06007979 RID: 31097 RVA: 0x00141DE9 File Offset: 0x0013FFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x0600797A RID: 31098 RVA: 0x00141DF2 File Offset: 0x0013FFF2
		// (set) Token: 0x0600797B RID: 31099 RVA: 0x00141DFA File Offset: 0x0013FFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MCMGKPLCAAP
		{
			get
			{
				return this.mCMGKPLCAAP_;
			}
			set
			{
				this.mCMGKPLCAAP_ = value;
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x0600797C RID: 31100 RVA: 0x00141E03 File Offset: 0x00140003
		// (set) Token: 0x0600797D RID: 31101 RVA: 0x00141E0B File Offset: 0x0014000B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CGJBCPOMNHE
		{
			get
			{
				return this.cGJBCPOMNHE_;
			}
			set
			{
				this.cGJBCPOMNHE_ = value;
			}
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x0600797E RID: 31102 RVA: 0x00141E14 File Offset: 0x00140014
		// (set) Token: 0x0600797F RID: 31103 RVA: 0x00141E1C File Offset: 0x0014001C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EEEABJCNKDO
		{
			get
			{
				return this.eEEABJCNKDO_;
			}
			set
			{
				this.eEEABJCNKDO_ = value;
			}
		}

		// Token: 0x06007980 RID: 31104 RVA: 0x00141E25 File Offset: 0x00140025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MBFIICLMKKD);
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x00141E34 File Offset: 0x00140034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MBFIICLMKKD other)
		{
			return other != null && (other == this || (this.JJNFBPMOHDJ == other.JJNFBPMOHDJ && this.BuffId == other.BuffId && this.MCMGKPLCAAP == other.MCMGKPLCAAP && this.CGJBCPOMNHE == other.CGJBCPOMNHE && this.EEEABJCNKDO == other.EEEABJCNKDO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007982 RID: 31106 RVA: 0x00141EB0 File Offset: 0x001400B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JJNFBPMOHDJ != 0U)
			{
				num ^= this.JJNFBPMOHDJ.GetHashCode();
			}
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.MCMGKPLCAAP != 0U)
			{
				num ^= this.MCMGKPLCAAP.GetHashCode();
			}
			if (this.CGJBCPOMNHE != 0U)
			{
				num ^= this.CGJBCPOMNHE.GetHashCode();
			}
			if (this.EEEABJCNKDO != 0U)
			{
				num ^= this.EEEABJCNKDO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x00141F53 File Offset: 0x00140153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x00141F5B File Offset: 0x0014015B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x00141F64 File Offset: 0x00140164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BuffId);
			}
			if (this.JJNFBPMOHDJ != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.JJNFBPMOHDJ);
			}
			if (this.CGJBCPOMNHE != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CGJBCPOMNHE);
			}
			if (this.MCMGKPLCAAP != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MCMGKPLCAAP);
			}
			if (this.EEEABJCNKDO != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EEEABJCNKDO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007986 RID: 31110 RVA: 0x00142010 File Offset: 0x00140210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JJNFBPMOHDJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JJNFBPMOHDJ);
			}
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
			}
			if (this.MCMGKPLCAAP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MCMGKPLCAAP);
			}
			if (this.CGJBCPOMNHE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CGJBCPOMNHE);
			}
			if (this.EEEABJCNKDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EEEABJCNKDO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x001420B0 File Offset: 0x001402B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MBFIICLMKKD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JJNFBPMOHDJ != 0U)
			{
				this.JJNFBPMOHDJ = other.JJNFBPMOHDJ;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
			}
			if (other.MCMGKPLCAAP != 0U)
			{
				this.MCMGKPLCAAP = other.MCMGKPLCAAP;
			}
			if (other.CGJBCPOMNHE != 0U)
			{
				this.CGJBCPOMNHE = other.CGJBCPOMNHE;
			}
			if (other.EEEABJCNKDO != 0U)
			{
				this.EEEABJCNKDO = other.EEEABJCNKDO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x0014213C File Offset: 0x0014033C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x00142148 File Offset: 0x00140348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.BuffId = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.JJNFBPMOHDJ = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.CGJBCPOMNHE = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.MCMGKPLCAAP = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.EEEABJCNKDO = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E9D RID: 11933
		private static readonly MessageParser<MBFIICLMKKD> _parser = new MessageParser<MBFIICLMKKD>(() => new MBFIICLMKKD());

		// Token: 0x04002E9E RID: 11934
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E9F RID: 11935
		public const int JJNFBPMOHDJFieldNumber = 2;

		// Token: 0x04002EA0 RID: 11936
		private uint jJNFBPMOHDJ_;

		// Token: 0x04002EA1 RID: 11937
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04002EA2 RID: 11938
		private uint buffId_;

		// Token: 0x04002EA3 RID: 11939
		public const int MCMGKPLCAAPFieldNumber = 12;

		// Token: 0x04002EA4 RID: 11940
		private uint mCMGKPLCAAP_;

		// Token: 0x04002EA5 RID: 11941
		public const int CGJBCPOMNHEFieldNumber = 9;

		// Token: 0x04002EA6 RID: 11942
		private uint cGJBCPOMNHE_;

		// Token: 0x04002EA7 RID: 11943
		public const int EEEABJCNKDOFieldNumber = 14;

		// Token: 0x04002EA8 RID: 11944
		private uint eEEABJCNKDO_;
	}
}
