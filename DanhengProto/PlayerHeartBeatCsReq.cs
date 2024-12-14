using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CBD RID: 3261
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerHeartBeatCsReq : IMessage<PlayerHeartBeatCsReq>, IMessage, IEquatable<PlayerHeartBeatCsReq>, IDeepCloneable<PlayerHeartBeatCsReq>, IBufferMessage
	{
		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x0600912E RID: 37166 RVA: 0x0018048F File Offset: 0x0017E68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerHeartBeatCsReq> Parser
		{
			get
			{
				return PlayerHeartBeatCsReq._parser;
			}
		}

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x0600912F RID: 37167 RVA: 0x00180496 File Offset: 0x0017E696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerHeartBeatCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x06009130 RID: 37168 RVA: 0x001804A8 File Offset: 0x0017E6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHeartBeatCsReq.Descriptor;
			}
		}

		// Token: 0x06009131 RID: 37169 RVA: 0x001804AF File Offset: 0x0017E6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeartBeatCsReq()
		{
		}

		// Token: 0x06009132 RID: 37170 RVA: 0x001804B8 File Offset: 0x0017E6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeartBeatCsReq(PlayerHeartBeatCsReq other) : this()
		{
			this.clientTimeMs_ = other.clientTimeMs_;
			this.cANDPJMDEAD_ = other.cANDPJMDEAD_;
			this.lFEIOFIHJAB_ = ((other.lFEIOFIHJAB_ != null) ? other.lFEIOFIHJAB_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009133 RID: 37171 RVA: 0x00180510 File Offset: 0x0017E710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeartBeatCsReq Clone()
		{
			return new PlayerHeartBeatCsReq(this);
		}

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x06009134 RID: 37172 RVA: 0x00180518 File Offset: 0x0017E718
		// (set) Token: 0x06009135 RID: 37173 RVA: 0x00180520 File Offset: 0x0017E720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ClientTimeMs
		{
			get
			{
				return this.clientTimeMs_;
			}
			set
			{
				this.clientTimeMs_ = value;
			}
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x06009136 RID: 37174 RVA: 0x00180529 File Offset: 0x0017E729
		// (set) Token: 0x06009137 RID: 37175 RVA: 0x00180531 File Offset: 0x0017E731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CANDPJMDEAD
		{
			get
			{
				return this.cANDPJMDEAD_;
			}
			set
			{
				this.cANDPJMDEAD_ = value;
			}
		}

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x06009138 RID: 37176 RVA: 0x0018053A File Offset: 0x0017E73A
		// (set) Token: 0x06009139 RID: 37177 RVA: 0x00180542 File Offset: 0x0017E742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientUploadData LFEIOFIHJAB
		{
			get
			{
				return this.lFEIOFIHJAB_;
			}
			set
			{
				this.lFEIOFIHJAB_ = value;
			}
		}

		// Token: 0x0600913A RID: 37178 RVA: 0x0018054B File Offset: 0x0017E74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHeartBeatCsReq);
		}

		// Token: 0x0600913B RID: 37179 RVA: 0x0018055C File Offset: 0x0017E75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHeartBeatCsReq other)
		{
			return other != null && (other == this || (this.ClientTimeMs == other.ClientTimeMs && this.CANDPJMDEAD == other.CANDPJMDEAD && object.Equals(this.LFEIOFIHJAB, other.LFEIOFIHJAB) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600913C RID: 37180 RVA: 0x001805BC File Offset: 0x0017E7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientTimeMs != 0UL)
			{
				num ^= this.ClientTimeMs.GetHashCode();
			}
			if (this.CANDPJMDEAD != 0U)
			{
				num ^= this.CANDPJMDEAD.GetHashCode();
			}
			if (this.lFEIOFIHJAB_ != null)
			{
				num ^= this.LFEIOFIHJAB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600913D RID: 37181 RVA: 0x0018062A File Offset: 0x0017E82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600913E RID: 37182 RVA: 0x00180632 File Offset: 0x0017E832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600913F RID: 37183 RVA: 0x0018063C File Offset: 0x0017E83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CANDPJMDEAD != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CANDPJMDEAD);
			}
			if (this.ClientTimeMs != 0UL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.ClientTimeMs);
			}
			if (this.lFEIOFIHJAB_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.LFEIOFIHJAB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009140 RID: 37184 RVA: 0x001806B0 File Offset: 0x0017E8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientTimeMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClientTimeMs);
			}
			if (this.CANDPJMDEAD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CANDPJMDEAD);
			}
			if (this.lFEIOFIHJAB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LFEIOFIHJAB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009141 RID: 37185 RVA: 0x00180720 File Offset: 0x0017E920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerHeartBeatCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClientTimeMs != 0UL)
			{
				this.ClientTimeMs = other.ClientTimeMs;
			}
			if (other.CANDPJMDEAD != 0U)
			{
				this.CANDPJMDEAD = other.CANDPJMDEAD;
			}
			if (other.lFEIOFIHJAB_ != null)
			{
				if (this.lFEIOFIHJAB_ == null)
				{
					this.LFEIOFIHJAB = new ClientUploadData();
				}
				this.LFEIOFIHJAB.MergeFrom(other.LFEIOFIHJAB);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009142 RID: 37186 RVA: 0x0018079C File Offset: 0x0017E99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009143 RID: 37187 RVA: 0x001807A8 File Offset: 0x0017E9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 48U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.lFEIOFIHJAB_ == null)
							{
								this.LFEIOFIHJAB = new ClientUploadData();
							}
							input.ReadMessage(this.LFEIOFIHJAB);
						}
					}
					else
					{
						this.ClientTimeMs = input.ReadUInt64();
					}
				}
				else
				{
					this.CANDPJMDEAD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040037EE RID: 14318
		private static readonly MessageParser<PlayerHeartBeatCsReq> _parser = new MessageParser<PlayerHeartBeatCsReq>(() => new PlayerHeartBeatCsReq());

		// Token: 0x040037EF RID: 14319
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037F0 RID: 14320
		public const int ClientTimeMsFieldNumber = 6;

		// Token: 0x040037F1 RID: 14321
		private ulong clientTimeMs_;

		// Token: 0x040037F2 RID: 14322
		public const int CANDPJMDEADFieldNumber = 1;

		// Token: 0x040037F3 RID: 14323
		private uint cANDPJMDEAD_;

		// Token: 0x040037F4 RID: 14324
		public const int LFEIOFIHJABFieldNumber = 11;

		// Token: 0x040037F5 RID: 14325
		private ClientUploadData lFEIOFIHJAB_;
	}
}
