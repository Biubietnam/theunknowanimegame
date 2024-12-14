using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011AD RID: 4525
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartFightFestCsReq : IMessage<StartFightFestCsReq>, IMessage, IEquatable<StartFightFestCsReq>, IDeepCloneable<StartFightFestCsReq>, IBufferMessage
	{
		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0600CA0F RID: 51727 RVA: 0x0021E16B File Offset: 0x0021C36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartFightFestCsReq> Parser
		{
			get
			{
				return StartFightFestCsReq._parser;
			}
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0600CA10 RID: 51728 RVA: 0x0021E172 File Offset: 0x0021C372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartFightFestCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0600CA11 RID: 51729 RVA: 0x0021E184 File Offset: 0x0021C384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartFightFestCsReq.Descriptor;
			}
		}

		// Token: 0x0600CA12 RID: 51730 RVA: 0x0021E18B File Offset: 0x0021C38B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFightFestCsReq()
		{
		}

		// Token: 0x0600CA13 RID: 51731 RVA: 0x0021E1AC File Offset: 0x0021C3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFightFestCsReq(StartFightFestCsReq other) : this()
		{
			this.type_ = other.type_;
			this.eventId_ = other.eventId_;
			this.jJIPJBEAJIH_ = other.jJIPJBEAJIH_.Clone();
			this.avatarList_ = other.avatarList_.Clone();
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA14 RID: 51732 RVA: 0x0021E216 File Offset: 0x0021C416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFightFestCsReq Clone()
		{
			return new StartFightFestCsReq(this);
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0600CA15 RID: 51733 RVA: 0x0021E21E File Offset: 0x0021C41E
		// (set) Token: 0x0600CA16 RID: 51734 RVA: 0x0021E226 File Offset: 0x0021C426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0600CA17 RID: 51735 RVA: 0x0021E22F File Offset: 0x0021C42F
		// (set) Token: 0x0600CA18 RID: 51736 RVA: 0x0021E237 File Offset: 0x0021C437
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

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0600CA19 RID: 51737 RVA: 0x0021E240 File Offset: 0x0021C440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> JJIPJBEAJIH
		{
			get
			{
				return this.jJIPJBEAJIH_;
			}
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0600CA1A RID: 51738 RVA: 0x0021E248 File Offset: 0x0021C448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BNBMFMMBIAO> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0600CA1B RID: 51739 RVA: 0x0021E250 File Offset: 0x0021C450
		// (set) Token: 0x0600CA1C RID: 51740 RVA: 0x0021E258 File Offset: 0x0021C458
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

		// Token: 0x0600CA1D RID: 51741 RVA: 0x0021E261 File Offset: 0x0021C461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartFightFestCsReq);
		}

		// Token: 0x0600CA1E RID: 51742 RVA: 0x0021E270 File Offset: 0x0021C470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartFightFestCsReq other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.EventId == other.EventId && this.jJIPJBEAJIH_.Equals(other.jJIPJBEAJIH_) && this.avatarList_.Equals(other.avatarList_) && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA1F RID: 51743 RVA: 0x0021E2F4 File Offset: 0x0021C4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != FightFestType.None)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			num ^= this.jJIPJBEAJIH_.GetHashCode();
			num ^= this.avatarList_.GetHashCode();
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA20 RID: 51744 RVA: 0x0021E387 File Offset: 0x0021C587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CA21 RID: 51745 RVA: 0x0021E38F File Offset: 0x0021C58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA22 RID: 51746 RVA: 0x0021E398 File Offset: 0x0021C598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Id);
			}
			this.avatarList_.WriteTo(ref output, StartFightFestCsReq._repeated_avatarList_codec);
			this.jJIPJBEAJIH_.WriteTo(ref output, StartFightFestCsReq._repeated_jJIPJBEAJIH_codec);
			if (this.EventId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.EventId);
			}
			if (this.Type != FightFestType.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA23 RID: 51747 RVA: 0x0021E430 File Offset: 0x0021C630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != FightFestType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			num += this.jJIPJBEAJIH_.CalculateSize(StartFightFestCsReq._repeated_jJIPJBEAJIH_codec);
			num += this.avatarList_.CalculateSize(StartFightFestCsReq._repeated_avatarList_codec);
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA24 RID: 51748 RVA: 0x0021E4C4 File Offset: 0x0021C6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartFightFestCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != FightFestType.None)
			{
				this.Type = other.Type;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this.jJIPJBEAJIH_.Add(other.jJIPJBEAJIH_);
			this.avatarList_.Add(other.avatarList_);
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA25 RID: 51749 RVA: 0x0021E54A File Offset: 0x0021C74A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA26 RID: 51750 RVA: 0x0021E554 File Offset: 0x0021C754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 96U)
				{
					if (num == 56U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						this.avatarList_.AddEntriesFrom(ref input, StartFightFestCsReq._repeated_avatarList_codec);
						continue;
					}
					if (num == 96U)
					{
						goto IL_5F;
					}
				}
				else
				{
					if (num == 98U)
					{
						goto IL_5F;
					}
					if (num == 104U)
					{
						this.EventId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Type = (FightFestType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_5F:
				this.jJIPJBEAJIH_.AddEntriesFrom(ref input, StartFightFestCsReq._repeated_jJIPJBEAJIH_codec);
			}
		}

		// Token: 0x04005181 RID: 20865
		private static readonly MessageParser<StartFightFestCsReq> _parser = new MessageParser<StartFightFestCsReq>(() => new StartFightFestCsReq());

		// Token: 0x04005182 RID: 20866
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005183 RID: 20867
		public const int TypeFieldNumber = 15;

		// Token: 0x04005184 RID: 20868
		private FightFestType type_;

		// Token: 0x04005185 RID: 20869
		public const int EventIdFieldNumber = 13;

		// Token: 0x04005186 RID: 20870
		private uint eventId_;

		// Token: 0x04005187 RID: 20871
		public const int JJIPJBEAJIHFieldNumber = 12;

		// Token: 0x04005188 RID: 20872
		private static readonly FieldCodec<uint> _repeated_jJIPJBEAJIH_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04005189 RID: 20873
		private readonly RepeatedField<uint> jJIPJBEAJIH_ = new RepeatedField<uint>();

		// Token: 0x0400518A RID: 20874
		public const int AvatarListFieldNumber = 11;

		// Token: 0x0400518B RID: 20875
		private static readonly FieldCodec<BNBMFMMBIAO> _repeated_avatarList_codec = FieldCodec.ForMessage<BNBMFMMBIAO>(90U, BNBMFMMBIAO.Parser);

		// Token: 0x0400518C RID: 20876
		private readonly RepeatedField<BNBMFMMBIAO> avatarList_ = new RepeatedField<BNBMFMMBIAO>();

		// Token: 0x0400518D RID: 20877
		public const int IdFieldNumber = 7;

		// Token: 0x0400518E RID: 20878
		private uint id_;
	}
}
