using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FFB RID: 4091
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournQueryScRsp : IMessage<RogueTournQueryScRsp>, IMessage, IEquatable<RogueTournQueryScRsp>, IDeepCloneable<RogueTournQueryScRsp>, IBufferMessage
	{
		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600B605 RID: 46597 RVA: 0x001E882F File Offset: 0x001E6A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournQueryScRsp> Parser
		{
			get
			{
				return RogueTournQueryScRsp._parser;
			}
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600B606 RID: 46598 RVA: 0x001E8836 File Offset: 0x001E6A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournQueryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600B607 RID: 46599 RVA: 0x001E8848 File Offset: 0x001E6A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournQueryScRsp.Descriptor;
			}
		}

		// Token: 0x0600B608 RID: 46600 RVA: 0x001E884F File Offset: 0x001E6A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournQueryScRsp()
		{
		}

		// Token: 0x0600B609 RID: 46601 RVA: 0x001E8858 File Offset: 0x001E6A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournQueryScRsp(RogueTournQueryScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurInfo_ = ((other.rogueTournCurInfo_ != null) ? other.rogueTournCurInfo_.Clone() : null);
			this.rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B60A RID: 46602 RVA: 0x001E88C0 File Offset: 0x001E6AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournQueryScRsp Clone()
		{
			return new RogueTournQueryScRsp(this);
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600B60B RID: 46603 RVA: 0x001E88C8 File Offset: 0x001E6AC8
		// (set) Token: 0x0600B60C RID: 46604 RVA: 0x001E88D0 File Offset: 0x001E6AD0
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

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600B60D RID: 46605 RVA: 0x001E88D9 File Offset: 0x001E6AD9
		// (set) Token: 0x0600B60E RID: 46606 RVA: 0x001E88E1 File Offset: 0x001E6AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurInfo RogueTournCurInfo
		{
			get
			{
				return this.rogueTournCurInfo_;
			}
			set
			{
				this.rogueTournCurInfo_ = value;
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600B60F RID: 46607 RVA: 0x001E88EA File Offset: 0x001E6AEA
		// (set) Token: 0x0600B610 RID: 46608 RVA: 0x001E88F2 File Offset: 0x001E6AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournInfo RogueGetInfo
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

		// Token: 0x0600B611 RID: 46609 RVA: 0x001E88FB File Offset: 0x001E6AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournQueryScRsp);
		}

		// Token: 0x0600B612 RID: 46610 RVA: 0x001E890C File Offset: 0x001E6B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournQueryScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurInfo, other.RogueTournCurInfo) && object.Equals(this.RogueGetInfo, other.RogueGetInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B613 RID: 46611 RVA: 0x001E8970 File Offset: 0x001E6B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num ^= this.RogueTournCurInfo.GetHashCode();
			}
			if (this.rogueGetInfo_ != null)
			{
				num ^= this.RogueGetInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x001E89DB File Offset: 0x001E6BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x001E89E3 File Offset: 0x001E6BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B616 RID: 46614 RVA: 0x001E89EC File Offset: 0x001E6BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueGetInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueGetInfo);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueTournCurInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x001E8A64 File Offset: 0x001E6C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurInfo);
			}
			if (this.rogueGetInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGetInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B618 RID: 46616 RVA: 0x001E8AD4 File Offset: 0x001E6CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournQueryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueTournCurInfo_ != null)
			{
				if (this.rogueTournCurInfo_ == null)
				{
					this.RogueTournCurInfo = new RogueTournCurInfo();
				}
				this.RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
			}
			if (other.rogueGetInfo_ != null)
			{
				if (this.rogueGetInfo_ == null)
				{
					this.RogueGetInfo = new RogueTournInfo();
				}
				this.RogueGetInfo.MergeFrom(other.RogueGetInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B619 RID: 46617 RVA: 0x001E8B68 File Offset: 0x001E6D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B61A RID: 46618 RVA: 0x001E8B74 File Offset: 0x001E6D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 58U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rogueTournCurInfo_ == null)
							{
								this.RogueTournCurInfo = new RogueTournCurInfo();
							}
							input.ReadMessage(this.RogueTournCurInfo);
						}
					}
					else
					{
						if (this.rogueGetInfo_ == null)
						{
							this.RogueGetInfo = new RogueTournInfo();
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

		// Token: 0x040049CD RID: 18893
		private static readonly MessageParser<RogueTournQueryScRsp> _parser = new MessageParser<RogueTournQueryScRsp>(() => new RogueTournQueryScRsp());

		// Token: 0x040049CE RID: 18894
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049CF RID: 18895
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040049D0 RID: 18896
		private uint retcode_;

		// Token: 0x040049D1 RID: 18897
		public const int RogueTournCurInfoFieldNumber = 14;

		// Token: 0x040049D2 RID: 18898
		private RogueTournCurInfo rogueTournCurInfo_;

		// Token: 0x040049D3 RID: 18899
		public const int RogueGetInfoFieldNumber = 7;

		// Token: 0x040049D4 RID: 18900
		private RogueTournInfo rogueGetInfo_;
	}
}
