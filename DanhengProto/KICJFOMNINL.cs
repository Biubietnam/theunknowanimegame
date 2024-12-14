using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009AB RID: 2475
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KICJFOMNINL : IMessage<KICJFOMNINL>, IMessage, IEquatable<KICJFOMNINL>, IDeepCloneable<KICJFOMNINL>, IBufferMessage
	{
		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x06006EA8 RID: 28328 RVA: 0x00127980 File Offset: 0x00125B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KICJFOMNINL> Parser
		{
			get
			{
				return KICJFOMNINL._parser;
			}
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x06006EA9 RID: 28329 RVA: 0x00127987 File Offset: 0x00125B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KICJFOMNINLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x06006EAA RID: 28330 RVA: 0x00127999 File Offset: 0x00125B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KICJFOMNINL.Descriptor;
			}
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x001279A0 File Offset: 0x00125BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KICJFOMNINL()
		{
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x001279A8 File Offset: 0x00125BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KICJFOMNINL(KICJFOMNINL other) : this()
		{
			this.gBHOHDDHHGK_ = other.gBHOHDDHHGK_;
			this.eIOPNPBAPKM_ = other.eIOPNPBAPKM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x001279D9 File Offset: 0x00125BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KICJFOMNINL Clone()
		{
			return new KICJFOMNINL(this);
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x06006EAE RID: 28334 RVA: 0x001279E1 File Offset: 0x00125BE1
		// (set) Token: 0x06006EAF RID: 28335 RVA: 0x001279E9 File Offset: 0x00125BE9
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

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x06006EB0 RID: 28336 RVA: 0x001279F2 File Offset: 0x00125BF2
		// (set) Token: 0x06006EB1 RID: 28337 RVA: 0x001279FA File Offset: 0x00125BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EIOPNPBAPKM
		{
			get
			{
				return this.eIOPNPBAPKM_;
			}
			set
			{
				this.eIOPNPBAPKM_ = value;
			}
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x00127A03 File Offset: 0x00125C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KICJFOMNINL);
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x00127A11 File Offset: 0x00125C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KICJFOMNINL other)
		{
			return other != null && (other == this || (this.GBHOHDDHHGK == other.GBHOHDDHHGK && this.EIOPNPBAPKM == other.EIOPNPBAPKM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x00127A50 File Offset: 0x00125C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GBHOHDDHHGK != 0U)
			{
				num ^= this.GBHOHDDHHGK.GetHashCode();
			}
			if (this.EIOPNPBAPKM != 0U)
			{
				num ^= this.EIOPNPBAPKM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x00127AA8 File Offset: 0x00125CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x00127AB0 File Offset: 0x00125CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x00127ABC File Offset: 0x00125CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GBHOHDDHHGK != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GBHOHDDHHGK);
			}
			if (this.EIOPNPBAPKM != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EIOPNPBAPKM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x00127B18 File Offset: 0x00125D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GBHOHDDHHGK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GBHOHDDHHGK);
			}
			if (this.EIOPNPBAPKM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EIOPNPBAPKM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x00127B70 File Offset: 0x00125D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KICJFOMNINL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GBHOHDDHHGK != 0U)
			{
				this.GBHOHDDHHGK = other.GBHOHDDHHGK;
			}
			if (other.EIOPNPBAPKM != 0U)
			{
				this.EIOPNPBAPKM = other.EIOPNPBAPKM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x00127BC0 File Offset: 0x00125DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EBB RID: 28347 RVA: 0x00127BCC File Offset: 0x00125DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EIOPNPBAPKM = input.ReadUInt32();
					}
				}
				else
				{
					this.GBHOHDDHHGK = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002A7D RID: 10877
		private static readonly MessageParser<KICJFOMNINL> _parser = new MessageParser<KICJFOMNINL>(() => new KICJFOMNINL());

		// Token: 0x04002A7E RID: 10878
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A7F RID: 10879
		public const int GBHOHDDHHGKFieldNumber = 8;

		// Token: 0x04002A80 RID: 10880
		private uint gBHOHDDHHGK_;

		// Token: 0x04002A81 RID: 10881
		public const int EIOPNPBAPKMFieldNumber = 12;

		// Token: 0x04002A82 RID: 10882
		private uint eIOPNPBAPKM_;
	}
}
