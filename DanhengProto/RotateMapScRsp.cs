using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001041 RID: 4161
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RotateMapScRsp : IMessage<RotateMapScRsp>, IMessage, IEquatable<RotateMapScRsp>, IDeepCloneable<RotateMapScRsp>, IBufferMessage
	{
		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600B918 RID: 47384 RVA: 0x001F0F75 File Offset: 0x001EF175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RotateMapScRsp> Parser
		{
			get
			{
				return RotateMapScRsp._parser;
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600B919 RID: 47385 RVA: 0x001F0F7C File Offset: 0x001EF17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RotateMapScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600B91A RID: 47386 RVA: 0x001F0F8E File Offset: 0x001EF18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RotateMapScRsp.Descriptor;
			}
		}

		// Token: 0x0600B91B RID: 47387 RVA: 0x001F0F95 File Offset: 0x001EF195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotateMapScRsp()
		{
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x001F0FA0 File Offset: 0x001EF1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotateMapScRsp(RotateMapScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.clientPosVersion_ = other.clientPosVersion_;
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x001F0FF8 File Offset: 0x001EF1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotateMapScRsp Clone()
		{
			return new RotateMapScRsp(this);
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600B91E RID: 47390 RVA: 0x001F1000 File Offset: 0x001EF200
		// (set) Token: 0x0600B91F RID: 47391 RVA: 0x001F1008 File Offset: 0x001EF208
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

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600B920 RID: 47392 RVA: 0x001F1011 File Offset: 0x001EF211
		// (set) Token: 0x0600B921 RID: 47393 RVA: 0x001F1019 File Offset: 0x001EF219
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

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600B922 RID: 47394 RVA: 0x001F1022 File Offset: 0x001EF222
		// (set) Token: 0x0600B923 RID: 47395 RVA: 0x001F102A File Offset: 0x001EF22A
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

		// Token: 0x0600B924 RID: 47396 RVA: 0x001F1033 File Offset: 0x001EF233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RotateMapScRsp);
		}

		// Token: 0x0600B925 RID: 47397 RVA: 0x001F1044 File Offset: 0x001EF244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RotateMapScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.ClientPosVersion == other.ClientPosVersion && object.Equals(this.Motion, other.Motion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B926 RID: 47398 RVA: 0x001F10A4 File Offset: 0x001EF2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ClientPosVersion != 0U)
			{
				num ^= this.ClientPosVersion.GetHashCode();
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

		// Token: 0x0600B927 RID: 47399 RVA: 0x001F1112 File Offset: 0x001EF312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x001F111A File Offset: 0x001EF31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B929 RID: 47401 RVA: 0x001F1124 File Offset: 0x001EF324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motion_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Motion);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ClientPosVersion != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ClientPosVersion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B92A RID: 47402 RVA: 0x001F119C File Offset: 0x001EF39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ClientPosVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClientPosVersion);
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

		// Token: 0x0600B92B RID: 47403 RVA: 0x001F120C File Offset: 0x001EF40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RotateMapScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ClientPosVersion != 0U)
			{
				this.ClientPosVersion = other.ClientPosVersion;
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

		// Token: 0x0600B92C RID: 47404 RVA: 0x001F1288 File Offset: 0x001EF488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B92D RID: 47405 RVA: 0x001F1294 File Offset: 0x001EF494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 64U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ClientPosVersion = input.ReadUInt32();
						}
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
		}

		// Token: 0x04004AFB RID: 19195
		private static readonly MessageParser<RotateMapScRsp> _parser = new MessageParser<RotateMapScRsp>(() => new RotateMapScRsp());

		// Token: 0x04004AFC RID: 19196
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AFD RID: 19197
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004AFE RID: 19198
		private uint retcode_;

		// Token: 0x04004AFF RID: 19199
		public const int ClientPosVersionFieldNumber = 14;

		// Token: 0x04004B00 RID: 19200
		private uint clientPosVersion_;

		// Token: 0x04004B01 RID: 19201
		public const int MotionFieldNumber = 5;

		// Token: 0x04004B02 RID: 19202
		private MotionInfo motion_;
	}
}
