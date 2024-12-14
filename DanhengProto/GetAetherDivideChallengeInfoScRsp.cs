using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005FD RID: 1533
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAetherDivideChallengeInfoScRsp : IMessage<GetAetherDivideChallengeInfoScRsp>, IMessage, IEquatable<GetAetherDivideChallengeInfoScRsp>, IDeepCloneable<GetAetherDivideChallengeInfoScRsp>, IBufferMessage
	{
		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x060044B9 RID: 17593 RVA: 0x000BC6AF File Offset: 0x000BA8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAetherDivideChallengeInfoScRsp> Parser
		{
			get
			{
				return GetAetherDivideChallengeInfoScRsp._parser;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x060044BA RID: 17594 RVA: 0x000BC6B6 File Offset: 0x000BA8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAetherDivideChallengeInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x060044BB RID: 17595 RVA: 0x000BC6C8 File Offset: 0x000BA8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAetherDivideChallengeInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x000BC6CF File Offset: 0x000BA8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideChallengeInfoScRsp()
		{
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x000BC6F0 File Offset: 0x000BA8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideChallengeInfoScRsp(GetAetherDivideChallengeInfoScRsp other) : this()
		{
			this.cLFBHPJBLKH_ = other.cLFBHPJBLKH_.Clone();
			this.retcode_ = other.retcode_;
			this.gJJIMBMMNGC_ = other.gJJIMBMMNGC_.Clone();
			this.fJOILAFHGAH_ = other.fJOILAFHGAH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x000BC74E File Offset: 0x000BA94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAetherDivideChallengeInfoScRsp Clone()
		{
			return new GetAetherDivideChallengeInfoScRsp(this);
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x060044BF RID: 17599 RVA: 0x000BC756 File Offset: 0x000BA956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> CLFBHPJBLKH
		{
			get
			{
				return this.cLFBHPJBLKH_;
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x000BC75E File Offset: 0x000BA95E
		// (set) Token: 0x060044C1 RID: 17601 RVA: 0x000BC766 File Offset: 0x000BA966
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

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x000BC76F File Offset: 0x000BA96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GJJIMBMMNGC
		{
			get
			{
				return this.gJJIMBMMNGC_;
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x060044C3 RID: 17603 RVA: 0x000BC777 File Offset: 0x000BA977
		// (set) Token: 0x060044C4 RID: 17604 RVA: 0x000BC77F File Offset: 0x000BA97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FJOILAFHGAH
		{
			get
			{
				return this.fJOILAFHGAH_;
			}
			set
			{
				this.fJOILAFHGAH_ = value;
			}
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x000BC788 File Offset: 0x000BA988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAetherDivideChallengeInfoScRsp);
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x000BC798 File Offset: 0x000BA998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAetherDivideChallengeInfoScRsp other)
		{
			return other != null && (other == this || (this.cLFBHPJBLKH_.Equals(other.cLFBHPJBLKH_) && this.Retcode == other.Retcode && this.gJJIMBMMNGC_.Equals(other.gJJIMBMMNGC_) && this.FJOILAFHGAH == other.FJOILAFHGAH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x000BC80C File Offset: 0x000BAA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cLFBHPJBLKH_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.gJJIMBMMNGC_.GetHashCode();
			if (this.FJOILAFHGAH != 0U)
			{
				num ^= this.FJOILAFHGAH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x000BC880 File Offset: 0x000BAA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x000BC888 File Offset: 0x000BAA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x000BC894 File Offset: 0x000BAA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gJJIMBMMNGC_.WriteTo(ref output, GetAetherDivideChallengeInfoScRsp._repeated_gJJIMBMMNGC_codec);
			if (this.FJOILAFHGAH != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.FJOILAFHGAH);
			}
			this.cLFBHPJBLKH_.WriteTo(ref output, GetAetherDivideChallengeInfoScRsp._repeated_cLFBHPJBLKH_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x000BC910 File Offset: 0x000BAB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cLFBHPJBLKH_.CalculateSize(GetAetherDivideChallengeInfoScRsp._repeated_cLFBHPJBLKH_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.gJJIMBMMNGC_.CalculateSize(GetAetherDivideChallengeInfoScRsp._repeated_gJJIMBMMNGC_codec);
			if (this.FJOILAFHGAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FJOILAFHGAH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x000BC98C File Offset: 0x000BAB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAetherDivideChallengeInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.cLFBHPJBLKH_.Add(other.cLFBHPJBLKH_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.gJJIMBMMNGC_.Add(other.gJJIMBMMNGC_);
			if (other.FJOILAFHGAH != 0U)
			{
				this.FJOILAFHGAH = other.FJOILAFHGAH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x000BC9FE File Offset: 0x000BABFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x000BCA08 File Offset: 0x000BAC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 96U)
				{
					if (num == 24U || num == 26U)
					{
						this.gJJIMBMMNGC_.AddEntriesFrom(ref input, GetAetherDivideChallengeInfoScRsp._repeated_gJJIMBMMNGC_codec);
						continue;
					}
					if (num == 96U)
					{
						this.FJOILAFHGAH = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U || num == 106U)
					{
						this.cLFBHPJBLKH_.AddEntriesFrom(ref input, GetAetherDivideChallengeInfoScRsp._repeated_cLFBHPJBLKH_codec);
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B7C RID: 7036
		private static readonly MessageParser<GetAetherDivideChallengeInfoScRsp> _parser = new MessageParser<GetAetherDivideChallengeInfoScRsp>(() => new GetAetherDivideChallengeInfoScRsp());

		// Token: 0x04001B7D RID: 7037
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B7E RID: 7038
		public const int CLFBHPJBLKHFieldNumber = 13;

		// Token: 0x04001B7F RID: 7039
		private static readonly FieldCodec<uint> _repeated_cLFBHPJBLKH_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04001B80 RID: 7040
		private readonly RepeatedField<uint> cLFBHPJBLKH_ = new RepeatedField<uint>();

		// Token: 0x04001B81 RID: 7041
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04001B82 RID: 7042
		private uint retcode_;

		// Token: 0x04001B83 RID: 7043
		public const int GJJIMBMMNGCFieldNumber = 3;

		// Token: 0x04001B84 RID: 7044
		private static readonly FieldCodec<uint> _repeated_gJJIMBMMNGC_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04001B85 RID: 7045
		private readonly RepeatedField<uint> gJJIMBMMNGC_ = new RepeatedField<uint>();

		// Token: 0x04001B86 RID: 7046
		public const int FJOILAFHGAHFieldNumber = 12;

		// Token: 0x04001B87 RID: 7047
		private uint fJOILAFHGAH_;
	}
}
