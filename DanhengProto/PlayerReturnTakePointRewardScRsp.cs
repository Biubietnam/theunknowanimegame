using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CDF RID: 3295
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnTakePointRewardScRsp : IMessage<PlayerReturnTakePointRewardScRsp>, IMessage, IEquatable<PlayerReturnTakePointRewardScRsp>, IDeepCloneable<PlayerReturnTakePointRewardScRsp>, IBufferMessage
	{
		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x060092FA RID: 37626 RVA: 0x00185B6F File Offset: 0x00183D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnTakePointRewardScRsp> Parser
		{
			get
			{
				return PlayerReturnTakePointRewardScRsp._parser;
			}
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x060092FB RID: 37627 RVA: 0x00185B76 File Offset: 0x00183D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnTakePointRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x060092FC RID: 37628 RVA: 0x00185B88 File Offset: 0x00183D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnTakePointRewardScRsp.Descriptor;
			}
		}

		// Token: 0x060092FD RID: 37629 RVA: 0x00185B8F File Offset: 0x00183D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakePointRewardScRsp()
		{
		}

		// Token: 0x060092FE RID: 37630 RVA: 0x00185B98 File Offset: 0x00183D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakePointRewardScRsp(PlayerReturnTakePointRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.bKGADLNAJDK_ = ((other.bKGADLNAJDK_ != null) ? other.bKGADLNAJDK_.Clone() : null);
			this.eHCPFCAONKN_ = other.eHCPFCAONKN_;
			this.lPNFOGLAPNE_ = other.lPNFOGLAPNE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092FF RID: 37631 RVA: 0x00185BFC File Offset: 0x00183DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnTakePointRewardScRsp Clone()
		{
			return new PlayerReturnTakePointRewardScRsp(this);
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x06009300 RID: 37632 RVA: 0x00185C04 File Offset: 0x00183E04
		// (set) Token: 0x06009301 RID: 37633 RVA: 0x00185C0C File Offset: 0x00183E0C
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

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x06009302 RID: 37634 RVA: 0x00185C15 File Offset: 0x00183E15
		// (set) Token: 0x06009303 RID: 37635 RVA: 0x00185C1D File Offset: 0x00183E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList BKGADLNAJDK
		{
			get
			{
				return this.bKGADLNAJDK_;
			}
			set
			{
				this.bKGADLNAJDK_ = value;
			}
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x06009304 RID: 37636 RVA: 0x00185C26 File Offset: 0x00183E26
		// (set) Token: 0x06009305 RID: 37637 RVA: 0x00185C2E File Offset: 0x00183E2E
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

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x06009306 RID: 37638 RVA: 0x00185C37 File Offset: 0x00183E37
		// (set) Token: 0x06009307 RID: 37639 RVA: 0x00185C3F File Offset: 0x00183E3F
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

		// Token: 0x06009308 RID: 37640 RVA: 0x00185C48 File Offset: 0x00183E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnTakePointRewardScRsp);
		}

		// Token: 0x06009309 RID: 37641 RVA: 0x00185C58 File Offset: 0x00183E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnTakePointRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BKGADLNAJDK, other.BKGADLNAJDK) && this.EHCPFCAONKN == other.EHCPFCAONKN && this.LPNFOGLAPNE == other.LPNFOGLAPNE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600930A RID: 37642 RVA: 0x00185CC8 File Offset: 0x00183EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.bKGADLNAJDK_ != null)
			{
				num ^= this.BKGADLNAJDK.GetHashCode();
			}
			if (this.EHCPFCAONKN != 0U)
			{
				num ^= this.EHCPFCAONKN.GetHashCode();
			}
			if (this.LPNFOGLAPNE != 0U)
			{
				num ^= this.LPNFOGLAPNE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600930B RID: 37643 RVA: 0x00185D4F File Offset: 0x00183F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600930C RID: 37644 RVA: 0x00185D57 File Offset: 0x00183F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x00185D60 File Offset: 0x00183F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LPNFOGLAPNE != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LPNFOGLAPNE);
			}
			if (this.bKGADLNAJDK_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.BKGADLNAJDK);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EHCPFCAONKN != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EHCPFCAONKN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600930E RID: 37646 RVA: 0x00185DF4 File Offset: 0x00183FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.bKGADLNAJDK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BKGADLNAJDK);
			}
			if (this.EHCPFCAONKN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EHCPFCAONKN);
			}
			if (this.LPNFOGLAPNE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LPNFOGLAPNE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600930F RID: 37647 RVA: 0x00185E7C File Offset: 0x0018407C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnTakePointRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.bKGADLNAJDK_ != null)
			{
				if (this.bKGADLNAJDK_ == null)
				{
					this.BKGADLNAJDK = new ItemList();
				}
				this.BKGADLNAJDK.MergeFrom(other.BKGADLNAJDK);
			}
			if (other.EHCPFCAONKN != 0U)
			{
				this.EHCPFCAONKN = other.EHCPFCAONKN;
			}
			if (other.LPNFOGLAPNE != 0U)
			{
				this.LPNFOGLAPNE = other.LPNFOGLAPNE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009310 RID: 37648 RVA: 0x00185F0C File Offset: 0x0018410C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009311 RID: 37649 RVA: 0x00185F18 File Offset: 0x00184118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 24U)
					{
						this.LPNFOGLAPNE = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
					{
						if (this.bKGADLNAJDK_ == null)
						{
							this.BKGADLNAJDK = new ItemList();
						}
						input.ReadMessage(this.BKGADLNAJDK);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.EHCPFCAONKN = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038B0 RID: 14512
		private static readonly MessageParser<PlayerReturnTakePointRewardScRsp> _parser = new MessageParser<PlayerReturnTakePointRewardScRsp>(() => new PlayerReturnTakePointRewardScRsp());

		// Token: 0x040038B1 RID: 14513
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038B2 RID: 14514
		public const int RetcodeFieldNumber = 8;

		// Token: 0x040038B3 RID: 14515
		private uint retcode_;

		// Token: 0x040038B4 RID: 14516
		public const int BKGADLNAJDKFieldNumber = 6;

		// Token: 0x040038B5 RID: 14517
		private ItemList bKGADLNAJDK_;

		// Token: 0x040038B6 RID: 14518
		public const int EHCPFCAONKNFieldNumber = 14;

		// Token: 0x040038B7 RID: 14519
		private uint eHCPFCAONKN_;

		// Token: 0x040038B8 RID: 14520
		public const int LPNFOGLAPNEFieldNumber = 3;

		// Token: 0x040038B9 RID: 14521
		private uint lPNFOGLAPNE_;
	}
}
