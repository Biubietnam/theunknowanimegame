using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CB9 RID: 3257
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerGetTokenCsReq : IMessage<PlayerGetTokenCsReq>, IMessage, IEquatable<PlayerGetTokenCsReq>, IDeepCloneable<PlayerGetTokenCsReq>, IBufferMessage
	{
		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x060090EE RID: 37102 RVA: 0x0017F6D7 File Offset: 0x0017D8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerGetTokenCsReq> Parser
		{
			get
			{
				return PlayerGetTokenCsReq._parser;
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x060090EF RID: 37103 RVA: 0x0017F6DE File Offset: 0x0017D8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerGetTokenCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x060090F0 RID: 37104 RVA: 0x0017F6F0 File Offset: 0x0017D8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerGetTokenCsReq.Descriptor;
			}
		}

		// Token: 0x060090F1 RID: 37105 RVA: 0x0017F6F7 File Offset: 0x0017D8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGetTokenCsReq()
		{
		}

		// Token: 0x060090F2 RID: 37106 RVA: 0x0017F720 File Offset: 0x0017D920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGetTokenCsReq(PlayerGetTokenCsReq other) : this()
		{
			this.channelId_ = other.channelId_;
			this.accountUid_ = other.accountUid_;
			this.platform_ = other.platform_;
			this.jIOPMFNPBNP_ = other.jIOPMFNPBNP_;
			this.cGEGOLLMHCJ_ = other.cGEGOLLMHCJ_;
			this.uid_ = other.uid_;
			this.token_ = other.token_;
			this.device_ = other.device_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090F3 RID: 37107 RVA: 0x0017F7A4 File Offset: 0x0017D9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGetTokenCsReq Clone()
		{
			return new PlayerGetTokenCsReq(this);
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x060090F4 RID: 37108 RVA: 0x0017F7AC File Offset: 0x0017D9AC
		// (set) Token: 0x060090F5 RID: 37109 RVA: 0x0017F7B4 File Offset: 0x0017D9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x060090F6 RID: 37110 RVA: 0x0017F7BD File Offset: 0x0017D9BD
		// (set) Token: 0x060090F7 RID: 37111 RVA: 0x0017F7C5 File Offset: 0x0017D9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AccountUid
		{
			get
			{
				return this.accountUid_;
			}
			set
			{
				this.accountUid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x060090F8 RID: 37112 RVA: 0x0017F7D8 File Offset: 0x0017D9D8
		// (set) Token: 0x060090F9 RID: 37113 RVA: 0x0017F7E0 File Offset: 0x0017D9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Platform
		{
			get
			{
				return this.platform_;
			}
			set
			{
				this.platform_ = value;
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x060090FA RID: 37114 RVA: 0x0017F7E9 File Offset: 0x0017D9E9
		// (set) Token: 0x060090FB RID: 37115 RVA: 0x0017F7F1 File Offset: 0x0017D9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JIOPMFNPBNP
		{
			get
			{
				return this.jIOPMFNPBNP_;
			}
			set
			{
				this.jIOPMFNPBNP_ = value;
			}
		}

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x060090FC RID: 37116 RVA: 0x0017F7FA File Offset: 0x0017D9FA
		// (set) Token: 0x060090FD RID: 37117 RVA: 0x0017F802 File Offset: 0x0017DA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CGEGOLLMHCJ
		{
			get
			{
				return this.cGEGOLLMHCJ_;
			}
			set
			{
				this.cGEGOLLMHCJ_ = value;
			}
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x060090FE RID: 37118 RVA: 0x0017F80B File Offset: 0x0017DA0B
		// (set) Token: 0x060090FF RID: 37119 RVA: 0x0017F813 File Offset: 0x0017DA13
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

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x06009100 RID: 37120 RVA: 0x0017F81C File Offset: 0x0017DA1C
		// (set) Token: 0x06009101 RID: 37121 RVA: 0x0017F824 File Offset: 0x0017DA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Token
		{
			get
			{
				return this.token_;
			}
			set
			{
				this.token_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x06009102 RID: 37122 RVA: 0x0017F837 File Offset: 0x0017DA37
		// (set) Token: 0x06009103 RID: 37123 RVA: 0x0017F83F File Offset: 0x0017DA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Device
		{
			get
			{
				return this.device_;
			}
			set
			{
				this.device_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x0017F852 File Offset: 0x0017DA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerGetTokenCsReq);
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x0017F860 File Offset: 0x0017DA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerGetTokenCsReq other)
		{
			return other != null && (other == this || (this.ChannelId == other.ChannelId && !(this.AccountUid != other.AccountUid) && this.Platform == other.Platform && this.JIOPMFNPBNP == other.JIOPMFNPBNP && this.CGEGOLLMHCJ == other.CGEGOLLMHCJ && this.Uid == other.Uid && !(this.Token != other.Token) && !(this.Device != other.Device) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x0017F918 File Offset: 0x0017DB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChannelId != 0U)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			if (this.AccountUid.Length != 0)
			{
				num ^= this.AccountUid.GetHashCode();
			}
			if (this.Platform != 0U)
			{
				num ^= this.Platform.GetHashCode();
			}
			if (this.JIOPMFNPBNP != 0U)
			{
				num ^= this.JIOPMFNPBNP.GetHashCode();
			}
			if (this.CGEGOLLMHCJ != 0U)
			{
				num ^= this.CGEGOLLMHCJ.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.Token.Length != 0)
			{
				num ^= this.Token.GetHashCode();
			}
			if (this.Device.Length != 0)
			{
				num ^= this.Device.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x0017FA0C File Offset: 0x0017DC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x0017FA14 File Offset: 0x0017DC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009109 RID: 37129 RVA: 0x0017FA20 File Offset: 0x0017DC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CGEGOLLMHCJ != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CGEGOLLMHCJ);
			}
			if (this.ChannelId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ChannelId);
			}
			if (this.Device.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Device);
			}
			if (this.Token.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Token);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Uid);
			}
			if (this.Platform != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Platform);
			}
			if (this.JIOPMFNPBNP != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.JIOPMFNPBNP);
			}
			if (this.AccountUid.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.AccountUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600910A RID: 37130 RVA: 0x0017FB30 File Offset: 0x0017DD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChannelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChannelId);
			}
			if (this.AccountUid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AccountUid);
			}
			if (this.Platform != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Platform);
			}
			if (this.JIOPMFNPBNP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JIOPMFNPBNP);
			}
			if (this.CGEGOLLMHCJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CGEGOLLMHCJ);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.Token.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Token);
			}
			if (this.Device.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Device);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600910B RID: 37131 RVA: 0x0017FC28 File Offset: 0x0017DE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerGetTokenCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChannelId != 0U)
			{
				this.ChannelId = other.ChannelId;
			}
			if (other.AccountUid.Length != 0)
			{
				this.AccountUid = other.AccountUid;
			}
			if (other.Platform != 0U)
			{
				this.Platform = other.Platform;
			}
			if (other.JIOPMFNPBNP != 0U)
			{
				this.JIOPMFNPBNP = other.JIOPMFNPBNP;
			}
			if (other.CGEGOLLMHCJ != 0U)
			{
				this.CGEGOLLMHCJ = other.CGEGOLLMHCJ;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.Token.Length != 0)
			{
				this.Token = other.Token;
			}
			if (other.Device.Length != 0)
			{
				this.Device = other.Device;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600910C RID: 37132 RVA: 0x0017FCFF File Offset: 0x0017DEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600910D RID: 37133 RVA: 0x0017FD08 File Offset: 0x0017DF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.CGEGOLLMHCJ = input.ReadUInt32();
							continue;
						}
						if (num == 16U)
						{
							this.ChannelId = input.ReadUInt32();
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							this.Device = input.ReadString();
							continue;
						}
						if (num == 50U)
						{
							this.Token = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Platform = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.JIOPMFNPBNP = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						this.AccountUid = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040037CE RID: 14286
		private static readonly MessageParser<PlayerGetTokenCsReq> _parser = new MessageParser<PlayerGetTokenCsReq>(() => new PlayerGetTokenCsReq());

		// Token: 0x040037CF RID: 14287
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037D0 RID: 14288
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040037D1 RID: 14289
		private uint channelId_;

		// Token: 0x040037D2 RID: 14290
		public const int AccountUidFieldNumber = 15;

		// Token: 0x040037D3 RID: 14291
		private string accountUid_ = "";

		// Token: 0x040037D4 RID: 14292
		public const int PlatformFieldNumber = 11;

		// Token: 0x040037D5 RID: 14293
		private uint platform_;

		// Token: 0x040037D6 RID: 14294
		public const int JIOPMFNPBNPFieldNumber = 12;

		// Token: 0x040037D7 RID: 14295
		private uint jIOPMFNPBNP_;

		// Token: 0x040037D8 RID: 14296
		public const int CGEGOLLMHCJFieldNumber = 1;

		// Token: 0x040037D9 RID: 14297
		private uint cGEGOLLMHCJ_;

		// Token: 0x040037DA RID: 14298
		public const int UidFieldNumber = 10;

		// Token: 0x040037DB RID: 14299
		private uint uid_;

		// Token: 0x040037DC RID: 14300
		public const int TokenFieldNumber = 6;

		// Token: 0x040037DD RID: 14301
		private string token_ = "";

		// Token: 0x040037DE RID: 14302
		public const int DeviceFieldNumber = 5;

		// Token: 0x040037DF RID: 14303
		private string device_ = "";
	}
}
