using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006A3 RID: 1699
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFightActivityDataScRsp : IMessage<GetFightActivityDataScRsp>, IMessage, IEquatable<GetFightActivityDataScRsp>, IDeepCloneable<GetFightActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x000CE590 File Offset: 0x000CC790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFightActivityDataScRsp> Parser
		{
			get
			{
				return GetFightActivityDataScRsp._parser;
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06004C0B RID: 19467 RVA: 0x000CE597 File Offset: 0x000CC797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFightActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x000CE5A9 File Offset: 0x000CC7A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFightActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x000CE5B0 File Offset: 0x000CC7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightActivityDataScRsp()
		{
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x000CE5D0 File Offset: 0x000CC7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightActivityDataScRsp(GetFightActivityDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.dPFKPKDKONP_ = other.dPFKPKDKONP_.Clone();
			this.aGGMHDOKDPM_ = other.aGGMHDOKDPM_;
			this.jDNHCNHAMML_ = other.jDNHCNHAMML_.Clone();
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x000CE63A File Offset: 0x000CC83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFightActivityDataScRsp Clone()
		{
			return new GetFightActivityDataScRsp(this);
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06004C10 RID: 19472 RVA: 0x000CE642 File Offset: 0x000CC842
		// (set) Token: 0x06004C11 RID: 19473 RVA: 0x000CE64A File Offset: 0x000CC84A
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

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06004C12 RID: 19474 RVA: 0x000CE653 File Offset: 0x000CC853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightActivityGroup> DPFKPKDKONP
		{
			get
			{
				return this.dPFKPKDKONP_;
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x000CE65B File Offset: 0x000CC85B
		// (set) Token: 0x06004C14 RID: 19476 RVA: 0x000CE663 File Offset: 0x000CC863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AGGMHDOKDPM
		{
			get
			{
				return this.aGGMHDOKDPM_;
			}
			set
			{
				this.aGGMHDOKDPM_ = value;
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x000CE66C File Offset: 0x000CC86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> JDNHCNHAMML
		{
			get
			{
				return this.jDNHCNHAMML_;
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06004C16 RID: 19478 RVA: 0x000CE674 File Offset: 0x000CC874
		// (set) Token: 0x06004C17 RID: 19479 RVA: 0x000CE67C File Offset: 0x000CC87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x000CE685 File Offset: 0x000CC885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFightActivityDataScRsp);
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x000CE694 File Offset: 0x000CC894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFightActivityDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.dPFKPKDKONP_.Equals(other.dPFKPKDKONP_) && this.AGGMHDOKDPM == other.AGGMHDOKDPM && this.JDNHCNHAMML.Equals(other.JDNHCNHAMML) && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x000CE718 File Offset: 0x000CC918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.dPFKPKDKONP_.GetHashCode();
			if (this.AGGMHDOKDPM)
			{
				num ^= this.AGGMHDOKDPM.GetHashCode();
			}
			num ^= this.JDNHCNHAMML.GetHashCode();
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x000CE7A5 File Offset: 0x000CC9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x000CE7AD File Offset: 0x000CC9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x000CE7B8 File Offset: 0x000CC9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AGGMHDOKDPM)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.AGGMHDOKDPM);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.WorldLevel);
			}
			this.jDNHCNHAMML_.WriteTo(ref output, GetFightActivityDataScRsp._map_jDNHCNHAMML_codec);
			this.dPFKPKDKONP_.WriteTo(ref output, GetFightActivityDataScRsp._repeated_dPFKPKDKONP_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x000CE850 File Offset: 0x000CCA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.dPFKPKDKONP_.CalculateSize(GetFightActivityDataScRsp._repeated_dPFKPKDKONP_codec);
			if (this.AGGMHDOKDPM)
			{
				num += 2;
			}
			num += this.jDNHCNHAMML_.CalculateSize(GetFightActivityDataScRsp._map_jDNHCNHAMML_codec);
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x000CE8D8 File Offset: 0x000CCAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFightActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.dPFKPKDKONP_.Add(other.dPFKPKDKONP_);
			if (other.AGGMHDOKDPM)
			{
				this.AGGMHDOKDPM = other.AGGMHDOKDPM;
			}
			this.jDNHCNHAMML_.MergeFrom(other.jDNHCNHAMML_);
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x000CE95E File Offset: 0x000CCB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x000CE968 File Offset: 0x000CCB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.AGGMHDOKDPM = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.jDNHCNHAMML_.AddEntriesFrom(ref input, GetFightActivityDataScRsp._map_jDNHCNHAMML_codec);
						continue;
					}
					if (num == 66U)
					{
						this.dPFKPKDKONP_.AddEntriesFrom(ref input, GetFightActivityDataScRsp._repeated_dPFKPKDKONP_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E16 RID: 7702
		private static readonly MessageParser<GetFightActivityDataScRsp> _parser = new MessageParser<GetFightActivityDataScRsp>(() => new GetFightActivityDataScRsp());

		// Token: 0x04001E17 RID: 7703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E18 RID: 7704
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04001E19 RID: 7705
		private uint retcode_;

		// Token: 0x04001E1A RID: 7706
		public const int DPFKPKDKONPFieldNumber = 8;

		// Token: 0x04001E1B RID: 7707
		private static readonly FieldCodec<FightActivityGroup> _repeated_dPFKPKDKONP_codec = FieldCodec.ForMessage<FightActivityGroup>(66U, FightActivityGroup.Parser);

		// Token: 0x04001E1C RID: 7708
		private readonly RepeatedField<FightActivityGroup> dPFKPKDKONP_ = new RepeatedField<FightActivityGroup>();

		// Token: 0x04001E1D RID: 7709
		public const int AGGMHDOKDPMFieldNumber = 2;

		// Token: 0x04001E1E RID: 7710
		private bool aGGMHDOKDPM_;

		// Token: 0x04001E1F RID: 7711
		public const int JDNHCNHAMMLFieldNumber = 7;

		// Token: 0x04001E20 RID: 7712
		private static readonly MapField<uint, uint>.Codec _map_jDNHCNHAMML_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 58U);

		// Token: 0x04001E21 RID: 7713
		private readonly MapField<uint, uint> jDNHCNHAMML_ = new MapField<uint, uint>();

		// Token: 0x04001E22 RID: 7714
		public const int WorldLevelFieldNumber = 5;

		// Token: 0x04001E23 RID: 7715
		private uint worldLevel_;
	}
}
