using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BA7 RID: 2983
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiplayerFightGameStartScNotify : IMessage<MultiplayerFightGameStartScNotify>, IMessage, IEquatable<MultiplayerFightGameStartScNotify>, IDeepCloneable<MultiplayerFightGameStartScNotify>, IBufferMessage
	{
		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x060083FA RID: 33786 RVA: 0x0015C7BF File Offset: 0x0015A9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultiplayerFightGameStartScNotify> Parser
		{
			get
			{
				return MultiplayerFightGameStartScNotify._parser;
			}
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x060083FB RID: 33787 RVA: 0x0015C7C6 File Offset: 0x0015A9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultiplayerFightGameStartScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x060083FC RID: 33788 RVA: 0x0015C7D8 File Offset: 0x0015A9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiplayerFightGameStartScNotify.Descriptor;
			}
		}

		// Token: 0x060083FD RID: 33789 RVA: 0x0015C7DF File Offset: 0x0015A9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameStartScNotify()
		{
		}

		// Token: 0x060083FE RID: 33790 RVA: 0x0015C7F4 File Offset: 0x0015A9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameStartScNotify(MultiplayerFightGameStartScNotify other) : this()
		{
			this.eBMOKPBKMMD_ = other.eBMOKPBKMMD_.Clone();
			this.bANNAKDNBFA_ = ((other.bANNAKDNBFA_ != null) ? other.bANNAKDNBFA_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083FF RID: 33791 RVA: 0x0015C845 File Offset: 0x0015AA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameStartScNotify Clone()
		{
			return new MultiplayerFightGameStartScNotify(this);
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x06008400 RID: 33792 RVA: 0x0015C84D File Offset: 0x0015AA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CCHCPNLPBDK> EBMOKPBKMMD
		{
			get
			{
				return this.eBMOKPBKMMD_;
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x06008401 RID: 33793 RVA: 0x0015C855 File Offset: 0x0015AA55
		// (set) Token: 0x06008402 RID: 33794 RVA: 0x0015C85D File Offset: 0x0015AA5D
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

		// Token: 0x06008403 RID: 33795 RVA: 0x0015C866 File Offset: 0x0015AA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiplayerFightGameStartScNotify);
		}

		// Token: 0x06008404 RID: 33796 RVA: 0x0015C874 File Offset: 0x0015AA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiplayerFightGameStartScNotify other)
		{
			return other != null && (other == this || (this.eBMOKPBKMMD_.Equals(other.eBMOKPBKMMD_) && object.Equals(this.BANNAKDNBFA, other.BANNAKDNBFA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008405 RID: 33797 RVA: 0x0015C8C8 File Offset: 0x0015AAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.eBMOKPBKMMD_.GetHashCode();
			if (this.bANNAKDNBFA_ != null)
			{
				num ^= this.BANNAKDNBFA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008406 RID: 33798 RVA: 0x0015C912 File Offset: 0x0015AB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008407 RID: 33799 RVA: 0x0015C91A File Offset: 0x0015AB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008408 RID: 33800 RVA: 0x0015C924 File Offset: 0x0015AB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bANNAKDNBFA_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.BANNAKDNBFA);
			}
			this.eBMOKPBKMMD_.WriteTo(ref output, MultiplayerFightGameStartScNotify._repeated_eBMOKPBKMMD_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008409 RID: 33801 RVA: 0x0015C974 File Offset: 0x0015AB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.eBMOKPBKMMD_.CalculateSize(MultiplayerFightGameStartScNotify._repeated_eBMOKPBKMMD_codec);
			if (this.bANNAKDNBFA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BANNAKDNBFA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600840A RID: 33802 RVA: 0x0015C9C8 File Offset: 0x0015ABC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiplayerFightGameStartScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.eBMOKPBKMMD_.Add(other.eBMOKPBKMMD_);
			if (other.bANNAKDNBFA_ != null)
			{
				if (this.bANNAKDNBFA_ == null)
				{
					this.BANNAKDNBFA = new EDDPABIGHBE();
				}
				this.BANNAKDNBFA.MergeFrom(other.BANNAKDNBFA);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x0015CA2D File Offset: 0x0015AC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600840C RID: 33804 RVA: 0x0015CA38 File Offset: 0x0015AC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.eBMOKPBKMMD_.AddEntriesFrom(ref input, MultiplayerFightGameStartScNotify._repeated_eBMOKPBKMMD_codec);
					}
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
		}

		// Token: 0x0400328F RID: 12943
		private static readonly MessageParser<MultiplayerFightGameStartScNotify> _parser = new MessageParser<MultiplayerFightGameStartScNotify>(() => new MultiplayerFightGameStartScNotify());

		// Token: 0x04003290 RID: 12944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003291 RID: 12945
		public const int EBMOKPBKMMDFieldNumber = 15;

		// Token: 0x04003292 RID: 12946
		private static readonly FieldCodec<CCHCPNLPBDK> _repeated_eBMOKPBKMMD_codec = FieldCodec.ForMessage<CCHCPNLPBDK>(122U, CCHCPNLPBDK.Parser);

		// Token: 0x04003293 RID: 12947
		private readonly RepeatedField<CCHCPNLPBDK> eBMOKPBKMMD_ = new RepeatedField<CCHCPNLPBDK>();

		// Token: 0x04003294 RID: 12948
		public const int BANNAKDNBFAFieldNumber = 6;

		// Token: 0x04003295 RID: 12949
		private EDDPABIGHBE bANNAKDNBFA_;
	}
}
