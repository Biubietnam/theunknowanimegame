using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000315 RID: 789
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CommonRogueQueryScRsp : IMessage<CommonRogueQueryScRsp>, IMessage, IEquatable<CommonRogueQueryScRsp>, IDeepCloneable<CommonRogueQueryScRsp>, IBufferMessage
	{
		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x000646C7 File Offset: 0x000628C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CommonRogueQueryScRsp> Parser
		{
			get
			{
				return CommonRogueQueryScRsp._parser;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x000646CE File Offset: 0x000628CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonRogueQueryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x000646E0 File Offset: 0x000628E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonRogueQueryScRsp.Descriptor;
			}
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x000646E7 File Offset: 0x000628E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueQueryScRsp()
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x000646F0 File Offset: 0x000628F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueQueryScRsp(CommonRogueQueryScRsp other) : this()
		{
			this.kAAGIEKEOND_ = other.kAAGIEKEOND_;
			this.rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00064748 File Offset: 0x00062948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueQueryScRsp Clone()
		{
			return new CommonRogueQueryScRsp(this);
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x00064750 File Offset: 0x00062950
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x00064758 File Offset: 0x00062958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KAAGIEKEOND
		{
			get
			{
				return this.kAAGIEKEOND_;
			}
			set
			{
				this.kAAGIEKEOND_ = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x00064761 File Offset: 0x00062961
		// (set) Token: 0x06002361 RID: 9057 RVA: 0x00064769 File Offset: 0x00062969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EIGCJPGPIOC RogueGetInfo
		{
			get
			{
				return this.rogueGetInfo_;
			}
			set
			{
				this.rogueGetInfo_ = value;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x00064772 File Offset: 0x00062972
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x0006477A File Offset: 0x0006297A
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

		// Token: 0x06002364 RID: 9060 RVA: 0x00064783 File Offset: 0x00062983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonRogueQueryScRsp);
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00064794 File Offset: 0x00062994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonRogueQueryScRsp other)
		{
			return other != null && (other == this || (this.KAAGIEKEOND == other.KAAGIEKEOND && object.Equals(this.RogueGetInfo, other.RogueGetInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x000647F4 File Offset: 0x000629F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KAAGIEKEOND != 0U)
			{
				num ^= this.KAAGIEKEOND.GetHashCode();
			}
			if (this.rogueGetInfo_ != null)
			{
				num ^= this.RogueGetInfo.GetHashCode();
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

		// Token: 0x06002367 RID: 9063 RVA: 0x00064862 File Offset: 0x00062A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x0006486A File Offset: 0x00062A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00064874 File Offset: 0x00062A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueGetInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueGetInfo);
			}
			if (this.KAAGIEKEOND != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.KAAGIEKEOND);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x000648E8 File Offset: 0x00062AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KAAGIEKEOND != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KAAGIEKEOND);
			}
			if (this.rogueGetInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGetInfo);
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

		// Token: 0x0600236B RID: 9067 RVA: 0x00064958 File Offset: 0x00062B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonRogueQueryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KAAGIEKEOND != 0U)
			{
				this.KAAGIEKEOND = other.KAAGIEKEOND;
			}
			if (other.rogueGetInfo_ != null)
			{
				if (this.rogueGetInfo_ == null)
				{
					this.RogueGetInfo = new EIGCJPGPIOC();
				}
				this.RogueGetInfo.MergeFrom(other.RogueGetInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x000649D4 File Offset: 0x00062BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x000649E0 File Offset: 0x00062BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.KAAGIEKEOND = input.ReadUInt32();
						}
					}
					else
					{
						if (this.rogueGetInfo_ == null)
						{
							this.RogueGetInfo = new EIGCJPGPIOC();
						}
						input.ReadMessage(this.RogueGetInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000E87 RID: 3719
		private static readonly MessageParser<CommonRogueQueryScRsp> _parser = new MessageParser<CommonRogueQueryScRsp>(() => new CommonRogueQueryScRsp());

		// Token: 0x04000E88 RID: 3720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E89 RID: 3721
		public const int KAAGIEKEONDFieldNumber = 10;

		// Token: 0x04000E8A RID: 3722
		private uint kAAGIEKEOND_;

		// Token: 0x04000E8B RID: 3723
		public const int RogueGetInfoFieldNumber = 2;

		// Token: 0x04000E8C RID: 3724
		private EIGCJPGPIOC rogueGetInfo_;

		// Token: 0x04000E8D RID: 3725
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04000E8E RID: 3726
		private uint retcode_;
	}
}
