using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003DF RID: 991
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DrinkMakerChallengeCsReq : IMessage<DrinkMakerChallengeCsReq>, IMessage, IEquatable<DrinkMakerChallengeCsReq>, IDeepCloneable<DrinkMakerChallengeCsReq>, IBufferMessage
	{
		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x0007A6ED File Offset: 0x000788ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DrinkMakerChallengeCsReq> Parser
		{
			get
			{
				return DrinkMakerChallengeCsReq._parser;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x0007A6F4 File Offset: 0x000788F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DrinkMakerChallengeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x0007A706 File Offset: 0x00078906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrinkMakerChallengeCsReq.Descriptor;
			}
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x0007A70D File Offset: 0x0007890D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerChallengeCsReq()
		{
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x0007A718 File Offset: 0x00078918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerChallengeCsReq(DrinkMakerChallengeCsReq other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.oEEHEOKKNGD_ = ((other.oEEHEOKKNGD_ != null) ? other.oEEHEOKKNGD_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x0007A764 File Offset: 0x00078964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerChallengeCsReq Clone()
		{
			return new DrinkMakerChallengeCsReq(this);
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x0007A76C File Offset: 0x0007896C
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x0007A774 File Offset: 0x00078974
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

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x0007A77D File Offset: 0x0007897D
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x0007A785 File Offset: 0x00078985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LGNIOADJNOJ OEEHEOKKNGD
		{
			get
			{
				return this.oEEHEOKKNGD_;
			}
			set
			{
				this.oEEHEOKKNGD_ = value;
			}
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x0007A78E File Offset: 0x0007898E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrinkMakerChallengeCsReq);
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x0007A79C File Offset: 0x0007899C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrinkMakerChallengeCsReq other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this.OEEHEOKKNGD, other.OEEHEOKKNGD) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x0007A7EC File Offset: 0x000789EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.oEEHEOKKNGD_ != null)
			{
				num ^= this.OEEHEOKKNGD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x0007A841 File Offset: 0x00078A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x0007A849 File Offset: 0x00078A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x0007A854 File Offset: 0x00078A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.oEEHEOKKNGD_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.OEEHEOKKNGD);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x0007A8B0 File Offset: 0x00078AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this.oEEHEOKKNGD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OEEHEOKKNGD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x0007A908 File Offset: 0x00078B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrinkMakerChallengeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.oEEHEOKKNGD_ != null)
			{
				if (this.oEEHEOKKNGD_ == null)
				{
					this.OEEHEOKKNGD = new LGNIOADJNOJ();
				}
				this.OEEHEOKKNGD.MergeFrom(other.OEEHEOKKNGD);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x0007A970 File Offset: 0x00078B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x0007A97C File Offset: 0x00078B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 32U)
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
					if (this.oEEHEOKKNGD_ == null)
					{
						this.OEEHEOKKNGD = new LGNIOADJNOJ();
					}
					input.ReadMessage(this.OEEHEOKKNGD);
				}
			}
		}

		// Token: 0x040011D1 RID: 4561
		private static readonly MessageParser<DrinkMakerChallengeCsReq> _parser = new MessageParser<DrinkMakerChallengeCsReq>(() => new DrinkMakerChallengeCsReq());

		// Token: 0x040011D2 RID: 4562
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011D3 RID: 4563
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x040011D4 RID: 4564
		private uint challengeId_;

		// Token: 0x040011D5 RID: 4565
		public const int OEEHEOKKNGDFieldNumber = 3;

		// Token: 0x040011D6 RID: 4566
		private LGNIOADJNOJ oEEHEOKKNGD_;
	}
}
