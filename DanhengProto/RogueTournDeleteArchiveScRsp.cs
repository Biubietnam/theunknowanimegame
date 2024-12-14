using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F95 RID: 3989
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournDeleteArchiveScRsp : IMessage<RogueTournDeleteArchiveScRsp>, IMessage, IEquatable<RogueTournDeleteArchiveScRsp>, IDeepCloneable<RogueTournDeleteArchiveScRsp>, IBufferMessage
	{
		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600B1BE RID: 45502 RVA: 0x001DDE79 File Offset: 0x001DC079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournDeleteArchiveScRsp> Parser
		{
			get
			{
				return RogueTournDeleteArchiveScRsp._parser;
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600B1BF RID: 45503 RVA: 0x001DDE80 File Offset: 0x001DC080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournDeleteArchiveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600B1C0 RID: 45504 RVA: 0x001DDE92 File Offset: 0x001DC092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournDeleteArchiveScRsp.Descriptor;
			}
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x001DDE99 File Offset: 0x001DC099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDeleteArchiveScRsp()
		{
		}

		// Token: 0x0600B1C2 RID: 45506 RVA: 0x001DDEA1 File Offset: 0x001DC0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDeleteArchiveScRsp(RogueTournDeleteArchiveScRsp other) : this()
		{
			this.maxTimes_ = other.maxTimes_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1C3 RID: 45507 RVA: 0x001DDED2 File Offset: 0x001DC0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDeleteArchiveScRsp Clone()
		{
			return new RogueTournDeleteArchiveScRsp(this);
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600B1C4 RID: 45508 RVA: 0x001DDEDA File Offset: 0x001DC0DA
		// (set) Token: 0x0600B1C5 RID: 45509 RVA: 0x001DDEE2 File Offset: 0x001DC0E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxTimes
		{
			get
			{
				return this.maxTimes_;
			}
			set
			{
				this.maxTimes_ = value;
			}
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600B1C6 RID: 45510 RVA: 0x001DDEEB File Offset: 0x001DC0EB
		// (set) Token: 0x0600B1C7 RID: 45511 RVA: 0x001DDEF3 File Offset: 0x001DC0F3
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

		// Token: 0x0600B1C8 RID: 45512 RVA: 0x001DDEFC File Offset: 0x001DC0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournDeleteArchiveScRsp);
		}

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x001DDF0A File Offset: 0x001DC10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournDeleteArchiveScRsp other)
		{
			return other != null && (other == this || (this.MaxTimes == other.MaxTimes && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1CA RID: 45514 RVA: 0x001DDF48 File Offset: 0x001DC148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxTimes != 0U)
			{
				num ^= this.MaxTimes.GetHashCode();
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

		// Token: 0x0600B1CB RID: 45515 RVA: 0x001DDFA0 File Offset: 0x001DC1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B1CC RID: 45516 RVA: 0x001DDFA8 File Offset: 0x001DC1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1CD RID: 45517 RVA: 0x001DDFB4 File Offset: 0x001DC1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxTimes != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MaxTimes);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1CE RID: 45518 RVA: 0x001DE010 File Offset: 0x001DC210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxTimes);
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

		// Token: 0x0600B1CF RID: 45519 RVA: 0x001DE068 File Offset: 0x001DC268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournDeleteArchiveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxTimes != 0U)
			{
				this.MaxTimes = other.MaxTimes;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1D0 RID: 45520 RVA: 0x001DE0B8 File Offset: 0x001DC2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1D1 RID: 45521 RVA: 0x001DE0C4 File Offset: 0x001DC2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 56U)
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
					this.MaxTimes = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400484F RID: 18511
		private static readonly MessageParser<RogueTournDeleteArchiveScRsp> _parser = new MessageParser<RogueTournDeleteArchiveScRsp>(() => new RogueTournDeleteArchiveScRsp());

		// Token: 0x04004850 RID: 18512
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004851 RID: 18513
		public const int MaxTimesFieldNumber = 6;

		// Token: 0x04004852 RID: 18514
		private uint maxTimes_;

		// Token: 0x04004853 RID: 18515
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04004854 RID: 18516
		private uint retcode_;
	}
}
