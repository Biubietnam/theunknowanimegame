using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CBB RID: 3259
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerGetTokenScRsp : IMessage<PlayerGetTokenScRsp>, IMessage, IEquatable<PlayerGetTokenScRsp>, IDeepCloneable<PlayerGetTokenScRsp>, IBufferMessage
	{
		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x06009111 RID: 37137 RVA: 0x0017FEBB File Offset: 0x0017E0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerGetTokenScRsp> Parser
		{
			get
			{
				return PlayerGetTokenScRsp._parser;
			}
		}

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x06009112 RID: 37138 RVA: 0x0017FEC2 File Offset: 0x0017E0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerGetTokenScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x06009113 RID: 37139 RVA: 0x0017FED4 File Offset: 0x0017E0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerGetTokenScRsp.Descriptor;
			}
		}

		// Token: 0x06009114 RID: 37140 RVA: 0x0017FEDB File Offset: 0x0017E0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGetTokenScRsp()
		{
		}

		// Token: 0x06009115 RID: 37141 RVA: 0x0017FEF0 File Offset: 0x0017E0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGetTokenScRsp(PlayerGetTokenScRsp other) : this()
		{
			this.msg_ = other.msg_;
			this.blackInfo_ = ((other.blackInfo_ != null) ? other.blackInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.secretKeySeed_ = other.secretKeySeed_;
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009116 RID: 37142 RVA: 0x0017FF60 File Offset: 0x0017E160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGetTokenScRsp Clone()
		{
			return new PlayerGetTokenScRsp(this);
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x06009117 RID: 37143 RVA: 0x0017FF68 File Offset: 0x0017E168
		// (set) Token: 0x06009118 RID: 37144 RVA: 0x0017FF70 File Offset: 0x0017E170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Msg
		{
			get
			{
				return this.msg_;
			}
			set
			{
				this.msg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x06009119 RID: 37145 RVA: 0x0017FF83 File Offset: 0x0017E183
		// (set) Token: 0x0600911A RID: 37146 RVA: 0x0017FF8B File Offset: 0x0017E18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackInfo BlackInfo
		{
			get
			{
				return this.blackInfo_;
			}
			set
			{
				this.blackInfo_ = value;
			}
		}

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x0600911B RID: 37147 RVA: 0x0017FF94 File Offset: 0x0017E194
		// (set) Token: 0x0600911C RID: 37148 RVA: 0x0017FF9C File Offset: 0x0017E19C
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

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x0600911D RID: 37149 RVA: 0x0017FFA5 File Offset: 0x0017E1A5
		// (set) Token: 0x0600911E RID: 37150 RVA: 0x0017FFAD File Offset: 0x0017E1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong SecretKeySeed
		{
			get
			{
				return this.secretKeySeed_;
			}
			set
			{
				this.secretKeySeed_ = value;
			}
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x0600911F RID: 37151 RVA: 0x0017FFB6 File Offset: 0x0017E1B6
		// (set) Token: 0x06009120 RID: 37152 RVA: 0x0017FFBE File Offset: 0x0017E1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x06009121 RID: 37153 RVA: 0x0017FFC7 File Offset: 0x0017E1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerGetTokenScRsp);
		}

		// Token: 0x06009122 RID: 37154 RVA: 0x0017FFD8 File Offset: 0x0017E1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerGetTokenScRsp other)
		{
			return other != null && (other == this || (!(this.Msg != other.Msg) && object.Equals(this.BlackInfo, other.BlackInfo) && this.Retcode == other.Retcode && this.SecretKeySeed == other.SecretKeySeed && this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009123 RID: 37155 RVA: 0x0018005C File Offset: 0x0017E25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Msg.Length != 0)
			{
				num ^= this.Msg.GetHashCode();
			}
			if (this.blackInfo_ != null)
			{
				num ^= this.BlackInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.SecretKeySeed != 0UL)
			{
				num ^= this.SecretKeySeed.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009124 RID: 37156 RVA: 0x001800FE File Offset: 0x0017E2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009125 RID: 37157 RVA: 0x00180106 File Offset: 0x0017E306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009126 RID: 37158 RVA: 0x00180110 File Offset: 0x0017E310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SecretKeySeed != 0UL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.SecretKeySeed);
			}
			if (this.Msg.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Msg);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Uid);
			}
			if (this.blackInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.BlackInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009127 RID: 37159 RVA: 0x001801C4 File Offset: 0x0017E3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Msg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Msg);
			}
			if (this.blackInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BlackInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.SecretKeySeed != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SecretKeySeed);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009128 RID: 37160 RVA: 0x00180268 File Offset: 0x0017E468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerGetTokenScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Msg.Length != 0)
			{
				this.Msg = other.Msg;
			}
			if (other.blackInfo_ != null)
			{
				if (this.blackInfo_ == null)
				{
					this.BlackInfo = new BlackInfo();
				}
				this.BlackInfo.MergeFrom(other.BlackInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.SecretKeySeed != 0UL)
			{
				this.SecretKeySeed = other.SecretKeySeed;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009129 RID: 37161 RVA: 0x00180311 File Offset: 0x0017E511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600912A RID: 37162 RVA: 0x0018031C File Offset: 0x0017E51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 40U)
					{
						this.SecretKeySeed = input.ReadUInt64();
						continue;
					}
					if (num == 50U)
					{
						this.Msg = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.blackInfo_ == null)
						{
							this.BlackInfo = new BlackInfo();
						}
						input.ReadMessage(this.BlackInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040037E1 RID: 14305
		private static readonly MessageParser<PlayerGetTokenScRsp> _parser = new MessageParser<PlayerGetTokenScRsp>(() => new PlayerGetTokenScRsp());

		// Token: 0x040037E2 RID: 14306
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037E3 RID: 14307
		public const int MsgFieldNumber = 6;

		// Token: 0x040037E4 RID: 14308
		private string msg_ = "";

		// Token: 0x040037E5 RID: 14309
		public const int BlackInfoFieldNumber = 14;

		// Token: 0x040037E6 RID: 14310
		private BlackInfo blackInfo_;

		// Token: 0x040037E7 RID: 14311
		public const int RetcodeFieldNumber = 11;

		// Token: 0x040037E8 RID: 14312
		private uint retcode_;

		// Token: 0x040037E9 RID: 14313
		public const int SecretKeySeedFieldNumber = 5;

		// Token: 0x040037EA RID: 14314
		private ulong secretKeySeed_;

		// Token: 0x040037EB RID: 14315
		public const int UidFieldNumber = 12;

		// Token: 0x040037EC RID: 14316
		private uint uid_;
	}
}
