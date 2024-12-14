using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011B9 RID: 4537
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartPartialChallengeCsReq : IMessage<StartPartialChallengeCsReq>, IMessage, IEquatable<StartPartialChallengeCsReq>, IDeepCloneable<StartPartialChallengeCsReq>, IBufferMessage
	{
		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x0600CA9F RID: 51871 RVA: 0x0021F8C5 File Offset: 0x0021DAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartPartialChallengeCsReq> Parser
		{
			get
			{
				return StartPartialChallengeCsReq._parser;
			}
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x0600CAA0 RID: 51872 RVA: 0x0021F8CC File Offset: 0x0021DACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartPartialChallengeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x0600CAA1 RID: 51873 RVA: 0x0021F8DE File Offset: 0x0021DADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartPartialChallengeCsReq.Descriptor;
			}
		}

		// Token: 0x0600CAA2 RID: 51874 RVA: 0x0021F8E5 File Offset: 0x0021DAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPartialChallengeCsReq()
		{
		}

		// Token: 0x0600CAA3 RID: 51875 RVA: 0x0021F8ED File Offset: 0x0021DAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPartialChallengeCsReq(StartPartialChallengeCsReq other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.isFirstHalf_ = other.isFirstHalf_;
			this.buffId_ = other.buffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAA4 RID: 51876 RVA: 0x0021F92A File Offset: 0x0021DB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPartialChallengeCsReq Clone()
		{
			return new StartPartialChallengeCsReq(this);
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0600CAA5 RID: 51877 RVA: 0x0021F932 File Offset: 0x0021DB32
		// (set) Token: 0x0600CAA6 RID: 51878 RVA: 0x0021F93A File Offset: 0x0021DB3A
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

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x0600CAA7 RID: 51879 RVA: 0x0021F943 File Offset: 0x0021DB43
		// (set) Token: 0x0600CAA8 RID: 51880 RVA: 0x0021F94B File Offset: 0x0021DB4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFirstHalf
		{
			get
			{
				return this.isFirstHalf_;
			}
			set
			{
				this.isFirstHalf_ = value;
			}
		}

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x0600CAA9 RID: 51881 RVA: 0x0021F954 File Offset: 0x0021DB54
		// (set) Token: 0x0600CAAA RID: 51882 RVA: 0x0021F95C File Offset: 0x0021DB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x0600CAAB RID: 51883 RVA: 0x0021F965 File Offset: 0x0021DB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartPartialChallengeCsReq);
		}

		// Token: 0x0600CAAC RID: 51884 RVA: 0x0021F974 File Offset: 0x0021DB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartPartialChallengeCsReq other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.IsFirstHalf == other.IsFirstHalf && this.BuffId == other.BuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAAD RID: 51885 RVA: 0x0021F9D0 File Offset: 0x0021DBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.IsFirstHalf)
			{
				num ^= this.IsFirstHalf.GetHashCode();
			}
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CAAE RID: 51886 RVA: 0x0021FA41 File Offset: 0x0021DC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CAAF RID: 51887 RVA: 0x0021FA49 File Offset: 0x0021DC49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CAB0 RID: 51888 RVA: 0x0021FA54 File Offset: 0x0021DC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFirstHalf)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsFirstHalf);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CAB1 RID: 51889 RVA: 0x0021FACC File Offset: 0x0021DCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.IsFirstHalf)
			{
				num += 2;
			}
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x0021FB30 File Offset: 0x0021DD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartPartialChallengeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.IsFirstHalf)
			{
				this.IsFirstHalf = other.IsFirstHalf;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x0021FB94 File Offset: 0x0021DD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x0021FBA0 File Offset: 0x0021DDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 72U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BuffId = input.ReadUInt32();
						}
					}
					else
					{
						this.ChallengeId = input.ReadUInt32();
					}
				}
				else
				{
					this.IsFirstHalf = input.ReadBool();
				}
			}
		}

		// Token: 0x040051B5 RID: 20917
		private static readonly MessageParser<StartPartialChallengeCsReq> _parser = new MessageParser<StartPartialChallengeCsReq>(() => new StartPartialChallengeCsReq());

		// Token: 0x040051B6 RID: 20918
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051B7 RID: 20919
		public const int ChallengeIdFieldNumber = 9;

		// Token: 0x040051B8 RID: 20920
		private uint challengeId_;

		// Token: 0x040051B9 RID: 20921
		public const int IsFirstHalfFieldNumber = 7;

		// Token: 0x040051BA RID: 20922
		private bool isFirstHalf_;

		// Token: 0x040051BB RID: 20923
		public const int BuffIdFieldNumber = 11;

		// Token: 0x040051BC RID: 20924
		private uint buffId_;
	}
}
