using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006EF RID: 1775
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetKilledPunkLordMonsterDataScRsp : IMessage<GetKilledPunkLordMonsterDataScRsp>, IMessage, IEquatable<GetKilledPunkLordMonsterDataScRsp>, IDeepCloneable<GetKilledPunkLordMonsterDataScRsp>, IBufferMessage
	{
		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06004F5F RID: 20319 RVA: 0x000D665F File Offset: 0x000D485F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetKilledPunkLordMonsterDataScRsp> Parser
		{
			get
			{
				return GetKilledPunkLordMonsterDataScRsp._parser;
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06004F60 RID: 20320 RVA: 0x000D6666 File Offset: 0x000D4866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetKilledPunkLordMonsterDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06004F61 RID: 20321 RVA: 0x000D6678 File Offset: 0x000D4878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetKilledPunkLordMonsterDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x000D667F File Offset: 0x000D487F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetKilledPunkLordMonsterDataScRsp()
		{
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x000D66A0 File Offset: 0x000D48A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetKilledPunkLordMonsterDataScRsp(GetKilledPunkLordMonsterDataScRsp other) : this()
		{
			this.kNFDKPFOIJH_ = other.kNFDKPFOIJH_.Clone();
			this.retcode_ = other.retcode_;
			this.hECNMGMNACC_ = other.hECNMGMNACC_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x000D66F2 File Offset: 0x000D48F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetKilledPunkLordMonsterDataScRsp Clone()
		{
			return new GetKilledPunkLordMonsterDataScRsp(this);
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06004F65 RID: 20325 RVA: 0x000D66FA File Offset: 0x000D48FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PunkLordMonsterKey> KNFDKPFOIJH
		{
			get
			{
				return this.kNFDKPFOIJH_;
			}
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06004F66 RID: 20326 RVA: 0x000D6702 File Offset: 0x000D4902
		// (set) Token: 0x06004F67 RID: 20327 RVA: 0x000D670A File Offset: 0x000D490A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06004F68 RID: 20328 RVA: 0x000D6713 File Offset: 0x000D4913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KilledPunkLordMonsterInfo> HECNMGMNACC
		{
			get
			{
				return this.hECNMGMNACC_;
			}
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x000D671B File Offset: 0x000D491B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetKilledPunkLordMonsterDataScRsp);
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x000D672C File Offset: 0x000D492C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetKilledPunkLordMonsterDataScRsp other)
		{
			return other != null && (other == this || (this.kNFDKPFOIJH_.Equals(other.kNFDKPFOIJH_) && this.Retcode == other.Retcode && this.hECNMGMNACC_.Equals(other.hECNMGMNACC_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x000D6790 File Offset: 0x000D4990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kNFDKPFOIJH_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.hECNMGMNACC_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x000D67EB File Offset: 0x000D49EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x000D67F3 File Offset: 0x000D49F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x000D67FC File Offset: 0x000D49FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hECNMGMNACC_.WriteTo(ref output, GetKilledPunkLordMonsterDataScRsp._repeated_hECNMGMNACC_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			this.kNFDKPFOIJH_.WriteTo(ref output, GetKilledPunkLordMonsterDataScRsp._repeated_kNFDKPFOIJH_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x000D685C File Offset: 0x000D4A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kNFDKPFOIJH_.CalculateSize(GetKilledPunkLordMonsterDataScRsp._repeated_kNFDKPFOIJH_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.hECNMGMNACC_.CalculateSize(GetKilledPunkLordMonsterDataScRsp._repeated_hECNMGMNACC_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x000D68C0 File Offset: 0x000D4AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetKilledPunkLordMonsterDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.kNFDKPFOIJH_.Add(other.kNFDKPFOIJH_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.hECNMGMNACC_.Add(other.hECNMGMNACC_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x000D691E File Offset: 0x000D4B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x000D6928 File Offset: 0x000D4B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 104U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.kNFDKPFOIJH_.AddEntriesFrom(ref input, GetKilledPunkLordMonsterDataScRsp._repeated_kNFDKPFOIJH_codec);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.hECNMGMNACC_.AddEntriesFrom(ref input, GetKilledPunkLordMonsterDataScRsp._repeated_hECNMGMNACC_codec);
				}
			}
		}

		// Token: 0x04001F49 RID: 8009
		private static readonly MessageParser<GetKilledPunkLordMonsterDataScRsp> _parser = new MessageParser<GetKilledPunkLordMonsterDataScRsp>(() => new GetKilledPunkLordMonsterDataScRsp());

		// Token: 0x04001F4A RID: 8010
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F4B RID: 8011
		public const int KNFDKPFOIJHFieldNumber = 15;

		// Token: 0x04001F4C RID: 8012
		private static readonly FieldCodec<PunkLordMonsterKey> _repeated_kNFDKPFOIJH_codec = FieldCodec.ForMessage<PunkLordMonsterKey>(122U, PunkLordMonsterKey.Parser);

		// Token: 0x04001F4D RID: 8013
		private readonly RepeatedField<PunkLordMonsterKey> kNFDKPFOIJH_ = new RepeatedField<PunkLordMonsterKey>();

		// Token: 0x04001F4E RID: 8014
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04001F4F RID: 8015
		private uint retcode_;

		// Token: 0x04001F50 RID: 8016
		public const int HECNMGMNACCFieldNumber = 2;

		// Token: 0x04001F51 RID: 8017
		private static readonly FieldCodec<KilledPunkLordMonsterInfo> _repeated_hECNMGMNACC_codec = FieldCodec.ForMessage<KilledPunkLordMonsterInfo>(18U, KilledPunkLordMonsterInfo.Parser);

		// Token: 0x04001F52 RID: 8018
		private readonly RepeatedField<KilledPunkLordMonsterInfo> hECNMGMNACC_ = new RepeatedField<KilledPunkLordMonsterInfo>();
	}
}
