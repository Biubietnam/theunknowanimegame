using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000623 RID: 1571
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAuthkeyCsReq : IMessage<GetAuthkeyCsReq>, IMessage, IEquatable<GetAuthkeyCsReq>, IDeepCloneable<GetAuthkeyCsReq>, IBufferMessage
	{
		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x0600466C RID: 18028 RVA: 0x000C0AF5 File Offset: 0x000BECF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAuthkeyCsReq> Parser
		{
			get
			{
				return GetAuthkeyCsReq._parser;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x0600466D RID: 18029 RVA: 0x000C0AFC File Offset: 0x000BECFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAuthkeyCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x000C0B0E File Offset: 0x000BED0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAuthkeyCsReq.Descriptor;
			}
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x000C0B15 File Offset: 0x000BED15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAuthkeyCsReq()
		{
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x000C0B28 File Offset: 0x000BED28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAuthkeyCsReq(GetAuthkeyCsReq other) : this()
		{
			this.cNKMGCPCCJB_ = other.cNKMGCPCCJB_;
			this.kMGOHIGOEBG_ = other.kMGOHIGOEBG_;
			this.iEABDLMOEBJ_ = other.iEABDLMOEBJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x000C0B65 File Offset: 0x000BED65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAuthkeyCsReq Clone()
		{
			return new GetAuthkeyCsReq(this);
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06004672 RID: 18034 RVA: 0x000C0B6D File Offset: 0x000BED6D
		// (set) Token: 0x06004673 RID: 18035 RVA: 0x000C0B75 File Offset: 0x000BED75
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

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06004674 RID: 18036 RVA: 0x000C0B7E File Offset: 0x000BED7E
		// (set) Token: 0x06004675 RID: 18037 RVA: 0x000C0B86 File Offset: 0x000BED86
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

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x000C0B99 File Offset: 0x000BED99
		// (set) Token: 0x06004677 RID: 18039 RVA: 0x000C0BA1 File Offset: 0x000BEDA1
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

		// Token: 0x06004678 RID: 18040 RVA: 0x000C0BAA File Offset: 0x000BEDAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAuthkeyCsReq);
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x000C0BB8 File Offset: 0x000BEDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAuthkeyCsReq other)
		{
			return other != null && (other == this || (this.CNKMGCPCCJB == other.CNKMGCPCCJB && !(this.KMGOHIGOEBG != other.KMGOHIGOEBG) && this.IEABDLMOEBJ == other.IEABDLMOEBJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x000C0C18 File Offset: 0x000BEE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CNKMGCPCCJB != 0U)
			{
				num ^= this.CNKMGCPCCJB.GetHashCode();
			}
			if (this.KMGOHIGOEBG.Length != 0)
			{
				num ^= this.KMGOHIGOEBG.GetHashCode();
			}
			if (this.IEABDLMOEBJ != 0U)
			{
				num ^= this.IEABDLMOEBJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x000C0C8B File Offset: 0x000BEE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x000C0C93 File Offset: 0x000BEE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x000C0C9C File Offset: 0x000BEE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CNKMGCPCCJB != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CNKMGCPCCJB);
			}
			if (this.IEABDLMOEBJ != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.IEABDLMOEBJ);
			}
			if (this.KMGOHIGOEBG.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.KMGOHIGOEBG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x000C0D18 File Offset: 0x000BEF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CNKMGCPCCJB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CNKMGCPCCJB);
			}
			if (this.KMGOHIGOEBG.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.KMGOHIGOEBG);
			}
			if (this.IEABDLMOEBJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IEABDLMOEBJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x000C0D8C File Offset: 0x000BEF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAuthkeyCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CNKMGCPCCJB != 0U)
			{
				this.CNKMGCPCCJB = other.CNKMGCPCCJB;
			}
			if (other.KMGOHIGOEBG.Length != 0)
			{
				this.KMGOHIGOEBG = other.KMGOHIGOEBG;
			}
			if (other.IEABDLMOEBJ != 0U)
			{
				this.IEABDLMOEBJ = other.IEABDLMOEBJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x000C0DF5 File Offset: 0x000BEFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x000C0E00 File Offset: 0x000BF000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 56U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.KMGOHIGOEBG = input.ReadString();
						}
					}
					else
					{
						this.IEABDLMOEBJ = input.ReadUInt32();
					}
				}
				else
				{
					this.CNKMGCPCCJB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001C1F RID: 7199
		private static readonly MessageParser<GetAuthkeyCsReq> _parser = new MessageParser<GetAuthkeyCsReq>(() => new GetAuthkeyCsReq());

		// Token: 0x04001C20 RID: 7200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C21 RID: 7201
		public const int CNKMGCPCCJBFieldNumber = 3;

		// Token: 0x04001C22 RID: 7202
		private uint cNKMGCPCCJB_;

		// Token: 0x04001C23 RID: 7203
		public const int KMGOHIGOEBGFieldNumber = 11;

		// Token: 0x04001C24 RID: 7204
		private string kMGOHIGOEBG_ = "";

		// Token: 0x04001C25 RID: 7205
		public const int IEABDLMOEBJFieldNumber = 7;

		// Token: 0x04001C26 RID: 7206
		private uint iEABDLMOEBJ_;
	}
}
