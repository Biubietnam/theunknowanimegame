using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CDD RID: 3293
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnTakePointRewardCsReq : IMessage<PlayerReturnTakePointRewardCsReq>, IMessage, IEquatable<PlayerReturnTakePointRewardCsReq>, IDeepCloneable<PlayerReturnTakePointRewardCsReq>, IBufferMessage
	{
		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x060092E3 RID: 37603 RVA: 0x00185805 File Offset: 0x00183A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnTakePointRewardCsReq> Parser
		{
			get
			{
				return PlayerReturnTakePointRewardCsReq._parser;
			}
		}

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x060092E4 RID: 37604 RVA: 0x0018580C File Offset: 0x00183A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnTakePointRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x060092E5 RID: 37605 RVA: 0x0018581E File Offset: 0x00183A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnTakePointRewardCsReq.Descriptor;
			}
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x00185825 File Offset: 0x00183A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakePointRewardCsReq()
		{
		}

		// Token: 0x060092E7 RID: 37607 RVA: 0x0018582D File Offset: 0x00183A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakePointRewardCsReq(PlayerReturnTakePointRewardCsReq other) : this()
		{
			this.lPNFOGLAPNE_ = other.lPNFOGLAPNE_;
			this.eHCPFCAONKN_ = other.eHCPFCAONKN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092E8 RID: 37608 RVA: 0x0018585E File Offset: 0x00183A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakePointRewardCsReq Clone()
		{
			return new PlayerReturnTakePointRewardCsReq(this);
		}

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x060092E9 RID: 37609 RVA: 0x00185866 File Offset: 0x00183A66
		// (set) Token: 0x060092EA RID: 37610 RVA: 0x0018586E File Offset: 0x00183A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LPNFOGLAPNE
		{
			get
			{
				return this.lPNFOGLAPNE_;
			}
			set
			{
				this.lPNFOGLAPNE_ = value;
			}
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x060092EB RID: 37611 RVA: 0x00185877 File Offset: 0x00183A77
		// (set) Token: 0x060092EC RID: 37612 RVA: 0x0018587F File Offset: 0x00183A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EHCPFCAONKN
		{
			get
			{
				return this.eHCPFCAONKN_;
			}
			set
			{
				this.eHCPFCAONKN_ = value;
			}
		}

		// Token: 0x060092ED RID: 37613 RVA: 0x00185888 File Offset: 0x00183A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnTakePointRewardCsReq);
		}

		// Token: 0x060092EE RID: 37614 RVA: 0x00185896 File Offset: 0x00183A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnTakePointRewardCsReq other)
		{
			return other != null && (other == this || (this.LPNFOGLAPNE == other.LPNFOGLAPNE && this.EHCPFCAONKN == other.EHCPFCAONKN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x001858D4 File Offset: 0x00183AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LPNFOGLAPNE != 0U)
			{
				num ^= this.LPNFOGLAPNE.GetHashCode();
			}
			if (this.EHCPFCAONKN != 0U)
			{
				num ^= this.EHCPFCAONKN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x0018592C File Offset: 0x00183B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060092F1 RID: 37617 RVA: 0x00185934 File Offset: 0x00183B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x00185940 File Offset: 0x00183B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EHCPFCAONKN != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.EHCPFCAONKN);
			}
			if (this.LPNFOGLAPNE != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.LPNFOGLAPNE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x0018599C File Offset: 0x00183B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LPNFOGLAPNE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LPNFOGLAPNE);
			}
			if (this.EHCPFCAONKN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EHCPFCAONKN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x001859F4 File Offset: 0x00183BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnTakePointRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LPNFOGLAPNE != 0U)
			{
				this.LPNFOGLAPNE = other.LPNFOGLAPNE;
			}
			if (other.EHCPFCAONKN != 0U)
			{
				this.EHCPFCAONKN = other.EHCPFCAONKN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092F5 RID: 37621 RVA: 0x00185A44 File Offset: 0x00183C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092F6 RID: 37622 RVA: 0x00185A50 File Offset: 0x00183C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LPNFOGLAPNE = input.ReadUInt32();
					}
				}
				else
				{
					this.EHCPFCAONKN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040038A9 RID: 14505
		private static readonly MessageParser<PlayerReturnTakePointRewardCsReq> _parser = new MessageParser<PlayerReturnTakePointRewardCsReq>(() => new PlayerReturnTakePointRewardCsReq());

		// Token: 0x040038AA RID: 14506
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038AB RID: 14507
		public const int LPNFOGLAPNEFieldNumber = 11;

		// Token: 0x040038AC RID: 14508
		private uint lPNFOGLAPNE_;

		// Token: 0x040038AD RID: 14509
		public const int EHCPFCAONKNFieldNumber = 7;

		// Token: 0x040038AE RID: 14510
		private uint eHCPFCAONKN_;
	}
}
