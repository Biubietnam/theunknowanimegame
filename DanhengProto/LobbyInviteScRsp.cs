using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A3F RID: 2623
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyInviteScRsp : IMessage<LobbyInviteScRsp>, IMessage, IEquatable<LobbyInviteScRsp>, IDeepCloneable<LobbyInviteScRsp>, IBufferMessage
	{
		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06007465 RID: 29797 RVA: 0x00135828 File Offset: 0x00133A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyInviteScRsp> Parser
		{
			get
			{
				return LobbyInviteScRsp._parser;
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06007466 RID: 29798 RVA: 0x0013582F File Offset: 0x00133A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyInviteScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06007467 RID: 29799 RVA: 0x00135841 File Offset: 0x00133A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyInviteScRsp.Descriptor;
			}
		}

		// Token: 0x06007468 RID: 29800 RVA: 0x00135848 File Offset: 0x00133A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyInviteScRsp()
		{
		}

		// Token: 0x06007469 RID: 29801 RVA: 0x0013585B File Offset: 0x00133A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyInviteScRsp(LobbyInviteScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.uidList_ = other.uidList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600746A RID: 29802 RVA: 0x00135891 File Offset: 0x00133A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyInviteScRsp Clone()
		{
			return new LobbyInviteScRsp(this);
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x0600746B RID: 29803 RVA: 0x00135899 File Offset: 0x00133A99
		// (set) Token: 0x0600746C RID: 29804 RVA: 0x001358A1 File Offset: 0x00133AA1
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

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x0600746D RID: 29805 RVA: 0x001358AA File Offset: 0x00133AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UidList
		{
			get
			{
				return this.uidList_;
			}
		}

		// Token: 0x0600746E RID: 29806 RVA: 0x001358B2 File Offset: 0x00133AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyInviteScRsp);
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x001358C0 File Offset: 0x00133AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyInviteScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.uidList_.Equals(other.uidList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x00135910 File Offset: 0x00133B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.uidList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x0013595D File Offset: 0x00133B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007472 RID: 29810 RVA: 0x00135965 File Offset: 0x00133B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007473 RID: 29811 RVA: 0x00135970 File Offset: 0x00133B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.uidList_.WriteTo(ref output, LobbyInviteScRsp._repeated_uidList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007474 RID: 29812 RVA: 0x001359C0 File Offset: 0x00133BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.uidList_.CalculateSize(LobbyInviteScRsp._repeated_uidList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x00135A14 File Offset: 0x00133C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyInviteScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.uidList_.Add(other.uidList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x00135A61 File Offset: 0x00133C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x00135A6C File Offset: 0x00133C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U && num != 34U)
				{
					if (num != 48U)
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
					this.uidList_.AddEntriesFrom(ref input, LobbyInviteScRsp._repeated_uidList_codec);
				}
			}
		}

		// Token: 0x04002CC7 RID: 11463
		private static readonly MessageParser<LobbyInviteScRsp> _parser = new MessageParser<LobbyInviteScRsp>(() => new LobbyInviteScRsp());

		// Token: 0x04002CC8 RID: 11464
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CC9 RID: 11465
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04002CCA RID: 11466
		private uint retcode_;

		// Token: 0x04002CCB RID: 11467
		public const int UidListFieldNumber = 4;

		// Token: 0x04002CCC RID: 11468
		private static readonly FieldCodec<uint> _repeated_uidList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04002CCD RID: 11469
		private readonly RepeatedField<uint> uidList_ = new RepeatedField<uint>();
	}
}
