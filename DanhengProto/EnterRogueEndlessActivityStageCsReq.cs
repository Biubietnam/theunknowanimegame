using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000455 RID: 1109
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterRogueEndlessActivityStageCsReq : IMessage<EnterRogueEndlessActivityStageCsReq>, IMessage, IEquatable<EnterRogueEndlessActivityStageCsReq>, IDeepCloneable<EnterRogueEndlessActivityStageCsReq>, IBufferMessage
	{
		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x0600315A RID: 12634 RVA: 0x00087B33 File Offset: 0x00085D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterRogueEndlessActivityStageCsReq> Parser
		{
			get
			{
				return EnterRogueEndlessActivityStageCsReq._parser;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x0600315B RID: 12635 RVA: 0x00087B3A File Offset: 0x00085D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterRogueEndlessActivityStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x00087B4C File Offset: 0x00085D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterRogueEndlessActivityStageCsReq.Descriptor;
			}
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x00087B53 File Offset: 0x00085D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueEndlessActivityStageCsReq()
		{
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x00087B66 File Offset: 0x00085D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueEndlessActivityStageCsReq(EnterRogueEndlessActivityStageCsReq other) : this()
		{
			this.gKCAKEDDEPN_ = other.gKCAKEDDEPN_;
			this.avatarList_ = other.avatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x00087B9C File Offset: 0x00085D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterRogueEndlessActivityStageCsReq Clone()
		{
			return new EnterRogueEndlessActivityStageCsReq(this);
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x00087BA4 File Offset: 0x00085DA4
		// (set) Token: 0x06003161 RID: 12641 RVA: 0x00087BAC File Offset: 0x00085DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GKCAKEDDEPN
		{
			get
			{
				return this.gKCAKEDDEPN_;
			}
			set
			{
				this.gKCAKEDDEPN_ = value;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x00087BB5 File Offset: 0x00085DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueEndlessAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x00087BBD File Offset: 0x00085DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterRogueEndlessActivityStageCsReq);
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x00087BCC File Offset: 0x00085DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterRogueEndlessActivityStageCsReq other)
		{
			return other != null && (other == this || (this.GKCAKEDDEPN == other.GKCAKEDDEPN && this.avatarList_.Equals(other.avatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x00087C1C File Offset: 0x00085E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GKCAKEDDEPN != 0U)
			{
				num ^= this.GKCAKEDDEPN.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x00087C69 File Offset: 0x00085E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x00087C71 File Offset: 0x00085E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x00087C7C File Offset: 0x00085E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GKCAKEDDEPN != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GKCAKEDDEPN);
			}
			this.avatarList_.WriteTo(ref output, EnterRogueEndlessActivityStageCsReq._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x00087CCC File Offset: 0x00085ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GKCAKEDDEPN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKCAKEDDEPN);
			}
			num += this.avatarList_.CalculateSize(EnterRogueEndlessActivityStageCsReq._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x00087D20 File Offset: 0x00085F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterRogueEndlessActivityStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GKCAKEDDEPN != 0U)
			{
				this.GKCAKEDDEPN = other.GKCAKEDDEPN;
			}
			this.avatarList_.Add(other.avatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x00087D6D File Offset: 0x00085F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x00087D78 File Offset: 0x00085F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.avatarList_.AddEntriesFrom(ref input, EnterRogueEndlessActivityStageCsReq._repeated_avatarList_codec);
					}
				}
				else
				{
					this.GKCAKEDDEPN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040013A7 RID: 5031
		private static readonly MessageParser<EnterRogueEndlessActivityStageCsReq> _parser = new MessageParser<EnterRogueEndlessActivityStageCsReq>(() => new EnterRogueEndlessActivityStageCsReq());

		// Token: 0x040013A8 RID: 5032
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013A9 RID: 5033
		public const int GKCAKEDDEPNFieldNumber = 5;

		// Token: 0x040013AA RID: 5034
		private uint gKCAKEDDEPN_;

		// Token: 0x040013AB RID: 5035
		public const int AvatarListFieldNumber = 9;

		// Token: 0x040013AC RID: 5036
		private static readonly FieldCodec<RogueEndlessAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<RogueEndlessAvatar>(74U, RogueEndlessAvatar.Parser);

		// Token: 0x040013AD RID: 5037
		private readonly RepeatedField<RogueEndlessAvatar> avatarList_ = new RepeatedField<RogueEndlessAvatar>();
	}
}
