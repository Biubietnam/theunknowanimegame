using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A43 RID: 2627
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyJoinScRsp : IMessage<LobbyJoinScRsp>, IMessage, IEquatable<LobbyJoinScRsp>, IDeepCloneable<LobbyJoinScRsp>, IBufferMessage
	{
		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06007492 RID: 29842 RVA: 0x00135F4B File Offset: 0x0013414B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyJoinScRsp> Parser
		{
			get
			{
				return LobbyJoinScRsp._parser;
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06007493 RID: 29843 RVA: 0x00135F52 File Offset: 0x00134152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyJoinScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06007494 RID: 29844 RVA: 0x00135F64 File Offset: 0x00134164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyJoinScRsp.Descriptor;
			}
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x00135F6B File Offset: 0x0013416B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyJoinScRsp()
		{
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x00135F80 File Offset: 0x00134180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyJoinScRsp(LobbyJoinScRsp other) : this()
		{
			this.eBMOKPBKMMD_ = other.eBMOKPBKMMD_.Clone();
			this.mGAIAJAKPEI_ = other.mGAIAJAKPEI_;
			this.roomId_ = other.roomId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x00135FD9 File Offset: 0x001341D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyJoinScRsp Clone()
		{
			return new LobbyJoinScRsp(this);
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x00135FE1 File Offset: 0x001341E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CCHCPNLPBDK> EBMOKPBKMMD
		{
			get
			{
				return this.eBMOKPBKMMD_;
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06007499 RID: 29849 RVA: 0x00135FE9 File Offset: 0x001341E9
		// (set) Token: 0x0600749A RID: 29850 RVA: 0x00135FF1 File Offset: 0x001341F1
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

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x0600749B RID: 29851 RVA: 0x00135FFA File Offset: 0x001341FA
		// (set) Token: 0x0600749C RID: 29852 RVA: 0x00136002 File Offset: 0x00134202
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

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x0600749D RID: 29853 RVA: 0x0013600B File Offset: 0x0013420B
		// (set) Token: 0x0600749E RID: 29854 RVA: 0x00136013 File Offset: 0x00134213
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

		// Token: 0x0600749F RID: 29855 RVA: 0x0013601C File Offset: 0x0013421C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyJoinScRsp);
		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x0013602C File Offset: 0x0013422C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyJoinScRsp other)
		{
			return other != null && (other == this || (this.eBMOKPBKMMD_.Equals(other.eBMOKPBKMMD_) && this.MGAIAJAKPEI == other.MGAIAJAKPEI && this.RoomId == other.RoomId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x0013609C File Offset: 0x0013429C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.eBMOKPBKMMD_.GetHashCode();
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num ^= this.MGAIAJAKPEI.GetHashCode();
			}
			if (this.RoomId != 0UL)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x00136121 File Offset: 0x00134321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x00136129 File Offset: 0x00134329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x00136134 File Offset: 0x00134334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomId != 0UL)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.RoomId);
			}
			this.eBMOKPBKMMD_.WriteTo(ref output, LobbyJoinScRsp._repeated_eBMOKPBKMMD_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.MGAIAJAKPEI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x001361BC File Offset: 0x001343BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.eBMOKPBKMMD_.CalculateSize(LobbyJoinScRsp._repeated_eBMOKPBKMMD_codec);
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MGAIAJAKPEI);
			}
			if (this.RoomId != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.RoomId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x00136240 File Offset: 0x00134440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyJoinScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.eBMOKPBKMMD_.Add(other.eBMOKPBKMMD_);
			if (other.MGAIAJAKPEI != FightGameMode.None)
			{
				this.MGAIAJAKPEI = other.MGAIAJAKPEI;
			}
			if (other.RoomId != 0UL)
			{
				this.RoomId = other.RoomId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x001362B5 File Offset: 0x001344B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x001362C0 File Offset: 0x001344C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 24U)
					{
						this.RoomId = input.ReadUInt64();
						continue;
					}
					if (num == 42U)
					{
						this.eBMOKPBKMMD_.AddEntriesFrom(ref input, LobbyJoinScRsp._repeated_eBMOKPBKMMD_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.MGAIAJAKPEI = (FightGameMode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002CD6 RID: 11478
		private static readonly MessageParser<LobbyJoinScRsp> _parser = new MessageParser<LobbyJoinScRsp>(() => new LobbyJoinScRsp());

		// Token: 0x04002CD7 RID: 11479
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CD8 RID: 11480
		public const int EBMOKPBKMMDFieldNumber = 5;

		// Token: 0x04002CD9 RID: 11481
		private static readonly FieldCodec<CCHCPNLPBDK> _repeated_eBMOKPBKMMD_codec = FieldCodec.ForMessage<CCHCPNLPBDK>(42U, CCHCPNLPBDK.Parser);

		// Token: 0x04002CDA RID: 11482
		private readonly RepeatedField<CCHCPNLPBDK> eBMOKPBKMMD_ = new RepeatedField<CCHCPNLPBDK>();

		// Token: 0x04002CDB RID: 11483
		public const int MGAIAJAKPEIFieldNumber = 11;

		// Token: 0x04002CDC RID: 11484
		private FightGameMode mGAIAJAKPEI_;

		// Token: 0x04002CDD RID: 11485
		public const int RoomIdFieldNumber = 3;

		// Token: 0x04002CDE RID: 11486
		private ulong roomId_;

		// Token: 0x04002CDF RID: 11487
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04002CE0 RID: 11488
		private uint retcode_;
	}
}
