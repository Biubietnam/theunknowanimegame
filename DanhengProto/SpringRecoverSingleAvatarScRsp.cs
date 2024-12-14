using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001183 RID: 4483
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpringRecoverSingleAvatarScRsp : IMessage<SpringRecoverSingleAvatarScRsp>, IMessage, IEquatable<SpringRecoverSingleAvatarScRsp>, IDeepCloneable<SpringRecoverSingleAvatarScRsp>, IBufferMessage
	{
		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0600C811 RID: 51217 RVA: 0x00218DA7 File Offset: 0x00216FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpringRecoverSingleAvatarScRsp> Parser
		{
			get
			{
				return SpringRecoverSingleAvatarScRsp._parser;
			}
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x0600C812 RID: 51218 RVA: 0x00218DAE File Offset: 0x00216FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpringRecoverSingleAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x0600C813 RID: 51219 RVA: 0x00218DC0 File Offset: 0x00216FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringRecoverSingleAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x0600C814 RID: 51220 RVA: 0x00218DC7 File Offset: 0x00216FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverSingleAvatarScRsp()
		{
		}

		// Token: 0x0600C815 RID: 51221 RVA: 0x00218DD0 File Offset: 0x00216FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverSingleAvatarScRsp(SpringRecoverSingleAvatarScRsp other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.id_ = other.id_;
			this.retcode_ = other.retcode_;
			this.hp_ = other.hp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C816 RID: 51222 RVA: 0x00218E24 File Offset: 0x00217024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverSingleAvatarScRsp Clone()
		{
			return new SpringRecoverSingleAvatarScRsp(this);
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0600C817 RID: 51223 RVA: 0x00218E2C File Offset: 0x0021702C
		// (set) Token: 0x0600C818 RID: 51224 RVA: 0x00218E34 File Offset: 0x00217034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0600C819 RID: 51225 RVA: 0x00218E3D File Offset: 0x0021703D
		// (set) Token: 0x0600C81A RID: 51226 RVA: 0x00218E45 File Offset: 0x00217045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0600C81B RID: 51227 RVA: 0x00218E4E File Offset: 0x0021704E
		// (set) Token: 0x0600C81C RID: 51228 RVA: 0x00218E56 File Offset: 0x00217056
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

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0600C81D RID: 51229 RVA: 0x00218E5F File Offset: 0x0021705F
		// (set) Token: 0x0600C81E RID: 51230 RVA: 0x00218E67 File Offset: 0x00217067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Hp
		{
			get
			{
				return this.hp_;
			}
			set
			{
				this.hp_ = value;
			}
		}

		// Token: 0x0600C81F RID: 51231 RVA: 0x00218E70 File Offset: 0x00217070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringRecoverSingleAvatarScRsp);
		}

		// Token: 0x0600C820 RID: 51232 RVA: 0x00218E80 File Offset: 0x00217080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringRecoverSingleAvatarScRsp other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.Id == other.Id && this.Retcode == other.Retcode && this.Hp == other.Hp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C821 RID: 51233 RVA: 0x00218EEC File Offset: 0x002170EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Hp != 0U)
			{
				num ^= this.Hp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C822 RID: 51234 RVA: 0x00218F7C File Offset: 0x0021717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C823 RID: 51235 RVA: 0x00218F84 File Offset: 0x00217184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C824 RID: 51236 RVA: 0x00218F90 File Offset: 0x00217190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Id);
			}
			if (this.Hp != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Hp);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C825 RID: 51237 RVA: 0x00219020 File Offset: 0x00217220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Hp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Hp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C826 RID: 51238 RVA: 0x002190A8 File Offset: 0x002172A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringRecoverSingleAvatarScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Hp != 0U)
			{
				this.Hp = other.Hp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C827 RID: 51239 RVA: 0x00219120 File Offset: 0x00217320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C828 RID: 51240 RVA: 0x0021912C File Offset: 0x0021732C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Hp = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040050C9 RID: 20681
		private static readonly MessageParser<SpringRecoverSingleAvatarScRsp> _parser = new MessageParser<SpringRecoverSingleAvatarScRsp>(() => new SpringRecoverSingleAvatarScRsp());

		// Token: 0x040050CA RID: 20682
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050CB RID: 20683
		public const int AvatarTypeFieldNumber = 10;

		// Token: 0x040050CC RID: 20684
		private AvatarType avatarType_;

		// Token: 0x040050CD RID: 20685
		public const int IdFieldNumber = 7;

		// Token: 0x040050CE RID: 20686
		private uint id_;

		// Token: 0x040050CF RID: 20687
		public const int RetcodeFieldNumber = 1;

		// Token: 0x040050D0 RID: 20688
		private uint retcode_;

		// Token: 0x040050D1 RID: 20689
		public const int HpFieldNumber = 9;

		// Token: 0x040050D2 RID: 20690
		private uint hp_;
	}
}
