using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011A3 RID: 4515
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartBoxingClubBattleScRsp : IMessage<StartBoxingClubBattleScRsp>, IMessage, IEquatable<StartBoxingClubBattleScRsp>, IDeepCloneable<StartBoxingClubBattleScRsp>, IBufferMessage
	{
		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x0600C989 RID: 51593 RVA: 0x0021C6FB File Offset: 0x0021A8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartBoxingClubBattleScRsp> Parser
		{
			get
			{
				return StartBoxingClubBattleScRsp._parser;
			}
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0600C98A RID: 51594 RVA: 0x0021C702 File Offset: 0x0021A902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartBoxingClubBattleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0600C98B RID: 51595 RVA: 0x0021C714 File Offset: 0x0021A914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartBoxingClubBattleScRsp.Descriptor;
			}
		}

		// Token: 0x0600C98C RID: 51596 RVA: 0x0021C71B File Offset: 0x0021A91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBoxingClubBattleScRsp()
		{
		}

		// Token: 0x0600C98D RID: 51597 RVA: 0x0021C724 File Offset: 0x0021A924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBoxingClubBattleScRsp(StartBoxingClubBattleScRsp other) : this()
		{
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C98E RID: 51598 RVA: 0x0021C77C File Offset: 0x0021A97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBoxingClubBattleScRsp Clone()
		{
			return new StartBoxingClubBattleScRsp(this);
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0600C98F RID: 51599 RVA: 0x0021C784 File Offset: 0x0021A984
		// (set) Token: 0x0600C990 RID: 51600 RVA: 0x0021C78C File Offset: 0x0021A98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0600C991 RID: 51601 RVA: 0x0021C795 File Offset: 0x0021A995
		// (set) Token: 0x0600C992 RID: 51602 RVA: 0x0021C79D File Offset: 0x0021A99D
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

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0600C993 RID: 51603 RVA: 0x0021C7A6 File Offset: 0x0021A9A6
		// (set) Token: 0x0600C994 RID: 51604 RVA: 0x0021C7AE File Offset: 0x0021A9AE
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

		// Token: 0x0600C995 RID: 51605 RVA: 0x0021C7B7 File Offset: 0x0021A9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartBoxingClubBattleScRsp);
		}

		// Token: 0x0600C996 RID: 51606 RVA: 0x0021C7C8 File Offset: 0x0021A9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartBoxingClubBattleScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BattleInfo, other.BattleInfo) && this.Retcode == other.Retcode && this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C997 RID: 51607 RVA: 0x0021C828 File Offset: 0x0021AA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C998 RID: 51608 RVA: 0x0021C896 File Offset: 0x0021AA96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C999 RID: 51609 RVA: 0x0021C89E File Offset: 0x0021AA9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C99A RID: 51610 RVA: 0x0021C8A8 File Offset: 0x0021AAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C99B RID: 51611 RVA: 0x0021C920 File Offset: 0x0021AB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C99C RID: 51612 RVA: 0x0021C990 File Offset: 0x0021AB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartBoxingClubBattleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C99D RID: 51613 RVA: 0x0021CA0C File Offset: 0x0021AC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C99E RID: 51614 RVA: 0x0021CA18 File Offset: 0x0021AC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					if (num != 72U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ChallengeId = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.battleInfo_ == null)
					{
						this.BattleInfo = new SceneBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
				}
			}
		}

		// Token: 0x04005145 RID: 20805
		private static readonly MessageParser<StartBoxingClubBattleScRsp> _parser = new MessageParser<StartBoxingClubBattleScRsp>(() => new StartBoxingClubBattleScRsp());

		// Token: 0x04005146 RID: 20806
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005147 RID: 20807
		public const int BattleInfoFieldNumber = 7;

		// Token: 0x04005148 RID: 20808
		private SceneBattleInfo battleInfo_;

		// Token: 0x04005149 RID: 20809
		public const int RetcodeFieldNumber = 9;

		// Token: 0x0400514A RID: 20810
		private uint retcode_;

		// Token: 0x0400514B RID: 20811
		public const int ChallengeIdFieldNumber = 10;

		// Token: 0x0400514C RID: 20812
		private uint challengeId_;
	}
}
