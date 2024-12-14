using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001B5 RID: 437
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeStageInfo : IMessage<ChallengeStageInfo>, IMessage, IEquatable<ChallengeStageInfo>, IDeepCloneable<ChallengeStageInfo>, IBufferMessage
	{
		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x00038DE9 File Offset: 0x00036FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeStageInfo> Parser
		{
			get
			{
				return ChallengeStageInfo._parser;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x00038DF0 File Offset: 0x00036FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeStageInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00038E02 File Offset: 0x00037002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeStageInfo.Descriptor;
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00038E09 File Offset: 0x00037009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStageInfo()
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00038E11 File Offset: 0x00037011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStageInfo(ChallengeStageInfo other) : this()
		{
			this.bossInfo_ = ((other.bossInfo_ != null) ? other.bossInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00038E46 File Offset: 0x00037046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStageInfo Clone()
		{
			return new ChallengeStageInfo(this);
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x00038E4E File Offset: 0x0003704E
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x00038E56 File Offset: 0x00037056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossInfo BossInfo
		{
			get
			{
				return this.bossInfo_;
			}
			set
			{
				this.bossInfo_ = value;
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00038E5F File Offset: 0x0003705F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeStageInfo);
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00038E6D File Offset: 0x0003706D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeStageInfo other)
		{
			return other != null && (other == this || (object.Equals(this.BossInfo, other.BossInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00038EA0 File Offset: 0x000370A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bossInfo_ != null)
			{
				num ^= this.BossInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00038EDC File Offset: 0x000370DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00038EE4 File Offset: 0x000370E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00038EED File Offset: 0x000370ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bossInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.BossInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00038F20 File Offset: 0x00037120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bossInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BossInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00038F60 File Offset: 0x00037160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeStageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bossInfo_ != null)
			{
				if (this.bossInfo_ == null)
				{
					this.BossInfo = new ChallengeBossInfo();
				}
				this.BossInfo.MergeFrom(other.BossInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00038FB4 File Offset: 0x000371B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00038FC0 File Offset: 0x000371C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.bossInfo_ == null)
					{
						this.BossInfo = new ChallengeBossInfo();
					}
					input.ReadMessage(this.BossInfo);
				}
			}
		}

		// Token: 0x0400084D RID: 2125
		private static readonly MessageParser<ChallengeStageInfo> _parser = new MessageParser<ChallengeStageInfo>(() => new ChallengeStageInfo());

		// Token: 0x0400084E RID: 2126
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400084F RID: 2127
		public const int BossInfoFieldNumber = 7;

		// Token: 0x04000850 RID: 2128
		private ChallengeBossInfo bossInfo_;
	}
}
