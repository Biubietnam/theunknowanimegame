using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001A7 RID: 423
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeGroup : IMessage<ChallengeGroup>, IMessage, IEquatable<ChallengeGroup>, IDeepCloneable<ChallengeGroup>, IBufferMessage
	{
		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00037200 File Offset: 0x00035400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeGroup> Parser
		{
			get
			{
				return ChallengeGroup._parser;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x00037207 File Offset: 0x00035407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeGroupReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x00037219 File Offset: 0x00035419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeGroup.Descriptor;
			}
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00037220 File Offset: 0x00035420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeGroup()
		{
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00037228 File Offset: 0x00035428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeGroup(ChallengeGroup other) : this()
		{
			this.groupId_ = other.groupId_;
			this.takenStarsCountReward_ = other.takenStarsCountReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00037259 File Offset: 0x00035459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeGroup Clone()
		{
			return new ChallengeGroup(this);
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x00037261 File Offset: 0x00035461
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x00037269 File Offset: 0x00035469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x00037272 File Offset: 0x00035472
		// (set) Token: 0x06001314 RID: 4884 RVA: 0x0003727A File Offset: 0x0003547A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong TakenStarsCountReward
		{
			get
			{
				return this.takenStarsCountReward_;
			}
			set
			{
				this.takenStarsCountReward_ = value;
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00037283 File Offset: 0x00035483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeGroup);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00037291 File Offset: 0x00035491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeGroup other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.TakenStarsCountReward == other.TakenStarsCountReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000372D0 File Offset: 0x000354D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.TakenStarsCountReward != 0UL)
			{
				num ^= this.TakenStarsCountReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00037328 File Offset: 0x00035528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00037330 File Offset: 0x00035530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0003733C File Offset: 0x0003553C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GroupId);
			}
			if (this.TakenStarsCountReward != 0UL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.TakenStarsCountReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00037394 File Offset: 0x00035594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.TakenStarsCountReward != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.TakenStarsCountReward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000373EC File Offset: 0x000355EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeGroup other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.TakenStarsCountReward != 0UL)
			{
				this.TakenStarsCountReward = other.TakenStarsCountReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0003743C File Offset: 0x0003563C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00037448 File Offset: 0x00035648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TakenStarsCountReward = input.ReadUInt64();
					}
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400080E RID: 2062
		private static readonly MessageParser<ChallengeGroup> _parser = new MessageParser<ChallengeGroup>(() => new ChallengeGroup());

		// Token: 0x0400080F RID: 2063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000810 RID: 2064
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04000811 RID: 2065
		private uint groupId_;

		// Token: 0x04000812 RID: 2066
		public const int TakenStarsCountRewardFieldNumber = 5;

		// Token: 0x04000813 RID: 2067
		private ulong takenStarsCountReward_;
	}
}
