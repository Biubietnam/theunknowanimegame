using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ABB RID: 2747
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MDLLCLADJCP : IMessage<MDLLCLADJCP>, IMessage, IEquatable<MDLLCLADJCP>, IDeepCloneable<MDLLCLADJCP>, IBufferMessage
	{
		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x060079D2 RID: 31186 RVA: 0x00142C00 File Offset: 0x00140E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MDLLCLADJCP> Parser
		{
			get
			{
				return MDLLCLADJCP._parser;
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x060079D3 RID: 31187 RVA: 0x00142C07 File Offset: 0x00140E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MDLLCLADJCPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x060079D4 RID: 31188 RVA: 0x00142C19 File Offset: 0x00140E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MDLLCLADJCP.Descriptor;
			}
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x00142C20 File Offset: 0x00140E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MDLLCLADJCP()
		{
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x00142C28 File Offset: 0x00140E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MDLLCLADJCP(MDLLCLADJCP other) : this()
		{
			this.cKOICILMBFC_ = other.cKOICILMBFC_;
			this.bPBGKPEIKDN_ = other.bPBGKPEIKDN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079D7 RID: 31191 RVA: 0x00142C59 File Offset: 0x00140E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MDLLCLADJCP Clone()
		{
			return new MDLLCLADJCP(this);
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x060079D8 RID: 31192 RVA: 0x00142C61 File Offset: 0x00140E61
		// (set) Token: 0x060079D9 RID: 31193 RVA: 0x00142C69 File Offset: 0x00140E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CKOICILMBFC
		{
			get
			{
				return this.cKOICILMBFC_;
			}
			set
			{
				this.cKOICILMBFC_ = value;
			}
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x060079DA RID: 31194 RVA: 0x00142C72 File Offset: 0x00140E72
		// (set) Token: 0x060079DB RID: 31195 RVA: 0x00142C7A File Offset: 0x00140E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BPBGKPEIKDN
		{
			get
			{
				return this.bPBGKPEIKDN_;
			}
			set
			{
				this.bPBGKPEIKDN_ = value;
			}
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x00142C83 File Offset: 0x00140E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MDLLCLADJCP);
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x00142C91 File Offset: 0x00140E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MDLLCLADJCP other)
		{
			return other != null && (other == this || (this.CKOICILMBFC == other.CKOICILMBFC && this.BPBGKPEIKDN == other.BPBGKPEIKDN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x00142CD0 File Offset: 0x00140ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CKOICILMBFC != 0U)
			{
				num ^= this.CKOICILMBFC.GetHashCode();
			}
			if (this.BPBGKPEIKDN != 0U)
			{
				num ^= this.BPBGKPEIKDN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x00142D28 File Offset: 0x00140F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x00142D30 File Offset: 0x00140F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x00142D3C File Offset: 0x00140F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CKOICILMBFC != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CKOICILMBFC);
			}
			if (this.BPBGKPEIKDN != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.BPBGKPEIKDN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x00142D98 File Offset: 0x00140F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CKOICILMBFC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CKOICILMBFC);
			}
			if (this.BPBGKPEIKDN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BPBGKPEIKDN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079E3 RID: 31203 RVA: 0x00142DF0 File Offset: 0x00140FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MDLLCLADJCP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CKOICILMBFC != 0U)
			{
				this.CKOICILMBFC = other.CKOICILMBFC;
			}
			if (other.BPBGKPEIKDN != 0U)
			{
				this.BPBGKPEIKDN = other.BPBGKPEIKDN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060079E4 RID: 31204 RVA: 0x00142E40 File Offset: 0x00141040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079E5 RID: 31205 RVA: 0x00142E4C File Offset: 0x0014104C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BPBGKPEIKDN = input.ReadUInt32();
					}
				}
				else
				{
					this.CKOICILMBFC = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002EBF RID: 11967
		private static readonly MessageParser<MDLLCLADJCP> _parser = new MessageParser<MDLLCLADJCP>(() => new MDLLCLADJCP());

		// Token: 0x04002EC0 RID: 11968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EC1 RID: 11969
		public const int CKOICILMBFCFieldNumber = 2;

		// Token: 0x04002EC2 RID: 11970
		private uint cKOICILMBFC_;

		// Token: 0x04002EC3 RID: 11971
		public const int BPBGKPEIKDNFieldNumber = 6;

		// Token: 0x04002EC4 RID: 11972
		private uint bPBGKPEIKDN_;
	}
}
