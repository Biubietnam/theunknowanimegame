using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200072F RID: 1839
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMonopolyFriendRankingListScRsp : IMessage<GetMonopolyFriendRankingListScRsp>, IMessage, IEquatable<GetMonopolyFriendRankingListScRsp>, IDeepCloneable<GetMonopolyFriendRankingListScRsp>, IBufferMessage
	{
		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06005229 RID: 21033 RVA: 0x000DD22F File Offset: 0x000DB42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMonopolyFriendRankingListScRsp> Parser
		{
			get
			{
				return GetMonopolyFriendRankingListScRsp._parser;
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x0600522A RID: 21034 RVA: 0x000DD236 File Offset: 0x000DB436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMonopolyFriendRankingListScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x0600522B RID: 21035 RVA: 0x000DD248 File Offset: 0x000DB448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMonopolyFriendRankingListScRsp.Descriptor;
			}
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x000DD24F File Offset: 0x000DB44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyFriendRankingListScRsp()
		{
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x000DD264 File Offset: 0x000DB464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyFriendRankingListScRsp(GetMonopolyFriendRankingListScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.oABNGINNGPO_ = other.oABNGINNGPO_.Clone();
			this.iAKOKMMPJKD_ = ((other.iAKOKMMPJKD_ != null) ? other.iAKOKMMPJKD_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x000DD2C1 File Offset: 0x000DB4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyFriendRankingListScRsp Clone()
		{
			return new GetMonopolyFriendRankingListScRsp(this);
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x0600522F RID: 21039 RVA: 0x000DD2C9 File Offset: 0x000DB4C9
		// (set) Token: 0x06005230 RID: 21040 RVA: 0x000DD2D1 File Offset: 0x000DB4D1
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

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06005231 RID: 21041 RVA: 0x000DD2DA File Offset: 0x000DB4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JJNGJHOCAGD> OABNGINNGPO
		{
			get
			{
				return this.oABNGINNGPO_;
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06005232 RID: 21042 RVA: 0x000DD2E2 File Offset: 0x000DB4E2
		// (set) Token: 0x06005233 RID: 21043 RVA: 0x000DD2EA File Offset: 0x000DB4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJNGJHOCAGD IAKOKMMPJKD
		{
			get
			{
				return this.iAKOKMMPJKD_;
			}
			set
			{
				this.iAKOKMMPJKD_ = value;
			}
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x000DD2F3 File Offset: 0x000DB4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMonopolyFriendRankingListScRsp);
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x000DD304 File Offset: 0x000DB504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMonopolyFriendRankingListScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.oABNGINNGPO_.Equals(other.oABNGINNGPO_) && object.Equals(this.IAKOKMMPJKD, other.IAKOKMMPJKD) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x000DD368 File Offset: 0x000DB568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.oABNGINNGPO_.GetHashCode();
			if (this.iAKOKMMPJKD_ != null)
			{
				num ^= this.IAKOKMMPJKD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x000DD3CB File Offset: 0x000DB5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x000DD3D3 File Offset: 0x000DB5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x000DD3DC File Offset: 0x000DB5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iAKOKMMPJKD_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.IAKOKMMPJKD);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			this.oABNGINNGPO_.WriteTo(ref output, GetMonopolyFriendRankingListScRsp._repeated_oABNGINNGPO_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x000DD448 File Offset: 0x000DB648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.oABNGINNGPO_.CalculateSize(GetMonopolyFriendRankingListScRsp._repeated_oABNGINNGPO_codec);
			if (this.iAKOKMMPJKD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IAKOKMMPJKD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x000DD4B4 File Offset: 0x000DB6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMonopolyFriendRankingListScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.oABNGINNGPO_.Add(other.oABNGINNGPO_);
			if (other.iAKOKMMPJKD_ != null)
			{
				if (this.iAKOKMMPJKD_ == null)
				{
					this.IAKOKMMPJKD = new JJNGJHOCAGD();
				}
				this.IAKOKMMPJKD.MergeFrom(other.IAKOKMMPJKD);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x000DD52D File Offset: 0x000DB72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x000DD538 File Offset: 0x000DB738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 56U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.oABNGINNGPO_.AddEntriesFrom(ref input, GetMonopolyFriendRankingListScRsp._repeated_oABNGINNGPO_codec);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.iAKOKMMPJKD_ == null)
					{
						this.IAKOKMMPJKD = new JJNGJHOCAGD();
					}
					input.ReadMessage(this.IAKOKMMPJKD);
				}
			}
		}

		// Token: 0x0400204B RID: 8267
		private static readonly MessageParser<GetMonopolyFriendRankingListScRsp> _parser = new MessageParser<GetMonopolyFriendRankingListScRsp>(() => new GetMonopolyFriendRankingListScRsp());

		// Token: 0x0400204C RID: 8268
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400204D RID: 8269
		public const int RetcodeFieldNumber = 7;

		// Token: 0x0400204E RID: 8270
		private uint retcode_;

		// Token: 0x0400204F RID: 8271
		public const int OABNGINNGPOFieldNumber = 11;

		// Token: 0x04002050 RID: 8272
		private static readonly FieldCodec<JJNGJHOCAGD> _repeated_oABNGINNGPO_codec = FieldCodec.ForMessage<JJNGJHOCAGD>(90U, JJNGJHOCAGD.Parser);

		// Token: 0x04002051 RID: 8273
		private readonly RepeatedField<JJNGJHOCAGD> oABNGINNGPO_ = new RepeatedField<JJNGJHOCAGD>();

		// Token: 0x04002052 RID: 8274
		public const int IAKOKMMPJKDFieldNumber = 3;

		// Token: 0x04002053 RID: 8275
		private JJNGJHOCAGD iAKOKMMPJKD_;
	}
}
