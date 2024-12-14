using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000625 RID: 1573
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAuthkeyScRsp : IMessage<GetAuthkeyScRsp>, IMessage, IEquatable<GetAuthkeyScRsp>, IDeepCloneable<GetAuthkeyScRsp>, IBufferMessage
	{
		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06004685 RID: 18053 RVA: 0x000C0F33 File Offset: 0x000BF133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAuthkeyScRsp> Parser
		{
			get
			{
				return GetAuthkeyScRsp._parser;
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x000C0F3A File Offset: 0x000BF13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAuthkeyScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06004687 RID: 18055 RVA: 0x000C0F4C File Offset: 0x000BF14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAuthkeyScRsp.Descriptor;
			}
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x000C0F53 File Offset: 0x000BF153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAuthkeyScRsp()
		{
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x000C0F74 File Offset: 0x000BF174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAuthkeyScRsp(GetAuthkeyScRsp other) : this()
		{
			this.iEABDLMOEBJ_ = other.iEABDLMOEBJ_;
			this.aDHFDKEPCKL_ = other.aDHFDKEPCKL_;
			this.cNKMGCPCCJB_ = other.cNKMGCPCCJB_;
			this.kMGOHIGOEBG_ = other.kMGOHIGOEBG_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x000C0FD4 File Offset: 0x000BF1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAuthkeyScRsp Clone()
		{
			return new GetAuthkeyScRsp(this);
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x0600468B RID: 18059 RVA: 0x000C0FDC File Offset: 0x000BF1DC
		// (set) Token: 0x0600468C RID: 18060 RVA: 0x000C0FE4 File Offset: 0x000BF1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IEABDLMOEBJ
		{
			get
			{
				return this.iEABDLMOEBJ_;
			}
			set
			{
				this.iEABDLMOEBJ_ = value;
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x0600468D RID: 18061 RVA: 0x000C0FED File Offset: 0x000BF1ED
		// (set) Token: 0x0600468E RID: 18062 RVA: 0x000C0FF5 File Offset: 0x000BF1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ADHFDKEPCKL
		{
			get
			{
				return this.aDHFDKEPCKL_;
			}
			set
			{
				this.aDHFDKEPCKL_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600468F RID: 18063 RVA: 0x000C1008 File Offset: 0x000BF208
		// (set) Token: 0x06004690 RID: 18064 RVA: 0x000C1010 File Offset: 0x000BF210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CNKMGCPCCJB
		{
			get
			{
				return this.cNKMGCPCCJB_;
			}
			set
			{
				this.cNKMGCPCCJB_ = value;
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06004691 RID: 18065 RVA: 0x000C1019 File Offset: 0x000BF219
		// (set) Token: 0x06004692 RID: 18066 RVA: 0x000C1021 File Offset: 0x000BF221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string KMGOHIGOEBG
		{
			get
			{
				return this.kMGOHIGOEBG_;
			}
			set
			{
				this.kMGOHIGOEBG_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06004693 RID: 18067 RVA: 0x000C1034 File Offset: 0x000BF234
		// (set) Token: 0x06004694 RID: 18068 RVA: 0x000C103C File Offset: 0x000BF23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x000C1045 File Offset: 0x000BF245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAuthkeyScRsp);
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x000C1054 File Offset: 0x000BF254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAuthkeyScRsp other)
		{
			return other != null && (other == this || (this.IEABDLMOEBJ == other.IEABDLMOEBJ && !(this.ADHFDKEPCKL != other.ADHFDKEPCKL) && this.CNKMGCPCCJB == other.CNKMGCPCCJB && !(this.KMGOHIGOEBG != other.KMGOHIGOEBG) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x000C10D8 File Offset: 0x000BF2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IEABDLMOEBJ != 0U)
			{
				num ^= this.IEABDLMOEBJ.GetHashCode();
			}
			if (this.ADHFDKEPCKL.Length != 0)
			{
				num ^= this.ADHFDKEPCKL.GetHashCode();
			}
			if (this.CNKMGCPCCJB != 0U)
			{
				num ^= this.CNKMGCPCCJB.GetHashCode();
			}
			if (this.KMGOHIGOEBG.Length != 0)
			{
				num ^= this.KMGOHIGOEBG.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x000C117F File Offset: 0x000BF37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x000C1187 File Offset: 0x000BF387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x000C1190 File Offset: 0x000BF390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ADHFDKEPCKL.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ADHFDKEPCKL);
			}
			if (this.CNKMGCPCCJB != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CNKMGCPCCJB);
			}
			if (this.KMGOHIGOEBG.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.KMGOHIGOEBG);
			}
			if (this.IEABDLMOEBJ != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.IEABDLMOEBJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x000C1248 File Offset: 0x000BF448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IEABDLMOEBJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IEABDLMOEBJ);
			}
			if (this.ADHFDKEPCKL.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ADHFDKEPCKL);
			}
			if (this.CNKMGCPCCJB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CNKMGCPCCJB);
			}
			if (this.KMGOHIGOEBG.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.KMGOHIGOEBG);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x000C12F0 File Offset: 0x000BF4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAuthkeyScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IEABDLMOEBJ != 0U)
			{
				this.IEABDLMOEBJ = other.IEABDLMOEBJ;
			}
			if (other.ADHFDKEPCKL.Length != 0)
			{
				this.ADHFDKEPCKL = other.ADHFDKEPCKL;
			}
			if (other.CNKMGCPCCJB != 0U)
			{
				this.CNKMGCPCCJB = other.CNKMGCPCCJB;
			}
			if (other.KMGOHIGOEBG.Length != 0)
			{
				this.KMGOHIGOEBG = other.KMGOHIGOEBG;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x000C1386 File Offset: 0x000BF586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x000C1390 File Offset: 0x000BF590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 16U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 26U)
					{
						this.ADHFDKEPCKL = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.CNKMGCPCCJB = input.ReadUInt32();
						continue;
					}
					if (num == 82U)
					{
						this.KMGOHIGOEBG = input.ReadString();
						continue;
					}
					if (num == 96U)
					{
						this.IEABDLMOEBJ = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001C28 RID: 7208
		private static readonly MessageParser<GetAuthkeyScRsp> _parser = new MessageParser<GetAuthkeyScRsp>(() => new GetAuthkeyScRsp());

		// Token: 0x04001C29 RID: 7209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C2A RID: 7210
		public const int IEABDLMOEBJFieldNumber = 12;

		// Token: 0x04001C2B RID: 7211
		private uint iEABDLMOEBJ_;

		// Token: 0x04001C2C RID: 7212
		public const int ADHFDKEPCKLFieldNumber = 3;

		// Token: 0x04001C2D RID: 7213
		private string aDHFDKEPCKL_ = "";

		// Token: 0x04001C2E RID: 7214
		public const int CNKMGCPCCJBFieldNumber = 8;

		// Token: 0x04001C2F RID: 7215
		private uint cNKMGCPCCJB_;

		// Token: 0x04001C30 RID: 7216
		public const int KMGOHIGOEBGFieldNumber = 10;

		// Token: 0x04001C31 RID: 7217
		private string kMGOHIGOEBG_ = "";

		// Token: 0x04001C32 RID: 7218
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04001C33 RID: 7219
		private uint retcode_;
	}
}
