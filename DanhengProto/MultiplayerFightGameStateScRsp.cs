using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BAB RID: 2987
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiplayerFightGameStateScRsp : IMessage<MultiplayerFightGameStateScRsp>, IMessage, IEquatable<MultiplayerFightGameStateScRsp>, IDeepCloneable<MultiplayerFightGameStateScRsp>, IBufferMessage
	{
		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x06008423 RID: 33827 RVA: 0x0015CD3F File Offset: 0x0015AF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultiplayerFightGameStateScRsp> Parser
		{
			get
			{
				return MultiplayerFightGameStateScRsp._parser;
			}
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x06008424 RID: 33828 RVA: 0x0015CD46 File Offset: 0x0015AF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultiplayerFightGameStateScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x06008425 RID: 33829 RVA: 0x0015CD58 File Offset: 0x0015AF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiplayerFightGameStateScRsp.Descriptor;
			}
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x0015CD5F File Offset: 0x0015AF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameStateScRsp()
		{
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x0015CD74 File Offset: 0x0015AF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameStateScRsp(MultiplayerFightGameStateScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.bANNAKDNBFA_ = ((other.bANNAKDNBFA_ != null) ? other.bANNAKDNBFA_.Clone() : null);
			this.eBMOKPBKMMD_ = other.eBMOKPBKMMD_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x0015CDD1 File Offset: 0x0015AFD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameStateScRsp Clone()
		{
			return new MultiplayerFightGameStateScRsp(this);
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x06008429 RID: 33833 RVA: 0x0015CDD9 File Offset: 0x0015AFD9
		// (set) Token: 0x0600842A RID: 33834 RVA: 0x0015CDE1 File Offset: 0x0015AFE1
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

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x0600842B RID: 33835 RVA: 0x0015CDEA File Offset: 0x0015AFEA
		// (set) Token: 0x0600842C RID: 33836 RVA: 0x0015CDF2 File Offset: 0x0015AFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDDPABIGHBE BANNAKDNBFA
		{
			get
			{
				return this.bANNAKDNBFA_;
			}
			set
			{
				this.bANNAKDNBFA_ = value;
			}
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x0600842D RID: 33837 RVA: 0x0015CDFB File Offset: 0x0015AFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CCHCPNLPBDK> EBMOKPBKMMD
		{
			get
			{
				return this.eBMOKPBKMMD_;
			}
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x0015CE03 File Offset: 0x0015B003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiplayerFightGameStateScRsp);
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x0015CE14 File Offset: 0x0015B014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiplayerFightGameStateScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BANNAKDNBFA, other.BANNAKDNBFA) && this.eBMOKPBKMMD_.Equals(other.eBMOKPBKMMD_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x0015CE78 File Offset: 0x0015B078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.bANNAKDNBFA_ != null)
			{
				num ^= this.BANNAKDNBFA.GetHashCode();
			}
			num ^= this.eBMOKPBKMMD_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x0015CEDB File Offset: 0x0015B0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008432 RID: 33842 RVA: 0x0015CEE3 File Offset: 0x0015B0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x0015CEEC File Offset: 0x0015B0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.eBMOKPBKMMD_.WriteTo(ref output, MultiplayerFightGameStateScRsp._repeated_eBMOKPBKMMD_codec);
			if (this.bANNAKDNBFA_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.BANNAKDNBFA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008434 RID: 33844 RVA: 0x0015CF58 File Offset: 0x0015B158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.bANNAKDNBFA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BANNAKDNBFA);
			}
			num += this.eBMOKPBKMMD_.CalculateSize(MultiplayerFightGameStateScRsp._repeated_eBMOKPBKMMD_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008435 RID: 33845 RVA: 0x0015CFC4 File Offset: 0x0015B1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiplayerFightGameStateScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.bANNAKDNBFA_ != null)
			{
				if (this.bANNAKDNBFA_ == null)
				{
					this.BANNAKDNBFA = new EDDPABIGHBE();
				}
				this.BANNAKDNBFA.MergeFrom(other.BANNAKDNBFA);
			}
			this.eBMOKPBKMMD_.Add(other.eBMOKPBKMMD_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008436 RID: 33846 RVA: 0x0015D03D File Offset: 0x0015B23D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008437 RID: 33847 RVA: 0x0015D048 File Offset: 0x0015B248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 50U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.bANNAKDNBFA_ == null)
							{
								this.BANNAKDNBFA = new EDDPABIGHBE();
							}
							input.ReadMessage(this.BANNAKDNBFA);
						}
					}
					else
					{
						this.eBMOKPBKMMD_.AddEntriesFrom(ref input, MultiplayerFightGameStateScRsp._repeated_eBMOKPBKMMD_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400329A RID: 12954
		private static readonly MessageParser<MultiplayerFightGameStateScRsp> _parser = new MessageParser<MultiplayerFightGameStateScRsp>(() => new MultiplayerFightGameStateScRsp());

		// Token: 0x0400329B RID: 12955
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400329C RID: 12956
		public const int RetcodeFieldNumber = 4;

		// Token: 0x0400329D RID: 12957
		private uint retcode_;

		// Token: 0x0400329E RID: 12958
		public const int BANNAKDNBFAFieldNumber = 15;

		// Token: 0x0400329F RID: 12959
		private EDDPABIGHBE bANNAKDNBFA_;

		// Token: 0x040032A0 RID: 12960
		public const int EBMOKPBKMMDFieldNumber = 6;

		// Token: 0x040032A1 RID: 12961
		private static readonly FieldCodec<CCHCPNLPBDK> _repeated_eBMOKPBKMMD_codec = FieldCodec.ForMessage<CCHCPNLPBDK>(50U, CCHCPNLPBDK.Parser);

		// Token: 0x040032A2 RID: 12962
		private readonly RepeatedField<CCHCPNLPBDK> eBMOKPBKMMD_ = new RepeatedField<CCHCPNLPBDK>();
	}
}
