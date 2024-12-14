using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A35 RID: 2613
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyCreateScRsp : IMessage<LobbyCreateScRsp>, IMessage, IEquatable<LobbyCreateScRsp>, IDeepCloneable<LobbyCreateScRsp>, IBufferMessage
	{
		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x060073EF RID: 29679 RVA: 0x001345BB File Offset: 0x001327BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyCreateScRsp> Parser
		{
			get
			{
				return LobbyCreateScRsp._parser;
			}
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x060073F0 RID: 29680 RVA: 0x001345C2 File Offset: 0x001327C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyCreateScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x060073F1 RID: 29681 RVA: 0x001345D4 File Offset: 0x001327D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyCreateScRsp.Descriptor;
			}
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x001345DB File Offset: 0x001327DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyCreateScRsp()
		{
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x001345F0 File Offset: 0x001327F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyCreateScRsp(LobbyCreateScRsp other) : this()
		{
			this.eBMOKPBKMMD_ = other.eBMOKPBKMMD_.Clone();
			this.mGAIAJAKPEI_ = other.mGAIAJAKPEI_;
			this.retcode_ = other.retcode_;
			this.roomId_ = other.roomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x00134649 File Offset: 0x00132849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyCreateScRsp Clone()
		{
			return new LobbyCreateScRsp(this);
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x060073F5 RID: 29685 RVA: 0x00134651 File Offset: 0x00132851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CCHCPNLPBDK> EBMOKPBKMMD
		{
			get
			{
				return this.eBMOKPBKMMD_;
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x060073F6 RID: 29686 RVA: 0x00134659 File Offset: 0x00132859
		// (set) Token: 0x060073F7 RID: 29687 RVA: 0x00134661 File Offset: 0x00132861
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

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x060073F8 RID: 29688 RVA: 0x0013466A File Offset: 0x0013286A
		// (set) Token: 0x060073F9 RID: 29689 RVA: 0x00134672 File Offset: 0x00132872
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

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x060073FA RID: 29690 RVA: 0x0013467B File Offset: 0x0013287B
		// (set) Token: 0x060073FB RID: 29691 RVA: 0x00134683 File Offset: 0x00132883
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

		// Token: 0x060073FC RID: 29692 RVA: 0x0013468C File Offset: 0x0013288C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyCreateScRsp);
		}

		// Token: 0x060073FD RID: 29693 RVA: 0x0013469C File Offset: 0x0013289C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyCreateScRsp other)
		{
			return other != null && (other == this || (this.eBMOKPBKMMD_.Equals(other.eBMOKPBKMMD_) && this.MGAIAJAKPEI == other.MGAIAJAKPEI && this.Retcode == other.Retcode && this.RoomId == other.RoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073FE RID: 29694 RVA: 0x0013470C File Offset: 0x0013290C
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
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
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

		// Token: 0x060073FF RID: 29695 RVA: 0x00134791 File Offset: 0x00132991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x00134799 File Offset: 0x00132999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007401 RID: 29697 RVA: 0x001347A4 File Offset: 0x001329A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.eBMOKPBKMMD_.WriteTo(ref output, LobbyCreateScRsp._repeated_eBMOKPBKMMD_codec);
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.MGAIAJAKPEI);
			}
			if (this.RoomId != 0UL)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.RoomId);
			}
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

		// Token: 0x06007402 RID: 29698 RVA: 0x0013482C File Offset: 0x00132A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.eBMOKPBKMMD_.CalculateSize(LobbyCreateScRsp._repeated_eBMOKPBKMMD_codec);
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MGAIAJAKPEI);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
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

		// Token: 0x06007403 RID: 29699 RVA: 0x001348B0 File Offset: 0x00132AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyCreateScRsp other)
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
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.RoomId != 0UL)
			{
				this.RoomId = other.RoomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007404 RID: 29700 RVA: 0x00134925 File Offset: 0x00132B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007405 RID: 29701 RVA: 0x00134930 File Offset: 0x00132B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 18U)
					{
						this.eBMOKPBKMMD_.AddEntriesFrom(ref input, LobbyCreateScRsp._repeated_eBMOKPBKMMD_codec);
						continue;
					}
					if (num == 40U)
					{
						this.MGAIAJAKPEI = (FightGameMode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.RoomId = input.ReadUInt64();
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

		// Token: 0x04002C9B RID: 11419
		private static readonly MessageParser<LobbyCreateScRsp> _parser = new MessageParser<LobbyCreateScRsp>(() => new LobbyCreateScRsp());

		// Token: 0x04002C9C RID: 11420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C9D RID: 11421
		public const int EBMOKPBKMMDFieldNumber = 2;

		// Token: 0x04002C9E RID: 11422
		private static readonly FieldCodec<CCHCPNLPBDK> _repeated_eBMOKPBKMMD_codec = FieldCodec.ForMessage<CCHCPNLPBDK>(18U, CCHCPNLPBDK.Parser);

		// Token: 0x04002C9F RID: 11423
		private readonly RepeatedField<CCHCPNLPBDK> eBMOKPBKMMD_ = new RepeatedField<CCHCPNLPBDK>();

		// Token: 0x04002CA0 RID: 11424
		public const int MGAIAJAKPEIFieldNumber = 5;

		// Token: 0x04002CA1 RID: 11425
		private FightGameMode mGAIAJAKPEI_;

		// Token: 0x04002CA2 RID: 11426
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04002CA3 RID: 11427
		private uint retcode_;

		// Token: 0x04002CA4 RID: 11428
		public const int RoomIdFieldNumber = 12;

		// Token: 0x04002CA5 RID: 11429
		private ulong roomId_;
	}
}
