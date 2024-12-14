using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000527 RID: 1319
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightEnterCsReq : IMessage<FightEnterCsReq>, IMessage, IEquatable<FightEnterCsReq>, IDeepCloneable<FightEnterCsReq>, IBufferMessage
	{
		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x000A20F7 File Offset: 0x000A02F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightEnterCsReq> Parser
		{
			get
			{
				return FightEnterCsReq._parser;
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x000A20FE File Offset: 0x000A02FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightEnterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x000A2110 File Offset: 0x000A0310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightEnterCsReq.Descriptor;
			}
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x000A2117 File Offset: 0x000A0317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightEnterCsReq()
		{
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x000A212C File Offset: 0x000A032C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightEnterCsReq(FightEnterCsReq other) : this()
		{
			this.lDPPHLJDANL_ = other.lDPPHLJDANL_;
			this.resVersion_ = other.resVersion_;
			this.iPEPBMIKJCN_ = other.iPEPBMIKJCN_;
			this.platform_ = other.platform_;
			this.kMANPJCMAOB_ = other.kMANPJCMAOB_;
			this.jIOPMFNPBNP_ = other.jIOPMFNPBNP_;
			this.uid_ = other.uid_;
			this.cGEGOLLMHCJ_ = other.cGEGOLLMHCJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x000A21B0 File Offset: 0x000A03B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightEnterCsReq Clone()
		{
			return new FightEnterCsReq(this);
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06003AFA RID: 15098 RVA: 0x000A21B8 File Offset: 0x000A03B8
		// (set) Token: 0x06003AFB RID: 15099 RVA: 0x000A21C0 File Offset: 0x000A03C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong LDPPHLJDANL
		{
			get
			{
				return this.lDPPHLJDANL_;
			}
			set
			{
				this.lDPPHLJDANL_ = value;
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x000A21C9 File Offset: 0x000A03C9
		// (set) Token: 0x06003AFD RID: 15101 RVA: 0x000A21D1 File Offset: 0x000A03D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ResVersion
		{
			get
			{
				return this.resVersion_;
			}
			set
			{
				this.resVersion_ = value;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x000A21DA File Offset: 0x000A03DA
		// (set) Token: 0x06003AFF RID: 15103 RVA: 0x000A21E2 File Offset: 0x000A03E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IPEPBMIKJCN
		{
			get
			{
				return this.iPEPBMIKJCN_;
			}
			set
			{
				this.iPEPBMIKJCN_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x000A21F5 File Offset: 0x000A03F5
		// (set) Token: 0x06003B01 RID: 15105 RVA: 0x000A21FD File Offset: 0x000A03FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Platform
		{
			get
			{
				return this.platform_;
			}
			set
			{
				this.platform_ = value;
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x000A2206 File Offset: 0x000A0406
		// (set) Token: 0x06003B03 RID: 15107 RVA: 0x000A220E File Offset: 0x000A040E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KMANPJCMAOB
		{
			get
			{
				return this.kMANPJCMAOB_;
			}
			set
			{
				this.kMANPJCMAOB_ = value;
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06003B04 RID: 15108 RVA: 0x000A2217 File Offset: 0x000A0417
		// (set) Token: 0x06003B05 RID: 15109 RVA: 0x000A221F File Offset: 0x000A041F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JIOPMFNPBNP
		{
			get
			{
				return this.jIOPMFNPBNP_;
			}
			set
			{
				this.jIOPMFNPBNP_ = value;
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06003B06 RID: 15110 RVA: 0x000A2228 File Offset: 0x000A0428
		// (set) Token: 0x06003B07 RID: 15111 RVA: 0x000A2230 File Offset: 0x000A0430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x000A2239 File Offset: 0x000A0439
		// (set) Token: 0x06003B09 RID: 15113 RVA: 0x000A2241 File Offset: 0x000A0441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CGEGOLLMHCJ
		{
			get
			{
				return this.cGEGOLLMHCJ_;
			}
			set
			{
				this.cGEGOLLMHCJ_ = value;
			}
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x000A224A File Offset: 0x000A044A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightEnterCsReq);
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x000A2258 File Offset: 0x000A0458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightEnterCsReq other)
		{
			return other != null && (other == this || (this.LDPPHLJDANL == other.LDPPHLJDANL && this.ResVersion == other.ResVersion && !(this.IPEPBMIKJCN != other.IPEPBMIKJCN) && this.Platform == other.Platform && this.KMANPJCMAOB == other.KMANPJCMAOB && this.JIOPMFNPBNP == other.JIOPMFNPBNP && this.Uid == other.Uid && this.CGEGOLLMHCJ == other.CGEGOLLMHCJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x000A2308 File Offset: 0x000A0508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LDPPHLJDANL != 0UL)
			{
				num ^= this.LDPPHLJDANL.GetHashCode();
			}
			if (this.ResVersion != 0U)
			{
				num ^= this.ResVersion.GetHashCode();
			}
			if (this.IPEPBMIKJCN.Length != 0)
			{
				num ^= this.IPEPBMIKJCN.GetHashCode();
			}
			if (this.Platform != 0U)
			{
				num ^= this.Platform.GetHashCode();
			}
			if (this.KMANPJCMAOB != 0U)
			{
				num ^= this.KMANPJCMAOB.GetHashCode();
			}
			if (this.JIOPMFNPBNP != 0U)
			{
				num ^= this.JIOPMFNPBNP.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.CGEGOLLMHCJ != 0U)
			{
				num ^= this.CGEGOLLMHCJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x000A23F8 File Offset: 0x000A05F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x000A2400 File Offset: 0x000A0600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x000A240C File Offset: 0x000A060C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IPEPBMIKJCN.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.IPEPBMIKJCN);
			}
			if (this.LDPPHLJDANL != 0UL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.LDPPHLJDANL);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Uid);
			}
			if (this.Platform != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Platform);
			}
			if (this.CGEGOLLMHCJ != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CGEGOLLMHCJ);
			}
			if (this.KMANPJCMAOB != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.KMANPJCMAOB);
			}
			if (this.ResVersion != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ResVersion);
			}
			if (this.JIOPMFNPBNP != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.JIOPMFNPBNP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x000A2514 File Offset: 0x000A0714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LDPPHLJDANL != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LDPPHLJDANL);
			}
			if (this.ResVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ResVersion);
			}
			if (this.IPEPBMIKJCN.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.IPEPBMIKJCN);
			}
			if (this.Platform != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Platform);
			}
			if (this.KMANPJCMAOB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KMANPJCMAOB);
			}
			if (this.JIOPMFNPBNP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JIOPMFNPBNP);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.CGEGOLLMHCJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CGEGOLLMHCJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x000A2600 File Offset: 0x000A0800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightEnterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LDPPHLJDANL != 0UL)
			{
				this.LDPPHLJDANL = other.LDPPHLJDANL;
			}
			if (other.ResVersion != 0U)
			{
				this.ResVersion = other.ResVersion;
			}
			if (other.IPEPBMIKJCN.Length != 0)
			{
				this.IPEPBMIKJCN = other.IPEPBMIKJCN;
			}
			if (other.Platform != 0U)
			{
				this.Platform = other.Platform;
			}
			if (other.KMANPJCMAOB != 0U)
			{
				this.KMANPJCMAOB = other.KMANPJCMAOB;
			}
			if (other.JIOPMFNPBNP != 0U)
			{
				this.JIOPMFNPBNP = other.JIOPMFNPBNP;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.CGEGOLLMHCJ != 0U)
			{
				this.CGEGOLLMHCJ = other.CGEGOLLMHCJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x000A26CD File Offset: 0x000A08CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x000A26D8 File Offset: 0x000A08D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num <= 48U)
					{
						if (num == 26U)
						{
							this.IPEPBMIKJCN = input.ReadString();
							continue;
						}
						if (num == 48U)
						{
							this.LDPPHLJDANL = input.ReadUInt64();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.Uid = input.ReadUInt32();
							continue;
						}
						if (num == 80U)
						{
							this.Platform = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 88U)
					{
						this.CGEGOLLMHCJ = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.KMANPJCMAOB = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ResVersion = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.JIOPMFNPBNP = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040017B1 RID: 6065
		private static readonly MessageParser<FightEnterCsReq> _parser = new MessageParser<FightEnterCsReq>(() => new FightEnterCsReq());

		// Token: 0x040017B2 RID: 6066
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017B3 RID: 6067
		public const int LDPPHLJDANLFieldNumber = 6;

		// Token: 0x040017B4 RID: 6068
		private ulong lDPPHLJDANL_;

		// Token: 0x040017B5 RID: 6069
		public const int ResVersionFieldNumber = 13;

		// Token: 0x040017B6 RID: 6070
		private uint resVersion_;

		// Token: 0x040017B7 RID: 6071
		public const int IPEPBMIKJCNFieldNumber = 3;

		// Token: 0x040017B8 RID: 6072
		private string iPEPBMIKJCN_ = "";

		// Token: 0x040017B9 RID: 6073
		public const int PlatformFieldNumber = 10;

		// Token: 0x040017BA RID: 6074
		private uint platform_;

		// Token: 0x040017BB RID: 6075
		public const int KMANPJCMAOBFieldNumber = 12;

		// Token: 0x040017BC RID: 6076
		private uint kMANPJCMAOB_;

		// Token: 0x040017BD RID: 6077
		public const int JIOPMFNPBNPFieldNumber = 14;

		// Token: 0x040017BE RID: 6078
		private uint jIOPMFNPBNP_;

		// Token: 0x040017BF RID: 6079
		public const int UidFieldNumber = 7;

		// Token: 0x040017C0 RID: 6080
		private uint uid_;

		// Token: 0x040017C1 RID: 6081
		public const int CGEGOLLMHCJFieldNumber = 11;

		// Token: 0x040017C2 RID: 6082
		private uint cGEGOLLMHCJ_;
	}
}
