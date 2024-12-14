using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C75 RID: 3189
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OPJNIHCPEIL : IMessage<OPJNIHCPEIL>, IMessage, IEquatable<OPJNIHCPEIL>, IDeepCloneable<OPJNIHCPEIL>, IBufferMessage
	{
		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x06008DB8 RID: 36280 RVA: 0x001768F1 File Offset: 0x00174AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OPJNIHCPEIL> Parser
		{
			get
			{
				return OPJNIHCPEIL._parser;
			}
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x06008DB9 RID: 36281 RVA: 0x001768F8 File Offset: 0x00174AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OPJNIHCPEILReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x06008DBA RID: 36282 RVA: 0x0017690A File Offset: 0x00174B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OPJNIHCPEIL.Descriptor;
			}
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x00176911 File Offset: 0x00174B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPJNIHCPEIL()
		{
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x00176919 File Offset: 0x00174B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPJNIHCPEIL(OPJNIHCPEIL other) : this()
		{
			this.pHFAJJEGNAA_ = other.pHFAJJEGNAA_;
			this.gBHOHDDHHGK_ = other.gBHOHDDHHGK_;
			this.mGLNPNAPECF_ = other.mGLNPNAPECF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x00176956 File Offset: 0x00174B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPJNIHCPEIL Clone()
		{
			return new OPJNIHCPEIL(this);
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x06008DBE RID: 36286 RVA: 0x0017695E File Offset: 0x00174B5E
		// (set) Token: 0x06008DBF RID: 36287 RVA: 0x00176966 File Offset: 0x00174B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHFAJJEGNAA
		{
			get
			{
				return this.pHFAJJEGNAA_;
			}
			set
			{
				this.pHFAJJEGNAA_ = value;
			}
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x06008DC0 RID: 36288 RVA: 0x0017696F File Offset: 0x00174B6F
		// (set) Token: 0x06008DC1 RID: 36289 RVA: 0x00176977 File Offset: 0x00174B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GBHOHDDHHGK
		{
			get
			{
				return this.gBHOHDDHHGK_;
			}
			set
			{
				this.gBHOHDDHHGK_ = value;
			}
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x06008DC2 RID: 36290 RVA: 0x00176980 File Offset: 0x00174B80
		// (set) Token: 0x06008DC3 RID: 36291 RVA: 0x00176988 File Offset: 0x00174B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MGLNPNAPECF
		{
			get
			{
				return this.mGLNPNAPECF_;
			}
			set
			{
				this.mGLNPNAPECF_ = value;
			}
		}

		// Token: 0x06008DC4 RID: 36292 RVA: 0x00176991 File Offset: 0x00174B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OPJNIHCPEIL);
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x001769A0 File Offset: 0x00174BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OPJNIHCPEIL other)
		{
			return other != null && (other == this || (this.PHFAJJEGNAA == other.PHFAJJEGNAA && this.GBHOHDDHHGK == other.GBHOHDDHHGK && this.MGLNPNAPECF == other.MGLNPNAPECF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x001769FC File Offset: 0x00174BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PHFAJJEGNAA != 0U)
			{
				num ^= this.PHFAJJEGNAA.GetHashCode();
			}
			if (this.GBHOHDDHHGK != 0U)
			{
				num ^= this.GBHOHDDHHGK.GetHashCode();
			}
			if (this.MGLNPNAPECF != 0U)
			{
				num ^= this.MGLNPNAPECF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x00176A6D File Offset: 0x00174C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x00176A75 File Offset: 0x00174C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x00176A80 File Offset: 0x00174C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GBHOHDDHHGK != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.GBHOHDDHHGK);
			}
			if (this.MGLNPNAPECF != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MGLNPNAPECF);
			}
			if (this.PHFAJJEGNAA != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.PHFAJJEGNAA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x00176AF8 File Offset: 0x00174CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PHFAJJEGNAA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHFAJJEGNAA);
			}
			if (this.GBHOHDDHHGK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GBHOHDDHHGK);
			}
			if (this.MGLNPNAPECF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MGLNPNAPECF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DCB RID: 36299 RVA: 0x00176B68 File Offset: 0x00174D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OPJNIHCPEIL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PHFAJJEGNAA != 0U)
			{
				this.PHFAJJEGNAA = other.PHFAJJEGNAA;
			}
			if (other.GBHOHDDHHGK != 0U)
			{
				this.GBHOHDDHHGK = other.GBHOHDDHHGK;
			}
			if (other.MGLNPNAPECF != 0U)
			{
				this.MGLNPNAPECF = other.MGLNPNAPECF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008DCC RID: 36300 RVA: 0x00176BCC File Offset: 0x00174DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x00176BD8 File Offset: 0x00174DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 96U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PHFAJJEGNAA = input.ReadUInt32();
						}
					}
					else
					{
						this.MGLNPNAPECF = input.ReadUInt32();
					}
				}
				else
				{
					this.GBHOHDDHHGK = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400366A RID: 13930
		private static readonly MessageParser<OPJNIHCPEIL> _parser = new MessageParser<OPJNIHCPEIL>(() => new OPJNIHCPEIL());

		// Token: 0x0400366B RID: 13931
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400366C RID: 13932
		public const int PHFAJJEGNAAFieldNumber = 13;

		// Token: 0x0400366D RID: 13933
		private uint pHFAJJEGNAA_;

		// Token: 0x0400366E RID: 13934
		public const int GBHOHDDHHGKFieldNumber = 10;

		// Token: 0x0400366F RID: 13935
		private uint gBHOHDDHHGK_;

		// Token: 0x04003670 RID: 13936
		public const int MGLNPNAPECFFieldNumber = 12;

		// Token: 0x04003671 RID: 13937
		private uint mGLNPNAPECF_;
	}
}
