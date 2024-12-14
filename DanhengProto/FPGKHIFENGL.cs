using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005BD RID: 1469
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FPGKHIFENGL : IMessage<FPGKHIFENGL>, IMessage, IEquatable<FPGKHIFENGL>, IDeepCloneable<FPGKHIFENGL>, IBufferMessage
	{
		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x060041A8 RID: 16808 RVA: 0x000B2CD7 File Offset: 0x000B0ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FPGKHIFENGL> Parser
		{
			get
			{
				return FPGKHIFENGL._parser;
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x000B2CDE File Offset: 0x000B0EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FPGKHIFENGLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x060041AA RID: 16810 RVA: 0x000B2CF0 File Offset: 0x000B0EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FPGKHIFENGL.Descriptor;
			}
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x000B2CF7 File Offset: 0x000B0EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPGKHIFENGL()
		{
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x000B2CFF File Offset: 0x000B0EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPGKHIFENGL(FPGKHIFENGL other) : this()
		{
			this.modifierSourceType_ = other.modifierSourceType_;
			this.id_ = other.id_;
			this.nBGNFNALOFK_ = other.nBGNFNALOFK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041AD RID: 16813 RVA: 0x000B2D3C File Offset: 0x000B0F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPGKHIFENGL Clone()
		{
			return new FPGKHIFENGL(this);
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x060041AE RID: 16814 RVA: 0x000B2D44 File Offset: 0x000B0F44
		// (set) Token: 0x060041AF RID: 16815 RVA: 0x000B2D4C File Offset: 0x000B0F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NAJIKLNPGFH ModifierSourceType
		{
			get
			{
				return this.modifierSourceType_;
			}
			set
			{
				this.modifierSourceType_ = value;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x000B2D55 File Offset: 0x000B0F55
		// (set) Token: 0x060041B1 RID: 16817 RVA: 0x000B2D5D File Offset: 0x000B0F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x060041B2 RID: 16818 RVA: 0x000B2D66 File Offset: 0x000B0F66
		// (set) Token: 0x060041B3 RID: 16819 RVA: 0x000B2D6E File Offset: 0x000B0F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentType NBGNFNALOFK
		{
			get
			{
				return this.nBGNFNALOFK_;
			}
			set
			{
				this.nBGNFNALOFK_ = value;
			}
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x000B2D77 File Offset: 0x000B0F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FPGKHIFENGL);
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x000B2D88 File Offset: 0x000B0F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FPGKHIFENGL other)
		{
			return other != null && (other == this || (this.ModifierSourceType == other.ModifierSourceType && this.Id == other.Id && this.NBGNFNALOFK == other.NBGNFNALOFK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x000B2DE4 File Offset: 0x000B0FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ModifierSourceType != NAJIKLNPGFH.DifficultyAjustmentSourceNone)
			{
				num ^= this.ModifierSourceType.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.NBGNFNALOFK != DifficultyAdjustmentType.DifficultyAjustmentTypeDefault)
			{
				num ^= this.NBGNFNALOFK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x000B2E61 File Offset: 0x000B1061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x000B2E69 File Offset: 0x000B1069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x000B2E74 File Offset: 0x000B1074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ModifierSourceType != NAJIKLNPGFH.DifficultyAjustmentSourceNone)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ModifierSourceType);
			}
			if (this.NBGNFNALOFK != DifficultyAdjustmentType.DifficultyAjustmentTypeDefault)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.NBGNFNALOFK);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x000B2EEC File Offset: 0x000B10EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ModifierSourceType != NAJIKLNPGFH.DifficultyAjustmentSourceNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ModifierSourceType);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.NBGNFNALOFK != DifficultyAdjustmentType.DifficultyAjustmentTypeDefault)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NBGNFNALOFK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x000B2F5C File Offset: 0x000B115C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FPGKHIFENGL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ModifierSourceType != NAJIKLNPGFH.DifficultyAjustmentSourceNone)
			{
				this.ModifierSourceType = other.ModifierSourceType;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.NBGNFNALOFK != DifficultyAdjustmentType.DifficultyAjustmentTypeDefault)
			{
				this.NBGNFNALOFK = other.NBGNFNALOFK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x000B2FC0 File Offset: 0x000B11C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x000B2FCC File Offset: 0x000B11CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Id = input.ReadUInt32();
						}
					}
					else
					{
						this.NBGNFNALOFK = (DifficultyAdjustmentType)input.ReadEnum();
					}
				}
				else
				{
					this.ModifierSourceType = (NAJIKLNPGFH)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001A0D RID: 6669
		private static readonly MessageParser<FPGKHIFENGL> _parser = new MessageParser<FPGKHIFENGL>(() => new FPGKHIFENGL());

		// Token: 0x04001A0E RID: 6670
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A0F RID: 6671
		public const int ModifierSourceTypeFieldNumber = 6;

		// Token: 0x04001A10 RID: 6672
		private NAJIKLNPGFH modifierSourceType_;

		// Token: 0x04001A11 RID: 6673
		public const int IdFieldNumber = 13;

		// Token: 0x04001A12 RID: 6674
		private uint id_;

		// Token: 0x04001A13 RID: 6675
		public const int NBGNFNALOFKFieldNumber = 10;

		// Token: 0x04001A14 RID: 6676
		private DifficultyAdjustmentType nBGNFNALOFK_;
	}
}
