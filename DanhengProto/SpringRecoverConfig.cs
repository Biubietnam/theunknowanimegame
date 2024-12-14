using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200117B RID: 4475
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpringRecoverConfig : IMessage<SpringRecoverConfig>, IMessage, IEquatable<SpringRecoverConfig>, IDeepCloneable<SpringRecoverConfig>, IBufferMessage
	{
		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600C7AA RID: 51114 RVA: 0x00217BD7 File Offset: 0x00215DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpringRecoverConfig> Parser
		{
			get
			{
				return SpringRecoverConfig._parser;
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600C7AB RID: 51115 RVA: 0x00217BDE File Offset: 0x00215DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpringRecoverConfigReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600C7AC RID: 51116 RVA: 0x00217BF0 File Offset: 0x00215DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringRecoverConfig.Descriptor;
			}
		}

		// Token: 0x0600C7AD RID: 51117 RVA: 0x00217BF7 File Offset: 0x00215DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverConfig()
		{
		}

		// Token: 0x0600C7AE RID: 51118 RVA: 0x00217C0C File Offset: 0x00215E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverConfig(SpringRecoverConfig other) : this()
		{
			this.defaultHp_ = other.defaultHp_;
			this.autoRecoverHp_ = other.autoRecoverHp_;
			this.avatarPresetHpList_ = other.avatarPresetHpList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7AF RID: 51119 RVA: 0x00217C59 File Offset: 0x00215E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverConfig Clone()
		{
			return new SpringRecoverConfig(this);
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600C7B0 RID: 51120 RVA: 0x00217C61 File Offset: 0x00215E61
		// (set) Token: 0x0600C7B1 RID: 51121 RVA: 0x00217C69 File Offset: 0x00215E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DefaultHp
		{
			get
			{
				return this.defaultHp_;
			}
			set
			{
				this.defaultHp_ = value;
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600C7B2 RID: 51122 RVA: 0x00217C72 File Offset: 0x00215E72
		// (set) Token: 0x0600C7B3 RID: 51123 RVA: 0x00217C7A File Offset: 0x00215E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AutoRecoverHp
		{
			get
			{
				return this.autoRecoverHp_;
			}
			set
			{
				this.autoRecoverHp_ = value;
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600C7B4 RID: 51124 RVA: 0x00217C83 File Offset: 0x00215E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AvatarPresetHp> AvatarPresetHpList
		{
			get
			{
				return this.avatarPresetHpList_;
			}
		}

		// Token: 0x0600C7B5 RID: 51125 RVA: 0x00217C8B File Offset: 0x00215E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringRecoverConfig);
		}

		// Token: 0x0600C7B6 RID: 51126 RVA: 0x00217C9C File Offset: 0x00215E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringRecoverConfig other)
		{
			return other != null && (other == this || (this.DefaultHp == other.DefaultHp && this.AutoRecoverHp == other.AutoRecoverHp && this.avatarPresetHpList_.Equals(other.avatarPresetHpList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7B7 RID: 51127 RVA: 0x00217CFC File Offset: 0x00215EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DefaultHp != 0U)
			{
				num ^= this.DefaultHp.GetHashCode();
			}
			if (this.AutoRecoverHp)
			{
				num ^= this.AutoRecoverHp.GetHashCode();
			}
			num ^= this.avatarPresetHpList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C7B8 RID: 51128 RVA: 0x00217D62 File Offset: 0x00215F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C7B9 RID: 51129 RVA: 0x00217D6A File Offset: 0x00215F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7BA RID: 51130 RVA: 0x00217D74 File Offset: 0x00215F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarPresetHpList_.WriteTo(ref output, SpringRecoverConfig._repeated_avatarPresetHpList_codec);
			if (this.AutoRecoverHp)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.AutoRecoverHp);
			}
			if (this.DefaultHp != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.DefaultHp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7BB RID: 51131 RVA: 0x00217DE0 File Offset: 0x00215FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DefaultHp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DefaultHp);
			}
			if (this.AutoRecoverHp)
			{
				num += 2;
			}
			num += this.avatarPresetHpList_.CalculateSize(SpringRecoverConfig._repeated_avatarPresetHpList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7BC RID: 51132 RVA: 0x00217E40 File Offset: 0x00216040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringRecoverConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DefaultHp != 0U)
			{
				this.DefaultHp = other.DefaultHp;
			}
			if (other.AutoRecoverHp)
			{
				this.AutoRecoverHp = other.AutoRecoverHp;
			}
			this.avatarPresetHpList_.Add(other.avatarPresetHpList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7BD RID: 51133 RVA: 0x00217EA1 File Offset: 0x002160A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7BE RID: 51134 RVA: 0x00217EAC File Offset: 0x002160AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 64U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DefaultHp = input.ReadUInt32();
						}
					}
					else
					{
						this.AutoRecoverHp = input.ReadBool();
					}
				}
				else
				{
					this.avatarPresetHpList_.AddEntriesFrom(ref input, SpringRecoverConfig._repeated_avatarPresetHpList_codec);
				}
			}
		}

		// Token: 0x040050A0 RID: 20640
		private static readonly MessageParser<SpringRecoverConfig> _parser = new MessageParser<SpringRecoverConfig>(() => new SpringRecoverConfig());

		// Token: 0x040050A1 RID: 20641
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050A2 RID: 20642
		public const int DefaultHpFieldNumber = 10;

		// Token: 0x040050A3 RID: 20643
		private uint defaultHp_;

		// Token: 0x040050A4 RID: 20644
		public const int AutoRecoverHpFieldNumber = 8;

		// Token: 0x040050A5 RID: 20645
		private bool autoRecoverHp_;

		// Token: 0x040050A6 RID: 20646
		public const int AvatarPresetHpListFieldNumber = 3;

		// Token: 0x040050A7 RID: 20647
		private static readonly FieldCodec<AvatarPresetHp> _repeated_avatarPresetHpList_codec = FieldCodec.ForMessage<AvatarPresetHp>(26U, AvatarPresetHp.Parser);

		// Token: 0x040050A8 RID: 20648
		private readonly RepeatedField<AvatarPresetHp> avatarPresetHpList_ = new RepeatedField<AvatarPresetHp>();
	}
}
