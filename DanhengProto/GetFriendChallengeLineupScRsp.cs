using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006C3 RID: 1731
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendChallengeLineupScRsp : IMessage<GetFriendChallengeLineupScRsp>, IMessage, IEquatable<GetFriendChallengeLineupScRsp>, IDeepCloneable<GetFriendChallengeLineupScRsp>, IBufferMessage
	{
		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06004D79 RID: 19833 RVA: 0x000D1FA3 File Offset: 0x000D01A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendChallengeLineupScRsp> Parser
		{
			get
			{
				return GetFriendChallengeLineupScRsp._parser;
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06004D7A RID: 19834 RVA: 0x000D1FAA File Offset: 0x000D01AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendChallengeLineupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06004D7B RID: 19835 RVA: 0x000D1FBC File Offset: 0x000D01BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendChallengeLineupScRsp.Descriptor;
			}
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x000D1FC3 File Offset: 0x000D01C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeLineupScRsp()
		{
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x000D1FD8 File Offset: 0x000D01D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeLineupScRsp(GetFriendChallengeLineupScRsp other) : this()
		{
			this.eMIDNFPPMBH_ = other.eMIDNFPPMBH_;
			this.retcode_ = other.retcode_;
			this.pPAGGONDPCF_ = other.pPAGGONDPCF_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x000D2025 File Offset: 0x000D0225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendChallengeLineupScRsp Clone()
		{
			return new GetFriendChallengeLineupScRsp(this);
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06004D7F RID: 19839 RVA: 0x000D202D File Offset: 0x000D022D
		// (set) Token: 0x06004D80 RID: 19840 RVA: 0x000D2035 File Offset: 0x000D0235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EMIDNFPPMBH
		{
			get
			{
				return this.eMIDNFPPMBH_;
			}
			set
			{
				this.eMIDNFPPMBH_ = value;
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06004D81 RID: 19841 RVA: 0x000D203E File Offset: 0x000D023E
		// (set) Token: 0x06004D82 RID: 19842 RVA: 0x000D2046 File Offset: 0x000D0246
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

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06004D83 RID: 19843 RVA: 0x000D204F File Offset: 0x000D024F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KLMFIBACKFD> PPAGGONDPCF
		{
			get
			{
				return this.pPAGGONDPCF_;
			}
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x000D2057 File Offset: 0x000D0257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendChallengeLineupScRsp);
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x000D2068 File Offset: 0x000D0268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendChallengeLineupScRsp other)
		{
			return other != null && (other == this || (this.EMIDNFPPMBH == other.EMIDNFPPMBH && this.Retcode == other.Retcode && this.pPAGGONDPCF_.Equals(other.pPAGGONDPCF_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x000D20C8 File Offset: 0x000D02C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EMIDNFPPMBH)
			{
				num ^= this.EMIDNFPPMBH.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.pPAGGONDPCF_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x000D212E File Offset: 0x000D032E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x000D2136 File Offset: 0x000D0336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x000D2140 File Offset: 0x000D0340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.pPAGGONDPCF_.WriteTo(ref output, GetFriendChallengeLineupScRsp._repeated_pPAGGONDPCF_codec);
			if (this.EMIDNFPPMBH)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.EMIDNFPPMBH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x000D21AC File Offset: 0x000D03AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EMIDNFPPMBH)
			{
				num += 2;
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.pPAGGONDPCF_.CalculateSize(GetFriendChallengeLineupScRsp._repeated_pPAGGONDPCF_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x000D220C File Offset: 0x000D040C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendChallengeLineupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EMIDNFPPMBH)
			{
				this.EMIDNFPPMBH = other.EMIDNFPPMBH;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.pPAGGONDPCF_.Add(other.pPAGGONDPCF_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x000D226D File Offset: 0x000D046D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x000D2278 File Offset: 0x000D0478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 34U)
					{
						if (num != 40U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EMIDNFPPMBH = input.ReadBool();
						}
					}
					else
					{
						this.pPAGGONDPCF_.AddEntriesFrom(ref input, GetFriendChallengeLineupScRsp._repeated_pPAGGONDPCF_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001EA3 RID: 7843
		private static readonly MessageParser<GetFriendChallengeLineupScRsp> _parser = new MessageParser<GetFriendChallengeLineupScRsp>(() => new GetFriendChallengeLineupScRsp());

		// Token: 0x04001EA4 RID: 7844
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EA5 RID: 7845
		public const int EMIDNFPPMBHFieldNumber = 5;

		// Token: 0x04001EA6 RID: 7846
		private bool eMIDNFPPMBH_;

		// Token: 0x04001EA7 RID: 7847
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04001EA8 RID: 7848
		private uint retcode_;

		// Token: 0x04001EA9 RID: 7849
		public const int PPAGGONDPCFFieldNumber = 4;

		// Token: 0x04001EAA RID: 7850
		private static readonly FieldCodec<KLMFIBACKFD> _repeated_pPAGGONDPCF_codec = FieldCodec.ForMessage<KLMFIBACKFD>(34U, KLMFIBACKFD.Parser);

		// Token: 0x04001EAB RID: 7851
		private readonly RepeatedField<KLMFIBACKFD> pPAGGONDPCF_ = new RepeatedField<KLMFIBACKFD>();
	}
}
