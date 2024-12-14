using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AB9 RID: 2745
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MBOAMPMKCFH : IMessage<MBOAMPMKCFH>, IMessage, IEquatable<MBOAMPMKCFH>, IDeepCloneable<MBOAMPMKCFH>, IBufferMessage
	{
		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x060079BB RID: 31163 RVA: 0x001428D0 File Offset: 0x00140AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MBOAMPMKCFH> Parser
		{
			get
			{
				return MBOAMPMKCFH._parser;
			}
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x060079BC RID: 31164 RVA: 0x001428D7 File Offset: 0x00140AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MBOAMPMKCFHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x060079BD RID: 31165 RVA: 0x001428E9 File Offset: 0x00140AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MBOAMPMKCFH.Descriptor;
			}
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x001428F0 File Offset: 0x00140AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBOAMPMKCFH()
		{
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x001428F8 File Offset: 0x00140AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBOAMPMKCFH(MBOAMPMKCFH other) : this()
		{
			this.oJCPEJFHEIP_ = other.oJCPEJFHEIP_;
			this.iOAPPNCJJCJ_ = other.iOAPPNCJJCJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x00142929 File Offset: 0x00140B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBOAMPMKCFH Clone()
		{
			return new MBOAMPMKCFH(this);
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x060079C1 RID: 31169 RVA: 0x00142931 File Offset: 0x00140B31
		// (set) Token: 0x060079C2 RID: 31170 RVA: 0x00142939 File Offset: 0x00140B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OJCPEJFHEIP
		{
			get
			{
				return this.oJCPEJFHEIP_;
			}
			set
			{
				this.oJCPEJFHEIP_ = value;
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x060079C3 RID: 31171 RVA: 0x00142942 File Offset: 0x00140B42
		// (set) Token: 0x060079C4 RID: 31172 RVA: 0x0014294A File Offset: 0x00140B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IOAPPNCJJCJ
		{
			get
			{
				return this.iOAPPNCJJCJ_;
			}
			set
			{
				this.iOAPPNCJJCJ_ = value;
			}
		}

		// Token: 0x060079C5 RID: 31173 RVA: 0x00142953 File Offset: 0x00140B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MBOAMPMKCFH);
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x00142961 File Offset: 0x00140B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MBOAMPMKCFH other)
		{
			return other != null && (other == this || (this.OJCPEJFHEIP == other.OJCPEJFHEIP && this.IOAPPNCJJCJ == other.IOAPPNCJJCJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079C7 RID: 31175 RVA: 0x001429A0 File Offset: 0x00140BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OJCPEJFHEIP != 0U)
			{
				num ^= this.OJCPEJFHEIP.GetHashCode();
			}
			if (this.IOAPPNCJJCJ != 0U)
			{
				num ^= this.IOAPPNCJJCJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079C8 RID: 31176 RVA: 0x001429F8 File Offset: 0x00140BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x00142A00 File Offset: 0x00140C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079CA RID: 31178 RVA: 0x00142A0C File Offset: 0x00140C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OJCPEJFHEIP != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.OJCPEJFHEIP);
			}
			if (this.IOAPPNCJJCJ != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.IOAPPNCJJCJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x00142A64 File Offset: 0x00140C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OJCPEJFHEIP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OJCPEJFHEIP);
			}
			if (this.IOAPPNCJJCJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IOAPPNCJJCJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079CC RID: 31180 RVA: 0x00142ABC File Offset: 0x00140CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MBOAMPMKCFH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OJCPEJFHEIP != 0U)
			{
				this.OJCPEJFHEIP = other.OJCPEJFHEIP;
			}
			if (other.IOAPPNCJJCJ != 0U)
			{
				this.IOAPPNCJJCJ = other.IOAPPNCJJCJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x00142B0C File Offset: 0x00140D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x00142B18 File Offset: 0x00140D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IOAPPNCJJCJ = input.ReadUInt32();
					}
				}
				else
				{
					this.OJCPEJFHEIP = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002EB8 RID: 11960
		private static readonly MessageParser<MBOAMPMKCFH> _parser = new MessageParser<MBOAMPMKCFH>(() => new MBOAMPMKCFH());

		// Token: 0x04002EB9 RID: 11961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EBA RID: 11962
		public const int OJCPEJFHEIPFieldNumber = 1;

		// Token: 0x04002EBB RID: 11963
		private uint oJCPEJFHEIP_;

		// Token: 0x04002EBC RID: 11964
		public const int IOAPPNCJJCJFieldNumber = 8;

		// Token: 0x04002EBD RID: 11965
		private uint iOAPPNCJJCJ_;
	}
}
