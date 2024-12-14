using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B9B RID: 2971
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MPEDPGPEMGH : IMessage<MPEDPGPEMGH>, IMessage, IEquatable<MPEDPGPEMGH>, IDeepCloneable<MPEDPGPEMGH>, IBufferMessage
	{
		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x06008397 RID: 33687 RVA: 0x0015B711 File Offset: 0x00159911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MPEDPGPEMGH> Parser
		{
			get
			{
				return MPEDPGPEMGH._parser;
			}
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x06008398 RID: 33688 RVA: 0x0015B718 File Offset: 0x00159918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MPEDPGPEMGHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x06008399 RID: 33689 RVA: 0x0015B72A File Offset: 0x0015992A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MPEDPGPEMGH.Descriptor;
			}
		}

		// Token: 0x0600839A RID: 33690 RVA: 0x0015B731 File Offset: 0x00159931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MPEDPGPEMGH()
		{
		}

		// Token: 0x0600839B RID: 33691 RVA: 0x0015B744 File Offset: 0x00159944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MPEDPGPEMGH(MPEDPGPEMGH other) : this()
		{
			this.iBKAAHPBIFC_ = other.iBKAAHPBIFC_;
			this.mEMBPPDDKAA_ = other.mEMBPPDDKAA_;
			this.hIBCKMBMACE_ = other.hIBCKMBMACE_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x0015B791 File Offset: 0x00159991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MPEDPGPEMGH Clone()
		{
			return new MPEDPGPEMGH(this);
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x0600839D RID: 33693 RVA: 0x0015B799 File Offset: 0x00159999
		// (set) Token: 0x0600839E RID: 33694 RVA: 0x0015B7A1 File Offset: 0x001599A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IBKAAHPBIFC
		{
			get
			{
				return this.iBKAAHPBIFC_;
			}
			set
			{
				this.iBKAAHPBIFC_ = value;
			}
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x0600839F RID: 33695 RVA: 0x0015B7AA File Offset: 0x001599AA
		// (set) Token: 0x060083A0 RID: 33696 RVA: 0x0015B7B2 File Offset: 0x001599B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MEMBPPDDKAA
		{
			get
			{
				return this.mEMBPPDDKAA_;
			}
			set
			{
				this.mEMBPPDDKAA_ = value;
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x060083A1 RID: 33697 RVA: 0x0015B7BB File Offset: 0x001599BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NCPHBHPPEOJ> HIBCKMBMACE
		{
			get
			{
				return this.hIBCKMBMACE_;
			}
		}

		// Token: 0x060083A2 RID: 33698 RVA: 0x0015B7C3 File Offset: 0x001599C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MPEDPGPEMGH);
		}

		// Token: 0x060083A3 RID: 33699 RVA: 0x0015B7D4 File Offset: 0x001599D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MPEDPGPEMGH other)
		{
			return other != null && (other == this || (this.IBKAAHPBIFC == other.IBKAAHPBIFC && this.MEMBPPDDKAA == other.MEMBPPDDKAA && this.hIBCKMBMACE_.Equals(other.hIBCKMBMACE_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083A4 RID: 33700 RVA: 0x0015B834 File Offset: 0x00159A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IBKAAHPBIFC != 0U)
			{
				num ^= this.IBKAAHPBIFC.GetHashCode();
			}
			if (this.MEMBPPDDKAA != 0U)
			{
				num ^= this.MEMBPPDDKAA.GetHashCode();
			}
			num ^= this.hIBCKMBMACE_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083A5 RID: 33701 RVA: 0x0015B89A File Offset: 0x00159A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060083A6 RID: 33702 RVA: 0x0015B8A2 File Offset: 0x00159AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083A7 RID: 33703 RVA: 0x0015B8AC File Offset: 0x00159AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IBKAAHPBIFC != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.IBKAAHPBIFC);
			}
			if (this.MEMBPPDDKAA != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MEMBPPDDKAA);
			}
			this.hIBCKMBMACE_.WriteTo(ref output, MPEDPGPEMGH._repeated_hIBCKMBMACE_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083A8 RID: 33704 RVA: 0x0015B918 File Offset: 0x00159B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IBKAAHPBIFC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IBKAAHPBIFC);
			}
			if (this.MEMBPPDDKAA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MEMBPPDDKAA);
			}
			num += this.hIBCKMBMACE_.CalculateSize(MPEDPGPEMGH._repeated_hIBCKMBMACE_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083A9 RID: 33705 RVA: 0x0015B984 File Offset: 0x00159B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MPEDPGPEMGH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IBKAAHPBIFC != 0U)
			{
				this.IBKAAHPBIFC = other.IBKAAHPBIFC;
			}
			if (other.MEMBPPDDKAA != 0U)
			{
				this.MEMBPPDDKAA = other.MEMBPPDDKAA;
			}
			this.hIBCKMBMACE_.Add(other.hIBCKMBMACE_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x0015B9E5 File Offset: 0x00159BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083AB RID: 33707 RVA: 0x0015B9F0 File Offset: 0x00159BF0
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.hIBCKMBMACE_.AddEntriesFrom(ref input, MPEDPGPEMGH._repeated_hIBCKMBMACE_codec);
						}
					}
					else
					{
						this.MEMBPPDDKAA = input.ReadUInt32();
					}
				}
				else
				{
					this.IBKAAHPBIFC = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003259 RID: 12889
		private static readonly MessageParser<MPEDPGPEMGH> _parser = new MessageParser<MPEDPGPEMGH>(() => new MPEDPGPEMGH());

		// Token: 0x0400325A RID: 12890
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400325B RID: 12891
		public const int IBKAAHPBIFCFieldNumber = 1;

		// Token: 0x0400325C RID: 12892
		private uint iBKAAHPBIFC_;

		// Token: 0x0400325D RID: 12893
		public const int MEMBPPDDKAAFieldNumber = 2;

		// Token: 0x0400325E RID: 12894
		private uint mEMBPPDDKAA_;

		// Token: 0x0400325F RID: 12895
		public const int HIBCKMBMACEFieldNumber = 3;

		// Token: 0x04003260 RID: 12896
		private static readonly FieldCodec<NCPHBHPPEOJ> _repeated_hIBCKMBMACE_codec = FieldCodec.ForMessage<NCPHBHPPEOJ>(26U, NCPHBHPPEOJ.Parser);

		// Token: 0x04003261 RID: 12897
		private readonly RepeatedField<NCPHBHPPEOJ> hIBCKMBMACE_ = new RepeatedField<NCPHBHPPEOJ>();
	}
}
