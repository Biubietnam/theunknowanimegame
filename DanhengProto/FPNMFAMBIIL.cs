using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005BF RID: 1471
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FPNMFAMBIIL : IMessage<FPNMFAMBIIL>, IMessage, IEquatable<FPNMFAMBIIL>, IDeepCloneable<FPNMFAMBIIL>, IBufferMessage
	{
		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x000B30C0 File Offset: 0x000B12C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FPNMFAMBIIL> Parser
		{
			get
			{
				return FPNMFAMBIIL._parser;
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x060041C2 RID: 16834 RVA: 0x000B30C7 File Offset: 0x000B12C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FPNMFAMBIILReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x000B30D9 File Offset: 0x000B12D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FPNMFAMBIIL.Descriptor;
			}
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x000B30E0 File Offset: 0x000B12E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPNMFAMBIIL()
		{
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x000B30E8 File Offset: 0x000B12E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPNMFAMBIIL(FPNMFAMBIIL other) : this()
		{
			this.cOJGEGHIADI_ = other.cOJGEGHIADI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x000B310D File Offset: 0x000B130D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPNMFAMBIIL Clone()
		{
			return new FPNMFAMBIIL(this);
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x000B3115 File Offset: 0x000B1315
		// (set) Token: 0x060041C8 RID: 16840 RVA: 0x000B311D File Offset: 0x000B131D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint COJGEGHIADI
		{
			get
			{
				return this.cOJGEGHIADI_;
			}
			set
			{
				this.cOJGEGHIADI_ = value;
			}
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x000B3126 File Offset: 0x000B1326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FPNMFAMBIIL);
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x000B3134 File Offset: 0x000B1334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FPNMFAMBIIL other)
		{
			return other != null && (other == this || (this.COJGEGHIADI == other.COJGEGHIADI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x000B3164 File Offset: 0x000B1364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.COJGEGHIADI != 0U)
			{
				num ^= this.COJGEGHIADI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x000B31A3 File Offset: 0x000B13A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x000B31AB File Offset: 0x000B13AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x000B31B4 File Offset: 0x000B13B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.COJGEGHIADI != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x000B31E8 File Offset: 0x000B13E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.COJGEGHIADI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x000B3226 File Offset: 0x000B1426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FPNMFAMBIIL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.COJGEGHIADI != 0U)
			{
				this.COJGEGHIADI = other.COJGEGHIADI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x000B3257 File Offset: 0x000B1457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x000B3260 File Offset: 0x000B1460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.COJGEGHIADI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001A16 RID: 6678
		private static readonly MessageParser<FPNMFAMBIIL> _parser = new MessageParser<FPNMFAMBIIL>(() => new FPNMFAMBIIL());

		// Token: 0x04001A17 RID: 6679
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A18 RID: 6680
		public const int COJGEGHIADIFieldNumber = 15;

		// Token: 0x04001A19 RID: 6681
		private uint cOJGEGHIADI_;
	}
}
