using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000863 RID: 2147
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GJNPFNDEHGL : IMessage<GJNPFNDEHGL>, IMessage, IEquatable<GJNPFNDEHGL>, IDeepCloneable<GJNPFNDEHGL>, IBufferMessage
	{
		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x000FCA48 File Offset: 0x000FAC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GJNPFNDEHGL> Parser
		{
			get
			{
				return GJNPFNDEHGL._parser;
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06005F7F RID: 24447 RVA: 0x000FCA4F File Offset: 0x000FAC4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GJNPFNDEHGLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x06005F80 RID: 24448 RVA: 0x000FCA61 File Offset: 0x000FAC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GJNPFNDEHGL.Descriptor;
			}
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x000FCA68 File Offset: 0x000FAC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GJNPFNDEHGL()
		{
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x000FCA70 File Offset: 0x000FAC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GJNPFNDEHGL(GJNPFNDEHGL other) : this()
		{
			this.nKHCICAHMCM_ = other.nKHCICAHMCM_;
			this.fOENAOEGENN_ = other.fOENAOEGENN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x000FCAA1 File Offset: 0x000FACA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GJNPFNDEHGL Clone()
		{
			return new GJNPFNDEHGL(this);
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06005F84 RID: 24452 RVA: 0x000FCAA9 File Offset: 0x000FACA9
		// (set) Token: 0x06005F85 RID: 24453 RVA: 0x000FCAB1 File Offset: 0x000FACB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NKHCICAHMCM
		{
			get
			{
				return this.nKHCICAHMCM_;
			}
			set
			{
				this.nKHCICAHMCM_ = value;
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x000FCABA File Offset: 0x000FACBA
		// (set) Token: 0x06005F87 RID: 24455 RVA: 0x000FCAC2 File Offset: 0x000FACC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FOENAOEGENN
		{
			get
			{
				return this.fOENAOEGENN_;
			}
			set
			{
				this.fOENAOEGENN_ = value;
			}
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x000FCACB File Offset: 0x000FACCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GJNPFNDEHGL);
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x000FCAD9 File Offset: 0x000FACD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GJNPFNDEHGL other)
		{
			return other != null && (other == this || (this.NKHCICAHMCM == other.NKHCICAHMCM && this.FOENAOEGENN == other.FOENAOEGENN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x000FCB18 File Offset: 0x000FAD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NKHCICAHMCM != 0U)
			{
				num ^= this.NKHCICAHMCM.GetHashCode();
			}
			if (this.FOENAOEGENN)
			{
				num ^= this.FOENAOEGENN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x000FCB70 File Offset: 0x000FAD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F8C RID: 24460 RVA: 0x000FCB78 File Offset: 0x000FAD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x000FCB84 File Offset: 0x000FAD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FOENAOEGENN)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.FOENAOEGENN);
			}
			if (this.NKHCICAHMCM != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.NKHCICAHMCM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x000FCBE0 File Offset: 0x000FADE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NKHCICAHMCM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NKHCICAHMCM);
			}
			if (this.FOENAOEGENN)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x000FCC2C File Offset: 0x000FAE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GJNPFNDEHGL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NKHCICAHMCM != 0U)
			{
				this.NKHCICAHMCM = other.NKHCICAHMCM;
			}
			if (other.FOENAOEGENN)
			{
				this.FOENAOEGENN = other.FOENAOEGENN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F90 RID: 24464 RVA: 0x000FCC7C File Offset: 0x000FAE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x000FCC88 File Offset: 0x000FAE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NKHCICAHMCM = input.ReadUInt32();
					}
				}
				else
				{
					this.FOENAOEGENN = input.ReadBool();
				}
			}
		}

		// Token: 0x040024BB RID: 9403
		private static readonly MessageParser<GJNPFNDEHGL> _parser = new MessageParser<GJNPFNDEHGL>(() => new GJNPFNDEHGL());

		// Token: 0x040024BC RID: 9404
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024BD RID: 9405
		public const int NKHCICAHMCMFieldNumber = 15;

		// Token: 0x040024BE RID: 9406
		private uint nKHCICAHMCM_;

		// Token: 0x040024BF RID: 9407
		public const int FOENAOEGENNFieldNumber = 12;

		// Token: 0x040024C0 RID: 9408
		private bool fOENAOEGENN_;
	}
}
