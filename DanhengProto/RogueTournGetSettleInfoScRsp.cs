using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FD7 RID: 4055
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetSettleInfoScRsp : IMessage<RogueTournGetSettleInfoScRsp>, IMessage, IEquatable<RogueTournGetSettleInfoScRsp>, IDeepCloneable<RogueTournGetSettleInfoScRsp>, IBufferMessage
	{
		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600B49F RID: 46239 RVA: 0x001E49CB File Offset: 0x001E2BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetSettleInfoScRsp> Parser
		{
			get
			{
				return RogueTournGetSettleInfoScRsp._parser;
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600B4A0 RID: 46240 RVA: 0x001E49D2 File Offset: 0x001E2BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetSettleInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600B4A1 RID: 46241 RVA: 0x001E49E4 File Offset: 0x001E2BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetSettleInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x001E49EB File Offset: 0x001E2BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetSettleInfoScRsp()
		{
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x001E49F4 File Offset: 0x001E2BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetSettleInfoScRsp(RogueTournGetSettleInfoScRsp other) : this()
		{
			this.tournFinishInfo_ = ((other.tournFinishInfo_ != null) ? other.tournFinishInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4A4 RID: 46244 RVA: 0x001E4A40 File Offset: 0x001E2C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetSettleInfoScRsp Clone()
		{
			return new RogueTournGetSettleInfoScRsp(this);
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600B4A5 RID: 46245 RVA: 0x001E4A48 File Offset: 0x001E2C48
		// (set) Token: 0x0600B4A6 RID: 46246 RVA: 0x001E4A50 File Offset: 0x001E2C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFinishInfo TournFinishInfo
		{
			get
			{
				return this.tournFinishInfo_;
			}
			set
			{
				this.tournFinishInfo_ = value;
			}
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600B4A7 RID: 46247 RVA: 0x001E4A59 File Offset: 0x001E2C59
		// (set) Token: 0x0600B4A8 RID: 46248 RVA: 0x001E4A61 File Offset: 0x001E2C61
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

		// Token: 0x0600B4A9 RID: 46249 RVA: 0x001E4A6A File Offset: 0x001E2C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetSettleInfoScRsp);
		}

		// Token: 0x0600B4AA RID: 46250 RVA: 0x001E4A78 File Offset: 0x001E2C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetSettleInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.TournFinishInfo, other.TournFinishInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4AB RID: 46251 RVA: 0x001E4AC8 File Offset: 0x001E2CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.tournFinishInfo_ != null)
			{
				num ^= this.TournFinishInfo.GetHashCode();
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

		// Token: 0x0600B4AC RID: 46252 RVA: 0x001E4B1D File Offset: 0x001E2D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x001E4B25 File Offset: 0x001E2D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x001E4B30 File Offset: 0x001E2D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.tournFinishInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TournFinishInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x001E4B8C File Offset: 0x001E2D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.tournFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TournFinishInfo);
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

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x001E4BE4 File Offset: 0x001E2DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetSettleInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.tournFinishInfo_ != null)
			{
				if (this.tournFinishInfo_ == null)
				{
					this.TournFinishInfo = new RogueTournFinishInfo();
				}
				this.TournFinishInfo.MergeFrom(other.TournFinishInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x001E4C4C File Offset: 0x001E2E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4B2 RID: 46258 RVA: 0x001E4C58 File Offset: 0x001E2E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 40U)
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
					if (this.tournFinishInfo_ == null)
					{
						this.TournFinishInfo = new RogueTournFinishInfo();
					}
					input.ReadMessage(this.TournFinishInfo);
				}
			}
		}

		// Token: 0x04004930 RID: 18736
		private static readonly MessageParser<RogueTournGetSettleInfoScRsp> _parser = new MessageParser<RogueTournGetSettleInfoScRsp>(() => new RogueTournGetSettleInfoScRsp());

		// Token: 0x04004931 RID: 18737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004932 RID: 18738
		public const int TournFinishInfoFieldNumber = 4;

		// Token: 0x04004933 RID: 18739
		private RogueTournFinishInfo tournFinishInfo_;

		// Token: 0x04004934 RID: 18740
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04004935 RID: 18741
		private uint retcode_;
	}
}
