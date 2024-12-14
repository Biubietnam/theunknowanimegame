using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009F9 RID: 2553
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveMapRotationRegionScRsp : IMessage<LeaveMapRotationRegionScRsp>, IMessage, IEquatable<LeaveMapRotationRegionScRsp>, IDeepCloneable<LeaveMapRotationRegionScRsp>, IBufferMessage
	{
		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x0600714C RID: 29004 RVA: 0x0012D9C3 File Offset: 0x0012BBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveMapRotationRegionScRsp> Parser
		{
			get
			{
				return LeaveMapRotationRegionScRsp._parser;
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x0600714D RID: 29005 RVA: 0x0012D9CA File Offset: 0x0012BBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveMapRotationRegionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x0600714E RID: 29006 RVA: 0x0012D9DC File Offset: 0x0012BBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveMapRotationRegionScRsp.Descriptor;
			}
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x0012D9E3 File Offset: 0x0012BBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMapRotationRegionScRsp()
		{
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x0012D9EC File Offset: 0x0012BBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMapRotationRegionScRsp(LeaveMapRotationRegionScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.clientPosVersion_ = other.clientPosVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x0012DA44 File Offset: 0x0012BC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMapRotationRegionScRsp Clone()
		{
			return new LeaveMapRotationRegionScRsp(this);
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06007152 RID: 29010 RVA: 0x0012DA4C File Offset: 0x0012BC4C
		// (set) Token: 0x06007153 RID: 29011 RVA: 0x0012DA54 File Offset: 0x0012BC54
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

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06007154 RID: 29012 RVA: 0x0012DA5D File Offset: 0x0012BC5D
		// (set) Token: 0x06007155 RID: 29013 RVA: 0x0012DA65 File Offset: 0x0012BC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06007156 RID: 29014 RVA: 0x0012DA6E File Offset: 0x0012BC6E
		// (set) Token: 0x06007157 RID: 29015 RVA: 0x0012DA76 File Offset: 0x0012BC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ClientPosVersion
		{
			get
			{
				return this.clientPosVersion_;
			}
			set
			{
				this.clientPosVersion_ = value;
			}
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x0012DA7F File Offset: 0x0012BC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveMapRotationRegionScRsp);
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x0012DA90 File Offset: 0x0012BC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveMapRotationRegionScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Motion, other.Motion) && this.ClientPosVersion == other.ClientPosVersion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x0012DAF0 File Offset: 0x0012BCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.ClientPosVersion != 0U)
			{
				num ^= this.ClientPosVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x0012DB5E File Offset: 0x0012BD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x0012DB66 File Offset: 0x0012BD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x0012DB70 File Offset: 0x0012BD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motion_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Motion);
			}
			if (this.ClientPosVersion != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ClientPosVersion);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x0012DBE8 File Offset: 0x0012BDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this.ClientPosVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClientPosVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x0012DC58 File Offset: 0x0012BE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveMapRotationRegionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			if (other.ClientPosVersion != 0U)
			{
				this.ClientPosVersion = other.ClientPosVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x0012DCD4 File Offset: 0x0012BED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x0012DCE0 File Offset: 0x0012BEE0
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
						if (num != 64U)
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
						this.ClientPosVersion = input.ReadUInt32();
					}
				}
				else
				{
					if (this.motion_ == null)
					{
						this.Motion = new MotionInfo();
					}
					input.ReadMessage(this.Motion);
				}
			}
		}

		// Token: 0x04002B97 RID: 11159
		private static readonly MessageParser<LeaveMapRotationRegionScRsp> _parser = new MessageParser<LeaveMapRotationRegionScRsp>(() => new LeaveMapRotationRegionScRsp());

		// Token: 0x04002B98 RID: 11160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B99 RID: 11161
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04002B9A RID: 11162
		private uint retcode_;

		// Token: 0x04002B9B RID: 11163
		public const int MotionFieldNumber = 3;

		// Token: 0x04002B9C RID: 11164
		private MotionInfo motion_;

		// Token: 0x04002B9D RID: 11165
		public const int ClientPosVersionFieldNumber = 7;

		// Token: 0x04002B9E RID: 11166
		private uint clientPosVersion_;
	}
}
