using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011A1 RID: 4513
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartBoxingClubBattleCsReq : IMessage<StartBoxingClubBattleCsReq>, IMessage, IEquatable<StartBoxingClubBattleCsReq>, IDeepCloneable<StartBoxingClubBattleCsReq>, IBufferMessage
	{
		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0600C974 RID: 51572 RVA: 0x0021C454 File Offset: 0x0021A654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartBoxingClubBattleCsReq> Parser
		{
			get
			{
				return StartBoxingClubBattleCsReq._parser;
			}
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0600C975 RID: 51573 RVA: 0x0021C45B File Offset: 0x0021A65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartBoxingClubBattleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0600C976 RID: 51574 RVA: 0x0021C46D File Offset: 0x0021A66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartBoxingClubBattleCsReq.Descriptor;
			}
		}

		// Token: 0x0600C977 RID: 51575 RVA: 0x0021C474 File Offset: 0x0021A674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBoxingClubBattleCsReq()
		{
		}

		// Token: 0x0600C978 RID: 51576 RVA: 0x0021C47C File Offset: 0x0021A67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBoxingClubBattleCsReq(StartBoxingClubBattleCsReq other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C979 RID: 51577 RVA: 0x0021C4A1 File Offset: 0x0021A6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBoxingClubBattleCsReq Clone()
		{
			return new StartBoxingClubBattleCsReq(this);
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0600C97A RID: 51578 RVA: 0x0021C4A9 File Offset: 0x0021A6A9
		// (set) Token: 0x0600C97B RID: 51579 RVA: 0x0021C4B1 File Offset: 0x0021A6B1
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

		// Token: 0x0600C97C RID: 51580 RVA: 0x0021C4BA File Offset: 0x0021A6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartBoxingClubBattleCsReq);
		}

		// Token: 0x0600C97D RID: 51581 RVA: 0x0021C4C8 File Offset: 0x0021A6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartBoxingClubBattleCsReq other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C97E RID: 51582 RVA: 0x0021C4F8 File Offset: 0x0021A6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600C97F RID: 51583 RVA: 0x0021C537 File Offset: 0x0021A737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C980 RID: 51584 RVA: 0x0021C53F File Offset: 0x0021A73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C981 RID: 51585 RVA: 0x0021C548 File Offset: 0x0021A748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C982 RID: 51586 RVA: 0x0021C57C File Offset: 0x0021A77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600C983 RID: 51587 RVA: 0x0021C5BA File Offset: 0x0021A7BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartBoxingClubBattleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C984 RID: 51588 RVA: 0x0021C5EB File Offset: 0x0021A7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C985 RID: 51589 RVA: 0x0021C5F4 File Offset: 0x0021A7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005140 RID: 20800
		private static readonly MessageParser<StartBoxingClubBattleCsReq> _parser = new MessageParser<StartBoxingClubBattleCsReq>(() => new StartBoxingClubBattleCsReq());

		// Token: 0x04005141 RID: 20801
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005142 RID: 20802
		public const int ChallengeIdFieldNumber = 5;

		// Token: 0x04005143 RID: 20803
		private uint challengeId_;
	}
}
