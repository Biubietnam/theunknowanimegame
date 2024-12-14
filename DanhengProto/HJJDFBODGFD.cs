using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008F3 RID: 2291
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HJJDFBODGFD : IMessage<HJJDFBODGFD>, IMessage, IEquatable<HJJDFBODGFD>, IDeepCloneable<HJJDFBODGFD>, IBufferMessage
	{
		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x0600662C RID: 26156 RVA: 0x0011108B File Offset: 0x0010F28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HJJDFBODGFD> Parser
		{
			get
			{
				return HJJDFBODGFD._parser;
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x0600662D RID: 26157 RVA: 0x00111092 File Offset: 0x0010F292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HJJDFBODGFDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x0600662E RID: 26158 RVA: 0x001110A4 File Offset: 0x0010F2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HJJDFBODGFD.Descriptor;
			}
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x001110AB File Offset: 0x0010F2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HJJDFBODGFD()
		{
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x001110CC File Offset: 0x0010F2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HJJDFBODGFD(HJJDFBODGFD other) : this()
		{
			this.eLCIIOJMHOM_ = other.eLCIIOJMHOM_;
			this.hHIHINPMODI_ = other.hHIHINPMODI_;
			this.fKECNPCBMHL_ = other.fKECNPCBMHL_;
			this.mLHMMLIAIDI_ = other.mLHMMLIAIDI_;
			this.pIAOGAKAPDG_ = other.pIAOGAKAPDG_;
			this.eDDAGIBDEGO_ = other.eDDAGIBDEGO_;
			this.bossInfo_ = other.bossInfo_.Clone();
			this.fEAOMKPJJLC_ = other.fEAOMKPJJLC_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x0011115A File Offset: 0x0010F35A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HJJDFBODGFD Clone()
		{
			return new HJJDFBODGFD(this);
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06006632 RID: 26162 RVA: 0x00111162 File Offset: 0x0010F362
		// (set) Token: 0x06006633 RID: 26163 RVA: 0x0011116A File Offset: 0x0010F36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ELCIIOJMHOM
		{
			get
			{
				return this.eLCIIOJMHOM_;
			}
			set
			{
				this.eLCIIOJMHOM_ = value;
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06006634 RID: 26164 RVA: 0x00111173 File Offset: 0x0010F373
		// (set) Token: 0x06006635 RID: 26165 RVA: 0x0011117B File Offset: 0x0010F37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HHIHINPMODI
		{
			get
			{
				return this.hHIHINPMODI_;
			}
			set
			{
				this.hHIHINPMODI_ = value;
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06006636 RID: 26166 RVA: 0x00111184 File Offset: 0x0010F384
		// (set) Token: 0x06006637 RID: 26167 RVA: 0x0011118C File Offset: 0x0010F38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FKECNPCBMHL
		{
			get
			{
				return this.fKECNPCBMHL_;
			}
			set
			{
				this.fKECNPCBMHL_ = value;
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06006638 RID: 26168 RVA: 0x00111195 File Offset: 0x0010F395
		// (set) Token: 0x06006639 RID: 26169 RVA: 0x0011119D File Offset: 0x0010F39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MLHMMLIAIDI
		{
			get
			{
				return this.mLHMMLIAIDI_;
			}
			set
			{
				this.mLHMMLIAIDI_ = value;
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x0600663A RID: 26170 RVA: 0x001111A6 File Offset: 0x0010F3A6
		// (set) Token: 0x0600663B RID: 26171 RVA: 0x001111AE File Offset: 0x0010F3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PIAOGAKAPDG
		{
			get
			{
				return this.pIAOGAKAPDG_;
			}
			set
			{
				this.pIAOGAKAPDG_ = value;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x001111B7 File Offset: 0x0010F3B7
		// (set) Token: 0x0600663D RID: 26173 RVA: 0x001111BF File Offset: 0x0010F3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EDDAGIBDEGO
		{
			get
			{
				return this.eDDAGIBDEGO_;
			}
			set
			{
				this.eDDAGIBDEGO_ = value;
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x001111C8 File Offset: 0x0010F3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BossInfo
		{
			get
			{
				return this.bossInfo_;
			}
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x0600663F RID: 26175 RVA: 0x001111D0 File Offset: 0x0010F3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AIHKDBCHPPG> FEAOMKPJJLC
		{
			get
			{
				return this.fEAOMKPJJLC_;
			}
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x001111D8 File Offset: 0x0010F3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HJJDFBODGFD);
		}

		// Token: 0x06006641 RID: 26177 RVA: 0x001111E8 File Offset: 0x0010F3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HJJDFBODGFD other)
		{
			return other != null && (other == this || (this.ELCIIOJMHOM == other.ELCIIOJMHOM && this.HHIHINPMODI == other.HHIHINPMODI && this.FKECNPCBMHL == other.FKECNPCBMHL && this.MLHMMLIAIDI == other.MLHMMLIAIDI && this.PIAOGAKAPDG == other.PIAOGAKAPDG && this.EDDAGIBDEGO == other.EDDAGIBDEGO && this.bossInfo_.Equals(other.bossInfo_) && this.fEAOMKPJJLC_.Equals(other.fEAOMKPJJLC_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x0011129C File Offset: 0x0010F49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ELCIIOJMHOM != 0U)
			{
				num ^= this.ELCIIOJMHOM.GetHashCode();
			}
			if (this.HHIHINPMODI != 0U)
			{
				num ^= this.HHIHINPMODI.GetHashCode();
			}
			if (this.FKECNPCBMHL != 0U)
			{
				num ^= this.FKECNPCBMHL.GetHashCode();
			}
			if (this.MLHMMLIAIDI != 0U)
			{
				num ^= this.MLHMMLIAIDI.GetHashCode();
			}
			if (this.PIAOGAKAPDG != 0U)
			{
				num ^= this.PIAOGAKAPDG.GetHashCode();
			}
			if (this.EDDAGIBDEGO != 0U)
			{
				num ^= this.EDDAGIBDEGO.GetHashCode();
			}
			num ^= this.bossInfo_.GetHashCode();
			num ^= this.fEAOMKPJJLC_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x00111374 File Offset: 0x0010F574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006644 RID: 26180 RVA: 0x0011137C File Offset: 0x0010F57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x00111388 File Offset: 0x0010F588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ELCIIOJMHOM != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ELCIIOJMHOM);
			}
			if (this.HHIHINPMODI != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.HHIHINPMODI);
			}
			if (this.FKECNPCBMHL != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.FKECNPCBMHL);
			}
			if (this.MLHMMLIAIDI != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MLHMMLIAIDI);
			}
			if (this.PIAOGAKAPDG != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PIAOGAKAPDG);
			}
			if (this.EDDAGIBDEGO != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EDDAGIBDEGO);
			}
			this.bossInfo_.WriteTo(ref output, HJJDFBODGFD._repeated_bossInfo_codec);
			this.fEAOMKPJJLC_.WriteTo(ref output, HJJDFBODGFD._repeated_fEAOMKPJJLC_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x00111474 File Offset: 0x0010F674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ELCIIOJMHOM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ELCIIOJMHOM);
			}
			if (this.HHIHINPMODI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HHIHINPMODI);
			}
			if (this.FKECNPCBMHL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FKECNPCBMHL);
			}
			if (this.MLHMMLIAIDI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MLHMMLIAIDI);
			}
			if (this.PIAOGAKAPDG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PIAOGAKAPDG);
			}
			if (this.EDDAGIBDEGO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EDDAGIBDEGO);
			}
			num += this.bossInfo_.CalculateSize(HJJDFBODGFD._repeated_bossInfo_codec);
			num += this.fEAOMKPJJLC_.CalculateSize(HJJDFBODGFD._repeated_fEAOMKPJJLC_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x00111550 File Offset: 0x0010F750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HJJDFBODGFD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ELCIIOJMHOM != 0U)
			{
				this.ELCIIOJMHOM = other.ELCIIOJMHOM;
			}
			if (other.HHIHINPMODI != 0U)
			{
				this.HHIHINPMODI = other.HHIHINPMODI;
			}
			if (other.FKECNPCBMHL != 0U)
			{
				this.FKECNPCBMHL = other.FKECNPCBMHL;
			}
			if (other.MLHMMLIAIDI != 0U)
			{
				this.MLHMMLIAIDI = other.MLHMMLIAIDI;
			}
			if (other.PIAOGAKAPDG != 0U)
			{
				this.PIAOGAKAPDG = other.PIAOGAKAPDG;
			}
			if (other.EDDAGIBDEGO != 0U)
			{
				this.EDDAGIBDEGO = other.EDDAGIBDEGO;
			}
			this.bossInfo_.Add(other.bossInfo_);
			this.fEAOMKPJJLC_.Add(other.fEAOMKPJJLC_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x00111612 File Offset: 0x0010F812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x0011161C File Offset: 0x0010F81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ELCIIOJMHOM = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.HHIHINPMODI = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.FKECNPCBMHL = input.ReadUInt32();
							continue;
						}
						if (num == 32U)
						{
							this.MLHMMLIAIDI = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.PIAOGAKAPDG = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.EDDAGIBDEGO = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U || num == 58U)
					{
						this.bossInfo_.AddEntriesFrom(ref input, HJJDFBODGFD._repeated_bossInfo_codec);
						continue;
					}
					if (num == 66U)
					{
						this.fEAOMKPJJLC_.AddEntriesFrom(ref input, HJJDFBODGFD._repeated_fEAOMKPJJLC_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002743 RID: 10051
		private static readonly MessageParser<HJJDFBODGFD> _parser = new MessageParser<HJJDFBODGFD>(() => new HJJDFBODGFD());

		// Token: 0x04002744 RID: 10052
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002745 RID: 10053
		public const int ELCIIOJMHOMFieldNumber = 1;

		// Token: 0x04002746 RID: 10054
		private uint eLCIIOJMHOM_;

		// Token: 0x04002747 RID: 10055
		public const int HHIHINPMODIFieldNumber = 2;

		// Token: 0x04002748 RID: 10056
		private uint hHIHINPMODI_;

		// Token: 0x04002749 RID: 10057
		public const int FKECNPCBMHLFieldNumber = 3;

		// Token: 0x0400274A RID: 10058
		private uint fKECNPCBMHL_;

		// Token: 0x0400274B RID: 10059
		public const int MLHMMLIAIDIFieldNumber = 4;

		// Token: 0x0400274C RID: 10060
		private uint mLHMMLIAIDI_;

		// Token: 0x0400274D RID: 10061
		public const int PIAOGAKAPDGFieldNumber = 5;

		// Token: 0x0400274E RID: 10062
		private uint pIAOGAKAPDG_;

		// Token: 0x0400274F RID: 10063
		public const int EDDAGIBDEGOFieldNumber = 6;

		// Token: 0x04002750 RID: 10064
		private uint eDDAGIBDEGO_;

		// Token: 0x04002751 RID: 10065
		public const int BossInfoFieldNumber = 7;

		// Token: 0x04002752 RID: 10066
		private static readonly FieldCodec<uint> _repeated_bossInfo_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04002753 RID: 10067
		private readonly RepeatedField<uint> bossInfo_ = new RepeatedField<uint>();

		// Token: 0x04002754 RID: 10068
		public const int FEAOMKPJJLCFieldNumber = 8;

		// Token: 0x04002755 RID: 10069
		private static readonly FieldCodec<AIHKDBCHPPG> _repeated_fEAOMKPJJLC_codec = FieldCodec.ForMessage<AIHKDBCHPPG>(66U, AIHKDBCHPPG.Parser);

		// Token: 0x04002756 RID: 10070
		private readonly RepeatedField<AIHKDBCHPPG> fEAOMKPJJLC_ = new RepeatedField<AIHKDBCHPPG>();
	}
}
