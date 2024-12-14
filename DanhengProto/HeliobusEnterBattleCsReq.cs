using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008BB RID: 2235
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusEnterBattleCsReq : IMessage<HeliobusEnterBattleCsReq>, IMessage, IEquatable<HeliobusEnterBattleCsReq>, IDeepCloneable<HeliobusEnterBattleCsReq>, IBufferMessage
	{
		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x060063A1 RID: 25505 RVA: 0x0010AE89 File Offset: 0x00109089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusEnterBattleCsReq> Parser
		{
			get
			{
				return HeliobusEnterBattleCsReq._parser;
			}
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x060063A2 RID: 25506 RVA: 0x0010AE90 File Offset: 0x00109090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusEnterBattleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x060063A3 RID: 25507 RVA: 0x0010AEA2 File Offset: 0x001090A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusEnterBattleCsReq.Descriptor;
			}
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x0010AEA9 File Offset: 0x001090A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusEnterBattleCsReq()
		{
		}

		// Token: 0x060063A5 RID: 25509 RVA: 0x0010AEBC File Offset: 0x001090BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusEnterBattleCsReq(HeliobusEnterBattleCsReq other) : this()
		{
			this.skillId_ = other.skillId_;
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x0010AF09 File Offset: 0x00109109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusEnterBattleCsReq Clone()
		{
			return new HeliobusEnterBattleCsReq(this);
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x060063A7 RID: 25511 RVA: 0x0010AF11 File Offset: 0x00109111
		// (set) Token: 0x060063A8 RID: 25512 RVA: 0x0010AF19 File Offset: 0x00109119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x060063A9 RID: 25513 RVA: 0x0010AF22 File Offset: 0x00109122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x060063AA RID: 25514 RVA: 0x0010AF2A File Offset: 0x0010912A
		// (set) Token: 0x060063AB RID: 25515 RVA: 0x0010AF32 File Offset: 0x00109132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x0010AF3B File Offset: 0x0010913B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusEnterBattleCsReq);
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x0010AF4C File Offset: 0x0010914C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusEnterBattleCsReq other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.avatarIdList_.Equals(other.avatarIdList_) && this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063AE RID: 25518 RVA: 0x0010AFAC File Offset: 0x001091AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
			}
			num ^= this.avatarIdList_.GetHashCode();
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x0010B012 File Offset: 0x00109212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x0010B01A File Offset: 0x0010921A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x0010B024 File Offset: 0x00109224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.SkillId);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.EventId);
			}
			this.avatarIdList_.WriteTo(ref output, HeliobusEnterBattleCsReq._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x0010B090 File Offset: 0x00109290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
			}
			num += this.avatarIdList_.CalculateSize(HeliobusEnterBattleCsReq._repeated_avatarIdList_codec);
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x0010B0FC File Offset: 0x001092FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusEnterBattleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x0010B15D File Offset: 0x0010935D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x0010B168 File Offset: 0x00109368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.SkillId = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.EventId = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.avatarIdList_.AddEntriesFrom(ref input, HeliobusEnterBattleCsReq._repeated_avatarIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400266A RID: 9834
		private static readonly MessageParser<HeliobusEnterBattleCsReq> _parser = new MessageParser<HeliobusEnterBattleCsReq>(() => new HeliobusEnterBattleCsReq());

		// Token: 0x0400266B RID: 9835
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400266C RID: 9836
		public const int SkillIdFieldNumber = 2;

		// Token: 0x0400266D RID: 9837
		private uint skillId_;

		// Token: 0x0400266E RID: 9838
		public const int AvatarIdListFieldNumber = 14;

		// Token: 0x0400266F RID: 9839
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04002670 RID: 9840
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04002671 RID: 9841
		public const int EventIdFieldNumber = 8;

		// Token: 0x04002672 RID: 9842
		private uint eventId_;
	}
}
