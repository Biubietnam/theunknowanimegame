using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001B1 RID: 433
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeRaidNotify : IMessage<ChallengeRaidNotify>, IMessage, IEquatable<ChallengeRaidNotify>, IDeepCloneable<ChallengeRaidNotify>, IBufferMessage
	{
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00038145 File Offset: 0x00036345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeRaidNotify> Parser
		{
			get
			{
				return ChallengeRaidNotify._parser;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0003814C File Offset: 0x0003634C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeRaidNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x0003815E File Offset: 0x0003635E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeRaidNotify.Descriptor;
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00038165 File Offset: 0x00036365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeRaidNotify()
		{
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0003816D File Offset: 0x0003636D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeRaidNotify(ChallengeRaidNotify other) : this()
		{
			this.challengeRaid_ = ((other.challengeRaid_ != null) ? other.challengeRaid_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x000381A2 File Offset: 0x000363A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeRaidNotify Clone()
		{
			return new ChallengeRaidNotify(this);
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x000381AA File Offset: 0x000363AA
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x000381B2 File Offset: 0x000363B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeRaid ChallengeRaid
		{
			get
			{
				return this.challengeRaid_;
			}
			set
			{
				this.challengeRaid_ = value;
			}
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x000381BB File Offset: 0x000363BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeRaidNotify);
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x000381C9 File Offset: 0x000363C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeRaidNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ChallengeRaid, other.ChallengeRaid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x000381FC File Offset: 0x000363FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.challengeRaid_ != null)
			{
				num ^= this.ChallengeRaid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00038238 File Offset: 0x00036438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00038240 File Offset: 0x00036440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00038249 File Offset: 0x00036449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.challengeRaid_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ChallengeRaid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0003827C File Offset: 0x0003647C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.challengeRaid_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChallengeRaid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x000382BC File Offset: 0x000364BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeRaidNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.challengeRaid_ != null)
			{
				if (this.challengeRaid_ == null)
				{
					this.ChallengeRaid = new ChallengeRaid();
				}
				this.ChallengeRaid.MergeFrom(other.ChallengeRaid);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00038310 File Offset: 0x00036510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0003831C File Offset: 0x0003651C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.challengeRaid_ == null)
					{
						this.ChallengeRaid = new ChallengeRaid();
					}
					input.ReadMessage(this.ChallengeRaid);
				}
			}
		}

		// Token: 0x04000830 RID: 2096
		private static readonly MessageParser<ChallengeRaidNotify> _parser = new MessageParser<ChallengeRaidNotify>(() => new ChallengeRaidNotify());

		// Token: 0x04000831 RID: 2097
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000832 RID: 2098
		public const int ChallengeRaidFieldNumber = 12;

		// Token: 0x04000833 RID: 2099
		private ChallengeRaid challengeRaid_;
	}
}
