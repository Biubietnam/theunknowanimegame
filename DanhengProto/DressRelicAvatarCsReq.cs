using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003D9 RID: 985
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DressRelicAvatarCsReq : IMessage<DressRelicAvatarCsReq>, IMessage, IEquatable<DressRelicAvatarCsReq>, IDeepCloneable<DressRelicAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x00079DF5 File Offset: 0x00077FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DressRelicAvatarCsReq> Parser
		{
			get
			{
				return DressRelicAvatarCsReq._parser;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x00079DFC File Offset: 0x00077FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DressRelicAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x00079E0E File Offset: 0x0007800E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DressRelicAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x00079E15 File Offset: 0x00078015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressRelicAvatarCsReq()
		{
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00079E28 File Offset: 0x00078028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressRelicAvatarCsReq(DressRelicAvatarCsReq other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.switchList_ = other.switchList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00079E5E File Offset: 0x0007805E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressRelicAvatarCsReq Clone()
		{
			return new DressRelicAvatarCsReq(this);
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002BDD RID: 11229 RVA: 0x00079E66 File Offset: 0x00078066
		// (set) Token: 0x06002BDE RID: 11230 RVA: 0x00079E6E File Offset: 0x0007806E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x00079E77 File Offset: 0x00078077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DressRelicParam> SwitchList
		{
			get
			{
				return this.switchList_;
			}
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00079E7F File Offset: 0x0007807F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DressRelicAvatarCsReq);
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x00079E90 File Offset: 0x00078090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DressRelicAvatarCsReq other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.switchList_.Equals(other.switchList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x00079EE0 File Offset: 0x000780E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			num ^= this.switchList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00079F2D File Offset: 0x0007812D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00079F35 File Offset: 0x00078135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00079F40 File Offset: 0x00078140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.switchList_.WriteTo(ref output, DressRelicAvatarCsReq._repeated_switchList_codec);
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x00079F90 File Offset: 0x00078190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			num += this.switchList_.CalculateSize(DressRelicAvatarCsReq._repeated_switchList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x00079FE4 File Offset: 0x000781E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DressRelicAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this.switchList_.Add(other.switchList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x0007A031 File Offset: 0x00078231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0007A03C File Offset: 0x0007823C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvatarId = input.ReadUInt32();
					}
				}
				else
				{
					this.switchList_.AddEntriesFrom(ref input, DressRelicAvatarCsReq._repeated_switchList_codec);
				}
			}
		}

		// Token: 0x040011BD RID: 4541
		private static readonly MessageParser<DressRelicAvatarCsReq> _parser = new MessageParser<DressRelicAvatarCsReq>(() => new DressRelicAvatarCsReq());

		// Token: 0x040011BE RID: 4542
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011BF RID: 4543
		public const int AvatarIdFieldNumber = 13;

		// Token: 0x040011C0 RID: 4544
		private uint avatarId_;

		// Token: 0x040011C1 RID: 4545
		public const int SwitchListFieldNumber = 2;

		// Token: 0x040011C2 RID: 4546
		private static readonly FieldCodec<DressRelicParam> _repeated_switchList_codec = FieldCodec.ForMessage<DressRelicParam>(18U, DressRelicParam.Parser);

		// Token: 0x040011C3 RID: 4547
		private readonly RepeatedField<DressRelicParam> switchList_ = new RepeatedField<DressRelicParam>();
	}
}
