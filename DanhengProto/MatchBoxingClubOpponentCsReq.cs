using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A97 RID: 2711
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchBoxingClubOpponentCsReq : IMessage<MatchBoxingClubOpponentCsReq>, IMessage, IEquatable<MatchBoxingClubOpponentCsReq>, IDeepCloneable<MatchBoxingClubOpponentCsReq>, IBufferMessage
	{
		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x06007820 RID: 30752 RVA: 0x0013E77B File Offset: 0x0013C97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchBoxingClubOpponentCsReq> Parser
		{
			get
			{
				return MatchBoxingClubOpponentCsReq._parser;
			}
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x06007821 RID: 30753 RVA: 0x0013E782 File Offset: 0x0013C982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MatchBoxingClubOpponentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x06007822 RID: 30754 RVA: 0x0013E794 File Offset: 0x0013C994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchBoxingClubOpponentCsReq.Descriptor;
			}
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x0013E79B File Offset: 0x0013C99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchBoxingClubOpponentCsReq()
		{
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x0013E7BC File Offset: 0x0013C9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchBoxingClubOpponentCsReq(MatchBoxingClubOpponentCsReq other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.avatarList_ = other.avatarList_.Clone();
			this.hHMFMFHCMOK_ = other.hHMFMFHCMOK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x0013E80E File Offset: 0x0013CA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchBoxingClubOpponentCsReq Clone()
		{
			return new MatchBoxingClubOpponentCsReq(this);
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x06007826 RID: 30758 RVA: 0x0013E816 File Offset: 0x0013CA16
		// (set) Token: 0x06007827 RID: 30759 RVA: 0x0013E81E File Offset: 0x0013CA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x06007828 RID: 30760 RVA: 0x0013E827 File Offset: 0x0013CA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x06007829 RID: 30761 RVA: 0x0013E82F File Offset: 0x0013CA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BFJBLOCEHJG> HHMFMFHCMOK
		{
			get
			{
				return this.hHMFMFHCMOK_;
			}
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x0013E837 File Offset: 0x0013CA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchBoxingClubOpponentCsReq);
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x0013E848 File Offset: 0x0013CA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchBoxingClubOpponentCsReq other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.avatarList_.Equals(other.avatarList_) && this.hHMFMFHCMOK_.Equals(other.hHMFMFHCMOK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x0013E8AC File Offset: 0x0013CAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			num ^= this.hHMFMFHCMOK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x0013E907 File Offset: 0x0013CB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600782E RID: 30766 RVA: 0x0013E90F File Offset: 0x0013CB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x0013E918 File Offset: 0x0013CB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarList_.WriteTo(ref output, MatchBoxingClubOpponentCsReq._repeated_avatarList_codec);
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ChallengeId);
			}
			this.hHMFMFHCMOK_.WriteTo(ref output, MatchBoxingClubOpponentCsReq._repeated_hHMFMFHCMOK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x0013E978 File Offset: 0x0013CB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			num += this.avatarList_.CalculateSize(MatchBoxingClubOpponentCsReq._repeated_avatarList_codec);
			num += this.hHMFMFHCMOK_.CalculateSize(MatchBoxingClubOpponentCsReq._repeated_hHMFMFHCMOK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x0013E9DC File Offset: 0x0013CBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchBoxingClubOpponentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this.avatarList_.Add(other.avatarList_);
			this.hHMFMFHCMOK_.Add(other.hHMFMFHCMOK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007832 RID: 30770 RVA: 0x0013EA3A File Offset: 0x0013CC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x0013EA44 File Offset: 0x0013CC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.avatarList_.AddEntriesFrom(ref input, MatchBoxingClubOpponentCsReq._repeated_avatarList_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ChallengeId = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						this.hHMFMFHCMOK_.AddEntriesFrom(ref input, MatchBoxingClubOpponentCsReq._repeated_hHMFMFHCMOK_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E21 RID: 11809
		private static readonly MessageParser<MatchBoxingClubOpponentCsReq> _parser = new MessageParser<MatchBoxingClubOpponentCsReq>(() => new MatchBoxingClubOpponentCsReq());

		// Token: 0x04002E22 RID: 11810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E23 RID: 11811
		public const int ChallengeIdFieldNumber = 3;

		// Token: 0x04002E24 RID: 11812
		private uint challengeId_;

		// Token: 0x04002E25 RID: 11813
		public const int AvatarListFieldNumber = 1;

		// Token: 0x04002E26 RID: 11814
		private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04002E27 RID: 11815
		private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

		// Token: 0x04002E28 RID: 11816
		public const int HHMFMFHCMOKFieldNumber = 4;

		// Token: 0x04002E29 RID: 11817
		private static readonly FieldCodec<BFJBLOCEHJG> _repeated_hHMFMFHCMOK_codec = FieldCodec.ForMessage<BFJBLOCEHJG>(34U, BFJBLOCEHJG.Parser);

		// Token: 0x04002E2A RID: 11818
		private readonly RepeatedField<BFJBLOCEHJG> hHMFMFHCMOK_ = new RepeatedField<BFJBLOCEHJG>();
	}
}
