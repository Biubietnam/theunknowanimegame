using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DCB RID: 3531
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ResetMapRotationRegionScRsp : IMessage<ResetMapRotationRegionScRsp>, IMessage, IEquatable<ResetMapRotationRegionScRsp>, IDeepCloneable<ResetMapRotationRegionScRsp>, IBufferMessage
	{
		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x06009DE0 RID: 40416 RVA: 0x001A4943 File Offset: 0x001A2B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ResetMapRotationRegionScRsp> Parser
		{
			get
			{
				return ResetMapRotationRegionScRsp._parser;
			}
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x06009DE1 RID: 40417 RVA: 0x001A494A File Offset: 0x001A2B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ResetMapRotationRegionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x06009DE2 RID: 40418 RVA: 0x001A495C File Offset: 0x001A2B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetMapRotationRegionScRsp.Descriptor;
			}
		}

		// Token: 0x06009DE3 RID: 40419 RVA: 0x001A4963 File Offset: 0x001A2B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetMapRotationRegionScRsp()
		{
		}

		// Token: 0x06009DE4 RID: 40420 RVA: 0x001A496C File Offset: 0x001A2B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetMapRotationRegionScRsp(ResetMapRotationRegionScRsp other) : this()
		{
			this.clientPosVersion_ = other.clientPosVersion_;
			this.retcode_ = other.retcode_;
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DE5 RID: 40421 RVA: 0x001A49C4 File Offset: 0x001A2BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetMapRotationRegionScRsp Clone()
		{
			return new ResetMapRotationRegionScRsp(this);
		}

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x06009DE6 RID: 40422 RVA: 0x001A49CC File Offset: 0x001A2BCC
		// (set) Token: 0x06009DE7 RID: 40423 RVA: 0x001A49D4 File Offset: 0x001A2BD4
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

		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x06009DE8 RID: 40424 RVA: 0x001A49DD File Offset: 0x001A2BDD
		// (set) Token: 0x06009DE9 RID: 40425 RVA: 0x001A49E5 File Offset: 0x001A2BE5
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

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x06009DEA RID: 40426 RVA: 0x001A49EE File Offset: 0x001A2BEE
		// (set) Token: 0x06009DEB RID: 40427 RVA: 0x001A49F6 File Offset: 0x001A2BF6
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

		// Token: 0x06009DEC RID: 40428 RVA: 0x001A49FF File Offset: 0x001A2BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetMapRotationRegionScRsp);
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x001A4A10 File Offset: 0x001A2C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetMapRotationRegionScRsp other)
		{
			return other != null && (other == this || (this.ClientPosVersion == other.ClientPosVersion && this.Retcode == other.Retcode && object.Equals(this.Motion, other.Motion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x001A4A70 File Offset: 0x001A2C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientPosVersion != 0U)
			{
				num ^= this.ClientPosVersion.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x001A4ADE File Offset: 0x001A2CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x001A4AE6 File Offset: 0x001A2CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x001A4AF0 File Offset: 0x001A2CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientPosVersion != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ClientPosVersion);
			}
			if (this.motion_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Motion);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DF2 RID: 40434 RVA: 0x001A4B68 File Offset: 0x001A2D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientPosVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClientPosVersion);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x001A4BD8 File Offset: 0x001A2DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetMapRotationRegionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClientPosVersion != 0U)
			{
				this.ClientPosVersion = other.ClientPosVersion;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x001A4C54 File Offset: 0x001A2E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DF5 RID: 40437 RVA: 0x001A4C60 File Offset: 0x001A2E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 50U)
					{
						if (num != 80U)
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
						if (this.motion_ == null)
						{
							this.Motion = new MotionInfo();
						}
						input.ReadMessage(this.Motion);
					}
				}
				else
				{
					this.ClientPosVersion = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003D60 RID: 15712
		private static readonly MessageParser<ResetMapRotationRegionScRsp> _parser = new MessageParser<ResetMapRotationRegionScRsp>(() => new ResetMapRotationRegionScRsp());

		// Token: 0x04003D61 RID: 15713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D62 RID: 15714
		public const int ClientPosVersionFieldNumber = 5;

		// Token: 0x04003D63 RID: 15715
		private uint clientPosVersion_;

		// Token: 0x04003D64 RID: 15716
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04003D65 RID: 15717
		private uint retcode_;

		// Token: 0x04003D66 RID: 15718
		public const int MotionFieldNumber = 6;

		// Token: 0x04003D67 RID: 15719
		private MotionInfo motion_;
	}
}
