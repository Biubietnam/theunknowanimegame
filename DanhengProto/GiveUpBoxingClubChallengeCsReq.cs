using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200085F RID: 2143
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GiveUpBoxingClubChallengeCsReq : IMessage<GiveUpBoxingClubChallengeCsReq>, IMessage, IEquatable<GiveUpBoxingClubChallengeCsReq>, IDeepCloneable<GiveUpBoxingClubChallengeCsReq>, IBufferMessage
	{
		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06005F50 RID: 24400 RVA: 0x000FC371 File Offset: 0x000FA571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GiveUpBoxingClubChallengeCsReq> Parser
		{
			get
			{
				return GiveUpBoxingClubChallengeCsReq._parser;
			}
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06005F51 RID: 24401 RVA: 0x000FC378 File Offset: 0x000FA578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GiveUpBoxingClubChallengeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06005F52 RID: 24402 RVA: 0x000FC38A File Offset: 0x000FA58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiveUpBoxingClubChallengeCsReq.Descriptor;
			}
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x000FC391 File Offset: 0x000FA591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiveUpBoxingClubChallengeCsReq()
		{
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x000FC399 File Offset: 0x000FA599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiveUpBoxingClubChallengeCsReq(GiveUpBoxingClubChallengeCsReq other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.lCDLBENJGIO_ = other.lCDLBENJGIO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x000FC3CA File Offset: 0x000FA5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiveUpBoxingClubChallengeCsReq Clone()
		{
			return new GiveUpBoxingClubChallengeCsReq(this);
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06005F56 RID: 24406 RVA: 0x000FC3D2 File Offset: 0x000FA5D2
		// (set) Token: 0x06005F57 RID: 24407 RVA: 0x000FC3DA File Offset: 0x000FA5DA
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

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06005F58 RID: 24408 RVA: 0x000FC3E3 File Offset: 0x000FA5E3
		// (set) Token: 0x06005F59 RID: 24409 RVA: 0x000FC3EB File Offset: 0x000FA5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LCDLBENJGIO
		{
			get
			{
				return this.lCDLBENJGIO_;
			}
			set
			{
				this.lCDLBENJGIO_ = value;
			}
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x000FC3F4 File Offset: 0x000FA5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiveUpBoxingClubChallengeCsReq);
		}

		// Token: 0x06005F5B RID: 24411 RVA: 0x000FC402 File Offset: 0x000FA602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiveUpBoxingClubChallengeCsReq other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.LCDLBENJGIO == other.LCDLBENJGIO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F5C RID: 24412 RVA: 0x000FC440 File Offset: 0x000FA640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.LCDLBENJGIO)
			{
				num ^= this.LCDLBENJGIO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x000FC498 File Offset: 0x000FA698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F5E RID: 24414 RVA: 0x000FC4A0 File Offset: 0x000FA6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F5F RID: 24415 RVA: 0x000FC4AC File Offset: 0x000FA6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this.LCDLBENJGIO)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.LCDLBENJGIO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x000FC508 File Offset: 0x000FA708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.LCDLBENJGIO)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x000FC554 File Offset: 0x000FA754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiveUpBoxingClubChallengeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.LCDLBENJGIO)
			{
				this.LCDLBENJGIO = other.LCDLBENJGIO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x000FC5A4 File Offset: 0x000FA7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F63 RID: 24419 RVA: 0x000FC5B0 File Offset: 0x000FA7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LCDLBENJGIO = input.ReadBool();
					}
				}
				else
				{
					this.ChallengeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040024AD RID: 9389
		private static readonly MessageParser<GiveUpBoxingClubChallengeCsReq> _parser = new MessageParser<GiveUpBoxingClubChallengeCsReq>(() => new GiveUpBoxingClubChallengeCsReq());

		// Token: 0x040024AE RID: 9390
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024AF RID: 9391
		public const int ChallengeIdFieldNumber = 11;

		// Token: 0x040024B0 RID: 9392
		private uint challengeId_;

		// Token: 0x040024B1 RID: 9393
		public const int LCDLBENJGIOFieldNumber = 15;

		// Token: 0x040024B2 RID: 9394
		private bool lCDLBENJGIO_;
	}
}
