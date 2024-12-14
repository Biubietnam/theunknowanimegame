using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001AF RID: 431
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeRaid : IMessage<ChallengeRaid>, IMessage, IEquatable<ChallengeRaid>, IDeepCloneable<ChallengeRaid>, IBufferMessage
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x00037E0C File Offset: 0x0003600C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeRaid> Parser
		{
			get
			{
				return ChallengeRaid._parser;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x00037E13 File Offset: 0x00036013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeRaidReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x00037E25 File Offset: 0x00036025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeRaid.Descriptor;
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00037E2C File Offset: 0x0003602C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeRaid()
		{
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00037E34 File Offset: 0x00036034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeRaid(ChallengeRaid other) : this()
		{
			this.maxScore_ = other.maxScore_;
			this.raidId_ = other.raidId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00037E65 File Offset: 0x00036065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeRaid Clone()
		{
			return new ChallengeRaid(this);
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x00037E6D File Offset: 0x0003606D
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x00037E75 File Offset: 0x00036075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x00037E7E File Offset: 0x0003607E
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x00037E86 File Offset: 0x00036086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RaidId
		{
			get
			{
				return this.raidId_;
			}
			set
			{
				this.raidId_ = value;
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00037E8F File Offset: 0x0003608F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeRaid);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00037E9D File Offset: 0x0003609D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeRaid other)
		{
			return other != null && (other == this || (this.MaxScore == other.MaxScore && this.RaidId == other.RaidId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00037EDC File Offset: 0x000360DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxScore != 0U)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00037F34 File Offset: 0x00036134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00037F3C File Offset: 0x0003613C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00037F48 File Offset: 0x00036148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RaidId);
			}
			if (this.MaxScore != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MaxScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00037FA4 File Offset: 0x000361A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxScore);
			}
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00037FFC File Offset: 0x000361FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeRaid other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxScore != 0U)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0003804C File Offset: 0x0003624C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00038058 File Offset: 0x00036258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxScore = input.ReadUInt32();
					}
				}
				else
				{
					this.RaidId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000829 RID: 2089
		private static readonly MessageParser<ChallengeRaid> _parser = new MessageParser<ChallengeRaid>(() => new ChallengeRaid());

		// Token: 0x0400082A RID: 2090
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400082B RID: 2091
		public const int MaxScoreFieldNumber = 6;

		// Token: 0x0400082C RID: 2092
		private uint maxScore_;

		// Token: 0x0400082D RID: 2093
		public const int RaidIdFieldNumber = 4;

		// Token: 0x0400082E RID: 2094
		private uint raidId_;
	}
}
