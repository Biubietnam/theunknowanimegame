using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000025 RID: 37
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AceAntiCheaterCsReq : IMessage<AceAntiCheaterCsReq>, IMessage, IEquatable<AceAntiCheaterCsReq>, IDeepCloneable<AceAntiCheaterCsReq>, IBufferMessage
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00005080 File Offset: 0x00003280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AceAntiCheaterCsReq> Parser
		{
			get
			{
				return AceAntiCheaterCsReq._parser;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00005087 File Offset: 0x00003287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AceAntiCheaterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00005099 File Offset: 0x00003299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AceAntiCheaterCsReq.Descriptor;
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000050A0 File Offset: 0x000032A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiCheaterCsReq()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000050B3 File Offset: 0x000032B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiCheaterCsReq(AceAntiCheaterCsReq other) : this()
		{
			this.bEIAPFDPOFH_ = other.bEIAPFDPOFH_;
			this.cGOCHPPAAKM_ = other.cGOCHPPAAKM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000050E4 File Offset: 0x000032E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiCheaterCsReq Clone()
		{
			return new AceAntiCheaterCsReq(this);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000050EC File Offset: 0x000032EC
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000050F4 File Offset: 0x000032F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BEIAPFDPOFH
		{
			get
			{
				return this.bEIAPFDPOFH_;
			}
			set
			{
				this.bEIAPFDPOFH_ = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000050FD File Offset: 0x000032FD
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00005105 File Offset: 0x00003305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CGOCHPPAAKM
		{
			get
			{
				return this.cGOCHPPAAKM_;
			}
			set
			{
				this.cGOCHPPAAKM_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005118 File Offset: 0x00003318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AceAntiCheaterCsReq);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005128 File Offset: 0x00003328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AceAntiCheaterCsReq other)
		{
			return other != null && (other == this || (this.BEIAPFDPOFH == other.BEIAPFDPOFH && !(this.CGOCHPPAAKM != other.CGOCHPPAAKM) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005178 File Offset: 0x00003378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BEIAPFDPOFH != 0U)
			{
				num ^= this.BEIAPFDPOFH.GetHashCode();
			}
			if (this.CGOCHPPAAKM.Length != 0)
			{
				num ^= this.CGOCHPPAAKM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000051D2 File Offset: 0x000033D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000051DA File Offset: 0x000033DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000051E4 File Offset: 0x000033E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BEIAPFDPOFH != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BEIAPFDPOFH);
			}
			if (this.CGOCHPPAAKM.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.CGOCHPPAAKM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00005244 File Offset: 0x00003444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BEIAPFDPOFH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BEIAPFDPOFH);
			}
			if (this.CGOCHPPAAKM.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CGOCHPPAAKM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000052A0 File Offset: 0x000034A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AceAntiCheaterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BEIAPFDPOFH != 0U)
			{
				this.BEIAPFDPOFH = other.BEIAPFDPOFH;
			}
			if (other.CGOCHPPAAKM.Length != 0)
			{
				this.CGOCHPPAAKM = other.CGOCHPPAAKM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000052F5 File Offset: 0x000034F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00005300 File Offset: 0x00003500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CGOCHPPAAKM = input.ReadString();
					}
				}
				else
				{
					this.BEIAPFDPOFH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000071 RID: 113
		private static readonly MessageParser<AceAntiCheaterCsReq> _parser = new MessageParser<AceAntiCheaterCsReq>(() => new AceAntiCheaterCsReq());

		// Token: 0x04000072 RID: 114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000073 RID: 115
		public const int BEIAPFDPOFHFieldNumber = 1;

		// Token: 0x04000074 RID: 116
		private uint bEIAPFDPOFH_;

		// Token: 0x04000075 RID: 117
		public const int CGOCHPPAAKMFieldNumber = 7;

		// Token: 0x04000076 RID: 118
		private string cGOCHPPAAKM_ = "";
	}
}
