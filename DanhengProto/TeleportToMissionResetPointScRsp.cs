using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001347 RID: 4935
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportToMissionResetPointScRsp : IMessage<TeleportToMissionResetPointScRsp>, IMessage, IEquatable<TeleportToMissionResetPointScRsp>, IDeepCloneable<TeleportToMissionResetPointScRsp>, IBufferMessage
	{
		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x0600DC39 RID: 56377 RVA: 0x0024A5F3 File Offset: 0x002487F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportToMissionResetPointScRsp> Parser
		{
			get
			{
				return TeleportToMissionResetPointScRsp._parser;
			}
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x0600DC3A RID: 56378 RVA: 0x0024A5FA File Offset: 0x002487FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TeleportToMissionResetPointScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x0600DC3B RID: 56379 RVA: 0x0024A60C File Offset: 0x0024880C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportToMissionResetPointScRsp.Descriptor;
			}
		}

		// Token: 0x0600DC3C RID: 56380 RVA: 0x0024A613 File Offset: 0x00248813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToMissionResetPointScRsp()
		{
		}

		// Token: 0x0600DC3D RID: 56381 RVA: 0x0024A61C File Offset: 0x0024881C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToMissionResetPointScRsp(TeleportToMissionResetPointScRsp other) : this()
		{
			this.clientPosVersion_ = other.clientPosVersion_;
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC3E RID: 56382 RVA: 0x0024A674 File Offset: 0x00248874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToMissionResetPointScRsp Clone()
		{
			return new TeleportToMissionResetPointScRsp(this);
		}

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x0600DC3F RID: 56383 RVA: 0x0024A67C File Offset: 0x0024887C
		// (set) Token: 0x0600DC40 RID: 56384 RVA: 0x0024A684 File Offset: 0x00248884
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

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x0600DC41 RID: 56385 RVA: 0x0024A68D File Offset: 0x0024888D
		// (set) Token: 0x0600DC42 RID: 56386 RVA: 0x0024A695 File Offset: 0x00248895
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

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x0600DC43 RID: 56387 RVA: 0x0024A69E File Offset: 0x0024889E
		// (set) Token: 0x0600DC44 RID: 56388 RVA: 0x0024A6A6 File Offset: 0x002488A6
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

		// Token: 0x0600DC45 RID: 56389 RVA: 0x0024A6AF File Offset: 0x002488AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportToMissionResetPointScRsp);
		}

		// Token: 0x0600DC46 RID: 56390 RVA: 0x0024A6C0 File Offset: 0x002488C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportToMissionResetPointScRsp other)
		{
			return other != null && (other == this || (this.ClientPosVersion == other.ClientPosVersion && object.Equals(this.Motion, other.Motion) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC47 RID: 56391 RVA: 0x0024A720 File Offset: 0x00248920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientPosVersion != 0U)
			{
				num ^= this.ClientPosVersion.GetHashCode();
			}
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
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

		// Token: 0x0600DC48 RID: 56392 RVA: 0x0024A78E File Offset: 0x0024898E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DC49 RID: 56393 RVA: 0x0024A796 File Offset: 0x00248996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC4A RID: 56394 RVA: 0x0024A7A0 File Offset: 0x002489A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientPosVersion != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ClientPosVersion);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.motion_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Motion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC4B RID: 56395 RVA: 0x0024A818 File Offset: 0x00248A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientPosVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClientPosVersion);
			}
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
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

		// Token: 0x0600DC4C RID: 56396 RVA: 0x0024A888 File Offset: 0x00248A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportToMissionResetPointScRsp other)
		{
			if (other == null)
			{
				return;
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
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC4D RID: 56397 RVA: 0x0024A904 File Offset: 0x00248B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC4E RID: 56398 RVA: 0x0024A910 File Offset: 0x00248B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 80U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.ClientPosVersion = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400579D RID: 22429
		private static readonly MessageParser<TeleportToMissionResetPointScRsp> _parser = new MessageParser<TeleportToMissionResetPointScRsp>(() => new TeleportToMissionResetPointScRsp());

		// Token: 0x0400579E RID: 22430
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400579F RID: 22431
		public const int ClientPosVersionFieldNumber = 5;

		// Token: 0x040057A0 RID: 22432
		private uint clientPosVersion_;

		// Token: 0x040057A1 RID: 22433
		public const int MotionFieldNumber = 14;

		// Token: 0x040057A2 RID: 22434
		private MotionInfo motion_;

		// Token: 0x040057A3 RID: 22435
		public const int RetcodeFieldNumber = 10;

		// Token: 0x040057A4 RID: 22436
		private uint retcode_;
	}
}
