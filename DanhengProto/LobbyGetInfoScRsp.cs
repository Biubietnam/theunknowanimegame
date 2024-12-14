using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A39 RID: 2617
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyGetInfoScRsp : IMessage<LobbyGetInfoScRsp>, IMessage, IEquatable<LobbyGetInfoScRsp>, IDeepCloneable<LobbyGetInfoScRsp>, IBufferMessage
	{
		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x0600741C RID: 29724 RVA: 0x00134C5B File Offset: 0x00132E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyGetInfoScRsp> Parser
		{
			get
			{
				return LobbyGetInfoScRsp._parser;
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x0600741D RID: 29725 RVA: 0x00134C62 File Offset: 0x00132E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyGetInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x0600741E RID: 29726 RVA: 0x00134C74 File Offset: 0x00132E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyGetInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x00134C7B File Offset: 0x00132E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyGetInfoScRsp()
		{
		}

		// Token: 0x06007420 RID: 29728 RVA: 0x00134C90 File Offset: 0x00132E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyGetInfoScRsp(LobbyGetInfoScRsp other) : this()
		{
			this.gCIGJDIMNCE_ = other.gCIGJDIMNCE_;
			this.retcode_ = other.retcode_;
			this.mGAIAJAKPEI_ = other.mGAIAJAKPEI_;
			this.eBMOKPBKMMD_ = other.eBMOKPBKMMD_.Clone();
			this.roomId_ = other.roomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x00134CF5 File Offset: 0x00132EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyGetInfoScRsp Clone()
		{
			return new LobbyGetInfoScRsp(this);
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x06007422 RID: 29730 RVA: 0x00134CFD File Offset: 0x00132EFD
		// (set) Token: 0x06007423 RID: 29731 RVA: 0x00134D05 File Offset: 0x00132F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong GCIGJDIMNCE
		{
			get
			{
				return this.gCIGJDIMNCE_;
			}
			set
			{
				this.gCIGJDIMNCE_ = value;
			}
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06007424 RID: 29732 RVA: 0x00134D0E File Offset: 0x00132F0E
		// (set) Token: 0x06007425 RID: 29733 RVA: 0x00134D16 File Offset: 0x00132F16
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

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06007426 RID: 29734 RVA: 0x00134D1F File Offset: 0x00132F1F
		// (set) Token: 0x06007427 RID: 29735 RVA: 0x00134D27 File Offset: 0x00132F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightGameMode MGAIAJAKPEI
		{
			get
			{
				return this.mGAIAJAKPEI_;
			}
			set
			{
				this.mGAIAJAKPEI_ = value;
			}
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06007428 RID: 29736 RVA: 0x00134D30 File Offset: 0x00132F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CCHCPNLPBDK> EBMOKPBKMMD
		{
			get
			{
				return this.eBMOKPBKMMD_;
			}
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06007429 RID: 29737 RVA: 0x00134D38 File Offset: 0x00132F38
		// (set) Token: 0x0600742A RID: 29738 RVA: 0x00134D40 File Offset: 0x00132F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x00134D49 File Offset: 0x00132F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyGetInfoScRsp);
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x00134D58 File Offset: 0x00132F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyGetInfoScRsp other)
		{
			return other != null && (other == this || (this.GCIGJDIMNCE == other.GCIGJDIMNCE && this.Retcode == other.Retcode && this.MGAIAJAKPEI == other.MGAIAJAKPEI && this.eBMOKPBKMMD_.Equals(other.eBMOKPBKMMD_) && this.RoomId == other.RoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x00134DD8 File Offset: 0x00132FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GCIGJDIMNCE != 0UL)
			{
				num ^= this.GCIGJDIMNCE.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num ^= this.MGAIAJAKPEI.GetHashCode();
			}
			num ^= this.eBMOKPBKMMD_.GetHashCode();
			if (this.RoomId != 0UL)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600742E RID: 29742 RVA: 0x00134E76 File Offset: 0x00133076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x00134E7E File Offset: 0x0013307E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x00134E88 File Offset: 0x00133088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.eBMOKPBKMMD_.WriteTo(ref output, LobbyGetInfoScRsp._repeated_eBMOKPBKMMD_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.MGAIAJAKPEI);
			}
			if (this.RoomId != 0UL)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.RoomId);
			}
			if (this.GCIGJDIMNCE != 0UL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.GCIGJDIMNCE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x00134F2C File Offset: 0x0013312C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GCIGJDIMNCE != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GCIGJDIMNCE);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MGAIAJAKPEI);
			}
			num += this.eBMOKPBKMMD_.CalculateSize(LobbyGetInfoScRsp._repeated_eBMOKPBKMMD_codec);
			if (this.RoomId != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x00134FC8 File Offset: 0x001331C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyGetInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GCIGJDIMNCE != 0UL)
			{
				this.GCIGJDIMNCE = other.GCIGJDIMNCE;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.MGAIAJAKPEI != FightGameMode.None)
			{
				this.MGAIAJAKPEI = other.MGAIAJAKPEI;
			}
			this.eBMOKPBKMMD_.Add(other.eBMOKPBKMMD_);
			if (other.RoomId != 0UL)
			{
				this.RoomId = other.RoomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x00135051 File Offset: 0x00133251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x0013505C File Offset: 0x0013325C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 18U)
					{
						this.eBMOKPBKMMD_.AddEntriesFrom(ref input, LobbyGetInfoScRsp._repeated_eBMOKPBKMMD_codec);
						continue;
					}
					if (num == 56U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.MGAIAJAKPEI = (FightGameMode)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.RoomId = input.ReadUInt64();
						continue;
					}
					if (num == 112U)
					{
						this.GCIGJDIMNCE = input.ReadUInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002CAA RID: 11434
		private static readonly MessageParser<LobbyGetInfoScRsp> _parser = new MessageParser<LobbyGetInfoScRsp>(() => new LobbyGetInfoScRsp());

		// Token: 0x04002CAB RID: 11435
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CAC RID: 11436
		public const int GCIGJDIMNCEFieldNumber = 14;

		// Token: 0x04002CAD RID: 11437
		private ulong gCIGJDIMNCE_;

		// Token: 0x04002CAE RID: 11438
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04002CAF RID: 11439
		private uint retcode_;

		// Token: 0x04002CB0 RID: 11440
		public const int MGAIAJAKPEIFieldNumber = 9;

		// Token: 0x04002CB1 RID: 11441
		private FightGameMode mGAIAJAKPEI_;

		// Token: 0x04002CB2 RID: 11442
		public const int EBMOKPBKMMDFieldNumber = 2;

		// Token: 0x04002CB3 RID: 11443
		private static readonly FieldCodec<CCHCPNLPBDK> _repeated_eBMOKPBKMMD_codec = FieldCodec.ForMessage<CCHCPNLPBDK>(18U, CCHCPNLPBDK.Parser);

		// Token: 0x04002CB4 RID: 11444
		private readonly RepeatedField<CCHCPNLPBDK> eBMOKPBKMMD_ = new RepeatedField<CCHCPNLPBDK>();

		// Token: 0x04002CB5 RID: 11445
		public const int RoomIdFieldNumber = 12;

		// Token: 0x04002CB6 RID: 11446
		private ulong roomId_;
	}
}
