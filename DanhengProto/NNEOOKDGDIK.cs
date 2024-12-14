using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C27 RID: 3111
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NNEOOKDGDIK : IMessage<NNEOOKDGDIK>, IMessage, IEquatable<NNEOOKDGDIK>, IDeepCloneable<NNEOOKDGDIK>, IBufferMessage
	{
		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x060089D6 RID: 35286 RVA: 0x0016C061 File Offset: 0x0016A261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NNEOOKDGDIK> Parser
		{
			get
			{
				return NNEOOKDGDIK._parser;
			}
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x060089D7 RID: 35287 RVA: 0x0016C068 File Offset: 0x0016A268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NNEOOKDGDIKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x060089D8 RID: 35288 RVA: 0x0016C07A File Offset: 0x0016A27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NNEOOKDGDIK.Descriptor;
			}
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x0016C081 File Offset: 0x0016A281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NNEOOKDGDIK()
		{
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x0016C08C File Offset: 0x0016A28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NNEOOKDGDIK(NNEOOKDGDIK other) : this()
		{
			this.level_ = other.level_;
			this.dCLLHFAOHLF_ = other.dCLLHFAOHLF_;
			this.cPCBPJCENOH_ = other.cPCBPJCENOH_;
			this.lFNCPMMHLCO_ = other.lFNCPMMHLCO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x0016C0E0 File Offset: 0x0016A2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NNEOOKDGDIK Clone()
		{
			return new NNEOOKDGDIK(this);
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x060089DC RID: 35292 RVA: 0x0016C0E8 File Offset: 0x0016A2E8
		// (set) Token: 0x060089DD RID: 35293 RVA: 0x0016C0F0 File Offset: 0x0016A2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x060089DE RID: 35294 RVA: 0x0016C0F9 File Offset: 0x0016A2F9
		// (set) Token: 0x060089DF RID: 35295 RVA: 0x0016C101 File Offset: 0x0016A301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DCLLHFAOHLF
		{
			get
			{
				return this.dCLLHFAOHLF_;
			}
			set
			{
				this.dCLLHFAOHLF_ = value;
			}
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x060089E0 RID: 35296 RVA: 0x0016C10A File Offset: 0x0016A30A
		// (set) Token: 0x060089E1 RID: 35297 RVA: 0x0016C112 File Offset: 0x0016A312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CPCBPJCENOH
		{
			get
			{
				return this.cPCBPJCENOH_;
			}
			set
			{
				this.cPCBPJCENOH_ = value;
			}
		}

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x060089E2 RID: 35298 RVA: 0x0016C11B File Offset: 0x0016A31B
		// (set) Token: 0x060089E3 RID: 35299 RVA: 0x0016C123 File Offset: 0x0016A323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LFNCPMMHLCO
		{
			get
			{
				return this.lFNCPMMHLCO_;
			}
			set
			{
				this.lFNCPMMHLCO_ = value;
			}
		}

		// Token: 0x060089E4 RID: 35300 RVA: 0x0016C12C File Offset: 0x0016A32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NNEOOKDGDIK);
		}

		// Token: 0x060089E5 RID: 35301 RVA: 0x0016C13C File Offset: 0x0016A33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NNEOOKDGDIK other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.DCLLHFAOHLF == other.DCLLHFAOHLF && this.CPCBPJCENOH == other.CPCBPJCENOH && this.LFNCPMMHLCO == other.LFNCPMMHLCO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089E6 RID: 35302 RVA: 0x0016C1A8 File Offset: 0x0016A3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.DCLLHFAOHLF != 0U)
			{
				num ^= this.DCLLHFAOHLF.GetHashCode();
			}
			if (this.CPCBPJCENOH)
			{
				num ^= this.CPCBPJCENOH.GetHashCode();
			}
			if (this.LFNCPMMHLCO != 0U)
			{
				num ^= this.LFNCPMMHLCO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060089E7 RID: 35303 RVA: 0x0016C232 File Offset: 0x0016A432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060089E8 RID: 35304 RVA: 0x0016C23A File Offset: 0x0016A43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089E9 RID: 35305 RVA: 0x0016C244 File Offset: 0x0016A444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LFNCPMMHLCO != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LFNCPMMHLCO);
			}
			if (this.DCLLHFAOHLF != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.DCLLHFAOHLF);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Level);
			}
			if (this.CPCBPJCENOH)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.CPCBPJCENOH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089EA RID: 35306 RVA: 0x0016C2D8 File Offset: 0x0016A4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.DCLLHFAOHLF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DCLLHFAOHLF);
			}
			if (this.CPCBPJCENOH)
			{
				num += 2;
			}
			if (this.LFNCPMMHLCO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LFNCPMMHLCO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060089EB RID: 35307 RVA: 0x0016C354 File Offset: 0x0016A554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NNEOOKDGDIK other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.DCLLHFAOHLF != 0U)
			{
				this.DCLLHFAOHLF = other.DCLLHFAOHLF;
			}
			if (other.CPCBPJCENOH)
			{
				this.CPCBPJCENOH = other.CPCBPJCENOH;
			}
			if (other.LFNCPMMHLCO != 0U)
			{
				this.LFNCPMMHLCO = other.LFNCPMMHLCO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060089EC RID: 35308 RVA: 0x0016C3CC File Offset: 0x0016A5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089ED RID: 35309 RVA: 0x0016C3D8 File Offset: 0x0016A5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 24U)
					{
						this.LFNCPMMHLCO = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.DCLLHFAOHLF = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.CPCBPJCENOH = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034DE RID: 13534
		private static readonly MessageParser<NNEOOKDGDIK> _parser = new MessageParser<NNEOOKDGDIK>(() => new NNEOOKDGDIK());

		// Token: 0x040034DF RID: 13535
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034E0 RID: 13536
		public const int LevelFieldNumber = 6;

		// Token: 0x040034E1 RID: 13537
		private uint level_;

		// Token: 0x040034E2 RID: 13538
		public const int DCLLHFAOHLFFieldNumber = 5;

		// Token: 0x040034E3 RID: 13539
		private uint dCLLHFAOHLF_;

		// Token: 0x040034E4 RID: 13540
		public const int CPCBPJCENOHFieldNumber = 15;

		// Token: 0x040034E5 RID: 13541
		private bool cPCBPJCENOH_;

		// Token: 0x040034E6 RID: 13542
		public const int LFNCPMMHLCOFieldNumber = 3;

		// Token: 0x040034E7 RID: 13543
		private uint lFNCPMMHLCO_;
	}
}
