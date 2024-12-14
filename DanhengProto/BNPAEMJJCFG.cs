using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000139 RID: 313
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BNPAEMJJCFG : IMessage<BNPAEMJJCFG>, IMessage, IEquatable<BNPAEMJJCFG>, IDeepCloneable<BNPAEMJJCFG>, IBufferMessage
	{
		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00029EA8 File Offset: 0x000280A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BNPAEMJJCFG> Parser
		{
			get
			{
				return BNPAEMJJCFG._parser;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00029EAF File Offset: 0x000280AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BNPAEMJJCFGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00029EC1 File Offset: 0x000280C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BNPAEMJJCFG.Descriptor;
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00029EC8 File Offset: 0x000280C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BNPAEMJJCFG()
		{
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00029EDC File Offset: 0x000280DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BNPAEMJJCFG(BNPAEMJJCFG other) : this()
		{
			this.eAFEAHGMEEL_ = other.eAFEAHGMEEL_.Clone();
			this.mDFFMCBEMBO_ = other.mDFFMCBEMBO_;
			this.eHELHCENICC_ = other.eHELHCENICC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00029F29 File Offset: 0x00028129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BNPAEMJJCFG Clone()
		{
			return new BNPAEMJJCFG(this);
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00029F31 File Offset: 0x00028131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> EAFEAHGMEEL
		{
			get
			{
				return this.eAFEAHGMEEL_;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x00029F39 File Offset: 0x00028139
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x00029F41 File Offset: 0x00028141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MDFFMCBEMBO
		{
			get
			{
				return this.mDFFMCBEMBO_;
			}
			set
			{
				this.mDFFMCBEMBO_ = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x00029F4A File Offset: 0x0002814A
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x00029F52 File Offset: 0x00028152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EHELHCENICC
		{
			get
			{
				return this.eHELHCENICC_;
			}
			set
			{
				this.eHELHCENICC_ = value;
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00029F5B File Offset: 0x0002815B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BNPAEMJJCFG);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00029F6C File Offset: 0x0002816C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BNPAEMJJCFG other)
		{
			return other != null && (other == this || (this.EAFEAHGMEEL.Equals(other.EAFEAHGMEEL) && this.MDFFMCBEMBO == other.MDFFMCBEMBO && this.EHELHCENICC == other.EHELHCENICC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00029FCC File Offset: 0x000281CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.EAFEAHGMEEL.GetHashCode();
			if (this.MDFFMCBEMBO != 0U)
			{
				num ^= this.MDFFMCBEMBO.GetHashCode();
			}
			if (this.EHELHCENICC != 0U)
			{
				num ^= this.EHELHCENICC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0002A032 File Offset: 0x00028232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0002A03A File Offset: 0x0002823A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0002A044 File Offset: 0x00028244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MDFFMCBEMBO != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MDFFMCBEMBO);
			}
			this.eAFEAHGMEEL_.WriteTo(ref output, BNPAEMJJCFG._map_eAFEAHGMEEL_codec);
			if (this.EHELHCENICC != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.EHELHCENICC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0002A0B0 File Offset: 0x000282B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.eAFEAHGMEEL_.CalculateSize(BNPAEMJJCFG._map_eAFEAHGMEEL_codec);
			if (this.MDFFMCBEMBO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MDFFMCBEMBO);
			}
			if (this.EHELHCENICC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EHELHCENICC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0002A11C File Offset: 0x0002831C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BNPAEMJJCFG other)
		{
			if (other == null)
			{
				return;
			}
			this.eAFEAHGMEEL_.MergeFrom(other.eAFEAHGMEEL_);
			if (other.MDFFMCBEMBO != 0U)
			{
				this.MDFFMCBEMBO = other.MDFFMCBEMBO;
			}
			if (other.EHELHCENICC != 0U)
			{
				this.EHELHCENICC = other.EHELHCENICC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0002A17D File Offset: 0x0002837D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0002A188 File Offset: 0x00028388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 34U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EHELHCENICC = input.ReadUInt32();
						}
					}
					else
					{
						this.eAFEAHGMEEL_.AddEntriesFrom(ref input, BNPAEMJJCFG._map_eAFEAHGMEEL_codec);
					}
				}
				else
				{
					this.MDFFMCBEMBO = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000615 RID: 1557
		private static readonly MessageParser<BNPAEMJJCFG> _parser = new MessageParser<BNPAEMJJCFG>(() => new BNPAEMJJCFG());

		// Token: 0x04000616 RID: 1558
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000617 RID: 1559
		public const int EAFEAHGMEELFieldNumber = 4;

		// Token: 0x04000618 RID: 1560
		private static readonly MapField<uint, uint>.Codec _map_eAFEAHGMEEL_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 34U);

		// Token: 0x04000619 RID: 1561
		private readonly MapField<uint, uint> eAFEAHGMEEL_ = new MapField<uint, uint>();

		// Token: 0x0400061A RID: 1562
		public const int MDFFMCBEMBOFieldNumber = 1;

		// Token: 0x0400061B RID: 1563
		private uint mDFFMCBEMBO_;

		// Token: 0x0400061C RID: 1564
		public const int EHELHCENICCFieldNumber = 8;

		// Token: 0x0400061D RID: 1565
		private uint eHELHCENICC_;
	}
}
