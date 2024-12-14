using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200048D RID: 1165
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EOLOFLGJCIP : IMessage<EOLOFLGJCIP>, IMessage, IEquatable<EOLOFLGJCIP>, IDeepCloneable<EOLOFLGJCIP>, IBufferMessage
	{
		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x0008E968 File Offset: 0x0008CB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EOLOFLGJCIP> Parser
		{
			get
			{
				return EOLOFLGJCIP._parser;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x060033EA RID: 13290 RVA: 0x0008E96F File Offset: 0x0008CB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EOLOFLGJCIPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x0008E981 File Offset: 0x0008CB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EOLOFLGJCIP.Descriptor;
			}
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x0008E988 File Offset: 0x0008CB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EOLOFLGJCIP()
		{
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x0008E990 File Offset: 0x0008CB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EOLOFLGJCIP(EOLOFLGJCIP other) : this()
		{
			this.kPLDAKLKEBP_ = other.kPLDAKLKEBP_;
			this.lLMNFCCPMLI_ = other.lLMNFCCPMLI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x0008E9C1 File Offset: 0x0008CBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EOLOFLGJCIP Clone()
		{
			return new EOLOFLGJCIP(this);
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x0008E9C9 File Offset: 0x0008CBC9
		// (set) Token: 0x060033F0 RID: 13296 RVA: 0x0008E9D1 File Offset: 0x0008CBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KPLDAKLKEBP
		{
			get
			{
				return this.kPLDAKLKEBP_;
			}
			set
			{
				this.kPLDAKLKEBP_ = value;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x060033F1 RID: 13297 RVA: 0x0008E9DA File Offset: 0x0008CBDA
		// (set) Token: 0x060033F2 RID: 13298 RVA: 0x0008E9E2 File Offset: 0x0008CBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LLMNFCCPMLI
		{
			get
			{
				return this.lLMNFCCPMLI_;
			}
			set
			{
				this.lLMNFCCPMLI_ = value;
			}
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x0008E9EB File Offset: 0x0008CBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EOLOFLGJCIP);
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x0008E9F9 File Offset: 0x0008CBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EOLOFLGJCIP other)
		{
			return other != null && (other == this || (this.KPLDAKLKEBP == other.KPLDAKLKEBP && this.LLMNFCCPMLI == other.LLMNFCCPMLI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x0008EA38 File Offset: 0x0008CC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KPLDAKLKEBP != 0U)
			{
				num ^= this.KPLDAKLKEBP.GetHashCode();
			}
			if (this.LLMNFCCPMLI != 0U)
			{
				num ^= this.LLMNFCCPMLI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x0008EA90 File Offset: 0x0008CC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x0008EA98 File Offset: 0x0008CC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x0008EAA4 File Offset: 0x0008CCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KPLDAKLKEBP != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.KPLDAKLKEBP);
			}
			if (this.LLMNFCCPMLI != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.LLMNFCCPMLI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x0008EAFC File Offset: 0x0008CCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KPLDAKLKEBP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KPLDAKLKEBP);
			}
			if (this.LLMNFCCPMLI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LLMNFCCPMLI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x0008EB54 File Offset: 0x0008CD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EOLOFLGJCIP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KPLDAKLKEBP != 0U)
			{
				this.KPLDAKLKEBP = other.KPLDAKLKEBP;
			}
			if (other.LLMNFCCPMLI != 0U)
			{
				this.LLMNFCCPMLI = other.LLMNFCCPMLI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x0008EBA4 File Offset: 0x0008CDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x0008EBB0 File Offset: 0x0008CDB0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LLMNFCCPMLI = input.ReadUInt32();
					}
				}
				else
				{
					this.KPLDAKLKEBP = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400149B RID: 5275
		private static readonly MessageParser<EOLOFLGJCIP> _parser = new MessageParser<EOLOFLGJCIP>(() => new EOLOFLGJCIP());

		// Token: 0x0400149C RID: 5276
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400149D RID: 5277
		public const int KPLDAKLKEBPFieldNumber = 1;

		// Token: 0x0400149E RID: 5278
		private uint kPLDAKLKEBP_;

		// Token: 0x0400149F RID: 5279
		public const int LLMNFCCPMLIFieldNumber = 2;

		// Token: 0x040014A0 RID: 5280
		private uint lLMNFCCPMLI_;
	}
}
