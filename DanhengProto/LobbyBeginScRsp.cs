using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A2D RID: 2605
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyBeginScRsp : IMessage<LobbyBeginScRsp>, IMessage, IEquatable<LobbyBeginScRsp>, IDeepCloneable<LobbyBeginScRsp>, IBufferMessage
	{
		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x060073BE RID: 29630 RVA: 0x00133D69 File Offset: 0x00131F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyBeginScRsp> Parser
		{
			get
			{
				return LobbyBeginScRsp._parser;
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x060073BF RID: 29631 RVA: 0x00133D70 File Offset: 0x00131F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyBeginScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x060073C0 RID: 29632 RVA: 0x00133D82 File Offset: 0x00131F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyBeginScRsp.Descriptor;
			}
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x00133D89 File Offset: 0x00131F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyBeginScRsp()
		{
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x00133D9C File Offset: 0x00131F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyBeginScRsp(LobbyBeginScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.eBMOKPBKMMD_ = other.eBMOKPBKMMD_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x00133DD2 File Offset: 0x00131FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyBeginScRsp Clone()
		{
			return new LobbyBeginScRsp(this);
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x060073C4 RID: 29636 RVA: 0x00133DDA File Offset: 0x00131FDA
		// (set) Token: 0x060073C5 RID: 29637 RVA: 0x00133DE2 File Offset: 0x00131FE2
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

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x060073C6 RID: 29638 RVA: 0x00133DEB File Offset: 0x00131FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CCHCPNLPBDK> EBMOKPBKMMD
		{
			get
			{
				return this.eBMOKPBKMMD_;
			}
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x00133DF3 File Offset: 0x00131FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyBeginScRsp);
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x00133E04 File Offset: 0x00132004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyBeginScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.eBMOKPBKMMD_.Equals(other.eBMOKPBKMMD_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x00133E54 File Offset: 0x00132054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.eBMOKPBKMMD_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x00133EA1 File Offset: 0x001320A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x00133EA9 File Offset: 0x001320A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x00133EB4 File Offset: 0x001320B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.eBMOKPBKMMD_.WriteTo(ref output, LobbyBeginScRsp._repeated_eBMOKPBKMMD_codec);
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

		// Token: 0x060073CD RID: 29645 RVA: 0x00133F04 File Offset: 0x00132104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.eBMOKPBKMMD_.CalculateSize(LobbyBeginScRsp._repeated_eBMOKPBKMMD_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x00133F58 File Offset: 0x00132158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyBeginScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.eBMOKPBKMMD_.Add(other.eBMOKPBKMMD_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x00133FA5 File Offset: 0x001321A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x00133FB0 File Offset: 0x001321B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.eBMOKPBKMMD_.AddEntriesFrom(ref input, LobbyBeginScRsp._repeated_eBMOKPBKMMD_codec);
				}
			}
		}

		// Token: 0x04002C7D RID: 11389
		private static readonly MessageParser<LobbyBeginScRsp> _parser = new MessageParser<LobbyBeginScRsp>(() => new LobbyBeginScRsp());

		// Token: 0x04002C7E RID: 11390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C7F RID: 11391
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04002C80 RID: 11392
		private uint retcode_;

		// Token: 0x04002C81 RID: 11393
		public const int EBMOKPBKMMDFieldNumber = 10;

		// Token: 0x04002C82 RID: 11394
		private static readonly FieldCodec<CCHCPNLPBDK> _repeated_eBMOKPBKMMD_codec = FieldCodec.ForMessage<CCHCPNLPBDK>(82U, CCHCPNLPBDK.Parser);

		// Token: 0x04002C83 RID: 11395
		private readonly RepeatedField<CCHCPNLPBDK> eBMOKPBKMMD_ = new RepeatedField<CCHCPNLPBDK>();
	}
}
